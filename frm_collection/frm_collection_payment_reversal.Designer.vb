<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_payment_reversal
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_paymentid = New DevExpress.XtraEditors.TextEdit()
        Me.btn_get = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reverse = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_orderid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_current_balance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_amount_to_reverse = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_new_balance = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_new_balance = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_paymentid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orderid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_current_balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount_to_reverse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_new_balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 65)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Payment ID"
        '
        'txt_paymentid
        '
        Me.txt_paymentid.Location = New System.Drawing.Point(91, 57)
        Me.txt_paymentid.Name = "txt_paymentid"
        Me.txt_paymentid.Size = New System.Drawing.Size(100, 28)
        Me.txt_paymentid.TabIndex = 1
        '
        'btn_get
        '
        Me.btn_get.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_get.Appearance.Options.UseBackColor = True
        Me.btn_get.Location = New System.Drawing.Point(196, 58)
        Me.btn_get.Name = "btn_get"
        Me.btn_get.Size = New System.Drawing.Size(56, 27)
        Me.btn_get.TabIndex = 2
        Me.btn_get.Text = "Get"
        '
        'btn_reverse
        '
        Me.btn_reverse.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_reverse.Appearance.Options.UseBackColor = True
        Me.btn_reverse.Location = New System.Drawing.Point(221, 277)
        Me.btn_reverse.Name = "btn_reverse"
        Me.btn_reverse.Size = New System.Drawing.Size(100, 37)
        Me.btn_reverse.TabIndex = 3
        Me.btn_reverse.Text = "Reverse"
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(91, 91)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Properties.ReadOnly = True
        Me.txt_orderid.Size = New System.Drawing.Size(138, 28)
        Me.txt_orderid.TabIndex = 5
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 99)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Order ID"
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(91, 125)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.ReadOnly = True
        Me.txt_customer.Size = New System.Drawing.Size(229, 28)
        Me.txt_customer.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(12, 133)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Customer"
        '
        'txt_current_balance
        '
        Me.txt_current_balance.Location = New System.Drawing.Point(154, 168)
        Me.txt_current_balance.Name = "txt_current_balance"
        Me.txt_current_balance.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_current_balance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_current_balance.Properties.ReadOnly = True
        Me.txt_current_balance.Size = New System.Drawing.Size(126, 28)
        Me.txt_current_balance.TabIndex = 9
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(34, 175)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(77, 13)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Current Balance"
        '
        'txt_amount_to_reverse
        '
        Me.txt_amount_to_reverse.Location = New System.Drawing.Point(154, 202)
        Me.txt_amount_to_reverse.Name = "txt_amount_to_reverse"
        Me.txt_amount_to_reverse.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.txt_amount_to_reverse.Properties.Appearance.Options.UseForeColor = True
        Me.txt_amount_to_reverse.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount_to_reverse.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_amount_to_reverse.Properties.ReadOnly = True
        Me.txt_amount_to_reverse.Size = New System.Drawing.Size(126, 28)
        Me.txt_amount_to_reverse.TabIndex = 11
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(34, 209)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(95, 13)
        Me.LabelControl5.TabIndex = 10
        Me.LabelControl5.Text = "Amount To Reverse"
        '
        'txt_new_balance
        '
        Me.txt_new_balance.Location = New System.Drawing.Point(154, 236)
        Me.txt_new_balance.Name = "txt_new_balance"
        Me.txt_new_balance.Properties.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink
        Me.txt_new_balance.Properties.Appearance.Options.UseForeColor = True
        Me.txt_new_balance.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_new_balance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_new_balance.Properties.ReadOnly = True
        Me.txt_new_balance.Size = New System.Drawing.Size(126, 28)
        Me.txt_new_balance.TabIndex = 13
        '
        'lbl_new_balance
        '
        Me.lbl_new_balance.Location = New System.Drawing.Point(34, 243)
        Me.lbl_new_balance.Name = "lbl_new_balance"
        Me.lbl_new_balance.Size = New System.Drawing.Size(97, 13)
        Me.lbl_new_balance.TabIndex = 12
        Me.lbl_new_balance.Text = "New Balance will be:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(222, 31)
        Me.LabelControl7.TabIndex = 21
        Me.LabelControl7.Text = "Payment Reversal"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(115, 277)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(100, 37)
        Me.btn_cancel.TabIndex = 22
        Me.btn_cancel.Text = "Cancel"
        '
        'frm_collection_payment_reversal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 327)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_new_balance)
        Me.Controls.Add(Me.lbl_new_balance)
        Me.Controls.Add(Me.txt_amount_to_reverse)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_current_balance)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btn_reverse)
        Me.Controls.Add(Me.btn_get)
        Me.Controls.Add(Me.txt_paymentid)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.payment
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_payment_reversal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Reversal"
        CType(Me.txt_paymentid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orderid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_current_balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount_to_reverse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_new_balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_paymentid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_get As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reverse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_orderid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_current_balance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_amount_to_reverse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_new_balance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_new_balance As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
End Class
