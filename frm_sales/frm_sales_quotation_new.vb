Imports System.Globalization
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports Microsoft.VisualStudio.TextManager.Interop
Imports MySqlConnector

Public Class frm_sales_quotation_new


    Private CustomerDetails As New CustomerDetails


    '--- ONLOAD ----
    Private Sub frm_sales_quotation_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If cbb_customer.Properties.Items.Count = 0 Then
            Load_Customer_list()
        End If

        If TryCast(grid_quotation.DataSource, DataTable) Is Nothing Then
            Create_DataSource_gridorder()
        End If

        If frm_main.lbl_user_role_id.Text = "1" Then
            col_d_price.OptionsColumn.AllowEdit = True
            col_unit_price.OptionsColumn.AllowEdit = True
        End If

        If rg_customer_type.EditValue = "new" Then
            txt_customer_name_new.Location = cbb_customer.Location
            txt_account_type.Text = "Regular"
            Load_SearchGrid()
        End If

    End Sub




    '--- FUNCTIONS ----

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
                End Select

                Dim query = "SELECT  pid, brand, unit, winmodel, description, inv.combination_name, regular_price,
                                     IF((" & discount_type & " = 'NET' OR " & discount_type & " = 'SRP' OR " & discount_type & " = '*'), " & discount_type & ", CONCAT(" & discount_type & ",'%')) AS discount, " & price & " AS unit_price
                            FROM (SELECT pid, brand, unit, winmodel, description, CONCAT(brand, ' ', sub_category) AS combination_name, 
                                    cost, regular_price, net_regular, dealer_price, vip_price, status FROM ims_inventory) inv
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

    'Load Customers to ComboBox
    Private Sub Load_Customer_list()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT LPAD(customer_id, 3, '0') as customer_id, first_name FROM ims_customers", connection)
                Using rdr As MySqlDataReader = cmd.ExecuteReader

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
        dt.Columns.Add("cost", GetType(Decimal))
        dt.Columns.Add("margin", GetType(String))
        dt.Columns.Add("volume", GetType(Double))
        dt.Columns.Add("weight", GetType(Double))
        grid_quotation.DataSource = dt
        Return dt
    End Function

    'Show Qty Dialog
    Private Sub Show_QtyDialog()
        Try
            Dim qty_dialog = New frm_sales_order_qty_dialog

            If qty_dialog.ShowDialog() = DialogResult.OK Then

                Using dt = TryCast(grid_quotation.DataSource, DataTable)
                    With grid_search_view
                        dt.Rows.Add(
                                .GetFocusedRowCellValue(col_search_pid),
                                qty_dialog.quantity_entered,
                                .GetFocusedRowCellValue(col_search_model),
                                .GetFocusedRowCellValue(col_search_description),
                                CDec(.GetFocusedRowCellValue(col_search_srp)),
                                .GetFocusedRowCellValue(col_search_discount),
                                .GetFocusedRowCellValue(col_search_unit_price),
                                qty_dialog.quantity_entered * CDec(.GetFocusedRowCellValue(col_search_unit_price)),
                                .GetFocusedRowCellValue(col_search_unit)
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
            Dim dt = TryCast(grid_quotation.DataSource, DataTable)

            For Each row As DataRow In dt.Rows
                sub_total += row.Item("total_price")
            Next

            'DISPLAY SUBTOTAL
            lbl_sub_total.Text = FormatCurrency(sub_total)

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

            'DISPLAY SUBTOTAL - DISCOUNT
            lbl_vatable_sales.Text = FormatCurrency(sub_total)

            'DISPLAY 12% VAT
            If cb_vatable.Checked = True Then
                Dim vatable_sales As Decimal = sub_total / 1.12
                lbl_vat.Text = FormatCurrency(sub_total - vatable_sales)
            Else
                lbl_vat.Text = ""
            End If

            'LESS WITHHOLDING TAX & DISPLAY
            If cb_withholding_tax_applied.Checked = True Then
                Dim vatable_sales As Decimal = sub_total / 1.12
                Dim withholding_tax As Decimal = vatable_sales * CDec(lbl_withholding_tax_percentage.Text.Replace("Less WT (", String.Empty).Replace("%)", String.Empty) / 100)
                sub_total -= withholding_tax
                lbl_withholding_tax_amount.Text = FormatCurrency(withholding_tax)
            Else
                lbl_withholding_tax_amount.Text = ""
            End If

            'ADD DELIVERY FEE & DISPLAY
            If Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
                lbl_delivery_fee.Text = FormatCurrency(txt_delivery_fee.Text)
                lbl_total.Text = FormatCurrency(sub_total + CDec(txt_delivery_fee.Text))
                'lbl_amount_to_pay.Text = FormatCurrency(sub_total + CDec(txt_delivery_fee.Text))
                'lbl_balance.Text = FormatCurrency(sub_total + CDec(txt_delivery_fee.Text) - CDec(lbl_paid_amount.Text))
                If CDec(txt_delivery_fee.Text) = 0 Then
                    txt_delivery_fee.Text = ""
                    lbl_delivery_fee.Text = ""
                End If
            Else
                lbl_delivery_fee.Text = ""
                lbl_total.Text = FormatCurrency(sub_total)
                'lbl_amount_to_pay.Text = FormatCurrency(sub_total)
                'lbl_balance.Text = FormatCurrency(sub_total - CDec(lbl_paid_amount.Text))
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'SHORTCUT
    Private Sub frm_sales_quotation_new_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            Show_QtyDialog()
        ElseIf e.KeyCode = Keys.F1 Then
            txt_search.Select()
        ElseIf e.Control = True And e.KeyCode = Keys.W Then
            grid_search_view.Focus()
        End If
    End Sub


    'Load Data to Field
    Public Function LoadData(quotation_id As String)

        lbl_quotation_id.Text = quotation_id

        Try

            Load_Customer_list()
            Create_DataSource_gridorder()

            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT *, ims_users.first_name AS prepared_by FROM ims_quotations
                                LEFT JOIN ims_customers ON ims_customers.first_name=ims_quotations.company
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_quotations.prepared_by
                                WHERE quotation_id=" & quotation_id

                Dim cmd = New MySqlCommand(query, conn)
                Using rdr As MySqlDataReader = cmd.ExecuteReader

                    While rdr.Read

                        'RESTRICT OTHER USER FROM CREATING WITH SISTER COMPANY
                        If rdr("customer_type").Equals("existing") Then
                            If rdr("account_type").Equals("Sister Company") Then
                                Dim current_user As String = frm_main.lbl_user_role_id.Text
                                If Not (current_user = "1" Or current_user = "2" Or current_user = "3" Or current_user = "4" Or current_user = "6") Then
                                    MsgBox("Insufficient priviledge!" & Environment.NewLine & "Kindly contact your administrator.", MsgBoxStyle.Critical, "Forbidden")
                                    Return False
                                End If
                            End If
                        End If

                        'Order Details
                        Me.Text = "Quotation Order #" & quotation_id & " - " & rdr("company")
                        lbl_status.Text = rdr("status").ToString.Trim
                        lbl_creation_date.Text = FormatDateTime(rdr("created_at"), DateFormat.LongDate)
                        lbl_created_by.Text = rdr("prepared_by")

                        cbb_customer.Text = rdr("company")
                        txt_customer_name_new.Text = rdr("company")

                        rg_customer_type.EditValue = rdr("customer_type")

                        txt_contact_person.Text = rdr("contact_person")
                        txt_contact_no.Text = rdr("contact_no")
                        txt_office_address.Text = rdr("contact_address")
                        txt_delivery_address.Text = rdr("delivery_address")

                        se_validity.Text = rdr("validity")

                        If rdr("is_term_applied") = True Then
                            cb_apply_terms.Checked = True
                            se_terms.EditValue = CDec(rdr("terms"))
                        Else
                            cb_apply_terms.Checked = False
                        End If

                        'Public, Private 
                        txt_pub_notes.Text = rdr("pub_note")
                        txt_priv_notes.Text = rdr("priv_note")

                        'Set Computations
                        txt_delivery_fee.Text = rdr("delivery_fee")
                        lbl_total.Text = FormatCurrency(rdr("total"))

                        If Not IsDBNull(rdr("discount_val")) Then txt_discount.Text = rdr("discount_val")
                        If Not IsDBNull(rdr("discount_type")) Then cbb_discount.SelectedText = rdr("discount_type")

                        cb_vatable.Checked = rdr("is_vatable")

                        cb_withholding_tax_applied.Checked = rdr("is_withholding_tax_applied")
                        If Not IsDBNull(rdr("withholding_tax_percentage")) Then lbl_withholding_tax_percentage.Text = "Less WT (" & FormatPercent(rdr("withholding_tax_percentage") / 100) & ")"
                        If Not IsDBNull(rdr("withholding_tax_amount")) Then lbl_withholding_tax_amount.Text = IIf(rdr("withholding_tax_amount") = 0.000, String.Empty, FormatPercent(rdr("withholding_tax_amount")))

                        data_to_grid(rdr("order_item"))

                    End While


                End Using
            End Using

            '--- UPDATING GUI

            btn_print.Enabled = True
            btn_transfer.Enabled = True
            btn_delete.Enabled = True

            btn_create.Visible = False
            btn_update.Location = btn_create.Location
            btn_update.Visible = True
            rg_customer_type.Enabled = False

            If rg_customer_type.EditValue = "new" Then
                txt_customer_name_new.Visible = True
                cbb_customer.Visible = False
            ElseIf rg_customer_type.EditValue = "existing" Then
                txt_customer_name_new.Visible = False
                cbb_customer.Visible = True
            End If

            Select Case lbl_status.Text
                Case "Pending", "Declined"
                    btn_transfer.Enabled = False
                    btn_print.Enabled = False

                Case "Approved"
                    If Not (frm_main.lbl_user_role_id.Text = "1" Or frm_main.lbl_user_role_id.Text = "6") Then
                        grid_quotation_view.OptionsBehavior.ReadOnly = True
                    End If
            End Select

            'Set Cost and Margin Column Visible for Admin and OM
            If frm_main.lbl_user_role_id.Text = "1" Or frm_main.lbl_user_role_id.Text = "6" Then
                col_cost.Visible = True
                col_margin.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function

    'Set Grid Data
    Public Sub data_to_grid(units As String)

        Dim comma(), equal() As String
        Dim piece As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim tmp_dt = TryCast(grid_quotation.DataSource, DataTable)

        'CLEAR DATATABLE FIRST
        If tmp_dt.Rows.Count > 0 Then
            tmp_dt.Rows.Clear()
        End If

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

                    If equal.Length = 6 Then    '---- OLD 
                        Dim discounted_price = equal(3) - (equal(3) * (equal(4).Replace("%", String.Empty) / 100))
                        tmp_dt.Rows.Add(0, equal(0), equal(1), equal(2), equal(3), equal(4), discounted_price, equal(5).Replace(";", String.Empty), "", cost, CInt(((discounted_price - cost) / discounted_price) * 100) & "%")


                    ElseIf equal.Length = 8 Then    '---- NEW 
                        Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7).Replace(";", String.Empty))
                        tmp_dt.Rows.Add(0, equal(0), equal(1), equal(2), equal(3),
                                        IIf(Char.IsDigit(equal(4)), equal(4) & "%", equal(4)),
                                        equal(5),
                                        equal(6),
                                        unit,
                                        cost,
                                        CInt(((equal(5) - cost) / equal(5)) * 100) & "%")

                    End If

                Next
            End Using

            ComputeTotal()

        End If

    End Sub

    'Function: SAVE
    Private Function SaveData(status As String)

        Dim res = False

        'Get Orders to String
        Dim orders = String.Empty
        For Each row As DataRow In TryCast(grid_quotation.DataSource, DataTable).Rows
            If String.IsNullOrEmpty(row.Item(1)) Then Continue For

            Dim unit = IIf(IsDBNull(row.Item("unit")) Or String.IsNullOrEmpty(row.Item("unit").ToString), "NULL", row.Item("unit"))

            orders += row.Item(1) & "=" & row.Item(2) & "=" & row.Item(3) & "=" & row.Item(4) & "=" & row.Item(5).ToString.Replace("%", String.Empty) & "=" & row.Item(6) & "=" & row.Item(7) & "=" & unit & ";"
        Next

        'Get Company
        Dim company As String = String.Empty
        If rg_customer_type.EditValue = "new" Then company = txt_customer_name_new.Text
        If rg_customer_type.EditValue = "existing" Then company = cbb_customer.Text

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "UPDATE ims_quotations SET company=@company, contact_person=@contact_person,
                        is_vatable=@is_vatable, discount_val=@discount_val, discount_type=@discount_type, is_term_applied=@is_term_applied, terms=@terms,
                        is_withholding_tax_applied=@is_withholding_tax_applied, withholding_tax_amount=@withholding_tax_amount, withholding_tax_percentage=@withholding_tax_percentage,
                        contact_no=@contact_no, contact_address=@contact_address, delivery_address=@delivery_address, 
                        order_item=@order_item, total=@total, delivery_fee=@delivery_fee,
                        priv_note=@priv_note, pub_note=@pub_note, status=@status WHERE quotation_id=" & lbl_quotation_id.Text
                Dim cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@company", company)
                cmd.Parameters.AddWithValue("@contact_person", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_contact_person.Text.Trim))
                cmd.Parameters.AddWithValue("@contact_no", txt_contact_no.Text.Trim)
                cmd.Parameters.AddWithValue("@contact_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_office_address.Text.Trim))
                cmd.Parameters.AddWithValue("@delivery_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_delivery_address.Text.Trim))
                cmd.Parameters.AddWithValue("@order_item", orders)
                cmd.Parameters.AddWithValue("@total", CDec(lbl_total.Text))
                cmd.Parameters.AddWithValue("@delivery_fee", CDec(IIf(String.IsNullOrEmpty(txt_delivery_fee.Text), Nothing, txt_delivery_fee.Text)))
                cmd.Parameters.AddWithValue("@is_term_applied", cb_apply_terms.Checked)
                cmd.Parameters.AddWithValue("@terms", IIf(cb_apply_terms.Checked, se_terms.Text, 0))
                cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text.Trim)
                cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                cmd.Parameters.AddWithValue("@discount_type", IIf(String.IsNullOrEmpty(cbb_discount.Text), Nothing, cbb_discount.Text))
                cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_withholding_tax_applied.Checked)
                cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(IIf(String.IsNullOrEmpty(lbl_withholding_tax_amount.Text), 0, lbl_withholding_tax_amount.Text)))
                cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("Less WT (", String.Empty).Replace("%)", String.Empty)))
                cmd.Parameters.AddWithValue("@status", status)

                If cmd.ExecuteNonQuery() > 0 Then
                    res = True
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return res

    End Function

    'PRINT QUOTATION
    Private Sub print_quotation(id As Integer)
        Dim report = New doc_quotation()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData
        Dim orders = String.Empty

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT *, 
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info, 
                        DATE_ADD(created_at, INTERVAL terms DAY) AS due_date, prepared.first_name AS prepared_name, 
                        approved.first_name AS approved_name FROM ims_quotations 
                        LEFT JOIN ims_users AS prepared ON prepared.usr_id=prepared_by
                        LEFT JOIN ims_users AS approved ON approved.usr_id=approved_by
                        WHERE quotation_id=" & id
                Dim cmd = New MySqlCommand(query, connection)
                Using rdr = cmd.ExecuteReader

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
            End Using

            data_to_print(orders, table.quotation)

            report.RequestParameters = False
            report.DataSource = table

            printTool.AutoShowParametersPanel = False
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set Print Data
    Public Sub data_to_print(units As String, tbl As DataTable)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        If tbl.Rows.Count > 0 Then tbl.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            'DECLARE VALUES
            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                Dim unit = IIf(equal(7).Replace(";", String.Empty).Equals("NULL"), "", equal(7).Replace(";", String.Empty))

                tbl.Rows.Add(equal(0),
                                             equal(1),
                                             equal(2),
                                             equal(3),
                                             IIf(Equals(equal(4), "0"), "", equal(4)),
                                             equal(5),
                                             equal(6),
                                             unit)
            Next

        End If

    End Sub






    '--- CONTROL EVENTS ----

    'CBB : CUSTOMER
    Private Sub cbb_customer_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_customer.SelectedValueChanged

        If cbb_customer.SelectedIndex = -1 Then Return

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT account_type, customer_id, account_type, address, contact_person, contact, terms,
                    trucking_note, credit_limit, used_credit, preferred_shipping, agent.usr_id, agent.first_name AS sales_agent 
                    FROM ims_customers
                    LEFT JOIN ims_users AS agent ON agent.usr_id=ims_customers.assigned_agent 
                    WHERE ims_customers.first_name=@customer AND is_deleted='0'", connection)
                cmd.Parameters.AddWithValue("@customer", cbb_customer.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read

                    'RESTRICT OTHER USER FROM CREATING WITH SISTER COMPANY
                    If rdr("account_type").Equals("Sister Company") Then
                        Dim current_user As String = frm_main.lbl_user_role_id.Text
                        If Not (current_user = "1" Or current_user = "2" Or current_user = "3" Or current_user = "4" Or current_user = "6") Then
                            MsgBox("Insufficient priviledge!" & Environment.NewLine & "Kindly contact your administrator.", MsgBoxStyle.Critical, "Forbidden")
                            grid_search.DataSource = Nothing
                            Return
                        End If
                    End If


                    'Set_Restrictions(rdr("account_type"))

                    CustomerDetails.customer_id = rdr("customer_id")
                    CustomerDetails.sales_agent = IIf(IsDBNull(rdr("usr_id")), 0, rdr("usr_id"))
                    CustomerDetails.account_terms = rdr("terms")

                    'rg_shipping_method.EditValue = rdr("preferred_shipping")
                    se_terms.EditValue = CInt(rdr("terms"))
                    txt_office_address.Text = rdr("address")
                    'txt_trucking.Text = rdr("trucking_note")

                    txt_account_type.Text = rdr("account_type")
                    txt_contact_person.Text = rdr("contact_person")
                    txt_contact_no.Text = rdr("contact")
                    'txt_credit_limit.Text = FormatCurrency(rdr("credit_limit"), 2)
                    'txt_used_credit.Text = FormatCurrency(rdr("used_credit"), 2)
                    'txt_available_credit.Text = FormatCurrency(rdr("credit_limit") - rdr("used_credit"), 2)
                    'txt_sales_agent.Text = IIf(IsDBNull(rdr("sales_agent")), Nothing, rdr("sales_agent"))

                End While
            End Using

            Load_SearchGrid()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'RG: CUSTOMER TYPE
    Private Sub rg_customer_type_SelectedIndexChanged(sender As Object, e As EventArgs) Handles rg_customer_type.SelectedIndexChanged
        If Equals(rg_customer_type.EditValue, "new") Then
            cbb_customer.Visible = False
            txt_customer_name_new.Visible = True
            txt_account_type.Text = "Regular"
            Load_SearchGrid()
        ElseIf Equals(rg_customer_type.EditValue, "existing") Then
            cbb_customer.Visible = True
            txt_customer_name_new.Visible = False
        End If

    End Sub

    'BUTTON : CREATE
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        Dim customer = String.Empty

        Select Case rg_customer_type.EditValue

            Case "new"
                If Not (String.IsNullOrWhiteSpace(txt_customer_name_new.Text) Or String.IsNullOrWhiteSpace(txt_contact_person.Text)) Then
                    customer = txt_customer_name_new.Text.Trim
                Else
                    MsgBox("Please enter Company name and contact person!", vbCritical, "Incomplete")
                    Exit Sub
                End If
            Case "existing"
                If Not (cbb_customer.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(txt_contact_person.Text)) Then
                    customer = cbb_customer.Text
                Else
                    MsgBox("Please select customer and contact person!", vbCritical, "Incomplete")
                    Exit Sub
                End If
        End Select


        If Not grid_quotation_view.RowCount = 0 Then
            If MsgBox("Press 'Yes' to confirm", vbInformation + vbYesNo, "Confirmation") = vbYes Then

                Try
                    Using connection = New MySqlConnection(str)
                        connection.Open()

                        'Get Orders to String
                        Dim orders = String.Empty
                        For Each row As DataRow In TryCast(grid_quotation.DataSource, DataTable).Rows
                            If String.IsNullOrEmpty(row.Item(1)) Then Continue For
                            Dim unit = IIf(IsDBNull(row.Item(8)), "NULL", row.Item(8))
                            orders += row.Item(1) & "=" & row.Item(2) & "=" & row.Item(3) & "=" & row.Item(4) & "=" & row.Item(5).ToString.Replace("%", String.Empty) & "=" & row.Item(6) & "=" & row.Item(7) & "=" & unit & ";"
                        Next

                        Dim query = "INSERT INTO ims_quotations (customer_type, company, contact_person, contact_no, contact_address, delivery_address, order_item,
                            discount_val, discount_type, is_vatable, is_withholding_tax_applied, withholding_tax_amount, withholding_tax_percentage,
                            total, delivery_fee, priv_note, pub_note, prepared_by, created_at, status, is_term_applied, terms, validity)
                            VALUES (@customer_type, @company, @contact_person, @contact_no, @contact_address, @delivery_address, @order_item,
                            @discount_val, @discount_type, @is_vatable, @is_withholding_tax_applied, @withholding_tax_amount, @withholding_tax_percentage,
                            @total, @delivery_fee, @priv_note, @pub_note, @prepared_by, CURRENT_TIMESTAMP, 'Pending', @is_term_applied, @terms, @validity)"

                        Dim cmd = New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@customer_type", rg_customer_type.EditValue)
                        cmd.Parameters.AddWithValue("@company", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(customer))
                        cmd.Parameters.AddWithValue("@contact_person", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_contact_person.Text.Trim))
                        cmd.Parameters.AddWithValue("@contact_no", txt_contact_no.Text.Trim)
                        cmd.Parameters.AddWithValue("@contact_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_office_address.Text.Trim))
                        cmd.Parameters.AddWithValue("@delivery_address", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_delivery_address.Text.Trim))
                        cmd.Parameters.AddWithValue("@order_item", orders)
                        cmd.Parameters.AddWithValue("@is_vatable", cb_vatable.Checked)
                        cmd.Parameters.AddWithValue("@discount_val", txt_discount.Text.Trim)
                        cmd.Parameters.AddWithValue("@discount_type", IIf(String.IsNullOrEmpty(cbb_discount.Text), Nothing, cbb_discount.Text))
                        cmd.Parameters.AddWithValue("@is_withholding_tax_applied", cb_withholding_tax_applied.Checked)
                        cmd.Parameters.AddWithValue("@withholding_tax_amount", CDec(IIf(String.IsNullOrEmpty(lbl_withholding_tax_amount.Text), 0, lbl_withholding_tax_amount.Text)))
                        cmd.Parameters.AddWithValue("@withholding_tax_percentage", CDec(lbl_withholding_tax_percentage.Text.Replace("Less WT (", String.Empty).Replace("%)", String.Empty)))
                        cmd.Parameters.AddWithValue("@total", CDec(lbl_total.Text))
                        cmd.Parameters.AddWithValue("@delivery_fee", CDec(IIf(String.IsNullOrEmpty(txt_delivery_fee.Text), Nothing, txt_delivery_fee.Text)))
                        cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text.Trim)
                        cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text.Trim)
                        cmd.Parameters.AddWithValue("@prepared_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@is_term_applied", cb_apply_terms.Checked)
                        cmd.Parameters.AddWithValue("@terms", IIf(cb_apply_terms.Checked, se_terms.Text, 0))
                        cmd.Parameters.AddWithValue("@validity", se_validity.Text)

                        If cmd.ExecuteNonQuery() > 0 Then
                            Me.Close()
                            MsgBox("Successfully Created!", vbInformation, "Information")
                        End If

                    End Using

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If

        Else
            MsgBox("No order found!", vbCritical, "Incomplete")
            Exit Sub
        End If

    End Sub

    'BUTTON : UPDATE
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If grid_quotation_view.RowCount > 0 Then
            If SaveData("Pending") Then
                LoadData(lbl_quotation_id.Text)
                MsgBox("Saved successfully!", MsgBoxStyle.Information, Nothing)
            End If
        Else
            MsgBox("No items to be saved!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    'BUTTON : DELETE
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Do you want to delete this quotation?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_quotations SET is_deleted='1' WHERE quotation_id=" & lbl_quotation_id.Text, connection)

                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Successfully Deleted!", vbInformation, "Information")
                        Me.Close()
                    End If

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'GRID : CELL VALUE CHANGED
    Private Property discount_counter As Integer = 0
    Private Sub grid_order_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_quotation_view.CellValueChanged

        Try
            If Equals(e.Column, col_qty) Then
                If grid_quotation_view.GetFocusedRowCellValue(col_discount).Equals("NET") Or
                    grid_quotation_view.GetFocusedRowCellValue(col_discount).Equals("*") Or
                    IsDBNull(grid_quotation_view.GetFocusedRowCellValue(col_discount)) Or String.IsNullOrWhiteSpace(grid_quotation_view.GetFocusedRowCellValue(col_discount)) Then
                    Dim discounted_price As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_d_price)
                    grid_quotation_view.SetFocusedRowCellValue(col_total_price, grid_quotation_view.GetFocusedRowCellValue(col_qty) * discounted_price)

                Else
                    Dim price As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_unit_price)
                    Dim discount As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
                    Dim discounted_price = price - (price * (discount / 100))
                    grid_quotation_view.SetFocusedRowCellValue(col_total_price, e.Value * discounted_price)
                End If
            End If

            If Equals(e.Column, col_unit_price) Then
                If grid_quotation_view.GetFocusedRowCellValue(col_discount).Equals("NET") Or
                    grid_quotation_view.GetFocusedRowCellValue(col_discount).Equals("*") Or
                    IsDBNull(grid_quotation_view.GetFocusedRowCellValue(col_discount)) Or
                    String.IsNullOrWhiteSpace(grid_quotation_view.GetFocusedRowCellValue(col_discount)) Then

                    Dim discounted_price As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_unit_price)
                    Dim qty As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_qty)
                    grid_quotation_view.SetFocusedRowCellValue(col_d_price, discounted_price)
                    grid_quotation_view.SetFocusedRowCellValue(col_total_price, qty * discounted_price)
                Else
                    Dim price As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_unit_price)
                    Dim discount As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
                    Dim discounted_price = price - (price * (discount / 100))
                    grid_quotation_view.SetFocusedRowCellValue(col_total_price, e.Value * discounted_price)
                    grid_quotation_view.SetFocusedRowCellValue(col_d_price, discounted_price)
                End If
            End If

            If Equals(e.Column, col_d_price) Then
                Dim discounted_price As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_d_price)
                grid_quotation_view.SetFocusedRowCellValue(col_total_price, grid_quotation_view.GetFocusedRowCellValue(col_qty) * discounted_price)
            End If

            If Equals(e.Column, col_discount) Then

                'DECLARATIONS
                Dim pass As String = String.Empty
                Dim old_total_price As Decimal = grid_quotation_view.GetFocusedRowCellValue(col_qty) * grid_quotation_view.GetFocusedRowCellValue(col_unit_price)
                Dim cost As Decimal = 0.00

                'Discount Counter
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
                                            grid_quotation_view.SetFocusedRowCellValue(col_total_price, old_total_price)
                                            grid_quotation_view.SetFocusedRowCellValue(col_discount, 0)
                                            Return
                                        End If
                                    End Using
                                End Using

                            Else
                                MsgBox("Password can't be blank!", vbCritical, "Password Required")
                                Return
                            End If
                        Else
                            grid_quotation_view.SetFocusedRowCellValue(col_discount, 0)
                        End If
                    End If
                End If

                'VALIDATE
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim dt = TryCast(grid_quotation.DataSource, DataTable)

                    discount_counter += 1

                    'GET COST
                    Using cmd = New MySqlCommand("SELECT cost FROM ims_inventory WHERE winmodel=@winmodel", connection)
                        cmd.Parameters.AddWithValue("@winmodel", grid_quotation_view.GetFocusedRowCellValue(col_model))
                        Using rdr As MySqlDataReader = cmd.ExecuteReader

                            rdr.Read()
                            cost = rdr("cost")
                            rdr.Close()

                            Dim price As Decimal = 0.00
                            Dim discount As Decimal = 0.00
                            Dim discounted_price As Decimal = 0.00

                            If e.Value.Equals("NET") Or e.Value.Equals("*") Or String.IsNullOrWhiteSpace(e.Value) Then
                                discounted_price = grid_quotation_view.GetFocusedRowCellValue(col_d_price)

                            Else
                                price = grid_quotation_view.GetFocusedRowCellValue(col_unit_price)
                                discount = grid_quotation_view.GetFocusedRowCellValue(col_discount).ToString.Replace("%", String.Empty)
                                discounted_price = price - (price * (discount / 100))
                            End If

                            If discounted_price < cost Then
                                MsgBox("Warning! You have exceeded allowable discount rate." & Environment.NewLine & "Your account will be disabled for repeated attempts.", vbCritical, "Forbidden")
                                grid_quotation_view.SetFocusedRowCellValue(col_total_price, old_total_price)
                                grid_quotation_view.SetFocusedRowCellValue(col_discount, 0)

                            Else
                                If e.Value.Equals("NET") Or e.Value.Equals("*") Or String.IsNullOrWhiteSpace(e.Value) Then
                                    grid_quotation_view.SetFocusedRowCellValue(col_total_price, grid_quotation_view.GetFocusedRowCellValue(col_qty) * discounted_price)

                                Else
                                    grid_quotation_view.SetFocusedRowCellValue(col_d_price, discounted_price)
                                    grid_quotation_view.SetFocusedRowCellValue(col_total_price, grid_quotation_view.GetFocusedRowCellValue(col_qty) * discounted_price)

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
        grid_quotation_view.DeleteRow(grid_quotation_view.FocusedRowHandle)
        ComputeTotal()
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

    'CHECKBOX : VATABLE
    Private Sub cb_vatable_CheckedChanged(sender As Object, e As EventArgs) Handles cb_vatable.CheckedChanged
        If cb_vatable.Checked = True Then
            txt_invoice.Enabled = True
        Else
            txt_invoice.Enabled = False
        End If
        ComputeTotal()
    End Sub

    'CHECKBOX : WITHHOLDING TAX
    Private Sub cb_withholding_tax_applied_CheckedChanged(sender As Object, e As EventArgs) Handles cb_withholding_tax_applied.CheckedChanged
        If cb_withholding_tax_applied.Checked = True Then
            cb_vatable.Enabled = False
            cb_vatable.Checked = True
        Else
            cb_vatable.Enabled = True
        End If
        ComputeTotal()
    End Sub

    'GRID_ORDER : Unserved Button
    Private Sub btn_unseved_ButtonClick(sender As Object, e As ButtonPressedEventArgs) Handles btn_unseved.ButtonClick
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'CHECK IF EXIST
                Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_sales_unserved_items 
                                                WHERE item=(SELECT pid FROM ims_inventory WHERE winmodel=@item) AND status='Unserved'", conn)
                    cmd.Parameters.AddWithValue("@item", grid_quotation_view.GetFocusedRowCellValue(col_model))
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
                        cmd.Parameters.AddWithValue("@qty", grid_quotation_view.GetFocusedRowCellValue(col_qty))
                        cmd.Parameters.AddWithValue("@item", grid_quotation_view.GetFocusedRowCellValue(col_model))

                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Added!", vbInformation, "Information")
                            grid_quotation_view.DeleteRow(grid_quotation_view.FocusedRowHandle)
                        End If

                    End Using
                End If

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : PRINT
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        print_quotation(lbl_quotation_id.Text)
    End Sub

    'BUTTON : TRANSFER
    Private Async Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click

        'Set Message based on Checked Radio
        Dim message_str = String.Empty
        If rg_customer_type.EditValue = "new" Then message_str = "You want it to be converted, right?" & vbCrLf & "*This cannot be undone."
        If rg_customer_type.EditValue = "existing" Then message_str = "Press 'YES' to confirm."

        If MsgBox(message_str, vbQuestion + vbYesNo, "Confirmation") = vbNo Then
            Exit Sub
        End If

        If SaveData("Approved") Then

            Dim is_existing_customer = 0
            Dim is_new_customer = 0
            Dim is_registered = False

            If rg_customer_type.EditValue = "new" Then

                'Check customer IF ALREADY EXIST
                Try
                    Using connection = New MySqlConnection(str)
                        connection.Open()
                        Dim cmd = New MySqlCommand("SELECT IF( EXISTS( SELECT * FROM ims_customers WHERE first_name = @customer), 1, 0) AS res", connection)
                        cmd.Parameters.AddWithValue("@customer", txt_customer_name_new.Text.Trim)
                        is_existing_customer = cmd.ExecuteScalar()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try

                If is_existing_customer = 1 Then
                    MsgBox("This customer is already registered!" & Environment.NewLine &
                           "Converting to Sales Order..", vbInformation + vbOKOnly, "Information")
                End If

                If is_existing_customer = 0 Then
                    MsgBox("Register new customer to database first.", vbInformation + vbOKOnly, "Information")

                    Dim new_customer_frm = New frm_sales_customers_new
                    new_customer_frm.txt_fname.Text = txt_customer_name_new.Text.Trim
                    new_customer_frm.txt_contact_person.Text = txt_contact_person.Text.Trim
                    new_customer_frm.txt_contact.Text = txt_contact_no.Text
                    new_customer_frm.txt_address.Text = txt_delivery_address.Text
                    new_customer_frm.cbb_account_type.Enabled = False
                    new_customer_frm.panel_admin.Visible = False
                    new_customer_frm.ShowDialog()
                    If new_customer_frm.is_new_customer Then
                        is_new_customer = 1
                    End If
                End If

            ElseIf rg_customer_type.EditValue = "existing" Then
                is_existing_customer = 1
            End If

            'PROCEEDING TO SALES ORDER
            If is_new_customer = 1 Or is_existing_customer = 1 Then

                'Update ims_quotations NEW to EXISTING
                Try
                    Using connection = New MySqlConnection(str)
                        connection.Open()
                        Dim cmd = New MySqlCommand("UPDATE ims_quotations SET customer_type='existing' WHERE quotation_id=" & CInt(lbl_quotation_id.Text), connection)
                        cmd.ExecuteNonQuery()

                        'Transfer Data to Order Form
                        Dim frm = New frm_sales_order_new
                        With frm
                            Await frm_main.LoadFrm(frm, "frm_sales_order_new")
                            frm.cbb_customer.EditValue = IIf(rg_customer_type.EditValue = "new", txt_customer_name_new.Text, cbb_customer.EditValue)
                            frm.txt_priv_notes.Text = txt_priv_notes.Text
                            frm.txt_pub_notes.Text = txt_pub_notes.Text
                            frm.txt_quote_id.Text = "Q" & lbl_quotation_id.Text
                            frm.cbb_discount.SelectedIndex = cbb_discount.SelectedIndex
                            frm.txt_discount.Enabled = txt_discount.Enabled
                            frm.txt_discount.Text = txt_discount.Text
                            frm.cb_vatable.Checked = cb_vatable.Checked
                            frm.cb_withholding_tax_applied.Checked = cb_withholding_tax_applied.Checked
                            If Not String.IsNullOrEmpty(txt_delivery_fee.Text) Then
                                frm.txt_delivery_fee.Text = FormatCurrency(txt_delivery_fee.Text)
                            End If
                        End With

                        frm.grid_order.DataSource = grid_quotation.DataSource
                        frm.ComputeTotal()
                        frm.txt_search.Enabled = False
                        frm.grid_order_view.OptionsBehavior.ReadOnly = True = False
                        Me.Close()

                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If

        End If

    End Sub

    'BUTTON : RESPONSE
    Private Sub btn_response_Click(sender As Object, e As EventArgs) Handles btn_response.Click
        Dim frm_dialog = New frm_sales_approval_dialog
        Dim dialog_result = frm_dialog.ShowDialog

        If dialog_result = DialogResult.Yes Then

            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("UPDATE ims_quotations 
                                    SET status='Approved', approved_by=@approved_by, approved_date=CURRENT_TIMESTAMP, 
                                    priv_note=@priv_note, pub_note=@pub_note
                                    WHERE quotation_id=@id", connection)
                    cmd.Parameters.AddWithValue("@approved_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("@id", lbl_quotation_id.Text)
                    cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                    cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Approved!", MsgBoxStyle.Information, "Information")
                    Me.Close()
                End Using
            End Using

        ElseIf dialog_result = DialogResult.No Then

            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("UPDATE ims_quotations 
                                    SET status='Declined', 
                                    priv_note=@priv_note, pub_note=@pub_note
                                    WHERE quotation_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", lbl_quotation_id.Text)
                    cmd.Parameters.AddWithValue("@priv_note", txt_priv_notes.Text)
                    cmd.Parameters.AddWithValue("@pub_note", txt_pub_notes.Text)
                    cmd.ExecuteNonQuery()
                    MsgBox("Declined!", MsgBoxStyle.Information, "Information")
                    Me.Close()
                End Using
            End Using

        End If
    End Sub

End Class
