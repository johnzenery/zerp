<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_generate_payment
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accounting_generate_payment))
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
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_receipts = New DevExpress.XtraGrid.GridControl()
        Me.grid_receipts_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receipt_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_cheque = New DevExpress.XtraEditors.PanelControl()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cb_crossed_check = New System.Windows.Forms.CheckBox()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.txt_acc_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_banks = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_payee = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_date = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cheque_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_collection_ref = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_suppliers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total_view = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_createdat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.rb_cash = New System.Windows.Forms.RadioButton()
        Me.rb_cheque = New System.Windows.Forms.RadioButton()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_receipt_no = New DevExpress.XtraEditors.TextEdit()
        Me.grid_cheque = New DevExpress.XtraGrid.GridControl()
        Me.grid_cheque_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_cheque_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_crossed_check = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cb_cc = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.grid_receipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_cheque.SuspendLayout()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_banks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_collection_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.lbl_receipt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1278, 78)
        Me.GunaPanel4.TabIndex = 12
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(1243, 27)
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
        Me.link_po_list.Size = New System.Drawing.Size(116, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Generate Payment"
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
        Me.GunaLabel2.Size = New System.Drawing.Size(241, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Generate Payment"
        '
        'grid_receipts
        '
        Me.grid_receipts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_receipts.Location = New System.Drawing.Point(413, 144)
        Me.grid_receipts.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_receipts.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_receipts.MainView = Me.grid_receipts_view
        Me.grid_receipts.Name = "grid_receipts"
        Me.grid_receipts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.grid_receipts.Size = New System.Drawing.Size(847, 345)
        Me.grid_receipts.TabIndex = 13
        Me.grid_receipts.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_receipts_view})
        '
        'grid_receipts_view
        '
        Me.grid_receipts_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_receipts_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_receipts_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_receipts_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_receipts_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_receipts_view.Appearance.Row.Options.UseFont = True
        Me.grid_receipts_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_po_id, Me.col_receipt_ref, Me.col_amount, Me.col_date_received, Me.col_purchase_id, Me.col_terms, Me.col_due_date})
        Me.grid_receipts_view.GridControl = Me.grid_receipts
        Me.grid_receipts_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_receipts_view.Name = "grid_receipts_view"
        Me.grid_receipts_view.OptionsBehavior.ReadOnly = True
        Me.grid_receipts_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_receipts_view.OptionsSelection.MultiSelect = True
        Me.grid_receipts_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_receipts_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_receipts_view.OptionsView.ColumnAutoWidth = False
        Me.grid_receipts_view.OptionsView.RowAutoHeight = True
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
        'col_po_id
        '
        Me.col_po_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_po_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_po_id.Caption = "Purchase ID"
        Me.col_po_id.FieldName = "purchase_id"
        Me.col_po_id.Name = "col_po_id"
        Me.col_po_id.Visible = True
        Me.col_po_id.VisibleIndex = 4
        Me.col_po_id.Width = 96
        '
        'col_receipt_ref
        '
        Me.col_receipt_ref.AppearanceCell.Options.UseTextOptions = True
        Me.col_receipt_ref.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_receipt_ref.Caption = "Receipt Ref"
        Me.col_receipt_ref.FieldName = "receipt_ref"
        Me.col_receipt_ref.Name = "col_receipt_ref"
        Me.col_receipt_ref.Visible = True
        Me.col_receipt_ref.VisibleIndex = 6
        Me.col_receipt_ref.Width = 104
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
        Me.col_amount.VisibleIndex = 7
        Me.col_amount.Width = 118
        '
        'col_date_received
        '
        Me.col_date_received.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_received.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_date_received.Caption = "Date Received"
        Me.col_date_received.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_received.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_received.FieldName = "received_date"
        Me.col_date_received.Name = "col_date_received"
        Me.col_date_received.Visible = True
        Me.col_date_received.VisibleIndex = 3
        Me.col_date_received.Width = 149
        '
        'col_purchase_id
        '
        Me.col_purchase_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_purchase_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_purchase_id.Caption = "Receipt Type"
        Me.col_purchase_id.FieldName = "receipt_type"
        Me.col_purchase_id.Name = "col_purchase_id"
        Me.col_purchase_id.Visible = True
        Me.col_purchase_id.VisibleIndex = 5
        Me.col_purchase_id.Width = 90
        '
        'col_terms
        '
        Me.col_terms.AppearanceCell.Options.UseTextOptions = True
        Me.col_terms.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 8
        '
        'col_due_date
        '
        Me.col_due_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_due_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_due_date.Caption = "Due Date"
        Me.col_due_date.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_due_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_due_date.FieldName = "due_date"
        Me.col_due_date.Name = "col_due_date"
        Me.col_due_date.Visible = True
        Me.col_due_date.VisibleIndex = 2
        Me.col_due_date.Width = 143
        '
        'RepositoryItemMemoEdit1
        '
        Me.RepositoryItemMemoEdit1.Name = "RepositoryItemMemoEdit1"
        '
        'btn_generate
        '
        Me.btn_generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_generate.Appearance.BackColor = System.Drawing.Color.DarkKhaki
        Me.btn_generate.Appearance.Options.UseBackColor = True
        Me.btn_generate.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.createmodeldifferences_16x16
        Me.btn_generate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_generate.Location = New System.Drawing.Point(12, 710)
        Me.btn_generate.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_generate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(389, 43)
        Me.btn_generate.TabIndex = 8
        Me.btn_generate.Text = "Generate Payment && Voucher"
        '
        'panel_cheque
        '
        Me.panel_cheque.Controls.Add(Me.txt_amount)
        Me.panel_cheque.Controls.Add(Me.LabelControl15)
        Me.panel_cheque.Controls.Add(Me.btn_add)
        Me.panel_cheque.Controls.Add(Me.cb_crossed_check)
        Me.panel_cheque.Controls.Add(Me.DateEdit1)
        Me.panel_cheque.Controls.Add(Me.txt_acc_name)
        Me.panel_cheque.Controls.Add(Me.LabelControl11)
        Me.panel_cheque.Controls.Add(Me.LabelControl10)
        Me.panel_cheque.Controls.Add(Me.txt_acc_no)
        Me.panel_cheque.Controls.Add(Me.LabelControl6)
        Me.panel_cheque.Controls.Add(Me.LabelControl5)
        Me.panel_cheque.Controls.Add(Me.cbb_banks)
        Me.panel_cheque.Controls.Add(Me.LabelControl4)
        Me.panel_cheque.Controls.Add(Me.txt_payee)
        Me.panel_cheque.Controls.Add(Me.LabelControl2)
        Me.panel_cheque.Controls.Add(Me.txt_cheque_date)
        Me.panel_cheque.Controls.Add(Me.LabelControl1)
        Me.panel_cheque.Controls.Add(Me.txt_cheque_no)
        Me.panel_cheque.Location = New System.Drawing.Point(12, 144)
        Me.panel_cheque.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.panel_cheque.LookAndFeel.UseDefaultLookAndFeel = False
        Me.panel_cheque.Name = "panel_cheque"
        Me.panel_cheque.Size = New System.Drawing.Size(389, 319)
        Me.panel_cheque.TabIndex = 14
        '
        'txt_amount
        '
        Me.txt_amount.EditValue = ""
        Me.txt_amount.Location = New System.Drawing.Point(122, 249)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_amount.Properties.Appearance.Options.UseFont = True
        Me.txt_amount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_amount.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txt_amount.Properties.MaskSettings.Set("mask", "n2")
        Me.txt_amount.Properties.UseMaskAsDisplayFormat = True
        Me.txt_amount.Size = New System.Drawing.Size(149, 22)
        Me.txt_amount.TabIndex = 22
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(16, 252)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Amount:"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(289, 275)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(89, 29)
        Me.btn_add.TabIndex = 21
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'cb_crossed_check
        '
        Me.cb_crossed_check.AutoSize = True
        Me.cb_crossed_check.Checked = True
        Me.cb_crossed_check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_crossed_check.Location = New System.Drawing.Point(16, 283)
        Me.cb_crossed_check.Name = "cb_crossed_check"
        Me.cb_crossed_check.Size = New System.Drawing.Size(127, 17)
        Me.cb_crossed_check.TabIndex = 20
        Me.cb_crossed_check.Text = "Apply Crossed Check"
        Me.cb_crossed_check.UseVisualStyleBackColor = True
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(224, 79)
        Me.DateEdit1.Name = "DateEdit1"
        Me.DateEdit1.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.DateEdit1.Properties.Appearance.Options.UseFont = True
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.DateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Size = New System.Drawing.Size(28, 22)
        Me.DateEdit1.TabIndex = 19
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Location = New System.Drawing.Point(122, 221)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_acc_name.Properties.Appearance.Options.UseFont = True
        Me.txt_acc_name.Size = New System.Drawing.Size(149, 22)
        Me.txt_acc_name.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(16, 224)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl11.TabIndex = 18
        Me.LabelControl11.Text = "Account Name:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Lato", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.ForeColor = System.Drawing.Color.White
        Me.LabelControl10.Appearance.Options.UseBackColor = True
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseForeColor = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl10.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelControl10.Location = New System.Drawing.Point(2, 2)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl10.Size = New System.Drawing.Size(385, 25)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "Cheque Details"
        '
        'txt_acc_no
        '
        Me.txt_acc_no.EditValue = ""
        Me.txt_acc_no.Location = New System.Drawing.Point(122, 191)
        Me.txt_acc_no.Name = "txt_acc_no"
        Me.txt_acc_no.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_acc_no.Properties.Appearance.Options.UseFont = True
        Me.txt_acc_no.Size = New System.Drawing.Size(149, 22)
        Me.txt_acc_no.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(16, 194)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Account No.:"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 164)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Payee Name:"
        '
        'cbb_banks
        '
        Me.cbb_banks.Location = New System.Drawing.Point(122, 109)
        Me.cbb_banks.Name = "cbb_banks"
        Me.cbb_banks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cbb_banks.Properties.Appearance.Options.UseFont = True
        Me.cbb_banks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_banks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_banks.Size = New System.Drawing.Size(151, 22)
        Me.cbb_banks.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(19, 112)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "*Bank:"
        '
        'txt_payee
        '
        Me.txt_payee.Location = New System.Drawing.Point(122, 161)
        Me.txt_payee.Name = "txt_payee"
        Me.txt_payee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_payee.Properties.Appearance.Options.UseFont = True
        Me.txt_payee.Size = New System.Drawing.Size(149, 22)
        Me.txt_payee.TabIndex = 4
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(19, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "*Cheque Date:"
        '
        'txt_cheque_date
        '
        Me.txt_cheque_date.Location = New System.Drawing.Point(122, 79)
        Me.txt_cheque_date.Name = "txt_cheque_date"
        Me.txt_cheque_date.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cheque_date.Properties.Appearance.Options.UseFont = True
        Me.txt_cheque_date.Size = New System.Drawing.Size(100, 22)
        Me.txt_cheque_date.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 52)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "*Cheque No.:"
        '
        'txt_cheque_no
        '
        Me.txt_cheque_no.Location = New System.Drawing.Point(122, 49)
        Me.txt_cheque_no.Name = "txt_cheque_no"
        Me.txt_cheque_no.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cheque_no.Properties.Appearance.Options.UseFont = True
        Me.txt_cheque_no.Size = New System.Drawing.Size(100, 22)
        Me.txt_cheque_no.TabIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Roboto", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(13, 685)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(85, 15)
        Me.LabelControl13.TabIndex = 26
        Me.LabelControl13.Text = "Collection Ref.:"
        '
        'txt_collection_ref
        '
        Me.txt_collection_ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_collection_ref.EditValue = ""
        Me.txt_collection_ref.Location = New System.Drawing.Point(115, 680)
        Me.txt_collection_ref.Name = "txt_collection_ref"
        Me.txt_collection_ref.Properties.Appearance.Font = New System.Drawing.Font("Roboto", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_collection_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_collection_ref.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_collection_ref.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_collection_ref.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_collection_ref.Size = New System.Drawing.Size(149, 24)
        Me.txt_collection_ref.TabIndex = 25
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(9, 11)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Supplier:"
        '
        'cbb_suppliers
        '
        Me.cbb_suppliers.Location = New System.Drawing.Point(63, 8)
        Me.cbb_suppliers.Name = "cbb_suppliers"
        Me.cbb_suppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_suppliers.Size = New System.Drawing.Size(271, 20)
        Me.cbb_suppliers.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(934, 762)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Total Amount:"
        '
        'txt_total_view
        '
        Me.txt_total_view.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_view.EditValue = ""
        Me.txt_total_view.Location = New System.Drawing.Point(1081, 759)
        Me.txt_total_view.Name = "txt_total_view"
        Me.txt_total_view.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.txt_total_view.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.txt_total_view.Properties.Appearance.Options.UseFont = True
        Me.txt_total_view.Properties.Appearance.Options.UseForeColor = True
        Me.txt_total_view.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total_view.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total_view.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.txt_total_view.Properties.ReadOnly = True
        Me.txt_total_view.Properties.UseReadOnlyAppearance = False
        Me.txt_total_view.Size = New System.Drawing.Size(179, 30)
        Me.txt_total_view.TabIndex = 17
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl3)
        Me.PanelControl2.Controls.Add(Me.cbb_suppliers)
        Me.PanelControl2.Location = New System.Drawing.Point(413, 104)
        Me.PanelControl2.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl2.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(847, 34)
        Me.PanelControl2.TabIndex = 18
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns.Location = New System.Drawing.Point(415, 522)
        Me.grid_returns.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_returns.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_returns.Size = New System.Drawing.Size(847, 231)
        Me.grid_returns.TabIndex = 19
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_returns_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_returns_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_returns_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_rid, Me.col_supplier, Me.col_total_cost, Me.col_createdat})
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_returns_view.OptionsSelection.MultiSelect = True
        Me.grid_returns_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_returns_view.OptionsView.ShowFooter = True
        '
        'col_rid
        '
        Me.col_rid.AppearanceCell.Options.UseTextOptions = True
        Me.col_rid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_rid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_rid.Caption = "Return ID"
        Me.col_rid.FieldName = "po_return_id"
        Me.col_rid.MaxWidth = 100
        Me.col_rid.MinWidth = 100
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 100
        '
        'col_supplier
        '
        Me.col_supplier.AppearanceHeader.Options.UseTextOptions = True
        Me.col_supplier.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MaxWidth = 250
        Me.col_supplier.MinWidth = 250
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 250
        '
        'col_total_cost
        '
        Me.col_total_cost.AppearanceCell.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total_cost.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total_cost.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total_cost.Caption = "Total Cost"
        Me.col_total_cost.DisplayFormat.FormatString = "c2"
        Me.col_total_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_cost.FieldName = "total_cost"
        Me.col_total_cost.MaxWidth = 150
        Me.col_total_cost.MinWidth = 100
        Me.col_total_cost.Name = "col_total_cost"
        Me.col_total_cost.Visible = True
        Me.col_total_cost.VisibleIndex = 3
        Me.col_total_cost.Width = 100
        '
        'col_createdat
        '
        Me.col_createdat.AppearanceCell.Options.UseTextOptions = True
        Me.col_createdat.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_createdat.AppearanceHeader.Options.UseTextOptions = True
        Me.col_createdat.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_createdat.Caption = "Created At"
        Me.col_createdat.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_createdat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_createdat.FieldName = "created_at"
        Me.col_createdat.MaxWidth = 120
        Me.col_createdat.MinWidth = 120
        Me.col_createdat.Name = "col_createdat"
        Me.col_createdat.Visible = True
        Me.col_createdat.VisibleIndex = 4
        Me.col_createdat.Width = 120
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl8
        '
        Me.LabelControl8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(413, 495)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(121, 21)
        Me.LabelControl8.TabIndex = 20
        Me.LabelControl8.Text = "Purchase Returns"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelControl12)
        Me.Panel1.Controls.Add(Me.rb_cash)
        Me.Panel1.Controls.Add(Me.rb_cheque)
        Me.Panel1.Location = New System.Drawing.Point(12, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 34)
        Me.Panel1.TabIndex = 21
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(3, 7)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(102, 18)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Payment Type:"
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rb_cash.Location = New System.Drawing.Point(200, 7)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(56, 21)
        Me.rb_cash.TabIndex = 1
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        '
        'rb_cheque
        '
        Me.rb_cheque.AutoSize = True
        Me.rb_cheque.Checked = True
        Me.rb_cheque.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.rb_cheque.Location = New System.Drawing.Point(122, 7)
        Me.rb_cheque.Name = "rb_cheque"
        Me.rb_cheque.Size = New System.Drawing.Size(73, 21)
        Me.rb_cheque.TabIndex = 0
        Me.rb_cheque.TabStop = True
        Me.rb_cheque.Text = "Cheque"
        Me.rb_cheque.UseVisualStyleBackColor = True
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl14.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Appearance.Options.UseForeColor = True
        Me.LabelControl14.Location = New System.Drawing.Point(703, 762)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(134, 22)
        Me.LabelControl14.TabIndex = 27
        Me.LabelControl14.Text = "No. of Receipt:"
        '
        'lbl_receipt_no
        '
        Me.lbl_receipt_no.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_receipt_no.EditValue = ""
        Me.lbl_receipt_no.Location = New System.Drawing.Point(843, 759)
        Me.lbl_receipt_no.Name = "lbl_receipt_no"
        Me.lbl_receipt_no.Properties.Appearance.Font = New System.Drawing.Font("Consolas", 14.25!, System.Drawing.FontStyle.Bold)
        Me.lbl_receipt_no.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.lbl_receipt_no.Properties.Appearance.Options.UseFont = True
        Me.lbl_receipt_no.Properties.Appearance.Options.UseForeColor = True
        Me.lbl_receipt_no.Properties.Appearance.Options.UseTextOptions = True
        Me.lbl_receipt_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_receipt_no.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.lbl_receipt_no.Properties.ReadOnly = True
        Me.lbl_receipt_no.Properties.UseReadOnlyAppearance = False
        Me.lbl_receipt_no.Size = New System.Drawing.Size(74, 30)
        Me.lbl_receipt_no.TabIndex = 29
        '
        'grid_cheque
        '
        Me.grid_cheque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_cheque.Location = New System.Drawing.Point(12, 472)
        Me.grid_cheque.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_cheque.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_cheque.MainView = Me.grid_cheque_view
        Me.grid_cheque.Name = "grid_cheque"
        Me.grid_cheque.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cb_cc, Me.btn_delete})
        Me.grid_cheque.Size = New System.Drawing.Size(389, 200)
        Me.grid_cheque.TabIndex = 53
        Me.grid_cheque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_cheque_view})
        '
        'grid_cheque_view
        '
        Me.grid_cheque_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_cheque_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_cheque_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_cheque_no, Me.col_cheque_date, Me.col_cheque_amount, Me.col_acc_no, Me.col_acc_name, Me.col_payee, Me.col_bank, Me.col_crossed_check, Me.col_delete})
        Me.grid_cheque_view.GridControl = Me.grid_cheque
        Me.grid_cheque_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_cheque_view.Name = "grid_cheque_view"
        Me.grid_cheque_view.OptionsView.ColumnAutoWidth = False
        Me.grid_cheque_view.OptionsView.ShowGroupPanel = False
        '
        'col_cheque_no
        '
        Me.col_cheque_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_no.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_cheque_no.AppearanceHeader.Options.UseForeColor = True
        Me.col_cheque_no.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cheque_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_no.Caption = "Cheque No"
        Me.col_cheque_no.FieldName = "cheque_no"
        Me.col_cheque_no.MaxWidth = 120
        Me.col_cheque_no.Name = "col_cheque_no"
        Me.col_cheque_no.Visible = True
        Me.col_cheque_no.VisibleIndex = 1
        Me.col_cheque_no.Width = 92
        '
        'col_cheque_date
        '
        Me.col_cheque_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_date.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_cheque_date.AppearanceHeader.Options.UseForeColor = True
        Me.col_cheque_date.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cheque_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_date.Caption = "Date"
        Me.col_cheque_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_cheque_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_cheque_date.FieldName = "cheque_date"
        Me.col_cheque_date.MaxWidth = 150
        Me.col_cheque_date.Name = "col_cheque_date"
        Me.col_cheque_date.Visible = True
        Me.col_cheque_date.VisibleIndex = 2
        Me.col_cheque_date.Width = 78
        '
        'col_cheque_amount
        '
        Me.col_cheque_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cheque_amount.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_cheque_amount.AppearanceHeader.Options.UseForeColor = True
        Me.col_cheque_amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cheque_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_amount.Caption = "Amount"
        Me.col_cheque_amount.DisplayFormat.FormatString = "c2"
        Me.col_cheque_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cheque_amount.FieldName = "cheque_amount"
        Me.col_cheque_amount.Name = "col_cheque_amount"
        Me.col_cheque_amount.Visible = True
        Me.col_cheque_amount.VisibleIndex = 3
        Me.col_cheque_amount.Width = 92
        '
        'col_acc_no
        '
        Me.col_acc_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_acc_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_acc_no.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_acc_no.AppearanceHeader.Options.UseForeColor = True
        Me.col_acc_no.AppearanceHeader.Options.UseTextOptions = True
        Me.col_acc_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_acc_no.Caption = "Acc. No."
        Me.col_acc_no.FieldName = "acc_no"
        Me.col_acc_no.Name = "col_acc_no"
        Me.col_acc_no.Visible = True
        Me.col_acc_no.VisibleIndex = 5
        Me.col_acc_no.Width = 108
        '
        'col_acc_name
        '
        Me.col_acc_name.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_acc_name.AppearanceHeader.Options.UseForeColor = True
        Me.col_acc_name.AppearanceHeader.Options.UseTextOptions = True
        Me.col_acc_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_acc_name.Caption = "Acc. Name"
        Me.col_acc_name.FieldName = "acc_name"
        Me.col_acc_name.Name = "col_acc_name"
        Me.col_acc_name.Visible = True
        Me.col_acc_name.VisibleIndex = 6
        '
        'col_payee
        '
        Me.col_payee.AppearanceCell.Options.UseTextOptions = True
        Me.col_payee.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payee.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_payee.AppearanceHeader.Options.UseForeColor = True
        Me.col_payee.AppearanceHeader.Options.UseTextOptions = True
        Me.col_payee.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payee.Caption = "Payee"
        Me.col_payee.FieldName = "payee"
        Me.col_payee.Name = "col_payee"
        Me.col_payee.Visible = True
        Me.col_payee.VisibleIndex = 7
        '
        'col_bank
        '
        Me.col_bank.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_bank.AppearanceHeader.Options.UseForeColor = True
        Me.col_bank.AppearanceHeader.Options.UseTextOptions = True
        Me.col_bank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_bank.Caption = "Bank"
        Me.col_bank.FieldName = "bank"
        Me.col_bank.Name = "col_bank"
        Me.col_bank.Visible = True
        Me.col_bank.VisibleIndex = 4
        Me.col_bank.Width = 85
        '
        'col_crossed_check
        '
        Me.col_crossed_check.AppearanceCell.Options.UseTextOptions = True
        Me.col_crossed_check.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_crossed_check.Caption = "CC"
        Me.col_crossed_check.ColumnEdit = Me.cb_cc
        Me.col_crossed_check.FieldName = "is_crossed_check"
        Me.col_crossed_check.Name = "col_crossed_check"
        Me.col_crossed_check.Visible = True
        Me.col_crossed_check.VisibleIndex = 8
        '
        'cb_cc
        '
        Me.cb_cc.AutoHeight = False
        Me.cb_cc.Name = "cb_cc"
        Me.cb_cc.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'col_delete
        '
        Me.col_delete.Caption = "Action"
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.MaxWidth = 40
        Me.col_delete.MinWidth = 40
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 0
        Me.col_delete.Width = 40
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.close_16x16
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'frm_accounting_generate_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1278, 802)
        Me.Controls.Add(Me.grid_cheque)
        Me.Controls.Add(Me.lbl_receipt_no)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_collection_ref)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.grid_returns)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.txt_total_view)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.panel_cheque)
        Me.Controls.Add(Me.grid_receipts)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Controls.Add(Me.btn_generate)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_accounting_generate_payment"
        Me.Text = "frm_accounting_generate_payment"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.grid_receipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_cheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_cheque.ResumeLayout(False)
        Me.panel_cheque.PerformLayout()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_banks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_collection_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.lbl_receipt_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_cc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_receipts As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_receipts_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_receipt_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_purchase_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemMemoEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit
    Friend WithEvents btn_generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents panel_cheque As DevExpress.XtraEditors.PanelControl
    Friend WithEvents cbb_suppliers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cheque_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_acc_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_banks As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_payee As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total_view As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_due_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_po_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_acc_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents DateEdit1 As DevExpress.XtraEditors.DateEdit
    Friend WithEvents cb_crossed_check As CheckBox
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_createdat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents rb_cash As RadioButton
    Friend WithEvents rb_cheque As RadioButton
    Friend WithEvents txt_collection_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_receipt_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_add As Button
    Friend WithEvents grid_cheque As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_cheque_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_cheque_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cheque_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cheque_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_crossed_check As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cb_cc As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
