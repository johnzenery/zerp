Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports DevExpress.Data.Mask
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports Inventory_Management.My.Resources


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_view_quotation
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_view_quotation))
        Me.radio_existing = New System.Windows.Forms.RadioButton()
        Me.radio_new = New System.Windows.Forms.RadioButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_customer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grid_remaining = New System.Windows.Forms.DataGridView()
        Me.col_other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_on_hold = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_quotation = New System.Windows.Forms.DataGridView()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_margin = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sku = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_contact_person = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_priv_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pub_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_decline = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_validity = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cb_apply_terms = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.txt_terms = New DevExpress.XtraEditors.TextEdit()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_account_type = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_delivery_fee = New System.Windows.Forms.LinkLabel()
        Me.txt_delivery_fee = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cb_vatable = New System.Windows.Forms.CheckBox()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.cb_tax_applied = New System.Windows.Forms.CheckBox()
        Me.txt_delivery_address = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_address = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_id = New DevExpress.XtraEditors.LabelControl()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_transfer = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_created_by = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_date_generated = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_quote_id = New Guna.UI.WinForms.GunaLabel()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cbb_validity.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_delivery_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.lbl_date_generated.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'radio_existing
        '
        Me.radio_existing.AutoSize = True
        Me.radio_existing.Enabled = False
        Me.radio_existing.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.radio_existing.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radio_existing.Location = New System.Drawing.Point(225, 24)
        Me.radio_existing.Name = "radio_existing"
        Me.radio_existing.Size = New System.Drawing.Size(72, 20)
        Me.radio_existing.TabIndex = 98
        Me.radio_existing.Text = "Existing"
        Me.radio_existing.UseVisualStyleBackColor = True
        '
        'radio_new
        '
        Me.radio_new.AutoSize = True
        Me.radio_new.Checked = True
        Me.radio_new.Enabled = False
        Me.radio_new.Font = New System.Drawing.Font("Arial", 9.7!)
        Me.radio_new.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.radio_new.Location = New System.Drawing.Point(153, 24)
        Me.radio_new.Name = "radio_new"
        Me.radio_new.Size = New System.Drawing.Size(50, 20)
        Me.radio_new.TabIndex = 97
        Me.radio_new.TabStop = True
        Me.radio_new.Text = "New"
        Me.radio_new.UseVisualStyleBackColor = True
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 26)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl3.TabIndex = 96
        Me.LabelControl3.Text = "Customer Type"
        '
        'cbb_customer
        '
        Me.cbb_customer.Location = New System.Drawing.Point(153, 52)
        Me.cbb_customer.Name = "cbb_customer"
        Me.cbb_customer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cbb_customer.Properties.Appearance.Options.UseFont = True
        Me.cbb_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customer.Size = New System.Drawing.Size(200, 22)
        Me.cbb_customer.TabIndex = 95
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
        Me.grid_remaining.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.grid_remaining.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grid_remaining.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.grid_remaining.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_remaining.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_remaining.ColumnHeadersHeight = 28
        Me.grid_remaining.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_remaining.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_other, Me.DataGridViewTextBoxColumn1, Me.col_on_hold})
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_remaining.DefaultCellStyle = DataGridViewCellStyle5
        Me.grid_remaining.Enabled = False
        Me.grid_remaining.EnableHeadersVisualStyles = False
        Me.grid_remaining.Location = New System.Drawing.Point(7, 181)
        Me.grid_remaining.MultiSelect = False
        Me.grid_remaining.Name = "grid_remaining"
        Me.grid_remaining.ReadOnly = True
        Me.grid_remaining.RowHeadersVisible = False
        Me.grid_remaining.RowTemplate.Height = 23
        Me.grid_remaining.Size = New System.Drawing.Size(162, 303)
        Me.grid_remaining.TabIndex = 94
        '
        'col_other
        '
        Me.col_other.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_other.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_other.HeaderText = "Others Stocks"
        Me.col_other.Name = "col_other"
        Me.col_other.ReadOnly = True
        Me.col_other.Width = 50
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "My Stocks"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'col_on_hold
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_on_hold.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_on_hold.HeaderText = "On Hold"
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.ReadOnly = True
        Me.col_on_hold.Width = 68
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(9, 519)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl4.TabIndex = 67
        Me.LabelControl4.Text = "Public Comments:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 55)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl1.TabIndex = 71
        Me.LabelControl1.Text = "Company"
        '
        'grid_quotation
        '
        Me.grid_quotation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_quotation.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_quotation.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_quotation.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_quotation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_quotation.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_quotation.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grid_quotation.ColumnHeadersHeight = 28
        Me.grid_quotation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_quotation.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_qty, Me.col_model, Me.col_description, Me.col_cost, Me.col_margin, Me.col_price, Me.col_sku, Me.col_total})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_quotation.DefaultCellStyle = DataGridViewCellStyle14
        Me.grid_quotation.EnableHeadersVisualStyles = False
        Me.grid_quotation.Location = New System.Drawing.Point(153, 181)
        Me.grid_quotation.Name = "grid_quotation"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_quotation.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grid_quotation.Size = New System.Drawing.Size(968, 299)
        Me.grid_quotation.TabIndex = 58
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty.DataPropertyName = "col_qty"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_cost.HeaderText = "Cost"
        Me.col_cost.MinimumWidth = 80
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Visible = False
        Me.col_cost.Width = 80
        '
        'col_margin
        '
        Me.col_margin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_margin.DefaultCellStyle = DataGridViewCellStyle10
        Me.col_margin.HeaderText = "Margin"
        Me.col_margin.MinimumWidth = 80
        Me.col_margin.Name = "col_margin"
        Me.col_margin.ReadOnly = True
        Me.col_margin.Visible = False
        Me.col_margin.Width = 80
        '
        'col_price
        '
        Me.col_price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle11.Format = "N2"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.col_price.DefaultCellStyle = DataGridViewCellStyle11
        Me.col_price.FillWeight = 102.6804!
        Me.col_price.HeaderText = "Price"
        Me.col_price.MinimumWidth = 80
        Me.col_price.Name = "col_price"
        Me.col_price.ReadOnly = True
        Me.col_price.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_price.Width = 80
        '
        'col_sku
        '
        Me.col_sku.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_sku.DefaultCellStyle = DataGridViewCellStyle12
        Me.col_sku.FillWeight = 80.0!
        Me.col_sku.HeaderText = "DISC."
        Me.col_sku.MinimumWidth = 50
        Me.col_sku.Name = "col_sku"
        Me.col_sku.Width = 50
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle13
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'txt_contact_person
        '
        Me.txt_contact_person.Location = New System.Drawing.Point(153, 80)
        Me.txt_contact_person.Name = "txt_contact_person"
        Me.txt_contact_person.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact_person.Properties.Appearance.Options.UseFont = True
        Me.txt_contact_person.Size = New System.Drawing.Size(200, 22)
        Me.txt_contact_person.TabIndex = 93
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 83)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 16)
        Me.LabelControl2.TabIndex = 92
        Me.LabelControl2.Text = "Contact Person"
        '
        'txt_priv_notes
        '
        Me.txt_priv_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_priv_notes.Location = New System.Drawing.Point(333, 544)
        Me.txt_priv_notes.Name = "txt_priv_notes"
        Me.txt_priv_notes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_priv_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_notes.Size = New System.Drawing.Size(307, 71)
        Me.txt_priv_notes.TabIndex = 76
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(333, 519)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(110, 16)
        Me.LabelControl5.TabIndex = 75
        Me.LabelControl5.Text = "Private Comments:"
        '
        'txt_pub_notes
        '
        Me.txt_pub_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_pub_notes.Location = New System.Drawing.Point(9, 544)
        Me.txt_pub_notes.Name = "txt_pub_notes"
        Me.txt_pub_notes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_pub_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_notes.Size = New System.Drawing.Size(307, 71)
        Me.txt_pub_notes.TabIndex = 68
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btn_decline)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.cbb_validity)
        Me.PanelControl1.Controls.Add(Me.cb_apply_terms)
        Me.PanelControl1.Controls.Add(Me.txt_terms)
        Me.PanelControl1.Controls.Add(Me.btn_approved)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.lbl_account_type)
        Me.PanelControl1.Controls.Add(Me.Panel1)
        Me.PanelControl1.Controls.Add(Me.txt_delivery_address)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.txt_address)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_no)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.lbl_id)
        Me.PanelControl1.Controls.Add(Me.btn_delete)
        Me.PanelControl1.Controls.Add(Me.btn_print)
        Me.PanelControl1.Controls.Add(Me.btn_save)
        Me.PanelControl1.Controls.Add(Me.radio_existing)
        Me.PanelControl1.Controls.Add(Me.radio_new)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.cbb_customer)
        Me.PanelControl1.Controls.Add(Me.grid_quotation)
        Me.PanelControl1.Controls.Add(Me.grid_remaining)
        Me.PanelControl1.Controls.Add(Me.txt_contact_person)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txt_priv_notes)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txt_pub_notes)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.btn_transfer)
        Me.PanelControl1.Controls.Add(Me.txt_customer)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 102)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1141, 626)
        Me.PanelControl1.TabIndex = 56
        '
        'btn_decline
        '
        Me.btn_decline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_decline.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_decline.Appearance.Options.UseFont = True
        Me.btn_decline.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.cancel_16x16
        Me.btn_decline.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_decline.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.BottomCenter
        Me.btn_decline.Location = New System.Drawing.Point(1061, 79)
        Me.btn_decline.Name = "btn_decline"
        Me.btn_decline.Size = New System.Drawing.Size(60, 44)
        Me.btn_decline.TabIndex = 127
        Me.btn_decline.Text = "Decline"
        Me.btn_decline.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(1006, 156)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl6.TabIndex = 126
        Me.LabelControl6.Text = "Validity"
        '
        'cbb_validity
        '
        Me.cbb_validity.Location = New System.Drawing.Point(1071, 153)
        Me.cbb_validity.Name = "cbb_validity"
        Me.cbb_validity.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cbb_validity.Properties.Appearance.Options.UseFont = True
        Me.cbb_validity.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_validity.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_validity.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_validity.Properties.Items.AddRange(New Object() {"7", "15", "30"})
        Me.cbb_validity.Size = New System.Drawing.Size(50, 22)
        Me.cbb_validity.TabIndex = 125
        '
        'cb_apply_terms
        '
        Me.cb_apply_terms.AutoSize = True
        Me.cb_apply_terms.Checked = True
        Me.cb_apply_terms.CheckedState.BorderColor = System.Drawing.Color.Red
        Me.cb_apply_terms.CheckedState.BorderRadius = 2
        Me.cb_apply_terms.CheckedState.BorderThickness = 0
        Me.cb_apply_terms.CheckedState.FillColor = System.Drawing.Color.Red
        Me.cb_apply_terms.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_apply_terms.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.cb_apply_terms.ForeColor = System.Drawing.Color.Black
        Me.cb_apply_terms.Location = New System.Drawing.Point(970, 127)
        Me.cb_apply_terms.Name = "cb_apply_terms"
        Me.cb_apply_terms.Size = New System.Drawing.Size(98, 20)
        Me.cb_apply_terms.TabIndex = 124
        Me.cb_apply_terms.Text = "Apply Terms"
        Me.cb_apply_terms.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_apply_terms.UncheckedState.BorderRadius = 2
        Me.cb_apply_terms.UncheckedState.BorderThickness = 0
        Me.cb_apply_terms.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.cb_apply_terms.UseVisualStyleBackColor = True
        '
        'txt_terms
        '
        Me.txt_terms.Location = New System.Drawing.Point(1071, 127)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terms.Properties.Appearance.Options.UseFont = True
        Me.txt_terms.Size = New System.Drawing.Size(50, 22)
        Me.txt_terms.TabIndex = 123
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x321
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_approved.Location = New System.Drawing.Point(1061, 61)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(60, 60)
        Me.btn_approved.TabIndex = 122
        Me.btn_approved.Text = "Approve"
        Me.btn_approved.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(20, 139)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl12.TabIndex = 121
        Me.LabelControl12.Text = "Account Type:"
        '
        'lbl_account_type
        '
        Me.lbl_account_type.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_type.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_account_type.Appearance.Options.UseFont = True
        Me.lbl_account_type.Appearance.Options.UseForeColor = True
        Me.lbl_account_type.Location = New System.Drawing.Point(153, 139)
        Me.lbl_account_type.Name = "lbl_account_type"
        Me.lbl_account_type.Size = New System.Drawing.Size(23, 16)
        Me.lbl_account_type.TabIndex = 120
        Me.lbl_account_type.Text = "N/A"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.lbl_delivery_fee)
        Me.Panel1.Controls.Add(Me.txt_delivery_fee)
        Me.Panel1.Controls.Add(Me.cbb_discount)
        Me.Panel1.Controls.Add(Me.cb_vatable)
        Me.Panel1.Controls.Add(Me.LabelControl11)
        Me.Panel1.Controls.Add(Me.lbl_withholding_tax_amount)
        Me.Panel1.Controls.Add(Me.LabelControl9)
        Me.Panel1.Controls.Add(Me.LabelControl14)
        Me.Panel1.Controls.Add(Me.txt_discount)
        Me.Panel1.Controls.Add(Me.lbl_withholding_tax_percentage)
        Me.Panel1.Controls.Add(Me.lbl_total)
        Me.Panel1.Controls.Add(Me.cb_tax_applied)
        Me.Panel1.Location = New System.Drawing.Point(662, 485)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(458, 136)
        Me.Panel1.TabIndex = 118
        '
        'lbl_delivery_fee
        '
        Me.lbl_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_delivery_fee.BackColor = System.Drawing.Color.Transparent
        Me.lbl_delivery_fee.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.lbl_delivery_fee.Location = New System.Drawing.Point(12, 14)
        Me.lbl_delivery_fee.Name = "lbl_delivery_fee"
        Me.lbl_delivery_fee.Size = New System.Drawing.Size(130, 18)
        Me.lbl_delivery_fee.TabIndex = 123
        Me.lbl_delivery_fee.TabStop = True
        Me.lbl_delivery_fee.Text = "Add Delivery Fee"
        Me.lbl_delivery_fee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_delivery_fee
        '
        Me.txt_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_delivery_fee.EditValue = ""
        Me.txt_delivery_fee.Enabled = False
        Me.txt_delivery_fee.Location = New System.Drawing.Point(146, 13)
        Me.txt_delivery_fee.Name = "txt_delivery_fee"
        Me.txt_delivery_fee.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.txt_delivery_fee.Properties.Appearance.Options.UseFont = True
        Me.txt_delivery_fee.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_delivery_fee.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_delivery_fee.Size = New System.Drawing.Size(93, 22)
        Me.txt_delivery_fee.TabIndex = 122
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(393, 13)
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
        Me.cb_vatable.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_vatable.Location = New System.Drawing.Point(131, 44)
        Me.cb_vatable.Name = "cb_vatable"
        Me.cb_vatable.Size = New System.Drawing.Size(98, 18)
        Me.cb_vatable.TabIndex = 116
        Me.cb_vatable.Text = "Vatable Sales"
        Me.cb_vatable.UseVisualStyleBackColor = True
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(158, 101)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(120, 22)
        Me.LabelControl11.TabIndex = 109
        Me.LabelControl11.Text = "Total Amount"
        '
        'lbl_withholding_tax_amount
        '
        Me.lbl_withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_withholding_tax_amount.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_amount.Location = New System.Drawing.Point(345, 66)
        Me.lbl_withholding_tax_amount.Name = "lbl_withholding_tax_amount"
        Me.lbl_withholding_tax_amount.Size = New System.Drawing.Size(111, 14)
        Me.lbl_withholding_tax_amount.TabIndex = 115
        Me.lbl_withholding_tax_amount.Text = "₱0.00"
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(254, 18)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl9.TabIndex = 110
        Me.LabelControl9.Text = "Discount:"
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(255, 68)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(84, 14)
        Me.LabelControl14.TabIndex = 114
        Me.LabelControl14.Text = "WT Deduction:"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.Enabled = False
        Me.txt_discount.Location = New System.Drawing.Point(329, 13)
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
        Me.lbl_withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_percentage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_percentage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_percentage.Location = New System.Drawing.Point(383, 48)
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
        Me.lbl_total.Location = New System.Drawing.Point(284, 98)
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
        Me.cb_tax_applied.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_tax_applied.Location = New System.Drawing.Point(235, 44)
        Me.cb_tax_applied.Name = "cb_tax_applied"
        Me.cb_tax_applied.Size = New System.Drawing.Size(142, 18)
        Me.cb_tax_applied.TabIndex = 112
        Me.cb_tax_applied.Text = "Apply Witholding Tax"
        Me.cb_tax_applied.UseVisualStyleBackColor = True
        '
        'txt_delivery_address
        '
        Me.txt_delivery_address.Location = New System.Drawing.Point(509, 102)
        Me.txt_delivery_address.Name = "txt_delivery_address"
        Me.txt_delivery_address.Size = New System.Drawing.Size(318, 53)
        Me.txt_delivery_address.TabIndex = 106
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(509, 80)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl10.TabIndex = 109
        Me.LabelControl10.Text = "Delivery Address:"
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(509, 52)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_address.Properties.Appearance.Options.UseFont = True
        Me.txt_address.Size = New System.Drawing.Size(318, 22)
        Me.txt_address.TabIndex = 105
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(509, 30)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl8.TabIndex = 108
        Me.LabelControl8.Text = "Office Address"
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(153, 108)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_no.Properties.Appearance.Options.UseFont = True
        Me.txt_no.Size = New System.Drawing.Size(200, 22)
        Me.txt_no.TabIndex = 104
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Black
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(20, 111)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl7.TabIndex = 107
        Me.LabelControl7.Text = "Contact No.:"
        '
        'lbl_id
        '
        Me.lbl_id.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_id.Appearance.Options.UseFont = True
        Me.lbl_id.Appearance.Options.UseForeColor = True
        Me.lbl_id.Location = New System.Drawing.Point(20, 5)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(10, 16)
        Me.lbl_id.TabIndex = 102
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(862, 15)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(60, 60)
        Me.btn_delete.TabIndex = 101
        Me.btn_delete.Text = "Delete"
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x321
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(928, 15)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(60, 60)
        Me.btn_print.TabIndex = 100
        Me.btn_print.Text = "Print"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_save.Location = New System.Drawing.Point(994, 15)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(60, 60)
        Me.btn_save.TabIndex = 99
        Me.btn_save.Text = "Save"
        '
        'btn_transfer
        '
        Me.btn_transfer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_transfer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_transfer.Appearance.Options.UseFont = True
        Me.btn_transfer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.movepivottable_32x32
        Me.btn_transfer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_transfer.Location = New System.Drawing.Point(1060, 14)
        Me.btn_transfer.Name = "btn_transfer"
        Me.btn_transfer.Size = New System.Drawing.Size(60, 60)
        Me.btn_transfer.TabIndex = 6
        Me.btn_transfer.Text = "Transfer"
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(153, 52)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer.Properties.Appearance.Options.UseFont = True
        Me.txt_customer.Size = New System.Drawing.Size(339, 22)
        Me.txt_customer.TabIndex = 91
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.lbl_created_by)
        Me.GunaPanel2.Controls.Add(Me.lbl_date_generated)
        Me.GunaPanel2.Controls.Add(Me.lbl_quote_id)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1165, 78)
        Me.GunaPanel2.TabIndex = 55
        '
        'lbl_created_by
        '
        Me.lbl_created_by.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_created_by.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_created_by.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_created_by.Appearance.Options.UseFont = True
        Me.lbl_created_by.Appearance.Options.UseForeColor = True
        Me.lbl_created_by.Appearance.Options.UseTextOptions = True
        Me.lbl_created_by.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_created_by.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_created_by.Location = New System.Drawing.Point(753, 47)
        Me.lbl_created_by.Name = "lbl_created_by"
        Me.lbl_created_by.Size = New System.Drawing.Size(400, 20)
        Me.lbl_created_by.TabIndex = 77
        Me.lbl_created_by.Text = "Created by"
        '
        'lbl_date_generated
        '
        Me.lbl_date_generated.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_date_generated.EditValue = "Date Generated"
        Me.lbl_date_generated.Location = New System.Drawing.Point(802, 12)
        Me.lbl_date_generated.Name = "lbl_date_generated"
        Me.lbl_date_generated.Properties.AllowFocused = False
        Me.lbl_date_generated.Properties.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.lbl_date_generated.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_date_generated.Properties.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.lbl_date_generated.Properties.Appearance.Options.UseBackColor = True
        Me.lbl_date_generated.Properties.Appearance.Options.UseFont = True
        Me.lbl_date_generated.Properties.Appearance.Options.UseForeColor = True
        Me.lbl_date_generated.Properties.Appearance.Options.UseTextOptions = True
        Me.lbl_date_generated.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_date_generated.Properties.AutoHeight = False
        Me.lbl_date_generated.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_date_generated.Properties.ReadOnly = True
        Me.lbl_date_generated.Properties.UseReadOnlyAppearance = False
        Me.lbl_date_generated.Size = New System.Drawing.Size(351, 34)
        Me.lbl_date_generated.TabIndex = 78
        Me.lbl_date_generated.TabStop = False
        '
        'lbl_quote_id
        '
        Me.lbl_quote_id.AutoSize = True
        Me.lbl_quote_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_quote_id.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_quote_id.Location = New System.Drawing.Point(12, 26)
        Me.lbl_quote_id.Name = "lbl_quote_id"
        Me.lbl_quote_id.Size = New System.Drawing.Size(154, 31)
        Me.lbl_quote_id.TabIndex = 1
        Me.lbl_quote_id.Text = "Quotation #"
        '
        'frm_sales_view_quotation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1165, 737)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_view_quotation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Quotation"
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_remaining, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_quotation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact_person.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cbb_validity.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_delivery_fee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_delivery_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.lbl_date_generated.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents radio_existing As RadioButton
    Friend WithEvents radio_new As RadioButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents grid_remaining As DataGridView
    Friend WithEvents col_other As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents col_on_hold As DataGridViewTextBoxColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_quotation As DataGridView
    Friend WithEvents txt_contact_person As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_priv_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pub_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_transfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_quote_id As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_delivery_address As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_address As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cb_vatable As CheckBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_withholding_tax_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_tax_applied As CheckBox
    'MY EDIT
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_account_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_delivery_fee As LinkLabel
    Friend WithEvents txt_delivery_fee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cb_apply_terms As Guna2CheckBox
    Friend WithEvents txt_terms As TextEdit
    Friend WithEvents LabelControl6 As LabelControl
    Friend WithEvents cbb_validity As ComboBoxEdit
    Friend WithEvents lbl_created_by As LabelControl
    Friend WithEvents lbl_date_generated As TextEdit
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_margin As DataGridViewTextBoxColumn
    Friend WithEvents col_price As DataGridViewTextBoxColumn
    Friend WithEvents col_sku As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents btn_decline As SimpleButton
End Class
