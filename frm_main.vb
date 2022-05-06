Imports System.IO
Imports System.Net
Imports System.Reflection
Imports System.Text
Imports DevExpress.XtraSplashScreen
Imports MySqlConnector
Imports Renci.SshNet

Public Class frm_main

    ReadOnly conn As New MySqlConnection(str)

    '--- On Load ---
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initialize_zerp()
        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        Dim lbl_version = " " & version.Major.ToString & "." & version.Minor.ToString & "." & version.Build.ToString
        Me.Text = "ZERP Business Solution" & lbl_version

    End Sub

    '--- ON CLOSED ---
    Private Sub frm_main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub


    '--- FUNCTIONS ----

    'Init
    Public Sub Initialize_zerp()

        Try

            'Show SplashScreen
            SplashScreenManager.ShowForm(Me, GetType(frm_splash_screen), True, True, False)

            'Display 'Logging in...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Logging in...")
            LogIn(frm_login.global_user_id)

            'Display 'Setting access roles...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Setting access roles...")
            role_access(frm_login.global_user_id)

            'Display 'Loading...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Loading...")
            LoadFrm(New frm_homepage)

            SplashScreenManager.CloseForm()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Log In
    Public Sub LogIn(usr_id As Integer)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT first_name, role, ims_users.role_id, store_name, usr_id, usr_photo FROM ims_users
                                    LEFT JOIN ims_stores ON ims_users.assigned_loc=ims_stores.store_id
                                    INNER JOIN ims_user_acc_types ON ims_users.role_id=ims_user_acc_types.role_id 
                                    WHERE usr_id='" & usr_id & "'", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    user_name.Text = rdr("first_name")
                    user_role.Text = rdr("role")
                    user_role_id.Text = rdr("role_id")
                    user_store.Text = rdr("store_name")
                    user_id.Text = rdr("usr_id")
                    setUserPhoto(rdr("usr_photo"))
                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Role Access
    Private Sub role_access(user_id As Integer)

        Try
            Dim result = New StringBuilder

            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT access FROM ims_users WHERE usr_id=@user_id", conn)
                cmd.Parameters.AddWithValue("@user_id", user_id)
                Dim var As String = cmd.ExecuteScalar

                result.Append(var)
            End Using
            'Hide All Menu
            With Me
                .menu_product.Visible = False
                .menu_sales.Visible = False
                .menu_warehouse.Visible = False
                .menu_collections.Visible = False
                .menu_logistics.Visible = False
                .menu_purchasing.Visible = False
                .menu_accounting.Visible = False
                .menu_administration.Visible = False

                If String.IsNullOrEmpty(result.ToString) Then Exit Sub
                Dim access = result.Replace(";", "", result.Length - 1, 1).ToString.Split(";")

                For i = 0 To access.Count - 1

                    Select Case access(i)

                        'Product
                        Case "catalogue"
                            .menu_product.Visible = True
                            .submenu_catalogue.Visible = True
                        Case "new_item"
                            .menu_product.Visible = True
                            .submenu_new_item.Visible = True
                        Case "import_catalogue"
                            .menu_product.Visible = True
                            .submenu_import_catalogue.Visible = True
                        Case "export_catalogue"
                            .menu_product.Visible = True
                            .submenu_export_catalogue.Visible = True

                        'Sales
                        Case "orders"
                            .menu_sales.Visible = True
                            .submenu_orders.Visible = True
                        Case "quotations"
                            .menu_sales.Visible = True
                            .submenu_quotations.Visible = True
                        Case "create_order"
                            .menu_sales.Visible = True
                            .submenu_create_order.Visible = True
                        Case "customers"
                            .menu_sales.Visible = True
                            .submenu_customers.Visible = True
                        Case "transaction_invoice"
                            .menu_sales.Visible = True
                            .submenu_invoices.Visible = True
                        Case "logistics"
                            .menu_sales.Visible = True
                            .submenu_logistics.Visible = True

                        'Warehouse
                        Case "daily_delivery"
                            .menu_warehouse.Visible = True
                            .submenu_ReceivingManagement.Visible = True
                        Case "delivery_logs"
                            .menu_warehouse.Visible = True
                            .submenu_delivery_logs.Visible = True
                        Case "stock_management"
                            .menu_warehouse.Visible = True
                            .submenu_stock_management.Visible = True
                        Case "stock_inventory"
                            .menu_warehouse.Visible = True
                            .submenu_product_inventory.Visible = True
                        Case "packing_list"
                            .menu_warehouse.Visible = True
                            .submenu_packageManagement.Visible = True
                        Case "for_selluseller"
                            .menu_warehouse.Visible = True
                            .submenu_selluseller.Visible = True

                        'Collections
                        Case "order_payments"
                            .menu_collections.Visible = True
                            .submenu_payments.Visible = True
                        Case "new_cheque_payment"
                            .menu_collections.Visible = True
                            .submenu_payment_new.Visible = True
                        Case "cheque_book"
                            .menu_collections.Visible = True
                            .submenu_cheque_book.Visible = True
                        Case "statement_of_account"
                            .menu_collections.Visible = True
                            .submenu_soa.Visible = True

                        'Logistics
                        Case "pickup_deliveries"
                            .menu_logistics.Visible = True
                            .submenu_order_management.Visible = True
                        Case "st_dispatching"
                            .menu_logistics.Visible = True
                            .submenu_StockTransferDispatching.Visible = True

                        'Purchasing
                        Case "new_purchase"
                            .menu_purchasing.Visible = True
                            .submenu_purchasing_new.Visible = True
                        Case "purchase_orders"
                            .menu_purchasing.Visible = True
                            .submenu_purchasing_orders.Visible = True

                        'Accounting
                        Case "account_payables"
                            .menu_accounting.Visible = True
                            .submenu_account_payables.Visible = True
                        Case "generate"
                            .menu_accounting.Visible = True
                            .submenu_generate.Visible = True
                        Case "payment_vouchers"
                            .menu_accounting.Visible = True
                            .submenu_payment_vouchers.Visible = True
                        Case "payment_cheques"
                            .menu_accounting.Visible = True
                            .submenu_payment_cheques.Visible = True

                        'Administration
                        Case "user_accounts"
                            .menu_administration.Visible = True
                            .submenu_user_accounts.Visible = True
                        Case "approvals"
                            .menu_administration.Visible = True
                            .submenu_approvals.Visible = True
                        Case "price_book"
                            .menu_administration.Visible = True
                            .submenu_price_books.Visible = True
                        Case "reports"
                            .menu_administration.Visible = True
                            .submenu_reports.Visible = True
                        Case "stores"
                            .menu_administration.Visible = True
                            .submenu_warehouse.Visible = True
                        Case "suppliers"
                            .menu_administration.Visible = True
                            .submenu_suppliers.Visible = True
                        Case "settings"
                            .menu_administration.Visible = True
                            .submenu_settings.Visible = True

                    End Select
                Next

            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try

    End Sub

    'Load Form on Panel
    Public Sub LoadFrm(form As Form)
        If panel_content.Controls.Count > 0 Then
            panel_content.Controls.RemoveAt(0)
        End If

        form.TopLevel = False
        form.Dock = DockStyle.Fill
        form.FormBorderStyle = FormBorderStyle.None
        panel_content.Controls.Add(form)
        panel_content.Tag = form
        form.Show()

    End Sub

    'Set User Photo on Login
    Private Sub setUserPhoto(FileName As String)

        Using client As New SftpClient(server, ftp_username, ftp_password)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_userFolder & "/" & FileName, ms)

                If Not ms.Length = 0 Then
                    user_photo.Image = Image.FromStream(ms)
                End If
            Catch ex As Exception
            End Try
        End Using

    End Sub

    'Export Datbase
    Private Sub ExportDatabase()

        Try
            Dim saveFileDialog = New SaveFileDialog
            saveFileDialog.Filter = "CSV File (*.csv*)|*.csv"

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT * FROM ims_inventory", conn)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                Dim fileContent = New StringBuilder

                For Each col As DataColumn In dt.Columns
                    fileContent.Append(col.ColumnName & ",")
                Next

                fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1)

                For Each row As DataRow In dt.Rows

                    For Each cell As Object In row.ItemArray
                        fileContent.Append(cell.ToString.Trim & ",")
                    Next

                    fileContent.Replace(",", System.Environment.NewLine, fileContent.Length - 1, 1)

                Next

                File.WriteAllText(saveFileDialog.FileName, fileContent.ToString)

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub







    '---- Controls -----

    'Shortcut Key to Connection
    Private Sub frm_main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 And e.Modifiers = Keys.Control Then


            'Discount Approcal
            Dim pass As String = ""
            Dim frm_pass = New frm_sales_password_required
            frm_pass.Label1.Text = "Enter Admin Password to continue:"
            Dim result = frm_pass.ShowDialog()

            If Not String.IsNullOrEmpty(frm_pass.Password) Then
                pass = frm_pass.Password
                frm_pass.Dispose()
            End If


            If result = DialogResult.OK Then
                If Not pass.Equals("zerp") Or String.IsNullOrWhiteSpace(pass) Then
                    MsgBox("Password is Incorrect!", vbCritical, "Incorrect Password")
                    Exit Sub
                End If

                frm_connection_panel.ShowDialog()

            End If

        End If
    End Sub



    '-------> My Account

    'Log Out
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frm_login.Show()
        Me.Hide()
    End Sub



    '--------> Catalogue
    Private Sub CatalogueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_catalogue.Click
        LoadFrm(New frm_product_catalogue)
    End Sub



    '--------> SALES 

    'Create Order
    Private Sub CreateOrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_create_order.Click
        frm_sales_create_order.Show()
    End Sub

    'Sales Orders
    Private Sub OrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_orders.Click
        LoadFrm(New frm_sales_orders)
    End Sub

    'Quotations
    Private Sub submenu_quotations_Click(sender As Object, e As EventArgs) Handles submenu_quotations.Click
        LoadFrm(New frm_sales_quotation_order_list)
    End Sub

    'Sales Returns
    Private Sub submenu_returns_Click(sender As Object, e As EventArgs) Handles submenu_returns.Click
        LoadFrm(New frm_sales_return_list)
    End Sub

    'New Customer
    Private Sub NewCustomerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewCustomerToolStripMenuItem.Click
        frm_sales_customers_new.ShowDialog()
    End Sub

    'Registered Customers
    Private Sub RegisteredCustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredCustomersToolStripMenuItem.Click
        LoadFrm(New frm_sales_customers)
    End Sub

    'Invoice List
    Private Sub submenu_invoices_Click(sender As Object, e As EventArgs) Handles submenu_invoices.Click
        frm_sales_transaction_invoice.Show()
    End Sub

    'Sales Logistics
    Private Sub submenu_logistics_Click(sender As Object, e As EventArgs) Handles submenu_logistics.Click
        frm_sales_logistics.Show()
    End Sub




    '---------> PRODUCTS 

    'New Product
    Private Sub NewItemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_new_item.Click
        LoadFrm(New frm_product_new)
    End Sub

    'Import
    Private Sub ImportDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_import_catalogue.Click
        frm_product_import.Show()
    End Sub

    'Export Database
    Private Sub ExportDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_export_catalogue.Click
        ExportDatabase()
    End Sub




    '---------> PURCHASING

    'New Purchase Order
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_purchasing_new.Click
        LoadFrm(New frm_purchaseorder_new)
    End Sub

    'Purchase Orders
    Private Sub PurchaseOrdersToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles submenu_purchasing_orders.Click
        LoadFrm(New frm_purchaseorder_list)
    End Sub

    'Purchase Returns
    Private Sub submenu_po_returns_Click(sender As Object, e As EventArgs) Handles submenu_po_returns.Click
        LoadFrm(New frm_purchaseorder_return_list)
    End Sub




    '---------> ADMINISTRATION

    'User Accounts
    Private Sub UserAccountsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_user_accounts.Click
        LoadFrm(New frm_admin_users)
    End Sub

    'Approval
    Private Sub ApprovalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_approvals.Click
        LoadFrm(New frm_admin_approval)
    End Sub

    'Reports
    Private Sub submenu_reports_Click(sender As Object, e As EventArgs) Handles submenu_reports.Click
        LoadFrm(New frm_admin_reports)
    End Sub

    'Banks
    Private Sub submenu_banks_Click(sender As Object, e As EventArgs) Handles submenu_banks.Click
        LoadFrm(New frm_admin_banks)
    End Sub

    'New Warehouse
    Private Sub submenu2_new_warehouse_Click(sender As Object, e As EventArgs) Handles submenu2_new_warehouse.Click
        frm_admin_store_add.ShowDialog()
    End Sub

    'Warehouse
    Private Sub submenu2_registered_warehouse_Click(sender As Object, e As EventArgs) Handles submenu2_registered_warehouse.Click
        LoadFrm(New frm_admin_stores)
    End Sub

    'New Supplier
    Private Sub NewSupplierToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NewSupplierToolStripMenuItem.Click
        LoadFrm(New frm_admin_supplier_add)
    End Sub

    'Registered Supplier
    Private Sub RegisteredSupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredSupplierToolStripMenuItem.Click
        LoadFrm(New frm_admin_supplier)
    End Sub

    'Price Book
    Private Sub PriceBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_price_books.Click
        LoadFrm(New frm_admin_price_book)
    End Sub

    'Settings
    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_settings.Click
        LoadFrm(New frm_admin_settings)
    End Sub





    '---------> Warehouse

    'Stock Inventory
    Private Sub StockLocationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_product_inventory.Click
        LoadFrm(New frm_warehouse_stock_inventory)
    End Sub

    'Daily Deliveries
    Private Sub DeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_ReceivingManagement.Click
        LoadFrm(New frm_warehouse_receivingManagement)
    End Sub

    'Delivery Logs
    Private Sub DeliveryLogsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_delivery_logs.Click
        LoadFrm(New frm_warehouse_SupplierDeliveries_logs)
    End Sub

    'Returned Units
    Private Sub submenu_returned_units_Click(sender As Object, e As EventArgs)
        LoadFrm(New frm_warehouse_returns_receive)
    End Sub

    'SelluSeller
    Private Sub submenu_selluseller_Click(sender As Object, e As EventArgs) Handles submenu_selluseller.Click
        LoadFrm(New frm_warehouse_selluseller)
    End Sub

    'Reconcile
    Private Sub submenu2_reconcile_Click(sender As Object, e As EventArgs) Handles submenu2_reconcile.Click
        LoadFrm(New frm_warehouse_stock_reconcile_list)
    End Sub

    'Stock Transfer
    Private Sub submenu2_StockTransfer_Click(sender As Object, e As EventArgs) Handles submenu2_StockTransfer.Click
        LoadFrm(New frm_warehouse_stocktransfer_list)
    End Sub



    '----------> Collections

    'Payments
    Private Sub UnpaidOrdersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payments.Click
        LoadFrm(New frm_collection_payments)
    End Sub

    'Cheque Payment
    Private Sub ChequePaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payment_new.Click
        frm_collection_cheque.Show()
    End Sub

    'Cheque Book
    Private Sub ChequeBookToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_cheque_book.Click
        LoadFrm(New frm_collection_cheque_books)
    End Sub

    'Statement of Account
    Private Sub submenu_soa_Click(sender As Object, e As EventArgs) Handles submenu_soa.Click
        LoadFrm(New frm_collection_soa)
    End Sub




    '----------> Logistics

    'Order Releasing Management
    Private Sub PickupDeliveriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_order_management.Click
        LoadFrm(New frm_logistics_ReleasingOrderManagement)
    End Sub

    'Stock Transfer Dispatching
    Private Sub submenu_StockTransferDispatching_Click(sender As Object, e As EventArgs) Handles submenu_StockTransferDispatching.Click
        LoadFrm(New frm_logistics_StockTransferDispatching)
    End Sub



    '----------> Accounting

    ''Generate Cheque
    'Private Sub ChequeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PaymentToolStripMenuItem.Click
    '    LoadFrm(New frm_accounting_generate_payment)
    'End Sub

    ''Generate Voucher
    'Private Sub VoucherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VoucherToolStripMenuItem.Click
    '    LoadFrm(New frm_accounting_generate_voucher)
    'End Sub


    'Generate Payment & Voucher
    Private Sub submenu_generate_Click(sender As Object, e As EventArgs) Handles submenu_generate.Click
        LoadFrm(New frm_accounting_generate_payment)
    End Sub

    'Account Payables
    Private Sub PayablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_account_payables.Click
        LoadFrm(New frm_accounting_payables)
    End Sub

    'Payment Vouchers
    Private Sub PaymentVouchersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payment_vouchers.Click
        LoadFrm(New frm_accounting_payment_vouchers)
    End Sub

    'Payment Cheques
    Private Sub PaymentChequesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_payment_cheques.Click
        LoadFrm(New frm_accounting_payment_cheques)
    End Sub

    'Payment Cash
    Private Sub submenu_payment_cash_Click(sender As Object, e As EventArgs) Handles submenu_payment_cash.Click
        LoadFrm(New frm_accounting_payment_cash)
    End Sub

    'Forecast and Payables
    Private Sub submenu_ForecastAndPayablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles submenu_ForecastAndPayablesToolStripMenuItem.Click
        LoadFrm(New frm_accounting_forecast_payables)
    End Sub

    'Inventory Count
    Private Sub submenu_InventoryCount_Click(sender As Object, e As EventArgs) Handles submenu_InventoryCount.Click
        LoadFrm(New frm_accounting_inventory_count)
    End Sub

    'Packing List
    Private Sub submenu_packageManagement_Click(sender As Object, e As EventArgs) Handles submenu_packageManagement.Click
        LoadFrm(New frm_warehouse_PackageManagement)
    End Sub


End Class
