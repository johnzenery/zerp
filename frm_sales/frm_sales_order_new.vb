Imports System.ServiceModel
Imports System.Text.RegularExpressions
Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSpreadsheet.API.Native.Implementation
Imports MySqlConnector
Imports Newtonsoft.Json
Imports OfficeOpenXml

Public Class frm_sales_order_new

    Private CustomerDetails As New CustomerDetails
    Private rid As Integer = 0

    Private Sub frm_sales_order_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cbb_customer.Properties.Items.Count = 0 Then
            Load_CustomerList()
            Load_Warehouse()
        End If

        If TryCast(grid_order.DataSource, DataTable) Is Nothing Then
            Create_DataSource_gridorder()
        End If

        LoadTaxCodes()

        If frm_main.lbl_user_role_id.Text = "1" Then
            col_d_price.OptionsColumn.AllowEdit = True
            col_unit_price.OptionsColumn.AllowEdit = True
        End If

    End Sub




    '>>> FUNCTIONS

    'Load AutoComplete String
    Private Sub Load_SearchGrid()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim discount_type = String.Empty
                Select Case txt_account_type.Text
                    Case "Regular"
                        'discount_type = "'0'"
                        discount_type = "ims_price_matrix.regular_discount"
                    Case "Dealer" : discount_type = "ims_price_matrix.dealer_discount"
                    Case "VIP" : discount_type = "ims_price_matrix.vip_discount"
                    Case "Sister Company" : discount_type = "'*'"
                    Case "Branch" : discount_type = "'*'"
                End Select

                Dim price = String.Empty
                Select Case txt_account_type.Text
                    Case "Regular"
                        'price = "regular_price"
                        price = "(IFNULL(
                                        IF(ims_price_matrix.regular_discount = 'NET', net_regular, regular_price - ((regular_discount / 100) * regular_price)), 
                                        regular_price
                                        )
                                  )"
                    Case "Dealer"
                        price = "(IFNULL(
                                        IF(ims_price_matrix.dealer_discount = 'NET', dealer_price, regular_price - ((dealer_discount / 100) * regular_price)), 
                                        dealer_price
                                        )
                                  )"
                    Case "VIP"
                        price = "(IFNULL(
                                        IF(ims_price_matrix.vip_discount = 'NET', vip_price, regular_price - ((vip_discount / 100) * regular_price)), 
                                        vip_price
                                        )
                                  )"
                    Case "Sister Company" : price = "inv.cost"
                    Case "Branch" : price = "inv.cost"
                End Select

                Dim query = "SELECT  pid, brand, unit, winmodel, description, inv.combination_name, regular_price, (IFNULL(inv.length, 0) * IFNULL(inv.width, 0) * IFNULL(inv.height, 0)) / 100 AS cbm, IFNULL(inv.weight, 0) AS kgs,
                                     IF((" & discount_type & " = 'NET' OR " & discount_type & " = 'SRP' OR " & discount_type & " = '*'), " & discount_type & ", CONCAT(" & discount_type & ",'%')) AS discount, " & price & " AS unit_price
                            FROM (SELECT pid, brand, unit, winmodel, description, CONCAT(brand, ' ', sub_category) AS combination_name, 
                                    cost, regular_price, net_regular, dealer_price, vip_price, status, length, width, height, weight FROM ims_inventory) inv
                            LEFT JOIN ims_price_matrix ON ims_price_matrix.combination_name=inv.combination_name
                            WHERE inv.status='Active'"

                'Dim query = "SELECT pid, brand, winmodel, description, " & GetAccountTypeTable() & " AS unit_price FROM ims_inventory WHERE status='Active'"
                Dim cmd = New MySqlCommand(query, connection)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_search.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Get Account Type Table : OBSOLETE
    Private Function GetAccountTypeTable()
        Dim account_type = String.Empty

        Select Case txt_account_type.Text
            Case "Regular" : account_type = "regular_price"
            Case "Dealer" : account_type = "dealer_price"
            Case "VIP" : account_type = "vip_price"
            Case "Sister Company" : account_type = "cost"
        End Select

        Return account_type

    End Function

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

    'Load Customers
    Private Sub Load_CustomerList()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("SELECT LPAD(customer_id, 3, '0') as customer_id, first_name FROM ims_customers WHERE is_deleted='0'", connection)
                    Dim rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read
                        cbb_customer.Properties.Items.Add(rdr("first_name"))
                    End While

                    cbb_customer.SelectedIndex = -1

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Tax Code to ComboBox
    Private Sub LoadTaxCodes()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'Load Tax Codes
                Using cmd = New MySqlCommand("SELECT * FROM ims_tax_code", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_taxCode.Properties.Items.Add(rdr("tax_code"))
                        End While
                    End Using
                End Using

                conn.Close()
            End Using

            'SET default value
            cbb_taxCode.EditValue = "WC158"

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    'Load Returns : New
    Private Sub LoadReturns_v2(rid As List(Of Integer))
        Try
            Using connection = New MySqlConnection(str) 'CONCAT('SR', LPAD(sales_return_id, 5, '0')) AS srid
                connection.Open()
                Dim str_returns As String = String.Empty

                If Not rid Is Nothing Then
                    For Each id As String In rid
                        str_returns = String.Concat(str_returns, " OR sales_return_id='" & id & "'")
                    Next
                End If


                Using cmd = New MySqlCommand("SELECT sales_return_id AS srid, ims_customers.first_name AS customer, amount, created_at
                                        FROM ims_sales_returns
                                        LEFT JOIN ims_customers ON ims_customers.customer_id=ims_sales_returns.customer_id
                                        WHERE ims_sales_returns.is_deleted=0 AND status='Received' AND is_applied='0'
                                        AND ims_customers.first_name=@customer_name" & str_returns, connection)
                    cmd.Parameters.AddWithValue("@customer_name", cbb_customer.EditValue)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_returns.DataSource = dt

                    If Not String.IsNullOrWhiteSpace(str_returns) Then
                        For Each id As String In rid
                            Dim row_handle = grid_returns_view.LocateByValue("srid", CInt(id))
                            grid_returns_view.SelectRow(row_handle)
                        Next

                    End If

                End Using

                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Create DataSource for Grid Order
    Public Function Create_DataSource_gridorder() As DataTable
        Dim dt = New DataTable
        dt.Columns.Add("pid", GetType(Integer))
        dt.Columns.Add("qty", GetType(Decimal))
        dt.Columns.Add("model", GetType(String))
        dt.Columns.Add("description", GetType(String))
        dt.Columns.Add("unit_price", GetType(Decimal))
        dt.Columns.Add("discount", GetType(String))
        dt.Columns.Add("discounted_price", GetType(Decimal))
        dt.Columns.Add("total_price", GetType(Decimal))
        dt.Columns.Add("unit", GetType(String))
        dt.Columns.Add("volume", GetType(Double))
        dt.Columns.Add("weight", GetType(Double))
        grid_order.DataSource = dt
        Return dt
    End Function

    'Load Sales Order History
    Private Sub LoadHistory()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Dim dt = New DataTable
                dt.Columns.Add("date_released", GetType(Date))
                dt.Columns.Add("qty", GetType(Decimal))
                dt.Columns.Add("winmodel", GetType(String))
                dt.Columns.Add("description", GetType(String))
                dt.Columns.Add("unit_price", GetType(Decimal))
                dt.Columns.Add("discount", GetType(String))
                dt.Columns.Add("discounted_price", GetType(Decimal))


                Using cmd = New MySqlCommand("SELECT order_item, date_released FROM ims_orders 
                                WHERE date_released >= DATE_SUB(CURDATE(), INTERVAL 6 MONTH) AND date_released <= CURDATE() AND customer=@customer
                                ORDER BY date_released DESC", conn)
                    cmd.Parameters.AddWithValue("@customer", CustomerDetails.customer_id)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            historydata_to_grid(rdr("date_released"), rdr("order_item"), dt)
                        End While
                    End Using
                End Using

                grid_history.DataSource = dt

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Data to Field
    Public Function LoadData(orderid As String)

        lbl_orderid.Text = orderid

        Try

            Load_CustomerList()
            Load_Warehouse()
            Create_DataSource_gridorder()

            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT *, ims_users.first_name AS sales_agent_name, ims_stores.store_name AS target_warehouse_name 
                FROM ims_orders
                LEFT JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id 
                LEFT JOIN ims_users ON ims_users.usr_id=ims_orders.sales_agent 
                LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                WHERE order_id=" & orderid

                Dim cmd = New MySqlCommand(query, conn)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read

                    'LIMIT ACCESS TO CERTAIN GROUPS ONLY
                    'Dim user_role_id As Integer = frm_main.lbl_user_role_id.Text
                    'If rdr("account_type").Equals("Sister Company") And Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then
                    '    MsgBox("You are not allowed to view this order.", vbExclamation, "Forbidden")
                    '    Return False
                    'End If

                    'Order Details
                    Me.Text = "Sales Order #" & orderid & " - " & rdr("first_name")
                    lbl_status.Text = rdr("status")
                    txt_quote_id.Text = IIf(IsDBNull(rdr("quotation_ref")), String.Empty, rdr("quotation_ref"))
                    txt_po_ref.Text = rdr("po_reference")
                    lbl_creation_date.Text = FormatDateTime(rdr("date_ordered"), DateFormat.LongDate)

                    'Warehouse
                    cbb_warehouse.Text = rdr("target_warehouse_name")

                    'Customer Account Details
                    txt_customer_id.Text = rdr("customer_id")
                    cbb_customer.SelectedText = rdr("first_name")
                    txt_account_type.Text = rdr("account_type")
                    txt_contact_person.Text = rdr("contact_person")
                    txt_contact_no.Text = rdr("contact")
                    txt_tin_no.Text = rdr("tin_no")
                    se_terms.EditValue = CDec(rdr("terms"))
                    txt_sales_agent.Text = IIf(IsDBNull(rdr("sales_agent_name")), String.Empty, rdr("sales_agent_name"))

                    'Sales Return
                    If Not IsDBNull(rdr("sales_return")) Then
                        Dim resultList As List(Of Integer) = JsonConvert.DeserializeObject(Of List(Of Integer))(rdr("sales_return"))
                        LoadReturns_v2(resultList)
                    End If

                    'Bill & Shipping Address
                    txt_billing.Text = rdr("bill_to")
                    txt_shipping.Text = rdr("ship_to")
                    If Equals(txt_billing.Text, txt_shipping.Text) Then cb_same_billing.Checked = True

                    'Public, Private & Trucking Note
                    txt_pub_notes.Text = rdr("pub_note")
                    txt_priv_notes.Text = rdr("priv_note")
                    txt_trucking.Text = rdr("trucking")

                    'Set Delivery Fee
                    txt_delivery_fee.Text = FormatCurrency(rdr("delivery_fee"))
                    'Set Shipping Method
                    rg_shipping_method.EditValue = rdr("shipping_method")
                    'Set Payment Type
                    rg_payment.EditValue = rdr("payment_type")

                    'Display Payment Status Computation
                    lbl_amount_to_pay.Text = FormatCurrency(rdr("amount_due"))
                    lbl_paid_amount.Text = FormatCurrency(rdr("paid_amount"))
                    lbl_credit.Text = FormatCurrency(rdr("credit_amount"))

                    'Set Payment Status
                    Select Case rdr("payment_status")
                        Case "UNPAID"
                            lbl_payment_status.Text = "UNPAID"
                            lbl_payment_status.Appearance.BackColor = Color.Red
                            lbl_payment_status.Appearance.ForeColor = Color.White
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
                                panel_sales_returns.Enabled = False

                                '### Set btn_refund : OBSOLETE
                                If rdr("payment_type").Equals("Cash") Or rdr("payment_type").Equals("E-Payment") Or rdr("payment_type").Equals("Cheque") Then
                                    btn_refund.Enabled = True
                                End If

                                '### Set if Requesting Refund : OBSOLETE
                                If rdr("payment_status").Equals("REFUND") Then
                                    lbl_payment_status.Text = "FOR REFUND"
                                    lbl_payment_status.Appearance.BackColor = Color.Purple
                                    btn_refund.Enabled = False
                                End If

                            End If
                    End Select

                    'Set Discount Value and Type
                    If Not IsDBNull(rdr("discount_val")) Then txt_discount.Text = rdr("discount_val")
                    If Not IsDBNull(rdr("discount_type")) Then cbb_discount.Text = rdr("discount_type")

                    'Set Packing Requirements
                    If Not IsDBNull(rdr("packing_requirements")) Then
                        Dim packing_req As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(rdr("packing_requirements"))
                        For Each req As String In packing_req
                            For Each item As CheckedListBoxItem In clbc_packing_req.Items
                                If Equals(item.Value, req) Then
                                    item.CheckState = CheckState.Checked
                                End If
                            Next
                        Next
                    End If



                    cb_vatable.Checked = rdr("is_vatable")
                    cb_vat_exempt.Checked = rdr("is_vat_exempt")
                    cb_vat_zero.Checked = rdr("is_vat_zero")
                    txt_vat_zero_value.EditValue = rdr("vat_zero_value")
                    txt_invoice.Text = rdr("invoice_no").ToString

                    'If Not IsDBNull(rdr("withholding_tax_percentage")) Then lbl_withholding_tax_percentage.Text = "Less: EWT " & FormatPercent(rdr("withholding_tax_percentage") / 100)
                    If Not IsDBNull(rdr("withholding_tax_amount")) Then lbl_withholding_tax_amount.Text = IIf(rdr("withholding_tax_amount") = 0.000, String.Empty, FormatPercent(rdr("withholding_tax_amount")))
                    cb_withholding_tax_applied.Checked = rdr("is_withholding_tax_applied")

                    'Set Orders To GRID
                    data_to_grid(rdr("order_item"))
                    Set_Restrictions(rdr("account_type"))

                End While

                rdr.Close()

            End Using

            '--- UPDATING GUI

            cbb_customer.ReadOnly = True
            btn_create.Visible = False
            btn_save.Location = btn_create.Location
            btn_save.Visible = True
            txt_search.Select()
            btn_print.Enabled = True
            btn_print.Enabled = True
            cbb_warehouse.Enabled = False
            btn_pack.Text = "Pack"

            'Status
            Select Case lbl_status.Text
                Case "Pending"
                    btn_pack.Enabled = True
                    cbb_warehouse.Enabled = True

                Case "Pending for Arrangement"
                    btn_pack.Text = "Arranging..."
                    cbb_warehouse.Enabled = True

                Case "For Packing"
                    btn_pack.Text = "Arranging..."

                Case "Packed"
                    btn_delete.Enabled = False
                    btn_pack.Text = "Void"
                    btn_pack.Enabled = True
                    btn_pack.Appearance.BackColor = Color.GreenYellow
                    col_qty.OptionsColumn.AllowEdit = False

                Case "Released"
                    btn_delete.Enabled = False
                    col_qty.OptionsColumn.AllowEdit = False

                Case "Cancelled"
                    btn_import.Enabled = False
                    btn_delete.Enabled = False
                    grid_order.Enabled = False
                    grid_order_view.OptionsBehavior.ReadOnly = True

                Case "Completed"
                    btn_delete.Enabled = False
                    col_qty.OptionsColumn.AllowEdit = False
                    btn_import.Enabled = False

                Case "Deleted"
                    btn_delete.Enabled = False
                    btn_import.Enabled = False
                    txt_search.Enabled = False
                    btn_save.Enabled = False
                    grid_order_view.OptionsBehavior.ReadOnly = True

            End Select

            'ENABLE ACCESS FOR ADMINISTRATORS
            If frm_main.lbl_user_role_id.Text.Equals("1") And Not lbl_status.Text = "Deleted" Then
                txt_search.Enabled = True
                btn_save.Enabled = True
                col_qty.OptionsColumn.AllowEdit = True
            End If

            'DISABLE INSERT ORDER IF FROM QUOTATION
            If Not String.IsNullOrEmpty(txt_quote_id.Text) Then
                If Not (frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 6) Then
                    txt_search.Enabled = False
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function

    Private Sub Set_Restrictions(account_type As String)
        'LIMIT ACCESS TO CERTAIN GROUPS ONLY
        Dim user_role_id As Integer = frm_main.lbl_user_role_id.Text
        If (account_type.Equals("Sister Company") Or account_type.Equals("Branch")) And Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then
            col_unit_price.Visible = False
            col_discount.Visible = False
            col_d_price.Visible = False
            col_total_price.Visible = False
            col_search_discount.Visible = False
            col_search_unit_price.Visible = False
            col_history_discountedprice.Visible = False

            'PAYMENT STATUS FIELDS
            lbl_amount_to_pay.Visible = False
            lbl_paid_amount.Visible = False
            lbl_balance.Visible = False

            panel_computation.Visible = False
        Else
            col_unit_price.Visible = True
            col_discount.Visible = True
            col_d_price.Visible = True
            col_total_price.Visible = True
            col_search_discount.Visible = True
            col_search_unit_price.Visible = True
            col_history_discountedprice.Visible = True

            'PAYMENT STATUS FIELDS
            lbl_amount_to_pay.Visible = True
            lbl_paid_amount.Visible = True
            lbl_balance.Visible = True

            panel_computation.Visible = True
        End If
    End Sub

    'Show Qty Dialog
    Private Sub Show_QtyDialog()
        Try
            Dim qty_dialog = New frm_sales_order_qty_dialog

            If qty_dialog.ShowDialog() = DialogResult.OK Then

                Using dt = TryCast(grid_order.DataSource, DataTable)
                    With grid_search_view

                        Dim total_amount As Decimal = qty_dialog.quantity_entered * CDec(.GetFocusedRowCellValue(col_search_unit_price))

                        'Credit Balance Checking
                        If CDec(lbl_total.Text) + total_amount > CDec(txt_available_credit.Text) And rg_payment.EditValue = "Terms" Then
                            MsgBox("Credit balance exceeded!", vbCritical, "Low Balance")
                            Return
                        End If

                        dt.Rows.Add(
                                .GetFocusedRowCellValue(col_search_pid),
                                qty_dialog.quantity_entered,
                                .GetFocusedRowCellValue(col_search_model),
                                .GetFocusedRowCellValue(col_search_description),
                                CDec(.GetFocusedRowCellValue(col_search_srp)),
                                .GetFocusedRowCellValue(col_search_discount),
                                .GetFocusedRowCellValue(col_search_unit_price),
                                total_amount,
                                .GetFocusedRowCellValue(col_search_unit),
                                .GetFocusedRowCellValue(col_search_vol),
                                .GetFocusedRowCellValue(col_search_weight)
                                )

                    End With
                End Using

                ComputeTotal()

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Compute Total
    Public Sub ComputeTotal()
        Try
            Dim sub_total As Decimal
            Dim total_volume As Double
            Dim total_weight As Double
            Dim vatable_sales As Decimal
            Dim vat_amount As Decimal
            Dim returns_selectedRowHandles = grid_returns_view.GetSelectedRows
            Dim returns_total_amount As Decimal = 0.00
            Dim dt = TryCast(grid_order.DataSource, DataTable)
            lbl_item_qty.Text = dt.Rows.Count

            'GET TOTAL : ORDERS
            For Each row As DataRow In dt.Rows
                sub_total += row.Item("total_price")
                total_volume += IIf(IsDBNull(row.Item("volume")), 0, row.Item("volume"))
                total_weight += IIf(IsDBNull(row.Item("weight")), 0, row.Item("weight"))
            Next

            'GET TOTAL : SALES RETURNS
            For i = 0 To returns_selectedRowHandles.Length - 1
                returns_total_amount += grid_returns_view.GetRowCellValue(returns_selectedRowHandles(i), col_return_amount)
            Next

            'DISPLAY SUBTOTAL
            lbl_gross_sales.Text = FormatCurrency(sub_total)

            'LESS DISCOUNT
            If Not String.IsNullOrEmpty(txt_discount.Text) And Not String.IsNullOrEmpty(cbb_discount.Text) Then

                If cbb_discount.EditValue.Equals("peso") Then 'IF PESO
                    sub_total -= Decimal.Parse(txt_discount.Text)
                    lbl_discount.Text = FormatCurrency(txt_discount.Text)

                ElseIf cbb_discount.EditValue.Equals("%") Then 'IF PERCENT
                    Dim discount_amout As Decimal = sub_total * (txt_discount.Text / 100)
                    sub_total -= discount_amout
                    lbl_discount.Text = FormatCurrency(discount_amout)
                End If
            Else
                lbl_discount.Text = FormatCurrency(0)
            End If

            'DEDUCT SALES RETURNS
            If returns_total_amount > 0 Then
                sub_total -= returns_total_amount
            End If

            'DISPLAY SUBTOTAL - DISCOUNT
            lbl_net_sales.Text = FormatCurrency(sub_total)

            'DISPLAY 12% VAT
            If cb_vatable.Checked = True Then

                vatable_sales = sub_total / VAT_percentage
                vat_amount = vatable_sales * (VAT_percentage - 1)
                lbl_vat_excl_sales.Text = FormatCurrency(vatable_sales)

                If cb_vat_zero.Checked = True Or cb_vat_exempt.Checked = True Then
                    sub_total -= vat_amount
                    lbl_vat_amount.Text = FormatCurrency(0)

                    'If Not txt_vat_zero_value.EditValue = 0 Then
                    '    vatable_sales = sub_total / ((CDec(txt_vat_zero_value.EditValue) / 100) + 1)
                    '    Dim vat_amount = vatable_sales * ((CDec(txt_vat_zero_value.EditValue) / 100) + 1)
                    '    lbl_vat_amount.Text = FormatCurrency(sub_total - vatable_sales) 'FormatCurrency(vat_amount)
                    'End If
                Else
                    lbl_vat_amount.Text = FormatCurrency(vat_amount)
                End If


            Else
                lbl_vat_excl_sales.Text = ""
                lbl_vat_amount.Text = ""
            End If

            'DISPLAY TOTAL : SALES & RETURNS
            lbl_total_sales.Text = FormatCurrency(sub_total)
            lbl_credit.Text = FormatCurrency(returns_total_amount)

            'LESS WITHHOLDING TAX & DISPLAY
            If cb_withholding_tax_applied.Checked = True Then
                'Dim vatable_sales As Decimal = sub_total / VAT_percentage

                Dim withholding_tax_percentage = CDec(lbl_withholding_tax_percentage.Text.Replace("Less: EWT (", String.Empty).Replace("%)", String.Empty)) / 100
                Dim withholding_tax_amount As Decimal = vatable_sales * withholding_tax_percentage
                sub_total -= withholding_tax_amount
                lbl_withholding_tax_amount.Text = FormatCurrency(withholding_tax_amount)
            Else
                lbl_withholding_tax_amount.Text = ""
            End If


            'ADD DELIVERY FEE
            If Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
                lbl_delivery_fee.Text = FormatCurrency(txt_delivery_fee.Text)
                sub_total += CDec(txt_delivery_fee.Text)
                If CDec(txt_delivery_fee.Text) = 0 Then
                    txt_delivery_fee.Text = ""
                    lbl_delivery_fee.Text = ""
                End If
            End If

            'DISPLAY FINAL AMOUNT
            lbl_total.Text = FormatCurrency(sub_total)
            lbl_amount_to_pay.Text = FormatCurrency(sub_total)
            lbl_balance.Text = FormatCurrency(sub_total - CDec(lbl_paid_amount.Text))

            'Compute Volume & Weight

            lbl_vol.Text = total_volume & "cm3"
            lbl_wt.Text = total_weight & "kg"

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Clear All Fields
    Private Sub ClearFields()

        CustomerDetails.customer_id = 0
        CustomerDetails.sales_agent = 0

        cbb_customer.SelectedIndex = -1
        txt_account_type.Text = String.Empty
        grid_search.DataSource = Nothing

        'CLEAR ORDER DETAILS
        se_terms.EditValue = 0
        txt_po_ref.Text = String.Empty
        txt_quote_id.Text = String.Empty
        rg_shipping_method.SelectedIndex = -1
        txt_billing.Text = String.Empty
        txt_shipping.Text = String.Empty
        cb_same_billing.Checked = False
        txt_trucking.Text = String.Empty
        txt_delivery_fee.Text = ""
        cb_vatable.Checked = False
        cb_withholding_tax_applied.Checked = False
        txt_invoice.Text = String.Empty

        'CLEAR CUSTOMER INFORMATION
        txt_customer_id.Text = String.Empty
        txt_contact_person.Text = String.Empty
        txt_contact_no.Text = String.Empty
        txt_sales_agent.Text = String.Empty
        txt_credit_limit.Text = String.Empty
        txt_used_credit.Text = String.Empty
        txt_available_credit.Text = String.Empty

        'CLEAR COMMENTS
        txt_pub_notes.Text = String.Empty
        txt_priv_notes.Text = String.Empty

        'CLEAR ORDER ROWS
        TryCast(grid_order.DataSource, DataTable).Rows.Clear()

        'CLEAR COMPUTATION
        txt_discount.Text = String.Empty
        txt_discount.Enabled = False
        cbb_discount.SelectedIndex = -1

        lbl_gross_sales.Text = FormatCurrency(0)
        lbl_discount.Text = FormatCurrency(0)
        lbl_net_sales.Text = FormatCurrency(0)
        lbl_vat_amount.Text = ""
        lbl_withholding_tax_amount.Text = ""
        lbl_delivery_fee.Text = ""
        lbl_total.Text = FormatCurrency(0)

        'RESET GUI
        btn_unserved_list.Enabled = False

    End Sub

    'Set Grid Data
    Public Sub data_to_grid(units As String)

        Dim comma(), equal() As String
        Dim piece As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim tmp_dt = TryCast(grid_order.DataSource, DataTable)

        'CLEAR DATATABLE FIRST
        If tmp_dt.Rows.Count > 0 Then
            tmp_dt.Rows.Clear()
        End If

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                If equal.Length = 6 Then    '---- OLD 
                    tmp_dt.Rows.Add(0, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), 0.00, equal(5).Replace(";", String.Empty))

                ElseIf equal.Length = 8 Then    '---- NEW 
                    Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7).Replace(";", String.Empty))
                    tmp_dt.Rows.Add(0, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), equal(5), equal(6), unit)

                ElseIf equal.Length = 10 Then
                    Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7))
                    tmp_dt.Rows.Add(0, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), equal(5), equal(6), unit, equal(8), equal(9).Replace(";", String.Empty))

                End If


            Next

            ComputeTotal()

        End If

    End Sub

    Public Sub historydata_to_grid(date_released As Date, units As String, dt As DataTable)

        Dim comma(), equal() As String
        Dim piece As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                dt.Rows.Add(date_released, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), equal(5).Replace(";", String.Empty))

                'If equal.Length = 6 Then    '---- OLD 
                '    dt.Rows.Add(date_released, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), 0.00, equal(5).Replace(";", String.Empty))

                'ElseIf equal.Length = 8 Then    '---- NEW 
                '    Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7).Replace(";", String.Empty))
                '    dt.Rows.Add(date_released, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), equal(5), equal(6), unit)

                'ElseIf equal.Length = 10 Then
                '    dt.Rows.Add(date_released, equal(0), equal(1), equal(2), equal(3), IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)), equal(5))

                'End If


            Next

        End If

    End Sub

    'Set Print Data
    Public Sub data_to_print(units As String, tbl As DataTable, UseFor As String, Optional ByVal warehouse As String = "")

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If tbl.Rows.Count > 0 Then tbl.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            'DECLARE VALUES
            warehouse = "ims_" & warehouse.Replace(" ", "_").ToLower
            comma = colonseparator.Split(units)

            'QUERY : GET LOCATION AND LOCATION 2
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT warehouse.location, warehouse.location_2, unit 
                                            FROM ims_inventory
                                            LEFT JOIN " & warehouse & " AS warehouse ON warehouse.pid=ims_inventory.pid
                                            WHERE ims_inventory.winmodel=@model", conn)

                    cmd.Parameters.AddWithValue("@model", String.Empty)
                    cmd.Prepare()

                    For i = 0 To comma.Length - 1
                        piece = comma(i).Trim
                        equal = piece.Split("=")
                        'MsgBox(comma(i))
                        Select Case UseFor

                            Case "Packing"
                                cmd.Parameters(0).Value = equal(1).ToString
                                Using rdr = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        rdr.Read()
                                        tbl.Rows.Add(equal(0), equal(1), equal(2), rdr("location"), rdr("location_2"), rdr("unit"))
                                    End If
                                End Using

                            Case "Draft"
                                cmd.Parameters(0).Value = equal(1).ToString
                                Using rdr = cmd.ExecuteReader
                                    rdr.Read()

                                    If equal.Length = 6 Then    '---- OLD 
                                        tbl.Rows.Add(equal(0),
                                                     equal(1),
                                                     equal(2),
                                                     equal(3),
                                                     IIf(Equals(equal(4), "0"), "", equal(4)),
                                                     Nothing, equal(5).Replace(";", String.Empty),
                                                     rdr("unit"))
                                    ElseIf equal.Length = 8 Then    '---- NEW 

                                        Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7).Replace(";", String.Empty))

                                        tbl.Rows.Add(equal(0),
                                                     equal(1),
                                                     equal(2),
                                                     equal(3),
                                                     IIf(Equals(equal(4), "0"), "", equal(4)),
                                                     equal(5),
                                                     equal(6),
                                                     unit)
                                    End If


                                End Using
                        End Select

                    Next

                End Using
            End Using

        End If

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
                        is_vatable, is_withholding_tax_applied, withholding_tax_percentage, withholding_tax_amount, delivery_fee, ims_customers.account_type,
                        amount_due, shipping_method, trucking, date_released, ims_stores.store_name,
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store, (SELECT VALUE FROM ims_settings WHERE NAME='store_info') AS store_info FROM `ims_orders`
                        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer 
                        LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                        WHERE order_id=@id", conn)
                cmd.Parameters.AddWithValue("@id", orderid)
                rdr = cmd.ExecuteReader

                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store")
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

                    data_to_print(rdr("order_item"), table.invoice_data, "Draft", rdr("store_name"))

                    'SET RESTRICTION FOR NON-ADMIN ACCOUNTS
                    Dim user_role_id As Integer = frm_main.lbl_user_role_id.Text
                    If Equals("Sister Company", rdr("account_type")) Or Equals("Branch", rdr("account_type")) And Not (user_role_id = 1 Or user_role_id = 2 Or user_role_id = 3 Or user_role_id = 4) Then
                        report.header_unit_price.Text = ""
                        report.header_discount.Text = ""
                        report.header_d_price.Text = ""
                        report.header_total_price.Text = ""
                        report.cell_unit_price.Visible = False
                        report.cell_discount.Visible = False
                        report.cell_d_price.Visible = False
                        report.cell_total_price.Visible = False
                        report.lbl_subtotal.Visible = False
                        report.lbl_discount.Visible = False
                        report.lbl_total_sales.Visible = False
                        report.lbl_total_amount_due.Text = FormatCurrency(0)
                    End If

                End While
            End Using


            report.RequestParameters = False
            report.DataSource = table
            report.ShowRibbonPreviewDialog()

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
        Dim packing_list_req As String = String.Empty

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_customers.contact_person, 
                            ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, 
                            ims_orders.priv_note, trucking, shipping_method, po_reference, ims_stores.store_name, volume, weight, packing_requirements
                            FROM `ims_orders` 
                            LEFT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                            LEFT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'"
                Dim cmd = New MySqlCommand(query, conn)
                rdr = cmd.ExecuteReader

                While rdr.Read
                    report.Parameters("order_id").Value = String.Concat("SO", rdr("order_id").ToString.PadLeft(6, "0"c))
                    report.Parameters("customer").Value = rdr("customer")
                    report.Parameters("contact_person").Value = rdr("contact_person")
                    report.Parameters("address").Value = rdr("ship_to")
                    report.Parameters("agent").Value = rdr("agent")
                    report.Parameters("ordered_date").Value = rdr("date_ordered")
                    report.Parameters("priv_notes").Value = rdr("priv_note")
                    report.Parameters("trucking").Value = rdr("trucking")
                    report.Parameters("shipping_method").Value = rdr("shipping_method")
                    report.Parameters("po_reference").Value = rdr("po_reference")
                    report.Parameters("target_warehouse").Value = rdr("store_name")
                    report.Parameters("volume").Value = rdr("volume")
                    report.Parameters("weight").Value = rdr("weight")

                    If Not IsDBNull(rdr("packing_requirements")) Then
                        Dim requirements_list As List(Of String) = JsonConvert.DeserializeObject(Of List(Of String))(rdr("packing_requirements"))
                        For Each item As String In requirements_list
                            packing_list_req += " " & item & ","
                        Next
                        ' Remove the last comma from the final string
                        If packing_list_req.EndsWith(",") Then
                            packing_list_req = packing_list_req.Remove(packing_list_req.Length - 1)
                        End If
                    End If


                    report.Parameters("packing_req").Value = packing_list_req
                    data_to_print(rdr("order_item"), table.packing_list, "Packing", rdr("store_name"))

                End While

                report.RequestParameters = False
                report.DataSource = table
                printTool.ShowRibbonPreviewDialog()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Validation
    Private Function ValidationOnSubmit() As Boolean

        If cbb_customer.SelectedIndex = -1 Or cbb_warehouse.SelectedIndex = -1 Or grid_order_view.RowCount = 0 Then
            MsgBox("Complete all fields!", vbCritical, "Required")
            Return False
        End If

        If String.IsNullOrWhiteSpace(rg_payment.EditValue) Then
            MsgBox("Select payment method!", vbCritical, "Required")
            Return False
        End If

        If String.IsNullOrWhiteSpace(rg_shipping_method.EditValue) Then
            MsgBox("Select shipping method!", vbCritical, "Shipping Not Found")
            Return False
        End If

        If cb_vatable.Checked = True And String.IsNullOrWhiteSpace(txt_invoice.EditValue) Then
            MsgBox("Invoice No. is needed.", vbCritical, "Required")
            Return False
        End If

        If CDec(lbl_total.Text) > CDec(txt_available_credit.EditValue) And rg_payment.EditValue = "Terms" Then
            MsgBox("Insufficent credit balance.", vbCritical, "Insufficient")
            Return False
        End If


        Return True

    End Function




    '>>> CONTROL EVENTS

    'GRID_SEARCH : ADD ITEM
    Private Sub btn_add_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btn_add.ButtonClick
        Show_QtyDialog()
    End Sub

    'SHORTCUT
    Private Sub frm_sales_order_new_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            Show_QtyDialog()
        ElseIf e.KeyCode = Keys.F1 Then
            txt_search.Select()
        ElseIf e.Control = True And e.KeyCode = Keys.W Then
            grid_search_view.Focus()
        End If
    End Sub

    'CBB : CUSTOMER
    Private Sub cbb_customer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedValueChanged

        If cbb_customer.SelectedIndex = -1 Then Return

        Try

            Using connection = New MySqlConnection(str)
                connection.Open()


                Dim cmd = New MySqlCommand("SELECT account_type, customer_id, account_type, address, contact_person, contact, terms, tin_no,
                    trucking_note, credit_limit, used_credit, preferred_shipping, preferred_payment, agent.usr_id, agent.first_name AS sales_agent 
                    FROM ims_customers
                    LEFT JOIN ims_users AS agent ON agent.usr_id=ims_customers.assigned_agent 
                    WHERE ims_customers.first_name=@customer AND is_deleted='0'", connection)
                cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read

                    CustomerDetails.customer_id = rdr("customer_id")
                    CustomerDetails.sales_agent = IIf(IsDBNull(rdr("usr_id")), 0, rdr("usr_id"))
                    CustomerDetails.account_terms = rdr("terms")
                    rg_payment.EditValue = IIf(IsDBNull(rdr("preferred_payment")), "CEC", rdr("preferred_payment"))


                    rg_shipping_method.EditValue = rdr("preferred_shipping")
                    txt_billing.Text = rdr("address")
                    txt_trucking.Text = rdr("trucking_note")

                    txt_customer_id.Text = rdr("customer_id")
                    txt_account_type.Text = rdr("account_type")
                    txt_contact_person.Text = rdr("contact_person")
                    txt_contact_no.Text = rdr("contact")
                    txt_tin_no.Text = rdr("tin_no")
                    txt_credit_limit.Text = FormatCurrency(rdr("credit_limit"), 2)
                    txt_used_credit.Text = FormatCurrency(rdr("used_credit"), 2)
                    txt_available_credit.Text = FormatCurrency(rdr("credit_limit") - rdr("used_credit"), 2)
                    txt_sales_agent.Text = IIf(IsDBNull(rdr("sales_agent")), Nothing, rdr("sales_agent"))

                    Set_Restrictions(rdr("account_type"))

                End While
            End Using

            Load_SearchGrid()
            'LoadReturns(rid)
            LoadReturns_v2(Nothing)
            LoadHistory()

            btn_import.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'TEXTBOX : DISCOUNT
    Private Sub txt_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyUp
        ComputeTotal()
    End Sub

    'CBB : DISCOUNT
    Private Sub cbb_discount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_discount.SelectedIndexChanged
        If cbb_discount.SelectedIndex = 1 Or cbb_discount.SelectedIndex = 2 Then
            txt_discount.Enabled = True
        Else
            txt_discount.Enabled = False
            txt_discount.Text = ""
        End If
        ComputeTotal()
    End Sub

    'TEXTBOX : DELIVERY FEE
    Private Sub txt_delivery_fee_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_delivery_fee.KeyUp
        ComputeTotal()
    End Sub

    'CHECKBOX : WITHHOLDING TAX
    Private Sub cb_withholding_tax_applied_CheckedChanged(sender As Object, e As EventArgs) Handles cb_withholding_tax_applied.CheckedChanged
        If cb_withholding_tax_applied.Checked = True Then
            cb_nonvatable.Enabled = False
            cb_vatable.Enabled = False
            cb_vatable.Checked = True
        Else
            cb_vatable.Enabled = True
            cb_nonvatable.Enabled = True
        End If
        ComputeTotal()
    End Sub

    'SPIN_EDIT : TERMS
    Private Sub se_terms_EditValueChanged(sender As Object, e As EventArgs) Handles se_terms.EditValueChanged

        If rg_payment.EditValue = "CEC" Then
            If Not frm_main.lbl_user_role_id.Text.Equals("1") Then
                se_terms.EditValue = 0
                lbl_admin_only.Visible = True
            End If

        ElseIf rg_payment.EditValue = "Terms" Then
            If se_terms.EditValue > CustomerDetails.account_terms Then
                If Not frm_main.lbl_user_role_id.Text.Equals("1") Then
                    MsgBox("Longer terms than default is detected!" & vbCrLf & "Please ask your administrator.", MsgBoxStyle.Critical, "Information")
                    se_terms.EditValue = CustomerDetails.account_terms
                    Return
                End If
            ElseIf se_terms.EditValue < 0 Then
                se_terms.EditValue = 0
            End If
        End If

    End Sub

    'CHECKBOX : SAME BILLING
    Private Sub cb_same_billing_CheckedChanged(sender As Object, e As EventArgs) Handles cb_same_billing.CheckedChanged
        If cb_same_billing.Checked Then
            txt_shipping.Text = txt_billing.Text
            txt_shipping.Enabled = False
        Else
            txt_shipping.Text = String.Empty
            txt_shipping.Enabled = True
        End If
    End Sub

    'RADIOGROUP : PAYMENT TYPE
    'Private Sub rg_payment_type_Properties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rg_payment.Properties.SelectedIndexChanged
    '    If rg_payment_type.EditValue = "Terms" Then
    '        se_terms.EditValue = CustomerDetails.account_terms

    '    Else
    '        se_terms.EditValue = 0
    '    End If
    'End Sub

    Private Sub rg_payment_EditValueChanged(sender As Object, e As EventArgs) Handles rg_payment.EditValueChanged
        If rg_payment.EditValue = "CEC" Then
            se_terms.EditValue = 0
        ElseIf rg_payment.EditValue = "Terms" Then
            se_terms.EditValue = CustomerDetails.account_terms
            lbl_admin_only.Visible = False
        End If
    End Sub

    'GRID_ORDER : CELL VALUE CHANGED
    Private Property discount_counter As Integer = 0
    Private Sub grid_order_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_order_view.CellValueChanged

        Try
            If Equals(e.Column, col_qty) Then
                If grid_order_view.GetFocusedRowCellValue(col_discount).Equals("NET") Or
                    grid_order_view.GetFocusedRowCellValue(col_discount).Equals("*") Or
                    IsDBNull(grid_order_view.GetFocusedRowCellValue(col_discount)) Or String.IsNullOrWhiteSpace(grid_order_view.GetFocusedRowCellValue(col_discount)) Then
                    Dim discounted_price As Decimal = grid_order_view.GetFocusedRowCellValue(col_d_price)

                    Dim total_amount As Decimal = grid_order_view.GetFocusedRowCellValue(col_qty) * discounted_price
                    grid_order_view.SetFocusedRowCellValue(col_total_price, total_amount)

                Else
                    Dim price As Decimal = grid_order_view.GetFocusedRowCellValue(col_unit_price)
                    Dim discount As Decimal = grid_order_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
                    Dim discounted_price = price - (price * (discount / 100))
                    grid_order_view.SetFocusedRowCellValue(col_total_price, e.Value * discounted_price)
                End If
            End If

            'If Equals(e.Column, col_discount) Then
            '    If e.Value.Equals("NET") Or e.Value.Equals("*") Or String.IsNullOrWhiteSpace(e.Value) Then
            '        Dim discounted_price As Decimal = grid_order_view.GetFocusedRowCellValue(col_d_price)
            '        grid_order_view.SetFocusedRowCellValue(col_total_price, grid_order_view.GetFocusedRowCellValue(col_qty) * discounted_price)

            '    Else
            '        Dim price As Decimal = grid_order_view.GetFocusedRowCellValue(col_unit_price)
            '        Dim discount As Decimal = grid_order_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
            '        Dim discounted_price = price - (price * (discount / 100))
            '        grid_order_view.SetFocusedRowCellValue(col_d_price, discounted_price)
            '        grid_order_view.SetFocusedRowCellValue(col_total_price, grid_order_view.GetFocusedRowCellValue(col_qty) * discounted_price)
            '    End If
            'End If

            If Equals(e.Column, col_unit_price) Then
                If grid_order_view.GetFocusedRowCellValue(col_discount).Equals("NET") Or grid_order_view.GetFocusedRowCellValue(col_discount).Equals("net") Or
                    grid_order_view.GetFocusedRowCellValue(col_discount).Equals("*") Or
                    IsDBNull(grid_order_view.GetFocusedRowCellValue(col_discount)) Or
                    String.IsNullOrWhiteSpace(grid_order_view.GetFocusedRowCellValue(col_discount)) Then

                    Dim discounted_price As Decimal = grid_order_view.GetFocusedRowCellValue(col_unit_price)
                    Dim qty As Decimal = grid_order_view.GetFocusedRowCellValue(col_qty)
                    grid_order_view.SetFocusedRowCellValue(col_d_price, discounted_price)
                    grid_order_view.SetFocusedRowCellValue(col_total_price, qty * discounted_price)
                Else
                    Dim price As Decimal = grid_order_view.GetFocusedRowCellValue(col_unit_price)
                    Dim discount As Decimal = grid_order_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
                    Dim discounted_price = price - (price * (discount / 100))
                    grid_order_view.SetFocusedRowCellValue(col_total_price, e.Value * discounted_price)
                    grid_order_view.SetFocusedRowCellValue(col_d_price, discounted_price)
                End If
            End If

            If Equals(e.Column, col_d_price) Then
                Dim discounted_price As Decimal = grid_order_view.GetFocusedRowCellValue(col_d_price)
                grid_order_view.SetFocusedRowCellValue(col_total_price, grid_order_view.GetFocusedRowCellValue(col_qty) * discounted_price)
            End If

            If Equals(e.Column, col_discount) Then

                'VALIDATION
                If Not (IsNumeric(e.Value) OrElse Equals(e.Value, "NET") OrElse Equals(e.Value, "*")) Then
                    MsgBox("Invalid value!", vbCritical, "Invalid")
                    Return
                End If

                'DECLARATIONS
                Dim pass As String = String.Empty
                Dim old_total_price As Decimal = grid_order_view.GetFocusedRowCellValue(col_qty) * grid_order_view.GetFocusedRowCellValue(col_unit_price)
                Dim cost As Decimal = 0.00

                'Discount Counter : NOT FOR ADMIN
                If Not frm_main.lbl_user_role_id.Text.Equals("1") Then
                    If discount_counter > 2 Then

                        'GETTING PASSWORD
                        If frm_sales_password_required.ShowDialog() = DialogResult.OK Then
                            If Not String.IsNullOrEmpty(frm_sales_password_required.Password) Then
                                pass = frm_sales_password_required.Password
                                frm_sales_password_required.Dispose()

                                'CHECK IF PASS IS CORRECT ELSE RESET TOTAL
                                Using connection = New MySqlConnection(str)
                                    connection.Open()
                                    Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_users WHERE role_id='1' AND pass=@pass", connection)
                                        cmd.Parameters.AddWithValue("@pass", Encrypt(pass))
                                        If cmd.ExecuteScalar = 0 Then
                                            MsgBox("Password is incorrect!", vbCritical, "Wrong Password")
                                            grid_order_view.SetFocusedRowCellValue(col_total_price, old_total_price)
                                            grid_order_view.SetFocusedRowCellValue(col_discount, 0)
                                            Return
                                        End If
                                    End Using
                                End Using
                            Else
                                MsgBox("Password can't be blank!", vbCritical, "Password Required")
                                Return
                            End If
                        Else
                            grid_order_view.SetFocusedRowCellValue(col_discount, 0)
                        End If
                    Else
                        grid_order_view.SetFocusedRowCellValue(col_discount, 0)
                    End If
                End If

                'VALIDATE
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim dt = TryCast(grid_order.DataSource, DataTable)

                    discount_counter += 1

                    'GET COST
                    Using cmd = New MySqlCommand("SELECT cost FROM ims_inventory WHERE winmodel=@winmodel", connection)
                        cmd.Parameters.AddWithValue("@winmodel", grid_order_view.GetFocusedRowCellValue(col_model))
                        Using rdr As MySqlDataReader = cmd.ExecuteReader
                            rdr.Read()
                            cost = rdr("cost")
                            rdr.Close()

                            Dim price As Decimal = 0.00
                            Dim discount As Decimal = 0.00
                            Dim discounted_price As Decimal = 0.00
                            If e.Value.Equals("NET") Or e.Value.Equals("*") Or String.IsNullOrWhiteSpace(e.Value) Then
                                discounted_price = grid_order_view.GetFocusedRowCellValue(col_d_price)
                            Else
                                price = grid_order_view.GetFocusedRowCellValue(col_unit_price)
                                discount = grid_order_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
                                discounted_price = price - (price * (discount / 100))
                            End If
                            If discounted_price < cost Then
                                MsgBox("Exceeded maximum discount, contact your administrator", vbExclamation, "Forbidden")
                                grid_order_view.SetFocusedRowCellValue(col_total_price, old_total_price)
                                grid_order_view.SetFocusedRowCellValue(col_discount, 0)
                            Else
                                If e.Value.Equals("NET") Or e.Value.Equals("*") Or String.IsNullOrWhiteSpace(e.Value) Then
                                    grid_order_view.SetFocusedRowCellValue(col_total_price, grid_order_view.GetFocusedRowCellValue(col_qty) * discounted_price)
                                Else
                                    grid_order_view.SetFocusedRowCellValue(col_d_price, discounted_price)
                                    grid_order_view.SetFocusedRowCellValue(col_total_price, grid_order_view.GetFocusedRowCellValue(col_qty) * discounted_price)

                                End If
                            End If

                        End Using
                    End Using
                End Using

            End If


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Information")
        End Try

        ComputeTotal()

    End Sub

    'GRID_ORDER : REMOVE ITEM
    Private Sub btn_remove_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btn_remove.ButtonClick
        Try
            grid_order_view.DeleteRow(grid_order_view.FocusedRowHandle)
            ComputeTotal()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'GRID_ORDER : ROWCOUNT_CHANGED
    Private Sub grid_order_view_RowCountChanged(sender As Object, e As EventArgs) Handles grid_order_view.RowCountChanged
        If grid_order_view.RowCount > 0 Then
            cbb_customer.Enabled = False
            btn_create.Enabled = True
            btn_pack.Enabled = True
        Else
            cbb_customer.Enabled = True
            btn_create.Enabled = False
            btn_pack.Enabled = False
        End If
    End Sub

    'GRID RETURNS : SELECTION CHANGED
    Private lockSelection As Boolean = False
    Private Sub grid_returns_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_returns_view.SelectionChanged

        ComputeTotal()

        '### SELECT ONLY 1 RETURN
        'If lockSelection Then
        '    Return
        'End If

        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView = TryCast(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        'Dim selectedRows() As Integer = grid_returns_view.GetSelectedRows()
        'lockSelection = True
        'For Each selectedRow As Integer In selectedRows
        '    If selectedRow <> e.ControllerRow Then
        '        view.UnselectRow(selectedRow)
        '    End If
        'Next selectedRow
        'lockSelection = False

    End Sub

    'BUTTON : UNSERVED LIST
    Private Sub btn_unserved_list_Click(sender As Object, e As EventArgs) Handles btn_unserved_list.Click
        Dim frm = New frm_sales_unserved_dialog
        frm.cid = CustomerDetails.customer_id
        frm.Show()
    End Sub

    'GRID_ORDER : Unserved Button
    Private Sub btn_unseved_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btn_unseved.ButtonClick
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'CHECK IF EXIST
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_sales_unserved_items 
                                                WHERE item=(SELECT pid FROM ims_inventory WHERE winmodel=@item) AND status='Unserved'", conn)
                    cmd.Parameters.AddWithValue("@item", grid_order_view.GetFocusedRowCellValue(col_model))
                    If cmd.ExecuteScalar > 0 Then
                        MsgBox("Duplicate item found in Unserved List!", vbCritical, "Duplicate")
                        Return
                    End If
                End Using

                'INSERT
                If MsgBox("Add to Unserved List?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                    Using cmd = New MySqlCommand("INSERT INTO ims_sales_unserved_items (customer_id, qty, item, created_at, status) VALUES
                                                (@customer_id, @qty, (SELECT pid FROM ims_inventory WHERE winmodel=@item), NOW(), 'Unserved')", conn)
                        cmd.Parameters.AddWithValue("@customer_id", CustomerDetails.customer_id)
                        cmd.Parameters.AddWithValue("@qty", grid_order_view.GetFocusedRowCellValue(col_qty))
                        cmd.Parameters.AddWithValue("@item", grid_order_view.GetFocusedRowCellValue(col_model))

                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Added!", vbInformation, "Information")
                            grid_order_view.DeleteRow(grid_order_view.FocusedRowHandle)
                        End If

                    End Using
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Draft Invoice
    Private Sub DraftInvoiceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DraftInvoiceToolStripMenuItem.Click
        btn_save_Click(Nothing, Nothing, True)
        'PrintDraftInvoice(lbl_orderid.Text)
        frm_sales_transaction_invoice.PrintInvoice(lbl_orderid.Text, "Unofficial Receipt")
    End Sub

    'Print Packing Slip
    Private Sub PackingSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PackingSlipToolStripMenuItem.Click
        print_packing_list(lbl_orderid.Text)
    End Sub

    'BUTTON : CREATE
    Dim order_id As Integer = 0
    Private Sub btn_create_Click(sender As Object, e As EventArgs, Optional no_confirmation As Boolean = False) Handles btn_create.Click

        'Validate
        If ValidationOnSubmit() = False Then
            Return
        End If

        If MsgBox("Press 'Yes' to create order.", vbInformation + vbYesNo, "Confirmation") = vbYes Then

            'Initialization
            Dim payment_type = rg_payment.EditValue
            Dim shipping_method = rg_shipping_method.EditValue
            Dim sales_returd_id As Integer = 0
            Dim sr_amount As Decimal = 0.00
            Dim packing_req As New List(Of String)
            Dim sales_returns As New List(Of Integer)

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'Get Orders to String
                    Dim orders = String.Empty
                    For Each row As DataRow In TryCast(grid_order.DataSource, DataTable).Rows
                        If String.IsNullOrEmpty(row.Item(1)) Then Continue For

                        Dim unit = IIf(IsDBNull(row.Item("unit")) Or String.IsNullOrEmpty(row.Item("unit").ToString), "NULL", row.Item("unit"))

                        orders += row.Item("qty") & "=" & row.Item("model") & "=" & row.Item("description") & "=" & row.Item("unit_price") &
                        "=" & row.Item("discount").ToString.Replace("%", String.Empty) & "=" & row.Item("discounted_price") & "=" & row.Item("total_price") & "=" & unit & "=" &
                        IIf(IsDBNull(row("volume")), 0, row("volume")) & "=" & IIf(IsDBNull(row("weight")), 0, row("weight")) & ";"
                    Next

                    'GET SALES RETURN ID AND AMOUNT : OLD (1 ONLY)
                    If grid_returns_view.GetSelectedRows.Count > 0 Then
                        sales_returd_id = grid_returns_view.GetRowCellValue(grid_returns_view.FocusedRowHandle, col_srid).ToString.Replace("SR", "")
                        sr_amount = grid_returns_view.GetRowCellValue(grid_returns_view.FocusedRowHandle, col_return_amount)
                    End If

                    'GET SALES RETURN ID AND AMOUNT : NEW (MULTIPLE)
                    For Each item In grid_returns_view.GetSelectedRows
                        sales_returns.Add(grid_returns_view.GetRowCellValue(item, col_srid))
                    Next

                    'GET PACKING REQUIREMENTS
                    For Each item As CheckedListBoxItem In clbc_packing_req.CheckedItems
                        packing_req.Add(item.Value)
                    Next

                    Dim query = "INSERT INTO ims_orders (customer, agent, bill_to, ship_to, quotation_ref, po_reference, order_item, target_warehouse, sales_return, applied_sales_return,
                    discount_val, discount_type, is_vatable, is_vat_exempt, is_vat_zero, vat_zero_value, invoice_no, is_withholding_tax_applied, withholding_tax_amount, withholding_tax_code, withholding_tax_percentage, delivery_fee,
                    pub_note, priv_note, status, date_ordered, payment_status, payment_type, shipping_method, amount_due, balance, trucking, terms, sales_agent, packing_requirements) 
                    VALUES (@customer_id, @agent_id, @bill_to, @ship_to, @quotation_ref, @po_reference, @order_item, (SELECT store_id FROM ims_stores WHERE store_name=@target_warehouse), @sales_return, @applied_sales_return,
                    @discount_val, @discount_type, @is_vatable, @is_vat_exempt, @is_vat_zero, @vat_zero_value, @invoice_no, @is_withholding_tax_applied, @withholding_tax_amount, @withholding_tax_code, @withholding_tax_percentage, @delivery_fee,
                    @pub_note, @priv_note, @status, @date_ordered, @payment_status, @payment_type, @shipping_method, @amount_due, @balance, @trucking, @terms, @sales_agent, @packing_requirements);
                    UPDATE ims_quotations SET is_converted='1', status='Converted' WHERE quotation_id=@qid"

                    Dim cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@customer_id", CustomerDetails.customer_id)
                    cmd.Parameters.AddWithValue("@agent_id", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("@bill_to", txt_billing.Text.Trim)
                    cmd.Parameters.AddWithValue("@ship_to", txt_shipping.Text.Trim)
                    cmd.Parameters.AddWithValue("@po_reference", txt_po_ref.Text.Trim)
                    cmd.Parameters.AddWithValue("@order_item", orders)
                    cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                    cmd.Parameters.AddWithValue("@is_vat_exempt", cb_vat_exempt.Checked)
                    cmd.Parameters.AddWithValue("@is_vat_zero", cb_vat_zero.Checked)
                    cmd.Parameters.AddWithValue("@vat_zero_value", txt_vat_zero_value.EditValue)
                    cmd.Parameters.AddWithValue("@invoice_no", txt_invoice.Text)
                    cmd.Parameters.AddWithValue("@discount_val", IIf(String.IsNullOrWhiteSpace(txt_discount.Text.Trim), 0.00, txt_discount.Text.Trim))
                    cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                    cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_withholding_tax_applied.Checked)
                    cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(IIf(String.IsNullOrWhiteSpace(lbl_withholding_tax_amount.Text), 0, lbl_withholding_tax_amount.Text)))
                    cmd.Parameters.AddWithValue("@withholding_tax_code", cbb_taxCode.EditValue)
                    cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("Less: EWT ", String.Empty).Replace("%", String.Empty)))
                    cmd.Parameters.AddWithValue("@delivery_fee", CDec(IIf(String.IsNullOrWhiteSpace(txt_delivery_fee.Text), 0, txt_delivery_fee.Text)))
                    cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                    cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                    cmd.Parameters.AddWithValue("@terms", se_terms.EditValue) 'IIf(rg_payment_type.EditValue = "Terms", se_terms.EditValue, 0))
                    cmd.Parameters.AddWithValue("@sales_agent", CustomerDetails.sales_agent)
                    cmd.Parameters.AddWithValue("@date_ordered", Date.Now)
                    cmd.Parameters.AddWithValue("@status", "Pending")
                    cmd.Parameters.AddWithValue("@payment_type", payment_type)
                    cmd.Parameters.AddWithValue("@payment_status", "UNPAID")
                    cmd.Parameters.AddWithValue("@shipping_method", shipping_method)
                    cmd.Parameters.AddWithValue("@amount_due", CDec(lbl_total.Text))
                    cmd.Parameters.AddWithValue("@balance", CDec(lbl_total.Text))
                    cmd.Parameters.AddWithValue("@trucking", txt_trucking.Text.Trim)
                    cmd.Parameters.AddWithValue("@quotation_ref", IIf(String.IsNullOrEmpty(txt_quote_id.Text), Nothing, txt_quote_id.Text))
                    cmd.Parameters.AddWithValue("@qid", CInt(IIf(String.IsNullOrEmpty(txt_quote_id.Text), 0, txt_quote_id.Text.Replace("Q", String.Empty))))
                    cmd.Parameters.AddWithValue("@target_warehouse", cbb_warehouse.Text)
                    cmd.Parameters.AddWithValue("@sales_return", JsonConvert.SerializeObject(sales_returns))
                    cmd.Parameters.AddWithValue("@applied_sales_return", sales_returd_id)
                    cmd.Parameters.AddWithValue("@packing_requirements", JsonConvert.SerializeObject(packing_req))
                    If cmd.ExecuteNonQuery() > 0 Then
                        order_id = cmd.LastInsertedId
                    End If

                End Using

                MsgBox("Successfully created!", vbInformation, "Information")

                If no_confirmation = False Then
                    Me.Close()
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'BUTTON : SAVE
    Private Sub btn_save_Click(sender As Object, e As EventArgs, Optional no_confirmation As Boolean = False) Handles btn_save.Click

        'Validation
        If ValidationOnSubmit() = False Then
            Return
        End If

        'Initialization
        Dim payment_type = rg_payment.EditValue
        Dim shipping_method = rg_shipping_method.EditValue
        Dim sales_return_id As Integer = 0
        Dim sr_amount As Decimal = 0.00
        Dim packing_req As New List(Of String)
        Dim sales_returns As New List(Of Integer)

        'Get Status
        Dim payment_status = String.Empty
        If CDec(lbl_total.Text) = CDec(lbl_paid_amount.Text) Then payment_status = "PAID"
        If CDec(lbl_total.Text) < CDec(lbl_paid_amount.Text) Then payment_status = "OVERPAID"
        If CDec(lbl_total.Text) > CDec(lbl_paid_amount.Text) Then payment_status = "PARTIAL"
        If CDec(lbl_paid_amount.Text) = 0 Then payment_status = "UNPAID"

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'Get Orders to String
                Dim orders = String.Empty
                For Each row As DataRow In TryCast(grid_order.DataSource, DataTable).Rows
                    If String.IsNullOrEmpty(row.Item(1)) Then Continue For

                    Dim unit = IIf(IsDBNull(row.Item("unit")) Or String.IsNullOrEmpty(row.Item("unit").ToString), "NULL", row.Item("unit"))

                    orders += row.Item("qty") & "=" & row.Item("model") & "=" & row.Item("description") & "=" & row.Item("unit_price") &
                        "=" & row.Item("discount").ToString.Replace("%", String.Empty) & "=" & row.Item("discounted_price") & "=" & row.Item("total_price") & "=" & unit & "=" &
                        IIf(IsDBNull(row("volume")), 0, row("volume")) & "=" & IIf(IsDBNull(row("weight")), 0, row("weight")) & ";"
                Next

                'GET SALES RETURN ID AND AMOUNT :  OLD (1 ONLY) sales_returns
                If grid_returns_view.GetSelectedRows.Count > 0 Then
                    sales_return_id = grid_returns_view.GetRowCellValue(grid_returns_view.GetSelectedRows(0), col_srid).ToString.Replace("SR", "")
                    sr_amount = grid_returns_view.GetRowCellValue(grid_returns_view.GetSelectedRows(0), col_return_amount)
                End If

                'GET SALES RETURN ID AND AMOUNT : NEW (Multiple)
                For Each item In grid_returns_view.GetSelectedRows
                    sales_returns.Add(grid_returns_view.GetRowCellValue(item, col_srid))
                Next

                'GET PACKING REQUIREMENTS
                For Each item As CheckedListBoxItem In clbc_packing_req.CheckedItems
                    packing_req.Add(item.Value)
                Next

                Dim query = "UPDATE ims_orders SET bill_to=@bill_to, ship_to=@ship_to, trucking=@trucking, payment_status=@payment_status,
                            order_item=@order_item, pub_note=@pub_note, priv_note=@priv_note, terms=@terms, target_warehouse=(SELECT store_id FROM ims_stores WHERE store_name=@target_warehouse),
                            is_vatable=@is_vatable, is_vat_exempt=@is_vat_exempt, is_vat_zero=@is_vat_zero, vat_zero_value=@vat_zero_value, invoice_no=@invoice_no, discount_val=@discount_val, discount_type=@discount_type,
                            is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_code=@withholding_tax_code, withholding_tax_percentage=@withholding_tax_percentage,
                            delivery_fee=@delivery_fee, amount_due=@amount_due, balance=@balance, credit_amount=@credit_amount, po_reference=@po_reference, sales_return=@sales_return, applied_sales_return=@applied_sales_return,
                            payment_type=@payment_type, payment_details=@payment_details, shipping_method=@shipping_method, status=@status, packing_requirements=@packing_requirements,
                            volume=@volume, weight=@weight WHERE order_id=@order_id"
                Dim cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@order_id", lbl_orderid.Text)
                cmd.Parameters.AddWithValue("@payment_status", payment_status)
                cmd.Parameters.AddWithValue("@bill_to", txt_billing.Text.Trim)
                cmd.Parameters.AddWithValue("@ship_to", txt_shipping.Text.Trim)
                cmd.Parameters.AddWithValue("@trucking", txt_trucking.Text.Trim)
                cmd.Parameters.AddWithValue("@order_item", orders)
                cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                cmd.Parameters.AddWithValue("@payment_type", payment_type)
                cmd.Parameters.AddWithValue("@payment_details", String.Empty)
                cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                cmd.Parameters.AddWithValue("@is_vat_exempt", cb_vat_exempt.Checked)
                cmd.Parameters.AddWithValue("@is_vat_zero", cb_vat_zero.Checked)
                cmd.Parameters.AddWithValue("@vat_zero_value", txt_vat_zero_value.EditValue)
                cmd.Parameters.AddWithValue("@invoice_no", txt_invoice.Text)
                cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@discount_type", cbb_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_withholding_tax_applied.Checked)
                cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(IIf(String.IsNullOrWhiteSpace(lbl_withholding_tax_amount.Text), 0, lbl_withholding_tax_amount.Text)))
                cmd.Parameters.AddWithValue("@withholding_tax_code", cbb_taxCode.EditValue)
                cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("Less: EWT ", String.Empty).Replace("%", String.Empty)))
                cmd.Parameters.AddWithValue("@amount_due", CDec(lbl_total.Text))
                cmd.Parameters.AddWithValue("@balance", CDec(lbl_total.Text))
                cmd.Parameters.AddWithValue("@credit_amount", sr_amount)
                cmd.Parameters.AddWithValue("@delivery_fee", CDec(IIf(String.IsNullOrWhiteSpace(txt_delivery_fee.Text), 0, txt_delivery_fee.Text)))
                cmd.Parameters.AddWithValue("@shipping_method", shipping_method)
                cmd.Parameters.AddWithValue("@po_reference", txt_po_ref.Text.Trim)
                cmd.Parameters.AddWithValue("@terms", se_terms.EditValue)
                cmd.Parameters.AddWithValue("@status", lbl_status.Text)
                cmd.Parameters.AddWithValue("@target_warehouse", cbb_warehouse.Text)
                cmd.Parameters.AddWithValue("@sales_return", JsonConvert.SerializeObject(sales_returns))
                cmd.Parameters.AddWithValue("@applied_sales_return", sales_return_id)
                cmd.Parameters.AddWithValue("@volume", lbl_vol.Text.Replace("cm3", String.Empty))
                cmd.Parameters.AddWithValue("@weight", lbl_wt.Text.Replace("kg", String.Empty))
                cmd.Parameters.AddWithValue("@packing_requirements", JsonConvert.SerializeObject(packing_req))
                cmd.ExecuteNonQuery()

            End Using

            If Not no_confirmation = True Then
                MsgBox("Save successfully!", vbInformation, "Information")
                LoadData(lbl_orderid.Text)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'BUTTON : PRINT
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        print_contextmenu.Show(btn_print, New Point(btn_print.Width - print_contextmenu.Width, btn_print.Height))
    End Sub

    'BUTTON : DELETE
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If MsgBox("Delete this Order?", vbQuestion + vbYesNo, "Confrimation") = vbYes Then

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim query = "UPDATE ims_orders SET deleted='1', status='Deleted' WHERE order_id=" & lbl_orderid.Text
                    Dim cmd = New MySqlCommand(query, conn)
                    cmd.ExecuteNonQuery()
                End Using
                Me.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

    'BUTTON : REFUND
    Private Sub btn_refund_Click(sender As Object, e As EventArgs) Handles btn_refund.Click
        If MsgBox("Refund payment for this Sales Order?", vbInformation + vbYesNo, "Confirmation") = vbYes Then
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("UPDATE ims_orders SET payment_status='REFUND' WHERE order_id=" & lbl_orderid.Text, connection)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Successfully tagged for Refund!", vbInformation, "Information")
                        Me.Close()
                    End If
                End Using
            End Using
        End If
    End Sub

    'BUTTON : PACK
    Private Sub btn_pack_Click(sender As Object, e As EventArgs) Handles btn_pack.Click

        If btn_pack.Text = "Create && Pack" Then

            btn_create_Click(Nothing, Nothing, True)

            If Not order_id = 0 Then
                If MsgBox("Ready for Packing?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Pending for Arrangement', date_arranged=NOW()
                                                        WHERE order_id=" & order_id, conn)
                            If cmd.ExecuteNonQuery() > 0 Then
                                MsgBox("For packing request sent!", vbInformation, "Information")
                                Me.Close()
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If
            End If

        End If

        Select Case lbl_status.Text

            'PENDING
            Case "Pending"
                If MsgBox("Ready for Packing?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Pending for Arrangement', date_arranged=NOW()
                                                        WHERE order_id=" & lbl_orderid.Text, conn)
                            If cmd.ExecuteNonQuery() > 0 Then
                                MsgBox("For packing request sent!", vbInformation, "Information")
                                Me.Close()
                            End If
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If

            'PACKED
            Case "Packed"
                If MsgBox("Cancel and unpack this order?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Cancelled Order' 
                                                        WHERE order_id=" & lbl_orderid.Text, conn)
                            If cmd.ExecuteNonQuery() > 0 Then
                                MsgBox("Cancellation is in qeued!" & vbCrLf & "Package will be unpacked soon...", vbInformation, "Notice")
                                Me.Close()
                            End If
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If

        End Select

    End Sub

    'BUTTON : EPAY RECEIPT
    Private Sub btn_epay_Click(sender As Object, e As EventArgs) Handles btn_epay.Click
        Dim frm As New frm_sales_order_epayment_proofs()
        frm.lbl_order_id.Text = lbl_orderid.Text
        frm.LoadData()
        frm.ShowDialog()
    End Sub

    'BUTTON : IMPORT
    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        Dim fd = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.Filter = "Excel file |*.xls;*.xlsx"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim path = fd.FileName

            Try
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                Using package = New ExcelPackage(New IO.FileInfo(path))

                    'Initialize
                    Dim WorkSheet = package.Workbook.Worksheets(0)
                    Dim dt_searchGrid = TryCast(grid_search.DataSource, DataTable)
                    Dim dt_orderGrid = TryCast(grid_order.DataSource, DataTable)
                    Dim not_found_skus = String.Empty

                    'Insert Value From WorkSheet
                    For i = WorkSheet.Dimension.Start.Row To WorkSheet.Dimension.End.Row
                        If Not (String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 1).Value) And String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 2).Value)) Then

                            Dim dr() As DataRow = dt_searchGrid.Select("winmodel='" & WorkSheet.Cells(i, 2).Value & "'")

                            If dr.Length > 0 Then
                                dt_orderGrid.Rows.Add(
                                        dr(0).Item("pid"),
                                        WorkSheet.Cells(i, 1).Value,
                                        dr(0).Item("winmodel"),
                                        dr(0).Item("description"),
                                        dr(0).Item("regular_price"),
                                        dr(0).Item("discount"),
                                        dr(0).Item("unit_price"),
                                        WorkSheet.Cells(i, 1).Value * dr(0).Item("unit_price"),
                                        dr(0).Item("unit")
                                        )

                            Else
                                not_found_skus = String.Concat(not_found_skus, Environment.NewLine, WorkSheet.Cells(i, 2).Value)
                            End If

                        End If
                    Next

                    If Not String.IsNullOrWhiteSpace(not_found_skus) Then
                        MsgBox("Not found SKUs:" & Environment.NewLine & not_found_skus, vbExclamation, "Not found")
                    End If

                    ComputeTotal()

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'CHECKBOX : NON-VATABLE
    Private Sub cb_nonvatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_nonvatable.CheckedChanged
        If cb_nonvatable.Checked = True Then
            cb_vatable.Checked = False
            cb_vat_exempt.Enabled = False
            cb_vat_zero.Enabled = False
            txt_vat_zero_value.Enabled = False
        End If
    End Sub

    'CHECKBOX : VATABLE
    Private Sub cb_vatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vatable.CheckedChanged
        If cb_vatable.Checked = True Then
            cb_nonvatable.Checked = False
            txt_invoice.Enabled = True
            cb_vat_exempt.Checked = False
            cb_vat_zero.Checked = False

            cb_vatable.Checked = True
            cb_vat_exempt.Enabled = True
            cb_vat_zero.Enabled = True
            txt_vat_zero_value.Enabled = True
        Else
            cb_nonvatable.Checked = True
            cb_vat_exempt.Checked = False
            cb_vat_zero.Checked = False
            txt_invoice.Enabled = False
            txt_vat_zero_value.Text = 0
            txt_invoice.Text = ""
        End If
        ComputeTotal()
    End Sub

    'CHECKBOX : VAT - EXEMPT
    Private Sub cb_vat_exempt_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vat_exempt.CheckedChanged
        If cb_vat_exempt.Checked = True Then
            cb_vat_zero.Checked = False
            txt_vat_zero_value.EditValue = 0
        End If
        ComputeTotal()
    End Sub

    'CHECKBOX : VAT - ZERO
    Private Sub cb_vat_zero_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vat_zero.CheckedChanged
        If cb_vat_zero.Checked = True Then
            cb_vat_exempt.Checked = False
        End If
        ComputeTotal()
    End Sub

    'txt_vat_zero_value : Changing
    Private Sub txt_vat_zero_value_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_vat_zero_value.KeyUp
        ComputeTotal()
    End Sub

    'cbb_taxCode : SELECTING TAX CODE based on input
    Private Sub cbb_taxCode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_taxCode.SelectedIndexChanged
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT tax_rate FROM ims_tax_code WHERE tax_code=@taxRate", conn)
                    cmd.Parameters.AddWithValue("@taxRate", cbb_taxCode.EditValue)
                    txt_taxRate.EditValue = cmd.ExecuteScalar
                End Using
                conn.Close()

                lbl_withholding_tax_percentage.Text = $"Less: EWT ({ Decimal.Round(CDec(txt_taxRate.EditValue) * 100, 2) }%)"

                ComputeTotal()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


