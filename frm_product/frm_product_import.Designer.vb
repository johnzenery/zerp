<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_product_import
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_product_import))
        Me.btn_details = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.btn_choose = New DevExpress.XtraEditors.SimpleButton()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.btn_download = New DevExpress.XtraEditors.SimpleButton()
        Me.BackgroundWorker = New System.ComponentModel.BackgroundWorker()
        Me.btn_upload = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout()
        '
        'btn_details
        '
        Me.btn_details.Location = New System.Drawing.Point(30, 124)
        Me.btn_details.Name = "btn_details"
        Me.btn_details.Size = New System.Drawing.Size(75, 23)
        Me.btn_details.TabIndex = 15
        Me.btn_details.Text = "Show Details"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(30, 129)
        Me.txt_status.Multiline = True
        Me.txt_status.Name = "txt_status"
        Me.txt_status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_status.Size = New System.Drawing.Size(322, 150)
        Me.txt_status.TabIndex = 14
        Me.txt_status.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Excel file (.xlsx):"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 30)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Import Catalogue"
        '
        'txt_path
        '
        Me.txt_path.Enabled = False
        Me.txt_path.Location = New System.Drawing.Point(30, 66)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(241, 21)
        Me.txt_path.TabIndex = 11
        '
        'btn_choose
        '
        Me.btn_choose.Location = New System.Drawing.Point(277, 65)
        Me.btn_choose.Name = "btn_choose"
        Me.btn_choose.Size = New System.Drawing.Size(75, 23)
        Me.btn_choose.TabIndex = 10
        Me.btn_choose.Text = "Choose File"
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(30, 95)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(322, 23)
        Me.ProgressBar.TabIndex = 9
        '
        'btn_download
        '
        Me.btn_download.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.download_16x16
        Me.btn_download.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
        Me.btn_download.Location = New System.Drawing.Point(222, 17)
        Me.btn_download.Name = "btn_download"
        Me.btn_download.Size = New System.Drawing.Size(131, 27)
        Me.btn_download.TabIndex = 16
        Me.btn_download.Text = "Download Template"
        '
        'BackgroundWorker
        '
        Me.BackgroundWorker.WorkerReportsProgress = True
        Me.BackgroundWorker.WorkerSupportsCancellation = True
        '
        'btn_upload
        '
        Me.btn_upload.Location = New System.Drawing.Point(277, 124)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(75, 23)
        Me.btn_upload.TabIndex = 17
        Me.btn_upload.Text = "Import"
        '
        'frm_product_import
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 156)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.btn_download)
        Me.Controls.Add(Me.btn_details)
        Me.Controls.Add(Me.txt_status)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_path)
        Me.Controls.Add(Me.btn_choose)
        Me.Controls.Add(Me.ProgressBar)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_product_import.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_product_import"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Import"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_download As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_details As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_path As TextBox
    Friend WithEvents btn_choose As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents BackgroundWorker As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_upload As DevExpress.XtraEditors.SimpleButton
End Class
