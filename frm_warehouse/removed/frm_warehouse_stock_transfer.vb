Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_warehouse_stock_transfer

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ---
    Private Sub frm_warehouse_stock_transfer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_transferred()
    End Sub





    '--- FUNCTIONS ---
    Private Sub load_transferred()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT concat('ST',LPAD(id,5,0)) as id, date, status, 
                (SELECT store_name FROM ims_stores WHERE store_id=src_store) as src_store, 
                (SELECT store_name FROM ims_stores WHERE store_id=receiver_store) as receiver_store 
                FROM ims_transferred_stocks
                WHERE is_deleted='0' 
                AND NOT (status='Completed' OR status='Resolved' OR status='Cancelled')
                AND ( src_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) OR receiver_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) )
                ORDER BY date DESC", conn)
            cmd.Parameters.AddWithValue("@my_store", frm_main.user_store.Text)

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_stock_transferred.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'For Editing
    Private Sub set_data_to_fields(units As String, grid As DataGridView)
        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT pid, winmodel, description FROM ims_inventory WHERE pid=@pid", conn)
                cmd.Parameters.AddWithValue("@pid", Nothing)
                cmd.Prepare()

                Dim units_arr = units.Split(";")

                For i = 0 To units_arr.Length - 1

                    Dim items = units_arr(i).Split("=")

                    cmd.Parameters(0).Value = items(0)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            grid.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), items(1), items(2))
                        End While
                    End Using

                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'For Receiving
    Private Sub set_data_to_grid(units As String, received_units As String, grid As DataGridView)
        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT pid, winmodel, description FROM ims_inventory WHERE pid=@pid", conn)
                cmd.Parameters.AddWithValue("@pid", Nothing)
                cmd.Prepare()

                Dim units_arr = units.Split(";")
                Dim received_units_arr = received_units.Split(";")

                For i = 0 To units_arr.Length - 1

                    Dim items = units_arr(i).Split("=")
                    Dim received_items = received_units_arr(i).Split("=")

                    cmd.Parameters(0).Value = items(0)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            grid.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), items(1), received_items(1))
                        End While
                    End Using

                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub




    '--- CONTROLS ----

    'btn_refresh
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_transferred()
    End Sub

    'btn_request_transfer
    Private Sub btn_request_transfer_Click(sender As Object, e As EventArgs) Handles btn_request_transfer.Click
        Dim frm = New frm_warehouse_stock_transfer_new
        frm.cbb_destination.Enabled = True
        frm.ShowDialog()
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If grid_stock_transferred_view.RowCount = 0 Then Exit Sub

        Dim id As Integer = grid_stock_transferred_view.GetFocusedRowCellValue(col_id).ToString.Replace("ST", "")

        Try
            Dim units = ""
            Dim report = New doc_transfer_request()
            Dim printTool = New ReportPrintTool(report)

            Dim table = New PrintData
            table.transferred_units.Rows.Clear()

            conn.Open()
            Dim query = "SELECT id, src_store.store_name AS src_store, receiver_store.store_name AS receiver_store, 
                 units, date, transfer_by.first_name AS transfer_by, approved_by.first_name AS approved_by, prepared_by, counted_by, driver, released_by.first_name AS released_by,
                (SELECT first_name FROM ims_users WHERE usr_id=received_by) as receiver, status,
                (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name,
                (SELECT value FROM ims_settings WHERE name='store_info') as store_info
                FROM `ims_transferred_stocks`
                LEFT JOIN ims_stores As src_store ON src_store.store_id=ims_transferred_stocks.src_store
                LEFT JOIN ims_stores As receiver_store ON receiver_store.store_id=ims_transferred_stocks.receiver_store
                LEFT JOIN ims_users AS transfer_by ON transfer_by.usr_id=ims_transferred_stocks.transfer_by
                LEFT JOIN ims_users AS released_by ON released_by.usr_id=ims_transferred_stocks.released_by
                LEFT JOIN ims_users AS approved_by ON approved_by.usr_id=ims_transferred_stocks.approved_by WHERE id=" & id

            Dim cmd = New MySqlCommand(query, conn)
            Using rdr = cmd.ExecuteReader
                While rdr.Read
                    report.Watermark.Text = rdr("status").ToString.ToUpper
                    report.Parameters("transfer_id").Value = "ST" & id.ToString.PadLeft(5, "0"c)
                    report.Parameters("transfer_date").Value = rdr("date")
                    report.Parameters("transfer_from").Value = rdr("src_store")
                    report.Parameters("transfer_to").Value = rdr("receiver_store")

                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info")

                    report.Parameters("transfer_by").Value = rdr("transfer_by")
                    report.Parameters("approved_by").Value = IIf(IsDBNull(rdr("approved_by")), "", rdr("approved_by"))
                    report.Parameters("prepared_by").Value = IIf(IsDBNull(rdr("prepared_by")), "", rdr("prepared_by"))
                    report.Parameters("counted_by").Value = IIf(IsDBNull(rdr("counted_by")), "", rdr("counted_by"))
                    report.Parameters("driver").Value = IIf(IsDBNull(rdr("driver")), "", rdr("driver"))
                    report.Parameters("released_by").Value = IIf(IsDBNull(rdr("released_by")), "", rdr("released_by"))

                    report.Parameters("received_by").Value = IIf(IsDBNull(rdr("receiver")), "", rdr("receiver"))

                    units = rdr("units")

                End While
            End Using

            Dim per_unit = units.Split(";")
            For i = 0 To per_unit.Length - 1

                Dim arr = per_unit(i).Split("=")

                Dim cmd_desc = New MySqlCommand("SELECT winmodel, description, qty_per_box FROM ims_inventory WHERE pid=@pid", conn)
                cmd_desc.Parameters.AddWithValue("@pid", arr(0))
                Dim rd As MySqlDataReader = cmd_desc.ExecuteReader

                While rd.Read
                    table.transferred_units.Rows.Add(arr(1), arr(1) / rd("qty_per_box"), rd("winmodel"), rd("description"), arr(2))
                End While
                rd.Close()
            Next

            report.RequestParameters = False
            report.DataSource = table
            report.ShowRibbonPreviewDialog

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Enable btn_ship if the status is APPROVED
    Private Sub grid_stock_transferred_view_FocusedRowChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grid_stock_transferred_view.FocusedRowChanged
        If grid_stock_transferred_view.RowCount > 0 Then
            Dim status = grid_stock_transferred_view.GetFocusedRowCellValue(col_status)
            If Not status.Equals("Approved") Then
                btn_dispatch.Enabled = False
            Else
                btn_dispatch.Enabled = True
            End If
        End If
    End Sub

    'btn_edit
    Private Sub btn_edit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick
        Dim id As Integer = grid_stock_transferred_view.GetFocusedRowCellValue(col_id).ToString.Replace("ST", "")

        Try
            Dim units = "", received_units = ""
            Dim frm = New frm_warehouse_stock_transfer_new

            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT src_store.store_name as src_store, receiver_store.store_name as receiver_store, units, status, received_units
                        FROM ims_transferred_stocks 
                        LEFT JOIN ims_stores As src_store ON src_store.store_id=ims_transferred_stocks.src_store
                        LEFT JOIN ims_stores As receiver_store ON receiver_store.store_id=ims_transferred_stocks.receiver_store
                        WHERE id=" & id, conn)
                Dim rdr = cmd.ExecuteReader

                While rdr.Read
                    units = rdr("units")
                    received_units = rdr("received_units")
                    frm.cbb_destination.Text = rdr("receiver_store")
                    frm.cbb_source.Text = rdr("src_store")
                    frm.LoadStoreUnits()

                    Select Case rdr("status")
                        Case "Pending", "Approved"
                            frm.cbb_destination.Enabled = True
                        Case Else
                            MsgBox("Modification is NOT allowed.", vbInformation, "Information")
                            Exit Sub
                    End Select

                    frm.lbl_title.Text = frm.lbl_title.Text & " (ST" & id.ToString.PadLeft(5, "0"c) & ")"
                    frm.cbb_source.Enabled = False
                End While

            End Using

            'Set Data to grid_receiver
            set_data_to_fields(units, frm.grid_receiver)

            'Show Save Button
            frm.btn_transfer.Visible = False
            frm.btn_save.Visible = True
            frm.btn_save.Location = New Point(1040, 18)

            'Show Dialog
            frm.ShowDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'btn_delete
    Private Sub btn_delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete.ButtonClick
        If grid_stock_transferred_view.GetFocusedRowCellValue(col_status) = "Dispatched" Then
            If MsgBox("Stock Transfer is already dispatched!" & Environment.NewLine & Environment.NewLine & "Do you want to cancel it instead?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim store_name = "ims_" & grid_stock_transferred_view.GetFocusedRowCellValue(col_from).ToString.ToLower.Replace(" ", "_")

                    'GET DATA AND RESTORE STOCKS TO SOURCE
                    Using get_cmd = New MySqlCommand("SELECT units FROM ims_transferred_stocks WHERE id=@id", connection)
                        Dim units = String.Empty
                        get_cmd.Parameters.AddWithValue("@id", CInt(grid_stock_transferred_view.GetFocusedRowCellValue(col_id).ToString.Replace("ST", "")))
                        Using rdr = get_cmd.ExecuteReader
                            While rdr.Read()
                                units = rdr("units")
                            End While
                        End Using

                        Dim per_unit = units.ToString.Split(";")
                        For i = 0 To per_unit.Length - 1

                            Dim arr = per_unit(i).Split("=")

                            Using cmd_revert = New MySqlCommand("UPDATE " & store_name & " SET qty=qty+@qty, on_hold=on_hold-@qty WHERE pid=@pid", connection)
                                cmd_revert.Parameters.AddWithValue("@pid", arr(0))
                                cmd_revert.Parameters.AddWithValue("@qty", arr(1))
                                cmd_revert.ExecuteNonQuery()
                            End Using
                        Next
                    End Using

                    'UPDATE ims_transferred_stocks
                    Using cmd = New MySqlCommand("UPDATE ims_transferred_stocks SET status='Cancelled' WHERE id=@id", connection)
                        cmd.Parameters.AddWithValue("@id", CInt(grid_stock_transferred_view.GetFocusedRowCellValue(col_id).ToString.Replace("ST", "")))
                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Stock Transfer was cancelled!", vbInformation, "Information")
                            frm_main.LoadFrm(New frm_warehouse_stock_transfer)
                        End If
                    End Using

                End Using
            End If
        Else
            If MsgBox("Delete this Transfer Request?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim query = "UPDATE ims_transferred_stocks SET is_deleted='1' WHERE id=@id"
                    Dim cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@id", CInt(grid_stock_transferred_view.GetFocusedRowCellValue(col_id).ToString.Replace("ST", "")))
                    cmd.ExecuteNonQuery()
                End Using

                load_transferred()
            End If
        End If

    End Sub

    'btn_dispatch
    Private Sub btn_dispatch_Click(sender As Object, e As EventArgs) Handles btn_dispatch.Click
        Dim frm = New frm_warehouse_stocktransfer_dispatch_dialog
        frm.txt_transfer_id.Text = grid_stock_transferred_view.GetFocusedRowCellValue(col_id)
        frm.ShowDialog()
    End Sub

    'btn_receive
    Private Sub btn_receive_Click(sender As Object, e As EventArgs) Handles btn_receive.Click

        Dim frm = New frm_warehouse_stock_transfer_receive_dialog

        If frm.ShowDialog() = DialogResult.OK Then

            Dim id As Integer
            Dim units = "", status = "", received_units = ""

            Try
                id = CInt(frm.txt_stock_transfer_id.Text.Replace("ST", ""))
            Catch ex As Exception
                MsgBox("Incorrect ID format!", vbCritical, "Invalid ID")
                Exit Sub
            End Try

            Try

                Dim frm_receive = New frm_warehouse_stocktransfer_receive

                Using conn
                    conn.Open()

                    Dim cmd = New MySqlCommand("SELECT count(*), from_store.store_name AS src_store, to_store.store_name AS receiver_store, units, status, received_units
                            FROM ims_transferred_stocks
                            INNER JOIN ims_stores AS from_store ON from_store.store_id=src_store
                            INNER JOIN ims_stores AS to_store ON to_store.store_id=receiver_store WHERE id=" & id, conn)

                    'Check IF exist
                    Dim count = cmd.ExecuteScalar
                    If count = 0 Then
                        MsgBox("No Transfer Record found.", vbCritical, "Not Found")
                        Exit Sub
                    End If

                    'Get Data to Form
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            'frm_receive.txt_source.Properties.Items.Add(rdr("src_store"))
                            'frm_receive.cbb_source.Text = rdr("src_store")
                            'frm_receive.cbb_destination.Properties.Items.Add(rdr("receiver_store"))
                            'frm_receive.cbb_destination.Text = rdr("receiver_store")
                            'frm_receive.lbl_transfer_id.Text = "ST" & id.ToString.PadLeft(5, "0"c)
                            units = rdr("units")
                            status = rdr("status")
                            received_units = rdr("received_units")
                        End While

                        Select Case status
                            Case "Pending"
                                MsgBox("Stock Transfer is NOT YET DISPATCHED.", vbInformation, "Forbidden")
                                Exit Sub
                            Case "Approved"
                                MsgBox("Stock Transfer is NOT YET DISPATCHED.", vbInformation, "Forbidden")
                                Exit Sub
                            Case "Reported", "Resolved"
                                'MsgBox("Modification is NOT allowed." & vbCrLf & "Reason: ALREADY_REPORTED/RESOLVED/COMPLETED", vbInformation, "Forbidden")
                                frm_receive.grid_TransferStocks.Enabled = False
                                frm_receive.btn_save.Enabled = False
                        End Select

                    End Using
                End Using

                If Not String.IsNullOrEmpty(received_units) Then
                    set_data_to_grid(units, received_units, frm_receive.grid_TransferStocks)
                Else
                    set_data_to_fields(units, frm_receive.grid_TransferStocks)
                End If

                frm_receive.ShowDialog()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'btn_reconcile
    Private Sub btn_reconcile_Click(sender As Object, e As EventArgs) Handles btn_reconcile.Click
        frm_main.LoadFrm(New frm_warehouse_stock_reconcile_list)
    End Sub

    'lbl_resolved
    Private Sub lbl_resolved_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_resolved.LinkClicked
        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT concat('ST',LPAD(id,5,0)) as id, date, status, 
                (SELECT store_name FROM ims_stores WHERE store_id=src_store) as src_store, 
                (SELECT store_name FROM ims_stores WHERE store_id=receiver_store) as receiver_store 
                FROM ims_transferred_stocks
                WHERE is_deleted='0' 
                AND status='Resolved'
                AND ( src_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) OR receiver_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) )
                ORDER BY date DESC", conn)
                cmd.Parameters.AddWithValue("@my_store", frm_main.user_store.Text)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_stock_transferred.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
        col_delete.Visible = False
    End Sub

    'lbl_completed
    Private Sub lbl_completed_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_completed.LinkClicked
        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT concat('ST',LPAD(id,5,0)) as id, date, status, 
                (SELECT store_name FROM ims_stores WHERE store_id=src_store) as src_store, 
                (SELECT store_name FROM ims_stores WHERE store_id=receiver_store) as receiver_store 
                FROM ims_transferred_stocks
                WHERE is_deleted='0' 
                AND status='Completed'
                AND ( src_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) OR receiver_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) )
                ORDER BY date DESC", conn)
                cmd.Parameters.AddWithValue("@my_store", frm_main.user_store.Text)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_stock_transferred.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
        col_delete.Visible = False
    End Sub

    'lbl_cancelled
    Private Sub lbl_cancelled_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_cancelled.LinkClicked
        Try
            Using conn
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT concat('ST',LPAD(id,5,0)) as id, date, status, 
                (SELECT store_name FROM ims_stores WHERE store_id=src_store) as src_store, 
                (SELECT store_name FROM ims_stores WHERE store_id=receiver_store) as receiver_store 
                FROM ims_transferred_stocks
                WHERE is_deleted='0' 
                AND status='Cancelled'
                AND ( src_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) OR receiver_store=(SELECT store_id FROM ims_stores WHERE store_name=@my_store) )
                ORDER BY date DESC", conn)
                cmd.Parameters.AddWithValue("@my_store", frm_main.user_store.Text)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_stock_transferred.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
        col_delete.Visible = False
    End Sub

    'lbl_inprogress
    Private Sub lbl_inprogress_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_inprogress.LinkClicked
        load_transferred()
        col_delete.Visible = True
    End Sub


End Class