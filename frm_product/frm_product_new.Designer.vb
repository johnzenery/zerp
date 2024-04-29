Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.DXErrorProvider
Imports DevExpress.XtraEditors.Mask
Imports DevExpress.XtraEditors.Repository
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySqlConnector
Imports Renci.SshNet
Imports Renci.SshNet.Sftp
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Globalization
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_product_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_new))
        Me.panel_addunit = New Guna.UI.WinForms.GunaPanel()
        Me.GunaGroupBox7 = New Guna.UI.WinForms.GunaGroupBox()
        Me.btn_camera = New DevExpress.XtraEditors.SimpleButton()
        Me.pb_new_unit = New DevExpress.XtraEditors.PictureEdit()
        Me.GunaGroupBox6 = New Guna.UI.WinForms.GunaGroupBox()
        Me.txt_warranty_period = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl21 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_warranty_coverage = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl19 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaGroupBox5 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_supmodel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.GunaGroupBox4 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelControl32 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_qty_per_box = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl18 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_warning_stock = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl17 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_ideal_stock = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl25 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_stock_duration = New DevExpress.XtraEditors.TextEdit()
        Me.GunaGroupBox3 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelControl15 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_length = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_width = New DevExpress.XtraEditors.TextEdit()
        Me.txt_height = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_weight = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl20 = New DevExpress.XtraEditors.LabelControl()
        Me.GunaGroupBox2 = New Guna.UI.WinForms.GunaGroupBox()
        Me.txt_vip_price = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl29 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_dealer_price = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl28 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl24 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_baseprice = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl26 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_srp = New DevExpress.XtraEditors.TextEdit()
        Me.GunaGroupBox1 = New Guna.UI.WinForms.GunaGroupBox()
        Me.LabelControl31 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_more_description = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_pid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl30 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_winmodel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_description = New DevExpress.XtraEditors.MemoEdit()
        Me.switch_serialize = New Guna.UI.WinForms.GunaGoogleSwitch()
        Me.LabelControl16 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl22 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cautions = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_maincategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_subcategory = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_brand = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tags = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_barcode = New DevExpress.XtraEditors.TextEdit()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.LabelControl27 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_status = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.ErrorNotif = New DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(Me.components)
        Me.panel_top = New Guna.UI.WinForms.GunaPanel()
        Me.breadcrumb = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl23 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.txt_title = New Guna.UI.WinForms.GunaLabel()
        Me.panel_addunit.SuspendLayout()
        Me.GunaGroupBox7.SuspendLayout()
        CType(Me.pb_new_unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox6.SuspendLayout()
        CType(Me.txt_warranty_period.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_warranty_coverage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox5.SuspendLayout()
        CType(Me.txt_supmodel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox4.SuspendLayout()
        CType(Me.txt_qty_per_box.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_warning_stock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ideal_stock.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_stock_duration.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox3.SuspendLayout()
        CType(Me.txt_length.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_width.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_height.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_weight.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox2.SuspendLayout()
        CType(Me.txt_vip_price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_dealer_price.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_baseprice.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_srp.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGroupBox1.SuspendLayout()
        CType(Me.txt_more_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_winmodel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cautions.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_maincategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_subcategory.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_brand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tags.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_barcode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel2.SuspendLayout()
        CType(Me.cbb_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.ErrorNotif, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel_top.SuspendLayout()
        Me.breadcrumb.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_addunit
        '
        Me.panel_addunit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.panel_addunit.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox7)
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox6)
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox5)
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox4)
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox3)
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox2)
        Me.panel_addunit.Controls.Add(Me.GunaGroupBox1)
        Me.panel_addunit.Controls.Add(Me.GunaPanel2)
        Me.panel_addunit.Location = New System.Drawing.Point(31, 20)
        Me.panel_addunit.Name = "panel_addunit"
        Me.panel_addunit.Size = New System.Drawing.Size(1138, 741)
        Me.panel_addunit.TabIndex = 5
        '
        'GunaGroupBox7
        '
        Me.GunaGroupBox7.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox7.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox7.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox7.BorderSize = 1
        Me.GunaGroupBox7.Controls.Add(Me.btn_camera)
        Me.GunaGroupBox7.Controls.Add(Me.pb_new_unit)
        Me.GunaGroupBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GunaGroupBox7.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox7.Location = New System.Drawing.Point(804, 18)
        Me.GunaGroupBox7.Name = "GunaGroupBox7"
        Me.GunaGroupBox7.Size = New System.Drawing.Size(321, 410)
        Me.GunaGroupBox7.TabIndex = 73
        Me.GunaGroupBox7.Text = "Product Image"
        Me.GunaGroupBox7.TextLocation = New System.Drawing.Point(10, 8)
        '
        'btn_camera
        '
        Me.btn_camera.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_camera.Appearance.Options.UseFont = True
        Me.btn_camera.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_camera.ImageOptions.ImageToTextIndent = 7
        Me.btn_camera.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.electronics_photo
        Me.btn_camera.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_camera.Location = New System.Drawing.Point(36, 332)
        Me.btn_camera.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_camera.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_camera.Name = "btn_camera"
        Me.btn_camera.Size = New System.Drawing.Size(250, 43)
        Me.btn_camera.TabIndex = 27
        Me.btn_camera.Text = "Select Product Image"
        '
        'pb_new_unit
        '
        Me.pb_new_unit.Location = New System.Drawing.Point(36, 61)
        Me.pb_new_unit.Name = "pb_new_unit"
        Me.pb_new_unit.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.pb_new_unit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.pb_new_unit.Size = New System.Drawing.Size(250, 250)
        Me.pb_new_unit.TabIndex = 0
        '
        'GunaGroupBox6
        '
        Me.GunaGroupBox6.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox6.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox6.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox6.BorderSize = 1
        Me.GunaGroupBox6.Controls.Add(Me.txt_warranty_period)
        Me.GunaGroupBox6.Controls.Add(Me.LabelControl21)
        Me.GunaGroupBox6.Controls.Add(Me.txt_warranty_coverage)
        Me.GunaGroupBox6.Controls.Add(Me.LabelControl19)
        Me.GunaGroupBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GunaGroupBox6.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox6.Location = New System.Drawing.Point(12, 500)
        Me.GunaGroupBox6.Name = "GunaGroupBox6"
        Me.GunaGroupBox6.Size = New System.Drawing.Size(438, 151)
        Me.GunaGroupBox6.TabIndex = 70
        Me.GunaGroupBox6.Text = "Warranty Information"
        Me.GunaGroupBox6.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txt_warranty_period
        '
        Me.txt_warranty_period.Location = New System.Drawing.Point(184, 49)
        Me.txt_warranty_period.Name = "txt_warranty_period"
        Me.txt_warranty_period.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_warranty_period.Properties.Appearance.Options.UseFont = True
        Me.txt_warranty_period.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_warranty_period.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_warranty_period.Size = New System.Drawing.Size(53, 22)
        Me.txt_warranty_period.TabIndex = 25
        '
        'LabelControl21
        '
        Me.LabelControl21.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl21.Appearance.Options.UseFont = True
        Me.LabelControl21.LineVisible = True
        Me.LabelControl21.Location = New System.Drawing.Point(15, 52)
        Me.LabelControl21.Name = "LabelControl21"
        Me.LabelControl21.Size = New System.Drawing.Size(154, 16)
        Me.LabelControl21.TabIndex = 67
        Me.LabelControl21.Text = "Warranty Period (Months):"
        '
        'txt_warranty_coverage
        '
        Me.txt_warranty_coverage.Location = New System.Drawing.Point(155, 79)
        Me.txt_warranty_coverage.Name = "txt_warranty_coverage"
        Me.txt_warranty_coverage.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_warranty_coverage.Properties.Appearance.Options.UseFont = True
        Me.txt_warranty_coverage.Size = New System.Drawing.Size(261, 56)
        Me.txt_warranty_coverage.TabIndex = 26
        '
        'LabelControl19
        '
        Me.LabelControl19.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl19.Appearance.Options.UseFont = True
        Me.LabelControl19.LineVisible = True
        Me.LabelControl19.Location = New System.Drawing.Point(21, 76)
        Me.LabelControl19.Name = "LabelControl19"
        Me.LabelControl19.Size = New System.Drawing.Size(128, 16)
        Me.LabelControl19.TabIndex = 64
        Me.LabelControl19.Text = "Warranty Description:"
        '
        'GunaGroupBox5
        '
        Me.GunaGroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox5.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox5.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox5.BorderSize = 1
        Me.GunaGroupBox5.Controls.Add(Me.LabelControl2)
        Me.GunaGroupBox5.Controls.Add(Me.txt_supmodel)
        Me.GunaGroupBox5.Controls.Add(Me.LabelControl3)
        Me.GunaGroupBox5.Controls.Add(Me.cbb_supplier)
        Me.GunaGroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GunaGroupBox5.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox5.Location = New System.Drawing.Point(466, 18)
        Me.GunaGroupBox5.Name = "GunaGroupBox5"
        Me.GunaGroupBox5.Size = New System.Drawing.Size(321, 177)
        Me.GunaGroupBox5.TabIndex = 72
        Me.GunaGroupBox5.Text = "Supplier Information"
        Me.GunaGroupBox5.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.LineVisible = True
        Me.LabelControl2.Location = New System.Drawing.Point(18, 62)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(102, 16)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "* Supplier Model:"
        '
        'txt_supmodel
        '
        Me.txt_supmodel.Location = New System.Drawing.Point(134, 59)
        Me.txt_supmodel.Name = "txt_supmodel"
        Me.txt_supmodel.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_supmodel.Properties.Appearance.Options.UseFont = True
        Me.txt_supmodel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_supmodel.Size = New System.Drawing.Size(138, 22)
        Me.txt_supmodel.TabIndex = 10
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.LineVisible = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 92)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(61, 16)
        Me.LabelControl3.TabIndex = 12
        Me.LabelControl3.Text = "* Supplier:"
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(28, 120)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_supplier.Properties.Appearance.Options.UseFont = True
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(275, 22)
        Me.cbb_supplier.TabIndex = 11
        '
        'GunaGroupBox4
        '
        Me.GunaGroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox4.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox4.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox4.BorderSize = 1
        Me.GunaGroupBox4.Controls.Add(Me.LabelControl32)
        Me.GunaGroupBox4.Controls.Add(Me.txt_qty_per_box)
        Me.GunaGroupBox4.Controls.Add(Me.LabelControl18)
        Me.GunaGroupBox4.Controls.Add(Me.txt_warning_stock)
        Me.GunaGroupBox4.Controls.Add(Me.LabelControl17)
        Me.GunaGroupBox4.Controls.Add(Me.txt_ideal_stock)
        Me.GunaGroupBox4.Controls.Add(Me.LabelControl25)
        Me.GunaGroupBox4.Controls.Add(Me.txt_stock_duration)
        Me.GunaGroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GunaGroupBox4.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox4.Location = New System.Drawing.Point(466, 213)
        Me.GunaGroupBox4.Name = "GunaGroupBox4"
        Me.GunaGroupBox4.Size = New System.Drawing.Size(321, 215)
        Me.GunaGroupBox4.TabIndex = 71
        Me.GunaGroupBox4.Text = "Stock Management"
        Me.GunaGroupBox4.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelControl32
        '
        Me.LabelControl32.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl32.Appearance.Options.UseFont = True
        Me.LabelControl32.LineVisible = True
        Me.LabelControl32.Location = New System.Drawing.Point(17, 59)
        Me.LabelControl32.Name = "LabelControl32"
        Me.LabelControl32.Size = New System.Drawing.Size(99, 16)
        Me.LabelControl32.TabIndex = 67
        Me.LabelControl32.Text = "Quantity Per Box"
        '
        'txt_qty_per_box
        '
        Me.txt_qty_per_box.Location = New System.Drawing.Point(153, 56)
        Me.txt_qty_per_box.Name = "txt_qty_per_box"
        Me.txt_qty_per_box.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_qty_per_box.Properties.Appearance.Options.UseFont = True
        Me.txt_qty_per_box.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_qty_per_box.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_qty_per_box.Size = New System.Drawing.Size(54, 22)
        Me.txt_qty_per_box.TabIndex = 66
        '
        'LabelControl18
        '
        Me.LabelControl18.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl18.Appearance.Options.UseFont = True
        Me.LabelControl18.LineVisible = True
        Me.LabelControl18.Location = New System.Drawing.Point(17, 117)
        Me.LabelControl18.Name = "LabelControl18"
        Me.LabelControl18.Size = New System.Drawing.Size(126, 16)
        Me.LabelControl18.TabIndex = 65
        Me.LabelControl18.Text = "Warning Stock Level:"
        '
        'txt_warning_stock
        '
        Me.txt_warning_stock.Location = New System.Drawing.Point(153, 114)
        Me.txt_warning_stock.Name = "txt_warning_stock"
        Me.txt_warning_stock.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_warning_stock.Properties.Appearance.Options.UseFont = True
        Me.txt_warning_stock.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_warning_stock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_warning_stock.Size = New System.Drawing.Size(54, 22)
        Me.txt_warning_stock.TabIndex = 23
        '
        'LabelControl17
        '
        Me.LabelControl17.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl17.Appearance.Options.UseFont = True
        Me.LabelControl17.LineVisible = True
        Me.LabelControl17.Location = New System.Drawing.Point(17, 87)
        Me.LabelControl17.Name = "LabelControl17"
        Me.LabelControl17.Size = New System.Drawing.Size(106, 16)
        Me.LabelControl17.TabIndex = 63
        Me.LabelControl17.Text = "Ideal Stock Level:"
        '
        'txt_ideal_stock
        '
        Me.txt_ideal_stock.Location = New System.Drawing.Point(153, 84)
        Me.txt_ideal_stock.Name = "txt_ideal_stock"
        Me.txt_ideal_stock.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_ideal_stock.Properties.Appearance.Options.UseFont = True
        Me.txt_ideal_stock.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_ideal_stock.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_ideal_stock.Size = New System.Drawing.Size(54, 22)
        Me.txt_ideal_stock.TabIndex = 22
        '
        'LabelControl25
        '
        Me.LabelControl25.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl25.Appearance.Options.UseFont = True
        Me.LabelControl25.LineVisible = True
        Me.LabelControl25.Location = New System.Drawing.Point(13, 148)
        Me.LabelControl25.Name = "LabelControl25"
        Me.LabelControl25.Size = New System.Drawing.Size(105, 32)
        Me.LabelControl25.TabIndex = 61
        Me.LabelControl25.Text = "Stocking Duration" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Days)"
        '
        'txt_stock_duration
        '
        Me.txt_stock_duration.Location = New System.Drawing.Point(153, 145)
        Me.txt_stock_duration.Name = "txt_stock_duration"
        Me.txt_stock_duration.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_stock_duration.Properties.Appearance.Options.UseFont = True
        Me.txt_stock_duration.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_stock_duration.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.txt_stock_duration.Size = New System.Drawing.Size(54, 22)
        Me.txt_stock_duration.TabIndex = 24
        '
        'GunaGroupBox3
        '
        Me.GunaGroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox3.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox3.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox3.BorderSize = 1
        Me.GunaGroupBox3.Controls.Add(Me.LabelControl15)
        Me.GunaGroupBox3.Controls.Add(Me.txt_length)
        Me.GunaGroupBox3.Controls.Add(Me.LabelControl14)
        Me.GunaGroupBox3.Controls.Add(Me.txt_width)
        Me.GunaGroupBox3.Controls.Add(Me.txt_height)
        Me.GunaGroupBox3.Controls.Add(Me.LabelControl13)
        Me.GunaGroupBox3.Controls.Add(Me.txt_weight)
        Me.GunaGroupBox3.Controls.Add(Me.LabelControl20)
        Me.GunaGroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.GunaGroupBox3.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox3.Location = New System.Drawing.Point(804, 449)
        Me.GunaGroupBox3.Name = "GunaGroupBox3"
        Me.GunaGroupBox3.Size = New System.Drawing.Size(326, 202)
        Me.GunaGroupBox3.TabIndex = 70
        Me.GunaGroupBox3.Text = "Dimension"
        Me.GunaGroupBox3.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelControl15
        '
        Me.LabelControl15.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl15.Appearance.Options.UseFont = True
        Me.LabelControl15.LineVisible = True
        Me.LabelControl15.Location = New System.Drawing.Point(20, 59)
        Me.LabelControl15.Name = "LabelControl15"
        Me.LabelControl15.Size = New System.Drawing.Size(72, 16)
        Me.LabelControl15.TabIndex = 34
        Me.LabelControl15.Text = "Length (cm):"
        '
        'txt_length
        '
        Me.txt_length.Location = New System.Drawing.Point(115, 56)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_length.Properties.Appearance.Options.UseFont = True
        Me.txt_length.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_length.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_length.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_length.Size = New System.Drawing.Size(72, 22)
        Me.txt_length.TabIndex = 18
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.LineVisible = True
        Me.LabelControl14.Location = New System.Drawing.Point(20, 89)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl14.TabIndex = 35
        Me.LabelControl14.Text = "Width (cm):"
        '
        'txt_width
        '
        Me.txt_width.Location = New System.Drawing.Point(115, 86)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_width.Properties.Appearance.Options.UseFont = True
        Me.txt_width.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_width.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_width.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_width.Size = New System.Drawing.Size(72, 22)
        Me.txt_width.TabIndex = 19
        '
        'txt_height
        '
        Me.txt_height.Location = New System.Drawing.Point(115, 117)
        Me.txt_height.Name = "txt_height"
        Me.txt_height.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_height.Properties.Appearance.Options.UseFont = True
        Me.txt_height.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_height.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_height.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_height.Size = New System.Drawing.Size(72, 22)
        Me.txt_height.TabIndex = 20
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.LineVisible = True
        Me.LabelControl13.Location = New System.Drawing.Point(21, 119)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl13.TabIndex = 36
        Me.LabelControl13.Text = "Height (cm):"
        '
        'txt_weight
        '
        Me.txt_weight.Location = New System.Drawing.Point(115, 161)
        Me.txt_weight.Name = "txt_weight"
        Me.txt_weight.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_weight.Properties.Appearance.Options.UseFont = True
        Me.txt_weight.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_weight.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_weight.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_weight.Size = New System.Drawing.Size(72, 22)
        Me.txt_weight.TabIndex = 21
        '
        'LabelControl20
        '
        Me.LabelControl20.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl20.Appearance.Options.UseFont = True
        Me.LabelControl20.LineVisible = True
        Me.LabelControl20.Location = New System.Drawing.Point(20, 164)
        Me.LabelControl20.Name = "LabelControl20"
        Me.LabelControl20.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl20.TabIndex = 47
        Me.LabelControl20.Text = "Weight (kg):"
        '
        'GunaGroupBox2
        '
        Me.GunaGroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox2.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox2.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox2.BorderSize = 1
        Me.GunaGroupBox2.Controls.Add(Me.txt_vip_price)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl29)
        Me.GunaGroupBox2.Controls.Add(Me.txt_dealer_price)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl28)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl24)
        Me.GunaGroupBox2.Controls.Add(Me.txt_baseprice)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl26)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl11)
        Me.GunaGroupBox2.Controls.Add(Me.txt_discount)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl10)
        Me.GunaGroupBox2.Controls.Add(Me.txt_cost)
        Me.GunaGroupBox2.Controls.Add(Me.LabelControl12)
        Me.GunaGroupBox2.Controls.Add(Me.txt_srp)
        Me.GunaGroupBox2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.GunaGroupBox2.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox2.Location = New System.Drawing.Point(466, 449)
        Me.GunaGroupBox2.Name = "GunaGroupBox2"
        Me.GunaGroupBox2.Size = New System.Drawing.Size(321, 202)
        Me.GunaGroupBox2.TabIndex = 69
        Me.GunaGroupBox2.Text = "Pricing"
        Me.GunaGroupBox2.TextLocation = New System.Drawing.Point(10, 8)
        '
        'txt_vip_price
        '
        Me.txt_vip_price.EditValue = "0.00"
        Me.txt_vip_price.Location = New System.Drawing.Point(239, 170)
        Me.txt_vip_price.Name = "txt_vip_price"
        Me.txt_vip_price.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vip_price.Properties.Appearance.Options.UseFont = True
        Me.txt_vip_price.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_vip_price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_vip_price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_vip_price.Size = New System.Drawing.Size(72, 22)
        Me.txt_vip_price.TabIndex = 17
        '
        'LabelControl29
        '
        Me.LabelControl29.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl29.Appearance.Options.UseFont = True
        Me.LabelControl29.LineVisible = True
        Me.LabelControl29.Location = New System.Drawing.Point(176, 173)
        Me.LabelControl29.Name = "LabelControl29"
        Me.LabelControl29.Size = New System.Drawing.Size(30, 16)
        Me.LabelControl29.TabIndex = 69
        Me.LabelControl29.Text = "*VIP:"
        '
        'txt_dealer_price
        '
        Me.txt_dealer_price.EditValue = "0.00"
        Me.txt_dealer_price.Location = New System.Drawing.Point(239, 140)
        Me.txt_dealer_price.Name = "txt_dealer_price"
        Me.txt_dealer_price.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_dealer_price.Properties.Appearance.Options.UseFont = True
        Me.txt_dealer_price.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_dealer_price.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_dealer_price.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_dealer_price.Size = New System.Drawing.Size(72, 22)
        Me.txt_dealer_price.TabIndex = 16
        '
        'LabelControl28
        '
        Me.LabelControl28.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl28.Appearance.Options.UseFont = True
        Me.LabelControl28.LineVisible = True
        Me.LabelControl28.Location = New System.Drawing.Point(176, 143)
        Me.LabelControl28.Name = "LabelControl28"
        Me.LabelControl28.Size = New System.Drawing.Size(46, 16)
        Me.LabelControl28.TabIndex = 67
        Me.LabelControl28.Text = "*Dealer:"
        '
        'LabelControl24
        '
        Me.LabelControl24.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl24.Appearance.Options.UseFont = True
        Me.LabelControl24.LineVisible = True
        Me.LabelControl24.Location = New System.Drawing.Point(13, 59)
        Me.LabelControl24.Name = "LabelControl24"
        Me.LabelControl24.Size = New System.Drawing.Size(77, 16)
        Me.LabelControl24.TabIndex = 64
        Me.LabelControl24.Text = "* Base Price:"
        '
        'txt_baseprice
        '
        Me.txt_baseprice.EditValue = "0.00"
        Me.txt_baseprice.Location = New System.Drawing.Point(96, 58)
        Me.txt_baseprice.Name = "txt_baseprice"
        Me.txt_baseprice.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_baseprice.Properties.Appearance.Options.UseFont = True
        Me.txt_baseprice.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_baseprice.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_baseprice.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_baseprice.Size = New System.Drawing.Size(72, 22)
        Me.txt_baseprice.TabIndex = 12
        '
        'LabelControl26
        '
        Me.LabelControl26.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl26.Appearance.Options.UseFont = True
        Me.LabelControl26.LineVisible = True
        Me.LabelControl26.Location = New System.Drawing.Point(136, 91)
        Me.LabelControl26.Name = "LabelControl26"
        Me.LabelControl26.Size = New System.Drawing.Size(12, 16)
        Me.LabelControl26.TabIndex = 66
        Me.LabelControl26.Text = "%"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.LineVisible = True
        Me.LabelControl11.Location = New System.Drawing.Point(22, 91)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl11.TabIndex = 29
        Me.LabelControl11.Text = "Discount:"
        '
        'txt_discount
        '
        Me.txt_discount.EditValue = "0"
        Me.txt_discount.Location = New System.Drawing.Point(96, 88)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.[True]
        Me.txt_discount.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_discount.Properties.Appearance.Options.UseFont = True
        Me.txt_discount.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_discount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_discount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_discount.Properties.Name = "TextEdit6"
        Me.txt_discount.Size = New System.Drawing.Size(38, 22)
        Me.txt_discount.TabIndex = 13
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.LineVisible = True
        Me.LabelControl10.Location = New System.Drawing.Point(22, 121)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(31, 16)
        Me.LabelControl10.TabIndex = 28
        Me.LabelControl10.Text = "Cost:"
        '
        'txt_cost
        '
        Me.txt_cost.EditValue = "0.00"
        Me.txt_cost.Enabled = False
        Me.txt_cost.Location = New System.Drawing.Point(96, 118)
        Me.txt_cost.Name = "txt_cost"
        Me.txt_cost.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cost.Properties.Appearance.Options.UseFont = True
        Me.txt_cost.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_cost.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_cost.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_cost.Size = New System.Drawing.Size(72, 22)
        Me.txt_cost.TabIndex = 14
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.LineVisible = True
        Me.LabelControl12.Location = New System.Drawing.Point(176, 116)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(53, 16)
        Me.LabelControl12.TabIndex = 30
        Me.LabelControl12.Text = "*Regular:"
        '
        'txt_srp
        '
        Me.txt_srp.EditValue = "0.00"
        Me.txt_srp.Location = New System.Drawing.Point(239, 110)
        Me.txt_srp.Name = "txt_srp"
        Me.txt_srp.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_srp.Properties.Appearance.Options.UseFont = True
        Me.txt_srp.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_srp.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_srp.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txt_srp.Size = New System.Drawing.Size(72, 22)
        Me.txt_srp.TabIndex = 15
        '
        'GunaGroupBox1
        '
        Me.GunaGroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GunaGroupBox1.BaseColor = System.Drawing.Color.GhostWhite
        Me.GunaGroupBox1.BorderColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox1.BorderSize = 1
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl31)
        Me.GunaGroupBox1.Controls.Add(Me.txt_more_description)
        Me.GunaGroupBox1.Controls.Add(Me.txt_pid)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl30)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl1)
        Me.GunaGroupBox1.Controls.Add(Me.txt_winmodel)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl4)
        Me.GunaGroupBox1.Controls.Add(Me.txt_description)
        Me.GunaGroupBox1.Controls.Add(Me.switch_serialize)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl16)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl22)
        Me.GunaGroupBox1.Controls.Add(Me.txt_cautions)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl5)
        Me.GunaGroupBox1.Controls.Add(Me.cbb_maincategory)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl6)
        Me.GunaGroupBox1.Controls.Add(Me.cbb_subcategory)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl7)
        Me.GunaGroupBox1.Controls.Add(Me.cbb_brand)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl8)
        Me.GunaGroupBox1.Controls.Add(Me.txt_tags)
        Me.GunaGroupBox1.Controls.Add(Me.LabelControl9)
        Me.GunaGroupBox1.Controls.Add(Me.txt_barcode)
        Me.GunaGroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGroupBox1.LineColor = System.Drawing.Color.SkyBlue
        Me.GunaGroupBox1.Location = New System.Drawing.Point(12, 18)
        Me.GunaGroupBox1.Name = "GunaGroupBox1"
        Me.GunaGroupBox1.Size = New System.Drawing.Size(438, 464)
        Me.GunaGroupBox1.TabIndex = 68
        Me.GunaGroupBox1.Text = "General"
        Me.GunaGroupBox1.TextLocation = New System.Drawing.Point(10, 8)
        '
        'LabelControl31
        '
        Me.LabelControl31.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl31.Appearance.Options.UseFont = True
        Me.LabelControl31.LineVisible = True
        Me.LabelControl31.Location = New System.Drawing.Point(29, 199)
        Me.LabelControl31.Name = "LabelControl31"
        Me.LabelControl31.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl31.TabIndex = 58
        Me.LabelControl31.Text = "More Details:"
        '
        'txt_more_description
        '
        Me.txt_more_description.Location = New System.Drawing.Point(146, 197)
        Me.txt_more_description.Name = "txt_more_description"
        Me.txt_more_description.Properties.AcceptsTab = True
        Me.txt_more_description.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_more_description.Properties.Appearance.Options.UseFont = True
        Me.txt_more_description.Size = New System.Drawing.Size(267, 50)
        Me.txt_more_description.TabIndex = 57
        '
        'txt_pid
        '
        Me.txt_pid.Location = New System.Drawing.Point(146, 56)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_pid.Properties.Appearance.Options.UseFont = True
        Me.txt_pid.Size = New System.Drawing.Size(148, 22)
        Me.txt_pid.TabIndex = 0
        '
        'LabelControl30
        '
        Me.LabelControl30.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl30.Appearance.Options.UseFont = True
        Me.LabelControl30.LineVisible = True
        Me.LabelControl30.Location = New System.Drawing.Point(21, 59)
        Me.LabelControl30.Name = "LabelControl30"
        Me.LabelControl30.Size = New System.Drawing.Size(111, 16)
        Me.LabelControl30.TabIndex = 56
        Me.LabelControl30.Text = "* Product ID (SKU):"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.LineVisible = True
        Me.LabelControl1.Location = New System.Drawing.Point(19, 121)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(101, 16)
        Me.LabelControl1.TabIndex = 8
        Me.LabelControl1.Text = "* Winland Model:"
        '
        'txt_winmodel
        '
        Me.txt_winmodel.Location = New System.Drawing.Point(146, 118)
        Me.txt_winmodel.Name = "txt_winmodel"
        Me.txt_winmodel.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_winmodel.Properties.Appearance.Options.UseFont = True
        Me.txt_winmodel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_winmodel.Size = New System.Drawing.Size(148, 22)
        Me.txt_winmodel.TabIndex = 3
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.LineVisible = True
        Me.LabelControl4.Location = New System.Drawing.Point(20, 150)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(79, 16)
        Me.LabelControl4.TabIndex = 14
        Me.LabelControl4.Text = "* Description:"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(146, 148)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_description.Properties.Appearance.Options.UseFont = True
        Me.txt_description.Size = New System.Drawing.Size(267, 43)
        Me.txt_description.TabIndex = 4
        '
        'switch_serialize
        '
        Me.switch_serialize.AllowDrop = True
        Me.switch_serialize.BaseColor = System.Drawing.SystemColors.Control
        Me.switch_serialize.CheckedOffColor = System.Drawing.Color.DarkGray
        Me.switch_serialize.CheckedOnColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.switch_serialize.FillColor = System.Drawing.Color.White
        Me.switch_serialize.Location = New System.Drawing.Point(375, 89)
        Me.switch_serialize.Name = "switch_serialize"
        Me.switch_serialize.Size = New System.Drawing.Size(38, 20)
        Me.switch_serialize.TabIndex = 2
        '
        'LabelControl16
        '
        Me.LabelControl16.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl16.Appearance.Options.UseFont = True
        Me.LabelControl16.LineVisible = True
        Me.LabelControl16.Location = New System.Drawing.Point(29, 256)
        Me.LabelControl16.Name = "LabelControl16"
        Me.LabelControl16.Size = New System.Drawing.Size(84, 16)
        Me.LabelControl16.TabIndex = 40
        Me.LabelControl16.Text = "Hazard Signs:"
        '
        'LabelControl22
        '
        Me.LabelControl22.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl22.Appearance.Options.UseFont = True
        Me.LabelControl22.LineVisible = True
        Me.LabelControl22.Location = New System.Drawing.Point(313, 89)
        Me.LabelControl22.Name = "LabelControl22"
        Me.LabelControl22.Size = New System.Drawing.Size(59, 16)
        Me.LabelControl22.TabIndex = 53
        Me.LabelControl22.Text = "Serialize?"
        '
        'txt_cautions
        '
        Me.txt_cautions.Location = New System.Drawing.Point(146, 253)
        Me.txt_cautions.Name = "txt_cautions"
        Me.txt_cautions.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_cautions.Properties.Appearance.Options.UseFont = True
        Me.txt_cautions.Size = New System.Drawing.Size(254, 22)
        Me.txt_cautions.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.LineVisible = True
        Me.LabelControl5.Location = New System.Drawing.Point(19, 284)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "* Main Category:"
        '
        'cbb_maincategory
        '
        Me.cbb_maincategory.Location = New System.Drawing.Point(146, 281)
        Me.cbb_maincategory.Name = "cbb_maincategory"
        Me.cbb_maincategory.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_maincategory.Properties.Appearance.Options.UseFont = True
        Me.cbb_maincategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_maincategory.Size = New System.Drawing.Size(148, 22)
        Me.cbb_maincategory.TabIndex = 6
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.LineVisible = True
        Me.LabelControl6.Location = New System.Drawing.Point(19, 314)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(93, 16)
        Me.LabelControl6.TabIndex = 20
        Me.LabelControl6.Text = "* Sub Category:"
        '
        'cbb_subcategory
        '
        Me.cbb_subcategory.Location = New System.Drawing.Point(146, 311)
        Me.cbb_subcategory.Name = "cbb_subcategory"
        Me.cbb_subcategory.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_subcategory.Properties.Appearance.Options.UseFont = True
        Me.cbb_subcategory.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_subcategory.Size = New System.Drawing.Size(148, 22)
        Me.cbb_subcategory.TabIndex = 7
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.LineVisible = True
        Me.LabelControl7.Location = New System.Drawing.Point(20, 344)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl7.TabIndex = 22
        Me.LabelControl7.Text = "* Brand:"
        '
        'cbb_brand
        '
        Me.cbb_brand.Location = New System.Drawing.Point(146, 341)
        Me.cbb_brand.Name = "cbb_brand"
        Me.cbb_brand.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.cbb_brand.Properties.Appearance.Options.UseFont = True
        Me.cbb_brand.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_brand.Size = New System.Drawing.Size(148, 22)
        Me.cbb_brand.TabIndex = 8
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.LineVisible = True
        Me.LabelControl8.Location = New System.Drawing.Point(14, 369)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(174, 16)
        Me.LabelControl8.TabIndex = 24
        Me.LabelControl8.Text = "Tags (separated by comma):"
        '
        'txt_tags
        '
        Me.txt_tags.Location = New System.Drawing.Point(146, 393)
        Me.txt_tags.Name = "txt_tags"
        Me.txt_tags.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_tags.Properties.Appearance.Options.UseFont = True
        Me.txt_tags.Size = New System.Drawing.Size(267, 50)
        Me.txt_tags.TabIndex = 9
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.LineVisible = True
        Me.LabelControl9.Location = New System.Drawing.Point(29, 89)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl9.TabIndex = 26
        Me.LabelControl9.Text = "Barcode:"
        '
        'txt_barcode
        '
        Me.txt_barcode.Location = New System.Drawing.Point(146, 86)
        Me.txt_barcode.Name = "txt_barcode"
        Me.txt_barcode.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_barcode.Properties.Appearance.Options.UseFont = True
        Me.txt_barcode.Size = New System.Drawing.Size(148, 22)
        Me.txt_barcode.TabIndex = 1
        '
        'GunaPanel2
        '
        Me.GunaPanel2.BackColor = System.Drawing.Color.SkyBlue
        Me.GunaPanel2.Controls.Add(Me.LabelControl27)
        Me.GunaPanel2.Controls.Add(Me.cbb_status)
        Me.GunaPanel2.Controls.Add(Me.btn_save)
        Me.GunaPanel2.Controls.Add(Me.btn_clear)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 679)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(1138, 62)
        Me.GunaPanel2.TabIndex = 63
        '
        'LabelControl27
        '
        Me.LabelControl27.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LabelControl27.Appearance.Options.UseFont = True
        Me.LabelControl27.LineVisible = True
        Me.LabelControl27.Location = New System.Drawing.Point(19, 20)
        Me.LabelControl27.Name = "LabelControl27"
        Me.LabelControl27.Size = New System.Drawing.Size(51, 20)
        Me.LabelControl27.TabIndex = 37
        Me.LabelControl27.Text = "Status:"
        '
        'cbb_status
        '
        Me.cbb_status.EditValue = "For Approval"
        Me.cbb_status.Enabled = False
        Me.cbb_status.Location = New System.Drawing.Point(74, 20)
        Me.cbb_status.Name = "cbb_status"
        Me.cbb_status.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbb_status.Properties.Appearance.Options.UseFont = True
        Me.cbb_status.Properties.AutoHeight = False
        Me.cbb_status.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_status.Properties.Items.AddRange(New Object() {"For Approval", "Active", "On-Hold", "Discontinued"})
        Me.cbb_status.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_status.Size = New System.Drawing.Size(117, 25)
        Me.cbb_status.TabIndex = 28
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.Location = New System.Drawing.Point(1050, 23)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(80, 27)
        Me.btn_save.TabIndex = 29
        Me.btn_save.Text = "Save"
        '
        'btn_clear
        '
        Me.btn_clear.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_clear.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.btn_clear.Appearance.Options.UseFont = True
        Me.btn_clear.Location = New System.Drawing.Point(964, 23)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(80, 27)
        Me.btn_clear.TabIndex = 7
        Me.btn_clear.Text = "Clear"
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel3.AutoScroll = True
        Me.GunaPanel3.BackColor = System.Drawing.Color.White
        Me.GunaPanel3.Controls.Add(Me.panel_addunit)
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 77)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Padding = New System.Windows.Forms.Padding(20, 20, 20, 0)
        Me.GunaPanel3.Size = New System.Drawing.Size(1202, 798)
        Me.GunaPanel3.TabIndex = 7
        '
        'ErrorNotif
        '
        Me.ErrorNotif.ContainerControl = Me
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.breadcrumb)
        Me.panel_top.Controls.Add(Me.txt_title)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1202, 78)
        Me.panel_top.TabIndex = 12
        '
        'breadcrumb
        '
        Me.breadcrumb.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.breadcrumb.BackColor = System.Drawing.Color.Transparent
        Me.breadcrumb.Controls.Add(Me.GunaPanel1)
        Me.breadcrumb.Location = New System.Drawing.Point(19, 44)
        Me.breadcrumb.Name = "breadcrumb"
        Me.breadcrumb.Size = New System.Drawing.Size(1162, 27)
        Me.breadcrumb.TabIndex = 5
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel1.Controls.Add(Me.LabelControl23)
        Me.GunaPanel1.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel1.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel1.TabIndex = 1
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl1.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.Enabled = False
        Me.HyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(70, 5)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.ShowLineShadow = False
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(80, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "New Product"
        '
        'LabelControl23
        '
        Me.LabelControl23.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl23.Appearance.Options.UseFont = True
        Me.LabelControl23.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl23.Name = "LabelControl23"
        Me.LabelControl23.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl23.TabIndex = 6
        Me.LabelControl23.Text = ">"
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
        'txt_title
        '
        Me.txt_title.AutoSize = True
        Me.txt_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.txt_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.txt_title.Location = New System.Drawing.Point(14, 10)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(170, 31)
        Me.txt_title.TabIndex = 1
        Me.txt_title.Text = "New Product"
        '
        'frm_product_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1202, 873)
        Me.Controls.Add(Me.GunaPanel3)
        Me.Controls.Add(Me.panel_top)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_product_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Product"
        Me.panel_addunit.ResumeLayout(False)
        Me.GunaGroupBox7.ResumeLayout(False)
        CType(Me.pb_new_unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox6.ResumeLayout(False)
        Me.GunaGroupBox6.PerformLayout()
        CType(Me.txt_warranty_period.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_warranty_coverage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox5.ResumeLayout(False)
        Me.GunaGroupBox5.PerformLayout()
        CType(Me.txt_supmodel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox4.ResumeLayout(False)
        Me.GunaGroupBox4.PerformLayout()
        CType(Me.txt_qty_per_box.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_warning_stock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ideal_stock.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_stock_duration.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox3.ResumeLayout(False)
        Me.GunaGroupBox3.PerformLayout()
        CType(Me.txt_length.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_width.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_height.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_weight.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox2.ResumeLayout(False)
        Me.GunaGroupBox2.PerformLayout()
        CType(Me.txt_vip_price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_dealer_price.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_baseprice.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_srp.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGroupBox1.ResumeLayout(False)
        Me.GunaGroupBox1.PerformLayout()
        CType(Me.txt_more_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_winmodel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cautions.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_maincategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_subcategory.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_brand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tags.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_barcode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        CType(Me.cbb_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaPanel3.ResumeLayout(False)
        CType(Me.ErrorNotif, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.breadcrumb.ResumeLayout(False)
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents panel_addunit As Guna.UI.WinForms.GunaPanel
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_supmodel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_winmodel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_maincategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_tags As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_brand As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_subcategory As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_srp As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_cost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_barcode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_height As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_width As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_length As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl16 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents txt_weight As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl20 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl15 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cautions As DevExpress.XtraEditors.TextEdit
    Friend WithEvents switch_serialize As Guna.UI.WinForms.GunaGoogleSwitch
    Friend WithEvents LabelControl22 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_stock_duration As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl25 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents txt_baseprice As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl24 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl26 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents ErrorNotif As DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider
    Friend WithEvents LabelControl27 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_status As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaGroupBox1 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox2 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox3 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox4 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents GunaGroupBox5 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LabelControl18 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_warning_stock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl17 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_ideal_stock As DevExpress.XtraEditors.TextEdit
    Friend WithEvents GunaGroupBox6 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents LabelControl19 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GunaGroupBox7 As Guna.UI.WinForms.GunaGroupBox
    Friend WithEvents btn_camera As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents pb_new_unit As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txt_warranty_period As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl21 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_warranty_coverage As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents panel_top As Guna.UI.WinForms.GunaPanel
    Friend WithEvents breadcrumb As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl23 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents txt_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_vip_price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl29 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_dealer_price As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl28 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl30 As DevExpress.XtraEditors.LabelControl
    'MY EDIT
    Friend WithEvents LabelControl31 As LabelControl
    Friend WithEvents txt_more_description As MemoEdit
    Friend WithEvents LabelControl32 As LabelControl
    Friend WithEvents txt_qty_per_box As TextEdit
End Class
