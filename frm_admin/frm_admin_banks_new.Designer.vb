<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_banks_new
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_banks_new))
        Me.txt_bank_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_bank_name = New DevExpress.XtraEditors.TextEdit()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.toggle_status = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_id = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_fund_name = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fund_name = New DevExpress.XtraEditors.TextEdit()
        Me.cb_debit = New DevExpress.XtraEditors.CheckEdit()
        Me.cb_credit = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_account_type = New DevExpress.XtraEditors.ComboBoxEdit()
        CType(Me.txt_bank_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_bank_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fund_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_debit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_credit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_account_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_bank_no
        '
        Me.txt_bank_no.Location = New System.Drawing.Point(104, 49)
        Me.txt_bank_no.Name = "txt_bank_no"
        Me.txt_bank_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bank_no.Properties.Appearance.Options.UseFont = True
        Me.txt_bank_no.Size = New System.Drawing.Size(190, 30)
        Me.txt_bank_no.TabIndex = 0
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 56)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "*Bank No."
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 92)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "*Bank Name"
        '
        'txt_bank_name
        '
        Me.txt_bank_name.Location = New System.Drawing.Point(104, 85)
        Me.txt_bank_name.Name = "txt_bank_name"
        Me.txt_bank_name.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_bank_name.Properties.Appearance.Options.UseFont = True
        Me.txt_bank_name.Size = New System.Drawing.Size(190, 30)
        Me.txt_bank_name.TabIndex = 2
        '
        'btn_save
        '
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Location = New System.Drawing.Point(188, 264)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(106, 37)
        Me.btn_save.TabIndex = 4
        Me.btn_save.Text = "Save"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(76, 264)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(106, 37)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(12, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(126, 24)
        Me.lbl_title.TabIndex = 6
        Me.lbl_title.Text = "Add New Bank"
        '
        'toggle_status
        '
        Me.toggle_status.Location = New System.Drawing.Point(121, 232)
        Me.toggle_status.Name = "toggle_status"
        Me.toggle_status.Properties.OffText = "Disabled"
        Me.toggle_status.Properties.OnText = "Enabled"
        Me.toggle_status.Size = New System.Drawing.Size(113, 24)
        Me.toggle_status.TabIndex = 7
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 235)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(88, 16)
        Me.LabelControl4.TabIndex = 8
        Me.LabelControl4.Text = "Account Status"
        '
        'lbl_id
        '
        Me.lbl_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Appearance.Options.UseFont = True
        Me.lbl_id.Location = New System.Drawing.Point(279, 27)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(11, 16)
        Me.lbl_id.TabIndex = 9
        Me.lbl_id.Text = "id"
        Me.lbl_id.Visible = False
        '
        'lbl_fund_name
        '
        Me.lbl_fund_name.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fund_name.Appearance.Options.UseFont = True
        Me.lbl_fund_name.Location = New System.Drawing.Point(12, 128)
        Me.lbl_fund_name.Name = "lbl_fund_name"
        Me.lbl_fund_name.Size = New System.Drawing.Size(70, 16)
        Me.lbl_fund_name.TabIndex = 11
        Me.lbl_fund_name.Text = "Fund Name"
        '
        'txt_fund_name
        '
        Me.txt_fund_name.Location = New System.Drawing.Point(104, 121)
        Me.txt_fund_name.Name = "txt_fund_name"
        Me.txt_fund_name.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fund_name.Properties.Appearance.Options.UseFont = True
        Me.txt_fund_name.Size = New System.Drawing.Size(190, 30)
        Me.txt_fund_name.TabIndex = 10
        '
        'cb_debit
        '
        Me.cb_debit.Location = New System.Drawing.Point(132, 199)
        Me.cb_debit.Name = "cb_debit"
        Me.cb_debit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cb_debit.Properties.Appearance.Options.UseFont = True
        Me.cb_debit.Properties.Caption = "Debit"
        Me.cb_debit.Size = New System.Drawing.Size(75, 22)
        Me.cb_debit.TabIndex = 45
        '
        'cb_credit
        '
        Me.cb_credit.Location = New System.Drawing.Point(213, 199)
        Me.cb_credit.Name = "cb_credit"
        Me.cb_credit.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cb_credit.Properties.Appearance.Options.UseFont = True
        Me.cb_credit.Properties.Caption = "Credit"
        Me.cb_credit.Size = New System.Drawing.Size(75, 22)
        Me.cb_credit.TabIndex = 46
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 202)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(106, 16)
        Me.LabelControl3.TabIndex = 47
        Me.LabelControl3.Text = "Transaction Type"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 162)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl5.TabIndex = 48
        Me.LabelControl5.Text = "Account Type"
        '
        'cbb_account_type
        '
        Me.cbb_account_type.Location = New System.Drawing.Point(104, 157)
        Me.cbb_account_type.Name = "cbb_account_type"
        Me.cbb_account_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_account_type.Properties.Items.AddRange(New Object() {"Savings", "Checking"})
        Me.cbb_account_type.Size = New System.Drawing.Size(128, 28)
        Me.cbb_account_type.TabIndex = 49
        '
        'frm_admin_banks_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 313)
        Me.Controls.Add(Me.cbb_account_type)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cb_credit)
        Me.Controls.Add(Me.cb_debit)
        Me.Controls.Add(Me.lbl_fund_name)
        Me.Controls.Add(Me.txt_fund_name)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.toggle_status)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_bank_name)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_bank_no)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_admin_banks_new.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_banks_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Bank"
        CType(Me.txt_bank_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_bank_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fund_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_debit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_credit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_account_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_bank_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_bank_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents toggle_status As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_fund_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_fund_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cb_debit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents cb_credit As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_account_type As DevExpress.XtraEditors.ComboBoxEdit
End Class
