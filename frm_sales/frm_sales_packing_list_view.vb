Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_sales_packing_list_view

    ReadOnly conn As New MySqlConnection(str)
    Public Property view_status = ""

    '--- ON LOAD ----
    Private Sub frm_packing_list_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPackers()
    End Sub


    '--- FUNCTIONS ---

    'Load Data
    Public Sub LoadData(orderid As Integer, status As String)

        txt_orderid.Text = orderid

        Try
            Dim query = "SELECT ims_customers.first_name as customer, ims_users.first_name as agent, priv_note, pub_note FROM `ims_orders` 
                         INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                         INNER JOIN ims_users ON ims_users.usr_id=ims_orders.agent WHERE order_id=@order_id"

            conn.Open()
            Dim cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@order_id", orderid)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            While rdr.Read
                txt_customer.Text = rdr("customer")
                txt_agent.Text = rdr("agent")
                txt_priv_comment.Text = rdr("priv_note")
                txt_pub_comment.Text = rdr("pub_note")
            End While

            'UPDATE GUI
            Select Case status
                Case "On-Going"
                    cbb_packer.Visible = True
                    lbl_packed_by.Visible = True
                    btn_packed.Text = "Mark as PACKED"
                Case "Cancelled Order"
                    cbb_packer.Visible = False
                    lbl_packed_by.Visible = False
                    btn_packed.Text = "Mark as UNPACKED"
            End Select

            view_status = status

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

        txt_priv_comment.Select()
        Me.ShowDialog()
    End Sub

    'Print
    Private Sub print_packing_list(id As String)
        Dim report = New doc_packing_list()
        Dim printTool = New ReportPrintTool(report)
        Dim rdr As MySqlDataReader
        Dim table = New PrintData
        Dim orders = String.Empty

        Try
            conn.Open()
            Dim query = "SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_customers.contact_person, ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, ims_orders.priv_note, trucking, shipping_method FROM `ims_orders` 
                            LEFT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            LEFT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'
                            UNION
                         SELECT ims_orders.order_id, ims_customers.first_name as customer, ims_customers.contact_person, ims_users.first_name as agent, ims_orders.order_item, ims_orders.ship_to, ims_orders.date_ordered, ims_orders.priv_note, trucking, shipping_method FROM `ims_orders` 
                            RIGHT JOIN ims_customers on ims_orders.customer=ims_customers.customer_id
                            RIGHT JOIN ims_users on ims_orders.agent=ims_users.usr_id WHERE order_id='" & id & "'"
            Dim cmd = New MySqlCommand(query, conn)
            rdr = cmd.ExecuteReader

            Using rdr
                rdr.Read()
                report.Parameters("order_id").Value = String.Concat("SO", rdr("order_id").ToString.PadLeft(5, "0"c))
                report.Parameters("customer").Value = rdr("customer")
                report.Parameters("contact_person").Value = rdr("contact_person")
                report.Parameters("address").Value = rdr("ship_to")
                report.Parameters("agent").Value = rdr("agent")
                report.Parameters("ordered_date").Value = rdr("date_ordered")
                report.Parameters("priv_notes").Value = rdr("priv_note")
                report.Parameters("trucking").Value = rdr("trucking")
                report.Parameters("shipping_method").Value = rdr("shipping_method")
                orders = rdr("order_item")
            End Using

            data_to_grid(orders, table.packing_list)

            report.RequestParameters = False
            report.DataSource = table

            printTool.AutoShowParametersPanel = False
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Set Grid Data
    Public Sub data_to_grid(units As String, GridOrTable As DataTable)

        Dim comma(), equal() As String
        Dim piece As String
        Dim i As Integer
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")
        Dim location = ""

        If GridOrTable.Rows.Count > 0 Then GridOrTable.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            comma = colonseparator.Split(units)

            For i = 0 To comma.Length - 1
                piece = comma(i).Trim
                equal = piece.Split("=")

                With conn
                    Dim my_store = "ims_" & frm_main.user_store.Text.Trim.Replace(" ", "_").ToLower
                    Dim cmd = New MySqlCommand("SELECT location FROM " & my_store & " INNER JOIN ims_inventory ON ims_inventory.pid=" & my_store & " .pid WHERE ims_inventory.winmodel=@model", conn)
                    cmd.Parameters.AddWithValue("@store", my_store)
                    cmd.Parameters.AddWithValue("@model", equal(1))
                    location = cmd.ExecuteScalar()
                End With

                GridOrTable.Rows.Add(equal(0), equal(1), equal(2), location)

            Next

            GridOrTable.DefaultView.Sort = "model ASC"

        End If

    End Sub

    'Load Packer
    Private Sub LoadPackers()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT first_name FROM ims_users WHERE role_id='5'", conn)
            Dim rdr As MySqlDataReader = cmd.ExecuteReader

            Dim Coll As ComboBoxItemCollection = cbb_packer.Properties.Items

            Coll.BeginUpdate()

            While rdr.Read
                Coll.Add(rdr("first_name"))
            End While

            Coll.EndUpdate()

            cbb_packer.SelectedIndex = -1

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Set Stocks to ON-HOLD
    Private Sub set_to_on_hold(orderid As String, type As String)

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT order_item FROM ims_orders WHERE order_id=" & orderid, conn)
            Dim orders = cmd.ExecuteScalar

            Dim query = "", comma(), equal() As String
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


                    Select Case type
                        Case "hold"
                            query = "UPDATE " & my_store & " SET qty=qty-@qty, on_hold=IFNULL(on_hold,0)+@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel)"
                        Case "unhold"
                            query = "UPDATE " & my_store & " SET qty=qty+@qty, on_hold=IFNULL(on_hold,0)-@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel)"
                    End Select

                    Dim update_cmd = New MySqlCommand(query, conn)
                    update_cmd.Parameters.AddWithValue("@qty", equal(0))
                    update_cmd.Parameters.AddWithValue("@winmodel", equal(1))
                    update_cmd.ExecuteNonQuery()
                Next

            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try

    End Sub






    '--- CONTROLS / EVENTS ----

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        'print_packing_list(txt_orderid.Text)
        frm_sales_view_order.print_packing_list(txt_orderid.Text)
    End Sub

    'btn_pack
    Private Sub btn_packed_Click(sender As Object, e As EventArgs) Handles btn_packed.Click

        Select Case view_status
            Case "On-Going"

                'Validate
                If cbb_packer.SelectedIndex = -1 Then
                    MsgBox("Select Who Pack First!", vbCritical, "Error")
                    Exit Sub
                End If

                'Insert to DB
                Try
                    conn.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_orders SET priv_note=@priv_note, pub_note=@pub_note, packed_by=(SELECT usr_id FROM ims_users WHERE first_name=@packer), date_packed=CURRENT_TIMESTAMP, status='Packed',
                                        no_of_box=@box, no_of_plastic=@plastic, no_of_rolls=@rolls WHERE order_id=" & txt_orderid.Text, conn)
                    cmd.Parameters.AddWithValue("@packer", cbb_packer.Text)
                    cmd.Parameters.AddWithValue("@priv_note", txt_priv_comment.Text.Trim())
                    cmd.Parameters.AddWithValue("@pub_note", txt_pub_comment.Text.Trim())
                    cmd.Parameters.AddWithValue("@box", IIf(String.IsNullOrEmpty(txt_box_no.Text.Trim()), Nothing, txt_box_no.Text))
                    cmd.Parameters.AddWithValue("@plastic", IIf(String.IsNullOrEmpty(txt_plastic_no.Text.Trim()), Nothing, txt_plastic_no.Text))
                    cmd.Parameters.AddWithValue("@rolls", IIf(String.IsNullOrEmpty(txt_rolls_no.Text.Trim()), Nothing, txt_rolls_no.Text))
                    cmd.ExecuteNonQuery()
                    conn.Close()

                    set_to_on_hold(txt_orderid.Text, "hold")

                    MsgBox("Successfully tag as 'PACKED'!", vbInformation, "PACKED")
                    Me.Close()

                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                Finally
                    If conn.State = ConnectionState.Open Then conn.Close()
                End Try

            Case "Cancelled Order"

                Dim ans = MsgBox("Tag this Package Order as UNPACKED?", vbQuestion + vbYesNo, "Confirmation")
                If ans = vbYes Then
                    Try
                        conn.Open()
                        Dim cmd = New MySqlCommand("UPDATE ims_orders SET priv_note=@note, status='Cancelled' WHERE order_id=" & txt_orderid.Text, conn)
                        cmd.Parameters.AddWithValue("@note", txt_priv_comment.Text)
                        cmd.ExecuteNonQuery()
                        conn.Close()

                        set_to_on_hold(txt_orderid.Text, "unhold")

                        MsgBox("Update Successfull!", vbInformation, "Information")
                        Me.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    Finally
                        If conn.State = ConnectionState.Open Then conn.Close()
                    End Try
                End If
        End Select


    End Sub

    Private Sub txt_box_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_box_no.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txt_plastic_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_plastic_no.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    Private Sub txt_rolls_no_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_rolls_no.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

End Class