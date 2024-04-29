<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_stock_return_batch
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_serial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_issue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_print_batch = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_arrange = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print_slip = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(14, 15)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(267, 38)
        Me.lbl_title.TabIndex = 135
        Me.lbl_title.Text = "New Batch Pullout"
        '
        'cbb_warehouse
        '
        Me.cbb_warehouse.Location = New System.Drawing.Point(120, 149)
        Me.cbb_warehouse.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_warehouse.Name = "cbb_warehouse"
        Me.cbb_warehouse.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.cbb_warehouse.Properties.Appearance.Options.UseFont = True
        Me.cbb_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_warehouse.Size = New System.Drawing.Size(293, 34)
        Me.cbb_warehouse.TabIndex = 152
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(25, 158)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl3.TabIndex = 151
        Me.LabelControl3.Text = "Warehouse"
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(120, 107)
        Me.cbb_supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(293, 34)
        Me.cbb_supplier.TabIndex = 150
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(25, 116)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl2.TabIndex = 149
        Me.LabelControl2.Text = "Supplier"
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_returns.Location = New System.Drawing.Point(5, 217)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.Size = New System.Drawing.Size(1079, 444)
        Me.grid_returns.TabIndex = 153
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_supmodel, Me.col_serial, Me.col_type, Me.col_issue})
        Me.grid_returns_view.DetailHeight = 431
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.Editable = False
        Me.grid_returns_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_returns_view.OptionsSelection.MultiSelect = True
        Me.grid_returns_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_returns_view.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_id
        '
        Me.col_id.Caption = "RID"
        Me.col_id.FieldName = "id"
        Me.col_id.MaxWidth = 80
        Me.col_id.MinWidth = 23
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 73
        '
        'col_qty
        '
        Me.col_qty.Caption = "QTY"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 58
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 2
        Me.col_qty.Width = 57
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 82
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 3
        Me.col_pid.Width = 80
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MaxWidth = 140
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 4
        Me.col_winmodel.Width = 137
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MaxWidth = 140
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 5
        Me.col_supmodel.Width = 137
        '
        'col_serial
        '
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MaxWidth = 175
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 6
        Me.col_serial.Width = 170
        '
        'col_type
        '
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "type"
        Me.col_type.MaxWidth = 117
        Me.col_type.MinWidth = 23
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 7
        Me.col_type.Width = 112
        '
        'col_issue
        '
        Me.col_issue.Caption = "Issue / Defect"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 23
        Me.col_issue.Name = "col_issue"
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 8
        Me.col_issue.Width = 190
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 10
        Me.btn_submit.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_submit.Location = New System.Drawing.Point(964, 668)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(120, 43)
        Me.btn_submit.TabIndex = 154
        Me.btn_submit.Text = "Submit"
        '
        'lbl_status
        '
        Me.lbl_status.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_status.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.lbl_status.Appearance.Options.UseFont = True
        Me.lbl_status.Appearance.Options.UseForeColor = True
        Me.lbl_status.Location = New System.Drawing.Point(120, 75)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(70, 24)
        Me.lbl_status.TabIndex = 156
        Me.lbl_status.Text = "_status"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(25, 83)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl1.TabIndex = 155
        Me.LabelControl1.Text = "Status"
        '
        'btn_print_batch
        '
        Me.btn_print_batch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print_batch.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_print_batch.Appearance.Options.UseFont = True
        Me.btn_print_batch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print_batch.ImageOptions.ImageToTextIndent = 10
        Me.btn_print_batch.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        Me.btn_print_batch.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_print_batch.Location = New System.Drawing.Point(882, 15)
        Me.btn_print_batch.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_print_batch.Name = "btn_print_batch"
        Me.btn_print_batch.Size = New System.Drawing.Size(93, 98)
        Me.btn_print_batch.TabIndex = 158
        Me.btn_print_batch.Text = "Print Batch"
        '
        'btn_arrange
        '
        Me.btn_arrange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_arrange.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_arrange.Appearance.Options.UseFont = True
        Me.btn_arrange.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boproductgroup_32x32
        Me.btn_arrange.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_arrange.ImageOptions.ImageToTextIndent = 10
        Me.btn_arrange.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_arrange.Location = New System.Drawing.Point(782, 15)
        Me.btn_arrange.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_arrange.Name = "btn_arrange"
        Me.btn_arrange.Size = New System.Drawing.Size(93, 98)
        Me.btn_arrange.TabIndex = 159
        Me.btn_arrange.Text = "Arrange"
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_delete.Appearance.Options.UseBackColor = True
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_delete.ImageOptions.ImageToTextIndent = 10
        Me.btn_delete.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_delete.Location = New System.Drawing.Point(5, 668)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(120, 43)
        Me.btn_delete.TabIndex = 160
        Me.btn_delete.Text = "Delete"
        '
        'btn_print_slip
        '
        Me.btn_print_slip.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print_slip.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_print_slip.Appearance.Options.UseFont = True
        Me.btn_print_slip.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print_slip.ImageOptions.ImageToTextIndent = 10
        Me.btn_print_slip.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.printarea
        Me.btn_print_slip.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_print_slip.Location = New System.Drawing.Point(982, 15)
        Me.btn_print_slip.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_print_slip.Name = "btn_print_slip"
        Me.btn_print_slip.Size = New System.Drawing.Size(93, 98)
        Me.btn_print_slip.TabIndex = 161
        Me.btn_print_slip.Text = "Print Slip"
        '
        'frm_stock_return_batch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1090, 725)
        Me.Controls.Add(Me.btn_print_slip)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_arrange)
        Me.Controls.Add(Me.btn_print_batch)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.grid_returns)
        Me.Controls.Add(Me.cbb_warehouse)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cbb_supplier)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_stock_return_batch"
        Me.Text = "Batch Pullout"
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_serial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_issue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_print_batch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_arrange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print_slip As DevExpress.XtraEditors.SimpleButton
End Class
