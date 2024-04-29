<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_quotation_order_list
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
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_quote = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_quotes = New DevExpress.XtraGrid.GridControl()
        Me.grid_quotes_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_quotation_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_company = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.date_created = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_validity = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_representative = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_quotes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_quotes_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_refresh
        '
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.Location = New System.Drawing.Point(178, 58)
        Me.btn_refresh.LookAndFeel.SkinName = "WXI"
        Me.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 13
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_quote
        '
        Me.btn_quote.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_quote.Appearance.Options.UseFont = True
        Me.btn_quote.Appearance.Options.UseTextOptions = True
        Me.btn_quote.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_quote.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_quote.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newtask_32x32
        Me.btn_quote.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_quote.ImageOptions.ImageToTextIndent = 5
        Me.btn_quote.Location = New System.Drawing.Point(12, 58)
        Me.btn_quote.LookAndFeel.SkinName = "WXI"
        Me.btn_quote.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_quote.Name = "btn_quote"
        Me.btn_quote.Size = New System.Drawing.Size(160, 46)
        Me.btn_quote.TabIndex = 11
        Me.btn_quote.Text = "New Quotation"
        '
        'grid_quotes
        '
        Me.grid_quotes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_quotes.Location = New System.Drawing.Point(-3, 110)
        Me.grid_quotes.LookAndFeel.SkinName = "WXI"
        Me.grid_quotes.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_quotes.MainView = Me.grid_quotes_view
        Me.grid_quotes.Name = "grid_quotes"
        Me.grid_quotes.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit})
        Me.grid_quotes.Size = New System.Drawing.Size(1333, 633)
        Me.grid_quotes.TabIndex = 9
        Me.grid_quotes.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_quotes_view})
        '
        'grid_quotes_view
        '
        Me.grid_quotes_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_quotes_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_quotes_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_quotes_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_quotes_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_quotes_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_quotes_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.grid_quotes_view.Appearance.Row.Options.UseFont = True
        Me.grid_quotes_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_quotes_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_quotes_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_quotes_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_quotes_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_quotation_id, Me.col_company, Me.col_status, Me.date_created, Me.col_action, Me.col_validity, Me.col_representative})
        Me.grid_quotes_view.GridControl = Me.grid_quotes
        Me.grid_quotes_view.Name = "grid_quotes_view"
        Me.grid_quotes_view.OptionsBehavior.ReadOnly = True
        Me.grid_quotes_view.OptionsSelection.ResetSelectionClickOutsideCheckboxSelector = True
        Me.grid_quotes_view.OptionsView.ColumnAutoWidth = False
        '
        'col_quotation_id
        '
        Me.col_quotation_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_quotation_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_quotation_id.Caption = "Quote ID"
        Me.col_quotation_id.FieldName = "quotation_id"
        Me.col_quotation_id.MaxWidth = 100
        Me.col_quotation_id.MinWidth = 50
        Me.col_quotation_id.Name = "col_quotation_id"
        Me.col_quotation_id.Visible = True
        Me.col_quotation_id.VisibleIndex = 1
        Me.col_quotation_id.Width = 80
        '
        'col_company
        '
        Me.col_company.AppearanceHeader.Options.UseTextOptions = True
        Me.col_company.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_company.Caption = "Customer"
        Me.col_company.FieldName = "company"
        Me.col_company.MinWidth = 150
        Me.col_company.Name = "col_company"
        Me.col_company.Visible = True
        Me.col_company.VisibleIndex = 2
        Me.col_company.Width = 250
        '
        'col_status
        '
        Me.col_status.AppearanceCell.Options.UseTextOptions = True
        Me.col_status.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.AppearanceHeader.Options.UseTextOptions = True
        Me.col_status.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 4
        Me.col_status.Width = 120
        '
        'date_created
        '
        Me.date_created.AppearanceCell.Options.UseTextOptions = True
        Me.date_created.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.date_created.Caption = "Created At"
        Me.date_created.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.date_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.date_created.FieldName = "created_at"
        Me.date_created.Name = "date_created"
        Me.date_created.Visible = True
        Me.date_created.VisibleIndex = 5
        Me.date_created.Width = 120
        '
        'col_action
        '
        Me.col_action.Caption = "Action"
        Me.col_action.ColumnEdit = Me.btn_edit
        Me.col_action.MaxWidth = 50
        Me.col_action.MinWidth = 50
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 50
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_validity
        '
        Me.col_validity.AppearanceCell.Options.UseTextOptions = True
        Me.col_validity.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_validity.Caption = "Validity"
        Me.col_validity.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.col_validity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_validity.FieldName = "validity"
        Me.col_validity.Name = "col_validity"
        Me.col_validity.Visible = True
        Me.col_validity.VisibleIndex = 6
        Me.col_validity.Width = 120
        '
        'col_representative
        '
        Me.col_representative.Caption = "Representative"
        Me.col_representative.FieldName = "representative"
        Me.col_representative.Name = "col_representative"
        Me.col_representative.Visible = True
        Me.col_representative.VisibleIndex = 3
        Me.col_representative.Width = 160
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(132, 31)
        Me.LabelControl1.TabIndex = 14
        Me.LabelControl1.Text = "Quotations"
        '
        'frm_sales_quotation_order_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1326, 741)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_refresh)
        Me.Controls.Add(Me.btn_quote)
        Me.Controls.Add(Me.grid_quotes)
        Me.Name = "frm_sales_quotation_order_list"
        Me.Text = "Quotations"
        CType(Me.grid_quotes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_quotes_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_quote As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents grid_quotes As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_quotes_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_quotation_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_company As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents date_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_validity As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_representative As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
