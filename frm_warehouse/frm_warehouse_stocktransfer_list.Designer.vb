<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_list
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_new_stockTransfer = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_src_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cbm = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_kgs = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_linked_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.newTransfer_contextMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.stripMenu_distribute = New System.Windows.Forms.ToolStripMenuItem()
        Me.RequestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_show_completed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_completed = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_sub_transfer = New DevExpress.XtraGrid.GridControl()
        Me.grid_sub_transfer_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_cancel = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_root_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_driver = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.btn_pending = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_arrange = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.newTransfer_contextMenu.SuspendLayout()
        CType(Me.grid_sub_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sub_transfer_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_new_stockTransfer
        '
        Me.btn_new_stockTransfer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new_stockTransfer.Appearance.Options.UseFont = True
        Me.btn_new_stockTransfer.Appearance.Options.UseTextOptions = True
        Me.btn_new_stockTransfer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new_stockTransfer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new_stockTransfer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_stockTransfer.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_stockTransfer.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.shopping_delivery
        Me.btn_new_stockTransfer.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_new_stockTransfer.Location = New System.Drawing.Point(12, 58)
        Me.btn_new_stockTransfer.Name = "btn_new_stockTransfer"
        Me.btn_new_stockTransfer.Size = New System.Drawing.Size(160, 46)
        Me.btn_new_stockTransfer.TabIndex = 11
        Me.btn_new_stockTransfer.Text = "New Transfer"
        '
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers.Location = New System.Drawing.Point(9, 60)
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_stock_transfers.Size = New System.Drawing.Size(1152, 476)
        Me.grid_stock_transfers.TabIndex = 12
        Me.grid_stock_transfers.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_transfers_view})
        '
        'grid_stock_transfers_view
        '
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_transfers_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_transfers_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_transfers_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_stock_transfers_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_stock_transfers_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_stock_transfers_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_transfer_id, Me.col_src_warehouse, Me.col_transfer_type, Me.col_status, Me.col_created_by, Me.col_created_at, Me.col_total_cbm, Me.col_total_kgs, Me.col_linked_warehouse})
        Me.grid_stock_transfers_view.GridControl = Me.grid_stock_transfers
        Me.grid_stock_transfers_view.Name = "grid_stock_transfers_view"
        Me.grid_stock_transfers_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transfers_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
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
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.MaxWidth = 120
        Me.col_transfer_id.MinWidth = 70
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 1
        Me.col_transfer_id.Width = 70
        '
        'col_src_warehouse
        '
        Me.col_src_warehouse.AppearanceHeader.Options.UseTextOptions = True
        Me.col_src_warehouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_src_warehouse.Caption = "Source/Requesting Warehouse"
        Me.col_src_warehouse.FieldName = "src_warehouse"
        Me.col_src_warehouse.MaxWidth = 200
        Me.col_src_warehouse.MinWidth = 150
        Me.col_src_warehouse.Name = "col_src_warehouse"
        Me.col_src_warehouse.Visible = True
        Me.col_src_warehouse.VisibleIndex = 2
        Me.col_src_warehouse.Width = 150
        '
        'col_transfer_type
        '
        Me.col_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_type.Caption = "Transfer Type"
        Me.col_transfer_type.FieldName = "transfer_type"
        Me.col_transfer_type.MaxWidth = 130
        Me.col_transfer_type.MinWidth = 130
        Me.col_transfer_type.Name = "col_transfer_type"
        Me.col_transfer_type.Visible = True
        Me.col_transfer_type.VisibleIndex = 4
        Me.col_transfer_type.Width = 130
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 180
        Me.col_status.MinWidth = 100
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 5
        Me.col_status.Width = 100
        '
        'col_created_by
        '
        Me.col_created_by.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_by.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_by.AppearanceHeader.Options.UseTextOptions = True
        Me.col_created_by.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_by.Caption = "Created by"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.MaxWidth = 100
        Me.col_created_by.MinWidth = 100
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Visible = True
        Me.col_created_by.VisibleIndex = 6
        Me.col_created_by.Width = 100
        '
        'col_created_at
        '
        Me.col_created_at.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_at.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.AppearanceHeader.Options.UseTextOptions = True
        Me.col_created_at.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.Caption = "Date Created"
        Me.col_created_at.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_created_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_created_at.FieldName = "created_at"
        Me.col_created_at.MaxWidth = 120
        Me.col_created_at.MinWidth = 120
        Me.col_created_at.Name = "col_created_at"
        Me.col_created_at.Visible = True
        Me.col_created_at.VisibleIndex = 7
        Me.col_created_at.Width = 120
        '
        'col_total_cbm
        '
        Me.col_total_cbm.Caption = "Total mᶟ"
        Me.col_total_cbm.FieldName = "total_cbm"
        Me.col_total_cbm.MaxWidth = 80
        Me.col_total_cbm.Name = "col_total_cbm"
        Me.col_total_cbm.Visible = True
        Me.col_total_cbm.VisibleIndex = 8
        '
        'col_total_kgs
        '
        Me.col_total_kgs.Caption = "Total Kg"
        Me.col_total_kgs.FieldName = "total_kgs"
        Me.col_total_kgs.MaxWidth = 80
        Me.col_total_kgs.Name = "col_total_kgs"
        Me.col_total_kgs.Visible = True
        Me.col_total_kgs.VisibleIndex = 9
        Me.col_total_kgs.Width = 50
        '
        'col_linked_warehouse
        '
        Me.col_linked_warehouse.Caption = "Affected Warehouse"
        Me.col_linked_warehouse.FieldName = "linked_warehouse"
        Me.col_linked_warehouse.Name = "col_linked_warehouse"
        Me.col_linked_warehouse.Visible = True
        Me.col_linked_warehouse.VisibleIndex = 3
        '
        'newTransfer_contextMenu
        '
        Me.newTransfer_contextMenu.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.newTransfer_contextMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.stripMenu_distribute, Me.RequestToolStripMenuItem})
        Me.newTransfer_contextMenu.Name = "newTransfer_contextMenu"
        Me.newTransfer_contextMenu.Size = New System.Drawing.Size(135, 48)
        '
        'stripMenu_distribute
        '
        Me.stripMenu_distribute.Name = "stripMenu_distribute"
        Me.stripMenu_distribute.Size = New System.Drawing.Size(134, 22)
        Me.stripMenu_distribute.Text = "Distribute"
        '
        'RequestToolStripMenuItem
        '
        Me.RequestToolStripMenuItem.Name = "RequestToolStripMenuItem"
        Me.RequestToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.RequestToolStripMenuItem.Text = "Request"
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
        Me.btn_refresh.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_refresh.Location = New System.Drawing.Point(178, 58)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 14
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_show_completed
        '
        Me.btn_show_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_show_completed.Location = New System.Drawing.Point(1054, 20)
        Me.btn_show_completed.LookAndFeel.SkinName = "WXI"
        Me.btn_show_completed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_show_completed.Name = "btn_show_completed"
        Me.btn_show_completed.Size = New System.Drawing.Size(107, 31)
        Me.btn_show_completed.TabIndex = 14
        Me.btn_show_completed.Text = "View Completed"
        '
        'btn_completed
        '
        Me.btn_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_completed.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_completed.Appearance.Options.UseBackColor = True
        Me.btn_completed.Location = New System.Drawing.Point(996, 20)
        Me.btn_completed.LookAndFeel.SkinName = "WXI"
        Me.btn_completed.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_completed.Name = "btn_completed"
        Me.btn_completed.Size = New System.Drawing.Size(165, 31)
        Me.btn_completed.TabIndex = 15
        Me.btn_completed.Text = "View Completed / Cancelled"
        '
        'grid_sub_transfer
        '
        Me.grid_sub_transfer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_sub_transfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_sub_transfer.Location = New System.Drawing.Point(9, 60)
        Me.grid_sub_transfer.MainView = Me.grid_sub_transfer_view
        Me.grid_sub_transfer.Name = "grid_sub_transfer"
        Me.grid_sub_transfer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_cancel})
        Me.grid_sub_transfer.Size = New System.Drawing.Size(1152, 476)
        Me.grid_sub_transfer.TabIndex = 13
        Me.grid_sub_transfer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sub_transfer_view})
        '
        'grid_sub_transfer_view
        '
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_sub_transfer_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sub_transfer_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_sub_transfer_view.Appearance.Row.Options.UseFont = True
        Me.grid_sub_transfer_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_sub_transfer_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_sub_transfer_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_sub_transfer_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_sub_transfer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.col_root_transfer_id, Me.col_from, Me.col_sub_transfer_type, Me.col_sub_transfer_status, Me.col_sub_transfer_id, Me.col_driver, Me.col_to})
        Me.grid_sub_transfer_view.GridControl = Me.grid_sub_transfer
        Me.grid_sub_transfer_view.Name = "grid_sub_transfer_view"
        Me.grid_sub_transfer_view.OptionsBehavior.ReadOnly = True
        Me.grid_sub_transfer_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Action"
        Me.GridColumn1.ColumnEdit = Me.btn_cancel
        Me.GridColumn1.MaxWidth = 80
        Me.GridColumn1.MinWidth = 50
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 7
        Me.GridColumn1.Width = 80
        '
        'btn_cancel
        '
        Me.btn_cancel.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.cancel_16x16
        Me.btn_cancel.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_root_transfer_id
        '
        Me.col_root_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_root_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_root_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_root_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_root_transfer_id.Caption = "Root Transfer ID"
        Me.col_root_transfer_id.FieldName = "root_transfer_id"
        Me.col_root_transfer_id.MaxWidth = 120
        Me.col_root_transfer_id.MinWidth = 120
        Me.col_root_transfer_id.Name = "col_root_transfer_id"
        Me.col_root_transfer_id.Visible = True
        Me.col_root_transfer_id.VisibleIndex = 0
        Me.col_root_transfer_id.Width = 120
        '
        'col_from
        '
        Me.col_from.AppearanceHeader.Options.UseTextOptions = True
        Me.col_from.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_from.Caption = "FROM"
        Me.col_from.FieldName = "from_warehouse"
        Me.col_from.Name = "col_from"
        Me.col_from.Visible = True
        Me.col_from.VisibleIndex = 2
        Me.col_from.Width = 200
        '
        'col_sub_transfer_type
        '
        Me.col_sub_transfer_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_type.Caption = "Transfer Type"
        Me.col_sub_transfer_type.FieldName = "transfer_type"
        Me.col_sub_transfer_type.MaxWidth = 130
        Me.col_sub_transfer_type.MinWidth = 130
        Me.col_sub_transfer_type.Name = "col_sub_transfer_type"
        Me.col_sub_transfer_type.Visible = True
        Me.col_sub_transfer_type.VisibleIndex = 4
        Me.col_sub_transfer_type.Width = 130
        '
        'col_sub_transfer_status
        '
        Me.col_sub_transfer_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_transfer_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_status.Caption = "Status"
        Me.col_sub_transfer_status.FieldName = "status"
        Me.col_sub_transfer_status.MaxWidth = 180
        Me.col_sub_transfer_status.MinWidth = 100
        Me.col_sub_transfer_status.Name = "col_sub_transfer_status"
        Me.col_sub_transfer_status.Visible = True
        Me.col_sub_transfer_status.VisibleIndex = 5
        Me.col_sub_transfer_status.Width = 180
        '
        'col_sub_transfer_id
        '
        Me.col_sub_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sub_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_id.Caption = "Sub Transfer ID"
        Me.col_sub_transfer_id.FieldName = "sub_transfer_id"
        Me.col_sub_transfer_id.MaxWidth = 120
        Me.col_sub_transfer_id.MinWidth = 120
        Me.col_sub_transfer_id.Name = "col_sub_transfer_id"
        Me.col_sub_transfer_id.Visible = True
        Me.col_sub_transfer_id.VisibleIndex = 1
        Me.col_sub_transfer_id.Width = 120
        '
        'col_driver
        '
        Me.col_driver.AppearanceHeader.Options.UseTextOptions = True
        Me.col_driver.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_driver.Caption = "Driver"
        Me.col_driver.FieldName = "delivered_by"
        Me.col_driver.MaxWidth = 120
        Me.col_driver.MinWidth = 120
        Me.col_driver.Name = "col_driver"
        Me.col_driver.Visible = True
        Me.col_driver.VisibleIndex = 6
        Me.col_driver.Width = 120
        '
        'col_to
        '
        Me.col_to.Caption = "TO"
        Me.col_to.FieldName = "to_warehouse"
        Me.col_to.Name = "col_to"
        Me.col_to.Visible = True
        Me.col_to.VisibleIndex = 3
        Me.col_to.Width = 200
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
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Stock Transfer"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 110)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1172, 575)
        Me.XtraTabControl1.TabIndex = 21
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.SeparatorControl1)
        Me.XtraTabPage1.Controls.Add(Me.btn_pending)
        Me.XtraTabPage1.Controls.Add(Me.btn_approved)
        Me.XtraTabPage1.Controls.Add(Me.btn_arrange)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl2)
        Me.XtraTabPage1.Controls.Add(Me.btn_show_completed)
        Me.XtraTabPage1.Controls.Add(Me.grid_stock_transfers)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1170, 544)
        Me.XtraTabPage1.Text = "Stock Transfers"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.LineOrientation = System.Windows.Forms.Orientation.Vertical
        Me.SeparatorControl1.Location = New System.Drawing.Point(1026, 15)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Size = New System.Drawing.Size(22, 42)
        Me.SeparatorControl1.TabIndex = 22
        '
        'btn_pending
        '
        Me.btn_pending.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_pending.Location = New System.Drawing.Point(687, 20)
        Me.btn_pending.LookAndFeel.SkinName = "WXI"
        Me.btn_pending.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_pending.Name = "btn_pending"
        Me.btn_pending.Size = New System.Drawing.Size(107, 31)
        Me.btn_pending.TabIndex = 25
        Me.btn_pending.Text = "Pending (0)"
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Location = New System.Drawing.Point(800, 20)
        Me.btn_approved.LookAndFeel.SkinName = "WXI"
        Me.btn_approved.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(107, 31)
        Me.btn_approved.TabIndex = 24
        Me.btn_approved.Text = "Approved (0)"
        '
        'btn_arrange
        '
        Me.btn_arrange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_arrange.Location = New System.Drawing.Point(913, 20)
        Me.btn_arrange.LookAndFeel.SkinName = "WXI"
        Me.btn_arrange.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_arrange.Name = "btn_arrange"
        Me.btn_arrange.Size = New System.Drawing.Size(107, 31)
        Me.btn_arrange.TabIndex = 23
        Me.btn_arrange.Text = "Arranging (0)"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(9, 14)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(192, 31)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Stock Transfers"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.btn_completed)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.grid_sub_transfer)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1170, 544)
        Me.XtraTabPage2.Text = "Sub - Stock Transfers"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(9, 14)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(263, 31)
        Me.LabelControl3.TabIndex = 22
        Me.LabelControl3.Text = "Sub - Stock Transfers"
        '
        'frm_warehouse_stocktransfer_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1196, 697)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_new_stockTransfer)
        Me.Name = "frm_warehouse_stocktransfer_list"
        Me.Text = "Stock Transfer"
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.newTransfer_contextMenu.ResumeLayout(False)
        CType(Me.grid_sub_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sub_transfer_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_new_stockTransfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_stock_transfers As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transfers_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_src_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_created_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_created_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents newTransfer_contextMenu As ContextMenuStrip
    Friend WithEvents stripMenu_distribute As ToolStripMenuItem
    Friend WithEvents RequestToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_total_cbm As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_kgs As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_linked_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_sub_transfer As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_sub_transfer_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_root_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_from As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_transfer_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_driver As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_to As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_show_completed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_completed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_arrange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents btn_pending As DevExpress.XtraEditors.SimpleButton
End Class
