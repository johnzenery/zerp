Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_collection_receipts


    '--- ONLOAD ----
    Private Sub frm_collection_receipts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCollections()
    End Sub



    '---- FUNCTIONS -----

    'LOAD COLLECTIONS
    Private Sub LoadCollections()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT CONCAT('CR', LPAD(collection_id, 5, '0')) as collection_id, ims_customers.first_name AS customer, date_generated FROM ims_collection_receipts
                                INNER JOIN ims_customers ON ims_customers.customer_id=ims_collection_receipts.customer_id ORDER BY collection_id DESC", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_receipts.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Collection Receipt
    Public Sub Print_Collection_Receipt(collection_id As Integer)
        Try
            Dim report = New doc_collection_receipt()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData
            Dim total_amount_of_payments As Decimal = 0.00
            Dim total_amount_of_orders As Decimal = 0.00
            Dim total_amount_of_return As Decimal = 0.00

            Using connection = New MySqlConnection(str)
                connection.Open()

                'Dim so_nos = String.Empty
                Using cmd = New MySqlCommand("SELECT ims_collection_receipts.collection_id, so_nos, sales_orders, cheques, date_generated, ims_users.first_name AS collected_by, ims_customers.first_name AS c_name, ims_customers.address, billing_id,
                                (SELECT value FROM ims_settings WHERE name='store_info') as store_info, (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name,
                                IFNULL(ims_collection_cash.amount, 0) AS collection_receipt_cash
                                FROM ims_collection_receipts 
                                LEFT JOIN ims_collection_cash ON ims_collection_cash.collection_id=ims_collection_receipts.collection_id
                                INNER JOIN ims_customers ON ims_customers.customer_id=ims_collection_receipts.customer_id
                                INNER JOIN ims_users ON ims_users.usr_id=ims_collection_receipts.collected_by
                                WHERE ims_collection_receipts.collection_id=" & collection_id, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read

                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of ChequesClass))(rdr("cheques"))
                            For Each item In itemsObject
                                table.collection_receipt_cheque.Rows.Add(item.bank, item.cheque_date, item.cheque_no, item.amount, item.acc_no, item.acc_name)
                                total_amount_of_payments += item.amount
                            Next

                            If Not IsDBNull(rdr("sales_orders")) Then
                                Dim SalesOrders = JsonConvert.DeserializeObject(Of List(Of SalesOrdersModel))(rdr("sales_orders"))
                                For Each order In SalesOrders
                                    table.collection_receipt.Rows.Add(order.So_no, order.Invoice_no, order.Due_Date, order.Balance, order.DR_no)
                                    total_amount_of_orders += order.Balance
                                Next
                            End If

                            report.Parameters("collection_id").Value = "CR" & rdr("collection_id").ToString.PadLeft(5, "0"c)
                            report.Parameters("store_name").Value = rdr("store_name")
                            report.Parameters("store_info").Value = rdr("store_info")
                            report.Parameters("collection_date").Value = rdr("date_generated")
                            report.Parameters("customer").Value = rdr("c_name")
                            report.Parameters("address").Value = rdr("address")
                            report.Parameters("collected_by").Value = rdr("collected_by")
                            report.Parameters("encoded_by").Value = rdr("collected_by")
                            report.Parameters("billing_ref").Value = IIf(rdr("billing_id") = 0, "N/A", "BS" & rdr("billing_id").ToString.PadLeft(5, "0"c))
                            'so_nos = IIf(IsDBNull(rdr("so_nos")), String.Empty, rdr("so_nos"))

                            report.Parameters("collection_receipt_cash").Value = rdr("collection_receipt_cash")

                            total_amount_of_payments += CDec(rdr("collection_receipt_cash"))



                        End While
                    End Using
                End Using

                'GET E-PAYMENTS  BANK TRANSFERS
                Using cmd = New MySqlCommand("SELECT gateway, amount, reference, ims_banks.fund_name
                                              FROM ims_collection_epayments 
                                              LEFT JOIN ims_banks ON ims_banks.bank_id=ims_collection_epayments.bank_id
                                              WHERE collection_id=" & collection_id, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            table.collection_receipt_epayments.Rows.Add(rdr("gateway"), rdr("fund_name"), rdr("reference"), rdr("amount"))
                            total_amount_of_payments += CDec(rdr("amount"))
                        End While
                    End Using
                End Using

                'GET CREDIT CARD PAYMENTS
                Using cmd = New MySqlCommand("SELECT ims_cc_terminals.terminal_name, amount, CONCAT(card_holder, ' - ', card_no) details 
                                              FROM ims_collection_creditcard 
                                              LEFT JOIN ims_cc_terminals ON ims_cc_terminals.terminal_id=ims_collection_creditcard.terminal_id
                                              WHERE collection_id=" & collection_id, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            table.collection_receipt_epayments.Rows.Add(rdr("terminal_name"), rdr("details"), "", rdr("amount"))
                            total_amount_of_payments += CDec(rdr("amount"))
                        End While
                    End Using
                End Using

                'GET ORDERS / TRANSACTIONS
                'Dim so_nos_array = so_nos.Split(",")
                'For i = 0 To so_nos_array.Length - 1
                '    Using cmd = New MySqlCommand("SELECT order_id, invoice_no, DATE_ADD(date_released, INTERVAL terms DAY) AS due_date, balance
                '                        FROM ims_orders 
                '                        LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims_orders.applied_sales_return
                '                        WHERE order_id=" & so_nos_array(i), connection)
                '        Using rdr = cmd.ExecuteReader
                '            While rdr.Read
                '                table.collection_receipt.Rows.Add("SO" & rdr("order_id").ToString.PadLeft(5, "0"c), rdr("invoice_no"), rdr("due_date"), rdr("balance"))
                '                total_amount_of_orders += rdr("balance")
                '            End While
                '        End Using
                '    End Using
                'Next

                'GET SALES RETURNS / DEDUCTIONS
                Using cmd = New MySqlCommand("SELECT sales_return_id, created_at, amount FROM ims_sales_returns WHERE collection_id=" & collection_id, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            table.collection_deductions.Rows.Add("SR" & rdr("sales_return_id").ToString.PadLeft(5, "0"c), rdr("created_at"), rdr("amount"))
                            total_amount_of_return += rdr("amount")
                        End While
                    End Using
                End Using

                report.Parameters("total_payments").Value = total_amount_of_payments
                report.Parameters("balance").Value = total_amount_of_orders - total_amount_of_payments
                report.Deductions.Visible = False 'IIf(table.collection_deductions.Rows.Count > 0, True, False)
                report.CASH.Visible = IIf(report.Parameters("collection_receipt_cash").Value > 0, True, False)
                report.CHECK.Visible = IIf(table.collection_receipt_cheque.Rows.Count > 0, True, False)
                report.EPAYMENTS.Visible = IIf(table.collection_receipt_epayments.Rows.Count > 0, True, False)
                report.RequestParameters = False
                report.DataSource = table
                report.ShowRibbonPreviewDialog()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub





    '--- CONTROLS ----

    'Print Button
    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim id As String = grid_receipts_view.GetFocusedRowCellValue(col_id)
        Print_Collection_Receipt(id.Replace("CR", String.Empty))
    End Sub

End Class
