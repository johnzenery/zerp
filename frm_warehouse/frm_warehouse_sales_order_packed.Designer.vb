
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_sales_order_packed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_sales_order_packed))
        Me.txt_priv_comment = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_orderid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_agent = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_packed = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pub_comment = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_box_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_plastic_no = New DevExpress.XtraEditors.TextEdit()
        Me.txt_rolls_no = New DevExpress.XtraEditors.TextEdit()
        Me.txt_prepared_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_checked_packed_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_priv_comment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_orderid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_agent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pub_comment.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_box_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_plastic_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_rolls_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_checked_packed_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_priv_comment
        '
        Me.txt_priv_comment.Location = New System.Drawing.Point(14, 151)
        Me.txt_priv_comment.Name = "txt_priv_comment"
        Me.txt_priv_comment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.8!)
        Me.txt_priv_comment.Properties.Appearance.Options.UseFont = True
        Me.txt_priv_comment.Size = New System.Drawing.Size(403, 50)
        Me.txt_priv_comment.TabIndex = 0
        '
        'txt_orderid
        '
        Me.txt_orderid.Location = New System.Drawing.Point(103, 5)
        Me.txt_orderid.Name = "txt_orderid"
        Me.txt_orderid.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_orderid.Properties.Appearance.Options.UseFont = True
        Me.txt_orderid.Properties.ReadOnly = True
        Me.txt_orderid.Properties.UseReadOnlyAppearance = False
        Me.txt_orderid.Size = New System.Drawing.Size(90, 30)
        Me.txt_orderid.TabIndex = 50
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(14, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 16)
        Me.LabelControl3.TabIndex = 49
        Me.LabelControl3.Text = "Order No."
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(103, 41)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_customer.Properties.Appearance.Options.UseFont = True
        Me.txt_customer.Properties.ReadOnly = True
        Me.txt_customer.Properties.UseReadOnlyAppearance = False
        Me.txt_customer.Size = New System.Drawing.Size(188, 30)
        Me.txt_customer.TabIndex = 52
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(14, 48)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl2.TabIndex = 51
        Me.LabelControl2.Text = "Customer"
        '
        'txt_agent
        '
        Me.txt_agent.Location = New System.Drawing.Point(103, 77)
        Me.txt_agent.Name = "txt_agent"
        Me.txt_agent.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_agent.Properties.Appearance.Options.UseFont = True
        Me.txt_agent.Properties.ReadOnly = True
        Me.txt_agent.Properties.UseReadOnlyAppearance = False
        Me.txt_agent.Size = New System.Drawing.Size(188, 30)
        Me.txt_agent.TabIndex = 54
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(14, 84)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 16)
        Me.LabelControl4.TabIndex = 53
        Me.LabelControl4.Text = "Sales Agent"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(14, 127)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(103, 16)
        Me.LabelControl5.TabIndex = 55
        Me.LabelControl5.Text = "Private Comment"
        '
        'btn_packed
        '
        Me.btn_packed.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_packed.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_packed.Appearance.Options.UseBackColor = True
        Me.btn_packed.Appearance.Options.UseFont = True
        Me.btn_packed.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.[True]
        Me.btn_packed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_packed.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.check
        Me.btn_packed.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_packed.Location = New System.Drawing.Point(218, 437)
        Me.btn_packed.Name = "btn_packed"
        Me.btn_packed.Size = New System.Drawing.Size(195, 46)
        Me.btn_packed.TabIndex = 2
        Me.btn_packed.Text = "Mark as Packed"
        '
        'btn_print
        '
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        Me.btn_print.Location = New System.Drawing.Point(313, 24)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(100, 100)
        Me.btn_print.TabIndex = 1
        Me.btn_print.Text = "Print" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Packing List"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 209)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(98, 16)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Public Comment"
        '
        'txt_pub_comment
        '
        Me.txt_pub_comment.Location = New System.Drawing.Point(14, 231)
        Me.txt_pub_comment.Name = "txt_pub_comment"
        Me.txt_pub_comment.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.8!)
        Me.txt_pub_comment.Properties.Appearance.Options.UseFont = True
        Me.txt_pub_comment.Size = New System.Drawing.Size(403, 50)
        Me.txt_pub_comment.TabIndex = 58
        '
        'txt_box_no
        '
        Me.txt_box_no.Location = New System.Drawing.Point(82, 305)
        Me.txt_box_no.Name = "txt_box_no"
        Me.txt_box_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_box_no.Properties.Appearance.Options.UseFont = True
        Me.txt_box_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_box_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_box_no.Size = New System.Drawing.Size(40, 30)
        Me.txt_box_no.TabIndex = 60
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(14, 312)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl6.TabIndex = 61
        Me.LabelControl6.Text = "No. of Box"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(152, 312)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(78, 16)
        Me.LabelControl7.TabIndex = 62
        Me.LabelControl7.Text = "No. of Plastic"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(302, 312)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(69, 16)
        Me.LabelControl8.TabIndex = 63
        Me.LabelControl8.Text = "No. of Rolls"
        '
        'txt_plastic_no
        '
        Me.txt_plastic_no.Location = New System.Drawing.Point(236, 305)
        Me.txt_plastic_no.Name = "txt_plastic_no"
        Me.txt_plastic_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_plastic_no.Properties.Appearance.Options.UseFont = True
        Me.txt_plastic_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_plastic_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_plastic_no.Size = New System.Drawing.Size(40, 30)
        Me.txt_plastic_no.TabIndex = 64
        '
        'txt_rolls_no
        '
        Me.txt_rolls_no.Location = New System.Drawing.Point(377, 305)
        Me.txt_rolls_no.Name = "txt_rolls_no"
        Me.txt_rolls_no.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_rolls_no.Properties.Appearance.Options.UseFont = True
        Me.txt_rolls_no.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_rolls_no.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_rolls_no.Size = New System.Drawing.Size(40, 30)
        Me.txt_rolls_no.TabIndex = 65
        '
        'txt_prepared_by
        '
        Me.txt_prepared_by.Location = New System.Drawing.Point(169, 348)
        Me.txt_prepared_by.Name = "txt_prepared_by"
        Me.txt_prepared_by.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_prepared_by.Properties.Appearance.Options.UseFont = True
        Me.txt_prepared_by.Size = New System.Drawing.Size(244, 30)
        Me.txt_prepared_by.TabIndex = 67
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(14, 355)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(80, 16)
        Me.LabelControl9.TabIndex = 66
        Me.LabelControl9.Text = "*Prepared by"
        '
        'txt_checked_packed_by
        '
        Me.txt_checked_packed_by.Location = New System.Drawing.Point(169, 384)
        Me.txt_checked_packed_by.Name = "txt_checked_packed_by"
        Me.txt_checked_packed_by.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_checked_packed_by.Properties.Appearance.Options.UseFont = True
        Me.txt_checked_packed_by.Size = New System.Drawing.Size(244, 30)
        Me.txt_checked_packed_by.TabIndex = 69
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(14, 391)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(70, 16)
        Me.LabelControl10.TabIndex = 68
        Me.LabelControl10.Text = "*Packed by"
        '
        'btn_close
        '
        Me.btn_close.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btn_close.Appearance.Options.UseFont = True
        Me.btn_close.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_close.Location = New System.Drawing.Point(14, 437)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(195, 46)
        Me.btn_close.TabIndex = 70
        Me.btn_close.Text = "Close"
        '
        'frm_warehouse_sales_order_packed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 497)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_checked_packed_by)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.txt_prepared_by)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.txt_rolls_no)
        Me.Controls.Add(Me.txt_plastic_no)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.txt_box_no)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_pub_comment)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_agent)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_orderid)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_packed)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.txt_priv_comment)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_sales_order_packed.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_sales_order_packed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Packing List"
        CType(Me.txt_priv_comment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_orderid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_agent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pub_comment.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_box_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_plastic_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_rolls_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_checked_packed_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_packed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_orderid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_agent As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_priv_comment As MemoEdit
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents txt_pub_comment As MemoEdit
    Friend WithEvents txt_box_no As TextEdit
    Friend WithEvents LabelControl6 As LabelControl
    Friend WithEvents LabelControl7 As LabelControl
    Friend WithEvents LabelControl8 As LabelControl
    Friend WithEvents txt_plastic_no As TextEdit
    Friend WithEvents txt_rolls_no As TextEdit
    Friend WithEvents txt_prepared_by As TextEdit
    Friend WithEvents LabelControl9 As LabelControl
    Friend WithEvents txt_checked_packed_by As TextEdit
    Friend WithEvents LabelControl10 As LabelControl
    Friend WithEvents btn_close As SimpleButton
End Class
