<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stock_inventory
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
        Me.btn_import = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPane = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_mystore = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grid_mystore = New DevExpress.XtraGrid.GridControl()
        Me.grid_mystore_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_masterbox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_innerbox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_on_hold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_location_1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_location_2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_zone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tab_allstore = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grid_all = New DevExpress.XtraGrid.GridControl()
        Me.grid_all_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_ginee_export = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.TabPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane.SuspendLayout()
        Me.tab_mystore.SuspendLayout()
        CType(Me.grid_mystore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_mystore_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_allstore.SuspendLayout()
        CType(Me.grid_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_all_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_import
        '
        Me.btn_import.Appearance.Options.UseTextOptions = True
        Me.btn_import.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_import.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_import.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.exporttoxls_16x16
        Me.btn_import.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.btn_import.Location = New System.Drawing.Point(207, 52)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(91, 38)
        Me.btn_import.TabIndex = 8
        Me.btn_import.Text = "Import"
        '
        'btn_export
        '
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.exporttoxls_16x16
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.btn_export.Location = New System.Drawing.Point(12, 52)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(91, 38)
        Me.btn_export.TabIndex = 7
        Me.btn_export.Text = "Export"
        '
        'btn_print
        '
        Me.btn_print.Appearance.Options.UseTextOptions = True
        Me.btn_print.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_print.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.btn_print.Location = New System.Drawing.Point(110, 52)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(91, 38)
        Me.btn_print.TabIndex = 6
        Me.btn_print.Text = "Print"
        '
        'TabPane
        '
        Me.TabPane.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPane.Appearance.Options.UseFont = True
        Me.TabPane.AppearanceButton.Hovered.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.AppearanceButton.Hovered.Options.UseFont = True
        Me.TabPane.AppearanceButton.Normal.BackColor = System.Drawing.Color.White
        Me.TabPane.AppearanceButton.Normal.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.AppearanceButton.Normal.Options.UseBackColor = True
        Me.TabPane.AppearanceButton.Normal.Options.UseFont = True
        Me.TabPane.AppearanceButton.Pressed.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.AppearanceButton.Pressed.Options.UseFont = True
        Me.TabPane.Controls.Add(Me.tab_mystore)
        Me.TabPane.Controls.Add(Me.tab_allstore)
        Me.TabPane.Location = New System.Drawing.Point(-1, 104)
        Me.TabPane.Name = "TabPane"
        Me.TabPane.PageProperties.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.TabPane.PageProperties.AppearanceCaption.Options.UseBackColor = True
        Me.TabPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_mystore, Me.tab_allstore})
        Me.TabPane.RegularSize = New System.Drawing.Size(1448, 587)
        Me.TabPane.SelectedPage = Me.tab_mystore
        Me.TabPane.Size = New System.Drawing.Size(1448, 587)
        Me.TabPane.TabAlignment = DevExpress.XtraEditors.Alignment.Near
        Me.TabPane.TabIndex = 1
        Me.TabPane.Text = "TabPane1"
        '
        'tab_mystore
        '
        Me.tab_mystore.Caption = "My Store"
        Me.tab_mystore.Controls.Add(Me.grid_mystore)
        Me.tab_mystore.Name = "tab_mystore"
        Me.tab_mystore.Size = New System.Drawing.Size(1448, 546)
        '
        'grid_mystore
        '
        Me.grid_mystore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_mystore.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grid_mystore.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grid_mystore.Location = New System.Drawing.Point(0, 0)
        Me.grid_mystore.MainView = Me.grid_mystore_view
        Me.grid_mystore.Name = "grid_mystore"
        Me.grid_mystore.Size = New System.Drawing.Size(1448, 546)
        Me.grid_mystore.TabIndex = 1
        Me.grid_mystore.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_mystore_view})
        '
        'grid_mystore_view
        '
        Me.grid_mystore_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Yellow
        Me.grid_mystore_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_mystore_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_mystore_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_mystore_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_mystore_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_mystore_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_mystore_view.Appearance.Row.Options.UseFont = True
        Me.grid_mystore_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grid_mystore_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_winmodel, Me.col_brand, Me.col_main_category, Me.col_sub_category, Me.col_description, Me.col_status, Me.col_masterbox, Me.col_innerbox, Me.col_qty, Me.col_on_hold, Me.col_location_1, Me.col_location_2, Me.col_zone, Me.col_unit})
        Me.grid_mystore_view.GridControl = Me.grid_mystore
        Me.grid_mystore_view.Name = "grid_mystore_view"
        Me.grid_mystore_view.OptionsEditForm.EditFormColumnCount = 1
        Me.grid_mystore_view.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_mystore_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 69
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Winland Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 222
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 2
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 3
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 4
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 5
        Me.col_description.Width = 466
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 6
        '
        'col_masterbox
        '
        Me.col_masterbox.Caption = "Master Box"
        Me.col_masterbox.FieldName = "masterbox_qty"
        Me.col_masterbox.Name = "col_masterbox"
        Me.col_masterbox.Visible = True
        Me.col_masterbox.VisibleIndex = 7
        '
        'col_innerbox
        '
        Me.col_innerbox.Caption = "Inner Box"
        Me.col_innerbox.FieldName = "qty_per_box"
        Me.col_innerbox.Name = "col_innerbox"
        Me.col_innerbox.Visible = True
        Me.col_innerbox.VisibleIndex = 8
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Quantity"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 10
        Me.col_qty.Width = 100
        '
        'col_on_hold
        '
        Me.col_on_hold.AppearanceCell.Options.UseTextOptions = True
        Me.col_on_hold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_on_hold.Caption = "On Hold"
        Me.col_on_hold.FieldName = "on_hold"
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.Visible = True
        Me.col_on_hold.VisibleIndex = 11
        Me.col_on_hold.Width = 102
        '
        'col_location_1
        '
        Me.col_location_1.AppearanceCell.Options.UseTextOptions = True
        Me.col_location_1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_location_1.Caption = "Location 1"
        Me.col_location_1.FieldName = "location"
        Me.col_location_1.Name = "col_location_1"
        Me.col_location_1.Visible = True
        Me.col_location_1.VisibleIndex = 12
        '
        'col_location_2
        '
        Me.col_location_2.AppearanceCell.Options.UseTextOptions = True
        Me.col_location_2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_location_2.Caption = "Location 2"
        Me.col_location_2.FieldName = "location_2"
        Me.col_location_2.Name = "col_location_2"
        Me.col_location_2.Visible = True
        Me.col_location_2.VisibleIndex = 13
        '
        'col_zone
        '
        Me.col_zone.AppearanceCell.Options.UseTextOptions = True
        Me.col_zone.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_zone.AppearanceHeader.Options.UseTextOptions = True
        Me.col_zone.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_zone.Caption = "Zone"
        Me.col_zone.FieldName = "zone"
        Me.col_zone.FieldNameSortGroup = "zone"
        Me.col_zone.Name = "col_zone"
        Me.col_zone.Visible = True
        Me.col_zone.VisibleIndex = 14
        '
        'col_unit
        '
        Me.col_unit.Caption = "Unit"
        Me.col_unit.FieldName = "unit"
        Me.col_unit.Name = "col_unit"
        Me.col_unit.Visible = True
        Me.col_unit.VisibleIndex = 9
        '
        'tab_allstore
        '
        Me.tab_allstore.Caption = "All Stores"
        Me.tab_allstore.Controls.Add(Me.grid_all)
        Me.tab_allstore.Name = "tab_allstore"
        Me.tab_allstore.Padding = New System.Windows.Forms.Padding(0, 0, 0, 6)
        Me.tab_allstore.Size = New System.Drawing.Size(1448, 546)
        '
        'grid_all
        '
        Me.grid_all.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_all.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grid_all.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grid_all.Location = New System.Drawing.Point(0, 0)
        Me.grid_all.MainView = Me.grid_all_view
        Me.grid_all.Name = "grid_all"
        Me.grid_all.Size = New System.Drawing.Size(1448, 540)
        Me.grid_all.TabIndex = 0
        Me.grid_all.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_all_view})
        '
        'grid_all_view
        '
        Me.grid_all_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Yellow
        Me.grid_all_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_all_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_all_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_all_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_all_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_all_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_all_view.Appearance.Row.Options.UseFont = True
        Me.grid_all_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grid_all_view.GridControl = Me.grid_all
        Me.grid_all_view.Name = "grid_all_view"
        Me.grid_all_view.OptionsBehavior.ReadOnly = True
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 12)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(189, 31)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Stock Inventory"
        '
        'btn_ginee_export
        '
        Me.btn_ginee_export.Appearance.Options.UseTextOptions = True
        Me.btn_ginee_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_ginee_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_ginee_export.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.exporttoxls_16x16
        Me.btn_ginee_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.btn_ginee_export.Location = New System.Drawing.Point(304, 52)
        Me.btn_ginee_export.Name = "btn_ginee_export"
        Me.btn_ginee_export.Size = New System.Drawing.Size(102, 38)
        Me.btn_ginee_export.TabIndex = 21
        Me.btn_ginee_export.Text = "Ginee Export"
        '
        'frm_warehouse_stock_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1446, 707)
        Me.Controls.Add(Me.btn_ginee_export)
        Me.Controls.Add(Me.TabPane)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_print)
        Me.Name = "frm_warehouse_stock_inventory"
        Me.Text = "Stock Inventory"
        CType(Me.TabPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane.ResumeLayout(False)
        Me.tab_mystore.ResumeLayout(False)
        CType(Me.grid_mystore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_mystore_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_allstore.ResumeLayout(False)
        CType(Me.grid_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_all_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabPane As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tab_mystore As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents grid_mystore As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_mystore_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tab_allstore As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents grid_all As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_all_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_on_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_location_1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_zone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_import As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_location_2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_masterbox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_innerbox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_ginee_export As DevExpress.XtraEditors.SimpleButton
End Class
