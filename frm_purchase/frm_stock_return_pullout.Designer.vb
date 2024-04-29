<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock_return_pullout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stock_return_pullout))
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
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
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sent = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_comments = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_comments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lbl_title.Size = New System.Drawing.Size(322, 38)
        Me.lbl_title.TabIndex = 134
        Me.lbl_title.Text = "New Pull Out Request"
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(106, 107)
        Me.cbb_supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(293, 34)
        Me.cbb_supplier.TabIndex = 136
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(23, 116)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl2.TabIndex = 135
        Me.LabelControl2.Text = "Supplier"
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_returns.Location = New System.Drawing.Point(5, 207)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.Size = New System.Drawing.Size(1366, 367)
        Me.grid_returns.TabIndex = 137
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_supmodel, Me.col_serial, Me.col_type, Me.col_issue, Me.col_description})
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
        Me.col_winmodel.Width = 138
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
        Me.col_supmodel.Width = 138
        '
        'col_serial
        '
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MaxWidth = 175
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 7
        Me.col_serial.Width = 172
        '
        'col_type
        '
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "type"
        Me.col_type.MaxWidth = 117
        Me.col_type.MinWidth = 23
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 8
        Me.col_type.Width = 115
        '
        'col_issue
        '
        Me.col_issue.Caption = "Issue / Defect"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 23
        Me.col_issue.Name = "col_issue"
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 9
        Me.col_issue.Width = 234
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_create.Appearance.Options.UseBackColor = True
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.ImageOptions.ImageToTextIndent = 10
        Me.btn_create.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_create.Location = New System.Drawing.Point(1243, 644)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(120, 43)
        Me.btn_create.TabIndex = 138
        Me.btn_create.Text = "Create"
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_delete.ImageOptions.ImageToTextIndent = 10
        Me.btn_delete.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_trash
        Me.btn_delete.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_delete.Location = New System.Drawing.Point(1069, 15)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(93, 98)
        Me.btn_delete.TabIndex = 139
        Me.btn_delete.Text = "Delete"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(23, 77)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl1.TabIndex = 143
        Me.LabelControl1.Text = "Status"
        '
        'lbl_status
        '
        Me.lbl_status.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_status.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.lbl_status.Appearance.Options.UseFont = True
        Me.lbl_status.Appearance.Options.UseForeColor = True
        Me.lbl_status.Location = New System.Drawing.Point(106, 69)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(70, 24)
        Me.lbl_status.TabIndex = 144
        Me.lbl_status.Text = "_status"
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 10
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        Me.btn_print.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_print.Location = New System.Drawing.Point(1270, 15)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(93, 98)
        Me.btn_print.TabIndex = 146
        Me.btn_print.Text = "Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Request"
        '
        'btn_sent
        '
        Me.btn_sent.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sent.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_sent.Appearance.Options.UseFont = True
        Me.btn_sent.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_sent.ImageOptions.ImageToTextIndent = 10
        Me.btn_sent.ImageOptions.SvgImage = CType(resources.GetObject("btn_sent.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_sent.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_sent.Location = New System.Drawing.Point(1169, 15)
        Me.btn_sent.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sent.Name = "btn_sent"
        Me.btn_sent.Size = New System.Drawing.Size(93, 98)
        Me.btn_sent.TabIndex = 149
        Me.btn_sent.Text = "Send to" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Supplier"
        '
        'cbb_warehouse
        '
        Me.cbb_warehouse.Location = New System.Drawing.Point(106, 149)
        Me.cbb_warehouse.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_warehouse.Name = "cbb_warehouse"
        Me.cbb_warehouse.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.cbb_warehouse.Properties.Appearance.Options.UseFont = True
        Me.cbb_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_warehouse.Size = New System.Drawing.Size(293, 34)
        Me.cbb_warehouse.TabIndex = 151
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(23, 158)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl3.TabIndex = 150
        Me.LabelControl3.Text = "Pickup Site"
        '
        'txt_comments
        '
        Me.txt_comments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_comments.EditValue = ""
        Me.txt_comments.Location = New System.Drawing.Point(23, 606)
        Me.txt_comments.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_comments.Name = "txt_comments"
        Me.txt_comments.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.txt_comments.Properties.Appearance.Options.UseFont = True
        Me.txt_comments.Size = New System.Drawing.Size(842, 81)
        Me.txt_comments.TabIndex = 152
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(23, 585)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(67, 16)
        Me.LabelControl4.TabIndex = 153
        Me.LabelControl4.Text = "Comments"
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 200
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 6
        Me.col_description.Width = 200
        '
        'frm_stock_return_pullout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1377, 701)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_comments)
        Me.Controls.Add(Me.cbb_warehouse)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_sent)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.grid_returns)
        Me.Controls.Add(Me.cbb_supplier)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.lbl_title)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_stock_return_pullout"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pullout Request"
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_comments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_serial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_issue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_sent As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbb_warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_comments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
End Class
