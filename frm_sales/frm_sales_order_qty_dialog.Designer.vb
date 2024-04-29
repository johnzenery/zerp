<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_order_qty_dialog
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
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_minus = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_qty = New DevExpress.XtraEditors.SpinEdit()
        CType(Me.txt_qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_add.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_add1
        Me.btn_add.Location = New System.Drawing.Point(195, 12)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(50, 50)
        Me.btn_add.TabIndex = 1
        '
        'btn_minus
        '
        Me.btn_minus.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter
        Me.btn_minus.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_remove
        Me.btn_minus.Location = New System.Drawing.Point(33, 12)
        Me.btn_minus.Name = "btn_minus"
        Me.btn_minus.Size = New System.Drawing.Size(50, 50)
        Me.btn_minus.TabIndex = 2
        '
        'txt_qty
        '
        Me.txt_qty.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_qty.Location = New System.Drawing.Point(89, 10)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 24.0!)
        Me.txt_qty.Properties.Appearance.Options.UseFont = True
        Me.txt_qty.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_qty.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_qty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txt_qty.Properties.MaskSettings.Set("autoHideDecimalSeparator", True)
        Me.txt_qty.Properties.MaxValue = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.txt_qty.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_qty.Size = New System.Drawing.Size(100, 54)
        Me.txt_qty.TabIndex = 3
        '
        'frm_sales_order_qty_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(279, 76)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.btn_minus)
        Me.Controls.Add(Me.btn_add)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.LookAndFeel.SkinName = "WXI"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "frm_sales_order_qty_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quantity Dialog"
        CType(Me.txt_qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_minus As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_qty As DevExpress.XtraEditors.SpinEdit
End Class
