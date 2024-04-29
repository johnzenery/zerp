<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_view_transaction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accounting_view_transaction))
        Me.grid_transaction = New DevExpress.XtraGrid.GridControl()
        Me.grid_transaction_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_base_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.dtp_received_date = New System.Windows.Forms.DateTimePicker()
        Me.txt_counted_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_encoded_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_purchaseID = New DevExpress.XtraEditors.TextEdit()
        Me.txt_supplier = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_dr_date = New DevExpress.XtraEditors.DateEdit()
        Me.dt_si_date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dr_no = New DevExpress.XtraEditors.TextEdit()
        Me.txt_si_no = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_terms = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_discount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_credit = New DevExpress.XtraEditors.LabelControl()
        Me.txt_sub_total = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_ewt = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_vat = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_vatables_sales = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_12_vat = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_receipt_id = New DevExpress.XtraEditors.LabelControl()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_sales = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.txt_total = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl2 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lbl_amount = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl3 = New DevExpress.XtraEditors.SeparatorControl()
        Me.lbl_purchase_id = New DevExpress.XtraEditors.LabelControl()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transaction_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_counted_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_encoded_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_purchaseID.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.dt_dr_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_dr_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_si_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_si_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dr_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_si_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_transaction
        '
        Me.grid_transaction.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transaction.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_transaction.Location = New System.Drawing.Point(14, 229)
        Me.grid_transaction.MainView = Me.grid_transaction_view
        Me.grid_transaction.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_transaction.Name = "grid_transaction"
        Me.grid_transaction.Size = New System.Drawing.Size(1500, 393)
        Me.grid_transaction.TabIndex = 13
        Me.grid_transaction.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transaction_view})
        '
        'grid_transaction_view
        '
        Me.grid_transaction_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_transaction_view.Appearance.Row.Options.UseFont = True
        Me.grid_transaction_view.AutoFillColumn = Me.col_description
        Me.grid_transaction_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_supmodel, Me.col_description, Me.col_cost, Me.col_total_cost, Me.col_base_price, Me.col_discount})
        Me.grid_transaction_view.DetailHeight = 431
        Me.grid_transaction_view.GridControl = Me.grid_transaction
        Me.grid_transaction_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_transaction_view.Name = "grid_transaction_view"
        Me.grid_transaction_view.OptionsBehavior.ReadOnly = True
        Me.grid_transaction_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_transaction_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_transaction_view.OptionsView.ColumnAutoWidth = False
        Me.grid_transaction_view.OptionsView.RowAutoHeight = True
        '
        'col_description
        '
        Me.col_description.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_description.AppearanceCell.Options.UseBackColor = True
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 23
        Me.col_description.Name = "col_description"
        Me.col_description.OptionsColumn.AllowEdit = False
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 4
        Me.col_description.Width = 518
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "reference"
        Me.col_id.MinWidth = 23
        Me.col_id.Name = "col_id"
        Me.col_id.Width = 87
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Qty"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 1
        Me.col_pid.Width = 87
        '
        'col_winmodel
        '
        Me.col_winmodel.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_winmodel.AppearanceCell.Options.UseBackColor = True
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.OptionsColumn.AllowEdit = False
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 2
        Me.col_winmodel.Width = 173
        '
        'col_supmodel
        '
        Me.col_supmodel.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_supmodel.AppearanceCell.Options.UseBackColor = True
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.OptionsColumn.AllowEdit = False
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 3
        Me.col_supmodel.Width = 189
        '
        'col_cost
        '
        Me.col_cost.Caption = "Item Cost"
        Me.col_cost.DisplayFormat.FormatString = "c2"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "cost"
        Me.col_cost.MinWidth = 23
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 7
        Me.col_cost.Width = 117
        '
        'col_total_cost
        '
        Me.col_total_cost.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_total_cost.AppearanceCell.Options.UseBackColor = True
        Me.col_total_cost.Caption = "Total Cost"
        Me.col_total_cost.DisplayFormat.FormatString = "c3"
        Me.col_total_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_cost.FieldName = "total_cost"
        Me.col_total_cost.MinWidth = 23
        Me.col_total_cost.Name = "col_total_cost"
        Me.col_total_cost.OptionsColumn.AllowEdit = False
        Me.col_total_cost.Visible = True
        Me.col_total_cost.VisibleIndex = 8
        Me.col_total_cost.Width = 127
        '
        'col_base_price
        '
        Me.col_base_price.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_base_price.AppearanceCell.Options.UseBackColor = True
        Me.col_base_price.Caption = "Base Price"
        Me.col_base_price.DisplayFormat.FormatString = "n2"
        Me.col_base_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_base_price.FieldName = "base_price"
        Me.col_base_price.MinWidth = 23
        Me.col_base_price.Name = "col_base_price"
        Me.col_base_price.OptionsColumn.AllowEdit = False
        Me.col_base_price.Visible = True
        Me.col_base_price.VisibleIndex = 5
        Me.col_base_price.Width = 105
        '
        'col_discount
        '
        Me.col_discount.AppearanceCell.BackColor = System.Drawing.Color.Lavender
        Me.col_discount.AppearanceCell.Options.UseBackColor = True
        Me.col_discount.Caption = "Discount"
        Me.col_discount.FieldName = "discount"
        Me.col_discount.MinWidth = 23
        Me.col_discount.Name = "col_discount"
        Me.col_discount.OptionsColumn.AllowEdit = False
        Me.col_discount.Visible = True
        Me.col_discount.VisibleIndex = 6
        Me.col_discount.Width = 87
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Cheque No."
        Me.GridColumn1.FieldName = "payment_cheque"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 1
        Me.GridColumn1.Width = 148
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 98)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(56, 16)
        Me.LabelControl1.TabIndex = 15
        Me.LabelControl1.Text = "Supplier:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(20, 98)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(63, 16)
        Me.LabelControl3.TabIndex = 17
        Me.LabelControl3.Text = "Tax Type:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(19, 59)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl4.TabIndex = 18
        Me.LabelControl4.Text = "Received Date"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(19, 18)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(81, 16)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Purchase ID:"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.dtp_received_date)
        Me.PanelControl1.Controls.Add(Me.txt_counted_by)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.txt_encoded_by)
        Me.PanelControl1.Controls.Add(Me.LabelControl8)
        Me.PanelControl1.Controls.Add(Me.txt_purchaseID)
        Me.PanelControl1.Controls.Add(Me.txt_supplier)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Location = New System.Drawing.Point(14, 81)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(855, 140)
        Me.PanelControl1.TabIndex = 20
        '
        'dtp_received_date
        '
        Me.dtp_received_date.CustomFormat = "MM/dd/yyyy"
        Me.dtp_received_date.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dtp_received_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_received_date.Location = New System.Drawing.Point(132, 57)
        Me.dtp_received_date.Margin = New System.Windows.Forms.Padding(4)
        Me.dtp_received_date.Name = "dtp_received_date"
        Me.dtp_received_date.Size = New System.Drawing.Size(135, 24)
        Me.dtp_received_date.TabIndex = 29
        '
        'txt_counted_by
        '
        Me.txt_counted_by.Location = New System.Drawing.Point(638, 50)
        Me.txt_counted_by.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_counted_by.Name = "txt_counted_by"
        Me.txt_counted_by.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_counted_by.Properties.Appearance.Options.UseFont = True
        Me.txt_counted_by.Properties.ReadOnly = True
        Me.txt_counted_by.Size = New System.Drawing.Size(184, 34)
        Me.txt_counted_by.TabIndex = 28
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(538, 54)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl9.TabIndex = 27
        Me.LabelControl9.Text = "Counted by:"
        '
        'txt_encoded_by
        '
        Me.txt_encoded_by.Location = New System.Drawing.Point(638, 11)
        Me.txt_encoded_by.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_encoded_by.Name = "txt_encoded_by"
        Me.txt_encoded_by.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_encoded_by.Properties.Appearance.Options.UseFont = True
        Me.txt_encoded_by.Properties.ReadOnly = True
        Me.txt_encoded_by.Size = New System.Drawing.Size(184, 34)
        Me.txt_encoded_by.TabIndex = 26
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(538, 22)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl8.TabIndex = 25
        Me.LabelControl8.Text = "Encoded by:"
        '
        'txt_purchaseID
        '
        Me.txt_purchaseID.Location = New System.Drawing.Point(118, 11)
        Me.txt_purchaseID.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_purchaseID.Name = "txt_purchaseID"
        Me.txt_purchaseID.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_purchaseID.Properties.Appearance.Options.UseFont = True
        Me.txt_purchaseID.Properties.ReadOnly = True
        Me.txt_purchaseID.Size = New System.Drawing.Size(112, 34)
        Me.txt_purchaseID.TabIndex = 21
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(118, 95)
        Me.txt_supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_supplier.Properties.Appearance.Options.UseFont = True
        Me.txt_supplier.Properties.ReadOnly = True
        Me.txt_supplier.Size = New System.Drawing.Size(391, 34)
        Me.txt_supplier.TabIndex = 20
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl2)
        Me.PanelControl2.Controls.Add(Me.dt_dr_date)
        Me.PanelControl2.Controls.Add(Me.dt_si_date)
        Me.PanelControl2.Controls.Add(Me.LabelControl19)
        Me.PanelControl2.Controls.Add(Me.txt_dr_no)
        Me.PanelControl2.Controls.Add(Me.txt_si_no)
        Me.PanelControl2.Controls.Add(Me.cbb_type)
        Me.PanelControl2.Controls.Add(Me.txt_terms)
        Me.PanelControl2.Controls.Add(Me.LabelControl17)
        Me.PanelControl2.Controls.Add(Me.lbl_status)
        Me.PanelControl2.Controls.Add(Me.LabelControl16)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Location = New System.Drawing.Point(880, 81)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(635, 140)
        Me.PanelControl2.TabIndex = 29
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(20, 20)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(92, 16)
        Me.LabelControl2.TabIndex = 144
        Me.LabelControl2.Text = "DR No. && Date"
        '
        'dt_dr_date
        '
        Me.dt_dr_date.EditValue = Nothing
        Me.dt_dr_date.Location = New System.Drawing.Point(247, 11)
        Me.dt_dr_date.Margin = New System.Windows.Forms.Padding(4)
        Me.dt_dr_date.Name = "dt_dr_date"
        Me.dt_dr_date.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_dr_date.Properties.Appearance.Options.UseFont = True
        Me.dt_dr_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_dr_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_dr_date.Properties.DisplayFormat.FormatString = "MM/dd/yyyy "
        Me.dt_dr_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_dr_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_dr_date.Size = New System.Drawing.Size(117, 34)
        Me.dt_dr_date.TabIndex = 140
        '
        'dt_si_date
        '
        Me.dt_si_date.EditValue = Nothing
        Me.dt_si_date.Location = New System.Drawing.Point(247, 53)
        Me.dt_si_date.Margin = New System.Windows.Forms.Padding(4)
        Me.dt_si_date.Name = "dt_si_date"
        Me.dt_si_date.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_si_date.Properties.Appearance.Options.UseFont = True
        Me.dt_si_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_si_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_si_date.Properties.DisplayFormat.FormatString = "MM/dd/yyyy "
        Me.dt_si_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_si_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_si_date.Size = New System.Drawing.Size(117, 34)
        Me.dt_si_date.TabIndex = 141
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Location = New System.Drawing.Point(20, 60)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl19.TabIndex = 145
        Me.LabelControl19.Text = "SI No. && Date"
        '
        'txt_dr_no
        '
        Me.txt_dr_no.Location = New System.Drawing.Point(120, 11)
        Me.txt_dr_no.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_dr_no.Name = "txt_dr_no"
        Me.txt_dr_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_dr_no.Properties.Appearance.Options.UseFont = True
        Me.txt_dr_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_dr_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_dr_no.Size = New System.Drawing.Size(117, 34)
        Me.txt_dr_no.TabIndex = 142
        '
        'txt_si_no
        '
        Me.txt_si_no.Location = New System.Drawing.Point(120, 53)
        Me.txt_si_no.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_si_no.Name = "txt_si_no"
        Me.txt_si_no.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_si_no.Properties.Appearance.Options.UseFont = True
        Me.txt_si_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_si_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_si_no.Size = New System.Drawing.Size(117, 34)
        Me.txt_si_no.TabIndex = 143
        '
        'cbb_type
        '
        Me.cbb_type.Location = New System.Drawing.Point(120, 95)
        Me.cbb_type.Margin = New System.Windows.Forms.Padding(4)
        Me.cbb_type.Name = "cbb_type"
        Me.cbb_type.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.cbb_type.Properties.Appearance.Options.UseFont = True
        Me.cbb_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_type.Properties.Items.AddRange(New Object() {"NON-VAT", "VAT"})
        Me.cbb_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_type.Size = New System.Drawing.Size(141, 34)
        Me.cbb_type.TabIndex = 139
        '
        'txt_terms
        '
        Me.txt_terms.Location = New System.Drawing.Point(342, 95)
        Me.txt_terms.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_terms.Properties.Appearance.Options.UseFont = True
        Me.txt_terms.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_terms.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txt_terms.Size = New System.Drawing.Size(66, 34)
        Me.txt_terms.TabIndex = 30
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(288, 101)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl17.TabIndex = 29
        Me.LabelControl17.Text = "Terms"
        '
        'lbl_status
        '
        Me.lbl_status.Appearance.Font = New System.Drawing.Font("Arial", 11.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_status.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.lbl_status.Appearance.Options.UseFont = True
        Me.lbl_status.Appearance.Options.UseForeColor = True
        Me.lbl_status.Location = New System.Drawing.Point(429, 17)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(0, 24)
        Me.lbl_status.TabIndex = 28
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(378, 20)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(44, 16)
        Me.LabelControl16.TabIndex = 27
        Me.LabelControl16.Text = "Status:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!)
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Location = New System.Drawing.Point(14, 23)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(251, 42)
        Me.LabelControl10.TabIndex = 21
        Me.LabelControl10.Text = "Receipt Details"
        '
        'LabelControl6
        '
        Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(1114, 886)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(151, 27)
        Me.LabelControl6.TabIndex = 24
        Me.LabelControl6.Text = "Total Amount"
        '
        'LabelControl7
        '
        Me.LabelControl7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(1254, 847)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(54, 20)
        Me.LabelControl7.TabIndex = 27
        Me.LabelControl7.Text = "Credits"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(1186, 668)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(127, 20)
        Me.LabelControl11.TabIndex = 28
        Me.LabelControl11.Text = "Discount Applied"
        '
        'lbl_discount
        '
        Me.lbl_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_discount.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_discount.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_discount.Appearance.Options.UseFont = True
        Me.lbl_discount.Appearance.Options.UseForeColor = True
        Me.lbl_discount.Appearance.Options.UseTextOptions = True
        Me.lbl_discount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_discount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_discount.Location = New System.Drawing.Point(1328, 666)
        Me.lbl_discount.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_discount.Size = New System.Drawing.Size(187, 22)
        Me.lbl_discount.TabIndex = 29
        Me.lbl_discount.Text = "_discount"
        '
        'lbl_credit
        '
        Me.lbl_credit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_credit.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_credit.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_credit.Appearance.Options.UseFont = True
        Me.lbl_credit.Appearance.Options.UseForeColor = True
        Me.lbl_credit.Appearance.Options.UseTextOptions = True
        Me.lbl_credit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_credit.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_credit.Location = New System.Drawing.Point(1357, 847)
        Me.lbl_credit.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_credit.Name = "lbl_credit"
        Me.lbl_credit.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_credit.Size = New System.Drawing.Size(158, 18)
        Me.lbl_credit.TabIndex = 30
        Me.lbl_credit.Text = "0.00"
        '
        'txt_sub_total
        '
        Me.txt_sub_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sub_total.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.txt_sub_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_sub_total.Appearance.Options.UseFont = True
        Me.txt_sub_total.Appearance.Options.UseForeColor = True
        Me.txt_sub_total.Appearance.Options.UseTextOptions = True
        Me.txt_sub_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_sub_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_sub_total.Location = New System.Drawing.Point(1304, 635)
        Me.txt_sub_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_sub_total.Name = "txt_sub_total"
        Me.txt_sub_total.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.txt_sub_total.Size = New System.Drawing.Size(210, 23)
        Me.txt_sub_total.TabIndex = 32
        Me.txt_sub_total.Text = "0.00"
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(1238, 639)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(68, 19)
        Me.LabelControl13.TabIndex = 31
        Me.LabelControl13.Text = "Sub Total"
        '
        'lbl_ewt
        '
        Me.lbl_ewt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_ewt.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_ewt.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.lbl_ewt.Appearance.Options.UseFont = True
        Me.lbl_ewt.Appearance.Options.UseForeColor = True
        Me.lbl_ewt.Appearance.Options.UseTextOptions = True
        Me.lbl_ewt.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_ewt.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_ewt.Location = New System.Drawing.Point(1357, 791)
        Me.lbl_ewt.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_ewt.Name = "lbl_ewt"
        Me.lbl_ewt.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_ewt.Size = New System.Drawing.Size(158, 15)
        Me.lbl_ewt.TabIndex = 34
        Me.lbl_ewt.Text = "0.00"
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.Crimson
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(1227, 791)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(81, 20)
        Me.LabelControl14.TabIndex = 33
        Me.LabelControl14.Text = "Less EWT"
        '
        'LabelControl12
        '
        Me.LabelControl12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(1206, 734)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(103, 20)
        Me.LabelControl12.TabIndex = 35
        Me.LabelControl12.Text = "Vatable Sales"
        '
        'lbl_vat
        '
        Me.lbl_vat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_vat.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_vat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_vat.Appearance.Options.UseFont = True
        Me.lbl_vat.Appearance.Options.UseForeColor = True
        Me.lbl_vat.Appearance.Options.UseTextOptions = True
        Me.lbl_vat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_vat.Location = New System.Drawing.Point(1186, 764)
        Me.lbl_vat.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_vat.Name = "lbl_vat"
        Me.lbl_vat.Size = New System.Drawing.Size(120, 20)
        Me.lbl_vat.TabIndex = 36
        Me.lbl_vat.Text = "VAT"
        '
        'lbl_vatables_sales
        '
        Me.lbl_vatables_sales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_vatables_sales.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_vatables_sales.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_vatables_sales.Appearance.Options.UseFont = True
        Me.lbl_vatables_sales.Appearance.Options.UseForeColor = True
        Me.lbl_vatables_sales.Appearance.Options.UseTextOptions = True
        Me.lbl_vatables_sales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vatables_sales.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_vatables_sales.Location = New System.Drawing.Point(1357, 734)
        Me.lbl_vatables_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_vatables_sales.Name = "lbl_vatables_sales"
        Me.lbl_vatables_sales.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_vatables_sales.Size = New System.Drawing.Size(158, 22)
        Me.lbl_vatables_sales.TabIndex = 37
        Me.lbl_vatables_sales.Text = "vat_sales"
        '
        'lbl_12_vat
        '
        Me.lbl_12_vat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_12_vat.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_12_vat.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_12_vat.Appearance.Options.UseFont = True
        Me.lbl_12_vat.Appearance.Options.UseForeColor = True
        Me.lbl_12_vat.Appearance.Options.UseTextOptions = True
        Me.lbl_12_vat.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_12_vat.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_12_vat.Location = New System.Drawing.Point(1357, 762)
        Me.lbl_12_vat.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_12_vat.Name = "lbl_12_vat"
        Me.lbl_12_vat.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_12_vat.Size = New System.Drawing.Size(158, 22)
        Me.lbl_12_vat.TabIndex = 38
        Me.lbl_12_vat.Text = "%_vat_sales"
        '
        'lbl_receipt_id
        '
        Me.lbl_receipt_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_receipt_id.Location = New System.Drawing.Point(1454, 58)
        Me.lbl_receipt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_receipt_id.Name = "lbl_receipt_id"
        Me.lbl_receipt_id.Size = New System.Drawing.Size(60, 16)
        Me.lbl_receipt_id.TabIndex = 39
        Me.lbl_receipt_id.Text = "Payable ID"
        Me.lbl_receipt_id.Visible = False
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_close.Location = New System.Drawing.Point(14, 863)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(115, 41)
        Me.btn_close.TabIndex = 14
        Me.btn_close.Text = "Close"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_update.Appearance.Options.UseBackColor = True
        Me.btn_update.Location = New System.Drawing.Point(136, 863)
        Me.btn_update.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(115, 41)
        Me.btn_update.TabIndex = 40
        Me.btn_update.Text = "Update"
        '
        'LabelControl18
        '
        Me.LabelControl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(1264, 705)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(40, 19)
        Me.LabelControl18.TabIndex = 41
        Me.LabelControl18.Text = "Sales"
        '
        'lbl_sales
        '
        Me.lbl_sales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_sales.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_sales.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_sales.Appearance.Options.UseFont = True
        Me.lbl_sales.Appearance.Options.UseForeColor = True
        Me.lbl_sales.Appearance.Options.UseTextOptions = True
        Me.lbl_sales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_sales.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_sales.Location = New System.Drawing.Point(1304, 703)
        Me.lbl_sales.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_sales.Name = "lbl_sales"
        Me.lbl_sales.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_sales.Size = New System.Drawing.Size(210, 22)
        Me.lbl_sales.TabIndex = 42
        Me.lbl_sales.Text = "0.00"
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl1.LineColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeparatorControl1.LineThickness = 1
        Me.SeparatorControl1.Location = New System.Drawing.Point(1304, 692)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl1.Size = New System.Drawing.Size(210, 10)
        Me.SeparatorControl1.TabIndex = 43
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total.Appearance.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_total.Appearance.Options.UseFont = True
        Me.txt_total.Appearance.Options.UseForeColor = True
        Me.txt_total.Appearance.Options.UseTextOptions = True
        Me.txt_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_total.Location = New System.Drawing.Point(1304, 887)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.txt_total.Size = New System.Drawing.Size(210, 22)
        Me.txt_total.TabIndex = 44
        Me.txt_total.Text = "0.00"
        '
        'SeparatorControl2
        '
        Me.SeparatorControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl2.LineColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeparatorControl2.LineThickness = 1
        Me.SeparatorControl2.Location = New System.Drawing.Point(1304, 811)
        Me.SeparatorControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.SeparatorControl2.Name = "SeparatorControl2"
        Me.SeparatorControl2.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl2.Size = New System.Drawing.Size(210, 10)
        Me.SeparatorControl2.TabIndex = 45
        '
        'lbl_amount
        '
        Me.lbl_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_amount.Appearance.Font = New System.Drawing.Font("Arial", 11.25!)
        Me.lbl_amount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_amount.Appearance.Options.UseFont = True
        Me.lbl_amount.Appearance.Options.UseForeColor = True
        Me.lbl_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_amount.Location = New System.Drawing.Point(1304, 823)
        Me.lbl_amount.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_amount.Name = "lbl_amount"
        Me.lbl_amount.Padding = New System.Windows.Forms.Padding(0, 0, 6, 0)
        Me.lbl_amount.Size = New System.Drawing.Size(210, 22)
        Me.lbl_amount.TabIndex = 46
        Me.lbl_amount.Text = "0.00"
        '
        'SeparatorControl3
        '
        Me.SeparatorControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SeparatorControl3.LineColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.SeparatorControl3.LineThickness = 2
        Me.SeparatorControl3.Location = New System.Drawing.Point(1304, 869)
        Me.SeparatorControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.SeparatorControl3.Name = "SeparatorControl3"
        Me.SeparatorControl3.Padding = New System.Windows.Forms.Padding(0)
        Me.SeparatorControl3.Size = New System.Drawing.Size(210, 10)
        Me.SeparatorControl3.TabIndex = 47
        '
        'lbl_purchase_id
        '
        Me.lbl_purchase_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_purchase_id.Location = New System.Drawing.Point(1454, 34)
        Me.lbl_purchase_id.Margin = New System.Windows.Forms.Padding(4)
        Me.lbl_purchase_id.Name = "lbl_purchase_id"
        Me.lbl_purchase_id.Size = New System.Drawing.Size(68, 16)
        Me.lbl_purchase_id.TabIndex = 48
        Me.lbl_purchase_id.Text = "Purchase ID"
        Me.lbl_purchase_id.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_delete.Appearance.Options.UseBackColor = True
        Me.btn_delete.Location = New System.Drawing.Point(259, 863)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(115, 41)
        Me.btn_delete.TabIndex = 49
        Me.btn_delete.Text = "Delete"
        '
        'frm_accounting_view_transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1528, 923)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.lbl_purchase_id)
        Me.Controls.Add(Me.SeparatorControl3)
        Me.Controls.Add(Me.lbl_amount)
        Me.Controls.Add(Me.SeparatorControl2)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.SeparatorControl1)
        Me.Controls.Add(Me.lbl_sales)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.lbl_receipt_id)
        Me.Controls.Add(Me.lbl_12_vat)
        Me.Controls.Add(Me.lbl_vatables_sales)
        Me.Controls.Add(Me.lbl_vat)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.lbl_ewt)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.txt_sub_total)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.lbl_credit)
        Me.Controls.Add(Me.lbl_discount)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.grid_transaction)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_accounting_view_transaction.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_accounting_view_transaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "View Transaction Details"
        CType(Me.grid_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transaction_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_counted_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_encoded_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_purchaseID.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.dt_dr_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_dr_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_si_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_si_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dr_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_si_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_transaction As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_transaction_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents txt_counted_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_encoded_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_purchaseID As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_supplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_discount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_credit As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_sub_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_ewt As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_vat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_vatables_sales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_12_vat As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_receipt_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dtp_received_date As DateTimePicker
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents lbl_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_terms As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_dr_date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents dt_si_date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dr_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_si_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_sales As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl1 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents txt_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl2 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lbl_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SeparatorControl3 As DevExpress.XtraEditors.SeparatorControl
    Friend WithEvents lbl_purchase_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_base_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
End Class
