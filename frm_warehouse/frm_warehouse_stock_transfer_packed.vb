Imports MySqlConnector
Imports System.Globalization.CultureInfo

Public Class frm_warehouse_stock_transfer_packed

    Private store_list As New List(Of String)

    '--- ONLOAD ---
    Private Sub frm_warehouse_packagemgmt_packed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub




    '--- CONTROLS ---

    'btn_packed
    Private Sub btn_packed_Click(sender As Object, e As EventArgs) Handles btn_packed.Click

        If txt_status.Text.Equals("Arranging") Then

            'Validation
            If String.IsNullOrEmpty(txt_prepared_by.Text) Or String.IsNullOrEmpty(txt_packed_by.Text) Then
                MsgBox("Complete all fields!", vbCritical, "Error")
                Exit Sub
            End If

            If MsgBox("Press 'Yes' to confirm.", vbInformation + vbYesNo, "Confirmation") = vbYes Then
                Try
                    Using conn = New MySqlConnection(str)
                        conn.Open()
                        Dim sub_transfer_id As Integer = txt_sub_transfer_id.Text.Replace("SubT-", String.Empty)

                        'Check and Set to On-Hold stock
                        If sub_transfer_function(sub_transfer_id, conn) = True Then

                            Dim cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub
                                    SET checked_by=@organized_by, prepared_by=@prepared_by, packed_by=@packed_by, date_packed=CURRENT_TIMESTAMP, status='Packed'
                                    WHERE sub_transfer_id=" & sub_transfer_id, conn)

                            cmd.Parameters.AddWithValue("@prepared_by", CurrentCulture.TextInfo.ToTitleCase(txt_prepared_by.Text.Trim))
                            cmd.Parameters.AddWithValue("@packed_by", CurrentCulture.TextInfo.ToTitleCase(txt_packed_by.Text.Trim))
                            cmd.Parameters.AddWithValue("@organized_by", frm_main.lbl_user_name.Text)

                            If cmd.ExecuteNonQuery() > 0 Then
                                MsgBox("Successfully tag as 'PACKED'!", vbInformation, "Information")
                                Me.Close()
                            End If

                        End If

                    End Using

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If


        ElseIf txt_status.Text.Equals("Pending Cancellation") Then

            If MsgBox("Press 'Yes' to confirm.", vbInformation + vbYesNo, "Confirmation") = vbYes Then
                Try
                    Using conn = New MySqlConnection(str)
                        conn.Open()
                        Dim sub_transfer_id As Integer = txt_sub_transfer_id.Text.Replace("SubT-", String.Empty)

                        'Unhold
                        sub_transfer_unhold(sub_transfer_id, conn)

                        'Update
                        Dim cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub
                                    SET status='Cancelled'
                                    WHERE sub_transfer_id=" & sub_transfer_id, conn)

                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("UNPACKED!", vbInformation, "Information")
                            Me.Close()
                        End If

                    End Using

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If

        End If
    End Sub






    '--- FUNCTIONS ---

    'Sub Transfer - Transfer Function
    Private Function sub_transfer_function(sub_transfer_id As Integer, connect As MySqlConnection)

        Dim src_store_tbl = String.Empty
        Dim low_stocks_level = String.Empty
        Dim items = String.Empty

        Using cmd = New MySqlCommand("SELECT item, SRC.store_name AS src_store_name
                                            FROM ims_stock_transfer_sub
                                            INNER JOIN ims_stores SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                            INNER JOIN ims_stores RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id 
                                            WHERE sub_transfer_id=" & sub_transfer_id, connect)
            Using rdr = cmd.ExecuteReader
                While rdr.Read
                    src_store_tbl = "ims_" & rdr("src_store_name").ToString.ToLower.Replace(" ", "_")
                    items = rdr("item")
                End While
            End Using
        End Using

        Using cmd_check = New MySqlCommand("SELECT IFNULL(src_store.qty,0) AS qty, winmodel
                                    FROM ims_inventory
                                    LEFT JOIN " & src_store_tbl & " AS src_store ON src_store.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", connect)
            cmd_check.Parameters.AddWithValue("@pid", 0)
            cmd_check.Prepare()

            Dim rows = items.Split(";")
            For i = 0 To rows.Length - 1
                Dim cells = rows(i).Split("=")
                cmd_check.Parameters(0).Value = cells(0)

                Using rdr = cmd_check.ExecuteReader
                    While rdr.Read

                        'Check Current stocks to Stocks in Transfer Order
                        If cells(1) > CInt(rdr("qty")) Then
                            low_stocks_level += String.Concat(vbNewLine, rdr("winmodel"))
                        End If

                    End While
                End Using

            Next
        End Using

        'DEDUCT IF Stock Level is SUFFICIENT
        If String.IsNullOrEmpty(low_stocks_level) Then

            'Deduct to Qty AND Put to on_hold
            Dim cmd_deduct = New MySqlCommand("UPDATE " & src_store_tbl & " SET qty=qty-@qty, on_hold=IFNULL(on_hold, 0)+@qty WHERE pid=@pid and qty>=@qty", connect)
            cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
            cmd_deduct.Parameters.AddWithValue("@qty", Nothing)
            cmd_deduct.Prepare()

            Dim rows = items.Split(";")
            For i = 0 To rows.Length - 1
                Dim cells = rows(i).Split("=")

                'Set Value to Parameters
                cmd_deduct.Parameters(0).Value = cells(0) 'PID
                cmd_deduct.Parameters(1).Value = cells(1) 'QTY
                cmd_deduct.ExecuteNonQuery()

            Next

        Else
            MsgBox("Couldn't proceed due to Low Stock level!" & vbCrLf & vbCrLf & "Items with low stock level:" & low_stocks_level, vbCritical, "Low Level Stocks")
            Return False
        End If

        Return True

    End Function

    'Sub Transfer - Unhold Function
    Private Sub sub_transfer_unhold(sub_transfer_id As Integer, connect As MySqlConnection)

        Dim src_store_tbl = String.Empty
        Dim items = String.Empty

        'Get Items and Source Store
        Using cmd = New MySqlCommand("SELECT item, SRC.store_name AS src_store_name
                                            FROM ims_stock_transfer_sub
                                            INNER JOIN ims_stores SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                                            INNER JOIN ims_stores RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id 
                                            WHERE sub_transfer_id=" & sub_transfer_id, connect)
            Using rdr = cmd.ExecuteReader
                While rdr.Read
                    src_store_tbl = "ims_" & rdr("src_store_name").ToString.ToLower.Replace(" ", "_")
                    items = rdr("item")
                End While
            End Using
        End Using


        'Unhold QTY
        Using cmd_deduct = New MySqlCommand("UPDATE " & src_store_tbl & " SET qty=qty+@onhold_qty, on_hold=IFNULL(on_hold, 0)-@onhold_qty WHERE pid=@pid and on_hold>=@onhold_qty", connect)
            cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
            cmd_deduct.Parameters.AddWithValue("@onhold_qty", Nothing)
            cmd_deduct.Prepare()

            Dim rows = items.Split(";")
            For i = 0 To rows.Length - 1
                Dim cells = rows(i).Split("=")

                'Set Value to Parameters
                cmd_deduct.Parameters(0).Value = cells(0) 'PID
                cmd_deduct.Parameters(1).Value = cells(1) 'QTY
                cmd_deduct.ExecuteNonQuery()

            Next
        End Using

    End Sub





    'Transfer Function
    Private Function transfer_func(id As Integer, connect As MySqlConnection)

        Dim source_store = String.Empty
        Dim units = String.Empty
        Dim transfer_type = String.Empty

        Try

            Using cmd_getStoreAndItem = New MySqlCommand("SELECT ims_stores.store_name as src_store, item, transfer_type
                                FROM ims_stock_transfer
                                INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                                WHERE transfer_id=" & id, connect)
                Using rdr = cmd_getStoreAndItem.ExecuteReader
                    While rdr.Read
                        source_store = "ims_" & rdr("src_store").ToString.ToLower.Replace(" ", "_")
                        units = rdr("item").ToString.Trim
                        transfer_type = rdr("transfer_type")
                    End While
                End Using
            End Using


            'Checking Stocks Availability & Deduct
            If transfer_type.Equals("Distribute") Then
                'Check
                If check_stocks_distribute(source_store, units, connect) Then
                    Return True
                End If
                'Deduct
                deduct_stock_distribute(source_store, units, connect)

            ElseIf transfer_type.Equals("Request") Then
                'Check
                If check_stocks_request(units, connect) Then
                    Return True
                End If
                'Deduct
                deduct_stock_request(units, connect)

            End If

            Return False

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function

    'Check Stock's Availability - Distribute
    Private Function check_stocks_distribute(source_store As String, units As String, connect As MySqlConnection)

        Dim low_stocks_level = String.Empty

        Using cmd_check = New MySqlCommand("SELECT IFNULL(store.qty,0) AS qty, winmodel
                                    FROM ims_inventory
                                    LEFT JOIN " & source_store & " AS store ON store.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", connect)
            cmd_check.Parameters.AddWithValue("@pid", 0)
            cmd_check.Prepare()

            Dim rows = units.Split(";")
            For i = 0 To rows.Length - 2
                Dim cells = rows(i).Split("@")

                cmd_check.Parameters(0).Value = cells(0)
                Using rdr = cmd_check.ExecuteReader
                    While rdr.Read

                        'Slice to Per Warehouse
                        Dim PerStore() = cells(1).Split(",")
                        Dim total_qty = 0

                        'Get SUM of Qty
                        For j = 0 To PerStore.Length - 1
                            Dim StoreAndQty = PerStore(j).Split("=")
                            total_qty += StoreAndQty(1)
                        Next

                        'Check Current stocks to Stocks in Transfer Order
                        If total_qty > CInt(rdr("qty")) Then
                            low_stocks_level += String.Concat(vbNewLine, rdr("winmodel"))
                        End If

                    End While
                End Using
            Next

        End Using

        If Not String.IsNullOrEmpty(low_stocks_level) Then
            MsgBox("Couldn't proceed due to Low Stock level!" & vbCrLf & vbCrLf & "Items with low stock level:" & low_stocks_level, vbCritical, "Low Level Stocks")
            Return True
        End If

        Return False

    End Function

    'Check Stock's Availability - Request
    Private Function check_stocks_request(units As String, connect As MySqlConnection)

        Dim low_stocks_level = String.Empty

        Dim rows = units.Split(";")
        For i = 0 To rows.Length - 2

            'Slice PID and StoreAndQty
            Dim cells = rows(i).Split("@")

            'Slice to Per Warehouse
            Dim PerStore() = cells(1).Split(",")

            'Get SUM of Qty
            For j = 0 To PerStore.Length - 1

                Dim warehouse_name = String.Empty
                Dim tbl_warehouse = String.Empty
                Dim StoreAndQty = PerStore(j).Split("=")

                'Get Warehouse table name
                Using cmd_getStore = New MySqlCommand("SELECT store_name FROM ims_stores WHERE store_id=" & StoreAndQty(0).Trim, connect)
                    warehouse_name = cmd_getStore.ExecuteScalar()
                    tbl_warehouse = String.Concat("ims_", warehouse_name.Replace(" ", "_").ToLower())
                End Using

                'Get Value from Database
                Using cmd_check = New MySqlCommand("SELECT IFNULL(store.qty,0) AS qty, winmodel
                                    FROM ims_inventory
                                    LEFT JOIN " & tbl_warehouse & " AS store ON store.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", connect)
                    cmd_check.Parameters.AddWithValue("@pid", cells(0))

                    Using rdr = cmd_check.ExecuteReader
                        While rdr.Read()

                            'Check Current stocks to Stocks in Transfer Order
                            If StoreAndQty(1) > CInt(rdr("qty")) Then
                                If Not low_stocks_level.Contains(rdr("winmodel")) Then
                                    low_stocks_level += String.Concat(vbNewLine, rdr("winmodel"), " @ ", warehouse_name)
                                End If
                            End If

                        End While
                    End Using
                End Using

            Next

        Next


        If Not String.IsNullOrEmpty(low_stocks_level) Then
            MsgBox("Couldn't proceed due to Low Stock level!" & vbCrLf & vbCrLf & "Items with low stock level:" & low_stocks_level, vbCritical, "Low Level Stocks")
            Return True
        End If

        Return False

    End Function

    'Deduct Stock - Distribute
    Private Sub deduct_stock_distribute(source_store As String, units As String, connect As MySqlConnection)

        'Deduct to Qty AND Put to on_hold
        Dim cmd_deduct = New MySqlCommand("UPDATE " & source_store & " SET qty=qty-@qty, on_hold=IFNULL(on_hold, 0)+@qty WHERE pid=@pid and qty>=@qty", connect)
        cmd_deduct.Parameters.AddWithValue("@pid", Nothing)
        cmd_deduct.Parameters.AddWithValue("@qty", Nothing)
        cmd_deduct.Prepare()


        Dim rows = units.Split(";")
        For i = 0 To rows.Length - 2

            'Declare Values
            Dim total_qty = 0

            'Split PID to PerStores
            Dim cells = rows(i).Split("@")

            'Slice PerStores to Per Store
            Dim PerStore() = cells(1).Split(",")

            'Get SUM of Qty
            For j = 0 To PerStore.Length - 1
                Dim StoreAndQty = PerStore(j).Split("=")
                total_qty += StoreAndQty(1)
            Next

            'Set Value to Parameters
            cmd_deduct.Parameters(0).Value = cells(0)  'PID
            cmd_deduct.Parameters(1).Value = total_qty 'QTY
            cmd_deduct.ExecuteNonQuery()

        Next
    End Sub

    'Deduct Stock - Request
    Private Sub deduct_stock_request(units As String, connect As MySqlConnection)

        Dim rows = units.Split(";")
        For i = 0 To rows.Length - 2

            'Slice PID and StoreAndQty
            Dim cells = rows(i).Split("@")

            'Slice to Per Warehouse
            Dim PerStore() = cells(1).Split(",")

            'Get SUM of Qty
            For j = 0 To PerStore.Length - 1

                Dim tbl_warehouse = String.Empty
                Dim StoreAndQty = PerStore(j).Split("=")

                'Get Warehouse table name
                Using cmd_getStore = New MySqlCommand("SELECT store_name FROM ims_stores WHERE store_id=" & StoreAndQty(0).Trim, connect)
                    tbl_warehouse = String.Concat("ims_", cmd_getStore.ExecuteScalar().Replace(" ", "_").ToLower())
                End Using

                'Deduct to Qty AND Put to on_hold
                Dim cmd_deduct = New MySqlCommand("UPDATE " & tbl_warehouse & " SET qty=qty-@qty, on_hold=IFNULL(on_hold, 0)+@qty WHERE pid=@pid and qty>=@qty", connect)
                cmd_deduct.Parameters.AddWithValue("@pid", cells(0))
                cmd_deduct.Parameters.AddWithValue("@qty", StoreAndQty(1))
                cmd_deduct.ExecuteNonQuery()

            Next

        Next

    End Sub


End Class
