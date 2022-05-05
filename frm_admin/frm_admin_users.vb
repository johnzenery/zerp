Imports System.Globalization
Imports System.IO
Imports MySql.Data.MySqlClient
Imports Renci.SshNet
Imports Renci.SshNet.Sftp

Public Class frm_admin_users

    ReadOnly conn As New MySqlConnection(str)


    '--- ON LOAD ---
    Private Sub frm_users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStores()
        get_roles()
        load_roles()
        LoadUsers(grid_users)
    End Sub





    '--- FUNCTIONS ---

    'Get Roles from database
    Private Sub get_roles()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM ims_user_acc_types", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            cbb_role.BeginUpdate()

            While rdr.Read
                cbb_role.Items.Add(rdr("role"))
                cbb_view_role.Properties.Items.Add(rdr("role"))
            End While

            cbb_role.EndUpdate()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Load Stores to cbb_stores
    Private Sub LoadStores()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT store_name FROM ims_stores", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            cbb_store.BeginUpdate()
            While rdr.Read
                cbb_store.Items.Add(rdr("store_name").ToString.Replace("Winland ", ""))
                cbb_view_store.Properties.Items.Add(rdr("store_name").ToString.Replace("Winland ", ""))
            End While
            cbb_store.EndUpdate()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'Load Grids
    Private Sub LoadUsers(grid As DataGridView)
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT LPAD(usr_id, 8, 0) as usr_id, first_name, username, ims_user_acc_types.role, ims_stores.store_name, IF(ims_users.deleted = 0, 'Active', 'Disabled') as status FROM ims_users
                            INNER JOIN ims_user_acc_types ON ims_users.role_id=ims_user_acc_types.role_id
                            INNER JOIN ims_stores ON ims_stores.store_id=ims_users.assigned_loc", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_users.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try
    End Sub

    'Load Roles
    Private Sub load_roles()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM ims_user_acc_types", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_roles.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Upload Photo to Server
    Private Function UploadUserPhoto(username As String, picture_box As DevExpress.XtraEditors.PictureEdit)

        Using client As New SftpClient(server, ftp_username, ftp_password)
            client.Connect()

            'Get directoory list
            Dim files = client.ListDirectory("./")

            'Check IF FOLDER EXIST
            Dim is_exist = False
            For Each file As SftpFile In files
                If Equals(file.Name, ftp_userFolder) Then is_exist = True
            Next

            'Creating folder IF NOT EXIST
            If is_exist = False Then
                MsgBox("No folder '" & ftp_userFolder & "' existed! Creating one...")
                client.CreateDirectory("./" & ftp_userFolder)
            End If

            'Saving file to Folder
            Dim stream As New MemoryStream
            pb_view_user.Image.Save(stream, Imaging.ImageFormat.Jpeg)
            stream.Position = 0
            client.UploadFile(stream, "./" & ftp_userFolder & "/" & username)
        End Using

        Return username

    End Function


    'Private Function uUploadImageProof(username As String, picture_box As DevExpress.XtraEditors.PictureEdit)

    '    Dim strFile As Stream = Nothing
    '    Dim cred = New NetworkCredential(My.Settings.FTPusername, My.Settings.FTPpass)
    '    Dim URi = "ftp://" & My.Settings.server & ":" & My.Settings.FTPport & "/" & My.Settings.UserFolder

    '    'CONVERTING IMAGE TO BYTES
    '    Dim ms As New MemoryStream
    '    picture_box.Image.Save(ms, Imaging.ImageFormat.Jpeg)
    '    Dim btfile() As Byte = ms.GetBuffer

    '    'Make request for Upload
    '    Dim wrUpload As FtpWebRequest
    '    Dim Filename = username
    '    wrUpload = DirectCast(WebRequest.Create(URi & "/" & Filename), FtpWebRequest)
    '    wrUpload.Credentials = cred
    '    wrUpload.Method = WebRequestMethods.Ftp.UploadFile

    '    'Check IF FOLDER EXIST
    '    Dim chkFolder As FtpWebRequest = DirectCast(WebRequest.Create(URi), FtpWebRequest)
    '    chkFolder.Credentials = cred
    '    chkFolder.Method = WebRequestMethods.Ftp.MakeDirectory

    '    Try

    '        Using response As FtpWebResponse = DirectCast(chkFolder.GetResponse(), FtpWebResponse)
    '            'Get and Write request to server
    '            strFile = wrUpload.GetRequestStream()
    '            strFile.Write(btfile, 0, btfile.Length)
    '        End Using

    '    Catch ex As Exception

    '        'Get and Write request to server
    '        strFile = wrUpload.GetRequestStream()
    '        strFile.Write(btfile, 0, btfile.Length)

    '    Finally
    '        strFile.Close()
    '        strFile.Dispose()
    '    End Try

    '    Return Filename

    'End Function


    'Set User Photo from server

    Private Sub setUserPhoto(FileName As String)

        Using client As New SftpClient(server, ftp_username, ftp_password)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_userFolder & "/" & FileName, ms)

                If Not ms.Length = 0 Then
                    pb_view_user.Image = Image.FromStream(ms)
                End If
            Catch ex As Exception
            End Try
        End Using

    End Sub

    'Private Sub ssetUserPhoto(FileName As String)
    '    Dim DownloadURi = "ftp://" & My.Settings.FTPserver & ":" & My.Settings.FTPport & "/" & My.Settings.UserFolder & "/" & FileName

    '    'Creating Client request to download
    '    Dim DLReq As New WebClient
    '    DLReq.Credentials = New NetworkCredential(My.Settings.FTPusername, My.Settings.FTPpass)
    '    Dim imgbytes() As Byte = DLReq.DownloadData(DownloadURi)

    '    'Setting Image bytes to PictureBox
    '    Dim ms As New MemoryStream(imgbytes)
    '    pb_view_user.Image = Image.FromStream(ms)

    '    'Memory cleaning
    '    DLReq.Dispose()
    '    'ms.Dispose()
    'End Sub

    'Clear Fields
    Private Sub ClearFields()
        txt_fname.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        cbb_store.SelectedIndex = -1
        cbb_role.SelectedIndex = 0
        pb_user.Image = Nothing
    End Sub






    '--- CONTROLS ----

    'btn_add_user
    Private Sub btn_add_user_Click(sender As Object, e As EventArgs) Handles btn_add_user.Click

        If String.IsNullOrEmpty(txt_fname.Text) _
            Or String.IsNullOrEmpty(txt_username.Text) _
            Or String.IsNullOrEmpty(txt_password.Text) _
            Or cbb_store.SelectedIndex <= 0 _
            Or cbb_role.SelectedIndex <= 0 Then
            MsgBox("Complete all required fields!", vbCritical, "Forbidden")
            Exit Sub
        End If


        Dim ans = MsgBox("Add '" & CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_fname.Text.ToLower.Trim) _
            & "' as " & cbb_role.Text.ToUpper & " to store: " & cbb_store.Text.ToUpper, vbQuestion + vbYesNo, "Add New User")
        If ans = vbYes Then

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("INSERT INTO ims_users (first_name, username, pass, assigned_loc, role_id, usr_photo) 
                            VALUES (@first_name, @username, @pass, (SELECT store_id FROM `ims_stores` WHERE store_name=@assigned_loc), 
                            (SELECT role_id FROM ims_user_acc_types WHERE role=@role), @usr_photo)", conn)

                cmd.Parameters.AddWithValue("@first_name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_fname.Text.ToLower.Trim))
                cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim)
                cmd.Parameters.AddWithValue("@pass", Encrypt(txt_password.Text.Trim))
                cmd.Parameters.AddWithValue("@assigned_loc", "winland " & cbb_store.Text.Trim)
                cmd.Parameters.AddWithValue("@role", cbb_role.Text.Trim)

                If pb_user.Image IsNot Nothing Then
                    cmd.Parameters.AddWithValue("@usr_photo", UploadUserPhoto("usr_" & txt_username.Text.Trim & ".jpg", pb_user))
                Else
                    cmd.Parameters.AddWithValue("@usr_photo", "usr_default.jpg")
                End If

                cmd.ExecuteNonQuery()

                ClearFields()
                MsgBox("Account successfully created!", vbInformation, "Register Successfull")
                frm_main.LoadFrm(New frm_admin_users)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'pb_user.Clicked | For Selecting/Uploading
    Private Sub pb_user_Click(sender As Object, e As EventArgs) Handles pb_user.Click
        Dim d As New OpenFileDialog
        If Not d.ShowDialog = DialogResult.Cancel Then
            pb_user.Image = Image.FromFile(d.FileName)
        End If
    End Sub

    'btn_viewpass
    Private Sub btn_viewpass_Click(sender As Object, e As EventArgs) Handles btn_viewpass.Click
        If txt_view_pass.Properties.UseSystemPasswordChar = True Then
            btn_viewpass.ImageOptions.Image = My.Resources.hide_16x16
            txt_view_pass.Properties.UseSystemPasswordChar = False
        Else
            txt_view_pass.Properties.UseSystemPasswordChar = True
            btn_viewpass.ImageOptions.Image = My.Resources.show_16x16
        End If
    End Sub

    'btn_view_update
    Private Sub btn_view_update_Click(sender As Object, e As EventArgs) Handles btn_view_update.Click

        'Validation
        If String.IsNullOrEmpty(txt_view_fname.Text) _
            Or String.IsNullOrEmpty(txt_userid.Text) _
            Or String.IsNullOrEmpty(txt_view_username.Text) _
            Or String.IsNullOrEmpty(txt_view_pass.Text) _
            Or cbb_view_store.SelectedIndex = 0 _
            Or cbb_view_role.SelectedIndex = 0 Then
            MsgBox("Complete all required fields!", vbCritical, "Forbidden")
            Exit Sub
        End If

        Dim uid As Integer = txt_userid.Text
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("UPDATE ims_users SET first_name=@fname, username=@username,
                pass=@password,assigned_loc=(SELECT store_id FROM ims_stores WHERE store_name=@store),
                role_id=(SELECT role_id FROM ims_user_acc_types WHERE role=@role), usr_photo=@usr_photo WHERE usr_id='" & uid & "'", conn)

            cmd.Parameters.AddWithValue("@fname", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_view_fname.Text.Trim.ToLower))
            cmd.Parameters.AddWithValue("@username", txt_view_username.Text.Trim)
            cmd.Parameters.AddWithValue("@password", Encrypt(txt_view_pass.Text.Trim))
            cmd.Parameters.AddWithValue("@store", "Winland " & cbb_view_store.Text.Trim)
            cmd.Parameters.AddWithValue("@role", cbb_view_role.Text.Trim)

            If pb_view_user.Image IsNot Nothing Then
                cmd.Parameters.AddWithValue("@usr_photo", UploadUserPhoto("usr_" & txt_view_username.Text.Trim & ".jpg", pb_view_user))
            Else
                cmd.Parameters.AddWithValue("@usr_photo", "usr_default.jpg")
            End If

            cmd.ExecuteNonQuery()

            MsgBox("Successfully Updated!", vbInformation, "Information")
            frm_main.LoadFrm(New frm_admin_users)


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'grid_users.Clicked
    Private Sub grid_users_Click(sender As Object, e As EventArgs) Handles grid_users.Click

        txt_view_fname.Text = ""
        txt_view_username.Text = ""
        txt_view_pass.Text = ""
        cbb_view_store.SelectedIndex = -1
        cbb_view_role.SelectedIndex = -1
        pb_view_user.Image = Nothing

        bgw_load_account.RunWorkerAsync()

        panel_loading.Height = 278

    End Sub

    'btn_edit_roles
    Private Sub btn_edit_roles_Click(sender As Object, e As EventArgs) Handles btn_edit_roles.Click

        If Not String.IsNullOrEmpty(txt_userid.Text) Then

            Dim frm = New frm_admin_users_role
            frm.acc_id.Text = txt_userid.Text
            frm.acc_name.Text = txt_view_fname.Text
            frm.acc_username.Text = txt_view_username.Text
            frm.acc_role.Text = cbb_view_role.Text
            frm.ShowDialog()

        End If

    End Sub

    'link_disable
    Private Sub link_disable_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_disable.LinkClicked

        If String.IsNullOrEmpty(txt_userid.Text) Then
            MsgBox("Select account on the list first!", vbCritical, "Account Not Found")
            Exit Sub
        End If

        Dim ans = MsgBox(link_disable.Text & "?", vbYesNo + vbQuestion, "Update Status")
        If ans = vbYes Then
            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_users SET deleted=@value WHERE usr_id=@id", conn)

                Dim val = False
                Select Case link_disable.Text
                    Case "Enable this account" : val = False
                    Case "Disable this account" : val = True
                End Select

                cmd.Parameters.AddWithValue("@value", val)
                cmd.Parameters.AddWithValue("@id", CInt(txt_userid.Text))
                cmd.ExecuteNonQuery()

                MsgBox("Account status was successfully updated.", vbInformation, "Success")
                frm_main.LoadFrm(New frm_admin_users)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub

    'btn_new_row | Add new row
    Private Sub btn_new_row_Click(sender As Object, e As EventArgs) Handles btn_new_row.Click

        If Not String.IsNullOrWhiteSpace(TryCast(grid_roles_view.GetRowCellValue(grid_roles_view.RowCount - 1, col_role), String)) Then
            grid_roles_view.AddNewRow()
        End If

    End Sub

    'grid_roles | Initialization
    Private Sub grid_roles_view_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles grid_roles_view.InitNewRow
        grid_roles_view.SetRowCellValue(e.RowHandle, col_role_id, grid_roles_view.RowCount)
    End Sub

    'btn_roles_update | Update Roles
    Private Sub btn_roles_update_Click(sender As Object, e As EventArgs) Handles btn_roles_update.Click

        'Validate Rows
        For i = 0 To grid_roles_view.RowCount - 1
            Dim role = grid_roles_view.GetRowCellValue(i, col_role)
            If String.IsNullOrEmpty(TryCast(role, String)) Then
                MsgBox("Some field(s) are required! Couldn't proceed.", vbCritical, "Error")
                Exit Sub
            End If
        Next

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("INSERT INTO ims_user_acc_types (role_id, role) VALUES (@role_id, @role)
                                ON DUPLICATE KEY UPDATE role=@role", conn)
            cmd.Parameters.AddWithValue("@role_id", Nothing)
            cmd.Parameters.AddWithValue("@role", Nothing)
            cmd.Prepare()

            For i = 0 To grid_roles_view.RowCount - 1
                cmd.Parameters(0).Value = grid_roles_view.GetRowCellValue(i, col_role_id)
                cmd.Parameters(1).Value = grid_roles_view.GetRowCellValue(i, col_role)
                cmd.ExecuteNonQuery()
            Next

            MsgBox("Update Successfull!", vbInformation, "Updated")
            frm_main.LoadFrm(New frm_admin_users)

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'BGW DoWork
    Private Sub bgw_load_account_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_load_account.DoWork
        Try
            Dim userid = grid_users.CurrentRow.Cells(0).Value

            conn.Open()
            Dim cmd = New MySqlCommand("SELECT * FROM ims_users
                            INNER JOIN ims_stores on ims_users.assigned_loc=ims_stores.store_id
                            INNER JOIN ims_user_acc_types ON ims_users.role_id=ims_user_acc_types.role_id WHERE usr_id='" & CInt(userid) & "'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            While rdr.Read
                txt_userid.Invoke(Sub() txt_userid.Text = userid)

                txt_view_fname.Invoke(Sub() txt_view_fname.Text = rdr("first_name"))
                txt_view_username.Invoke(Sub() txt_view_username.Text = rdr("username"))
                txt_view_pass.Invoke(Sub() txt_view_pass.Text = Decrypt(rdr("pass")))
                cbb_view_store.Invoke(Sub() cbb_view_store.Text = rdr("store_name").ToString.Replace("Winland ", ""))
                cbb_view_role.Invoke(Sub() cbb_view_role.Text = rdr("role"))
                pb_user.Invoke(Sub() If (Not IsDBNull(rdr("usr_photo"))) Then setUserPhoto(rdr("usr_photo")))
            End While

            link_disable.Invoke(Sub()
                                    link_disable.Visible = True
                                    If grid_users.CurrentRow.Cells(5).Value.Equals("Active") Then
                                        link_disable.Text = "Disable this account"
                                    Else
                                        link_disable.Text = "Enable this account"
                                    End If
                                End Sub)


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    'BGW Completed
    Private Sub bgw_load_account_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_load_account.RunWorkerCompleted
        panel_loading.Height = 10
    End Sub

    'btn_select_photo
    Private Sub btn_update_photo_Click(sender As Object, e As EventArgs) Handles btn_update_photo.Click

        If txt_userid.Text.Equals("") Then
            MsgBox("Select user first!", vbCritical, "No User Selected")
            Exit Sub
        End If

        Try
            Dim d As New OpenFileDialog
            If Not d.ShowDialog = DialogResult.Cancel Then
                pb_view_user.Image = Image.FromFile(d.FileName)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class