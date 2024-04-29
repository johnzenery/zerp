Public Class frm_sales_password_required

    Public Property Password As String

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If Not String.IsNullOrWhiteSpace(txt_password.Text) Then
            Password = txt_password.Text
            Me.Close()
        End If
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()
    End Sub

    Private Sub txt_password_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_password.KeyUp
        If e.KeyCode = Keys.Enter Then
            btn_submit.PerformClick()
        End If
    End Sub
End Class