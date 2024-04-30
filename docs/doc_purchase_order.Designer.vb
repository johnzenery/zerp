Imports DevExpress.Utils
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.Parameters
Imports DevExpress.XtraReports.UI
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class doc_purchase_order
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(doc_purchase_order))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrLabel31 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel32 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel29 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel30 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel27 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel26 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel15 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel14 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel13 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel12 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel11 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel10 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.PrintData1 = New Inventory_Management.PrintData()
        Me.supplier = New DevExpress.XtraReports.Parameters.Parameter()
        Me.contact_person = New DevExpress.XtraReports.Parameters.Parameter()
        Me.delivery_addr = New DevExpress.XtraReports.Parameters.Parameter()
        Me.deliver_to = New DevExpress.XtraReports.Parameters.Parameter()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.pid = New DevExpress.XtraReports.Parameters.Parameter()
        Me.print_date = New DevExpress.XtraReports.Parameters.Parameter()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.XrLabel35 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel18 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel42 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel40 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_vatable_sales = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_discount = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine3 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel38 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel37 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel36 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_total_sales = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel33 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_vat = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel28 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel20 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.XrLabel22 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel21 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel19 = New DevExpress.XtraReports.UI.XRLabel()
        Me.lbl_subtotal = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel17 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrRichText1 = New DevExpress.XtraReports.UI.XRRichText()
        Me.XrLabel16 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel23 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel24 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLabel25 = New DevExpress.XtraReports.UI.XRLabel()
        Me.total = New DevExpress.XtraReports.Parameters.Parameter()
        Me.amount_due = New DevExpress.XtraReports.Parameters.Parameter()
        Me.sub_total = New DevExpress.XtraReports.UI.CalculatedField()
        Me.discount_type = New DevExpress.XtraReports.Parameters.Parameter()
        Me.discount_val = New DevExpress.XtraReports.Parameters.Parameter()
        Me.store_info = New DevExpress.XtraReports.Parameters.Parameter()
        Me.prepared_by = New DevExpress.XtraReports.Parameters.Parameter()
        Me.approved_by = New DevExpress.XtraReports.Parameters.Parameter()
        Me.lead_time = New DevExpress.XtraReports.Parameters.Parameter()
        Me.approved_date = New DevExpress.XtraReports.Parameters.Parameter()
        Me.expiration_date = New DevExpress.XtraReports.Parameters.Parameter()
        Me.terms = New DevExpress.XtraReports.Parameters.Parameter()
        Me.is_vatable = New DevExpress.XtraReports.Parameters.Parameter()
        Me.is_withholding_tax_applied = New DevExpress.XtraReports.Parameters.Parameter()
        Me.withholding_tax_percentage = New DevExpress.XtraReports.Parameters.Parameter()
        Me.withholding_tax_amount = New DevExpress.XtraReports.Parameters.Parameter()
        Me.pub_notes = New DevExpress.XtraReports.Parameters.Parameter()
        Me.store_name = New DevExpress.XtraReports.Parameters.Parameter()
        Me.vat_rate = New DevExpress.XtraReports.Parameters.Parameter()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrintData1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 50.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 50.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.StylePriority.UseBorders = False
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(750.0001!, 25.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell6, Me.XrTableCell12, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell6.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.StylePriority.UseFont = False
        Me.XrTableCell6.StylePriority.UseTextAlignment = False
        Me.XrTableCell6.Text = "[qty]"
        Me.XrTableCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell6.Weight = 0.2946664105168354R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[unit]")})
        Me.XrTableCell12.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.StylePriority.UseBorders = False
        Me.XrTableCell12.StylePriority.UseFont = False
        Me.XrTableCell12.StylePriority.UseTextAlignment = False
        Me.XrTableCell12.Text = "XrTableCell12"
        Me.XrTableCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell12.Weight = 0.29466661284834078R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell7.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.StylePriority.UseBorders = False
        Me.XrTableCell7.StylePriority.UseFont = False
        Me.XrTableCell7.StylePriority.UseTextAlignment = False
        Me.XrTableCell7.Text = "[supmodel]"
        Me.XrTableCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell7.Weight = 0.91733337766995082R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell8.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.StylePriority.UseFont = False
        Me.XrTableCell8.StylePriority.UseTextAlignment = False
        Me.XrTableCell8.Text = "[description]"
        Me.XrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell8.Weight = 1.591111328125R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell9.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "[cost!N2]"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell9.Weight = 0.661111165364583R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableCell10.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseBorders = False
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = "[total_cost!N2]"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight
        Me.XrTableCell10.Weight = 0.661111002604167R
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel31, Me.XrLabel32, Me.XrLabel29, Me.XrLabel30, Me.XrLabel27, Me.XrLabel26, Me.XrLabel15, Me.XrLabel14, Me.XrLabel13, Me.XrLabel12, Me.XrLabel11, Me.XrLabel10, Me.XrLabel9, Me.XrLabel8, Me.XrLabel7, Me.XrLabel6, Me.XrLabel5, Me.XrLabel4, Me.XrLabel3, Me.XrLabel2, Me.XrLabel1, Me.XrPictureBox1})
        Me.ReportHeader.HeightF = 225.5832!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrLabel31
        '
        Me.XrLabel31.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?terms")})
        Me.XrLabel31.LocationFloat = New DevExpress.Utils.PointFloat(602.0833!, 148.2501!)
        Me.XrLabel31.Multiline = True
        Me.XrLabel31.Name = "XrLabel31"
        Me.XrLabel31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel31.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
        Me.XrLabel31.StylePriority.UseTextAlignment = False
        Me.XrLabel31.Text = "XrLabel14"
        Me.XrLabel31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel32
        '
        Me.XrLabel32.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel32.LocationFloat = New DevExpress.Utils.PointFloat(412.0834!, 148.2501!)
        Me.XrLabel32.Multiline = True
        Me.XrLabel32.Name = "XrLabel32"
        Me.XrLabel32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel32.SizeF = New System.Drawing.SizeF(189.9999!, 17.79166!)
        Me.XrLabel32.StylePriority.UseFont = False
        Me.XrLabel32.Text = "Payment Terms (Days):"
        '
        'XrLabel29
        '
        Me.XrLabel29.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel29.LocationFloat = New DevExpress.Utils.PointFloat(412.0834!, 130.4584!)
        Me.XrLabel29.Multiline = True
        Me.XrLabel29.Name = "XrLabel29"
        Me.XrLabel29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel29.SizeF = New System.Drawing.SizeF(189.9999!, 17.79166!)
        Me.XrLabel29.StylePriority.UseFont = False
        Me.XrLabel29.Text = "PO Valid Until:"
        '
        'XrLabel30
        '
        Me.XrLabel30.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?expiration_date")})
        Me.XrLabel30.LocationFloat = New DevExpress.Utils.PointFloat(602.0833!, 130.4584!)
        Me.XrLabel30.Multiline = True
        Me.XrLabel30.Name = "XrLabel30"
        Me.XrLabel30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel30.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
        Me.XrLabel30.StylePriority.UseTextAlignment = False
        Me.XrLabel30.Text = "XrLabel14"
        Me.XrLabel30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel30.TextFormatString = "{0:MM/dd/yyyy}"
        '
        'XrLabel27
        '
        Me.XrLabel27.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?lead_time")})
        Me.XrLabel27.LocationFloat = New DevExpress.Utils.PointFloat(602.0833!, 112.6667!)
        Me.XrLabel27.Multiline = True
        Me.XrLabel27.Name = "XrLabel27"
        Me.XrLabel27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel27.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
        Me.XrLabel27.StylePriority.UseTextAlignment = False
        Me.XrLabel27.Text = "XrLabel14"
        Me.XrLabel27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel27.TextFormatString = "{0:MM/dd/yyyy}"
        '
        'XrLabel26
        '
        Me.XrLabel26.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel26.LocationFloat = New DevExpress.Utils.PointFloat(412.0834!, 112.6666!)
        Me.XrLabel26.Multiline = True
        Me.XrLabel26.Name = "XrLabel26"
        Me.XrLabel26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel26.SizeF = New System.Drawing.SizeF(189.9999!, 17.79166!)
        Me.XrLabel26.StylePriority.UseFont = False
        Me.XrLabel26.Text = "Expected Date of Delivery:"
        '
        'XrLabel15
        '
        Me.XrLabel15.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?print_date")})
        Me.XrLabel15.LocationFloat = New DevExpress.Utils.PointFloat(604.1667!, 82.20834!)
        Me.XrLabel15.Multiline = True
        Me.XrLabel15.Name = "XrLabel15"
        Me.XrLabel15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel15.SizeF = New System.Drawing.SizeF(145.8333!, 17.79166!)
        Me.XrLabel15.StylePriority.UseTextAlignment = False
        Me.XrLabel15.Text = "XrLabel15"
        Me.XrLabel15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel15.TextFormatString = "{0:M/d/yyyy}"
        '
        'XrLabel14
        '
        Me.XrLabel14.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pid")})
        Me.XrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(604.1666!, 64.41669!)
        Me.XrLabel14.Multiline = True
        Me.XrLabel14.Name = "XrLabel14"
        Me.XrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel14.SizeF = New System.Drawing.SizeF(145.8334!, 17.79165!)
        Me.XrLabel14.StylePriority.UseTextAlignment = False
        Me.XrLabel14.Text = "XrLabel14"
        Me.XrLabel14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel13
        '
        Me.XrLabel13.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?deliver_to")})
        Me.XrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(126.6073!, 179.125!)
        Me.XrLabel13.Multiline = True
        Me.XrLabel13.Name = "XrLabel13"
        Me.XrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel13.SizeF = New System.Drawing.SizeF(245.8332!, 17.79169!)
        Me.XrLabel13.Text = "XrLabel13"
        '
        'XrLabel12
        '
        Me.XrLabel12.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?supplier")})
        Me.XrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(117.5593!, 130.4583!)
        Me.XrLabel12.Multiline = True
        Me.XrLabel12.Name = "XrLabel12"
        Me.XrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel12.SizeF = New System.Drawing.SizeF(268.0656!, 17.79161!)
        Me.XrLabel12.Text = "XrLabel12"
        '
        'XrLabel11
        '
        Me.XrLabel11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?contact_person")})
        Me.XrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(117.5593!, 148.25!)
        Me.XrLabel11.Multiline = True
        Me.XrLabel11.Name = "XrLabel11"
        Me.XrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel11.SizeF = New System.Drawing.SizeF(227.7085!, 17.79164!)
        Me.XrLabel11.Text = "XrLabel11"
        '
        'XrLabel10
        '
        Me.XrLabel10.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?delivery_addr")})
        Me.XrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(126.6073!, 196.9167!)
        Me.XrLabel10.Multiline = True
        Me.XrLabel10.Name = "XrLabel10"
        Me.XrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel10.SizeF = New System.Drawing.SizeF(245.8332!, 17.79166!)
        Me.XrLabel10.Text = "XrLabel10"
        '
        'XrLabel9
        '
        Me.XrLabel9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0!, 179.125!)
        Me.XrLabel9.Multiline = True
        Me.XrLabel9.Name = "XrLabel9"
        Me.XrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel9.SizeF = New System.Drawing.SizeF(125.4166!, 17.79164!)
        Me.XrLabel9.StylePriority.UseFont = False
        Me.XrLabel9.Text = "Deliver To:"
        '
        'XrLabel8
        '
        Me.XrLabel8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0!, 196.9167!)
        Me.XrLabel8.Multiline = True
        Me.XrLabel8.Name = "XrLabel8"
        Me.XrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel8.SizeF = New System.Drawing.SizeF(125.4166!, 17.79164!)
        Me.XrLabel8.StylePriority.UseFont = False
        Me.XrLabel8.Text = "Delivery Address:"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 148.2501!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(110.8333!, 17.79164!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Contact Person:"
        '
        'XrLabel6
        '
        Me.XrLabel6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(0!, 130.4584!)
        Me.XrLabel6.Multiline = True
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(68.74997!, 17.79166!)
        Me.XrLabel6.StylePriority.UseFont = False
        Me.XrLabel6.Text = "Supplier:"
        '
        'XrLabel5
        '
        Me.XrLabel5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(504.1667!, 82.20834!)
        Me.XrLabel5.Multiline = True
        Me.XrLabel5.Name = "XrLabel5"
        Me.XrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel5.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
        Me.XrLabel5.StylePriority.UseFont = False
        Me.XrLabel5.Text = "Date:"
        '
        'XrLabel4
        '
        Me.XrLabel4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(504.1667!, 64.41669!)
        Me.XrLabel4.Multiline = True
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(99.99997!, 17.79165!)
        Me.XrLabel4.StylePriority.UseFont = False
        Me.XrLabel4.Text = "Purchase ID:"
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Arial", 22.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(452.0833!, 0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(297.9167!, 54.25002!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "PURCHASE ORDER"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?store_info")})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 29.87499!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(333.3333!, 70.12501!)
        Me.XrLabel2.Text = "345 Unit D, J. Teodoro St., Grace Park, Caloocan City" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Globe: 09052862165 / 09272" &
    "673759" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Tel/Fax: 7753-0278 / 83654851"
        '
        'XrLabel1
        '
        Me.XrLabel1.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?store_name")})
        Me.XrLabel1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 9.99999!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(333.3333!, 19.875!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Winland Electronics and Electrical Center"
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.XrPictureBox1.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource(Global.Inventory_Management.My.Resources.Resources.Logo_Only, True)
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(100.0!, 100.0!)
        Me.XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage
        '
        'PrintData1
        '
        Me.PrintData1.DataSetName = "PrintData"
        Me.PrintData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'supplier
        '
        Me.supplier.Description = "supplier"
        Me.supplier.Name = "supplier"
        Me.supplier.Visible = False
        '
        'contact_person
        '
        Me.contact_person.Description = "contact_person"
        Me.contact_person.Name = "contact_person"
        Me.contact_person.Visible = False
        '
        'delivery_addr
        '
        Me.delivery_addr.Description = "delivery_addr"
        Me.delivery_addr.Name = "delivery_addr"
        Me.delivery_addr.Visible = False
        '
        'deliver_to
        '
        Me.deliver_to.Description = "deliver_to"
        Me.deliver_to.Name = "deliver_to"
        Me.deliver_to.Visible = False
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 35.33343!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(750.0!, 29.99998!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell11, Me.XrTableCell2, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell3})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.Text = "QTY"
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell1.Weight = 0.2946666598928892R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell11.Multiline = True
        Me.XrTableCell11.Name = "XrTableCell11"
        Me.XrTableCell11.StylePriority.UseFont = False
        Me.XrTableCell11.StylePriority.UseTextAlignment = False
        Me.XrTableCell11.Text = "Unit"
        Me.XrTableCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell11.Weight = 0.29466665989288932R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.StylePriority.UseTextAlignment = False
        Me.XrTableCell2.Text = "SUP. MODEL"
        Me.XrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell2.Weight = 0.91733308124934843R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = "DESCRIPTION"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 1.591111328125R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.StylePriority.UseTextAlignment = False
        Me.XrTableCell5.Text = "ITEM COST"
        Me.XrTableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell5.Weight = 0.661111165364583R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "TOTAL COST"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell3.Weight = 0.661111002604167R
        '
        'pid
        '
        Me.pid.Description = "pid"
        Me.pid.Name = "pid"
        Me.pid.Visible = False
        '
        'print_date
        '
        Me.print_date.Description = "print_date"
        Me.print_date.Name = "print_date"
        Me.print_date.Visible = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel35, Me.XrLabel18, Me.XrLabel42, Me.XrLabel40, Me.lbl_vatable_sales, Me.lbl_discount, Me.XrLine3, Me.XrLabel38, Me.XrLabel37, Me.XrLabel36, Me.lbl_total_sales, Me.XrLine2, Me.XrLabel33, Me.lbl_vat, Me.XrLabel28, Me.XrLabel20, Me.XrLine1, Me.XrLabel22, Me.XrLabel21, Me.XrLabel19, Me.lbl_subtotal, Me.XrLabel17, Me.XrRichText1, Me.XrLabel16, Me.XrLabel23, Me.XrLabel24, Me.XrLabel25})
        Me.ReportFooter.HeightF = 287.4706!
        Me.ReportFooter.KeepTogether = True
        Me.ReportFooter.Name = "ReportFooter"
        Me.ReportFooter.PrintAtBottom = True
        '
        'XrLabel35
        '
        Me.XrLabel35.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?pub_notes")})
        Me.XrLabel35.LocationFloat = New DevExpress.Utils.PointFloat(51.04167!, 235.6668!)
        Me.XrLabel35.Multiline = True
        Me.XrLabel35.Name = "XrLabel35"
        Me.XrLabel35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel35.SizeF = New System.Drawing.SizeF(486.4583!, 51.80386!)
        Me.XrLabel35.Text = "XrLabel12"
        '
        'XrLabel18
        '
        Me.XrLabel18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 235.6667!)
        Me.XrLabel18.Multiline = True
        Me.XrLabel18.Name = "XrLabel18"
        Me.XrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel18.SizeF = New System.Drawing.SizeF(51.04164!, 17.79166!)
        Me.XrLabel18.StylePriority.UseFont = False
        Me.XrLabel18.Text = "Notes:"
        '
        'XrLabel42
        '
        Me.XrLabel42.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel42.LocationFloat = New DevExpress.Utils.PointFloat(474.8166!, 64.08328!)
        Me.XrLabel42.Multiline = True
        Me.XrLabel42.Name = "XrLabel42"
        Me.XrLabel42.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel42.SizeF = New System.Drawing.SizeF(149.9999!, 17.79164!)
        Me.XrLabel42.StylePriority.UseFont = False
        Me.XrLabel42.StylePriority.UseTextAlignment = False
        Me.XrLabel42.Text = "Total Sales"
        Me.XrLabel42.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel40
        '
        Me.XrLabel40.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel40.LocationFloat = New DevExpress.Utils.PointFloat(474.8166!, 99.62501!)
        Me.XrLabel40.Multiline = True
        Me.XrLabel40.Name = "XrLabel40"
        Me.XrLabel40.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel40.SizeF = New System.Drawing.SizeF(149.9999!, 17.79164!)
        Me.XrLabel40.StylePriority.UseFont = False
        Me.XrLabel40.StylePriority.UseTextAlignment = False
        Me.XrLabel40.Text = "Vatable Sales:"
        Me.XrLabel40.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lbl_vatable_sales
        '
        Me.lbl_vatable_sales.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("lbl_vatable_sales.ExpressionBindings"))})
        Me.lbl_vatable_sales.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vatable_sales.LocationFloat = New DevExpress.Utils.PointFloat(624.8165!, 99.62498!)
        Me.lbl_vatable_sales.Multiline = True
        Me.lbl_vatable_sales.Name = "lbl_vatable_sales"
        Me.lbl_vatable_sales.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_vatable_sales.SizeF = New System.Drawing.SizeF(125.1835!, 17.79166!)
        Me.lbl_vatable_sales.StylePriority.UseFont = False
        Me.lbl_vatable_sales.StylePriority.UseTextAlignment = False
        Me.lbl_vatable_sales.Text = "0.00"
        Me.lbl_vatable_sales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lbl_vatable_sales.TextFormatString = "{0:N2}"
        '
        'lbl_discount
        '
        Me.lbl_discount.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(IsNUllorEmpty(?discount_type)," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " " & Global.Microsoft.VisualBasic.ChrW(9) & "'0.00'," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Iif(?discount_type == 'peso'," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) &
                    "?discount_val , " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & Global.Microsoft.VisualBasic.ChrW(9) & "Sum([total_cost]) * (ToDecimal(?discount_val) / 100)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & ")" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ") " &
                    " " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))})
        Me.lbl_discount.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_discount.LocationFloat = New DevExpress.Utils.PointFloat(624.8165!, 40.29165!)
        Me.lbl_discount.Multiline = True
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_discount.SizeF = New System.Drawing.SizeF(125.1835!, 17.79164!)
        Me.lbl_discount.StylePriority.UseFont = False
        Me.lbl_discount.StylePriority.UseTextAlignment = False
        Me.lbl_discount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lbl_discount.TextFormatString = "-   {0:N2}"
        '
        'XrLine3
        '
        Me.XrLine3.LocationFloat = New DevExpress.Utils.PointFloat(624.8165!, 166.2681!)
        Me.XrLine3.Name = "XrLine3"
        Me.XrLine3.SizeF = New System.Drawing.SizeF(125.1835!, 2.064972!)
        '
        'XrLabel38
        '
        Me.XrLabel38.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("XrLabel38.ExpressionBindings"))})
        Me.XrLabel38.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel38.LocationFloat = New DevExpress.Utils.PointFloat(624.8166!, 145.4764!)
        Me.XrLabel38.Multiline = True
        Me.XrLabel38.Name = "XrLabel38"
        Me.XrLabel38.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel38.SizeF = New System.Drawing.SizeF(125.1835!, 17.79164!)
        Me.XrLabel38.StylePriority.UseFont = False
        Me.XrLabel38.StylePriority.UseTextAlignment = False
        Me.XrLabel38.Text = "0.00"
        Me.XrLabel38.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel38.TextFormatString = "-   {0:N2}"
        '
        'XrLabel37
        '
        Me.XrLabel37.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel37.LocationFloat = New DevExpress.Utils.PointFloat(560.2331!, 145.4764!)
        Me.XrLabel37.Multiline = True
        Me.XrLabel37.Name = "XrLabel37"
        Me.XrLabel37.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel37.SizeF = New System.Drawing.SizeF(64.58337!, 17.79164!)
        Me.XrLabel37.StylePriority.UseFont = False
        Me.XrLabel37.StylePriority.UseTextAlignment = False
        Me.XrLabel37.Text = "Less EWT:"
        Me.XrLabel37.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel36
        '
        Me.XrLabel36.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("XrLabel36.ExpressionBindings"))})
        Me.XrLabel36.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel36.LocationFloat = New DevExpress.Utils.PointFloat(624.8165!, 122.6248!)
        Me.XrLabel36.Multiline = True
        Me.XrLabel36.Name = "XrLabel36"
        Me.XrLabel36.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel36.SizeF = New System.Drawing.SizeF(125.1835!, 17.79164!)
        Me.XrLabel36.StylePriority.UseFont = False
        Me.XrLabel36.StylePriority.UseTextAlignment = False
        Me.XrLabel36.Text = "0.00"
        Me.XrLabel36.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.XrLabel36.TextFormatString = "{0:N2}"
        '
        'lbl_total_sales
        '
        Me.lbl_total_sales.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", resources.GetString("lbl_total_sales.ExpressionBindings"))})
        Me.lbl_total_sales.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_sales.LocationFloat = New DevExpress.Utils.PointFloat(624.8166!, 64.08328!)
        Me.lbl_total_sales.Multiline = True
        Me.lbl_total_sales.Name = "lbl_total_sales"
        Me.lbl_total_sales.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_total_sales.SizeF = New System.Drawing.SizeF(125.1835!, 17.79164!)
        Me.lbl_total_sales.StylePriority.UseFont = False
        Me.lbl_total_sales.StylePriority.UseTextAlignment = False
        Me.lbl_total_sales.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lbl_total_sales.TextFormatString = "{0:N2}"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(624.8165!, 61.08334!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(123.1002!, 2.06498!)
        '
        'XrLabel33
        '
        Me.XrLabel33.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(?is_withholding_tax_applied == True, " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "?withholding_tax_percentage + '%'," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) &
                    "''" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ")  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))})
        Me.XrLabel33.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel33.LocationFloat = New DevExpress.Utils.PointFloat(468.1499!, 145.4764!)
        Me.XrLabel33.Multiline = True
        Me.XrLabel33.Name = "XrLabel33"
        Me.XrLabel33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel33.SizeF = New System.Drawing.SizeF(92.08322!, 17.79163!)
        Me.XrLabel33.StylePriority.UseFont = False
        Me.XrLabel33.StylePriority.UseTextAlignment = False
        Me.XrLabel33.Text = "asd"
        Me.XrLabel33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lbl_vat
        '
        Me.lbl_vat.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vat.LocationFloat = New DevExpress.Utils.PointFloat(530.0247!, 122.6248!)
        Me.lbl_vat.Multiline = True
        Me.lbl_vat.Name = "lbl_vat"
        Me.lbl_vat.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_vat.SizeF = New System.Drawing.SizeF(94.79175!, 17.79164!)
        Me.lbl_vat.StylePriority.UseFont = False
        Me.lbl_vat.StylePriority.UseTextAlignment = False
        Me.lbl_vat.Text = "VAT:"
        Me.lbl_vat.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel28
        '
        Me.XrLabel28.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel28.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?approved_date")})
        Me.XrLabel28.LocationFloat = New DevExpress.Utils.PointFloat(196.4834!, 204.0955!)
        Me.XrLabel28.Multiline = True
        Me.XrLabel28.Name = "XrLabel28"
        Me.XrLabel28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel28.SizeF = New System.Drawing.SizeF(163.1844!, 18.73811!)
        Me.XrLabel28.StylePriority.UseBorders = False
        Me.XrLabel28.StylePriority.UseTextAlignment = False
        Me.XrLabel28.Text = "XrLabel28"
        Me.XrLabel28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrLabel28.TextFormatString = "{0:MM/dd/yyyy}"
        '
        'XrLabel20
        '
        Me.XrLabel20.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel20.LocationFloat = New DevExpress.Utils.PointFloat(568.2333!, 40.29166!)
        Me.XrLabel20.Multiline = True
        Me.XrLabel20.Name = "XrLabel20"
        Me.XrLabel20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel20.SizeF = New System.Drawing.SizeF(56.58325!, 17.79163!)
        Me.XrLabel20.StylePriority.UseFont = False
        Me.XrLabel20.StylePriority.UseTextAlignment = False
        Me.XrLabel20.Text = "Discount:"
        Me.XrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLine1
        '
        Me.XrLine1.LineWidth = 5.0!
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(750.0!, 5.208333!)
        '
        'XrLabel22
        '
        Me.XrLabel22.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(602.0833!, 172.3039!)
        Me.XrLabel22.Multiline = True
        Me.XrLabel22.Name = "XrLabel22"
        Me.XrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel22.SizeF = New System.Drawing.SizeF(147.9167!, 17.79165!)
        Me.XrLabel22.StylePriority.UseFont = False
        Me.XrLabel22.StylePriority.UseTextAlignment = False
        Me.XrLabel22.Text = "[?amount_due!PHP 0,0.00]"
        Me.XrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrLabel21
        '
        Me.XrLabel21.Font = New System.Drawing.Font("Arial", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(452.0833!, 172.3039!)
        Me.XrLabel21.Multiline = True
        Me.XrLabel21.Name = "XrLabel21"
        Me.XrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel21.SizeF = New System.Drawing.SizeF(150.0!, 17.79165!)
        Me.XrLabel21.StylePriority.UseFont = False
        Me.XrLabel21.StylePriority.UseTextAlignment = False
        Me.XrLabel21.Text = "Total Amount Due:"
        Me.XrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel19
        '
        Me.XrLabel19.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Iif(IsNUllorEmpty(?discount_type), ''," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(9) & "Iif(?discount_type == 'peso', '', Round(" &
                    "?discount_val) + '%')" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & ")  ")})
        Me.XrLabel19.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic)
        Me.XrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(476.1499!, 40.29166!)
        Me.XrLabel19.Multiline = True
        Me.XrLabel19.Name = "XrLabel19"
        Me.XrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel19.SizeF = New System.Drawing.SizeF(92.08337!, 17.79164!)
        Me.XrLabel19.StylePriority.UseFont = False
        Me.XrLabel19.StylePriority.UseTextAlignment = False
        Me.XrLabel19.Text = "asd"
        Me.XrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'lbl_subtotal
        '
        Me.lbl_subtotal.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "Sum([total_cost])")})
        Me.lbl_subtotal.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_subtotal.LocationFloat = New DevExpress.Utils.PointFloat(624.8166!, 17.0!)
        Me.lbl_subtotal.Multiline = True
        Me.lbl_subtotal.Name = "lbl_subtotal"
        Me.lbl_subtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.lbl_subtotal.SizeF = New System.Drawing.SizeF(123.1003!, 17.79164!)
        Me.lbl_subtotal.StylePriority.UseFont = False
        Me.lbl_subtotal.StylePriority.UseTextAlignment = False
        Me.lbl_subtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        Me.lbl_subtotal.TextFormatString = "{0:N2}"
        '
        'XrLabel17
        '
        Me.XrLabel17.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(524.8165!, 17.0!)
        Me.XrLabel17.Multiline = True
        Me.XrLabel17.Name = "XrLabel17"
        Me.XrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel17.SizeF = New System.Drawing.SizeF(99.99997!, 17.79164!)
        Me.XrLabel17.StylePriority.UseFont = False
        Me.XrLabel17.StylePriority.UseTextAlignment = False
        Me.XrLabel17.Text = " Sub Total:"
        Me.XrLabel17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'XrRichText1
        '
        Me.XrRichText1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.XrRichText1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 17.00001!)
        Me.XrRichText1.Name = "XrRichText1"
        Me.XrRichText1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrRichText1.SerializableRtfString = resources.GetString("XrRichText1.SerializableRtfString")
        Me.XrRichText1.SizeF = New System.Drawing.SizeF(396.8749!, 100.4166!)
        Me.XrRichText1.StylePriority.UseFont = False
        '
        'XrLabel16
        '
        Me.XrLabel16.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel16.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(33.29833!, 127.2739!)
        Me.XrLabel16.Multiline = True
        Me.XrLabel16.Name = "XrLabel16"
        Me.XrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel16.SizeF = New System.Drawing.SizeF(163.1844!, 32.99413!)
        Me.XrLabel16.StylePriority.UseBorders = False
        Me.XrLabel16.StylePriority.UseFont = False
        Me.XrLabel16.StylePriority.UsePadding = False
        Me.XrLabel16.StylePriority.UseTextAlignment = False
        Me.XrLabel16.Text = "Prepared By"
        Me.XrLabel16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel23
        '
        Me.XrLabel23.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel23.LocationFloat = New DevExpress.Utils.PointFloat(196.4827!, 127.2739!)
        Me.XrLabel23.Multiline = True
        Me.XrLabel23.Name = "XrLabel23"
        Me.XrLabel23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel23.SizeF = New System.Drawing.SizeF(163.185!, 32.99415!)
        Me.XrLabel23.StylePriority.UseBorders = False
        Me.XrLabel23.StylePriority.UseFont = False
        Me.XrLabel23.StylePriority.UsePadding = False
        Me.XrLabel23.StylePriority.UseTextAlignment = False
        Me.XrLabel23.Text = "Approved By"
        Me.XrLabel23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel24
        '
        Me.XrLabel24.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel24.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?prepared_by")})
        Me.XrLabel24.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel24.LocationFloat = New DevExpress.Utils.PointFloat(33.2983!, 160.2681!)
        Me.XrLabel24.Multiline = True
        Me.XrLabel24.Name = "XrLabel24"
        Me.XrLabel24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 6, 100.0!)
        Me.XrLabel24.SizeF = New System.Drawing.SizeF(163.185!, 62.57747!)
        Me.XrLabel24.StylePriority.UseBorders = False
        Me.XrLabel24.StylePriority.UseFont = False
        Me.XrLabel24.StylePriority.UsePadding = False
        Me.XrLabel24.StylePriority.UseTextAlignment = False
        Me.XrLabel24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'XrLabel25
        '
        Me.XrLabel25.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrLabel25.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "?approved_by")})
        Me.XrLabel25.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.XrLabel25.LocationFloat = New DevExpress.Utils.PointFloat(196.4834!, 160.2681!)
        Me.XrLabel25.Multiline = True
        Me.XrLabel25.Name = "XrLabel25"
        Me.XrLabel25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel25.SizeF = New System.Drawing.SizeF(163.1844!, 43.82744!)
        Me.XrLabel25.StylePriority.UseBorders = False
        Me.XrLabel25.StylePriority.UseFont = False
        Me.XrLabel25.StylePriority.UsePadding = False
        Me.XrLabel25.StylePriority.UseTextAlignment = False
        Me.XrLabel25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
        '
        'total
        '
        Me.total.Description = "total"
        Me.total.Name = "total"
        Me.total.Type = GetType(Decimal)
        Me.total.ValueInfo = "0"
        Me.total.Visible = False
        '
        'amount_due
        '
        Me.amount_due.Description = "amount_due"
        Me.amount_due.Name = "amount_due"
        Me.amount_due.Type = GetType(Decimal)
        Me.amount_due.ValueInfo = "0"
        Me.amount_due.Visible = False
        '
        'sub_total
        '
        Me.sub_total.DataMember = "purchase_order_slip"
        Me.sub_total.Expression = "Sum([total_cost])"
        Me.sub_total.FieldType = DevExpress.XtraReports.UI.FieldType.[Decimal]
        Me.sub_total.Name = "sub_total"
        '
        'discount_type
        '
        Me.discount_type.Description = "discount_type"
        Me.discount_type.Name = "discount_type"
        Me.discount_type.Visible = False
        '
        'discount_val
        '
        Me.discount_val.Description = "discount_val"
        Me.discount_val.Name = "discount_val"
        Me.discount_val.Type = GetType(Decimal)
        Me.discount_val.ValueInfo = "0"
        Me.discount_val.Visible = False
        '
        'store_info
        '
        Me.store_info.Description = "store_info"
        Me.store_info.Name = "store_info"
        Me.store_info.Visible = False
        '
        'prepared_by
        '
        Me.prepared_by.Description = "prepared_by"
        Me.prepared_by.Name = "prepared_by"
        Me.prepared_by.Visible = False
        '
        'approved_by
        '
        Me.approved_by.Description = "approved_by"
        Me.approved_by.Name = "approved_by"
        Me.approved_by.Visible = False
        '
        'lead_time
        '
        Me.lead_time.Description = "lead_time"
        Me.lead_time.Name = "lead_time"
        Me.lead_time.Type = GetType(Date)
        Me.lead_time.ValueInfo = "2000-01-01"
        Me.lead_time.Visible = False
        '
        'approved_date
        '
        Me.approved_date.Description = "approved_date"
        Me.approved_date.Name = "approved_date"
        Me.approved_date.Type = GetType(Date)
        Me.approved_date.ValueInfo = "2000-01-01"
        Me.approved_date.Visible = False
        '
        'expiration_date
        '
        Me.expiration_date.Description = "expiration_date"
        Me.expiration_date.Name = "expiration_date"
        Me.expiration_date.Type = GetType(Date)
        Me.expiration_date.ValueInfo = "2021-04-07"
        Me.expiration_date.Visible = False
        '
        'terms
        '
        Me.terms.Description = "terms"
        Me.terms.Name = "terms"
        Me.terms.Type = GetType(Integer)
        Me.terms.ValueInfo = "0"
        Me.terms.Visible = False
        '
        'is_vatable
        '
        Me.is_vatable.Description = "is_vatable"
        Me.is_vatable.Name = "is_vatable"
        Me.is_vatable.Type = GetType(Boolean)
        Me.is_vatable.ValueInfo = "True"
        Me.is_vatable.Visible = False
        '
        'is_withholding_tax_applied
        '
        Me.is_withholding_tax_applied.Description = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.Name = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.Type = GetType(Boolean)
        Me.is_withholding_tax_applied.ValueInfo = "False"
        Me.is_withholding_tax_applied.Visible = False
        '
        'withholding_tax_percentage
        '
        Me.withholding_tax_percentage.Description = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Name = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Type = GetType(Decimal)
        Me.withholding_tax_percentage.ValueInfo = "0"
        Me.withholding_tax_percentage.Visible = False
        '
        'withholding_tax_amount
        '
        Me.withholding_tax_amount.Description = "withholding_tax_amount"
        Me.withholding_tax_amount.Name = "withholding_tax_amount"
        Me.withholding_tax_amount.Type = GetType(Decimal)
        Me.withholding_tax_amount.ValueInfo = "0"
        Me.withholding_tax_amount.Visible = False
        '
        'pub_notes
        '
        Me.pub_notes.Description = "pub_notes"
        Me.pub_notes.Name = "pub_notes"
        Me.pub_notes.Visible = False
        '
        'store_name
        '
        Me.store_name.Description = "store_name"
        Me.store_name.Name = "store_name"
        Me.store_name.Visible = False
        '
        'vat_rate
        '
        Me.vat_rate.Description = "vat_rate"
        Me.vat_rate.Name = "vat_rate"
        Me.vat_rate.Type = GetType(Decimal)
        Me.vat_rate.ValueInfo = "1.12"
        Me.vat_rate.Visible = False
        '
        'doc_purchase_order
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.CalculatedFields.AddRange(New DevExpress.XtraReports.UI.CalculatedField() {Me.sub_total})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.PrintData1})
        Me.DataMember = "purchase_order_slip"
        Me.DataSource = Me.PrintData1
        Me.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Margins = New System.Drawing.Printing.Margins(50, 50, 50, 50)
        Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() {Me.supplier, Me.contact_person, Me.delivery_addr, Me.deliver_to, Me.pid, Me.print_date, Me.total, Me.amount_due, Me.discount_type, Me.discount_val, Me.store_info, Me.prepared_by, Me.approved_by, Me.lead_time, Me.approved_date, Me.expiration_date, Me.terms, Me.is_vatable, Me.is_withholding_tax_applied, Me.withholding_tax_percentage, Me.withholding_tax_amount, Me.pub_notes, Me.store_name, Me.vat_rate})
        Me.Version = "22.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrintData1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrRichText1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
	Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
	Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
	Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
	Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel5 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel9 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel8 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel12 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel11 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel10 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents PrintData1 As PrintData
	Friend WithEvents supplier As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents contact_person As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents delivery_addr As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents deliver_to As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel13 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
	Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
	Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
	Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
	Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
	Friend WithEvents XrLabel15 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel14 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents pid As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents print_date As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
	Friend WithEvents XrRichText1 As DevExpress.XtraReports.UI.XRRichText
	Friend WithEvents XrLabel22 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel21 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel19 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents lbl_subtotal As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel17 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents total As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents amount_due As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents sub_total As DevExpress.XtraReports.UI.CalculatedField
	Friend WithEvents discount_type As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents discount_val As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents XrLabel20 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents store_info As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel16 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel23 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel24 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel25 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents prepared_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents approved_by As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel27 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel26 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents lead_time As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents approved_date As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel28 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel29 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel30 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents expiration_date As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents XrLabel31 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel32 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents terms As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents lbl_discount As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLine3 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents XrLabel38 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel37 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel36 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents lbl_total_sales As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
	Friend WithEvents XrLabel33 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents lbl_vat As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel42 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents XrLabel40 As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents lbl_vatable_sales As DevExpress.XtraReports.UI.XRLabel
	Friend WithEvents is_vatable As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents is_withholding_tax_applied As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents withholding_tax_percentage As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents withholding_tax_amount As DevExpress.XtraReports.Parameters.Parameter
	Friend WithEvents pub_notes As Parameter
	Friend WithEvents XrLabel35 As XRLabel
	Friend WithEvents XrLabel18 As XRLabel
    Friend WithEvents store_name As Parameter
    Friend WithEvents XrTableCell12 As XRTableCell
    Friend WithEvents XrTableCell11 As XRTableCell
    Friend WithEvents vat_rate As Parameter
End Class
