Imports DevExpress.Data.Mask
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_view_order
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_view_order))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_status = New Guna.UI.WinForms.GunaLabel()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_amounttopay = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_paid_amount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_delivery_fee = New System.Windows.Forms.LinkLabel()
        Me.txt_delivery_fee = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_po_ref = New DevExpress.XtraEditors.TextEdit()
        Me.gb_payment = New DevExpress.XtraEditors.GroupControl()
        Me.rb_epay = New System.Windows.Forms.RadioButton()
        Me.rb_cheque = New System.Windows.Forms.RadioButton()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_terms = New System.Windows.Forms.RadioButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_customer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.cb_same_billing = New System.Windows.Forms.CheckBox()
        Me.txt_trucking = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_trucking = New DevExpress.XtraEditors.LabelControl()
        Me.txt_shipping = New DevExpress.XtraEditors.TextEdit()
        Me.gb_shipping = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.rb_deliver = New System.Windows.Forms.RadioButton()
        Me.rb_pickup = New System.Windows.Forms.RadioButton()
        Me.txt_billing = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_payment_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_pack = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_priv_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pub_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_order = New System.Windows.Forms.DataGridView()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grid_remaining = New System.Windows.Forms.DataGridView()
        Me.col_other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_on_hold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.print_contextmenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DraftInvoiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PackingSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cb_vatable = New System.Windows.Forms.CheckBox()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.cb_tax_applied = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_balance = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_refund = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_epayment = New DevExpress.XtraEditors.SimpleButton()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_invoice = New DevExpress.XtraEditors.LabelControl()
        Me.txt_invoice = New DevExpress.XtraEditors.TextEdit()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_terms = New System.Windows.Forms.NumericUpDown()
        Me.txt_sales_agent = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_sales_agent = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_terms = New DevExpress.XtraEditors.LabelControl()
        Me.txt_quote_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact_person = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_credits_available = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_account_type = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_cid = New DevExpress.XtraEditors.TextEdit()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btn_modify = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_unserved = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_cant_edit = New System.Windows.Forms.Label()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_po_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_payment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_payment.SuspendLayout()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trucking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_shipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gb_shipping, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gb_shipping.SuspendLayout()
        CType(Me.txt_billing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.print_contextmenu.SuspendLayout()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.txt_invoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.txt_terms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sales_agent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quote_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_credits_available.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_account_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_cid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.lbl_status)
        Me.GunaPanel2.Controls.Add(Me.lbl_title)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1409, 78)
        Me.GunaPanel2.TabIndex = 13
        '
        'lbl_status
        '
        Me.lbl_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_status.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_status.ForeColor = System.Drawing.Color.Gray
        Me.lbl_status.Location = New System.Drawing.Point(960, 26)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(425, 31)
        Me.lbl_status.TabIndex = 2
        Me.lbl_status.Text = "Status"
        Me.lbl_status.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 26)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(105, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Order #"
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(32, 67)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl16.TabIndex = 106
        Me.LabelControl16.Text = "Amount to Pay"
        '
        'lbl_amounttopay
        '
        Me.lbl_amounttopay.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_amounttopay.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_amounttopay.Appearance.Options.UseFont = True
        Me.lbl_amounttopay.Appearance.Options.UseForeColor = True
        Me.lbl_amounttopay.Appearance.Options.UseTextOptions = True
        Me.lbl_amounttopay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_amounttopay.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_amounttopay.Location = New System.Drawing.Point(125, 65)
        Me.lbl_amounttopay.Name = "lbl_amounttopay"
        Me.lbl_amounttopay.Size = New System.Drawing.Size(110, 18)
        Me.lbl_amounttopay.TabIndex = 105
        Me.lbl_amounttopay.Text = "0.00"
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(32, 85)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl15.TabIndex = 104
        Me.LabelControl15.Text = "Paid Amount"
        '
        'lbl_paid_amount
        '
        Me.lbl_paid_amount.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_paid_amount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_paid_amount.Appearance.Options.UseFont = True
        Me.lbl_paid_amount.Appearance.Options.UseForeColor = True
        Me.lbl_paid_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_paid_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_paid_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_paid_amount.Location = New System.Drawing.Point(125, 85)
        Me.lbl_paid_amount.Name = "lbl_paid_amount"
        Me.lbl_paid_amount.Size = New System.Drawing.Size(110, 18)
        Me.lbl_paid_amount.TabIndex = 103
        Me.lbl_paid_amount.Text = "0.00"
        '
        'lbl_delivery_fee
        '
        Me.lbl_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_delivery_fee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_delivery_fee.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_delivery_fee.Location = New System.Drawing.Point(248, 50)
        Me.lbl_delivery_fee.Name = "lbl_delivery_fee"
        Me.lbl_delivery_fee.Size = New System.Drawing.Size(130, 18)
        Me.lbl_delivery_fee.TabIndex = 102
        Me.lbl_delivery_fee.TabStop = True
        Me.lbl_delivery_fee.Text = "Add Delivery Fee"
        Me.lbl_delivery_fee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_delivery_fee
        '
        Me.txt_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_delivery_fee.EditValue = ""
        Me.txt_delivery_fee.Enabled = False
        Me.txt_delivery_fee.Location = New System.Drawing.Point(382, 49)
        Me.txt_delivery_fee.Name = "txt_delivery_fee"
        Me.txt_delivery_fee.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_delivery_fee.Properties.Appearance.Options.UseFont = True
        Me.txt_delivery_fee.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_delivery_fee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_delivery_fee.Size = New System.Drawing.Size(93, 22)
        Me.txt_delivery_fee.TabIndex = 99
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(19, 277)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl7.TabIndex = 100
        Me.LabelControl7.Text = "PO Ref. #"
        '
        'txt_po_ref
        '
        Me.txt_po_ref.Location = New System.Drawing.Point(119, 274)
        Me.txt_po_ref.Name = "txt_po_ref"
        Me.txt_po_ref.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_po_ref.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_po_ref.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_po_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_po_ref.Properties.Appearance.Options.UseForeColor = True
        Me.txt_po_ref.Size = New System.Drawing.Size(87, 22)
        Me.txt_po_ref.TabIndex = 99
        '
        'gb_payment
        '
        Me.gb_payment.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gb_payment.Controls.Add(Me.rb_epay)
        Me.gb_payment.Controls.Add(Me.rb_cheque)
        Me.gb_payment.Controls.Add(Me.rb_cash)
        Me.gb_payment.Controls.Add(Me.rb_terms)
        Me.gb_payment.Controls.Add(Me.LabelControl11)
        Me.gb_payment.Location = New System.Drawing.Point(17, 450)
        Me.gb_payment.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.gb_payment.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gb_payment.Name = "gb_payment"
        Me.gb_payment.Size = New System.Drawing.Size(386, 59)
        Me.gb_payment.TabIndex = 96
        Me.gb_payment.Text = "Shipping Method"
        '
        'rb_epay
        '
        Me.rb_epay.AutoSize = True
        Me.rb_epay.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_epay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_epay.Location = New System.Drawing.Point(102, 28)
        Me.rb_epay.Name = "rb_epay"
        Me.rb_epay.Size = New System.Drawing.Size(90, 20)
        Me.rb_epay.TabIndex = 100
        Me.rb_epay.Text = "E-Payment"
        Me.rb_epay.UseVisualStyleBackColor = True
        '
        'rb_cheque
        '
        Me.rb_cheque.AutoSize = True
        Me.rb_cheque.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_cheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_cheque.Location = New System.Drawing.Point(266, 28)
        Me.rb_cheque.Name = "rb_cheque"
        Me.rb_cheque.Size = New System.Drawing.Size(69, 20)
        Me.rb_cheque.TabIndex = 99
        Me.rb_cheque.Text = "Cheque"
        Me.rb_cheque.UseVisualStyleBackColor = True
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_cash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_cash.Location = New System.Drawing.Point(40, 28)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(55, 20)
        Me.rb_cash.TabIndex = 98
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_terms
        '
        Me.rb_terms.AutoSize = True
        Me.rb_terms.Checked = True
        Me.rb_terms.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_terms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_terms.Location = New System.Drawing.Point(199, 28)
        Me.rb_terms.Name = "rb_terms"
        Me.rb_terms.Size = New System.Drawing.Size(60, 20)
        Me.rb_terms.TabIndex = 97
        Me.rb_terms.TabStop = True
        Me.rb_terms.Text = "Terms"
        Me.rb_terms.UseVisualStyleBackColor = True
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 9.7!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(4, 5)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(91, 16)
        Me.LabelControl11.TabIndex = 95
        Me.LabelControl11.Text = "Payment Type"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(14, 90)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 47
        Me.LabelControl3.Text = "Company"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(15, 63)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl12.TabIndex = 87
        Me.LabelControl12.Text = "Customer ID"
        '
        'cbb_customer
        '
        Me.cbb_customer.Location = New System.Drawing.Point(115, 87)
        Me.cbb_customer.Name = "cbb_customer"
        Me.cbb_customer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.cbb_customer.Properties.Appearance.Options.UseFont = True
        Me.cbb_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customer.Properties.ReadOnly = True
        Me.cbb_customer.Size = New System.Drawing.Size(276, 22)
        Me.cbb_customer.TabIndex = 70
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 305)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "Bill To"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 334)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl2.TabIndex = 73
        Me.LabelControl2.Text = "Ship To"
        '
        'cb_same_billing
        '
        Me.cb_same_billing.AutoSize = True
        Me.cb_same_billing.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cb_same_billing.Location = New System.Drawing.Point(298, 334)
        Me.cb_same_billing.Name = "cb_same_billing"
        Me.cb_same_billing.Size = New System.Drawing.Size(97, 18)
        Me.cb_same_billing.TabIndex = 77
        Me.cb_same_billing.Text = "Same as billing"
        Me.cb_same_billing.UseVisualStyleBackColor = True
        '
        'txt_trucking
        '
        Me.txt_trucking.Location = New System.Drawing.Point(119, 355)
        Me.txt_trucking.Name = "txt_trucking"
        Me.txt_trucking.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_trucking.Properties.Appearance.Options.UseFont = True
        Me.txt_trucking.Size = New System.Drawing.Size(276, 22)
        Me.txt_trucking.TabIndex = 93
        '
        'lbl_trucking
        '
        Me.lbl_trucking.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_trucking.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_trucking.Appearance.Options.UseFont = True
        Me.lbl_trucking.Appearance.Options.UseForeColor = True
        Me.lbl_trucking.Location = New System.Drawing.Point(18, 358)
        Me.lbl_trucking.Name = "lbl_trucking"
        Me.lbl_trucking.Size = New System.Drawing.Size(49, 16)
        Me.lbl_trucking.TabIndex = 83
        Me.lbl_trucking.Text = "Trucking"
        '
        'txt_shipping
        '
        Me.txt_shipping.Location = New System.Drawing.Point(119, 329)
        Me.txt_shipping.Name = "txt_shipping"
        Me.txt_shipping.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_shipping.Properties.Appearance.Options.UseFont = True
        Me.txt_shipping.Size = New System.Drawing.Size(174, 22)
        Me.txt_shipping.TabIndex = 92
        '
        'gb_shipping
        '
        Me.gb_shipping.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.gb_shipping.Controls.Add(Me.LabelControl10)
        Me.gb_shipping.Controls.Add(Me.rb_deliver)
        Me.gb_shipping.Controls.Add(Me.rb_pickup)
        Me.gb_shipping.Location = New System.Drawing.Point(17, 383)
        Me.gb_shipping.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.gb_shipping.LookAndFeel.UseDefaultLookAndFeel = False
        Me.gb_shipping.Name = "gb_shipping"
        Me.gb_shipping.Size = New System.Drawing.Size(386, 61)
        Me.gb_shipping.TabIndex = 89
        Me.gb_shipping.Text = "Shipping Method"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 9.7!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(4, 5)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(108, 16)
        Me.LabelControl10.TabIndex = 95
        Me.LabelControl10.Text = "Shipping Method"
        '
        'rb_deliver
        '
        Me.rb_deliver.AutoSize = True
        Me.rb_deliver.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_deliver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_deliver.Location = New System.Drawing.Point(127, 29)
        Me.rb_deliver.Name = "rb_deliver"
        Me.rb_deliver.Size = New System.Drawing.Size(63, 20)
        Me.rb_deliver.TabIndex = 1
        Me.rb_deliver.Text = "Deliver"
        Me.rb_deliver.UseVisualStyleBackColor = True
        '
        'rb_pickup
        '
        Me.rb_pickup.AutoSize = True
        Me.rb_pickup.Checked = True
        Me.rb_pickup.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_pickup.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_pickup.Location = New System.Drawing.Point(40, 29)
        Me.rb_pickup.Name = "rb_pickup"
        Me.rb_pickup.Size = New System.Drawing.Size(69, 20)
        Me.rb_pickup.TabIndex = 0
        Me.rb_pickup.TabStop = True
        Me.rb_pickup.Text = "Pick-up"
        Me.rb_pickup.UseVisualStyleBackColor = True
        '
        'txt_billing
        '
        Me.txt_billing.Location = New System.Drawing.Point(119, 302)
        Me.txt_billing.Name = "txt_billing"
        Me.txt_billing.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_billing.Properties.Appearance.Options.UseFont = True
        Me.txt_billing.Size = New System.Drawing.Size(276, 22)
        Me.txt_billing.TabIndex = 91
        '
        'lbl_payment_status
        '
        Me.lbl_payment_status.Appearance.BackColor = System.Drawing.Color.Red
        Me.lbl_payment_status.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_payment_status.Appearance.ForeColor = System.Drawing.Color.White
        Me.lbl_payment_status.Appearance.Options.UseBackColor = True
        Me.lbl_payment_status.Appearance.Options.UseFont = True
        Me.lbl_payment_status.Appearance.Options.UseForeColor = True
        Me.lbl_payment_status.Appearance.Options.UseTextOptions = True
        Me.lbl_payment_status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_payment_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_payment_status.Location = New System.Drawing.Point(10, 43)
        Me.lbl_payment_status.Name = "lbl_payment_status"
        Me.lbl_payment_status.Size = New System.Drawing.Size(110, 18)
        Me.lbl_payment_status.TabIndex = 95
        Me.lbl_payment_status.Text = "STATUS"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(10, 9)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(151, 25)
        Me.LabelControl6.TabIndex = 94
        Me.LabelControl6.Text = "Payment Status"
        '
        'btn_pack
        '
        Me.btn_pack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pack.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pack.Appearance.Options.UseFont = True
        Me.btn_pack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_pack.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.packing1
        Me.btn_pack.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_pack.Location = New System.Drawing.Point(1267, 89)
        Me.btn_pack.Name = "btn_pack"
        Me.btn_pack.Size = New System.Drawing.Size(118, 46)
        Me.btn_pack.TabIndex = 91
        Me.btn_pack.Text = "Pack"
        '
        'btn_delete
        '
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_delete.Location = New System.Drawing.Point(436, 89)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(150, 46)
        Me.btn_delete.TabIndex = 80
        Me.btn_delete.Text = "Delete this Order"
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x321
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.Location = New System.Drawing.Point(1019, 89)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(118, 46)
        Me.btn_print.TabIndex = 78
        Me.btn_print.Text = "Print"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.Location = New System.Drawing.Point(1143, 89)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(118, 46)
        Me.btn_save.TabIndex = 6
        Me.btn_save.Text = "Save"
        '
        'txt_priv_notes
        '
        Me.txt_priv_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_priv_notes.Location = New System.Drawing.Point(17, 549)
        Me.txt_priv_notes.Name = "txt_priv_notes"
        Me.txt_priv_notes.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_priv_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_notes.Size = New System.Drawing.Size(378, 46)
        Me.txt_priv_notes.TabIndex = 76
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(17, 525)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl5.TabIndex = 75
        Me.LabelControl5.Text = "Private Comments:"
        '
        'txt_pub_notes
        '
        Me.txt_pub_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_pub_notes.Location = New System.Drawing.Point(15, 627)
        Me.txt_pub_notes.Name = "txt_pub_notes"
        Me.txt_pub_notes.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_pub_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_notes.Size = New System.Drawing.Size(380, 46)
        Me.txt_pub_notes.TabIndex = 68
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(17, 603)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl4.TabIndex = 67
        Me.LabelControl4.Text = "Public Comments:"
        '
        'grid_order
        '
        Me.grid_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_order.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_order.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_order.ColumnHeadersHeight = 28
        Me.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_qty, Me.col_model, Me.col_description, Me.col_cost, Me.col_sku, Me.col_total})
        Me.grid_order.EnableHeadersVisualStyles = False
        Me.grid_order.Location = New System.Drawing.Point(592, 142)
        Me.grid_order.Name = "grid_order"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grid_order.RowHeadersWidth = 47
        Me.grid_order.Size = New System.Drawing.Size(793, 453)
        Me.grid_order.TabIndex = 58
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Qty"
        Me.col_qty.MinimumWidth = 6
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Item"
        Me.col_model.MinimumWidth = 6
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 130
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.FillWeight = 137.4594!
        Me.col_description.HeaderText = "Description"
        Me.col_description.MinimumWidth = 6
        Me.col_description.Name = "col_description"
        '
        'col_cost
        '
        Me.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_cost.FillWeight = 102.6804!
        Me.col_cost.HeaderText = "Price"
        Me.col_cost.MinimumWidth = 6
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Width = 80
        '
        'col_sku
        '
        Me.col_sku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_sku.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_sku.FillWeight = 80.0!
        Me.col_sku.HeaderText = "DISCOUNT"
        Me.col_sku.MinimumWidth = 6
        Me.col_sku.Name = "col_sku"
        Me.col_sku.Width = 115
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.MinimumWidth = 6
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_total.Width = 115
        '
        'grid_remaining
        '
        Me.grid_remaining.AllowUserToAddRows = False
        Me.grid_remaining.AllowUserToDeleteRows = False
        Me.grid_remaining.AllowUserToResizeColumns = False
        Me.grid_remaining.AllowUserToResizeRows = False
        Me.grid_remaining.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_remaining.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_remaining.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_remaining.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_remaining.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_remaining.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_remaining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_remaining.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grid_remaining.ColumnHeadersHeight = 28
        Me.grid_remaining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_remaining.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_other, Me.DataGridViewTextBoxColumn1, Me.col_on_hold})
        Me.grid_remaining.Enabled = False
        Me.grid_remaining.EnableHeadersVisualStyles = False
        Me.grid_remaining.Location = New System.Drawing.Point(436, 142)
        Me.grid_remaining.MultiSelect = False
        Me.grid_remaining.Name = "grid_remaining"
        Me.grid_remaining.ReadOnly = True
        Me.grid_remaining.RowHeadersVisible = False
        Me.grid_remaining.RowHeadersWidth = 47
        Me.grid_remaining.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_remaining.RowTemplate.Height = 23
        Me.grid_remaining.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grid_remaining.Size = New System.Drawing.Size(150, 453)
        Me.grid_remaining.TabIndex = 87
        '
        'col_other
        '
        Me.col_other.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_other.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_other.HeaderText = "Others Stocks"
        Me.col_other.MinimumWidth = 6
        Me.col_other.Name = "col_other"
        Me.col_other.ReadOnly = True
        Me.col_other.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "My Stocks"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'col_on_hold
        '
        Me.col_on_hold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_on_hold.DefaultCellStyle = DataGridViewCellStyle11
        Me.col_on_hold.HeaderText = "On Hold"
        Me.col_on_hold.MinimumWidth = 6
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.ReadOnly = True
        Me.col_on_hold.Width = 50
        '
        'print_contextmenu
        '
        Me.print_contextmenu.ImageScalingSize = New System.Drawing.Size(18, 18)
        Me.print_contextmenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DraftInvoiceToolStripMenuItem, Me.PackingSlipToolStripMenuItem})
        Me.print_contextmenu.Name = "print_contextmenu"
        Me.print_contextmenu.Size = New System.Drawing.Size(142, 48)
        '
        'DraftInvoiceToolStripMenuItem
        '
        Me.DraftInvoiceToolStripMenuItem.Name = "DraftInvoiceToolStripMenuItem"
        Me.DraftInvoiceToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.DraftInvoiceToolStripMenuItem.Text = "Draft Invoice"
        '
        'PackingSlipToolStripMenuItem
        '
        Me.PackingSlipToolStripMenuItem.Name = "PackingSlipToolStripMenuItem"
        Me.PackingSlipToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PackingSlipToolStripMenuItem.Text = "Packing Slip"
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(626, 47)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_discount.Properties.Appearance.Options.UseFont = True
        Me.cbb_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"peso", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(62, 22)
        Me.cbb_discount.TabIndex = 107
        '
        'cb_vatable
        '
        Me.cb_vatable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_vatable.AutoSize = True
        Me.cb_vatable.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cb_vatable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cb_vatable.Location = New System.Drawing.Point(351, 79)
        Me.cb_vatable.Name = "cb_vatable"
        Me.cb_vatable.Size = New System.Drawing.Size(106, 20)
        Me.cb_vatable.TabIndex = 116
        Me.cb_vatable.Text = "Vatable Sales"
        Me.cb_vatable.UseVisualStyleBackColor = True
        '
        'LabelControl17
        '
        Me.LabelControl17.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(387, 136)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(120, 22)
        Me.LabelControl17.TabIndex = 109
        Me.LabelControl17.Text = "Total Amount"
        '
        'lbl_withholding_tax_amount
        '
        Me.lbl_withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_withholding_tax_amount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_withholding_tax_amount.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseForeColor = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_amount.Location = New System.Drawing.Point(578, 100)
        Me.lbl_withholding_tax_amount.Name = "lbl_withholding_tax_amount"
        Me.lbl_withholding_tax_amount.Size = New System.Drawing.Size(111, 14)
        Me.lbl_withholding_tax_amount.TabIndex = 115
        Me.lbl_withholding_tax_amount.Text = "₱0.00"
        '
        'LabelControl18
        '
        Me.LabelControl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(487, 52)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl18.TabIndex = 110
        Me.LabelControl18.Text = "Discount:"
        '
        'LabelControl19
        '
        Me.LabelControl19.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(488, 102)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl19.TabIndex = 114
        Me.LabelControl19.Text = "WT Deduction:"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.Enabled = False
        Me.txt_discount.Location = New System.Drawing.Point(562, 47)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_discount.Properties.Appearance.Options.UseFont = True
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.Mask.BeepOnError = True
        Me.txt_discount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_discount.Properties.MaskSettings.Set("mask", "n")
        Me.txt_discount.Size = New System.Drawing.Size(68, 22)
        Me.txt_discount.TabIndex = 108
        '
        'lbl_withholding_tax_percentage
        '
        Me.lbl_withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_withholding_tax_percentage.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseForeColor = True
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_percentage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_percentage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_percentage.Location = New System.Drawing.Point(616, 82)
        Me.lbl_withholding_tax_percentage.Name = "lbl_withholding_tax_percentage"
        Me.lbl_withholding_tax_percentage.Size = New System.Drawing.Size(73, 14)
        Me.lbl_withholding_tax_percentage.TabIndex = 113
        Me.lbl_withholding_tax_percentage.Text = "1.00%"
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_total.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_total.Appearance.Options.UseBackColor = True
        Me.lbl_total.Appearance.Options.UseBorderColor = True
        Me.lbl_total.Appearance.Options.UseFont = True
        Me.lbl_total.Appearance.Options.UseForeColor = True
        Me.lbl_total.Appearance.Options.UseTextOptions = True
        Me.lbl_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lbl_total.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_total.Location = New System.Drawing.Point(517, 132)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total.Size = New System.Drawing.Size(171, 29)
        Me.lbl_total.TabIndex = 111
        Me.lbl_total.Text = "₱0.00"
        '
        'cb_tax_applied
        '
        Me.cb_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_tax_applied.AutoSize = True
        Me.cb_tax_applied.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cb_tax_applied.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cb_tax_applied.Location = New System.Drawing.Point(471, 79)
        Me.cb_tax_applied.Name = "cb_tax_applied"
        Me.cb_tax_applied.Size = New System.Drawing.Size(148, 20)
        Me.cb_tax_applied.TabIndex = 112
        Me.cb_tax_applied.Text = "Apply Witholding Tax"
        Me.cb_tax_applied.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 31)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Order Details"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.lbl_balance)
        Me.Guna2Panel1.Controls.Add(Me.LabelControl21)
        Me.Guna2Panel1.Controls.Add(Me.btn_refund)
        Me.Guna2Panel1.Controls.Add(Me.btn_epayment)
        Me.Guna2Panel1.Controls.Add(Me.LabelControl6)
        Me.Guna2Panel1.Controls.Add(Me.LabelControl16)
        Me.Guna2Panel1.Controls.Add(Me.lbl_payment_status)
        Me.Guna2Panel1.Controls.Add(Me.lbl_amounttopay)
        Me.Guna2Panel1.Controls.Add(Me.lbl_paid_amount)
        Me.Guna2Panel1.Controls.Add(Me.LabelControl15)
        Me.Guna2Panel1.Location = New System.Drawing.Point(436, 601)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(255, 172)
        Me.Guna2Panel1.TabIndex = 122
        '
        'lbl_balance
        '
        Me.lbl_balance.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_balance.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_balance.Appearance.Options.UseFont = True
        Me.lbl_balance.Appearance.Options.UseForeColor = True
        Me.lbl_balance.Appearance.Options.UseTextOptions = True
        Me.lbl_balance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_balance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_balance.Location = New System.Drawing.Point(125, 109)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(110, 18)
        Me.lbl_balance.TabIndex = 110
        Me.lbl_balance.Text = "0.00"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(32, 110)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl21.TabIndex = 109
        Me.LabelControl21.Text = "Balance"
        '
        'btn_refund
        '
        Me.btn_refund.Enabled = False
        Me.btn_refund.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refund.Location = New System.Drawing.Point(9, 134)
        Me.btn_refund.Name = "btn_refund"
        Me.btn_refund.Size = New System.Drawing.Size(110, 27)
        Me.btn_refund.TabIndex = 108
        Me.btn_refund.Text = "Refund"
        '
        'btn_epayment
        '
        Me.btn_epayment.Enabled = False
        Me.btn_epayment.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_epayment.Location = New System.Drawing.Point(125, 134)
        Me.btn_epayment.Name = "btn_epayment"
        Me.btn_epayment.Size = New System.Drawing.Size(110, 27)
        Me.btn_epayment.TabIndex = 107
        Me.btn_epayment.Text = "E-Payment Proofs"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.BorderThickness = 1
        Me.Guna2Panel2.Controls.Add(Me.lbl_invoice)
        Me.Guna2Panel2.Controls.Add(Me.txt_invoice)
        Me.Guna2Panel2.Controls.Add(Me.cbb_discount)
        Me.Guna2Panel2.Controls.Add(Me.cb_vatable)
        Me.Guna2Panel2.Controls.Add(Me.cb_tax_applied)
        Me.Guna2Panel2.Controls.Add(Me.LabelControl17)
        Me.Guna2Panel2.Controls.Add(Me.lbl_total)
        Me.Guna2Panel2.Controls.Add(Me.lbl_withholding_tax_amount)
        Me.Guna2Panel2.Controls.Add(Me.lbl_withholding_tax_percentage)
        Me.Guna2Panel2.Controls.Add(Me.LabelControl18)
        Me.Guna2Panel2.Controls.Add(Me.txt_discount)
        Me.Guna2Panel2.Controls.Add(Me.lbl_delivery_fee)
        Me.Guna2Panel2.Controls.Add(Me.txt_delivery_fee)
        Me.Guna2Panel2.Controls.Add(Me.LabelControl19)
        Me.Guna2Panel2.Location = New System.Drawing.Point(697, 601)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(712, 172)
        Me.Guna2Panel2.TabIndex = 123
        '
        'lbl_invoice
        '
        Me.lbl_invoice.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_invoice.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_invoice.Appearance.Options.UseFont = True
        Me.lbl_invoice.Appearance.Options.UseForeColor = True
        Me.lbl_invoice.Location = New System.Drawing.Point(291, 102)
        Me.lbl_invoice.Name = "lbl_invoice"
        Me.lbl_invoice.Size = New System.Drawing.Size(67, 16)
        Me.lbl_invoice.TabIndex = 118
        Me.lbl_invoice.Text = "Invoice No.:"
        Me.lbl_invoice.Visible = False
        '
        'txt_invoice
        '
        Me.txt_invoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_invoice.EditValue = ""
        Me.txt_invoice.Location = New System.Drawing.Point(364, 99)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_invoice.Properties.Appearance.Options.UseFont = True
        Me.txt_invoice.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_invoice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_invoice.Size = New System.Drawing.Size(93, 22)
        Me.txt_invoice.TabIndex = 119
        Me.txt_invoice.Visible = False
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel3.BorderThickness = 1
        Me.Guna2Panel3.Controls.Add(Me.txt_terms)
        Me.Guna2Panel3.Controls.Add(Me.txt_sales_agent)
        Me.Guna2Panel3.Controls.Add(Me.lbl_sales_agent)
        Me.Guna2Panel3.Controls.Add(Me.lbl_terms)
        Me.Guna2Panel3.Controls.Add(Me.txt_quote_id)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl20)
        Me.Guna2Panel3.Controls.Add(Me.txt_no)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl14)
        Me.Guna2Panel3.Controls.Add(Me.txt_contact_person)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl13)
        Me.Guna2Panel3.Controls.Add(Me.lbl_credits_available)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl9)
        Me.Guna2Panel3.Controls.Add(Me.lbl_account_type)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl8)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl7)
        Me.Guna2Panel3.Controls.Add(Me.lbl_cid)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.txt_trucking)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl12)
        Me.Guna2Panel3.Controls.Add(Me.txt_po_ref)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl3)
        Me.Guna2Panel3.Controls.Add(Me.lbl_trucking)
        Me.Guna2Panel3.Controls.Add(Me.cb_same_billing)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl4)
        Me.Guna2Panel3.Controls.Add(Me.txt_shipping)
        Me.Guna2Panel3.Controls.Add(Me.gb_payment)
        Me.Guna2Panel3.Controls.Add(Me.cbb_customer)
        Me.Guna2Panel3.Controls.Add(Me.txt_billing)
        Me.Guna2Panel3.Controls.Add(Me.txt_priv_notes)
        Me.Guna2Panel3.Controls.Add(Me.gb_shipping)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl2)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl1)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl5)
        Me.Guna2Panel3.Controls.Add(Me.txt_pub_notes)
        Me.Guna2Panel3.Location = New System.Drawing.Point(12, 86)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(413, 687)
        Me.Guna2Panel3.TabIndex = 124
        '
        'txt_terms
        '
        Me.txt_terms.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_terms.Location = New System.Drawing.Point(318, 144)
        Me.txt_terms.Maximum = New Decimal(New Integer() {360, 0, 0, 0})
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Size = New System.Drawing.Size(73, 22)
        Me.txt_terms.TabIndex = 120
        '
        'txt_sales_agent
        '
        Me.txt_sales_agent.Location = New System.Drawing.Point(115, 227)
        Me.txt_sales_agent.Name = "txt_sales_agent"
        Me.txt_sales_agent.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_sales_agent.Properties.Appearance.Options.UseFont = True
        Me.txt_sales_agent.Properties.ReadOnly = True
        Me.txt_sales_agent.Size = New System.Drawing.Size(180, 22)
        Me.txt_sales_agent.TabIndex = 119
        '
        'lbl_sales_agent
        '
        Me.lbl_sales_agent.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_sales_agent.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_sales_agent.Appearance.Options.UseFont = True
        Me.lbl_sales_agent.Appearance.Options.UseForeColor = True
        Me.lbl_sales_agent.Location = New System.Drawing.Point(13, 230)
        Me.lbl_sales_agent.Name = "lbl_sales_agent"
        Me.lbl_sales_agent.Size = New System.Drawing.Size(92, 16)
        Me.lbl_sales_agent.TabIndex = 118
        Me.lbl_sales_agent.Text = "Assigned Agent"
        '
        'lbl_terms
        '
        Me.lbl_terms.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_terms.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_terms.Appearance.Options.UseFont = True
        Me.lbl_terms.Appearance.Options.UseForeColor = True
        Me.lbl_terms.Location = New System.Drawing.Point(271, 146)
        Me.lbl_terms.Name = "lbl_terms"
        Me.lbl_terms.Size = New System.Drawing.Size(36, 16)
        Me.lbl_terms.TabIndex = 117
        Me.lbl_terms.Text = "Terms"
        '
        'txt_quote_id
        '
        Me.txt_quote_id.Location = New System.Drawing.Point(298, 274)
        Me.txt_quote_id.Name = "txt_quote_id"
        Me.txt_quote_id.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_quote_id.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_quote_id.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_quote_id.Properties.Appearance.Options.UseBackColor = True
        Me.txt_quote_id.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_quote_id.Properties.Appearance.Options.UseFont = True
        Me.txt_quote_id.Properties.Appearance.Options.UseForeColor = True
        Me.txt_quote_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_quote_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_quote_id.Properties.ReadOnly = True
        Me.txt_quote_id.Size = New System.Drawing.Size(79, 20)
        Me.txt_quote_id.TabIndex = 113
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(220, 276)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl20.TabIndex = 112
        Me.LabelControl20.Text = "Quotation ID"
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(115, 199)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_no.Properties.Appearance.Options.UseFont = True
        Me.txt_no.Properties.ReadOnly = True
        Me.txt_no.Size = New System.Drawing.Size(180, 22)
        Me.txt_no.TabIndex = 111
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(15, 202)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl14.TabIndex = 110
        Me.LabelControl14.Text = "Contact No."
        '
        'txt_contact_person
        '
        Me.txt_contact_person.Location = New System.Drawing.Point(115, 171)
        Me.txt_contact_person.Name = "txt_contact_person"
        Me.txt_contact_person.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_contact_person.Properties.Appearance.Options.UseFont = True
        Me.txt_contact_person.Properties.ReadOnly = True
        Me.txt_contact_person.Size = New System.Drawing.Size(180, 22)
        Me.txt_contact_person.TabIndex = 109
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(15, 174)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl13.TabIndex = 108
        Me.LabelControl13.Text = "Contact Person"
        '
        'lbl_credits_available
        '
        Me.lbl_credits_available.Location = New System.Drawing.Point(115, 143)
        Me.lbl_credits_available.Name = "lbl_credits_available"
        Me.lbl_credits_available.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_credits_available.Properties.Appearance.Options.UseFont = True
        Me.lbl_credits_available.Properties.ReadOnly = True
        Me.lbl_credits_available.Size = New System.Drawing.Size(128, 22)
        Me.lbl_credits_available.TabIndex = 107
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(15, 146)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl9.TabIndex = 106
        Me.LabelControl9.Text = "Credit Balance"
        '
        'lbl_account_type
        '
        Me.lbl_account_type.Location = New System.Drawing.Point(115, 115)
        Me.lbl_account_type.Name = "lbl_account_type"
        Me.lbl_account_type.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_account_type.Properties.Appearance.Options.UseFont = True
        Me.lbl_account_type.Properties.ReadOnly = True
        Me.lbl_account_type.Size = New System.Drawing.Size(180, 22)
        Me.lbl_account_type.TabIndex = 105
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(15, 118)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl8.TabIndex = 104
        Me.LabelControl8.Text = "Account type"
        '
        'lbl_cid
        '
        Me.lbl_cid.Location = New System.Drawing.Point(115, 60)
        Me.lbl_cid.Name = "lbl_cid"
        Me.lbl_cid.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_cid.Properties.Appearance.Options.UseFont = True
        Me.lbl_cid.Properties.ReadOnly = True
        Me.lbl_cid.Size = New System.Drawing.Size(128, 22)
        Me.lbl_cid.TabIndex = 103
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btn_modify
        '
        Me.btn_modify.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_modify.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_modify.Appearance.Options.UseFont = True
        Me.btn_modify.Enabled = False
        Me.btn_modify.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.modifytablestyle_32x32
        Me.btn_modify.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_modify.Location = New System.Drawing.Point(895, 89)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(118, 46)
        Me.btn_modify.TabIndex = 125
        Me.btn_modify.Text = "Modify"
        '
        'btn_unserved
        '
        Me.btn_unserved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_unserved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_unserved.Appearance.Options.UseFont = True
        Me.btn_unserved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.article_32x321
        Me.btn_unserved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_unserved.Location = New System.Drawing.Point(771, 89)
        Me.btn_unserved.Name = "btn_unserved"
        Me.btn_unserved.Size = New System.Drawing.Size(118, 46)
        Me.btn_unserved.TabIndex = 129
        Me.btn_unserved.Text = "Unserved"
        '
        'lbl_cant_edit
        '
        Me.lbl_cant_edit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_cant_edit.AutoSize = True
        Me.lbl_cant_edit.BackColor = System.Drawing.Color.GhostWhite
        Me.lbl_cant_edit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.lbl_cant_edit.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_cant_edit.Location = New System.Drawing.Point(854, 542)
        Me.lbl_cant_edit.Name = "lbl_cant_edit"
        Me.lbl_cant_edit.Size = New System.Drawing.Size(318, 15)
        Me.lbl_cant_edit.TabIndex = 130
        Me.lbl_cant_edit.Text = "Modification of Quotation based orders requires privilege."
        Me.lbl_cant_edit.Visible = False
        '
        'frm_sales_view_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1409, 785)
        Me.Controls.Add(Me.lbl_cant_edit)
        Me.Controls.Add(Me.btn_unserved)
        Me.Controls.Add(Me.btn_modify)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Controls.Add(Me.btn_pack)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.grid_order)
        Me.Controls.Add(Me.grid_remaining)
        Me.Controls.Add(Me.btn_delete)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1275, 824)
        Me.Name = "frm_sales_view_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Order"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_po_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_payment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_payment.ResumeLayout(False)
        Me.gb_payment.PerformLayout()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trucking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_shipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gb_shipping, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gb_shipping.ResumeLayout(False)
        Me.gb_shipping.PerformLayout()
        CType(Me.txt_billing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.print_contextmenu.ResumeLayout(False)
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.txt_invoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.txt_terms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sales_agent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quote_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_credits_available.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_account_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_cid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_priv_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pub_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_order As DataGridView
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_remaining As DataGridView
    Friend WithEvents btn_pack As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_status As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lbl_payment_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_cheque As RadioButton
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_terms As RadioButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_same_billing As CheckBox
    Friend WithEvents txt_trucking As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_trucking As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_shipping As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gb_shipping As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_deliver As RadioButton
    Friend WithEvents rb_pickup As RadioButton
    Friend WithEvents txt_billing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gb_payment As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_po_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_delivery_fee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_delivery_fee As LinkLabel
    Friend WithEvents lbl_paid_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_amounttopay As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents print_contextmenu As ContextMenuStrip
    Friend WithEvents DraftInvoiceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PackingSlipToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_vatable As CheckBox
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_withholding_tax_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_tax_applied As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents col_other As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents col_on_hold As DataGridViewTextBoxColumn
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents lbl_credits_available As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_account_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_cid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_contact_person As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_sku As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents txt_quote_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    'MY EDIT
    Friend WithEvents rb_epay As RadioButton
    Friend WithEvents btn_epayment As SimpleButton
    Friend WithEvents txt_terms As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_sales_agent As TextEdit
    Friend WithEvents lbl_sales_agent As LabelControl
    Friend WithEvents lbl_terms As LabelControl
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents btn_modify As SimpleButton
    Friend WithEvents btn_refund As SimpleButton
    Friend WithEvents lbl_balance As LabelControl
    Friend WithEvents LabelControl21 As LabelControl
    Friend WithEvents btn_unserved As SimpleButton
    Friend WithEvents lbl_invoice As LabelControl
    Friend WithEvents txt_invoice As TextEdit
    Friend WithEvents lbl_cant_edit As Label
End Class
