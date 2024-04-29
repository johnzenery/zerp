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
Partial Class frm_sales_create_order
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_create_order))
        Me.txt_quote_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_order = New System.Windows.Forms.DataGridView()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_unserve = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.grid_remaining = New System.Windows.Forms.DataGridView()
        Me.col_other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_on_hold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.txt_terms = New System.Windows.Forms.NumericUpDown()
        Me.txt_sales_agent = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_sales_agent = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_terms = New DevExpress.XtraEditors.LabelControl()
        Me.txt_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact_person = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_credits_available = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_account_type = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_cid = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_trucking = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_po_ref = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.cb_same_billing = New System.Windows.Forms.CheckBox()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_shipping = New DevExpress.XtraEditors.TextEdit()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.rb_epay = New System.Windows.Forms.RadioButton()
        Me.rb_cheque = New System.Windows.Forms.RadioButton()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_terms = New System.Windows.Forms.RadioButton()
        Me.cbb_customer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_billing = New DevExpress.XtraEditors.TextEdit()
        Me.txt_priv_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.rb_deliver = New System.Windows.Forms.RadioButton()
        Me.rb_pickup = New System.Windows.Forms.RadioButton()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pub_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_invoice = New DevExpress.XtraEditors.LabelControl()
        Me.txt_invoice = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cb_vatable = New System.Windows.Forms.CheckBox()
        Me.cb_tax_applied = New System.Windows.Forms.CheckBox()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_delivery_fee = New System.Windows.Forms.LinkLabel()
        Me.txt_delivery_fee = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_payment_status = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_balance = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_paid_amount = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_unserved = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.HyperlinkLabelControl3 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl4 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_head = New System.Windows.Forms.Label()
        CType(Me.txt_quote_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        CType(Me.txt_terms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sales_agent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_credits_available.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_account_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl_cid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_trucking.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_po_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_shipping.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_billing.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.txt_invoice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_quote_id
        '
        Me.txt_quote_id.Location = New System.Drawing.Point(297, 265)
        Me.txt_quote_id.Name = "txt_quote_id"
        Me.txt_quote_id.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_quote_id.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_quote_id.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_quote_id.Properties.Appearance.Options.UseBackColor = True
        Me.txt_quote_id.Properties.Appearance.Options.UseFont = True
        Me.txt_quote_id.Properties.Appearance.Options.UseForeColor = True
        Me.txt_quote_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_quote_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_quote_id.Properties.ReadOnly = True
        Me.txt_quote_id.Size = New System.Drawing.Size(79, 20)
        Me.txt_quote_id.TabIndex = 100
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(219, 267)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl15.TabIndex = 99
        Me.LabelControl15.Text = "Quotation ID"
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_clear.Appearance.Options.UseFont = True
        Me.btn_clear.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.clearall_32x32
        Me.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_clear.Location = New System.Drawing.Point(1143, 89)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(118, 46)
        Me.btn_clear.TabIndex = 66
        Me.btn_clear.Text = "Clear"
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
        Me.grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_order.ColumnHeadersHeight = 28
        Me.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_qty, Me.col_model, Me.col_description, Me.col_cost, Me.col_sku, Me.col_total, Me.btn_unserve})
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
        Me.grid_order.Size = New System.Drawing.Size(793, 476)
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
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 150
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.FillWeight = 137.4594!
        Me.col_description.HeaderText = "Description"
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
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_sku
        '
        Me.col_sku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_sku.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_sku.FillWeight = 80.0!
        Me.col_sku.HeaderText = "DISCOUNT"
        Me.col_sku.Name = "col_sku"
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btn_unserve
        '
        Me.btn_unserve.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btn_unserve.HeaderText = "Unserved"
        Me.btn_unserve.Name = "btn_unserve"
        Me.btn_unserve.Text = "📦"
        Me.btn_unserve.UseColumnTextForButtonValue = True
        Me.btn_unserve.Width = 59
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
        Me.grid_remaining.RowTemplate.Height = 23
        Me.grid_remaining.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.grid_remaining.Size = New System.Drawing.Size(150, 476)
        Me.grid_remaining.TabIndex = 80
        '
        'col_other
        '
        Me.col_other.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_other.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_other.HeaderText = "Others Stocks"
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
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'col_on_hold
        '
        Me.col_on_hold.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_on_hold.DefaultCellStyle = DataGridViewCellStyle11
        Me.col_on_hold.HeaderText = "On Hold"
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.ReadOnly = True
        Me.col_on_hold.Width = 50
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boorderitem_32x32
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.Location = New System.Drawing.Point(1267, 89)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(118, 46)
        Me.btn_create.TabIndex = 6
        Me.btn_create.Text = "Create"
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
        Me.Guna2Panel3.Controls.Add(Me.LabelControl15)
        Me.Guna2Panel3.Controls.Add(Me.txt_no)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl8)
        Me.Guna2Panel3.Controls.Add(Me.txt_contact_person)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl18)
        Me.Guna2Panel3.Controls.Add(Me.lbl_credits_available)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl19)
        Me.Guna2Panel3.Controls.Add(Me.lbl_account_type)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl20)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl21)
        Me.Guna2Panel3.Controls.Add(Me.lbl_cid)
        Me.Guna2Panel3.Controls.Add(Me.Label1)
        Me.Guna2Panel3.Controls.Add(Me.txt_trucking)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl22)
        Me.Guna2Panel3.Controls.Add(Me.txt_po_ref)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl23)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl24)
        Me.Guna2Panel3.Controls.Add(Me.cb_same_billing)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl25)
        Me.Guna2Panel3.Controls.Add(Me.txt_shipping)
        Me.Guna2Panel3.Controls.Add(Me.GroupControl1)
        Me.Guna2Panel3.Controls.Add(Me.cbb_customer)
        Me.Guna2Panel3.Controls.Add(Me.txt_billing)
        Me.Guna2Panel3.Controls.Add(Me.txt_priv_notes)
        Me.Guna2Panel3.Controls.Add(Me.GroupControl2)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl28)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl29)
        Me.Guna2Panel3.Controls.Add(Me.LabelControl30)
        Me.Guna2Panel3.Controls.Add(Me.txt_pub_notes)
        Me.Guna2Panel3.Location = New System.Drawing.Point(17, 86)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(413, 687)
        Me.Guna2Panel3.TabIndex = 125
        '
        'txt_terms
        '
        Me.txt_terms.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_terms.Location = New System.Drawing.Point(320, 144)
        Me.txt_terms.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Size = New System.Drawing.Size(73, 22)
        Me.txt_terms.TabIndex = 116
        '
        'txt_sales_agent
        '
        Me.txt_sales_agent.Location = New System.Drawing.Point(117, 227)
        Me.txt_sales_agent.Name = "txt_sales_agent"
        Me.txt_sales_agent.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_sales_agent.Properties.Appearance.Options.UseFont = True
        Me.txt_sales_agent.Properties.ReadOnly = True
        Me.txt_sales_agent.Size = New System.Drawing.Size(180, 22)
        Me.txt_sales_agent.TabIndex = 115
        '
        'lbl_sales_agent
        '
        Me.lbl_sales_agent.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_sales_agent.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_sales_agent.Appearance.Options.UseFont = True
        Me.lbl_sales_agent.Appearance.Options.UseForeColor = True
        Me.lbl_sales_agent.Location = New System.Drawing.Point(15, 230)
        Me.lbl_sales_agent.Name = "lbl_sales_agent"
        Me.lbl_sales_agent.Size = New System.Drawing.Size(92, 16)
        Me.lbl_sales_agent.TabIndex = 114
        Me.lbl_sales_agent.Text = "Assigned Agent"
        '
        'lbl_terms
        '
        Me.lbl_terms.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_terms.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_terms.Appearance.Options.UseFont = True
        Me.lbl_terms.Appearance.Options.UseForeColor = True
        Me.lbl_terms.Location = New System.Drawing.Point(273, 146)
        Me.lbl_terms.Name = "lbl_terms"
        Me.lbl_terms.Size = New System.Drawing.Size(36, 16)
        Me.lbl_terms.TabIndex = 112
        Me.lbl_terms.Text = "Terms"
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(117, 199)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_no.Properties.Appearance.Options.UseFont = True
        Me.txt_no.Properties.ReadOnly = True
        Me.txt_no.Size = New System.Drawing.Size(180, 22)
        Me.txt_no.TabIndex = 111
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(15, 202)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl8.TabIndex = 110
        Me.LabelControl8.Text = "Contact No."
        '
        'txt_contact_person
        '
        Me.txt_contact_person.Location = New System.Drawing.Point(117, 171)
        Me.txt_contact_person.Name = "txt_contact_person"
        Me.txt_contact_person.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_contact_person.Properties.Appearance.Options.UseFont = True
        Me.txt_contact_person.Properties.ReadOnly = True
        Me.txt_contact_person.Size = New System.Drawing.Size(180, 22)
        Me.txt_contact_person.TabIndex = 109
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(15, 174)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl18.TabIndex = 108
        Me.LabelControl18.Text = "Contact Person"
        '
        'lbl_credits_available
        '
        Me.lbl_credits_available.Location = New System.Drawing.Point(117, 143)
        Me.lbl_credits_available.Name = "lbl_credits_available"
        Me.lbl_credits_available.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_credits_available.Properties.Appearance.Options.UseFont = True
        Me.lbl_credits_available.Properties.ReadOnly = True
        Me.lbl_credits_available.Size = New System.Drawing.Size(128, 22)
        Me.lbl_credits_available.TabIndex = 107
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(15, 146)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl19.TabIndex = 106
        Me.LabelControl19.Text = "Credit Balance"
        '
        'lbl_account_type
        '
        Me.lbl_account_type.Location = New System.Drawing.Point(117, 115)
        Me.lbl_account_type.Name = "lbl_account_type"
        Me.lbl_account_type.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_account_type.Properties.Appearance.Options.UseFont = True
        Me.lbl_account_type.Properties.ReadOnly = True
        Me.lbl_account_type.Size = New System.Drawing.Size(180, 22)
        Me.lbl_account_type.TabIndex = 105
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.Location = New System.Drawing.Point(15, 118)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl20.TabIndex = 104
        Me.LabelControl20.Text = "Account type"
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl21.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseForeColor = True
        Me.LabelControl21.Location = New System.Drawing.Point(18, 268)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl21.TabIndex = 100
        Me.LabelControl21.Text = "PO Ref. #"
        '
        'lbl_cid
        '
        Me.lbl_cid.Location = New System.Drawing.Point(117, 60)
        Me.lbl_cid.Name = "lbl_cid"
        Me.lbl_cid.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.lbl_cid.Properties.Appearance.Options.UseFont = True
        Me.lbl_cid.Properties.ReadOnly = True
        Me.lbl_cid.Size = New System.Drawing.Size(128, 22)
        Me.lbl_cid.TabIndex = 103
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
        'txt_trucking
        '
        Me.txt_trucking.Location = New System.Drawing.Point(120, 346)
        Me.txt_trucking.Name = "txt_trucking"
        Me.txt_trucking.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_trucking.Properties.Appearance.Options.UseFont = True
        Me.txt_trucking.Size = New System.Drawing.Size(276, 22)
        Me.txt_trucking.TabIndex = 93
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl22.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseForeColor = True
        Me.LabelControl22.Location = New System.Drawing.Point(15, 63)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl22.TabIndex = 87
        Me.LabelControl22.Text = "Customer ID"
        '
        'txt_po_ref
        '
        Me.txt_po_ref.Location = New System.Drawing.Point(120, 265)
        Me.txt_po_ref.Name = "txt_po_ref"
        Me.txt_po_ref.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_po_ref.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me.txt_po_ref.Properties.Appearance.Options.UseBorderColor = True
        Me.txt_po_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_po_ref.Properties.Appearance.Options.UseForeColor = True
        Me.txt_po_ref.Size = New System.Drawing.Size(87, 22)
        Me.txt_po_ref.TabIndex = 99
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl23.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Appearance.Options.UseForeColor = True
        Me.LabelControl23.Location = New System.Drawing.Point(14, 90)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl23.TabIndex = 47
        Me.LabelControl23.Text = "Company"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl24.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.Appearance.Options.UseForeColor = True
        Me.LabelControl24.Location = New System.Drawing.Point(17, 349)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl24.TabIndex = 83
        Me.LabelControl24.Text = "Trucking"
        '
        'cb_same_billing
        '
        Me.cb_same_billing.AutoSize = True
        Me.cb_same_billing.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.cb_same_billing.Location = New System.Drawing.Point(297, 323)
        Me.cb_same_billing.Name = "cb_same_billing"
        Me.cb_same_billing.Size = New System.Drawing.Size(97, 18)
        Me.cb_same_billing.TabIndex = 77
        Me.cb_same_billing.Text = "Same as billing"
        Me.cb_same_billing.UseVisualStyleBackColor = True
        '
        'LabelControl25
        '
        Me.LabelControl25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl25.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.Appearance.Options.UseForeColor = True
        Me.LabelControl25.Location = New System.Drawing.Point(17, 603)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl25.TabIndex = 67
        Me.LabelControl25.Text = "Public Comments:"
        '
        'txt_shipping
        '
        Me.txt_shipping.Location = New System.Drawing.Point(120, 320)
        Me.txt_shipping.Name = "txt_shipping"
        Me.txt_shipping.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_shipping.Properties.Appearance.Options.UseFont = True
        Me.txt_shipping.Size = New System.Drawing.Size(170, 22)
        Me.txt_shipping.TabIndex = 92
        '
        'GroupControl1
        '
        Me.GroupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl1.Controls.Add(Me.rb_epay)
        Me.GroupControl1.Controls.Add(Me.rb_cheque)
        Me.GroupControl1.Controls.Add(Me.LabelControl26)
        Me.GroupControl1.Controls.Add(Me.rb_cash)
        Me.GroupControl1.Controls.Add(Me.rb_terms)
        Me.GroupControl1.Location = New System.Drawing.Point(17, 450)
        Me.GroupControl1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GroupControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(386, 59)
        Me.GroupControl1.TabIndex = 96
        Me.GroupControl1.Text = "Shipping Method"
        '
        'rb_epay
        '
        Me.rb_epay.AutoSize = True
        Me.rb_epay.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_epay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_epay.Location = New System.Drawing.Point(109, 29)
        Me.rb_epay.Name = "rb_epay"
        Me.rb_epay.Size = New System.Drawing.Size(90, 20)
        Me.rb_epay.TabIndex = 96
        Me.rb_epay.Text = "E-Payment"
        Me.rb_epay.UseVisualStyleBackColor = True
        '
        'rb_cheque
        '
        Me.rb_cheque.AutoSize = True
        Me.rb_cheque.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_cheque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_cheque.Location = New System.Drawing.Point(273, 29)
        Me.rb_cheque.Name = "rb_cheque"
        Me.rb_cheque.Size = New System.Drawing.Size(69, 20)
        Me.rb_cheque.TabIndex = 2
        Me.rb_cheque.Text = "Cheque"
        Me.rb_cheque.UseVisualStyleBackColor = True
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Arial", 9.7!, System.Drawing.FontStyle.Bold)
        Me.LabelControl26.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.Appearance.Options.UseForeColor = True
        Me.LabelControl26.Location = New System.Drawing.Point(4, 5)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(91, 16)
        Me.LabelControl26.TabIndex = 95
        Me.LabelControl26.Text = "Payment Type"
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Checked = True
        Me.rb_cash.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_cash.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_cash.Location = New System.Drawing.Point(47, 29)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(55, 20)
        Me.rb_cash.TabIndex = 1
        Me.rb_cash.TabStop = True
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_terms
        '
        Me.rb_terms.AutoSize = True
        Me.rb_terms.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.rb_terms.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.rb_terms.Location = New System.Drawing.Point(206, 29)
        Me.rb_terms.Name = "rb_terms"
        Me.rb_terms.Size = New System.Drawing.Size(60, 20)
        Me.rb_terms.TabIndex = 0
        Me.rb_terms.Text = "Terms"
        Me.rb_terms.UseVisualStyleBackColor = True
        '
        'cbb_customer
        '
        Me.cbb_customer.Location = New System.Drawing.Point(117, 87)
        Me.cbb_customer.Name = "cbb_customer"
        Me.cbb_customer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.cbb_customer.Properties.Appearance.Options.UseFont = True
        Me.cbb_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customer.Size = New System.Drawing.Size(276, 22)
        Me.cbb_customer.TabIndex = 70
        '
        'txt_billing
        '
        Me.txt_billing.Location = New System.Drawing.Point(120, 293)
        Me.txt_billing.Name = "txt_billing"
        Me.txt_billing.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.txt_billing.Properties.Appearance.Options.UseFont = True
        Me.txt_billing.Size = New System.Drawing.Size(276, 22)
        Me.txt_billing.TabIndex = 91
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
        'GroupControl2
        '
        Me.GroupControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.GroupControl2.Controls.Add(Me.LabelControl27)
        Me.GroupControl2.Controls.Add(Me.rb_deliver)
        Me.GroupControl2.Controls.Add(Me.rb_pickup)
        Me.GroupControl2.Location = New System.Drawing.Point(17, 383)
        Me.GroupControl2.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        Me.GroupControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(386, 61)
        Me.GroupControl2.TabIndex = 89
        Me.GroupControl2.Text = "Shipping Method"
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Arial", 9.7!, System.Drawing.FontStyle.Bold)
        Me.LabelControl27.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.Appearance.Options.UseForeColor = True
        Me.LabelControl27.Location = New System.Drawing.Point(4, 5)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(108, 16)
        Me.LabelControl27.TabIndex = 95
        Me.LabelControl27.Text = "Shipping Method"
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
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl28.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.Appearance.Options.UseForeColor = True
        Me.LabelControl28.Location = New System.Drawing.Point(17, 325)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl28.TabIndex = 73
        Me.LabelControl28.Text = "Ship To"
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.LabelControl29.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.Appearance.Options.UseForeColor = True
        Me.LabelControl29.Location = New System.Drawing.Point(17, 296)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl29.TabIndex = 71
        Me.LabelControl29.Text = "Bill To"
        '
        'LabelControl30
        '
        Me.LabelControl30.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl30.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl30.Appearance.Options.UseFont = True
        Me.LabelControl30.Appearance.Options.UseForeColor = True
        Me.LabelControl30.Location = New System.Drawing.Point(17, 525)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(112, 16)
        Me.LabelControl30.TabIndex = 75
        Me.LabelControl30.Text = "Private Comments:"
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
        Me.Guna2Panel2.Controls.Add(Me.LabelControl1)
        Me.Guna2Panel2.Controls.Add(Me.lbl_total)
        Me.Guna2Panel2.Controls.Add(Me.lbl_withholding_tax_amount)
        Me.Guna2Panel2.Controls.Add(Me.lbl_withholding_tax_percentage)
        Me.Guna2Panel2.Controls.Add(Me.LabelControl5)
        Me.Guna2Panel2.Controls.Add(Me.txt_discount)
        Me.Guna2Panel2.Controls.Add(Me.lbl_delivery_fee)
        Me.Guna2Panel2.Controls.Add(Me.txt_delivery_fee)
        Me.Guna2Panel2.Controls.Add(Me.LabelControl7)
        Me.Guna2Panel2.Location = New System.Drawing.Point(697, 624)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(712, 149)
        Me.Guna2Panel2.TabIndex = 127
        '
        'lbl_invoice
        '
        Me.lbl_invoice.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_invoice.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_invoice.Appearance.Options.UseFont = True
        Me.lbl_invoice.Appearance.Options.UseForeColor = True
        Me.lbl_invoice.Location = New System.Drawing.Point(289, 80)
        Me.lbl_invoice.Name = "lbl_invoice"
        Me.lbl_invoice.Size = New System.Drawing.Size(67, 16)
        Me.lbl_invoice.TabIndex = 107
        Me.lbl_invoice.Text = "Invoice No.:"
        Me.lbl_invoice.Visible = False
        '
        'txt_invoice
        '
        Me.txt_invoice.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_invoice.EditValue = ""
        Me.txt_invoice.Location = New System.Drawing.Point(362, 77)
        Me.txt_invoice.Name = "txt_invoice"
        Me.txt_invoice.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_invoice.Properties.Appearance.Options.UseFont = True
        Me.txt_invoice.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_invoice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_invoice.Size = New System.Drawing.Size(93, 22)
        Me.txt_invoice.TabIndex = 117
        Me.txt_invoice.Visible = False
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(626, 24)
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
        Me.cb_vatable.Location = New System.Drawing.Point(351, 56)
        Me.cb_vatable.Name = "cb_vatable"
        Me.cb_vatable.Size = New System.Drawing.Size(106, 20)
        Me.cb_vatable.TabIndex = 116
        Me.cb_vatable.Text = "Vatable Sales"
        Me.cb_vatable.UseVisualStyleBackColor = True
        '
        'cb_tax_applied
        '
        Me.cb_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_tax_applied.AutoSize = True
        Me.cb_tax_applied.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cb_tax_applied.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.cb_tax_applied.Location = New System.Drawing.Point(471, 56)
        Me.cb_tax_applied.Name = "cb_tax_applied"
        Me.cb_tax_applied.Size = New System.Drawing.Size(148, 20)
        Me.cb_tax_applied.TabIndex = 112
        Me.cb_tax_applied.Text = "Apply Witholding Tax"
        Me.cb_tax_applied.UseVisualStyleBackColor = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(387, 113)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(120, 22)
        Me.LabelControl1.TabIndex = 109
        Me.LabelControl1.Text = "Total Amount"
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
        Me.lbl_total.Location = New System.Drawing.Point(517, 109)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total.Size = New System.Drawing.Size(171, 29)
        Me.lbl_total.TabIndex = 111
        Me.lbl_total.Text = "₱0.00"
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
        Me.lbl_withholding_tax_amount.Location = New System.Drawing.Point(578, 77)
        Me.lbl_withholding_tax_amount.Name = "lbl_withholding_tax_amount"
        Me.lbl_withholding_tax_amount.Size = New System.Drawing.Size(111, 14)
        Me.lbl_withholding_tax_amount.TabIndex = 115
        Me.lbl_withholding_tax_amount.Text = "₱0.00"
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
        Me.lbl_withholding_tax_percentage.Location = New System.Drawing.Point(616, 59)
        Me.lbl_withholding_tax_percentage.Name = "lbl_withholding_tax_percentage"
        Me.lbl_withholding_tax_percentage.Size = New System.Drawing.Size(73, 14)
        Me.lbl_withholding_tax_percentage.TabIndex = 113
        Me.lbl_withholding_tax_percentage.Text = "1.00%"
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(487, 29)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl5.TabIndex = 110
        Me.LabelControl5.Text = "Discount:"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.Enabled = False
        Me.txt_discount.Location = New System.Drawing.Point(562, 24)
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
        'lbl_delivery_fee
        '
        Me.lbl_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_delivery_fee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_delivery_fee.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_delivery_fee.Location = New System.Drawing.Point(248, 27)
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
        Me.txt_delivery_fee.Location = New System.Drawing.Point(382, 26)
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
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(488, 79)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl7.TabIndex = 114
        Me.LabelControl7.Text = "WT Deduction:"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Guna2Panel1.BorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel1.BorderThickness = 1
        Me.Guna2Panel1.Controls.Add(Me.LabelControl10)
        Me.Guna2Panel1.Controls.Add(Me.LabelControl11)
        Me.Guna2Panel1.Controls.Add(Me.lbl_payment_status)
        Me.Guna2Panel1.Controls.Add(Me.lbl_balance)
        Me.Guna2Panel1.Controls.Add(Me.lbl_paid_amount)
        Me.Guna2Panel1.Controls.Add(Me.LabelControl12)
        Me.Guna2Panel1.Location = New System.Drawing.Point(436, 624)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(255, 149)
        Me.Guna2Panel1.TabIndex = 126
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(10, 9)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(151, 25)
        Me.LabelControl10.TabIndex = 94
        Me.LabelControl10.Text = "Payment Status"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(10, 93)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl11.TabIndex = 106
        Me.LabelControl11.Text = "Amount to Pay"
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
        'lbl_balance
        '
        Me.lbl_balance.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_balance.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_balance.Appearance.Options.UseFont = True
        Me.lbl_balance.Appearance.Options.UseForeColor = True
        Me.lbl_balance.Appearance.Options.UseTextOptions = True
        Me.lbl_balance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_balance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_balance.Location = New System.Drawing.Point(108, 93)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(110, 18)
        Me.lbl_balance.TabIndex = 105
        Me.lbl_balance.Text = "0.00"
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
        Me.lbl_paid_amount.Location = New System.Drawing.Point(108, 72)
        Me.lbl_paid_amount.Name = "lbl_paid_amount"
        Me.lbl_paid_amount.Size = New System.Drawing.Size(110, 18)
        Me.lbl_paid_amount.TabIndex = 103
        Me.lbl_paid_amount.Text = "0.00"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(10, 72)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(75, 16)
        Me.LabelControl12.TabIndex = 104
        Me.LabelControl12.Text = "Paid Amount"
        '
        'btn_unserved
        '
        Me.btn_unserved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_unserved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_unserved.Appearance.Options.UseFont = True
        Me.btn_unserved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.article_32x321
        Me.btn_unserved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_unserved.Location = New System.Drawing.Point(1019, 89)
        Me.btn_unserved.Name = "btn_unserved"
        Me.btn_unserved.Size = New System.Drawing.Size(118, 46)
        Me.btn_unserved.TabIndex = 128
        Me.btn_unserved.Text = "Unserved"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.lbl_head)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1409, 78)
        Me.Panel2.TabIndex = 129
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.HyperlinkLabelControl3)
        Me.Panel3.Controls.Add(Me.LabelControl2)
        Me.Panel3.Controls.Add(Me.HyperlinkLabelControl4)
        Me.Panel3.Location = New System.Drawing.Point(19, 44)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(435, 27)
        Me.Panel3.TabIndex = 82
        '
        'HyperlinkLabelControl3
        '
        Me.HyperlinkLabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl3.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl3.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl3.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl3.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl3.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl3.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl3.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.Enabled = False
        Me.HyperlinkLabelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl3.Location = New System.Drawing.Point(68, 5)
        Me.HyperlinkLabelControl3.Name = "HyperlinkLabelControl3"
        Me.HyperlinkLabelControl3.ShowLineShadow = False
        Me.HyperlinkLabelControl3.Size = New System.Drawing.Size(103, 18)
        Me.HyperlinkLabelControl3.TabIndex = 7
        Me.HyperlinkLabelControl3.Text = "New Sales Order"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(53, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl2.TabIndex = 6
        Me.LabelControl2.Text = ">"
        '
        'HyperlinkLabelControl4
        '
        Me.HyperlinkLabelControl4.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl4.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl4.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl4.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl4.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl4.AppearanceDisabled.Options.UseLinkColor = True
        Me.HyperlinkLabelControl4.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl4.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl4.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl4.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl4.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl4.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl4.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl4.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl4.Location = New System.Drawing.Point(11, 5)
        Me.HyperlinkLabelControl4.Name = "HyperlinkLabelControl4"
        Me.HyperlinkLabelControl4.ShowLineShadow = False
        Me.HyperlinkLabelControl4.Size = New System.Drawing.Size(37, 18)
        Me.HyperlinkLabelControl4.TabIndex = 5
        Me.HyperlinkLabelControl4.Text = "Home"
        '
        'lbl_head
        '
        Me.lbl_head.AutoSize = True
        Me.lbl_head.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_head.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_head.Location = New System.Drawing.Point(14, 10)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(220, 31)
        Me.lbl_head.TabIndex = 81
        Me.lbl_head.Text = "New Sales Order"
        '
        'frm_sales_create_order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1409, 785)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_unserved)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.Guna2Panel3)
        Me.Controls.Add(Me.grid_order)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.grid_remaining)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_sales_create_order"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Order"
        CType(Me.txt_quote_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        CType(Me.txt_terms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sales_agent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_credits_available.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_account_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl_cid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_trucking.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_po_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_shipping.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_billing.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        Me.GroupControl2.PerformLayout()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.txt_invoice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_order As DataGridView
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_remaining As DataGridView
    Friend WithEvents txt_quote_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents txt_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact_person As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_credits_available As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_account_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_cid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_trucking As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_po_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_same_billing As CheckBox
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_shipping As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents rb_cheque As RadioButton
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_terms As RadioButton
    Friend WithEvents cbb_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_billing As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_priv_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_deliver As RadioButton
    Friend WithEvents rb_pickup As RadioButton
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pub_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_vatable As CheckBox
    Friend WithEvents cb_tax_applied As CheckBox
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_withholding_tax_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_delivery_fee As LinkLabel
    Friend WithEvents txt_delivery_fee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_payment_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_balance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_paid_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_other As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents col_on_hold As DataGridViewTextBoxColumn
    'MY EDIT
    Friend WithEvents txt_terms As System.Windows.Forms.NumericUpDown
    Friend WithEvents txt_sales_agent As TextEdit
    Friend WithEvents lbl_sales_agent As LabelControl
    Friend WithEvents lbl_terms As LabelControl
    Friend WithEvents rb_epay As RadioButton
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_sku As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents btn_unserve As DataGridViewButtonColumn
    Friend WithEvents btn_unserved As SimpleButton
    Friend WithEvents lbl_invoice As LabelControl
    Friend WithEvents txt_invoice As TextEdit
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents HyperlinkLabelControl3 As HyperlinkLabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents HyperlinkLabelControl4 As HyperlinkLabelControl
    Friend WithEvents lbl_head As Label
End Class
