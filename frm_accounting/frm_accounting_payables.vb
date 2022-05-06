Imports MySqlConnector

Public Class frm_accounting_payables

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ----
    Private Sub frm_accounting_payables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_account_payables("")
    End Sub




    '---- FUNCTIONS ----

    'Load Account Payables
    Private Sub load_account_payables(status As String)

        Try
            conn.Open()
            Dim query = "SELECT payable_id, ims_suppliers.supplier, ims_purchase.terms, receipt_ref, receipt_type, amount, ims_delivery_receipts.status, received_date, ims_stores.store_name, 
                        CONCAT('PO',LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, CONCAT('PV', LPAD(ims_delivery_receipts.p_voucher_id, 5, 0)) as payment_ref, 
                        DATE_ADD(received_date, INTERVAL ims_suppliers.terms DAY) as due_date 
                        FROM ims_delivery_receipts
                        LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_delivery_receipts.supplier_id
                        LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                        LEFT JOIN ims_payment_vouchers ON ims_payment_vouchers.payment_id=ims_delivery_receipts.p_voucher_id
                        LEFT JOIN ims_stores ON ims_stores.store_id=ims_delivery_receipts.store_id " & status & " ORDER BY payable_id DESC"
            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_payables.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try

    End Sub




    '--- CONTROLS ----


    'btn_all
    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        load_account_payables("")
    End Sub

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click
        load_account_payables("WHERE status='PAID'")
    End Sub

    'btn_unpaid
    Private Sub btn_unpaid_Click(sender As Object, e As EventArgs) Handles btn_unpaid.Click
        load_account_payables("WHERE status='UNPAID'")
    End Sub

    'btn_issued
    Private Sub btn_issued_Click(sender As Object, e As EventArgs) Handles btn_issued.Click
        load_account_payables("WHERE status='ISSUED'")
    End Sub

    'btn_new_payable
    Private Sub btn_new_payable_Click(sender As Object, e As EventArgs) Handles btn_new_payable.Click
        frm_accounting_new_payable.ShowDialog()
    End Sub

    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim payable_id As Integer = grid_payables_view.GetFocusedRowCellValue(col_id)
        Dim frm = New frm_accounting_view_transaction
        frm.lbl_payable_id.Text = payable_id
        If frm.ShowDialog() = DialogResult.OK Then
            load_account_payables("")
        End If
    End Sub
End Class