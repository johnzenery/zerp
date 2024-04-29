Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Container
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Repository
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySqlConnector
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_orders_list
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
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btn_sort_cancelled = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sort_completed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sort_all = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_sort_onprocess = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_order = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_orders = New DevExpress.XtraGrid.GridControl()
        Me.grid_orders_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_order_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tax_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_ordered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_packed = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_released = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_checked_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_packed_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_organized_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_released_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delivered_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dute_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sales_invoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_arranged = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.cbb_timer)
        Me.Panel1.Controls.Add(Me.PictureEdit1)
        Me.Panel1.Location = New System.Drawing.Point(1765, 15)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(162, 48)
        Me.Panel1.TabIndex = 7
        Me.Panel1.Visible = False
        '
        'cbb_timer
        '
        Me.cbb_timer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_timer.EditValue = "1 min"
        Me.cbb_timer.Location = New System.Drawing.Point(67, 4)
        Me.cbb_timer.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_timer.Name = "cbb_timer"
        Me.cbb_timer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_timer.Properties.Appearance.Options.UseFont = True
        Me.cbb_timer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_timer.Properties.Items.AddRange(New Object() {"1 min", "5 min", "10 min", "30 min"})
        Me.cbb_timer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_timer.Size = New System.Drawing.Size(91, 36)
        Me.cbb_timer.TabIndex = 4
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = Global.Inventory_Management.My.Resources.Resources.time_16x16
        Me.PictureEdit1.Location = New System.Drawing.Point(36, 11)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit1.Size = New System.Drawing.Size(23, 25)
        Me.PictureEdit1.TabIndex = 6
        '
        'btn_sort_cancelled
        '
        Me.btn_sort_cancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_cancelled.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_sort_cancelled.Appearance.Options.UseFont = True
        Me.btn_sort_cancelled.Appearance.Options.UseTextOptions = True
        Me.btn_sort_cancelled.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_cancelled.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_cancelled.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_cancelled.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_cancelled.Location = New System.Drawing.Point(1554, 71)
        Me.btn_sort_cancelled.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sort_cancelled.Name = "btn_sort_cancelled"
        Me.btn_sort_cancelled.Size = New System.Drawing.Size(119, 57)
        Me.btn_sort_cancelled.TabIndex = 18
        Me.btn_sort_cancelled.Text = "CANCELLED"
        '
        'btn_sort_completed
        '
        Me.btn_sort_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_completed.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_sort_completed.Appearance.Options.UseFont = True
        Me.btn_sort_completed.Appearance.Options.UseTextOptions = True
        Me.btn_sort_completed.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_completed.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_completed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_completed.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_completed.Location = New System.Drawing.Point(1681, 70)
        Me.btn_sort_completed.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sort_completed.Name = "btn_sort_completed"
        Me.btn_sort_completed.Size = New System.Drawing.Size(119, 57)
        Me.btn_sort_completed.TabIndex = 17
        Me.btn_sort_completed.Text = "COMPLETED"
        '
        'btn_sort_all
        '
        Me.btn_sort_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_all.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_sort_all.Appearance.Options.UseFont = True
        Me.btn_sort_all.Appearance.Options.UseTextOptions = True
        Me.btn_sort_all.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_all.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_all.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_all.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_all.Location = New System.Drawing.Point(1808, 70)
        Me.btn_sort_all.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sort_all.Name = "btn_sort_all"
        Me.btn_sort_all.Size = New System.Drawing.Size(119, 57)
        Me.btn_sort_all.TabIndex = 15
        Me.btn_sort_all.Text = "ALL"
        '
        'btn_sort_onprocess
        '
        Me.btn_sort_onprocess.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sort_onprocess.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_sort_onprocess.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_sort_onprocess.Appearance.Options.UseBackColor = True
        Me.btn_sort_onprocess.Appearance.Options.UseFont = True
        Me.btn_sort_onprocess.Appearance.Options.UseTextOptions = True
        Me.btn_sort_onprocess.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_sort_onprocess.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_sort_onprocess.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_sort_onprocess.ImageOptions.ImageToTextIndent = 5
        Me.btn_sort_onprocess.Location = New System.Drawing.Point(1427, 71)
        Me.btn_sort_onprocess.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_sort_onprocess.Name = "btn_sort_onprocess"
        Me.btn_sort_onprocess.Size = New System.Drawing.Size(119, 57)
        Me.btn_sort_onprocess.TabIndex = 16
        Me.btn_sort_onprocess.Text = "ON-PROCESS"
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_refresh.Location = New System.Drawing.Point(208, 71)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(187, 57)
        Me.btn_refresh.TabIndex = 13
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_order
        '
        Me.btn_order.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_order.Appearance.Options.UseFont = True
        Me.btn_order.Appearance.Options.UseTextOptions = True
        Me.btn_order.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_order.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_order.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newsales_32x32
        Me.btn_order.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_order.ImageOptions.ImageToTextIndent = 5
        Me.btn_order.Location = New System.Drawing.Point(14, 71)
        Me.btn_order.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_order.Name = "btn_order"
        Me.btn_order.Size = New System.Drawing.Size(187, 57)
        Me.btn_order.TabIndex = 10
        Me.btn_order.Text = "New Order"
        '
        'grid_orders
        '
        Me.grid_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_orders.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_orders.Location = New System.Drawing.Point(-1, 135)
        Me.grid_orders.MainView = Me.grid_orders_view
        Me.grid_orders.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view})
        Me.grid_orders.Size = New System.Drawing.Size(1928, 713)
        Me.grid_orders.TabIndex = 8
        Me.grid_orders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_orders_view})
        '
        'grid_orders_view
        '
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_orders_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_orders_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_orders_view.Appearance.Row.Options.UseFont = True
        Me.grid_orders_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.SelectedRow.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_orders_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseFont = True
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_orders_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_order_id, Me.GridColumn2, Me.col_po_ref, Me.GridColumn1, Me.GridColumn3, Me.GridColumn9, Me.GridColumn7, Me.col_tax_type, Me.GridColumn10, Me.GridColumn5, Me.col_date_ordered, Me.col_date_packed, Me.col_date_released, Me.col_checked_by, Me.col_packed_by, Me.col_organized_by, Me.col_released_by, Me.col_delivered_by, Me.col_terms, Me.col_dute_date, Me.col_sales_invoice, Me.col_date_arranged})
        Me.grid_orders_view.DetailHeight = 431
        Me.grid_orders_view.GridControl = Me.grid_orders
        Me.grid_orders_view.Name = "grid_orders_view"
        Me.grid_orders_view.OptionsBehavior.ReadOnly = True
        Me.grid_orders_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_orders_view.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        '
        'col_view
        '
        Me.col_view.Caption = "Action"
        Me.col_view.ColumnEdit = Me.btn_view
        Me.col_view.MinWidth = 70
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 70
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.article_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_order_id
        '
        Me.col_order_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_order_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.Caption = "Order ID"
        Me.col_order_id.FieldName = "order_id"
        Me.col_order_id.MinWidth = 93
        Me.col_order_id.Name = "col_order_id"
        Me.col_order_id.Visible = True
        Me.col_order_id.VisibleIndex = 1
        Me.col_order_id.Width = 93
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "Customer"
        Me.GridColumn2.FieldName = "first_name"
        Me.GridColumn2.MinWidth = 292
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 292
        '
        'col_po_ref
        '
        Me.col_po_ref.Caption = "P.O. Ref"
        Me.col_po_ref.FieldName = "po_reference"
        Me.col_po_ref.MinWidth = 103
        Me.col_po_ref.Name = "col_po_ref"
        Me.col_po_ref.Visible = True
        Me.col_po_ref.VisibleIndex = 3
        Me.col_po_ref.Width = 103
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Target Warehouse"
        Me.GridColumn1.FieldName = "target_warehouse_name"
        Me.GridColumn1.MinWidth = 233
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 233
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Sales Coordinator"
        Me.GridColumn3.FieldName = "agent"
        Me.GridColumn3.MinWidth = 210
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 5
        Me.GridColumn3.Width = 210
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Shipping"
        Me.GridColumn9.FieldName = "shipping_method"
        Me.GridColumn9.MinWidth = 117
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 6
        Me.GridColumn9.Width = 117
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Payment Type"
        Me.GridColumn7.FieldName = "payment_type"
        Me.GridColumn7.MinWidth = 140
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 140
        '
        'col_tax_type
        '
        Me.col_tax_type.Caption = "Tax Type"
        Me.col_tax_type.FieldName = "tax_type"
        Me.col_tax_type.MinWidth = 93
        Me.col_tax_type.Name = "col_tax_type"
        Me.col_tax_type.Visible = True
        Me.col_tax_type.VisibleIndex = 8
        Me.col_tax_type.Width = 140
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn10.Caption = "Payment Status"
        Me.GridColumn10.FieldName = "payment_status"
        Me.GridColumn10.MinWidth = 140
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 9
        Me.GridColumn10.Width = 140
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Package Status"
        Me.GridColumn5.FieldName = "status"
        Me.GridColumn5.MinWidth = 140
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 10
        Me.GridColumn5.Width = 140
        '
        'col_date_ordered
        '
        Me.col_date_ordered.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_ordered.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_ordered.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_ordered.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_ordered.Caption = "Date Ordered"
        Me.col_date_ordered.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_ordered.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_ordered.FieldName = "date_ordered"
        Me.col_date_ordered.MinWidth = 140
        Me.col_date_ordered.Name = "col_date_ordered"
        Me.col_date_ordered.OptionsColumn.AllowEdit = False
        Me.col_date_ordered.Visible = True
        Me.col_date_ordered.VisibleIndex = 11
        Me.col_date_ordered.Width = 140
        '
        'col_date_packed
        '
        Me.col_date_packed.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_packed.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_packed.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_packed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_packed.Caption = "Date Packed"
        Me.col_date_packed.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_packed.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_packed.FieldName = "date_packed"
        Me.col_date_packed.MinWidth = 140
        Me.col_date_packed.Name = "col_date_packed"
        Me.col_date_packed.OptionsColumn.AllowEdit = False
        Me.col_date_packed.Visible = True
        Me.col_date_packed.VisibleIndex = 13
        Me.col_date_packed.Width = 140
        '
        'col_date_released
        '
        Me.col_date_released.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_released.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_released.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_released.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_released.Caption = "Date Released"
        Me.col_date_released.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_released.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_released.FieldName = "date_released"
        Me.col_date_released.MinWidth = 140
        Me.col_date_released.Name = "col_date_released"
        Me.col_date_released.OptionsColumn.AllowEdit = False
        Me.col_date_released.Visible = True
        Me.col_date_released.VisibleIndex = 14
        Me.col_date_released.Width = 140
        '
        'col_checked_by
        '
        Me.col_checked_by.Caption = "Prepared by"
        Me.col_checked_by.FieldName = "prepared_by"
        Me.col_checked_by.MinWidth = 210
        Me.col_checked_by.Name = "col_checked_by"
        Me.col_checked_by.Visible = True
        Me.col_checked_by.VisibleIndex = 15
        Me.col_checked_by.Width = 210
        '
        'col_packed_by
        '
        Me.col_packed_by.Caption = "Organized by"
        Me.col_packed_by.FieldName = "organized_by"
        Me.col_packed_by.MinWidth = 210
        Me.col_packed_by.Name = "col_packed_by"
        Me.col_packed_by.Visible = True
        Me.col_packed_by.VisibleIndex = 17
        Me.col_packed_by.Width = 210
        '
        'col_organized_by
        '
        Me.col_organized_by.Caption = "Packed by"
        Me.col_organized_by.FieldName = "packed_by"
        Me.col_organized_by.MinWidth = 210
        Me.col_organized_by.Name = "col_organized_by"
        Me.col_organized_by.Visible = True
        Me.col_organized_by.VisibleIndex = 16
        Me.col_organized_by.Width = 210
        '
        'col_released_by
        '
        Me.col_released_by.Caption = "Released By"
        Me.col_released_by.FieldName = "released_by"
        Me.col_released_by.MinWidth = 210
        Me.col_released_by.Name = "col_released_by"
        Me.col_released_by.Visible = True
        Me.col_released_by.VisibleIndex = 18
        Me.col_released_by.Width = 210
        '
        'col_delivered_by
        '
        Me.col_delivered_by.Caption = "Delivered by"
        Me.col_delivered_by.FieldName = "delivered_by"
        Me.col_delivered_by.MinWidth = 210
        Me.col_delivered_by.Name = "col_delivered_by"
        Me.col_delivered_by.Visible = True
        Me.col_delivered_by.VisibleIndex = 19
        Me.col_delivered_by.Width = 210
        '
        'col_terms
        '
        Me.col_terms.AppearanceCell.Options.UseTextOptions = True
        Me.col_terms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.MinWidth = 70
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 20
        Me.col_terms.Width = 70
        '
        'col_dute_date
        '
        Me.col_dute_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_dute_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_dute_date.Caption = "Due Date"
        Me.col_dute_date.DisplayFormat.FormatString = "MMM dd, yyyy"
        Me.col_dute_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_dute_date.FieldName = "due_date"
        Me.col_dute_date.MinWidth = 140
        Me.col_dute_date.Name = "col_dute_date"
        Me.col_dute_date.Visible = True
        Me.col_dute_date.VisibleIndex = 21
        Me.col_dute_date.Width = 140
        '
        'col_sales_invoice
        '
        Me.col_sales_invoice.Caption = "Sales Invoice"
        Me.col_sales_invoice.MinWidth = 93
        Me.col_sales_invoice.Name = "col_sales_invoice"
        Me.col_sales_invoice.Visible = True
        Me.col_sales_invoice.VisibleIndex = 22
        Me.col_sales_invoice.Width = 93
        '
        'col_date_arranged
        '
        Me.col_date_arranged.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_arranged.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_arranged.Caption = "Date Arrange"
        Me.col_date_arranged.DisplayFormat.FormatString = "MM/dd, hh:mm tt"
        Me.col_date_arranged.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_arranged.FieldName = "date_arranged"
        Me.col_date_arranged.MinWidth = 140
        Me.col_date_arranged.Name = "col_date_arranged"
        Me.col_date_arranged.Visible = True
        Me.col_date_arranged.VisibleIndex = 12
        Me.col_date_arranged.Width = 140
        '
        'timer
        '
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(192, 38)
        Me.LabelControl1.TabIndex = 19
        Me.LabelControl1.Text = "Sales Orders"
        '
        'frm_sales_orders_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1940, 847)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_orders)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_sort_cancelled)
        Me.Controls.Add(Me.btn_sort_completed)
        Me.Controls.Add(Me.btn_order)
        Me.Controls.Add(Me.btn_sort_all)
        Me.Controls.Add(Me.btn_sort_onprocess)
        Me.Controls.Add(Me.Panel1)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_sales_orders_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Orders"
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_orders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_orders_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_order_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents timer As Timer
    Friend WithEvents col_date_packed As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_order As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_date_ordered As GridColumn
    Friend WithEvents col_date_released As GridColumn
    Friend WithEvents col_view As GridColumn
    Friend WithEvents btn_sort_completed As SimpleButton
    Friend WithEvents btn_sort_onprocess As SimpleButton
    Friend WithEvents btn_sort_all As SimpleButton
    Friend WithEvents btn_sort_cancelled As SimpleButton
    Friend WithEvents col_released_by As GridColumn
    Friend WithEvents col_packed_by As GridColumn
    Friend WithEvents col_po_ref As GridColumn
    Friend WithEvents GridColumn1 As GridColumn
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents col_checked_by As GridColumn
    Friend WithEvents col_organized_by As GridColumn
    Friend WithEvents col_terms As GridColumn
    Friend WithEvents col_dute_date As GridColumn
    Friend WithEvents col_sales_invoice As GridColumn
    Friend WithEvents col_tax_type As GridColumn
    Friend WithEvents col_date_arranged As GridColumn
    Friend WithEvents btn_view_order As RepositoryItemButtonEdit
    Friend WithEvents btn_view As RepositoryItemButtonEdit
    Friend WithEvents col_delivered_by As GridColumn
End Class
