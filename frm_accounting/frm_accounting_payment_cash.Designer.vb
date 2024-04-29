<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_payment_cash
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_payments = New DevExpress.XtraGrid.GridControl()
        Me.grid_payments_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payee = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_created_at = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_status = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.col_voucher_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_payments
        '
        Me.grid_payments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payments.Location = New System.Drawing.Point(-1, 70)
        Me.grid_payments.MainView = Me.grid_payments_view
        Me.grid_payments.Name = "grid_payments"
        Me.grid_payments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemButtonEdit1, Me.cbb_status})
        Me.grid_payments.Size = New System.Drawing.Size(966, 507)
        Me.grid_payments.TabIndex = 15
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
        Me.grid_payments_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_payee, Me.col_amount, Me.col_created_at, Me.col_voucher_id})
        Me.grid_payments_view.GridControl = Me.grid_payments
        Me.grid_payments_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_payments_view.Name = "grid_payments_view"
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
        'col_payee
        '
        Me.col_payee.Caption = "Payee"
        Me.col_payee.FieldName = "payee"
        Me.col_payee.Name = "col_payee"
        Me.col_payee.OptionsColumn.ReadOnly = True
        Me.col_payee.Visible = True
        Me.col_payee.VisibleIndex = 1
        Me.col_payee.Width = 338
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_amount.FieldName = "amount"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.OptionsColumn.ReadOnly = True
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 2
        Me.col_amount.Width = 113
        '
        'col_created_at
        '
        Me.col_created_at.AppearanceCell.Options.UseTextOptions = True
        Me.col_created_at.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_created_at.Caption = "Created At"
        Me.col_created_at.ColumnEdit = Me.cbb_status
        Me.col_created_at.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_created_at.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_created_at.FieldName = "payment_date"
        Me.col_created_at.Name = "col_created_at"
        Me.col_created_at.Visible = True
        Me.col_created_at.VisibleIndex = 3
        Me.col_created_at.Width = 124
        '
        'cbb_status
        '
        Me.cbb_status.AutoHeight = False
        Me.cbb_status.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_status.Items.AddRange(New Object() {"OUTSTANDING", "CLEAR", "VOID"})
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        '
        'col_voucher_id
        '
        Me.col_voucher_id.Caption = "Voucher ID"
        Me.col_voucher_id.FieldName = "voucher_id"
        Me.col_voucher_id.Name = "col_voucher_id"
        Me.col_voucher_id.Visible = True
        Me.col_voucher_id.VisibleIndex = 4
        '
        'RepositoryItemButtonEdit1
        '
        Me.RepositoryItemButtonEdit1.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.createmodeldifferences_16x16
        Me.RepositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.RepositoryItemButtonEdit1.Name = "RepositoryItemButtonEdit1"
        Me.RepositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(178, 31)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Payment Cash"
        '
        'frm_accounting_payment_cash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 574)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_payments)
        Me.Name = "frm_accounting_payment_cash"
        Me.Text = "Payment Cash"
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_payments As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payments_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payee As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_created_at As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_status As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents RepositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_voucher_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
