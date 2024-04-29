Imports DevExpress.Spreadsheet
Imports MySqlConnector
Imports Newtonsoft.Json
Imports System.Globalization
Imports System.Text.RegularExpressions

Public Class frm_sales_customers_new

    Public Property other_notes As String
    Public Property is_new_customer As Boolean = False

    '--- ONLOAD ----

    Private Sub frm_sales_customers_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Load Sales Agents Name
        LoadAgents()

        LoadBanksDetails()

        'RESTRICT DISABLE/ENABLE CUSTOMER FOR ADMIN AND ACCOUNTING 
        If frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 2 Or frm_main.lbl_user_role_id.Text = 12 Then
            btn_disable_customer.Enabled = True
            cbb_account_type.Enabled = True
        Else
            btn_disable_customer.Enabled = False
            cbb_account_type.Enabled = False
        End If

        If Not String.IsNullOrEmpty(lbl_customer_id.Text) And Not (frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 2 Or frm_main.lbl_user_role_id.Text = 12) Then
            txt_fname.Enabled = False
        End If

    End Sub



    '---- FUNCTIONS -----

    'New Customer
    Private Sub NewCustomer()

        If MsgBox("Pres 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    With CultureInfo.CurrentCulture.TextInfo

                        Dim search_cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_customers WHERE first_name=@customer", connection)
                        search_cmd.Parameters.AddWithValue("@customer", .ToTitleCase(txt_fname.Text.Trim))
                        Dim rdr As MySqlDataReader = search_cmd.ExecuteReader()

                        While rdr.Read()
                            If CInt(rdr("COUNT(*)")) > 0 Then
                                MsgBox("Company Name Already Exist! Try different one.", vbCritical, "Error")
                                Exit Sub
                            End If
                        End While
                        rdr.Close()

                        Dim preferred_shipping = String.Empty
                        Select Case cbb_shipping.SelectedIndex
                            Case 0 : preferred_shipping = "Pickup"
                            Case 1 : preferred_shipping = "Deliver"
                        End Select

                        'Get Data in Spreadsheet
                        Dim ws = sheet_customer.ActiveWorksheet
                        Dim usedRange = ws.GetUsedRange()

                        Dim data As String = String.Empty

                        For i = 0 To usedRange.RowCount - 1
                            Dim is_contain = False
                            For j = 0 To usedRange.ColumnCount - 1
                                'If String.IsNullOrWhiteSpace(usedRange.Item(i, j).Value.ToString) Then Continue For
                                data += usedRange.Item(i, j).Value.ToString & "="
                                is_contain = True
                            Next
                            If is_contain = False Then Continue For
                            data += ";"
                        Next

                        'Get Banks
                        Dim BanksList = New List(Of SalesCustomerBankAccounts)
                        If grid_bank.Rows.Count > 1 Then
                            For i = 0 To grid_bank.RowCount - 2
                                BanksList.Add(New SalesCustomerBankAccounts With {
                                    .bank = grid_bank.Rows(i).Cells(0).Value,
                                    .bank_acc_no = grid_bank.Rows(i).Cells(1).Value,
                                    .bank_acc_name = grid_bank.Rows(i).Cells(2).Value
                            })
                            Next
                        End If

                        'Set Query
                        Dim query = String.Empty
                        If lbl_title.Text.Equals("New Customer") Then
                            query = "INSERT INTO ims_customers (first_name, contact_person, contact, address, terms, account_type, preferred_shipping, preferred_payment, trucking_note, assigned_agent, other_notes, credit_limit, banks, tin_no) 
                                            VALUES (@fname, @contact_person, @contact, @address, @terms, @type, @shipping, @payment, @trucking, IFNULL((SELECT IFNULL(usr_id, 0) FROM ims_users WHERE first_name=@assigned_agent), 0), @other_notes, @credit_limit, @banks, @tin_no)"
                        End If

                        Dim cmd = New MySqlCommand(query, connection)
                        cmd.Parameters.AddWithValue("@fname", .ToTitleCase(txt_fname.Text.Trim))
                        cmd.Parameters.AddWithValue("@contact_person", .ToTitleCase(txt_contact_person.Text))
                        cmd.Parameters.AddWithValue("@contact", .ToTitleCase(txt_contact.Text.Trim))
                        cmd.Parameters.AddWithValue("@address", .ToTitleCase(txt_address.Text.Trim))
                        cmd.Parameters.AddWithValue("@type", cbb_account_type.Text.Trim)
                        cmd.Parameters.AddWithValue("@shipping", preferred_shipping)
                        cmd.Parameters.AddWithValue("@payment", cbb_payment_type.EditValue)
                        cmd.Parameters.AddWithValue("@trucking", .ToTitleCase(txt_trucking.Text))
                        cmd.Parameters.AddWithValue("@other_notes", If(String.IsNullOrEmpty(data), String.Empty, data))
                        cmd.Parameters.AddWithValue("@assigned_agent", cbb_agents.Text.Trim())
                        cmd.Parameters.AddWithValue("@banks", JsonConvert.SerializeObject(BanksList))
                        cmd.Parameters.AddWithValue("@tin_no", txt_tin.Text)
                        'Admin Only
                        cmd.Parameters.AddWithValue("@terms", num_terms.Value)
                        cmd.Parameters.AddWithValue("@credit_limit", CDec(txt_credit_limit.Text))
                        cmd.ExecuteNonQuery()
                    End With

                    MsgBox("New Customer was Added!", vbInformation, "Added")
                    ClearField()

                    is_new_customer = True
                End Using

                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If
    End Sub

    'Update Customer
    Private Sub UpdateCustomer()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                With CultureInfo.CurrentCulture.TextInfo

                    Dim preferred_shipping = String.Empty
                    Select Case cbb_shipping.SelectedIndex
                        Case 0 : preferred_shipping = "Pickup"
                        Case 1 : preferred_shipping = "Deliver"
                    End Select

                    'Get Data in Spreadsheet
                    Dim ws = sheet_customer.ActiveWorksheet
                    Dim usedRange = ws.GetUsedRange()

                    Dim data As String = String.Empty

                    For i = 0 To usedRange.RowCount - 1
                        Dim is_contain = False
                        For j = 0 To usedRange.ColumnCount - 1
                            'If String.IsNullOrWhiteSpace(usedRange.Item(i, j).Value.ToString) Then Continue For
                            data += usedRange.Item(i, j).Value.ToString & "="
                            is_contain = True
                        Next
                        If is_contain = False Then Continue For
                        data += ";"
                    Next

                    'Get Banks
                    Dim BanksList = New List(Of SalesCustomerBankAccounts)
                    If grid_bank.Rows.Count > 1 Then
                        For i = 0 To grid_bank.RowCount - 2
                            BanksList.Add(New SalesCustomerBankAccounts With {
                                .bank = grid_bank.Rows(i).Cells(0).Value,
                                .bank_acc_no = grid_bank.Rows(i).Cells(1).Value,
                                .bank_acc_name = grid_bank.Rows(i).Cells(2).Value
                        })
                        Next
                    End If

                    'Set Query
                    Dim query = "UPDATE ims_customers SET first_name=@fname, contact_person=@contact_person, contact=@contact, address=@address, terms=@terms, account_type=@type, banks=@banks, tin_no=@tin_no, preferred_payment=@preferred_payment,
                                    preferred_shipping=@shipping, trucking_note=@trucking, assigned_agent=IFNULL((SELECT IFNULL(usr_id, 0) FROM ims_users WHERE first_name=@assigned_agent), 0), credit_limit=@credit_limit, other_notes=@other_notes
                            WHERE customer_id=" & lbl_customer_id.Text
                    Dim cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@fname", .ToTitleCase(txt_fname.Text.Trim))
                    cmd.Parameters.AddWithValue("@contact_person", .ToTitleCase(txt_contact_person.Text))
                    cmd.Parameters.AddWithValue("@contact", .ToTitleCase(txt_contact.Text.Trim))
                    cmd.Parameters.AddWithValue("@address", .ToTitleCase(txt_address.Text.Trim))
                    cmd.Parameters.AddWithValue("@type", cbb_account_type.Text)
                    cmd.Parameters.AddWithValue("@shipping", preferred_shipping)
                    cmd.Parameters.AddWithValue("@preferred_payment", cbb_payment_type.EditValue)
                    cmd.Parameters.AddWithValue("@trucking", .ToTitleCase(txt_trucking.Text))
                    cmd.Parameters.AddWithValue("@other_notes", If(String.IsNullOrEmpty(data), String.Empty, data))
                    cmd.Parameters.AddWithValue("@assigned_agent", cbb_agents.Text.Trim())
                    cmd.Parameters.AddWithValue("@banks", JsonConvert.SerializeObject(BanksList))
                    cmd.Parameters.AddWithValue("@tin_no", txt_tin.Text)
                    'Admin Only
                    cmd.Parameters.AddWithValue("@credit_limit", CDec(txt_credit_limit.Text))
                    cmd.Parameters.AddWithValue("@terms", num_terms.Value)
                    cmd.ExecuteNonQuery()
                End With
            End Using

            MsgBox("Successfully Updated!", vbInformation, "Information")
            ClearField()
            Me.Close()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Spreacdsheet
    Public Sub LoadSheet(other_notes As String)
        If Not String.IsNullOrEmpty(other_notes) Then

            Dim colonseparator As New Regex("\b;\b")
            Dim equalseparator As New Regex("\b=\b")
            Dim worksheet As Worksheet = sheet_customer.ActiveWorksheet

            sheet_customer.WorksheetDisplayArea.SetSize(0, 4, 25)

            Dim per_row = other_notes.Remove(other_notes.Length - 1, 1).Split(";")

            For i = 0 To per_row.Length - 1

                Dim row_data = per_row(i).Trim
                Dim cell_data = row_data.Split("=")


                For j = 0 To cell_data.Length - 1
                    worksheet.Cells(i, j).Value = cell_data(j)
                Next

            Next

        End If
    End Sub

    'Load Agents
    Private Sub LoadAgents()
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Using cmd = New MySqlCommand("SELECT first_name FROM ims_users WHERE deleted=0", connect)
                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read()
                            cbb_agents.Properties.Items.Add(rdr("first_name"))
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
        If Not String.IsNullOrEmpty(lbl_customer_id.Text) Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT banks FROM ims_customers WHERE customer_id=@cid", conn)
                        cmd.Parameters.AddWithValue("@cid", lbl_customer_id.Text)
                        Using rdr = cmd.ExecuteReader

                            While rdr.Read
                                If Not IsDBNull(rdr("banks")) Then
                                    Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesCustomerBankAccounts))(rdr("banks"))
                                    For Each item In itemsObject
                                        grid_bank.Rows.Add(item.bank, item.bank_acc_no, item.bank_acc_name)
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



    'btn_apply
    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click

        If String.IsNullOrEmpty(txt_fname.Text) _
            Or String.IsNullOrEmpty(txt_address.Text) _
            Or String.IsNullOrEmpty(txt_contact_person.Text) _
            Or cbb_account_type.SelectedIndex = -1 _
            Or cbb_shipping.SelectedIndex = -1 Then

            MsgBox("Complete all fields!", vbCritical, "Incomplete Details")
            Exit Sub

        End If

        If String.IsNullOrEmpty(lbl_customer_id.Text) Then
            NewCustomer()
        Else
            UpdateCustomer()
        End If

        Me.DialogResult = DialogResult.OK

    End Sub

    'btn_cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        ClearField()
        Me.Close()
    End Sub

    'Clear Fields
    Private Sub ClearField()
        txt_fname.Text = String.Empty
        txt_contact.Text = String.Empty
        txt_address.Text = String.Empty
        num_terms.Value = 0
        cbb_account_type.SelectedIndex = -1
        cbb_shipping.SelectedIndex = -1
        txt_trucking.Text = String.Empty
    End Sub

    'btn_delete
    Private Sub btn_delete_customer_Click(sender As Object, e As EventArgs) Handles btn_disable_customer.Click

        If Equals(btn_disable_customer.Text, "Disable Customer") Then

            If MsgBox("Disable this Customer?" & Environment.NewLine & "Press 'Yes' to confirm.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Using connection As New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_customers SET is_deleted='1' WHERE customer_id=@id", connection)
                        cmd.Parameters.AddWithValue("@id", lbl_customer_id.Text)
                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Successfully disabled!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    End Using
                End Using
            End If
        ElseIf Equals(btn_disable_customer.Text, "Enable Customer") Then

            If MsgBox("Enable this Customer?" & Environment.NewLine & "Press 'Yes' to confirm.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Using connection As New MySqlConnection(str)
                    connection.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_customers SET is_deleted='0' WHERE customer_id=@id", connection)
                        cmd.Parameters.AddWithValue("@id", lbl_customer_id.Text)
                        If cmd.ExecuteNonQuery() > 0 Then
                            MsgBox("Successfully enabled!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK
                            Me.Close()
                        End If
                    End Using
                End Using
            End If
        End If

    End Sub

End Class