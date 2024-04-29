Imports DevExpress.XtraEditors.Controls
Imports MySqlConnector
Imports System.Globalization

Public Class frm_sales_create_quotation

    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection

    Private Property discount_counter = 0


    '--- ONLOAD ---
    Private Sub frm_sales_create_quotation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AutoCompleteString()
        Load_Customer_list()
        If frm_main.lbl_user_role_id.Text = "1" Or frm_main.lbl_user_role_id.Text = "6" Then
            grid_quotation.Columns(5).ReadOnly = False
            grid_quotation.Columns(3).Visible = True
            grid_quotation.Columns(4).Visible = True
        End If
    End Sub





    '--- FUNCTION ----

    'Load Customers
    Private Sub Load_Customer_list()
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

    'Get All Store Tables
    Private Function get_all_store_tables(MyStore As String)
        Dim tables = String.Empty

        Using connection = New MySqlConnection(str)
            connection.Open()

            Dim rdr_tbl = New MySqlCommand("SELECT store_name FROM ims_stores", connection).ExecuteReader

            While rdr_tbl.Read
                Dim store = "ims_" & rdr_tbl("store_name").ToString.ToLower.Replace(" ", "_")
                If store.Equals(MyStore) Then Continue While
                tables += store & ","
            End While
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
        End Select

        Return If(Not radio_new.Checked, account_type, "regular_price")

    End Function

    'Clear All Fields
    Private Sub ClearFields()
        cbb_customer.SelectedIndex = -1
        cbb_validity.SelectedIndex = 0
        txt_customer.Text = String.Empty
        txt_contact_person.Text = String.Empty
        txt_no.Text = String.Empty
        txt_address.Text = String.Empty
        txt_delivery_address.Text = String.Empty
        lbl_account_type.Text = "N/A"
        txt_terms.Text = String.Empty

        grid_quotation.Rows.Clear()
        grid_remaining.Rows.Clear()

        txt_pub_notes.Text = String.Empty
        txt_priv_notes.Text = String.Empty

        lbl_delivery_fee.LinkColor = Color.Blue
        lbl_delivery_fee.Text = "Add Delivery Fee"
        txt_delivery_fee.Text = String.Empty

        cb_apply_terms.Checked = False
        cbb_discount.SelectedIndex = -1
        txt_discount.Text = String.Empty
        cb_tax_applied.Checked = False
        lbl_total.Text = "₱0.00"
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

                    End Using

                    discount_counter += 1

                End If



                Dim price As Decimal = grid_quotation.Rows(e.RowIndex).Cells(5).Value
                Dim discount As Decimal = grid_quotation.Rows(e.RowIndex).Cells(6).Value.ToString.Replace("%", String.Empty)
                Dim discounted_price = price - (price * (discount / 100))

                If discounted_price < cost Then
                    MsgBox("Price is less than of cost!", vbCritical, "Error")
                    grid_quotation.Rows(e.RowIndex).Cells(7).Value = CDec(grid_quotation.Rows(e.RowIndex).Cells(0).Value * price).ToString("n2")
                    grid_quotation.Rows(e.RowIndex).Cells(6).Value = "0%"
                    Exit Sub
                End If

                Dim total As Decimal = grid_quotation.Rows(e.RowIndex).Cells(0).Value * discounted_price

                grid_quotation.Rows(e.RowIndex).Cells(4).Value = CInt(((discounted_price - cost) / discounted_price) * 100) & "%"
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
    Private Sub grid_order_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_quotation.RowsRemoved
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

    'radio_new
    Private Sub radio_new_CheckedChanged(sender As Object, e As EventArgs) Handles radio_new.CheckedChanged
        If radio_new.Checked = True Then
            cbb_customer.Visible = False
            txt_customer.Visible = True
        Else
            cbb_customer.Visible = True
            txt_customer.Visible = False
        End If
        ClearFields()
        txt_contact_person.Text = String.Empty
        lbl_account_type.Text = "N/A"
    End Sub

    'Load Customer Address with Cbb_customer
    Private Sub cbb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedIndexChanged

        If cbb_customer.SelectedIndex = -1 Then Return

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT * FROM ims_customers WHERE first_name=@customer AND is_deleted='0'", connection)
                cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)

                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    While rdr.Read

                        'RESTRICT OTHER USER FROM CREATING WITH SISTER COMPANY
                        If rdr("account_type").Equals("Sister Company") Then
                            Dim current_user As String = frm_main.lbl_user_role_id.Text
                            If Not (current_user = "1" Or current_user = "2" Or current_user = "3" Or current_user = "4" Or current_user = "6") Then
                                MsgBox("Insufficient priviledge!" & Environment.NewLine & "Kindly contact your administrator.", MsgBoxStyle.Critical, "Forbidden")
                                ClearFields()
                                Return
                            End If
                        End If

                        txt_contact_person.Text = IIf(IsDBNull(rdr("contact_person")), String.Empty, rdr("contact_person"))
                        txt_no.Text = IIf(rdr("contact").Equals("0"), String.Empty, rdr("contact"))
                        txt_address.Text = IIf(IsDBNull(rdr("address")), String.Empty, rdr("address"))
                        txt_delivery_address.Text = IIf(IsDBNull(rdr("address")), String.Empty, rdr("address"))
                        lbl_account_type.Text = rdr("account_type")
                    End While
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_create
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        Dim ans = MsgBox("Press 'YES' to create.", vbInformation + vbYesNo, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        'Validation
        If radio_new.Checked = True Then
            If String.IsNullOrEmpty(txt_customer.Text) Or String.IsNullOrEmpty(txt_contact_person.Text) Or grid_quotation.Rows.Count <= 1 Or cbb_validity.SelectedIndex = -1 Then
                MsgBox("Complete All Fields!", vbCritical, "Error")
                Exit Sub
            End If
        End If

        If radio_existing.Checked = True Then
            If String.IsNullOrEmpty(cbb_customer.Text) Or String.IsNullOrEmpty(txt_contact_person.Text) Or grid_quotation.Rows.Count <= 1 Or cbb_validity.SelectedIndex = -1 Then
                MsgBox("Complete All Fields!", vbCritical, "Error")
                Exit Sub
            End If
        End If

        'Get Orders to String
        Dim orders = String.Empty
        For Each row In grid_quotation.Rows
            If String.IsNullOrEmpty(row.Cells(1).value) Then Continue For
            orders += row.Cells(0).value & "=" & row.Cells(1).value &
                "=" & row.Cells(2).value & "=" & row.Cells(5).value &
                "=" & row.Cells(6).Value & "=" & row.Cells(7).Value & ";"
        Next

        'Get Customer Type & Name
        Dim customer_type = String.Empty
        Dim customer = String.Empty
        If radio_new.Checked = True Then
            customer_type = "new"
            customer = txt_customer.Text.Trim
        End If
        If radio_existing.Checked = True Then
            customer_type = "existing"
            customer = cbb_customer.Text
        End If

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "INSERT INTO ims_quotations (customer_type, company, contact_person, contact_no, contact_address, delivery_address, order_item,
                        discount_val, discount_type, is_vatable, is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage,
                        total, delivery_fee, priv_note, pub_note, prepared_by, created_at, status, is_term_applied, terms, validity)
                        VALUES (@customer_type, @company, @contact_person, @contact_no, @contact_address, @delivery_address, @order_item,
                        @discount_val, @discount_type, @is_vatable, @is_withholding_tax_applied, @withholding_tax_amount, @withholding_tax_percentage,
                        @total, @delivery_fee, @priv_note, @pub_note, @prepared_by, CURRENT_TIMESTAMP, 'Pending', @is_term_applied, @terms, @validity)"

                Dim cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@customer_type", customer_type)
                cmd.Parameters.AddWithValue("@company", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(customer))
                cmd.Parameters.AddWithValue("@contact_person", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_contact_person.Text.Trim))
                cmd.Parameters.AddWithValue("@contact_no", txt_no.Text.Trim)
                cmd.Parameters.AddWithValue("@contact_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_address.Text.Trim))
                cmd.Parameters.AddWithValue("@delivery_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_delivery_address.Text.Trim))
                cmd.Parameters.AddWithValue("@order_item", orders)
                cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@discount_type", IIf(String.IsNullOrEmpty(cbb_discount.Text), Nothing, cbb_discount.Text))
                cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                cmd.Parameters.AddWithValue("@total", CDec(lbl_total.Text))
                cmd.Parameters.AddWithValue("@delivery_fee", CDec(IIf(String.IsNullOrEmpty(txt_delivery_fee.Text), Nothing, txt_delivery_fee.Text)))
                cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@prepared_by", frm_main.lbl_user_id.Text)
                cmd.Parameters.AddWithValue("@is_term_applied", cb_apply_terms.Checked)
                cmd.Parameters.AddWithValue("@terms", IIf(cb_apply_terms.Checked, txt_terms.Text, 0))
                cmd.Parameters.AddWithValue("@validity", cbb_validity.Text)
                Dim inserted = cmd.ExecuteNonQuery()
            End Using

            MsgBox("Successfully Created!", vbInformation, "Information")
            ClearFields()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_clear
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
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