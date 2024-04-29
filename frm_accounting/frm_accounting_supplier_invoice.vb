Imports MySqlConnector

Public Class frm_accounting_supplier_invoice

    '--- ONLOAD ----
    Private Sub frm_accounting_payables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load UNPAIDS
        load_account_payables("AND ims_delivery_receipts.status='UNPAID'")
    End Sub




    '---- FUNCTIONS ----

    'Load Account Payables
    Private Async Sub load_account_payables(status As String)

        Try
            pgb.Visible = True
            Using connection = New MySqlConnection(str)
                connection.Open() '
                '--

                'Dim query = "SELECT payable_id, ims_suppliers.supplier, ims_delivery_receipts.terms, tax_type, dr_no, dr_date, si_no, si_date, ims_delivery_receipts.amount, withholding_tax_amount, ims_delivery_receipts.status, receipt_date, received_date, ims_stores.store_name, 
                '        CONCAT('PO',LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, CONCAT('PV', LPAD(ims_delivery_receipts.p_voucher_id, 5, 0)) as payment_ref, 
                '        DATE_ADD(received_date, INTERVAL ims_delivery_receipts.terms DAY) as due_date, 
                '        (SELECT CONCAT(status, IF(status='CLEAR', ' - ', ''), IFNULL(clearing_date, '')) FROM ims_generated_cheques WHERE p_voucher_id=ims_delivery_receipts.p_voucher_id LIMIT 1) 'clearing_status'
                '        FROM ims_delivery_receipts
                '        LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_delivery_receipts.supplier_id
                '        LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                '        LEFT JOIN ims_payment_vouchers ON ims_payment_vouchers.payment_id=ims_delivery_receipts.p_voucher_id
                '        LEFT JOIN ims_stores ON ims_stores.store_id=ims_delivery_receipts.store_id 
                '        WHERE ims_delivery_receipts.is_deleted=0 " & status & " 
                '        ORDER BY payable_id DESC"

                Dim query = "SELECT 
                                payable_id, 
                                ims_suppliers.supplier, 
                                ims_delivery_receipts.terms,  
                                tax_type,  
                                dr_no,  
                                dr_date,  
                                si_no,  
                                si_date,  
                                ims_delivery_receipts.amount,  
                                withholding_tax_amount,  
                                ims_delivery_receipts.status,  
                                receipt_date,  
                                received_date,  
                                ims_stores.store_name, 
                                CONCAT('PO',LPAD(ims_delivery_receipts.purchase_id, 5, 0)) as purchase_id, 
                                CONCAT('PV', LPAD(ims_delivery_receipts.p_voucher_id, 5, 0)) as payment_ref, 
                                DATE_ADD(received_date, INTERVAL ims_delivery_receipts.terms DAY) as due_date,
                                (SELECT CONCAT(status, IF(status='CLEAR', ' - ', ''), IFNULL(clearing_date, '')) FROM ims_generated_cheques WHERE p_voucher_id=ims_delivery_receipts.p_voucher_id LIMIT 1) 'clearing_status',
                                tbl_deliveries.total_cost,
                                REPLACE(REPLACE(discount, 'Pesos', ''), 'OFF', '') discount,
                                IF(ims_purchase.is_withholding_tax_applied=1, ((tbl_deliveries.total_cost / 1.12) * 0.01), 0.00) ewt
                            FROM ims_delivery_receipts
                            LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_delivery_receipts.supplier_id
                            LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_delivery_receipts.purchase_id
                            LEFT JOIN ims_payment_vouchers ON ims_payment_vouchers.payment_id=ims_delivery_receipts.p_voucher_id
                            LEFT JOIN ims_stores ON ims_stores.store_id=ims_delivery_receipts.store_id 
                            LEFT JOIN (
                                SELECT 
                                    receipt_id, 
                                    SUM(qty * ims_deliveries.cost) as total_cost 
                                FROM ims_deliveries
                                LEFT JOIN ims_inventory ON ims_inventory.pid = ims_deliveries.item
                                GROUP BY receipt_id
                            ) as tbl_deliveries ON tbl_deliveries.receipt_id = ims_delivery_receipts.payable_id
                            WHERE ims_delivery_receipts.is_deleted=0 " & status & " 
                            ORDER BY payable_id DESC"

                Dim cmd = New MySqlCommand(query, connection)
                Dim dt = New DataTable

                Await Task.Run(Sub()
                                   Dim da = New MySqlDataAdapter(cmd)
                                   da.Fill(dt)
                               End Sub)

                grid_payables.DataSource = dt


            End Using
            pgb.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub




    '--- CONTROLS ----


    'btn_all
    Private Sub btn_all_Click(sender As Object, e As EventArgs) Handles btn_all.Click
        load_account_payables(String.Empty)
    End Sub

    'btn_paid
    Private Sub btn_paid_Click(sender As Object, e As EventArgs) Handles btn_paid.Click
        load_account_payables("AND ims_delivery_receipts.status='PAID'")
    End Sub

    'btn_unpaid
    Private Sub btn_unpaid_Click(sender As Object, e As EventArgs) Handles btn_unpaid.Click
        load_account_payables("AND ims_delivery_receipts.status='UNPAID'")
    End Sub

    'btn_issued
    Private Sub btn_issued_Click(sender As Object, e As EventArgs) Handles btn_issued.Click
        load_account_payables("AND ims_delivery_receipts.status='ISSUED'")
    End Sub

    'btn_new_payable
    Private Sub btn_new_payable_Click(sender As Object, e As EventArgs) Handles btn_new_payable.Click
        frm_accounting_new_payable.ShowDialog()
    End Sub

    Private Async Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim payable_id As Integer = grid_payables_view.GetFocusedRowCellValue(col_id)
        Dim frm = New frm_accounting_view_transaction
        frm.Text = "Payable - " & payable_id
        frm.lbl_receipt_id.Text = payable_id
        frm.lbl_purchase_id.Text = CInt(grid_payables_view.GetFocusedRowCellValue(col_purchase_id).ToString.Replace("PO", ""))

        Await frm_main.LoadFrm(frm, "frm_accounting_view_transaction_" & payable_id)
    End Sub

    'BUTTON : EXPORT
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Dim saveFileDialog = New SaveFileDialog With {.Filter = "Microsoft Excel (*.xlsx)|*.xlsx"}

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            grid_payables_view.ExportToXlsx(saveFileDialog.FileName)
        End If

    End Sub

    'BUTTON : REFRESH
    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        load_account_payables(String.Empty)
    End Sub

End Class