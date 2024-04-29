Imports DevExpress.XtraGauges.Core.Base
Imports DevExpress.XtraReports.UI
Imports MySqlConnector


Public Class frm_accounting_payment_cheques


    '--- ONLOAD ----
    Private Sub frm_accounting_payment_cheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_generated_cheques()
    End Sub






    '--- FUNCTIONS ----

    'Load Generated Cheques
    Private Sub load_generated_cheques()

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()
                Dim cmd = New MySqlCommand("SELECT LPAD(ims_generated_cheques.id, 5, 0) as id, cheque_no, cheque_date, ims_generated_cheques.bank, payor_acc_no, clearing_date AS date_cleared, IFNULL(clearing_date2, cheque_date) AS clearing_date,
                                        payee, ims_generated_cheques.acc_no, ims_generated_cheques.acc_name, amount, ims_suppliers.supplier, status, CONCAT('PV', LPAD(p_voucher_id, 5, 0)) AS voucher_id
                                        FROM `ims_generated_cheques`
                                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_generated_cheques.supplier 
                                        ORDER BY ims_generated_cheques.id DESC", connect)
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
            MessageBox.Show("Error Encountered: " & ex.Message, "Convert Numbers To Words", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return "!#ERROR_ENCOUNTERED"
        End Try

        'Trap null values
        If IsNothing(wAmount) = True Then wAmount = String.Empty Else wAmount =
        IIf(InStr(wAmount.Trim.ToLower, "pesos"), wAmount.Trim, wAmount.Trim & " Pesos Only")

        'Display the result
        Return wAmount
    End Function




    '--- CONTROLS ----

    'Status Selection Change
    Private Sub grid_payments_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_payments_view.CellValueChanged
        If e.Column.Equals(col_status) Then

            If MsgBox("Press 'Yes' to confirm changes.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Try
                    Using connect = New MySqlConnection(str)
                        connect.Open()

                        Dim query As String = String.Empty

                        If Equals(e.Value, "OUTSTANDING") Then
                            query = "UPDATE ims_generated_cheques SET status='OUTSTANDING', clearing_date=NULL WHERE id=@id"
                        ElseIf Equals(e.Value, "CLEAR") Then
                            query = "UPDATE ims_generated_cheques SET status='CLEAR', clearing_date=NOW() WHERE id=@id"
                        End If

                        Dim cmd = New MySqlCommand(query, connect)
                        'cmd.Parameters.AddWithValue("@status", grid_payments_view.GetFocusedRowCellValue(col_status))
                        cmd.Parameters.AddWithValue("@id", grid_payments_view.GetFocusedRowCellValue(col_id))
                        If cmd.ExecuteNonQuery() > 0 Then
                            Select Case e.Value
                                Case "OUTSTANDING" : grid_payments_view.SetFocusedRowCellValue(col_date_cleared, Nothing)
                                Case "CLEAR" : grid_payments_view.SetFocusedRowCellValue(col_date_cleared, Date.Now)
                            End Select

                        End If

                        connect.Close()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If

        ElseIf e.Column.Equals(col_clearing_date) Then

            If MsgBox("Press 'Yes' to confirm changes.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Try
                    Using conn = New MySqlConnection(str)
                        conn.Open()
                        Using cmd = New MySqlCommand("UPDATE ims_generated_cheques SET clearing_date2=@clearing_date WHERE id=@id", conn)
                            cmd.Parameters.AddWithValue("@id", grid_payments_view.GetFocusedRowCellValue(col_id))
                            cmd.Parameters.AddWithValue("@clearing_date", grid_payments_view.GetFocusedRowCellValue(col_clearing_date))
                            cmd.ExecuteNonQuery()
                        End Using
                        conn.Close()
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If
        End If

    End Sub

    Private Sub RepositoryItemButtonEdit1_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_print.ButtonClick
        Dim report = New doc_cheque()
        Dim printTool = New ReportPrintTool(report)
        Dim id = grid_payments_view.GetFocusedRowCellValue(col_id)
        Dim amount As Decimal, dt As Date, payee As String = String.Empty, is_crossed_check As Boolean

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()
                Dim cmd = New MySqlCommand("SELECT amount, payee, cheque_date, is_crossed_check FROM ims_generated_cheques WHERE id=@id", connect)
                cmd.Parameters.AddWithValue("@id", id)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    payee = rdr("payee")
                    dt = rdr("cheque_date")
                    amount = rdr("amount")
                    is_crossed_check = rdr("is_crossed_check")
                End While

                report.Parameters("payee").Value = payee
                report.Parameters("cheque_date").Value = dt
                report.Parameters("amount").Value = amount
                report.Parameters("ac_payee").Value = is_crossed_check
                report.Parameters("AmountWords").Value = AmountInWords(amount)
                report.RequestParameters = False

                report.ShowRibbonPreviewDialog()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub grid_payments_view_ShowingEditor(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles grid_payments_view.ShowingEditor
        If grid_payments_view.GetFocusedRowCellValue(col_status).Equals("VOIDED") Then
            e.Cancel = True
        End If
    End Sub

    'BUTTON : EXPORT
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            Dim saveFileDialog = New SaveFileDialog With {.Filter = "Microsoft Excel (*.xlsx)|*.xlsx"}
            If saveFileDialog.ShowDialog = DialogResult.OK Then
                grid_payments_view.ExportToXlsx(saveFileDialog.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class