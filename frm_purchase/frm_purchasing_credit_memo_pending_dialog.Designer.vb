<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_purchasing_credit_memo_pending_dialog
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.grid_pending_credits = New DevExpress.XtraGrid.GridControl()
        Me.grid_pending_credits_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_rid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_cost = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_model = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_credit_ref = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_supplier = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.grid_pending_credits, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_pending_credits_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(232, 38)
        Me.LabelControl1.TabIndex = 21
        Me.LabelControl1.Text = "Pending Credits"
        '
        'grid_pending_credits
        '
        Me.grid_pending_credits.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_pending_credits.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_pending_credits.Location = New System.Drawing.Point(-4, 79)
        Me.grid_pending_credits.MainView = Me.grid_pending_credits_view
        Me.grid_pending_credits.Margin = New System.Windows.Forms.Padding(4)
        Me.grid_pending_credits.Name = "grid_pending_credits"
        Me.grid_pending_credits.Size = New System.Drawing.Size(1256, 586)
        Me.grid_pending_credits.TabIndex = 22
        Me.grid_pending_credits.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_pending_credits_view})
        '
        'grid_pending_credits_view
        '
        Me.grid_pending_credits_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_rid, Me.col_qty, Me.col_cost, Me.col_model, Me.col_description, Me.col_status, Me.col_credit_ref, Me.col_supplier})
        Me.grid_pending_credits_view.DetailHeight = 431
        Me.grid_pending_credits_view.GridControl = Me.grid_pending_credits
        Me.grid_pending_credits_view.Name = "grid_pending_credits_view"
        Me.grid_pending_credits_view.OptionsBehavior.ReadOnly = True
        '
        'col_id
        '
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.MaxWidth = 58
        Me.col_id.MinWidth = 23
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 58
        '
        'col_rid
        '
        Me.col_rid.Caption = "RID"
        Me.col_rid.FieldName = "rid"
        Me.col_rid.MaxWidth = 93
        Me.col_rid.MinWidth = 23
        Me.col_rid.Name = "col_rid"
        Me.col_rid.Visible = True
        Me.col_rid.VisibleIndex = 1
        Me.col_rid.Width = 93
        '
        'col_qty
        '
        Me.col_qty.Caption = "QTY"
        Me.col_qty.FieldName = "qty_received"
        Me.col_qty.MaxWidth = 93
        Me.col_qty.MinWidth = 23
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 2
        Me.col_qty.Width = 93
        '
        'col_cost
        '
        Me.col_cost.Caption = "Cost"
        Me.col_cost.DisplayFormat.FormatString = "n2"
        Me.col_cost.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_cost.FieldName = "credit_cost"
        Me.col_cost.MaxWidth = 117
        Me.col_cost.MinWidth = 23
        Me.col_cost.Name = "col_cost"
        Me.col_cost.Visible = True
        Me.col_cost.VisibleIndex = 3
        Me.col_cost.Width = 106
        '
        'col_model
        '
        Me.col_model.Caption = "Model"
        Me.col_model.FieldName = "winmodel"
        Me.col_model.MinWidth = 150
        Me.col_model.Name = "col_model"
        Me.col_model.Visible = True
        Me.col_model.VisibleIndex = 4
        Me.col_model.Width = 184
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 150
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 5
        Me.col_description.Width = 150
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.MaxWidth = 175
        Me.col_status.MinWidth = 23
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 6
        Me.col_status.Width = 149
        '
        'col_credit_ref
        '
        Me.col_credit_ref.Caption = "Credit Ref."
        Me.col_credit_ref.FieldName = "delivery_ref"
        Me.col_credit_ref.MaxWidth = 150
        Me.col_credit_ref.MinWidth = 25
        Me.col_credit_ref.Name = "col_credit_ref"
        Me.col_credit_ref.Visible = True
        Me.col_credit_ref.VisibleIndex = 7
        Me.col_credit_ref.Width = 150
        '
        'col_supplier
        '
        Me.col_supplier.Caption = "Supplier"
        Me.col_supplier.FieldName = "supplier"
        Me.col_supplier.MinWidth = 25
        Me.col_supplier.Name = "col_supplier"
        Me.col_supplier.Visible = True
        Me.col_supplier.VisibleIndex = 8
        Me.col_supplier.Width = 237
        '
        'frm_purchasing_credit_memo_pending_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1253, 660)
        Me.Controls.Add(Me.grid_pending_credits)
        Me.Controls.Add(Me.LabelControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frm_purchasing_credit_memo_pending_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pending Credits"
        CType(Me.grid_pending_credits, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_pending_credits_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents grid_pending_credits As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_pending_credits_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_rid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_cost As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_credit_ref As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_supplier As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_model As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
End Class
