Imports MySqlConnector

Public Class frm_collection_payments


    '--- ON LOAD ----
    Private Sub frm_accounting_payments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_cash_orders()
        load_cheque_orders()
        load_epay_orders()
        start_timer()
    End Sub





    '--- FUNCTIONS ----

    'Load Unpaid (CASH)
    Public Sub load_cash_orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT 
                            status, 
                            order_id, 
                            date_ordered, 
                            ims_customers.first_name as customer, 
                            ims_users.first_name as agent, 
                            shipping_method, 
                            IF(STRCMP(payment_status, 'REFUND') = 0, IFNULL(paid_amount,0), (amount_due - IFNULL(paid_amount,0))) AS amount_due, 
                            IFNULL(payment_status, 'UNPAID') as payment_status 
                        FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='cash' AND ims_orders.deleted='0' AND NOT (((STATUS='Cancelled' OR STATUS='Cancelled Order') AND payment_status='UNPAID') OR (STATUS='Completed' AND payment_status='PAID') OR (payment_status='PAID'))
                        ORDER BY order_id DESC"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_cash.DataSource = dt
                grid_cash_view.BestFitColumns()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load Unpaid (CHEQUE)
    Public Sub load_cheque_orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT status, order_id, date_ordered, ims_customers.first_name as customer, ims_users.first_name as agent, shipping_method, amount_due, IFNULL(payment_status, 'UNPAID') as payment_status FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='cheque' AND (payment_status IS NULL OR NOT payment_status = 'PAID') AND NOT status='Cancelled' AND ims_orders.deleted='0'
                        ORDER BY order_id DESC"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_cheque.DataSource = dt
                grid_cheque_view.BestFitColumns()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load Unpaid (TERMS)
    Public Sub load_epay_orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT 
                            status, order_id, date_ordered, ims_customers.first_name as customer, ims_users.first_name as agent, shipping_method, 
                            IF(STRCMP(payment_status, 'REFUND') = 0, IFNULL(paid_amount,0), (amount_due - IFNULL(paid_amount,0))) AS amount_due, 
                            IFNULL(payment_status, 'UNPAID') as payment_status,
                            payment_type, payment_option, payment_details FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='E-Payment' AND NOT payment_status = 'PAID' AND NOT status='Cancelled' AND ims_orders.deleted='0'
                        ORDER BY order_id DESC"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_epay.DataSource = dt
                grid_epay_view.BestFitColumns()
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

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        load_cash_orders()
        load_cheque_orders()
        load_epay_orders()
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub




    '--- CONTROLS -----

    'CASH Double Cell Click
    Private Sub grid_cash_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_cash_view.DoubleClick

        Dim status = grid_cash_view.GetFocusedRowCellValue(col_payment_status)
        Dim id = grid_cash_view.GetFocusedRowCellValue(col_order_id)
        Dim cus = grid_cash_view.GetFocusedRowCellValue(col_customer)
        Dim ad = Math.Abs(CDec(grid_cash_view.GetFocusedRowCellValue(col_amount_due)))

        If status.Equals("OVERPAID") Or status.Equals("REFUND") Then
            Dim frm = New frm_collection_refund
            frm.LoadData(id, cus, ad, status)
            If frm.ShowDialog() = DialogResult.OK Then
                load_cash_orders()
            End If
        Else
            Dim frm = New frm_collection_cash
            frm.LoadData(id, cus, ad)
            If frm.ShowDialog() = DialogResult.OK Then
                load_cash_orders()
            End If
        End If

    End Sub

    'EPAY Double Click
    Private Sub grid_epay_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_epay_view.DoubleClick

        Dim status = grid_epay_view.GetFocusedRowCellValue(col_payment_status)
        Dim id = grid_epay_view.GetFocusedRowCellValue(col_order_id)
        Dim cus = grid_epay_view.GetFocusedRowCellValue(col_customer)
        Dim ad = grid_epay_view.GetFocusedRowCellValue(col_amount_due)

        If status.Equals("OVERPAID") Or status.Equals("REFUND") Then
            Dim frm = New frm_collection_refund
            frm.LoadData(id, cus, ad, status)
            If frm.ShowDialog() = DialogResult.OK Then
                load_epay_orders()
            End If
        Else
            Dim frm = New frm_collection_epayment()
            frm.LoadData(id, cus, ad)
            If frm.ShowDialog() = DialogResult.OK Then
                load_epay_orders()
            End If
        End If

    End Sub

    'btn_payment_history
    Private Sub btn_payment_history_Click(sender As Object, e As EventArgs) Handles btn_payment_history.Click
        frm_collection_payment_journal.Show()
    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_cash_orders()
        load_cheque_orders()
        load_epay_orders()
    End Sub

    'btn_terms
    Private Sub btn_terms_collection_Click(sender As Object, e As EventArgs) Handles btn_terms_collection.Click
        frm_collection_terms.Show()
    End Sub

    'Show Chequebook
    Private Sub btn_chequebook_Click(sender As Object, e As EventArgs) Handles btn_chequebook.Click
        frm_collection_cheque_books.Show()
    End Sub

    'Show Collection Receipts
    Private Sub btn_collection_receipts_Click(sender As Object, e As EventArgs) Handles btn_collection_receipts.Click
        frm_collection_receipts.ShowDialog()
    End Sub

    'Refresh via F5
    Private Sub frm_collection_payments_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            load_cash_orders()
            load_cheque_orders()
            load_epay_orders()
        End If
    End Sub
End Class
