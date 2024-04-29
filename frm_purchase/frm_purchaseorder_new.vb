Imports DevExpress.XtraEditors.Controls
Imports MySqlConnector
Imports Newtonsoft.Json
Imports System.IO

Public Class frm_purchaseorder_new

    ReadOnly dt = New DataTable
    Private model_AutoCompleteString As New AutoCompleteStringCollection
    Private description_AutoCompleteString As New AutoCompleteStringCollection



    '--- ON LOAD ---
    Private Sub frm_purchaseorder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Load_Supplier()
        load_locations()
        CreateTable()

    End Sub





    '--- FUNCTIONS ---

    'Set Supplier (AUTOFILL)
    Private Sub Load_Supplier()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim rdr = New MySqlCommand("SELECT supplier FROM `ims_suppliers`", connection).ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_supplier.Properties.Items
                Coll.BeginUpdate()
                Try
                    While rdr.Read
                        Coll.Add(rdr("supplier"))
                    End While
                Finally
                    Coll.EndUpdate()
                End Try

                cbb_supplier.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Deliver Location to ComboBox
    Private Sub load_locations()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim rdr = New MySqlCommand("SELECT store_name FROM `ims_stores`", connection).ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_deliver.Properties.Items
                Coll.BeginUpdate()

                Try
                    While rdr.Read
                        Coll.Add(rdr("store_name"))
                    End While
                Finally
                    Coll.EndUpdate()
                End Try

                cbb_deliver.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set Supplier Details to Textbox
    Private Sub cbb_supplier_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_supplier.SelectedValueChanged

        If cbb_supplier.SelectedIndex > -1 Then

            Try
                grid_order.Enabled = True

                'Clear Grid thru Datasource
                Dim dataSource = TryCast(grid_order.DataSource, DataTable)
                dataSource.Rows.Clear()
                grid_order.DataSource = dataSource

                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("SELECT * FROM `ims_suppliers` WHERE supplier=@supplier", connection)
                    cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read
                        txt_contact.Text = rdr("contact_person")
                        txt_supplier_id.Text = rdr("id")
                        txt_terms.Text = rdr("terms")
                        txt_lead_time.Text = rdr("lead_time")
                        cb_tax_applied.Checked = rdr("is_with_tax")
                        lbl_withholding_tax_percentage.Text = FormatPercent(rdr("tax_rate") / 100)
                    End While

                End Using

                'After Loading Details, Load to Autocomplete the Models
                Load_AutoCompleteString()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If
    End Sub

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT winmodel, description FROM ims_inventory WHERE supplier=@supplier", connection)
                cmd.Parameters.AddWithValue("@supplier", txt_supplier_id.Text)
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

    'Load All Stocks
    Private Sub load_AllStocks()
        grid_stocks.Rows.Clear()

        For i = 0 To grid_order.Rows.Count - 2
            Dim winmodel = grid_order.Rows(i).Cells(3).Value

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim mySqlCommand = New MySqlCommand(get_query() & " WHERE winmodel=@winmodel", connection)
                mySqlCommand.Parameters.AddWithValue("@winmodel", winmodel)
                Using mySqlDataReader As MySqlDataReader = mySqlCommand.ExecuteReader()
                    While mySqlDataReader.Read()
                        grid_stocks.Rows.Add(mySqlDataReader("total_qty"))
                        grid_order.Rows(i).Cells(2).Value = mySqlDataReader("qty_per_box")
                    End While
                End Using
            End Using
        Next

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
                Dim withholding_tax As Decimal = less_vat_subtotal * CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty) / 100)
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
    Private Function get_all_store_tables()
        Dim tables As String = String.Empty

        Using connection = New MySqlConnection(str)
            connection.Open()

            Dim rdr As MySqlDataReader = New MySqlCommand("SELECT store_name FROM ims_stores", connection).ExecuteReader()

            While rdr.Read()
                Dim str As String = String.Concat("ims_", rdr("store_name").ToString().ToLower().Replace(" ", "_"))
                tables = String.Concat(tables, str, ",")
            End While

        End Using

        Return tables
    End Function

    'Query
    Private Function get_query()
        Dim store_tables As String() = get_all_store_tables().ToString().Split(New Char() {","c})
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

    'Clear Fields
    Private Sub ClearFields()

        cbb_supplier.SelectedIndex = -1
        cbb_deliver.SelectedIndex = -1
        txt_contact.Text = String.Empty
        txt_delivery_address.Text = String.Empty
        txt_priv_notes.Text = String.Empty
        txt_pub_notes.Text = String.Empty
        txt_supplier_id.Text = String.Empty
        txt_lead_time.Text = String.Empty
        Dim dataSource As DataTable = TryCast(Me.grid_order.DataSource, DataTable)
        dataSource.Rows.Clear()
        grid_order.DataSource = dataSource
        txt_discount.Text = String.Empty
        txt_discount.Enabled = False
        cbb_discount.SelectedIndex = -1
        cb_payment_first.Checked = False
        lbl_total.Text = "₱0.00"
        txt_terms.Text = String.Empty
        txt_search.Text = String.Empty
        grid_stocks.Rows.Clear()
    End Sub

    'Create DataTable (grid_order)
    Private Sub CreateTable()
        Try
            Dim dataTable = New DataTable()
            dataTable.Columns.Add("sku", GetType(Integer))
            dataTable.Columns.Add("qty", GetType(Double))
            dataTable.Columns.Add("qty_per_box", GetType(Integer))
            dataTable.Columns.Add("winmodel", GetType(String))
            dataTable.Columns.Add("supmodel", GetType(String))
            dataTable.Columns.Add("description", GetType(String))
            dataTable.Columns.Add("cost", GetType(Decimal))
            dataTable.Columns.Add("total", GetType(Decimal))
            grid_order.DataSource = dataTable
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'SaveData
    Private Sub SaveData(status As String)

        'VALIDATION
        If String.IsNullOrEmpty(cbb_supplier.Text) Or String.IsNullOrEmpty(cbb_deliver.Text) Or grid_order.Rows.Count <= 1 Then
            MsgBox("Incomplete Details!", MsgBoxStyle.Critical, "Forbidden")
            Return
        End If

        If Not IsNumeric(txt_terms.Text) Then
            MsgBox("Terms MUST be a number!", MsgBoxStyle.Critical, "Forbidden")
            Return
        End If

        'Dim orders = String.Empty
        Dim ListOfOrders = New List(Of PurchaseOrderClass)

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
                .qty_received = 0
            })

        Next


        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd As MySqlCommand = New MySqlCommand("INSERT INTO ims_purchase (supplier, contact_person, address, deliver_to, orders, is_vatable, discount_val, discount_type,
                                                          is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage, total, terms, lead_time, notes, pub_notes, status, created_by, date_generated, is_payment_first)
                                                        VALUES ((SELECT id FROM ims_suppliers WHERE supplier=@supplier), @contact_person, @address, (SELECT store_id FROM ims_stores WHERE store_name=@deliver_to), @orders, @is_vatable, @discount_val, @discount_type,
                                                          @is_withholding_tax_applied, @withholding_tax_amount, @withholding_tax_percentage, @total, @terms, @lead_time, @notes, @pub_notes, @status, @user_id, CURDATE(), @is_payment_first)", connection)
                cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text.Trim())
                cmd.Parameters.AddWithValue("@contact_person", txt_contact.Text.Trim())
                cmd.Parameters.AddWithValue("@address", txt_delivery_address.Text.Trim())
                cmd.Parameters.AddWithValue("@deliver_to", cbb_deliver.Text.Trim())
                cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                cmd.Parameters.AddWithValue("@is_payment_first", Me.cb_payment_first.Checked)
                cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim())
                cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim())
                cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                cmd.Parameters.AddWithValue("@notes", txt_priv_notes.Text.Trim())
                cmd.Parameters.AddWithValue("@pub_notes", txt_pub_notes.Text.Trim())
                cmd.Parameters.AddWithValue("@total", CDec(lbl_total.Text.Replace("₱", String.Empty)))
                cmd.Parameters.AddWithValue("@terms", txt_terms.Text)
                cmd.Parameters.AddWithValue("@lead_time", txt_lead_time.Text)
                cmd.Parameters.AddWithValue("@status", status)
                cmd.Parameters.AddWithValue("@user_id", frm_main.lbl_user_id.Text)
                cmd.ExecuteNonQuery()

                MsgBox("Successfully Created!", MsgBoxStyle.Information, "Information")

                Me.Dispose()

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Digits Only in Column Qty
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




    '--- CONTROL & EVENTS ---

    'grid_order | Editing Control Swing
    Private Sub grid_order_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_order.EditingControlShowing

        If grid_order.CurrentCell.ColumnIndex = 1 Then
            AddHandler DirectCast(e.Control, TextBox).KeyPress, AddressOf DigitsOnly_KeyPress
        End If

        If Not (grid_order.CurrentCell.ColumnIndex = 3 Or grid_order.CurrentCell.ColumnIndex = 5) Then
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

    'grid_control | Editing Control Swing
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

                            Dim cmd = New MySqlCommand(get_query() & " WHERE winmodel=@winmodel", connection)
                            cmd.Parameters.AddWithValue("@winmodel", grid_order.CurrentCell.Value)
                            Dim rdr As MySqlDataReader = cmd.ExecuteReader

                            If rdr.HasRows Then
                                Using rdr
                                    While rdr.Read

                                        'Validation of Unit Status
                                        If rdr("status").Equals("Active") Then

                                            'SET VALUE TO grid_stocks
                                            If grid_stocks.Rows.Count <= e.RowIndex Then
                                                grid_stocks.Rows.Add(New Object() {rdr("total_qty")})
                                            Else
                                                grid_stocks.Rows(e.RowIndex).Cells(0).Value = rdr("total_qty")
                                            End If

                                            'SET VALUE to grid_order
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

                                        Else
                                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & String.Empty, vbCritical, "Not Active")
                                            grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                                            Return
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

                            Dim cmd = New MySqlCommand(get_query() & " WHERE description=@description", connection)
                            cmd.Parameters.AddWithValue("@description", grid_order.CurrentCell.Value)
                            Dim rdr As MySqlDataReader = cmd.ExecuteReader

                            If rdr.HasRows Then
                                Using rdr
                                    While rdr.Read

                                        'Validation of Unit Status
                                        If rdr("status").Equals("Active") Then

                                            'SET VALUE TO grid_stocks
                                            If grid_stocks.Rows.Count <= e.RowIndex Then
                                                grid_stocks.Rows.Add(New Object() {rdr("total_qty")})
                                            Else
                                                grid_stocks.Rows(e.RowIndex).Cells(0).Value = rdr("total_qty")
                                            End If

                                            'SET VALUE to grid_order
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

                                        Else
                                            MsgBox("Oops! Selected Item is Inactive." & vbCrLf & vbCrLf & "Status: " & rdr("status") & String.Empty, vbCritical, "Not Active")
                                            grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                                            Return
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
                    If IsDBNull(grid_order.Rows(e.RowIndex).Cells(3).Value) Then Exit Sub

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

    'Grid Order Scroll
    Private Sub grid_order_Scroll(sender As Object, e As ScrollEventArgs) Handles grid_order.Scroll
        grid_stocks.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    'txt_discount.keyup 
    Private Sub txt_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyUp
        ComputeTotal()
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

    'btn_clear
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    'ON DELETE
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

    'Breadcrumb
    Private Async Sub link_po_list_Click(sender As Object, e As EventArgs) Handles link_po_list.Click
        Me.Close()
        Await frm_main.LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
    End Sub

    'cbb_deliver.SelectedValueChanged 
    Private Sub cbb_deliver_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_deliver.EditValueChanged

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM `ims_stores` WHERE store_name=@store_name", connection)
                cmd.Parameters.AddWithValue("@store_name", cbb_deliver.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    txt_delivery_address.Text = rdr("store_addr")
                End While

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If GridCheck() Then
            If MsgBox("Press 'YES' to confirm.", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Confirmation") = MsgBoxResult.Yes Then
                SaveData("Unfinished")
            End If
        Else
            MsgBox("Some cells are empty. Please check it first!", vbExclamation, "Emty Cells Found")
        End If
    End Sub

    'btn_import.Click | Import CSV 
    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click

        'cbb Supplier Validation
        If cbb_supplier.SelectedIndex = -1 Then
            MsgBox("Choose supplier to proceed.", vbCritical, "Required")
            Return
        End If

        Dim openFileDialog = New OpenFileDialog() With
          {
             .Title = "Open File Dialog",
             .Filter = "CSV file (*.csv)|*.csv",
             .RestoreDirectory = True,
             .FilterIndex = 2
          }

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            If MsgBox("Click 'Yes' to continue.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                Try
                    'Stream Data from CSV
                    Dim csvData As String = File.ReadAllText(openFileDialog.FileName)
                    'Get grid_order DataTable
                    Dim dataSource As DataTable = DirectCast(grid_order.DataSource, DataTable)

                    Using connection = New MySqlConnection(str)
                        connection.Open()
                        Dim not_found_unit = String.Empty, not_active = String.Empty

                        For Each row As String In csvData.Split(ControlChars.Lf)

                            If Not String.IsNullOrEmpty(row) Then
                                Dim values = row.Split(","c)

                                'SKip if Row is Empty
                                If String.IsNullOrWhiteSpace(values(0)) Or String.IsNullOrWhiteSpace(values(1)) Then Continue For

                                Dim cmd = New MySqlCommand("SELECT * FROM ims_inventory 
                                WHERE winmodel=@winmodel AND supplier=(SELECT id FROM ims_suppliers WHERE supplier=@supname)", connection)
                                cmd.Parameters.AddWithValue("@winmodel", values(1).ToString.Trim)
                                cmd.Parameters.AddWithValue("@supname", cbb_supplier.Text.Trim)

                                Using reader = cmd.ExecuteReader
                                    If Not reader.HasRows Then not_found_unit = vbCrLf & "- " & values(1)

                                    While reader.Read
                                        If reader("status").ToString().Equals("Active") Then
                                            dataSource.Rows.Add(reader("pid"), values(0), 0, reader("winmodel"), reader("supmodel"), reader("description"), reader("cost"), values(0) * reader("cost"))
                                        Else
                                            not_active += String.Empty & vbCrLf & "   > " & reader("winmodel") & " is " & reader("status")
                                        End If

                                    End While
                                End Using

                            End If
                        Next

                        grid_order.DataSource = dataSource
                        ComputeTotal()

                        'IF Has Error or Not Active
                        If Not String.IsNullOrEmpty(not_found_unit) Or Not String.IsNullOrEmpty(not_active) Then
                            MsgBox(String.Concat("Couldn't import item(s) below:", not_found_unit, not_active), vbExclamation, "Failed")
                        End If

                    End Using



                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try

                'Load All Stocks
                load_AllStocks()

            End If
        End If

    End Sub

    'btn_active_orders.Click | Show Active Orders
    Private Sub btn_active_orders_Click(sender As Object, e As EventArgs) Handles btn_active_orders.Click
        If cbb_supplier.SelectedIndex <> -1 Then
            Dim frm As frm_purchaseorder_view_ordered_items = New frm_purchaseorder_view_ordered_items()
            frm.grid_po_view.ActiveFilterString = String.Concat("[Supplier] ='", cbb_supplier.Text, "'")
            frm.Show()
        Else
            MsgBox("Select supplier from the list first!", MsgBoxStyle.Critical, "Supplier Required")
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

    'IF VATABLE
    Private Sub cb_vatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vatable.CheckedChanged
        If cb_tax_applied.Checked Then
            cb_vatable.Checked = True
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

    'btn_approval
    Private Sub btn_approval_Click(sender As Object, e As EventArgs) Handles btn_approval.Click
        If GridCheck() Then
            If MsgBox("Press 'YES' to confirm.", MsgBoxStyle.YesNo Or MsgBoxStyle.Information, "Confirmation") = MsgBoxResult.Yes Then
                SaveData("For Approval")
            End If
        Else
            MsgBox("Some cells are empty. Please check it first!", vbExclamation, "Emty Cells Found")
        End If
    End Sub

    'Search Box
    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim dataSource = DirectCast(grid_order.DataSource, DataTable)
        Dim dataViews = New DataView(dataSource)
        dataSource.DefaultView.RowFilter = String.Concat(New String() {"winmodel LIKE '%", txt_search.Text.Trim(), "%' OR supmodel LIKE '%", txt_search.Text.Trim(), "%' OR description LIKE '%", txt_search.Text.Trim(), "%'"})
        grid_order.DataSource = dataSource
    End Sub

    'Sort
    Private Sub grid_order_Sorted(sender As Object, e As EventArgs) Handles grid_order.Sorted
        Dim dt = DirectCast(grid_order.DataSource, DataTable)
        dt.DefaultView.Sort = "winmodel ASC"
        grid_order.DataSource = dt.DefaultView.ToTable
    End Sub


End Class

