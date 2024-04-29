Imports MySqlConnector

Public Class frm_admin_users_roles_list


    'ONLOAD
    Private Sub frm_admin_users_roles_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        get_roles()
    End Sub



    '>>> FUNCTION

    'Get Roles from database
    Private Sub get_roles()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT * FROM ims_user_acc_types", connection)
                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_roles.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub




    'BUTTON : NEW ROLE
    Private Sub btn_new_row_Click(sender As Object, e As EventArgs) Handles btn_new_row.Click

        If Not String.IsNullOrWhiteSpace(TryCast(grid_roles_view.GetRowCellValue(grid_roles_view.RowCount - 1, col_role), String)) Then
            grid_roles_view.AddNewRow()
        End If

    End Sub

    'BUTTON : SUBMIT
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
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("INSERT INTO ims_user_acc_types (role_id, role) VALUES (@role_id, @role)
                                ON DUPLICATE KEY UPDATE role=@role", connection)
                cmd.Parameters.AddWithValue("@role_id", Nothing)
                cmd.Parameters.AddWithValue("@role", Nothing)
                cmd.Prepare()

                For i = 0 To grid_roles_view.RowCount - 1
                    cmd.Parameters(0).Value = grid_roles_view.GetRowCellValue(i, col_role_id)
                    cmd.Parameters(1).Value = grid_roles_view.GetRowCellValue(i, col_role)
                    cmd.ExecuteNonQuery()
                Next
            End Using

            MsgBox("Update Successfull!", vbInformation, "Updated")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class