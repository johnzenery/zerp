<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_collection_payment_journal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_payment_journal))
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_payment_ledger = New DevExpress.XtraGrid.GridControl()
        Me.grid_payment_ledger_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_orderid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn10 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn11 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn13 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn12 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_proofs = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reversal = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_payment_ledger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payment_ledger_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_proofs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "GridColumn1"
        Me.GridColumn1.FieldName = "payment_type"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 4
        Me.GridColumn1.Width = 145
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(203, 31)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Payment Journal"
        '
        'grid_payment_ledger
        '
        Me.grid_payment_ledger.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payment_ledger.Location = New System.Drawing.Point(2, 64)
        Me.grid_payment_ledger.MainView = Me.grid_payment_ledger_view
        Me.grid_payment_ledger.Name = "grid_payment_ledger"
        Me.grid_payment_ledger.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_proofs})
        Me.grid_payment_ledger.Size = New System.Drawing.Size(1457, 530)
        Me.grid_payment_ledger.TabIndex = 21
        Me.grid_payment_ledger.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_payment_ledger_view})
        '
        'grid_payment_ledger_view
        '
        Me.grid_payment_ledger_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_payment_ledger_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_payment_ledger_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_payment_ledger_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_payment_ledger_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_payment_ledger_view.Appearance.Row.Options.UseFont = True
        Me.grid_payment_ledger_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_payment_ledger_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_payment_ledger_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_payment_ledger_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_payment_ledger_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_orderid, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn10, Me.GridColumn11, Me.GridColumn13, Me.GridColumn3, Me.GridColumn9, Me.GridColumn12})
        Me.grid_payment_ledger_view.GridControl = Me.grid_payment_ledger
        Me.grid_payment_ledger_view.Name = "grid_payment_ledger_view"
        Me.grid_payment_ledger_view.OptionsBehavior.ReadOnly = True
        Me.grid_payment_ledger_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_payment_ledger_view.OptionsView.ColumnAutoWidth = False
        Me.grid_payment_ledger_view.OptionsView.ShowGroupPanel = False
        Me.grid_payment_ledger_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_orderid
        '
        Me.col_orderid.AppearanceCell.Options.UseTextOptions = True
        Me.col_orderid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_orderid.Caption = "Order ID"
        Me.col_orderid.FieldName = "order_id"
        Me.col_orderid.MaxWidth = 100
        Me.col_orderid.MinWidth = 50
        Me.col_orderid.Name = "col_orderid"
        Me.col_orderid.Visible = True
        Me.col_orderid.VisibleIndex = 2
        Me.col_orderid.Width = 68
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Type"
        Me.GridColumn4.FieldName = "type"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 1
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "New Balance"
        Me.GridColumn5.DisplayFormat.FormatString = "n2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "new_balance"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 7
        Me.GridColumn5.Width = 71
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Customer"
        Me.GridColumn6.FieldName = "customer"
        Me.GridColumn6.MinWidth = 50
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 174
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Date"
        Me.GridColumn7.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn7.FieldName = "payment_date"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 3
        Me.GridColumn7.Width = 119
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Current Balance"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "current_balance"
        Me.GridColumn8.MinWidth = 120
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 5
        Me.GridColumn8.Width = 120
        '
        'GridColumn10
        '
        Me.GridColumn10.Caption = "Total Payment"
        Me.GridColumn10.DisplayFormat.FormatString = "n2"
        Me.GridColumn10.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn10.FieldName = "total_payment"
        Me.GridColumn10.MinWidth = 120
        Me.GridColumn10.Name = "GridColumn10"
        Me.GridColumn10.Visible = True
        Me.GridColumn10.VisibleIndex = 6
        Me.GridColumn10.Width = 126
        '
        'GridColumn11
        '
        Me.GridColumn11.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn11.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn11.Caption = "ID"
        Me.GridColumn11.FieldName = "transaction_id"
        Me.GridColumn11.Name = "GridColumn11"
        Me.GridColumn11.Visible = True
        Me.GridColumn11.VisibleIndex = 0
        Me.GridColumn11.Width = 48
        '
        'GridColumn13
        '
        Me.GridColumn13.Caption = "Generated by"
        Me.GridColumn13.FieldName = "received_by"
        Me.GridColumn13.MaxWidth = 130
        Me.GridColumn13.MinWidth = 130
        Me.GridColumn13.Name = "GridColumn13"
        Me.GridColumn13.Visible = True
        Me.GridColumn13.VisibleIndex = 8
        Me.GridColumn13.Width = 130
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "E-Pay Ref."
        Me.GridColumn3.FieldName = "epayment_ref"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 9
        Me.GridColumn3.Width = 86
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Gateway"
        Me.GridColumn9.FieldName = "gateway"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 10
        '
        'GridColumn12
        '
        Me.GridColumn12.Caption = "Proofs"
        Me.GridColumn12.ColumnEdit = Me.btn_proofs
        Me.GridColumn12.MaxWidth = 60
        Me.GridColumn12.Name = "GridColumn12"
        Me.GridColumn12.Visible = True
        Me.GridColumn12.VisibleIndex = 11
        Me.GridColumn12.Width = 60
        '
        'btn_proofs
        '
        Me.btn_proofs.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.article_16x16
        Me.btn_proofs.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_proofs.Name = "btn_proofs"
        Me.btn_proofs.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
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
        Me.btn_refresh.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_refresh.Location = New System.Drawing.Point(1288, 12)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 28
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_reversal
        '
        Me.btn_reversal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reversal.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reversal.Appearance.Options.UseFont = True
        Me.btn_reversal.Appearance.Options.UseTextOptions = True
        Me.btn_reversal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_reversal.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_reversal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_reversal.ImageOptions.ImageToTextIndent = 5
        Me.btn_reversal.ImageOptions.SvgImage = CType(resources.GetObject("btn_reversal.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.btn_reversal.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_reversal.Location = New System.Drawing.Point(1122, 12)
        Me.btn_reversal.Name = "btn_reversal"
        Me.btn_reversal.Size = New System.Drawing.Size(160, 46)
        Me.btn_reversal.TabIndex = 29
        Me.btn_reversal.Text = "Payment Reversal"
        '
        'frm_collection_payment_journal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1460, 595)
        Me.Controls.Add(Me.btn_reversal)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.grid_payment_ledger)
        Me.Controls.Add(Me.LabelControl1)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_collection_payment_journal.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_collection_payment_journal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payment Journal"
        CType(Me.grid_payment_ledger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payment_ledger_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_proofs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_payment_ledger As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payment_ledger_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_orderid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn10 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn11 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn13 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_reversal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn12 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_proofs As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
