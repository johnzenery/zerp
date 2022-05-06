Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports Guna.UI.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySqlConnector
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Resources
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_stock_reconcile_new
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_reconcile_new))
		Me.panel_top = New GunaLinePanel()
		Me.GunaPanel2 = New GunaPanel()
		Me.GunaPanel3 = New GunaPanel()
		Me.sub_title = New HyperlinkLabelControl()
		Me.LabelControl1 = New LabelControl()
		Me.HyperlinkLabelControl2 = New HyperlinkLabelControl()
		Me.lbl_title = New GunaLabel()
		Me.btn_submit = New SimpleButton()
		Me.GunaLabel7 = New GunaLabel()
		Me.GunaLabel6 = New GunaLabel()
		Me.GunaLabel5 = New GunaLabel()
		Me.Panel2 = New Panel()
		Me.cbb_model = New ComboBoxEdit()
		Me.GunaLabel4 = New GunaLabel()
		Me.txt_memo = New MemoEdit()
		Me.rb_deduct = New RadioButton()
		Me.rb_add = New RadioButton()
		Me.num_reconcile = New NumericUpDown()
		Me.GunaLabel3 = New GunaLabel()
		Me.GunaLabel2 = New GunaLabel()
		Me.txt_description = New MemoEdit()
		Me.txt_pid = New TextEdit()
		Me.cbb_stores = New ComboBoxEdit()
		Me.GunaLabel1 = New GunaLabel()
		Me.btn_cancel = New SimpleButton()
		Me.panel_top.SuspendLayout()
		Me.GunaPanel2.SuspendLayout()
		Me.GunaPanel3.SuspendLayout()
		Me.Panel2.SuspendLayout()
		DirectCast(Me.cbb_model.Properties, ISupportInitialize).BeginInit()
		DirectCast(Me.txt_memo.Properties, ISupportInitialize).BeginInit()
		DirectCast(Me.num_reconcile, ISupportInitialize).BeginInit()
		DirectCast(Me.txt_description.Properties, ISupportInitialize).BeginInit()
		DirectCast(Me.txt_pid.Properties, ISupportInitialize).BeginInit()
		DirectCast(Me.cbb_stores.Properties, ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		Me.panel_top.BackColor = Color.GhostWhite
		Me.panel_top.Controls.Add(Me.GunaPanel2)
		Me.panel_top.Controls.Add(Me.lbl_title)
		Me.panel_top.Dock = DockStyle.Top
		Me.panel_top.LineColor = SystemColors.ControlLight
		Me.panel_top.LineStyle = BorderStyle.None
		Me.panel_top.Location = New Point(0, 0)
		Me.panel_top.Name = "panel_top"
		Me.panel_top.Size = New System.Drawing.Size(460, 78)
		Me.panel_top.TabIndex = 10
		Me.GunaPanel2.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
		Me.GunaPanel2.BackColor = Color.Transparent
		Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
		Me.GunaPanel2.Location = New Point(19, 44)
		Me.GunaPanel2.Name = "GunaPanel2"
		Me.GunaPanel2.Size = New System.Drawing.Size(251, 27)
		Me.GunaPanel2.TabIndex = 6
		Me.GunaPanel3.Controls.Add(Me.sub_title)
		Me.GunaPanel3.Controls.Add(Me.LabelControl1)
		Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl2)
		Me.GunaPanel3.Dock = DockStyle.Left
		Me.GunaPanel3.Location = New Point(0, 0)
		Me.GunaPanel3.Name = "GunaPanel3"
		Me.GunaPanel3.Size = New System.Drawing.Size(191, 27)
		Me.GunaPanel3.TabIndex = 1
		Me.sub_title.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Bold, GraphicsUnit.Point, 0)
		Me.sub_title.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
		Me.sub_title.Appearance.Options.UseFont = True
		Me.sub_title.Appearance.Options.UseLinkColor = True
		Me.sub_title.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
		Me.sub_title.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
		Me.sub_title.AppearanceHovered.Options.UseForeColor = True
		Me.sub_title.AppearanceHovered.Options.UseLinkColor = True
		Me.sub_title.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
		Me.sub_title.AppearancePressed.Options.UseLinkColor = True
		Me.sub_title.Enabled = False
		Me.sub_title.LineStyle = DashStyle.Custom
		Me.sub_title.LinkBehavior = LinkBehavior.NeverUnderline
		Me.sub_title.Location = New Point(70, 5)
		Me.sub_title.Name = "sub_title"
		Me.sub_title.ShowLineShadow = False
		Me.sub_title.Size = New System.Drawing.Size(92, 18)
		Me.sub_title.TabIndex = 7
		Me.sub_title.Text = "New Reconcile"
		Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
		Me.LabelControl1.Appearance.Options.UseFont = True
		Me.LabelControl1.Location = New Point(55, 7)
		Me.LabelControl1.Name = "LabelControl1"
		Me.LabelControl1.Size = New System.Drawing.Size(9, 14)
		Me.LabelControl1.TabIndex = 6
		Me.LabelControl1.Text = ">"
		Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Me.HyperlinkLabelControl2.Appearance.LinkColor = DXSkinColors.ForeColors.ControlText
		Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
		Me.HyperlinkLabelControl2.Appearance.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.AppearanceDisabled.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearanceDisabled.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.AppearanceHovered.ForeColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearanceHovered.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseForeColor = True
		Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.AppearancePressed.LinkColor = Color.FromArgb(0, 122, 204)
		Me.HyperlinkLabelControl2.AppearancePressed.Options.UseLinkColor = True
		Me.HyperlinkLabelControl2.LineStyle = DashStyle.Custom
		Me.HyperlinkLabelControl2.LinkBehavior = LinkBehavior.NeverUnderline
		Me.HyperlinkLabelControl2.Location = New Point(13, 5)
		Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
		Me.HyperlinkLabelControl2.ShowLineShadow = False
		Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(37, 18)
		Me.HyperlinkLabelControl2.TabIndex = 5
		Me.HyperlinkLabelControl2.Text = "Home"
		Me.lbl_title.AutoSize = True
		Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
		Me.lbl_title.ForeColor = Color.FromArgb(213, 115, 45)
		Me.lbl_title.Location = New Point(14, 10)
		Me.lbl_title.Name = "lbl_title"
		Me.lbl_title.Size = New System.Drawing.Size(196, 31)
		Me.lbl_title.TabIndex = 1
		Me.lbl_title.Text = "New Reconcile"
		Me.btn_submit.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		Me.btn_submit.Appearance.BackColor = DXSkinColors.FillColors.Primary
		Me.btn_submit.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Me.btn_submit.Appearance.Options.UseBackColor = True
		Me.btn_submit.Appearance.Options.UseFont = True
		Me.btn_submit.Appearance.Options.UseTextOptions = True
		Me.btn_submit.Appearance.TextOptions.HAlignment = HorzAlignment.Center
		Me.btn_submit.Appearance.TextOptions.VAlignment = VertAlignment.Center
		Me.btn_submit.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter
		Me.btn_submit.ImageOptions.ImageToTextIndent = 8
		Me.btn_submit.Location = New Point(235, 488)
		Me.btn_submit.LookAndFeel.SkinName = "Office 2010 Blue"
		Me.btn_submit.LookAndFeel.UseDefaultLookAndFeel = False
		Me.btn_submit.Name = "btn_submit"
		Me.btn_submit.Size = New System.Drawing.Size(206, 46)
		Me.btn_submit.TabIndex = 80
		Me.btn_submit.Text = "Submit"
		Me.GunaLabel7.AutoSize = True
		Me.GunaLabel7.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel7.Location = New Point(23, 123)
		Me.GunaLabel7.Name = "GunaLabel7"
		Me.GunaLabel7.Size = New System.Drawing.Size(70, 15)
		Me.GunaLabel7.TabIndex = 100
		Me.GunaLabel7.Text = "Description"
		Me.GunaLabel6.AutoSize = True
		Me.GunaLabel6.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel6.Location = New Point(24, 92)
		Me.GunaLabel6.Name = "GunaLabel6"
		Me.GunaLabel6.Size = New System.Drawing.Size(40, 15)
		Me.GunaLabel6.TabIndex = 99
		Me.GunaLabel6.Text = "Model"
		Me.GunaLabel5.AutoSize = True
		Me.GunaLabel5.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel5.Location = New Point(24, 40)
		Me.GunaLabel5.Name = "GunaLabel5"
		Me.GunaLabel5.Size = New System.Drawing.Size(71, 15)
		Me.GunaLabel5.TabIndex = 95
		Me.GunaLabel5.Text = "Warehouse"
		Me.Panel2.BackColor = Color.Lavender
		Me.Panel2.Controls.Add(Me.cbb_model)
		Me.Panel2.Controls.Add(Me.GunaLabel4)
		Me.Panel2.Controls.Add(Me.txt_memo)
		Me.Panel2.Controls.Add(Me.rb_deduct)
		Me.Panel2.Controls.Add(Me.rb_add)
		Me.Panel2.Controls.Add(Me.num_reconcile)
		Me.Panel2.Controls.Add(Me.GunaLabel3)
		Me.Panel2.Controls.Add(Me.GunaLabel2)
		Me.Panel2.Controls.Add(Me.txt_description)
		Me.Panel2.Controls.Add(Me.txt_pid)
		Me.Panel2.Controls.Add(Me.cbb_stores)
		Me.Panel2.Controls.Add(Me.GunaLabel1)
		Me.Panel2.Controls.Add(Me.GunaLabel5)
		Me.Panel2.Controls.Add(Me.GunaLabel7)
		Me.Panel2.Controls.Add(Me.GunaLabel6)
		Me.Panel2.Location = New Point(19, 92)
		Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me.Panel2.Name = "Panel2"
		Me.Panel2.Size = New System.Drawing.Size(422, 384)
		Me.Panel2.TabIndex = 111
		Me.cbb_model.Location = New Point(114, 90)
		Me.cbb_model.Name = "cbb_model"
		Me.cbb_model.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.cbb_model.Properties.Appearance.Options.UseFont = True
		Me.cbb_model.Properties.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Combo)})
		Me.cbb_model.Size = New System.Drawing.Size(168, 22)
		Me.cbb_model.TabIndex = 118
		Me.GunaLabel4.AutoSize = True
		Me.GunaLabel4.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel4.Location = New Point(24, 250)
		Me.GunaLabel4.Name = "GunaLabel4"
		Me.GunaLabel4.Size = New System.Drawing.Size(32, 15)
		Me.GunaLabel4.TabIndex = 117
		Me.GunaLabel4.Text = "Type"
		Me.txt_memo.Location = New Point(114, 277)
		Me.txt_memo.Name = "txt_memo"
		Me.txt_memo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.txt_memo.Properties.Appearance.Options.UseFont = True
		Me.txt_memo.Size = New System.Drawing.Size(270, 86)
		Me.txt_memo.TabIndex = 116
		Me.rb_deduct.AutoSize = True
		Me.rb_deduct.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.rb_deduct.Location = New Point(191, 250)
		Me.rb_deduct.Name = "rb_deduct"
		Me.rb_deduct.Size = New System.Drawing.Size(64, 19)
		Me.rb_deduct.TabIndex = 115
		Me.rb_deduct.TabStop = True
		Me.rb_deduct.Text = "Deduct"
		Me.rb_deduct.UseVisualStyleBackColor = True
		Me.rb_add.AutoSize = True
		Me.rb_add.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.rb_add.Location = New Point(114, 250)
		Me.rb_add.Name = "rb_add"
		Me.rb_add.Size = New System.Drawing.Size(65, 19)
		Me.rb_add.TabIndex = 114
		Me.rb_add.TabStop = True
		Me.rb_add.Text = "Add Up"
		Me.rb_add.UseVisualStyleBackColor = True
		Me.num_reconcile.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.num_reconcile.Location = New Point(114, 217)
		Me.num_reconcile.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
		Me.num_reconcile.Name = "num_reconcile"
		Me.num_reconcile.Size = New System.Drawing.Size(96, 21)
		Me.num_reconcile.TabIndex = 113
		Me.num_reconcile.TextAlign = HorizontalAlignment.Center
		Me.GunaLabel3.AutoSize = True
		Me.GunaLabel3.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel3.Location = New Point(24, 278)
		Me.GunaLabel3.Name = "GunaLabel3"
		Me.GunaLabel3.Size = New System.Drawing.Size(40, 15)
		Me.GunaLabel3.TabIndex = 112
		Me.GunaLabel3.Text = "Notes"
		Me.GunaLabel2.AutoSize = True
		Me.GunaLabel2.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel2.Location = New Point(24, 223)
		Me.GunaLabel2.Name = "GunaLabel2"
		Me.GunaLabel2.Size = New System.Drawing.Size(82, 15)
		Me.GunaLabel2.TabIndex = 111
		Me.GunaLabel2.Text = "Reconcile Qty"
		Me.txt_description.Location = New Point(114, 116)
		Me.txt_description.Name = "txt_description"
		Me.txt_description.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.txt_description.Properties.Appearance.Options.UseFont = True
		Me.txt_description.Properties.[ReadOnly] = True
		Me.txt_description.Properties.UseReadOnlyAppearance = False
		Me.txt_description.Size = New System.Drawing.Size(270, 86)
		Me.txt_description.TabIndex = 110
		Me.txt_pid.Enabled = False
		Me.txt_pid.Location = New Point(114, 64)
		Me.txt_pid.Name = "txt_pid"
		Me.txt_pid.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.txt_pid.Properties.Appearance.Options.UseFont = True
		Me.txt_pid.Size = New System.Drawing.Size(137, 22)
		Me.txt_pid.TabIndex = 108
		Me.cbb_stores.Location = New Point(114, 38)
		Me.cbb_stores.Name = "cbb_stores"
		Me.cbb_stores.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.cbb_stores.Properties.Appearance.Options.UseFont = True
		Me.cbb_stores.Properties.Buttons.AddRange(New EditorButton() {New EditorButton(ButtonPredefines.Combo)})
		Me.cbb_stores.Size = New System.Drawing.Size(270, 22)
		Me.cbb_stores.TabIndex = 107
		Me.GunaLabel1.AutoSize = True
		Me.GunaLabel1.Font = New System.Drawing.Font("Arial", 9.0!)
		Me.GunaLabel1.Location = New Point(24, 66)
		Me.GunaLabel1.Name = "GunaLabel1"
		Me.GunaLabel1.Size = New System.Drawing.Size(64, 15)
		Me.GunaLabel1.TabIndex = 106
		Me.GunaLabel1.Text = "Product ID"
		Me.btn_cancel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
		Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, FontStyle.Regular, GraphicsUnit.Point, 0)
		Me.btn_cancel.Appearance.Options.UseFont = True
		Me.btn_cancel.Appearance.Options.UseTextOptions = True
		Me.btn_cancel.Appearance.TextOptions.HAlignment = HorzAlignment.Center
		Me.btn_cancel.Appearance.TextOptions.VAlignment = VertAlignment.Center
		Me.btn_cancel.ImageOptions.ImageToTextAlignment = ImageAlignToText.LeftCenter
		Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
		Me.btn_cancel.Location = New Point(20, 488)
		Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
		Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
		Me.btn_cancel.Name = "btn_cancel"
		Me.btn_cancel.Size = New System.Drawing.Size(209, 46)
		Me.btn_cancel.TabIndex = 112
		Me.btn_cancel.Text = "Cancel"
		Me.AutoScaleDimensions = New SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = Color.White
		Me.ClientSize = New System.Drawing.Size(460, 550)
		Me.Controls.Add(Me.btn_cancel)
		Me.Controls.Add(Me.btn_submit)
		Me.Controls.Add(Me.Panel2)
		Me.Controls.Add(Me.panel_top)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.Icon = DirectCast(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "frm_warehouse_stock_reconcile_new"
		Me.StartPosition = FormStartPosition.CenterScreen
		Me.Text = "New Reconcile"
		Me.panel_top.ResumeLayout(False)
		Me.panel_top.PerformLayout()
		Me.GunaPanel2.ResumeLayout(False)
		Me.GunaPanel3.ResumeLayout(False)
		Me.GunaPanel3.PerformLayout()
		Me.Panel2.ResumeLayout(False)
		Me.Panel2.PerformLayout()
		DirectCast(Me.cbb_model.Properties, ISupportInitialize).EndInit()
		DirectCast(Me.txt_memo.Properties, ISupportInitialize).EndInit()
		DirectCast(Me.num_reconcile, ISupportInitialize).EndInit()
		DirectCast(Me.txt_description.Properties, ISupportInitialize).EndInit()
		DirectCast(Me.txt_pid.Properties, ISupportInitialize).EndInit()
		DirectCast(Me.cbb_stores.Properties, ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents sub_title As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txt_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_stores As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rb_deduct As RadioButton
    Friend WithEvents rb_add As RadioButton
    Friend WithEvents num_reconcile As NumericUpDown
    Friend WithEvents txt_memo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbb_model As DevExpress.XtraEditors.ComboBoxEdit
End Class
