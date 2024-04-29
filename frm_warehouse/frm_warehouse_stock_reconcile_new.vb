Imports MySqlConnector

Public Class frm_warehouse_stock_reconcile_new


    Private Sub frm_warehouse_stock_reconcile_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If String.IsNullOrWhiteSpace(cbb_stores.Text) Then
            load_warehouse()
            load_model()
        End If
    End Sub


    '--- FUNCTIONS ---

    Private Sub load_warehouse()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim mySqlCommand = New MySqlCommand("SELECT store_name FROM ims_stores", connection)
                cbb_stores.Properties.Items.Clear()
                Using mySqlDataReader = mySqlCommand.ExecuteReader()
                    While mySqlDataReader.Read()
                        cbb_stores.Properties.Items.Add(mySqlDataReader("store_name"))
                    End While
                End Using
            End Using

            cbb_stores.SelectedText = frm_main.lbl_user_designation.Text

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub load_model()
        Try
            Dim my_store = "ims_" & cbb_stores.Text.ToLower.Replace(" ", "_")

            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT winmodel FROM ims_inventory INNER JOIN " & my_store & " AS MyStore ON MyStore.pid=ims_inventory.pid", connection)

                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_model.Properties.Items.Add(rdr("winmodel"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Public Sub approved_func(status As String)
        Try

            Using connection = New MySqlConnection(str)
                connection.Open()

                If status = "Approved" Then
                    Dim query = String.Empty

                    If rb_add.Checked Then query = "INSERT INTO ims_" & cbb_stores.Text.ToLower.Replace(" ", "_") & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty"
                    If rb_deduct.Checked Then query = "UPDATE ims_" & cbb_stores.Text.ToLower.Replace(" ", "_") & " SET qty=qty-@qty WHERE pid=@pid AND qty>=@qty"

                    Using cmd = New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@qty", num_reconcile.Value)
                        cmd.Parameters.AddWithValue("@pid", CInt(txt_pid.Text))
                        Dim ans = cmd.ExecuteNonQuery()

                        If ans > 0 Then
                            Using cmd_update_status = New MySqlCommand("UPDATE ims_reconciled_stocks SET status=@status, approved_by=@approved_by WHERE id=@id", connection)
                                cmd_update_status.Parameters.AddWithValue("@id", CInt(lbl_title.Text.Replace("Reconcile Request #", String.Empty)))
                                cmd_update_status.Parameters.AddWithValue("@status", status)
                                cmd_update_status.Parameters.AddWithValue("@approved_by", frm_main.lbl_user_id.Text)
                                cmd_update_status.ExecuteNonQuery()

                                MsgBox("Request has been approved!", vbInformation, "Information")
                                Me.Close()
                            End Using
                        Else
                            MsgBox("Reconcilation Failed! Something is wrong.", vbCritical, "Failed")
                        End If

                    End Using

                ElseIf status = "Declined" Then
                    Using cmd_update_status = New MySqlCommand("UPDATE ims_reconciled_stocks SET status=@status, approved_by=@approved_by WHERE id=@id", connection)
                        cmd_update_status.Parameters.AddWithValue("@id", CInt(lbl_title.Text.Replace("Reconcile Request #", String.Empty)))
                        cmd_update_status.Parameters.AddWithValue("@status", status)
                        cmd_update_status.Parameters.AddWithValue("@approved_by", frm_main.lbl_user_id.Text)
                        cmd_update_status.ExecuteNonQuery()
                    End Using

                    MsgBox("Request has been declined!", vbInformation, "Information")
                    Me.Close()
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    '--- CONTROLS ---
    Private Sub cbb_model_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_model.EditValueChanged
        Try

            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT pid, description FROM ims_inventory WHERE winmodel=@model", connection)
                cmd.Parameters.AddWithValue("@model", cbb_model.Text.Trim)
                Using rdr = cmd.ExecuteReader
                    rdr.Read()
                    txt_description.Text = rdr("description")
                    txt_pid.Text = rdr("pid")
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_submit
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        If btn_submit.Text = "Approve" Then
            Dim res = MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation")
            If res = vbYes Then
                approved_func("Approved")
            End If
            Exit Sub
        End If

        If cbb_stores.SelectedIndex = -1 Or
            String.IsNullOrWhiteSpace(cbb_model.Text) Or
            String.IsNullOrWhiteSpace(txt_description.Text) Or
            String.IsNullOrWhiteSpace(txt_memo.Text) Or
            String.IsNullOrWhiteSpace(txt_pid.Text) Or
            num_reconcile.Value = 0 Then
            MsgBox("Complete all fields!", vbCritical, "Required")
            Exit Sub
        End If

        If rb_add.Checked = False And rb_deduct.Checked = False Then
            MsgBox("Select Type of Reconcilation!", vbCritical, "Required")
            Exit Sub
        End If

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("INSERT INTO ims_reconciled_stocks (src_store, qty, item, reconciled_type, reconciled_by, notes, status, created_at)
                            VALUES ((SELECT store_id FROM ims_stores WHERE store_name=@store_name), @qty, @item, @reconciled_type, @reconciled_by, @notes, @status, CURRENT_TIMESTAMP)", connection)
                cmd.Parameters.AddWithValue("@store_name", cbb_stores.Text.Trim)
                cmd.Parameters.AddWithValue("@qty", num_reconcile.Value)
                cmd.Parameters.AddWithValue("@item", txt_pid.Text)
                cmd.Parameters.AddWithValue("@reconciled_type", IIf(rb_add.Checked = True, "add", "deduct"))
                cmd.Parameters.AddWithValue("@reconciled_by", frm_main.lbl_user_id.Text)
                cmd.Parameters.AddWithValue("@notes", txt_memo.Text.Trim)
                cmd.Parameters.AddWithValue("@status", "Pending")
                cmd.ExecuteNonQuery()
            End Using

            MsgBox("Reconcilation request submitted!" & vbCrLf & "waiting for approval..", vbInformation, "Information")
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click

        If btn_cancel.Text = "Decline" Then
            Dim res = MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation")
            If res = vbYes Then
                approved_func("Declined")
            End If
            Exit Sub
        End If

        Me.Close()

    End Sub

End Class