Imports MySqlConnector

Public Class frm_collection_hold

    Private Property order_id = 0

    '--- ONLOAD ----
    Private Sub frm_accounting_hold_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    '--- FUNCTIONS ----
    Public Sub LoadData(orderid As Integer)
        order_id = orderid

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT priv_note FROM ims_orders WHERE order_id=" & orderid, connection)
                txt_notes.Text = cmd.ExecuteScalar()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Me.ShowDialog()

    End Sub





    '--- CONTROLS ----

    'btn_hold
    Private Async Sub btn_hold_Click(sender As Object, e As EventArgs) Handles btn_hold.Click

        Dim ans = MsgBox("Tag this order as HOLD?", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()

                    Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_status='HOLD', priv_note=@priv_note WHERE order_id=" & order_id, connection)
                    cmd.Parameters.AddWithValue("@priv_note", txt_notes.Text.Trim)
                    cmd.ExecuteNonQuery()

                    Await frm_main.LoadFrm(New frm_collection_payments, "frm_collection_payments")

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If

        order_id = 0
        txt_notes.Text = String.Empty
        Me.Close()

    End Sub

    'btn_cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

End Class