<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_transfer_reports
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_admin_transfer_reports))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_transfer_id = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_report = New DevExpress.XtraEditors.MemoEdit()
        Me.rb_zero = New System.Windows.Forms.RadioButton()
        Me.rb_dest = New System.Windows.Forms.RadioButton()
        Me.rb_src = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_source = New DevExpress.XtraEditors.TextEdit()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_destination = New DevExpress.XtraEditors.TextEdit()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_apply = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_report = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descriptiom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.col_missing = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_reportID = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_reported_date = New DevExpress.XtraEditors.TextEdit()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_reported_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_report.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_destination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_reported_date.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_reported_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Transfer ID"
        '
        'txt_transfer_id
        '
        Me.txt_transfer_id.Enabled = False
        Me.txt_transfer_id.Location = New System.Drawing.Point(123, 66)
        Me.txt_transfer_id.Name = "txt_transfer_id"
        Me.txt_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_transfer_id.Properties.Appearance.Options.UseTextOptions = True
        Me.txt_transfer_id.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.txt_transfer_id.Size = New System.Drawing.Size(149, 30)
        Me.txt_transfer_id.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(16, 339)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Incident Note"
        '
        'txt_report
        '
        Me.txt_report.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_report.Location = New System.Drawing.Point(123, 338)
        Me.txt_report.Name = "txt_report"
        Me.txt_report.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_report.Properties.Appearance.Options.UseFont = True
        Me.txt_report.Properties.ReadOnly = True
        Me.txt_report.Properties.UseReadOnlyAppearance = False
        Me.txt_report.Size = New System.Drawing.Size(528, 64)
        Me.txt_report.TabIndex = 9
        '
        'rb_zero
        '
        Me.rb_zero.AutoSize = True
        Me.rb_zero.Location = New System.Drawing.Point(29, 74)
        Me.rb_zero.Name = "rb_zero"
        Me.rb_zero.Size = New System.Drawing.Size(131, 17)
        Me.rb_zero.TabIndex = 2
        Me.rb_zero.TabStop = True
        Me.rb_zero.Text = "Remove from On-Hold"
        Me.rb_zero.UseVisualStyleBackColor = True
        '
        'rb_dest
        '
        Me.rb_dest.AutoSize = True
        Me.rb_dest.Location = New System.Drawing.Point(29, 51)
        Me.rb_dest.Name = "rb_dest"
        Me.rb_dest.Size = New System.Drawing.Size(83, 17)
        Me.rb_dest.TabIndex = 1
        Me.rb_dest.TabStop = True
        Me.rb_dest.Text = "Reconcile to"
        Me.rb_dest.UseVisualStyleBackColor = True
        '
        'rb_src
        '
        Me.rb_src.AutoSize = True
        Me.rb_src.Location = New System.Drawing.Point(29, 28)
        Me.rb_src.Name = "rb_src"
        Me.rb_src.Size = New System.Drawing.Size(108, 17)
        Me.rb_src.TabIndex = 0
        Me.rb_src.TabStop = True
        Me.rb_src.Text = "Reconcile back to"
        Me.rb_src.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(17, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Source Store"
        '
        'txt_source
        '
        Me.txt_source.Location = New System.Drawing.Point(123, 102)
        Me.txt_source.Name = "txt_source"
        Me.txt_source.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_source.Properties.Appearance.Options.UseFont = True
        Me.txt_source.Properties.ReadOnly = True
        Me.txt_source.Properties.UseReadOnlyAppearance = False
        Me.txt_source.Size = New System.Drawing.Size(239, 30)
        Me.txt_source.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(15, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Destination Store"
        '
        'txt_destination
        '
        Me.txt_destination.Location = New System.Drawing.Point(123, 138)
        Me.txt_destination.Name = "txt_destination"
        Me.txt_destination.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_destination.Properties.Appearance.Options.UseFont = True
        Me.txt_destination.Properties.ReadOnly = True
        Me.txt_destination.Properties.UseReadOnlyAppearance = False
        Me.txt_destination.Size = New System.Drawing.Size(239, 30)
        Me.txt_destination.TabIndex = 13
        '
        'btn_cancel
        '
        Me.btn_cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Appearance.Options.UseTextOptions = True
        Me.btn_cancel.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_cancel.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancel.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_cancel.ImageOptions.ImageToTextIndent = 8
        Me.btn_cancel.Location = New System.Drawing.Point(385, 526)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(130, 41)
        Me.btn_cancel.TabIndex = 84
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_apply
        '
        Me.btn_apply.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_apply.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_apply.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_apply.Appearance.Options.UseBackColor = True
        Me.btn_apply.Appearance.Options.UseFont = True
        Me.btn_apply.Appearance.Options.UseTextOptions = True
        Me.btn_apply.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_apply.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_apply.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_apply.ImageOptions.ImageToTextIndent = 8
        Me.btn_apply.Location = New System.Drawing.Point(521, 526)
        Me.btn_apply.Name = "btn_apply"
        Me.btn_apply.Size = New System.Drawing.Size(130, 41)
        Me.btn_apply.TabIndex = 83
        Me.btn_apply.Text = "Submit"
        '
        'grid_report
        '
        Me.grid_report.AllowUserToAddRows = False
        Me.grid_report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.grid_report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.grid_report.BackgroundColor = System.Drawing.Color.GhostWhite
        Me.grid_report.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grid_report.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grid_report.ColumnHeadersHeight = 28
        Me.grid_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grid_report.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.descriptiom, Me.col_missing})
        Me.grid_report.EnableHeadersVisualStyles = False
        Me.grid_report.Location = New System.Drawing.Point(18, 184)
        Me.grid_report.Margin = New System.Windows.Forms.Padding(0)
        Me.grid_report.MultiSelect = False
        Me.grid_report.Name = "grid_report"
        Me.grid_report.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_report.Size = New System.Drawing.Size(633, 144)
        Me.grid_report.TabIndex = 85
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "PID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.FillWeight = 73.71088!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'descriptiom
        '
        Me.descriptiom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descriptiom.HeaderText = "Description"
        Me.descriptiom.Name = "descriptiom"
        Me.descriptiom.ReadOnly = True
        '
        'col_missing
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.col_missing.DefaultCellStyle = DataGridViewCellStyle4
        Me.col_missing.HeaderText = "Missing"
        Me.col_missing.Name = "col_missing"
        Me.col_missing.ReadOnly = True
        Me.col_missing.Width = 66
        '
        'lbl_reportID
        '
        Me.lbl_reportID.AutoSize = True
        Me.lbl_reportID.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_reportID.Location = New System.Drawing.Point(278, 73)
        Me.lbl_reportID.Name = "lbl_reportID"
        Me.lbl_reportID.Size = New System.Drawing.Size(59, 15)
        Me.lbl_reportID.TabIndex = 86
        Me.lbl_reportID.Text = "Report ID"
        Me.lbl_reportID.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(392, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 15)
        Me.Label5.TabIndex = 90
        Me.Label5.Text = "Date of Report"
        '
        'txt_reported_date
        '
        Me.txt_reported_date.Location = New System.Drawing.Point(488, 138)
        Me.txt_reported_date.Name = "txt_reported_date"
        Me.txt_reported_date.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_reported_date.Properties.Appearance.Options.UseFont = True
        Me.txt_reported_date.Properties.ReadOnly = True
        Me.txt_reported_date.Properties.UseReadOnlyAppearance = False
        Me.txt_reported_date.Size = New System.Drawing.Size(239, 30)
        Me.txt_reported_date.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(392, 109)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 15)
        Me.Label6.TabIndex = 88
        Me.Label6.Text = "Reported by"
        '
        'txt_reported_by
        '
        Me.txt_reported_by.Location = New System.Drawing.Point(488, 102)
        Me.txt_reported_by.Name = "txt_reported_by"
        Me.txt_reported_by.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_reported_by.Properties.Appearance.Options.UseFont = True
        Me.txt_reported_by.Properties.ReadOnly = True
        Me.txt_reported_by.Properties.UseReadOnlyAppearance = False
        Me.txt_reported_by.Size = New System.Drawing.Size(239, 30)
        Me.txt_reported_by.TabIndex = 87
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Appearance.Options.UseForeColor = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(267, 31)
        Me.LabelControl5.TabIndex = 93
        Me.LabelControl5.Text = "Stock Transfer Report"
        '
        'GroupControl1
        '
        Me.GroupControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupControl1.Controls.Add(Me.rb_zero)
        Me.GroupControl1.Controls.Add(Me.rb_src)
        Me.GroupControl1.Controls.Add(Me.rb_dest)
        Me.GroupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light
        Me.GroupControl1.Location = New System.Drawing.Point(20, 407)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(631, 109)
        Me.GroupControl1.TabIndex = 95
        Me.GroupControl1.Text = "Action to Resolve"
        '
        'frm_admin_transfer_reports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 577)
        Me.Controls.Add(Me.GroupControl1)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_reported_date)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_reported_by)
        Me.Controls.Add(Me.lbl_reportID)
        Me.Controls.Add(Me.grid_report)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_apply)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_destination)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_source)
        Me.Controls.Add(Me.txt_report)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_transfer_id)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_admin_transfer_reports.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_admin_transfer_reports"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transfer Stock Report"
        CType(Me.txt_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_report.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_destination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_reported_date.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_reported_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        Me.GroupControl1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_transfer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_report As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents rb_zero As RadioButton
    Friend WithEvents rb_dest As RadioButton
    Friend WithEvents rb_src As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_destination As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_apply As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_report As DataGridView
    Friend WithEvents lbl_reportID As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_reported_date As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_reported_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents descriptiom As DataGridViewTextBoxColumn
    Friend WithEvents col_missing As DataGridViewTextBoxColumn
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GroupControl1 As DevExpress.XtraEditors.GroupControl
End Class
