<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_stock_reconcile_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_reconcile_list))
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_completed = New System.Windows.Forms.LinkLabel()
        Me.btn_completed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_request_transfer = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stock_transferred = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transferred_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_store = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_item = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_stock_transferred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transferred_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.Location = New System.Drawing.Point(948, 58)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 17
        Me.btn_refresh.Text = "Refresh"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 644)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Load:"
        '
        'lbl_completed
        '
        Me.lbl_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_completed.AutoSize = True
        Me.lbl_completed.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_completed.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_completed.Location = New System.Drawing.Point(56, 644)
        Me.lbl_completed.Name = "lbl_completed"
        Me.lbl_completed.Size = New System.Drawing.Size(68, 15)
        Me.lbl_completed.TabIndex = 24
        Me.lbl_completed.TabStop = True
        Me.lbl_completed.Text = "Completed"
        '
        'btn_completed
        '
        Me.btn_completed.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_completed.Appearance.Options.UseFont = True
        Me.btn_completed.Appearance.Options.UseTextOptions = True
        Me.btn_completed.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_completed.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_completed.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x32
        Me.btn_completed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_completed.ImageOptions.ImageToTextIndent = 5
        Me.btn_completed.Location = New System.Drawing.Point(178, 58)
        Me.btn_completed.Name = "btn_completed"
        Me.btn_completed.Size = New System.Drawing.Size(171, 46)
        Me.btn_completed.TabIndex = 20
        Me.btn_completed.Text = "Mark as Completed"
        '
        'btn_request_transfer
        '
        Me.btn_request_transfer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_request_transfer.Appearance.Options.UseFont = True
        Me.btn_request_transfer.Appearance.Options.UseTextOptions = True
        Me.btn_request_transfer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_request_transfer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_request_transfer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newtask_32x321
        Me.btn_request_transfer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_request_transfer.ImageOptions.ImageToTextIndent = 5
        Me.btn_request_transfer.Location = New System.Drawing.Point(12, 58)
        Me.btn_request_transfer.Name = "btn_request_transfer"
        Me.btn_request_transfer.Size = New System.Drawing.Size(160, 46)
        Me.btn_request_transfer.TabIndex = 14
        Me.btn_request_transfer.Text = "New Reconcile"
        '
        'grid_stock_transferred
        '
        Me.grid_stock_transferred.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transferred.Location = New System.Drawing.Point(-1, 110)
        Me.grid_stock_transferred.MainView = Me.grid_stock_transferred_view
        Me.grid_stock_transferred.Name = "grid_stock_transferred"
        Me.grid_stock_transferred.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_delete})
        Me.grid_stock_transferred.Size = New System.Drawing.Size(1123, 529)
        Me.grid_stock_transferred.TabIndex = 13
        Me.grid_stock_transferred.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_transferred_view})
        '
        'grid_stock_transferred_view
        '
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_transferred_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transferred_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_transferred_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_status, Me.col_store, Me.col_item, Me.col_delete, Me.col_qty, Me.col_type})
        Me.grid_stock_transferred_view.GridControl = Me.grid_stock_transferred
        Me.grid_stock_transferred_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_stock_transferred_view.Name = "grid_stock_transferred_view"
        Me.grid_stock_transferred_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transferred_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_stock_transferred_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_stock_transferred_view.OptionsView.ColumnAutoWidth = False
        Me.grid_stock_transferred_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 103
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 5
        Me.col_status.Width = 93
        '
        'col_store
        '
        Me.col_store.Caption = "Store / Warehouse"
        Me.col_store.FieldName = "store_name"
        Me.col_store.Name = "col_store"
        Me.col_store.Visible = True
        Me.col_store.VisibleIndex = 4
        Me.col_store.Width = 238
        '
        'col_item
        '
        Me.col_item.Caption = "Item"
        Me.col_item.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_item.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_item.FieldName = "winmodel"
        Me.col_item.Name = "col_item"
        Me.col_item.Visible = True
        Me.col_item.VisibleIndex = 3
        Me.col_item.Width = 159
        '
        'col_delete
        '
        Me.col_delete.Caption = "Delete"
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 6
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        EditorButtonImageOptions2.Image = CType(resources.GetObject("EditorButtonImageOptions2.Image"), System.Drawing.Image)
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_qty
        '
        Me.col_qty.Caption = "Quantity"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 2
        '
        'col_type
        '
        Me.col_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "reconciled_type"
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 1
        Me.col_type.Width = 85
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(178, 31)
        Me.LabelControl1.TabIndex = 75
        Me.LabelControl1.Text = "Reconcilations"
        '
        'frm_warehouse_stock_reconcile_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1120, 666)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_completed)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_stock_transferred)
        Me.Controls.Add(Me.btn_completed)
        Me.Controls.Add(Me.btn_request_transfer)
        Me.Controls.Add(Me.btn_refresh)
        Me.Name = "frm_warehouse_stock_reconcile_list"
        Me.Text = "Reconcilations"
        CType(Me.grid_stock_transferred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transferred_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_request_transfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_stock_transferred As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transferred_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_store As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_item As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_completed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_completed As LinkLabel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
