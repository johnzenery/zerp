Imports System.Text
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.X509
Imports DevExpress.Utils.Drawing
Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Grid
Imports MySqlConnector
Imports Seagull.BarTender.Print

Public Class frm_warehouse_receivingManagement

    '--- ON LOAD ----
    Private Sub frm_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_sales_returns()
        SetAccess()
    End Sub



    '--- FUCNCTIONS ---

    'SET ACCESS OF VIEWING
    Private Sub SetAccess()
        Try
            Dim result = New StringBuilder

            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT access FROM ims_users WHERE usr_id=@userid", conn)
                    cmd.Parameters.AddWithValue("@userid", frm_main.lbl_user_id.Text)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            result.Append(rdr("access"))
                        End While
                    End Using
                End Using
            End Using

            Dim access = result.Replace(";", String.Empty, result.Length - 1, 1).ToString.Split(";")

            tab_control.TabPages.Remove(tab_sales_return)
            tab_control.TabPages.Remove(tab_supplier_deliveries)
            tab_control.TabPages.Remove(tab_stock_transfers)
            tab_control.TabPages.Remove(tab_stock_returns)

            For i = 0 To access.Count - 1
                Select Case access(i)
                    Case "receiving_supplier_delivery" : tab_control.TabPages.Add(tab_supplier_deliveries)
                    Case "receiving_stock_transfer" : tab_control.TabPages.Add(tab_stock_transfers)
                    Case "receiving_sales_returns" : tab_control.TabPages.Add(tab_sales_return)
                    Case "receiving_stock_returns" : tab_control.TabPages.Add(tab_stock_returns)
                End Select
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load all Deliveries
    Private Sub LoadDeliveries()

        Try
            Using conn As New MySqlConnection(str)
                conn.Open()

                'FILTER
                Dim selection_query = String.Empty
                If Not (frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 3 Or frm_main.lbl_user_role_id.Text = 6 Or frm_main.lbl_user_role_id.Text = 11) Then
                    selection_query = "AND deliver_to=(SELECT store_id FROM ims_stores WHERE store_name=@deliver_to)"
                End If

                Dim cmd = New MySqlCommand("SELECT DATE_ADD(CONVERT(date_sent, DATE), INTERVAL ims_purchase.lead_time DAY) AS lead_time, CONCAT('PO',LPAD(purchase_id,5,0)) AS poid, ims_suppliers.supplier,
					(CASE
					     WHEN CURDATE() < DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) THEN 'On-going'
					     WHEN CURDATE() = DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) THEN 'Due Date'
					     WHEN CURDATE() > DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) AND CURDATE() <= DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time + 7 DAY) THEN 'Overdue'
					     WHEN CURDATE() > DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time + 7 DAY) THEN 'Obsolete'
					  END) AS lead_time_status
					FROM `ims_purchase`
                    LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                    WHERE (STATUS='Sent' OR STATUS='Partial') AND deleted=0 " & selection_query & "
                    ORDER BY lead_time ASC", conn)
                cmd.Parameters.AddWithValue("@deliver_to", frm_main.lbl_user_designation.Text.Trim)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_delivery.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Stock Transfers
    Private Sub LoadAllStockTransfers()
        Try
            Dim myStoreName = frm_main.lbl_user_designation.Text.Replace("Winland", String.Empty).Trim
            Using connection = New MySqlConnection(str)
                connection.Open()

                'FILTER
                Dim filter = String.Empty
                If Not (frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 3 Or frm_main.lbl_user_role_id.Text = 6 Or frm_main.lbl_user_role_id.Text = 11) Then
                    filter = "AND RECVR.store_name='" & frm_main.lbl_user_designation.Text.Trim & "'"
                End If

                Using cmd = New MySqlCommand("SELECT 
                                    LPAD(sub_transfer_id,5,0) AS sub_transfer_id,
                                    transfer_type, SRC.store_name AS src_warehouse, RECVR.store_name AS recvr_warehouse
                                    FROM ims_stock_transfer_sub 
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Dispatched' " & filter, connection)
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

    'Load Stock Transfers
    Public Sub load_sales_returns()
        Try
            Dim myStoreName = frm_main.lbl_user_designation.Text.Replace("Winland", String.Empty).Trim
            Using connection = New MySqlConnection(str)
                connection.Open()

                'FILTER
                Dim filter = String.Empty
                If Not (frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 3 Or frm_main.lbl_user_role_id.Text = 6 Or frm_main.lbl_user_role_id.Text = 11) Then
                    filter = "AND RECVR.store_name='" & frm_main.lbl_user_designation.Text.Trim & "'"
                End If

                Using cmd = New MySqlCommand("SELECT 
                                    CONCAT('SR', LPAD(sales_return_id,5,0)) AS srid, cs.first_name AS customer, ims_users.first_name AS created_by, ims_stores.store_name, created_at
                                    FROM ims_sales_returns 
                                    INNER JOIN ims_customers AS cs ON cs.customer_id=ims_sales_returns.customer_id
                                    INNER JOIN ims_users ON ims_users.usr_id=ims_sales_returns.created_by
                                    INNER JOIN ims_stores ON ims_stores.store_id=ims_sales_returns.store_id
                                    WHERE status='Approved' AND ims_sales_returns.is_deleted=0", connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_sales_returns.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    'SUBMIT PULLOUT
    Private Function Submit(type As String) As Boolean
        Dim is_submitted As Boolean = False
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim transc = conn.BeginTransaction

                Try
                    'INSERT TO RETURN DELIVERIES
                    'Using cmd = New MySqlCommand("INSERT INTO rs_returns_deliveries (rid, qty, return_action, delivery_ref, received_by, received_at) 
                    '                              VALUES (@rid, @qty, @return_action, @delivery_ref, @received_by, CURRENT_TIMESTAMP)", conn, transc)
                    '    cmd.Parameters.AddWithValue("@rid", txt_rid.EditValue)
                    '    cmd.Parameters.AddWithValue("@qty", se_delQty.EditValue)
                    '    cmd.Parameters.AddWithValue("@delivery_ref", txt_del_ref.EditValue)
                    '    cmd.Parameters.AddWithValue("@return_action", cbb_action.EditValue)
                    '    cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                    '    cmd.ExecuteNonQuery()
                    'End Using

                    Select Case type
                        Case "Repaired"
                            'UPDATE RETURNS STATUS
                            'Using cmd = New MySqlCommand("UPDATE rs_returns 
                            '                SET is_repaired=@isRepaired, qty_returned=qty_returned+@qty, status=IF(qty=qty_returned, 'Completed', 'Partial') 
                            '                WHERE id=@rid", conn, transc)
                            '    cmd.Parameters.AddWithValue("@rid", txt_rid.EditValue)
                            '    cmd.Parameters.AddWithValue("@isRepaired", IIf(cbb_repaired.EditValue.Equals("YES"), 1, 0))
                            '    cmd.Parameters.AddWithValue("@qty", se_delQty.EditValue)
                            '    cmd.ExecuteNonQuery()
                            'End Using

                            'CODE : ADD TO INVENTORY HERE


                        Case "Replacement"
                            'UPDATE RETURNS STATUS
                            'Using cmd = New MySqlCommand("UPDATE rs_returns 
                            '                SET is_replaced_as_new=@isRelacedAsNew, qty_returned=qty_returned+@qty, status=IF(qty=qty_returned, 'Completed', 'Partial') 
                            '                WHERE id=@rid", conn, transc)
                            '    cmd.Parameters.AddWithValue("@rid", txt_rid.EditValue)
                            '    cmd.Parameters.AddWithValue("@isRelacedAsNew", IIf(cbb_brandNew.EditValue.Equals("YES"), 1, 0))
                            '    cmd.Parameters.AddWithValue("@qty", se_delQty.EditValue)
                            '    cmd.ExecuteNonQuery()
                            'End Using

                            'CODE : ADD TO INVENTORY HERE


                        Case "For Credit"
                    End Select

                    'UPDATE PULLOUT STATUS
                    'Using cmd = New MySqlCommand("UPDATE rs_returns_batch
                    '                            SET status=IF(
                    '                                    (SELECT SUM(qty) FROM rs_returns WHERE batch_id=@id)  = (SELECT SUM(qty_returned) FROM rs_returns WHERE batch_id=@id), 
                    '                                'Completed', 'Partially Delivered')
                    '                            WHERE batch_id=@id", conn, transc)

                    '    cmd.Parameters.AddWithValue("@id", txt_batch_id.EditValue)
                    '    If cmd.ExecuteNonQuery() > 0 Then
                    '        MsgBox("Submitted!", vbInformation, "Information")
                    '        is_submitted = True
                    '    End If
                    'End Using

                    'COMMIT
                    transc.Commit()

                Catch ex As Exception
                    transc.Rollback()
                    MsgBox($"Error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                Finally
                    conn.Close()
                End Try
            End Using

        Catch ex As Exception
            MsgBox($"Error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        End Try

        Return is_submitted

    End Function

    'Load Supplier Deliveries Form to Panel
    Public Sub LoadFrm(form As Form)
        If panel_supplierDeliveries.Controls.Count > 0 Then
            panel_supplierDeliveries.Controls.RemoveAt(0)
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        panel_supplierDeliveries.Controls.Add(form)
        panel_supplierDeliveries.Tag = form
        lbl_ClicktoView_1.Hide()
        form.Show()
    End Sub

    'Load Stock Transfer Form to Panel
    Public Sub LoadtoStockTransferPanel(form As Form)
        If panel_stockTransfers.Controls.Count > 0 Then
            panel_stockTransfers.Controls.RemoveAt(0)
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        panel_stockTransfers.Controls.Add(form)
        panel_stockTransfers.Tag = form
        lbl_ClicktoView_2.Hide()
        form.Show()
    End Sub

    'Load Sales Return Form to Panel
    Public Sub LoadtoSalesReturnPanel(form As Form)
        If panel_sales_return.Controls.Count > 0 Then
            panel_sales_return.Controls.RemoveAt(0)
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        panel_sales_return.Controls.Add(form)
        panel_sales_return.Tag = form
        lbl_sales_return.Hide()
        form.Show()
    End Sub


    'INITIALIZE DATATABLE FOR GRID STOCK RETURNS 
    Private Sub InitializeStockReturnView()
        Try
            Dim tbl = New DataTable
            tbl.Columns.Add("rid")
            tbl.Columns.Add("received_qty", GetType(Integer))
            tbl.Columns.Add("received_serials")
            tbl.Columns.Add("received_remarks")
            tbl.Columns.Add("received_resolved_type")
            tbl.Columns.Add("received_credit_memo_cost", GetType(Decimal))
            tbl.Columns.Add("cost_per_unit", GetType(Decimal))
            tbl.Columns.Add("cost", GetType(Decimal))
            tbl.Columns.Add("total_qty", GetType(Integer))
            tbl.Columns.Add("remaining_qty", GetType(Integer))
            tbl.Columns.Add("pid")
            tbl.Columns.Add("supmodel")
            tbl.Columns.Add("winmodel")
            tbl.Columns.Add("unit")
            tbl.Columns.Add("description")
            tbl.Columns.Add("serial")
            tbl.Columns.Add("request_type")
            tbl.Columns.Add("issue")
            tbl.Columns.Add("date_pullout", GetType(Date))
            tbl.Columns.Add("warehouse", GetType(String))

            grid_stock_return.DataSource = tbl

            cbb_supplier.Properties.Items.Clear()
            Using conn = New MySqlConnection(str)
                conn.Open()

                'INITIALIZE SUPPLIER
                Using cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_supplier.Properties.Items.Add(rdr("supplier"))
                        End While
                    End Using
                End Using

                'INITIALIZE WAREHOUSE
                Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_tagetWarehouse.Properties.Items.Add(rdr("store_name"))
                        End While
                    End Using
                End Using

                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox($"Error occured:{vbCrLf + vbCrLf + ex.Message}", vbCritical, "Error")
        End Try
    End Sub


    '--- CONTROLS ----

    'Grid Delivery
    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim poid As Integer = grid_delivery_view.GetFocusedRowCellValue(col_purchase_id).Replace("PO", String.Empty)
        Dim frm = New frm_warehouse_delivery_receive
        LoadFrm(frm)
        frm.Load_Orders(poid)
    End Sub

    'Grid Style
    Private Sub grid_delivery_view_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grid_delivery_view.RowStyle
        Dim status As String = grid_delivery_view.GetRowCellValue(e.RowHandle, "lead_time_status")

        Select Case status
            Case "Obsolete"
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.ForeColor = Color.White
            Case "Overdue" : e.Appearance.BackColor = Color.DarkOrange
            Case "On-going", "Due Date" : e.Appearance.BackColor = Color.Lime
        End Select
    End Sub

    'TabControl Selected
    Private Sub XtraTabControl1_Selected(sender As Object, e As DevExpress.XtraTab.TabPageEventArgs) Handles tab_control.Selected
        Select Case e.Page.Name
            Case tab_supplier_deliveries.Name : LoadDeliveries()
            Case tab_stock_transfers.Name : LoadAllStockTransfers()
            Case tab_sales_return.Name : load_sales_returns()
            Case tab_stock_returns.Name : InitializeStockReturnView() 'Load_PullOut()
        End Select
    End Sub

    'View Order
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Dim transferID = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
        Dim transferType = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
        Dim frm = New frm_warehouse_stocktransfer_receive

        frm.lbl_transfer_id.Text = transferID
        frm.lbl_transfer_type.Text = transferType

        LoadtoStockTransferPanel(frm)

        Select Case transferType
            Case "Distribute" : frm.LoadStockTransferDeliveries("destination")
            Case "Request" : frm.LoadStockTransferDeliveries("source")
        End Select


    End Sub

    'View Sales Return
    Private Sub btn_view_srid_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_srid.ButtonClick
        Dim frm = New frm_warehouse_returns_receive
        frm.txt_srid.Text = grid_sales_returns_view.GetFocusedRowCellValue(col_srid)
        frm.txt_customer.Text = grid_sales_returns_view.GetFocusedRowCellValue(col_customer)
        frm.txt_created_by.Text = grid_sales_returns_view.GetFocusedRowCellValue(col_created_by)
        frm.txt_warehouse.Text = grid_sales_returns_view.GetFocusedRowCellValue(col_warehouse)
        LoadtoSalesReturnPanel(frm)
    End Sub

    Private Sub panel_supplierDeliveries_ControlRemoved(sender As Object, e As ControlEventArgs) Handles panel_supplierDeliveries.ControlRemoved
        LoadDeliveries()
    End Sub

    Private Sub panel_stockTransfers_ControlRemoved(sender As Object, e As ControlEventArgs) Handles panel_stockTransfers.ControlRemoved
        LoadAllStockTransfers()
    End Sub

    Private Sub panel_sales_return_ControlRemoved(sender As Object, e As ControlEventArgs) Handles panel_sales_return.ControlRemoved
        load_sales_returns()
    End Sub

    'BUTTON : SUBMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If cbb_supplier.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txt_reference_no.EditValue) _
            Or dt_received.EditValue = Nothing Or CType(grid_stock_return.DataSource, DataTable).Rows.Count = 0 Then
            MsgBox("Complete all required fields!", vbExclamation, "Required")
            Exit Sub

        Else
            'Validate Rows
            For Each row As DataRow In CType(grid_stock_return.DataSource, DataTable).Rows

                'Check item if queried
                If String.IsNullOrWhiteSpace(row.Item("pid")) Then
                    MsgBox("Something is wrong. Check all item first!", vbCritical, "Required")
                    Exit Sub
                End If

                'Check Received QTY and Resolve Type
                If IsDBNull(row.Item("received_qty")) Or IsDBNull(row.Item("received_resolved_type")) Then
                    MsgBox("Receive quantity and type should not empty!", vbCritical, "Required")
                    Exit Sub
                End If

                'Check Credit Memo Value if Resolve Type = Credit Memo Cost
                If row.Item("received_qty") > row.Item("remaining_qty") Or row.Item("received_qty") = 0 Then
                    MsgBox($"Check Received QTY.{vbCrLf}Shouldn't be Zero or higher than to receive!", vbCritical, "Required")
                    Exit Sub
                End If

                'Check Credit Memo Value if Resolve Type = Credit Memo Cost
                If row.Item("received_resolved_type").Equals("Pullout") Then
                    If IsDBNull(row.Item("received_credit_memo_cost")) Then
                        MsgBox("Credit Memo cost should not empty!", vbCritical, "Required")
                        Exit Sub
                    End If
                End If

            Next

            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") Then
                Try
                    Using conn As New MySqlConnection(str)
                        conn.Open()
                        Dim transc = conn.BeginTransaction
                        Dim query = String.Empty

                        Try
                            For Each row As DataRow In CType(grid_stock_return.DataSource, DataTable).Rows

                                'GET Table from datatable -> Convert to table_name
                                Dim tbl = "ims_" & row.Item("warehouse").ToString.Trim.ToLower.Replace(" ", "_")

                                'CHOOSE query based on Resolve Type
                                If row.Item("received_resolved_type").Equals("Pullout") Or row.Item("received_resolved_type").Equals("Reject") Then
                                    query = $"UPDATE {tbl} SET on_hold=on_hold-@qty WHERE pid=@pid"
                                Else
                                    query = $"UPDATE {tbl} SET on_hold=on_hold-@qty, qty=qty+@qty WHERE pid=@pid"
                                End If

                                'UPDATE stocks 
                                Using cmd = New MySqlCommand(query, conn, transc)
                                    cmd.Parameters.AddWithValue("@qty", row.Item("received_qty"))
                                    cmd.Parameters.AddWithValue("@pid", row.Item("pid"))
                                    cmd.ExecuteNonQuery()
                                End Using

                                'UPDATE rs_returns
                                Using cmd = New MySqlCommand("UPDATE rs_returns 
                                                SET qty_returned=qty_returned+@qty, status=IF(qty=qty_returned, 'Completed', 'Partial')
                                                WHERE id=@rid", conn, transc)
                                    cmd.Parameters.AddWithValue("@qty", row.Item("received_qty"))
                                    cmd.Parameters.AddWithValue("@rid", row.Item("rid"))
                                    cmd.ExecuteNonQuery()
                                End Using

                                'UPDATE rs_returns_batch
                                Using cmd = New MySqlCommand("UPDATE rs_returns_batch
                                                            INNER JOIN (
	                                                            SELECT batch_id, SUM(qty) as qty, SUM(qty_returned) as qty_returned
	                                                            FROM rs_returns
	                                                            WHERE batch_id=(SELECT batch_id FROM rs_returns WHERE id=@rid)
	                                                            GROUP BY batch_id
                                                            ) AS rs_returns ON rs_returns.batch_id=rs_returns_batch.batch_id
                                                            SET rs_returns_batch.status=IF(rs_returns.qty=rs_returns.qty_returned, 'Completed', 'Partial')", conn, transc)
                                    cmd.Parameters.AddWithValue("@rid", row.Item("rid"))
                                    cmd.ExecuteNonQuery()
                                End Using

                                'INSERT TO rs_returns_deliveries
                                Dim status = String.Empty
                                Select Case row.Item("received_resolved_type")
                                    Case "Pullout" : status = "Pending for Credit"
                                    Case "Reject" : status = "Rejected"
                                    Case Else : status = "Received"
                                End Select

                                Using cmd = New MySqlCommand("INSERT INTO rs_returns_deliveries
                                                (rid, qty_received, return_action, delivery_ref, serial, remarks, credit_cost, status, received_by, received_at)
                                         VALUES (@rid, @qty_received, @return_action, @delivery_ref, @serial, @remarks, IFNULL(@credit_cost, 0.00), @status, @received_by, CURRENT_TIMESTAMP)", conn, transc)
                                    cmd.Parameters.AddWithValue("@rid", row.Item("rid"))
                                    cmd.Parameters.AddWithValue("@qty_received", row.Item("received_qty"))
                                    cmd.Parameters.AddWithValue("@return_action", row.Item("received_resolved_type"))
                                    cmd.Parameters.AddWithValue("@delivery_ref", txt_reference_no.EditValue)
                                    cmd.Parameters.AddWithValue("@serial", row.Item("received_serials"))
                                    cmd.Parameters.AddWithValue("@remarks", row.Item("received_remarks"))
                                    cmd.Parameters.AddWithValue("@credit_cost", row.Item("received_credit_memo_cost"))
                                    cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                                    cmd.Parameters.AddWithValue("@status", status)
                                    cmd.ExecuteNonQuery()
                                End Using
                            Next

                            'COMMIT Transactions
                            transc.Commit()
                            MsgBox("Success!", vbInformation, "Information")

                            'Clear Fields
                            CType(grid_stock_return.DataSource, DataTable).Rows.Clear()
                            cbb_supplier.SelectedIndex = -1
                            cbb_tagetWarehouse.SelectedIndex = -1
                            txt_reference_no.EditValue = String.Empty
                            dt_received.EditValue = Nothing

                        Catch ex As Exception
                            transc.Rollback()
                            MsgBox($"Error occured:{vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                        End Try

                        conn.Close()
                    End Using

                Catch ex As Exception
                    MsgBox($"Error occured:{vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                End Try
            End If
        End If
    End Sub

    Private Sub grid_stock_return_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_stock_return_view.CellValueChanged
        If e.Column.Name = col_rid.Name Then
            Dim rid = grid_stock_return_view.GetFocusedRowCellValue(col_rid)
            Dim datarow = grid_stock_return_view.GetDataRow(e.RowHandle)

            'Check Supplier and Warehouse to proceed
            If cbb_supplier.SelectedIndex = -1 Then
                MsgBox("Complete required fields!", vbExclamation, "Required")
                Exit Sub
            End If

            If Not String.IsNullOrWhiteSpace(rid) Then
                Try
                    Using conn As New MySqlConnection(str)


                        conn.Open()
                        Using cmd = New MySqlCommand($"SELECT qty, (qty - qty_returned) remaining_qty, rs_returns.pullout_id, batch_id, 
                                                    rs_returns.pid, ims_inventory.supmodel, ims_inventory.winmodel, ims_inventory.description, ims_inventory.unit,
                                                    rs_returns.type, issue, serial, rs_returns.status, rs_returns_pullout.sent_at, ims_inventory.cost,
                                                    ims_suppliers.supplier, ims_stores.store_name
                                    FROM rs_returns
                                    INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                    INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                                    INNER JOIN ims_stores ON ims_stores.store_id=rs_returns.src_warehouse_id
                                    INNER JOIN rs_returns_pullout ON rs_returns_pullout.pullout_id=rs_returns.pullout_id
                                    WHERE rs_returns.id=@id AND ims_suppliers.supplier=@supplier", conn)
                            cmd.Parameters.AddWithValue("@id", rid)
                            cmd.Parameters.AddWithValue("@supplier", cbb_supplier.EditValue.ToString.Trim)
                            'cmd.Parameters.AddWithValue("@warehouse", cbb_tagetWarehouse.EditValue.ToString.Trim)

                            Using rdr = cmd.ExecuteReader
                                If rdr.HasRows Then
                                    While rdr.Read

                                        If Equals(rdr("status").ToString, "Completed") Then
                                            MsgBox("This RID is already completed!", vbInformation, "Information")
                                            Exit While
                                        ElseIf Not (Equals(rdr("status").ToString, "Sent") Or Equals(rdr("status").ToString, "Partial")) Then
                                            MsgBox("This RID is not yet sent.", vbInformation, "Information")
                                            Exit While
                                        End If

                                        datarow.Item("cost") = rdr("cost")
                                        datarow.Item("total_qty") = rdr("qty")
                                        datarow.Item("remaining_qty") = rdr("remaining_qty")

                                        datarow.Item("pid") = rdr("pid")
                                        datarow.Item("supmodel") = rdr("supmodel")
                                        datarow.Item("winmodel") = rdr("winmodel")

                                        datarow.Item("unit") = rdr("unit")
                                        datarow.Item("description") = rdr("description")
                                        datarow.Item("serial") = rdr("serial")
                                        datarow.Item("request_type") = rdr("type")
                                        datarow.Item("issue") = rdr("issue")
                                        datarow.Item("date_pullout") = rdr("sent_at")
                                        datarow.Item("warehouse") = rdr("store_name")

                                    End While

                                    grid_stock_return_view.BestFitColumns()

                                Else
                                    MsgBox($"RID not found!", vbCritical, "Not Found")
                                    datarow.Item("rid") = Nothing
                                    datarow.Item("cost") = DBNull.Value
                                    datarow.Item("total_qty") = DBNull.Value
                                    datarow.Item("remaining_qty") = DBNull.Value
                                    datarow.Item("pid") = Nothing
                                    datarow.Item("supmodel") = Nothing
                                    datarow.Item("winmodel") = Nothing
                                    datarow.Item("unit") = Nothing
                                    datarow.Item("description") = Nothing
                                    datarow.Item("serial") = Nothing
                                    datarow.Item("request_type") = Nothing
                                    datarow.Item("issue") = Nothing
                                    datarow.Item("date_pullout") = DBNull.Value
                                End If
                            End Using
                        End Using
                    End Using

                Catch ex As Exception
                    MsgBox($"Error occured:{vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                End Try

            End If

        End If
    End Sub

    'BUTTON : ADD STOCK RETURN ROW
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        grid_stock_return_view.AddNewRow()
    End Sub

    'BUTTON : DELETE STOCK RETURN ROW
    Private Sub btn_delete_row_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete_row.ButtonClick
        Dim datarow = grid_stock_return_view.GetFocusedDataRow()
        datarow.Delete()
    End Sub

End Class