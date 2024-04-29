Imports MySqlConnector
Imports OfficeOpenXml
Imports System.IO
Imports System.Text

Public Class frm_warehouse_import

    Private Property selected_warehouse As String = String.Empty
    Private Property uploading = False
    Private Property error_lines = String.Empty
    Dim rows_count As Integer = 0



    'FUNCTIONS
    Private Sub DoBackup(warehouse As String, path As String)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT ims_inventory.pid 'PID', ims_inventory.winmodel 'MODEL', qty 'QTY', location 'LOCATION 1', location_2 'LOCATION 2', zone 'ZONE'
                                FROM " & warehouse & " AS tbl_def
                                LEFT JOIN ims_inventory ON ims_inventory.pid=tbl_def.pid", conn)

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    Dim fileContent = New StringBuilder

                    For Each col As DataColumn In dt.Columns
                        fileContent.Append(col.ColumnName & ",")
                    Next

                    fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1)

                    For Each row As DataRow In dt.Rows

                        For Each cell As Object In row.ItemArray
                            fileContent.Append(cell.ToString.Trim & ",")
                        Next

                        fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1)

                    Next

                    File.WriteAllText(path, fileContent.ToString)

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "An orer occured!")
        End Try
    End Sub




    Private Sub btn_choose_Click(sender As Object, e As EventArgs) Handles btn_choose.Click

        Dim fd = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.Filter = "Excel file |*.xls;*.xlsx"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txt_path.Text = fd.FileName
        End If

    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import.Click

        If cbb_warehouse.SelectedIndex = -1 Or String.IsNullOrWhiteSpace(cbb_warehouse.Text) Then
            MsgBox("Select target warehouse!", vbCritical, "Incomplete")
            Return
        End If

        If Not String.IsNullOrWhiteSpace(txt_path.Text) Then
            If MsgBox("Click 'Yes' to continue.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                selected_warehouse = "ims_" & cbb_warehouse.EditValue.ToString.Trim.Replace(" ", "_").ToLower

                'PROMPT TO BACK UP
                If MsgBox("Do you want to make backup for target warehouse first?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                    Using sfd = New SaveFileDialog
                        sfd.Filter = "CSV File (*.csv*)|*.csv"
                        If sfd.ShowDialog = DialogResult.OK Then
                            DoBackup(selected_warehouse, sfd.FileName)
                        End If
                    End Using
                End If


                uploading = True
                txt_status.Text = String.Empty
                error_lines = String.Empty
                btn_import.Enabled = False
                BackgroundWorker.RunWorkerAsync()

            End If
        Else
            MsgBox("Select file to upload!", vbCritical, "Required")
        End If

    End Sub





    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Import()
    End Sub

    'Import from XLSX (Excel)
    Private Sub Import()

        Try
            'Get PATH
            Dim path = String.Empty
            If txt_path.InvokeRequired Then
                txt_path.Invoke(
                    Sub()
                        path = txt_path.Text
                    End Sub)
            Else
                path = txt_path.Text
            End If

            Dim into_value As String = "pid"
            Dim values As String = "@pid"
            Dim on_duplicate As String = "pid=@pid"

            If ce_qty.Checked = True Then
                into_value += ", qty"
                values += ", @qty"
                on_duplicate += ", qty=@qty"
            End If
            If ce_loc1.Checked = True Then
                into_value += ", location"
                values += ", @location"
                on_duplicate += ", location=@location"
            End If
            If ce_loc2.Checked = True Then
                into_value += ", location_2"
                values += ", @location_2"
                on_duplicate += ", location_2=@location_2"
            End If
            If ce_zone.Checked = True Then
                into_value += ", zone"
                values += ", @zone"
                on_duplicate += ", zone=@zone"
            End If


            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "INSERT INTO " & selected_warehouse & " (" & into_value & ") 
                        VALUES (" & values & ")
                        ON DUPLICATE KEY UPDATE " & on_duplicate

                Using insert_cmd = New MySqlCommand(query, connection)
                    insert_cmd.Parameters.AddWithValue("@pid", 0)
                    If ce_qty.Checked = True Then insert_cmd.Parameters.AddWithValue("@qty", 0)
                    If ce_loc1.Checked = True Then insert_cmd.Parameters.AddWithValue("@location", String.Empty)
                    If ce_loc2.Checked = True Then insert_cmd.Parameters.AddWithValue("@location_2", String.Empty)
                    If ce_zone.Checked = True Then insert_cmd.Parameters.AddWithValue("@zone", String.Empty)
                    insert_cmd.Prepare()

                    'Loading Excel File
                    Dim counts = 0
                    uploading = True
                    txt_status.Text = String.Empty
                    error_lines = String.Empty
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial
                    Using package = New ExcelPackage(New FileInfo(path))

                        'Get WorkSheet
                        Dim WorkSheet = package.Workbook.Worksheets(0)

                        'Set Maximum Rows to Progressbar.Maximum
                        If txt_path.InvokeRequired Then
                            txt_path.Invoke(Sub() ProgressBar.Properties.Maximum = WorkSheet.Dimension.End.Row - 1)
                        Else
                            ProgressBar.Properties.Maximum = WorkSheet.Dimension.End.Row - 1
                        End If

                        rows_count = WorkSheet.Dimension.End.Row - 1

                        'Insert Value From WorkSheet
                        For i = WorkSheet.Dimension.Start.Row + 1 To WorkSheet.Dimension.End.Row

                            'Skip If incomplete details
                            If String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 1).Value) _  'PID
                                Then
                                counts += 1
                                error_lines += "Line " & counts & vbCrLf
                                Continue For
                            End If

                            insert_cmd.Parameters(0).Value = WorkSheet.Cells(i, 1).Value 'PID
                            If ce_qty.Checked = True Then insert_cmd.Parameters("@qty").Value = IIf(String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 3).Value), 0.00, WorkSheet.Cells(i, 3).Value) 'QTY
                            If ce_loc1.Checked = True Then insert_cmd.Parameters("@location").Value = WorkSheet.Cells(i, 4).Value 'Location 1
                            If ce_loc2.Checked = True Then insert_cmd.Parameters("@location_2").Value = WorkSheet.Cells(i, 5).Value 'Location 2
                            If ce_zone.Checked = True Then insert_cmd.Parameters("@zone").Value = WorkSheet.Cells(i, 6).Value 'Zone

                            insert_cmd.ExecuteNonQuery()

                            'Clear Parameter Values
                            For Each parameter As MySqlParameter In insert_cmd.Parameters
                                parameter.Value = Nothing
                            Next

                            counts += 1
                            BackgroundWorker.ReportProgress(counts)

                        Next

                    End Using 'End ExcelPackage

                End Using 'End MySqlCommand
            End Using 'End MySqlConnection

        Catch ex As Exception
            MsgBox("Failed to Upload." & vbCrLf & vbCrLf & ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged

        txt_status.Text += "Processing row " & e.ProgressPercentage & " out of " & rows_count & " rows" & vbCrLf
        txt_status.SelectionStart = txt_status.Text.Length
        txt_status.ScrollToCaret()
        ProgressBar.EditValue = e.ProgressPercentage

    End Sub

    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        If e.Cancelled = True Then
            MsgBox("Operation has been cancelled!", vbInformation, "Operation")
            uploading = False

        ElseIf e.Error IsNot Nothing Then
            MsgBox(e.Error.Message, vbCritical, "Operation")
            uploading = False

        Else
            uploading = False

            If Not String.IsNullOrEmpty(error_lines) Then
                txt_status.AppendText(vbCrLf & "Lines didn't processed:" & vbCrLf & error_lines & vbCrLf & vbCrLf)
            End If


            MsgBox("Upload Complete!", vbInformation, "Success")
        End If

        btn_import.Enabled = True

    End Sub

    Private Sub frm_warehouse_import_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If uploading = True Then
            Dim ans = MsgBox("Importing is still in progress. " & vbCrLf & "Do you still want to cancel?", vbQuestion + vbYesNo, "Confirmation")

            If ans = vbYes Then
                If BackgroundWorker.WorkerSupportsCancellation = True Then
                    BackgroundWorker.CancelAsync()
                End If
                e.Cancel = False
            Else
                e.Cancel = True
            End If

        End If
    End Sub

    Private Sub btn_download_Click(sender As Object, e As EventArgs) Handles btn_download.Click

        Using sfd As New SaveFileDialog
            With sfd
                .AddExtension = True
                .DefaultExt = ".xlsx"
                .Filter = "Microsoft Excel (*.xlsx)|*.xlsx"
                .FilterIndex = 1
                .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
                .Title = "Select The Location To Save This PDF File"
                .ValidateNames = True
            End With

            If sfd.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(sfd.FileName, My.Resources.Inventory_Template, False)
            End If
        End Using

    End Sub

    '>>> ONLOAD
    Private Sub frm_warehouse_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetWarehouseList()
    End Sub

    'LIST WAREHOUSE TO COMBOBOX
    Private Sub GetWarehouseList()
        Using conn = New MySqlConnection(str)
            conn.Open()
            Using cmd = New MySqlCommand("SELECT * FROM ims_stores", conn)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        cbb_warehouse.Properties.Items.Add(rdr("store_name"))
                    End While
                End Using
            End Using
        End Using
    End Sub

    'BUTTON : CANCEL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'CheckEdit = TRUE
    Private Sub ce_qty_CheckedChanged(sender As Object, e As EventArgs) Handles ce_qty.CheckedChanged
        If ce_qty.Checked = True Then
            MsgBox("Warning!" & Environment.NewLine & "It will overwrite existing stocks." & Environment.NewLine & "Proceed with caution.", vbExclamation, "Warning")
        End If
    End Sub
End Class