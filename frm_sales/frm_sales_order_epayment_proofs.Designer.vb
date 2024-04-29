<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_sales_order_epayment_proofs
    Inherits DevExpress.XtraEditors.XtraForm

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_sales_order_epayment_proofs))
        Me.ImageCollection = New DevExpress.Utils.ImageCollection(Me.components)
        Me.btn_add = New DevExpress.XtraEditors.SimpleButton()
        Me.layout_image = New System.Windows.Forms.FlowLayoutPanel()
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewImageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_order_id = New System.Windows.Forms.Label()
        Me.btn_save = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cms.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageCollection
        '
        Me.ImageCollection.ImageSize = New System.Drawing.Size(600, 600)
        Me.ImageCollection.ImageStream = CType(resources.GetObject("ImageCollection.ImageStream"), DevExpress.Utils.ImageCollectionStreamer)
        Me.ImageCollection.Images.SetKeyName(0, "photo-1572996398321-5c4b5e687548.jpg")
        Me.ImageCollection.Images.SetKeyName(1, "planet-1702788_1920.jpg")
        Me.ImageCollection.Images.SetKeyName(2, "rizki-dwi-yd1wWWilf4o-unsplash.jpg")
        Me.ImageCollection.Images.SetKeyName(3, "sunset-1373171_1920.jpg")
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter
        Me.btn_add.ImageOptions.SvgImage = Global.Inventory_Management.My.Resources.Resources.actions_addcircled
        Me.btn_add.Location = New System.Drawing.Point(15, 288)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(119, 37)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "Add Image"
        '
        'layout_image
        '
        Me.layout_image.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.layout_image.AutoScroll = True
        Me.layout_image.BackColor = System.Drawing.SystemColors.Control
        Me.layout_image.Location = New System.Drawing.Point(15, 43)
        Me.layout_image.Name = "layout_image"
        Me.layout_image.Size = New System.Drawing.Size(469, 235)
        Me.layout_image.TabIndex = 4
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewImageToolStripMenuItem, Me.DeleteToolStripMenuItem})
        Me.cms.Name = "ContextMenuStrip"
        Me.cms.Size = New System.Drawing.Size(150, 52)
        '
        'ViewImageToolStripMenuItem
        '
        Me.ViewImageToolStripMenuItem.Name = "ViewImageToolStripMenuItem"
        Me.ViewImageToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.ViewImageToolStripMenuItem.Text = "View Image"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(149, 24)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Attached Photos:"
        '
        'lbl_order_id
        '
        Me.lbl_order_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_order_id.AutoSize = True
        Me.lbl_order_id.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_order_id.Location = New System.Drawing.Point(432, 22)
        Me.lbl_order_id.Name = "lbl_order_id"
        Me.lbl_order_id.Size = New System.Drawing.Size(52, 15)
        Me.lbl_order_id.TabIndex = 7
        Me.lbl_order_id.Text = "SO00000"
        Me.lbl_order_id.Visible = False
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btn_save.Appearance.Options.UseBackColor = True
        Me.btn_save.Location = New System.Drawing.Point(366, 288)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(119, 37)
        Me.btn_save.TabIndex = 8
        Me.btn_save.Text = "Save"
        '
        'frm_sales_order_epayment_proofs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 337)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.lbl_order_id)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.layout_image)
        Me.Controls.Add(Me.btn_add)
        Me.IconOptions.Icon = CType(resources.GetObject("frm_sales_order_epayment_proofs.IconOptions.Icon"), System.Drawing.Icon)
        Me.Name = "frm_sales_order_epayment_proofs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sales Proofs"
        CType(Me.ImageCollection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cms.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ImageCollection As DevExpress.Utils.ImageCollection
    Friend WithEvents btn_add As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents layout_image As FlowLayoutPanel
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_order_id As Label
    Friend WithEvents btn_save As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents ViewImageToolStripMenuItem As ToolStripMenuItem
End Class
