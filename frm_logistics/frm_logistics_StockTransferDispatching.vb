Imports MySqlConnector

Public Class frm_logistics_StockTransferDispatching
    Private Sub frm_logistics_StockTransferDispatching_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStockTransfers()
    End Sub



    '--- FUNCTIONS ---
    Private Sub LoadStockTransfers()

        Dim filter = IIf(Set_Restriction(), "AND src_store_id='" & frm_main.lbl_user_designation_id.Text & "'", "")

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
                            WHERE (tbl.status='Packed' OR tbl.status='Dispatched') " & filter, connection)
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

    'RESTRICTION
    Private Function Set_Restriction()
        Dim result As Boolean = False
        'LIMIT ACCESS TO ADMINISTRATOR, PURCHASE MANAGER, WAREHOUSE ADMIN
        If Not (frm_main.lbl_user_role_id.Text = 1 Or
            frm_main.lbl_user_role_id.Text = 3 Or
            frm_main.lbl_user_role_id.Text = 11) Then
            result = True
        End If
        Return result
    End Function

    'Dispatch Button
    Private Sub btn_dispatch_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_dispatch.ButtonClick
        Dim sub_stid = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_stid)
        Dim status = grid_stock_transfers_view.GetFocusedRowCellValue(col_status)

        If status.Equals("Packed") Then
            Dim frm = New frm_warehouse_stocktransfer_dispatch_dialog
            frm.txt_transfer_id.Text = sub_stid
            If frm.ShowDialog() = vbOK Then
                LoadStockTransfers()
            End If
        ElseIf status.Equals("Dispatched") Then
            MsgBox("Already dispatched!", vbInformation, "Information")
        End If

    End Sub
End Class