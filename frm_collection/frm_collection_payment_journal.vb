Imports DevExpress.XtraGrid.Columns
Imports MySqlConnector

Public Class frm_collection_payment_journal

    Private Property is_columns_added As Boolean = False

    Private Sub frm_collection_order_history_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPaymentLogs()
    End Sub


    Public Sub LoadPaymentLogs()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim credit_columns As String = String.Empty
                Dim column_name_list As New List(Of String)
                Dim fund_name_list As New List(Of String)
                Dim column_index As Integer = 0

                Using cmd_get_columns = New MySqlCommand("SELECT IFNULL(journal_column_name, '') journal_column_name, fund_name FROM ims_banks WHERE is_enabled='1' AND is_credit='1'", conn)
                    Using rdr = cmd_get_columns.ExecuteReader
                        While rdr.Read
                            credit_columns += ", " & rdr("journal_column_name")
                            column_name_list.Add(rdr("journal_column_name"))
                            fund_name_list.Add(rdr("fund_name"))
                        End While
                    End Using
                End Using


                Dim query = "SELECT transaction_id, type, concat('SO',LPAD(order_id,5,0)) order_id, payment_date, ims_customers.first_name customer, current_balance,
                    total_payment, new_balance, ims_users.first_name received_by, epayment_ref, gateway " & credit_columns & "
                    FROM ims_payments_journal 
                    LEFT JOIN ims_users on ims_users.usr_id=ims_payments_journal.received_by
                    LEFT JOIN ims_customers ON ims_customers.customer_id=ims_payments_journal.customer_id 
                    WHERE is_voided='0'
                    ORDER BY transaction_id DESC"

                Using cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_payment_ledger.DataSource = dt

                    If is_columns_added = False Then
                        For Each column As String In column_name_list
                            Dim unbound_column = grid_payment_ledger_view.Columns.Add()
                            unbound_column.FieldName = column
                            unbound_column.Caption = fund_name_list.Item(column_index)
                            unbound_column.Name = column
                            unbound_column.Visible = True
                            unbound_column.VisibleIndex = dt.Columns.Count + column_index
                            grid_payment_ledger_view.Columns.Add(unbound_column)
                            column_index += 1
                        Next
                    End If

                    is_columns_added = True
                    grid_payment_ledger_view.BestFitColumns()
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        LoadPaymentLogs()
    End Sub

    'BUTTON : REVERSAL
    Private Sub btn_reversal_Click(sender As Object, e As EventArgs) Handles btn_reversal.Click
        Dim frm = New frm_collection_payment_reversal
        If frm.ShowDialog() = DialogResult.OK Then
            LoadPaymentLogs()
        End If
    End Sub

    'BUTTON : PROOFS
    Private Sub btn_proofs_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_proofs.ButtonClick
        Dim frm As New frm_sales_order_epayment_proofs()
        frm.lbl_order_id.Text = grid_payment_ledger_view.GetFocusedRowCellValue(col_orderid)
        frm.LoadData()
        frm.ShowDialog()
    End Sub

End Class