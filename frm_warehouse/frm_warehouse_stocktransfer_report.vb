Imports MySqlConnector

Public Class frm_warehouse_stocktransfer_report


    '--- FUNCTIONS ---

    Private Function GetReportedUnits() As String
        Dim units = String.Empty

        For i = 0 To grid_transfer_report_view.RowCount - 1
            If i = 0 Then
                units += grid_transfer_report_view.GetRowCellValue(i, col_pid) & "=" & grid_transfer_report_view.GetRowCellValue(i, col_missing)
                Continue For
            End If
            units += ";" & grid_transfer_report_view.GetRowCellValue(i, col_pid) & "=" & grid_transfer_report_view.GetRowCellValue(i, col_missing)
        Next

        Return units

    End Function



    '--- CONTROLS ---
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click

        'Validation
        If String.IsNullOrWhiteSpace(txt_report_notes.Text) Then
            MsgBox("Oops! Incident report MUST have value.", vbCritical, "Required")
            Exit Sub
        End If

        Try
            Using connect = New MySqlConnection(str)
                connect.Open()
                Using cmd = New MySqlCommand("INSERT INTO ims_stock_transfer_reports 
                                    (transfer_id, source_store_id, destination_store_id, reported_units, received_by, received_date, status, incident_report)
                             VALUES (@transfer_id, (SELECT store_id FROM ims_stores WHERE store_name=@source_store),
                                     (SELECT store_id FROM ims_stores WHERE store_name=@destination_store), @reported_units, @received_by, @received_date, @status, @incident_report)", connect)

                    cmd.Parameters.AddWithValue("@transfer_id", CInt(txt_stock_transfer_id.Text.Replace("ST", String.Empty)))
                    cmd.Parameters.AddWithValue("@source_store", txt_source.Text.Trim)
                    cmd.Parameters.AddWithValue("@destination_store", txt_destination.Text.Trim)
                    cmd.Parameters.AddWithValue("@reported_units", GetReportedUnits())
                    cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                    cmd.Parameters.AddWithValue("@received_date", Date.Now())
                    cmd.Parameters.AddWithValue("@status", "Pending")
                    cmd.Parameters.AddWithValue("@incident_report", txt_report_notes.Text.Trim)
                    cmd.ExecuteNonQuery()

                    MsgBox("Incident Report has been submitted!", vbInformation, "Information")
                    Me.Close()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class