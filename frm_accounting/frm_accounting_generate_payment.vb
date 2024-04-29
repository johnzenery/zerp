Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Globalization

Public Class frm_accounting_generate_payment

    '--- ONLOAD ---
    Private Sub frm_accounting_payment_cheques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_banks()
        load_suppliers()
        load_AutoSuggest()
        CreateDataTable()
    End Sub





    '--- FUNCTIONS ----

    'Load Banks List
    Private Sub load_banks()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("SELECT bank_acc_name FROM ims_banks WHERE is_enabled=1", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_banks.Properties.Items.Add(rdr("bank_acc_name"))
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Create DataTable
    Private Sub CreateDataTable()
        Dim dt = New DataTable
        dt.Columns.Add("cheque_no", GetType(String))
        dt.Columns.Add("cheque_date")
        dt.Columns.Add("cheque_amount")
        dt.Columns.Add("bank", GetType(String))
        dt.Columns.Add("acc_no", GetType(String))
        dt.Columns.Add("acc_name", GetType(String))
        dt.Columns.Add("payee", GetType(String))
        dt.Columns.Add("is_crossed_check", GetType(Boolean))
        grid_cheque.DataSource = dt
    End Sub

    'Load Supplier List
    Private Sub load_suppliers()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", connection)
                Dim rdr = cmd.ExecuteReader

                While rdr.Read
                    cbb_suppliers.Properties.Items.Add(rdr("supplier"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load Auto Suggest
    Private Sub load_AutoSuggest()
        Try

            Dim Collection = New AutoCompleteStringCollection

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Using cmd = New MySqlCommand("SELECT payee FROM `ims_generated_cheques` GROUP BY payee", connection)
                        Dim rdr As MySqlDataReader = cmd.ExecuteReader

                        While rdr.Read
                            Collection.Add(rdr("payee"))
                        End While
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

            txt_payee.Properties.AdvancedModeOptions.AutoCompleteSource = AutoCompleteSource.CustomSource
            txt_payee.Properties.AdvancedModeOptions.AutoCompleteMode = AutoCompleteMode.SuggestAppend
            txt_payee.Properties.AdvancedModeOptions.AutoCompleteCustomSource = Collection

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Get Count of Payment Vouchers
    Private Function get_count(connection As MySqlConnection)

        Dim get_cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_payment_vouchers", connection)
        Return get_cmd.ExecuteScalar

    End Function

    'Print Cheque
    Private Sub PrintCheque(id As Integer, connection As MySqlConnection)

        Dim report = New doc_cheque()

        Dim cmd = New MySqlCommand("SELECT amount, payee, cheque_date, is_crossed_check 
                        FROM ims_generated_cheques 
                        WHERE p_voucher_id=" & id, connection)

        Using rdr As MySqlDataReader = cmd.ExecuteReader
            While rdr.Read
                Dim custom_report = New doc_cheque()
                custom_report.Parameters("payee").Value = rdr("payee")
                custom_report.Parameters("cheque_date").Value = rdr("cheque_date")
                custom_report.Parameters("amount").Value = rdr("amount")
                custom_report.Parameters("AmountWords").Value = AmountInWords(rdr("amount"))
                custom_report.Parameters("ac_payee").Value = rdr("is_crossed_check")
                custom_report.CreateDocument()
                report.ModifyDocument(Sub(x) x.AddPages(custom_report.Pages))
            End While
        End Using


        report.RequestParameters = False
        report.ShowRibbonPreviewDialog()

    End Sub

    'Print Voucher
    Public Sub print_voucher(id As Integer, connection As MySqlConnection)
        Dim report = New doc_payment_voucher()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData

        Dim supplier = String.Empty, collection_ref = String.Empty, generated_by = String.Empty, voucher_date = New Date, receipts() As String = {}, store_name = String.Empty, store_info = String.Empty, payment_type = String.Empty, contact_person = String.Empty

        Try
            'GET VOUCHER DETAILS
            Dim query = "SELECT payment_type, receipts, creation_date, collection_ref, ims_users.first_name AS generated_by, ims_suppliers.supplier, ims_suppliers.contact_person,
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info 
                        FROM ims_payment_vouchers
                        INNER JOIN ims_suppliers ON ims_suppliers.id=ims_payment_vouchers.supplier
                        INNER JOIN ims_users ON ims_users.usr_id=ims_payment_vouchers.generated_by
                        WHERE payment_id=@payment_id"

            Using cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@payment_id", id)
                Using rdr_details = cmd.ExecuteReader
                    While rdr_details.Read
                        store_name = rdr_details("store_name")
                        contact_person = rdr_details("contact_person")
                        payment_type = rdr_details("payment_type")
                        voucher_date = rdr_details("creation_date")
                        collection_ref = rdr_details("collection_ref")
                        supplier = rdr_details("supplier")
                        collection_ref = rdr_details("collection_ref")
                        generated_by = rdr_details("generated_by")
                        store_info = rdr_details("store_info")

                        receipts = rdr_details("receipts").ToString.Split(",")

                    End While
                End Using
            End Using


            'GET RECEIPTS
            Using get_receipt = New MySqlCommand("SELECT CONCAT('PO', LPAD(ims_delivery_receipts.purchase_id, 5, 0)) AS purchase_id, IF(ISNULL(si_no), 'DR', 'SI-VAT') receipt_type, IF(ISNULL(si_no), dr_no, si_no) receipt_ref, received_date, ims_purchase.terms,
                                    ims_delivery_receipts.amount, 
                                    DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date 
                                    FROM ims_delivery_receipts 
                                    LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                    LEFT JOIN ims_payment_vouchers ON ims_payment_vouchers.payment_id=ims_delivery_receipts.p_voucher_id
                                    WHERE p_voucher_id=@p_voucher_id
                                    ORDER BY receipt_ref ASC", connection)

                get_receipt.Parameters.AddWithValue("@p_voucher_id", id)
                Using reader = get_receipt.ExecuteReader
                    While reader.Read
                        table.payment_voucher.Rows.Add(reader("purchase_id"),
                                                   reader("received_date"),
                                                   reader("terms"),
                                                   reader("amount"),
                                                   reader("due_date"),
                                                   reader("receipt_type"),
                                                   reader("receipt_ref"))
                    End While
                End Using
            End Using

            Select Case payment_type

                Case "cheque"
                    'Get Cheque Total No. and Details
                    Using get_cheque = New MySqlCommand("SELECT bank, cheque_no, cheque_date, amount, payor_acc_no
                                            FROM ims_generated_cheques
                                            WHERE p_voucher_id=" & id, connection)

                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.payment_voucher_cheque.Rows.Add(rdr_cheque("bank"), rdr_cheque("payor_acc_no"), rdr_cheque("cheque_no"), rdr_cheque("cheque_date"), rdr_cheque("amount"))
                            End While
                        End Using
                    End Using

                Case "cash"
                    'Get Cash Details
                    Using get_cheque = New MySqlCommand("SELECT id, payment_date, amount 
                                            FROM ims_generated_cash  
                                            WHERE p_voucher_id=" & id, connection)

                        Using rdr_cheque = get_cheque.ExecuteReader
                            While rdr_cheque.Read
                                table.collection_receipt_cheque.Rows.Add(rdr_cheque("id"), rdr_cheque("payment_date"), Nothing, rdr_cheque("amount"))
                            End While
                        End Using
                    End Using

            End Select


            'GET PURCHASE RETURNS
            Using get_returns = New MySqlCommand("SELECT po_return_id, ims_suppliers.supplier, total_cost 
                                FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id
                                WHERE p_voucher_id=" & id, connection)
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
            report.Parameters("collection_ref").Value = collection_ref
            report.Parameters("generated_by").Value = generated_by
            report.Parameters("payment_type").Value = payment_type
            report.Parameters("contact_person").Value = contact_person
            report.RequestParameters = False


            report.DataSource = table
            report.ShowRibbonPreviewDialog()

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

    'Generate Cheque Payment
    Private Sub GenerateCheque()

        Dim receipts As String = String.Empty
        Dim generated_cheques = String.Empty
        Dim Selected_receipts = grid_receipts_view.GetSelectedRows

        'IF NO RECEIPTS
        If Selected_receipts.Length = 0 Then
            MsgBox("Select Receipts First!", vbCritical, "Required")
            Exit Sub
        End If

        'IF NO CHEQUES
        If Not grid_cheque_view.RowCount > 0 Then
            MsgBox("No Cheques to be generated!", vbCritical, "Required")
            Exit Sub
        End If

        'Check Totals
        Dim total_amount_due As Decimal = 0.00
        For i = 0 To grid_cheque_view.RowCount - 1
            total_amount_due += grid_cheque_view.GetRowCellValue(i, col_cheque_amount)
        Next
        If Not total_amount_due = CDec(txt_total_view.Text) Then
            MsgBox("Total of cheques amount is NOT equal to Total Amount Due!" & total_amount_due, vbCritical, "Mismatch")
            Exit Sub
        End If

        Dim ans = MsgBox("Press 'YES' to proceed.", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            'Get ID of receipts
            For i = 0 To Selected_receipts.Length - 1
                'If last
                If i = Selected_receipts.Length - 1 Then
                    receipts += grid_receipts_view.GetRowCellValue(Selected_receipts(i), col_id).ToString
                    Continue For
                End If
                receipts += grid_receipts_view.GetRowCellValue(Selected_receipts(i), col_id) & ", "
            Next


            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim voucher_id As Integer = 0
                    Dim transc = connection.BeginTransaction

                    Try
                        'GENERATE NEW VOUCHER | //MERGE
                        Using cmd = New MySqlCommand("INSERT INTO ims_payment_vouchers (payment_type, receipts, creation_date, collection_ref, supplier, generated_by, voucher_status, voucher_amount)
                                    VALUES (@payment_type, @receipts, CURRENT_TIMESTAMP, @collection_ref, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @generated_by, @voucher_status, @voucher_amount)", connection, transc)
                            cmd.Parameters.AddWithValue("receipts", receipts)
                            cmd.Parameters.AddWithValue("payment_type", "cheque")
                            cmd.Parameters.AddWithValue("collection_ref", txt_collection_ref.Text.Trim)
                            cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                            cmd.Parameters.AddWithValue("generated_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("voucher_status", "Normal")
                            cmd.Parameters.AddWithValue("voucher_amount", CDec(txt_total_view.Text.Trim))
                            cmd.ExecuteNonQuery()
                            voucher_id = cmd.LastInsertedId
                        End Using

                        'GET LAST VOUCHER ID
                        'voucher_id = get_count(connection)

                        'GENERATE CHEQUE
                        Using cmd = New MySqlCommand("INSERT INTO ims_generated_cheques (cheque_no, cheque_date, bank, payor_acc_no, payee, acc_no, acc_name, amount, supplier, status, is_crossed_check, p_voucher_id)
                                    VALUES (@cheque_no, @cheque_date, @bank, @payor_acc_no, @payee, @acc_no, @acc_name, @amount, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @status, @x_check, @p_voucher_id)", connection, transc)
                            cmd.Parameters.AddWithValue("cheque_no", 0)
                            cmd.Parameters.AddWithValue("cheque_date", Date.ParseExact("01/01/1990", "MM/dd/yyyy", CultureInfo.InvariantCulture))
                            cmd.Parameters.AddWithValue("bank", String.Empty)
                            cmd.Parameters.AddWithValue("payee", String.Empty)
                            cmd.Parameters.AddWithValue("acc_no", String.Empty)
                            cmd.Parameters.AddWithValue("acc_name", String.Empty)
                            cmd.Parameters.AddWithValue("amount", 0.00)
                            cmd.Parameters.AddWithValue("x_check", cb_crossed_check.Checked)

                            cmd.Parameters.AddWithValue("payor_acc_no", txt_payor_acc_no.Text.Trim)
                            cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                            cmd.Parameters.AddWithValue("p_voucher_id", voucher_id)
                            cmd.Parameters.AddWithValue("status", "OUTSTANDING")
                            cmd.Prepare()

                            For i = 0 To grid_cheque_view.RowCount - 1
                                cmd.Parameters(0).Value = grid_cheque_view.GetRowCellValue(i, col_cheque_no)
                                cmd.Parameters(1).Value = Date.ParseExact(grid_cheque_view.GetRowCellValue(i, col_cheque_date), "MM/dd/yyyy", CultureInfo.InvariantCulture)
                                cmd.Parameters(2).Value = grid_cheque_view.GetRowCellValue(i, col_bank)
                                cmd.Parameters(3).Value = grid_cheque_view.GetRowCellValue(i, col_payee)
                                cmd.Parameters(4).Value = grid_cheque_view.GetRowCellValue(i, col_acc_no)
                                cmd.Parameters(5).Value = grid_cheque_view.GetRowCellValue(i, col_acc_name)
                                cmd.Parameters(6).Value = CDec(grid_cheque_view.GetRowCellValue(i, col_cheque_amount))
                                cmd.Parameters(7).Value = cb_crossed_check.Checked
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        'GET CHEQUE COUNT
                        'Dim cheque_id = get_payment_id(conn, "cheque")

                        'UPDATE RECEIPTS
                        Using update_cmd = New MySqlCommand("UPDATE ims_delivery_receipts 
                                            SET status='PAID', p_voucher_id=@p_voucher_id
                                            WHERE payable_id=@payable_id", connection, transc)
                            update_cmd.Parameters.AddWithValue("@payable_id", 0)
                            update_cmd.Parameters.AddWithValue("@p_voucher_id", voucher_id)
                            update_cmd.Prepare()

                            For i = 0 To Selected_receipts.Length - 1
                                update_cmd.Parameters(0).Value = grid_receipts_view.GetRowCellValue(Selected_receipts(i), col_id)
                                update_cmd.ExecuteNonQuery()
                            Next

                        End Using

                        'UPDATE PURCHASE ORDER RETURNS
                        Using update_returns = New MySqlCommand("UPDATE ims_purchase_returns 
                                                SET is_applied='1', status='Applied', p_voucher_id=@p_voucher_id 
                                                WHERE po_return_id=@id; 
                                                UPDATE rs_returns_deliveries SET status='Credited' 
                                                WHERE credit_memo_id=@id", connection, transc)
                            update_returns.Parameters.AddWithValue("@id", 0)
                            update_returns.Parameters.AddWithValue("@p_voucher_id", voucher_id)
                            update_returns.Prepare()

                            For i = 0 To grid_returns_view.GetSelectedRows.Length - 1
                                update_returns.Parameters(0).Value = grid_returns_view.GetRowCellValue(grid_returns_view.GetSelectedRows(i), col_rid)
                                update_returns.ExecuteNonQuery()
                            Next

                        End Using

                        transc.Commit()

                    Catch ex As Exception
                        transc.Rollback()
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                    'PRINT CHEQUE
                    If MsgBox("Print cheques?", vbInformation + vbYesNo, "Print") = vbYes Then
                        PrintCheque(voucher_id, connection)
                    End If

                    'PRINT VOUCHER
                    If MsgBox("Print Payment Voucher?", vbInformation + vbYesNo, "Print") = vbYes Then
                        print_voucher(voucher_id, connection)
                    End If

                    'CLEAR FIELDS
                    txt_cheque_no.Text = String.Empty
                    txt_cheque_date.Text = String.Empty
                    cbb_banks.Text = String.Empty
                    txt_payee.Text = String.Empty
                    txt_acc_no.Text = String.Empty
                    txt_acc_name.Text = String.Empty
                    cbb_suppliers.Text = String.Empty
                    txt_total_view.Text = String.Empty
                    txt_collection_ref.Text = String.Empty
                    txt_amount.Text = 0.00
                    lbl_receipt_no.Text = String.Empty
                    grid_receipts.DataSource = Nothing
                    grid_returns.DataSource = Nothing
                    Dim dt_cheques = TryCast(grid_cheque.DataSource, DataTable)
                    dt_cheques.Rows.Clear()
                    grid_cheque.DataSource = dt_cheques

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'Generate Cash Payment
    Private Sub GenerateCash()

        Dim receipts As String = String.Empty
        Dim Selected_receipts = grid_receipts_view.GetSelectedRows

        If Selected_receipts.Length = 0 Then
            MsgBox("Select Receipts First!", vbCritical, "Required")
            Exit Sub
        End If

        If MsgBox("Generate Cash Payment?" & vbNewLine & "Press 'YES' to proceed.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            'Get ID of receipts
            For i = 0 To Selected_receipts.Length - 1
                'If last
                If i = Selected_receipts.Length - 1 Then
                    receipts += grid_receipts_view.GetRowCellValue(Selected_receipts(i), col_id).ToString
                    Continue For
                End If
                receipts += grid_receipts_view.GetRowCellValue(Selected_receipts(i), col_id) & ", "
            Next


            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'GENERATE NEW VOUCHER | //MERGE
                    Using cmd = New MySqlCommand("INSERT INTO ims_payment_vouchers (payment_type, receipts, creation_date, collection_ref, supplier, generated_by, voucher_status, voucher_amount)
                                VALUES (@payment_type, @receipts, CURRENT_TIMESTAMP, @collection_ref, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @generated_by, @voucher_status, @voucher_amount)", connection)
                        cmd.Parameters.AddWithValue("receipts", receipts)
                        cmd.Parameters.AddWithValue("payment_type", "cash")
                        cmd.Parameters.AddWithValue("collection_ref", txt_collection_ref.Text.Trim)
                        cmd.Parameters.AddWithValue("supplier", cbb_suppliers.Text.Trim)
                        cmd.Parameters.AddWithValue("generated_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("voucher_status", "Normal")
                        cmd.Parameters.AddWithValue("voucher_amount", CDec(txt_total_view.Text.Trim))
                        cmd.ExecuteNonQuery()
                    End Using

                    'GET LAST VOUCHER ID
                    Dim voucher_id = get_count(connection)

                    'GENERATE CASH
                    Using cmd = New MySqlCommand("INSERT INTO ims_generated_cash (payee, payment_date, amount, p_voucher_id)
                                VALUES (@payee, NOW(), @amount, @p_voucher_id)", connection)
                        cmd.Parameters.AddWithValue("payee", cbb_suppliers.Text.Trim)
                        cmd.Parameters.AddWithValue("amount", CDec(txt_total_view.Text.Trim))
                        cmd.Parameters.AddWithValue("p_voucher_id", voucher_id)
                        cmd.ExecuteNonQuery()
                    End Using

                    'GET CHEQUE COUNT
                    'Dim payment_id = get_payment_id(conn, "cash")

                    'UPDATE RECEIPTS
                    Using update_cmd = New MySqlCommand("UPDATE ims_delivery_receipts SET 
                                                        status='PAID',
                                                        p_voucher_id=@p_voucher_id
                                                     WHERE payable_id=@payable_id", connection)
                        update_cmd.Parameters.AddWithValue("@payable_id", 0)
                        update_cmd.Parameters.AddWithValue("@p_voucher_id", voucher_id)
                        update_cmd.Prepare()

                        For i = 0 To Selected_receipts.Length - 1
                            update_cmd.Parameters(0).Value = grid_receipts_view.GetRowCellValue(Selected_receipts(i), col_id)
                            update_cmd.ExecuteNonQuery()
                        Next
                    End Using

                    'UPDATE PURCHASE ORDER RETURNS
                    Using update_returns = New MySqlCommand("UPDATE ims_purchase_returns 
                                            SET is_applied='1', status='Applied', p_voucher_id=@p_voucher_id 
                                            WHERE po_return_id=@id", connection)
                        update_returns.Parameters.AddWithValue("@id", 0)
                        update_returns.Parameters.AddWithValue("@p_voucher_id", voucher_id)
                        update_returns.Prepare()

                        For i = 0 To grid_returns_view.GetSelectedRows.Length - 1
                            update_returns.Parameters(0).Value = grid_returns_view.GetRowCellValue(grid_returns_view.GetSelectedRows(i), col_rid)
                            update_returns.ExecuteNonQuery()
                        Next
                    End Using

                    'PRINT VOUCHER
                    If MsgBox("Print Payment Voucher?", vbInformation + vbYesNo, "Print") = vbYes Then
                        print_voucher(voucher_id, connection)
                    End If

                    MsgBox("Successfully Generated!", vbInformation, "Information")

                    'CLEAR FIELDS
                    txt_cheque_no.Text = String.Empty
                    txt_cheque_date.Text = String.Empty
                    cbb_banks.Text = String.Empty
                    txt_payee.Text = String.Empty
                    txt_acc_no.Text = String.Empty
                    txt_acc_name.Text = String.Empty
                    cbb_suppliers.Text = String.Empty
                    txt_total_view.Text = String.Empty
                    lbl_receipt_no.Text = String.Empty
                    txt_collection_ref.Text = String.Empty
                    grid_receipts.DataSource = Nothing
                    grid_returns.DataSource = Nothing
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub





    '--- CONTROLS ----

    'cbb_suppliers SELECTION CHANGED
    Private Sub cbb_suppliers_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_suppliers.Properties.SelectedValueChanged

        If Not String.IsNullOrWhiteSpace(cbb_suppliers.Text) Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'GET Payables
                    Using cmd = New MySqlCommand("SELECT 
                                payable_id, 
                                receipt_type, 
                                dr_no, dr_date, 
                                si_no, si_date, 
                                amount, 
                                IF(ims_purchase.is_withholding_tax_applied=1, ((tbl_deliveries.total_cost / 1.12) * 0.01), 0.00) ewt,
                                received_date, 
                                CONCAT('PO',LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id,
                                ims_purchase.terms, DATE_ADD(received_date, INTERVAL ims_purchase.terms DAY) as due_date
                                FROM `ims_delivery_receipts` 
                                INNER JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                                LEFT JOIN (
                                SELECT 
                                        receipt_id, 
                                        SUM(qty * ims_deliveries.cost) as total_cost 
                                    FROM ims_deliveries
                                    GROUP BY receipt_id
                                ) as tbl_deliveries ON tbl_deliveries.receipt_id = ims_delivery_receipts.payable_id
                                WHERE supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier AND ims_delivery_receipts.status='UNPAID') 
                                        AND ims_delivery_receipts.is_deleted=0", connection)
                        cmd.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
                        cmd.ExecuteNonQuery()

                        Dim dt = New DataTable
                        Dim da = New MySqlDataAdapter(cmd)
                        da.Fill(dt)

                        grid_receipts.DataSource = dt
                    End Using

                    'GET BANK DETAILS
                    Using cmd_get = New MySqlCommand("SELECT acc_name, acc_no FROM ims_suppliers WHERE supplier=@supname", connection)
                        cmd_get.Parameters.AddWithValue("@supname", cbb_suppliers.Text)
                        Using rdr As MySqlDataReader = cmd_get.ExecuteReader
                            While rdr.Read
                                txt_payee.Text = cbb_suppliers.Text
                                txt_acc_name.Text = If(Not IsDBNull(rdr("acc_name")), rdr("acc_name"), String.Empty)
                                txt_acc_no.Text = If(Not IsDBNull(rdr("acc_no")), rdr("acc_no"), String.Empty)
                            End While
                        End Using
                    End Using

                    'GET PURCHASE RETURNS
                    Using cmd_returns = New MySqlCommand("SELECT po_return_id, supplier,
                                total_cost, created_at, status FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id 
                                WHERE is_deleted=0 AND supplier=@supplier AND is_applied='0'
                                ORDER BY po_return_id DESC", connection)
                        cmd_returns.Parameters.AddWithValue("@supplier", cbb_suppliers.Text)
                        cmd_returns.ExecuteNonQuery()
                        Dim dt = New DataTable
                        Dim da = New MySqlDataAdapter(cmd_returns)
                        da.Fill(dt)
                        grid_returns.DataSource = dt
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'grid_receipts_view_SelectionChanged
    Dim first_is_ewt = False
    Dim error_on_selection = False
    Private Sub grid_receipts_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_receipts_view.SelectionChanged

        Dim SelectedRows = grid_receipts_view.GetSelectedRows
        lbl_receipt_no.Text = SelectedRows.Count

        Dim total As Decimal = 0.00
        Dim total_sum As Decimal = 0.00
        Dim is_month_not_equal = False

        Dim is_withholding_tax_applied = False

        If Not SelectedRows.Length = 0 Then


            With grid_receipts_view
                For i = 0 To SelectedRows.Length - 1

                    first_is_ewt = IIf(.GetRowCellValue(SelectedRows(0), col_ewt) > 0.00, True, False)

                    If .GetRowCellValue(SelectedRows(i), col_ewt) > 0.00 Then
                        is_withholding_tax_applied = True
                        If Not first_is_ewt = is_withholding_tax_applied Then
                            MsgBox("One of the orders is EWT applied!", vbCritical, "Forbidden")
                            error_on_selection = True
                            Exit Sub
                        End If
                        error_on_selection = False
                    End If

                    'Validation: Current Month != Due Date Month
                    If Not Month(.GetRowCellValue(SelectedRows(0), col_due_date)) = Month(.GetRowCellValue(SelectedRows(i), col_due_date)) Then
                        is_month_not_equal = True
                    End If

                    Dim due_date As Date = .GetRowCellValue(SelectedRows(i), col_due_date)
                    Dim amount As Decimal = .GetRowCellValue(SelectedRows(i), col_amount)

                    total_sum += CInt(due_date.ToString("dd")) * amount


                    total += .GetRowCellValue(SelectedRows(i), col_amount)
                Next

                'If is_month_not_equal = True Then
                '    MsgBox("Warning! Month of due should Equal.", vbExclamation, "Not Equal")
                'End If

                'If is_withholding_tax_applied = True Then
                '    MsgBox("Withholding Tax applied!", vbExclamation, "Forbidden")
                'End If

                txt_total_view.Text = FormatCurrency(total)
                Dim product_sum = total_sum / total

                Dim ddate As Date = .GetFocusedRowCellValue(col_due_date)
                txt_cheque_date.Text = ddate.ToString("MM") & "/" & Math.Round(product_sum).ToString.PadLeft(2, "0"c) & "/" & ddate.ToString("yyyy")

            End With

        End If

        'GET TOTAL RETURNS
        Dim total_returns As Decimal = 0.00
        Dim returns_row = grid_returns_view.GetSelectedRows
        For i = 0 To returns_row.Length - 1
            total_returns += grid_returns_view.GetRowCellValue(returns_row(i), col_total_cost)
        Next

        txt_total_view.Text = FormatCurrency(total - total_returns)

    End Sub

    'btn_generate
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click

        If error_on_selection = True Then
            MsgBox("EWT applied receipt should NOT mixed with none applied.", vbCritical, "Forbidden")
            Exit Sub
        End If

        If rb_cheque.Checked = True Then
            GenerateCheque()
        ElseIf rb_cash.Checked = True Then
            GenerateCash()
        End If

    End Sub

    'DateEdit
    Private Sub DateEdit1_Closed(sender As Object, e As DevExpress.XtraEditors.Controls.ClosedEventArgs) Handles DateEdit1.Closed
        txt_cheque_date.Text = Date.ParseExact(DateEdit1.EditValue, "dd/MM/yyyy", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy")
    End Sub

    'Purchase Returns Selection
    Private Sub grid_returns_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_returns_view.SelectionChanged

        Dim total_payables As Decimal = 0.00
        Dim total_returns As Decimal = 0.00

        'GET TOTAL PAYABLES
        Dim payables_rows = grid_receipts_view.GetSelectedRows
        For i = 0 To payables_rows.Length - 1
            total_payables += grid_receipts_view.GetRowCellValue(payables_rows(i), col_amount)
        Next
        'GET TOTAL RETURNS
        Dim returns_row = grid_returns_view.GetSelectedRows
        For i = 0 To returns_row.Length - 1
            total_returns += grid_returns_view.GetRowCellValue(returns_row(i), col_total_cost)
        Next

        'DISPLAY
        txt_total_view.Text = FormatCurrency(total_payables - total_returns, 2)

    End Sub

    Private Sub rb_cash_Click(sender As Object, e As EventArgs) Handles rb_cash.Click
        panel_cheque.Enabled = False
        Dim dt = TryCast(grid_cheque.DataSource, DataTable)
        dt.Rows.Clear()
        cbb_banks.SelectedIndex = -1
        cbb_banks.Enabled = False
        txt_payor_acc_no.Enabled = False
        txt_cheque_no.Enabled = False
        txt_cheque_date.Enabled = False
        grid_cheque.DataSource = dt
        grid_cheque.Enabled = False
        DateEdit1.Enabled = False

        txt_payor_acc_no.Text = String.Empty
        txt_cheque_no.Text = String.Empty
        txt_cheque_date.Text = String.Empty
    End Sub

    Private Sub rb_cheque_Click(sender As Object, e As EventArgs) Handles rb_cheque.Click
        cbb_banks.Enabled = True
        txt_payor_acc_no.Enabled = True
        grid_cheque.Enabled = True
        panel_cheque.Enabled = True
        txt_cheque_no.Enabled = True
        txt_cheque_date.Enabled = True
        DateEdit1.Enabled = True
    End Sub

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim cheque_no = txt_cheque_no.Text.Trim
        Dim cheque_date = txt_cheque_date.Text.Trim
        Dim bank = cbb_banks.Text.Trim
        Dim payee = txt_payee.Text.Trim
        Dim acc_no = txt_acc_no.Text.Trim
        Dim acc_name = txt_acc_name.Text.Trim
        Dim amount = txt_amount.Text.Trim
        Dim is_crossed_cheque = cb_crossed_check.Checked

        'Validation
        If String.IsNullOrWhiteSpace(txt_cheque_no.Text) Or String.IsNullOrWhiteSpace(txt_cheque_date.Text) _
            Or String.IsNullOrWhiteSpace(cbb_banks.Text) Or Not CDec(txt_amount.Text) > 0 Then
            MsgBox("Fill up all required fields!", vbCritical, "Required")
            Exit Sub
        End If



        Dim dataSource As DataTable = TryCast(grid_cheque.DataSource, DataTable)
        dataSource.Rows.Add(cheque_no, cheque_date, amount, bank, acc_no, acc_name, payee, is_crossed_cheque)
        grid_cheque.DataSource = dataSource



    End Sub

    Private Sub btn_delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete.ButtonClick
        grid_cheque_view.DeleteRow(grid_cheque_view.FocusedRowHandle)
    End Sub

    Private Sub DateEdit1_Properties_DisableCalendarDate(sender As Object, e As DevExpress.XtraEditors.Calendar.DisableCalendarDateEventArgs) Handles DateEdit1.Properties.DisableCalendarDate
        If e.Date.DayOfWeek = 0 Or e.Date.DayOfWeek = 6 Or e.Date.Date < Date.Today Then
            e.IsDisabled = True
        End If
    End Sub

    Private Sub cbb_banks_EditValueChanged(sender As Object, e As EventArgs) Handles cbb_banks.EditValueChanged
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT bank_acc_no FROM ims_banks WHERE bank_acc_name=@bank_name", conn)
                    cmd.Parameters.AddWithValue("@bank_name", cbb_banks.EditValue)
                    Using rdr = cmd.ExecuteReader
                        If rdr.HasRows Then
                            rdr.Read()
                            txt_payor_acc_no.Text = rdr("bank_acc_no")
                        Else
                            txt_payor_acc_no.Text = String.Empty
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class