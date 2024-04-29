
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraTab
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_product_catalogue
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.sw_view_stocks = New DevExpress.XtraEditors.ToggleSwitch()
        Me.grid_catalogue = New DevExpress.XtraGrid.GridControl()
        Me.grid_catalogue_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_srp_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_regular_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dealer_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_vip_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_my_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_onhold_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_other_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_technical_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_details = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_view_more = New System.Windows.Forms.LinkLabel()
        Me.txt_warranty = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_brand = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sub_category = New DevExpress.XtraEditors.TextEdit()
        Me.txt_main_category = New DevExpress.XtraEditors.TextEdit()
        Me.txt_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_hazards = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tags = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_weight = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_height = New DevExpress.XtraEditors.TextEdit()
        Me.txt_width = New DevExpress.XtraEditors.TextEdit()
        Me.txt_length = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_retail_price = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_description = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_winmodel = New DevExpress.XtraEditors.TextEdit()
        Me.txt_barcode = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.pb_product = New DevExpress.XtraEditors.PictureEdit()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.bgw_load_catalogue = New System.ComponentModel.BackgroundWorker()
        Me.details_panel = New DevExpress.XtraEditors.PanelControl()
        Me.link_view_image = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.SidePanel1 = New DevExpress.XtraEditors.SidePanel()
        Me.countdown_timer = New System.Windows.Forms.Timer(Me.components)
        Me.col_tags = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.sw_view_stocks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_catalogue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_catalogue_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_warranty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sub_category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_main_category.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_hazards.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tags.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_height.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_width.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_length.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_retail_price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_winmodel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_barcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_product.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.details_panel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.details_panel.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        Me.SidePanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl1.Location = New System.Drawing.Point(940, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "View Stocks"
        '
        'sw_view_stocks
        '
        Me.sw_view_stocks.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.sw_view_stocks.Location = New System.Drawing.Point(1019, 17)
        Me.sw_view_stocks.Name = "sw_view_stocks"
        Me.sw_view_stocks.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.sw_view_stocks.Properties.LookAndFeel.SkinName = "The Bezier"
        Me.sw_view_stocks.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.sw_view_stocks.Properties.OffText = "Hide"
        Me.sw_view_stocks.Properties.OnText = "Show"
        Me.sw_view_stocks.Size = New System.Drawing.Size(95, 20)
        Me.sw_view_stocks.TabIndex = 5
        '
        'grid_catalogue
        '
        Me.grid_catalogue.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_catalogue.Location = New System.Drawing.Point(0, 49)
        Me.grid_catalogue.MainView = Me.grid_catalogue_view
        Me.grid_catalogue.Name = "grid_catalogue"
        Me.grid_catalogue.Size = New System.Drawing.Size(1119, 865)
        Me.grid_catalogue.TabIndex = 4
        Me.grid_catalogue.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_catalogue_view})
        '
        'grid_catalogue_view
        '
        Me.grid_catalogue_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_catalogue_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_catalogue_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_catalogue_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_catalogue_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_catalogue_view.Appearance.Row.Options.UseFont = True
        Me.grid_catalogue_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.grid_catalogue_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_winmodel, Me.col_description, Me.col_main_category, Me.col_sub_category, Me.col_brand, Me.col_status, Me.col_srp_price, Me.col_regular_price, Me.col_dealer_price, Me.col_vip_price, Me.col_my_qty, Me.col_onhold_qty, Me.col_other_qty, Me.col_technical_desc, Me.col_tags})
        Me.grid_catalogue_view.GridControl = Me.grid_catalogue
        Me.grid_catalogue_view.Name = "grid_catalogue_view"
        Me.grid_catalogue_view.OptionsBehavior.ReadOnly = True
        Me.grid_catalogue_view.OptionsClipboard.CopyColumnHeaders = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_catalogue_view.OptionsLayout.Columns.AddNewColumns = False
        Me.grid_catalogue_view.OptionsLayout.Columns.RemoveOldColumns = False
        Me.grid_catalogue_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_pid.AppearanceHeader.Options.UseForeColor = True
        Me.col_pid.Caption = "Product ID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 120
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 50
        '
        'col_winmodel
        '
        Me.col_winmodel.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_winmodel.AppearanceHeader.Options.UseForeColor = True
        Me.col_winmodel.Caption = "Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MaxWidth = 200
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 102
        '
        'col_description
        '
        Me.col_description.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_description.AppearanceHeader.Options.UseForeColor = True
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 2
        Me.col_description.Width = 156
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Main Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 3
        Me.col_main_category.Width = 102
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 4
        Me.col_sub_category.Width = 70
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 5
        Me.col_brand.Width = 64
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_status.AppearanceHeader.Options.UseForeColor = True
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 100
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 8
        Me.col_status.Width = 59
        '
        'col_srp_price
        '
        Me.col_srp_price.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.col_srp_price.AppearanceCell.Options.UseBackColor = True
        Me.col_srp_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_srp_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_srp_price.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_srp_price.AppearanceHeader.Options.UseForeColor = True
        Me.col_srp_price.Caption = "SRP"
        Me.col_srp_price.DisplayFormat.FormatString = "n2"
        Me.col_srp_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_srp_price.FieldName = "regular_price"
        Me.col_srp_price.MaxWidth = 80
        Me.col_srp_price.Name = "col_srp_price"
        Me.col_srp_price.Visible = True
        Me.col_srp_price.VisibleIndex = 9
        Me.col_srp_price.Width = 52
        '
        'col_regular_price
        '
        Me.col_regular_price.Caption = "Regular Price"
        Me.col_regular_price.DisplayFormat.FormatString = "n2"
        Me.col_regular_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_regular_price.FieldName = "matrix_regular_price"
        Me.col_regular_price.MaxWidth = 100
        Me.col_regular_price.Name = "col_regular_price"
        Me.col_regular_price.Visible = True
        Me.col_regular_price.VisibleIndex = 10
        Me.col_regular_price.Width = 36
        '
        'col_dealer_price
        '
        Me.col_dealer_price.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.col_dealer_price.AppearanceCell.Options.UseBackColor = True
        Me.col_dealer_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_dealer_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_dealer_price.Caption = "Dealer"
        Me.col_dealer_price.DisplayFormat.FormatString = "n2"
        Me.col_dealer_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_dealer_price.FieldName = "matrix_dealer_price"
        Me.col_dealer_price.MaxWidth = 80
        Me.col_dealer_price.Name = "col_dealer_price"
        Me.col_dealer_price.Width = 63
        '
        'col_vip_price
        '
        Me.col_vip_price.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.col_vip_price.AppearanceCell.Options.UseBackColor = True
        Me.col_vip_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_vip_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_vip_price.Caption = "VIP"
        Me.col_vip_price.DisplayFormat.FormatString = "n2"
        Me.col_vip_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_vip_price.FieldName = "matrix_vip_price"
        Me.col_vip_price.MaxWidth = 80
        Me.col_vip_price.Name = "col_vip_price"
        Me.col_vip_price.Width = 63
        '
        'col_my_qty
        '
        Me.col_my_qty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_my_qty.AppearanceCell.Options.UseBackColor = True
        Me.col_my_qty.Caption = "MyStocks"
        Me.col_my_qty.FieldName = "qty"
        Me.col_my_qty.MaxWidth = 70
        Me.col_my_qty.MinWidth = 70
        Me.col_my_qty.Name = "col_my_qty"
        Me.col_my_qty.Visible = True
        Me.col_my_qty.VisibleIndex = 11
        Me.col_my_qty.Width = 70
        '
        'col_onhold_qty
        '
        Me.col_onhold_qty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_onhold_qty.AppearanceCell.Options.UseBackColor = True
        Me.col_onhold_qty.Caption = "On-hold"
        Me.col_onhold_qty.FieldName = "onhold"
        Me.col_onhold_qty.MaxWidth = 70
        Me.col_onhold_qty.MinWidth = 70
        Me.col_onhold_qty.Name = "col_onhold_qty"
        Me.col_onhold_qty.Visible = True
        Me.col_onhold_qty.VisibleIndex = 12
        Me.col_onhold_qty.Width = 70
        '
        'col_other_qty
        '
        Me.col_other_qty.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_other_qty.AppearanceCell.Options.UseBackColor = True
        Me.col_other_qty.Caption = "Others"
        Me.col_other_qty.FieldName = "other_qty"
        Me.col_other_qty.MaxWidth = 70
        Me.col_other_qty.MinWidth = 70
        Me.col_other_qty.Name = "col_other_qty"
        Me.col_other_qty.Visible = True
        Me.col_other_qty.VisibleIndex = 13
        Me.col_other_qty.Width = 70
        '
        'col_technical_desc
        '
        Me.col_technical_desc.Caption = "Technical Description"
        Me.col_technical_desc.FieldName = "technical_description"
        Me.col_technical_desc.Name = "col_technical_desc"
        Me.col_technical_desc.Visible = True
        Me.col_technical_desc.VisibleIndex = 6
        Me.col_technical_desc.Width = 138
        '
        'btn_print
        '
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.Appearance.Options.UseTextOptions = True
        Me.btn_print.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_print.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        Me.btn_print.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_print.Location = New System.Drawing.Point(5, 5)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(128, 39)
        Me.btn_print.TabIndex = 2
        Me.btn_print.Text = "Print"
        '
        'btn_details
        '
        Me.btn_details.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_details.Appearance.Options.UseFont = True
        Me.btn_details.Appearance.Options.UseTextOptions = True
        Me.btn_details.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_details.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_details.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_details.ImageOptions.ImageToTextIndent = 5
        Me.btn_details.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.detailed
        Me.btn_details.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_details.Location = New System.Drawing.Point(139, 5)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(113, 39)
        Me.btn_details.TabIndex = 3
        Me.btn_details.Text = "Details"
        '
        'lbl_view_more
        '
        Me.lbl_view_more.AutoSize = True
        Me.lbl_view_more.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.lbl_view_more.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_view_more.LinkColor = System.Drawing.Color.Purple
        Me.lbl_view_more.Location = New System.Drawing.Point(118, 337)
        Me.lbl_view_more.Name = "lbl_view_more"
        Me.lbl_view_more.Size = New System.Drawing.Size(60, 14)
        Me.lbl_view_more.TabIndex = 76
        Me.lbl_view_more.TabStop = True
        Me.lbl_view_more.Text = "View More"
        '
        'txt_warranty
        '
        Me.txt_warranty.EditValue = ""
        Me.txt_warranty.Location = New System.Drawing.Point(121, 533)
        Me.txt_warranty.Name = "txt_warranty"
        Me.txt_warranty.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_warranty.Properties.Appearance.Options.UseFont = True
        Me.txt_warranty.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_warranty.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_warranty.Properties.ReadOnly = True
        Me.txt_warranty.Size = New System.Drawing.Size(192, 59)
        Me.txt_warranty.TabIndex = 75
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Location = New System.Drawing.Point(14, 540)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(54, 16)
        Me.LabelControl22.TabIndex = 74
        Me.LabelControl22.Text = "Warranty"
        '
        'txt_brand
        '
        Me.txt_brand.EditValue = ""
        Me.txt_brand.Location = New System.Drawing.Point(121, 425)
        Me.txt_brand.Name = "txt_brand"
        Me.txt_brand.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_brand.Properties.Appearance.Options.UseFont = True
        Me.txt_brand.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_brand.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_brand.Properties.ReadOnly = True
        Me.txt_brand.Size = New System.Drawing.Size(122, 30)
        Me.txt_brand.TabIndex = 73
        '
        'txt_sub_category
        '
        Me.txt_sub_category.EditValue = ""
        Me.txt_sub_category.Location = New System.Drawing.Point(121, 389)
        Me.txt_sub_category.Name = "txt_sub_category"
        Me.txt_sub_category.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_sub_category.Properties.Appearance.Options.UseFont = True
        Me.txt_sub_category.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_sub_category.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_sub_category.Properties.ReadOnly = True
        Me.txt_sub_category.Size = New System.Drawing.Size(122, 30)
        Me.txt_sub_category.TabIndex = 72
        '
        'txt_main_category
        '
        Me.txt_main_category.EditValue = ""
        Me.txt_main_category.Location = New System.Drawing.Point(121, 353)
        Me.txt_main_category.Name = "txt_main_category"
        Me.txt_main_category.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_main_category.Properties.Appearance.Options.UseFont = True
        Me.txt_main_category.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_main_category.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_main_category.Properties.ReadOnly = True
        Me.txt_main_category.Size = New System.Drawing.Size(122, 30)
        Me.txt_main_category.TabIndex = 71
        '
        'txt_status
        '
        Me.txt_status.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txt_status.Appearance.Options.UseFont = True
        Me.txt_status.Appearance.Options.UseTextOptions = True
        Me.txt_status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_status.Location = New System.Drawing.Point(106, 50)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(49, 20)
        Me.txt_status.TabIndex = 70
        Me.txt_status.Text = "Active"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Location = New System.Drawing.Point(14, 54)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl21.TabIndex = 69
        Me.LabelControl21.Text = "Unit Status"
        '
        'txt_hazards
        '
        Me.txt_hazards.EditValue = ""
        Me.txt_hazards.Location = New System.Drawing.Point(121, 497)
        Me.txt_hazards.Name = "txt_hazards"
        Me.txt_hazards.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_hazards.Properties.Appearance.Options.UseFont = True
        Me.txt_hazards.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_hazards.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_hazards.Properties.ReadOnly = True
        Me.txt_hazards.Size = New System.Drawing.Size(192, 30)
        Me.txt_hazards.TabIndex = 67
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(14, 504)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl20.TabIndex = 66
        Me.LabelControl20.Text = "Hazards"
        '
        'txt_tags
        '
        Me.txt_tags.EditValue = ""
        Me.txt_tags.Location = New System.Drawing.Point(121, 461)
        Me.txt_tags.Name = "txt_tags"
        Me.txt_tags.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_tags.Properties.Appearance.Options.UseFont = True
        Me.txt_tags.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_tags.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_tags.Properties.ReadOnly = True
        Me.txt_tags.Size = New System.Drawing.Size(122, 30)
        Me.txt_tags.TabIndex = 65
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(13, 468)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl19.TabIndex = 64
        Me.LabelControl19.Text = "Tags"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(13, 432)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl17.TabIndex = 62
        Me.LabelControl17.Text = "Brand"
        '
        'txt_weight
        '
        Me.txt_weight.EditValue = ""
        Me.txt_weight.Location = New System.Drawing.Point(247, 38)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_weight.Properties.Appearance.Options.UseFont = True
        Me.txt_weight.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_weight.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_weight.Properties.ReadOnly = True
        Me.txt_weight.Size = New System.Drawing.Size(48, 30)
        Me.txt_weight.TabIndex = 45
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(170, 45)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl16.TabIndex = 44
        Me.LabelControl16.Text = "Weight (kg):"
        '
        'txt_height
        '
        Me.txt_height.EditValue = ""
        Me.txt_height.Location = New System.Drawing.Point(96, 110)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_height.Properties.Appearance.Options.UseFont = True
        Me.txt_height.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_height.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_height.Properties.ReadOnly = True
        Me.txt_height.Size = New System.Drawing.Size(48, 30)
        Me.txt_height.TabIndex = 43
        '
        'txt_width
        '
        Me.txt_width.EditValue = ""
        Me.txt_width.Location = New System.Drawing.Point(96, 74)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_width.Properties.Appearance.Options.UseFont = True
        Me.txt_width.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_width.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_width.Properties.ReadOnly = True
        Me.txt_width.Size = New System.Drawing.Size(48, 30)
        Me.txt_width.TabIndex = 42
        '
        'txt_length
        '
        Me.txt_length.EditValue = ""
        Me.txt_length.Location = New System.Drawing.Point(96, 38)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_length.Properties.Appearance.Options.UseFont = True
        Me.txt_length.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_length.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_length.Properties.ReadOnly = True
        Me.txt_length.Size = New System.Drawing.Size(48, 30)
        Me.txt_length.TabIndex = 41
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(16, 45)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl11.TabIndex = 26
        Me.LabelControl11.Text = "Length (cm):"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(16, 81)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl12.TabIndex = 27
        Me.LabelControl12.Text = "Width (cm):"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(16, 117)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl13.TabIndex = 28
        Me.LabelControl13.Text = "Height (cm):"
        '
        'txt_retail_price
        '
        Me.txt_retail_price.EditValue = ""
        Me.txt_retail_price.Location = New System.Drawing.Point(121, 230)
        Me.txt_retail_price.Name = "txt_retail_price"
        Me.txt_retail_price.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_retail_price.Properties.Appearance.Options.UseFont = True
        Me.txt_retail_price.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_retail_price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_retail_price.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_retail_price.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_retail_price.Properties.ReadOnly = True
        Me.txt_retail_price.Size = New System.Drawing.Size(146, 30)
        Me.txt_retail_price.TabIndex = 58
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(13, 237)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl6.TabIndex = 57
        Me.LabelControl6.Text = "SRP:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(14, 396)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl2.TabIndex = 55
        Me.LabelControl2.Text = "Sub Category"
        '
        'txt_description
        '
        Me.txt_description.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_description.EditValue = ""
        Me.txt_description.Location = New System.Drawing.Point(121, 266)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_description.Properties.Appearance.Options.UseFont = True
        Me.txt_description.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_description.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_description.Properties.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(214, 68)
        Me.txt_description.TabIndex = 53
        '
        'txt_winmodel
        '
        Me.txt_winmodel.EditValue = ""
        Me.txt_winmodel.Location = New System.Drawing.Point(121, 194)
        Me.txt_winmodel.Name = "txt_winmodel"
        Me.txt_winmodel.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_winmodel.Properties.Appearance.Options.UseFont = True
        Me.txt_winmodel.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_winmodel.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_winmodel.Properties.ReadOnly = True
        Me.txt_winmodel.Size = New System.Drawing.Size(214, 30)
        Me.txt_winmodel.TabIndex = 52
        '
        'txt_barcode
        '
        Me.txt_barcode.EditValue = ""
        Me.txt_barcode.Location = New System.Drawing.Point(86, 122)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_barcode.Properties.Appearance.Options.UseFont = True
        Me.txt_barcode.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.White
        Me.txt_barcode.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.txt_barcode.Properties.ReadOnly = True
        Me.txt_barcode.Size = New System.Drawing.Size(106, 30)
        Me.txt_barcode.TabIndex = 51
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(13, 273)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl10.TabIndex = 50
        Me.LabelControl10.Text = "Description:"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(13, 125)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl8.TabIndex = 49
        Me.LabelControl8.Text = "Barcode:"
        '
        'lbl_pid
        '
        Me.lbl_pid.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_pid.Appearance.Options.UseFont = True
        Me.lbl_pid.Location = New System.Drawing.Point(106, 84)
        Me.lbl_pid.Name = "lbl_pid"
        Me.lbl_pid.Size = New System.Drawing.Size(54, 20)
        Me.lbl_pid.TabIndex = 48
        Me.lbl_pid.Text = "000000"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(13, 87)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl4.TabIndex = 47
        Me.LabelControl4.Text = "Product SKU:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(13, 360)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl3.TabIndex = 46
        Me.LabelControl3.Text = "Main Category"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(14, 201)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl5.TabIndex = 45
        Me.LabelControl5.Text = "Winland Model:"
        '
        'pb_product
        '
        Me.pb_product.Location = New System.Drawing.Point(200, 50)
        Me.pb_product.Name = "pb_product"
        Me.pb_product.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pb_product.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pb_product.Size = New System.Drawing.Size(120, 120)
        Me.pb_product.TabIndex = 44
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(298, 284)
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(298, 271)
        '
        'bgw_load_catalogue
        '
        '
        'details_panel
        '
        Me.details_panel.Controls.Add(Me.link_view_image)
        Me.details_panel.Controls.Add(Me.GroupControl1)
        Me.details_panel.Controls.Add(Me.SeparatorControl1)
        Me.details_panel.Controls.Add(Me.lbl_view_more)
        Me.details_panel.Controls.Add(Me.LabelControl7)
        Me.details_panel.Controls.Add(Me.LabelControl21)
        Me.details_panel.Controls.Add(Me.txt_warranty)
        Me.details_panel.Controls.Add(Me.pb_product)
        Me.details_panel.Controls.Add(Me.LabelControl22)
        Me.details_panel.Controls.Add(Me.LabelControl5)
        Me.details_panel.Controls.Add(Me.txt_brand)
        Me.details_panel.Controls.Add(Me.LabelControl3)
        Me.details_panel.Controls.Add(Me.txt_sub_category)
        Me.details_panel.Controls.Add(Me.LabelControl4)
        Me.details_panel.Controls.Add(Me.txt_main_category)
        Me.details_panel.Controls.Add(Me.lbl_pid)
        Me.details_panel.Controls.Add(Me.txt_status)
        Me.details_panel.Controls.Add(Me.LabelControl8)
        Me.details_panel.Controls.Add(Me.LabelControl10)
        Me.details_panel.Controls.Add(Me.txt_hazards)
        Me.details_panel.Controls.Add(Me.txt_barcode)
        Me.details_panel.Controls.Add(Me.LabelControl20)
        Me.details_panel.Controls.Add(Me.txt_winmodel)
        Me.details_panel.Controls.Add(Me.txt_tags)
        Me.details_panel.Controls.Add(Me.txt_description)
        Me.details_panel.Controls.Add(Me.LabelControl19)
        Me.details_panel.Controls.Add(Me.LabelControl2)
        Me.details_panel.Controls.Add(Me.LabelControl17)
        Me.details_panel.Controls.Add(Me.LabelControl6)
        Me.details_panel.Controls.Add(Me.txt_retail_price)
        Me.details_panel.Location = New System.Drawing.Point(4, 3)
        Me.details_panel.Name = "details_panel"
        Me.details_panel.Size = New System.Drawing.Size(342, 899)
        Me.details_panel.TabIndex = 21
        '
        'link_view_image
        '
        Me.link_view_image.Location = New System.Drawing.Point(232, 173)
        Me.link_view_image.Name = "link_view_image"
        Me.link_view_image.Size = New System.Drawing.Size(55, 13)
        Me.link_view_image.TabIndex = 79
        Me.link_view_image.Text = "View Image"
        Me.link_view_image.Visible = False
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.txt_weight)
        Me.GroupControl1.Controls.Add(Me.LabelControl16)
        Me.GroupControl1.Controls.Add(Me.LabelControl11)
        Me.GroupControl1.Controls.Add(Me.txt_height)
        Me.GroupControl1.Controls.Add(Me.LabelControl13)
        Me.GroupControl1.Controls.Add(Me.txt_width)
        Me.GroupControl1.Controls.Add(Me.LabelControl12)
        Me.GroupControl1.Controls.Add(Me.txt_length)
        Me.GroupControl1.Location = New System.Drawing.Point(15, 607)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(320, 154)
        Me.GroupControl1.TabIndex = 78
        Me.GroupControl1.Text = "Dimensions"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.Location = New System.Drawing.Point(2, 24)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(335, 23)
        Me.SeparatorControl1.TabIndex = 77
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl7.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl7.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl7.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl7.Size = New System.Drawing.Size(338, 30)
        Me.LabelControl7.TabIndex = 75
        Me.LabelControl7.Text = "Item Details"
        '
        'PanelControl2
        '
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.btn_print)
        Me.PanelControl2.Controls.Add(Me.LabelControl1)
        Me.PanelControl2.Controls.Add(Me.sw_view_stocks)
        Me.PanelControl2.Controls.Add(Me.btn_details)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelControl2.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1119, 49)
        Me.PanelControl2.TabIndex = 74
        '
        'SidePanel1
        '
        Me.SidePanel1.AutoScroll = True
        Me.SidePanel1.BorderThickness = 0
        Me.SidePanel1.Controls.Add(Me.details_panel)
        Me.SidePanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SidePanel1.Location = New System.Drawing.Point(1119, 0)
        Me.SidePanel1.Name = "SidePanel1"
        Me.SidePanel1.Size = New System.Drawing.Size(364, 914)
        Me.SidePanel1.TabIndex = 76
        Me.SidePanel1.Text = "SidePanel1"
        Me.SidePanel1.Visible = False
        '
        'countdown_timer
        '
        Me.countdown_timer.Interval = 1000
        '
        'col_tags
        '
        Me.col_tags.Caption = "Tags"
        Me.col_tags.FieldName = "tags"
        Me.col_tags.Name = "col_tags"
        Me.col_tags.Visible = True
        Me.col_tags.VisibleIndex = 7
        '
        'frm_product_catalogue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1483, 914)
        Me.Controls.Add(Me.grid_catalogue)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.SidePanel1)
        Me.Name = "frm_product_catalogue"
        Me.Text = "Product Catalogue"
        CType(Me.sw_view_stocks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_catalogue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_catalogue_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_warranty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sub_category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_main_category.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_hazards.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tags.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_height.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_width.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_length.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_retail_price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_winmodel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_barcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_product.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.details_panel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.details_panel.ResumeLayout(False)
        Me.details_panel.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        Me.SidePanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txt_hazards As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_tags As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_weight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_height As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_width As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_length As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_retail_price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_winmodel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_barcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pb_product As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txt_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_main_category As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_brand As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sub_category As DevExpress.XtraEditors.TextEdit
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_details As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_warranty As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_catalogue As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_catalogue_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_srp_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents bgw_load_catalogue As System.ComponentModel.BackgroundWorker
    Friend WithEvents SplashScreenManager1 As DevExpress.XtraSplashScreen.SplashScreenManager
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dealer_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_vip_price As DevExpress.XtraGrid.Columns.GridColumn
    'MY EDIT
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents sw_view_stocks As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents col_my_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_onhold_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_other_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_view_more As LinkLabel
    Friend WithEvents PanelControl2 As PanelControl
    Friend WithEvents details_panel As PanelControl
    Friend WithEvents LabelControl7 As LabelControl
    Friend WithEvents SidePanel1 As SidePanel
    Friend WithEvents SeparatorControl1 As SeparatorControl
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents link_view_image As HyperlinkLabelControl
    Friend WithEvents col_regular_price As GridColumn
    Friend WithEvents countdown_timer As Timer
    Friend WithEvents col_technical_desc As GridColumn
    Friend WithEvents col_tags As GridColumn
End Class
