<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_transfer_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_transfer_view))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_transfer_id = New DevExpress.XtraEditors.LabelControl()
        Me.btn_approved = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_declined = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_transfer_type = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(110, 22)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Transfer ID"
        '
        'txt_transfer_id
        '
        Me.txt_transfer_id.Appearance.BackColor = System.Drawing.Color.White
        Me.txt_transfer_id.Appearance.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold)
        Me.txt_transfer_id.Appearance.Options.UseBackColor = True
        Me.txt_transfer_id.Appearance.Options.UseFont = True
        Me.txt_transfer_id.Appearance.Options.UseTextOptions = True
        Me.txt_transfer_id.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_transfer_id.AutoEllipsis = True
        Me.txt_transfer_id.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.txt_transfer_id.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.txt_transfer_id.Location = New System.Drawing.Point(35, 44)
        Me.txt_transfer_id.Name = "txt_transfer_id"
        Me.txt_transfer_id.Size = New System.Drawing.Size(207, 32)
        Me.txt_transfer_id.TabIndex = 1
        Me.txt_transfer_id.Text = "ST00000"
        '
        'btn_approved
        '
        Me.btn_approved.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.apply_32x322
        Me.btn_approved.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_approved.Location = New System.Drawing.Point(142, 82)
        Me.btn_approved.Name = "btn_approved"
        Me.btn_approved.Size = New System.Drawing.Size(100, 80)
        Me.btn_approved.TabIndex = 2
        Me.btn_approved.Text = "Approved"
        '
        'btn_declined
        '
        Me.btn_declined.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.cancel_32x32
        Me.btn_declined.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter
        Me.btn_declined.Location = New System.Drawing.Point(35, 82)
        Me.btn_declined.Name = "btn_declined"
        Me.btn_declined.Size = New System.Drawing.Size(100, 80)
        Me.btn_declined.TabIndex = 3
        Me.btn_declined.Text = "Decline"
        '
        'btn_view
        '
        Me.btn_view.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.saledetalis_16x16
        Me.btn_view.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view.Location = New System.Drawing.Point(35, 168)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(207, 45)
        Me.btn_view.TabIndex = 4
        Me.btn_view.Text = "View Units"
        '
        'lbl_transfer_type
        '
        Me.lbl_transfer_type.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lbl_transfer_type.Appearance.Options.UseFont = True
        Me.lbl_transfer_type.Location = New System.Drawing.Point(94, 219)
        Me.lbl_transfer_type.Name = "lbl_transfer_type"
        Me.lbl_transfer_type.Size = New System.Drawing.Size(78, 16)
        Me.lbl_transfer_type.TabIndex = 5
        Me.lbl_transfer_type.Text = "Transfer Type"
        Me.lbl_transfer_type.Visible = False
        '
        'frm_admin_transfer_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(278, 242)
        Me.Controls.Add(Me.lbl_transfer_type)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.btn_declined)
        Me.Controls.Add(Me.btn_approved)
        Me.Controls.Add(Me.txt_transfer_id)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_admin_transfer_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Approval"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_transfer_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_approved As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_declined As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_transfer_type As DevExpress.XtraEditors.LabelControl
End Class
