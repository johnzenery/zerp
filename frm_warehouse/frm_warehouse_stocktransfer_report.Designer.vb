<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_stocktransfer_report))
        Me.txt_stock_transfer_id = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_report_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_source = New DevExpress.XtraEditors.TextEdit()
        Me.grid_transfer_report = New DevExpress.XtraGrid.GridControl()
        Me.grid_transfer_report_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_toReceive = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delivered = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_missing = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_destination = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_stock_transfer_id.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_report_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_source.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transfer_report, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_transfer_report_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_destination.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_stock_transfer_id
        '
        Me.txt_stock_transfer_id.EditValue = ""
        Me.txt_stock_transfer_id.Enabled = False
        Me.txt_stock_transfer_id.EnterMoveNextControl = True
        Me.txt_stock_transfer_id.Location = New System.Drawing.Point(93, 61)
        Me.txt_stock_transfer_id.Name = "txt_stock_transfer_id"
        Me.txt_stock_transfer_id.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_stock_transfer_id.Properties.Appearance.Options.UseFont = True
        Me.txt_stock_transfer_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_stock_transfer_id.Size = New System.Drawing.Size(94, 30)
        Me.txt_stock_transfer_id.TabIndex = 6
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(15, 68)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(27, 15)
        Me.LabelControl1.TabIndex = 7
        Me.LabelControl1.Text = "STID"
        '
        'txt_report_notes
        '
        Me.txt_report_notes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_report_notes.EditValue = ""
        Me.txt_report_notes.Location = New System.Drawing.Point(15, 401)
        Me.txt_report_notes.Name = "txt_report_notes"
        Me.txt_report_notes.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_report_notes.Properties.Appearance.Options.UseFont = True
        Me.txt_report_notes.Size = New System.Drawing.Size(639, 69)
        Me.txt_report_notes.TabIndex = 8
        '
        'LabelControl2
        '
        Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(15, 380)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(135, 15)
        Me.LabelControl2.TabIndex = 9
        Me.LabelControl2.Text = "Transfer Incident Report "
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.Appearance.Options.UseTextOptions = True
        Me.btn_submit.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_submit.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 8
        Me.btn_submit.Location = New System.Drawing.Point(564, 476)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(90, 32)
        Me.btn_submit.TabIndex = 85
        Me.btn_submit.Text = "Submit"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(15, 104)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(39, 15)
        Me.LabelControl3.TabIndex = 88
        Me.LabelControl3.Text = "Source"
        '
        'txt_source
        '
        Me.txt_source.EditValue = ""
        Me.txt_source.Enabled = False
        Me.txt_source.EnterMoveNextControl = True
        Me.txt_source.Location = New System.Drawing.Point(93, 97)
        Me.txt_source.Name = "txt_source"
        Me.txt_source.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_source.Properties.Appearance.Options.UseFont = True
        Me.txt_source.Size = New System.Drawing.Size(210, 30)
        Me.txt_source.TabIndex = 87
        '
        'grid_transfer_report
        '
        Me.grid_transfer_report.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_transfer_report.Location = New System.Drawing.Point(15, 174)
        Me.grid_transfer_report.MainView = Me.grid_transfer_report_view
        Me.grid_transfer_report.Name = "grid_transfer_report"
        Me.grid_transfer_report.Size = New System.Drawing.Size(639, 196)
        Me.grid_transfer_report.TabIndex = 89
        Me.grid_transfer_report.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_transfer_report_view})
        '
        'grid_transfer_report_view
        '
        Me.grid_transfer_report_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.grid_transfer_report_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_transfer_report_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_transfer_report_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_transfer_report_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_winmodel, Me.col_description, Me.col_toReceive, Me.col_delivered, Me.col_missing})
        Me.grid_transfer_report_view.GridControl = Me.grid_transfer_report
        Me.grid_transfer_report_view.Name = "grid_transfer_report_view"
        Me.grid_transfer_report_view.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_transfer_report_view.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_transfer_report_view.OptionsBehavior.ReadOnly = True
        Me.grid_transfer_report_view.OptionsCustomization.AllowColumnMoving = False
        Me.grid_transfer_report_view.OptionsCustomization.AllowFilter = False
        Me.grid_transfer_report_view.OptionsCustomization.AllowSort = False
        Me.grid_transfer_report_view.OptionsView.ShowGroupPanel = False
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 80
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Winmodel"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MaxWidth = 150
        Me.col_winmodel.MinWidth = 150
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 150
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 2
        '
        'col_toReceive
        '
        Me.col_toReceive.AppearanceCell.Options.UseTextOptions = True
        Me.col_toReceive.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_toReceive.Caption = "To Receive"
        Me.col_toReceive.FieldName = "to_receive"
        Me.col_toReceive.MaxWidth = 80
        Me.col_toReceive.Name = "col_toReceive"
        Me.col_toReceive.Visible = True
        Me.col_toReceive.VisibleIndex = 3
        '
        'col_delivered
        '
        Me.col_delivered.AppearanceCell.Options.UseTextOptions = True
        Me.col_delivered.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_delivered.Caption = "Delivered"
        Me.col_delivered.FieldName = "delivered"
        Me.col_delivered.MaxWidth = 80
        Me.col_delivered.Name = "col_delivered"
        Me.col_delivered.Visible = True
        Me.col_delivered.VisibleIndex = 4
        '
        'col_missing
        '
        Me.col_missing.AppearanceCell.Options.UseTextOptions = True
        Me.col_missing.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_missing.Caption = "Missing"
        Me.col_missing.FieldName = "missing"
        Me.col_missing.MaxWidth = 80
        Me.col_missing.Name = "col_missing"
        Me.col_missing.Visible = True
        Me.col_missing.VisibleIndex = 5
        Me.col_missing.Width = 50
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(15, 140)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(66, 15)
        Me.LabelControl4.TabIndex = 91
        Me.LabelControl4.Text = "Destination "
        '
        'txt_destination
        '
        Me.txt_destination.EditValue = ""
        Me.txt_destination.Enabled = False
        Me.txt_destination.EnterMoveNextControl = True
        Me.txt_destination.Location = New System.Drawing.Point(93, 133)
        Me.txt_destination.Name = "txt_destination"
        Me.txt_destination.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.txt_destination.Properties.Appearance.Options.UseFont = True
        Me.txt_destination.Size = New System.Drawing.Size(210, 30)
        Me.txt_destination.TabIndex = 90
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
        Me.LabelControl5.TabIndex = 92
        Me.LabelControl5.Text = "Stock Transfer Report"
        '
        'frm_warehouse_stocktransfer_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(666, 517)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.txt_destination)
        Me.Controls.Add(Me.grid_transfer_report)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.txt_source)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_report_notes)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_stock_transfer_id)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_warehouse_stocktransfer_report.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_warehouse_stocktransfer_report"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stock Transfer Report"
        CType(Me.txt_stock_transfer_id.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_report_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_source.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transfer_report, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_transfer_report_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_destination.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_stock_transfer_id As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_report_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_source As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_transfer_report As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_transfer_report_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_toReceive As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_delivered As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_missing As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_destination As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
End Class
