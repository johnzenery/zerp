Imports MySqlConnector

Public Class frm_accounting_view_transaction


    Public Property is_vatable As Boolean = False
    Public Property amount As Decimal = 0.00


    '--- Onload ---
    Private Sub frm_accounting_view_transaction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadData()

    End Sub




    '--- FUNCTIONS ---
    Private Sub LoadData()

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim cmd = New MySqlCommand("SELECT qty, ims_inventory.pid, ims_inventory.winmodel, ims_inventory.supmodel, ims_inventory.description, ims_deliveries.cost, (qty * ims_deliveries.cost) as total_cost 
                        FROM ims_deliveries
                        LEFT JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item
                        WHERE receipt_id=@receipt_id", connect)
                cmd.Parameters.AddWithValue("@receipt_id", lbl_payable_id.Text)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)


                Dim cmd_get_info = New MySqlCommand("SELECT (SELECT supplier FROM ims_suppliers WHERE id=supplier_id) as supplier, is_vatable,
                        CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id,5,0)) as poid, received_date, receipt_type, receipt_ref,
                        withholding_tax_amount,
                        count_by, (SELECT first_name FROM ims_users WHERE usr_id=ims_deliveries.receiver) as encoder, ims_delivery_receipts.discount, return_credit, amount
                        FROM ims_delivery_receipts
                        LEFT JOIN ims_deliveries ON ims_deliveries.receipt_id=ims_delivery_receipts.payable_id                        
                        LEFT JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item  
                        LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id    
                        WHERE payable_id=@receipt_id", connect)
                cmd_get_info.Parameters.AddWithValue("@receipt_id", lbl_payable_id.Text)
                Dim rdr As MySqlDataReader = cmd_get_info.ExecuteReader

                While rdr.Read
                    txt_purchaseID.Text = rdr("poid")
                    txt_supplier.Text = rdr("supplier")
                    dtp_received_date.Value = rdr("received_date")
                    txt_encoded_by.Text = rdr("encoder")
                    txt_counted_by.Text = rdr("count_by")
                    txt_ref.Text = rdr("receipt_ref")
                    cbb_type.Text = rdr("receipt_type")


                    lbl_discount.Text = IIf(IsDBNull(rdr("discount")), "", rdr("discount"))
                    is_vatable = rdr("is_vatable")

                    lbl_returned_credit.Text = IIf(rdr("return_credit") <= 0, "", CDec(rdr("return_credit")))
                    txt_total.Text = FormatCurrency(rdr("amount"))
                    amount = rdr("amount")
                    lbl_ewt.Text = IIf(rdr("withholding_tax_amount") > 0, rdr("withholding_tax_amount"), "")
                End While

                grid_transaction.DataSource = dt
                grid_transaction_view.OptionsBehavior.ReadOnly = False
                SetTotals()
            End Using

            'Set Update Button for Administrator, Accounting Mgr., Operation Staff
            Dim user_role = frm_main.user_role_id.Text
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

        'Get Subtotal
        For i = 0 To grid_transaction_view.RowCount - 1
            sub_total += grid_transaction_view.GetRowCellValue(i, col_total_cost)
        Next

        'Set Subtotal
        txt_sub_total.Text = FormatCurrency(sub_total)

        'Set Vat
        If is_vatable Then
            lbl_vatables_sales.Text = FormatCurrency(amount / 1.12)
            lbl_12_vat.Text = FormatCurrency((amount / 1.12) * 0.12)
        Else
            lbl_vatables_sales.Text = String.Empty
            lbl_12_vat.Text = String.Empty
        End If

        'Deduct Discounts
        If Not String.IsNullOrEmpty(lbl_discount.Text) Then
            If lbl_discount.Text.Contains("%"c) Then
                sub_total -= sub_total * (CDec(lbl_discount.Text.Replace("% OFF", String.Empty)) / 100)
            Else
                sub_total -= CDec(lbl_discount.Text.Replace(" Pesos OFF", String.Empty))
            End If
        End If

        'Deduct Return Credits
        If Not String.IsNullOrEmpty(lbl_returned_credit.Text) Then
            sub_total -= CDec(lbl_returned_credit.Text)
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
        End If
    End Sub

    'btn_update
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then

            Try

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_delivery_receipts 
                                SET amount=@amount, received_date=@received_date, receipt_ref=@receipt_ref, receipt_type=@receipt_type
                                WHERE payable_id=@payable_id", connect)
                        cmd.Parameters.AddWithValue("@amount", CDec(txt_total.Text))
                        cmd.Parameters.AddWithValue("@received_date", dtp_received_date.Value)
                        cmd.Parameters.AddWithValue("@receipt_ref", txt_ref.Text.Trim)
                        cmd.Parameters.AddWithValue("@receipt_type", cbb_type.Text.Trim)
                        cmd.Parameters.AddWithValue("@payable_id", lbl_payable_id.Text)
                        If cmd.ExecuteNonQuery > 0 Then
                            Using cmd_update_logs = New MySqlCommand("UPDATE ims_deliveries
                                                    SET qty=@qty, cost=@cost
                                                    WHERE item=@item AND receipt_id=@payable_id", connect)
                                cmd_update_logs.Parameters.AddWithValue("qty", 0)
                                cmd_update_logs.Parameters.AddWithValue("cost", 0.00)
                                cmd_update_logs.Parameters.AddWithValue("item", 0)
                                cmd_update_logs.Parameters.AddWithValue("payable_id", lbl_payable_id.Text)
                                cmd_update_logs.Prepare()

                                For i = 0 To grid_transaction_view.RowCount - 1
                                    cmd_update_logs.Parameters(0).Value = grid_transaction_view.GetRowCellValue(i, col_qty)
                                    cmd_update_logs.Parameters(1).Value = grid_transaction_view.GetRowCellValue(i, col_cost)
                                    cmd_update_logs.Parameters(2).Value = grid_transaction_view.GetRowCellValue(i, col_pid)
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
End Class