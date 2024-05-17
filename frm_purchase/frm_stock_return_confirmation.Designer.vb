<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock_return_confirmation
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
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_status = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.col_batch = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_declined = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_pr_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_retrieve = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pr_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_returns.Location = New System.Drawing.Point(5, 145)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbb_status})
        Me.grid_returns.Size = New System.Drawing.Size(1327, 553)
        Me.grid_returns.TabIndex = 138
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_supmodel, Me.col_serial, Me.col_type, Me.col_issue, Me.col_status, Me.col_batch})
        Me.grid_returns_view.DetailHeight = 431
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsSelection.EnableAppearanceFocusedCell = False
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
        Me.col_id.OptionsColumn.AllowEdit = False
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 80
        '
        'col_qty
        '
        Me.col_qty.Caption = "QTY"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 58
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.OptionsColumn.AllowEdit = False
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 1
        Me.col_qty.Width = 57
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 82
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.OptionsColumn.AllowEdit = False
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 2
        Me.col_pid.Width = 80
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MaxWidth = 140
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.OptionsColumn.AllowEdit = False
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 3
        Me.col_winmodel.Width = 138
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MaxWidth = 140
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.OptionsColumn.AllowEdit = False
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 4
        Me.col_supmodel.Width = 138
        '
        'col_serial
        '
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MaxWidth = 175
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.OptionsColumn.AllowEdit = False
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 5
        Me.col_serial.Width = 172
        '
        'col_type
        '
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "type"
        Me.col_type.MaxWidth = 117
        Me.col_type.MinWidth = 23
        Me.col_type.Name = "col_type"
        Me.col_type.OptionsColumn.AllowEdit = False
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 6
        Me.col_type.Width = 115
        '
        'col_issue
        '
        Me.col_issue.Caption = "Issue / Defect"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 23
        Me.col_issue.Name = "col_issue"
        Me.col_issue.OptionsColumn.AllowEdit = False
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 7
        Me.col_issue.Width = 261
        '
        'col_status
        '
        Me.col_status.AppearanceCell.BackColor = System.Drawing.Color.White
        Me.col_status.AppearanceCell.Options.UseBackColor = True
        Me.col_status.Caption = "Status"
        Me.col_status.ColumnEdit = Me.cbb_status
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 175
        Me.col_status.MinWidth = 140
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 8
        Me.col_status.Width = 175
        '
        'cbb_status
        '
        Me.cbb_status.AutoHeight = False
        Me.cbb_status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_status.Items.AddRange(New Object() {"Approved", "Declined"})
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'col_batch
        '
        Me.col_batch.Caption = "Batch ID"
        Me.col_batch.FieldName = "batch_id"
        Me.col_batch.MaxWidth = 80
        Me.col_batch.MinWidth = 25
        Me.col_batch.Name = "col_batch"
        Me.col_batch.Width = 80
        '
        'btn_declined
        '
        Me.btn_declined.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_declined.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_declined.Appearance.Options.UseBackColor = True
        Me.btn_declined.Appearance.Options.UseFont = True
        Me.btn_declined.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_declined.ImageOptions.ImageToTextIndent = 10
        Me.btn_declined.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_declined.Location = New System.Drawing.Point(669, 706)
        Me.btn_declined.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_declined.Name = "btn_declined"
        Me.btn_declined.Size = New System.Drawing.Size(120, 43)
        Me.btn_declined.TabIndex = 141
        Me.btn_declined.Text = "Declined"
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_approved.Appearance.Options.UseBackColor = True
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_approved.ImageOptions.ImageToTextIndent = 10
        Me.btn_approved.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_approved.Location = New System.Drawing.Point(796, 706)
        Me.btn_approved.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(120, 43)
        Me.btn_approved.TabIndex = 140
        Me.btn_approved.Text = "Approved"
        '
        'txt_pr_id
        '
        Me.txt_pr_id.EditValue = ""
        Me.txt_pr_id.Location = New System.Drawing.Point(84, 85)
        Me.txt_pr_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pr_id.Name = "txt_pr_id"
        Me.txt_pr_id.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_pr_id.Properties.Appearance.Options.UseFont = True
        Me.txt_pr_id.Size = New System.Drawing.Size(125, 34)
        Me.txt_pr_id.TabIndex = 142
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 94)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl1.TabIndex = 144
        Me.LabelControl1.Text = "Pullout ID"
        '
        'btn_retrieve
        '
        Me.btn_retrieve.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_retrieve.Appearance.Options.UseFont = True
        Me.btn_retrieve.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_retrieve.ImageOptions.ImageToTextIndent = 10
        Me.btn_retrieve.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_retrieve.Location = New System.Drawing.Point(217, 85)
        Me.btn_retrieve.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_retrieve.Name = "btn_retrieve"
        Me.btn_retrieve.Size = New System.Drawing.Size(97, 37)
        Me.btn_retrieve.TabIndex = 145
        Me.btn_retrieve.Text = "Retrieve"
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
        Me.lbl_title.Size = New System.Drawing.Size(312, 38)
        Me.lbl_title.TabIndex = 146
        Me.lbl_title.Text = "Supplier Confirmation"
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 10
        Me.btn_submit.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_submit.Location = New System.Drawing.Point(1204, 707)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(120, 43)
        Me.btn_submit.TabIndex = 147
        Me.btn_submit.Text = "Submit"
        '
        'frm_stock_return_confirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1337, 763)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_retrieve)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_pr_id)
        Me.Controls.Add(Me.btn_declined)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.grid_returns)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_stock_return_confirmation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier Confirmation"
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pr_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

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
    Friend WithEvents btn_declined As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_pr_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_retrieve As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_status As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_batch As DevExpress.XtraGrid.Columns.GridColumn
End Class
