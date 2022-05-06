Imports MySqlConnector

Public Class frm_collection_payment_ledger

    Private Sub frm_collection_order_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentLogs()
    End Sub


    Public Sub LoadPaymentLogs()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT payment_id, payment_date, order_id, ims_customers.first_name AS customer, ims_users.first_name AS received_by, 
                    current_balance, payment, returns_amount, balance, payment_gateway, payment_ref 
                    FROM ims_payment_logs 
                    LEFT JOIN ims_users on ims_users.usr_id=ims_payment_logs.received_by
                    LEFT JOIN ims_customers ON ims_customers.customer_id=ims_payment_logs.customer_id 
                    ORDER BY payment_id DESC"
                Dim cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_cash.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class