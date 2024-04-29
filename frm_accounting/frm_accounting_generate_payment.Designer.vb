<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_generate_payment
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
        Me.grid_receipts = New DevExpress.XtraGrid.GridControl()
        Me.grid_receipts_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_po_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_purchase_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_ewt = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dr_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dr_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_si_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_si_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemMemoEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit()
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton()
        Me.panel_cheque = New DevExpress.XtraEditors.PanelControl()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.cb_crossed_check = New System.Windows.Forms.CheckBox()
        Me.txt_acc_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_payee = New DevExpress.XtraEditors.TextEdit()
        Me.DateEdit1 = New DevExpress.XtraEditors.DateEdit()
        Me.cbb_banks = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
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
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_payor_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_receipts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.panel_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_cheque.SuspendLayout()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_banks.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_collection_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.lbl_receipt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_cc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_payor_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_receipts
        '
        Me.grid_receipts.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_receipts.Location = New System.Drawing.Point(413, 144)
        Me.grid_receipts.MainView = Me.grid_receipts_view
        Me.grid_receipts.Name = "grid_receipts"
        Me.grid_receipts.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemMemoEdit1})
        Me.grid_receipts.Size = New System.Drawing.Size(1025, 333)
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
        Me.grid_receipts_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_po_id, Me.col_amount, Me.col_date_received, Me.col_purchase_id, Me.col_terms, Me.col_due_date, Me.col_ewt, Me.col_dr_no, Me.col_dr_date, Me.col_si_no, Me.col_si_date})
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
        Me.col_purchase_id.VisibleIndex = 6
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
        Me.col_terms.VisibleIndex = 12
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
        'col_ewt
        '
        Me.col_ewt.Caption = "EWT"
        Me.col_ewt.DisplayFormat.FormatString = "c2"
        Me.col_ewt.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_ewt.FieldName = "ewt"
        Me.col_ewt.Name = "col_ewt"
        Me.col_ewt.Visible = True
        Me.col_ewt.VisibleIndex = 5
        '
        'col_dr_no
        '
        Me.col_dr_no.Caption = "DR No."
        Me.col_dr_no.FieldName = "dr_no"
        Me.col_dr_no.Name = "col_dr_no"
        Me.col_dr_no.Visible = True
        Me.col_dr_no.VisibleIndex = 8
        '
        'col_dr_date
        '
        Me.col_dr_date.Caption = "DR Date"
        Me.col_dr_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_dr_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_dr_date.FieldName = "dr_date"
        Me.col_dr_date.Name = "col_dr_date"
        Me.col_dr_date.Visible = True
        Me.col_dr_date.VisibleIndex = 9
        '
        'col_si_no
        '
        Me.col_si_no.Caption = "SI No."
        Me.col_si_no.FieldName = "si_no"
        Me.col_si_no.Name = "col_si_no"
        Me.col_si_no.Visible = True
        Me.col_si_no.VisibleIndex = 10
        '
        'col_si_date
        '
        Me.col_si_date.Caption = "SI Date"
        Me.col_si_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_si_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_si_date.FieldName = "si_date"
        Me.col_si_date.Name = "col_si_date"
        Me.col_si_date.Visible = True
        Me.col_si_date.VisibleIndex = 11
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
        Me.btn_generate.Location = New System.Drawing.Point(12, 741)
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
        Me.panel_cheque.Controls.Add(Me.txt_acc_name)
        Me.panel_cheque.Controls.Add(Me.LabelControl11)
        Me.panel_cheque.Controls.Add(Me.txt_acc_no)
        Me.panel_cheque.Controls.Add(Me.LabelControl6)
        Me.panel_cheque.Controls.Add(Me.LabelControl10)
        Me.panel_cheque.Controls.Add(Me.LabelControl5)
        Me.panel_cheque.Controls.Add(Me.txt_payee)
        Me.panel_cheque.Location = New System.Drawing.Point(12, 300)
        Me.panel_cheque.Name = "panel_cheque"
        Me.panel_cheque.Size = New System.Drawing.Size(395, 245)
        Me.panel_cheque.TabIndex = 14
        '
        'txt_amount
        '
        Me.txt_amount.EditValue = ""
        Me.txt_amount.Location = New System.Drawing.Point(114, 152)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_amount.Properties.Appearance.Options.UseFont = True
        Me.txt_amount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_amount.Properties.MaskSettings.Set("autoHideDecimalSeparator", Nothing)
        Me.txt_amount.Properties.MaskSettings.Set("mask", "n2")
        Me.txt_amount.Properties.UseMaskAsDisplayFormat = True
        Me.txt_amount.Size = New System.Drawing.Size(149, 30)
        Me.txt_amount.TabIndex = 22
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Location = New System.Drawing.Point(8, 159)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(49, 16)
        Me.LabelControl15.TabIndex = 23
        Me.LabelControl15.Text = "Amount:"
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(299, 199)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(89, 32)
        Me.btn_add.TabIndex = 21
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'cb_crossed_check
        '
        Me.cb_crossed_check.AutoSize = True
        Me.cb_crossed_check.Checked = True
        Me.cb_crossed_check.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cb_crossed_check.Location = New System.Drawing.Point(8, 207)
        Me.cb_crossed_check.Name = "cb_crossed_check"
        Me.cb_crossed_check.Size = New System.Drawing.Size(127, 17)
        Me.cb_crossed_check.TabIndex = 20
        Me.cb_crossed_check.Text = "Apply Crossed Check"
        Me.cb_crossed_check.UseVisualStyleBackColor = True
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Location = New System.Drawing.Point(114, 116)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_acc_name.Properties.Appearance.Options.UseFont = True
        Me.txt_acc_name.Size = New System.Drawing.Size(252, 30)
        Me.txt_acc_name.TabIndex = 6
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(8, 123)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl11.TabIndex = 18
        Me.LabelControl11.Text = "Account Name:"
        '
        'txt_acc_no
        '
        Me.txt_acc_no.EditValue = ""
        Me.txt_acc_no.Location = New System.Drawing.Point(114, 80)
        Me.txt_acc_no.Name = "txt_acc_no"
        Me.txt_acc_no.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_acc_no.Properties.Appearance.Options.UseFont = True
        Me.txt_acc_no.Size = New System.Drawing.Size(252, 30)
        Me.txt_acc_no.TabIndex = 5
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(8, 87)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl6.TabIndex = 9
        Me.LabelControl6.Text = "Account No.:"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Appearance.Options.UseTextOptions = True
        Me.LabelControl10.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl10.Location = New System.Drawing.Point(2, 14)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl10.Size = New System.Drawing.Size(108, 16)
        Me.LabelControl10.TabIndex = 16
        Me.LabelControl10.Text = "Payee Account"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(8, 51)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl5.TabIndex = 8
        Me.LabelControl5.Text = "Payee Name:"
        '
        'txt_payee
        '
        Me.txt_payee.Location = New System.Drawing.Point(114, 44)
        Me.txt_payee.Name = "txt_payee"
        Me.txt_payee.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_payee.Properties.Appearance.Options.UseFont = True
        Me.txt_payee.Size = New System.Drawing.Size(252, 30)
        Me.txt_payee.TabIndex = 4
        '
        'DateEdit1
        '
        Me.DateEdit1.EditValue = Nothing
        Me.DateEdit1.Location = New System.Drawing.Point(244, 143)
        Me.DateEdit1.Name = "DateEdit1"
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.DateEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.DateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateEdit1.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew
        Me.DateEdit1.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.DateEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.DateEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        Me.DateEdit1.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.[False]
        Me.DateEdit1.Size = New System.Drawing.Size(28, 28)
        Me.DateEdit1.TabIndex = 19
        '
        'cbb_banks
        '
        Me.cbb_banks.Location = New System.Drawing.Point(109, 42)
        Me.cbb_banks.Name = "cbb_banks"
        Me.cbb_banks.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.cbb_banks.Properties.Appearance.Options.UseFont = True
        Me.cbb_banks.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_banks.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_banks.Size = New System.Drawing.Size(183, 30)
        Me.cbb_banks.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(14, 49)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "*Payor Bank:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(127, 122)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(86, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "*Cheque Date:"
        '
        'txt_cheque_date
        '
        Me.txt_cheque_date.Location = New System.Drawing.Point(141, 143)
        Me.txt_cheque_date.Name = "txt_cheque_date"
        Me.txt_cheque_date.Size = New System.Drawing.Size(100, 28)
        Me.txt_cheque_date.TabIndex = 2
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 119)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "*Cheque No.:"
        '
        'txt_cheque_no
        '
        Me.txt_cheque_no.Location = New System.Drawing.Point(26, 141)
        Me.txt_cheque_no.Name = "txt_cheque_no"
        Me.txt_cheque_no.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.txt_cheque_no.Properties.Appearance.Options.UseFont = True
        Me.txt_cheque_no.Size = New System.Drawing.Size(109, 30)
        Me.txt_cheque_no.TabIndex = 1
        '
        'LabelControl13
        '
        Me.LabelControl13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(11, 703)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl13.TabIndex = 26
        Me.LabelControl13.Text = "Collection Ref.:"
        '
        'txt_collection_ref
        '
        Me.txt_collection_ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_collection_ref.EditValue = ""
        Me.txt_collection_ref.Location = New System.Drawing.Point(113, 695)
        Me.txt_collection_ref.Name = "txt_collection_ref"
        Me.txt_collection_ref.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_collection_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_collection_ref.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_collection_ref.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.txt_collection_ref.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_collection_ref.Size = New System.Drawing.Size(149, 32)
        Me.txt_collection_ref.TabIndex = 25
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(413, 114)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Supplier:"
        '
        'cbb_suppliers
        '
        Me.cbb_suppliers.Location = New System.Drawing.Point(472, 107)
        Me.cbb_suppliers.Name = "cbb_suppliers"
        Me.cbb_suppliers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_suppliers.Size = New System.Drawing.Size(271, 28)
        Me.cbb_suppliers.TabIndex = 0
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(1112, 754)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl9.TabIndex = 15
        Me.LabelControl9.Text = "Total Amount:"
        '
        'txt_total_view
        '
        Me.txt_total_view.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_view.EditValue = ""
        Me.txt_total_view.Location = New System.Drawing.Point(1259, 747)
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
        Me.txt_total_view.Size = New System.Drawing.Size(179, 36)
        Me.txt_total_view.TabIndex = 17
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns.Location = New System.Drawing.Point(415, 510)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order})
        Me.grid_returns.Size = New System.Drawing.Size(1025, 231)
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
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(415, 483)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl8.TabIndex = 20
        Me.LabelControl8.Text = "Credit Memo"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LabelControl12)
        Me.Panel1.Controls.Add(Me.rb_cash)
        Me.Panel1.Controls.Add(Me.rb_cheque)
        Me.Panel1.Location = New System.Drawing.Point(14, 63)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 34)
        Me.Panel1.TabIndex = 21
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(6, 9)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(95, 17)
        Me.LabelControl12.TabIndex = 2
        Me.LabelControl12.Text = "Payment Type:"
        '
        'rb_cash
        '
        Me.rb_cash.AutoSize = True
        Me.rb_cash.Font = New System.Drawing.Font("Tahoma", 10.25!)
        Me.rb_cash.Location = New System.Drawing.Point(200, 7)
        Me.rb_cash.Name = "rb_cash"
        Me.rb_cash.Size = New System.Drawing.Size(56, 21)
        Me.rb_cash.TabIndex = 1
        Me.rb_cash.Text = "Cash"
        Me.rb_cash.UseVisualStyleBackColor = True
        Me.rb_cash.Visible = False
        '
        'rb_cheque
        '
        Me.rb_cheque.AutoSize = True
        Me.rb_cheque.Checked = True
        Me.rb_cheque.Font = New System.Drawing.Font("Tahoma", 10.25!)
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
        Me.LabelControl14.Location = New System.Drawing.Point(881, 754)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(134, 22)
        Me.LabelControl14.TabIndex = 27
        Me.LabelControl14.Text = "No. of Receipt:"
        '
        'lbl_receipt_no
        '
        Me.lbl_receipt_no.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_receipt_no.EditValue = ""
        Me.lbl_receipt_no.Location = New System.Drawing.Point(1021, 748)
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
        Me.lbl_receipt_no.Size = New System.Drawing.Size(74, 36)
        Me.lbl_receipt_no.TabIndex = 29
        '
        'grid_cheque
        '
        Me.grid_cheque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_cheque.Location = New System.Drawing.Point(12, 576)
        Me.grid_cheque.MainView = Me.grid_cheque_view
        Me.grid_cheque.Name = "grid_cheque"
        Me.grid_cheque.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cb_cc, Me.btn_delete})
        Me.grid_cheque.Size = New System.Drawing.Size(395, 113)
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
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(227, 31)
        Me.LabelControl16.TabIndex = 54
        Me.LabelControl16.Text = "Generate Payment"
        '
        'PanelControl1
        '
        Me.PanelControl1.Controls.Add(Me.LabelControl18)
        Me.PanelControl1.Controls.Add(Me.txt_payor_acc_no)
        Me.PanelControl1.Controls.Add(Me.LabelControl17)
        Me.PanelControl1.Controls.Add(Me.DateEdit1)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.txt_cheque_no)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txt_cheque_date)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.cbb_banks)
        Me.PanelControl1.Location = New System.Drawing.Point(12, 114)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(395, 180)
        Me.PanelControl1.TabIndex = 55
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseTextOptions = True
        Me.LabelControl18.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.LabelControl18.Location = New System.Drawing.Point(2, 14)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.LabelControl18.Size = New System.Drawing.Size(106, 16)
        Me.LabelControl18.TabIndex = 20
        Me.LabelControl18.Text = "Payor Account"
        '
        'txt_payor_acc_no
        '
        Me.txt_payor_acc_no.EditValue = ""
        Me.txt_payor_acc_no.Enabled = False
        Me.txt_payor_acc_no.Location = New System.Drawing.Point(110, 78)
        Me.txt_payor_acc_no.Name = "txt_payor_acc_no"
        Me.txt_payor_acc_no.Size = New System.Drawing.Size(244, 28)
        Me.txt_payor_acc_no.TabIndex = 10
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Location = New System.Drawing.Point(14, 85)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl17.TabIndex = 11
        Me.LabelControl17.Text = "Account No.:"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.Red
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 551)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(188, 16)
        Me.LabelControl7.TabIndex = 56
        Me.LabelControl7.Text = "**NOTE: Limit to 1 Cheque only."
        '
        'frm_accounting_generate_payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1456, 790)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.cbb_suppliers)
        Me.Controls.Add(Me.grid_cheque)
        Me.Controls.Add(Me.lbl_receipt_no)
        Me.Controls.Add(Me.LabelControl14)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txt_collection_ref)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.grid_returns)
        Me.Controls.Add(Me.txt_total_view)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.panel_cheque)
        Me.Controls.Add(Me.grid_receipts)
        Me.Controls.Add(Me.btn_generate)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_accounting_generate_payment.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_accounting_generate_payment"
        Me.Text = "Generate Payment"
        CType(Me.grid_receipts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_receipts_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemMemoEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.panel_cheque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_cheque.ResumeLayout(False)
        Me.panel_cheque.PerformLayout()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_banks.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cheque_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_collection_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_suppliers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_payor_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_receipts As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_receipts_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
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
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_payor_acc_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_dr_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dr_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_si_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_si_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_ewt As DevExpress.XtraGrid.Columns.GridColumn
End Class
