<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_return_list
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_new_return = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_createdat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_credit_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_credit_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.col_total_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_credited = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_pending = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.col_reference = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.btn_new_return.Location = New System.Drawing.Point(12, 58)
        Me.btn_new_return.Name = "btn_new_return"
        Me.btn_new_return.Size = New System.Drawing.Size(160, 46)
        Me.btn_new_return.TabIndex = 16
        Me.btn_new_return.Text = "New Return"
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_rid, Me.col_reference, Me.col_supplier, Me.col_createdat, Me.col_status, Me.col_warehouse, Me.col_amount, Me.col_created_by, Me.col_received_by, Me.col_customer_type, Me.col_credit_status, Me.col_credit_ref, Me.col_received_date})
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_returns_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_view_order
        Me.col_view.MaxWidth = 80
        Me.col_view.MinWidth = 50
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 50
        '
        'col_rid
        '
        Me.col_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_rid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.Caption = "Return ID"
        Me.col_rid.FieldName = "sales_return_id"
        Me.col_rid.MaxWidth = 100
        Me.col_rid.MinWidth = 100
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 100
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.col_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_supplier.Caption = "Customer"
        Me.col_supplier.FieldName = "customer"
        Me.col_supplier.MaxWidth = 250
        Me.col_supplier.MinWidth = 250
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 3
        Me.col_supplier.Width = 250
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
        Me.col_createdat.MaxWidth = 120
        Me.col_createdat.MinWidth = 120
        Me.col_createdat.Name = "col_createdat"
        Me.col_createdat.Visible = True
        Me.col_createdat.VisibleIndex = 10
        Me.col_createdat.Width = 120
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 150
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 6
        Me.col_status.Width = 20
        '
        'col_warehouse
        '
        Me.col_warehouse.Caption = "Warehouse"
        Me.col_warehouse.FieldName = "warehouse"
        Me.col_warehouse.MinWidth = 150
        Me.col_warehouse.Name = "col_warehouse"
        Me.col_warehouse.Visible = True
        Me.col_warehouse.VisibleIndex = 7
        Me.col_warehouse.Width = 150
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "n2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.MaxWidth = 150
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 5
        Me.col_amount.Width = 49
        '
        'col_created_by
        '
        Me.col_created_by.Caption = "Created By"
        Me.col_created_by.FieldName = "sales_coordinator"
        Me.col_created_by.MaxWidth = 250
        Me.col_created_by.MinWidth = 100
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Visible = True
        Me.col_created_by.VisibleIndex = 8
        Me.col_created_by.Width = 100
        '
        'col_received_by
        '
        Me.col_received_by.Caption = "Received by"
        Me.col_received_by.FieldName = "received_by"
        Me.col_received_by.MaxWidth = 250
        Me.col_received_by.MinWidth = 100
        Me.col_received_by.Name = "col_received_by"
        Me.col_received_by.Visible = True
        Me.col_received_by.VisibleIndex = 9
        Me.col_received_by.Width = 100
        '
        'col_customer_type
        '
        Me.col_customer_type.Caption = "Customer Type"
        Me.col_customer_type.FieldName = "account_type"
        Me.col_customer_type.MaxWidth = 150
        Me.col_customer_type.Name = "col_customer_type"
        Me.col_customer_type.Visible = True
        Me.col_customer_type.VisibleIndex = 4
        Me.col_customer_type.Width = 81
        '
        'col_credit_status
        '
        Me.col_credit_status.Caption = "Credit Status"
        Me.col_credit_status.FieldName = "credit_status"
        Me.col_credit_status.MinWidth = 120
        Me.col_credit_status.Name = "col_credit_status"
        Me.col_credit_status.Visible = True
        Me.col_credit_status.VisibleIndex = 12
        Me.col_credit_status.Width = 120
        '
        'col_credit_ref
        '
        Me.col_credit_ref.Caption = "Credit Ref."
        Me.col_credit_ref.FieldName = "credit_ref"
        Me.col_credit_ref.MinWidth = 100
        Me.col_credit_ref.Name = "col_credit_ref"
        Me.col_credit_ref.Visible = True
        Me.col_credit_ref.VisibleIndex = 13
        Me.col_credit_ref.Width = 100
        '
        'col_received_date
        '
        Me.col_received_date.Caption = "Received Date"
        Me.col_received_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_received_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_received_date.FieldName = "received_at"
        Me.col_received_date.MaxWidth = 120
        Me.col_received_date.MinWidth = 120
        Me.col_received_date.Name = "col_received_date"
        Me.col_received_date.Visible = True
        Me.col_received_date.VisibleIndex = 11
        Me.col_received_date.Width = 120
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns.Location = New System.Drawing.Point(-1, 110)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_returns.Size = New System.Drawing.Size(1477, 608)
        Me.grid_returns.TabIndex = 15
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'col_total_cost
        '
        Me.col_total_cost.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_cost.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total_cost.Caption = "Amount"
        Me.col_total_cost.DisplayFormat.FormatString = "c2"
        Me.col_total_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_cost.FieldName = "amount"
        Me.col_total_cost.MaxWidth = 150
        Me.col_total_cost.MinWidth = 100
        Me.col_total_cost.Name = "col_total_cost"
        Me.col_total_cost.Visible = True
        Me.col_total_cost.VisibleIndex = 3
        Me.col_total_cost.Width = 100
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(12, 12)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(171, 31)
        Me.lbl_title.TabIndex = 17
        Me.lbl_title.Text = "Sales Returns"
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_refresh.Location = New System.Drawing.Point(178, 58)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 18
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_credited
        '
        Me.btn_credited.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_credited.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_credited.Appearance.Options.UseFont = True
        Me.btn_credited.Appearance.Options.UseTextOptions = True
        Me.btn_credited.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_credited.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_credited.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_credited.ImageOptions.ImageToTextIndent = 5
        Me.btn_credited.Location = New System.Drawing.Point(1348, 58)
        Me.btn_credited.Name = "btn_credited"
        Me.btn_credited.Size = New System.Drawing.Size(112, 46)
        Me.btn_credited.TabIndex = 19
        Me.btn_credited.Text = "Credited"
        '
        'btn_pending
        '
        Me.btn_pending.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pending.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_pending.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pending.Appearance.Options.UseBackColor = True
        Me.btn_pending.Appearance.Options.UseFont = True
        Me.btn_pending.Appearance.Options.UseTextOptions = True
        Me.btn_pending.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_pending.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_pending.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_pending.ImageOptions.ImageToTextIndent = 5
        Me.btn_pending.Location = New System.Drawing.Point(1230, 58)
        Me.btn_pending.Name = "btn_pending"
        Me.btn_pending.Size = New System.Drawing.Size(112, 46)
        Me.btn_pending.TabIndex = 20
        Me.btn_pending.Text = "Pending"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(1182, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 20)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Filter:"
        '
        'col_reference
        '
        Me.col_reference.Caption = "Reference"
        Me.col_reference.FieldName = "reference"
        Me.col_reference.MaxWidth = 100
        Me.col_reference.MinWidth = 100
        Me.col_reference.Name = "col_reference"
        Me.col_reference.Visible = True
        Me.col_reference.VisibleIndex = 2
        Me.col_reference.Width = 100
        '
        'frm_sales_return_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1472, 716)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_pending)
        Me.Controls.Add(Me.btn_credited)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_new_return)
        Me.Controls.Add(Me.grid_returns)
        Me.Name = "frm_sales_return_list"
        Me.Text = "Sales Returns"
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_new_return As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_createdat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents col_total_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_created_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_title As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_customer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_credit_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_credit_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_credited As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_pending As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_reference As DevExpress.XtraGrid.Columns.GridColumn
End Class
