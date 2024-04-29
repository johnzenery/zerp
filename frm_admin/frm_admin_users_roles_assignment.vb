Imports MySqlConnector
Imports System.Text

Public Class frm_admin_users_roles_assignment


    '--- ONLOAD ----
    Private Sub frm_users_role_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        set_access()
    End Sub



    '--- FUNCTIONS ----

    'Set Access
    Private Sub set_access()

        Try
            Dim result = New StringBuilder
            Using connection = New MySqlConnection(str)
                connection.Open()


                Dim cmd = New MySqlCommand("SELECT access FROM ims_users WHERE usr_id=@id", connection)
                cmd.Parameters.AddWithValue("@id", CInt(acc_id.Text))
                result.Append(cmd.ExecuteScalar)

                'Validation
                If String.IsNullOrEmpty(result.ToString) Then Exit Sub

                Dim access = result.Replace(";", String.Empty, result.Length - 1, 1).ToString.Split(";")

                For i = 0 To access.Count - 1

                    Select Case access(i)

                    'Product
                        Case "catalogue" : cb_catalogue.Checked = True

                    'Sales
                        Case "orders" : cb_orders.Checked = True
                        Case "quotations" : cb_quotations.Checked = True
                        Case "create_order" : cb_create_order.Checked = True
                        Case "customers" : cb_customers.Checked = True
                        Case "transaction_invoice" : cb_transaction_invoice.Checked = True
                        Case "logistics" : cb_logistics.Checked = True
                        Case "sales_returns" : cb_sales_returns.Checked = True
                        Case "discounting_matrix" : cb_discounting_matrix.Checked = True

                    'Warehouse
                        Case "daily_delivery" : cb_receiving_mgmt.Checked = True
                        Case "receiving_supplier_delivery" : cb_receiving_supplier_delivery.Checked = True
                        Case "receiving_stock_transfer" : cb_receiving_stock_transfer.Checked = True
                        Case "receiving_stock_returns" : cb_receiving_stock_returns.Checked = True
                        Case "receiving_sales_returns" : cb_receiving_sales_returns.Checked = True
                        Case "stock_management" : cb_stock_management.Checked = True
                        Case "stock_inventory" : cb_stock_inventory.Checked = True
                        Case "packing_list" : cb_package_mgmt.Checked = True
                        Case "for_selluseller" : cb_for_selluseller.Checked = True
                        Case "generate_barcode" : cb_generate_barcode.Checked = True

                    'Collections
                        Case "order_payments" : cb_order_payments.Checked = True
                        Case "new_cheque_payment" : cb_new_cheque_payment.Checked = True
                        Case "cheque_book" : cb_cheque_book.Checked = True
                        Case "statement_of_account" : cb_soa.Checked = True

                    'Logistics
                        Case "pickup_deliveries" : cb_order_management.Checked = True
                        Case "st_dispatching" : cb_stock_transfer_dispatching.Checked = True
                        Case "stock_returns_releasing" : cb_stock_returns_releasing.Checked = True

                    'Purchasing
                        Case "new_purchase" : cb_new_purchase.Checked = True
                        Case "purchase_orders" : cb_purchase_orders.Checked = True
                        Case "purchase_returns" : cb_credit_memo.Checked = True
                        Case "stock_returns" : cb_stock_returns.Checked = True
                        Case "delivery_logs" : cb_delivery_logs.Checked = True
                        Case "purchase_request" : cb_purchase_request.Checked = True

                    'Accounting
                        Case "account_payables" : cb_account_payables.Checked = True
                        Case "generate_new" : cb_generate_new.Checked = True
                        Case "generated_payments" : cb_generated_payments.Checked = True

                    'Administration
                        Case "user_accounts" : cb_user_accounts.Checked = True
                        Case "product_database" : cb_product_database.Checked = True
                        Case "price_book" : cb_price_book.Checked = True
                        Case "price_matrix" : cb_price_matrix.Checked = True
                        Case "registered_banks" : cb_registered_banks.Checked = True
                        Case "stores" : cb_stores.Checked = True
                        Case "suppliers" : cb_suppliers.Checked = True
                        Case "settings" : cb_company_information.Checked = True
                        Case "reports" : cb_reports.Checked = True

                        Case "approvals_po" : cb_approvals_po.Checked = True
                        Case "approvals_st" : cb_approvals_st.Checked = True
                        Case "approvals_sr" : cb_approvals_sr.Checked = True
                        Case "approvals_tr" : cb_approvals_tr.Checked = True
                        Case "approvals_re" : cb_approvals_re.Checked = True
                        Case "approvals_qu" : cb_approvals_qu.Checked = True
                        Case "approvals_pr" : cb_approvals_pr.Checked = True

                    End Select

                Next
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub


    'Get access based on checked box
    Private Function get_access()

        Dim access = String.Empty

        'Product
        If cb_catalogue.Checked Then access += "catalogue;"

        'Sales
        If cb_orders.Checked Then access += "orders;"
        If cb_quotations.Checked Then access += "quotations;"
        If cb_create_order.Checked Then access += "create_order;"
        If cb_customers.Checked Then access += "customers;"
        If cb_transaction_invoice.Checked Then access += "transaction_invoice;"
        If cb_logistics.Checked Then access += "logistics;"
        If cb_sales_returns.Checked Then access += "sales_returns;"
        If cb_discounting_matrix.Checked Then access += "discounting_matrix;"

        'Warehouse
        If cb_receiving_mgmt.Checked Then access += "daily_delivery;"
        If cb_receiving_supplier_delivery.Checked Then access += "receiving_supplier_delivery;"
        If cb_receiving_stock_transfer.Checked Then access += "receiving_stock_transfer;"
        If cb_receiving_stock_returns.Checked Then access += "receiving_stock_returns;"
        If cb_receiving_sales_returns.Checked Then access += "receiving_sales_returns;"
        If cb_stock_management.Checked Then access += "stock_management;"
        If cb_stock_inventory.Checked Then access += "stock_inventory;"
        If cb_package_mgmt.Checked Then access += "packing_list;"
        If cb_for_selluseller.Checked Then access += "for_selluseller;"
        If cb_generate_barcode.Checked Then access += "generate_barcode;"

        'Collections
        If cb_order_payments.Checked Then access += "order_payments;"
        If cb_new_cheque_payment.Checked Then access += "new_cheque_payment;"
        If cb_cheque_book.Checked Then access += "cheque_book;"
        If cb_soa.Checked Then access += "statement_of_account;"

        'Logistics
        If cb_order_management.Checked Then access += "pickup_deliveries;"
        If cb_stock_transfer_dispatching.Checked Then access += "st_dispatching;"
        If cb_stock_returns_releasing.Checked Then access += "stock_returns_releasing;"

        'Purchasing
        If cb_new_purchase.Checked Then access += "new_purchase;"
        If cb_purchase_orders.Checked Then access += "purchase_orders;"
        If cb_credit_memo.Checked Then access += "purchase_returns;"
        If cb_stock_returns.Checked Then access += "stock_returns;"
        If cb_delivery_logs.Checked Then access += "delivery_logs;"
        If cb_purchase_request.Checked Then access += "purchase_request;"

        'Accounting
        If cb_account_payables.Checked Then access += "account_payables;"
        If cb_generate_new.Checked Then access += "generate_new;"
        If cb_generated_payments.Checked Then access += "generated_payments;"

        'Administration
        If cb_approvals_po.Checked Then access += "approvals_po;"
        If cb_approvals_st.Checked Then access += "approvals_st;"
        If cb_approvals_sr.Checked Then access += "approvals_sr;"
        If cb_approvals_tr.Checked Then access += "approvals_tr;"
        If cb_approvals_qu.Checked Then access += "approvals_qu;"
        If cb_approvals_pr.Checked Then access += "approvals_pr;"
        If cb_approvals_re.Checked Then access += "approvals_re;"

        If cb_reports.Checked Then access += "reports;"
        If cb_product_database.Checked Then access += "product_database;"
        If cb_price_book.Checked Then access += "price_book;"
        If cb_price_matrix.Checked Then access += "price_matrix;"
        If cb_registered_banks.Checked Then access += "registered_banks;"
        If cb_user_accounts.Checked Then access += "user_accounts;"
        If cb_stores.Checked Then access += "stores;"
        If cb_suppliers.Checked Then access += "suppliers;"
        If cb_company_information.Checked Then access += "settings;"

        Return access

    End Function





    '--- CONTROLS ----

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("UPDATE ims_users SET access=@access WHERE usr_id=@id", connection)
                cmd.Parameters.AddWithValue("@access", get_access())
                cmd.Parameters.AddWithValue("@id", CInt(acc_id.Text))
                cmd.ExecuteNonQuery()

                MsgBox("Roles has been updated!", vbInformation, "Successfully Updated")
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    'btn_close
    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Dispose()
    End Sub

End Class