Imports System.IO
Imports MySqlConnector
Imports Renci.SshNet
Imports Renci.SshNet.Sftp

Public Class frm_admin_user_management


    'ONLOAD
    Private Sub frm_user_management_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Users()
    End Sub



    '>>> FUNCTIONS

    'LOAD USERS
    Private Sub Load_Users()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT usr_id, first_name, username, IF(is_enabled=1, 'Enabled', 'Disabled') status,
                            ims_user_acc_types.role, company_role, ims_stores.store_name as designation, organization, division, department 
                            FROM ims_users
                            LEFT JOIN ims_user_acc_types ON ims_users.role_id=ims_user_acc_types.role_id
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_users.assigned_loc
                            WHERE ims_users.deleted=0", connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_users.DataSource = dt
                Get_Designations()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'GET WAREHOUSE DESIGNATIONS
    Private Sub Get_Designations()
        Using conn = New MySqlConnection(str)
            conn.Open()

            For i = 0 To grid_users_view.RowCount - 1
                Dim designation As String()
                Dim result As String = String.Empty

                'GET DESIGNATIONS
                Using cmd = New MySqlCommand("SELECT designations FROM ims_users WHERE usr_id=@userid", conn)
                    cmd.Parameters.AddWithValue("@userid", grid_users_view.GetRowCellValue(i, col_userid))
                    designation = cmd.ExecuteScalar.ToString.Split(";")
                End Using

                'GET STORE NAME THROUGH STORE ID
                Using cmd_get = New MySqlCommand("SELECT store_name FROM ims_stores WHERE store_id=@store_id", conn)
                    cmd_get.Parameters.AddWithValue("@store_id", 0)
                    cmd_get.Prepare()

                    For j = 0 To designation.Length - 1
                        cmd_get.Parameters(0).Value = designation(j)
                        Using rdr = cmd_get.ExecuteReader
                            While rdr.Read
                                result += rdr("store_name").ToString.Replace("Winland ", "") & IIf(Not j = designation.Length - 1, ", ", "")
                            End While
                        End Using
                    Next

                End Using

                grid_users_view.SetRowCellValue(i, col_designation, result)
            Next


        End Using
    End Sub







    'EVENTS

    'BUTTON : DELETE
    Private Sub btn_delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete.ButtonClick
        If MsgBox("Are you sure you want to delete?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_users SET deleted=1 WHERE usr_id=@user_id", conn)
                        cmd.Parameters.AddWithValue("@user_id", grid_users_view.GetFocusedRowCellValue(col_userid))
                        If cmd.ExecuteNonQuery > 0 Then
                            Load_Users()
                            MsgBox("Successfully deleted!", vbInformation, "Information")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'BUTTON : EDIT
    Private Sub btn_edit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick
        Dim frm = New frm_admin_users_new
        frm.user_id = grid_users_view.GetFocusedRowCellValue(col_userid)
        If frm.ShowDialog() = DialogResult.OK Then
            Load_Users()
        End If
    End Sub

    'BUTTON : NEW USER
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim frm = New frm_admin_users_new
        If frm.ShowDialog() = DialogResult.OK Then
            Load_Users()
        End If
    End Sub

    'BUTTON : ROLES
    Private Sub btn_roles_Click(sender As Object, e As EventArgs) Handles btn_roles.Click
        frm_admin_users_roles_list.ShowDialog()
    End Sub
End Class