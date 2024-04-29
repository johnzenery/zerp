Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraSpreadsheet.API.Native.Implementation
Imports MySqlConnector
Imports Renci.SshNet
Imports Renci.SshNet.Sftp

Public Class frm_admin_users_new

    Public Property user_id As Integer = 0

    'ONLOAD
    Private Sub frm_admin_users_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_GridWarehouse()
        Get_Roles()
        Load_UserDetails(user_id)
    End Sub



    'FUNCTIONS

    'LOAD USER ACCOUNT DETAILS
    Private Sub Load_UserDetails(id As Integer)
        If Not id = 0 Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Using cmd = New MySqlCommand("SELECT DISTINCT company_role FROM ims_users", conn)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                cbb_company_role.Properties.Items.Add(rdr("company_role"))
                            End While
                        End Using
                    End Using

                    Using cmd = New MySqlCommand("SELECT usr_id, first_name, username, pass, designations, company_role, ims_users.role_id, usr_photo, is_enabled,
                                                ims_user_acc_types.role, organization, division, department
                                                FROM ims_users 
                                                LEFT JOIN ims_user_acc_types ON ims_user_acc_types.role_id=ims_users.role_id
                                                WHERE usr_id=" & id, conn)
                        Using rdr = cmd.ExecuteReader
                            While rdr.Read
                                Me.Text = rdr("first_name")
                                txt_userid.Text = rdr("usr_id")
                                txt_fname.Text = rdr("first_name")
                                txt_username.Text = rdr("username")
                                txt_password.Text = Decrypt(rdr("pass"))
                                cbb_role.SelectedText = rdr("role")
                                cbb_company_role.EditValue = rdr("company_role")
                                pb_user.Image = IIf(IsDBNull(rdr("usr_photo")), Nothing, setUserPhoto(rdr("usr_photo")))
                                toggle_status.IsOn = rdr("is_enabled")
                                cbb_organization.EditValue = rdr("organization")
                                cbb_division.EditValue = rdr("division")
                                cbb_department.EditValue = rdr("department")

                                Dim selected_warehouse = rdr("designations").ToString.Split(";")
                                For i = 0 To selected_warehouse.Length - 1
                                    For j = 0 To grid_warehouse_view.RowCount - 1
                                        If Equals(selected_warehouse(i).ToString, grid_warehouse_view.GetRowCellValue(j, col_storeid).ToString) Then
                                            grid_warehouse_view.SelectRow(j)
                                        End If
                                    Next
                                Next

                            End While
                        End Using
                    End Using

                    conn.Close()
                End Using
                btn_save.Location = btn_add_user.Location
                btn_add_user.Visible = False
                btn_save.Visible = True
                btn_edit_roles.Visible = True
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'LOAD WAREHOUSE TO GRID
    Private Sub Load_GridWarehouse()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_stores", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_warehouse.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Clear Fields
    Private Sub ClearFields()
        txt_fname.Text = String.Empty
        txt_username.Text = String.Empty
        txt_password.Text = String.Empty
        cbb_role.SelectedIndex = -1
        pb_user.Image = Nothing

        For i = 0 To grid_warehouse_view.RowCount
            grid_warehouse_view.UnselectRow(i)
        Next

    End Sub

    'Upload Photo to Server
    Private Function UploadUserPhoto(username As String, picture_box As DevExpress.XtraEditors.PictureEdit)

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
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
            pb_user.Image.Save(stream, Imaging.ImageFormat.Jpeg)
            stream.Position = 0
            client.UploadFile(stream, "./" & ftp_userFolder & "/" & username)
        End Using

        Return username

    End Function

    'Set User Photo from server
    Private Function setUserPhoto(FileName As String)
        Dim user_image As Image = Nothing

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_userFolder & "/" & FileName, ms)

                If Not ms.Length = 0 Then
                    user_image = Image.FromStream(ms)
                End If
            Catch ex As Exception
            End Try
        End Using

        Return user_image
    End Function

    'Get Roles from database
    Private Sub Get_Roles()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT * FROM ims_user_acc_types", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    cbb_role.Properties.Items.Add(rdr("role"))
                End While

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'GET WAREHOUSE'S ID
    Private Function GetCustomerIDs() As String
        Dim customer_ids As String = String.Empty

        Dim selected_rows = grid_warehouse_view.GetSelectedRows

        For i = 0 To selected_rows.Length - 1
            customer_ids = IIf(i = 0,
                                   String.Concat(customer_ids, grid_warehouse_view.GetRowCellValue(selected_rows(i), col_storeid)),
                                   String.Concat(customer_ids, ";", grid_warehouse_view.GetRowCellValue(selected_rows(i), col_storeid))
                                   )
        Next

        Return customer_ids

    End Function






    '>>> EVENTS

    'BUTTON : BROWSE
    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Dim open_dialog As New OpenFileDialog
        If Not open_dialog.ShowDialog = DialogResult.Cancel Then
            pb_user.Image = Image.FromFile(open_dialog.FileName)
        End If
    End Sub

    'BUTTON : CREATE
    Private Sub btn_add_user_Click(sender As Object, e As EventArgs) Handles btn_add_user.Click

        If String.IsNullOrEmpty(txt_fname.Text) _
            Or String.IsNullOrEmpty(txt_username.Text) _
            Or String.IsNullOrEmpty(txt_password.Text) _
            Or grid_warehouse_view.GetSelectedRows.Count = 0 _
            Or cbb_role.SelectedIndex = -1 Then
            MsgBox("Complete all fields!", vbCritical, "Forbidden")
            Exit Sub
        End If


        If MsgBox("Add '" & CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_fname.Text.ToLower.Trim) _
            & "' as " & cbb_role.Text.ToUpper & "?", vbQuestion + vbYesNo, "Add New User") = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    'VALIDATION
                    Using cmd = New MySqlCommand("SELECT COUNT(*) FROM ims_users WHERE username=@username", connection)
                        cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim)
                        If cmd.ExecuteScalar > 0 Then
                            MsgBox("Duplicate username found!", vbCritical, "Duplicate")
                            Exit Sub
                        End If
                    End Using

                    'INSERT COMMAND
                    Using cmd = New MySqlCommand("INSERT INTO ims_users (first_name, username, pass, designations, role_id, company_role, usr_photo, is_enabled, organization, division, department) 
                            VALUES (@first_name, @username, @pass, @designations, 
                            (SELECT role_id FROM ims_user_acc_types WHERE role=@role), @company_role, @usr_photo, @is_enabled, @organization, @division, @department)", connection)

                        cmd.Parameters.AddWithValue("@first_name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_fname.Text.ToLower.Trim))
                        cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim)
                        cmd.Parameters.AddWithValue("@pass", Encrypt(txt_password.Text.Trim))
                        cmd.Parameters.AddWithValue("@designations", GetCustomerIDs())
                        cmd.Parameters.AddWithValue("@role", cbb_role.Text.Trim)
                        cmd.Parameters.AddWithValue("@company_role", cbb_company_role.Text.Trim)
                        cmd.Parameters.AddWithValue("@is_enabled", toggle_status.IsOn)
                        cmd.Parameters.AddWithValue("@organization", cbb_organization.EditValue)
                        cmd.Parameters.AddWithValue("@division", cbb_division.EditValue)
                        cmd.Parameters.AddWithValue("@department", cbb_department.EditValue)

                        If pb_user.Image IsNot Nothing Then
                            cmd.Parameters.AddWithValue("@usr_photo", UploadUserPhoto("usr_" & txt_username.Text.Trim & ".jpg", pb_user))
                        Else
                            cmd.Parameters.AddWithValue("@usr_photo", "usr_default.jpg")
                        End If

                        cmd.ExecuteNonQuery()
                    End Using

                End Using

                    ClearFields()
                MsgBox("Account successfully created!", vbInformation, "Information")
                'Me.Close()
                Me.DialogResult = DialogResult.OK
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try

        End If

    End Sub

    'BUTTON : SAVE
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If String.IsNullOrEmpty(txt_fname.Text) _
            Or String.IsNullOrEmpty(txt_username.Text) _
            Or String.IsNullOrEmpty(txt_password.Text) _
            Or grid_warehouse_view.GetSelectedRows.Count = 0 _
            Or cbb_role.SelectedIndex = -1 Then
            MsgBox("Complete all fields!", vbCritical, "Forbidden")
            Exit Sub
        End If

        If MsgBox("Press 'Yes' to confirm.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("UPDATE ims_users 
                            SET first_name=@first_name, username=@username, pass=@pass, is_enabled=@is_enabled,
                            designations=@designations, company_role=@company_role, usr_photo=@usr_photo, ims_users.role_id=(SELECT role_id FROM ims_user_acc_types WHERE role=@role),
                            organization=@organization, division=@division, department=@department
                            WHERE usr_id=@usr_id", connection)

                    cmd.Parameters.AddWithValue("@usr_id", txt_userid.Text)
                    cmd.Parameters.AddWithValue("@first_name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_fname.Text.ToLower.Trim))
                    cmd.Parameters.AddWithValue("@username", txt_username.Text.Trim)
                    cmd.Parameters.AddWithValue("@pass", Encrypt(txt_password.Text.Trim))
                    cmd.Parameters.AddWithValue("@designations", GetCustomerIDs())
                    cmd.Parameters.AddWithValue("@role", cbb_role.Text.Trim)
                    cmd.Parameters.AddWithValue("@company_role", cbb_company_role.Text.Trim)
                    cmd.Parameters.AddWithValue("@is_enabled", toggle_status.IsOn)
                    cmd.Parameters.AddWithValue("@organization", cbb_organization.EditValue)
                    cmd.Parameters.AddWithValue("@division", cbb_division.EditValue)
                    cmd.Parameters.AddWithValue("@department", cbb_department.EditValue)

                    If pb_user.Image IsNot Nothing Then
                        cmd.Parameters.AddWithValue("@usr_photo", UploadUserPhoto("usr_" & txt_username.Text.Trim & ".jpg", pb_user))
                    Else
                        cmd.Parameters.AddWithValue("@usr_photo", "usr_default.jpg")
                    End If

                    cmd.ExecuteNonQuery()
                End Using

                MsgBox("Saved!", vbInformation, "Information")
                'Me.Close()
                Me.DialogResult = DialogResult.OK
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try

        End If

    End Sub

    'BUTTON : CLOSE
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    'BUTTON : VIEW PASS
    Private Sub btn_view_pass_Click(sender As Object, e As EventArgs) Handles btn_view_pass.Click
        If txt_password.Properties.UseSystemPasswordChar = True Then
            btn_view_pass.ImageOptions.Image = My.Resources.hide_16x16
            txt_password.Properties.UseSystemPasswordChar = False
        Else
            btn_view_pass.ImageOptions.Image = My.Resources.show_16x16
            txt_password.Properties.UseSystemPasswordChar = True
        End If
    End Sub

    'BUTTON : EDIT ROLES
    Private Sub btn_edit_roles_Click(sender As Object, e As EventArgs) Handles btn_edit_roles.Click
        If Not String.IsNullOrEmpty(txt_userid.Text) Then
            Dim frm = New frm_admin_users_roles_assignment
            frm.acc_id.Text = txt_userid.Text
            frm.acc_name.Text = txt_fname.Text
            frm.acc_username.Text = txt_username.Text
            frm.acc_role.Text = cbb_role.Text
            frm.ShowDialog()
        End If
    End Sub

End Class