Imports DevExpress.XtraCharts
Imports MySqlConnector

Public Class frm_accounting_inventory_count
    Private Sub _accounting_inventory_count_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim month_date As String = Date.Now.Month
        Dim year_date As String = Date.Now.Year

        dt_start.EditValue = Date.Parse("1/" & month_date & "/" & year_date)
        Dim end_of_month As String = Date.DaysInMonth(Date.Now.Year, Date.Now.Month) & "/" & month_date & "/" & year_date
        dt_end.EditValue = Date.Parse(end_of_month)

        LoadInventoryCount()
    End Sub




    '---- FUNCTIONS ----

    'Load Inventory Count
    Private Sub LoadInventoryCount()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim stores() As String
                Using cmd = New MySqlCommand("SELECT  
	                                            GROUP_CONCAT(DISTINCT store_name) stores 
                                            FROM ims_inventory_count inv
                                            INNER JOIN ims_stores ON ims_stores.store_id=inv.store_id 
                                            GROUP BY date_gathered LIMIT 1", conn)
                    stores = cmd.ExecuteScalar.ToString.Split(",")
                End Using

                Dim sub_query = String.Empty
                For i = 0 To stores.Length - 1
                    sub_query = String.Concat(sub_query, " (SELECT SUM(total_stock_value) FROM ims_inventory_count inner_tbl
                                                INNER JOIN ims_stores ON ims_stores.store_id=inner_tbl.store_id 
                                                WHERE store_name='",
                                                stores(i),
                                                "' AND inv.date_gathered=date_gathered) AS '", stores(i), "'")
                    If Not i = stores.Length - 1 Then sub_query = String.Concat(sub_query, ",")
                Next

                Using cmd = New MySqlCommand("SELECT  
	                                            date_gathered as 'Date', " & sub_query & ",
                                                (SELECT SUM(total_stock_value) FROM ims_inventory_count inner_tbl WHERE inv.date_gathered=date_gathered) AS 'Total Value'
                                            FROM ims_inventory_count inv
                                            WHERE date_gathered BETWEEN @start_date AND @end_date
                                            GROUP BY date_gathered", conn)
                    cmd.Parameters.AddWithValue("@start_date", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@end_date", dt_end.EditValue)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_inventory.DataSource = dt
                    SetInventoryCountGui()
                    chart_inventoryStock(stores)

                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Grid View
    Private Sub SetInventoryCountGui()
        grid_inventory_view.Columns(0).DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        grid_inventory_view.Columns(0).DisplayFormat.FormatString = "MM/dd/yyyy"
        grid_inventory_view.Columns(0).AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        grid_inventory_view.Columns(0).MaxWidth = 150

        For i = 1 To grid_inventory_view.Columns.Count - 1
            grid_inventory_view.Columns(i).DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            grid_inventory_view.Columns(i).DisplayFormat.FormatString = "n2"
        Next

    End Sub

    Private Sub chart_inventoryStock(stores As String())
        Try
            'Plot Coordinator's Data to Chart
            Using dt = CType(grid_inventory.DataSource, DataTable)

                'Clear All Series
                chart_inventory.Series.Clear()

                'Create Series with Stores
                For i = 1 To stores.Length
                    Dim series As Series = New Series(stores(i - 1), ViewType.StackedBar) With {
                        .ArgumentScaleType = ScaleType.Auto,
                        .ValueScaleType = ScaleType.Numerical
                    }

                    'Add Series to Chart
                    chart_inventory.Series.Add(series)

                    Dim series_coordinators = chart_inventory.Series(stores(i - 1))

                    'Clear Series Points
                    series_coordinators.Points.Clear()

                    'Plot Series points to Chart
                    For j = 0 To dt.Rows.Count - 1
                        series_coordinators.Points.Add(New SeriesPoint(CDate(dt.Rows(j).Item(0)).ToString("MM/dd/yyyy"), CDec(dt.Rows(j).Item(i))))
                    Next

                Next

                'Set Charts's Formats
                chart_inventory.Legend.Direction = LegendDirection.LeftToRight
                chart_inventory.SeriesTemplate.Label.TextPattern = "{V:C2}"
                Dim axisXLabel As AxisLabel = CType(chart_inventory.Diagram, XYDiagram).AxisX.Label
                Dim axisYLabel As AxisLabel = CType(chart_inventory.Diagram, XYDiagram).AxisY.Label
                axisXLabel.TextPattern = "{A:MM-dd-yyyy}"
                axisYLabel.TextPattern = "{V:C2}"

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_view | View Button
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        LoadInventoryCount()
    End Sub
End Class