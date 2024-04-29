Imports MySqlConnector

Public Class frm_collection_payment_reversal

    Dim ReversalInfo As New Reversal_Info_Class


    'BUTTON : GET
    Private Sub btn_get_Click(sender As Object, e As EventArgs) Handles btn_get.Click

        If String.IsNullOrWhiteSpace(txt_paymentid.EditValue) Then
            MsgBox("Enter Payment ID first!", vbCritical, "Required")
            Exit Sub
        End If

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT ims_payments_journal.order_id, ims_customers.first_name customer, ims_customers.customer_id, IFNULL(epayment_ref, '') epayment_ref,
                    ims_orders.paid_amount, ims_orders.balance, total_payment
                    FROM ims_payments_journal 
                    LEFT JOIN ims_users on ims_users.usr_id=ims_payments_journal.received_by
                    LEFT JOIN ims_customers ON ims_customers.customer_id=ims_payments_journal.customer_id 
                    LEFT JOIN ims_orders ON ims_orders.order_id=ims_payments_journal.order_id
                    WHERE is_voided='0' AND transaction_id=@transaction_id", conn)
                    cmd.Parameters.AddWithValue("@transaction_id", txt_paymentid.EditValue)

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read

                            txt_orderid.EditValue = rdr("order_id")
                            txt_customer.EditValue = rdr("customer")
                            txt_current_balance.EditValue = rdr("balance")
                            txt_amount_to_reverse.EditValue = rdr("total_payment")
                            txt_new_balance.EditValue = CDec(rdr("balance")) + CDec(rdr("total_payment"))

                            ReversalInfo.customer_id = rdr("customer_id")
                            ReversalInfo.order_paid_amount = rdr("paid_amount")
                            ReversalInfo.epayment_ref = rdr("epayment_ref")

                        End While
                    End Using

                End Using
                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'BUTTON : CANCEL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'BUTTON : REVERSE
    Private Sub btn_reverse_Click(sender As Object, e As EventArgs) Handles btn_reverse.Click
        If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim credit_columns_names As String = String.Empty
                    Dim credit_columns_values As String = String.Empty

                    'GET credit_columns
                    Using cmd_get_columns = New MySqlCommand("SELECT journal_column_name, fund_name FROM ims_banks WHERE is_enabled='1' AND is_credit='1'", conn)
                        Using rdr = cmd_get_columns.ExecuteReader
                            While rdr.Read
                                credit_columns_names += ", " & rdr("journal_column_name")
                                credit_columns_values += ", " & rdr("journal_column_name") & "* -1"
                            End While
                        End Using
                    End Using

                    'INSERT TO Journal
                    Using cmd = New MySqlCommand("INSERT INTO ims_payments_journal (order_id, payment_date, customer_id, current_balance, total_payment, new_balance, epayment_ref, gateway, type, received_by " & credit_columns_names & ")
                                                SELECT order_id, NOW(), customer_id, @current_balance, @total_payment, @new_balance, epayment_ref, gateway, @type, @received_by " & credit_columns_values & " FROM ims_payments_journal
                                                WHERE transaction_id=@transactionID", conn)
                        cmd.Parameters.AddWithValue("@transactionID", txt_paymentid.EditValue)
                        cmd.Parameters.AddWithValue("@current_balance", CDec(txt_current_balance.EditValue))
                        cmd.Parameters.AddWithValue("@total_payment", -CDec(txt_amount_to_reverse.EditValue))
                        cmd.Parameters.AddWithValue("@new_balance", CDec(txt_new_balance.EditValue))
                        cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@type", "Reverse")
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Successfully reverse!", vbInformation, "Information")
                        End If
                    End Using

                    'UPDATE Sales Order
                    Using cmd = New MySqlCommand("UPDATE ims_orders 
                                    SET 
                                    payment_status = If(IFNULL(paid_amount, 0) - @paid_amount = 0, 'UNPAID',
                                                     If(amount_due = IFNULL(paid_amount, 0) - @paid_amount, 'PAID',
                                                     If(amount_due < IFNULL(paid_amount, 0) - @paid_amount, 'OVERPAID',
                                                     If(amount_due > IFNULL(paid_amount, 0) - @paid_amount, 'PARTIAL','UNKNOWN')))), 
                                    paid_amount=IFNULL(paid_amount,0) - @paid_amount,
                                    balance=amount_due - paid_amount
                                    WHERE order_id=@order_id", conn)
                        cmd.Parameters.AddWithValue("@order_id", txt_orderid.EditValue)
                        cmd.Parameters.AddWithValue("@paid_amount", txt_amount_to_reverse.EditValue)
                        cmd.ExecuteNonQuery()
                    End Using

                    conn.Close()
                    Me.DialogResult = DialogResult.OK

                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class

Public Class Reversal_Info_Class
    Public Property customer_id As Integer
    Public Property order_paid_amount As Decimal
    Public Property epayment_ref As String
End Class