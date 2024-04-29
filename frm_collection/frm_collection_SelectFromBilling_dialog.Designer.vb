<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_collection_SelectFromBilling_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_collection_SelectFromBilling_dialog))
        Me.grid_soa = New DevExpress.XtraGrid.GridControl()
        Me.grid_soa_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_soa_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_total = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_date_created = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_customer_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_select = New System.Windows.Forms.Button()
        CType(Me.grid_soa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_soa_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_soa
        '
        Me.grid_soa.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_soa.Location = New System.Drawing.Point(12, 57)
        Me.grid_soa.MainView = Me.grid_soa_view
        Me.grid_soa.Name = "grid_soa"
        Me.grid_soa.Size = New System.Drawing.Size(644, 335)
        Me.grid_soa.TabIndex = 1
        Me.grid_soa.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_soa_view})
        '
        'grid_soa_view
        '
        Me.grid_soa_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_soa_id, Me.col_customer, Me.col_total, Me.col_date_created, Me.col_customer_id})
        Me.grid_soa_view.GridControl = Me.grid_soa
        Me.grid_soa_view.Name = "grid_soa_view"
        Me.grid_soa_view.OptionsBehavior.Editable = False
        '
        'col_soa_id
        '
        Me.col_soa_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_soa_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_soa_id.AppearanceHeader.Options.UseTextOptions = True
        Me.col_soa_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_soa_id.Caption = "Billing ID"
        Me.col_soa_id.FieldName = "soa_id"
        Me.col_soa_id.MaxWidth = 100
        Me.col_soa_id.Name = "col_soa_id"
        Me.col_soa_id.Visible = True
        Me.col_soa_id.VisibleIndex = 0
        Me.col_soa_id.Width = 100
        '
        'col_customer
        '
        Me.col_customer.Caption = "Customer"
        Me.col_customer.FieldName = "customer"
        Me.col_customer.Name = "col_customer"
        Me.col_customer.Visible = True
        Me.col_customer.VisibleIndex = 1
        Me.col_customer.Width = 262
        '
        'col_total
        '
        Me.col_total.AppearanceCell.Options.UseTextOptions = True
        Me.col_total.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.col_total.AppearanceHeader.Options.UseTextOptions = True
        Me.col_total.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_total.Caption = "Total"
        Me.col_total.DisplayFormat.FormatString = "c2"
        Me.col_total.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_total.FieldName = "total"
        Me.col_total.MaxWidth = 120
        Me.col_total.Name = "col_total"
        Me.col_total.Visible = True
        Me.col_total.VisibleIndex = 2
        Me.col_total.Width = 96
        '
        'col_date_created
        '
        Me.col_date_created.AppearanceCell.Options.UseTextOptions = True
        Me.col_date_created.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_created.AppearanceHeader.Options.UseTextOptions = True
        Me.col_date_created.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_date_created.Caption = "Date Generated"
        Me.col_date_created.DisplayFormat.FormatString = "MM-dd-yyyy"
        Me.col_date_created.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col_date_created.FieldName = "print_date"
        Me.col_date_created.MaxWidth = 120
        Me.col_date_created.Name = "col_date_created"
        Me.col_date_created.Visible = True
        Me.col_date_created.VisibleIndex = 3
        Me.col_date_created.Width = 93
        '
        'col_customer_id
        '
        Me.col_customer_id.Caption = "Customer ID"
        Me.col_customer_id.FieldName = "customer_id"
        Me.col_customer_id.Name = "col_customer_id"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select Billing Statement"
        '
        'btn_select
        '
        Me.btn_select.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_select.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btn_select.Location = New System.Drawing.Point(544, 398)
        Me.btn_select.Name = "btn_select"
        Me.btn_select.Size = New System.Drawing.Size(112, 39)
        Me.btn_select.TabIndex = 3
        Me.btn_select.Text = "Select"
        Me.btn_select.UseVisualStyleBackColor = True
        '
        'frm_collection_SelectFromBilling_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 444)
        Me.Controls.Add(Me.btn_select)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grid_soa)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IconOptions.Icon = CType(resources.GetObject("frm_collection_SelectFromBilling_dialog.IconOptions.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_collection_SelectFromBilling_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Billing Statements"
        CType(Me.grid_soa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_soa_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_soa As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_soa_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_soa_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_customer As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_total As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_date_created As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_select As Button
    Friend WithEvents col_customer_id As DevExpress.XtraGrid.Columns.GridColumn
End Class
