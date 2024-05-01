Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_collection_billing_statement_new


    '--- ONLOAD ----
    Private Sub frm_collection_soa_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub




    '--- FUNCTIONS ---

    'Load Customers
    Private Sub LoadCustomers()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT first_name FROM ims_customers", connection)
                Dim rdr = cmd.ExecuteReader

                While rdr.Read
                    cbb_customers.Properties.Items.Add(rdr("first_name"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'LOAD SALES RETURN
    Public Sub SalesReturnsLoad(customer As String)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT CONCAT('SR', LPAD(sales_return_id, 5, '0')) AS srid, ims_customers.first_name AS customer, amount, created_at
                                        FROM ims_sales_returns
                                        LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                                        WHERE ims_sales_returns.is_deleted=0 AND ims_sales_returns.is_applied=0 AND status='Received'
                                        AND ims_customers.first_name=@customer", conn)
                    cmd.Parameters.AddWithValue("@customer", customer)
                    Dim da = New MySqlDataAdapter(cmd)
                    Dim dt = New DataTable
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub




    '--- CONTROLS ----

    'btn_cancel | Dispose ME
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'btn_generate | Start to Generate
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click

        Dim OrderRows = grid_orders_view.GetSelectedRows
        Dim ReturnsRow = grid_returns_view.GetSelectedRows
        Dim selected_index As Integer = cbb_customers.SelectedIndex

        'Validation
        If OrderRows.Length = 0 Then
            MsgBox("No order is selected!", vbCritical, "No Order")
            Exit Sub
        End If

        Dim ans = MsgBox("Press 'YES' to continue", vbInformation + vbYesNo, "Confirmation")
        If ans = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim ListOfStatements = New List(Of BillingStatementClass)

                    'For Each row As DataRow In DirectCast(grid_orders.DataSource, DataTable).Rows
                    '    ListOfStatements.Add(New BillingStatementClass With {
                    '        .OrderID = row.Item("order_id"),
                    '        .DateReleased = row.Item("date_released"),
                    '        .DueDate = row.Item("due_date"),
                    '        .Amount = row.Item("amount_due"),
                    '        .PaidAmount = row.Item("paid_amount"),
                    '        .Balance = row.Item("balance"),
                    '        .PORef = row.Item("po_reference")
                    '    })
                    'Next

                    For Each rowIndex In grid_orders_view.GetSelectedRows
                        ListOfStatements.Add(New BillingStatementClass With {
                            .OrderID = grid_orders_view.GetRowCellValue(rowIndex, col_orderid),
                            .DateReleased = grid_orders_view.GetRowCellValue(rowIndex, col_date_of_order),
                            .DueDate = grid_orders_view.GetRowCellValue(rowIndex, col_due_date),
                            .Amount = grid_orders_view.GetRowCellValue(rowIndex, col_sales_total),
                            .PaidAmount = grid_orders_view.GetRowCellValue(rowIndex, col_sales_paid_amount),
                            .Balance = grid_orders_view.GetRowCellValue(rowIndex, col_sales_balance),
                            .PORef = grid_orders_view.GetRowCellValue(rowIndex, col_sales_poref)
                        })
                    Next

                    Dim insert_cmd = New MySqlCommand("INSERT INTO ims_soa (customer_id, statements, print_date, total, prepared_by) 
                                VALUES ((SELECT customer_id FROM ims_customers WHERE first_name=@customer_name), @statements, CURRENT_TIMESTAMP, @total, @prepared_by)", connection)
                    insert_cmd.Parameters.AddWithValue("@customer_name", cbb_customers.Text.Trim)
                    insert_cmd.Parameters.AddWithValue("@statements", JsonConvert.SerializeObject(ListOfStatements))
                    insert_cmd.Parameters.AddWithValue("@total", CDec(txt_total_view.Text))
                    insert_cmd.Parameters.AddWithValue("@prepared_by", frm_main.lbl_user_id.Text)
                    If insert_cmd.ExecuteNonQuery() > 0 Then

                        'UPDATE SALES ORDERS
                        Using cmd = New MySqlCommand("UPDATE ims_orders SET soa_id=@soa_id WHERE order_id=@order_id", connection)
                            cmd.Parameters.AddWithValue("@soa_id", insert_cmd.LastInsertedId)
                            cmd.Parameters.AddWithValue("@order_id", 0)
                            cmd.Prepare()

                            For i = 0 To OrderRows.Length - 1
                                cmd.Parameters(1).Value = CInt(grid_orders_view.GetRowCellValue(OrderRows(i), col_orderid).ToString.Replace("SO", String.Empty))
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        'UPDATE RETURNS
                        Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET soa_id=@soa_id WHERE sales_return_id=@sales_return_id", connection)
                            cmd.Parameters.AddWithValue("@soa_id", insert_cmd.LastInsertedId)
                            cmd.Parameters.AddWithValue("@sales_return_id", 0)
                            cmd.Prepare()

                            For i = 0 To ReturnsRow.Length - 1
                                cmd.Parameters(1).Value = CInt(grid_returns_view.GetRowCellValue(ReturnsRow(i), col_srid).ToString.Replace("SR", String.Empty))
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        connection.Close()

                        If MsgBox("Successfully Generated!" & vbCrLf & "Print Billing Statement?", vbInformation + vbYesNo, "Confirmation") = vbYes Then
                            frm_collection_billing_statement.Print_BillingStatement(insert_cmd.LastInsertedId)
                        End If

                        'RELOAD COLLECTION SOA
                        Me.DialogResult = DialogResult.OK
                    End If

                End Using

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'Show Orders based on Customer
    Private Sub cbb_customers_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_customers.EditValueChanged
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT concat('SO',LPAD(order_id,5,0)) as order_id, 
                                    date_released, 
                                    DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) as due_date, 
                                    amount_due, paid_amount, (amount_due - paid_amount) balance, po_reference
                                    FROM ims_orders 
                                    INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                                    WHERE first_name=@customer_name AND (payment_status='UNPAID' OR payment_status='PARTIAL') AND deleted=0", connection)
                cmd.Parameters.AddWithValue("@customer_name", cbb_customers.Text.Trim)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_orders.DataSource = dt

                SalesReturnsLoad(cbb_customers.Text.Trim)
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'On Grid_Orders selection changed
    Private Sub grid_orders_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_orders_view.SelectionChanged
        Dim trancs_selectedRowHandles = grid_orders_view.GetSelectedRows
        Dim returns_selectedRowHandles = grid_returns_view.GetSelectedRows
        Dim amount As Decimal = 0.00

        For i = 0 To trancs_selectedRowHandles.Length - 1
            amount += grid_orders_view.GetRowCellValue(trancs_selectedRowHandles(i), col_sales_balance)
        Next

        For i = 0 To returns_selectedRowHandles.Length - 1
            amount -= grid_returns_view.GetRowCellValue(returns_selectedRowHandles(i), col_returns_total)
        Next

        txt_total_view.Text = FormatCurrency(amount, 2)

    End Sub

    Private lockSelection As Boolean = False
    Private Sub grid_returns_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_returns_view.SelectionChanged

        'RESTRICT TO ONE ROW SELECTION ONLY
        'If lockSelection Then Return
        'Dim selectedRows() As Integer = grid_returns_view.GetSelectedRows()
        'lockSelection = True
        'For Each selectedRow As Integer In selectedRows
        '    If selectedRow <> e.ControllerRow Then
        '        grid_returns_view.UnselectRow(selectedRow)
        '    End If
        'Next selectedRow
        'lockSelection = False

        'COMPUTE TOTAL
        Dim trancs_selectedRowHandles = grid_orders_view.GetSelectedRows
        Dim returns_selectedRowHandles = grid_returns_view.GetSelectedRows
        Dim amount As Decimal = 0.00

        'GET TOTAL TRANS AMOUNT
        For i = 0 To trancs_selectedRowHandles.Length - 1
            amount += grid_orders_view.GetRowCellValue(trancs_selectedRowHandles(i), col_sales_balance)
        Next

        'DEDUCT TOTAL RETURNS AMOUNT
        For i = 0 To returns_selectedRowHandles.Length - 1
            amount -= grid_returns_view.GetRowCellValue(returns_selectedRowHandles(i), col_returns_total)
        Next

        txt_total_view.Text = FormatCurrency(amount, 2)

    End Sub
End Class

Public Class BillingStatementClass
    Public Property OrderID As String
    Public Property DateReleased As Date
    Public Property DueDate As Date
    Public Property Amount As Decimal
    Public Property PaidAmount As Decimal
    Public Property Balance As Decimal
    Public Property PORef As String
End Class