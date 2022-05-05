<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_warehouse_returns_receive
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
        Dim EditorButtonImageOptions1 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject2 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject3 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject4 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.btn_update = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.grid_returns = New DevExpress.XtraGrid.GridControl()
        Me.grid_returns_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_winmodel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_pid = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_description = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt_warehouse = New System.Windows.Forms.TextBox()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.btn_received = New DevExpress.XtraEditors.SimpleButton()
        Me.txt_created_by = New System.Windows.Forms.TextBox()
        Me.txt_customer = New System.Windows.Forms.TextBox()
        Me.txt_srid = New System.Windows.Forms.TextBox()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_head = New System.Windows.Forms.Label()
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_update
        '
        Me.btn_update.AutoHeight = False
        EditorButtonImageOptions1.Image = Global.Inventory_Management.My.Resources.Resources.pencolor_16x16
        Me.btn_update.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, SerializableAppearanceObject2, SerializableAppearanceObject3, SerializableAppearanceObject4, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_update.Name = "btn_update"
        Me.btn_update.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'grid_returns
        '
        Me.grid_returns.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_returns.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.grid_returns.Location = New System.Drawing.Point(12, 126)
        Me.grid_returns.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_returns.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_returns.MainView = Me.grid_returns_view
        Me.grid_returns.Name = "grid_returns"
        Me.grid_returns.Size = New System.Drawing.Size(510, 350)
        Me.grid_returns.TabIndex = 12
        Me.grid_returns.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_returns_view})
        '
        'grid_returns_view
        '
        Me.grid_returns_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
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
        '
        'col_winmodel
        '
        Me.col_winmodel.Caption = "Model"
        Me.col_winmodel.FieldName = "winmodel"
        Me.col_winmodel.Name = "col_winmodel"
        Me.col_winmodel.Visible = True
        Me.col_winmodel.VisibleIndex = 1
        Me.col_winmodel.Width = 120
        '
        'col_qty
        '
        Me.col_qty.AppearanceCell.Options.UseTextOptions = True
        Me.col_qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_qty.Caption = "Qty"
        Me.col_qty.FieldName = "qty"
        Me.col_qty.MaxWidth = 100
        Me.col_qty.Name = "col_qty"
        Me.col_qty.Visible = True
        Me.col_qty.VisibleIndex = 0
        Me.col_qty.Width = 86
        '
        'col_pid
        '
        Me.col_pid.AppearanceCell.Options.UseTextOptions = True
        Me.col_pid.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_pid.Caption = "PID"
        Me.col_pid.FieldName = "pid"
        Me.col_pid.MinWidth = 80
        Me.col_pid.Name = "col_pid"
        Me.col_pid.Width = 95
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
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl4.Appearance.Options.UseFont = True
        Me.LabelControl4.Appearance.Options.UseForeColor = True
        Me.LabelControl4.Location = New System.Drawing.Point(12, 15)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(32, 16)
        Me.LabelControl4.TabIndex = 131
        Me.LabelControl4.Text = "SRID"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Appearance.Options.UseForeColor = True
        Me.LabelControl1.Location = New System.Drawing.Point(12, 41)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(57, 16)
        Me.LabelControl1.TabIndex = 132
        Me.LabelControl1.Text = "Customer"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(221, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txt_warehouse)
        Me.Panel1.Controls.Add(Me.LabelControl3)
        Me.Panel1.Controls.Add(Me.btn_received)
        Me.Panel1.Controls.Add(Me.txt_created_by)
        Me.Panel1.Controls.Add(Me.txt_customer)
        Me.Panel1.Controls.Add(Me.txt_srid)
        Me.Panel1.Controls.Add(Me.LabelControl2)
        Me.Panel1.Controls.Add(Me.grid_returns)
        Me.Panel1.Controls.Add(Me.LabelControl4)
        Me.Panel1.Controls.Add(Me.LabelControl1)
        Me.Panel1.Location = New System.Drawing.Point(12, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(534, 523)
        Me.Panel1.TabIndex = 133
        '
        'txt_warehouse
        '
        Me.txt_warehouse.Location = New System.Drawing.Point(103, 92)
        Me.txt_warehouse.Name = "txt_warehouse"
        Me.txt_warehouse.ReadOnly = True
        Me.txt_warehouse.Size = New System.Drawing.Size(224, 20)
        Me.txt_warehouse.TabIndex = 139
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Appearance.Options.UseForeColor = True
        Me.LabelControl3.Location = New System.Drawing.Point(12, 93)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(55, 16)
        Me.LabelControl3.TabIndex = 138
        Me.LabelControl3.Text = "Submit to"
        '
        'btn_received
        '
        Me.btn_received.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_received.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_received.Appearance.Options.UseBackColor = True
        Me.btn_received.Location = New System.Drawing.Point(429, 483)
        Me.btn_received.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_received.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_received.Name = "btn_received"
        Me.btn_received.Size = New System.Drawing.Size(93, 31)
        Me.btn_received.TabIndex = 137
        Me.btn_received.Text = "Receive"
        '
        'txt_created_by
        '
        Me.txt_created_by.Location = New System.Drawing.Point(103, 66)
        Me.txt_created_by.Name = "txt_created_by"
        Me.txt_created_by.ReadOnly = True
        Me.txt_created_by.Size = New System.Drawing.Size(184, 20)
        Me.txt_created_by.TabIndex = 136
        '
        'txt_customer
        '
        Me.txt_customer.Location = New System.Drawing.Point(103, 40)
        Me.txt_customer.Name = "txt_customer"
        Me.txt_customer.ReadOnly = True
        Me.txt_customer.Size = New System.Drawing.Size(184, 20)
        Me.txt_customer.TabIndex = 135
        '
        'txt_srid
        '
        Me.txt_srid.Location = New System.Drawing.Point(103, 14)
        Me.txt_srid.Name = "txt_srid"
        Me.txt_srid.ReadOnly = True
        Me.txt_srid.Size = New System.Drawing.Size(100, 20)
        Me.txt_srid.TabIndex = 134
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ControlText
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Appearance.Options.UseForeColor = True
        Me.LabelControl2.Location = New System.Drawing.Point(12, 67)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(66, 16)
        Me.LabelControl2.TabIndex = 133
        Me.LabelControl2.Text = "Created by"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Lavender
        Me.Panel5.Controls.Add(Me.lbl_head)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(558, 42)
        Me.Panel5.TabIndex = 134
        '
        'lbl_head
        '
        Me.lbl_head.AutoSize = True
        Me.lbl_head.Font = New System.Drawing.Font("Tahoma", 16.0!)
        Me.lbl_head.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbl_head.Location = New System.Drawing.Point(12, 9)
        Me.lbl_head.Name = "lbl_head"
        Me.lbl_head.Size = New System.Drawing.Size(218, 27)
        Me.lbl_head.TabIndex = 0
        Me.lbl_head.Text = "Receive Sales Return"
        '
        'frm_warehouse_returns_receive
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(558, 606)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frm_warehouse_returns_receive"
        Me.Text = "frm_warehouse_returns"
        CType(Me.btn_update, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_returns_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_returns As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_returns_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_winmodel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_pid As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_description As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_head As Label
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_created_by As TextBox
    Friend WithEvents txt_customer As TextBox
    Friend WithEvents txt_srid As TextBox
    Friend WithEvents btn_update As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_received As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txt_warehouse As TextBox
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
