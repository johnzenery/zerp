Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports MySqlConnector


Public Class frm_admin_approval


    '--- ONLOAD ---
    Private Sub frm_admin_approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Tab()
        load_data()
    End Sub






    '--- FUNCTIONS ----
    Public Sub load_data()
        Dim connection = New MySqlConnection(str)

        Try
            connection.Open()

            'Show Products
            If Me.Tag = "frm_admin_approval_products" Then
                Using units_cmd = New MySqlCommand("SELECT pid, winmodel, description, status FROM ims_inventory WHERE NOT status='Active' ORDER BY FIELD(status, 'For Approval', 'On-Hold', 'Discontinued', '')", connection)
                    units_cmd.ExecuteNonQuery()
                    Dim dt_units = New DataTable
                    Dim da_units = New MySqlDataAdapter(units_cmd)
                    da_units.Fill(dt_units)
                    grid_approval_units.DataSource = dt_units
                    grid_approval_units_view.ActiveFilterString = "[status] <> 'Discontinued'"
                End Using
            End If

            'Show Purchase Orders
            If Me.Tag = "frm_admin_approval_purchase_orders" Then
                Using purchase_cmd = New MySqlCommand("SELECT concat('PO',LPAD(purchase_id,5,0)) as purchase_id, ims_suppliers.supplier, date_generated, status, total, ims_users.first_name AS created_by
                                        FROM `ims_purchase`
                                        LEFT JOIN ims_users ON ims_users.usr_id=ims_purchase.created_by
                                        LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase.supplier 
                                        WHERE (status='For Approval' OR status='Revised (Approved)' OR status='Revised (Sent)' OR status='Revised (Partial)' OR status='Revised (Completed)') AND ims_purchase.deleted=0", connection)
                    purchase_cmd.ExecuteNonQuery()
                    Dim dt_purchase = New DataTable
                    Dim da_purchase = New MySqlDataAdapter(purchase_cmd)
                    da_purchase.Fill(dt_purchase)
                    grid_po.DataSource = dt_purchase
                End Using
            End If

            'Show Transfer Approvals
            If Me.Tag = "frm_admin_approval_stock_transfers" Then
                Using transfer_cmd = New MySqlCommand("SELECT CONCAT('ST', LPAD(transfer_id, 5,0)) as transfer_id, transfer_type, (SELECT store_name FROM ims_stores WHERE store_id=src_store_id) as transfer_from,
                                 linked_warehouse AS transfer_to, status, ims_users.first_name AS created_by, created_at
                                FROM ims_stock_transfer 
                                INNER JOIN ims_users ON ims_users.usr_id=ims_stock_transfer.created_by
                                WHERE status = 'For Approval' AND is_deleted=0", connection)
                    transfer_cmd.ExecuteNonQuery()
                    Dim dt_transfer = New DataTable
                    Dim da_transfer = New MySqlDataAdapter(transfer_cmd)
                    da_transfer.Fill(dt_transfer)
                    grid_transfer.DataSource = dt_transfer
                End Using
            End If

            'Show Transfer Reports
            If Me.Tag = "frm_admin_approval_transfer_reports" Then
                Using transfer_report_cmd = New MySqlCommand("SELECT transfer_report_id, CONCAT('ST', LPAD(transfer_id, 5,0)) AS transfer_id, ims_users.first_name AS reported_by, received_date, status,
                                src_tbl.store_name AS src_storeName, des_tbl.store_name AS des_storeName
                                FROM ims_stock_transfer_reports
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_stock_transfer_reports.received_by
                                LEFT JOIN ims_stores AS src_tbl ON src_tbl.store_id=ims_stock_transfer_reports.source_store_id
                                LEFT JOIN ims_stores AS des_tbl ON des_tbl.store_id=ims_stock_transfer_reports.destination_store_id
                                WHERE status = 'Pending'", connection)
                    transfer_report_cmd.ExecuteNonQuery()
                    Dim dt_transfer = New DataTable
                    Dim da_transfer = New MySqlDataAdapter(transfer_report_cmd)
                    da_transfer.Fill(dt_transfer)
                    grid_transferReport.DataSource = dt_transfer
                End Using
            End If

            'Show Reconcilations
            If Me.Tag = "frm_admin_approval_reconcilations" Then
                Using reconcilations_cmd = New MySqlCommand("SELECT LPAD(id,5,0) as id, ims_inventory.winmodel, ims_stores.store_name, qty,  UPPER(reconciled_type) as reconciled_type, ims_reconciled_stocks.status, notes, ims_users.first_name as requested_by FROM ims_reconciled_stocks
                            INNER JOIN ims_stores ON ims_stores.store_id=src_store
                            INNER JOIN ims_users ON ims_users.usr_id=reconciled_by
                            INNER JOIN ims_inventory ON ims_inventory.pid=item
                            WHERE is_deleted='0' AND ims_reconciled_stocks.status='Pending'", connection)
                    reconcilations_cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(reconcilations_cmd)
                    da.Fill(dt)
                    grid_stock_reconcilation.DataSource = dt
                    cb_approved.Checked = False
                End Using
            End If

            'Show Sales Returns
            If Me.Tag = "frm_admin_approval_sales_returns" Then
                Using sr_cmd = New MySqlCommand("SELECT concat('SR',LPAD(sales_return_id,5,0)) as srid, ims_customers.first_name AS customer, amount, ims_stores.store_name, created_at 
                            FROM ims_sales_returns
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_sales_returns.store_id
                            WHERE ims_sales_returns.is_deleted='0' AND ims_sales_returns.status='Pending' ORDER BY sales_return_id DESC", connection)
                    sr_cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(sr_cmd)
                    da.Fill(dt)
                    grid_sales_returns.DataSource = dt
                End Using
            End If

            'Show Pullout Requests
            If Me.Tag = "frm_admin_approval_pullout_requests" Then
                Using pr_cmd = New MySqlCommand("SELECT pullout_id, ims_suppliers.supplier, rs_returns_pullout.status, ims_users.first_name AS created_by, created_at
                            FROM rs_returns_pullout
                            INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns_pullout.supplier_id
                            INNER JOIN ims_users ON ims_users.usr_id=rs_returns_pullout.created_by
                            WHERE rs_returns_pullout.is_deleted='0' AND rs_returns_pullout.status='For Approval' 
                            ORDER BY created_at DESC", connection)
                    pr_cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(pr_cmd)
                    da.Fill(dt)
                    grid_pullouts.DataSource = dt
                End Using
            End If

            'Show Stock Returns : For Approval
            If Me.Tag = "frm_admin_approval_stock_returns" Then
                Using pr_cmd = New MySqlCommand("SELECT rs_returns.id, qty, qty_returned, ims_inventory.winmodel, 
                                                        ims_inventory.supmodel, serial, rs_returns.type, issue, rs_returns.status, pullout_id, ims_suppliers.supplier, comments, ims_stores.store_name AS warehouse
                                            FROM rs_returns
                                            INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            INNER JOIN ims_stores ON ims_stores.store_id=rs_returns.src_warehouse_id
                                            LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                                            WHERE NOT rs_returns.status='Completed' AND approval_winland = 'Pending' AND rs_returns.is_deleted='0'", connection)
                    pr_cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(pr_cmd)
                    da.Fill(dt)
                    grid_stock_returns.DataSource = dt
                End Using
            End If

            'Show Quotation
            If Me.Tag = "frm_admin_approval_quotations" Then
                Using quotation_cmd = New MySqlCommand("SELECT concat('Q',LPAD(quotation_id,5,0)) as quotation_id, created_at, company, status, ims_users.first_name prepared_by
                            FROM ims_quotations 
                            LEFT JOIN ims_users ON ims_users.usr_id=ims_quotations.prepared_by
                            WHERE is_converted='0' AND is_deleted='0' AND status='Pending' ORDER BY quotation_id DESC", connection) 'AND NOW() BETWEEN created_at AND created_at + INTERVAL 30 DAY 
                    quotation_cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(quotation_cmd)
                    da.Fill(dt)
                    grid_quotation.DataSource = dt
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            connection.Close()
        End Try

    End Sub

    'Load Tab
    Private Sub Load_Tab()

        'Set All Page to Invisible
        For Each tab As XtraTabPage In XtraTabControl1.TabPages
            tab.PageVisible = False
        Next

        Dim tag As String = Me.Tag

        Select Case tag
            Case "frm_admin_approval_purchase_orders"
                XtraTabPage_purchase_orders.PageVisible = True
                Me.Text = "Purchase Order Approvals"
            Case "frm_admin_approval_stock_transfers"
                XtraTabPage_stock_transfers.PageVisible = True
                Me.Text = "Stock Transfer Approvals"
            Case "frm_admin_approval_quotations"
                XtraTabPage_quotaions.PageVisible = True
                Me.Text = "Quotation Approvals"
            Case "frm_admin_approval_sales_returns"
                XtraTabPage_sales_return.PageVisible = True
                Me.Text = "Sales Return Approvals"
            Case "frm_admin_approval_pullout_requests"
                XtraTabPage_pullout_requests.PageVisible = True
                Me.Text = "Pullout Requests"
            Case "frm_admin_approval_reconcilations"
                XtraTabPage_reconcilations.PageVisible = True
                Me.Text = "Reconcilation Approvals"
            Case "frm_admin_approval_transfer_reports"
                XtraTabPage_transfer_reports.PageVisible = True
                Me.Text = "Transfer Report Approvals"
            Case "frm_admin_approval_products"
                XtraTabPage_products.PageVisible = True
                Me.Text = "Product Approvals"
            Case "frm_admin_approval_stock_returns"
                XtraTabPage_pullout_requests.PageVisible = True
                Me.Text = "Stock Returns Approval"
        End Select

    End Sub




    '--- CONTROLS ---

    'Items/Units Approval
    Private Sub grid_approval_units_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_approval_units_view.RowCellClick

        If grid_approval_units_view.FocusedColumn.Name.Equals(col_pid.Name) Then
            Dim frm = New frm_product_new
            frm.cbb_status.Enabled = True
            frm.UpdateInformation(CInt(grid_approval_units_view.GetFocusedRowCellValue(col_pid)), "approval")
            If frm.ShowDialog = DialogResult.OK Then
                load_data()
            End If
        End If

    End Sub

    'Purchase Order Approval
    Private Sub grid_po_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_po_view.RowCellClick

        If grid_po_view.FocusedColumn.Name.Equals(col_poid.Name) Then
            Dim frm = New frm_purchaseorder_edit
            frm.txt_poid.Text = grid_po_view.GetFocusedRowCellValue(col_poid)
            frm.is_approval = True
            frm.btn_recall.Visible = False

            frm.Init("_approval")

            If frm.ShowDialog() = DialogResult.OK Then
                load_data()
            End If

        End If
    End Sub

    'Quotation Approval
    Private Sub grid_quotation_view_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grid_quotation_view.RowCellClick
        If grid_quotation_view.FocusedColumn.Name.Equals(col_quotation_id.Name) Then
            ' Dim frm = New frm_sales_view_quotation()
            Dim quotation_id = grid_quotation_view.GetFocusedRowCellValue(col_quotation_id).ToString().Replace("Q", String.Empty)
            'frm.load_data(quotation_id)
            'frm.btn_approved.Visible = True
            'frm.btn_approved.Location = New Point(1060, 14)
            'frm.btn_decline.Visible = True
            'frm.btn_transfer.Visible = False
            'frm.btn_save.Enabled = False

            'frm.ShowDialog()
            'load_data()

            Dim frm = New frm_sales_quotation_new()
            'frm_main.LoadFrm(frm, "quotation_approval_" & quotation_id)
            frm.LoadData(quotation_id)
            frm.btn_response.Enabled = True
            frm.grid_search_view.OptionsBehavior.Editable = False
            frm.grid_quotation_view.OptionsBehavior.ReadOnly = True
            frm.ShowDialog()
            load_data()

        End If
    End Sub

    'Stock Reconcilation Approval
    Private Sub grid_stock_reconcilation_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_stock_reconcilation_view.RowCellClick
        If grid_stock_reconcilation_view.FocusedColumn.Name.Equals(col_reconcile_id.Name) Then
            Dim id = grid_stock_reconcilation_view.GetFocusedRowCellValue(col_reconcile_id)

            Dim frm = New frm_warehouse_stock_reconcile_new
            frm.Text = "Reconcile Request #" & id
            frm.lbl_title.Text = "Reconcile Request #" & id

            With grid_stock_reconcilation_view
                frm.cbb_stores.SelectedText = .GetFocusedRowCellValue(col_reconcile_store)
                frm.cbb_stores.Enabled = False

                frm.cbb_model.Text = .GetFocusedRowCellValue(col_reconcile_item)
                frm.cbb_model.Enabled = False

                Dim type = .GetFocusedRowCellValue(col_reconcile_type)
                If type.Equals("ADD") Then
                    frm.rb_add.Checked = True
                    frm.rb_deduct.Enabled = False
                End If
                If type.Equals("DEDUCT") Then
                    frm.rb_deduct.Checked = True
                    frm.rb_add.Enabled = False
                End If

                frm.num_reconcile.Value = .GetFocusedRowCellValue(col_reconcile_qty)
                frm.num_reconcile.Enabled = False

                frm.txt_memo.Text = .GetFocusedRowCellValue(col_reconcile_notes)
                frm.txt_memo.ReadOnly = True
                frm.txt_memo.Properties.UseReadOnlyAppearance = False

                frm.btn_submit.Text = "Approve"
                frm.btn_cancel.Text = "Decline"
                frm.btn_cancel.Appearance.BackColor = Color.Crimson
            End With
            frm.ShowDialog()
            load_data()
        End If
    End Sub

    'Sales Returns Approval
    Private Sub grid_sales_returns_view_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grid_sales_returns_view.RowCellClick
        If grid_sales_returns_view.FocusedColumn.Name.Equals(col_srid.Name) Then
            Dim frm = New frm_sales_return_new
            'frm.Show()
            frm.LoadEdit(grid_sales_returns_view.GetFocusedRowCellValue(col_srid).ToString.Replace("SR", String.Empty))
            frm.Text = "Sales Return"
            frm.lbl_title.Text = "Sales Return - Approval"
            frm.btn_create.Visible = False
            frm.btn_clear.Visible = False
            frm.btn_save.Visible = False
            frm.btn_delete.Visible = False
            frm.btn_approved.Visible = True
            frm.btn_print.Visible = False
            frm.btn_approved.Location = frm.btn_create.Location
            frm.cbb_customer.ReadOnly = True
            If frm.ShowDialog = DialogResult.OK Then
                load_data()
            End If
        End If
    End Sub

    'Stock Transfer Approval
    Private Sub btn_view_stockTransfer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_stockTransfer.ButtonClick
        Dim stid = CInt(grid_transfer_view.GetFocusedRowCellValue(col_transfer_id).ToString.Replace("ST", String.Empty))
        Dim status = grid_transfer_view.GetFocusedRowCellValue(col_transfer_status)
        Dim transfer_type = grid_transfer_view.GetFocusedRowCellValue(col_transferType)

        If transfer_type = "Distribute" Then
            Dim frm = New frm_warehouse_stocktransfer_new_distribute
            frm.LoadEdit(stid)
            frm.lbl_title.Text = "Stock Transfer (Dist.) - Approval"
            frm.btn_approved.Visible = True
            frm.btn_save.Enabled = False
            frm.btn_print.Enabled = False
            frm.btn_delete.Enabled = False
            frm.ShowDialog()

        ElseIf transfer_type = "Request" Then
            Dim frm = New frm_warehouse_stocktransfer_new_request
            frm.LoadEdit(stid)
            frm.lbl_title.Text = "Stock Transfer (Req.) - Approval"
            frm.btn_approved.Visible = True
            frm.btn_save.Enabled = False
            frm.btn_print.Enabled = False
            frm.btn_delete.Enabled = False
            frm.ShowDialog()

        End If

        load_data()
    End Sub

    'Stock Transfer Report
    Private Sub btn_view_report_stockTransfer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_report_stockTransfer.ButtonClick
        Dim reportID = CInt(grid_transferReport_view.GetFocusedRowCellValue(col_reportID))

        Dim frm = New frm_admin_transfer_reports
        frm.lbl_reportID.Text = reportID
        frm.ShowDialog()
        load_data()
    End Sub

    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_data()
    End Sub

    'RECONCILATIONS : SHOW/HIDE APPROVED
    Private Sub cb_completed_CheckedChanged(sender As Object, e As EventArgs) Handles cb_approved.CheckedChanged
        Dim status As String = String.Empty

        If cb_approved.Checked = True Then
            status = "Approved"
            cb_show_declined.Enabled = False
        Else
            status = "Pending"
            cb_show_declined.Enabled = True
        End If

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT LPAD(id,5,0) as id, ims_inventory.winmodel, ims_stores.store_name, qty,  UPPER(reconciled_type) as reconciled_type, ims_reconciled_stocks.status, notes, ims_users.first_name as requested_by FROM ims_reconciled_stocks
                            INNER JOIN ims_stores ON ims_stores.store_id=src_store
                            INNER JOIN ims_users ON ims_users.usr_id=reconciled_by
                            INNER JOIN ims_inventory ON ims_inventory.pid=item
                            WHERE is_deleted='0' AND ims_reconciled_stocks.status='" & status & "'
                            ORDER BY id DESC", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_stock_reconcilation.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'RECONCILATIONS : SHOW/HIDE DECLINED
    Private Sub cb_show_declined_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_declined.CheckedChanged
        Dim status As String = String.Empty

        If cb_show_declined.Checked = True Then
            status = "Declined"
            cb_approved.Enabled = False
        Else
            status = "Pending"
            cb_approved.Enabled = True
        End If

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT LPAD(id,5,0) as id, ims_inventory.winmodel, ims_stores.store_name, qty,  UPPER(reconciled_type) as reconciled_type, ims_reconciled_stocks.status, notes, ims_users.first_name as requested_by FROM ims_reconciled_stocks
                            INNER JOIN ims_stores ON ims_stores.store_id=src_store
                            INNER JOIN ims_users ON ims_users.usr_id=reconciled_by
                            INNER JOIN ims_inventory ON ims_inventory.pid=item
                            WHERE is_deleted='0' AND ims_reconciled_stocks.status='" & status & "'
                            ORDER BY id DESC", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_stock_reconcilation.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : SHOW PULLOUT REQUESTS
    Private Sub btn_show_pullout_request_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_show_pullout_request.ButtonClick
        Dim id = grid_pullouts_view.GetFocusedRowCellValue(col_pullout_id)

        Dim frm = New frm_stock_return_pullout
        frm.btn_create.Visible = False
        frm.btn_delete.Enabled = False

        frm.Pullout_id = id
        frm.LoadEdit(id)
        If frm.ShowDialog() = DialogResult.OK Then
            load_data()
        End If

    End Sub

    'BUTTON : STOCK RETURNS 'APPROVED'
    Private Sub btn_stockreturn_approved_Click(sender As Object, e As EventArgs) Handles btn_stockreturn_approved.Click
        If MsgBox($"Are you sure?{vbCrLf & vbCrLf}Status:  Approved", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Dim selected_rows = grid_stock_returns_view.GetSelectedRows

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Using trans = conn.BeginTransaction
                        Try
                            Using cmd = New MySqlCommand("UPDATE rs_returns SET approval_winland='Approved' WHERE id=@id", conn, trans)
                                cmd.Parameters.AddWithValue("@id", 0)
                                cmd.Prepare()

                                For i = 0 To selected_rows.Length - 1
                                    cmd.Parameters("@id").Value = grid_stock_returns_view.GetRowCellValue(selected_rows(i), col_stockreturn_rid)
                                    cmd.ExecuteNonQuery()
                                Next

                                trans.Commit()
                                MsgBox("Approved!", vbInformation, "Information")
                                load_data()

                            End Using
                        Catch ex As Exception
                            trans.Rollback()
                            MsgBox(ex.Message, vbCritical, "Error")
                        End Try
                    End Using

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'BUTTON : STOCK RETURNS 'DECLINE'
    Private Sub btn_stockreturn_decline_Click(sender As Object, e As EventArgs) Handles btn_stockreturn_decline.Click
        If MsgBox($"Are you sure?{vbCrLf & vbCrLf}Status:  Declined", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Dim selected_rows = grid_stock_returns_view.GetSelectedRows

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Using trans = conn.BeginTransaction
                        Try
                            Using cmd = New MySqlCommand("UPDATE rs_returns SET approval_winland='Declined' WHERE id=@id", conn, trans)
                                cmd.Parameters.AddWithValue("@id", 0)
                                cmd.Prepare()

                                For i = 0 To selected_rows.Length - 1
                                    cmd.Parameters("@id").Value = grid_stock_returns_view.GetRowCellValue(selected_rows(i), col_stockreturn_rid)
                                    cmd.ExecuteNonQuery()
                                Next

                                trans.Commit()
                                MsgBox("Approved!", vbInformation, "Information")
                                load_data()

                            End Using
                        Catch ex As Exception
                            trans.Rollback()
                            MsgBox(ex.Message, vbCritical, "Error")
                        End Try
                    End Using

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub


End Class