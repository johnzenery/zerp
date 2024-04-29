<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock_return_delivery_logs
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
        Me.grid_deliveries = New DevExpress.XtraGrid.GridControl()
        Me.grid_deliveries_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delivery_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_serial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_return_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_approval_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_at = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_deliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_deliveries_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(401, 38)
        Me.LabelControl1.TabIndex = 133
        Me.LabelControl1.Text = "Return to Vendor Deliveries"
        '
        'grid_deliveries
        '
        Me.grid_deliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_deliveries.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_deliveries.Location = New System.Drawing.Point(-1, 86)
        Me.grid_deliveries.MainView = Me.grid_deliveries_view
        Me.grid_deliveries.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_deliveries.Name = "grid_deliveries"
        Me.grid_deliveries.Size = New System.Drawing.Size(1522, 625)
        Me.grid_deliveries.TabIndex = 134
        Me.grid_deliveries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_deliveries_view})
        '
        'grid_deliveries_view
        '
        Me.grid_deliveries_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_deliveries_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.grid_deliveries_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_deliveries_view.Appearance.Row.Options.UseFont = True
        Me.grid_deliveries_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_deliveries_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_deliveries_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_deliveries_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_deliveries_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_rid, Me.col_qty_received, Me.col_delivery_ref, Me.col_winmodel, Me.col_supmodel, Me.col_description, Me.col_supplier, Me.col_serial, Me.col_return_action, Me.col_approval_supplier, Me.col_status, Me.col_received_at})
        Me.grid_deliveries_view.DetailHeight = 431
        Me.grid_deliveries_view.GridControl = Me.grid_deliveries
        Me.grid_deliveries_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_deliveries_view.Name = "grid_deliveries_view"
        Me.grid_deliveries_view.OptionsBehavior.ReadOnly = True
        Me.grid_deliveries_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_deliveries_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_deliveries_view.OptionsView.ColumnAutoWidth = False
        Me.grid_deliveries_view.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.MaxWidth = 58
        Me.col_id.MinWidth = 12
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 58
        '
        'col_rid
        '
        Me.col_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_rid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.Caption = "RID"
        Me.col_rid.FieldName = "rid"
        Me.col_rid.MaxWidth = 70
        Me.col_rid.MinWidth = 12
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 48
        '
        'col_qty_received
        '
        Me.col_qty_received.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty_received.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty_received.Caption = "QTY"
        Me.col_qty_received.FieldName = "qty_received"
        Me.col_qty_received.MaxWidth = 70
        Me.col_qty_received.MinWidth = 70
        Me.col_qty_received.Name = "col_qty_received"
        Me.col_qty_received.Visible = True
        Me.col_qty_received.VisibleIndex = 2
        Me.col_qty_received.Width = 70
        '
        'col_delivery_ref
        '
        Me.col_delivery_ref.Caption = "Delivery Ref."
        Me.col_delivery_ref.FieldName = "delivery_ref"
        Me.col_delivery_ref.MaxWidth = 117
        Me.col_delivery_ref.MinWidth = 23
        Me.col_delivery_ref.Name = "col_delivery_ref"
        Me.col_delivery_ref.Visible = True
        Me.col_delivery_ref.VisibleIndex = 9
        Me.col_delivery_ref.Width = 117
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MaxWidth = 140
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 3
        Me.col_winmodel.Width = 112
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MaxWidth = 140
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 4
        Me.col_supmodel.Width = 112
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 200
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 5
        Me.col_description.Width = 200
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.col_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MaxWidth = 292
        Me.col_supplier.MinWidth = 292
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 8
        Me.col_supplier.Width = 292
        '
        'col_serial
        '
        Me.col_serial.AppearanceCell.Options.UseTextOptions = True
        Me.col_serial.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MaxWidth = 163
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 6
        Me.col_serial.Width = 114
        '
        'col_return_action
        '
        Me.col_return_action.Caption = "Return Action"
        Me.col_return_action.FieldName = "return_action"
        Me.col_return_action.MaxWidth = 152
        Me.col_return_action.MinWidth = 23
        Me.col_return_action.Name = "col_return_action"
        Me.col_return_action.Visible = True
        Me.col_return_action.VisibleIndex = 10
        Me.col_return_action.Width = 152
        '
        'col_approval_supplier
        '
        Me.col_approval_supplier.Caption = "Credit Cost"
        Me.col_approval_supplier.FieldName = "credit_cost"
        Me.col_approval_supplier.MaxWidth = 117
        Me.col_approval_supplier.MinWidth = 12
        Me.col_approval_supplier.Name = "col_approval_supplier"
        Me.col_approval_supplier.Visible = True
        Me.col_approval_supplier.VisibleIndex = 7
        Me.col_approval_supplier.Width = 117
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Received By"
        Me.col_status.FieldName = "received_by"
        Me.col_status.MaxWidth = 140
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 11
        Me.col_status.Width = 140
        '
        'col_received_at
        '
        Me.col_received_at.Caption = "Date Received"
        Me.col_received_at.DisplayFormat.FormatString = "MM/dd/yyyy hh:mm tt"
        Me.col_received_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_received_at.FieldName = "received_at"
        Me.col_received_at.MaxWidth = 175
        Me.col_received_at.MinWidth = 23
        Me.col_received_at.Name = "col_received_at"
        Me.col_received_at.Visible = True
        Me.col_received_at.VisibleIndex = 12
        Me.col_received_at.Width = 175
        '
        'frm_stock_return_delivery_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 706)
        Me.Controls.Add(Me.grid_deliveries)
        Me.Controls.Add(Me.LabelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_stock_return_delivery_logs"
        Me.Text = "Return to Vendor Logs"
        CType(Me.grid_deliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_deliveries_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_deliveries As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_deliveries_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_delivery_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_serial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_return_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_approval_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
End Class
