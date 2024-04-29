<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock_return_print
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
        Me.se_qty = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_model = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_rid = New DevExpress.XtraEditors.TextEdit()
        Me.tab = New DevExpress.XtraTab.XtraTabControl()
        Me.tab_single = New DevExpress.XtraTab.XtraTabPage()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.se_qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_model.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_rid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab.SuspendLayout()
        Me.tab_single.SuspendLayout()
        Me.SuspendLayout()
        '
        'se_qty
        '
        Me.se_qty.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.se_qty.Location = New System.Drawing.Point(89, 99)
        Me.se_qty.Name = "se_qty"
        Me.se_qty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.se_qty.Properties.MaxValue = New Decimal(New Integer() {100, 0, 0, 0})
        Me.se_qty.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.se_qty.Size = New System.Drawing.Size(100, 28)
        Me.se_qty.TabIndex = 0
        '
        'txt_model
        '
        Me.txt_model.Enabled = False
        Me.txt_model.Location = New System.Drawing.Point(89, 65)
        Me.txt_model.Name = "txt_model"
        Me.txt_model.Size = New System.Drawing.Size(130, 28)
        Me.txt_model.TabIndex = 1
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(22, 72)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Model"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(23, 106)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl4.TabIndex = 6
        Me.LabelControl4.Text = "Quantity"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(22, 22)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 13)
        Me.LabelControl3.TabIndex = 8
        Me.LabelControl3.Text = "Return ID"
        '
        'txt_rid
        '
        Me.txt_rid.Location = New System.Drawing.Point(89, 15)
        Me.txt_rid.Name = "txt_rid"
        Me.txt_rid.Size = New System.Drawing.Size(100, 28)
        Me.txt_rid.TabIndex = 7
        '
        'tab
        '
        Me.tab.Location = New System.Drawing.Point(12, 42)
        Me.tab.Name = "tab"
        Me.tab.SelectedTabPage = Me.tab_single
        Me.tab.Size = New System.Drawing.Size(260, 193)
        Me.tab.TabIndex = 9
        Me.tab.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab_single})
        '
        'tab_single
        '
        Me.tab_single.Controls.Add(Me.txt_rid)
        Me.tab_single.Controls.Add(Me.LabelControl3)
        Me.tab_single.Controls.Add(Me.se_qty)
        Me.tab_single.Controls.Add(Me.txt_model)
        Me.tab_single.Controls.Add(Me.LabelControl4)
        Me.tab_single.Controls.Add(Me.LabelControl1)
        Me.tab_single.Name = "tab_single"
        Me.tab_single.Size = New System.Drawing.Size(258, 162)
        Me.tab_single.Text = "Single Unit"
        '
        'btn_print
        '
        Me.btn_print.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_print.Appearance.Options.UseBackColor = True
        Me.btn_print.Location = New System.Drawing.Point(186, 241)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(86, 29)
        Me.btn_print.TabIndex = 10
        Me.btn_print.Text = "Print"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(88, 24)
        Me.LabelControl5.TabIndex = 133
        Me.LabelControl5.Text = "Print Label"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(94, 241)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(86, 29)
        Me.btn_cancel.TabIndex = 134
        Me.btn_cancel.Text = "Cancel"
        '
        'frm_stock_return_print
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 277)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.tab)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_stock_return_print"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Label"
        CType(Me.se_qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_model.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_rid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tab, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab.ResumeLayout(False)
        Me.tab_single.ResumeLayout(False)
        Me.tab_single.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents se_qty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_model As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_rid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents tab As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab_single As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
End Class
