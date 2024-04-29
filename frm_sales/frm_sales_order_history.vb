Imports MySqlConnector

Public Class frm_sales_order_history


    'ON LOAD
    Private Sub frm_sales_order_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Customers()
        Load_OrderHistory()
    End Sub




    '---- FUNCTIONS ----

    'Load Orders
    Private Sub Load_OrderHistory()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT concat('SO',LPAD(order_id,5,0)) as order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, transaction_type, payment_status, date_packed, date_released,
                            CONCAT( UPPER( SUBSTRING( payment_type, 1, 1 ) ) , LOWER( SUBSTRING( payment_type FROM 2 ) ) ) as payment_type,
                            CONCAT( UPPER( SUBSTRING( shipping_method, 1, 1 ) ) , LOWER( SUBSTRING( shipping_method FROM 2 ) ) ) as shipping_method, status FROM ims_orders 
                            INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id 
                            INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id 
                            WHERE (status='Completed' OR status='Cancelled') AND ims_orders.deleted='0' ORDER BY date_ordered DESC"
                Using cmd = New MySqlCommand(query, connection)
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_orders.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Customers Name
    Private Sub Load_Customers()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("SELECT first_name FROM ims_customers", connection)
                    Dim rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_customer.Properties.Items.Add(rdr("first_name"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Filter by Customer
    Private Sub cbb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedIndexChanged
        Try
            Dim dt = CType(grid_orders.DataSource, DataTable)
            Dim dataview = New DataView(dt)

            dt.DefaultView.RowFilter = "first_name LIKE '%" & cbb_customer.Text.Trim & "%'"
            grid_orders.DataSource = dt
        Catch ex As Exception

        End Try
    End Sub

    'View Order
    Private Sub grid_orders_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_orders_view.RowCellClick
        If grid_orders_view.FocusedColumn.FieldName = "order_id" Then
            Dim orderid As String = grid_orders_view.GetRowCellValue(e.RowHandle, "order_id")

            Dim view_order = New frm_sales_view_order
            view_order.LoadData(orderid.Replace("SO", String.Empty))
            view_order.Show()
        End If
    End Sub
End Class