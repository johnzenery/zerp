Imports DevExpress.XtraGrid.Views
Imports MySqlConnector

Public Class frm_collection_cashier_refund

    Private Property fund_acc_list As New List(Of String)
    Private Property total_tendered_amount As Decimal = 0.00

    Private Sub frm_collection_cashier_refund_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Customers()
        Load_FundAccounts()
        btn_add_Click(sender, e)
    End Sub





    '---- FUNCTIONS

    Public Sub Compute()

        Dim total_tendered As Decimal = 0.00

        'GET TOTAL TENDERED AMOUNT
        For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls
            total_tendered += CDec(ctl.txt_amount.EditValue)
        Next

        total_tendered_amount = total_tendered
        txt_balance.EditValue = FormatCurrency(total_tendered)

    End Sub

    Private Sub Load_FundAccounts()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT fund_name FROM ims_banks WHERE is_debit=1 AND is_enabled='1'", conn)
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

    Private Sub Load_Customers()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT first_name FROM ims_customers WHERE is_deleted=0", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_customer.Properties.Items.Add(rdr("first_name"))
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

            'Customer
            If String.IsNullOrWhiteSpace(cbb_customer.EditValue) Then
                MsgBox("Select customer first!", vbCritical, "Required")
                Return False
            End If

            For Each ctl As ctl_collection_cashier_register_pay In panel_payments.Controls

                'Fund
                If String.IsNullOrWhiteSpace(ctl.cbb_fund.EditValue) Then
                    MsgBox("Select debiting fund!", vbCritical, "Required")
                    Return False
                End If

                'Amount
                If String.IsNullOrWhiteSpace(ctl.txt_amount.Text) Then
                    MsgBox("Payment amount should not blank.", vbCritical, "Required")
                    Return False
                End If

                'if e-pay : should have reference
                If ctl.rg_payment_type.EditValue = "E-Payment" And String.IsNullOrWhiteSpace(ctl.txt_epaymen_ref.Text) Then
                    MsgBox("E-Payment reference is required!", vbCritical, "Required")
                    Return False
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return True

    End Function







    '---- CONTROLS / EVENTS

    'BUTTON : ADD
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Try
            Dim ctl = New ctl_collection_cashier_register_pay

            ctl.rg_payment_type.Properties.Items.RemoveAt(2)
            AddHandler ctl.txt_amount.KeyUp, AddressOf Compute
            ctl.lbl_fund.Text = "Debit Fund"
            ctl.cbb_fund.Properties.Items.AddRange(fund_acc_list)
            panel_payments.Controls.Add(ctl)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : SUBMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        Dim type_cash As Boolean = False
        Dim type_epayment As Boolean = False

        For Each control As ctl_collection_cashier_register_pay In panel_payments.Controls

            'ONE CASH ONLY
            If control.rg_payment_type.EditValue = "Cash" Then
                If type_cash = False Then
                    type_cash = True
                Else
                    MsgBox("Same type of refund is not allowed! (Cash)", vbCritical, "Forbidden")
                    Return
                End If
            End If

            'ONE E-PAYMENT ONLY
            If control.rg_payment_type.EditValue = "E-Payment" Then
                If type_epayment = False Then
                    type_epayment = True
                Else
                    MsgBox("Same type of refund is not allowed! (E-Payment)", vbCritical, "Forbidden")
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
                        Dim epayment_ref As String = String.Empty

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
                            End If
                        Next

                        'REMOVE , ON STRING
                        fund_names_list = fund_names_list.Substring(0, fund_names_list.Length - 2)
                        fund_values = fund_values.Substring(0, fund_values.Length - 2)

                        'INSERT INTO PAYMENT JOURNAL
                        Using cmd = New MySqlCommand("INSERT INTO ims_payments_journal 
                                (payment_date, customer_id, type, total_payment, received_by, epayment_ref, " & fund_names_list & ") 
                                VALUES (NOW(), (SELECT customer_id FROM ims_customers WHERE first_name=@customer_name), @type, @total_payment, @received_by, @epayment_ref, " & fund_values & ") ", conn)

                            cmd.Parameters.AddWithValue("@customer_name", cbb_customer.EditValue)
                            cmd.Parameters.AddWithValue("@type", "Refund")
                            cmd.Parameters.AddWithValue("@total_payment", total_tendered_amount)
                            cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@epayment_ref", IIf(String.IsNullOrWhiteSpace(epayment_ref), Nothing, epayment_ref))
                            If cmd.ExecuteNonQuery() > 0 Then
                                MsgBox("Refund success!", vbInformation, "Information")
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

    'BUTTON : CANCEL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

End Class