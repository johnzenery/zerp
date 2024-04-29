Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Text.RegularExpressions

Public Class frm_warehouse_sales_order_packed

    Public Property view_status = String.Empty

    '--- ON LOAD ----
    Private Sub frm_packing_list_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    '--- FUNCTIONS ---

    'Load Data
    Public Sub LoadData(orderid As Integer, status As String)

        txt_orderid.Text = orderid

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT ims_customers.first_name as customer, ims_users.first_name as agent, priv_note, pub_note, prepared_by, checked_by
                         FROM ims_orders 
                         INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer
                         INNER JOIN ims_users ON ims_users.usr_id=ims_orders.agent WHERE order_id=@order_id"


                Dim cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@order_id", orderid)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    txt_customer.Text = rdr("customer")
                    txt_agent.Text = rdr("agent")
                    txt_priv_comment.Text = rdr("priv_note")
                    txt_pub_comment.Text = rdr("pub_note")
                    txt_prepared_by.Text = IIf(IsDBNull(rdr("prepared_by")), "", rdr("prepared_by"))
                    txt_checked_packed_by.Text = IIf(IsDBNull(rdr("checked_by")), "", rdr("checked_by"))
                End While

                'UPDATE GUI
                Select Case status
                    Case "On-Going"
                        txt_prepared_by.Enabled = True
                        txt_checked_packed_by.Enabled = True
                        btn_packed.Text = "Mark as PACKED"
                        Me.Text = "Packing List"
                    Case "Cancelled Order"
                        txt_prepared_by.Enabled = False
                        txt_checked_packed_by.Enabled = False
                        btn_packed.Text = "Mark as UNPACKED"
                        Me.Text = "Unpacking List"
                End Select

                view_status = status
                txt_priv_comment.Select()
                Me.ShowDialog()

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try


    End Sub

    'Set Stocks to ON-HOLD
    Private Sub set_onhold(orderid As String, type As String)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT order_item FROM ims_orders WHERE order_id=" & orderid, connection)
                Dim orders = cmd.ExecuteScalar

                Dim query = String.Empty, comma(), equal() As String
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


                        Select Case type
                            Case "hold"
                                query = "UPDATE " & my_store & " SET qty=qty-@qty, on_hold=IFNULL(on_hold,0)+@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel)"
                            Case "unhold"
                                query = "UPDATE " & my_store & " SET qty=qty+@qty, on_hold=IFNULL(on_hold,0)-@qty
                                        WHERE pid=(SELECT pid FROM ims_inventory WHERE winmodel=@winmodel)"
                        End Select

                        Dim update_cmd = New MySqlCommand(query, connection)
                        update_cmd.Parameters.AddWithValue("@qty", equal(0))
                        update_cmd.Parameters.AddWithValue("@winmodel", equal(1))
                        update_cmd.ExecuteNonQuery()
                    Next

                End If
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub






    '--- CONTROLS / EVENTS ----

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        frm_sales_order_new.print_packing_list(txt_orderid.Text)
    End Sub

    'btn_pack
    Private async Sub btn_packed_Click(sender As Object, e As EventArgs) Handles btn_packed.Click

        Select Case view_status
            Case "On-Going"

                If String.IsNullOrEmpty(txt_checked_packed_by.Text) Or String.IsNullOrEmpty(txt_prepared_by.Text) Then
                    MsgBox("Complete all required fields!", vbCritical, "Incomplete")
                    Return
                End If

                If MsgBox("Press YES to confirm.", vbInformation + vbYesNo, "Confirmation") = vbYes Then

                    Try
                        Using connection = New MySqlConnection(str)
                            connection.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET priv_note=@priv_note, pub_note=@pub_note, 
                                        prepared_by=@prepared_by, checked_by=@checked_by, packed_by=@packer, 
                                        date_packed=CURRENT_TIMESTAMP, status='Packed',
                                        no_of_box=@box, no_of_plastic=@plastic, no_of_rolls=@rolls WHERE order_id=" & txt_orderid.Text, connection)
                            cmd.Parameters.AddWithValue("@prepared_by", txt_prepared_by.Text)
                            cmd.Parameters.AddWithValue("@checked_by", txt_checked_packed_by.Text)
                            cmd.Parameters.AddWithValue("@packer", frm_main.lbl_user_id.Text)
                            cmd.Parameters.AddWithValue("@priv_note", txt_priv_comment.Text.Trim())
                            cmd.Parameters.AddWithValue("@pub_note", txt_pub_comment.Text.Trim())
                            cmd.Parameters.AddWithValue("@box", IIf(String.IsNullOrEmpty(txt_box_no.Text.Trim()), Nothing, txt_box_no.Text))
                            cmd.Parameters.AddWithValue("@plastic", IIf(String.IsNullOrEmpty(txt_plastic_no.Text.Trim()), Nothing, txt_plastic_no.Text))
                            cmd.Parameters.AddWithValue("@rolls", IIf(String.IsNullOrEmpty(txt_rolls_no.Text.Trim()), Nothing, txt_rolls_no.Text))
                            Await cmd.ExecuteNonQueryAsync()
                        End Using

                        set_onhold(txt_orderid.Text, "hold")

                        MsgBox("Successfully tag as 'PACKED'!", vbInformation, "PACKED")
                        Me.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
                    End Try

                End If
            Case "Cancelled Order"

                Dim ans = MsgBox("Tag this Package Order as UNPACKED?", vbQuestion + vbYesNo, "Confirmation")
                If ans = vbYes Then
                    Try
                        Using connection = New MySqlConnection(str)
                            connection.Open()

                            Dim cmd = New MySqlCommand("UPDATE ims_orders SET priv_note=@note, status='Cancelled' WHERE order_id=" & txt_orderid.Text, connection)
                            cmd.Parameters.AddWithValue("@note", txt_priv_comment.Text)
                            cmd.ExecuteNonQuery()
                        End Using

                        set_onhold(txt_orderid.Text, "unhold")

                        MsgBox("Update Successfull!", vbInformation, "Information")
                        Me.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message, vbCritical, "Error")
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

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub
End Class