Imports MySqlConnector
Imports System.IO
Imports Seagull.BarTender.Print
Imports Seagull.BarTender.Print.Database

Public Class frm_warehouse_pricetag_generator


    '--- FUNCTIONS ---

    'Load Units
    Private Sub LoadUnits()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT winmodel FROM ims_inventory", connection)
                    Using rdr = cmd.ExecuteReader
                        Dim units = New AutoCompleteStringCollection

                        While rdr.Read()
                            units.Add(rdr("winmodel"))
                        End While

                        txt_unit.Properties.Items.AddRange(units)

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try
    End Sub

    'Print barcode per Items
    Private Sub Print_barcode_per_item()

        Try
            'Get and Set values from Database
            Dim Units As String = "barcode, winmodel" & vbNewLine
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT IFNULL(NULLIF(barcode,''), pid) AS barcode_no, regular_price 
                                    FROM ims_inventory
                                    WHERE winmodel=@winmodel", conn)
                    cmd.Parameters.AddWithValue("@winmodel", txt_unit.EditValue)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            Units += rdr("barcode_no") & ", " & rdr("regular_price") & vbNewLine
                        End While
                    End Using
                End Using
            End Using

            Using engine As New Engine(True)
                engine.Start()
                'engine.Window.Visible = True

                'Get Template into PATH
                Dim barcode_pricetag_bytes() As Byte = My.Resources.barcode_pricetag

                'Create Path
                Dim dir_path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Zerp Data"
                If Not Directory.Exists(dir_path) Then Directory.CreateDirectory(dir_path)
                Dim full_path = dir_path & "\barcode_pricetag.btw"

                File.WriteAllBytes(full_path, barcode_pricetag_bytes)
                Dim bcode_temp_path = New FileInfo(full_path)

                'Open Document to Print.Engine
                Dim btFormat As LabelFormatDocument = engine.Documents.Open(full_path, My.Settings.LabelPrinter)

                'Write Values to 
                Dim tmpFile = dir_path & "\pricetags_to_print.csv"
                File.WriteAllText(tmpFile, Units)
                Dim tf = New TextFile("pricetags_to_print")
                tf.FileName = tmpFile

                btFormat.PrintSetup.IdenticalCopiesOfLabel = CInt(SpinEdit_qty.EditValue)

                btFormat.DatabaseConnections.SetDatabaseConnection(tf)
                Dim result As Result = btFormat.Print("Printing pricetags...", New Messages)

                btFormat.Close(SaveOptions.DoNotSaveChanges)
                engine.Stop()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try
    End Sub




    '--- CONTROLS AND EVENTS

    Private Sub frm_warehouse_pricetag_generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnits()
    End Sub


    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        'Validate Printer
        If String.IsNullOrWhiteSpace(My.Settings.LabelPrinter) Then
            MsgBox("Set label printer first!", vbExclamation, "No Printer")
            Return
        End If

        Print_barcode_per_item()
    End Sub

    Private Sub txt_unit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txt_unit.SelectedIndexChanged
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT pid FROM ims_inventory WHERE winmodel=@winmodel", conn)
                    cmd.Parameters.AddWithValue("@winmodel", txt_unit.Text.Trim)
                    txt_pid.Text = cmd.ExecuteScalar
                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class