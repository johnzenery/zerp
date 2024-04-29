Imports DevExpress.XtraBars
Imports DevExpress.XtraEditors
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.IO

Public Class frm_warehouse_stocktransfer_new_request

    'Declarations
    Private store_list As New List(Of String)
    Private dt As DataTable
    Private model_AutoCompleteString As New AutoCompleteStringCollection
    Private description_AutoCompleteString As New AutoCompleteStringCollection
    Private CountedStores As String
    Private total_cbm As Decimal
    Private total_kgs As Decimal

    '--- ONLOAD --- 
    Private Sub frm_warehouse_stocktransfer_request_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialized()
    End Sub



    '--- FUNCTIONS ----

    'INITIALIZED
    Private Sub Initialized()
        Me.Size = frm_main.Size
        CreateDataTable()
        LoadWarehouses()
        btn_import.Location = btn_print.Location

        'Set Grid Display
        grid_request_stock.Columns(5).HeaderCell.Style.BackColor = Color.FromArgb(255, 255, 192)
        grid_request_stock.Columns(6).HeaderCell.Style.BackColor = Color.FromArgb(255, 255, 192)
        grid_request_stock.Columns(7).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Italic)
        grid_request_stock.Columns(8).HeaderCell.Style.Font = New Font("Microsoft Sans Serif", 9, FontStyle.Italic)


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

    'Update DropDown Button
    Private Sub UpdateDropDownButton(ByVal submenuItem As BarItem)
        dropdown_btn.Text = submenuItem.Caption
        dropdown_btn.Tag = submenuItem.Tag
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
            dt.Columns.Add("qty_needed", GetType(Decimal))
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
                    Using cmd = New MySqlCommand("Select * FROM ims_stores", conn)
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

                Using cmd = New MySqlCommand("Select winmodel, description FROM ims_inventory 
                                            Left JOIN " & warehouse & " ON " & warehouse & ".pid=ims_inventory.pid", conn)
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

        Dim dt = DirectCast(grid_request_stock.DataSource, DataTable)

        For i = 0 To dt.Rows.Count - 1

            StoreOverQty += dt.Rows(i).Item(0) & "@"     'Start with PID

            For j = 9 To dt.Columns.Count - 2

                For Each store As String In store_list
                    Dim StoreArr = store.Split("@")

                    'Compare Columns & Getting Values
                    If Equals(StoreArr(1).Trim, dt.Columns(j).ColumnName.Trim) Then

                        'If No Value RETURN FALSE
                        If IsDBNull(dt.Rows(i).Item(j + 1)) Then
                            Return "False"
                        End If

                        'No comma at first & put comma before value
                        If Not j = 9 Then StoreOverQty += ","

                        'Get Value
                        StoreOverQty += StoreArr(0).Trim & "=" & dt.Rows(i).Item(j + 1)

                        'Add to Counted Stores
                        If Not CountedStores.Contains(dt.Columns(j).ColumnName.Trim) _
                                                            And Not dt.Rows(i).Item(j + 1) = 0 Then
                            If String.IsNullOrEmpty(CountedStores) Then
                                CountedStores += dt.Columns(j).ColumnName.Trim
                            Else
                                CountedStores += ", " & dt.Columns(j).ColumnName.Trim
                            End If

                        End If

                    End If
                Next

            Next

            'End with comma
            StoreOverQty += ";"

            'Get Total CBM and KG
            total_cbm += dt.Rows(i).Item(6) * dt.Rows(i).Item(7)
            total_kgs += dt.Rows(i).Item(6) * dt.Rows(i).Item(8)

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
                Dim left_join = String.Empty
                Dim StoreQuery = String.Empty


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


                'Query Table
                For i = 0 To cbb_src_warehouse.Properties.Items.Count - 1

                    Dim store = "ims_" & cbb_src_warehouse.Properties.Items(i).ToString.Replace(" ", "_").ToLower
                    Dim store_tblName = cbb_src_warehouse.Properties.Items(i).Replace("Winland ", String.Empty)

                    StoreQuery += "IFNULL(" & store & ".qty, 0) AS '" & store_tblName & "', "
                    left_join += "LEFT JOIN " & store & " ON " & store & ".pid=ims_inventory.pid "
                Next


                'Retrieving and Setting Value
                Using cmd = New MySqlCommand("SELECT " & StoreQuery & " ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, IFNULL(inv.qty, 0) AS qty,
                                     (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory 
                                    " & left_join & "
                                    LEFT JOIN " & warehouse_tbl & " AS inv ON inv.pid=ims_inventory.pid
                                    WHERE ims_inventory.pid=@pid", connection)
                    cmd.Parameters.AddWithValue("@pid", 0)
                    cmd.Prepare()

                    Dim row() = items.Split(";")
                    For i = 0 To row.Length - 2
                        Dim cells = row(i).Split("@")
                        cmd.Parameters(0).Value = cells(0)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                Dim output As Integer = rdr("cbm")
                                With dt.Rows.Add(
                                    rdr("pid"),
                                    rdr("winmodel"),
                                    rdr("description"),
                                    rdr("masterbox_qty"),
                                    rdr("qty_per_box"),
                                    0,
                                    0,
                                    rdr("cbm"),
                                    rdr("kgs"))
                                End With

                                Dim PerStore() = cells(1).Split(",")
                                For j = 0 To PerStore.Length - 1

                                    Dim StoreAndQty = PerStore(j).Split("=")

                                    For Each store As String In store_list
                                        Dim StoreArr = store.Split("@")
                                        If Equals(StoreArr(0).Trim, StoreAndQty(0)) Then
                                            grid_request_stock.Rows(i).Cells(StoreArr(1).Trim).Value = IIf(rdr(StoreArr(1).Trim) Mod 1 = 0, CInt(rdr(StoreArr(1).Trim)), rdr(StoreArr(1).Trim))
                                            grid_request_stock.Rows(i).Cells("RE: " & StoreArr(1).Trim).Value = StoreAndQty(1)
                                        End If
                                    Next

                                Next

                            End While
                        End Using

                        'Get Total Requested Stock
                        For j = 9 To grid_request_stock.Columns.Count - 1
                            If j Mod 2 = 0 Then
                                grid_request_stock.Rows(i).Cells(6).Value += grid_request_stock.Rows(i).Cells(j).Value
                            End If
                        Next

                    Next

                    'HIDE QTY. NEEDED
                    grid_request_stock.Columns(5).Visible = False

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
        lbl_title.Text = "Edit Stock Transfer - Request"

        Initialized()
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
                                Case "Approved" : btn_arrange.Enabled = True
                                Case "Pending for Arrangement"
                                    btn_arrange.Text = "Pending"
                                    btn_save.Enabled = False
                                Case "Arranging"
                                    btn_arrange.Text = "Arranging"
                                    btn_arrange.Enabled = False
                                    btn_save.Enabled = False
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

    'Print Transfer Stock - Request
    Public Sub print_transfer_request(stid As String)

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
                        custom_report.Parameters("destination_store").Value = src_store
                        custom_report.Parameters("store_name").Value = store_name
                        custom_report.Parameters("store_info").Value = store_info
                        custom_report.Parameters("transfer_id").Value = transfer_id
                        custom_report.Parameters("transfer_type").Value = transfer_type
                        custom_report.Parameters("transfer_date").Value = transfer_date
                        custom_report.Parameters("src_store").Value = "Winland " & linkedWarehouse(i)
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
        For i = 0 To grid_request_stock.Rows.Count - 1
            For j = 9 To grid_request_stock.Columns.Count - 1
                If j Mod 2 > 0 Then
                    total_cbm += grid_request_stock.Rows(i).Cells(7).Value * IIf(IsDBNull(grid_request_stock.Rows(i).Cells(j).Value), 0, grid_request_stock.Rows(i).Cells(j).Value)
                    total_kgs += grid_request_stock.Rows(i).Cells(8).Value * IIf(IsDBNull(grid_request_stock.Rows(i).Cells(j).Value), 0, grid_request_stock.Rows(i).Cells(j).Value)
                End If
            Next
        Next
        lbl_total_cbm.Text = FormatNumber(total_cbm, 2) & " m³"
        lbl_total_kgs.Text = FormatNumber(total_kgs, 2) & " Kg"
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
                                VALUES ('Request', (SELECT store_id FROM ims_stores WHERE store_name=@src_store), @item, 'Draft', @total_cbm, @total_kgs, @linked_warehouse, @created_by, @public_note, NOW())", connect)
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
                                VALUES ('Request', (SELECT store_id FROM ims_stores WHERE store_name=@src_store), @item, 'For Approval', @total_cbm, @total_kgs, @linked_warehouse, @created_by, @public_note, NOW())", connect)
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
                    'cmd.Parameters.AddWithValue("@status", IIf(lbl_status.Text.Equals("Dispatched"), "Dispatched", "For Approval"))
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
    Private Sub cbb_src_warehouse_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_src_warehouse.SelectedValueChanged
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
                dt.Columns.Add("RE: " & cbb_src_warehouse.Properties.Items(i).Replace("Winland ", String.Empty), GetType(Decimal))
            Next

            'Remove Currently Selected
            dt.Columns.Remove(cbb_src_warehouse.Text.Replace("Winland ", String.Empty))
            dt.Columns.Remove("RE: " & cbb_src_warehouse.Text.Replace("Winland ", String.Empty))

            'Assign to Datasource
            grid_request_stock.DataSource = dt

            For i = 9 To grid_request_stock.Columns.Count - 1
                grid_request_stock.Columns(i).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                grid_request_stock.Columns(i).Width = 100
                If i Mod 2 = 1 Then
                    grid_request_stock.Columns(i).HeaderCell.Style.BackColor = Color.AntiqueWhite
                    grid_request_stock.Columns(i).DefaultCellStyle.BackColor = Color.AntiqueWhite
                    grid_request_stock.Columns(i).ReadOnly = True
                Else
                    grid_request_stock.Columns(i).HeaderCell.Style.ForeColor = Color.Red
                End If
            Next

            'Load Models and Descriptions
            Load_AutoCompleteString()

            'Enable Grid 
            grid_request_stock.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'EditingControl
    Private Sub grid_request_stock_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_request_stock.EditingControlShowing

        If Not (grid_request_stock.CurrentCell.ColumnIndex = 1 Or grid_request_stock.CurrentCell.ColumnIndex = 2) Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = TryCast(e.Control, TextBox)

            If grid_request_stock.CurrentCell.ColumnIndex = 1 Then

                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = model_AutoCompleteString
                    txt.CharacterCasing = CharacterCasing.Upper
                End If

            ElseIf grid_request_stock.CurrentCell.ColumnIndex = 2 Then
                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = description_AutoCompleteString
                End If
            End If

        End If

    End Sub

    'CellEndEdit
    Private Sub grid_request_stock_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_request_stock.CellEndEdit
        If Not String.IsNullOrEmpty(cbb_src_warehouse.Text) Then
            'IF MODEL
            If e.ColumnIndex.Equals(1) Then
                If Not IsDBNull(grid_request_stock.CurrentCell.Value) Then

                    'CHECK IF ALREADY EXIST
                    For i = 0 To grid_request_stock.Rows.Count - 1
                        'Skip if Current Row
                        If i = grid_request_stock.CurrentRow.Index Then Continue For

                        'Compare & throw if 
                        If Equals(grid_request_stock.CurrentCell.Value, grid_request_stock.Rows(i).Cells(1).Value) Then
                            MsgBox("Warning! Item Already Exist.", vbExclamation, "Duplicate Entry")
                        End If
                    Next

                    'GET AND SET
                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Dim warehouse_tbl = "ims_" & cbb_src_warehouse.Text.Replace(" ", "_").ToLower
                            Dim left_join = String.Empty
                            Dim StoreQuery = String.Empty

                            'Query Table
                            For i = 0 To cbb_src_warehouse.Properties.Items.Count - 1

                                Dim store = "ims_" & cbb_src_warehouse.Properties.Items(i).ToString.Replace(" ", "_").ToLower
                                Dim store_tblName = cbb_src_warehouse.Properties.Items(i).Replace("Winland ", String.Empty)

                                StoreQuery += "IFNULL(" & store & ".qty, 0) AS '" & store_tblName & "', "
                                left_join += "LEFT JOIN " & store & " ON " & store & ".pid=ims_inventory.pid "
                            Next

                            Using cmd = New MySqlCommand("SELECT " & StoreQuery & " ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, inv.qty,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory 
                                    " & left_join & "
                                    LEFT JOIN " & warehouse_tbl & " AS inv ON inv.pid=ims_inventory.pid
                                    WHERE ims_inventory.winmodel=@winmodel", conn)
                                cmd.Parameters.AddWithValue("@winmodel", grid_request_stock.CurrentCell.Value)

                                Using rdr As MySqlDataReader = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        While rdr.Read

                                            'SET VALUE to grid_order
                                            grid_request_stock.Rows(e.RowIndex).Cells(0).Value = rdr("pid")
                                            grid_request_stock.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel")
                                            grid_request_stock.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                                            grid_request_stock.Rows(e.RowIndex).Cells(3).Value = rdr("masterbox_qty")
                                            grid_request_stock.Rows(e.RowIndex).Cells(4).Value = rdr("qty_per_box")
                                            grid_request_stock.Rows(e.RowIndex).Cells(5).Value = 0
                                            grid_request_stock.Rows(e.RowIndex).Cells(6).Value = 0
                                            grid_request_stock.Rows(e.RowIndex).Cells(7).Value = rdr("cbm")
                                            grid_request_stock.Rows(e.RowIndex).Cells(8).Value = rdr("kgs")

                                            For i = 9 To grid_request_stock.Columns.Count - 1
                                                grid_request_stock.Rows(e.RowIndex).Cells(i).Value = 0
                                            Next

                                            For Each store As String In cbb_src_warehouse.Properties.Items
                                                Dim StoreArr = store.Replace("Winland ", String.Empty).Trim

                                                For i = 9 To grid_request_stock.Columns.Count - 1
                                                    If Equals(StoreArr.Trim, grid_request_stock.Columns(i).Name.ToString.Trim) Then
                                                        grid_request_stock.Rows(e.RowIndex).Cells(i).Value = IIf(rdr(StoreArr) Mod 1 = 0, CInt(rdr(StoreArr)), rdr(StoreArr))
                                                    End If
                                                Next
                                            Next

                                        End While
                                    Else
                                        MsgBox("Selected item couldn't found!", vbCritical, "Not Found")
                                        For i = 0 To grid_request_stock.Columns.Count - 1
                                            grid_request_stock.Rows(e.RowIndex).Cells(i).Value = DBNull.Value
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

                'Validation for Qty must not higher than Stocks
                If Not IsDBNull(grid_request_stock.CurrentCell.Value) Then
                    If grid_request_stock.Rows(e.RowIndex).Cells(e.ColumnIndex).Value > grid_request_stock.Rows(e.RowIndex).Cells(e.ColumnIndex - 1).Value Then
                        MsgBox("Must NOT higher than warehouse stocks!", vbExclamation, "Insufficent Stock")
                        grid_request_stock.CurrentCell.Value = DBNull.Value
                        Exit Sub
                    End If
                End If

                'Get Total of Requested Stocks
                grid_request_stock.Rows(e.RowIndex).Cells(6).Value = 0
                For i = 9 To grid_request_stock.Columns.Count - 1
                    If i Mod 2 = 0 Then
                        grid_request_stock.Rows(e.RowIndex).Cells(6).Value += IIf(IsDBNull(grid_request_stock.Rows(e.RowIndex).Cells(i).Value), 0, grid_request_stock.Rows(e.RowIndex).Cells(i).Value)
                    End If
                Next


            End If

            'Set Totals
            SetTotals()

        End If
    End Sub

    'IF NUMBER FORMART ERROR
    Private Sub grid_request_stock_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles grid_request_stock.DataError
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

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try


    End Sub

    'When ROWS ADDED
    Private Sub grid_request_stock_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles grid_request_stock.RowsAdded
        If grid_request_stock.Rows.Count > 1 Then
            cbb_src_warehouse.Enabled = False
            btn_create.Enabled = True
        End If
    End Sub

    'When ROWS DELETED
    Private Sub grid_request_stock_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_request_stock.RowsRemoved
        If grid_request_stock.Rows.Count = 1 Then
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
    Private Sub grid_request_stock_KeyUp(sender As Object, e As KeyEventArgs) Handles grid_request_stock.KeyUp
        If grid_request_stock.RowCount > 1 Then
            If e.KeyCode = Keys.Delete Then
                grid_request_stock.Rows.RemoveAt(grid_request_stock.CurrentCell.RowIndex)
            End If
        End If
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        print_transfer_request(txt_stid.Text)
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
                            frm_warehouse_stocktransfer_new_distribute.insert_to_subtransfer(transfer_id, connect)

                            Me.Close()
                        End If
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

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
            MsgBox("Select destination warehouse first!.", vbCritical, "Required")
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
                'Stream Data from CSV
                Dim csvData As String = File.ReadAllText(openFileDialog.FileName)

                'Get grid_order DataTable
                Dim grid_tbl = DirectCast(grid_request_stock.DataSource, DataTable)
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
                    For Each dt_row As DataRow In grid_tbl.Rows
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
                            Dim left_join = String.Empty
                            Dim StoreQuery = String.Empty

                            'Query Table
                            For i = 0 To cbb_src_warehouse.Properties.Items.Count - 1

                                Dim store = "ims_" & cbb_src_warehouse.Properties.Items(i).ToString.Replace(" ", "_").ToLower
                                Dim store_tblName = cbb_src_warehouse.Properties.Items(i).Replace("Winland ", String.Empty)

                                StoreQuery += "IFNULL(" & store & ".qty, 0) AS '" & store_tblName & "', "
                                left_join += "LEFT JOIN " & store & " ON " & store & ".pid=ims_inventory.pid "
                            Next

                            Using cmd = New MySqlCommand("SELECT " & StoreQuery & " ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty, inv.qty,
                                    (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs
                                    FROM ims_inventory 
                                    " & left_join & "
                                    LEFT JOIN " & warehouse_tbl & " AS inv ON inv.pid=ims_inventory.pid
                                    WHERE ims_inventory.winmodel=@winmodel", conn)
                                cmd.Parameters.AddWithValue("@winmodel", values(1).Trim)

                                Using rdr As MySqlDataReader = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        While rdr.Read

                                            'SET VALUE to grid_order
                                            grid_tbl.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), rdr("masterbox_qty"), rdr("qty_per_box"), values(0).Trim, 0.00, rdr("cbm"), rdr("kgs"))

                                            For i = 8 To grid_request_stock.Columns.Count - 1
                                                grid_tbl.Rows(grid_tbl.Rows.Count - 1).Item(i) = 0
                                            Next

                                            'Show Per Warehouse Table QTY
                                            For Each store As String In cbb_src_warehouse.Properties.Items
                                                Dim StoreArr = store.Replace("Winland ", String.Empty).Trim
                                                For i = 9 To grid_tbl.Columns.Count - 1
                                                    If Equals(StoreArr.Trim, grid_tbl.Columns(i).ColumnName) Then
                                                        grid_tbl.Rows(grid_tbl.Rows.Count - 1).Item(i) = IIf(rdr(StoreArr) Mod 1 = 0, CInt(rdr(StoreArr)), rdr(StoreArr))
                                                    End If
                                                Next
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

                grid_request_stock.DataSource = grid_tbl

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
        Dim dt = DirectCast(grid_request_stock.DataSource, DataTable)
        Dim dataViews As DataView = New DataView(dt)
        dt.DefaultView.RowFilter = String.Concat(New String() {"winmodel LIKE '%", Me.txt_search.Text.Trim(), "%' OR description LIKE '%", Me.txt_search.Text.Trim(), "%'"})
        grid_request_stock.DataSource = dt
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