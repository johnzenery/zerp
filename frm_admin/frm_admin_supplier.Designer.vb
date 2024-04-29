<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_admin_supplier
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
        Me.btn_new = New DevExpress.XtraEditors.SimpleButton()
        Me.grid_supplier = New DevExpress.XtraGrid.GridControl()
        Me.grid_supplier_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_supid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_office_addr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_warehouse_addr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_contact_person = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tin_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_position = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tel_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_mobile_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fax_no = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_email = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_lead_time = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_acc_nos = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_zip_code = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_is_with_tax = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_atc = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cbb_tax_code = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
        Me.col_tax_rate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.grid_supplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_supplier_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_tax_code, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_new
        '
        Me.btn_new.Appearance.Font = New System.Drawing.Font("Arial", 8.5!)
        Me.btn_new.Appearance.Options.UseFont = True
        Me.btn_new.Appearance.Options.UseTextOptions = True
        Me.btn_new.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_new.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new.ImageOptions.ImageToTextIndent = 5
        Me.btn_new.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.adddatasource
        Me.btn_new.ImageOptions.SvgImageSize = New System.Drawing.Size(20, 20)
        Me.btn_new.Location = New System.Drawing.Point(14, 81)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(4)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(187, 57)
        Me.btn_new.TabIndex = 0
        Me.btn_new.Text = "New Supplier"
        '
        'grid_supplier
        '
        Me.grid_supplier.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_supplier.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_supplier.Location = New System.Drawing.Point(5, 148)
        Me.grid_supplier.MainView = Me.grid_supplier_view
        Me.grid_supplier.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_supplier.Name = "grid_supplier"
        Me.grid_supplier.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.cbb_tax_code})
        Me.grid_supplier.Size = New System.Drawing.Size(1389, 596)
        Me.grid_supplier.TabIndex = 52
        Me.grid_supplier.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_supplier_view})
        '
        'grid_supplier_view
        '
        Me.grid_supplier_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_supplier_view.Appearance.Row.Options.UseFont = True
        Me.grid_supplier_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_supid, Me.col_supplier_name, Me.col_office_addr, Me.col_warehouse_addr, Me.col_contact_person, Me.col_tin_no, Me.col_position, Me.col_tel_no, Me.col_mobile_no, Me.col_fax_no, Me.col_email, Me.col_lead_time, Me.col_terms, Me.col_acc_name, Me.col_acc_nos, Me.col_bank, Me.col_zip_code, Me.col_is_with_tax, Me.col_atc, Me.col_tax_rate})
        Me.grid_supplier_view.DetailHeight = 431
        Me.grid_supplier_view.GridControl = Me.grid_supplier
        Me.grid_supplier_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_supplier_view.Name = "grid_supplier_view"
        Me.grid_supplier_view.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.Inplace
        Me.grid_supplier_view.OptionsEditForm.EditFormColumnCount = 2
        Me.grid_supplier_view.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.[True]
        Me.grid_supplier_view.OptionsView.ColumnAutoWidth = False
        '
        'col_supid
        '
        Me.col_supid.Caption = "Supplier ID"
        Me.col_supid.FieldName = "id"
        Me.col_supid.MinWidth = 24
        Me.col_supid.Name = "col_supid"
        Me.col_supid.Visible = True
        Me.col_supid.VisibleIndex = 0
        Me.col_supid.Width = 87
        '
        'col_supplier_name
        '
        Me.col_supplier_name.AppearanceCell.Options.UseTextOptions = True
        Me.col_supplier_name.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_supplier_name.Caption = "Supplier Name"
        Me.col_supplier_name.FieldName = "supplier"
        Me.col_supplier_name.MinWidth = 24
        Me.col_supplier_name.Name = "col_supplier_name"
        Me.col_supplier_name.Visible = True
        Me.col_supplier_name.VisibleIndex = 1
        Me.col_supplier_name.Width = 125
        '
        'col_office_addr
        '
        Me.col_office_addr.AppearanceCell.Options.UseTextOptions = True
        Me.col_office_addr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_office_addr.Caption = "Office Address"
        Me.col_office_addr.FieldName = "office_addr"
        Me.col_office_addr.MinWidth = 24
        Me.col_office_addr.Name = "col_office_addr"
        Me.col_office_addr.Visible = True
        Me.col_office_addr.VisibleIndex = 2
        Me.col_office_addr.Width = 87
        '
        'col_warehouse_addr
        '
        Me.col_warehouse_addr.AppearanceCell.Options.UseTextOptions = True
        Me.col_warehouse_addr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_warehouse_addr.Caption = "Warehouse Address"
        Me.col_warehouse_addr.FieldName = "warehouse_addr"
        Me.col_warehouse_addr.MinWidth = 24
        Me.col_warehouse_addr.Name = "col_warehouse_addr"
        Me.col_warehouse_addr.Visible = True
        Me.col_warehouse_addr.VisibleIndex = 3
        Me.col_warehouse_addr.Width = 87
        '
        'col_contact_person
        '
        Me.col_contact_person.Caption = "Contact Person"
        Me.col_contact_person.FieldName = "contact_person"
        Me.col_contact_person.MinWidth = 24
        Me.col_contact_person.Name = "col_contact_person"
        Me.col_contact_person.Visible = True
        Me.col_contact_person.VisibleIndex = 9
        Me.col_contact_person.Width = 87
        '
        'col_tin_no
        '
        Me.col_tin_no.Caption = "TIN No."
        Me.col_tin_no.FieldName = "tin_no"
        Me.col_tin_no.MinWidth = 24
        Me.col_tin_no.Name = "col_tin_no"
        Me.col_tin_no.Visible = True
        Me.col_tin_no.VisibleIndex = 5
        Me.col_tin_no.Width = 134
        '
        'col_position
        '
        Me.col_position.Caption = "Position"
        Me.col_position.FieldName = "position"
        Me.col_position.MinWidth = 24
        Me.col_position.Name = "col_position"
        Me.col_position.Visible = True
        Me.col_position.VisibleIndex = 10
        Me.col_position.Width = 87
        '
        'col_tel_no
        '
        Me.col_tel_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_tel_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_tel_no.Caption = "Tel. No."
        Me.col_tel_no.FieldName = "tel_no"
        Me.col_tel_no.MinWidth = 24
        Me.col_tel_no.Name = "col_tel_no"
        Me.col_tel_no.Visible = True
        Me.col_tel_no.VisibleIndex = 11
        Me.col_tel_no.Width = 87
        '
        'col_mobile_no
        '
        Me.col_mobile_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_mobile_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_mobile_no.Caption = "Mobile No."
        Me.col_mobile_no.FieldName = "mobile_no"
        Me.col_mobile_no.MinWidth = 24
        Me.col_mobile_no.Name = "col_mobile_no"
        Me.col_mobile_no.Visible = True
        Me.col_mobile_no.VisibleIndex = 12
        Me.col_mobile_no.Width = 87
        '
        'col_fax_no
        '
        Me.col_fax_no.AppearanceCell.Options.UseTextOptions = True
        Me.col_fax_no.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_fax_no.Caption = "Fax No."
        Me.col_fax_no.FieldName = "fax_no"
        Me.col_fax_no.MinWidth = 24
        Me.col_fax_no.Name = "col_fax_no"
        Me.col_fax_no.Visible = True
        Me.col_fax_no.VisibleIndex = 13
        Me.col_fax_no.Width = 87
        '
        'col_email
        '
        Me.col_email.Caption = "Email"
        Me.col_email.FieldName = "email"
        Me.col_email.MinWidth = 24
        Me.col_email.Name = "col_email"
        Me.col_email.Visible = True
        Me.col_email.VisibleIndex = 14
        Me.col_email.Width = 87
        '
        'col_lead_time
        '
        Me.col_lead_time.Caption = "Lead Time (Days)"
        Me.col_lead_time.FieldName = "lead_time"
        Me.col_lead_time.MinWidth = 24
        Me.col_lead_time.Name = "col_lead_time"
        Me.col_lead_time.Visible = True
        Me.col_lead_time.VisibleIndex = 15
        Me.col_lead_time.Width = 87
        '
        'col_terms
        '
        Me.col_terms.Caption = "Terms (Days)"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.MinWidth = 24
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 16
        Me.col_terms.Width = 87
        '
        'col_acc_name
        '
        Me.col_acc_name.Caption = "Account Name"
        Me.col_acc_name.FieldName = "acc_name"
        Me.col_acc_name.MinWidth = 24
        Me.col_acc_name.Name = "col_acc_name"
        Me.col_acc_name.Visible = True
        Me.col_acc_name.VisibleIndex = 7
        Me.col_acc_name.Width = 87
        '
        'col_acc_nos
        '
        Me.col_acc_nos.Caption = "Account No"
        Me.col_acc_nos.FieldName = "acc_no"
        Me.col_acc_nos.MinWidth = 24
        Me.col_acc_nos.Name = "col_acc_nos"
        Me.col_acc_nos.Visible = True
        Me.col_acc_nos.VisibleIndex = 8
        Me.col_acc_nos.Width = 87
        '
        'col_bank
        '
        Me.col_bank.Caption = "Bank"
        Me.col_bank.FieldName = "bank"
        Me.col_bank.MinWidth = 24
        Me.col_bank.Name = "col_bank"
        Me.col_bank.Visible = True
        Me.col_bank.VisibleIndex = 6
        Me.col_bank.Width = 137
        '
        'col_zip_code
        '
        Me.col_zip_code.AppearanceCell.Options.UseTextOptions = True
        Me.col_zip_code.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_zip_code.Caption = "Zip Code"
        Me.col_zip_code.FieldName = "zip_code"
        Me.col_zip_code.MinWidth = 24
        Me.col_zip_code.Name = "col_zip_code"
        Me.col_zip_code.Visible = True
        Me.col_zip_code.VisibleIndex = 4
        Me.col_zip_code.Width = 87
        '
        'col_is_with_tax
        '
        Me.col_is_with_tax.Caption = "Apply WT"
        Me.col_is_with_tax.FieldName = "is_with_tax"
        Me.col_is_with_tax.MinWidth = 24
        Me.col_is_with_tax.Name = "col_is_with_tax"
        Me.col_is_with_tax.Visible = True
        Me.col_is_with_tax.VisibleIndex = 17
        Me.col_is_with_tax.Width = 87
        '
        'col_atc
        '
        Me.col_atc.Caption = "ATC"
        Me.col_atc.ColumnEdit = Me.cbb_tax_code
        Me.col_atc.FieldName = "tax_atc"
        Me.col_atc.MinWidth = 24
        Me.col_atc.Name = "col_atc"
        Me.col_atc.Visible = True
        Me.col_atc.VisibleIndex = 18
        Me.col_atc.Width = 116
        '
        'cbb_tax_code
        '
        Me.cbb_tax_code.AutoHeight = False
        Me.cbb_tax_code.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_tax_code.Name = "cbb_tax_code"
        '
        'col_tax_rate
        '
        Me.col_tax_rate.Caption = "Tax Rate (%)"
        Me.col_tax_rate.DisplayFormat.FormatString = "p"
        Me.col_tax_rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_tax_rate.FieldName = "tax_rate"
        Me.col_tax_rate.MinWidth = 24
        Me.col_tax_rate.Name = "col_tax_rate"
        Me.col_tax_rate.Visible = True
        Me.col_tax_rate.VisibleIndex = 19
        Me.col_tax_rate.Width = 115
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "GridColumn2"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 13
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(13, 13)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(317, 38)
        Me.LabelControl1.TabIndex = 53
        Me.LabelControl1.Text = "Supplier Management"
        '
        'frm_admin_supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1398, 748)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_supplier)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_admin_supplier"
        Me.Text = "Supplier Management"
        CType(Me.grid_supplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_supplier_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_tax_code, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_supplier As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_supplier_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btn_new As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_supid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_office_addr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_warehouse_addr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_contact_person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_position As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tel_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_mobile_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fax_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_email As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_lead_time As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_acc_nos As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_zip_code As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tin_no As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_is_with_tax As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_atc As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tax_rate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_tax_code As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
End Class
