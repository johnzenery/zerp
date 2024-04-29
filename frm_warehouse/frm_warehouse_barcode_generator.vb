Imports MySqlConnector
Imports System.IO
Imports Seagull.BarTender.Print
Imports Seagull.BarTender.Print.Database

Public Class frm_warehouse_barcode_generator


    '--- ONLOAD ---
    Private Sub frm_warehouse_barcode_generator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUnits()
    End Sub

#Region "Controls"

    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub rb_per_unit_Click(sender As Object, e As EventArgs) Handles rb_per_unit.Click
        txt_unit.Enabled = True
        txt_qty.Enabled = True
        txt_po_no.Enabled = False
        txt_receipt_ref.Enabled = False
    End Sub

    Private Sub rb_per_receipt_Click(sender As Object, e As EventArgs) Handles rb_per_receipt.Click
        txt_unit.Enabled = False
        txt_qty.Enabled = False
        txt_po_no.Enabled = True
        txt_receipt_ref.Enabled = True
    End Sub

    'btn_generate
    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If rb_per_unit.Checked Then 'IF PER MODEL

            'Validation
            If txt_unit.SelectedIndex = -1 Then
                MsgBox("Select model first!", vbExclamation, "No model selected")
                Return
            End If
            If txt_qty.Value = 0 Then
                MsgBox("Quantity should not be Zero.", vbExclamation, "Zero quanity")
                Return
            End If
            If String.IsNullOrWhiteSpace(My.Settings.LabelPrinter) Then
                MsgBox("Set label printer first!", vbExclamation, "No Printer")
                Return
            End If

            'Print per Item
            Print_barcode_per_item()



        ElseIf rb_per_receipt.Checked Then  'IF PER RECEIPT

            'Validation
            If txt_po_no.Text = String.Empty Or txt_receipt_ref.Text = String.Empty Or cbb_type.SelectedIndex = -1 Then
                MsgBox("Complete all fields!", vbExclamation, "Incomplete fields.")
                Return
            End If
            If String.IsNullOrWhiteSpace(My.Settings.LabelPrinter) Then
                MsgBox("Set label printer first!", vbExclamation, "No Printer")
                Return
            End If

            'Print per Receipt
            Print_barcode_per_receipt()


        End If

    End Sub

#End Region

#Region "Methods"

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
                Using cmd = New MySqlCommand("SELECT IFNULL(NULLIF(barcode,''), pid) AS barcode_no, winmodel 
                                    FROM ims_inventory
                                    WHERE winmodel=@winmodel", conn)
                    cmd.Parameters.AddWithValue("@winmodel", txt_unit.Text.Trim)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            Units += rdr("barcode_no") & ", " & rdr("winmodel") & vbNewLine
                        End While
                    End Using
                End Using
            End Using

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

                btFormat.PrintSetup.IdenticalCopiesOfLabel = CInt(txt_qty.Text)

                btFormat.DatabaseConnections.SetDatabaseConnection(tf)
                Dim result As Result = btFormat.Print("Printing barcodes...", New Messages)

                btFormat.Close(SaveOptions.DoNotSaveChanges)
                engine.Stop()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try
    End Sub

    'Print barcode per Receipt
    Public Sub Print_barcode_per_receipt()

        Try

            'Get and Set values from Database
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT IFNULL(NULLIF(inv.barcode,''), inv.pid) AS barcode_no, inv.winmodel, qty, inv.description
                                    FROM ims_deliveries
                                    INNER JOIN ims_inventory AS inv ON inv.pid=ims_deliveries.item
                                    INNER JOIN ims_delivery_receipts AS rec ON rec.payable_id=ims_deliveries.receipt_id
                                    WHERE rec.purchase_id=@poid AND rec.receipt_type=@rec_type AND rec.receipt_ref=@rec_ref", conn)
                    cmd.Parameters.AddWithValue("@poid", txt_po_no.Text.Replace("PO", String.Empty).Trim)
                    cmd.Parameters.AddWithValue("@rec_type", cbb_type.Text.Trim)
                    cmd.Parameters.AddWithValue("@rec_ref", txt_receipt_ref.Text.Trim)

                    Using rdr = cmd.ExecuteReader

                        If rdr.HasRows Then

                            Dim dt = New DataTable
                            dt.Columns.Add("qty", GetType(Integer))
                            dt.Columns.Add("barcode", GetType(String))
                            dt.Columns.Add("model", GetType(String))
                            dt.Columns.Add("description", GetType(String))

                            While rdr.Read
                                dt.Rows.Add(rdr("qty"), rdr("barcode_no"), rdr("winmodel"), rdr("description"))
                            End While

                            Dim frm = New frm_warehouse_barcode_label_list
                            frm.grid_labels.DataSource = dt
                            frm.ShowDialog()
                        Else
                            MsgBox("No data found!", vbExclamation, "No data")
                            Return
                        End If

                    End Using
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try

    End Sub

#End Region

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

End Class

