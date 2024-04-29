Imports System.IO
Imports DevExpress.Pdf.Native.BouncyCastle.Asn1.X509
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json
Imports OfficeOpenXml

Public Class frm_purchaseorder_edit

    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection
    Public Property is_approval As Boolean = False
    Private Property VAT_RATE As Decimal = VAT_percentage - 1


    '--- ONLOAD ---

    Private Sub frm_purchaseorder_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If TryCast(grid_purchasing.DataSource, DataTable) Is Nothing Then
            grid_purchasing.DataSource = Set_DataTable()
        End If
        If cbb_supplier.Properties.Items.Count = 0 Then load_supplier()
        If cbb_deliver.Properties.Items.Count = 0 Then load_locations()
    End Sub

    Private Sub frm_purchaseorder_edit_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If String.IsNullOrEmpty(txt_poid.Text) Then
            btn_import.Location = btn_print.Location
            btn_recall.Visible = False
        Else
            btn_recall.Location = btn_approved.Location
            btn_import.Visible = False
        End If
    End Sub



    '--- FUNCTIONS ----

    'Load data using PO ID
    Public Sub Init(src As String)

        'Initialize
        load_locations()
        grid_purchasing.DataSource = Set_DataTable()

        Try
            'DECLARATIONS
            Dim Orders = String.Empty, discount_type = String.Empty, deliver_to = String.Empty

            Dim query = "SELECT ims_suppliers.supplier, ims_purchase.contact_person, address, ims_users.first_name AS created_by, DATE_ADD(CONVERT(date_sent, DATE), INTERVAL ims_purchase.lead_time DAY) AS default_date,                                     
                            (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to, notes, status, discount_val, discount_type, orders, ims_purchase.terms, ims_purchase.lead_time, pub_notes,
                            is_vatable, vat_rate, is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage 
                            FROM ims_purchase
                            INNER JOIN ims_users ON ims_users.usr_id=created_by
                            LEFT JOIN ims_suppliers on ims_purchase.supplier=ims_suppliers.id 
                            WHERE purchase_id='" & CInt(Replace(txt_poid.Text, "PO", String.Empty)) & "'"

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand(query, connection)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    While reader.Read

                        Me.Text = String.Concat(Me.txt_poid.Text, " - " & reader("supplier"))
                        Orders = reader("orders")
                        lbl_status.Text = reader("status")

                        If lbl_status.Text.Equals("Sent") Or lbl_status.Text.Equals("Partial") Or lbl_status.Text.Equals("Completed") Then
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
                        lbl_created_by.Text = String.Concat(reader("created_by"))

                        lbl_withholding_tax_percentage.Text = FormatPercent(reader("withholding_tax_percentage") / 100)
                        lbl_withholding_tax_amount.Text = FormatCurrency(reader("withholding_tax_amount"))
                        cb_ewt_tax_applied.Checked = reader("is_withholding_tax_applied")
                        cb_vatable.Checked = reader("is_vatable")
                        VAT_RATE = reader("vat_rate")

                        If Not IsDBNull(reader("discount_val")) Then txt_discount.Text = reader("discount_val")
                        If Not IsDBNull(reader("discount_type")) Then discount_type = reader("discount_type")

                    End While
                End Using
            End Using


            cbb_deliver.Text = deliver_to

            'set_GridData(Orders)
            set_grid_data(Orders)
            'load_AllStocks()
            cbb_discount.Text = discount_type

            'grid_order.ClearSelection()

            'Set Fields
            SetFields()

            'Load AutoCOmpleteString for TextBox
            'Load_AutoCompleteString()
            Load_SearchBox(cbb_supplier.Text)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load Items to ComboBox Search
    Private Sub Load_SearchBox(supplier_name As String)
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT winmodel FROM `ims_inventory` 
                    INNER JOIN ims_suppliers ON ims_inventory.supplier=ims_suppliers.id 
                    WHERE ims_suppliers.supplier=@supplier
                    ORDER by winmodel ASC", connection)
                cmd.Parameters.AddWithValue("@supplier", supplier_name)

                cbb_search.Properties.Items.Clear()

                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_search.Properties.Items.Add(rdr("winmodel"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load Supplier to ComboBox
    Private Sub load_supplier()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_supplier.Properties.Items.Add(rdr("supplier"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set up the fields
    Private Sub SetFields()

        cbb_supplier.ReadOnly = True
        cbb_deliver.ReadOnly = True
        txt_contact.ReadOnly = True
        txt_del_address.ReadOnly = True

        btn_delete.Visible = True
        btn_send.Visible = True
        btn_print.Visible = True

        btn_delete.Enabled = False
        btn_save_draft.Enabled = False
        btn_send.Enabled = False
        btn_print.Enabled = False


        Select Case lbl_status.Text

            Case "Unfinished"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False

                cbb_deliver.ReadOnly = False

                btn_delete.Enabled = True
                btn_save_draft.Enabled = True
                btn_print.Enabled = False

            Case "For Approval"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False

            Case "Approved"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False

                cbb_deliver.ReadOnly = False

                btn_send.Enabled = True
                btn_delete.Enabled = True



            Case "Sent"
                btn_print.Enabled = True

            Case "Partial"
                btn_print.Enabled = True

            Case "Revised (Partial)"

            Case "Revised (Partial)"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False

            Case "Revised (Partial)"

            Case "Completed"
                btn_send.Text = "Completed"
                btn_print.Enabled = True

            Case "Rejected"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False

            Case "Rejected (Approved)"
                txt_terms.ReadOnly = False
                txt_lead_time.ReadOnly = False
                txt_contact.ReadOnly = False
                txt_del_address.ReadOnly = False
                btn_delete.Enabled = True
                cbb_deliver.ReadOnly = False

            Case "Rejected (Approved)"

            Case "Rejected (Sent)"


        End Select

        'If Approval Will Disable ALL BUTTONS
        If is_approval = True Then
            btn_approved.Visible = True
            btn_delete.Enabled = False
            btn_print.Enabled = False
            btn_send.Enabled = False
            btn_approval.Enabled = False
            btn_save_draft.Enabled = False
        End If

        'ADMIN ACCESS : DIRECT SAVE WITHOUT APPROVAL
        If frm_main.lbl_user_role_id.Text = "1" And
                (lbl_status.Text = "Approved" Or lbl_status.Text = "Sent" Or lbl_status.Text = "Partial" Or lbl_status.Text = "Completed") Then
            btn_approval.Enabled = True
            btn_approval.Text = "Save"
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

    'Set Units to Grid : OBSOLETE!!!
    Sub set_GridData(units As String)

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
    Private Sub PrintPurchaseOrderSlip(id As Integer)
        Dim report = New doc_purchase_order()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData
        Dim orders = String.Empty

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT purchase_id, ims_suppliers.supplier, ims_purchase.contact_person, address, orders, total, discount_type, discount_val,
                is_vatable, vat_rate, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, pub_notes,
                (SELECT store_name FROM ims_stores WHERE store_id=deliver_to) as deliver_to,
                (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info,
                date_sent, ims_users.first_name as prepared_by,
                (SELECT first_name FROM ims_users WHERE usr_id=approved_by) as approved_by, approved_date, DATE_ADD(date_sent, INTERVAL ims_purchase.lead_time DAY) as lead_time, ims_purchase.terms FROM ims_purchase
                INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase.supplier
                INNER JOIN ims_users ON ims_users.usr_id=ims_purchase.created_by WHERE purchase_id='" & id & "'"
                Using rdr As MySqlDataReader = New MySqlCommand(query, connection).ExecuteReader
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
                        report.Parameters("vat_rate").Value = rdr("vat_rate") + 1
                        report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                        report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                        report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")
                        orders = rdr("orders")


                        report.lbl_vat.Text = Decimal.Round(CDec(rdr("vat_rate")) * 100, 0) & "% VAT"
                    End While
                End Using

                Using cmd = New MySqlCommand("SELECT unit FROM ims_inventory WHERE winmodel=@winmodel", connection)
                    cmd.Parameters.AddWithValue("@winmodel", String.Empty)
                    cmd.Prepare()

                    'Set Order to DataTable
                    Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(orders)
                    For Each Order In PurchaseOrder
                        cmd.Parameters(0).Value = Order.winmodel
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                table.purchase_order_slip.Rows.Add(
                                    Order.qty,
                                    Order.winmodel,
                                    Order.supmodel,
                                    Order.description,
                                    Order.cost,
                                    Order.total_cost,
                                    rdr("unit"))
                            End While
                        End Using
                    Next
                End Using

                'Sort DataTable
                table.purchase_order_slip.DefaultView.Sort = "supmodel ASC"

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
            Dim sub_total As Decimal = 0.00
            Dim discount_amount As Decimal = 0.00
            Dim vat_excl_purchase As Decimal = 0.00
            Dim grid_dt = DirectCast(grid_purchasing.DataSource, DataTable)
            lbl_noofitems.Text = grid_purchasing_view.RowCount

            'GET Gross Purchase
            For i = 0 To grid_dt.Rows.Count - 1
                If IsDBNull(grid_dt.Rows(i).Item("total")) Then Continue For
                sub_total += grid_dt.Rows(i).Item("total")
            Next

            lbl_gross_purchase.Text = FormatCurrency(sub_total)

            If Not String.IsNullOrEmpty(txt_discount.Text) And Not cbb_discount.SelectedIndex = -1 Then
                If cbb_discount.SelectedIndex = 1 Then 'IF PESO
                    discount_amount = Decimal.Parse(txt_discount.Text)
                ElseIf cbb_discount.SelectedIndex = 2 Then 'IF PERCENT
                    discount_amount = sub_total * (txt_discount.Text / 100)
                End If
                sub_total -= discount_amount
            End If

            'DISPLAY 'Discount' AND 'Total Purchase'
            lbl_discount.Text = FormatCurrency(discount_amount)
            lbl_net_purchase.Text = FormatCurrency(sub_total)

            'COMPUTE and DISPLAY 'Amount NET of VAT' and 'VAT' 
            If cb_vatable.Checked = True Then
                vat_excl_purchase = sub_total / (VAT_RATE + 1)
                lbl_vat_excl_sales.Text = FormatCurrency(vat_excl_purchase)
                lbl_vat_amount.Text = FormatCurrency(vat_excl_purchase * VAT_RATE)
            Else
                lbl_vat_excl_sales.Text = FormatCurrency(0)
                lbl_vat_amount.Text = FormatCurrency(0)
            End If

            'DISPLAY Total Purchase
            lbl_total_purchase_due.Text = FormatCurrency(sub_total)

            If cb_ewt_tax_applied.Checked = True Then

                'DISPLAY EWT Amount
                Dim withholding_tax As Decimal = vat_excl_purchase * CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty) / 100)
                lbl_withholding_tax_amount.Text = FormatCurrency(withholding_tax)
                sub_total -= withholding_tax
            Else
                lbl_withholding_tax_amount.Text = FormatCurrency(0)
            End If

            'DISPLAY Total Amount
            lbl_total.Text = FormatCurrency(sub_total)

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

    'Grid Value Checking | For Null, Empty Values
    Private Function GridCheck()
        Try

            For Each row As DataRow In TryCast(grid_purchasing.DataSource, DataTable).Rows
                If IsDBNull(row.Item("qty")) Or IsDBNull(row.Item("cost")) Then
                    Return False
                End If
            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function

    'SaveData : NEW
    Private Sub SaveData(status As String)

        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Dim ListOfOrders = New List(Of PurchaseOrderClass)

            For Each row As DataRow In DirectCast(grid_purchasing.DataSource, DataTable).Rows
                ListOfOrders.Add(New PurchaseOrderClass With {
                    .is_bundle = row.Item("is_bundle"),
                    .pid = row.Item("sku"),
                    .qty = row.Item("qty"),
                    .qty_per_box = row.Item("qty_per_box"),
                    .masterbox_qty = row.Item("masterbox_qty"),
                    .min_order_qty = row.Item("min_order_qty"),
                    .winmodel = row.Item("winmodel"),
                    .supmodel = row.Item("supmodel"),
                    .brand = row.Item("brand"),
                    .sub_category = row.Item("sub_category"),
                    .description = row.Item("description"),
                    .cost = row.Item("cost"),
                    .total_cost = row.Item("total"),
                    .qty_received = row.Item("qty_received"),
                    .base_price = row.Item("base_price"),
                    .discount = row.Item("discount"),
                    .unit = IIf(IsDBNull(row.Item("unit")), String.Empty, row.Item("unit"))
                })
            Next


            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO ims_purchase (supplier, contact_person, address, deliver_to, orders, is_vatable, vat_rate, discount_val, discount_type,
                                                          is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage, total, terms, lead_time, notes, pub_notes, status, created_by, date_generated)
                                                        VALUES ((SELECT id FROM ims_suppliers WHERE supplier=@supplier), @contact_person, @address, (SELECT store_id FROM ims_stores WHERE store_name=@deliver_to), @orders, @is_vatable, @vat_rate, @discount_val, @discount_type,
                                                          @is_withholding_tax_applied, @withholding_tax_amount, @withholding_tax_percentage, @total, @terms, @lead_time, @notes, @pub_notes, @status, @user_id, CURDATE())", connection)
                    cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text.Trim())
                    cmd.Parameters.AddWithValue("@contact_person", txt_contact.Text.Trim())
                    cmd.Parameters.AddWithValue("@address", txt_del_address.Text.Trim())
                    cmd.Parameters.AddWithValue("@deliver_to", cbb_deliver.Text.Trim())
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@vat_rate", VAT_percentage - 1)
                    cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim())
                    cmd.Parameters.AddWithValue("@discount_type", IIf(cbb_discount.SelectedIndex = 0, Nothing, cbb_discount.Text.Trim))
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_ewt_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim())
                    cmd.Parameters.AddWithValue("@pub_notes", txt_pub_notes.Text.Trim())
                    cmd.Parameters.AddWithValue("@total", CDec(lbl_total.Text.Replace("₱", String.Empty)))
                    cmd.Parameters.AddWithValue("@terms", txt_terms.Text)
                    cmd.Parameters.AddWithValue("@lead_time", txt_lead_time.Text)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@user_id", frm_main.lbl_user_id.Text)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Saved successfully!", vbInformation, "Information")
                        Me.Dispose()
                    End If

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub






    '--- CONTROLS ---

    'btn_save_drafts
    Private Async Sub btn_save_draft_Click(sender As Object, e As EventArgs) Handles btn_save_draft.Click

        'CHECK CELL VALUES
        If GridCheck() = False Then
            MsgBox("Some cells are empty. Please check it first!", vbExclamation, "Empty Cells")
            Return
        End If

        'COMBOBOX CHECKER
        If String.IsNullOrEmpty(cbb_supplier.Text) Or String.IsNullOrEmpty(cbb_deliver.Text) Or grid_purchasing_view.RowCount = 0 Then
            MsgBox("Complete all fields!", vbExclamation, "Validation")
            Return
        End If

        'IF NEW THEN INSERT
        If String.IsNullOrEmpty(txt_poid.Text) Then
            SaveData("Unfinished")
            Return
        End If

        Dim ListOfOrders = New List(Of PurchaseOrderClass)
        Dim purchase_id = txt_poid.Text

        For Each row As DataRow In DirectCast(grid_purchasing.DataSource, DataTable).Rows
            ListOfOrders.Add(New PurchaseOrderClass With {
                .is_bundle = row.Item("is_bundle"),
                .pid = row.Item("sku"),
                .qty = row.Item("qty"),
                .qty_per_box = row.Item("qty_per_box"),
                .masterbox_qty = row.Item("masterbox_qty"),
                .min_order_qty = row.Item("min_order_qty"),
                .winmodel = row.Item("winmodel"),
                .supmodel = row.Item("supmodel"),
                .brand = row.Item("brand"),
                .sub_category = row.Item("sub_category"),
                .description = row.Item("description"),
                .cost = row.Item("cost"),
                .total_cost = row.Item("total"),
                .qty_received = row.Item("qty_received"),
                .base_price = row.Item("base_price"),
                .discount = row.Item("discount"),
                .unit = IIf(IsDBNull(row.Item("unit")), String.Empty, row.Item("unit"))
            })
        Next

        Try
            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET contact_person=@contact_person, address=@address,deliver_to=(SELECT store_id FROM ims_stores WHERE store_name=@deliver_to), status=@status,
                                        orders=@orders, is_vatable=@is_vatable, vat_rate=@vat_rate, discount_val=@discount_val, discount_type=@discount_type, pub_notes=@pub_notes, notes=@notes, 
                                        is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                                        total=@total, terms=@terms, lead_time=@lead_time WHERE purchase_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", CInt(purchase_id.Replace("PO", String.Empty)))
                    cmd.Parameters.AddWithValue("@contact_person", txt_contact.Text.Trim)
                    cmd.Parameters.AddWithValue("@address", txt_del_address.Text.Trim)
                    cmd.Parameters.AddWithValue("@deliver_to", cbb_deliver.Text.Trim)
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@vat_rate", VAT_RATE)
                    cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@discount_type", IIf(cbb_discount.SelectedIndex = 0, Nothing, cbb_discount.Text.Trim))
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_ewt_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@pub_notes", txt_pub_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@total", CDec(Replace(lbl_total.Text, "₱", String.Empty)))
                    cmd.Parameters.AddWithValue("@terms", CInt(txt_terms.Text))
                    cmd.Parameters.AddWithValue("@lead_time", CInt(txt_lead_time.Text))
                    cmd.Parameters.AddWithValue("@status", "Unfinished")

                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Saved successfully!", vbInformation, "Information")
                        Me.Dispose()
                        Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
                    End If

                End Using

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_submit_for_approval
    Private Async Sub btn_approval_Click(sender As Object, e As EventArgs) Handles btn_approval.Click

        'CHECK CELL VALUES
        If GridCheck() = False Then
            MsgBox("Some cells are empty. Please check it first!", vbExclamation, "Empty Cells Found")
            Return
        End If

        'COMBOBOX CHECKER
        If String.IsNullOrEmpty(cbb_supplier.Text) Or String.IsNullOrEmpty(cbb_deliver.Text) Or grid_purchasing_view.RowCount = 0 Then
            MsgBox("Complete all fields!", vbExclamation, "Validation")
            Return
        End If

        'IF NEW THEN INSERT
        If String.IsNullOrEmpty(txt_poid.Text) Then
            SaveData("For Approval")
            Return
        End If

        Dim ListOfOrders = New List(Of PurchaseOrderClass)
        Dim purchase_id = txt_poid.Text
        Dim status = "UNKNOWN STATUS"

        'Define Status
        Select Case lbl_status.Text
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
        If frm_main.lbl_user_role_id.Text = "1" And (lbl_status.Text = "Approved" Or lbl_status.Text = "Sent" Or lbl_status.Text = "Partial" Or lbl_status.Text = "Completed") Then
            status = lbl_status.Text
        End If

        Try

            For Each row As DataRow In DirectCast(grid_purchasing.DataSource, DataTable).Rows
                ListOfOrders.Add(New PurchaseOrderClass With {
                    .is_bundle = row.Item("is_bundle"),
                    .pid = row.Item("sku"),
                    .qty = row.Item("qty"),
                    .qty_per_box = row.Item("qty_per_box"),
                    .masterbox_qty = row.Item("masterbox_qty"),
                    .min_order_qty = row.Item("min_order_qty"),
                    .winmodel = row.Item("winmodel").ToString(),
                    .supmodel = row.Item("supmodel").ToString(),
                    .brand = row.Item("brand").ToString(),
                    .sub_category = row.Item("sub_category").ToString(),
                    .description = row.Item("description").ToString(),
                    .cost = row.Item("cost"),
                    .total_cost = row.Item("total"),
                    .qty_received = row.Item("qty_received"),
                    .base_price = row.Item("base_price"),
                    .discount = row.Item("discount"),
                    .unit = IIf(IsDBNull(row.Item("unit")), String.Empty, row.Item("unit"))
                })
            Next


            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET contact_person=@contact_person, address=@address, deliver_to=(SELECT store_id FROM ims_stores WHERE store_name=@deliver_to), status=@status,
                                        orders=@orders, is_vatable=@is_vatable, vat_rate=@vat_rate, discount_val=@discount_val, discount_type=@discount_type, pub_notes=@pub_notes, notes=@notes,
                                        is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                                        total=@total, terms=@terms, lead_time=@lead_time WHERE purchase_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", CInt(purchase_id.Replace("PO", String.Empty)))
                    cmd.Parameters.AddWithValue("@contact_person", txt_contact.Text.Trim)
                    cmd.Parameters.AddWithValue("@address", txt_del_address.Text.Trim)
                    cmd.Parameters.AddWithValue("@deliver_to", cbb_deliver.Text.Trim)
                    cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@vat_rate", VAT_RATE)
                    cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@discount_type", IIf(cbb_discount.SelectedIndex = 0, Nothing, cbb_discount.Text.Trim))
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_ewt_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@pub_notes", txt_pub_notes.Text.Trim)
                    cmd.Parameters.AddWithValue("@total", CDec(Replace(lbl_total.Text, "₱", String.Empty)))
                    cmd.Parameters.AddWithValue("@terms", CInt(txt_terms.Text))
                    cmd.Parameters.AddWithValue("@lead_time", CInt(txt_lead_time.Text))
                    cmd.Parameters.AddWithValue("@status", status)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Saved successfully!", vbInformation, "Information")
                        Me.Dispose()
                        Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
                    End If

                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_delete
    Private Async Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If MsgBox("Delete this purchase order?", vbQuestion + vbYesNo, "Delete") = vbYes Then
            Dim id = CInt(txt_poid.Text.Replace("PO", String.Empty))

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET deleted='1' WHERE purchase_id='" & id & "' ", connection).ExecuteNonQuery()

                    MsgBox("Successfully deleted!", vbInformation, "Information")
                    Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If
    End Sub

    'Breadcrumbs
    Private Async Sub link_po_list_Click_1(sender As Object, e As EventArgs)
        Me.Close()
        Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        CMS_print.Show(btn_print, New Point(btn_print.Width - CMS_print.Width, btn_print.Height))
    End Sub

    'btn_send
    Private Async Sub btn_send_Click(sender As Object, e As EventArgs) Handles btn_send.Click

        Dim ans = MsgBox("Press 'Yes' to send.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Dim id As Integer = txt_poid.Text.Replace("PO", String.Empty)
            Dim dt = Date.Today.ToString("yyyy-MM-dd")
            Dim i = 0

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status='Sent', date_sent='" & dt & "' WHERE purchase_id='" & id & "' ", connection)
                    i = cmd.ExecuteNonQuery
                End Using

                If i > 0 Then
                    MsgBox("Your Purchase order has been tagged as SENT!", vbInformation, "Information")
                    Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
                    PrintPurchaseOrderSlip(txt_poid.Text.Replace("PO", String.Empty))
                    Me.Close()
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
                    Select Case lbl_status.Text
                        Case "For Approval" : status = "Approved"
                        Case "Revised (Approved)" : status = "Approved"
                        Case "Revised (Sent)" : status = "Sent"
                        Case "Revised (Partial)" : status = "Partial"
                        Case "Revised (Completed)" : status = "Completed"
                    End Select

                Case "Reject"
                    Select Case lbl_status.Text
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
                    cmd.Parameters.AddWithValue("@id", CInt(txt_poid.Text.Replace("PO", String.Empty)))
                    cmd.Parameters.AddWithValue("@approved_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("@approved_date", Date.Today)
                    cmd.Parameters.AddWithValue("@status", status)
                    cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim)
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Purchase Order is " & IIf(Equals("Approve", response), "Approved!", "Rejected!"), vbInformation, "Information")
                Me.DialogResult = DialogResult.OK
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'cbb_discount | Enable/Disable txt_discount && Compute
    Private Sub cbb_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_discount.SelectedIndexChanged
        If Not String.IsNullOrEmpty(txt_discount.Text) Then ComputeTotal()
    End Sub

    'lbl_dispose.Click | Dispose Order when Obsolete
    Private Async Sub lbl_dispose_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_dispose.LinkClicked

        If MsgBox("Press 'Yes' to continue.", vbYesNo + vbQuestion, "Dispose Obsolete Order") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_purchase SET status=@status WHERE purchase_id=" & CInt(txt_poid.Text.Replace("PO", String.Empty)), connection)
                    cmd.Parameters.AddWithValue("@status", "Obsolete")
                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Order was successfully disposed!", vbInformation, "Success")
                Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")

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
    Private Sub cb_tax_applied_Click(sender As Object, e As EventArgs)
        If cb_ewt_tax_applied.Checked = False Then
            cb_vatable.Enabled = True
        Else
            cb_vatable.Enabled = False
            cb_vatable.Checked = True
        End If
        ComputeTotal()
    End Sub

    'IF VATABLE
    Private Sub cb_vatable_CheckedChanged(sender As Object, e As EventArgs)
        If cb_ewt_tax_applied.Checked Then cb_vatable.Checked = True
    End Sub

    'txt_discount | Compute on Changingd in Discount Text
    Private Sub txt_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyUp
        ComputeTotal()
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

    'CONTEXTMENU : Print Purchase Order Slip
    Private Sub CMS_strip_purchase_order_Click(sender As Object, e As EventArgs) Handles CMS_strip_purchase_order.Click
        PrintPurchaseOrderSlip(txt_poid.Text.Replace("PO", String.Empty))
    End Sub

    'CONTEXTMENU : Print Purchase Slip
    Private Sub CMS_strip_purchase_slip_Click(sender As Object, e As EventArgs) Handles CMS_strip_purchase_slip.Click
        Dim id As Integer = txt_poid.Text.Replace("PO", String.Empty)
        PrintPurchaseSlip(id)
    End Sub



    'SET GRID
    Private Function Set_DataTable() As DataTable
        Dim dt = New DataTable
        dt.Columns.Add("is_bundle", GetType(Boolean))
        dt.Columns.Add("sku", GetType(Integer))
        dt.Columns.Add("qty", GetType(Decimal))
        dt.Columns.Add("qty_per_box", GetType(Integer))
        dt.Columns.Add("masterbox_qty", GetType(Integer))
        dt.Columns.Add("min_order_qty", GetType(Integer))
        dt.Columns.Add("winmodel", GetType(String))
        dt.Columns.Add("supmodel", GetType(String))
        dt.Columns.Add("brand", GetType(String))
        dt.Columns.Add("sub_category", GetType(String))
        dt.Columns.Add("description", GetType(String))
        dt.Columns.Add("cost", GetType(Decimal))
        dt.Columns.Add("total", GetType(Decimal))
        dt.Columns.Add("total_received", GetType(Integer))
        dt.Columns.Add("qty_received", GetType(Integer))
        dt.Columns.Add("remaining", GetType(Decimal))
        dt.Columns.Add("base_price", GetType(Decimal))
        dt.Columns.Add("discount", GetType(String))
        dt.Columns.Add("unit", GetType(String))
        Return dt
    End Function

    'Set Units to Grid
    Sub set_grid_data(units As String)

        Dim dt = TryCast(grid_purchasing.DataSource, DataTable)

        If Not String.IsNullOrEmpty(units) Then

            Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(units)
            For Each Order In PurchaseOrder
                dt.Rows.Add(
                            Order.is_bundle,
                            Order.pid,
                            Order.qty,
                            Order.qty_per_box,
                            Order.masterbox_qty,
                            Order.min_order_qty,
                            Order.winmodel,
                            Order.supmodel,
                            Order.brand,
                            Order.sub_category,
                            Order.description,
                            Order.cost,
                            Order.total_cost,
                            Order.qty_received,
                            0,
                            Order.qty - Order.qty_received,
                            Order.base_price,
                            Order.discount,
                            Order.unit
                        )
            Next

            grid_purchasing.DataSource = dt
            ComputeTotal()

        End If

    End Sub

    'GET CURRENT CELL DISCOUNT
    Function GetTotalDiscount() As Decimal
        Dim total_disc As Decimal = 1.0

        Try
            Dim disc_val = IIf(IsDBNull(grid_purchasing_view.GetFocusedRowCellValue(col_discount)), "", grid_purchasing_view.GetFocusedRowCellValue(col_discount))
            Dim disc As String = IIf(IsDBNull(disc_val) Or String.IsNullOrEmpty(disc_val), "0", disc_val)

            If Not IsDBNull(disc) Then
                For Each d As Decimal In disc.Split("/"c)
                    total_disc *= 1 - (d / 100)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return 1 - total_disc

    End Function





    'BUTTON : ADD ITEM
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim item_searched As String = cbb_search.Text

        If Not String.IsNullOrEmpty(item_searched) Then
            Dim not_found_unit = String.Empty, not_active = String.Empty
            Dim dt = TryCast(grid_purchasing.DataSource, DataTable)

            'CHECK IF ALREADY EXIST
            For i = 0 To dt.Rows.Count - 1
                If Equals(dt.Rows(i).Item(5).ToString(), item_searched) Then
                    If MsgBox("Warning! Item already exist." & Environment.NewLine & "Proceed with caution.", vbExclamation + vbYesNo, "Duplicate Entry") = vbNo Then
                        Exit Sub
                    End If
                End If
            Next

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT 
                                ims_inventory.pid, winmodel, supmodel, description, base_price, unit,
                                IFNULL(discount, 0) discount, cost, qty_per_box, masterbox_qty, min_order_qty, brand, sub_category, status 
                                FROM `ims_inventory` 
                                WHERE winmodel=@winmodel", conn)
                        cmd.Parameters.AddWithValue("@winmodel", item_searched)
                        Using rdr = cmd.ExecuteReader
                            If rdr.HasRows Then

                                Dim qty_dialog = New frm_sales_order_qty_dialog
                                If qty_dialog.ShowDialog = DialogResult.OK Then

                                    While rdr.Read
                                        If rdr("status").ToString.Equals("Active") Then
                                            dt.Rows.Add(
                                                    False,
                                                    rdr("pid"),
                                                    CDec(qty_dialog.quantity_entered),
                                                    rdr("qty_per_box"),
                                                    rdr("masterbox_qty"),
                                                    rdr("min_order_qty"),
                                                    rdr("winmodel"),
                                                    rdr("supmodel"),
                                                    rdr("brand"),
                                                    rdr("sub_category"),
                                                    rdr("description"),
                                                    rdr("cost"),
                                                    rdr("cost") * qty_dialog.quantity_entered,
                                                    0,
                                                    0,
                                                    CDec(qty_dialog.quantity_entered),
                                                    rdr("base_price"),
                                                    rdr("discount"),
                                                    rdr("unit"))
                                        Else
                                            not_active += String.Empty & vbCrLf & "   > " & rdr("winmodel") & " is " & rdr("status")
                                        End If
                                    End While

                                    ComputeTotal()

                                    'IF Has Error or Not Active
                                    If Not String.IsNullOrEmpty(not_found_unit) Or Not String.IsNullOrEmpty(not_active) Then
                                        MsgBox(String.Concat("Couldn't import item(s) below:", not_found_unit, not_active), vbExclamation, "Failed")
                                    End If

                                    grid_purchasing_view.MoveLastVisible()
                                    cbb_search.SelectedIndex = -1
                                    cbb_search.Focus()
                                End If
                            Else
                                MsgBox("Item not found!", vbCritical, "Not found")
                            End If
                        End Using
                    End Using

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        Else
            MsgBox("Search box cannot be empty!", vbCritical, "Not Found")
        End If
    End Sub

    'BUTTON : REMOVE ITEM
    Private Sub btn_remove_item_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btn_remove_item.ButtonClick
        grid_purchasing_view.DeleteRow(grid_purchasing_view.FocusedRowHandle)
        ComputeTotal()
    End Sub

    'CBB SEARCH : ENTER
    Private Sub cbb_search_KeyDown(sender As Object, e As KeyEventArgs) Handles cbb_search.KeyDown
        If e.KeyValue = Keys.Enter Then
            btn_add.PerformClick()
        End If
    End Sub

    'GRID PURCHASING : COLUMNS (Qty, Cost)
    Private Sub grid_purchasing_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_purchasing_view.CellValueChanged
        Try

            If e.Column.Name = col_discount.Name Or e.Column.Name = col_base_price.Name Then
                Dim new_cost As Decimal
                Dim base_price As Decimal = grid_purchasing_view.GetFocusedRowCellValue(col_base_price)
                Dim disc_val = IIf(IsDBNull(grid_purchasing_view.GetFocusedRowCellValue(col_discount)), "", grid_purchasing_view.GetFocusedRowCellValue(col_discount))

                If Not Equals(disc_val, "NET") Then
                    Dim discount As Decimal = GetTotalDiscount()
                    new_cost = base_price - (base_price * discount)

                    If e.Column.Equals(col_discount) Or e.Column.Equals(col_base_price) Then
                        grid_purchasing_view.SetFocusedRowCellValue(col_cost2, new_cost)
                        'grid_pricebooks_view.SetFocusedRowCellValue(col_discount, IIf(String.IsNullOrEmpty(disc_val), 0, disc_val))
                    End If

                Else
                    new_cost = grid_purchasing_view.GetFocusedRowCellValue(col_cost2)
                End If

                grid_purchasing_view.SetFocusedRowCellValue(col_cost2, new_cost)
            End If

            If e.Column.Name = col_quantity.Name Or e.Column.Name = col_cost2.Name Then
                If Not IsDBNull(grid_purchasing_view.GetFocusedRowCellValue(col_quantity)) And Not IsDBNull(grid_purchasing_view.GetFocusedRowCellValue(col_cost2)) Then
                    Dim qty As Decimal = grid_purchasing_view.GetFocusedRowCellValue(col_quantity)
                    Dim cost As Decimal = grid_purchasing_view.GetFocusedRowCellValue(col_cost2)
                    grid_purchasing_view.SetFocusedRowCellValue(col_total_amount, qty * cost)
                    ComputeTotal()
                End If

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    Private Sub grid_purchasing_view_CellValueChanging(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_purchasing_view.CellValueChanging
        Try

            If e.Column.Name = col_bundle.Name Then
                Dim val As Boolean = grid_purchasing_view.GetFocusedRowCellValue(col_bundle)
                grid_purchasing_view.SetFocusedRowCellValue(col_cost2, 0.00)
                ComputeTotal()
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub cbb_supplier_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_supplier.EditValueChanged
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT contact_person, terms, lead_time, tax_rate, is_with_tax 
                                            FROM ims_suppliers 
                                            WHERE supplier=@supplier", conn)
                    cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            txt_contact.Text = rdr("contact_person")
                            txt_terms.Text = rdr("terms")
                            txt_lead_time.Text = rdr("lead_time")
                            lbl_withholding_tax_percentage.Text = Decimal.Round(CDec(rdr("tax_rate")) * 100, 0) & "%"
                            cb_ewt_tax_applied.EditValue = rdr("is_with_tax")
                        End While
                    End Using
                End Using
            End Using

            DirectCast(grid_purchasing.DataSource, DataTable).Rows.Clear()
            Load_SearchBox(cbb_supplier.Text)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : IMPORT
    Private Async Sub btn_import2_ClickAsync(sender As Object, e As EventArgs) Handles btn_import.Click

        'cbb Supplier Validation
        If cbb_supplier.SelectedIndex = -1 Then
            MsgBox("Choose supplier to proceed.", vbCritical, "Required")
            Return
        End If

        Dim fd = New OpenFileDialog()
        fd.Title = "Open File Dialog"
        fd.Filter = "Excel file |*.xls;*.xlsx"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim path = fd.FileName

            Try
                ProgressPanel.Visible = True
                Await ImportPO(path)
                ProgressPanel.Visible = False
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Async Function ImportPO(path As String) As Task
        ExcelPackage.LicenseContext = LicenseContext.NonCommercial
        Using package = New ExcelPackage(New IO.FileInfo(path))

            'Initialize
            Dim not_found_unit = String.Empty, not_active = String.Empty
            Dim WorkSheet = package.Workbook.Worksheets(0)
            Dim dt_orderGrid = TryCast(grid_purchasing.DataSource, DataTable)
            Dim dt_searchGrid As New DataTable

            Await Task.Run(Sub()
                               Using connection = New MySqlConnection(str)
                                   connection.Open()
                                   Using cmd = New MySqlCommand("SELECT * FROM ims_inventory", connection)
                                       Dim da = New MySqlDataAdapter(cmd)
                                       da.Fill(dt_searchGrid)
                                   End Using
                               End Using
                           End Sub)

            'Insert Value From WorkSheet
            For i = WorkSheet.Dimension.Start.Row To WorkSheet.Dimension.End.Row
                If Not (String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 1).Value) And String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 2).Value)) Then

                    Dim dr() As DataRow = dt_searchGrid.Select("winmodel='" & WorkSheet.Cells(i, 2).Value & "'")

                    If dr.Length > 0 Then
                        If dr(0).Item("status").ToString().Equals("Active") Then
                            dt_orderGrid.Rows.Add(
                                False,
                                dr(0).Item("pid"),
                                WorkSheet.Cells(i, 1).Value,
                                dr(0).Item("qty_per_box"),
                                dr(0).Item("masterbox_qty"),
                                dr(0).Item("min_order_qty"),
                                dr(0).Item("winmodel"),
                                dr(0).Item("supmodel"),
                                dr(0).Item("brand"),
                                dr(0).Item("sub_category"),
                                dr(0).Item("description"),
                                dr(0).Item("cost"),
                                WorkSheet.Cells(i, 1).Value * dr(0).Item("cost"),
                                0,
                                0,
                                WorkSheet.Cells(i, 1).Value,
                                dr(0).Item("base_price"),
                                IIf(IsDBNull(dr(0).Item("discount")), 0, dr(0).Item("discount")),
                                dr(0).Item("unit")
                            )
                        Else
                            not_active += String.Empty & vbCrLf & "   > " & dr(0).Item("winmodel") & " is " & dr(0).Item("status")
                        End If
                    End If
                End If
            Next

            'grid_order.DataSource = dt
            ComputeTotal()

            'IF Has Error or Not Active
            If Not String.IsNullOrEmpty(not_found_unit) Or Not String.IsNullOrEmpty(not_active) Then
                MsgBox(String.Concat("Couldn't import item(s) below:", not_found_unit, not_active), vbExclamation, "Failed")
            End If

        End Using

    End Function

    Private Sub cb_nonvatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_nonvatable.CheckedChanged
        If cb_nonvatable.Checked Then
            cb_vatable.Checked = False
            cb_ewt_tax_applied.Checked = False
        Else
            cb_vatable.Checked = True
        End If
        ComputeTotal()
    End Sub

    Private Sub cb_vatable_CheckedChanged_1(sender As Object, e As EventArgs) Handles cb_vatable.CheckedChanged
        If cb_vatable.Checked Then
            cb_nonvatable.Checked = False
        Else
            cb_nonvatable.Checked = True
        End If
        ComputeTotal()
    End Sub

    Private Sub cb_ewt_tax_applied_CheckedChanged(sender As Object, e As EventArgs) Handles cb_ewt_tax_applied.CheckedChanged
        If cb_ewt_tax_applied.Checked = True Then
            cb_vatable.Enabled = False
            cb_vatable.Checked = True
        Else
            cb_vatable.Enabled = True
        End If
        ComputeTotal()
    End Sub

    Private Sub btn_recall_Click(sender As Object, e As EventArgs) Handles btn_recall.Click
        If MsgBox("All prices will be set to default, continue?", vbYesNo + vbQuestion, "Confirmation") = MsgBoxResult.Yes Then

            Dim dt = TryCast(grid_purchasing.DataSource, DataTable)

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT base_price, cost, discount FROM ims_inventory WHERE pid=@pid", conn)
                        cmd.Parameters.AddWithValue("@pid", 0)
                        cmd.Prepare()

                        For Each row As DataRow In dt.Rows
                            cmd.Parameters(0).Value = row.Item("sku")
                            Using rdr = cmd.ExecuteReader
                                While rdr.Read
                                    row.Item("base_price") = rdr("base_price")
                                    row.Item("cost") = rdr("cost")
                                    row.Item("discount") = IIf(IsDBNull(rdr("discount")), 0, rdr("discount")) / 100
                                End While
                            End Using
                        Next

                        MsgBox("Updated!", vbInformation, "Information")

                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class