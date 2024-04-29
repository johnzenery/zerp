Imports MySqlConnector

Public Class frm_purchasing_credit_memo



    '--- ON LOAD ----

    Private Sub frm_purchasing_credit_memo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturns(False)
    End Sub




    '--- FUNCTIONS ---

    Private Sub LoadReturns(show_all As Boolean)
        Try
            Dim show_all_query As String = String.Empty

            If show_all = True Then show_all_query = String.Empty
            If show_all = False Then show_all_query = "AND is_applied=0"

            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand($"SELECT concat('CM',LPAD(po_return_id,5,0)) AS po_return_id, supplier, is_applied,
                                total_cost, created_at, concat('PV',LPAD(p_voucher_id,5,0)) AS voucher_id FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id 
                                WHERE is_deleted=0 {show_all_query} ORDER BY po_return_id DESC", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_returns.DataSource = dt

                    conn.Clone()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'New Return Button
    Private Async Sub btn_new_return_Click(sender As Object, e As EventArgs) Handles btn_new_return.Click
        Await frm_main.LoadFrm(New frm_purchasing_credit_memo_new, "frm_purchasing_credit_memo_new")
    End Sub

    'View Purchase Return
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Try
            Dim id As Integer = grid_returns_view.GetFocusedRowCellValue(col_rid).ToString.Replace("CM", String.Empty)
            Dim frm = New frm_purchasing_credit_memo_new
            frm.Show()
            frm.LoadEdit(id)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        If cb_show_all.Checked = True Then
            LoadReturns(True)
        Else
            LoadReturns(False)
        End If
    End Sub

    'CHECKBOX : SHOW ALL
    Private Sub cb_show_all_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_all.CheckedChanged
        If cb_show_all.Checked = True Then
            LoadReturns(True)
        Else
            LoadReturns(False)
        End If
    End Sub

    'BUTTON : PENDING CREDITS
    Private Sub btn_pending_credits_Click(sender As Object, e As EventArgs) Handles btn_pending_credits.Click
        Dim frm = New frm_purchasing_credit_memo_pending_dialog
        frm.ShowDialog()
    End Sub
End Class