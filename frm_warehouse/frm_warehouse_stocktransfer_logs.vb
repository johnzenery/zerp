Imports MySqlConnector

Public Class frm_warehouse_stocktransfer_logs
    Private Sub frm_warehouse_stocktransfer_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.EditValue = Date.Today.AddDays(-7)
        dt_end.EditValue = Date.Now
        Load_Logs(dt_start.EditValue, dt_end.EditValue)
    End Sub


    '---- FUNCTIONS ----

    'LOAD LOGS
    Private Sub Load_Logs(startDate As Date, endDate As Date)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT log_id, original_qty, qty, IF(original_qty = 0, 0.00, (original_qty - qty)) AS missing_qty, inv.winmodel, inv.description, FROM_W.store_name AS from_warehouse, TO_W.store_name AS to_warehouse, date_received, rec.first_name received_by, cre.first_name created_by,
                                                concat('ST',LPAD(ims_stock_transfer_logs.transfer_id,5,0)) AS transfer_id, subtransfer_id
                                            FROM ims_stock_transfer_logs
                                            INNER JOIN ims_inventory inv ON inv.pid=ims_stock_transfer_logs.pid
                                            LEFT JOIN ims_stores FROM_W ON FROM_W.store_id=ims_stock_transfer_logs.from_warehouse
                                            LEFT JOIN ims_stores TO_W ON TO_W.store_id=ims_stock_transfer_logs.to_warehouse
                                            LEFT JOIN ims_stock_transfer ON ims_stock_transfer.transfer_id=ims_stock_transfer_logs.transfer_id
                                            LEFT JOIN ims_users AS cre ON cre.usr_id=ims_stock_transfer.created_by
                                            LEFT JOIN ims_users AS rec ON rec.usr_id=ims_stock_transfer_logs.received_by
                                            WHERE date_received BETWEEN @start_date AND @end_date
                                            ORDER BY log_id DESC", conn)
                    cmd.Parameters.AddWithValue("@start_date", startDate)
                    cmd.Parameters.AddWithValue("@end_date", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_logs.DataSource = dt
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : EXPORT
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            Dim saveFileDialog = New SaveFileDialog With {.Filter = "Microsoft Excel (*.xlsx)|*.xlsx"}
            If saveFileDialog.ShowDialog = DialogResult.OK Then
                grid_logs_view.ExportToXlsx(saveFileDialog.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : VIEW
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Load_Logs(dt_start.EditValue, dt_end.EditValue)
    End Sub

End Class