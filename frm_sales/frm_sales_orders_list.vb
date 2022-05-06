Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports MySqlConnector

Public Class frm_sales_orders

    ReadOnly conn As New MySqlConnection(str)

    'ON LOAD
    Private Sub frm_sales_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_orders("ON-PROCESS")
        'start_timer() || TIMER WAS DISABLED
    End Sub




    '---- FUNCTIONS ----

    'Load Orders
    Private Sub load_orders(filter As String)

        Dim query_filter As String = String.Empty

        Select Case filter
            Case "ALL" : query_filter = "ims_orders.deleted='0'"
            Case "ON-PROCESS" : query_filter = "(status='Pending' OR status='Pending For Arrangement' OR status='On-Going' OR status='Packed') AND ims_orders.deleted='0'"
            Case "CANCELLED" : query_filter = "(status='Cancelled' OR status='Cancelled Order') AND ims_orders.deleted='0'"
            Case "COMPLETED" : query_filter = "(status='Released' OR status='Completed') AND ims_orders.deleted='0'"
        End Select

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "SELECT concat('SO',LPAD(order_id,5,0)) as order_id, date_ordered, po_reference,
                            AGENT.first_name AS agent, PACKED_BY.first_name AS packed_by, RELEASED_BY.first_name AS released_by, ims_customers.first_name, 
                            transaction_type, payment_status, date_packed, date_released,
                            CONCAT( UPPER( SUBSTRING( payment_type, 1, 1 ) ), LOWER( SUBSTRING( payment_type FROM 2 ) ) ) as payment_type,
                            CONCAT( UPPER( SUBSTRING( shipping_method, 1, 1 ) ) , LOWER( SUBSTRING( shipping_method FROM 2 ) ) ) as shipping_method, status FROM ims_orders  
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            LEFT JOIN ims_users AGENT on AGENT.usr_id=ims_orders.agent
                            LEFT JOIN ims_users PACKED_BY on PACKED_BY.usr_id=ims_orders.packed_by
                            LEFT JOIN ims_users RELEASED_BY on RELEASED_BY.usr_id=ims_orders.released_by
                            WHERE " & query_filter & " ORDER BY date_ordered DESC"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_orders.DataSource = dt
                grid_orders_view.FocusedRowHandle = -1

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

    'Highlight Active Sort Button
    Private Sub HighlightButton(btn As SimpleButton)
        btn_sort_all.Appearance.BackColor = Nothing
        btn_sort_onprocess.Appearance.BackColor = Nothing
        btn_sort_cancelled.Appearance.BackColor = Nothing
        btn_sort_completed.Appearance.BackColor = Nothing

        btn.Appearance.BackColor = DXSkinColors.FillColors.Primary
    End Sub

    Private Sub load_baseOn_active()
        If btn_sort_all.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("ALL")
        ElseIf btn_sort_onprocess.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("ON-PROCESS")
        ElseIf btn_sort_cancelled.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("CANCELLED")
        ElseIf btn_sort_completed.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("COMPLETED")
        End If
    End Sub


    '--- CONTROLS ----

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        load_baseOn_active()
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub

    'CTRL + N | Show New Order, F5 | Sales Order
    Private Sub frm_sales_orders_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.N AndAlso e.Modifiers = Keys.Control Then
            Dim frm = New frm_sales_create_order
            frm.Show()

        ElseIf e.KeyCode = Keys.F5 Then
            load_baseOn_active()
        End If
    End Sub

    'btn_order | Show New Order
    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        Dim frm = New frm_sales_create_order
        frm.Show()
    End Sub

    'btn_quote | Show New Quote
    Private Sub btn_quote_Click(sender As Object, e As EventArgs)
        Dim frm = New frm_sales_create_quotation
        frm.Show()
    End Sub

    'btn_customer | Show New Customer
    Private Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        frm_sales_customers_new.ShowDialog()
    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        If btn_sort_all.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("ALL")
        ElseIf btn_sort_onprocess.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("ON-PROCESS")
        ElseIf btn_sort_cancelled.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("CANCELLED")
        ElseIf btn_sort_completed.Appearance.BackColor.Equals(DXSkinColors.FillColors.Primary) Then
            load_orders("COMPLETED")
        End If
    End Sub

    'btn_order_history
    Private Sub btn_order_history_Click(sender As Object, e As EventArgs)
        frm_sales_order_history.Show()
    End Sub

    'btn_view_order | View Order
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Dim orderid As String = grid_orders_view.GetFocusedRowCellValue(col_order_id)

        Dim view_order = New frm_sales_view_order
        If view_order.LoadData(orderid.Replace("SO", "")) = True Then
            view_order.Show()
        End If

    End Sub

    'btn_sort_all
    Private Sub btn_sort_all_Click(sender As Object, e As EventArgs) Handles btn_sort_all.Click
        load_orders("ALL")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub

    'btn_sort_onprocess
    Private Sub btn_sort_onprocess_Click(sender As Object, e As EventArgs) Handles btn_sort_onprocess.Click
        load_orders("ON-PROCESS")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub

    'btn_sort_cancelled
    Private Sub btn_sort_cancelled_Click(sender As Object, e As EventArgs) Handles btn_sort_cancelled.Click
        load_orders("CANCELLED")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub

    'btn_sort_completed
    Private Sub btn_sort_completed_Click(sender As Object, e As EventArgs) Handles btn_sort_completed.Click
        load_orders("COMPLETED")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub
End Class