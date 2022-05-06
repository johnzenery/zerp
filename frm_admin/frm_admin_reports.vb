Imports DevExpress.XtraCharts
Imports DevExpress.XtraEditors
Imports MySqlConnector

Public Class frm_admin_reports


    '--- ONLOAD ---
    Private Sub frm_admin_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim month_date As String = Date.Now.Month
        Dim year_date As String = Date.Now.Year

        dt_start.EditValue = Date.Parse("1/" & month_date & "/" & year_date)
        Dim end_of_month As String = Date.DaysInMonth(Date.Now.Year, Date.Now.Month) & "/" & month_date & "/" & year_date
        dt_end.EditValue = Date.Parse(end_of_month)

        Load_Selected_Tab()
    End Sub




    '--- FUNCTIONS ----

    'Loading Selected Tab
    Private Sub Load_Selected_Tab()
        Select Case TabControl.SelectedTabPage.Name
            Case tab_sales.Name : Load_Sales_Over_Time()
            Case tab_transactions.Name : Load_Sales_per_Transactions(dt_start.EditValue, dt_end.EditValue)
            Case tab_users.Name : Load_SalesCoordinatorAgent()
            Case tab_user_performance.Name
                Load_CoordinatorAgent_list()
                Load_SalesCoordinatorAgent_performance()
            Case tab_product.Name : Load_ProductPerformace()
            Case tab_customer_performance.Name : Load_CustomerPerformance()
        End Select
    End Sub

    'Load Totals
    Private Sub LoadTotals()
        Dim dt = CType(grid_sales_report.DataSource, DataTable)

        Dim total_cost As Decimal = 0.00
        Dim total_cash As Decimal = 0.00
        Dim total_cheque As Decimal = 0.00
        Dim total_epay As Decimal = 0.00
        Dim total_nonvatable_sales As Decimal = 0.00
        Dim total_vatable_sales As Decimal = 0.00
        Dim total_sales As Decimal = 0.00
        Dim total_transactions As Integer = 0
        Dim total_avg_transc_amout As Decimal = 0.00
        Dim total_avg_sales_margin As String = String.Empty

        For i = 0 To dt.Rows.Count - 1
            total_cost += dt.Rows(i).Item(1)
            total_cheque += dt.Rows(i).Item(2)
            total_epay += dt.Rows(i).Item(3)
            total_cash += dt.Rows(i).Item(4)
            total_nonvatable_sales += dt.Rows(i).Item(5)
            total_vatable_sales += dt.Rows(i).Item(6)
            total_sales += dt.Rows(i).Item(7)
            total_transactions += dt.Rows(i).Item(8)
        Next

        'lbl_totalcost.Text = "Total Cost: " & FormatCurrency(total_cost, 2)
        'lbl_cash.Text = "Cash: " & FormatCurrency(total_cash, 2)
        'lbl_cheques.Text = "Cheque/Terms: " & FormatCurrency(total_cheque, 2)
        'lbl_epay.Text = "E-Pay: " & FormatCurrency(total_epay, 2)
        'lbl_gross_sales.Text = "Total Sales: " & FormatCurrency(total_sales, 2)
        'lbl_no_transactions.Text = "Transactions: " & total_transactions
        'lbl_avg_sales_amount.Text = "Avg. Amount: " & FormatCurrency(total_sales / total_transactions, 2)
        'lbl_ave_sales_margin.Text = "Avg. Margin: " & Math.Round(((total_sales - total_cost) / total_sales) * 100, 0) & "%"
        lbl_totalcost.Text = FormatCurrency(total_cost, 2)
        lbl_cash.Text = FormatCurrency(total_cash, 2)
        lbl_cheques.Text = FormatCurrency(total_cheque, 2)
        lbl_epay.Text = FormatCurrency(total_epay, 2)
        lbl_nonvatable_sales.Text = FormatCurrency(total_nonvatable_sales, 2)
        lbl_vatable_sales.Text = FormatCurrency(total_vatable_sales, 2)
        lbl_gross_sales.Text = FormatCurrency(total_sales, 2)
        lbl_no_transactions.Text = total_transactions
        lbl_avg_sales_amount.Text = FormatCurrency(total_sales / total_transactions, 2)
        lbl_ave_sales_margin.Text = Math.Round(((total_sales - total_cost) / total_sales) * 100, 0) & "%"
    End Sub



    '-->> SALES REPORTS

    'Load Sales Report
    Private Sub Load_Sales_Over_Time()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'DISPLAY DATA WITH STORED PROCEDURE
                Dim query = "SELECT 
	                            datee, 
	                            SUM(cost * qty) total_cost,
	                            SUM(IF(payment_type='Cheque' OR payment_type='Terms', price, 0.00)) total_terms,
	                            SUM(IF(payment_type='E-Payment', price, 0.00)) total_epay,
	                            SUM(IF(payment_type='Cash', price, 0.00)) total_cash,
                                SUM(IF(is_vatable=0, price, 0.00)) nonvat_sales,
	                            SUM(IF(is_vatable=1, (price/1.12), 0.00)) vat_sales,
	                            SUM(price) total_sales,
	                            COUNT(DISTINCT(order_id)) total_transactions,
	                            ROUND(SUM(price) / COUNT(DISTINCT(order_id)),2) avg_transc_amount,
	                            (SUM(price) - SUM(cost * qty)) / SUM(price) avg_sales_margin
                            FROM (
	                            SELECT
		                            DATE(purchase_date) datee, cost, qty, price, ims_orders.payment_type, ims_orders.order_id, ims_orders.payment_status, is_vatable
	                            FROM ims_sales
	                            INNER JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id
                            ) tbl
                            WHERE datee BETWEEN @start_date AND @end_date AND payment_status='PAID'
                            GROUP BY datee
                            ORDER BY datee DESC"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@start_date", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@end_date", dt_end.EditValue)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_sales_report.DataSource = dt
                    chart_SalesOverTime()
                    LoadTotals()

                End Using
            End Using

        Catch ex As Exception
            If Not ex.GetType.ToString = "System.DivideByZeroException" Then
                MsgBox(ex.Message, vbCritical, "Error")
            End If
        End Try
    End Sub

    'Load Sales Report
    Private Sub Load_Sales_per_Transactions(StartDate As Date, EndDate As Date)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'DISPLAY DATA WITH STORED PROCEDURE
                Dim query = "SELECT 
	                            order_id, ims_customers.first_name AS customer,
	                            DATE(date_released) AS released_date, 
	                            (SELECT SUM(cost * qty) FROM ims_sales WHERE order_id=ims.order_id) AS total_cost, 
	                            (SELECT SUM(price) FROM ims_sales WHERE order_id=ims.order_id) AS gross_sales, 
	                            (SELECT (SUM(price) - SUM(cost * qty)) FROM ims_sales WHERE order_id=ims.order_id) AS net_sales,
	                            (SELECT (SUM(price) - SUM(cost * qty)) / SUM(price) FROM ims_sales WHERE order_id=ims.order_id) AS sales_margin,
	                            ims_users.first_name AS coordinator 
                            FROM ims_orders ims
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims.customer
                            INNER JOIN ims_users ON ims_users.usr_id=ims.agent
                            WHERE ims.deleted='0' AND payment_status='PAID' AND DATE(date_released) BETWEEN @StartDate AND @EndDate"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StartDate", StartDate)
                    cmd.Parameters.AddWithValue("@EndDate", EndDate)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_transaction.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Sales Coordinator / Agent
    Private Sub Load_SalesCoordinatorAgent()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'LOAD SALES REPORT OF COORDINATORS
                Dim query_coordinator = "SELECT 
	                                        (SELECT first_name FROM ims_users WHERE usr_id=agent) AS sales_coordinator,
	                                        IFNULL((SELECT COUNT(*) FROM ims_orders WHERE agent=ims.agent AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY) GROUP BY agent),0) AS transactions,
	                                        (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE agent=ims.agent AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY)) AS unique_customer,
	                                        SUM(DISTINCT (SELECT SUM(cost * qty) FROM ims_sales INNER JOIN ims_orders AS a ON a.order_id=ims_sales.order_id WHERE DATE(purchase_date) = DATE(ims.date_released) AND a.payment_status='PAID' AND a.agent=ims.agent)) AS total_cost,
	                                        SUM(DISTINCT (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE DATE(date_released) = DATE(ims.date_released) AND agent=ims.agent)) AS gross_sales
                                        FROM ims_orders ims
                                        WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND DATE(date_released) BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY) 
                                        GROUP BY agent"
                Using cmd = New MySqlCommand(query_coordinator, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_coordinator.DataSource = dt
                End Using


                'LOAD SALES REPORT OF AGENTS
                Dim query_agents = "SELECT 
	                                    IFNULL((SELECT first_name FROM ims_users WHERE usr_id=sales_agent), 'Unassigned') AS sales_agents,
	                                    (SELECT COUNT(*) FROM ims_orders WHERE sales_agent=ims.sales_agent AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY) AND payment_status='PAID' AND deleted='0' GROUP BY sales_agent) AS transactions,
	                                    (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE sales_agent=ims.sales_agent AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY)) AS unique_customer,
	                                    SUM(DISTINCT (SELECT SUM(cost * qty) FROM ims_sales INNER JOIN ims_orders AS a ON a.order_id=ims_sales.order_id WHERE DATE(purchase_date) = DATE(ims.date_released) AND a.payment_status='PAID' AND a.sales_agent=ims.sales_agent)) AS total_cost,
	                                    SUM(DISTINCT (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders WHERE DATE(date_released) = DATE(ims.date_released) AND sales_agent=ims.sales_agent)) AS gross_sales
                                    FROM ims_orders ims
                                    WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND date_released BETWEEN @StartDate AND DATE_ADD(@EndDate, INTERVAL 1 DAY)  
                                     GROUP BY sales_agent"
                Using cmd = New MySqlCommand(query_agents, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_agents.DataSource = dt
                End Using

                'Plot To Chart
                chart_SalesByUsers()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Sales Coordinator / Agent Performance
    Private Sub Load_SalesCoordinatorAgent_performance()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'LOAD SALES REPORT OF COORDINATORS
                Dim query_coordinator = "SELECT 
	                                        DATE(date_released) AS datee,
	                                        (SELECT COUNT(*) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND agent=ims.agent) AS transactions,
	                                        (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND agent=ims.agent) AS unique_customer,
	                                        (SELECT SUM(cost * qty) FROM ims_sales 
		                                        INNER JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id 
		                                        WHERE DATE(purchase_date) = datee AND ims_orders.payment_status='PAID' AND agent=ims.agent) AS total_cost,	
	                                        (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders 
		                                        WHERE DATE(date_released) = datee AND agent=ims.agent) AS gross_sale
                                        FROM ims_orders ims
                                        WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND agent=@coordinator
                                        AND DATE(date_released) BETWEEN @StartDate AND @EndDate
                                        GROUP BY datee
                                        ORDER BY datee DESC"
                Using cmd = New MySqlCommand(query_coordinator, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.Parameters.AddWithValue("@coordinator", lbl_coordinator.Text)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_perf_coor.DataSource = dt

                End Using

                'LOAD SALES REPORT OF COORDINATORS
                Dim query_agent = "SELECT 
	                                    DATE(date_released) AS datee,
	                                    (SELECT COUNT(*) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND sales_agent=ims.sales_agent) AS transactions,
	                                    (SELECT COUNT(DISTINCT customer) FROM ims_orders WHERE DATE(date_released)=datee AND payment_status='PAID' AND deleted='0' AND sales_agent=ims.sales_agent) AS unique_customer,
	                                    (SELECT SUM(cost * qty) FROM ims_sales 
		                                    INNER JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id 
		                                    WHERE DATE(purchase_date) = datee AND ims_orders.payment_status='PAID' AND sales_agent=ims.sales_agent) AS total_cost,	
	                                    (SELECT IFNULL(SUM(paid_amount), 0.00) FROM ims_orders 
		                                    WHERE DATE(date_released) = datee AND sales_agent=ims.sales_agent) AS gross_sale
                                    FROM ims_orders ims
                                    WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND payment_status='PAID' AND deleted='0' AND sales_agent=@agent
                                    AND DATE(date_released) BETWEEN @StartDate AND @EndDate 
                                    GROUP BY datee
                                    ORDER BY datee DESC"
                Using cmd = New MySqlCommand(query_agent, conn)
                    'cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    'cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    'cmd.Parameters.AddWithValue("@agent", lbl_agent.Text)
                    'cmd.ExecuteNonQuery()
                    'Dim dt = New DataTable
                    'Dim da = New MySqlDataAdapter(cmd)
                    'da.Fill(dt)

                    'grid_perf_sa.DataSource = dt

                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    cmd.Parameters.AddWithValue("@agent", lbl_agent.Text)
                    Using rdr = cmd.ExecuteReader

                        Dim dt = New DataTable
                        dt.Columns.Add("datee", GetType(Date))
                        dt.Columns.Add("transactions", GetType(Integer))
                        dt.Columns.Add("unique_customer", GetType(Integer))
                        dt.Columns.Add("total_cost", GetType(Decimal))
                        dt.Columns.Add("gross_sale", GetType(Decimal))
                        dt.Columns.Add("avg_sales_margin", GetType(String))

                        While rdr.Read
                            dt.Rows.Add(
                                CDate(CDate(rdr("datee")).ToString("dd/MM/yyyy")), rdr("transactions"), rdr("unique_customer"), rdr("total_cost"), rdr("gross_sale"), Math.Round(((rdr("gross_sale") - rdr("total_cost")) / rdr("gross_sale")) * 100, 0) & "%")
                        End While

                        grid_perf_sa.DataSource = dt

                    End Using
                End Using

                'Show tp Chart
                chart_performance()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Coordinator/Agent List
    Private Sub Load_CoordinatorAgent_list()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                cbb_coordinator.Properties.Items.Clear()
                cbb_agent.Properties.Items.Clear()
                cbb_agent.Properties.Items.Add("Unassigned")

                Using cmd = New MySqlCommand("SELECT first_name, role_id FROM ims_users WHERE role_id=7 OR role_id=10", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            If rdr("role_id") = 7 Then
                                cbb_coordinator.Properties.Items.Add(rdr("first_name"))
                            ElseIf rdr("role_id") = 10 Then
                                cbb_agent.Properties.Items.Add(rdr("first_name"))
                            End If
                        End While
                        cbb_coordinator.SelectedIndex = 0
                        cbb_agent.SelectedIndex = 0
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load User ID Upon Selection
    Private Sub GetUserID(cbb_ As ComboBoxEdit, lbl_ As LabelControl)

        'IF UNASSIGNED
        If cbb_.Text.Equals("Unassigned") Then
            lbl_.Text = "0"
            Return
        End If

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT usr_id FROM ims_users WHERE first_name=@name", conn)
                    cmd.Parameters.AddWithValue("@name", cbb_.Text)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            lbl_.Text = rdr("usr_id")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Product Performance
    Private Sub Load_ProductPerformace()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'LOAD SALES REPORT OF COORDINATORS
                Dim query = "SELECT 
	                             pid, winmodel, description, 
	                             SUM(s.qty) AS qty, 
	                             SUM(s.qty * s.cost) AS total_cost, 
	                             SUM(price) AS total_sales, 
	                             SUM(price - (s.qty * s.cost)) AS gross_income,
	                             (SUM(price) - SUM(s.qty * s.cost)) / SUM(price) AS margin
                            FROM ims_sales s
                            INNER JOIN ims_inventory ON ims_inventory.pid=s.item
                            WHERE DATE(purchase_date) BETWEEN @StartDate AND @EndDate
                            GROUP BY item
                            ORDER BY qty DESC"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_product_perf.DataSource = dt
                End Using

                'Show First Item to Chart
                lbl_prod_name.Text = grid_product_perf_view.GetRowCellValue(0, col_model)
                chart_Product(grid_product_perf_view.GetRowCellValue(0, col_item))

            End Using


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Customer Performance
    Private Sub Load_CustomerPerformance()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT
	                                            customer, type, no_of_transc, total_cost, gross_sales AS total_gross, ((gross_sales - total_cost) / gross_sales) margin
                                            FROM (
	                                            SELECT 
		                                            ims_customers.first_name AS customer, ims_customers.account_type AS type, COUNT(customer) no_of_transc,
		                                            SUM((SELECT SUM(cost * qty) FROM ims_sales WHERE order_id=ims.order_id)) AS total_cost,
		                                            SUM((SELECT SUM(price) FROM ims_sales WHERE order_id=ims.order_id)) AS gross_sales
	                                            FROM ims_orders ims
	                                            INNER JOIN ims_customers ON ims_customers.customer_id=ims.customer
	                                            WHERE date_released IS NOT NULL AND NOT paid_amount = 0 AND deleted=0 AND DATE(date_released) BETWEEN @StartDate AND @EndDate
                                                GROUP BY customer
                                            ) s2", conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_customer_performance.DataSource = dt

                    'Show in Chart
                    chart_CustomerPerformance()

                End Using
            End Using
        Catch ex As Exception

        End Try
    End Sub



    '--->> Charts

    'Sales Over Time 
    Private Sub chart_SalesOverTime()
        Try
            Dim data = DirectCast(grid_sales_report.DataSource, DataTable)
            Dim SalesSeries = chart_sales.Series("sales")

            SalesSeries.Points.Clear()

            data.DefaultView.Sort = "datee ASC"
            Dim dt = data.DefaultView.ToTable

            If rb_gross_sales.Checked Then 'Show Gross Sales in Chart
                For i = 0 To dt.Rows.Count - 1
                    SalesSeries.Points.Add(New SeriesPoint(CDate(dt.Rows(i).Item(0)).ToString("MM/dd/yyyy"), CDec(dt.Rows(i).Item(7))))
                Next
            ElseIf rb_transactions.Checked Then 'Show Total Transactions in Chart
                For i = 0 To dt.Rows.Count - 1
                    SalesSeries.Points.Add(New SeriesPoint(CDate(dt.Rows(i).Item(0)).ToString("MM/dd/yyyy"), CInt(dt.Rows(i).Item(8))))
                Next
            ElseIf rb_margin.Checked Then 'Show Average Sales Margin in Chart
                For i = 0 To dt.Rows.Count - 1
                    SalesSeries.Points.Add(New SeriesPoint(CDate(dt.Rows(i).Item(0)).ToString("MM/dd/yyyy"), CInt(dt.Rows(i).Item(10) * 100)))
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Sales Agent/Coordinator Total Transactions, Gross, Net
    Private Sub chart_SalesByUsers()
        Try

            'Plot Coordinator's Data to Chart
            Using dt = DirectCast(grid_coordinator.DataSource, DataTable)
                Dim series_coordinators = chart_coordinator.Series("coordinators")

                series_coordinators.Points.Clear()

                For i = 0 To dt.Rows.Count - 1
                    series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1)))
                Next
            End Using

            'Plot Agents's Data to Chart
            Using dt = DirectCast(grid_agents.DataSource, DataTable)
                Dim series_agents = chart_agents.Series("agents")

                series_agents.Points.Clear()

                For i = 0 To dt.Rows.Count - 1
                    series_agents.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1)))
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Performance
    Private Sub chart_performance()
        Try

            'Plot Coordinator's Performance to Chart
            Using dt = DirectCast(grid_perf_coor.DataSource, DataTable)
                Dim series_coordinators = chart_perf_coordinator.Series("coordinators")

                series_coordinators.Points.Clear()
                Dim selection As Integer = 0

                If rb_perf_coor_transaction.Checked = True Then
                    selection = 1
                ElseIf rb_perf_coor_sales.Checked = True Then
                    selection = 4
                End If

                dt.DefaultView.Sort = "datee ASC"
                Dim data = dt.DefaultView.ToTable
                For i = 0 To data.Rows.Count - 1
                    series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(CDate(data.Rows(i).Item(0)).ToString("MM/dd/yyyy"), data.Rows(i).Item(selection)))
                Next
            End Using

            'Plot Agents's Performace to Chart
            Using dt = DirectCast(grid_perf_sa.DataSource, DataTable)
                Dim series_agents = chart_perf_agent.Series("agents")

                series_agents.Points.Clear()
                Dim selection As Integer = 0

                If rb_perf_agent_transaction.Checked = True Then
                    selection = 1
                ElseIf rb_perf_agent_sales.Checked = True Then
                    selection = 4
                End If

                dt.DefaultView.Sort = "datee ASC"
                Dim data = dt.DefaultView.ToTable
                For i = 0 To data.Rows.Count - 1
                    series_agents.Points.Add(New DevExpress.XtraCharts.SeriesPoint(CDate(data.Rows(i).Item(0)).ToString("MM/dd/yyyy"), data.Rows(i).Item(selection)))
                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Product Performance
    Private Sub chart_Product(item As String)
        Try

            Using conn = New MySqlConnection(str)

                conn.Open()
                Dim series = chart_prod.Series("item")
                series.Points.Clear()

                'Getting Data to Chart
                Using cmd = New MySqlCommand("SELECT DATE(purchase_date) AS dt, SUM(qty) AS qty FROM ims_sales 
                                                        WHERE item=@item AND DATE(purchase_date) BETWEEN @StartDate AND @EndDate
                                                        GROUP BY dt", conn)
                    cmd.Parameters.AddWithValue("@item", item)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            series.Points.Add(New DevExpress.XtraCharts.SeriesPoint(CDate(rdr("dt")).ToString("MM/dd/yyyy"), CInt(rdr("qty"))))
                        End While
                    End Using
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Customer Performance
    Private Sub chart_CustomerPerformance()
        Try
            Using dt = DirectCast(grid_customer_performance.DataSource, DataTable)
                Dim series_coordinators = chart_customer_performance.Series("customers")

                series_coordinators.Points.Clear()

                If rb_cp_gross.Checked Then 'Show Gross Sales in Chart
                    For i = 0 To dt.Rows.Count - 1
                        series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, FormatNumber(dt.Rows(i).Item(3), 2)))
                    Next
                ElseIf rb_cp_margin.Checked Then 'Show Average Sales Margin in Chart
                    For i = 0 To dt.Rows.Count - 1
                        series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, Math.Round(dt.Rows(i).Item(4) * 100, 0)))
                    Next
                ElseIf rb_cp_transc.Checked Then 'Show Total Transactions in Chart
                    For i = 0 To dt.Rows.Count - 1
                        series_coordinators.Points.Add(New DevExpress.XtraCharts.SeriesPoint(dt.Rows(i).Item(0).ToString, dt.Rows(i).Item(1)))
                    Next
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub





    '---- CONTROLS ----

    '-->> General Controls
    Private Sub btn_view_Click(sender As Object, e As EventArgs) Handles btn_view.Click
        Load_Selected_Tab()
    End Sub

    Private Sub TabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles TabControl.SelectedPageChanged
        Load_Selected_Tab()
    End Sub


    '-->> Control For Sales Over Time

    Private Sub rb_gross_sales_Click(sender As Object, e As EventArgs) Handles rb_gross_sales.Click
        chart_SalesOverTime()
    End Sub

    Private Sub rb_margin_Click(sender As Object, e As EventArgs) Handles rb_margin.Click
        chart_SalesOverTime()
    End Sub

    Private Sub rb_transactions_Click(sender As Object, e As EventArgs) Handles rb_transactions.Click
        chart_SalesOverTime()
    End Sub



    '-->COMBOBOX FOR PERFORMANCE

    Private Sub cbb_coordinator_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_coordinator.EditValueChanged
        GetUserID(cbb_coordinator, lbl_coordinator)
        Load_SalesCoordinatorAgent_performance()
    End Sub

    Private Sub cbb_agent_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_agent.EditValueChanged
        GetUserID(cbb_agent, lbl_agent)
        Load_SalesCoordinatorAgent_performance()
    End Sub



    '--> RADIO BUTTONS FOR SALES PERFORMANCE

    Private Sub rb_perf_coor_transaction_Click(sender As Object, e As EventArgs) Handles rb_perf_coor_transaction.Click
        chart_performance()
    End Sub

    Private Sub rb_perf_coor_sales_Click(sender As Object, e As EventArgs) Handles rb_perf_coor_sales.Click
        chart_performance()
    End Sub

    Private Sub rb_perf_agent_transaction_Click(sender As Object, e As EventArgs) Handles rb_perf_agent_transaction.Click
        chart_performance()
    End Sub

    Private Sub rb_perf_agent_sales_Click(sender As Object, e As EventArgs) Handles rb_perf_agent_sales.Click
        chart_performance()
    End Sub


    '---> RADIO BUTTONS FOR CUSTOMER PERFORMANCE

    Private Sub rb_cp_gross_Click(sender As Object, e As EventArgs) Handles rb_cp_gross.Click
        chart_CustomerPerformance()
    End Sub

    Private Sub rb_cp_margin_Click(sender As Object, e As EventArgs) Handles rb_cp_margin.Click
        chart_CustomerPerformance()
    End Sub

    Private Sub rb_cp_transc_Click(sender As Object, e As EventArgs) Handles rb_cp_transc.Click
        chart_CustomerPerformance()
    End Sub


    Private Sub grid_product_perf_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_product_perf_view.RowCellClick
        If grid_product_perf_view.FocusedColumn.Name = col_item.Name Then
            lbl_prod_name.Text = grid_product_perf_view.GetFocusedRowCellValue(col_model)
            chart_Product(grid_product_perf_view.GetFocusedRowCellValue(col_item))
        End If
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs)
        Try
            Dim fd = New SaveFileDialog
            fd.Filter = "Excel Files (*.xls*)|*.xls"
            If fd.ShowDialog = DialogResult.OK Then
                grid_sales_report.ExportToXls(fd.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_sales_report_view.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_sales_coordinator_Click(sender As Object, e As EventArgs) Handles btn_print_sales_coordinator.Click
        grid_coordinator.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_sales_agent_Click(sender As Object, e As EventArgs) Handles btn_print_sales_agent.Click
        grid_agents.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_perf_coor_Click(sender As Object, e As EventArgs) Handles btn_print_perf_coor.Click
        grid_perf_coor.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_perf_agnet_Click(sender As Object, e As EventArgs) Handles btn_print_perf_agnet.Click
        grid_perf_sa.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_print_product_Click(sender As Object, e As EventArgs) Handles btn_print_product.Click
        grid_product_perf.ShowRibbonPrintPreview()
    End Sub

    Private Sub grid_sales_report_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_sales_report_view.DoubleClick
        If grid_sales_report_view.FocusedColumn.Name = col_datee.Name Then
            Dim _date As Date = grid_sales_report_view.GetFocusedRowCellValue(col_datee)
            TabControl.SelectedTabPage = tab_transactions
            Load_Sales_per_Transactions(_date, _date)
        End If
    End Sub

    Private Sub grid_transaction_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_transaction_view.DoubleClick
        If grid_transaction_view.FocusedColumn.Name = col_sales_order_id.Name Then
            frm_sales_transaction_invoice.PrintInvoice(grid_transaction_view.GetFocusedRowCellValue(col_sales_order_id))
        End If
    End Sub
End Class