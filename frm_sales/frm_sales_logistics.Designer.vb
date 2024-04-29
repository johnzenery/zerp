<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_logistics
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_logistics))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_logistics = New DevExpress.XtraGrid.GridControl()
        Me.grid_logistics_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_logistics_contact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_logistics_contact_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_nearest_branch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_logistics_destination = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_new_logistics = New DevExpress.XtraEditors.SimpleButton()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_logistics, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_logistics_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_logistics
        '
        Me.grid_logistics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_logistics.Location = New System.Drawing.Point(-1, 131)
        Me.grid_logistics.MainView = Me.grid_logistics_view
        Me.grid_logistics.Name = "grid_logistics"
        Me.grid_logistics.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit, Me.btn_view, Me.btn_delete})
        Me.grid_logistics.Size = New System.Drawing.Size(1190, 644)
        Me.grid_logistics.TabIndex = 9
        Me.grid_logistics.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_logistics_view})
        '
        'grid_logistics_view
        '
        Me.grid_logistics_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_logistics_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_logistics_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_logistics_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_logistics_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_logistics_view.Appearance.Row.Options.UseFont = True
        Me.grid_logistics_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_logistics_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_logistics_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_logistics_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_logistics_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_name, Me.col_logistics_contact, Me.col_logistics_contact_no, Me.col_nearest_branch, Me.col_logistics_destination, Me.col_edit, Me.col_view, Me.col_delete})
        Me.grid_logistics_view.GridControl = Me.grid_logistics
        Me.grid_logistics_view.Name = "grid_logistics_view"
        Me.grid_logistics_view.OptionsBehavior.ReadOnly = True
        Me.grid_logistics_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_logistics_view.OptionsView.ShowGroupPanel = False
        Me.grid_logistics_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_logistics_view.RowHeight = 25
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_id.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_id.AppearanceHeader.Options.UseFont = True
        Me.col_id.AppearanceHeader.Options.UseForeColor = True
        Me.col_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "logistics_id"
        Me.col_id.MaxWidth = 80
        Me.col_id.MinWidth = 10
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 77
        '
        'col_name
        '
        Me.col_name.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_name.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_name.AppearanceHeader.Options.UseFont = True
        Me.col_name.AppearanceHeader.Options.UseForeColor = True
        Me.col_name.AppearanceHeader.Options.UseTextOptions = True
        Me.col_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_name.Caption = "Logistics Name"
        Me.col_name.FieldName = "logistics_name"
        Me.col_name.MaxWidth = 130
        Me.col_name.MinWidth = 130
        Me.col_name.Name = "col_name"
        Me.col_name.Visible = True
        Me.col_name.VisibleIndex = 1
        Me.col_name.Width = 130
        '
        'col_logistics_contact
        '
        Me.col_logistics_contact.AppearanceCell.Options.UseTextOptions = True
        Me.col_logistics_contact.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_logistics_contact.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_logistics_contact.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_logistics_contact.AppearanceHeader.Options.UseFont = True
        Me.col_logistics_contact.AppearanceHeader.Options.UseForeColor = True
        Me.col_logistics_contact.AppearanceHeader.Options.UseTextOptions = True
        Me.col_logistics_contact.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_logistics_contact.Caption = "Contact Person"
        Me.col_logistics_contact.FieldName = "logistics_contact"
        Me.col_logistics_contact.MaxWidth = 180
        Me.col_logistics_contact.MinWidth = 100
        Me.col_logistics_contact.Name = "col_logistics_contact"
        Me.col_logistics_contact.Visible = True
        Me.col_logistics_contact.VisibleIndex = 2
        Me.col_logistics_contact.Width = 136
        '
        'col_logistics_contact_no
        '
        Me.col_logistics_contact_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_logistics_contact_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_logistics_contact_no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_logistics_contact_no.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_logistics_contact_no.AppearanceHeader.Options.UseFont = True
        Me.col_logistics_contact_no.AppearanceHeader.Options.UseForeColor = True
        Me.col_logistics_contact_no.AppearanceHeader.Options.UseTextOptions = True
        Me.col_logistics_contact_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_logistics_contact_no.Caption = "Contact No."
        Me.col_logistics_contact_no.FieldName = "logistics_contact_no"
        Me.col_logistics_contact_no.MaxWidth = 120
        Me.col_logistics_contact_no.MinWidth = 120
        Me.col_logistics_contact_no.Name = "col_logistics_contact_no"
        Me.col_logistics_contact_no.Visible = True
        Me.col_logistics_contact_no.VisibleIndex = 3
        Me.col_logistics_contact_no.Width = 120
        '
        'col_nearest_branch
        '
        Me.col_nearest_branch.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_nearest_branch.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_nearest_branch.AppearanceHeader.Options.UseFont = True
        Me.col_nearest_branch.AppearanceHeader.Options.UseForeColor = True
        Me.col_nearest_branch.AppearanceHeader.Options.UseTextOptions = True
        Me.col_nearest_branch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_nearest_branch.Caption = "Nearest Branch"
        Me.col_nearest_branch.FieldName = "nearest_branch"
        Me.col_nearest_branch.MaxWidth = 280
        Me.col_nearest_branch.MinWidth = 100
        Me.col_nearest_branch.Name = "col_nearest_branch"
        Me.col_nearest_branch.Visible = True
        Me.col_nearest_branch.VisibleIndex = 4
        Me.col_nearest_branch.Width = 136
        '
        'col_logistics_destination
        '
        Me.col_logistics_destination.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col_logistics_destination.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_logistics_destination.AppearanceHeader.Options.UseFont = True
        Me.col_logistics_destination.AppearanceHeader.Options.UseForeColor = True
        Me.col_logistics_destination.AppearanceHeader.Options.UseTextOptions = True
        Me.col_logistics_destination.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_logistics_destination.Caption = "Destinations"
        Me.col_logistics_destination.DisplayFormat.FormatString = "dd/MM, hh:mm tt"
        Me.col_logistics_destination.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_logistics_destination.FieldName = "destinations"
        Me.col_logistics_destination.MaxWidth = 350
        Me.col_logistics_destination.MinWidth = 100
        Me.col_logistics_destination.Name = "col_logistics_destination"
        Me.col_logistics_destination.Visible = True
        Me.col_logistics_destination.VisibleIndex = 5
        Me.col_logistics_destination.Width = 136
        '
        'col_edit
        '
        Me.col_edit.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_edit.AppearanceHeader.Options.UseFont = True
        Me.col_edit.AppearanceHeader.Options.UseTextOptions = True
        Me.col_edit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_edit.Caption = "Edit"
        Me.col_edit.ColumnEdit = Me.btn_edit
        Me.col_edit.MaxWidth = 60
        Me.col_edit.Name = "col_edit"
        Me.col_edit.Visible = True
        Me.col_edit.VisibleIndex = 7
        Me.col_edit.Width = 60
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        Me.btn_edit.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_view
        '
        Me.col_view.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_view.AppearanceHeader.Options.UseFont = True
        Me.col_view.AppearanceHeader.Options.UseTextOptions = True
        Me.col_view.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_view.Caption = "View"
        Me.col_view.ColumnEdit = Me.btn_view
        Me.col_view.MaxWidth = 60
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 6
        Me.col_view.Width = 60
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        Me.btn_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_delete
        '
        Me.col_delete.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.col_delete.AppearanceHeader.Options.UseFont = True
        Me.col_delete.AppearanceHeader.Options.UseTextOptions = True
        Me.col_delete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_delete.Caption = "Delete"
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.MaxWidth = 60
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 8
        Me.col_delete.Width = 60
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        Me.btn_delete.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.trash_16x16
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_new_logistics
        '
        Me.btn_new_logistics.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_logistics.Appearance.Options.UseFont = True
        Me.btn_new_logistics.Appearance.Options.UseTextOptions = True
        Me.btn_new_logistics.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new_logistics.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new_logistics.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_logistics.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_logistics.ImageOptions.SvgImage = CType(resources.GetObject("btn_new_logistics.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_new_logistics.Location = New System.Drawing.Point(12, 58)
        Me.btn_new_logistics.Name = "btn_new_logistics"
        Me.btn_new_logistics.Size = New System.Drawing.Size(160, 46)
        Me.btn_new_logistics.TabIndex = 11
        Me.btn_new_logistics.Text = "New Logistic"
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridColumn9.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn9.AppearanceHeader.Options.UseFont = True
        Me.GridColumn9.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Shipping"
        Me.GridColumn9.FieldName = "shipping_method"
        Me.GridColumn9.MaxWidth = 100
        Me.GridColumn9.MinWidth = 100
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 100
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 31)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Logistics"
        '
        'frm_sales_logistics
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 774)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_new_logistics)
        Me.Controls.Add(Me.grid_logistics)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_sales_logistics.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_logistics"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Logistics"
        CType(Me.grid_logistics, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_logistics_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_logistics As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_logistics_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_logistics_contact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_logistics_contact_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_nearest_branch As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_logistics_destination As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_new_logistics As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
