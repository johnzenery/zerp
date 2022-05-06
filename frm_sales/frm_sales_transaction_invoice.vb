Imports System.Text.RegularExpressions
Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_sales_transaction_invoice

    ReadOnly conn As New MySqlConnection(str)

    Private Sub frm_print_receipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadInvoices()
    End Sub





    '--- FUNCTIONS ----

    'Load Deliveries
    Private Sub LoadInvoices()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_id, date_ordered, date_released, 
                                REPRESENTATIVE.first_name AS representative, SALES_AGENT.first_name AS sales_agent, 
                                ims_customers.first_name, payment_type, IFNULL(payment_status, 'UNPAID') as payment_status, ship_to, trucking, status, shipping_method FROM `ims_orders`  
                                INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                                LEFT JOIN ims_users SALES_AGENT ON ims_orders.sales_agent=SALES_AGENT.usr_id
                                LEFT JOIN ims_users REPRESENTATIVE ON ims_orders.agent=REPRESENTATIVE.usr_id
                                WHERE (status='Completed' OR status='Released') AND ims_orders.deleted='0'", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_deliveries.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Print Invoice Receipt
    Public Sub PrintInvoice(orderid As String)
        Dim report = New doc_sales_order_receipt()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_id, ims_customers.first_name, ims_customers.contact_person, ims_customers.account_type, address, ship_to, order_item, pub_note, payment_type, payment_status, DATE_ADD(date_released, INTERVAL ims_customers.terms DAY) AS due_date,
                        ims_orders.terms, amount_due, shipping_method, trucking, date_released, delivery_fee, 
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_info') AS store_info, (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name,
                        is_vatable, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, discount_type, discount_val, applied_sales_return, CONCAT('SR', LPAD(sales_return_id, 5, '0')) AS srid, IFNULL(ims_sales_returns.amount, 0) as amount,
                        no_of_box, no_of_plastic, no_of_rolls,
                        agent.first_name AS prepared_by, packer.first_name AS arranged_by, releaser.first_name AS released_by, sales_agent.first_name AS sales_agent FROM `ims_orders`
                        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                        INNER JOIN ims_users AS agent ON agent.usr_id=agent
                        LEFT JOIN ims_users AS sales_agent ON sales_agent.usr_id=sales_agent
                        LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims_orders.applied_sales_return
                        INNER JOIN ims_users AS packer ON packer.usr_id=packed_by
                        INNER JOIN ims_users AS releaser ON releaser.usr_id=released_by 
                        WHERE order_id=@id", connection)
                cmd.Parameters.AddWithValue("@id", orderid)
                rdr = cmd.ExecuteReader

                While rdr.Read

                    If rdr("account_type").ToString.Equals("Sister Company") Then
                        If Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 2 Or frm_main.user_role_id.Text = 4 Or frm_main.user_role_id.Text = 6) Then
                            MsgBox("Requires priviledge to access.", vbExclamation, "Forbidden")
                            Return
                        End If
                    End If

                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info")
                    report.Parameters("orderid").Value = String.Concat("SO", rdr("order_id").ToString().PadLeft(5, "0"c))
                    report.Parameters("customer").Value = rdr("first_name")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("customer_addr").Value = rdr("address")
                    report.Parameters("shipping_addr").Value = rdr("ship_to")
                    report.Parameters("shipping_method").Value = rdr("shipping_method")
                    report.Parameters("trucking").Value = rdr("trucking")
                    report.Parameters("amount_due").Value = rdr("amount_due")
                    report.Parameters("pub_notes").Value = rdr("pub_note")
                    report.Parameters("date_released").Value = rdr("date_released")
                    report.Parameters("due_date").Value = rdr("due_date")
                    report.Parameters("payment").Value = rdr("payment_type").ToString().ToUpper()
                    report.Parameters("terms").Value = rdr("terms")
                    report.Parameters("delivery_charge").Value = rdr("delivery_fee")
                    report.Parameters("discount_type").Value = rdr("discount_type")
                    report.Parameters("discount_val").Value = rdr("discount_val")
                    report.Parameters("is_vatable").Value = rdr("is_vatable")
                    report.Parameters("deduction_IsApplied").Value = IIf(rdr("applied_sales_return") = 0, False, True)
                    report.Parameters("deduction_srid").Value = rdr("srid")
                    report.Parameters("deduction_customer").Value = rdr("first_name")
                    report.Parameters("deduction_total").Value = rdr("amount")
                    report.Parameters("credits").Value = rdr("amount")
                    report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                    report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                    report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")
                    report.Parameters("no_of_box").Value = rdr("no_of_box")
                    report.Parameters("no_of_plastic").Value = rdr("no_of_plastic")
                    report.Parameters("no_of_rolls").Value = rdr("no_of_rolls")
                    report.Parameters("subtotal").Value = data_to_grid(rdr("order_item"), table.invoice_data)
                    report.Parameters("prepared_by").Value = rdr("prepared_by")
                    report.Parameters("arranged_by").Value = rdr("arranged_by")
                    report.Parameters("released_by").Value = rdr("released_by")
                    report.Parameters("sales_agent").Value = rdr("sales_agent")

                    'ADD PAID WATERMARK WHEN PAID
                    If rdr("payment_status").Equals("PAID") Then
                        report.Watermark.Text = "PAID"
                    End If

                End While

                report.RequestParameters = False
                report.DataSource = table
                report.ShowRibbonPreviewDialog()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set data to Table
    Public Function data_to_grid(orders As String, table As DataTable)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim subtotal As Decimal

        If table.Rows.Count > 0 Then table.Rows.Clear()

        If Not String.IsNullOrEmpty(orders) Then

            comma = colonseparator.Split(orders)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")
                subtotal += equal(5).Replace(";", "")
                table.Rows.Add(equal(0), equal(1), equal(2), equal(3), equal(4), equal(5).Replace(";", ""))
            Next

            table.DefaultView.Sort = "model ASC"

        End If

        Return subtotal

    End Function






    '--- CONTROLS ----
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim orderid = grid_deliveries_view.GetFocusedRowCellValue(col_id)
        PrintInvoice(orderid)
    End Sub

End Class