
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraSplashScreen
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Runtime.CompilerServices


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Dim splashScreenManager As DevExpress.XtraSplashScreen.SplashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, Nothing, True, True)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.panel_main = New Guna.UI.WinForms.GunaPanel()
        Me.panel_content = New Guna.UI.WinForms.GunaPanel()
        Me.panel_top = New Guna.UI.WinForms.GunaGradientPanel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.user_store = New Guna.UI.WinForms.GunaLabel()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.menu_product = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_catalogue = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_new_item = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_import_catalogue = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_export_catalogue = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_sales = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_create_order = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_orders = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_quotations = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_returns = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_customers = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewCustomerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisteredCustomersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_invoices = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_logistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_warehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_stock_management = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu2_StockTransfer = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu2_reconcile = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_packageManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_ReceivingManagement = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_delivery_logs = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_product_inventory = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_selluseller = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_logistics = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_order_management = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_StockTransferDispatching = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_collections = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_payments = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_payment_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_cheque_book = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_soa = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_accounting = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_account_payables = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_generate = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_payment_vouchers = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_payment_cheques = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_payment_cash = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_ForecastAndPayablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_InventoryCount = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_purchasing = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_purchasing_new = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_purchasing_orders = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_po_returns = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_administration = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_user_accounts = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_approvals = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_price_books = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_reports = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_banks = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_warehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu2_new_warehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu2_registered_warehouse = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_suppliers = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisteredSupplierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.submenu_settings = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_my_account = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.user_role_id = New Guna.UI.WinForms.GunaLabel()
        Me.user_id = New Guna.UI.WinForms.GunaLabel()
        Me.user_role = New Guna.UI.WinForms.GunaLabel()
        Me.user_name = New Guna.UI.WinForms.GunaLabel()
        Me.user_photo = New Guna.UI.WinForms.GunaCirclePictureBox()
        Me.bgw_main = New System.ComponentModel.BackgroundWorker()
        Me.Guna2Elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.panel_main.SuspendLayout()
        Me.panel_top.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.user_photo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'splashScreenManager
        '
        splashScreenManager.ClosingDelay = 500
        '
        'panel_main
        '
        Me.panel_main.BackColor = System.Drawing.Color.White
        Me.panel_main.Controls.Add(Me.panel_content)
        Me.panel_main.Controls.Add(Me.panel_top)
        Me.panel_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_main.Location = New System.Drawing.Point(0, 0)
        Me.panel_main.Name = "panel_main"
        Me.panel_main.Size = New System.Drawing.Size(1424, 861)
        Me.panel_main.TabIndex = 2
        '
        'panel_content
        '
        Me.panel_content.BackColor = System.Drawing.Color.WhiteSmoke
        Me.panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_content.Location = New System.Drawing.Point(0, 96)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Size = New System.Drawing.Size(1424, 765)
        Me.panel_content.TabIndex = 3
        '
        'panel_top
        '
        Me.panel_top.BackgroundImage = CType(resources.GetObject("panel_top.BackgroundImage"), System.Drawing.Image)
        Me.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.panel_top.Controls.Add(Me.PictureEdit1)
        Me.panel_top.Controls.Add(Me.user_store)
        Me.panel_top.Controls.Add(Me.MenuStrip)
        Me.panel_top.Controls.Add(Me.GunaLinePanel1)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.GradientColor1 = System.Drawing.Color.GhostWhite
        Me.panel_top.GradientColor2 = System.Drawing.Color.LightSteelBlue
        Me.panel_top.GradientColor3 = System.Drawing.Color.White
        Me.panel_top.GradientColor4 = System.Drawing.Color.White
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1424, 96)
        Me.panel_top.TabIndex = 4
        Me.panel_top.Text = "GunaGradientPanel1"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Cursor = System.Windows.Forms.Cursors.Default
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 6)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.AllowFocused = False
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowMenu = False
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.PictureEdit1.Size = New System.Drawing.Size(210, 59)
        Me.PictureEdit1.TabIndex = 16
        '
        'user_store
        '
        Me.user_store.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_store.BackColor = System.Drawing.Color.GhostWhite
        Me.user_store.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.user_store.ForeColor = System.Drawing.Color.Gray
        Me.user_store.Location = New System.Drawing.Point(1195, 80)
        Me.user_store.Name = "user_store"
        Me.user_store.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.user_store.Size = New System.Drawing.Size(214, 28)
        Me.user_store.TabIndex = 3
        Me.user_store.Text = "Branch Store Name"
        Me.user_store.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.menu_product, Me.menu_sales, Me.menu_warehouse, Me.menu_logistics, Me.menu_collections, Me.menu_accounting, Me.menu_purchasing, Me.menu_administration, Me.menu_my_account})
        Me.MenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip.Location = New System.Drawing.Point(0, 68)
        Me.MenuStrip.MdiWindowListItem = Me.menu_warehouse
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(6, 2, 0, 5)
        Me.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip.ShowItemToolTips = True
        Me.MenuStrip.Size = New System.Drawing.Size(807, 31)
        Me.MenuStrip.TabIndex = 0
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'menu_product
        '
        Me.menu_product.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_catalogue, Me.submenu_new_item, Me.submenu_import_catalogue, Me.submenu_export_catalogue})
        Me.menu_product.Name = "menu_product"
        Me.menu_product.Size = New System.Drawing.Size(72, 24)
        Me.menu_product.Text = "Product"
        '
        'submenu_catalogue
        '
        Me.submenu_catalogue.Name = "submenu_catalogue"
        Me.submenu_catalogue.Size = New System.Drawing.Size(197, 24)
        Me.submenu_catalogue.Text = "Catalogue"
        Me.submenu_catalogue.Visible = False
        '
        'submenu_new_item
        '
        Me.submenu_new_item.Name = "submenu_new_item"
        Me.submenu_new_item.Size = New System.Drawing.Size(197, 24)
        Me.submenu_new_item.Text = "New Item"
        Me.submenu_new_item.Visible = False
        '
        'submenu_import_catalogue
        '
        Me.submenu_import_catalogue.Name = "submenu_import_catalogue"
        Me.submenu_import_catalogue.Size = New System.Drawing.Size(197, 24)
        Me.submenu_import_catalogue.Text = "Import Catalogue"
        Me.submenu_import_catalogue.Visible = False
        '
        'submenu_export_catalogue
        '
        Me.submenu_export_catalogue.Name = "submenu_export_catalogue"
        Me.submenu_export_catalogue.Size = New System.Drawing.Size(197, 24)
        Me.submenu_export_catalogue.Text = "Export  Catalogue"
        Me.submenu_export_catalogue.Visible = False
        '
        'menu_sales
        '
        Me.menu_sales.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_create_order, Me.submenu_orders, Me.submenu_quotations, Me.submenu_returns, Me.submenu_customers, Me.submenu_invoices, Me.submenu_logistics})
        Me.menu_sales.Name = "menu_sales"
        Me.menu_sales.Size = New System.Drawing.Size(55, 24)
        Me.menu_sales.Text = "Sales"
        '
        'submenu_create_order
        '
        Me.submenu_create_order.Name = "submenu_create_order"
        Me.submenu_create_order.Size = New System.Drawing.Size(204, 24)
        Me.submenu_create_order.Text = "New Order"
        Me.submenu_create_order.Visible = False
        '
        'submenu_orders
        '
        Me.submenu_orders.Name = "submenu_orders"
        Me.submenu_orders.Size = New System.Drawing.Size(204, 24)
        Me.submenu_orders.Text = "Sales Orders"
        Me.submenu_orders.Visible = False
        '
        'submenu_quotations
        '
        Me.submenu_quotations.Name = "submenu_quotations"
        Me.submenu_quotations.Size = New System.Drawing.Size(204, 24)
        Me.submenu_quotations.Text = "Quotations"
        Me.submenu_quotations.Visible = False
        '
        'submenu_returns
        '
        Me.submenu_returns.Name = "submenu_returns"
        Me.submenu_returns.Size = New System.Drawing.Size(204, 24)
        Me.submenu_returns.Text = "Sales Returns"
        '
        'submenu_customers
        '
        Me.submenu_customers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewCustomerToolStripMenuItem, Me.RegisteredCustomersToolStripMenuItem})
        Me.submenu_customers.Name = "submenu_customers"
        Me.submenu_customers.Size = New System.Drawing.Size(204, 24)
        Me.submenu_customers.Text = "Customers"
        Me.submenu_customers.Visible = False
        '
        'NewCustomerToolStripMenuItem
        '
        Me.NewCustomerToolStripMenuItem.Name = "NewCustomerToolStripMenuItem"
        Me.NewCustomerToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.NewCustomerToolStripMenuItem.Text = "New Customer"
        '
        'RegisteredCustomersToolStripMenuItem
        '
        Me.RegisteredCustomersToolStripMenuItem.Name = "RegisteredCustomersToolStripMenuItem"
        Me.RegisteredCustomersToolStripMenuItem.Size = New System.Drawing.Size(222, 24)
        Me.RegisteredCustomersToolStripMenuItem.Text = "Registered Customers"
        '
        'submenu_invoices
        '
        Me.submenu_invoices.Name = "submenu_invoices"
        Me.submenu_invoices.Size = New System.Drawing.Size(204, 24)
        Me.submenu_invoices.Text = "Transaction Invoice"
        Me.submenu_invoices.Visible = False
        '
        'submenu_logistics
        '
        Me.submenu_logistics.Name = "submenu_logistics"
        Me.submenu_logistics.Size = New System.Drawing.Size(204, 24)
        Me.submenu_logistics.Text = "Logistics"
        Me.submenu_logistics.Visible = False
        '
        'menu_warehouse
        '
        Me.menu_warehouse.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_stock_management, Me.submenu_packageManagement, Me.submenu_ReceivingManagement, Me.submenu_delivery_logs, Me.submenu_product_inventory, Me.submenu_selluseller})
        Me.menu_warehouse.Name = "menu_warehouse"
        Me.menu_warehouse.Size = New System.Drawing.Size(94, 24)
        Me.menu_warehouse.Text = "Warehouse"
        '
        'submenu_stock_management
        '
        Me.submenu_stock_management.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu2_StockTransfer, Me.submenu2_reconcile})
        Me.submenu_stock_management.Name = "submenu_stock_management"
        Me.submenu_stock_management.Size = New System.Drawing.Size(234, 24)
        Me.submenu_stock_management.Text = "Stock Management"
        Me.submenu_stock_management.Visible = False
        '
        'submenu2_StockTransfer
        '
        Me.submenu2_StockTransfer.Name = "submenu2_StockTransfer"
        Me.submenu2_StockTransfer.Size = New System.Drawing.Size(170, 24)
        Me.submenu2_StockTransfer.Text = "Stock Transfer"
        '
        'submenu2_reconcile
        '
        Me.submenu2_reconcile.Name = "submenu2_reconcile"
        Me.submenu2_reconcile.Size = New System.Drawing.Size(170, 24)
        Me.submenu2_reconcile.Text = "Reconcile"
        '
        'submenu_packageManagement
        '
        Me.submenu_packageManagement.Name = "submenu_packageManagement"
        Me.submenu_packageManagement.Size = New System.Drawing.Size(234, 24)
        Me.submenu_packageManagement.Text = "Package Management"
        Me.submenu_packageManagement.Visible = False
        '
        'submenu_ReceivingManagement
        '
        Me.submenu_ReceivingManagement.Name = "submenu_ReceivingManagement"
        Me.submenu_ReceivingManagement.Size = New System.Drawing.Size(234, 24)
        Me.submenu_ReceivingManagement.Text = "Receiving Management"
        Me.submenu_ReceivingManagement.Visible = False
        '
        'submenu_delivery_logs
        '
        Me.submenu_delivery_logs.Name = "submenu_delivery_logs"
        Me.submenu_delivery_logs.Size = New System.Drawing.Size(234, 24)
        Me.submenu_delivery_logs.Text = "Delivery Logs"
        Me.submenu_delivery_logs.Visible = False
        '
        'submenu_product_inventory
        '
        Me.submenu_product_inventory.Name = "submenu_product_inventory"
        Me.submenu_product_inventory.Size = New System.Drawing.Size(234, 24)
        Me.submenu_product_inventory.Text = "Inventory"
        Me.submenu_product_inventory.Visible = False
        '
        'submenu_selluseller
        '
        Me.submenu_selluseller.Name = "submenu_selluseller"
        Me.submenu_selluseller.Size = New System.Drawing.Size(234, 24)
        Me.submenu_selluseller.Text = "For SelluSeller"
        Me.submenu_selluseller.Visible = False
        '
        'menu_logistics
        '
        Me.menu_logistics.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_order_management, Me.submenu_StockTransferDispatching})
        Me.menu_logistics.Name = "menu_logistics"
        Me.menu_logistics.Size = New System.Drawing.Size(78, 24)
        Me.menu_logistics.Text = "Logistics"
        '
        'submenu_order_management
        '
        Me.submenu_order_management.Name = "submenu_order_management"
        Me.submenu_order_management.Size = New System.Drawing.Size(276, 24)
        Me.submenu_order_management.Text = "Order Releasing Management"
        Me.submenu_order_management.Visible = False
        '
        'submenu_StockTransferDispatching
        '
        Me.submenu_StockTransferDispatching.Name = "submenu_StockTransferDispatching"
        Me.submenu_StockTransferDispatching.Size = New System.Drawing.Size(276, 24)
        Me.submenu_StockTransferDispatching.Text = "Stock Transfer Dispatching"
        Me.submenu_StockTransferDispatching.Visible = False
        '
        'menu_collections
        '
        Me.menu_collections.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_payments, Me.submenu_payment_new, Me.submenu_cheque_book, Me.submenu_soa})
        Me.menu_collections.Name = "menu_collections"
        Me.menu_collections.Size = New System.Drawing.Size(94, 24)
        Me.menu_collections.Text = "Collections"
        '
        'submenu_payments
        '
        Me.submenu_payments.Name = "submenu_payments"
        Me.submenu_payments.Size = New System.Drawing.Size(222, 24)
        Me.submenu_payments.Text = "Order Payments"
        Me.submenu_payments.Visible = False
        '
        'submenu_payment_new
        '
        Me.submenu_payment_new.Name = "submenu_payment_new"
        Me.submenu_payment_new.Size = New System.Drawing.Size(222, 24)
        Me.submenu_payment_new.Text = "New Cheque Payment"
        Me.submenu_payment_new.Visible = False
        '
        'submenu_cheque_book
        '
        Me.submenu_cheque_book.Name = "submenu_cheque_book"
        Me.submenu_cheque_book.Size = New System.Drawing.Size(222, 24)
        Me.submenu_cheque_book.Text = "Cheque Book"
        Me.submenu_cheque_book.Visible = False
        '
        'submenu_soa
        '
        Me.submenu_soa.Name = "submenu_soa"
        Me.submenu_soa.Size = New System.Drawing.Size(222, 24)
        Me.submenu_soa.Text = "Statement of Account"
        Me.submenu_soa.Visible = False
        '
        'menu_accounting
        '
        Me.menu_accounting.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_account_payables, Me.submenu_generate, Me.submenu_payment_vouchers, Me.submenu_payment_cheques, Me.submenu_payment_cash, Me.submenu_ForecastAndPayablesToolStripMenuItem, Me.submenu_InventoryCount})
        Me.menu_accounting.Name = "menu_accounting"
        Me.menu_accounting.Size = New System.Drawing.Size(96, 24)
        Me.menu_accounting.Text = "Accounting"
        '
        'submenu_account_payables
        '
        Me.submenu_account_payables.Name = "submenu_account_payables"
        Me.submenu_account_payables.Size = New System.Drawing.Size(271, 24)
        Me.submenu_account_payables.Text = "Account Payables"
        Me.submenu_account_payables.Visible = False
        '
        'submenu_generate
        '
        Me.submenu_generate.Name = "submenu_generate"
        Me.submenu_generate.Size = New System.Drawing.Size(271, 24)
        Me.submenu_generate.Text = "Generate Payment && Voucher"
        Me.submenu_generate.Visible = False
        '
        'submenu_payment_vouchers
        '
        Me.submenu_payment_vouchers.Name = "submenu_payment_vouchers"
        Me.submenu_payment_vouchers.Size = New System.Drawing.Size(271, 24)
        Me.submenu_payment_vouchers.Text = "Payment Vouchers"
        Me.submenu_payment_vouchers.Visible = False
        '
        'submenu_payment_cheques
        '
        Me.submenu_payment_cheques.Name = "submenu_payment_cheques"
        Me.submenu_payment_cheques.Size = New System.Drawing.Size(271, 24)
        Me.submenu_payment_cheques.Text = "Payment Cheques"
        Me.submenu_payment_cheques.Visible = False
        '
        'submenu_payment_cash
        '
        Me.submenu_payment_cash.Name = "submenu_payment_cash"
        Me.submenu_payment_cash.Size = New System.Drawing.Size(271, 24)
        Me.submenu_payment_cash.Text = "Payment Cash"
        '
        'submenu_ForecastAndPayablesToolStripMenuItem
        '
        Me.submenu_ForecastAndPayablesToolStripMenuItem.Name = "submenu_ForecastAndPayablesToolStripMenuItem"
        Me.submenu_ForecastAndPayablesToolStripMenuItem.Size = New System.Drawing.Size(271, 24)
        Me.submenu_ForecastAndPayablesToolStripMenuItem.Text = "Forecast And Payables"
        '
        'submenu_InventoryCount
        '
        Me.submenu_InventoryCount.Name = "submenu_InventoryCount"
        Me.submenu_InventoryCount.Size = New System.Drawing.Size(271, 24)
        Me.submenu_InventoryCount.Text = "Inventory Count"
        '
        'menu_purchasing
        '
        Me.menu_purchasing.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_purchasing_new, Me.submenu_purchasing_orders, Me.submenu_po_returns})
        Me.menu_purchasing.Name = "menu_purchasing"
        Me.menu_purchasing.Size = New System.Drawing.Size(92, 24)
        Me.menu_purchasing.Text = "Purchasing"
        '
        'submenu_purchasing_new
        '
        Me.submenu_purchasing_new.Name = "submenu_purchasing_new"
        Me.submenu_purchasing_new.Size = New System.Drawing.Size(189, 24)
        Me.submenu_purchasing_new.Text = "New Purchase"
        Me.submenu_purchasing_new.Visible = False
        '
        'submenu_purchasing_orders
        '
        Me.submenu_purchasing_orders.Name = "submenu_purchasing_orders"
        Me.submenu_purchasing_orders.Size = New System.Drawing.Size(189, 24)
        Me.submenu_purchasing_orders.Text = "Purchase Orders"
        Me.submenu_purchasing_orders.Visible = False
        '
        'submenu_po_returns
        '
        Me.submenu_po_returns.Name = "submenu_po_returns"
        Me.submenu_po_returns.Size = New System.Drawing.Size(189, 24)
        Me.submenu_po_returns.Text = "Purchase Returns"
        '
        'menu_administration
        '
        Me.menu_administration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu_user_accounts, Me.submenu_approvals, Me.submenu_price_books, Me.submenu_reports, Me.submenu_banks, Me.submenu_warehouse, Me.submenu_suppliers, Me.submenu_settings})
        Me.menu_administration.Name = "menu_administration"
        Me.menu_administration.Size = New System.Drawing.Size(119, 24)
        Me.menu_administration.Text = "Administration"
        '
        'submenu_user_accounts
        '
        Me.submenu_user_accounts.Name = "submenu_user_accounts"
        Me.submenu_user_accounts.Size = New System.Drawing.Size(171, 24)
        Me.submenu_user_accounts.Text = "User Accounts"
        Me.submenu_user_accounts.Visible = False
        '
        'submenu_approvals
        '
        Me.submenu_approvals.Name = "submenu_approvals"
        Me.submenu_approvals.Size = New System.Drawing.Size(171, 24)
        Me.submenu_approvals.Text = "Approvals"
        Me.submenu_approvals.Visible = False
        '
        'submenu_price_books
        '
        Me.submenu_price_books.Name = "submenu_price_books"
        Me.submenu_price_books.Size = New System.Drawing.Size(171, 24)
        Me.submenu_price_books.Text = "Price Book"
        Me.submenu_price_books.Visible = False
        '
        'submenu_reports
        '
        Me.submenu_reports.Name = "submenu_reports"
        Me.submenu_reports.Size = New System.Drawing.Size(171, 24)
        Me.submenu_reports.Text = "Reports"
        Me.submenu_reports.Visible = False
        '
        'submenu_banks
        '
        Me.submenu_banks.Name = "submenu_banks"
        Me.submenu_banks.Size = New System.Drawing.Size(171, 24)
        Me.submenu_banks.Text = "Banks"
        '
        'submenu_warehouse
        '
        Me.submenu_warehouse.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.submenu2_new_warehouse, Me.submenu2_registered_warehouse})
        Me.submenu_warehouse.Name = "submenu_warehouse"
        Me.submenu_warehouse.Size = New System.Drawing.Size(171, 24)
        Me.submenu_warehouse.Text = "Warehouse"
        Me.submenu_warehouse.Visible = False
        '
        'submenu2_new_warehouse
        '
        Me.submenu2_new_warehouse.Name = "submenu2_new_warehouse"
        Me.submenu2_new_warehouse.Size = New System.Drawing.Size(232, 24)
        Me.submenu2_new_warehouse.Text = "Create New Warehouse"
        '
        'submenu2_registered_warehouse
        '
        Me.submenu2_registered_warehouse.Name = "submenu2_registered_warehouse"
        Me.submenu2_registered_warehouse.Size = New System.Drawing.Size(232, 24)
        Me.submenu2_registered_warehouse.Text = "Registered Warehouse"
        '
        'submenu_suppliers
        '
        Me.submenu_suppliers.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewSupplierToolStripMenuItem, Me.RegisteredSupplierToolStripMenuItem})
        Me.submenu_suppliers.Name = "submenu_suppliers"
        Me.submenu_suppliers.Size = New System.Drawing.Size(171, 24)
        Me.submenu_suppliers.Text = "Suppliers"
        Me.submenu_suppliers.Visible = False
        '
        'NewSupplierToolStripMenuItem
        '
        Me.NewSupplierToolStripMenuItem.Name = "NewSupplierToolStripMenuItem"
        Me.NewSupplierToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.NewSupplierToolStripMenuItem.Text = "New Supplier"
        '
        'RegisteredSupplierToolStripMenuItem
        '
        Me.RegisteredSupplierToolStripMenuItem.Name = "RegisteredSupplierToolStripMenuItem"
        Me.RegisteredSupplierToolStripMenuItem.Size = New System.Drawing.Size(208, 24)
        Me.RegisteredSupplierToolStripMenuItem.Text = "Registered Supplier"
        '
        'submenu_settings
        '
        Me.submenu_settings.Name = "submenu_settings"
        Me.submenu_settings.Size = New System.Drawing.Size(171, 24)
        Me.submenu_settings.Text = "Settings"
        Me.submenu_settings.Visible = False
        '
        'menu_my_account
        '
        Me.menu_my_account.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.menu_my_account.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.menu_my_account.Name = "menu_my_account"
        Me.menu_my_account.Size = New System.Drawing.Size(99, 24)
        Me.menu_my_account.Text = "My Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(180, 24)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaLinePanel1.Controls.Add(Me.user_role_id)
        Me.GunaLinePanel1.Controls.Add(Me.user_id)
        Me.GunaLinePanel1.Controls.Add(Me.user_role)
        Me.GunaLinePanel1.Controls.Add(Me.user_name)
        Me.GunaLinePanel1.Controls.Add(Me.user_photo)
        Me.GunaLinePanel1.LineColor = System.Drawing.SystemColors.ControlLight
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.Location = New System.Drawing.Point(1216, 12)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(208, 63)
        Me.GunaLinePanel1.TabIndex = 2
        '
        'user_role_id
        '
        Me.user_role_id.AutoSize = True
        Me.user_role_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_role_id.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.user_role_id.Location = New System.Drawing.Point(128, 33)
        Me.user_role_id.Name = "user_role_id"
        Me.user_role_id.Size = New System.Drawing.Size(38, 13)
        Me.user_role_id.TabIndex = 5
        Me.user_role_id.Text = "role_id"
        Me.user_role_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.user_role_id.Visible = False
        '
        'user_id
        '
        Me.user_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_id.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.user_id.Location = New System.Drawing.Point(68, 46)
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(45, 15)
        Me.user_id.TabIndex = 4
        Me.user_id.Text = "user_id"
        Me.user_id.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.user_id.Visible = False
        '
        'user_role
        '
        Me.user_role.AutoSize = True
        Me.user_role.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_role.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.user_role.Location = New System.Drawing.Point(66, 33)
        Me.user_role.Name = "user_role"
        Me.user_role.Size = New System.Drawing.Size(54, 13)
        Me.user_role.TabIndex = 3
        Me.user_role.Text = "User Role"
        Me.user_role.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'user_name
        '
        Me.user_name.AutoSize = True
        Me.user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_name.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.user_name.Location = New System.Drawing.Point(65, 12)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(89, 20)
        Me.user_name.TabIndex = 2
        Me.user_name.Text = "User Name"
        Me.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'user_photo
        '
        Me.user_photo.BaseColor = System.Drawing.Color.Gainsboro
        Me.user_photo.Image = CType(resources.GetObject("user_photo.Image"), System.Drawing.Image)
        Me.user_photo.Location = New System.Drawing.Point(15, 6)
        Me.user_photo.Name = "user_photo"
        Me.user_photo.Size = New System.Drawing.Size(45, 45)
        Me.user_photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.user_photo.TabIndex = 1
        Me.user_photo.TabStop = False
        Me.user_photo.UseTransfarantBackground = False
        '
        'Guna2Elipse
        '
        Me.Guna2Elipse.BorderRadius = 10
        Me.Guna2Elipse.TargetControl = Me.user_store
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1424, 861)
        Me.Controls.Add(Me.panel_main)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(1440, 900)
        Me.Name = "frm_main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ZERP Business Solution"
        Me.panel_main.ResumeLayout(False)
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.user_photo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_main As Guna.UI.WinForms.GunaPanel
    Friend WithEvents panel_content As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents user_photo As Guna.UI.WinForms.GunaCirclePictureBox
    Friend WithEvents user_role As Guna.UI.WinForms.GunaLabel
    Friend WithEvents user_name As Guna.UI.WinForms.GunaLabel
    Friend WithEvents user_store As Guna.UI.WinForms.GunaLabel
    Friend WithEvents user_id As Guna.UI.WinForms.GunaLabel
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents menu_sales As ToolStripMenuItem
    Friend WithEvents menu_warehouse As ToolStripMenuItem
    Friend WithEvents menu_administration As ToolStripMenuItem
    Friend WithEvents submenu_orders As ToolStripMenuItem
    Friend WithEvents submenu_create_order As ToolStripMenuItem
    Friend WithEvents menu_product As ToolStripMenuItem
    Friend WithEvents submenu_customers As ToolStripMenuItem
    Friend WithEvents NewCustomerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents submenu_user_accounts As ToolStripMenuItem
    Friend WithEvents submenu_warehouse As ToolStripMenuItem
    Friend WithEvents NewStoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents submenu_suppliers As ToolStripMenuItem
    Friend WithEvents NewSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents submenu_stock_management As ToolStripMenuItem
    Friend WithEvents menu_my_account As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisteredStoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisteredSupplierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegisteredCustomersToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel_top As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents submenu_ReceivingManagement As ToolStripMenuItem
    Friend WithEvents submenu_delivery_logs As ToolStripMenuItem
    Friend WithEvents submenu_product_inventory As ToolStripMenuItem
    Friend WithEvents submenu_price_books As ToolStripMenuItem
    Friend WithEvents menu_collections As ToolStripMenuItem
    Friend WithEvents submenu_payments As ToolStripMenuItem
    Friend WithEvents submenu_payment_new As ToolStripMenuItem
    Friend WithEvents submenu_cheque_book As ToolStripMenuItem
    Friend WithEvents menu_logistics As ToolStripMenuItem
    Friend WithEvents submenu_order_management As ToolStripMenuItem
    Friend WithEvents menu_purchasing As ToolStripMenuItem
    Friend WithEvents submenu_purchasing_new As ToolStripMenuItem
    Friend WithEvents submenu_purchasing_orders As ToolStripMenuItem
    Friend WithEvents menu_accounting As ToolStripMenuItem
    Friend WithEvents submenu_payment_vouchers As ToolStripMenuItem
    Friend WithEvents submenu_account_payables As ToolStripMenuItem
    Friend WithEvents submenu_generate As ToolStripMenuItem
    Friend WithEvents submenu_payment_cheques As ToolStripMenuItem
    Friend WithEvents submenu_settings As ToolStripMenuItem
    Friend WithEvents submenu_approvals As ToolStripMenuItem
    Friend WithEvents submenu_catalogue As ToolStripMenuItem
    Friend WithEvents submenu_new_item As ToolStripMenuItem
    Friend WithEvents submenu_import_catalogue As ToolStripMenuItem
    Friend WithEvents submenu_export_catalogue As ToolStripMenuItem
    Friend WithEvents user_role_id As Guna.UI.WinForms.GunaLabel
    Friend WithEvents bgw_main As System.ComponentModel.BackgroundWorker
    Friend WithEvents submenu_soa As ToolStripMenuItem
    Friend WithEvents Guna2Elipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents submenu_invoices As ToolStripMenuItem
    'MY EDIT
    Friend WithEvents submenu_logistics As ToolStripMenuItem
    Friend WithEvents submenu2_new_warehouse As ToolStripMenuItem
    Friend WithEvents submenu2_registered_warehouse As ToolStripMenuItem
    Private WithEvents PictureEdit1 As PictureEdit
    Friend WithEvents submenu_banks As ToolStripMenuItem
    Friend WithEvents submenu_reports As ToolStripMenuItem
    Friend WithEvents submenu_quotations As ToolStripMenuItem
    Friend WithEvents submenu_po_returns As ToolStripMenuItem
    Friend WithEvents submenu_payment_cash As ToolStripMenuItem
    Friend WithEvents submenu_ForecastAndPayablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents submenu_returns As ToolStripMenuItem
    Friend WithEvents submenu_InventoryCount As ToolStripMenuItem
    Friend WithEvents submenu_selluseller As ToolStripMenuItem
    Friend WithEvents submenu2_StockTransfer As ToolStripMenuItem
    Friend WithEvents submenu2_reconcile As ToolStripMenuItem
    Friend WithEvents submenu_packageManagement As ToolStripMenuItem
    Friend WithEvents submenu_StockTransferDispatching As ToolStripMenuItem
End Class
