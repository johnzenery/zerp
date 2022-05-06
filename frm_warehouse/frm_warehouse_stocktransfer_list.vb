Imports MySqlConnector

Public Class frm_warehouse_stocktransfer_list

    '--- ONLOAD ---
    Private Sub frm_warehouse_stocktransfer_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_stock_transfers()
        load_sub_transfers()
    End Sub



    '--- FUNCTIONS

    'Load All Stock Transfers
    Private Sub load_stock_transfers()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT concat('ST',LPAD(transfer_id,5,0)) AS transfer_id, status, created_at, linked_warehouse,
                                    transfer_type, ims_stores.store_name AS  src_warehouse, ims_users.first_name AS created_by, total_cbm, total_kgs
                                    FROM ims_stock_transfer 
                                    INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                                    INNER JOIN ims_users ON ims_users.usr_id=ims_stock_transfer.created_by
                                    WHERE is_deleted=0
                                    ORDER BY transfer_id DESC", connection) 'AND NOT status='Completed'
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_stock_transfers.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Transfers
    Private Sub load_sub_transfers()

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim query = "SELECT sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as root_transfer_id, transfer_type, status,
                                    SRC.store_name AS from_warehouse, RECVR.store_name AS to_warehouse, delivered_by
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    ORDER BY sub_transfer_id DESC" 'AND NOT status='Transferred'


                Dim cmd = New MySqlCommand(query, connect)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_sub_transfer.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub






    '--- CONTROLS ---
    Private Sub btn_new_stockTransfer_Click(sender As Object, e As EventArgs) Handles btn_new_stockTransfer.Click
        newTransfer_contextMenu.Show(btn_new_stockTransfer, New Point(btn_new_stockTransfer.Width - btn_new_stockTransfer.Width, btn_new_stockTransfer.Height))
    End Sub

    'Distribute Strip Menu
    Private Sub stripMenu_distribute_Click(sender As Object, e As EventArgs) Handles stripMenu_distribute.Click
        Dim frm = New frm_warehouse_stocktransfer_distribute_new
        frm.ShowDialog()
        load_stock_transfers()
    End Sub

    'Request Strip Menu
    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        Dim frm = New frm_warehouse_stocktransfer_request_new
        frm.ShowDialog()
        load_stock_transfers()
    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_stock_transfers()
        load_sub_transfers()
    End Sub

    'btn_view
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick

        If grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type).Equals("Distribute") Then
            Dim frm = New frm_warehouse_stocktransfer_distribute_new
            frm.LoadEdit(grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id).ToString.Replace("ST", ""))

        ElseIf grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type).Equals("Request") Then
            Dim frm = New frm_warehouse_stocktransfer_request_new
            frm.LoadEdit(grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id).ToString.Replace("ST", ""))
        End If

    End Sub

    Private Sub btn_cancel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_cancel.ButtonClick
        Dim frm = New frm_warehouse_stocktransfer_cancel_dialog
        frm.lbl_sub_transfer_id.Text = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_id)
        frm.lbl_stock_transfer_id.Text = grid_sub_transfer_view.GetFocusedRowCellValue(col_root_transfer_id)
        frm.lbl_transfer_type.Text = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_type)
        Dim status = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_status)
        frm.lbl_status.Text = status

        'IF Completely Transferred
        If status.Equals("Transferred") Then
            MsgBox("Already Transferred! Nothing was changed.", vbInformation, "Information")
            Return
        End If

        'IF Pending Cancellation
        If status.Equals("Pending Cancellation") Then
            MsgBox("Cancellation process is on-going...", vbInformation, "Information")
            Return
        End If

        'IF Cancelled
        If status.Equals("Cancelled") Then
            MsgBox("Already Cancelled!", vbInformation, "Information")
            Return
        End If

        If frm.ShowDialog = DialogResult.OK Then
            If status.Equals("Packed") Or status.Equals("Dispatched") Then

                Try
                    Using connect = New MySqlConnection(str)
                        connect.Open()
                        Using cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub SET status='Pending Cancellation' WHERE sub_transfer_id=@sid", connect)
                            cmd.Parameters.AddWithValue("@sid", grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_id))
                            If cmd.ExecuteNonQuery > 0 Then
                                MsgBox("Sent back to Package Dept. for unpacking!", vbInformation, "Information")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try


            ElseIf status.Equals("Arranging") Then

                Try
                    Using connect = New MySqlConnection(str)
                        connect.Open()
                        Using cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub SET status='Cancelled' WHERE sub_transfer_id=@sid", connect)
                            cmd.Parameters.AddWithValue("@sid", grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_id))
                            If cmd.ExecuteNonQuery > 0 Then
                                MsgBox("Cancelled!", vbInformation, "Information")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try


            End If

            'Refresh Data
            load_sub_transfers()

        End If

    End Sub
End Class