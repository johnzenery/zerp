Imports DevExpress.XtraBars.Navigation
Imports MySqlConnector

Public Class frm_warehouse_PackageManagement


    Private Sub frm_packing_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_orders("Pending for Arrangement")
        Load_transfers("Pending for Arrangement")
        Load_BatchPullouts("Pending Arrangement")
        start_timer()
    End Sub



    '---- FUNCTIONS ----

    'Load Orders
    Private Sub Load_orders(classification As String)

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim filter As String = IIf(Set_Restriction(), "AND target_warehouse=@target_warehouse", "")

                Dim query = String.Empty
                Select Case classification
                    Case "Pending for Arrangement", "0"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, transaction_type, status, ims_stores.store_name FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            WHERE status='Pending for Arrangement' AND NOT ims_orders.deleted='1' " & filter & " ORDER BY date_ordered ASC"
                    Case "On-Going", "1"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status, ims_stores.store_name FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            WHERE status='On-Going' AND NOT ims_orders.deleted='1' " & filter & " ORDER BY date_ordered ASC"
                    Case "Packed", "2"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status, ims_stores.store_name FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            WHERE status='Packed' AND NOT ims_orders.deleted='1' " & filter & " ORDER BY date_ordered ASC"
                    Case "Cancelled Order", "3"
                        query = "SELECT CONCAT('SO', LPAD(order_id, 5, '0')) AS order_id, date_ordered,  ims_users.first_name as agent, ims_customers.first_name, transaction_type, status, ims_stores.store_name FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            WHERE status='Cancelled Order' AND NOT ims_orders.deleted='1' " & filter & " ORDER BY date_ordered ASC"
                End Select
                Dim cmd = New MySqlCommand(query, connect)
                cmd.Parameters.AddWithValue("@target_warehouse", frm_main.lbl_user_designation_id.Text)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_orders.DataSource = dt

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        SetCount_Order()

    End Sub

    'Load Transfers
    Private Sub Load_transfers(classification As String)

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim filter = IIf(Set_Restriction(), "AND SRC.store_name='" & frm_main.lbl_user_designation.Text.Trim & "'", "") '" AND src_store_id='" & frm_main.lbl_user_designation_id.Text & "'" 

                Dim query = String.Empty
                Select Case classification
                    Case "Pending for Arrangement", "0"
                        query = "SELECT CONCAT('SubT-', sub_transfer_id) AS sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status, date_released,
                                    SRC.store_name AS source_warehouse, RECVR.store_name AS receiver_warehouse
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Pending for Arrangement' " & filter

                    Case "Arranging", "1"
                        query = "SELECT CONCAT('SubT-', sub_transfer_id) AS sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status, date_released,
                                    SRC.store_name AS source_warehouse, RECVR.store_name AS receiver_warehouse
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Arranging' " & filter

                    Case "Packed", "2"
                        query = "SELECT CONCAT('SubT-', sub_transfer_id) AS sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status, date_released,
                                    SRC.store_name AS source_warehouse, RECVR.store_name AS receiver_warehouse
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE status='Packed' " & filter

                    Case "Pending Cancellation", "3"
                        query = "SELECT CONCAT('SubT-', sub_transfer_id) AS sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as transfer_id, transfer_type, status, date_released,
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

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        SetCount_Transfers()

    End Sub

    'Load Pullouts
    Private Sub Load_BatchPullouts(classification As String)

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim filter = IIf(Set_Restriction(), "AND warehouse_id='" & frm_main.lbl_user_designation_id.Text.Trim & "'", "")

                Dim query = String.Empty
                Select Case classification
                    Case "Pending Arrangement", "0"
                        query = "SELECT batch_id, ims_suppliers.supplier, status
                                FROM rs_returns_batch
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                                WHERE rs_returns_batch.is_deleted='0' AND rs_returns_batch.status='Pending Arrangement'" & filter

                    Case "On-Going Arrangement", "1"
                        query = "SELECT batch_id, ims_suppliers.supplier, status
                                FROM rs_returns_batch
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                                WHERE rs_returns_batch.is_deleted='0' AND rs_returns_batch.status='On-Going Arrangement'" & filter

                    Case "Packed", "2"
                        query = "SELECT batch_id, ims_suppliers.supplier, status
                                FROM rs_returns_batch
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                                WHERE rs_returns_batch.is_deleted='0' AND rs_returns_batch.status='Packed'" & filter

                End Select

                Dim cmd = New MySqlCommand(query, connect)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_batch_pullout.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        SetCount_StockReturns()

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

    'Count Label - Orders
    Private Sub SetCount_Order()
        Try
            Using connect = New MySqlConnection(str)

                connect.Open()

                'Label for Pending for Arrangement
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Pending for Arrangement' AND target_warehouse=@target_warehouse AND deleted='0'", connect)
                    cmd.Parameters.AddWithValue("@target_warehouse", frm_main.lbl_user_designation_id.Text)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_pending.Caption = "Pending Arrangements (" & count & ")"
                End Using

                'Label for On-Going
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='On-Going' AND target_warehouse=@target_warehouse AND deleted='0'", connect)
                    cmd.Parameters.AddWithValue("@target_warehouse", frm_main.lbl_user_designation_id.Text)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_ongoing.Caption = "On-Going (" & count & ")"
                End Using

                'Label for Packed
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Packed' AND target_warehouse=@target_warehouse AND deleted='0'", connect)
                    cmd.Parameters.AddWithValue("@target_warehouse", frm_main.lbl_user_designation_id.Text)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_completed.Caption = "Completed (" & count & ")"
                End Using

                'Label for UnPacked
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_orders WHERE status='Cancelled Order' AND target_warehouse=@target_warehouse AND deleted='0'", connect)
                    cmd.Parameters.AddWithValue("@target_warehouse", frm_main.lbl_user_designation_id.Text)
                    Dim count As Integer = cmd.ExecuteScalar()
                    tab_order_cancelled.Caption = "For Unpacking (" & count & ")"
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Count Label - Transfers
    Private Sub SetCount_Transfers()
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim filter = IIf(Set_Restriction(), " AND src_store_id='" & frm_main.lbl_user_designation_id.Text & "'", "") '" AND src_store_id='" & frm_main.lbl_user_designation_id.Text & "'" 

                'Label for Pending for Arrangement
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer_sub WHERE status='Pending for Arrangement'" & filter, connect)
                    tab_transfer_pending.Caption = "Pending Arrangements (" & cmd.ExecuteScalar() & ")"
                End Using

                'Label for On-Going
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer_sub WHERE status='Arranging'" & filter, connect)
                    tab_transfer_ongoing.Caption = "On-Going (" & cmd.ExecuteScalar() & ")"
                End Using

                'Label for Packed
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer_sub WHERE status='Packed'" & filter, connect)
                    tab_transfer_completed.Caption = "Completed (" & cmd.ExecuteScalar() & ")"
                End Using

                'Label for UnPacked
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer_sub WHERE status='Pending Cancellation'" & filter, connect)
                    tab_transfer_cancellation.Caption = "For Unpacking (" & cmd.ExecuteScalar() & ")"
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Count Label - Stock Returns
    Private Sub SetCount_StockReturns()
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim filter = IIf(Set_Restriction(), " AND warehouse_id='" & frm_main.lbl_user_designation_id.Text & "'", "") '" AND src_store_id='" & frm_main.lbl_user_designation_id.Text & "'" 

                'Label for Pending for Arrangement
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM rs_returns_batch WHERE status='Pending Arrangement'" & filter, connect)
                    tab_pullout_pending.Caption = "Pending Arrangements (" & cmd.ExecuteScalar() & ")"
                End Using

                'Label for On-Going
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM rs_returns_batch WHERE status='On-Going Arrangement'" & filter, connect)
                    tab_pullout_ongoing.Caption = "On-Going Arrangements(" & cmd.ExecuteScalar() & ")"
                End Using

                'Label for Packed
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM rs_returns_batch WHERE status='Packed'" & filter, connect)
                    tab_pullout_completed.Caption = "Completed (" & cmd.ExecuteScalar() & ")"
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'SET RESTRICTION
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






    '--- CONTROLS /EVENTS ----

    'btn_view_order | Sales Order
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_order_action.ButtonClick
        If tabpanel_orders.SelectedPage.Equals(tab_order_pending) Then
            Dim frm = New frm_warehouse_start_packing()
            frm.lbl_id.Text = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id)
            frm.ShowDialog()

        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_ongoing) Then
            Dim frm = New frm_warehouse_sales_order_packed()
            Dim order_id As Integer = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id).ToString.Replace("SO", String.Empty)
            Dim status As String = grid_orders_view.GetFocusedRowCellValue(col_order_status)
            frm.LoadData(order_id, status)

        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_completed) Then
            MsgBox("Good job!", vbInformation, "Completed")

        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_cancelled) Then
            Dim frm As frm_warehouse_sales_order_packed = New frm_warehouse_sales_order_packed()
            Dim order_id As Integer = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id).ToString.Replace("SO", String.Empty)
            Dim status As String = grid_orders_view.GetFocusedRowCellValue(col_order_status)
            frm.LoadData(order_id, status)

        End If

        Load_orders(tabpanel_orders.SelectedPageIndex)

    End Sub

    'btn_view_transfer | Stock Transfer
    Private Sub btn_view_transfer_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_transfer_action.ButtonClick
        If tabpanel_transfer.SelectedPage.Equals(tab_transfer_pending) Then
            Dim frm = New frm_warehouse_start_packing()
            frm.lbl_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_transfer_id)
            frm.transfer_type = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
            frm.lbl_description.Text = "Start to arrange this transfer?"
            frm.Text = "Arrange Transfer"
            frm.ShowDialog()

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_ongoing) Then
            Dim frm = New frm_warehouse_stock_transfer_packed
            frm.txt_sub_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_transfer_id)
            frm.txt_status.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_status)
            frm.txt_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            frm.txt_transfer_type.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
            frm.ShowDialog()

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_completed) Then
            MsgBox("Good job!", vbInformation, "Completed")

        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_cancellation) Then
            Dim frm = New frm_warehouse_stock_transfer_packed
            frm.txt_sub_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_transfer_id)
            frm.txt_status.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_status)
            frm.txt_transfer_id.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            frm.txt_transfer_type.Text = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type)
            frm.lbl_prepared_by.Visible = False
            frm.txt_prepared_by.Visible = False
            frm.lbl_packed_by.Visible = False
            frm.txt_packed_by.Visible = False
            frm.btn_packed.Location = New Point(15, 145)
            frm.Size = New Point(300, 230)
            frm.btn_packed.Text = "Unpacked"
            frm.ShowDialog()

        End If

        Load_transfers(tabpanel_transfer.SelectedPageIndex)

    End Sub

    'timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Load_orders(tabpanel_orders.SelectedPageIndex)
        Load_transfers(tabpanel_transfer.SelectedPageIndex)
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub

    'Tab Selection | Orders
    Private Sub tabpanel_orders_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles tabpanel_orders.SelectedPageChanged
        If tabpanel_orders.SelectedPage.Equals(tab_order_pending) Then
            Load_orders("Pending for Arrangement")
        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_ongoing) Then
            Load_orders("On-Going")
        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_completed) Then
            Load_orders("Packed")
        ElseIf tabpanel_orders.SelectedPage.Equals(tab_order_cancelled) Then
            Load_orders("Cancelled Order")
        End If
    End Sub

    'Tab Selection | Transfer
    Private Sub tabpanel_transfer_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles tabpanel_transfer.SelectedPageChanged

        col_from.VisibleIndex = 6
        col_to.VisibleIndex = 7

        If tabpanel_transfer.SelectedPage.Equals(tab_transfer_pending) Then
            Load_transfers("Pending for Arrangement")
        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_ongoing) Then
            Load_transfers("Arranging")
        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_completed) Then
            Load_transfers("Packed")
        ElseIf tabpanel_transfer.SelectedPage.Equals(tab_transfer_cancellation) Then
            Load_transfers("Pending Cancellation")
        End If
    End Sub

    'Tab Selection | Pullouts
    Private Sub tabpanel_pullout_SelectedPageChanged(sender As Object, e As SelectedPageChangedEventArgs) Handles tabpanel_pullouts.SelectedPageChanged

        If tabpanel_pullouts.SelectedPage.Equals(tab_pullout_pending) Then
            Load_BatchPullouts("Pending Arrangement")
        ElseIf tabpanel_pullouts.SelectedPage.Equals(tab_pullout_ongoing) Then
            Load_BatchPullouts("On-Going Arrangement")
        ElseIf tabpanel_pullouts.SelectedPage.Equals(tab_pullout_completed) Then
            Load_BatchPullouts("Packed")
        ElseIf tabpanel_pullouts.SelectedPage.Equals(tab_pullout_unpacking) Then
            Load_BatchPullouts("Unpacking")
        End If
    End Sub

    'F5 to Refresh
    Private Sub frm_warehouse_PackageManagement_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            Load_orders(tabpanel_orders.SelectedPageIndex)
            Load_transfers(tabpanel_transfer.SelectedPageIndex)
        End If
    End Sub

    'BUTTON : PRINT (STOCK TRANSFER)
    Private Sub btn_print_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_transfer_print.ButtonClick
        Dim sub_transfer_id As Integer = grid_stock_transfers_view.GetFocusedRowCellValue(col_sub_transfer_id).ToString.Replace("SubT-", String.Empty)

        Using connect = New MySqlConnection(str)
            connect.Open()

            Dim frm = New frm_warehouse_stocktransfer_dispatch_dialog
            frm.printSubTransfer(sub_transfer_id, "send")

        End Using
    End Sub

    'BUTTON : PRINT (BATCH PULLOUT)
    Private Sub btn_pullout_print_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_pullouts_print.ButtonClick
        Dim frm = New frm_stock_return_batch
        frm.PrintBatchPullout(grid_batch_pullout_view.GetFocusedRowCellValue(col_batch_id))
    End Sub

    'BUTTON : ACTION (BATCH PULLOUT)
    Private Sub btn_pullout_action_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_pullouts_action.ButtonClick
        If tabpanel_pullouts.SelectedPage.Equals(tab_pullout_pending) Then
            Dim frm = New frm_warehouse_start_packing()
            frm.lbl_id.Text = grid_batch_pullout_view.GetFocusedRowCellValue(col_batch_id)
            frm.type = "pullout"
            frm.ShowDialog()

        ElseIf tabpanel_pullouts.SelectedPage.Equals(tab_pullout_ongoing) Then
            Dim frm = New frm_warehouse_pullout_packed()
            frm.txt_pullout_id.EditValue = grid_batch_pullout_view.GetFocusedRowCellValue(col_batch_id)
            frm.txt_supplier.EditValue = grid_batch_pullout_view.GetFocusedRowCellValue(col_batch_pullout_supplier)
            frm.txt_status.EditValue = grid_batch_pullout_view.GetFocusedRowCellValue(col_batch_pullout_status)
            frm.ShowDialog()

        ElseIf tabpanel_pullouts.SelectedPage.Equals(tab_pullout_completed) Then
            MsgBox("Good job!", vbInformation, "Information")

        ElseIf tabpanel_pullouts.SelectedPage.Equals(tab_pullout_unpacking) Then
            'Dim frm As frm_warehouse_sales_order_packed = New frm_warehouse_sales_order_packed()
            'Dim order_id As Integer = grid_orders_view.GetFocusedRowCellValue(col_SalesOrder_id).ToString.Replace("SO", String.Empty)
            'Dim status As String = grid_orders_view.GetFocusedRowCellValue(col_order_status)
            'frm.LoadData(order_id, status)

        End If

        Load_BatchPullouts(tabpanel_pullouts.SelectedPageIndex)
    End Sub

End Class