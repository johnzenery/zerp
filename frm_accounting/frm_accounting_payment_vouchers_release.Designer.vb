<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_payment_vouchers_release
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
        Me.txt_received_by = New DevExpress.XtraEditors.TextEdit()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.de_released_date = New DevExpress.XtraEditors.DateEdit()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_received_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_released_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.de_released_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(11, 53)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(59, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Received by"
        '
        'txt_received_by
        '
        Me.txt_received_by.Location = New System.Drawing.Point(99, 46)
        Me.txt_received_by.Name = "txt_received_by"
        Me.txt_received_by.Size = New System.Drawing.Size(156, 28)
        Me.txt_received_by.TabIndex = 1
        '
        'btn_submit
        '
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Location = New System.Drawing.Point(180, 120)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(75, 32)
        Me.btn_submit.TabIndex = 2
        Me.btn_submit.Text = "Submit"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(11, 87)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(70, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Date Released"
        '
        'de_released_date
        '
        Me.de_released_date.EditValue = Nothing
        Me.de_released_date.Location = New System.Drawing.Point(99, 80)
        Me.de_released_date.Name = "de_released_date"
        Me.de_released_date.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_released_date.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.de_released_date.Size = New System.Drawing.Size(156, 28)
        Me.de_released_date.TabIndex = 4
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(99, 120)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 32)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(11, 12)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(168, 23)
        Me.LabelControl3.TabIndex = 6
        Me.LabelControl3.Text = "Release Information"
        '
        'frm_accounting_payment_vouchers_release
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(276, 162)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.de_released_date)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.txt_received_by)
        Me.Controls.Add(Me.LabelControl1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_accounting_payment_vouchers_release"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Release"
        CType(Me.txt_received_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_released_date.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.de_released_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_received_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents de_released_date As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
