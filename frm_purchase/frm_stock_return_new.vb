Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_stock_return_new

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ---
    Private Sub frm_purchase_return_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateComboBoxes()
        'CREATE DATATABLE FOR GRID
        Dim dt = New DataTable
        dt.Columns.Add("qty")
        dt.Columns.Add("pid")
        dt.Columns.Add("winmodel")
        dt.Columns.Add("supmodel")
        dt.Columns.Add("supplier")
        dt.Columns.Add("cost")
        dt.Columns.Add("serial")
        dt.Columns.Add("type")
        dt.Columns.Add("issue")
        dt.Columns.Add("accessories")
        dt.Columns.Add("reference")
        dt.Columns.Add("comments")
        grid_returns.DataSource = dt
    End Sub


    '--- FUNCTIONS ---

    ''LOAD ITEMS TO COMBOBOX : MODEL
    Private Sub PopulateComboBoxes()
        Try
            conn.Open()

            'Models
            Using cmd = New MySqlCommand("SELECT winmodel FROM ims_inventory WHERE status='Active'", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_model.Properties.Items.Add(rdr("winmodel"))
                    End While
                End Using
            End Using

            'Warehouse
            Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores WHERE deleted='0'", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_warehouse.Properties.Items.Add(rdr("store_name"))
                    End While
                End Using
                cbb_warehouse.SelectedText = frm_main.lbl_user_designation.Text
            End Using

            'Supplier
            Using cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_supplier.Properties.Items.Add(rdr("supplier"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'PRINT TAGS : SINGLE UNIT
    Private Sub PrintTags(RIDs As List(Of Integer))
        Try
            conn.Open()
            Dim report As New doc_return_tag
            Dim printTool = New ReportPrintTool(report)
            Dim dt = New DataTable


            For Each rid As Integer In RIDs
                Using cmd = New MySqlCommand("SELECT id, qty, ims_inventory.supmodel, rs_returns.type, serial, accessories, issue
                                          FROM rs_returns 
                                          INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                          WHERE id=@rid", conn)
                    cmd.Parameters.AddWithValue("@rid", rid)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            For i = 1 To CInt(rdr("qty"))
                                Dim sub_report As New doc_return_tag
                                sub_report.Parameters("RID").Value = rdr("id").ToString
                                sub_report.Parameters("model").Value = rdr("supmodel")
                                sub_report.Parameters("type").Value = rdr("type")
                                sub_report.Parameters("serial").Value = rdr("serial")
                                sub_report.Parameters("accessories").Value = rdr("accessories")
                                sub_report.Parameters("issue").Value = rdr("issue")
                                sub_report.CreateDocument()

                                report.Pages.AddRange(sub_report.Pages)
                            Next
                        End While
                    End Using
                End Using
            Next

            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub




    '--- CONTROL / EVENTS ----

    Private Sub cbb_model_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_model.SelectedIndexChanged
        If Not cbb_model.SelectedIndex = -1 Then
            Try
                conn.Open()
                Using cmd = New MySqlCommand("SELECT pid, supmodel, description, cost, ims_suppliers.supplier
                                            FROM ims_inventory 
                                            LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_inventory.supplier
                                            WHERE status='Active' AND winmodel=@winmodel", conn)
                    cmd.Parameters.AddWithValue("@winmodel", cbb_model.EditValue)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            txt_pid.EditValue = rdr("pid")
                            txt_supmodel.EditValue = rdr("supmodel")
                            txt_description.EditValue = rdr("description")
                            cbb_supplier.EditValue = rdr("supplier")
                            txt_cost.EditValue = rdr("cost")
                        End While
                    End Using
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    'BUTTON : ADD
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        If String.IsNullOrWhiteSpace(cbb_model.EditValue) _
            Or cbb_type.SelectedIndex = -1 _
            Or cbb_warehouse.SelectedIndex = -1 _
            Or String.IsNullOrWhiteSpace(txt_issue.EditValue) Then
            MsgBox("Complete all required fields!", vbExclamation, "Incomplete Fields")

        Else
            Dim dt = TryCast(grid_returns.DataSource, DataTable)
            dt.Rows.Add(
                se_qty.EditValue,
                txt_pid.EditValue,
                cbb_model.EditValue,
                txt_supmodel.EditValue,
                cbb_supplier.EditValue,
                txt_cost.EditValue,
                txt_serial.EditValue,
                cbb_type.EditValue,
                txt_issue.EditValue,
                txt_acc.EditValue,
                txt_ref.EditValue,
                txt_comments.EditValue)

            'Clear Values
            ClearFields()

        End If
    End Sub

    Private Sub ClearFields()
        se_qty.EditValue = 1
        txt_pid.EditValue = ""
        cbb_model.SelectedIndex = -1
        txt_supmodel.EditValue = ""
        txt_description.EditValue = ""
        cbb_supplier.SelectedIndex = -1
        txt_cost.EditValue = ""
        txt_serial.EditValue = ""
        cbb_type.SelectedIndex = -1
        txt_issue.EditValue = ""
        txt_acc.EditValue = ""
        txt_ref.EditValue = ""
        txt_comments.EditValue = ""
    End Sub

    'BUTTON : EDIT
    Private Sub btn_delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete.ButtonClick
        grid_returns_view.DeleteRow(grid_returns_view.FocusedRowHandle)
    End Sub

    'BUTTON : SUBMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If MsgBox("Press 'YES' to submit.", vbYesNo + vbQuestion, "Are you sure?") = vbYes Then

            Dim RID_list As New List(Of Integer)

            Try
                Dim result As Boolean = False
                Dim warehouse = String.Concat("ims_", cbb_warehouse.EditValue.ToString.Replace(" ", "_").ToLower)

                conn.Open()
                Using cmd = New MySqlCommand($"INSERT INTO rs_returns (qty, pid, supplier_id, cost, serial, type, status, approval_winland, approval_supplier, issue, accessories, reference, comments, src_warehouse_id, created_by, created_at)
                                    VALUES (@qty, @pid, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @cost, @serial, @type, @status, @approval_winland, @approval_supplier, @issue, @accessories, @reference, @comments, 
                                        (SELECT store_id FROM ims_stores WHERE store_name=@warehouse), @created_by, CURRENT_TIMESTAMP);
                                    UPDATE {warehouse} SET on_hold=IFNULL(on_hold, 0)+@qty, qty=qty-@qty WHERE pid=@pid", conn)
                    cmd.Parameters.AddWithValue("@qty", 0)
                    cmd.Parameters.AddWithValue("@pid", 0)
                    cmd.Parameters.AddWithValue("@supplier", Nothing)
                    cmd.Parameters.AddWithValue("@cost", 0.00)
                    cmd.Parameters.AddWithValue("@serial", Nothing)
                    cmd.Parameters.AddWithValue("@type", Nothing)
                    cmd.Parameters.AddWithValue("@status", "For Approval")
                    cmd.Parameters.AddWithValue("@approval_winland", "Pending")
                    cmd.Parameters.AddWithValue("@approval_supplier", "Pending")
                    cmd.Parameters.AddWithValue("@issue", Nothing)
                    cmd.Parameters.AddWithValue("@accessories", Nothing)
                    cmd.Parameters.AddWithValue("@reference", Nothing)
                    cmd.Parameters.AddWithValue("@comments", Nothing)
                    cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("@warehouse", cbb_warehouse.EditValue)
                    cmd.Prepare()

                    Dim dt = TryCast(grid_returns.DataSource, DataTable)
                    For Each row As DataRow In dt.Rows
                        cmd.Parameters("@qty").Value = row("qty")
                        cmd.Parameters("@pid").Value = row("pid")
                        cmd.Parameters("@supplier").Value = row("supplier")
                        cmd.Parameters("@cost").Value = row("cost")
                        cmd.Parameters("@serial").Value = row("serial")
                        cmd.Parameters("@type").Value = row("type")
                        cmd.Parameters("@issue").Value = row("issue")
                        cmd.Parameters("@reference").Value = row("reference")
                        cmd.Parameters("@comments").Value = row("comments")
                        cmd.Parameters("@accessories").Value = row("accessories")
                        If cmd.ExecuteNonQuery() > 0 Then
                            RID_list.Add(cmd.LastInsertedId)
                            result = True
                        End If
                    Next

                    If result = True Then
                        TryCast(grid_returns.DataSource, DataTable).Rows.Clear()
                        MsgBox($"Submitted!{vbCrLf}Stocks are deducted from the selected warehouse.", vbInformation, "Information")
                        Me.Close()
                    End If

                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
                If MsgBox($"Print all tags?{vbCrLf}Press 'Yes' to continue.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                    PrintTags(RID_list)
                End If
            End Try
        End If
    End Sub

    'BUTTON : CLEAR
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub

End Class