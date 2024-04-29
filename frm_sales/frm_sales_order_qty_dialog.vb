Public Class frm_sales_order_qty_dialog

    Public Property quantity_entered As Decimal = 1
    Public Property dialog_result As DialogResult = DialogResult.Cancel

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        quantity_entered += 1.0
        txt_qty.EditValue = quantity_entered
    End Sub

    Private Sub btn_minus_Click(sender As Object, e As EventArgs) Handles btn_minus.Click
        quantity_entered -= 1.0
        txt_qty.EditValue = quantity_entered
    End Sub

    Private Sub frm_sales_order_qty_dialog_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyCode = Keys.Enter Then
            quantity_entered = txt_qty.EditValue
            Me.DialogResult = DialogResult.OK
        ElseIf e.KeyCode = Keys.Escape Then
            Me.DialogResult = DialogResult.Cancel
        End If
    End Sub

    Private Sub frm_sales_order_qty_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_qty.Select()
    End Sub

    Private Sub txt_qty_Spin(sender As Object, e As DevExpress.XtraEditors.Controls.SpinEventArgs)

        If e.IsSpinUp Then
            quantity_entered += 1
            txt_qty.EditValue = quantity_entered
        Else
            quantity_entered -= 1
            txt_qty.EditValue -= quantity_entered
        End If

    End Sub
End Class