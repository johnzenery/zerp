Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_collection_soa_new

    ReadOnly conn As New MySqlConnection(str)




    '--- ONLOAD ----
    Private Sub frm_collection_soa_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomers()
    End Sub




    '--- FUNCTIONS ---

    'Load Customers
    Private Sub LoadCustomers()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT first_name FROM ims_customers", conn)
            Dim rdr = cmd.ExecuteReader

            While rdr.Read
                cbb_customers.Properties.Items.Add(rdr("first_name"))
            End While

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Print SOA
    Private Sub PrintSOA(soa_id As Integer)

        Try
            Dim report = New doc_soa()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            conn.Open()
            Dim cmd = New MySqlCommand("SELECT date_released, DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) AS due_date,
                        CONCAT('SO',LPAD(order_id,5,0)) AS order_id, amount_due FROM ims_orders
                        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer WHERE soa_id=@soa_id", conn)
            cmd.Parameters.AddWithValue("@soa_id", soa_id)
            Dim rdr = cmd.ExecuteReader

            While rdr.Read
                table.soa.Rows.Add(rdr("order_id"), rdr("date_released"), rdr("due_date"), rdr("amount_due"))
            End While
            rdr.Close()

            report.DataSource = table

            Dim get_soa_details = New MySqlCommand("SELECT concat('SA',LPAD(soa_id,5,0)) as soa, ims_customers.first_name as customer, ims_customers.address, 
                            ims_customers.contact_person, print_date, total, ims_users.first_name as prepared_by,
                            (SELECT value FROM ims_settings WHERE name='store_info') as store_info FROM ims_soa
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_soa.customer_id
                            INNER JOIN ims_users ON ims_users.usr_id=prepared_by ORDER BY soa_id ASC", conn)
            Dim reader = get_soa_details.ExecuteReader

            While reader.Read
                report.Parameters("store_info").Value = reader("store_info")
                report.Parameters("soa_id").Value = "SA" & soa_id.ToString.PadLeft(5, "0"c)
                report.Parameters("customer").Value = reader("customer")
                report.Parameters("attn").Value = reader("contact_person")
                report.Parameters("print_date").Value = reader("print_date")
                report.Parameters("addr").Value = reader("address")
                report.Parameters("prepared_by").Value = reader("prepared_by")
                report.Parameters("total").Value = reader("total")
            End While

            printTool.AutoShowParametersPanel = False
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub




    '--- CONTROLS ----

    'btn_cancel | Dispose ME
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub

    'btn_generate | Start to Generate
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click

        Dim SelectedRows = grid_orders_view.GetSelectedRows
        Dim selected_index As Integer = cbb_customers.SelectedIndex

        'Validation
        If SelectedRows.Length = 0 Then
            MsgBox("No order is selected.", vbCritical, "No Order")
            Exit Sub
        End If

        Dim ans = MsgBox("Press 'YES' to continue", vbInformation + vbYesNo, "Confirmation")
        If ans = vbYes Then

            Try
                conn.Open()
                Dim get_cmd = New MySqlCommand("SELECT count(*) FROM ims_soa", conn)
                Dim count = get_cmd.ExecuteScalar

                Dim cmd = New MySqlCommand("UPDATE ims_orders SET soa_id=@soa_id WHERE order_id=@order_id", conn)
                cmd.Parameters.AddWithValue("@soa_id", count + 1)
                cmd.Parameters.AddWithValue("@order_id", 0)
                cmd.Prepare()

                For i = 0 To SelectedRows.Length - 1
                    cmd.Parameters(1).Value = CInt(grid_orders_view.GetRowCellValue(SelectedRows(i), col_orderid).ToString.Replace("SO", ""))
                    cmd.ExecuteNonQuery()
                Next

                Dim insert_cmd = New MySqlCommand("INSERT INTO ims_soa (customer_id, print_date, total, prepared_by) 
                                VALUES ((SELECT customer_id FROM ims_customers WHERE first_name=@customer_name), CURRENT_TIMESTAMP, @total, @prepared_by)", conn)
                insert_cmd.Parameters.AddWithValue("@customer_name", cbb_customers.Text.Trim)
                insert_cmd.Parameters.AddWithValue("@total", CDec(txt_total_view.Text))
                insert_cmd.Parameters.AddWithValue("@prepared_by", frm_main.user_id.Text)
                insert_cmd.ExecuteNonQuery()

                Dim print_soa = MsgBox("Successfully Generated!" & vbCrLf & "Print Generated SOA?", vbInformation + vbYesNo, "Confirmation")
                If print_soa = vbYes Then

                    conn.Close()

                    'Print Soa IF YES
                    PrintSOA(count + 1)
                End If

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try

        End If

    End Sub

    'Show Orders based on Customer
    Private Sub cbb_customers_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_customers.EditValueChanged
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT concat('SO',LPAD(order_id,5,0)) as order_id, 
                                    date_released, 
                                    DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) as due_date, 
                                    amount_due FROM ims_orders 
                                    INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                                    WHERE first_name=@customer_name AND payment_status='UNPAID' AND date_released IS NOT NULL AND deleted=0", conn)
            cmd.Parameters.AddWithValue("@customer_name", cbb_customers.Text.Trim)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_orders.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'On Grid_Orders selection changed
    Private Sub grid_orders_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_orders_view.SelectionChanged
        Dim SelectedRows = grid_orders_view.GetSelectedRows
        Dim total_sum As Decimal = 0.00

        If Not SelectedRows.Length = 0 Then

            For i = 0 To SelectedRows.Length - 1
                total_sum += grid_orders_view.GetRowCellValue(SelectedRows(i), col_total)
            Next

            txt_total_view.Text = FormatCurrency(total_sum)
        Else
            txt_total_view.Text = ""
        End If

    End Sub



End Class