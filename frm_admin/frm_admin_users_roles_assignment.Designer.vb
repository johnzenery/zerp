Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_users_roles_assignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_users_roles_assignment))
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
        Me.cb_approvals_re = New System.Windows.Forms.CheckBox()
        Me.cb_approvals_pr = New System.Windows.Forms.CheckBox()
        Me.cb_approvals_qu = New System.Windows.Forms.CheckBox()
        Me.cb_approvals_tr = New System.Windows.Forms.CheckBox()
        Me.cb_approvals_sr = New System.Windows.Forms.CheckBox()
        Me.cb_approvals_st = New System.Windows.Forms.CheckBox()
        Me.cb_approvals_po = New System.Windows.Forms.CheckBox()
        Me.cb_registered_banks = New System.Windows.Forms.CheckBox()
        Me.cb_product_database = New System.Windows.Forms.CheckBox()
        Me.cb_price_matrix = New System.Windows.Forms.CheckBox()
        Me.cb_reports = New System.Windows.Forms.CheckBox()
        Me.cb_stores = New System.Windows.Forms.CheckBox()
        Me.cb_suppliers = New System.Windows.Forms.CheckBox()
        Me.cb_company_information = New System.Windows.Forms.CheckBox()
        Me.cb_user_accounts = New System.Windows.Forms.CheckBox()
        Me.cb_price_book = New System.Windows.Forms.CheckBox()
        Me.GroupControl6 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_soa = New System.Windows.Forms.CheckBox()
        Me.cb_order_payments = New System.Windows.Forms.CheckBox()
        Me.cb_new_cheque_payment = New System.Windows.Forms.CheckBox()
        Me.cb_cheque_book = New System.Windows.Forms.CheckBox()
        Me.GroupControl8 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_generated_payments = New System.Windows.Forms.CheckBox()
        Me.cb_account_payables = New System.Windows.Forms.CheckBox()
        Me.cb_generate_new = New System.Windows.Forms.CheckBox()
        Me.GroupControl5 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_receiving_sales_returns = New System.Windows.Forms.CheckBox()
        Me.cb_receiving_stock_returns = New System.Windows.Forms.CheckBox()
        Me.cb_generate_barcode = New System.Windows.Forms.CheckBox()
        Me.cb_receiving_stock_transfer = New System.Windows.Forms.CheckBox()
        Me.cb_receiving_supplier_delivery = New System.Windows.Forms.CheckBox()
        Me.cb_for_selluseller = New System.Windows.Forms.CheckBox()
        Me.cb_receiving_mgmt = New System.Windows.Forms.CheckBox()
        Me.cb_stock_management = New System.Windows.Forms.CheckBox()
        Me.cb_stock_inventory = New System.Windows.Forms.CheckBox()
        Me.cb_package_mgmt = New System.Windows.Forms.CheckBox()
        Me.GroupControl9 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_credit_memo = New System.Windows.Forms.CheckBox()
        Me.cb_stock_returns = New System.Windows.Forms.CheckBox()
        Me.cb_purchase_request = New System.Windows.Forms.CheckBox()
        Me.cb_new_purchase = New System.Windows.Forms.CheckBox()
        Me.cb_purchase_orders = New System.Windows.Forms.CheckBox()
        Me.cb_delivery_logs = New System.Windows.Forms.CheckBox()
        Me.GroupControl4 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_discounting_matrix = New System.Windows.Forms.CheckBox()
        Me.cb_sales_returns = New System.Windows.Forms.CheckBox()
        Me.cb_quotations = New System.Windows.Forms.CheckBox()
        Me.cb_logistics = New System.Windows.Forms.CheckBox()
        Me.cb_orders = New System.Windows.Forms.CheckBox()
        Me.cb_transaction_invoice = New System.Windows.Forms.CheckBox()
        Me.cb_create_order = New System.Windows.Forms.CheckBox()
        Me.cb_customers = New System.Windows.Forms.CheckBox()
        Me.GroupControl10 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_stock_returns_releasing = New System.Windows.Forms.CheckBox()
        Me.cb_stock_transfer_dispatching = New System.Windows.Forms.CheckBox()
        Me.cb_order_management = New System.Windows.Forms.CheckBox()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.cb_catalogue = New System.Windows.Forms.CheckBox()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
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
        Me.GroupControl2.Location = New System.Drawing.Point(14, 92)
        Me.GroupControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(285, 244)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "User Details"
        '
        'acc_username
        '
        Me.acc_username.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_username.Appearance.Options.UseFont = True
        Me.acc_username.Location = New System.Drawing.Point(139, 87)
        Me.acc_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.acc_username.Name = "acc_username"
        Me.acc_username.Size = New System.Drawing.Size(54, 21)
        Me.acc_username.TabIndex = 7
        Me.acc_username.Text = "jzenery"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(29, 114)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 21)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Name:"
        '
        'acc_id
        '
        Me.acc_id.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_id.Appearance.Options.UseFont = True
        Me.acc_id.Location = New System.Drawing.Point(139, 60)
        Me.acc_id.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.acc_id.Name = "acc_id"
        Me.acc_id.Size = New System.Drawing.Size(72, 21)
        Me.acc_id.TabIndex = 5
        Me.acc_id.Text = "00000001"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(27, 60)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(102, 21)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "Account ID:"
        '
        'acc_role
        '
        Me.acc_role.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_role.Appearance.Options.UseFont = True
        Me.acc_role.Location = New System.Drawing.Point(139, 166)
        Me.acc_role.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.acc_role.Name = "acc_role"
        Me.acc_role.Size = New System.Drawing.Size(101, 21)
        Me.acc_role.TabIndex = 3
        Me.acc_role.Text = "Administrator"
        '
        'acc_name
        '
        Me.acc_name.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.acc_name.Appearance.Options.UseFont = True
        Me.acc_name.Location = New System.Drawing.Point(139, 114)
        Me.acc_name.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.acc_name.Name = "acc_name"
        Me.acc_name.Size = New System.Drawing.Size(131, 21)
        Me.acc_name.TabIndex = 2
        Me.acc_name.Text = "John Zenery Bullo"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(29, 165)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 21)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Role:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(27, 87)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(86, 21)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Username"
        '
        'btn_save
        '
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.Location = New System.Drawing.Point(153, 343)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(146, 41)
        Me.btn_save.TabIndex = 31
        Me.btn_save.Text = "Apply"
        '
        'btn_close
        '
        Me.btn_close.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_close.Appearance.Options.UseFont = True
        Me.btn_close.Location = New System.Drawing.Point(14, 343)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(132, 41)
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
        Me.GroupControl1.Location = New System.Drawing.Point(306, 92)
        Me.GroupControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(1125, 763)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "Account Roles"
        '
        'GroupControl7
        '
        Me.GroupControl7.Controls.Add(Me.cb_approvals_re)
        Me.GroupControl7.Controls.Add(Me.cb_approvals_pr)
        Me.GroupControl7.Controls.Add(Me.cb_approvals_qu)
        Me.GroupControl7.Controls.Add(Me.cb_approvals_tr)
        Me.GroupControl7.Controls.Add(Me.cb_approvals_sr)
        Me.GroupControl7.Controls.Add(Me.cb_approvals_st)
        Me.GroupControl7.Controls.Add(Me.cb_approvals_po)
        Me.GroupControl7.Controls.Add(Me.cb_registered_banks)
        Me.GroupControl7.Controls.Add(Me.cb_product_database)
        Me.GroupControl7.Controls.Add(Me.cb_price_matrix)
        Me.GroupControl7.Controls.Add(Me.cb_reports)
        Me.GroupControl7.Controls.Add(Me.cb_stores)
        Me.GroupControl7.Controls.Add(Me.cb_suppliers)
        Me.GroupControl7.Controls.Add(Me.cb_company_information)
        Me.GroupControl7.Controls.Add(Me.cb_user_accounts)
        Me.GroupControl7.Controls.Add(Me.cb_price_book)
        Me.GroupControl7.Location = New System.Drawing.Point(687, 425)
        Me.GroupControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl7.Name = "GroupControl7"
        Me.GroupControl7.Size = New System.Drawing.Size(432, 332)
        Me.GroupControl7.TabIndex = 25
        Me.GroupControl7.Text = "Administration"
        '
        'cb_approvals_re
        '
        Me.cb_approvals_re.AutoSize = True
        Me.cb_approvals_re.Location = New System.Drawing.Point(27, 209)
        Me.cb_approvals_re.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_re.Name = "cb_approvals_re"
        Me.cb_approvals_re.Size = New System.Drawing.Size(179, 20)
        Me.cb_approvals_re.TabIndex = 29
        Me.cb_approvals_re.Text = "Approvals - Reconcilations"
        Me.cb_approvals_re.UseVisualStyleBackColor = True
        '
        'cb_approvals_pr
        '
        Me.cb_approvals_pr.AutoSize = True
        Me.cb_approvals_pr.Location = New System.Drawing.Point(27, 181)
        Me.cb_approvals_pr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_pr.Name = "cb_approvals_pr"
        Me.cb_approvals_pr.Size = New System.Drawing.Size(147, 20)
        Me.cb_approvals_pr.TabIndex = 28
        Me.cb_approvals_pr.Text = "Approvals - Products"
        Me.cb_approvals_pr.UseVisualStyleBackColor = True
        '
        'cb_approvals_qu
        '
        Me.cb_approvals_qu.AutoSize = True
        Me.cb_approvals_qu.Location = New System.Drawing.Point(27, 153)
        Me.cb_approvals_qu.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_qu.Name = "cb_approvals_qu"
        Me.cb_approvals_qu.Size = New System.Drawing.Size(153, 20)
        Me.cb_approvals_qu.TabIndex = 27
        Me.cb_approvals_qu.Text = "Approvals - Quotation"
        Me.cb_approvals_qu.UseVisualStyleBackColor = True
        '
        'cb_approvals_tr
        '
        Me.cb_approvals_tr.AutoSize = True
        Me.cb_approvals_tr.Location = New System.Drawing.Point(27, 124)
        Me.cb_approvals_tr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_tr.Name = "cb_approvals_tr"
        Me.cb_approvals_tr.Size = New System.Drawing.Size(183, 20)
        Me.cb_approvals_tr.TabIndex = 26
        Me.cb_approvals_tr.Text = "Approvals - Trans. Reports"
        Me.cb_approvals_tr.UseVisualStyleBackColor = True
        '
        'cb_approvals_sr
        '
        Me.cb_approvals_sr.AutoSize = True
        Me.cb_approvals_sr.Location = New System.Drawing.Point(27, 96)
        Me.cb_approvals_sr.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_sr.Name = "cb_approvals_sr"
        Me.cb_approvals_sr.Size = New System.Drawing.Size(177, 20)
        Me.cb_approvals_sr.TabIndex = 25
        Me.cb_approvals_sr.Text = "Approvals - Sales Returns"
        Me.cb_approvals_sr.UseVisualStyleBackColor = True
        '
        'cb_approvals_st
        '
        Me.cb_approvals_st.AutoSize = True
        Me.cb_approvals_st.Location = New System.Drawing.Point(27, 68)
        Me.cb_approvals_st.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_st.Name = "cb_approvals_st"
        Me.cb_approvals_st.Size = New System.Drawing.Size(182, 20)
        Me.cb_approvals_st.TabIndex = 24
        Me.cb_approvals_st.Text = "Approvals - Stock Transfer"
        Me.cb_approvals_st.UseVisualStyleBackColor = True
        '
        'cb_approvals_po
        '
        Me.cb_approvals_po.AutoSize = True
        Me.cb_approvals_po.Location = New System.Drawing.Point(27, 39)
        Me.cb_approvals_po.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_approvals_po.Name = "cb_approvals_po"
        Me.cb_approvals_po.Size = New System.Drawing.Size(193, 20)
        Me.cb_approvals_po.TabIndex = 23
        Me.cb_approvals_po.Text = "Approvals - Purchase Orders"
        Me.cb_approvals_po.UseVisualStyleBackColor = True
        '
        'cb_registered_banks
        '
        Me.cb_registered_banks.AutoSize = True
        Me.cb_registered_banks.Location = New System.Drawing.Point(231, 153)
        Me.cb_registered_banks.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_registered_banks.Name = "cb_registered_banks"
        Me.cb_registered_banks.Size = New System.Drawing.Size(127, 20)
        Me.cb_registered_banks.TabIndex = 22
        Me.cb_registered_banks.Text = "Registered Banks"
        Me.cb_registered_banks.UseVisualStyleBackColor = True
        '
        'cb_product_database
        '
        Me.cb_product_database.AutoSize = True
        Me.cb_product_database.Location = New System.Drawing.Point(232, 68)
        Me.cb_product_database.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_product_database.Name = "cb_product_database"
        Me.cb_product_database.Size = New System.Drawing.Size(129, 20)
        Me.cb_product_database.TabIndex = 21
        Me.cb_product_database.Text = "Product Database"
        Me.cb_product_database.UseVisualStyleBackColor = True
        '
        'cb_price_matrix
        '
        Me.cb_price_matrix.AutoSize = True
        Me.cb_price_matrix.Location = New System.Drawing.Point(232, 124)
        Me.cb_price_matrix.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_price_matrix.Name = "cb_price_matrix"
        Me.cb_price_matrix.Size = New System.Drawing.Size(96, 20)
        Me.cb_price_matrix.TabIndex = 20
        Me.cb_price_matrix.Text = "Price Matrix"
        Me.cb_price_matrix.UseVisualStyleBackColor = True
        '
        'cb_reports
        '
        Me.cb_reports.AutoSize = True
        Me.cb_reports.Location = New System.Drawing.Point(231, 39)
        Me.cb_reports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_reports.Name = "cb_reports"
        Me.cb_reports.Size = New System.Drawing.Size(141, 20)
        Me.cb_reports.TabIndex = 19
        Me.cb_reports.Text = "Statistics && Reports"
        Me.cb_reports.UseVisualStyleBackColor = True
        '
        'cb_stores
        '
        Me.cb_stores.AutoSize = True
        Me.cb_stores.Location = New System.Drawing.Point(231, 209)
        Me.cb_stores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_stores.Name = "cb_stores"
        Me.cb_stores.Size = New System.Drawing.Size(94, 20)
        Me.cb_stores.TabIndex = 16
        Me.cb_stores.Text = "Warehouse"
        Me.cb_stores.UseVisualStyleBackColor = True
        '
        'cb_suppliers
        '
        Me.cb_suppliers.AutoSize = True
        Me.cb_suppliers.Location = New System.Drawing.Point(232, 238)
        Me.cb_suppliers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_suppliers.Name = "cb_suppliers"
        Me.cb_suppliers.Size = New System.Drawing.Size(82, 20)
        Me.cb_suppliers.TabIndex = 17
        Me.cb_suppliers.Text = "Suppliers"
        Me.cb_suppliers.UseVisualStyleBackColor = True
        '
        'cb_company_information
        '
        Me.cb_company_information.AutoSize = True
        Me.cb_company_information.Location = New System.Drawing.Point(231, 266)
        Me.cb_company_information.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_company_information.Name = "cb_company_information"
        Me.cb_company_information.Size = New System.Drawing.Size(152, 20)
        Me.cb_company_information.TabIndex = 18
        Me.cb_company_information.Text = "Company Information"
        Me.cb_company_information.UseVisualStyleBackColor = True
        '
        'cb_user_accounts
        '
        Me.cb_user_accounts.AutoSize = True
        Me.cb_user_accounts.Location = New System.Drawing.Point(232, 181)
        Me.cb_user_accounts.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_user_accounts.Name = "cb_user_accounts"
        Me.cb_user_accounts.Size = New System.Drawing.Size(133, 20)
        Me.cb_user_accounts.TabIndex = 13
        Me.cb_user_accounts.Text = "User Management"
        Me.cb_user_accounts.UseVisualStyleBackColor = True
        '
        'cb_price_book
        '
        Me.cb_price_book.AutoSize = True
        Me.cb_price_book.Location = New System.Drawing.Point(232, 96)
        Me.cb_price_book.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_price_book.Name = "cb_price_book"
        Me.cb_price_book.Size = New System.Drawing.Size(88, 20)
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
        Me.GroupControl6.Location = New System.Drawing.Point(687, 60)
        Me.GroupControl6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl6.Name = "GroupControl6"
        Me.GroupControl6.Size = New System.Drawing.Size(197, 357)
        Me.GroupControl6.TabIndex = 21
        Me.GroupControl6.Text = "Collections"
        '
        'cb_soa
        '
        Me.cb_soa.AutoSize = True
        Me.cb_soa.Location = New System.Drawing.Point(27, 124)
        Me.cb_soa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_soa.Name = "cb_soa"
        Me.cb_soa.Size = New System.Drawing.Size(152, 20)
        Me.cb_soa.TabIndex = 16
        Me.cb_soa.Text = "Statement of Account"
        Me.cb_soa.UseVisualStyleBackColor = True
        '
        'cb_order_payments
        '
        Me.cb_order_payments.AutoSize = True
        Me.cb_order_payments.Location = New System.Drawing.Point(27, 39)
        Me.cb_order_payments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_order_payments.Name = "cb_order_payments"
        Me.cb_order_payments.Size = New System.Drawing.Size(121, 20)
        Me.cb_order_payments.TabIndex = 13
        Me.cb_order_payments.Text = "Order Payments"
        Me.cb_order_payments.UseVisualStyleBackColor = True
        '
        'cb_new_cheque_payment
        '
        Me.cb_new_cheque_payment.AutoSize = True
        Me.cb_new_cheque_payment.Location = New System.Drawing.Point(27, 68)
        Me.cb_new_cheque_payment.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_new_cheque_payment.Name = "cb_new_cheque_payment"
        Me.cb_new_cheque_payment.Size = New System.Drawing.Size(154, 20)
        Me.cb_new_cheque_payment.TabIndex = 14
        Me.cb_new_cheque_payment.Text = "New Cheque Payment"
        Me.cb_new_cheque_payment.UseVisualStyleBackColor = True
        '
        'cb_cheque_book
        '
        Me.cb_cheque_book.AutoSize = True
        Me.cb_cheque_book.Location = New System.Drawing.Point(27, 96)
        Me.cb_cheque_book.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_cheque_book.Name = "cb_cheque_book"
        Me.cb_cheque_book.Size = New System.Drawing.Size(103, 20)
        Me.cb_cheque_book.TabIndex = 15
        Me.cb_cheque_book.Text = "Cheque Book"
        Me.cb_cheque_book.UseVisualStyleBackColor = True
        '
        'GroupControl8
        '
        Me.GroupControl8.Controls.Add(Me.cb_generated_payments)
        Me.GroupControl8.Controls.Add(Me.cb_account_payables)
        Me.GroupControl8.Controls.Add(Me.cb_generate_new)
        Me.GroupControl8.Location = New System.Drawing.Point(483, 425)
        Me.GroupControl8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl8.Name = "GroupControl8"
        Me.GroupControl8.Size = New System.Drawing.Size(197, 332)
        Me.GroupControl8.TabIndex = 24
        Me.GroupControl8.Text = "Accounting"
        '
        'cb_generated_payments
        '
        Me.cb_generated_payments.AutoSize = True
        Me.cb_generated_payments.Location = New System.Drawing.Point(27, 110)
        Me.cb_generated_payments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_generated_payments.Name = "cb_generated_payments"
        Me.cb_generated_payments.Size = New System.Drawing.Size(147, 20)
        Me.cb_generated_payments.TabIndex = 17
        Me.cb_generated_payments.Text = "Generated Payments"
        Me.cb_generated_payments.UseVisualStyleBackColor = True
        '
        'cb_account_payables
        '
        Me.cb_account_payables.AutoSize = True
        Me.cb_account_payables.Location = New System.Drawing.Point(27, 39)
        Me.cb_account_payables.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_account_payables.Name = "cb_account_payables"
        Me.cb_account_payables.Size = New System.Drawing.Size(128, 20)
        Me.cb_account_payables.TabIndex = 13
        Me.cb_account_payables.Text = "Account Payables"
        Me.cb_account_payables.UseVisualStyleBackColor = True
        '
        'cb_generate_new
        '
        Me.cb_generate_new.AutoEllipsis = True
        Me.cb_generate_new.Location = New System.Drawing.Point(27, 65)
        Me.cb_generate_new.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_generate_new.Name = "cb_generate_new"
        Me.cb_generate_new.Size = New System.Drawing.Size(160, 37)
        Me.cb_generate_new.TabIndex = 14
        Me.cb_generate_new.Text = "Generate Payment && Voucher"
        Me.cb_generate_new.UseVisualStyleBackColor = True
        '
        'GroupControl5
        '
        Me.GroupControl5.Controls.Add(Me.cb_receiving_sales_returns)
        Me.GroupControl5.Controls.Add(Me.cb_receiving_stock_returns)
        Me.GroupControl5.Controls.Add(Me.cb_generate_barcode)
        Me.GroupControl5.Controls.Add(Me.cb_receiving_stock_transfer)
        Me.GroupControl5.Controls.Add(Me.cb_receiving_supplier_delivery)
        Me.GroupControl5.Controls.Add(Me.cb_for_selluseller)
        Me.GroupControl5.Controls.Add(Me.cb_receiving_mgmt)
        Me.GroupControl5.Controls.Add(Me.cb_stock_management)
        Me.GroupControl5.Controls.Add(Me.cb_stock_inventory)
        Me.GroupControl5.Controls.Add(Me.cb_package_mgmt)
        Me.GroupControl5.Location = New System.Drawing.Point(483, 60)
        Me.GroupControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl5.Name = "GroupControl5"
        Me.GroupControl5.Size = New System.Drawing.Size(197, 357)
        Me.GroupControl5.TabIndex = 20
        Me.GroupControl5.Text = "Warehouse"
        '
        'cb_receiving_sales_returns
        '
        Me.cb_receiving_sales_returns.AutoSize = True
        Me.cb_receiving_sales_returns.Location = New System.Drawing.Point(48, 124)
        Me.cb_receiving_sales_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_receiving_sales_returns.Name = "cb_receiving_sales_returns"
        Me.cb_receiving_sales_returns.Size = New System.Drawing.Size(108, 20)
        Me.cb_receiving_sales_returns.TabIndex = 23
        Me.cb_receiving_sales_returns.Text = "Sales Returns"
        Me.cb_receiving_sales_returns.UseVisualStyleBackColor = True
        '
        'cb_receiving_stock_returns
        '
        Me.cb_receiving_stock_returns.AutoSize = True
        Me.cb_receiving_stock_returns.Location = New System.Drawing.Point(48, 209)
        Me.cb_receiving_stock_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_receiving_stock_returns.Name = "cb_receiving_stock_returns"
        Me.cb_receiving_stock_returns.Size = New System.Drawing.Size(108, 20)
        Me.cb_receiving_stock_returns.TabIndex = 22
        Me.cb_receiving_stock_returns.Text = "Stock Returns"
        Me.cb_receiving_stock_returns.UseVisualStyleBackColor = True
        '
        'cb_generate_barcode
        '
        Me.cb_generate_barcode.AutoSize = True
        Me.cb_generate_barcode.Location = New System.Drawing.Point(27, 294)
        Me.cb_generate_barcode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_generate_barcode.Name = "cb_generate_barcode"
        Me.cb_generate_barcode.Size = New System.Drawing.Size(131, 20)
        Me.cb_generate_barcode.TabIndex = 21
        Me.cb_generate_barcode.Text = "Generate Barcode"
        Me.cb_generate_barcode.UseVisualStyleBackColor = True
        '
        'cb_receiving_stock_transfer
        '
        Me.cb_receiving_stock_transfer.AutoSize = True
        Me.cb_receiving_stock_transfer.Location = New System.Drawing.Point(48, 181)
        Me.cb_receiving_stock_transfer.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_receiving_stock_transfer.Name = "cb_receiving_stock_transfer"
        Me.cb_receiving_stock_transfer.Size = New System.Drawing.Size(113, 20)
        Me.cb_receiving_stock_transfer.TabIndex = 20
        Me.cb_receiving_stock_transfer.Text = "Stock Transfer"
        Me.cb_receiving_stock_transfer.UseVisualStyleBackColor = True
        '
        'cb_receiving_supplier_delivery
        '
        Me.cb_receiving_supplier_delivery.AutoSize = True
        Me.cb_receiving_supplier_delivery.Location = New System.Drawing.Point(48, 153)
        Me.cb_receiving_supplier_delivery.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_receiving_supplier_delivery.Name = "cb_receiving_supplier_delivery"
        Me.cb_receiving_supplier_delivery.Size = New System.Drawing.Size(125, 20)
        Me.cb_receiving_supplier_delivery.TabIndex = 19
        Me.cb_receiving_supplier_delivery.Text = "Supplier Delivery"
        Me.cb_receiving_supplier_delivery.UseVisualStyleBackColor = True
        '
        'cb_for_selluseller
        '
        Me.cb_for_selluseller.AutoSize = True
        Me.cb_for_selluseller.Location = New System.Drawing.Point(27, 266)
        Me.cb_for_selluseller.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_for_selluseller.Name = "cb_for_selluseller"
        Me.cb_for_selluseller.Size = New System.Drawing.Size(148, 20)
        Me.cb_for_selluseller.TabIndex = 18
        Me.cb_for_selluseller.Text = "New Stock Deliveries"
        Me.cb_for_selluseller.UseVisualStyleBackColor = True
        '
        'cb_receiving_mgmt
        '
        Me.cb_receiving_mgmt.AutoSize = True
        Me.cb_receiving_mgmt.Location = New System.Drawing.Point(27, 96)
        Me.cb_receiving_mgmt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_receiving_mgmt.Name = "cb_receiving_mgmt"
        Me.cb_receiving_mgmt.Size = New System.Drawing.Size(161, 20)
        Me.cb_receiving_mgmt.TabIndex = 13
        Me.cb_receiving_mgmt.Text = "Receiving Management"
        Me.cb_receiving_mgmt.UseVisualStyleBackColor = True
        '
        'cb_stock_management
        '
        Me.cb_stock_management.AutoSize = True
        Me.cb_stock_management.Location = New System.Drawing.Point(27, 39)
        Me.cb_stock_management.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_stock_management.Name = "cb_stock_management"
        Me.cb_stock_management.Size = New System.Drawing.Size(138, 20)
        Me.cb_stock_management.TabIndex = 15
        Me.cb_stock_management.Text = "Stock Management"
        Me.cb_stock_management.UseVisualStyleBackColor = True
        '
        'cb_stock_inventory
        '
        Me.cb_stock_inventory.AutoSize = True
        Me.cb_stock_inventory.Location = New System.Drawing.Point(27, 238)
        Me.cb_stock_inventory.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_stock_inventory.Name = "cb_stock_inventory"
        Me.cb_stock_inventory.Size = New System.Drawing.Size(82, 20)
        Me.cb_stock_inventory.TabIndex = 16
        Me.cb_stock_inventory.Text = "Inventory"
        Me.cb_stock_inventory.UseVisualStyleBackColor = True
        '
        'cb_package_mgmt
        '
        Me.cb_package_mgmt.AutoSize = True
        Me.cb_package_mgmt.Location = New System.Drawing.Point(27, 68)
        Me.cb_package_mgmt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_package_mgmt.Name = "cb_package_mgmt"
        Me.cb_package_mgmt.Size = New System.Drawing.Size(154, 20)
        Me.cb_package_mgmt.TabIndex = 10
        Me.cb_package_mgmt.Text = "Package Management"
        Me.cb_package_mgmt.UseVisualStyleBackColor = True
        '
        'GroupControl9
        '
        Me.GroupControl9.Controls.Add(Me.cb_credit_memo)
        Me.GroupControl9.Controls.Add(Me.cb_stock_returns)
        Me.GroupControl9.Controls.Add(Me.cb_purchase_request)
        Me.GroupControl9.Controls.Add(Me.cb_new_purchase)
        Me.GroupControl9.Controls.Add(Me.cb_purchase_orders)
        Me.GroupControl9.Controls.Add(Me.cb_delivery_logs)
        Me.GroupControl9.Location = New System.Drawing.Point(279, 425)
        Me.GroupControl9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl9.Name = "GroupControl9"
        Me.GroupControl9.Size = New System.Drawing.Size(197, 332)
        Me.GroupControl9.TabIndex = 23
        Me.GroupControl9.Text = "Purchasing"
        '
        'cb_credit_memo
        '
        Me.cb_credit_memo.AutoSize = True
        Me.cb_credit_memo.Location = New System.Drawing.Point(28, 124)
        Me.cb_credit_memo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_credit_memo.Name = "cb_credit_memo"
        Me.cb_credit_memo.Size = New System.Drawing.Size(102, 20)
        Me.cb_credit_memo.TabIndex = 17
        Me.cb_credit_memo.Text = "Credit Memo"
        Me.cb_credit_memo.UseVisualStyleBackColor = True
        '
        'cb_stock_returns
        '
        Me.cb_stock_returns.AutoSize = True
        Me.cb_stock_returns.Location = New System.Drawing.Point(27, 96)
        Me.cb_stock_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_stock_returns.Name = "cb_stock_returns"
        Me.cb_stock_returns.Size = New System.Drawing.Size(108, 20)
        Me.cb_stock_returns.TabIndex = 16
        Me.cb_stock_returns.Text = "Stock Returns"
        Me.cb_stock_returns.UseVisualStyleBackColor = True
        '
        'cb_purchase_request
        '
        Me.cb_purchase_request.AutoSize = True
        Me.cb_purchase_request.Location = New System.Drawing.Point(27, 181)
        Me.cb_purchase_request.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_purchase_request.Name = "cb_purchase_request"
        Me.cb_purchase_request.Size = New System.Drawing.Size(131, 20)
        Me.cb_purchase_request.TabIndex = 15
        Me.cb_purchase_request.Text = "Purchase Request"
        Me.cb_purchase_request.UseVisualStyleBackColor = True
        '
        'cb_new_purchase
        '
        Me.cb_new_purchase.AutoSize = True
        Me.cb_new_purchase.Location = New System.Drawing.Point(27, 39)
        Me.cb_new_purchase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_new_purchase.Name = "cb_new_purchase"
        Me.cb_new_purchase.Size = New System.Drawing.Size(110, 20)
        Me.cb_new_purchase.TabIndex = 7
        Me.cb_new_purchase.Text = "New Purchase"
        Me.cb_new_purchase.UseVisualStyleBackColor = True
        '
        'cb_purchase_orders
        '
        Me.cb_purchase_orders.AutoSize = True
        Me.cb_purchase_orders.Location = New System.Drawing.Point(27, 68)
        Me.cb_purchase_orders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_purchase_orders.Name = "cb_purchase_orders"
        Me.cb_purchase_orders.Size = New System.Drawing.Size(124, 20)
        Me.cb_purchase_orders.TabIndex = 8
        Me.cb_purchase_orders.Text = "Purchase Orders"
        Me.cb_purchase_orders.UseVisualStyleBackColor = True
        '
        'cb_delivery_logs
        '
        Me.cb_delivery_logs.AutoSize = True
        Me.cb_delivery_logs.Location = New System.Drawing.Point(27, 153)
        Me.cb_delivery_logs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_delivery_logs.Name = "cb_delivery_logs"
        Me.cb_delivery_logs.Size = New System.Drawing.Size(104, 20)
        Me.cb_delivery_logs.TabIndex = 14
        Me.cb_delivery_logs.Text = "Delivery Logs"
        Me.cb_delivery_logs.UseVisualStyleBackColor = True
        '
        'GroupControl4
        '
        Me.GroupControl4.Controls.Add(Me.cb_discounting_matrix)
        Me.GroupControl4.Controls.Add(Me.cb_sales_returns)
        Me.GroupControl4.Controls.Add(Me.cb_quotations)
        Me.GroupControl4.Controls.Add(Me.cb_logistics)
        Me.GroupControl4.Controls.Add(Me.cb_orders)
        Me.GroupControl4.Controls.Add(Me.cb_transaction_invoice)
        Me.GroupControl4.Controls.Add(Me.cb_create_order)
        Me.GroupControl4.Controls.Add(Me.cb_customers)
        Me.GroupControl4.Location = New System.Drawing.Point(279, 60)
        Me.GroupControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl4.Name = "GroupControl4"
        Me.GroupControl4.Size = New System.Drawing.Size(197, 357)
        Me.GroupControl4.TabIndex = 19
        Me.GroupControl4.Text = "Sales"
        '
        'cb_discounting_matrix
        '
        Me.cb_discounting_matrix.AutoSize = True
        Me.cb_discounting_matrix.Location = New System.Drawing.Point(27, 209)
        Me.cb_discounting_matrix.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_discounting_matrix.Name = "cb_discounting_matrix"
        Me.cb_discounting_matrix.Size = New System.Drawing.Size(133, 20)
        Me.cb_discounting_matrix.TabIndex = 14
        Me.cb_discounting_matrix.Text = "Discounting Matrix"
        Me.cb_discounting_matrix.UseVisualStyleBackColor = True
        '
        'cb_sales_returns
        '
        Me.cb_sales_returns.AutoSize = True
        Me.cb_sales_returns.Location = New System.Drawing.Point(27, 124)
        Me.cb_sales_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_sales_returns.Name = "cb_sales_returns"
        Me.cb_sales_returns.Size = New System.Drawing.Size(108, 20)
        Me.cb_sales_returns.TabIndex = 13
        Me.cb_sales_returns.Text = "Sales Returns"
        Me.cb_sales_returns.UseVisualStyleBackColor = True
        '
        'cb_quotations
        '
        Me.cb_quotations.AutoSize = True
        Me.cb_quotations.Location = New System.Drawing.Point(27, 96)
        Me.cb_quotations.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_quotations.Name = "cb_quotations"
        Me.cb_quotations.Size = New System.Drawing.Size(90, 20)
        Me.cb_quotations.TabIndex = 12
        Me.cb_quotations.Text = "Quotations"
        Me.cb_quotations.UseVisualStyleBackColor = True
        '
        'cb_logistics
        '
        Me.cb_logistics.AutoSize = True
        Me.cb_logistics.Location = New System.Drawing.Point(27, 238)
        Me.cb_logistics.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_logistics.Name = "cb_logistics"
        Me.cb_logistics.Size = New System.Drawing.Size(77, 20)
        Me.cb_logistics.TabIndex = 11
        Me.cb_logistics.Text = "Logistics"
        Me.cb_logistics.UseVisualStyleBackColor = True
        '
        'cb_orders
        '
        Me.cb_orders.AutoSize = True
        Me.cb_orders.Location = New System.Drawing.Point(27, 68)
        Me.cb_orders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_orders.Name = "cb_orders"
        Me.cb_orders.Size = New System.Drawing.Size(103, 20)
        Me.cb_orders.TabIndex = 7
        Me.cb_orders.Text = "Sales Orders"
        Me.cb_orders.UseVisualStyleBackColor = True
        '
        'cb_transaction_invoice
        '
        Me.cb_transaction_invoice.AutoSize = True
        Me.cb_transaction_invoice.Location = New System.Drawing.Point(27, 181)
        Me.cb_transaction_invoice.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_transaction_invoice.Name = "cb_transaction_invoice"
        Me.cb_transaction_invoice.Size = New System.Drawing.Size(140, 20)
        Me.cb_transaction_invoice.TabIndex = 1
        Me.cb_transaction_invoice.Text = "Transaction Invoice"
        Me.cb_transaction_invoice.UseVisualStyleBackColor = True
        '
        'cb_create_order
        '
        Me.cb_create_order.AutoSize = True
        Me.cb_create_order.Location = New System.Drawing.Point(27, 39)
        Me.cb_create_order.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_create_order.Name = "cb_create_order"
        Me.cb_create_order.Size = New System.Drawing.Size(91, 20)
        Me.cb_create_order.TabIndex = 8
        Me.cb_create_order.Text = "New Order"
        Me.cb_create_order.UseVisualStyleBackColor = True
        '
        'cb_customers
        '
        Me.cb_customers.AutoSize = True
        Me.cb_customers.Location = New System.Drawing.Point(27, 153)
        Me.cb_customers.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_customers.Name = "cb_customers"
        Me.cb_customers.Size = New System.Drawing.Size(90, 20)
        Me.cb_customers.TabIndex = 9
        Me.cb_customers.Text = "Customers"
        Me.cb_customers.UseVisualStyleBackColor = True
        '
        'GroupControl10
        '
        Me.GroupControl10.Controls.Add(Me.cb_stock_returns_releasing)
        Me.GroupControl10.Controls.Add(Me.cb_stock_transfer_dispatching)
        Me.GroupControl10.Controls.Add(Me.cb_order_management)
        Me.GroupControl10.Location = New System.Drawing.Point(75, 425)
        Me.GroupControl10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl10.Name = "GroupControl10"
        Me.GroupControl10.Size = New System.Drawing.Size(197, 332)
        Me.GroupControl10.TabIndex = 22
        Me.GroupControl10.Text = "Logistics"
        '
        'cb_stock_returns_releasing
        '
        Me.cb_stock_returns_releasing.AutoSize = True
        Me.cb_stock_returns_releasing.Location = New System.Drawing.Point(18, 96)
        Me.cb_stock_returns_releasing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_stock_returns_releasing.Name = "cb_stock_returns_releasing"
        Me.cb_stock_returns_releasing.Size = New System.Drawing.Size(167, 20)
        Me.cb_stock_returns_releasing.TabIndex = 2
        Me.cb_stock_returns_releasing.Text = "Stock Returns Releasing"
        Me.cb_stock_returns_releasing.UseVisualStyleBackColor = True
        '
        'cb_stock_transfer_dispatching
        '
        Me.cb_stock_transfer_dispatching.AutoSize = True
        Me.cb_stock_transfer_dispatching.Location = New System.Drawing.Point(18, 68)
        Me.cb_stock_transfer_dispatching.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_stock_transfer_dispatching.Name = "cb_stock_transfer_dispatching"
        Me.cb_stock_transfer_dispatching.Size = New System.Drawing.Size(162, 20)
        Me.cb_stock_transfer_dispatching.TabIndex = 1
        Me.cb_stock_transfer_dispatching.Text = "Stock Transfer Dispatc."
        Me.cb_stock_transfer_dispatching.UseVisualStyleBackColor = True
        '
        'cb_order_management
        '
        Me.cb_order_management.AutoSize = True
        Me.cb_order_management.Location = New System.Drawing.Point(18, 39)
        Me.cb_order_management.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_order_management.Name = "cb_order_management"
        Me.cb_order_management.Size = New System.Drawing.Size(161, 20)
        Me.cb_order_management.TabIndex = 0
        Me.cb_order_management.Text = "Order Releasing Mgmt."
        Me.cb_order_management.UseVisualStyleBackColor = True
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.cb_catalogue)
        Me.GroupControl3.Location = New System.Drawing.Point(75, 60)
        Me.GroupControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(197, 357)
        Me.GroupControl3.TabIndex = 18
        Me.GroupControl3.Text = "Products"
        '
        'cb_catalogue
        '
        Me.cb_catalogue.AutoSize = True
        Me.cb_catalogue.Location = New System.Drawing.Point(18, 39)
        Me.cb_catalogue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_catalogue.Name = "cb_catalogue"
        Me.cb_catalogue.Size = New System.Drawing.Size(86, 20)
        Me.cb_catalogue.TabIndex = 0
        Me.cb_catalogue.Text = "Catalogue"
        Me.cb_catalogue.UseVisualStyleBackColor = True
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(242, 38)
        Me.LabelControl4.TabIndex = 33
        Me.LabelControl4.Text = "Set Role Access"
        '
        'frm_admin_users_roles_assignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1444, 870)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.LabelControl4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IconOptions.Icon = CType(resources.GetObject("frm_admin_users_roles_assignment.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_users_roles_assignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Role Access"
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
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents acc_role As DevExpress.XtraEditors.LabelControl
    Friend WithEvents acc_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents acc_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_catalogue As CheckBox
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
    Friend WithEvents cb_price_book As CheckBox
    Friend WithEvents GroupControl8 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_account_payables As CheckBox
    Friend WithEvents cb_generate_new As CheckBox
    Friend WithEvents GroupControl9 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_new_purchase As CheckBox
    Friend WithEvents cb_purchase_orders As CheckBox
    Friend WithEvents GroupControl10 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_order_management As CheckBox
    Friend WithEvents cb_transaction_invoice As CheckBox
    Friend WithEvents cb_stores As CheckBox
    Friend WithEvents cb_suppliers As CheckBox
    Friend WithEvents cb_company_information As CheckBox
    Friend WithEvents cb_logistics As CheckBox
    Friend WithEvents acc_username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_soa As CheckBox
    Friend WithEvents cb_reports As CheckBox
    Friend WithEvents cb_quotations As CheckBox
    Friend WithEvents cb_for_selluseller As CheckBox
    Friend WithEvents cb_stock_transfer_dispatching As CheckBox
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents cb_receiving_stock_transfer As CheckBox
    Friend WithEvents cb_receiving_supplier_delivery As CheckBox
    Friend WithEvents cb_sales_returns As CheckBox
    Friend WithEvents cb_price_matrix As CheckBox
    Friend WithEvents cb_product_database As CheckBox
    Friend WithEvents cb_generated_payments As CheckBox
    Friend WithEvents cb_registered_banks As CheckBox
    Friend WithEvents cb_purchase_request As CheckBox
    Friend WithEvents cb_stock_returns As CheckBox
    Friend WithEvents cb_generate_barcode As CheckBox
    Friend WithEvents cb_approvals_re As CheckBox
    Friend WithEvents cb_approvals_pr As CheckBox
    Friend WithEvents cb_approvals_qu As CheckBox
    Friend WithEvents cb_approvals_tr As CheckBox
    Friend WithEvents cb_approvals_sr As CheckBox
    Friend WithEvents cb_approvals_st As CheckBox
    Friend WithEvents cb_approvals_po As CheckBox
    Friend WithEvents cb_discounting_matrix As CheckBox
    Friend WithEvents cb_credit_memo As CheckBox
    Friend WithEvents cb_receiving_stock_returns As CheckBox
    Friend WithEvents cb_receiving_sales_returns As CheckBox
    Friend WithEvents cb_stock_returns_releasing As CheckBox
End Class
