<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_cashier_register_pay
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.panel_payments = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_orderid = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_customer_name = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_amount = New DevExpress.XtraEditors.LabelControl()
        Me.txt_balance = New DevExpress.XtraEditors.TextEdit()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_epay = New DevExpress.XtraEditors.SimpleButton()
        Me.cb_print_collection_receipt = New DevExpress.XtraEditors.CheckEdit()
        CType(Me.txt_balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.cb_print_collection_receipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 21)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Order ID:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 47)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Customer:"
        '
        'panel_payments
        '
        Me.panel_payments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panel_payments.AutoScroll = True
        Me.panel_payments.Location = New System.Drawing.Point(5, 62)
        Me.panel_payments.Name = "panel_payments"
        Me.panel_payments.Size = New System.Drawing.Size(719, 382)
        Me.panel_payments.TabIndex = 5
        '
        'btn_add
        '
        Me.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_add.Appearance.Options.UseBackColor = True
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_add.Location = New System.Drawing.Point(5, 32)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(80, 26)
        Me.btn_add.TabIndex = 4
        Me.btn_add.Text = "+ Pay"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(497, 548)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(52, 20)
        Me.LabelControl3.TabIndex = 3
        Me.LabelControl3.Text = "Balance"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(457, 47)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(101, 20)
        Me.LabelControl4.TabIndex = 4
        Me.LabelControl4.Text = "Amount to Pay:"
        '
        'lbl_orderid
        '
        Me.lbl_orderid.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_orderid.Appearance.Options.UseFont = True
        Me.lbl_orderid.Location = New System.Drawing.Point(97, 21)
        Me.lbl_orderid.Name = "lbl_orderid"
        Me.lbl_orderid.Size = New System.Drawing.Size(35, 20)
        Me.lbl_orderid.TabIndex = 5
        Me.lbl_orderid.Text = "*****"
        '
        'lbl_customer_name
        '
        Me.lbl_customer_name.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_customer_name.Appearance.Options.UseFont = True
        Me.lbl_customer_name.Location = New System.Drawing.Point(97, 47)
        Me.lbl_customer_name.Name = "lbl_customer_name"
        Me.lbl_customer_name.Size = New System.Drawing.Size(35, 20)
        Me.lbl_customer_name.TabIndex = 6
        Me.lbl_customer_name.Text = "*****"
        '
        'lbl_amount
        '
        Me.lbl_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_amount.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_amount.Appearance.Options.UseFont = True
        Me.lbl_amount.Location = New System.Drawing.Point(575, 47)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Size = New System.Drawing.Size(31, 20)
        Me.lbl_amount.TabIndex = 7
        Me.lbl_amount.Text = "0.00"
        '
        'txt_balance
        '
        Me.txt_balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_balance.Location = New System.Drawing.Point(559, 541)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_balance.Properties.Appearance.Options.UseFont = True
        Me.txt_balance.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_balance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_balance.Properties.ReadOnly = True
        Me.txt_balance.Size = New System.Drawing.Size(177, 34)
        Me.txt_balance.TabIndex = 48
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_16x162
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 5
        Me.btn_submit.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_submit.Location = New System.Drawing.Point(103, 545)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 26)
        Me.btn_submit.TabIndex = 49
        Me.btn_submit.Text = "Submit"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_cancel.Location = New System.Drawing.Point(12, 545)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 26)
        Me.btn_cancel.TabIndex = 50
        Me.btn_cancel.Text = "Cancel"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.btn_epay)
        Me.GroupControl2.Controls.Add(Me.btn_add)
        Me.GroupControl2.Controls.Add(Me.panel_payments)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 86)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(729, 449)
        Me.GroupControl2.TabIndex = 52
        Me.GroupControl2.Text = "Payments"
        '
        'btn_epay
        '
        Me.btn_epay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_epay.Appearance.Options.UseFont = True
        Me.btn_epay.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_epay.ImageOptions.ImageToTextIndent = 10
        Me.btn_epay.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_epay.Location = New System.Drawing.Point(622, 32)
        Me.btn_epay.Name = "btn_epay"
        Me.btn_epay.Size = New System.Drawing.Size(102, 26)
        Me.btn_epay.TabIndex = 54
        Me.btn_epay.Text = "E-Pay Receipt"
        '
        'cb_print_collection_receipt
        '
        Me.cb_print_collection_receipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cb_print_collection_receipt.Location = New System.Drawing.Point(205, 549)
        Me.cb_print_collection_receipt.Name = "cb_print_collection_receipt"
        Me.cb_print_collection_receipt.Properties.Caption = "Print Collection Receipt"
        Me.cb_print_collection_receipt.Size = New System.Drawing.Size(155, 22)
        Me.cb_print_collection_receipt.TabIndex = 53
        '
        'frm_collection_cashier_register_pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 587)
        Me.Controls.Add(Me.cb_print_collection_receipt)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_balance)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.lbl_customer_name)
        Me.Controls.Add(Me.lbl_orderid)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.MinimizeBox = False
        Me.Name = "frm_collection_cashier_register_pay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pay Order"
        CType(Me.txt_balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.cb_print_collection_receipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_orderid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_customer_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_balance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents panel_payments As FlowLayoutPanel
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents cb_print_collection_receipt As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents btn_epay As DevExpress.XtraEditors.SimpleButton
End Class
