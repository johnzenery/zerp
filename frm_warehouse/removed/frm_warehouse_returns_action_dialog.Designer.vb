
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_warehouse_returns_action_dialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_warehouse_returns_action_dialog))
        Me.btn_return = New DevExpress.XtraEditors.SimpleButton()
        Me.btn_ok = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.hidden_id = New DevExpress.XtraEditors.LabelControl()
        Me.hidden_store = New DevExpress.XtraEditors.LabelControl()
        Me.hidden_pid = New DevExpress.XtraEditors.LabelControl()
        Me.lbl_srid = New DevExpress.XtraEditors.LabelControl()
        Me.txt_winmodel = New System.Windows.Forms.TextBox()
        Me.txt_qty = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btn_return
        '
        Me.btn_return.Location = New System.Drawing.Point(26, 180)
        Me.btn_return.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_return.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(212, 42)
        Me.btn_return.TabIndex = 1
        Me.btn_return.Text = "Defective"
        '
        'btn_ok
        '
        Me.btn_ok.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btn_ok.Appearance.Options.UseBackColor = True
        Me.btn_ok.Location = New System.Drawing.Point(26, 132)
        Me.btn_ok.LookAndFeel.SkinName = "Office 2010 Blue"
        Me.btn_ok.LookAndFeel.UseDefaultLookAndFeel = False
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(212, 42)
        Me.btn_ok.TabIndex = 2
        Me.btn_ok.Text = "In Good Condition"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 112)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Choose Action:"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Appearance.Options.UseFont = True
        Me.LabelControl2.Location = New System.Drawing.Point(26, 51)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(34, 16)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Model"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Appearance.Options.UseFont = True
        Me.LabelControl3.Location = New System.Drawing.Point(26, 77)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(47, 16)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Quantity"
        '
        'hidden_id
        '
        Me.hidden_id.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hidden_id.Appearance.Options.UseFont = True
        Me.hidden_id.Location = New System.Drawing.Point(244, 70)
        Me.hidden_id.Name = "hidden_id"
        Me.hidden_id.Size = New System.Drawing.Size(55, 16)
        Me.hidden_id.TabIndex = 9
        Me.hidden_id.Text = "hidden_id"
        Me.hidden_id.Visible = False
        '
        'hidden_store
        '
        Me.hidden_store.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hidden_store.Appearance.Options.UseFont = True
        Me.hidden_store.Location = New System.Drawing.Point(244, 92)
        Me.hidden_store.Name = "hidden_store"
        Me.hidden_store.Size = New System.Drawing.Size(74, 16)
        Me.hidden_store.TabIndex = 10
        Me.hidden_store.Text = "hidden_store"
        Me.hidden_store.Visible = False
        '
        'hidden_pid
        '
        Me.hidden_pid.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hidden_pid.Appearance.Options.UseFont = True
        Me.hidden_pid.Location = New System.Drawing.Point(244, 109)
        Me.hidden_pid.Name = "hidden_pid"
        Me.hidden_pid.Size = New System.Drawing.Size(62, 16)
        Me.hidden_pid.TabIndex = 11
        Me.hidden_pid.Text = "hidden_pid"
        Me.hidden_pid.Visible = False
        '
        'lbl_srid
        '
        Me.lbl_srid.Appearance.BackColor = System.Drawing.Color.GhostWhite
        Me.lbl_srid.Appearance.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_srid.Appearance.Options.UseBackColor = True
        Me.lbl_srid.Appearance.Options.UseFont = True
        Me.lbl_srid.Appearance.Options.UseTextOptions = True
        Me.lbl_srid.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.lbl_srid.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
        Me.lbl_srid.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.lbl_srid.Location = New System.Drawing.Point(26, 8)
        Me.lbl_srid.Name = "lbl_srid"
        Me.lbl_srid.Size = New System.Drawing.Size(212, 38)
        Me.lbl_srid.TabIndex = 5
        Me.lbl_srid.Text = "SRID"
        '
        'txt_winmodel
        '
        Me.txt_winmodel.Enabled = False
        Me.txt_winmodel.Location = New System.Drawing.Point(85, 50)
        Me.txt_winmodel.Name = "txt_winmodel"
        Me.txt_winmodel.Size = New System.Drawing.Size(153, 20)
        Me.txt_winmodel.TabIndex = 12
        '
        'txt_qty
        '
        Me.txt_qty.Enabled = False
        Me.txt_qty.Location = New System.Drawing.Point(85, 76)
        Me.txt_qty.Name = "txt_qty"
        Me.txt_qty.Size = New System.Drawing.Size(86, 20)
        Me.txt_qty.TabIndex = 13
        '
        'frm_warehouse_returns_action_dialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(277, 235)
        Me.Controls.Add(Me.txt_qty)
        Me.Controls.Add(Me.txt_winmodel)
        Me.Controls.Add(Me.hidden_pid)
        Me.Controls.Add(Me.hidden_store)
        Me.Controls.Add(Me.hidden_id)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.lbl_srid)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.btn_return)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_warehouse_returns_action_dialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Action"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_return As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btn_ok As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents hidden_id As DevExpress.XtraEditors.LabelControl
    Friend WithEvents hidden_store As DevExpress.XtraEditors.LabelControl
    Friend WithEvents hidden_pid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lbl_srid As DevExpress.XtraEditors.LabelControl
    Friend WithEvents txt_winmodel As TextBox
    Friend WithEvents txt_qty As TextBox
End Class
