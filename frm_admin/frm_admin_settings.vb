Imports MySqlConnector

Public Class frm_admin_settings

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ----
    Private Sub frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub





    '--- FUNCTIONS ----
    Private Sub load_store_info()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET Company Name
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='store_name'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            txt_company_name.Text = result("value")
                        End While
                    End Using
                End Using

                'GET COMPANY's Information
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='store_info'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            txt_company_info.Text = result("value")
                        End While
                    End Using
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub



    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("UPDATE ims_settings SET value=@company_info WHERE name='store_info'; 
                                        UPDATE ims_settings SET value=@company_name WHERE name='store_name'", conn)
            cmd.Parameters.AddWithValue("@company_name", txt_company_name.Text.Trim)
            cmd.Parameters.AddWithValue("@company_info", txt_company_info.Text.Trim)
            cmd.ExecuteNonQuery()

            MsgBox("Updated Successfullly!", vbInformation, "Success")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub nav_documents_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles nav_documents.SelectedPageChanged
        If e.Page.Caption = nav_documents.Text Then
            load_store_info()
        End If
    End Sub
End Class