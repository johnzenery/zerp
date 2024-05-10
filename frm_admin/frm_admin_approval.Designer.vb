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
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_quotation = New DevExpress.XtraGrid.GridControl()
        Me.grid_quotation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_quotation_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_company = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_quote_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_createdby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_totalamount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_sales_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_sales_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_srid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_returns_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_returns_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_approval_units = New DevExpress.XtraGrid.GridControl()
        Me.grid_approval_units_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
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
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage_purchase_orders = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage_quotaions = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage_sales_return = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage_products = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage_stock_transfers = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage_transfer_reports = New DevExpress.XtraTab.XtraTabPage()
        Me.XtraTabPage_reconcilations = New DevExpress.XtraTab.XtraTabPage()
        Me.cb_show_declined = New DevExpress.XtraEditors.CheckButton()
        Me.cb_approved = New DevExpress.XtraEditors.CheckButton()
        Me.XtraTabPage_pullout_requests = New DevExpress.XtraTab.XtraTabPage()
        Me.btn_stockreturn_decline = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_stockreturn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stock_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_stockreturn_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_stockreturn_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_stockreturn_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_stockreturn_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_serial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn15 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_issue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_pullouts = New DevExpress.XtraGrid.GridControl()
        Me.grid_pullouts_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pullout_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_show_pullout_request = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_pullout_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabPage_stock_liquidation = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_liquidation = New DevExpress.XtraGrid.GridControl()
        Me.grid_liquidation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_liquidate_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn16 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn17 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn18 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_liquidation = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
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
        CType(Me.grid_transferReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transferReport_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_report_stockTransfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage_purchase_orders.SuspendLayout()
        Me.XtraTabPage_quotaions.SuspendLayout()
        Me.XtraTabPage_sales_return.SuspendLayout()
        Me.XtraTabPage_products.SuspendLayout()
        Me.XtraTabPage_stock_transfers.SuspendLayout()
        Me.XtraTabPage_transfer_reports.SuspendLayout()
        Me.XtraTabPage_reconcilations.SuspendLayout()
        Me.XtraTabPage_pullout_requests.SuspendLayout()
        CType(Me.grid_stock_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_pullouts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_pullouts_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_show_pullout_request, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage_stock_liquidation.SuspendLayout()
        CType(Me.grid_liquidation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_liquidation_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_liquidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_quotation
        '
        Me.grid_quotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_quotation.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_quotation.Location = New System.Drawing.Point(4, 75)
        Me.grid_quotation.MainView = Me.grid_quotation_view
        Me.grid_quotation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_quotation.Name = "grid_quotation"
        Me.grid_quotation.Size = New System.Drawing.Size(1492, 617)
        Me.grid_quotation.TabIndex = 16
        Me.grid_quotation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_quotation_view})
        '
        'grid_quotation_view
        '
        Me.grid_quotation_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_quotation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_quotation_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_quotation_view.Appearance.Row.Options.UseFont = True
        Me.grid_quotation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_quotation_id, Me.col_company, Me.col_quote_date_generated, Me.GridColumn7})
        Me.grid_quotation_view.DetailHeight = 431
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
        Me.col_quotation_id.MinWidth = 23
        Me.col_quotation_id.Name = "col_quotation_id"
        Me.col_quotation_id.Visible = True
        Me.col_quotation_id.VisibleIndex = 0
        Me.col_quotation_id.Width = 107
        '
        'col_company
        '
        Me.col_company.Caption = "Company"
        Me.col_company.FieldName = "company"
        Me.col_company.MinWidth = 23
        Me.col_company.Name = "col_company"
        Me.col_company.Visible = True
        Me.col_company.VisibleIndex = 1
        Me.col_company.Width = 751
        '
        'col_quote_date_generated
        '
        Me.col_quote_date_generated.Caption = "Date Generated"
        Me.col_quote_date_generated.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.col_quote_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_quote_date_generated.FieldName = "created_at"
        Me.col_quote_date_generated.MinWidth = 23
        Me.col_quote_date_generated.Name = "col_quote_date_generated"
        Me.col_quote_date_generated.Visible = True
        Me.col_quote_date_generated.VisibleIndex = 2
        Me.col_quote_date_generated.Width = 87
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Created by"
        Me.GridColumn7.FieldName = "prepared_by"
        Me.GridColumn7.MinWidth = 23
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 87
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Appearance.Options.UseTextOptions = True
        Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl5.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(290, 36)
        Me.LabelControl5.TabIndex = 15
        Me.LabelControl5.Text = "Approval - Quotations"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl3.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(354, 36)
        Me.LabelControl3.TabIndex = 4
        Me.LabelControl3.Text = "Approval - Stock Transfers"
        '
        'grid_stock_reconcilation
        '
        Me.grid_stock_reconcilation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_reconcilation.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_stock_reconcilation.Location = New System.Drawing.Point(4, 78)
        Me.grid_stock_reconcilation.MainView = Me.grid_stock_reconcilation_view
        Me.grid_stock_reconcilation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_stock_reconcilation.Name = "grid_stock_reconcilation"
        Me.grid_stock_reconcilation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit, Me.btn_delete})
        Me.grid_stock_reconcilation.Size = New System.Drawing.Size(1492, 614)
        Me.grid_stock_reconcilation.TabIndex = 14
        Me.grid_stock_reconcilation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_reconcilation_view})
        '
        'grid_stock_reconcilation_view
        '
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_stock_reconcilation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_reconcilation_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_stock_reconcilation_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_reconcilation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_reconcile_id, Me.GridColumn1, Me.col_reconcile_store, Me.col_reconcile_item, Me.col_reconcile_qty, Me.col_reconcile_type, Me.col_reconcile_notes, Me.col_reconcile_request_by})
        Me.grid_stock_reconcilation_view.DetailHeight = 431
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
        Me.col_reconcile_id.MinWidth = 23
        Me.col_reconcile_id.Name = "col_reconcile_id"
        Me.col_reconcile_id.Visible = True
        Me.col_reconcile_id.VisibleIndex = 0
        Me.col_reconcile_id.Width = 91
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.MinWidth = 23
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 5
        Me.GridColumn1.Width = 170
        '
        'col_reconcile_store
        '
        Me.col_reconcile_store.Caption = "Store / Warehouse"
        Me.col_reconcile_store.FieldName = "store_name"
        Me.col_reconcile_store.MinWidth = 23
        Me.col_reconcile_store.Name = "col_reconcile_store"
        Me.col_reconcile_store.Visible = True
        Me.col_reconcile_store.VisibleIndex = 4
        Me.col_reconcile_store.Width = 189
        '
        'col_reconcile_item
        '
        Me.col_reconcile_item.Caption = "Item"
        Me.col_reconcile_item.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_reconcile_item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_reconcile_item.FieldName = "winmodel"
        Me.col_reconcile_item.MinWidth = 23
        Me.col_reconcile_item.Name = "col_reconcile_item"
        Me.col_reconcile_item.Visible = True
        Me.col_reconcile_item.VisibleIndex = 3
        Me.col_reconcile_item.Width = 107
        '
        'col_reconcile_qty
        '
        Me.col_reconcile_qty.Caption = "Quantity"
        Me.col_reconcile_qty.FieldName = "qty"
        Me.col_reconcile_qty.MinWidth = 23
        Me.col_reconcile_qty.Name = "col_reconcile_qty"
        Me.col_reconcile_qty.Visible = True
        Me.col_reconcile_qty.VisibleIndex = 2
        Me.col_reconcile_qty.Width = 76
        '
        'col_reconcile_type
        '
        Me.col_reconcile_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_reconcile_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_reconcile_type.Caption = "Type"
        Me.col_reconcile_type.FieldName = "reconciled_type"
        Me.col_reconcile_type.MinWidth = 23
        Me.col_reconcile_type.Name = "col_reconcile_type"
        Me.col_reconcile_type.Visible = True
        Me.col_reconcile_type.VisibleIndex = 1
        Me.col_reconcile_type.Width = 93
        '
        'col_reconcile_notes
        '
        Me.col_reconcile_notes.Caption = "Notes"
        Me.col_reconcile_notes.FieldName = "notes"
        Me.col_reconcile_notes.MinWidth = 23
        Me.col_reconcile_notes.Name = "col_reconcile_notes"
        Me.col_reconcile_notes.Visible = True
        Me.col_reconcile_notes.VisibleIndex = 7
        Me.col_reconcile_notes.Width = 380
        '
        'col_reconcile_request_by
        '
        Me.col_reconcile_request_by.Caption = "Requested by"
        Me.col_reconcile_request_by.FieldName = "requested_by"
        Me.col_reconcile_request_by.MinWidth = 204
        Me.col_reconcile_request_by.Name = "col_reconcile_request_by"
        Me.col_reconcile_request_by.Visible = True
        Me.col_reconcile_request_by.VisibleIndex = 6
        Me.col_reconcile_request_by.Width = 204
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
        Me.LabelControl4.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(342, 36)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Approval - Reconcilations"
        '
        'grid_transfer
        '
        Me.grid_transfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transfer.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_transfer.Location = New System.Drawing.Point(4, 78)
        Me.grid_transfer.MainView = Me.grid_transfer_view
        Me.grid_transfer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_transfer.Name = "grid_transfer"
        Me.grid_transfer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_stockTransfer})
        Me.grid_transfer.Size = New System.Drawing.Size(1492, 614)
        Me.grid_transfer.TabIndex = 5
        Me.grid_transfer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transfer_view})
        '
        'grid_transfer_view
        '
        Me.grid_transfer_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_transfer_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transfer_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_transfer_view.Appearance.Row.Options.UseFont = True
        Me.grid_transfer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_transfer_id, Me.col_transfer_from, Me.col_transfer_status, Me.col_transfer_to, Me.col_action, Me.col_transferType, Me.col_created_by, Me.col_created_at})
        Me.grid_transfer_view.DetailHeight = 431
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
        Me.col_transfer_id.MaxWidth = 105
        Me.col_transfer_id.MinWidth = 23
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 1
        Me.col_transfer_id.Width = 93
        '
        'col_transfer_from
        '
        Me.col_transfer_from.Caption = "Source/Requesting Warehouse"
        Me.col_transfer_from.FieldName = "transfer_from"
        Me.col_transfer_from.MinWidth = 23
        Me.col_transfer_from.Name = "col_transfer_from"
        Me.col_transfer_from.Visible = True
        Me.col_transfer_from.VisibleIndex = 3
        Me.col_transfer_from.Width = 197
        '
        'col_transfer_status
        '
        Me.col_transfer_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_status.Caption = "Status"
        Me.col_transfer_status.FieldName = "status"
        Me.col_transfer_status.MaxWidth = 117
        Me.col_transfer_status.MinWidth = 23
        Me.col_transfer_status.Name = "col_transfer_status"
        Me.col_transfer_status.Visible = True
        Me.col_transfer_status.VisibleIndex = 5
        Me.col_transfer_status.Width = 112
        '
        'col_transfer_to
        '
        Me.col_transfer_to.Caption = "Affected Warehouse(s)"
        Me.col_transfer_to.FieldName = "transfer_to"
        Me.col_transfer_to.MinWidth = 23
        Me.col_transfer_to.Name = "col_transfer_to"
        Me.col_transfer_to.Visible = True
        Me.col_transfer_to.VisibleIndex = 4
        Me.col_transfer_to.Width = 154
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.btn_view_stockTransfer
        Me.col_action.MaxWidth = 58
        Me.col_action.MinWidth = 23
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 58
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
        Me.col_transferType.MaxWidth = 140
        Me.col_transferType.MinWidth = 23
        Me.col_transferType.Name = "col_transferType"
        Me.col_transferType.Visible = True
        Me.col_transferType.VisibleIndex = 2
        Me.col_transferType.Width = 87
        '
        'col_created_by
        '
        Me.col_created_by.Caption = "Created by"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.MaxWidth = 175
        Me.col_created_by.MinWidth = 23
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Visible = True
        Me.col_created_by.VisibleIndex = 6
        Me.col_created_by.Width = 87
        '
        'col_created_at
        '
        Me.col_created_at.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_at.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.Caption = "Created at"
        Me.col_created_at.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_created_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_created_at.FieldName = "created_at"
        Me.col_created_at.MaxWidth = 140
        Me.col_created_at.MinWidth = 23
        Me.col_created_at.Name = "col_created_at"
        Me.col_created_at.Visible = True
        Me.col_created_at.VisibleIndex = 7
        Me.col_created_at.Width = 87
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
        Me.LabelControl1.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(676, 25)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Approval - Products"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Appearance.Options.UseTextOptions = True
        Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl2.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(370, 36)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Approval - Purchase Orders"
        '
        'grid_po
        '
        Me.grid_po.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_po.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_po.Location = New System.Drawing.Point(4, 78)
        Me.grid_po.MainView = Me.grid_po_view
        Me.grid_po.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_po.Name = "grid_po"
        Me.grid_po.Size = New System.Drawing.Size(1492, 614)
        Me.grid_po.TabIndex = 2
        Me.grid_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_po_view})
        '
        'grid_po_view
        '
        Me.grid_po_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_po_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_po_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_po_view.Appearance.Row.Options.UseFont = True
        Me.grid_po_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_poid, Me.col_supplier, Me.col_po_status, Me.col_date_generated, Me.col_createdby, Me.col_totalamount})
        Me.grid_po_view.DetailHeight = 431
        Me.grid_po_view.GridControl = Me.grid_po
        Me.grid_po_view.Name = "grid_po_view"
        Me.grid_po_view.OptionsBehavior.Editable = False
        '
        'col_poid
        '
        Me.col_poid.AppearanceCell.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink
        Me.col_poid.AppearanceCell.Options.UseForeColor = True
        Me.col_poid.AppearanceCell.Options.UseTextOptions = True
        Me.col_poid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_poid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_poid.Caption = "Purchase ID"
        Me.col_poid.FieldName = "purchase_id"
        Me.col_poid.MinWidth = 23
        Me.col_poid.Name = "col_poid"
        Me.col_poid.Visible = True
        Me.col_poid.VisibleIndex = 0
        Me.col_poid.Width = 141
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 23
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.OptionsColumn.AllowEdit = False
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 1
        Me.col_supplier.Width = 259
        '
        'col_po_status
        '
        Me.col_po_status.Caption = "Status"
        Me.col_po_status.FieldName = "status"
        Me.col_po_status.MinWidth = 23
        Me.col_po_status.Name = "col_po_status"
        Me.col_po_status.Visible = True
        Me.col_po_status.VisibleIndex = 2
        Me.col_po_status.Width = 110
        '
        'col_date_generated
        '
        Me.col_date_generated.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_generated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_generated.Caption = "Date Generated"
        Me.col_date_generated.DisplayFormat.FormatString = "MMM dd, yyyy"
        Me.col_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_generated.FieldName = "date_generated"
        Me.col_date_generated.MinWidth = 23
        Me.col_date_generated.Name = "col_date_generated"
        Me.col_date_generated.Visible = True
        Me.col_date_generated.VisibleIndex = 3
        Me.col_date_generated.Width = 139
        '
        'col_createdby
        '
        Me.col_createdby.Caption = "Created by"
        Me.col_createdby.FieldName = "created_by"
        Me.col_createdby.MinWidth = 23
        Me.col_createdby.Name = "col_createdby"
        Me.col_createdby.Visible = True
        Me.col_createdby.VisibleIndex = 4
        Me.col_createdby.Width = 87
        '
        'col_totalamount
        '
        Me.col_totalamount.Caption = "Total Amount"
        Me.col_totalamount.DisplayFormat.FormatString = "n2"
        Me.col_totalamount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_totalamount.FieldName = "total"
        Me.col_totalamount.MinWidth = 23
        Me.col_totalamount.Name = "col_totalamount"
        Me.col_totalamount.Visible = True
        Me.col_totalamount.VisibleIndex = 5
        Me.col_totalamount.Width = 87
        '
        'grid_sales_returns
        '
        Me.grid_sales_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_sales_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_sales_returns.Location = New System.Drawing.Point(4, 78)
        Me.grid_sales_returns.MainView = Me.grid_sales_returns_view
        Me.grid_sales_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_sales_returns.Name = "grid_sales_returns"
        Me.grid_sales_returns.Size = New System.Drawing.Size(1492, 614)
        Me.grid_sales_returns.TabIndex = 5
        Me.grid_sales_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sales_returns_view})
        '
        'grid_sales_returns_view
        '
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_sales_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sales_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_sales_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_sales_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_srid, Me.col_customer, Me.col_amount, Me.col_returns_date_generated, Me.col_returns_warehouse})
        Me.grid_sales_returns_view.DetailHeight = 431
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
        Me.col_srid.MaxWidth = 93
        Me.col_srid.MinWidth = 23
        Me.col_srid.Name = "col_srid"
        Me.col_srid.Visible = True
        Me.col_srid.VisibleIndex = 0
        Me.col_srid.Width = 93
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.MaxWidth = 292
        Me.col_customer.MinWidth = 23
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 233
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.MaxWidth = 140
        Me.col_amount.MinWidth = 23
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 2
        Me.col_amount.Width = 140
        '
        'col_returns_date_generated
        '
        Me.col_returns_date_generated.Caption = "Date Generated"
        Me.col_returns_date_generated.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.col_returns_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_returns_date_generated.FieldName = "created_at"
        Me.col_returns_date_generated.MaxWidth = 233
        Me.col_returns_date_generated.MinWidth = 23
        Me.col_returns_date_generated.Name = "col_returns_date_generated"
        Me.col_returns_date_generated.Visible = True
        Me.col_returns_date_generated.VisibleIndex = 3
        Me.col_returns_date_generated.Width = 164
        '
        'col_returns_warehouse
        '
        Me.col_returns_warehouse.Caption = "Receiving Warehouse"
        Me.col_returns_warehouse.FieldName = "store_name"
        Me.col_returns_warehouse.MinWidth = 23
        Me.col_returns_warehouse.Name = "col_returns_warehouse"
        Me.col_returns_warehouse.Visible = True
        Me.col_returns_warehouse.VisibleIndex = 4
        Me.col_returns_warehouse.Width = 234
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
        Me.LabelControl6.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(322, 36)
        Me.LabelControl6.TabIndex = 4
        Me.LabelControl6.Text = "Approval - Sales Returns"
        '
        'grid_approval_units
        '
        Me.grid_approval_units.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_approval_units.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_approval_units.Location = New System.Drawing.Point(4, 78)
        Me.grid_approval_units.MainView = Me.grid_approval_units_view
        Me.grid_approval_units.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_approval_units.Name = "grid_approval_units"
        Me.grid_approval_units.Size = New System.Drawing.Size(1492, 618)
        Me.grid_approval_units.TabIndex = 0
        Me.grid_approval_units.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_approval_units_view})
        '
        'grid_approval_units_view
        '
        Me.grid_approval_units_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_approval_units_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_approval_units_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_approval_units_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_approval_units_view.Appearance.Row.Options.UseFont = True
        Me.grid_approval_units_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_model, Me.col_description, Me.col_status})
        Me.grid_approval_units_view.DetailHeight = 431
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
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 97
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MinWidth = 23
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 1
        Me.col_model.Width = 143
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 23
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 2
        Me.col_description.Width = 285
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 3
        Me.col_status.Width = 121
        '
        'grid_transferReport
        '
        Me.grid_transferReport.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transferReport.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_transferReport.Location = New System.Drawing.Point(4, 78)
        Me.grid_transferReport.MainView = Me.grid_transferReport_view
        Me.grid_transferReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_transferReport.Name = "grid_transferReport"
        Me.grid_transferReport.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_report_stockTransfer})
        Me.grid_transferReport.Size = New System.Drawing.Size(1492, 614)
        Me.grid_transferReport.TabIndex = 6
        Me.grid_transferReport.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transferReport_view})
        '
        'grid_transferReport_view
        '
        Me.grid_transferReport_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.grid_transferReport_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transferReport_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_transferReport_view.Appearance.Row.Options.UseFont = True
        Me.grid_transferReport_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_reportID, Me.GridColumn2, Me.GridColumn3, Me.GridColumn5, Me.GridColumn4, Me.GridColumn8, Me.GridColumn9, Me.GridColumn6})
        Me.grid_transferReport_view.DetailHeight = 431
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
        Me.col_reportID.MaxWidth = 93
        Me.col_reportID.MinWidth = 23
        Me.col_reportID.Name = "col_reportID"
        Me.col_reportID.Visible = True
        Me.col_reportID.VisibleIndex = 1
        Me.col_reportID.Width = 93
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Transfer ID"
        Me.GridColumn2.FieldName = "transfer_id"
        Me.GridColumn2.MaxWidth = 105
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 105
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Source"
        Me.GridColumn3.FieldName = "src_storeName"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 303
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Destination"
        Me.GridColumn5.FieldName = "des_storeName"
        Me.GridColumn5.MinWidth = 23
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 4
        Me.GridColumn5.Width = 321
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Status"
        Me.GridColumn4.FieldName = "status"
        Me.GridColumn4.MaxWidth = 117
        Me.GridColumn4.MinWidth = 23
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 5
        Me.GridColumn4.Width = 117
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Reported by"
        Me.GridColumn8.FieldName = "reported_by"
        Me.GridColumn8.MaxWidth = 175
        Me.GridColumn8.MinWidth = 23
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 175
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Reported at"
        Me.GridColumn9.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "received_date"
        Me.GridColumn9.MaxWidth = 140
        Me.GridColumn9.MinWidth = 23
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 140
        '
        'GridColumn6
        '
        Me.GridColumn6.ColumnEdit = Me.btn_view_report_stockTransfer
        Me.GridColumn6.MaxWidth = 58
        Me.GridColumn6.MinWidth = 23
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 58
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
        Me.LabelControl8.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(369, 36)
        Me.LabelControl8.TabIndex = 5
        Me.LabelControl8.Text = "Approval - Transfers Report"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.XtraTabControl1.AppearancePage.Header.Options.UseFont = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(4, 80)
        Me.XtraTabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage_purchase_orders
        Me.XtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.[True]
        Me.XtraTabControl1.Size = New System.Drawing.Size(1502, 734)
        Me.XtraTabControl1.TabIndex = 10
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage_purchase_orders, Me.XtraTabPage_quotaions, Me.XtraTabPage_sales_return, Me.XtraTabPage_products, Me.XtraTabPage_stock_transfers, Me.XtraTabPage_transfer_reports, Me.XtraTabPage_reconcilations, Me.XtraTabPage_pullout_requests, Me.XtraTabPage_stock_liquidation})
        '
        'XtraTabPage_purchase_orders
        '
        Me.XtraTabPage_purchase_orders.Controls.Add(Me.grid_po)
        Me.XtraTabPage_purchase_orders.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage_purchase_orders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_purchase_orders.Name = "XtraTabPage_purchase_orders"
        Me.XtraTabPage_purchase_orders.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_purchase_orders.Text = "Purchase Orders"
        '
        'XtraTabPage_quotaions
        '
        Me.XtraTabPage_quotaions.Controls.Add(Me.grid_quotation)
        Me.XtraTabPage_quotaions.Controls.Add(Me.LabelControl5)
        Me.XtraTabPage_quotaions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_quotaions.Name = "XtraTabPage_quotaions"
        Me.XtraTabPage_quotaions.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_quotaions.Text = "Quotations"
        '
        'XtraTabPage_sales_return
        '
        Me.XtraTabPage_sales_return.Controls.Add(Me.grid_sales_returns)
        Me.XtraTabPage_sales_return.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage_sales_return.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_sales_return.Name = "XtraTabPage_sales_return"
        Me.XtraTabPage_sales_return.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_sales_return.Text = "Sales Returns"
        '
        'XtraTabPage_products
        '
        Me.XtraTabPage_products.Controls.Add(Me.grid_approval_units)
        Me.XtraTabPage_products.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage_products.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_products.Name = "XtraTabPage_products"
        Me.XtraTabPage_products.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_products.Text = "Products"
        '
        'XtraTabPage_stock_transfers
        '
        Me.XtraTabPage_stock_transfers.Controls.Add(Me.grid_transfer)
        Me.XtraTabPage_stock_transfers.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage_stock_transfers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_stock_transfers.Name = "XtraTabPage_stock_transfers"
        Me.XtraTabPage_stock_transfers.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_stock_transfers.Text = "Stock Transfers"
        '
        'XtraTabPage_transfer_reports
        '
        Me.XtraTabPage_transfer_reports.Controls.Add(Me.grid_transferReport)
        Me.XtraTabPage_transfer_reports.Controls.Add(Me.LabelControl8)
        Me.XtraTabPage_transfer_reports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_transfer_reports.Name = "XtraTabPage_transfer_reports"
        Me.XtraTabPage_transfer_reports.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_transfer_reports.Text = "Transfer Reports"
        '
        'XtraTabPage_reconcilations
        '
        Me.XtraTabPage_reconcilations.Controls.Add(Me.cb_show_declined)
        Me.XtraTabPage_reconcilations.Controls.Add(Me.cb_approved)
        Me.XtraTabPage_reconcilations.Controls.Add(Me.grid_stock_reconcilation)
        Me.XtraTabPage_reconcilations.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage_reconcilations.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_reconcilations.Name = "XtraTabPage_reconcilations"
        Me.XtraTabPage_reconcilations.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_reconcilations.Text = "Reconcilations"
        '
        'cb_show_declined
        '
        Me.cb_show_declined.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_show_declined.Location = New System.Drawing.Point(1190, 16)
        Me.cb_show_declined.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_show_declined.Name = "cb_show_declined"
        Me.cb_show_declined.Size = New System.Drawing.Size(149, 52)
        Me.cb_show_declined.TabIndex = 16
        Me.cb_show_declined.Text = "Show Declined"
        '
        'cb_approved
        '
        Me.cb_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_approved.Location = New System.Drawing.Point(1346, 16)
        Me.cb_approved.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approved.Name = "cb_approved"
        Me.cb_approved.Size = New System.Drawing.Size(149, 52)
        Me.cb_approved.TabIndex = 15
        Me.cb_approved.Text = "Show Approved"
        '
        'XtraTabPage_pullout_requests
        '
        Me.XtraTabPage_pullout_requests.Controls.Add(Me.btn_stockreturn_decline)
        Me.XtraTabPage_pullout_requests.Controls.Add(Me.btn_stockreturn_approved)
        Me.XtraTabPage_pullout_requests.Controls.Add(Me.grid_stock_returns)
        Me.XtraTabPage_pullout_requests.Controls.Add(Me.LabelControl7)
        Me.XtraTabPage_pullout_requests.Controls.Add(Me.grid_pullouts)
        Me.XtraTabPage_pullout_requests.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabPage_pullout_requests.Name = "XtraTabPage_pullout_requests"
        Me.XtraTabPage_pullout_requests.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_pullout_requests.Text = "Stock Returns"
        '
        'btn_stockreturn_decline
        '
        Me.btn_stockreturn_decline.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_stockreturn_decline.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_stockreturn_decline.Appearance.Options.UseBackColor = True
        Me.btn_stockreturn_decline.Location = New System.Drawing.Point(1363, 639)
        Me.btn_stockreturn_decline.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_stockreturn_decline.Name = "btn_stockreturn_decline"
        Me.btn_stockreturn_decline.Size = New System.Drawing.Size(126, 50)
        Me.btn_stockreturn_decline.TabIndex = 141
        Me.btn_stockreturn_decline.Text = "Decline"
        '
        'btn_stockreturn_approved
        '
        Me.btn_stockreturn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_stockreturn_approved.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_stockreturn_approved.Appearance.Options.UseBackColor = True
        Me.btn_stockreturn_approved.Location = New System.Drawing.Point(1230, 639)
        Me.btn_stockreturn_approved.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_stockreturn_approved.Name = "btn_stockreturn_approved"
        Me.btn_stockreturn_approved.Size = New System.Drawing.Size(126, 50)
        Me.btn_stockreturn_approved.TabIndex = 140
        Me.btn_stockreturn_approved.Text = "Approve"
        '
        'grid_stock_returns
        '
        Me.grid_stock_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_stock_returns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_returns.Location = New System.Drawing.Point(4, 78)
        Me.grid_stock_returns.MainView = Me.grid_stock_returns_view
        Me.grid_stock_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_stock_returns.Name = "grid_stock_returns"
        Me.grid_stock_returns.Size = New System.Drawing.Size(1492, 551)
        Me.grid_stock_returns.TabIndex = 139
        Me.grid_stock_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_returns_view})
        '
        'grid_stock_returns_view
        '
        Me.grid_stock_returns_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_stock_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_stock_returns_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_stock_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_returns_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_stock_returns_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_stock_returns_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_stock_returns_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_stock_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_stockreturn_rid, Me.col_stockreturn_qty, Me.col_stockreturn_winmodel, Me.col_stockreturn_supmodel, Me.GridColumn14, Me.col_serial, Me.col_warehouse, Me.col_type, Me.GridColumn15, Me.col_issue, Me.col_comments})
        Me.grid_stock_returns_view.DetailHeight = 431
        Me.grid_stock_returns_view.GridControl = Me.grid_stock_returns
        Me.grid_stock_returns_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_stock_returns_view.Name = "grid_stock_returns_view"
        Me.grid_stock_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_returns_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_stock_returns_view.OptionsSelection.MultiSelect = True
        Me.grid_stock_returns_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_stock_returns_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_stockreturn_rid
        '
        Me.col_stockreturn_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_stockreturn_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_stockreturn_rid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_stockreturn_rid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_stockreturn_rid.Caption = "RID"
        Me.col_stockreturn_rid.FieldName = "id"
        Me.col_stockreturn_rid.MaxWidth = 70
        Me.col_stockreturn_rid.MinWidth = 12
        Me.col_stockreturn_rid.Name = "col_stockreturn_rid"
        Me.col_stockreturn_rid.Visible = True
        Me.col_stockreturn_rid.VisibleIndex = 1
        Me.col_stockreturn_rid.Width = 54
        '
        'col_stockreturn_qty
        '
        Me.col_stockreturn_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_stockreturn_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_stockreturn_qty.Caption = "QTY"
        Me.col_stockreturn_qty.FieldName = "qty"
        Me.col_stockreturn_qty.MaxWidth = 70
        Me.col_stockreturn_qty.MinWidth = 23
        Me.col_stockreturn_qty.Name = "col_stockreturn_qty"
        Me.col_stockreturn_qty.Visible = True
        Me.col_stockreturn_qty.VisibleIndex = 2
        Me.col_stockreturn_qty.Width = 54
        '
        'col_stockreturn_winmodel
        '
        Me.col_stockreturn_winmodel.Caption = "Win. Model"
        Me.col_stockreturn_winmodel.FieldName = "winmodel"
        Me.col_stockreturn_winmodel.MaxWidth = 140
        Me.col_stockreturn_winmodel.MinWidth = 23
        Me.col_stockreturn_winmodel.Name = "col_stockreturn_winmodel"
        Me.col_stockreturn_winmodel.Visible = True
        Me.col_stockreturn_winmodel.VisibleIndex = 3
        Me.col_stockreturn_winmodel.Width = 120
        '
        'col_stockreturn_supmodel
        '
        Me.col_stockreturn_supmodel.Caption = "Sup. Model"
        Me.col_stockreturn_supmodel.FieldName = "supmodel"
        Me.col_stockreturn_supmodel.MaxWidth = 140
        Me.col_stockreturn_supmodel.MinWidth = 23
        Me.col_stockreturn_supmodel.Name = "col_stockreturn_supmodel"
        Me.col_stockreturn_supmodel.Visible = True
        Me.col_stockreturn_supmodel.VisibleIndex = 4
        Me.col_stockreturn_supmodel.Width = 120
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn14.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn14.Caption = "Supplier"
        Me.GridColumn14.FieldName = "supplier"
        Me.GridColumn14.MaxWidth = 292
        Me.GridColumn14.MinWidth = 292
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 5
        Me.GridColumn14.Width = 292
        '
        'col_serial
        '
        Me.col_serial.AppearanceCell.Options.UseTextOptions = True
        Me.col_serial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MaxWidth = 163
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 6
        Me.col_serial.Width = 122
        '
        'col_warehouse
        '
        Me.col_warehouse.Caption = "Warehouse"
        Me.col_warehouse.FieldName = "warehouse"
        Me.col_warehouse.MaxWidth = 292
        Me.col_warehouse.MinWidth = 23
        Me.col_warehouse.Name = "col_warehouse"
        Me.col_warehouse.Visible = True
        Me.col_warehouse.VisibleIndex = 10
        Me.col_warehouse.Width = 117
        '
        'col_type
        '
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "type"
        Me.col_type.MaxWidth = 140
        Me.col_type.MinWidth = 23
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 7
        Me.col_type.Width = 120
        '
        'GridColumn15
        '
        Me.GridColumn15.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn15.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn15.Caption = "Status"
        Me.GridColumn15.FieldName = "status"
        Me.GridColumn15.MaxWidth = 140
        Me.GridColumn15.MinWidth = 23
        Me.GridColumn15.Name = "GridColumn15"
        Me.GridColumn15.Visible = True
        Me.GridColumn15.VisibleIndex = 9
        Me.GridColumn15.Width = 120
        '
        'col_issue
        '
        Me.col_issue.Caption = "Issue / Defect"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 23
        Me.col_issue.Name = "col_issue"
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 8
        Me.col_issue.Width = 76
        '
        'col_comments
        '
        Me.col_comments.Caption = "Internal Comments"
        Me.col_comments.FieldName = "comments"
        Me.col_comments.MinWidth = 23
        Me.col_comments.Name = "col_comments"
        Me.col_comments.Visible = True
        Me.col_comments.VisibleIndex = 11
        Me.col_comments.Width = 50
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Appearance.Options.UseTextOptions = True
        Me.LabelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl7.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(334, 36)
        Me.LabelControl7.TabIndex = 138
        Me.LabelControl7.Text = "Approval - Stock Returns"
        '
        'grid_pullouts
        '
        Me.grid_pullouts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_pullouts.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_pullouts.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_pullouts.Location = New System.Drawing.Point(1284, 4)
        Me.grid_pullouts.MainView = Me.grid_pullouts_view
        Me.grid_pullouts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_pullouts.Name = "grid_pullouts"
        Me.grid_pullouts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_show_pullout_request})
        Me.grid_pullouts.Size = New System.Drawing.Size(211, 50)
        Me.grid_pullouts.TabIndex = 137
        Me.grid_pullouts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_pullouts_view})
        Me.grid_pullouts.Visible = False
        '
        'grid_pullouts_view
        '
        Me.grid_pullouts_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_pullouts_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_pullouts_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_pullouts_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_pullouts_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_pullouts_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_pullouts_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_pullouts_view.Appearance.Row.Options.UseFont = True
        Me.grid_pullouts_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_pullouts_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_pullouts_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_pullouts_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_pullouts_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pullout_action, Me.col_pullout_id, Me.GridColumn10, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13})
        Me.grid_pullouts_view.DetailHeight = 431
        Me.grid_pullouts_view.GridControl = Me.grid_pullouts
        Me.grid_pullouts_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_pullouts_view.Name = "grid_pullouts_view"
        Me.grid_pullouts_view.OptionsBehavior.ReadOnly = True
        Me.grid_pullouts_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_pullouts_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_pullout_action
        '
        Me.col_pullout_action.ColumnEdit = Me.btn_show_pullout_request
        Me.col_pullout_action.MaxWidth = 47
        Me.col_pullout_action.MinWidth = 23
        Me.col_pullout_action.Name = "col_pullout_action"
        Me.col_pullout_action.Visible = True
        Me.col_pullout_action.VisibleIndex = 0
        Me.col_pullout_action.Width = 47
        '
        'btn_show_pullout_request
        '
        Me.btn_show_pullout_request.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.up_16x161
        Me.btn_show_pullout_request.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_show_pullout_request.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_show_pullout_request.Name = "btn_show_pullout_request"
        Me.btn_show_pullout_request.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_pullout_id
        '
        Me.col_pullout_id.AppearanceCell.ForeColor = System.Drawing.Color.SlateBlue
        Me.col_pullout_id.AppearanceCell.Options.UseForeColor = True
        Me.col_pullout_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_pullout_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pullout_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pullout_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pullout_id.Caption = "Pullout ID"
        Me.col_pullout_id.FieldName = "pullout_id"
        Me.col_pullout_id.MaxWidth = 87
        Me.col_pullout_id.MinWidth = 12
        Me.col_pullout_id.Name = "col_pullout_id"
        Me.col_pullout_id.Visible = True
        Me.col_pullout_id.VisibleIndex = 1
        Me.col_pullout_id.Width = 87
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Supplier"
        Me.GridColumn10.FieldName = "supplier"
        Me.GridColumn10.MaxWidth = 292
        Me.GridColumn10.MinWidth = 292
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 2
        Me.GridColumn10.Width = 292
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "Status"
        Me.GridColumn11.FieldName = "status"
        Me.GridColumn11.MaxWidth = 140
        Me.GridColumn11.MinWidth = 23
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 4
        Me.GridColumn11.Width = 138
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn12.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn12.Caption = "Created By"
        Me.GridColumn12.FieldName = "created_by"
        Me.GridColumn12.MaxWidth = 163
        Me.GridColumn12.MinWidth = 23
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 3
        Me.GridColumn12.Width = 153
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn13.Caption = "Created At"
        Me.GridColumn13.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn13.FieldName = "created_at"
        Me.GridColumn13.MaxWidth = 140
        Me.GridColumn13.MinWidth = 140
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 5
        Me.GridColumn13.Width = 140
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_refresh.Location = New System.Drawing.Point(4, 15)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(187, 57)
        Me.btn_refresh.TabIndex = 21
        Me.btn_refresh.Text = "Refresh"
        '
        'XtraTabPage_stock_liquidation
        '
        Me.XtraTabPage_stock_liquidation.Controls.Add(Me.grid_liquidation)
        Me.XtraTabPage_stock_liquidation.Controls.Add(Me.LabelControl9)
        Me.XtraTabPage_stock_liquidation.Name = "XtraTabPage_stock_liquidation"
        Me.XtraTabPage_stock_liquidation.Size = New System.Drawing.Size(1500, 696)
        Me.XtraTabPage_stock_liquidation.Text = "Stock Liquidation"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Appearance.Options.UseTextOptions = True
        Me.LabelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl9.Location = New System.Drawing.Point(18, 18)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(376, 36)
        Me.LabelControl9.TabIndex = 139
        Me.LabelControl9.Text = "Approval - Stock Liquidation"
        '
        'grid_liquidation
        '
        Me.grid_liquidation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_liquidation.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_liquidation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_liquidation.Location = New System.Drawing.Point(4, 78)
        Me.grid_liquidation.MainView = Me.grid_liquidation_view
        Me.grid_liquidation.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_liquidation.Name = "grid_liquidation"
        Me.grid_liquidation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_liquidation})
        Me.grid_liquidation.Size = New System.Drawing.Size(1492, 614)
        Me.grid_liquidation.TabIndex = 140
        Me.grid_liquidation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_liquidation_view})
        '
        'grid_liquidation_view
        '
        Me.grid_liquidation_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_liquidation_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_liquidation_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_liquidation_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_liquidation_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_liquidation_view.Appearance.Row.Options.UseFont = True
        Me.grid_liquidation_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_liquidation_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_liquidation_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_liquidation_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_liquidation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_liquidate_id, Me.GridColumn16, Me.GridColumn17, Me.GridColumn18, Me.GridColumn19})
        Me.grid_liquidation_view.DetailHeight = 431
        Me.grid_liquidation_view.GridControl = Me.grid_liquidation
        Me.grid_liquidation_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_liquidation_view.Name = "grid_liquidation_view"
        Me.grid_liquidation_view.OptionsBehavior.ReadOnly = True
        Me.grid_liquidation_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_liquidation_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_liquidate_id
        '
        Me.col_liquidate_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_liquidate_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_liquidate_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_liquidate_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_liquidate_id.Caption = "SLID"
        Me.col_liquidate_id.FieldName = "liquidation_id"
        Me.col_liquidate_id.MaxWidth = 120
        Me.col_liquidate_id.MinWidth = 12
        Me.col_liquidate_id.Name = "col_liquidate_id"
        Me.col_liquidate_id.Visible = True
        Me.col_liquidate_id.VisibleIndex = 1
        Me.col_liquidate_id.Width = 87
        '
        'GridColumn16
        '
        Me.GridColumn16.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn16.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn16.Caption = "Status"
        Me.GridColumn16.FieldName = "status"
        Me.GridColumn16.MaxWidth = 292
        Me.GridColumn16.MinWidth = 23
        Me.GridColumn16.Name = "GridColumn16"
        Me.GridColumn16.Visible = True
        Me.GridColumn16.VisibleIndex = 2
        Me.GridColumn16.Width = 292
        '
        'GridColumn17
        '
        Me.GridColumn17.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn17.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn17.Caption = "Created By"
        Me.GridColumn17.FieldName = "created_by"
        Me.GridColumn17.MaxWidth = 250
        Me.GridColumn17.MinWidth = 23
        Me.GridColumn17.Name = "GridColumn17"
        Me.GridColumn17.Visible = True
        Me.GridColumn17.VisibleIndex = 3
        Me.GridColumn17.Width = 250
        '
        'GridColumn18
        '
        Me.GridColumn18.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn18.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn18.Caption = "Created At"
        Me.GridColumn18.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn18.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn18.FieldName = "created_at"
        Me.GridColumn18.MaxWidth = 140
        Me.GridColumn18.MinWidth = 140
        Me.GridColumn18.Name = "GridColumn18"
        Me.GridColumn18.Visible = True
        Me.GridColumn18.VisibleIndex = 4
        Me.GridColumn18.Width = 140
        '
        'GridColumn19
        '
        Me.GridColumn19.ColumnEdit = Me.btn_view_liquidation
        Me.GridColumn19.MaxWidth = 47
        Me.GridColumn19.MinWidth = 23
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 0
        Me.GridColumn19.Width = 47
        '
        'btn_view_liquidation
        '
        Me.btn_view_liquidation.AutoHeight = False
        EditorButtonImageOptions4.Image = Global.Inventory_Management.My.Resources.Resources.up_16x161
        Me.btn_view_liquidation.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_liquidation.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_liquidation.Name = "btn_view_liquidation"
        Me.btn_view_liquidation.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frm_admin_approval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1507, 815)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_admin_approval"
        Me.Text = "Approvals"
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
        CType(Me.grid_transferReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transferReport_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_report_stockTransfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage_purchase_orders.ResumeLayout(False)
        Me.XtraTabPage_purchase_orders.PerformLayout()
        Me.XtraTabPage_quotaions.ResumeLayout(False)
        Me.XtraTabPage_quotaions.PerformLayout()
        Me.XtraTabPage_sales_return.ResumeLayout(False)
        Me.XtraTabPage_products.ResumeLayout(False)
        Me.XtraTabPage_stock_transfers.ResumeLayout(False)
        Me.XtraTabPage_stock_transfers.PerformLayout()
        Me.XtraTabPage_transfer_reports.ResumeLayout(False)
        Me.XtraTabPage_transfer_reports.PerformLayout()
        Me.XtraTabPage_reconcilations.ResumeLayout(False)
        Me.XtraTabPage_reconcilations.PerformLayout()
        Me.XtraTabPage_pullout_requests.ResumeLayout(False)
        Me.XtraTabPage_pullout_requests.PerformLayout()
        CType(Me.grid_stock_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_pullouts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_pullouts_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_show_pullout_request, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage_stock_liquidation.ResumeLayout(False)
        Me.XtraTabPage_stock_liquidation.PerformLayout()
        CType(Me.grid_liquidation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_liquidation_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_liquidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents col_action As GridColumn
    Friend WithEvents col_transferType As GridColumn
    Friend WithEvents col_created_by As GridColumn
    Friend WithEvents col_created_at As GridColumn
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
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage_purchase_orders As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_quotaions As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_sales_return As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_products As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_stock_transfers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_transfer_reports As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage_reconcilations As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_refresh As SimpleButton
    Friend WithEvents col_returns_date_generated As GridColumn
    Friend WithEvents col_returns_warehouse As GridColumn
    Friend WithEvents cb_approved As CheckButton
    Friend WithEvents col_quote_date_generated As GridColumn
    Friend WithEvents col_createdby As GridColumn
    Friend WithEvents col_totalamount As GridColumn
    Friend WithEvents GridColumn7 As GridColumn
    Friend WithEvents XtraTabPage_pullout_requests As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl7 As LabelControl
    Friend WithEvents grid_pullouts As GridControl
    Friend WithEvents grid_pullouts_view As GridView
    Friend WithEvents col_pullout_action As GridColumn
    Friend WithEvents btn_show_pullout_request As RepositoryItemButtonEdit
    Friend WithEvents col_pullout_id As GridColumn
    Friend WithEvents GridColumn10 As GridColumn
    Friend WithEvents GridColumn11 As GridColumn
    Friend WithEvents GridColumn12 As GridColumn
    Friend WithEvents GridColumn13 As GridColumn
    Friend WithEvents btn_stockreturn_decline As SimpleButton
    Friend WithEvents btn_stockreturn_approved As SimpleButton
    Friend WithEvents grid_stock_returns As GridControl
    Friend WithEvents grid_stock_returns_view As GridView
    Friend WithEvents col_stockreturn_rid As GridColumn
    Friend WithEvents col_stockreturn_qty As GridColumn
    Friend WithEvents col_stockreturn_winmodel As GridColumn
    Friend WithEvents col_stockreturn_supmodel As GridColumn
    Friend WithEvents GridColumn14 As GridColumn
    Friend WithEvents col_serial As GridColumn
    Friend WithEvents col_type As GridColumn
    Friend WithEvents GridColumn15 As GridColumn
    Friend WithEvents col_issue As GridColumn
    Friend WithEvents col_comments As GridColumn
    Friend WithEvents cb_show_declined As CheckButton
    Friend WithEvents col_warehouse As GridColumn
    Friend WithEvents XtraTabPage_stock_liquidation As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl9 As LabelControl
    Friend WithEvents grid_liquidation As GridControl
    Friend WithEvents grid_liquidation_view As GridView
    Friend WithEvents col_liquidate_id As GridColumn
    Friend WithEvents GridColumn16 As GridColumn
    Friend WithEvents GridColumn17 As GridColumn
    Friend WithEvents GridColumn18 As GridColumn
    Friend WithEvents GridColumn19 As GridColumn
    Friend WithEvents btn_view_liquidation As RepositoryItemButtonEdit
End Class
