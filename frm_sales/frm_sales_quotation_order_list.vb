Imports MySqlConnector

Public Class frm_sales_quotation_order_list

    '--- ONLOAD ----
    Private Sub frm_quotation_order_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_quotes()
    End Sub

    'Load Quotations
    Private Sub load_quotes()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT CONCAT('Q',LPAD(quotation_id,5,0)) AS quotation_id, company, ims_users.first_name AS representative, status, created_at, (created_at + INTERVAL validity DAY) validity 
			            FROM ims_quotations 
			            LEFT JOIN ims_users ON ims_users.usr_id=prepared_by
                        WHERE is_converted='0' AND is_deleted='0' AND NOW() BETWEEN created_at AND created_at + INTERVAL validity DAY 
                        ORDER BY quotation_id DESC"
                Dim cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_quotes.DataSource = dt
                grid_quotes_view.FocusedRowHandle = -1
            End Using


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub



    '--- CONTROLS ---

    'View Quotation
    Private Sub btn_edit_quotation_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick
        Dim quote_id = grid_quotes_view.GetFocusedRowCellValue(col_quotation_id)

        Dim view_quote = New frm_sales_view_quotation
        view_quote.load_data(quote_id.Replace("Q", ""))
        view_quote.cbb_customer.Enabled = False
        view_quote.Show()
    End Sub

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_quotes()
    End Sub

    'btn_new
    Private Sub btn_quote_Click(sender As Object, e As EventArgs) Handles btn_quote.Click
        Dim frm = New frm_sales_create_quotation
        frm.Show()
    End Sub
End Class