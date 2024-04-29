Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
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
Partial Class frm_collection_payments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_payments))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.cbb_timer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.grid_cash = New DevExpress.XtraGrid.GridControl()
        Me.grid_cash_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_order_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn23 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount_due = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn24 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_cheque = New DevExpress.XtraGrid.GridControl()
        Me.grid_cheque_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn22 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn19 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn25 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grid_epay = New DevExpress.XtraGrid.GridControl()
        Me.grid_epay_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn14 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_option = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_details = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.btn_payment_history = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_terms_collection = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_chequebook = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_collection_receipts = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cash_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grid_epay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_epay_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.PictureEdit1)
        Me.Panel2.Controls.Add(Me.cbb_timer)
        Me.Panel2.Location = New System.Drawing.Point(1319, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(106, 38)
        Me.Panel2.TabIndex = 8
        '
        'PictureEdit1
        '
        Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
        Me.PictureEdit1.Location = New System.Drawing.Point(5, 10)
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
        Me.cbb_timer.Location = New System.Drawing.Point(26, 5)
        Me.cbb_timer.Name = "cbb_timer"
        Me.cbb_timer.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cbb_timer.Properties.Appearance.Options.UseFont = True
        Me.cbb_timer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_timer.Properties.Items.AddRange(New Object() {"1 min", "5 min", "10 min", "30 min"})
        Me.cbb_timer.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_timer.Size = New System.Drawing.Size(73, 28)
        Me.cbb_timer.TabIndex = 4
        '
        'grid_cash
        '
        Me.grid_cash.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_cash.Location = New System.Drawing.Point(0, 33)
        Me.grid_cash.MainView = Me.grid_cash_view
        Me.grid_cash.Name = "grid_cash"
        Me.grid_cash.Size = New System.Drawing.Size(739, 258)
        Me.grid_cash.TabIndex = 14
        Me.grid_cash.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_cash_view})
        '
        'grid_cash_view
        '
        Me.grid_cash_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_cash_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_cash_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_cash_view.Appearance.Row.Options.UseFont = True
        Me.grid_cash_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_cash_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_cash_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_cash_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_cash_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_order_id, Me.GridColumn3, Me.col_customer, Me.GridColumn4, Me.GridColumn23, Me.col_amount_due, Me.GridColumn24, Me.col_payment_status})
        Me.grid_cash_view.GridControl = Me.grid_cash
        Me.grid_cash_view.Name = "grid_cash_view"
        Me.grid_cash_view.OptionsBehavior.Editable = False
        Me.grid_cash_view.OptionsBehavior.ReadOnly = True
        Me.grid_cash_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_cash_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_order_id
        '
        Me.col_order_id.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.col_order_id.AppearanceCell.Options.UseForeColor = True
        Me.col_order_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_id.Caption = "Order ID"
        Me.col_order_id.FieldName = "order_id"
        Me.col_order_id.MaxWidth = 100
        Me.col_order_id.MinWidth = 50
        Me.col_order_id.Name = "col_order_id"
        Me.col_order_id.Visible = True
        Me.col_order_id.VisibleIndex = 0
        Me.col_order_id.Width = 70
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.Caption = "Representative"
        Me.GridColumn3.FieldName = "agent"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 85
        '
        'col_customer
        '
        Me.col_customer.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_customer.AppearanceHeader.Options.UseForeColor = True
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.MinWidth = 50
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 5
        Me.col_customer.Width = 87
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn4.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn4.Caption = "Order Date"
        Me.GridColumn4.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "date_ordered"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        Me.GridColumn4.Width = 85
        '
        'GridColumn23
        '
        Me.GridColumn23.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn23.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn23.Caption = "Ship Type"
        Me.GridColumn23.FieldName = "shipping_method"
        Me.GridColumn23.Name = "GridColumn23"
        Me.GridColumn23.Visible = True
        Me.GridColumn23.VisibleIndex = 2
        '
        'col_amount_due
        '
        Me.col_amount_due.AppearanceCell.Options.UseTextOptions = True
        Me.col_amount_due.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount_due.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_amount_due.AppearanceHeader.Options.UseForeColor = True
        Me.col_amount_due.AppearanceHeader.Options.UseTextOptions = True
        Me.col_amount_due.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount_due.Caption = "Amount"
        Me.col_amount_due.DisplayFormat.FormatString = "c2"
        Me.col_amount_due.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount_due.FieldName = "amount_due"
        Me.col_amount_due.MaxWidth = 200
        Me.col_amount_due.Name = "col_amount_due"
        Me.col_amount_due.Visible = True
        Me.col_amount_due.VisibleIndex = 7
        Me.col_amount_due.Width = 123
        '
        'GridColumn24
        '
        Me.GridColumn24.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn24.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn24.Caption = "Status"
        Me.GridColumn24.FieldName = "status"
        Me.GridColumn24.Name = "GridColumn24"
        Me.GridColumn24.Visible = True
        Me.GridColumn24.VisibleIndex = 3
        Me.GridColumn24.Width = 68
        '
        'col_payment_status
        '
        Me.col_payment_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payment_status.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_payment_status.AppearanceHeader.Options.UseForeColor = True
        Me.col_payment_status.Caption = "Payment"
        Me.col_payment_status.FieldName = "payment_status"
        Me.col_payment_status.Name = "col_payment_status"
        Me.col_payment_status.Visible = True
        Me.col_payment_status.VisibleIndex = 4
        Me.col_payment_status.Width = 82
        '
        'GunaPanel1
        '
        Me.GunaPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GunaPanel1.Location = New System.Drawing.Point(5, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(1437, 316)
        Me.GunaPanel1.TabIndex = 15
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(8, 12)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.grid_cash)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelControl2)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grid_cheque)
        Me.SplitContainer1.Panel2.Controls.Add(Me.LabelControl3)
        Me.SplitContainer1.Size = New System.Drawing.Size(1420, 291)
        Me.SplitContainer1.SplitterDistance = 744
        Me.SplitContainer1.TabIndex = 9
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl2.Appearance.Options.UseBackColor = True
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl2.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl2.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl2.Size = New System.Drawing.Size(739, 33)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "Cash Collection"
        '
        'grid_cheque
        '
        Me.grid_cheque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_cheque.Location = New System.Drawing.Point(0, 33)
        Me.grid_cheque.MainView = Me.grid_cheque_view
        Me.grid_cheque.Name = "grid_cheque"
        Me.grid_cheque.Size = New System.Drawing.Size(672, 258)
        Me.grid_cheque.TabIndex = 15
        Me.grid_cheque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_cheque_view})
        '
        'grid_cheque_view
        '
        Me.grid_cheque_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_cheque_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_cheque_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_cheque_view.Appearance.Row.Options.UseFont = True
        Me.grid_cheque_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_cheque_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_cheque_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_cheque_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_cheque_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn22, Me.GridColumn10, Me.GridColumn19, Me.GridColumn25})
        Me.grid_cheque_view.GridControl = Me.grid_cheque
        Me.grid_cheque_view.Name = "grid_cheque_view"
        Me.grid_cheque_view.OptionsBehavior.Editable = False
        Me.grid_cheque_view.OptionsBehavior.ReadOnly = True
        Me.grid_cheque_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_cheque_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn6.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn6.Caption = "Order ID"
        Me.GridColumn6.FieldName = "order_id"
        Me.GridColumn6.MaxWidth = 100
        Me.GridColumn6.MinWidth = 50
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 0
        Me.GridColumn6.Width = 70
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn7.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn7.Caption = "Representative"
        Me.GridColumn7.FieldName = "agent"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 6
        Me.GridColumn7.Width = 53
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn8.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn8.Caption = "Customer"
        Me.GridColumn8.FieldName = "customer"
        Me.GridColumn8.MinWidth = 50
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 56
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn9.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn9.Caption = "Order Date"
        Me.GridColumn9.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn9.FieldName = "date_ordered"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 1
        Me.GridColumn9.Width = 92
        '
        'GridColumn22
        '
        Me.GridColumn22.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn22.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn22.Caption = "Ship Type"
        Me.GridColumn22.FieldName = "shipping_method"
        Me.GridColumn22.Name = "GridColumn22"
        Me.GridColumn22.Visible = True
        Me.GridColumn22.VisibleIndex = 2
        Me.GridColumn22.Width = 84
        '
        'GridColumn10
        '
        Me.GridColumn10.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn10.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn10.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn10.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn10.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn10.Caption = "Amount"
        Me.GridColumn10.DisplayFormat.FormatString = "c2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "amount_due"
        Me.GridColumn10.MaxWidth = 200
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 7
        Me.GridColumn10.Width = 94
        '
        'GridColumn19
        '
        Me.GridColumn19.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn19.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn19.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn19.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn19.Caption = "Payment"
        Me.GridColumn19.FieldName = "payment_status"
        Me.GridColumn19.Name = "GridColumn19"
        Me.GridColumn19.Visible = True
        Me.GridColumn19.VisibleIndex = 4
        Me.GridColumn19.Width = 55
        '
        'GridColumn25
        '
        Me.GridColumn25.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn25.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn25.Caption = "Status"
        Me.GridColumn25.FieldName = "status"
        Me.GridColumn25.Name = "GridColumn25"
        Me.GridColumn25.Visible = True
        Me.GridColumn25.VisibleIndex = 3
        Me.GridColumn25.Width = 56
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl3.Appearance.Options.UseBackColor = True
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl3.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl3.Location = New System.Drawing.Point(0, 0)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl3.Size = New System.Drawing.Size(672, 33)
        Me.LabelControl3.TabIndex = 25
        Me.LabelControl3.Text = "Pickup / COD Cheque Collection"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(-5, 133)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.PanelControl1)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GunaPanel1)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.PanelControl2)
        Me.SplitContainer2.Panel2.Padding = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.SplitContainer2.Size = New System.Drawing.Size(1447, 570)
        Me.SplitContainer2.SplitterDistance = 316
        Me.SplitContainer2.TabIndex = 16
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.SplitContainer1)
        Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl1.Location = New System.Drawing.Point(5, 0)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1437, 316)
        Me.PanelControl1.TabIndex = 15
        '
        'PanelControl2
        '
        Me.PanelControl2.Controls.Add(Me.grid_epay)
        Me.PanelControl2.Controls.Add(Me.LabelControl4)
        Me.PanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelControl2.Location = New System.Drawing.Point(5, 0)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(1437, 250)
        Me.PanelControl2.TabIndex = 16
        '
        'grid_epay
        '
        Me.grid_epay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_epay.Location = New System.Drawing.Point(2, 35)
        Me.grid_epay.MainView = Me.grid_epay_view
        Me.grid_epay.Name = "grid_epay"
        Me.grid_epay.Size = New System.Drawing.Size(1433, 213)
        Me.grid_epay.TabIndex = 15
        Me.grid_epay.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_epay_view})
        '
        'grid_epay_view
        '
        Me.grid_epay_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_epay_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_epay_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_epay_view.Appearance.Row.Options.UseFont = True
        Me.grid_epay_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_epay_view.Appearance.SelectedRow.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_epay_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_epay_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_epay_view.Appearance.SelectedRow.Options.UseFont = True
        Me.grid_epay_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_epay_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn5, Me.GridColumn11, Me.GridColumn12, Me.GridColumn13, Me.GridColumn14, Me.col_payment_option, Me.col_payment_type, Me.col_payment_details})
        Me.grid_epay_view.GridControl = Me.grid_epay
        Me.grid_epay_view.Name = "grid_epay_view"
        Me.grid_epay_view.OptionsBehavior.Editable = False
        Me.grid_epay_view.OptionsBehavior.ReadOnly = True
        Me.grid_epay_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_epay_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'GridColumn1
        '
        Me.GridColumn1.AppearanceCell.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.GridColumn1.AppearanceCell.Options.UseForeColor = True
        Me.GridColumn1.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn1.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn1.Caption = "Order ID"
        Me.GridColumn1.FieldName = "order_id"
        Me.GridColumn1.MaxWidth = 70
        Me.GridColumn1.MinWidth = 50
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 69
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn2.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn2.Caption = "Representative"
        Me.GridColumn2.FieldName = "agent"
        Me.GridColumn2.MaxWidth = 150
        Me.GridColumn2.MinWidth = 120
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 8
        Me.GridColumn2.Width = 120
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn5.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn5.Caption = "Customer"
        Me.GridColumn5.FieldName = "customer"
        Me.GridColumn5.MaxWidth = 250
        Me.GridColumn5.MinWidth = 200
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 200
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn11.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn11.Caption = "Order Date"
        Me.GridColumn11.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn11.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn11.FieldName = "date_ordered"
        Me.GridColumn11.MaxWidth = 120
        Me.GridColumn11.MinWidth = 120
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 1
        Me.GridColumn11.Width = 120
        '
        'GridColumn12
        '
        Me.GridColumn12.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn12.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn12.Caption = "Ship Type"
        Me.GridColumn12.FieldName = "shipping_method"
        Me.GridColumn12.MaxWidth = 100
        Me.GridColumn12.MinWidth = 100
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 2
        Me.GridColumn12.Width = 100
        '
        'GridColumn13
        '
        Me.GridColumn13.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn13.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn13.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn13.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn13.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn13.Caption = "Amount"
        Me.GridColumn13.DisplayFormat.FormatString = "c2"
        Me.GridColumn13.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn13.FieldName = "amount_due"
        Me.GridColumn13.MaxWidth = 100
        Me.GridColumn13.MinWidth = 100
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 9
        Me.GridColumn13.Width = 100
        '
        'GridColumn14
        '
        Me.GridColumn14.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn14.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn14.Caption = "Status"
        Me.GridColumn14.FieldName = "status"
        Me.GridColumn14.MaxWidth = 100
        Me.GridColumn14.MinWidth = 100
        Me.GridColumn14.Name = "GridColumn14"
        Me.GridColumn14.Visible = True
        Me.GridColumn14.VisibleIndex = 3
        Me.GridColumn14.Width = 100
        '
        'col_payment_option
        '
        Me.col_payment_option.Caption = "Payment Option"
        Me.col_payment_option.FieldName = "payment_option"
        Me.col_payment_option.MaxWidth = 150
        Me.col_payment_option.MinWidth = 120
        Me.col_payment_option.Name = "col_payment_option"
        Me.col_payment_option.Visible = True
        Me.col_payment_option.VisibleIndex = 5
        Me.col_payment_option.Width = 120
        '
        'col_payment_type
        '
        Me.col_payment_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_payment_type.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_payment_type.AppearanceHeader.Options.UseForeColor = True
        Me.col_payment_type.Caption = "Payment"
        Me.col_payment_type.FieldName = "payment_status"
        Me.col_payment_type.MaxWidth = 180
        Me.col_payment_type.MinWidth = 80
        Me.col_payment_type.Name = "col_payment_type"
        Me.col_payment_type.Visible = True
        Me.col_payment_type.VisibleIndex = 4
        Me.col_payment_type.Width = 180
        '
        'col_payment_details
        '
        Me.col_payment_details.Caption = "Payment Details"
        Me.col_payment_details.FieldName = "payment_details"
        Me.col_payment_details.Name = "col_payment_details"
        Me.col_payment_details.Visible = True
        Me.col_payment_details.VisibleIndex = 6
        Me.col_payment_details.Width = 59
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl4.Appearance.Options.UseBackColor = True
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl4.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl4.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl4.Size = New System.Drawing.Size(1433, 33)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "E-Payment Collection"
        '
        'timer
        '
        '
        'btn_payment_history
        '
        Me.btn_payment_history.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_payment_history.Appearance.Options.UseFont = True
        Me.btn_payment_history.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.article_32x32
        Me.btn_payment_history.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_payment_history.ImageOptions.ImageToTextIndent = 7
        Me.btn_payment_history.Location = New System.Drawing.Point(19, 69)
        Me.btn_payment_history.Name = "btn_payment_history"
        Me.btn_payment_history.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_payment_history.Size = New System.Drawing.Size(160, 46)
        Me.btn_payment_history.TabIndex = 17
        Me.btn_payment_history.Text = "Payment Ledger"
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_refresh.Location = New System.Drawing.Point(1263, 69)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 18
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_terms_collection
        '
        Me.btn_terms_collection.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_terms_collection.Appearance.Options.UseFont = True
        Me.btn_terms_collection.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.insertheader_32x32
        Me.btn_terms_collection.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_terms_collection.ImageOptions.ImageToTextIndent = 7
        Me.btn_terms_collection.Location = New System.Drawing.Point(185, 69)
        Me.btn_terms_collection.Name = "btn_terms_collection"
        Me.btn_terms_collection.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_terms_collection.Size = New System.Drawing.Size(160, 46)
        Me.btn_terms_collection.TabIndex = 19
        Me.btn_terms_collection.Text = "Terms Collection"
        '
        'btn_chequebook
        '
        Me.btn_chequebook.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_chequebook.Appearance.Options.UseFont = True
        Me.btn_chequebook.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.financial_32x32
        Me.btn_chequebook.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_chequebook.ImageOptions.ImageToTextIndent = 7
        Me.btn_chequebook.Location = New System.Drawing.Point(351, 70)
        Me.btn_chequebook.Name = "btn_chequebook"
        Me.btn_chequebook.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_chequebook.Size = New System.Drawing.Size(160, 46)
        Me.btn_chequebook.TabIndex = 21
        Me.btn_chequebook.Text = "Cheque Book"
        '
        'btn_collection_receipts
        '
        Me.btn_collection_receipts.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_collection_receipts.Appearance.Options.UseFont = True
        Me.btn_collection_receipts.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.text_32x32
        Me.btn_collection_receipts.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_collection_receipts.ImageOptions.ImageToTextIndent = 7
        Me.btn_collection_receipts.Location = New System.Drawing.Point(517, 69)
        Me.btn_collection_receipts.Name = "btn_collection_receipts"
        Me.btn_collection_receipts.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_collection_receipts.Size = New System.Drawing.Size(160, 46)
        Me.btn_collection_receipts.TabIndex = 22
        Me.btn_collection_receipts.Text = "Collection Receipts"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(196, 31)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "Order Collection"
        '
        'frm_collection_payments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1435, 697)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btn_collection_receipts)
        Me.Controls.Add(Me.btn_chequebook)
        Me.Controls.Add(Me.btn_terms_collection)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_payment_history)
        Me.Controls.Add(Me.SplitContainer2)
        Me.KeyPreview = True
        Me.Name = "frm_collection_payments"
        Me.Text = "Order Collection"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_timer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cash_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.grid_epay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_epay_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_cash As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_cash_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_order_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount_due As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn14 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn15 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn16 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn17 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn20 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn21 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents grid_cheque As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_cheque_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn19 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn22 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn23 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn24 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents GridColumn25 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn26 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn27 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents cbb_timer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents timer As Timer
    Friend WithEvents btn_payment_history As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_epay As GridControl
    Friend WithEvents grid_epay_view As GridView
    Friend WithEvents GridColumn1 As GridColumn
    Friend WithEvents GridColumn2 As GridColumn
    Friend WithEvents GridColumn5 As GridColumn
    Friend WithEvents col_payment_option As GridColumn
    Friend WithEvents col_payment_type As GridColumn
    Friend WithEvents col_payment_details As GridColumn
    Friend WithEvents btn_terms_collection As SimpleButton
    Friend WithEvents btn_chequebook As SimpleButton
    Friend WithEvents btn_collection_receipts As SimpleButton
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
End Class
