<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_cancel_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stocktransfer_cancel_dialog))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_status = New System.Windows.Forms.Label()
        Me.lbl_transfer_type = New System.Windows.Forms.Label()
        Me.lbl_stock_transfer_id = New System.Windows.Forms.Label()
        Me.lbl_sub_transfer_id = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ok = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sub Transfer ID"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Transfer ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Transfer Type"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Status"
        '
        'lbl_status
        '
        Me.lbl_status.AutoSize = True
        Me.lbl_status.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_status.Location = New System.Drawing.Point(132, 119)
        Me.lbl_status.Name = "lbl_status"
        Me.lbl_status.Size = New System.Drawing.Size(45, 15)
        Me.lbl_status.TabIndex = 7
        Me.lbl_status.Text = "Label5"
        '
        'lbl_transfer_type
        '
        Me.lbl_transfer_type.AutoSize = True
        Me.lbl_transfer_type.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_transfer_type.Location = New System.Drawing.Point(132, 92)
        Me.lbl_transfer_type.Name = "lbl_transfer_type"
        Me.lbl_transfer_type.Size = New System.Drawing.Size(45, 15)
        Me.lbl_transfer_type.TabIndex = 6
        Me.lbl_transfer_type.Text = "Label6"
        '
        'lbl_stock_transfer_id
        '
        Me.lbl_stock_transfer_id.AutoSize = True
        Me.lbl_stock_transfer_id.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_stock_transfer_id.Location = New System.Drawing.Point(132, 62)
        Me.lbl_stock_transfer_id.Name = "lbl_stock_transfer_id"
        Me.lbl_stock_transfer_id.Size = New System.Drawing.Size(45, 15)
        Me.lbl_stock_transfer_id.TabIndex = 5
        Me.lbl_stock_transfer_id.Text = "Label7"
        '
        'lbl_sub_transfer_id
        '
        Me.lbl_sub_transfer_id.AutoSize = True
        Me.lbl_sub_transfer_id.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_sub_transfer_id.Location = New System.Drawing.Point(132, 34)
        Me.lbl_sub_transfer_id.Name = "lbl_sub_transfer_id"
        Me.lbl_sub_transfer_id.Size = New System.Drawing.Size(45, 15)
        Me.lbl_sub_transfer_id.TabIndex = 4
        Me.lbl_sub_transfer_id.Text = "Label8"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(12, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(193, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Press 'OK' to confirm cancellation."
        '
        'btn_cancel
        '
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.Location = New System.Drawing.Point(15, 190)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(102, 46)
        Me.btn_cancel.TabIndex = 11
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_ok
        '
        Me.btn_ok.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_ok.Appearance.Options.UseBackColor = True
        Me.btn_ok.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_ok.Location = New System.Drawing.Point(121, 190)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(102, 46)
        Me.btn_ok.TabIndex = 12
        Me.btn_ok.Text = "OK"
        '
        'frm_warehouse_stocktransfer_cancel_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 248)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_status)
        Me.Controls.Add(Me.lbl_transfer_type)
        Me.Controls.Add(Me.lbl_stock_transfer_id)
        Me.Controls.Add(Me.lbl_sub_transfer_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stocktransfer_cancel_dialog.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_stocktransfer_cancel_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cancellation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_status As Label
    Friend WithEvents lbl_transfer_type As Label
    Friend WithEvents lbl_stock_transfer_id As Label
    Friend WithEvents lbl_sub_transfer_id As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ok As DevExpress.XtraEditors.SimpleButton
End Class
