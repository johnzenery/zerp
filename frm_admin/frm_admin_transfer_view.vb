Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_admin_transfer_view



    'btn_view | Print Units to be Transferred
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click

        Select Case lbl_transfer_type.Text
            Case "Request"
                Dim frm = New frm_warehouse_stocktransfer_new_request
                frm.print_transfer_request(txt_transfer_id.Text)
            Case "Distribute"
                Dim frm = New frm_warehouse_stocktransfer_new_distribute
                frm.print_transfer_distribute(txt_transfer_id.Text)
        End Select


        Return
        Dim id = CInt(txt_transfer_id.Text.Replace("ST", String.Empty))

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT id, src_store.store_name as src_store, receiver_store.store_name as receiver_store, 
                 units, date, transfer_by.first_name as transfer_by, approved_by.first_name as approved_by, status,
                (SELECT value FROM ims_settings WHERE name='store_info') as store_info FROM `ims_transferred_stocks`
                LEFT JOIN ims_stores As src_store ON src_store.store_id=ims_transferred_stocks.src_store
                LEFT JOIN ims_stores As receiver_store ON receiver_store.store_id=ims_transferred_stocks.src_store
                LEFT JOIN ims_users AS transfer_by ON transfer_by.usr_id=ims_transferred_stocks.transfer_by
                LEFT JOIN ims_users AS approved_by ON approved_by.usr_id=ims_transferred_stocks.approved_by WHERE id=" & id

                Dim cmd = New MySqlCommand(query, connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim table = New PrintData
                table.transferred_units.Rows.Clear()
                Dim transfer_id = 1, transfer_date = Date.Today, transfer_from = String.Empty, transfer_to = String.Empty, transfer_by = String.Empty, units = String.Empty, store_info = String.Empty, approved_by = String.Empty, status = String.Empty

                While rdr.Read
                    status = rdr("status")
                    transfer_id = rdr("id")
                    transfer_date = rdr("date")
                    transfer_from = rdr("src_store")
                    transfer_to = rdr("receiver_store")
                    transfer_by = rdr("transfer_by")
                    units = rdr("units")
                    store_info = rdr("store_info")
                    approved_by = IIf(IsDBNull(rdr("approved_by")), String.Empty, rdr("approved_by"))
                End While
                rdr.Close()

                Dim per_unit = units.Split(";")
                For i = 0 To per_unit.Length - 1

                    Dim arr = per_unit(i).Split("=")

                    Dim cmd_desc = New MySqlCommand("SELECT winmodel, description, qty_per_box FROM ims_inventory WHERE pid=@pid", connection)
                    cmd_desc.Parameters.AddWithValue("@pid", arr(0))
                    Dim rd As MySqlDataReader = cmd_desc.ExecuteReader

                    While rd.Read
                        table.transferred_units.Rows.Add(arr(1), arr(1) / rd("qty_per_box"), rd("winmodel"), rd("description"), arr(2))
                    End While
                    rd.Close()
                Next

                Dim report = New doc_transfer_request()
                Dim printTool = New ReportPrintTool(report)

                report.Parameters("store_info").Value = store_info
                report.Parameters("transfer_id").Value = "ST" & id.ToString.PadLeft(5, "0"c)
                report.Parameters("transfer_date").Value = transfer_date
                report.Parameters("transfer_from").Value = transfer_from
                report.Parameters("transfer_to").Value = transfer_to
                report.Parameters("transfer_by").Value = transfer_by
                report.Parameters("approved_by").Value = approved_by
                report.Watermark.Text = status.ToUpper
                report.RequestParameters = False

                report.DataSource = table
                report.ShowRibbonPreviewDialog
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_approved | Approve Transfer Request
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click

        Dim ans = MsgBox("Press 'Yes' to Approve it.", vbYesNo + vbQuestion, "Confirmation")

        If ans = vbYes Then
            Dim id = CInt(txt_transfer_id.Text.Replace("ST", String.Empty))

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("UPDATE ims_stock_transfer SET approved_by=@approved_by, status=@status WHERE transfer_id = " & id, connection)
                    cmd.Parameters.AddWithValue("approved_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("status", "Approved")
                    cmd.ExecuteNonQuery()

                    MsgBox("Approved! ", vbInformation, "Information")
                End Using

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'btn_declined | Decline Transfer Request
    Private Sub btn_declined_Click(sender As Object, e As EventArgs) Handles btn_declined.Click

        Dim ans = MsgBox("Do you want Decline this Transfer Request?.", vbYesNo + vbQuestion, "Confirmation")

        If ans = vbYes Then
            Dim id = CInt(txt_transfer_id.Text.Replace("ST", String.Empty))

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("UPDATE ims_stock_transfer SET approved_by=@approved_by, status='Declined' WHERE transfer_id = " & id, connection)
                    cmd.Parameters.AddWithValue("approved_by", frm_main.lbl_user_id.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("Declined!", vbInformation, "Information")
                End Using

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub







End Class