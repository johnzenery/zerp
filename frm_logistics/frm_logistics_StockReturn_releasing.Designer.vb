<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logistics_StockReturn_releasing
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
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_pullout = New DevExpress.XtraGrid.GridControl()
        Me.grid_pullout_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_batch_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_dispatch = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_pullout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_pullout_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_dispatch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(300, 31)
        Me.LabelControl2.TabIndex = 60
        Me.LabelControl2.Text = "Stock Returns Releasing"
        '
        'grid_pullout
        '
        Me.grid_pullout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_pullout.Location = New System.Drawing.Point(-2, 62)
        Me.grid_pullout.MainView = Me.grid_pullout_view
        Me.grid_pullout.Name = "grid_pullout"
        Me.grid_pullout.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_dispatch})
        Me.grid_pullout.Size = New System.Drawing.Size(1071, 503)
        Me.grid_pullout.TabIndex = 61
        Me.grid_pullout.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_pullout_view})
        '
        'grid_pullout_view
        '
        Me.grid_pullout_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_pullout_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_pullout_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_pullout_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_pullout_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_pullout_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_pullout_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_pullout_view.Appearance.Row.Options.UseFont = True
        Me.grid_pullout_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_pullout_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_pullout_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_pullout_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_pullout_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_batch_id, Me.col_supplier, Me.col_status, Me.col_action, Me.col_warehouse})
        Me.grid_pullout_view.GridControl = Me.grid_pullout
        Me.grid_pullout_view.Name = "grid_pullout_view"
        Me.grid_pullout_view.OptionsBehavior.ReadOnly = True
        Me.grid_pullout_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_pullout_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_batch_id
        '
        Me.col_batch_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_batch_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_batch_id.Caption = "Batch ID"
        Me.col_batch_id.FieldName = "batch_id"
        Me.col_batch_id.MaxWidth = 80
        Me.col_batch_id.MinWidth = 80
        Me.col_batch_id.Name = "col_batch_id"
        Me.col_batch_id.Visible = True
        Me.col_batch_id.VisibleIndex = 0
        Me.col_batch_id.Width = 80
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 1
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 200
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 3
        '
        'col_action
        '
        Me.col_action.Caption = "Dispatch"
        Me.col_action.ColumnEdit = Me.btn_dispatch
        Me.col_action.MaxWidth = 70
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 4
        Me.col_action.Width = 50
        '
        'btn_dispatch
        '
        Me.btn_dispatch.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.shopping_delivery
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_dispatch.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_dispatch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_dispatch.Name = "btn_dispatch"
        Me.btn_dispatch.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_warehouse
        '
        Me.col_warehouse.Caption = "Source Warehouse"
        Me.col_warehouse.FieldName = "store_name"
        Me.col_warehouse.MaxWidth = 250
        Me.col_warehouse.Name = "col_warehouse"
        Me.col_warehouse.Visible = True
        Me.col_warehouse.VisibleIndex = 2
        '
        'frm_logistics_stock_return_releasing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1068, 563)
        Me.Controls.Add(Me.grid_pullout)
        Me.Controls.Add(Me.LabelControl2)
        Me.Name = "frm_logistics_stock_return_releasing"
        Me.Text = "Stock Returns Releasing"
        CType(Me.grid_pullout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_pullout_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_dispatch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_pullout As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_pullout_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_batch_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_dispatch As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse As DevExpress.XtraGrid.Columns.GridColumn
End Class
