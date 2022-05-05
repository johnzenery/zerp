<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_barcode_generator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_barcode_generator))
        Me.GunaPanel4 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.rb_per_unit = New System.Windows.Forms.RadioButton()
        Me.rb_per_receipt = New System.Windows.Forms.RadioButton()
        Me.txt_pid = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_po_no = New System.Windows.Forms.TextBox()
        Me.txt_receipt_ref = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_qty = New System.Windows.Forms.NumericUpDown()
        Me.btn_close = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_generate = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_unit = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_printers = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbb_type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GunaPanel4.SuspendLayout()
        CType(Me.txt_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_unit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_printers.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel4
        '
        Me.GunaPanel4.BackColor = System.Drawing.Color.GhostWhite
        Me.GunaPanel4.Controls.Add(Me.GunaLabel2)
        Me.GunaPanel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.GunaPanel4.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel4.Name = "GunaPanel4"
        Me.GunaPanel4.Size = New System.Drawing.Size(336, 61)
        Me.GunaPanel4.TabIndex = 26
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel2.Location = New System.Drawing.Point(12, 14)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(244, 31)
        Me.GunaLabel2.TabIndex = 1
        Me.GunaLabel2.Text = "Barcode Generator"
        '
        'rb_per_unit
        '
        Me.rb_per_unit.AutoSize = True
        Me.rb_per_unit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_per_unit.Location = New System.Drawing.Point(17, 84)
        Me.rb_per_unit.Name = "rb_per_unit"
        Me.rb_per_unit.Size = New System.Drawing.Size(72, 20)
        Me.rb_per_unit.TabIndex = 27
        Me.rb_per_unit.TabStop = True
        Me.rb_per_unit.Text = "Per Unit"
        Me.rb_per_unit.UseVisualStyleBackColor = True
        '
        'rb_per_receipt
        '
        Me.rb_per_receipt.AutoSize = True
        Me.rb_per_receipt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_per_receipt.Location = New System.Drawing.Point(17, 180)
        Me.rb_per_receipt.Name = "rb_per_receipt"
        Me.rb_per_receipt.Size = New System.Drawing.Size(96, 20)
        Me.rb_per_receipt.TabIndex = 28
        Me.rb_per_receipt.TabStop = True
        Me.rb_per_receipt.Text = "Per Receipt"
        Me.rb_per_receipt.UseVisualStyleBackColor = True
        '
        'txt_pid
        '
        Me.txt_pid.Enabled = False
        Me.txt_pid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pid.Location = New System.Drawing.Point(239, 110)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Size = New System.Drawing.Size(83, 22)
        Me.txt_pid.TabIndex = 30
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Model"
        '
        'txt_po_no
        '
        Me.txt_po_no.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_po_no.Location = New System.Drawing.Point(37, 229)
        Me.txt_po_no.Name = "txt_po_no"
        Me.txt_po_no.Size = New System.Drawing.Size(76, 22)
        Me.txt_po_no.TabIndex = 32
        '
        'txt_receipt_ref
        '
        Me.txt_receipt_ref.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_receipt_ref.Location = New System.Drawing.Point(203, 229)
        Me.txt_receipt_ref.Name = "txt_receipt_ref"
        Me.txt_receipt_ref.Size = New System.Drawing.Size(115, 22)
        Me.txt_receipt_ref.TabIndex = 33
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 16)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "PO No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(200, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Receipt Ref."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(34, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(27, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Qty"
        '
        'txt_qty
        '
        Me.txt_qty.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_qty.Location = New System.Drawing.Point(84, 140)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(82, 22)
        Me.txt_qty.TabIndex = 37
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(17, 360)
        Me.btn_close.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_close.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(301, 32)
        Me.btn_close.TabIndex = 38
        Me.btn_close.Text = "Close"
        '
        'btn_generate
        '
        Me.btn_generate.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btn_generate.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.btn_generate.Appearance.Options.UseBackColor = True
        Me.btn_generate.Appearance.Options.UseFont = True
        Me.btn_generate.Location = New System.Drawing.Point(17, 308)
        Me.btn_generate.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_generate.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(301, 46)
        Me.btn_generate.TabIndex = 39
        Me.btn_generate.Text = "Generate"
        '
        'txt_unit
        '
        Me.txt_unit.Location = New System.Drawing.Point(84, 110)
        Me.txt_unit.Name = "txt_unit"
        Me.txt_unit.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txt_unit.Properties.Appearance.Options.UseFont = True
        Me.txt_unit.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_unit.Size = New System.Drawing.Size(149, 22)
        Me.txt_unit.TabIndex = 41
        '
        'cbb_printers
        '
        Me.cbb_printers.Location = New System.Drawing.Point(107, 270)
        Me.cbb_printers.Name = "cbb_printers"
        Me.cbb_printers.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cbb_printers.Properties.Appearance.Options.UseFont = True
        Me.cbb_printers.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_printers.Size = New System.Drawing.Size(211, 22)
        Me.cbb_printers.TabIndex = 42
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Select printer:"
        '
        'cbb_type
        '
        Me.cbb_type.Location = New System.Drawing.Point(119, 229)
        Me.cbb_type.Name = "cbb_type"
        Me.cbb_type.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.cbb_type.Properties.Appearance.Options.UseFont = True
        Me.cbb_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_type.Properties.Items.AddRange(New Object() {"DR", "SI-NV", "SI-VAT", "OR-NV", "OR-VAT"})
        Me.cbb_type.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_type.Size = New System.Drawing.Size(78, 22)
        Me.cbb_type.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(116, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Type"
        '
        'frm_warehouse_barcode_generator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(336, 409)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbb_type)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbb_printers)
        Me.Controls.Add(Me.txt_unit)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_receipt_ref)
        Me.Controls.Add(Me.txt_po_no)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_pid)
        Me.Controls.Add(Me.rb_per_receipt)
        Me.Controls.Add(Me.rb_per_unit)
        Me.Controls.Add(Me.GunaPanel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_barcode_generator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Barcode Generator"
        Me.GunaPanel4.ResumeLayout(False)
        Me.GunaPanel4.PerformLayout()
        CType(Me.txt_qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_unit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_printers.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GunaPanel4 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents rb_per_unit As RadioButton
    Friend WithEvents rb_per_receipt As RadioButton
    Friend WithEvents txt_pid As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_po_no As TextBox
    Friend WithEvents txt_receipt_ref As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_qty As NumericUpDown
    Friend WithEvents btn_close As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_generate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_unit As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents cbb_printers As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label5 As Label
    Friend WithEvents cbb_type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents Label6 As Label
End Class
