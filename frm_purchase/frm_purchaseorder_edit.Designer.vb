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
        Me.components = New System.ComponentModel.Container()
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.lbl_noofitems = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_date = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_approval = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_pub_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_active_orders = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_withholding_tax_percentage = New DevExpress.XtraEditors.LabelControl()
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
        Me.txt_priv_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_deliver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_discount = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.CMS_print = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CMS_strip_purchase_order = New System.Windows.Forms.ToolStripMenuItem()
        Me.CMS_strip_purchase_slip = New System.Windows.Forms.ToolStripMenuItem()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_poid = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_status = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_created_by = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_purchasing = New DevExpress.XtraGrid.GridControl()
        Me.grid_purchasing_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_bundle = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.ce_bundle = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col_sku = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_quantity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qtyperbox = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_min_order_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_masterbox_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_desc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_received = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_remain = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_remove_item = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_base_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_discount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_search = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_total = New DevExpress.XtraEditors.LabelControl()
        Me.btn_import = New DevExpress.XtraEditors.SimpleButton()
        Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl41 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl37 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl43 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl42 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.panel_computation = New DevExpress.XtraEditors.PanelControl()
        Me.lbl_total_purchase_due = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_vat_excl_sales = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_net_purchase = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_discount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_gross_purchase = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_vat_amount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_withholding_tax_amount = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_delivery_fee = New DevExpress.XtraEditors.LabelControl()
        Me.SeparatorControl1 = New DevExpress.XtraEditors.SeparatorControl()
        Me.SeparatorControl4 = New DevExpress.XtraEditors.SeparatorControl()
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.cb_ewt_tax_applied = New DevExpress.XtraEditors.CheckEdit()
        Me.cb_vatable = New DevExpress.XtraEditors.CheckEdit()
        Me.cb_nonvatable = New DevExpress.XtraEditors.CheckEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_recall = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressPanel = New DevExpress.XtraWaitForm.ProgressPanel()
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_lead_time.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_del_address.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CMS_print.SuspendLayout()
        CType(Me.grid_purchasing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_purchasing_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ce_bundle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_remove_item, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl2.SuspendLayout()
        CType(Me.panel_computation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_computation.SuspendLayout()
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.cb_ewt_tax_applied.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_vatable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cb_nonvatable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_noofitems
        '
        Me.lbl_noofitems.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_noofitems.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_noofitems.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_noofitems.Appearance.Options.UseFont = True
        Me.lbl_noofitems.Appearance.Options.UseForeColor = True
        Me.lbl_noofitems.Location = New System.Drawing.Point(106, 746)
        Me.lbl_noofitems.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_noofitems.Name = "lbl_noofitems"
        Me.lbl_noofitems.Size = New System.Drawing.Size(9, 20)
        Me.lbl_noofitems.TabIndex = 122
        Me.lbl_noofitems.Text = "0"
        '
        'LabelControl18
        '
        Me.LabelControl18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl18.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.Appearance.Options.UseForeColor = True
        Me.LabelControl18.Location = New System.Drawing.Point(14, 746)
        Me.LabelControl18.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl18.TabIndex = 121
        Me.LabelControl18.Text = "No. of Items:"
        '
        'lbl_date
        '
        Me.lbl_date.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_date.Appearance.Options.UseFont = True
        Me.lbl_date.Appearance.Options.UseForeColor = True
        Me.lbl_date.Location = New System.Drawing.Point(438, 54)
        Me.lbl_date.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(26, 20)
        Me.lbl_date.TabIndex = 120
        Me.lbl_date.Text = "N/A"
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl17.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.Appearance.Options.UseForeColor = True
        Me.LabelControl17.Location = New System.Drawing.Point(328, 54)
        Me.LabelControl17.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(95, 20)
        Me.LabelControl17.TabIndex = 119
        Me.LabelControl17.Text = "Default Date:"
        '
        'btn_approval
        '
        Me.btn_approval.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approval.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_approval.Appearance.Options.UseFont = True
        Me.btn_approval.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_16x16
        Me.btn_approval.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_approval.Location = New System.Drawing.Point(1402, 28)
        Me.btn_approval.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_approval.Name = "btn_approval"
        Me.btn_approval.Size = New System.Drawing.Size(90, 74)
        Me.btn_approval.TabIndex = 116
        Me.btn_approval.Text = "Submit for" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Approval"
        '
        'txt_pub_notes
        '
        Me.txt_pub_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_pub_notes.Location = New System.Drawing.Point(14, 814)
        Me.txt_pub_notes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pub_notes.Name = "txt_pub_notes"
        Me.txt_pub_notes.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pub_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_notes.Size = New System.Drawing.Size(440, 76)
        Me.txt_pub_notes.TabIndex = 108
        '
        'LabelControl15
        '
        Me.LabelControl15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl15.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.Appearance.Options.UseForeColor = True
        Me.LabelControl15.Location = New System.Drawing.Point(14, 786)
        Me.LabelControl15.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(92, 20)
        Me.LabelControl15.TabIndex = 109
        Me.LabelControl15.Text = "Public Notes:"
        '
        'btn_active_orders
        '
        Me.btn_active_orders.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_active_orders.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.info_16x16
        Me.btn_active_orders.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_active_orders.Location = New System.Drawing.Point(1422, 110)
        Me.btn_active_orders.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_active_orders.Name = "btn_active_orders"
        Me.btn_active_orders.Size = New System.Drawing.Size(147, 31)
        Me.btn_active_orders.TabIndex = 101
        Me.btn_active_orders.Text = "View Active Orders"
        '
        'lbl_withholding_tax_percentage
        '
        Me.lbl_withholding_tax_percentage.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_percentage.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_percentage.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_percentage.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_percentage.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_percentage.Location = New System.Drawing.Point(1192, 823)
        Me.lbl_withholding_tax_percentage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_withholding_tax_percentage.Name = "lbl_withholding_tax_percentage"
        Me.lbl_withholding_tax_percentage.Size = New System.Drawing.Size(85, 17)
        Me.lbl_withholding_tax_percentage.TabIndex = 100
        Me.lbl_withholding_tax_percentage.Text = "0%"
        '
        'lbl_dispose
        '
        Me.lbl_dispose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_dispose.AutoSize = True
        Me.lbl_dispose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_dispose.Location = New System.Drawing.Point(1283, 116)
        Me.lbl_dispose.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_dispose.Name = "lbl_dispose"
        Me.lbl_dispose.Size = New System.Drawing.Size(148, 21)
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
        Me.LabelControl13.Location = New System.Drawing.Point(245, 110)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(128, 20)
        Me.LabelControl13.TabIndex = 96
        Me.LabelControl13.Text = "Lead Time (Days):"
        '
        'txt_lead_time
        '
        Me.txt_lead_time.Location = New System.Drawing.Point(382, 106)
        Me.txt_lead_time.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_lead_time.Name = "txt_lead_time"
        Me.txt_lead_time.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_lead_time.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_lead_time.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_lead_time.Size = New System.Drawing.Size(70, 34)
        Me.txt_lead_time.TabIndex = 1
        '
        'txt_del_address
        '
        Me.txt_del_address.Location = New System.Drawing.Point(608, 151)
        Me.txt_del_address.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_del_address.Name = "txt_del_address"
        Me.txt_del_address.Size = New System.Drawing.Size(335, 69)
        Me.txt_del_address.TabIndex = 4
        '
        'btn_approved
        '
        Me.btn_approved.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.knowledgebasearticle_32x32
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_approved.Location = New System.Drawing.Point(1094, 28)
        Me.btn_approved.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(70, 74)
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
        Me.LabelControl12.Location = New System.Drawing.Point(14, 110)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(98, 20)
        Me.LabelControl12.TabIndex = 85
        Me.LabelControl12.Text = "Terms (Days):"
        '
        'txt_terms
        '
        Me.txt_terms.EditValue = ""
        Me.txt_terms.Location = New System.Drawing.Point(130, 106)
        Me.txt_terms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_terms.Name = "txt_terms"
        Me.txt_terms.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_terms.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_terms.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_terms.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False")
        Me.txt_terms.Properties.MaskSettings.Set("mask", "n0")
        Me.txt_terms.Size = New System.Drawing.Size(100, 34)
        Me.txt_terms.TabIndex = 0
        '
        'btn_send
        '
        Me.btn_send.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_send.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_send.Appearance.Options.UseFont = True
        Me.btn_send.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.assignto_32x32
        Me.btn_send.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_send.Location = New System.Drawing.Point(1248, 28)
        Me.btn_send.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(70, 74)
        Me.btn_send.TabIndex = 11
        Me.btn_send.Text = "Send"
        Me.btn_send.Visible = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_delete.Appearance.Options.UseFont = True
        Me.btn_delete.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.trash_32x32
        Me.btn_delete.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_delete.Location = New System.Drawing.Point(1171, 28)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(70, 74)
        Me.btn_delete.TabIndex = 12
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.Visible = False
        '
        'btn_print
        '
        Me.btn_print.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_32x32
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.Location = New System.Drawing.Point(1325, 28)
        Me.btn_print.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(70, 74)
        Me.btn_print.TabIndex = 9
        Me.btn_print.Text = "Print"
        Me.btn_print.Visible = False
        '
        'btn_save_draft
        '
        Me.btn_save_draft.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save_draft.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_save_draft.Appearance.Options.UseFont = True
        Me.btn_save_draft.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saveto_16x16
        Me.btn_save_draft.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_save_draft.Location = New System.Drawing.Point(1499, 28)
        Me.btn_save_draft.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_save_draft.Name = "btn_save_draft"
        Me.btn_save_draft.Size = New System.Drawing.Size(70, 74)
        Me.btn_save_draft.TabIndex = 10
        Me.btn_save_draft.Text = "Save as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Draft"
        '
        'txt_priv_notes
        '
        Me.txt_priv_notes.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_priv_notes.Location = New System.Drawing.Point(461, 814)
        Me.txt_priv_notes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_priv_notes.Name = "txt_priv_notes"
        Me.txt_priv_notes.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_priv_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_notes.Size = New System.Drawing.Size(440, 76)
        Me.txt_priv_notes.TabIndex = 8
        '
        'LabelControl4
        '
        Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(461, 786)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(98, 20)
        Me.LabelControl4.TabIndex = 67
        Me.LabelControl4.Text = "Private Notes:"
        '
        'cbb_deliver
        '
        Me.cbb_deliver.Location = New System.Drawing.Point(564, 106)
        Me.cbb_deliver.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_deliver.Name = "cbb_deliver"
        Me.cbb_deliver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_deliver.Size = New System.Drawing.Size(379, 34)
        Me.cbb_deliver.TabIndex = 3
        '
        'txt_discount
        '
        Me.txt_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_discount.Location = New System.Drawing.Point(86, 7)
        Me.txt_discount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.DisplayFormat.FormatString = "n2"
        Me.txt_discount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txt_discount.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_discount.Properties.MaskSettings.Set("mask", "n")
        Me.txt_discount.Size = New System.Drawing.Size(68, 34)
        Me.txt_discount.TabIndex = 7
        '
        'LabelControl10
        '
        Me.LabelControl10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(24, 15)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(55, 18)
        Me.LabelControl10.TabIndex = 62
        Me.LabelControl10.Text = "Discount"
        '
        'cbb_discount
        '
        Me.cbb_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_discount.EditValue = ""
        Me.cbb_discount.Location = New System.Drawing.Point(262, 7)
        Me.cbb_discount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_discount.Name = "cbb_discount"
        Me.cbb_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.cbb_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.cbb_discount.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_discount.Properties.Items.AddRange(New Object() {"", "peso", "%"})
        Me.cbb_discount.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_discount.Size = New System.Drawing.Size(93, 34)
        Me.cbb_discount.TabIndex = 6
        '
        'LabelControl9
        '
        Me.LabelControl9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(1192, 854)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(178, 37)
        Me.LabelControl9.TabIndex = 59
        Me.LabelControl9.Text = "Total Amount"
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(130, 148)
        Me.cbb_supplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(323, 34)
        Me.cbb_supplier.TabIndex = 43
        Me.cbb_supplier.TabStop = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 151)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 20)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Supplier:"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(476, 110)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(70, 20)
        Me.LabelControl6.TabIndex = 49
        Me.LabelControl6.Text = "Deliver to:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(476, 151)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(122, 20)
        Me.LabelControl2.TabIndex = 45
        Me.LabelControl2.Text = "Delivery Address:"
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(128, 190)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(323, 34)
        Me.txt_contact.TabIndex = 2
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(14, 193)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(114, 20)
        Me.LabelControl3.TabIndex = 47
        Me.LabelControl3.Text = "Contact Person:"
        '
        'CMS_print
        '
        Me.CMS_print.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.CMS_print.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_strip_purchase_order, Me.CMS_strip_purchase_slip})
        Me.CMS_print.Name = "CMS_print"
        Me.CMS_print.Size = New System.Drawing.Size(179, 52)
        '
        'CMS_strip_purchase_order
        '
        Me.CMS_strip_purchase_order.Name = "CMS_strip_purchase_order"
        Me.CMS_strip_purchase_order.Size = New System.Drawing.Size(178, 24)
        Me.CMS_strip_purchase_order.Text = "Purchase Order"
        '
        'CMS_strip_purchase_slip
        '
        Me.CMS_strip_purchase_slip.Name = "CMS_strip_purchase_slip"
        Me.CMS_strip_purchase_slip.Size = New System.Drawing.Size(178, 24)
        Me.CMS_strip_purchase_slip.Text = "Purchase List"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(132, 31)
        Me.LabelControl7.TabIndex = 125
        Me.LabelControl7.Text = "Purchase ID:"
        '
        'txt_poid
        '
        Me.txt_poid.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.txt_poid.Appearance.Options.UseFont = True
        Me.txt_poid.Location = New System.Drawing.Point(154, 15)
        Me.txt_poid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_poid.Name = "txt_poid"
        Me.txt_poid.Size = New System.Drawing.Size(0, 31)
        Me.txt_poid.TabIndex = 126
        '
        'lbl_status
        '
        Me.lbl_status.Appearance.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_status.Appearance.ForeColor = System.Drawing.Color.IndianRed
        Me.lbl_status.Appearance.Options.UseFont = True
        Me.lbl_status.Appearance.Options.UseForeColor = True
        Me.lbl_status.Location = New System.Drawing.Point(385, 16)
        Me.lbl_status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(44, 31)
        Me.lbl_status.TabIndex = 128
        Me.lbl_status.Text = "N/A"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(328, 23)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(51, 20)
        Me.LabelControl8.TabIndex = 127
        Me.LabelControl8.Text = "Status:"
        '
        'lbl_created_by
        '
        Me.lbl_created_by.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_created_by.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbl_created_by.Appearance.Options.UseFont = True
        Me.lbl_created_by.Appearance.Options.UseForeColor = True
        Me.lbl_created_by.Location = New System.Drawing.Point(107, 54)
        Me.lbl_created_by.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_created_by.Name = "lbl_created_by"
        Me.lbl_created_by.Size = New System.Drawing.Size(26, 20)
        Me.lbl_created_by.TabIndex = 130
        Me.lbl_created_by.Text = "N/A"
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl19.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.Appearance.Options.UseForeColor = True
        Me.LabelControl19.Location = New System.Drawing.Point(14, 54)
        Me.LabelControl19.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(81, 20)
        Me.LabelControl19.TabIndex = 129
        Me.LabelControl19.Text = "Created by:"
        '
        'grid_purchasing
        '
        Me.grid_purchasing.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_purchasing.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_purchasing.Location = New System.Drawing.Point(14, 295)
        Me.grid_purchasing.MainView = Me.grid_purchasing_view
        Me.grid_purchasing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_purchasing.Name = "grid_purchasing"
        Me.grid_purchasing.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_remove_item, Me.ce_bundle})
        Me.grid_purchasing.Size = New System.Drawing.Size(1556, 286)
        Me.grid_purchasing.TabIndex = 131
        Me.grid_purchasing.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_purchasing_view})
        '
        'grid_purchasing_view
        '
        Me.grid_purchasing_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!)
        Me.grid_purchasing_view.Appearance.Row.Options.UseFont = True
        Me.grid_purchasing_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_bundle, Me.col_sku, Me.col_quantity, Me.col_qtyperbox, Me.col_min_order_qty, Me.col_masterbox_qty, Me.col_winmodel, Me.col_supmodel, Me.col_brand, Me.col_sub_category, Me.col_desc, Me.col_cost2, Me.col_total_amount, Me.col_received, Me.col_remain, Me.col_delete, Me.col_base_price, Me.col_discount, Me.col_unit})
        Me.grid_purchasing_view.DetailHeight = 431
        Me.grid_purchasing_view.GridControl = Me.grid_purchasing
        Me.grid_purchasing_view.Name = "grid_purchasing_view"
        '
        'col_bundle
        '
        Me.col_bundle.AppearanceHeader.Options.UseTextOptions = True
        Me.col_bundle.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_bundle.Caption = "Bundle"
        Me.col_bundle.ColumnEdit = Me.ce_bundle
        Me.col_bundle.FieldName = "is_bundle"
        Me.col_bundle.MinWidth = 23
        Me.col_bundle.Name = "col_bundle"
        Me.col_bundle.Visible = True
        Me.col_bundle.VisibleIndex = 0
        Me.col_bundle.Width = 58
        '
        'ce_bundle
        '
        Me.ce_bundle.AutoHeight = False
        Me.ce_bundle.Name = "ce_bundle"
        Me.ce_bundle.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'col_sku
        '
        Me.col_sku.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.col_sku.AppearanceCell.Options.UseBackColor = True
        Me.col_sku.Caption = "SKU"
        Me.col_sku.FieldName = "sku"
        Me.col_sku.MaxWidth = 82
        Me.col_sku.MinWidth = 23
        Me.col_sku.Name = "col_sku"
        Me.col_sku.OptionsColumn.AllowEdit = False
        Me.col_sku.Visible = True
        Me.col_sku.VisibleIndex = 1
        Me.col_sku.Width = 78
        '
        'col_quantity
        '
        Me.col_quantity.Caption = "Quantity"
        Me.col_quantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_quantity.FieldName = "qty"
        Me.col_quantity.MaxWidth = 70
        Me.col_quantity.MinWidth = 23
        Me.col_quantity.Name = "col_quantity"
        Me.col_quantity.UnboundDataType = GetType(Decimal)
        Me.col_quantity.Visible = True
        Me.col_quantity.VisibleIndex = 2
        Me.col_quantity.Width = 65
        '
        'col_qtyperbox
        '
        Me.col_qtyperbox.Caption = "I.B. Qty."
        Me.col_qtyperbox.FieldName = "qty_per_box"
        Me.col_qtyperbox.MaxWidth = 70
        Me.col_qtyperbox.MinWidth = 23
        Me.col_qtyperbox.Name = "col_qtyperbox"
        Me.col_qtyperbox.OptionsColumn.AllowEdit = False
        Me.col_qtyperbox.Visible = True
        Me.col_qtyperbox.VisibleIndex = 4
        Me.col_qtyperbox.Width = 65
        '
        'col_min_order_qty
        '
        Me.col_min_order_qty.Caption = "M.O. Qty."
        Me.col_min_order_qty.FieldName = "min_order_qty"
        Me.col_min_order_qty.MaxWidth = 78
        Me.col_min_order_qty.MinWidth = 23
        Me.col_min_order_qty.Name = "col_min_order_qty"
        Me.col_min_order_qty.OptionsColumn.AllowEdit = False
        Me.col_min_order_qty.Visible = True
        Me.col_min_order_qty.VisibleIndex = 6
        '
        'col_masterbox_qty
        '
        Me.col_masterbox_qty.Caption = "M.B. Qty."
        Me.col_masterbox_qty.FieldName = "masterbox_qty"
        Me.col_masterbox_qty.MaxWidth = 76
        Me.col_masterbox_qty.MinWidth = 23
        Me.col_masterbox_qty.Name = "col_masterbox_qty"
        Me.col_masterbox_qty.OptionsColumn.AllowEdit = False
        Me.col_masterbox_qty.Visible = True
        Me.col_masterbox_qty.VisibleIndex = 5
        Me.col_masterbox_qty.Width = 65
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.OptionsColumn.ReadOnly = True
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 7
        Me.col_winmodel.Width = 101
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.OptionsColumn.ReadOnly = True
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 8
        Me.col_supmodel.Width = 101
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.MinWidth = 23
        Me.col_brand.Name = "col_brand"
        Me.col_brand.OptionsColumn.ReadOnly = True
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 9
        Me.col_brand.Width = 101
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.MinWidth = 23
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.OptionsColumn.ReadOnly = True
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 10
        Me.col_sub_category.Width = 101
        '
        'col_desc
        '
        Me.col_desc.Caption = "Description"
        Me.col_desc.FieldName = "description"
        Me.col_desc.MinWidth = 23
        Me.col_desc.Name = "col_desc"
        Me.col_desc.Visible = True
        Me.col_desc.VisibleIndex = 11
        Me.col_desc.Width = 101
        '
        'col_cost2
        '
        Me.col_cost2.Caption = "Cost"
        Me.col_cost2.DisplayFormat.FormatString = "n2"
        Me.col_cost2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost2.FieldName = "cost"
        Me.col_cost2.MaxWidth = 105
        Me.col_cost2.MinWidth = 23
        Me.col_cost2.Name = "col_cost2"
        Me.col_cost2.Visible = True
        Me.col_cost2.VisibleIndex = 14
        Me.col_cost2.Width = 94
        '
        'col_total_amount
        '
        Me.col_total_amount.Caption = "Total Amount"
        Me.col_total_amount.DisplayFormat.FormatString = "n2"
        Me.col_total_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total_amount.FieldName = "total"
        Me.col_total_amount.MaxWidth = 105
        Me.col_total_amount.MinWidth = 23
        Me.col_total_amount.Name = "col_total_amount"
        Me.col_total_amount.OptionsColumn.ReadOnly = True
        Me.col_total_amount.Visible = True
        Me.col_total_amount.VisibleIndex = 15
        Me.col_total_amount.Width = 97
        '
        'col_received
        '
        Me.col_received.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_received.AppearanceCell.Options.UseBackColor = True
        Me.col_received.Caption = "Received"
        Me.col_received.FieldName = "total_received"
        Me.col_received.MaxWidth = 76
        Me.col_received.MinWidth = 23
        Me.col_received.Name = "col_received"
        Me.col_received.OptionsColumn.AllowEdit = False
        Me.col_received.Visible = True
        Me.col_received.VisibleIndex = 16
        Me.col_received.Width = 76
        '
        'col_remain
        '
        Me.col_remain.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.col_remain.AppearanceCell.Options.UseBackColor = True
        Me.col_remain.Caption = "Remaining"
        Me.col_remain.FieldName = "remaining"
        Me.col_remain.MaxWidth = 76
        Me.col_remain.MinWidth = 23
        Me.col_remain.Name = "col_remain"
        Me.col_remain.OptionsColumn.AllowEdit = False
        Me.col_remain.Visible = True
        Me.col_remain.VisibleIndex = 17
        Me.col_remain.Width = 76
        '
        'col_delete
        '
        Me.col_delete.ColumnEdit = Me.btn_remove_item
        Me.col_delete.MaxWidth = 47
        Me.col_delete.MinWidth = 23
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 18
        Me.col_delete.Width = 47
        '
        'btn_remove_item
        '
        Me.btn_remove_item.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_removecircled
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_remove_item.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_remove_item.Name = "btn_remove_item"
        Me.btn_remove_item.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_base_price
        '
        Me.col_base_price.Caption = "Base Price"
        Me.col_base_price.DisplayFormat.FormatString = "n2"
        Me.col_base_price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_base_price.FieldName = "base_price"
        Me.col_base_price.MaxWidth = 105
        Me.col_base_price.MinWidth = 23
        Me.col_base_price.Name = "col_base_price"
        Me.col_base_price.Visible = True
        Me.col_base_price.VisibleIndex = 12
        Me.col_base_price.Width = 84
        '
        'col_discount
        '
        Me.col_discount.Caption = "DISC."
        Me.col_discount.DisplayFormat.FormatString = "p0"
        Me.col_discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_discount.FieldName = "discount"
        Me.col_discount.MaxWidth = 93
        Me.col_discount.MinWidth = 23
        Me.col_discount.Name = "col_discount"
        Me.col_discount.Visible = True
        Me.col_discount.VisibleIndex = 13
        Me.col_discount.Width = 89
        '
        'col_unit
        '
        Me.col_unit.Caption = "Unit"
        Me.col_unit.FieldName = "unit"
        Me.col_unit.MaxWidth = 58
        Me.col_unit.MinWidth = 23
        Me.col_unit.Name = "col_unit"
        Me.col_unit.OptionsColumn.AllowEdit = False
        Me.col_unit.Visible = True
        Me.col_unit.VisibleIndex = 3
        Me.col_unit.Width = 44
        '
        'cbb_search
        '
        Me.cbb_search.Location = New System.Drawing.Point(112, 252)
        Me.cbb_search.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_search.Name = "cbb_search"
        Me.cbb_search.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_search.Size = New System.Drawing.Size(265, 34)
        Me.cbb_search.TabIndex = 133
        Me.cbb_search.ToolTip = "Press Enter to add item"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(14, 260)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(91, 20)
        Me.LabelControl5.TabIndex = 134
        Me.LabelControl5.Text = "Search Item:"
        '
        'btn_add
        '
        Me.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_add.Appearance.Options.UseBackColor = True
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_add.Location = New System.Drawing.Point(383, 252)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(57, 36)
        Me.btn_add.TabIndex = 135
        Me.btn_add.Text = "Add"
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Appearance.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total.Appearance.Options.UseFont = True
        Me.lbl_total.Appearance.Options.UseTextOptions = True
        Me.lbl_total.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total.Location = New System.Drawing.Point(16, 209)
        Me.lbl_total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(194, 37)
        Me.lbl_total.TabIndex = 136
        Me.lbl_total.Text = "₱0.00"
        '
        'btn_import
        '
        Me.btn_import.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_import.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_import.Appearance.Options.UseFont = True
        Me.btn_import.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.up_32x32
        Me.btn_import.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_import.Location = New System.Drawing.Point(1017, 28)
        Me.btn_import.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(70, 74)
        Me.btn_import.TabIndex = 137
        Me.btn_import.Text = "Import"
        '
        'PanelControl2
        '
        Me.PanelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PanelControl2.Controls.Add(Me.LabelControl16)
        Me.PanelControl2.Controls.Add(Me.cbb_discount)
        Me.PanelControl2.Controls.Add(Me.LabelControl10)
        Me.PanelControl2.Controls.Add(Me.txt_discount)
        Me.PanelControl2.Location = New System.Drawing.Point(1208, 588)
        Me.PanelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl2.Name = "PanelControl2"
        Me.PanelControl2.Size = New System.Drawing.Size(362, 49)
        Me.PanelControl2.TabIndex = 139
        '
        'LabelControl16
        '
        Me.LabelControl16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.Location = New System.Drawing.Point(163, 16)
        Me.LabelControl16.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(94, 18)
        Me.LabelControl16.TabIndex = 63
        Me.LabelControl16.Text = "Discount Type"
        '
        'LabelControl41
        '
        Me.LabelControl41.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl41.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl41.Appearance.Options.UseFont = True
        Me.LabelControl41.Appearance.Options.UseTextOptions = True
        Me.LabelControl41.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl41.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl41.Location = New System.Drawing.Point(1192, 704)
        Me.LabelControl41.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl41.Name = "LabelControl41"
        Me.LabelControl41.Size = New System.Drawing.Size(160, 31)
        Me.LabelControl41.TabIndex = 142
        Me.LabelControl41.Text = "Total Purchase"
        '
        'LabelControl37
        '
        Me.LabelControl37.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl37.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl37.Appearance.Options.UseFont = True
        Me.LabelControl37.Appearance.Options.UseTextOptions = True
        Me.LabelControl37.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl37.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl37.Location = New System.Drawing.Point(1203, 673)
        Me.LabelControl37.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl37.Name = "LabelControl37"
        Me.LabelControl37.Size = New System.Drawing.Size(147, 21)
        Me.LabelControl37.TabIndex = 141
        Me.LabelControl37.Text = "Discount"
        '
        'LabelControl20
        '
        Me.LabelControl20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.Appearance.Options.UseTextOptions = True
        Me.LabelControl20.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl20.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl20.Location = New System.Drawing.Point(1190, 645)
        Me.LabelControl20.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(160, 26)
        Me.LabelControl20.TabIndex = 140
        Me.LabelControl20.Text = "Gross Purchase"
        '
        'LabelControl43
        '
        Me.LabelControl43.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl43.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl43.Appearance.Options.UseFont = True
        Me.LabelControl43.Appearance.Options.UseTextOptions = True
        Me.LabelControl43.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl43.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl43.Location = New System.Drawing.Point(1211, 735)
        Me.LabelControl43.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl43.Name = "LabelControl43"
        Me.LabelControl43.Size = New System.Drawing.Size(141, 18)
        Me.LabelControl43.TabIndex = 144
        Me.LabelControl43.Text = "Amount Net of VAT"
        '
        'LabelControl21
        '
        Me.LabelControl21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.Appearance.Options.UseTextOptions = True
        Me.LabelControl21.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl21.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl21.Location = New System.Drawing.Point(1211, 761)
        Me.LabelControl21.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(141, 17)
        Me.LabelControl21.TabIndex = 143
        Me.LabelControl21.Text = "VAT"
        '
        'LabelControl42
        '
        Me.LabelControl42.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl42.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LabelControl42.Appearance.Options.UseFont = True
        Me.LabelControl42.Appearance.Options.UseTextOptions = True
        Me.LabelControl42.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl42.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl42.Location = New System.Drawing.Point(1191, 794)
        Me.LabelControl42.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl42.Name = "LabelControl42"
        Me.LabelControl42.Size = New System.Drawing.Size(160, 20)
        Me.LabelControl42.TabIndex = 146
        Me.LabelControl42.Text = "Total Cost"
        '
        'LabelControl22
        '
        Me.LabelControl22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.Appearance.Options.UseTextOptions = True
        Me.LabelControl22.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.LabelControl22.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.LabelControl22.Location = New System.Drawing.Point(1279, 821)
        Me.LabelControl22.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(71, 21)
        Me.LabelControl22.TabIndex = 145
        Me.LabelControl22.Text = "Less: EWT"
        '
        'panel_computation
        '
        Me.panel_computation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_computation.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.panel_computation.Controls.Add(Me.lbl_total_purchase_due)
        Me.panel_computation.Controls.Add(Me.lbl_vat_excl_sales)
        Me.panel_computation.Controls.Add(Me.lbl_net_purchase)
        Me.panel_computation.Controls.Add(Me.lbl_discount)
        Me.panel_computation.Controls.Add(Me.lbl_gross_purchase)
        Me.panel_computation.Controls.Add(Me.lbl_vat_amount)
        Me.panel_computation.Controls.Add(Me.lbl_withholding_tax_amount)
        Me.panel_computation.Controls.Add(Me.lbl_delivery_fee)
        Me.panel_computation.Controls.Add(Me.SeparatorControl1)
        Me.panel_computation.Controls.Add(Me.SeparatorControl4)
        Me.panel_computation.Controls.Add(Me.lbl_total)
        Me.panel_computation.Location = New System.Drawing.Point(1359, 645)
        Me.panel_computation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panel_computation.Name = "panel_computation"
        Me.panel_computation.Size = New System.Drawing.Size(214, 258)
        Me.panel_computation.TabIndex = 147
        '
        'lbl_total_purchase_due
        '
        Me.lbl_total_purchase_due.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total_purchase_due.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_total_purchase_due.Appearance.Options.UseFont = True
        Me.lbl_total_purchase_due.Appearance.Options.UseTextOptions = True
        Me.lbl_total_purchase_due.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_total_purchase_due.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_total_purchase_due.Location = New System.Drawing.Point(44, 144)
        Me.lbl_total_purchase_due.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_total_purchase_due.Name = "lbl_total_purchase_due"
        Me.lbl_total_purchase_due.Size = New System.Drawing.Size(160, 30)
        Me.lbl_total_purchase_due.TabIndex = 18
        Me.lbl_total_purchase_due.Text = "₱0.00"
        '
        'lbl_vat_excl_sales
        '
        Me.lbl_vat_excl_sales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_vat_excl_sales.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_vat_excl_sales.Appearance.Options.UseFont = True
        Me.lbl_vat_excl_sales.Appearance.Options.UseTextOptions = True
        Me.lbl_vat_excl_sales.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vat_excl_sales.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_vat_excl_sales.Location = New System.Drawing.Point(44, 85)
        Me.lbl_vat_excl_sales.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_vat_excl_sales.Name = "lbl_vat_excl_sales"
        Me.lbl_vat_excl_sales.Size = New System.Drawing.Size(160, 27)
        Me.lbl_vat_excl_sales.TabIndex = 14
        '
        'lbl_net_purchase
        '
        Me.lbl_net_purchase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_net_purchase.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_net_purchase.Appearance.Options.UseFont = True
        Me.lbl_net_purchase.Appearance.Options.UseTextOptions = True
        Me.lbl_net_purchase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_net_purchase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_net_purchase.Location = New System.Drawing.Point(44, 62)
        Me.lbl_net_purchase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_net_purchase.Name = "lbl_net_purchase"
        Me.lbl_net_purchase.Size = New System.Drawing.Size(160, 27)
        Me.lbl_net_purchase.TabIndex = 12
        Me.lbl_net_purchase.Text = "₱0.00"
        '
        'lbl_discount
        '
        Me.lbl_discount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_discount.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_discount.Appearance.Options.UseFont = True
        Me.lbl_discount.Appearance.Options.UseTextOptions = True
        Me.lbl_discount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_discount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_discount.Location = New System.Drawing.Point(44, 27)
        Me.lbl_discount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_discount.Name = "lbl_discount"
        Me.lbl_discount.Size = New System.Drawing.Size(160, 21)
        Me.lbl_discount.TabIndex = 11
        Me.lbl_discount.Text = "₱0.00"
        '
        'lbl_gross_purchase
        '
        Me.lbl_gross_purchase.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_gross_purchase.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_gross_purchase.Appearance.Options.UseFont = True
        Me.lbl_gross_purchase.Appearance.Options.UseTextOptions = True
        Me.lbl_gross_purchase.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_gross_purchase.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_gross_purchase.Location = New System.Drawing.Point(44, 2)
        Me.lbl_gross_purchase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_gross_purchase.Name = "lbl_gross_purchase"
        Me.lbl_gross_purchase.Size = New System.Drawing.Size(160, 25)
        Me.lbl_gross_purchase.TabIndex = 5
        Me.lbl_gross_purchase.Text = "₱0.00"
        '
        'lbl_vat_amount
        '
        Me.lbl_vat_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_vat_amount.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_vat_amount.Appearance.Options.UseFont = True
        Me.lbl_vat_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_vat_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_vat_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_vat_amount.Location = New System.Drawing.Point(44, 110)
        Me.lbl_vat_amount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_vat_amount.Name = "lbl_vat_amount"
        Me.lbl_vat_amount.Size = New System.Drawing.Size(160, 27)
        Me.lbl_vat_amount.TabIndex = 6
        '
        'lbl_withholding_tax_amount
        '
        Me.lbl_withholding_tax_amount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_withholding_tax_amount.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_withholding_tax_amount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.lbl_withholding_tax_amount.Appearance.Options.UseFont = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseForeColor = True
        Me.lbl_withholding_tax_amount.Appearance.Options.UseTextOptions = True
        Me.lbl_withholding_tax_amount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_withholding_tax_amount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_withholding_tax_amount.Location = New System.Drawing.Point(44, 169)
        Me.lbl_withholding_tax_amount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_withholding_tax_amount.Name = "lbl_withholding_tax_amount"
        Me.lbl_withholding_tax_amount.Size = New System.Drawing.Size(160, 27)
        Me.lbl_withholding_tax_amount.TabIndex = 7
        '
        'lbl_delivery_fee
        '
        Me.lbl_delivery_fee.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_delivery_fee.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_delivery_fee.Appearance.Options.UseFont = True
        Me.lbl_delivery_fee.Appearance.Options.UseTextOptions = True
        Me.lbl_delivery_fee.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.lbl_delivery_fee.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_delivery_fee.Location = New System.Drawing.Point(44, 198)
        Me.lbl_delivery_fee.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_delivery_fee.Name = "lbl_delivery_fee"
        Me.lbl_delivery_fee.Size = New System.Drawing.Size(160, 21)
        Me.lbl_delivery_fee.TabIndex = 8
        '
        'SeparatorControl1
        '
        Me.SeparatorControl1.Location = New System.Drawing.Point(4, 46)
        Me.SeparatorControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SeparatorControl1.Name = "SeparatorControl1"
        Me.SeparatorControl1.Padding = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.SeparatorControl1.Size = New System.Drawing.Size(208, 28)
        Me.SeparatorControl1.TabIndex = 13
        '
        'SeparatorControl4
        '
        Me.SeparatorControl4.Location = New System.Drawing.Point(2, 119)
        Me.SeparatorControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SeparatorControl4.Name = "SeparatorControl4"
        Me.SeparatorControl4.Padding = New System.Windows.Forms.Padding(10, 11, 10, 11)
        Me.SeparatorControl4.Size = New System.Drawing.Size(208, 42)
        Me.SeparatorControl4.TabIndex = 19
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PanelControl1.Controls.Add(Me.LabelControl23)
        Me.PanelControl1.Controls.Add(Me.cb_ewt_tax_applied)
        Me.PanelControl1.Controls.Add(Me.cb_vatable)
        Me.PanelControl1.Controls.Add(Me.cb_nonvatable)
        Me.PanelControl1.Controls.Add(Me.LabelControl14)
        Me.PanelControl1.Location = New System.Drawing.Point(14, 588)
        Me.PanelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(568, 49)
        Me.PanelControl1.TabIndex = 148
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(424, 16)
        Me.LabelControl23.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(37, 18)
        Me.LabelControl23.TabIndex = 151
        Me.LabelControl23.Text = "EWT:"
        '
        'cb_ewt_tax_applied
        '
        Me.cb_ewt_tax_applied.Location = New System.Drawing.Point(476, 12)
        Me.cb_ewt_tax_applied.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_ewt_tax_applied.Name = "cb_ewt_tax_applied"
        Me.cb_ewt_tax_applied.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cb_ewt_tax_applied.Properties.Appearance.Options.UseFont = True
        Me.cb_ewt_tax_applied.Properties.Caption = "Apply"
        Me.cb_ewt_tax_applied.Size = New System.Drawing.Size(69, 26)
        Me.cb_ewt_tax_applied.TabIndex = 151
        '
        'cb_vatable
        '
        Me.cb_vatable.Location = New System.Drawing.Point(274, 12)
        Me.cb_vatable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_vatable.Name = "cb_vatable"
        Me.cb_vatable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cb_vatable.Properties.Appearance.Options.UseFont = True
        Me.cb_vatable.Properties.Caption = "VATable Sales"
        Me.cb_vatable.Size = New System.Drawing.Size(134, 26)
        Me.cb_vatable.TabIndex = 150
        '
        'cb_nonvatable
        '
        Me.cb_nonvatable.EditValue = True
        Me.cb_nonvatable.Location = New System.Drawing.Point(102, 11)
        Me.cb_nonvatable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cb_nonvatable.Name = "cb_nonvatable"
        Me.cb_nonvatable.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.cb_nonvatable.Properties.Appearance.Options.UseFont = True
        Me.cb_nonvatable.Properties.Caption = "NON-VATable Sales"
        Me.cb_nonvatable.Size = New System.Drawing.Size(169, 26)
        Me.cb_nonvatable.TabIndex = 149
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(8, 15)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(70, 18)
        Me.LabelControl14.TabIndex = 63
        Me.LabelControl14.Text = "Tax Type:"
        '
        'btn_recall
        '
        Me.btn_recall.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_recall.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.btn_recall.Appearance.Options.UseFont = True
        Me.btn_recall.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_recall.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_recall.Location = New System.Drawing.Point(1171, 110)
        Me.btn_recall.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_recall.Name = "btn_recall"
        Me.btn_recall.Size = New System.Drawing.Size(70, 74)
        Me.btn_recall.TabIndex = 149
        Me.btn_recall.Text = "Recall"
        '
        'ProgressPanel
        '
        Me.ProgressPanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressPanel.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.ProgressPanel.Appearance.Options.UseBackColor = True
        Me.ProgressPanel.Caption = "Please Wait"
        Me.ProgressPanel.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.ProgressPanel.Description = "Importing Orders ..."
        Me.ProgressPanel.Location = New System.Drawing.Point(1349, 218)
        Me.ProgressPanel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressPanel.Name = "ProgressPanel"
        Me.ProgressPanel.Padding = New System.Windows.Forms.Padding(12, 12, 12, 12)
        Me.ProgressPanel.Size = New System.Drawing.Size(220, 70)
        Me.ProgressPanel.TabIndex = 150
        Me.ProgressPanel.Text = "ProgressPanel1"
        Me.ProgressPanel.Visible = False
        Me.ProgressPanel.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Ring
        '
        'frm_purchaseorder_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1583, 903)
        Me.Controls.Add(Me.ProgressPanel)
        Me.Controls.Add(Me.btn_recall)
        Me.Controls.Add(Me.PanelControl1)
        Me.Controls.Add(Me.panel_computation)
        Me.Controls.Add(Me.LabelControl42)
        Me.Controls.Add(Me.LabelControl22)
        Me.Controls.Add(Me.LabelControl43)
        Me.Controls.Add(Me.LabelControl21)
        Me.Controls.Add(Me.LabelControl41)
        Me.Controls.Add(Me.LabelControl37)
        Me.Controls.Add(Me.LabelControl20)
        Me.Controls.Add(Me.PanelControl2)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.cbb_search)
        Me.Controls.Add(Me.grid_purchasing)
        Me.Controls.Add(Me.lbl_created_by)
        Me.Controls.Add(Me.LabelControl19)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.txt_poid)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.lbl_noofitems)
        Me.Controls.Add(Me.LabelControl18)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.LabelControl17)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.btn_approval)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txt_pub_notes)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl15)
        Me.Controls.Add(Me.cbb_supplier)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.btn_active_orders)
        Me.Controls.Add(Me.lbl_withholding_tax_percentage)
        Me.Controls.Add(Me.lbl_dispose)
        Me.Controls.Add(Me.cbb_deliver)
        Me.Controls.Add(Me.LabelControl13)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_lead_time)
        Me.Controls.Add(Me.txt_priv_notes)
        Me.Controls.Add(Me.txt_del_address)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.btn_save_draft)
        Me.Controls.Add(Me.LabelControl12)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.txt_terms)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_send)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_purchaseorder_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Purchase Order"
        CType(Me.txt_pub_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_lead_time.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_del_address.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_terms.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_priv_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_deliver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CMS_print.ResumeLayout(False)
        CType(Me.grid_purchasing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_purchasing_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ce_bundle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_remove_item, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl2.ResumeLayout(False)
        Me.PanelControl2.PerformLayout()
        CType(Me.panel_computation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_computation.ResumeLayout(False)
        CType(Me.SeparatorControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SeparatorControl4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        Me.PanelControl1.PerformLayout()
        CType(Me.cb_ewt_tax_applied.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_vatable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cb_nonvatable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_deliver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_discount As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
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
    Friend WithEvents btn_active_orders As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pub_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_priv_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_approval As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_save_draft As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_date As LabelControl
    Friend WithEvents LabelControl17 As LabelControl
    Friend WithEvents lbl_noofitems As LabelControl
    Friend WithEvents LabelControl18 As LabelControl
    Friend WithEvents CMS_print As ContextMenuStrip
    Friend WithEvents CMS_strip_purchase_order As ToolStripMenuItem
    Friend WithEvents CMS_strip_purchase_slip As ToolStripMenuItem
    Friend WithEvents LabelControl7 As LabelControl
    Friend WithEvents txt_poid As LabelControl
    Friend WithEvents lbl_status As LabelControl
    Friend WithEvents LabelControl8 As LabelControl
    Friend WithEvents lbl_created_by As LabelControl
    Friend WithEvents LabelControl19 As LabelControl
    Friend WithEvents grid_purchasing As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_purchasing_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_sku As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_quantity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qtyperbox As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_min_order_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_desc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cost2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_received As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_remain As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_search As ComboBoxEdit
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents btn_add As SimpleButton
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_remove_item As Repository.RepositoryItemButtonEdit
    Friend WithEvents lbl_total As LabelControl
    Friend WithEvents col_masterbox_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_import As SimpleButton
    Friend WithEvents col_base_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_discount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PanelControl2 As PanelControl
    Friend WithEvents LabelControl16 As LabelControl
    Friend WithEvents LabelControl41 As LabelControl
    Friend WithEvents LabelControl37 As LabelControl
    Friend WithEvents LabelControl20 As LabelControl
    Friend WithEvents LabelControl43 As LabelControl
    Friend WithEvents LabelControl21 As LabelControl
    Friend WithEvents LabelControl42 As LabelControl
    Friend WithEvents LabelControl22 As LabelControl
    Friend WithEvents panel_computation As PanelControl
    Friend WithEvents lbl_total_purchase_due As LabelControl
    Friend WithEvents lbl_vat_excl_sales As LabelControl
    Friend WithEvents lbl_net_purchase As LabelControl
    Friend WithEvents lbl_discount As LabelControl
    Friend WithEvents lbl_gross_purchase As LabelControl
    Friend WithEvents lbl_vat_amount As LabelControl
    Friend WithEvents lbl_withholding_tax_amount As LabelControl
    Friend WithEvents lbl_delivery_fee As LabelControl
    Friend WithEvents SeparatorControl1 As SeparatorControl
    Friend WithEvents SeparatorControl4 As SeparatorControl
    Friend WithEvents PanelControl1 As PanelControl
    Friend WithEvents LabelControl14 As LabelControl
    Friend WithEvents cb_nonvatable As CheckEdit
    Friend WithEvents cb_vatable As CheckEdit
    Friend WithEvents cb_ewt_tax_applied As CheckEdit
    Friend WithEvents LabelControl23 As LabelControl
    Friend WithEvents btn_recall As SimpleButton
    Friend WithEvents ProgressPanel As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents col_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bundle As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ce_bundle As Repository.RepositoryItemCheckEdit
End Class
