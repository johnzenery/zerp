<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stocktransfer_logs
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
        Me.grid_logs = New DevExpress.XtraGrid.GridControl()
        Me.grid_logs_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_log_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transferred_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_to = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_datetime = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_transfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_subtransfer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_receivedby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_createdby = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_lacking_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_start = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.dt_end = New DevExpress.XtraEditors.DateEdit()
        Me.btn_view = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_logs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_logs_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_logs
        '
        Me.grid_logs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_logs.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_logs.Location = New System.Drawing.Point(4, 124)
        Me.grid_logs.MainView = Me.grid_logs_view
        Me.grid_logs.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_logs.Name = "grid_logs"
        Me.grid_logs.Size = New System.Drawing.Size(1480, 629)
        Me.grid_logs.TabIndex = 0
        Me.grid_logs.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_logs_view})
        '
        'grid_logs_view
        '
        Me.grid_logs_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_logs_view.Appearance.Row.Options.UseFont = True
        Me.grid_logs_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_log_id, Me.col_transferred_qty, Me.col_model, Me.col_description, Me.col_from, Me.col_to, Me.col_datetime, Me.col_transfer_id, Me.col_subtransfer_id, Me.col_receivedby, Me.col_createdby, Me.col_qty, Me.col_lacking_qty})
        Me.grid_logs_view.DetailHeight = 431
        Me.grid_logs_view.GridControl = Me.grid_logs
        Me.grid_logs_view.Name = "grid_logs_view"
        Me.grid_logs_view.OptionsBehavior.ReadOnly = True
        Me.grid_logs_view.OptionsPrint.PrintHorzLines = False
        Me.grid_logs_view.OptionsPrint.PrintVertLines = False
        '
        'col_log_id
        '
        Me.col_log_id.Caption = "Log ID"
        Me.col_log_id.FieldName = "log_id"
        Me.col_log_id.MaxWidth = 70
        Me.col_log_id.MinWidth = 23
        Me.col_log_id.Name = "col_log_id"
        Me.col_log_id.Visible = True
        Me.col_log_id.VisibleIndex = 0
        Me.col_log_id.Width = 70
        '
        'col_transferred_qty
        '
        Me.col_transferred_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_transferred_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transferred_qty.AppearanceHeader.Options.UseTextOptions = True
        Me.col_transferred_qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_transferred_qty.Caption = "Recv. QTY"
        Me.col_transferred_qty.FieldName = "qty"
        Me.col_transferred_qty.MaxWidth = 95
        Me.col_transferred_qty.MinWidth = 23
        Me.col_transferred_qty.Name = "col_transferred_qty"
        Me.col_transferred_qty.Visible = True
        Me.col_transferred_qty.VisibleIndex = 2
        Me.col_transferred_qty.Width = 95
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MaxWidth = 187
        Me.col_model.MinWidth = 23
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 4
        Me.col_model.Width = 118
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 23
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 5
        Me.col_description.Width = 118
        '
        'col_from
        '
        Me.col_from.Caption = "FROM"
        Me.col_from.FieldName = "from_warehouse"
        Me.col_from.MaxWidth = 233
        Me.col_from.MinWidth = 23
        Me.col_from.Name = "col_from"
        Me.col_from.Visible = True
        Me.col_from.VisibleIndex = 6
        Me.col_from.Width = 118
        '
        'col_to
        '
        Me.col_to.Caption = "TO"
        Me.col_to.FieldName = "to_warehouse"
        Me.col_to.MaxWidth = 233
        Me.col_to.MinWidth = 23
        Me.col_to.Name = "col_to"
        Me.col_to.Visible = True
        Me.col_to.VisibleIndex = 7
        Me.col_to.Width = 118
        '
        'col_datetime
        '
        Me.col_datetime.Caption = "Date Received"
        Me.col_datetime.DisplayFormat.FormatString = "MM-dd-yyyy hh:mm tt"
        Me.col_datetime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_datetime.FieldName = "date_received"
        Me.col_datetime.MaxWidth = 140
        Me.col_datetime.MinWidth = 23
        Me.col_datetime.Name = "col_datetime"
        Me.col_datetime.Visible = True
        Me.col_datetime.VisibleIndex = 8
        Me.col_datetime.Width = 118
        '
        'col_transfer_id
        '
        Me.col_transfer_id.Caption = "Transfer ID"
        Me.col_transfer_id.FieldName = "transfer_id"
        Me.col_transfer_id.MaxWidth = 93
        Me.col_transfer_id.MinWidth = 23
        Me.col_transfer_id.Name = "col_transfer_id"
        Me.col_transfer_id.Visible = True
        Me.col_transfer_id.VisibleIndex = 9
        Me.col_transfer_id.Width = 92
        '
        'col_subtransfer_id
        '
        Me.col_subtransfer_id.Caption = "Sub Transfer ID"
        Me.col_subtransfer_id.FieldName = "subtransfer_id"
        Me.col_subtransfer_id.MaxWidth = 117
        Me.col_subtransfer_id.MinWidth = 23
        Me.col_subtransfer_id.Name = "col_subtransfer_id"
        Me.col_subtransfer_id.Visible = True
        Me.col_subtransfer_id.VisibleIndex = 10
        Me.col_subtransfer_id.Width = 115
        '
        'col_receivedby
        '
        Me.col_receivedby.Caption = "Received by"
        Me.col_receivedby.FieldName = "received_by"
        Me.col_receivedby.MaxWidth = 175
        Me.col_receivedby.MinWidth = 23
        Me.col_receivedby.Name = "col_receivedby"
        Me.col_receivedby.Visible = True
        Me.col_receivedby.VisibleIndex = 11
        Me.col_receivedby.Width = 139
        '
        'col_createdby
        '
        Me.col_createdby.Caption = "Created by"
        Me.col_createdby.FieldName = "created_by"
        Me.col_createdby.MaxWidth = 175
        Me.col_createdby.MinWidth = 23
        Me.col_createdby.Name = "col_createdby"
        Me.col_createdby.Visible = True
        Me.col_createdby.VisibleIndex = 12
        Me.col_createdby.Width = 175
        '
        'col_qty
        '
        Me.col_qty.Caption = "Orig. QTY"
        Me.col_qty.FieldName = "original_qty"
        Me.col_qty.MaxWidth = 80
        Me.col_qty.MinWidth = 80
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 1
        Me.col_qty.Width = 80
        '
        'col_lacking_qty
        '
        Me.col_lacking_qty.Caption = "Missing QTY"
        Me.col_lacking_qty.FieldName = "missing_qty"
        Me.col_lacking_qty.MaxWidth = 95
        Me.col_lacking_qty.MinWidth = 25
        Me.col_lacking_qty.Name = "col_lacking_qty"
        Me.col_lacking_qty.Visible = True
        Me.col_lacking_qty.VisibleIndex = 3
        Me.col_lacking_qty.Width = 95
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(294, 38)
        Me.LabelControl3.TabIndex = 34
        Me.LabelControl3.Text = "Stock Transfer Logs"
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_export.Appearance.Options.UseFont = True
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 5
        Me.btn_export.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources._next
        Me.btn_export.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export.Location = New System.Drawing.Point(1302, 15)
        Me.btn_export.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(182, 49)
        Me.btn_export.TabIndex = 35
        Me.btn_export.Text = "Export"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(27, 82)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl1.TabIndex = 36
        Me.LabelControl1.Text = "Coverage:"
        '
        'dt_start
        '
        Me.dt_start.EditValue = Nothing
        Me.dt_start.Location = New System.Drawing.Point(109, 73)
        Me.dt_start.Name = "dt_start"
        Me.dt_start.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_start.Properties.Appearance.Options.UseFont = True
        Me.dt_start.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_start.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_start.Size = New System.Drawing.Size(154, 34)
        Me.dt_start.TabIndex = 37
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(269, 82)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(14, 16)
        Me.LabelControl2.TabIndex = 38
        Me.LabelControl2.Text = "—"
        '
        'dt_end
        '
        Me.dt_end.EditValue = Nothing
        Me.dt_end.Location = New System.Drawing.Point(290, 73)
        Me.dt_end.Name = "dt_end"
        Me.dt_end.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.dt_end.Properties.Appearance.Options.UseFont = True
        Me.dt_end.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dt_end.Properties.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.dt_end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.dt_end.Size = New System.Drawing.Size(154, 34)
        Me.dt_end.TabIndex = 39
        '
        'btn_view
        '
        Me.btn_view.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_view.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_view.Appearance.Options.UseBackColor = True
        Me.btn_view.Appearance.Options.UseFont = True
        Me.btn_view.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_view.ImageOptions.ImageToTextIndent = 5
        Me.btn_view.Location = New System.Drawing.Point(458, 73)
        Me.btn_view.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_view.Name = "btn_view"
        Me.btn_view.Size = New System.Drawing.Size(93, 33)
        Me.btn_view.TabIndex = 76
        Me.btn_view.Text = "View"
        '
        'frm_warehouse_stocktransfer_logs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1498, 757)
        Me.Controls.Add(Me.btn_view)
        Me.Controls.Add(Me.dt_end)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.dt_start)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.grid_logs)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_warehouse_stocktransfer_logs"
        Me.Text = "Stock Transfer Logs"
        CType(Me.grid_logs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_logs_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_start.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_end.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_logs As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_logs_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_log_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transferred_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_from As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_to As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_datetime As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_transfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_subtransfer_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_receivedby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_createdby As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_lacking_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_start As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents dt_end As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btn_view As DevExpress.XtraEditors.SimpleButton
End Class
