<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_price_book
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
        Me.grid_pricebooks = New DevExpress.XtraGrid.GridControl()
        Me.grid_pricebooks_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_base_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_srp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_srp_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_net_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_net_price_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_net_dealer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_net_dealer_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_net_vip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_net_vip_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_matrix_regular = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_matrix_regular_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_matrix_dealer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_matrix_dealer_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_matrix_vip = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_matrix_vip_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemTextEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_find = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_show_margin = New DevExpress.XtraEditors.CheckButton()
        CType(Me.grid_pricebooks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_pricebooks_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_pricebooks
        '
        Me.grid_pricebooks.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_pricebooks.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_pricebooks.Location = New System.Drawing.Point(13, 79)
        Me.grid_pricebooks.MainView = Me.grid_pricebooks_view
        Me.grid_pricebooks.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_pricebooks.Name = "grid_pricebooks"
        Me.grid_pricebooks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemTextEdit1})
        Me.grid_pricebooks.Size = New System.Drawing.Size(1495, 745)
        Me.grid_pricebooks.TabIndex = 12
        Me.grid_pricebooks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_pricebooks_view})
        '
        'grid_pricebooks_view
        '
        Me.grid_pricebooks_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_pricebooks_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_pricebooks_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_pricebooks_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_pricebooks_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_pricebooks_view.Appearance.Row.Options.UseFont = True
        Me.grid_pricebooks_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_model, Me.col_action, Me.col_main_category, Me.col_sub_category, Me.col_brand, Me.col_base_price, Me.col_cost, Me.col_discount, Me.col_srp, Me.col_srp_margin, Me.col_net_price, Me.col_net_price_margin, Me.col_net_dealer, Me.col_net_dealer_margin, Me.col_net_vip, Me.col_net_vip_margin, Me.col_matrix_regular, Me.col_matrix_regular_margin, Me.col_matrix_dealer, Me.col_matrix_dealer_margin, Me.col_matrix_vip, Me.col_matrix_vip_margin, Me.col_status})
        Me.grid_pricebooks_view.DetailHeight = 431
        Me.grid_pricebooks_view.GridControl = Me.grid_pricebooks
        Me.grid_pricebooks_view.Name = "grid_pricebooks_view"
        Me.grid_pricebooks_view.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.grid_pricebooks_view.OptionsPrint.PrintHorzLines = False
        Me.grid_pricebooks_view.OptionsPrint.PrintVertLines = False
        Me.grid_pricebooks_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect
        Me.grid_pricebooks_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_pricebooks_view.OptionsView.ColumnAutoWidth = False
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.OptionsColumn.AllowFocus = False
        Me.col_pid.OptionsColumn.ReadOnly = True
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 91
        '
        'col_model
        '
        Me.col_model.AppearanceCell.Options.UseTextOptions = True
        Me.col_model.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MinWidth = 23
        Me.col_model.Name = "col_model"
        Me.col_model.OptionsColumn.AllowFocus = False
        Me.col_model.OptionsColumn.ReadOnly = True
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 1
        Me.col_model.Width = 127
        '
        'col_action
        '
        Me.col_action.Caption = "Description"
        Me.col_action.FieldName = "description"
        Me.col_action.MinWidth = 23
        Me.col_action.Name = "col_action"
        Me.col_action.OptionsColumn.AllowFocus = False
        Me.col_action.OptionsColumn.ReadOnly = True
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 2
        Me.col_action.Width = 344
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Main Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.MinWidth = 23
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.OptionsColumn.AllowFocus = False
        Me.col_main_category.OptionsColumn.ReadOnly = True
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 3
        Me.col_main_category.Width = 118
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.MinWidth = 23
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.OptionsColumn.AllowFocus = False
        Me.col_sub_category.OptionsColumn.ReadOnly = True
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 4
        Me.col_sub_category.Width = 111
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.MinWidth = 23
        Me.col_brand.Name = "col_brand"
        Me.col_brand.OptionsColumn.AllowFocus = False
        Me.col_brand.OptionsColumn.ReadOnly = True
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 5
        Me.col_brand.Width = 78
        '
        'col_base_price
        '
        Me.col_base_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_base_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_base_price.Caption = "Base Price"
        Me.col_base_price.DisplayFormat.FormatString = "n3"
        Me.col_base_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_base_price.FieldName = "base_price"
        Me.col_base_price.MinWidth = 23
        Me.col_base_price.Name = "col_base_price"
        Me.col_base_price.Visible = True
        Me.col_base_price.VisibleIndex = 6
        Me.col_base_price.Width = 93
        '
        'col_cost
        '
        Me.col_cost.AppearanceCell.Options.UseTextOptions = True
        Me.col_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cost.Caption = "Cost"
        Me.col_cost.DisplayFormat.FormatString = "n3"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.MinWidth = 23
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 8
        Me.col_cost.Width = 91
        '
        'col_discount
        '
        Me.col_discount.AppearanceCell.Options.UseTextOptions = True
        Me.col_discount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_discount.Caption = "Disc(%)"
        Me.col_discount.FieldName = "discount"
        Me.col_discount.MinWidth = 23
        Me.col_discount.Name = "col_discount"
        Me.col_discount.Visible = True
        Me.col_discount.VisibleIndex = 7
        Me.col_discount.Width = 92
        '
        'col_srp
        '
        Me.col_srp.AppearanceCell.Options.UseTextOptions = True
        Me.col_srp.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_srp.Caption = "SRP"
        Me.col_srp.FieldName = "regular_price"
        Me.col_srp.MinWidth = 23
        Me.col_srp.Name = "col_srp"
        Me.col_srp.Visible = True
        Me.col_srp.VisibleIndex = 9
        Me.col_srp.Width = 87
        '
        'col_srp_margin
        '
        Me.col_srp_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_srp_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_srp_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_srp_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srp_margin.Caption = "SRP Margin"
        Me.col_srp_margin.DisplayFormat.FormatString = "P0"
        Me.col_srp_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_srp_margin.FieldName = "srp_margin"
        Me.col_srp_margin.MinWidth = 23
        Me.col_srp_margin.Name = "col_srp_margin"
        Me.col_srp_margin.OptionsColumn.AllowEdit = False
        Me.col_srp_margin.Visible = True
        Me.col_srp_margin.VisibleIndex = 10
        Me.col_srp_margin.Width = 117
        '
        'col_net_price
        '
        Me.col_net_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_net_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_net_price.Caption = "NET Regular"
        Me.col_net_price.DisplayFormat.FormatString = "n3"
        Me.col_net_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_net_price.FieldName = "net_regular"
        Me.col_net_price.MinWidth = 23
        Me.col_net_price.Name = "col_net_price"
        Me.col_net_price.Visible = True
        Me.col_net_price.VisibleIndex = 11
        Me.col_net_price.Width = 117
        '
        'col_net_price_margin
        '
        Me.col_net_price_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_net_price_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_net_price_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_net_price_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_net_price_margin.Caption = "NET Regular Margin"
        Me.col_net_price_margin.DisplayFormat.FormatString = "P0"
        Me.col_net_price_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_net_price_margin.FieldName = "regular_margin"
        Me.col_net_price_margin.MinWidth = 23
        Me.col_net_price_margin.Name = "col_net_price_margin"
        Me.col_net_price_margin.OptionsColumn.AllowEdit = False
        Me.col_net_price_margin.Visible = True
        Me.col_net_price_margin.VisibleIndex = 12
        Me.col_net_price_margin.Width = 152
        '
        'col_net_dealer
        '
        Me.col_net_dealer.AppearanceCell.Options.UseTextOptions = True
        Me.col_net_dealer.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_net_dealer.Caption = "NET Dealer"
        Me.col_net_dealer.DisplayFormat.FormatString = "n3"
        Me.col_net_dealer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_net_dealer.FieldName = "net_dealer"
        Me.col_net_dealer.MinWidth = 23
        Me.col_net_dealer.Name = "col_net_dealer"
        Me.col_net_dealer.Visible = True
        Me.col_net_dealer.VisibleIndex = 13
        Me.col_net_dealer.Width = 104
        '
        'col_net_dealer_margin
        '
        Me.col_net_dealer_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_net_dealer_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_net_dealer_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_net_dealer_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_net_dealer_margin.Caption = "NET Dealer Margin"
        Me.col_net_dealer_margin.DisplayFormat.FormatString = "P0"
        Me.col_net_dealer_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_net_dealer_margin.FieldName = "dealer_margin"
        Me.col_net_dealer_margin.MinWidth = 23
        Me.col_net_dealer_margin.Name = "col_net_dealer_margin"
        Me.col_net_dealer_margin.OptionsColumn.AllowEdit = False
        Me.col_net_dealer_margin.Visible = True
        Me.col_net_dealer_margin.VisibleIndex = 14
        Me.col_net_dealer_margin.Width = 152
        '
        'col_net_vip
        '
        Me.col_net_vip.AppearanceCell.Options.UseTextOptions = True
        Me.col_net_vip.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_net_vip.Caption = "NET VIP"
        Me.col_net_vip.DisplayFormat.FormatString = "n3"
        Me.col_net_vip.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_net_vip.FieldName = "net_vip"
        Me.col_net_vip.MinWidth = 23
        Me.col_net_vip.Name = "col_net_vip"
        Me.col_net_vip.Visible = True
        Me.col_net_vip.VisibleIndex = 15
        Me.col_net_vip.Width = 103
        '
        'col_net_vip_margin
        '
        Me.col_net_vip_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_net_vip_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_net_vip_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_net_vip_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_net_vip_margin.Caption = "NET VIP Margin"
        Me.col_net_vip_margin.DisplayFormat.FormatString = "P0"
        Me.col_net_vip_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_net_vip_margin.FieldName = "vip_margin"
        Me.col_net_vip_margin.MinWidth = 23
        Me.col_net_vip_margin.Name = "col_net_vip_margin"
        Me.col_net_vip_margin.OptionsColumn.AllowEdit = False
        Me.col_net_vip_margin.Visible = True
        Me.col_net_vip_margin.VisibleIndex = 16
        Me.col_net_vip_margin.Width = 152
        '
        'col_matrix_regular
        '
        Me.col_matrix_regular.Caption = "M. Regular"
        Me.col_matrix_regular.DisplayFormat.FormatString = "n3"
        Me.col_matrix_regular.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_matrix_regular.FieldName = "matrix_regular"
        Me.col_matrix_regular.MinWidth = 23
        Me.col_matrix_regular.Name = "col_matrix_regular"
        Me.col_matrix_regular.OptionsColumn.AllowEdit = False
        Me.col_matrix_regular.Visible = True
        Me.col_matrix_regular.VisibleIndex = 17
        Me.col_matrix_regular.Width = 105
        '
        'col_matrix_regular_margin
        '
        Me.col_matrix_regular_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_matrix_regular_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_matrix_regular_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_matrix_regular_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_matrix_regular_margin.Caption = "M. Regular Margin"
        Me.col_matrix_regular_margin.DisplayFormat.FormatString = "P0"
        Me.col_matrix_regular_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_matrix_regular_margin.FieldName = "matrix_regular_margin"
        Me.col_matrix_regular_margin.MinWidth = 23
        Me.col_matrix_regular_margin.Name = "col_matrix_regular_margin"
        Me.col_matrix_regular_margin.OptionsColumn.AllowEdit = False
        Me.col_matrix_regular_margin.Visible = True
        Me.col_matrix_regular_margin.VisibleIndex = 18
        Me.col_matrix_regular_margin.Width = 117
        '
        'col_matrix_dealer
        '
        Me.col_matrix_dealer.Caption = "M. Dealer"
        Me.col_matrix_dealer.DisplayFormat.FormatString = "n3"
        Me.col_matrix_dealer.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_matrix_dealer.FieldName = "matrix_dealer"
        Me.col_matrix_dealer.MinWidth = 23
        Me.col_matrix_dealer.Name = "col_matrix_dealer"
        Me.col_matrix_dealer.OptionsColumn.AllowEdit = False
        Me.col_matrix_dealer.Visible = True
        Me.col_matrix_dealer.VisibleIndex = 19
        Me.col_matrix_dealer.Width = 105
        '
        'col_matrix_dealer_margin
        '
        Me.col_matrix_dealer_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_matrix_dealer_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_matrix_dealer_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_matrix_dealer_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_matrix_dealer_margin.Caption = "M. Dealer Margin"
        Me.col_matrix_dealer_margin.DisplayFormat.FormatString = "P0"
        Me.col_matrix_dealer_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_matrix_dealer_margin.FieldName = "matrix_dealer_margin"
        Me.col_matrix_dealer_margin.MinWidth = 23
        Me.col_matrix_dealer_margin.Name = "col_matrix_dealer_margin"
        Me.col_matrix_dealer_margin.OptionsColumn.AllowEdit = False
        Me.col_matrix_dealer_margin.Visible = True
        Me.col_matrix_dealer_margin.VisibleIndex = 20
        Me.col_matrix_dealer_margin.Width = 117
        '
        'col_matrix_vip
        '
        Me.col_matrix_vip.Caption = "M. VIP"
        Me.col_matrix_vip.DisplayFormat.FormatString = "n3"
        Me.col_matrix_vip.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_matrix_vip.FieldName = "matrix_vip"
        Me.col_matrix_vip.MinWidth = 23
        Me.col_matrix_vip.Name = "col_matrix_vip"
        Me.col_matrix_vip.OptionsColumn.AllowEdit = False
        Me.col_matrix_vip.Visible = True
        Me.col_matrix_vip.VisibleIndex = 21
        Me.col_matrix_vip.Width = 105
        '
        'col_matrix_vip_margin
        '
        Me.col_matrix_vip_margin.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.col_matrix_vip_margin.AppearanceCell.Options.UseBackColor = True
        Me.col_matrix_vip_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_matrix_vip_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_matrix_vip_margin.Caption = "M. VIP Margin"
        Me.col_matrix_vip_margin.DisplayFormat.FormatString = "P0"
        Me.col_matrix_vip_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_matrix_vip_margin.FieldName = "matrix_vip_margin"
        Me.col_matrix_vip_margin.MinWidth = 23
        Me.col_matrix_vip_margin.Name = "col_matrix_vip_margin"
        Me.col_matrix_vip_margin.OptionsColumn.AllowEdit = False
        Me.col_matrix_vip_margin.Visible = True
        Me.col_matrix_vip_margin.VisibleIndex = 22
        Me.col_matrix_vip_margin.Width = 117
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Width = 87
        '
        'RepositoryItemTextEdit1
        '
        Me.RepositoryItemTextEdit1.AutoHeight = False
        Me.RepositoryItemTextEdit1.Name = "RepositoryItemTextEdit1"
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
        Me.LabelControl1.Size = New System.Drawing.Size(159, 38)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Price Book"
        '
        'btn_find
        '
        Me.btn_find.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_find.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_find.Appearance.Options.UseFont = True
        Me.btn_find.Appearance.Options.UseTextOptions = True
        Me.btn_find.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_find.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_find.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_find.ImageOptions.ImageToTextIndent = 5
        Me.btn_find.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.enablesearch
        Me.btn_find.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_find.Location = New System.Drawing.Point(1641, 15)
        Me.btn_find.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_find.Name = "btn_find"
        Me.btn_find.Size = New System.Drawing.Size(187, 57)
        Me.btn_find.TabIndex = 21
        Me.btn_find.Text = "Find Below Cost"
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.btn_export.Appearance.Options.UseFont = True
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 5
        Me.btn_export.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.exporttoxls
        Me.btn_export.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export.Location = New System.Drawing.Point(1321, 15)
        Me.btn_export.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(187, 57)
        Me.btn_export.TabIndex = 22
        Me.btn_export.Text = "Export"
        '
        'btn_show_margin
        '
        Me.btn_show_margin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_show_margin.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_show_margin.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.showcontainerheader
        Me.btn_show_margin.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_show_margin.Location = New System.Drawing.Point(1127, 16)
        Me.btn_show_margin.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_show_margin.Name = "btn_show_margin"
        Me.btn_show_margin.Size = New System.Drawing.Size(187, 57)
        Me.btn_show_margin.TabIndex = 24
        Me.btn_show_margin.Text = "Show Margins"
        '
        'frm_admin_price_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1521, 837)
        Me.Controls.Add(Me.btn_show_margin)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_find)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_pricebooks)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_admin_price_book"
        Me.Text = "Price Book"
        CType(Me.grid_pricebooks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_pricebooks_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemTextEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_pricebooks As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_pricebooks_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_base_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemTextEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTextEdit
    Friend WithEvents col_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_net_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_net_vip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_net_dealer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_matrix_dealer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_matrix_vip As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_find As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_matrix_regular As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_srp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_srp_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_net_price_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_net_dealer_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_net_vip_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_show_margin As DevExpress.XtraEditors.CheckButton
    Friend WithEvents col_matrix_regular_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_matrix_dealer_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_matrix_vip_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
End Class
