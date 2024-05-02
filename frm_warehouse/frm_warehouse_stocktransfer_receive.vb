Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Text.RegularExpressions

Public Class frm_warehouse_stocktransfer_receive

    Private Property root_transfer_id As Integer

    '--- ONLOAD ---
    Private Sub frm_warehouse_stock_transfer_receive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWarehouseToComboDestination()
    End Sub


    '--- FUNCTIONS ---

    'Set All Store to cbb_destination
    Private Sub LoadWarehouseToComboDestination()
        Using connect = New MySqlConnection(str)
            connect.Open()
            Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores", connect)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_destination.Items.Add(rdr("store_name"))
                        cbb_source.Items.Add(rdr("store_name"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    'Load Stock Transfer Deliveries
    Public Sub LoadStockTransferDeliveries(_ToCompareComboBox As String)
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()
                Dim items = String.Empty
                grid_TransferStocks.Rows.Clear()

                Using cmd = New MySqlCommand("SELECT transfer_type, item, root_transfer_id,
                                        SRC.store_name AS src_store, RECVR.store_name AS recvr_store
                                        FROM ims_stock_transfer_sub
                                        LEFT JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                        LEFT JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                                        WHERE sub_transfer_id=@stid", connect)
                    cmd.Parameters.AddWithValue("@stid", CInt(lbl_transfer_id.Text))
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read

                            items = rdr("item")

                            root_transfer_id = rdr("root_transfer_id")
                            cbb_source.Text = rdr("src_store")
                            cbb_destination.Text = rdr("recvr_store")
                            cbb_source.Enabled = False
                            cbb_destination.Enabled = False

                        End While
                    End Using

                    'Set to Grid
                    SetToGrid(items, connect)

                End Using
                'Valdation
                If grid_TransferStocks.Rows.Count = 0 Then
                    btn_save.Enabled = False
                Else
                    btn_save.Enabled = True
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Display to Grid
    Private Sub SetToGrid(units As String, connect As MySqlConnection)

        Dim comma(), piece, equal() As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        'Clear DataTable
        If grid_TransferStocks.Rows.Count > 0 Then grid_TransferStocks.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            Using cmd = New MySqlCommand("SELECT winmodel, description
                            FROM ims_inventory WHERE pid=@pid", connect)
                cmd.Parameters.AddWithValue("@pid", 0)
                cmd.Prepare()

                comma = colonseparator.Split(units)

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    cmd.Parameters("@pid").Value = equal(0)

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            grid_TransferStocks.Rows.Add(equal(0), rdr("winmodel"), rdr("description"), equal(1).Trim.Replace(";", String.Empty), String.Empty)
                        End While
                    End Using

                Next

            End Using

        End If


    End Sub

    'Get Store/Warehouse list
    Private Function LoadStoreList() As List(Of String)
        Dim store_list = New List(Of String)
        Using connect = New MySqlConnection(str)
            connect.Open()

            Using cmd = New MySqlCommand("SELECT store_id, store_name FROM ims_stores", connect)
                Using rdr = cmd.ExecuteReader
                    Dim i = 0
                    store_list.Clear()

                    While rdr.Read
                        store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                    End While
                End Using
            End Using

            Return store_list

        End Using
    End Function





    Private Function transfer_func()

        Dim to_receive_count = 0
        Dim delivered_count = 0
        Dim source_store = "ims_" & cbb_source.Text.Trim.ToLower.Replace(" ", "_")
        Dim destination_store = "ims_" & cbb_destination.Text.Trim.ToLower.Replace(" ", "_")

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                'Check Stocks Availabilty in ON_HOLD
                'If check_stocks(source_store, grid_TransferStocks) Then Return "Failed"



                'Get to_ReceiveCount and DeliveredCount
                For i = 0 To grid_TransferStocks.Rows.Count - 1
                    to_receive_count += CInt(grid_TransferStocks.Rows(i).Cells(3).Value)
                    delivered_count += CInt(grid_TransferStocks.Rows(i).Cells(4).Value)
                Next

                'Compare to_ReceiveCount and DeliveredCount
                If Not to_receive_count = delivered_count Then
                    Dim ans = MsgBox("Incomplete delivery. Continue anyway?", vbYesNo + vbExclamation, "Confirmation")
                    If Not ans = vbYes Then Return "Exit"
                End If



                'Update Source table and Set to destination table
                Dim cmd_deduct = New MySqlCommand("UPDATE " & source_store & " SET on_hold=on_hold-@qty WHERE pid=@pid", connect)
                cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
                cmd_deduct.Parameters.AddWithValue("@qty", Nothing)
                cmd_deduct.Prepare()

                For i = 0 To grid_TransferStocks.Rows.Count - 1

                    cmd_deduct.Parameters(0).Value = grid_TransferStocks.Rows(i).Cells(0).Value
                    cmd_deduct.Parameters(1).Value = grid_TransferStocks.Rows(i).Cells(4).Value
                    Dim inserted = cmd_deduct.ExecuteNonQuery

                    If inserted > 0 Then
                        Dim cmd_add = New MySqlCommand("INSERT INTO " & destination_store & " (pid, qty) VALUES (@pid,@qty) ON DUPLICATE KEY UPDATE qty=qty+@qty;
                                        INSERT INTO ims_stock_transfer_logs (original_qty, qty, pid, from_warehouse, to_warehouse, date_received, received_by, transfer_id, subtransfer_id) 
                                        VALUES (@original_qty, @qty, @pid, (SELECT store_id FROM ims_stores WHERE store_name=@from), (SELECT store_id FROM ims_stores WHERE store_name=@to), NOW(), @received_by, @transfer_id, @subtransfer_id )", connect)
                        cmd_add.Parameters.AddWithValue("@pid", grid_TransferStocks.Rows(i).Cells(0).Value)
                        cmd_add.Parameters.AddWithValue("@original_qty", grid_TransferStocks.Rows(i).Cells(3).Value)
                        cmd_add.Parameters.AddWithValue("@qty", grid_TransferStocks.Rows(i).Cells(4).Value)
                        cmd_add.Parameters.AddWithValue("@from", cbb_source.Text.Trim)
                        cmd_add.Parameters.AddWithValue("@to", cbb_destination.Text.Trim)
                        cmd_add.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                        cmd_add.Parameters.AddWithValue("@transfer_id", root_transfer_id)
                        cmd_add.Parameters.AddWithValue("@subtransfer_id", CInt(lbl_transfer_id.Text))
                        cmd_add.ExecuteNonQuery()
                    End If

                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        'Return status
        If to_receive_count = delivered_count Then
            Return "Complete"
        Else
            Return "Incomplete"
        End If

    End Function

    'Check Stock's Availability
    Private Function check_stocks(source_store As String, grid As DataGridView)

        Using connection = New MySqlConnection(str)
            connection.Open()

            Dim low_stocks_level = String.Empty
            Dim cmd_check = New MySqlCommand("SELECT IFNULL(on_hold, 0) FROM " & source_store & " WHERE pid=@pid", connection)
            cmd_check.Parameters.AddWithValue("@pid", Nothing)
            cmd_check.Prepare()

            For i = 0 To grid.Rows.Count - 1

                cmd_check.Parameters(0).Value = grid.Rows(i).Cells(0).Value
                Dim qty_result As Integer = cmd_check.ExecuteScalar

                If CInt(grid.Rows(i).Cells(4).Value) > qty_result Then
                    If i = grid.Rows.Count - 1 Then
                        low_stocks_level += grid.Rows(i).Cells(0).Value
                    Else
                        low_stocks_level += grid.Rows(i).Cells(0).Value & vbCrLf
                    End If
                End If

            Next

            If Not String.IsNullOrEmpty(low_stocks_level) Then
                MsgBox("Couldn't proceed!" & vbCrLf & vbCrLf & "Low On-Hold stock level items:" & vbCrLf & low_stocks_level, vbCritical, "Low Level")
                Return True
            End If
        End Using

        Return False

    End Function

    'Get SKU & Qty Received
    Private Function get_received_units()

        Dim units = String.Empty
        For i = 0 To grid_TransferStocks.Rows.Count - 1
            If i = grid_TransferStocks.Rows.Count - 1 Then
                units += grid_TransferStocks.Rows(i).Cells(0).Value & "=" & grid_TransferStocks.Rows(i).Cells(4).Value
                Continue For
            End If
            units += grid_TransferStocks.Rows(i).Cells(0).Value & "=" & grid_TransferStocks.Rows(i).Cells(4).Value & ";"
        Next

        Return units

    End Function

    'Check IF Completed
    Private Function CheckIfCompleted(connect As MySqlConnection) As Boolean

        Dim return_res = False
        Dim submitted_warehouse = String.Empty

        If Equals(lbl_transfer_type.Text, "Distribute") Then
            submitted_warehouse = cbb_destination.Text.Replace("Winland ", String.Empty).Trim 'GetSubmittedWarehouse()
        ElseIf Equals(lbl_transfer_type.Text, "Request") Then
            submitted_warehouse = cbb_source.Text.Replace("Winland ", String.Empty).Trim
        End If


        Try
            Using cmd = New MySqlCommand("SELECT linked_warehouse, delivered_warehouse 
                            FROM ims_stock_transfer 
                            INNER JOIN ims_stock_transfer_sub ON ims_stock_transfer_sub.root_transfer_id=ims_stock_transfer.transfer_id
                            WHERE sub_transfer_id=" & CInt(lbl_transfer_id.Text.Replace("ST", String.Empty)), connect)
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

    'Get 
    Private Function GetSubmittedWarehouse() As String
        Dim submitted_warehouse = String.Empty

        If cbb_destination.Enabled = True Then
            submitted_warehouse = cbb_destination.Text.Replace("Winland ", String.Empty)
        ElseIf cbb_source.Enabled = True Then
            submitted_warehouse = cbb_source.Text.Replace("Winland ", String.Empty)
        End If

        Return submitted_warehouse.Trim

    End Function

    'Get Missing Items for Report
    Private Function GetMissingUnits() As DataTable
        Dim dt = New DataTable
        dt.Columns.Add("pid")
        dt.Columns.Add("winmodel")
        dt.Columns.Add("description")
        dt.Columns.Add("to_receive")
        dt.Columns.Add("delivered")
        dt.Columns.Add("missing")

        For i = 0 To grid_TransferStocks.Rows.Count - 1
            If Not grid_TransferStocks.Rows(i).Cells(3).Value = grid_TransferStocks.Rows(i).Cells(4).Value Then
                dt.Rows.Add(
                    grid_TransferStocks.Rows(i).Cells(0).Value,
                    grid_TransferStocks.Rows(i).Cells(1).Value,
                    grid_TransferStocks.Rows(i).Cells(2).Value,
                    grid_TransferStocks.Rows(i).Cells(3).Value,
                    grid_TransferStocks.Rows(i).Cells(4).Value,
                    grid_TransferStocks.Rows(i).Cells(3).Value - grid_TransferStocks.Rows(i).Cells(4).Value)
            End If
        Next

        Return dt

    End Function

    'Set to DataTable
    Private Sub SetDataTable(units As String, dt As DataTable, warehouse_tbl As String, conn As MySqlConnection)

        Dim comma(), piece, equal() As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        'Clear DataTable
        If dt.Rows.Count > 0 Then dt.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty,
                            (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs,
                            location, location_2
                            FROM ims_inventory 
                            LEFT JOIN " & warehouse_tbl & " AS w_tbl ON w_tbl.pid=ims_inventory.pid
                            WHERE ims_inventory.pid=@pid", conn)
                cmd.Parameters.AddWithValue("@pid", 0)
                cmd.Prepare()

                comma = colonseparator.Split(units)

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    cmd.Parameters("@pid").Value = equal(0)

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            dt.Rows.Add(equal(1).Trim.Replace(";", String.Empty), rdr("qty_per_box"), rdr("masterbox_qty"), rdr("winmodel"), rdr("description"), rdr("location"), rdr("location_2"))
                        End While
                    End Using

                Next

            End Using

        End If

    End Sub







    '--- CONTROLS ---

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        For i = 0 To grid_TransferStocks.Rows.Count - 1
            If String.IsNullOrWhiteSpace(grid_TransferStocks.Rows(i).Cells(4).Value) Then
                MsgBox("Incomplete Records or No Quantity found!", vbCritical, "No Quantity")
                Exit Sub
            End If
        Next

        Dim delivered_warehouse As String = String.Empty
        Select Case lbl_transfer_type.Text
            Case "Distribute" : delivered_warehouse = cbb_destination.Text.Replace("Winland ", String.Empty)
            Case "Request" : delivered_warehouse = cbb_source.Text.Replace("Winland ", String.Empty)
        End Select

        'Start Transfering
        Select Case transfer_func()
            Case "Complete"
                If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then

                    Try
                        Using connect = New MySqlConnection(str)
                            connect.Open()

                            'UPDATE Transfer ID
                            Using cmd = New MySqlCommand("UPDATE ims_stock_transfer
                                            LEFT JOIN ims_stock_transfer_sub ON ims_stock_transfer_sub.root_transfer_id=ims_stock_transfer.transfer_id
                                            SET ims_stock_transfer_sub.received_by=@received_by,
                                            ims_stock_transfer_sub.status='Transferred', date_completed=CURRENT_TIMESTAMP, 
                                            delivered_warehouse=IF(delivered_warehouse='', '" & delivered_warehouse & "', CONCAT(delivered_warehouse, ', ', '" & delivered_warehouse & "')),
                                            ims_stock_transfer.status=IF(" & CheckIfCompleted(connect) & "=True, 'Completed', ims_stock_transfer.status)
                                            WHERE ims_stock_transfer_sub.sub_transfer_id=@id", connect) 'GetSubmittedWarehouse()

                                cmd.Parameters.AddWithValue("@id", CInt(lbl_transfer_id.Text.Replace("ST", String.Empty)))
                                cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                                cmd.ExecuteNonQuery()
                            End Using


                            MsgBox("Success!", vbInformation, "Information")
                            'Dim frm = New frm_warehouse_receivingManagement
                            'frm_main.LoadFrm(frm)
                            'frm.tab_control.SelectedTabPage = frm.tab_stock_transfers
                            Me.Close()
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End If

            Case "Incomplete"
                If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then

                    Try
                        Using connect = New MySqlConnection(str)
                            connect.Open()

                            'UPDATE Transfer ID
                            Using cmd = New MySqlCommand("UPDATE ims_stock_transfer
                                            LEFT JOIN ims_stock_transfer_sub ON ims_stock_transfer_sub.root_transfer_id=ims_stock_transfer.transfer_id
                                            SET ims_stock_transfer_sub.received_by=@received_by,
                                            ims_stock_transfer.status=IF(" & CheckIfCompleted(connect) & "=TRUE, 'Completed', ims_stock_transfer.status),
                                            ims_stock_transfer_sub.status='Transferred', date_completed=CURRENT_TIMESTAMP, 
                                            delivered_warehouse=IF(delivered_warehouse='', '" & delivered_warehouse & "', CONCAT(delivered_warehouse, ', ', '" & delivered_warehouse & "'))
                                            WHERE ims_stock_transfer_sub.sub_transfer_id=@id", connect) 'GetSubmittedWarehouse()

                                cmd.Parameters.AddWithValue("@id", CInt(lbl_transfer_id.Text.Replace("ST", String.Empty)))
                                cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                                cmd.ExecuteNonQuery()
                            End Using


                            MsgBox("Incomplete delivery detected!" & vbCrLf & "You must submit report for investigation.", vbInformation, "Information")

                            Dim frm_report = New frm_warehouse_stocktransfer_report
                            frm_report.ControlBox = False
                            frm_report.txt_stock_transfer_id.Text = lbl_transfer_id.Text
                            frm_report.grid_transfer_report.DataSource = GetMissingUnits()

                            frm_report.txt_source.Text = cbb_source.Text
                            frm_report.txt_destination.Text = cbb_destination.Text

                            'If cbb_destination.Enabled = True Then
                            '    frm_report.txt_source.Text = cbb_source.Text
                            '    frm_report.txt_destination.Text = cbb_destination.Text '"Winland " & GetSubmittedWarehouse()

                            'ElseIf cbb_source.Enabled = True Then
                            '    frm_report.txt_source.Text = "Winland " & GetSubmittedWarehouse()
                            '    frm_report.txt_destination.Text = cbb_destination.Text
                            'End If

                            frm_report.ShowDialog()
                            Me.Close()

                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End If

            Case "Exit" : Exit Sub

        End Select

    End Sub

    'grid_receiver.CellEndEdit
    Private Sub grid_receiver_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_TransferStocks.CellEndEdit

        Dim cell_value = grid_TransferStocks.CurrentCell.Value

        If Not String.IsNullOrWhiteSpace(cell_value) Then
            If Not IsNumeric(cell_value) Then
                MsgBox("Input numbers only!", vbCritical, "Number Format Exception")
                grid_TransferStocks.CurrentCell.Value = String.Empty
            End If

            If cell_value.Contains(".") Then
                MsgBox("Whole numbers only!", vbCritical, "Number Format Exception")
                grid_TransferStocks.CurrentCell.Value = String.Empty
            End If

            If CInt(cell_value) > CInt(grid_TransferStocks.CurrentRow.Cells(3).Value) Or CInt(cell_value) < 0 Then
                MsgBox("Invalid Quantity.", vbCritical, "Invalid")
                grid_TransferStocks.CurrentCell.Value = String.Empty
            End If
        End If

    End Sub

    'Distribute
    Private Sub cbb_destination_SelectionChangeCommitted(sender As Object, e As EventArgs)
        LoadStockTransferDeliveries("destination")
    End Sub

    'Request
    Private Sub cbb_source_SelectionChangeCommitted(sender As Object, e As EventArgs)
        LoadStockTransferDeliveries("source")
    End Sub

    'Complete Delivery
    Private Sub btn_complete_delivery_Click(sender As Object, e As EventArgs) Handles btn_complete_delivery.Click

        If MsgBox("Are you sure all items are delivered?" & vbNewLine & "Press 'YES' to continue.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            Dim source_store = "ims_" & cbb_source.Text.Trim.ToLower.Replace(" ", "_")
            Dim destination_store = "ims_" & cbb_destination.Text.Trim.ToLower.Replace(" ", "_")

            Dim delivered_warehouse As String = String.Empty
            Select Case lbl_transfer_type.Text
                Case "Distribute" : delivered_warehouse = cbb_destination.Text.Replace("Winland ", String.Empty)
                Case "Request" : delivered_warehouse = cbb_source.Text.Replace("Winland ", String.Empty)
            End Select

            Try
                Using connect = New MySqlConnection(str)
                    connect.Open()

                    'Deduct to On-Hold and Add to QTY
                    Using cmd_deduct = New MySqlCommand("UPDATE " & source_store & " SET on_hold=on_hold-@qty WHERE pid=@pid and on_hold>=@qty", connect)
                        cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
                        cmd_deduct.Parameters.AddWithValue("@qty", Nothing)
                        cmd_deduct.Prepare()

                        For i = 0 To grid_TransferStocks.Rows.Count - 1

                            cmd_deduct.Parameters(0).Value = grid_TransferStocks.Rows(i).Cells(0).Value
                            cmd_deduct.Parameters(1).Value = grid_TransferStocks.Rows(i).Cells(3).Value
                            Dim deducted = cmd_deduct.ExecuteNonQuery

                            If deducted > 0 Then
                                Dim cmd_add = New MySqlCommand("INSERT INTO " & destination_store & " (`pid`, `qty`) VALUES (@pid,@qty) ON DUPLICATE KEY UPDATE qty=qty+@qty;
                                        INSERT INTO ims_stock_transfer_logs (original_qty, qty, pid, from_warehouse, to_warehouse, date_received, received_by, transfer_id, subtransfer_id) 
                                        VALUES (@original_qty, @qty, @pid, (SELECT store_id FROM ims_stores WHERE store_name=@from), (SELECT store_id FROM ims_stores WHERE store_name=@to), NOW(), @received_by, @transfer_id, @subtransfer_id )", connect)
                                cmd_add.Parameters.AddWithValue("@pid", grid_TransferStocks.Rows(i).Cells(0).Value)
                                cmd_add.Parameters.AddWithValue("@original_qty", grid_TransferStocks.Rows(i).Cells(3).Value)
                                cmd_add.Parameters.AddWithValue("@qty", grid_TransferStocks.Rows(i).Cells(3).Value)
                                cmd_add.Parameters.AddWithValue("@from", cbb_source.Text.Trim)
                                cmd_add.Parameters.AddWithValue("@to", cbb_destination.Text.Trim)
                                cmd_add.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                                cmd_add.Parameters.AddWithValue("@transfer_id", root_transfer_id)
                                cmd_add.Parameters.AddWithValue("@subtransfer_id", CInt(lbl_transfer_id.Text))
                                cmd_add.ExecuteNonQuery()
                            End If

                        Next
                    End Using

                    'UPDATE Transfer ID
                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer
                                            LEFT JOIN ims_stock_transfer_sub ON ims_stock_transfer_sub.root_transfer_id=ims_stock_transfer.transfer_id
                                            SET ims_stock_transfer_sub.received_by=@received_by,
                                            ims_stock_transfer_sub.status='Transferred', date_completed=CURRENT_TIMESTAMP, 
                                            delivered_warehouse=IF(delivered_warehouse='', '" & delivered_warehouse & "', CONCAT(delivered_warehouse, ', ', '" & delivered_warehouse & "')),
                                            ims_stock_transfer.status=IF(" & CheckIfCompleted(connect) & "=True, 'Completed', ims_stock_transfer.status)
                                            WHERE ims_stock_transfer_sub.sub_transfer_id=@id", connect) 'GetSubmittedWarehouse()

                        cmd.Parameters.AddWithValue("@id", CInt(lbl_transfer_id.Text.Replace("ST", String.Empty)))
                        cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                    MsgBox("Success!", vbInformation, "Information")
                    'Dim frm = New frm_warehouse_receivingManagement
                    'frm_main.LoadFrm(frm)
                    'frm.tabcontrol.SelectedTab = frm.tab_stockTransfer
                    Me.Close()
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    Private Sub btn_print_list_Click(sender As Object, e As EventArgs) Handles btn_print_list.Click
        Dim frm = New frm_warehouse_stocktransfer_dispatch_dialog
        frm.printSubTransfer(lbl_transfer_id.Text, "receive")
    End Sub
End Class