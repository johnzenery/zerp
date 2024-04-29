Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Text.RegularExpressions

Public Class frm_sales_view_order


    Dim model_AutoCompleteString As New AutoCompleteStringCollection
    Dim description_AutoCompleteString As New AutoCompleteStringCollection

    Private Property discount_counter = 0
    Private Property current_discount = 0
    Private Property old_price As Decimal = 0.00

    '#### ONLOAD #####
    Private Sub frm_sales_view_order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_AutoCompleteString()

        'Enable Price Editing for Administrator and Operation Staff
        If frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 6 Then
            grid_order.Columns(3).ReadOnly = False
        End If

    End Sub



    '##### FUNCTIONS #####

    'Load Data to Field
    Public Function LoadData(orderid As String)

        lbl_title.Text = "Order #" & orderid

        Try
            LoadCustomers()
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT *, ims_users.first_name AS sales_agent_name FROM `ims_orders` 
                LEFT JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id 
                LEFT JOIN ims_users ON ims_users.usr_id=ims_orders.sales_agent 
                WHERE order_id=" & orderid

                Dim cmd = New MySqlCommand(query, conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read

                    If rdr("account_type").Equals("Sister Company") And Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 6) Then
                        MsgBox("You are not allowed to view this order.", vbExclamation, "Forbidden")
                        Return False
                    End If

                    'Order Details
                    Me.Text = "View Order #" & orderid & " - " & rdr("first_name")
                    lbl_status.Text = rdr("status").ToString.Replace("&", "&&")
                    txt_quote_id.Text = IIf(IsDBNull(rdr("quotation_ref")), String.Empty, rdr("quotation_ref"))
                    txt_po_ref.Text = rdr("po_reference")

                    'Customer Account Details
                    lbl_cid.Text = rdr("customer_id")
                    cbb_customer.Text = rdr("first_name")
                    lbl_account_type.Text = rdr("account_type")
                    lbl_credits_available.Text = FormatCurrency(CDec(rdr("credit_limit")) - CDec(rdr("used_credit")), 2)
                    txt_contact_person.Text = rdr("contact_person")
                    txt_no.Text = rdr("contact")
                    txt_terms.Value = CDec(rdr("terms"))
                    txt_sales_agent.Text = IIf(IsDBNull(rdr("sales_agent_name")), String.Empty, rdr("sales_agent_name"))

                    'Bill & Shipping Address
                    txt_billing.Text = rdr("bill_to")
                    txt_shipping.Text = rdr("ship_to")
                    If Equals(txt_billing.Text, txt_shipping.Text) Then cb_same_billing.Checked = True

                    'Public, Private & Trucking Note
                    txt_pub_notes.Text = rdr("pub_note")
                    txt_priv_notes.Text = rdr("priv_note")
                    txt_trucking.Text = rdr("trucking")

                    'Set Delivery Fee
                    If rdr("delivery_fee") > 0 Then
                        txt_delivery_fee.Text = FormatCurrency(rdr("delivery_fee"))
                        lbl_delivery_fee.LinkColor = Color.Red
                        lbl_delivery_fee.Text = "Remove Delivery Fee"
                    Else
                        txt_delivery_fee.Text = String.Empty
                    End If

                    'Set Shipping Method
                    Select Case rdr("shipping_method")
                        Case "Pickup" : rb_pickup.Checked = True
                        Case "Deliver" : rb_deliver.Checked = True
                    End Select

                    'Set Payment Type
                    Select Case rdr("payment_type")
                        Case "Cash" : rb_cash.Checked = True
                        Case "E-Payment"
                            rb_epay.Checked = True
                            btn_epayment.Enabled = True
                        Case "Terms" : rb_terms.Checked = True
                        Case "Cheque" : rb_cheque.Checked = True
                    End Select

                    'Display Payment Status Computation
                    lbl_amounttopay.Text = FormatCurrency(rdr("amount_due"))
                    lbl_paid_amount.Text = FormatCurrency(rdr("paid_amount"))

                    'Set Payment Status
                    Select Case rdr("payment_status")
                        Case "UNPAID" : lbl_payment_status.Text = "UNPAID"
                        Case "PENDING CONFIRMATION"
                            lbl_payment_status.Text = "PENDING CONFIRMATION"
                            lbl_payment_status.Appearance.BackColor = Color.Yellow
                        Case "HOLD"
                            lbl_payment_status.Text = rdr("payment_status")
                            lbl_payment_status.Appearance.BackColor = Color.Blue
                        Case "PAID", "PARTIAL", "OVERPAID", "REFUND"
                            If Not IsDBNull(rdr("paid_amount")) Then

                                Dim res = CDec(rdr("amount_due")) - CDec(rdr("paid_amount"))

                                If res = 0 Then
                                    lbl_payment_status.Text = "PAID"
                                    lbl_payment_status.Appearance.BackColor = Color.YellowGreen
                                ElseIf res < 0 Then
                                    lbl_payment_status.Text = "OVERPAID"
                                    lbl_payment_status.Appearance.BackColor = Color.OrangeRed
                                ElseIf res > 0 Then
                                    lbl_payment_status.Text = "PARTIAL"
                                    lbl_payment_status.Appearance.BackColor = Color.Yellow
                                    lbl_payment_status.Appearance.ForeColor = Color.Black
                                End If

                                'Display and Balances
                                lbl_balance.Text = FormatCurrency(res)

                                'Set btn_refund IF CASH
                                If rdr("payment_type").Equals("Cash") Or rdr("payment_type").Equals("E-Payment") Then
                                    btn_refund.Enabled = True
                                End If

                                'Set if Requesting Refund
                                If rdr("payment_status").Equals("REFUND") Then
                                    lbl_payment_status.Text = "FOR REFUND"
                                    lbl_payment_status.Appearance.BackColor = Color.Purple
                                    btn_refund.Enabled = False
                                End If

                            End If
                    End Select

                    If Not IsDBNull(rdr("discount_val")) Then txt_discount.Text = rdr("discount_val")
                    If Not IsDBNull(rdr("discount_type")) Then cbb_discount.Text = rdr("discount_type")

                    cb_tax_applied.Checked = rdr("is_withholding_tax_applied")
                    cb_vatable.Checked = rdr("is_vatable")
                    txt_invoice.Text = rdr("invoice_no").ToString

                    If Not IsDBNull(rdr("withholding_tax_percentage")) Then lbl_withholding_tax_percentage.Text = FormatPercent(rdr("withholding_tax_percentage") / 100)
                    If Not IsDBNull(rdr("withholding_tax_amount")) Then lbl_withholding_tax_amount.Text = FormatPercent(rdr("withholding_tax_amount"))

                    data_to_grid(rdr("order_item"), grid_order, 5)

                End While

                rdr.Close()
                load_remaining_grid()

            End Using

            '--- UPDATING GUI

            'Status
            Select Case lbl_status.Text
                Case "For Packing"
                    btn_pack.Text = String.Empty
                    btn_pack.Enabled = False
                    btn_pack.ImageOptions.Image = My.Resources.packing_now

                Case "Packed"
                    'btn_save.Enabled = False
                    btn_delete.Enabled = False
                    btn_modify.Enabled = True
                    grid_order.ReadOnly = True

                    'btn_pack
                    btn_pack.Text = "Void"
                    btn_pack.ImageOptions.Image = My.Resources.unpacking

                Case "Released"
                    'btn_save.Enabled = False
                    btn_delete.Enabled = False
                    btn_pack.Enabled = False
                    If frm_main.user_role_id.Text.Equals("1") Then
                        grid_order.ReadOnly = False
                    Else
                        grid_order.ReadOnly = True
                    End If

                Case "Cancelled"
                    'btn_save.Enabled = False
                    btn_delete.Enabled = False
                    btn_pack.Enabled = False
                    grid_order.Enabled = False

                Case "Completed"
                    'btn_save.Enabled = False
                    btn_delete.Enabled = False
                    btn_pack.Enabled = False
                    If frm_main.user_role_id.Text.Equals("1") Then
                        grid_order.Enabled = True
                    Else
                        grid_order.Enabled = False
                    End If

            End Select

            'Disable grid_order IF FROM Quotation
            If Not String.IsNullOrEmpty(txt_quote_id.Text) Then
                If Not (frm_main.user_role_id.Text = 1 Or frm_main.user_role_id.Text = 6) Then
                    grid_order.Enabled = False
                    grid_order.AllowUserToAddRows = False
                    lbl_cant_edit.Visible = True
                End If
            End If

            ComputeTotal()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function

    'Load Customers
    Private Sub LoadCustomers()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT first_name FROM ims_customers", conn)
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

    'Compute Total Units Cost
    Private Sub ComputeTotal()
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

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()

        Dim STORE_TABLE = "ims_" & frm_main.user_store.Text.ToLower.Replace(" ", "_")

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT ims_inventory.winmodel, ims_inventory.description FROM " & STORE_TABLE & " RIGHT JOIN ims_inventory ON " & STORE_TABLE & ".pid=ims_inventory.pid"
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

    'Print Packing Slip
    Public Sub print_packing_list(id As Integer)
        Dim report = New doc_packing_list()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData
        Dim orders = String.Empty

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_customers.contact_person, 
                            ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, 
                            ims_orders.priv_note, trucking, shipping_method, po_reference
                            FROM `ims_orders` 
                            LEFT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            LEFT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'"
                Dim cmd = New MySqlCommand(query, conn)
                rdr = cmd.ExecuteReader

                While rdr.Read
                    report.Parameters("order_id").Value = String.Concat("SO", rdr("order_id").ToString.PadLeft(5, "0"c))
                    report.Parameters("customer").Value = rdr("customer")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("address").Value = rdr("ship_to")
                    report.Parameters("agent").Value = rdr("agent")
                    report.Parameters("ordered_date").Value = rdr("date_ordered")
                    report.Parameters("priv_notes").Value = rdr("priv_note")
                    report.Parameters("trucking").Value = rdr("trucking")
                    report.Parameters("shipping_method").Value = rdr("shipping_method")
                    report.Parameters("po_reference").Value = rdr("po_reference")

                    data_to_grid(rdr("order_item"), table.packing_list, 3)

                End While

                report.RequestParameters = False
                report.DataSource = table
                printTool.ShowRibbonPreviewDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Print Draft
    Private Sub PrintDraftInvoice(orderid As Integer)
        Dim report = New doc_draft_receipt()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData

        Try

            Using conn = New MySqlConnection(str)
                conn.Open()

                Dim cmd = New MySqlCommand("SELECT order_id, ims_customers.first_name, ims_customers.contact_person, ship_to, order_item, pub_note, payment_type, discount_type, discount_val,
                        is_vatable, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, delivery_fee,
                        amount_due, shipping_method, trucking, date_released, 
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT VALUE FROM ims_settings WHERE NAME='store_info') AS store_info FROM `ims_orders`
                        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer WHERE order_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", orderid)
                rdr = cmd.ExecuteReader

                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info")
                    report.Parameters("orderid").Value = "SO" & rdr("order_id").ToString.PadLeft(5, "0"c)
                    report.Parameters("customer").Value = rdr("first_name")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("shipping_addr").Value = rdr("ship_to")
                    report.Parameters("shipping_method").Value = rdr("shipping_method")
                    report.Parameters("trucking").Value = rdr("trucking")
                    report.Parameters("amount_due").Value = rdr("amount_due")
                    report.Parameters("pub_notes").Value = rdr("pub_note")
                    report.Parameters("payment").Value = rdr("payment_type").ToString.ToUpper
                    report.Parameters("delivery_charge").Value = rdr("delivery_fee")
                    report.Parameters("discount_type").Value = rdr("discount_type")
                    report.Parameters("discount_val").Value = rdr("discount_val")

                    report.Parameters("is_vatable").Value = rdr("is_vatable")
                    report.Parameters("is_withholding_tax_applied").Value = rdr("is_withholding_tax_applied")
                    report.Parameters("withholding_tax_percentage").Value = rdr("withholding_tax_percentage")
                    report.Parameters("withholding_tax_amount").Value = rdr("withholding_tax_amount")

                    data_to_grid(rdr("order_item"), table.invoice_data, 5)

                End While
            End Using

            report.RequestParameters = False
            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set Grid Data
    Public Sub data_to_grid(units As String, GridOrTable As Object, ColumnCount As Integer)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If GridOrTable.Rows.Count > 0 Then GridOrTable.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            'DECLARE VALUES
            Dim warehouse As String = "ims_winland_main_store"
            comma = colonseparator.Split(units)

            'QUERY : GET LOCATION AND LOCATION 2
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT warehouse.location, warehouse.location_2 
                                            FROM ims_inventory
                                            LEFT JOIN " & warehouse & " AS warehouse ON warehouse.pid=ims_inventory.pid
                                            WHERE ims_inventory.winmodel=@model", conn)
                    'Using cmd = New MySqlCommand("SELECT location, location_2 
                    '                            FROM " & warehouse & " AS tbl_default
                    '                            INNER JOIN ims_inventory ON ims_inventory.pid=tbl_default.pid
                    '                            WHERE ims_inventory.winmodel=@model", conn)
                    cmd.Parameters.AddWithValue("@model", 0)
                    cmd.Prepare()

                    For i = 0 To comma.Length - 1
                        piece = comma(i).Trim
                        equal = piece.Split("=")

                        Select Case ColumnCount

                            Case 3
                                cmd.Parameters(0).Value = equal(1).ToString.Trim
                                Using rdr = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        rdr.Read()
                                        GridOrTable.Rows.Add(equal(0), equal(1), equal(2), rdr("location"), rdr("location_2"))
                                    End If
                                End Using

                            Case 5
                                GridOrTable.Rows.Add(equal(0), equal(1), equal(2), equal(3), equal(4), equal(5).Replace(";", String.Empty))

                        End Select

                        If Not GridOrTable.GetType.Name.Equals("DataGridView") Then GridOrTable.DefaultView.Sort = "model ASC"

                    Next

                End Using
            End Using

            ComputeTotal()

        End If

    End Sub

    'Remaining Grid Load
    Private Sub load_remaining_grid()

        grid_remaining.Rows.Clear()

        Using conn = New MySqlConnection(str)
            conn.Open()
            For i = 0 To grid_order.Rows.Count - 2
                Dim model = grid_order.Rows(i).Cells(1).Value
                Dim cmd = New MySqlCommand(get_query(conn) & " WHERE winmodel=@winmodel", conn)
                cmd.Parameters.AddWithValue("@winmodel", model)
                Using rdr As MySqlDataReader = cmd.ExecuteReader
                    While rdr.Read
                        grid_remaining.Rows.Add(rdr("other_qty"), rdr("qty"), rdr("onhold"))
                        grid_remaining.CurrentCell = Nothing
                    End While
                End Using
            Next

        End Using

    End Sub

    'Get All Store Tables
    Private Function get_all_store_tables(MyStore As String, conn As MySqlConnection)
        Dim tbl_cmd = New MySqlCommand("SELECT store_name FROM ims_stores", conn)
        Dim rdr_tbl As MySqlDataReader = tbl_cmd.ExecuteReader

        Dim tables = String.Empty
        While rdr_tbl.Read
            Dim store = "ims_" & rdr_tbl("store_name").ToString.ToLower.Replace(" ", "_")
            If store.Equals(MyStore) Then Continue While
            tables += store & ","
        End While

        rdr_tbl.Close()

        Return tables
    End Function

    'Concat Queries
    Private Function get_query(conn As MySqlConnection)

        'Get Active Table
        Dim STORE_TABLE = "ims_" & frm_main.user_store.Text.ToLower.Replace(" ", "_")

        'Get All Store's Tables Inventory Except Own
        Dim tables = get_all_store_tables(STORE_TABLE, conn).ToString.Split(",")

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







    '##### CONTROLS ######

    'Grid Control Editing
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

        If e.ColumnIndex.Equals(1) Then

            If String.IsNullOrEmpty(grid_order.CurrentCell.Value) Then Exit Sub

            For i = 0 To grid_order.Rows.Count - 1
                If i = grid_order.CurrentRow.Index Then Continue For
                If grid_order.CurrentCell.Value.Equals(grid_order.Rows(i).Cells(1).Value) Then
                    MsgBox("Already exist!", vbCritical, "Duplicate")
                    grid_order.Rows.RemoveAt(grid_order.CurrentRow.Index)
                    Exit Sub
                End If
            Next

            Try

                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim cmd = New MySqlCommand(get_query(conn) & " WHERE winmodel=@winmodel", conn)
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

                        grid_remaining.CurrentCell = Nothing

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
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim cmd = New MySqlCommand(get_query(conn) & " WHERE description=@description", conn)
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
                        grid_order.Rows(e.RowIndex).Cells(1).Value = rdr("winmodel").ToString.ToUpper
                        grid_order.Rows(e.RowIndex).Cells(2).Value = rdr("description")
                        Dim cost As Decimal = rdr(GetAccountTypeTable)
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
                If String.IsNullOrEmpty(grid_order.Rows(e.RowIndex).Cells(1).Value) Then Exit Sub

                If e.ColumnIndex.Equals(3) Then
                    If old_price > CDec(grid_order.CurrentCell.Value) Then
                        Dim ans = MsgBox("Stated price is lower than default." & vbCrLf & "Continue anyway?", vbYesNo + vbExclamation, "Price is lower than default")
                        If Not ans = vbYes Then
                            grid_order.CurrentCell.Value = old_price
                        End If
                    End If
                    grid_order.CurrentCell.Value = CDec(grid_order.CurrentCell.Value)
                End If

                Dim cost = 0.00

                If e.ColumnIndex.Equals(4) Then

                    'Discount Counter
                    If Not frm_main.user_role_id.Text.Equals("1") Then 'IF NOT ADMIN
                        If discount_counter > 2 Then
                            Dim pass As String = String.Empty
                            frm_sales_password_required.ShowDialog()
                            If Not String.IsNullOrEmpty(frm_sales_password_required.Password) Then
                                pass = frm_sales_password_required.Password
                                frm_sales_password_required.Dispose()
                            End If

                            Dim count = 0

                            Using conn = New MySqlConnection(str)
                                conn.Open()
                                Dim cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_users WHERE role_id='1' AND pass=@pass", conn)
                                cmd.Parameters.AddWithValue("@pass", Encrypt(pass))
                                count = cmd.ExecuteScalar
                            End Using

                            If Not count >= 1 Or String.IsNullOrWhiteSpace(pass) Then
                                MsgBox("Password is Incorrect!", vbCritical, "Incorrect Password")
                                Dim current_price As Decimal = grid_order.Rows(e.RowIndex).Cells(3).Value
                                Dim current_total = current_price - (current_price * (current_discount / 100))
                                grid_order.Rows(e.RowIndex).Cells(5).Value = CDec(grid_order.Rows(e.RowIndex).Cells(0).Value * current_total)
                                grid_order.Rows(e.RowIndex).Cells(4).Value = current_discount & "%"
                                current_discount = 0
                                Exit Sub
                            End If
                        End If
                    End If

                    'Get Cost
                    Using conn = New MySqlConnection(str)
                        conn.Open()
                        Dim cmd = New MySqlCommand("SELECT cost FROM ims_inventory WHERE winmodel=@winmodel", conn)
                        cmd.Parameters.AddWithValue("@winmodel", grid_order.Rows(e.RowIndex).Cells(1).Value)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader

                        rdr.Read()
                        cost = rdr("cost")
                        rdr.Close()
                    End Using

                    discount_counter += 1

                End If


                Dim price As Decimal = grid_order.Rows(e.RowIndex).Cells(3).Value
                Dim discount As Decimal = grid_order.Rows(e.RowIndex).Cells(4).Value.ToString.Replace("%", String.Empty)
                Dim total_price = price - (price * (discount / 100))

                If total_price < cost Then
                    MsgBox("Price is less than of cost!", vbCritical, "Error")
                    Dim current_price As Decimal = grid_order.Rows(e.RowIndex).Cells(3).Value
                    Dim current_total = current_price - (current_price * (current_discount / 100))
                    grid_order.Rows(e.RowIndex).Cells(5).Value = CDec(grid_order.Rows(e.RowIndex).Cells(0).Value * current_total)
                    grid_order.Rows(e.RowIndex).Cells(4).Value = current_discount & "%"
                    Exit Sub
                End If

                Dim total As Decimal = grid_order.Rows(e.RowIndex).Cells(0).Value * total_price

                grid_order.Rows(e.RowIndex).Cells(5).Value = total.ToString("n2")
                grid_order.Rows(e.RowIndex).Cells(3).Value = price.ToString("n2")
                grid_order.Rows(e.RowIndex).Cells(4).Value = discount & "%"

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

        'Compute Total
        ComputeTotal()

    End Sub

    'Grid Begin Edit
    Private Sub grid_order_CellBeginEdit(sender As Object, e As DataGridViewCellCancelEventArgs) Handles grid_order.CellBeginEdit

        If Not String.IsNullOrEmpty(grid_order.Rows(e.RowIndex).Cells(4).Value) Then
            current_discount = grid_order.Rows(e.RowIndex).Cells(4).Value.ToString.Replace("%", String.Empty)
        End If

        If e.ColumnIndex.Equals(3) Then
            old_price = grid_order.CurrentCell.Value
        End If

    End Sub

    'Grid Removed Row (Delete)
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

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Delete Key
    Private Sub grid_order_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles grid_order.PreviewKeyDown
        If e.KeyCode = Keys.Delete Then
            If grid_order.Rows.Count > 1 Then
                grid_order.Rows.RemoveAt(grid_order.CurrentCell.RowIndex)
            End If
        End If
    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs, Optional no_confirmation As Boolean = False) Handles btn_save.Click

        'Validation
        If String.IsNullOrEmpty(txt_billing.Text) Or grid_order.Rows.Count <= 1 Then
            MsgBox("Complete All Fields!", vbCritical, "Error")
            Exit Sub
        End If

        'Credit Balance Checking
        If CDec(lbl_total.Text) > CDec(lbl_credits_available.Text) And rb_terms.Checked = True Then
            MsgBox("Credit Balance is Low. Can't Proceed!", vbCritical, "Low Balance")
            Exit Sub
        End If


        'Initialization
        Dim payment_type = String.Empty
        Dim payment_details = String.Empty
        Dim shipping_method = String.Empty

        'Get Payment Method
        If rb_cash.Checked Then payment_type = "Cash"
        If rb_epay.Checked Then payment_type = "E-Payment"
        If rb_terms.Checked Then payment_type = "Terms"
        If rb_cheque.Checked Then payment_type = "Cheque"


        'Get Shipping Method
        If rb_pickup.Checked Then shipping_method = "Pickup"
        If rb_deliver.Checked Then shipping_method = "Deliver"


        'Get Orders
        Dim orders = String.Empty
        For Each row In grid_order.Rows
            If String.IsNullOrEmpty(row.Cells(1).value) Then Continue For
            orders += row.Cells(0).value & "=" & row.Cells(1).value & "=" & row.Cells(2).value & "=" & row.Cells(3).value & "=" & row.Cells(4).Value & "=" & row.Cells(5).Value & ";"
        Next

        'Get Delivery Fee
        Dim _delivery_fee = If(String.IsNullOrEmpty(txt_delivery_fee.Text), Nothing, CDec(txt_delivery_fee.Text))

        'Get Status
        Dim payment_status = String.Empty
        If CDec(lbl_total.Text) = CDec(lbl_paid_amount.Text) Then payment_status = "PAID"
        If CDec(lbl_total.Text) < CDec(lbl_paid_amount.Text) Then payment_status = "OVERPAID"
        If CDec(lbl_total.Text) > CDec(lbl_paid_amount.Text) Then payment_status = "PARTIAL"
        If CDec(lbl_paid_amount.Text) = 0 Then payment_status = "UNPAID"

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim order_id = lbl_title.Text.Split("#")
                Dim status = lbl_status.Text
                Dim query = "UPDATE ims_orders SET bill_to=@bill_to, ship_to=@ship_to, trucking=@trucking, payment_status=@payment_status,
                            order_item=@order_item, pub_note=@pub_note, priv_note=@priv_note, terms=@terms,
                            is_vatable=@is_vatable, invoice_no=@invoice_no, discount_val=@discount_val, discount_type=@discount_type,
                            is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                            delivery_fee=@delivery_fee, amount_due=@amount_due, po_reference=@po_reference,
                            payment_type=@payment_type, payment_details=@payment_details, shipping_method=@shipping_method, status=@status WHERE order_id=" & order_id(1)
                Dim cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@payment_status", payment_status)
                cmd.Parameters.AddWithValue("@bill_to", txt_billing.Text.Trim)
                cmd.Parameters.AddWithValue("@ship_to", txt_shipping.Text.Trim)
                cmd.Parameters.AddWithValue("@trucking", txt_trucking.Text.Trim)
                cmd.Parameters.AddWithValue("@order_item", orders)
                cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                cmd.Parameters.AddWithValue("@payment_type", payment_type)
                cmd.Parameters.AddWithValue("@payment_details", payment_details)
                cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                cmd.Parameters.AddWithValue("@invoice_no", txt_invoice.Text)
                cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_tax_applied.Checked)
                cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(lbl_withholding_tax_amount.Text))
                cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("%", String.Empty)))
                cmd.Parameters.AddWithValue("@amount_due", CDec(lbl_total.Text))
                cmd.Parameters.AddWithValue("@delivery_fee", _delivery_fee)
                cmd.Parameters.AddWithValue("@shipping_method", shipping_method)
                cmd.Parameters.AddWithValue("@po_reference", txt_po_ref.Text.Trim)
                cmd.Parameters.AddWithValue("@terms", txt_terms.Value)

                If status.Equals("No Payment && Shipping") Or status.Equals("No Payment Details") Or status.Equals("No Shipping Method") Then

                    Dim shipping = False, payment = False

                    If rb_deliver.Checked = True Or rb_pickup.Checked = True Then
                        shipping = True
                    End If

                    If rb_cash.Checked = True Or rb_cheque.Checked = True Or rb_terms.Checked = True Then
                        payment = True
                    End If

                    If shipping = True And payment = True Then
                        status = "Pending"
                    ElseIf shipping = True And payment = False Then
                        status = "No Payment Details"
                    ElseIf shipping = False And payment = True Then
                        status = "No Shipping Method"
                    End If

                End If

                cmd.Parameters.AddWithValue("@status", status.Replace("&&", "&"))

                cmd.ExecuteNonQuery()

                If Not no_confirmation = True Then MsgBox("Save Successfully!", vbInformation, "Information")

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Ready for Packing
    Private Sub btn_pack_Click(sender As Object, e As EventArgs) Handles btn_pack.Click

        Select Case lbl_status.Text

            'PENDING
            Case "Pending"
                Dim ans = MsgBox("Ready for Packing?", vbQuestion + vbYesNo, "For Packing")
                If ans = vbYes Then

                    Try
                        Dim order_id = lbl_title.Text.Split("#")
                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Pending for Arrangement' WHERE order_id=" & order_id(1), conn)
                            cmd.ExecuteNonQuery()

                            MsgBox("Saved Successfully!", vbInformation, "Information")
                            Me.Close()
                            frm_main.submenu_orders.PerformClick()
                        End Using


                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If

            'PACKED
            Case "Packed"
                If MsgBox("Cancel and unpack this order?", vbQuestion + vbYesNo, "For Packing") = vbYes Then

                    Try
                        Dim order_id = lbl_title.Text.Split("#")
                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Cancelled Order' WHERE order_id=" & order_id(1), conn)
                            cmd.ExecuteNonQuery()

                            MsgBox("Update Successful!" & vbCrLf & "Package will be unpacked soon...", vbInformation, "Notice")
                            Me.Close()
                            frm_main.submenu_orders.PerformClick()
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If

        End Select

    End Sub

    'btn_delete Delete Order
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim i = MsgBox("Delete this Order?", vbQuestion + vbYesNo, "Delete")

        If Not i = vbYes Then Exit Sub

        Dim order_id = lbl_title.Text.Split("#")

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "UPDATE ims_orders SET deleted='1' WHERE order_id=" & order_id(1)
                Dim cmd = New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()
                Me.Close()

                frm_main.submenu_orders.PerformClick()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        print_contextmenu.Show(btn_print, New Point(btn_print.Width - print_contextmenu.Width, btn_print.Height))
    End Sub

    'cb_same_billing | Same Shipping Address & Billing Address
    Private Sub cb_same_billing_CheckedChanged(sender As Object, e As EventArgs) Handles cb_same_billing.CheckedChanged
        If cb_same_billing.Checked Then
            txt_shipping.Text = txt_billing.Text
            txt_shipping.Enabled = False
        Else
            txt_shipping.Text = String.Empty
            txt_shipping.Enabled = True
        End If
    End Sub

    Private Sub grid_order_Scroll(sender As Object, e As ScrollEventArgs) Handles grid_order.Scroll
        grid_remaining.FirstDisplayedScrollingRowIndex = e.NewValue
    End Sub

    'lbl_delivery_fee.LinkClicked | Delivery Fee
    Private Sub lbl_delivery_fee_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_delivery_fee.LinkClicked

        Dim _total = CDec(lbl_total.Text)

        If lbl_delivery_fee.LinkColor = Color.Red And Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
            _total -= CDec(txt_delivery_fee.Text)

            txt_delivery_fee.Text = String.Empty
            lbl_amounttopay.Text = FormatCurrency(_total)
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
                lbl_amounttopay.Text = FormatCurrency(_total)
                lbl_total.Text = FormatCurrency(_total)

            Catch ex As Exception
                MsgBox("Invalid Number Format!", vbCritical, "Number Exception")
            End Try

            If Not String.IsNullOrWhiteSpace(txt_delivery_fee.Text) Then
                lbl_delivery_fee.LinkColor = Color.Red
                lbl_delivery_fee.Text = "Remove Delivery Fee"
            End If

            ComputeTotal()
        End If

    End Sub

    'Print Packing Slip
    Private Sub PackingSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackingSlipToolStripMenuItem.Click
        Dim id = lbl_title.Text.Split("#")
        print_packing_list(id(1))
    End Sub

    'Print Draft Invoice
    Private Sub DraftInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DraftInvoiceToolStripMenuItem.Click
        btn_save_Click(Nothing, Nothing, True)
        Dim id = lbl_title.Text.Split("#")
        PrintDraftInvoice(id(1))
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

    'E-Payment Button
    Private Sub btn_epayment_Click(sender As Object, e As EventArgs) Handles btn_epayment.Click
        Dim frm As New frm_sales_order_epayment_proofs()
        frm.lbl_order_id.Text = lbl_title.Text.Replace("Order #", "SO")
        frm.LoadData()
        frm.ShowDialog()
    End Sub

    'Modify Button
    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click
        Dim text As String = btn_modify.Text
        If btn_modify.Text.Equals("Modify") Then
            Dim passw As String = String.Empty
            Dim value_count As Integer = 0

            frm_sales_password_required.ShowDialog()
            If Not String.IsNullOrEmpty(frm_sales_password_required.Password) Then
                passw = frm_sales_password_required.Password
                frm_sales_password_required.Dispose()
            End If

            If Not String.IsNullOrEmpty(passw) Then
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim cmd As MySqlCommand = New MySqlCommand("SELECT COUNT(*) FROM ims_users WHERE role_id='1' AND pass=@pass", conn)
                    cmd.Parameters.AddWithValue("@pass", Encrypt(passw))
                    value_count = CInt(cmd.ExecuteScalar())
                End Using

                If value_count = 0 Then
                    MsgBox("Password is Incorrect!", MsgBoxStyle.Critical, "Incorrect Password")
                    Return
                End If

                MsgBox("Success! You may now modify this order." & vbCrLf & "Please exit after modification.", MsgBoxStyle.Information, "Modification")
                grid_order.ReadOnly = False
                grid_order.Columns(5).ReadOnly = True
                btn_save.Enabled = True
                btn_modify.Text = "Exit"
                btn_modify.ImageOptions.Image = My.Resources.cancel_32x32
            Else
                Return
            End If
        ElseIf btn_modify.Text.Equals("Exit") Then
            grid_order.[ReadOnly] = True
            btn_modify.Text = "Modify"
            btn_modify.ImageOptions.Image = My.Resources.modifytablestyle_32x32
        End If
    End Sub

    'btn_refund
    Private Sub btn_refund_Click(sender As Object, e As EventArgs) Handles btn_refund.Click
        If MsgBox("Refund payment for this Sales Order?", vbInformation + vbYesNo, "Refund Confirmation") = vbYes Then
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim id = lbl_title.Text.Split("#")
                Using cmd = New MySqlCommand("UPDATE ims_orders SET payment_status='REFUND' WHERE order_id=" & id(1), connection)
                    If cmd.ExecuteNonQuery = 1 Then
                        MsgBox("Successfully tagged for Refund!" & Environment.NewLine & "Reopening this view will update the Payment Status.", vbInformation, "Refunded")
                    End If
                End Using
            End Using
        End If
    End Sub

    Private Sub btn_unserved_Click(sender As Object, e As EventArgs) Handles btn_unserved.Click
        Dim frm = New frm_sales_unserved_dialog
        frm.cid = lbl_cid.Text
        frm.Show()
    End Sub
End Class

