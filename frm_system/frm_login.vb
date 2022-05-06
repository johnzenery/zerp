Imports DevExpress.XtraSplashScreen
Imports MySqlConnector

Public Class frm_login

    '--- Declaration ---
    Public Property global_user_id As Integer

    '--- ONLOAD ---
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Testing Server Connection
        If TestConnection() = False Then
            btn_login.Enabled = False
            btn_login.ForeColor = Color.Silver
            err_lbl.Text = "Couldn't connect to server." & vbNewLine & "Contact your adminstrator."
            err_lbl.Visible = True
            Exit Sub
        End If

        txt_username.Select()
    End Sub



    '--- FUNCTIONS ---

    Private Sub LogIn()

        'Validation
        Err.Clear()
        err_lbl.Visible = False

        If String.IsNullOrWhiteSpace(txt_username.Text) Then
            Err.SetError(lbl_username, "Input the provided username.")
            Exit Sub
        End If

        If String.IsNullOrWhiteSpace(txt_password.Text) Then
            Err.SetError(lbl_pass, "Input your password.")
            Exit Sub
        End If

        'Initialization
        Dim username = txt_username.Text.Trim
        Dim pass = txt_password.Text.Trim
        Dim ok_username = False
        Dim ok_pass = False
        Dim user_id = 0

        Try
            'Getting Username and Password
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_users WHERE deleted=0", connection)

                    Using rdr As MySqlDataReader = cmd.ExecuteReader
                        While rdr.Read

                            If Equals(rdr("username"), username) Then
                                ok_username = True

                                If Equals(Decrypt(rdr("pass")), pass) Then
                                    ok_pass = True
                                    user_id = rdr("usr_id")
                                End If

                            End If

                        End While
                    End Using

                End Using
            End Using

            'Checking Username and Password
            If ok_username Then
                If ok_pass Then

                    'WHEN IT PASS THE VERIFICATION

                    global_user_id = user_id

                    frm_main.Show()
                    Me.Hide()

                    txt_username.Text = String.Empty
                    txt_password.Text = String.Empty

                Else
                    err_lbl.Text = "Incorrect credentials."
                    err_lbl.Visible = True
                End If
            Else
                err_lbl.Text = "Incorrect credentials."
                err_lbl.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub



    '--- CONTROLS ---

    'Login Button
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        LogIn()
    End Sub

    'keypress on Enter
    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If
    End Sub

    'Press CTRL + F1 to show Connection Settings
    Private Sub frm_login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'SHOW DEVELOPER
        If e.Modifiers = Keys.Shift And e.KeyCode = Keys.Z Then
            MsgBox("Developed by John Zenery", vbInformation, "Who is my Creator")
        End If

        'BYPASS LOGIN FOR SUPERADMIN
        If e.Shift And e.Control And e.KeyCode = Keys.Enter Then
            txt_username.Text = "zen"
            txt_password.Text = "@asd"
            btn_login.PerformClick()
        End If

        'Show Password dialog and ZERP Connection Panel
        If e.KeyCode = Keys.F1 And e.Modifiers = Keys.Control Then


            Dim pass As String = ""
            Dim frm_pass = New frm_sales_password_required
            frm_pass.Label1.Text = "Enter Admin Password to continue:"
            Dim result = frm_pass.ShowDialog()

            If Not String.IsNullOrEmpty(frm_pass.Password) Then
                pass = frm_pass.Password
                frm_pass.Dispose()
            End If


            If result = DialogResult.OK Then
                If Not pass.Equals(connection_panel_password) Or String.IsNullOrWhiteSpace(pass) Then
                    MsgBox("Password is Incorrect!", vbCritical, "Incorrect Password")
                    Exit Sub
                End If

                frm_connection_panel.ShowDialog()

            End If

        End If
    End Sub

    'Upon Close
    Private Sub frm_login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Application.Exit()
    End Sub
End Class
