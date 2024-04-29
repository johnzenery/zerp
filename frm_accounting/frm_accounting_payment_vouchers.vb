Imports MySqlConnector

Public Class frm_accounting_payment_vouchers


    '--- ONLOAD ----
    Private Sub frm_accounting_payment_vouchers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.EditValue = New DateTime(Date.Now.Year, 1, 1)
        dt_end.EditValue = Date.Now
        load_payment_vouchers(dt_start.EditValue, dt_end.EditValue)
    End Sub




    '---- FUNCTIONS -----

    'Load Payment Vouchers
    Private Sub load_payment_vouchers(startDate As Date, endDate As Date)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT CONCAT('PV', LPAD(payment_id, 5, 0)) as payment_id, UPPER(payment_type) AS payment_type, 
                                        ims_suppliers.supplier, creation_date, voucher_amount, voucher_status, ims_users.first_name released_by, received_by, date_released
                                        FROM ims_payment_vouchers
                                        LEFT JOIN ims_users ON ims_users.usr_id=ims_payment_vouchers.released_by
                                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier 
                                        WHERE creation_date BETWEEN @start_date AND @end_date
                                        ORDER BY payment_id DESC", connection)
                cmd.Parameters.AddWithValue("@start_date", startDate)
                cmd.Parameters.AddWithValue("@end_date", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_payments.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Amount In Words
    Public Function AmountInWords(ByVal nAmount As String, Optional ByVal wAmount _
                 As String = vbNullString, Optional ByVal nSet As Object = Nothing) As String
        'Let's make sure entered value is numeric
        If Not IsNumeric(nAmount) Then Return "Please enter numeric values only."

        Dim tempDecValue As String = String.Empty : If InStr(nAmount, ".") Then _
        tempDecValue = nAmount.Substring(nAmount.IndexOf("."))
        nAmount = Replace(nAmount, tempDecValue, String.Empty)

        Try
            Dim intAmount As Long = nAmount
            If intAmount > 0 Then
                nSet = IIf((intAmount.ToString.Trim.Length / 3) _
                > (CLng(intAmount.ToString.Trim.Length / 3)),
              CLng(intAmount.ToString.Trim.Length / 3) + 1,
                  CLng(intAmount.ToString.Trim.Length / 3))
                Dim eAmount As Long = Microsoft.VisualBasic.Left(intAmount.ToString.Trim,
              (intAmount.ToString.Trim.Length - ((nSet - 1) * 3)))
                Dim multiplier As Long = 10 ^ (((nSet - 1) * 3))

                Dim Ones() As String =
            {String.Empty, "One", "Two", "Three",
              "Four", "Five",
              "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {String.Empty,
            "Eleven", "Twelve", "Thirteen",
              "Fourteen", "Fifteen",
              "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {String.Empty, "Ten",
            "Twenty", "Thirty",
              "Forty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {String.Empty, String.Empty,
            "Thousand", "Million",
              "Billion", "Trillion",
              "Quadrillion", "Quintillion"}

                intAmount = eAmount

                Dim nHundred As Integer = intAmount \ 100 : intAmount = intAmount Mod 100
                Dim nTen As Integer = intAmount \ 10 : intAmount = intAmount Mod 10
                Dim nOne As Integer = intAmount \ 1

                If nHundred > 0 Then wAmount = wAmount &
            Ones(nHundred) & " Hundred " 'This is for hundreds                
                If nTen > 0 Then 'This is for tens and teens
                    If nTen = 1 And nOne > 0 Then 'This is for teens 
                        wAmount = wAmount & Teens(nOne) & " "
                    Else 'This is for tens, 10 to 90
                        wAmount = wAmount & Tens(nTen) & IIf(nOne > 0, " ", " ")
                        If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                    End If
                Else 'This is for ones, 1 to 9
                    If nOne > 0 Then wAmount = wAmount & Ones(nOne) & " "
                End If
                wAmount = wAmount & HMBT(nSet) & " "
                wAmount = AmountInWords(CStr(CLng(nAmount) -
              (eAmount * multiplier)).Trim & tempDecValue, wAmount, nSet - 1)
            Else
                If Val(nAmount) = 0 Then nAmount = nAmount &
            tempDecValue : tempDecValue = String.Empty
                If (Math.Round(Val(nAmount), 2) * 100) > 0 Then wAmount =
              Trim(AmountInWords(CStr(Math.Round(Val(nAmount), 2) * 100),
              wAmount.Trim & " Pesos And ", 1)) & " Cents"
            End If
        Catch ex As Exception
            MessageBox.Show("Error Encountered: " & ex.Message,
          "Convert Numbers To Words",
          MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
      IIf(InStr(wAmount.Trim.ToLower, "pesos"),
      wAmount.Trim, wAmount.Trim & " Pesos")

        'Display the result
        Return wAmount
    End Function







    '---- CONTROLS ----

    'btn_view
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim id As Integer = grid_payments_view.GetFocusedRowCellValue(col_id).ToString.Replace("PV", String.Empty)
                frm_accounting_generate_payment.print_voucher(id, connection)
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_void_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_void.ButtonClick

        'Validation
        Dim voucher_id As Integer = grid_payments_view.GetFocusedRowCellValue(col_id).ToString.Replace("PV", String.Empty)
        Dim voucher_status = grid_payments_view.GetFocusedRowCellValue(col_status)
        If voucher_status = "VOIDED" Then
            MsgBox("Voided already!", vbInformation, "Information")
            Exit Sub
        End If

        If MsgBox("Do you to VOID this voucher?" & vbNewLine & "Press 'Yes' to continue.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
            Try
                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_payment_vouchers SET voucher_status='VOIDED' 
                                    WHERE payment_id=" & voucher_id, connect)
                        If cmd.ExecuteNonQuery > 0 Then

                            'Unpaid Receipts
                            Using cmd_update_receipt = New MySqlCommand("UPDATE ims_delivery_receipts 
                                                            SET status='UNPAID', p_voucher_id=NULL WHERE p_voucher_id=" & voucher_id, connect)
                                cmd_update_receipt.ExecuteNonQuery()
                            End Using

                            'Void Purchase Returns
                            Using cmd_update_purchase_returns = New MySqlCommand("UPDATE ims_purchase_returns
                                                            SET status='Pending', is_applied='0', p_voucher_id=NULL
                                                            WHERE p_voucher_id=" & voucher_id, connect)
                                cmd_update_purchase_returns.ExecuteNonQuery()
                            End Using

                            'Void Cheque
                            Using cmd_update_cheque = New MySqlCommand("UPDATE ims_generated_cheques
                                                            SET status='VOIDED'
                                                            WHERE p_voucher_id=" & voucher_id, connect)
                                cmd_update_cheque.ExecuteNonQuery()
                            End Using

                            MsgBox("Voided!", vbInformation, "Information")

                        End If
                    End Using

                End Using

                load_payment_vouchers(dt_start.EditValue, dt_end.EditValue)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_release_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_release.ButtonClick
        Dim payment_id As Integer = grid_payments_view.GetFocusedRowCellValue(col_id).ToString.Replace("PV", String.Empty)
        Dim frm = New frm_accounting_payment_vouchers_release
        frm.payment_id = payment_id
        If frm.ShowDialog() = DialogResult.OK Then
            load_payment_vouchers(dt_start.EditValue, dt_end.EditValue)
        End If
    End Sub

End Class