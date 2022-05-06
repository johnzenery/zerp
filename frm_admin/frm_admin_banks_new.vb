Imports MySqlConnector

Public Class frm_admin_banks_new


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If lbl_id.Text.Equals("id") Then

            'SAVE
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("INSERT INTO ims_banks (bank_acc_name, bank_acc_no, is_enabled) VALUES (@acc_name, @acc_no, @status)", conn)
                        cmd.Parameters.AddWithValue("@acc_name", txt_bank_name.Text)
                        cmd.Parameters.AddWithValue("@acc_no", txt_bank_no.Text)
                        cmd.Parameters.AddWithValue("@status", toggle_status.EditValue)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        Else
            'EDIT
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open
                    Using cmd = New MySqlCommand("UPDATE ims_banks SET bank_acc_name=@acc_name, bank_acc_no=@acc_no, is_enabled=@status WHERE bank_id=@id", conn)
                        cmd.Parameters.AddWithValue("@id", lbl_id.Text)
                        cmd.Parameters.AddWithValue("@acc_name", txt_bank_name.Text)
                        cmd.Parameters.AddWithValue("@acc_no", txt_bank_no.Text)
                        cmd.Parameters.AddWithValue("@status", toggle_status.EditValue)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class