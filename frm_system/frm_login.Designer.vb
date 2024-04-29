<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_login
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_login))
        Me.lbl_username = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_pass = New DevExpress.XtraEditors.LabelControl()
        Me.Err = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.btn_validate = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_login = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Err, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_username
        '
        Me.lbl_username.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_username.Appearance.Options.UseFont = True
        Me.lbl_username.Appearance.Options.UseForeColor = True
        Me.lbl_username.Location = New System.Drawing.Point(173, 16)
        Me.lbl_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(71, 21)
        Me.lbl_username.TabIndex = 5
        Me.lbl_username.Text = "Username"
        '
        'lbl_pass
        '
        Me.lbl_pass.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Appearance.ForeColor = System.Drawing.Color.Black
        Me.lbl_pass.Appearance.Options.UseFont = True
        Me.lbl_pass.Appearance.Options.UseForeColor = True
        Me.lbl_pass.Location = New System.Drawing.Point(173, 81)
        Me.lbl_pass.LookAndFeel.SkinName = "Office 2010 Silver"
        Me.lbl_pass.LookAndFeel.UseDefaultLookAndFeel = False
        Me.lbl_pass.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(67, 21)
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
        Me.txt_username.Location = New System.Drawing.Point(173, 44)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(193, 32)
        Me.txt_username.TabIndex = 10
        Me.txt_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_password.Location = New System.Drawing.Point(173, 105)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(193, 32)
        Me.txt_password.TabIndex = 11
        Me.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txt_password.UseSystemPasswordChar = True
        '
        'btn_validate
        '
        Me.btn_validate.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_validate.Appearance.Options.UseForeColor = True
        Me.btn_validate.Location = New System.Drawing.Point(273, 150)
        Me.btn_validate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_validate.Name = "btn_validate"
        Me.btn_validate.Size = New System.Drawing.Size(93, 49)
        Me.btn_validate.TabIndex = 12
        Me.btn_validate.Text = "Validate"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Options.UseTextOptions = True
        Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.LabelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl1.Location = New System.Drawing.Point(18, 149)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(144, 65)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Please login with the provided credentials."
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inventory_Management.My.Resources.Resources.man_key
        Me.PictureEdit1.Location = New System.Drawing.Point(22, 16)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Properties.SvgImageSize = New System.Drawing.Size(10, 10)
        Me.PictureEdit1.Size = New System.Drawing.Size(144, 142)
        Me.PictureEdit1.TabIndex = 14
        '
        'btn_close
        '
        Me.btn_close.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_close.Appearance.Options.UseForeColor = True
        Me.btn_close.Location = New System.Drawing.Point(173, 150)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(93, 49)
        Me.btn_close.TabIndex = 13
        Me.btn_close.Text = "Close"
        '
        'cbb_warehouse
        '
        Me.cbb_warehouse.Location = New System.Drawing.Point(15, 42)
        Me.cbb_warehouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_warehouse.Name = "cbb_warehouse"
        Me.cbb_warehouse.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cbb_warehouse.Properties.Appearance.Options.UseFont = True
        Me.cbb_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_warehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_warehouse.Size = New System.Drawing.Size(252, 42)
        Me.cbb_warehouse.TabIndex = 16
        '
        'btn_login
        '
        Me.btn_login.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_login.Appearance.ForeColor = System.Drawing.Color.Black
        Me.btn_login.Appearance.Options.UseBackColor = True
        Me.btn_login.Appearance.Options.UseForeColor = True
        Me.btn_login.Location = New System.Drawing.Point(274, 42)
        Me.btn_login.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(93, 42)
        Me.btn_login.TabIndex = 17
        Me.btn_login.Text = "Log IN"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.Label1)
        Me.PanelControl1.Controls.Add(Me.cbb_warehouse)
        Me.PanelControl1.Controls.Add(Me.btn_login)
        Me.PanelControl1.Location = New System.Drawing.Point(-1, 222)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(392, 102)
        Me.PanelControl1.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 16)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Select designation:"
        '
        'frm_login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(386, 236)
        Me.ControlBox = False
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureEdit1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.lbl_pass)
        Me.Controls.Add(Me.btn_validate)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IconOptions.Icon = CType(resources.GetObject("frm_login.IconOptions.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Err, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_username As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_pass As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Err As ErrorProvider
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_username As TextBox
    Friend WithEvents btn_validate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbb_warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_login As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
End Class
