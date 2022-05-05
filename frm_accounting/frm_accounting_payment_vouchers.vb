Imports DevExpress.XtraReports.UI
Imports MySql.Data.MySqlClient

Public Class frm_accounting_payment_vouchers

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ----
    Private Sub frm_accounting_payment_vouchers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_payment_vouchers()
    End Sub




    '---- FUNCTIONS -----

    'Load Payment Vouchers
    Private Sub load_payment_vouchers()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT CONCAT('PV', LPAD(payment_id, 5, 0)) as payment_id, UPPER(payment_type) AS payment_type, ims_suppliers.supplier, creation_date, voucher_amount, voucher_status FROM ims_payment_vouchers
                                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier ORDER BY payment_id DESC", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_payments.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Print Voucher
    Private Sub print_voucher(id As Integer)
        Dim report = New doc_payment_voucher()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData

        Dim conn As New MySqlConnection(str)
        Dim supplier = "", collection_ref = "", generated_by = "", voucher_date = New Date,
            receipts() As String = {}, store_name = "", store_info = "", payment_type = String.Empty,
            contact_person = String.Empty, voucher_status = String.Empty

        Try

            conn.Open()

            'GET VOUCHER DETAILS
            Dim query = "SELECT payment_type, ims_suppliers.supplier, ims_suppliers.contact_person, receipts, collection_ref, creation_date, receipts, voucher_status,
                        ims_users.first_name, (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info
                        FROM ims_payment_vouchers
                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier
                        INNER JOIN ims_users ON ims_users.usr_id=ims_payment_vouchers.generated_by
                        WHERE payment_id=@payment_id"
            Using cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@payment_id", id)
                Using rdr_details = cmd.ExecuteReader
                    While rdr_details.Read
                        contact_person = rdr_details("contact_person")
                        payment_type = rdr_details("payment_type")
                        voucher_date = rdr_details("creation_date")
                        collection_ref = rdr_details("collection_ref")
                        supplier = rdr_details("supplier")
                        collection_ref = rdr_details("collection_ref")
                        generated_by = rdr_details("first_name")
                        store_info = rdr_details("store_info")
                        store_name = rdr_details("store_name")
                        voucher_status = rdr_details("voucher_status")

                        receipts = rdr_details("receipts").ToString.Split(",")

                    End While
                End Using
            End Using


            'GET RECEIPTS DATA
            Using get_receipt = New MySqlCommand("SELECT CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, receipt_type, receipt_ref, received_date, ims_purchase.terms,
                                    payment_cheque, payment_dates, ims_delivery_receipts.amount, ims_generated_cheques.bank,
                                    DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date FROM ims_delivery_receipts 
                                    INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                    LEFT JOIN ims_generated_cheques ON ims_generated_cheques.id=ims_delivery_receipts.cheque_id 
                                    WHERE payment_ref=@ref ORDER BY receipt_ref ASC", conn)
                get_receipt.Parameters.AddWithValue("@ref", id)
                Using reader = get_receipt.ExecuteReader
                    While reader.Read
                        table.payment_voucher.Rows.Add(reader("purchase_id"),
                                                       reader("received_date"),
                                                       reader("terms"),
                                                       reader("payment_cheque"),
                                                       reader("payment_dates"),
                                                       reader("amount"),
                                                       reader("bank"),
                                                       reader("due_date"),
                                                       reader("receipt_type"),
                                                       reader("receipt_ref"))
                    End While
                End Using
            End Using

            Dim cheque_no As String = "0"


            Select Case payment_type
                Case "cheque"
                    'Get Cheque Total No. and Details
                    Using get_cheque = New MySqlCommand("SELECT bank, cheque_no, cheque_date, ims_generated_cheques.amount FROM ims_generated_cheques 
                            INNER JOIN ims_delivery_receipts ON ims_delivery_receipts.payment_cheque=cheque_no
                            WHERE payment_ref=@ref GROUP BY cheque_no, bank, ims_generated_cheques.amount, cheque_date", conn)
                        get_cheque.Parameters.AddWithValue("@ref", id)
                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("bank"), rdr_cheque("cheque_date"), rdr_cheque("cheque_no"), rdr_cheque("amount"))
                                cheque_no = rdr_cheque("cheque_no")
                            End While
                        End Using
                    End Using

                Case "cash"
                    'Get Cash Details
                    Using get_cheque = New MySqlCommand("SELECT ims_generated_cash.id, ims_generated_cash.payment_date, ims_generated_cash.amount 
                                            FROM ims_delivery_receipts  
                                            INNER JOIN ims_generated_cash ON ims_generated_cash.id=cash_id
                                            WHERE payable_id=@pid GROUP BY id", conn)
                        get_cheque.Parameters.AddWithValue("@pid", receipts(0))
                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("id"), rdr_cheque("payment_date"), Nothing, rdr_cheque("amount"))
                            End While
                        End Using
                    End Using

            End Select


            'GET PURCHASE RETURNS
            Using get_returns = New MySqlCommand("SELECT po_return_id, ims_suppliers.supplier, total_cost FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id
                                WHERE cheque_no=" & cheque_no, conn)
                Using reader = get_returns.ExecuteReader
                    While reader.Read
                        table.purchase_returns.Rows.Add(reader("po_return_id"), reader("supplier"), reader("total_cost"))
                    End While
                End Using
            End Using

            report.Parameters("store_name").Value = store_name
            report.Parameters("store_info").Value = store_info
            report.Parameters("voucher_id").Value = "PV" & id.ToString.PadLeft(5, "0"c)
            report.Parameters("voucher_date").Value = voucher_date
            report.Parameters("supplier").Value = supplier
            report.Parameters("contact_person").Value = contact_person
            report.Parameters("collection_ref").Value = collection_ref
            report.Parameters("generated_by").Value = generated_by
            report.Parameters("payment_type").Value = payment_type
            If voucher_status.Equals("VOIDED") Then
                report.Watermark.Text = "VOIDED"
            End If
            report.RequestParameters = False

            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
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
            {"", "One", "Two", "Three",
              "Four", "Five",
              "Six", "Seven", "Eight", "Nine"}
                Dim Teens() As String = {"",
            "Eleven", "Twelve", "Thirteen",
              "Fourteen", "Fifteen",
              "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
                Dim Tens() As String = {"", "Ten",
            "Twenty", "Thirty",
              "Forty", "Fifty", "Sixty",
              "Seventy", "Eighty", "Ninety"}
                Dim HMBT() As String = {"", "",
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
                Dim id As Integer = grid_payments_view.GetFocusedRowCellValue(col_id).ToString.Replace("PV", "")
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

                load_payment_vouchers()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub
End Class