Imports MySqlConnector

Public Class frm_collection_cheque_customer

    ReadOnly conn As New MySqlConnection(str)

    '--- ON LOAD ----
    Private Sub frm_accounting_cheque_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerList()
    End Sub





    '--- FUNCTIONS ----
    Private Sub LoadCustomerList()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT customer_id, first_name as customer FROM ims_customers", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_customer.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'btn_select
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click

        Dim cid = grid_customer_view.GetFocusedRowCellValue(col_id)
        Dim name = grid_customer_view.GetFocusedRowCellValue(col_name)

        frm_collection_cheque.customer_id = cid
        frm_collection_cheque.customer_name = name

        Me.Close()

    End Sub

End Class