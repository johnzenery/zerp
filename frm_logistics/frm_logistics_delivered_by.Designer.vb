<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logistics_delivered_by
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_driver = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbb_driver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 27)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(146, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Enter driver's name (optional):"
        '
        'cbb_driver
        '
        Me.cbb_driver.Location = New System.Drawing.Point(12, 46)
        Me.cbb_driver.Name = "cbb_driver"
        Me.cbb_driver.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_driver.Size = New System.Drawing.Size(182, 28)
        Me.cbb_driver.TabIndex = 1
        '
        'btn_submit
        '
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Location = New System.Drawing.Point(97, 82)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(97, 33)
        Me.btn_submit.TabIndex = 2
        Me.btn_submit.Text = "Submit"
        '
        'frm_logistics_delivered_by
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 125)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.cbb_driver)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_logistics_delivered_by"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delivered by"
        CType(Me.cbb_driver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_driver As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
End Class
