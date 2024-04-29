<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_approval_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stocktransfer_approval_dialog))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_reject = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_stock_transfer_id = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(40, 35)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(189, 17)
        Me.LabelControl1.TabIndex = 5
        Me.LabelControl1.Text = "Action for this Stock Transfer"
        '
        'btn_reject
        '
        Me.btn_reject.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reject.Appearance.Options.UseFont = True
        Me.btn_reject.Location = New System.Drawing.Point(12, 125)
        Me.btn_reject.Name = "btn_reject"
        Me.btn_reject.Size = New System.Drawing.Size(247, 49)
        Me.btn_reject.TabIndex = 4
        Me.btn_reject.Text = "Reject"
        '
        'btn_approved
        '
        Me.btn_approved.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_approved.Appearance.Options.UseBackColor = True
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.Location = New System.Drawing.Point(12, 70)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(247, 49)
        Me.btn_approved.TabIndex = 3
        Me.btn_approved.Text = "Approve"
        '
        'lbl_stock_transfer_id
        '
        Me.lbl_stock_transfer_id.Appearance.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.lbl_stock_transfer_id.Appearance.Options.UseFont = True
        Me.lbl_stock_transfer_id.Location = New System.Drawing.Point(73, 180)
        Me.lbl_stock_transfer_id.Name = "lbl_stock_transfer_id"
        Me.lbl_stock_transfer_id.Size = New System.Drawing.Size(134, 17)
        Me.lbl_stock_transfer_id.TabIndex = 6
        Me.lbl_stock_transfer_id.Text = "lbl_stock_transfer_id"
        Me.lbl_stock_transfer_id.Visible = False
        '
        'frm_warehouse_stocktransfer_approval_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 201)
        Me.Controls.Add(Me.lbl_stock_transfer_id)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_reject)
        Me.Controls.Add(Me.btn_approved)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stocktransfer_approval_dialog.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_warehouse_stocktransfer_approval_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Response"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_reject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_stock_transfer_id As DevExpress.XtraEditors.LabelControl
End Class
