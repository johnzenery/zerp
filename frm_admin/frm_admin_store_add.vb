Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class frm_admin_store_add

    ReadOnly conn As New MySqlConnection(str)


    '--- CONTROL ----

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If Not String.IsNullOrEmpty(txt_storename.Text) And
           Not String.IsNullOrEmpty(txt_storeaddr.Text) And
           Not String.IsNullOrEmpty(txt_person_in_charge.Text) Then

            Dim ans = MsgBox("Add '" & txt_storename.Text & "' as new store?", vbQuestion + vbYesNo, "Add New Store")
            If ans = vbYes Then

                Try
                    conn.Open()
                    Dim cmd = New MySqlCommand("INSERT INTO ims_stores (store_name, store_addr, person_in_charge) VALUES (@store_name, @store_addr, @person_in_charge)", conn)

                    With CultureInfo.CurrentCulture.TextInfo
                        cmd.Parameters.AddWithValue("@store_name", (txt_storename.Text.Trim))
                        cmd.Parameters.AddWithValue("@store_addr", .ToTitleCase(txt_storeaddr.Text.Trim))
                        cmd.Parameters.AddWithValue("@person_in_charge", .ToTitleCase(txt_person_in_charge.Text.Trim))
                    End With

                    Dim i = cmd.ExecuteNonQuery()

                    'create table for new added store
                    Dim strName = "ims_" & txt_storename.Text.Trim.ToLower.Replace(" ", "_")
                    CheckToCreateTable(strName)

                    MsgBox("Successfully added new store!", vbInformation, "Added")

                    Me.Dispose()

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                Finally
                    conn.Close()
                End Try
            Else
                Exit Sub
            End If

        Else
            MsgBox("Complete all required fields to continue.", vbCritical, "Incomplete Details")
        End If
    End Sub

    'btn_cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Dispose()
    End Sub




    '--- FUNCTIONS ----

    'Check IF IMS_purchase EXIST
    Private Sub CheckToCreateTable(storeName As String)

        Dim checktable As New MySqlCommand("SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '" & db & "' AND table_name = '" & storeName & "'", conn)

        Dim rdr As MySqlDataReader = checktable.ExecuteReader
        rdr.Read()
        Dim count = rdr("COUNT(*)")
        rdr.Close()

        If count = 0 Then
            Dim createTable As New MySqlCommand("CREATE TABLE `" & storeName & "` ( `pid` varchar(6) NOT NULL PRIMARY KEY, `qty` DECIMAL(10,2) NULL, `on_hold` DECIMAL(10,2) NULL, location VARCHAR(6))", conn)
            createTable.ExecuteNonQuery()
        End If

    End Sub

End Class