Imports System.Text.RegularExpressions
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class frm_warehouse_SupplierDeliveries

    ReadOnly conn As New MySqlConnection(str)


    '--- ON LOAD ---
    Private Sub frm_purchaseorder_receive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = txt_poid.Text
        load_all_warehouse()

        If frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 3 Or frm_main.user_role_id.Text = 6 Or frm_main.user_role_id.Text = 8 Then
            cbb_deliver.ReadOnly = False
        End If

    End Sub



    '--- FUNCTIONS ---




    '--- CONTROLS AND EVENTS ---

    'btn_apply
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'Validate Receipt Info
        If Not (cbb_receipt.SelectedIndex = -1 Or
            String.IsNullOrWhiteSpace(txt_ref.Text) Or
            String.IsNullOrWhiteSpace(txt_amount.Text) Or
            String.IsNullOrWhiteSpace(txt_count_by.Text)) Then

            'Number Formatting
            Try
                Dim a = CDec(txt_amount.Text)
                Dim b = CDec(txt_discount.Text)
                Dim c = CDec(txt_return_credit.Text)
            Catch ex As Exception
                MsgBox("Incorrect Number! Check all fields.", vbCritical, "Number Format Exception")
                Exit Sub
            End Try

            Dim res As Boolean = False
            Dim is_payment_first As Boolean = False
            Using conn
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_purchase WHERE purchase_id=@id", conn)
                    cmd.Parameters.AddWithValue("@id", CInt(txt_poid.Text.Replace("PO", "")))
                    Dim rdr = cmd.ExecuteReader()
                    rdr.Read()
                    is_payment_first = CBool(rdr("is_payment_first"))
                End Using
            End Using

            If Not is_payment_first Then
                res = not_payment_first()
            Else
                res = payment_first()
            End If

            'Show Print Barcode dialog
            If res = True Then
                If MsgBox("Show Barcode Generator?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                    Dim frm = New frm_warehouse_barcode_generator
                    frm.rb_per_receipt.Checked = True
                    frm.txt_po_no.Text = txt_poid.Text
                    frm.cbb_type.Text = cbb_receipt.Text
                    frm.txt_receipt_ref.Text = txt_ref.Text
                    frm.ShowDialog()
                End If
            End If

            cbb_receipt.SelectedIndex = -1
            txt_ref.Text = String.Empty
            txt_amount.Text = String.Empty
            txt_count_by.Text = String.Empty
            txt_discount.Text = String.Empty
            txt_return_credit.Text = String.Empty
            cbb_discount.SelectedIndex = -1

        Else
            MsgBox("Can't saved! No receipt info detected.", vbCritical, "Error")
        End If

    End Sub

    'btn_mark
    Private Sub btn_mark_Click(sender As Object, e As EventArgs) Handles btn_mark.Click

        Dim ans = MsgBox("Mark as 'Completed'? It cannot be undone.", vbQuestion + vbYesNo, "Mark Completed")
        If ans = vbYes Then

            Try

                Dim id As Integer = txt_poid.Text.Replace("PO", "")

                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status='Completed', date_completed=@date_completed WHERE purchase_id=" & id, conn)
                cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                cmd.ExecuteNonQuery()

                MsgBox("Success! Transaction has been completed.", vbInformation, "Transaction Complete")
                frm_main.LoadFrm(New frm_warehouse_receivingManagement)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub




    '--- FUNCTIONS ----

    'LOAD THE ORDERS 
    Public Sub Load_Orders(poid As Integer)

        If conn.State = ConnectionState.Open Then conn.Close()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT orders, ims_purchase.supplier as supid, ims_suppliers.supplier, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, date_sent,
                                        is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage, ims_purchase.status, is_payment_first, ims_delivery_receipts.receipt_type 
                                        FROM `ims_purchase`
                                        LEFT JOIN ims_delivery_receipts ON ims_delivery_receipts.receipt_ref=CONCAT('PO',LPAD(ims_purchase.purchase_id, 5, '0'))                        
                                        LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id WHERE ims_purchase.purchase_id='" & poid & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            While rdr.Read
                If rdr("is_payment_first") = True Then
                    cbb_receipt.Text = rdr("receipt_type")
                    txt_ref.Text = String.Concat("PO", poid.ToString().PadLeft(5, "0"c))
                    txt_ref.Enabled = False
                End If
                txt_date_sent.Text = Date.Parse(rdr("date_sent")).ToString("MM-dd-yyyy")
                cbb_supplier.Text = rdr("supplier")
                cbb_deliver.Text = rdr("deliver_to")
                txt_supid.Text = rdr("supid")
                set_PurchaseOrder_DataTable(rdr("orders"), rdr("status"))
                is_withholding_tax_applied.Checked = rdr("is_withholding_tax_applied")
                withholding_tax_amount.Text = rdr("withholding_tax_amount")
                withholding_tax_percentage.Text = rdr("withholding_tax_percentage")
            End While

            grid_order.ClearSelection()
            ColorIndicator()

            txt_poid.Text = "PO" & poid.ToString.PadLeft(5, "0"c)
            lbl_head.Text = txt_poid.Text & " - " & cbb_supplier.Text
            dt_receipt.EditValue = Date.Today

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
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
            dataTable.Columns.Add("cost", GetType(Decimal)) 'Hidden
            dataTable.Columns.Add("total", GetType(Decimal)) 'Hidden
            dataTable.Columns.Add("total_received", GetType(Decimal))
            dataTable.Columns.Add("qty_received", GetType(Decimal))
            dataTable.Columns.Add("remaining", GetType(Decimal))

            If Not String.IsNullOrEmpty(units) Then

                'comma = colonseparator.Split(units)
                'Dim qty_received = received.Split(";")

                'For i = 0 To comma.Length - 1
                '    piece = comma(i).Trim
                '    equal = piece.Split("=")

                '    If status.Equals("Sent") Then
                '        no += 1
                '        dataTable.Rows.Add(equal(0), equal(1), equal(2), equal(4), 0, 0, equal(1), equal(5))
                '    ElseIf status.Equals("Partial") Then
                '        no += 1
                '        dataTable.Rows.Add(equal(0), equal(1), equal(2), equal(4), qty_received(i), 0, equal(1) - qty_received(i), equal(5))
                '    End If

                'Next

                Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(units)
                For Each Order In PurchaseOrder
                    If Equals(status, "Sent") Then
                        dataTable.Rows.Add(
                            Order.pid,
                            Order.qty,
                            Order.winmodel,
                            Order.supmodel,
                            Order.description,
                            Order.cost,
                            Order.total_cost,
                            0,
                            0,
                            Order.qty
                        )
                    ElseIf Equals(status, "Partial") Then
                        dataTable.Rows.Add(
                            Order.pid,
                            Order.qty,
                            Order.winmodel,
                            Order.supmodel,
                            Order.description,
                            Order.cost,
                            Order.total_cost,
                            Order.qty_received,
                            0,
                            Order.qty - Order.qty_received
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

        'Validate Receive Counts
        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows
            received += row.Item(7) + row.Item(8)
            If CDec(row.Item(8)) > 0.00 Then
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
            Dim purchaseID As Integer = txt_poid.Text.Replace("PO", "")
            Dim receipt_type = cbb_receipt.SelectedItem
            Dim receipt_ref = txt_ref.Text.Trim
            Dim amount = CDec(txt_amount.Text)
            Dim store = "ims_" & cbb_deliver.Text.Replace(" ", "_").ToLower
            Dim str_qtyReceived = ""
            Dim date_receieved = CDate(String.Concat(CDate(dt_receipt.EditValue).ToString("dd/MM/yyyy"), Date.Now.ToString(" HH:mm")))

            Dim qty_remaining = 0, qty_receieved = 0
            Dim product_ID(1000) As Integer, qty_received(1000) As Decimal
            Dim discount As String

            'Get Discount
            Select Case cbb_discount.SelectedIndex
                Case 0 : discount = txt_discount.Text & " Pesos OFF"
                Case 1 : discount = txt_discount.Text & "% OFF"
                Case Else : discount = ""
            End Select

            'Get Values From Grid 
            Dim datatable = TryCast(grid_order.DataSource, DataTable)
            Dim ListOfOrders = New List(Of PurchaseOrderClass)
            Dim row_count = 0
            For Each row As DataRow In datatable.Rows

                product_ID(row_count) = row.Item(0)     'Get PID
                qty_received(row_count) = row.Item(8)   'Get QTY 
                qty_receieved += row.Item(8)            'Get Total Received
                qty_remaining += row.Item(9)            'Get Total Remaining

                row_count += 1

                ListOfOrders.Add(New PurchaseOrderClass With {
                .pid = row.Item(0),
                .qty = row.Item(1),
                .winmodel = row.Item(2),
                .supmodel = row.Item(3),
                .description = row.Item(4),
                .cost = row.Item(5),
                .total_cost = row.Item(6),
                .qty_received = row.Item(7) + row.Item(8)
                })

            Next


            Try
                conn.Open()

                'Insert to Store's Inventory  
                For i = 0 To datatable.Rows.Count - 1
                    Using add_qty_cmd = New MySqlCommand("INSERT INTO " & store & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", conn)
                        add_qty_cmd.Parameters.AddWithValue("@pid", datatable.Rows(i).Item(0))
                        add_qty_cmd.Parameters.AddWithValue("@qty", datatable.Rows(i).Item(8))
                        add_qty_cmd.ExecuteNonQuery()
                    End Using
                Next

                'Insert to ims_delivery_receipts
                Using payables_cmd = New MySqlCommand("INSERT INTO ims_delivery_receipts (supplier_id, receipt_ref, receipt_type, amount, discount, return_credit, status, received_date, store_id, purchase_id, count_by)
		                VALUES (@supplier_id, @receipt_ref, @receipt_type, @amount, @discount, @return_credit, @status, @received_date, (SELECT store_id FROM ims_stores WHERE store_name=@store_name), @purchase_id, @count_by)", conn)
                    payables_cmd.Parameters.AddWithValue("@supplier_id", supplier_id)
                    payables_cmd.Parameters.AddWithValue("@receipt_ref", receipt_ref)
                    payables_cmd.Parameters.AddWithValue("@receipt_type", receipt_type)
                    payables_cmd.Parameters.AddWithValue("@amount", TotalAmount) 'NONE
                    payables_cmd.Parameters.AddWithValue("@discount", IIf(String.IsNullOrEmpty(discount), Nothing, discount))
                    payables_cmd.Parameters.AddWithValue("@return_credit", IIf(String.IsNullOrWhiteSpace(txt_return_credit.Text), 0, txt_return_credit.Text))
                    payables_cmd.Parameters.AddWithValue("@status", "UNPAID")
                    payables_cmd.Parameters.AddWithValue("@received_date", date_receieved)
                    payables_cmd.Parameters.AddWithValue("@store_name", frm_main.user_store.Text)
                    payables_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                    payables_cmd.Parameters.AddWithValue("@count_by", txt_count_by.Text.ToLower.Trim)
                    payables_cmd.ExecuteNonQuery()
                End Using

                'Get Count of ims_delivery_receipts
                Dim get_count = New MySqlCommand("SELECT COUNT(*) FROM ims_delivery_receipts", conn)
                Dim receipt_id = CInt(get_count.ExecuteScalar)

                'Insert to ims_deliveries
                Using deliveries_cmd = New MySqlCommand("INSERT INTO ims_deliveries (item, qty, date_received, purchase_id, receiver, store_id, receipt_id, cost) 
                        VALUES (@item, @qty, @date_received, @purchase_id, @userid, (SELECT store_id FROM ims_stores WHERE store_name=@store), @receipt_id, @cost)", conn)
                    deliveries_cmd.Parameters.AddWithValue("@item", 0)
                    deliveries_cmd.Parameters.AddWithValue("@qty", 0.00)
                    deliveries_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                    deliveries_cmd.Parameters.AddWithValue("@userid", frm_main.user_id.Text)
                    deliveries_cmd.Parameters.AddWithValue("@date_received", date_receieved)
                    deliveries_cmd.Parameters.AddWithValue("@store", cbb_deliver.Text)
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

                End Using


                'Update ims_purchase
                Using cmd = New MySqlCommand("UPDATE ims_purchase SET orders=@orders, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", conn)
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@purchase_id", purchaseID)

                    If qty_remaining = qty_receieved Then
                        cmd.Parameters.AddWithValue("@status", "Completed")
                        cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                        'Load Deliveries
                        frm_main.LoadFrm(New frm_warehouse_receivingManagement)

                    Else
                        cmd.Parameters.AddWithValue("@status", "Partial")
                        cmd.Parameters.AddWithValue("@date_completed", "")
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                        'Refresh Current
                        Dim frm = New frm_warehouse_SupplierDeliveries
                        frm_warehouse_receivingManagement.LoadFrm(frm)
                        Load_Orders(purchaseID)

                    End If

                End Using

                result = True

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
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
            Dim purchaseID As Integer = txt_poid.Text.Replace("PO", "")
            Dim receipt_type = cbb_receipt.SelectedItem
            Dim receipt_ref = txt_ref.Text.Trim
            Dim amount = CDec(txt_amount.Text)
            Dim store = "ims_" & cbb_deliver.Text.Replace(" ", "_").ToLower
            Dim str_qtyReceived = ""
            Dim date_receieved = CDate(String.Concat(CDate(dt_receipt.EditValue).ToString("dd/MM/yyyy"), Date.Now.ToString(" HH:mm")))

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
                .pid = row.Item(0),
                .qty = row.Item(1),
                .winmodel = row.Item(2),
                .supmodel = row.Item(3),
                .description = row.Item(4),
                .cost = row.Item(5),
                .total_cost = row.Item(6),
                .qty_received = row.Item(7) + row.Item(8)
                })

            Next



            Try
                conn.Open()

                'Insert to Store's Inventory  
                For i = 0 To datatable.Rows.Count - 1
                    Using add_qty_cmd = New MySqlCommand("INSERT INTO " & store & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", conn)
                        add_qty_cmd.Parameters.AddWithValue("@pid", datatable.Rows(i).Item(0))
                        add_qty_cmd.Parameters.AddWithValue("@qty", datatable.Rows(i).Item(8))
                        add_qty_cmd.ExecuteNonQuery()
                    End Using
                Next

                'Get Payable ID
                Dim get_payable_id = New MySqlCommand("SELECT payable_id FROM ims_delivery_receipts WHERE receipt_ref=@ref", conn)
                get_payable_id.Parameters.AddWithValue("@ref", txt_poid.Text)
                Dim receipt_id = get_payable_id.ExecuteScalar()

                'Insert to Deliveries Table
                Dim deliveries_cmd = New MySqlCommand("INSERT INTO ims_deliveries (item, qty, date_received, purchase_id, receiver, store_id, receipt_id, cost) 
                        VALUES (@item, @qty, @date_received, @purchase_id, @userid, (SELECT store_id FROM ims_stores WHERE store_name=@store), @receipt_id, @cost)", conn)
                deliveries_cmd.Parameters.AddWithValue("@item", 0)
                deliveries_cmd.Parameters.AddWithValue("@qty", 0.00)
                deliveries_cmd.Parameters.AddWithValue("@purchase_id", purchaseID)
                deliveries_cmd.Parameters.AddWithValue("@userid", frm_main.user_id.Text)
                deliveries_cmd.Parameters.AddWithValue("@date_received", date_receieved)
                deliveries_cmd.Parameters.AddWithValue("@store", frm_main.user_store.Text)
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
                Dim cmd = New MySqlCommand("UPDATE ims_purchase SET orders=@orders, date_completed=@date_completed, status=@status WHERE purchase_id=@purchase_id", conn)
                cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                cmd.Parameters.AddWithValue("@qty_received", str_qtyReceived)
                cmd.Parameters.AddWithValue("@purchase_id", purchaseID)

                If qty_remaining = qty_receieved Then
                    cmd.Parameters.AddWithValue("@status", "Completed")
                    cmd.Parameters.AddWithValue("@date_completed", Date.Now)
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                    'Load Deliveries
                    frm_main.LoadFrm(New frm_warehouse_receivingManagement)

                Else
                    cmd.Parameters.AddWithValue("@status", "Partial")
                    cmd.Parameters.AddWithValue("@date_completed", "")
                    cmd.ExecuteNonQuery()
                    MsgBox("Successfull!", vbInformation + vbOKOnly, "Information")

                    'Refresh Current
                    Dim frm = New frm_warehouse_SupplierDeliveries
                    frm_warehouse_receivingManagement.LoadFrm(frm)
                    Load_Orders(purchaseID)

                End If

                result = True

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

        Return result

    End Function

    'Color Indicator
    Private Sub ColorIndicator()

        For Each row As DataGridViewRow In grid_order.Rows
            If row.Cells(9).Value = 0 Then
                row.Cells(9).Style.BackColor = Color.FromArgb(224, 224, 224)
                row.Cells(9).Style.ForeColor = Color.Black

                row.Cells(8).Style.BackColor = Color.FromArgb(224, 224, 224)
                row.Cells(8).Style.ForeColor = Color.Black

                row.Cells(9).ReadOnly = True
                row.Cells(8).ReadOnly = True
            Else
                row.Cells(9).Style.BackColor = Color.IndianRed
                row.Cells(9).Style.ForeColor = Color.White
            End If

        Next

    End Sub

    'Restriction on Cell Edit
    Private Sub grid_order_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_order.CellEndEdit

        If Not IsNumeric(grid_order.CurrentCell.Value) Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Number are only allowed!", vbCritical, "Forbidden")
            Exit Sub
        End If

        If CInt(grid_order.CurrentCell.Value) > CInt(grid_order.CurrentRow.Cells(9).Value) Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Value is greater than of the remaining.", vbCritical, "Forbidden")
        ElseIf grid_order.CurrentCell.Value < 0 Then
            grid_order.CurrentCell.Value = 0
            MsgBox("Value is less than of the Zero.", vbCritical, "Forbidden")
        End If
    End Sub

    'btn_print | Print Receiving List
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        Try
            Dim report = New doc_delivery_list()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Dim deliver_to = "", supplier = "", orders = "", received = ""

            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT orders, ims_suppliers.supplier, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, qty_received FROM `ims_purchase`
                                        LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                                        WHERE purchase_id='" & CInt(txt_poid.Text.Replace("PO", "")) & "'", connection)
                    Using rdr As MySqlDataReader = cmd.ExecuteReader
                        While rdr.Read
                            supplier = rdr("supplier")
                            deliver_to = rdr("deliver_to")
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
                        Using get_loc_cmd = New MySqlCommand("SELECT location FROM " & store & " WHERE pid=@pid", connection)
                            get_loc_cmd.Parameters.AddWithValue("@pid", Order.pid)

                            table.delivery_list.Rows.Add(
                                String.Empty,
                                Order.winmodel,
                                Order.supmodel,
                                Order.description,
                                get_loc_cmd.ExecuteScalar())
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