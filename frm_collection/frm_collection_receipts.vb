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
    Private Sub Print_Collection_Receipt(collection_id As Integer)
        Try
            Dim report = New doc_collection_receipt()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim so_nos = String.Empty
                Using cmd = New MySqlCommand("SELECT collection_id, so_nos, cheques, date_generated, ims_users.first_name AS collected_by, ims_customers.first_name AS c_name, ims_customers.address,
                                (SELECT value FROM ims_settings WHERE name='store_info') as store_info, (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name
                                FROM ims_collection_receipts 
                                INNER JOIN ims_customers ON ims_customers.customer_id=ims_collection_receipts.customer_id
                                INNER JOIN ims_users ON ims_users.usr_id=ims_collection_receipts.collected_by
                                WHERE collection_id=" & collection_id, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            report.Parameters("store_name").Value = rdr("store_name")
                            report.Parameters("store_info").Value = rdr("store_info")
                            report.Parameters("collection_id").Value = "CR" & rdr("collection_id").ToString.PadLeft(5, "0"c)
                            report.Parameters("collection_date").Value = rdr("date_generated")
                            report.Parameters("customer").Value = rdr("c_name")
                            report.Parameters("address").Value = rdr("address")
                            report.Parameters("collected_by").Value = rdr("collected_by")
                            'report.Parameters("encoded_by").Value = rdr("collected_by")
                            so_nos = rdr("so_nos")

                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of ChequesClass))(rdr("cheques"))
                            For Each item In itemsObject
                                table.payment_voucher_cheque.Rows.Add(item.bank, item.cheque_date, item.cheque_no, item.amount)
                            Next

                        End While
                    End Using
                End Using

                Dim so_nos_array = so_nos.Split(",")
                For i = 0 To so_nos_array.Length - 1
                    Using cmd = New MySqlCommand("SELECT order_id, date_released, DATE_ADD(date_released, INTERVAL terms DAY) AS due_date, amount_due FROM ims_orders WHERE order_id=" & so_nos_array(i), connection)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                table.collection_receipt.Rows.Add("SO" & rdr("order_id").ToString.PadLeft(5, "0"c), rdr("date_released"), rdr("due_date"), rdr("amount_due"))
                            End While
                        End Using
                    End Using
                Next

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
        Print_Collection_Receipt(id.Replace("CR", ""))
    End Sub

End Class
