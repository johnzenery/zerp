<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_username = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pass = New DevExpress.XtraEditors.LabelControl()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_login = New DevExpress.XtraEditors.SimpleButton()
        Me.err_lbl = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_username.Appearance.Options.UseFont = True
        Me.lbl_username.Appearance.Options.UseForeColor = True
        Me.lbl_username.Location = New System.Drawing.Point(141, 23)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(59, 17)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username"
        '
        'lbl_pass
        '
        Me.lbl_pass.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_pass.Appearance.Options.UseFont = True
        Me.lbl_pass.Appearance.Options.UseForeColor = True
        Me.lbl_pass.Location = New System.Drawing.Point(141, 76)
        Me.lbl_pass.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.lbl_pass.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(56, 17)
        Me.lbl_pass.TabIndex = 6
        Me.lbl_pass.Text = "Password"
        '
        'Err
        '
        Me.Err.ContainerControl = Me
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_username.Location = New System.Drawing.Point(141, 46)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(166, 27)
        Me.txt_username.TabIndex = 10
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(141, 95)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(166, 27)
        Me.txt_password.TabIndex = 11
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_login
        '
        Me.btn_login.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Appearance.Options.UseForeColor = True
        Me.btn_login.Location = New System.Drawing.Point(227, 132)
        Me.btn_login.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.btn_login.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(80, 40)
        Me.btn_login.TabIndex = 12
        Me.btn_login.Text = "Log IN"
        '
        'err_lbl
        '
        Me.err_lbl.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.err_lbl.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.err_lbl.Appearance.Options.UseFont = True
        Me.err_lbl.Appearance.Options.UseForeColor = True
        Me.err_lbl.Appearance.Options.UseTextOptions = True
        Me.err_lbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.err_lbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.err_lbl.Location = New System.Drawing.Point(141, 178)
        Me.err_lbl.Name = "err_lbl"
        Me.err_lbl.Size = New System.Drawing.Size(166, 40)
        Me.err_lbl.TabIndex = 9
        Me.err_lbl.Text = "*Incorrect credentials."
        Me.err_lbl.Visible = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
        Me.PanelControl1.Appearance.Options.UseBackColor = True
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.PictureEdit1)
        Me.PanelControl1.Controls.Add(Me.btn_close)
        Me.PanelControl1.Controls.Add(Me.txt_username)
        Me.PanelControl1.Controls.Add(Me.err_lbl)
        Me.PanelControl1.Controls.Add(Me.btn_login)
        Me.PanelControl1.Controls.Add(Me.lbl_pass)
        Me.PanelControl1.Controls.Add(Me.txt_password)
        Me.PanelControl1.Controls.Add(Me.lbl_username)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(321, 221)
        Me.PanelControl1.TabIndex = 13
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(8, 131)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(123, 53)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Please login with the provided credentials."
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inventory_Management.My.Resources.Resources.man_key
        Me.PictureEdit1.Location = New System.Drawing.Point(12, 23)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Properties.SvgImageSize = New System.Drawing.Size(10, 10)
        Me.PictureEdit1.Size = New System.Drawing.Size(123, 115)
        Me.PictureEdit1.TabIndex = 14
        '
        'btn_close
        '
        Me.btn_close.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Appearance.Options.UseForeColor = True
        Me.btn_close.Location = New System.Drawing.Point(141, 132)
        Me.btn_close.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.btn_close.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(80, 40)
        Me.btn_close.TabIndex = 13
        Me.btn_close.Text = "Close"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(321, 221)
        Me.Controls.Add(Me.PanelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Err As ErrorProvider
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_login As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents err_lbl As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
End Class
