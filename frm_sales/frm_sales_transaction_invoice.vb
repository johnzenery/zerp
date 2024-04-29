Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class frm_sales_transaction_invoice


    Private Sub frm_print_receipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.EditValue = New Date(Date.Today.Year, Date.Today.Month, 1)
        dt_end.EditValue = Date.Now
        LoadInvoices(dt_start.EditValue, dt_end.EditValue)
    End Sub





    '--- FUNCTIONS ----

    'Load Deliveries
    Private Sub LoadInvoices(startDate As Date, endDate As Date)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_id, date_ordered, date_released, ims_customers.account_type,
                                REPRESENTATIVE.first_name AS representative, SALES_AGENT.first_name AS sales_agent, 
                                ims_customers.first_name, payment_type, IFNULL(payment_status, 'UNPAID') as payment_status, ship_to, trucking, status, shipping_method 
                                FROM `ims_orders`  
                                INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                                LEFT JOIN ims_users SALES_AGENT ON ims_orders.sales_agent=SALES_AGENT.usr_id
                                LEFT JOIN ims_users REPRESENTATIVE ON ims_orders.agent=REPRESENTATIVE.usr_id
                                WHERE (status='Completed' OR status='Released') AND ims_orders.deleted='0'
                                    AND date_released BETWEEN  @start_date AND @end_date
                                ORDER BY order_id DESC", connection)
                cmd.Parameters.AddWithValue("@start_date", startDate)
                cmd.Parameters.AddWithValue("@end_date", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_deliveries.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print Invoice Receipt
    Public Sub PrintInvoice(orderid As String, Optional form_title As String = "SALES ORDER")
        Dim report = New doc_sales_order_receipt()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData

        report.lbl_form_title.Text = form_title

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_id, ims_customers.first_name, ims_customers.contact_person, ims_customers.account_type, address, ship_to, order_item, pub_note, payment_type, payment_status, DATE_ADD(date_released, INTERVAL ims_customers.terms DAY) AS due_date,
                        ims_orders.terms, amount_due, shipping_method, trucking, date_ordered, date_released, delivery_fee, 
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_info') AS store_info, (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name,
                        is_vatable, is_vat_exempt, is_vat_zero, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, discount_type, discount_val, 
                        applied_sales_return, CONCAT('SR', LPAD(sales_return_id, 5, '0')) AS srid, IFNULL(ims_sales_returns.amount, 0) as credit_amount, units,
                        no_of_box, no_of_plastic, no_of_rolls,
                        agent.first_name AS sales_rep, prepared_by, checked_by, packer.first_name AS packed_by, releaser.first_name AS released_by, delivered_by
                        FROM `ims_orders`
                        LEFT JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                        LEFT JOIN ims_users AS agent ON agent.usr_id=agent
                        LEFT JOIN ims_users AS sales_agent ON sales_agent.usr_id=sales_agent
                        LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims_orders.applied_sales_return
                        LEFT JOIN ims_users AS packer ON packer.usr_id=packed_by
                        LEFT JOIN ims_users AS releaser ON releaser.usr_id=released_by 
                        WHERE order_id=@id", connection)
                cmd.Parameters.AddWithValue("@id", orderid)
                rdr = cmd.ExecuteReader

                While rdr.Read

                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info")
                    report.Parameters("orderid").Value = String.Concat("SO", rdr("order_id").ToString().PadLeft(5, "0"c))
                    report.Parameters("customer").Value = rdr("first_name")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("customer_addr").Value = rdr("address")
                    report.Parameters("shipping_addr").Value = rdr("ship_to")
                    report.Parameters("shipping_method").Value = rdr("shipping_method")
                    report.Parameters("trucking").Value = rdr("trucking")

                    Dim sub_total As Decimal = data_to_print(rdr("order_item"), table.invoice_data)
                    report.Parameters("subtotal").Value = sub_total
                    report.Parameters("amount_due").Value = rdr("amount_due")
                    report.Parameters("pub_notes").Value = rdr("pub_note")
                    report.Parameters("date_created").Value = rdr("date_ordered")
                    report.Parameters("date_released").Value = rdr("date_released")
                    report.Parameters("due_date").Value = rdr("due_date")
                    report.Parameters("payment").Value = rdr("payment_type").ToString().ToUpper()
                    report.Parameters("terms").Value = rdr("terms")
                    report.Parameters("delivery_charge").Value = rdr("delivery_fee")



                    Dim disc_amount As Decimal = 0.00
                    Select Case rdr("discount_type")
                        Case "%" : disc_amount = sub_total * (rdr("discount_val") / 100)
                        Case "peso" : disc_amount = rdr("discount_val")
                    End Select

                    report.Parameters("discount_amount").Value = disc_amount
                    report.Parameters("discount_type").Value = rdr("discount_type")
                    report.Parameters("discount_val").Value = rdr("discount_val")

                    report.Parameters("is_vatable").Value = rdr("is_vatable")
                    report.Parameters("is_vat_exempt").Value = rdr("is_vat_exempt")
                    report.Parameters("is_vat_zero").Value = rdr("is_vat_zero")

                    report.Parameters("deduction_IsApplied").Value = IIf(rdr("applied_sales_return") = 0, False, True)
                    report.Parameters("deduction_srid").Value = rdr("srid")
                    report.Parameters("deduction_customer").Value = rdr("first_name")
                    report.Parameters("credit_amount").Value = rdr("credit_amount")

                    report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                    report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                    report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")
                    report.Parameters("no_of_box").Value = rdr("no_of_box")
                    report.Parameters("no_of_plastic").Value = rdr("no_of_plastic")
                    report.Parameters("no_of_rolls").Value = rdr("no_of_rolls")

                    report.Parameters("sales_rep").Value = rdr("sales_rep")
                    report.Parameters("prepared_by").Value = rdr("prepared_by")
                    report.Parameters("checked_by").Value = rdr("checked_by")
                    report.Parameters("packed_by").Value = rdr("packed_by")
                    report.Parameters("released_by").Value = rdr("released_by")
                    report.Parameters("delivered_by").Value = rdr("delivered_by")

                    'ADD PAID WATERMARK WHEN PAID
                    If rdr("payment_status").Equals("PAID") Then
                        report.Watermark.Text = "PAID"
                    End If

                    'Set Items to Grid
                    If Not IsDBNull(rdr("units")) Then
                        Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesReturnClass))(rdr("units"))
                        For Each item In itemsObject
                            table.sales_returns.Rows.Add(item.qty, item.model, item.description, item.unit_price, item.purchase_date, 0, item.total_amount, item.unit_price)
                        Next
                    End If


                    'SET RESTRICTION FOR NON-ADMIN ACCOUNTS
                    Dim user_role_id As Integer = frm_main.lbl_user_role_id.Text
                    If (Equals("Sister Company", rdr("account_type")) Or Equals("Branch", rdr("account_type"))) And Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then

                        report.header_unit_price.Text = ""
                        report.header_discount.Text = ""
                        report.header_total_price.Text = ""
                        report.header_d_price.Text = ""
                        report.cell_unit_price.Visible = False
                        report.cell_discount.Visible = False
                        report.cell_d_price.Visible = False
                        report.cell_total_price.Visible = False

                        report.lbl_subtotal.Visible = False
                        report.lbl_discount.Visible = False
                        report.lbl_total_sales.Visible = False

                        report.lbl_sales_return_subtotal.Visible = False
                        report.lbl_sales_returns.Visible = False

                        report.lbl_TotalSales.Visible = False
                        report.lbl_vat.Visible = False
                        report.lbl_AmountOfNetVat.Visible = False
                        report.lbl_VatableSales.Visible = False
                        report.lbl_VatExemptSales.Visible = False
                        report.lbl_VatZeroRated.Visible = False
                        report.lbl_VatAmount.Visible = False
                        report.lbl_TotalAmountDue.Visible = False
                        report.lbl_LessEWT.Visible = False
                        report.lbl_total_amount_due.Visible = False

                    ElseIf Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then
                        report.xpanel_breakdown_computation.Visible = False
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

    'SET DATE TO TABLE : ORDERS
    Public Function data_to_print(orders As String, table As DataTable)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim subtotal As Decimal

        If table.Rows.Count > 0 Then table.Rows.Clear()


        If Not String.IsNullOrEmpty(orders) Then

            comma = colonseparator.Split(orders)

            Using conn = New MySqlConnection(str)
                conn.Open()

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    Using cmd = New MySqlCommand("SELECT unit FROM ims_inventory WHERE winmodel='" & equal(1) & "'", conn)
                        Using rdr = cmd.ExecuteReader
                            rdr.Read()

                            If equal.Length = 6 Then    '---- OLD 
                                table.Rows.Add(equal(0),
                                               equal(1),
                                               equal(2),
                                               equal(3),
                                               IIf(Equals(equal(4), "0"), "", equal(4)),
                                               Nothing,
                                               equal(5).Replace(";", String.Empty),
                                               rdr("unit"))

                                subtotal += equal(5).Replace(";", String.Empty)

                            ElseIf equal.Length = 8 Then    '---- NEW =< 4.1.9 

                                Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7).Replace(";", String.Empty))

                                table.Rows.Add(equal(0),
                                               equal(1),
                                               equal(2),
                                               equal(3),
                                               IIf(Equals(equal(4), "0"), "", equal(4)),
                                               equal(5),
                                               equal(6),
                                               unit)

                                subtotal += equal(6).Replace(";", String.Empty)

                            ElseIf equal.Length = 10 Then
                                'Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7))
                                table.Rows.Add(equal(0),
                                               equal(1),
                                               equal(2),
                                               equal(3),
                                               IIf(Equals(equal(4), "0"), "", equal(4)),
                                               equal(5),
                                               equal(6),
                                               "",
                                               equal(8),
                                               equal(9).Replace(";", String.Empty))

                                subtotal += equal(6)

                            End If

                        End Using
                    End Using
                Next

            End Using

            'table.DefaultView.Sort = "model ASC"

        End If

        Return subtotal

    End Function




    '--- CONTROLS ----
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim orderid = grid_deliveries_view.GetFocusedRowCellValue(col_id)
        PrintInvoice(orderid)
    End Sub

End Class