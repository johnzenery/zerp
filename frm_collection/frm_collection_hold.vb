Imports MySqlConnector

Public Class frm_collection_hold

    ReadOnly conn As New MySqlConnection(str)
    Private Property order_id = 0

    '--- ONLOAD ----
    Private Sub frm_accounting_hold_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub




    '--- FUNCTIONS ----
    Public Sub LoadData(orderid As Integer)
        order_id = orderid

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT priv_note FROM ims_orders WHERE order_id=" & orderid, conn)
            txt_notes.Text = cmd.ExecuteScalar()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

        Me.ShowDialog()

    End Sub





    '--- CONTROLS ----

    'btn_hold
    Private Sub btn_hold_Click(sender As Object, e As EventArgs) Handles btn_hold.Click

        Dim ans = MsgBox("Tag this order as HOLD?", vbQuestion + vbYesNo, "Confirmation")

        If ans = vbYes Then

            Try
                conn.Open()
                Dim cmd = New MySqlCommand("UPDATE ims_orders SET payment_status='HOLD', priv_note=@priv_note WHERE order_id=" & order_id, conn)
                cmd.Parameters.AddWithValue("@priv_note", txt_notes.Text.Trim)
                cmd.ExecuteNonQuery()

                frm_main.LoadFrm(New frm_collection_payments)


            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            Finally
                conn.Close()
            End Try
        End If

        order_id = 0
        txt_notes.Text = ""
        Me.Close()

    End Sub

    'btn_cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

End Class