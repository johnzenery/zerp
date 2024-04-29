Imports DevExpress.XtraCharts.Native
Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_stock_return_batch

    ReadOnly conn As New MySqlConnection(str)
    Public Property batch_id As Integer = 0

    'ONLOAD
    Private Sub frm_stock_return_batch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbb_supplier.Properties.Items.Count = 0 And cbb_warehouse.Properties.Items.Count = 0 Then
            PopulateComboBoxes()
        End If
    End Sub



    '--- FUNCTIONS ----

    'LOAD UNITS
    Private Sub LoadUnits()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id, qty, rs_returns.pid, ims_inventory.winmodel, ims_inventory.supmodel, serial, rs_returns.type, issue
                                            FROM rs_returns
                                            INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            WHERE approval_winland='Approved' AND approval_supplier='Approved' AND rs_returns.is_deleted='0' AND rs_returns.batch_id IS NULL
                                                AND supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier)
                                                AND src_warehouse_id=(SELECT store_id FROM ims_stores WHERE store_name=@warehouse)", conn)
                cmd.Parameters.AddWithValue("@supplier", cbb_supplier.EditValue.ToString)
                cmd.Parameters.AddWithValue("@warehouse", cbb_warehouse.EditValue.ToString)

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_returns.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'POPULATE SUPPLIER
    Private Sub PopulateComboBoxes()
        Try
            conn.Open()

            'Populate Suppliers
            cbb_supplier.Properties.Items.Clear()
            Using cmd = New MySqlCommand("SELECT supplier FROM ims_suppliers", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_supplier.Properties.Items.Add(rdr("supplier"))
                    End While
                End Using
            End Using

            'Populate Warehouse
            cbb_warehouse.Properties.Items.Clear()
            Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_warehouse.Properties.Items.Add(rdr("store_name"))
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'LOAD EDIT
    Public Sub LoadEdit(batchID As String)
        batch_id = batchID
        lbl_title.Text = $"Batch Pullout #{batchID}"
        Me.Text = $"Batch Pullout #{batchID}"

        Try
            conn.Open()


            'GET PULLOUT REQUEST STATUS AND UPDATE GUI
            Using cmd = New MySqlCommand($"SELECT status
                                        FROM rs_returns_batch 
                                        WHERE batch_id={batchID}", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        Select Case rdr("status")
                            Case "Pending Arrangement"
                                btn_arrange.Enabled = False
                                btn_delete.Visible = False
                        End Select
                    End While
                End Using
            End Using

            'GET UNITS FROM RETRUNS
            Using cmd = New MySqlCommand($"SELECT qty, ims_inventory.pid, ims_inventory.winmodel, ims_inventory.supmodel, serial, rs_returns.type, issue, rs_returns.id
                                        FROM rs_returns 
                                        LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                        WHERE batch_id={batchID}", conn)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_returns.DataSource = dt
            End Using

            'GET DETAILS FROM BATCH
            Using cmd = New MySqlCommand($"SELECT rs_returns_batch.status, ims_suppliers.supplier, ims_stores.store_name
                                        FROM rs_returns_batch
                                        INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                                        INNER JOIN ims_stores ON ims_stores.store_id=rs_returns_batch.warehouse_id
                                        WHERE rs_returns_batch.batch_id={batchID}", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_supplier.EditValue = rdr("supplier")
                        cbb_warehouse.EditValue = rdr("store_name")
                        lbl_status.Text = rdr("status")
                    End While
                End Using
            End Using

            cbb_supplier.Properties.ReadOnly = True
            cbb_warehouse.Properties.ReadOnly = True
            btn_submit.Visible = False
            grid_returns_view.OptionsSelection.MultiSelect = False

        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub


    'PRINT BATCH
    Public Sub PrintBatchPullout(batchID As Integer)
        Dim report = New doc_batch_pullout
        Dim table = New PrintData

        Try
            conn.Open()
            Dim query = $"SELECT batch_id, ims_suppliers.supplier, ims_stores.store_name, sent_at
                        FROM rs_returns_batch
                        INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                        INNER JOIN ims_stores ON ims_stores.store_id=rs_returns_batch.warehouse_id
                        WHERE batch_id={batchID}"
            Using rdr = New MySqlCommand(query, conn).ExecuteReader
                While rdr.Read
                    report.Parameters("batch_id").Value = rdr("batch_id")
                    report.Parameters("supplier").Value = rdr("supplier")
                    report.Parameters("warehouse").Value = rdr("store_name")
                    report.Parameters("sent_at").Value = rdr("sent_at")
                End While
            End Using

            Using rdr = New MySqlCommand($"SELECT id, qty, rs_returns.type, ims_inventory.pid, ims_inventory.winmodel, issue, serial
                                         FROM rs_returns
                                         LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                         WHERE batch_id={batchID}", conn).ExecuteReader
                While rdr.Read
                    table.batch_units.Rows.Add(rdr("id"), rdr("qty"), rdr("pid"), rdr("winmodel"), rdr("serial"), rdr("type"), rdr("issue"))
                End While
            End Using

            report.RequestParameters = False
            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'PRINT SLIP : SUPPLIER RETURNS
    Public Sub PrintSupplierReturns(batchID As Integer)
        Dim report = New doc_supplier_returns
        Dim table = New PrintData

        Try
            conn.Open()
            Dim query = $"SELECT batch_id, ims_suppliers.supplier, ims_stores.store_name AS warehouse, released_at,
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info,
                        created_by.first_name AS encoded_by, prepared_by, packed_by, released_by.first_name AS released_by, driver
                        FROM rs_returns_batch
                        INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns_batch.supplier_id
                        INNER JOIN ims_stores ON ims_stores.store_id=rs_returns_batch.warehouse_id
                        LEFT JOIN ims_users AS created_by ON created_by.usr_id=rs_returns_batch.created_by
                        LEFT JOIN ims_users AS released_by ON released_by.usr_id=rs_returns_batch.released_by
                        WHERE batch_id={batchID}"
            Using rdr = New MySqlCommand(query, conn).ExecuteReader
                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info")

                    report.Parameters("batch_id").Value = rdr("batch_id")
                    report.Parameters("supplier").Value = rdr("supplier")
                    report.Parameters("warehouse").Value = rdr("warehouse")
                    report.Parameters("sent_at").Value = rdr("released_at")

                    report.Parameters("encoded_by").Value = rdr("encoded_by")
                    report.Parameters("prepared_by").Value = rdr("prepared_by")
                    report.Parameters("packed_by").Value = rdr("packed_by")
                    report.Parameters("released_by").Value = rdr("released_by")
                    report.Parameters("driver").Value = rdr("driver")
                End While
            End Using

            Using rdr = New MySqlCommand($"SELECT id, qty, rs_returns.type, ims_inventory.pid, ims_inventory.winmodel, issue, serial
                                         FROM rs_returns
                                         LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                         WHERE batch_id={batchID}", conn).ExecuteReader
                While rdr.Read
                    table.batch_units.Rows.Add(rdr("id"), rdr("qty"), rdr("pid"), rdr("winmodel"), rdr("serial"), rdr("type"), rdr("issue"))
                End While
            End Using

            report.RequestParameters = False
            report.DataSource = table
            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub



    '--- CONTROLS / EVENTS ----

    'COMBOBOX : SUPPLIER
    Private Sub cbb_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_supplier.SelectedIndexChanged
        If cbb_supplier.SelectedIndex >= 0 And cbb_warehouse.SelectedIndex >= 0 Then
            btn_submit.Enabled = True
            LoadUnits()
        Else
            btn_submit.Enabled = False
            grid_returns.DataSource = Nothing
        End If
    End Sub

    'COMBOBOX : WAREHOUSE
    Private Sub cbb_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_warehouse.SelectedIndexChanged
        If cbb_supplier.SelectedIndex >= 0 And cbb_warehouse.SelectedIndex >= 0 Then
            btn_submit.Enabled = True
            LoadUnits()
        Else
            btn_submit.Enabled = False
            grid_returns.DataSource = Nothing
        End If
    End Sub

    'BUTTON : ARRANGE
    Private Sub btn_arrange_Click(sender As Object, e As EventArgs) Handles btn_arrange.Click
        If MsgBox($"Batch be sent to Packaging Dept.{vbCrLf}Press 'Yes to confirm.'", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                conn.Open()
                Using trans = conn.BeginTransaction
                    Try
                        'UPDATE BATCH
                        Using cmd = New MySqlCommand($"UPDATE rs_returns_batch 
                                            SET status='Pending Arrangement', sent_by=@sent_by, sent_at=CURRENT_TIMESTAMP 
                                            WHERE batch_id={batch_id}", conn, trans)
                            cmd.Parameters.AddWithValue("@sent_by", frm_main.lbl_user_id.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        'UPDATE RETURNS
                        Using cmd = New MySqlCommand($"UPDATE rs_returns 
                                            SET status='Pending Arrangement' 
                                            WHERE batch_id={batch_id}", conn, trans)
                            cmd.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                        MsgBox("Sent!", vbInformation, "Information")
                        Me.Close()

                    Catch ex As Exception
                        trans.Rollback()
                        MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                    End Try
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    'BUTTON : SUBMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        Dim selectedRows = grid_returns_view.GetSelectedRows
        If Not selectedRows.Length = 0 Then
            If MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                Try
                    Dim batchID As Integer = 0

                    conn.Open()
                    Using trans = conn.BeginTransaction
                        Try
                            'INSERT TO BATC
                            Using cmd = New MySqlCommand("INSERT INTO rs_returns_batch 
                                                (status, supplier_id, warehouse_id, created_by, created_at) 
                                                VALUES ('Created', 
                                                        (SELECT id FROM ims_suppliers WHERE supplier=@supplier),
                                                        (SELECT store_id FROM ims_stores WHERE store_name=@warehouse),
                                                        @created_by, CURRENT_TIMESTAMP)", conn, trans)
                                cmd.Parameters.AddWithValue("@supplier", cbb_supplier.EditValue)
                                cmd.Parameters.AddWithValue("@warehouse", cbb_warehouse.EditValue)
                                cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                                If cmd.ExecuteNonQuery > 0 Then
                                    batchID = cmd.LastInsertedId
                                End If
                            End Using

                            'UPDATE RETURNS : SET BATCH ID AND STATUS
                            Using cmd = New MySqlCommand("UPDATE rs_returns 
                                                        SET status='Batched', batch_id=@batch_id 
                                                        WHERE id=@id", conn, trans)
                                cmd.Parameters.AddWithValue("@id", 0)
                                cmd.Parameters.AddWithValue("@batch_id", batchID)
                                cmd.Prepare()

                                For i = 0 To selectedRows.Length - 1
                                    cmd.Parameters("@id").Value = grid_returns_view.GetRowCellValue(selectedRows(i), col_id)
                                    cmd.ExecuteNonQuery()
                                Next
                            End Using

                            trans.Commit()
                            MsgBox("Submitted!", vbInformation, "Information")
                            Me.Close()

                        Catch ex As Exception
                            trans.Rollback()
                            MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                        End Try
                    End Using

                Catch ex As Exception
                    MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                Finally
                    conn.Close()
                End Try
            End If
        Else
            MsgBox("No selected rows!", vbCritical, "Reequired")
        End If
    End Sub

    'BUTTON : PRINT BATCH
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print_batch.Click
        PrintBatchPullout(batch_id)
    End Sub

    Private Sub btn_print_slip_Click(sender As Object, e As EventArgs) Handles btn_print_slip.Click
        PrintSupplierReturns(batch_id)
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Do you to delete this batch?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                conn.Open()
                Using trans = conn.BeginTransaction
                    Try
                        'UPDATE BATCH
                        Using cmd = New MySqlCommand($"UPDATE rs_returns_batch 
                                            SET status='Deleted', is_deleted=1
                                            WHERE batch_id={batch_id}", conn, trans)
                            cmd.Parameters.AddWithValue("@sent_by", frm_main.lbl_user_id.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        'UPDATE RETURNS
                        Using cmd = New MySqlCommand($"UPDATE rs_returns 
                                            SET status='For Approval', batch_id=NULL 
                                            WHERE batch_id={batch_id}", conn, trans)
                            cmd.ExecuteNonQuery()
                        End Using

                        trans.Commit()
                        MsgBox("Deleted!", vbInformation, "Information")
                        Me.Close()

                    Catch ex As Exception
                        trans.Rollback()
                        MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                    End Try
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

End Class