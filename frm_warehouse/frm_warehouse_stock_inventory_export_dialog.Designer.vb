<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stock_inventory_export_dialog
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
        Me.components = New System.ComponentModel.Container()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_export = New DevExpress.XtraGrid.GridControl()
        Me.grid_export_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_warehouse_code = New DevExpress.XtraEditors.TextEdit()
        Me.col_storeid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.XtraSaveFileDialog1 = New DevExpress.XtraEditors.XtraSaveFileDialog(Me.components)
        CType(Me.grid_export, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_export_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_warehouse_code.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(150, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Select warehouse(s) to export:"
        '
        'grid_export
        '
        Me.grid_export.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_export.Location = New System.Drawing.Point(-2, 45)
        Me.grid_export.MainView = Me.grid_export_view
        Me.grid_export.Name = "grid_export"
        Me.grid_export.Size = New System.Drawing.Size(394, 211)
        Me.grid_export.TabIndex = 1
        Me.grid_export.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_export_view})
        '
        'grid_export_view
        '
        Me.grid_export_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_storeid, Me.col_warehouse_name})
        Me.grid_export_view.GridControl = Me.grid_export
        Me.grid_export_view.Name = "grid_export_view"
        Me.grid_export_view.OptionsSelection.MultiSelect = True
        Me.grid_export_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        Me.grid_export_view.OptionsView.ShowGroupPanel = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(178, 276)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(96, 38)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_export
        '
        Me.btn_export.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_export.Appearance.Options.UseBackColor = True
        Me.btn_export.Location = New System.Drawing.Point(280, 276)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(96, 38)
        Me.btn_export.TabIndex = 3
        Me.btn_export.Text = "Export"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 267)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(85, 13)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Warehouse code:"
        '
        'txt_warehouse_code
        '
        Me.txt_warehouse_code.Location = New System.Drawing.Point(12, 286)
        Me.txt_warehouse_code.Name = "txt_warehouse_code"
        Me.txt_warehouse_code.Size = New System.Drawing.Size(85, 28)
        Me.txt_warehouse_code.TabIndex = 5
        '
        'col_storeid
        '
        Me.col_storeid.Caption = "Warehouse ID"
        Me.col_storeid.FieldName = "store_id"
        Me.col_storeid.MaxWidth = 86
        Me.col_storeid.Name = "col_storeid"
        Me.col_storeid.Visible = True
        Me.col_storeid.VisibleIndex = 1
        Me.col_storeid.Width = 50
        '
        'col_warehouse_name
        '
        Me.col_warehouse_name.Caption = "Warehouse Name"
        Me.col_warehouse_name.FieldName = "store_name"
        Me.col_warehouse_name.Name = "col_warehouse_name"
        Me.col_warehouse_name.Visible = True
        Me.col_warehouse_name.VisibleIndex = 2
        '
        'XtraSaveFileDialog1
        '
        Me.XtraSaveFileDialog1.FileName = "XtraSaveFileDialog1"
        '
        'frm_warehouse_stock_inventory_export_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(388, 326)
        Me.ControlBox = False
        Me.Controls.Add(Me.txt_warehouse_code)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.grid_export)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frm_warehouse_stock_inventory_export_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Export Dialog"
        CType(Me.grid_export, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_export_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_warehouse_code.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_export As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_export_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_warehouse_code As DevExpress.XtraEditors.TextEdit
    Friend WithEvents col_storeid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraSaveFileDialog1 As DevExpress.XtraEditors.XtraSaveFileDialog
End Class
