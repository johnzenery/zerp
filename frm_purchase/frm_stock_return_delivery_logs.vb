Imports MySqlConnector

Public Class frm_stock_return_delivery_logs

    Private ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ---
    Private Sub frm_stock_return_delivery_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveries()
    End Sub



    '--- FUNCTIONS ---
    Private Sub LoadDeliveries()
        Try
            conn.Open()
            Using cmd = New MySqlCommand("SELECT rs_returns_deliveries.id, rid, qty_received, return_action, delivery_ref, rs_returns_deliveries.serial, remarks, credit_cost,
                                                winmodel, supmodel, ims_users.first_name AS received_by, received_at, ims_suppliers.supplier, ims_inventory.description
                                          FROM rs_returns_deliveries
                                          INNER JOIN rs_returns ON rs_returns.id=rs_returns_deliveries.rid
                                          INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                          INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                                          LEFT JOIN ims_users ON ims_users.usr_id=rs_returns_deliveries.received_by
                                          ORDER BY received_at DESC", conn)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_deliveries.DataSource = dt
                grid_deliveries_view.BestFitColumns()
                col_description.MaxWidth = 500
            End Using
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


End Class