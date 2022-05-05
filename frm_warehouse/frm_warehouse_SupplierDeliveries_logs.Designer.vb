Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports System.ComponentModel
Imports System.Drawing.Drawing2D


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_SupplierDeliveries_logs
    Inherits System.Windows.Forms.Form

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
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_supplier_deliveries = New DevExpress.XtraGrid.GridControl()
        Me.grid_supplier_deliveries_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_timestamp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dt_edit_date = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_reference = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dt_end = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_view = New Guna.UI.WinForms.GunaButton()
        Me.dt_start = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaButton1 = New Guna.UI.WinForms.GunaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_generate_barcode = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_supplier_deliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_supplier_deliveries_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_edit_date, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_edit_date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1268, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.link_po_list)
        Me.GunaPanel1.Controls.Add(Me.LabelControl7)
        Me.GunaPanel1.Controls.Add(Me.link_home)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 0
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(82, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Delivery Logs"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        '
        'link_home
        '
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_home.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_home.Location = New System.Drawing.Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(179, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Delivery Logs"
        '
        'grid_supplier_deliveries
        '
        Me.grid_supplier_deliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_supplier_deliveries.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_supplier_deliveries.Location = New System.Drawing.Point(12, 148)
        Me.grid_supplier_deliveries.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_supplier_deliveries.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_supplier_deliveries.MainView = Me.grid_supplier_deliveries_view
        Me.grid_supplier_deliveries.Name = "grid_supplier_deliveries"
        Me.grid_supplier_deliveries.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.dt_edit_date})
        Me.grid_supplier_deliveries.Size = New System.Drawing.Size(1275, 476)
        Me.grid_supplier_deliveries.TabIndex = 11
        Me.grid_supplier_deliveries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_supplier_deliveries_view})
        '
        'grid_supplier_deliveries_view
        '
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_supplier_deliveries_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_supplier_deliveries_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_supplier_deliveries_view.Appearance.Row.Options.UseFont = True
        Me.grid_supplier_deliveries_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.col_action, Me.GridColumn4, Me.col_timestamp, Me.GridColumn5, Me.col_supplier, Me.col_description, Me.col_cost, Me.col_reference, Me.col_id})
        Me.grid_supplier_deliveries_view.GridControl = Me.grid_supplier_deliveries
        Me.grid_supplier_deliveries_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_supplier_deliveries_view.Name = "grid_supplier_deliveries_view"
        Me.grid_supplier_deliveries_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_supplier_deliveries_view.OptionsView.AutoCalcPreviewLineCount = True
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Model"
        Me.GridColumn2.FieldName = "winmodel"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.ReadOnly = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 2
        Me.GridColumn2.Width = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn3.Caption = "Qty"
        Me.GridColumn3.FieldName = "qty"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 72
        '
        'col_action
        '
        Me.col_action.Caption = "Warehouse"
        Me.col_action.FieldName = "store_name"
        Me.col_action.MaxWidth = 250
        Me.col_action.MinWidth = 150
        Me.col_action.Name = "col_action"
        Me.col_action.OptionsColumn.ReadOnly = True
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 5
        Me.col_action.Width = 180
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Purchase ID"
        Me.GridColumn4.FieldName = "poid"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 7
        Me.GridColumn4.Width = 78
        '
        'col_timestamp
        '
        Me.col_timestamp.AppearanceCell.Options.UseTextOptions = True
        Me.col_timestamp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_timestamp.Caption = "Timestamp"
        Me.col_timestamp.ColumnEdit = Me.dt_edit_date
        Me.col_timestamp.DisplayFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.col_timestamp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_timestamp.FieldName = "date_received"
        Me.col_timestamp.Name = "col_timestamp"
        Me.col_timestamp.OptionsColumn.ReadOnly = True
        Me.col_timestamp.Visible = True
        Me.col_timestamp.VisibleIndex = 0
        Me.col_timestamp.Width = 129
        '
        'dt_edit_date
        '
        Me.dt_edit_date.AutoHeight = False
        Me.dt_edit_date.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_edit_date.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_edit_date.DisplayFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.dt_edit_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_edit_date.EditFormat.FormatString = "hh:mm tt MM/dd/yyyy"
        Me.dt_edit_date.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_edit_date.MaskSettings.Set("mask", "hh:mm tt MM/dd/yyyy")
        Me.dt_edit_date.Name = "dt_edit_date"
        Me.dt_edit_date.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Receiver"
        Me.GridColumn5.FieldName = "first_name"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.ReadOnly = True
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 9
        Me.GridColumn5.Width = 99
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 250
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.OptionsColumn.ReadOnly = True
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 6
        Me.col_supplier.Width = 262
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 250
        Me.col_description.Name = "col_description"
        Me.col_description.OptionsColumn.ReadOnly = True
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 3
        Me.col_description.Width = 268
        '
        'col_cost
        '
        Me.col_cost.Caption = "Cost"
        Me.col_cost.DisplayFormat.FormatString = "n2"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.OptionsColumn.ReadOnly = True
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 4
        Me.col_cost.Width = 89
        '
        'col_reference
        '
        Me.col_reference.Caption = "Receipt Ref."
        Me.col_reference.FieldName = "receipt_ref"
        Me.col_reference.Name = "col_reference"
        Me.col_reference.OptionsColumn.ReadOnly = True
        Me.col_reference.Visible = True
        Me.col_reference.VisibleIndex = 8
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "reference"
        Me.col_id.Name = "col_id"
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Purchase ID"
        Me.GridColumn7.FieldName = "poid"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 109
        '
        'dt_end
        '
        Me.dt_end.BackColor = System.Drawing.Color.Transparent
        Me.dt_end.BaseColor = System.Drawing.Color.White
        Me.dt_end.BorderColor = System.Drawing.Color.Silver
        Me.dt_end.BorderSize = 1
        Me.dt_end.CustomFormat = "MMMM dd, yyyy"
        Me.dt_end.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dt_end.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_end.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dt_end.ForeColor = System.Drawing.Color.Black
        Me.dt_end.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_end.Location = New System.Drawing.Point(259, 106)
        Me.dt_end.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_end.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.OnHoverBaseColor = System.Drawing.Color.White
        Me.dt_end.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_end.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_end.OnPressedColor = System.Drawing.Color.Black
        Me.dt_end.Size = New System.Drawing.Size(152, 30)
        Me.dt_end.TabIndex = 23
        Me.dt_end.Text = "October 20, 2020"
        Me.dt_end.Value = New Date(2020, 10, 20, 10, 38, 39, 28)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(242, 113)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(11, 16)
        Me.LabelControl2.TabIndex = 22
        Me.LabelControl2.Text = "to"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 113)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Coverage:"
        '
        'btn_view
        '
        Me.btn_view.AnimationHoverSpeed = 0.07!
        Me.btn_view.AnimationSpeed = 0.03!
        Me.btn_view.BackColor = System.Drawing.Color.Transparent
        Me.btn_view.BaseColor = System.Drawing.Color.Gray
        Me.btn_view.BorderColor = System.Drawing.Color.Gray
        Me.btn_view.BorderSize = 1
        Me.btn_view.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btn_view.FocusedColor = System.Drawing.Color.Empty
        Me.btn_view.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_view.ForeColor = System.Drawing.Color.White
        Me.btn_view.Image = Nothing
        Me.btn_view.ImageSize = New System.Drawing.Size(20, 20)
        Me.btn_view.Location = New System.Drawing.Point(417, 107)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btn_view.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.btn_view.OnHoverForeColor = System.Drawing.Color.White
        Me.btn_view.OnHoverImage = Nothing
        Me.btn_view.OnPressedColor = System.Drawing.Color.Black
        Me.btn_view.Radius = 2
        Me.btn_view.Size = New System.Drawing.Size(103, 28)
        Me.btn_view.TabIndex = 20
        Me.btn_view.Text = "View"
        Me.btn_view.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dt_start
        '
        Me.dt_start.BackColor = System.Drawing.Color.Transparent
        Me.dt_start.BaseColor = System.Drawing.Color.White
        Me.dt_start.BorderColor = System.Drawing.Color.Silver
        Me.dt_start.BorderSize = 1
        Me.dt_start.CustomFormat = "MMMM dd, yyyy"
        Me.dt_start.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dt_start.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.dt_start.ForeColor = System.Drawing.Color.Black
        Me.dt_start.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_start.Location = New System.Drawing.Point(79, 106)
        Me.dt_start.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dt_start.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.OnHoverBaseColor = System.Drawing.Color.White
        Me.dt_start.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_start.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dt_start.OnPressedColor = System.Drawing.Color.Black
        Me.dt_start.Size = New System.Drawing.Size(157, 30)
        Me.dt_start.TabIndex = 19
        Me.dt_start.Text = "October 20, 2020"
        Me.dt_start.Value = New Date(2020, 10, 20, 11, 17, 55, 279)
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.export_32x32
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(1164, 95)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(123, 46)
        Me.btn_print.TabIndex = 24
        Me.btn_print.Text = "Export"
        '
        'GunaButton1
        '
        Me.GunaButton1.AnimationHoverSpeed = 0.07!
        Me.GunaButton1.AnimationSpeed = 0.03!
        Me.GunaButton1.BackColor = System.Drawing.Color.Transparent
        Me.GunaButton1.BaseColor = System.Drawing.Color.Gray
        Me.GunaButton1.BorderColor = System.Drawing.Color.Gray
        Me.GunaButton1.BorderSize = 1
        Me.GunaButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.GunaButton1.ForeColor = System.Drawing.Color.White
        Me.GunaButton1.Image = Nothing
        Me.GunaButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaButton1.Location = New System.Drawing.Point(526, 108)
        Me.GunaButton1.Name = "GunaButton1"
        Me.GunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaButton1.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaButton1.OnHoverImage = Nothing
        Me.GunaButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaButton1.Radius = 2
        Me.GunaButton1.Size = New System.Drawing.Size(103, 28)
        Me.GunaButton1.TabIndex = 25
        Me.GunaButton1.Text = "Checker"
        Me.GunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.GunaButton1.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.GhostWhite
        Me.Panel1.Controls.Add(Me.GunaLabel2)
        Me.Panel1.Controls.Add(Me.GunaPanel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1299, 78)
        Me.Panel1.TabIndex = 55
        '
        'btn_generate_barcode
        '
        Me.btn_generate_barcode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate_barcode.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate_barcode.Appearance.Options.UseFont = True
        Me.btn_generate_barcode.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.barcode_32x32
        Me.btn_generate_barcode.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_generate_barcode.ImageOptions.ImageToTextIndent = 5
        Me.btn_generate_barcode.Location = New System.Drawing.Point(986, 95)
        Me.btn_generate_barcode.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_generate_barcode.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_generate_barcode.Name = "btn_generate_barcode"
        Me.btn_generate_barcode.Size = New System.Drawing.Size(172, 46)
        Me.btn_generate_barcode.TabIndex = 56
        Me.btn_generate_barcode.Text = "Generate Barcode"
        '
        'frm_warehouse_SupplierDeliveries_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1299, 636)
        Me.Controls.Add(Me.btn_generate_barcode)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaButton1)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.grid_supplier_deliveries)
        Me.Name = "frm_warehouse_SupplierDeliveries_logs"
        Me.Text = "frm_delivery_logs"
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_supplier_deliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_supplier_deliveries_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_edit_date.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_edit_date, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_supplier_deliveries As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_supplier_deliveries_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_timestamp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dt_end As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_view As Guna.UI.WinForms.GunaButton
    Friend WithEvents dt_start As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents col_supplier As GridColumn
    Friend WithEvents col_description As GridColumn
    Friend WithEvents col_cost As GridColumn
    Friend WithEvents btn_print As SimpleButton
    Friend WithEvents col_reference As GridColumn
    Friend WithEvents GunaButton1 As GunaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dt_edit_date As RepositoryItemDateEdit
    Friend WithEvents col_id As GridColumn
    Friend WithEvents btn_generate_barcode As SimpleButton
End Class
