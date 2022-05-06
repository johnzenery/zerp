Imports System.Text
Imports MySqlConnector

Public Class frm_admin_users_role

    ReadOnly conn As New MySqlConnection(str)


    '--- ONLOAD ----
    Private Sub frm_users_role_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_access()
    End Sub



    '--- FUNCTIONS ----

    'Set Access
    Private Sub set_access()

        Try
            Dim result = New StringBuilder
            conn.Open()

            Dim cmd = New MySqlCommand("SELECT access FROM ims_users WHERE usr_id=@id", conn)
            cmd.Parameters.AddWithValue("@id", CInt(acc_id.Text))
            result.Append(cmd.ExecuteScalar)

            'Validation
            If String.IsNullOrEmpty(result.ToString) Then Exit Sub

            Dim access = result.Replace(";", "", result.Length - 1, 1).ToString.Split(";")

            For i = 0 To access.Count - 1

                Select Case access(i)

                    'Product
                    Case "catalogue" : cb_catalogue.Checked = True
                    Case "new_item" : cb_new_item.Checked = True
                    Case "import_catalogue" : cb_import_catalogue.Checked = True
                    Case "export_catalogue" : cb_export_catalogue.Checked = True

                    'Sales
                    Case "orders" : cb_orders.Checked = True
                    Case "quotations" : cb_quotations.Checked = True
                    Case "create_order" : cb_create_order.Checked = True
                    Case "customers" : cb_customers.Checked = True
                    Case "transaction_invoice" : cb_transaction_invoice.Checked = True
                    Case "logistics" : cb_logistics.Checked = True

                    'Warehouse
                    Case "daily_delivery" : cb_receiving_mgmt.Checked = True
                    Case "delivery_logs" : cb_delivery_logs.Checked = True
                    Case "stock_management" : cb_stock_management.Checked = True
                    Case "stock_inventory" : cb_stock_inventory.Checked = True
                    Case "packing_list" : cb_package_mgmt.Checked = True
                    Case "for_selluseller" : cb_for_selluseller.Checked = True

                    'Collections
                    Case "order_payments" : cb_order_payments.Checked = True
                    Case "new_cheque_payment" : cb_new_cheque_payment.Checked = True
                    Case "cheque_book" : cb_cheque_book.Checked = True
                    Case "statement_of_account" : cb_soa.Checked = True

                    'Logistics
                    Case "pickup_deliveries" : cb_order_management.Checked = True
                    Case "st_dispatching" : cb_stock_transfer_dispatching.Checked = True

                    'Purchasing
                    Case "new_purchase" : cb_new_purchase.Checked = True
                    Case "purchase_orders" : cb_purchase_orders.Checked = True

                    'Accounting
                    Case "account_payables" : cb_account_payables.Checked = True
                    Case "generate" : cb_generate.Checked = True
                    Case "payment_vouchers" : cb_payment_vouchers.Checked = True
                    Case "payment_cheques" : cb_payment_cheques.Checked = True

                    'Administration
                    Case "user_accounts" : cb_user_accounts.Checked = True
                    Case "approvals" : cb_approvals.Checked = True
                    Case "price_book" : cb_price_book.Checked = True
                    Case "stores" : cb_stores.Checked = True
                    Case "suppliers" : cb_suppliers.Checked = True
                    Case "settings" : cb_settings.Checked = True
                    Case "reports" : cb_reports.Checked = True

                End Select

            Next

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try

    End Sub


    'Get access based on checked box
    Private Function get_access()

        Dim access = ""

        'Product
        If cb_catalogue.Checked Then access += "catalogue;"
        If cb_new_item.Checked Then access += "new_item;"
        If cb_import_catalogue.Checked Then access += "import_catalogue;"
        If cb_export_catalogue.Checked Then access += "export_catalogue;"

        'Sales
        If cb_orders.Checked Then access += "orders;"
        If cb_quotations.Checked Then access += "quotations;"
        If cb_create_order.Checked Then access += "create_order;"
        If cb_customers.Checked Then access += "customers;"
        If cb_transaction_invoice.Checked Then access += "transaction_invoice;"
        If cb_logistics.Checked Then access += "logistics;"

        'Warehouse
        If cb_receiving_mgmt.Checked Then access += "daily_delivery;"
        If cb_delivery_logs.Checked Then access += "delivery_logs;"
        If cb_stock_management.Checked Then access += "stock_management;"
        If cb_stock_inventory.Checked Then access += "stock_inventory;"
        If cb_package_mgmt.Checked Then access += "packing_list;"
        If cb_for_selluseller.Checked Then access += "for_selluseller;"

        'Collections
        If cb_order_payments.Checked Then access += "order_payments;"
        If cb_new_cheque_payment.Checked Then access += "new_cheque_payment;"
        If cb_cheque_book.Checked Then access += "cheque_book;"
        If cb_soa.Checked Then access += "statement_of_account;"

        'Logistics
        If cb_order_management.Checked Then access += "pickup_deliveries;"
        If cb_stock_transfer_dispatching.Checked Then access += "st_dispatching;"

        'Purchasing
        If cb_new_purchase.Checked Then access += "new_purchase;"
        If cb_purchase_orders.Checked Then access += "purchase_orders;"

        'Accounting
        If cb_account_payables.Checked Then access += "account_payables;"
        If cb_generate.Checked Then access += "generate;"
        If cb_payment_vouchers.Checked Then access += "payment_vouchers;"
        If cb_payment_cheques.Checked Then access += "payment_cheques;"

        'Administration
        If cb_user_accounts.Checked Then access += "user_accounts;"
        If cb_approvals.Checked Then access += "approvals;"
        If cb_price_book.Checked Then access += "price_book;"
        If cb_reports.Checked Then access += "reports;"
        If cb_stores.Checked Then access += "stores;"
        If cb_suppliers.Checked Then access += "suppliers;"
        If cb_settings.Checked Then access += "settings;"

        Return access

    End Function





    '--- CONTROLS ----

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("UPDATE ims_users SET access=@access WHERE usr_id=@id", conn)
            cmd.Parameters.AddWithValue("@access", get_access())
            cmd.Parameters.AddWithValue("@id", CInt(acc_id.Text))
            cmd.ExecuteNonQuery()

            MsgBox("Roles has been updated!", vbInformation, "Successfully Updated")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            conn.Close()
        End Try

    End Sub

    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()
    End Sub

End Class