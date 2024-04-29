Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Views.Grid
Imports MySqlConnector

Public Class frm_warehouse_new_deliveries

    '--- ONLOAD ----
    Private Sub frm_warehouse_new_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.EditValue = Date.Today.AddDays(-7)
        dt_end.EditValue = Date.Now
        LoadDelivered(dt_start.EditValue, dt_end.EditValue)
    End Sub




    '---- FUNCTIONS ----

    'Load Delivery Logs
    Private Sub LoadDelivered(startDate As Date, endDate As Date)

        Dim query = "SELECT reference, ims_inventory.winmodel, ims_inventory.description, qty, date_received, brand, main_category, sub_category,
                    ims_stores.store_name 
                    FROM `ims_deliveries`
                    LEFT JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item
                    LEFT JOIN ims_stores ON ims_stores.store_id=ims_deliveries.store_id
                    WHERE date_received BETWEEN CAST(@startDate AS DATE) AND CAST(@endDate AS DATE) 
                    ORDER BY date_received DESC"
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@endDate", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_delivered.DataSource = dt
                    grid_delivered_view.ClearSelection()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        LoadDelivered(dt_start.EditValue, dt_end.EditValue)
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_delivered.ShowRibbonPrintPreview()
    End Sub

    Private Sub grid_delivered_view_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grid_delivered_view.RowStyle
        'Dim status As String = grid_delivered_view.GetRowCellValue(e.RowHandle, "is_added")

        'Select Case status
        '    Case "YES"
        '        e.Appearance.BackColor = Color.FromArgb(255, 213, 115, 45)
        '        e.Appearance.ForeColor = Color.White
        'End Select

    End Sub

    Private Sub cbb_IsAdded_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs)
        Dim cbb = CType(sender, ComboBoxEdit)
        Dim id As String = grid_delivered_view.GetFocusedRowCellValue(col_id)
        Using conn = New MySqlConnection(str)
            conn.Open()
            Using cmd = New MySqlCommand("UPDATE ims_deliveries SET is_added=@value WHERE reference=@id", conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@value", cbb.EditValue)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub

End Class