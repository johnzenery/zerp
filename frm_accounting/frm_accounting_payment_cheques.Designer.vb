<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_accounting_payment_cheques
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
        Me.grid_payments = New DevExpress.XtraGrid.GridControl()
        Me.grid_payments_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cheque_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_status = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.col_date_cleared = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_clearing_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payor_acc_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_print = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_voucher_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_payments
        '
        Me.grid_payments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payments.Location = New System.Drawing.Point(-1, 112)
        Me.grid_payments.MainView = Me.grid_payments_view
        Me.grid_payments.Name = "grid_payments"
        Me.grid_payments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_print, Me.cbb_status})
        Me.grid_payments.Size = New System.Drawing.Size(1490, 582)
        Me.grid_payments.TabIndex = 14
        Me.grid_payments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_payments_view})
        '
        'grid_payments_view
        '
        Me.grid_payments_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_payments_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_payments_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_payments_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_payments_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_payments_view.Appearance.Row.Options.UseFont = True
        Me.grid_payments_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_cheque_no, Me.col_cheque_date, Me.col_status, Me.col_date_cleared, Me.col_clearing_date, Me.col_bank, Me.col_payor_acc_no, Me.col_payee, Me.col_acc_no, Me.col_acc_name, Me.col_supplier, Me.col_amount, Me.col_print, Me.col_voucher_id})
        Me.grid_payments_view.GridControl = Me.grid_payments
        Me.grid_payments_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_payments_view.Name = "grid_payments_view"
        Me.grid_payments_view.OptionsPrint.PrintHorzLines = False
        Me.grid_payments_view.OptionsPrint.PrintVertLines = False
        Me.grid_payments_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_payments_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_payments_view.OptionsView.ColumnAutoWidth = False
        Me.grid_payments_view.OptionsView.RowAutoHeight = True
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.Name = "col_id"
        Me.col_id.OptionsColumn.ReadOnly = True
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 53
        '
        'col_cheque_no
        '
        Me.col_cheque_no.Caption = "Cheque No"
        Me.col_cheque_no.FieldName = "cheque_no"
        Me.col_cheque_no.Name = "col_cheque_no"
        Me.col_cheque_no.OptionsColumn.ReadOnly = True
        Me.col_cheque_no.Visible = True
        Me.col_cheque_no.VisibleIndex = 1
        '
        'col_cheque_date
        '
        Me.col_cheque_date.Caption = "Cheque Date"
        Me.col_cheque_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_cheque_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_cheque_date.FieldName = "cheque_date"
        Me.col_cheque_date.Name = "col_cheque_date"
        Me.col_cheque_date.OptionsColumn.ReadOnly = True
        Me.col_cheque_date.Visible = True
        Me.col_cheque_date.VisibleIndex = 2
        Me.col_cheque_date.Width = 105
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.ColumnEdit = Me.cbb_status
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 4
        Me.col_status.Width = 124
        '
        'cbb_status
        '
        Me.cbb_status.AutoHeight = False
        Me.cbb_status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_status.Items.AddRange(New Object() {"OUTSTANDING", "CLEAR"})
        Me.cbb_status.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'col_date_cleared
        '
        Me.col_date_cleared.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_cleared.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_cleared.Caption = "Date Cleared"
        Me.col_date_cleared.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_date_cleared.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_cleared.FieldName = "date_cleared"
        Me.col_date_cleared.MaxWidth = 100
        Me.col_date_cleared.Name = "col_date_cleared"
        Me.col_date_cleared.Visible = True
        Me.col_date_cleared.VisibleIndex = 5
        Me.col_date_cleared.Width = 100
        '
        'col_clearing_date
        '
        Me.col_clearing_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_clearing_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_clearing_date.Caption = "Clearing Date"
        Me.col_clearing_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_clearing_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_clearing_date.FieldName = "clearing_date"
        Me.col_clearing_date.MaxWidth = 100
        Me.col_clearing_date.Name = "col_clearing_date"
        Me.col_clearing_date.Visible = True
        Me.col_clearing_date.VisibleIndex = 6
        Me.col_clearing_date.Width = 100
        '
        'col_bank
        '
        Me.col_bank.Caption = "Bank"
        Me.col_bank.FieldName = "bank"
        Me.col_bank.Name = "col_bank"
        Me.col_bank.OptionsColumn.ReadOnly = True
        Me.col_bank.Visible = True
        Me.col_bank.VisibleIndex = 7
        Me.col_bank.Width = 186
        '
        'col_payor_acc_no
        '
        Me.col_payor_acc_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_payor_acc_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_payor_acc_no.Caption = "Payor Acc. No."
        Me.col_payor_acc_no.FieldName = "payor_acc_no"
        Me.col_payor_acc_no.MinWidth = 120
        Me.col_payor_acc_no.Name = "col_payor_acc_no"
        Me.col_payor_acc_no.Visible = True
        Me.col_payor_acc_no.VisibleIndex = 8
        Me.col_payor_acc_no.Width = 120
        '
        'col_payee
        '
        Me.col_payee.Caption = "Payee"
        Me.col_payee.FieldName = "payee"
        Me.col_payee.Name = "col_payee"
        Me.col_payee.OptionsColumn.ReadOnly = True
        Me.col_payee.Visible = True
        Me.col_payee.VisibleIndex = 9
        Me.col_payee.Width = 134
        '
        'col_acc_no
        '
        Me.col_acc_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_acc_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_acc_no.Caption = "Account No."
        Me.col_acc_no.FieldName = "acc_no"
        Me.col_acc_no.Name = "col_acc_no"
        Me.col_acc_no.OptionsColumn.ReadOnly = True
        Me.col_acc_no.Visible = True
        Me.col_acc_no.VisibleIndex = 10
        Me.col_acc_no.Width = 128
        '
        'col_acc_name
        '
        Me.col_acc_name.Caption = "Account Name"
        Me.col_acc_name.FieldName = "acc_name"
        Me.col_acc_name.Name = "col_acc_name"
        Me.col_acc_name.OptionsColumn.ReadOnly = True
        Me.col_acc_name.Visible = True
        Me.col_acc_name.VisibleIndex = 11
        Me.col_acc_name.Width = 190
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.OptionsColumn.ReadOnly = True
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 12
        Me.col_supplier.Width = 226
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "n2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.OptionsColumn.ReadOnly = True
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 3
        Me.col_amount.Width = 102
        '
        'col_print
        '
        Me.col_print.Caption = "Print"
        Me.col_print.ColumnEdit = Me.btn_print
        Me.col_print.Name = "col_print"
        Me.col_print.OptionsColumn.FixedWidth = True
        Me.col_print.Visible = True
        Me.col_print.VisibleIndex = 14
        '
        'btn_print
        '
        Me.btn_print.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_voucher_id
        '
        Me.col_voucher_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_voucher_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_voucher_id.Caption = "Voucher ID"
        Me.col_voucher_id.FieldName = "voucher_id"
        Me.col_voucher_id.Name = "col_voucher_id"
        Me.col_voucher_id.Visible = True
        Me.col_voucher_id.VisibleIndex = 13
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(223, 31)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Payment Cheques"
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.Appearance.Options.UseFont = True
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 5
        Me.btn_export.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.exporttoxls
        Me.btn_export.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export.Location = New System.Drawing.Point(1315, 56)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(160, 46)
        Me.btn_export.TabIndex = 26
        Me.btn_export.Text = "Export"
        '
        'frm_accounting_payment_cheques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1487, 690)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_payments)
        Me.Name = "frm_accounting_payment_cheques"
        Me.Text = "Payment Cheques"
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_payments As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payments_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_print As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_cheque_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cheque_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_status As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents col_voucher_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_date_cleared As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payor_acc_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_clearing_date As DevExpress.XtraGrid.Columns.GridColumn
End Class
