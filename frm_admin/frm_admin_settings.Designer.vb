<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_settings
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
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.TileNavCategory1 = New DevExpress.XtraBars.Navigation.TileNavCategory()
        Me.nav_documents = New DevExpress.XtraBars.Navigation.NavigationPane()
        Me.NavigationPage1 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_company_name = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_company_info = New DevExpress.XtraEditors.MemoEdit()
        Me.NavigationPage2 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.me_payment_option_info = New DevExpress.XtraEditors.MemoEdit()
        Me.NavigationPage3 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_tax_code = New DevExpress.XtraGrid.GridControl()
        Me.grid_tax_code_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_tax_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tax_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tax_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_view_order = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_print = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_tax_rate = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.NavigationPage4 = New DevExpress.XtraBars.Navigation.NavigationPage()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_pullout_instruction = New DevExpress.XtraEditors.MemoEdit()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.nav_documents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.nav_documents.SuspendLayout()
        Me.NavigationPage1.SuspendLayout()
        CType(Me.txt_company_name.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_company_info.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage2.SuspendLayout()
        CType(Me.me_payment_option_info.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage3.SuspendLayout()
        CType(Me.grid_tax_code, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_tax_code_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_tax_rate.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NavigationPage4.SuspendLayout()
        CType(Me.txt_pullout_instruction.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileNavCategory1
        '
        Me.TileNavCategory1.Name = "TileNavCategory1"
        '
        '
        '
        Me.TileNavCategory1.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty
        '
        'nav_documents
        '
        Me.nav_documents.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nav_documents.Controls.Add(Me.NavigationPage1)
        Me.nav_documents.Controls.Add(Me.NavigationPage2)
        Me.nav_documents.Controls.Add(Me.NavigationPage3)
        Me.nav_documents.Controls.Add(Me.NavigationPage4)
        Me.nav_documents.Location = New System.Drawing.Point(2, 78)
        Me.nav_documents.Margin = New System.Windows.Forms.Padding(4)
        Me.nav_documents.Name = "nav_documents"
        Me.nav_documents.Pages.AddRange(New DevExpress.XtraBars.Navigation.NavigationPageBase() {Me.NavigationPage1, Me.NavigationPage2, Me.NavigationPage3, Me.NavigationPage4})
        Me.nav_documents.RegularSize = New System.Drawing.Size(1382, 682)
        Me.nav_documents.SelectedPage = Me.NavigationPage1
        Me.nav_documents.Size = New System.Drawing.Size(1382, 682)
        Me.nav_documents.TabIndex = 13
        Me.nav_documents.Text = "Company Information"
        '
        'NavigationPage1
        '
        Me.NavigationPage1.Caption = "Company Information"
        Me.NavigationPage1.Controls.Add(Me.LabelControl3)
        Me.NavigationPage1.Controls.Add(Me.txt_company_name)
        Me.NavigationPage1.Controls.Add(Me.LabelControl1)
        Me.NavigationPage1.Controls.Add(Me.txt_company_info)
        Me.NavigationPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage1.Name = "NavigationPage1"
        Me.NavigationPage1.Size = New System.Drawing.Size(1155, 595)
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(24, 36)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(113, 20)
        Me.LabelControl3.TabIndex = 5
        Me.LabelControl3.Text = "Company Name"
        '
        'txt_company_name
        '
        Me.txt_company_name.Location = New System.Drawing.Point(24, 63)
        Me.txt_company_name.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_company_name.Name = "txt_company_name"
        Me.txt_company_name.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_company_name.Properties.Appearance.Options.UseFont = True
        Me.txt_company_name.Size = New System.Drawing.Size(490, 38)
        Me.txt_company_name.TabIndex = 4
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(24, 112)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(152, 20)
        Me.LabelControl1.TabIndex = 1
        Me.LabelControl1.Text = "Company Information"
        '
        'txt_company_info
        '
        Me.txt_company_info.Location = New System.Drawing.Point(24, 139)
        Me.txt_company_info.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_company_info.Name = "txt_company_info"
        Me.txt_company_info.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_company_info.Properties.Appearance.Options.UseFont = True
        Me.txt_company_info.Size = New System.Drawing.Size(490, 76)
        Me.txt_company_info.TabIndex = 0
        '
        'NavigationPage2
        '
        Me.NavigationPage2.Caption = "Billing Statement"
        Me.NavigationPage2.Controls.Add(Me.LabelControl4)
        Me.NavigationPage2.Controls.Add(Me.me_payment_option_info)
        Me.NavigationPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage2.Name = "NavigationPage2"
        Me.NavigationPage2.Size = New System.Drawing.Size(943, 552)
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(23, 32)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(147, 20)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Payment Information"
        '
        'me_payment_option_info
        '
        Me.me_payment_option_info.Location = New System.Drawing.Point(23, 59)
        Me.me_payment_option_info.Margin = New System.Windows.Forms.Padding(4)
        Me.me_payment_option_info.Name = "me_payment_option_info"
        Me.me_payment_option_info.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.me_payment_option_info.Properties.Appearance.Options.UseFont = True
        Me.me_payment_option_info.Size = New System.Drawing.Size(490, 457)
        Me.me_payment_option_info.TabIndex = 2
        '
        'NavigationPage3
        '
        Me.NavigationPage3.Caption = "Tax"
        Me.NavigationPage3.Controls.Add(Me.LabelControl8)
        Me.NavigationPage3.Controls.Add(Me.grid_tax_code)
        Me.NavigationPage3.Controls.Add(Me.LabelControl7)
        Me.NavigationPage3.Controls.Add(Me.txt_tax_rate)
        Me.NavigationPage3.Controls.Add(Me.LabelControl5)
        Me.NavigationPage3.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage3.Name = "NavigationPage3"
        Me.NavigationPage3.Size = New System.Drawing.Size(1155, 595)
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Arial", 6.5!)
        Me.LabelControl8.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Critical
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Appearance.Options.UseForeColor = True
        Me.LabelControl8.Location = New System.Drawing.Point(192, 19)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(191, 14)
        Me.LabelControl8.TabIndex = 135
        Me.LabelControl8.Text = "*need to exit the program to take effect."
        '
        'grid_tax_code
        '
        Me.grid_tax_code.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_tax_code.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_tax_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.grid_tax_code.Location = New System.Drawing.Point(20, 106)
        Me.grid_tax_code.MainView = Me.grid_tax_code_view
        Me.grid_tax_code.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_tax_code.Name = "grid_tax_code"
        Me.grid_tax_code.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_view_order, Me.btn_print})
        Me.grid_tax_code.Size = New System.Drawing.Size(1131, 485)
        Me.grid_tax_code.TabIndex = 134
        Me.grid_tax_code.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_tax_code_view})
        '
        'grid_tax_code_view
        '
        Me.grid_tax_code_view.Appearance.HeaderPanel.BackColor = System.Drawing.Color.White
        Me.grid_tax_code_view.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.grid_tax_code_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_tax_code_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_tax_code_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_tax_code_view.Appearance.Row.Options.UseFont = True
        Me.grid_tax_code_view.Appearance.SelectedRow.BackColor = System.Drawing.Color.White
        Me.grid_tax_code_view.Appearance.SelectedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grid_tax_code_view.Appearance.SelectedRow.Options.UseBackColor = True
        Me.grid_tax_code_view.Appearance.SelectedRow.Options.UseForeColor = True
        Me.grid_tax_code_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_tax_id, Me.col_tax_code, Me.col_tax_rate, Me.col_description})
        Me.grid_tax_code_view.DetailHeight = 431
        Me.grid_tax_code_view.GridControl = Me.grid_tax_code
        Me.grid_tax_code_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_tax_code_view.Name = "grid_tax_code_view"
        Me.grid_tax_code_view.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
        Me.grid_tax_code_view.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Save
        Me.grid_tax_code_view.OptionsEditForm.EditFormColumnCount = 1
        Me.grid_tax_code_view.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_tax_code_view.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_tax_code_view.OptionsView.ShowGroupPanel = False
        Me.grid_tax_code_view.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        '
        'col_tax_id
        '
        Me.col_tax_id.Caption = "ID"
        Me.col_tax_id.FieldName = "tax_id"
        Me.col_tax_id.MaxWidth = 80
        Me.col_tax_id.MinWidth = 25
        Me.col_tax_id.Name = "col_tax_id"
        Me.col_tax_id.OptionsColumn.ReadOnly = True
        Me.col_tax_id.Visible = True
        Me.col_tax_id.VisibleIndex = 0
        Me.col_tax_id.Width = 80
        '
        'col_tax_code
        '
        Me.col_tax_code.Caption = "Tax Code"
        Me.col_tax_code.FieldName = "tax_code"
        Me.col_tax_code.MaxWidth = 120
        Me.col_tax_code.MinWidth = 25
        Me.col_tax_code.Name = "col_tax_code"
        Me.col_tax_code.Visible = True
        Me.col_tax_code.VisibleIndex = 1
        Me.col_tax_code.Width = 94
        '
        'col_tax_rate
        '
        Me.col_tax_rate.Caption = "Rate"
        Me.col_tax_rate.DisplayFormat.FormatString = "p"
        Me.col_tax_rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_tax_rate.FieldName = "tax_rate"
        Me.col_tax_rate.MaxWidth = 100
        Me.col_tax_rate.MinWidth = 25
        Me.col_tax_rate.Name = "col_tax_rate"
        Me.col_tax_rate.Visible = True
        Me.col_tax_rate.VisibleIndex = 2
        Me.col_tax_rate.Width = 80
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 25
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 3
        Me.col_description.Width = 94
        '
        'btn_view_order
        '
        Me.btn_view_order.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_view_order.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_view_order.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_view_order.Name = "btn_view_order"
        Me.btn_view_order.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_print
        '
        Me.btn_print.AutoHeight = False
        EditorButtonImageOptions2.SvgImage = Global.Inventory_Management.My.Resources.Resources.print
        EditorButtonImageOptions2.SvgImageSize = New System.Drawing.Size(18, 18)
        Me.btn_print.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_print.Name = "btn_print"
        Me.btn_print.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Arial", 11.0!)
        Me.LabelControl7.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Hyperlink
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(20, 74)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(273, 21)
        Me.LabelControl7.TabIndex = 6
        Me.LabelControl7.Text = "Creditable Withholding Tax Codes"
        '
        'txt_tax_rate
        '
        Me.txt_tax_rate.Location = New System.Drawing.Point(110, 10)
        Me.txt_tax_rate.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_tax_rate.Name = "txt_tax_rate"
        Me.txt_tax_rate.Properties.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.txt_tax_rate.Properties.Appearance.Options.UseFont = True
        Me.txt_tax_rate.Properties.MaskSettings.Set("MaskManagerType", GetType(DevExpress.Data.Mask.NumericMaskManager))
        Me.txt_tax_rate.Size = New System.Drawing.Size(74, 34)
        Me.txt_tax_rate.TabIndex = 5
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(20, 19)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(82, 16)
        Me.LabelControl5.TabIndex = 4
        Me.LabelControl5.Text = "VAT rate (%)"
        '
        'NavigationPage4
        '
        Me.NavigationPage4.Caption = "Purchasing"
        Me.NavigationPage4.Controls.Add(Me.LabelControl6)
        Me.NavigationPage4.Controls.Add(Me.txt_pullout_instruction)
        Me.NavigationPage4.Margin = New System.Windows.Forms.Padding(4)
        Me.NavigationPage4.Name = "NavigationPage4"
        Me.NavigationPage4.Size = New System.Drawing.Size(943, 552)
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(23, 32)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(192, 20)
        Me.LabelControl6.TabIndex = 5
        Me.LabelControl6.Text = "Pullout Request Instruction"
        '
        'txt_pullout_instruction
        '
        Me.txt_pullout_instruction.Location = New System.Drawing.Point(23, 59)
        Me.txt_pullout_instruction.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_pullout_instruction.Name = "txt_pullout_instruction"
        Me.txt_pullout_instruction.Properties.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.txt_pullout_instruction.Properties.Appearance.Options.UseFont = True
        Me.txt_pullout_instruction.Size = New System.Drawing.Size(490, 457)
        Me.txt_pullout_instruction.TabIndex = 4
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_save.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Appearance.Options.UseFont = True
        Me.btn_save.Location = New System.Drawing.Point(1223, 775)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(150, 52)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Save"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(118, 38)
        Me.LabelControl2.TabIndex = 21
        Me.LabelControl2.Text = "Settings"
        '
        'frm_admin_settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1388, 837)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.nav_documents)
        Me.Controls.Add(Me.btn_save)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_admin_settings"
        Me.Text = "Settings"
        CType(Me.nav_documents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.nav_documents.ResumeLayout(False)
        Me.NavigationPage1.ResumeLayout(False)
        Me.NavigationPage1.PerformLayout()
        CType(Me.txt_company_name.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_company_info.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage2.ResumeLayout(False)
        Me.NavigationPage2.PerformLayout()
        CType(Me.me_payment_option_info.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage3.ResumeLayout(False)
        Me.NavigationPage3.PerformLayout()
        CType(Me.grid_tax_code, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_tax_code_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_view_order, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_print, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_tax_rate.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NavigationPage4.ResumeLayout(False)
        Me.NavigationPage4.PerformLayout()
        CType(Me.txt_pullout_instruction.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TileNavCategory1 As DevExpress.XtraBars.Navigation.TileNavCategory
    Friend WithEvents nav_documents As DevExpress.XtraBars.Navigation.NavigationPane
    Friend WithEvents NavigationPage1 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_company_info As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_company_name As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavigationPage2 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents me_payment_option_info As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents NavigationPage3 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents txt_tax_rate As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents NavigationPage4 As DevExpress.XtraBars.Navigation.NavigationPage
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_pullout_instruction As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_tax_code As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_tax_code_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_tax_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tax_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tax_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_view_order As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_print As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
End Class
