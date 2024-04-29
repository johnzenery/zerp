Imports Seagull.BarTender.Print

Public Class frm_printers

    '--->> ON LOAD
    Private Sub frm_printers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbb_printers.Properties.Items.Clear()
        load_printers()
        cbb_printers.Text = My.Settings.LabelPrinter
    End Sub





    'Load Printer
    Private Sub load_printers()
        Dim printers As New Printers()
        For Each printer As Printer In printers
            cbb_printers.Properties.Items.Add(printer.PrinterName)
        Next
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        My.Settings.LabelPrinter = cbb_printers.Text
        My.Settings.Save()
        MsgBox("Saved!")
        Me.Close()
    End Sub
End Class