<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_user_management
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_users = New DevExpress.XtraGrid.GridControl()
        Me.grid_users_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_userid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_username = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_role = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_company_role = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_designation = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_roles = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_users, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_users_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_users
        '
        Me.grid_users.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_users.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_users.Location = New System.Drawing.Point(5, 148)
        Me.grid_users.MainView = Me.grid_users_view
        Me.grid_users.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_users.Name = "grid_users"
        Me.grid_users.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit, Me.btn_delete})
        Me.grid_users.Size = New System.Drawing.Size(1658, 718)
        Me.grid_users.TabIndex = 0
        Me.grid_users.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_users_view})
        '
        'grid_users_view
        '
        Me.grid_users_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_users_view.Appearance.Row.Options.UseFont = True
        Me.grid_users_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_userid, Me.col_fname, Me.col_username, Me.col_role, Me.col_company_role, Me.col_designation, Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.col_edit, Me.col_delete})
        Me.grid_users_view.DetailHeight = 431
        Me.grid_users_view.GridControl = Me.grid_users
        Me.grid_users_view.Name = "grid_users_view"
        '
        'col_userid
        '
        Me.col_userid.Caption = "User ID"
        Me.col_userid.FieldName = "usr_id"
        Me.col_userid.MaxWidth = 87
        Me.col_userid.MinWidth = 23
        Me.col_userid.Name = "col_userid"
        Me.col_userid.Visible = True
        Me.col_userid.VisibleIndex = 0
        Me.col_userid.Width = 70
        '
        'col_fname
        '
        Me.col_fname.Caption = "Full Name"
        Me.col_fname.FieldName = "first_name"
        Me.col_fname.MinWidth = 23
        Me.col_fname.Name = "col_fname"
        Me.col_fname.Visible = True
        Me.col_fname.VisibleIndex = 1
        Me.col_fname.Width = 87
        '
        'col_username
        '
        Me.col_username.Caption = "Username"
        Me.col_username.FieldName = "username"
        Me.col_username.MaxWidth = 146
        Me.col_username.MinWidth = 23
        Me.col_username.Name = "col_username"
        Me.col_username.Visible = True
        Me.col_username.VisibleIndex = 2
        Me.col_username.Width = 87
        '
        'col_role
        '
        Me.col_role.Caption = "System Role"
        Me.col_role.FieldName = "role"
        Me.col_role.MaxWidth = 1225
        Me.col_role.MinWidth = 23
        Me.col_role.Name = "col_role"
        Me.col_role.Visible = True
        Me.col_role.VisibleIndex = 3
        Me.col_role.Width = 87
        '
        'col_company_role
        '
        Me.col_company_role.Caption = "Company Role"
        Me.col_company_role.FieldName = "company_role"
        Me.col_company_role.MinWidth = 23
        Me.col_company_role.Name = "col_company_role"
        Me.col_company_role.Visible = True
        Me.col_company_role.VisibleIndex = 4
        Me.col_company_role.Width = 87
        '
        'col_designation
        '
        Me.col_designation.Caption = "Designation"
        Me.col_designation.FieldName = "designation"
        Me.col_designation.MinWidth = 23
        Me.col_designation.Name = "col_designation"
        Me.col_designation.Visible = True
        Me.col_designation.VisibleIndex = 5
        Me.col_designation.Width = 87
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.MaxWidth = 140
        Me.GridColumn1.MinWidth = 140
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 6
        Me.GridColumn1.Width = 140
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Organization"
        Me.GridColumn2.FieldName = "organization"
        Me.GridColumn2.MinWidth = 23
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 7
        Me.GridColumn2.Width = 87
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Division"
        Me.GridColumn3.FieldName = "division"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 8
        Me.GridColumn3.Width = 87
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Department"
        Me.GridColumn4.FieldName = "department"
        Me.GridColumn4.MinWidth = 23
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 9
        Me.GridColumn4.Width = 87
        '
        'col_edit
        '
        Me.col_edit.Caption = "Edit"
        Me.col_edit.ColumnEdit = Me.btn_edit
        Me.col_edit.MaxWidth = 58
        Me.col_edit.MinWidth = 23
        Me.col_edit.Name = "col_edit"
        Me.col_edit.Visible = True
        Me.col_edit.VisibleIndex = 10
        Me.col_edit.Width = 58
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_edit
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(18, 18)
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_delete
        '
        Me.col_delete.Caption = "Delete"
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.MaxWidth = 70
        Me.col_delete.MinWidth = 23
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 11
        Me.col_delete.Width = 58
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_removecircled
        EditorButtonImageOptions2.SvgImageSize = New System.Drawing.Size(18, 18)
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(268, 38)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "User Management"
        '
        'btn_new
        '
        Me.btn_new.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_new.Appearance.Options.UseFont = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newemployee_16x16
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 5
        Me.btn_new.Location = New System.Drawing.Point(14, 81)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(187, 57)
        Me.btn_new.TabIndex = 21
        Me.btn_new.Text = "New User"
        '
        'btn_roles
        '
        Me.btn_roles.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_roles.Appearance.Options.UseFont = True
        Me.btn_roles.Appearance.Options.UseTextOptions = True
        Me.btn_roles.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_roles.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_roles.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_roles.ImageOptions.ImageToTextIndent = 5
        Me.btn_roles.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_user
        Me.btn_roles.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btn_roles.Location = New System.Drawing.Point(208, 81)
        Me.btn_roles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_roles.Name = "btn_roles"
        Me.btn_roles.Size = New System.Drawing.Size(187, 57)
        Me.btn_roles.TabIndex = 22
        Me.btn_roles.Text = "User Roles"
        '
        'frm_admin_user_management
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 866)
        Me.Controls.Add(Me.btn_roles)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_users)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_admin_user_management"
        Me.Text = "User Management"
        CType(Me.grid_users, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_users_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_users As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_users_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_userid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_username As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_role As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_designation As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_roles As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_company_role As DevExpress.XtraGrid.Columns.GridColumn
End Class
