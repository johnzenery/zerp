Imports DevExpress.XtraRichEdit.Import.OpenXml
Imports MySqlConnector

Public Class frm_stock_return_confirmation

    ReadOnly conn As New MySqlConnection(str)

    'ONLOAD
    Private Sub frm_stock_returns_confirmation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_approved.Enabled = False
        btn_declined.Enabled = False
    End Sub

    'LOAD RETURN ID
    Private Sub RetrieveReturns(id As Integer)
        Try
            conn.Open()
            'GET UNITS FROM RETRUNS
            Using cmd = New MySqlCommand($"SELECT qty, ims_inventory.pid, ims_inventory.winmodel, ims_inventory.supmodel, serial, rs_returns.type, issue, rs_returns.id, approval_supplier as status
                                            FROM rs_returns 
                                            LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            WHERE NOT approval_supplier='Pending' AND pullout_id={id}", conn)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_returns.DataSource = dt
                btn_approved.Enabled = True
                btn_declined.Enabled = True

                If grid_returns_view.RowCount = 0 Then
                    MsgBox($"Pullout Request NOT found/sent.", vbCritical, "Not Found")
                    btn_approved.Enabled = False
                    btn_declined.Enabled = False
                End If

            End Using
        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btn_retrieve_Click(sender As Object, e As EventArgs) Handles btn_retrieve.Click
        RetrieveReturns(txt_pr_id.EditValue)
    End Sub

    'BUTTON : APPROVE
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        Dim selected_rows = grid_returns_view.GetSelectedRows
        If selected_rows.Length > 0 Then
            If MsgBox($"Press 'Yes' to confirm{vbCrLf + vbCrLf}Status: APPROVED", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Try
                    conn.Open()
                    Dim trans = conn.BeginTransaction

                    Try
                        Using cmd = New MySqlCommand("UPDATE rs_returns SET approval_supplier='Approved' WHERE id=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", 0)
                            cmd.Prepare()

                            For i = 0 To selected_rows.Length - 1
                                cmd.Parameters("@id").Value = grid_returns_view.GetRowCellValue(selected_rows(i), col_id)
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        trans.Commit()

                    Catch ex As MySqlException
                        trans.Rollback()
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                Catch ex As Exception
                    MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                Finally
                    conn.Close()
                    RetrieveReturns(txt_pr_id.EditValue)
                End Try
            End If
        Else
            MsgBox("No selected rows!", vbCritical, "Not Found")
        End If
    End Sub

    Private Sub btn_declined_Click(sender As Object, e As EventArgs) Handles btn_declined.Click
        Dim selected_rows = grid_returns_view.GetSelectedRows
        If selected_rows.Length > 0 Then
            If MsgBox($"Press 'Yes' to confirm{vbCrLf + vbCrLf}Status: DECLINED", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Try
                    conn.Open()
                    Dim trans = conn.BeginTransaction

                    Try
                        Using cmd = New MySqlCommand("UPDATE rs_returns SET approval_supplier='Declined' WHERE id=@id", conn, trans)
                            cmd.Parameters.AddWithValue("@id", 0)
                            cmd.Prepare()

                            For i = 0 To selected_rows.Length - 1
                                cmd.Parameters("@id").Value = grid_returns_view.GetRowCellValue(selected_rows(i), col_id)
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        trans.Commit()

                    Catch ex As MySqlException
                        trans.Rollback()
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                Catch ex As Exception
                    MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                Finally
                    conn.Close()
                    RetrieveReturns(txt_pr_id.EditValue)
                End Try
            End If
        Else
            MsgBox("No selected rows!", vbCritical, "Not Found")
        End If
    End Sub
End Class