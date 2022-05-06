Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_purchaseorder_return_new

    Private model_AutoCompleteString As New AutoCompleteStringCollection
    Private description_AutoCompleteString As New AutoCompleteStringCollection
    Dim ListOfItem As List(Of PurchaseReturnClass) = New List(Of PurchaseReturnClass)



    '--- ONLOAD ---
    Private Sub frm_purchaseorder_return_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Supplier()
    End Sub



    '--- FUNCTIONS ----

    'Set Supplier (AUTOFILL)
    Private Sub Load_Supplier()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim rdr = New MySqlCommand("SELECT supplier FROM `ims_suppliers`", conn).ExecuteReader

                While rdr.Read
                    cbb_supplier.Properties.Items.Add(rdr("supplier"))
                End While

                cbb_supplier.SelectedIndex = -1

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Load AutoComplete String
    Private Sub Load_AutoCompleteString()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT winmodel, description FROM ims_inventory WHERE supplier=@supplier", conn)
                cmd.Parameters.AddWithValue("@supplier", txt_supplier_id.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                model_AutoCompleteString.Clear()
                description_AutoCompleteString.Clear()

                While rdr.Read
                    model_AutoCompleteString.Add(rdr("winmodel"))
                    description_AutoCompleteString.Add(rdr("description"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Digits Only in Column Qty
    Private Sub DigitsOnly_KeyPress(sender As Object, e As KeyPressEventArgs)
        If grid_return.CurrentCell.ColumnIndex = 1 Then
            If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
                e.Handled = True
            End If
        End If
    End Sub

    'Compute Total 
    Private Sub ComputeTotal()
        Try
            Dim sub_total As Decimal = 0.00

            For i = 0 To grid_return.Rows.Count - 1
                If IsDBNull(grid_return.Rows(i).Cells(6).Value) Then Continue For
                sub_total += grid_return.Rows(i).Cells(6).Value
            Next

            lbl_total.Text = FormatCurrency(sub_total, 2)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Clear Fields
    Private Sub ClearFields()
        grid_return.Rows.Clear()
        lbl_total.Text = FormatCurrency(0.00)
        txt_supplier_id.Text = String.Empty
        cbb_supplier.Text = String.Empty
    End Sub

    'Load Edit
    Public Sub LoadEdit(id As Integer)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using rdr = New MySqlCommand("SELECT * FROM ims_purchase_returns 
                            INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id
                            WHERE po_return_id=" & id, conn).ExecuteReader
                    While rdr.Read
                        txt_prid.Text = rdr("po_return_id")
                        cbb_supplier.Text = rdr("supplier")

                        Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of PurchaseReturnClass))(rdr("items"))
                        For Each item In itemsObject
                            grid_return.Rows.Add(item.batch_no, item.rid, item.qty, item.model, item.description, item.cost, item.total_cost)
                        Next

                        ComputeTotal()
                    End While

                    'Update GUI for EDITING
                    lbl_title.Text = "Edit Purchase Return"
                    HyperlinkLabelControl3.Text = "Edit"
                    btn_create.Visible = False
                    btn_clear.Visible = False
                    btn_update.Visible = True
                    btn_delete.Visible = True
                    btn_print.Visible = True
                    lbl_rid.Visible = True
                    txt_prid.Visible = True
                    btn_print.Location = btn_update.Location
                    btn_update.Location = btn_create.Location
                    btn_delete.Location = btn_clear.Location
                    txt_prid.ReadOnly = True
                    cbb_supplier.ReadOnly = True
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    '--- CONTROLS ----


    'grid_order | Editing Control Swing
    Private Sub grid_return_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grid_return.EditingControlShowing

        If grid_return.CurrentCell.ColumnIndex = 2 Then
            AddHandler DirectCast(e.Control, TextBox).KeyPress, AddressOf DigitsOnly_KeyPress
        End If

        If Not (grid_return.CurrentCell.ColumnIndex = 3 Or grid_return.CurrentCell.ColumnIndex = 4) Then
            Dim control As TextBox = TryCast(e.Control, TextBox)
            If control IsNot Nothing Then
                control.AutoCompleteMode = AutoCompleteMode.None
            End If
        Else
            Dim txt As TextBox = TryCast(e.Control, TextBox)
            RemoveHandler txt.KeyPress, AddressOf DigitsOnly_KeyPress

            If grid_return.CurrentCell.ColumnIndex = 3 Then

                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = model_AutoCompleteString
                    txt.CharacterCasing = CharacterCasing.Upper
                End If

            ElseIf grid_return.CurrentCell.ColumnIndex = 4 Then
                If txt IsNot Nothing Then
                    txt.AutoCompleteMode = AutoCompleteMode.SuggestAppend
                    txt.AutoCompleteSource = AutoCompleteSource.CustomSource
                    txt.AutoCompleteCustomSource = description_AutoCompleteString
                End If
            End If

        End If

    End Sub

    'grid_control | Editing Control Swing
    Private Sub grid_return_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_return.CellEndEdit
        If Not String.IsNullOrEmpty(cbb_supplier.Text) Then

            'IF MODEL
            If e.ColumnIndex.Equals(3) Then
                If Not IsDBNull(grid_return.CurrentCell.Value) Then

                    'CHECK IF ALREADY EXIST
                    'For i = 0 To grid_return.Rows.Count - 1
                    '    If i = grid_return.CurrentRow.Index Then Continue For
                    '    If grid_return.CurrentCell.Value.Equals(grid_return.Rows(i).Cells(3).Value) Then
                    '        MsgBox("Warning! Item Already Exist.", vbExclamation, "Duplicate Entry")
                    '    End If
                    'Next

                    'GET AND SET
                    Try

                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Dim cmd = New MySqlCommand("SELECT winmodel, description, cost FROM ims_inventory WHERE winmodel=@winmodel", conn)
                            cmd.Parameters.AddWithValue("@winmodel", grid_return.CurrentCell.Value)
                            Dim rdr As MySqlDataReader = cmd.ExecuteReader

                            If rdr.HasRows Then
                                Using rdr
                                    While rdr.Read

                                        'SET VALUE to grid_order
                                        grid_return.Rows(e.RowIndex).Cells(3).Value = rdr("winmodel")
                                        grid_return.Rows(e.RowIndex).Cells(4).Value = rdr("description")
                                        Dim cost As Decimal = rdr("cost")
                                        grid_return.Rows(e.RowIndex).Cells(5).Value = cost

                                        If Not IsDBNull(grid_return.Rows(e.RowIndex).Cells(2).Value) Then
                                            Dim total As Decimal = grid_return.Rows(e.RowIndex).Cells(2).Value * cost
                                            grid_return.Rows(e.RowIndex).Cells(6).Value = total
                                        End If

                                    End While
                                End Using
                            Else
                                MsgBox("Selected item couldn't found!", vbCritical, "Not Found")
                                grid_return.Rows(e.RowIndex).Cells(0).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(1).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(2).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(3).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(4).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(5).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(6).Value = DBNull.Value
                                Return
                            End If
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If
            End If


            'IF DESCRIPTION
            If e.ColumnIndex.Equals(4) Then
                If Not IsDBNull(grid_return.CurrentCell.Value) Then

                    'GET AND SET
                    Try

                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Dim cmd = New MySqlCommand("SELECT winmodel, description, cost FROM ims_inventory WHERE description=@description", conn)
                            cmd.Parameters.AddWithValue("@description", grid_return.CurrentCell.Value)
                            Dim rdr As MySqlDataReader = cmd.ExecuteReader

                            If rdr.HasRows Then
                                Using rdr
                                    While rdr.Read

                                        'SET VALUE to grid_order
                                        grid_return.Rows(e.RowIndex).Cells(3).Value = rdr("winmodel")
                                        grid_return.Rows(e.RowIndex).Cells(4).Value = rdr("description")
                                        Dim cost As Decimal = rdr("cost")
                                        grid_return.Rows(e.RowIndex).Cells(5).Value = cost

                                        If Not IsDBNull(grid_return.Rows(e.RowIndex).Cells(2).Value) Then
                                            Dim total As Decimal = grid_return.Rows(e.RowIndex).Cells(2).Value * cost
                                            grid_return.Rows(e.RowIndex).Cells(6).Value = total
                                        End If

                                    End While
                                End Using
                            Else
                                MsgBox("Selected item couldn't found!", vbCritical, "Not Found")
                                grid_return.Rows(e.RowIndex).Cells(0).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(1).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(2).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(3).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(4).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(5).Value = DBNull.Value
                                grid_return.Rows(e.RowIndex).Cells(6).Value = DBNull.Value
                                Return
                            End If
                        End Using

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If
            End If


            'IF QTY OR PRICE
            If e.ColumnIndex.Equals(2) Or e.ColumnIndex.Equals(5) Then

                Try
                    If IsDBNull(grid_return.CurrentCell.Value) Or String.IsNullOrEmpty(grid_return.Rows(e.RowIndex).Cells(3).Value) Then Return
                    Dim qty As Decimal = grid_return.Rows(e.RowIndex).Cells(2).Value
                    Dim cost As Decimal = grid_return.Rows(e.RowIndex).Cells(5).Value
                    Dim total As Decimal = Decimal.Multiply(qty, cost)
                    grid_return.Rows(e.RowIndex).Cells(5).Value = cost
                    grid_return.Rows(e.RowIndex).Cells(6).Value = total

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try

            End If

            'Compute Total
            ComputeTotal()

        End If

    End Sub

    'Selecting ComboBox
    Private Sub cbb_supplier_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_supplier.SelectedValueChanged
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM `ims_suppliers` WHERE supplier=@supplier", conn)
                cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    txt_supplier_id.Text = rdr("id")
                End While
            End Using

            'Load Units
            Load_AutoCompleteString()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_create
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

        'Validation
        If cbb_supplier.SelectedIndex = -1 Or grid_return.Rows.Count - 1 = 0 Then
            MsgBox("Creation failed! Complete all fields.", vbCritical, "Failed to Create")
            Return
        End If

        For i = 0 To grid_return.Rows.Count - 2

            ListOfItem.Add(New PurchaseReturnClass With {
                .batch_no = grid_return.Rows(i).Cells(0).Value,
                .rid = grid_return.Rows(i).Cells(1).Value,
                .qty = grid_return.Rows(i).Cells(2).Value,
                .model = grid_return.Rows(i).Cells(3).Value,
                .description = grid_return.Rows(i).Cells(4).Value,
                .cost = grid_return.Rows(i).Cells(5).Value,
                .total_cost = grid_return.Rows(i).Cells(6).Value
            })

        Next

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("INSERT INTO ims_purchase_returns (supplier_id, items, total_cost, status, created_by, created_at) VALUES (@supplier_id, @items, @total_cost, 'Pending', @created_by, NOW())", conn)
                    cmd.Parameters.AddWithValue("@supplier_id", txt_supplier_id.Text)
                    cmd.Parameters.AddWithValue("@items", JsonConvert.SerializeObject(ListOfItem))
                    cmd.Parameters.AddWithValue("@total_cost", CDec(lbl_total.Text))
                    cmd.Parameters.AddWithValue("@created_by", frm_main.user_id.Text)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Successfully Created!", vbInformation, "Created")
                        frm_main.LoadFrm(New frm_purchaseorder_return_list)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Update Button
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Validation
        If cbb_supplier.SelectedIndex = -1 Or grid_return.Rows.Count - 1 = 0 Then
            MsgBox("Creation failed! Complete all fields.", vbCritical, "Failed to Create")
            Return
        End If

        For i = 0 To grid_return.Rows.Count - 2

            ListOfItem.Add(New PurchaseReturnClass With {
                .batch_no = grid_return.Rows(i).Cells(0).Value,
                .rid = grid_return.Rows(i).Cells(1).Value,
                .qty = grid_return.Rows(i).Cells(2).Value,
                .model = grid_return.Rows(i).Cells(3).Value,
                .description = grid_return.Rows(i).Cells(4).Value,
                .cost = grid_return.Rows(i).Cells(5).Value,
                .total_cost = grid_return.Rows(i).Cells(6).Value
            })

        Next

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("UPDATE ims_purchase_returns SET items=@items, total_cost=@total_cost, status='Pending' WHERE po_return_id=" & txt_prid.Text, conn)
                    cmd.Parameters.AddWithValue("@items", JsonConvert.SerializeObject(ListOfItem))
                    cmd.Parameters.AddWithValue("@total_cost", CDec(lbl_total.Text))
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Successfully Updated!", vbInformation, "Created")
                        frm_main.LoadFrm(New frm_purchaseorder_return_list)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_clear | Clear Fields
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

    'Grid Returns Deleted
    Private Sub grid_return_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles grid_return.RowsRemoved
        ComputeTotal()
    End Sub

    'Delete Button
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If MsgBox("Press 'Yes' to Delete.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_purchase_returns SET is_deleted='1' WHERE po_return_id=@id", conn)
                        cmd.Parameters.AddWithValue("@id", txt_prid.Text)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Deleted!", vbInformation, "Information")
                            frm_main.LoadFrm(New frm_purchaseorder_return_list)
                        End If
                    End Using
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Button
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Try
            Dim report = New doc_purchase_return()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT po_return_id, ims_suppliers.supplier, ims_users.first_name AS created_by, items, total_cost,
                                    (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') AS store_info FROM ims_purchase_returns
                                    INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id
                                    INNER JOIN ims_users ON ims_users.usr_id=ims_purchase_returns.created_by
                                    WHERE po_return_id=" & txt_prid.Text, connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            report.Parameters("store_name").Value = rdr("store_name")
                            report.Parameters("store_info").Value = rdr("store_info")
                            report.Parameters("supplier").Value = rdr("supplier")
                            report.Parameters("prid").Value = String.Concat("PR", rdr("po_return_id").ToString.PadLeft(5, "0"c))
                            report.Parameters("created_by").Value = rdr("created_by")
                            report.Parameters("total_cost").Value = rdr("total_cost")

                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of PurchaseReturnClass))(rdr("items"))
                            For Each item In itemsObject
                                table.purchase_returns_items.Rows.Add(item.rid, item.qty, item.model, item.description, item.cost, item.total_cost, item.batch_no)
                            Next

                        End While

                        report.RequestParameters = False
                        report.DataSource = table
                        report.ShowRibbonPreviewDialog()

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class
