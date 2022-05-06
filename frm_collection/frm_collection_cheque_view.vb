Imports MySqlConnector

Public Class frm_collection_cheque_view

    ReadOnly conn As New MySqlConnection(str)


    'btn_apply
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Dim ans = MsgBox("Mark Cheque as '" & cbb_status.Text & "'", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_cheque_collections SET status=@status WHERE cheque_id=" & lbl_cheque_id.Text, conn)
                cmd.Parameters.AddWithValue("@status", cbb_status.Text)
                cmd.ExecuteNonQuery()

                If cbb_status.Text.Equals("CLEARED") Then
                    Dim order_ids = txt_orders.Text.Split(",")
                    Dim result As MySqlDataReader

                    For i = 0 To order_ids.Length - 2

                        Dim rd_cmd = New MySqlCommand("SELECT payment_type, amount_due FROM ims_orders WHERE order_id=" & order_ids(i).Replace(",", "").Trim, conn)
                        result = rd_cmd.ExecuteReader

                        result.Read()

                        If result("payment_type").Equals("Terms") Then
                            Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit-@amount WHERE first_name=@name", conn)
                            credit_cmd.Parameters.AddWithValue("@amount", CDec(result("amount_due")))
                            credit_cmd.Parameters.AddWithValue("@name", txt_customer.Text)
                            result.Close()

                            credit_cmd.ExecuteNonQuery()

                        End If

                    Next
                End If


                MsgBox("Successfully Updated!", vbInformation, "Success")
                Me.Close()
                frm_main.LoadFrm(New frm_collection_cheque_books)

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try

        End If

    End Sub


End Class