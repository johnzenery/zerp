Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_payables
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_payables = New DevExpress.XtraGrid.GridControl()
        Me.grid_payables_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receipt_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receipt_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_posted_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_dates = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_view = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.btn_issued = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_unpaid = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_paid = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_all = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_new_payable = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_payables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payables_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1131, 78)
        Me.GunaPanel4.TabIndex = 11
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1096, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(108, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Account Payables"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(232, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Account Payables"
        '
        'grid_payables
        '
        Me.grid_payables.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payables.Location = New System.Drawing.Point(12, 71)
        Me.grid_payables.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_payables.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_payables.MainView = Me.grid_payables_view
        Me.grid_payables.Name = "grid_payables"
        Me.grid_payables.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view})
        Me.grid_payables.Size = New System.Drawing.Size(1107, 418)
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
        Me.grid_payables_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_supplier, Me.col_receipt_type, Me.col_receipt_ref, Me.col_amount, Me.col_status, Me.col_action, Me.col_date_received, Me.col_purchase_id, Me.col_posted_date, Me.col_payment_dates, Me.col_payment_ref, Me.col_terms, Me.col_due_date, Me.col_view})
        Me.grid_payables_view.GridControl = Me.grid_payables
        Me.grid_payables_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_payables_view.Name = "grid_payables_view"
        Me.grid_payables_view.OptionsBehavior.ReadOnly = True
        Me.grid_payables_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_payables_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_payables_view.OptionsView.ColumnAutoWidth = False
        Me.grid_payables_view.OptionsView.RowAutoHeight = True
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
        'col_receipt_type
        '
        Me.col_receipt_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_receipt_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_receipt_type.Caption = "Receipt Type"
        Me.col_receipt_type.FieldName = "receipt_type"
        Me.col_receipt_type.Name = "col_receipt_type"
        Me.col_receipt_type.Visible = True
        Me.col_receipt_type.VisibleIndex = 3
        Me.col_receipt_type.Width = 102
        '
        'col_receipt_ref
        '
        Me.col_receipt_ref.AppearanceCell.Options.UseTextOptions = True
        Me.col_receipt_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_receipt_ref.Caption = "Receipt Ref"
        Me.col_receipt_ref.FieldName = "receipt_ref"
        Me.col_receipt_ref.Name = "col_receipt_ref"
        Me.col_receipt_ref.Visible = True
        Me.col_receipt_ref.VisibleIndex = 4
        Me.col_receipt_ref.Width = 83
        '
        'col_amount
        '
        Me.col_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 5
        Me.col_amount.Width = 118
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Payment Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 7
        Me.col_status.Width = 118
        '
        'col_action
        '
        Me.col_action.Caption = "Branch"
        Me.col_action.FieldName = "store_name"
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 11
        Me.col_action.Width = 223
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
        Me.col_date_received.VisibleIndex = 8
        Me.col_date_received.Width = 120
        '
        'col_purchase_id
        '
        Me.col_purchase_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_purchase_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_purchase_id.Caption = "Purchase ID"
        Me.col_purchase_id.FieldName = "purchase_id"
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 6
        Me.col_purchase_id.Width = 90
        '
        'col_posted_date
        '
        Me.col_posted_date.Caption = "Cheque No."
        Me.col_posted_date.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.col_posted_date.FieldName = "payment_cheque"
        Me.col_posted_date.Name = "col_posted_date"
        Me.col_posted_date.Width = 115
        '
        'col_payment_dates
        '
        Me.col_payment_dates.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment_dates.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payment_dates.Caption = "Cheque Date"
        Me.col_payment_dates.ColumnEdit = Me.RepositoryItemMemoEdit1
        Me.col_payment_dates.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_payment_dates.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_payment_dates.FieldName = "payment_dates"
        Me.col_payment_dates.Name = "col_payment_dates"
        Me.col_payment_dates.Width = 140
        '
        'col_payment_ref
        '
        Me.col_payment_ref.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_payment_ref.Caption = "Voucher ID"
        Me.col_payment_ref.FieldName = "payment_ref"
        Me.col_payment_ref.Name = "col_payment_ref"
        Me.col_payment_ref.Visible = True
        Me.col_payment_ref.VisibleIndex = 14
        Me.col_payment_ref.Width = 100
        '
        'col_terms
        '
        Me.col_terms.AppearanceCell.Options.UseTextOptions = True
        Me.col_terms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 9
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
        Me.col_due_date.VisibleIndex = 10
        Me.col_due_date.Width = 136
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
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.documentmap_16x16
        Me.btn_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.btn_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view.Name = "btn_view"
        Me.btn_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.btn_issued)
        Me.PanelControl1.Controls.Add(Me.btn_unpaid)
        Me.PanelControl1.Controls.Add(Me.btn_paid)
        Me.PanelControl1.Controls.Add(Me.btn_all)
        Me.PanelControl1.Location = New System.Drawing.Point(868, 17)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
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
        Me.btn_issued.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_issued.LookAndFeel.UseDefaultLookAndFeel = False
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
        Me.btn_unpaid.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_unpaid.LookAndFeel.UseDefaultLookAndFeel = False
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
        Me.btn_paid.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_paid.LookAndFeel.UseDefaultLookAndFeel = False
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
        Me.btn_all.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_all.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(54, 30)
        Me.btn_all.TabIndex = 1
        Me.btn_all.Text = "ALL"
        '
        'btn_new_payable
        '
        Me.btn_new_payable.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.addnewdatasource_32x32
        Me.btn_new_payable.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_payable.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_payable.Location = New System.Drawing.Point(12, 15)
        Me.btn_new_payable.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_new_payable.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_new_payable.Name = "btn_new_payable"
        Me.btn_new_payable.Size = New System.Drawing.Size(173, 46)
        Me.btn_new_payable.TabIndex = 6
        Me.btn_new_payable.Text = "New Payable from PO"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Controls.Add(Me.btn_new_payable)
        Me.Panel1.Controls.Add(Me.PanelControl1)
        Me.Panel1.Controls.Add(Me.grid_payables)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1131, 499)
        Me.Panel1.TabIndex = 14
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(811, 31)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Filter By:"
        '
        'frm_accounting_payables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1131, 577)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_accounting_payables"
        Me.Text = "frm_accounting_payables"
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_payables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payables_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_payables As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payables_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_receipt_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_receipt_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_posted_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_dates As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents Panel1 As Panel
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
End Class
