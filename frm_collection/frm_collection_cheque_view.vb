Imports MySqlConnector

Public Class frm_collection_cheque_view


    'btn_apply
    Private Async Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim ans = MsgBox("Mark Cheque as '" & cbb_status.Text & "'", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("UPDATE ims_cheque_collections SET status=@status WHERE cheque_id=" & lbl_cheque_id.Text, connection)
                    cmd.Parameters.AddWithValue("@status", cbb_status.Text)
                    cmd.ExecuteNonQuery()

                    If cbb_status.Text.Equals("CLEARED") Then
                        Dim order_ids = txt_orders.Text.Split(",")
                        Dim result As MySqlDataReader

                        For i = 0 To order_ids.Length - 2

                            Dim rd_cmd = New MySqlCommand("SELECT payment_type, amount_due FROM ims_orders WHERE order_id=" & order_ids(i).Replace(",", String.Empty).Trim, connection)
                            result = rd_cmd.ExecuteReader

                            result.Read()

                            If result("payment_type").Equals("Terms") Then
                                Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit-@amount WHERE first_name=@name", connection)
                                credit_cmd.Parameters.AddWithValue("@amount", CDec(result("amount_due")))
                                credit_cmd.Parameters.AddWithValue("@name", txt_customer.Text)
                                result.Close()

                                credit_cmd.ExecuteNonQuery()

                            End If

                        Next
                    End If

                End Using

                MsgBox("Successfully Updated!", vbInformation, "Success")
                Me.Close()
                Await frm_main.LoadFrm(New frm_collection_cheque_books, "frm_collection_cheque_books")

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'DELETE
    'Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
    '    Try
    '        Using conn = New MySqlConnection(str)
    '            conn.Open()
    '            Using cmd = New MySqlCommand("UPDATE ims_cheque_collections SET is_deleted=1 WHERE cheque_id=@id", conn)
    '                cmd.Parameters.AddWithValue("@id", lbl_cheque_id.Text)
    '                If cmd.ExecuteNonQuery > 0 Then
    '                    MsgBox("Deleted!", vbInformation, "Information")
    '                    Me.Close()
    '                End If
    '            End Using
    '        End Using
    '    Catch ex As Exception

    '    End Try
    'End Sub
End Class