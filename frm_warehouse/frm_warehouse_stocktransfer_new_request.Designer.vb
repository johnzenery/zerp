<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_new_request
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stocktransfer_new_request))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_created_by = New DevExpress.XtraEditors.LabelControl()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_stid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_request_stock = New System.Windows.Forms.DataGridView()
        Me.pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.winmodel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_masterbox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_innerBox = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty_needed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cbm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_kgs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total_kgs = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_total_cbm = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_arrange = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_note = New System.Windows.Forms.TextBox()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_import = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_search = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_src_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.PopupMenu_button = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me.barmanager_btn = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.dropdown_btn = New DevExpress.XtraEditors.DropDownButton()
        CType(Me.txt_stid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_request_stock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_src_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu_button, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.barmanager_btn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(379, 31)
        Me.lbl_title.TabIndex = 82
        Me.lbl_title.Text = "New Stock Transfer - Request"
        '
        'lbl_created_by
        '
        Me.lbl_created_by.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_created_by.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lbl_created_by.Appearance.ForeColor = System.Drawing.Color.DarkGray
        Me.lbl_created_by.Appearance.Options.UseFont = True
        Me.lbl_created_by.Appearance.Options.UseForeColor = True
        Me.lbl_created_by.Appearance.Options.UseTextOptions = True
        Me.lbl_created_by.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_created_by.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_created_by.Location = New System.Drawing.Point(739, 45)
        Me.lbl_created_by.Name = "lbl_created_by"
        Me.lbl_created_by.Size = New System.Drawing.Size(400, 20)
        Me.lbl_created_by.TabIndex = 79
        Me.lbl_created_by.Text = "Created by"
        Me.lbl_created_by.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.ImageOptions.Image = CType(resources.GetObject("btn_save.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_save.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_save.Location = New System.Drawing.Point(603, 130)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(118, 46)
        Me.btn_save.TabIndex = 85
        Me.btn_save.Text = "Save"
        Me.btn_save.Visible = False
        '
        'txt_stid
        '
        Me.txt_stid.Enabled = False
        Me.txt_stid.Location = New System.Drawing.Point(152, 77)
        Me.txt_stid.Name = "txt_stid"
        Me.txt_stid.Size = New System.Drawing.Size(100, 28)
        Me.txt_stid.TabIndex = 84
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(19, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl2.TabIndex = 83
        Me.LabelControl2.Text = "Stock Transfer ID"
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.ImageOptions.Image = CType(resources.GetObject("btn_delete.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_delete.Location = New System.Drawing.Point(603, 80)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(118, 46)
        Me.btn_delete.TabIndex = 82
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.Visible = False
        '
        'btn_create
        '
        Me.btn_create.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_create.Enabled = False
        Me.btn_create.ImageOptions.Image = CType(resources.GetObject("btn_create.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_create.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_create.Location = New System.Drawing.Point(479, 130)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(118, 46)
        Me.btn_create.TabIndex = 81
        Me.btn_create.Text = "Create"
        Me.btn_create.Visible = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 116)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl1.TabIndex = 79
        Me.LabelControl1.Text = "Requested by"
        '
        'grid_request_stock
        '
        Me.grid_request_stock.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_request_stock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_request_stock.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_request_stock.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_request_stock.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.grid_request_stock.ColumnHeadersHeight = 40
        Me.grid_request_stock.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.pid, Me.winmodel, Me.description, Me.col_masterbox, Me.col_innerBox, Me.col_qty_needed, Me.qty, Me.col_cbm, Me.col_kgs})
        Me.grid_request_stock.Enabled = False
        Me.grid_request_stock.EnableHeadersVisualStyles = False
        Me.grid_request_stock.GridColor = System.Drawing.SystemColors.InactiveCaption
        Me.grid_request_stock.Location = New System.Drawing.Point(17, 180)
        Me.grid_request_stock.Margin = New System.Windows.Forms.Padding(0)
        Me.grid_request_stock.Name = "grid_request_stock"
        Me.grid_request_stock.RowHeadersWidth = 40
        Me.grid_request_stock.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_request_stock.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.grid_request_stock.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_request_stock.RowTemplate.Height = 40
        Me.grid_request_stock.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_request_stock.Size = New System.Drawing.Size(1120, 328)
        Me.grid_request_stock.TabIndex = 78
        '
        'pid
        '
        Me.pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.pid.DataPropertyName = "pid"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.pid.DefaultCellStyle = DataGridViewCellStyle12
        Me.pid.FillWeight = 80.0!
        Me.pid.HeaderText = "PID"
        Me.pid.MinimumWidth = 80
        Me.pid.Name = "pid"
        Me.pid.Width = 80
        '
        'winmodel
        '
        Me.winmodel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.winmodel.DataPropertyName = "winmodel"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.winmodel.DefaultCellStyle = DataGridViewCellStyle13
        Me.winmodel.FillWeight = 73.71088!
        Me.winmodel.HeaderText = "Model"
        Me.winmodel.MinimumWidth = 120
        Me.winmodel.Name = "winmodel"
        Me.winmodel.Width = 120
        '
        'description
        '
        Me.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.description.DataPropertyName = "description"
        Me.description.FillWeight = 300.0!
        Me.description.HeaderText = "Description"
        Me.description.MinimumWidth = 300
        Me.description.Name = "description"
        Me.description.Width = 300
        '
        'col_masterbox
        '
        Me.col_masterbox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_masterbox.DataPropertyName = "masterbox_qty"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_masterbox.DefaultCellStyle = DataGridViewCellStyle14
        Me.col_masterbox.FillWeight = 80.0!
        Me.col_masterbox.HeaderText = "MasterBox Qty."
        Me.col_masterbox.MinimumWidth = 80
        Me.col_masterbox.Name = "col_masterbox"
        Me.col_masterbox.Width = 80
        '
        'col_innerBox
        '
        Me.col_innerBox.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_innerBox.DataPropertyName = "qty_per_box"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_innerBox.DefaultCellStyle = DataGridViewCellStyle15
        Me.col_innerBox.FillWeight = 80.0!
        Me.col_innerBox.HeaderText = "Inner Box Qty."
        Me.col_innerBox.MinimumWidth = 80
        Me.col_innerBox.Name = "col_innerBox"
        Me.col_innerBox.Width = 80
        '
        'col_qty_needed
        '
        Me.col_qty_needed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty_needed.DataPropertyName = "qty_needed"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_qty_needed.DefaultCellStyle = DataGridViewCellStyle16
        Me.col_qty_needed.FillWeight = 80.0!
        Me.col_qty_needed.HeaderText = "QTY. Needed"
        Me.col_qty_needed.Name = "col_qty_needed"
        Me.col_qty_needed.Width = 80
        '
        'qty
        '
        Me.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.qty.DataPropertyName = "qty"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle17.NullValue = Nothing
        Me.qty.DefaultCellStyle = DataGridViewCellStyle17
        Me.qty.FillWeight = 80.0!
        Me.qty.HeaderText = "QTY. Requested"
        Me.qty.MinimumWidth = 80
        Me.qty.Name = "qty"
        Me.qty.Width = 80
        '
        'col_cbm
        '
        Me.col_cbm.DataPropertyName = "cbm"
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle18.Format = "N2"
        Me.col_cbm.DefaultCellStyle = DataGridViewCellStyle18
        Me.col_cbm.HeaderText = "CBM"
        Me.col_cbm.Name = "col_cbm"
        Me.col_cbm.ReadOnly = True
        Me.col_cbm.Width = 60
        '
        'col_kgs
        '
        Me.col_kgs.DataPropertyName = "kgs"
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Gray
        DataGridViewCellStyle19.Format = "N2"
        Me.col_kgs.DefaultCellStyle = DataGridViewCellStyle19
        Me.col_kgs.HeaderText = "KGS"
        Me.col_kgs.Name = "col_kgs"
        Me.col_kgs.ReadOnly = True
        Me.col_kgs.Width = 60
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.ImageOptions.Image = CType(resources.GetObject("btn_print.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(851, 80)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(118, 46)
        Me.btn_print.TabIndex = 86
        Me.btn_print.Text = "Print"
        Me.btn_print.Visible = False
        '
        'lbl_total_kgs
        '
        Me.lbl_total_kgs.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_kgs.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl_total_kgs.Appearance.Options.UseFont = True
        Me.lbl_total_kgs.Location = New System.Drawing.Point(1073, 572)
        Me.lbl_total_kgs.Name = "lbl_total_kgs"
        Me.lbl_total_kgs.Size = New System.Drawing.Size(59, 13)
        Me.lbl_total_kgs.TabIndex = 90
        Me.lbl_total_kgs.Text = "lbl_total_kgs"
        '
        'lbl_total_cbm
        '
        Me.lbl_total_cbm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_cbm.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.lbl_total_cbm.Appearance.Options.UseFont = True
        Me.lbl_total_cbm.Location = New System.Drawing.Point(1074, 553)
        Me.lbl_total_cbm.Name = "lbl_total_cbm"
        Me.lbl_total_cbm.Size = New System.Drawing.Size(62, 13)
        Me.lbl_total_cbm.TabIndex = 89
        Me.lbl_total_cbm.Text = "lbl_total_cbm"
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(975, 572)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(64, 13)
        Me.LabelControl4.TabIndex = 88
        Me.LabelControl4.Text = "Total Weight:"
        '
        'LabelControl3
        '
        Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(975, 553)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(87, 13)
        Me.LabelControl3.TabIndex = 87
        Me.LabelControl3.Text = "Total Cubic Meter:"
        '
        'btn_arrange
        '
        Me.btn_arrange.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_arrange.Enabled = False
        Me.btn_arrange.ImageOptions.Image = CType(resources.GetObject("btn_arrange.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_arrange.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_arrange.ImageOptions.ImageToTextIndent = 5
        Me.btn_arrange.Location = New System.Drawing.Point(727, 80)
        Me.btn_arrange.Name = "btn_arrange"
        Me.btn_arrange.Size = New System.Drawing.Size(118, 46)
        Me.btn_arrange.TabIndex = 92
        Me.btn_arrange.Text = "Arrange"
        Me.btn_arrange.Visible = False
        '
        'LabelControl5
        '
        Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(18, 512)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(60, 13)
        Me.LabelControl5.TabIndex = 94
        Me.LabelControl5.Text = "Public Notes"
        '
        'txt_note
        '
        Me.txt_note.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_note.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_note.Location = New System.Drawing.Point(18, 531)
        Me.txt_note.Multiline = True
        Me.txt_note.Name = "txt_note"
        Me.txt_note.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_note.Size = New System.Drawing.Size(565, 55)
        Me.txt_note.TabIndex = 93
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.ImageOptions.Image = CType(resources.GetObject("btn_approved.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_approved.Location = New System.Drawing.Point(479, 80)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(118, 46)
        Me.btn_approved.TabIndex = 95
        Me.btn_approved.Text = "Response"
        Me.btn_approved.Visible = False
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(0, 0)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        '
        'btn_import
        '
        Me.btn_import.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_import.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.loadfrom_32x32
        Me.btn_import.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_import.ImageOptions.ImageToTextIndent = 5
        Me.btn_import.Location = New System.Drawing.Point(727, 130)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(118, 46)
        Me.btn_import.TabIndex = 96
        Me.btn_import.Text = "Import"
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(918, 146)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl16.TabIndex = 122
        Me.LabelControl16.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Location = New System.Drawing.Point(967, 141)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txt_search.Properties.Appearance.Options.UseFont = True
        Me.txt_search.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_search.Size = New System.Drawing.Size(171, 32)
        Me.txt_search.TabIndex = 121
        Me.txt_search.TabStop = False
        '
        'cbb_src_warehouse
        '
        Me.cbb_src_warehouse.Location = New System.Drawing.Point(152, 111)
        Me.cbb_src_warehouse.Name = "cbb_src_warehouse"
        Me.cbb_src_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_src_warehouse.Size = New System.Drawing.Size(290, 28)
        Me.cbb_src_warehouse.TabIndex = 123
        '
        'lbl_status
        '
        Me.lbl_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_status.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_status.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.lbl_status.Appearance.Options.UseFont = True
        Me.lbl_status.Appearance.Options.UseForeColor = True
        Me.lbl_status.Appearance.Options.UseTextOptions = True
        Me.lbl_status.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_status.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_status.Location = New System.Drawing.Point(739, 9)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(400, 30)
        Me.lbl_status.TabIndex = 124
        Me.lbl_status.Text = "Status"
        Me.lbl_status.Visible = False
        '
        'PopupMenu_button
        '
        Me.PopupMenu_button.Manager = Me.barmanager_btn
        Me.PopupMenu_button.Name = "PopupMenu_button"
        '
        'barmanager_btn
        '
        Me.barmanager_btn.DockControls.Add(Me.barDockControlTop)
        Me.barmanager_btn.DockControls.Add(Me.barDockControlBottom)
        Me.barmanager_btn.DockControls.Add(Me.barDockControlLeft)
        Me.barmanager_btn.DockControls.Add(Me.barDockControlRight)
        Me.barmanager_btn.Form = Me
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.barmanager_btn
        Me.barDockControlTop.Size = New System.Drawing.Size(1150, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 598)
        Me.barDockControlBottom.Manager = Me.barmanager_btn
        Me.barDockControlBottom.Size = New System.Drawing.Size(1150, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.barmanager_btn
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 598)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1150, 0)
        Me.barDockControlRight.Manager = Me.barmanager_btn
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 598)
        '
        'dropdown_btn
        '
        Me.dropdown_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dropdown_btn.DropDownControl = Me.PopupMenu_button
        Me.dropdown_btn.Location = New System.Drawing.Point(975, 80)
        Me.dropdown_btn.Name = "dropdown_btn"
        Me.dropdown_btn.Size = New System.Drawing.Size(163, 46)
        Me.dropdown_btn.TabIndex = 129
        Me.dropdown_btn.Text = "-- Select Action --"
        '
        'frm_warehouse_stocktransfer_new_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1150, 598)
        Me.Controls.Add(Me.dropdown_btn)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.cbb_src_warehouse)
        Me.Controls.Add(Me.lbl_created_by)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.LabelControl16)
        Me.Controls.Add(Me.txt_search)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_note)
        Me.Controls.Add(Me.btn_arrange)
        Me.Controls.Add(Me.lbl_total_kgs)
        Me.Controls.Add(Me.lbl_total_cbm)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_stid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_request_stock)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stocktransfer_new_request.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_warehouse_stocktransfer_new_request"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Stock Transfer - Request"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.txt_stid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_request_stock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_src_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu_button, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.barmanager_btn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_created_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_stid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_request_stock As DataGridView
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_total_kgs As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_total_cbm As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_title As Label
    Friend WithEvents btn_arrange As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_note As TextBox
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_import As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents pid As DataGridViewTextBoxColumn
    Friend WithEvents winmodel As DataGridViewTextBoxColumn
    Friend WithEvents description As DataGridViewTextBoxColumn
    Friend WithEvents col_masterbox As DataGridViewTextBoxColumn
    Friend WithEvents col_innerBox As DataGridViewTextBoxColumn
    Friend WithEvents col_qty_needed As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents col_cbm As DataGridViewTextBoxColumn
    Friend WithEvents col_kgs As DataGridViewTextBoxColumn
    Friend WithEvents cbb_src_warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_status As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PopupMenu_button As DevExpress.XtraBars.PopupMenu
    Friend WithEvents barmanager_btn As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents dropdown_btn As DevExpress.XtraEditors.DropDownButton
End Class
