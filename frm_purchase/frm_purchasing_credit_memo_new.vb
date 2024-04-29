Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraSpreadsheet.Model
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_purchasing_credit_memo_new

    Private model_AutoCompleteString As New AutoCompleteStringCollection
    Private description_AutoCompleteString As New AutoCompleteStringCollection
    Dim ListOfItem As List(Of PurchaseReturnClass) = New List(Of PurchaseReturnClass)



    '--- ONLOAD ---
    Private Sub frm_purchaseorder_return_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Supplier()
        btn_fetch_pendings.Location = btn_update.Location - New Point(60)
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
        Try
            If grid_return.DataSource Is Nothing Then
                grid_return.Rows.Clear()
            Else
                TryCast(grid_return.DataSource, DataTable).Rows.Clear()
            End If

            lbl_total.Text = FormatCurrency(0.00)
            txt_supplier_id.Text = String.Empty
            cbb_supplier.Text = String.Empty
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
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
                    Me.Text = "Credit Memo #" & txt_prid.Text
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
                    cbb_supplier.ReadOnly = True
                    btn_fetch_pendings.Visible = False
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

            'IF RID
            If e.ColumnIndex.Equals(1) Then
                If Not IsDBNull(grid_return.CurrentCell.Value) Then
                    Try
                        Using conn = New MySqlConnection(str)
                            conn.Open()
                            Using cmd = New MySqlCommand("SELECT rid, qty_received, credit_cost, rs_returns.batch_id,  ims_inventory.winmodel, ims_inventory.description
                                                         FROM rs_returns_deliveries
                                                         INNER JOIN rs_returns ON rs_returns.id=rs_returns_deliveries.rid
                                                         INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                                                         INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                                         WHERE rs_returns.id=@rid AND return_action='Pullout' 
                                                                AND rs_returns_deliveries.status='Pending for Credit'
                                                                AND ims_suppliers.supplier=@supplier", conn)
                                cmd.Parameters.AddWithValue("@rid", grid_return.CurrentCell.Value)
                                cmd.Parameters.AddWithValue("@supplier", cbb_supplier.EditValue)

                                Using rdr = cmd.ExecuteReader
                                    If rdr.HasRows Then
                                        While rdr.Read
                                            grid_return.Rows(e.RowIndex).Cells(0).Value = rdr("batch_id")
                                            grid_return.Rows(e.RowIndex).Cells(1).Value = rdr("rid")
                                            grid_return.Rows(e.RowIndex).Cells(2).Value = rdr("qty_received")
                                            grid_return.Rows(e.RowIndex).Cells(3).Value = rdr("winmodel")
                                            grid_return.Rows(e.RowIndex).Cells(4).Value = rdr("description")
                                            grid_return.Rows(e.RowIndex).Cells(5).Value = rdr("credit_cost")
                                            grid_return.Rows(e.RowIndex).Cells(6).Value = rdr("qty_received") * rdr("credit_cost")
                                        End While
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
                            End Using
                            conn.Close()
                        End Using
                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try
                End If
            End If

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

            'Clear ROws
            If grid_return.DataSource Is Nothing Then
                grid_return.Rows.Clear()
            Else
                TryCast(grid_return.DataSource, DataTable).Rows.Clear()
            End If

            'Load Units
            Load_AutoCompleteString()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_create
    Private Async Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click

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
                Dim trans = conn.BeginTransaction
                Dim credit_memo_id As Integer = 0

                Try
                    'UPDATE Credit Memo
                    Using cmd = New MySqlCommand("INSERT INTO ims_purchase_returns (supplier_id, items, total_cost, status, created_by, created_at) 
                                                  VALUES (@supplier_id, @items, @total_cost, 'Pending', @created_by, NOW())", conn, trans)
                        cmd.Parameters.AddWithValue("@supplier_id", txt_supplier_id.Text)
                        cmd.Parameters.AddWithValue("@items", JsonConvert.SerializeObject(ListOfItem))
                        cmd.Parameters.AddWithValue("@total_cost", CDec(lbl_total.Text))
                        cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                        If cmd.ExecuteNonQuery > 0 Then
                            credit_memo_id = cmd.LastInsertedId
                        End If
                    End Using

                    'UPDATE Return to Vendor Deliveries
                    Using cmd = New MySqlCommand($"UPDATE rs_returns_deliveries SET status='Created', credit_memo_id={credit_memo_id}
                                                 WHERE rid=@rid", conn, trans)
                        cmd.Parameters.AddWithValue("@rid", 0)
                        cmd.Prepare()

                        For i = 0 To grid_return.RowCount - 1
                            cmd.Parameters("@rid").Value = grid_return.Rows(i).Cells(1).Value
                            cmd.ExecuteNonQuery()
                        Next
                    End Using

                    trans.Commit()
                    MsgBox("Successfully Created!", vbInformation, "Created")
                    Await frm_main.LoadFrm(New frm_purchasing_credit_memo, "frm_purchaseorder_return_list")

                Catch ex As Exception
                    trans.Rollback()
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try

                conn.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Update Button
    Private Async Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
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
                        Await frm_main.LoadFrm(New frm_purchasing_credit_memo, "frm_purchaseorder_return_list")
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
    Private Async Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Try
            If MsgBox("Press 'Yes' to Delete.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim transc = conn.BeginTransaction
                    Try
                        'UPDATE rs_return_deliveries; Set Status = 'Pending'
                        Using cmd = New MySqlCommand("UPDATE rs_returns_deliveries SET status='Pending for Credit', credit_memo_id=NULL
                                                    WHERE rid=@rid", conn, transc)
                            cmd.Parameters.AddWithValue("@rid", 0)
                            cmd.Prepare()

                            For i = 0 To grid_return.RowCount - 1
                                cmd.Parameters("@rid").Value = grid_return.Rows(i).Cells(1).Value
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        'UPDATE Credit Memo to deleted
                        Using cmd = New MySqlCommand("UPDATE ims_purchase_returns SET is_deleted='1' WHERE po_return_id=@id", conn, transc)
                            cmd.Parameters.AddWithValue("@id", txt_prid.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        transc.Commit()
                        MsgBox("Deleted!", vbInformation, "Information")
                        Me.Close()
                        Await frm_main.LoadFrm(New frm_purchasing_credit_memo, "frm_purchasing_credit_memo")

                    Catch ex As Exception
                        transc.Rollback()
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Button
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Try
            Dim report = New doc_purchase_credit_memo()
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
                            report.Parameters("cmid").Value = String.Concat("CM", rdr("po_return_id").ToString.PadLeft(5, "0"c))
                            report.Parameters("created_by").Value = rdr("created_by")
                            report.Parameters("total_cost").Value = rdr("total_cost")

                            Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of PurchaseReturnClass))(rdr("items"))
                            For Each item In itemsObject
                                table.purchase_returns_items.Rows.Add(
                                                                      IIf(item.rid = 0, "", item.rid),
                                                                      item.qty,
                                                                      item.model,
                                                                      item.description,
                                                                      item.cost,
                                                                      item.total_cost,
                                                                      IIf(item.batch_no = 0, "", item.batch_no))
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

    'BUTTON : SHOW PENDING CREDITS
    Private Sub btn_show_pending_Click(sender As Object, e As EventArgs) Handles btn_show_pending.Click
        If cbb_supplier.SelectedIndex = -1 Then
            MsgBox("Select Supplier first!", vbCritical, "Required")
            Exit Sub
        Else
            Dim frm = frm_purchasing_credit_memo_pending_dialog
            frm.supplier = cbb_supplier.EditValue
            frm.is_filtered = True
            frm.ShowDialog()
        End If

    End Sub

    'BUTTON : FETCH PENDINGS
    Private Sub btn_fetch_pendings_Click(sender As Object, e As EventArgs) Handles btn_fetch_pendings.Click
        If cbb_supplier.SelectedIndex = -1 Then
            MsgBox("Select Supplier first!", vbCritical, "Required")
            Exit Sub
        Else
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim rowCount As Integer = 0
                    Dim dt = New DataTable
                    dt.Columns.Add("batch_id")
                    dt.Columns.Add("rid")
                    dt.Columns.Add("qty_received")
                    dt.Columns.Add("winmodel")
                    dt.Columns.Add("description")
                    dt.Columns.Add("credit_cost", GetType(Decimal))
                    dt.Columns.Add("total_cost", GetType(Decimal))

                    Dim query = "SELECT rid, qty_received, credit_cost, rs_returns.batch_id,  ims_inventory.winmodel, ims_inventory.description
                                                         FROM rs_returns_deliveries
                                                         INNER JOIN rs_returns ON rs_returns.id=rs_returns_deliveries.rid
                                                         INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                                                         INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                                         WHERE return_action='Pullout' 
                                                                AND rs_returns_deliveries.status='Pending for Credit'
                                                                AND ims_suppliers.supplier=@supplier"

                    Using cmd = New MySqlCommand(query, conn)
                        cmd.Parameters.AddWithValue("@supplier", cbb_supplier.EditValue)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                Dim newRow As DataRow = dt.NewRow()
                                newRow("batch_id") = rdr("batch_id")
                                newRow("rid") = rdr("rid")
                                newRow("qty_received") = rdr("qty_received")
                                newRow("winmodel") = rdr("winmodel")
                                newRow("description") = rdr("description")
                                newRow("credit_cost") = rdr("credit_cost")
                                newRow("total_cost") = rdr("qty_received") * rdr("credit_cost")
                                dt.Rows.Add(newRow)
                            End While
                        End Using
                    End Using

                    grid_return.DataSource = dt

                    'Compute Total
                    ComputeTotal()

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class