<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_homepage
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_homepage))
        Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
        Me.txt_quotes = New DevExpress.XtraEditors.LabelControl()
        Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
        Me.txt_welcome = New DevExpress.XtraEditors.LabelControl()
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelControl1.SuspendLayout()
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelControl1
        '
        Me.PanelControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PanelControl1.Controls.Add(Me.txt_welcome)
        Me.PanelControl1.Controls.Add(Me.PictureEdit2)
        Me.PanelControl1.Controls.Add(Me.txt_quotes)
        Me.PanelControl1.Location = New System.Drawing.Point(140, 121)
        Me.PanelControl1.Name = "PanelControl1"
        Me.PanelControl1.Size = New System.Drawing.Size(866, 510)
        Me.PanelControl1.TabIndex = 1
        '
        'txt_quotes
        '
        Me.txt_quotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_quotes.Appearance.Font = New System.Drawing.Font("Calibri Light", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_quotes.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_quotes.Appearance.Options.UseFont = True
        Me.txt_quotes.Appearance.Options.UseForeColor = True
        Me.txt_quotes.Appearance.Options.UseTextOptions = True
        Me.txt_quotes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_quotes.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_quotes.Location = New System.Drawing.Point(3, 437)
        Me.txt_quotes.Name = "txt_quotes"
        Me.txt_quotes.Size = New System.Drawing.Size(860, 45)
        Me.txt_quotes.TabIndex = 3
        Me.txt_quotes.Text = "Just one small positive thought in the morning can change your whole day." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "- Dala" &
    "i Lama"
        '
        'PictureEdit2
        '
        Me.PictureEdit2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
        Me.PictureEdit2.Location = New System.Drawing.Point(203, 15)
        Me.PictureEdit2.Name = "PictureEdit2"
        Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me.PictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
        Me.PictureEdit2.Size = New System.Drawing.Size(450, 338)
        Me.PictureEdit2.TabIndex = 4
        '
        'txt_welcome
        '
        Me.txt_welcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_welcome.Appearance.Font = New System.Drawing.Font("Calibri Light", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_welcome.Appearance.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.txt_welcome.Appearance.Options.UseFont = True
        Me.txt_welcome.Appearance.Options.UseForeColor = True
        Me.txt_welcome.Appearance.Options.UseTextOptions = True
        Me.txt_welcome.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_welcome.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_welcome.Location = New System.Drawing.Point(3, 365)
        Me.txt_welcome.Name = "txt_welcome"
        Me.txt_welcome.Size = New System.Drawing.Size(860, 45)
        Me.txt_welcome.TabIndex = 5
        Me.txt_welcome.Text = "Yehey! Welcome Back John Zenery"
        '
        'frm_homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 710)
        Me.Controls.Add(Me.PanelControl1)
        Me.Name = "frm_homepage"
        Me.Text = "Welcome"
        CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelControl1.ResumeLayout(False)
        CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
    Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents txt_quotes As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_welcome As DevExpress.XtraEditors.LabelControl
End Class
