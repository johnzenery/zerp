<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_billing_statement
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_soa = New DevExpress.XtraGrid.GridControl()
        Me.grid_soa_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_soa_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_generated = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_prepared_by = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_print = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_repo_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_soa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_soa_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_repo_print, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_soa
        '
        Me.grid_soa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_soa.Location = New System.Drawing.Point(-1, 110)
        Me.grid_soa.MainView = Me.grid_soa_view
        Me.grid_soa.Name = "grid_soa"
        Me.grid_soa.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_repo_print})
        Me.grid_soa.Size = New System.Drawing.Size(1187, 486)
        Me.grid_soa.TabIndex = 8
        Me.grid_soa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_soa_view})
        '
        'grid_soa_view
        '
        Me.grid_soa_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_soa_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_soa_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_soa_view.Appearance.Row.Options.UseFont = True
        Me.grid_soa_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_soa_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_soa_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_soa_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_soa_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_soa_id, Me.col_customer, Me.col_date_generated, Me.col_amount, Me.col_prepared_by, Me.col_print})
        Me.grid_soa_view.GridControl = Me.grid_soa
        Me.grid_soa_view.Name = "grid_soa_view"
        Me.grid_soa_view.OptionsBehavior.ReadOnly = True
        Me.grid_soa_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_soa_view.OptionsView.ColumnAutoWidth = False
        Me.grid_soa_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_soa_id
        '
        Me.col_soa_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_soa_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_soa_id.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_soa_id.AppearanceHeader.Options.UseForeColor = True
        Me.col_soa_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_soa_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_soa_id.Caption = "BS ID"
        Me.col_soa_id.FieldName = "soa_id"
        Me.col_soa_id.MaxWidth = 100
        Me.col_soa_id.MinWidth = 50
        Me.col_soa_id.Name = "col_soa_id"
        Me.col_soa_id.Visible = True
        Me.col_soa_id.VisibleIndex = 0
        Me.col_soa_id.Width = 80
        '
        'col_customer
        '
        Me.col_customer.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_customer.AppearanceHeader.Options.UseForeColor = True
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.MinWidth = 50
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 266
        '
        'col_date_generated
        '
        Me.col_date_generated.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_generated.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_generated.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_date_generated.AppearanceHeader.Options.UseForeColor = True
        Me.col_date_generated.Caption = "Date Generated"
        Me.col_date_generated.DisplayFormat.FormatString = "MM/dd/yyy"
        Me.col_date_generated.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_generated.FieldName = "print_date"
        Me.col_date_generated.MaxWidth = 120
        Me.col_date_generated.Name = "col_date_generated"
        Me.col_date_generated.Visible = True
        Me.col_date_generated.VisibleIndex = 2
        Me.col_date_generated.Width = 120
        '
        'col_amount
        '
        Me.col_amount.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_amount.AppearanceHeader.Options.UseForeColor = True
        Me.col_amount.AppearanceHeader.Options.UseTextOptions = True
        Me.col_amount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_amount.Caption = "Amount "
        Me.col_amount.DisplayFormat.FormatString = "c2"
        Me.col_amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.col_amount.FieldName = "total"
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 3
        Me.col_amount.Width = 158
        '
        'col_prepared_by
        '
        Me.col_prepared_by.AppearanceCell.Options.UseTextOptions = True
        Me.col_prepared_by.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_prepared_by.AppearanceHeader.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.col_prepared_by.AppearanceHeader.Options.UseForeColor = True
        Me.col_prepared_by.Caption = "Prepared By"
        Me.col_prepared_by.FieldName = "prepared_by"
        Me.col_prepared_by.Name = "col_prepared_by"
        Me.col_prepared_by.Visible = True
        Me.col_prepared_by.VisibleIndex = 4
        Me.col_prepared_by.Width = 150
        '
        'col_print
        '
        Me.col_print.AppearanceHeader.Options.UseTextOptions = True
        Me.col_print.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_print.Caption = "Print"
        Me.col_print.ColumnEdit = Me.btn_repo_print
        Me.col_print.Name = "col_print"
        Me.col_print.Visible = True
        Me.col_print.VisibleIndex = 5
        '
        'btn_repo_print
        '
        Me.btn_repo_print.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_repo_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_repo_print.Name = "btn_repo_print"
        Me.btn_repo_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_new
        '
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 8
        Me.btn_new.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.newdatasource
        Me.btn_new.Location = New System.Drawing.Point(12, 58)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(160, 46)
        Me.btn_new.TabIndex = 9
        Me.btn_new.Text = "New Statement"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(203, 31)
        Me.LabelControl1.TabIndex = 82
        Me.LabelControl1.Text = "Billing Statement"
        '
        'frm_collection_billing_statement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 591)
        Me.Controls.Add(Me.grid_soa)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_new)
        Me.Name = "frm_collection_billing_statement"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Statement of Accounts"
        CType(Me.grid_soa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_soa_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_repo_print, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_soa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_soa_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_soa_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_generated As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_prepared_by As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_print As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_repo_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
End Class
