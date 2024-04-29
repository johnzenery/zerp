<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_product_database
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_product = New DevExpress.XtraGrid.GridControl()
        Me.grid_product_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_barcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tech_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tags = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_length = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_width = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_height = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_weight = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_hazards = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_IBQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_MBQ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_MO_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warranty_period = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warranty_coverage = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.btn_edit = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_import_update = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export_database = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_product_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(218, 31)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Product Database"
        '
        'grid_product
        '
        Me.grid_product.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_product.Location = New System.Drawing.Point(-1, 110)
        Me.grid_product.MainView = Me.grid_product_view
        Me.grid_product.Name = "grid_product"
        Me.grid_product.Size = New System.Drawing.Size(1461, 634)
        Me.grid_product.TabIndex = 21
        Me.grid_product.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_product_view})
        '
        'grid_product_view
        '
        Me.grid_product_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_product_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_product_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_product_view.Appearance.Row.Options.UseFont = True
        Me.grid_product_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_barcode, Me.col_winmodel, Me.col_supmodel, Me.col_supplier, Me.col_description, Me.col_tech_description, Me.col_main_category, Me.col_sub_category, Me.col_brand, Me.col_type, Me.col_tags, Me.col_status, Me.col_length, Me.col_width, Me.col_height, Me.col_weight, Me.col_unit, Me.col_hazards, Me.col_IBQ, Me.col_MBQ, Me.col_MO_qty, Me.col_warranty_period, Me.col_warranty_coverage})
        Me.grid_product_view.GridControl = Me.grid_product
        Me.grid_product_view.Name = "grid_product_view"
        Me.grid_product_view.OptionsBehavior.Editable = False
        Me.grid_product_view.OptionsSelection.CheckBoxSelectorColumnWidth = 50
        Me.grid_product_view.OptionsSelection.MultiSelect = True
        Me.grid_product_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_product_view.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MinWidth = 80
        Me.col_pid.Name = "col_pid"
        Me.col_pid.OptionsColumn.ReadOnly = True
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 1
        Me.col_pid.Width = 80
        '
        'col_barcode
        '
        Me.col_barcode.Caption = "Barcode"
        Me.col_barcode.FieldName = "barcode"
        Me.col_barcode.MinWidth = 100
        Me.col_barcode.Name = "col_barcode"
        Me.col_barcode.Visible = True
        Me.col_barcode.VisibleIndex = 2
        Me.col_barcode.Width = 100
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MinWidth = 140
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 3
        Me.col_winmodel.Width = 140
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MinWidth = 140
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 4
        Me.col_supmodel.Width = 140
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Sup. ID"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 60
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 5
        Me.col_supplier.Width = 60
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 460
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 6
        Me.col_description.Width = 460
        '
        'col_tech_description
        '
        Me.col_tech_description.Caption = "Technical Description"
        Me.col_tech_description.FieldName = "technical_description"
        Me.col_tech_description.MinWidth = 150
        Me.col_tech_description.Name = "col_tech_description"
        Me.col_tech_description.Visible = True
        Me.col_tech_description.VisibleIndex = 7
        Me.col_tech_description.Width = 150
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Main Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.MinWidth = 120
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 8
        Me.col_main_category.Width = 120
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.MinWidth = 120
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 9
        Me.col_sub_category.Width = 120
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.MinWidth = 100
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 10
        Me.col_brand.Width = 100
        '
        'col_type
        '
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "type"
        Me.col_type.MinWidth = 75
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 11
        '
        'col_tags
        '
        Me.col_tags.Caption = "Tags"
        Me.col_tags.FieldName = "tags"
        Me.col_tags.MinWidth = 150
        Me.col_tags.Name = "col_tags"
        Me.col_tags.Visible = True
        Me.col_tags.VisibleIndex = 12
        Me.col_tags.Width = 150
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MinWidth = 100
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 13
        Me.col_status.Width = 100
        '
        'col_length
        '
        Me.col_length.Caption = "Length"
        Me.col_length.FieldName = "length"
        Me.col_length.MinWidth = 60
        Me.col_length.Name = "col_length"
        Me.col_length.Visible = True
        Me.col_length.VisibleIndex = 14
        Me.col_length.Width = 60
        '
        'col_width
        '
        Me.col_width.Caption = "Width"
        Me.col_width.FieldName = "width"
        Me.col_width.MinWidth = 60
        Me.col_width.Name = "col_width"
        Me.col_width.Visible = True
        Me.col_width.VisibleIndex = 15
        Me.col_width.Width = 60
        '
        'col_height
        '
        Me.col_height.Caption = "Height"
        Me.col_height.FieldName = "height"
        Me.col_height.MinWidth = 60
        Me.col_height.Name = "col_height"
        Me.col_height.Visible = True
        Me.col_height.VisibleIndex = 16
        Me.col_height.Width = 60
        '
        'col_weight
        '
        Me.col_weight.Caption = "Weight"
        Me.col_weight.FieldName = "weight"
        Me.col_weight.MinWidth = 60
        Me.col_weight.Name = "col_weight"
        Me.col_weight.Visible = True
        Me.col_weight.VisibleIndex = 17
        Me.col_weight.Width = 60
        '
        'col_unit
        '
        Me.col_unit.Caption = "Unit"
        Me.col_unit.FieldName = "unit"
        Me.col_unit.MinWidth = 60
        Me.col_unit.Name = "col_unit"
        Me.col_unit.Visible = True
        Me.col_unit.VisibleIndex = 18
        '
        'col_hazards
        '
        Me.col_hazards.Caption = "Hazards"
        Me.col_hazards.FieldName = "hazards"
        Me.col_hazards.MinWidth = 150
        Me.col_hazards.Name = "col_hazards"
        Me.col_hazards.Visible = True
        Me.col_hazards.VisibleIndex = 19
        Me.col_hazards.Width = 150
        '
        'col_IBQ
        '
        Me.col_IBQ.Caption = "I.B.Q."
        Me.col_IBQ.FieldName = "qty_per_box"
        Me.col_IBQ.MinWidth = 60
        Me.col_IBQ.Name = "col_IBQ"
        Me.col_IBQ.Visible = True
        Me.col_IBQ.VisibleIndex = 20
        Me.col_IBQ.Width = 60
        '
        'col_MBQ
        '
        Me.col_MBQ.Caption = "M.B.Q."
        Me.col_MBQ.FieldName = "masterbox_qty"
        Me.col_MBQ.MinWidth = 60
        Me.col_MBQ.Name = "col_MBQ"
        Me.col_MBQ.Visible = True
        Me.col_MBQ.VisibleIndex = 21
        Me.col_MBQ.Width = 60
        '
        'col_MO_qty
        '
        Me.col_MO_qty.Caption = "M.O. Qty"
        Me.col_MO_qty.FieldName = "min_order_qty"
        Me.col_MO_qty.MinWidth = 70
        Me.col_MO_qty.Name = "col_MO_qty"
        Me.col_MO_qty.Visible = True
        Me.col_MO_qty.VisibleIndex = 22
        Me.col_MO_qty.Width = 70
        '
        'col_warranty_period
        '
        Me.col_warranty_period.Caption = "Warranty"
        Me.col_warranty_period.FieldName = "warranty_period"
        Me.col_warranty_period.MinWidth = 80
        Me.col_warranty_period.Name = "col_warranty_period"
        Me.col_warranty_period.Visible = True
        Me.col_warranty_period.VisibleIndex = 23
        Me.col_warranty_period.Width = 80
        '
        'col_warranty_coverage
        '
        Me.col_warranty_coverage.Caption = "Warranty Coverage"
        Me.col_warranty_coverage.FieldName = "warranty_coverage"
        Me.col_warranty_coverage.MinWidth = 120
        Me.col_warranty_coverage.Name = "col_warranty_coverage"
        Me.col_warranty_coverage.Visible = True
        Me.col_warranty_coverage.VisibleIndex = 24
        Me.col_warranty_coverage.Width = 120
        '
        'BackgroundWorker
        '
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.Caption = "Getting Products"
        Me.ProgressPanel.Description = "Please wait..."
        Me.ProgressPanel.Location = New System.Drawing.Point(611, 324)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Padding = New System.Windows.Forms.Padding(10)
        Me.ProgressPanel.Size = New System.Drawing.Size(246, 66)
        Me.ProgressPanel.TabIndex = 22
        Me.ProgressPanel.Text = "ProgressPanel"
        Me.ProgressPanel.Visible = False
        '
        'btn_edit
        '
        Me.btn_edit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_edit.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_edit.Appearance.Options.UseFont = True
        Me.btn_edit.Appearance.Options.UseTextOptions = True
        Me.btn_edit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_edit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_edit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_edit.ImageOptions.ImageToTextIndent = 5
        Me.btn_edit.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_edit
        Me.btn_edit.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_edit.Location = New System.Drawing.Point(1344, 58)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.Size = New System.Drawing.Size(102, 40)
        Me.btn_edit.TabIndex = 23
        Me.btn_edit.Text = "Edit"
        '
        'btn_import_update
        '
        Me.btn_import_update.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_import_update.Appearance.Options.UseFont = True
        Me.btn_import_update.Appearance.Options.UseTextOptions = True
        Me.btn_import_update.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_import_update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_import_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_import_update.ImageOptions.ImageToTextIndent = 5
        Me.btn_import_update.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_import_update.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_import_update.Location = New System.Drawing.Point(12, 58)
        Me.btn_import_update.Name = "btn_import_update"
        Me.btn_import_update.Size = New System.Drawing.Size(166, 40)
        Me.btn_import_update.TabIndex = 24
        Me.btn_import_update.Text = "Mass Import/Update"
        '
        'btn_export_database
        '
        Me.btn_export_database.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_export_database.Appearance.Options.UseFont = True
        Me.btn_export_database.Appearance.Options.UseTextOptions = True
        Me.btn_export_database.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export_database.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export_database.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export_database.ImageOptions.ImageToTextIndent = 5
        Me.btn_export_database.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources._next
        Me.btn_export_database.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export_database.Location = New System.Drawing.Point(1436, 12)
        Me.btn_export_database.Name = "btn_export_database"
        Me.btn_export_database.Size = New System.Drawing.Size(24, 40)
        Me.btn_export_database.TabIndex = 25
        Me.btn_export_database.Text = "Export Database"
        Me.btn_export_database.Visible = False
        '
        'btn_export
        '
        Me.btn_export.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_export.Appearance.Options.UseFont = True
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.Enabled = False
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 5
        Me.btn_export.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources._next
        Me.btn_export.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export.Location = New System.Drawing.Point(184, 58)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(156, 40)
        Me.btn_export.TabIndex = 26
        Me.btn_export.Text = "Export"
        '
        'frm_admin_product_database
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1458, 743)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_export_database)
        Me.Controls.Add(Me.btn_import_update)
        Me.Controls.Add(Me.btn_edit)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.grid_product)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_admin_product_database"
        Me.Text = "Product Database"
        CType(Me.grid_product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_product_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_product As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_product_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_barcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tech_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tags As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_length As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_width As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_height As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_weight As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_hazards As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_IBQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_MBQ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_MO_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warranty_period As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warranty_coverage As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents btn_edit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_import_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_export_database As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
End Class
