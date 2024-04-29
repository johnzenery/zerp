Imports MySqlConnector

Public Class frm_accounting_new_payable


    '--- ON LOAD ----
    Private Sub frm_accounting_new_payable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPO()
    End Sub


    '--- FUNCTIONS ----
    Private Sub LoadPO()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT concat('PO',LPAD(purchase_id,5,0)) as poid, ims_suppliers.supplier FROM ims_purchase
                                            LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id WHERE deleted='0' AND is_payment_first='1'", connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_po.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub grid_po_view_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grid_po_view.FocusedRowChanged
        txt_poid.Text = grid_po_view.GetFocusedRowCellValue(col_poid)
        txt_supplier.Text = grid_po_view.GetFocusedRowCellValue(col_supplier)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT * FROM ims_purchase WHERE purchase_id=@id", connection)
                cmd.Parameters.AddWithValue("@id", CInt(txt_poid.Text.Replace("PO", String.Empty)))
                Dim rdr = cmd.ExecuteReader()

                While rdr.Read
                    txt_amount.Text = FormatCurrency(rdr("total"))
                    Dim disc_type As String = rdr("discount_type")
                    If Not String.IsNullOrEmpty(disc_type) Then
                        'IF %
                        If disc_type.Equals("%") Then
                            txt_discount.Text = CInt(rdr("discount_val")) & disc_type
                        End If
                        'IF Peso
                        If disc_type.Equals("peso") Then
                            txt_discount.Text = CInt(rdr("discount_val")) & " " & disc_type
                        End If
                    End If
                End While

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Async Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        'VALIDATION
        If String.IsNullOrWhiteSpace(txt_poid.Text) Or cbb_receipt.SelectedIndex = -1 Then
            MsgBox("Incomplete details! Check all fields.", vbCritical, "Fields Required")
            Exit Sub
        End If

        'CONFIRMATION
        Dim ans = MsgBox("Press 'YES' to confirm", vbInformation + vbYesNo, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                'CHECK IF EXIST
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_delivery_receipts WHERE receipt_ref=@ref", connection)
                    cmd.Parameters.AddWithValue("@ref", txt_poid.Text)
                    Using rdr = cmd.ExecuteReader
                        rdr.Read()
                        If rdr("COUNT(*)") > 0 Then
                            MsgBox("Duplicate found!", vbCritical, "Duplicate")
                            Exit Sub
                        End If
                    End Using
                End Using

                'Insert to Merchandice Payables Table
                Dim payables_cmd = New MySqlCommand("INSERT INTO ims_delivery_receipts (supplier_id, receipt_ref, receipt_type, amount, discount, status, received_date, store_id, purchase_id)
		                VALUES ((SELECT id FROM ims_suppliers WHERE supplier=@supplier), 
                                @receipt_ref, @receipt_type, @amount, @discount, @status, CURRENT_TIMESTAMP, (SELECT store_id FROM ims_stores WHERE store_name=@store_name), @purchase_id)", connection)
                payables_cmd.Parameters.AddWithValue("@supplier", txt_supplier.Text)
                payables_cmd.Parameters.AddWithValue("@receipt_ref", txt_poid.Text)
                payables_cmd.Parameters.AddWithValue("@receipt_type", cbb_receipt.Text)
                payables_cmd.Parameters.AddWithValue("@amount", CDec(txt_amount.Text))
                payables_cmd.Parameters.AddWithValue("@discount", IIf(String.IsNullOrEmpty(txt_discount.Text), Nothing, txt_discount.Text))
                payables_cmd.Parameters.AddWithValue("@status", "UNPAID")
                payables_cmd.Parameters.AddWithValue("@store_name", frm_main.lbl_user_designation.Text)
                payables_cmd.Parameters.AddWithValue("@purchase_id", CInt(txt_poid.Text.Replace("PO", String.Empty)))
                payables_cmd.ExecuteNonQuery()

                MsgBox("New payable was created!", vbInformation, "Information")
                Me.Close()
                Await frm_main.LoadFrm(New frm_accounting_supplier_invoice, "frm_accounting_payables")

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class