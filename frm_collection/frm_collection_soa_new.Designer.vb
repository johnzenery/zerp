<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_soa_new
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_soa_new))
        Me.panel_content = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txt_total_view = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_customers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_orders = New DevExpress.XtraGrid.GridControl()
        Me.grid_orders_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_orderid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_due_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_of_order = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemHyperLinkEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit()
        Me.RepositoryItemDateEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemDateEdit()
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.panel_content.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_customers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_content
        '
        Me.panel_content.Controls.Add(Me.Panel2)
        Me.panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_content.Location = New System.Drawing.Point(0, 74)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Size = New System.Drawing.Size(790, 496)
        Me.panel_content.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txt_total_view)
        Me.Panel2.Controls.Add(Me.LabelControl9)
        Me.Panel2.Controls.Add(Me.LabelControl1)
        Me.Panel2.Controls.Add(Me.cbb_customers)
        Me.Panel2.Controls.Add(Me.btn_cancel)
        Me.Panel2.Controls.Add(Me.grid_orders)
        Me.Panel2.Controls.Add(Me.btn_generate)
        Me.Panel2.Location = New System.Drawing.Point(12, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(766, 472)
        Me.Panel2.TabIndex = 20
        '
        'txt_total_view
        '
        Me.txt_total_view.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_total_view.EditValue = ""
        Me.txt_total_view.Location = New System.Drawing.Point(155, 429)
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
        Me.txt_total_view.TabIndex = 19
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Appearance.Options.UseForeColor = True
        Me.LabelControl9.Location = New System.Drawing.Point(8, 432)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(131, 22)
        Me.LabelControl9.TabIndex = 18
        Me.LabelControl9.Text = "Total Amount:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(111, 17)
        Me.LabelControl1.TabIndex = 12
        Me.LabelControl1.Text = "Select Customer"
        '
        'cbb_customers
        '
        Me.cbb_customers.Location = New System.Drawing.Point(129, 12)
        Me.cbb_customers.Name = "cbb_customers"
        Me.cbb_customers.Properties.Appearance.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.cbb_customers.Properties.Appearance.Options.UseFont = True
        Me.cbb_customers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customers.Size = New System.Drawing.Size(194, 24)
        Me.cbb_customers.TabIndex = 11
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.cancel
        Me.btn_cancel.Location = New System.Drawing.Point(493, 424)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(129, 39)
        Me.btn_cancel.TabIndex = 10
        Me.btn_cancel.Text = "Cancel"
        '
        'grid_orders
        '
        Me.grid_orders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_orders.Location = New System.Drawing.Point(8, 47)
        Me.grid_orders.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_orders.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_orders.MainView = Me.grid_orders_view
        Me.grid_orders.Name = "grid_orders"
        Me.grid_orders.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemHyperLinkEdit1, Me.RepositoryItemDateEdit1})
        Me.grid_orders.Size = New System.Drawing.Size(749, 368)
        Me.grid_orders.TabIndex = 8
        Me.grid_orders.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_orders_view})
        '
        'grid_orders_view
        '
        Me.grid_orders_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_orders_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_orders_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_orders_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_orders_view.Appearance.Row.Options.UseFont = True
        Me.grid_orders_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_orders_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_orders_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_orders_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_orderid, Me.col_due_date, Me.col_total, Me.col_date_of_order})
        Me.grid_orders_view.GridControl = Me.grid_orders
        Me.grid_orders_view.Name = "grid_orders_view"
        Me.grid_orders_view.OptionsBehavior.Editable = False
        Me.grid_orders_view.OptionsBehavior.ReadOnly = True
        Me.grid_orders_view.OptionsSelection.MultiSelect = True
        Me.grid_orders_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'col_orderid
        '
        Me.col_orderid.AppearanceCell.Options.UseTextOptions = True
        Me.col_orderid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_orderid.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_orderid.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_orderid.AppearanceHeader.Options.UseFont = True
        Me.col_orderid.AppearanceHeader.Options.UseForeColor = True
        Me.col_orderid.AppearanceHeader.Options.UseTextOptions = True
        Me.col_orderid.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_orderid.Caption = "Order ID"
        Me.col_orderid.FieldName = "order_id"
        Me.col_orderid.MaxWidth = 100
        Me.col_orderid.MinWidth = 50
        Me.col_orderid.Name = "col_orderid"
        Me.col_orderid.Visible = True
        Me.col_orderid.VisibleIndex = 1
        Me.col_orderid.Width = 72
        '
        'col_due_date
        '
        Me.col_due_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_due_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_due_date.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_due_date.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_due_date.AppearanceHeader.Options.UseFont = True
        Me.col_due_date.AppearanceHeader.Options.UseForeColor = True
        Me.col_due_date.AppearanceHeader.Options.UseTextOptions = True
        Me.col_due_date.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_due_date.Caption = "Due Date"
        Me.col_due_date.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_due_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_due_date.FieldName = "due_date"
        Me.col_due_date.MaxWidth = 300
        Me.col_due_date.MinWidth = 50
        Me.col_due_date.Name = "col_due_date"
        Me.col_due_date.Visible = True
        Me.col_due_date.VisibleIndex = 3
        Me.col_due_date.Width = 124
        '
        'col_total
        '
        Me.col_total.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold)
        Me.col_total.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_total.AppearanceHeader.Options.UseFont = True
        Me.col_total.AppearanceHeader.Options.UseForeColor = True
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total.Caption = "Total Amount"
        Me.col_total.DisplayFormat.FormatString = "c2"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "amount_due"
        Me.col_total.Name = "col_total"
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 4
        Me.col_total.Width = 109
        '
        'col_date_of_order
        '
        Me.col_date_of_order.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_of_order.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_of_order.Caption = "Date Released"
        Me.col_date_of_order.DisplayFormat.FormatString = "MMMM dd, yyyy"
        Me.col_date_of_order.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_of_order.FieldName = "date_released"
        Me.col_date_of_order.Name = "col_date_of_order"
        Me.col_date_of_order.Visible = True
        Me.col_date_of_order.VisibleIndex = 2
        Me.col_date_of_order.Width = 113
        '
        'RepositoryItemHyperLinkEdit1
        '
        Me.RepositoryItemHyperLinkEdit1.AutoHeight = False
        Me.RepositoryItemHyperLinkEdit1.Name = "RepositoryItemHyperLinkEdit1"
        '
        'RepositoryItemDateEdit1
        '
        Me.RepositoryItemDateEdit1.AutoHeight = False
        Me.RepositoryItemDateEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemDateEdit1.Name = "RepositoryItemDateEdit1"
        '
        'btn_generate
        '
        Me.btn_generate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_generate.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_generate.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_addcircled
        Me.btn_generate.Location = New System.Drawing.Point(628, 424)
        Me.btn_generate.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_generate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(129, 39)
        Me.btn_generate.TabIndex = 9
        Me.btn_generate.Text = "Generate"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(790, 74)
        Me.Panel1.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(336, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Statement of Account"
        '
        'frm_collection_soa_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(790, 570)
        Me.Controls.Add(Me.panel_content)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_soa_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generate SOA"
        Me.panel_content.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.txt_total_view.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_customers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_orders_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemHyperLinkEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemDateEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_content As Panel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_orders As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_orders_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_orderid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_due_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemDateEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemDateEdit
    Friend WithEvents col_date_of_order As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemHyperLinkEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemHyperLinkEdit
    Friend WithEvents btn_generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_customers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_total_view As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
End Class
