<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_details))
        Me.lbl_more_details = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'lbl_more_details
        '
        Me.lbl_more_details.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_more_details.Appearance.BackColor = System.Drawing.Color.White
        Me.lbl_more_details.Appearance.Options.UseBackColor = True
        Me.lbl_more_details.Appearance.Options.UseTextOptions = True
        Me.lbl_more_details.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top
        Me.lbl_more_details.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_more_details.Location = New System.Drawing.Point(12, 13)
        Me.lbl_more_details.Name = "lbl_more_details"
        Me.lbl_more_details.Padding = New System.Windows.Forms.Padding(10)
        Me.lbl_more_details.Size = New System.Drawing.Size(446, 311)
        Me.lbl_more_details.TabIndex = 2
        Me.lbl_more_details.Text = "LabelControl1"
        '
        'frm_product_details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 336)
        Me.Controls.Add(Me.lbl_more_details)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_product_details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Description"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_more_details As DevExpress.XtraEditors.LabelControl
End Class
