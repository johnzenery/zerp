Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frm_sales_view_quotation

    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection

    Private Property discount_counter = 0




    '--- ONLOAD ----
    Private Sub frm_sales_view_quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AutoCompleteString()
    End Sub




    '--- FUNCTIONS ----

    'Load Data via ID
    Public Sub load_data(id As Integer)
        Try
            LoadCustomers()
            Dim existing_company = String.Empty, discount_type = String.Empty, orders = String.Empty

            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "SELECT * FROM ims_quotations
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_quotations.prepared_by
                                WHERE quotation_id=" & id & " AND is_deleted=0"
                Dim cmd = New MySqlCommand(query, connection)
                Dim rdr = cmd.ExecuteReader

                While rdr.Read

                    Me.Text = "View Quotation #" & id.ToString.PadLeft(5, "0"c) & " - " & rdr("company")
                    lbl_quote_id.Text = lbl_quote_id.Text & id.ToString.PadLeft(5, "0"c)
                    lbl_id.Text = id

                    Select Case rdr("customer_type")
                        Case "new"
                            radio_new.Checked = True
                            cbb_customer.Visible = False
                            txt_customer.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rdr("company"))
                        Case "existing"
                            radio_existing.Checked = True
                            txt_customer.Visible = False
                            existing_company = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(rdr("company"))
                    End Select

                    lbl_date_generated.Text = "Created at " & CDate(rdr("created_at")).ToString("MMM dd, yyyy")
                    lbl_created_by.Text = "Created by " & rdr("first_name")
                    txt_contact_person.Text = rdr("contact_person")
                    txt_no.Text = rdr("contact_no")
                    txt_address.Text = rdr("contact_address")
                    txt_delivery_address.Text = rdr("delivery_address")

                    orders = rdr("order_item")

                    txt_priv_notes.Text = rdr("priv_note")
                    txt_pub_notes.Text = rdr("pub_note")
                    lbl_total.Text = FormatCurrency(rdr("total"))

                    lbl_withholding_tax_percentage.Text = FormatPercent(rdr("withholding_tax_percentage") / 100)
                    lbl_withholding_tax_amount.Text = FormatCurrency(rdr("withholding_tax_amount"))
                    cb_tax_applied.Checked = rdr("is_withholding_tax_applied")
                    cb_vatable.Checked = rdr("is_vatable")

                    If rdr("status").Equals("Pending") Or rdr("status").Equals("Declined") Then
                        btn_transfer.Enabled = False
                        btn_print.Enabled = False
                    ElseIf rdr("status").Equals("Approved") Then
                        If Not (frm_main.lbl_user_role_id.Text = "1" Or frm_main.lbl_user_role_id.Text = "6") Then
                            grid_quotation.ReadOnly = True
                        End If
                    End If

                    cbb_validity.Text = rdr("validity")

                    If rdr("is_term_applied") = True Then
                        cb_apply_terms.Checked = True
                        txt_terms.Text = rdr("terms")
                    Else
                        cb_apply_terms.Checked = False
                    End If

                    If rdr("delivery_fee") > 0 Then
                        txt_delivery_fee.Text = FormatCurrency(rdr("delivery_fee"))
                        lbl_delivery_fee.LinkColor = Color.Red
                        lbl_delivery_fee.Text = "Remove Delivery Fee"
                    End If

                    If Not IsDBNull(rdr("discount_val")) Then txt_discount.Text = rdr("discount_val")
                    If Not IsDBNull(rdr("discount_type")) Then discount_type = rdr("discount_type")
                    cb_vatable.Checked = rdr("is_vatable")
                    If Not IsDBNull(rdr("withholding_tax_percentage")) Then lbl_withholding_tax_percentage.Text = FormatPercent(rdr("withholding_tax_percentage") / 100)
                    If Not IsDBNull(rdr("withholding_tax_amount")) Then lbl_withholding_tax_amount.Text = FormatCurrency(rdr("withholding_tax_amount"))

                End While
                rdr.Close()

            End Using

            data_to_grid(orders, grid_quotation, "display")
            load_remaining_grid()

            If Not String.IsNullOrEmpty(existing_company) Then cbb_customer.Text = existing_company
            cbb_discount.Text = discount_type

            'Set Cost and Margin Column Visible for Admin and OM
            If frm_main.lbl_user_role_id.Text = "1" Or frm_main.lbl_user_role_id.Text = "6" Then
                grid_quotation.Columns(5).ReadOnly = False
                grid_quotation.Columns(3).Visible = True
                grid_quotation.Columns(4).Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()

        Dim STORE_TABLE = "ims_" & frm_main.lbl_user_designation.Text.ToLower.Replace(" ", "_")

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "SELECT winmodel, description FROM " & STORE_TABLE & " RIGHT JOIN ims_inventory ON " & STORE_TABLE & ".pid=ims_inventory.pid"
                Dim cmd = New MySqlCommand(query, connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                model_AutoCompleteString.Clear()
                description_AutoCompleteString.Clear()

                While rdr.Read
                    model_AutoCompleteString.Add(rdr("winmodel"))
                    description_AutoCompleteString.Add(rdr("description"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Compute Total 
    Private Sub ComputeTotal()
        Try
            Dim sub_total As Decimal

            'Get subtotal
            For Each row As DataGridViewRow In grid_quotation.Rows
                sub_total += row.Cells(7).Value
            Next

            If Not String.IsNullOrWhiteSpace(txt_discount.Text) And Not cbb_discount.SelectedIndex = -1 Then
                If cbb_discount.SelectedIndex = 0 Then 'IF PESO
                    sub_total = sub_total - Decimal.Parse(txt_discount.Text)
                ElseIf cbb_discount.SelectedIndex = 1 Then 'IF PERCENT
                    sub_total = sub_total - (sub_total * (txt_discount.Text / 100))
                End If
            End If
            'TAX
            If cb_tax_applied.Checked = True Then
                Dim less_vat_subtotal As Decimal = sub_total / 1.12
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty) / 100)
                lbl_total.Text = FormatCurrency(sub_total - withholding_tax)
                lbl_withholding_tax_amount.Text = FormatCurrency(withholding_tax)
            Else
                lbl_total.Text = FormatCurrency(sub_total, 2)
                lbl_withholding_tax_amount.Text = FormatCurrency(0)
            End If
            'DELIVERY FEE
            If String.IsNullOrEmpty(txt_delivery_fee.Text) Then
                lbl_total.Text = FormatCurrency(sub_total)
            Else
                lbl_total.Text = FormatCurrency(Decimal.Add(sub_total, txt_delivery_fee.Text))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Grid Data
    Private Sub data_to_grid(units As String, table As Object, mode As String)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If table.Rows.Count > 0 Then table.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            Using connection = New MySqlConnection(str)
                connection.Open()

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")
                    Dim cost As Decimal = 0.00

                    Using cmd = New MySqlCommand("SELECT cost FROM ims_inventory WHERE winmodel=@model", connection)
                        cmd.Parameters.AddWithValue("@model", equal(1))
                        cost = cmd.ExecuteScalar
                    End Using

                    Select Case mode
                        Case "display"
                            Dim discounted_price = equal(3) - (equal(3) * (equal(4).Replace("%", String.Empty) / 100))
                            table.Rows.Add(equal(0), equal(1), equal(2), cost, CInt(((discounted_price - cost) / discounted_price) * 100) & "%", equal(3), equal(4), equal(5).Replace(";", String.Empty))
                        Case "print"
                            table.Rows.Add(equal(0), equal(1), equal(2), equal(3), equal(4), equal(5).Replace(";", String.Empty))
                    End Select


                Next
            End Using

            ComputeTotal()

        End If

    End Sub

    'Remaining Grid Load
    Private Sub load_remaining_grid()

        grid_remaining.Rows.Clear()

        Using connection = New MySqlConnection(str)
            connection.Open()

            For i = 0 To grid_quotation.Rows.Count - 2
                Dim model = grid_quotation.Rows(i).Cells(1).Value

                Using cmd = New MySqlCommand(get_query() & " WHERE winmodel=@winmodel", connection)
                    cmd.Parameters.AddWithValue("@winmodel", model)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            grid_remaining.Rows.Add(rdr("other_qty"), rdr("qty"), rdr("onhold"))
                            grid_remaining.CurrentCell = Nothing
                        End While
                    End Using
                End Using
            Next
        End Using

    End Sub

    'Get All Store Tables
    Private Function get_all_store_tables(MyStore As String)
        Dim tables = String.Empty

        Using connection = New MySqlConnection(str)
            connection.Open()
            Using rdr_tbl = New MySqlCommand("SELECT store_name FROM ims_stores", connection).ExecuteReader

                While rdr_tbl.Read
                    Dim store = "ims_" & rdr_tbl("store_name").ToString.ToLower.Replace(" ", "_")
                    If store.Equals(MyStore) Then Continue While
                    tables += store & ","
                End While
            End Using
        End Using

        Return tables

    End Function

    'Concat Queries
    Private Function get_query()

        'Get Active Table
        Dim STORE_TABLE = "ims_" & frm_main.lbl_user_designation.Text.ToLower.Replace(" ", "_")

        'Get All Store's Tables Inventory Except Own
        Dim tables = get_all_store_tables(STORE_TABLE).ToString.Split(",")

        Dim other_qty = String.Empty
        Dim inner_join = String.Empty

        For i = 0 To tables.Length - 2
            other_qty += "IFNULL(" & tables(i) & ".qty,0)"
            inner_join += "LEFT JOIN " & tables(i) & " ON ims_inventory.pid=" & tables(i) & ".pid "
            If Not i = tables.Length - 2 Then
                other_qty += " + "
            End If
        Next

        'Dim query = "SELECT (" & other_qty & ") as other_qty, IFNULL(" & STORE_TABLE & ".qty,0) as qty, IFNULL(" & STORE_TABLE & ".on_hold,0) as onhold, ims_inventory.pid, description, winmodel, status, " & GetAccountTypeTable() & " FROM `ims_inventory` LEFT JOIN " & STORE_TABLE & " ON ims_inventory.pid=" & STORE_TABLE & ".pid " & inner_join
        Dim query = "SELECT (" & other_qty & ") as other_qty, IFNULL(" & STORE_TABLE & ".qty,0) as qty, IFNULL(" & STORE_TABLE & ".on_hold,0) as onhold, ims_inventory.pid, description, winmodel, status, cost, " & GetAccountTypeTable() & " FROM `ims_inventory` LEFT JOIN " & STORE_TABLE & " ON ims_inventory.pid=" & STORE_TABLE & ".pid " & inner_join

        Return query

    End Function

    'Get Account Type
    Private Function GetAccountTypeTable() As Object
        Dim account_type = String.Empty

        Select Case lbl_account_type.Text
            Case "Regular" : account_type = "regular_price"
            Case "Dealer" : account_type = "dealer_price"
            Case "VIP" : account_type = "vip_price"
            Case "Sister Company" : account_type = "cost"
            Case Else
                account_type = "regular_price"
        End Select

        Return If(radio_existing.Checked, account_type, "regular_price")

    End Function

    'Load Customers
    Private Sub LoadCustomers()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT LPAD(customer_id, 3, '0') as customer_id, first_name FROM ims_customers", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_customer.Properties.Items


                Coll.BeginUpdate()

                While rdr.Read
                    Coll.Add(rdr("first_name"))
                End While

                Coll.EndUpdate()

                cbb_customer.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print
    Private Sub print_quotation(id As Integer)
        Dim report = New doc_quotation()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData
        Dim orders = String.Empty

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT *, 
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info, 
                        DATE_ADD(created_at, INTERVAL terms DAY) AS due_date, prepared.first_name AS prepared_name, 
                        approved.first_name AS approved_name FROM ims_quotations 
                        INNER JOIN ims_users AS prepared ON prepared.usr_id=prepared_by
                        INNER JOIN ims_users AS approved ON approved.usr_id=approved_by
                        WHERE quotation_id=" & id
                Dim cmd = New MySqlCommand(query, connection)
                rdr = cmd.ExecuteReader

                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("quotation_id").Value = "Q" & id.ToString.PadLeft(5, "0"c)
                    report.Parameters("company").Value = rdr("company")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("contact_no").Value = rdr("contact_no")
                    report.Parameters("delivery_address").Value = rdr("delivery_address")
                    report.Parameters("total").Value = rdr("total")
                    report.Parameters("pub_notes").Value = rdr("pub_note")
                    report.Parameters("prepared_by").Value = rdr("prepared_name")
                    report.Parameters("approved_name").Value = rdr("approved_name")
                    report.Parameters("store_info").Value = rdr("store_info")
                    report.Parameters("is_term_applied").Value = rdr("is_term_applied")
                    report.Parameters("terms").Value = rdr("terms")
                    report.Parameters("validity").Value = rdr("validity") & " Days"
                    report.Parameters("created_at").Value = rdr("created_at")
                    report.Parameters("due_date").Value = rdr("due_date")
                    report.Parameters("discount_type").Value = rdr("discount_type")
                    report.Parameters("discount_val").Value = rdr("discount_val")

                    report.Parameters("is_vatable").Value = rdr("is_vatable")
                    report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                    report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                    report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")
                    report.Parameters("delivery_charge").Value = IIf(rdr("delivery_fee") > 0, rdr("delivery_fee"), String.Empty)
                    orders = rdr("order_item")
                End While
            End Using

            data_to_grid(orders, table.quotation, "print")

            report.RequestParameters = False
            report.DataSource = table

            printTool.AutoShowParametersPanel = False
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Function: SAVE
    Private Function SaveData(status As String)

        Dim res = False

        'Get Orders
        Dim orders = String.Empty
        For Each row In grid_quotation.Rows
            If String.IsNullOrEmpty(row.Cells(1).value) Then Continue For
            orders += row.Cells(0).value & "=" & row.Cells(1).value &
                "=" & row.Cells(2).value & "=" & row.Cells(5).value &
                "=" & row.Cells(6).Value & "=" & row.Cells(7).Value & ";"
        Next

        'Get Company
        Dim company = String.Empty
        If cbb_customer.Visible = True Then company = cbb_customer.Text
        If txt_customer.Visible = True Then company = txt_customer.Text

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "UPDATE ims_quotations SET company=@company, contact_person=@contact_person,
                        is_vatable=@is_vatable, discount_val=@discount_val, discount_type=@discount_type, is_term_applied=@is_term_applied, terms=@terms,
                        is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                        contact_no=@contact_no, contact_address=@contact_address, delivery_address=@delivery_address, 
                        order_item=@order_item, total=@total, delivery_fee=@delivery_fee,
                        priv_note=@priv_note, pub_note=@pub_note, status=@status WHERE quotation_id=" & lbl_id.Text
                Dim cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@company", company)
                cmd.Parameters.AddWithValue("@contact_person", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_contact_person.Text.Trim))
                cmd.Parameters.AddWithValue("@contact_no", txt_no.Text.Trim)
                cmd.Parameters.AddWithValue("@contact_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_address.Text.Trim))
                cmd.Parameters.AddWithValue("@delivery_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_delivery_address.Text.Trim))
                cmd.Parameters.AddWithValue("@order_item", orders)
                cmd.Parameters.AddWithValue("@total", CDec(lbl_total.Text))
                cmd.Parameters.AddWithValue("@delivery_fee", CDec(IIf(String.IsNullOrEmpty(txt_delivery_fee.Text), Nothing, txt_delivery_fee.Text)))
                cmd.Parameters.AddWithValue("@is_term_applied", cb_apply_terms.Checked)
                cmd.Parameters.AddWithValue("@terms", IIf(cb_apply_terms.Checked, txt_terms.Text, Nothing))
                cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                cmd.Parameters.AddWithValue("@status", status)
                Dim i = cmd.ExecuteNonQuery()

                If i > 0 Then res = True
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return res

    End Function

    'Digits Only
    Private Sub DigitsOnly_KeyPress(sender As Object, e As KeyPressEventArgs)

        If grid_quotation.CurrentCell.ColumnIndex = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If

        End If
    End Sub





    '--- CONTROLS ----

    'Editing Grid
    Private Sub grid_quotation_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_quotation.EditingControlShowing

        AddHandler DirectCast(e.Control, TextBox).KeyPress, AddressOf DigitsOnly_KeyPress

        If Not (grid_quotation.CurrentCell.ColumnIndex = 1 Or grid_quotation.CurrentCell.ColumnIndex = 2) Then
            Dim txt = TryCast(e.Control, TextBox)
            If txt IsNot Nothing Then
                txt.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt = TryCast(e.Control, TextBox)
            Dim columnIndex As Integer = grid_quotation.CurrentCell.ColumnIndex
            If columnIndex <> 1 Then
                If columnIndex = 2 Then
                    If txt IsNot Nothing Then
                        txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                        txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                        txt.AutoCompleteCustomSource = description_AutoCompleteString
                    End If
                End If
            ElseIf txt IsNot Nothing Then
                txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                txt.AutoCompleteCustomSource = model_AutoCompleteString
                txt.CharacterCasing = CharacterCasing.Upper
            End If
        End If

    End Sub

    'Grid Cell End Edit
    Private Sub grid_quotation_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_quotation.CellEndEdit

        If e.ColumnIndex.Equals(1) Then

            'If No Value or Empty Cell Found
            If String.IsNullOrEmpty(grid_quotation.CurrentCell.Value) Then Return

            'Check Duplicates in the List
            For i = 0 To grid_quotation.Rows.Count - 1
                If i = grid_quotation.CurrentRow.Index Then Continue For
                If grid_quotation.CurrentCell.Value.Equals(grid_quotation.Rows(i).Cells(1).Value) Then
                    MsgBox("Already exist!", vbCritical, "Duplicate")
                    grid_quotation.Rows.RemoveAt(grid_quotation.CurrentRow.Index)
                    Exit Sub
                End If
            Next

            Try

                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand(get_query() & " WHERE winmodel=@winmodel", connection)
                    cmd.Parameters.AddWithValue("@winmodel", grid_quotation.CurrentCell.Value)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read

                        'Validation of Unit Status
                        If rdr("status").Equals("For Approval") Or rdr("status").Equals("On-Hold") Then
                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & String.Empty, vbCritical, "Not Active")
                            grid_quotation.Rows.RemoveAt(grid_quotation.CurrentRow.Index)
                            Exit Sub
                        End If

                        If rdr("status").Equals("Discontinued") Then
                            MsgBox("Selected Item is Discontinued." & vbCrLf & "Available only until supply last...", vbInformation, "Discontinued")
                        End If


                        If grid_remaining.Rows.Count > e.RowIndex Then
                            grid_remaining.Rows(e.RowIndex).Cells(0).Value = rdr("other_qty")
                            grid_remaining.Rows(e.RowIndex).Cells(1).Value = rdr("qty")
                            grid_remaining.Rows(e.RowIndex).Cells(2).Value = rdr("onhold")
                        Else
                            grid_remaining.Rows.Add(rdr("other_qty"), rdr("qty"), rdr("onhold"))
                        End If

                        'grid_order.Rows(e.RowIndex).Cells(0).Value = 1
                        grid_quotation.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                        grid_quotation.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                        Dim price As Decimal = rdr(GetAccountTypeTable)
                        Dim cost As Decimal = rdr("cost")
                        grid_quotation.Rows(e.RowIndex).Cells(3).Value = cost
                        grid_quotation.Rows(e.RowIndex).Cells(4).Value = CInt(((price - cost) / price) * 100) & "%"
                        grid_quotation.Rows(e.RowIndex).Cells(5).Value = price.ToString("n2")
                        grid_quotation.Rows(e.RowIndex).Cells(6).Value = "0%"
                        Dim total As Decimal = grid_quotation.Rows(e.RowIndex).Cells(0).Value * price
                        grid_quotation.Rows(e.RowIndex).Cells(7).Value = total.ToString("n2")
                    End While

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        If e.ColumnIndex.Equals(2) Then

            If String.IsNullOrEmpty(grid_quotation.CurrentCell.Value) Then Exit Sub

            For i = 0 To grid_quotation.Rows.Count - 1
                If i = grid_quotation.CurrentRow.Index Then Continue For
                If grid_quotation.CurrentCell.Value.Equals(grid_quotation.Rows(i).Cells(2).Value) Then
                    MsgBox("Already exist!", vbCritical, "Duplicate")
                    grid_quotation.Rows.RemoveAt(grid_quotation.CurrentRow.Index)
                    Exit Sub
                End If
            Next

            Try

                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand(get_query() & " WHERE description=@description", connection)
                    cmd.Parameters.AddWithValue("@description", grid_quotation.CurrentCell.Value)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read

                        'Validation of Unit Status
                        If rdr("status").Equals("For Approval") Or rdr("status").Equals("On-Hold") Then
                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & String.Empty, vbCritical, "Not Active")
                            grid_quotation.Rows.RemoveAt(grid_quotation.CurrentRow.Index)
                            Exit Sub
                        End If

                        If rdr("status").Equals("Discontinued") Then
                            MsgBox("Selected Item is Discontinued." & vbCrLf & "Available only until supply last...", vbInformation, "Discontinued")
                        End If



                        If grid_remaining.Rows.Count > e.RowIndex Then
                            grid_remaining.Rows(e.RowIndex).Cells(0).Value = rdr("other_qty")
                            grid_remaining.Rows(e.RowIndex).Cells(1).Value = rdr("qty")
                            grid_remaining.Rows(e.RowIndex).Cells(2).Value = rdr("onhold")
                        Else
                            grid_remaining.Rows.Add(rdr("other_qty"), rdr("qty"), rdr("onhold"))
                        End If

                        'grid_order.Rows(e.RowIndex).Cells(0).Value = 1
                        grid_quotation.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                        grid_quotation.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                        Dim price As Decimal = rdr(GetAccountTypeTable)
                        Dim cost As Decimal = rdr("cost")
                        grid_quotation.Rows(e.RowIndex).Cells(3).Value = cost
                        grid_quotation.Rows(e.RowIndex).Cells(4).Value = CInt(((price - cost) / price) * 100) & "%"
                        grid_quotation.Rows(e.RowIndex).Cells(5).Value = price.ToString("n2")
                        grid_quotation.Rows(e.RowIndex).Cells(6).Value = "0%"
                        Dim total As Decimal = grid_quotation.Rows(e.RowIndex).Cells(0).Value * price
                        grid_quotation.Rows(e.RowIndex).Cells(7).Value = total.ToString("n2")
                    End While
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If


        If e.ColumnIndex.Equals(0) Or e.ColumnIndex.Equals(5) Or e.ColumnIndex.Equals(6) Then

            Try
                If String.IsNullOrEmpty(grid_quotation.Rows(e.RowIndex).Cells(1).Value) Then Return

                Dim cost As Decimal = 0.00

                If e.ColumnIndex.Equals(5) Then
                    grid_quotation.CurrentCell.Value = CDec(grid_quotation.CurrentCell.Value)
                End If

                If e.ColumnIndex.Equals(6) Then

                    'Discount Counter
                    If discount_counter > 5 Then

                        'Discount Approcal
                        Dim pass As String = String.Empty
                        frm_sales_password_required.ShowDialog()
                        If Not String.IsNullOrEmpty(frm_sales_password_required.Password) Then
                            pass = frm_sales_password_required.Password
                            frm_sales_password_required.Dispose()
                        End If

                        Dim count = 0

                        Using connection = New MySqlConnection(str)
                            connection.Open()
                            Dim cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_users WHERE role_id='1' AND pass=@pass", connection)
                            cmd.Parameters.AddWithValue("@pass", Encrypt(pass))
                            count = cmd.ExecuteScalar
                        End Using

                        If count < 1 Or String.IsNullOrWhiteSpace(pass) Then
                            MsgBox("Password is Incorrect!", vbCritical, "Incorrect Password")
                            grid_quotation.Rows(e.RowIndex).Cells(7).Value = CDec(grid_quotation.Rows(e.RowIndex).Cells(0).Value * grid_quotation.Rows(e.RowIndex).Cells(5).Value).ToString("n2")
                            grid_quotation.Rows(e.RowIndex).Cells(6).Value = "0%"
                            Exit Sub
                        End If

                    End If

                    'Get Cost
                    Using connection = New MySqlConnection(str)
                        connection.Open()
                        Dim cmd = New MySqlCommand("SELECT cost FROM ims_inventory WHERE winmodel=@winmodel", connection)
                        cmd.Parameters.AddWithValue("@winmodel", grid_quotation.Rows(e.RowIndex).Cells(1).Value)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader

                        rdr.Read()
                        cost = rdr("cost")
                        rdr.Close()
                    End Using

                    discount_counter += 1

                End If



                Dim price As Decimal = grid_quotation.Rows(e.RowIndex).Cells(5).Value
                Dim discount As Decimal = grid_quotation.Rows(e.RowIndex).Cells(6).Value.ToString.Replace("%", String.Empty)
                Dim total_price = price - (price * (discount / 100))

                If total_price < cost Then
                    MsgBox("Price is less than of cost!", vbCritical, "Error")
                    grid_quotation.Rows(e.RowIndex).Cells(7).Value = CDec(grid_quotation.Rows(e.RowIndex).Cells(0).Value * price).ToString("n2")
                    grid_quotation.Rows(e.RowIndex).Cells(6).Value = "0%"
                    Exit Sub
                End If

                Dim total As Decimal = grid_quotation.Rows(e.RowIndex).Cells(0).Value * total_price

                grid_quotation.Rows(e.RowIndex).Cells(4).Value = CInt(((total_price - cost) / total_price) * 100) & "%"
                grid_quotation.Rows(e.RowIndex).Cells(7).Value = total.ToString("n2")
                grid_quotation.Rows(e.RowIndex).Cells(6).Value = discount & "%"


            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If


        'Compute Total
        ComputeTotal()

    End Sub

    'Grid Order (Rows Remove)
    Private Sub grid_quotation_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_quotation.RowsRemoved
        Try
            If grid_quotation.Rows.Count > 0 Then
                If grid_remaining.Rows.Count > 0 Then

                    For Each row As DataGridViewRow In grid_remaining.Rows
                        If row.Index = e.RowIndex Then
                            grid_remaining.Rows.RemoveAt(e.RowIndex)
                        End If
                    Next

                End If
                ComputeTotal()
            End If

            If grid_quotation.Rows.Count <= 1 Then
                cbb_customer.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Delete Key
    Private Sub grid_order_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles grid_quotation.PreviewKeyDown
        Try
            If e.KeyCode = Keys.Delete Then
                If grid_quotation.Rows.Count > 1 Then
                    grid_quotation.Rows.RemoveAt(grid_quotation.CurrentCell.RowIndex)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    'btn_approved | Button of Approval
    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        Try
            If MsgBox("Press 'Yes' to continue", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Confirmation") = MsgBoxResult.Yes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_quotations 
                                    SET status='Approved', approved_by=@approved_by, approved_date=CURRENT_TIMESTAMP, 
                                    priv_note=@priv_note, pub_note=@pub_note
                                    WHERE quotation_id=@id", connection)
                        cmd.Parameters.AddWithValue("@approved_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@id", lbl_id.Text)
                        cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                        cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfully Approved!", MsgBoxStyle.Information, "Information")
                        Me.Close()
                    End Using
                End Using
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_decline | Button of Decline
    Private Sub btn_decline_Click(sender As Object, e As EventArgs) Handles btn_decline.Click
        Try
            If MsgBox("Press 'Yes' to continue", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Confirmation") = MsgBoxResult.Yes Then
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_quotations 
                                    SET status='Declined', 
                                    priv_note=@priv_note, pub_note=@pub_note
                                    WHERE quotation_id=@id", connection)
                        cmd.Parameters.AddWithValue("@id", lbl_id.Text)
                        cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                        cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                        cmd.ExecuteNonQuery()
                        MsgBox("Declined!", MsgBoxStyle.Information, "Information")
                        Me.Close()
                    End Using
                End Using
            Else
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_delete
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Do you want to delete this quotation?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_quotations SET is_deleted='1' WHERE quotation_id=" & lbl_id.Text, connection)
                    cmd.ExecuteNonQuery()

                    MsgBox("Successfully Deleted!", vbInformation, "Success")
                    Me.Dispose()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If grid_quotation.Rows.Count > 1 Then
            If cb_apply_terms.Checked Then
                If String.IsNullOrWhiteSpace(txt_terms.Text) Then
                    MsgBox("Terms inputbox must not empty!", MsgBoxStyle.Critical, "Error")
                    Return
                ElseIf txt_terms.Text = 0 Then
                    MsgBox("Invalid terms!", MsgBoxStyle.Critical, "Error")
                    Return
                End If
            End If
            If SaveData("Pending") Then
                MsgBox("Successfully Saved!", MsgBoxStyle.Information, Nothing)
            End If
        Else
            MsgBox("No items to be saved!", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        print_quotation(lbl_id.Text)
    End Sub

    'btn_convert
    Private Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click

        'Set Message based on Checked Radio
        Dim message_str = String.Empty
        If radio_new.Checked Then message_str = "You want it to be converted, right?" & vbCrLf & "*This cannot be undone."
        If radio_existing.Checked Then message_str = "Press 'YES' to confirm."

        If Not MsgBox(message_str, vbQuestion + vbYesNo, "Confirmation") = vbYes Then Exit Sub

        If SaveData("Approved") Then

            Dim is_existing_customer = 0
            Dim is_new_customer = 0

            If radio_new.Checked = True Then

                'Check customer IF ALREADY EXIST
                Try
                    Using connection = New MySqlConnection(str)
                        connection.Open()
                        Dim cmd = New MySqlCommand("SELECT IF( EXISTS( SELECT * FROM ims_customers WHERE first_name = @customer), 1, 0) AS res", connection)
                        cmd.Parameters.AddWithValue("@customer", txt_customer.Text.Trim)
                        is_existing_customer = cmd.ExecuteScalar()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try

                If is_existing_customer = 1 Then
                    MsgBox("This customer is already registered. Proceeding to Sales Order..", vbInformation + vbOKOnly, "Information")
                End If

                If is_existing_customer = 0 Then
                    MsgBox("Register new customer to database first.", vbInformation + vbOKOnly, "Information")

                    Dim new_customer_frm = New frm_sales_customers_new
                    new_customer_frm.txt_fname.Text = txt_customer.Text.Trim
                    new_customer_frm.txt_contact_person.Text = txt_contact_person.Text.Trim
                    new_customer_frm.txt_contact.Text = txt_no.Text
                    new_customer_frm.txt_address.Text = txt_delivery_address.Text
                    new_customer_frm.cbb_account_type.Enabled = False
                    new_customer_frm.panel_admin.Visible = False
                    new_customer_frm.ShowDialog()
                    If new_customer_frm.is_new_customer Then
                        is_new_customer = 1
                    End If
                End If

                If is_new_customer = 1 Or is_existing_customer = 1 Then

                    'Update ims_quotations NEW to EXISTING
                    Try
                        Using connection = New MySqlConnection(str)
                            connection.Open()
                            Dim cmd = New MySqlCommand("UPDATE ims_quotations SET customer_type='existing' WHERE quotation_id=" & lbl_id.Text, connection)
                            cmd.ExecuteNonQuery()
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If

            End If

            'Transfer Data to Order Form
            Dim frm = New frm_sales_order_new
            With frm
                .Show()
                frm.cbb_customer.Text = IIf(radio_new.Checked, txt_customer.Text, cbb_customer.Text)
                frm.txt_priv_notes.Text = txt_priv_notes.Text
                frm.txt_pub_notes.Text = txt_pub_notes.Text
                frm.txt_quote_id.Text = lbl_quote_id.Text.Replace("Quotation #", "Q")
                frm.cbb_discount.SelectedIndex = cbb_discount.SelectedIndex
                frm.txt_discount.Enabled = txt_discount.Enabled
                frm.txt_discount.Text = txt_discount.Text
                frm.cb_vatable.Checked = cb_vatable.Checked
                frm.cb_withholding_tax_applied.Checked = cb_tax_applied.Checked
                'frm.lbl_withholding_tax_percentage.Text = lbl_withholding_tax_percentage.Text
                'frm.lbl_withholding_tax_amount.Text = lbl_withholding_tax_amount.Text
                If Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
                    frm.txt_delivery_fee.Text = FormatCurrency(txt_delivery_fee.Text)
                End If
            End With

            Dim dt = frm.Create_DataSource_gridorder

            'Transfer Grid Quotation Data
            For i = 0 To grid_quotation.Rows.Count - 2
                With grid_quotation
                    dt.Rows.Add(
                                0,
                                .Rows(i).Cells(0).Value,
                                .Rows(i).Cells(1).Value,
                                .Rows(i).Cells(2).Value,
                                .Rows(i).Cells(5).Value,
                                .Rows(i).Cells(6).Value.ToString.Replace("%", ""),
                                .Rows(i).Cells(7).Value)
                End With
            Next

            frm.grid_order.DataSource = dt
            frm.ComputeTotal()
            frm.txt_search.Enabled = False
            frm.grid_order_view.OptionsBehavior.ReadOnly = True = False
            Me.Close()

        End If

    End Sub

    'Load Customer Address with Cbb_customer
    Private Sub cbb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedIndexChanged

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM ims_customers WHERE first_name=@customer", connection)
                cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    txt_contact_person.Text = IIf(IsDBNull(rdr("contact_person")), String.Empty, rdr("contact_person"))
                    txt_no.Text = IIf(rdr("contact") = 0, String.Empty, rdr("contact"))
                    txt_address.Text = IIf(IsDBNull(rdr("address")), String.Empty, rdr("address"))
                    txt_delivery_address.Text = IIf(IsDBNull(rdr("address")), String.Empty, rdr("address"))
                    lbl_account_type.Text = rdr("account_type")
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'cbb_discount.SelectedIndexChanged
    Private Sub cbb_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_discount.SelectedIndexChanged
        If Not cbb_discount.SelectedIndex = -1 Then
            txt_discount.Enabled = True
        Else
            txt_discount.Enabled = False
        End If

        If Not String.IsNullOrEmpty(txt_discount.Text) Then ComputeTotal()

    End Sub

    'IF VATABLE
    Private Sub cb_vatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vatable.CheckedChanged
        If cb_tax_applied.Checked Then cb_vatable.Checked = True
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

    'txt_discount.keyup 
    Private Sub txt_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyUp
        ComputeTotal()
    End Sub

    'cb_apply_terms.CheckedChanged
    Private Sub cb_apply_terms_CheckedChanged(sender As Object, e As EventArgs) Handles cb_apply_terms.CheckedChanged
        If Not cb_apply_terms.Checked Then
            txt_terms.Text = String.Empty
        End If
    End Sub

    'lbl_delivery_fee
    Private Sub lbl_delivery_fee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_delivery_fee.LinkClicked
        Dim total = CDec(lbl_total.Text)
        If Not ((lbl_delivery_fee.LinkColor = Color.Red) And Not String.IsNullOrEmpty(txt_delivery_fee.Text)) Then
            Dim delivery_fee = InputBox("Enter delivery fee below", "Delivery Fee")
            If Not String.IsNullOrWhiteSpace(delivery_fee) Then

                Try
                    total += delivery_fee
                    txt_delivery_fee.Text = FormatCurrency(delivery_fee)
                    lbl_total.Text = FormatCurrency(total, -1, TriState.UseDefault, TriState.UseDefault, TriState.UseDefault)
                Catch ex As Exception
                    MsgBox("Invalid Number Format!", MsgBoxStyle.Critical, "Number Exception")
                End Try

                If Not String.IsNullOrWhiteSpace(txt_delivery_fee.Text) Then
                    lbl_delivery_fee.LinkColor = Color.Red
                    lbl_delivery_fee.Text = "Remove Delivery Fee"
                End If

                ComputeTotal()

            End If
        Else
            total -= CDec(txt_delivery_fee.Text)
            txt_delivery_fee.Text = String.Empty
            lbl_total.Text = FormatCurrency(total)
            lbl_delivery_fee.LinkColor = Color.Blue
            lbl_delivery_fee.Text = "Add Delivery Fee"
            ComputeTotal()
        End If
    End Sub

End Class