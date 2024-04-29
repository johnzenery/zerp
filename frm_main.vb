
Imports DevExpress.XtraBars.Docking2010.Views
Imports DevExpress.XtraSplashScreen
Imports MySqlConnector
Imports Renci.SshNet
Imports System.IO
Imports System.Reflection
Imports System.Text
Imports System.Net
Imports System.Text.RegularExpressions
Imports OfficeOpenXml
Imports DevExpress.Spreadsheet

Public Class frm_main

    Public Property global_user_id As Integer = 0
    Public Property global_designation_value As String = String.Empty



    '--- On Load ---
    Private Sub frm_main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DevExpress.Utils.Paint.TextRendererHelper.UseScriptAnalyse = False
        Initialize_zerp()
        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        Dim lbl_version = "v" & version.Major.ToString & "." & version.Minor.ToString & "." & version.Build.ToString
        'Me.Text = "ZERP"

        lbl_zerp_database.Text = My.Settings.DatabaseType
        lbl_zerp_version.Text = lbl_version

        'GET SCREEN SIZE
        Dim primaryScreenSize As Size = Screen.PrimaryScreen.Bounds.Size

        'SET WINDOW SIZE
        'Me.Width = CInt(primaryScreenSize.Width * 0.8)
        'Me.Height = CInt(primaryScreenSize.Height * 0.8)
        Me.WindowState = FormWindowState.Maximized

        'SET MINIMUM SIZE
        Me.MinimumSize = New Size(CInt(primaryScreenSize.Width * 0.8), CInt(primaryScreenSize.Height * 0.8))

    End Sub

    '--- ON CLOSED ---
    Private Sub frm_main_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub



    '--- FUNCTIONS ----

    'Init
    Public Async Sub Initialize_zerp()

        Try

            'Show SplashScreen
            SplashScreenManager.ShowForm(Me, GetType(frm_splash_screen), True, True, False)

            'Display 'Logging in...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Logging in...")
            If LogIn(frm_login.global_user_id) Then
                If Not frm_login.global_user_id = 10 Then
                    Log_Access()
                End If
            End If

            'Display 'Setting access roles...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Setting access roles...")
            role_access_2(frm_login.global_user_id)

            'Display 'Loading...'
            SplashScreenManager.Default.SendCommand(frm_splash_screen.SplashScreenCommand.set_status, "Loading...")
            Await LoadFrm(New frm_homepage, "homepage")

            SplashScreenManager.CloseForm()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'GET EXTERNAL IP ADDRESS
    Private Function GetExternalIp() As String
        Try
            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                     .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return Nothing
        End Try
    End Function

    'INSERT TO ims_logs_access
    Private Sub Log_Access()
        Using conn = New MySqlConnection(str)
            conn.Open()
            Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
            Dim lbl_version = "v" & version.Major.ToString & "." & version.Minor.ToString & "." & version.Build.ToString

            Using cmd = New MySqlCommand("INSERT INTO ims_logs_access (user_id, pc_name, ip_address, zerp_version, access_date) 
                                          VALUES (@user_id, @pc_name, @ip_address, @zerp_version, CURRENT_TIMESTAMP)", conn)
                cmd.Parameters.AddWithValue("@user_id", frm_login.global_user_id)
                cmd.Parameters.AddWithValue("@pc_name", System.Environment.MachineName)
                cmd.Parameters.AddWithValue("@zerp_version", lbl_version)
                cmd.Parameters.AddWithValue("@ip_address", GetExternalIp())

                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    'Log In
    Public Function LogIn(usr_id As Integer)
        Dim is_login As Boolean = False

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim cmd = New MySqlCommand("SELECT first_name, role, ims_users.role_id, usr_id, usr_photo, ims_stores.store_id 
                                    FROM ims_users
                                    LEFT JOIN ims_stores ON ims_stores.store_name=@store_name
                                    INNER JOIN ims_user_acc_types ON ims_users.role_id=ims_user_acc_types.role_id 
                                    WHERE usr_id='" & usr_id & "'", connection)
                cmd.Parameters.AddWithValue("@store_name", frm_login.global_user_designation)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    btn_account.Caption = rdr("first_name")
                    lbl_user_name.Text = rdr("first_name") '
                    lbl_user_role.Text = rdr("role") '
                    lbl_user_role_id.Text = rdr("role_id") '
                    lbl_user_designation_id.Text = rdr("store_id")
                    lbl_user_id.Text = rdr("usr_id") '

                    lbl_user_designation.Text = frm_login.global_user_designation

                    'setUserPhoto(rdr("usr_photo"))

                    is_login = True

                End While
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return is_login

    End Function

    'Role Access
    Private Sub role_access_2(user_id As Integer)

        Try
            Dim result = New StringBuilder

            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT access FROM ims_users WHERE usr_id=@user_id", conn)
                cmd.Parameters.AddWithValue("@user_id", user_id)

                result.Append(cmd.ExecuteScalar)
            End Using

            'Hide All Menu
            With Me
                .menu2_catalog.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_collections.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_logistics.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_accounting.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
                submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Never

                If String.IsNullOrEmpty(result.ToString) Then Exit Sub
                Dim access = result.Replace(";", String.Empty, result.Length - 1, 1).ToString.Split(";")

                For i = 0 To access.Count - 1

                    Select Case access(i)

                        'Product
                        Case "catalogue"
                            .menu2_catalog.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Sales
                        Case "orders"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_sales_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "quotations"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_quotations.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "create_order"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_new_order.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "sales_returns"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_returns.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "customers"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_customers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "transaction_invoice"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_invoices.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "discounting_matrix"
                            .menu2_sales.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_discounting_matrix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Warehouse
                        Case "daily_delivery"
                            .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_receiving_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "stock_management"
                            .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_stock_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "stock_inventory"
                            .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_inventory.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "packing_list"
                            .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_package_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "for_selluseller"
                            .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_new_deliveries.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "generate_barcode"
                            .menu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_generate_barcode.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Collections
                        Case "order_payments"
                            .menu2_collections.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_collection_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "new_cheque_payment"
                            .menu2_collections.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_payment_terms.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "cheque_book"
                            .menu2_collections.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_cheque_book.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "statement_of_account"
                            .menu2_collections.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_billing_statement.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Logistics
                        Case "pickup_deliveries"
                            .menu2_logistics.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_release_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "st_dispatching"
                            .menu2_logistics.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_dispatch_transfers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "stock_returns_releasing"
                            .menu2_logistics.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_stock_returns_releasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Purchasing
                        Case "new_purchase"
                            .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_new_purhcase.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "purchase_orders"
                            .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_purchase_orders.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "purchase_returns"
                            .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_credit_memo.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "stock_returns"
                            .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_stock_return_to_vendor.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "delivery_logs"
                            .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_purchase_delivery_logs.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "purchase_request"
                            .menu2_purchasing.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu_purchase_request.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Accounting
                        Case "account_payables"
                            .menu2_accounting.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_supplier_invoice.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "generate_new"
                            .menu2_accounting.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_generate_payment_vouchers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "generated_payments"
                            .menu2_accounting.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_generated_payments.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                        'Administration
                        Case "user_accounts"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_user_management.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "product_database"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_product_database.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "price_book"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_price_book.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "price_matrix"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_price_matrix.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "registered_banks"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_registered_banks.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "reports"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_reports.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "stores"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_warehouse.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "suppliers"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_suppliers.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "settings"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_company_information.Visibility = DevExpress.XtraBars.BarItemVisibility.Always


                        Case "approvals_po"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_purchase_order.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "approvals_st"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_stock_transfer.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "approvals_sr"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_sales_returns.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "approvals_tr"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_transfer_reports.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "approvals_re"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_reconcilations.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "approvals_qu"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_quotations.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                        Case "approvals_pr"
                            .menu2_administration.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            .submenu2_approvals.Visibility = DevExpress.XtraBars.BarItemVisibility.Always
                            submenu2_approvals_products.Visibility = DevExpress.XtraBars.BarItemVisibility.Always

                    End Select
                Next

            End With

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error Encountered")
        End Try

    End Sub


    'Load Form on Panel
    Public Async Function LoadFrm(form As Form, myTag As String) As Task
        ProgressPanel.Visible = True
        Await Task.Delay(500)
        Await LoadPanel(form, myTag)
        ProgressPanel.Visible = False
    End Function

    'Load a Panel
    Private Async Function LoadPanel(form As Form, myTag As String) As Task
        Dim doc As BaseDocument = TabbedView1.Documents.FirstOrDefault(Function(x) x.Form.Tag.ToString() = myTag)
        If doc IsNot Nothing Then
            TabbedView1.ActivateDocument(doc.Control)
        Else
            form.Tag = myTag
            Dim view = TabbedView1.AddDocument(form)
        End If
        Await Task.Delay(0)
    End Function

    'Set User Photo on Login
    Private Sub setUserPhoto(FileName As String)

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_userFolder & "/" & FileName, ms)

                If Not ms.Length = 0 Then
                    pe_user_photo.Image = Image.FromStream(ms)
                End If
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End Using

    End Sub

    Private Sub ExportDatabase()
        Try
            ExcelPackage.LicenseContext = LicenseContext.Commercial
            Dim saveFileDialog = New SaveFileDialog With {.Filter = "Microsoft Excel (*.xlsx)|*.xlsx"}

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(saveFileDialog.FileName, My.Resources.import_template, False)


                Using package = New ExcelPackage(saveFileDialog.FileName)
                    Dim sheet = package.Workbook.Worksheets(0)

                    Using connection = New MySqlConnection(str)
                        connection.Open()

                        Using cmd = New MySqlCommand("SELECT * FROM ims_inventory", connection)
                            cmd.ExecuteNonQuery()

                            Dim dt = New DataTable
                            Dim da = New MySqlDataAdapter(cmd)
                            da.Fill(dt)


                            For i = 1 To dt.Rows.Count - 1
                                For j = 0 To dt.Columns.Count - 1
                                    sheet.Cells(i + 1, j + 1).Value = dt.Rows(i).Item(j)
                                Next
                            Next


                        End Using
                    End Using

                    package.Save()

                    MsgBox("Exported!", vbInformation, "Information")
                    Log_Export("Exported Catalog.", lbl_user_id.Text)

                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub






    '---- Controls -----

    'Shortcut Key to Connection
    Private Sub frm_main_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F1 And e.Modifiers = Keys.Control Then


            'Discount Approcal
            Dim pass As String = String.Empty
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



    '#### MENU 2 ####

    '>>> CATALOG

    Private Async Sub menu2_catalog_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles menu2_catalog.ItemClick
        Await LoadFrm(New frm_product_catalogue, "frm_product_catalogue")
    End Sub


    '>>> SALES

    'New Sales Order
    Private Async Sub submenu2_new_order_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_new_order.ItemClick
        Await LoadFrm(New frm_sales_order_new, "frm_sales_order_new")
    End Sub

    'Sales Orders
    Private Async Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_sales_orders.ItemClick
        Await LoadFrm(New frm_sales_orders_list, "frm_sales_orders_list")
    End Sub

    'Quotations
    Private Async Sub submenu2_quotations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_quotations.ItemClick
        Await LoadFrm(New frm_sales_quotation_order_list, "frm_sales_quotation_order_list")
    End Sub

    'Sales Returns
    Private Async Sub submenu2_returns_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_returns.ItemClick
        Await LoadFrm(New frm_sales_return_list, "frm_sales_return_list")
    End Sub

    'Customers : New
    Private Async Sub submenu2_customers_new_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_customers_new.ItemClick
        Await LoadFrm(New frm_sales_customers_new, "frm_sales_customers_new")
    End Sub

    'Customers : Registered
    Private Async Sub submenu2_customers_registered_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_customers_registered.ItemClick
        Await LoadFrm(New frm_sales_customers_list, "frm_sales_customers")
    End Sub

    'Discounting Matrix
    Private Async Sub submenu2_discounting_matrix_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_discounting_matrix.ItemClick
        Dim frm = New frm_admin_price_matrix
        frm.Text = "Discounting Matrix"
        frm.lbl_heading.Text = "Discounting Matrix"
        frm.btn_export.Visible = False
        frm.btn_update.Visible = False
        frm.cb_show_null.Visible = False
        frm.col_vip_price.Visible = False
        frm.col_min_margin.Visible = False
        frm.col_max_margin.Visible = False
        frm.col_avg_margin.Visible = False
        frm.col_affected.Visible = False
        frm.grid_price_matrix_view.OptionsBehavior.ReadOnly = True
        Await LoadFrm(frm, "frm_admin_price_matrix")
    End Sub

    'Invoice Receipts
    Private Async Sub submenu2_invoices_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_invoices.ItemClick
        Await LoadFrm(New frm_sales_transaction_invoice, "frm_sales_transaction_invoice")
    End Sub



    '>>> WAREHOUSE

    'Stock Transfers
    Private Async Sub stock_management_transfer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles stock_management_transfer.ItemClick
        Await LoadFrm(New frm_warehouse_stocktransfer_list, "frm_warehouse_stocktransfer_list")
    End Sub

    'Reconcilations
    Private Async Sub stock_management_reconcilations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles stock_management_reconcilations.ItemClick
        Await LoadFrm(New frm_warehouse_stock_reconcile_list, "frm_warehouse_stock_reconcile_list")
    End Sub

    'Stock Transfer Logs
    Private Async Sub stock_management_stocktransfer_logs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles stock_management_stocktransfer_logs.ItemClick
        Await LoadFrm(New frm_warehouse_stocktransfer_logs, "frm_warehouse_stocktransfer_logs")
    End Sub

    'Stock Returns
    Private Async Sub stock_management_returns_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles stock_management_returns.ItemClick
        Dim frm = New frm_return_to_vendor
        frm.btn_pullout_request.Visible = False
        frm.btn_batch_pullout.Visible = False
        frm.btn_confirmation.Visible = False
        frm.tab_pullouts.PageVisible = False
        frm.tab_batch.PageVisible = False
        Await LoadFrm(frm, "frm_stock_return_list")
    End Sub

    'Package Mangement
    Private Async Sub submenu2_package_management_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_package_management.ItemClick
        Await LoadFrm(New frm_warehouse_PackageManagement, "frm_warehouse_PackageManagement")
    End Sub

    'Receiving Management
    Private Async Sub submenu2_receiving_management_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_receiving_management.ItemClick
        Await LoadFrm(New frm_warehouse_receivingManagement, "frm_warehouse_receivingManagement")
    End Sub

    'Supplier Delivery Logs
    Private Async Sub submenu2_delivery_logs_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_purchase_delivery_logs.ItemClick
        Await LoadFrm(New frm_purchaseorder_delivery_logs, "frm_warehouse_delivery_logs")
    End Sub

    'Inventory
    Private Async Sub submenu2_inventory_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_inventory.ItemClick
        Await LoadFrm(New frm_warehouse_stock_inventory, "frm_warehouse_stock_inventory")
    End Sub

    'SelluSeller
    Private Async Sub submenu2_for_selluseller_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_new_deliveries.ItemClick
        Await LoadFrm(New frm_warehouse_new_deliveries, "frm_warehouse_selluseller")
    End Sub

    'Generate Barcode
    Private Sub submenu2_generate_barcode_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_generate_barcode.ItemClick
        Dim frm = New frm_warehouse_barcode_generator
        frm.ShowDialog()
    End Sub

    'Generate Pricetag
    Private Sub submenu2_generate_pricetag_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_generate_pricetag.ItemClick
        Dim frm = New frm_warehouse_pricetag_generator
        frm.ShowDialog()
    End Sub



    '>>> LOGISTICS

    'Release Orders
    Private Async Sub submenu2_release_orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_release_orders.ItemClick
        Await LoadFrm(New frm_logistics_ReleasingOrderManagement, "frm_logistics_ReleasingOrderManagement")
    End Sub

    'Dispatch Transfers
    Private Async Sub submenu2_dispatch_transfers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_dispatch_transfers.ItemClick
        Await LoadFrm(New frm_logistics_StockTransferDispatching, "frm_logistics_StockTransferDispatching")
    End Sub

    'Pullouts Releasing
    Private Async Sub submenu2_pullouts_releasing_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_stock_returns_releasing.ItemClick
        Await LoadFrm(New frm_logistics_StockReturn_releasing, "frm_logistics_stock_return_releasing")
    End Sub



    '>>> COLLECTIONS

    'Collection of Orders
    Private Async Sub submenu2_collection_orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_collection_orders.ItemClick
        Await LoadFrm(New frm_collection_cashier_register, "frm_collection_mix_payment")
    End Sub

    'New Cheque Payment
    Private Sub submenu2_new_cheque_payment_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_payment_terms.ItemClick
        Dim frm = New frm_collection_payment_terms
        frm.ShowDialog()
    End Sub

    'Cheque Book
    Private Async Sub submenu2_cheque_book_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_cheque_book.ItemClick
        Await LoadFrm(New frm_collection_cheque_books, "frm_collection_cheque_books")
    End Sub

    'Statement of Accounts
    Private Async Sub submenu2_soa_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_billing_statement.ItemClick
        Await LoadFrm(New frm_collection_billing_statement, "frm_collection_billing_statement")
    End Sub



    '>>> ACCOUNTING

    'Account Payables
    Private Async Sub submenu2_account_payables_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_supplier_invoice.ItemClick
        Await LoadFrm(New frm_accounting_supplier_invoice, "frm_accounting_payables")
    End Sub

    'Generate Payment & Voucher
    Private Async Sub submenu2_generate_payment_vouchers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_generate_payment_vouchers.ItemClick
        Await LoadFrm(New frm_accounting_generate_payment, "frm_accounting_generate_payment")
    End Sub

    'Payment Vouchers
    Private Async Sub submenu2_generated_vouchers_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_generated_vouchers.ItemClick
        Await LoadFrm(New frm_accounting_payment_vouchers, "frm_accounting_payment_vouchers")
    End Sub

    'Payment Cheques
    Private Async Sub submenu2_generated_cheques_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_generated_cheques.ItemClick
        Await LoadFrm(New frm_accounting_payment_cheques, "frm_accounting_payment_cheques")
    End Sub

    'Payment Cash
    Private Async Sub submenu2_generated_cash_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_generated_cash.ItemClick
        Await LoadFrm(New frm_accounting_payment_cash, "frm_accounting_payment_cash")
    End Sub



    '>>> PURCHASING

    'New Purchase Order
    Private Async Sub submenu2_new_purhcase_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_new_purhcase.ItemClick
        Await LoadFrm(New frm_purchaseorder_edit, "frm_purchaseorder_new")
    End Sub

    'Purchase Orders
    Private Async Sub submenu2_purchase_orders_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_purchase_orders.ItemClick
        Await LoadFrm(New frm_purchaseorder_list, "frm_purchaseorder_list")
    End Sub

    'Return to Vendor
    Private Async Sub submenu2_purchase_returns_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_stock_return_to_vendor.ItemClick
        Await LoadFrm(New frm_return_to_vendor, "frm_return_to_vendor")
    End Sub

    'Credit Memo
    Private Async Sub submenu2_credit_memo_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_credit_memo.ItemClick
        Await LoadFrm(New frm_purchasing_credit_memo, "frm_purchasing_credit_memo")
    End Sub

    'Purchase Request
    Private Async Sub submenu_purchase_request_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu_purchase_request.ItemClick
        Await LoadFrm(New frm_purchaseorder_purchase_request_list, "frm_purchaseorder_purchase_request_list")
    End Sub



    '>>> ADMINISTRATION

    'Admin Approvals
    Private Async Sub submenu2_admin_approvals_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs)
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval")
    End Sub

    'Statistics & Reports
    Private Async Sub submenu2_reports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_reports.ItemClick
        Await LoadFrm(New frm_admin_reports, "frm_admin_reports")
    End Sub

    'Product Database
    Private Async Sub submenu2_product_database_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_product_database.ItemClick
        Await LoadFrm(New frm_admin_product_database, "frm_admin_product_database")
    End Sub

    'Price Book
    Private Async Sub submenu2_price_book_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_price_book.ItemClick
        Await LoadFrm(New frm_admin_price_book, "frm_admin_price_book")
    End Sub

    'Price Matrix
    Private Async Sub submenu2_price_matrix_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_price_matrix.ItemClick
        Await LoadFrm(New frm_admin_price_matrix, "frm_admin_price_matrix")
    End Sub

    'Registered Banks
    Private Async Sub submenu2_registered_banks_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_registered_banks.ItemClick
        Await LoadFrm(New frm_admin_banks, "frm_admin_banks")
    End Sub

    'User Management
    Private Async Sub user_management_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_user_management.ItemClick
        Await LoadFrm(New frm_admin_user_management, "frm_admin_user_management")
    End Sub

    'Warehouse : New
    Private Sub submenu2_warehouse_new_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_warehouse_new.ItemClick
        Dim frm = frm_admin_store_add
        frm.ShowDialog()
    End Sub

    'Warehouse : Management
    Private Async Sub submenu2_warehouse_management_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_warehouse_management.ItemClick
        Await LoadFrm(New frm_admin_stores, "frm_admin_stores")
    End Sub

    'Supplier : New
    Private Async Sub submenu2_suppliers_new_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_suppliers_new.ItemClick
        Await LoadFrm(New frm_admin_supplier_add, "frm_admin_supplier_add")
    End Sub

    'Supplier : Management
    Private Async Sub submenu2_suppliers_management_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_suppliers_management.ItemClick
        Await LoadFrm(New frm_admin_supplier, "frm_admin_supplier")
    End Sub

    'Company Information
    Private Async Sub submenu2_company_information_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_company_information.ItemClick
        Await LoadFrm(New frm_admin_settings, "frm_admin_settings")
    End Sub



    '>>> SETTINGS

    'Printer
    Private Sub submenu2_printer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_printer.ItemClick
        frm_printers.ShowDialog()
    End Sub


    'LOGOUT
    Private Sub link_logout_Click(sender As Object, e As EventArgs) Handles link_logout.Click
        frm_login.Show()
        Me.Dispose()
    End Sub

    'Approvals : Purchase Order
    Private Async Sub submenu2_approvals_purchase_order_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_purchase_order.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_purchase_orders")
    End Sub

    'Approvals : Stock Transfer
    Private Async Sub submenu2_approvals_stock_transfer_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_stock_transfer.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_stock_transfers")
    End Sub

    'Approvals : Quotations
    Private Async Sub submenu2_approvals_quotations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_quotations.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_quotations")
    End Sub

    'Approvals : Sales Returns
    Private Async Sub submenu2_approvals_sales_returns_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_sales_returns.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_sales_returns")
    End Sub

    'Approvals : Stock Returns
    Private Async Sub submenu2_approvals_pullout_requests_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_stock_returns.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_stock_returns")
    End Sub

    'Approvals : Reconcilations
    Private Async Sub submenu2_approvals_reconcilations_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_reconcilations.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_reconcilations")
    End Sub

    'Approvals : Transfer Reports
    Private Async Sub submenu2_approvals_transfer_reports_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_transfer_reports.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_transfer_reports")
    End Sub

    'Approvals : Products
    Private Async Sub submenu2_approvals_products_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles submenu2_approvals_products.ItemClick
        Await LoadFrm(New frm_admin_approval, "frm_admin_approval_products")
    End Sub

End Class





