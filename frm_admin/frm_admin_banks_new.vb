Imports MySqlConnector

Public Class frm_admin_banks_new

    Public Property old_bank_name As String = ""
    Public Property old_bank_no As String = ""


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'VALIDATION
        If String.IsNullOrEmpty(txt_bank_name.Text) Or String.IsNullOrEmpty(txt_bank_no.Text) Or String.IsNullOrEmpty(cbb_account_type.EditValue) Then
            MsgBox("Complete all required fields!", vbExclamation, "Information")
            Return
        End If

        'SAVE AS NEW
        If lbl_id.Text.Equals("id") Then

            If cb_credit.Checked = True Then
                If MsgBox("Credit was ticked!" & Environment.NewLine &
                          "It would create additional column on payment journal." & Environment.NewLine & "Proceed?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Else
                    MsgBox("Couldn't proceed! Please untick credit.", vbInformation, "Information")
                    Return
                End If
            End If

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("INSERT INTO ims_banks (bank_acc_name, bank_acc_no, fund_name, account_type, is_debit, is_credit, is_enabled) VALUES (@acc_name, @acc_no, @fund_name, @account_type, @is_debit, @is_credit, @status)", conn)
                        cmd.Parameters.AddWithValue("@acc_name", txt_bank_name.Text)
                        cmd.Parameters.AddWithValue("@acc_no", txt_bank_no.Text)
                        cmd.Parameters.AddWithValue("@fund_name", txt_fund_name.Text)
                        cmd.Parameters.AddWithValue("@account_type", cbb_account_type.EditValue)
                        cmd.Parameters.AddWithValue("@is_debit", cb_debit.EditValue)
                        cmd.Parameters.AddWithValue("@is_credit", cb_credit.EditValue)
                        cmd.Parameters.AddWithValue("@status", toggle_status.EditValue)
                        If cmd.ExecuteNonQuery() > 0 Then

                            'CREATE COLUMN IN PAYMENT JOURNAL
                            If cb_credit.Checked = True Then
                                Dim table_name As String = txt_bank_name.Text.Trim.ToLower.Replace(" ", "_") & "_" & txt_bank_no.Text.Trim.ToLower.Replace(" ", "_")
                                Using cmd_updateTable = New MySqlCommand("ALTER TABLE ims_payments_journal ADD " & table_name & " decimal(10,2) NOT NULL;
                                                                          UPDATE ims_banks SET journal_column_name='" & table_name & "' WHERE bank_id=@id", conn)
                                    cmd_updateTable.Parameters.AddWithValue("@id", cmd.LastInsertedId)
                                    cmd_updateTable.ExecuteNonQuery()
                                End Using
                            End If

                            MsgBox("Success!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK

                        End If

                    End Using

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try


        Else
            'UPDATE ONLY

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_banks SET bank_acc_name=@acc_name, bank_acc_no=@acc_no, fund_name=@fund_name, account_type=@account_type, is_enabled=@status, is_debit=@is_debit, is_credit=@is_credit WHERE bank_id=@id", conn)
                        cmd.Parameters.AddWithValue("@id", lbl_id.Text)
                        cmd.Parameters.AddWithValue("@acc_name", txt_bank_name.Text)
                        cmd.Parameters.AddWithValue("@acc_no", txt_bank_no.Text)
                        cmd.Parameters.AddWithValue("@fund_name", txt_fund_name.Text)
                        cmd.Parameters.AddWithValue("@account_type", cbb_account_type.EditValue)
                        cmd.Parameters.AddWithValue("@is_debit", cb_debit.EditValue)
                        cmd.Parameters.AddWithValue("@is_credit", cb_credit.EditValue)
                        cmd.Parameters.AddWithValue("@status", toggle_status.EditValue)
                        If cmd.ExecuteNonQuery() > 0 Then

                            Dim old_table_name As String = old_bank_name.Trim.ToLower.Replace(" ", "_").Replace("-", "") & "_" & old_bank_no.Trim.ToLower.Replace(" ", "_")
                            Dim new_table_name As String = txt_bank_name.Text.Trim.ToLower.Replace(" ", "_").Replace("-", "") & "_" & txt_bank_no.Text.Trim.ToLower.Replace(" ", "_")

                            'UPDATE TABLE NAME IF NOT MATCH TO OLD
                            If Not Equals(old_bank_no.Trim.ToLower, txt_bank_no.Text.Trim.ToLower) Or Not Equals(old_bank_name.Trim.ToLower, txt_bank_name.Text.Trim.ToLower) Then
                                Using cmd_updateTable = New MySqlCommand("ALTER TABLE ims_payments_journal RENAME COLUMN " & old_table_name & " TO " & new_table_name & ";
                                                                          UPDATE ims_banks SET journal_column_name='" & new_table_name & "' WHERE bank_id=@id", conn)
                                    cmd_updateTable.Parameters.AddWithValue("@id", lbl_id.Text)
                                    cmd_updateTable.ExecuteNonQuery()
                                End Using
                            End If

                            'CREATE COLUMN IN PAYMENT JOURNAL
                            If cb_credit.Checked = True Then
                                Dim is_found As Boolean = False

                                Using cmd_select = New MySqlCommand("SELECT COUNT(*) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'ims_payments_journal' AND COLUMN_NAME = '" & new_table_name & "'", conn)
                                    If cmd_select.ExecuteScalar > 0 Then
                                        is_found = True
                                    End If
                                End Using

                                If is_found = False Then
                                    Using cmd_updateTable = New MySqlCommand("ALTER TABLE ims_payments_journal ADD " & new_table_name & " decimal(10,2) NOT NULL", conn)
                                        cmd_updateTable.ExecuteNonQuery()
                                    End Using
                                End If
                            End If

                            MsgBox("Updated!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK

                        End If
                    End Using

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub

End Class