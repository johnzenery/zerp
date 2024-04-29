Public Class doc_payment_voucher

    Private Sub doc_payment_voucher_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint

        If purchase_return_report.RowCount = 0 Then
            purchase_return_report.Visible = False
        End If

        If payment_type.Value.Equals("cash") Then
            PV_Cheque.Visible = False
        ElseIf payment_type.Value.Equals("cheque") Then
            PV_Cash.Visible = False
        End If

    End Sub

End Class