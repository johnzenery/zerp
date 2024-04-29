Imports MySqlConnector

Public Class frm_warehouse_stocktransfer_approval_dialog
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click

        Dim ans = MsgBox("Press 'Yes' to Approve it.", vbYesNo + vbQuestion, "Confirmation")

        If ans = vbYes Then
            Dim id = CInt(lbl_stock_transfer_id.Text.Replace("ST", String.Empty))

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_stock_transfer SET approved_by=@approved_by, status=@status WHERE transfer_id = " & id, conn)
                    cmd.Parameters.AddWithValue("approved_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("status", "Approved")
                    cmd.ExecuteNonQuery()

                    MsgBox("Approved! ", vbInformation, "Information")
                    Me.DialogResult = DialogResult.Yes
                    Me.Close()
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    Private Sub btn_reject_Click(sender As Object, e As EventArgs) Handles btn_reject.Click

        Dim ans = MsgBox("Do you want Decline this Transfer Request?.", vbYesNo + vbQuestion, "Confirmation")

        If ans = vbYes Then
            Dim id = CInt(lbl_stock_transfer_id.Text.Replace("ST", String.Empty))

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_stock_transfer SET approved_by=@approved_by, status='Declined' WHERE transfer_id = " & id, conn)
                    cmd.Parameters.AddWithValue("approved_by", frm_main.lbl_user_id.Text)
                    cmd.ExecuteNonQuery()

                    MsgBox("Declined!", vbInformation, "Information")
                    Me.DialogResult = DialogResult.No
                    Me.Close()
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub
End Class