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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_reconcile_new))
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_model = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txt_memo = New DevExpress.XtraEditors.MemoEdit()
        Me.rb_deduct = New System.Windows.Forms.RadioButton()
        Me.rb_add = New System.Windows.Forms.RadioButton()
        Me.num_reconcile = New System.Windows.Forms.NumericUpDown()
        Me.txt_description = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_pid = New DevExpress.XtraEditors.TextEdit()
        Me.cbb_stores = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_title = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.cbb_model.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_memo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num_reconcile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_stores.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.Appearance.Options.UseTextOptions = True
        Me.btn_submit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_submit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 8
        Me.btn_submit.Location = New System.Drawing.Point(196, 421)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(171, 46)
        Me.btn_submit.TabIndex = 80
        Me.btn_submit.Text = "Submit"
        '
        'cbb_model
        '
        Me.cbb_model.Location = New System.Drawing.Point(106, 159)
        Me.cbb_model.Name = "cbb_model"
        Me.cbb_model.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cbb_model.Properties.Appearance.Options.UseFont = True
        Me.cbb_model.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_model.Size = New System.Drawing.Size(168, 30)
        Me.cbb_model.TabIndex = 118
        '
        'txt_memo
        '
        Me.txt_memo.Location = New System.Drawing.Point(106, 349)
        Me.txt_memo.Name = "txt_memo"
        Me.txt_memo.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_memo.Properties.Appearance.Options.UseFont = True
        Me.txt_memo.Size = New System.Drawing.Size(261, 62)
        Me.txt_memo.TabIndex = 116
        '
        'rb_deduct
        '
        Me.rb_deduct.AutoSize = True
        Me.rb_deduct.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rb_deduct.Location = New System.Drawing.Point(183, 322)
        Me.rb_deduct.Name = "rb_deduct"
        Me.rb_deduct.Size = New System.Drawing.Size(64, 19)
        Me.rb_deduct.TabIndex = 115
        Me.rb_deduct.TabStop = True
        Me.rb_deduct.Text = "Deduct"
        Me.rb_deduct.UseVisualStyleBackColor = True
        '
        'rb_add
        '
        Me.rb_add.AutoSize = True
        Me.rb_add.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.rb_add.Location = New System.Drawing.Point(106, 322)
        Me.rb_add.Name = "rb_add"
        Me.rb_add.Size = New System.Drawing.Size(65, 19)
        Me.rb_add.TabIndex = 114
        Me.rb_add.TabStop = True
        Me.rb_add.Text = "Add Up"
        Me.rb_add.UseVisualStyleBackColor = True
        '
        'num_reconcile
        '
        Me.num_reconcile.DecimalPlaces = 2
        Me.num_reconcile.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.num_reconcile.Location = New System.Drawing.Point(106, 289)
        Me.num_reconcile.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.num_reconcile.Name = "num_reconcile"
        Me.num_reconcile.Size = New System.Drawing.Size(96, 21)
        Me.num_reconcile.TabIndex = 113
        Me.num_reconcile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(106, 195)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_description.Properties.Appearance.Options.UseFont = True
        Me.txt_description.Properties.ReadOnly = True
        Me.txt_description.Properties.UseReadOnlyAppearance = False
        Me.txt_description.Size = New System.Drawing.Size(261, 86)
        Me.txt_description.TabIndex = 110
        '
        'txt_pid
        '
        Me.txt_pid.Enabled = False
        Me.txt_pid.Location = New System.Drawing.Point(106, 123)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_pid.Properties.Appearance.Options.UseFont = True
        Me.txt_pid.Size = New System.Drawing.Size(137, 30)
        Me.txt_pid.TabIndex = 108
        '
        'cbb_stores
        '
        Me.cbb_stores.Location = New System.Drawing.Point(106, 87)
        Me.cbb_stores.Name = "cbb_stores"
        Me.cbb_stores.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.cbb_stores.Properties.Appearance.Options.UseFont = True
        Me.cbb_stores.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_stores.Size = New System.Drawing.Size(261, 30)
        Me.cbb_stores.TabIndex = 107
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
        Me.btn_cancel.Location = New System.Drawing.Point(19, 421)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(171, 46)
        Me.btn_cancel.TabIndex = 112
        Me.btn_cancel.Text = "Cancel"
        '
        'lbl_title
        '
        Me.lbl_title.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Appearance.Options.UseFont = True
        Me.lbl_title.Appearance.Options.UseForeColor = True
        Me.lbl_title.Location = New System.Drawing.Point(19, 22)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(226, 31)
        Me.lbl_title.TabIndex = 113
        Me.lbl_title.Text = "New Reconcilation"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(18, 93)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl8.TabIndex = 120
        Me.LabelControl8.Text = "Warehouse"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(18, 202)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(68, 16)
        Me.LabelControl1.TabIndex = 121
        Me.LabelControl1.Text = "Description"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(18, 165)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(38, 16)
        Me.LabelControl3.TabIndex = 122
        Me.LabelControl3.Text = "Model"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(18, 129)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl4.TabIndex = 123
        Me.LabelControl4.Text = "Product ID"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(18, 356)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl5.TabIndex = 124
        Me.LabelControl5.Text = "Notes"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(18, 325)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl6.TabIndex = 125
        Me.LabelControl6.Text = "Type"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(18, 290)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(87, 16)
        Me.LabelControl7.TabIndex = 126
        Me.LabelControl7.Text = "Reconcile Qty."
        '
        'frm_warehouse_stock_reconcile_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 479)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.cbb_model)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_memo)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.rb_deduct)
        Me.Controls.Add(Me.rb_add)
        Me.Controls.Add(Me.num_reconcile)
        Me.Controls.Add(Me.txt_description)
        Me.Controls.Add(Me.cbb_stores)
        Me.Controls.Add(Me.txt_pid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stock_reconcile_new.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frm_warehouse_stock_reconcile_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reconcilation"
        CType(Me.cbb_model.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_memo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num_reconcile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_stores.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cbb_stores As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents rb_deduct As RadioButton
    Friend WithEvents rb_add As RadioButton
    Friend WithEvents num_reconcile As NumericUpDown
    Friend WithEvents txt_memo As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cbb_model As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents lbl_title As LabelControl
    Friend WithEvents LabelControl8 As LabelControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents LabelControl5 As LabelControl
    Friend WithEvents LabelControl6 As LabelControl
    Friend WithEvents LabelControl7 As LabelControl
End Class
