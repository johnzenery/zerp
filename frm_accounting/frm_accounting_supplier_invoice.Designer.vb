Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_supplier_invoice
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
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.grid_payables = New DevExpress.XtraGrid.GridControl()
        Me.grid_payables_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tax_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receipt_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_drno = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_drdate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sino = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sidate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_subtotal = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_clearing_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ewt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_issued = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_unpaid = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_paid = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_all = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_new_payable = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.pgb = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payables_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'grid_payables
        '
        Me.grid_payables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payables.Location = New System.Drawing.Point(-1, 110)
        Me.grid_payables.MainView = Me.grid_payables_view
        Me.grid_payables.Name = "grid_payables"
        Me.grid_payables.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view})
        Me.grid_payables.Size = New System.Drawing.Size(1453, 466)
        Me.grid_payables.TabIndex = 12
        Me.grid_payables.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_payables_view})
        '
        'grid_payables_view
        '
        Me.grid_payables_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_payables_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_payables_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_payables_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_payables_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_payables_view.Appearance.Row.Options.UseFont = True
        Me.grid_payables_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_view, Me.col_id, Me.col_supplier, Me.col_tax_type, Me.col_receipt_ref, Me.col_drno, Me.col_drdate, Me.col_sino, Me.col_sidate, Me.col_subtotal, Me.col_amount, Me.col_purchase_id, Me.col_status, Me.col_date_received, Me.col_terms, Me.col_due_date, Me.col_clearing_status, Me.col_action, Me.col_payment_ref, Me.col_ewt, Me.col_discount})
        Me.grid_payables_view.GridControl = Me.grid_payables
        Me.grid_payables_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_payables_view.Name = "grid_payables_view"
        Me.grid_payables_view.OptionsBehavior.ReadOnly = True
        Me.grid_payables_view.OptionsPrint.PrintHorzLines = False
        Me.grid_payables_view.OptionsPrint.PrintVertLines = False
        Me.grid_payables_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_payables_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_payables_view.OptionsView.ColumnAutoWidth = False
        Me.grid_payables_view.OptionsView.RowAutoHeight = True
        '
        'col_view
        '
        Me.col_view.Caption = "View"
        Me.col_view.ColumnEdit = Me.btn_view
        Me.col_view.Name = "col_view"
        Me.col_view.Visible = True
        Me.col_view.VisibleIndex = 0
        Me.col_view.Width = 49
        '
        'btn_view
        '
        Me.btn_view.AutoHeight = False
        Me.btn_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.documentmap_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "payable_id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 46
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 262
        '
        'col_tax_type
        '
        Me.col_tax_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_tax_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_tax_type.Caption = "Tax Type"
        Me.col_tax_type.FieldName = "tax_type"
        Me.col_tax_type.Name = "col_tax_type"
        Me.col_tax_type.Visible = True
        Me.col_tax_type.VisibleIndex = 3
        Me.col_tax_type.Width = 102
        '
        'col_receipt_ref
        '
        Me.col_receipt_ref.AppearanceCell.Options.UseTextOptions = True
        Me.col_receipt_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_receipt_ref.Caption = "Receipt Ref"
        Me.col_receipt_ref.FieldName = "receipt_ref"
        Me.col_receipt_ref.Name = "col_receipt_ref"
        Me.col_receipt_ref.Width = 83
        '
        'col_drno
        '
        Me.col_drno.Caption = "DR No."
        Me.col_drno.FieldName = "dr_no"
        Me.col_drno.Name = "col_drno"
        Me.col_drno.Visible = True
        Me.col_drno.VisibleIndex = 4
        '
        'col_drdate
        '
        Me.col_drdate.Caption = "DR Date"
        Me.col_drdate.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_drdate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_drdate.FieldName = "dr_date"
        Me.col_drdate.Name = "col_drdate"
        Me.col_drdate.Visible = True
        Me.col_drdate.VisibleIndex = 5
        '
        'col_sino
        '
        Me.col_sino.Caption = "SI No."
        Me.col_sino.FieldName = "si_no"
        Me.col_sino.Name = "col_sino"
        Me.col_sino.Visible = True
        Me.col_sino.VisibleIndex = 6
        '
        'col_sidate
        '
        Me.col_sidate.Caption = "SI Date"
        Me.col_sidate.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_sidate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_sidate.FieldName = "si_date"
        Me.col_sidate.Name = "col_sidate"
        Me.col_sidate.Visible = True
        Me.col_sidate.VisibleIndex = 7
        '
        'col_subtotal
        '
        Me.col_subtotal.Caption = "Subtotal"
        Me.col_subtotal.DisplayFormat.FormatString = "c2"
        Me.col_subtotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_subtotal.FieldName = "total_cost"
        Me.col_subtotal.Name = "col_subtotal"
        Me.col_subtotal.Visible = True
        Me.col_subtotal.VisibleIndex = 8
        Me.col_subtotal.Width = 110
        '
        'col_amount
        '
        Me.col_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount.Caption = "Total Amount"
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 11
        Me.col_amount.Width = 110
        '
        'col_purchase_id
        '
        Me.col_purchase_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_purchase_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_purchase_id.Caption = "Purchase ID"
        Me.col_purchase_id.FieldName = "purchase_id"
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 12
        Me.col_purchase_id.Width = 90
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Payment Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 13
        Me.col_status.Width = 118
        '
        'col_date_received
        '
        Me.col_date_received.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_received.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_received.Caption = "Date Received"
        Me.col_date_received.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_received.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_received.FieldName = "received_date"
        Me.col_date_received.Name = "col_date_received"
        Me.col_date_received.Visible = True
        Me.col_date_received.VisibleIndex = 14
        Me.col_date_received.Width = 120
        '
        'col_terms
        '
        Me.col_terms.AppearanceCell.Options.UseTextOptions = True
        Me.col_terms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 15
        '
        'col_due_date
        '
        Me.col_due_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_due_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_due_date.Caption = "Due Date"
        Me.col_due_date.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_due_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_due_date.FieldName = "due_date"
        Me.col_due_date.Name = "col_due_date"
        Me.col_due_date.Visible = True
        Me.col_due_date.VisibleIndex = 16
        Me.col_due_date.Width = 136
        '
        'col_clearing_status
        '
        Me.col_clearing_status.Caption = "Clearing Status"
        Me.col_clearing_status.FieldName = "clearing_status"
        Me.col_clearing_status.Name = "col_clearing_status"
        Me.col_clearing_status.Visible = True
        Me.col_clearing_status.VisibleIndex = 17
        Me.col_clearing_status.Width = 150
        '
        'col_action
        '
        Me.col_action.Caption = "Warehouse"
        Me.col_action.FieldName = "store_name"
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 18
        Me.col_action.Width = 223
        '
        'col_payment_ref
        '
        Me.col_payment_ref.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_payment_ref.Caption = "Voucher ID"
        Me.col_payment_ref.FieldName = "payment_ref"
        Me.col_payment_ref.Name = "col_payment_ref"
        Me.col_payment_ref.Visible = True
        Me.col_payment_ref.VisibleIndex = 19
        Me.col_payment_ref.Width = 100
        '
        'col_ewt
        '
        Me.col_ewt.Caption = "EWT"
        Me.col_ewt.DisplayFormat.FormatString = "n2"
        Me.col_ewt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_ewt.FieldName = "ewt"
        Me.col_ewt.Name = "col_ewt"
        Me.col_ewt.Visible = True
        Me.col_ewt.VisibleIndex = 10
        '
        'col_discount
        '
        Me.col_discount.Caption = "Discount"
        Me.col_discount.DisplayFormat.FormatString = "c2"
        Me.col_discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_discount.FieldName = "discount"
        Me.col_discount.Name = "col_discount"
        Me.col_discount.Visible = True
        Me.col_discount.VisibleIndex = 9
        Me.col_discount.Width = 120
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.btn_issued)
        Me.PanelControl1.Controls.Add(Me.btn_unpaid)
        Me.PanelControl1.Controls.Add(Me.btn_paid)
        Me.PanelControl1.Controls.Add(Me.btn_all)
        Me.PanelControl1.Location = New System.Drawing.Point(69, 56)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(251, 46)
        Me.PanelControl1.TabIndex = 13
        '
        'btn_issued
        '
        Me.btn_issued.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_issued.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btn_issued.Appearance.Options.UseBackColor = True
        Me.btn_issued.Location = New System.Drawing.Point(70, 8)
        Me.btn_issued.Name = "btn_issued"
        Me.btn_issued.Size = New System.Drawing.Size(54, 30)
        Me.btn_issued.TabIndex = 4
        Me.btn_issued.Text = "ISSUED"
        '
        'btn_unpaid
        '
        Me.btn_unpaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_unpaid.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_unpaid.Appearance.Options.UseBackColor = True
        Me.btn_unpaid.Location = New System.Drawing.Point(10, 8)
        Me.btn_unpaid.Name = "btn_unpaid"
        Me.btn_unpaid.Size = New System.Drawing.Size(54, 30)
        Me.btn_unpaid.TabIndex = 3
        Me.btn_unpaid.Text = "UNPAID"
        '
        'btn_paid
        '
        Me.btn_paid.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_paid.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_paid.Appearance.Options.UseBackColor = True
        Me.btn_paid.Location = New System.Drawing.Point(130, 8)
        Me.btn_paid.Name = "btn_paid"
        Me.btn_paid.Size = New System.Drawing.Size(54, 30)
        Me.btn_paid.TabIndex = 2
        Me.btn_paid.Text = "PAID"
        '
        'btn_all
        '
        Me.btn_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_all.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_all.Appearance.Options.UseBackColor = True
        Me.btn_all.Location = New System.Drawing.Point(188, 8)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(54, 30)
        Me.btn_all.TabIndex = 1
        Me.btn_all.Text = "ALL"
        '
        'btn_new_payable
        '
        Me.btn_new_payable.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_new_payable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_payable.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_payable.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.newdatasource
        Me.btn_new_payable.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_new_payable.Location = New System.Drawing.Point(1417, 9)
        Me.btn_new_payable.Name = "btn_new_payable"
        Me.btn_new_payable.Size = New System.Drawing.Size(173, 46)
        Me.btn_new_payable.TabIndex = 6
        Me.btn_new_payable.Text = "New Payable from PO"
        Me.btn_new_payable.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Filter By:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(193, 31)
        Me.LabelControl2.TabIndex = 20
        Me.LabelControl2.Text = "Supplier Invoice"
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 5
        Me.btn_export.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.exporttoxls
        Me.btn_export.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export.Location = New System.Drawing.Point(1266, 54)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(173, 46)
        Me.btn_export.TabIndex = 21
        Me.btn_export.Text = "Export to XLSX"
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_refresh.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_refresh.Location = New System.Drawing.Point(1138, 54)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(122, 46)
        Me.btn_refresh.TabIndex = 22
        Me.btn_refresh.Text = "Refresh"
        '
        'pgb
        '
        Me.pgb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.pgb.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pgb.Appearance.Options.UseBackColor = True
        Me.pgb.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.pgb.Description = "Retrieving Invoices ..."
        Me.pgb.Location = New System.Drawing.Point(602, 220)
        Me.pgb.Name = "pgb"
        Me.pgb.Size = New System.Drawing.Size(246, 76)
        Me.pgb.TabIndex = 23
        Me.pgb.Text = "ProgressPanel1"
        Me.pgb.Visible = False
        Me.pgb.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'frm_accounting_supplier_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1451, 577)
        Me.Controls.Add(Me.pgb)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.grid_payables)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.btn_new_payable)
        Me.Name = "frm_accounting_supplier_invoice"
        Me.Text = "Supplier Invoice"
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payables_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_payables As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payables_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_receipt_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tax_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_clearing_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_due_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_unpaid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_paid As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btn_issued As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_new_payable As SimpleButton
    Friend WithEvents col_view As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view As Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents btn_export As SimpleButton
    Friend WithEvents btn_refresh As SimpleButton
    Friend WithEvents pgb As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents col_drno As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_drdate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sino As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sidate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ewt As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_subtotal As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_discount As DevExpress.XtraGrid.Columns.GridColumn
End Class
