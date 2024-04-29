Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_import
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_path = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_choose = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_download = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_import = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.ProgressBar = New DevExpress.XtraEditors.ProgressBarControl()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.cbb_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.ce_qty = New DevExpress.XtraEditors.CheckEdit()
        Me.ce_loc1 = New DevExpress.XtraEditors.CheckEdit()
        Me.ce_loc2 = New DevExpress.XtraEditors.CheckEdit()
        Me.ce_zone = New DevExpress.XtraEditors.CheckEdit()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.txt_path.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProgressBar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ce_qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ce_loc1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ce_loc2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ce_zone.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 15.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(29, 18)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(155, 30)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Import Inventory"
        '
        'txt_path
        '
        Me.txt_path.Location = New System.Drawing.Point(29, 101)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(321, 30)
        Me.txt_path.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(29, 78)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(133, 16)
        Me.LabelControl2.TabIndex = 2
        Me.LabelControl2.Text = "Select Excel file (.xlsx):"
        '
        'btn_choose
        '
        Me.btn_choose.Location = New System.Drawing.Point(359, 100)
        Me.btn_choose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(100, 36)
        Me.btn_choose.TabIndex = 11
        Me.btn_choose.Text = "Choose File"
        '
        'btn_download
        '
        Me.btn_download.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.download_16x16
        Me.btn_download.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_download.Location = New System.Drawing.Point(275, 28)
        Me.btn_download.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(184, 37)
        Me.btn_download.TabIndex = 17
        Me.btn_download.Text = "Download Template"
        '
        'btn_import
        '
        Me.btn_import.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_import.Appearance.Options.UseBackColor = True
        Me.btn_import.Location = New System.Drawing.Point(323, 438)
        Me.btn_import.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_import.Name = "btn_import"
        Me.btn_import.Size = New System.Drawing.Size(136, 33)
        Me.btn_import.TabIndex = 21
        Me.btn_import.Text = "Import"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(29, 226)
        Me.txt_status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_status.Multiline = True
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_status.Size = New System.Drawing.Size(428, 133)
        Me.txt_status.TabIndex = 19
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(29, 190)
        Me.ProgressBar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(429, 26)
        Me.ProgressBar.TabIndex = 22
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'cbb_warehouse
        '
        Me.cbb_warehouse.Location = New System.Drawing.Point(183, 144)
        Me.cbb_warehouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_warehouse.Name = "cbb_warehouse"
        Me.cbb_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_warehouse.Size = New System.Drawing.Size(276, 30)
        Me.cbb_warehouse.TabIndex = 23
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(29, 153)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(116, 16)
        Me.LabelControl3.TabIndex = 24
        Me.LabelControl3.Text = "Target Warehouse:"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(29, 372)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(127, 16)
        Me.LabelControl4.TabIndex = 26
        Me.LabelControl4.Text = "Select affected fields:"
        '
        'ce_qty
        '
        Me.ce_qty.Location = New System.Drawing.Point(35, 395)
        Me.ce_qty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ce_qty.Name = "ce_qty"
        Me.ce_qty.Properties.Appearance.ForeColor = System.Drawing.Color.Red
        Me.ce_qty.Properties.Appearance.Options.UseForeColor = True
        Me.ce_qty.Properties.Caption = "Quantity"
        Me.ce_qty.Size = New System.Drawing.Size(100, 22)
        Me.ce_qty.TabIndex = 27
        '
        'ce_loc1
        '
        Me.ce_loc1.EditValue = True
        Me.ce_loc1.Location = New System.Drawing.Point(143, 395)
        Me.ce_loc1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ce_loc1.Name = "ce_loc1"
        Me.ce_loc1.Properties.Caption = "Location 1"
        Me.ce_loc1.Size = New System.Drawing.Size(100, 22)
        Me.ce_loc1.TabIndex = 28
        '
        'ce_loc2
        '
        Me.ce_loc2.EditValue = True
        Me.ce_loc2.Location = New System.Drawing.Point(251, 395)
        Me.ce_loc2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ce_loc2.Name = "ce_loc2"
        Me.ce_loc2.Properties.Caption = "Location 2"
        Me.ce_loc2.Size = New System.Drawing.Size(100, 22)
        Me.ce_loc2.TabIndex = 29
        '
        'ce_zone
        '
        Me.ce_zone.EditValue = True
        Me.ce_zone.Location = New System.Drawing.Point(359, 395)
        Me.ce_zone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ce_zone.Name = "ce_zone"
        Me.ce_zone.Properties.Caption = "Zone"
        Me.ce_zone.Size = New System.Drawing.Size(100, 22)
        Me.ce_zone.TabIndex = 30
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(179, 438)
        Me.btn_cancel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(136, 33)
        Me.btn_cancel.TabIndex = 31
        Me.btn_cancel.Text = "Cancel"
        '
        'frm_warehouse_import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 486)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.ce_zone)
        Me.Controls.Add(Me.ce_loc2)
        Me.Controls.Add(Me.ce_loc1)
        Me.Controls.Add(Me.ce_qty)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.cbb_warehouse)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.btn_import)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.btn_choose)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Image = Global.Inventory_Management.My.Resources.Resources.up_16x161
        Me.LookAndFeel.SkinName = "WXI"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_warehouse_import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        CType(Me.txt_path.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProgressBar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ce_qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ce_loc1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ce_loc2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ce_zone.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents txt_path As TextEdit
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents btn_choose As SimpleButton
    Friend WithEvents btn_download As SimpleButton
    Friend WithEvents btn_import As SimpleButton
    Friend WithEvents txt_status As TextBox
    Friend WithEvents ProgressBar As ProgressBarControl
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents cbb_warehouse As ComboBoxEdit
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents ce_qty As CheckEdit
    Friend WithEvents ce_loc1 As CheckEdit
    Friend WithEvents ce_loc2 As CheckEdit
    Friend WithEvents ce_zone As CheckEdit
    Friend WithEvents btn_cancel As SimpleButton
End Class
