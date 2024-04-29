<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_store_add
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_store_add))
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_storeaddr = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_storename = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_person_in_charge = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_storeaddr.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_storename.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_person_in_charge.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.LabelControl11.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Appearance.Options.UseForeColor = True
        Me.LabelControl11.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(194, 29)
        Me.LabelControl11.TabIndex = 27
        Me.LabelControl11.Text = "New Store Details"
        '
        'txt_storeaddr
        '
        Me.txt_storeaddr.Location = New System.Drawing.Point(181, 108)
        Me.txt_storeaddr.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_storeaddr.Name = "txt_storeaddr"
        Me.txt_storeaddr.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_storeaddr.Properties.Appearance.Options.UseFont = True
        Me.txt_storeaddr.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_storeaddr.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_storeaddr.Size = New System.Drawing.Size(304, 57)
        Me.txt_storeaddr.TabIndex = 26
        '
        'txt_storename
        '
        Me.txt_storename.Location = New System.Drawing.Point(181, 71)
        Me.txt_storename.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_storename.Name = "txt_storename"
        Me.txt_storename.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_storename.Properties.Appearance.Options.UseFont = True
        Me.txt_storename.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_storename.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_storename.Size = New System.Drawing.Size(304, 28)
        Me.txt_storename.TabIndex = 25
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(24, 110)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(124, 21)
        Me.LabelControl2.TabIndex = 24
        Me.LabelControl2.Text = "* Store Address:"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 75)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(107, 21)
        Me.LabelControl1.TabIndex = 23
        Me.LabelControl1.Text = "* Store Name:"
        '
        'txt_person_in_charge
        '
        Me.txt_person_in_charge.Location = New System.Drawing.Point(181, 172)
        Me.txt_person_in_charge.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_person_in_charge.Name = "txt_person_in_charge"
        Me.txt_person_in_charge.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.txt_person_in_charge.Properties.Appearance.Options.UseFont = True
        Me.txt_person_in_charge.Properties.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.txt_person_in_charge.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.txt_person_in_charge.Size = New System.Drawing.Size(304, 28)
        Me.txt_person_in_charge.TabIndex = 29
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(24, 176)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(147, 21)
        Me.LabelControl3.TabIndex = 28
        Me.LabelControl3.Text = "* Person-in-Charge:"
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Location = New System.Drawing.Point(397, 215)
        Me.btn_save.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_save.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(88, 34)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "Save"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Location = New System.Drawing.Point(301, 215)
        Me.btn_cancel.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_cancel.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(88, 34)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "Cancel"
        '
        'frm_admin_store_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 262)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_person_in_charge)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.txt_storeaddr)
        Me.Controls.Add(Me.txt_storename)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_admin_store_add.IconOptions.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frm_admin_store_add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Store"
        CType(Me.txt_storeaddr.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_storename.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_person_in_charge.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_storeaddr As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents txt_storename As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_person_in_charge As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
End Class
