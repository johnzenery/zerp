Imports MySqlConnector

Public Class frm_admin_ccterminal_new

    Public Property assigned_fund_name As String = String.Empty

    '--- ONLOAD
    Private Sub frm_admin_ccterminal_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFunds()
    End Sub



    '--- FUNCTIONS
    Private Sub LoadFunds()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT fund_name FROM ims_banks", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_fund_name.Properties.Items.Add(rdr("fund_name"))
                        End While
                    End Using

                    If Not String.IsNullOrWhiteSpace(assigned_fund_name) Then
                        cbb_fund_name.EditValue = assigned_fund_name
                    End If

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    '--- EVENTS

    'BUTTON : SAVE
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                If String.IsNullOrWhiteSpace(txt_terminal_id.Text) Then
                    Using cmd = New MySqlCommand(" INSERT INTO ims_cc_terminals (terminal_name, assigned_fund_id) 
                    SELECT @terminal_name, bank_id FROM ims_banks WHERE fund_name=@fund_name", conn)
                        cmd.Parameters.AddWithValue("@terminal_name", txt_terminal_name.EditValue)
                        cmd.Parameters.AddWithValue("@fund_name", cbb_fund_name.EditValue)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Success!", vbInformation, "Information")
                            conn.Close()
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    End Using

                Else
                    Using cmd = New MySqlCommand(" UPDATE ims_cc_terminals SET terminal_name=@terminal_name, 
                                assigned_fund_id=(SELECT bank_id FROM ims_banks WHERE fund_name=@fund_name) WHERE terminal_id=@tid", conn)
                        cmd.Parameters.AddWithValue("@terminal_name", txt_terminal_name.EditValue)
                        cmd.Parameters.AddWithValue("@fund_name", cbb_fund_name.EditValue)
                        cmd.Parameters.AddWithValue("@tid", txt_terminal_id.EditValue)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Success!", vbInformation, "Information")
                            conn.Close()
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    End Using

                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : CLOSE
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Press 'YES' to delete", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("UPDATE ims_cc_terminals SET is_deleted='1' WHERE terminal_id=@tid", conn)
                    cmd.Parameters.AddWithValue("@tid", txt_terminal_id.EditValue)

                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Deleted!", vbInformation, "Information")
                        conn.Close()
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End Using

                conn.Close()
            End Using
        End If
    End Sub
End Class