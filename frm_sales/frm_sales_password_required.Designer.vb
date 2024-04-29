<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_password_required
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_password_required))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_password = New DevExpress.XtraEditors.TextEdit()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Maximum Tries Reached!" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Enter Admin Password to continue:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_password
        '
        Me.txt_password.EditValue = ""
        Me.txt_password.Location = New System.Drawing.Point(54, 77)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_password.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_password.Properties.LookAndFeel.SkinName = "WXI"
        Me.txt_password.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_password.Properties.UseSystemPasswordChar = True
        Me.txt_password.Size = New System.Drawing.Size(190, 38)
        Me.txt_password.TabIndex = 1
        '
        'btn_close
        '
        Me.btn_close.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_close.Location = New System.Drawing.Point(54, 121)
        Me.btn_close.LookAndFeel.SkinName = "WXI"
        Me.btn_close.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(91, 32)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Cancel"
        '
        'btn_submit
        '
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_submit.Location = New System.Drawing.Point(151, 121)
        Me.btn_submit.LookAndFeel.SkinName = "WXI"
        Me.btn_submit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(91, 32)
        Me.btn_submit.TabIndex = 3
        Me.btn_submit.Text = "Submit"
        '
        'frm_sales_password_required
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(300, 176)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sales_password_required"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Password Required"
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
End Class
