Public Class frm_warehouse_stock_transfer_receive_dialog

    Private Function txt_stock_transfer_id_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_stock_transfer_id.KeyDown
        If e.KeyCode = Keys.Enter Then
            btn_retrieve.PerformClick()
        End If

        Return DialogResult.Cancel

    End Function

End Class