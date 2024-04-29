Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_stock_return_pullout

    ReadOnly conn As New MySqlConnection(str)
    Public Property Pullout_id As Integer = 0

    '--- ONLOAD ---
    Private Sub frm_purchase_return_pullout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cbb_supplier.Properties.Items.Count = 0 Then
            PopulateComboBoxes()
        End If
        btn_create.Enabled = False
    End Sub



    '--- FUNCTIONS ---

    'LOAD TO EDIT/VIEW
    Public Sub LoadEdit(id As String)
        Pullout_id = id
        lbl_title.Text = $"Pullout Request #{id}"
        Me.Text = $"Pullout Request #{id}"

        Try
            conn.Open()

            'GET PULLOUT REQUEST STATUS AND UPDATE GUI
            Using cmd = New MySqlCommand($"SELECT status, ims_suppliers.supplier, ims_stores.store_name, comments
                                        FROM rs_returns_pullout 
                                        LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_pullout.supplier_id
                                        LEFT JOIN ims_stores ON ims_stores.store_id=rs_returns_pullout.warehouse_id
                                        WHERE pullout_id={id}", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read

                        Select Case rdr("status")
                            Case "Sent"
                                btn_sent.Enabled = False
                                btn_delete.Enabled = False
                        End Select

                        lbl_status.Text = rdr("status")
                        cbb_supplier.EditValue = rdr("supplier")
                        cbb_warehouse.EditValue = rdr("store_name")
                        txt_comments.EditValue = rdr("comments")

                    End While
                End Using
            End Using

            'GET UNITS FROM RETRUNS
            Using cmd = New MySqlCommand($"SELECT qty, ims_inventory.pid, ims_inventory.winmodel, ims_inventory.supmodel, ims_inventory.description, serial, rs_returns.type, issue, rs_returns.id
                                        FROM rs_returns 
                                        LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                        WHERE pullout_id={id}", conn)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_returns.DataSource = dt
            End Using

            cbb_supplier.Properties.ReadOnly = True
            cbb_warehouse.Properties.ReadOnly = True
            btn_create.Visible = False
            grid_returns_view.OptionsSelection.MultiSelect = False

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

    'LOAD UNITS
    Private Sub LoadUnits()
        Try
            If conn.State = ConnectionState.Open Then conn.Close()
            conn.Open()
            Using cmd = New MySqlCommand("SELECT id, qty, rs_returns.pid, ims_inventory.winmodel, ims_inventory.supmodel, serial, rs_returns.type, issue
                                            FROM rs_returns
                                            INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            INNER JOIN ims_stores ON ims_stores.store_id=rs_returns.src_warehouse_id
                                            WHERE approval_winland='Approved' AND approval_supplier='Pending' AND rs_returns.is_deleted='0' 
                                                AND supplier_id=(SELECT id FROM ims_suppliers WHERE supplier=@supplier) AND
                                                ims_stores.store_name=@warehouse", conn)
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

    'PRINT PULLOUT REQUEST
    Public Sub PrintPulloutRequest()
        Dim report = New doc_pullout_request
        Dim table = New PrintData

        Try
            If conn.State = ConnectionState.Open Then conn.Close()

            conn.Open()
            Dim query = $"SELECT pullout_id, status, comments, ims_users.first_name AS requested_by, ims_stores.store_addr AS warehouse_addr, ims_stores.store_name AS warehouse_name, ims_suppliers.supplier,
                        (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, (SELECT value FROM ims_settings WHERE name='store_info') as store_info,
                        (SELECT VALUE FROM ims_settings WHERE NAME='pullout_instruction') AS pullout_instruction
                        FROM rs_returns_pullout
                        LEFT JOIN ims_users ON ims_users.usr_id=rs_returns_pullout.created_by
                        LEFT JOIN ims_stores ON ims_stores.store_id=rs_returns_pullout.warehouse_id
                        LEFT JOIN ims_suppliers ON ims_suppliers.id=rs_returns_pullout.supplier_id
                        WHERE pullout_id={Pullout_id}"
            Using rdr = New MySqlCommand(query, conn).ExecuteReader
                While rdr.Read
                    report.Parameters("store_name").Value = rdr("store_name")
                    report.Parameters("store_info").Value = rdr("store_info") & vbCrLf & "Email: purchasing@winlandene.com"
                    report.Parameters("pullout_request_instruction").Value = rdr("pullout_instruction")

                    report.Parameters("pullout_id").Value = rdr("pullout_id")
                    report.Parameters("request_date").Value = Date.Now
                    report.Parameters("requested_by").Value = rdr("requested_by")

                    report.Parameters("supplier").Value = rdr("supplier")
                    report.Parameters("warehouse_name").Value = rdr("warehouse_name")
                    report.Parameters("warehouse_addr").Value = rdr("warehouse_addr")

                    report.Parameters("comments").Value = rdr("comments")
                End While
            End Using

            Using rdr = New MySqlCommand($"SELECT id, qty, rs_returns.type, ims_inventory.supmodel, issue, serial
                                         FROM rs_returns
                                         LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                         WHERE pullout_id={Pullout_id}", conn).ExecuteReader
                While rdr.Read
                    table.pullout_units.Rows.Add(rdr("qty"), rdr("type"), rdr("supmodel"), rdr("serial"), rdr("issue"), rdr("id"))
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




    '--- CONTROLS / EVENTS ---

    'COMBOBOX : SUPPLIER
    Private Sub cbb_supplier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_supplier.SelectedIndexChanged
        If cbb_supplier.SelectedIndex >= 0 And cbb_warehouse.SelectedIndex >= 0 Then
            LoadUnits()
        Else
            grid_returns.DataSource = Nothing
        End If
    End Sub

    'COMBOBOX : WAREHOUSE
    Private Sub cbb_warehouse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_warehouse.SelectedIndexChanged
        If cbb_supplier.SelectedIndex >= 0 And cbb_warehouse.SelectedIndex >= 0 Then
            LoadUnits()
        Else
            grid_returns.DataSource = Nothing
        End If
    End Sub

    'BUTTON : CREATE
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If MsgBox("Press 'Yes' to submit.", vbYesNo + vbQuestion, "Are you sure?") = vbYes Then

            Dim is_success As Boolean = False

            Try
                conn.Open()
                Using transac = conn.BeginTransaction
                    Try
                        Dim pulloutID As Integer = 0

                        'INSERT TO NEW PULLOUT
                        Using cmd_insertPullout = New MySqlCommand("INSERT INTO rs_returns_pullout (status, supplier_id, warehouse_id, comments, created_by, created_at) 
                                                            VALUES (@status, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), (SELECT store_id FROM ims_stores WHERE store_name=@warehouse), @comments, @created_by, CURRENT_TIMESTAMP)", conn, transac)
                            cmd_insertPullout.Parameters.AddWithValue("@status", "Created")
                            cmd_insertPullout.Parameters.AddWithValue("@supplier", cbb_supplier.EditValue.ToString)
                            cmd_insertPullout.Parameters.AddWithValue("@warehouse", cbb_warehouse.EditValue.ToString)
                            cmd_insertPullout.Parameters.AddWithValue("@comments", IIf(String.IsNullOrWhiteSpace(txt_comments.EditValue), Nothing, txt_comments.EditValue))
                            cmd_insertPullout.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                            If cmd_insertPullout.ExecuteNonQuery() > 0 Then
                                pulloutID = cmd_insertPullout.LastInsertedId
                            End If
                        End Using

                        'UPDATE RETURNS : SET PULLOUT ID
                        Dim selected_rows = grid_returns_view.GetSelectedRows
                        Using cmd_updateReturns = New MySqlCommand("UPDATE rs_returns SET pullout_id=@pullout_id WHERE id=@id", conn, transac)
                            cmd_updateReturns.Parameters.AddWithValue("@id", 0)
                            cmd_updateReturns.Parameters.AddWithValue("@pullout_id", pulloutID)
                            cmd_updateReturns.Prepare()

                            For i = 0 To selected_rows.Length - 1
                                cmd_updateReturns.Parameters("@id").Value = grid_returns_view.GetRowCellValue(selected_rows(i), col_id)
                                cmd_updateReturns.ExecuteNonQuery()
                            Next

                        End Using

                        transac.Commit()
                        MsgBox("Created!", vbInformation, "Information")
                        is_success = True

                    Catch ex As Exception
                        transac.Rollback()
                        MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                    End Try

                End Using
            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try

            If is_success = True Then Me.Close()
        End If
    End Sub

    'BUTTON : DELETE
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Are you sure you want to delete?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                conn.Open()
                Using cmd = New MySqlCommand($"UPDATE rs_returns 
                                            SET status='Pending', pullout_id=NULL
                                            WHERE pullout_id={Pullout_id};
                                            UPDATE rs_returns_pullout SET status='Deleted', is_deleted='1'
                                            WHERE pullout_id={Pullout_id}", conn)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Deleted!", vbInformation, "Information")
                        Me.Close()
                    End If
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    'BUTTON : PRINT REQUEST
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        PrintPulloutRequest()
    End Sub

    'BUTTON : SEND TO SUPPLIER
    Private Sub btn_sent_Click(sender As Object, e As EventArgs) Handles btn_sent.Click
        If MsgBox($"Mark as 'Sent'?{vbCrLf}Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                conn.Open()

                Using transc = conn.BeginTransaction
                    Try
                        'UPDATE PULLOUT REQUEST TO 'SENT'
                        Using cmd = New MySqlCommand("UPDATE rs_returns_pullout 
                                                        SET status='Sent', sent_by=@sent_by, sent_at=CURRENT_TIMESTAMP
                                                        WHERE pullout_id=@pullout_id", conn, transc)
                            cmd.Parameters.AddWithValue("@pullout_id", Pullout_id)
                            cmd.Parameters.AddWithValue("@sent_by", frm_main.lbl_user_id.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        'UPDATE RETURNS
                        Using cmd_updateReturns = New MySqlCommand("UPDATE rs_returns SET approval_supplier='Sent' WHERE pullout_id=@pullout_id", conn, transc)
                            cmd_updateReturns.Parameters.AddWithValue("@pullout_id", Pullout_id)
                            If cmd_updateReturns.ExecuteNonQuery() > 0 Then
                                transc.Commit()
                                MsgBox("Sent!", vbInformation, "Information")
                                Me.Close()
                            End If
                        End Using

                    Catch ex As Exception
                        transc.Rollback()
                        MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
                    End Try
                End Using

                PrintPulloutRequest()

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    Private Sub grid_returns_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_returns_view.SelectionChanged
        If grid_returns_view.GetSelectedRows.Length = 0 Then
            btn_create.Enabled = False
        Else
            btn_create.Enabled = True
        End If
    End Sub


#Region "OBSOLETE"

    'BUTTON : APPROVED
    Private Sub btn_approved_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure? (Approved)", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                conn.Open()
                Using cmd = New MySqlCommand($"UPDATE rs_returns_pullout 
                                            SET status='Approved', approved_date=CURRENT_TIMESTAMP, approved_by=@approved_by
                                            WHERE pullout_id={Pullout_id}", conn)
                    cmd.Parameters.AddWithValue("@approved_by", frm_main.lbl_user_id.Text)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Approved!", vbInformation, "Information")
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub

    'BUTTON : DECLINE
    Private Sub btn_decline_Click(sender As Object, e As EventArgs)
        If MsgBox("Are you sure? (Decline)", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                conn.Open()
                Using cmd = New MySqlCommand($"UPDATE rs_returns_pullout 
                                            SET status='Declined' 
                                            WHERE pullout_id={Pullout_id}", conn)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Declined!", vbInformation, "Information")
                        Me.DialogResult = DialogResult.OK
                        Me.Close()
                    End If
                End Using

            Catch ex As Exception
                MsgBox($"An error occured: {vbCrLf & vbCrLf & ex.Message}", vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If
    End Sub



#End Region

End Class