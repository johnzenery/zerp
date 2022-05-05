<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_stock_inventory
    Inherits System.Windows.Forms.Form

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
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.GunaPanel5 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.link_po_list = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.link_home = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.panel_content = New Guna.UI.WinForms.GunaPanel()
        Me.btn_export = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.TabPane = New DevExpress.XtraBars.Navigation.TabPane()
        Me.tab_mystore = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grid_mystore = New DevExpress.XtraGrid.GridControl()
        Me.grid_mystore_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_on_hold = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_location = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.tab_allstore = New DevExpress.XtraBars.Navigation.TabNavigationPage()
        Me.grid_all = New DevExpress.XtraGrid.GridControl()
        Me.grid_all_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_brand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_main_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_sub_category = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel5.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.panel_content.SuspendLayout()
        CType(Me.TabPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPane.SuspendLayout()
        Me.tab_mystore.SuspendLayout()
        CType(Me.grid_mystore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_mystore_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tab_allstore.SuspendLayout()
        CType(Me.grid_all, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_all_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.GunaPanel5)
        Me.panel_top.Controls.Add(Me.GunaLabel1)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(992, 78)
        Me.panel_top.TabIndex = 7
        '
        'GunaPanel5
        '
        Me.GunaPanel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel5.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel5.Controls.Add(Me.GunaPanel2)
        Me.GunaPanel5.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel5.Name = "GunaPanel5"
        Me.GunaPanel5.Size = New System.Drawing.Size(812, 27)
        Me.GunaPanel5.TabIndex = 6
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Controls.Add(Me.link_po_list)
        Me.GunaPanel2.Controls.Add(Me.LabelControl7)
        Me.GunaPanel2.Controls.Add(Me.link_home)
        Me.GunaPanel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel2.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(435, 27)
        Me.GunaPanel2.TabIndex = 1
        '
        'link_po_list
        '
        Me.link_po_list.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_po_list.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_po_list.Appearance.Options.UseFont = True
        Me.link_po_list.Appearance.Options.UseLinkColor = True
        Me.link_po_list.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearanceHovered.Options.UseForeColor = True
        Me.link_po_list.AppearanceHovered.Options.UseLinkColor = True
        Me.link_po_list.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_po_list.AppearancePressed.Options.UseLinkColor = True
        Me.link_po_list.Enabled = False
        Me.link_po_list.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_po_list.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_po_list.Location = New System.Drawing.Point(70, 5)
        Me.link_po_list.Name = "link_po_list"
        Me.link_po_list.ShowLineShadow = False
        Me.link_po_list.Size = New System.Drawing.Size(96, 18)
        Me.link_po_list.TabIndex = 7
        Me.link_po_list.Text = "Stock Inventory"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = ">"
        '
        'link_home
        '
        Me.link_home.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.link_home.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.link_home.Appearance.Options.UseFont = True
        Me.link_home.Appearance.Options.UseLinkColor = True
        Me.link_home.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceDisabled.Options.UseLinkColor = True
        Me.link_home.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearanceHovered.Options.UseForeColor = True
        Me.link_home.AppearanceHovered.Options.UseLinkColor = True
        Me.link_home.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.link_home.AppearancePressed.Options.UseLinkColor = True
        Me.link_home.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.link_home.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.link_home.Location = New System.Drawing.Point(13, 5)
        Me.link_home.Name = "link_home"
        Me.link_home.ShowLineShadow = False
        Me.link_home.Size = New System.Drawing.Size(37, 18)
        Me.link_home.TabIndex = 5
        Me.link_home.Text = "Home"
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel1.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(203, 31)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "Stock Inventory"
        '
        'panel_content
        '
        Me.panel_content.BackColor = System.Drawing.Color.White
        Me.panel_content.Controls.Add(Me.btn_export)
        Me.panel_content.Controls.Add(Me.btn_print)
        Me.panel_content.Controls.Add(Me.TabPane)
        Me.panel_content.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel_content.Location = New System.Drawing.Point(0, 78)
        Me.panel_content.Name = "panel_content"
        Me.panel_content.Size = New System.Drawing.Size(992, 628)
        Me.panel_content.TabIndex = 8
        '
        'btn_export
        '
        Me.btn_export.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_export.Appearance.Options.UseFont = True
        Me.btn_export.Appearance.Options.UseTextOptions = True
        Me.btn_export.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_export.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_export.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.exporttoxls_16x16
        Me.btn_export.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.btn_export.Location = New System.Drawing.Point(12, 18)
        Me.btn_export.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_export.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_export.Name = "btn_export"
        Me.btn_export.Size = New System.Drawing.Size(91, 28)
        Me.btn_export.TabIndex = 7
        Me.btn_export.Text = "Export"
        '
        'btn_print
        '
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.Appearance.Options.UseTextOptions = True
        Me.btn_print.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_print.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_print.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.print_16x16
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftBottom
        Me.btn_print.Location = New System.Drawing.Point(109, 18)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(91, 28)
        Me.btn_print.TabIndex = 6
        Me.btn_print.Text = "Print"
        '
        'TabPane
        '
        Me.TabPane.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPane.Appearance.BackColor = System.Drawing.Color.White
        Me.TabPane.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TabPane.Appearance.Options.UseBackColor = True
        Me.TabPane.Appearance.Options.UseFont = True
        Me.TabPane.AppearanceButton.Hovered.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.AppearanceButton.Hovered.Options.UseFont = True
        Me.TabPane.AppearanceButton.Normal.BackColor = System.Drawing.Color.White
        Me.TabPane.AppearanceButton.Normal.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.AppearanceButton.Normal.Options.UseBackColor = True
        Me.TabPane.AppearanceButton.Normal.Options.UseFont = True
        Me.TabPane.AppearanceButton.Pressed.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.AppearanceButton.Pressed.Options.UseFont = True
        Me.TabPane.Controls.Add(Me.tab_mystore)
        Me.TabPane.Controls.Add(Me.tab_allstore)
        Me.TabPane.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.TabPane.Location = New System.Drawing.Point(5, 52)
        Me.TabPane.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.TabPane.LookAndFeel.UseDefaultLookAndFeel = False
        Me.TabPane.Name = "TabPane"
        Me.TabPane.PageProperties.AppearanceCaption.BackColor = System.Drawing.Color.White
        Me.TabPane.PageProperties.AppearanceCaption.Options.UseBackColor = True
        Me.TabPane.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.tab_mystore, Me.tab_allstore})
        Me.TabPane.RegularSize = New System.Drawing.Size(982, 570)
        Me.TabPane.SelectedPage = Me.tab_mystore
        Me.TabPane.Size = New System.Drawing.Size(982, 570)
        Me.TabPane.TabAlignment = DevExpress.XtraEditors.Alignment.Near
        Me.TabPane.TabIndex = 1
        Me.TabPane.Text = "TabPane1"
        '
        'tab_mystore
        '
        Me.tab_mystore.Caption = "My Store"
        Me.tab_mystore.Controls.Add(Me.grid_mystore)
        Me.tab_mystore.Name = "tab_mystore"
        Me.tab_mystore.Size = New System.Drawing.Size(982, 538)
        '
        'grid_mystore
        '
        Me.grid_mystore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_mystore.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grid_mystore.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grid_mystore.Location = New System.Drawing.Point(0, 0)
        Me.grid_mystore.MainView = Me.grid_mystore_view
        Me.grid_mystore.Name = "grid_mystore"
        Me.grid_mystore.Size = New System.Drawing.Size(982, 538)
        Me.grid_mystore.TabIndex = 1
        Me.grid_mystore.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_mystore_view})
        '
        'grid_mystore_view
        '
        Me.grid_mystore_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Yellow
        Me.grid_mystore_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_mystore_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_mystore_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_mystore_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_mystore_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_mystore_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_mystore_view.Appearance.Row.Options.UseFont = True
        Me.grid_mystore_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grid_mystore_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_pid, Me.col_winmodel, Me.col_brand, Me.col_main_category, Me.col_sub_category, Me.col_description, Me.col_qty, Me.col_on_hold, Me.col_location})
        Me.grid_mystore_view.GridControl = Me.grid_mystore
        Me.grid_mystore_view.Name = "grid_mystore_view"
        Me.grid_mystore_view.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grid_mystore_view.OptionsEditForm.EditFormColumnCount = 1
        Me.grid_mystore_view.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_mystore_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "Product ID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Visible = True
        Me.col_pid.VisibleIndex = 0
        Me.col_pid.Width = 86
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Winland Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 222
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 5
        Me.col_description.Width = 466
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Quantity"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 6
        Me.col_qty.Width = 100
        '
        'col_on_hold
        '
        Me.col_on_hold.AppearanceCell.Options.UseTextOptions = True
        Me.col_on_hold.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_on_hold.Caption = "On Hold"
        Me.col_on_hold.FieldName = "on_hold"
        Me.col_on_hold.Name = "col_on_hold"
        Me.col_on_hold.Visible = True
        Me.col_on_hold.VisibleIndex = 7
        Me.col_on_hold.Width = 102
        '
        'col_location
        '
        Me.col_location.AppearanceCell.Options.UseTextOptions = True
        Me.col_location.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_location.Caption = "Location"
        Me.col_location.FieldName = "location"
        Me.col_location.Name = "col_location"
        Me.col_location.Visible = True
        Me.col_location.VisibleIndex = 8
        '
        'tab_allstore
        '
        Me.tab_allstore.Caption = "All Stores"
        Me.tab_allstore.Controls.Add(Me.grid_all)
        Me.tab_allstore.Name = "tab_allstore"
        Me.tab_allstore.Padding = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.tab_allstore.Size = New System.Drawing.Size(982, 538)
        '
        'grid_all
        '
        Me.grid_all.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_all.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.grid_all.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grid_all.Location = New System.Drawing.Point(0, 0)
        Me.grid_all.MainView = Me.grid_all_view
        Me.grid_all.Name = "grid_all"
        Me.grid_all.Size = New System.Drawing.Size(982, 533)
        Me.grid_all.TabIndex = 0
        Me.grid_all.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_all_view})
        '
        'grid_all_view
        '
        Me.grid_all_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Yellow
        Me.grid_all_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_all_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_all_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_all_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_all_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_all_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_all_view.Appearance.Row.Options.UseFont = True
        Me.grid_all_view.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.grid_all_view.GridControl = Me.grid_all
        Me.grid_all_view.Name = "grid_all_view"
        Me.grid_all_view.OptionsBehavior.Editable = False
        '
        'col_brand
        '
        Me.col_brand.Caption = "Brand"
        Me.col_brand.FieldName = "brand"
        Me.col_brand.Name = "col_brand"
        Me.col_brand.Visible = True
        Me.col_brand.VisibleIndex = 2
        '
        'col_main_category
        '
        Me.col_main_category.Caption = "Category"
        Me.col_main_category.FieldName = "main_category"
        Me.col_main_category.Name = "col_main_category"
        Me.col_main_category.Visible = True
        Me.col_main_category.VisibleIndex = 3
        '
        'col_sub_category
        '
        Me.col_sub_category.Caption = "Sub Category"
        Me.col_sub_category.FieldName = "sub_category"
        Me.col_sub_category.Name = "col_sub_category"
        Me.col_sub_category.Visible = True
        Me.col_sub_category.VisibleIndex = 4
        '
        'frm_warehouse_stock_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 706)
        Me.Controls.Add(Me.panel_content)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_warehouse_stock_inventory"
        Me.Text = "Stock Inventory"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel5.ResumeLayout(False)
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel2.PerformLayout()
        Me.panel_content.ResumeLayout(False)
        CType(Me.TabPane, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPane.ResumeLayout(False)
        Me.tab_mystore.ResumeLayout(False)
        CType(Me.grid_mystore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_mystore_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tab_allstore.ResumeLayout(False)
        CType(Me.grid_all, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_all_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPanel5 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents link_po_list As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents link_home As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents panel_content As Guna.UI.WinForms.GunaPanel
    Friend WithEvents TabPane As DevExpress.XtraBars.Navigation.TabPane
    Friend WithEvents tab_mystore As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents grid_mystore As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_mystore_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents tab_allstore As DevExpress.XtraBars.Navigation.TabNavigationPage
    Friend WithEvents grid_all As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_all_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_on_hold As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_export As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_location As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_brand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_main_category As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_sub_category As DevExpress.XtraGrid.Columns.GridColumn
End Class
