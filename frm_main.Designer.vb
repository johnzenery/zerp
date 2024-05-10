
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSplashScreen
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Runtime.CompilerServices


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
    Inherits DevExpress.XtraBars.ToolbarForm.ToolbarForm

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
        Dim splashScreenManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.lbl_user_designation_id = New DevExpress.XtraEditors.LabelControl()
        Me.bgw_main = New System.ComponentModel.BackgroundWorker()
        Me.DocumentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
        Me.TabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
        Me.NoDocumentsView2 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
        Me.ToolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.ToolbarFormControl1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormControl()
        Me.ToolbarFormManager2 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
        Me.BarDockControl1 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl2 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl3 = New DevExpress.XtraBars.BarDockControl()
        Me.BarDockControl4 = New DevExpress.XtraBars.BarDockControl()
        Me.btn_account = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupControlContainer1 = New DevExpress.XtraBars.PopupControlContainer(Me.components)
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_zerp_database = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_zerp_version = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_user_designation = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.link_logout = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_user_role_id = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_user_id = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_user_role = New DevExpress.XtraEditors.LabelControl()
        Me.pe_user_photo = New DevExpress.XtraEditors.PictureEdit()
        Me.lbl_user_name = New DevExpress.XtraEditors.LabelControl()
        Me.BarSubItem3 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem4 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem5 = New DevExpress.XtraBars.BarSubItem()
        Me.BarSubItem6 = New DevExpress.XtraBars.BarSubItem()
        Me.menu2_sales = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_new_order = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_sales_orders = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_quotations = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_customers = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_customers_new = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_customers_registered = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_returns = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_discounting_matrix = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_invoices = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_warehouse = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_stock_management = New DevExpress.XtraBars.BarSubItem()
        Me.stock_management_transfer = New DevExpress.XtraBars.BarButtonItem()
        Me.stock_management_stocktransfer_logs = New DevExpress.XtraBars.BarButtonItem()
        Me.stock_management_returns = New DevExpress.XtraBars.BarButtonItem()
        Me.stock_management_reconcilations = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_package_management = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_receiving_management = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_inventory = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_new_deliveries = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_generate_barcode = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_generate_pricetag = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_logistics = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_release_orders = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_dispatch_transfers = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_stock_returns_releasing = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_collections = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_collection_orders = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_payment_terms = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_cheque_book = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_billing_statement = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_accounting = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_supplier_invoice = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_generate_payment_vouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_generated_payments = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_generated_vouchers = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_generated_cheques = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_generated_cash = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_purchasing = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_new_purhcase = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_purchase_orders = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_stock_return_to_vendor = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_credit_memo = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_purchase_delivery_logs = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu_purchase_request = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_administration = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_approvals = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_approvals_purchase_order = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_stock_transfer = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_quotations = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_sales_returns = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_stock_returns = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_transfer_reports = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_reconcilations = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_products = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_approvals_stock_liquidation = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_reports = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_product_database = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_price_book = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_price_matrix = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_registered_banks = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_user_management = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_warehouse = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_warehouse_new = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_warehouse_management = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_suppliers = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_suppliers_new = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_suppliers_management = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_company_information = New DevExpress.XtraBars.BarButtonItem()
        Me.menu2_config = New DevExpress.XtraBars.BarSubItem()
        Me.submenu2_printer = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem27 = New DevExpress.XtraBars.BarButtonItem()
        Me.submenu2_forecast = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem29 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem30 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarButtonItem31 = New DevExpress.XtraBars.BarButtonItem()
        Me.BarStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
        Me.SkinBarSubItem1 = New DevExpress.XtraBars.SkinBarSubItem()
        Me.menu2_catalog = New DevExpress.XtraBars.BarButtonItem()
        Me.RepositoryItemPopupContainerEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.RepositoryItemPictureEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NoDocumentsView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolbarFormControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolbarFormManager2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PopupControlContainer1.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pe_user_photo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splashScreenManager
        '
        splashScreenManager.ClosingDelay = 500
        '
        'lbl_user_designation_id
        '
        Me.lbl_user_designation_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lbl_user_designation_id.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_user_designation_id.Appearance.Options.UseFont = True
        Me.lbl_user_designation_id.Appearance.Options.UseForeColor = True
        Me.lbl_user_designation_id.Location = New System.Drawing.Point(295, 175)
        Me.lbl_user_designation_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_user_designation_id.Name = "lbl_user_designation_id"
        Me.lbl_user_designation_id.Size = New System.Drawing.Size(95, 17)
        Me.lbl_user_designation_id.TabIndex = 20
        Me.lbl_user_designation_id.Text = "Designation ID"
        Me.lbl_user_designation_id.Visible = False
        '
        'DocumentManager1
        '
        Me.DocumentManager1.MdiParent = Me
        Me.DocumentManager1.View = Me.TabbedView1
        Me.DocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() {Me.TabbedView1, Me.NoDocumentsView2})
        '
        'TabbedView1
        '
        Me.TabbedView1.AppearancePage.HeaderActive.BackColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Question
        Me.TabbedView1.AppearancePage.HeaderActive.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.TabbedView1.AppearancePage.HeaderActive.Options.UseBackColor = True
        Me.TabbedView1.AppearancePage.HeaderActive.Options.UseFont = True
        Me.TabbedView1.DocumentProperties.AllowPin = True
        '
        'ToolbarFormManager1
        '
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlTop)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlRight)
        Me.ToolbarFormManager1.Form = Me
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 41)
        Me.barDockControlTop.Manager = Me.ToolbarFormManager1
        Me.barDockControlTop.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlTop.Size = New System.Drawing.Size(1678, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 1066)
        Me.barDockControlBottom.Manager = Me.ToolbarFormManager1
        Me.barDockControlBottom.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlBottom.Size = New System.Drawing.Size(1678, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 41)
        Me.barDockControlLeft.Manager = Me.ToolbarFormManager1
        Me.barDockControlLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 1025)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1678, 41)
        Me.barDockControlRight.Manager = Me.ToolbarFormManager1
        Me.barDockControlRight.Margin = New System.Windows.Forms.Padding(4)
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 1025)
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "RibbonPage2"
        '
        'ToolbarFormControl1
        '
        Me.ToolbarFormControl1.Location = New System.Drawing.Point(0, 0)
        Me.ToolbarFormControl1.Manager = Me.ToolbarFormManager2
        Me.ToolbarFormControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.ToolbarFormControl1.Name = "ToolbarFormControl1"
        Me.ToolbarFormControl1.Size = New System.Drawing.Size(1678, 41)
        Me.ToolbarFormControl1.TabIndex = 9
        Me.ToolbarFormControl1.TabStop = False
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.SkinBarSubItem1)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.btn_account)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.BarStaticItem1)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_catalog)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_sales)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_warehouse)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_logistics)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_collections)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_accounting)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_purchasing)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_administration)
        Me.ToolbarFormControl1.TitleItemLinks.Add(Me.menu2_config)
        Me.ToolbarFormControl1.ToolbarForm = Me
        '
        'ToolbarFormManager2
        '
        Me.ToolbarFormManager2.DockControls.Add(Me.BarDockControl1)
        Me.ToolbarFormManager2.DockControls.Add(Me.BarDockControl2)
        Me.ToolbarFormManager2.DockControls.Add(Me.BarDockControl3)
        Me.ToolbarFormManager2.DockControls.Add(Me.BarDockControl4)
        Me.ToolbarFormManager2.Form = Me
        Me.ToolbarFormManager2.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.btn_account, Me.BarSubItem3, Me.BarSubItem4, Me.BarSubItem5, Me.BarSubItem6, Me.menu2_sales, Me.menu2_warehouse, Me.menu2_logistics, Me.menu2_collections, Me.menu2_accounting, Me.menu2_purchasing, Me.menu2_administration, Me.menu2_config, Me.submenu2_new_order, Me.submenu2_sales_orders, Me.submenu2_quotations, Me.submenu2_returns, Me.submenu2_customers, Me.submenu2_invoices, Me.submenu2_stock_management, Me.stock_management_transfer, Me.stock_management_reconcilations, Me.submenu2_customers_new, Me.submenu2_customers_registered, Me.submenu2_package_management, Me.submenu2_receiving_management, Me.submenu2_purchase_delivery_logs, Me.submenu2_inventory, Me.submenu2_new_deliveries, Me.submenu2_release_orders, Me.submenu2_dispatch_transfers, Me.submenu2_collection_orders, Me.submenu2_payment_terms, Me.submenu2_cheque_book, Me.submenu2_billing_statement, Me.submenu2_supplier_invoice, Me.submenu2_generate_payment_vouchers, Me.BarButtonItem27, Me.submenu2_forecast, Me.BarButtonItem29, Me.BarButtonItem30, Me.BarButtonItem31, Me.submenu2_generated_payments, Me.submenu2_generated_vouchers, Me.submenu2_generated_cheques, Me.submenu2_generated_cash, Me.submenu2_new_purhcase, Me.submenu2_purchase_orders, Me.submenu2_stock_return_to_vendor, Me.submenu2_reports, Me.submenu2_price_book, Me.submenu2_registered_banks, Me.submenu2_user_management, Me.submenu2_warehouse, Me.submenu2_suppliers, Me.submenu2_company_information, Me.submenu2_warehouse_new, Me.submenu2_warehouse_management, Me.submenu2_suppliers_new, Me.submenu2_suppliers_management, Me.submenu2_printer, Me.BarStaticItem1, Me.SkinBarSubItem1, Me.submenu2_price_matrix, Me.submenu2_product_database, Me.menu2_catalog, Me.submenu_purchase_request, Me.stock_management_stocktransfer_logs, Me.submenu2_generate_barcode, Me.submenu2_approvals, Me.submenu2_approvals_purchase_order, Me.submenu2_approvals_stock_transfer, Me.submenu2_approvals_quotations, Me.submenu2_approvals_sales_returns, Me.submenu2_approvals_transfer_reports, Me.submenu2_approvals_reconcilations, Me.submenu2_approvals_products, Me.submenu2_generate_pricetag, Me.submenu2_discounting_matrix, Me.submenu2_approvals_stock_returns, Me.submenu2_stock_returns_releasing, Me.stock_management_returns, Me.submenu2_credit_memo, Me.submenu2_approvals_stock_liquidation})
        Me.ToolbarFormManager2.MaxItemId = 108
        Me.ToolbarFormManager2.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemPopupContainerEdit1, Me.RepositoryItemTextEdit1, Me.RepositoryItemPictureEdit1})
        '
        'BarDockControl1
        '
        Me.BarDockControl1.CausesValidation = False
        Me.BarDockControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.BarDockControl1.Location = New System.Drawing.Point(0, 41)
        Me.BarDockControl1.Manager = Me.ToolbarFormManager2
        Me.BarDockControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl1.Size = New System.Drawing.Size(1678, 0)
        '
        'BarDockControl2
        '
        Me.BarDockControl2.CausesValidation = False
        Me.BarDockControl2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BarDockControl2.Location = New System.Drawing.Point(0, 1066)
        Me.BarDockControl2.Manager = Me.ToolbarFormManager2
        Me.BarDockControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl2.Size = New System.Drawing.Size(1678, 0)
        '
        'BarDockControl3
        '
        Me.BarDockControl3.CausesValidation = False
        Me.BarDockControl3.Dock = System.Windows.Forms.DockStyle.Left
        Me.BarDockControl3.Location = New System.Drawing.Point(0, 41)
        Me.BarDockControl3.Manager = Me.ToolbarFormManager2
        Me.BarDockControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl3.Size = New System.Drawing.Size(0, 1025)
        '
        'BarDockControl4
        '
        Me.BarDockControl4.CausesValidation = False
        Me.BarDockControl4.Dock = System.Windows.Forms.DockStyle.Right
        Me.BarDockControl4.Location = New System.Drawing.Point(1678, 41)
        Me.BarDockControl4.Manager = Me.ToolbarFormManager2
        Me.BarDockControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.BarDockControl4.Size = New System.Drawing.Size(0, 1025)
        '
        'btn_account
        '
        Me.btn_account.ActAsDropDown = True
        Me.btn_account.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.btn_account.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown
        Me.btn_account.Caption = "User Account"
        Me.btn_account.DropDownControl = Me.PopupControlContainer1
        Me.btn_account.Id = 12
        Me.btn_account.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.employee_16x16
        Me.btn_account.Name = "btn_account"
        Me.btn_account.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'PopupControlContainer1
        '
        Me.PopupControlContainer1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PopupControlContainer1.Controls.Add(Me.PanelControl1)
        Me.PopupControlContainer1.Controls.Add(Me.lbl_user_designation)
        Me.PopupControlContainer1.Controls.Add(Me.LabelControl3)
        Me.PopupControlContainer1.Controls.Add(Me.link_logout)
        Me.PopupControlContainer1.Controls.Add(Me.SeparatorControl1)
        Me.PopupControlContainer1.Controls.Add(Me.LabelControl2)
        Me.PopupControlContainer1.Controls.Add(Me.lbl_user_designation_id)
        Me.PopupControlContainer1.Controls.Add(Me.lbl_user_role_id)
        Me.PopupControlContainer1.Controls.Add(Me.lbl_user_id)
        Me.PopupControlContainer1.Controls.Add(Me.lbl_user_role)
        Me.PopupControlContainer1.Controls.Add(Me.pe_user_photo)
        Me.PopupControlContainer1.Controls.Add(Me.lbl_user_name)
        Me.PopupControlContainer1.Location = New System.Drawing.Point(1631, 91)
        Me.PopupControlContainer1.Margin = New System.Windows.Forms.Padding(4)
        Me.PopupControlContainer1.Name = "PopupControlContainer1"
        Me.PopupControlContainer1.Size = New System.Drawing.Size(344, 384)
        Me.PopupControlContainer1.TabIndex = 13
        Me.PopupControlContainer1.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.lbl_zerp_database)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.lbl_zerp_version)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Location = New System.Drawing.Point(-2, 286)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(354, 100)
        Me.PanelControl1.TabIndex = 26
        '
        'lbl_zerp_database
        '
        Me.lbl_zerp_database.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_zerp_database.Appearance.Options.UseFont = True
        Me.lbl_zerp_database.Location = New System.Drawing.Point(139, 20)
        Me.lbl_zerp_database.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_zerp_database.Name = "lbl_zerp_database"
        Me.lbl_zerp_database.Size = New System.Drawing.Size(84, 25)
        Me.lbl_zerp_database.TabIndex = 28
        Me.lbl_zerp_database.Text = "_database"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(22, 52)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 25)
        Me.LabelControl5.TabIndex = 27
        Me.LabelControl5.Text = "ZERP Version"
        '
        'lbl_zerp_version
        '
        Me.lbl_zerp_version.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_zerp_version.Appearance.Options.UseFont = True
        Me.lbl_zerp_version.Location = New System.Drawing.Point(139, 52)
        Me.lbl_zerp_version.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_zerp_version.Name = "lbl_zerp_version"
        Me.lbl_zerp_version.Size = New System.Drawing.Size(69, 25)
        Me.lbl_zerp_version.TabIndex = 26
        Me.lbl_zerp_version.Text = "_version"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(22, 20)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 25)
        Me.LabelControl4.TabIndex = 25
        Me.LabelControl4.Text = "Database"
        '
        'lbl_user_designation
        '
        Me.lbl_user_designation.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_user_designation.Appearance.Options.UseFont = True
        Me.lbl_user_designation.Location = New System.Drawing.Point(136, 233)
        Me.lbl_user_designation.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_user_designation.Name = "lbl_user_designation"
        Me.lbl_user_designation.Size = New System.Drawing.Size(180, 25)
        Me.lbl_user_designation.TabIndex = 25
        Me.lbl_user_designation.Text = "Designation Location"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 233)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 25)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Designation"
        '
        'link_logout
        '
        Me.link_logout.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.link_logout.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.link_logout.Appearance.Options.UseFont = True
        Me.link_logout.Appearance.Options.UseLinkColor = True
        Me.link_logout.Location = New System.Drawing.Point(167, 170)
        Me.link_logout.Margin = New System.Windows.Forms.Padding(4)
        Me.link_logout.Name = "link_logout"
        Me.link_logout.Size = New System.Drawing.Size(54, 23)
        Me.link_logout.TabIndex = 23
        Me.link_logout.Text = "Logout"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(0, 36)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.SeparatorControl1.Size = New System.Drawing.Size(344, 22)
        Me.SeparatorControl1.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(13, 15)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(125, 23)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Account Details"
        '
        'lbl_user_role_id
        '
        Me.lbl_user_role_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lbl_user_role_id.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_user_role_id.Appearance.Options.UseFont = True
        Me.lbl_user_role_id.Appearance.Options.UseForeColor = True
        Me.lbl_user_role_id.Location = New System.Drawing.Point(295, 151)
        Me.lbl_user_role_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_user_role_id.Name = "lbl_user_role_id"
        Me.lbl_user_role_id.Size = New System.Drawing.Size(83, 17)
        Me.lbl_user_role_id.TabIndex = 5
        Me.lbl_user_role_id.Text = "User Role ID"
        Me.lbl_user_role_id.Visible = False
        '
        'lbl_user_id
        '
        Me.lbl_user_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic)
        Me.lbl_user_id.Appearance.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.lbl_user_id.Appearance.Options.UseFont = True
        Me.lbl_user_id.Appearance.Options.UseForeColor = True
        Me.lbl_user_id.Location = New System.Drawing.Point(295, 128)
        Me.lbl_user_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_user_id.Name = "lbl_user_id"
        Me.lbl_user_id.Size = New System.Drawing.Size(50, 17)
        Me.lbl_user_id.TabIndex = 4
        Me.lbl_user_id.Text = "User ID"
        Me.lbl_user_id.Visible = False
        '
        'lbl_user_role
        '
        Me.lbl_user_role.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.lbl_user_role.Appearance.Options.UseFont = True
        Me.lbl_user_role.Location = New System.Drawing.Point(162, 106)
        Me.lbl_user_role.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_user_role.Name = "lbl_user_role"
        Me.lbl_user_role.Size = New System.Drawing.Size(75, 25)
        Me.lbl_user_role.TabIndex = 2
        Me.lbl_user_role.Text = "User Role"
        '
        'pe_user_photo
        '
        Me.pe_user_photo.EditValue = Global.Inventory_Management.My.Resources.Resources.actions_user
        Me.pe_user_photo.Location = New System.Drawing.Point(33, 68)
        Me.pe_user_photo.Margin = New System.Windows.Forms.Padding(4)
        Me.pe_user_photo.Name = "pe_user_photo"
        Me.pe_user_photo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.pe_user_photo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pe_user_photo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pe_user_photo.Size = New System.Drawing.Size(117, 123)
        Me.pe_user_photo.TabIndex = 1
        '
        'lbl_user_name
        '
        Me.lbl_user_name.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_user_name.Appearance.Options.UseFont = True
        Me.lbl_user_name.Location = New System.Drawing.Point(162, 68)
        Me.lbl_user_name.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(117, 31)
        Me.lbl_user_name.TabIndex = 0
        Me.lbl_user_name.Text = "User Name"
        '
        'BarSubItem3
        '
        Me.BarSubItem3.Caption = "Catalogue"
        Me.BarSubItem3.Id = 16
        Me.BarSubItem3.Name = "BarSubItem3"
        '
        'BarSubItem4
        '
        Me.BarSubItem4.Caption = "New Item"
        Me.BarSubItem4.Id = 17
        Me.BarSubItem4.Name = "BarSubItem4"
        '
        'BarSubItem5
        '
        Me.BarSubItem5.Caption = "Import Catalogue"
        Me.BarSubItem5.Id = 18
        Me.BarSubItem5.Name = "BarSubItem5"
        '
        'BarSubItem6
        '
        Me.BarSubItem6.Caption = "Export Catalogue"
        Me.BarSubItem6.Id = 19
        Me.BarSubItem6.Name = "BarSubItem6"
        '
        'menu2_sales
        '
        Me.menu2_sales.Caption = "Sales"
        Me.menu2_sales.Id = 24
        Me.menu2_sales.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_new_order), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_sales_orders), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_quotations), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_customers), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_returns), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_discounting_matrix), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_invoices)})
        Me.menu2_sales.Name = "menu2_sales"
        '
        'submenu2_new_order
        '
        Me.submenu2_new_order.Caption = "New Order"
        Me.submenu2_new_order.Id = 32
        Me.submenu2_new_order.Name = "submenu2_new_order"
        Me.submenu2_new_order.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_sales_orders
        '
        Me.submenu2_sales_orders.Caption = "Sales Orders"
        Me.submenu2_sales_orders.Id = 33
        Me.submenu2_sales_orders.Name = "submenu2_sales_orders"
        Me.submenu2_sales_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_quotations
        '
        Me.submenu2_quotations.Caption = "Quotations"
        Me.submenu2_quotations.Id = 34
        Me.submenu2_quotations.Name = "submenu2_quotations"
        Me.submenu2_quotations.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_customers
        '
        Me.submenu2_customers.Caption = "Customers"
        Me.submenu2_customers.Id = 36
        Me.submenu2_customers.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_customers_new), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_customers_registered)})
        Me.submenu2_customers.Name = "submenu2_customers"
        Me.submenu2_customers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_customers_new
        '
        Me.submenu2_customers_new.Caption = "New Customer"
        Me.submenu2_customers_new.Id = 41
        Me.submenu2_customers_new.Name = "submenu2_customers_new"
        '
        'submenu2_customers_registered
        '
        Me.submenu2_customers_registered.Caption = "Registered Customers"
        Me.submenu2_customers_registered.Id = 42
        Me.submenu2_customers_registered.Name = "submenu2_customers_registered"
        '
        'submenu2_returns
        '
        Me.submenu2_returns.Caption = "Sales Returns"
        Me.submenu2_returns.Id = 35
        Me.submenu2_returns.Name = "submenu2_returns"
        Me.submenu2_returns.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_discounting_matrix
        '
        Me.submenu2_discounting_matrix.Caption = "Discounting Matrix"
        Me.submenu2_discounting_matrix.Id = 102
        Me.submenu2_discounting_matrix.Name = "submenu2_discounting_matrix"
        Me.submenu2_discounting_matrix.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_invoices
        '
        Me.submenu2_invoices.Caption = "Invoice Receipts"
        Me.submenu2_invoices.Id = 37
        Me.submenu2_invoices.Name = "submenu2_invoices"
        Me.submenu2_invoices.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menu2_warehouse
        '
        Me.menu2_warehouse.Caption = "Warehouse"
        Me.menu2_warehouse.Id = 25
        Me.menu2_warehouse.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_stock_management), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_package_management), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_receiving_management), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_inventory), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_new_deliveries), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generate_barcode), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generate_pricetag)})
        Me.menu2_warehouse.Name = "menu2_warehouse"
        '
        'submenu2_stock_management
        '
        Me.submenu2_stock_management.Caption = "Stocks Management"
        Me.submenu2_stock_management.Id = 38
        Me.submenu2_stock_management.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.stock_management_transfer), New DevExpress.XtraBars.LinkPersistInfo(Me.stock_management_stocktransfer_logs), New DevExpress.XtraBars.LinkPersistInfo(Me.stock_management_returns), New DevExpress.XtraBars.LinkPersistInfo(Me.stock_management_reconcilations)})
        Me.submenu2_stock_management.Name = "submenu2_stock_management"
        Me.submenu2_stock_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'stock_management_transfer
        '
        Me.stock_management_transfer.Caption = "Stock Transfers"
        Me.stock_management_transfer.Id = 39
        Me.stock_management_transfer.Name = "stock_management_transfer"
        '
        'stock_management_stocktransfer_logs
        '
        Me.stock_management_stocktransfer_logs.Caption = "Stock Transfer Logs"
        Me.stock_management_stocktransfer_logs.Id = 91
        Me.stock_management_stocktransfer_logs.Name = "stock_management_stocktransfer_logs"
        '
        'stock_management_returns
        '
        Me.stock_management_returns.Caption = "Stock Return"
        Me.stock_management_returns.Id = 105
        Me.stock_management_returns.Name = "stock_management_returns"
        '
        'stock_management_reconcilations
        '
        Me.stock_management_reconcilations.Caption = "Reconcilations"
        Me.stock_management_reconcilations.Id = 40
        Me.stock_management_reconcilations.Name = "stock_management_reconcilations"
        '
        'submenu2_package_management
        '
        Me.submenu2_package_management.Caption = "Package Management"
        Me.submenu2_package_management.Id = 43
        Me.submenu2_package_management.Name = "submenu2_package_management"
        Me.submenu2_package_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_receiving_management
        '
        Me.submenu2_receiving_management.Caption = "Receiving Management"
        Me.submenu2_receiving_management.Id = 44
        Me.submenu2_receiving_management.Name = "submenu2_receiving_management"
        Me.submenu2_receiving_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_inventory
        '
        Me.submenu2_inventory.Caption = "Inventory"
        Me.submenu2_inventory.Id = 46
        Me.submenu2_inventory.Name = "submenu2_inventory"
        Me.submenu2_inventory.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_new_deliveries
        '
        Me.submenu2_new_deliveries.Caption = "New Stocks Deliveries"
        Me.submenu2_new_deliveries.Id = 47
        Me.submenu2_new_deliveries.Name = "submenu2_new_deliveries"
        Me.submenu2_new_deliveries.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_generate_barcode
        '
        Me.submenu2_generate_barcode.Caption = "Generate Barcode"
        Me.submenu2_generate_barcode.Id = 92
        Me.submenu2_generate_barcode.Name = "submenu2_generate_barcode"
        Me.submenu2_generate_barcode.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_generate_pricetag
        '
        Me.submenu2_generate_pricetag.Caption = "Generate Pricetag"
        Me.submenu2_generate_pricetag.Id = 101
        Me.submenu2_generate_pricetag.Name = "submenu2_generate_pricetag"
        '
        'menu2_logistics
        '
        Me.menu2_logistics.Caption = "Logistics"
        Me.menu2_logistics.Id = 26
        Me.menu2_logistics.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_release_orders), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_dispatch_transfers), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_stock_returns_releasing)})
        Me.menu2_logistics.Name = "menu2_logistics"
        '
        'submenu2_release_orders
        '
        Me.submenu2_release_orders.Caption = "Release Orders"
        Me.submenu2_release_orders.Id = 48
        Me.submenu2_release_orders.Name = "submenu2_release_orders"
        Me.submenu2_release_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_dispatch_transfers
        '
        Me.submenu2_dispatch_transfers.Caption = "Dispatch Transfers"
        Me.submenu2_dispatch_transfers.Id = 49
        Me.submenu2_dispatch_transfers.Name = "submenu2_dispatch_transfers"
        Me.submenu2_dispatch_transfers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_stock_returns_releasing
        '
        Me.submenu2_stock_returns_releasing.Caption = "Stock Returns Releasing"
        Me.submenu2_stock_returns_releasing.Id = 104
        Me.submenu2_stock_returns_releasing.Name = "submenu2_stock_returns_releasing"
        Me.submenu2_stock_returns_releasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menu2_collections
        '
        Me.menu2_collections.Caption = "Collections"
        Me.menu2_collections.Id = 27
        Me.menu2_collections.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_collection_orders), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_payment_terms), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_cheque_book), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_billing_statement)})
        Me.menu2_collections.Name = "menu2_collections"
        '
        'submenu2_collection_orders
        '
        Me.submenu2_collection_orders.Caption = "Cashier Register"
        Me.submenu2_collection_orders.Id = 50
        Me.submenu2_collection_orders.Name = "submenu2_collection_orders"
        Me.submenu2_collection_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_payment_terms
        '
        Me.submenu2_payment_terms.Caption = "Payment Terms"
        Me.submenu2_payment_terms.Id = 51
        Me.submenu2_payment_terms.Name = "submenu2_payment_terms"
        Me.submenu2_payment_terms.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_cheque_book
        '
        Me.submenu2_cheque_book.Caption = "Cheque Book"
        Me.submenu2_cheque_book.Id = 52
        Me.submenu2_cheque_book.Name = "submenu2_cheque_book"
        Me.submenu2_cheque_book.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_billing_statement
        '
        Me.submenu2_billing_statement.Caption = "Billing Statements"
        Me.submenu2_billing_statement.Id = 53
        Me.submenu2_billing_statement.Name = "submenu2_billing_statement"
        Me.submenu2_billing_statement.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menu2_accounting
        '
        Me.menu2_accounting.Caption = "Accounting"
        Me.menu2_accounting.Id = 28
        Me.menu2_accounting.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_supplier_invoice), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generate_payment_vouchers), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generated_payments)})
        Me.menu2_accounting.Name = "menu2_accounting"
        Me.menu2_accounting.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_supplier_invoice
        '
        Me.submenu2_supplier_invoice.Caption = "Supplier Invoice"
        Me.submenu2_supplier_invoice.Id = 54
        Me.submenu2_supplier_invoice.Name = "submenu2_supplier_invoice"
        Me.submenu2_supplier_invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_generate_payment_vouchers
        '
        Me.submenu2_generate_payment_vouchers.Caption = "Generate Payment && Vouchers"
        Me.submenu2_generate_payment_vouchers.Id = 55
        Me.submenu2_generate_payment_vouchers.Name = "submenu2_generate_payment_vouchers"
        Me.submenu2_generate_payment_vouchers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_generated_payments
        '
        Me.submenu2_generated_payments.Caption = "Generated Payments"
        Me.submenu2_generated_payments.Id = 61
        Me.submenu2_generated_payments.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generated_vouchers), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generated_cheques), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_generated_cash)})
        Me.submenu2_generated_payments.Name = "submenu2_generated_payments"
        Me.submenu2_generated_payments.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_generated_vouchers
        '
        Me.submenu2_generated_vouchers.Caption = "Vouchers"
        Me.submenu2_generated_vouchers.Id = 62
        Me.submenu2_generated_vouchers.Name = "submenu2_generated_vouchers"
        '
        'submenu2_generated_cheques
        '
        Me.submenu2_generated_cheques.Caption = "Cheques"
        Me.submenu2_generated_cheques.Id = 63
        Me.submenu2_generated_cheques.Name = "submenu2_generated_cheques"
        '
        'submenu2_generated_cash
        '
        Me.submenu2_generated_cash.Caption = "Cash"
        Me.submenu2_generated_cash.Id = 64
        Me.submenu2_generated_cash.Name = "submenu2_generated_cash"
        '
        'menu2_purchasing
        '
        Me.menu2_purchasing.Caption = "Purchasing"
        Me.menu2_purchasing.Id = 29
        Me.menu2_purchasing.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_new_purhcase), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_purchase_orders), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_stock_return_to_vendor), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_credit_memo), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_purchase_delivery_logs), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu_purchase_request)})
        Me.menu2_purchasing.Name = "menu2_purchasing"
        Me.menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_new_purhcase
        '
        Me.submenu2_new_purhcase.Caption = "New Purchase"
        Me.submenu2_new_purhcase.Id = 65
        Me.submenu2_new_purhcase.Name = "submenu2_new_purhcase"
        Me.submenu2_new_purhcase.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_purchase_orders
        '
        Me.submenu2_purchase_orders.Caption = "Purchase Orders"
        Me.submenu2_purchase_orders.Id = 66
        Me.submenu2_purchase_orders.Name = "submenu2_purchase_orders"
        Me.submenu2_purchase_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_stock_return_to_vendor
        '
        Me.submenu2_stock_return_to_vendor.Caption = "Return to Vendor"
        Me.submenu2_stock_return_to_vendor.Id = 67
        Me.submenu2_stock_return_to_vendor.Name = "submenu2_stock_return_to_vendor"
        Me.submenu2_stock_return_to_vendor.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_credit_memo
        '
        Me.submenu2_credit_memo.Caption = "Credit Memo"
        Me.submenu2_credit_memo.Id = 106
        Me.submenu2_credit_memo.Name = "submenu2_credit_memo"
        Me.submenu2_credit_memo.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_purchase_delivery_logs
        '
        Me.submenu2_purchase_delivery_logs.Caption = "Supplier Delivery Logs"
        Me.submenu2_purchase_delivery_logs.Id = 45
        Me.submenu2_purchase_delivery_logs.Name = "submenu2_purchase_delivery_logs"
        Me.submenu2_purchase_delivery_logs.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu_purchase_request
        '
        Me.submenu_purchase_request.Caption = "Purchase Request"
        Me.submenu_purchase_request.Id = 90
        Me.submenu_purchase_request.Name = "submenu_purchase_request"
        Me.submenu_purchase_request.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menu2_administration
        '
        Me.menu2_administration.Caption = "Administration"
        Me.menu2_administration.Id = 30
        Me.menu2_administration.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_reports), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_product_database), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_price_book), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_price_matrix), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_registered_banks), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_user_management), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_warehouse), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_suppliers), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_company_information)})
        Me.menu2_administration.Name = "menu2_administration"
        Me.menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals
        '
        Me.submenu2_approvals.Caption = "Approvals"
        Me.submenu2_approvals.Id = 93
        Me.submenu2_approvals.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_purchase_order), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_stock_transfer), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_quotations), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_sales_returns), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_stock_returns), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_transfer_reports), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_reconcilations), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_products), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_approvals_stock_liquidation)})
        Me.submenu2_approvals.Name = "submenu2_approvals"
        '
        'submenu2_approvals_purchase_order
        '
        Me.submenu2_approvals_purchase_order.Caption = "Purchase Orders"
        Me.submenu2_approvals_purchase_order.Id = 94
        Me.submenu2_approvals_purchase_order.Name = "submenu2_approvals_purchase_order"
        Me.submenu2_approvals_purchase_order.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_stock_transfer
        '
        Me.submenu2_approvals_stock_transfer.Caption = "Stock Transfers"
        Me.submenu2_approvals_stock_transfer.Id = 95
        Me.submenu2_approvals_stock_transfer.Name = "submenu2_approvals_stock_transfer"
        Me.submenu2_approvals_stock_transfer.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_quotations
        '
        Me.submenu2_approvals_quotations.Caption = "Quotations"
        Me.submenu2_approvals_quotations.Id = 96
        Me.submenu2_approvals_quotations.Name = "submenu2_approvals_quotations"
        Me.submenu2_approvals_quotations.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_sales_returns
        '
        Me.submenu2_approvals_sales_returns.Caption = "Sales Returns"
        Me.submenu2_approvals_sales_returns.Id = 97
        Me.submenu2_approvals_sales_returns.Name = "submenu2_approvals_sales_returns"
        Me.submenu2_approvals_sales_returns.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_stock_returns
        '
        Me.submenu2_approvals_stock_returns.Caption = "Stock Returns"
        Me.submenu2_approvals_stock_returns.Id = 103
        Me.submenu2_approvals_stock_returns.Name = "submenu2_approvals_stock_returns"
        '
        'submenu2_approvals_transfer_reports
        '
        Me.submenu2_approvals_transfer_reports.Caption = "Transfer Reports"
        Me.submenu2_approvals_transfer_reports.Id = 98
        Me.submenu2_approvals_transfer_reports.Name = "submenu2_approvals_transfer_reports"
        Me.submenu2_approvals_transfer_reports.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_reconcilations
        '
        Me.submenu2_approvals_reconcilations.Caption = "Reconcilations"
        Me.submenu2_approvals_reconcilations.Id = 99
        Me.submenu2_approvals_reconcilations.Name = "submenu2_approvals_reconcilations"
        Me.submenu2_approvals_reconcilations.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_products
        '
        Me.submenu2_approvals_products.Caption = "Products"
        Me.submenu2_approvals_products.Id = 100
        Me.submenu2_approvals_products.Name = "submenu2_approvals_products"
        Me.submenu2_approvals_products.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_approvals_stock_liquidation
        '
        Me.submenu2_approvals_stock_liquidation.Caption = "Stock Liquidation"
        Me.submenu2_approvals_stock_liquidation.Id = 107
        Me.submenu2_approvals_stock_liquidation.Name = "submenu2_approvals_stock_liquidation"
        '
        'submenu2_reports
        '
        Me.submenu2_reports.Caption = "Statistics && Reports"
        Me.submenu2_reports.Id = 69
        Me.submenu2_reports.Name = "submenu2_reports"
        Me.submenu2_reports.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_product_database
        '
        Me.submenu2_product_database.Caption = "Product Database"
        Me.submenu2_product_database.Id = 88
        Me.submenu2_product_database.Name = "submenu2_product_database"
        Me.submenu2_product_database.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_price_book
        '
        Me.submenu2_price_book.Caption = "Price Book"
        Me.submenu2_price_book.Id = 70
        Me.submenu2_price_book.Name = "submenu2_price_book"
        Me.submenu2_price_book.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_price_matrix
        '
        Me.submenu2_price_matrix.Caption = "Price Matrix"
        Me.submenu2_price_matrix.Id = 87
        Me.submenu2_price_matrix.Name = "submenu2_price_matrix"
        Me.submenu2_price_matrix.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_registered_banks
        '
        Me.submenu2_registered_banks.Caption = "Registered Banks"
        Me.submenu2_registered_banks.Id = 71
        Me.submenu2_registered_banks.Name = "submenu2_registered_banks"
        Me.submenu2_registered_banks.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_user_management
        '
        Me.submenu2_user_management.Caption = "User Management"
        Me.submenu2_user_management.Id = 72
        Me.submenu2_user_management.Name = "submenu2_user_management"
        Me.submenu2_user_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_warehouse
        '
        Me.submenu2_warehouse.Caption = "Warehouse"
        Me.submenu2_warehouse.Id = 73
        Me.submenu2_warehouse.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_warehouse_new), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_warehouse_management)})
        Me.submenu2_warehouse.Name = "submenu2_warehouse"
        Me.submenu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_warehouse_new
        '
        Me.submenu2_warehouse_new.Caption = "New Warehouse"
        Me.submenu2_warehouse_new.Id = 76
        Me.submenu2_warehouse_new.Name = "submenu2_warehouse_new"
        '
        'submenu2_warehouse_management
        '
        Me.submenu2_warehouse_management.Caption = "Warehouse Management"
        Me.submenu2_warehouse_management.Id = 77
        Me.submenu2_warehouse_management.Name = "submenu2_warehouse_management"
        '
        'submenu2_suppliers
        '
        Me.submenu2_suppliers.Caption = "Suppliers"
        Me.submenu2_suppliers.Id = 74
        Me.submenu2_suppliers.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_suppliers_new), New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_suppliers_management)})
        Me.submenu2_suppliers.Name = "submenu2_suppliers"
        Me.submenu2_suppliers.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'submenu2_suppliers_new
        '
        Me.submenu2_suppliers_new.Caption = "New Supplier"
        Me.submenu2_suppliers_new.Id = 78
        Me.submenu2_suppliers_new.Name = "submenu2_suppliers_new"
        '
        'submenu2_suppliers_management
        '
        Me.submenu2_suppliers_management.Caption = "Supplier Management"
        Me.submenu2_suppliers_management.Id = 79
        Me.submenu2_suppliers_management.Name = "submenu2_suppliers_management"
        '
        'submenu2_company_information
        '
        Me.submenu2_company_information.Caption = "Settings"
        Me.submenu2_company_information.Id = 75
        Me.submenu2_company_information.Name = "submenu2_company_information"
        Me.submenu2_company_information.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'menu2_config
        '
        Me.menu2_config.Caption = "Configurations"
        Me.menu2_config.Id = 31
        Me.menu2_config.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.submenu2_printer)})
        Me.menu2_config.Name = "menu2_config"
        '
        'submenu2_printer
        '
        Me.submenu2_printer.Caption = "Printer"
        Me.submenu2_printer.Id = 81
        Me.submenu2_printer.Name = "submenu2_printer"
        '
        'BarButtonItem27
        '
        Me.BarButtonItem27.Caption = "BarButtonItem27"
        Me.BarButtonItem27.Id = 56
        Me.BarButtonItem27.Name = "BarButtonItem27"
        '
        'submenu2_forecast
        '
        Me.submenu2_forecast.Caption = "Forecast && Payables"
        Me.submenu2_forecast.Id = 57
        Me.submenu2_forecast.Name = "submenu2_forecast"
        Me.submenu2_forecast.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'BarButtonItem29
        '
        Me.BarButtonItem29.Caption = "Inventory Count"
        Me.BarButtonItem29.Id = 58
        Me.BarButtonItem29.Name = "BarButtonItem29"
        '
        'BarButtonItem30
        '
        Me.BarButtonItem30.Caption = "BarButtonItem30"
        Me.BarButtonItem30.Id = 59
        Me.BarButtonItem30.Name = "BarButtonItem30"
        '
        'BarButtonItem31
        '
        Me.BarButtonItem31.Caption = "BarButtonItem31"
        Me.BarButtonItem31.Id = 60
        Me.BarButtonItem31.Name = "BarButtonItem31"
        '
        'BarStaticItem1
        '
        Me.BarStaticItem1.Caption = "ZERP"
        Me.BarStaticItem1.Id = 82
        Me.BarStaticItem1.ItemAppearance.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.BarStaticItem1.ItemAppearance.Normal.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseFont = True
        Me.BarStaticItem1.ItemAppearance.Normal.Options.UseForeColor = True
        Me.BarStaticItem1.Name = "BarStaticItem1"
        '
        'SkinBarSubItem1
        '
        Me.SkinBarSubItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right
        Me.SkinBarSubItem1.Caption = "Skin"
        Me.SkinBarSubItem1.Id = 85
        Me.SkinBarSubItem1.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.morecolors
        Me.SkinBarSubItem1.Name = "SkinBarSubItem1"
        Me.SkinBarSubItem1.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph
        '
        'menu2_catalog
        '
        Me.menu2_catalog.Caption = "Catalog"
        Me.menu2_catalog.Id = 89
        Me.menu2_catalog.Name = "menu2_catalog"
        '
        'RepositoryItemPopupContainerEdit1
        '
        Me.RepositoryItemPopupContainerEdit1.AutoHeight = False
        Me.RepositoryItemPopupContainerEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemPopupContainerEdit1.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.RepositoryItemPopupContainerEdit1.Name = "RepositoryItemPopupContainerEdit1"
        Me.RepositoryItemPopupContainerEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
        '
        'RepositoryItemPictureEdit1
        '
        Me.RepositoryItemPictureEdit1.Name = "RepositoryItemPictureEdit1"
        Me.RepositoryItemPictureEdit1.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.ProgressPanel.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.Appearance.Options.UseFont = True
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Location = New System.Drawing.Point(710, 475)
        Me.ProgressPanel.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Padding = New System.Windows.Forms.Padding(12)
        Me.ProgressPanel.Size = New System.Drawing.Size(287, 81)
        Me.ProgressPanel.TabIndex = 22
        Me.ProgressPanel.Text = "ProgressPanel1"
        Me.ProgressPanel.Visible = False
        Me.ProgressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1678, 1066)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.PopupControlContainer1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.BarDockControl3)
        Me.Controls.Add(Me.BarDockControl4)
        Me.Controls.Add(Me.BarDockControl2)
        Me.Controls.Add(Me.BarDockControl1)
        Me.Controls.Add(Me.ToolbarFormControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_main.IconOptions.Icon"), System.Drawing.Icon)
        Me.IconOptions.ShowIcon = False
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ToolbarFormControl = Me.ToolbarFormControl1
        CType(Me.DocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NoDocumentsView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolbarFormControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolbarFormManager2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupControlContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PopupControlContainer1.ResumeLayout(False)
        Me.PopupControlContainer1.PerformLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pe_user_photo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPopupContainerEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemPictureEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NewStoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisteredStoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents bgw_main As System.ComponentModel.BackgroundWorker
    Friend WithEvents NoDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
    Friend WithEvents DocumentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
    Friend WithEvents TabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
    Friend WithEvents lbl_user_designation_id As LabelControl
    Friend WithEvents ToolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents ToolbarFormControl1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormControl
    Friend WithEvents ToolbarFormManager2 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
    Friend WithEvents BarDockControl1 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl2 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl3 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents BarDockControl4 As DevExpress.XtraBars.BarDockControl
    Friend WithEvents RepositoryItemPopupContainerEdit1 As Repository.RepositoryItemPopupContainerEdit
    Friend WithEvents RepositoryItemTextEdit1 As Repository.RepositoryItemTextEdit
    Friend WithEvents RepositoryItemPictureEdit1 As Repository.RepositoryItemPictureEdit
    Friend WithEvents btn_account As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents PopupControlContainer1 As DevExpress.XtraBars.PopupControlContainer
    Friend WithEvents lbl_user_name As LabelControl
    Friend WithEvents pe_user_photo As PictureEdit
    Friend WithEvents lbl_user_role As LabelControl
    Friend WithEvents lbl_user_id As LabelControl
    Friend WithEvents lbl_user_role_id As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents SeparatorControl1 As SeparatorControl
    Friend WithEvents link_logout As HyperlinkLabelControl
    Friend WithEvents BarSubItem3 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem4 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem5 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents BarSubItem6 As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_sales As DevExpress.XtraBars.BarSubItem
    Friend WithEvents submenu2_new_order As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_sales_orders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_quotations As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_returns As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_customers As DevExpress.XtraBars.BarSubItem
    Friend WithEvents submenu2_invoices As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menu2_warehouse As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_logistics As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_collections As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_accounting As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_purchasing As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_administration As DevExpress.XtraBars.BarSubItem
    Friend WithEvents menu2_config As DevExpress.XtraBars.BarSubItem
    Friend WithEvents PanelControl1 As PanelControl
    Friend WithEvents lbl_user_designation As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents lbl_zerp_database As LabelControl
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents lbl_zerp_version As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents submenu2_stock_management As DevExpress.XtraBars.BarSubItem
    Friend WithEvents stock_management_transfer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents stock_management_reconcilations As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_customers_new As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_customers_registered As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_package_management As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_receiving_management As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_purchase_delivery_logs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_inventory As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_new_deliveries As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_release_orders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_dispatch_transfers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_collection_orders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_payment_terms As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_cheque_book As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_billing_statement As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_supplier_invoice As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_generate_payment_vouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_generated_payments As DevExpress.XtraBars.BarSubItem
    Friend WithEvents submenu2_generated_vouchers As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_generated_cheques As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_generated_cash As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_forecast As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem29 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_new_purhcase As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_purchase_orders As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_stock_return_to_vendor As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_reports As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_price_book As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_registered_banks As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_user_management As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem27 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem30 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarButtonItem31 As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_warehouse As DevExpress.XtraBars.BarSubItem
    Friend WithEvents submenu2_warehouse_new As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_warehouse_management As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_suppliers As DevExpress.XtraBars.BarSubItem
    Friend WithEvents submenu2_suppliers_new As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_suppliers_management As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_company_information As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_printer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents BarStaticItem1 As DevExpress.XtraBars.BarStaticItem
    Friend WithEvents SkinBarSubItem1 As DevExpress.XtraBars.SkinBarSubItem
    Friend WithEvents submenu2_price_matrix As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_product_database As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents menu2_catalog As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents NoDocumentsView2 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
    Friend WithEvents submenu_purchase_request As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents stock_management_stocktransfer_logs As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_generate_barcode As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals As DevExpress.XtraBars.BarSubItem
    Friend WithEvents submenu2_approvals_purchase_order As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_stock_transfer As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_quotations As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_sales_returns As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_transfer_reports As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_reconcilations As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_products As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_generate_pricetag As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_discounting_matrix As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_stock_returns As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_stock_returns_releasing As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents stock_management_returns As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_credit_memo As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents submenu2_approvals_stock_liquidation As DevExpress.XtraBars.BarButtonItem
End Class
