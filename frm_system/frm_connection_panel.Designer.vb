Imports DevExpress.XtraEditors

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_connection_panel
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
        Me.btn_save = New System.Windows.Forms.Button()
        Me.rb_wan = New System.Windows.Forms.RadioButton()
        Me.rb_lan = New System.Windows.Forms.RadioButton()
        Me.rb_development_db = New System.Windows.Forms.RadioButton()
        Me.rb_production_db = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(12, 133)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(205, 33)
        Me.btn_save.TabIndex = 19
        Me.btn_save.Text = "Save and Restart"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'rb_wan
        '
        Me.rb_wan.AutoSize = True
        Me.rb_wan.Location = New System.Drawing.Point(21, 19)
        Me.rb_wan.Name = "rb_wan"
        Me.rb_wan.Size = New System.Drawing.Size(51, 17)
        Me.rb_wan.TabIndex = 27
        Me.rb_wan.TabStop = True
        Me.rb_wan.Text = "WAN"
        Me.rb_wan.UseVisualStyleBackColor = True
        '
        'rb_lan
        '
        Me.rb_lan.AutoSize = True
        Me.rb_lan.Location = New System.Drawing.Point(103, 19)
        Me.rb_lan.Name = "rb_lan"
        Me.rb_lan.Size = New System.Drawing.Size(46, 17)
        Me.rb_lan.TabIndex = 28
        Me.rb_lan.TabStop = True
        Me.rb_lan.Text = "LAN"
        Me.rb_lan.UseVisualStyleBackColor = True
        '
        'rb_development_db
        '
        Me.rb_development_db.AutoSize = True
        Me.rb_development_db.Location = New System.Drawing.Point(105, 20)
        Me.rb_development_db.Name = "rb_development_db"
        Me.rb_development_db.Size = New System.Drawing.Size(88, 17)
        Me.rb_development_db.TabIndex = 30
        Me.rb_development_db.TabStop = True
        Me.rb_development_db.Text = "Development"
        Me.rb_development_db.UseVisualStyleBackColor = True
        '
        'rb_production_db
        '
        Me.rb_production_db.AutoSize = True
        Me.rb_production_db.Location = New System.Drawing.Point(23, 20)
        Me.rb_production_db.Name = "rb_production_db"
        Me.rb_production_db.Size = New System.Drawing.Size(76, 17)
        Me.rb_production_db.TabIndex = 29
        Me.rb_production_db.TabStop = True
        Me.rb_production_db.Text = "Production"
        Me.rb_production_db.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_production_db)
        Me.GroupBox1.Controls.Add(Me.rb_development_db)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_wan)
        Me.GroupBox2.Controls.Add(Me.rb_lan)
        Me.GroupBox2.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 48)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Connection Type"
        '
        'frm_connection_panel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 178)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_save)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_connection_panel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connection Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_save As Button
    Friend WithEvents rb_wan As RadioButton
    Friend WithEvents rb_lan As RadioButton
    Friend WithEvents rb_development_db As RadioButton
    Friend WithEvents rb_production_db As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
