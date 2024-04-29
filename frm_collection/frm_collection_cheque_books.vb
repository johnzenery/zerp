Imports MySqlConnector

Public Class frm_collection_cheque_books


    '--- ONLOAD ----
    Private Sub frm_accounting_cheque_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.EditValue = New DateTime(Date.Now.Year, 1, 1)
        dt_end.EditValue = Date.Now
        LoadData(dt_start.EditValue, dt_end.EditValue)
    End Sub



    Private Sub LoadData(startDate As Date, endDate As Date)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT * FROM ims_cheque_collections 
                                        LEFT JOIN ims_customers ON ims_customers.customer_id=ims_cheque_collections.customer_id 
                                        WHERE NOT status='CLEAR' AND ims_cheque_collections.is_deleted=0
                                            AND entry_date BETWEEN @start_date AND @end_date
                                        ORDER BY cheque_id DESC", connection)
                cmd.Parameters.AddWithValue("@start_date", startDate)
                cmd.Parameters.AddWithValue("@end_date", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_cheque_book.DataSource = dt
                grid_cheque_view.BestFitColumns()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'BUTTON : View Cheque
    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick

        Dim cheque_view = New frm_collection_cheque_view

        If grid_cheque_view.RowCount > 0 Then

            Dim cheque_id = grid_cheque_view.GetFocusedRowCellValue(col_chequeID)

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("SELECT * FROM ims_cheque_collections INNER JOIN ims_customers ON ims_customers.customer_id=ims_cheque_collections.customer_id WHERE cheque_id=" & cheque_id, connection)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read
                        cheque_view.lbl_cheque_id.Text = rdr("cheque_id")
                        cheque_view.txt_cheque_date.Text = rdr("cheque_date")
                        cheque_view.txt_cheque_no.Text = rdr("cheque_no")
                        cheque_view.txt_acc_no.Text = rdr("acc_no")
                        cheque_view.txt_acc_name.Text = rdr("acc_name")
                        cheque_view.txt_amount.Text = rdr("amount")
                        cheque_view.txt_customer.Text = rdr("first_name")
                        cheque_view.txt_payee.Text = rdr("payee_name")
                        cheque_view.cbb_status.Text = rdr("status")
                        cheque_view.txt_bank.Text = rdr("bank")
                        cheque_view.txt_orders.Text = rdr("orders")
                    End While

                    cheque_view.ShowDialog()
                    LoadData(dt_start.EditValue, dt_end.EditValue)
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub
End Class