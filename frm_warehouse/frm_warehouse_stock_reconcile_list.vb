Imports MySqlConnector

Public Class frm_warehouse_stock_reconcile_list


    '--- ONLOAD ----
    Private Sub frm_warehouse_stock_reconcile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_reconcile()
    End Sub



    '--- FUNCTIONS ----

    'Load Reconcile
    Private Sub load_reconcile()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT LPAD(id,5,0) as id, ims_inventory.winmodel, ims_stores.store_name, qty,  UPPER(reconciled_type) as reconciled_type, ims_reconciled_stocks.status FROM ims_reconciled_stocks
                            inner join ims_stores ON ims_stores.store_id=src_store
                            Inner join ims_inventory ON ims_inventory.pid=item
                            WHERE is_deleted='0' AND NOT ims_reconciled_stocks.status='Completed'", connection)
                cmd.ExecuteNonQuery()
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_stock_transferred.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub





    '--- CONTROLS ----

    'btn_request_transfer
    Private Sub btn_request_transfer_Click(sender As Object, e As EventArgs) Handles btn_request_transfer.Click
        Dim frm = New frm_warehouse_stock_reconcile_new
        frm.ShowDialog()
    End Sub

    'btn_delete
    Private Sub btn_delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete.ButtonClick
        Dim ans = MsgBox("Are you sure you want to delete?", vbYesNo + vbQuestion, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_reconciled_stocks SET is_deleted='1' WHERE id=@id", connection)
                cmd.Parameters.AddWithValue("@id", CInt(grid_stock_transferred_view.GetFocusedRowCellValue(col_id)))
                cmd.ExecuteNonQuery()
            End Using

            load_reconcile()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_reconcile()
    End Sub

    'FocusedRowChanged
    Private Sub grid_stock_transferred_view_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grid_stock_transferred_view.FocusedRowChanged
        Dim status = grid_stock_transferred_view.GetFocusedRowCellValue(col_status)
        If status = "Pending" Or status = "Completed" Then
            btn_completed.Enabled = False
        Else
            btn_completed.Enabled = True
        End If
    End Sub

    'btn_completed
    Private Sub btn_completed_Click(sender As Object, e As EventArgs) Handles btn_completed.Click
        Dim id As Integer = grid_stock_transferred_view.GetFocusedRowCellValue(col_id)
        Dim ans = MsgBox("Mark this as Completed?", vbYesNo + vbQuestion, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_reconciled_stocks SET status='Completed' WHERE id=@id", connection)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.ExecuteNonQuery()
                btn_completed.Enabled = False
            End Using

            load_reconcile()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'lbl_completed
    Private Sub lbl_completed_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_completed.LinkClicked
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT LPAD(id,5,0) as id, ims_inventory.winmodel, ims_stores.store_name, qty,  UPPER(reconciled_type) as reconciled_type, ims_reconciled_stocks.status FROM ims_reconciled_stocks
                            inner join ims_stores ON ims_stores.store_id=src_store
                            Inner join ims_inventory ON ims_inventory.pid=item
                            WHERE is_deleted='0' AND ims_reconciled_stocks.status='Completed' AND ims_stores.store_name=@store_name", connection)
                cmd.Parameters.AddWithValue("@store_name", frm_main.lbl_user_designation.Text)
                cmd.ExecuteNonQuery()
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_stock_transferred.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class