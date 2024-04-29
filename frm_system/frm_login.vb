Imports System.Reflection
Imports MySqlConnector

Public Class frm_login

    '--- Declaration ---
    Public Property global_user_id As Integer
    Public Property global_user_designation As String


    '--- ONLOAD ---
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Testing Server Connection
        If TestConnection() = False Then
            btn_validate.Enabled = False
            btn_validate.ForeColor = Color.Silver
            MsgBox("Couldn't connect to server." & vbNewLine & "Contact your adminstrator.", vbCritical, "Information")
            Exit Sub
        End If

        'CHECK VERSION
        Using conn = New MySqlConnection(str)
            conn.Open()
            Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='required_version'", conn)
                Using rdr = cmd.ExecuteReader
                    If rdr.HasRows Then
                        rdr.Read()

                        Dim required_version As Version = New Version(rdr("value"))
                        Dim app_version As Version = Assembly.GetExecutingAssembly().GetName().Version
                        Dim res = required_version.CompareTo(app_version)

                        If res >= 0 Then
                            MsgBox("Oops! Required application version is " & required_version.ToString & Environment.NewLine, vbCritical, "Information")
                            Application.Exit()
                        End If

                    Else
                        MsgBox("No required version found!" & Environment.NewLine & "Application will now exit.", vbCritical, "Information")
                        Application.Exit()
                    End If
                End Using
            End Using
        End Using

        txt_username.Select()

    End Sub


    '--- FUNCTIONS ---


    Private Sub LogIn()
        'Validation
        Err.Clear()
        'err_lbl.Visible = False

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
        Dim designations() As String = {}
        'MsgBox(Decrypt("xKFIYS2hIJvO+5NykGalSQ=="))
        Try
            'Getting Username and Password
            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET USER DETAILS
                Using cmd = New MySqlCommand("SELECT * FROM ims_users WHERE is_enabled=1", connection)
                    Using rdr As MySqlDataReader = cmd.ExecuteReader
                        While rdr.Read

                            If Equals(rdr("username"), username) Then
                                ok_username = True

                                If Equals(Decrypt(rdr("pass")), pass) Then
                                    ok_pass = True
                                    user_id = rdr("usr_id")
                                    designations = rdr("designations").ToString.Split(";")
                                End If
                            End If

                        End While
                    End Using
                End Using

                'GET STORE NAME THROUGH STORE ID
                Using cmd_get = New MySqlCommand("SELECT store_name FROM ims_stores WHERE store_id=@store_id", connection)
                    cmd_get.Parameters.AddWithValue("@store_id", 0)
                    cmd_get.Prepare()

                    cbb_warehouse.Properties.Items.Clear()

                    For j = 0 To designations.Length - 1
                        cmd_get.Parameters(0).Value = designations(j)
                        Using rdr = cmd_get.ExecuteReader
                            While rdr.Read
                                cbb_warehouse.Properties.Items.Add(rdr("store_name"))
                            End While
                        End Using
                    Next
                    cbb_warehouse.SelectedIndex = 0
                End Using

            End Using '

            'Checking Username and Password
            If ok_username Then
                If ok_pass Then

                    'WHEN IT PASS THE VERIFICATION

                    global_user_id = user_id
                    Me.Size = New Size(388, 360)

                Else
                    MsgBox("Incorrect password/username!", vbCritical, "Information")
                    Me.Size = New Size(388, 278)
                End If
            Else
                MsgBox("Incorrect password/username!", vbCritical, "Information")
                Me.Size = New Size(388, 278)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub



    '--- CONTROLS ---

    'Login Button
    Private Sub btn_validate_Click(sender As Object, e As EventArgs) Handles btn_validate.Click
        LogIn()
    End Sub

    'BUTTON : ENTER
    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        global_user_designation = cbb_warehouse.Text
        frm_main.Show()
        Me.Hide()

        txt_username.Text = String.Empty
        txt_password.Text = String.Empty
        cbb_warehouse.Properties.Items.Clear()
        Me.Size = New Size(333, 226)

    End Sub

    'keypress on Enter
    Private Sub txt_password_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_password.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_validate.PerformClick()
        End If
    End Sub

    'Press CTRL + F1 to show Connection Settings
    Private Sub frm_login_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        'SHOW DEVELOPER
        If e.Modifiers = Keys.Shift And e.KeyCode = Keys.Z Then
            MsgBox("Developed by John Zenery :)", vbInformation, "Who is my Creator")
            txt_username.Text = String.Empty
            txt_password.Text = String.Empty
        End If

        'BYPASS LOGIN FOR SUPERADMIN
        If e.Shift And e.Control And e.KeyCode = Keys.F12 Then
            txt_username.Text = "zen"
            txt_password.Text = "@asd"
            btn_validate.PerformClick()
            btn_login.PerformClick()
        End If

        'PRESS LOGIN
        If e.Control And e.KeyCode = Keys.Enter Then
            btn_login.PerformClick()
        End If

        'Show Password dialog and ZERP Connection Panel
        If e.KeyCode = Keys.F1 And e.Modifiers = Keys.Control Then


            Dim pass As String = String.Empty
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
