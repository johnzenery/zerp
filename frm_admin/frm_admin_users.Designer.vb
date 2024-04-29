<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_users
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLinePanel1 = New Guna.UI.WinForms.GunaLinePanel()
        Me.cbb_store = New Guna.UI.WinForms.GunaComboBox()
        Me.pb_user = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_role = New Guna.UI.WinForms.GunaComboBox()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_add_user = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_password = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_username = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_fname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.GunaLinePanel2 = New Guna.UI.WinForms.GunaLinePanel()
        Me.panel_loading = New System.Windows.Forms.Panel()
        Me.ProgressPanel1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_update_photo = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_view_store = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.link_disable = New System.Windows.Forms.LinkLabel()
        Me.btn_edit_roles = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_userid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_view_role = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_viewpass = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_view_update = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_view_pass = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_view_username = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_view_fname = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.pb_view_user = New DevExpress.XtraEditors.PictureEdit()
        Me.grid_users = New System.Windows.Forms.DataGridView()
        Me.col_pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_store = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GunaLinePanel3 = New Guna.UI.WinForms.GunaLinePanel()
        Me.btn_new_row = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_roles_update = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_roles = New DevExpress.XtraGrid.GridControl()
        Me.grid_roles_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_role_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_role = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.bgw_load_account = New System.ComponentModel.BackgroundWorker()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaLinePanel1.SuspendLayout()
        CType(Me.pb_user.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaLinePanel2.SuspendLayout()
        Me.panel_loading.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cbb_view_store.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_view_role.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_view_pass.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_view_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_view_fname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pb_view_user.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GunaLinePanel3.SuspendLayout()
        CType(Me.grid_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_roles_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.GunaLabel2)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1182, 78)
        Me.panel_top.TabIndex = 8
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1158, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.link_po_list)
        Me.GunaPanel1.Controls.Add(Me.LabelControl7)
        Me.GunaPanel1.Controls.Add(Me.link_home)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 1
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.Enabled = False
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(88, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "User Accounts"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        '
        'link_home
        '
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_home.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_home.Location = New System.Drawing.Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(192, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "User Accounts"
        '
        'GunaLinePanel1
        '
        Me.GunaLinePanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel1.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaLinePanel1.Controls.Add(Me.cbb_store)
        Me.GunaLinePanel1.Controls.Add(Me.pb_user)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl6)
        Me.GunaLinePanel1.Controls.Add(Me.cbb_role)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl5)
        Me.GunaLinePanel1.Controls.Add(Me.btn_add_user)
        Me.GunaLinePanel1.Controls.Add(Me.txt_password)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl4)
        Me.GunaLinePanel1.Controls.Add(Me.txt_username)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl3)
        Me.GunaLinePanel1.Controls.Add(Me.txt_fname)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl1)
        Me.GunaLinePanel1.Controls.Add(Me.LabelControl18)
        Me.GunaLinePanel1.Controls.Add(Me.SeparatorControl1)
        Me.GunaLinePanel1.LineBottom = 1
        Me.GunaLinePanel1.LineColor = System.Drawing.SystemColors.Control
        Me.GunaLinePanel1.LineLeft = 1
        Me.GunaLinePanel1.LineRight = 1
        Me.GunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel1.LineTop = 1
        Me.GunaLinePanel1.Location = New System.Drawing.Point(3, 3)
        Me.GunaLinePanel1.Name = "GunaLinePanel1"
        Me.GunaLinePanel1.Size = New System.Drawing.Size(375, 350)
        Me.GunaLinePanel1.TabIndex = 9
        '
        'cbb_store
        '
        Me.cbb_store.BackColor = System.Drawing.Color.Transparent
        Me.cbb_store.BaseColor = System.Drawing.Color.White
        Me.cbb_store.BorderColor = System.Drawing.Color.Silver
        Me.cbb_store.BorderSize = 1
        Me.cbb_store.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_store.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_store.FocusedColor = System.Drawing.Color.Empty
        Me.cbb_store.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_store.ForeColor = System.Drawing.Color.Black
        Me.cbb_store.FormattingEnabled = True
        Me.cbb_store.Items.AddRange(New Object() {"-- Store ---"})
        Me.cbb_store.Location = New System.Drawing.Point(18, 251)
        Me.cbb_store.Name = "cbb_store"
        Me.cbb_store.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbb_store.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbb_store.Size = New System.Drawing.Size(160, 23)
        Me.cbb_store.StartIndex = 0
        Me.cbb_store.TabIndex = 69
        '
        'pb_user
        '
        Me.pb_user.Location = New System.Drawing.Point(18, 54)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.pb_user.Properties.Appearance.Options.UseFont = True
        Me.pb_user.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.pb_user.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pb_user.Properties.NullText = "Click to Upload"
        Me.pb_user.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pb_user.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pb_user.Size = New System.Drawing.Size(160, 160)
        Me.pb_user.TabIndex = 68
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(18, 231)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl6.TabIndex = 67
        Me.LabelControl6.Text = "Store Assign:"
        '
        'cbb_role
        '
        Me.cbb_role.BackColor = System.Drawing.Color.Transparent
        Me.cbb_role.BaseColor = System.Drawing.Color.White
        Me.cbb_role.BorderColor = System.Drawing.Color.Silver
        Me.cbb_role.BorderSize = 1
        Me.cbb_role.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbb_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbb_role.FocusedColor = System.Drawing.Color.Empty
        Me.cbb_role.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_role.ForeColor = System.Drawing.Color.Black
        Me.cbb_role.FormattingEnabled = True
        Me.cbb_role.Items.AddRange(New Object() {"-- Role ---"})
        Me.cbb_role.Location = New System.Drawing.Point(192, 251)
        Me.cbb_role.Name = "cbb_role"
        Me.cbb_role.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cbb_role.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cbb_role.Size = New System.Drawing.Size(156, 23)
        Me.cbb_role.StartIndex = 0
        Me.cbb_role.TabIndex = 62
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(192, 231)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl5.TabIndex = 61
        Me.LabelControl5.Text = "User Role:"
        '
        'btn_add_user
        '
        Me.btn_add_user.Appearance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_add_user.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_add_user.Appearance.Options.UseBackColor = True
        Me.btn_add_user.Appearance.Options.UseBorderColor = True
        Me.btn_add_user.Appearance.Options.UseTextOptions = True
        Me.btn_add_user.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_add_user.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.editcontact_16x16
        Me.btn_add_user.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add_user.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.btn_add_user.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_add_user.Location = New System.Drawing.Point(18, 295)
        Me.btn_add_user.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_add_user.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_add_user.Name = "btn_add_user"
        Me.btn_add_user.Size = New System.Drawing.Size(330, 34)
        Me.btn_add_user.TabIndex = 60
        Me.btn_add_user.Text = "Create Account"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(192, 186)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_password.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_password.Size = New System.Drawing.Size(160, 24)
        Me.txt_password.TabIndex = 59
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(192, 164)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "Password:"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(192, 136)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_username.Properties.Appearance.Options.UseFont = True
        Me.txt_username.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_username.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_username.Size = New System.Drawing.Size(160, 24)
        Me.txt_username.TabIndex = 57
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(192, 114)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl3.TabIndex = 56
        Me.LabelControl3.Text = "Username:"
        '
        'txt_fname
        '
        Me.txt_fname.Location = New System.Drawing.Point(192, 85)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_fname.Properties.Appearance.Options.UseFont = True
        Me.txt_fname.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_fname.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_fname.Size = New System.Drawing.Size(160, 24)
        Me.txt_fname.TabIndex = 53
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(192, 63)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl1.TabIndex = 52
        Me.LabelControl1.Text = "Full Name:"
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl18.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl18.Location = New System.Drawing.Point(18, 9)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(83, 24)
        Me.LabelControl18.TabIndex = 50
        Me.LabelControl18.Text = "New User"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.LineAlignment = DevExpress.XtraEditors.Alignment.Near
        Me.SeparatorControl1.LineThickness = 1
        Me.SeparatorControl1.Location = New System.Drawing.Point(3, 26)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(357, 23)
        Me.SeparatorControl1.TabIndex = 51
        '
        'GunaLinePanel2
        '
        Me.GunaLinePanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaLinePanel2.Controls.Add(Me.panel_loading)
        Me.GunaLinePanel2.Controls.Add(Me.GroupBox1)
        Me.GunaLinePanel2.Controls.Add(Me.grid_users)
        Me.GunaLinePanel2.Controls.Add(Me.LabelControl12)
        Me.GunaLinePanel2.Controls.Add(Me.SeparatorControl2)
        Me.GunaLinePanel2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLinePanel2.LineBottom = 1
        Me.GunaLinePanel2.LineColor = System.Drawing.SystemColors.Control
        Me.GunaLinePanel2.LineLeft = 1
        Me.GunaLinePanel2.LineRight = 1
        Me.GunaLinePanel2.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel2.LineTop = 1
        Me.GunaLinePanel2.Location = New System.Drawing.Point(384, 3)
        Me.GunaLinePanel2.Name = "GunaLinePanel2"
        Me.GunaLinePanel2.Size = New System.Drawing.Size(709, 706)
        Me.GunaLinePanel2.TabIndex = 10
        '
        'panel_loading
        '
        Me.panel_loading.Controls.Add(Me.ProgressPanel1)
        Me.panel_loading.Location = New System.Drawing.Point(10, 43)
        Me.panel_loading.Name = "panel_loading"
        Me.panel_loading.Size = New System.Drawing.Size(688, 10)
        Me.panel_loading.TabIndex = 93
        '
        'ProgressPanel1
        '
        Me.ProgressPanel1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel1.Appearance.Options.UseBackColor = True
        Me.ProgressPanel1.Location = New System.Drawing.Point(280, 96)
        Me.ProgressPanel1.Name = "ProgressPanel1"
        Me.ProgressPanel1.Size = New System.Drawing.Size(150, 83)
        Me.ProgressPanel1.TabIndex = 93
        Me.ProgressPanel1.Text = "ProgressPanel1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_update_photo)
        Me.GroupBox1.Controls.Add(Me.cbb_view_store)
        Me.GroupBox1.Controls.Add(Me.link_disable)
        Me.GroupBox1.Controls.Add(Me.btn_edit_roles)
        Me.GroupBox1.Controls.Add(Me.txt_userid)
        Me.GroupBox1.Controls.Add(Me.LabelControl15)
        Me.GroupBox1.Controls.Add(Me.cbb_view_role)
        Me.GroupBox1.Controls.Add(Me.LabelControl14)
        Me.GroupBox1.Controls.Add(Me.btn_viewpass)
        Me.GroupBox1.Controls.Add(Me.btn_view_update)
        Me.GroupBox1.Controls.Add(Me.txt_view_pass)
        Me.GroupBox1.Controls.Add(Me.LabelControl13)
        Me.GroupBox1.Controls.Add(Me.LabelControl11)
        Me.GroupBox1.Controls.Add(Me.txt_view_username)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.txt_view_fname)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.pb_view_user)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(680, 256)
        Me.GroupBox1.TabIndex = 92
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Account Details"
        '
        'btn_update_photo
        '
        Me.btn_update_photo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update_photo.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_update_photo.Appearance.Options.UseFont = True
        Me.btn_update_photo.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_update_photo.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.btn_update_photo.Location = New System.Drawing.Point(469, 170)
        Me.btn_update_photo.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_update_photo.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_update_photo.Name = "btn_update_photo"
        Me.btn_update_photo.Size = New System.Drawing.Size(145, 23)
        Me.btn_update_photo.TabIndex = 96
        Me.btn_update_photo.Text = "Select Photo"
        '
        'cbb_view_store
        '
        Me.cbb_view_store.EditValue = "-- Store Assignment --"
        Me.cbb_view_store.Location = New System.Drawing.Point(254, 72)
        Me.cbb_view_store.Name = "cbb_view_store"
        Me.cbb_view_store.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_view_store.Properties.Items.AddRange(New Object() {"-- Store Assignment --"})
        Me.cbb_view_store.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.cbb_view_store.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbb_view_store.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_view_store.Size = New System.Drawing.Size(162, 20)
        Me.cbb_view_store.TabIndex = 95
        '
        'link_disable
        '
        Me.link_disable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.link_disable.AutoSize = True
        Me.link_disable.Location = New System.Drawing.Point(423, 215)
        Me.link_disable.Name = "link_disable"
        Me.link_disable.Size = New System.Drawing.Size(115, 14)
        Me.link_disable.TabIndex = 94
        Me.link_disable.TabStop = True
        Me.link_disable.Text = "Disable this account"
        Me.link_disable.Visible = False
        '
        'btn_edit_roles
        '
        Me.btn_edit_roles.Appearance.BackColor = System.Drawing.Color.LimeGreen
        Me.btn_edit_roles.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_edit_roles.Appearance.Options.UseBackColor = True
        Me.btn_edit_roles.Appearance.Options.UseFont = True
        Me.btn_edit_roles.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.reviewallowuserstoeditranges_16x16
        Me.btn_edit_roles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_edit_roles.Location = New System.Drawing.Point(19, 206)
        Me.btn_edit_roles.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_edit_roles.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit_roles.Name = "btn_edit_roles"
        Me.btn_edit_roles.Size = New System.Drawing.Size(162, 31)
        Me.btn_edit_roles.TabIndex = 91
        Me.btn_edit_roles.Text = "Edit Roles Access"
        '
        'txt_userid
        '
        Me.txt_userid.Enabled = False
        Me.txt_userid.Location = New System.Drawing.Point(89, 44)
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_userid.Properties.Appearance.Options.UseFont = True
        Me.txt_userid.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_userid.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_userid.Size = New System.Drawing.Size(150, 22)
        Me.txt_userid.TabIndex = 89
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(19, 47)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(44, 14)
        Me.LabelControl15.TabIndex = 88
        Me.LabelControl15.Text = "User ID:"
        '
        'cbb_view_role
        '
        Me.cbb_view_role.EditValue = "-- Role ---"
        Me.cbb_view_role.Location = New System.Drawing.Point(254, 121)
        Me.cbb_view_role.Name = "cbb_view_role"
        Me.cbb_view_role.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_view_role.Properties.Appearance.Options.UseFont = True
        Me.cbb_view_role.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_view_role.Properties.Items.AddRange(New Object() {"-- Role ---"})
        Me.cbb_view_role.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.cbb_view_role.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbb_view_role.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_view_role.Size = New System.Drawing.Size(162, 20)
        Me.cbb_view_role.TabIndex = 87
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(254, 101)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl14.TabIndex = 86
        Me.LabelControl14.Text = "User Role:"
        '
        'btn_viewpass
        '
        Me.btn_viewpass.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_viewpass.Appearance.Options.UseFont = True
        Me.btn_viewpass.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.show_16x16
        Me.btn_viewpass.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.RightCenter
        Me.btn_viewpass.Location = New System.Drawing.Point(210, 142)
        Me.btn_viewpass.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_viewpass.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_viewpass.Name = "btn_viewpass"
        Me.btn_viewpass.Size = New System.Drawing.Size(29, 24)
        Me.btn_viewpass.TabIndex = 85
        '
        'btn_view_update
        '
        Me.btn_view_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_view_update.Appearance.BackColor = System.Drawing.Color.DarkTurquoise
        Me.btn_view_update.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_view_update.Appearance.Options.UseBackColor = True
        Me.btn_view_update.Appearance.Options.UseFont = True
        Me.btn_view_update.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.save_16x16
        Me.btn_view_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view_update.Location = New System.Drawing.Point(544, 206)
        Me.btn_view_update.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_view_update.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_update.Name = "btn_view_update"
        Me.btn_view_update.Size = New System.Drawing.Size(112, 31)
        Me.btn_view_update.TabIndex = 84
        Me.btn_view_update.Text = "Update"
        '
        'txt_view_pass
        '
        Me.txt_view_pass.Location = New System.Drawing.Point(89, 142)
        Me.txt_view_pass.Name = "txt_view_pass"
        Me.txt_view_pass.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_view_pass.Properties.Appearance.Options.UseFont = True
        Me.txt_view_pass.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_view_pass.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_view_pass.Properties.UseSystemPasswordChar = True
        Me.txt_view_pass.Size = New System.Drawing.Size(122, 22)
        Me.txt_view_pass.TabIndex = 83
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(19, 145)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl13.TabIndex = 82
        Me.LabelControl13.Text = "Password:"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(254, 50)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(86, 14)
        Me.LabelControl11.TabIndex = 80
        Me.LabelControl11.Text = "Assigned Store:"
        '
        'txt_view_username
        '
        Me.txt_view_username.Location = New System.Drawing.Point(89, 112)
        Me.txt_view_username.Name = "txt_view_username"
        Me.txt_view_username.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_view_username.Properties.Appearance.Options.UseFont = True
        Me.txt_view_username.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_view_username.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_view_username.Size = New System.Drawing.Size(150, 22)
        Me.txt_view_username.TabIndex = 79
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(19, 115)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(58, 14)
        Me.LabelControl10.TabIndex = 78
        Me.LabelControl10.Text = "Username:"
        '
        'txt_view_fname
        '
        Me.txt_view_fname.Location = New System.Drawing.Point(89, 74)
        Me.txt_view_fname.Name = "txt_view_fname"
        Me.txt_view_fname.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_view_fname.Properties.Appearance.Options.UseFont = True
        Me.txt_view_fname.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_view_fname.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_view_fname.Size = New System.Drawing.Size(150, 22)
        Me.txt_view_fname.TabIndex = 75
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(19, 77)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(56, 14)
        Me.LabelControl8.TabIndex = 74
        Me.LabelControl8.Text = "Full Name:"
        '
        'pb_view_user
        '
        Me.pb_view_user.Location = New System.Drawing.Point(469, 21)
        Me.pb_view_user.Name = "pb_view_user"
        Me.pb_view_user.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.pb_view_user.Properties.Appearance.Options.UseFont = True
        Me.pb_view_user.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.pb_view_user.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.pb_view_user.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pb_view_user.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        Me.pb_view_user.Size = New System.Drawing.Size(145, 145)
        Me.pb_view_user.TabIndex = 73
        '
        'grid_users
        '
        Me.grid_users.AllowUserToAddRows = False
        Me.grid_users.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_users.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_users.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_users.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_users.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_users.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_users.ColumnHeadersHeight = 28
        Me.grid_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_users.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pid, Me.col_qty, Me.col_username, Me.col_description, Me.col_store, Me.col_status})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_users.DefaultCellStyle = DataGridViewCellStyle4
        Me.grid_users.EnableHeadersVisualStyles = False
        Me.grid_users.Location = New System.Drawing.Point(21, 327)
        Me.grid_users.MultiSelect = False
        Me.grid_users.Name = "grid_users"
        Me.grid_users.ReadOnly = True
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_users.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grid_users.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_users.Size = New System.Drawing.Size(671, 349)
        Me.grid_users.TabIndex = 72
        '
        'col_pid
        '
        Me.col_pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_pid.DataPropertyName = "usr_id"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_pid.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_pid.FillWeight = 80.0!
        Me.col_pid.HeaderText = "User ID"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.ReadOnly = True
        Me.col_pid.Width = 80
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty.DataPropertyName = "first_name"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Full Name"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.ReadOnly = True
        Me.col_qty.Width = 150
        '
        'col_username
        '
        Me.col_username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_username.DataPropertyName = "username"
        Me.col_username.HeaderText = "Username"
        Me.col_username.Name = "col_username"
        Me.col_username.ReadOnly = True
        Me.col_username.Width = 120
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_description.DataPropertyName = "role"
        Me.col_description.HeaderText = "Role"
        Me.col_description.Name = "col_description"
        Me.col_description.ReadOnly = True
        Me.col_description.Width = 130
        '
        'col_store
        '
        Me.col_store.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_store.DataPropertyName = "store_name"
        Me.col_store.FillWeight = 200.0!
        Me.col_store.HeaderText = "Assigned Store"
        Me.col_store.Name = "col_store"
        Me.col_store.ReadOnly = True
        Me.col_store.Width = 220
        '
        'col_status
        '
        Me.col_status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_status.DataPropertyName = "status"
        Me.col_status.HeaderText = "Status"
        Me.col_status.Name = "col_status"
        Me.col_status.ReadOnly = True
        Me.col_status.Width = 80
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl12.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl12.Location = New System.Drawing.Point(18, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(123, 24)
        Me.LabelControl12.TabIndex = 50
        Me.LabelControl12.Text = "User Accounts"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.LineAlignment = DevExpress.XtraEditors.Alignment.Near
        Me.SeparatorControl2.LineThickness = 1
        Me.SeparatorControl2.Location = New System.Drawing.Point(3, 26)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Size = New System.Drawing.Size(690, 23)
        Me.SeparatorControl2.TabIndex = 51
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel2.Controls.Add(Me.GunaLinePanel3)
        Me.Panel2.Controls.Add(Me.GunaLinePanel1)
        Me.Panel2.Controls.Add(Me.GunaLinePanel2)
        Me.Panel2.Location = New System.Drawing.Point(24, 93)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1096, 729)
        Me.Panel2.TabIndex = 0
        '
        'GunaLinePanel3
        '
        Me.GunaLinePanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLinePanel3.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaLinePanel3.Controls.Add(Me.btn_new_row)
        Me.GunaLinePanel3.Controls.Add(Me.btn_roles_update)
        Me.GunaLinePanel3.Controls.Add(Me.grid_roles)
        Me.GunaLinePanel3.Controls.Add(Me.LabelControl20)
        Me.GunaLinePanel3.Controls.Add(Me.SeparatorControl3)
        Me.GunaLinePanel3.LineBottom = 1
        Me.GunaLinePanel3.LineColor = System.Drawing.SystemColors.Control
        Me.GunaLinePanel3.LineLeft = 1
        Me.GunaLinePanel3.LineRight = 1
        Me.GunaLinePanel3.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.GunaLinePanel3.LineTop = 1
        Me.GunaLinePanel3.Location = New System.Drawing.Point(3, 359)
        Me.GunaLinePanel3.Name = "GunaLinePanel3"
        Me.GunaLinePanel3.Size = New System.Drawing.Size(375, 350)
        Me.GunaLinePanel3.TabIndex = 11
        '
        'btn_new_row
        '
        Me.btn_new_row.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_new_row.Appearance.Options.UseFont = True
        Me.btn_new_row.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newemployee_16x16
        Me.btn_new_row.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_row.Location = New System.Drawing.Point(124, 309)
        Me.btn_new_row.Name = "btn_new_row"
        Me.btn_new_row.Size = New System.Drawing.Size(114, 31)
        Me.btn_new_row.TabIndex = 86
        Me.btn_new_row.Text = "New Role"
        '
        'btn_roles_update
        '
        Me.btn_roles_update.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_roles_update.Appearance.Options.UseFont = True
        Me.btn_roles_update.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.recurrence_16x16
        Me.btn_roles_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_roles_update.Location = New System.Drawing.Point(244, 309)
        Me.btn_roles_update.Name = "btn_roles_update"
        Me.btn_roles_update.Size = New System.Drawing.Size(114, 31)
        Me.btn_roles_update.TabIndex = 85
        Me.btn_roles_update.Text = "Update"
        '
        'grid_roles
        '
        Me.grid_roles.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grid_roles.Location = New System.Drawing.Point(18, 51)
        Me.grid_roles.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_roles.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_roles.MainView = Me.grid_roles_view
        Me.grid_roles.Name = "grid_roles"
        Me.grid_roles.Size = New System.Drawing.Size(340, 250)
        Me.grid_roles.TabIndex = 52
        Me.grid_roles.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_roles_view})
        '
        'grid_roles_view
        '
        Me.grid_roles_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_roles_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_roles_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_role_id, Me.col_role})
        Me.grid_roles_view.GridControl = Me.grid_roles
        Me.grid_roles_view.Name = "grid_roles_view"
        Me.grid_roles_view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_role_id
        '
        Me.col_role_id.Caption = "Role ID"
        Me.col_role_id.FieldName = "role_id"
        Me.col_role_id.Name = "col_role_id"
        Me.col_role_id.OptionsColumn.AllowEdit = False
        Me.col_role_id.OptionsColumn.AllowSize = False
        Me.col_role_id.OptionsColumn.FixedWidth = True
        Me.col_role_id.OptionsColumn.ReadOnly = True
        Me.col_role_id.Visible = True
        Me.col_role_id.VisibleIndex = 0
        Me.col_role_id.Width = 57
        '
        'col_role
        '
        Me.col_role.Caption = "Role"
        Me.col_role.FieldName = "role"
        Me.col_role.Name = "col_role"
        Me.col_role.Visible = True
        Me.col_role.VisibleIndex = 1
        Me.col_role.Width = 256
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelControl20.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseForeColor = True
        Me.LabelControl20.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom
        Me.LabelControl20.LineOrientation = DevExpress.XtraEditors.LabelLineOrientation.Horizontal
        Me.LabelControl20.Location = New System.Drawing.Point(18, 9)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(48, 24)
        Me.LabelControl20.TabIndex = 50
        Me.LabelControl20.Text = "Roles"
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.LineAlignment = DevExpress.XtraEditors.Alignment.Near
        Me.SeparatorControl3.LineThickness = 1
        Me.SeparatorControl3.Location = New System.Drawing.Point(3, 26)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Size = New System.Drawing.Size(369, 23)
        Me.SeparatorControl3.TabIndex = 51
        '
        'bgw_load_account
        '
        '
        'frm_admin_users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1182, 835)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.panel_top)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Name = "frm_admin_users"
        Me.Text = "frm_users"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaLinePanel1.ResumeLayout(False)
        Me.GunaLinePanel1.PerformLayout()
        CType(Me.pb_user.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaLinePanel2.ResumeLayout(False)
        Me.GunaLinePanel2.PerformLayout()
        Me.panel_loading.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cbb_view_store.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_view_role.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_view_pass.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_view_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_view_fname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pb_view_user.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.GunaLinePanel3.ResumeLayout(False)
        Me.GunaLinePanel3.PerformLayout()
        CType(Me.grid_roles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_roles_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLinePanel1 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents txt_fname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btn_add_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_role As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GunaLinePanel2 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pb_user As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents grid_users As DataGridView
    Friend WithEvents btn_view_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_view_pass As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_view_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_view_fname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pb_view_user As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents btn_viewpass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbb_view_role As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_userid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_edit_roles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbb_store As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents link_disable As LinkLabel
    Friend WithEvents cbb_view_store As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaLinePanel3 As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents grid_roles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_roles_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents col_role_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_role As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_roles_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_new_row As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_loading As Panel
    Friend WithEvents ProgressPanel1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents bgw_load_account As System.ComponentModel.BackgroundWorker
    Friend WithEvents col_pid As DataGridViewTextBoxColumn
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_username As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_store As DataGridViewTextBoxColumn
    Friend WithEvents col_status As DataGridViewTextBoxColumn
    Friend WithEvents btn_update_photo As DevExpress.XtraEditors.SimpleButton
End Class
