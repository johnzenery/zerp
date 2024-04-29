Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Text.RegularExpressions
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public Class frm_warehouse_start_packing

    Public Property transfer_type As String
    Private store_list As New List(Of String)
    Public type As String = String.Empty


    '--- CONTROLS ----

    'btn_yes
    Private Sub btn_yes_Click(sender As Object, e As EventArgs) Handles btn_yes.Click
        Try

            'IF SALES ORDER
            If lbl_id.Text.Contains("SO") Then
                Dim order_id = CInt(lbl_id.Text.Replace("SO", String.Empty))

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_orders SET status='On-Going' WHERE order_id=" & order_id, connect)
                        If cmd.ExecuteNonQuery() > 0 Then

                            'Print Packing Slip
                            frm_sales_order_new.print_packing_list(order_id)
                            Me.Close()

                        End If
                    End Using
                End Using

                'IF TRANSFER
            ElseIf lbl_id.Text.Contains("SubT-") Then
                Dim sub_transfer_id = CInt(lbl_id.Text.Replace("SubT-", String.Empty))

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer 
                                    SET ims_stock_transfer.status='Arranging' 
                                    WHERE transfer_id=(SELECT root_transfer_id FROM ims_stock_transfer_sub WHERE sub_transfer_id=@sub_transfer_id);
                                    UPDATE ims_stock_transfer_sub SET status='Arranging' WHERE sub_transfer_id=@sub_transfer_id", connect)
                        cmd.Parameters.AddWithValue("@sub_transfer_id", sub_transfer_id)
                        If cmd.ExecuteNonQuery() > 0 Then

                            MsgBox("Arrangement started!", vbInformation, "Information")
                            Me.Close()

                        End If
                    End Using
                End Using

            End If

            If type.Equals("pullout") Then
                Dim batch_id = CInt(lbl_id.Text)

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using trans = connect.BeginTransaction
                        Try
                            'UPDATE BATCH
                            Using cmd = New MySqlCommand($"UPDATE rs_returns_batch SET status='On-Going Arrangement' 
                                                    WHERE batch_id={batch_id}", connect, trans)
                                cmd.ExecuteNonQuery()
                            End Using

                            'UPDATE RETURNS
                            Using cmd = New MySqlCommand($"UPDATE rs_returns 
                                                SET status='On-Going Arrangement' 
                                                WHERE batch_id={batch_id}", connect, trans)
                                cmd.ExecuteNonQuery()
                            End Using

                            trans.Commit()

                            'Print Packing Slip
                            Dim frm = New frm_stock_return_batch
                            frm.PrintBatchPullout(batch_id)

                            MsgBox("Arrangement started!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK
                            Me.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message, vbCritical, "Error")
                        End Try
                    End Using

                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_no
    Private Sub btn_no_Click(sender As Object, e As EventArgs) Handles btn_no.Click
        Me.Close()
    End Sub



    '--- FUNCTION ----


    'Print Transfer Stock - Request Transfers
    Public Sub print_transfer_request(stid As Integer, conn As MySqlConnection)

        Dim report = New doc_sub_transfer()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData
        Dim items As String = String.Empty
        Dim storesInItem() As String = {}
        Dim linkedWarehouse() As String = {}
        Dim store_name = String.Empty, store_info = String.Empty, transfer_id = String.Empty, transfer_type = String.Empty, src_store = String.Empty, transfer_by = String.Empty, approved_by = String.Empty,
            prepared_by = String.Empty, checked_by = String.Empty, released_by = String.Empty, delivered_by = String.Empty

        Try
            'Get Common Values
            Using cmd = New MySqlCommand("SELECT 
                            transfer_id, transfer_type, ims_stores.store_name AS src_store, item, item, linked_warehouse,
                            transBy.first_name AS transfer_by, approvedBy.first_name AS approved_by,                      
                            (SELECT value FROM ims_settings WHERE name='store_name') AS store_name,
                            (SELECT value FROM ims_settings WHERE name='store_info') AS store_info
                            FROM ims_stock_transfer 
                            INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                            LEFT JOIN ims_users AS transBy ON transBy.usr_id=ims_stock_transfer.created_by
                            LEFT JOIN ims_users AS approvedBy ON approvedBy.usr_id=ims_stock_transfer.approved_by
                            WHERE transfer_id=" & stid, conn)

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read

                        linkedWarehouse = rdr("linked_warehouse").ToString.Split(",")
                        items = rdr("item")

                        store_name = rdr("store_name")
                        store_info = rdr("store_info")
                        transfer_id = String.Concat("ST", rdr("transfer_id").ToString.PadLeft(5, "0"c))
                        transfer_type = rdr("transfer_type")
                        src_store = rdr("src_store")

                        transfer_by = rdr("transfer_by")
                        approved_by = IIf(IsDBNull(rdr("approved_by")), String.Empty, rdr("approved_by"))

                    End While
                End Using
            End Using


            'Get Stores/Warehouse
            Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Winland ', '') AS store_name FROM ims_stores", conn)
                Using rdr = cmd.ExecuteReader
                    Dim i = 0
                    store_list.Clear()

                    While rdr.Read
                        store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                    End While
                End Using
            End Using



            For i = 0 To linkedWarehouse.Length - 1

                'Get per Store Values
                Dim ims_storeTable = String.Concat("ims_winland_", linkedWarehouse(i).Trim.Replace(" ", "_").ToLower)
                Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, store_tbl.location,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory
                                    LEFT JOIN " & ims_storeTable & " AS store_tbl ON store_tbl.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", conn)
                    cmd.Parameters.AddWithValue("@pid", 0)
                    cmd.Prepare()

                    'Get linkedWarehouse StoreID via Compare
                    Dim linkedWarehouse_id = 0
                    For Each store As String In store_list
                        Dim StoreArr = store.Split("@")
                        If Equals(linkedWarehouse(i).Trim, StoreArr(1).Trim) Then
                            linkedWarehouse_id = StoreArr(0).Trim
                        End If
                    Next

                    'Create New Report
                    Dim custom_report = New doc_sub_transfer()
                    custom_report.Parameters("destination_store").Value = src_store
                    custom_report.Parameters("store_name").Value = store_name
                    custom_report.Parameters("store_info").Value = store_info
                    custom_report.Parameters("transfer_id").Value = transfer_id
                    custom_report.Parameters("transfer_type").Value = transfer_type
                    custom_report.Parameters("src_store").Value = "Winland " & linkedWarehouse(i)
                    custom_report.Parameters("transfer_by").Value = transfer_by
                    custom_report.Parameters("approved_by").Value = approved_by

                    'Clear Table values
                    Dim total_cbm As Decimal = 0.00
                    Dim total_weight As Decimal = 0.00
                    table.transferred_units.Rows.Clear()

                    Dim row() = items.Split(";")
                    For j = 0 To row.Length - 2
                        Dim cells = row(j).Split("@")

                        'Get product info
                        cmd.Parameters(0).Value = cells(0)

                        'Read info
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read

                                Dim PerStore() = cells(1).Split(",")
                                For k = 0 To PerStore.Length - 1

                                    Dim StoreAndQty = PerStore(k).Split("=")

                                    'Matching linkedID to storeid on cell
                                    If linkedWarehouse_id = CInt(StoreAndQty(0)) Then

                                        'If NOT Zero, Add to table
                                        If Not CInt(StoreAndQty(1)) = 0 Then
                                            table.transferred_units.Rows.Add(StoreAndQty(1), rdr("qty_per_box"), rdr("masterbox_qty"), rdr("winmodel"), rdr("description"), rdr("location"))
                                            total_cbm += rdr("cbm") * StoreAndQty(1)
                                            total_weight += rdr("kgs") * StoreAndQty(1)
                                        End If

                                    End If

                                Next

                            End While
                        End Using

                    Next

                    custom_report.Parameters("total_cubic_meter").Value = total_cbm
                    custom_report.Parameters("total_weight").Value = total_weight
                    custom_report.DataSource = table
                    custom_report.CreateDocument()
                    report.ModifyDocument(Sub(x) x.AddPages(custom_report.Pages))
                End Using
            Next

            report.RequestParameters = False
            report.ShowRibbonPreviewDialog

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Transfer Stock - Distribute Transfer
    Public Sub print_transfer_distribute(stid As Integer, conn As MySqlConnection)

        Dim report = New doc_sub_transfer()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData
        Dim items As String = String.Empty
        Dim storesInItem() As String = {}
        Dim linkedWarehouse() As String = {}
        Dim store_name = String.Empty, store_info = String.Empty, transfer_id = String.Empty, transfer_type = String.Empty, src_store = String.Empty, transfer_by = String.Empty, approved_by = String.Empty,
            prepared_by = String.Empty, checked_by = String.Empty

        Try

            'Get Common Values
            Using cmd = New MySqlCommand("SELECT 
                            transfer_id, transfer_type, ims_stores.store_name AS src_store, item, item, linked_warehouse,
                            CREATED_BY.first_name AS transfer_by, APPROVED_BY.first_name AS approved_by,
                            (SELECT value FROM ims_settings WHERE name='store_name') AS store_name,
                            (SELECT value FROM ims_settings WHERE name='store_info') AS store_info
                            FROM ims_stock_transfer 
                            INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                            LEFT JOIN ims_users AS CREATED_BY ON CREATED_BY.usr_id=ims_stock_transfer.created_by
                            LEFT JOIN ims_users AS APPROVED_BY ON APPROVED_BY.usr_id=ims_stock_transfer.approved_by
                            WHERE transfer_id=" & stid, conn)

                Using rdr = cmd.ExecuteReader()
                    While rdr.Read

                        linkedWarehouse = rdr("linked_warehouse").ToString.Split(",")
                        items = rdr("item")

                        store_name = rdr("store_name")
                        store_info = rdr("store_info")
                        transfer_id = String.Concat("ST", rdr("transfer_id").ToString.PadLeft(5, "0"c))
                        transfer_type = rdr("transfer_type")
                        src_store = rdr("src_store")

                        transfer_by = rdr("transfer_by")
                        approved_by = IIf(IsDBNull(rdr("approved_by")), String.Empty, rdr("approved_by"))

                    End While
                End Using
            End Using


            'Get Stores/Warehouse
            Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Winland ', '') AS store_name FROM ims_stores", conn)
                Using rdr = cmd.ExecuteReader
                    Dim i = 0
                    store_list.Clear()

                    While rdr.Read
                        store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                    End While
                End Using
            End Using



            For i = 0 To linkedWarehouse.Length - 1

                'Get per Store Values
                Dim ims_storeTable = String.Concat("ims_winland_", linkedWarehouse(i).Trim.Replace(" ", "_").ToLower)
                Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, store_tbl.location,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory
                                    LEFT JOIN " & ims_storeTable & " AS store_tbl ON store_tbl.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", conn)
                    cmd.Parameters.AddWithValue("@pid", 0)
                    cmd.Prepare()

                    'Get linkedWarehouse StoreID via Compare
                    Dim linkedWarehouse_id = 0
                    For Each store As String In store_list
                        Dim StoreArr = store.Split("@")
                        If Equals(linkedWarehouse(i).Trim, StoreArr(1).Trim) Then
                            linkedWarehouse_id = StoreArr(0).Trim
                        End If
                    Next

                    'Create New Report
                    Dim custom_report = New doc_sub_transfer()
                    custom_report.Parameters("destination_store").Value = "Winland " & linkedWarehouse(i)
                    custom_report.Parameters("store_name").Value = store_name
                    custom_report.Parameters("store_info").Value = store_info
                    custom_report.Parameters("transfer_id").Value = transfer_id
                    custom_report.Parameters("transfer_type").Value = transfer_type
                    custom_report.Parameters("src_store").Value = src_store
                    custom_report.Parameters("transfer_by").Value = transfer_by
                    custom_report.Parameters("approved_by").Value = approved_by

                    'Clear Table values
                    Dim total_cbm As Decimal = 0.00
                    Dim total_weight As Decimal = 0.00
                    table.transferred_units.Rows.Clear()

                    Dim row() = items.Split(";")
                    For j = 0 To row.Length - 2
                        Dim cells = row(j).Split("@")

                        'Get product info
                        cmd.Parameters(0).Value = cells(0)

                        'Read info
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read

                                Dim PerStore() = cells(1).Split(",")
                                For k = 0 To PerStore.Length - 1

                                    Dim StoreAndQty = PerStore(k).Split("=")

                                    'Matching linkedID to storeid on cell
                                    If linkedWarehouse_id = CInt(StoreAndQty(0)) Then

                                        'If NOT Zero, Add to table
                                        If Not CInt(StoreAndQty(1)) = 0 Then
                                            table.transferred_units.Rows.Add(StoreAndQty(1), rdr("qty_per_box"), rdr("masterbox_qty"), rdr("winmodel"), rdr("description"), rdr("location"))
                                            total_cbm += rdr("cbm") * StoreAndQty(1)
                                            total_weight += rdr("kgs") * StoreAndQty(1)
                                        End If

                                    End If

                                Next

                            End While
                        End Using

                    Next

                    custom_report.Parameters("total_cubic_meter").Value = total_cbm
                    custom_report.Parameters("total_weight").Value = total_weight
                    custom_report.DataSource = table
                    custom_report.CreateDocument()
                    report.ModifyDocument(Sub(x) x.AddPages(custom_report.Pages))
                End Using
            Next

            report.RequestParameters = False
            report.ShowRibbonPreviewDialog

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Packing Slip - Sales Orders
    Private Sub print_packing_list(id As String, connect As MySqlConnection)
        Dim report = New doc_packing_list()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData
        Dim order_id = String.Empty, customer = String.Empty, addr = String.Empty, order_date = String.Empty, orders = String.Empty, priv_notes = String.Empty, agent = String.Empty, trucking = String.Empty, shipping_method = String.Empty

        Try
            Dim query = "SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, ims_orders.priv_note, trucking, shipping_method FROM `ims_orders` 
                            LEFT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            LEFT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'
                            UNION
                         SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, ims_orders.priv_note, trucking, shipping_method FROM `ims_orders` 
                            RIGHT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            RIGHT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'"
            Dim cmd = New MySqlCommand(query, connect)
            rdr = cmd.ExecuteReader

            Using rdr
                rdr.Read()
                order_id = rdr("order_id")
                customer = rdr("customer")
                addr = rdr("ship_to")
                agent = rdr("agent")
                orders = rdr("order_item")
                order_date = rdr("date_ordered")
                priv_notes = rdr("priv_note")
                trucking = rdr("trucking")
                shipping_method = rdr("shipping_method")
            End Using

            data_to_grid(orders, table.packing_list, connect)

            report.Parameters("order_id").Value = order_id
            report.Parameters("customer").Value = customer
            report.Parameters("address").Value = addr
            report.Parameters("agent").Value = agent
            report.Parameters("ordered_date").Value = order_date
            report.Parameters("priv_notes").Value = priv_notes
            report.Parameters("shipping_method").Value = shipping_method
            report.Parameters("trucking").Value = trucking
            report.RequestParameters = False
            report.DataSource = table

            printTool.AutoShowParametersPanel = False
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set Grid Data
    Public Sub data_to_grid(units As String, GridOrTable As DataTable, connect As MySqlConnection)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim location = String.Empty

        If GridOrTable.Rows.Count > 0 Then GridOrTable.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                Dim my_store = "ims_" & frm_main.lbl_user_designation.Text.Trim.Replace(" ", "_").ToLower
                Dim cmd = New MySqlCommand("SELECT location FROM " & my_store & " INNER JOIN ims_inventory ON ims_inventory.pid=" & my_store & " .pid WHERE ims_inventory.winmodel=@model", connect)
                cmd.Parameters.AddWithValue("@store", my_store)
                cmd.Parameters.AddWithValue("@model", equal(1))
                location = cmd.ExecuteScalar()

                GridOrTable.Rows.Add(equal(0), equal(1), equal(2), location)

            Next

            GridOrTable.DefaultView.Sort = "model ASC"

        End If

    End Sub

End Class