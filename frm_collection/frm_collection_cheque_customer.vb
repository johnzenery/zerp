Imports MySqlConnector

Public Class frm_collection_cheque_customer

    Public ccdata As CollectionChequeData

    '--- ON LOAD ----
    Private Sub frm_accounting_cheque_customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCustomerList()
    End Sub





    '--- FUNCTIONS ----
    Private Sub LoadCustomerList()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT customer_id, first_name as customer FROM ims_customers", connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_customer.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_select
    Private Sub btn_select_Click_1(sender As Object, e As EventArgs) Handles btn_select.Click

        ccdata.customer_id = grid_customer_view.GetFocusedRowCellValue(col_id)
        ccdata.customer_name = grid_customer_view.GetFocusedRowCellValue(col_name)

        DialogResult = DialogResult.OK
        Me.Close()

    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class