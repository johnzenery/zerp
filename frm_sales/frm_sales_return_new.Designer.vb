<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_return_new
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_return_new))
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.link_sales_return = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_action = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        Me.grid_return = New System.Windows.Forms.DataGridView()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_totalcost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_last_order_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_last_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_customer_id = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_customer = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_srid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_account_type = New DevExpress.XtraEditors.LabelControl()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_store_id = New DevExpress.XtraEditors.LabelControl()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.grid_return, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_srid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Controls.Add(Me.lbl_title)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1077, 78)
        Me.GunaPanel2.TabIndex = 13
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel3.Controls.Add(Me.GunaPanel4)
        Me.GunaPanel3.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(1037, 27)
        Me.GunaPanel3.TabIndex = 5
        '
        'GunaPanel4
        '
        Me.GunaPanel4.Controls.Add(Me.LabelControl2)
        Me.GunaPanel4.Controls.Add(Me.link_sales_return)
        Me.GunaPanel4.Controls.Add(Me.lbl_action)
        Me.GunaPanel4.Controls.Add(Me.LabelControl6)
        Me.GunaPanel4.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel4.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(153, 7)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = ">"
        '
        'link_sales_return
        '
        Me.link_sales_return.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_sales_return.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_sales_return.Appearance.Options.UseFont = True
        Me.link_sales_return.Appearance.Options.UseLinkColor = True
        Me.link_sales_return.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_sales_return.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_sales_return.AppearanceHovered.Options.UseForeColor = True
        Me.link_sales_return.AppearanceHovered.Options.UseLinkColor = True
        Me.link_sales_return.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_sales_return.AppearancePressed.Options.UseLinkColor = True
        Me.link_sales_return.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_sales_return.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_sales_return.Location = New System.Drawing.Point(70, 5)
        Me.link_sales_return.Name = "link_sales_return"
        Me.link_sales_return.ShowLineShadow = False
        Me.link_sales_return.Size = New System.Drawing.Size(77, 18)
        Me.link_sales_return.TabIndex = 8
        Me.link_sales_return.Text = "Sales Return"
        '
        'lbl_action
        '
        Me.lbl_action.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_action.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.lbl_action.Appearance.Options.UseFont = True
        Me.lbl_action.Appearance.Options.UseLinkColor = True
        Me.lbl_action.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_action.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_action.AppearanceHovered.Options.UseForeColor = True
        Me.lbl_action.AppearanceHovered.Options.UseLinkColor = True
        Me.lbl_action.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lbl_action.AppearancePressed.Options.UseLinkColor = True
        Me.lbl_action.Enabled = False
        Me.lbl_action.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.lbl_action.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.lbl_action.Location = New System.Drawing.Point(168, 5)
        Me.lbl_action.Name = "lbl_action"
        Me.lbl_action.ShowLineShadow = False
        Me.lbl_action.Size = New System.Drawing.Size(29, 18)
        Me.lbl_action.TabIndex = 7
        Me.lbl_action.Text = "New"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl6.TabIndex = 6
        Me.LabelControl6.Text = ">"
        '
        'HyperlinkLabelControl2
        '
        Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl2.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl2.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceDisabled.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl2.Location = New System.Drawing.Point(13, 5)
        Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
        Me.HyperlinkLabelControl2.ShowLineShadow = False
        Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(37, 18)
        Me.HyperlinkLabelControl2.TabIndex = 5
        Me.HyperlinkLabelControl2.Text = "Home"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(14, 10)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(233, 31)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "New Sales Return"
        '
        'grid_return
        '
        Me.grid_return.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_return.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_return.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_return.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_return.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_return.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_return.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_return.ColumnHeadersHeight = 28
        Me.grid_return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_return.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_qty, Me.col_model, Me.col_description, Me.col_cost, Me.col_totalcost, Me.col_pid, Me.col_last_order_date, Me.col_last_qty})
        Me.grid_return.EnableHeadersVisualStyles = False
        Me.grid_return.Location = New System.Drawing.Point(24, 181)
        Me.grid_return.Name = "grid_return"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_return.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grid_return.Size = New System.Drawing.Size(1029, 398)
        Me.grid_return.TabIndex = 60
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Width = 80
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle3
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Model"
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 150
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.FillWeight = 137.4594!
        Me.col_description.HeaderText = "Description"
        Me.col_description.Name = "col_description"
        '
        'col_cost
        '
        Me.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_cost.FillWeight = 102.6804!
        Me.col_cost.HeaderText = "Last Price"
        Me.col_cost.Name = "col_cost"
        Me.col_cost.ReadOnly = True
        Me.col_cost.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_totalcost
        '
        Me.col_totalcost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "n2"
        Me.col_totalcost.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_totalcost.HeaderText = "Total"
        Me.col_totalcost.Name = "col_totalcost"
        Me.col_totalcost.ReadOnly = True
        Me.col_totalcost.Width = 120
        '
        'col_pid
        '
        Me.col_pid.HeaderText = "PID"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = False
        Me.col_pid.Width = 50
        '
        'col_last_order_date
        '
        Me.col_last_order_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.Format = "MM/dd/yyyy"
        Me.col_last_order_date.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_last_order_date.HeaderText = "Last Order"
        Me.col_last_order_date.Name = "col_last_order_date"
        Me.col_last_order_date.ReadOnly = True
        Me.col_last_order_date.Width = 120
        '
        'col_last_qty
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_last_qty.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_last_qty.HeaderText = "Last QTY"
        Me.col_last_qty.Name = "col_last_qty"
        Me.col_last_qty.ReadOnly = True
        Me.col_last_qty.Width = 77
        '
        'txt_customer_id
        '
        Me.txt_customer_id.Enabled = False
        Me.txt_customer_id.Location = New System.Drawing.Point(411, 127)
        Me.txt_customer_id.Name = "txt_customer_id"
        Me.txt_customer_id.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_customer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_customer_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_customer_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_customer_id.Size = New System.Drawing.Size(43, 22)
        Me.txt_customer_id.TabIndex = 119
        '
        'cbb_customer
        '
        Me.cbb_customer.Location = New System.Drawing.Point(128, 127)
        Me.cbb_customer.Name = "cbb_customer"
        Me.cbb_customer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_customer.Properties.Appearance.Options.UseFont = True
        Me.cbb_customer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_customer.Size = New System.Drawing.Size(277, 22)
        Me.cbb_customer.TabIndex = 117
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(26, 130)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl3.TabIndex = 118
        Me.LabelControl3.Text = "Customer"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_update.Appearance.Options.UseFont = True
        Me.btn_update.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_32x32
        Me.btn_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_update.Location = New System.Drawing.Point(935, 73)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(118, 46)
        Me.btn_update.TabIndex = 125
        Me.btn_update.Text = "Save"
        Me.btn_update.Visible = False
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_clear.Appearance.Options.UseFont = True
        Me.btn_clear.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.clearall_32x32
        Me.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_clear.Location = New System.Drawing.Point(811, 121)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(118, 46)
        Me.btn_clear.TabIndex = 124
        Me.btn_clear.Text = "Clear"
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boproductgroup_32x321
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.Location = New System.Drawing.Point(935, 121)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(118, 46)
        Me.btn_create.TabIndex = 123
        Me.btn_create.Text = "Create"
        '
        'LabelControl1
        '
        Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(57, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(826, 590)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(50, 22)
        Me.LabelControl1.TabIndex = 128
        Me.LabelControl1.Text = "Total"
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_total.Appearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_total.Appearance.Options.UseBackColor = True
        Me.lbl_total.Appearance.Options.UseBorderColor = True
        Me.lbl_total.Appearance.Options.UseFont = True
        Me.lbl_total.Appearance.Options.UseForeColor = True
        Me.lbl_total.Appearance.Options.UseTextOptions = True
        Me.lbl_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lbl_total.LineStyle = System.Drawing.Drawing2D.DashStyle.Dash
        Me.lbl_total.Location = New System.Drawing.Point(882, 590)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total.Size = New System.Drawing.Size(171, 29)
        Me.lbl_total.TabIndex = 129
        Me.lbl_total.Text = "₱0.00"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(26, 103)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl4.TabIndex = 130
        Me.LabelControl4.Text = "SRID"
        '
        'txt_srid
        '
        Me.txt_srid.Enabled = False
        Me.txt_srid.Location = New System.Drawing.Point(128, 100)
        Me.txt_srid.Name = "txt_srid"
        Me.txt_srid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_srid.Properties.Appearance.Options.UseFont = True
        Me.txt_srid.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_srid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_srid.Size = New System.Drawing.Size(58, 22)
        Me.txt_srid.TabIndex = 131
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(26, 152)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(83, 16)
        Me.LabelControl5.TabIndex = 132
        Me.LabelControl5.Text = "Account Type"
        '
        'lbl_account_type
        '
        Me.lbl_account_type.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_account_type.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_account_type.Appearance.Options.UseFont = True
        Me.lbl_account_type.Appearance.Options.UseForeColor = True
        Me.lbl_account_type.Location = New System.Drawing.Point(128, 152)
        Me.lbl_account_type.Name = "lbl_account_type"
        Me.lbl_account_type.Size = New System.Drawing.Size(0, 16)
        Me.lbl_account_type.TabIndex = 133
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x32
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_approved.Location = New System.Drawing.Point(439, 121)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(118, 46)
        Me.btn_approved.TabIndex = 134
        Me.btn_approved.Text = "Approved"
        Me.btn_approved.Visible = False
        '
        'lbl_store_id
        '
        Me.lbl_store_id.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_store_id.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_store_id.Appearance.Options.UseFont = True
        Me.lbl_store_id.Appearance.Options.UseForeColor = True
        Me.lbl_store_id.Location = New System.Drawing.Point(192, 103)
        Me.lbl_store_id.Name = "lbl_store_id"
        Me.lbl_store_id.Size = New System.Drawing.Size(69, 16)
        Me.lbl_store_id.TabIndex = 136
        Me.lbl_store_id.Text = "lbl_store_id"
        Me.lbl_store_id.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_delete.Location = New System.Drawing.Point(563, 121)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 46)
        Me.btn_delete.TabIndex = 126
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.Visible = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.Enabled = False
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x32
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.Location = New System.Drawing.Point(687, 121)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(118, 46)
        Me.btn_print.TabIndex = 137
        Me.btn_print.Text = "Print"
        '
        'frm_sales_return_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1077, 634)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.lbl_store_id)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.lbl_account_type)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_srid)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.txt_customer_id)
        Me.Controls.Add(Me.cbb_customer)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.grid_return)
        Me.Controls.Add(Me.GunaPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_return_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_sales_return_new"
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.grid_return, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_srid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbl_action As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_return As DataGridView
    Friend WithEvents txt_customer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_customer As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_sales_return As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_srid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_account_type As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_store_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_totalcost As DataGridViewTextBoxColumn
    Friend WithEvents col_pid As DataGridViewTextBoxColumn
    Friend WithEvents col_last_order_date As DataGridViewTextBoxColumn
    Friend WithEvents col_last_qty As DataGridViewTextBoxColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
End Class
