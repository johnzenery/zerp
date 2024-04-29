<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stock_transfer_packed
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stock_transfer_packed))
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_packed = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_transfer_type = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_prepared_by = New DevExpress.XtraEditors.TextEdit()
        Me.lbl_prepared_by = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_status = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_packed_by = New DevExpress.XtraEditors.LabelControl()
        Me.txt_packed_by = New DevExpress.XtraEditors.TextEdit()
        Me.txt_sub_transfer_id = New DevExpress.XtraEditors.TextEdit()
        Me.txt_transfer_id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txt_transfer_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_status.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_packed_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_sub_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(16, 8)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(95, 16)
        Me.LabelControl3.TabIndex = 51
        Me.LabelControl3.Text = "Root Transfer ID"
        '
        'btn_packed
        '
        Me.btn_packed.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_16x16
        Me.btn_packed.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_packed.Location = New System.Drawing.Point(16, 227)
        Me.btn_packed.Name = "btn_packed"
        Me.btn_packed.Size = New System.Drawing.Size(274, 38)
        Me.btn_packed.TabIndex = 66
        Me.btn_packed.Text = "Mark as Packed"
        '
        'txt_transfer_type
        '
        Me.txt_transfer_type.Location = New System.Drawing.Point(106, 73)
        Me.txt_transfer_type.Name = "txt_transfer_type"
        Me.txt_transfer_type.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_transfer_type.Properties.Appearance.Options.UseFont = True
        Me.txt_transfer_type.Properties.ReadOnly = True
        Me.txt_transfer_type.Properties.UseReadOnlyAppearance = False
        Me.txt_transfer_type.Size = New System.Drawing.Size(184, 30)
        Me.txt_transfer_type.TabIndex = 77
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(16, 80)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(28, 16)
        Me.LabelControl1.TabIndex = 76
        Me.LabelControl1.Text = "Type"
        '
        'txt_prepared_by
        '
        Me.txt_prepared_by.Location = New System.Drawing.Point(106, 143)
        Me.txt_prepared_by.Name = "txt_prepared_by"
        Me.txt_prepared_by.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_prepared_by.Properties.Appearance.Options.UseFont = True
        Me.txt_prepared_by.Size = New System.Drawing.Size(184, 30)
        Me.txt_prepared_by.TabIndex = 78
        '
        'lbl_prepared_by
        '
        Me.lbl_prepared_by.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.lbl_prepared_by.Appearance.Options.UseFont = True
        Me.lbl_prepared_by.Location = New System.Drawing.Point(16, 150)
        Me.lbl_prepared_by.Name = "lbl_prepared_by"
        Me.lbl_prepared_by.Size = New System.Drawing.Size(69, 16)
        Me.lbl_prepared_by.TabIndex = 79
        Me.lbl_prepared_by.Text = "Prepared by"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(16, 41)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(91, 16)
        Me.LabelControl4.TabIndex = 82
        Me.LabelControl4.Text = "Sub Transfer ID"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(106, 107)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_status.Properties.Appearance.Options.UseFont = True
        Me.txt_status.Properties.ReadOnly = True
        Me.txt_status.Properties.UseReadOnlyAppearance = False
        Me.txt_status.Size = New System.Drawing.Size(184, 30)
        Me.txt_status.TabIndex = 84
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(16, 114)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(36, 16)
        Me.LabelControl5.TabIndex = 83
        Me.LabelControl5.Text = "Status"
        '
        'lbl_packed_by
        '
        Me.lbl_packed_by.Appearance.Font = New System.Drawing.Font("Tahoma", 9.749999!)
        Me.lbl_packed_by.Appearance.Options.UseFont = True
        Me.lbl_packed_by.Location = New System.Drawing.Point(16, 186)
        Me.lbl_packed_by.Name = "lbl_packed_by"
        Me.lbl_packed_by.Size = New System.Drawing.Size(57, 16)
        Me.lbl_packed_by.TabIndex = 86
        Me.lbl_packed_by.Text = "Packed by"
        '
        'txt_packed_by
        '
        Me.txt_packed_by.Location = New System.Drawing.Point(106, 179)
        Me.txt_packed_by.Name = "txt_packed_by"
        Me.txt_packed_by.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_packed_by.Properties.Appearance.Options.UseFont = True
        Me.txt_packed_by.Size = New System.Drawing.Size(184, 30)
        Me.txt_packed_by.TabIndex = 85
        '
        'txt_sub_transfer_id
        '
        Me.txt_sub_transfer_id.Location = New System.Drawing.Point(124, 37)
        Me.txt_sub_transfer_id.Name = "txt_sub_transfer_id"
        Me.txt_sub_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_sub_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_sub_transfer_id.Properties.ReadOnly = True
        Me.txt_sub_transfer_id.Properties.UseReadOnlyAppearance = False
        Me.txt_sub_transfer_id.Size = New System.Drawing.Size(118, 30)
        Me.txt_sub_transfer_id.TabIndex = 87
        '
        'txt_transfer_id
        '
        Me.txt_transfer_id.Location = New System.Drawing.Point(124, 1)
        Me.txt_transfer_id.Name = "txt_transfer_id"
        Me.txt_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.txt_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_transfer_id.Properties.ReadOnly = True
        Me.txt_transfer_id.Properties.UseReadOnlyAppearance = False
        Me.txt_transfer_id.Size = New System.Drawing.Size(118, 30)
        Me.txt_transfer_id.TabIndex = 88
        '
        'frm_warehouse_stock_transfer_packed
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 283)
        Me.Controls.Add(Me.txt_transfer_id)
        Me.Controls.Add(Me.txt_sub_transfer_id)
        Me.Controls.Add(Me.lbl_packed_by)
        Me.Controls.Add(Me.txt_packed_by)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.lbl_prepared_by)
        Me.Controls.Add(Me.txt_prepared_by)
        Me.Controls.Add(Me.txt_transfer_type)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_packed)
        Me.Controls.Add(Me.LabelControl3)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stock_transfer_packed.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_stock_transfer_packed"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arrangement Dialog"
        CType(Me.txt_transfer_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_status.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_packed_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_sub_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_packed As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_transfer_type As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_prepared_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lbl_prepared_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_status As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_packed_by As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_packed_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_sub_transfer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_transfer_id As DevExpress.XtraEditors.TextEdit
End Class
