<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_logistics_new
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_logistics_new))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_name = New DevExpress.XtraEditors.TextEdit()
        Me.txt_contact = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_contact_no = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_nearest = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_destinations = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.id = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_contact_no.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_nearest.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_destinations.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(15, 65)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(65, 13)
        Me.LabelControl1.TabIndex = 10
        Me.LabelControl1.Text = "Logistic Name"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(104, 58)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(192, 28)
        Me.txt_name.TabIndex = 11
        '
        'txt_contact
        '
        Me.txt_contact.Location = New System.Drawing.Point(104, 90)
        Me.txt_contact.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_contact.Name = "txt_contact"
        Me.txt_contact.Size = New System.Drawing.Size(192, 28)
        Me.txt_contact.TabIndex = 13
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(15, 97)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl2.TabIndex = 12
        Me.LabelControl2.Text = "Contact Person"
        '
        'txt_contact_no
        '
        Me.txt_contact_no.Location = New System.Drawing.Point(104, 122)
        Me.txt_contact_no.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_contact_no.Name = "txt_contact_no"
        Me.txt_contact_no.Size = New System.Drawing.Size(192, 28)
        Me.txt_contact_no.TabIndex = 15
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(15, 129)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(58, 13)
        Me.LabelControl3.TabIndex = 14
        Me.LabelControl3.Text = "Contact No."
        '
        'txt_nearest
        '
        Me.txt_nearest.Location = New System.Drawing.Point(104, 154)
        Me.txt_nearest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_nearest.Name = "txt_nearest"
        Me.txt_nearest.Size = New System.Drawing.Size(280, 37)
        Me.txt_nearest.TabIndex = 16
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(15, 161)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(74, 13)
        Me.LabelControl4.TabIndex = 17
        Me.LabelControl4.Text = "Nearest Branch"
        '
        'LabelControl5
        '
        Me.LabelControl5.Location = New System.Drawing.Point(15, 202)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl5.TabIndex = 19
        Me.LabelControl5.Text = "Destinations"
        '
        'txt_destinations
        '
        Me.txt_destinations.Location = New System.Drawing.Point(104, 195)
        Me.txt_destinations.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_destinations.Name = "txt_destinations"
        Me.txt_destinations.Size = New System.Drawing.Size(280, 54)
        Me.txt_destinations.TabIndex = 18
        '
        'btn_new
        '
        Me.btn_new.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_new.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_new.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Appearance.Options.UseBackColor = True
        Me.btn_new.Appearance.Options.UseFont = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 5
        Me.btn_new.Location = New System.Drawing.Point(247, 274)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(137, 33)
        Me.btn_new.TabIndex = 20
        Me.btn_new.Text = "Save Record"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 5
        Me.btn_cancel.Location = New System.Drawing.Point(105, 274)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(137, 33)
        Me.btn_cancel.TabIndex = 21
        Me.btn_cancel.Text = "Cancel"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(15, 46)
        Me.id.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(8, 13)
        Me.id.TabIndex = 22
        Me.id.Text = "id"
        Me.id.Visible = False
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Appearance.Options.UseForeColor = True
        Me.LabelControl6.Location = New System.Drawing.Point(15, 9)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(155, 31)
        Me.LabelControl6.TabIndex = 23
        Me.LabelControl6.Text = "New Logistic"
        '
        'frm_sales_logistics_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(396, 316)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_destinations)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_nearest)
        Me.Controls.Add(Me.txt_contact_no)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_contact)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_sales_logistics_new.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sales_logistics_new"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Logisctic"
        CType(Me.txt_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_contact_no.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_nearest.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_destinations.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_contact As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_contact_no As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_nearest As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_destinations As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
End Class
