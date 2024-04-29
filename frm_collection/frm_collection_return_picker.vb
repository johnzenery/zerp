Imports MySqlConnector

Public Class frm_collection_return_picker



    Private Sub frm_sales_returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    '--- ONLOAD ---

    Public Sub SalesReturnsLoad(customer As String)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT CONCAT('SR', LPAD(sales_return_id, 5, '0')) AS id, ims_customers.first_name AS customer, amount, created_at
                                        FROM ims_sales_returns
                                        LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                                        WHERE ims_sales_returns.is_deleted=0 AND ims_sales_returns.is_applied=0 AND status='Received' 
                                        AND ims_customers.first_name=@customer", conn)
                    cmd.Parameters.AddWithValue("@customer", customer)
                    Dim da = New MySqlDataAdapter(cmd)
                    Dim dt = New DataTable
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub


    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        sales_return_id = CInt(grid_customer_view.GetFocusedRowCellValue(col_id).ToString.Replace("SR", String.Empty))
        sales_return_amount = grid_customer_view.GetFocusedRowCellValue(col_amount)
        Me.Close()
    End Sub

End Class