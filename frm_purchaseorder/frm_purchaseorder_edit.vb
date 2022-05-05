Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient
Imports Newtonsoft.Json

Public Class frm_purchaseorder_edit

    'ReadOnly conn As New MySqlConnection(str)
    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection



    '--- FUNCTIONS ----

    'Load data using PO ID
    Public Sub Init(src As String)

        'Load Locations
        load_locations()

        Try
            'DECLARATIONS
            Dim Orders = "", discount_type = "", deliver_to = String.Empty

            Dim query = "SELECT ims_suppliers.supplier, ims_purchase.contact_person, address, ims_users.first_name AS created_by, DATE_ADD(CONVERT(date_sent, DATE), INTERVAL ims_purchase.lead_time DAY) AS default_date,                                     
                            (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, notes, status, discount_val, discount_type, orders, ims_purchase.terms, ims_purchase.lead_time, pub_notes,
                            is_vatable, is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage FROM ims_purchase
                            INNER JOIN ims_users ON ims_users.usr_id=created_by
                            LEFT JOIN ims_suppliers on ims_purchase.supplier=ims_suppliers.id 
                            WHERE purchase_id='" & CInt(Replace(txt_poid.Text, "PO", "")) & "'"

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read

                        Me.Text = String.Concat(Me.txt_poid.Text, " - Purchase Order")
                        Orders = reader("orders")
                        txt_status.Text = reader("status")

                        If txt_status.Text.Equals("Sent") Or txt_status.Text.Equals("Partial") Or txt_status.Text.Equals("Completed") Then
                            lbl_date.Text = Convert.ToDateTime(reader("default_date")).ToString("MMMM dd, yyyy (dddd)")
                        End If

                        cbb_supplier.Text = reader("supplier")
                        txt_contact.Text = reader("contact_person")
                        txt_del_address.Text = reader("address")
                        deliver_to = reader("deliver_to")
                        txt_priv_notes.Text = reader("notes")
                        txt_pub_notes.Text = If(IsDBNull(reader("pub_notes")), String.Empty, reader("pub_notes"))
                        txt_terms.Text = reader("terms")
                        txt_lead_time.Text = reader("lead_time")
                        lbl_created_by.Text = String.Concat("Created by ", reader("created_by"))

                        lbl_withholding_tax_percentage.Text = FormatPercent(reader("withholding_tax_percentage") / 100)
                        lbl_withholding_tax_amount.Text = FormatCurrency(reader("withholding_tax_amount"))
                        cb_tax_applied.Checked = reader("is_withholding_tax_applied")
                        cb_vatable.Checked = reader("is_vatable")

                        If Not IsDBNull(reader("discount_val")) Then txt_discount.Text = reader("discount_val")
                        If Not IsDBNull(reader("discount_type")) Then discount_type = reader("discount_type")

                    End While
                End Using
            End Using


            cbb_deliver.Text = deliver_to

            set_GridData(Orders)
            load_AllStocks()
            cbb_discount.Text = discount_type

            grid_order.ClearSelection()

            'Set Fields
            SetFields()

            If lbl_created_by.Text.Equals(frm_main.user_name.Text) And src.Equals("_view") Then
                Text = String.Concat(txt_poid.Text, " - Purchase Order (View Only)")
                btn_save_draft.Enabled = False
                btn_approval.Enabled = False
                btn_delete.Enabled = False
                grid_order.ReadOnly = True

            ElseIf src.Equals("_approval") Then
                btn_save_draft.Enabled = False
                btn_approval.Enabled = False
                btn_delete.Enabled = False
                grid_order.ReadOnly = True

            End If

            'Load AutoCOmpleteString for TextBox
            Load_AutoCompleteString()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set up the fields
    Private Sub SetFields()

        cbb_deliver.ReadOnly = True
        'txt_terms.ReadOnly = True
        'txt_lead_time.ReadOnly = True
        txt_contact.ReadOnly = True
        txt_del_address.ReadOnly = True

        btn_delete.Enabled = False
        btn_save_draft.Enabled = False
        btn_send.Enabled = False
        btn_print.Enabled = False

        grid_order.AllowUserToAddRows = False

        Select Case txt_status.Text

            Case "Unfinished"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False

                cbb_deliver.ReadOnly = False

                btn_delete.Enabled = True
                btn_save_draft.Enabled = True
                btn_print.Enabled = False
                grid_order.AllowUserToAddRows = True

            Case "For Approval"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False
                grid_order.AllowUserToAddRows = True

            Case "Approved"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False

                cbb_deliver.ReadOnly = False

                btn_send.Enabled = True
                btn_delete.Enabled = True


                grid_order.AllowUserToAddRows = True

            Case "Sent"
                btn_print.Enabled = True
                grid_order.AllowUserToAddRows = True

            Case "Partial"
                btn_print.Enabled = True
                grid_order.AllowUserToDeleteRows = False

                grid_order.Columns(1).ReadOnly = True
                grid_order.Columns(3).ReadOnly = True
                grid_order.Columns(4).ReadOnly = True
                grid_order.Columns(5).ReadOnly = True

                For i = 1 To 6
                    If i = 5 Then Continue For
                    grid_order.Columns(i).DefaultCellStyle.BackColor = Color.Gainsboro
                Next

            Case "Revised (Partial)"
                grid_order.AllowUserToAddRows = True

            Case "Revised (Partial)"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False
                grid_order.AllowUserToAddRows = True

            Case "Revised (Partial)"
                grid_order.AllowUserToDeleteRows = False
                grid_order.Columns(1).ReadOnly = False
                grid_order.Columns(3).ReadOnly = True
                grid_order.Columns(4).ReadOnly = True
                grid_order.Columns(5).ReadOnly = True

                For i = 1 To 6
                    If i = 5 Then Continue For
                    grid_order.Columns(i).DefaultCellStyle.BackColor = Color.Gainsboro
                Next

            Case "Completed"
                btn_send.Text = "Completed"
                btn_print.Enabled = True
                'grid_order.ReadOnly = True

            Case "Rejected"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False
                grid_order.AllowUserToAddRows = True

            Case "Rejected (Approved)"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False
                grid_order.AllowUserToAddRows = True

            Case "Rejected (Approved)"
                grid_order.AllowUserToDeleteRows = False
                grid_order.Columns(1).ReadOnly = False
                grid_order.Columns(3).ReadOnly = True
                grid_order.Columns(4).ReadOnly = True
                grid_order.Columns(5).ReadOnly = True

                For i = 1 To 6
                    If i = 5 Then Continue For
                    grid_order.Columns(i).DefaultCellStyle.BackColor = Color.Gainsboro
                Next

            Case "Rejected (Sent)"
                grid_order.AllowUserToAddRows = True


        End Select

        'If Approval Will Disable ALL BUTTONS
        If btn_approved.Visible = True Then
            btn_delete.Enabled = False
            btn_print.Enabled = False
            btn_send.Enabled = False
            btn_save_draft.Enabled = False
        End If

        'Admin Access
        If frm_main.user_role_id.Text = "1" And (txt_status.Text = "Approved" Or txt_status.Text = "Sent" Or txt_status.Text = "Partial" Or txt_status.Text = "Completed") Then
            grid_order.AllowUserToDeleteRows = False
            grid_order.AllowUserToAddRows = True
            'btn_print.Enabled = True
            btn_approval.Enabled = True
            btn_approval.Text = "Save"
            grid_order.Columns(1).ReadOnly = False
            grid_order.Columns(3).ReadOnly = False
            grid_order.Columns(4).ReadOnly = False
            grid_order.Columns(5).ReadOnly = False

            For i = 1 To 6
                If i = 5 Then Continue For
                grid_order.Columns(i).DefaultCellStyle.BackColor = Color.White
            Next
        End If

        'ZEN ACCESS ONLY
        If frm_main.user_id.Text = 10 Then
            grid_order.Columns(8).ReadOnly = False
        End If

    End Sub

    'Load Deliver Location to ComboBox
    Private Sub load_locations()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim rdr As MySqlDataReader = New MySqlCommand("SELECT store_name FROM `ims_stores`", connection).ExecuteReader
                Dim Coll As ComboBoxItemCollection = cbb_deliver.Properties.Items

                While rdr.Read
                    cbb_deliver.Properties.Items.Add(rdr("store_name"))
                End While

            End Using

            cbb_deliver.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set Units to Grid
    Sub set_GridData(units As String)

        'Dim comma(), equal() As String
        'Dim piece As String
        'Dim i As Integer
        'Dim colonseparator As New Regex("\b;\b")
        'Dim equalseparator As New Regex("\b=\b")

        'If grid_order.Rows.Count > 0 Then grid_order.Rows.Clear()

        Dim dt = New DataTable
        dt.Columns.Add("sku", GetType(Integer))
        dt.Columns.Add("qty", GetType(Decimal))
        dt.Columns.Add("qty_per_box", GetType(Integer))
        dt.Columns.Add("winmodel", GetType(String))
        dt.Columns.Add("supmodel", GetType(String))
        dt.Columns.Add("description", GetType(String))
        dt.Columns.Add("cost", GetType(Decimal))
        dt.Columns.Add("total", GetType(Decimal))
        dt.Columns.Add("total_received", GetType(Integer))
        dt.Columns.Add("qty_received", GetType(Integer))
        dt.Columns.Add("remaining", GetType(Decimal))

        If Not String.IsNullOrEmpty(units) Then

            'comma = colonseparator.Split(units)

            'For i = 0 To comma.Length - 1
            '    piece = comma(i).Trim
            '    equal = piece.Split("=")

            '    dt.Rows.Add(equal(0), equal(1), 0, equal(2), equal(3), equal(4), equal(5), equal(6).Replace(";", ""))
            'Next

            Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(units)
            For Each Order In PurchaseOrder
                'dt.Rows.Add(Order.pid, Order.qty, 0, Order.winmodel, Order.supmodel, Order.description, Order.cost, Order.total_cost)
                dt.Rows.Add(
                            Order.pid,
                            Order.qty,
                            0,
                            Order.winmodel,
                            Order.supmodel,
                            Order.description,
                            Order.cost,
                            Order.total_cost,
                            Order.qty_received,
                            0,
                            Order.qty - Order.qty_received
                        )
            Next

            grid_order.DataSource = dt
            lbl_noofitems.Text = dt.Rows.Count
            ComputeTotal()

        End If

    End Sub

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT winmodel, description FROM `ims_inventory` 
                    INNER JOIN ims_suppliers ON ims_inventory.supplier=ims_suppliers.id 
                    WHERE ims_suppliers.supplier=@supplier", connection)
                cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text)

                Using rdr = cmd.ExecuteReader
                    model_AutoCompleteString.Clear()
                    description_AutoCompleteString.Clear()

                    While rdr.Read
                        model_AutoCompleteString.Add(rdr("winmodel"))
                        description_AutoCompleteString.Add(rdr("description"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print Purchase Order Slip
    Private Sub PrintPurchaseOrderSlip(id As String)
        Dim report = New doc_purchase_order()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData

        Dim orders = String.Empty
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT purchase_id, ims_suppliers.supplier, ims_purchase.contact_person, address, orders, total, discount_type, discount_val,
                is_vatable, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, pub_notes,
                (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to,
                (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info,
                date_sent, ims_users.first_name as prepared_by,
                (SELECT first_name FROM ims_users WHERE usr_id=approved_by) as approved_by, approved_date, DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) as lead_time, ims_purchase.terms FROM ims_purchase
                INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase.supplier
                INNER JOIN ims_users ON ims_users.usr_id=ims_purchase.created_by WHERE purchase_id='" & id & "'"
                Dim rdr As MySqlDataReader = New MySqlCommand(query, connection).ExecuteReader

                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info") & vbCrLf & "Email: purchasing@winlandene.com"
                    report.Parameters("pid").Value = String.Concat("PO", rdr("purchase_id").ToString().PadLeft(5, "0"c))
                    report.Parameters("supplier").Value = rdr("supplier")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("delivery_addr").Value = rdr("address")
                    report.Parameters("deliver_to").Value = rdr("deliver_to")
                    report.Parameters("prepared_by").Value = rdr("prepared_by")
                    report.Parameters("approved_by").Value = rdr("approved_by")
                    report.Parameters("print_date").Value = Format(rdr("date_sent"), "MM/dd/yyyy")
                    report.Parameters("lead_time").Value = rdr("lead_time")
                    report.Parameters("expiration_date").Value = DateAdd("d", 7, CDate(rdr("lead_time")))
                    report.Parameters("approved_date").Value = rdr("approved_date")
                    report.Parameters("terms").Value = rdr("terms")
                    report.Parameters("pub_notes").Value = rdr("pub_notes")
                    report.Parameters("amount_due").Value = rdr("total")
                    report.Parameters("discount_type").Value = rdr("discount_type")
                    report.Parameters("discount_val").Value = rdr("discount_val")
                    report.Parameters("is_vatable").Value = rdr("is_vatable")
                    report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                    report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                    report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")

                    'Set Order to DataTable
                    Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(rdr("orders"))
                    For Each Order In PurchaseOrder
                        table.purchase_order_slip.Rows.Add(Order.qty, Order.winmodel, Order.supmodel, Order.description, Order.cost, Order.total_cost)
                    Next
                    'Sort DataTable
                    table.purchase_order_slip.DefaultView.Sort = "supmodel ASC"

                End While

                report.RequestParameters = False

                report.DataSource = table
                report.ShowRibbonPreviewDialog()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print Purchase Slip
    Private Sub PrintPurchaseSlip(id As String)
        Dim report = New doc_purchase_list()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT purchase_id, ims_suppliers.supplier, ims_purchase.contact_person, address, orders, pub_notes,
                (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to,
                (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info,
                date_sent, ims_users.first_name as prepared_by,
                (SELECT first_name FROM ims_users WHERE usr_id=approved_by) as approved_by, approved_date, DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) as lead_time, ims_purchase.terms FROM ims_purchase
                INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase.supplier
                INNER JOIN ims_users ON ims_users.usr_id=ims_purchase.created_by WHERE purchase_id='" & id & "'"
                Dim rdr As MySqlDataReader = New MySqlCommand(query, connection).ExecuteReader

                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info") & vbCrLf & "Email: purchasing@winlandene.com"
                    report.Parameters("pid").Value = String.Concat("PO", rdr("purchase_id").ToString().PadLeft(5, "0"c))
                    report.Parameters("supplier").Value = rdr("supplier")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("delivery_addr").Value = rdr("address")
                    report.Parameters("deliver_to").Value = rdr("deliver_to")
                    report.Parameters("prepared_by").Value = rdr("prepared_by")
                    report.Parameters("approved_by").Value = rdr("approved_by")
                    report.Parameters("print_date").Value = Format(rdr("date_sent"), "MM/dd/yyyy")
                    report.Parameters("lead_time").Value = rdr("lead_time")
                    report.Parameters("expiration_date").Value = DateAdd("d", 7, CDate(rdr("lead_time")))
                    report.Parameters("approved_date").Value = rdr("approved_date")
                    report.Parameters("terms").Value = rdr("terms")
                    report.Parameters("pub_notes").Value = rdr("pub_notes")

                    'Set Order to DataTable
                    Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(rdr("orders"))
                    For Each Order In PurchaseOrder
                        table.purchase_order_slip.Rows.Add(Order.qty, Order.winmodel, Order.supmodel, Order.description)
                    Next
                    'Sort DataTable
                    table.purchase_order_slip.DefaultView.Sort = "supmodel ASC"

                End While

                report.RequestParameters = False

                report.DataSource = table
                report.ShowRibbonPreviewDialog()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Compute Total 
    Private Sub ComputeTotal()
        Try
            Dim sub_total As Decimal
            Dim grid_dt = DirectCast(grid_order.DataSource, DataTable)

            For i = 0 To grid_dt.Rows.Count - 1
                If IsDBNull(grid_dt.Rows(i).Item(7)) Then Continue For
                sub_total += grid_dt.Rows(i).Item(7)
            Next

            If Not String.IsNullOrEmpty(txt_discount.Text) And Not cbb_discount.SelectedIndex = -1 Then
                If cbb_discount.SelectedIndex = 0 Then 'IF PESO
                    sub_total = sub_total - Decimal.Parse(txt_discount.Text)
                ElseIf cbb_discount.SelectedIndex = 1 Then 'IF PERCENT
                    sub_total = sub_total - (sub_total * (txt_discount.Text / 100))
                End If
            End If

            If cb_tax_applied.Checked = True Then
                Dim less_vat_subtotal As Decimal = sub_total / 1.12
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(lbl_withholding_tax_percentage.Text.Replace("%", "") / 100)
                lbl_total.Text = FormatCurrency(sub_total - withholding_tax)
                lbl_withholding_tax_amount.Text = FormatCurrency(withholding_tax)
            Else
                lbl_total.Text = FormatCurrency(sub_total, 2)
                lbl_withholding_tax_amount.Text = FormatCurrency(0)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Get Tables
    Private Function get_all_store_tables(conn As MySqlConnection)
        Dim tables As String = String.Empty
        Dim rdr As MySqlDataReader = New MySqlCommand("SELECT store_name FROM ims_stores", conn).ExecuteReader()

        While rdr.Read()
            Dim str As String = String.Concat("ims_", rdr("store_name").ToString().ToLower().Replace(" ", "_"))
            tables = String.Concat(tables, str, ",")
        End While
        rdr.Close()
        Return tables
    End Function

    'Get Query
    Private Function get_query(conn As MySqlConnection)
        Dim store_tables As String() = get_all_store_tables(conn).ToString().Split(New Char() {","c})
        Dim QUERY_STR As String = String.Empty
        Dim LEFT_JOIN_STR As String = String.Empty

        For i = 0 To store_tables.Length - 2
            QUERY_STR = String.Concat(New String() {QUERY_STR, "IFNULL(", store_tables(i), ".qty,0) + IFNULL(", store_tables(i), ".on_hold,0) "})
            LEFT_JOIN_STR = String.Concat(New String() {LEFT_JOIN_STR, "LEFT JOIN ", store_tables(i), " ON ims_inventory.pid=", store_tables(i), ".pid "})
            If Not i = store_tables.Length - 2 Then
                QUERY_STR = String.Concat(QUERY_STR, " + ")
            End If
        Next

        Return String.Concat("SELECT ims_inventory.pid, winmodel, supmodel, description, cost, qty_per_box, status, ", QUERY_STR, " AS total_qty FROM `ims_inventory` ", LEFT_JOIN_STR)

    End Function

    'Load All Stocks
    Private Sub load_AllStocks()

        grid_stocks.Rows.Clear()

        Using connection = New MySqlConnection(str)
            connection.Open()

            For i = 0 To grid_order.Rows.Count - 2
                Dim winmodel = grid_order.Rows(i).Cells(3).Value

                Dim cmd = New MySqlCommand(get_query(connection) & " WHERE winmodel=@winmodel", connection)
                cmd.Parameters.AddWithValue("@winmodel", winmodel)
                Using rdr As MySqlDataReader = cmd.ExecuteReader()
                    While rdr.Read()
                        grid_stocks.Rows.Add(rdr("total_qty"))
                        grid_order.Rows(i).Cells(2).Value = rdr("qty_per_box")
                    End While
                End Using
            Next

        End Using

    End Sub

    'Digits ONLY
    Private Sub DigitsOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If grid_order.CurrentCell.ColumnIndex = 1 Then
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If
        End If
    End Sub

    'Grid Value Checking | For Null, Empty Values
    Private Function GridCheck()
        For i = 0 To grid_order.Rows.Count - 1
            If IsDBNull(grid_order.Rows(i).Cells(0).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(1).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(2).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(3).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(4).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(5).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(6).Value) Or
                IsDBNull(grid_order.Rows(i).Cells(7).Value) Then
                Return False
            End If
        Next
        Return True
    End Function



    '--- CONTROLS ---

    'btn_save_drafts
    Private Sub btn_save_draft_Click(sender As Object, e As EventArgs) Handles btn_save_draft.Click

        'CHECK CELL VALUES
        If GridCheck() = False Then
            MsgBox("Some cells are empty. Please check it first!", vbExclamation, "Emty Cells Found")
            Return
        End If

        'COMBOBOX CHECKER
        If String.IsNullOrEmpty(cbb_supplier.Text) Or
            String.IsNullOrEmpty(cbb_deliver.Text) Or
            grid_order.Rows.Count < 1 Then Return

        'TERMS VALIDATOR
        If Not IsNumeric(txt_terms.Text) Then
            MsgBox("Terms MUST be a number!", vbCritical, "Forbidden")
            Exit Sub
        End If

        Dim ListOfOrders = New List(Of PurchaseOrderClass)
        'Dim orders = String.Empty
        Dim purchase_id = txt_poid.Text

        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows

            'If String.IsNullOrEmpty(row.Item(0).ToString) Then Continue For
            'orders = orders & row.Item(0).ToString & "=" & row.Item(1).ToString & "=" & row.Item(3).ToString & "=" & row.Item(4).ToString & "=" & row.Item(5).ToString & "=" & row.Item(6).ToString & "=" & row.Item(7).ToString & ";"

            ListOfOrders.Add(New PurchaseOrderClass With {
                .pid = row.Item(0),
                .qty = row.Item(1),
                .winmodel = row.Item(3),
                .supmodel = row.Item(4),
                .description = row.Item(5),
                .cost = row.Item(6),
                .total_cost = row.Item(7),
                .qty_received = IIf(IsDBNull(row.Item(8)), 0, row.Item(8))
            })

        Next

        Try
            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET contact_person=@contact_person, address=@address,deliver_to=(SELECT store_id FROM ims_stores WHERE store_name=@deliver_to), status=@status,
                                        orders=@orders, is_vatable=@is_vatable, discount_val=@discount_val, discount_type=@discount_type, pub_notes=@pub_notes, notes=@notes, is_payment_first=@is_payment_first,
                                        is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                                        total=@total, terms=@terms, lead_time=@lead_time WHERE purchase_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", CInt(purchase_id.Replace("PO", "")))
                    cmd.Parameters.AddWithValue("@contact_person", txt_contact.Text.Trim)
                    cmd.Parameters.AddWithValue("@address", txt_del_address.Text.Trim)
                    cmd.Parameters.AddWithValue("@deliver_to", cbb_deliver.Text.Trim)
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", "")))
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@pub_notes", txt_pub_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@total", CDec(Replace(lbl_total.Text, "₱", "")))
                    cmd.Parameters.AddWithValue("@terms", CInt(txt_terms.Text))
                    cmd.Parameters.AddWithValue("@lead_time", CInt(txt_lead_time.Text))
                    cmd.Parameters.AddWithValue("@status", "Unfinished")
                    cmd.Parameters.AddWithValue("@is_payment_first", cb_payment_first.Checked)

                    If cmd.ExecuteNonQuery() >= 1 Then MsgBox("Saved Successfully!", vbInformation, "Information")
                    frm_main.LoadFrm(New frm_purchaseorder_list)
                End Using

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_submit_for_approval
    Private Sub btn_approval_Click(sender As Object, e As EventArgs) Handles btn_approval.Click

        'CHECK CELL VALUES
        If GridCheck() = False Then
            MsgBox("Some cells are empty. Please check it first!", vbExclamation, "Emty Cells Found")
            Return
        End If

        'COMBOBOX CHECKER
        If String.IsNullOrEmpty(cbb_supplier.Text) Or
            String.IsNullOrEmpty(cbb_deliver.Text) Or
            grid_order.Rows.Count < 1 Then Exit Sub

        'TERMS VALIDATOR
        If Not IsNumeric(txt_terms.Text) Then
            MsgBox("Terms MUST be a number!", vbCritical, "Forbidden")
            Exit Sub
        End If

        Dim ListOfOrders = New List(Of PurchaseOrderClass)
        'Dim orders = String.Empty
        Dim purchase_id = txt_poid.Text
        Dim status = "UNKNOWN STATUS"

        'Define Status
        Select Case txt_status.Text
            Case "Unfinished" : status = "For Approval"
            Case "For Approval" : status = "For Approval"
            Case "Approved" : status = "Revised (Approved)"
            Case "Revised (Approved)" : status = "Revised (Approved)"
            Case "Sent" : status = "Revised (Sent)"
            Case "Revised (Sent)" : status = "Revised (Sent)"
            Case "Partial" : status = "Revised (Partial)"
            Case "Revised (Partial)" : status = "Revised (Partial)"

            Case "Rejected" : status = "For Approval"
            Case "Rejected (Approved)" : status = "Revised (Approved)"
            Case "Rejected (Sent)" : status = "Revised (Sent)"
            Case "Rejected (Partial)" : status = "Revised (Partial)"

            Case "Completed" : status = "Revised (Completed)"
        End Select

        'Admin Access | Save As Is! 
        If frm_main.user_role_id.Text = "1" And (txt_status.Text = "Approved" Or txt_status.Text = "Sent" Or txt_status.Text = "Partial" Or txt_status.Text = "Completed") Then
            status = txt_status.Text
        End If

        For Each row As DataRow In DirectCast(grid_order.DataSource, DataTable).Rows

            'If String.IsNullOrEmpty(row.Item(0).ToString) Then Continue For
            'orders = orders & row.Item(0).ToString & "=" & row.Item(1).ToString & "=" & row.Item(3).ToString & "=" & row.Item(4).ToString & "=" & row.Item(5).ToString & "=" & row.Item(6).ToString & "=" & row.Item(7).ToString & ";"

            ListOfOrders.Add(New PurchaseOrderClass With {
                .pid = row.Item(0),
                .qty = row.Item(1),
                .winmodel = row.Item(3),
                .supmodel = row.Item(4),
                .description = row.Item(5),
                .cost = row.Item(6),
                .total_cost = row.Item(7),
                .qty_received = IIf(IsDBNull(row.Item(8)), 0, row.Item(8))
            })

        Next

        Try
            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET contact_person=@contact_person, address=@address, deliver_to=(SELECT store_id FROM ims_stores WHERE store_name=@deliver_to), status=@status,
                                        orders=@orders, is_vatable=@is_vatable, discount_val=@discount_val, discount_type=@discount_type, pub_notes=@pub_notes, notes=@notes, is_payment_first=@is_payment_first,
                                        is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                                        total=@total, terms=@terms, lead_time=@lead_time WHERE purchase_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", CInt(purchase_id.Replace("PO", "")))
                    cmd.Parameters.AddWithValue("@contact_person", txt_contact.Text.Trim)
                    cmd.Parameters.AddWithValue("@address", txt_del_address.Text.Trim)
                    cmd.Parameters.AddWithValue("@deliver_to", cbb_deliver.Text.Trim)
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", "")))
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@pub_notes", txt_pub_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@total", CDec(Replace(lbl_total.Text, "₱", "")))
                    cmd.Parameters.AddWithValue("@terms", CInt(txt_terms.Text))
                    cmd.Parameters.AddWithValue("@lead_time", CInt(txt_lead_time.Text))
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@is_payment_first", cb_payment_first.Checked)

                    If cmd.ExecuteNonQuery() >= 1 Then MsgBox("Saved Successfully!", vbInformation, "Information")
                    frm_main.LoadFrm(New frm_purchaseorder_list)
                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If MsgBox("Delete this purchase order?", vbQuestion + vbYesNo, "Delete") = vbYes Then
            Dim id = CInt(txt_poid.Text.Replace("PO", ""))

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET deleted='1' WHERE purchase_id='" & id & "' ", connection).ExecuteNonQuery()

                    MsgBox("Successfully deleted!", vbInformation, "Information")
                    frm_main.LoadFrm(New frm_purchaseorder_list)
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If
    End Sub

    'Breadcrumbs
    Private Sub link_po_list_Click_1(sender As Object, e As EventArgs) Handles link_po_list.Click
        Me.Close()
        frm_main.LoadFrm(New frm_purchaseorder_list)
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        CMS_print.Show(btn_print, New Point(btn_print.Width - CMS_print.Width, btn_print.Height))
    End Sub

    'btn_send
    Private Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click

        Dim ans = MsgBox("Press 'Yes' to send.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Dim id As Integer = txt_poid.Text.Replace("PO", "")
            Dim dt = Date.Today.ToString("yyyy-MM-dd")
            Dim i = 0

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status='Sent', date_sent='" & dt & "' WHERE purchase_id='" & id & "' ", connection)
                    i = cmd.ExecuteNonQuery
                End Using

                If i >= 1 Then
                    MsgBox("Your Purchase order has been tagged as SENT!", vbInformation, "Information")
                    Me.Close()
                    frm_main.LoadFrm(New frm_purchaseorder_list)
                    PrintPurchaseOrderSlip(txt_poid.Text.Replace("PO", ""))
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'btn_approved | Admin Approval Button
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click

        Dim response = String.Empty
        Dim result = frm_purchaseorder_approval_dialog.ShowDialog

        If result = DialogResult.Yes Then
            response = "Approve"
        ElseIf result = DialogResult.No Then
            response = "Reject"
        Else
            Return
        End If

        If MsgBox(response & " this PO?" & vbCrLf & "Press 'YES' to Continue.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Dim status = String.Empty

            Select Case response

                Case "Approve"
                    Select Case txt_status.Text
                        Case "For Approval" : status = "Approved"
                        Case "Revised (Approved)" : status = "Approved"
                        Case "Revised (Sent)" : status = "Sent"
                        Case "Revised (Partial)" : status = "Partial"
                        Case "Revised (Completed)" : status = "Completed"
                    End Select

                Case "Reject"
                    Select Case txt_status.Text
                        Case "For Approval" : status = "Rejected"
                        Case "Revised (Approved)" : status = "Rejected (Approved)"
                        Case "Revised (Sent)" : status = "Rejected (Sent)"
                        Case "Revised (Partial)" : status = "Rejected (Partial)"
                        Case "Revised (Completed)" : status = "Rejected (Completed)"
                    End Select

            End Select

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status=@status, approved_by=@approved_by, approved_date=@approved_date, notes=@notes WHERE purchase_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", CInt(txt_poid.Text.Replace("PO", "")))
                    cmd.Parameters.AddWithValue("@approved_by", frm_main.user_id.Text)
                    cmd.Parameters.AddWithValue("@approved_date", Date.Today)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Purchase Order is " & IIf(Equals("Approve", response), "Approved!", "Rejected!"), vbInformation, "Information")
                Me.Close()
                frm_main.LoadFrm(New frm_admin_approval)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'grid_order.EditingControlShowing | Grid cell to TextBox
    Private Sub grid_order_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_order.EditingControlShowing

        If grid_order.CurrentCell.ColumnIndex = 1 Then
            AddHandler DirectCast(e.Control, TextBox).KeyPress, AddressOf DigitsOnly_KeyPress
        End If

        If Not grid_order.CurrentCell.ColumnIndex = 3 Or grid_order.CurrentCell.ColumnIndex = 5 Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            RemoveHandler txt.KeyPress, AddressOf DigitsOnly_KeyPress

            If grid_order.CurrentCell.ColumnIndex = 3 Then

                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = model_AutoCompleteString
                    txt.CharacterCasing = CharacterCasing.Upper
                End If

            ElseIf grid_order.CurrentCell.ColumnIndex = 5 Then
                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = description_AutoCompleteString
                End If
            End If

        End If

    End Sub

    'grid_order.CellEndEdit | Upon Selection of Value in Cells
    Private Sub grid_order_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_order.CellEndEdit
        If Not String.IsNullOrEmpty(cbb_supplier.Text) Then

            'IF MODEL
            If e.ColumnIndex.Equals(3) Then
                If Not IsDBNull(grid_order.CurrentCell.Value) Then

                    'CHECK IF ALREADY EXIST
                    For i = 0 To grid_order.Rows.Count - 1
                        If i = grid_order.CurrentRow.Index Then Continue For
                        If grid_order.CurrentCell.Value.Equals(grid_order.Rows(i).Cells(3).Value) Then
                            MsgBox("Warning! Item Already Exist.", vbExclamation, "Duplicate Entry")
                        End If
                    Next

                    'GET AND SET
                    Try
                        Using connection = New MySqlConnection(str)
                            connection.Open()
                            Dim cmd = New MySqlCommand(get_query(connection) & " WHERE winmodel=@winmodel", connection)
                            cmd.Parameters.AddWithValue("@winmodel", grid_order.CurrentCell.Value)
                            Dim rdr As MySqlDataReader = cmd.ExecuteReader

                            If rdr.HasRows Then
                                Using rdr
                                    While rdr.Read

                                        'SET VALUE TO grid_stocks
                                        If grid_stocks.Rows.Count <= e.RowIndex Then
                                            grid_stocks.Rows.Add(New Object() {rdr("total_qty")})
                                        Else
                                            grid_stocks.Rows(e.RowIndex).Cells(0).Value = rdr("total_qty")
                                        End If

                                        'Validation of Unit Status
                                        If Not rdr("status").Equals("Active") Then
                                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & "", vbCritical, "Not Active")
                                            grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                                            Exit Sub
                                        End If

                                        grid_order.Rows(e.RowIndex).Cells(0).Value = rdr("pid").ToString.PadLeft(6, "0"c)
                                        grid_order.Rows(e.RowIndex).Cells(2).Value = rdr("qty_per_box")
                                        grid_order.Rows(e.RowIndex).Cells(3).Value = rdr("winmodel")
                                        grid_order.Rows(e.RowIndex).Cells(4).Value = rdr("supmodel")
                                        grid_order.Rows(e.RowIndex).Cells(5).Value = rdr("description")
                                        Dim cost As Decimal = rdr("cost")
                                        grid_order.Rows(e.RowIndex).Cells(6).Value = cost
                                        If Not IsDBNull(grid_order.Rows(e.RowIndex).Cells(1).Value) Then
                                            Dim total As Decimal = grid_order.Rows(e.RowIndex).Cells(1).Value * cost
                                            grid_order.Rows(e.RowIndex).Cells(7).Value = total
                                        End If

                                    End While
                                End Using
                            Else
                                MsgBox("Selected item couldn't found!", vbCritical, "Not Found")
                                grid_order.Rows(e.RowIndex).Cells(0).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(1).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(2).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(3).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(4).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(5).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(6).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(7).Value = DBNull.Value
                                Return
                            End If

                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                Else
                    Return
                End If
            End If


            'IF DESCRIPTION
            If e.ColumnIndex.Equals(5) Then
                If Not IsDBNull(grid_order.CurrentCell.Value) Then

                    For i = 0 To grid_order.Rows.Count - 1
                        If i = grid_order.CurrentRow.Index Then Continue For
                        If grid_order.CurrentCell.Value.Equals(grid_order.Rows(i).Cells(5).Value) Then
                            MsgBox("Warning! Item Already Exist.", vbExclamation, "Duplicate Entry")
                        End If
                    Next

                    Try
                        Using connection = New MySqlConnection(str)
                            connection.Open()
                            Dim cmd = New MySqlCommand(get_query(connection) & " WHERE description=@description", connection)
                            cmd.Parameters.AddWithValue("@description", grid_order.CurrentCell.Value)
                            Dim rdr As MySqlDataReader = cmd.ExecuteReader

                            If rdr.HasRows Then
                                Using rdr
                                    While rdr.Read

                                        'Validation of Unit Status
                                        If Not rdr("status").Equals("Active") Then
                                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & "", vbCritical, "Not Active")
                                            grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                                            Return
                                        End If

                                        grid_order.Rows(e.RowIndex).Cells(0).Value = rdr("pid").ToString.PadLeft(6, "0"c)
                                        grid_order.Rows(e.RowIndex).Cells(2).Value = rdr("qty_per_box")
                                        grid_order.Rows(e.RowIndex).Cells(3).Value = rdr("winmodel")
                                        grid_order.Rows(e.RowIndex).Cells(4).Value = rdr("supmodel")
                                        grid_order.Rows(e.RowIndex).Cells(5).Value = rdr("description")
                                        Dim cost As Decimal = rdr("cost")
                                        grid_order.Rows(e.RowIndex).Cells(6).Value = cost
                                        If Not IsDBNull(grid_order.Rows(e.RowIndex).Cells(1).Value) Then
                                            Dim total As Decimal = grid_order.Rows(e.RowIndex).Cells(1).Value * cost
                                            grid_order.Rows(e.RowIndex).Cells(7).Value = total
                                        End If
                                    End While
                                End Using
                            Else
                                MsgBox("Selected item couldn't found!", vbCritical, "Not Found")
                                grid_order.Rows(e.RowIndex).Cells(0).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(1).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(2).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(3).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(4).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(5).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(6).Value = DBNull.Value
                                grid_order.Rows(e.RowIndex).Cells(7).Value = DBNull.Value
                                Return
                            End If

                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                Else
                    Return
                End If

            End If

            'IF QTY OR PRICE
            If e.ColumnIndex.Equals(1) Or e.ColumnIndex.Equals(6) Then

                Try

                    'Check if NOT null | Validation
                    If IsDBNull(grid_order.Rows(e.RowIndex).Cells(3).Value) Then Return

                    Dim qty As Decimal = grid_order.Rows(e.RowIndex).Cells(1).Value
                    Dim cost As Decimal = grid_order.Rows(e.RowIndex).Cells(6).Value
                    Dim total As Decimal = Decimal.Multiply(qty, cost)
                    grid_order.Rows(e.RowIndex).Cells(6).Value = cost
                    grid_order.Rows(e.RowIndex).Cells(7).Value = total

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try

            End If

            'Compute Total
            ComputeTotal()

        End If

    End Sub

    'grid_order | Upon Deletion of Row
    Private Sub grid_order_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_order.RowsRemoved
        Try
            If grid_order.Rows.Count > 0 Then
                If grid_stocks.Rows.Count > 0 Then
                    For Each row As DataGridViewRow In grid_stocks.Rows
                        If row.Index = e.RowIndex Then grid_stocks.Rows.RemoveAt(e.RowIndex)
                    Next
                End If
                ComputeTotal()
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Grid Scroll with All Stocks grid
    Private Sub grid_order_Scroll(ByVal sender As Object, ByVal e As ScrollEventArgs) Handles grid_order.Scroll
        grid_stocks.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    'grid_order.UserAddedRow | Disable btn_send upon Adding Row
    Private Sub grid_order_UserAddedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grid_order.UserAddedRow

        If txt_status.Text.Equals("Approved") Then
            btn_send.Enabled = False
            btn_print.Enabled = False
        End If
        lbl_noofitems.Text = TryCast(grid_order.DataSource, DataTable).Rows.Count
    End Sub

    'grid_order.UserDeletedRow | Disable btn_send upon Deleting Row
    Private Sub grid_order_UserDeletedRow(sender As Object, e As DataGridViewRowEventArgs) Handles grid_order.UserDeletedRow

        If txt_status.Text.Equals("Approved") Then
            btn_send.Enabled = False
            btn_print.Enabled = False
        End If
        lbl_noofitems.Text = TryCast(grid_order.DataSource, DataTable).Rows.Count
    End Sub

    'cbb_discount | Enable/Disable txt_discount && Compute
    Private Sub cbb_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_discount.SelectedIndexChanged
        If Not String.IsNullOrEmpty(txt_discount.Text) Then ComputeTotal()
    End Sub

    'lbl_dispose.Click | Dispose Order when Obsolete
    Private Sub lbl_dispose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_dispose.LinkClicked

        If MsgBox("Press 'Yes' to continue.", vbYesNo + vbQuestion, "Dispose Obsolete Order") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status=@status WHERE purchase_id=" & CInt(txt_poid.Text.Replace("PO", "")), connection)
                    cmd.Parameters.AddWithValue("@status", "Obsolete")
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Order was successfully disposed!", vbInformation, "Success")
                frm_main.LoadFrm(New frm_purchaseorder_list)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'btn_active_orders.Click | Show Active Orders
    Private Sub btn_active_orders_Click(sender As Object, e As EventArgs) Handles btn_active_orders.Click
        Dim frmPurchaseorderViewOrderedItem As frm_purchaseorder_view_ordered_items = New frm_purchaseorder_view_ordered_items()
        frmPurchaseorderViewOrderedItem.grid_po_view.ActiveFilterString = String.Concat("[Supplier] ='", cbb_supplier.Text, "'")
        frmPurchaseorderViewOrderedItem.Show()
    End Sub

    'cb_tax_applied.Click
    Private Sub cb_tax_applied_Click(sender As Object, e As EventArgs) Handles cb_tax_applied.Click
        If cb_tax_applied.Checked = False Then
            cb_vatable.Enabled = True
        Else
            cb_vatable.Enabled = False
            cb_vatable.Checked = True
        End If
        ComputeTotal()
    End Sub

    'IF VATABLE
    Private Sub cb_vatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vatable.CheckedChanged
        If cb_tax_applied.Checked Then cb_vatable.Checked = True
    End Sub

    'Delete Key
    Private Sub grid_order_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles grid_order.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If grid_order.Rows.Count > 1 Then
                    grid_order.Rows.RemoveAt(grid_order.CurrentCell.RowIndex)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'txt_discount | Compute on Changingd in Discount Text
    Private Sub txt_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyUp
        ComputeTotal()
    End Sub

    'Search
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim dt = DirectCast(grid_order.DataSource, DataTable)
        Dim dataViews As DataView = New DataView(dt)
        dt.DefaultView.RowFilter = String.Concat(New String() {"winmodel LIKE '%", Me.txt_search.Text.Trim(), "%' OR supmodel LIKE '%", Me.txt_search.Text.Trim(), "%' OR description LIKE '%", Me.txt_search.Text.Trim(), "%'"})
        grid_order.DataSource = dt
    End Sub

    'Sort
    Private Sub grid_order_Sorted(sender As Object, e As EventArgs) Handles grid_order.Sorted
        Dim dt = DirectCast(grid_order.DataSource, DataTable)
        dt.DefaultView.Sort = "winmodel ASC"
        grid_order.DataSource = dt.DefaultView.ToTable
    End Sub

    'cbb_deliver
    Private Sub cbb_deliver_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_deliver.EditValueChanged

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM `ims_stores` WHERE store_name=@store_name", connection)
                cmd.Parameters.AddWithValue("@store_name", cbb_deliver.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    txt_del_address.Text = rdr("store_addr")
                End While

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print Purchase Order Slip
    Private Sub CMS_strip_purchase_order_Click(sender As Object, e As EventArgs) Handles CMS_strip_purchase_order.Click
        Dim id As Integer = txt_poid.Text.Replace("PO", "")
        PrintPurchaseOrderSlip(id)
    End Sub

    'Print Purchase Slip
    Private Sub CMS_strip_purchase_slip_Click(sender As Object, e As EventArgs) Handles CMS_strip_purchase_slip.Click
        Dim id As Integer = txt_poid.Text.Replace("PO", "")
        PrintPurchaseSlip(id)
    End Sub

End Class