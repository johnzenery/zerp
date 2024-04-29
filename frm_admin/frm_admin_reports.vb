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
            Case tab_sku_breakdown.Name : Load_SKU_Breakdown()
            Case tab_product.Name : Load_ProductPerformace()
            Case tab_customer_performance.Name : Load_CustomerPerformance()
        End Select
    End Sub

    '-->> SALES REPORTS

    'Load Sales Report
    Private Sub Load_Sales_Over_Time()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'SUM(IF(is_vatable=1, (price/1.12), 0.00)) vat_sales,
                'DISPLAY DATA WITH STORED PROCEDURE
                Dim query = "SELECT 
	                            datee, 
	                            SUM(cost * qty) total_cost,
	                            SUM(IF(payment_type='Cheque' OR payment_type='Terms', price, 0.00)) total_terms,
	                            SUM(IF(payment_type='E-Payment', price, 0.00)) total_epay,
	                            SUM(IF(payment_type='Cash', price, 0.00)) total_cash,
                                SUM(IF(payment_type='CEC' OR payment_type='Cash' OR payment_type='Cheque' OR payment_type='E-Payment', price, 0.00)) total_cec,
                                SUM(IF(is_vatable=0, price, 0.00)) nonvat_sales,
	                            SUM(IF(is_vatable=1, price, 0.00)) vat_sales,
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
                            WHERE datee BETWEEN @start_date AND @end_date
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

                    For Each col As DevExpress.XtraGrid.Columns.GridColumn In grid_sales_report_view.Columns
                        col.Summary.Clear()
                    Next

                    grid_sales_report_view.Columns("total_cost").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_cost", "{0:N2}")
                    'grid_sales_report_view.Columns("total_cash").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_cash", "{0:N2}")
                    'grid_sales_report_view.Columns("total_epay").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_epay", "{0:N2}")
                    grid_sales_report_view.Columns("total_cec").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_cec", "{0:N2}")
                    grid_sales_report_view.Columns("total_terms").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_terms", "{0:N2}")
                    grid_sales_report_view.Columns("nonvat_sales").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "nonvat_sales", "{0:N2}")
                    grid_sales_report_view.Columns("vat_sales").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "vat_sales", "{0:N2}")
                    grid_sales_report_view.Columns("total_sales").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_sales", "{0:N2}")
                    grid_sales_report_view.Columns("total_transactions").Summary.Add(DevExpress.Data.SummaryItemType.Sum, "total_transactions", "{0:N0}")
                    grid_sales_report_view.Columns("avg_transc_amount").Summary.Add(DevExpress.Data.SummaryItemType.Average, "avg_transc_amount", "{0:N2}")
                    grid_sales_report_view.Columns("avg_sales_margin").Summary.Add(DevExpress.Data.SummaryItemType.Average, "avg_sales_margin", "{0:P0}")

                End Using

                conn.Close()
            End Using

        Catch ex As Exception
            If Not ex.GetType.ToString = "System.DivideByZeroException" Then
                MsgBox(ex.Message, vbCritical, "Error")
            End If
        End Try
    End Sub

    'Load Sales Report
    Private Sub Load_Sales_per_Transactions(dt_start As Date, dt_end As Date)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                '((IF(is_vatable = 1, (total_sales / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, (total_sales / 1.12) * 0.12), total_sales) 
                '    + delivery_fee 
                '    + IF(is_withholding_tax_applied = 1, ((total_sales / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, (total_sales / 1.12) * 0.12)) * .01, 0.00)
                '    - (cost_sales - IFNULL(sales_return - cost_of_returns, 0.00)))
                ') gross,
                'DISPLAY DATA WITH STORED PROCEDURE
                Dim query = "SELECT 
                                order_id,
                                ims_customers.first_name AS customer,
                                ims_customers.account_type,
                                DATE(date_released) AS released_date, 
                                (SELECT SUM(cost * qty) FROM ims_sales WHERE order_id = ims.order_id) AS total_cost, 
                                subtotal, delivery_fee, amount_due,
                                discount,
                                (subtotal - discount) AS sales,
                                IFNULL(cost_of_returns, 0.00) cost_of_returns,
                                IFNULL(sales_return, 0.00) sales_return,
                                total_sales,
                                IF(is_vatable = 0, total_sales, 0.00) AS nonvat_sales,
                                IF(is_vatable = 1 AND is_vat_exempt = 0 AND is_vat_zero = 0, total_sales / 1.12, 0.00) AS vatable_sales,
                                IF(is_vat_exempt = 1, total_sales / 1.12, 0.00) AS vat_exempt_sales,
                                IF(is_vat_zero = 1, total_sales / 1.12, 0.00) AS vat_zero_sales,
                                IF(is_vatable = 1 AND is_vat_exempt = 0 AND is_vat_zero = 0, (total_sales / 1.12) * 0.12, 0.00) AS vat_amount,
                                IF(is_vatable = 1, (total_sales - (total_sales / 1.12) * 0.12), total_sales) AS amount_net_of_vat,  
                                IF(is_vatable = 1, (total_sales / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, (total_sales / 1.12) * 0.12), total_sales) total_amount_due,
                                IF(is_withholding_tax_applied = 1, ((total_sales / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, (total_sales / 1.12) * 0.12)) * .01, 0.00) ewt,
                                (((IF(is_vatable = 1, ((subtotal - discount) / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, ((subtotal - discount) / 1.12) * 0.12), (subtotal - discount)) 
                                    + delivery_fee 
                                    - cost_sales) - IFNULL(sales_return - cost_of_returns, 0.00))
                                ) gross,
                                (((IF(is_vatable = 1, ((subtotal - discount) / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, ((subtotal - discount) / 1.12) * 0.12), (subtotal - discount)) 
                                        + delivery_fee
                                        - cost_sales) - IFNULL(sales_return - cost_of_returns, 0.00))
                                    / (IF(is_vatable = 1, (total_sales / 1.12) + IF(is_vat_exempt = 1 OR is_vat_zero = 1, 0.00, (total_sales / 1.12) * 0.12), total_sales) + delivery_fee)
                                ) sales_margin,
                                (SELECT (SUM(price) - SUM(cost * qty)) FROM ims_sales WHERE order_id = ims.order_id) AS net_sales,
                                (SELECT (SUM(price) - SUM(cost * qty)) / SUM(price) FROM ims_sales WHERE order_id = ims.order_id) AS margin,
                                ims_users.first_name AS coordinator, agent.first_name agent
                            FROM (
                                SELECT
                                    ims.order_id,
                                    ims.customer,
                                    ims.date_released,
                                    ims.is_vatable, ims.is_vat_exempt, ims.is_vat_zero, ims.is_withholding_tax_applied,
                                    ims.agent, ims.sales_agent,
                                    ims.paid_amount, ims.delivery_fee, ims.amount_due,
                                    ims.discount_type,
                                    ims.discount_val,
                                    (SELECT SUM(price) FROM ims_sales WHERE order_id = ims.order_id) AS subtotal,
                                    (SELECT SUM(cost * qty) FROM ims_sales WHERE order_id = ims.order_id) AS cost_sales,
                                    ((SELECT SUM(price) FROM ims_sales WHERE order_id = ims.order_id) 
                                                - (IF(discount_type = '%', (SELECT SUM(price) FROM ims_sales WHERE order_id = ims.order_id) * (discount_val / 100), IF(discount_type = 'peso', discount_val, 0.00)))
                                                - IFNULL((SELECT SUM(price * qty) FROM ims_sales_returns, JSON_TABLE(units, '$[*]' COLUMNS (qty DECIMAL(10,2) PATH '$.qty', price DECIMAL(10,2) PATH '$.unit_price')) AS jt WHERE sales_return_id = ims.applied_sales_return), 0.00)
                                    ) total_sales,
                                    (IF(discount_type = '%', (SELECT SUM(price) FROM ims_sales WHERE order_id = ims.order_id) * (discount_val / 100), IF(discount_type = 'peso', discount_val, 0.00))) AS discount,
                                    (SELECT SUM(cost * qty) FROM ims_sales_returns, JSON_TABLE(units, '$[*]' COLUMNS (qty DECIMAL(10,2) PATH '$.qty', cost DECIMAL(10,2) PATH '$.cost')) AS jt WHERE sales_return_id = ims.applied_sales_return) AS cost_of_returns,
                                    (SELECT SUM(price * qty) FROM ims_sales_returns, JSON_TABLE(units, '$[*]' COLUMNS (qty DECIMAL(10,2) PATH '$.qty', price DECIMAL(10,2) PATH '$.unit_price')) AS jt WHERE sales_return_id = ims.applied_sales_return) AS sales_return
                                FROM ims_orders ims
                                WHERE ims.deleted = '0' AND DATE(date_released) BETWEEN @StartDate AND @EndDate
                            ) ims
                            LEFT JOIN ims_customers ON ims_customers.customer_id = ims.customer
                            LEFT JOIN ims_users ON ims_users.usr_id = ims.agent
                            LEFT JOIN ims_users agent ON agent.usr_id = ims.sales_agent
                            ORDER BY order_id DESC"
                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end)
                    cmd.CommandTimeout = 120
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_transaction.DataSource = dt
                End Using

                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Load_SKU_Breakdown()
        Try
            'Load Filter
            Load_CBB()

            Dim query As String = String.Empty

            query += IIf(Not (cbb_skuB_customer.SelectedIndex = 0 Or cbb_skuB_customer.SelectedIndex = -1), "AND ims_customers.first_name=@customer", "")
            query += IIf(Not (cbb_skuB_pid.SelectedIndex = 0 Or cbb_skuB_pid.SelectedIndex = -1), "AND ims_inventory.pid='" & cbb_skuB_pid.EditValue & "' ", "")
            query += IIf(Not (cbb_skuB_brand.SelectedIndex = 0 Or cbb_skuB_brand.SelectedIndex = -1), "AND ims_inventory.brand='" & cbb_skuB_brand.EditValue & "' ", "")

            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT 
	                                            ims_sales.customer, ims_customers.first_name AS customer_name, ims_customers.account_type AS customer_type,
	                                            ims_sales.order_id, 
	                                            IF(ims_orders.is_vatable = FALSE, 'Non-Vat', IF(ims_orders.is_vat_exempt = TRUE, 'Vatable - VAT Exempt', IF(ims_orders.is_vat_zero = TRUE, 'Vatable - Zero Rated', 'Vatable'))) AS tax_type,
	                                            ims_orders.date_ordered, ims_sales.purchase_date,
	                                            qty, item, ims_inventory.winmodel, ims_inventory.description, ims_inventory.brand, ims_inventory.main_category, ims_inventory.sub_category,
	                                            ims_sales.cost, srp, ims_sales.discount, (price/qty) AS discounted_price, price AS total_amount, (ims_sales.cost * qty) AS total_cost, 
	                                            price - (ims_sales.cost * qty) AS income, (price - (ims_sales.cost * qty)) / price AS margin
                                            FROM
	                                            ims_sales
                                            LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales.customer
                                            LEFT JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id
                                            LEFT JOIN ims_inventory ON ims_inventory.pid=ims_sales.item
                                            WHERE DATE(purchase_date) BETWEEN @StartDate AND @EndDate " & query & "
                                            ", conn)
                    cmd.Parameters.AddWithValue("@StartDate", dt_start.EditValue)
                    cmd.Parameters.AddWithValue("@EndDate", dt_end.EditValue)

                    If Not (cbb_skuB_customer.SelectedIndex = 0 Or cbb_skuB_customer.SelectedIndex = -1) Then
                        cmd.Parameters.AddWithValue("@customer", cbb_skuB_customer.EditValue)
                    End If

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_sku_breakdown.DataSource = dt
                End Using

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    'LOAD Customer, PID, Brand to CBB
    Private Sub Load_CBB()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT first_name FROM ims_customers", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_skuB_customer.Properties.Items.Add(rdr("first_name"))
                        End While
                    End Using
                End Using

                Using cmd = New MySqlCommand("SELECT pid FROM ims_inventory", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_skuB_pid.Properties.Items.Add(rdr("pid"))
                        End While
                    End Using
                End Using

                Using cmd = New MySqlCommand("SELECT DISTINCT brand FROM ims_inventory", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_skuB_brand.Properties.Items.Add(rdr("brand"))
                        End While
                    End Using
                End Using

                conn.Close()
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

                conn.Close()
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

                conn.Close()
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
	                                            customer, type, no_of_transc, total_cost, gross_sales AS total_gross, ((gross_sales - total_cost) / gross_sales) margin, sales_returns
                                            FROM (
	                                            SELECT 
		                                            ims_customers.first_name AS customer, ims_customers.account_type AS type, COUNT(customer) no_of_transc,
		                                            SUM((SELECT SUM(cost * qty) FROM ims_sales WHERE order_id=ims.order_id)) AS total_cost,
		                                            SUM((SELECT SUM(price) FROM ims_sales WHERE order_id=ims.order_id)) AS gross_sales,
                                                    SUM(ims_sales_returns.amount) sales_returns
	                                            FROM ims_orders ims
	                                            INNER JOIN ims_customers ON ims_customers.customer_id=ims.customer
                                                LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims.applied_sales_return
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

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
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

    Private Sub btn_export_transaction_Click(sender As Object, e As EventArgs) Handles btn_export_transaction.Click
        grid_transaction_view.ShowRibbonPrintPreview()
    End Sub

    Private Sub btn_export_sku_breakdown_Click(sender As Object, e As EventArgs) Handles btn_export_sku_breakdown.Click
        grid_sku_breakdown.ShowRibbonPrintPreview()
    End Sub

    Private Async Sub grid_sku_breakdown_view_DoubleClick(sender As Object, e As EventArgs) Handles grid_sku_breakdown_view.DoubleClick
        If grid_sku_breakdown_view.FocusedColumn.Name = col_sku_breakdown_orderId.Name Then
            Dim orderID As Integer = grid_sku_breakdown_view.GetFocusedRowCellValue(col_sku_breakdown_orderId)
            Dim view_order = New frm_sales_order_new

            If view_order.LoadData(orderID) = True Then
                Await frm_main.LoadFrm(view_order, "sales_order_" & orderID)
            End If
        End If
    End Sub
End Class