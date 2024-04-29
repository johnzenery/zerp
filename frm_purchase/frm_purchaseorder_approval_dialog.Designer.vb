<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchaseorder_approval_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_purchaseorder_approval_dialog))
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reject = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'btn_approved
        '
        Me.btn_approved.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_approved.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_approved.Appearance.Options.UseBackColor = True
        Me.btn_approved.Appearance.Options.UseFont = True
        Me.btn_approved.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btn_approved.Location = New System.Drawing.Point(23, 55)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(166, 39)
        Me.btn_approved.TabIndex = 0
        Me.btn_approved.Text = "Approve"
        '
        'btn_reject
        '
        Me.btn_reject.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_reject.Appearance.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold)
        Me.btn_reject.Appearance.Options.UseBackColor = True
        Me.btn_reject.Appearance.Options.UseFont = True
        Me.btn_reject.DialogResult = System.Windows.Forms.DialogResult.No
        Me.btn_reject.Location = New System.Drawing.Point(23, 100)
        Me.btn_reject.Name = "btn_reject"
        Me.btn_reject.Size = New System.Drawing.Size(166, 39)
        Me.btn_reject.TabIndex = 1
        Me.btn_reject.Text = "Reject"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(34, 25)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(145, 13)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Action for this Purchase Order"
        '
        'frm_purchaseorder_approval_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 162)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_reject)
        Me.Controls.Add(Me.btn_approved)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_purchaseorder_approval_dialog.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_purchaseorder_approval_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Approval Dialog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reject As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
