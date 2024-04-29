Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_warehouse_returns_receive


    Private Sub frm_warehouse_returns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_data()
    End Sub



    '--- FUNCTIONS ----

    'Load Data
    Private Sub load_data()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Dim dt = New DataTable
                dt.Columns.Add("qty", GetType(Decimal))
                dt.Columns.Add("pid", GetType(Integer))
                dt.Columns.Add("winmodel", GetType(String))
                dt.Columns.Add("description", GetType(String))

                Using cmd = New MySqlCommand("SELECT units, notes
                                       FROM ims_sales_returns
                                       WHERE sales_return_id=@srid", conn)
                    cmd.Parameters.AddWithValue("@srid", CInt(txt_srid.Text.Replace("SR", String.Empty)))
                    Using rdr = cmd.ExecuteReader

                        rdr.Read()
                        txt_notes.EditValue = rdr("notes")

                        'Set Items to Grid
                        Dim itemsObject = JsonConvert.DeserializeObject(Of List(Of SalesReturnClass))(rdr("units"))
                        For Each item In itemsObject
                            dt.Rows.Add(item.qty, item.pid, item.model, item.description)
                        Next
                    End Using

                    grid_returns.DataSource = dt

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub



    '--- CONTROLS ---

    Private Sub btn_received_Click(sender As Object, e As EventArgs) Handles btn_received.Click

        If MsgBox("You are about to receive these items." & vbNewLine & "Press 'YES' to confirm.", vbInformation + vbYesNo, "Confirmation") = vbYes Then

            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Dim counter = 0
                    For i = 0 To grid_returns_view.RowCount - 1
                        'INSERT/UPDATE TO SOURCE STORE
                        Dim destination_store = "ims_" & txt_warehouse.Text.ToLower.Replace(" ", "_")
                        Using cmd_add_to_qty = New MySqlCommand("INSERT INTO " & destination_store & " (`pid`, `qty`) VALUES (@pid,@qty) ON DUPLICATE KEY UPDATE qty=qty+@qty", conn)
                            cmd_add_to_qty.Parameters.AddWithValue("@pid", grid_returns_view.GetRowCellValue(i, col_pid))
                            cmd_add_to_qty.Parameters.AddWithValue("@qty", grid_returns_view.GetRowCellValue(i, col_qty))
                            If cmd_add_to_qty.ExecuteNonQuery() > 0 Then
                                counter += 1
                            End If
                        End Using
                    Next

                    'Update Sales Return ID
                    If counter = grid_returns_view.RowCount Then
                        Using cmd_update_sr = New MySqlCommand("UPDATE ims_sales_returns SET status='Received', received_by=@user, received_at=NOW() WHERE sales_return_id=@srid", conn)
                            cmd_update_sr.Parameters.AddWithValue("@user", frm_main.lbl_user_id.Text)
                            cmd_update_sr.Parameters.AddWithValue("@srid", CInt(txt_srid.Text.Replace("SR", String.Empty)))
                            If cmd_update_sr.ExecuteNonQuery > 0 Then
                                MsgBox("Submitted!" & vbNewLine & "Handover the stock to " & txt_warehouse.Text & ".", vbInformation, "Information")
                                Me.Close()

                                'Dim frm = New frm_warehouse_receivingManagement
                                'frm_main.LoadFrm(frm)
                                'frm.tab_control.SelectedTabPage = frm.tab_sales_return
                                'frm.load_sales_returns()
                                Me.Close()
                            End If
                        End Using
                    End If

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

    End Sub

End Class