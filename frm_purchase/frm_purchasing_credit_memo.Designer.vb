<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_purchasing_credit_memo
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_createdat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_voucher = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_is_applied = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cb_is_applied = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.btn_new_return = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.cb_show_all = New DevExpress.XtraEditors.CheckButton()
        Me.btn_pending_credits = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_is_applied, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_returns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns.Location = New System.Drawing.Point(-1, 135)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order, Me.cb_is_applied})
        Me.grid_returns.Size = New System.Drawing.Size(1432, 747)
        Me.grid_returns.TabIndex = 13
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_returns_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_returns_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_returns_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_rid, Me.col_supplier, Me.col_total_cost, Me.col_createdat, Me.col_voucher, Me.col_is_applied})
        Me.grid_returns_view.DetailHeight = 431
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_returns_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_view_order
        Me.col_view.MaxWidth = 58
        Me.col_view.MinWidth = 58
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 58
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_rid
        '
        Me.col_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_rid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.Caption = "Return ID"
        Me.col_rid.FieldName = "po_return_id"
        Me.col_rid.MaxWidth = 117
        Me.col_rid.MinWidth = 117
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 117
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
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 292
        '
        'col_total_cost
        '
        Me.col_total_cost.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_cost.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total_cost.Caption = "Total Cost"
        Me.col_total_cost.DisplayFormat.FormatString = "c2"
        Me.col_total_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_cost.FieldName = "total_cost"
        Me.col_total_cost.MaxWidth = 175
        Me.col_total_cost.MinWidth = 117
        Me.col_total_cost.Name = "col_total_cost"
        Me.col_total_cost.Visible = True
        Me.col_total_cost.VisibleIndex = 3
        Me.col_total_cost.Width = 117
        '
        'col_createdat
        '
        Me.col_createdat.AppearanceCell.Options.UseTextOptions = True
        Me.col_createdat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_createdat.AppearanceHeader.Options.UseTextOptions = True
        Me.col_createdat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_createdat.Caption = "Created At"
        Me.col_createdat.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_createdat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_createdat.FieldName = "created_at"
        Me.col_createdat.MaxWidth = 140
        Me.col_createdat.MinWidth = 140
        Me.col_createdat.Name = "col_createdat"
        Me.col_createdat.Visible = True
        Me.col_createdat.VisibleIndex = 4
        Me.col_createdat.Width = 140
        '
        'col_voucher
        '
        Me.col_voucher.AppearanceCell.Options.UseTextOptions = True
        Me.col_voucher.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_voucher.Caption = "Voucher"
        Me.col_voucher.FieldName = "voucher_id"
        Me.col_voucher.MaxWidth = 175
        Me.col_voucher.MinWidth = 23
        Me.col_voucher.Name = "col_voucher"
        Me.col_voucher.Visible = True
        Me.col_voucher.VisibleIndex = 5
        Me.col_voucher.Width = 87
        '
        'col_is_applied
        '
        Me.col_is_applied.Caption = "Applied"
        Me.col_is_applied.ColumnEdit = Me.cb_is_applied
        Me.col_is_applied.FieldName = "is_applied"
        Me.col_is_applied.MaxWidth = 93
        Me.col_is_applied.MinWidth = 23
        Me.col_is_applied.Name = "col_is_applied"
        Me.col_is_applied.OptionsColumn.ReadOnly = True
        Me.col_is_applied.Visible = True
        Me.col_is_applied.VisibleIndex = 6
        Me.col_is_applied.Width = 23
        '
        'cb_is_applied
        '
        Me.cb_is_applied.AutoHeight = False
        Me.cb_is_applied.Name = "cb_is_applied"
        Me.cb_is_applied.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'btn_new_return
        '
        Me.btn_new_return.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_return.Appearance.Options.UseFont = True
        Me.btn_new_return.Appearance.Options.UseTextOptions = True
        Me.btn_new_return.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new_return.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new_return.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newsales_32x32
        Me.btn_new_return.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_return.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_return.Location = New System.Drawing.Point(18, 71)
        Me.btn_new_return.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_new_return.Name = "btn_new_return"
        Me.btn_new_return.Size = New System.Drawing.Size(187, 57)
        Me.btn_new_return.TabIndex = 14
        Me.btn_new_return.Text = "New Credit Memo"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(186, 38)
        Me.LabelControl1.TabIndex = 131
        Me.LabelControl1.Text = "Credit Memo"
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_refresh.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_refresh.Location = New System.Drawing.Point(211, 71)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(187, 57)
        Me.btn_refresh.TabIndex = 132
        Me.btn_refresh.Text = "Refresh"
        '
        'cb_show_all
        '
        Me.cb_show_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_show_all.Location = New System.Drawing.Point(1227, 71)
        Me.cb_show_all.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_show_all.Name = "cb_show_all"
        Me.cb_show_all.Size = New System.Drawing.Size(187, 57)
        Me.cb_show_all.TabIndex = 133
        Me.cb_show_all.Text = "Show All"
        '
        'btn_pending_credits
        '
        Me.btn_pending_credits.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_pending_credits.Appearance.Options.UseFont = True
        Me.btn_pending_credits.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.insertheader_32x32
        Me.btn_pending_credits.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_pending_credits.ImageOptions.ImageToTextIndent = 5
        Me.btn_pending_credits.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_pending_credits.Location = New System.Drawing.Point(406, 71)
        Me.btn_pending_credits.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_pending_credits.Name = "btn_pending_credits"
        Me.btn_pending_credits.Size = New System.Drawing.Size(187, 57)
        Me.btn_pending_credits.TabIndex = 134
        Me.btn_pending_credits.Text = "Pending Credits"
        '
        'frm_purchasing_credit_memo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1428, 881)
        Me.Controls.Add(Me.btn_pending_credits)
        Me.Controls.Add(Me.cb_show_all)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_returns)
        Me.Controls.Add(Me.btn_new_return)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_purchasing_credit_memo"
        Me.Text = "Credit Memo"
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_is_applied, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_createdat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_new_return As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_voucher As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_is_applied As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cb_is_applied As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents cb_show_all As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btn_pending_credits As DevExpress.XtraEditors.SimpleButton
End Class
