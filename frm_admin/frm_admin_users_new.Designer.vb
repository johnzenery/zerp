<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_users_new
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
        Me.pb_user = New DevExpress.XtraEditors.PictureEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_add_user = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_password = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_username = New DevExpress.XtraEditors.TextEdit()
        Me.txt_fname = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_role = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_userid = New DevExpress.XtraEditors.TextEdit()
        Me.grid_warehouse = New DevExpress.XtraGrid.GridControl()
        Me.grid_warehouse_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_storeid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_storename = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_browse = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_view_pass = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_edit_roles = New DevExpress.XtraEditors.SimpleButton()
        Me.toggle_status = New DevExpress.XtraEditors.ToggleSwitch()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_organization = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_division = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_department = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_company_role = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.pb_user.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_fname.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_role.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_userid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_warehouse, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_warehouse_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_organization.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_division.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_department.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_company_role.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pb_user
        '
        Me.pb_user.Location = New System.Drawing.Point(12, 51)
        Me.pb_user.Name = "pb_user"
        Me.pb_user.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.pb_user.Properties.Appearance.Options.UseFont = True
        Me.pb_user.Properties.NullText = "Click to Upload"
        Me.pb_user.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pb_user.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pb_user.Size = New System.Drawing.Size(160, 160)
        Me.pb_user.TabIndex = 78
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(12, 306)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(119, 14)
        Me.LabelControl6.TabIndex = 77
        Me.LabelControl6.Text = "Select designation(s):"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(190, 248)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(67, 14)
        Me.LabelControl5.TabIndex = 76
        Me.LabelControl5.Text = "System Role"
        '
        'btn_add_user
        '
        Me.btn_add_user.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add_user.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_add_user.Appearance.Options.UseBackColor = True
        Me.btn_add_user.Appearance.Options.UseTextOptions = True
        Me.btn_add_user.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_add_user.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.editcontact_16x16
        Me.btn_add_user.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add_user.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.btn_add_user.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_add_user.Location = New System.Drawing.Point(374, 497)
        Me.btn_add_user.Name = "btn_add_user"
        Me.btn_add_user.Size = New System.Drawing.Size(135, 34)
        Me.btn_add_user.TabIndex = 6
        Me.btn_add_user.Text = "Create Account"
        '
        'txt_password
        '
        Me.txt_password.EditValue = ""
        Me.txt_password.Location = New System.Drawing.Point(266, 80)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_password.Properties.Appearance.Options.UseFont = True
        Me.txt_password.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_password.Properties.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.txt_password.Properties.UseSystemPasswordChar = True
        Me.txt_password.Size = New System.Drawing.Size(163, 32)
        Me.txt_password.TabIndex = 2
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(190, 89)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl4.TabIndex = 73
        Me.LabelControl4.Text = "Password"
        '
        'txt_username
        '
        Me.txt_username.EditValue = ""
        Me.txt_username.Location = New System.Drawing.Point(266, 46)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Properties.NullText = "Username"
        Me.txt_username.Size = New System.Drawing.Size(192, 28)
        Me.txt_username.TabIndex = 0
        '
        'txt_fname
        '
        Me.txt_fname.EditValue = ""
        Me.txt_fname.Location = New System.Drawing.Point(266, 12)
        Me.txt_fname.Name = "txt_fname"
        Me.txt_fname.Properties.NullText = "Full name"
        Me.txt_fname.Size = New System.Drawing.Size(234, 28)
        Me.txt_fname.TabIndex = 1
        '
        'cbb_role
        '
        Me.cbb_role.Location = New System.Drawing.Point(284, 238)
        Me.cbb_role.Name = "cbb_role"
        Me.cbb_role.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbb_role.Properties.Appearance.Options.UseFont = True
        Me.cbb_role.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_role.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_role.Size = New System.Drawing.Size(174, 32)
        Me.cbb_role.TabIndex = 3
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Appearance.Options.UseTextOptions = True
        Me.btn_close.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_close.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.btn_close.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_close.Location = New System.Drawing.Point(274, 497)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(94, 34)
        Me.btn_close.TabIndex = 7
        Me.btn_close.Text = "Cancel"
        '
        'txt_userid
        '
        Me.txt_userid.EditValue = ""
        Me.txt_userid.Enabled = False
        Me.txt_userid.Location = New System.Drawing.Point(12, 12)
        Me.txt_userid.Name = "txt_userid"
        Me.txt_userid.Properties.NullText = "User ID"
        Me.txt_userid.Size = New System.Drawing.Size(75, 28)
        Me.txt_userid.TabIndex = 83
        '
        'grid_warehouse
        '
        Me.grid_warehouse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_warehouse.Location = New System.Drawing.Point(12, 326)
        Me.grid_warehouse.MainView = Me.grid_warehouse_view
        Me.grid_warehouse.Name = "grid_warehouse"
        Me.grid_warehouse.Size = New System.Drawing.Size(497, 160)
        Me.grid_warehouse.TabIndex = 5
        Me.grid_warehouse.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_warehouse_view})
        '
        'grid_warehouse_view
        '
        Me.grid_warehouse_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_storeid, Me.col_storename})
        Me.grid_warehouse_view.GridControl = Me.grid_warehouse
        Me.grid_warehouse_view.Name = "grid_warehouse_view"
        Me.grid_warehouse_view.OptionsSelection.CheckBoxSelectorColumnWidth = 50
        Me.grid_warehouse_view.OptionsSelection.MultiSelect = True
        Me.grid_warehouse_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_warehouse_view.OptionsView.ShowGroupPanel = False
        '
        'col_storeid
        '
        Me.col_storeid.Caption = "ID"
        Me.col_storeid.FieldName = "store_id"
        Me.col_storeid.MaxWidth = 60
        Me.col_storeid.Name = "col_storeid"
        Me.col_storeid.OptionsColumn.AllowEdit = False
        Me.col_storeid.Visible = True
        Me.col_storeid.VisibleIndex = 1
        Me.col_storeid.Width = 50
        '
        'col_storename
        '
        Me.col_storename.Caption = "Warehouse Name"
        Me.col_storename.FieldName = "store_name"
        Me.col_storename.Name = "col_storename"
        Me.col_storename.OptionsColumn.AllowEdit = False
        Me.col_storename.Visible = True
        Me.col_storename.VisibleIndex = 2
        '
        'btn_browse
        '
        Me.btn_browse.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_browse.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.electronics_photo2
        Me.btn_browse.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btn_browse.Location = New System.Drawing.Point(12, 217)
        Me.btn_browse.Name = "btn_browse"
        Me.btn_browse.Size = New System.Drawing.Size(160, 34)
        Me.btn_browse.TabIndex = 4
        Me.btn_browse.Text = "Browse"
        '
        'btn_view_pass
        '
        Me.btn_view_pass.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.show_16x16
        Me.btn_view_pass.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view_pass.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btn_view_pass.Location = New System.Drawing.Point(426, 80)
        Me.btn_view_pass.Name = "btn_view_pass"
        Me.btn_view_pass.Size = New System.Drawing.Size(32, 32)
        Me.btn_view_pass.TabIndex = 86
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Appearance.Options.UseTextOptions = True
        Me.btn_save.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_save.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.save_16x16
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None
        Me.btn_save.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_save.Location = New System.Drawing.Point(374, 492)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(135, 34)
        Me.btn_save.TabIndex = 87
        Me.btn_save.Text = "Save"
        Me.btn_save.Visible = False
        '
        'btn_edit_roles
        '
        Me.btn_edit_roles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_edit_roles.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_edit_roles.Appearance.Options.UseFont = True
        Me.btn_edit_roles.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.reviewallowuserstoeditranges_16x16
        Me.btn_edit_roles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_edit_roles.Location = New System.Drawing.Point(127, 497)
        Me.btn_edit_roles.Name = "btn_edit_roles"
        Me.btn_edit_roles.Size = New System.Drawing.Size(118, 34)
        Me.btn_edit_roles.TabIndex = 92
        Me.btn_edit_roles.Text = "Edit Access"
        Me.btn_edit_roles.Visible = False
        '
        'toggle_status
        '
        Me.toggle_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.toggle_status.EditValue = True
        Me.toggle_status.Location = New System.Drawing.Point(12, 509)
        Me.toggle_status.Name = "toggle_status"
        Me.toggle_status.Properties.OffText = "Disabled"
        Me.toggle_status.Properties.OnText = "Enabled"
        Me.toggle_status.Size = New System.Drawing.Size(109, 24)
        Me.toggle_status.TabIndex = 93
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 492)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(39, 14)
        Me.LabelControl7.TabIndex = 94
        Me.LabelControl7.Text = "Status:"
        '
        'cbb_organization
        '
        Me.cbb_organization.Location = New System.Drawing.Point(266, 126)
        Me.cbb_organization.Name = "cbb_organization"
        Me.cbb_organization.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_organization.Size = New System.Drawing.Size(234, 28)
        Me.cbb_organization.TabIndex = 95
        '
        'cbb_division
        '
        Me.cbb_division.Location = New System.Drawing.Point(266, 160)
        Me.cbb_division.Name = "cbb_division"
        Me.cbb_division.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_division.Size = New System.Drawing.Size(234, 28)
        Me.cbb_division.TabIndex = 96
        '
        'cbb_department
        '
        Me.cbb_department.Location = New System.Drawing.Point(266, 194)
        Me.cbb_department.Name = "cbb_department"
        Me.cbb_department.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_department.Size = New System.Drawing.Size(234, 28)
        Me.cbb_department.TabIndex = 97
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(190, 133)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl1.TabIndex = 98
        Me.LabelControl1.Text = "Organization"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(190, 165)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl2.TabIndex = 99
        Me.LabelControl2.Text = "Division"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(190, 199)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl3.TabIndex = 100
        Me.LabelControl3.Text = "Department"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(190, 53)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl8.TabIndex = 101
        Me.LabelControl8.Text = "Username"
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(190, 17)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl9.TabIndex = 102
        Me.LabelControl9.Text = "Full name"
        '
        'cbb_company_role
        '
        Me.cbb_company_role.Location = New System.Drawing.Point(284, 276)
        Me.cbb_company_role.Name = "cbb_company_role"
        Me.cbb_company_role.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.cbb_company_role.Properties.Appearance.Options.UseFont = True
        Me.cbb_company_role.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_company_role.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard
        Me.cbb_company_role.Size = New System.Drawing.Size(174, 32)
        Me.cbb_company_role.TabIndex = 103
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(190, 286)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(77, 14)
        Me.LabelControl10.TabIndex = 104
        Me.LabelControl10.Text = "Company Role"
        '
        'frm_admin_users_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 545)
        Me.Controls.Add(Me.cbb_company_role)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.cbb_department)
        Me.Controls.Add(Me.cbb_division)
        Me.Controls.Add(Me.cbb_organization)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.toggle_status)
        Me.Controls.Add(Me.btn_edit_roles)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_view_pass)
        Me.Controls.Add(Me.btn_browse)
        Me.Controls.Add(Me.grid_warehouse)
        Me.Controls.Add(Me.txt_userid)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.cbb_role)
        Me.Controls.Add(Me.pb_user)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.btn_add_user)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.txt_fname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.Inventory_Management.My.Resources.Resources.icon
        Me.LookAndFeel.SkinName = "WXI"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_users_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        CType(Me.pb_user.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_password.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_username.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_fname.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_role.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_userid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_warehouse, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_warehouse_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_organization.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_division.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_department.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_company_role.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pb_user As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_add_user As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_password As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_username As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_fname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_role As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_userid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_warehouse As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_warehouse_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_storeid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_storename As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_browse As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_view_pass As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_edit_roles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents toggle_status As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_organization As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbb_division As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbb_department As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_company_role As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
End Class
