<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_sales_customers_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_customers_list))
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions2 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject5 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject6 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject7 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject8 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grid_customer = New DevExpress.XtraGrid.GridControl()
        Me.gridview_customer = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_action = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.button_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fname = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_contact_person = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_type = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_contact = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_addr = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_payment = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_shipping = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_trucking = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terms = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_assigned_agents = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_credit_limit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_used_credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_remaining_credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_other_notes = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_tin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_customer = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridview_customer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_edit
        '
        EditorButtonImageOptions1.Image = CType(resources.GetObject("EditorButtonImageOptions1.Image"), System.Drawing.Image)
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'grid_customer
        '
        Me.grid_customer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_customer.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.grid_customer.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.grid_customer.Location = New System.Drawing.Point(-1, 110)
        Me.grid_customer.LookAndFeel.SkinName = "WXI"
        Me.grid_customer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_customer.MainView = Me.gridview_customer
        Me.grid_customer.Name = "grid_customer"
        Me.grid_customer.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.button_edit})
        Me.grid_customer.Size = New System.Drawing.Size(1422, 494)
        Me.grid_customer.TabIndex = 53
        Me.grid_customer.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridview_customer})
        '
        'gridview_customer
        '
        Me.gridview_customer.Appearance.HeaderPanel.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.gridview_customer.Appearance.HeaderPanel.Options.UseFont = True
        Me.gridview_customer.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.gridview_customer.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_customer.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.gridview_customer.Appearance.Row.Options.UseFont = True
        Me.gridview_customer.Appearance.Row.Options.UseTextOptions = True
        Me.gridview_customer.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.gridview_customer.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_action, Me.col_id, Me.col_fname, Me.col_contact_person, Me.col_type, Me.col_contact, Me.col_addr, Me.col_payment, Me.col_shipping, Me.col_trucking, Me.col_terms, Me.col_assigned_agents, Me.col_credit_limit, Me.col_used_credit, Me.col_remaining_credit, Me.col_other_notes, Me.col_tin, Me.col_status})
        Me.gridview_customer.GridControl = Me.grid_customer
        Me.gridview_customer.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.gridview_customer.Name = "gridview_customer"
        Me.gridview_customer.OptionsBehavior.ReadOnly = True
        Me.gridview_customer.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[True]
        '
        'col_action
        '
        Me.col_action.ColumnEdit = Me.button_edit
        Me.col_action.MaxWidth = 50
        Me.col_action.Name = "col_action"
        Me.col_action.Visible = True
        Me.col_action.VisibleIndex = 0
        Me.col_action.Width = 46
        '
        'button_edit
        '
        Me.button_edit.AutoHeight = False
        EditorButtonImageOptions2.Image = Global.Inventory_Management.My.Resources.Resources.editcontact_16x16
        Me.button_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject5, SerializableAppearanceObject6, SerializableAppearanceObject7, SerializableAppearanceObject8, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.button_edit.Name = "button_edit"
        Me.button_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "customer_id"
        Me.col_id.MaxWidth = 50
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 1
        Me.col_id.Width = 50
        '
        'col_fname
        '
        Me.col_fname.AppearanceCell.Options.UseTextOptions = True
        Me.col_fname.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_fname.Caption = "Customer"
        Me.col_fname.FieldName = "first_name"
        Me.col_fname.Name = "col_fname"
        Me.col_fname.Visible = True
        Me.col_fname.VisibleIndex = 2
        Me.col_fname.Width = 219
        '
        'col_contact_person
        '
        Me.col_contact_person.AppearanceCell.Options.UseTextOptions = True
        Me.col_contact_person.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_contact_person.Caption = "Contact Person"
        Me.col_contact_person.FieldName = "contact_person"
        Me.col_contact_person.MaxWidth = 240
        Me.col_contact_person.Name = "col_contact_person"
        Me.col_contact_person.Visible = True
        Me.col_contact_person.VisibleIndex = 3
        Me.col_contact_person.Width = 130
        '
        'col_type
        '
        Me.col_type.AppearanceCell.Options.UseTextOptions = True
        Me.col_type.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_type.Caption = "Type"
        Me.col_type.FieldName = "account_type"
        Me.col_type.Name = "col_type"
        Me.col_type.Visible = True
        Me.col_type.VisibleIndex = 4
        Me.col_type.Width = 62
        '
        'col_contact
        '
        Me.col_contact.AppearanceCell.Options.UseTextOptions = True
        Me.col_contact.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_contact.Caption = "Contact No."
        Me.col_contact.FieldName = "contact"
        Me.col_contact.MaxWidth = 100
        Me.col_contact.Name = "col_contact"
        Me.col_contact.Visible = True
        Me.col_contact.VisibleIndex = 5
        Me.col_contact.Width = 72
        '
        'col_addr
        '
        Me.col_addr.AppearanceCell.Options.UseTextOptions = True
        Me.col_addr.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_addr.Caption = "Address"
        Me.col_addr.FieldName = "address"
        Me.col_addr.Name = "col_addr"
        Me.col_addr.Visible = True
        Me.col_addr.VisibleIndex = 6
        Me.col_addr.Width = 141
        '
        'col_payment
        '
        Me.col_payment.Caption = "Payment"
        Me.col_payment.FieldName = "preferred_payment"
        Me.col_payment.MaxWidth = 100
        Me.col_payment.Name = "col_payment"
        Me.col_payment.Visible = True
        Me.col_payment.VisibleIndex = 7
        Me.col_payment.Width = 69
        '
        'col_shipping
        '
        Me.col_shipping.Caption = "Shipping Option"
        Me.col_shipping.FieldName = "preferred_shipping"
        Me.col_shipping.MaxWidth = 100
        Me.col_shipping.Name = "col_shipping"
        Me.col_shipping.Visible = True
        Me.col_shipping.VisibleIndex = 8
        Me.col_shipping.Width = 69
        '
        'col_trucking
        '
        Me.col_trucking.AppearanceCell.Options.UseTextOptions = True
        Me.col_trucking.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.col_trucking.Caption = "Trucking"
        Me.col_trucking.FieldName = "trucking_note"
        Me.col_trucking.MaxWidth = 100
        Me.col_trucking.Name = "col_trucking"
        Me.col_trucking.Visible = True
        Me.col_trucking.VisibleIndex = 9
        Me.col_trucking.Width = 64
        '
        'col_terms
        '
        Me.col_terms.Caption = "Terms"
        Me.col_terms.FieldName = "terms"
        Me.col_terms.MaxWidth = 60
        Me.col_terms.Name = "col_terms"
        Me.col_terms.Visible = True
        Me.col_terms.VisibleIndex = 10
        Me.col_terms.Width = 56
        '
        'col_assigned_agents
        '
        Me.col_assigned_agents.Caption = "Assigned Agents"
        Me.col_assigned_agents.FieldName = "assigned_agents"
        Me.col_assigned_agents.MaxWidth = 130
        Me.col_assigned_agents.Name = "col_assigned_agents"
        Me.col_assigned_agents.Visible = True
        Me.col_assigned_agents.VisibleIndex = 11
        Me.col_assigned_agents.Width = 116
        '
        'col_credit_limit
        '
        Me.col_credit_limit.AppearanceHeader.Options.UseTextOptions = True
        Me.col_credit_limit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_credit_limit.Caption = "Credit Limit"
        Me.col_credit_limit.DisplayFormat.FormatString = "c2"
        Me.col_credit_limit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_credit_limit.FieldName = "credit_limit"
        Me.col_credit_limit.MaxWidth = 100
        Me.col_credit_limit.Name = "col_credit_limit"
        Me.col_credit_limit.Visible = True
        Me.col_credit_limit.VisibleIndex = 12
        Me.col_credit_limit.Width = 88
        '
        'col_used_credit
        '
        Me.col_used_credit.Caption = "Used Credit"
        Me.col_used_credit.DisplayFormat.FormatString = "c2"
        Me.col_used_credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_used_credit.FieldName = "used_credit"
        Me.col_used_credit.MaxWidth = 100
        Me.col_used_credit.Name = "col_used_credit"
        Me.col_used_credit.Visible = True
        Me.col_used_credit.VisibleIndex = 13
        Me.col_used_credit.Width = 76
        '
        'col_remaining_credit
        '
        Me.col_remaining_credit.Caption = "Remaining Credit"
        Me.col_remaining_credit.DisplayFormat.FormatString = "c2"
        Me.col_remaining_credit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_remaining_credit.FieldName = "remaining_credit"
        Me.col_remaining_credit.MaxWidth = 100
        Me.col_remaining_credit.Name = "col_remaining_credit"
        Me.col_remaining_credit.Visible = True
        Me.col_remaining_credit.VisibleIndex = 14
        Me.col_remaining_credit.Width = 99
        '
        'col_other_notes
        '
        Me.col_other_notes.Caption = "Other Notes"
        Me.col_other_notes.FieldName = "other_notes"
        Me.col_other_notes.Name = "col_other_notes"
        '
        'col_tin
        '
        Me.col_tin.Caption = "TIN"
        Me.col_tin.FieldName = "tin_no"
        Me.col_tin.Name = "col_tin"
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 15
        Me.col_status.Width = 35
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(271, 31)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Registered Customers"
        '
        'btn_customer
        '
        Me.btn_customer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_customer.Appearance.Options.UseFont = True
        Me.btn_customer.Appearance.Options.UseTextOptions = True
        Me.btn_customer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_customer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_customer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.employee_32x32
        Me.btn_customer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_customer.ImageOptions.ImageToTextIndent = 5
        Me.btn_customer.ImageOptions.SvgImageSize = New System.Drawing.Size(16, 16)
        Me.btn_customer.Location = New System.Drawing.Point(12, 58)
        Me.btn_customer.Name = "btn_customer"
        Me.btn_customer.Size = New System.Drawing.Size(160, 46)
        Me.btn_customer.TabIndex = 54
        Me.btn_customer.Text = "New Customer"
        '
        'frm_sales_customers_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1419, 603)
        Me.Controls.Add(Me.btn_customer)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.grid_customer)
        Me.Name = "frm_sales_customers_list"
        Me.Text = "Registered Customers"
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridview_customer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button_edit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_customer As DevExpress.XtraGrid.GridControl
    Friend WithEvents gridview_customer As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_fname As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_contact As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_addr As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_type As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_shipping As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_trucking As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_terms As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_credit_limit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_contact_person As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_other_notes As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_remaining_credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_used_credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_assigned_agents As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_tin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_customer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_action As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents button_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_payment As DevExpress.XtraGrid.Columns.GridColumn
End Class
