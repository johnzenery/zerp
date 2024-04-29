<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_payment_vouchers
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
        Dim EditorButtonImageOptions10 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject37 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject38 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject39 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject40 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions11 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject41 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject42 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject43 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject44 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions12 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject45 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject46 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject47 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject48 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_payments = New DevExpress.XtraGrid.GridControl()
        Me.grid_payments_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_created = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_print = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_voucher_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_void = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_void = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_release = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_release = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_received_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_released_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_void, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_release, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_payments
        '
        Me.grid_payments.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_payments.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_payments.Location = New System.Drawing.Point(4, 119)
        Me.grid_payments.MainView = Me.grid_payments_view
        Me.grid_payments.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_payments.Name = "grid_payments"
        Me.grid_payments.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_print, Me.btn_void, Me.btn_release})
        Me.grid_payments.Size = New System.Drawing.Size(1616, 680)
        Me.grid_payments.TabIndex = 13
        Me.grid_payments.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_payments_view})
        '
        'grid_payments_view
        '
        Me.grid_payments_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_payments_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_payments_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_payments_view.Appearance.Row.Options.UseFont = True
        Me.grid_payments_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_payment_type, Me.col_supplier, Me.col_date_created, Me.col_print, Me.col_voucher_amount, Me.col_void, Me.col_status, Me.col_release, Me.col_received_by, Me.col_date_received, Me.col_released_by})
        Me.grid_payments_view.DetailHeight = 431
        Me.grid_payments_view.GridControl = Me.grid_payments
        Me.grid_payments_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_payments_view.Name = "grid_payments_view"
        Me.grid_payments_view.OptionsBehavior.ReadOnly = True
        Me.grid_payments_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_payments_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_payments_view.OptionsView.ColumnAutoWidth = False
        Me.grid_payments_view.OptionsView.RowAutoHeight = True
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "Payment No."
        Me.col_id.FieldName = "payment_id"
        Me.col_id.MinWidth = 23
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 132
        '
        'col_payment_type
        '
        Me.col_payment_type.Caption = "Payment Type"
        Me.col_payment_type.FieldName = "payment_type"
        Me.col_payment_type.MinWidth = 23
        Me.col_payment_type.Name = "col_payment_type"
        Me.col_payment_type.Visible = True
        Me.col_payment_type.VisibleIndex = 1
        Me.col_payment_type.Width = 118
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 23
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 2
        Me.col_supplier.Width = 377
        '
        'col_date_created
        '
        Me.col_date_created.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_created.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_created.Caption = "Date"
        Me.col_date_created.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_created.FieldName = "creation_date"
        Me.col_date_created.MinWidth = 23
        Me.col_date_created.Name = "col_date_created"
        Me.col_date_created.Visible = True
        Me.col_date_created.VisibleIndex = 3
        Me.col_date_created.Width = 149
        '
        'col_print
        '
        Me.col_print.Caption = "Print"
        Me.col_print.ColumnEdit = Me.btn_print
        Me.col_print.MinWidth = 23
        Me.col_print.Name = "col_print"
        Me.col_print.OptionsColumn.FixedWidth = True
        Me.col_print.Visible = True
        Me.col_print.VisibleIndex = 6
        Me.col_print.Width = 87
        '
        'btn_print
        '
        Me.btn_print.AutoHeight = False
        EditorButtonImageOptions10.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions10, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject37, SerializableAppearanceObject38, SerializableAppearanceObject39, SerializableAppearanceObject40, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_voucher_amount
        '
        Me.col_voucher_amount.Caption = "Amount"
        Me.col_voucher_amount.DisplayFormat.FormatString = "n2"
        Me.col_voucher_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_voucher_amount.FieldName = "voucher_amount"
        Me.col_voucher_amount.MaxWidth = 140
        Me.col_voucher_amount.MinWidth = 140
        Me.col_voucher_amount.Name = "col_voucher_amount"
        Me.col_voucher_amount.Visible = True
        Me.col_voucher_amount.VisibleIndex = 4
        Me.col_voucher_amount.Width = 140
        '
        'col_void
        '
        Me.col_void.Caption = "Void"
        Me.col_void.ColumnEdit = Me.btn_void
        Me.col_void.MinWidth = 23
        Me.col_void.Name = "col_void"
        Me.col_void.Visible = True
        Me.col_void.VisibleIndex = 8
        Me.col_void.Width = 87
        '
        'btn_void
        '
        Me.btn_void.AutoHeight = False
        EditorButtonImageOptions11.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_forbid
        EditorButtonImageOptions11.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_void.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions11, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject41, SerializableAppearanceObject42, SerializableAppearanceObject43, SerializableAppearanceObject44, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_void.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_void.Name = "btn_void"
        Me.btn_void.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "voucher_status"
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 5
        Me.col_status.Width = 110
        '
        'col_release
        '
        Me.col_release.Caption = "Release"
        Me.col_release.ColumnEdit = Me.btn_release
        Me.col_release.MinWidth = 23
        Me.col_release.Name = "col_release"
        Me.col_release.Visible = True
        Me.col_release.VisibleIndex = 7
        Me.col_release.Width = 85
        '
        'btn_release
        '
        Me.btn_release.AutoHeight = False
        EditorButtonImageOptions12.Image = Global.Inventory_Management.My.Resources.Resources.deliver
        Me.btn_release.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions12, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject45, SerializableAppearanceObject46, SerializableAppearanceObject47, SerializableAppearanceObject48, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_release.Name = "btn_release"
        Me.btn_release.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_received_by
        '
        Me.col_received_by.Caption = "Received by"
        Me.col_received_by.FieldName = "received_by"
        Me.col_received_by.MinWidth = 23
        Me.col_received_by.Name = "col_received_by"
        Me.col_received_by.Visible = True
        Me.col_received_by.VisibleIndex = 9
        Me.col_received_by.Width = 120
        '
        'col_date_received
        '
        Me.col_date_received.Caption = "Date Received"
        Me.col_date_received.FieldName = "date_released"
        Me.col_date_received.MinWidth = 23
        Me.col_date_received.Name = "col_date_received"
        Me.col_date_received.Visible = True
        Me.col_date_received.VisibleIndex = 10
        Me.col_date_received.Width = 125
        '
        'col_released_by
        '
        Me.col_released_by.Caption = "Released by"
        Me.col_released_by.FieldName = "released_by"
        Me.col_released_by.MinWidth = 23
        Me.col_released_by.Name = "col_released_by"
        Me.col_released_by.Visible = True
        Me.col_released_by.VisibleIndex = 11
        Me.col_released_by.Width = 87
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(277, 38)
        Me.LabelControl1.TabIndex = 20
        Me.LabelControl1.Text = "Payment Vouchers"
        '
        'dt_start
        '
        Me.dt_start.EditValue = Nothing
        Me.dt_start.Location = New System.Drawing.Point(110, 71)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_start.Properties.Appearance.Options.UseFont = True
        Me.dt_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Properties.MaskSettings.Set("mask", "d")
        Me.dt_start.Size = New System.Drawing.Size(154, 34)
        Me.dt_start.TabIndex = 39
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(28, 80)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "Coverage:"
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view.ImageOptions.ImageToTextIndent = 5
        Me.btn_view.Location = New System.Drawing.Point(452, 72)
        Me.btn_view.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(93, 33)
        Me.btn_view.TabIndex = 77
        Me.btn_view.Text = "View"
        '
        'dt_end
        '
        Me.dt_end.EditValue = Nothing
        Me.dt_end.Location = New System.Drawing.Point(291, 71)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_end.Properties.Appearance.Options.UseFont = True
        Me.dt_end.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Size = New System.Drawing.Size(154, 34)
        Me.dt_end.TabIndex = 79
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(270, 80)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(14, 16)
        Me.LabelControl3.TabIndex = 78
        Me.LabelControl3.Text = "—"
        '
        'frm_accounting_payment_vouchers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1625, 807)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_payments)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_accounting_payment_vouchers"
        Me.Text = "Payment Vouchers"
        CType(Me.grid_payments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_payments_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_void, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_release, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_payments As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_payments_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_print As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_payment_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_voucher_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_void As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_void As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_release As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_release As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_received_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_released_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dt_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dt_end As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
