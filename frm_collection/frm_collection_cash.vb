Imports MySqlConnector

Public Class frm_collection_cash

    Public Property id As Integer = 0
    Public Property amount As Decimal = 0.00
    Private Property sales_order_amount As Decimal = 0.00

    '-- ONLOAD ---
    Private Sub frm_collection_cash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Clear Sales Return Values on Load
        sales_return_amount = 0.00
        sales_return_id = 0
    End Sub



    '--- FUNCTIONS ---

    'Load Data
    Public Sub LoadData(orderid As Integer, customer As String, amountdue As String)
        lbl_orderid.Text = orderid
        lbl_customer.Text = customer
        sales_order_amount = amountdue
        lbl_amount_due.Text = FormatCurrency(amountdue)
    End Sub




    '--- CONTROLS ----

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click

        Dim ans = MsgBox("Mark it as PAID?" & vbCrLf & "Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Using transc = connection.BeginTransaction

                        Try
                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_option=@option, 
                                payment_status = If(amount_due = IFNULL(paid_amount, 0) + @paid_amount + @sr_amount, 'PAID',
                                                 If(amount_due < IFNULL(paid_amount, 0) + @paid_amount + @sr_amount, 'OVERPAID',
                                                 If(amount_due > IFNULL(paid_amount, 0) + @paid_amount + @sr_amount, 'PARTIAL',''))), 
                                paid_amount=IFNULL(paid_amount,0) + @paid_amount + @sr_amount,
                                applied_sales_return=@srid,
                                status=IF((status='Released' AND shipping_method='Deliver'), 'Completed', status) 
                                WHERE order_id=" & lbl_orderid.Text, connection, transc)
                            cmd.Parameters.AddWithValue("@option", "CASH")
                            cmd.Parameters.AddWithValue("@paid_amount", CDec(txt_amount_tendered.Text))
                            cmd.Parameters.AddWithValue("@srid", sales_return_id)
                            cmd.Parameters.AddWithValue("@sr_amount", sales_return_amount)
                            cmd.ExecuteNonQuery()

                            'INSERT TO PAYMENT LOGS
                            Dim payment_id = Insert_PaymentLog(connection, Date.Now, lbl_orderid.Text, lbl_customer.Text, sales_order_amount, txt_amount_tendered.Text, sales_return_amount, lbl_balance.Text, "CASH", Nothing)
                            Update_SalesReturns(sales_return_id, "Payment ID #" & payment_id, 0, connection, transc)
                            transc.Commit()

                            MsgBox("Successful Transaction!", vbInformation, "Information")

                        Catch ex As Exception
                            transc.Rollback()
                        End Try
                    End Using

                    connection.Close()
                End Using

                Me.DialogResult = DialogResult.OK
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    Private Sub btn_deduct_Click(sender As Object, e As EventArgs) Handles btn_deduct.Click
        If btn_deduct.Text.Equals("Deduct Returns") Then

            sales_return_amount = 0.00
            sales_return_id = 0

            Dim frm = New frm_collection_return_picker
            frm.SalesReturnsLoad(lbl_customer.Text)
            frm.ShowDialog()

            If Not sales_return_amount = 0 Then
                btn_deduct.Text = "Remove Deduction"
                btn_deduct.Appearance.BackColor = Color.IndianRed
                lbl_deduction.Visible = True
                lbl_amount_due.Text = FormatCurrency(CDec(lbl_amount_due.Text) - sales_return_amount)
                lbl_deduction.Text = "Deducted Amount: " & FormatCurrency(sales_return_amount)

                Dim amount_tendered As Decimal = IIf(String.IsNullOrEmpty(txt_amount_tendered.Text.Trim), 0, txt_amount_tendered.Text.Trim)
                Dim amount_to_pay As Decimal = lbl_amount_due.Text.Trim
                lbl_balance.Text = FormatCurrency(amount_to_pay - amount_tendered)
            End If

        Else
            btn_deduct.Text = "Deduct Returns"
            lbl_amount_due.Text = FormatCurrency(CDec(lbl_amount_due.Text) + CDec(lbl_deduction.Text.Replace("Deducted Amount: ", String.Empty)))
            btn_deduct.Appearance.BackColor = Nothing
            lbl_deduction.Visible = False
            sales_return_amount = 0.00
            sales_return_id = 0
        End If

    End Sub

    'txt_amount_tendered.KeyPress
    Private Sub txt_amount_tendered_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_amount_tendered.KeyPress
        'Only Numbers, backspace, decimal
        'If (e.KeyChar.ToString = ".") And (txt_amount_tendered.Text.Contains(e.KeyChar.ToString)) Then
        '    e.Handled = True
        '    Exit Sub
        'End If

        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Or e.KeyChar = "-" Or Char.IsControl(e.KeyChar))
    End Sub

    'txt_amount_tendered.KeyUp
    Private Sub txt_amount_tendered_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_amount_tendered.KeyUp
        If Not String.IsNullOrWhiteSpace(txt_amount_tendered.Text) Or txt_amount_tendered.Text.Equals("-") Then
            Dim amount_tendered As Decimal = txt_amount_tendered.Text.Trim
            Dim amount_to_pay As Decimal = lbl_amount_due.Text.Trim
            lbl_balance.Text = FormatCurrency(Decimal.Subtract(amount_to_pay, amount_tendered))
        Else
            lbl_balance.Text = lbl_amount_due.Text
        End If
    End Sub


End Class