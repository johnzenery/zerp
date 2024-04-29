<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_cheque_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_cheque_view))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_bank = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_date = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_payee = New DevExpress.XtraEditors.TextEdit()
        Me.txt_orders = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_status = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_cheque_id = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_bank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orders.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_bank)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Controls.Add(Me.txt_amount)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txt_cheque_date)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txt_cheque_no)
        Me.PanelControl1.Location = New System.Drawing.Point(11, 63)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(274, 122)
        Me.PanelControl1.TabIndex = 0
        '
        'LabelControl8
        '
        Me.LabelControl8.Location = New System.Drawing.Point(127, 63)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(23, 13)
        Me.LabelControl8.TabIndex = 15
        Me.LabelControl8.Text = "Bank"
        '
        'txt_bank
        '
        Me.txt_bank.Location = New System.Drawing.Point(127, 82)
        Me.txt_bank.Name = "txt_bank"
        Me.txt_bank.Properties.ReadOnly = True
        Me.txt_bank.Properties.UseReadOnlyAppearance = False
        Me.txt_bank.Size = New System.Drawing.Size(134, 28)
        Me.txt_bank.TabIndex = 14
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 63)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(37, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Amount"
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(16, 82)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.ReadOnly = True
        Me.txt_amount.Properties.UseReadOnlyAppearance = False
        Me.txt_amount.Size = New System.Drawing.Size(104, 28)
        Me.txt_amount.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(127, 10)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Cheque Date"
        '
        'txt_cheque_date
        '
        Me.txt_cheque_date.Location = New System.Drawing.Point(127, 29)
        Me.txt_cheque_date.Name = "txt_cheque_date"
        Me.txt_cheque_date.Properties.ReadOnly = True
        Me.txt_cheque_date.Properties.UseReadOnlyAppearance = False
        Me.txt_cheque_date.Size = New System.Drawing.Size(134, 28)
        Me.txt_cheque_date.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(16, 10)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 13)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Cheque No."
        '
        'txt_cheque_no
        '
        Me.txt_cheque_no.Location = New System.Drawing.Point(17, 29)
        Me.txt_cheque_no.Name = "txt_cheque_no"
        Me.txt_cheque_no.Properties.ReadOnly = True
        Me.txt_cheque_no.Properties.UseReadOnlyAppearance = False
        Me.txt_cheque_no.Size = New System.Drawing.Size(104, 28)
        Me.txt_cheque_no.TabIndex = 0
        '
        'LabelControl7
        '
        Me.LabelControl7.Location = New System.Drawing.Point(16, 35)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl7.TabIndex = 13
        Me.LabelControl7.Text = "Customer"
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(73, 28)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.ReadOnly = True
        Me.txt_customer.Properties.UseReadOnlyAppearance = False
        Me.txt_customer.Size = New System.Drawing.Size(188, 28)
        Me.txt_customer.TabIndex = 12
        '
        'LabelControl6
        '
        Me.LabelControl6.Location = New System.Drawing.Point(11, 272)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(69, 13)
        Me.LabelControl6.TabIndex = 11
        Me.LabelControl6.Text = "Account Name"
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Location = New System.Drawing.Point(97, 265)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Properties.ReadOnly = True
        Me.txt_acc_name.Properties.UseReadOnlyAppearance = False
        Me.txt_acc_name.Size = New System.Drawing.Size(188, 28)
        Me.txt_acc_name.TabIndex = 10
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(11, 238)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 9
        Me.LabelControl5.Text = "Account No."
        '
        'txt_acc_no
        '
        Me.txt_acc_no.Location = New System.Drawing.Point(97, 231)
        Me.txt_acc_no.Name = "txt_acc_no"
        Me.txt_acc_no.Properties.ReadOnly = True
        Me.txt_acc_no.Properties.UseReadOnlyAppearance = False
        Me.txt_acc_no.Size = New System.Drawing.Size(188, 28)
        Me.txt_acc_no.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 204)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(30, 13)
        Me.LabelControl4.TabIndex = 7
        Me.LabelControl4.Text = "Payee"
        '
        'txt_payee
        '
        Me.txt_payee.Location = New System.Drawing.Point(73, 197)
        Me.txt_payee.Name = "txt_payee"
        Me.txt_payee.Properties.ReadOnly = True
        Me.txt_payee.Properties.UseReadOnlyAppearance = False
        Me.txt_payee.Size = New System.Drawing.Size(212, 28)
        Me.txt_payee.TabIndex = 6
        '
        'txt_orders
        '
        Me.txt_orders.Location = New System.Drawing.Point(138, 299)
        Me.txt_orders.Name = "txt_orders"
        Me.txt_orders.Properties.ReadOnly = True
        Me.txt_orders.Properties.UseReadOnlyAppearance = False
        Me.txt_orders.Size = New System.Drawing.Size(147, 44)
        Me.txt_orders.TabIndex = 16
        '
        'LabelControl9
        '
        Me.LabelControl9.Location = New System.Drawing.Point(11, 306)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(97, 13)
        Me.LabelControl9.TabIndex = 17
        Me.LabelControl9.Text = "Payment For Orders"
        '
        'cbb_status
        '
        Me.cbb_status.Location = New System.Drawing.Point(51, 348)
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.Properties.AutoHeight = False
        Me.cbb_status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_status.Properties.Items.AddRange(New Object() {"RECEIVED", "HOLD", "CLEARED", "CANCELLED"})
        Me.cbb_status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_status.Size = New System.Drawing.Size(137, 31)
        Me.cbb_status.TabIndex = 18
        '
        'LabelControl10
        '
        Me.LabelControl10.Location = New System.Drawing.Point(8, 356)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(35, 13)
        Me.LabelControl10.TabIndex = 19
        Me.LabelControl10.Text = "Status:"
        '
        'btn_save
        '
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Location = New System.Drawing.Point(194, 349)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(91, 30)
        Me.btn_save.TabIndex = 20
        Me.btn_save.Text = "Save"
        '
        'lbl_cheque_id
        '
        Me.lbl_cheque_id.Location = New System.Drawing.Point(16, 10)
        Me.lbl_cheque_id.Name = "lbl_cheque_id"
        Me.lbl_cheque_id.Size = New System.Drawing.Size(51, 13)
        Me.lbl_cheque_id.TabIndex = 21
        Me.lbl_cheque_id.Text = "Cheque ID"
        Me.lbl_cheque_id.Visible = False
        '
        'frm_collection_cheque_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 386)
        Me.Controls.Add(Me.lbl_cheque_id)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_orders)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.cbb_status)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.txt_acc_name)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_payee)
        Me.Controls.Add(Me.txt_acc_no)
        Me.Controls.Add(Me.LabelControl4)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_collection_cheque_view.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_cheque_view"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cheque Details"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_bank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orders.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acc_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_payee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acc_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_bank As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_status As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_orders As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbl_cheque_id As DevExpress.XtraEditors.LabelControl
End Class
