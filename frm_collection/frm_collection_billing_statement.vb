Imports System.Runtime.Remoting.Metadata.W3cXsd2001
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_collection_billing_statement

    '--- ONLOAD ---
    Private Sub frm_collection_soa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub




    '--- FUNCTIONS ---

    'Load Data to Grid
    Private Sub LoadData()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT concat('BS',LPAD(soa_id,5,0)) as soa_id, ims_customers.first_name as customer, print_date, total, ims_users.first_name as prepared_by FROM ims_soa
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_soa.customer_id
                            INNER JOIN ims_users ON ims_users.usr_id=prepared_by 
                            WHERE ims_soa.is_deleted=0
                            ORDER BY soa_id DESC", connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_soa.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print SOA
    Public Sub Print_BillingStatement(soa_id As Integer)

        Try
            Dim report = New doc_billing_statement()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData
            Dim total_of_overdue As Decimal = 0.00
            Dim total_of_due As Decimal = 0.00

            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET ORDERS
                'Using cmd = New MySqlCommand("SELECT date_released, DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) AS due_date,
                '        CONCAT('SO',LPAD(order_id,5,0)) AS order_id, amount_due, paid_amount, (amount_due - paid_amount) balance, po_reference 
                '        FROM ims_orders
                '        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer 
                '        WHERE soa_id=@soa_id AND (payment_status='UNPAID' OR payment_status='PARTIAL')", connection)
                '    cmd.Parameters.AddWithValue("@soa_id", soa_id)

                '    Using rdr = cmd.ExecuteReader
                '        While rdr.Read
                '            If Date.Now > CDate(rdr("due_date")) Then
                '                total_of_overdue += rdr("amount_due")
                '            Else
                '                total_of_due += rdr("amount_due")
                '            End If

                '            table.soa.Rows.Add(rdr("order_id"), rdr("date_released"), rdr("due_date"), rdr("amount_due"), rdr("po_reference"), rdr("paid_amount"), rdr("balance"))
                '        End While
                '    End Using

                '    report.DataSource = table

                'End Using

                'GET SALES RETURNS
                Using cmd_returns = New MySqlCommand("SELECT sales_return_id, created_at, amount FROM ims_sales_returns WHERE soa_id=@soa_id", connection)
                    cmd_returns.Parameters.AddWithValue("@soa_id", soa_id)
                    Using rdr = cmd_returns.ExecuteReader
                        While rdr.Read
                            table.collection_deductions.Rows.Add("SR" & rdr("sales_return_id").ToString.PadLeft(5, "0"c), rdr("created_at"), rdr("amount"))
                        End While
                    End Using
                End Using

                'GET SOA DETAILS
                Using get_soa_details = New MySqlCommand("SELECT concat('SA',LPAD(soa_id,5,0)) as soa, ims_customers.first_name as customer, ims_customers.address, statements,
                            ims_customers.contact_person, print_date, total, ims_users.first_name as prepared_by,
                            (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, 
                            (SELECT value FROM ims_settings WHERE name='store_info') AS store_info,
                            (SELECT value FROM ims_settings WHERE name='payment_option_info') AS payment_option_info
                            FROM ims_soa
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_soa.customer_id
                            INNER JOIN ims_users ON ims_users.usr_id=prepared_by
                            WHERE soa_id=@soa_id", connection)
                    get_soa_details.Parameters.AddWithValue("@soa_id", soa_id)

                    Using reader = get_soa_details.ExecuteReader
                        While reader.Read

                            Dim BillingStatements = JsonConvert.DeserializeObject(Of List(Of BillingStatementClass))(reader("statements"))
                            For Each Statement In BillingStatements

                                Get_SalesReturnsToTable(table, Statement.OrderID.Replace("SO", String.Empty))

                                table.soa.Rows.Add(
                                            Statement.OrderID,
                                            Statement.DateReleased,
                                            Statement.DueDate,
                                            Statement.Amount,
                                            Statement.PORef,
                                            Statement.PaidAmount,
                                            Statement.Balance
                                        )

                                If Date.Now > Statement.DueDate Then
                                    total_of_overdue += Statement.Balance
                                Else
                                    total_of_due += Statement.Balance
                                End If

                            Next

                            report.Parameters("store_name").Value = reader("store_name")
                            report.Parameters("store_info").Value = reader("store_info")
                            report.Parameters("soa_id").Value = "BS" & soa_id.ToString.PadLeft(5, "0"c)
                            report.Parameters("customer").Value = reader("customer")
                            report.Parameters("attn").Value = reader("contact_person")
                            report.Parameters("print_date").Value = reader("print_date")
                            report.Parameters("addr").Value = reader("address")
                            report.Parameters("prepared_by").Value = reader("prepared_by")
                            report.Parameters("total_overdue").Value = total_of_overdue
                            report.Parameters("total_due").Value = total_of_due
                            report.Parameters("total").Value = reader("total")
                            report.lbl_payment_option_info.Text = reader("payment_option_info")

                            report.DataSource = table

                        End While
                    End Using
                End Using

                report.detailreport_deductions.Visible = IIf(table.collection_deductions.Rows.Count > 0, True, False)
                printTool.AutoShowParametersPanel = False
                printTool.ShowRibbonPreviewDialog()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'GET SALES RETURNS
    Private Sub Get_SalesReturnsToTable(table As PrintData, OrderID As Integer)

        Using conn = New MySqlConnection(str)
            conn.Open()
            Using cmd_returns = New MySqlCommand("SELECT sales_return_id, created_at, amount 
                                                    FROM ims_sales_returns 
                                                    INNER JOIN ims_orders ON ims_orders.applied_sales_return=ims_sales_returns.sales_return_id
                                                    WHERE ims_orders.order_id=@order_id", conn)
                cmd_returns.Parameters.AddWithValue("@order_id", OrderID)
                Using rdr = cmd_returns.ExecuteReader
                    While rdr.Read
                        table.collection_deductions.Rows.Add("SR" & rdr("sales_return_id").ToString.PadLeft(5, "0"c), rdr("created_at"), rdr("amount"))
                    End While
                End Using
            End Using
        End Using

    End Sub





    '--- CONTROLS ---



    'btn_new |  Show SOA Generator
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Using frm = New frm_collection_billing_statement_new
            If frm.ShowDialog() = DialogResult.OK Then
                LoadData()
            End If
        End Using
    End Sub

    'btn_print | Show Print Dialog
    Private Sub btn_repo_print_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_repo_print.ButtonClick
        Print_BillingStatement(grid_soa_view.GetFocusedRowCellValue(col_soa_id).ToString.Replace("BS", ""))
    End Sub

End Class