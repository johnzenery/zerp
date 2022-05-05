Imports DevExpress.XtraBars.Navigation
Imports MySql.Data.MySqlClient

Public Class frm_warehouse_PackageManagement

    ReadOnly conn As New MySqlConnection(str)


    Private Sub frm_packing_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders("Pending for Arrangement")
        start_timer()

        col_sub_transfer_id.Visible = False
        col_from.Visible = False
        col_to.Visible = False

    End Sub



    '---- FUNCTIONS ----

    'Load Orders
    Private Sub load_orders(classification As String)

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim query = String.Empty
                Select Case classification
                    Case "Pending for Arrangement", "0"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='Pending for Arrangement' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
                    Case "On-Going", "1"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='On-Going' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
                    Case "Packed", "2"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='Packed' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
                    Case "Cancelled Order", "3"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE status='Cancelled Order' AND NOT ims_orders.deleted='1' ORDER BY date_ordered ASC"
                End Select
                Dim cmd = New MySqlCommand(query, conn)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_orders.DataSource = dt

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        SetCount()

    End Sub

    'Load Transfers
    Private Sub load_transfers(classification As String)

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim filter = String.Empty
                If Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 3 Or frm_main.user_role_id.Text = 6 Or frm_main.user_role_id.Text = 11) Then
                    filter = "AND SRC.store_name='" & frm_main.user_store.Text.Trim & "'"
                End If

                Dim query = String.Empty
                Select Case classification
                    Case "Pending for Arrangement", "0"
                        query = "SELECT CONCAT('ST', LPAD(transfer_id, 5, '0')) as transfer_id, transfer_type, status 
                                    FROM ims_stock_transfer 
                                    WHERE is_deleted=0 AND status='Pending for Arrangement'"

                    Case "Arranging", "1"
                        query = "SELECT sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status,
                                    SRC.store_name AS source_warehouse, RECVR.store_name AS receiver_warehouse
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Arranging' " & filter

                    Case "Packed", "2"
                        query = "SELECT sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status,
                                    SRC.store_name AS source_warehouse, RECVR.store_name AS receiver_warehouse
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Packed' " & filter

                    Case "Pending Cancellation", "3"
                        query = "SELECT sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status,
                                    SRC.store_name AS source_warehouse, RECVR.store_name AS receiver_warehouse
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Pending Cancellation' " & filter

                End Select

                Dim cmd = New MySqlCommand(query, connect)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_stock_transfers.DataSource = dt
                grid_orders_view.FocusedRowHandle = -1
                grid_orders_view.ClearSelection()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Start Timer
    Private Sub start_timer()

        Select Case cbb_timer.SelectedIndex
            Case 0 : timer.Interval = 60000
            Case 1 : timer.Interval = 300000
            Case 2 : timer.Interval = 600000
            Case 3 : timer.Interval = 1800000
        End Select

        timer.Stop()
        timer.Start()

    End Sub

    'Count Label
    Private Sub SetCount()
        Try
            Using connect = New MySqlConnection(str)

                connect.Open()

                'Label for Pending for Arrangement
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Pending for Arrangement' AND deleted='0'", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_pending.Caption = "Pending Arrangements (" & count & ")"
                End Using

                'Label for On-Going
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='On-Going' AND deleted='0'", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_ongoing.Caption = "On-Going (" & count & ")"
                End Using

                'Label for Packed
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Packed' AND deleted='0'", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_completed.Caption = "Completed (" & count & ")"
                End Using

                'Label for UnPacked
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Cancelled Order' AND deleted='0'", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_cancelled.Caption = "For Unpacking (" & count & ")"
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub




    '--- CONTROLS /EVENTS ----

    'btn_view_order | Sales Order
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        If tabpanel_orders.SelectedPage.Equals(tab_order_pending) Then
            Dim frm = New frm_sales_start_packing()
            frm.lbl_id.Text = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id)
            frm.ShowDialog()

        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_ongoing) Then
            Dim frm = New frm_sales_packing_list_view()
            Dim order_id As Integer = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id).ToString.Replace("SO", "")
            Dim status As String = grid_orders_view.GetFocusedRowCellValue(col_order_status)
            frm.LoadData(order_id, status)

        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_completed) Then
            MsgBox("Good job!", vbInformation, "Completed")

        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_cancelled) Then
            Dim frm As frm_sales_packing_list_view = New frm_sales_packing_list_view()
            Dim order_id As Integer = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id).ToString.Replace("SO", "")
            Dim status As String = grid_orders_view.GetFocusedRowCellValue(col_order_status)
            frm.LoadData(order_id, status)

        End If

        load_orders(tabpanel_orders.SelectedPageIndex)

    End Sub

    'btn_view_transfer | Stock Transfer
    Private Sub btn_view_transfer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_transfer.ButtonClick
        If tabpanel_transfer.SelectedPage.Equals(tab_transfer_pending) Then
            Dim frm = New frm_sales_start_packing()
            frm.lbl_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            frm.transfer_type = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
            frm.ShowDialog()

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_ongoing) Then
            Dim frm = New frm_warehouse_PackageManagement_packed
            frm.txt_sub_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_transfer_id)
            frm.txt_status.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_status)
            frm.txt_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            frm.txt_transfer_type.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
            frm.ShowDialog()

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_completed) Then
            MsgBox("Good job!", vbInformation, "Completed")

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_cancellation) Then
            Dim frm = New frm_warehouse_PackageManagement_packed
            frm.txt_sub_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_transfer_id)
            frm.txt_status.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_status)
            frm.txt_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            frm.txt_transfer_type.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
            frm.lbl_checked_by.Visible = False
            frm.lbl_prepared_by.Visible = False
            frm.txt_prepared_by.Visible = False
            frm.cbb_packer.Visible = False
            frm.btn_print.Location = New Point(16, 145)
            frm.btn_packed.Location = New Point(119, 145)
            frm.Size = New Point(259, 243)
            frm.btn_packed.Text = "Unpacked"
            frm.ShowDialog()

        End If

        load_transfers(tabpanel_transfer.SelectedPageIndex)

    End Sub

    'timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        load_orders(tabpanel_orders.SelectedPageIndex)
        load_transfers(tabpanel_transfer.SelectedPageIndex)
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub

    'Tab Selection | Orders
    Private Sub tabpanel_orders_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles tabpanel_orders.SelectedPageChanged
        If tabpanel_orders.SelectedPage.Equals(tab_order_pending) Then
            load_orders("Pending for Arrangement")
        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_ongoing) Then
            load_orders("On-Going")
        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_completed) Then
            load_orders("Packed")
        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_cancelled) Then
            load_orders("Cancelled Order")
        End If
    End Sub

    'Tab Selection | Transfer
    Private Sub tabpanel_transfer_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles tabpanel_transfer.SelectedPageChanged

        col_from.VisibleIndex = 5
        col_to.VisibleIndex = 6

        If tabpanel_transfer.SelectedPage.Equals(tab_transfer_pending) Then
            load_transfers("Pending for Arrangement")

            col_sub_transfer_id.Visible = False
            col_from.Visible = False
            col_to.Visible = False

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_ongoing) Then
            load_transfers("Arranging")

            col_sub_transfer_id.Visible = True
            col_from.Visible = True
            col_to.Visible = True

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_completed) Then
            load_transfers("Packed")

            col_sub_transfer_id.Visible = True
            col_from.Visible = True
            col_to.Visible = True

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_cancellation) Then
            load_transfers("Pending Cancellation")

            col_sub_transfer_id.Visible = True
            col_from.Visible = True
            col_to.Visible = True

        End If


    End Sub

    'F5 to Refresh
    Private Sub frm_warehouse_PackageManagement_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            load_orders(tabpanel_orders.SelectedPageIndex)
            load_transfers(tabpanel_transfer.SelectedPageIndex)
        End If
    End Sub

End Class