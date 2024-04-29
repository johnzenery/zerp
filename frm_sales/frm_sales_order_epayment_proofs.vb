Imports DevExpress.XtraEditors
Imports MySqlConnector
Imports Renci.SshNet
Imports Renci.SshNet.Sftp
Imports System.IO

Public Class frm_sales_order_epayment_proofs

    Private Property Selected_image_no As Integer = 0




    '--- FUNCTIONS -----

    'Load
    Public Sub LoadData()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT proof_gallery FROM ims_orders WHERE order_id=@id", connection)
                cmd.Parameters.AddWithValue("@id", CInt(lbl_order_id.Text.Replace("SO", String.Empty)))
                Dim res = cmd.ExecuteScalar

                If Not String.IsNullOrEmpty(res) Then
                    Dim photos = res.ToString.Split(";")

                    For i = 0 To photos.Length - 1
                        Dim picturebox = New PictureEdit
                        setImageProof(photos(i), picturebox)
                        picturebox.Tag = i
                        picturebox.Size = New Point(100, 96)
                        picturebox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
                        AddHandler picturebox.Click, AddressOf SelectPic

                        layout_image.Controls.Add(picturebox)
                    Next

                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'SelectPic
    Sub SelectPic(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim pic = CType(sender, PictureEdit)
        Selected_image_no = pic.Tag
        cms.Show(pic, New Point(0, 0))
    End Sub

    'Upload Image Proof
    Private Function UploadImageProof(filename As String, picture_box As DevExpress.XtraEditors.PictureEdit)

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
            client.Connect()

            'Get directoory list
            Dim files = client.ListDirectory("./")

            'Check IF FOLDER EXIST
            Dim is_exist = False
            For Each file As SftpFile In files
                If Equals(file.Name, ftp_salesFolder) Then is_exist = True
            Next

            'Creating folder IF NOT EXIST
            If is_exist = False Then
                MsgBox("No folder '" & ftp_salesFolder & "' existed! Creating one...")
                client.CreateDirectory("./" & ftp_salesFolder)
            End If

            'Saving file to Folder
            Dim stream As New MemoryStream
            picture_box.Image.Save(stream, Imaging.ImageFormat.Jpeg)
            stream.Position = 0
            client.UploadFile(stream, "./" & ftp_salesFolder & "/" & filename)
        End Using

        Return filename

    End Function

    'Set Image Proof
    Private Sub setImageProof(FileName As String, pic_box As PictureEdit)

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_salesFolder & "/" & FileName, ms)

                If Not ms.Length = 0 Then
                    pic_box.Image = Image.FromStream(ms)
                End If
            Catch ex As Exception
            End Try
        End Using

    End Sub





    '--- CONTROLS -----

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click

        Dim fd = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.Filter = "Images |*.jpg;*.png;*.jpeg;*.bmp;"
        fd.RestoreDirectory = True
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim picturebox = New PictureEdit
            picturebox.Image = Image.FromFile(fd.FileName) 'Add Photo
            picturebox.Tag = layout_image.Controls.Count
            picturebox.Size = New Point(100, 96)
            picturebox.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom
            AddHandler picturebox.Click, AddressOf SelectPic

            layout_image.Controls.Add(picturebox)
        End If

    End Sub

    'View Image
    Private Sub ViewImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewImageToolStripMenuItem.Click
        Dim pb_image = TryCast(layout_image.Controls.Item(Selected_image_no), PictureEdit)

        Dim frm = New Form
        frm.Text = "View Photo"
        frm.Size = New Point(500, 500)
        frm.MinimumSize = New Point(500, 500)
        frm.StartPosition = FormStartPosition.CenterScreen

        Dim picture_edit = New PictureEdit
        picture_edit.Dock = DockStyle.Fill
        picture_edit.Image = pb_image.Image
        picture_edit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom

        frm.Controls.Add(picture_edit)
        frm.ShowDialog()

    End Sub

    'Delete
    Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click

        Try
            layout_image.Controls.RemoveAt(Selected_image_no)
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim ans = MsgBox("Press 'YES' to confirm.", vbInformation + vbYesNo, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Dim FileNames As String = String.Empty
        For i = 0 To layout_image.Controls.Count - 1
            Dim pic_box = TryCast(layout_image.Controls.Item(i), PictureEdit)

            If i = layout_image.Controls.Count - 1 Then
                FileNames += UploadImageProof(lbl_order_id.Text & "_" & i & ".jpg", pic_box)
                Continue For
            End If

            FileNames += UploadImageProof(lbl_order_id.Text & "_" & i & ".jpg", pic_box) & ";"
        Next

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("UPDATE ims_orders SET proof_gallery=@proof_gallery WHERE order_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", CInt(lbl_order_id.Text.Replace("SO", String.Empty)))
                    cmd.Parameters.AddWithValue("@proof_gallery", FileNames)
                    'cmd.Parameters.AddWithValue("@status", IIf(String.IsNullOrEmpty(FileNames), "UNPAID", "PENDING CONFIRMATION"))

                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Success!", vbInformation, "Information")
                    End If

                    connection.Close()
                    Me.Close()

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub


End Class