Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_sales_return_new

    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection


    '--- ONLOAD ---

    Private Sub frm_sales_return_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Initialize()
    End Sub





    '--- FUNCTION ----

    'INITIALIZE
    Private Sub Initialize()
        Load_AutoCompleteString()
        LoadCustomers()
        Load_Warehouse()
        cbb_customer.Select()
        If frm_main.lbl_user_role_id.Text = "1" Then
            grid_return.Columns(3).ReadOnly = False
        End If
    End Sub

    'Load Warehouse to ComboBox
    Private Sub Load_Warehouse()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_stores", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_warehouse.Properties.Items.Add(rdr("store_name"))
                        End While
                    End Using
                End Using

                cbb_warehouse.SelectedText = frm_main.lbl_user_designation.Text
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Information")
        End Try
    End Sub

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()

        Dim STORE_TABLE = "ims_" & frm_main.lbl_user_designation.Text.ToLower.Replace(" ", "_")

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT winmodel, description FROM ims_inventory" '& STORE_TABLE & " RIGHT JOIN ims_inventory ON " & STORE_TABLE & ".pid=ims_inventory.pid"
                Dim cmd = New MySqlCommand(query, conn)
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

    'Load Customers
    Public Sub LoadCustomers()
        If cbb_customer.Properties.Items.Count = 0 Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim cmd = New MySqlCommand("SELECT first_name FROM ims_customers WHERE is_deleted='0'", conn)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read
                        cbb_customer.Properties.Items.Add(rdr("first_name"))
                    End While

                    'Set to None
                    cbb_customer.SelectedIndex = -1

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'Clear
    Private Sub ClearFields()
        cbb_customer.SelectedIndex = -1
        txt_customer_id.Text = String.Empty
        lbl_account_type.Text = String.Empty
        grid_return.Rows.Clear()
        lbl_total.Text = FormatCurrency(0)
    End Sub

    'Compute Total 
    Public Sub ComputeTotal()
        Try
            Dim sub_total As Decimal

            For Each row As DataGridViewRow In grid_return.Rows
                sub_total += row.Cells(5).Value
            Next

            lbl_total.Text = FormatCurrency(sub_total)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Digits Only
    Private Sub DigitsOnly_KeyPress(sender As Object, e As KeyPressEventArgs)

        If grid_return.CurrentCell.ColumnIndex = 0 Then

            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not e.KeyChar = "." Then
                e.Handled = True
            End If

        End If
    End Sub

    'Edit Sales Return
    Public Sub LoadEdit(id As Integer)

        Initialize()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim status = String.Empty, orders = String.Empty

                Using rdr = New MySqlCommand("SELECT ims_customers.first_name AS customer, ims_customers.account_type, units, ims_stores.store_id, status, created_at, ims_stores.store_name, IFNULL(notes, '') notes, IFNULL(reference, '') reference
                            FROM ims_sales_returns 
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_sales_returns.store_id
                            LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                            WHERE sales_return_id=" & id, conn).ExecuteReader
                    While rdr.Read
                        txt_srid.Text = id
                        cbb_customer.Text = rdr("customer")
                        cbb_warehouse.EditValue = rdr("store_name")
                        lbl_store_id.Text = rdr("store_id")
                        lbl_account_type.Text = rdr("account_type")
                        lbl_date_generated.Text = CDate(rdr("created_at")).ToLongDateString
                        txt_notes.Text = rdr("notes")
                        txt_reference.Text = rdr("reference")
                        status = rdr("status")
                        orders = rdr("units")
                    End While
                End Using

                'Set Items to Grid
                Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesReturnClass))(orders)
                For Each item In itemsObject
                    grid_return.Rows.Add(item.qty, item.model, item.description, item.tax_type, item.unit_price, item.total_amount, item.pid, item.purchase_date, item.last_qty, item.cost)
                Next


                'Update GUI for EDITING
                Me.Text = "Edit Sales Return"
                'lbl_title.Text = "Edit Sales Return"
                btn_create.Visible = False
                btn_clear.Visible = False
                btn_save.Visible = True
                btn_delete.Visible = True
                btn_save.Location = btn_create.Location
                btn_delete.Location = btn_clear.Location
                cbb_customer.ReadOnly = True

                If status.Equals("Received") Then
                    btn_print.Enabled = True
                    btn_save.Enabled = False
                End If

                ComputeTotal()
                Set_Restrictions()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Set_Restrictions()

        Dim user_role_id As Integer = frm_main.lbl_user_role_id.Text
        If lbl_account_type.Text.Equals("Sister Company") And Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then
            col_cost.Visible = False
            col_totalcost.Visible = False
            lbl_total.Visible = False
        Else
            col_cost.Visible = True
            col_totalcost.Visible = True
            lbl_total.Visible = True
        End If

    End Sub

    'Get Account Type Table
    Private Function GetAccountTypeTable()
        Dim account_type = String.Empty

        Select Case lbl_account_type.Text
            Case "Regular" : account_type = "regular_price"
            Case "Dealer" : account_type = "dealer_price"
            Case "VIP" : account_type = "vip_price"
            Case "Sister Company" : account_type = "cost"
            Case Else : account_type = "regular_price"
        End Select

        Return account_type

    End Function

    'Check Grid Values
    Private Function CheckGridValue()

        For i = 0 To grid_return.Rows.Count - 2
            If Not (String.IsNullOrEmpty(grid_return.Rows(i).Cells(0).Value) Or String.IsNullOrEmpty(grid_return.Rows(i).Cells(4).Value)) Then
                If grid_return.Rows(i).Cells(0).Value < 1 Or grid_return.Rows(i).Cells(4).Value < 1 Then
                    MsgBox("Grid values MUST NOT equal to ZERO!", vbExclamation, "Error")
                    Return True
                End If
            Else
                MsgBox("Incomplete grid values!", vbExclamation, "Error")
                Return True
            End If
        Next

        Return False

    End Function





    '--- CONTROLS ----

    'Editing Grid
    Private Sub grid_return_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_return.EditingControlShowing

        AddHandler DirectCast(e.Control, TextBox).KeyPress, New KeyPressEventHandler(AddressOf DigitsOnly_KeyPress)

        If Not (grid_return.CurrentCell.ColumnIndex = 1 Or grid_return.CurrentCell.ColumnIndex = 2) Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = DirectCast(e.Control, TextBox)
            If Not grid_return.CurrentCell.ColumnIndex = 1 Then
                If grid_return.CurrentCell.ColumnIndex = 2 Then
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
    Private Sub grid_return_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_return.CellEndEdit

        'Model
        If e.ColumnIndex.Equals(1) Then

            'If No Value or Empty Cell Found
            If String.IsNullOrEmpty(grid_return.CurrentCell.Value) Then Exit Sub

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim cmd = New MySqlCommand("SELECT qty, item, inv.winmodel, inv.description, purchase_date, (ims_sales.price / ims_sales.qty) as price, ims_sales.cost,
                                                IF(ims_orders.is_vatable='1', IF(is_vat_exempt='1', 'VAT Exempt', IF(is_vat_zero='1', 'VAT Zero Rated', 'VAT')), 'Non-VAT') tax_type " & 'inv. & GetAccountTypeTable() & " AS price" &
                                               " FROM ims_sales
                                                LEFT JOIN ims_inventory inv ON inv.pid=ims_sales.item
                                                LEFT JOIN ims_orders ON ims_orders.order_id=ims_sales.order_id
                                                WHERE inv.winmodel=@winmodel AND ims_sales.customer=@customer_id
                                                ORDER BY purchase_date DESC
                                                LIMIT 1", conn)
                    cmd.Parameters.AddWithValue("@winmodel", grid_return.CurrentCell.Value)
                    cmd.Parameters.AddWithValue("@customer_id", txt_customer_id.Text)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    If rdr.HasRows Then
                        While rdr.Read

                            Dim first_item_vat_type As String = String.Empty
                            If grid_return.Rows.Count > 2 Then
                                first_item_vat_type = grid_return.Rows(0).Cells(3).Value.ToString
                            End If

                            If Not String.IsNullOrEmpty(first_item_vat_type) Then
                                If Not Equals(first_item_vat_type, rdr("tax_type").ToString()) Then
                                    MsgBox("Vat Type is not same!", vbCritical, "Error")
                                    Exit Sub
                                End If
                            End If

                            grid_return.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                            grid_return.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                            Dim cost As Decimal = rdr("price")
                            grid_return.Rows(e.RowIndex).Cells(3).Value = rdr("tax_type")
                            grid_return.Rows(e.RowIndex).Cells(4).Value = cost.ToString("n2")
                            grid_return.Rows(e.RowIndex).Cells(6).Value = rdr("item")
                            grid_return.Rows(e.RowIndex).Cells(7).Value = rdr("purchase_date")
                            grid_return.Rows(e.RowIndex).Cells(8).Value = rdr("qty")
                            grid_return.Rows(e.RowIndex).Cells(9).Value = rdr("cost")

                        End While
                    Else
                        MsgBox("No last order found!", vbCritical, "Not found")
                    End If

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        'QTY, Last Price, Total
        If e.ColumnIndex.Equals(0) Or e.ColumnIndex.Equals(4) Or e.ColumnIndex.Equals(5) Or e.ColumnIndex.Equals(1) Then
            If String.IsNullOrEmpty(grid_return.Rows(e.RowIndex).Cells(1).Value) Then Return

            grid_return.Rows(e.RowIndex).Cells(4).Value = CDec(grid_return.Rows(e.RowIndex).Cells(4).Value)
            If Not String.IsNullOrEmpty(grid_return.Rows(e.RowIndex).Cells(0).Value) Then
                grid_return.Rows(e.RowIndex).Cells(5).Value = CDec(grid_return.Rows(e.RowIndex).Cells(0).Value * grid_return.Rows(e.RowIndex).Cells(4).Value)
            End If
        End If

        'Compute Total
        ComputeTotal()

    End Sub

    'Clear Button
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    'Create Button
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        'VALIDATION
        If cbb_customer.SelectedIndex = -1 Or grid_return.Rows.Count < 0 Then
            MsgBox("Incomplete fields!", vbCritical, "Incomplete")
            Return
        End If

        'CHECK GRID
        If CheckGridValue() Then
            Return
        End If

        If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
            Dim ListOfUnits = New List(Of SalesReturnClass)
            For i = 0 To grid_return.RowCount - 2
                ListOfUnits.Add(New SalesReturnClass With {
                .qty = grid_return.Rows(i).Cells(0).Value,
                .model = grid_return.Rows(i).Cells(1).Value,
                .description = grid_return.Rows(i).Cells(2).Value,
                .tax_type = grid_return.Rows(i).Cells(3).Value,
                .unit_price = grid_return.Rows(i).Cells(4).Value,
                .total_amount = grid_return.Rows(i).Cells(5).Value,
                .pid = grid_return.Rows(i).Cells(6).Value,
                .purchase_date = grid_return.Rows(i).Cells(7).Value,
                .last_qty = grid_return.Rows(i).Cells(8).Value,
                .cost = grid_return.Rows(i).Cells(9).Value
            })
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("INSERT INTO ims_sales_returns (customer_id, units, amount, status, store_id, created_by, created_at, notes, reference) 
                                    VALUES ((SELECT customer_id FROM ims_customers WHERE first_name=@customer), @units, @amount, 'Pending', (SELECT store_id FROM ims_stores WHERE store_name=@store),  @created_by, NOW(), @notes, @reference)", connection)
                        cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                        cmd.Parameters.AddWithValue("@units", JsonConvert.SerializeObject(ListOfUnits))
                        cmd.Parameters.AddWithValue("@amount", CDec(lbl_total.Text))
                        cmd.Parameters.AddWithValue("@store", cbb_warehouse.Text)
                        cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@notes", txt_notes.Text.Trim)
                        cmd.Parameters.AddWithValue("@reference", IIf(String.IsNullOrWhiteSpace(txt_reference.EditValue), DBNull.Value, txt_reference.EditValue))
                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Successfully Added!", vbInformation, "Information")
                            ClearFields()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'Update/Save Button
    Private Async Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        'VALIDATION
        If cbb_customer.SelectedIndex = -1 Or grid_return.Rows.Count < 0 Then
            MsgBox("Incomplete fields!", vbCritical, "Incomplete")
            Return
        End If

        'CHECK GRID
        If CheckGridValue() Then
            Return
        End If

        If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
            Dim ListOfUnits = New List(Of SalesReturnClass)
            For i = 0 To grid_return.RowCount - 2
                ListOfUnits.Add(New SalesReturnClass With {
                .qty = grid_return.Rows(i).Cells(0).Value,
                .model = grid_return.Rows(i).Cells(1).Value,
                .description = grid_return.Rows(i).Cells(2).Value,
                .tax_type = grid_return.Rows(i).Cells(3).Value,
                .unit_price = grid_return.Rows(i).Cells(4).Value,
                .total_amount = grid_return.Rows(i).Cells(5).Value,
                .pid = grid_return.Rows(i).Cells(6).Value,
                .purchase_date = grid_return.Rows(i).Cells(7).Value,
                .last_qty = grid_return.Rows(i).Cells(8).Value,
                .cost = grid_return.Rows(i).Cells(9).Value
            })
            Next

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_returns 
                                                  SET units=@units, amount=@amount, status='Pending', store_id=(SELECT store_id FROM ims_stores WHERE store_name=@store), notes=@notes, status='Pending', reference=@reference
                                                  WHERE sales_return_id=" & txt_srid.Text, connection)
                        cmd.Parameters.AddWithValue("@units", JsonConvert.SerializeObject(ListOfUnits))
                        cmd.Parameters.AddWithValue("@store", cbb_warehouse.EditValue)
                        cmd.Parameters.AddWithValue("@amount", CDec(lbl_total.Text))
                        cmd.Parameters.AddWithValue("@notes", txt_notes.Text.Trim)
                        cmd.Parameters.AddWithValue("@reference", IIf(String.IsNullOrWhiteSpace(txt_reference.EditValue), DBNull.Value, txt_reference.EditValue))
                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Saved!", vbInformation, "Information")
                            Me.Close()
                            Await frm_main.LoadFrm(New frm_sales_return_list, "frm_sales_return_list")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'Link to Sales Return List
    Private Async Sub link_sales_return_Click(sender As Object, e As EventArgs)
        Await frm_main.LoadFrm(New frm_sales_return_list, "frm_sales_return_list")
    End Sub

    'Delete Button
    Private Async Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Delete this Sales Return?" & Environment.NewLine & Environment.NewLine & "Press 'YES' to Delete.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET is_deleted=1 WHERE sales_return_id=" & txt_srid.Text, connection)
                        If cmd.ExecuteNonQuery() = 1 Then
                            MsgBox("Deleted!", vbInformation, "Information")
                            Await frm_main.LoadFrm(New frm_sales_return_list, "frm_sales_return_list")
                            Me.Close()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'Customer List
    Private Sub cbb_customer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedIndexChanged
        If cbb_customer.SelectedIndex = -1 Then Return
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT customer_id, account_type FROM ims_customers WHERE first_name=@customer", conn)
                    cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                    Using rdr = cmd.ExecuteReader
                        rdr.Read()
                        txt_customer_id.Text = rdr("customer_id")
                        lbl_account_type.Text = rdr("account_type")
                    End Using
                End Using

                'RESTRICT OTHER USER FROM CREATING WITH SISTER COMPANY
                Set_Restrictions()

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub grid_return_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_return.RowsRemoved
        ComputeTotal()
    End Sub

    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        Try
            If MsgBox("Press 'Yes' to confirm", vbYesNo + vbQuestion, "Confirmation") = MsgBoxResult.Yes Then
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET status='Approved', approved_by=@user, notes=@notes WHERE sales_return_id=" & txt_srid.Text, conn)
                        cmd.Parameters.AddWithValue("@user", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@notes", txt_notes.Text.Trim)
                        If cmd.ExecuteNonQuery > 0 Then

                            MsgBox("Approved!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK
                            Me.Close()

                        End If
                    End Using
                    conn.Close()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Try
            Dim report = New doc_sales_return()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT sales_return_id, company.first_name company_name, customer.contact_person, units, amount, created_at,
                                    entered.first_name entered_by, approved.first_name approved_by, received.first_name received_by, 
                                    (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name,
                                    (SELECT value FROM ims_settings WHERE name='store_info') AS store_info 
                                    FROM ims_sales_returns

                                    INNER JOIN ims_customers AS company ON company.customer_id=ims_sales_returns.customer_id
                                    INNER JOIN ims_customers AS customer ON customer.customer_id=ims_sales_returns.customer_id
                                    LEFT  JOIN ims_users AS entered ON entered.usr_id=ims_sales_returns.created_by
                                    LEFT  JOIN ims_users AS approved ON approved.usr_id=ims_sales_returns.approved_by
                                    LEFT  JOIN ims_users AS received ON received.usr_id=ims_sales_returns.received_by
                                    WHERE sales_return_id=" & txt_srid.Text, connection)

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            report.Parameters("store_name").Value = rdr("store_name")
                            report.Parameters("store_info").Value = rdr("store_info")
                            report.Parameters("srid").Value = String.Concat("SR", rdr("sales_return_id").ToString.PadLeft(5, "0"c))
                            report.Parameters("company_name").Value = rdr("company_name")
                            report.Parameters("contact_person").Value = rdr("contact_person")
                            report.Parameters("total_amount_due").Value = rdr("amount")
                            report.Parameters("entered_by").Value = rdr("entered_by")
                            report.Parameters("approved_by").Value = rdr("approved_by")
                            report.Parameters("received_by").Value = rdr("received_by")
                            report.Parameters("created_at").Value = rdr("created_at")

                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesReturnClass))(rdr("units"))
                            For Each item In itemsObject
                                table.sales_returns.Rows.Add(item.qty, item.model, item.description, item.unit_price, item.purchase_date, String.Empty, item.total_amount)
                            Next

                        End While


                        'HIDE PRICES
                        Dim user_role_id As Integer = frm_main.lbl_user_role_id.Text
                        If lbl_account_type.Text.Equals("Sister Company") And Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then
                            report.header_order_price.Text = ""
                            report.header_total_price.Text = ""
                            report.cell_order_price.Visible = False
                            report.cell_total_price.Visible = False
                            report.lbl_sub_total.Visible = False
                            report.lbl_total_amount.Visible = False
                        End If

                        report.RequestParameters = False
                        report.DataSource = table
                        report.ShowRibbonPreviewDialog()

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class