#Region "ZEN_ACCESS"
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim dt = New DataTable
        dt.Columns.Add("qty", GetType(Decimal))
        dt.Columns.Add("model", GetType(String))
        dt.Columns.Add("description", GetType(String))

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_orders 
                                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                                            WHERE ims_customers.first_name=@customer AND (status='Completed' OR status='Released') AND deleted=0", conn)
                    cmd.Parameters.AddWithValue("@customer", cbb_customer.EditValue)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            to_grid(rdr("order_item"), dt, rdr("order_id"))
                        End While
                    End Using
                End Using
            End Using

            grid_order.DataSource = dt

            Dim sfd = New SaveFileDialog
            If sfd.ShowDialog = DialogResult.OK Then
                grid_order_view.ExportToXlsx(sfd.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Public Sub to_grid(units As String, dt As DataTable, order_id As Integer)

        Dim comma(), equal() As String
        Dim piece As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                If equal.Length = 6 Then    '---- OLD 
                    dt.Rows.Add(equal(0), equal(1), equal(2))

                ElseIf equal.Length = 8 Then    '---- NEW 
                    dt.Rows.Add(equal(0), equal(1), equal(2))

                End If

            Next

        End If

    End Sub

#End Region

End Class

Public Class CustomerDetails
    Public Property customer_id As Integer
    Public Property sales_agent As Integer
    Public Property account_terms As Integer = 0
End Class