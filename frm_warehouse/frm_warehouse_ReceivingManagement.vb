Imports DevExpress.XtraGrid.Views.Grid
Imports MySqlConnector

Public Class frm_warehouse_receivingManagement

    '--- ON LOAD ----
    Private Sub frm_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveries()
    End Sub



    '--- FUCNCTIONS ---

    'Load all Deliveries
    Private Sub LoadDeliveries()

        Try
            Using conn As New MySqlConnection(str)
                conn.Open()

                'FILTER
                Dim selection_query = String.Empty
                If Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 3 Or frm_main.user_role_id.Text = 6 Or frm_main.user_role_id.Text = 11) Then
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
                    WHERE (STATUS='Sent' OR STATUS='Partial') " & selection_query & "
                    ORDER BY lead_time ASC", conn)
                cmd.Parameters.AddWithValue("@deliver_to", frm_main.user_store.Text.Trim)
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
            Dim myStoreName = frm_main.user_store.Text.Replace("Winland", "").Trim
            Using connection = New MySqlConnection(str)
                connection.Open()

                'FILTER
                Dim filter = String.Empty
                If Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 3 Or frm_main.user_role_id.Text = 6 Or frm_main.user_role_id.Text = 11) Then
                    filter = "AND RECVR.store_name='" & frm_main.user_store.Text.Trim & "'"
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
            Dim myStoreName = frm_main.user_store.Text.Replace("Winland", "").Trim
            Using connection = New MySqlConnection(str)
                connection.Open()

                'FILTER
                Dim filter = String.Empty
                If Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 3 Or frm_main.user_role_id.Text = 6 Or frm_main.user_role_id.Text = 11) Then
                    filter = "AND RECVR.store_name='" & frm_main.user_store.Text.Trim & "'"
                End If

                Using cmd = New MySqlCommand("SELECT 
                                    CONCAT('SR', LPAD(sales_return_id,5,0)) AS srid, cs.first_name AS customer, ims_users.first_name AS created_by, ims_stores.store_name
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




    '--- CONTROLS ----

    'Grid Delivery
    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim poid As Integer = grid_delivery_view.GetFocusedRowCellValue(col_purchase_id).Replace("PO", "")
        Dim frm = New frm_warehouse_SupplierDeliveries
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
    Private Sub tabcontrol_Selected(sender As Object, e As TabControlEventArgs) Handles tabcontrol.Selected
        Select Case e.TabPage.Name
            Case tab_supplierDeliveries.Name : LoadDeliveries()
            Case tab_stockTransfer.Name : LoadAllStockTransfers()
            Case tab_sales_returns.Name : load_sales_returns()
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

End Class