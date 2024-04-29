Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports MySqlConnector

Public Class frm_sales_return_list


    '--- ONLOAD ----
    Private Sub frm_sales_return_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturns("Pending")
    End Sub


    '--- FUNCTIONS ----

    'Load Sales Returns
    Private Sub LoadReturns(status As String)
        Dim is_applied As Integer = 0

        If status = "Pending" Then
            is_applied = 0
        ElseIf status = "Credited" Then
            is_applied = 1
        End If

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT CONCAT('SR', LPAD(sales_return_id,5,0)) sales_return_id, amount, created_at, received_at, status, reference,
                                IF(is_applied='0', 'Pending', 'Credited') credit_status, 
                                IF(collection_id = 0, '', CONCAT('CR', LPAD(collection_id, 5, 0))) credit_ref, 
                                ims_stores.store_name AS warehouse,
                                ims_customers.first_name AS customer, ims_users.first_name AS sales_coordinator, RECEIVED_BY.first_name AS received_by, ims_customers.account_type 
                                FROM ims_sales_returns 
                                LEFT JOIN ims_stores ON ims_stores.store_id=ims_sales_returns.store_id
                                LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id 
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_sales_returns.created_by 
                                LEFT JOIN ims_users AS RECEIVED_BY ON RECEIVED_BY.usr_id=ims_sales_returns.received_by 
                                WHERE ims_sales_returns.is_deleted=0 AND is_applied=" & is_applied & "
                                ORDER BY sales_return_id DESC", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                    SetRestriction()
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'HIDE AMOUNT FOR RESTRICTED USER
    Private Sub SetRestriction()
        For i = 0 To grid_returns_view.RowCount - 1
            If grid_returns_view.GetRowCellValue(i, col_customer_type).Equals("Sister Company") Then
                grid_returns_view.SetRowCellValue(i, col_amount, Nothing)
            End If
        Next
    End Sub

    'HIGHLIGHT FUNCTION
    Private Sub HighlightButton(btn As SimpleButton)
        btn_pending.Appearance.BackColor = Nothing
        btn_credited.Appearance.BackColor = Nothing

        btn.Appearance.BackColor = DXSkinColors.FillColors.Danger
    End Sub





    '--- CONTROLS ---

    'New Sales Return Button
    Private Async Sub btn_new_return_Click(sender As Object, e As EventArgs) Handles btn_new_return.Click
        Await frm_main.LoadFrm(New frm_sales_return_new, "frm_sales_return_new")
    End Sub

    'View Sales Return
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Dim id = grid_returns_view.GetFocusedRowCellValue(col_rid).ToString.Replace("SR", String.Empty)
        Dim frm = New frm_sales_return_new
        frm.Show()
        frm.LoadEdit(id)
    End Sub

    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        If btn_pending.Appearance.BackColor.Equals(DXSkinColors.FillColors.Danger) Then
            LoadReturns("Pending")
        ElseIf btn_credited.Appearance.BackColor.Equals(DXSkinColors.FillColors.Danger) Then
            LoadReturns("Credited")
        End If
    End Sub

    'BUTTON : PENDING
    Private Sub btn_pending_Click(sender As Object, e As EventArgs) Handles btn_pending.Click
        LoadReturns("Pending")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub

    Private Sub btn_credited_Click(sender As Object, e As EventArgs) Handles btn_credited.Click
        LoadReturns("Credited")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub
End Class