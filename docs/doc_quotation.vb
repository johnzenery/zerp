Public Class doc_quotation
    Private Sub doc_quotation_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint


        If is_term_applied.Value = True Then
            XrLabel38.Visible = True
            XrLabel39.Visible = True
            XrLabel41.Visible = True
            XrLabel43.Visible = True
        Else
            XrLabel38.Visible = False
            XrLabel39.Visible = False
            XrLabel41.Visible = False
            XrLabel43.Visible = False
        End If
    End Sub
End Class