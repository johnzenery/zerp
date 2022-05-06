Imports DevExpress.XtraGrid.Views.Grid
Imports MySqlConnector


Public Class frm_admin_approval


    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ---
    Private Sub frm_admin_approval_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub






    '--- FUNCTIONS ----
    Public Sub load_data()

        Try
            conn.Open()

            'Show Units
            Using units_cmd = New MySqlCommand("SELECT pid, winmodel, description, status FROM ims_inventory WHERE NOT status='Active' ORDER BY FIELD(status, 'For Approval', 'On-Hold', 'Discontinued', '')", conn)
                units_cmd.ExecuteNonQuery()
                Dim dt_units = New DataTable
                Dim da_units = New MySqlDataAdapter(units_cmd)
                da_units.Fill(dt_units)
                grid_approval_units.DataSource = dt_units
                grid_approval_units_view.ActiveFilterString = "[status] <> 'Discontinued'"
            End Using

            'Show Purchase Orders
            Using purchase_cmd = New MySqlCommand("SELECT concat('PO',LPAD(purchase_id,5,0)) as purchase_id, ims_suppliers.supplier, date_generated, status FROM `ims_purchase`
                                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase.supplier WHERE (status='For Approval' OR status='Revised (Approved)' OR status='Revised (Sent)' OR status='Revised (Partial)' OR status='Revised (Completed)') AND deleted=0", conn)
                purchase_cmd.ExecuteNonQuery()
                Dim dt_purchase = New DataTable
                Dim da_purchase = New MySqlDataAdapter(purchase_cmd)
                da_purchase.Fill(dt_purchase)
                grid_po.DataSource = dt_purchase
            End Using

            'Show Transfer Approvals
            Using transfer_cmd = New MySqlCommand("SELECT CONCAT('ST', LPAD(transfer_id, 5,0)) as transfer_id, transfer_type, (SELECT store_name FROM ims_stores WHERE store_id=src_store_id) as transfer_from,
                                 linked_warehouse AS transfer_to, status, ims_users.first_name AS created_by, created_at
                                FROM ims_stock_transfer 
                                INNER JOIN ims_users ON ims_users.usr_id=ims_stock_transfer.created_by
                                WHERE status = 'For Approval' AND is_deleted=0", conn)
                transfer_cmd.ExecuteNonQuery()
                Dim dt_transfer = New DataTable
                Dim da_transfer = New MySqlDataAdapter(transfer_cmd)
                da_transfer.Fill(dt_transfer)
                grid_transfer.DataSource = dt_transfer
            End Using

            'Show Transfer Reports
            Using transfer_report_cmd = New MySqlCommand("SELECT transfer_report_id, CONCAT('ST', LPAD(transfer_id, 5,0)) AS transfer_id, ims_users.first_name AS reported_by, received_date, status,
                                src_tbl.store_name AS src_storeName, des_tbl.store_name AS des_storeName
                                FROM ims_stock_transfer_reports
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_stock_transfer_reports.received_by
                                LEFT JOIN ims_stores AS src_tbl ON src_tbl.store_id=ims_stock_transfer_reports.source_store_id
                                LEFT JOIN ims_stores AS des_tbl ON des_tbl.store_id=ims_stock_transfer_reports.destination_store_id
                                WHERE status = 'Pending'", conn)
                transfer_report_cmd.ExecuteNonQuery()
                Dim dt_transfer = New DataTable
                Dim da_transfer = New MySqlDataAdapter(transfer_report_cmd)
                da_transfer.Fill(dt_transfer)
                grid_transferReport.DataSource = dt_transfer
            End Using

            'Show Reconcilations
            Using reconcilations_cmd = New MySqlCommand("SELECT LPAD(id,5,0) as id, ims_inventory.winmodel, ims_stores.store_name, qty,  UPPER(reconciled_type) as reconciled_type, ims_reconciled_stocks.status, notes, ims_users.first_name as requested_by FROM ims_reconciled_stocks
                            INNER JOIN ims_stores ON ims_stores.store_id=src_store
                            INNER JOIN ims_users ON ims_users.usr_id=reconciled_by
                            INNER JOIN ims_inventory ON ims_inventory.pid=item
                            WHERE is_deleted='0' AND ims_reconciled_stocks.status='Pending'", conn)
                reconcilations_cmd.ExecuteNonQuery()
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(reconcilations_cmd)
                da.Fill(dt)
                grid_stock_reconcilation.DataSource = dt
            End Using

            'Show Returns
            Using sr_cmd = New MySqlCommand("SELECT concat('SR',LPAD(sales_return_id,5,0)) as srid, ims_customers.first_name AS customer, amount FROM ims_sales_returns
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                            WHERE ims_sales_returns.is_deleted='0' AND ims_sales_returns.status='Pending' ORDER BY sales_return_id DESC", conn)
                sr_cmd.ExecuteNonQuery()
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(sr_cmd)
                da.Fill(dt)
                grid_sales_returns.DataSource = dt
            End Using

            'Show Quotation
            Using quotation_cmd = New MySqlCommand("SELECT concat('Q',LPAD(quotation_id,5,0)) as quotation_id, company, status FROM ims_quotations 
                            WHERE is_converted='0' AND is_deleted='0' AND NOW() BETWEEN created_at AND created_at + INTERVAL 30 DAY AND status='Pending' ORDER BY quotation_id DESC", conn)
                quotation_cmd.ExecuteNonQuery()
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(quotation_cmd)
                da.Fill(dt)
                grid_quotation.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub





    '--- CONTROLS ---

    'Items/Units Approval
    Private Sub grid_approval_units_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_approval_units_view.RowCellClick

        If grid_approval_units_view.FocusedColumn.Name.Equals(col_pid.Name) Then
            frm_product_new.cbb_status.Enabled = True
            frm_product_new.UpdateInformation(CInt(grid_approval_units_view.GetFocusedRowCellValue(col_pid)), "approval")
        End If

    End Sub

    'Purchase Order Approval
    Private Sub grid_po_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_po_view.RowCellClick

        If grid_po_view.FocusedColumn.Name.Equals(col_poid.Name) Then
            Dim frm = New frm_purchaseorder_edit
            frm.txt_poid.Text = grid_po_view.GetFocusedRowCellValue(col_poid)
            frm.btn_approved.Visible = True
            frm.Init("_approval")
            frm.ShowDialog()
            load_data()
        End If
    End Sub

    'Quotation Approval
    Private Sub grid_quotation_view_RowCellClick(sender As Object, e As RowCellClickEventArgs) Handles grid_quotation_view.RowCellClick
        If grid_quotation_view.FocusedColumn.Name.Equals(col_quotation_id.Name) Then
            Dim frm = New frm_sales_view_quotation()
            frm.load_data(grid_quotation_view.GetFocusedRowCellValue(col_quotation_id).ToString().Replace("Q", ""))
            frm.btn_approved.Visible = True
            frm.btn_approved.Location = New Point(1060, 14)
            frm.btn_transfer.Visible = False
            frm.btn_save.Enabled = False
            frm.grid_quotation.ReadOnly = True
            frm.ShowDialog()
            Me.load_data()
        End If
    End Sub

    'Stock Reconcilation Approval
    Private Sub grid_stock_reconcilation_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_stock_reconcilation_view.RowCellClick
        If grid_stock_reconcilation_view.FocusedColumn.Name.Equals(col_reconcile_id.Name) Then
            Dim id = grid_stock_reconcilation_view.GetFocusedRowCellValue(col_reconcile_id)

            Dim frm = New frm_warehouse_stock_reconcile_new
            frm.Text = "Reconcile Request #" & id
            frm.lbl_title.Text = "Reconcile Request #" & id
            frm.sub_title.Text = "Reconcile Request"

            With grid_stock_reconcilation_view
                frm.cbb_stores.Text = .GetFocusedRowCellValue(col_reconcile_store)
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
            frm.Show()
            frm.LoadEdit(grid_sales_returns_view.GetFocusedRowCellValue(col_srid).ToString.Replace("SR", ""))
            frm.Text = "Sales Return"
            frm.lbl_title.Text = "Sales Return"
            frm.lbl_action.Text = "Approval"
            frm.btn_create.Visible = False
            frm.btn_clear.Visible = False
            frm.btn_update.Visible = False
            frm.btn_delete.Visible = False
            frm.btn_approved.Visible = True
            frm.btn_print.Visible = False
            frm.btn_approved.Location = frm.btn_create.Location
            frm.cbb_customer.ReadOnly = True
        End If
    End Sub

    'Stock Transfer Approval
    Private Sub btn_view_stockTransfer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_stockTransfer.ButtonClick
        Dim stid = CInt(grid_transfer_view.GetFocusedRowCellValue(col_transfer_id).ToString.Replace("ST", ""))
        Dim status = grid_transfer_view.GetFocusedRowCellValue(col_transfer_status)
        Dim transfer_type = grid_transfer_view.GetFocusedRowCellValue(col_transferType)

        'Dim frm = New frm_admin_transfer_view
        'frm.txt_transfer_id.Text = grid_transfer_view.GetFocusedRowCellValue(col_transfer_id)
        'frm.lbl_transfer_type.Text = grid_transfer_view.GetFocusedRowCellValue(col_transferType)
        'frm.ShowDialog()

        If transfer_type = "Distribute" Then
            Dim frm = New frm_warehouse_stocktransfer_distribute_new
            frm.LoadEdit(stid)
            frm.btn_approved.Visible = True
            frm.btn_save.Enabled = False
            frm.btn_print.Enabled = False
            frm.btn_delete.Enabled = False

        ElseIf transfer_type = "Request" Then
            Dim frm = New frm_warehouse_stocktransfer_request_new
            frm.LoadEdit(stid)
            frm.btn_approved.Visible = True
            frm.btn_save.Enabled = False
            frm.btn_print.Enabled = False
            frm.btn_delete.Enabled = False

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




End Class