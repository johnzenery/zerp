<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_returns_receive
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
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_update = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_received = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_srid = New DevExpress.XtraEditors.TextEdit()
        Me.txt_customer = New DevExpress.XtraEditors.TextEdit()
        Me.txt_created_by = New DevExpress.XtraEditors.TextEdit()
        Me.txt_warehouse = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.txt_notes = New DevExpress.XtraEditors.MemoEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_srid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_created_by.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_warehouse.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.pencolor_16x16
        Me.btn_update.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_update.Name = "btn_update"
        Me.btn_update.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grid_returns.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_returns.Location = New System.Drawing.Point(10, 143)
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.Size = New System.Drawing.Size(922, 418)
        Me.grid_returns.TabIndex = 12
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_returns_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_returns_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_returns_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_returns_view.Appearance.Row.Options.UseFont = True
        Me.grid_returns_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_qty, Me.col_pid, Me.col_winmodel, Me.col_description})
        Me.grid_returns_view.GridControl = Me.grid_returns
        Me.grid_returns_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_returns_view.Name = "grid_returns_view"
        Me.grid_returns_view.OptionsBehavior.ReadOnly = True
        Me.grid_returns_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_returns_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_returns_view.OptionsView.ShowGroupPanel = False
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Qty"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 100
        Me.col_qty.MinWidth = 19
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        Me.col_qty.Width = 85
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MinWidth = 79
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Width = 95
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.MinWidth = 19
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 120
        '
        'col_description
        '
        Me.col_description.Caption = "Description"
        Me.col_description.FieldName = "description"
        Me.col_description.MinWidth = 250
        Me.col_description.Name = "col_description"
        Me.col_description.Visible = True
        Me.col_description.VisibleIndex = 2
        Me.col_description.Width = 250
        '
        'btn_received
        '
        Me.btn_received.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_received.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_received.Appearance.Options.UseBackColor = True
        Me.btn_received.Location = New System.Drawing.Point(840, 567)
        Me.btn_received.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.btn_received.Name = "btn_received"
        Me.btn_received.Size = New System.Drawing.Size(92, 31)
        Me.btn_received.TabIndex = 137
        Me.btn_received.Text = "Receive"
        '
        'txt_srid
        '
        Me.txt_srid.Location = New System.Drawing.Point(103, 7)
        Me.txt_srid.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_srid.Name = "txt_srid"
        Me.txt_srid.Properties.ReadOnly = True
        Me.txt_srid.Size = New System.Drawing.Size(100, 28)
        Me.txt_srid.TabIndex = 140
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(103, 41)
        Me.txt_customer.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.Properties.ReadOnly = True
        Me.txt_customer.Size = New System.Drawing.Size(184, 28)
        Me.txt_customer.TabIndex = 141
        '
        'txt_created_by
        '
        Me.txt_created_by.Location = New System.Drawing.Point(103, 75)
        Me.txt_created_by.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_created_by.Name = "txt_created_by"
        Me.txt_created_by.Properties.ReadOnly = True
        Me.txt_created_by.Size = New System.Drawing.Size(184, 28)
        Me.txt_created_by.TabIndex = 142
        '
        'txt_warehouse
        '
        Me.txt_warehouse.Location = New System.Drawing.Point(103, 109)
        Me.txt_warehouse.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.txt_warehouse.Name = "txt_warehouse"
        Me.txt_warehouse.Properties.ReadOnly = True
        Me.txt_warehouse.Size = New System.Drawing.Size(184, 28)
        Me.txt_warehouse.TabIndex = 143
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabelControl5.Appearance.Options.UseFont = True
        Me.LabelControl5.Location = New System.Drawing.Point(13, 14)
        Me.LabelControl5.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(28, 16)
        Me.LabelControl5.TabIndex = 144
        Me.LabelControl5.Text = "SRID"
        '
        'LabelControl6
        '
        Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabelControl6.Appearance.Options.UseFont = True
        Me.LabelControl6.Location = New System.Drawing.Point(13, 48)
        Me.LabelControl6.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl6.Name = "LabelControl6"
        Me.LabelControl6.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl6.TabIndex = 145
        Me.LabelControl6.Text = "Customer"
        '
        'LabelControl7
        '
        Me.LabelControl7.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabelControl7.Appearance.Options.UseFont = True
        Me.LabelControl7.Location = New System.Drawing.Point(13, 82)
        Me.LabelControl7.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl7.Name = "LabelControl7"
        Me.LabelControl7.Size = New System.Drawing.Size(62, 16)
        Me.LabelControl7.TabIndex = 146
        Me.LabelControl7.Text = "Created by"
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabelControl8.Appearance.Options.UseFont = True
        Me.LabelControl8.Location = New System.Drawing.Point(13, 116)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl8.TabIndex = 147
        Me.LabelControl8.Text = "Submit to"
        '
        'txt_notes
        '
        Me.txt_notes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_notes.Location = New System.Drawing.Point(313, 48)
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Properties.ReadOnly = True
        Me.txt_notes.Properties.UseReadOnlyAppearance = False
        Me.txt_notes.Size = New System.Drawing.Size(619, 84)
        Me.txt_notes.TabIndex = 148
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(313, 26)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(37, 16)
        Me.LabelControl1.TabIndex = 149
        Me.LabelControl1.Text = "Notes:"
        '
        'frm_warehouse_returns_receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 606)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.LabelControl7)
        Me.Controls.Add(Me.LabelControl6)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.txt_warehouse)
        Me.Controls.Add(Me.txt_created_by)
        Me.Controls.Add(Me.txt_customer)
        Me.Controls.Add(Me.txt_srid)
        Me.Controls.Add(Me.btn_received)
        Me.Controls.Add(Me.grid_returns)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "frm_warehouse_returns_receive"
        Me.Text = "frm_warehouse_returns"
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_srid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_customer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_created_by.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_warehouse.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_notes.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_update As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_received As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_srid As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_customer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_created_by As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txt_warehouse As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_notes As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
