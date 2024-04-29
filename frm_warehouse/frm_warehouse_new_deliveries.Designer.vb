<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_new_deliveries
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
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_delivered_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_delivered = New DevExpress.XtraGrid.GridControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        CType(Me.grid_delivered_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_delivered, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        Me.btn_print.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_print.Location = New System.Drawing.Point(1104, 58)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(160, 46)
        Me.btn_print.TabIndex = 32
        Me.btn_print.Text = "Print"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(251, 73)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 16)
        Me.LabelControl2.TabIndex = 30
        Me.LabelControl2.Text = "to"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 73)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 29
        Me.LabelControl1.Text = "Coverage:"
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
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 250
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 4
        Me.col_description.Width = 288
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 7
        Me.col_main_category.Width = 126
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Timestamp"
        Me.GridColumn6.DisplayFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "date_received"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 1
        Me.GridColumn6.Width = 149
        '
        'col_action
        '
        Me.col_action.Caption = "Warehouse"
        Me.col_action.FieldName = "store_name"
        Me.col_action.MaxWidth = 250
        Me.col_action.MinWidth = 150
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 5
        Me.col_action.Width = 200
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.FieldName = "qty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 82
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Model"
        Me.GridColumn2.FieldName = "winmodel"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 3
        Me.GridColumn2.Width = 91
        '
        'grid_delivered_view
        '
        Me.grid_delivered_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_delivered_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_delivered_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_delivered_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_delivered_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_delivered_view.Appearance.Row.Options.UseFont = True
        Me.grid_delivered_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.GridColumn2, Me.GridColumn3, Me.col_action, Me.col_brand, Me.GridColumn6, Me.col_main_category, Me.col_description, Me.col_sub_category})
        Me.grid_delivered_view.GridControl = Me.grid_delivered
        Me.grid_delivered_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_delivered_view.Name = "grid_delivered_view"
        Me.grid_delivered_view.OptionsBehavior.ReadOnly = True
        Me.grid_delivered_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_delivered_view.OptionsView.AutoCalcPreviewLineCount = True
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "reference"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 89
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 6
        Me.col_brand.Width = 101
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.MinWidth = 80
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 8
        Me.col_sub_category.Width = 124
        '
        'grid_delivered
        '
        Me.grid_delivered.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_delivered.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_delivered.Location = New System.Drawing.Point(-1, 110)
        Me.grid_delivered.MainView = Me.grid_delivered_view
        Me.grid_delivered.Name = "grid_delivered"
        Me.grid_delivered.Size = New System.Drawing.Size(1280, 521)
        Me.grid_delivered.TabIndex = 26
        Me.grid_delivered.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_delivered_view})
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(317, 31)
        Me.LabelControl3.TabIndex = 33
        Me.LabelControl3.Text = "New Stocks Delivery Logs"
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view.ImageOptions.ImageToTextIndent = 5
        Me.btn_view.Location = New System.Drawing.Point(433, 66)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(108, 30)
        Me.btn_view.TabIndex = 34
        Me.btn_view.Text = "View"
        '
        'dt_start
        '
        Me.dt_start.EditValue = Nothing
        Me.dt_start.Location = New System.Drawing.Point(85, 66)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dt_start.Properties.Appearance.Options.UseFont = True
        Me.dt_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.dt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Properties.EditFormat.FormatString = "MMMM dd, yyyy"
        Me.dt_start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_start.Size = New System.Drawing.Size(157, 30)
        Me.dt_start.TabIndex = 35
        '
        'dt_end
        '
        Me.dt_end.EditValue = Nothing
        Me.dt_end.Location = New System.Drawing.Point(270, 66)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.dt_end.Properties.Appearance.Options.UseFont = True
        Me.dt_end.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Properties.EditFormat.FormatString = "MMMM dd, yyyy"
        Me.dt_end.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_end.Size = New System.Drawing.Size(157, 30)
        Me.dt_end.TabIndex = 36
        '
        'frm_warehouse_new_deliveries
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1276, 631)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_delivered)
        Me.Name = "frm_warehouse_new_deliveries"
        Me.Text = "New Stocks Delivery Logs"
        CType(Me.grid_delivered_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_delivered, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_delivered_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_delivered As DevExpress.XtraGrid.GridControl
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dt_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dt_end As DevExpress.XtraEditors.DateEdit
End Class
