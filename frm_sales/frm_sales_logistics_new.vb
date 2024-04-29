Imports MySqlConnector
Imports System.Globalization

Public Class frm_sales_logistics_new


    '--- CONTROLS ---

    'btn_new
    Private Sub btn_quote_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        'Validation
        If String.IsNullOrWhiteSpace(txt_name.Text) Or
            String.IsNullOrWhiteSpace(txt_contact.Text) Or
            String.IsNullOrWhiteSpace(txt_contact_no.Text) Then
            MsgBox("Incomplete fields!", vbCritical, "Fields Required")
            Exit Sub
        End If

        Dim ans = MsgBox("Press 'YES' to continue.", vbInformation + vbYesNo, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = String.Empty
                If Not btn_new.Text.Equals("Update") Then
                    query = "INSERT INTO ims_logistics (logistics_name, logistics_contact, logistics_contact_no, nearest_branch, destinations)
                    VALUES (@logistics_name, @logistics_contact, @logistics_contact_no, @nearest_branch, @destinations)"
                Else
                    query = "UPDATE ims_logistics SET logistics_name=@logistics_name, logistics_contact=@logistics_contact, 
                    logistics_contact_no=@logistics_contact_no, nearest_branch=@nearest_branch, destinations=@destinations WHERE logistics_id=@id"
                End If

                Using cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@id", id.Text)
                    cmd.Parameters.AddWithValue("@logistics_name", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_name.Text.Trim))
                    cmd.Parameters.AddWithValue("@logistics_contact", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_contact.Text.Trim))
                    cmd.Parameters.AddWithValue("@logistics_contact_no", txt_contact_no.Text.Trim)
                    cmd.Parameters.AddWithValue("@nearest_branch", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_nearest.Text.Trim))
                    cmd.Parameters.AddWithValue("@destinations", CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_destinations.Text.Trim))
                    Dim i = cmd.ExecuteNonQuery

                    MsgBox("Success!", vbInformation, "Recorded")
                    Me.Close()

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class