<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_dispatch_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stocktransfer_dispatch_dialog))
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_dispatch = New DevExpress.XtraEditors.SimpleButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_driver = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_count_by = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_prepared_by = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_transfer_id = New DevExpress.XtraEditors.TextEdit()
        CType(Me.txt_driver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_print
        '
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 5
        Me.btn_print.Location = New System.Drawing.Point(196, 7)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(54, 30)
        Me.btn_print.TabIndex = 83
        Me.btn_print.Text = "List"
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
        Me.btn_cancel.Location = New System.Drawing.Point(18, 155)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(111, 41)
        Me.btn_cancel.TabIndex = 82
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_dispatch
        '
        Me.btn_dispatch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dispatch.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_dispatch.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dispatch.Appearance.Options.UseBackColor = True
        Me.btn_dispatch.Appearance.Options.UseFont = True
        Me.btn_dispatch.Appearance.Options.UseTextOptions = True
        Me.btn_dispatch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_dispatch.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_dispatch.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_dispatch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_dispatch.ImageOptions.ImageToTextIndent = 8
        Me.btn_dispatch.Location = New System.Drawing.Point(135, 155)
        Me.btn_dispatch.Name = "btn_dispatch"
        Me.btn_dispatch.Size = New System.Drawing.Size(115, 41)
        Me.btn_dispatch.TabIndex = 81
        Me.btn_dispatch.Text = "Dispatch"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(15, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Driver"
        '
        'txt_driver
        '
        Me.txt_driver.Location = New System.Drawing.Point(117, 115)
        Me.txt_driver.Name = "txt_driver"
        Me.txt_driver.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txt_driver.Properties.Appearance.Options.UseFont = True
        Me.txt_driver.Size = New System.Drawing.Size(133, 30)
        Me.txt_driver.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(15, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Checked By"
        '
        'txt_count_by
        '
        Me.txt_count_by.Location = New System.Drawing.Point(117, 79)
        Me.txt_count_by.Name = "txt_count_by"
        Me.txt_count_by.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txt_count_by.Properties.Appearance.Options.UseFont = True
        Me.txt_count_by.Properties.ReadOnly = True
        Me.txt_count_by.Size = New System.Drawing.Size(133, 30)
        Me.txt_count_by.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Prepared By"
        '
        'txt_prepared_by
        '
        Me.txt_prepared_by.Location = New System.Drawing.Point(117, 43)
        Me.txt_prepared_by.Name = "txt_prepared_by"
        Me.txt_prepared_by.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txt_prepared_by.Properties.Appearance.Options.UseFont = True
        Me.txt_prepared_by.Properties.ReadOnly = True
        Me.txt_prepared_by.Size = New System.Drawing.Size(133, 30)
        Me.txt_prepared_by.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(15, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sub-Transfer ID"
        '
        'txt_transfer_id
        '
        Me.txt_transfer_id.Enabled = False
        Me.txt_transfer_id.Location = New System.Drawing.Point(117, 7)
        Me.txt_transfer_id.Name = "txt_transfer_id"
        Me.txt_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.txt_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_transfer_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_transfer_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_transfer_id.Properties.ReadOnly = True
        Me.txt_transfer_id.Size = New System.Drawing.Size(77, 30)
        Me.txt_transfer_id.TabIndex = 0
        '
        'frm_warehouse_stocktransfer_dispatch_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(262, 206)
        Me.Controls.Add(Me.btn_print)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_dispatch)
        Me.Controls.Add(Me.txt_transfer_id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_prepared_by)
        Me.Controls.Add(Me.txt_driver)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_count_by)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stocktransfer_dispatch_dialog.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_stocktransfer_dispatch_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dispatch Dialog"
        CType(Me.txt_driver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_count_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_prepared_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_transfer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_driver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_count_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_prepared_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_dispatch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
End Class
