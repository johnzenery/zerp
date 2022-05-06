Imports MySqlConnector

Public Class frm_collection_cheque_books

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ----
    Private Sub frm_accounting_cheque_books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    Private Sub LoadData()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM ims_cheque_collections 
                                        INNER JOIN ims_customers on ims_customers.customer_id=ims_cheque_collections.customer_id WHERE NOT status='CLEAR' ORDER BY cheque_date ASC", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_cheque_book.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'View Cheque
    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click

        Dim cheque_view = New frm_collection_cheque_view

        If grid_cheque_view.RowCount > 0 Then

            Dim cheque_id = grid_cheque_view.GetRowCellValue(grid_cheque_view.FocusedRowHandle, "cheque_id")

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM ims_cheque_collections INNER JOIN ims_customers ON ims_customers.customer_id=ims_cheque_collections.customer_id WHERE cheque_id=" & cheque_id, conn)
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

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If


    End Sub

End Class