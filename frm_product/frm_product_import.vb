Imports System.IO

Imports MySqlConnector
Imports OfficeOpenXml

Public Class frm_product_import

    ReadOnly conn As New MySqlConnection(str)
    Dim rows_count As Integer = 0
    Private Property one_percent = 0
    Private Property counter = 0
    Private Property uploading = False
    Private Property error_lines = ""



    '--- ON LOAD -----
    Private Sub frm_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_status.Text = ""
        ProgressBar.Value = 0
    End Sub




    '--- Controls -----


    'btn_select
    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_choose.Click

        Dim fd = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        'fd.Filter = "CSV file (*.csv)|*.csv"
        fd.Filter = "Excel file |*.xls;*.xlsx"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            txt_path.Text = fd.FileName
        End If

    End Sub

    'btn_import
    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        If Not String.IsNullOrWhiteSpace(txt_path.Text) Then
            Dim ans = MsgBox("Click 'Yes' to continue.", vbQuestion + vbYesNo, "Confirmation")

            If ans = vbYes Then

                'Try
                '    'Stream Data from CSV
                '    Dim csvData As String = File.ReadAllText(txt_path.Text)
                '    'rows_count = csvData.Split(ControlChars.Lf)
                'Catch ex As Exception
                '    MsgBox(ex.Message, vbCritical, "Error")
                '    Exit Sub
                'End Try

                uploading = True
                'ProgressBar.Maximum = rows_count.Length - 1
                txt_status.Text = ""
                error_lines = ""
                btn_upload.Enabled = False
                BackgroundWorker.RunWorkerAsync()

            End If
        End If

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


            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "INSERT INTO ims_inventory (pid, barcode, winmodel, supmodel, description, technical_description, main_category, sub_category, brand, type, tags, base_price, cost, discount, regular_price, dealer_price, vip_price, length, width, height, weight, hazards, status, supplier, serialized, qty_per_box, masterbox_qty, min_order_qty, ideal_stock, warning_stock, stock_duration, warranty_period, warranty_coverage, date_entry) 
                        VALUES (@pid, @barcode, @winmodel, @supmodel, @description, @technical_description, @main_category, @sub_category, @brand, @type, @tags, @base_price, @cost, @discount, @regular_price, @dealer_price, @vip_price, @length, @width, @height, @weight, @hazards, @status, @supplier, @serialized, @qty_per_box, @masterbox_qty, @min_order_qty, @ideal_stock, @warning_stock, @stock_duration, @warranty_period, @warranty_coverage, @date_entry)
                        ON DUPLICATE KEY UPDATE barcode=@barcode, winmodel=@winmodel, supmodel=@supmodel, description=@description, technical_description=@technical_description, main_category=@main_category, sub_category=@sub_category, brand=@brand, type=@type, tags=@tags, base_price=@base_price, cost=@cost, discount=@discount, regular_price=@regular_price, dealer_price=@dealer_price, vip_price=@vip_price,
                        length=@length, width=@width, height=@height, weight=@weight, hazards=@hazards, status=@status, supplier=@supplier, serialized=@serialized, qty_per_box=@qty_per_box, masterbox_qty=@masterbox_qty, min_order_qty=@min_order_qty, ideal_stock=@ideal_stock, warning_stock=@warning_stock, stock_duration=@stock_duration, warranty_period=@warranty_period, warranty_coverage=@warranty_coverage, date_entry=@date_entry"
                Using insert_cmd = New MySqlCommand(query, connection)
                    insert_cmd.Parameters.AddWithValue("@pid", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@barcode", Nothing)
                    insert_cmd.Parameters.AddWithValue("@winmodel", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@supmodel", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@supplier", 0)
                    insert_cmd.Parameters.AddWithValue("@description", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@technical_description", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@main_category", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@sub_category", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@brand", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@type", Nothing)
                    insert_cmd.Parameters.AddWithValue("@tags", String.Empty)
                    insert_cmd.Parameters.AddWithValue("@status", "Inactive")
                    insert_cmd.Parameters.AddWithValue("@base_price", 0.00)
                    insert_cmd.Parameters.AddWithValue("@cost", 0.00)
                    insert_cmd.Parameters.AddWithValue("@discount", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@regular_price", 0.00)
                    insert_cmd.Parameters.AddWithValue("@dealer_price", 0.00)
                    insert_cmd.Parameters.AddWithValue("@vip_price", 0.00)
                    insert_cmd.Parameters.AddWithValue("@length", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@width", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@height", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@weight", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@hazards", Nothing)
                    insert_cmd.Parameters.AddWithValue("@serialized", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@qty_per_box", Nothing)
                    insert_cmd.Parameters.AddWithValue("@masterbox_qty", Nothing)
                    insert_cmd.Parameters.AddWithValue("@min_order_qty", Nothing)
                    insert_cmd.Parameters.AddWithValue("@ideal_stock", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@warning_stock", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@stock_duration", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@warranty_period", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@warranty_coverage", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@date_entry", Nothing)
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
                            txt_path.Invoke(Sub() ProgressBar.Maximum = WorkSheet.Dimension.End.Row - 1)
                        Else
                            ProgressBar.Maximum = WorkSheet.Dimension.End.Row - 1
                        End If

                        rows_count = WorkSheet.Dimension.End.Row - 1

                        'Insert Value From WorkSheet
                        For i = WorkSheet.Dimension.Start.Row + 1 To WorkSheet.Dimension.End.Row

                            'Skip If incomplete details
                            If String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 1).Value) _  'PID
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 3).Value) _ 'winmodel
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 4).Value) _  'supmodel
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 5).Value) _  'supid
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 6).Value) _  'description
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 8).Value) _  'main_category
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 9).Value) _  'sub_category
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 10).Value) _  'brand
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 13).Value) _ 'status
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 14).Value) _ 'base PricValuee
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 15).Value) _ 'cost
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 17).Value) _ 'regular_price
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 18).Value) _ 'dealer_price 
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 19).Value) _ 'vip_price
                                Then
                                counts += 1
                                error_lines += "Line " & counts & vbCrLf
                                Continue For
                            End If

                            insert_cmd.Parameters(0).Value = WorkSheet.Cells(i, 1).Value 'PID
                            insert_cmd.Parameters(1).Value = WorkSheet.Cells(i, 2).Value 'Barcode
                            insert_cmd.Parameters(2).Value = WorkSheet.Cells(i, 3).Value 'WinModel
                            insert_cmd.Parameters(3).Value = WorkSheet.Cells(i, 4).Value 'SupModel
                            insert_cmd.Parameters(4).Value = WorkSheet.Cells(i, 5).Value 'Supplier ID
                            insert_cmd.Parameters(5).Value = WorkSheet.Cells(i, 6).Value 'Description
                            insert_cmd.Parameters(6).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 7).Value), WorkSheet.Cells(i, 7).Value, String.Empty) 'Technical Description
                            insert_cmd.Parameters(7).Value = WorkSheet.Cells(i, 8).Value 'Main Category
                            insert_cmd.Parameters(8).Value = WorkSheet.Cells(i, 9).Value 'Sub Category
                            insert_cmd.Parameters(9).Value = WorkSheet.Cells(i, 10).Value 'Brand
                            insert_cmd.Parameters(10).Value = WorkSheet.Cells(i, 11).Value 'Type
                            insert_cmd.Parameters(11).Value = WorkSheet.Cells(i, 12).Value 'Tags
                            insert_cmd.Parameters(12).Value = WorkSheet.Cells(i, 13).Value 'Status
                            insert_cmd.Parameters(13).Value = WorkSheet.Cells(i, 14).Value 'Base Price    
                            insert_cmd.Parameters(14).Value = WorkSheet.Cells(i, 15).Value 'Cost
                            insert_cmd.Parameters(15).Value = WorkSheet.Cells(i, 16).Value 'Discount
                            insert_cmd.Parameters(16).Value = WorkSheet.Cells(i, 17).Value 'Regular Price
                            insert_cmd.Parameters(17).Value = WorkSheet.Cells(i, 18).Value 'Dealer Price
                            insert_cmd.Parameters(18).Value = WorkSheet.Cells(i, 19).Value 'VIP Price
                            insert_cmd.Parameters(19).Value = WorkSheet.Cells(i, 20).Value 'Length
                            insert_cmd.Parameters(20).Value = WorkSheet.Cells(i, 21).Value 'Width
                            insert_cmd.Parameters(21).Value = WorkSheet.Cells(i, 22).Value 'Height
                            insert_cmd.Parameters(22).Value = WorkSheet.Cells(i, 23).Value 'Weight
                            insert_cmd.Parameters(23).Value = WorkSheet.Cells(i, 24).Value 'Hazards
                            insert_cmd.Parameters(24).Value = WorkSheet.Cells(i, 25).Value 'Serialized
                            insert_cmd.Parameters(25).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 26).Value), WorkSheet.Cells(i, 26).Value, 0) 'Qty per Box
                            insert_cmd.Parameters(26).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 26).Value), WorkSheet.Cells(i, 26).Value, 0) 'MasterBox Qty
                            insert_cmd.Parameters(27).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 26).Value), WorkSheet.Cells(i, 26).Value, 0) 'Minimum Order Qty
                            insert_cmd.Parameters(28).Value = WorkSheet.Cells(i, 27).Value 'Ideal Stock
                            insert_cmd.Parameters(29).Value = WorkSheet.Cells(i, 28).Value 'Warning Stock
                            insert_cmd.Parameters(30).Value = WorkSheet.Cells(i, 29).Value 'Stock Duration
                            insert_cmd.Parameters(31).Value = WorkSheet.Cells(i, 30).Value 'Warranty Period
                            insert_cmd.Parameters(32).Value = WorkSheet.Cells(i, 31).Value 'Warranty Coverage
                            insert_cmd.Parameters(33).Value = WorkSheet.Cells(i, 32).Value 'Entry Date

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
            'MsgBox("Failed to Upload." & vbCrLf & vbCrLf & ex.Message, vbCritical, "Error")
            Console.WriteLine(ex.ToString)
        End Try

    End Sub

    'Do Work
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Import()
    End Sub

    'ProgressChanged
    Private Sub BackgroundWorker_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker.ProgressChanged

        txt_status.Text += "Processing row " & e.ProgressPercentage & " out of " & rows_count & " rows" & vbCrLf
        txt_status.SelectionStart = txt_status.Text.Length
        txt_status.ScrollToCaret()
        ProgressBar.Value = e.ProgressPercentage

    End Sub

    'Background Completed
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

        btn_upload.Enabled = True

    End Sub

    'Form Closing
    Private Sub frm_import_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

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

    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click

        Select Case btn_details.Text
            Case "Show Details"
                btn_details.Text = "Hide Details"
                Me.Height = 355
                txt_status.Visible = True
                btn_details.Top = 285
                btn_upload.Top = 285
            Case "Hide Details"
                btn_details.Text = "Show Details"
                Me.Height = 195
                txt_status.Visible = False
                btn_details.Top = 124
                btn_upload.Top = 124
        End Select
    End Sub

    'btn_download
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
                My.Computer.FileSystem.WriteAllBytes(sfd.FileName, My.Resources.import_template, False)
            End If
        End Using

    End Sub

End Class