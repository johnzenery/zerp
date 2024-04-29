<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_unserved_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_unserved_dialog))
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_unserved = New DevExpress.XtraGrid.GridControl()
        Me.grid_unserved_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_entry_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unserved_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_remarks = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.lbl_title = New Guna.UI.WinForms.GunaLabel()
        CType(Me.grid_unserved, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_unserved_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.ImageOptions.Image = CType(resources.GetObject("btn_export.ImageOptions.Image"), System.Drawing.Image)
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 8
        Me.btn_export.Location = New System.Drawing.Point(829, 8)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(163, 51)
        Me.btn_export.TabIndex = 3
        Me.btn_export.Text = "Export to CSV"
        '
        'grid_unserved
        '
        Me.grid_unserved.Location = New System.Drawing.Point(-1, 69)
        Me.grid_unserved.MainView = Me.grid_unserved_view
        Me.grid_unserved.Name = "grid_unserved"
        Me.grid_unserved.Size = New System.Drawing.Size(1006, 507)
        Me.grid_unserved.TabIndex = 14
        Me.grid_unserved.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_unserved_view})
        '
        'grid_unserved_view
        '
        Me.grid_unserved_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_unserved_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_unserved_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_unserved_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_unserved_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_unserved_view.Appearance.Row.Options.UseFont = True
        Me.grid_unserved_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_entry_date, Me.col_unserved_qty, Me.col_model, Me.col_description, Me.col_remarks})
        Me.grid_unserved_view.GridControl = Me.grid_unserved
        Me.grid_unserved_view.Name = "grid_unserved_view"
        Me.grid_unserved_view.OptionsBehavior.Editable = False
        '
        'col_entry_date
        '
        Me.col_entry_date.AppearanceCell.Options.UseTextOptions = True
        Me.col_entry_date.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_entry_date.Caption = "Entry Date"
        Me.col_entry_date.DisplayFormat.FormatString = "d"
        Me.col_entry_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_entry_date.FieldName = "created_at"
        Me.col_entry_date.MaxWidth = 120
        Me.col_entry_date.Name = "col_entry_date"
        Me.col_entry_date.Visible = True
        Me.col_entry_date.VisibleIndex = 0
        '
        'col_unserved_qty
        '
        Me.col_unserved_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_unserved_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_unserved_qty.Caption = "Unserved Qty"
        Me.col_unserved_qty.FieldName = "qty"
        Me.col_unserved_qty.MaxWidth = 100
        Me.col_unserved_qty.Name = "col_unserved_qty"
        Me.col_unserved_qty.Visible = True
        Me.col_unserved_qty.VisibleIndex = 1
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MaxWidth = 150
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 2
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 3
        '
        'col_remarks
        '
        Me.col_remarks.AppearanceCell.Options.UseTextOptions = True
        Me.col_remarks.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_remarks.Caption = "Remarks"
        Me.col_remarks.FieldName = "item_status"
        Me.col_remarks.MaxWidth = 100
        Me.col_remarks.Name = "col_remarks"
        Me.col_remarks.Visible = True
        Me.col_remarks.VisibleIndex = 4
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(12, 9)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(205, 31)
        Me.lbl_title.TabIndex = 15
        Me.lbl_title.Text = "Unserved Items"
        '
        'frm_sales_unserved_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1004, 576)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.grid_unserved)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_sales_unserved_dialog.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_unserved_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unserved Items"
        CType(Me.grid_unserved, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_unserved_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_unserved As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_unserved_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_entry_date As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_unserved_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_remarks As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbl_title As Guna.UI.WinForms.GunaLabel
End Class
