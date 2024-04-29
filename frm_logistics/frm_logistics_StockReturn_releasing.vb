Imports MySqlConnector

Public Class frm_logistics_StockReturn_releasing

    ReadOnly conn As New MySqlConnection(str)

    ''--- ONLOAD ---
    Private Sub frm_logistics_pullouts_releasing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPullouts()
    End Sub


    ''--- FUNCTIONS ---
    Private Sub LoadPullouts()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT batch_id, ims_suppliers.supplier, status, ims_stores.store_name
                                            FROM rs_returns_batch
                                            LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                                            LEFT JOIN ims_stores ON ims_stores.store_id=rs_returns_batch.warehouse_id
                                            WHERE rs_returns_batch.is_deleted='0' AND rs_returns_batch.status='Packed'", conn)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_pullout.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'BUTTON : DISPATCH
    Private Sub btn_dispatch_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_dispatch.ButtonClick
        Dim batch_id = grid_pullout_view.GetFocusedRowCellValue(col_batch_id)
        Dim driver As String = String.Empty

        If MsgBox($"Press 'Yes' to confirm.{vbCrLf & vbCrLf}Pullout ID: {batch_id}", vbYesNo + vbQuestion, "Confirmation") = vbYes Then

            Using frm = New frm_logistics_delivered_by
                If frm.ShowDialog = DialogResult.OK Then
                    driver = frm.driver_name
                End If
            End Using

            Try
                conn.Open()
                Using trans = conn.BeginTransaction
                    Try
                        'UPDATE PULLOUT ID
                        Using cmd = New MySqlCommand($"UPDATE rs_returns_batch
                                            SET status='Released', released_by=@released_by, released_at=CURRENT_TIMESTAMP, driver=@driver
                                            WHERE batch_id=@batch_id", conn, trans)
                            cmd.Parameters.AddWithValue("@batch_id", batch_id)
                            cmd.Parameters.AddWithValue("@released_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@driver", driver)
                            cmd.ExecuteNonQuery()
                        End Using

                        'UPDATE RETURNS : SET AS 'SENT'
                        Using cmd = New MySqlCommand("UPDATE rs_returns SET status='Sent' WHERE batch_id=@batch_id", conn, trans)
                            cmd.Parameters.AddWithValue("@batch_id", batch_id)
                            cmd.ExecuteNonQuery()
                        End Using

                        trans.Commit()

                        Dim frm = New frm_stock_return_batch
                        frm.PrintSupplierReturns(batch_id)

                        MsgBox("Released!", vbInformation, "Information")

                    Catch ex As Exception
                        trans.Rollback()
                        MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                    Finally
                        conn.Close()
                        LoadPullouts()
                    End Try
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            End Try


        End If
    End Sub
End Class