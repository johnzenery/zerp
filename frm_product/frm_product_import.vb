Imports System.IO
Imports MySqlConnector
Imports OfficeOpenXml

Public Class frm_product_import

    Dim rows_count As Integer = 0
    Private Property one_percent = 0
    Private Property counter = 0
    Private Property uploading = False
    Private Property error_lines = String.Empty



    '--- ON LOAD -----
    Private Sub frm_import_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_status.Text = String.Empty
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

                uploading = True
                'ProgressBar.Maximum = rows_count.Length - 1
                txt_status.Text = String.Empty
                error_lines = String.Empty
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
                Dim query = "INSERT INTO ims_inventory (pid, barcode, winmodel, supmodel, description, technical_description, main_category, sub_category, brand, type, tags, base_price, cost, discount, regular_price, dealer_price, vip_price, length, width, height, weight, hazards, status, supplier, serialized, qty_per_box, masterbox_qty, min_order_qty, ideal_stock, warning_stock, stock_duration, warranty_period, warranty_coverage, date_entry, unit) 
                        VALUES (@pid, @barcode, @winmodel, @supmodel, @description, @technical_description, @main_category, @sub_category, @brand, @type, @tags, @base_price, @cost, @discount, @regular_price, @dealer_price, @vip_price, @length, @width, @height, @weight, @hazards, @status, @supplier, @serialized, @qty_per_box, @masterbox_qty, @min_order_qty, @ideal_stock, @warning_stock, @stock_duration, @warranty_period, @warranty_coverage, @date_entry, @unit)
                        ON DUPLICATE KEY UPDATE barcode=@barcode, winmodel=@winmodel, supmodel=@supmodel, description=@description, technical_description=@technical_description, main_category=@main_category, sub_category=@sub_category, brand=@brand, type=@type, tags=@tags, base_price=@base_price, cost=@cost, discount=@discount, regular_price=@regular_price, net_regular=@net_regular, dealer_price=@dealer_price, vip_price=@vip_price,
                        length=@length, width=@width, height=@height, weight=@weight, hazards=@hazards, status=@status, supplier=@supplier, serialized=@serialized, qty_per_box=@qty_per_box, masterbox_qty=@masterbox_qty, min_order_qty=@min_order_qty, ideal_stock=@ideal_stock, warning_stock=@warning_stock, stock_duration=@stock_duration, warranty_period=@warranty_period, warranty_coverage=@warranty_coverage, date_entry=@date_entry, unit=@unit"
                Using insert_cmd = New MySqlCommand(query, connection)
                    insert_cmd.Parameters.AddWithValue("@pid", Nothing)
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
                    insert_cmd.Parameters.AddWithValue("@net_regular", 0.00)
                    insert_cmd.Parameters.AddWithValue("@dealer_price", 0.00)
                    insert_cmd.Parameters.AddWithValue("@vip_price", 0.00)
                    insert_cmd.Parameters.AddWithValue("@length", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@width", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@height", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@weight", DBNull.Value)
                    insert_cmd.Parameters.AddWithValue("@unit", Nothing)
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
                            'String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 1).Value) _  'PID  
                            If String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 3).Value) _ 'winmodel
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 4).Value) _  'supmodel
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 5).Value) _  'supid
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 6).Value) _  'description
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 8).Value) _  'main_category
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 9).Value) _  'sub_category
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 10).Value) _  'brand
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 13).Value) _ 'status
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 14).Value) _ 'Base Price
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 15).Value) _ 'cost
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 17).Value) _ 'regular_price
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 18).Value) _ 'net_regular
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 19).Value) _ 'dealer_price OR NET Dealer
                                Or String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 20).Value) _ 'vip_price OR NET VIP
                                Then
                                counts += 1
                                error_lines += "Line " & counts & vbCrLf
                                Continue For
                            End If

                            'CHECK IF NO PID and Duplicate in Database
                            If String.IsNullOrWhiteSpace(WorkSheet.Cells(i, 1).Value) And Check_Model_IF_EXIST(WorkSheet.Cells(i, 3).Value) = True Then
                                counts += 1
                                error_lines += "Line " & counts & " : Found duplicate in the system." & vbCrLf
                                Continue For
                            End If

                            insert_cmd.Parameters(0).Value = WorkSheet.Cells(i, 1).Value 'PID
                            insert_cmd.Parameters(1).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 2).Value), WorkSheet.Cells(i, 2).Value, Nothing) 'Barcode
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
                            insert_cmd.Parameters(17).Value = WorkSheet.Cells(i, 18).Value 'NET Regular
                            insert_cmd.Parameters(18).Value = WorkSheet.Cells(i, 19).Value 'Dealer Price OR NET Dealer
                            insert_cmd.Parameters(19).Value = WorkSheet.Cells(i, 20).Value 'VIP Price OR NET VIP
                            insert_cmd.Parameters(20).Value = WorkSheet.Cells(i, 21).Value 'Length
                            insert_cmd.Parameters(21).Value = WorkSheet.Cells(i, 22).Value 'Width
                            insert_cmd.Parameters(22).Value = WorkSheet.Cells(i, 23).Value 'Height
                            insert_cmd.Parameters(23).Value = WorkSheet.Cells(i, 24).Value 'Weight
                            insert_cmd.Parameters(24).Value = WorkSheet.Cells(i, 25).Value 'Unit
                            insert_cmd.Parameters(25).Value = WorkSheet.Cells(i, 26).Value 'Hazards
                            insert_cmd.Parameters(26).Value = WorkSheet.Cells(i, 27).Value 'Serialized
                            insert_cmd.Parameters(27).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 28).Value), WorkSheet.Cells(i, 28).Value, 0) 'Qty per Box
                            insert_cmd.Parameters(28).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 29).Value), WorkSheet.Cells(i, 29).Value, 0) 'MasterBox Qty
                            insert_cmd.Parameters(29).Value = IIf(Not String.IsNullOrEmpty(WorkSheet.Cells(i, 30).Value), WorkSheet.Cells(i, 30).Value, 0) 'Minimum Order Qty
                            insert_cmd.Parameters(30).Value = WorkSheet.Cells(i, 31).Value 'Ideal Stock
                            insert_cmd.Parameters(31).Value = WorkSheet.Cells(i, 32).Value 'Warning Stock
                            insert_cmd.Parameters(32).Value = WorkSheet.Cells(i, 33).Value 'Stock Duration
                            insert_cmd.Parameters(33).Value = WorkSheet.Cells(i, 34).Value 'Warranty Period
                            insert_cmd.Parameters(34).Value = WorkSheet.Cells(i, 35).Value 'Warranty Coverage 
                            insert_cmd.Parameters(35).Value = WorkSheet.Cells(i, 36).Value 'Entry Date
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

    'CHECK WinModel IF EXIST
    Private Function Check_Model_IF_EXIST(winmodel As String)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using check_cmd = New MySqlCommand("SELECT COUNT(winmodel) FROM ims_inventory WHERE winmodel=@winmodel", conn)
                    check_cmd.Parameters.AddWithValue("@winmodel", winmodel)
                    If CInt(check_cmd.ExecuteScalar) > 0 Then
                        Return True
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return False

    End Function

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