Imports MySqlConnector

Public Class frm_accounting_payment_vouchers_release

    Public Property payment_id As Integer

    'BUTTON : SUBMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("UPDATE ims_payment_vouchers SET received_by=@received_by, date_released=@date_released, 
                            released_by=@released_by WHERE payment_id=@payment_id", conn)
                    cmd.Parameters.AddWithValue("@received_by", txt_received_by.Text.Trim)
                    cmd.Parameters.AddWithValue("@date_released", de_released_date.EditValue)
                    cmd.Parameters.AddWithValue("@released_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("@payment_id", payment_id)
                    If cmd.ExecuteNonQuery > 0 Then
                        conn.Close()
                        MsgBox("Released!")
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : CLOSE
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class