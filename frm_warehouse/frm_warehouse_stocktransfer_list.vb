Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports MySqlConnector

Public Class frm_warehouse_stocktransfer_list

    '--- ONLOAD ---
    Private Sub frm_warehouse_stocktransfer_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetCount()
        btn_pending.PerformClick()
        load_sub_transfers(False)
    End Sub



    '--- FUNCTIONS

    'Load All Stock Transfers
    Private Sub load_stock_transfers(status As String) 'show_completed As Boolean
        'Dim addtl_query As String = IIf(show_completed = True, "", "NOT")

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                'Using cmd = New MySqlCommand("SELECT concat('ST',LPAD(transfer_id,5,0)) AS transfer_id, status, created_at, linked_warehouse,
                '                    transfer_type, ims_stores.store_name AS  src_warehouse, ims_users.first_name AS created_by, total_cbm, total_kgs
                '                    FROM ims_stock_transfer 
                '                    INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                '                    INNER JOIN ims_users ON ims_users.usr_id=ims_stock_transfer.created_by
                '                    WHERE is_deleted=0 AND " & addtl_query & " status='Completed'
                '                    ORDER BY transfer_id DESC", connection)
                Using cmd = New MySqlCommand("SELECT concat('ST',LPAD(transfer_id,5,0)) AS transfer_id, status, created_at, linked_warehouse,
                                    transfer_type, ims_stores.store_name AS  src_warehouse, ims_users.first_name AS created_by, total_cbm, total_kgs
                                    FROM ims_stock_transfer 
                                    INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                                    INNER JOIN ims_users ON ims_users.usr_id=ims_stock_transfer.created_by
                                    WHERE ims_stock_transfer.is_deleted=0 AND " & status & "
                                    ORDER BY transfer_id DESC", connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_stock_transfers.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Transfers
    Private Sub load_sub_transfers(show_completed As Boolean)
        Dim addtl_query As String = IIf(show_completed = True, "", "NOT")

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim query = "SELECT sub_transfer_id, CONCAT('ST', LPAD(root_transfer_id, 5, '0')) as root_transfer_id, transfer_type, status,
                                    SRC.store_name AS from_warehouse, RECVR.store_name AS to_warehouse, delivered_by
                                    FROM ims_stock_transfer_sub
                                    INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                    INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                    WHERE " & addtl_query & " (status='Transferred' OR status='Cancelled')
                                    ORDER BY sub_transfer_id DESC"


                Dim cmd = New MySqlCommand(query, connect)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_sub_transfer.DataSource = dt

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Count Label
    Private Sub SetCount()
        Try
            Using connect = New MySqlConnection(str)

                connect.Open()

                'Pending 
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer WHERE NOT (status='Completed' OR status='Approved' OR status='Pending for Arrangement' OR status='Arranging' ) AND is_deleted=0", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    btn_pending.Text = "Pending (" & count & ")"
                End Using

                'Approved
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer WHERE status='Approved' AND is_deleted=0", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    btn_approved.Text = "Approved (" & count & ")"
                End Using

                'Arranging
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_stock_transfer WHERE (status='Arranging' OR status='Pending for Arrangement') AND is_deleted=0", connect)
                    Dim count As Integer = cmd.ExecuteScalar()
                    btn_arrange.Text = "Arranging (" & count & ")"
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Highlight Active Sort Button
    Private Sub HighlightButton(btn As SimpleButton)
        btn_show_completed.Appearance.BackColor = Nothing
        btn_pending.Appearance.BackColor = Nothing
        btn_approved.Appearance.BackColor = Nothing
        btn_arrange.Appearance.BackColor = Nothing
        btn_completed.Appearance.BackColor = Nothing

        btn.Appearance.BackColor = DXSkinColors.FillColors.Primary
    End Sub






    '--- CONTROLS ---

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        btn_pending.PerformClick()
        SetCount()
        load_sub_transfers(IIf(btn_completed.Text = "Close", True, False))
    End Sub



    '>>> STOCK TRANSFERS

    'NEW
    Private Sub btn_new_stockTransfer_Click(sender As Object, e As EventArgs) Handles btn_new_stockTransfer.Click
        newTransfer_contextMenu.Show(btn_new_stockTransfer, New Point(btn_new_stockTransfer.Width - btn_new_stockTransfer.Width, btn_new_stockTransfer.Height))
    End Sub

    'Distribute Strip Menu
    Private Async Sub stripMenu_distribute_Click(sender As Object, e As EventArgs) Handles stripMenu_distribute.Click
        Await frm_main.LoadFrm(New frm_warehouse_stocktransfer_new_distribute, "frm_warehouse_stocktransfer_distribute_new")
    End Sub

    'Request Strip Menu
    Private Async Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        Await frm_main.LoadFrm(New frm_warehouse_stocktransfer_new_request, "frm_warehouse_stocktransfer_request_new")
    End Sub

    'BUTTON VIEW
    Private Async Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick

        If grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type).Equals("Distribute") Then
            Dim frm = New frm_warehouse_stocktransfer_new_distribute
            Dim transfer_id As String = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            Await frm_main.LoadFrm(frm, "stock_transfer_" & transfer_id)
            frm.LoadEdit(transfer_id.Replace("ST", String.Empty))

        ElseIf grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_type).Equals("Request") Then
            Dim frm = New frm_warehouse_stocktransfer_new_request
            Dim transfer_id As String = grid_stock_transfers_view.GetFocusedRowCellValue(col_transfer_id)
            Await frm_main.LoadFrm(frm, "stock_transfer_" & transfer_id)
            frm.LoadEdit(transfer_id.Replace("ST", String.Empty))
        End If

    End Sub

    'BUTTON FILTER : COMPLETED
    Private Sub btn_show_completed_Click(sender As Object, e As EventArgs) Handles btn_show_completed.Click
        load_stock_transfers("status='Completed'")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub


    'BUTTON FILTER : APPROVED
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        load_stock_transfers("status='Approved'")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub

    'BUTTON FILTER : ARRANGING
    Private Sub btn_arrange_Click(sender As Object, e As EventArgs) Handles btn_arrange.Click
        load_stock_transfers("(status='Arranging' OR status='Pending for Arrangement')")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub

    Private Sub btn_pending_Click(sender As Object, e As EventArgs) Handles btn_pending.Click
        load_stock_transfers("NOT (status='completed' OR status='Approved' OR status='Pending for Arrangement' OR status='Arranging' )")
        HighlightButton(TryCast(sender, SimpleButton))
    End Sub



    '>>> SUB - STOCK TRANSFERS
    Private Sub btn_cancel_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_cancel.ButtonClick
        Dim frm = New frm_warehouse_stocktransfer_cancel_dialog
        frm.lbl_sub_transfer_id.Text = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_id)
        frm.lbl_stock_transfer_id.Text = grid_sub_transfer_view.GetFocusedRowCellValue(col_root_transfer_id)
        frm.lbl_transfer_type.Text = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_type)
        Dim status = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_status)
        frm.lbl_status.Text = status

        Dim FROM_warehouse As String = grid_sub_transfer_view.GetFocusedRowCellValue(col_from)
        Dim TO_warehouse As String = grid_sub_transfer_view.GetFocusedRowCellValue(col_to)
        Dim transfer_type As String = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_type)
        Dim submitted_warehouse = String.Empty

        Select Case transfer_type
            Case "Distribute" : submitted_warehouse = TO_warehouse.Replace("Winland ", String.Empty).Trim
            Case "Request" : submitted_warehouse = FROM_warehouse.Replace("Winland ", String.Empty).Trim
        End Select

        'IF Completely Transferred
        If status.Equals("Dispatched") Then
            MsgBox("Not allowed for dispatched!", vbInformation, "Information")
            Return
        End If

        'IF Completely Transferredc
        If status.Equals("Transferred") Then
            MsgBox("Already Transferred! Nothing was changed.", vbInformation, "Information")
            Return
        End If

        'IF Pending Cancellation
        If status.Equals("Pending Cancellation") Then
            MsgBox("Cancellation process is on-going...", vbInformation, "Information")
            Return
        End If

        'IF Cancelled
        If status.Equals("Cancelled") Then
            MsgBox("Already Cancelled!", vbInformation, "Information")
            Return
        End If

        If frm.ShowDialog = DialogResult.OK Then
            If status.Equals("Packed") Then

                Try
                    Using connect = New MySqlConnection(str)
                        connect.Open()
                        Using cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub SET status='Pending Cancellation' WHERE sub_transfer_id=@sid;
                                        UPDATE ims_stock_transfer 
                                        SET ims_stock_transfer.status=IF(" & CheckIfCompleted(connect) & "=True, 'Completed', ims_stock_transfer.status),
                                        delivered_warehouse=IF(delivered_warehouse='', '" & submitted_warehouse & "', CONCAT(delivered_warehouse, ', ', '" & submitted_warehouse & "'))
                                        WHERE transfer_id=@root_id", connect)
                            cmd.Parameters.AddWithValue("@sid", grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_id))
                            cmd.Parameters.AddWithValue("@root_id", CInt(grid_sub_transfer_view.GetFocusedRowCellValue(col_root_transfer_id).ToString.Replace("ST", "")))
                            If cmd.ExecuteNonQuery > 0 Then
                                MsgBox("Sent back to Package Dept. for unpacking!", vbInformation, "Information")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try


            ElseIf status.Equals("Arranging") Or status.Equals("Pending for Arrangement") Then

                Try
                    Using connect = New MySqlConnection(str)
                        connect.Open()
                        Using cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub SET status='Cancelled' WHERE sub_transfer_id=@sid;
                                        UPDATE ims_stock_transfer 
                                        SET ims_stock_transfer.status=IF(" & CheckIfCompleted(connect) & "=True, 'Completed', ims_stock_transfer.status),
                                        delivered_warehouse=IF(delivered_warehouse='', '" & submitted_warehouse & "', CONCAT(delivered_warehouse, ', ', '" & submitted_warehouse & "'))
                                        WHERE transfer_id=@root_id", connect)
                            cmd.Parameters.AddWithValue("@sid", grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_id))
                            cmd.Parameters.AddWithValue("@root_id", CInt(grid_sub_transfer_view.GetFocusedRowCellValue(col_root_transfer_id).ToString.Replace("ST", "")))
                            If cmd.ExecuteNonQuery > 0 Then
                                MsgBox("Cancelled!", vbInformation, "Information")
                            End If
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try


            End If

            'Refresh Data
            load_sub_transfers(IIf(btn_completed.Text = "Close", True, False))

        End If

    End Sub


    'Check IF Completed
    Private Function CheckIfCompleted(connect As MySqlConnection) As Boolean

        Dim return_res = False
        Dim FROM_warehouse As String = grid_sub_transfer_view.GetFocusedRowCellValue(col_from)
        Dim TO_warehouse As String = grid_sub_transfer_view.GetFocusedRowCellValue(col_to)
        Dim transfer_type As String = grid_sub_transfer_view.GetFocusedRowCellValue(col_sub_transfer_type)
        Dim submitted_warehouse = String.Empty

        If Equals(transfer_type, "Distribute") Then
            submitted_warehouse = TO_warehouse.Replace("Winland ", String.Empty).Trim
        ElseIf Equals(transfer_type, "Request") Then
            submitted_warehouse = FROM_warehouse.Replace("Winland ", String.Empty).Trim
        End If


        Try
            Using cmd = New MySqlCommand("SELECT linked_warehouse, delivered_warehouse 
                            FROM ims_stock_transfer 
                            WHERE transfer_id=" & CInt(grid_sub_transfer_view.GetFocusedRowCellValue(col_root_transfer_id).ToString.Replace("ST", "")), connect)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        Dim linkedWarehouse As String = rdr("linked_warehouse")


                        Dim deliveredWarehouse As String = String.Concat(rdr("delivered_warehouse"), ", ", submitted_warehouse)
                        Dim linked_warehouse As New List(Of String)
                        linked_warehouse.AddRange(linkedWarehouse.ToString.Split(","c))

                        Dim result = 0
                        For Each l_warehouse As String In linked_warehouse

                            If deliveredWarehouse.Contains(l_warehouse.Trim) Then
                                result += 1
                            End If
                        Next

                        If linked_warehouse.Count = result Then
                            return_res = True
                        Else
                            return_res = False
                        End If

                    End While
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return return_res

    End Function


    Private Sub show_completed_Click(sender As Object, e As EventArgs) Handles btn_completed.Click
        If btn_completed.Text = "View Completed / Cancelled" Then
            load_sub_transfers(True)
            btn_completed.Text = "Close"
        Else
            load_sub_transfers(False)
            btn_completed.Text = "View Completed / Cancelled"
        End If
    End Sub




End Class