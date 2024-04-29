Imports MySqlConnector


Public Class frm_admin_transfer_reports


    '--- ONLOAD ---
    Private Sub frm_admin_transfer_reports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub




    '--- FUNCTIONS ----

    'For Receiving
    'Private Sub set_data_to_grid(units As String, received_units As String, grid As DataGridView)
    '    Try
    '        Using conn
    '            conn.Open()
    '            Dim cmd = New MySqlCommand("SELECT pid, winmodel, description FROM ims_inventory WHERE pid=@pid", conn)
    '            cmd.Parameters.AddWithValue("@pid", Nothing)
    '            cmd.Prepare()

    '            Dim units_arr = units.Split(";")
    '            Dim received_units_arr = received_units.Split(";")

    '            For i = 0 To units_arr.Length - 1

    '                Dim items = units_arr(i).Split("=")
    '                Dim received_items = received_units_arr(i).Split("=")

    '                cmd.Parameters(0).Value = items(0)
    '                Using rdr = cmd.ExecuteReader
    '                    While rdr.Read
    '                        grid.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), items(1), received_items(1), CInt(items(1)) - CInt(received_items(1)))
    '                    End While
    '                End Using
    '                If grid.Rows(i).Cells(5).Value > 0 Then grid.Rows(i).Cells(5).Style.BackColor = Color.IndianRed
    '                If grid.Rows(i).Cells(5).Value > 0 Then grid.Rows(i).Cells(5).Style.ForeColor = Color.White
    '            Next

    '        End Using

    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical, "Error")
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    'Load Transfer Report
    Private Sub LoadReport()
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Using cmd = New MySqlCommand("SELECT CONCAT('ST', LPAD(transfer_id, 5,0)) AS transfer_id, incident_report, ims_users.first_name AS reported_by, received_date AS reported_date, reported_units,
                                src_tbl.store_name AS src_storeName, des_tbl.store_name AS des_storeName
                                FROM ims_stock_transfer_reports
                                LEFT JOIN ims_users ON ims_users.usr_id=ims_stock_transfer_reports.received_by
                                LEFT JOIN ims_stores AS src_tbl ON src_tbl.store_id=ims_stock_transfer_reports.source_store_id
                                LEFT JOIN ims_stores AS des_tbl ON des_tbl.store_id=ims_stock_transfer_reports.destination_store_id
                                WHERE transfer_report_id=" & lbl_reportID.Text, connect)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            txt_transfer_id.Text = rdr("transfer_id")
                            txt_source.Text = rdr("src_storeName")
                            txt_destination.Text = rdr("des_storeName")
                            txt_report.Text = rdr("incident_report")
                            txt_reported_by.Text = rdr("reported_by")
                            txt_reported_date.Text = rdr("reported_date")

                            rb_src.Text += " " & rdr("src_storeName")
                            rb_dest.Text += " " & rdr("des_storeName")

                            SetToGrid(rdr("reported_units"))
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set To Grid
    Private Sub SetToGrid(units As String)
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Using cmd = New MySqlCommand("SELECT pid, winmodel, description FROM ims_inventory WHERE pid=@pid", connect)
                    cmd.Parameters.AddWithValue("@pid", Nothing)
                    cmd.Prepare()

                    Dim units_arr = units.Split(";")
                    For i = 0 To units_arr.Length - 1
                        Dim items = units_arr(i).Split("=")

                        cmd.Parameters(0).Value = items(0)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                grid_report.Rows.Add(rdr("pid"), rdr("winmodel"), rdr("description"), items(1))
                            End While
                        End Using

                    Next

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub




    'Public Sub load_report(id As Integer)
    '    Try
    '        Dim units = "", received_units = ""
    '        Using conn
    '            conn.Open()
    '            Dim cmd = New MySqlCommand("SELECT src.store_name AS src, dest.store_name AS dest, units, received_units, report_notes FROM ims_transferred_stocks
    '                    INNER JOIN ims_stores AS src ON src.store_id=src_store
    '                    INNER JOIN ims_stores AS dest ON dest.store_id=receiver_store WHERE id=" & id, conn)

    '            Using rdr = cmd.ExecuteReader
    '                rdr.Read()
    '                txt_transfer_id.Text = "ST" & id.ToString.PadLeft(5, "0"c)
    '                txt_source.Text = rdr("src")
    '                txt_destination.Text = rdr("dest")
    '                txt_report.EditValue = rdr("report_notes")
    '                units = rdr("units")
    '                received_units = rdr("received_units")
    '                rb_src.Text += " " & rdr("src")
    '                rb_dest.Text += " " & rdr("dest")
    '            End Using
    '        End Using

    '        set_data_to_grid(units, received_units, grid_report)

    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical, "Error")
    '    Finally
    '        conn.Close()
    '    End Try
    'End Sub

    'btn_apply

    Private Sub btn_apply_Click(sender As Object, e As EventArgs) Handles btn_apply.Click
        If rb_src.Checked = False And rb_dest.Checked = False And rb_zero.Checked = False Then
            MsgBox("Select Action to Resolve to continue.", vbCritical, "Required")
            Exit Sub
        End If

        If MsgBox("Press 'YES' to continue.", vbYesNo + vbInformation, "Confirmation") = vbYes Then
            Try

                Dim src_store = "ims_" & txt_source.Text.Trim.ToLower.Replace(" ", "_")
                Dim des_store = "ims_" & txt_destination.Text.Trim.ToLower.Replace(" ", "_")

                Dim reconcile_to_src = "UPDATE " & src_store & " SET qty=qty+@qty, on_hold=IFNULL(on_hold, 0)-@qty WHERE pid=@pid"
                Dim reconcile_to_destination = "INSERT INTO " & des_store & " (pid, qty) VALUES (@pid, @qty) ON DUPLICATE KEY UPDATE qty=qty+@qty; UPDATE " & src_store & " SET on_hold=IFNULL(on_hold, 0)-@qty WHERE pid=@pid"
                Dim reconcile_to_none = "UPDATE " & src_store & " SET on_hold=IFNULL(on_hold, 0)-@qty WHERE pid=@pid"
                Dim query = String.Empty, action_to_resolve = String.Empty

                If rb_src.Checked = True Then query = reconcile_to_src
                If rb_dest.Checked = True Then query = reconcile_to_destination
                If rb_zero.Checked = True Then query = reconcile_to_none

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    'UPDATE WAREHOUSE TABLE FOR STOCKS
                    Using cmd = New MySqlCommand(query, connect)
                        cmd.Parameters.AddWithValue("@pid", Nothing)
                        cmd.Parameters.AddWithValue("@qty", Nothing)
                        cmd.Prepare()

                        For i = 0 To grid_report.Rows.Count - 1
                            If grid_report.Rows(i).Cells(3).Value > 0 Then
                                cmd.Parameters(0).Value = grid_report.Rows(i).Cells(0).Value
                                cmd.Parameters(1).Value = grid_report.Rows(i).Cells(3).Value
                                cmd.ExecuteNonQuery()
                            End If
                        Next
                    End Using

                    If rb_src.Checked = True Then action_to_resolve = rb_src.Text
                    If rb_dest.Checked = True Then action_to_resolve = rb_dest.Text
                    If rb_zero.Checked = True Then action_to_resolve = rb_zero.Text

                    'UPDATE Transfer Report
                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer_reports 
                                                SET status='Resolved', action_to_resolve=@action_to_resolve, action_taken_by=@action_taken_by
                                                WHERE transfer_report_id=@id", connect)
                        cmd.Parameters.AddWithValue("@id", CInt(lbl_reportID.Text))
                        cmd.Parameters.AddWithValue("@action_to_resolve", action_to_resolve)
                        cmd.Parameters.AddWithValue("@action_taken_by", frm_main.lbl_user_id.Text)
                        cmd.ExecuteNonQuery()
                    End Using

                End Using

                MsgBox("Successfully Resolve!", vbInformation, "Information")
                Me.Close()

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If


    End Sub


End Class