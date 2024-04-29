Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports Inventory_Management.My.Resources
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_transaction_invoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_transaction_invoice))
        Me.grid_deliveries = New DevExpress.XtraGrid.GridControl()
        Me.grid_deliveries_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_account_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_shipping_method = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_invoice = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_sales_agent = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_released = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_deliveries, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_deliveries_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_deliveries
        '
        Me.grid_deliveries.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_deliveries.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_deliveries.Location = New System.Drawing.Point(3, 121)
        Me.grid_deliveries.LookAndFeel.SkinName = "WXI"
        Me.grid_deliveries.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_deliveries.MainView = Me.grid_deliveries_view
        Me.grid_deliveries.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_deliveries.Name = "grid_deliveries"
        Me.grid_deliveries.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_print})
        Me.grid_deliveries.Size = New System.Drawing.Size(1484, 770)
        Me.grid_deliveries.TabIndex = 32
        Me.grid_deliveries.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_deliveries_view})
        '
        'grid_deliveries_view
        '
        Me.grid_deliveries_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_deliveries_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_deliveries_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_deliveries_view.Appearance.Row.Options.UseFont = True
        Me.grid_deliveries_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_deliveries_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_deliveries_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_deliveries_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_deliveries_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_customer, Me.col_account_type, Me.GridColumn4, Me.col_shipping_method, Me.col_status, Me.col_payment_type, Me.col_payment_status, Me.GridColumn3, Me.GridColumn7, Me.GridColumn9, Me.col_invoice, Me.col_sales_agent, Me.col_date_released})
        Me.grid_deliveries_view.DetailHeight = 431
        Me.grid_deliveries_view.GridControl = Me.grid_deliveries
        Me.grid_deliveries_view.Name = "grid_deliveries_view"
        Me.grid_deliveries_view.OptionsBehavior.ReadOnly = True
        Me.grid_deliveries_view.OptionsEditForm.EditFormColumnCount = 1
        Me.grid_deliveries_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_deliveries_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "Order ID"
        Me.col_id.FieldName = "order_id"
        Me.col_id.MaxWidth = 117
        Me.col_id.MinWidth = 58
        Me.col_id.Name = "col_id"
        Me.col_id.OptionsColumn.AllowEdit = False
        Me.col_id.OptionsColumn.ReadOnly = True
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 85
        '
        'col_customer
        '
        Me.col_customer.AppearanceHeader.Options.UseTextOptions = True
        Me.col_customer.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "first_name"
        Me.col_customer.MinWidth = 58
        Me.col_customer.Name = "col_customer"
        Me.col_customer.OptionsColumn.AllowEdit = False
        Me.col_customer.OptionsColumn.ReadOnly = True
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 149
        '
        'col_account_type
        '
        Me.col_account_type.Caption = "Type"
        Me.col_account_type.FieldName = "account_type"
        Me.col_account_type.MinWidth = 23
        Me.col_account_type.Name = "col_account_type"
        Me.col_account_type.Visible = True
        Me.col_account_type.VisibleIndex = 2
        Me.col_account_type.Width = 86
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "Order Date"
        Me.GridColumn4.DisplayFormat.FormatString = "MMM dd, yyyy"
        Me.GridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn4.FieldName = "date_ordered"
        Me.GridColumn4.MinWidth = 23
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.AllowEdit = False
        Me.GridColumn4.OptionsColumn.ReadOnly = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 8
        Me.GridColumn4.Width = 90
        '
        'col_shipping_method
        '
        Me.col_shipping_method.AppearanceHeader.Options.UseTextOptions = True
        Me.col_shipping_method.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_shipping_method.Caption = "Ship Type"
        Me.col_shipping_method.FieldName = "shipping_method"
        Me.col_shipping_method.MinWidth = 23
        Me.col_shipping_method.Name = "col_shipping_method"
        Me.col_shipping_method.Visible = True
        Me.col_shipping_method.VisibleIndex = 3
        Me.col_shipping_method.Width = 65
        '
        'col_status
        '
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 12
        Me.col_status.Width = 104
        '
        'col_payment_type
        '
        Me.col_payment_type.AppearanceHeader.Options.UseTextOptions = True
        Me.col_payment_type.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payment_type.Caption = "Payment Type"
        Me.col_payment_type.FieldName = "payment_type"
        Me.col_payment_type.MinWidth = 23
        Me.col_payment_type.Name = "col_payment_type"
        Me.col_payment_type.Visible = True
        Me.col_payment_type.VisibleIndex = 4
        Me.col_payment_type.Width = 107
        '
        'col_payment_status
        '
        Me.col_payment_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_payment_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payment_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_payment_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_payment_status.Caption = "Payment Status"
        Me.col_payment_status.FieldName = "payment_status"
        Me.col_payment_status.MinWidth = 23
        Me.col_payment_status.Name = "col_payment_status"
        Me.col_payment_status.OptionsColumn.AllowEdit = False
        Me.col_payment_status.OptionsColumn.ReadOnly = True
        Me.col_payment_status.Visible = True
        Me.col_payment_status.VisibleIndex = 5
        Me.col_payment_status.Width = 117
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Representative"
        Me.GridColumn3.FieldName = "representative"
        Me.GridColumn3.MinWidth = 23
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.AllowEdit = False
        Me.GridColumn3.OptionsColumn.ReadOnly = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 6
        Me.GridColumn3.Width = 108
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn7.Caption = "Trucking"
        Me.GridColumn7.FieldName = "trucking"
        Me.GridColumn7.MinWidth = 23
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsColumn.AllowEdit = False
        Me.GridColumn7.OptionsColumn.ReadOnly = True
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 10
        Me.GridColumn7.Width = 78
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceHeader.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn9.Caption = "Ship To"
        Me.GridColumn9.FieldName = "ship_to"
        Me.GridColumn9.MinWidth = 23
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.AllowEdit = False
        Me.GridColumn9.OptionsColumn.ReadOnly = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 11
        Me.GridColumn9.Width = 170
        '
        'col_invoice
        '
        Me.col_invoice.AppearanceCell.Options.UseTextOptions = True
        Me.col_invoice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_invoice.AppearanceHeader.Options.UseTextOptions = True
        Me.col_invoice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_invoice.Caption = "Invoice"
        Me.col_invoice.ColumnEdit = Me.btn_print
        Me.col_invoice.MaxWidth = 82
        Me.col_invoice.MinWidth = 23
        Me.col_invoice.Name = "col_invoice"
        Me.col_invoice.OptionsColumn.ReadOnly = True
        Me.col_invoice.Visible = True
        Me.col_invoice.VisibleIndex = 13
        Me.col_invoice.Width = 82
        '
        'btn_print
        '
        Me.btn_print.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.employeedirectory_16x16
        Me.btn_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_sales_agent
        '
        Me.col_sales_agent.AppearanceHeader.Options.UseTextOptions = True
        Me.col_sales_agent.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_sales_agent.Caption = "Sales Agent"
        Me.col_sales_agent.FieldName = "sales_agent"
        Me.col_sales_agent.MinWidth = 23
        Me.col_sales_agent.Name = "col_sales_agent"
        Me.col_sales_agent.Visible = True
        Me.col_sales_agent.VisibleIndex = 7
        Me.col_sales_agent.Width = 98
        '
        'col_date_released
        '
        Me.col_date_released.Caption = "Released Date"
        Me.col_date_released.DisplayFormat.FormatString = "MMM dd, yyyy"
        Me.col_date_released.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_released.FieldName = "date_released"
        Me.col_date_released.MinWidth = 23
        Me.col_date_released.Name = "col_date_released"
        Me.col_date_released.Visible = True
        Me.col_date_released.VisibleIndex = 9
        Me.col_date_released.Width = 86
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(163, 38)
        Me.LabelControl1.TabIndex = 139
        Me.LabelControl1.Text = "Invoice List"
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view.ImageOptions.ImageToTextIndent = 5
        Me.btn_view.Location = New System.Drawing.Point(459, 65)
        Me.btn_view.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(93, 33)
        Me.btn_view.TabIndex = 144
        Me.btn_view.Text = "View"
        '
        'dt_end
        '
        Me.dt_end.EditValue = Nothing
        Me.dt_end.Location = New System.Drawing.Point(291, 65)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_end.Properties.Appearance.Options.UseFont = True
        Me.dt_end.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Size = New System.Drawing.Size(154, 34)
        Me.dt_end.TabIndex = 143
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(270, 74)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(14, 16)
        Me.LabelControl2.TabIndex = 142
        Me.LabelControl2.Text = "—"
        '
        'dt_start
        '
        Me.dt_start.EditValue = Nothing
        Me.dt_start.Location = New System.Drawing.Point(110, 65)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_start.Properties.Appearance.Options.UseFont = True
        Me.dt_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Size = New System.Drawing.Size(154, 34)
        Me.dt_start.TabIndex = 141
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(28, 74)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl3.TabIndex = 140
        Me.LabelControl3.Text = "Coverage:"
        '
        'frm_sales_transaction_invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1490, 890)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_deliveries)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_sales_transaction_invoice.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_sales_transaction_invoice"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Invoice List"
        CType(Me.grid_deliveries, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_deliveries_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_deliveries As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_deliveries_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_shipping_method As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_invoice As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_sales_agent As GridColumn
    Friend WithEvents col_date_released As GridColumn
    Friend WithEvents col_account_type As GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents dt_end As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
