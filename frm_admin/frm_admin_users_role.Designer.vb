Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_users_role
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_users_role))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.acc_username = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.acc_id = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.acc_role = New DevExpress.XtraEditors.LabelControl()
        Me.acc_name = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.GroupControl7 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_reports = New System.Windows.Forms.CheckBox()
        Me.cb_stores = New System.Windows.Forms.CheckBox()
        Me.cb_suppliers = New System.Windows.Forms.CheckBox()
        Me.cb_settings = New System.Windows.Forms.CheckBox()
        Me.cb_user_accounts = New System.Windows.Forms.CheckBox()
        Me.cb_approvals = New System.Windows.Forms.CheckBox()
        Me.cb_price_book = New System.Windows.Forms.CheckBox()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_soa = New System.Windows.Forms.CheckBox()
        Me.cb_order_payments = New System.Windows.Forms.CheckBox()
        Me.cb_new_cheque_payment = New System.Windows.Forms.CheckBox()
        Me.cb_cheque_book = New System.Windows.Forms.CheckBox()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_account_payables = New System.Windows.Forms.CheckBox()
        Me.cb_generate = New System.Windows.Forms.CheckBox()
        Me.cb_payment_vouchers = New System.Windows.Forms.CheckBox()
        Me.cb_payment_cheques = New System.Windows.Forms.CheckBox()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_for_selluseller = New System.Windows.Forms.CheckBox()
        Me.cb_receiving_mgmt = New System.Windows.Forms.CheckBox()
        Me.cb_delivery_logs = New System.Windows.Forms.CheckBox()
        Me.cb_stock_management = New System.Windows.Forms.CheckBox()
        Me.cb_stock_inventory = New System.Windows.Forms.CheckBox()
        Me.cb_package_mgmt = New System.Windows.Forms.CheckBox()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_new_purchase = New System.Windows.Forms.CheckBox()
        Me.cb_purchase_orders = New System.Windows.Forms.CheckBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_quotations = New System.Windows.Forms.CheckBox()
        Me.cb_logistics = New System.Windows.Forms.CheckBox()
        Me.cb_orders = New System.Windows.Forms.CheckBox()
        Me.cb_transaction_invoice = New System.Windows.Forms.CheckBox()
        Me.cb_create_order = New System.Windows.Forms.CheckBox()
        Me.cb_customers = New System.Windows.Forms.CheckBox()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_order_management = New System.Windows.Forms.CheckBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_catalogue = New System.Windows.Forms.CheckBox()
        Me.cb_new_item = New System.Windows.Forms.CheckBox()
        Me.cb_import_catalogue = New System.Windows.Forms.CheckBox()
        Me.cb_export_catalogue = New System.Windows.Forms.CheckBox()
        Me.cb_stock_transfer_dispatching = New System.Windows.Forms.CheckBox()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl7.SuspendLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl6.SuspendLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl8.SuspendLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl5.SuspendLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl9.SuspendLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl4.SuspendLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl10.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Controls.Add(Me.GunaLabel1)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1084, 78)
        Me.GunaPanel2.TabIndex = 14
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel3.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1048, 27)
        Me.GunaPanel3.TabIndex = 5
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel4.Controls.Add(Me.LabelControl6)
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel4.TabIndex = 1
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl1.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.Enabled = False
        Me.HyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(70, 5)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.ShowLineShadow = False
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(113, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = " Roles Assignment"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = ">"
        '
        'HyperlinkLabelControl2
        '
        Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl2.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl2.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceDisabled.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl2.Location = New System.Drawing.Point(13, 5)
        Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
        Me.HyperlinkLabelControl2.ShowLineShadow = False
        Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(37, 18)
        Me.HyperlinkLabelControl2.TabIndex = 5
        Me.HyperlinkLabelControl2.Text = "Home"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(233, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Roles Assignment"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1084, 557)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.GroupControl2)
        Me.Panel2.Controls.Add(Me.btn_save)
        Me.Panel2.Controls.Add(Me.btn_close)
        Me.Panel2.Controls.Add(Me.GroupControl1)
        Me.Panel2.Location = New System.Drawing.Point(24, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1048, 529)
        Me.Panel2.TabIndex = 32
        '
        'GroupControl2
        '
        Me.GroupControl2.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl2.AppearanceCaption.Options.UseFont = True
        Me.GroupControl2.Controls.Add(Me.acc_username)
        Me.GroupControl2.Controls.Add(Me.LabelControl3)
        Me.GroupControl2.Controls.Add(Me.acc_id)
        Me.GroupControl2.Controls.Add(Me.LabelControl5)
        Me.GroupControl2.Controls.Add(Me.acc_role)
        Me.GroupControl2.Controls.Add(Me.acc_name)
        Me.GroupControl2.Controls.Add(Me.LabelControl2)
        Me.GroupControl2.Controls.Add(Me.LabelControl1)
        Me.GroupControl2.Location = New System.Drawing.Point(20, 29)
        Me.GroupControl2.LookAndFeel.SkinName = "DevExpress Style"
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(244, 198)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "User Details"
        '
        'acc_username
        '
        Me.acc_username.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_username.Appearance.Options.UseFont = True
        Me.acc_username.Location = New System.Drawing.Point(119, 71)
        Me.acc_username.Name = "acc_username"
        Me.acc_username.Size = New System.Drawing.Size(42, 16)
        Me.acc_username.TabIndex = 7
        Me.acc_username.Text = "jzenery"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(25, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Name:"
        '
        'acc_id
        '
        Me.acc_id.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_id.Appearance.Options.UseFont = True
        Me.acc_id.Location = New System.Drawing.Point(119, 49)
        Me.acc_id.Name = "acc_id"
        Me.acc_id.Size = New System.Drawing.Size(56, 16)
        Me.acc_id.TabIndex = 5
        Me.acc_id.Text = "00000001"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(23, 49)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Account ID:"
        '
        'acc_role
        '
        Me.acc_role.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_role.Appearance.Options.UseFont = True
        Me.acc_role.Location = New System.Drawing.Point(119, 135)
        Me.acc_role.Name = "acc_role"
        Me.acc_role.Size = New System.Drawing.Size(77, 16)
        Me.acc_role.TabIndex = 3
        Me.acc_role.Text = "Administrator"
        '
        'acc_name
        '
        Me.acc_name.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_name.Appearance.Options.UseFont = True
        Me.acc_name.Location = New System.Drawing.Point(119, 93)
        Me.acc_name.Name = "acc_name"
        Me.acc_name.Size = New System.Drawing.Size(100, 16)
        Me.acc_name.TabIndex = 2
        Me.acc_name.Text = "John Zenery Bullo"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(25, 134)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(33, 16)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Role:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 71)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(64, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Username"
        '
        'btn_save
        '
        Me.btn_save.Appearance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.Location = New System.Drawing.Point(139, 233)
        Me.btn_save.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(125, 33)
        Me.btn_save.TabIndex = 31
        Me.btn_save.Text = "Apply"
        '
        'btn_close
        '
        Me.btn_close.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_close.Appearance.Options.UseFont = True
        Me.btn_close.Location = New System.Drawing.Point(20, 233)
        Me.btn_close.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_close.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(113, 33)
        Me.btn_close.TabIndex = 30
        Me.btn_close.Text = "Close"
        '
        'GroupControl1
        '
        Me.GroupControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.GroupControl1.Appearance.Options.UseBackColor = True
        Me.GroupControl1.AppearanceCaption.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.GroupControl1.AppearanceCaption.Options.UseFont = True
        Me.GroupControl1.Controls.Add(Me.GroupControl7)
        Me.GroupControl1.Controls.Add(Me.GroupControl6)
        Me.GroupControl1.Controls.Add(Me.GroupControl8)
        Me.GroupControl1.Controls.Add(Me.GroupControl5)
        Me.GroupControl1.Controls.Add(Me.GroupControl9)
        Me.GroupControl1.Controls.Add(Me.GroupControl4)
        Me.GroupControl1.Controls.Add(Me.GroupControl10)
        Me.GroupControl1.Controls.Add(Me.GroupControl3)
        Me.GroupControl1.Location = New System.Drawing.Point(280, 29)
        Me.GroupControl1.LookAndFeel.SkinName = "DevExpress Style"
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(754, 497)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Account Roles"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.cb_reports)
        Me.GroupControl7.Controls.Add(Me.cb_stores)
        Me.GroupControl7.Controls.Add(Me.cb_suppliers)
        Me.GroupControl7.Controls.Add(Me.cb_settings)
        Me.GroupControl7.Controls.Add(Me.cb_user_accounts)
        Me.GroupControl7.Controls.Add(Me.cb_approvals)
        Me.GroupControl7.Controls.Add(Me.cb_price_book)
        Me.GroupControl7.Location = New System.Drawing.Point(556, 269)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl7.TabIndex = 25
        Me.GroupControl7.Text = "Administration"
        '
        'cb_reports
        '
        Me.cb_reports.AutoSize = True
        Me.cb_reports.Location = New System.Drawing.Point(22, 97)
        Me.cb_reports.Name = "cb_reports"
        Me.cb_reports.Size = New System.Drawing.Size(64, 17)
        Me.cb_reports.TabIndex = 19
        Me.cb_reports.Text = "Reports"
        Me.cb_reports.UseVisualStyleBackColor = True
        '
        'cb_stores
        '
        Me.cb_stores.AutoSize = True
        Me.cb_stores.Location = New System.Drawing.Point(23, 120)
        Me.cb_stores.Name = "cb_stores"
        Me.cb_stores.Size = New System.Drawing.Size(81, 17)
        Me.cb_stores.TabIndex = 16
        Me.cb_stores.Text = "Warehouse"
        Me.cb_stores.UseVisualStyleBackColor = True
        '
        'cb_suppliers
        '
        Me.cb_suppliers.AutoSize = True
        Me.cb_suppliers.Location = New System.Drawing.Point(23, 142)
        Me.cb_suppliers.Name = "cb_suppliers"
        Me.cb_suppliers.Size = New System.Drawing.Size(69, 17)
        Me.cb_suppliers.TabIndex = 17
        Me.cb_suppliers.Text = "Suppliers"
        Me.cb_suppliers.UseVisualStyleBackColor = True
        '
        'cb_settings
        '
        Me.cb_settings.AutoSize = True
        Me.cb_settings.Location = New System.Drawing.Point(23, 163)
        Me.cb_settings.Name = "cb_settings"
        Me.cb_settings.Size = New System.Drawing.Size(65, 17)
        Me.cb_settings.TabIndex = 18
        Me.cb_settings.Text = "Settings"
        Me.cb_settings.UseVisualStyleBackColor = True
        '
        'cb_user_accounts
        '
        Me.cb_user_accounts.AutoSize = True
        Me.cb_user_accounts.Location = New System.Drawing.Point(23, 30)
        Me.cb_user_accounts.Name = "cb_user_accounts"
        Me.cb_user_accounts.Size = New System.Drawing.Size(95, 17)
        Me.cb_user_accounts.TabIndex = 13
        Me.cb_user_accounts.Text = "User Accounts"
        Me.cb_user_accounts.UseVisualStyleBackColor = True
        '
        'cb_approvals
        '
        Me.cb_approvals.AutoSize = True
        Me.cb_approvals.Location = New System.Drawing.Point(23, 53)
        Me.cb_approvals.Name = "cb_approvals"
        Me.cb_approvals.Size = New System.Drawing.Size(74, 17)
        Me.cb_approvals.TabIndex = 14
        Me.cb_approvals.Text = "Approvals"
        Me.cb_approvals.UseVisualStyleBackColor = True
        '
        'cb_price_book
        '
        Me.cb_price_book.AutoSize = True
        Me.cb_price_book.Location = New System.Drawing.Point(23, 76)
        Me.cb_price_book.Name = "cb_price_book"
        Me.cb_price_book.Size = New System.Drawing.Size(75, 17)
        Me.cb_price_book.TabIndex = 15
        Me.cb_price_book.Text = "Price Book"
        Me.cb_price_book.UseVisualStyleBackColor = True
        '
        'GroupControl6
        '
        Me.GroupControl6.Controls.Add(Me.cb_soa)
        Me.GroupControl6.Controls.Add(Me.cb_order_payments)
        Me.GroupControl6.Controls.Add(Me.cb_new_cheque_payment)
        Me.GroupControl6.Controls.Add(Me.cb_cheque_book)
        Me.GroupControl6.Location = New System.Drawing.Point(556, 49)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl6.TabIndex = 21
        Me.GroupControl6.Text = "Collections"
        '
        'cb_soa
        '
        Me.cb_soa.AutoSize = True
        Me.cb_soa.Location = New System.Drawing.Point(23, 96)
        Me.cb_soa.Name = "cb_soa"
        Me.cb_soa.Size = New System.Drawing.Size(131, 17)
        Me.cb_soa.TabIndex = 16
        Me.cb_soa.Text = "Statement of Account"
        Me.cb_soa.UseVisualStyleBackColor = True
        '
        'cb_order_payments
        '
        Me.cb_order_payments.AutoSize = True
        Me.cb_order_payments.Location = New System.Drawing.Point(23, 27)
        Me.cb_order_payments.Name = "cb_order_payments"
        Me.cb_order_payments.Size = New System.Drawing.Size(104, 17)
        Me.cb_order_payments.TabIndex = 13
        Me.cb_order_payments.Text = "Order Payments"
        Me.cb_order_payments.UseVisualStyleBackColor = True
        '
        'cb_new_cheque_payment
        '
        Me.cb_new_cheque_payment.AutoSize = True
        Me.cb_new_cheque_payment.Location = New System.Drawing.Point(23, 50)
        Me.cb_new_cheque_payment.Name = "cb_new_cheque_payment"
        Me.cb_new_cheque_payment.Size = New System.Drawing.Size(132, 17)
        Me.cb_new_cheque_payment.TabIndex = 14
        Me.cb_new_cheque_payment.Text = "New Cheque Payment"
        Me.cb_new_cheque_payment.UseVisualStyleBackColor = True
        '
        'cb_cheque_book
        '
        Me.cb_cheque_book.AutoSize = True
        Me.cb_cheque_book.Location = New System.Drawing.Point(23, 73)
        Me.cb_cheque_book.Name = "cb_cheque_book"
        Me.cb_cheque_book.Size = New System.Drawing.Size(89, 17)
        Me.cb_cheque_book.TabIndex = 15
        Me.cb_cheque_book.Text = "Cheque Book"
        Me.cb_cheque_book.UseVisualStyleBackColor = True
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.cb_account_payables)
        Me.GroupControl8.Controls.Add(Me.cb_generate)
        Me.GroupControl8.Controls.Add(Me.cb_payment_vouchers)
        Me.GroupControl8.Controls.Add(Me.cb_payment_cheques)
        Me.GroupControl8.Location = New System.Drawing.Point(381, 269)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl8.TabIndex = 24
        Me.GroupControl8.Text = "Accounting"
        '
        'cb_account_payables
        '
        Me.cb_account_payables.AutoSize = True
        Me.cb_account_payables.Location = New System.Drawing.Point(23, 30)
        Me.cb_account_payables.Name = "cb_account_payables"
        Me.cb_account_payables.Size = New System.Drawing.Size(111, 17)
        Me.cb_account_payables.TabIndex = 13
        Me.cb_account_payables.Text = "Account Payables"
        Me.cb_account_payables.UseVisualStyleBackColor = True
        '
        'cb_generate
        '
        Me.cb_generate.AutoSize = True
        Me.cb_generate.Location = New System.Drawing.Point(23, 53)
        Me.cb_generate.Name = "cb_generate"
        Me.cb_generate.Size = New System.Drawing.Size(71, 17)
        Me.cb_generate.TabIndex = 14
        Me.cb_generate.Text = "Generate"
        Me.cb_generate.UseVisualStyleBackColor = True
        '
        'cb_payment_vouchers
        '
        Me.cb_payment_vouchers.AutoSize = True
        Me.cb_payment_vouchers.Location = New System.Drawing.Point(23, 76)
        Me.cb_payment_vouchers.Name = "cb_payment_vouchers"
        Me.cb_payment_vouchers.Size = New System.Drawing.Size(115, 17)
        Me.cb_payment_vouchers.TabIndex = 15
        Me.cb_payment_vouchers.Text = "Payment Vouchers"
        Me.cb_payment_vouchers.UseVisualStyleBackColor = True
        '
        'cb_payment_cheques
        '
        Me.cb_payment_cheques.AutoSize = True
        Me.cb_payment_cheques.Location = New System.Drawing.Point(23, 99)
        Me.cb_payment_cheques.Name = "cb_payment_cheques"
        Me.cb_payment_cheques.Size = New System.Drawing.Size(113, 17)
        Me.cb_payment_cheques.TabIndex = 16
        Me.cb_payment_cheques.Text = "Payment Cheques"
        Me.cb_payment_cheques.UseVisualStyleBackColor = True
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.cb_for_selluseller)
        Me.GroupControl5.Controls.Add(Me.cb_receiving_mgmt)
        Me.GroupControl5.Controls.Add(Me.cb_delivery_logs)
        Me.GroupControl5.Controls.Add(Me.cb_stock_management)
        Me.GroupControl5.Controls.Add(Me.cb_stock_inventory)
        Me.GroupControl5.Controls.Add(Me.cb_package_mgmt)
        Me.GroupControl5.Location = New System.Drawing.Point(381, 49)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl5.TabIndex = 20
        Me.GroupControl5.Text = "Warehouse"
        '
        'cb_for_selluseller
        '
        Me.cb_for_selluseller.AutoSize = True
        Me.cb_for_selluseller.Location = New System.Drawing.Point(23, 142)
        Me.cb_for_selluseller.Name = "cb_for_selluseller"
        Me.cb_for_selluseller.Size = New System.Drawing.Size(93, 17)
        Me.cb_for_selluseller.TabIndex = 18
        Me.cb_for_selluseller.Text = "For SelluSeller"
        Me.cb_for_selluseller.UseVisualStyleBackColor = True
        '
        'cb_receiving_mgmt
        '
        Me.cb_receiving_mgmt.AutoSize = True
        Me.cb_receiving_mgmt.Location = New System.Drawing.Point(23, 73)
        Me.cb_receiving_mgmt.Name = "cb_receiving_mgmt"
        Me.cb_receiving_mgmt.Size = New System.Drawing.Size(137, 17)
        Me.cb_receiving_mgmt.TabIndex = 13
        Me.cb_receiving_mgmt.Text = "Receiving Management"
        Me.cb_receiving_mgmt.UseVisualStyleBackColor = True
        '
        'cb_delivery_logs
        '
        Me.cb_delivery_logs.AutoSize = True
        Me.cb_delivery_logs.Location = New System.Drawing.Point(23, 96)
        Me.cb_delivery_logs.Name = "cb_delivery_logs"
        Me.cb_delivery_logs.Size = New System.Drawing.Size(90, 17)
        Me.cb_delivery_logs.TabIndex = 14
        Me.cb_delivery_logs.Text = "Delivery Logs"
        Me.cb_delivery_logs.UseVisualStyleBackColor = True
        '
        'cb_stock_management
        '
        Me.cb_stock_management.AutoSize = True
        Me.cb_stock_management.Location = New System.Drawing.Point(23, 27)
        Me.cb_stock_management.Name = "cb_stock_management"
        Me.cb_stock_management.Size = New System.Drawing.Size(117, 17)
        Me.cb_stock_management.TabIndex = 15
        Me.cb_stock_management.Text = "Stock Management"
        Me.cb_stock_management.UseVisualStyleBackColor = True
        '
        'cb_stock_inventory
        '
        Me.cb_stock_inventory.AutoSize = True
        Me.cb_stock_inventory.Location = New System.Drawing.Point(23, 119)
        Me.cb_stock_inventory.Name = "cb_stock_inventory"
        Me.cb_stock_inventory.Size = New System.Drawing.Size(74, 17)
        Me.cb_stock_inventory.TabIndex = 16
        Me.cb_stock_inventory.Text = "Inventory"
        Me.cb_stock_inventory.UseVisualStyleBackColor = True
        '
        'cb_package_mgmt
        '
        Me.cb_package_mgmt.AutoSize = True
        Me.cb_package_mgmt.Location = New System.Drawing.Point(23, 50)
        Me.cb_package_mgmt.Name = "cb_package_mgmt"
        Me.cb_package_mgmt.Size = New System.Drawing.Size(131, 17)
        Me.cb_package_mgmt.TabIndex = 10
        Me.cb_package_mgmt.Text = "Package Management"
        Me.cb_package_mgmt.UseVisualStyleBackColor = True
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.cb_new_purchase)
        Me.GroupControl9.Controls.Add(Me.cb_purchase_orders)
        Me.GroupControl9.Location = New System.Drawing.Point(206, 269)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl9.TabIndex = 23
        Me.GroupControl9.Text = "Purchasing"
        '
        'cb_new_purchase
        '
        Me.cb_new_purchase.AutoSize = True
        Me.cb_new_purchase.Location = New System.Drawing.Point(23, 30)
        Me.cb_new_purchase.Name = "cb_new_purchase"
        Me.cb_new_purchase.Size = New System.Drawing.Size(94, 17)
        Me.cb_new_purchase.TabIndex = 7
        Me.cb_new_purchase.Text = "New Purchase"
        Me.cb_new_purchase.UseVisualStyleBackColor = True
        '
        'cb_purchase_orders
        '
        Me.cb_purchase_orders.AutoSize = True
        Me.cb_purchase_orders.Location = New System.Drawing.Point(23, 53)
        Me.cb_purchase_orders.Name = "cb_purchase_orders"
        Me.cb_purchase_orders.Size = New System.Drawing.Size(106, 17)
        Me.cb_purchase_orders.TabIndex = 8
        Me.cb_purchase_orders.Text = "Purchase Orders"
        Me.cb_purchase_orders.UseVisualStyleBackColor = True
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cb_quotations)
        Me.GroupControl4.Controls.Add(Me.cb_logistics)
        Me.GroupControl4.Controls.Add(Me.cb_orders)
        Me.GroupControl4.Controls.Add(Me.cb_transaction_invoice)
        Me.GroupControl4.Controls.Add(Me.cb_create_order)
        Me.GroupControl4.Controls.Add(Me.cb_customers)
        Me.GroupControl4.Location = New System.Drawing.Point(206, 49)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl4.TabIndex = 19
        Me.GroupControl4.Text = "Sales"
        '
        'cb_quotations
        '
        Me.cb_quotations.AutoSize = True
        Me.cb_quotations.Location = New System.Drawing.Point(23, 73)
        Me.cb_quotations.Name = "cb_quotations"
        Me.cb_quotations.Size = New System.Drawing.Size(79, 17)
        Me.cb_quotations.TabIndex = 12
        Me.cb_quotations.Text = "Quotations"
        Me.cb_quotations.UseVisualStyleBackColor = True
        '
        'cb_logistics
        '
        Me.cb_logistics.AutoSize = True
        Me.cb_logistics.Location = New System.Drawing.Point(23, 142)
        Me.cb_logistics.Name = "cb_logistics"
        Me.cb_logistics.Size = New System.Drawing.Size(66, 17)
        Me.cb_logistics.TabIndex = 11
        Me.cb_logistics.Text = "Logistics"
        Me.cb_logistics.UseVisualStyleBackColor = True
        '
        'cb_orders
        '
        Me.cb_orders.AutoSize = True
        Me.cb_orders.Location = New System.Drawing.Point(23, 50)
        Me.cb_orders.Name = "cb_orders"
        Me.cb_orders.Size = New System.Drawing.Size(87, 17)
        Me.cb_orders.TabIndex = 7
        Me.cb_orders.Text = "Sales Orders"
        Me.cb_orders.UseVisualStyleBackColor = True
        '
        'cb_transaction_invoice
        '
        Me.cb_transaction_invoice.AutoSize = True
        Me.cb_transaction_invoice.Location = New System.Drawing.Point(23, 119)
        Me.cb_transaction_invoice.Name = "cb_transaction_invoice"
        Me.cb_transaction_invoice.Size = New System.Drawing.Size(120, 17)
        Me.cb_transaction_invoice.TabIndex = 1
        Me.cb_transaction_invoice.Text = "Transaction Invoice"
        Me.cb_transaction_invoice.UseVisualStyleBackColor = True
        '
        'cb_create_order
        '
        Me.cb_create_order.AutoSize = True
        Me.cb_create_order.Location = New System.Drawing.Point(23, 27)
        Me.cb_create_order.Name = "cb_create_order"
        Me.cb_create_order.Size = New System.Drawing.Size(78, 17)
        Me.cb_create_order.TabIndex = 8
        Me.cb_create_order.Text = "New Order"
        Me.cb_create_order.UseVisualStyleBackColor = True
        '
        'cb_customers
        '
        Me.cb_customers.AutoSize = True
        Me.cb_customers.Location = New System.Drawing.Point(23, 96)
        Me.cb_customers.Name = "cb_customers"
        Me.cb_customers.Size = New System.Drawing.Size(77, 17)
        Me.cb_customers.TabIndex = 9
        Me.cb_customers.Text = "Customers"
        Me.cb_customers.UseVisualStyleBackColor = True
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.cb_stock_transfer_dispatching)
        Me.GroupControl10.Controls.Add(Me.cb_order_management)
        Me.GroupControl10.Location = New System.Drawing.Point(31, 269)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl10.TabIndex = 22
        Me.GroupControl10.Text = "Logistics"
        '
        'cb_order_management
        '
        Me.cb_order_management.AutoSize = True
        Me.cb_order_management.Location = New System.Drawing.Point(15, 30)
        Me.cb_order_management.Name = "cb_order_management"
        Me.cb_order_management.Size = New System.Drawing.Size(136, 17)
        Me.cb_order_management.TabIndex = 0
        Me.cb_order_management.Text = "Order Releasing Mgmt."
        Me.cb_order_management.UseVisualStyleBackColor = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cb_catalogue)
        Me.GroupControl3.Controls.Add(Me.cb_new_item)
        Me.GroupControl3.Controls.Add(Me.cb_import_catalogue)
        Me.GroupControl3.Controls.Add(Me.cb_export_catalogue)
        Me.GroupControl3.Location = New System.Drawing.Point(31, 49)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(169, 212)
        Me.GroupControl3.TabIndex = 18
        Me.GroupControl3.Text = "Products"
        '
        'cb_catalogue
        '
        Me.cb_catalogue.AutoSize = True
        Me.cb_catalogue.Location = New System.Drawing.Point(15, 27)
        Me.cb_catalogue.Name = "cb_catalogue"
        Me.cb_catalogue.Size = New System.Drawing.Size(75, 17)
        Me.cb_catalogue.TabIndex = 0
        Me.cb_catalogue.Text = "Catalogue"
        Me.cb_catalogue.UseVisualStyleBackColor = True
        '
        'cb_new_item
        '
        Me.cb_new_item.AutoSize = True
        Me.cb_new_item.Location = New System.Drawing.Point(15, 50)
        Me.cb_new_item.Name = "cb_new_item"
        Me.cb_new_item.Size = New System.Drawing.Size(72, 17)
        Me.cb_new_item.TabIndex = 2
        Me.cb_new_item.Text = "New Item"
        Me.cb_new_item.UseVisualStyleBackColor = True
        '
        'cb_import_catalogue
        '
        Me.cb_import_catalogue.AutoSize = True
        Me.cb_import_catalogue.Location = New System.Drawing.Point(15, 73)
        Me.cb_import_catalogue.Name = "cb_import_catalogue"
        Me.cb_import_catalogue.Size = New System.Drawing.Size(110, 17)
        Me.cb_import_catalogue.TabIndex = 3
        Me.cb_import_catalogue.Text = "Import Catalogue"
        Me.cb_import_catalogue.UseVisualStyleBackColor = True
        '
        'cb_export_catalogue
        '
        Me.cb_export_catalogue.AutoSize = True
        Me.cb_export_catalogue.Location = New System.Drawing.Point(15, 96)
        Me.cb_export_catalogue.Name = "cb_export_catalogue"
        Me.cb_export_catalogue.Size = New System.Drawing.Size(110, 17)
        Me.cb_export_catalogue.TabIndex = 4
        Me.cb_export_catalogue.Text = "Export Catalogue"
        Me.cb_export_catalogue.UseVisualStyleBackColor = True
        '
        'cb_stock_transfer_dispatching
        '
        Me.cb_stock_transfer_dispatching.AutoSize = True
        Me.cb_stock_transfer_dispatching.Location = New System.Drawing.Point(15, 53)
        Me.cb_stock_transfer_dispatching.Name = "cb_stock_transfer_dispatching"
        Me.cb_stock_transfer_dispatching.Size = New System.Drawing.Size(154, 17)
        Me.cb_stock_transfer_dispatching.TabIndex = 1
        Me.cb_stock_transfer_dispatching.Text = "Stock Transfer Dispatching"
        Me.cb_stock_transfer_dispatching.UseVisualStyleBackColor = True
        '
        'frm_admin_users_role
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1084, 635)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_users_role"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Access Assignment"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.GroupControl7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl7.ResumeLayout(False)
        Me.GroupControl7.PerformLayout()
        CType(Me.GroupControl6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl6.ResumeLayout(False)
        Me.GroupControl6.PerformLayout()
        CType(Me.GroupControl8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl8.ResumeLayout(False)
        Me.GroupControl8.PerformLayout()
        CType(Me.GroupControl5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl5.ResumeLayout(False)
        Me.GroupControl5.PerformLayout()
        CType(Me.GroupControl9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl9.ResumeLayout(False)
        Me.GroupControl9.PerformLayout()
        CType(Me.GroupControl4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl4.ResumeLayout(False)
        Me.GroupControl4.PerformLayout()
        CType(Me.GroupControl10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl10.ResumeLayout(False)
        Me.GroupControl10.PerformLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents acc_role As DevExpress.XtraEditors.LabelControl
    Friend WithEvents acc_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents acc_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_catalogue As CheckBox
    Friend WithEvents cb_import_catalogue As CheckBox
    Friend WithEvents cb_new_item As CheckBox
    Friend WithEvents cb_export_catalogue As CheckBox
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cb_package_mgmt As CheckBox
    Friend WithEvents cb_customers As CheckBox
    Friend WithEvents cb_create_order As CheckBox
    Friend WithEvents cb_orders As CheckBox
    Friend WithEvents GroupControl5 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_receiving_mgmt As CheckBox
    Friend WithEvents cb_delivery_logs As CheckBox
    Friend WithEvents cb_stock_management As CheckBox
    Friend WithEvents cb_stock_inventory As CheckBox
    Friend WithEvents GroupControl4 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl3 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl6 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_order_payments As CheckBox
    Friend WithEvents cb_new_cheque_payment As CheckBox
    Friend WithEvents cb_cheque_book As CheckBox
    Friend WithEvents GroupControl7 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_user_accounts As CheckBox
    Friend WithEvents cb_approvals As CheckBox
    Friend WithEvents cb_price_book As CheckBox
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_account_payables As CheckBox
    Friend WithEvents cb_generate As CheckBox
    Friend WithEvents cb_payment_vouchers As CheckBox
    Friend WithEvents cb_payment_cheques As CheckBox
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_new_purchase As CheckBox
    Friend WithEvents cb_purchase_orders As CheckBox
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_order_management As CheckBox
    Friend WithEvents cb_transaction_invoice As CheckBox
    Friend WithEvents cb_stores As CheckBox
    Friend WithEvents cb_suppliers As CheckBox
    Friend WithEvents cb_settings As CheckBox
    Friend WithEvents cb_logistics As CheckBox
    Friend WithEvents acc_username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cb_soa As CheckBox
    Friend WithEvents cb_reports As CheckBox
    Friend WithEvents cb_quotations As CheckBox
    Friend WithEvents cb_for_selluseller As CheckBox
    Friend WithEvents cb_stock_transfer_dispatching As CheckBox
End Class
