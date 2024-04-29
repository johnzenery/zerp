Imports System.Drawing.Printing

Public Class doc_sales_order_receipt

    Private Sub doc_invoice_receipt_BeforePrint(sender As Object, e As PrintEventArgs) Handles Me.BeforePrint

        'HIDE SHIPPING & TRUCKING IF PICKUP
        If shipping_method.Value = "Pickup" Then
            lbl_shipping_addr.Visible = False
            lbl_trucking_addr.Visible = False
            XrLabel10.Visible = False
        End If

        'SHOW "THIS DOCUMENT IS NOT VALID FOR CLAIM OF INPUT TAX" IF VATABLE
        If is_vatable.Value = False Then
            XrLabel7.Visible = True
            'panel_vatables.Visible = False
        Else
            XrLabel7.Visible = False
            'panel_vatables.Visible = True
        End If

        'SHOW DEDUCTION IF APPLIED
        If deduction_IsApplied.Value = True Then
            report_deduction.Visible = True
        Else
            report_deduction.Visible = False
        End If

    End Sub

End Class