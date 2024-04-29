Imports DevExpress.XtraEditors.Controls
Imports MySqlConnector

Public Class frm_sales_create_order

    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection

    Private Property discount_counter = 0
    Private Property old_price = 0.00
    Private Property terms_value As Integer

    Private Sub frm_sales_create_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AutoCompleteString()
        LoadCustomers()
        cbb_customer.Select()
        If frm_main.user_role_id.Text = "1" Then grid_order.Columns(3).ReadOnly = False
        btn_unserved.Enabled = False
    End Sub




    '--- FUNCTION ----


    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()

        Dim STORE_TABLE = "ims_" & frm_main.user_store.Text.ToLower.Replace(" ", "_")

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "SELECT ims_inventory.winmodel, ims_inventory.description FROM " & STORE_TABLE & " RIGHT JOIN ims_inventory ON " & STORE_TABLE & ".pid=ims_inventory.pid"
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
    Public Sub ComputeTotal()
        Try
            Dim sub_total As Decimal

            For Each row As DataGridViewRow In grid_order.Rows
                sub_total += row.Cells(5).Value
            Next

            If Not String.IsNullOrEmpty(txt_discount.Text) And Not cbb_discount.SelectedIndex = -1 Then
                If cbb_discount.SelectedIndex = 0 Then 'IF PESO
                    sub_total -= Decimal.Parse(txt_discount.Text)
                ElseIf cbb_discount.SelectedIndex = 1 Then 'IF PERCENT
                    sub_total -= (sub_total * (txt_discount.Text / 100))
                End If
            End If

            If cb_tax_applied.Checked = True Then
                Dim less_vat_subtotal As Decimal = sub_total / 1.12
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty) / 100)
                sub_total -= withholding_tax
                lbl_withholding_tax_amount.Text = FormatCurrency(withholding_tax)
            Else
                lbl_withholding_tax_amount.Text = FormatCurrency(0)
            End If


            If Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
                lbl_total.Text = FormatCurrency(sub_total + CDec(txt_delivery_fee.Text))
                lbl_balance.Text = FormatCurrency(sub_total + CDec(txt_delivery_fee.Text) - CDec(lbl_paid_amount.Text))
            Else
                lbl_total.Text = FormatCurrency(sub_total)
                lbl_balance.Text = FormatCurrency(sub_total - CDec(lbl_paid_amount.Text))
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Customers
    Private Sub LoadCustomers()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT LPAD(customer_id, 3, '0') as customer_id, first_name FROM ims_customers WHERE is_deleted='0'", connection)
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

    'Clear All Fields
    Private Sub ClearFields()

        lbl_cid.Text = String.Empty
        cbb_customer.SelectedIndex = -1
        lbl_account_type.Text = String.Empty
        lbl_credits_available.Text = String.Empty
        txt_contact_person.Text = String.Empty
        txt_no.Text = String.Empty

        txt_po_ref.Text = String.Empty
        txt_quote_id.Text = String.Empty

        txt_billing.Text = String.Empty
        cb_same_billing.Checked = False
        txt_shipping.Text = String.Empty
        txt_trucking.Text = String.Empty
        txt_pub_notes.Text = String.Empty
        txt_priv_notes.Text = String.Empty

        grid_order.Rows.Clear()
        grid_remaining.Rows.Clear()

        txt_discount.Text = String.Empty
        txt_discount.Enabled = False
        cbb_discount.SelectedIndex = -1
        lbl_total.Text = "₱ 0.00"

        lbl_balance.Text = FormatCurrency(0)

        lbl_delivery_fee.LinkColor = Color.Blue
        lbl_delivery_fee.Text = "Add Delivery Fee"
        txt_delivery_fee.Text = String.Empty
        cb_vatable.Checked = False
        cb_tax_applied.Checked = False

        btn_unserved.Enabled = False

    End Sub

    'Get All Store Tables
    Private Function get_all_store_tables(MyStore As String)

        Dim tables = String.Empty

        Using connection = New MySqlConnection(str)
            connection.Open()
            Dim tbl_cmd = New MySqlCommand("SELECT store_name FROM ims_stores", connection)
            Dim rdr_tbl As MySqlDataReader = tbl_cmd.ExecuteReader


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
        Dim STORE_TABLE = "ims_" & frm_main.user_store.Text.ToLower.Replace(" ", "_")

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

        Dim query = "SELECT (" & other_qty & ") as other_qty, IFNULL(" & STORE_TABLE & ".qty,0) as qty, IFNULL(" & STORE_TABLE & ".on_hold,0) as onhold, ims_inventory.pid, description, winmodel, status, " & GetAccountTypeTable() & " FROM `ims_inventory` LEFT JOIN " & STORE_TABLE & " ON ims_inventory.pid=" & STORE_TABLE & ".pid " & inner_join

        Return query

    End Function

    'Get Account Type Table
    Private Function GetAccountTypeTable()
        Dim account_type = String.Empty

        Select Case lbl_account_type.Text
            Case "Regular" : account_type = "regular_price"
            Case "Dealer" : account_type = "dealer_price"
            Case "VIP" : account_type = "vip_price"
            Case "Sister Company" : account_type = "cost"
        End Select

        Return account_type

    End Function

    'Digits Only
    Private Sub DigitsOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If grid_order.CurrentCell.ColumnIndex = 0 Then
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If
        End If
    End Sub






    '--- CONTROLS -----


    'Editing Grid
    Private Sub grid_order_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_order.EditingControlShowing

        AddHandler DirectCast(e.Control, TextBox).KeyPress, New KeyPressEventHandler(AddressOf DigitsOnly_KeyPress)

        If Not (grid_order.CurrentCell.ColumnIndex = 1 Or grid_order.CurrentCell.ColumnIndex = 2) Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = DirectCast(e.Control, TextBox)
            If Not grid_order.CurrentCell.ColumnIndex = 1 Then
                If grid_order.CurrentCell.ColumnIndex = 2 Then
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

    'Grid Cell End
    Private Sub grid_order_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_order.CellEndEdit

        'Select Customer First Before Orders
        Try
            If String.IsNullOrEmpty(lbl_cid.Text) Then
                MsgBox("Select Customer First!", vbCritical, "Forbidden")
                grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                Exit Sub
            End If
        Catch ex As Exception
        End Try

        If e.ColumnIndex.Equals(1) Then

            'If No Value or Empty Cell Found
            If String.IsNullOrEmpty(grid_order.CurrentCell.Value) Then Exit Sub

            'Check Duplicates in the List
            For i = 0 To grid_order.Rows.Count - 1
                If i = grid_order.CurrentRow.Index Then Continue For
                If grid_order.CurrentCell.Value.Equals(grid_order.Rows(i).Cells(1).Value) Then
                    MsgBox("Already exist!", vbCritical, "Duplicate")
                    grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                    Exit Sub
                End If
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand(get_query() & " WHERE winmodel=@winmodel", connection)
                    cmd.Parameters.AddWithValue("@winmodel", grid_order.CurrentCell.Value)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read

                        'Validation of Unit Status
                        If rdr("status").Equals("For Approval") Or rdr("status").Equals("On-Hold") Then
                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & String.Empty, vbCritical, "Not Active")
                            grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
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

                        'grid_remaining.CurrentCell = Nothing

                        'grid_order.Rows(e.RowIndex).Cells(0).Value = 1
                        grid_order.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                        grid_order.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                        Dim cost As Decimal = rdr(GetAccountTypeTable())
                        grid_order.Rows(e.RowIndex).Cells(3).Value = cost.ToString("n2")
                        grid_order.Rows(e.RowIndex).Cells(4).Value = "0%"
                        Dim total As Decimal = grid_order.Rows(e.RowIndex).Cells(0).Value * cost
                        grid_order.Rows(e.RowIndex).Cells(5).Value = total.ToString("n2")
                    End While

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        If e.ColumnIndex.Equals(2) Then

            If String.IsNullOrEmpty(grid_order.CurrentCell.Value) Then Exit Sub

            For i = 0 To grid_order.Rows.Count - 1
                If i = grid_order.CurrentRow.Index Then Continue For
                If grid_order.CurrentCell.Value.Equals(grid_order.Rows(i).Cells(2).Value) Then
                    MsgBox("Already exist!", vbCritical, "Duplicate")
                    grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                    Exit Sub
                End If
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand(get_query() & " WHERE description=@description", connection)
                    cmd.Parameters.AddWithValue("@description", grid_order.CurrentCell.Value)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read

                        'Validation of Unit Status
                        If rdr("status").Equals("For Approval") Or rdr("status").Equals("On-Hold") Then
                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & String.Empty, vbCritical, "Not Active")
                            grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
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

                        grid_remaining.CurrentCell = Nothing

                        'grid_order.Rows(e.RowIndex).Cells(0).Value = 1
                        grid_order.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel")
                        Dim cost As Decimal = rdr(GetAccountTypeTable())
                        grid_order.Rows(e.RowIndex).Cells(3).Value = cost.ToString("n2")
                        grid_order.Rows(e.RowIndex).Cells(4).Value = "0%"
                        Dim total As Decimal = grid_order.Rows(e.RowIndex).Cells(0).Value * cost
                        grid_order.Rows(e.RowIndex).Cells(5).Value = total.ToString("n2")
                    End While

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        If e.ColumnIndex.Equals(0) Or e.ColumnIndex.Equals(3) Or e.ColumnIndex.Equals(4) Then


            Try

                'Check if NOT null | Validation
                If String.IsNullOrEmpty(grid_order.Rows(e.RowIndex).Cells(1).Value) Then Exit Sub

                If e.ColumnIndex.Equals(3) Then
                    Try
                        If old_price > CDec(grid_order.CurrentCell.Value) Then
                            Dim ans = MsgBox("Stated price is lower than default." & vbCrLf & "Continue anyway?", vbYesNo + vbExclamation, "Price is lower than default")
                            If Not ans = vbYes Then
                                grid_order.CurrentCell.Value = old_price
                            End If
                        End If
                        grid_order.CurrentCell.Value = CDec(grid_order.CurrentCell.Value)
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If

                Dim cost = 0.00

                If e.ColumnIndex.Equals(4) Then

                    'Discount Counter
                    If Not frm_main.user_role_id.Text.Equals("1") Then 'IF NOT ADMIN
                        If discount_counter > 2 Then

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

                            If Not count >= 1 Or String.IsNullOrWhiteSpace(pass) Then
                                MsgBox("Password is Incorrect!", vbCritical, "Incorrect Password")
                                grid_order.Rows(e.RowIndex).Cells(5).Value = CDec(grid_order.Rows(e.RowIndex).Cells(0).Value * grid_order.Rows(e.RowIndex).Cells(3).Value).ToString("n2")
                                grid_order.Rows(e.RowIndex).Cells(4).Value = "0%"
                                Exit Sub
                            End If

                        End If
                    End If


                    'Get Cost
                    Using connection = New MySqlConnection(str)
                        connection.Open()

                        Dim cmd = New MySqlCommand("SELECT cost FROM ims_inventory WHERE winmodel=@winmodel", connection)
                        cmd.Parameters.AddWithValue("@winmodel", grid_order.Rows(e.RowIndex).Cells(1).Value)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader

                        rdr.Read()
                        cost = rdr("cost")
                        rdr.Close()
                    End Using

                    discount_counter += 1

                End If

                'Computation
                Dim price As Decimal = grid_order.Rows(e.RowIndex).Cells(3).Value
                Dim discount As Decimal = grid_order.Rows(e.RowIndex).Cells(4).Value.ToString.Replace("%", String.Empty)
                Dim total_price = price - (price * (discount / 100))

                If total_price < cost Then
                    MsgBox("Price is less than of cost!", vbCritical, "Error")
                    grid_order.Rows(e.RowIndex).Cells(5).Value = CDec(grid_order.Rows(e.RowIndex).Cells(0).Value * price).ToString("n2")
                    grid_order.Rows(e.RowIndex).Cells(4).Value = "0%"
                    Exit Sub
                End If

                Dim total As Decimal = grid_order.Rows(e.RowIndex).Cells(0).Value * total_price

                grid_order.Rows(e.RowIndex).Cells(5).Value = total.ToString("n2")
                grid_order.Rows(e.RowIndex).Cells(4).Value = discount & "%"


            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

        'Compute Total
        ComputeTotal()

    End Sub

    'Get Old price
    Private Sub grid_order_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_order.CellBeginEdit
        If e.ColumnIndex.Equals(3) Then
            old_price = grid_order.CurrentCell.Value
        End If
    End Sub

    'TextBox Discount
    Private Sub txt_discount_EditValueChanged(sender As Object, e As EventArgs) Handles txt_discount.EditValueChanged
        ComputeTotal()
    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        If Not (String.IsNullOrEmpty(cbb_customer.Text) Or String.IsNullOrEmpty(txt_billing.Text) Or grid_order.Rows.Count = 0) Then

            'Credit Balance Checking
            If CDec(lbl_total.Text) > CDec(lbl_credits_available.Text) And rb_terms.Checked = True Then
                MsgBox("Credit Balance is Low. Can't Proceed!", vbCritical, "Low Balance")
                Exit Sub
            End If

            'Initialization
            Dim payment_type = String.Empty
            Dim shipping_method = String.Empty

            'Get Payment Method
            If rb_cash.Checked Then payment_type = "Cash"
            If rb_epay.Checked Then payment_type = "E-Payment"
            If rb_terms.Checked Then payment_type = "Terms"
            If rb_cheque.Checked Then payment_type = "Cheque"

            'Get Shipping Method
            If rb_pickup.Checked Then shipping_method = "Pickup"
            If rb_deliver.Checked Then shipping_method = "Deliver"

            '// Stocks Checking
            'Dim result = check_stocks()
            'If Not IsNothing(result) Then
            '    MsgBox("Couldn't proceed due to insuffiecient stock." & vbCrLf & result, vbExclamation, "Insufficient Stock")
            '    Exit Sub
            'End If

            'Get Orders to String
            Dim orders = String.Empty
            For Each row In grid_order.Rows
                If String.IsNullOrEmpty(row.Cells(1).value) Then Continue For
                orders += row.Cells(0).value & "=" & row.Cells(1).value & "=" & row.Cells(2).value & "=" & row.Cells(3).value & "=" & row.Cells(4).Value & "=" & row.Cells(5).Value & ";"
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim query = "INSERT INTO ims_orders (customer, agent, bill_to, ship_to, quotation_ref, po_reference, order_item,
                    discount_val, discount_type, is_vatable, invoice_no, is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage, delivery_fee,
                    pub_note, priv_note, status, date_ordered, payment_status, payment_type, shipping_method, amount_due, trucking, terms, sales_agent) 
                    VALUES ((SELECT customer_id FROM ims_customers WHERE first_name=@customer AND is_deleted=0), @agent, @bill_to, @ship_to, @quotation_ref, @po_reference, @order_item,
                    @discount_val, @discount_type, @is_vatable, @invoice_no, @is_withholding_tax_applied, @withholding_tax_amount, @withholding_tax_percentage, @delivery_fee,
                    @pub_note, @priv_note, @status, @date_ordered, @payment_status, @payment_type, @shipping_method, @amount_due, @trucking, @terms, COALESCE((SELECT usr_id FROM ims_users WHERE first_name=@sales_agent),0));
                    UPDATE ims_quotations SET is_converted='1', status='Converted' WHERE quotation_id=@qid"

                    Dim cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@customer", cbb_customer.Text.Trim)
                    cmd.Parameters.AddWithValue("@agent", frm_main.user_id.Text)
                    cmd.Parameters.AddWithValue("@bill_to", txt_billing.Text.Trim)
                    cmd.Parameters.AddWithValue("@ship_to", txt_shipping.Text.Trim)
                    cmd.Parameters.AddWithValue("@po_reference", txt_po_ref.Text.Trim)
                    cmd.Parameters.AddWithValue("@order_item", orders)
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@invoice_no", txt_invoice.Text)
                    cmd.Parameters.AddWithValue("@discount_val", IIf(String.IsNullOrWhiteSpace(txt_discount.Text.Trim), 0.00, txt_discount.Text.Trim))
                    cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                    cmd.Parameters.AddWithValue("@delivery_fee", IIf(String.IsNullOrEmpty(txt_delivery_fee.Text), 0.00, txt_delivery_fee.Text))
                    cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                    cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                    cmd.Parameters.AddWithValue("@terms", txt_terms.Value)
                    cmd.Parameters.AddWithValue("@sales_agent", txt_sales_agent.Text)
                    cmd.Parameters.AddWithValue("@date_ordered", Date.Now)
                    cmd.Parameters.AddWithValue("@status", "Pending")
                    cmd.Parameters.AddWithValue("@payment_type", payment_type)
                    cmd.Parameters.AddWithValue("@payment_status", "UNPAID")
                    cmd.Parameters.AddWithValue("@shipping_method", shipping_method)
                    cmd.Parameters.AddWithValue("@amount_due", CDec(lbl_total.Text))
                    cmd.Parameters.AddWithValue("@trucking", txt_trucking.Text.Trim)
                    cmd.Parameters.AddWithValue("@quotation_ref", IIf(String.IsNullOrEmpty(txt_quote_id.Text), Nothing, txt_quote_id.Text))
                    cmd.Parameters.AddWithValue("@qid", CInt(IIf(String.IsNullOrEmpty(txt_quote_id.Text), 0, txt_quote_id.Text.Replace("Q", String.Empty))))
                    cmd.ExecuteNonQuery()

                    ClearFields()
                    frm_sales_orders.btn_refresh.PerformClick()
                End Using

                MsgBox("Successfully Created!", vbInformation, "Information")

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        Else
            MsgBox("Complete All Fields!", vbCritical, "Error")
            Exit Sub
        End If

    End Sub

    'Grid Order (Rows Remove)
    Private Sub grid_order_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_order.RowsRemoved
        Try
            If grid_order.Rows.Count > 0 Then
                If grid_remaining.Rows.Count > 0 Then

                    For Each row As DataGridViewRow In grid_remaining.Rows
                        If row.Index = e.RowIndex Then
                            grid_remaining.Rows.RemoveAt(e.RowIndex)
                        End If
                    Next

                End If
                ComputeTotal()
            End If

            If grid_order.Rows.Count <= 1 Then
                cbb_customer.Enabled = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Grid Order (Rows Added)
    Private Sub grid_order_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles grid_order.RowsAdded
        If grid_order.Rows.Count > 1 Then
            cbb_customer.Enabled = False
        End If
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

    'Same as Billing CHECKBOX
    Private Sub cb_same_billing_CheckedChanged(sender As Object, e As EventArgs) Handles cb_same_billing.CheckedChanged
        If cb_same_billing.Checked Then
            txt_shipping.Text = txt_billing.Text
            txt_shipping.Enabled = False
        Else
            txt_shipping.Text = String.Empty
            txt_shipping.Enabled = True
        End If
    End Sub

    'btn_clear
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    'Load Customer Address with Cbb_customer
    Private Sub cbb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedIndexChanged

        If cbb_customer.SelectedIndex = -1 Then Return

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT account_type, customer_id, account_type, address, contact_person, contact, terms,
                    trucking_note, credit_limit, used_credit, preferred_shipping, agent.first_name AS sales_agent 
                    FROM ims_customers
                    LEFT JOIN ims_users AS agent ON agent.usr_id=ims_customers.assigned_agent 
                    WHERE ims_customers.first_name=@customer AND is_deleted='0'", connection)
                cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read

                    'RESTRICT OTHER USER FROM CREATING WITH SISTER COMPANY
                    If rdr("account_type").Equals("Sister Company") Then
                        Dim current_user As String = frm_main.user_role_id.Text
                        If Not (current_user = "1" Or current_user = "2" Or current_user = "3" Or current_user = "4" Or current_user = "6") Then
                            MsgBox("Insufficient priviledge!" & Environment.NewLine & "Kindly contact your administrator.", MsgBoxStyle.Critical, "Forbidden")
                            ClearFields()
                            Return
                        End If
                    End If

                    lbl_cid.Text = rdr("customer_id")
                    lbl_account_type.Text = rdr("account_type")
                    txt_billing.Text = rdr("address")
                    txt_contact_person.Text = rdr("contact_person")
                    txt_no.Text = rdr("contact")
                    txt_terms.Value = CInt(rdr("terms"))
                    terms_value = rdr("terms")
                    txt_sales_agent.Text = IIf(IsDBNull(rdr("sales_agent")), Nothing, rdr("sales_agent"))
                    txt_trucking.Text = rdr("trucking_note")
                    lbl_credits_available.Text = FormatCurrency(CDec(rdr("credit_limit")) - CDec(rdr("used_credit")), 2)
                    Select Case rdr("preferred_shipping")
                        Case "Pickup" : rb_pickup.Checked = True
                        Case "Delivery" : rb_deliver.Checked = True
                    End Select

                    btn_unserved.Enabled = True

                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Grid Scrolling
    Private Sub grid_order_Scroll(sender As Object, e As ScrollEventArgs) Handles grid_order.Scroll
        grid_remaining.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    'Shortcut Keys
    Private Sub frm_sales_create_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1 : cbb_customer.Select()
            Case Keys.F2 : grid_order.Select()
            Case Keys.F8 : btn_create.PerformClick()
            Case Keys.Escape : Me.Dispose()
        End Select
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
        If cb_tax_applied.Checked Then
            cb_vatable.Checked = True
        End If

        If cb_vatable.Checked = True Then
            lbl_invoice.Visible = True
            txt_invoice.Visible = True
        Else
            lbl_invoice.Visible = False
            txt_invoice.Visible = False
        End If

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

    'lbl_delivery_fee.LinkClicked | Delivery Fee
    Private Sub lbl_delivery_fee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_delivery_fee.LinkClicked

        Dim _total = CDec(lbl_total.Text)

        If lbl_delivery_fee.LinkColor = Color.Red And Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
            _total -= CDec(txt_delivery_fee.Text)

            txt_delivery_fee.Text = String.Empty
            lbl_total.Text = FormatCurrency(_total)

            lbl_delivery_fee.LinkColor = Color.Blue
            lbl_delivery_fee.Text = "Add Delivery Fee"
            ComputeTotal()
            Exit Sub
        End If


        Dim _del_fee = InputBox("Enter delivery fee below", "Delivery Fee")

        If Not String.IsNullOrWhiteSpace(_del_fee) Then
            Try
                _total += CDec(_del_fee)

                txt_delivery_fee.Text = FormatCurrency(_del_fee)
                lbl_total.Text = FormatCurrency(_total)

            Catch ex As Exception
                MsgBox("Invalid Number Format!", vbCritical, "Number Exception")
            End Try

            If Not String.IsNullOrWhiteSpace(txt_delivery_fee.Text) Then
                lbl_delivery_fee.LinkColor = Color.Red
                lbl_delivery_fee.Text = "Remove Delivery Fee"
            End If

            ComputeTotal()
        Else
            Exit Sub
        End If

    End Sub

    'terms Key up
    Private Sub txt_terms_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_terms.KeyUp
        If Not frm_main.user_role_id.Text.Equals("1") Then
            If txt_terms.Value > terms_value Then
                MsgBox("Longer terms than default is detected!" & vbCrLf & "Please contact your administrator.", MsgBoxStyle.Critical, "Terms higher than default")
                txt_terms.Value = terms_value
                Return
            End If
        End If
    End Sub

    Private Sub grid_order_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles grid_order.CellClick

        'UNSERVED ITEM
        If e.ColumnIndex.Equals(6) Then

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    'CHECK IF EXIST
                    Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_sales_unserved_items 
                                                WHERE item=(SELECT pid FROM ims_inventory WHERE winmodel=@item) AND status='Unserved'", conn)
                        cmd.Parameters.AddWithValue("@item", grid_order.Rows(e.RowIndex).Cells(1).Value)
                        If cmd.ExecuteScalar > 0 Then
                            MsgBox("Duplicate item found in Unserved List!", vbCritical, "Duplicate")
                            Return
                        End If
                    End Using

                    'INSERT
                    If MsgBox("Add to Unserved List?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                        Using cmd = New MySqlCommand("INSERT INTO ims_sales_unserved_items (customer_id, qty, item, created_at, status) VALUES
                                                (@customer_id, @qty, (SELECT pid FROM ims_inventory WHERE winmodel=@item), NOW(), 'Unserved')", conn)
                            cmd.Parameters.AddWithValue("@customer_id", lbl_cid.Text)
                            cmd.Parameters.AddWithValue("@qty", grid_order.Rows(e.RowIndex).Cells(0).Value)
                            cmd.Parameters.AddWithValue("@item", grid_order.Rows(e.RowIndex).Cells(1).Value)

                            If cmd.ExecuteNonQuery() = 1 Then
                                MsgBox("Added!", vbInformation, "Information")
                                grid_order.Rows.RemoveAt(e.RowIndex)
                            End If

                        End Using
                    End If

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    Private Sub btn_unserved_Click(sender As Object, e As EventArgs) Handles btn_unserved.Click
        Dim frm = New frm_sales_unserved_dialog
        frm.cid = lbl_cid.Text
        frm.Show()
    End Sub

End Class