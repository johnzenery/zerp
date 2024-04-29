Imports DevExpress.Pdf.Interop
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json
Imports System.Globalization

Public Class frm_collection_payment_terms

    'Public Property customer_id As Integer = 0
    'Public Property customer_name As String = String.Empty
    Public Property soa_id As Integer = 0

    Dim dt_cheque As New DataTable
    Dim itemsObject As String
    Dim ListOfItem As List(Of ChequesClass) = New List(Of ChequesClass)
    Dim ccdata As New CollectionChequeData
    Dim Old_Billing_Statement_id As Integer = 0
    Dim Billing_Statement_id As Integer = 0
    Dim Orders_Count As Integer = 0

    '--- ONLOAD ---
    Private Sub frm_accounting_cheque_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt_cheque.Columns.Add("cheque_no")
        dt_cheque.Columns.Add("cheque_date")
        dt_cheque.Columns.Add("cheque_amount")
        dt_cheque.Columns.Add("acc_no")
        dt_cheque.Columns.Add("acc_name")
        dt_cheque.Columns.Add("payee")
        dt_cheque.Columns.Add("bank")
        grid_cheque.DataSource = dt_cheque
        LoadPayee()

        cbb_bank.Enabled = False
    End Sub



    '--- FUNCTIONS ---

    'Load Banks
    Private Sub LoadPayee()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT payee_name FROM ims_cheque_collections GROUP BY payee_name", connection)
                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            cbb_payee.Properties.Items.Add(rdr("payee_name"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Banks
    Private Sub LoadBankOpt(cid As Integer)
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using mySqlCommand = New MySqlCommand("SELECT banks FROM ims_customers WHERE customer_id=" & cid, connection)
                    Using rdr = mySqlCommand.ExecuteReader()
                        While rdr.Read()
                            If Not IsDBNull(rdr("banks")) Then
                                itemsObject = rdr("banks")
                                For Each item In JsonConvert.DeserializeObject(Of List(Of SalesCustomerBankAccounts))(itemsObject)
                                    cbb_bank.Properties.Items.Add(item.bank)
                                Next
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Transactions
    Private Sub LoadTransactions(cid As Integer)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT po_reference, order_id, invoice_no,
                            date_ordered, DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) as due_date, 
                            amount_due, paid_amount, (amount_due - paid_amount) balance, payment_type 
                            FROM ims_orders 
                            WHERE payment_type='Terms' AND payment_status='UNPAID' AND NOT status='Cancelled' AND customer='" & cid & "' AND deleted=0", connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_transaction.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load Returns
    Private Sub LoadReturns(cid As Integer)
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT CONCAT('SR', LPAD(sales_return_id, 5, '0')) AS srid, ims_customers.first_name AS customer, amount, created_at
                                        FROM ims_sales_returns
                                        LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                                        WHERE ims_sales_returns.is_deleted=0 AND ims_sales_returns.is_applied=0 AND status='Received'
                                        AND ims_sales_returns.customer_id=" & cid, connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_returns.DataSource = dt

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'COMPUTE
    Private Sub Compute()

        Dim trancs_selectedRowHandles = grid_transaction_view.GetSelectedRows
        Dim returns_selectedRowHandles = grid_returns_view.GetSelectedRows
        Dim transactions_total_amount As Decimal = 0.00
        Dim returns_total_amount As Decimal = 0.00

        'GET TOTAL AMOUNT OF TRANSACTIONS
        For i = 0 To trancs_selectedRowHandles.Length - 1
            transactions_total_amount += grid_transaction_view.GetRowCellValue(trancs_selectedRowHandles(i), col_balance)
        Next

        'GET TOTAL AMOUNT OF SALES RETURNS
        For i = 0 To returns_selectedRowHandles.Length - 1
            returns_total_amount += grid_returns_view.GetRowCellValue(returns_selectedRowHandles(i), col_return_amount)
        Next

        'DISPLAY TOTAL
        If trancs_selectedRowHandles.Length = 0 And returns_selectedRowHandles.Length = 0 Then
            txt_total.Text = FormatCurrency(0)
        Else
            txt_total.Text = FormatCurrency(transactions_total_amount - returns_total_amount)
        End If

    End Sub






    '--- CONTROLS ---

    'Grid Transaction Selection
    Private Sub grid_transaction_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_transaction_view.SelectionChanged

        Compute()

        'Dim trancs_selectedRowHandles = grid_transaction_view.GetSelectedRows
        'Dim returns_selectedRowHandles = grid_returns_view.GetSelectedRows
        'Dim amount = 0.00

        'For i = 0 To trancs_selectedRowHandles.Length - 1
        '    amount += grid_transaction_view.GetRowCellValue(trancs_selectedRowHandles(i), col_amount)
        '    txt_total.Text = FormatCurrency(amount, 2)
        'Next

        'Old_Billing_Statement_id = Billing_Statement_id
        'If trancs_selectedRowHandles.Length = Orders_Count Then
        '    Billing_Statement_id = Old_Billing_Statement_id
        'Else
        '    Billing_Statement_id = 0
        'End If

        'If Not returns_selectedRowHandles.Length = 0 Then
        '    txt_total.Text = FormatCurrency(CDec(txt_total.Text) - grid_returns_view.GetRowCellValue(returns_selectedRowHandles(0), col_return_amount))
        'End If

    End Sub

    'Grid Return Selection
    Private lockSelection As Boolean = False
    Private Sub grid_returns_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_returns_view.SelectionChanged

        Compute()

        '### SELECT ONLY 1 RETURN
        'If lockSelection Then
        '    Return
        'End If

        'Dim view As GridView = TryCast(sender, GridView)
        'Dim selectedRows() As Integer = grid_returns_view.GetSelectedRows()
        'lockSelection = True
        'For Each selectedRow As Integer In selectedRows
        '    If selectedRow <> e.ControllerRow Then
        '        view.UnselectRow(selectedRow)
        '    End If
        'Next selectedRow
        'lockSelection = False

    End Sub

    'btn_select
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        ccdata.customer_id = 0
        txt_total.Text = String.Empty

        Dim frm_dialog = New frm_collection_cheque_customer
        frm_dialog.ccdata = ccdata
        If frm_dialog.ShowDialog() = DialogResult.OK Then

            If Not IsNothing(grid_cheque.DataSource) Then
                Dim dt = TryCast(grid_cheque.DataSource, DataTable)
                dt.Rows.Clear()
                grid_cheque.DataSource = dt
            End If

            cbb_bank.Enabled = True
            lbl_customer_id.Text = ccdata.customer_id 'customer_id
            txt_customer_name.Text = ccdata.customer_name
            LoadBankOpt(ccdata.customer_id)
            LoadTransactions(ccdata.customer_id)
            LoadReturns(ccdata.customer_id)

            lbl_indicator.Visible = False

        End If

    End Sub


    'btn_close
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'btn_apply
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click

        'Customer Validation
        If String.IsNullOrWhiteSpace(txt_customer_name.Text) Then
            MsgBox("Select Customer first!", vbCritical, "Required")
            Exit Sub
        End If

        ':Transactions
        If grid_transaction_view.GetSelectedRows.Length <= 0 Then
            MsgBox("No Selected Transaction Found!", vbCritical, "No Transaction")
            Exit Sub
        ElseIf grid_cheque_view.RowCount <= 0 Then
            MsgBox("No Cheque Details Found!", vbCritical, "No Cheque")
            Exit Sub
        End If

        'Get total
        Dim total As Decimal = 0.00
        For i = 0 To grid_cheque_view.RowCount - 1
            total += CDec(grid_cheque_view.GetRowCellValue(i, col_cheque_amount))
        Next

        'If not Tally | 1 peso 
        If Math.Abs(total) < Math.Abs(txt_total.Text - 1) Or Math.Abs(total) > Math.Abs(txt_total.Text + 1) Then
            MsgBox("Total amount of Cheque(s) is NOT equal to Transaction(s) total." & vbCrLf & vbCrLf _
                   & "Total Cheque(s) Amount: " & total & vbCrLf _
                   & "Total Transaction(s) Amount: " & CDec(txt_total.Text), vbCritical, "Not Equal")
            Exit Sub
        End If

        'After Validation
        If MsgBox("Proceed to Create Cheque Payment?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            Try

                'Declarations
                Dim ListOfOrders As New List(Of SalesOrdersModel)
                Dim orders = String.Empty, cheque_number = String.Empty, cheque_date = String.Empty
                Dim selectedRowHandles = grid_transaction_view.GetSelectedRows
                Dim sales_returns As New List(Of Integer)

                'GET SALES ORDERS
                For i = 0 To selectedRowHandles.Length - 1
                    If i = selectedRowHandles.Length - 1 Then
                        orders = String.Concat(orders, grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id))
                    Else
                        orders = String.Concat(orders, grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id), ",")
                    End If

                    ListOfOrders.Add(New SalesOrdersModel With {
                                    .So_no = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id),
                                    .Invoice_no = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_invoice),
                                    .DR_no = String.Empty,
                                    .Due_Date = IIf(IsDBNull(grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_due_date)), Nothing, grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_due_date)),
                                    .Balance = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_balance)
                                })

                Next


                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim transc = connection.BeginTransaction

                    Try

                        'INSERT CHEQUE
                        Using cheque_cmd = New MySqlCommand("INSERT INTO ims_cheque_collections (cheque_date, cheque_no, amount, acc_name, acc_no, payee_name, customer_id, orders, bank, status, entry_date, collected_by) 
                                            VALUES (@cheque_date, @cheque_no, @amount, @acc_name, @acc_no, @payee_name, @customer_id, @orders, @bank, @status, @entry_date, @collected_by)", connection, transc)
                            cheque_cmd.Parameters.AddWithValue("@cheque_no", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@cheque_date", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@amount", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@bank", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@acc_no", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@acc_name", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@payee_name", String.Empty)
                            cheque_cmd.Parameters.AddWithValue("@orders", orders)
                            cheque_cmd.Parameters.AddWithValue("@customer_id", lbl_customer_id.Text)
                            cheque_cmd.Parameters.AddWithValue("@entry_date", Date.Today)
                            cheque_cmd.Parameters.AddWithValue("@status", "RECEIVED")
                            cheque_cmd.Parameters.AddWithValue("@collected_by", frm_main.lbl_user_id.Text)
                            cheque_cmd.Prepare()

                            For i = 0 To grid_cheque_view.RowCount - 1
                                Dim intRow = grid_cheque_view.GetVisibleRowHandle(i)
                                cheque_cmd.Parameters(0).Value = grid_cheque_view.GetRowCellValue(intRow, col_cheque_no)
                                cheque_cmd.Parameters(1).Value = Date.ParseExact(grid_cheque_view.GetRowCellValue(intRow, col_cheque_date), "MM/dd/yyyy", CultureInfo.InvariantCulture).ToString("yyyy/MM/dd")
                                cheque_cmd.Parameters(2).Value = CDec(grid_cheque_view.GetRowCellValue(intRow, col_cheque_amount))
                                cheque_cmd.Parameters(3).Value = grid_cheque_view.GetRowCellValue(intRow, col_bank)
                                cheque_cmd.Parameters(4).Value = grid_cheque_view.GetRowCellValue(intRow, col_acc_no)
                                cheque_cmd.Parameters(5).Value = grid_cheque_view.GetRowCellValue(intRow, col_acc_name)
                                cheque_cmd.Parameters(6).Value = grid_cheque_view.GetRowCellValue(intRow, col_payee)
                                cheque_cmd.Parameters(7).Value = orders
                                cheque_cmd.Parameters(8).Value = lbl_customer_id.Text
                                cheque_cmd.ExecuteNonQuery()

                                If i = grid_cheque_view.RowCount - 1 Then
                                    cheque_number += grid_cheque_view.GetRowCellValue(intRow, col_cheque_no)
                                Else
                                    cheque_number += grid_cheque_view.GetRowCellValue(intRow, col_cheque_no) & ", "
                                End If
                            Next

                        End Using

                        Dim collection_ref_id As Integer = 0
                        'INSERT TO IMS_COLLECTION_RECEIPT
                        Using cmd_collection = New MySqlCommand("INSERT INTO ims_collection_receipts (customer_id, sales_orders, cheques, date_generated, collected_by, billing_id) 
                                            VALUES (@customer_id, @sales_orders, @cheques, NOW(), @collected_by, @billing_id)", connection, transc)

                            'GET CHEQUES
                            For i = 0 To grid_cheque_view.RowCount - 1
                                ListOfItem.Add(New ChequesClass With {
                                    .cheque_no = grid_cheque_view.GetRowCellValue(i, col_cheque_no),
                                    .cheque_date = Date.ParseExact(grid_cheque_view.GetRowCellValue(i, col_cheque_date), "MM/dd/yyyy", CultureInfo.InvariantCulture),
                                    .bank = grid_cheque_view.GetRowCellValue(i, col_bank),
                                    .amount = grid_cheque_view.GetRowCellValue(i, col_cheque_amount),
                                    .acc_no = grid_cheque_view.GetRowCellValue(i, col_acc_no),
                                    .acc_name = grid_cheque_view.GetRowCellValue(i, col_acc_name),
                                    .payee_name = grid_cheque_view.GetRowCellValue(i, col_payee)
                                })
                            Next

                            cmd_collection.Parameters.AddWithValue("@customer_id", lbl_customer_id.Text)
                            'cmd_collection.Parameters.AddWithValue("@so_nos", orders)
                            cmd_collection.Parameters.AddWithValue("@sales_orders", JsonConvert.SerializeObject(ListOfOrders))
                            cmd_collection.Parameters.AddWithValue("@cheques", JsonConvert.SerializeObject(ListOfItem))
                            cmd_collection.Parameters.AddWithValue("@collected_by", frm_main.lbl_user_id.Text)
                            cmd_collection.Parameters.AddWithValue("@billing_id", Billing_Statement_id)
                            cmd_collection.ExecuteNonQuery()

                            collection_ref_id = cmd_collection.LastInsertedId

                        End Using

                        'UPDATE SALES RETURN
                        Dim credit_ref = "CR" & collection_ref_id.ToString.PadLeft(5, "0"c)

                        For Each rowHandles In grid_returns_view.GetSelectedRows
                            Dim srid As Integer = grid_returns_view.GetRowCellValue(rowHandles, col_srid).ToString.Replace("SR", String.Empty)
                            sales_returns.Add(srid)
                            Update_SalesReturns(srid, credit_ref, collection_ref_id, connection, transc)
                        Next


                        'UPDATE ORDERS --->>>''IF((status='Released' AND shipping_method='Deliver'), 'Completed', status)
                        For i = 0 To selectedRowHandles.Length - 1
                            Dim id = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_id)
                            Dim amount As Decimal = grid_transaction_view.GetRowCellValue(selectedRowHandles(i), col_balance)

                            Dim order_cmd = New MySqlCommand("UPDATE ims_orders 
                                            SET paid_amount=paid_amount + @amount, balance=amount_due - paid_amount,
                                            payment_option=@option, payment_details=@details, 
                                            collection_id=@collection_id,
                                            status='Completed', payment_status='PAID'
                                            WHERE order_id=" & id, connection, transc)
                            order_cmd.Parameters.AddWithValue("@option", "Cheque")
                            order_cmd.Parameters.AddWithValue("@amount", amount)
                            order_cmd.Parameters.AddWithValue("@collection_id", collection_ref_id)
                            order_cmd.Parameters.AddWithValue("@details", Date.Today & " - " & cheque_number)
                            order_cmd.ExecuteNonQuery()
                        Next

                        'UPDATE CUSTOMER'S CREDIT LIMIT
                        Using cmd = New MySqlCommand("UPDATE ims_customers  
                                            SET used_credit=used_credit-@return_amount
                                            WHERE customer_id=@cid", connection, transc)
                            cmd.Parameters.AddWithValue("@cid", lbl_customer_id.Text)
                            cmd.Parameters.AddWithValue("@return_amount", CDec(txt_total.Text))
                            cmd.ExecuteNonQuery()
                        End Using

                        transc.Commit()

                        'PRINT COLLECTION RECEIPT
                        frm_collection_receipts.Print_Collection_Receipt(collection_ref_id)


                        MsgBox("Order(s) has been marked as PAID!", vbInformation, "Success")
                        Me.Close()

                        connection.Close()

                    Catch ex As Exception
                        transc.Rollback()
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        'Validate
        If String.IsNullOrWhiteSpace(txt_no.Text) Or String.IsNullOrWhiteSpace(txt_amount.Text) Or String.IsNullOrWhiteSpace(dt_date.Text) Or String.IsNullOrWhiteSpace(cbb_bank.Text) Then
            MsgBox("Incomplete cheque details!", vbCritical, "Required")
            Exit Sub
        End If

        Dim dataSource As DataTable = TryCast(grid_cheque.DataSource, DataTable)
        dataSource.Rows.Add(New Object() {txt_no.Text, dt_date.Text, FormatCurrency(CDec(txt_amount.Text)), txt_acc_no.Text, txt_acc_name.Text, cbb_payee.Text, cbb_bank.Text})
        grid_cheque.DataSource = dataSource
        txt_no.Text = String.Empty
        txt_amount.Text = String.Empty
        dt_date.Text = String.Empty
        txt_acc_no.Text = String.Empty
        txt_acc_name.Text = String.Empty
        cbb_payee.Text = String.Empty
        cbb_bank.Text = String.Empty
        ComputeTotal()

    End Sub

    'Compute Total
    Private Sub ComputeTotal()
        Dim total As Decimal = 0.00
        For i = 0 To grid_cheque_view.RowCount - 1
            total = Decimal.Add(total, grid_cheque_view.GetRowCellValue(i, col_cheque_amount))
        Next

        lbl_total_amount_cheques.Text = FormatCurrency(total, 2)

    End Sub

    'btn_delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If grid_cheque_view.RowCount > 0 Then
            grid_cheque_view.DeleteSelectedRows()
            ComputeTotal()
        End If

    End Sub

    Private Sub cbb_bank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_bank.SelectedIndexChanged
        For Each item In JsonConvert.DeserializeObject(Of List(Of SalesCustomerBankAccounts))(itemsObject)
            If cbb_bank.EditValue.Equals(item.bank) Then
                txt_acc_no.Text = item.bank_acc_no
                txt_acc_name.Text = item.bank_acc_name
                Return
            Else
                txt_acc_no.Text = String.Empty
                txt_acc_name.Text = String.Empty
            End If
        Next

    End Sub

    'Show SOA Dialog Selector
    Private Sub btn_select_from_soa_Click(sender As Object, e As EventArgs) Handles btn_select_from_soa.Click
        Dim frm = New frm_collection_SelectFromBilling_dialog
        frm.ccdata = ccdata

        If frm.ShowDialog() = DialogResult.OK Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT order_id, po_reference, date_ordered, DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) as due_date,
                            amount_due, paid_amount, balance, invoice_no
                            FROM ims_orders 
                            WHERE (payment_type='cheque' OR payment_type='terms' OR  payment_type='CEC') AND (payment_status='UNPAID' OR payment_status='PARTIAL') AND NOT status='Cancelled' AND soa_id='" & ccdata.billing_id & "' AND deleted=0", conn)
                        cmd.ExecuteNonQuery()

                        Dim dt = New DataTable
                        Dim da = New MySqlDataAdapter(cmd)
                        da.Fill(dt)

                        grid_transaction.DataSource = dt
                        Billing_Statement_id = ccdata.billing_id
                        Orders_Count = dt.Rows.Count

                        'Select All Rows
                        For i = 0 To grid_transaction_view.RowCount - 1
                            grid_transaction_view.SelectRow(i)
                        Next

                        cbb_bank.Enabled = True
                        lbl_customer_id.Text = ccdata.customer_id 'customer_id
                        txt_customer_name.Text = ccdata.customer_name
                        LoadBankOpt(ccdata.customer_id)
                        LoadReturns(ccdata.customer_id)

                        lbl_indicator.Visible = True
                        lbl_indicator.Text = "**Loaded unpaid and partially paid accounts from Billling No. " & ccdata.billing_id

                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class

Public Class CollectionChequeData
    Public Property customer_id As Integer = 0
    Public Property billing_id As Integer = 0
    Public Property customer_name As String = String.Empty
End Class
