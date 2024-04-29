<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_return_picker
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_return_picker))
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_customer_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_name = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_amount = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.coL_date = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_select = New System.Windows.Forms.Button()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_customer_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.Location = New System.Drawing.Point(0, 0)
        Me.grid_returns.MainView = Me.grid_customer_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.Size = New System.Drawing.Size(603, 337)
        Me.grid_returns.TabIndex = 13
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_customer_view})
        '
        'grid_customer_view
        '
        Me.grid_customer_view.Appearance.Row.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.grid_customer_view.Appearance.Row.Options.UseFont = True
        Me.grid_customer_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_name, Me.col_amount, Me.coL_date})
        Me.grid_customer_view.GridControl = Me.grid_returns
        Me.grid_customer_view.Name = "grid_customer_view"
        Me.grid_customer_view.OptionsBehavior.Editable = False
        Me.grid_customer_view.OptionsBehavior.ReadOnly = True
        Me.grid_customer_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_customer_view.OptionsView.ShowIndicator = False
        Me.grid_customer_view.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.[False]
        Me.grid_customer_view.OptionsView.WaitAnimationOptions = DevExpress.XtraEditors.WaitAnimationOptions.Indicator
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.MaxWidth = 100
        Me.col_id.MinWidth = 100
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 100
        '
        'col_name
        '
        Me.col_name.Caption = "Name"
        Me.col_name.FieldName = "customer"
        Me.col_name.Name = "col_name"
        Me.col_name.Visible = True
        Me.col_name.VisibleIndex = 1
        Me.col_name.Width = 271
        '
        'col_amount
        '
        Me.col_amount.Caption = "Amount"
        Me.col_amount.FieldName = "amount"
        Me.col_amount.MaxWidth = 120
        Me.col_amount.MinWidth = 120
        Me.col_amount.Name = "col_amount"
        Me.col_amount.Visible = True
        Me.col_amount.VisibleIndex = 3
        Me.col_amount.Width = 120
        '
        'coL_date
        '
        Me.coL_date.Caption = "Created at"
        Me.coL_date.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.coL_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.coL_date.FieldName = "created_at"
        Me.coL_date.MaxWidth = 120
        Me.coL_date.MinWidth = 120
        Me.coL_date.Name = "coL_date"
        Me.coL_date.Visible = True
        Me.coL_date.VisibleIndex = 2
        Me.coL_date.Width = 120
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.Location = New System.Drawing.Point(476, 346)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(115, 38)
        Me.btn_select.TabIndex = 14
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'frm_sales_return_picker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 394)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.grid_returns)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_sales_return_picker.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_sales_return_picker"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Deduct Sales Return"
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_customer_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_customer_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_name As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_select As Button
    Friend WithEvents col_amount As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents coL_date As DevExpress.XtraGrid.Columns.GridColumn
End Class
