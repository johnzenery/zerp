Imports System.Text.RegularExpressions
Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_logistics_ReleasingOrderManagement


    ReadOnly conn As New MySqlConnection(str)


    '---- ONLOAD ----
    Private Sub frm_logistics_deliveries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadDeliveries()
        start_timer()
    End Sub







    '--- FUNCTIONS ----

    'Load Deliveries
    Private Sub LoadDeliveries()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_id, date_ordered, ims_users.first_name as agent, ims_customers.first_name, payment_type, IFNULL(payment_status, 'UNPAID') as payment_status, ship_to, trucking, status, shipping_method, amount_due FROM `ims_orders` 
                                INNER JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                                INNER JOIN ims_users on ims_orders.agent=ims_users.usr_id
                                WHERE (status='Packed') AND ims_orders.deleted=0
                                ORDER BY order_id DESC", conn) ' OR status='Released'
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_deliveries.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Set Deduct to Stocks
    Private Sub deduct_to_stocks(orderid As String, customer As String)

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_item FROM ims_orders WHERE order_id=" & orderid, conn)
            Dim orders = cmd.ExecuteScalar

            Dim comma(), equal() As String
            Dim piece As String
            Dim i As Integer
            Dim colonseparator As New Regex("\b;\b")
            Dim equalseparator As New Regex("\b=\b")

            If Not String.IsNullOrEmpty(orders) Then

                Dim my_store = "ims_" & frm_main.user_store.Text.Replace(" ", "_").ToLower

                comma = colonseparator.Split(orders)

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    Dim query = "UPDATE " & my_store & " SET on_hold=IFNULL(on_hold,0)-@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel);
                                        INSERT INTO ims_sales (item, qty, price, cost, purchase_date, customer, order_id)
                                        VALUES ((SELECT pid FROM ims_inventory WHERE winmodel=@winmodel), @qty, @price, (SELECT cost FROM ims_inventory WHERE winmodel=@winmodel),  
                                        @purchase_date, (SELECT customer_id FROM ims_customers WHERE first_name=@customer), @order_id)"
                    Dim update_cmd = New MySqlCommand(query, conn)
                    update_cmd.Parameters.AddWithValue("@winmodel", equal(1))
                    update_cmd.Parameters.AddWithValue("@qty", equal(0))
                    update_cmd.Parameters.AddWithValue("@price", CDec(equal(5).Replace(";", "")))
                    update_cmd.Parameters.AddWithValue("@purchase_date", Date.Now)
                    update_cmd.Parameters.AddWithValue("@customer", customer)
                    update_cmd.Parameters.AddWithValue("@order_id", orderid)
                    update_cmd.ExecuteNonQuery()
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
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
        LoadDeliveries()
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

        Select Case shipping_method

            'FOR PICKUP
            Case "Pickup"

                'Validation: SKIP IF TERMS
                If payment_type.Equals("Cash") Or payment_type.Equals("Cheque") Or payment_type.Equals("E-Payment") Then
                    If payment_status.Equals("UNPAID") Or
                        payment_status.Equals("OVERPAID") Or
                        payment_status.Equals("REFUND") Or
                        payment_status.Equals("PARTIAL") Or
                        payment_status.Equals("PENDING CONFIRMATION") Then
                        MsgBox("Oops! Settle the payment first." & vbCrLf & vbCrLf & "Payment Status: " & payment_type, vbCritical, "Payment Error")
                        Exit Sub
                    End If
                End If

                Dim ans = MsgBox("Release this Order?" & vbCrLf & vbCrLf & "Press 'Yes' to Continue.", vbQuestion + vbYesNo, "Confirmation")
                If ans = vbYes Then

                    Try

                        'Deduct To Stocks
                        deduct_to_stocks(orderid, customer)

                        'If PAID
                        conn.Open()
                        Dim cmd = New MySqlCommand("UPDATE ims_orders SET status='Completed', date_released=@date, released_by=@released_by WHERE order_id=" & orderid, conn)
                        cmd.Parameters.AddWithValue("@date", Date.Now)
                        cmd.Parameters.AddWithValue("@released_by", frm_main.user_id.Text)
                        cmd.ExecuteNonQuery()

                        'Deduct to Credit
                        If payment_type.Equals("Terms") Then
                            Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit+@amount WHERE first_name=@fname", conn)
                            credit_cmd.Parameters.AddWithValue("@amount", amount)
                            credit_cmd.Parameters.AddWithValue("@fname", customer)
                            credit_cmd.ExecuteNonQuery()
                        End If

                        conn.Close()

                        frm_sales_transaction_invoice.PrintInvoice(orderid)

                        MsgBox("Successfully Released!", vbInformation, "Released")
                        frm_main.LoadFrm(New frm_logistics_ReleasingOrderManagement)

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        If conn.State = ConnectionState.Open Then conn.Close()
                    End Try

                End If


            'FOR DELIVERY
            Case "Deliver"

                'IF RELESED ALREADY
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

                Dim ans = MsgBox("Ready for Delivery?" & vbCrLf & vbCrLf & "This will tag as RELEASED. Continue?", vbQuestion + vbYesNo, "Confirmation")
                If ans = vbYes Then

                    Dim status = "UNKNOWN STATUS"
                    Select Case payment_status
                        Case "UNPAID", "PARTIAL", "OVERPAID", "REFUND", "PENDING CONFIRMATION" : status = "Released"
                        Case "PAID" : status = "Completed"
                    End Select

                    If payment_type.Equals("Terms") Then
                        status = "Completed"
                    End If

                    Try

                        'Deduct To Stocks
                        deduct_to_stocks(orderid, customer)

                        conn.Open()
                        Dim cmd = New MySqlCommand("UPDATE ims_orders SET status=@status, date_released=@date, released_by=@released_by WHERE order_id=" & orderid, conn)
                        cmd.Parameters.AddWithValue("@date", Date.Now)
                        cmd.Parameters.AddWithValue("@released_by", frm_main.user_id.Text)
                        cmd.Parameters.AddWithValue("@status", status)
                        cmd.ExecuteNonQuery()
                        conn.Close()

                        frm_sales_transaction_invoice.PrintInvoice(orderid)

                        Dim msg = ""
                        Select Case payment_status
                            Case "UNPAID", "PARTIAL", "OVERPAID" : msg = "Successfully tag as '" & status.ToUpper & "'" & vbCrLf & vbCrLf & "Please return the payment after Delivery!"
                            Case "PAID" : msg = "Successfully tag as '" & status.ToUpper & "'"
                        End Select


                        If payment_type.Equals("Terms") Then
                            conn.Open()
                            Dim credit_cmd = New MySqlCommand("UPDATE ims_customers SET used_credit=used_credit+@amount WHERE first_name=@fname", conn)
                            credit_cmd.Parameters.AddWithValue("@amount", amount)
                            credit_cmd.Parameters.AddWithValue("@fname", customer)
                            credit_cmd.ExecuteNonQuery()
                            conn.Close()

                            msg = "Successfully tag as '" & status.ToUpper & "'"
                        End If

                        MsgBox(msg, vbInformation, "Success")
                        frm_main.LoadFrm(New frm_logistics_ReleasingOrderManagement)

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        If conn.State = ConnectionState.Open Then conn.Close()
                    End Try

                End If


        End Select

    End Sub

End Class