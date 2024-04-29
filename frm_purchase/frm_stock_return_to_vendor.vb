Imports DevExpress.LookAndFeel
Imports MySqlConnector

Public Class frm_return_to_vendor



    '--- ONLOAD ----
    Private Sub frm_purchase_return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturns(False)
        LoadPulloutRequests()
        LoadBatchPullouts()
    End Sub


    '--- FUNCTIONS ----
    Private Sub LoadReturns(is_completed As Boolean)
        Try
            Dim query As String = String.Empty

            If is_completed = True Then
                query = "rs_returns.status = 'Completed'"
            Else
                query = "NOT rs_returns.status = 'Completed'"
            End If

            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand($"SELECT rs_returns.id, qty, qty_returned, ims_inventory.winmodel, ims_inventory.supmodel, ims_inventory.description, serial, rs_returns.type, issue, 
                                                rs_returns.status, approval_winland, rs_returns.created_at, approval_supplier, pullout_id, batch_id, ims_suppliers.supplier, comments, ims_stores.store_name
                                            FROM rs_returns
                                            INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                                            LEFT JOIN ims_stores ON ims_stores.store_id=rs_returns.src_warehouse_id
                                            WHERE { query } AND rs_returns.is_deleted='0'", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                    grid_returns_view.BestFitColumns()
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        End Try
    End Sub

    'LOAD PULLOUTS
    Private Sub LoadPulloutRequests()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT pullout_id, ims_suppliers.supplier, status, creator.first_name AS created_by, created_at, sender.first_name AS sent_by, sent_at
                                            FROM rs_returns_pullout
                                            LEFT JOIN ims_users AS creator ON creator.usr_id=rs_returns_pullout.created_by
                                            LEFT JOIN ims_users AS sender ON sender.usr_id=rs_returns_pullout.sent_by
                                            LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_pullout.supplier_id
                                            WHERE rs_returns_pullout.is_deleted='0'", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_pullouts.DataSource = dt
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        End Try
    End Sub

    'LOAD BATCH
    Private Sub LoadBatchPullouts()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT batch_id, ims_suppliers.supplier, ims_stores.store_name, status, creator.first_name AS created_by, created_at
                                            FROM rs_returns_batch
                                            LEFT JOIN ims_users AS creator ON creator.usr_id=rs_returns_batch.created_by
                                            LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                                            LEFT JOIN ims_stores ON ims_stores.store_id=rs_returns_batch.warehouse_id
                                            WHERE rs_returns_batch.is_deleted='0'", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_batch.DataSource = dt
                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : NEW RETURN
    Private Async Sub btn_new_return_Click(sender As Object, e As EventArgs) Handles btn_new_return.Click
        Await frm_main.LoadFrm(New frm_stock_return_new, "frm_purchase_return_new")
    End Sub

    'BUTTON : NEW PULLOUT REQUEST
    Private Async Sub btn_pullout_Click(sender As Object, e As EventArgs) Handles btn_pullout_request.Click
        Dim frm = New frm_stock_return_pullout
        frm.lbl_status.Visible = False
        frm.btn_delete.Visible = False
        frm.btn_print.Visible = False
        frm.btn_sent.Visible = False
        Await frm_main.LoadFrm(frm, "frm_purchase_return_pullout")
    End Sub

    'BUTTON : NEW BATCH PULLOUT
    Private Async Sub btn_batch_pullout_Click(sender As Object, e As EventArgs) Handles btn_batch_pullout.Click
        Dim frm = New frm_stock_return_batch
        frm.lbl_status.Visible = False
        frm.btn_delete.Visible = False
        frm.btn_print_batch.Visible = False
        frm.btn_arrange.Visible = False
        Await frm_main.LoadFrm(frm, "frm_stock_return_batch")
    End Sub
    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadReturns(IIf(btn_show_completed.Text = "Show Completed", False, True))
        LoadPulloutRequests()
        LoadBatchPullouts()
    End Sub

    'col_action (BUTTON : ACTION)
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        If MsgBox($"Mark as good?{vbCrLf}(ex. repaired, good, etc.)", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim transc = conn.BeginTransaction()

                    Try
                        'UPDATE STATUS OF RETURN UNIT
                        Using cmd = New MySqlCommand("UPDATE rs_returns SET status='Completed', is_good='1' WHERE id=@id", conn, transc)
                            cmd.Parameters.AddWithValue("@id", grid_returns_view.GetFocusedRowCellValue(col_rid))
                            cmd.ExecuteNonQuery()
                        End Using

                        'RETURN TO STOCKS
                        Dim warehouse = String.Concat("ims_", grid_returns_view.GetFocusedRowCellValue(col_warehouse).ToString.Replace(" ", "_").ToLower)
                        Using cmd = New MySqlCommand($"UPDATE {warehouse} tbl
                                                    INNER JOIN rs_returns ON rs_returns.id=@id
                                                    SET on_hold=IFNULL(on_hold, 0)-rs_returns.qty, tbl.qty=tbl.qty+rs_returns.qty 
                                                    WHERE tbl.pid=rs_returns.pid", conn, transc)
                            cmd.Parameters.AddWithValue("@id", grid_returns_view.GetFocusedRowCellValue(col_rid))
                            cmd.ExecuteNonQuery()
                        End Using

                        transc.Commit()
                        MsgBox("Marked as good!", vbInformation, "Information")
                        LoadReturns(IIf(btn_show_completed.Text = "Show Completed", False, True))

                    Catch mysql_e As MySqlException
                        transc.Rollback()
                        MsgBox($"An error occured: {vbCrLf & vbCrLf & mysql_e.Message}", vbCritical, "Error")
                    End Try

                    conn.Close()
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            End Try
        End If
    End Sub

    'VIEW PULLOUT REQUEST
    Private Async Sub btn_open_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_open.ButtonClick
        Dim id = grid_pullouts_view.GetFocusedRowCellValue(col_pullout_id)

        Dim frm = New frm_stock_return_pullout
        frm.Pullout_id = id
        frm.LoadEdit(id)
        Await frm_main.LoadFrm(frm, $"frm_purchase_return_pullout_{id}")
    End Sub

    'BUTTON : SUPPLIER CONFIRMATION
    Private Sub btn_confirmation_Click(sender As Object, e As EventArgs) Handles btn_confirmation.Click
        Dim frm = New frm_stock_return_confirmation
        frm.ShowDialog()
    End Sub

    'BUTTON : OPEN BATCH
    Private Async Sub btn_batch_open_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_batch_open.ButtonClick
        Dim id = grid_batch_view.GetFocusedRowCellValue(col_batch_id)

        Dim frm = New frm_stock_return_batch
        frm.LoadEdit(id)
        Await frm_main.LoadFrm(frm, $"frm_stock_return_batch_{id}")
    End Sub

    'BUTTON : PRINT
    Private Sub btn_print_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_print.ButtonClick
        Dim frm = New frm_stock_return_print
        frm.txt_rid.EditValue = grid_returns_view.GetFocusedRowCellValue(col_rid)
        frm.txt_model.EditValue = grid_returns_view.GetFocusedRowCellValue(col_winmodel)
        frm.se_qty.EditValue = grid_returns_view.GetFocusedRowCellValue(col_qty)

        frm.txt_rid.Enabled = False
        frm.ShowDialog()
    End Sub

    'BUTTON : SHOW COMPLETED
    Private Sub btn_show_completed_Click(sender As Object, e As EventArgs) Handles btn_show_completed.Click
        If btn_show_completed.Text = "Show Completed" Then
            LoadReturns(True)
            btn_show_completed.Text = "Close"
            btn_show_completed.Appearance.BackColor = DXSkinColors.FillColors.Danger
        Else
            LoadReturns(False)
            btn_show_completed.Text = "Show Completed"
            btn_show_completed.Appearance.BackColor = Nothing
        End If
    End Sub

    'SHOW DELIVERY LOGS
    Private Async Sub btn_return_to_vendor_logs_Click(sender As Object, e As EventArgs) Handles btn_return_to_vendor_logs.Click
        Await frm_main.LoadFrm(New frm_stock_return_delivery_logs, "frm_stock_return_delivery_logs")
    End Sub
End Class