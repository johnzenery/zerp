<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchaseorder_purchase_request_new
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_requested_by = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_order = New DevExpress.XtraGrid.GridControl()
        Me.grid_order_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.txt_search = New DevExpress.XtraEditors.SearchControl()
        Me.grid_search = New DevExpress.XtraGrid.GridControl()
        Me.grid_search_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_search_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_search_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_search_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_search_unit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_search_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_search_add = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_add = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_search_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_requested_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_order_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_search_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(12, 63)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(85, 16)
        Me.LabelControl8.TabIndex = 6
        Me.LabelControl8.Text = "Requested by"
        '
        'txt_requested_by
        '
        Me.txt_requested_by.Location = New System.Drawing.Point(113, 56)
        Me.txt_requested_by.Name = "txt_requested_by"
        Me.txt_requested_by.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txt_requested_by.Properties.Appearance.Options.UseFont = True
        Me.txt_requested_by.Properties.ReadOnly = True
        Me.txt_requested_by.Size = New System.Drawing.Size(215, 30)
        Me.txt_requested_by.TabIndex = 22
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(286, 31)
        Me.LabelControl2.TabIndex = 23
        Me.LabelControl2.Text = "New Purchase Request"
        '
        'grid_order
        '
        Me.grid_order.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_order.Location = New System.Drawing.Point(556, 73)
        Me.grid_order.MainView = Me.grid_order_view
        Me.grid_order.Name = "grid_order"
        Me.grid_order.Size = New System.Drawing.Size(600, 594)
        Me.grid_order.TabIndex = 24
        Me.grid_order.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_order_view})
        '
        'grid_order_view
        '
        Me.grid_order_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_qty, Me.col_unit, Me.col_model, Me.col_description, Me.col_pid, Me.col_brand, Me.col_supplier})
        Me.grid_order_view.GridControl = Me.grid_order
        Me.grid_order_view.Name = "grid_order_view"
        '
        'col_qty
        '
        Me.col_qty.Caption = "QTY"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 60
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        Me.col_qty.Width = 50
        '
        'col_unit
        '
        Me.col_unit.Caption = "Unit"
        Me.col_unit.FieldName = "unit"
        Me.col_unit.MaxWidth = 50
        Me.col_unit.Name = "col_unit"
        Me.col_unit.OptionsColumn.AllowEdit = False
        Me.col_unit.Visible = True
        Me.col_unit.VisibleIndex = 1
        Me.col_unit.Width = 40
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MaxWidth = 120
        Me.col_model.MinWidth = 23
        Me.col_model.Name = "col_model"
        Me.col_model.OptionsColumn.AllowEdit = False
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 3
        Me.col_model.Width = 120
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.OptionsColumn.AllowEdit = False
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 4
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 80
        Me.col_pid.Name = "col_pid"
        Me.col_pid.OptionsColumn.AllowEdit = False
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 5
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.MaxWidth = 100
        Me.col_brand.Name = "col_brand"
        Me.col_brand.OptionsColumn.AllowEdit = False
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 2
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 5
        Me.btn_submit.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.adddatasource
        Me.btn_submit.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_submit.Location = New System.Drawing.Point(983, 21)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(173, 46)
        Me.btn_submit.TabIndex = 25
        Me.btn_submit.Text = "Submit"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.AllowHtmlDraw = True
        Me.XtraTabControl1.Location = New System.Drawing.Point(12, 107)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(538, 415)
        Me.XtraTabControl1.TabIndex = 26
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.Controls.Add(Me.txt_search)
        Me.XtraTabPage1.Controls.Add(Me.LabelControl6)
        Me.XtraTabPage1.Controls.Add(Me.grid_search)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(536, 384)
        Me.XtraTabPage1.Text = "Search Item"
        '
        'txt_search
        '
        Me.txt_search.Client = Me.grid_search
        Me.txt_search.Location = New System.Drawing.Point(125, 13)
        Me.txt_search.Name = "txt_search"
        Me.txt_search.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Repository.ClearButton(), New DevExpress.XtraEditors.Repository.SearchButton()})
        Me.txt_search.Properties.Client = Me.grid_search
        Me.txt_search.Size = New System.Drawing.Size(254, 28)
        Me.txt_search.TabIndex = 21
        '
        'grid_search
        '
        Me.grid_search.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_search.Location = New System.Drawing.Point(3, 51)
        Me.grid_search.MainView = Me.grid_search_view
        Me.grid_search.Name = "grid_search"
        Me.grid_search.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_add})
        Me.grid_search.Size = New System.Drawing.Size(530, 326)
        Me.grid_search.TabIndex = 0
        Me.grid_search.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_search_view})
        '
        'grid_search_view
        '
        Me.grid_search_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_search_pid, Me.col_search_brand, Me.col_search_model, Me.col_search_unit, Me.col_search_description, Me.col_search_add, Me.col_search_supplier})
        Me.grid_search_view.GridControl = Me.grid_search
        Me.grid_search_view.Name = "grid_search_view"
        Me.grid_search_view.OptionsBehavior.ReadOnly = True
        Me.grid_search_view.OptionsView.ShowGroupPanel = False
        '
        'col_search_pid
        '
        Me.col_search_pid.Caption = "PID"
        Me.col_search_pid.FieldName = "pid"
        Me.col_search_pid.MinWidth = 23
        Me.col_search_pid.Name = "col_search_pid"
        Me.col_search_pid.Width = 87
        '
        'col_search_brand
        '
        Me.col_search_brand.Caption = "Brand"
        Me.col_search_brand.FieldName = "brand"
        Me.col_search_brand.MaxWidth = 93
        Me.col_search_brand.MinWidth = 23
        Me.col_search_brand.Name = "col_search_brand"
        Me.col_search_brand.OptionsColumn.AllowEdit = False
        Me.col_search_brand.Visible = True
        Me.col_search_brand.VisibleIndex = 0
        Me.col_search_brand.Width = 81
        '
        'col_search_model
        '
        Me.col_search_model.Caption = "Model"
        Me.col_search_model.FieldName = "winmodel"
        Me.col_search_model.MaxWidth = 120
        Me.col_search_model.MinWidth = 23
        Me.col_search_model.Name = "col_search_model"
        Me.col_search_model.OptionsColumn.AllowEdit = False
        Me.col_search_model.Visible = True
        Me.col_search_model.VisibleIndex = 1
        Me.col_search_model.Width = 112
        '
        'col_search_unit
        '
        Me.col_search_unit.Caption = "Unit"
        Me.col_search_unit.FieldName = "unit"
        Me.col_search_unit.Name = "col_search_unit"
        Me.col_search_unit.Visible = True
        Me.col_search_unit.VisibleIndex = 2
        Me.col_search_unit.Width = 70
        '
        'col_search_description
        '
        Me.col_search_description.Caption = "Description"
        Me.col_search_description.FieldName = "description"
        Me.col_search_description.MinWidth = 23
        Me.col_search_description.Name = "col_search_description"
        Me.col_search_description.OptionsColumn.AllowEdit = False
        Me.col_search_description.Visible = True
        Me.col_search_description.VisibleIndex = 3
        Me.col_search_description.Width = 192
        '
        'col_search_add
        '
        Me.col_search_add.ColumnEdit = Me.btn_add
        Me.col_search_add.MaxWidth = 40
        Me.col_search_add.Name = "col_search_add"
        Me.col_search_add.Visible = True
        Me.col_search_add.VisibleIndex = 4
        Me.col_search_add.Width = 40
        '
        'btn_add
        '
        Me.btn_add.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_addcircled
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_add.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_add.Name = "btn_add"
        Me.btn_add.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_search_supplier
        '
        Me.col_search_supplier.Caption = "Supplier ID"
        Me.col_search_supplier.FieldName = "supplier"
        Me.col_search_supplier.Name = "col_search_supplier"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 12.5!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(14, 17)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(96, 21)
        Me.LabelControl6.TabIndex = 1
        Me.LabelControl6.Text = "Search Item:"
        '
        'frm_purchaseorder_purchase_request
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1168, 679)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.grid_order)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_requested_by)
        Me.Controls.Add(Me.LabelControl8)
        Me.KeyPreview = True
        Me.Name = "frm_purchaseorder_purchase_request"
        Me.Text = "Purchase Request"
        CType(Me.txt_requested_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_order_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.XtraTabPage1.PerformLayout()
        CType(Me.txt_search.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_search_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_add, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_requested_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_order As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_order_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents txt_search As DevExpress.XtraEditors.SearchControl
    Friend WithEvents grid_search As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_search_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_search_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_search_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_search_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_search_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_search_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_search_add As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_add As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_unit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_search_supplier As DevExpress.XtraGrid.Columns.GridColumn
End Class
