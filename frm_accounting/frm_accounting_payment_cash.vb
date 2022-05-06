Imports MySqlConnector

Public Class frm_accounting_payment_cash


    '--- ONLOAD ---
    Private Sub frm_accounting_payment_cash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPayments()
    End Sub



    '--- FUNCTIONS ----

    'Load Payments
    Private Sub LoadPayments()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT *, CONCAT('PV', LPAD(p_voucher_id, 5, 0)) AS voucher_id FROM ims_generated_cash", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_payments.DataSource = dt
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub
End Class