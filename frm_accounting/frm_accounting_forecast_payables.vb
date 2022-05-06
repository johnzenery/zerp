Imports MySqlConnector

Public Class frm_accounting_forecast_payables


    '--- ONLOAD ---
    Private Sub frm_accounting_forecast_payables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim month_date As String = Date.Now.Month
        Dim year_date As String = Date.Now.Year

        dt_start.EditValue = Date.Parse("1/" & month_date & "/" & year_date)
        Dim end_of_month As String = Date.DaysInMonth(Date.Now.Year, Date.Now.Month) & "/" & month_date & "/" & year_date
        dt_end.EditValue = Date.Parse(end_of_month)

        LoadActualPayables()
        LoadForeCasted()
    End Sub



    '--- FUNCTIONS ----

    'Load LoadActualPayables
    Private Sub LoadActualPayables()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT mondays, SUM(total) as total FROM (
	                                                SELECT * FROM (
		                                                SELECT
			                                                STR_TO_DATE(CONCAT(YEAR(cheque_date), WEEK(cheque_date), 'Monday'), '%X %V %W') AS mondays,
			                                                SUM(amount) AS total
		                                                FROM ims_generated_cheques
		                                                GROUP BY mondays
		                                                ORDER BY mondays
	                                                ) tbl_cheque
	                                                UNION ALL	
	                                                SELECT * FROM (
		                                                SELECT
			                                                STR_TO_DATE(CONCAT(YEAR(payment_date), WEEK(payment_date), 'Monday'), '%X %V %W') AS mondays,
			                                                SUM(amount) AS total
		                                                FROM ims_generated_cash
		                                                GROUP BY mondays
		                                                ORDER BY mondays
	                                                ) tbl_cash
                                                ) tbl
                                                WHERE mondays BETWEEN @start_date AND @end_date
                                                GROUP BY mondays", conn)
                    cmd.Parameters.AddWithValue("@start_date", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@end_date", dt_end.EditValue)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_actual_payables.DataSource = dt

                    'Display Actual Payables
                    chart_ActualPayables()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load LoadForeCasted
    Private Sub LoadForeCasted()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT 
	                                                STR_TO_DATE(CONCAT(YEAR(due_date), WEEK(due_date), 'Monday'), '%Y %U %W') AS mondays,
	                                                SUM(amount) AS total
                                                FROM (
	                                                SELECT 
		                                                payable_id, terms,
		                                                DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) AS due_date, amount 
	                                                FROM ims_delivery_receipts
	                                                INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                                ) tbl
                                                WHERE due_date BETWEEN @start_date AND @end_date
                                                GROUP BY mondays
                                                ORDER BY mondays", conn)
                    cmd.Parameters.AddWithValue("@start_date", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@end_date", dt_end.EditValue)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_forecasted_payables.DataSource = dt

                    'Display Actual Payables
                    chart_ForecastedPayables()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Sales Agent/Coordinator Total Transactions, Gross, Net
    Private Sub chart_ActualPayables()
        Try

            'Plot Data to Chart
            Using dt = DirectCast(grid_actual_payables.DataSource, DataTable)
                Dim total_actual As Decimal = 0.00
                Dim series = chart_actual_payables.Series("Actual Payables")

                series.Points.Clear()

                For i = 0 To dt.Rows.Count - 1
                    series.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0), CDec(dt.Rows(i).Item(1))))
                    total_actual += CDec(dt.Rows(i).Item(1))
                Next

                'Display Total
                lbl_actual_total.Text = String.Concat("Total: ", FormatCurrency(total_actual))

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Sales Agent/Coordinator Total Transactions, Gross, Net
    Private Sub chart_ForecastedPayables()
        Try

            'Plot Data to Chart
            Using dt = DirectCast(grid_forecasted_payables.DataSource, DataTable)
                Dim total_forecast As Decimal = 0.00
                Dim series = chart_forecasted_payables.Series("Forecasted Payables")

                series.Points.Clear()

                For i = 0 To dt.Rows.Count - 1
                    series.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0), CDec(dt.Rows(i).Item(1))))
                    total_forecast += CDec(dt.Rows(i).Item(1))
                Next

                'Display Total
                lbl_future_total.Text = String.Concat("Total: ", FormatCurrency(total_forecast))

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Button View
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        LoadActualPayables()
        LoadForeCasted()
    End Sub
End Class