Imports MySqlConnector

Public Class frm_accounting_view_transaction


    Private Property is_vatable As Boolean = False
    Private Property VAT_RATE As Decimal = 0.12
    Private Property is_withholding_applied As Boolean = False
    Private Property WT_RATE As Decimal = 0.01
    Public Property amount As Decimal = 0.00


    '--- Onload ---
    Private Sub frm_accounting_view_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
        Select Case lbl_status.Text
            Case "PAID"
                btn_update.Enabled = False
                btn_delete.Enabled = False
            Case "UNPAID" : btn_update.Enabled = True
        End Select
    End Sub




    '--- FUNCTIONS ---
    Private Sub LoadData()

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim cmd = New MySqlCommand("
                       SELECT 
                            reference,
                            qty,
                            ims_inventory.pid,
                            ims_inventory.winmodel,
                            ims_inventory.supmodel,
                            extracted_data.description,
                            extracted_data.base_price,
                            extracted_data.discount,
                            ims_deliveries.cost,
                            (qty * ims_deliveries.cost) AS total_cost,
                            ims_deliveries.purchase_id
                        FROM ims_deliveries
                        LEFT JOIN ims_inventory ON ims_inventory.pid = ims_deliveries.item
                        LEFT JOIN (
		                            SELECT
		                            DISTINCT extracted_data.pid,
		                            extracted_data.base_price,
		                            extracted_data.discount,
                                    extracted_data.description
		                        FROM ims_purchase
		                        CROSS JOIN JSON_TABLE(
		                            orders,
		                            '$[*]' COLUMNS (
		                                pid INT PATH '$.pid',
		                                base_price DECIMAL(10, 2) PATH '$.base_price',
		                                discount VARCHAR(10) PATH '$.discount',
                                        description TEXT PATH '$.description'
		                            )
		                        ) AS extracted_data
		                        WHERE purchase_id = @purchase_id
                        ) AS extracted_data ON extracted_data.pid = ims_deliveries.item
                        WHERE receipt_id = @receipt_id", connect)
                cmd.Parameters.AddWithValue("@receipt_id", lbl_receipt_id.Text)
                cmd.Parameters.AddWithValue("@purchase_id", lbl_purchase_id.Text)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)


                Dim cmd_get_info = New MySqlCommand("SELECT (SELECT supplier FROM ims_suppliers WHERE id=supplier_id) as supplier, is_vatable,
                        CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id,5,0)) as poid, received_date, receipt_type, receipt_ref, ims_delivery_receipts.terms,
                        ims_purchase.vat_rate, ims_purchase.withholding_tax_percentage,ims_purchase.is_withholding_tax_applied, ims_delivery_receipts.status, tax_type, dr_no, dr_date, si_no, si_date,
                        count_by, (SELECT first_name FROM ims_users WHERE usr_id=ims_deliveries.receiver) as encoder, ims_delivery_receipts.discount, return_credit, amount
                        FROM ims_delivery_receipts
                        LEFT JOIN ims_deliveries ON ims_deliveries.receipt_id=ims_delivery_receipts.payable_id                        
                        LEFT JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item  
                        LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id    
                        WHERE payable_id=@receipt_id", connect)
                cmd_get_info.Parameters.AddWithValue("@receipt_id", lbl_receipt_id.Text)
                Dim rdr As MySqlDataReader = cmd_get_info.ExecuteReader

                While rdr.Read
                    txt_purchaseID.Text = rdr("poid")
                    txt_supplier.Text = rdr("supplier")
                    dtp_received_date.Value = rdr("received_date")
                    txt_encoded_by.Text = rdr("encoder")
                    txt_counted_by.Text = rdr("count_by")

                    cbb_type.EditValue = rdr("tax_type")
                    txt_dr_no.EditValue = rdr("dr_no")
                    dt_dr_date.EditValue = rdr("dr_date")
                    txt_si_no.EditValue = rdr("si_no")
                    dt_si_date.EditValue = rdr("si_date")

                    lbl_status.Text = rdr("status")
                    txt_terms.Text = rdr("terms")

                    lbl_discount.Text = IIf(IsDBNull(rdr("discount")), String.Empty, rdr("discount"))
                    is_vatable = rdr("is_vatable")
                    VAT_RATE = CDec(rdr("vat_rate"))
                    lbl_vat.Text = Decimal.Round(CDec(rdr("vat_rate")) * 100, 0) & "% VAT"
                    is_withholding_applied = rdr("is_withholding_tax_applied")
                    WT_RATE = rdr("withholding_tax_percentage")

                    lbl_credit.Text = IIf(rdr("return_credit") <= 0, String.Empty, CDec(rdr("return_credit")))
                    txt_total.Text = FormatCurrency(rdr("amount"))
                    amount = rdr("amount")
                    'lbl_ewt.Text = IIf(rdr("withholding_tax_amount") > 0, rdr("withholding_tax_amount"), String.Empty)
                End While

                grid_transaction.DataSource = dt
                grid_transaction_view.OptionsBehavior.ReadOnly = False
                SetTotals()
            End Using

            'Set Update Button for Administrator, Accounting Mgr., Operation Staff
            Dim user_role = frm_main.lbl_user_role_id.Text
            If Not (user_role = 1 Or user_role = 2 Or user_role = 6) Then
                btn_update.Enabled = False
                btn_update.Appearance.BackColor = Color.Gainsboro
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Get Total
    Private Sub SetTotals()
        Dim sub_total As Decimal = 0.00

        'Get & Set Subtotal
        For i = 0 To grid_transaction_view.RowCount - 1
            sub_total += grid_transaction_view.GetRowCellValue(i, col_total_cost)
        Next
        txt_sub_total.Text = FormatCurrency(sub_total)

        'Deduct Discounts
        If Not String.IsNullOrEmpty(lbl_discount.Text) Then
            If lbl_discount.Text.Contains("%"c) Then
                sub_total -= sub_total * (CDec(lbl_discount.Text.Replace("% OFF", String.Empty)) / 100)
            Else
                sub_total -= CDec(lbl_discount.Text.Replace(" Pesos OFF", String.Empty))
            End If
        End If

        'Set Sales 
        lbl_sales.Text = FormatCurrency(sub_total)

        'Set Vat
        If is_vatable = True Then
            lbl_vatables_sales.Text = FormatCurrency(sub_total / (VAT_RATE + 1))
            lbl_12_vat.Text = FormatCurrency((sub_total / (VAT_RATE + 1)) * VAT_RATE)
        Else
            lbl_vatables_sales.Text = String.Empty
            lbl_12_vat.Text = String.Empty
        End If

        'LESS EWT
        If is_withholding_applied = True Then
            Dim ewt As Decimal = (sub_total / (VAT_RATE + 1)) * WT_RATE
            lbl_ewt.Text = FormatCurrency(ewt)
            sub_total -= ewt
        Else
            lbl_ewt.Text = String.Empty
        End If

        'Set Amount
        lbl_amount.Text = FormatCurrency(sub_total)

        'Deduct Credits
        If Not String.IsNullOrEmpty(lbl_credit.Text) Then
            sub_total -= CDec(lbl_credit.Text)
        End If

        'Set Total
        txt_total.Text = FormatCurrency(sub_total)

    End Sub




    '--- CONTROLS ----

    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    'Row Cell Value Changed
    Private Sub grid_transaction_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_transaction_view.CellValueChanged
        If e.Column.Name = col_qty.Name Or e.Column.Name = col_cost.Name Then
            Dim total = grid_transaction_view.GetFocusedRowCellValue(col_qty) * grid_transaction_view.GetFocusedRowCellValue(col_cost)
            grid_transaction_view.SetFocusedRowCellValue(col_total_cost, total)
            SetTotals()

        ElseIf e.Column.Name = col_pid.Name Then
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT winmodel, supmodel, description FROM ims_inventory WHERE pid=@pid", conn)
                    cmd.Parameters.AddWithValue("@pid", e.Value)
                    Using rdr = cmd.ExecuteReader
                        If rdr.HasRows Then
                            While rdr.Read
                                grid_transaction_view.SetFocusedRowCellValue(col_winmodel, rdr("winmodel"))
                                grid_transaction_view.SetFocusedRowCellValue(col_supmodel, rdr("supmodel"))
                                grid_transaction_view.SetFocusedRowCellValue(col_description, rdr("description"))
                            End While
                        Else
                            MsgBox("Item not found!", vbCritical, "Information")
                            grid_transaction_view.SetFocusedRowCellValue(col_winmodel, "-- NOT FOUND --")
                            grid_transaction_view.SetFocusedRowCellValue(col_supmodel, "-- NOT FOUND --")
                            grid_transaction_view.SetFocusedRowCellValue(col_description, "-- NOT FOUND --")
                        End If
                    End Using
                End Using
            End Using
        End If
    End Sub

    'btn_update
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then

            Try

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_delivery_receipts 
                                SET amount=@amount, received_date=@received_date, terms=@terms,
                                tax_type=@tax_type, dr_no=@dr_no, dr_date=@dr_date, si_no=@si_no, si_date=@si_date
                                WHERE payable_id=@payable_id", connect)
                        cmd.Parameters.AddWithValue("@amount", CDec(txt_total.Text))
                        cmd.Parameters.AddWithValue("@received_date", dtp_received_date.Value)
                        cmd.Parameters.AddWithValue("@dr_date", dt_dr_date.EditValue)
                        cmd.Parameters.AddWithValue("@dr_no", txt_dr_no.EditValue)
                        cmd.Parameters.AddWithValue("@si_date", dt_si_date.EditValue)
                        cmd.Parameters.AddWithValue("@si_no", txt_si_no.EditValue)
                        cmd.Parameters.AddWithValue("@tax_type", cbb_type.EditValue)
                        cmd.Parameters.AddWithValue("@payable_id", lbl_receipt_id.Text)
                        cmd.Parameters.AddWithValue("@terms", txt_terms.Text)
                        If cmd.ExecuteNonQuery > 0 Then
                            Using cmd_update_logs = New MySqlCommand("UPDATE ims_deliveries
                                                    SET item=@item, qty=@qty, cost=@cost
                                                    WHERE reference=@reference", connect)
                                cmd_update_logs.Parameters.AddWithValue("qty", 0)
                                cmd_update_logs.Parameters.AddWithValue("cost", 0.00)
                                cmd_update_logs.Parameters.AddWithValue("item", 0)
                                cmd_update_logs.Parameters.AddWithValue("reference", 0)
                                cmd_update_logs.Prepare()

                                For i = 0 To grid_transaction_view.RowCount - 1
                                    cmd_update_logs.Parameters(0).Value = grid_transaction_view.GetRowCellValue(i, col_qty)
                                    cmd_update_logs.Parameters(1).Value = grid_transaction_view.GetRowCellValue(i, col_cost)
                                    cmd_update_logs.Parameters(2).Value = grid_transaction_view.GetRowCellValue(i, col_pid)
                                    cmd_update_logs.Parameters(3).Value = grid_transaction_view.GetRowCellValue(i, col_id)
                                    cmd_update_logs.ExecuteNonQuery()
                                Next

                                MsgBox("Updated!", vbInformation, "Information")
                                Me.DialogResult = vbOK
                            End Using
                        End If
                    End Using
                End Using


            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Deleting invoice will rollback quantities. Continue?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim tbl_name As String = String.Empty

                    'GET TABLE NAME VIA Payable ID
                    Using get_table_cmd = New MySqlCommand("SELECT 
	                                                            CONCAT('ims_', LOWER(REPLACE(ims_stores.store_name, ' ', '_'))) tbl_name
                                                            FROM ims_delivery_receipts 
                                                            INNER JOIN ims_stores ON ims_stores.store_id=ims_delivery_receipts.store_id
                                                            WHERE payable_id=@payable_id", conn)
                        get_table_cmd.Parameters.AddWithValue("@payable_id", lbl_receipt_id.Text)
                        tbl_name = get_table_cmd.ExecuteScalar
                    End Using

                    Dim transc = conn.BeginTransaction()
                    Dim will_proceed = True

                    Using cmd_update_cmd = New MySqlCommand("UPDATE " & tbl_name & " SET qty=qty-@rollback_qty WHERE pid=@pid", conn)
                        cmd_update_cmd.Parameters.AddWithValue("@rollback_qty", 0)
                        cmd_update_cmd.Parameters.AddWithValue("@pid", 0)
                        cmd_update_cmd.Transaction = transc
                        cmd_update_cmd.Prepare()

                        For Each row As DataRow In TryCast(grid_transaction.DataSource, DataTable).Rows
                            cmd_update_cmd.Parameters("@rollback_qty").Value = row("qty")
                            cmd_update_cmd.Parameters("@pid").Value = row("pid")
                            If cmd_update_cmd.ExecuteNonQuery() = 0 Then
                                transc.Rollback()
                                will_proceed = False
                                MsgBox("Error occured!", vbCritical, "Error")
                            End If
                        Next
                    End Using

                    If will_proceed = False Then Exit Sub

                    'UPDATE ims_deliveries to Deleted | Delivery LOGS
                    Using cmd_delete_deliveries = New MySqlCommand("UPDATE ims_deliveries SET is_deleted=1 WHERE receipt_id=@reciept_id", conn)
                        cmd_delete_deliveries.Transaction = transc
                        cmd_delete_deliveries.Parameters.AddWithValue("@reciept_id", lbl_receipt_id.Text)

                        If cmd_delete_deliveries.ExecuteNonQuery > 0 Then

                            'UPDATE ims_delivery_receipts to Deleted | Supplier Invoice
                            Using cmd_update_receipt = New MySqlCommand("UPDATE ims_delivery_receipts SET is_deleted=1 WHERE payable_id=@payable_id", conn)
                                cmd_update_receipt.Transaction = transc
                                cmd_update_receipt.Parameters.AddWithValue("@payable_id", lbl_receipt_id.Text)

                                If cmd_update_receipt.ExecuteNonQuery > 0 Then
                                    transc.Commit()
                                    MsgBox("Deleted!", vbInformation, "Information")
                                    Me.Close()
                                End If
                            End Using
                        Else
                            transc.Rollback()
                            MsgBox("Error occured!", vbCritical, "Error")
                        End If
                    End Using

                    conn.Close()

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
End Class