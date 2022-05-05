Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Mask
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_purchaseorder_edit
    Inherits System.Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.lbl_created_by = New DevExpress.XtraEditors.LabelControl()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl3 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.txt_status = New DevExpress.XtraEditors.TextEdit()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_noofitems = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_date = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_search = New DevExpress.XtraEditors.TextEdit()
        Me.btn_approval = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_stocks = New System.Windows.Forms.DataGridView()
        Me.col_other = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txt_pub_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.cb_vatable = New System.Windows.Forms.CheckBox()
        Me.lbl_withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_active_orders = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
        Me.cb_tax_applied = New System.Windows.Forms.CheckBox()
        Me.lbl_dispose = New System.Windows.Forms.LinkLabel()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_lead_time = New DevExpress.XtraEditors.TextEdit()
        Me.txt_del_address = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_terms = New DevExpress.XtraEditors.TextEdit()
        Me.btn_send = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_delete = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_save_draft = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_poid = New DevExpress.XtraEditors.TextEdit()
        Me.txt_priv_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_deliver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_order = New System.Windows.Forms.DataGridView()
        Me.col_pid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_qty_per_box = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_sup_model = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_cost = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_total_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_to_received = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_remaining = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CMS_print = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMS_strip_purchase_order = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_strip_purchase_slip = New System.Windows.Forms.ToolStripMenuItem()
        Me.cb_payment_first = New System.Windows.Forms.CheckBox()
        Me.GunaPanel4.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        CType(Me.txt_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stocks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lead_time.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_del_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_print.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.lbl_created_by)
        Me.GunaPanel4.Controls.Add(Me.GunaPanel5)
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Controls.Add(Me.txt_status)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(1357, 78)
        Me.GunaPanel4.TabIndex = 9
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
        Me.lbl_created_by.Location = New System.Drawing.Point(931, 46)
        Me.lbl_created_by.Name = "lbl_created_by"
        Me.lbl_created_by.Size = New System.Drawing.Size(400, 20)
        Me.lbl_created_by.TabIndex = 70
        Me.lbl_created_by.Text = "Created by"
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel1)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(841, 27)
        Me.GunaPanel5.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.HyperlinkLabelControl3)
        Me.GunaPanel1.Controls.Add(Me.LabelControl8)
        Me.GunaPanel1.Controls.Add(Me.link_po_list)
        Me.GunaPanel1.Controls.Add(Me.LabelControl7)
        Me.GunaPanel1.Controls.Add(Me.link_home)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 0
        '
        'HyperlinkLabelControl3
        '
        Me.HyperlinkLabelControl3.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl3.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl3.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl3.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl3.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl3.Enabled = False
        Me.HyperlinkLabelControl3.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl3.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl3.Location = New System.Drawing.Point(182, 5)
        Me.HyperlinkLabelControl3.Name = "HyperlinkLabelControl3"
        Me.HyperlinkLabelControl3.ShowLineShadow = False
        Me.HyperlinkLabelControl3.Size = New System.Drawing.Size(24, 18)
        Me.HyperlinkLabelControl3.TabIndex = 9
        Me.HyperlinkLabelControl3.Text = "Edit"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(167, 7)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl8.TabIndex = 8
        Me.LabelControl8.Text = ">"
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(91, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Purchasing List"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        '
        'link_home
        '
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_home.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_home.Location = New System.Drawing.Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(259, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Edit Purchase Order"
        '
        'txt_status
        '
        Me.txt_status.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_status.EditValue = "Status"
        Me.txt_status.Location = New System.Drawing.Point(980, 11)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Properties.AllowFocused = False
        Me.txt_status.Properties.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.txt_status.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txt_status.Properties.Appearance.ForeColor = System.Drawing.Color.Orange
        Me.txt_status.Properties.Appearance.Options.UseBackColor = True
        Me.txt_status.Properties.Appearance.Options.UseFont = True
        Me.txt_status.Properties.Appearance.Options.UseForeColor = True
        Me.txt_status.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_status.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_status.Properties.AutoHeight = False
        Me.txt_status.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.txt_status.Properties.ReadOnly = True
        Me.txt_status.Properties.UseReadOnlyAppearance = False
        Me.txt_status.Size = New System.Drawing.Size(351, 34)
        Me.txt_status.TabIndex = 76
        Me.txt_status.TabStop = False
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat
        Me.PanelControl1.Controls.Add(Me.cb_payment_first)
        Me.PanelControl1.Controls.Add(Me.lbl_noofitems)
        Me.PanelControl1.Controls.Add(Me.LabelControl18)
        Me.PanelControl1.Controls.Add(Me.lbl_date)
        Me.PanelControl1.Controls.Add(Me.LabelControl17)
        Me.PanelControl1.Controls.Add(Me.LabelControl16)
        Me.PanelControl1.Controls.Add(Me.txt_search)
        Me.PanelControl1.Controls.Add(Me.btn_approval)
        Me.PanelControl1.Controls.Add(Me.grid_stocks)
        Me.PanelControl1.Controls.Add(Me.txt_pub_notes)
        Me.PanelControl1.Controls.Add(Me.LabelControl15)
        Me.PanelControl1.Controls.Add(Me.cb_vatable)
        Me.PanelControl1.Controls.Add(Me.lbl_withholding_tax_amount)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Controls.Add(Me.btn_active_orders)
        Me.PanelControl1.Controls.Add(Me.lbl_withholding_tax_percentage)
        Me.PanelControl1.Controls.Add(Me.cb_tax_applied)
        Me.PanelControl1.Controls.Add(Me.lbl_dispose)
        Me.PanelControl1.Controls.Add(Me.LabelControl13)
        Me.PanelControl1.Controls.Add(Me.txt_lead_time)
        Me.PanelControl1.Controls.Add(Me.txt_del_address)
        Me.PanelControl1.Controls.Add(Me.btn_approved)
        Me.PanelControl1.Controls.Add(Me.LabelControl12)
        Me.PanelControl1.Controls.Add(Me.txt_terms)
        Me.PanelControl1.Controls.Add(Me.btn_send)
        Me.PanelControl1.Controls.Add(Me.btn_delete)
        Me.PanelControl1.Controls.Add(Me.btn_print)
        Me.PanelControl1.Controls.Add(Me.btn_save_draft)
        Me.PanelControl1.Controls.Add(Me.LabelControl5)
        Me.PanelControl1.Controls.Add(Me.txt_poid)
        Me.PanelControl1.Controls.Add(Me.txt_priv_notes)
        Me.PanelControl1.Controls.Add(Me.LabelControl4)
        Me.PanelControl1.Controls.Add(Me.cbb_deliver)
        Me.PanelControl1.Controls.Add(Me.lbl_total)
        Me.PanelControl1.Controls.Add(Me.txt_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl10)
        Me.PanelControl1.Controls.Add(Me.cbb_discount)
        Me.PanelControl1.Controls.Add(Me.LabelControl9)
        Me.PanelControl1.Controls.Add(Me.grid_order)
        Me.PanelControl1.Controls.Add(Me.cbb_supplier)
        Me.PanelControl1.Controls.Add(Me.LabelControl1)
        Me.PanelControl1.Controls.Add(Me.LabelControl6)
        Me.PanelControl1.Controls.Add(Me.LabelControl2)
        Me.PanelControl1.Controls.Add(Me.txt_contact)
        Me.PanelControl1.Controls.Add(Me.LabelControl3)
        Me.PanelControl1.Location = New System.Drawing.Point(24, 97)
        Me.PanelControl1.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.PanelControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(1307, 614)
        Me.PanelControl1.TabIndex = 52
        '
        'lbl_noofitems
        '
        Me.lbl_noofitems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_noofitems.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noofitems.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_noofitems.Appearance.Options.UseFont = True
        Me.lbl_noofitems.Appearance.Options.UseForeColor = True
        Me.lbl_noofitems.Location = New System.Drawing.Point(100, 485)
        Me.lbl_noofitems.Name = "lbl_noofitems"
        Me.lbl_noofitems.Size = New System.Drawing.Size(93, 16)
        Me.lbl_noofitems.TabIndex = 122
        Me.lbl_noofitems.Text = "lbl_no_of_items"
        '
        'LabelControl18
        '
        Me.LabelControl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(21, 485)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(73, 16)
        Me.LabelControl18.TabIndex = 121
        Me.LabelControl18.Text = "No. of Items:"
        '
        'lbl_date
        '
        Me.lbl_date.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_date.Appearance.Options.UseFont = True
        Me.lbl_date.Appearance.Options.UseForeColor = True
        Me.lbl_date.Location = New System.Drawing.Point(320, 17)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(23, 16)
        Me.lbl_date.TabIndex = 120
        Me.lbl_date.Text = "N/A"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(226, 17)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl17.TabIndex = 119
        Me.LabelControl17.Text = "Default Date:"
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Appearance.Options.UseForeColor = True
        Me.LabelControl16.Location = New System.Drawing.Point(1060, 127)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(43, 16)
        Me.LabelControl16.TabIndex = 118
        Me.LabelControl16.Text = "Search"
        '
        'txt_search
        '
        Me.txt_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_search.Location = New System.Drawing.Point(1109, 122)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.txt_search.Properties.Appearance.Options.UseFont = True
        Me.txt_search.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_search.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_search.Size = New System.Drawing.Size(171, 24)
        Me.txt_search.TabIndex = 117
        Me.txt_search.TabStop = False
        '
        'btn_approval
        '
        Me.btn_approval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approval.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approval.Appearance.Options.UseFont = True
        Me.btn_approval.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_16x16
        Me.btn_approval.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_approval.Location = New System.Drawing.Point(1072, 17)
        Me.btn_approval.Name = "btn_approval"
        Me.btn_approval.Size = New System.Drawing.Size(77, 60)
        Me.btn_approval.TabIndex = 116
        Me.btn_approval.Text = "Submit for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Approval"
        '
        'grid_stocks
        '
        Me.grid_stocks.AllowUserToAddRows = False
        Me.grid_stocks.AllowUserToDeleteRows = False
        Me.grid_stocks.AllowUserToResizeColumns = False
        Me.grid_stocks.AllowUserToResizeRows = False
        Me.grid_stocks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grid_stocks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_stocks.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_stocks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_stocks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_stocks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_stocks.ColumnHeadersHeight = 32
        Me.grid_stocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_stocks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_other})
        Me.grid_stocks.Enabled = False
        Me.grid_stocks.EnableHeadersVisualStyles = False
        Me.grid_stocks.Location = New System.Drawing.Point(21, 152)
        Me.grid_stocks.MultiSelect = False
        Me.grid_stocks.Name = "grid_stocks"
        Me.grid_stocks.ReadOnly = True
        Me.grid_stocks.RowHeadersVisible = False
        Me.grid_stocks.RowHeadersWidth = 47
        Me.grid_stocks.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stocks.RowTemplate.Height = 23
        Me.grid_stocks.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.grid_stocks.Size = New System.Drawing.Size(51, 327)
        Me.grid_stocks.TabIndex = 115
        '
        'col_other
        '
        Me.col_other.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_other.DefaultCellStyle = DataGridViewCellStyle2
        Me.col_other.HeaderText = "All Stocks"
        Me.col_other.MinimumWidth = 6
        Me.col_other.Name = "col_other"
        Me.col_other.ReadOnly = True
        Me.col_other.Width = 50
        '
        'txt_pub_notes
        '
        Me.txt_pub_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_pub_notes.Location = New System.Drawing.Point(28, 539)
        Me.txt_pub_notes.Name = "txt_pub_notes"
        Me.txt_pub_notes.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pub_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_notes.Size = New System.Drawing.Size(377, 62)
        Me.txt_pub_notes.TabIndex = 108
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(28, 517)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl15.TabIndex = 109
        Me.LabelControl15.Text = "Public Notes:"
        '
        'cb_vatable
        '
        Me.cb_vatable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_vatable.AutoSize = True
        Me.cb_vatable.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_vatable.Location = New System.Drawing.Point(956, 522)
        Me.cb_vatable.Name = "cb_vatable"
        Me.cb_vatable.Size = New System.Drawing.Size(98, 18)
        Me.cb_vatable.TabIndex = 107
        Me.cb_vatable.Text = "Vatable Sales"
        Me.cb_vatable.UseVisualStyleBackColor = True
        '
        'lbl_withholding_tax_amount
        '
        Me.lbl_withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_withholding_tax_amount.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_amount.Location = New System.Drawing.Point(1170, 544)
        Me.lbl_withholding_tax_amount.Name = "lbl_withholding_tax_amount"
        Me.lbl_withholding_tax_amount.Size = New System.Drawing.Size(111, 14)
        Me.lbl_withholding_tax_amount.TabIndex = 103
        Me.lbl_withholding_tax_amount.Text = "₱ 0.00"
        '
        'LabelControl14
        '
        Me.LabelControl14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(1080, 546)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(84, 14)
        Me.LabelControl14.TabIndex = 102
        Me.LabelControl14.Text = "WT Deduction:"
        '
        'btn_active_orders
        '
        Me.btn_active_orders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_active_orders.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.info_16x16
        Me.btn_active_orders.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_active_orders.Location = New System.Drawing.Point(1155, 83)
        Me.btn_active_orders.Name = "btn_active_orders"
        Me.btn_active_orders.Size = New System.Drawing.Size(126, 25)
        Me.btn_active_orders.TabIndex = 101
        Me.btn_active_orders.Text = "View Active Orders"
        '
        'lbl_withholding_tax_percentage
        '
        Me.lbl_withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_percentage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_percentage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_percentage.Location = New System.Drawing.Point(1208, 526)
        Me.lbl_withholding_tax_percentage.Name = "lbl_withholding_tax_percentage"
        Me.lbl_withholding_tax_percentage.Size = New System.Drawing.Size(73, 14)
        Me.lbl_withholding_tax_percentage.TabIndex = 100
        Me.lbl_withholding_tax_percentage.Text = "0.00%"
        '
        'cb_tax_applied
        '
        Me.cb_tax_applied.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_tax_applied.AutoSize = True
        Me.cb_tax_applied.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_tax_applied.Location = New System.Drawing.Point(1060, 522)
        Me.cb_tax_applied.Name = "cb_tax_applied"
        Me.cb_tax_applied.Size = New System.Drawing.Size(142, 18)
        Me.cb_tax_applied.TabIndex = 99
        Me.cb_tax_applied.Text = "Apply Witholding Tax"
        Me.cb_tax_applied.UseVisualStyleBackColor = True
        '
        'lbl_dispose
        '
        Me.lbl_dispose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_dispose.AutoSize = True
        Me.lbl_dispose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dispose.Location = New System.Drawing.Point(1036, 88)
        Me.lbl_dispose.Name = "lbl_dispose"
        Me.lbl_dispose.Size = New System.Drawing.Size(113, 16)
        Me.lbl_dispose.TabIndex = 98
        Me.lbl_dispose.TabStop = True
        Me.lbl_dispose.Text = "Dispose this Order"
        Me.lbl_dispose.Visible = False
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl13.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Appearance.Options.UseForeColor = True
        Me.LabelControl13.Location = New System.Drawing.Point(226, 47)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(111, 16)
        Me.LabelControl13.TabIndex = 96
        Me.LabelControl13.Text = "Lead Time (Days):"
        '
        'txt_lead_time
        '
        Me.txt_lead_time.Location = New System.Drawing.Point(343, 44)
        Me.txt_lead_time.Name = "txt_lead_time"
        Me.txt_lead_time.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lead_time.Properties.Appearance.Options.UseFont = True
        Me.txt_lead_time.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_lead_time.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_lead_time.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_lead_time.Size = New System.Drawing.Size(60, 22)
        Me.txt_lead_time.TabIndex = 1
        '
        'txt_del_address
        '
        Me.txt_del_address.Location = New System.Drawing.Point(537, 72)
        Me.txt_del_address.Name = "txt_del_address"
        Me.txt_del_address.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_del_address.Properties.Appearance.Options.UseFont = True
        Me.txt_del_address.Size = New System.Drawing.Size(287, 56)
        Me.txt_del_address.TabIndex = 4
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.knowledgebasearticle_32x32
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_approved.Location = New System.Drawing.Point(853, 17)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(81, 60)
        Me.btn_approved.TabIndex = 13
        Me.btn_approved.Text = "Response"
        Me.btn_approved.Visible = False
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Appearance.Options.UseForeColor = True
        Me.LabelControl12.Location = New System.Drawing.Point(28, 47)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl12.TabIndex = 85
        Me.LabelControl12.Text = "Terms (Days):"
        '
        'txt_terms
        '
        Me.txt_terms.Location = New System.Drawing.Point(127, 44)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_terms.Properties.Appearance.Options.UseFont = True
        Me.txt_terms.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_terms.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_terms.Size = New System.Drawing.Size(86, 22)
        Me.txt_terms.TabIndex = 0
        '
        'btn_send
        '
        Me.btn_send.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_send.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_send.Appearance.Options.UseFont = True
        Me.btn_send.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.assignto_32x32
        Me.btn_send.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_send.Location = New System.Drawing.Point(1006, 17)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(60, 60)
        Me.btn_send.TabIndex = 11
        Me.btn_send.Text = "Send"
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(940, 17)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(60, 60)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x32
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(1221, 17)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(60, 60)
        Me.btn_print.TabIndex = 9
        Me.btn_print.Text = "Print"
        '
        'btn_save_draft
        '
        Me.btn_save_draft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save_draft.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save_draft.Appearance.Options.UseFont = True
        Me.btn_save_draft.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_16x16
        Me.btn_save_draft.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_save_draft.Location = New System.Drawing.Point(1155, 17)
        Me.btn_save_draft.Name = "btn_save_draft"
        Me.btn_save_draft.Size = New System.Drawing.Size(60, 60)
        Me.btn_save_draft.TabIndex = 10
        Me.btn_save_draft.Text = "Save as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draft"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(28, 17)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl5.TabIndex = 69
        Me.LabelControl5.Text = "Purchase ID:"
        '
        'txt_poid
        '
        Me.txt_poid.Location = New System.Drawing.Point(127, 14)
        Me.txt_poid.Name = "txt_poid"
        Me.txt_poid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_poid.Properties.Appearance.Options.UseFont = True
        Me.txt_poid.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_poid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_poid.Properties.ReadOnly = True
        Me.txt_poid.Size = New System.Drawing.Size(86, 22)
        Me.txt_poid.TabIndex = 70
        Me.txt_poid.TabStop = False
        '
        'txt_priv_notes
        '
        Me.txt_priv_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_priv_notes.Location = New System.Drawing.Point(411, 539)
        Me.txt_priv_notes.Name = "txt_priv_notes"
        Me.txt_priv_notes.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_priv_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_notes.Size = New System.Drawing.Size(377, 62)
        Me.txt_priv_notes.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(411, 517)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl4.TabIndex = 67
        Me.LabelControl4.Text = "Private Notes:"
        '
        'cbb_deliver
        '
        Me.cbb_deliver.Location = New System.Drawing.Point(499, 44)
        Me.cbb_deliver.Name = "cbb_deliver"
        Me.cbb_deliver.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_deliver.Properties.Appearance.Options.UseFont = True
        Me.cbb_deliver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_deliver.Size = New System.Drawing.Size(325, 22)
        Me.cbb_deliver.TabIndex = 3
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        Me.lbl_total.Appearance.Options.UseBackColor = True
        Me.lbl_total.Appearance.Options.UseFont = True
        Me.lbl_total.Appearance.Options.UseForeColor = True
        Me.lbl_total.Appearance.Options.UseTextOptions = True
        Me.lbl_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.lbl_total.Location = New System.Drawing.Point(1109, 576)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.lbl_total.Size = New System.Drawing.Size(171, 29)
        Me.lbl_total.TabIndex = 64
        Me.lbl_total.Text = "₱0.00"
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.Location = New System.Drawing.Point(1165, 491)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_discount.Properties.Appearance.Options.UseFont = True
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.Mask.EditMask = "n"
        Me.txt_discount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_discount.Size = New System.Drawing.Size(68, 22)
        Me.txt_discount.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(1079, 496)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(51, 14)
        Me.LabelControl10.TabIndex = 62
        Me.LabelControl10.Text = "Discount:"
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.Location = New System.Drawing.Point(1229, 491)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_discount.Properties.Appearance.Options.UseFont = True
        Me.cbb_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"peso", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(51, 22)
        Me.cbb_discount.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Consolas", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(983, 579)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(120, 22)
        Me.LabelControl9.TabIndex = 59
        Me.LabelControl9.Text = "Total Amount"
        '
        'grid_order
        '
        Me.grid_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_order.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_order.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_order.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.grid_order.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.grid_order.ColumnHeadersHeight = 32
        Me.grid_order.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_order.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.col_pid, Me.col_qty, Me.col_qty_per_box, Me.col_model, Me.col_sup_model, Me.col_description, Me.col_cost, Me.col_total, Me.col_total_received, Me.col_to_received, Me.col_remaining})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer), CType(CType(78, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grid_order.DefaultCellStyle = DataGridViewCellStyle12
        Me.grid_order.EnableHeadersVisualStyles = False
        Me.grid_order.Location = New System.Drawing.Point(73, 152)
        Me.grid_order.Name = "grid_order"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_order.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.grid_order.RowHeadersWidth = 30
        Me.grid_order.RowTemplate.Height = 23
        Me.grid_order.Size = New System.Drawing.Size(1208, 327)
        Me.grid_order.TabIndex = 5
        '
        'col_pid
        '
        Me.col_pid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_pid.DataPropertyName = "sku"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_pid.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_pid.FillWeight = 80.0!
        Me.col_pid.HeaderText = "SKU"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.ReadOnly = True
        Me.col_pid.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_qty
        '
        Me.col_qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty.DataPropertyName = "qty"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_qty.DefaultCellStyle = DataGridViewCellStyle5
        Me.col_qty.FillWeight = 80.0!
        Me.col_qty.HeaderText = "Quantity"
        Me.col_qty.Name = "col_qty"
        '
        'col_qty_per_box
        '
        Me.col_qty_per_box.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_qty_per_box.DataPropertyName = "qty_per_box"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.WhiteSmoke
        Me.col_qty_per_box.DefaultCellStyle = DataGridViewCellStyle6
        Me.col_qty_per_box.HeaderText = "Qty Per Box"
        Me.col_qty_per_box.Name = "col_qty_per_box"
        Me.col_qty_per_box.ReadOnly = True
        Me.col_qty_per_box.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_qty_per_box.Width = 60
        '
        'col_model
        '
        Me.col_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_model.DataPropertyName = "winmodel"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_model.DefaultCellStyle = DataGridViewCellStyle7
        Me.col_model.FillWeight = 73.71088!
        Me.col_model.HeaderText = "Win. Model"
        Me.col_model.Name = "col_model"
        Me.col_model.Width = 150
        '
        'col_sup_model
        '
        Me.col_sup_model.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_sup_model.DataPropertyName = "supmodel"
        Me.col_sup_model.HeaderText = "Sup. Model"
        Me.col_sup_model.Name = "col_sup_model"
        Me.col_sup_model.ReadOnly = True
        Me.col_sup_model.Width = 150
        '
        'col_description
        '
        Me.col_description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.col_description.DataPropertyName = "description"
        Me.col_description.FillWeight = 137.4594!
        Me.col_description.HeaderText = "Description"
        Me.col_description.Name = "col_description"
        '
        'col_cost
        '
        Me.col_cost.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_cost.DataPropertyName = "cost"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "n2"
        Me.col_cost.DefaultCellStyle = DataGridViewCellStyle8
        Me.col_cost.FillWeight = 102.6804!
        Me.col_cost.HeaderText = "Cost"
        Me.col_cost.Name = "col_cost"
        '
        'col_total
        '
        Me.col_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.col_total.DataPropertyName = "total"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "n2"
        Me.col_total.DefaultCellStyle = DataGridViewCellStyle9
        Me.col_total.FillWeight = 125.5929!
        Me.col_total.HeaderText = "Total"
        Me.col_total.Name = "col_total"
        Me.col_total.ReadOnly = True
        Me.col_total.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'col_total_received
        '
        Me.col_total_received.DataPropertyName = "total_received"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_total_received.DefaultCellStyle = DataGridViewCellStyle10
        Me.col_total_received.HeaderText = "Received"
        Me.col_total_received.Name = "col_total_received"
        Me.col_total_received.ReadOnly = True
        Me.col_total_received.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_total_received.Width = 76
        '
        'col_to_received
        '
        Me.col_to_received.DataPropertyName = "qty_received"
        Me.col_to_received.HeaderText = "Receive"
        Me.col_to_received.Name = "col_to_received"
        Me.col_to_received.ReadOnly = True
        Me.col_to_received.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_to_received.Visible = False
        Me.col_to_received.Width = 70
        '
        'col_remaining
        '
        Me.col_remaining.DataPropertyName = "remaining"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_remaining.DefaultCellStyle = DataGridViewCellStyle11
        Me.col_remaining.HeaderText = "Remaining"
        Me.col_remaining.Name = "col_remaining"
        Me.col_remaining.ReadOnly = True
        Me.col_remaining.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.col_remaining.Width = 81
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(127, 72)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Properties.ReadOnly = True
        Me.cbb_supplier.Size = New System.Drawing.Size(277, 22)
        Me.cbb_supplier.TabIndex = 43
        Me.cbb_supplier.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(28, 75)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(424, 47)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(60, 16)
        Me.LabelControl6.TabIndex = 49
        Me.LabelControl6.Text = "Deliver to:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(424, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(107, 16)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Delivery Address:"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(126, 100)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_contact.Properties.Appearance.Options.UseFont = True
        Me.txt_contact.Size = New System.Drawing.Size(277, 22)
        Me.txt_contact.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(28, 103)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(94, 16)
        Me.LabelControl3.TabIndex = 47
        Me.LabelControl3.Text = "Contact Person:"
        '
        'CMS_print
        '
        Me.CMS_print.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_strip_purchase_order, Me.CMS_strip_purchase_slip})
        Me.CMS_print.Name = "CMS_print"
        Me.CMS_print.Size = New System.Drawing.Size(168, 48)
        '
        'CMS_strip_purchase_order
        '
        Me.CMS_strip_purchase_order.Name = "CMS_strip_purchase_order"
        Me.CMS_strip_purchase_order.Size = New System.Drawing.Size(167, 22)
        Me.CMS_strip_purchase_order.Text = "Purchase Order"
        '
        'CMS_strip_purchase_slip
        '
        Me.CMS_strip_purchase_slip.Name = "CMS_strip_purchase_slip"
        Me.CMS_strip_purchase_slip.Size = New System.Drawing.Size(167, 22)
        Me.CMS_strip_purchase_slip.Text = "Purchase List"
        '
        'cb_payment_first
        '
        Me.cb_payment_first.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_payment_first.AutoSize = True
        Me.cb_payment_first.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cb_payment_first.Location = New System.Drawing.Point(956, 494)
        Me.cb_payment_first.Name = "cb_payment_first"
        Me.cb_payment_first.Size = New System.Drawing.Size(98, 18)
        Me.cb_payment_first.TabIndex = 123
        Me.cb_payment_first.Text = "Payment first"
        Me.cb_payment_first.UseVisualStyleBackColor = True
        '
        'frm_purchaseorder_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1357, 734)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.GunaPanel4)
        Me.Name = "frm_purchaseorder_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Purchase Order"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        CType(Me.txt_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stocks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lead_time.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_del_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_print.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_deliver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_total As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_order As DataGridView
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_poid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl3 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_delete As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_send As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_terms As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_del_address As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_lead_time As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_dispose As LinkLabel
    Friend WithEvents lbl_withholding_tax_percentage As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_tax_applied As CheckBox
    Friend WithEvents btn_active_orders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_withholding_tax_amount As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cb_vatable As CheckBox

    Friend WithEvents lbl_created_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_search As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_pub_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_priv_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_approval As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_stocks As DataGridView
    Friend WithEvents col_other As DataGridViewTextBoxColumn
    Friend WithEvents btn_save_draft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_date As LabelControl
    Friend WithEvents LabelControl17 As LabelControl
    Friend WithEvents lbl_noofitems As LabelControl
    Friend WithEvents LabelControl18 As LabelControl
    Friend WithEvents col_pid As DataGridViewTextBoxColumn
    Friend WithEvents col_qty As DataGridViewTextBoxColumn
    Friend WithEvents col_qty_per_box As DataGridViewTextBoxColumn
    Friend WithEvents col_model As DataGridViewTextBoxColumn
    Friend WithEvents col_sup_model As DataGridViewTextBoxColumn
    Friend WithEvents col_description As DataGridViewTextBoxColumn
    Friend WithEvents col_cost As DataGridViewTextBoxColumn
    Friend WithEvents col_total As DataGridViewTextBoxColumn
    Friend WithEvents col_total_received As DataGridViewTextBoxColumn
    Friend WithEvents col_to_received As DataGridViewTextBoxColumn
    Friend WithEvents col_remaining As DataGridViewTextBoxColumn
    Friend WithEvents CMS_print As ContextMenuStrip
    Friend WithEvents CMS_strip_purchase_order As ToolStripMenuItem
    Friend WithEvents CMS_strip_purchase_slip As ToolStripMenuItem
    Friend WithEvents cb_payment_first As CheckBox
End Class
