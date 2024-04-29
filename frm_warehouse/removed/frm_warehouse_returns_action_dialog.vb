Imports MySql.Data.MySqlClient

Public Class frm_warehouse_returns_action_dialog

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_approved_returns SET status='Defective', encoded_by=@user WHERE id=" & hidden_id.Text, conn)
                        cmd.Parameters.AddWithValue("@user", frm_main.user_id.Text)
                        If cmd.ExecuteNonQuery = 1 Then
                            MsgBox("Submitted!", vbInformation, "Information")
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    Private Sub btn_ok_Click(sender As Object, e As EventArgs) Handles btn_ok.Click

        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_approved_returns SET status='Good Condition', encoded_by=@user WHERE id=" & hidden_id.Text, conn)
                        cmd.Parameters.AddWithValue("@user", frm_main.user_id.Text)
                        If cmd.ExecuteNonQuery > 0 Then

                            'INSERT/UPDATE TO SOURCE STORE
                            Dim destination_store = "ims_" & hidden_store.Text.ToLower.Replace(" ", "_")
                            Using cmd_update = New MySqlCommand("INSERT INTO " & destination_store & " (`pid`, `qty`) VALUES (@pid,@qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", conn)
                                cmd_update.Parameters.AddWithValue("@pid", hidden_pid.Text)
                                'cmd_update.Parameters.AddWithValue("@qty", lbl_qty.Text)
                                cmd_update.ExecuteNonQuery()
                            End Using

                            MsgBox("Submitted!", vbInformation, "Information")
                            Me.Close()

                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

End Class