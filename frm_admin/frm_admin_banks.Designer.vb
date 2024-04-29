<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_admin_banks
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
        Dim EditorButtonImageOptions5 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject17 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject18 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject19 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject20 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions6 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject21 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject22 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject23 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject24 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.grid_banks = New DevExpress.XtraGrid.GridControl()
        Me.grid_banks_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_id_debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank_name_debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_bank_acc_debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_fund_name_debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status_debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.toggle_status = New DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch()
        Me.col_is_debit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_is_credit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_new_bank = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.tab_banks = New DevExpress.XtraTab.XtraTabPage()
        Me.tab_terminals = New DevExpress.XtraTab.XtraTabPage()
        Me.grid_terminal = New DevExpress.XtraGrid.GridControl()
        Me.grid_terminal_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_terminal_view = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_terminal_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_terminal_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_assigned_credit_fund = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_new_terminal = New DevExpress.XtraEditors.SimpleButton()
        Me.col_account_type = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_banks, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_banks_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toggle_status, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.tab_banks.SuspendLayout()
        Me.tab_terminals.SuspendLayout()
        CType(Me.grid_terminal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_terminal_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_terminal_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_banks
        '
        Me.grid_banks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_banks.Location = New System.Drawing.Point(3, 3)
        Me.grid_banks.MainView = Me.grid_banks_view
        Me.grid_banks.Name = "grid_banks"
        Me.grid_banks.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.toggle_status, Me.btn_edit})
        Me.grid_banks.Size = New System.Drawing.Size(1154, 530)
        Me.grid_banks.TabIndex = 53
        Me.grid_banks.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_banks_view})
        '
        'grid_banks_view
        '
        Me.grid_banks_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_banks_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_banks_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_banks_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_banks_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_banks_view.Appearance.Row.Options.UseFont = True
        Me.grid_banks_view.Appearance.Row.Options.UseTextOptions = True
        Me.grid_banks_view.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_banks_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_edit, Me.col_id_debit, Me.col_bank_name_debit, Me.col_bank_acc_debit, Me.col_fund_name_debit, Me.col_status_debit, Me.col_is_debit, Me.col_is_credit, Me.col_account_type})
        Me.grid_banks_view.GridControl = Me.grid_banks
        Me.grid_banks_view.Name = "grid_banks_view"
        Me.grid_banks_view.OptionsBehavior.ReadOnly = True
        '
        'col_edit
        '
        Me.col_edit.Caption = "Action"
        Me.col_edit.ColumnEdit = Me.btn_edit
        Me.col_edit.Name = "col_edit"
        Me.col_edit.Visible = True
        Me.col_edit.VisibleIndex = 0
        Me.col_edit.Width = 55
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        EditorButtonImageOptions5.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions5, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject17, SerializableAppearanceObject18, SerializableAppearanceObject19, SerializableAppearanceObject20, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_id_debit
        '
        Me.col_id_debit.Caption = "Bank ID"
        Me.col_id_debit.FieldName = "bank_id"
        Me.col_id_debit.MaxWidth = 100
        Me.col_id_debit.Name = "col_id_debit"
        Me.col_id_debit.Visible = True
        Me.col_id_debit.VisibleIndex = 1
        Me.col_id_debit.Width = 73
        '
        'col_bank_name_debit
        '
        Me.col_bank_name_debit.Caption = "Bank Name"
        Me.col_bank_name_debit.FieldName = "bank_acc_name"
        Me.col_bank_name_debit.Name = "col_bank_name_debit"
        Me.col_bank_name_debit.Visible = True
        Me.col_bank_name_debit.VisibleIndex = 2
        Me.col_bank_name_debit.Width = 235
        '
        'col_bank_acc_debit
        '
        Me.col_bank_acc_debit.Caption = "Bank Account No."
        Me.col_bank_acc_debit.FieldName = "bank_acc_no"
        Me.col_bank_acc_debit.Name = "col_bank_acc_debit"
        Me.col_bank_acc_debit.Visible = True
        Me.col_bank_acc_debit.VisibleIndex = 3
        Me.col_bank_acc_debit.Width = 156
        '
        'col_fund_name_debit
        '
        Me.col_fund_name_debit.Caption = "Fund Name"
        Me.col_fund_name_debit.FieldName = "fund_name"
        Me.col_fund_name_debit.MinWidth = 200
        Me.col_fund_name_debit.Name = "col_fund_name_debit"
        Me.col_fund_name_debit.Visible = True
        Me.col_fund_name_debit.VisibleIndex = 5
        Me.col_fund_name_debit.Width = 200
        '
        'col_status_debit
        '
        Me.col_status_debit.Caption = "Status"
        Me.col_status_debit.ColumnEdit = Me.toggle_status
        Me.col_status_debit.FieldName = "is_enabled"
        Me.col_status_debit.Name = "col_status_debit"
        Me.col_status_debit.Visible = True
        Me.col_status_debit.VisibleIndex = 8
        Me.col_status_debit.Width = 119
        '
        'toggle_status
        '
        Me.toggle_status.AutoHeight = False
        Me.toggle_status.LookAndFeel.SkinName = "VS2010"
        Me.toggle_status.LookAndFeel.UseDefaultLookAndFeel = False
        Me.toggle_status.Name = "toggle_status"
        Me.toggle_status.OffText = "Disabled"
        Me.toggle_status.OnText = "Enabled"
        '
        'col_is_debit
        '
        Me.col_is_debit.Caption = "Is Debit?"
        Me.col_is_debit.FieldName = "is_debit"
        Me.col_is_debit.MinWidth = 60
        Me.col_is_debit.Name = "col_is_debit"
        Me.col_is_debit.Visible = True
        Me.col_is_debit.VisibleIndex = 6
        Me.col_is_debit.Width = 83
        '
        'col_is_credit
        '
        Me.col_is_credit.Caption = "Is Credit?"
        Me.col_is_credit.FieldName = "is_credit"
        Me.col_is_credit.MinWidth = 60
        Me.col_is_credit.Name = "col_is_credit"
        Me.col_is_credit.Visible = True
        Me.col_is_credit.VisibleIndex = 7
        Me.col_is_credit.Width = 92
        '
        'btn_new_bank
        '
        Me.btn_new_bank.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_new_bank.Appearance.Options.UseFont = True
        Me.btn_new_bank.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_bank.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_bank.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.adddatasource
        Me.btn_new_bank.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_new_bank.Location = New System.Drawing.Point(12, 58)
        Me.btn_new_bank.Name = "btn_new_bank"
        Me.btn_new_bank.Size = New System.Drawing.Size(138, 46)
        Me.btn_new_bank.TabIndex = 54
        Me.btn_new_bank.Text = "New Bank"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(215, 31)
        Me.LabelControl1.TabIndex = 55
        Me.LabelControl1.Text = "Registered Banks"
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XtraTabControl1.Location = New System.Drawing.Point(5, 111)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.tab_banks
        Me.XtraTabControl1.Size = New System.Drawing.Size(1162, 567)
        Me.XtraTabControl1.TabIndex = 56
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.tab_banks, Me.tab_terminals})
        '
        'tab_banks
        '
        Me.tab_banks.Controls.Add(Me.grid_banks)
        Me.tab_banks.Name = "tab_banks"
        Me.tab_banks.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_banks.Size = New System.Drawing.Size(1160, 536)
        Me.tab_banks.Text = "Registered Banks"
        '
        'tab_terminals
        '
        Me.tab_terminals.Controls.Add(Me.grid_terminal)
        Me.tab_terminals.Name = "tab_terminals"
        Me.tab_terminals.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_terminals.Size = New System.Drawing.Size(1152, 525)
        Me.tab_terminals.Text = "Registered Terminals"
        '
        'grid_terminal
        '
        Me.grid_terminal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_terminal.Location = New System.Drawing.Point(3, 3)
        Me.grid_terminal.MainView = Me.grid_terminal_view
        Me.grid_terminal.Name = "grid_terminal"
        Me.grid_terminal.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_terminal_view})
        Me.grid_terminal.Size = New System.Drawing.Size(1146, 519)
        Me.grid_terminal.TabIndex = 54
        Me.grid_terminal.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_terminal_view})
        '
        'grid_terminal_view
        '
        Me.grid_terminal_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_terminal_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_terminal_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_terminal_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_terminal_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_terminal_view.Appearance.Row.Options.UseFont = True
        Me.grid_terminal_view.Appearance.Row.Options.UseTextOptions = True
        Me.grid_terminal_view.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_terminal_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.col_terminal_id, Me.col_terminal_name, Me.col_assigned_credit_fund})
        Me.grid_terminal_view.GridControl = Me.grid_terminal
        Me.grid_terminal_view.Name = "grid_terminal_view"
        Me.grid_terminal_view.OptionsBehavior.ReadOnly = True
        Me.grid_terminal_view.OptionsView.ColumnAutoWidth = False
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Action"
        Me.GridColumn1.ColumnEdit = Me.btn_terminal_view
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.Visible = True
        Me.GridColumn1.VisibleIndex = 0
        Me.GridColumn1.Width = 59
        '
        'btn_terminal_view
        '
        Me.btn_terminal_view.AutoHeight = False
        EditorButtonImageOptions6.Image = Global.Inventory_Management.My.Resources.Resources.snapmodifytablecellstyle_16x16
        Me.btn_terminal_view.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions6, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject21, SerializableAppearanceObject22, SerializableAppearanceObject23, SerializableAppearanceObject24, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_terminal_view.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_terminal_view.Name = "btn_terminal_view"
        Me.btn_terminal_view.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_terminal_id
        '
        Me.col_terminal_id.Caption = "Terminal ID"
        Me.col_terminal_id.FieldName = "terminal_id"
        Me.col_terminal_id.MaxWidth = 100
        Me.col_terminal_id.Name = "col_terminal_id"
        Me.col_terminal_id.Visible = True
        Me.col_terminal_id.VisibleIndex = 1
        Me.col_terminal_id.Width = 86
        '
        'col_terminal_name
        '
        Me.col_terminal_name.Caption = "Terminal Name"
        Me.col_terminal_name.FieldName = "terminal_name"
        Me.col_terminal_name.Name = "col_terminal_name"
        Me.col_terminal_name.Visible = True
        Me.col_terminal_name.VisibleIndex = 2
        Me.col_terminal_name.Width = 250
        '
        'col_assigned_credit_fund
        '
        Me.col_assigned_credit_fund.Caption = "Assigned Credit Fund"
        Me.col_assigned_credit_fund.FieldName = "assigned_fund_name"
        Me.col_assigned_credit_fund.Name = "col_assigned_credit_fund"
        Me.col_assigned_credit_fund.Visible = True
        Me.col_assigned_credit_fund.VisibleIndex = 3
        Me.col_assigned_credit_fund.Width = 250
        '
        'btn_new_terminal
        '
        Me.btn_new_terminal.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_new_terminal.Appearance.Options.UseFont = True
        Me.btn_new_terminal.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_new_terminal.ImageOptions.ImageToTextIndent = 5
        Me.btn_new_terminal.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.adddatasource
        Me.btn_new_terminal.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_new_terminal.Location = New System.Drawing.Point(156, 59)
        Me.btn_new_terminal.Name = "btn_new_terminal"
        Me.btn_new_terminal.Size = New System.Drawing.Size(138, 46)
        Me.btn_new_terminal.TabIndex = 57
        Me.btn_new_terminal.Text = "New Terminal"
        '
        'col_account_type
        '
        Me.col_account_type.Caption = "Account Type"
        Me.col_account_type.FieldName = "account_type"
        Me.col_account_type.Name = "col_account_type"
        Me.col_account_type.Visible = True
        Me.col_account_type.VisibleIndex = 4
        Me.col_account_type.Width = 103
        '
        'frm_admin_banks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1172, 680)
        Me.Controls.Add(Me.btn_new_terminal)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_new_bank)
        Me.Controls.Add(Me.XtraTabControl1)
        Me.Name = "frm_admin_banks"
        Me.Text = "Registered Banks"
        CType(Me.grid_banks, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_banks_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toggle_status, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.tab_banks.ResumeLayout(False)
        Me.tab_terminals.ResumeLayout(False)
        CType(Me.grid_terminal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_terminal_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_terminal_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_banks As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_banks_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank_name_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_bank_acc_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_new_bank As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents toggle_status As DevExpress.XtraEditors.Repository.RepositoryItemToggleSwitch
    Friend WithEvents col_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents col_fund_name_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_is_debit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_is_credit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents tab_banks As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents tab_terminals As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents grid_terminal As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_terminal_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_terminal_view As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_terminal_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_terminal_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_assigned_credit_fund As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_new_terminal As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_account_type As DevExpress.XtraGrid.Columns.GridColumn
End Class
