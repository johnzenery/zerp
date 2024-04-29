Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frm_warehouse_delivery_receive


    '--- ON LOAD ---
    Private Sub frm_purchaseorder_receive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = txt_poid.Text
        load_all_warehouse()

        If frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 3 Or frm_main.lbl_user_role_id.Text = 6 Or frm_main.lbl_user_role_id.Text = 8 Then
            cbb_deliver.ReadOnly = False
        End If

    End Sub



    '--- FUNCTIONS ---
    Private Function Is_Validated()

        If String.IsNullOrWhiteSpace(txt_dr_no.EditValue) And String.IsNullOrWhiteSpace(txt_si_no.EditValue) Then
            MsgBox("No receipt information (DR/SI No.)", vbCritical, "Incomplete")
            Return False
        End If


        If dt_dr_date.EditValue = Nothing And dt_si_date.EditValue = Nothing Then
            MsgBox("No receipt information (DR/SI Date)", vbCritical, "Incomplete")
            Return False
        End If

        If cbb_tax_type.SelectedIndex = -1 Then
            MsgBox("No Tax type detected!", vbCritical, "Incomplete")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txt_amount.Text) Then
            MsgBox("No total cost detected!", vbCritical, "Incomplete")
            Return False
        End If

        If String.IsNullOrWhiteSpace(txt_count_by.Text) Then
            MsgBox("No counted by detected!", vbCritical, "Incomplete")
            Return False
        End If

        Return True

    End Function




    '--- CONTROLS AND EVENTS ---

    'btn_apply
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'Validate Receipt Info
        If Is_Validated() = True Then

            'Number Formatting
            Try
                Dim a = CDec(txt_amount.Text)
                Dim b = CDec(txt_discount.Text)
                Dim c = CDec(txt_return_credit.Text)
            Catch ex As Exception
                MsgBox("Incorrect Number! Check all fields.", vbCritical, "Number Format Exception")
                Exit Sub
            End Try

            Dim result As Boolean = False

            result = not_payment_first()

            'Show Print Barcode dialog
            If result = True Then
                If MsgBox("Show Barcode Generator?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                    Dim frm = New frm_warehouse_barcode_generator
                    frm.rb_per_receipt.Checked = True
                    frm.txt_po_no.Text = txt_poid.Text
                    'frm.cbb_type.Text = cbb_receipt.Text
                    'frm.txt_receipt_ref.Text = txt_ref.Text
                    frm.ShowDialog()
                End If

                Me.Close()
            End If

        End If

    End Sub

    'btn_mark
    Private Async Sub btn_mark_Click(sender As Object, e As EventArgs) Handles btn_mark.Click

        Dim ans = MsgBox("Mark as 'Completed'? It cannot be undone.", vbQuestion + vbYesNo, "Mark Completed")
        If ans = vbYes Then

            Try

                Dim id As Integer = txt_poid.Text.Replace("PO", String.Empty)

                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status='Completed', date_completed=@date_completed WHERE purchase_id=" & id, connection)
                    cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                    cmd.ExecuteNonQuery()

                    MsgBox("Success! Transaction has been completed.", vbInformation, "Transaction Complete")
                    Await frm_main.LoadFrm(New frm_warehouse_receivingManagement, "frm_warehouse_receivingManagement")
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub




    '--- FUNCTIONS ----

    'LOAD THE ORDERS 
    Public Sub Load_Orders(poid As Integer)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT orders, ims_purchase.supplier as supid, ims_suppliers.supplier, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, date_sent,
                                        discount_type, discount_val, is_withholding_tax_applied, withholding_tax_percentage, 
                                        ims_purchase.status, is_payment_first, ims_delivery_receipts.receipt_type, ims_users.first_name 'purchaser'
                                        FROM `ims_purchase`
                                        LEFT JOIN ims_users ON ims_users.usr_id=ims_purchase.created_by
                                        LEFT JOIN ims_delivery_receipts ON ims_delivery_receipts.receipt_ref=CONCAT('PO',LPAD(ims_purchase.purchase_id, 5, '0'))                        
                                        LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id WHERE ims_purchase.purchase_id='" & poid & "'", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read

                    txt_date_sent.Text = Date.Parse(rdr("date_sent")).ToString("MM-dd-yyyy")
                    cbb_supplier.Text = rdr("supplier")
                    cbb_deliver.Text = rdr("deliver_to")
                    txt_supid.Text = rdr("supid")
                    lbl_purchaser_name.Text = rdr("purchaser")

                    set_PurchaseOrder_DataTable(rdr("orders"), rdr("status"))

                    If Not IsDBNull(rdr("discount_type")) Then
                        cbb_discount.EditValue = rdr("discount_type")
                        txt_discount.EditValue = rdr("discount_val")
                    End If

                    is_withholding_tax_applied.Checked = rdr("is_withholding_tax_applied")
                    withholding_tax_percentage.Text = rdr("withholding_tax_percentage")


                End While

                grid_order.ClearSelection()
                ColorIndicator()

                txt_poid.Text = "PO" & poid.ToString.PadLeft(5, "0"c)
                lbl_head.Text = txt_poid.Text & " - " & cbb_supplier.Text
                dt_receive_date.EditValue = Date.Today

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Units to Grid
    Private Sub set_PurchaseOrder_DataTable(units As String, status As String)
        Dim no = 0
        Try
            Dim colonseparator As New Regex("\b;\b")
            Dim equalseparator As New Regex("\b=\b")

            Dim dataTable = New DataTable()
            dataTable.Columns.Add("pid", GetType(Integer))
            dataTable.Columns.Add("qty", GetType(Decimal))
            dataTable.Columns.Add("winmodel", GetType(String))
            dataTable.Columns.Add("supmodel", GetType(String)) 'Hidden
            dataTable.Columns.Add("description", GetType(String))
            dataTable.Columns.Add("total", GetType(Decimal)) 'Hidden
            dataTable.Columns.Add("total_received", GetType(Decimal))
            dataTable.Columns.Add("qty_received", GetType(Decimal))
            dataTable.Columns.Add("remaining", GetType(Decimal))
            dataTable.Columns.Add("cost", GetType(Decimal))
            dataTable.Columns.Add("total_cost", GetType(Decimal))
            dataTable.Columns.Add("discount", GetType(String))
            dataTable.Columns.Add("base_price", GetType(Decimal))
            dataTable.Columns.Add("is_bundle", GetType(Boolean))

            If Not String.IsNullOrEmpty(units) Then

                Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(units)
                For Each Order In PurchaseOrder
                    If Equals(status, "Sent") Then
                        dataTable.Rows.Add(
                            Order.pid,
                            Order.qty,
                            Order.winmodel,
                            Order.supmodel,
                            Order.description,
                            Order.total_cost,
                            0,
                            0,
                            Order.qty,
                            Order.cost,
                            0.00,
                            Order.discount,
                            Order.base_price,
                            Order.is_bundle
                        )
                    ElseIf Equals(status, "Partial") Then
                        dataTable.Rows.Add(
                            Order.pid,
                            Order.qty,
                            Order.winmodel,
                            Order.supmodel,
                            Order.description,
                            Order.total_cost,
                            Order.qty_received,
                            0,
                            Order.qty - Order.qty_received,
                            Order.cost,
                            0.00,
                            Order.discount,
                            Order.base_price,
                            Order.is_bundle
                        )
                    End If

                Next

                grid_order.DataSource = dataTable

            End If
        Catch ex As Exception
            MsgBox("Error in line " & no, vbCritical, "Error")
        End Try


    End Sub

    'Not Payment First
    Private Function not_payment_first()

        Dim result As Boolean = False
        Dim received As Decimal = 0.00
        Dim TotalAmount As Decimal = 0.00
        Dim ewt_amount As Decimal = 0.00

        'Validate Receive Counts
        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows
            received += row.Item("qty_received")
            If CDec(row.Item("qty_received")) > 0.00 Then
                TotalAmount += CDec(row.Item("qty_received")) * CDec(row.Item("cost"))    'QTY Received * cost
            End If
        Next

        If received = 0 Then
            MsgBox("No QTY Received detected!", vbCritical, "Error")
            Return False
        End If


        Try
            'Deduct Discount to TotalAmount
            If Not cbb_discount.SelectedIndex = -1 And Not String.IsNullOrWhiteSpace(txt_discount.Text) Then
                Select Case cbb_discount.SelectedIndex
                    Case 0 : TotalAmount -= CDec(txt_discount.Text)
                    Case 1 : TotalAmount -= (TotalAmount * (CDec(txt_discount.Text) / 100))
                End Select
            End If

            'Withholding Tax Deduction
            If is_withholding_tax_applied.Checked = True Then
                Dim vatable_sales As Decimal = TotalAmount / 1.12
                ewt_amount = vatable_sales * CDec(withholding_tax_percentage.Text / 100)
                TotalAmount -= ewt_amount
            End If

            'Deduct Return Credit to TotalAmount
            If Not String.IsNullOrWhiteSpace(txt_return_credit.Text) Then
                TotalAmount -= CDec(txt_return_credit.Text)
            End If

            'Receipt Amount Validation
            Dim system_total = TotalAmount
            Dim input_total = Math.Round(CDec(txt_amount.Text.Trim) - ewt_amount, 2)
            If Math.Abs(input_total) < Math.Abs(system_total - 1) Or Math.Abs(input_total) > Math.Abs(system_total + 1) Then
                MsgBox("Receipt amount value doesn't match!" & input_total, vbCritical, "Invalid Amount")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Number Format Exception")
            Return False
        End Try


        If MsgBox("Press 'YES' to Continue.", vbQuestion + vbYesNo, "Submit") = vbYes Then

            'Declaration of Values
            Dim supplier_id = txt_supid.Text
            Dim purchaseID As Integer = txt_poid.Text.Replace("PO", String.Empty)

            Dim amount = CDec(txt_amount.Text)
            Dim store = "ims_" & cbb_deliver.Text.Replace(" ", "_").ToLower
            Dim date_receieved As String = CDate(String.Concat(Date.Parse(dt_receive_date.EditValue).ToString("yyyy-MM-dd"), Date.Now.ToString(" HH:mm"))).ToString("yyyy-MM-dd HH:mm")
            'Dim date_receipt As String = CDate(String.Concat(Date.Parse(dt_receipt_date.EditValue).ToString("yyyy-MM-dd"), Date.Now.ToString(" HH:mm"))).ToString("yyyy-MM-dd HH:mm")

            Dim qty_toReceive = 0, qty_TotalReceieved = 0
            'Dim product_ID(1000) As Integer, qty_received(1000) As Decimal
            Dim discount As String

            'Get Discount
            Select Case cbb_discount.SelectedIndex
                Case 0 : discount = txt_discount.Text & " Pesos OFF"
                Case 1 : discount = txt_discount.Text & "% OFF"
                Case Else : discount = String.Empty
            End Select

            'Get Values From Grid 
            Dim datatable = TryCast(grid_order.DataSource, DataTable)
            Dim ListOfOrders = New List(Of PurchaseOrderClass)

            For Each row As DataRow In datatable.Rows

                qty_TotalReceieved += row.Item("qty_received") + row.Item("total_received")          'Get Total Received
                qty_toReceive += row.Item("qty")            'Get QTY

                ListOfOrders.Add(New PurchaseOrderClass With {
                .pid = row.Item("pid"),
                .qty = row.Item("qty"),
                .winmodel = row.Item("winmodel"),
                .supmodel = row.Item("supmodel"),
                .description = row.Item("description"),
                .total_cost = row.Item("total"),
                .qty_received = row.Item("total_received") + row.Item("qty_received"),
                .cost = row.Item("cost"),
                .base_price = row.Item("base_price"),
                .discount = row.Item("discount")
                })

            Next


            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'Insert to Store's Inventory  
                    For i = 0 To datatable.Rows.Count - 1
                        If CDec(datatable.Rows(i).Item("qty_received")) > 0 Then
                            Using add_qty_cmd = New MySqlCommand("INSERT INTO " & store & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", connection)
                                add_qty_cmd.Parameters.AddWithValue("@pid", datatable.Rows(i).Item("pid"))
                                add_qty_cmd.Parameters.AddWithValue("@qty", datatable.Rows(i).Item("qty_received"))
                                add_qty_cmd.ExecuteNonQuery()
                            End Using
                        End If
                    Next

                    'Insert to ims_delivery_receipts
                    Using payables_cmd = New MySqlCommand("INSERT INTO ims_delivery_receipts (supplier_id, dr_no, dr_date, si_no, si_date, tax_type, amount, discount, return_credit, status, received_date, store_id, purchase_id, count_by, terms, created_at)
		                VALUES (@supplier_id, @dr_no, @dr_date, @si_no, @si_date, @tax_type, @amount, @discount, @return_credit, @status, @received_date, (SELECT store_id FROM ims_stores WHERE store_name=@store_name), @purchase_id, @count_by,
                                (SELECT terms FROM ims_purchase WHERE purchase_id=@purchase_id), CURRENT_TIMESTAMP)", connection)
                        payables_cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
                        payables_cmd.Parameters.AddWithValue("@dr_no", txt_dr_no.EditValue)
                        payables_cmd.Parameters.AddWithValue("@dr_date", dt_dr_date.EditValue)
                        payables_cmd.Parameters.AddWithValue("@si_no", txt_si_no.EditValue)
                        payables_cmd.Parameters.AddWithValue("@si_date", dt_si_date.EditValue)
                        payables_cmd.Parameters.AddWithValue("@tax_type", cbb_tax_type.EditValue)
                        payables_cmd.Parameters.AddWithValue("@amount", TotalAmount) 'NONE
                        payables_cmd.Parameters.AddWithValue("@discount", IIf(String.IsNullOrEmpty(discount), Nothing, discount))
                        payables_cmd.Parameters.AddWithValue("@return_credit", IIf(String.IsNullOrWhiteSpace(txt_return_credit.Text), 0, txt_return_credit.Text))
                        payables_cmd.Parameters.AddWithValue("@status", "UNPAID")
                        payables_cmd.Parameters.AddWithValue("@received_date", date_receieved)
                        payables_cmd.Parameters.AddWithValue("@store_name", cbb_deliver.Text)
                        payables_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                        payables_cmd.Parameters.AddWithValue("@count_by", txt_count_by.Text.ToLower.Trim)
                        payables_cmd.ExecuteNonQuery()
                    End Using

                    'Get Count of ims_delivery_receipts
                    Dim get_count = New MySqlCommand("SELECT COUNT(*) FROM ims_delivery_receipts", connection)
                    Dim receipt_id = CInt(get_count.ExecuteScalar)

                    'Insert to ims_deliveries
                    Using deliveries_cmd = New MySqlCommand("INSERT INTO ims_deliveries (item, qty, date_received, purchase_id, receiver, store_id, receipt_id, cost, is_bundle ) 
                        VALUES (@item, @qty, @date_received, @purchase_id, @userid, (SELECT store_id FROM ims_stores WHERE store_name=@store), @receipt_id, @cost, @is_bundle)", connection)
                        deliveries_cmd.Parameters.AddWithValue("@item", 0)
                        deliveries_cmd.Parameters.AddWithValue("@qty", 0.00)
                        deliveries_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                        deliveries_cmd.Parameters.AddWithValue("@userid", frm_main.lbl_user_id.Text)
                        deliveries_cmd.Parameters.AddWithValue("@date_received", date_receieved)
                        deliveries_cmd.Parameters.AddWithValue("@store", cbb_deliver.Text)
                        deliveries_cmd.Parameters.AddWithValue("@receipt_id", receipt_id)
                        deliveries_cmd.Parameters.AddWithValue("@cost", 0.00)
                        deliveries_cmd.Parameters.AddWithValue("@is_bundle", False)
                        deliveries_cmd.Prepare()

                        For i = 0 To datatable.Rows.Count - 1
                            If datatable.Rows(i).Item("qty_received") > 0 Then
                                deliveries_cmd.Parameters("item").Value = datatable.Rows(i).Item("pid")
                                deliveries_cmd.Parameters("qty").Value = datatable.Rows(i).Item("qty_received")
                                deliveries_cmd.Parameters("cost").Value = datatable.Rows(i).Item("cost")
                                deliveries_cmd.Parameters("is_bundle").Value = datatable.Rows(i).Item("is_bundle")
                                deliveries_cmd.ExecuteNonQuery()
                            Else
                                Continue For
                            End If
                        Next

                    End Using


                    'Update ims_purchase
                    Using cmd = New MySqlCommand("UPDATE ims_purchase SET orders=@orders, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", connection)
                        cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                        cmd.Parameters.AddWithValue("@purchase_id", purchaseID)

                        If qty_toReceive = qty_TotalReceieved Then
                            cmd.Parameters.AddWithValue("@status", "Completed")
                            cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                            cmd.ExecuteNonQuery()
                            MsgBox("Success!", vbInformation + vbOKOnly, "Information")

                            'Load Deliveries
                            'frm_main.LoadFrm(New frm_warehouse_receivingManagement, "frm_warehouse_receivingManagement")

                        Else
                            cmd.Parameters.AddWithValue("@status", "Partial")
                            cmd.Parameters.AddWithValue("@date_completed", String.Empty)
                            cmd.ExecuteNonQuery()
                            MsgBox("Success!", vbInformation + vbOKOnly, "Information")

                            'Refresh Current
                            'Load_Orders(purchaseID)

                        End If

                    End Using
                End Using

                result = True

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

        Return result

    End Function

    'Payment First
    Private Function payment_first()

        Dim result As Boolean = False
        Dim received As Decimal = 0.00
        Dim TotalAmount As Decimal = 0.00

        'Validate Receive Counts
        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows
            received += row.Item(7) + row.Item(8)
            If CDec(row.Item(8)) > 0 Then
                TotalAmount += CDec(row.Item(8)) * CDec(row.Item(5))    'QTY Received * cost
            End If
        Next

        If received = 0 Then
            MsgBox("Can't saved! No values detected.", vbCritical, "Error")
            Return False
        End If

        Try
            'Deduct Discount to TotalAmount
            If Not cbb_discount.SelectedIndex = -1 And Not String.IsNullOrWhiteSpace(txt_discount.Text) Then
                Select Case cbb_discount.SelectedIndex
                    Case 0 : TotalAmount -= CDec(txt_discount.Text)
                    Case 1 : TotalAmount -= (TotalAmount * (CDec(txt_discount.Text) / 100))
                End Select
            End If

            Dim less_wt As Decimal = 0.00
            'Withholding Tax Deduction
            If is_withholding_tax_applied.Checked = True Then
                Dim less_vat_subtotal As Decimal = TotalAmount / 1.12
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(withholding_tax_percentage.Text / 100)
                TotalAmount -= withholding_tax
                less_wt = withholding_tax
            End If

            'Deduct Return Credit to TotalAmount
            If Not String.IsNullOrWhiteSpace(txt_return_credit.Text) Then
                TotalAmount -= CDec(txt_return_credit.Text)
            End If

            'Receipt Amount Validation
            Dim system_total = TotalAmount
            Dim input_total = Math.Round(CDec(txt_amount.Text.Trim) - less_wt, 2)
            If Math.Abs(input_total) < Math.Abs(system_total - 1) Or Math.Abs(input_total) > Math.Abs(system_total + 1) Then
                MsgBox("Receipt amount value is doesn't match!", vbCritical, "Invalid Amount")
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Number Format Exception")
            Return False
        End Try


        If MsgBox("Press 'YES' to Continue.", vbQuestion + vbYesNo, "Submit") = vbYes Then

            'Declaration of Values
            Dim supplier_id = txt_supid.Text
            Dim purchaseID As Integer = txt_poid.Text.Replace("PO", String.Empty)
            'Dim receipt_type = cbb_receipt.SelectedItem
            'Dim receipt_ref = txt_ref.Text.Trim
            Dim amount = CDec(txt_amount.Text)
            Dim store = "ims_" & cbb_deliver.Text.Replace(" ", "_").ToLower
            Dim str_qtyReceived = String.Empty
            Dim date_receieved As String = CDate(String.Concat(Date.Parse(dt_receive_date.EditValue).ToString("yyyy-MM-dd"), Date.Now.ToString(" HH:mm"))).ToString("yyyy-MM-dd HH:mm")

            Dim qty_remaining = 0, qty_receieved = 0
            Dim product_ID(1000) As Integer, qty_received(1000) As Decimal
            Dim discount As String

            Select Case cbb_discount.SelectedIndex
                Case 0 : discount = txt_discount.Text & "Pesos OFF"
                Case 1 : discount = txt_discount.Text & "% OFF"
                Case Else : discount = String.Empty
            End Select


            'Get Values From Grid 
            Dim datatable = TryCast(grid_order.DataSource, DataTable)
            Dim ListOfOrders = New List(Of PurchaseOrderClass)
            Dim row_count = 0
            For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows

                product_ID(row_count) = row.Item(0)     'Get PID
                qty_received(row_count) = row.Item(8)   'Get QTY 
                qty_receieved += row.Item(8)            'Get Received
                qty_remaining += row.Item(9)            'Get Remaining

                row_count += 1

                ListOfOrders.Add(New PurchaseOrderClass With {
                .pid = row.Item("pid"),
                .qty = row.Item("qty"),
                .winmodel = row.Item("winmodel"),
                .supmodel = row.Item("supmodel"),
                .description = row.Item("description"),
                .total_cost = row.Item("total"),
                .qty_received = row.Item("total_received") + row.Item("total_received"),
                .cost = row.Item("cost")
                })

            Next



            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'Insert to Store's Inventory  
                    For i = 0 To datatable.Rows.Count - 1
                        Using add_qty_cmd = New MySqlCommand("INSERT INTO " & store & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", connection)
                            add_qty_cmd.Parameters.AddWithValue("@pid", datatable.Rows(i).Item(0))
                            add_qty_cmd.Parameters.AddWithValue("@qty", datatable.Rows(i).Item(8))
                            add_qty_cmd.ExecuteNonQuery()
                        End Using
                    Next

                    'Get Payable ID
                    Dim get_payable_id = New MySqlCommand("SELECT payable_id FROM ims_delivery_receipts WHERE receipt_ref=@ref", connection)
                    get_payable_id.Parameters.AddWithValue("@ref", txt_poid.Text)
                    Dim receipt_id = get_payable_id.ExecuteScalar()

                    'Insert to Deliveries Table
                    Dim deliveries_cmd = New MySqlCommand("INSERT INTO ims_deliveries (item, qty, date_received, purchase_id, receiver, store_id, receipt_id, cost) 
                        VALUES (@item, @qty, @date_received, @purchase_id, @userid, (SELECT store_id FROM ims_stores WHERE store_name=@store), @receipt_id, @cost)", connection)
                    deliveries_cmd.Parameters.AddWithValue("@item", 0)
                    deliveries_cmd.Parameters.AddWithValue("@qty", 0.00)
                    deliveries_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                    deliveries_cmd.Parameters.AddWithValue("@userid", frm_main.lbl_user_id.Text)
                    deliveries_cmd.Parameters.AddWithValue("@date_received", date_receieved)
                    deliveries_cmd.Parameters.AddWithValue("@store", frm_main.lbl_user_designation.Text)
                    deliveries_cmd.Parameters.AddWithValue("@receipt_id", receipt_id)
                    deliveries_cmd.Parameters.AddWithValue("@cost", 0.00)
                    deliveries_cmd.Prepare()

                    For i = 0 To datatable.Rows.Count - 1
                        If datatable.Rows(i).Item(8) > 0 Then
                            deliveries_cmd.Parameters(0).Value = datatable.Rows(i).Item(0)
                            deliveries_cmd.Parameters(1).Value = datatable.Rows(i).Item(8)
                            deliveries_cmd.Parameters(7).Value = datatable.Rows(i).Item(5)
                            deliveries_cmd.ExecuteNonQuery()
                        Else
                            Continue For
                        End If
                    Next

                    'Update ims_purchase
                    'Dim cmd = New MySqlCommand("UPDATE ims_purchase SET qty_received=@qty_received, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", conn)
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET orders=@orders, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", connection)
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@qty_received", str_qtyReceived)
                    cmd.Parameters.AddWithValue("@purchase_id", purchaseID)

                    If qty_remaining = qty_receieved Then
                        cmd.Parameters.AddWithValue("@status", "Completed")
                        cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                        'Load Deliveries
                        'frm_main.LoadFrm(New frm_warehouse_receivingManagement, "frm_warehouse_receivingManagement")

                    Else
                        cmd.Parameters.AddWithValue("@status", "Partial")
                        cmd.Parameters.AddWithValue("@date_completed", String.Empty)
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                        'Refresh Current
                        Load_Orders(purchaseID)

                    End If
                End Using

                result = True

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

        Return result

    End Function

    'Color Indicator
    Private Sub ColorIndicator()

        For Each row As DataGridViewRow In grid_order.Rows
            If row.Cells("col_remaining_qty").Value = 0 Then
                row.Cells("col_remaining_qty").Style.BackColor = Color.FromArgb(224, 224, 224)
                row.Cells("col_remaining_qty").Style.ForeColor = Color.Black

                row.Cells("col_received").Style.BackColor = Color.FromArgb(224, 224, 224)
                row.Cells("col_received").Style.ForeColor = Color.Black

                row.Cells("col_remaining_qty").ReadOnly = True
                row.Cells("col_received").ReadOnly = True
            Else
                row.Cells("col_remaining_qty").Style.BackColor = Color.IndianRed
                row.Cells("col_remaining_qty").Style.ForeColor = Color.White
            End If

        Next

    End Sub

    'Restriction on Cell Edit
    Private Sub grid_order_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_order.CellEndEdit

        If Not IsNumeric(grid_order.CurrentCell.Value) Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Number only!", vbCritical, "Forbidden")
            Exit Sub
        End If

        If CInt(grid_order.CurrentCell.Value) > CInt(grid_order.CurrentRow.Cells("col_remaining_qty").Value) Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Value is greater than of the remaining.", vbCritical, "Forbidden")
        ElseIf grid_order.CurrentCell.Value < 0 Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Value is less than of the Zero.", vbCritical, "Forbidden")
        End If

        'Compute and Display Grand Total Cost
        Dim grand_total_cost As Decimal = 0.00
        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows
            grand_total_cost += row.Item("qty_received") * row.Item("cost")
        Next

        grid_order.CurrentRow.Cells("total_cost").Value = CDec(grid_order.CurrentCell.Value) * CDec(grid_order.CurrentRow.Cells("col_cost").Value)
        txt_grand_total.EditValue = grand_total_cost

    End Sub

    'btn_print | Print Receiving List
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        Try
            Dim report = New doc_delivery_list()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Dim deliver_to = cbb_deliver.Text.Trim,
                supplier = String.Empty, orders = String.Empty, received = String.Empty

            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT orders, ims_suppliers.supplier, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, qty_received FROM `ims_purchase`
                                        LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                                        WHERE purchase_id='" & CInt(txt_poid.Text.Replace("PO", String.Empty)) & "'", connection)
                    Using rdr As MySqlDataReader = cmd.ExecuteReader
                        While rdr.Read
                            supplier = rdr("supplier")
                            'deliver_to = rdr("deliver_to")
                            orders = rdr("orders")
                            received = rdr("qty_received")
                        End While
                    End Using
                End Using


                Dim store = String.Concat("ims_", deliver_to.ToLower().Replace(" ", "_"))

                If Not String.IsNullOrEmpty(orders) Then

                    Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(orders)
                    For Each Order In PurchaseOrder

                        'Skip IF COMPLETED
                        If Order.qty = Order.qty_received Then Continue For

                        'Get Location
                        Using get_loc_cmd = New MySqlCommand("SELECT location, location_2, ims_inventory.unit 
                                                    FROM " & store & " AS tbl 
                                                    LEFT JOIN ims_inventory ON ims_inventory.pid=tbl.pid
                                                    WHERE tbl.pid=@pid", connection)
                            get_loc_cmd.Parameters.AddWithValue("@pid", Order.pid)

                            Dim loc_1 As Object = Nothing
                            Dim loc_2 As Object = Nothing
                            Dim unit As Object = Nothing

                            Using rdr = get_loc_cmd.ExecuteReader
                                If rdr.HasRows Then
                                    rdr.Read()
                                    loc_1 = rdr("location")
                                    loc_2 = rdr("location_2")
                                    unit = rdr("unit")
                                End If

                                table.delivery_list.Rows.Add(
                                String.Empty,
                                Order.winmodel,
                                Order.supmodel,
                                Order.description,
                                loc_1,
                                loc_2,
                                unit)

                            End Using
                        End Using

                    Next

                    table.delivery_list.DefaultView.Sort = "supmodel ASC"

                End If
            End Using


            report.Parameters("pid").Value = txt_poid.Text
            report.Parameters("deliver_to").Value = deliver_to
            report.Parameters("supplier").Value = supplier

            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'txt_amount | Allow Numbers Only
    Private Sub txt_amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'txt_discount | Allow Numbers Only
    Private Sub txt_discount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_discount.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'txt_return_credit | Allow Numbers Only
    Private Sub txt_return_credit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_return_credit.KeyPress
        If Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = ".") And Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    'Grid Order Sorted
    Private Sub grid_order_Sorted(sender As Object, e As EventArgs) Handles grid_order.Sorted
        ColorIndicator()
    End Sub

    'Search
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim dataSource = DirectCast(grid_order.DataSource, DataTable)
        Dim dataViews As DataView = New DataView(dataSource)
        dataSource.DefaultView.RowFilter = String.Concat(New String() {"winmodel LIKE '%", txt_search.Text.Trim(), "%' OR description LIKE '%", txt_search.Text.Trim(), "%'"})
        grid_order.DataSource = dataSource
        ColorIndicator()
    End Sub

    'Load Warehouse to CBB
    Private Sub load_all_warehouse()
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()
                Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores", connect)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_deliver.Properties.Items.Add(rdr("store_name"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub

End Class