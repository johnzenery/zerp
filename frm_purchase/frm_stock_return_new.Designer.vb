<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stock_return_new
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl = New DevExpress.XtraTab.XtraTabControl()
        Me.tab_store = New DevExpress.XtraTab.XtraTabPage()
        Me.btn_clear = New DevExpress.XtraEditors.SimpleButton()
        Me.cbb_supplier = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.cbb_warehouse = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl14 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl13 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_comments = New DevExpress.XtraEditors.MemoEdit()
        Me.txt_ref = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl12 = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_desc = New DevExpress.XtraEditors.LabelControl()
        Me.txt_description = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_supmodel = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_submit = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_serial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_issue = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_accessories = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_comments = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.se_qty = New DevExpress.XtraEditors.SpinEdit()
        Me.txt_acc = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_issue = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_serial = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_type = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_cost = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_model = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl.SuspendLayout()
        Me.tab_store.SuspendLayout()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_comments.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_supmodel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se_qty.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_acc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_issue.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_serial.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_model.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(265, 38)
        Me.LabelControl1.TabIndex = 133
        Me.LabelControl1.Text = "New Stock Return"
        '
        'XtraTabControl
        '
        Me.XtraTabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl.Location = New System.Drawing.Point(14, 80)
        Me.XtraTabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.XtraTabControl.Name = "XtraTabControl"
        Me.XtraTabControl.SelectedTabPage = Me.tab_store
        Me.XtraTabControl.Size = New System.Drawing.Size(1647, 911)
        Me.XtraTabControl.TabIndex = 134
        Me.XtraTabControl.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab_store})
        '
        'tab_store
        '
        Me.tab_store.Controls.Add(Me.btn_clear)
        Me.tab_store.Controls.Add(Me.cbb_supplier)
        Me.tab_store.Controls.Add(Me.cbb_warehouse)
        Me.tab_store.Controls.Add(Me.LabelControl14)
        Me.tab_store.Controls.Add(Me.LabelControl13)
        Me.tab_store.Controls.Add(Me.txt_comments)
        Me.tab_store.Controls.Add(Me.txt_ref)
        Me.tab_store.Controls.Add(Me.LabelControl12)
        Me.tab_store.Controls.Add(Me.lbl_desc)
        Me.tab_store.Controls.Add(Me.txt_description)
        Me.tab_store.Controls.Add(Me.btn_add)
        Me.tab_store.Controls.Add(Me.txt_supmodel)
        Me.tab_store.Controls.Add(Me.LabelControl11)
        Me.tab_store.Controls.Add(Me.btn_submit)
        Me.tab_store.Controls.Add(Me.grid_returns)
        Me.tab_store.Controls.Add(Me.LabelControl10)
        Me.tab_store.Controls.Add(Me.se_qty)
        Me.tab_store.Controls.Add(Me.txt_acc)
        Me.tab_store.Controls.Add(Me.LabelControl9)
        Me.tab_store.Controls.Add(Me.txt_issue)
        Me.tab_store.Controls.Add(Me.LabelControl8)
        Me.tab_store.Controls.Add(Me.txt_serial)
        Me.tab_store.Controls.Add(Me.LabelControl7)
        Me.tab_store.Controls.Add(Me.cbb_type)
        Me.tab_store.Controls.Add(Me.LabelControl6)
        Me.tab_store.Controls.Add(Me.txt_cost)
        Me.tab_store.Controls.Add(Me.LabelControl5)
        Me.tab_store.Controls.Add(Me.LabelControl4)
        Me.tab_store.Controls.Add(Me.txt_pid)
        Me.tab_store.Controls.Add(Me.LabelControl3)
        Me.tab_store.Controls.Add(Me.cbb_model)
        Me.tab_store.Controls.Add(Me.LabelControl2)
        Me.tab_store.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tab_store.Name = "tab_store"
        Me.tab_store.Size = New System.Drawing.Size(1645, 873)
        Me.tab_store.Text = "Store Unit"
        '
        'btn_clear
        '
        Me.btn_clear.Appearance.Options.UseFont = True
        Me.btn_clear.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_clear.ImageOptions.ImageToTextIndent = 10
        Me.btn_clear.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_clear.Location = New System.Drawing.Point(349, 773)
        Me.btn_clear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(69, 41)
        Me.btn_clear.TabIndex = 152
        Me.btn_clear.Text = "Clear"
        '
        'cbb_supplier
        '
        Me.cbb_supplier.Location = New System.Drawing.Point(120, 235)
        Me.cbb_supplier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_supplier.Name = "cbb_supplier"
        Me.cbb_supplier.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_supplier.Size = New System.Drawing.Size(280, 34)
        Me.cbb_supplier.TabIndex = 151
        '
        'cbb_warehouse
        '
        Me.cbb_warehouse.Location = New System.Drawing.Point(28, 775)
        Me.cbb_warehouse.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_warehouse.Name = "cbb_warehouse"
        Me.cbb_warehouse.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbb_warehouse.Properties.Appearance.Options.UseFont = True
        Me.cbb_warehouse.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_warehouse.Size = New System.Drawing.Size(240, 36)
        Me.cbb_warehouse.TabIndex = 150
        '
        'LabelControl14
        '
        Me.LabelControl14.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl14.Appearance.Options.UseFont = True
        Me.LabelControl14.Location = New System.Drawing.Point(28, 747)
        Me.LabelControl14.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl14.Name = "LabelControl14"
        Me.LabelControl14.Size = New System.Drawing.Size(86, 23)
        Me.LabelControl14.TabIndex = 149
        Me.LabelControl14.Text = "Warehouse"
        '
        'LabelControl13
        '
        Me.LabelControl13.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl13.Appearance.Options.UseFont = True
        Me.LabelControl13.Location = New System.Drawing.Point(28, 667)
        Me.LabelControl13.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl13.Name = "LabelControl13"
        Me.LabelControl13.Size = New System.Drawing.Size(83, 23)
        Me.LabelControl13.TabIndex = 55
        Me.LabelControl13.Text = "Comments"
        '
        'txt_comments
        '
        Me.txt_comments.Location = New System.Drawing.Point(125, 665)
        Me.txt_comments.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_comments.Name = "txt_comments"
        Me.txt_comments.Size = New System.Drawing.Size(280, 64)
        Me.txt_comments.TabIndex = 54
        '
        'txt_ref
        '
        Me.txt_ref.Location = New System.Drawing.Point(122, 623)
        Me.txt_ref.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_ref.Name = "txt_ref"
        Me.txt_ref.Properties.Appearance.Options.UseFont = True
        Me.txt_ref.Properties.UseReadOnlyAppearance = False
        Me.txt_ref.Size = New System.Drawing.Size(189, 34)
        Me.txt_ref.TabIndex = 53
        '
        'LabelControl12
        '
        Me.LabelControl12.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl12.Appearance.Options.UseFont = True
        Me.LabelControl12.Location = New System.Drawing.Point(26, 628)
        Me.LabelControl12.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl12.Name = "LabelControl12"
        Me.LabelControl12.Size = New System.Drawing.Size(75, 23)
        Me.LabelControl12.TabIndex = 52
        Me.LabelControl12.Text = "Reference"
        '
        'lbl_desc
        '
        Me.lbl_desc.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_desc.Appearance.Options.UseFont = True
        Me.lbl_desc.Location = New System.Drawing.Point(26, 166)
        Me.lbl_desc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lbl_desc.Name = "lbl_desc"
        Me.lbl_desc.Size = New System.Drawing.Size(86, 23)
        Me.lbl_desc.TabIndex = 51
        Me.lbl_desc.Text = "Description"
        '
        'txt_description
        '
        Me.txt_description.Location = New System.Drawing.Point(122, 160)
        Me.txt_description.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_description.Name = "txt_description"
        Me.txt_description.Properties.ReadOnly = True
        Me.txt_description.Size = New System.Drawing.Size(280, 68)
        Me.txt_description.TabIndex = 50
        '
        'btn_add
        '
        Me.btn_add.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.btn_add.Appearance.Options.UseBackColor = True
        Me.btn_add.Appearance.Options.UseFont = True
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.ImageToTextIndent = 10
        Me.btn_add.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_add.Location = New System.Drawing.Point(275, 773)
        Me.btn_add.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(69, 41)
        Me.btn_add.TabIndex = 49
        Me.btn_add.Text = "Add"
        '
        'txt_supmodel
        '
        Me.txt_supmodel.Location = New System.Drawing.Point(122, 118)
        Me.txt_supmodel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_supmodel.Name = "txt_supmodel"
        Me.txt_supmodel.Properties.Appearance.Options.UseFont = True
        Me.txt_supmodel.Properties.ReadOnly = True
        Me.txt_supmodel.Size = New System.Drawing.Size(189, 34)
        Me.txt_supmodel.TabIndex = 48
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl11.Appearance.Options.UseFont = True
        Me.LabelControl11.Location = New System.Drawing.Point(26, 123)
        Me.LabelControl11.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(86, 23)
        Me.LabelControl11.TabIndex = 47
        Me.LabelControl11.Text = "Sup. Model"
        '
        'btn_submit
        '
        Me.btn_submit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_submit.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_submit.Appearance.Options.UseBackColor = True
        Me.btn_submit.Appearance.Options.UseFont = True
        Me.btn_submit.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_submit.ImageOptions.ImageToTextIndent = 10
        Me.btn_submit.ImageOptions.SvgImageSize = New System.Drawing.Size(15, 15)
        Me.btn_submit.Location = New System.Drawing.Point(1510, 821)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(120, 43)
        Me.btn_submit.TabIndex = 46
        Me.btn_submit.Text = "Submit"
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_returns.Location = New System.Drawing.Point(425, 26)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_delete})
        Me.grid_returns.Size = New System.Drawing.Size(1205, 788)
        Me.grid_returns.TabIndex = 44
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_supmodel, Me.col_supplier, Me.col_cost, Me.col_serial, Me.col_type, Me.col_issue, Me.col_accessories, Me.col_delete, Me.col_ref, Me.col_comments})
        Me.grid_returns_view.DetailHeight = 431
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.Name = "grid_returns_view"
        '
        'col_qty
        '
        Me.col_qty.Caption = "QTY"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 58
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        Me.col_qty.Width = 58
        '
        'col_pid
        '
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MaxWidth = 82
        Me.col_pid.MinWidth = 23
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 1
        Me.col_pid.Width = 58
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Win. Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MinWidth = 23
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 2
        Me.col_winmodel.Width = 87
        '
        'col_supmodel
        '
        Me.col_supmodel.Caption = "Sup. Model"
        Me.col_supmodel.FieldName = "supmodel"
        Me.col_supmodel.MinWidth = 23
        Me.col_supmodel.Name = "col_supmodel"
        Me.col_supmodel.Visible = True
        Me.col_supmodel.VisibleIndex = 3
        Me.col_supmodel.Width = 87
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 23
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 4
        Me.col_supplier.Width = 87
        '
        'col_cost
        '
        Me.col_cost.Caption = "Cost"
        Me.col_cost.FieldName = "cost"
        Me.col_cost.MinWidth = 23
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 5
        Me.col_cost.Width = 87
        '
        'col_serial
        '
        Me.col_serial.Caption = "Serial"
        Me.col_serial.FieldName = "serial"
        Me.col_serial.MinWidth = 23
        Me.col_serial.Name = "col_serial"
        Me.col_serial.Visible = True
        Me.col_serial.VisibleIndex = 6
        Me.col_serial.Width = 87
        '
        'col_type
        '
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "type"
        Me.col_type.MinWidth = 23
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 7
        Me.col_type.Width = 87
        '
        'col_issue
        '
        Me.col_issue.Caption = "Issue / Defect"
        Me.col_issue.FieldName = "issue"
        Me.col_issue.MinWidth = 23
        Me.col_issue.Name = "col_issue"
        Me.col_issue.Visible = True
        Me.col_issue.VisibleIndex = 8
        Me.col_issue.Width = 87
        '
        'col_accessories
        '
        Me.col_accessories.Caption = "Accessories"
        Me.col_accessories.FieldName = "accessories"
        Me.col_accessories.MinWidth = 23
        Me.col_accessories.Name = "col_accessories"
        Me.col_accessories.Visible = True
        Me.col_accessories.VisibleIndex = 9
        Me.col_accessories.Width = 87
        '
        'col_delete
        '
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.MaxWidth = 47
        Me.col_delete.MinWidth = 23
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 12
        Me.col_delete.Width = 47
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        EditorButtonImageOptions1.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_removecircled
        EditorButtonImageOptions1.SvgImageSize = New System.Drawing.Size(23, 23)
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_ref
        '
        Me.col_ref.Caption = "Reference"
        Me.col_ref.FieldName = "reference"
        Me.col_ref.MaxWidth = 117
        Me.col_ref.MinWidth = 23
        Me.col_ref.Name = "col_ref"
        Me.col_ref.Visible = True
        Me.col_ref.VisibleIndex = 10
        Me.col_ref.Width = 87
        '
        'col_comments
        '
        Me.col_comments.Caption = "Comments"
        Me.col_comments.FieldName = "comments"
        Me.col_comments.MinWidth = 23
        Me.col_comments.Name = "col_comments"
        Me.col_comments.Visible = True
        Me.col_comments.VisibleIndex = 11
        Me.col_comments.Width = 87
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl10.Appearance.Options.UseFont = True
        Me.LabelControl10.Location = New System.Drawing.Point(23, 571)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(66, 23)
        Me.LabelControl10.TabIndex = 43
        Me.LabelControl10.Text = "Quantity"
        '
        'se_qty
        '
        Me.se_qty.EditValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.se_qty.Location = New System.Drawing.Point(120, 566)
        Me.se_qty.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.se_qty.Name = "se_qty"
        Me.se_qty.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.se_qty.Properties.MaxValue = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.se_qty.Properties.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.se_qty.Size = New System.Drawing.Size(117, 34)
        Me.se_qty.TabIndex = 42
        '
        'txt_acc
        '
        Me.txt_acc.Location = New System.Drawing.Point(120, 524)
        Me.txt_acc.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_acc.Name = "txt_acc"
        Me.txt_acc.Properties.Appearance.Options.UseFont = True
        Me.txt_acc.Properties.UseReadOnlyAppearance = False
        Me.txt_acc.Size = New System.Drawing.Size(280, 34)
        Me.txt_acc.TabIndex = 41
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl9.Appearance.Options.UseFont = True
        Me.LabelControl9.Location = New System.Drawing.Point(26, 529)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(86, 23)
        Me.LabelControl9.TabIndex = 40
        Me.LabelControl9.Text = "Accessories"
        '
        'txt_issue
        '
        Me.txt_issue.Location = New System.Drawing.Point(120, 423)
        Me.txt_issue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_issue.Name = "txt_issue"
        Me.txt_issue.Size = New System.Drawing.Size(280, 94)
        Me.txt_issue.TabIndex = 39
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(23, 430)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(66, 46)
        Me.LabelControl8.TabIndex = 38
        Me.LabelControl8.Text = "*Issue or" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Defect"
        '
        'txt_serial
        '
        Me.txt_serial.Location = New System.Drawing.Point(120, 382)
        Me.txt_serial.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_serial.Name = "txt_serial"
        Me.txt_serial.Properties.Appearance.Options.UseFont = True
        Me.txt_serial.Properties.UseReadOnlyAppearance = False
        Me.txt_serial.Size = New System.Drawing.Size(189, 34)
        Me.txt_serial.TabIndex = 37
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(23, 386)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(41, 23)
        Me.LabelControl7.TabIndex = 36
        Me.LabelControl7.Text = "Serial"
        '
        'cbb_type
        '
        Me.cbb_type.Location = New System.Drawing.Point(120, 337)
        Me.cbb_type.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_type.Name = "cbb_type"
        Me.cbb_type.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbb_type.Properties.Appearance.Options.UseFont = True
        Me.cbb_type.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_type.Properties.Items.AddRange(New Object() {"Pullout", "For Repair", "Replacement"})
        Me.cbb_type.Size = New System.Drawing.Size(189, 36)
        Me.cbb_type.TabIndex = 35
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(23, 345)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(43, 23)
        Me.LabelControl6.TabIndex = 34
        Me.LabelControl6.Text = "*Type"
        '
        'txt_cost
        '
        Me.txt_cost.Location = New System.Drawing.Point(122, 277)
        Me.txt_cost.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_cost.Name = "txt_cost"
        Me.txt_cost.Properties.Appearance.Options.UseFont = True
        Me.txt_cost.Properties.ReadOnly = True
        Me.txt_cost.Size = New System.Drawing.Size(120, 34)
        Me.txt_cost.TabIndex = 33
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(26, 282)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(34, 23)
        Me.LabelControl5.TabIndex = 32
        Me.LabelControl5.Text = "Cost"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(26, 240)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(62, 23)
        Me.LabelControl4.TabIndex = 30
        Me.LabelControl4.Text = "Supplier"
        '
        'txt_pid
        '
        Me.txt_pid.Location = New System.Drawing.Point(122, 32)
        Me.txt_pid.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txt_pid.Name = "txt_pid"
        Me.txt_pid.Properties.Appearance.Options.UseFont = True
        Me.txt_pid.Properties.ReadOnly = True
        Me.txt_pid.Size = New System.Drawing.Size(120, 34)
        Me.txt_pid.TabIndex = 29
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(26, 37)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(27, 23)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "PID"
        '
        'cbb_model
        '
        Me.cbb_model.Location = New System.Drawing.Point(122, 74)
        Me.cbb_model.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cbb_model.Name = "cbb_model"
        Me.cbb_model.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cbb_model.Properties.Appearance.Options.UseFont = True
        Me.cbb_model.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_model.Size = New System.Drawing.Size(189, 36)
        Me.cbb_model.TabIndex = 1
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(26, 81)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(94, 23)
        Me.LabelControl2.TabIndex = 0
        Me.LabelControl2.Text = "*Win. Model"
        '
        'frm_stock_return_new
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1675, 1006)
        Me.Controls.Add(Me.XtraTabControl)
        Me.Controls.Add(Me.LabelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frm_stock_return_new"
        Me.Text = "New Stock Return"
        CType(Me.XtraTabControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl.ResumeLayout(False)
        Me.tab_store.ResumeLayout(False)
        Me.tab_store.PerformLayout()
        CType(Me.cbb_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_comments.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_ref.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_description.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_supmodel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.se_qty.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_acc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_issue.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_serial.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_type.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_pid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_model.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents XtraTabControl As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab_store As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cbb_model As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents se_qty As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents txt_acc As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_issue As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_serial As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_type As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_cost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_submit As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_serial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_issue As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_accessories As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_supmodel As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_supmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_description As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lbl_desc As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents txt_ref As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl12 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl13 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_comments As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents col_comments As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cbb_warehouse As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl14 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_supplier As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents btn_clear As DevExpress.XtraEditors.SimpleButton
End Class
