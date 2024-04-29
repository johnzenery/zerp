Imports DevExpress.XtraGrid.Views.Grid
Imports MySqlConnector

Public Class frm_purchaseorder_list


    'On Load
    Private Sub frm_purchaseorder_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        int_load("All")
        start_timer()
    End Sub



    '--- CONTROL ----

    'btn_fulfilled
    Private Sub btn_fulfilled_Click(sender As Object, e As EventArgs) Handles btn_fulfilled.Click
        If btn_fulfilled.Text.Equals("Fulfilled Orders") Then
            int_load("Completed")
            btn_fulfilled.Text = "Close"
            btn_fulfilled.ImageOptions.Image = My.Resources.cancel_32x32
            btn_obsolete.Enabled = False
        Else
            btn_fulfilled.Text = "Fulfilled Orders"
            int_load("All")
            btn_fulfilled.ImageOptions.Image = My.Resources.historyitem_32x32
            btn_obsolete.Enabled = True
        End If
    End Sub

    'btn_obsolete
    Private Sub btn_obsolete_Click(sender As Object, e As EventArgs) Handles btn_obsolete.Click
        If btn_obsolete.Text.Equals("Obsolete Orders") Then
            int_load("Obsolete")
            btn_obsolete.Text = "Close"
            btn_obsolete.ImageOptions.Image = My.Resources.cancel_32x32
            btn_fulfilled.Enabled = False
        Else
            int_load("All")
            btn_obsolete.Text = "Obsolete Orders"
            btn_obsolete.ImageOptions.Image = My.Resources.switchtimescalesto_32x32
            btn_fulfilled.Enabled = True
        End If
    End Sub

    'btn_new
    Private Async Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Await frm_main.LoadFrm(New frm_purchaseorder_edit, "frm_purchaseorder_new")
    End Sub




    '---- FUNCTIONS ----

    'Initialize
    Private Sub int_load(status As String)
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd As New MySqlCommand

                If status.Equals("All") Then
                    cmd = New MySqlCommand("SELECT concat('PO',LPAD(purchase_id,5,0)) purchase_id, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, ims_suppliers.supplier, total, status, date_generated, date_sent, DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) as edd,
                    user.first_name AS created_by, approved.first_name AS approved_by,
                   (CASE
                     WHEN CURDATE() < DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) THEN 'On-going'
                     WHEN CURDATE() = DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) THEN 'Due Date'
                     WHEN CURDATE() > DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) AND CURDATE() <= DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time + 7 DAY) THEN 'Overdue'
                     WHEN CURDATE() > DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time + 7 DAY) THEN 'Obsolete'
                    END) as lead_time_status, ims_purchase.terms
                    FROM ims_purchase 
                    LEFT JOIN ims_users AS user ON user.usr_id=created_by
                    LEFT JOIN ims_users AS approved ON approved.usr_id=approved_by
                    LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                    WHERE ims_purchase.deleted='0' AND NOT (status='Completed' OR status='Obsolete')
                    ORDER BY purchase_id DESC", connection)
                ElseIf status.Equals("Completed") Then
                    cmd = New MySqlCommand("SELECT concat('PO',LPAD(purchase_id,5,0)) purchase_id, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, ims_suppliers.supplier, total, status, date_generated, date_sent, user.first_name AS created_by, ims_purchase.terms, approved.first_name AS approved_by FROM ims_purchase 
                            LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                            LEFT JOIN ims_users as user ON user.usr_id=created_by
                            LEFT JOIN ims_users AS approved ON approved.usr_id=approved_by
                            WHERE ims_purchase.deleted='0' AND status='Completed' ORDER BY purchase_id DESC", connection)
                ElseIf status.Equals("Obsolete") Then
                    cmd = New MySqlCommand("SELECT concat('PO',LPAD(purchase_id,5,0)) purchase_id, (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, ims_suppliers.supplier, total, status, date_generated, date_sent, user.first_name AS created_by, ims_purchase.terms, approved.first_name AS approved_by FROM ims_purchase 
                            LEFT JOIN ims_suppliers ON ims_purchase.supplier=ims_suppliers.id
                            LEFT JOIN ims_users as user ON user.usr_id=created_by
                            LEFT JOIN ims_users AS approved ON approved.usr_id=approved_by
                            WHERE ims_purchase.deleted='0' AND status='obsolete' ORDER BY purchase_id DESC", connection)
                End If

                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_po.DataSource = dt
                grid_po_view.BestFitColumns()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Start Timer
    Private Sub start_timer()

        Select Case cbb_timer.SelectedIndex
            Case 0 : timer.Interval = 60000
            Case 1 : timer.Interval = 300000
            Case 2 : timer.Interval = 600000
            Case 3 : timer.Interval = 1800000
        End Select

        timer.Stop()
        timer.Start()

    End Sub

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        int_load("All")
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub

    'Show Ordered Items
    Private Sub btn_ordered_items_Click(sender As Object, e As EventArgs) Handles btn_ordered_items.Click
        frm_purchaseorder_view_ordered_items.Show()
    End Sub

    'Refresh via F5
    Private Sub frm_collection_payments_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F5 Then
            If btn_fulfilled.Text.Equals("Fulfilled Orders") Then
                int_load("All")

            ElseIf btn_fulfilled.Text.Equals("Close") Then
                int_load("Completed")
            End If
        End If
    End Sub


    'Purchase Order Approval
    Private Async Sub grid_po_view_RowCellClick(sender As Object, e As DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs) Handles grid_po_view.RowCellClick
        If grid_po_view.FocusedColumn.Name.Equals(col_id.Name) Then
            Dim pid = grid_po_view.GetFocusedRowCellValue(col_id)

            Dim frm = New frm_purchaseorder_edit
            frm.txt_poid.Text = pid

            If Equals(grid_po_view.GetFocusedRowCellValue(col_lead_time_status), "Obsolete") Then
                frm.lbl_dispose.Visible = True
            End If

            frm.Init("_view")
            'frm.ShowDialog()
            Await frm_main.LoadFrm(frm, "purchase_approval_" & pid)
        End If
    End Sub

    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        int_load("All")
    End Sub

End Class