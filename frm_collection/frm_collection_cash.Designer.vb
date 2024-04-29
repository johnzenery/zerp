<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_cash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_cash))
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_paid = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_amount_due = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orderid = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_customer = New DevExpress.XtraEditors.LabelControl()
        Me.btn_deduct = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_deduction = New DevExpress.XtraEditors.LabelControl()
        Me.txt_amount_tendered = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_balance = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_amount_tendered.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 81)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl2.TabIndex = 16
        Me.LabelControl2.Text = "Customer:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 59)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Order ID:"
        '
        'btn_paid
        '
        Me.btn_paid.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_paid.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_paid.Appearance.Options.UseBackColor = True
        Me.btn_paid.Appearance.Options.UseFont = True
        Me.btn_paid.Location = New System.Drawing.Point(172, 367)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(150, 47)
        Me.btn_paid.TabIndex = 19
        Me.btn_paid.Text = "PAID"
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
        Me.lbl_amount_due.Location = New System.Drawing.Point(20, 144)
        Me.lbl_amount_due.Name = "lbl_amount_due"
        Me.lbl_amount_due.Size = New System.Drawing.Size(303, 42)
        Me.lbl_amount_due.TabIndex = 20
        Me.lbl_amount_due.Text = "P0.00"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_orderid.Appearance.Options.UseFont = True
        Me.lbl_orderid.Location = New System.Drawing.Point(98, 59)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(7, 16)
        Me.lbl_orderid.TabIndex = 21
        Me.lbl_orderid.Text = "0"
        '
        'lbl_customer
        '
        Me.lbl_customer.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.lbl_customer.Appearance.Options.UseFont = True
        Me.lbl_customer.Location = New System.Drawing.Point(98, 81)
        Me.lbl_customer.Name = "lbl_customer"
        Me.lbl_customer.Size = New System.Drawing.Size(97, 16)
        Me.lbl_customer.TabIndex = 22
        Me.lbl_customer.Text = "Customer Name"
        '
        'btn_deduct
        '
        Me.btn_deduct.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.btn_deduct.Appearance.Options.UseFont = True
        Me.btn_deduct.Location = New System.Drawing.Point(20, 367)
        Me.btn_deduct.Name = "btn_deduct"
        Me.btn_deduct.Size = New System.Drawing.Size(146, 47)
        Me.btn_deduct.TabIndex = 24
        Me.btn_deduct.Text = "Deduct Returns"
        '
        'lbl_deduction
        '
        Me.lbl_deduction.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_deduction.Appearance.ForeColor = System.Drawing.Color.Red
        Me.lbl_deduction.Appearance.Options.UseFont = True
        Me.lbl_deduction.Appearance.Options.UseForeColor = True
        Me.lbl_deduction.Location = New System.Drawing.Point(20, 421)
        Me.lbl_deduction.Name = "lbl_deduction"
        Me.lbl_deduction.Size = New System.Drawing.Size(80, 14)
        Me.lbl_deduction.TabIndex = 25
        Me.lbl_deduction.Text = "No Deductions"
        Me.lbl_deduction.Visible = False
        '
        'txt_amount_tendered
        '
        Me.txt_amount_tendered.Location = New System.Drawing.Point(20, 228)
        Me.txt_amount_tendered.Name = "txt_amount_tendered"
        Me.txt_amount_tendered.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 15.75!, System.Drawing.FontStyle.Bold)
        Me.txt_amount_tendered.Properties.Appearance.Options.UseFont = True
        Me.txt_amount_tendered.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount_tendered.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_amount_tendered.Properties.AutoHeight = False
        Me.txt_amount_tendered.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.txt_amount_tendered.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_amount_tendered.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_amount_tendered.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_amount_tendered.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txt_amount_tendered.Size = New System.Drawing.Size(303, 42)
        Me.txt_amount_tendered.TabIndex = 35
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
        Me.lbl_balance.Location = New System.Drawing.Point(20, 308)
        Me.lbl_balance.Name = "lbl_balance"
        Me.lbl_balance.Size = New System.Drawing.Size(303, 42)
        Me.lbl_balance.TabIndex = 32
        Me.lbl_balance.Text = "P0.00"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(20, 276)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(68, 26)
        Me.LabelControl8.TabIndex = 33
        Me.LabelControl8.Text = "Balance"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(20, 196)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(158, 26)
        Me.LabelControl9.TabIndex = 34
        Me.LabelControl9.Text = "Amount Tendered"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(20, 112)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(102, 26)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Total to Pay"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(178, 31)
        Me.LabelControl4.TabIndex = 37
        Me.LabelControl4.Text = "Cash Payment"
        '
        'frm_collection_cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 450)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_amount_tendered)
        Me.Controls.Add(Me.lbl_balance)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.lbl_deduction)
        Me.Controls.Add(Me.btn_deduct)
        Me.Controls.Add(Me.lbl_customer)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.lbl_amount_due)
        Me.Controls.Add(Me.btn_paid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_collection_cash.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_cash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cash Payment"
        CType(Me.txt_amount_tendered.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_paid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_amount_due As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_orderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_customer As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_deduct As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_deduction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_amount_tendered As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_balance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
End Class
