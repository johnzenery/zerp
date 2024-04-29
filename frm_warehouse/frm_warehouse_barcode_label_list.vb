Imports System.IO
Imports Seagull.BarTender.Print
Imports Seagull.BarTender.Print.Database

Public Class frm_warehouse_barcode_label_list


    Private Sub btn_print_all_Click(sender As Object, e As EventArgs) Handles btn_print_all.Click
        Try

            Dim Units As String = "barcode, winmodel" & vbNewLine

            For Each row As DataRow In CType(grid_labels.DataSource, DataTable).Rows
                For i = 1 To CInt(row.Item("qty"))
                    Units += row.Item("barcode") & ", " & row.Item("model") & vbNewLine
                Next
            Next

            Using engine As New Engine(True)
                engine.Start()
                'engine.Window.Visible = True

                'Get Template into PATH
                Dim barcode_template_bytes() As Byte = My.Resources.barcode_template

                'Create Path
                Dim dir_path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Zerp Data"
                If Not Directory.Exists(dir_path) Then Directory.CreateDirectory(dir_path)
                Dim full_path = dir_path & "\barcode_template.btw"

                File.WriteAllBytes(full_path, barcode_template_bytes)
                Dim bcode_temp_path = New FileInfo(full_path)

                'Open Document to Print.Engine
                Dim btFormat As LabelFormatDocument = engine.Documents.Open(full_path, My.Settings.LabelPrinter)

                'Write Values to 
                Dim tmpFile = dir_path & "\barcodes_to_print.csv"
                File.WriteAllText(tmpFile, Units)
                Dim tf = New TextFile("barcodes_to_print")
                tf.FileName = tmpFile

                btFormat.DatabaseConnections.SetDatabaseConnection(tf)
                Dim result As Result = btFormat.Print("Printing barcodes...", New Messages)

                btFormat.Close(SaveOptions.DoNotSaveChanges)
                engine.Stop()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try
    End Sub


    Private Sub btn_print_selected_Click(sender As Object, e As EventArgs) Handles btn_print_selected.Click
        Try

            Dim Units As String = "barcode, winmodel" & vbNewLine
            Dim selected_rows = grid_labels_view.GetSelectedRows

            For i = 0 To selected_rows.Length - 1
                For j = 1 To CInt(grid_labels_view.GetRowCellValue(selected_rows(i), col_qty))
                    Units += grid_labels_view.GetRowCellValue(selected_rows(i), col_barcode) & "," & grid_labels_view.GetRowCellValue(selected_rows(i), col_model) & vbNewLine
                Next
            Next

            Using engine As New Engine(True)
                engine.Start()

                'engine.Window.Visible = True

                'Get Template into PATH
                Dim barcode_template_bytes() As Byte = My.Resources.barcode_template

                'Create Path
                Dim dir_path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Zerp Data"
                If Not Directory.Exists(dir_path) Then Directory.CreateDirectory(dir_path)
                Dim full_path = dir_path & "\barcode_template.btw"

                File.WriteAllBytes(full_path, barcode_template_bytes)
                Dim bcode_temp_path = New FileInfo(full_path)

                'Open Document to Print.Engine
                Dim btFormat As LabelFormatDocument = engine.Documents.Open(full_path, My.Settings.LabelPrinter)

                'Write Values to 
                Dim tmpFile = dir_path & "\barcodes_to_print.csv"
                File.WriteAllText(tmpFile, Units)
                Dim tf = New TextFile("barcodes_to_print")
                tf.FileName = tmpFile

                btFormat.DatabaseConnections.SetDatabaseConnection(tf)
                Dim result As Result = btFormat.Print("Printing barcodes...", New Messages)

                btFormat.Close(SaveOptions.DoNotSaveChanges)
                engine.Stop()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try
    End Sub
End Class