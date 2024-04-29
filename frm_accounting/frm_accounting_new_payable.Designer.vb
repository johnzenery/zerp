<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_accounting_new_payable
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_accounting_new_payable))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_poid = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_cancel = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_create = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_discount = New DevExpress.XtraEditors.TextEdit()
        Me.txt_amount = New DevExpress.XtraEditors.TextEdit()
        Me.txt_supplier = New DevExpress.XtraEditors.TextEdit()
        Me.grid_po = New DevExpress.XtraGrid.GridControl()
        Me.grid_po_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_poid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.cbb_receipt = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_supplier.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbb_receipt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 61)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(133, 16)
        Me.LabelControl1.TabIndex = 13
        Me.LabelControl1.Text = "Select Purchase Order"
        '
        'txt_poid
        '
        Me.txt_poid.Location = New System.Drawing.Point(109, 251)
        Me.txt_poid.Name = "txt_poid"
        Me.txt_poid.Properties.ReadOnly = True
        Me.txt_poid.Properties.UseReadOnlyAppearance = False
        Me.txt_poid.Size = New System.Drawing.Size(104, 28)
        Me.txt_poid.TabIndex = 16
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 256)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(71, 16)
        Me.LabelControl2.TabIndex = 17
        Me.LabelControl2.Text = "Purchase ID"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 290)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(48, 16)
        Me.LabelControl3.TabIndex = 18
        Me.LabelControl3.Text = "Supplier"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 324)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(45, 16)
        Me.LabelControl4.TabIndex = 19
        Me.LabelControl4.Text = "Amount"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(12, 358)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(51, 16)
        Me.LabelControl5.TabIndex = 20
        Me.LabelControl5.Text = "Discount"
        '
        'btn_cancel
        '
        Me.btn_cancel.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_cancel.Appearance.Options.UseFont = True
        Me.btn_cancel.Location = New System.Drawing.Point(97, 399)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(149, 45)
        Me.btn_cancel.TabIndex = 22
        Me.btn_cancel.Text = "Cancel"
        '
        'btn_create
        '
        Me.btn_create.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_create.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.btn_create.Appearance.Options.UseBackColor = True
        Me.btn_create.Appearance.Options.UseFont = True
        Me.btn_create.Location = New System.Drawing.Point(252, 399)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(149, 45)
        Me.btn_create.TabIndex = 23
        Me.btn_create.Text = "Create"
        '
        'txt_discount
        '
        Me.txt_discount.Location = New System.Drawing.Point(109, 353)
        Me.txt_discount.Name = "txt_discount"
        Me.txt_discount.Properties.ReadOnly = True
        Me.txt_discount.Properties.UseReadOnlyAppearance = False
        Me.txt_discount.Size = New System.Drawing.Size(104, 28)
        Me.txt_discount.TabIndex = 25
        '
        'txt_amount
        '
        Me.txt_amount.Location = New System.Drawing.Point(109, 319)
        Me.txt_amount.Name = "txt_amount"
        Me.txt_amount.Properties.ReadOnly = True
        Me.txt_amount.Properties.UseReadOnlyAppearance = False
        Me.txt_amount.Size = New System.Drawing.Size(164, 28)
        Me.txt_amount.TabIndex = 26
        '
        'txt_supplier
        '
        Me.txt_supplier.Location = New System.Drawing.Point(109, 285)
        Me.txt_supplier.Name = "txt_supplier"
        Me.txt_supplier.Properties.ReadOnly = True
        Me.txt_supplier.Properties.UseReadOnlyAppearance = False
        Me.txt_supplier.Size = New System.Drawing.Size(292, 28)
        Me.txt_supplier.TabIndex = 27
        '
        'grid_po
        '
        Me.grid_po.Location = New System.Drawing.Point(6, 83)
        Me.grid_po.MainView = Me.grid_po_view
        Me.grid_po.Name = "grid_po"
        Me.grid_po.Size = New System.Drawing.Size(389, 156)
        Me.grid_po.TabIndex = 28
        Me.grid_po.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_po_view})
        '
        'grid_po_view
        '
        Me.grid_po_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_poid, Me.col_supplier})
        Me.grid_po_view.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None
        Me.grid_po_view.GridControl = Me.grid_po
        Me.grid_po_view.Name = "grid_po_view"
        Me.grid_po_view.OptionsBehavior.Editable = False
        Me.grid_po_view.OptionsBehavior.ReadOnly = True
        Me.grid_po_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_po_view.OptionsView.ShowGroupPanel = False
        '
        'col_poid
        '
        Me.col_poid.Caption = "Purchase ID"
        Me.col_poid.FieldName = "poid"
        Me.col_poid.MaxWidth = 80
        Me.col_poid.MinWidth = 80
        Me.col_poid.Name = "col_poid"
        Me.col_poid.Visible = True
        Me.col_poid.VisibleIndex = 0
        Me.col_poid.Width = 80
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 1
        Me.col_supplier.Width = 294
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(231, 358)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(76, 16)
        Me.LabelControl6.TabIndex = 29
        Me.LabelControl6.Text = "Receipt Type"
        '
        'cbb_receipt
        '
        Me.cbb_receipt.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbb_receipt.Location = New System.Drawing.Point(313, 353)
        Me.cbb_receipt.Name = "cbb_receipt"
        Me.cbb_receipt.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbb_receipt.Properties.Items.AddRange(New Object() {"DR", "SI-NV", "SI-VAT", "OR-NV", "OR-VAT"})
        Me.cbb_receipt.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbb_receipt.Size = New System.Drawing.Size(87, 28)
        Me.cbb_receipt.TabIndex = 87
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl7.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Appearance.Options.UseForeColor = True
        Me.LabelControl7.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(160, 31)
        Me.LabelControl7.TabIndex = 88
        Me.LabelControl7.Text = "New Payable"
        '
        'frm_accounting_new_payable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 452)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.cbb_receipt)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.grid_po)
        Me.Controls.Add(Me.txt_supplier)
        Me.Controls.Add(Me.txt_amount)
        Me.Controls.Add(Me.txt_discount)
        Me.Controls.Add(Me.btn_create)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.txt_poid)
        Me.Controls.Add(Me.LabelControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_accounting_new_payable.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_accounting_new_payable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Payable"
        CType(Me.txt_poid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_discount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_amount.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_supplier.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_po_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbb_receipt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_poid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btn_cancel As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_create As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_discount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_supplier As DevExpress.XtraEditors.TextEdit
    Friend WithEvents grid_po As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_po_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_poid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cbb_receipt As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
End Class
