<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_barcode_label_list
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_barcode_label_list))
        Me.grid_labels = New DevExpress.XtraGrid.GridControl()
        Me.grid_labels_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_barcode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.se_qty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.btn_print_all = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print_selected = New DevExpress.XtraEditors.SimpleButton()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.grid_labels, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_labels_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.se_qty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_labels
        '
        Me.grid_labels.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_labels.Location = New System.Drawing.Point(12, 50)
        Me.grid_labels.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_labels.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_labels.MainView = Me.grid_labels_view
        Me.grid_labels.Name = "grid_labels"
        Me.grid_labels.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.se_qty})
        Me.grid_labels.Size = New System.Drawing.Size(690, 360)
        Me.grid_labels.TabIndex = 0
        Me.grid_labels.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_labels_view})
        '
        'grid_labels_view
        '
        Me.grid_labels_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_labels_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_labels_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_labels_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_labels_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_labels_view.Appearance.Row.Options.UseFont = True
        Me.grid_labels_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_model, Me.col_description, Me.col_barcode, Me.col_qty})
        Me.grid_labels_view.GridControl = Me.grid_labels
        Me.grid_labels_view.Name = "grid_labels_view"
        Me.grid_labels_view.OptionsSelection.CheckBoxSelectorColumnWidth = 40
        Me.grid_labels_view.OptionsSelection.MultiSelect = True
        Me.grid_labels_view.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "model"
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 3
        Me.col_model.Width = 142
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 4
        Me.col_description.Width = 258
        '
        'col_barcode
        '
        Me.col_barcode.Caption = "Barcode"
        Me.col_barcode.FieldName = "barcode"
        Me.col_barcode.Name = "col_barcode"
        Me.col_barcode.Visible = True
        Me.col_barcode.VisibleIndex = 2
        Me.col_barcode.Width = 93
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Qty"
        Me.col_qty.ColumnEdit = Me.se_qty
        Me.col_qty.DisplayFormat.FormatString = "n0"
        Me.col_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_qty.FieldName = "qty"
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 1
        Me.col_qty.Width = 58
        '
        'se_qty
        '
        Me.se_qty.AutoHeight = False
        Me.se_qty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.se_qty.Name = "se_qty"
        '
        'btn_print_all
        '
        Me.btn_print_all.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print_all.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_print_all.Appearance.Options.UseBackColor = True
        Me.btn_print_all.Location = New System.Drawing.Point(606, 419)
        Me.btn_print_all.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print_all.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print_all.Name = "btn_print_all"
        Me.btn_print_all.Size = New System.Drawing.Size(96, 33)
        Me.btn_print_all.TabIndex = 1
        Me.btn_print_all.Text = "Print All"
        '
        'btn_print_selected
        '
        Me.btn_print_selected.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_print_selected.Location = New System.Drawing.Point(504, 419)
        Me.btn_print_selected.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print_selected.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print_selected.Name = "btn_print_selected"
        Me.btn_print_selected.Size = New System.Drawing.Size(96, 33)
        Me.btn_print_selected.TabIndex = 2
        Me.btn_print_selected.Text = "Print Selected"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select items to print:"
        '
        'frm_warehouse_barcode_label_list
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(714, 463)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_print_selected)
        Me.Controls.Add(Me.btn_print_all)
        Me.Controls.Add(Me.grid_labels)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_barcode_label_list"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Labels"
        CType(Me.grid_labels, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_labels_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.se_qty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grid_labels As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_labels_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_print_all As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print_selected As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label1 As Label
    Friend WithEvents col_barcode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents se_qty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
End Class
