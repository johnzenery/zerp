Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Guna.UI.WinForms
Imports Guna.UI2.WinForms
Imports Inventory_Management.My
Imports Inventory_Management.My.Resources
Imports System.ComponentModel
Imports System.Drawing.Drawing2D

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_stock_transfer
    Inherits System.Windows.Forms.Form

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
        Dim EditorButtonImageOptions3 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject9 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject10 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject11 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject12 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim EditorButtonImageOptions4 As DevExpress.XtraEditors.Controls.EditorButtonImageOptions = New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
        Dim SerializableAppearanceObject13 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject14 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject15 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Dim SerializableAppearanceObject16 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.panel_top = New Guna.UI.WinForms.GunaLinePanel()
        Me.btn_stock_transfer = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_reconcile = New DevExpress.XtraEditors.SimpleButton()
        Me.GunaPanel2 = New Guna.UI.WinForms.GunaPanel()
        Me.GunaPanel3 = New Guna.UI.WinForms.GunaPanel()
        Me.HyperlinkLabelControl1 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.HyperlinkLabelControl2 = New DevExpress.XtraEditors.HyperlinkLabelControl()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.grid_stock_transferred = New DevExpress.XtraGrid.GridControl()
        Me.grid_stock_transferred_view = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col_id = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_status = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_from = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col_edit = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_edit = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.col_delete = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btn_delete = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
        Me.btn_request_transfer = New DevExpress.XtraEditors.SimpleButton()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.lbl_inprogress = New System.Windows.Forms.LinkLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_resolved = New System.Windows.Forms.LinkLabel()
        Me.lbl_completed = New System.Windows.Forms.LinkLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.btn_dispatch = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_refresh = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_print = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_receive = New DevExpress.XtraEditors.SimpleButton()
        Me.lbl_cancelled = New System.Windows.Forms.LinkLabel()
        Me.panel_top.SuspendLayout()
        Me.GunaPanel2.SuspendLayout()
        Me.GunaPanel3.SuspendLayout()
        CType(Me.grid_stock_transferred, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grid_stock_transferred_view, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'panel_top
        '
        Me.panel_top.BackColor = System.Drawing.Color.GhostWhite
        Me.panel_top.Controls.Add(Me.btn_stock_transfer)
        Me.panel_top.Controls.Add(Me.btn_reconcile)
        Me.panel_top.Controls.Add(Me.GunaPanel2)
        Me.panel_top.Controls.Add(Me.GunaLabel11)
        Me.panel_top.Dock = System.Windows.Forms.DockStyle.Top
        Me.panel_top.LineColor = System.Drawing.SystemColors.ControlLight
        Me.panel_top.LineStyle = System.Windows.Forms.BorderStyle.None
        Me.panel_top.Location = New System.Drawing.Point(0, 0)
        Me.panel_top.Name = "panel_top"
        Me.panel_top.Size = New System.Drawing.Size(1120, 78)
        Me.panel_top.TabIndex = 8
        '
        'btn_stock_transfer
        '
        Me.btn_stock_transfer.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_stock_transfer.Appearance.BackColor = System.Drawing.Color.White
        Me.btn_stock_transfer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_stock_transfer.Appearance.Options.UseBackColor = True
        Me.btn_stock_transfer.Appearance.Options.UseFont = True
        Me.btn_stock_transfer.Enabled = False
        Me.btn_stock_transfer.Location = New System.Drawing.Point(848, 37)
        Me.btn_stock_transfer.Name = "btn_stock_transfer"
        Me.btn_stock_transfer.Size = New System.Drawing.Size(130, 44)
        Me.btn_stock_transfer.TabIndex = 8
        Me.btn_stock_transfer.Text = "Stock Transfer"
        '
        'btn_reconcile
        '
        Me.btn_reconcile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_reconcile.Appearance.BackColor = System.Drawing.SystemColors.Control
        Me.btn_reconcile.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_reconcile.Appearance.Options.UseBackColor = True
        Me.btn_reconcile.Appearance.Options.UseFont = True
        Me.btn_reconcile.Location = New System.Drawing.Point(972, 40)
        Me.btn_reconcile.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_reconcile.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_reconcile.Name = "btn_reconcile"
        Me.btn_reconcile.Size = New System.Drawing.Size(130, 41)
        Me.btn_reconcile.TabIndex = 9
        Me.btn_reconcile.Text = "Reconcile"
        '
        'GunaPanel2
        '
        Me.GunaPanel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaPanel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPanel2.Controls.Add(Me.GunaPanel3)
        Me.GunaPanel2.Location = New System.Drawing.Point(19, 44)
        Me.GunaPanel2.Name = "GunaPanel2"
        Me.GunaPanel2.Size = New System.Drawing.Size(813, 27)
        Me.GunaPanel2.TabIndex = 6
        '
        'GunaPanel3
        '
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl1)
        Me.GunaPanel3.Controls.Add(Me.LabelControl1)
        Me.GunaPanel3.Controls.Add(Me.HyperlinkLabelControl2)
        Me.GunaPanel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GunaPanel3.Location = New System.Drawing.Point(0, 0)
        Me.GunaPanel3.Name = "GunaPanel3"
        Me.GunaPanel3.Size = New System.Drawing.Size(183, 27)
        Me.GunaPanel3.TabIndex = 1
        '
        'HyperlinkLabelControl1
        '
        Me.HyperlinkLabelControl1.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl1.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl1.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl1.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl1.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl1.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl1.Enabled = False
        Me.HyperlinkLabelControl1.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl1.Location = New System.Drawing.Point(70, 5)
        Me.HyperlinkLabelControl1.Name = "HyperlinkLabelControl1"
        Me.HyperlinkLabelControl1.ShowLineShadow = False
        Me.HyperlinkLabelControl1.Size = New System.Drawing.Size(87, 18)
        Me.HyperlinkLabelControl1.TabIndex = 7
        Me.HyperlinkLabelControl1.Text = "Stock Transfer"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(55, 7)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(9, 14)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = ">"
        '
        'HyperlinkLabelControl2
        '
        Me.HyperlinkLabelControl2.Appearance.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HyperlinkLabelControl2.Appearance.LinkColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText
        Me.HyperlinkLabelControl2.Appearance.Options.UseFont = True
        Me.HyperlinkLabelControl2.Appearance.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceDisabled.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceDisabled.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseForeColor = True
        Me.HyperlinkLabelControl2.AppearanceHovered.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.AppearancePressed.LinkColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.HyperlinkLabelControl2.AppearancePressed.Options.UseLinkColor = True
        Me.HyperlinkLabelControl2.LineStyle = System.Drawing.Drawing2D.DashStyle.Custom
        Me.HyperlinkLabelControl2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.HyperlinkLabelControl2.Location = New System.Drawing.Point(13, 5)
        Me.HyperlinkLabelControl2.Name = "HyperlinkLabelControl2"
        Me.HyperlinkLabelControl2.ShowLineShadow = False
        Me.HyperlinkLabelControl2.Size = New System.Drawing.Size(37, 18)
        Me.HyperlinkLabelControl2.TabIndex = 5
        Me.HyperlinkLabelControl2.Text = "Home"
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!)
        Me.GunaLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(213, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(45, Byte), Integer))
        Me.GunaLabel11.Location = New System.Drawing.Point(14, 10)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(192, 31)
        Me.GunaLabel11.TabIndex = 1
        Me.GunaLabel11.Text = "Stock Transfer"
        '
        'grid_stock_transferred
        '
        Me.grid_stock_transferred.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_stock_transferred.Location = New System.Drawing.Point(20, 72)
        Me.grid_stock_transferred.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.grid_stock_transferred.LookAndFeel.UseDefaultLookAndFeel = False
        Me.grid_stock_transferred.MainView = Me.grid_stock_transferred_view
        Me.grid_stock_transferred.Name = "grid_stock_transferred"
        Me.grid_stock_transferred.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.btn_edit, Me.btn_delete})
        Me.grid_stock_transferred.Size = New System.Drawing.Size(1082, 479)
        Me.grid_stock_transferred.TabIndex = 13
        Me.grid_stock_transferred.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.grid_stock_transferred_view})
        '
        'grid_stock_transferred_view
        '
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!)
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Options.UseFont = True
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.grid_stock_transferred_view.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.grid_stock_transferred_view.Appearance.Row.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grid_stock_transferred_view.Appearance.Row.Options.UseFont = True
        Me.grid_stock_transferred_view.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col_id, Me.col_status, Me.col_from, Me.GridColumn3, Me.GridColumn6, Me.col_edit, Me.col_delete})
        Me.grid_stock_transferred_view.GridControl = Me.grid_stock_transferred
        Me.grid_stock_transferred_view.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always
        Me.grid_stock_transferred_view.Name = "grid_stock_transferred_view"
        Me.grid_stock_transferred_view.OptionsBehavior.ReadOnly = True
        Me.grid_stock_transferred_view.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.grid_stock_transferred_view.OptionsView.AutoCalcPreviewLineCount = True
        Me.grid_stock_transferred_view.OptionsView.ColumnAutoWidth = False
        Me.grid_stock_transferred_view.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.[False]
        '
        'col_id
        '
        Me.col_id.AppearanceCell.Options.UseTextOptions = True
        Me.col_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col_id.Caption = "ID"
        Me.col_id.FieldName = "id"
        Me.col_id.Name = "col_id"
        Me.col_id.Visible = True
        Me.col_id.VisibleIndex = 0
        Me.col_id.Width = 103
        '
        'col_status
        '
        Me.col_status.Caption = "Status"
        Me.col_status.FieldName = "status"
        Me.col_status.Name = "col_status"
        Me.col_status.Visible = True
        Me.col_status.VisibleIndex = 1
        Me.col_status.Width = 93
        '
        'col_from
        '
        Me.col_from.Caption = "From"
        Me.col_from.FieldName = "src_store"
        Me.col_from.Name = "col_from"
        Me.col_from.Visible = True
        Me.col_from.VisibleIndex = 2
        Me.col_from.Width = 207
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me.GridColumn3.Caption = "To"
        Me.GridColumn3.FieldName = "receiver_store"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 260
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn6.Caption = "Date"
        Me.GridColumn6.DisplayFormat.FormatString = "MM/dd/yyyy"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.GridColumn6.FieldName = "date"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 111
        '
        'col_edit
        '
        Me.col_edit.Caption = "Edit"
        Me.col_edit.ColumnEdit = Me.btn_edit
        Me.col_edit.Name = "col_edit"
        Me.col_edit.Visible = True
        Me.col_edit.VisibleIndex = 5
        '
        'btn_edit
        '
        Me.btn_edit.AutoHeight = False
        EditorButtonImageOptions3.Image = Global.Inventory_Management.My.Resources.Resources.pencolor_16x16
        Me.btn_edit.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject9, SerializableAppearanceObject10, SerializableAppearanceObject11, SerializableAppearanceObject12, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_edit.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'col_delete
        '
        Me.col_delete.Caption = "Delete"
        Me.col_delete.ColumnEdit = Me.btn_delete
        Me.col_delete.Name = "col_delete"
        Me.col_delete.Visible = True
        Me.col_delete.VisibleIndex = 6
        '
        'btn_delete
        '
        Me.btn_delete.AutoHeight = False
        EditorButtonImageOptions4.Image = Global.Inventory_Management.My.Resources.Resources.trash_16x16
        Me.btn_delete.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, True, True, False, EditorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject13, SerializableAppearanceObject14, SerializableAppearanceObject15, SerializableAppearanceObject16, "", Nothing, Nothing, DevExpress.Utils.ToolTipAnchor.[Default])})
        Me.btn_delete.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
        '
        'btn_request_transfer
        '
        Me.btn_request_transfer.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_request_transfer.Appearance.Options.UseFont = True
        Me.btn_request_transfer.Appearance.Options.UseTextOptions = True
        Me.btn_request_transfer.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_request_transfer.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_request_transfer.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.newtask_32x321
        Me.btn_request_transfer.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_request_transfer.ImageOptions.ImageToTextIndent = 5
        Me.btn_request_transfer.Location = New System.Drawing.Point(20, 15)
        Me.btn_request_transfer.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_request_transfer.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_request_transfer.Name = "btn_request_transfer"
        Me.btn_request_transfer.Size = New System.Drawing.Size(160, 46)
        Me.btn_request_transfer.TabIndex = 14
        Me.btn_request_transfer.Text = "New Transfer"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.lbl_cancelled)
        Me.Guna2Panel1.Controls.Add(Me.lbl_inprogress)
        Me.Guna2Panel1.Controls.Add(Me.Label1)
        Me.Guna2Panel1.Controls.Add(Me.lbl_resolved)
        Me.Guna2Panel1.Controls.Add(Me.lbl_completed)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.btn_dispatch)
        Me.Guna2Panel1.Controls.Add(Me.btn_refresh)
        Me.Guna2Panel1.Controls.Add(Me.btn_print)
        Me.Guna2Panel1.Controls.Add(Me.btn_receive)
        Me.Guna2Panel1.Controls.Add(Me.btn_request_transfer)
        Me.Guna2Panel1.Controls.Add(Me.grid_stock_transferred)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 78)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1120, 588)
        Me.Guna2Panel1.TabIndex = 15
        '
        'lbl_inprogress
        '
        Me.lbl_inprogress.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_inprogress.AutoSize = True
        Me.lbl_inprogress.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_inprogress.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_inprogress.Location = New System.Drawing.Point(60, 560)
        Me.lbl_inprogress.Name = "lbl_inprogress"
        Me.lbl_inprogress.Size = New System.Drawing.Size(72, 15)
        Me.lbl_inprogress.TabIndex = 24
        Me.lbl_inprogress.TabStop = True
        Me.lbl_inprogress.Text = "In-Progress"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label1.Location = New System.Drawing.Point(16, 560)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Load:"
        '
        'lbl_resolved
        '
        Me.lbl_resolved.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_resolved.AutoSize = True
        Me.lbl_resolved.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_resolved.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_resolved.Location = New System.Drawing.Point(208, 560)
        Me.lbl_resolved.Name = "lbl_resolved"
        Me.lbl_resolved.Size = New System.Drawing.Size(59, 15)
        Me.lbl_resolved.TabIndex = 22
        Me.lbl_resolved.TabStop = True
        Me.lbl_resolved.Text = "Resolved"
        '
        'lbl_completed
        '
        Me.lbl_completed.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_completed.AutoSize = True
        Me.lbl_completed.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_completed.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_completed.Location = New System.Drawing.Point(134, 560)
        Me.lbl_completed.Name = "lbl_completed"
        Me.lbl_completed.Size = New System.Drawing.Size(68, 15)
        Me.lbl_completed.TabIndex = 21
        Me.lbl_completed.TabStop = True
        Me.lbl_completed.Text = "Completed"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Silver
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(849, 10)
        Me.Guna2Panel2.TabIndex = 19
        '
        'btn_dispatch
        '
        Me.btn_dispatch.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dispatch.Appearance.Options.UseFont = True
        Me.btn_dispatch.Appearance.Options.UseTextOptions = True
        Me.btn_dispatch.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_dispatch.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_dispatch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_dispatch.ImageOptions.ImageToTextIndent = 5
        Me.btn_dispatch.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.shopping_delivery1
        Me.btn_dispatch.Location = New System.Drawing.Point(352, 15)
        Me.btn_dispatch.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_dispatch.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_dispatch.Name = "btn_dispatch"
        Me.btn_dispatch.Size = New System.Drawing.Size(160, 46)
        Me.btn_dispatch.TabIndex = 18
        Me.btn_dispatch.Text = "Dispatch"
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_refresh.Appearance.Options.UseFont = True
        Me.btn_refresh.Appearance.Options.UseTextOptions = True
        Me.btn_refresh.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_refresh.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_refresh.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.refresh_32x32
        Me.btn_refresh.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_refresh.ImageOptions.ImageToTextIndent = 5
        Me.btn_refresh.Location = New System.Drawing.Point(942, 15)
        Me.btn_refresh.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_refresh.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(160, 46)
        Me.btn_refresh.TabIndex = 17
        Me.btn_refresh.Text = "Refresh"
        '
        'btn_print
        '
        Me.btn_print.Appearance.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.btn_print.Appearance.Options.UseFont = True
        Me.btn_print.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_print.ImageOptions.ImageToTextIndent = 8
        Me.btn_print.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.printarea
        Me.btn_print.ImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.btn_print.Location = New System.Drawing.Point(186, 15)
        Me.btn_print.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_print.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(160, 46)
        Me.btn_print.TabIndex = 16
        Me.btn_print.Text = "Print"
        '
        'btn_receive
        '
        Me.btn_receive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_receive.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_receive.Appearance.Options.UseFont = True
        Me.btn_receive.Appearance.Options.UseTextOptions = True
        Me.btn_receive.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.btn_receive.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.btn_receive.ImageOptions.Image = Global.Inventory_Management.My.Resources.Resources.boproductgroup_32x32
        Me.btn_receive.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_receive.ImageOptions.ImageToTextIndent = 5
        Me.btn_receive.Location = New System.Drawing.Point(776, 15)
        Me.btn_receive.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_receive.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_receive.Name = "btn_receive"
        Me.btn_receive.Size = New System.Drawing.Size(160, 46)
        Me.btn_receive.TabIndex = 15
        Me.btn_receive.Text = "Receive Transfer"
        '
        'lbl_cancelled
        '
        Me.lbl_cancelled.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_cancelled.AutoSize = True
        Me.lbl_cancelled.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.lbl_cancelled.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.lbl_cancelled.Location = New System.Drawing.Point(273, 560)
        Me.lbl_cancelled.Name = "lbl_cancelled"
        Me.lbl_cancelled.Size = New System.Drawing.Size(63, 15)
        Me.lbl_cancelled.TabIndex = 25
        Me.lbl_cancelled.TabStop = True
        Me.lbl_cancelled.Text = "Cancelled"
        '
        'frm_warehouse_stock_transfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1120, 666)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.panel_top)
        Me.Name = "frm_warehouse_stock_transfer"
        Me.Text = "frm_warehouse_stock_transfer"
        Me.panel_top.ResumeLayout(False)
        Me.panel_top.PerformLayout()
        Me.GunaPanel2.ResumeLayout(False)
        Me.GunaPanel3.ResumeLayout(False)
        Me.GunaPanel3.PerformLayout()
        CType(Me.grid_stock_transferred, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grid_stock_transferred_view, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_edit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btn_delete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents panel_top As Guna.UI.WinForms.GunaLinePanel
    Friend WithEvents GunaPanel2 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents GunaPanel3 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents HyperlinkLabelControl1 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents HyperlinkLabelControl2 As DevExpress.XtraEditors.HyperlinkLabelControl
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents grid_stock_transferred As DevExpress.XtraGrid.GridControl
    Friend WithEvents grid_stock_transferred_view As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col_id As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_status As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col_from As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_request_transfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_receive As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_print As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_refresh As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_dispatch As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents col_edit As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_edit As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents col_delete As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btn_delete As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
    Friend WithEvents btn_stock_transfer As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_reconcile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_resolved As LinkLabel
    Friend WithEvents lbl_completed As LinkLabel
    Friend WithEvents lbl_inprogress As LinkLabel
    Friend WithEvents lbl_cancelled As LinkLabel
End Class
