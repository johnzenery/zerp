<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class doc_cheque
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_crossed_check = New DevExpress.XtraReports.UI.XRLabel()
        Me.cheque_date = New DevExpress.XtraReports.Parameters.Parameter()
        Me.payee = New DevExpress.XtraReports.Parameters.Parameter()
        Me.amount = New DevExpress.XtraReports.Parameters.Parameter()
        Me.AmountWords = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ac_payee = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.lbl_crossed_check})
        Me.Detail.HeightF = 288.0!
        Me.Detail.Name = "Detail"
        '
        'XrLabel5
        '
        Me.XrLabel5.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?payee")})
        Me.XrLabel5.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(90.0!, 68.0!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(416.6666!, 23.0!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.StylePriority.UseTextAlignment = False
        Me.XrLabel5.Text = "D GREAT EAST CORPORATION"
        Me.XrLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLabel4
        '
        Me.XrLabel4.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?amount")})
        Me.XrLabel4.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(570.7!, 68.0!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(197.2999!, 23.0!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.StylePriority.UseTextAlignment = False
        Me.XrLabel4.Text = "**P20,500,000.25**"
        Me.XrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel4.TextFormatString = "**{0:n2}**"
        '
        'XrLabel3
        '
        Me.XrLabel3.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?cheque_date")})
        Me.XrLabel3.Font = New System.Drawing.Font("Roboto", 13.0!)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(585.83!, 35.0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(122.9167!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "02/20/2021"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrLabel3.TextFormatString = "{0:MM/dd/yyyy}"
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?AmountWords")})
        Me.XrLabel2.Font = New System.Drawing.Font("Roboto", 12.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(60.00001!, 98.0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(707.9999!, 24.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "TWENTY MILLION FIVE HUNDRED THOUSAND AND TWENTY FIVE CENTS ONLY"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'lbl_crossed_check
        '
        Me.lbl_crossed_check.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.lbl_crossed_check.Font = New System.Drawing.Font("Roboto", 14.25!)
        Me.lbl_crossed_check.LocationFloat = New DevExpress.Utils.PointFloat(20.0!, 34.99999!)
        Me.lbl_crossed_check.Multiline = True
        Me.lbl_crossed_check.Name = "lbl_crossed_check"
        Me.lbl_crossed_check.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_crossed_check.SizeF = New System.Drawing.SizeF(106.25!, 25.80001!)
        Me.lbl_crossed_check.StylePriority.UseBorders = False
        Me.lbl_crossed_check.StylePriority.UseFont = False
        Me.lbl_crossed_check.StylePriority.UseTextAlignment = False
        Me.lbl_crossed_check.Text = "A/C PAYEE"
        Me.lbl_crossed_check.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'cheque_date
        '
        Me.cheque_date.Description = "cheque_date"
        Me.cheque_date.Name = "cheque_date"
        Me.cheque_date.Type = GetType(Date)
        Me.cheque_date.Visible = False
        '
        'payee
        '
        Me.payee.Description = "payee"
        Me.payee.Name = "payee"
        Me.payee.ValueInfo = "0"
        Me.payee.Visible = False
        '
        'amount
        '
        Me.amount.Description = "amount"
        Me.amount.Name = "amount"
        Me.amount.Type = GetType(Decimal)
        Me.amount.ValueInfo = "0"
        Me.amount.Visible = False
        '
        'AmountWords
        '
        Me.AmountWords.Description = "AmountWords"
        Me.AmountWords.Name = "AmountWords"
        Me.AmountWords.ValueInfo = "0"
        Me.AmountWords.Visible = False
        '
        'ac_payee
        '
        Me.ac_payee.Description = "ac_payee"
        Me.ac_payee.Name = "ac_payee"
        Me.ac_payee.Type = GetType(Boolean)
        Me.ac_payee.ValueInfo = "False"
        Me.ac_payee.Visible = False
        '
        'doc_cheque
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(0, 0, 0, 0)
        Me.PageHeight = 288
        Me.PageWidth = 768
        Me.PaperKind = System.Drawing.Printing.PaperKind.Custom
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.cheque_date, Me.payee, Me.amount, Me.AmountWords, Me.ac_payee})
        Me.Version = "20.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents lbl_crossed_check As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents cheque_date As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents payee As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents amount As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents AmountWords As DevExpress.XtraReports.Parameters.Parameter
    Friend WithEvents ac_payee As DevExpress.XtraReports.Parameters.Parameter
End Class
