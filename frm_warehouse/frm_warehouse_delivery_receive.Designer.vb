Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_delivery_receive
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_purchaser_name = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_dr_date = New DevExpress.XtraEditors.DateEdit()
        Me.cbb_tax_type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.dt_si_date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dr_no = New DevExpress.XtraEditors.TextEdit()
        Me.txt_si_no = New DevExpress.XtraEditors.TextEdit()
        Me.is_withholding_tax_applied = New System.Windows.Forms.CheckBox()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_grand_total = New DevExpress.XtraEditors.TextEdit()
        Me.txt_date_sent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_receive_date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_order = New System.Windows.Forms.DataGridView()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_search = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_return_credit = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_count_by = New DevExpress.XtraEditors.TextEdit()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_supid = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.btn_mark = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_poid = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_deliver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_head = New DevExpress.XtraEditors.LabelControl()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sup_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_base_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_tota_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_remaining_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_isBundle = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.dt_dr_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dr_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_tax_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_si_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_si_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dr_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_si_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_grand_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_date_sent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_receive_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_receive_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_return_credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.PanelControl1.Controls.Add(Me.lbl_purchaser_name)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.GroupControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.txt_grand_total)
        Me.PanelControl1.Controls.Add(Me.txt_date_sent)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.dt_receive_date)
        Me.PanelControl1.Controls.Add(Me.LabelControl11)
        Me.PanelControl1.Controls.Add(Me.grid_order)
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.txt_search)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.withholding_tax_percentage)
        Me.PanelControl1.Controls.Add(Me.cbb_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_return_credit)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txt_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl7)
        Me.PanelControl1.Controls.Add(Me.txt_count_by)
        Me.PanelControl1.Controls.Add(Me.btn_print)
        Me.PanelControl1.Controls.Add(Me.txt_supid)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.txt_amount)
        Me.PanelControl1.Controls.Add(Me.btn_mark)
        Me.PanelControl1.Controls.Add(Me.btn_save)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txt_poid)
        Me.PanelControl1.Controls.Add(Me.cbb_deliver)
        Me.PanelControl1.Controls.Add(Me.cbb_supplier)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Location = New System.Drawing.Point(-4, 54)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1165, 533)
        Me.PanelControl1.TabIndex = 53
        '
        'lbl_purchaser_name
        '
        Me.lbl_purchaser_name.Location = New System.Drawing.Point(96, 125)
        Me.lbl_purchaser_name.Name = "lbl_purchaser_name"
        Me.lbl_purchaser_name.Size = New System.Drawing.Size(27, 13)
        Me.lbl_purchaser_name.TabIndex = 142
        Me.lbl_purchaser_name.Text = "Name"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(22, 125)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl2.TabIndex = 141
        Me.LabelControl2.Text = "Purchaser"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.LabelControl15)
        Me.GroupControl1.Controls.Add(Me.LabelControl20)
        Me.GroupControl1.Controls.Add(Me.dt_dr_date)
        Me.GroupControl1.Controls.Add(Me.cbb_tax_type)
        Me.GroupControl1.Controls.Add(Me.dt_si_date)
        Me.GroupControl1.Controls.Add(Me.LabelControl19)
        Me.GroupControl1.Controls.Add(Me.txt_dr_no)
        Me.GroupControl1.Controls.Add(Me.txt_si_no)
        Me.GroupControl1.Controls.Add(Me.is_withholding_tax_applied)
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light
        Me.GroupControl1.Location = New System.Drawing.Point(574, 12)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(309, 134)
        Me.GroupControl1.TabIndex = 140
        Me.GroupControl1.Text = "Receipt Information"
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(15, 33)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl15.TabIndex = 134
        Me.LabelControl15.Text = "DR No. && Date"
        '
        'LabelControl20
        '
        Me.LabelControl20.Location = New System.Drawing.Point(40, 101)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(45, 13)
        Me.LabelControl20.TabIndex = 139
        Me.LabelControl20.Text = "Tax Type"
        '
        'dt_dr_date
        '
        Me.dt_dr_date.EditValue = Nothing
        Me.dt_dr_date.Location = New System.Drawing.Point(197, 26)
        Me.dt_dr_date.Name = "dt_dr_date"
        Me.dt_dr_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_dr_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_dr_date.Properties.DisplayFormat.FormatString = "MM/dd/yyyy "
        Me.dt_dr_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_dr_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_dr_date.Size = New System.Drawing.Size(100, 28)
        Me.dt_dr_date.TabIndex = 130
        '
        'cbb_tax_type
        '
        Me.cbb_tax_type.Location = New System.Drawing.Point(91, 94)
        Me.cbb_tax_type.Name = "cbb_tax_type"
        Me.cbb_tax_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_tax_type.Properties.Items.AddRange(New Object() {"NON-VAT", "VAT"})
        Me.cbb_tax_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_tax_type.Size = New System.Drawing.Size(100, 28)
        Me.cbb_tax_type.TabIndex = 138
        '
        'dt_si_date
        '
        Me.dt_si_date.EditValue = Nothing
        Me.dt_si_date.Location = New System.Drawing.Point(197, 60)
        Me.dt_si_date.Name = "dt_si_date"
        Me.dt_si_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_si_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_si_date.Properties.DisplayFormat.FormatString = "MM/dd/yyyy "
        Me.dt_si_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_si_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_si_date.Size = New System.Drawing.Size(100, 28)
        Me.dt_si_date.TabIndex = 131
        '
        'LabelControl19
        '
        Me.LabelControl19.Location = New System.Drawing.Point(19, 67)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(66, 13)
        Me.LabelControl19.TabIndex = 136
        Me.LabelControl19.Text = "SI No. && Date"
        '
        'txt_dr_no
        '
        Me.txt_dr_no.Location = New System.Drawing.Point(91, 26)
        Me.txt_dr_no.Name = "txt_dr_no"
        Me.txt_dr_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_dr_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_dr_no.Size = New System.Drawing.Size(100, 28)
        Me.txt_dr_no.TabIndex = 132
        '
        'txt_si_no
        '
        Me.txt_si_no.Location = New System.Drawing.Point(91, 60)
        Me.txt_si_no.Name = "txt_si_no"
        Me.txt_si_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_si_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_si_no.Size = New System.Drawing.Size(100, 28)
        Me.txt_si_no.TabIndex = 133
        '
        'is_withholding_tax_applied
        '
        Me.is_withholding_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.is_withholding_tax_applied.AutoSize = True
        Me.is_withholding_tax_applied.Enabled = False
        Me.is_withholding_tax_applied.Location = New System.Drawing.Point(197, 101)
        Me.is_withholding_tax_applied.Name = "is_withholding_tax_applied"
        Me.is_withholding_tax_applied.Size = New System.Drawing.Size(103, 17)
        Me.is_withholding_tax_applied.TabIndex = 101
        Me.is_withholding_tax_applied.Text = "Withholding Tax"
        Me.is_withholding_tax_applied.UseVisualStyleBackColor = True
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(899, 437)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl14.TabIndex = 129
        Me.LabelControl14.Text = "Grand Total"
        '
        'txt_grand_total
        '
        Me.txt_grand_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_grand_total.EditValue = "0.00"
        Me.txt_grand_total.Location = New System.Drawing.Point(997, 431)
        Me.txt_grand_total.Name = "txt_grand_total"
        Me.txt_grand_total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.txt_grand_total.Properties.Appearance.Options.UseFont = True
        Me.txt_grand_total.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_grand_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_grand_total.Properties.DisplayFormat.FormatString = "c2"
        Me.txt_grand_total.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_grand_total.Properties.ReadOnly = True
        Me.txt_grand_total.Size = New System.Drawing.Size(153, 28)
        Me.txt_grand_total.TabIndex = 128
        '
        'txt_date_sent
        '
        Me.txt_date_sent.Location = New System.Drawing.Point(259, 28)
        Me.txt_date_sent.Name = "txt_date_sent"
        Me.txt_date_sent.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_date_sent.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_date_sent.Properties.ReadOnly = True
        Me.txt_date_sent.Size = New System.Drawing.Size(96, 28)
        Me.txt_date_sent.TabIndex = 125
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(197, 30)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(48, 13)
        Me.LabelControl12.TabIndex = 124
        Me.LabelControl12.Text = "Date Sent"
        '
        'dt_receive_date
        '
        Me.dt_receive_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dt_receive_date.EditValue = Nothing
        Me.dt_receive_date.Location = New System.Drawing.Point(900, 28)
        Me.dt_receive_date.Name = "dt_receive_date"
        Me.dt_receive_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_receive_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_receive_date.Properties.DisplayFormat.FormatString = "MM/dd/yyyy "
        Me.dt_receive_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_receive_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_receive_date.Size = New System.Drawing.Size(100, 28)
        Me.dt_receive_date.TabIndex = 123
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Location = New System.Drawing.Point(900, 9)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl11.TabIndex = 122
        Me.LabelControl11.Text = "Received Date"
        '
        'grid_order
        '
        Me.grid_order.AllowUserToAddRows = False
        Me.grid_order.AllowUserToDeleteRows = False
        Me.grid_order.AllowUserToResizeRows = False
        Me.grid_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_order.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_order.ColumnHeadersHeight = 32
        Me.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.col_sup_model, Me.DataGridViewTextBoxColumn4, Me.col_base_price, Me.col_discount, Me.col_total, Me.col_tota_received, Me.col_received, Me.col_remaining_qty, Me.col_cost, Me.total_cost, Me.col_isBundle})
        Me.grid_order.EnableHeadersVisualStyles = False
        Me.grid_order.Location = New System.Drawing.Point(22, 179)
        Me.grid_order.Name = "grid_order"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grid_order.RowHeadersWidth = 30
        Me.grid_order.RowTemplate.Height = 23
        Me.grid_order.Size = New System.Drawing.Size(1128, 246)
        Me.grid_order.TabIndex = 121
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(22, 152)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(33, 13)
        Me.LabelControl16.TabIndex = 120
        Me.LabelControl16.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Location = New System.Drawing.Point(62, 145)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_search.Size = New System.Drawing.Size(152, 28)
        Me.txt_search.TabIndex = 119
        Me.txt_search.TabStop = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Location = New System.Drawing.Point(997, 504)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(19, 13)
        Me.LabelControl10.TabIndex = 104
        Me.LabelControl10.Text = "PHP"
        '
        'withholding_tax_percentage
        '
        Me.withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Tahoma", 8.5!)
        Me.withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.withholding_tax_percentage.Location = New System.Drawing.Point(730, 506)
        Me.withholding_tax_percentage.Name = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Size = New System.Drawing.Size(137, 13)
        Me.withholding_tax_percentage.TabIndex = 103
        Me.withholding_tax_percentage.Text = "withholding_tax_percentage"
        Me.withholding_tax_percentage.Visible = False
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(1082, 463)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.cbb_discount.Properties.Appearance.Options.UseFont = True
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"peso", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(67, 28)
        Me.cbb_discount.TabIndex = 100
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Location = New System.Drawing.Point(905, 504)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl8.TabIndex = 98
        Me.LabelControl8.Text = "Return Credit"
        '
        'txt_return_credit
        '
        Me.txt_return_credit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_return_credit.EditValue = "0.00"
        Me.txt_return_credit.Location = New System.Drawing.Point(1024, 497)
        Me.txt_return_credit.Name = "txt_return_credit"
        Me.txt_return_credit.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_return_credit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_return_credit.Size = New System.Drawing.Size(125, 28)
        Me.txt_return_credit.TabIndex = 99
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Location = New System.Drawing.Point(929, 470)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(41, 13)
        Me.LabelControl9.TabIndex = 97
        Me.LabelControl9.Text = "Discount"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.EditValue = "0.00"
        Me.txt_discount.Location = New System.Drawing.Point(997, 463)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_discount.Size = New System.Drawing.Size(82, 28)
        Me.txt_discount.TabIndex = 96
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Location = New System.Drawing.Point(900, 119)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl7.TabIndex = 94
        Me.LabelControl7.Text = "Counted by"
        '
        'txt_count_by
        '
        Me.txt_count_by.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_count_by.Location = New System.Drawing.Point(900, 137)
        Me.txt_count_by.Name = "txt_count_by"
        Me.txt_count_by.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_count_by.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_count_by.Size = New System.Drawing.Size(100, 28)
        Me.txt_count_by.TabIndex = 93
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        Me.btn_print.Location = New System.Drawing.Point(1024, 16)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(60, 60)
        Me.btn_print.TabIndex = 95
        Me.btn_print.Text = "Print"
        '
        'txt_supid
        '
        Me.txt_supid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.txt_supid.Appearance.Options.UseFont = True
        Me.txt_supid.Location = New System.Drawing.Point(361, 56)
        Me.txt_supid.Name = "txt_supid"
        Me.txt_supid.Size = New System.Drawing.Size(28, 14)
        Me.txt_supid.TabIndex = 92
        Me.txt_supid.Text = "supid"
        Me.txt_supid.Visible = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Location = New System.Drawing.Point(900, 65)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(49, 13)
        Me.LabelControl4.TabIndex = 91
        Me.LabelControl4.Text = "Total Cost"
        '
        'txt_amount
        '
        Me.txt_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_amount.Location = New System.Drawing.Point(900, 84)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_amount.Size = New System.Drawing.Size(100, 28)
        Me.txt_amount.TabIndex = 90
        '
        'btn_mark
        '
        Me.btn_mark.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_mark.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.checkbox_16x161
        Me.btn_mark.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_mark.Location = New System.Drawing.Point(20, 478)
        Me.btn_mark.Name = "btn_mark"
        Me.btn_mark.Size = New System.Drawing.Size(162, 32)
        Me.btn_mark.TabIndex = 85
        Me.btn_mark.Text = "Mark as Completed"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_save.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract1
        Me.btn_save.Location = New System.Drawing.Point(1090, 16)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(60, 60)
        Me.btn_save.TabIndex = 72
        Me.btn_save.Text = "Save"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(22, 32)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl5.TabIndex = 69
        Me.LabelControl5.Text = "Purchase ID"
        '
        'txt_poid
        '
        Me.txt_poid.Location = New System.Drawing.Point(96, 27)
        Me.txt_poid.Name = "txt_poid"
        Me.txt_poid.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_poid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_poid.Properties.ReadOnly = True
        Me.txt_poid.Size = New System.Drawing.Size(86, 28)
        Me.txt_poid.TabIndex = 70
        '
        'cbb_deliver
        '
        Me.cbb_deliver.Location = New System.Drawing.Point(96, 89)
        Me.cbb_deliver.Name = "cbb_deliver"
        Me.cbb_deliver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_deliver.Properties.ReadOnly = True
        Me.cbb_deliver.Properties.UseReadOnlyAppearance = False
        Me.cbb_deliver.Size = New System.Drawing.Size(259, 28)
        Me.cbb_deliver.TabIndex = 65
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(96, 58)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Properties.ReadOnly = True
        Me.cbb_supplier.Properties.UseReadOnlyAppearance = False
        Me.cbb_supplier.Size = New System.Drawing.Size(259, 28)
        Me.cbb_supplier.TabIndex = 43
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 62)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(38, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier"
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(22, 91)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl6.TabIndex = 49
        Me.LabelControl6.Text = "Deliver to"
        '
        'lbl_head
        '
        Me.lbl_head.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_head.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_head.Appearance.Options.UseFont = True
        Me.lbl_head.Appearance.Options.UseForeColor = True
        Me.lbl_head.Location = New System.Drawing.Point(13, 13)
        Me.lbl_head.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(205, 31)
        Me.lbl_head.TabIndex = 55
        Me.lbl_head.Text = "Receive Delivery"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "pid"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "PID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "qty"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn2.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "winmodel"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn3.FillWeight = 73.71088!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Win. Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'col_sup_model
        '
        Me.col_sup_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_sup_model.DataPropertyName = "supmodel"
        Me.col_sup_model.HeaderText = "Sup. Model"
        Me.col_sup_model.Name = "col_sup_model"
        Me.col_sup_model.ReadOnly = True
        Me.col_sup_model.Visible = False
        Me.col_sup_model.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "description"
        Me.DataGridViewTextBoxColumn4.FillWeight = 137.4594!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'col_base_price
        '
        Me.col_base_price.DataPropertyName = "base_price"
        Me.col_base_price.HeaderText = "Base Price"
        Me.col_base_price.Name = "col_base_price"
        Me.col_base_price.ReadOnly = True
        Me.col_base_price.Width = 75
        '
        'col_discount
        '
        Me.col_discount.DataPropertyName = "discount"
        Me.col_discount.HeaderText = "Discount"
        Me.col_discount.Name = "col_discount"
        Me.col_discount.ReadOnly = True
        Me.col_discount.Width = 73
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_total.DataPropertyName = "total"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "n2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_total.Visible = False
        '
        'col_tota_received
        '
        Me.col_tota_received.DataPropertyName = "total_received"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_tota_received.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_tota_received.HeaderText = "Total Received"
        Me.col_tota_received.Name = "col_tota_received"
        Me.col_tota_received.ReadOnly = True
        Me.col_tota_received.Width = 95
        '
        'col_received
        '
        Me.col_received.DataPropertyName = "qty_received"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_received.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_received.HeaderText = "QTY. Received"
        Me.col_received.Name = "col_received"
        Me.col_received.Width = 95
        '
        'col_remaining_qty
        '
        Me.col_remaining_qty.DataPropertyName = "remaining"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_remaining_qty.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_remaining_qty.HeaderText = "Remaining"
        Me.col_remaining_qty.Name = "col_remaining_qty"
        Me.col_remaining_qty.ReadOnly = True
        Me.col_remaining_qty.Width = 81
        '
        'col_cost
        '
        Me.col_cost.DataPropertyName = "cost"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle9.Format = "n2"
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_cost.HeaderText = "Cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Width = 54
        '
        'total_cost
        '
        Me.total_cost.DataPropertyName = "total_cost"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle10.Format = "N2"
        DataGridViewCellStyle10.NullValue = "0.00"
        Me.total_cost.DefaultCellStyle = DataGridViewCellStyle10
        Me.total_cost.HeaderText = "Total Cost"
        Me.total_cost.Name = "total_cost"
        Me.total_cost.ReadOnly = True
        Me.total_cost.Width = 75
        '
        'col_isBundle
        '
        Me.col_isBundle.DataPropertyName = "is_bundle"
        Me.col_isBundle.HeaderText = "Is Bundle"
        Me.col_isBundle.Name = "col_isBundle"
        Me.col_isBundle.ReadOnly = True
        Me.col_isBundle.Visible = False
        Me.col_isBundle.Width = 51
        '
        'frm_warehouse_delivery_receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 587)
        Me.Controls.Add(Me.lbl_head)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_warehouse_delivery_receive"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frm_warehouse_delivery_receive"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        CType(Me.dt_dr_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dr_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_tax_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_si_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_si_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dr_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_si_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_grand_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_date_sent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_receive_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_receive_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_return_credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_poid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_deliver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_mark As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_supid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_count_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_return_credit As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents is_withholding_tax_applied As CheckBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As LabelControl
    Friend WithEvents txt_search As TextEdit
    Friend WithEvents grid_order As DataGridView
    Friend WithEvents dt_receive_date As DateEdit
    Friend WithEvents LabelControl11 As LabelControl
    Friend WithEvents txt_date_sent As TextEdit
    Friend WithEvents LabelControl12 As LabelControl
    Friend WithEvents lbl_head As LabelControl
    Friend WithEvents LabelControl14 As LabelControl
    Friend WithEvents txt_grand_total As TextEdit
    Friend WithEvents LabelControl19 As LabelControl
    Friend WithEvents LabelControl15 As LabelControl
    Friend WithEvents txt_si_no As TextEdit
    Friend WithEvents txt_dr_no As TextEdit
    Friend WithEvents dt_si_date As DateEdit
    Friend WithEvents dt_dr_date As DateEdit
    Friend WithEvents LabelControl20 As LabelControl
    Friend WithEvents cbb_tax_type As ComboBoxEdit
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents lbl_purchaser_name As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents col_sup_model As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents col_base_price As DataGridViewTextBoxColumn
    Friend WithEvents col_discount As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents col_tota_received As DataGridViewTextBoxColumn
    Friend WithEvents col_received As DataGridViewTextBoxColumn
    Friend WithEvents col_remaining_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents total_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_isBundle As DataGridViewCheckBoxColumn
End Class
