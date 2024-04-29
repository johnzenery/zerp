<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_printers
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_printers))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbb_printers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.cbb_printers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(121, 16)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Select label printer:"
        '
        'cbb_printers
        '
        Me.cbb_printers.Location = New System.Drawing.Point(15, 41)
        Me.cbb_printers.Name = "cbb_printers"
        Me.cbb_printers.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cbb_printers.Properties.Appearance.Options.UseFont = True
        Me.cbb_printers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_printers.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_printers.Size = New System.Drawing.Size(211, 30)
        Me.cbb_printers.TabIndex = 45
        '
        'btn_print
        '
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.Location = New System.Drawing.Point(137, 77)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(89, 27)
        Me.btn_print.TabIndex = 46
        Me.btn_print.Text = "Apply"
        '
        'frm_printers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(246, 116)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.cbb_printers)
        Me.Controls.Add(Me.Label5)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.IconOptions.Icon = CType(resources.GetObject("frm_printers.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_printers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Label Printer"
        CType(Me.cbb_printers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents cbb_printers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
End Class
