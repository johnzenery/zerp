<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_cashier_refund
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Me.cbb_customer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_payments = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_balance = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.txt_balance.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbb_customer
        '
        Me.cbb_customer.Location = New System.Drawing.Point(86, 30)
        Me.cbb_customer.Name = "cbb_customer"
        Me.cbb_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbb_customer.Size = New System.Drawing.Size(218, 28)
        Me.cbb_customer.TabIndex = 51
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 32)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 20)
        Me.LabelControl3.TabIndex = 50
        Me.LabelControl3.Text = "Customer"
        '
        'GroupControl2
        '
        Me.GroupControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl2.Controls.Add(Me.btn_add)
        Me.GroupControl2.Controls.Add(Me.panel_payments)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 75)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(729, 347)
        Me.GroupControl2.TabIndex = 53
        Me.GroupControl2.Text = "Payments"
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
        Me.btn_add.Text = "+ Refund"
        '
        'panel_payments
        '
        Me.panel_payments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_payments.AutoScroll = True
        Me.panel_payments.Location = New System.Drawing.Point(5, 62)
        Me.panel_payments.Name = "panel_payments"
        Me.panel_payments.Size = New System.Drawing.Size(719, 280)
        Me.panel_payments.TabIndex = 5
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_cancel.Location = New System.Drawing.Point(12, 445)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(85, 26)
        Me.btn_cancel.TabIndex = 57
        Me.btn_cancel.Text = "Cancel"
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
        Me.btn_submit.Location = New System.Drawing.Point(103, 445)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(85, 26)
        Me.btn_submit.TabIndex = 56
        Me.btn_submit.Text = "Submit"
        '
        'txt_balance
        '
        Me.txt_balance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_balance.Location = New System.Drawing.Point(558, 441)
        Me.txt_balance.Name = "txt_balance"
        Me.txt_balance.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold)
        Me.txt_balance.Properties.Appearance.Options.UseFont = True
        Me.txt_balance.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_balance.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_balance.Properties.ReadOnly = True
        Me.txt_balance.Size = New System.Drawing.Size(177, 34)
        Me.txt_balance.TabIndex = 55
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(448, 448)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(104, 20)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Refund Amount"
        '
        'frm_collection_cashier_refund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 483)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_balance)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.cbb_customer)
        Me.Controls.Add(Me.LabelControl3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_collection_cashier_refund"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Refund Order"
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.txt_balance.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbb_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl2 As DevExpress.XtraEditors.GroupControl
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_payments As FlowLayoutPanel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_balance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
