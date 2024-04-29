Imports DevExpress.XtraPrinting

Public Class doc_cheque


    Private Sub XrLabel2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        Dim cell = XrLabel2
        Dim str = cell.Text

        Me.PrintingSystem.Graph.Font = cell.Font
        Dim cellWidth As Single = cell.WidthF

        Select Case Me.ReportUnit
            Case DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch
                cellWidth = GraphicsUnitConverter.Convert(cellWidth, GraphicsUnit.Inch, GraphicsUnit.Document) / 100
            Case DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
                cellWidth = GraphicsUnitConverter.Convert(cellWidth, GraphicsUnit.Millimeter, GraphicsUnit.Document) / 10
        End Select

        Dim Size = Me.PrintingSystem.Graph.MeasureString(str, CInt(cellWidth))
        Dim textHeight As Single = 0

        Select Case Me.ReportUnit
            Case DevExpress.XtraReports.UI.ReportUnit.HundredthsOfAnInch
                textHeight = GraphicsUnitConverter.Convert(Size.Height, GraphicsUnit.Document, GraphicsUnit.Inch) * 100
            Case DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
                textHeight = GraphicsUnitConverter.Convert(Size.Height, GraphicsUnit.Document, GraphicsUnit.Millimeter) * 10
        End Select

        If textHeight > cell.HeightF Then
            cell.Font = New Font("Roboto", 10)
        End If

    End Sub

    Private Sub XrLabel1_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lbl_crossed_check.BeforePrint
        Select Case ac_payee.Value
            Case True : lbl_crossed_check.Visible = True
            Case False : lbl_crossed_check.Visible = False
        End Select
    End Sub

End Class