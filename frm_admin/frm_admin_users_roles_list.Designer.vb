<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_users_roles_list
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
        Me.btn_new_row = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_roles_update = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_roles = New DevExpress.XtraGrid.GridControl()
        Me.grid_roles_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_role_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_role = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_roles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_roles_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_new_row
        '
        Me.btn_new_row.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_new_row.Appearance.Options.UseFont = True
        Me.btn_new_row.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newemployee_16x16
        Me.btn_new_row.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_row.Location = New System.Drawing.Point(122, 322)
        Me.btn_new_row.Name = "btn_new_row"
        Me.btn_new_row.Size = New System.Drawing.Size(114, 38)
        Me.btn_new_row.TabIndex = 89
        Me.btn_new_row.Text = "New Role"
        '
        'btn_roles_update
        '
        Me.btn_roles_update.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_roles_update.Appearance.Options.UseFont = True
        Me.btn_roles_update.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.recurrence_16x16
        Me.btn_roles_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_roles_update.Location = New System.Drawing.Point(242, 322)
        Me.btn_roles_update.Name = "btn_roles_update"
        Me.btn_roles_update.Size = New System.Drawing.Size(114, 38)
        Me.btn_roles_update.TabIndex = 88
        Me.btn_roles_update.Text = "Submit"
        '
        'grid_roles
        '
        Me.grid_roles.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grid_roles.Location = New System.Drawing.Point(16, 12)
        Me.grid_roles.MainView = Me.grid_roles_view
        Me.grid_roles.Name = "grid_roles"
        Me.grid_roles.Size = New System.Drawing.Size(340, 302)
        Me.grid_roles.TabIndex = 87
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
        Me.grid_roles_view.OptionsView.ShowGroupPanel = False
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
        'frm_admin_users_roles_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(368, 370)
        Me.Controls.Add(Me.btn_new_row)
        Me.Controls.Add(Me.btn_roles_update)
        Me.Controls.Add(Me.grid_roles)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_users_roles_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Roles"
        CType(Me.grid_roles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_roles_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_new_row As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_roles_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_roles As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_roles_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_role_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_role As DevExpress.XtraGrid.Columns.GridColumn
End Class
