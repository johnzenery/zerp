Public Class frm_connection_panel

    '--- ONLOAD ---
    Private Sub frm_connection_panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Select Case My.Settings.ConnectionType
            Case "WAN" : rb_wan.Checked = True
            Case "LAN" : rb_lan.Checked = True
        End Select

        Select Case My.Settings.DatabaseType
            Case "Production" : rb_production_db.Checked = True
            Case "Development" : rb_development_db.Checked = True
        End Select

    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If rb_wan.Checked Then My.Settings.ConnectionType = "WAN"
        If rb_lan.Checked Then My.Settings.ConnectionType = "LAN"

        If rb_production_db.Checked Then My.Settings.DatabaseType = "Production"
        If rb_development_db.Checked Then My.Settings.DatabaseType = "Development"

        My.Settings.Save()
        Application.Restart()
    End Sub

End Class