<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_epayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_epayment))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_ref = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_customer = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orderid = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_bank_option = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_deduction = New DevExpress.XtraEditors.LabelControl()
        Me.btn_deduct = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_paid = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_amount_due = New DevExpress.XtraEditors.LabelControl()
        Me.btn_attachments = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_amount_tendered = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_balance = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_bank_option.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txt_amount_tendered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_ref)
        Me.Panel2.Controls.Add(Me.lbl_customer)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.lbl_orderid)
        Me.Panel2.Controls.Add(Me.cbb_bank_option)
        Me.Panel2.Controls.Add(Me.LabelControl2)
        Me.Panel2.Controls.Add(Me.LabelControl5)
        Me.Panel2.Controls.Add(Me.LabelControl3)
        Me.Panel2.Location = New System.Drawing.Point(12, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(324, 132)
        Me.Panel2.TabIndex = 39
        '
        'txt_ref
        '
        Me.txt_ref.Location = New System.Drawing.Point(198, 97)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txt_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_ref.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ref.Size = New System.Drawing.Size(114, 30)
        Me.txt_ref.TabIndex = 27
        '
        'lbl_customer
        '
        Me.lbl_customer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_customer.Appearance.Options.UseFont = True
        Me.lbl_customer.Appearance.Options.UseTextOptions = True
        Me.lbl_customer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.lbl_customer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_customer.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.NoWrap
        Me.lbl_customer.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_customer.Location = New System.Drawing.Point(82, 37)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(203, 18)
        Me.lbl_customer.TabIndex = 37
        Me.lbl_customer.Text = "Customer Name"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(126, 104)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl1.TabIndex = 26
        Me.LabelControl1.Text = "Reference:"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_orderid.Appearance.Options.UseFont = True
        Me.lbl_orderid.Location = New System.Drawing.Point(82, 14)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(7, 16)
        Me.lbl_orderid.TabIndex = 36
        Me.lbl_orderid.Text = "0"
        '
        'cbb_bank_option
        '
        Me.cbb_bank_option.Location = New System.Drawing.Point(115, 61)
        Me.cbb_bank_option.Name = "cbb_bank_option"
        Me.cbb_bank_option.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cbb_bank_option.Properties.Appearance.Options.UseFont = True
        Me.cbb_bank_option.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_bank_option.Properties.Items.AddRange(New Object() {"Gcash", "Maya", "Coins.ph", "Palawan Express", "ShopeePay", "Lazada Wallet", "GrabPay", "DragonPay", "-", "BDO", "China Bank", "Metrobank", "PBCom", "PNB", "RCBC", "Security Bank"})
        Me.cbb_bank_option.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_bank_option.Size = New System.Drawing.Size(197, 30)
        Me.cbb_bank_option.TabIndex = 28
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(8, 35)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl2.TabIndex = 34
        Me.LabelControl2.Text = "Customer:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(8, 68)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(104, 16)
        Me.LabelControl5.TabIndex = 29
        Me.LabelControl5.Text = "E-Payment Type:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(8, 13)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl3.TabIndex = 35
        Me.LabelControl3.Text = "Order ID:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lbl_deduction)
        Me.Panel1.Controls.Add(Me.btn_deduct)
        Me.Panel1.Controls.Add(Me.btn_paid)
        Me.Panel1.Controls.Add(Me.lbl_amount_due)
        Me.Panel1.Controls.Add(Me.btn_attachments)
        Me.Panel1.Controls.Add(Me.txt_amount_tendered)
        Me.Panel1.Controls.Add(Me.lbl_balance)
        Me.Panel1.Controls.Add(Me.LabelControl10)
        Me.Panel1.Controls.Add(Me.LabelControl8)
        Me.Panel1.Controls.Add(Me.LabelControl9)
        Me.Panel1.Location = New System.Drawing.Point(12, 184)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(324, 372)
        Me.Panel1.TabIndex = 38
        '
        'lbl_deduction
        '
        Me.lbl_deduction.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_deduction.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_deduction.Appearance.Options.UseFont = True
        Me.lbl_deduction.Appearance.Options.UseForeColor = True
        Me.lbl_deduction.Location = New System.Drawing.Point(12, 348)
        Me.lbl_deduction.Name = "lbl_deduction"
        Me.lbl_deduction.Size = New System.Drawing.Size(56, 14)
        Me.lbl_deduction.TabIndex = 33
        Me.lbl_deduction.Text = "Deduction"
        Me.lbl_deduction.Visible = False
        '
        'btn_deduct
        '
        Me.btn_deduct.Location = New System.Drawing.Point(12, 302)
        Me.btn_deduct.Name = "btn_deduct"
        Me.btn_deduct.Size = New System.Drawing.Size(303, 40)
        Me.btn_deduct.TabIndex = 32
        Me.btn_deduct.Text = "Deduct Returns"
        '
        'btn_paid
        '
        Me.btn_paid.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_paid.Appearance.Options.UseBackColor = True
        Me.btn_paid.Location = New System.Drawing.Point(156, 249)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(159, 47)
        Me.btn_paid.TabIndex = 19
        Me.btn_paid.Text = "Apply"
        '
        'lbl_amount_due
        '
        Me.lbl_amount_due.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_amount_due.Appearance.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_amount_due.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_amount_due.Appearance.Options.UseBackColor = True
        Me.lbl_amount_due.Appearance.Options.UseFont = True
        Me.lbl_amount_due.Appearance.Options.UseForeColor = True
        Me.lbl_amount_due.Appearance.Options.UseTextOptions = True
        Me.lbl_amount_due.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_amount_due.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_amount_due.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_amount_due.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_amount_due.Location = New System.Drawing.Point(12, 34)
        Me.lbl_amount_due.Name = "lbl_amount_due"
        Me.lbl_amount_due.Size = New System.Drawing.Size(303, 42)
        Me.lbl_amount_due.TabIndex = 20
        Me.lbl_amount_due.Text = "P0.00"
        '
        'btn_attachments
        '
        Me.btn_attachments.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.article_32x32
        Me.btn_attachments.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_attachments.ImageOptions.ImageToTextIndent = 5
        Me.btn_attachments.Location = New System.Drawing.Point(12, 249)
        Me.btn_attachments.Name = "btn_attachments"
        Me.btn_attachments.Size = New System.Drawing.Size(138, 47)
        Me.btn_attachments.TabIndex = 24
        Me.btn_attachments.Text = "View" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Attachments"
        '
        'txt_amount_tendered
        '
        Me.txt_amount_tendered.Location = New System.Drawing.Point(12, 114)
        Me.txt_amount_tendered.Name = "txt_amount_tendered"
        Me.txt_amount_tendered.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_amount_tendered.Properties.Appearance.Options.UseFont = True
        Me.txt_amount_tendered.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount_tendered.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_amount_tendered.Properties.AutoHeight = False
        Me.txt_amount_tendered.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_amount_tendered.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_amount_tendered.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount_tendered.Size = New System.Drawing.Size(303, 42)
        Me.txt_amount_tendered.TabIndex = 31
        '
        'lbl_balance
        '
        Me.lbl_balance.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_balance.Appearance.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_balance.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_balance.Appearance.Options.UseBackColor = True
        Me.lbl_balance.Appearance.Options.UseFont = True
        Me.lbl_balance.Appearance.Options.UseForeColor = True
        Me.lbl_balance.Appearance.Options.UseTextOptions = True
        Me.lbl_balance.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_balance.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.lbl_balance.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_balance.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_balance.Location = New System.Drawing.Point(12, 194)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(303, 42)
        Me.lbl_balance.TabIndex = 27
        Me.lbl_balance.Text = "P0.00"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(12, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(102, 26)
        Me.LabelControl10.TabIndex = 30
        Me.LabelControl10.Text = "Total to Pay"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(12, 162)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(68, 26)
        Me.LabelControl8.TabIndex = 28
        Me.LabelControl8.Text = "Balance"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(12, 82)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(158, 26)
        Me.LabelControl9.TabIndex = 29
        Me.LabelControl9.Text = "Amount Tendered"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(134, 31)
        Me.LabelControl4.TabIndex = 40
        Me.LabelControl4.Text = "E-Payment"
        '
        'frm_collection_epayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 566)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_collection_epayment.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_epayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "E-Payment"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_bank_option.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt_amount_tendered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txt_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_bank_option As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_paid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_amount_due As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_attachments As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_amount_tendered As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_balance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_deduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_deduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
