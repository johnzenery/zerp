<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock_return_liquidation_new
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
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_liquidation_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_issue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_liquidation = New DevExpress.XtraGrid.GridControl()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total_amount = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_decline = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_created_by = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_liquidation_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_liquidation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_status
        '
        Me.lbl_status.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_status.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.lbl_status.Appearance.Options.UseFont = True
        Me.lbl_status.Appearance.Options.UseForeColor = True
        Me.lbl_status.Location = New System.Drawing.Point(121, 74)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(70, 24)
        Me.lbl_status.TabIndex = 170
        Me.lbl_status.Text = "_status"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(26, 82)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl1.TabIndex = 169
        Me.LabelControl1.Text = "Status"
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_create.Appearance.Options.UseBackColor = True
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.ImageOptions.ImageToTextIndent = 10
        Me.btn_create.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_create.Location = New System.Drawing.Point(1304, 32)
        Me.btn_create.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(78, 43)
        Me.btn_create.TabIndex = 168
        Me.btn_create.Text = "Create"
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "n2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "total_cost"
        Me.col_amount.MaxWidth = 120
        Me.col_amount.MinWidth = 23
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 10
        Me.col_amount.Width = 119
        '
        'col_cost
        '
        Me.col_cost.Caption = "Cost"
        Me.col_cost.DisplayFormat.FormatString = "n2"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.MaxWidth = 120
        Me.col_cost.MinWidth = 23
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 9
        Me.col_cost.Width = 115
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MaxWidth = 300
        Me.col_description.MinWidth = 23
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 6
        Me.col_description.Width = 289
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MaxWidth = 180
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 5
        Me.col_winmodel.Width = 173
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 82
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 4
        Me.col_pid.Width = 79
        '
        'col_qty
        '
        Me.col_qty.Caption = "QTY"
        Me.col_qty.FieldName = "qty_received"
        Me.col_qty.MaxWidth = 58
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 3
        Me.col_qty.Width = 56
        '
        'col_rid
        '
        Me.col_rid.Caption = "RID"
        Me.col_rid.FieldName = "rid"
        Me.col_rid.MaxWidth = 80
        Me.col_rid.MinWidth = 23
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 2
        Me.col_rid.Width = 77
        '
        'grid_liquidation_view
        '
        Me.grid_liquidation_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_liquidation_view.Appearance.Row.Options.UseFont = True
        Me.grid_liquidation_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_rid, Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_description, Me.col_remarks, Me.col_issue, Me.col_cost, Me.col_amount, Me.col_id})
        Me.grid_liquidation_view.DetailHeight = 431
        Me.grid_liquidation_view.GridControl = Me.grid_liquidation
        Me.grid_liquidation_view.Name = "grid_liquidation_view"
        Me.grid_liquidation_view.OptionsBehavior.Editable = False
        Me.grid_liquidation_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_liquidation_view.OptionsSelection.MultiSelect = True
        Me.grid_liquidation_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_liquidation_view.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_remarks
        '
        Me.col_remarks.Caption = "Remarks"
        Me.col_remarks.FieldName = "remarks"
        Me.col_remarks.MaxWidth = 250
        Me.col_remarks.MinWidth = 25
        Me.col_remarks.Name = "col_remarks"
        Me.col_remarks.Visible = True
        Me.col_remarks.VisibleIndex = 7
        Me.col_remarks.Width = 94
        '
        'col_issue
        '
        Me.col_issue.Caption = "Issue"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 25
        Me.col_issue.Name = "col_issue"
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 8
        Me.col_issue.Width = 94
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.MaxWidth = 60
        Me.col_id.MinWidth = 25
        Me.col_id.Name = "col_id"
        Me.col_id.OptionsColumn.ReadOnly = True
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 60
        '
        'grid_liquidation
        '
        Me.grid_liquidation.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_liquidation.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_liquidation.Location = New System.Drawing.Point(6, 144)
        Me.grid_liquidation.MainView = Me.grid_liquidation_view
        Me.grid_liquidation.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_liquidation.Name = "grid_liquidation"
        Me.grid_liquidation.Size = New System.Drawing.Size(1398, 516)
        Me.grid_liquidation.TabIndex = 167
        Me.grid_liquidation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_liquidation_view})
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
        Me.btn_delete.Location = New System.Drawing.Point(6, 671)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(124, 43)
        Me.btn_delete.TabIndex = 173
        Me.btn_delete.Text = "Delete"
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(15, 14)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(323, 38)
        Me.lbl_title.TabIndex = 162
        Me.lbl_title.Text = "New Stock Liquidation"
        '
        'lbl_total_amount
        '
        Me.lbl_total_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_amount.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_amount.Appearance.Options.UseFont = True
        Me.lbl_total_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_total_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_amount.Location = New System.Drawing.Point(1176, 670)
        Me.lbl_total_amount.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_total_amount.Name = "lbl_total_amount"
        Me.lbl_total_amount.Size = New System.Drawing.Size(220, 44)
        Me.lbl_total_amount.TabIndex = 174
        Me.lbl_total_amount.Text = "₱0.00"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseTextOptions = True
        Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Location = New System.Drawing.Point(948, 670)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(220, 44)
        Me.LabelControl3.TabIndex = 175
        Me.LabelControl3.Text = "Grand Total"
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 10
        Me.btn_print.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_print.Location = New System.Drawing.Point(1218, 32)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(78, 43)
        Me.btn_print.TabIndex = 176
        Me.btn_print.Text = "Print"
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_approved.Appearance.Options.UseBackColor = True
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_approved.ImageOptions.ImageToTextIndent = 10
        Me.btn_approved.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_approved.Location = New System.Drawing.Point(1132, 32)
        Me.btn_approved.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(78, 43)
        Me.btn_approved.TabIndex = 177
        Me.btn_approved.Text = "Approve"
        Me.btn_approved.Visible = False
        '
        'btn_decline
        '
        Me.btn_decline.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_decline.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_decline.Appearance.Options.UseBackColor = True
        Me.btn_decline.Appearance.Options.UseFont = True
        Me.btn_decline.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_decline.ImageOptions.ImageToTextIndent = 10
        Me.btn_decline.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_decline.Location = New System.Drawing.Point(1046, 32)
        Me.btn_decline.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_decline.Name = "btn_decline"
        Me.btn_decline.Size = New System.Drawing.Size(78, 43)
        Me.btn_decline.TabIndex = 178
        Me.btn_decline.Text = "Decline"
        Me.btn_decline.Visible = False
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(26, 106)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl2.TabIndex = 179
        Me.LabelControl2.Text = "Created by"
        '
        'lbl_created_by
        '
        Me.lbl_created_by.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.lbl_created_by.Appearance.Options.UseFont = True
        Me.lbl_created_by.Location = New System.Drawing.Point(121, 106)
        Me.lbl_created_by.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_created_by.Name = "lbl_created_by"
        Me.lbl_created_by.Size = New System.Drawing.Size(58, 16)
        Me.lbl_created_by.TabIndex = 180
        Me.lbl_created_by.Text = "John Zen"
        '
        'frm_stock_return_liquidation_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 725)
        Me.Controls.Add(Me.lbl_created_by)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btn_decline)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lbl_total_amount)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.grid_liquidation)
        Me.Controls.Add(Me.lbl_title)
        Me.Name = "frm_stock_return_liquidation_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Stock Liquidation"
        CType(Me.grid_liquidation_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_liquidation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_liquidation_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_liquidation As DevExpress.XtraGrid.GridControl
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_decline As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_created_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_issue As DevExpress.XtraGrid.Columns.GridColumn
End Class
