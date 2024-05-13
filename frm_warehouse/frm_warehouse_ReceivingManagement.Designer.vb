Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_receivingManagement
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.lbl_ClicktoView_1 = New System.Windows.Forms.Label()
        Me.grid_delivery = New DevExpress.XtraGrid.GridControl()
        Me.grid_delivery_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_lead_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_src_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_linked_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SearchControl1 = New DevExpress.XtraEditors.SearchControl()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.panel_supplierDeliveries = New DevExpress.XtraEditors.PanelControl()
        Me.panel_stockTransfers = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_ClicktoView_2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SearchControl3 = New DevExpress.XtraEditors.SearchControl()
        Me.grid_sales_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_sales_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_srid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_returns_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sales_return_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_srid = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_created_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panel_sales_return = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_sales_return = New System.Windows.Forms.Label()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.tab_control = New DevExpress.XtraTab.XtraTabControl()
        Me.tab_supplier_deliveries = New DevExpress.XtraTab.XtraTabPage()
        Me.tab_sales_return = New DevExpress.XtraTab.XtraTabPage()
        Me.tab_stock_transfers = New DevExpress.XtraTab.XtraTabPage()
        Me.tab_stock_returns = New DevExpress.XtraTab.XtraTabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_received = New DevExpress.XtraEditors.DateEdit()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stock_return = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_return_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_stock_return_delete_row = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete_row = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_serials = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received_resolved_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_resolved_type = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.col_received_credit_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_current_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_remaining_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_serial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_request_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_issue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_pullout = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_stockreturns_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_reference_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_tagetWarehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_delivery, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_delivery_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_supplierDeliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_supplierDeliveries.SuspendLayout()
        CType(Me.panel_stockTransfers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_stockTransfers.SuspendLayout()
        CType(Me.SearchControl3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_srid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_sales_return, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_sales_return.SuspendLayout()
        CType(Me.tab_control, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_control.SuspendLayout()
        Me.tab_supplier_deliveries.SuspendLayout()
        Me.tab_sales_return.SuspendLayout()
        Me.tab_stock_transfers.SuspendLayout()
        Me.tab_stock_returns.SuspendLayout()
        CType(Me.dt_received.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_received.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_return_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete_row, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_resolved_type, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_reference_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_tagetWarehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'lbl_ClicktoView_1
        '
        Me.lbl_ClicktoView_1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ClicktoView_1.AutoSize = True
        Me.lbl_ClicktoView_1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClicktoView_1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbl_ClicktoView_1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_ClicktoView_1.Location = New System.Drawing.Point(328, 299)
        Me.lbl_ClicktoView_1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ClicktoView_1.Name = "lbl_ClicktoView_1"
        Me.lbl_ClicktoView_1.Size = New System.Drawing.Size(257, 29)
        Me.lbl_ClicktoView_1.TabIndex = 0
        Me.lbl_ClicktoView_1.Text = "Click Deliveries to View"
        '
        'grid_delivery
        '
        Me.grid_delivery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_delivery.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_delivery.Location = New System.Drawing.Point(5, 80)
        Me.grid_delivery.MainView = Me.grid_delivery_view
        Me.grid_delivery.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_delivery.Name = "grid_delivery"
        Me.grid_delivery.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view})
        Me.grid_delivery.Size = New System.Drawing.Size(613, 682)
        Me.grid_delivery.TabIndex = 1
        Me.grid_delivery.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_delivery_view})
        '
        'grid_delivery_view
        '
        Me.grid_delivery_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grid_delivery_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_delivery_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_delivery_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_delivery_view.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.grid_delivery_view.Appearance.Row.Options.UseFont = True
        Me.grid_delivery_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_lead_time, Me.col_purchase_id, Me.col_supplier, Me.col_status, Me.col_action})
        Me.grid_delivery_view.DetailHeight = 431
        Me.grid_delivery_view.GridControl = Me.grid_delivery
        Me.grid_delivery_view.Name = "grid_delivery_view"
        Me.grid_delivery_view.OptionsBehavior.ReadOnly = True
        Me.grid_delivery_view.OptionsView.ShowGroupPanel = False
        Me.grid_delivery_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_lead_time
        '
        Me.col_lead_time.Caption = "EDD"
        Me.col_lead_time.DisplayFormat.FormatString = "dd MMM"
        Me.col_lead_time.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_lead_time.FieldName = "lead_time"
        Me.col_lead_time.MaxWidth = 82
        Me.col_lead_time.MinWidth = 23
        Me.col_lead_time.Name = "col_lead_time"
        Me.col_lead_time.OptionsColumn.AllowEdit = False
        Me.col_lead_time.Visible = True
        Me.col_lead_time.VisibleIndex = 1
        Me.col_lead_time.Width = 69
        '
        'col_purchase_id
        '
        Me.col_purchase_id.Caption = "Purchase ID"
        Me.col_purchase_id.FieldName = "poid"
        Me.col_purchase_id.MaxWidth = 105
        Me.col_purchase_id.MinWidth = 23
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 2
        Me.col_purchase_id.Width = 105
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceCell.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Italic)
        Me.col_supplier.AppearanceCell.Options.UseFont = True
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 23
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 3
        Me.col_supplier.Width = 230
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "lead_time_status"
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Width = 87
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.btn_view
        Me.col_action.MinWidth = 23
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 44
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_stock_transfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers.Location = New System.Drawing.Point(4, 64)
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.Size = New System.Drawing.Size(762, 682)
        Me.grid_stock_transfers.TabIndex = 13
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
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_transfer_id, Me.col_transfer_type, Me.col_src_warehouse, Me.col_linked_warehouse, Me.GridColumn1})
        Me.grid_stock_transfers_view.DetailHeight = 431
        Me.grid_stock_transfers_view.GridControl = Me.grid_stock_transfers
        Me.grid_stock_transfers_view.Name = "grid_stock_transfers_view"
        Me.grid_stock_transfers_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transfers_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_stock_transfers_view.OptionsView.ShowGroupPanel = False
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
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Sub Transfer ID"
        Me.col_transfer_id.FieldName = "sub_transfer_id"
        Me.col_transfer_id.MaxWidth = 128
        Me.col_transfer_id.MinWidth = 128
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 1
        Me.col_transfer_id.Width = 128
        '
        'col_transfer_type
        '
        Me.col_transfer_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_type.Caption = "Transfer Type"
        Me.col_transfer_type.FieldName = "transfer_type"
        Me.col_transfer_type.MaxWidth = 140
        Me.col_transfer_type.MinWidth = 140
        Me.col_transfer_type.Name = "col_transfer_type"
        Me.col_transfer_type.Visible = True
        Me.col_transfer_type.VisibleIndex = 2
        Me.col_transfer_type.Width = 140
        '
        'col_src_warehouse
        '
        Me.col_src_warehouse.AppearanceHeader.Options.UseTextOptions = True
        Me.col_src_warehouse.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_src_warehouse.Caption = "FROM"
        Me.col_src_warehouse.FieldName = "src_warehouse"
        Me.col_src_warehouse.MinWidth = 233
        Me.col_src_warehouse.Name = "col_src_warehouse"
        Me.col_src_warehouse.Visible = True
        Me.col_src_warehouse.VisibleIndex = 3
        Me.col_src_warehouse.Width = 233
        '
        'col_linked_warehouse
        '
        Me.col_linked_warehouse.Caption = "TO"
        Me.col_linked_warehouse.FieldName = "recvr_warehouse"
        Me.col_linked_warehouse.MinWidth = 292
        Me.col_linked_warehouse.Name = "col_linked_warehouse"
        Me.col_linked_warehouse.Visible = True
        Me.col_linked_warehouse.VisibleIndex = 4
        Me.col_linked_warehouse.Width = 292
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Status"
        Me.GridColumn1.FieldName = "status"
        Me.GridColumn1.MaxWidth = 117
        Me.GridColumn1.MinWidth = 117
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Width = 117
        '
        'SearchControl1
        '
        Me.SearchControl1.Client = Me.grid_delivery
        Me.SearchControl1.Location = New System.Drawing.Point(423, 38)
        Me.SearchControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchControl1.Name = "SearchControl1"
        Me.SearchControl1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl1.Properties.Client = Me.grid_delivery
        Me.SearchControl1.Properties.NullValuePrompt = "Search"
        Me.SearchControl1.Size = New System.Drawing.Size(195, 34)
        Me.SearchControl1.TabIndex = 84
        Me.SearchControl1.ToolTipTitle = "Search"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(7, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(232, 33)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "Supplier Deliveries"
        '
        'panel_supplierDeliveries
        '
        Me.panel_supplierDeliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_supplierDeliveries.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_supplierDeliveries.Appearance.Options.UseBackColor = True
        Me.panel_supplierDeliveries.Controls.Add(Me.lbl_ClicktoView_1)
        Me.panel_supplierDeliveries.Location = New System.Drawing.Point(625, 79)
        Me.panel_supplierDeliveries.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_supplierDeliveries.Name = "panel_supplierDeliveries"
        Me.panel_supplierDeliveries.Size = New System.Drawing.Size(817, 683)
        Me.panel_supplierDeliveries.TabIndex = 83
        '
        'panel_stockTransfers
        '
        Me.panel_stockTransfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_stockTransfers.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_stockTransfers.Appearance.Options.UseBackColor = True
        Me.panel_stockTransfers.Controls.Add(Me.lbl_ClicktoView_2)
        Me.panel_stockTransfers.Location = New System.Drawing.Point(772, 64)
        Me.panel_stockTransfers.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_stockTransfers.Name = "panel_stockTransfers"
        Me.panel_stockTransfers.Size = New System.Drawing.Size(670, 697)
        Me.panel_stockTransfers.TabIndex = 84
        '
        'lbl_ClicktoView_2
        '
        Me.lbl_ClicktoView_2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_ClicktoView_2.AutoSize = True
        Me.lbl_ClicktoView_2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ClicktoView_2.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbl_ClicktoView_2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_ClicktoView_2.Location = New System.Drawing.Point(229, 318)
        Me.lbl_ClicktoView_2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ClicktoView_2.Name = "lbl_ClicktoView_2"
        Me.lbl_ClicktoView_2.Size = New System.Drawing.Size(321, 29)
        Me.lbl_ClicktoView_2.TabIndex = 0
        Me.lbl_ClicktoView_2.Text = "Click Stock Transfers to View"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(5, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 33)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Stock Tranfers"
        '
        'SearchControl3
        '
        Me.SearchControl3.Client = Me.grid_sales_returns
        Me.SearchControl3.Location = New System.Drawing.Point(420, 38)
        Me.SearchControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.SearchControl3.Name = "SearchControl3"
        Me.SearchControl3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.SearchControl3.Properties.Client = Me.grid_sales_returns
        Me.SearchControl3.Properties.NullValuePrompt = "Search"
        Me.SearchControl3.Size = New System.Drawing.Size(198, 34)
        Me.SearchControl3.TabIndex = 86
        Me.SearchControl3.ToolTipTitle = "Search"
        '
        'grid_sales_returns
        '
        Me.grid_sales_returns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_sales_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_sales_returns.Location = New System.Drawing.Point(5, 80)
        Me.grid_sales_returns.MainView = Me.grid_sales_returns_view
        Me.grid_sales_returns.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_sales_returns.Name = "grid_sales_returns"
        Me.grid_sales_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_srid})
        Me.grid_sales_returns.Size = New System.Drawing.Size(613, 682)
        Me.grid_sales_returns.TabIndex = 2
        Me.grid_sales_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_sales_returns_view})
        '
        'grid_sales_returns_view
        '
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_sales_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_sales_returns_view.Appearance.Row.Font = New System.Drawing.Font("Arial", 9.5!)
        Me.grid_sales_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_sales_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_srid, Me.col_returns_date, Me.col_customer, Me.col_sales_return_action, Me.col_created_by, Me.col_warehouse})
        Me.grid_sales_returns_view.DetailHeight = 431
        Me.grid_sales_returns_view.GridControl = Me.grid_sales_returns
        Me.grid_sales_returns_view.Name = "grid_sales_returns_view"
        Me.grid_sales_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_sales_returns_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_srid
        '
        Me.col_srid.AppearanceCell.Options.UseTextOptions = True
        Me.col_srid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.Caption = "SRID"
        Me.col_srid.DisplayFormat.FormatString = "dd MMM"
        Me.col_srid.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_srid.FieldName = "srid"
        Me.col_srid.MaxWidth = 82
        Me.col_srid.MinWidth = 23
        Me.col_srid.Name = "col_srid"
        Me.col_srid.OptionsColumn.AllowEdit = False
        Me.col_srid.Visible = True
        Me.col_srid.VisibleIndex = 1
        Me.col_srid.Width = 82
        '
        'col_returns_date
        '
        Me.col_returns_date.Caption = "Date"
        Me.col_returns_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_returns_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_returns_date.FieldName = "created_at"
        Me.col_returns_date.MinWidth = 23
        Me.col_returns_date.Name = "col_returns_date"
        Me.col_returns_date.Visible = True
        Me.col_returns_date.VisibleIndex = 2
        Me.col_returns_date.Width = 117
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.MinWidth = 23
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 3
        Me.col_customer.Width = 203
        '
        'col_sales_return_action
        '
        Me.col_sales_return_action.ColumnEdit = Me.btn_view_srid
        Me.col_sales_return_action.MaxWidth = 47
        Me.col_sales_return_action.MinWidth = 23
        Me.col_sales_return_action.Name = "col_sales_return_action"
        Me.col_sales_return_action.Visible = True
        Me.col_sales_return_action.VisibleIndex = 0
        Me.col_sales_return_action.Width = 47
        '
        'btn_view_srid
        '
        Me.btn_view_srid.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_view_srid.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_srid.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_srid.Name = "btn_view_srid"
        Me.btn_view_srid.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_created_by
        '
        Me.col_created_by.Caption = "Created_by"
        Me.col_created_by.FieldName = "created_by"
        Me.col_created_by.MinWidth = 23
        Me.col_created_by.Name = "col_created_by"
        Me.col_created_by.Width = 87
        '
        'col_warehouse
        '
        Me.col_warehouse.Caption = "Submit to"
        Me.col_warehouse.FieldName = "store_name"
        Me.col_warehouse.MinWidth = 23
        Me.col_warehouse.Name = "col_warehouse"
        Me.col_warehouse.Width = 87
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 20)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(176, 33)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Sales Returns"
        Me.Label4.UseMnemonic = False
        '
        'panel_sales_return
        '
        Me.panel_sales_return.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_sales_return.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_sales_return.Appearance.Options.UseBackColor = True
        Me.panel_sales_return.Controls.Add(Me.lbl_sales_return)
        Me.panel_sales_return.Location = New System.Drawing.Point(625, 79)
        Me.panel_sales_return.Margin = New System.Windows.Forms.Padding(4)
        Me.panel_sales_return.Name = "panel_sales_return"
        Me.panel_sales_return.Size = New System.Drawing.Size(817, 683)
        Me.panel_sales_return.TabIndex = 84
        '
        'lbl_sales_return
        '
        Me.lbl_sales_return.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lbl_sales_return.AutoSize = True
        Me.lbl_sales_return.BackColor = System.Drawing.Color.Transparent
        Me.lbl_sales_return.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.lbl_sales_return.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lbl_sales_return.Location = New System.Drawing.Point(311, 331)
        Me.lbl_sales_return.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_sales_return.Name = "lbl_sales_return"
        Me.lbl_sales_return.Size = New System.Drawing.Size(289, 29)
        Me.lbl_sales_return.TabIndex = 0
        Me.lbl_sales_return.Text = "Click Sales Return to View"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(342, 38)
        Me.LabelControl2.TabIndex = 75
        Me.LabelControl2.Text = "Receiving Management"
        '
        'tab_control
        '
        Me.tab_control.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_control.AppearancePage.Header.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tab_control.AppearancePage.Header.Options.UseFont = True
        Me.tab_control.Location = New System.Drawing.Point(14, 80)
        Me.tab_control.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_control.Name = "tab_control"
        Me.tab_control.SelectedTabPage = Me.tab_supplier_deliveries
        Me.tab_control.Size = New System.Drawing.Size(1448, 804)
        Me.tab_control.TabIndex = 76
        Me.tab_control.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab_sales_return, Me.tab_supplier_deliveries, Me.tab_stock_transfers, Me.tab_stock_returns})
        '
        'tab_supplier_deliveries
        '
        Me.tab_supplier_deliveries.Controls.Add(Me.panel_supplierDeliveries)
        Me.tab_supplier_deliveries.Controls.Add(Me.grid_delivery)
        Me.tab_supplier_deliveries.Controls.Add(Me.SearchControl1)
        Me.tab_supplier_deliveries.Controls.Add(Me.Label2)
        Me.tab_supplier_deliveries.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_supplier_deliveries.Name = "tab_supplier_deliveries"
        Me.tab_supplier_deliveries.Size = New System.Drawing.Size(1446, 766)
        Me.tab_supplier_deliveries.Text = "Supplier Deliveries"
        '
        'tab_sales_return
        '
        Me.tab_sales_return.Controls.Add(Me.panel_sales_return)
        Me.tab_sales_return.Controls.Add(Me.SearchControl3)
        Me.tab_sales_return.Controls.Add(Me.grid_sales_returns)
        Me.tab_sales_return.Controls.Add(Me.Label4)
        Me.tab_sales_return.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_sales_return.Name = "tab_sales_return"
        Me.tab_sales_return.Size = New System.Drawing.Size(1446, 766)
        Me.tab_sales_return.Text = "Sales Returns"
        '
        'tab_stock_transfers
        '
        Me.tab_stock_transfers.Controls.Add(Me.Label3)
        Me.tab_stock_transfers.Controls.Add(Me.panel_stockTransfers)
        Me.tab_stock_transfers.Controls.Add(Me.grid_stock_transfers)
        Me.tab_stock_transfers.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_stock_transfers.Name = "tab_stock_transfers"
        Me.tab_stock_transfers.Size = New System.Drawing.Size(1446, 766)
        Me.tab_stock_transfers.Text = "Stock Transfers"
        '
        'tab_stock_returns
        '
        Me.tab_stock_returns.Controls.Add(Me.Label1)
        Me.tab_stock_returns.Controls.Add(Me.dt_received)
        Me.tab_stock_returns.Controls.Add(Me.cbb_supplier)
        Me.tab_stock_returns.Controls.Add(Me.btn_add)
        Me.tab_stock_returns.Controls.Add(Me.grid_stock_return)
        Me.tab_stock_returns.Controls.Add(Me.btn_submit)
        Me.tab_stock_returns.Controls.Add(Me.LabelControl20)
        Me.tab_stock_returns.Controls.Add(Me.txt_reference_no)
        Me.tab_stock_returns.Controls.Add(Me.LabelControl19)
        Me.tab_stock_returns.Controls.Add(Me.cbb_tagetWarehouse)
        Me.tab_stock_returns.Controls.Add(Me.LabelControl18)
        Me.tab_stock_returns.Controls.Add(Me.LabelControl5)
        Me.tab_stock_returns.Margin = New System.Windows.Forms.Padding(4)
        Me.tab_stock_returns.Name = "tab_stock_returns"
        Me.tab_stock_returns.Size = New System.Drawing.Size(1446, 766)
        Me.tab_stock_returns.Text = "Return to Vendor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 33)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "Return to Vendor"
        '
        'dt_received
        '
        Me.dt_received.EditValue = Nothing
        Me.dt_received.Location = New System.Drawing.Point(156, 159)
        Me.dt_received.Margin = New System.Windows.Forms.Padding(4)
        Me.dt_received.Name = "dt_received"
        Me.dt_received.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_received.Properties.Appearance.Options.UseFont = True
        Me.dt_received.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_received.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_received.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_received.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_received.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_received.Size = New System.Drawing.Size(183, 34)
        Me.dt_received.TabIndex = 32
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(156, 75)
        Me.cbb_supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(322, 34)
        Me.cbb_supplier.TabIndex = 31
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_add.Appearance.Options.UseBackColor = True
        Me.btn_add.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_add.Location = New System.Drawing.Point(5, 729)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(108, 32)
        Me.btn_add.TabIndex = 30
        Me.btn_add.Text = "+ Add"
        '
        'grid_stock_return
        '
        Me.grid_stock_return.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_return.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_stock_return.Location = New System.Drawing.Point(5, 218)
        Me.grid_stock_return.MainView = Me.grid_stock_return_view
        Me.grid_stock_return.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_stock_return.Name = "grid_stock_return"
        Me.grid_stock_return.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbb_resolved_type, Me.btn_delete_row})
        Me.grid_stock_return.Size = New System.Drawing.Size(1437, 503)
        Me.grid_stock_return.TabIndex = 29
        Me.grid_stock_return.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_return_view})
        '
        'grid_stock_return_view
        '
        Me.grid_stock_return_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_stock_return_delete_row, Me.col_rid, Me.col_received_qty, Me.col_received_serials, Me.col_received_remarks, Me.col_received_resolved_type, Me.col_received_credit_cost, Me.col_current_cost, Me.col_total_qty, Me.col_remaining_qty, Me.col_pid, Me.col_supmodel, Me.col_winmodel, Me.col_unit, Me.col_description, Me.col_serial, Me.col_request_type, Me.col_issue, Me.col_date_pullout, Me.col_stockreturns_warehouse})
        Me.grid_stock_return_view.DetailHeight = 431
        Me.grid_stock_return_view.GridControl = Me.grid_stock_return
        Me.grid_stock_return_view.Name = "grid_stock_return_view"
        Me.grid_stock_return_view.OptionsSelection.EnableAppearanceFocusedRow = False
        Me.grid_stock_return_view.OptionsView.ColumnAutoWidth = False
        '
        'col_stock_return_delete_row
        '
        Me.col_stock_return_delete_row.ColumnEdit = Me.btn_delete_row
        Me.col_stock_return_delete_row.MaxWidth = 47
        Me.col_stock_return_delete_row.MinWidth = 23
        Me.col_stock_return_delete_row.Name = "col_stock_return_delete_row"
        Me.col_stock_return_delete_row.Visible = True
        Me.col_stock_return_delete_row.VisibleIndex = 0
        Me.col_stock_return_delete_row.Width = 47
        '
        'btn_delete_row
        '
        Me.btn_delete_row.AutoHeight = False
        EditorButtonImageOptions4.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_removecircled
        EditorButtonImageOptions4.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_delete_row.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete_row.Name = "btn_delete_row"
        Me.btn_delete_row.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_rid
        '
        Me.col_rid.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_rid.AppearanceCell.Options.UseBackColor = True
        Me.col_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.Caption = "RID"
        Me.col_rid.FieldName = "rid"
        Me.col_rid.MinWidth = 23
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 66
        '
        'col_received_qty
        '
        Me.col_received_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_received_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_received_qty.Caption = "QTY. Received"
        Me.col_received_qty.FieldName = "received_qty"
        Me.col_received_qty.MinWidth = 23
        Me.col_received_qty.Name = "col_received_qty"
        Me.col_received_qty.Visible = True
        Me.col_received_qty.VisibleIndex = 2
        Me.col_received_qty.Width = 66
        '
        'col_received_serials
        '
        Me.col_received_serials.Caption = "Serials"
        Me.col_received_serials.FieldName = "received_serials"
        Me.col_received_serials.MinWidth = 23
        Me.col_received_serials.Name = "col_received_serials"
        Me.col_received_serials.Visible = True
        Me.col_received_serials.VisibleIndex = 3
        Me.col_received_serials.Width = 66
        '
        'col_received_remarks
        '
        Me.col_received_remarks.Caption = "Remarks"
        Me.col_received_remarks.FieldName = "received_remarks"
        Me.col_received_remarks.MinWidth = 23
        Me.col_received_remarks.Name = "col_received_remarks"
        Me.col_received_remarks.Visible = True
        Me.col_received_remarks.VisibleIndex = 4
        Me.col_received_remarks.Width = 66
        '
        'col_received_resolved_type
        '
        Me.col_received_resolved_type.Caption = "Resolve Type"
        Me.col_received_resolved_type.ColumnEdit = Me.cbb_resolved_type
        Me.col_received_resolved_type.FieldName = "received_resolved_type"
        Me.col_received_resolved_type.MinWidth = 23
        Me.col_received_resolved_type.Name = "col_received_resolved_type"
        Me.col_received_resolved_type.Visible = True
        Me.col_received_resolved_type.VisibleIndex = 5
        Me.col_received_resolved_type.Width = 66
        '
        'cbb_resolved_type
        '
        Me.cbb_resolved_type.AutoHeight = False
        Me.cbb_resolved_type.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_resolved_type.Items.AddRange(New Object() {"Replacement", "Repair", "Pullout", "Reject"})
        Me.cbb_resolved_type.Name = "cbb_resolved_type"
        Me.cbb_resolved_type.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'col_received_credit_cost
        '
        Me.col_received_credit_cost.Caption = "Cost Per Unit"
        Me.col_received_credit_cost.DisplayFormat.FormatString = "n2"
        Me.col_received_credit_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_received_credit_cost.FieldName = "received_credit_memo_cost"
        Me.col_received_credit_cost.MinWidth = 23
        Me.col_received_credit_cost.Name = "col_received_credit_cost"
        Me.col_received_credit_cost.Visible = True
        Me.col_received_credit_cost.VisibleIndex = 6
        Me.col_received_credit_cost.Width = 66
        '
        'col_current_cost
        '
        Me.col_current_cost.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_current_cost.AppearanceCell.Options.UseBackColor = True
        Me.col_current_cost.Caption = "Current Cost"
        Me.col_current_cost.FieldName = "cost"
        Me.col_current_cost.MinWidth = 25
        Me.col_current_cost.Name = "col_current_cost"
        Me.col_current_cost.OptionsColumn.ReadOnly = True
        Me.col_current_cost.Visible = True
        Me.col_current_cost.VisibleIndex = 7
        Me.col_current_cost.Width = 94
        '
        'col_total_qty
        '
        Me.col_total_qty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_total_qty.AppearanceCell.Options.UseBackColor = True
        Me.col_total_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total_qty.Caption = "Total QTY"
        Me.col_total_qty.FieldName = "total_qty"
        Me.col_total_qty.MinWidth = 23
        Me.col_total_qty.Name = "col_total_qty"
        Me.col_total_qty.OptionsColumn.ReadOnly = True
        Me.col_total_qty.Visible = True
        Me.col_total_qty.VisibleIndex = 8
        Me.col_total_qty.Width = 66
        '
        'col_remaining_qty
        '
        Me.col_remaining_qty.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_remaining_qty.AppearanceCell.Options.UseBackColor = True
        Me.col_remaining_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_remaining_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_remaining_qty.Caption = "Balance QTY"
        Me.col_remaining_qty.FieldName = "remaining_qty"
        Me.col_remaining_qty.MinWidth = 23
        Me.col_remaining_qty.Name = "col_remaining_qty"
        Me.col_remaining_qty.OptionsColumn.ReadOnly = True
        Me.col_remaining_qty.Visible = True
        Me.col_remaining_qty.VisibleIndex = 9
        Me.col_remaining_qty.Width = 66
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_pid.AppearanceCell.Options.UseBackColor = True
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 82
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.OptionsColumn.ReadOnly = True
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 10
        Me.col_pid.Width = 82
        '
        'col_supmodel
        '
        Me.col_supmodel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_supmodel.AppearanceCell.Options.UseBackColor = True
        Me.col_supmodel.Caption = "Supmodel"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.OptionsColumn.ReadOnly = True
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 11
        Me.col_supmodel.Width = 66
        '
        'col_winmodel
        '
        Me.col_winmodel.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_winmodel.AppearanceCell.Options.UseBackColor = True
        Me.col_winmodel.Caption = "Winmodel"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.OptionsColumn.ReadOnly = True
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 12
        Me.col_winmodel.Width = 66
        '
        'col_unit
        '
        Me.col_unit.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_unit.AppearanceCell.Options.UseBackColor = True
        Me.col_unit.Caption = "Unit"
        Me.col_unit.FieldName = "unit"
        Me.col_unit.MinWidth = 23
        Me.col_unit.Name = "col_unit"
        Me.col_unit.OptionsColumn.ReadOnly = True
        Me.col_unit.Visible = True
        Me.col_unit.VisibleIndex = 13
        Me.col_unit.Width = 66
        '
        'col_description
        '
        Me.col_description.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_description.AppearanceCell.Options.UseBackColor = True
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 175
        Me.col_description.Name = "col_description"
        Me.col_description.OptionsColumn.ReadOnly = True
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 14
        Me.col_description.Width = 175
        '
        'col_serial
        '
        Me.col_serial.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_serial.AppearanceCell.Options.UseBackColor = True
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.OptionsColumn.ReadOnly = True
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 15
        Me.col_serial.Width = 66
        '
        'col_request_type
        '
        Me.col_request_type.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_request_type.AppearanceCell.Options.UseBackColor = True
        Me.col_request_type.Caption = "Request Type"
        Me.col_request_type.FieldName = "request_type"
        Me.col_request_type.MinWidth = 23
        Me.col_request_type.Name = "col_request_type"
        Me.col_request_type.OptionsColumn.ReadOnly = True
        Me.col_request_type.Visible = True
        Me.col_request_type.VisibleIndex = 16
        Me.col_request_type.Width = 66
        '
        'col_issue
        '
        Me.col_issue.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_issue.AppearanceCell.Options.UseBackColor = True
        Me.col_issue.Caption = "Issue"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 23
        Me.col_issue.Name = "col_issue"
        Me.col_issue.OptionsColumn.ReadOnly = True
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 17
        Me.col_issue.Width = 66
        '
        'col_date_pullout
        '
        Me.col_date_pullout.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_date_pullout.AppearanceCell.Options.UseBackColor = True
        Me.col_date_pullout.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_pullout.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_pullout.Caption = "Date Pullout"
        Me.col_date_pullout.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_date_pullout.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_pullout.FieldName = "date_pullout"
        Me.col_date_pullout.MinWidth = 23
        Me.col_date_pullout.Name = "col_date_pullout"
        Me.col_date_pullout.OptionsColumn.ReadOnly = True
        Me.col_date_pullout.Visible = True
        Me.col_date_pullout.VisibleIndex = 18
        Me.col_date_pullout.Width = 66
        '
        'col_stockreturns_warehouse
        '
        Me.col_stockreturns_warehouse.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.col_stockreturns_warehouse.AppearanceCell.Options.UseBackColor = True
        Me.col_stockreturns_warehouse.Caption = "Warehouse"
        Me.col_stockreturns_warehouse.FieldName = "warehouse"
        Me.col_stockreturns_warehouse.MinWidth = 23
        Me.col_stockreturns_warehouse.Name = "col_stockreturns_warehouse"
        Me.col_stockreturns_warehouse.OptionsColumn.ReadOnly = True
        Me.col_stockreturns_warehouse.Visible = True
        Me.col_stockreturns_warehouse.VisibleIndex = 19
        Me.col_stockreturns_warehouse.Width = 87
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Location = New System.Drawing.Point(1318, 729)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(124, 32)
        Me.btn_submit.TabIndex = 15
        Me.btn_submit.Text = "Submit"
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Location = New System.Drawing.Point(27, 168)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl20.TabIndex = 27
        Me.LabelControl20.Text = "*Date Received"
        '
        'txt_reference_no
        '
        Me.txt_reference_no.Location = New System.Drawing.Point(156, 117)
        Me.txt_reference_no.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_reference_no.Name = "txt_reference_no"
        Me.txt_reference_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_reference_no.Properties.Appearance.Options.UseFont = True
        Me.txt_reference_no.Size = New System.Drawing.Size(123, 34)
        Me.txt_reference_no.TabIndex = 26
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(27, 126)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(96, 16)
        Me.LabelControl19.TabIndex = 25
        Me.LabelControl19.Text = "*Reference No."
        '
        'cbb_tagetWarehouse
        '
        Me.cbb_tagetWarehouse.Location = New System.Drawing.Point(1070, 33)
        Me.cbb_tagetWarehouse.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_tagetWarehouse.Name = "cbb_tagetWarehouse"
        Me.cbb_tagetWarehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_tagetWarehouse.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_tagetWarehouse.Size = New System.Drawing.Size(50, 34)
        Me.cbb_tagetWarehouse.TabIndex = 24
        Me.cbb_tagetWarehouse.Visible = False
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Location = New System.Drawing.Point(966, 42)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(96, 21)
        Me.LabelControl18.TabIndex = 23
        Me.LabelControl18.Text = "(*Warehouse)"
        Me.LabelControl18.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(27, 84)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl5.TabIndex = 6
        Me.LabelControl5.Text = "*Supplier"
        '
        'frm_warehouse_receivingManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1475, 892)
        Me.Controls.Add(Me.tab_control)
        Me.Controls.Add(Me.LabelControl2)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_warehouse_receivingManagement"
        Me.Text = "Receiving Management"
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_delivery, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_delivery_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchControl1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_supplierDeliveries, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_supplierDeliveries.ResumeLayout(False)
        Me.panel_supplierDeliveries.PerformLayout()
        CType(Me.panel_stockTransfers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_stockTransfers.ResumeLayout(False)
        Me.panel_stockTransfers.PerformLayout()
        CType(Me.SearchControl3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sales_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_sales_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_srid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_sales_return, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_sales_return.ResumeLayout(False)
        Me.panel_sales_return.PerformLayout()
        CType(Me.tab_control, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_control.ResumeLayout(False)
        Me.tab_supplier_deliveries.ResumeLayout(False)
        Me.tab_supplier_deliveries.PerformLayout()
        Me.tab_sales_return.ResumeLayout(False)
        Me.tab_sales_return.PerformLayout()
        Me.tab_stock_transfers.ResumeLayout(False)
        Me.tab_stock_transfers.PerformLayout()
        Me.tab_stock_returns.ResumeLayout(False)
        Me.tab_stock_returns.PerformLayout()
        CType(Me.dt_received.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_received.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_return_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete_row, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_resolved_type, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_reference_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_tagetWarehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_ClicktoView_1 As Label
    Friend WithEvents grid_delivery As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_delivery_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view As Repository.RepositoryItemButtonEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents grid_stock_transfers As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transfers_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_src_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_linked_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents panel_supplierDeliveries As PanelControl
    Friend WithEvents panel_stockTransfers As PanelControl
    Friend WithEvents lbl_ClicktoView_2 As Label
    Friend WithEvents btn_view_order As Repository.RepositoryItemButtonEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents panel_sales_return As PanelControl
    Friend WithEvents lbl_sales_return As Label
    Friend WithEvents grid_sales_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_sales_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_srid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sales_return_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_srid As Repository.RepositoryItemButtonEdit
    Friend WithEvents col_created_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents SearchControl1 As SearchControl
    Friend WithEvents SearchControl3 As SearchControl
    Friend WithEvents tab_control As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab_supplier_deliveries As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab_stock_transfers As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab_sales_return As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents col_returns_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tab_stock_returns As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents btn_submit As SimpleButton
    Friend WithEvents cbb_tagetWarehouse As ComboBoxEdit
    Friend WithEvents LabelControl18 As LabelControl
    Friend WithEvents txt_reference_no As TextEdit
    Friend WithEvents LabelControl19 As LabelControl
    Friend WithEvents LabelControl20 As LabelControl
    Friend WithEvents grid_stock_return As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_return_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_serials As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received_resolved_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_resolved_type As Repository.RepositoryItemComboBox
    Friend WithEvents col_received_credit_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_remaining_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_add As SimpleButton
    Friend WithEvents col_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_serial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_request_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_issue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_pullout As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_stock_return_delete_row As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete_row As Repository.RepositoryItemButtonEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents dt_received As DateEdit
    Friend WithEvents cbb_supplier As ComboBoxEdit
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_stockreturns_warehouse As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_current_cost As DevExpress.XtraGrid.Columns.GridColumn
End Class
