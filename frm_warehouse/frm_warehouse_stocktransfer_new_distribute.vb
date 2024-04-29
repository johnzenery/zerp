Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.IO

Public Class frm_warehouse_stocktransfer_new_distribute

    'Declarations
    Private store_list As New List(Of String)
    Private dt As DataTable
    Private model_AutoCompleteString As New AutoCompleteStringCollection
    Private description_AutoCompleteString As New AutoCompleteStringCollection
    Private CountedStores As String
    Private total_cbm As Decimal
    Private total_kgs As Decimal

    '--- ONLOAD ---
    Private Sub frm_warehouse_stocktransfer_distribute_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub



    '--- FUNCTIONS ----
    'INITIALIZE
    Private Sub Initialize()
        'Me.Size = frm_main.Size
        CreateDataTable()
        LoadWarehouses()
        btn_import.Location = btn_print.Location


        'CREATE DROPDOWN BUTTON ITEMS | "Save as Draft" && "Submit for Approval"
        If PopupMenu_button.ItemLinks.Count = 0 Then
            Dim btn_SaveAsDraft = New BarButtonItem(barmanager_btn, "Save as Draft")
            btn_SaveAsDraft.Tag = "save_as_draft"
            AddHandler btn_SaveAsDraft.ItemClick, AddressOf btn_SaveAsDraft_ItemClick

            Dim btn_SubmitForApproval = New BarButtonItem(barmanager_btn, "Submit for Approval")
            btn_SubmitForApproval.Tag = "submit_for_approval"
            AddHandler btn_SubmitForApproval.ItemClick, AddressOf btn_SubmitForApproval_ItemClick

            PopupMenu_button.AddItem(btn_SaveAsDraft)
            PopupMenu_button.AddItem(btn_SubmitForApproval)

        Else
            Dim btn_SaveOnly = New BarButtonItem(barmanager_btn, "Save")
            btn_SaveOnly.Tag = "save_only"
            AddHandler btn_SaveOnly.ItemClick, AddressOf btn_SaveOnly_ItemClick

            Dim btn_UpdateForApproval = New BarButtonItem(barmanager_btn, "Submit for Approval")
            btn_UpdateForApproval.Tag = "update_for_approval"
            AddHandler btn_UpdateForApproval.ItemClick, AddressOf btn_UpdateForApproval_ItemClick

            PopupMenu_button.AddItem(btn_SaveOnly)
            PopupMenu_button.AddItem(btn_UpdateForApproval)
            PopupMenu_button.ItemLinks.Item(0).Visible = False
            PopupMenu_button.ItemLinks.Item(1).Visible = False

        End If


    End Sub

    'Create DataTable
    Private Sub CreateDataTable()
        If dt Is Nothing Then
            dt = New DataTable
            dt.Columns.Add("pid", GetType(Integer))
            dt.Columns.Add("winmodel", GetType(String))
            dt.Columns.Add("description", GetType(String))
            dt.Columns.Add("masterbox_qty", GetType(Integer))
            dt.Columns.Add("qty_per_box", GetType(Integer))
            dt.Columns.Add("qty", GetType(Decimal))
            dt.Columns.Add("cbm", GetType(Decimal))
            dt.Columns.Add("kgs", GetType(Decimal))
        End If
    End Sub

    'Load Warehouses
    Private Sub LoadWarehouses()
        If cbb_src_warehouse.Properties.Items.Count = 0 Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT * FROM ims_stores", conn)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                cbb_src_warehouse.Properties.Items.Add(rdr("store_name"))
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                model_AutoCompleteString.Clear()
                description_AutoCompleteString.Clear()
                Dim warehouse = String.Concat("ims_", cbb_src_warehouse.Text.Replace(" ", "_").ToLower)

                Using cmd = New MySqlCommand("SELECT winmodel, description FROM ims_inventory 
                                            LEFT JOIN " & warehouse & " ON " & warehouse & ".pid=ims_inventory.pid", conn)
                    Using rdr As MySqlDataReader = cmd.ExecuteReader
                        While rdr.Read
                            model_AutoCompleteString.Add(rdr("winmodel"))
                            description_AutoCompleteString.Add(rdr("description"))
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Get Store together with Values
    Private Function GetValues()
        Dim StoreOverQty As String = String.Empty
        CountedStores = String.Empty
        total_cbm = 0.00
        total_kgs = 0.00

        Dim dt = DirectCast(grid_distribute_stock.DataSource, DataTable)

        For i = 0 To dt.Rows.Count - 1

            StoreOverQty += dt.Rows(i).Item(0) & "@"      'Start with PID

            For j = 8 To dt.Columns.Count - 1

                'If No Value RETURN FALSE
                If IsDBNull(dt.Rows(i).Item(j)) Then
                    Return "False"
                End If

                'Get Column index of Current Cell
                'Dim ColumnIndex = dt.Rows(i).Item(j).ColumnIndex

                For Each store As String In store_list
                    Dim StoreArr = store.Split("@")

                    'Compare Columns & Getting Values
                    If Equals(StoreArr(1).Trim, dt.Columns(j).ColumnName.Replace("Winland ", String.Empty).Trim) Then

                        'No comma at first & put comma before value
                        If Not j = 8 Then StoreOverQty += ","

                        'Get Value
                        StoreOverQty += StoreArr(0).Trim & "=" & dt.Rows(i).Item(j)

                        'Add to Counted Stores
                        If Not CountedStores.Contains(dt.Columns(j).ColumnName.Replace("Winland ", String.Empty).Trim) _
                                                            And Not dt.Rows(i).Item(j) = 0 Then
                            If String.IsNullOrEmpty(CountedStores) Then
                                CountedStores += dt.Columns(j).ColumnName.Replace("Winland ", String.Empty).Trim
                            Else
                                CountedStores += ", " & dt.Columns(j).ColumnName.Replace("Winland ", String.Empty).Trim
                            End If
                        End If

                    End If
                Next

                'Get Total CBM and KG
                total_cbm += dt.Rows(i).Item(j) * dt.Rows(i).Item(6) '(qty * CBM)
                total_kgs += dt.Rows(i).Item(j) * dt.Rows(i).Item(7) '(qty * kgs)
            Next

            'End with comma
            StoreOverQty += ";"

        Next

        Return StoreOverQty

    End Function

    'Set Item to Grid
    Private Sub SetToGrid(items As String)
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                'Declare Value
                Dim warehouse_tbl = "ims_" & cbb_src_warehouse.Text.Replace(" ", "_").ToLower

                'Get Stores/Warehouse
                Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Parsell ', '') AS store_name FROM ims_stores", connection)
                    Using rdr = cmd.ExecuteReader
                        Dim i = 0
                        store_list.Clear()

                        While rdr.Read
                            store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                        End While
                    End Using
                End Using

                'Retrieving and Setting Value
                Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, IFNULL(inv.qty, 0) AS qty,
                                     (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory 
                                    INNER JOIN " & warehouse_tbl & " AS inv ON inv.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", connection)
                    cmd.Parameters.AddWithValue("@pid", 0)
                    cmd.Prepare()

                    Dim row() = items.Split(";")
                    For i = 0 To row.Length - 2
                        Dim cells = row(i).Split("@")
                        cmd.Parameters(0).Value = cells(0)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read

                                With dt.Rows.Add(
                                    rdr("pid"),
                                    rdr("winmodel"),
                                    rdr("description"),
                                    rdr("masterbox_qty"),
                                    rdr("qty_per_box"),
                                    rdr("qty"),
                                    rdr("cbm"),
                                    rdr("kgs"))
                                End With

                                Dim PerStore() = cells(1).Split(",")
                                For j = 0 To PerStore.Length - 1

                                    Dim StoreAndQty = PerStore(j).Split("=")

                                    For Each store As String In store_list
                                        Dim StoreArr = store.Split("@")
                                        If Equals(StoreArr(0).Trim, StoreAndQty(0)) Then
                                            grid_distribute_stock.Rows(i).Cells(StoreArr(1).Trim).Value = StoreAndQty(1)
                                        End If
                                    Next

                                Next

                            End While
                        End Using
                    Next

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Edit
    Public Sub LoadEdit(stid As Integer)

        'Show
        btn_import.Visible = False
        lbl_created_by.Visible = True
        lbl_status.Visible = True
        btn_print.Visible = True
        btn_delete.Visible = True
        btn_create.Visible = False
        'btn_save.Location = btn_create.Location
        'btn_save.Visible = True
        btn_arrange.Visible = True
        cbb_src_warehouse.ReadOnly = True

        Me.Text = "Edit Stock Transfer - ST" & stid.ToString.PadLeft(5, "0"c)
        lbl_title.Text = "Edit Stock Transfer - Distribute"

        Initialize()
        Me.WindowState = FormWindowState.Normal

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT concat('ST',LPAD(transfer_id,5,0)) AS transfer_id, status, created_at, item, public_note,
                                    transfer_type, ims_stores.store_name AS  src_warehouse, ims_users.first_name AS created_by 
                                    FROM ims_stock_transfer  
                                    INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                                    INNER JOIN ims_users ON ims_users.usr_id=ims_stock_transfer.created_by
                                    WHERE transfer_id=" & stid, conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            txt_stid.Text = rdr("transfer_id")
                            cbb_src_warehouse.Text = rdr("src_warehouse")
                            lbl_status.Text = rdr("status")
                            txt_note.Text = rdr("public_note")

                            Select Case rdr("status")
                                Case "Approved"
                                    btn_arrange.Enabled = True
                                Case "Pending for Arrangement"
                                    btn_arrange.Text = "Pending"
                                    btn_save.Enabled = False
                                    btn_delete.Enabled = False
                                Case "Arranging"
                                    btn_arrange.Text = "Arranging"
                                    btn_arrange.Enabled = False
                                    btn_save.Enabled = False
                                    btn_delete.Enabled = False
                                Case "Ready for Delivery"
                                    btn_arrange.Text = "Arranged"
                                Case "Dispatched", "Completed"
                            End Select

                            lbl_created_by.Text = String.Concat("Created by ", rdr("created_by"), " at ", CDate(rdr("created_at")).ToString("MM/dd/yyyy"))
                            SetToGrid(rdr("item"))
                            SetTotals()
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Transfer Stock - Distribute
    Public Sub print_transfer_distribute(stid As String)

        Dim report = New doc_sub_transfer()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData
        Dim items As String = String.Empty
        Dim storesInItem() As String = {}
        Dim linkedWarehouse() As String = {}
        Dim store_name = String.Empty, store_info = String.Empty, transfer_id = String.Empty, transfer_type = String.Empty, src_store = String.Empty, transfer_by = String.Empty, approved_by = String.Empty,
            prepared_by = String.Empty, checked_by = String.Empty, released_by = String.Empty, delivered_by = String.Empty, status = String.Empty
        Dim transfer_date As Date

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'Get Common Values
                Using cmd = New MySqlCommand("SELECT 
                            transfer_id, transfer_type, ims_stores.store_name AS src_store, item, linked_warehouse,
                            CREATED_BY.first_name AS created_by, APPROVED_BY.first_name AS approved_by, status, created_at,
                            (SELECT value FROM ims_settings WHERE name='store_name') AS store_name,
                            (SELECT value FROM ims_settings WHERE name='store_info') AS store_info
                            FROM ims_stock_transfer 
                            INNER JOIN ims_stores ON ims_stores.store_id=ims_stock_transfer.src_store_id
                            LEFT JOIN ims_users AS CREATED_BY ON CREATED_BY.usr_id=ims_stock_transfer.created_by
                            LEFT JOIN ims_users AS APPROVED_BY ON APPROVED_BY.usr_id=ims_stock_transfer.approved_by
                            WHERE transfer_id=" & CInt(stid.Replace("ST", String.Empty)), conn)

                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read

                            linkedWarehouse = rdr("linked_warehouse").ToString.Split(",")
                            items = rdr("item")

                            store_name = rdr("store_name")
                            store_info = rdr("store_info")
                            transfer_id = String.Concat("ST", rdr("transfer_id").ToString.PadLeft(5, "0"c))
                            transfer_type = rdr("transfer_type")
                            transfer_date = rdr("created_at")
                            src_store = rdr("src_store")
                            status = rdr("status")

                            transfer_by = rdr("created_by")
                            approved_by = IIf(IsDBNull(rdr("approved_by")), String.Empty, rdr("approved_by"))

                        End While
                    End Using
                End Using


                'Get Stores/Warehouse
                Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Parsell ', '') AS store_name FROM ims_stores", conn)
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
                    Dim ims_storeTable = String.Concat("ims_parsell_", linkedWarehouse(i).Trim.Replace(" ", "_").ToLower)
                    Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, store_tbl.location, store_tbl.location_2,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs, unit
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
                        custom_report.Parameters("transfer_date").Value = transfer_date
                        custom_report.Parameters("src_store").Value = src_store
                        custom_report.Parameters("transfer_by").Value = transfer_by
                        custom_report.Parameters("approved_by").Value = approved_by
                        custom_report.Parameters("prepared_by").Value = prepared_by
                        custom_report.Parameters("checked_by").Value = checked_by
                        custom_report.Parameters("released_by").Value = released_by
                        custom_report.Parameters("delivered_by").Value = delivered_by
                        custom_report.Parameters("status").Value = "[ " & status.ToUpper & " ]"
                        custom_report.lbl_subtransfer_id.Visible = False
                        custom_report.val_subtransfer_id.Visible = False

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
                                                table.transferred_units.Rows.Add(StoreAndQty(1), rdr("qty_per_box"), rdr("masterbox_qty"), rdr("winmodel"), rdr("description"), rdr("location"), rdr("location_2"), rdr("unit"))
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

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Total CBM and KGS to Label
    Private Sub SetTotals()
        total_cbm = 0
        total_kgs = 0
        For i = 0 To grid_distribute_stock.Rows.Count - 1
            For j = 8 To grid_distribute_stock.Columns.Count - 1
                'Get Total CBM and KG
                total_cbm += grid_distribute_stock.Rows(i).Cells(6).Value * IIf(IsDBNull(grid_distribute_stock.Rows(i).Cells(j).Value), 0, grid_distribute_stock.Rows(i).Cells(j).Value)
                total_kgs += grid_distribute_stock.Rows(i).Cells(7).Value * IIf(IsDBNull(grid_distribute_stock.Rows(i).Cells(j).Value), 0, grid_distribute_stock.Rows(i).Cells(j).Value)
            Next
        Next
        lbl_total_cbm.Text = FormatNumber(total_cbm, 2) & " m³"
        lbl_total_kgs.Text = FormatNumber(total_kgs, 2) & " Kg"
    End Sub

    'Insert to ims_stock_transfer_sub
    Public Sub insert_to_subtransfer(stid As String, conn As MySqlConnection)


        'Get Stores/Warehouse
        Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Parsell ', '') AS store_name FROM ims_stores", conn)
            Using rdr = cmd.ExecuteReader
                Dim i = 0
                store_list.Clear()

                While rdr.Read
                    store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                End While
            End Using
        End Using


        'Declaration
        Dim linkedWarehouse() As String = {}
        Dim transfer_id = 0, transfer_type = String.Empty, src_store_id = String.Empty, items = String.Empty

        Using cmd = New MySqlCommand("SELECT transfer_id, transfer_type, src_store_id, item, linked_warehouse 
                        FROM ims_stock_transfer
                        WHERE transfer_id=" & stid, conn)

            Using rdr = cmd.ExecuteReader
                While rdr.Read

                    linkedWarehouse = rdr("linked_warehouse").ToString.Split(",")
                    items = rdr("item")
                    transfer_id = rdr("transfer_id")
                    transfer_type = rdr("transfer_type")
                    src_store_id = rdr("src_store_id")

                End While
            End Using

        End Using

        '---- INSERTING to Sub Transfer per Warehouse
        For i = 0 To linkedWarehouse.Length - 1

            'Get linkedWarehouse StoreID via Compare
            Dim linkedWarehouse_ID = 0
            For Each store As String In store_list
                Dim StoreArr = store.Split("@")
                If Equals(linkedWarehouse(i).Trim, StoreArr(1).Trim) Then
                    linkedWarehouse_ID = StoreArr(0).Trim
                End If
            Next

            'Insert to ims_stock_transfer_sub
            Using cmd_insert = New MySqlCommand("INSERT INTO ims_stock_transfer_sub 
                                                (root_transfer_id, transfer_type, src_store_id, recvr_store_id, item, status, total_cbm, total_kgs, released_by, date_released)
                                         VALUES (@root_transfer_id, @transfer_type, @src_store_id, @recvr_store_id, @item, @status, @total_cbm, @total_kgs, @released_by, @date_released)", conn)
                cmd_insert.Parameters.AddWithValue("@root_transfer_id", transfer_id)
                cmd_insert.Parameters.AddWithValue("@transfer_type", transfer_type)

                Select Case transfer_type
                    Case "Distribute"
                        cmd_insert.Parameters.AddWithValue("@src_store_id", src_store_id)
                        cmd_insert.Parameters.AddWithValue("@recvr_store_id", linkedWarehouse_ID)
                    Case "Request"
                        cmd_insert.Parameters.AddWithValue("@src_store_id", linkedWarehouse_ID)
                        cmd_insert.Parameters.AddWithValue("@recvr_store_id", src_store_id)
                End Select

                cmd_insert.Parameters.AddWithValue("@item", String.Empty)
                cmd_insert.Parameters.AddWithValue("@status", "Pending for Arrangement")
                cmd_insert.Parameters.AddWithValue("@total_cbm", 0.00)
                cmd_insert.Parameters.AddWithValue("@total_kgs", 0.00)
                cmd_insert.Parameters.AddWithValue("@released_by", 0)
                cmd_insert.Parameters.AddWithValue("@date_released", Date.Now)
                cmd_insert.Prepare()

                'Clear Values
                Dim item_to_insert = String.Empty
                Dim total_cbm As Decimal = 0.00
                Dim total_weight As Decimal = 0.00

                Dim row() = items.Split(";")
                For j = 0 To row.Length - 2
                    Dim cells = row(j).Split("@")

                    Dim PerStore() = cells(1).Split(",")
                    For k = 0 To PerStore.Length - 1

                        Dim StoreAndQty = PerStore(k).Split("=")

                        'Matching linkedID to storeid on cell
                        If linkedWarehouse_ID = CInt(StoreAndQty(0)) Then

                            'If NOT Zero, Add to table
                            If Not CInt(StoreAndQty(1)) = 0 Then

                                'Add up CBM & KGS
                                total_cbm += GetCBM(cells(0), conn) * StoreAndQty(1)
                                total_weight += GetKGS(cells(0), conn) * StoreAndQty(1)

                                If String.IsNullOrEmpty(item_to_insert) Then
                                    item_to_insert += cells(0) & "=" & StoreAndQty(1)
                                    Continue For
                                End If

                                item_to_insert += ";" & cells(0) & "=" & StoreAndQty(1)

                            End If

                        End If

                    Next

                Next

                cmd_insert.Parameters("@total_cbm").Value = total_cbm
                cmd_insert.Parameters("@total_kgs").Value = total_weight
                cmd_insert.Parameters("@item").Value = item_to_insert
                cmd_insert.ExecuteNonQuery()

            End Using

        Next

    End Sub

    'Update DropDown Button
    Private Sub UpdateDropDownButton(ByVal submenuItem As BarItem)
        dropdown_btn.Text = submenuItem.Caption
        dropdown_btn.Tag = submenuItem.Tag
    End Sub

    'FOR APPROVAL
    Private Sub Submit_for_Approval(typeOfapproval As String)

        If MsgBox("Submit for Approval?", vbYesNo + vbQuestion, "Confirmation") = MsgBoxResult.Yes Then

            Try
                Using connect = New MySqlConnection(str)
                    connect.Open()

                    'Get Stores/Warehouse
                    Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Parsell ', '') AS store_name FROM ims_stores", connect)
                        Using rdr = cmd.ExecuteReader
                            Dim i = 0
                            store_list.Clear()

                            While rdr.Read
                                store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                            End While
                        End Using
                    End Using

                    'Get Value determine if has error
                    Dim items As String = GetValues()
                    If Equals(items, "False") Then
                        MsgBox("All cells MUST have a value!", vbExclamation, "Forbidden")
                        Return
                    End If

                    'Define type of Approval
                    If typeOfapproval.Equals("insert") Then

                        Using cmd = New MySqlCommand("INSERT INTO ims_stock_transfer (transfer_type, src_store_id, item, status, total_cbm, total_kgs, linked_warehouse, created_by, public_note, created_at)
                                VALUES ('Distribute', (SELECT store_id FROM ims_stores WHERE store_name=@src_store), @item, 'For Approval', @total_cbm, @total_kgs, @linked_warehouse, @created_by, @public_note, NOW())", connect)
                            cmd.Parameters.AddWithValue("@src_store", cbb_src_warehouse.Text)
                            cmd.Parameters.AddWithValue("@item", items)
                            cmd.Parameters.AddWithValue("@total_cbm", total_cbm)
                            cmd.Parameters.AddWithValue("@total_kgs", total_kgs)
                            cmd.Parameters.AddWithValue("@linked_warehouse", CountedStores)
                            cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@public_note", txt_note.Text.Trim)

                            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
                                If cmd.ExecuteNonQuery > 0 Then
                                    Me.Close()
                                    MsgBox("Successfully Added!", vbInformation, "Information")
                                End If
                            End If

                        End Using

                    ElseIf typeOfapproval.Equals("update") Then
                        Using cmd = New MySqlCommand("UPDATE ims_stock_transfer SET item=@item, status=@status, total_cbm=@total_cbm, total_kgs=@total_kgs, linked_warehouse=@linked_warehouse, public_note=@public_note WHERE transfer_id=@stid", connect)
                            cmd.Parameters.AddWithValue("@stid", CInt(txt_stid.Text.Replace("ST", String.Empty)))
                            cmd.Parameters.AddWithValue("@item", items)
                            cmd.Parameters.AddWithValue("@total_cbm", total_cbm)
                            cmd.Parameters.AddWithValue("@total_kgs", total_kgs)
                            cmd.Parameters.AddWithValue("@linked_warehouse", CountedStores)
                            cmd.Parameters.AddWithValue("@status", IIf(lbl_status.Text.Equals("Dispatched"), "Dispatched", "For Approval"))
                            cmd.Parameters.AddWithValue("@public_note", txt_note.Text.Trim)

                            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
                                If cmd.ExecuteNonQuery > 0 Then
                                    Me.Close()
                                    MsgBox("Saved Successfully!", vbInformation, "Information")
                                End If
                            End If

                        End Using

                    End If

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'SAVE AS DRAFT
    Private Sub Save_as_Draft()

        If MsgBox("Save as Draft?", vbYesNo + vbQuestion, "Confirmation") = MsgBoxResult.Yes Then

            Try
                Using connect = New MySqlConnection(str)
                    connect.Open()

                    'Get Stores/Warehouse
                    Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Parsell ', '') AS store_name FROM ims_stores", connect)
                        Using rdr = cmd.ExecuteReader
                            Dim i = 0
                            store_list.Clear()

                            While rdr.Read
                                store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                            End While
                        End Using
                    End Using

                    'Get Value determine if has error
                    Dim items As String = GetValues()
                    If Equals(items, "False") Then
                        MsgBox("All cells MUST have a value!", vbExclamation, "Forbidden")
                        Return
                    End If

                    Using cmd = New MySqlCommand("INSERT INTO ims_stock_transfer (transfer_type, src_store_id, item, status, total_cbm, total_kgs, linked_warehouse, created_by, public_note, created_at)
                                VALUES ('Distribute', (SELECT store_id FROM ims_stores WHERE store_name=@src_store), @item, 'Draft', @total_cbm, @total_kgs, @linked_warehouse, @created_by, @public_note, NOW())", connect)
                        cmd.Parameters.AddWithValue("@src_store", cbb_src_warehouse.Text)
                        cmd.Parameters.AddWithValue("@item", items)
                        cmd.Parameters.AddWithValue("@total_cbm", total_cbm)
                        cmd.Parameters.AddWithValue("@total_kgs", total_kgs)
                        cmd.Parameters.AddWithValue("@linked_warehouse", CountedStores)
                        cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@public_note", txt_note.Text.Trim)

                        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
                            If cmd.ExecuteNonQuery > 0 Then
                                Me.Close()
                                MsgBox("Successfully Added!", vbInformation, "Information")
                            End If
                        End If

                    End Using

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'Save Only
    Private Sub Save_Only()

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                'Get Stores/Warehouse
                Using cmd = New MySqlCommand("SELECT store_id, REPLACE(store_name, 'Parsell ', '') AS store_name FROM ims_stores", connect)
                    Using rdr = cmd.ExecuteReader
                        Dim i = 0
                        store_list.Clear()

                        While rdr.Read
                            store_list.Add(rdr("store_id") & " @ " & rdr("store_name"))
                        End While
                    End Using
                End Using

                'Get Value determine if has error
                Dim items As String = GetValues()
                If Equals(items, "False") Then
                    MsgBox("All cells MUST have a value!", vbExclamation, "Forbidden")
                    Return
                End If

                Using cmd = New MySqlCommand("UPDATE ims_stock_transfer SET item=@item, total_cbm=@total_cbm, total_kgs=@total_kgs, linked_warehouse=@linked_warehouse, public_note=@public_note WHERE transfer_id=@stid", connect)
                    cmd.Parameters.AddWithValue("@stid", CInt(txt_stid.Text.Replace("ST", String.Empty)))
                    cmd.Parameters.AddWithValue("@item", items)
                    cmd.Parameters.AddWithValue("@total_cbm", total_cbm)
                    cmd.Parameters.AddWithValue("@total_kgs", total_kgs)
                    cmd.Parameters.AddWithValue("@linked_warehouse", CountedStores)
                    'cmd.Parameters.AddWithValue("@status", "") 'IIf(lbl_status.Text.Equals("Dispatched"), "Dispatched", "For Approval")
                    cmd.Parameters.AddWithValue("@public_note", txt_note.Text.Trim)

                    If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
                        If cmd.ExecuteNonQuery > 0 Then
                            Me.Close()
                            MsgBox("Saved Successfully!", vbInformation, "Information")
                        End If
                    End If

                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub




    '--- CONTROLS & EVENTS ----

    'cbb_src_warehouse_EditValueChanged
    Private Sub cbb_src_warehouse_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_src_warehouse.EditValueChanged
        Try
            Dim selected_warehouse = cbb_src_warehouse.Text.Replace(" ", "_").ToLower

            'Add Warehouse Columns except Source
            For i = 0 To cbb_src_warehouse.Properties.Items.Count - 1
                'Skip if EXIST
                If dt.Columns.Contains(cbb_src_warehouse.Properties.Items(i).Replace("Winland ", String.Empty)) Then
                    Continue For
                End If
                'Add Warehouse IF NOT EXIST
                dt.Columns.Add(cbb_src_warehouse.Properties.Items(i).Replace("Winland ", String.Empty), GetType(Decimal))

            Next

            'Remove Currently Selected
            dt.Columns.Remove(cbb_src_warehouse.Text.Replace("Winland ", String.Empty))

            'Assign to Datasource
            grid_distribute_stock.DataSource = dt

            'Set Grid Display
            For i = 8 To grid_distribute_stock.Columns.Count - 1
                grid_distribute_stock.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                grid_distribute_stock.Columns(i).Width = 100
            Next
            'Load Models and Descriptions
            Load_AutoCompleteString()

            'Enable Grid 
            grid_distribute_stock.Enabled = True

        Catch ex As Exception
            MsgBox(ex.InnerException, vbCritical, "Error")
        End Try
    End Sub

    'EditingControl
    Private Sub grid_distribute_stock_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_distribute_stock.EditingControlShowing

        If Not (grid_distribute_stock.CurrentCell.ColumnIndex = 1 Or grid_distribute_stock.CurrentCell.ColumnIndex = 2) Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = TryCast(e.Control, TextBox)

            If grid_distribute_stock.CurrentCell.ColumnIndex = 1 Then

                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = model_AutoCompleteString
                    txt.CharacterCasing = CharacterCasing.Upper
                End If

            ElseIf grid_distribute_stock.CurrentCell.ColumnIndex = 2 Then
                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = description_AutoCompleteString
                End If
            End If

        End If

    End Sub

    'CellEndEdit
    Private Sub grid_distribute_stock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_distribute_stock.CellEndEdit
        If Not String.IsNullOrEmpty(cbb_src_warehouse.Text) Then
            'IF MODEL
            If e.ColumnIndex.Equals(1) Then
                If Not IsDBNull(grid_distribute_stock.CurrentCell.Value) Then

                    'CHECK IF ALREADY EXIST
                    For i = 0 To grid_distribute_stock.Rows.Count - 1
                        'Skip if Current Row
                        If i = grid_distribute_stock.CurrentRow.Index Then Continue For

                        'Compare & throw if 
                        If Equals(grid_distribute_stock.CurrentCell.Value, grid_distribute_stock.Rows(i).Cells(1).Value) Then
                            MsgBox("Warning! Item Already Exist.", vbExclamation, "Duplicate Entry")
                        End If
                    Next

                    'GET AND SET
                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Dim warehouse_tbl = "ims_" & cbb_src_warehouse.Text.Replace(" ", "_").ToLower
                            Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, inv.qty,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory 
                                    INNER JOIN " & warehouse_tbl & " AS inv ON inv.pid=ims_inventory.pid
                                    WHERE ims_inventory.winmodel=@winmodel", conn)
                                cmd.Parameters.AddWithValue("@winmodel", grid_distribute_stock.CurrentCell.Value)

                                Using rdr As MySqlDataReader = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        While rdr.Read

                                            'SET VALUE to grid_order
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(0).Value = rdr("pid")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(3).Value = rdr("masterbox_qty")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(4).Value = rdr("qty_per_box")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(5).Value = rdr("qty")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(6).Value = rdr("cbm")
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(7).Value = rdr("kgs")

                                            For i = 8 To grid_distribute_stock.Columns.Count - 1
                                                grid_distribute_stock.Rows(e.RowIndex).Cells(i).Value = 0
                                            Next

                                        End While
                                    Else
                                        MsgBox("Selected item couldn't found!", vbCritical, "Not Found")
                                        For i = 0 To grid_distribute_stock.Columns.Count - 1
                                            grid_distribute_stock.Rows(e.RowIndex).Cells(i).Value = DBNull.Value
                                        Next
                                        Return
                                    End If
                                End Using

                            End Using
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                Else
                    Return
                End If

            ElseIf e.ColumnIndex > 8 Then


                'Get Total of Distributed Stocks
                Dim total_distributed = 0
                For i = 8 To grid_distribute_stock.Columns.Count - 1
                    total_distributed += IIf(IsDBNull(grid_distribute_stock.Rows(e.RowIndex).Cells(i).Value), 0, grid_distribute_stock.Rows(e.RowIndex).Cells(i).Value)
                Next

                'Validation for Qty must not higher than Stocks
                If Not IsDBNull(grid_distribute_stock.CurrentCell.Value) Then
                    If total_distributed > grid_distribute_stock.Rows(e.RowIndex).Cells(5).Value Then
                        MsgBox("Total quantity of distributed MUST NOT higher than 'Stock Source Qty'!", vbExclamation, "Insufficent Stock")
                        grid_distribute_stock.CurrentCell.Value = DBNull.Value
                        Exit Sub
                    End If
                End If


            End If

            'Get Total CBM and KGS
            SetTotals()

        End If
    End Sub

    'IF NUMBER FORMART ERROR
    Private Sub grid_distribute_stock_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grid_distribute_stock.DataError
        If e.Context.ToString.Contains("Parsing") Then
            MsgBox("Incorrect Number Format!", vbCritical, "Incorrect Format")
        End If
    End Sub

    'btn_create
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Submit_for_Approval("insert")
    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Save_Only()
    End Sub

    'When ROWS ADDED
    Private Sub grid_distribute_stock_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles grid_distribute_stock.RowsAdded
        If grid_distribute_stock.Rows.Count > 1 Then
            cbb_src_warehouse.Enabled = False
            btn_create.Enabled = True
        End If
    End Sub

    'When ROWS DELETED
    Private Sub grid_distribute_stock_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_distribute_stock.RowsRemoved
        If grid_distribute_stock.Rows.Count = 1 Then
            cbb_src_warehouse.Enabled = True
            btn_create.Enabled = False
        End If
    End Sub

    'btn_delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Delete this Stock Transfer?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer SET is_deleted=1
                                    WHERE transfer_id=@stid", conn)
                        cmd.Parameters.AddWithValue("@stid", CInt(txt_stid.Text.Replace("ST", String.Empty)))
                        cmd.ExecuteNonQuery()
                        Me.Close()
                        MsgBox("Deleted!", vbInformation, "Information")
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'Delete Row upon Pressing Del Button
    Private Sub grid_request_stock_KeyUp(sender As Object, e As KeyEventArgs) Handles grid_distribute_stock.KeyUp
        If grid_distribute_stock.RowCount > 1 Then
            If e.KeyCode = Keys.Delete Then
                grid_distribute_stock.Rows.RemoveAt(grid_distribute_stock.CurrentCell.RowIndex)
            End If
        End If
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        print_transfer_distribute(txt_stid.Text)
    End Sub

    'btn_arrange
    Private Sub btn_arrange_Click(sender As Object, e As EventArgs) Handles btn_arrange.Click

        If MsgBox("Ready to arrange?" & Environment.NewLine & "WARNING: You can't edit it anymore!", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Dim transfer_id = CInt(txt_stid.Text.Replace("ST", String.Empty))

            Try
                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer 
                                SET status='Pending for Arrangement' WHERE transfer_id=" & transfer_id, connect)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Sent to Package Dept!", vbInformation, "Information")

                            'Dissolve into Sub Transfers
                            insert_to_subtransfer(transfer_id, connect)

                            Me.Close()

                        End If
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'btn_approved
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click

        Dim frm = New frm_warehouse_stocktransfer_approval_dialog
        frm.lbl_stock_transfer_id.Text = txt_stid.Text

        Dim DialogResult = frm.ShowDialog()
        If DialogResult = DialogResult.Yes Or DialogResult = DialogResult.No Then

            Try
                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Dim transfer_id = CInt(txt_stid.Text.Replace("ST", String.Empty))
                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer SET public_note=@public_note WHERE transfer_id=" & transfer_id, connect)
                        cmd.Parameters.AddWithValue("@public_note", txt_note.Text.Trim)
                        If cmd.ExecuteNonQuery > 0 Then
                            Me.Close()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'btn_import
    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click

        'cbb Supplier Validation
        If cbb_src_warehouse.SelectedIndex = -1 Then
            MsgBox("Select source warehouse first!.", vbCritical, "Required")
            Return
        End If

        Dim openFileDialog = New OpenFileDialog() With
          {
             .Title = "Open File Dialog",
             .Filter = "CSV file (*.csv)|*.csv",
             .RestoreDirectory = True,
             .FilterIndex = 2
          }

        If openFileDialog.ShowDialog() = DialogResult.OK AndAlso MsgBox("Click 'Yes' to continue.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            Try
                'Declarations
                Dim csvData As String = File.ReadAllText(openFileDialog.FileName)
                Dim dataSource = DirectCast(grid_distribute_stock.DataSource, DataTable)
                Dim not_found_unit = String.Empty, duplicates = String.Empty

                For Each row As String In csvData.Split(ControlChars.Lf)

                    'If EMPTY
                    If String.IsNullOrEmpty(row) Then Continue For

                    'SPLIT ROW VALUES
                    Dim values = row.Split(","c)

                    'SKIP ROW IF EMPTY
                    If String.IsNullOrWhiteSpace(values(0)) Or String.IsNullOrWhiteSpace(values(1)) Then Continue For

                    'VALIDATE IF DUPLICATE
                    Dim is_duplicate = False
                    For Each dt_row As DataRow In dataSource.Rows
                        If dt_row.Item("winmodel") = values(1).Trim Then
                            is_duplicate = True
                            duplicates = String.Concat(duplicates, Environment.NewLine, values(1).Trim)
                        End If
                    Next
                    If is_duplicate Then Continue For

                    'GET AND SET
                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()

                            Dim warehouse_tbl = "ims_" & cbb_src_warehouse.Text.Replace(" ", "_").ToLower
                            Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, inv.qty,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory 
                                    INNER JOIN " & warehouse_tbl & " AS inv ON inv.pid=ims_inventory.pid
                                    WHERE ims_inventory.winmodel=@winmodel", conn)
                                cmd.Parameters.AddWithValue("@winmodel", values(1).Trim)

                                Using rdr As MySqlDataReader = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        While rdr.Read

                                            'SET VALUE to grid_order
                                            dataSource.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), rdr("masterbox_qty"), rdr("qty_per_box"), rdr("qty"), rdr("cbm"), rdr("kgs"))

                                            For i = 8 To grid_distribute_stock.Columns.Count - 1
                                                dataSource.Rows(dataSource.Rows.Count - 1).Item(i) = 0
                                            Next

                                        End While
                                    Else
                                        not_found_unit += values(1) & vbNewLine
                                    End If
                                End Using

                            End Using
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                Next

                grid_distribute_stock.DataSource = dataSource

                'Set Totals
                SetTotals()

                'IF Duplicate in Import
                If Not String.IsNullOrWhiteSpace(duplicates) Then
                    MsgBox(String.Concat("Duplicate item(s) from import detected!", Environment.NewLine, duplicates), vbExclamation, "Import")
                End If

                'IF Has Error or Not Active
                If Not String.IsNullOrEmpty(not_found_unit) Then
                    MsgBox(String.Concat("Couldn't import item(s) below:", not_found_unit), vbExclamation, "Failed")
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'Search
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim dt = DirectCast(grid_distribute_stock.DataSource, DataTable)
        Dim dataViews As DataView = New DataView(dt)
        dt.DefaultView.RowFilter = String.Concat(New String() {"winmodel LIKE '%", Me.txt_search.Text.Trim(), "%' OR description LIKE '%", Me.txt_search.Text.Trim(), "%'"})
        grid_distribute_stock.DataSource = dt
    End Sub

    'DropDownButton : Save as Draft
    Private Sub btn_SaveAsDraft_ItemClick(sender As Object, e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Save_as_Draft()
    End Sub

    'DropDownButton : Submit for Approval
    Private Sub btn_SubmitForApproval_ItemClick(sender As Object, e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Submit_for_Approval("insert")
    End Sub

    'DropDownButton : Save Only
    Private Sub btn_SaveOnly_ItemClick(sender As Object, e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Save_Only()
    End Sub

    'DropDownButton : Update for Approval
    Private Sub btn_UpdateForApproval_ItemClick(sender As Object, e As ItemClickEventArgs)
        UpdateDropDownButton(e.Item)
        Submit_for_Approval("update")
    End Sub

    'DropDownButton
    Private Sub dropdown_btn_Click(sender As Object, e As EventArgs) Handles dropdown_btn.Click

        If Not TryCast(sender, DropDownButton).Tag = Nothing Then
            Dim tag As String = TryCast(sender, DropDownButton).Tag.ToString()

            If tag = "save_as_draft" Then Save_as_Draft()
            If tag = "submit_for_approval" Then Submit_for_Approval("insert")
            If tag = "save_only" Then Save_Only()
            If tag = "update_for_approval" Then Submit_for_Approval("update")

        End If


    End Sub

End Class