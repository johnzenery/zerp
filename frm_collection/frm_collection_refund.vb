Imports MySqlConnector

Public Class frm_collection_refund

    ReadOnly conn As New MySqlConnection(str)

    'Load Data
    Public Sub LoadData(orderid As Integer, customer As String, amountdue As String, type As String)
        lbl_orderid.Text = orderid
        lbl_customer.Text = customer
        refund_type.Text = type
        lbl_amount_due.Text = FormatCurrency(amountdue)
    End Sub

    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click

        Dim ans = MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation")
        If ans = vbYes Then
            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_status=@p_status, paid_amount=paid_amount-@payment_status
                                            WHERE order_id=" & lbl_orderid.Text, conn)
                cmd.Parameters.AddWithValue("@payment_status", Math.Abs(CDec(lbl_amount_due.Text)))
                cmd.Parameters.AddWithValue("@p_status", IIf(refund_type.Text.Equals("OVERPAID"), "PAID", "UNPAID"))
                cmd.ExecuteNonQuery()

                'INSERT TO PAYMENT LOGS
                Insert_PaymentLog(conn, Date.Now, lbl_orderid.Text, lbl_customer.Text, CDec(lbl_amount_due.Text) * -1, CDec(lbl_amount_due.Text) * -1, 0.00, 0.00, "REFUND", Nothing)

                MsgBox("Successful Transaction!", vbInformation, "Information")

                frm_main.LoadFrm(New frm_collection_payments)
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If
    End Sub
End Class