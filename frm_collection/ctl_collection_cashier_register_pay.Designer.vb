<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctl_collection_cashier_register_pay
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.rg_payment_type = New DevExpress.XtraEditors.RadioGroup()
        Me.LabelControl34 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_epaymen_ref = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_fund = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_fund = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.g_epay = New System.Windows.Forms.GroupBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_gateway = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.g_card = New System.Windows.Forms.GroupBox()
        Me.cbb_terminal = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cc_number = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cc_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.g_cheque = New System.Windows.Forms.GroupBox()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_name = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_payee = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_cheque_date = New DevExpress.XtraEditors.DateEdit()
        Me.cbb_bank = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_no = New DevExpress.XtraEditors.TextEdit()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.rg_payment_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_epaymen_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_fund.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.g_epay.SuspendLayout()
        CType(Me.cbb_gateway.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.g_card.SuspendLayout()
        CType(Me.cbb_terminal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cc_number.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.g_cheque.SuspendLayout()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_cheque_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_bank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rg_payment_type
        '
        Me.rg_payment_type.EditValue = "Cash"
        Me.rg_payment_type.Location = New System.Drawing.Point(88, 4)
        Me.rg_payment_type.Name = "rg_payment_type"
        Me.rg_payment_type.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.rg_payment_type.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rg_payment_type.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.rg_payment_type.Properties.Appearance.Options.UseBackColor = True
        Me.rg_payment_type.Properties.Appearance.Options.UseFont = True
        Me.rg_payment_type.Properties.Appearance.Options.UseForeColor = True
        Me.rg_payment_type.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.rg_payment_type.Properties.ColumnIndent = 0
        Me.rg_payment_type.Properties.FlowLayoutItemHorzIndent = 8
        Me.rg_payment_type.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.[Default]
        Me.rg_payment_type.Properties.ItemHorzAlignment = DevExpress.XtraEditors.RadioItemHorzAlignment.Near
        Me.rg_payment_type.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() {New DevExpress.XtraEditors.Controls.RadioGroupItem("Cash", "Cash"), New DevExpress.XtraEditors.Controls.RadioGroupItem("E-Payment", "E-Payment"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Cheque", "Cheque"), New DevExpress.XtraEditors.Controls.RadioGroupItem("Credit Card", "Credit Card")})
        Me.rg_payment_type.Properties.ItemsLayout = DevExpress.XtraEditors.RadioGroupItemsLayout.Flow
        Me.rg_payment_type.Properties.ItemVertAlignment = DevExpress.XtraEditors.RadioItemVertAlignment.Top
        Me.rg_payment_type.Size = New System.Drawing.Size(312, 32)
        Me.rg_payment_type.TabIndex = 42
        '
        'LabelControl34
        '
        Me.LabelControl34.Location = New System.Drawing.Point(9, 11)
        Me.LabelControl34.Name = "LabelControl34"
        Me.LabelControl34.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl34.TabIndex = 43
        Me.LabelControl34.Text = "Payment Type"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 13)
        Me.LabelControl1.TabIndex = 44
        Me.LabelControl1.Text = "Reference"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(552, 34)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Amount"
        '
        'txt_epaymen_ref
        '
        Me.txt_epaymen_ref.Location = New System.Drawing.Point(73, 28)
        Me.txt_epaymen_ref.Name = "txt_epaymen_ref"
        Me.txt_epaymen_ref.Properties.NullValuePrompt = "Enter reference"
        Me.txt_epaymen_ref.Size = New System.Drawing.Size(116, 28)
        Me.txt_epaymen_ref.TabIndex = 47
        '
        'lbl_fund
        '
        Me.lbl_fund.Location = New System.Drawing.Point(15, 34)
        Me.lbl_fund.Name = "lbl_fund"
        Me.lbl_fund.Size = New System.Drawing.Size(56, 13)
        Me.lbl_fund.TabIndex = 48
        Me.lbl_fund.Text = "Credit Fund"
        '
        'cbb_fund
        '
        Me.cbb_fund.Location = New System.Drawing.Point(15, 53)
        Me.cbb_fund.Name = "cbb_fund"
        Me.cbb_fund.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_fund.Properties.NullValuePrompt = "Select crediting fund"
        Me.cbb_fund.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_fund.Size = New System.Drawing.Size(260, 28)
        Me.cbb_fund.TabIndex = 49
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.g_epay)
        Me.PanelControl1.Controls.Add(Me.g_card)
        Me.PanelControl1.Controls.Add(Me.g_cheque)
        Me.PanelControl1.Controls.Add(Me.txt_amount)
        Me.PanelControl1.Controls.Add(Me.btn_delete)
        Me.PanelControl1.Controls.Add(Me.cbb_fund)
        Me.PanelControl1.Controls.Add(Me.LabelControl34)
        Me.PanelControl1.Controls.Add(Me.lbl_fund)
        Me.PanelControl1.Controls.Add(Me.rg_payment_type)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(694, 88)
        Me.PanelControl1.TabIndex = 50
        '
        'g_epay
        '
        Me.g_epay.Controls.Add(Me.LabelControl1)
        Me.g_epay.Controls.Add(Me.txt_epaymen_ref)
        Me.g_epay.Controls.Add(Me.LabelControl3)
        Me.g_epay.Controls.Add(Me.cbb_gateway)
        Me.g_epay.Location = New System.Drawing.Point(9, 321)
        Me.g_epay.Name = "g_epay"
        Me.g_epay.Size = New System.Drawing.Size(672, 78)
        Me.g_epay.TabIndex = 69
        Me.g_epay.TabStop = False
        Me.g_epay.Text = "E-Payment Details"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(215, 35)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(43, 13)
        Me.LabelControl3.TabIndex = 65
        Me.LabelControl3.Text = "Gateway"
        '
        'cbb_gateway
        '
        Me.cbb_gateway.Location = New System.Drawing.Point(269, 28)
        Me.cbb_gateway.Name = "cbb_gateway"
        Me.cbb_gateway.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_gateway.Properties.NullValuePrompt = "Enter gateway"
        Me.cbb_gateway.Size = New System.Drawing.Size(143, 28)
        Me.cbb_gateway.TabIndex = 66
        '
        'g_card
        '
        Me.g_card.Controls.Add(Me.cbb_terminal)
        Me.g_card.Controls.Add(Me.LabelControl11)
        Me.g_card.Controls.Add(Me.txt_cc_number)
        Me.g_card.Controls.Add(Me.LabelControl12)
        Me.g_card.Controls.Add(Me.txt_cc_name)
        Me.g_card.Controls.Add(Me.LabelControl15)
        Me.g_card.Location = New System.Drawing.Point(9, 219)
        Me.g_card.Name = "g_card"
        Me.g_card.Size = New System.Drawing.Size(672, 96)
        Me.g_card.TabIndex = 68
        Me.g_card.TabStop = False
        Me.g_card.Text = "Card Details"
        '
        'cbb_terminal
        '
        Me.cbb_terminal.Location = New System.Drawing.Point(73, 56)
        Me.cbb_terminal.Name = "cbb_terminal"
        Me.cbb_terminal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_terminal.Properties.NullValuePrompt = "Select terminal"
        Me.cbb_terminal.Size = New System.Drawing.Size(339, 28)
        Me.cbb_terminal.TabIndex = 60
        '
        'LabelControl11
        '
        Me.LabelControl11.Location = New System.Drawing.Point(6, 29)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl11.TabIndex = 51
        Me.LabelControl11.Text = "Card Number"
        '
        'txt_cc_number
        '
        Me.txt_cc_number.Location = New System.Drawing.Point(73, 22)
        Me.txt_cc_number.Name = "txt_cc_number"
        Me.txt_cc_number.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_cc_number.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txt_cc_number.Properties.NullValuePrompt = "Enter last 4 digits only"
        Me.txt_cc_number.Size = New System.Drawing.Size(150, 28)
        Me.txt_cc_number.TabIndex = 52
        '
        'LabelControl12
        '
        Me.LabelControl12.Location = New System.Drawing.Point(235, 29)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl12.TabIndex = 53
        Me.LabelControl12.Text = "Card Holder Name"
        '
        'txt_cc_name
        '
        Me.txt_cc_name.Location = New System.Drawing.Point(328, 20)
        Me.txt_cc_name.Name = "txt_cc_name"
        Me.txt_cc_name.Properties.NullValuePrompt = "Enter card holder name"
        Me.txt_cc_name.Size = New System.Drawing.Size(203, 28)
        Me.txt_cc_name.TabIndex = 54
        '
        'LabelControl15
        '
        Me.LabelControl15.Location = New System.Drawing.Point(6, 63)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(40, 13)
        Me.LabelControl15.TabIndex = 59
        Me.LabelControl15.Text = "Terminal"
        '
        'g_cheque
        '
        Me.g_cheque.Controls.Add(Me.LabelControl7)
        Me.g_cheque.Controls.Add(Me.LabelControl4)
        Me.g_cheque.Controls.Add(Me.txt_acc_no)
        Me.g_cheque.Controls.Add(Me.LabelControl5)
        Me.g_cheque.Controls.Add(Me.LabelControl9)
        Me.g_cheque.Controls.Add(Me.txt_acc_name)
        Me.g_cheque.Controls.Add(Me.cbb_payee)
        Me.g_cheque.Controls.Add(Me.LabelControl6)
        Me.g_cheque.Controls.Add(Me.dt_cheque_date)
        Me.g_cheque.Controls.Add(Me.cbb_bank)
        Me.g_cheque.Controls.Add(Me.LabelControl8)
        Me.g_cheque.Controls.Add(Me.txt_cheque_no)
        Me.g_cheque.Location = New System.Drawing.Point(9, 87)
        Me.g_cheque.Name = "g_cheque"
        Me.g_cheque.Size = New System.Drawing.Size(672, 126)
        Me.g_cheque.TabIndex = 67
        Me.g_cheque.TabStop = False
        Me.g_cheque.Text = "Cheque Details"
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(6, 30)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl7.TabIndex = 57
        Me.LabelControl7.Text = "*Cheque No."
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(6, 63)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl4.TabIndex = 51
        Me.LabelControl4.Text = "*Account No."
        '
        'txt_acc_no
        '
        Me.txt_acc_no.Location = New System.Drawing.Point(73, 57)
        Me.txt_acc_no.Name = "txt_acc_no"
        Me.txt_acc_no.Properties.NullValuePrompt = "Enter account number"
        Me.txt_acc_no.Size = New System.Drawing.Size(203, 28)
        Me.txt_acc_no.TabIndex = 52
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(291, 64)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(75, 13)
        Me.LabelControl5.TabIndex = 53
        Me.LabelControl5.Text = "*Account Name"
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(291, 98)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl9.TabIndex = 62
        Me.LabelControl9.Text = "Payee Name"
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Location = New System.Drawing.Point(370, 58)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Properties.NullValuePrompt = "Enter account name"
        Me.txt_acc_name.Size = New System.Drawing.Size(203, 28)
        Me.txt_acc_name.TabIndex = 54
        '
        'cbb_payee
        '
        Me.cbb_payee.Location = New System.Drawing.Point(370, 92)
        Me.cbb_payee.Name = "cbb_payee"
        Me.cbb_payee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_payee.Properties.NullValuePrompt = "Enter payee name"
        Me.cbb_payee.Size = New System.Drawing.Size(258, 28)
        Me.cbb_payee.TabIndex = 61
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(6, 98)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl6.TabIndex = 55
        Me.LabelControl6.Text = "*Bank"
        '
        'dt_cheque_date
        '
        Me.dt_cheque_date.EditValue = Nothing
        Me.dt_cheque_date.Location = New System.Drawing.Point(291, 23)
        Me.dt_cheque_date.Name = "dt_cheque_date"
        Me.dt_cheque_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_cheque_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_cheque_date.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_cheque_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_cheque_date.Properties.NullValuePrompt = "Enter cheque date"
        Me.dt_cheque_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_cheque_date.Size = New System.Drawing.Size(121, 28)
        Me.dt_cheque_date.TabIndex = 60
        '
        'cbb_bank
        '
        Me.cbb_bank.Location = New System.Drawing.Point(73, 91)
        Me.cbb_bank.Name = "cbb_bank"
        Me.cbb_bank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_bank.Properties.NullValuePrompt = "Select bank"
        Me.cbb_bank.Size = New System.Drawing.Size(203, 28)
        Me.cbb_bank.TabIndex = 56
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(215, 30)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl8.TabIndex = 59
        Me.LabelControl8.Text = "*Cheque Date"
        '
        'txt_cheque_no
        '
        Me.txt_cheque_no.Location = New System.Drawing.Point(73, 23)
        Me.txt_cheque_no.Name = "txt_cheque_no"
        Me.txt_cheque_no.Properties.NullValuePrompt = "Enter cheque no."
        Me.txt_cheque_no.Size = New System.Drawing.Size(122, 28)
        Me.txt_cheque_no.TabIndex = 58
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(552, 53)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_amount.Properties.Appearance.Options.UseFont = True
        Me.txt_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_amount.Properties.DisplayFormat.FormatString = "c2"
        Me.txt_amount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.EditFormat.FormatString = "c2"
        Me.txt_amount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_amount.Properties.MaskSettings.Set("mask", "c")
        Me.txt_amount.Properties.NullValuePrompt = "Enter amount"
        Me.txt_amount.Size = New System.Drawing.Size(129, 28)
        Me.txt_amount.TabIndex = 64
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_delete.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_deletecircled
        Me.btn_delete.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_delete.Location = New System.Drawing.Point(658, 3)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light
        Me.btn_delete.Size = New System.Drawing.Size(30, 30)
        Me.btn_delete.TabIndex = 50
        '
        'ctl_collection_cashier_register_pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "ctl_collection_cashier_register_pay"
        Me.Size = New System.Drawing.Size(694, 88)
        CType(Me.rg_payment_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_epaymen_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_fund.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.g_epay.ResumeLayout(False)
        Me.g_epay.PerformLayout()
        CType(Me.cbb_gateway.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.g_card.ResumeLayout(False)
        Me.g_card.PerformLayout()
        CType(Me.cbb_terminal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cc_number.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.g_cheque.ResumeLayout(False)
        Me.g_cheque.PerformLayout()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_cheque_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_bank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rg_payment_type As DevExpress.XtraEditors.RadioGroup
    Friend WithEvents LabelControl34 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_epaymen_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_fund As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_fund As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_bank As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acc_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acc_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_cheque_date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_payee As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_gateway As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents g_cheque As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents g_card As GroupBox
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_number As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cc_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_terminal As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents g_epay As GroupBox
End Class
