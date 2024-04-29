
Imports System.Globalization
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.BandedGrid
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_collection_cashier_register_pay

    Private Property bank_list As New List(Of String)
    Private Property payees_list As New List(Of String)
    Private Property fund_acc_list As New List(Of String)
    Private Property gateway_list As New List(Of String)
    Private Property cc_terminal_list As New List(Of String)
    Private Property total_tendered_amount As Decimal = 0.00

    Dim customer_banks(,) As String
    Dim ListOfItem As List(Of ChequesClass) = New List(Of ChequesClass)

    '--- ONLOAD
    Private Sub frm_collection_cashier_register_pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Banks()
        Load_PayeeName()
        Load_Gateways()
        Load_FundAccounts()
        LoadBanksDetails()
        Load_Terminals()
        btn_add_Click(sender, e)
    End Sub



    '--- FUNCTIONS

    Public Sub Compute()

        Dim amount_to_pay As Decimal = lbl_amount.Text
        Dim total_tendered As Decimal = 0.00

        'GET TOTAL TENDERED AMOUNT
        For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
            total_tendered += CDec(ctl.txt_amount.EditValue)
        Next

        total_tendered_amount = total_tendered
        Dim total_amount_due = amount_to_pay - total_tendered
        txt_balance.EditValue = FormatCurrency(total_amount_due)
    End Sub

    Private Sub Load_Banks()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT DISTINCT bank FROM ims_cheque_collections", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            bank_list.Add(rdr("bank"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Load_Gateways()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT DISTINCT gateway FROM ims_payments_journal", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            If Not IsDBNull(rdr("gateway")) Then
                                gateway_list.Add(rdr("gateway"))
                            End If
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Load_PayeeName()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT DISTINCT payee_name FROM ims_cheque_collections", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            payees_list.Add(rdr("payee_name"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub Load_FundAccounts()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT fund_name FROM ims_banks WHERE is_credit=1 AND is_enabled='1'", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            fund_acc_list.Add(rdr("fund_name"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load Banks
    Private Sub LoadBanksDetails()
        If Not String.IsNullOrEmpty(lbl_customer_name.Text) Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT banks FROM ims_customers WHERE first_name=@first_name", conn)
                        cmd.Parameters.AddWithValue("@first_name", lbl_customer_name.Text)
                        Using rdr = cmd.ExecuteReader

                            While rdr.Read
                                If Not IsDBNull(rdr("banks")) Then

                                    Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesCustomerBankAccounts))(rdr("banks"))

                                    ReDim customer_banks(itemsObject.Count - 1, 2)
                                    Dim i As Integer = 0

                                    For Each item In itemsObject
                                        For j = 0 To 2
                                            If j = 0 Then customer_banks(i, j) = item.bank
                                            If j = 1 Then customer_banks(i, j) = item.bank_acc_no
                                            If j = 2 Then customer_banks(i, j) = item.bank_acc_name
                                        Next
                                        i += 1
                                    Next
                                End If
                            End While
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'Load Terminals
    Private Sub Load_Terminals()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT terminal_name FROM ims_cc_terminals WHERE is_deleted='0'", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cc_terminal_list.Add(rdr("terminal_name"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    'Validate Payments
    Private Function Validate_Payments()

        Try
            For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls

                'CHECK Fund
                If String.IsNullOrWhiteSpace(ctl.cbb_fund.EditValue) Then
                    MsgBox("Select creding fund!", vbCritical, "Required")
                    Return False
                End If

                'CHECK Amount
                If String.IsNullOrWhiteSpace(ctl.txt_amount.Text) Then
                    MsgBox("Payment amount should not blank.", vbCritical, "Required")
                    Return False
                End If

                '------

                'if e-pay : should have reference
                If ctl.rg_payment_type.EditValue = "E-Payment" And String.IsNullOrWhiteSpace(ctl.txt_epaymen_ref.Text) Then
                    MsgBox("E-Payment reference is required!", vbCritical, "Required")
                    Return False
                End If

                'if cheque : should be complete
                If ctl.rg_payment_type.EditValue = "Cheque" Then
                    If String.IsNullOrWhiteSpace(ctl.txt_cheque_no.Text) Or ctl.dt_cheque_date.EditValue = Nothing Or
                        String.IsNullOrWhiteSpace(ctl.txt_acc_no.Text) Or String.IsNullOrWhiteSpace(ctl.txt_acc_name.Text) Or ctl.cbb_bank.EditValue = Nothing Then
                        MsgBox("Fill all required fields!", vbCritical, "Required")
                        Return False
                    End If
                End If

                'if credit card : should be complete
                If ctl.rg_payment_type.EditValue = "Credit Card" Then
                    If ctl.cbb_terminal.EditValue = Nothing Then
                        MsgBox("Fill all required fields!", vbCritical, "Required")
                        Return False
                    End If
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function

    'Insert to Cheque Collection
    Private Sub Insert_Cheque()

        Using conn = New MySqlConnection(str)
            conn.Open()

            For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
                If ctl.rg_payment_type.EditValue = "Cheque" Then

                    Dim cheque_cmd = New MySqlCommand("INSERT INTO ims_cheque_collections (cheque_date, cheque_no, amount, acc_name, acc_no, payee_name, customer_id, orders, bank, status, entry_date, collected_by) 
                                                VALUES (@cheque_date, @cheque_no, @amount, @acc_name, @acc_no, @payee_name, (SELECT customer_id FROM ims_customers WHERE first_name=@customer_name), 
                                                        @orders, @bank, @status, CURRENT_TIMESTAMP, @collected_by)", conn)
                    cheque_cmd.Parameters.AddWithValue("@cheque_no", ctl.txt_cheque_no.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@cheque_date", ctl.dt_cheque_date.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@amount", ctl.txt_amount.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@bank", ctl.cbb_bank.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@acc_no", ctl.txt_acc_no.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@acc_name", ctl.txt_acc_name.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@payee_name", ctl.cbb_payee.EditValue)
                    cheque_cmd.Parameters.AddWithValue("@orders", CInt(lbl_orderid.Text.Replace("SO", "")))
                    cheque_cmd.Parameters.AddWithValue("@customer_name", lbl_customer_name.Text)
                    cheque_cmd.Parameters.AddWithValue("@status", "RECEIVED")
                    cheque_cmd.Parameters.AddWithValue("@collected_by", frm_main.lbl_user_id.Text)
                    cheque_cmd.ExecuteNonQuery()

                End If
            Next
        End Using

    End Sub

    'UPDATE Sales Orders
    Private Sub Update_SalesOrdersAndReturns(order_id As Integer, paid_amount As Decimal, collection_id As Integer, Optional type As String = "Pay")
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Dim sales_return As String = String.Empty
                Dim resultList As List(Of Integer) = New List(Of Integer)

                Using cmd = New MySqlCommand("UPDATE ims_orders 
                                    LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims_orders.applied_sales_return
                                    SET 
                                    ims_sales_returns.is_applied='1', ims_sales_returns.collection_id=@collection_id,
                                    payment_status = If(IFNULL(paid_amount, 0) + @paid_amount = 0, 'PAID',
                                                     If(amount_due = IFNULL(paid_amount, 0) + @paid_amount, 'PAID',
                                                     If(amount_due < IFNULL(paid_amount, 0) + @paid_amount, 'OVERPAID',
                                                     If(amount_due > IFNULL(paid_amount, 0) + @paid_amount, 'PARTIAL','UNKNOWN')))), 
                                    paid_amount=IFNULL(paid_amount,0) + @paid_amount,
                                    balance=amount_due - paid_amount,
                                    ims_orders.status=IF((ims_orders.status='Released' AND shipping_method='Deliver'), 'Completed', ims_orders.status) 
                                    WHERE order_id=@order_id", conn)
                    cmd.Parameters.AddWithValue("@order_id", order_id)
                    cmd.Parameters.AddWithValue("@paid_amount", paid_amount)
                    cmd.Parameters.AddWithValue("@collection_id", collection_id)
                    cmd.ExecuteNonQuery()
                End Using

                'GET SALES RETURN LIST FROM ORDERS
                Using selectReturnsCmd = New MySqlCommand("SELECT sales_return FROM ims_orders WHERE order_id=@order_id", conn)
                    selectReturnsCmd.Parameters.AddWithValue("@order_id", order_id)
                    sales_return = selectReturnsCmd.ExecuteScalar
                End Using

                'UPDATE SALES RETURN LIST
                If Not String.IsNullOrWhiteSpace(sales_return) Then
                    For Each rid As String In JsonConvert.DeserializeObject(Of List(Of Integer))(sales_return)
                        Using updateReturn = New MySqlCommand("UPDATE ims_sales_returns 
                                                           SET 
                                                           is_applied='1', collection_id=@collection_id
                                                           WHERE sales_return_id=@sales_return_id", conn)
                            updateReturn.Parameters.AddWithValue("sales_return_id", rid)
                            updateReturn.Parameters.AddWithValue("@collection_id", collection_id)
                            updateReturn.ExecuteNonQuery()
                        End Using
                    Next
                End If

                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'INSERT Collection Receipts
    Private Function Insert_CollectionReceipts() As Integer
        Dim collection_id As Integer = 0
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd_collection = New MySqlCommand("INSERT INTO ims_collection_receipts (customer_id, sales_orders, cheques, date_generated, collected_by) 
                                            VALUES ((SELECT customer_id FROM ims_customers WHERE first_name=@customer_name), @sales_orders, @cheques, NOW(), @collected_by)", conn)

                    For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
                        If ctl.rg_payment_type.EditValue = "Cheque" Then

                            ListOfItem.Add(New ChequesClass With {
                            .cheque_no = ctl.txt_cheque_no.EditValue,
                            .cheque_date = ctl.dt_cheque_date.EditValue, 'Date.ParseExact(ctl.dt_cheque_date.EditValue, "MM/dd/yyyy", CultureInfo.InvariantCulture),
                            .bank = ctl.cbb_bank.EditValue,
                            .amount = ctl.txt_amount.EditValue,
                            .acc_no = ctl.txt_acc_no.EditValue,
                            .acc_name = ctl.txt_acc_name.EditValue,
                            .payee_name = ctl.cbb_payee.EditValue
                        })
                        End If
                    Next

                    'GET ORDERS / TRANSACTIONS
                    Dim ListOfOrders As List(Of SalesOrdersModel) = New List(Of SalesOrdersModel)
                    Dim sales_orders = CInt(lbl_orderid.Text.Replace("SO", String.Empty))
                    Using cmd = New MySqlCommand("SELECT order_id, invoice_no, DATE_ADD(date_released, INTERVAL terms DAY) AS due_date, balance
                                        FROM ims_orders 
                                        LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims_orders.applied_sales_return
                                        WHERE order_id=" & sales_orders, conn)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                ListOfOrders.Add(New SalesOrdersModel With {
                                    .So_no = rdr("order_id"),
                                    .Invoice_no = rdr("invoice_no"),
                                    .DR_no = String.Empty,
                                    .Due_Date = IIf(IsDBNull(rdr("due_date")), Nothing, rdr("due_date")),
                                    .Balance = rdr("balance")
                                })
                            End While
                        End Using
                    End Using

                    cmd_collection.Parameters.AddWithValue("@customer_name", lbl_customer_name.Text)
                    'cmd_collection.Parameters.AddWithValue("@so_nos", CInt(lbl_orderid.Text.Replace("SO", String.Empty)))
                    cmd_collection.Parameters.AddWithValue("@sales_orders", JsonConvert.SerializeObject(ListOfOrders))
                    cmd_collection.Parameters.AddWithValue("@cheques", JsonConvert.SerializeObject(ListOfItem))
                    cmd_collection.Parameters.AddWithValue("@collected_by", frm_main.lbl_user_id.Text)
                    cmd_collection.ExecuteNonQuery()
                    collection_id = cmd_collection.LastInsertedId
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return collection_id

    End Function

    'INSERT E-PAYMENTS
    Private Sub Insert_EPayments(collection_id As Integer)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
                    If ctl.rg_payment_type.EditValue = "E-Payment" Then


                        Using cmd = New MySqlCommand("INSERT INTO ims_collection_epayments (collection_id, gateway, bank_id, reference, amount, created_at) 
                                              VALUES (@collection_id, @gateway, (SELECT bank_id FROM ims_banks WHERE fund_name=@fund_name), @reference, @amount, CURRENT_TIMESTAMP)", conn)
                            cmd.Parameters.AddWithValue("@collection_id", collection_id)
                            cmd.Parameters.AddWithValue("@gateway", ctl.cbb_gateway.EditValue)
                            cmd.Parameters.AddWithValue("@fund_name", ctl.cbb_fund.EditValue)
                            cmd.Parameters.AddWithValue("@reference", ctl.txt_epaymen_ref.EditValue)
                            cmd.Parameters.AddWithValue("@amount", ctl.txt_amount.EditValue)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'INSERT CASH
    Private Sub Insert_Cash(collection_id As Integer)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
                    If ctl.rg_payment_type.EditValue = "Cash" Then


                        Using cmd = New MySqlCommand("INSERT INTO ims_collection_cash (collection_id, amount, created_at) 
                                              VALUES (@collection_id, @amount, CURRENT_TIMESTAMP)", conn)
                            cmd.Parameters.AddWithValue("@collection_id", collection_id)
                            cmd.Parameters.AddWithValue("@amount", ctl.txt_amount.EditValue)
                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'INSERT CREDIT CARD
    Private Sub Insert_CreditCard(collection_id As Integer)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
                    If ctl.rg_payment_type.EditValue = "Credit Card" Then


                        Using cmd = New MySqlCommand("INSERT INTO ims_collection_creditcard (collection_id, terminal_id, card_holder, card_no, amount, created_at) 
                                              VALUES (@collection_id, (SELECT terminal_id FROM ims_cc_terminals WHERE terminal_name=@terminal), @card_holder, @card_no, @amount, CURRENT_TIMESTAMP)", conn)
                            cmd.Parameters.AddWithValue("@collection_id", collection_id)
                            cmd.Parameters.AddWithValue("@terminal", ctl.cbb_terminal.EditValue)
                            cmd.Parameters.AddWithValue("@card_holder", ctl.txt_cc_name.EditValue)
                            cmd.Parameters.AddWithValue("@card_no", ctl.txt_cc_number.EditValue)
                            cmd.Parameters.AddWithValue("@amount", ctl.txt_amount.EditValue)

                            cmd.ExecuteNonQuery()
                        End Using
                    End If
                Next
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub





    '--- EVENTS

    'BUTTON : ADD
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim ctl = New ctl_collection_cashier_register_pay
            AddHandler ctl.txt_amount.KeyUp, AddressOf Compute
            AddHandler ctl.btn_delete.Click, AddressOf Compute
            ctl.cbb_payee.Properties.Items.AddRange(payees_list)
            ctl.cbb_gateway.Properties.Items.AddRange(gateway_list)
            ctl.cbb_fund.Properties.Items.AddRange(fund_acc_list)
            ctl.cbb_terminal.Properties.Items.AddRange(cc_terminal_list)

            If Not IsNothing(customer_banks) Then
                For i = 1 To customer_banks.Length / 3
                    ctl.cbb_bank.Properties.Items.Add(customer_banks(i - 1, 0).ToString)
                Next
                ctl._banks = customer_banks
            End If

            panel_payments.Controls.Add(ctl)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : CANCEL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'BUTTON : SUBMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Dim type_cash As Boolean = False
        Dim type_epayment As Boolean = False
        Dim type_cheque As Boolean = False
        Dim type_credit_card As Boolean = False

        For Each control As ctl_collection_cashier_register_pay In panel_payments.Controls

            'ONE CASH ONLY
            If control.rg_payment_type.EditValue = "Cash" Then
                If type_cash = False Then
                    type_cash = True
                Else
                    MsgBox("Same type of payment is not allowed! (Cash)", vbCritical, "Forbidden")
                    Return
                End If
            End If

            'ONE E-PAYMENT ONLY
            If control.rg_payment_type.EditValue = "E-Payment" Then
                If type_epayment = False Then
                    type_epayment = True
                Else
                    MsgBox("Same type of payment is not allowed! (E-Payment)", vbCritical, "Forbidden")
                    Return
                End If
            End If

            'ONE CHEQUE ONLY
            If control.rg_payment_type.EditValue = "Cheque" Then
                If type_cheque = False Then
                    type_cheque = True
                Else
                    MsgBox("Same type of payment is not allowed! (Cheque)", vbCritical, "Forbidden")
                    Return
                End If
            End If

            'ONE CREDIT CARD ONLY
            If control.rg_payment_type.EditValue = "Credit Card" Then
                If type_credit_card = False Then
                    type_credit_card = True
                Else
                    MsgBox("Same type of payment is not allowed! (Credit Card)", vbCritical, "Forbidden")
                    Return
                End If
            End If

        Next

        If Validate_Payments() = True Then

            If MsgBox("Press 'Yes' to confirm.", vbInformation + vbYesNo, "Confirmation") = vbYes Then
                Try
                    Using conn = New MySqlConnection(str)
                        conn.Open()

                        Dim fund_names_list As String = String.Empty
                        Dim fund_values As String = String.Empty
                        Dim order_id As Integer = lbl_orderid.Text.Replace("SO", "")
                        Dim epayment_ref As String = String.Empty
                        Dim gateway As String = String.Empty

                        'GET FUND NAME AND VALUES (AMOUNT)
                        For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
                            'GET fund name and amount
                            Using cmd_select = New MySqlCommand("SELECT journal_column_name FROM ims_banks WHERE fund_name=@fund_name", conn)
                                cmd_select.Parameters.AddWithValue("@fund_name", ctl.cbb_fund.Text)
                                Using rdr = cmd_select.ExecuteReader
                                    While rdr.Read
                                        fund_names_list += rdr("journal_column_name") & ", "
                                        fund_values += CDec(ctl.txt_amount.Text) & ", "
                                    End While
                                End Using
                            End Using

                            'GET E-Payment Ref.
                            If ctl.rg_payment_type.EditValue = "E-Payment" Then
                                epayment_ref = ctl.txt_epaymen_ref.Text.Trim
                                gateway = ctl.cbb_gateway.EditValue

                            ElseIf ctl.rg_payment_type.EditValue = "Credit Card" Then
                                gateway = ctl.cbb_terminal.EditValue

                            End If
                        Next

                        'REMOVE , ON STRING
                        fund_names_list = fund_names_list.Substring(0, fund_names_list.Length - 2)
                        fund_values = fund_values.Substring(0, fund_values.Length - 2)

                        'INSERT INTO PAYMENT JOURNAL
                        Using cmd = New MySqlCommand("INSERT INTO ims_payments_journal 
                                (order_id, payment_date, customer_id, type, current_balance, total_payment, new_balance, received_by, epayment_ref, gateway, " & fund_names_list & ") 
                                VALUES (@order_id, NOW(), (SELECT customer_id FROM ims_customers WHERE first_name=@customer_name), @type, @current_balance, 
                                         @total_payment, @new_balance, @received_by, @epayment_ref, @gateway, " & fund_values & ") ", conn)

                            cmd.Parameters.AddWithValue("@order_id", order_id)
                            cmd.Parameters.AddWithValue("@customer_name", lbl_customer_name.Text)
                            cmd.Parameters.AddWithValue("@type", "Pay")
                            cmd.Parameters.AddWithValue("@current_balance", CDec(lbl_amount.Text))
                            cmd.Parameters.AddWithValue("@total_payment", total_tendered_amount)
                            cmd.Parameters.AddWithValue("@new_balance", CDec(txt_balance.Text))
                            cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@epayment_ref", IIf(String.IsNullOrWhiteSpace(epayment_ref), Nothing, epayment_ref))
                            cmd.Parameters.AddWithValue("@gateway", gateway)
                            If cmd.ExecuteNonQuery() > 0 Then

                                'Insert Cheques to Cheque Collections
                                Insert_Cheque()

                                'INSERT to collection_payments : E-Payments, Cash, Cheque
                                Dim collection_id = Insert_CollectionReceipts()
                                Insert_Cash(collection_id)
                                Insert_EPayments(collection_id)
                                Insert_CreditCard(collection_id)

                                'UPDATE Sales Orders
                                Update_SalesOrdersAndReturns(order_id, total_tendered_amount, collection_id)

                                If cb_print_collection_receipt.Checked = True Then
                                    frm_collection_receipts.Print_Collection_Receipt(collection_id)
                                End If

                                MsgBox("Success!", vbInformation, "Information")
                                Me.DialogResult = DialogResult.OK
                                Me.Close()
                            End If

                        End Using
                    End Using

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If
        End If
    End Sub

    'BUTTON : EPAYMENT RECEIPT
    Private Sub btn_epay_Click(sender As Object, e As EventArgs) Handles btn_epay.Click
        Dim frm As New frm_sales_order_epayment_proofs()
        frm.lbl_order_id.Text = lbl_orderid.Text
        frm.LoadData()
        frm.ShowDialog()
    End Sub
End Class

Public Class SalesOrdersModel
    Property So_no As String
    Property Invoice_no As String
    Property DR_no As String
    Property Due_Date As Date
    Property Balance As Decimal
End Class