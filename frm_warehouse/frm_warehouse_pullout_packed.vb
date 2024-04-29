Imports MySqlConnector

Public Class frm_warehouse_pullout_packed

    ReadOnly conn As New MySqlConnection(str)

    Private Function ValidateInputs() As Boolean
        Dim res As Boolean = False

        If Not (String.IsNullOrWhiteSpace(txt_packed_by.EditValue) Or String.IsNullOrWhiteSpace(txt_prepared_by.EditValue)) Then
            res = True
        End If

        Return res
    End Function

    Private Sub btn_packed_Click(sender As Object, e As EventArgs) Handles btn_packed.Click
        If ValidateInputs() = True Then
            If MsgBox("Press 'Yes' to confirm", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Try
                    conn.Open()

                    Using trans = conn.BeginTransaction
                        Try
                            'UPDATE BATCH
                            Using cmd = New MySqlCommand($"UPDATE rs_returns_batch
                                            SET status='Packed', prepared_by=@prepared_by, packed_by=@packed_by, packed_at=CURRENT_TIMESTAMP
                                            WHERE batch_id={txt_pullout_id.EditValue}", conn, trans)
                                cmd.Parameters.AddWithValue("@prepared_by", txt_prepared_by.EditValue.ToString)
                                cmd.Parameters.AddWithValue("@packed_by", txt_packed_by.EditValue.ToString)
                                If cmd.ExecuteNonQuery > 0 Then
                                End If
                            End Using

                            'UPDATE RETURNS
                            'UPDATE RETURNS
                            Using cmd = New MySqlCommand($"UPDATE rs_returns 
                                            SET status='Packed' 
                                            WHERE batch_id={txt_pullout_id.EditValue}", conn, trans)
                                cmd.ExecuteNonQuery()
                            End Using

                            trans.Commit()
                            MsgBox("Packed!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK

                        Catch ex As Exception
                            trans.Rollback()
                            MsgBox($"An error occured:{vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                        End Try
                    End Using

                Catch ex As Exception
                    MsgBox($"An error occured:{vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                Finally
                    conn.Close()
                End Try
            End If

        Else
            MsgBox("Complete all fields!", vbCritical, "Required")
        End If
    End Sub

End Class