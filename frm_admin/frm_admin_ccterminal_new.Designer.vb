<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_ccterminal_new
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
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_fund_name = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_terminal_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_terminal_id = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_fund_name = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_terminal_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_terminal_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_fund_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(12, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(158, 24)
        Me.lbl_title.TabIndex = 7
        Me.lbl_title.Text = "Add New Terminal"
        '
        'lbl_fund_name
        '
        Me.lbl_fund_name.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fund_name.Appearance.Options.UseFont = True
        Me.lbl_fund_name.Location = New System.Drawing.Point(12, 118)
        Me.lbl_fund_name.Name = "lbl_fund_name"
        Me.lbl_fund_name.Size = New System.Drawing.Size(90, 16)
        Me.lbl_fund_name.TabIndex = 58
        Me.lbl_fund_name.Text = "Assigned Fund"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(122, 186)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(80, 37)
        Me.btn_cancel.TabIndex = 53
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_save
        '
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Location = New System.Drawing.Point(208, 186)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 37)
        Me.btn_save.TabIndex = 52
        Me.btn_save.Text = "Save"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl2.TabIndex = 51
        Me.LabelControl2.Text = "Name"
        '
        'txt_terminal_name
        '
        Me.txt_terminal_name.Location = New System.Drawing.Point(92, 82)
        Me.txt_terminal_name.Name = "txt_terminal_name"
        Me.txt_terminal_name.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terminal_name.Properties.Appearance.Options.UseFont = True
        Me.txt_terminal_name.Size = New System.Drawing.Size(194, 30)
        Me.txt_terminal_name.TabIndex = 50
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(10, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl1.TabIndex = 49
        Me.LabelControl1.Text = "Terminal ID"
        '
        'txt_terminal_id
        '
        Me.txt_terminal_id.Location = New System.Drawing.Point(92, 46)
        Me.txt_terminal_id.Name = "txt_terminal_id"
        Me.txt_terminal_id.Properties.AllowFocused = False
        Me.txt_terminal_id.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terminal_id.Properties.Appearance.Options.UseFont = True
        Me.txt_terminal_id.Properties.ReadOnly = True
        Me.txt_terminal_id.Size = New System.Drawing.Size(52, 30)
        Me.txt_terminal_id.TabIndex = 48
        '
        'cbb_fund_name
        '
        Me.cbb_fund_name.Location = New System.Drawing.Point(12, 142)
        Me.cbb_fund_name.Name = "cbb_fund_name"
        Me.cbb_fund_name.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_fund_name.Size = New System.Drawing.Size(276, 28)
        Me.cbb_fund_name.TabIndex = 59
        '
        'btn_delete
        '
        Me.btn_delete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_delete.Appearance.Options.UseBackColor = True
        Me.btn_delete.Location = New System.Drawing.Point(10, 186)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(80, 37)
        Me.btn_delete.TabIndex = 60
        Me.btn_delete.Text = "Delete"
        '
        'frm_admin_ccterminal_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 235)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.cbb_fund_name)
        Me.Controls.Add(Me.lbl_fund_name)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_terminal_name)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_terminal_id)
        Me.Controls.Add(Me.lbl_title)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_ccterminal_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Terminal"
        CType(Me.txt_terminal_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_terminal_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_fund_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_fund_name As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_terminal_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_terminal_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_fund_name As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
End Class
