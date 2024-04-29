<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_start_packing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_start_packing))
        Me.lbl_description = New System.Windows.Forms.Label()
        Me.btn_yes = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_no = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_id = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'lbl_description
        '
        Me.lbl_description.AutoSize = True
        Me.lbl_description.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_description.Location = New System.Drawing.Point(18, 77)
        Me.lbl_description.Name = "lbl_description"
        Me.lbl_description.Size = New System.Drawing.Size(238, 25)
        Me.lbl_description.TabIndex = 0
        Me.lbl_description.Text = "Start to arrange this order?"
        '
        'btn_yes
        '
        Me.btn_yes.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_yes.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_yes.Appearance.Options.UseBackColor = True
        Me.btn_yes.Appearance.Options.UseFont = True
        Me.btn_yes.Location = New System.Drawing.Point(137, 122)
        Me.btn_yes.Name = "btn_yes"
        Me.btn_yes.Size = New System.Drawing.Size(119, 43)
        Me.btn_yes.TabIndex = 1
        Me.btn_yes.Text = "Yes"
        '
        'btn_no
        '
        Me.btn_no.Appearance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_no.Appearance.Options.UseFont = True
        Me.btn_no.Location = New System.Drawing.Point(12, 122)
        Me.btn_no.Name = "btn_no"
        Me.btn_no.Size = New System.Drawing.Size(119, 43)
        Me.btn_no.TabIndex = 2
        Me.btn_no.Text = "No"
        '
        'lbl_id
        '
        Me.lbl_id.Appearance.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold)
        Me.lbl_id.Appearance.Options.UseFont = True
        Me.lbl_id.Appearance.Options.UseTextOptions = True
        Me.lbl_id.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_id.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_id.Location = New System.Drawing.Point(12, 24)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(244, 40)
        Me.lbl_id.TabIndex = 4
        Me.lbl_id.Text = "00000"
        '
        'frm_warehouse_start_packing
        '
        Me.Appearance.Options.UseFont = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(269, 181)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.btn_no)
        Me.Controls.Add(Me.btn_yes)
        Me.Controls.Add(Me.lbl_description)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_start_packing.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_start_packing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrange Order"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_description As Label
    Friend WithEvents btn_yes As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_no As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_id As DevExpress.XtraEditors.LabelControl
End Class
