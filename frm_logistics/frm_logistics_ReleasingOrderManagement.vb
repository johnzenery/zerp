Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Text.RegularExpressions

Public Class frm_logistics_ReleasingOrderManagement

    '---- ONLOAD ----
    Private Sub frm_logistics_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Orders()
        start_timer()
    End Sub







    '--- FUNCTIONS ----

    'Load Deliveries
    Private Sub Load_Orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, payment_type, 
                                IFNULL(payment_status, 'UNPAID') as payment_status, ship_to, trucking, status, shipping_method, amount_due, ims_stores.store_name AS warehouse
                                FROM `ims_orders` 
                                LEFT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                                LEFT JOIN ims_users on ims_orders.agent=ims_users.usr_id
                                LEFT JOIN ims_stores ON ims_stores.store_id=ims_orders.target_warehouse
                                WHERE status='Packed' AND ims_orders.deleted=0
                                ORDER BY order_id DESC", connection) ' OR status='Released'
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_deliveries.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set Deduct to Stocks
    Private Sub deduct_to_stocks(orderid As String, customer As String)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_item FROM ims_orders WHERE order_id=" & orderid, connection)
                Dim orders = cmd.ExecuteScalar

                Dim comma(), equal() As String
                Dim piece As String
                Dim i As Integer
                Dim colonseparator As New Regex("\b;\b")
                Dim equalseparator As New Regex("\b=\b")

                If Not String.IsNullOrEmpty(orders) Then

                    Dim my_store = "ims_" & frm_main.lbl_user_designation.Text.Replace(" ", "_").ToLower

                    comma = colonseparator.Split(orders)

                    For i = 0 To comma.Length - 1
                        piece = comma(i).Trim
                        equal = piece.Split("=")

                        Dim query = "UPDATE " & my_store & " SET on_hold=IFNULL(on_hold,0)-@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel);
                                        INSERT INTO ims_sales (item, qty, srp, discount, price, cost, purchase_date, customer, order_id)
                                        VALUES ((SELECT pid FROM ims_inventory WHERE winmodel=@winmodel), @qty, @srp, @discount, @price, (SELECT cost FROM ims_inventory WHERE winmodel=@winmodel),  
                                        @purchase_date, (SELECT customer_id FROM ims_customers WHERE first_name=@customer), @order_id)"
                        Dim update_cmd = New MySqlCommand(query, connection)
                        update_cmd.Parameters.AddWithValue("@winmodel", equal(1))
                        update_cmd.Parameters.AddWithValue("@qty", equal(0))

                        If equal.Length = 6 Then    '---- OLD 
                            update_cmd.Parameters.AddWithValue("@price", CDec(equal(5).Replace(";", String.Empty)))
                            update_cmd.Parameters.AddWithValue("@srp", 0.00)
                            update_cmd.Parameters.AddWithValue("@discount", 0.00)

                        ElseIf equal.Length = 8 Or equal.Length = 10 Then    '---- NEW 
                            update_cmd.Parameters.AddWithValue("@price", CDec(equal(6)))
                            update_cmd.Parameters.AddWithValue("@srp", equal(3))
                            update_cmd.Parameters.AddWithValue("@discount", equal(3) - equal(5))

                        End If

                        update_cmd.Parameters.AddWithValue("@purchase_date", Date.Now)
                        update_cmd.Parameters.AddWithValue("@customer", customer)
                        update_cmd.Parameters.AddWithValue("@order_id", orderid)
                        update_cmd.ExecuteNonQuery()
                    Next

                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Start Timer
    Private Sub start_timer()

        Select Case cbb_timer.SelectedIndex
            Case 0 : timer.Interval = 60000
            Case 1 : timer.Interval = 300000
            Case 2 : timer.Interval = 600000
            Case 3 : timer.Interval = 1800000
        End Select

        timer.Stop()
        timer.Start()

    End Sub

    'Timer
    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        Load_Orders()
    End Sub

    'Timer Selection
    Private Sub cbb_timer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_timer.SelectedIndexChanged
        start_timer()
    End Sub



    '----- CONTROLS ----

    'Print
    Private Sub btn_release_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_release.ButtonClick

        Dim orderid = grid_deliveries_view.GetFocusedRowCellValue(col_id)
        Dim shipping_method = grid_deliveries_view.GetFocusedRowCellValue(col_shipping_method)
        Dim payment_status = grid_deliveries_view.GetFocusedRowCellValue(col_payment_status)
        Dim payment_type = grid_deliveries_view.GetFocusedRowCellValue(col_payment_type)
        Dim customer = grid_deliveries_view.GetFocusedRowCellValue(col_customer)
        Dim amount = CDec(grid_deliveries_view.GetFocusedRowCellValue(col_amount))

        Dim frm_driver = New frm_logistics_delivered_by
        Dim driver_name As String = String.Empty


        Select Case shipping_method

            'FOR PICKUP
            Case "Pickup"

                'Validation: SKIP IF TERMS
                If payment_type.Equals("Cash") Or payment_type.Equals("Cheque") Or payment_type.Equals("E-Payment") Or payment_type.Equals("CEC") Then
                    If payment_status.Equals("UNPAID") Or
                        payment_status.Equals("OVERPAID") Or
                        payment_status.Equals("REFUND") Or
                        payment_status.Equals("PARTIAL") Or
                        payment_status.Equals("PENDING CONFIRMATION") Then
                        MsgBox("Oops! Settle the payment first." & vbCrLf & vbCrLf & "Payment Status: " & payment_type, vbCritical, "Payment Error")
                        Exit Sub
                    End If
                End If

                If MsgBox("Release this Order?" & vbCrLf & vbCrLf & "Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                    Try

                        'Deduct To Stocks
                        deduct_to_stocks(orderid, customer)

                        'GET Driver's Name
                        If frm_driver.ShowDialog() = DialogResult.OK Then
                            driver_name = frm_driver.driver_name
                        End If

                        'If PAID
                        Using connection = New MySqlConnection(str)
                            connection.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders 
                                                       LEFT JOIN ims_sales_returns ON ims_sales_returns.sales_return_id=ims_orders.applied_sales_return
                                                        SET 
                                                            ims_sales_returns.is_applied='1', 
                                                            ims_orders.status=IF(payment_type='Terms', 'Released', 'Completed'), 
                                                            date_released=@date, 
                                                            released_by=@released_by,
                                                            delivered_by=@delivered_by
                                                        WHERE order_id=" & orderid, connection)
                            cmd.Parameters.AddWithValue("@date", Date.Now)
                            cmd.Parameters.AddWithValue("@released_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@delivered_by", driver_name)
                            cmd.ExecuteNonQuery()

                            'Add Back to Credit
                            If payment_type.Equals("Terms") Then
                                Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit+@amount WHERE first_name=@fname", connection)
                                credit_cmd.Parameters.AddWithValue("@amount", amount)
                                credit_cmd.Parameters.AddWithValue("@fname", customer)
                                credit_cmd.ExecuteNonQuery()
                            End If

                            connection.Close()
                        End Using

                        frm_sales_transaction_invoice.PrintInvoice(orderid)

                        MsgBox("Released!", vbInformation, "Released")
                        Load_Orders()

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End If


            'FOR DELIVERY
            Case "Deliver"

                'Validation: IF RELESED ALREADY
                If grid_deliveries_view.GetFocusedRowCellValue(col_status).Equals("Released") Then
                    MsgBox("Oops! Package was 'Already Released'.", vbExclamation, "Forbidden")
                    Exit Sub
                End If

                'Validation: IF E-Payment BUT NOT PAID
                If payment_type.Equals("E-Payment") Then
                    If payment_status.Equals("UNPAID") Or
                        payment_status.Equals("OVERPAID") Or
                        payment_status.Equals("REFUND") Or
                        payment_status.Equals("PARTIAL") Or
                        payment_status.Equals("PENDING CONFIRMATION") Then
                        MsgBox("Oops! Settle the payment first." & vbCrLf & vbCrLf & "Payment Status: " & payment_type, vbCritical, "Payment Error")
                        Exit Sub
                    End If
                End If

                If MsgBox("Ready for Delivery?" & vbCrLf & vbCrLf & "This will tag as RELEASED. Continue?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then

                    Dim status = "UNKNOWN STATUS"
                    Select Case payment_status
                        Case "UNPAID", "PARTIAL", "OVERPAID", "REFUND", "PENDING CONFIRMATION" : status = "Released"
                        Case "PAID" : status = "Completed"
                    End Select

                    If payment_type.Equals("Terms") Then
                        status = "Completed"
                    End If

                    Try

                        'GET Driver's Name
                        If frm_driver.ShowDialog() = DialogResult.OK Then
                            driver_name = frm_driver.driver_name
                        End If

                        'Deduct To Stocks
                        deduct_to_stocks(orderid, customer)

                        Using connection = New MySqlConnection(str)
                            connection.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders 
                                                        SET status=@status, date_released=@date, released_by=@released_by, delivered_by=@delivered_by
                                                        WHERE order_id=" & orderid, connection)
                            cmd.Parameters.AddWithValue("@date", Date.Now)
                            cmd.Parameters.AddWithValue("@released_by", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@delivered_by", driver_name)
                            cmd.Parameters.AddWithValue("@status", status)
                            cmd.ExecuteNonQuery()
                        End Using


                        frm_sales_transaction_invoice.PrintInvoice(orderid)

                        Dim msg = String.Empty
                        Select Case payment_status
                            Case "UNPAID", "PARTIAL", "OVERPAID" : msg = "Successfully tag as '" & status.ToUpper & "'" & vbCrLf & vbCrLf & "Please return the payment after Delivery!"
                            Case "PAID" : msg = "Successfully tag as '" & status.ToUpper & "'"
                        End Select


                        If payment_type.Equals("Terms") Then
                            Using connection = New MySqlConnection(str)
                                connection.Open()

                                Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit+@amount WHERE first_name=@fname", connection)
                                credit_cmd.Parameters.AddWithValue("@amount", amount)
                                credit_cmd.Parameters.AddWithValue("@fname", customer)
                                credit_cmd.ExecuteNonQuery()
                            End Using

                            msg = "Successfully tag as '" & status.ToUpper & "'"
                        End If

                        MsgBox(msg, vbInformation, "Success")
                        Load_Orders()

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End If


        End Select

    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        Load_Orders()
    End Sub

End Class