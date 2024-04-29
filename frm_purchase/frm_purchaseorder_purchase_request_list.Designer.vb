<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchaseorder_purchase_request_list
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_purchase_request = New DevExpress.XtraGrid.GridControl()
        Me.grid_purchase_request_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pr_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pr_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pr_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pr_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pr_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pr_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pr_requested_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_done = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_date_requested = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_purchase_request, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_purchase_request_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_done, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_new
        '
        Me.btn_new.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Appearance.Options.UseFont = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 5
        Me.btn_new.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.adddatasource
        Me.btn_new.Location = New System.Drawing.Point(12, 58)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(160, 46)
        Me.btn_new.TabIndex = 11
        Me.btn_new.Text = "New Order"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(238, 31)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Purchase Requests"
        '
        'grid_purchase_request
        '
        Me.grid_purchase_request.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_purchase_request.Location = New System.Drawing.Point(-1, 110)
        Me.grid_purchase_request.MainView = Me.grid_purchase_request_view
        Me.grid_purchase_request.Name = "grid_purchase_request"
        Me.grid_purchase_request.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_done})
        Me.grid_purchase_request.Size = New System.Drawing.Size(1289, 613)
        Me.grid_purchase_request.TabIndex = 21
        Me.grid_purchase_request.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_purchase_request_view})
        '
        'grid_purchase_request_view
        '
        Me.grid_purchase_request_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_purchase_request_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_purchase_request_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_purchase_request_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_purchase_request_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_purchase_request_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_purchase_request_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_purchase_request_view.Appearance.Row.Options.UseFont = True
        Me.grid_purchase_request_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_purchase_request_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_purchase_request_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_purchase_request_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_purchase_request_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pr_id, Me.col_pr_qty, Me.col_pr_pid, Me.col_pr_model, Me.col_pr_description, Me.col_pr_supplier, Me.col_pr_requested_by, Me.col_date_requested, Me.col_action})
        Me.grid_purchase_request_view.GridControl = Me.grid_purchase_request
        Me.grid_purchase_request_view.Name = "grid_purchase_request_view"
        Me.grid_purchase_request_view.OptionsBehavior.ReadOnly = True
        Me.grid_purchase_request_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'col_pr_id
        '
        Me.col_pr_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_pr_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr_id.Caption = "ID"
        Me.col_pr_id.FieldName = "id"
        Me.col_pr_id.MaxWidth = 60
        Me.col_pr_id.MinWidth = 60
        Me.col_pr_id.Name = "col_pr_id"
        Me.col_pr_id.Visible = True
        Me.col_pr_id.VisibleIndex = 0
        Me.col_pr_id.Width = 60
        '
        'col_pr_qty
        '
        Me.col_pr_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_pr_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr_qty.Caption = "QTY."
        Me.col_pr_qty.FieldName = "qty"
        Me.col_pr_qty.Name = "col_pr_qty"
        Me.col_pr_qty.Visible = True
        Me.col_pr_qty.VisibleIndex = 1
        '
        'col_pr_pid
        '
        Me.col_pr_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pr_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr_pid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pr_pid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr_pid.Caption = "PID"
        Me.col_pr_pid.FieldName = "pid"
        Me.col_pr_pid.MaxWidth = 100
        Me.col_pr_pid.MinWidth = 100
        Me.col_pr_pid.Name = "col_pr_pid"
        Me.col_pr_pid.Visible = True
        Me.col_pr_pid.VisibleIndex = 2
        Me.col_pr_pid.Width = 100
        '
        'col_pr_model
        '
        Me.col_pr_model.AppearanceHeader.Options.UseTextOptions = True
        Me.col_pr_model.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pr_model.Caption = "Model"
        Me.col_pr_model.FieldName = "winmodel"
        Me.col_pr_model.MaxWidth = 180
        Me.col_pr_model.MinWidth = 180
        Me.col_pr_model.Name = "col_pr_model"
        Me.col_pr_model.Visible = True
        Me.col_pr_model.VisibleIndex = 3
        Me.col_pr_model.Width = 180
        '
        'col_pr_description
        '
        Me.col_pr_description.Caption = "Description"
        Me.col_pr_description.FieldName = "description"
        Me.col_pr_description.MinWidth = 10
        Me.col_pr_description.Name = "col_pr_description"
        Me.col_pr_description.Visible = True
        Me.col_pr_description.VisibleIndex = 4
        Me.col_pr_description.Width = 629
        '
        'col_pr_supplier
        '
        Me.col_pr_supplier.Caption = "Supplier"
        Me.col_pr_supplier.FieldName = "supplier"
        Me.col_pr_supplier.MaxWidth = 350
        Me.col_pr_supplier.MinWidth = 350
        Me.col_pr_supplier.Name = "col_pr_supplier"
        Me.col_pr_supplier.Visible = True
        Me.col_pr_supplier.VisibleIndex = 5
        Me.col_pr_supplier.Width = 350
        '
        'col_pr_requested_by
        '
        Me.col_pr_requested_by.Caption = "Requested by"
        Me.col_pr_requested_by.FieldName = "requested_by"
        Me.col_pr_requested_by.MinWidth = 180
        Me.col_pr_requested_by.Name = "col_pr_requested_by"
        Me.col_pr_requested_by.Visible = True
        Me.col_pr_requested_by.VisibleIndex = 6
        Me.col_pr_requested_by.Width = 180
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.btn_done
        Me.col_action.MaxWidth = 50
        Me.col_action.MinWidth = 50
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 8
        Me.col_action.Width = 50
        '
        'btn_done
        '
        Me.btn_done.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.check
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_done.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_done.Name = "btn_done"
        Me.btn_done.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_date_requested
        '
        Me.col_date_requested.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_requested.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_requested.Caption = "Date Requested"
        Me.col_date_requested.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.col_date_requested.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_requested.FieldName = "date_request"
        Me.col_date_requested.MaxWidth = 140
        Me.col_date_requested.MinWidth = 140
        Me.col_date_requested.Name = "col_date_requested"
        Me.col_date_requested.Visible = True
        Me.col_date_requested.VisibleIndex = 7
        Me.col_date_requested.Width = 140
        '
        'frm_purchaseorder_purchase_request_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 721)
        Me.Controls.Add(Me.grid_purchase_request)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_new)
        Me.Name = "frm_purchaseorder_purchase_request_list"
        Me.Text = "Purchase Requests"
        CType(Me.grid_purchase_request, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_purchase_request_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_done, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_purchase_request As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_purchase_request_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pr_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pr_requested_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_done As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_date_requested As DevExpress.XtraGrid.Columns.GridColumn
End Class
