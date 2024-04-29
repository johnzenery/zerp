<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_pricetag_generator
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
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_unit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.SpinEdit_qty = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_pid = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txt_unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit_qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btn_print.Appearance.Options.UseBackColor = True
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.Location = New System.Drawing.Point(122, 132)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(104, 34)
        Me.btn_print.TabIndex = 40
        Me.btn_print.Text = "Print"
        '
        'txt_unit
        '
        Me.txt_unit.Location = New System.Drawing.Point(67, 48)
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txt_unit.Properties.Appearance.Options.UseFont = True
        Me.txt_unit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_unit.Size = New System.Drawing.Size(149, 30)
        Me.txt_unit.TabIndex = 44
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Model"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 16)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "PID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 89)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Qty"
        '
        'btn_close
        '
        Me.btn_close.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btn_close.Appearance.Options.UseFont = True
        Me.btn_close.Location = New System.Drawing.Point(12, 132)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(104, 34)
        Me.btn_close.TabIndex = 47
        Me.btn_close.Text = "Close"
        '
        'SpinEdit_qty
        '
        Me.SpinEdit_qty.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit_qty.Location = New System.Drawing.Point(67, 84)
        Me.SpinEdit_qty.Name = "SpinEdit_qty"
        Me.SpinEdit_qty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit_qty.Size = New System.Drawing.Size(100, 28)
        Me.SpinEdit_qty.TabIndex = 48
        '
        'txt_pid
        '
        Me.txt_pid.Location = New System.Drawing.Point(67, 14)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Properties.ReadOnly = True
        Me.txt_pid.Size = New System.Drawing.Size(100, 28)
        Me.txt_pid.TabIndex = 49
        '
        'frm_warehouse_pricetag_generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(238, 178)
        Me.Controls.Add(Me.txt_pid)
        Me.Controls.Add(Me.SpinEdit_qty)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_unit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_print)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_warehouse_pricetag_generator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pricetag "
        CType(Me.txt_unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit_qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_unit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SpinEdit_qty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_pid As DevExpress.XtraEditors.TextEdit
End Class
