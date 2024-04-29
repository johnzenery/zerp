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

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_payment_terms
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_payment_terms))
        Me.txt_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_date = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_acc_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_total = New DevExpress.XtraEditors.TextEdit()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.grid_cheque = New DevExpress.XtraGrid.GridControl()
        Me.grid_cheque_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_cheque_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.grid_transaction = New DevExpress.XtraGrid.GridControl()
        Me.grid_transaction_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_poref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_released = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transc_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payments_made = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_balance = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_invoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_bank = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_srid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_return_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridView4 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbb_payee = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_customer_name = New DevExpress.XtraEditors.TextEdit()
        Me.btn_apply = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_select = New System.Windows.Forms.Button()
        Me.lbl_customer_id = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total_amount_cheques = New DevExpress.XtraEditors.LabelControl()
        Me.btn_select_from_soa = New System.Windows.Forms.Button()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_indicator = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transaction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transaction_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_bank.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_payee.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(16, 190)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_no.Size = New System.Drawing.Size(106, 28)
        Me.txt_no.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 170)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(72, 14)
        Me.LabelControl5.TabIndex = 40
        Me.LabelControl5.Text = "*Cheque No."
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(237, 170)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl6.TabIndex = 41
        Me.LabelControl6.Text = "*Amount"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(18, 69)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(69, 14)
        Me.LabelControl7.TabIndex = 43
        Me.LabelControl7.Text = "Account No."
        '
        'txt_acc_no
        '
        Me.txt_acc_no.Location = New System.Drawing.Point(129, 62)
        Me.txt_acc_no.Name = "txt_acc_no"
        Me.txt_acc_no.Size = New System.Drawing.Size(166, 28)
        Me.txt_acc_no.TabIndex = 2
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(128, 170)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(79, 14)
        Me.LabelControl8.TabIndex = 45
        Me.LabelControl8.Text = "*Cheque Date"
        '
        'dt_date
        '
        Me.dt_date.EditValue = Nothing
        Me.dt_date.Location = New System.Drawing.Point(128, 190)
        Me.dt_date.Name = "dt_date"
        Me.dt_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_date.Properties.DisplayFormat.FormatString = "MM/dd/yyy"
        Me.dt_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_date.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.dt_date.Size = New System.Drawing.Size(100, 28)
        Me.dt_date.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(18, 102)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(81, 14)
        Me.LabelControl9.TabIndex = 47
        Me.LabelControl9.Text = "Account Name"
        '
        'txt_acc_name
        '
        Me.txt_acc_name.Location = New System.Drawing.Point(128, 96)
        Me.txt_acc_name.Name = "txt_acc_name"
        Me.txt_acc_name.Size = New System.Drawing.Size(341, 28)
        Me.txt_acc_name.TabIndex = 3
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(18, 136)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(68, 14)
        Me.LabelControl10.TabIndex = 49
        Me.LabelControl10.Text = "Payee Name"
        '
        'txt_total
        '
        Me.txt_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total.EditValue = ""
        Me.txt_total.Location = New System.Drawing.Point(989, 451)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold)
        Me.txt_total.Properties.Appearance.Options.UseFont = True
        Me.txt_total.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_total.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_total.Properties.ReadOnly = True
        Me.txt_total.Properties.UseReadOnlyAppearance = False
        Me.txt_total.Size = New System.Drawing.Size(158, 30)
        Me.txt_total.TabIndex = 42
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(347, 188)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(67, 30)
        Me.btn_add.TabIndex = 8
        Me.btn_add.Text = "Add"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'grid_cheque
        '
        Me.grid_cheque.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_cheque.Location = New System.Drawing.Point(18, 237)
        Me.grid_cheque.MainView = Me.grid_cheque_view
        Me.grid_cheque.Name = "grid_cheque"
        Me.grid_cheque.Size = New System.Drawing.Size(451, 239)
        Me.grid_cheque.TabIndex = 52
        Me.grid_cheque.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_cheque_view, Me.GridView1})
        '
        'grid_cheque_view
        '
        Me.grid_cheque_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_cheque_no, Me.col_cheque_date, Me.col_cheque_amount, Me.col_acc_no, Me.col_acc_name, Me.col_payee, Me.col_bank})
        Me.grid_cheque_view.GridControl = Me.grid_cheque
        Me.grid_cheque_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_cheque_view.Name = "grid_cheque_view"
        Me.grid_cheque_view.OptionsBehavior.ReadOnly = True
        Me.grid_cheque_view.OptionsSelection.MultiSelect = True
        Me.grid_cheque_view.OptionsView.ColumnAutoWidth = False
        Me.grid_cheque_view.OptionsView.ShowGroupPanel = False
        Me.grid_cheque_view.OptionsView.ShowIndicator = False
        '
        'col_cheque_no
        '
        Me.col_cheque_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_cheque_no.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_cheque_no.AppearanceHeader.Options.UseFont = True
        Me.col_cheque_no.AppearanceHeader.Options.UseForeColor = True
        Me.col_cheque_no.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cheque_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_no.Caption = "Cheque No"
        Me.col_cheque_no.FieldName = "cheque_no"
        Me.col_cheque_no.MaxWidth = 120
        Me.col_cheque_no.Name = "col_cheque_no"
        Me.col_cheque_no.Visible = True
        Me.col_cheque_no.VisibleIndex = 0
        Me.col_cheque_no.Width = 92
        '
        'col_cheque_date
        '
        Me.col_cheque_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_cheque_date.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_cheque_date.AppearanceHeader.Options.UseFont = True
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
        Me.col_cheque_date.VisibleIndex = 1
        Me.col_cheque_date.Width = 78
        '
        'col_cheque_amount
        '
        Me.col_cheque_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_cheque_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_cheque_amount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_cheque_amount.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_cheque_amount.AppearanceHeader.Options.UseFont = True
        Me.col_cheque_amount.AppearanceHeader.Options.UseForeColor = True
        Me.col_cheque_amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_cheque_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_cheque_amount.Caption = "Amount"
        Me.col_cheque_amount.DisplayFormat.FormatString = "c2"
        Me.col_cheque_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cheque_amount.FieldName = "cheque_amount"
        Me.col_cheque_amount.Name = "col_cheque_amount"
        Me.col_cheque_amount.Visible = True
        Me.col_cheque_amount.VisibleIndex = 2
        Me.col_cheque_amount.Width = 92
        '
        'col_acc_no
        '
        Me.col_acc_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_acc_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_acc_no.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_acc_no.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_acc_no.AppearanceHeader.Options.UseFont = True
        Me.col_acc_no.AppearanceHeader.Options.UseForeColor = True
        Me.col_acc_no.AppearanceHeader.Options.UseTextOptions = True
        Me.col_acc_no.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_acc_no.Caption = "Acc. No."
        Me.col_acc_no.FieldName = "acc_no"
        Me.col_acc_no.Name = "col_acc_no"
        Me.col_acc_no.Visible = True
        Me.col_acc_no.VisibleIndex = 4
        Me.col_acc_no.Width = 108
        '
        'col_acc_name
        '
        Me.col_acc_name.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_acc_name.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_acc_name.AppearanceHeader.Options.UseFont = True
        Me.col_acc_name.AppearanceHeader.Options.UseForeColor = True
        Me.col_acc_name.AppearanceHeader.Options.UseTextOptions = True
        Me.col_acc_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_acc_name.Caption = "Acc. Name"
        Me.col_acc_name.FieldName = "acc_name"
        Me.col_acc_name.Name = "col_acc_name"
        Me.col_acc_name.Visible = True
        Me.col_acc_name.VisibleIndex = 5
        '
        'col_payee
        '
        Me.col_payee.AppearanceCell.Options.UseTextOptions = True
        Me.col_payee.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payee.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_payee.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_payee.AppearanceHeader.Options.UseFont = True
        Me.col_payee.AppearanceHeader.Options.UseForeColor = True
        Me.col_payee.AppearanceHeader.Options.UseTextOptions = True
        Me.col_payee.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payee.Caption = "Payee"
        Me.col_payee.FieldName = "payee"
        Me.col_payee.Name = "col_payee"
        Me.col_payee.Visible = True
        Me.col_payee.VisibleIndex = 6
        '
        'col_bank
        '
        Me.col_bank.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_bank.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_bank.AppearanceHeader.Options.UseFont = True
        Me.col_bank.AppearanceHeader.Options.UseForeColor = True
        Me.col_bank.AppearanceHeader.Options.UseTextOptions = True
        Me.col_bank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_bank.Caption = "Bank"
        Me.col_bank.FieldName = "bank"
        Me.col_bank.Name = "col_bank"
        Me.col_bank.Visible = True
        Me.col_bank.VisibleIndex = 3
        Me.col_bank.Width = 85
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.grid_cheque
        Me.GridView1.Name = "GridView1"
        '
        'grid_transaction
        '
        Me.grid_transaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_transaction.Location = New System.Drawing.Point(0, 25)
        Me.grid_transaction.MainView = Me.grid_transaction_view
        Me.grid_transaction.Name = "grid_transaction"
        Me.grid_transaction.Size = New System.Drawing.Size(654, 247)
        Me.grid_transaction.TabIndex = 1
        Me.grid_transaction.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transaction_view, Me.GridView2})
        '
        'grid_transaction_view
        '
        Me.grid_transaction_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_transaction_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transaction_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_poref, Me.col_id, Me.col_date_released, Me.col_due_date, Me.col_transc_amount, Me.col_payments_made, Me.col_balance, Me.col_invoice})
        Me.grid_transaction_view.GridControl = Me.grid_transaction
        Me.grid_transaction_view.Name = "grid_transaction_view"
        Me.grid_transaction_view.OptionsBehavior.ReadOnly = True
        Me.grid_transaction_view.OptionsSelection.MultiSelect = True
        Me.grid_transaction_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_transaction_view.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_transaction_view.OptionsView.ShowGroupPanel = False
        Me.grid_transaction_view.OptionsView.ShowIndicator = False
        '
        'col_poref
        '
        Me.col_poref.Caption = "PO Ref."
        Me.col_poref.FieldName = "po_reference"
        Me.col_poref.Name = "col_poref"
        Me.col_poref.Visible = True
        Me.col_poref.VisibleIndex = 1
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "Order ID"
        Me.col_id.FieldName = "order_id"
        Me.col_id.MaxWidth = 80
        Me.col_id.MinWidth = 60
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 2
        Me.col_id.Width = 67
        '
        'col_date_released
        '
        Me.col_date_released.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_released.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_released.Caption = "Date"
        Me.col_date_released.DisplayFormat.FormatString = "d"
        Me.col_date_released.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_released.FieldName = "date_ordered"
        Me.col_date_released.MaxWidth = 100
        Me.col_date_released.MinWidth = 80
        Me.col_date_released.Name = "col_date_released"
        Me.col_date_released.Visible = True
        Me.col_date_released.VisibleIndex = 3
        Me.col_date_released.Width = 90
        '
        'col_due_date
        '
        Me.col_due_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_due_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_due_date.Caption = "Due Date"
        Me.col_due_date.DisplayFormat.FormatString = "d"
        Me.col_due_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_due_date.FieldName = "due_date"
        Me.col_due_date.Name = "col_due_date"
        Me.col_due_date.Visible = True
        Me.col_due_date.VisibleIndex = 4
        Me.col_due_date.Width = 82
        '
        'col_transc_amount
        '
        Me.col_transc_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_transc_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_transc_amount.Caption = "Amount"
        Me.col_transc_amount.DisplayFormat.FormatString = "c2"
        Me.col_transc_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_transc_amount.FieldName = "amount_due"
        Me.col_transc_amount.Name = "col_transc_amount"
        Me.col_transc_amount.Visible = True
        Me.col_transc_amount.VisibleIndex = 5
        Me.col_transc_amount.Width = 106
        '
        'col_payments_made
        '
        Me.col_payments_made.AppearanceCell.Options.UseTextOptions = True
        Me.col_payments_made.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_payments_made.Caption = "Payments Made"
        Me.col_payments_made.DisplayFormat.FormatString = "c2"
        Me.col_payments_made.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_payments_made.FieldName = "paid_amount"
        Me.col_payments_made.Name = "col_payments_made"
        Me.col_payments_made.Visible = True
        Me.col_payments_made.VisibleIndex = 6
        Me.col_payments_made.Width = 103
        '
        'col_balance
        '
        Me.col_balance.AppearanceCell.Options.UseTextOptions = True
        Me.col_balance.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_balance.Caption = "Balance"
        Me.col_balance.DisplayFormat.FormatString = "c2"
        Me.col_balance.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_balance.FieldName = "balance"
        Me.col_balance.Name = "col_balance"
        Me.col_balance.Visible = True
        Me.col_balance.VisibleIndex = 7
        Me.col_balance.Width = 103
        '
        'col_invoice
        '
        Me.col_invoice.Caption = "Invoice"
        Me.col_invoice.FieldName = "invoice_no"
        Me.col_invoice.Name = "col_invoice"
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.grid_transaction
        Me.GridView2.Name = "GridView2"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(654, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNPAID ORDERS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(236, 190)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_amount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_amount.Size = New System.Drawing.Size(105, 28)
        Me.txt_amount.TabIndex = 7
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 34)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(75, 14)
        Me.LabelControl3.TabIndex = 54
        Me.LabelControl3.Text = "*Select Bank:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(903, 460)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(74, 14)
        Me.LabelControl1.TabIndex = 53
        Me.LabelControl1.Text = "Amount Due:"
        '
        'cbb_bank
        '
        Me.cbb_bank.Location = New System.Drawing.Point(128, 28)
        Me.cbb_bank.Name = "cbb_bank"
        Me.cbb_bank.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_bank.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_bank.Size = New System.Drawing.Size(166, 28)
        Me.cbb_bank.TabIndex = 1
        '
        'btn_delete
        '
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_16x16
        Me.btn_delete.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_delete.Location = New System.Drawing.Point(420, 188)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(47, 30)
        Me.btn_delete.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.PanelControl2)
        Me.GroupBox1.Controls.Add(Me.PanelControl1)
        Me.GroupBox1.Controls.Add(Me.cbb_payee)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.cbb_bank)
        Me.GroupBox1.Controls.Add(Me.LabelControl1)
        Me.GroupBox1.Controls.Add(Me.LabelControl3)
        Me.GroupBox1.Controls.Add(Me.txt_amount)
        Me.GroupBox1.Controls.Add(Me.grid_cheque)
        Me.GroupBox1.Controls.Add(Me.btn_add)
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.LabelControl10)
        Me.GroupBox1.Controls.Add(Me.txt_acc_name)
        Me.GroupBox1.Controls.Add(Me.LabelControl9)
        Me.GroupBox1.Controls.Add(Me.dt_date)
        Me.GroupBox1.Controls.Add(Me.LabelControl8)
        Me.GroupBox1.Controls.Add(Me.txt_acc_no)
        Me.GroupBox1.Controls.Add(Me.LabelControl7)
        Me.GroupBox1.Controls.Add(Me.LabelControl6)
        Me.GroupBox1.Controls.Add(Me.LabelControl5)
        Me.GroupBox1.Controls.Add(Me.txt_no)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 111)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1157, 491)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cheque Details"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl2.Controls.Add(Me.grid_transaction)
        Me.PanelControl2.Controls.Add(Me.Label1)
        Me.PanelControl2.Location = New System.Drawing.Point(493, 19)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(654, 272)
        Me.PanelControl2.TabIndex = 60
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.grid_returns)
        Me.PanelControl1.Controls.Add(Me.Label2)
        Me.PanelControl1.Location = New System.Drawing.Point(493, 297)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(654, 148)
        Me.PanelControl1.TabIndex = 60
        '
        'grid_returns
        '
        Me.grid_returns.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_returns.Location = New System.Drawing.Point(0, 25)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.Size = New System.Drawing.Size(654, 123)
        Me.grid_returns.TabIndex = 1
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view, Me.GridView4})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_srid, Me.GridColumn3, Me.col_return_amount})
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_returns_view.OptionsSelection.MultiSelect = True
        Me.grid_returns_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_returns_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_returns_view.OptionsSelection.UseIndicatorForSelection = False
        Me.grid_returns_view.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_returns_view.OptionsView.ShowGroupPanel = False
        Me.grid_returns_view.OptionsView.ShowIndicator = False
        '
        'col_srid
        '
        Me.col_srid.AppearanceCell.Options.UseTextOptions = True
        Me.col_srid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_srid.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_srid.AppearanceHeader.Options.UseFont = True
        Me.col_srid.AppearanceHeader.Options.UseForeColor = True
        Me.col_srid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_srid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_srid.Caption = "SRID"
        Me.col_srid.FieldName = "srid"
        Me.col_srid.MaxWidth = 80
        Me.col_srid.MinWidth = 60
        Me.col_srid.Name = "col_srid"
        Me.col_srid.Visible = True
        Me.col_srid.VisibleIndex = 1
        Me.col_srid.Width = 60
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.GridColumn3.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.GridColumn3.AppearanceHeader.Options.UseFont = True
        Me.GridColumn3.AppearanceHeader.Options.UseForeColor = True
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Date Created"
        Me.GridColumn3.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn3.FieldName = "created_at"
        Me.GridColumn3.MaxWidth = 100
        Me.GridColumn3.MinWidth = 80
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 80
        '
        'col_return_amount
        '
        Me.col_return_amount.AppearanceCell.Options.UseTextOptions = True
        Me.col_return_amount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_return_amount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_return_amount.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_return_amount.AppearanceHeader.Options.UseFont = True
        Me.col_return_amount.AppearanceHeader.Options.UseForeColor = True
        Me.col_return_amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_return_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_return_amount.Caption = "Amount"
        Me.col_return_amount.DisplayFormat.FormatString = "c2"
        Me.col_return_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_return_amount.FieldName = "amount"
        Me.col_return_amount.Name = "col_return_amount"
        Me.col_return_amount.Visible = True
        Me.col_return_amount.VisibleIndex = 3
        Me.col_return_amount.Width = 88
        '
        'GridView4
        '
        Me.GridView4.GridControl = Me.grid_returns
        Me.GridView4.Name = "GridView4"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.SteelBlue
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label2.Size = New System.Drawing.Size(654, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "SALES RETURNS"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbb_payee
        '
        Me.cbb_payee.Location = New System.Drawing.Point(128, 130)
        Me.cbb_payee.Name = "cbb_payee"
        Me.cbb_payee.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_payee.Size = New System.Drawing.Size(258, 28)
        Me.cbb_payee.TabIndex = 55
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(22, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(63, 14)
        Me.LabelControl2.TabIndex = 29
        Me.LabelControl2.Text = "Customer:"
        '
        'txt_customer_name
        '
        Me.txt_customer_name.Enabled = False
        Me.txt_customer_name.Location = New System.Drawing.Point(100, 78)
        Me.txt_customer_name.Name = "txt_customer_name"
        Me.txt_customer_name.Size = New System.Drawing.Size(139, 28)
        Me.txt_customer_name.TabIndex = 45
        '
        'btn_apply
        '
        Me.btn_apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_apply.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_apply.Appearance.Options.UseBackColor = True
        Me.btn_apply.Location = New System.Drawing.Point(1040, 608)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(129, 35)
        Me.btn_apply.TabIndex = 32
        Me.btn_apply.Text = "Apply"
        '
        'btn_select
        '
        Me.btn_select.Location = New System.Drawing.Point(242, 77)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(75, 29)
        Me.btn_select.TabIndex = 0
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'lbl_customer_id
        '
        Me.lbl_customer_id.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_customer_id.Appearance.Options.UseFont = True
        Me.lbl_customer_id.Location = New System.Drawing.Point(272, 57)
        Me.lbl_customer_id.Name = "lbl_customer_id"
        Me.lbl_customer_id.Size = New System.Drawing.Size(9, 14)
        Me.lbl_customer_id.TabIndex = 51
        Me.lbl_customer_id.Text = "id"
        Me.lbl_customer_id.Visible = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Location = New System.Drawing.Point(905, 608)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(129, 35)
        Me.btn_cancel.TabIndex = 52
        Me.btn_cancel.Text = "Cancel"
        '
        'LabelControl11
        '
        Me.LabelControl11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(261, 618)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(103, 19)
        Me.LabelControl11.TabIndex = 55
        Me.LabelControl11.Text = "Total Amount"
        '
        'lbl_total_amount_cheques
        '
        Me.lbl_total_amount_cheques.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_amount_cheques.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_total_amount_cheques.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total_amount_cheques.Appearance.Options.UseBackColor = True
        Me.lbl_total_amount_cheques.Appearance.Options.UseFont = True
        Me.lbl_total_amount_cheques.Appearance.Options.UseTextOptions = True
        Me.lbl_total_amount_cheques.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_amount_cheques.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_amount_cheques.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        Me.lbl_total_amount_cheques.Location = New System.Drawing.Point(381, 614)
        Me.lbl_total_amount_cheques.Name = "lbl_total_amount_cheques"
        Me.lbl_total_amount_cheques.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total_amount_cheques.Size = New System.Drawing.Size(157, 28)
        Me.lbl_total_amount_cheques.TabIndex = 56
        Me.lbl_total_amount_cheques.Text = "₱0.00"
        '
        'btn_select_from_soa
        '
        Me.btn_select_from_soa.BackColor = System.Drawing.Color.SteelBlue
        Me.btn_select_from_soa.FlatAppearance.BorderSize = 0
        Me.btn_select_from_soa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_select_from_soa.ForeColor = System.Drawing.Color.White
        Me.btn_select_from_soa.Location = New System.Drawing.Point(369, 80)
        Me.btn_select_from_soa.Name = "btn_select_from_soa"
        Me.btn_select_from_soa.Size = New System.Drawing.Size(107, 25)
        Me.btn_select_from_soa.TabIndex = 57
        Me.btn_select_from_soa.Text = "Select from Billing"
        Me.btn_select_from_soa.UseVisualStyleBackColor = False
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(323, 85)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(40, 14)
        Me.LabelControl4.TabIndex = 58
        Me.LabelControl4.Text = "And/Or"
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(22, 23)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(191, 31)
        Me.LabelControl12.TabIndex = 59
        Me.LabelControl12.Text = "Payment Terms"
        '
        'lbl_indicator
        '
        Me.lbl_indicator.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_indicator.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.lbl_indicator.Appearance.Options.UseFont = True
        Me.lbl_indicator.Appearance.Options.UseForeColor = True
        Me.lbl_indicator.Location = New System.Drawing.Point(491, 88)
        Me.lbl_indicator.Name = "lbl_indicator"
        Me.lbl_indicator.Size = New System.Drawing.Size(328, 14)
        Me.lbl_indicator.TabIndex = 60
        Me.lbl_indicator.Text = "**Loaded unpaid and partially paid accounts from Billling No."
        Me.lbl_indicator.Visible = False
        '
        'frm_collection_payment_terms
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 655)
        Me.Controls.Add(Me.lbl_indicator)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.btn_select_from_soa)
        Me.Controls.Add(Me.lbl_total_amount_cheques)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.lbl_customer_id)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.txt_customer_name)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.GroupBox1)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_collection_cheque.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_collection_payment_terms"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Terms"
        CType(Me.txt_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_total.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cheque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_cheque_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transaction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transaction_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_bank.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_payee.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acc_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_acc_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_total As DevExpress.XtraEditors.TextEdit
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
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents grid_transaction As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_transaction_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_released As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transc_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_bank As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_apply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_select As Button
    Friend WithEvents lbl_customer_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl11 As LabelControl
    Friend WithEvents lbl_total_amount_cheques As LabelControl
    Friend WithEvents grid_returns As GridControl
    Friend WithEvents grid_returns_view As GridView
    Friend WithEvents col_srid As GridColumn
    Friend WithEvents GridColumn3 As GridColumn
    Friend WithEvents col_return_amount As GridColumn
    Friend WithEvents GridView4 As GridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbb_payee As ComboBoxEdit
    Friend WithEvents btn_select_from_soa As Button
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents LabelControl12 As LabelControl
    Friend WithEvents PanelControl2 As PanelControl
    Friend WithEvents PanelControl1 As PanelControl
    Friend WithEvents col_poref As GridColumn
    Friend WithEvents col_due_date As GridColumn
    Friend WithEvents col_payments_made As GridColumn
    Friend WithEvents col_balance As GridColumn
    Friend WithEvents col_invoice As GridColumn
    Friend WithEvents lbl_indicator As LabelControl
End Class
