<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_cashier_register
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_cec = New DevExpress.XtraGrid.GridControl()
        Me.grid_cec_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_pay_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_orderid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_order_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_shipping_method = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_representative = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_collection_receipts = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_terms_collection = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_payment_history = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tab_cec = New DevExpress.XtraTab.XtraTabPage()
        Me.tab_terms = New DevExpress.XtraTab.XtraTabPage()
        Me.grid_terms = New DevExpress.XtraGrid.GridControl()
        Me.grid_terms_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_cec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cec_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_pay_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tab_cec.SuspendLayout()
        Me.tab_terms.SuspendLayout()
        CType(Me.grid_terms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_terms_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(189, 31)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Cahier Register"
        '
        'grid_cec
        '
        Me.grid_cec.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_cec.Location = New System.Drawing.Point(3, 15)
        Me.grid_cec.MainView = Me.grid_cec_view
        Me.grid_cec.Name = "grid_cec"
        Me.grid_cec.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_pay_order})
        Me.grid_cec.Size = New System.Drawing.Size(1377, 465)
        Me.grid_cec.TabIndex = 21
        Me.grid_cec.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_cec_view})
        '
        'grid_cec_view
        '
        Me.grid_cec_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_cec_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_cec_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_cec_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_cec_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_cec_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_cec_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_cec_view.Appearance.Row.Options.UseFont = True
        Me.grid_cec_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_cec_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_cec_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_cec_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_cec_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_orderid, Me.col_order_date, Me.col_shipping_method, Me.col_status, Me.col_payment_status, Me.col_payment, Me.col_customer, Me.col_representative, Me.col_amount})
        Me.grid_cec_view.GridControl = Me.grid_cec
        Me.grid_cec_view.Name = "grid_cec_view"
        Me.grid_cec_view.OptionsBehavior.ReadOnly = True
        Me.grid_cec_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_cec_view.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        '
        'col_view
        '
        Me.col_view.AppearanceCell.Options.UseTextOptions = True
        Me.col_view.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_view.ColumnEdit = Me.btn_pay_order
        Me.col_view.MaxWidth = 50
        Me.col_view.MinWidth = 60
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 60
        '
        'btn_pay_order
        '
        Me.btn_pay_order.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.payment
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_pay_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_pay_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_pay_order.Name = "btn_pay_order"
        Me.btn_pay_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_orderid
        '
        Me.col_orderid.AppearanceCell.Options.UseTextOptions = True
        Me.col_orderid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_orderid.Caption = "ID"
        Me.col_orderid.FieldName = "orderid"
        Me.col_orderid.MaxWidth = 80
        Me.col_orderid.MinWidth = 80
        Me.col_orderid.Name = "col_orderid"
        Me.col_orderid.OptionsColumn.AllowEdit = False
        Me.col_orderid.Visible = True
        Me.col_orderid.VisibleIndex = 1
        Me.col_orderid.Width = 80
        '
        'col_order_date
        '
        Me.col_order_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_order_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_order_date.Caption = "Date Ordered"
        Me.col_order_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_order_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_order_date.FieldName = "date_ordered"
        Me.col_order_date.Name = "col_order_date"
        Me.col_order_date.OptionsColumn.AllowEdit = False
        Me.col_order_date.Visible = True
        Me.col_order_date.VisibleIndex = 2
        Me.col_order_date.Width = 141
        '
        'col_shipping_method
        '
        Me.col_shipping_method.AppearanceCell.Options.UseTextOptions = True
        Me.col_shipping_method.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_shipping_method.Caption = "Shiping Method"
        Me.col_shipping_method.FieldName = "shipping_method"
        Me.col_shipping_method.Name = "col_shipping_method"
        Me.col_shipping_method.OptionsColumn.AllowEdit = False
        Me.col_shipping_method.Visible = True
        Me.col_shipping_method.VisibleIndex = 3
        Me.col_shipping_method.Width = 141
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Package Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.OptionsColumn.AllowEdit = False
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 4
        Me.col_status.Width = 141
        '
        'col_payment_status
        '
        Me.col_payment_status.Caption = "Payment Status"
        Me.col_payment_status.FieldName = "payment_status"
        Me.col_payment_status.Name = "col_payment_status"
        Me.col_payment_status.OptionsColumn.AllowEdit = False
        Me.col_payment_status.Visible = True
        Me.col_payment_status.VisibleIndex = 5
        Me.col_payment_status.Width = 120
        '
        'col_payment
        '
        Me.col_payment.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payment.Caption = "Payment Type"
        Me.col_payment.FieldName = "payment_type"
        Me.col_payment.Name = "col_payment"
        Me.col_payment.OptionsColumn.AllowEdit = False
        Me.col_payment.Visible = True
        Me.col_payment.VisibleIndex = 6
        Me.col_payment.Width = 129
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.Name = "col_customer"
        Me.col_customer.OptionsColumn.AllowEdit = False
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 7
        Me.col_customer.Width = 129
        '
        'col_representative
        '
        Me.col_representative.Caption = "Representative"
        Me.col_representative.FieldName = "representative"
        Me.col_representative.Name = "col_representative"
        Me.col_representative.OptionsColumn.AllowEdit = False
        Me.col_representative.Visible = True
        Me.col_representative.VisibleIndex = 8
        Me.col_representative.Width = 129
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount_due"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.OptionsColumn.AllowEdit = False
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 9
        Me.col_amount.Width = 180
        '
        'btn_collection_receipts
        '
        Me.btn_collection_receipts.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_collection_receipts.Appearance.Options.UseFont = True
        Me.btn_collection_receipts.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.text_32x32
        Me.btn_collection_receipts.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_collection_receipts.ImageOptions.ImageToTextIndent = 7
        Me.btn_collection_receipts.Location = New System.Drawing.Point(344, 58)
        Me.btn_collection_receipts.Name = "btn_collection_receipts"
        Me.btn_collection_receipts.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_collection_receipts.Size = New System.Drawing.Size(160, 46)
        Me.btn_collection_receipts.TabIndex = 26
        Me.btn_collection_receipts.Text = "Collection Receipts"
        '
        'btn_terms_collection
        '
        Me.btn_terms_collection.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_terms_collection.Appearance.Options.UseFont = True
        Me.btn_terms_collection.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.insertheader_32x32
        Me.btn_terms_collection.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_terms_collection.ImageOptions.ImageToTextIndent = 7
        Me.btn_terms_collection.Location = New System.Drawing.Point(12, 58)
        Me.btn_terms_collection.Name = "btn_terms_collection"
        Me.btn_terms_collection.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_terms_collection.Size = New System.Drawing.Size(160, 46)
        Me.btn_terms_collection.TabIndex = 24
        Me.btn_terms_collection.Text = "Terms Collection"
        '
        'btn_payment_history
        '
        Me.btn_payment_history.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_payment_history.Appearance.Options.UseFont = True
        Me.btn_payment_history.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.financial_32x321
        Me.btn_payment_history.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_payment_history.ImageOptions.ImageToTextIndent = 7
        Me.btn_payment_history.Location = New System.Drawing.Point(178, 58)
        Me.btn_payment_history.Name = "btn_payment_history"
        Me.btn_payment_history.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.btn_payment_history.Size = New System.Drawing.Size(160, 46)
        Me.btn_payment_history.TabIndex = 23
        Me.btn_payment_history.Text = "Payment Journal"
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
        Me.btn_refresh.Location = New System.Drawing.Point(1237, 58)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 27
        Me.btn_refresh.Text = "Refresh"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 122)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tab_cec
        Me.XtraTabControl1.Size = New System.Drawing.Size(1385, 514)
        Me.XtraTabControl1.TabIndex = 29
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab_cec, Me.tab_terms})
        '
        'tab_cec
        '
        Me.tab_cec.Controls.Add(Me.grid_cec)
        Me.tab_cec.Name = "tab_cec"
        Me.tab_cec.Size = New System.Drawing.Size(1383, 483)
        Me.tab_cec.Text = "CEC"
        '
        'tab_terms
        '
        Me.tab_terms.Controls.Add(Me.grid_terms)
        Me.tab_terms.Name = "tab_terms"
        Me.tab_terms.Size = New System.Drawing.Size(1383, 483)
        Me.tab_terms.Text = "Terms"
        '
        'grid_terms
        '
        Me.grid_terms.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_terms.Location = New System.Drawing.Point(3, 9)
        Me.grid_terms.MainView = Me.grid_terms_view
        Me.grid_terms.Name = "grid_terms"
        Me.grid_terms.Size = New System.Drawing.Size(1377, 465)
        Me.grid_terms.TabIndex = 22
        Me.grid_terms.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_terms_view})
        '
        'grid_terms_view
        '
        Me.grid_terms_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_terms_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_terms_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_terms_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_terms_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_terms_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_terms_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_terms_view.Appearance.Row.Options.UseFont = True
        Me.grid_terms_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_terms_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_terms_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_terms_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_terms_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9, Me.GridColumn10})
        Me.grid_terms_view.GridControl = Me.grid_terms
        Me.grid_terms_view.Name = "grid_terms_view"
        Me.grid_terms_view.OptionsBehavior.ReadOnly = True
        Me.grid_terms_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_terms_view.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        '
        'GridColumn2
        '
        Me.GridColumn2.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn2.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn2.Caption = "ID"
        Me.GridColumn2.FieldName = "orderid"
        Me.GridColumn2.MaxWidth = 80
        Me.GridColumn2.MinWidth = 80
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.AllowEdit = False
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 80
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Date Ordered"
        Me.GridColumn3.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "date_ordered"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 141
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Shiping Method"
        Me.GridColumn4.FieldName = "shipping_method"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 141
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn5.Caption = "Package Status"
        Me.GridColumn5.FieldName = "status"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.AllowEdit = False
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 141
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Payment Status"
        Me.GridColumn6.FieldName = "payment_status"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.AllowEdit = False
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 120
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Payment Type"
        Me.GridColumn7.FieldName = "payment_type"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 129
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Customer"
        Me.GridColumn8.FieldName = "customer"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.AllowEdit = False
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 129
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Representative"
        Me.GridColumn9.FieldName = "representative"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 129
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Amount"
        Me.GridColumn10.DisplayFormat.FormatString = "c2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "amount_due"
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.OptionsColumn.AllowEdit = False
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 8
        Me.GridColumn10.Width = 180
        '
        'frm_collection_cashier_register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1409, 648)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_collection_receipts)
        Me.Controls.Add(Me.btn_terms_collection)
        Me.Controls.Add(Me.btn_payment_history)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm_collection_cashier_register"
        Me.Text = "Cashier Register"
        CType(Me.grid_cec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cec_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_pay_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tab_cec.ResumeLayout(False)
        Me.tab_terms.ResumeLayout(False)
        CType(Me.grid_terms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_terms_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_cec As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_cec_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_pay_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_collection_receipts As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_terms_collection As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_payment_history As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_orderid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_order_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_shipping_method As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_representative As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab_cec As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab_terms As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid_terms As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_terms_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
End Class
