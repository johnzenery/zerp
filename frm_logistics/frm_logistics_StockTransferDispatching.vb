Imports MySqlConnector

Public Class frm_logistics_StockTransferDispatching
    Private Sub frm_logistics_StockTransferDispatching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStockTransfers()
    End Sub



    '--- FUNCTIONS ---
    Private Sub LoadStockTransfers()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT 
                            CONCAT('ST', LPAD(root_transfer_id, 5, '0')) root_transfer_id, 
                            (LPAD(sub_transfer_id, 5, '0')) sub_transfer_id,
                            src.store_name AS from_store, dest.store_name AS to_store, total_cbm, total_kgs, tbl.transfer_type, STATUS 
                            FROM ims_stock_transfer_sub AS tbl
                            INNER JOIN ims_stores AS src ON src.store_id=tbl.src_store_id
                            INNER JOIN ims_stores AS dest ON dest.store_id=tbl.recvr_store_id
                            WHERE (tbl.status='Packed' OR tbl.status='Dispatched')", connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_stock_transfers.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Dispatch Button
    Private Sub btn_dispatch_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_dispatch.ButtonClick
        Dim sub_stid = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_stid)

        Dim frm = New frm_warehouse_stocktransfer_dispatch_dialog
        frm.txt_transfer_id.Text = sub_stid
        If frm.ShowDialog() = vbOK Then
            LoadStockTransfers()
        End If
    End Sub
End Class