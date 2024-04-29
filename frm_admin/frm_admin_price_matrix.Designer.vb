<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_price_matrix
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
        Me.lbl_heading = New DevExpress.XtraEditors.LabelControl()
        Me.grid_price_matrix = New DevExpress.XtraGrid.GridControl()
        Me.grid_price_matrix_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_combinations = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_affected = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_regular_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_dealer_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_vip_price = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_min_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_max_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_avg_margin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_dealer = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cbb_vip = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.cb_show_null = New DevExpress.XtraEditors.CheckButton()
        Me.btn_update = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.grid_price_matrix, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_price_matrix_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_dealer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_vip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_heading
        '
        Me.lbl_heading.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.lbl_heading.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.lbl_heading.Appearance.Options.UseFont = True
        Me.lbl_heading.Appearance.Options.UseForeColor = True
        Me.lbl_heading.Location = New System.Drawing.Point(12, 12)
        Me.lbl_heading.Name = "lbl_heading"
        Me.lbl_heading.Size = New System.Drawing.Size(142, 31)
        Me.lbl_heading.TabIndex = 20
        Me.lbl_heading.Text = "Price Matrix"
        '
        'grid_price_matrix
        '
        Me.grid_price_matrix.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_price_matrix.Location = New System.Drawing.Point(-1, 110)
        Me.grid_price_matrix.MainView = Me.grid_price_matrix_view
        Me.grid_price_matrix.Name = "grid_price_matrix"
        Me.grid_price_matrix.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbb_dealer, Me.cbb_vip})
        Me.grid_price_matrix.Size = New System.Drawing.Size(1148, 491)
        Me.grid_price_matrix.TabIndex = 21
        Me.grid_price_matrix.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_price_matrix_view})
        '
        'grid_price_matrix_view
        '
        Me.grid_price_matrix_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_price_matrix_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_price_matrix_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_price_matrix_view.Appearance.Row.Options.UseFont = True
        Me.grid_price_matrix_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_combinations, Me.col_affected, Me.col_regular_price, Me.col_dealer_price, Me.col_vip_price, Me.col_min_margin, Me.col_max_margin, Me.col_avg_margin})
        Me.grid_price_matrix_view.GridControl = Me.grid_price_matrix
        Me.grid_price_matrix_view.Name = "grid_price_matrix_view"
        Me.grid_price_matrix_view.OptionsPrint.PrintHorzLines = False
        Me.grid_price_matrix_view.OptionsPrint.PrintVertLines = False
        Me.grid_price_matrix_view.OptionsView.ColumnAutoWidth = False
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "combination_id"
        Me.col_id.MaxWidth = 80
        Me.col_id.Name = "col_id"
        Me.col_id.OptionsColumn.AllowEdit = False
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 80
        '
        'col_combinations
        '
        Me.col_combinations.Caption = "Brand - Sub Category"
        Me.col_combinations.FieldName = "combination_name"
        Me.col_combinations.MinWidth = 250
        Me.col_combinations.Name = "col_combinations"
        Me.col_combinations.OptionsColumn.AllowEdit = False
        Me.col_combinations.Visible = True
        Me.col_combinations.VisibleIndex = 1
        Me.col_combinations.Width = 250
        '
        'col_affected
        '
        Me.col_affected.AppearanceCell.Options.UseTextOptions = True
        Me.col_affected.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_affected.AppearanceHeader.Options.UseTextOptions = True
        Me.col_affected.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_affected.Caption = "AU"
        Me.col_affected.FieldName = "affected_items"
        Me.col_affected.MaxWidth = 50
        Me.col_affected.Name = "col_affected"
        Me.col_affected.OptionsColumn.AllowEdit = False
        Me.col_affected.Visible = True
        Me.col_affected.VisibleIndex = 2
        Me.col_affected.Width = 50
        '
        'col_regular_price
        '
        Me.col_regular_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_regular_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_regular_price.AppearanceHeader.Options.UseTextOptions = True
        Me.col_regular_price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_regular_price.Caption = "REGULAR"
        Me.col_regular_price.FieldName = "regular_discount"
        Me.col_regular_price.MinWidth = 80
        Me.col_regular_price.Name = "col_regular_price"
        Me.col_regular_price.Visible = True
        Me.col_regular_price.VisibleIndex = 3
        Me.col_regular_price.Width = 150
        '
        'col_dealer_price
        '
        Me.col_dealer_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_dealer_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_dealer_price.AppearanceHeader.Options.UseTextOptions = True
        Me.col_dealer_price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_dealer_price.Caption = "DEALER"
        Me.col_dealer_price.FieldName = "dealer_discount"
        Me.col_dealer_price.MinWidth = 80
        Me.col_dealer_price.Name = "col_dealer_price"
        Me.col_dealer_price.Visible = True
        Me.col_dealer_price.VisibleIndex = 4
        Me.col_dealer_price.Width = 150
        '
        'col_vip_price
        '
        Me.col_vip_price.AppearanceCell.Options.UseTextOptions = True
        Me.col_vip_price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_vip_price.AppearanceHeader.Options.UseTextOptions = True
        Me.col_vip_price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_vip_price.Caption = "VIP"
        Me.col_vip_price.FieldName = "vip_discount"
        Me.col_vip_price.MinWidth = 80
        Me.col_vip_price.Name = "col_vip_price"
        Me.col_vip_price.Visible = True
        Me.col_vip_price.VisibleIndex = 5
        Me.col_vip_price.Width = 150
        '
        'col_min_margin
        '
        Me.col_min_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_min_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_min_margin.AppearanceHeader.Options.UseTextOptions = True
        Me.col_min_margin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_min_margin.Caption = "LOW"
        Me.col_min_margin.DisplayFormat.FormatString = "p2"
        Me.col_min_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_min_margin.FieldName = "min_margin"
        Me.col_min_margin.Name = "col_min_margin"
        Me.col_min_margin.OptionsColumn.AllowEdit = False
        Me.col_min_margin.Visible = True
        Me.col_min_margin.VisibleIndex = 6
        '
        'col_max_margin
        '
        Me.col_max_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_max_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_max_margin.AppearanceHeader.Options.UseTextOptions = True
        Me.col_max_margin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_max_margin.Caption = "MAX"
        Me.col_max_margin.DisplayFormat.FormatString = "p2"
        Me.col_max_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_max_margin.FieldName = "max_margin"
        Me.col_max_margin.Name = "col_max_margin"
        Me.col_max_margin.OptionsColumn.AllowEdit = False
        Me.col_max_margin.Visible = True
        Me.col_max_margin.VisibleIndex = 7
        '
        'col_avg_margin
        '
        Me.col_avg_margin.AppearanceCell.Options.UseTextOptions = True
        Me.col_avg_margin.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_avg_margin.AppearanceHeader.Options.UseTextOptions = True
        Me.col_avg_margin.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_avg_margin.Caption = "AVG"
        Me.col_avg_margin.DisplayFormat.FormatString = "p2"
        Me.col_avg_margin.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_avg_margin.FieldName = "avg_margin"
        Me.col_avg_margin.Name = "col_avg_margin"
        Me.col_avg_margin.OptionsColumn.AllowEdit = False
        Me.col_avg_margin.Visible = True
        Me.col_avg_margin.VisibleIndex = 8
        '
        'cbb_dealer
        '
        Me.cbb_dealer.AutoHeight = False
        Me.cbb_dealer.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_dealer.Items.AddRange(New Object() {"NET"})
        Me.cbb_dealer.Name = "cbb_dealer"
        '
        'cbb_vip
        '
        Me.cbb_vip.AutoHeight = False
        Me.cbb_vip.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_vip.Items.AddRange(New Object() {"NET"})
        Me.cbb_vip.Name = "cbb_vip"
        '
        'cb_show_null
        '
        Me.cb_show_null.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cb_show_null.Location = New System.Drawing.Point(995, 58)
        Me.cb_show_null.Name = "cb_show_null"
        Me.cb_show_null.Size = New System.Drawing.Size(140, 46)
        Me.cb_show_null.TabIndex = 23
        Me.cb_show_null.Text = "Show NULL"
        '
        'btn_update
        '
        Me.btn_update.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_update.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Appearance.Options.UseFont = True
        Me.btn_update.Appearance.Options.UseTextOptions = True
        Me.btn_update.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_update.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_update.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_update.ImageOptions.ImageToTextIndent = 5
        Me.btn_update.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.updatedataextract
        Me.btn_update.Location = New System.Drawing.Point(1141, 27)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(160, 46)
        Me.btn_update.TabIndex = 24
        Me.btn_update.Text = "Update"
        Me.btn_update.Visible = False
        '
        'btn_export
        '
        Me.btn_export.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_export.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.Appearance.Options.UseFont = True
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_export.ImageOptions.ImageToTextIndent = 5
        Me.btn_export.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.exporttoxls
        Me.btn_export.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_export.Location = New System.Drawing.Point(829, 58)
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(160, 46)
        Me.btn_export.TabIndex = 25
        Me.btn_export.Text = "Export"
        '
        'frm_admin_price_matrix
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 598)
        Me.Controls.Add(Me.btn_export)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.cb_show_null)
        Me.Controls.Add(Me.grid_price_matrix)
        Me.Controls.Add(Me.lbl_heading)
        Me.Name = "frm_admin_price_matrix"
        Me.Text = "Price Matrix"
        CType(Me.grid_price_matrix, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_price_matrix_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_dealer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_vip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_heading As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_price_matrix As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_price_matrix_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_combinations As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_dealer_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_vip_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_dealer As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cbb_vip As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
    Friend WithEvents cb_show_null As DevExpress.XtraEditors.CheckButton
    Friend WithEvents btn_update As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_min_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_max_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_avg_margin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_regular_price As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_affected As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
End Class
