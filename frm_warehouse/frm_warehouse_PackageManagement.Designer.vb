Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraBars.Navigation
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Runtime.CompilerServices

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_PackageManagement
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
        Dim EditorButtonImageOptions5 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject17 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject18 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject19 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject20 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions6 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject21 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject22 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject23 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject24 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions7 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject25 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject26 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject27 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject28 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_pullout_action = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_pullout_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grid_orders = New DevExpress.XtraGrid.GridControl()
        Me.grid_orders_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_SalesOrder_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_order_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sales_order_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_order_action = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_target_warehouse = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.tabpanel_orders = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_order_pending = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_order_ongoing = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_order_completed = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_order_cancelled = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grid_stock_transfers = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transfers_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_transfer_action = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_print = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_transfer_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_created = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabpanel_transfer = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_transfer_pending = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_transfer_completed = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_transfer_ongoing = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_transfer_cancellation = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage2 = New DevExpress.XtraTab.XtraTabPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabPage3 = New DevExpress.XtraTab.XtraTabPage()
        Me.grid_batch_pullout = New DevExpress.XtraGrid.GridControl()
        Me.grid_batch_pullout_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_pullouts_action = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_pullouts_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_batch_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_batch_pullout_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_batch_pullout_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tabpanel_pullouts = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_pullout_pending = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_pullout_ongoing = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_pullout_completed = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.tab_pullout_unpacking = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.btn_pullout_action, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_pullout_print, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_order_action, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabpanel_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpanel_orders.SuspendLayout()
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_transfer_action, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_transfer_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabpanel_transfer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpanel_transfer.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.XtraTabPage2.SuspendLayout()
        Me.XtraTabPage3.SuspendLayout()
        CType(Me.grid_batch_pullout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_batch_pullout_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_pullouts_action, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_pullouts_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabpanel_pullouts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabpanel_pullouts.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_pullout_action
        '
        Me.btn_pullout_action.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_pullout_action.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_pullout_action.Name = "btn_pullout_action"
        Me.btn_pullout_action.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_pullout_print
        '
        Me.btn_pullout_print.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        EditorButtonImageOptions2.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_pullout_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_pullout_print.Name = "btn_pullout_print"
        Me.btn_pullout_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.LabelControl16)
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Controls.Add(Me.cbb_timer)
        Me.Panel1.Location = New System.Drawing.Point(921, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 35)
        Me.Panel1.TabIndex = 8
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(32, 9)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(72, 17)
        Me.LabelControl16.TabIndex = 24
        Me.LabelControl16.Text = "Auto refresh"
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inventory_Management.My.Resources.Resources.time_16x16
        Me.PictureEdit1.Location = New System.Drawing.Point(110, 9)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(20, 20)
        Me.PictureEdit1.TabIndex = 6
        '
        'cbb_timer
        '
        Me.cbb_timer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_timer.EditValue = "1 min"
        Me.cbb_timer.Location = New System.Drawing.Point(135, 4)
        Me.cbb_timer.Name = "cbb_timer"
        Me.cbb_timer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_timer.Properties.Appearance.Options.UseFont = True
        Me.cbb_timer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_timer.Properties.Items.AddRange(New Object() {"1 min", "5 min", "10 min", "30 min"})
        Me.cbb_timer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_timer.Size = New System.Drawing.Size(75, 28)
        Me.cbb_timer.TabIndex = 4
        '
        'grid_orders
        '
        Me.grid_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_orders.Location = New System.Drawing.Point(18, 105)
        Me.grid_orders.MainView = Me.grid_orders_view
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_order_action})
        Me.grid_orders.Size = New System.Drawing.Size(1087, 433)
        Me.grid_orders.TabIndex = 8
        Me.grid_orders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_orders_view})
        '
        'grid_orders_view
        '
        Me.grid_orders_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_orders_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_orders_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_orders_view.Appearance.Row.Options.UseFont = True
        Me.grid_orders_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_orders_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_SalesOrder_id, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.col_order_status, Me.col_sales_order_id, Me.col_target_warehouse})
        Me.grid_orders_view.GridControl = Me.grid_orders
        Me.grid_orders_view.Name = "grid_orders_view"
        Me.grid_orders_view.OptionsBehavior.ReadOnly = True
        Me.grid_orders_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_orders_view.OptionsView.ShowGroupPanel = False
        Me.grid_orders_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_SalesOrder_id
        '
        Me.col_SalesOrder_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_SalesOrder_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_SalesOrder_id.Caption = "Order ID"
        Me.col_SalesOrder_id.FieldName = "order_id"
        Me.col_SalesOrder_id.MaxWidth = 100
        Me.col_SalesOrder_id.MinWidth = 50
        Me.col_SalesOrder_id.Name = "col_SalesOrder_id"
        Me.col_SalesOrder_id.OptionsColumn.FixedWidth = True
        Me.col_SalesOrder_id.Visible = True
        Me.col_SalesOrder_id.VisibleIndex = 1
        Me.col_SalesOrder_id.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Customer"
        Me.GridColumn2.FieldName = "first_name"
        Me.GridColumn2.MaxWidth = 250
        Me.GridColumn2.MinWidth = 50
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 150
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Generated by"
        Me.GridColumn3.FieldName = "agent"
        Me.GridColumn3.MaxWidth = 250
        Me.GridColumn3.MinWidth = 50
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 150
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Entry Date"
        Me.GridColumn4.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "date_ordered"
        Me.GridColumn4.MaxWidth = 100
        Me.GridColumn4.MinWidth = 50
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 100
        '
        'col_order_status
        '
        Me.col_order_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_status.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_order_status.AppearanceHeader.Options.UseForeColor = True
        Me.col_order_status.Caption = "Status"
        Me.col_order_status.FieldName = "status"
        Me.col_order_status.MaxWidth = 250
        Me.col_order_status.Name = "col_order_status"
        Me.col_order_status.OptionsColumn.FixedWidth = True
        Me.col_order_status.Visible = True
        Me.col_order_status.VisibleIndex = 5
        Me.col_order_status.Width = 120
        '
        'col_sales_order_id
        '
        Me.col_sales_order_id.Caption = "Action"
        Me.col_sales_order_id.ColumnEdit = Me.btn_order_action
        Me.col_sales_order_id.MaxWidth = 60
        Me.col_sales_order_id.Name = "col_sales_order_id"
        Me.col_sales_order_id.Visible = True
        Me.col_sales_order_id.VisibleIndex = 0
        Me.col_sales_order_id.Width = 50
        '
        'btn_order_action
        '
        Me.btn_order_action.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_order_action.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_order_action.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_order_action.Name = "btn_order_action"
        Me.btn_order_action.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_target_warehouse
        '
        Me.col_target_warehouse.Caption = "Target Warehouse"
        Me.col_target_warehouse.FieldName = "store_name"
        Me.col_target_warehouse.Name = "col_target_warehouse"
        Me.col_target_warehouse.Visible = True
        Me.col_target_warehouse.VisibleIndex = 6
        '
        'timer
        '
        '
        'tabpanel_orders
        '
        Me.tabpanel_orders.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabpanel_orders.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.tabpanel_orders.Appearance.Options.UseBackColor = True
        Me.tabpanel_orders.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_orders.AppearanceButton.Hovered.Options.UseFont = True
        Me.tabpanel_orders.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_orders.AppearanceButton.Normal.Options.UseFont = True
        Me.tabpanel_orders.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tabpanel_orders.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.Red
        Me.tabpanel_orders.AppearanceButton.Pressed.Options.UseFont = True
        Me.tabpanel_orders.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.tabpanel_orders.Controls.Add(Me.tab_order_pending)
        Me.tabpanel_orders.Controls.Add(Me.tab_order_ongoing)
        Me.tabpanel_orders.Controls.Add(Me.tab_order_completed)
        Me.tabpanel_orders.Controls.Add(Me.tab_order_cancelled)
        Me.tabpanel_orders.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpanel_orders.Location = New System.Drawing.Point(18, 56)
        Me.tabpanel_orders.Name = "tabpanel_orders"
        Me.tabpanel_orders.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_order_pending, Me.tab_order_ongoing, Me.tab_order_completed, Me.tab_order_cancelled})
        Me.tabpanel_orders.RegularSize = New System.Drawing.Size(1087, 55)
        Me.tabpanel_orders.SelectedPage = Me.tab_order_pending
        Me.tabpanel_orders.Size = New System.Drawing.Size(1087, 55)
        Me.tabpanel_orders.TabIndex = 15
        Me.tabpanel_orders.Text = "Pending Arrangements"
        '
        'tab_order_pending
        '
        Me.tab_order_pending.Caption = "Pending Arrangements"
        Me.tab_order_pending.Name = "tab_order_pending"
        Me.tab_order_pending.Size = New System.Drawing.Size(1087, 9)
        '
        'tab_order_ongoing
        '
        Me.tab_order_ongoing.Caption = "On-Going"
        Me.tab_order_ongoing.Name = "tab_order_ongoing"
        Me.tab_order_ongoing.Size = New System.Drawing.Size(1099, 36)
        '
        'tab_order_completed
        '
        Me.tab_order_completed.Caption = "Completed"
        Me.tab_order_completed.Name = "tab_order_completed"
        Me.tab_order_completed.Size = New System.Drawing.Size(1099, 36)
        '
        'tab_order_cancelled
        '
        Me.tab_order_cancelled.Caption = "For Unpacking"
        Me.tab_order_cancelled.Name = "tab_order_cancelled"
        Me.tab_order_cancelled.Size = New System.Drawing.Size(1099, 36)
        '
        'grid_stock_transfers
        '
        Me.grid_stock_transfers.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transfers.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transfers.Location = New System.Drawing.Point(18, 105)
        Me.grid_stock_transfers.MainView = Me.grid_stock_transfers_view
        Me.grid_stock_transfers.Name = "grid_stock_transfers"
        Me.grid_stock_transfers.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_transfer_action, Me.btn_transfer_print})
        Me.grid_stock_transfers.Size = New System.Drawing.Size(1088, 423)
        Me.grid_stock_transfers.TabIndex = 14
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
        Me.grid_stock_transfers_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_print, Me.col_transfer_id, Me.col_transfer_type, Me.col_from, Me.col_to, Me.col_transfer_status, Me.col_sub_transfer_id, Me.col_date_created})
        Me.grid_stock_transfers_view.GridControl = Me.grid_stock_transfers
        Me.grid_stock_transfers_view.Name = "grid_stock_transfers_view"
        Me.grid_stock_transfers_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transfers_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_stock_transfers_view.OptionsView.ShowGroupPanel = False
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_transfer_action
        Me.col_view.MaxWidth = 60
        Me.col_view.MinWidth = 50
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 55
        '
        'btn_transfer_action
        '
        Me.btn_transfer_action.AutoHeight = False
        EditorButtonImageOptions4.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_transfer_action.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_transfer_action.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_transfer_action.Name = "btn_transfer_action"
        Me.btn_transfer_action.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_print
        '
        Me.col_print.Caption = "Print"
        Me.col_print.ColumnEdit = Me.btn_transfer_print
        Me.col_print.MaxWidth = 60
        Me.col_print.Name = "col_print"
        Me.col_print.Visible = True
        Me.col_print.VisibleIndex = 1
        Me.col_print.Width = 55
        '
        'btn_transfer_print
        '
        Me.btn_transfer_print.AutoHeight = False
        EditorButtonImageOptions5.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        EditorButtonImageOptions5.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_transfer_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions5, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_transfer_print.Name = "btn_transfer_print"
        Me.btn_transfer_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_transfer_id
        '
        Me.col_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_id.Caption = "Root Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.MaxWidth = 120
        Me.col_transfer_id.MinWidth = 80
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 3
        Me.col_transfer_id.Width = 104
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
        'col_from
        '
        Me.col_from.AppearanceHeader.Options.UseTextOptions = True
        Me.col_from.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_from.Caption = "FROM"
        Me.col_from.FieldName = "source_warehouse"
        Me.col_from.MaxWidth = 200
        Me.col_from.MinWidth = 200
        Me.col_from.Name = "col_from"
        Me.col_from.Visible = True
        Me.col_from.VisibleIndex = 6
        Me.col_from.Width = 200
        '
        'col_to
        '
        Me.col_to.Caption = "TO"
        Me.col_to.FieldName = "receiver_warehouse"
        Me.col_to.MaxWidth = 200
        Me.col_to.MinWidth = 250
        Me.col_to.Name = "col_to"
        Me.col_to.Visible = True
        Me.col_to.VisibleIndex = 7
        Me.col_to.Width = 250
        '
        'col_transfer_status
        '
        Me.col_transfer_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transfer_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transfer_status.Caption = "Status"
        Me.col_transfer_status.FieldName = "status"
        Me.col_transfer_status.MaxWidth = 150
        Me.col_transfer_status.MinWidth = 80
        Me.col_transfer_status.Name = "col_transfer_status"
        Me.col_transfer_status.Visible = True
        Me.col_transfer_status.VisibleIndex = 5
        Me.col_transfer_status.Width = 80
        '
        'col_sub_transfer_id
        '
        Me.col_sub_transfer_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_sub_transfer_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sub_transfer_id.Caption = "Sub Transfer ID"
        Me.col_sub_transfer_id.FieldName = "sub_transfer_id"
        Me.col_sub_transfer_id.MaxWidth = 120
        Me.col_sub_transfer_id.Name = "col_sub_transfer_id"
        Me.col_sub_transfer_id.Visible = True
        Me.col_sub_transfer_id.VisibleIndex = 2
        Me.col_sub_transfer_id.Width = 90
        '
        'col_date_created
        '
        Me.col_date_created.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_created.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_created.Caption = "Date Generated"
        Me.col_date_created.DisplayFormat.FormatString = "MM-dd-yyyy, hh:mm tt"
        Me.col_date_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_created.FieldName = "date_released"
        Me.col_date_created.MinWidth = 180
        Me.col_date_created.Name = "col_date_created"
        Me.col_date_created.Visible = True
        Me.col_date_created.VisibleIndex = 8
        Me.col_date_created.Width = 200
        '
        'tabpanel_transfer
        '
        Me.tabpanel_transfer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabpanel_transfer.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_transfer.AppearanceButton.Hovered.Options.UseFont = True
        Me.tabpanel_transfer.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_transfer.AppearanceButton.Normal.Options.UseFont = True
        Me.tabpanel_transfer.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tabpanel_transfer.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.Red
        Me.tabpanel_transfer.AppearanceButton.Pressed.Options.UseFont = True
        Me.tabpanel_transfer.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_pending)
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_completed)
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_ongoing)
        Me.tabpanel_transfer.Controls.Add(Me.tab_transfer_cancellation)
        Me.tabpanel_transfer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpanel_transfer.Location = New System.Drawing.Point(18, 56)
        Me.tabpanel_transfer.Name = "tabpanel_transfer"
        Me.tabpanel_transfer.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_transfer_pending, Me.tab_transfer_ongoing, Me.tab_transfer_completed, Me.tab_transfer_cancellation})
        Me.tabpanel_transfer.RegularSize = New System.Drawing.Size(1088, 55)
        Me.tabpanel_transfer.SelectedPage = Me.tab_transfer_pending
        Me.tabpanel_transfer.Size = New System.Drawing.Size(1088, 55)
        Me.tabpanel_transfer.TabIndex = 85
        Me.tabpanel_transfer.Text = "Pending"
        '
        'tab_transfer_pending
        '
        Me.tab_transfer_pending.Caption = "Pending Arrangements"
        Me.tab_transfer_pending.Name = "tab_transfer_pending"
        Me.tab_transfer_pending.Size = New System.Drawing.Size(1088, 9)
        '
        'tab_transfer_completed
        '
        Me.tab_transfer_completed.Caption = "Completed"
        Me.tab_transfer_completed.Name = "tab_transfer_completed"
        Me.tab_transfer_completed.Size = New System.Drawing.Size(1099, 36)
        '
        'tab_transfer_ongoing
        '
        Me.tab_transfer_ongoing.Caption = "On-Going Arrangements"
        Me.tab_transfer_ongoing.Name = "tab_transfer_ongoing"
        Me.tab_transfer_ongoing.Size = New System.Drawing.Size(1088, 9)
        '
        'tab_transfer_cancellation
        '
        Me.tab_transfer_cancellation.Caption = "For Unpacking"
        Me.tab_transfer_cancellation.Name = "tab_transfer_cancellation"
        Me.tab_transfer_cancellation.Size = New System.Drawing.Size(1099, 36)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(270, 31)
        Me.LabelControl2.TabIndex = 74
        Me.LabelControl2.Text = "Package Management"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 65)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(1119, 572)
        Me.XtraTabControl1.TabIndex = 75
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1, Me.XtraTabPage2, Me.XtraTabPage3})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.LabelControl1)
        Me.XtraTabPage1.Controls.Add(Me.grid_orders)
        Me.XtraTabPage1.Controls.Add(Me.tabpanel_orders)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(1117, 541)
        Me.XtraTabPage1.Text = "Customer Orders"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 19)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(163, 25)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Customer Orders"
        '
        'XtraTabPage2
        '
        Me.XtraTabPage2.Controls.Add(Me.grid_stock_transfers)
        Me.XtraTabPage2.Controls.Add(Me.LabelControl3)
        Me.XtraTabPage2.Controls.Add(Me.tabpanel_transfer)
        Me.XtraTabPage2.Name = "XtraTabPage2"
        Me.XtraTabPage2.Size = New System.Drawing.Size(1117, 541)
        Me.XtraTabPage2.Text = "Stock Transfers"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 19)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(151, 25)
        Me.LabelControl3.TabIndex = 1
        Me.LabelControl3.Text = "Stock Transfers"
        '
        'XtraTabPage3
        '
        Me.XtraTabPage3.Controls.Add(Me.grid_batch_pullout)
        Me.XtraTabPage3.Controls.Add(Me.tabpanel_pullouts)
        Me.XtraTabPage3.Controls.Add(Me.LabelControl4)
        Me.XtraTabPage3.Name = "XtraTabPage3"
        Me.XtraTabPage3.Size = New System.Drawing.Size(1117, 541)
        Me.XtraTabPage3.Text = "Return to Vendor"
        '
        'grid_batch_pullout
        '
        Me.grid_batch_pullout.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_batch_pullout.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_batch_pullout.Location = New System.Drawing.Point(18, 105)
        Me.grid_batch_pullout.MainView = Me.grid_batch_pullout_view
        Me.grid_batch_pullout.Name = "grid_batch_pullout"
        Me.grid_batch_pullout.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_pullouts_action, Me.btn_pullouts_print})
        Me.grid_batch_pullout.Size = New System.Drawing.Size(1088, 423)
        Me.grid_batch_pullout.TabIndex = 87
        Me.grid_batch_pullout.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_batch_pullout_view})
        '
        'grid_batch_pullout_view
        '
        Me.grid_batch_pullout_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_batch_pullout_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_batch_pullout_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_batch_pullout_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_batch_pullout_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_batch_pullout_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_batch_pullout_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_batch_pullout_view.Appearance.Row.Options.UseFont = True
        Me.grid_batch_pullout_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_batch_pullout_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_batch_pullout_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_batch_pullout_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_batch_pullout_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn5, Me.col_batch_id, Me.col_batch_pullout_status, Me.col_batch_pullout_supplier})
        Me.grid_batch_pullout_view.GridControl = Me.grid_batch_pullout
        Me.grid_batch_pullout_view.Name = "grid_batch_pullout_view"
        Me.grid_batch_pullout_view.OptionsBehavior.ReadOnly = True
        Me.grid_batch_pullout_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_batch_pullout_view.OptionsView.ShowGroupPanel = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Action"
        Me.GridColumn1.ColumnEdit = Me.btn_pullouts_action
        Me.GridColumn1.MaxWidth = 60
        Me.GridColumn1.MinWidth = 50
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 55
        '
        'btn_pullouts_action
        '
        Me.btn_pullouts_action.AutoHeight = False
        EditorButtonImageOptions6.Image = Global.Inventory_Management.My.Resources.Resources.up_16x16
        Me.btn_pullouts_action.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions6, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject21, SerializableAppearanceObject22, SerializableAppearanceObject23, SerializableAppearanceObject24, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_pullouts_action.Name = "btn_pullouts_action"
        Me.btn_pullouts_action.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Print"
        Me.GridColumn5.ColumnEdit = Me.btn_pullouts_print
        Me.GridColumn5.MaxWidth = 60
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 1
        Me.GridColumn5.Width = 55
        '
        'btn_pullouts_print
        '
        Me.btn_pullouts_print.AutoHeight = False
        EditorButtonImageOptions7.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        EditorButtonImageOptions7.SvgImageSize = New System.Drawing.Size(22, 22)
        Me.btn_pullouts_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions7, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject25, SerializableAppearanceObject26, SerializableAppearanceObject27, SerializableAppearanceObject28, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_pullouts_print.Name = "btn_pullouts_print"
        Me.btn_pullouts_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_batch_id
        '
        Me.col_batch_id.Caption = "Batch ID"
        Me.col_batch_id.FieldName = "batch_id"
        Me.col_batch_id.MaxWidth = 80
        Me.col_batch_id.Name = "col_batch_id"
        Me.col_batch_id.Visible = True
        Me.col_batch_id.VisibleIndex = 2
        Me.col_batch_id.Width = 40
        '
        'col_batch_pullout_status
        '
        Me.col_batch_pullout_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_batch_pullout_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_batch_pullout_status.Caption = "Status"
        Me.col_batch_pullout_status.FieldName = "status"
        Me.col_batch_pullout_status.MaxWidth = 250
        Me.col_batch_pullout_status.MinWidth = 80
        Me.col_batch_pullout_status.Name = "col_batch_pullout_status"
        Me.col_batch_pullout_status.Visible = True
        Me.col_batch_pullout_status.VisibleIndex = 4
        Me.col_batch_pullout_status.Width = 80
        '
        'col_batch_pullout_supplier
        '
        Me.col_batch_pullout_supplier.Caption = "Supplier"
        Me.col_batch_pullout_supplier.FieldName = "supplier"
        Me.col_batch_pullout_supplier.Name = "col_batch_pullout_supplier"
        Me.col_batch_pullout_supplier.Visible = True
        Me.col_batch_pullout_supplier.VisibleIndex = 3
        '
        'tabpanel_pullouts
        '
        Me.tabpanel_pullouts.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabpanel_pullouts.AppearanceButton.Hovered.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_pullouts.AppearanceButton.Hovered.Options.UseFont = True
        Me.tabpanel_pullouts.AppearanceButton.Normal.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.tabpanel_pullouts.AppearanceButton.Normal.Options.UseFont = True
        Me.tabpanel_pullouts.AppearanceButton.Pressed.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.tabpanel_pullouts.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.Red
        Me.tabpanel_pullouts.AppearanceButton.Pressed.Options.UseFont = True
        Me.tabpanel_pullouts.AppearanceButton.Pressed.Options.UseForeColor = True
        Me.tabpanel_pullouts.Controls.Add(Me.tab_pullout_pending)
        Me.tabpanel_pullouts.Controls.Add(Me.tab_pullout_ongoing)
        Me.tabpanel_pullouts.Controls.Add(Me.tab_pullout_completed)
        Me.tabpanel_pullouts.Controls.Add(Me.tab_pullout_unpacking)
        Me.tabpanel_pullouts.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabpanel_pullouts.Location = New System.Drawing.Point(18, 56)
        Me.tabpanel_pullouts.Name = "tabpanel_pullouts"
        Me.tabpanel_pullouts.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_pullout_pending, Me.tab_pullout_ongoing, Me.tab_pullout_completed, Me.tab_pullout_unpacking})
        Me.tabpanel_pullouts.RegularSize = New System.Drawing.Size(1088, 55)
        Me.tabpanel_pullouts.SelectedPage = Me.tab_pullout_pending
        Me.tabpanel_pullouts.Size = New System.Drawing.Size(1088, 55)
        Me.tabpanel_pullouts.TabIndex = 86
        Me.tabpanel_pullouts.Text = "Pending"
        '
        'tab_pullout_pending
        '
        Me.tab_pullout_pending.Caption = "Pending Arrangements"
        Me.tab_pullout_pending.Name = "tab_pullout_pending"
        Me.tab_pullout_pending.Size = New System.Drawing.Size(1088, 9)
        '
        'tab_pullout_ongoing
        '
        Me.tab_pullout_ongoing.Caption = "On-Going Arrangements"
        Me.tab_pullout_ongoing.Name = "tab_pullout_ongoing"
        Me.tab_pullout_ongoing.Size = New System.Drawing.Size(1088, 9)
        '
        'tab_pullout_completed
        '
        Me.tab_pullout_completed.Caption = "Completed"
        Me.tab_pullout_completed.Name = "tab_pullout_completed"
        Me.tab_pullout_completed.Size = New System.Drawing.Size(1088, 9)
        '
        'tab_pullout_unpacking
        '
        Me.tab_pullout_unpacking.Caption = "For Unpacking"
        Me.tab_pullout_unpacking.Name = "tab_pullout_unpacking"
        Me.tab_pullout_unpacking.PageVisible = False
        Me.tab_pullout_unpacking.Size = New System.Drawing.Size(1088, 9)
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(18, 19)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(163, 25)
        Me.LabelControl4.TabIndex = 2
        Me.LabelControl4.Text = "Return to Vendor"
        '
        'frm_warehouse_PackageManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 649)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LabelControl2)
        Me.KeyPreview = True
        Me.Name = "frm_warehouse_PackageManagement"
        Me.Text = "Package Management"
        CType(Me.btn_pullout_action, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_pullout_print, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_order_action, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabpanel_orders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpanel_orders.ResumeLayout(False)
        CType(Me.grid_stock_transfers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transfers_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_transfer_action, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_transfer_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabpanel_transfer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpanel_transfer.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        Me.XtraTabPage2.ResumeLayout(False)
        Me.XtraTabPage2.PerformLayout()
        Me.XtraTabPage3.ResumeLayout(False)
        Me.XtraTabPage3.PerformLayout()
        CType(Me.grid_batch_pullout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_batch_pullout_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_pullouts_action, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_pullouts_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabpanel_pullouts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabpanel_pullouts.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_orders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_orders_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_SalesOrder_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_order_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents timer As Timer
    Friend WithEvents tabpanel_orders As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tab_order_pending As TabNavigationPage
    Friend WithEvents tab_order_ongoing As TabNavigationPage
    Friend WithEvents tab_order_completed As TabNavigationPage
    Friend WithEvents tab_order_cancelled As TabNavigationPage
    Friend WithEvents grid_stock_transfers As GridControl
    Friend WithEvents grid_stock_transfers_view As GridView
    Friend WithEvents col_view As GridColumn
    Friend WithEvents col_transfer_id As GridColumn
    Friend WithEvents col_transfer_type As GridColumn
    Friend WithEvents col_from As GridColumn
    Friend WithEvents col_to As GridColumn
    Friend WithEvents col_transfer_status As GridColumn
    Friend WithEvents btn_transfer_action As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents tabpanel_transfer As TabPane
    Friend WithEvents tab_transfer_pending As TabNavigationPage
    Friend WithEvents tab_transfer_ongoing As TabNavigationPage
    Friend WithEvents tab_transfer_completed As TabNavigationPage
    Friend WithEvents col_sales_order_id As GridColumn
    Friend WithEvents btn_order_action As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_sub_transfer_id As GridColumn
    Friend WithEvents tab_transfer_cancellation As TabNavigationPage
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents LabelControl16 As LabelControl
    Friend WithEvents col_target_warehouse As GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents XtraTabPage2 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents col_print As GridColumn
    Friend WithEvents btn_transfer_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_date_created As GridColumn
    Friend WithEvents XtraTabPage3 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid_batch_pullout As GridControl
    Friend WithEvents grid_batch_pullout_view As GridView
    Friend WithEvents GridColumn1 As GridColumn
    Friend WithEvents GridColumn5 As GridColumn
    Friend WithEvents col_batch_pullout_status As GridColumn
    Friend WithEvents tabpanel_pullouts As TabPane
    Friend WithEvents tab_pullout_pending As TabNavigationPage
    Friend WithEvents tab_pullout_completed As TabNavigationPage
    Friend WithEvents tab_pullout_ongoing As TabNavigationPage
    Friend WithEvents tab_pullout_unpacking As TabNavigationPage
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents col_batch_pullout_supplier As GridColumn
    Friend WithEvents col_batch_id As GridColumn
    Friend WithEvents btn_pullout_action As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_pullout_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_pullouts_action As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_pullouts_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
