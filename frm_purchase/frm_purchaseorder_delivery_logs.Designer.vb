Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_purchaseorder_delivery_logs
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.grid_supplier_deliveries = New DevExpress.XtraGrid.GridControl()
        Me.grid_supplier_deliveries_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_timestamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dt_edit_date = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.col_date_of_delivery = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_poid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tax_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dr_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_si_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_encoder = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_counted_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        Me.col_isBundle = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_supplier_deliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_supplier_deliveries_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_edit_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_edit_date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_supplier_deliveries
        '
        Me.grid_supplier_deliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_supplier_deliveries.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_supplier_deliveries.Location = New System.Drawing.Point(-1, 114)
        Me.grid_supplier_deliveries.MainView = Me.grid_supplier_deliveries_view
        Me.grid_supplier_deliveries.Name = "grid_supplier_deliveries"
        Me.grid_supplier_deliveries.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dt_edit_date})
        Me.grid_supplier_deliveries.Size = New System.Drawing.Size(1669, 532)
        Me.grid_supplier_deliveries.TabIndex = 11
        Me.grid_supplier_deliveries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_supplier_deliveries_view})
        '
        'grid_supplier_deliveries_view
        '
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_supplier_deliveries_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_supplier_deliveries_view.Appearance.Row.Options.UseFont = True
        Me.grid_supplier_deliveries_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_timestamp, Me.col_date_of_delivery, Me.col_isBundle, Me.col_qty, Me.col_unit, Me.col_pid, Me.col_brand, Me.col_model, Me.col_description, Me.col_cost, Me.col_warehouse, Me.col_supplier, Me.col_poid, Me.col_reference, Me.col_tax_type, Me.col_dr_no, Me.col_si_no, Me.col_encoder, Me.col_counted_by, Me.col_id})
        Me.grid_supplier_deliveries_view.GridControl = Me.grid_supplier_deliveries
        Me.grid_supplier_deliveries_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_supplier_deliveries_view.Name = "grid_supplier_deliveries_view"
        Me.grid_supplier_deliveries_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_supplier_deliveries_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_supplier_deliveries_view.OptionsView.ColumnAutoWidth = False
        '
        'col_timestamp
        '
        Me.col_timestamp.AppearanceCell.Options.UseTextOptions = True
        Me.col_timestamp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_timestamp.Caption = "Timestamp"
        Me.col_timestamp.ColumnEdit = Me.dt_edit_date
        Me.col_timestamp.DisplayFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.col_timestamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_timestamp.FieldName = "created_at"
        Me.col_timestamp.Name = "col_timestamp"
        Me.col_timestamp.OptionsColumn.ReadOnly = True
        Me.col_timestamp.Visible = True
        Me.col_timestamp.VisibleIndex = 0
        Me.col_timestamp.Width = 92
        '
        'dt_edit_date
        '
        Me.dt_edit_date.AutoHeight = False
        Me.dt_edit_date.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_edit_date.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_edit_date.DisplayFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.dt_edit_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_edit_date.EditFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.dt_edit_date.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_edit_date.MaskSettings.Set("mask", "hh:mm tt MM/dd/yyyy")
        Me.dt_edit_date.Name = "dt_edit_date"
        Me.dt_edit_date.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'col_date_of_delivery
        '
        Me.col_date_of_delivery.Caption = "Date of Delivery"
        Me.col_date_of_delivery.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_date_of_delivery.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_of_delivery.FieldName = "date_received"
        Me.col_date_of_delivery.Name = "col_date_of_delivery"
        Me.col_date_of_delivery.Visible = True
        Me.col_date_of_delivery.VisibleIndex = 1
        Me.col_date_of_delivery.Width = 106
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_qty.Caption = "Qty"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.OptionsColumn.ReadOnly = True
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 3
        Me.col_qty.Width = 51
        '
        'col_unit
        '
        Me.col_unit.Caption = "Unit"
        Me.col_unit.FieldName = "unit"
        Me.col_unit.MaxWidth = 60
        Me.col_unit.Name = "col_unit"
        Me.col_unit.Visible = True
        Me.col_unit.VisibleIndex = 4
        Me.col_unit.Width = 49
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 5
        Me.col_pid.Width = 53
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 6
        Me.col_brand.Width = 61
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.Name = "col_model"
        Me.col_model.OptionsColumn.ReadOnly = True
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 7
        Me.col_model.Width = 55
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 250
        Me.col_description.Name = "col_description"
        Me.col_description.OptionsColumn.ReadOnly = True
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 8
        Me.col_description.Width = 250
        '
        'col_cost
        '
        Me.col_cost.Caption = "Cost"
        Me.col_cost.DisplayFormat.FormatString = "n2"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.OptionsColumn.ReadOnly = True
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 9
        Me.col_cost.Width = 62
        '
        'col_warehouse
        '
        Me.col_warehouse.Caption = "Warehouse"
        Me.col_warehouse.FieldName = "store_name"
        Me.col_warehouse.MaxWidth = 250
        Me.col_warehouse.MinWidth = 150
        Me.col_warehouse.Name = "col_warehouse"
        Me.col_warehouse.OptionsColumn.ReadOnly = True
        Me.col_warehouse.Visible = True
        Me.col_warehouse.VisibleIndex = 10
        Me.col_warehouse.Width = 150
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 250
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.OptionsColumn.ReadOnly = True
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 11
        Me.col_supplier.Width = 250
        '
        'col_poid
        '
        Me.col_poid.Caption = "Purchase ID"
        Me.col_poid.FieldName = "poid"
        Me.col_poid.Name = "col_poid"
        Me.col_poid.OptionsColumn.ReadOnly = True
        Me.col_poid.Visible = True
        Me.col_poid.VisibleIndex = 12
        Me.col_poid.Width = 82
        '
        'col_reference
        '
        Me.col_reference.Caption = "Receipt Ref."
        Me.col_reference.FieldName = "receipt_ref"
        Me.col_reference.Name = "col_reference"
        Me.col_reference.OptionsColumn.ReadOnly = True
        Me.col_reference.Visible = True
        Me.col_reference.VisibleIndex = 13
        Me.col_reference.Width = 84
        '
        'col_tax_type
        '
        Me.col_tax_type.Caption = "Tax Type"
        Me.col_tax_type.FieldName = "tax_type"
        Me.col_tax_type.Name = "col_tax_type"
        Me.col_tax_type.Visible = True
        Me.col_tax_type.VisibleIndex = 14
        Me.col_tax_type.Width = 70
        '
        'col_dr_no
        '
        Me.col_dr_no.Caption = "DR No."
        Me.col_dr_no.FieldName = "dr_no"
        Me.col_dr_no.Name = "col_dr_no"
        Me.col_dr_no.Visible = True
        Me.col_dr_no.VisibleIndex = 15
        Me.col_dr_no.Width = 70
        '
        'col_si_no
        '
        Me.col_si_no.Caption = "SI No."
        Me.col_si_no.FieldName = "si_no"
        Me.col_si_no.Name = "col_si_no"
        Me.col_si_no.Visible = True
        Me.col_si_no.VisibleIndex = 16
        Me.col_si_no.Width = 70
        '
        'col_encoder
        '
        Me.col_encoder.Caption = "Encoder"
        Me.col_encoder.FieldName = "first_name"
        Me.col_encoder.Name = "col_encoder"
        Me.col_encoder.OptionsColumn.ReadOnly = True
        Me.col_encoder.Visible = True
        Me.col_encoder.VisibleIndex = 17
        Me.col_encoder.Width = 100
        '
        'col_counted_by
        '
        Me.col_counted_by.Caption = "Counted by"
        Me.col_counted_by.FieldName = "count_by"
        Me.col_counted_by.MinWidth = 50
        Me.col_counted_by.Name = "col_counted_by"
        Me.col_counted_by.Visible = True
        Me.col_counted_by.VisibleIndex = 18
        Me.col_counted_by.Width = 100
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "reference"
        Me.col_id.Name = "col_id"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Purchase ID"
        Me.GridColumn7.FieldName = "poid"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 109
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(240, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(12, 14)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "to"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(55, 14)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Coverage:"
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.insertheader_32x32
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(1530, 62)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(123, 46)
        Me.btn_print.TabIndex = 24
        Me.btn_print.Text = "Export"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(165, 31)
        Me.LabelControl4.TabIndex = 74
        Me.LabelControl4.Text = "Delivery Logs"
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view.ImageOptions.ImageToTextIndent = 5
        Me.btn_view.Location = New System.Drawing.Point(416, 74)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(80, 27)
        Me.btn_view.TabIndex = 75
        Me.btn_view.Text = "View"
        '
        'dt_start
        '
        Me.dt_start.EditValue = Nothing
        Me.dt_start.Location = New System.Drawing.Point(81, 73)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dt_start.Properties.Appearance.Options.UseFont = True
        Me.dt_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.dt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_start.Size = New System.Drawing.Size(153, 28)
        Me.dt_start.TabIndex = 76
        '
        'dt_end
        '
        Me.dt_end.EditValue = Nothing
        Me.dt_end.Location = New System.Drawing.Point(257, 73)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.dt_end.Properties.Appearance.Options.UseFont = True
        Me.dt_end.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_end.Size = New System.Drawing.Size(153, 28)
        Me.dt_end.TabIndex = 77
        '
        'col_isBundle
        '
        Me.col_isBundle.Caption = "Bundle"
        Me.col_isBundle.FieldName = "is_bundle"
        Me.col_isBundle.Name = "col_isBundle"
        Me.col_isBundle.Visible = True
        Me.col_isBundle.VisibleIndex = 2
        '
        'frm_purchaseorder_delivery_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1665, 642)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_supplier_deliveries)
        Me.Name = "frm_purchaseorder_delivery_logs"
        Me.Text = "Delivery Logs"
        CType(Me.grid_supplier_deliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_supplier_deliveries_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_edit_date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_edit_date, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_supplier_deliveries As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_supplier_deliveries_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_poid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_timestamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_encoder As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_supplier As GridColumn
    Friend WithEvents col_description As GridColumn
    Friend WithEvents col_cost As GridColumn
    Friend WithEvents btn_print As SimpleButton
    Friend WithEvents col_reference As GridColumn
    Friend WithEvents dt_edit_date As RepositoryItemDateEdit
    Friend WithEvents col_id As GridColumn
    Friend WithEvents col_pid As GridColumn
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents col_counted_by As GridColumn
    Friend WithEvents col_unit As GridColumn
    Friend WithEvents col_brand As GridColumn
    Friend WithEvents btn_view As SimpleButton
    Friend WithEvents dt_start As DateEdit
    Friend WithEvents dt_end As DateEdit
    Friend WithEvents col_tax_type As GridColumn
    Friend WithEvents col_dr_no As GridColumn
    Friend WithEvents col_si_no As GridColumn
    Friend WithEvents col_date_of_delivery As GridColumn
    Friend WithEvents col_isBundle As GridColumn
End Class
