Imports MySql.Data.MySqlClient

Public Class frm_warehouse_stock_transfer_new

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ---
    Private Sub frm_warehouse_stock_transfer_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStore_List()
    End Sub



    '--- FUNCTIONS -----

    'Load Store List
    Private Sub LoadStore_List()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT store_name FROM ims_stores", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            Using rdr
                While rdr.Read
                    cbb_source.Properties.Items.Add(rdr("store_name"))
                    cbb_destination.Properties.Items.Add(rdr("store_name"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Store Stocks
    Public Sub LoadStoreUnits()

        Try
            conn.Open()

            Dim myIMS_store = "ims_" & cbb_source.Text.ToLower.Replace(" ", "_")
            Dim query = "SELECT ims_inventory.pid, qty, winmodel, description, location FROM ims_inventory 
                        INNER JOIN " & myIMS_store & " on ims_inventory.pid=" & myIMS_store & ".pid"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_sender.DataSource = dt


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub





    '--- CONTROLS ----

    'btn_transfer
    Private Sub btn_transfer_Click(sender As Object, e As EventArgs) Handles btn_transfer.Click

        If cbb_source.SelectedIndex = -1 Or cbb_destination.SelectedIndex = -1 Or grid_receiver.Rows.Count = 0 Then
            MsgBox("Complete all the required fields!", vbCritical, "Error")
            Exit Sub
        End If

        Try
            Dim ans = MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation")

            If ans = vbYes Then
                conn.Open()
                Dim transferred = ""

                'Update in Database | transfer to on_hold Column
                Dim source_store = "ims_" & cbb_source.Text.ToLower.Replace(" ", "_")

                'Get Items to Transfer
                For i = 0 To grid_receiver.Rows.Count - 1
                    If i = grid_receiver.Rows.Count - 1 Then
                        transferred += grid_receiver.Rows(i).Cells(0).Value & "=" & grid_receiver.Rows(i).Cells(3).Value & "=" & grid_receiver.Rows(i).Cells(4).Value
                        Continue For
                    End If
                    transferred += grid_receiver.Rows(i).Cells(0).Value & "=" & grid_receiver.Rows(i).Cells(3).Value & "=" & grid_receiver.Rows(i).Cells(4).Value & ";"
                Next

                'Insert in ims_transferred
                Dim query = "INSERT INTO ims_transferred_stocks (`src_store`, `receiver_store`, `units`, `date`, `status`, `transfer_by`) 
                        VALUES ((SELECT store_id FROM ims_stores WHERE store_name=@src_store),
                        (SELECT store_id FROM ims_stores WHERE store_name=@receiver_store), @units, CURRENT_TIMESTAMP, 'Pending', @user_id)"


                Dim cmd_transferred = New MySqlCommand(query, conn)
                cmd_transferred.Parameters.AddWithValue("@src_store", cbb_source.Text)
                cmd_transferred.Parameters.AddWithValue("@receiver_store", cbb_destination.Text)
                cmd_transferred.Parameters.AddWithValue("@units", transferred)
                cmd_transferred.Parameters.AddWithValue("@user_id", frm_main.user_id.Text)
                cmd_transferred.ExecuteNonQuery()

                MsgBox("Transfer Submitted! Waiting for Approval..", vbInformation, "Information")

                Me.Dispose()
                frm_main.LoadFrm(New frm_warehouse_stock_transfer)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        With grid_sender.CurrentRow

            If .Cells(1).Value <= 0 Then
                MsgBox("No Available Stocks!", vbCritical, "Forbidden")
                Exit Sub
            End If

            For i = 0 To grid_receiver.Rows.Count - 1

                If Equals(.Cells(0).Value, grid_receiver.Rows(i).Cells(0).Value) Then



                    If CInt(grid_receiver.Rows(i).Cells(3).Value < .Cells(1).Value) Then
                        grid_receiver.Rows(i).Cells(3).Value += 1
                    End If
                    Exit Sub
                End If
            Next

            grid_receiver.Rows.Add(.Cells(0).Value, .Cells(2).Value, .Cells(3).Value, 1)

        End With
    End Sub

    'btn_remove
    Private Sub btn_remove_Click(sender As Object, e As EventArgs) Handles btn_remove.Click
        Try
            If grid_receiver.Rows.Count >= 1 Then
                grid_receiver.Rows.RemoveAt(grid_receiver.CurrentRow.Index)
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Editing the value (Resstriction)
    Private Sub grid_receiver_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles grid_receiver.CellEndEdit

        For i = 0 To grid_sender.Rows.Count - 1
            If Equals(grid_receiver.CurrentRow.Cells(0).Value, grid_sender.Rows(i).Cells(0).Value) Then
                If grid_receiver.CurrentCell.Value > grid_sender.Rows(i).Cells(1).Value Or grid_receiver.CurrentCell.Value <= 0 Then
                    MsgBox("Insufficient stocks quantity. Check carefully!", vbExclamation, "Forbidden")
                    grid_receiver.CurrentCell.Value = 1
                End If
            End If
        Next

    End Sub

    'Cbb_source Selection && Load Units from the Store
    Private Sub cbb_source_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_source.SelectedIndexChanged
        If cbb_destination.SelectedIndex = cbb_source.SelectedIndex Then
            MsgBox("Forbidden! Must be different from the Destination.", vbCritical, "Error")
            cbb_destination.SelectedText = frm_main.user_store.Text
            Exit Sub
        End If

        LoadStoreUnits()
    End Sub

    'cbb_destination Change Index
    Private Sub cbb_destination_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbb_destination.SelectedIndexChanged
        If cbb_destination.SelectedIndex = cbb_source.SelectedIndex Then
            MsgBox("Forbidden! Must be different from the Source.", vbCritical, "Error")
            cbb_destination.SelectedIndex = -1
        End If
    End Sub

    'txt_Search
    Private Sub txt_search_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_search.KeyPress
        If e.KeyChar = ChrW(13) Then
            e.Handled = True

            Dim txtSearch = txt_search.Text.Trim
            Dim source_store = "ims_" & cbb_source.Text.ToLower.Replace(" ", "_")

            Try
                conn.Open()
                Dim query = "SELECT LPAD(ims_inventory.pid,6,0) as pid, qty, winmodel, description, location FROM ims_inventory INNER JOIN " _
                            & source_store & " on ims_inventory.pid=" & source_store & ".pid WHERE (winmodel LIKE @txtSearch) OR (description like @txtSearch)"
                Dim cmd = New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@txtSearch", "%" & txtSearch & "%")
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_sender.DataSource = dt


            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If cbb_source.SelectedIndex = -1 Or cbb_destination.SelectedIndex = -1 Or grid_receiver.Rows.Count = 0 Then
            MsgBox("Complete all the required fields!", vbCritical, "Error")
            Exit Sub
        End If

        Try
            Dim ans = MsgBox("Press 'Yes' to confirm.", vbYesNo + vbQuestion, "Confirmation")

            If ans = vbYes Then

                Using conn
                    conn.Open()
                    Dim transferred = ""

                    'Update in Database | transfer to on_hold Column
                    Dim source_store = "ims_" & cbb_source.Text.ToLower.Replace(" ", "_")

                    'Get Items to Transfer
                    For i = 0 To grid_receiver.Rows.Count - 1
                        If i = grid_receiver.Rows.Count - 1 Then
                            transferred += grid_receiver.Rows(i).Cells(0).Value & "=" & grid_receiver.Rows(i).Cells(3).Value & "=" & grid_receiver.Rows(i).Cells(4).Value
                            Continue For
                        End If
                        transferred += grid_receiver.Rows(i).Cells(0).Value & "=" & grid_receiver.Rows(i).Cells(3).Value & "=" & grid_receiver.Rows(i).Cells(4).Value & ";"
                    Next

                    'Insert in ims_transferred
                    Dim query = "UPDATE ims_transferred_stocks SET src_store=(SELECT store_id FROM ims_stores WHERE store_name=@src_store),
                            receiver_store=(SELECT store_id FROM ims_stores WHERE store_name=@receiver_store), 
                            units=@units, 
                            date=CURRENT_TIMESTAMP,
                            status='Pending', 
                            transfer_by=@user_id WHERE id=@id"

                    Dim cmd_transferred = New MySqlCommand(query, conn)
                    cmd_transferred.Parameters.AddWithValue("@src_store", cbb_source.Text)
                    cmd_transferred.Parameters.AddWithValue("@receiver_store", cbb_destination.Text)
                    cmd_transferred.Parameters.AddWithValue("@units", transferred)
                    cmd_transferred.Parameters.AddWithValue("@user_id", frm_main.user_id.Text)
                    cmd_transferred.Parameters.AddWithValue("@id", CInt(lbl_title.Text.Replace("Stock Transfer (ST", "").Replace(")", "")))
                    cmd_transferred.ExecuteNonQuery()

                End Using

                MsgBox("Save Successfully!.", vbInformation, "Information")

                Me.Dispose()
                frm_main.LoadFrm(New frm_warehouse_stock_transfer)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub
End Class