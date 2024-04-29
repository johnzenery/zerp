<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_stores
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_store = New DevExpress.XtraGrid.GridControl()
        Me.gridview_supplier = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_store, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_add
        '
        Me.btn_add.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_add.Appearance.Options.UseFont = True
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.newdatasource
        Me.btn_add.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.CommonPalette
        Me.btn_add.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_add.Location = New System.Drawing.Point(12, 58)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(160, 46)
        Me.btn_add.TabIndex = 53
        Me.btn_add.Text = "New Warehouse"
        '
        'grid_store
        '
        Me.grid_store.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_store.Location = New System.Drawing.Point(-1, 114)
        Me.grid_store.MainView = Me.gridview_supplier
        Me.grid_store.Name = "grid_store"
        Me.grid_store.Size = New System.Drawing.Size(1032, 512)
        Me.grid_store.TabIndex = 52
        Me.grid_store.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_supplier})
        '
        'gridview_supplier
        '
        Me.gridview_supplier.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.gridview_supplier.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridview_supplier.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gridview_supplier.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_supplier.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.gridview_supplier.Appearance.Row.Options.UseFont = True
        Me.gridview_supplier.Appearance.Row.Options.UseTextOptions = True
        Me.gridview_supplier.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_supplier.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4})
        Me.gridview_supplier.GridControl = Me.grid_store
        Me.gridview_supplier.Name = "gridview_supplier"
        Me.gridview_supplier.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.gridview_supplier.OptionsView.BestFitMode = DevExpress.XtraGrid.Views.Grid.GridBestFitMode.Full
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Store ID"
        Me.GridColumn1.FieldName = "store_id"
        Me.GridColumn1.MaxWidth = 100
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 100
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Store Name"
        Me.GridColumn2.FieldName = "store_name"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 1
        Me.GridColumn2.Width = 200
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "Store Address"
        Me.GridColumn3.FieldName = "store_addr"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 2
        Me.GridColumn3.Width = 305
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "Person-in-Charge"
        Me.GridColumn4.FieldName = "person_in_charge"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 3
        Me.GridColumn4.Width = 269
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(302, 31)
        Me.LabelControl1.TabIndex = 54
        Me.LabelControl1.Text = "Warehouse Management"
        '
        'frm_admin_stores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 623)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.grid_store)
        Me.Name = "frm_admin_stores"
        Me.Text = "Warehouse Management"
        CType(Me.grid_store, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_store As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_supplier As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
