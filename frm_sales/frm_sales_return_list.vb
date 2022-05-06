Imports MySqlConnector

Public Class frm_sales_return_list


    '--- ONLOAD ----
    Private Sub frm_sales_return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturns()
    End Sub


    '--- FUNCTIONS ----

    'Load Sales Returns
    Private Sub LoadReturns()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT CONCAT('SR', LPAD(sales_return_id,5,0)) sales_return_id, amount, created_at, status,
                                ims_customers.first_name AS customer, ims_users.first_name AS sales_coordinator
                                FROM ims_sales_returns 
                                LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id 
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_sales_returns.created_by 
                                WHERE ims_sales_returns.is_deleted=0 AND is_applied='0'
                                ORDER BY sales_return_id DESC", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub






    '--- CONTROLS ---

    'New Sales Return Button
    Private Sub btn_new_return_Click(sender As Object, e As EventArgs) Handles btn_new_return.Click
        frm_main.LoadFrm(New frm_sales_return_new)
    End Sub

    'View Sales Return
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Dim id = grid_returns_view.GetFocusedRowCellValue(col_rid).ToString.Replace("SR", "")
        Dim frm = New frm_sales_return_new
        frm.Show()
        frm.LoadEdit(id)
    End Sub


End Class