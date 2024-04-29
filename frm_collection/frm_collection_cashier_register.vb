Imports MySqlConnector

Public Class frm_collection_cashier_register



    Private Sub frm_collection_mix_payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Orders_CEC()
        Load_Orders_TERMS()
    End Sub



    '--- FUNCTIONS

    'LOAD ORDERS
    Private Sub Load_Orders_CEC()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "SELECT concat('SO',LPAD(order_id,5,0)) as orderid, date_ordered, ims_orders.terms, 
                            AGENT.first_name 'representative', ims_customers.first_name 'customer', 
                            payment_status, payment_type, shipping_method, status, (amount_due - paid_amount) amount_due
                            FROM ims_orders  
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            LEFT JOIN ims_users AGENT on AGENT.usr_id=ims_orders.agent
                            LEFT JOIN ims_users ORGANIZED_BY on ORGANIZED_BY.usr_id=ims_orders.packed_by
                            LEFT JOIN ims_users RELEASED_BY on RELEASED_BY.usr_id=ims_orders.released_by
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            WHERE payment_type='CEC' AND NOT (((STATUS='Cancelled' OR STATUS='Cancelled Order') AND payment_status='UNPAID') OR (STATUS='Completed' AND payment_status='PAID') OR (payment_status='PAID')) AND ims_orders.deleted='0'
                            ORDER BY date_ordered DESC"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_cec.DataSource = dt
                grid_cec_view.BestFitColumns()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub Load_Orders_TERMS()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "SELECT concat('SO',LPAD(order_id,5,0)) as orderid, date_ordered, ims_orders.terms, 
                            AGENT.first_name 'representative', ims_customers.first_name 'customer', 
                            payment_status, payment_type, shipping_method, status, (amount_due - paid_amount) amount_due
                            FROM ims_orders  
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            LEFT JOIN ims_users AGENT on AGENT.usr_id=ims_orders.agent
                            LEFT JOIN ims_users ORGANIZED_BY on ORGANIZED_BY.usr_id=ims_orders.packed_by
                            LEFT JOIN ims_users RELEASED_BY on RELEASED_BY.usr_id=ims_orders.released_by
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            WHERE payment_type='Terms' AND NOT (((STATUS='Cancelled' OR STATUS='Cancelled Order') AND payment_status='UNPAID') OR (STATUS='Completed' AND payment_status='PAID') OR (payment_status='PAID')) AND ims_orders.deleted='0'
                            ORDER BY date_ordered DESC"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_terms.DataSource = dt
                grid_terms_view.BestFitColumns()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'BUTTON : Payment Ledger
    Private Async Sub btn_payment_history_Click(sender As Object, e As EventArgs) Handles btn_payment_history.Click
        Await frm_main.LoadFrm(New frm_collection_payment_journal, "frm_collection_payment_ledger")
    End Sub

    'BUTTON : Terms Collection
    Private Sub btn_terms_collection_Click(sender As Object, e As EventArgs) Handles btn_terms_collection.Click
        frm_collection_terms.Show()
    End Sub

    'BUTTON : Collection Receipts
    Private Sub btn_collection_receipts_Click(sender As Object, e As EventArgs) Handles btn_collection_receipts.Click
        frm_collection_receipts.ShowDialog()
    End Sub

    'BUTTON : Refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Load_Orders_CEC()
        Load_Orders_TERMS()
    End Sub

    'BUTTON : PAY ORDER
    Private Sub btn_pay_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_pay_order.ButtonClick
        Dim frm = New frm_collection_cashier_register_pay
        frm.lbl_orderid.Text = grid_cec_view.GetFocusedRowCellValue(col_orderid)
        frm.lbl_customer_name.Text = grid_cec_view.GetFocusedRowCellValue(col_customer)
        frm.lbl_amount.Text = FormatCurrency(grid_cec_view.GetFocusedRowCellValue(col_amount))
        frm.txt_balance.EditValue = FormatCurrency(grid_cec_view.GetFocusedRowCellValue(col_amount))
        If frm.ShowDialog() = DialogResult.OK Then
            Load_Orders_CEC()
            Load_Orders_TERMS()
        End If
    End Sub

    'BUTTON : REFUND
    Private Sub btn_refund_Click(sender As Object, e As EventArgs) 
        Dim frm = New frm_collection_cashier_refund
        frm.ShowDialog()
    End Sub

End Class