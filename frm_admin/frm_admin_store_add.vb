Imports DevExpress.XtraReports.Design
Imports MySqlConnector
Imports System.Globalization

Public Class frm_admin_store_add


    '--- CONTROL ----

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If Not String.IsNullOrEmpty(txt_storename.Text) And
           Not String.IsNullOrEmpty(txt_storeaddr.Text) And
           Not String.IsNullOrEmpty(txt_person_in_charge.Text) Then

            If MsgBox("Add '" & txt_storename.Text & "' as new warehouse?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                Try
                    Using connection = New MySqlConnection(str)
                        connection.Open()

                        Using cmd = New MySqlCommand("INSERT INTO ims_stores (store_name, store_addr, person_in_charge) VALUES (@store_name, @store_addr, @person_in_charge)", connection)
                            With CultureInfo.CurrentCulture.TextInfo
                                cmd.Parameters.AddWithValue("@store_name", (txt_storename.Text.Trim))
                                cmd.Parameters.AddWithValue("@store_addr", .ToTitleCase(txt_storeaddr.Text.Trim))
                                cmd.Parameters.AddWithValue("@person_in_charge", .ToTitleCase(txt_person_in_charge.Text.Trim))
                            End With

                            If cmd.ExecuteNonQuery() > 0 Then
                                'create table for new added store
                                Dim strName = "ims_" & txt_storename.Text.Trim.ToLower.Replace(" ", "_")
                                If CheckToCreateTable(strName, connection) = True Then
                                    MsgBox("Successfull!", vbInformation, "Information")
                                End If
                            End If
                        End Using

                        Me.Close()
                    End Using

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
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
    Private Function CheckToCreateTable(storeName As String, conn As MySqlConnection) As Boolean
        Dim result = False
        Dim count As Integer = 0
        Dim builder = New MySqlConnectionStringBuilder(conn.ConnectionString)
        Dim database As String = builder.Database

        'CHECK IF EXIST
        Using checktable = New MySqlCommand("SELECT COUNT(*) 
                                           FROM information_schema.tables 
                                           WHERE table_schema = '" & db & "' AND table_name = '" & storeName & "'", conn)
            Using rdr = checktable.ExecuteReader
                While rdr.Read
                    count = rdr("COUNT(*)")
                End While
            End Using
        End Using

        'IF NOT -> CREATE TABLE
        If count = 0 Then
            Dim createTable = New MySqlCommand("CREATE TABLE `" & storeName & "` 
                                    ( `pid` varchar(50) NOT NULL PRIMARY KEY, 
                                      `qty` DECIMAL(10,2) DEFAULT 0.00, 
                                      `on_hold` DECIMAL(10,2) NULL, 
                                      `location` VARCHAR(50),
                                      `location_2` VARCHAR(50),
                                      `zone` VARCHAR(50)
                                    )", conn)
            If createTable.ExecuteNonQuery() > 0 Then
                result = True
            End If
        End If

        Return result

    End Function

End Class