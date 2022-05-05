Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.Utils.Layout
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_approval
    Inherits System.Windows.Forms.Form

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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_quotation = New DevExpress.XtraGrid.GridControl()
        Me.grid_quotation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_quotation_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_company = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_stock_reconcilation = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_reconcilation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_reconcile_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_store = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_notes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reconcile_request_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_transfer = New DevExpress.XtraGrid.GridControl()
        Me.grid_transfer_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_stockTransfer = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_transferType = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_po = New DevExpress.XtraGrid.GridControl()
        Me.grid_po_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_poid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_sales_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_sales_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_srid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_approval_units = New DevExpress.XtraGrid.GridControl()
        Me.grid_approval_units_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tab_control = New System.Windows.Forms.TabControl()
        Me.tab_purchaseOrder = New System.Windows.Forms.TabPage()
        Me.tab_quotation = New System.Windows.Forms.TabPage()
        Me.tab_salesReturns = New System.Windows.Forms.TabPage()
        Me.tab_units = New System.Windows.Forms.TabPage()
        Me.tab_stockTransfer = New System.Windows.Forms.TabPage()
        Me.tab_transferReport = New System.Windows.Forms.TabPage()
        Me.grid_transferReport = New DevExpress.XtraGrid.GridControl()
        Me.grid_transferReport_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_reportID = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_report_stockTransfer = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.tab_reconcilations = New System.Windows.Forms.TabPage()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_quotation_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_reconcilation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_reconcilation_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transfer_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_stockTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_approval_units, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_approval_units_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control.SuspendLayout()
        Me.tab_purchaseOrder.SuspendLayout()
        Me.tab_quotation.SuspendLayout()
        Me.tab_salesReturns.SuspendLayout()
        Me.tab_units.SuspendLayout()
        Me.tab_stockTransfer.SuspendLayout()
        Me.tab_transferReport.SuspendLayout()
        CType(Me.grid_transferReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transferReport_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_report_stockTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_reconcilations.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.GunaLabel1)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1228, 78)
        Me.panel_top.TabIndex = 7
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel5.Location = New System.Drawing.Point(12, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1055, 27)
        Me.GunaPanel5.TabIndex = 6
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.link_po_list)
        Me.GunaPanel2.Controls.Add(Me.LabelControl7)
        Me.GunaPanel2.Controls.Add(Me.link_home)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel2.TabIndex = 1
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.Enabled = False
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(62, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Approvals"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        '
        'link_home
        '
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_home.Location = New System.Drawing.Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(135, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Approvals"
        '
        'grid_quotation
        '
        Me.grid_quotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_quotation.Location = New System.Drawing.Point(8, 57)
        Me.grid_quotation.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_quotation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_quotation.MainView = Me.grid_quotation_view
        Me.grid_quotation.Name = "grid_quotation"
        Me.grid_quotation.Size = New System.Drawing.Size(1178, 560)
        Me.grid_quotation.TabIndex = 16
        Me.grid_quotation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_quotation_view})
        '
        'grid_quotation_view
        '
        Me.grid_quotation_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_quotation_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_quotation_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_quotation_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_quotation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_quotation_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_quotation_view.Appearance.Row.Options.UseFont = True
        Me.grid_quotation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_quotation_id, Me.col_company})
        Me.grid_quotation_view.GridControl = Me.grid_quotation
        Me.grid_quotation_view.Name = "grid_quotation_view"
        Me.grid_quotation_view.OptionsBehavior.Editable = False
        '
        'col_quotation_id
        '
        Me.col_quotation_id.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_quotation_id.AppearanceCell.Options.UseForeColor = True
        Me.col_quotation_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.Caption = "Quote ID"
        Me.col_quotation_id.FieldName = "quotation_id"
        Me.col_quotation_id.Name = "col_quotation_id"
        Me.col_quotation_id.Visible = True
        Me.col_quotation_id.VisibleIndex = 0
        Me.col_quotation_id.Width = 92
        '
        'col_company
        '
        Me.col_company.Caption = "Company"
        Me.col_company.FieldName = "company"
        Me.col_company.Name = "col_company"
        Me.col_company.Visible = True
        Me.col_company.VisibleIndex = 1
        Me.col_company.Width = 473
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl5.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(217, 29)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Quotation Approvals"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(168, 29)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Stock Transfers"
        '
        'grid_stock_reconcilation
        '
        Me.grid_stock_reconcilation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_reconcilation.Location = New System.Drawing.Point(8, 57)
        Me.grid_stock_reconcilation.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_reconcilation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_reconcilation.MainView = Me.grid_stock_reconcilation_view
        Me.grid_stock_reconcilation.Name = "grid_stock_reconcilation"
        Me.grid_stock_reconcilation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit, Me.btn_delete})
        Me.grid_stock_reconcilation.Size = New System.Drawing.Size(1178, 560)
        Me.grid_stock_reconcilation.TabIndex = 14
        Me.grid_stock_reconcilation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_reconcilation_view})
        '
        'grid_stock_reconcilation_view
        '
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_reconcilation_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_reconcilation_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_reconcilation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_reconcile_id, Me.GridColumn1, Me.col_reconcile_store, Me.col_reconcile_item, Me.col_reconcile_qty, Me.col_reconcile_type, Me.col_reconcile_notes, Me.col_reconcile_request_by})
        Me.grid_stock_reconcilation_view.GridControl = Me.grid_stock_reconcilation
        Me.grid_stock_reconcilation_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_stock_reconcilation_view.Name = "grid_stock_reconcilation_view"
        Me.grid_stock_reconcilation_view.OptionsBehavior.Editable = False
        Me.grid_stock_reconcilation_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_stock_reconcilation_view.OptionsView.ColumnAutoWidth = False
        Me.grid_stock_reconcilation_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_reconcile_id
        '
        Me.col_reconcile_id.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_reconcile_id.AppearanceCell.Options.UseForeColor = True
        Me.col_reconcile_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_reconcile_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_reconcile_id.Caption = "ID"
        Me.col_reconcile_id.FieldName = "id"
        Me.col_reconcile_id.Name = "col_reconcile_id"
        Me.col_reconcile_id.Visible = True
        Me.col_reconcile_id.VisibleIndex = 0
        Me.col_reconcile_id.Width = 78
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 146
        '
        'col_reconcile_store
        '
        Me.col_reconcile_store.Caption = "Store / Warehouse"
        Me.col_reconcile_store.FieldName = "store_name"
        Me.col_reconcile_store.Name = "col_reconcile_store"
        Me.col_reconcile_store.Visible = True
        Me.col_reconcile_store.VisibleIndex = 4
        Me.col_reconcile_store.Width = 162
        '
        'col_reconcile_item
        '
        Me.col_reconcile_item.Caption = "Item"
        Me.col_reconcile_item.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_reconcile_item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_reconcile_item.FieldName = "winmodel"
        Me.col_reconcile_item.Name = "col_reconcile_item"
        Me.col_reconcile_item.Visible = True
        Me.col_reconcile_item.VisibleIndex = 3
        Me.col_reconcile_item.Width = 92
        '
        'col_reconcile_qty
        '
        Me.col_reconcile_qty.Caption = "Quantity"
        Me.col_reconcile_qty.FieldName = "qty"
        Me.col_reconcile_qty.Name = "col_reconcile_qty"
        Me.col_reconcile_qty.Visible = True
        Me.col_reconcile_qty.VisibleIndex = 2
        Me.col_reconcile_qty.Width = 56
        '
        'col_reconcile_type
        '
        Me.col_reconcile_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_reconcile_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_reconcile_type.Caption = "Type"
        Me.col_reconcile_type.FieldName = "reconciled_type"
        Me.col_reconcile_type.Name = "col_reconcile_type"
        Me.col_reconcile_type.Visible = True
        Me.col_reconcile_type.VisibleIndex = 1
        Me.col_reconcile_type.Width = 80
        '
        'col_reconcile_notes
        '
        Me.col_reconcile_notes.Caption = "Notes"
        Me.col_reconcile_notes.FieldName = "notes"
        Me.col_reconcile_notes.Name = "col_reconcile_notes"
        Me.col_reconcile_notes.Visible = True
        Me.col_reconcile_notes.VisibleIndex = 6
        '
        'col_reconcile_request_by
        '
        Me.col_reconcile_request_by.Caption = "Request By"
        Me.col_reconcile_request_by.FieldName = "requested_by"
        Me.col_reconcile_request_by.Name = "col_reconcile_request_by"
        Me.col_reconcile_request_by.Visible = True
        Me.col_reconcile_request_by.VisibleIndex = 7
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph)})
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Appearance.Options.UseTextOptions = True
        Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl4.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(158, 29)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Reconcilations"
        '
        'grid_transfer
        '
        Me.grid_transfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transfer.Location = New System.Drawing.Point(8, 57)
        Me.grid_transfer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_transfer.MainView = Me.grid_transfer_view
        Me.grid_transfer.Name = "grid_transfer"
        Me.grid_transfer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_stockTransfer})
        Me.grid_transfer.Size = New System.Drawing.Size(1178, 560)
        Me.grid_transfer.TabIndex = 5
        Me.grid_transfer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transfer_view})
        '
        'grid_transfer_view
        '
        Me.grid_transfer_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_transfer_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_transfer_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_transfer_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_transfer_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transfer_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_transfer_view.Appearance.Row.Options.UseFont = True
        Me.grid_transfer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_transfer_id, Me.col_transfer_from, Me.col_transfer_status, Me.col_transfer_to, Me.col_action, Me.col_transferType, Me.col_created_by, Me.col_created_at})
        Me.grid_transfer_view.GridControl = Me.grid_transfer
        Me.grid_transfer_view.Name = "grid_transfer_view"
        Me.grid_transfer_view.OptionsBehavior.ReadOnly = True
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.MaxWidth = 90
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 1
        Me.col_transfer_id.Width = 80
        '
        'col_transfer_from
        '
        Me.col_transfer_from.Caption = "From"
        Me.col_transfer_from.FieldName = "transfer_from"
        Me.col_transfer_from.Name = "col_transfer_from"
        Me.col_transfer_from.Visible = True
        Me.col_transfer_from.VisibleIndex = 3
        Me.col_transfer_from.Width = 169
        '
        'col_transfer_status
        '
        Me.col_transfer_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_status.Caption = "Status"
        Me.col_transfer_status.FieldName = "status"
        Me.col_transfer_status.MaxWidth = 100
        Me.col_transfer_status.Name = "col_transfer_status"
        Me.col_transfer_status.Visible = True
        Me.col_transfer_status.VisibleIndex = 5
        Me.col_transfer_status.Width = 96
        '
        'col_transfer_to
        '
        Me.col_transfer_to.Caption = "To"
        Me.col_transfer_to.FieldName = "transfer_to"
        Me.col_transfer_to.Name = "col_transfer_to"
        Me.col_transfer_to.Visible = True
        Me.col_transfer_to.VisibleIndex = 4
        Me.col_transfer_to.Width = 132
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.btn_view_stockTransfer
        Me.col_action.MaxWidth = 50
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 50
        '
        'btn_view_stockTransfer
        '
        Me.btn_view_stockTransfer.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view_stockTransfer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_stockTransfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_stockTransfer.Name = "btn_view_stockTransfer"
        Me.btn_view_stockTransfer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_transferType
        '
        Me.col_transferType.AppearanceCell.Options.UseTextOptions = True
        Me.col_transferType.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transferType.Caption = "Transfer Type"
        Me.col_transferType.FieldName = "transfer_type"
        Me.col_transferType.MaxWidth = 120
        Me.col_transferType.Name = "col_transferType"
        Me.col_transferType.Visible = True
        Me.col_transferType.VisibleIndex = 2
        '
        'col_created_by
        '
        Me.col_created_by.Caption = "Created by"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.MaxWidth = 150
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Visible = True
        Me.col_created_by.VisibleIndex = 6
        '
        'col_created_at
        '
        Me.col_created_at.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_at.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.Caption = "Created at"
        Me.col_created_at.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_created_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_created_at.FieldName = "created_at"
        Me.col_created_at.MaxWidth = 120
        Me.col_created_at.Name = "col_created_at"
        Me.col_created_at.Visible = True
        Me.col_created_at.VisibleIndex = 7
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(579, 20)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Inactive Units"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl2.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(182, 29)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Purchase Orders"
        '
        'grid_po
        '
        Me.grid_po.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_po.Location = New System.Drawing.Point(8, 57)
        Me.grid_po.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_po.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_po.MainView = Me.grid_po_view
        Me.grid_po.Name = "grid_po"
        Me.grid_po.Size = New System.Drawing.Size(1178, 560)
        Me.grid_po.TabIndex = 2
        Me.grid_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_po_view})
        '
        'grid_po_view
        '
        Me.grid_po_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_po_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_po_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_po_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_po_view.Appearance.Row.Options.UseFont = True
        Me.grid_po_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_poid, Me.col_date_generated, Me.col_supplier, Me.col_po_status})
        Me.grid_po_view.GridControl = Me.grid_po
        Me.grid_po_view.Name = "grid_po_view"
        Me.grid_po_view.OptionsBehavior.Editable = False
        '
        'col_poid
        '
        Me.col_poid.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_poid.AppearanceCell.Options.UseForeColor = True
        Me.col_poid.AppearanceCell.Options.UseTextOptions = True
        Me.col_poid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_poid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.Caption = "Purchase ID"
        Me.col_poid.FieldName = "purchase_id"
        Me.col_poid.Name = "col_poid"
        Me.col_poid.Visible = True
        Me.col_poid.VisibleIndex = 0
        Me.col_poid.Width = 121
        '
        'col_date_generated
        '
        Me.col_date_generated.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_generated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_generated.Caption = "Date Generated"
        Me.col_date_generated.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_generated.FieldName = "date_generated"
        Me.col_date_generated.Name = "col_date_generated"
        Me.col_date_generated.Visible = True
        Me.col_date_generated.VisibleIndex = 1
        Me.col_date_generated.Width = 119
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 222
        '
        'col_po_status
        '
        Me.col_po_status.Caption = "Status"
        Me.col_po_status.FieldName = "status"
        Me.col_po_status.Name = "col_po_status"
        Me.col_po_status.Visible = True
        Me.col_po_status.VisibleIndex = 3
        Me.col_po_status.Width = 94
        '
        'grid_sales_returns
        '
        Me.grid_sales_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_sales_returns.Location = New System.Drawing.Point(8, 57)
        Me.grid_sales_returns.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_sales_returns.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_sales_returns.MainView = Me.grid_sales_returns_view
        Me.grid_sales_returns.Name = "grid_sales_returns"
        Me.grid_sales_returns.Size = New System.Drawing.Size(1178, 560)
        Me.grid_sales_returns.TabIndex = 5
        Me.grid_sales_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sales_returns_view})
        '
        'grid_sales_returns_view
        '
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sales_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_sales_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_sales_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_srid, Me.col_customer, Me.col_amount})
        Me.grid_sales_returns_view.GridControl = Me.grid_sales_returns
        Me.grid_sales_returns_view.Name = "grid_sales_returns_view"
        Me.grid_sales_returns_view.OptionsBehavior.Editable = False
        '
        'col_srid
        '
        Me.col_srid.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_srid.AppearanceCell.Options.UseForeColor = True
        Me.col_srid.AppearanceCell.Options.UseTextOptions = True
        Me.col_srid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_srid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.Caption = "SRID"
        Me.col_srid.FieldName = "srid"
        Me.col_srid.Name = "col_srid"
        Me.col_srid.Visible = True
        Me.col_srid.VisibleIndex = 0
        Me.col_srid.Width = 83
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 244
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 2
        Me.col_amount.Width = 104
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Appearance.Options.UseTextOptions = True
        Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl6.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(579, 20)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Sales Returns"
        '
        'grid_approval_units
        '
        Me.grid_approval_units.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_approval_units.Location = New System.Drawing.Point(8, 57)
        Me.grid_approval_units.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_approval_units.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_approval_units.MainView = Me.grid_approval_units_view
        Me.grid_approval_units.Name = "grid_approval_units"
        Me.grid_approval_units.Size = New System.Drawing.Size(1178, 560)
        Me.grid_approval_units.TabIndex = 0
        Me.grid_approval_units.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_approval_units_view})
        '
        'grid_approval_units_view
        '
        Me.grid_approval_units_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_approval_units_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_approval_units_view.Appearance.Row.Options.UseFont = True
        Me.grid_approval_units_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_model, Me.col_description, Me.col_status})
        Me.grid_approval_units_view.GridControl = Me.grid_approval_units
        Me.grid_approval_units_view.Name = "grid_approval_units_view"
        Me.grid_approval_units_view.OptionsBehavior.Editable = False
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_pid.AppearanceCell.Options.UseForeColor = True
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "Product No."
        Me.col_pid.FieldName = "pid"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 83
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 1
        Me.col_model.Width = 123
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 2
        Me.col_description.Width = 244
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 3
        Me.col_status.Width = 104
        '
        'tab_control
        '
        Me.tab_control.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_control.Controls.Add(Me.tab_purchaseOrder)
        Me.tab_control.Controls.Add(Me.tab_quotation)
        Me.tab_control.Controls.Add(Me.tab_salesReturns)
        Me.tab_control.Controls.Add(Me.tab_units)
        Me.tab_control.Controls.Add(Me.tab_stockTransfer)
        Me.tab_control.Controls.Add(Me.tab_transferReport)
        Me.tab_control.Controls.Add(Me.tab_reconcilations)
        Me.tab_control.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.tab_control.Location = New System.Drawing.Point(12, 93)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedIndex = 0
        Me.tab_control.Size = New System.Drawing.Size(1204, 657)
        Me.tab_control.TabIndex = 9
        '
        'tab_purchaseOrder
        '
        Me.tab_purchaseOrder.Controls.Add(Me.LabelControl2)
        Me.tab_purchaseOrder.Controls.Add(Me.grid_po)
        Me.tab_purchaseOrder.Location = New System.Drawing.Point(4, 27)
        Me.tab_purchaseOrder.Name = "tab_purchaseOrder"
        Me.tab_purchaseOrder.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_purchaseOrder.Size = New System.Drawing.Size(1196, 626)
        Me.tab_purchaseOrder.TabIndex = 1
        Me.tab_purchaseOrder.Text = "Purchase Order"
        Me.tab_purchaseOrder.UseVisualStyleBackColor = True
        '
        'tab_quotation
        '
        Me.tab_quotation.Controls.Add(Me.grid_quotation)
        Me.tab_quotation.Controls.Add(Me.LabelControl5)
        Me.tab_quotation.Location = New System.Drawing.Point(4, 27)
        Me.tab_quotation.Name = "tab_quotation"
        Me.tab_quotation.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_quotation.Size = New System.Drawing.Size(1196, 626)
        Me.tab_quotation.TabIndex = 0
        Me.tab_quotation.Text = "Quotation"
        Me.tab_quotation.UseVisualStyleBackColor = True
        '
        'tab_salesReturns
        '
        Me.tab_salesReturns.Controls.Add(Me.grid_sales_returns)
        Me.tab_salesReturns.Controls.Add(Me.LabelControl6)
        Me.tab_salesReturns.Location = New System.Drawing.Point(4, 27)
        Me.tab_salesReturns.Name = "tab_salesReturns"
        Me.tab_salesReturns.Size = New System.Drawing.Size(1196, 626)
        Me.tab_salesReturns.TabIndex = 2
        Me.tab_salesReturns.Text = "Sales Returns"
        Me.tab_salesReturns.UseVisualStyleBackColor = True
        '
        'tab_units
        '
        Me.tab_units.Controls.Add(Me.grid_approval_units)
        Me.tab_units.Controls.Add(Me.LabelControl1)
        Me.tab_units.Location = New System.Drawing.Point(4, 27)
        Me.tab_units.Name = "tab_units"
        Me.tab_units.Size = New System.Drawing.Size(1196, 626)
        Me.tab_units.TabIndex = 3
        Me.tab_units.Text = "Units"
        Me.tab_units.UseVisualStyleBackColor = True
        '
        'tab_stockTransfer
        '
        Me.tab_stockTransfer.Controls.Add(Me.LabelControl3)
        Me.tab_stockTransfer.Controls.Add(Me.grid_transfer)
        Me.tab_stockTransfer.Location = New System.Drawing.Point(4, 27)
        Me.tab_stockTransfer.Name = "tab_stockTransfer"
        Me.tab_stockTransfer.Size = New System.Drawing.Size(1196, 626)
        Me.tab_stockTransfer.TabIndex = 4
        Me.tab_stockTransfer.Text = "Stock Transfer"
        Me.tab_stockTransfer.UseVisualStyleBackColor = True
        '
        'tab_transferReport
        '
        Me.tab_transferReport.Controls.Add(Me.grid_transferReport)
        Me.tab_transferReport.Controls.Add(Me.LabelControl8)
        Me.tab_transferReport.Location = New System.Drawing.Point(4, 27)
        Me.tab_transferReport.Name = "tab_transferReport"
        Me.tab_transferReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_transferReport.Size = New System.Drawing.Size(1196, 626)
        Me.tab_transferReport.TabIndex = 6
        Me.tab_transferReport.Text = "Transfer Report"
        Me.tab_transferReport.UseVisualStyleBackColor = True
        '
        'grid_transferReport
        '
        Me.grid_transferReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transferReport.Location = New System.Drawing.Point(8, 57)
        Me.grid_transferReport.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_transferReport.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_transferReport.MainView = Me.grid_transferReport_view
        Me.grid_transferReport.Name = "grid_transferReport"
        Me.grid_transferReport.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_report_stockTransfer})
        Me.grid_transferReport.Size = New System.Drawing.Size(1178, 560)
        Me.grid_transferReport.TabIndex = 6
        Me.grid_transferReport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transferReport_view})
        '
        'grid_transferReport_view
        '
        Me.grid_transferReport_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold)
        Me.grid_transferReport_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_transferReport_view.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.grid_transferReport_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_transferReport_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transferReport_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_transferReport_view.Appearance.Row.Options.UseFont = True
        Me.grid_transferReport_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_reportID, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn4, Me.GridColumn8, Me.GridColumn9, Me.GridColumn6})
        Me.grid_transferReport_view.GridControl = Me.grid_transferReport
        Me.grid_transferReport_view.Name = "grid_transferReport_view"
        Me.grid_transferReport_view.OptionsBehavior.ReadOnly = True
        '
        'col_reportID
        '
        Me.col_reportID.AppearanceCell.Options.UseTextOptions = True
        Me.col_reportID.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_reportID.Caption = "Report ID"
        Me.col_reportID.FieldName = "transfer_report_id"
        Me.col_reportID.MaxWidth = 80
        Me.col_reportID.Name = "col_reportID"
        Me.col_reportID.Visible = True
        Me.col_reportID.VisibleIndex = 1
        Me.col_reportID.Width = 80
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Transfer ID"
        Me.GridColumn2.FieldName = "transfer_id"
        Me.GridColumn2.MaxWidth = 90
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 90
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Source"
        Me.GridColumn3.FieldName = "src_storeName"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 260
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Destination"
        Me.GridColumn5.FieldName = "des_storeName"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 275
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Status"
        Me.GridColumn4.FieldName = "status"
        Me.GridColumn4.MaxWidth = 100
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 100
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Reported by"
        Me.GridColumn8.FieldName = "reported_by"
        Me.GridColumn8.MaxWidth = 150
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 150
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Reported at"
        Me.GridColumn9.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "received_date"
        Me.GridColumn9.MaxWidth = 120
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 120
        '
        'GridColumn6
        '
        Me.GridColumn6.ColumnEdit = Me.btn_view_report_stockTransfer
        Me.GridColumn6.MaxWidth = 50
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 50
        '
        'btn_view_report_stockTransfer
        '
        Me.btn_view_report_stockTransfer.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view_report_stockTransfer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_report_stockTransfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_report_stockTransfer.Name = "btn_view_report_stockTransfer"
        Me.btn_view_report_stockTransfer.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Appearance.Options.UseTextOptions = True
        Me.LabelControl8.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl8.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(248, 29)
        Me.LabelControl8.TabIndex = 5
        Me.LabelControl8.Text = "Stock Transfers Report"
        '
        'tab_reconcilations
        '
        Me.tab_reconcilations.Controls.Add(Me.grid_stock_reconcilation)
        Me.tab_reconcilations.Controls.Add(Me.LabelControl4)
        Me.tab_reconcilations.Location = New System.Drawing.Point(4, 27)
        Me.tab_reconcilations.Name = "tab_reconcilations"
        Me.tab_reconcilations.Size = New System.Drawing.Size(1196, 626)
        Me.tab_reconcilations.TabIndex = 5
        Me.tab_reconcilations.Text = "Reconcilations"
        Me.tab_reconcilations.UseVisualStyleBackColor = True
        '
        'frm_admin_approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1228, 762)
        Me.Controls.Add(Me.panel_top)
        Me.Controls.Add(Me.tab_control)
        Me.Name = "frm_admin_approval"
        Me.Text = "frm_admin_approval"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_quotation_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_reconcilation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_reconcilation_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transfer_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_stockTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_approval_units, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_approval_units_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control.ResumeLayout(False)
        Me.tab_purchaseOrder.ResumeLayout(False)
        Me.tab_purchaseOrder.PerformLayout()
        Me.tab_quotation.ResumeLayout(False)
        Me.tab_quotation.PerformLayout()
        Me.tab_salesReturns.ResumeLayout(False)
        Me.tab_units.ResumeLayout(False)
        Me.tab_stockTransfer.ResumeLayout(False)
        Me.tab_stockTransfer.PerformLayout()
        Me.tab_transferReport.ResumeLayout(False)
        Me.tab_transferReport.PerformLayout()
        CType(Me.grid_transferReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transferReport_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_report_stockTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_reconcilations.ResumeLayout(False)
        Me.tab_reconcilations.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_approval_units As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_approval_units_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_po As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_po_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_quotation As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_quotation_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_poid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_quotation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_company As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_po_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_transfer As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_transfer_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_from As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_transfer_to As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_generated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_stock_reconcilation As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_reconcilation_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_reconcile_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_store As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_reconcile_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_notes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reconcile_request_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_sales_returns As GridControl
    Friend WithEvents grid_sales_returns_view As GridView
    Friend WithEvents col_srid As GridColumn
    Friend WithEvents col_customer As GridColumn
    Friend WithEvents col_amount As GridColumn
    Friend WithEvents LabelControl6 As LabelControl
    Friend WithEvents tab_control As TabControl
    Friend WithEvents tab_quotation As TabPage
    Friend WithEvents tab_purchaseOrder As TabPage
    Friend WithEvents tab_salesReturns As TabPage
    Friend WithEvents tab_units As TabPage
    Friend WithEvents tab_stockTransfer As TabPage
    Friend WithEvents tab_reconcilations As TabPage
    Friend WithEvents col_action As GridColumn
    Friend WithEvents col_transferType As GridColumn
    Friend WithEvents col_created_by As GridColumn
    Friend WithEvents col_created_at As GridColumn
    Friend WithEvents tab_transferReport As TabPage
    Friend WithEvents grid_transferReport As GridControl
    Friend WithEvents grid_transferReport_view As GridView
    Friend WithEvents GridColumn2 As GridColumn
    Friend WithEvents GridColumn3 As GridColumn
    Friend WithEvents GridColumn4 As GridColumn
    Friend WithEvents GridColumn5 As GridColumn
    Friend WithEvents col_reportID As GridColumn
    Friend WithEvents GridColumn8 As GridColumn
    Friend WithEvents GridColumn9 As GridColumn
    Friend WithEvents LabelControl8 As LabelControl
    Friend WithEvents GridColumn6 As GridColumn
    Friend WithEvents btn_view_report_stockTransfer As RepositoryItemButtonEdit
    Friend WithEvents btn_view_stockTransfer As RepositoryItemButtonEdit
End Class
