Imports MySqlConnector

Public Class frm_admin_price_book

    ReadOnly conn As New MySqlConnection(str)


    '--- ON LOAD ---
    Private Sub frm_price_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPriceBooks()
    End Sub




    '--- FUNCTIONS ----

    'Load Price Books
    Private Sub LoadPriceBooks()

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT LPAD(pid, 6, 0) as pid, winmodel, description, main_category, sub_category, brand, base_price, cost, discount, regular_price, dealer_price, vip_price FROM ims_inventory", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_pricebooks.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub DeliveryView_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles DeliveryView.CellValueChanged

        Dim discount As Integer = 0
        If Not IsDBNull(DeliveryView.GetFocusedRowCellValue(col_discount)) Then
            discount = DeliveryView.GetFocusedRowCellValue(col_discount)
        End If

        Dim base_price As Decimal = DeliveryView.GetFocusedRowCellValue(col_base_price)
        Dim cost As Decimal = DeliveryView.GetFocusedRowCellValue(col_cost)
        Dim pid As Integer = DeliveryView.GetFocusedRowCellValue(col_pid)

        Dim new_cost As Decimal = base_price - (base_price * (discount / 100))

        If e.Column.Equals(col_discount) Or e.Column.Equals(col_base_price) Then
            DeliveryView.SetFocusedRowCellValue(col_cost, new_cost)
        End If

        Try
            conn.Open()
            Dim cmd = New MySqlCommand("UPDATE ims_inventory SET discount=@discount, cost=@cost, base_price=@base_price, regular_price=@regPrice, dealer_price=@dealer_price, vip_price=@vipPrice WHERE pid=@pid", conn)
            cmd.Parameters.AddWithValue("@pid", pid)

            If Not discount = 0 Then
                cmd.Parameters.AddWithValue("@discount", discount)
                cmd.Parameters.AddWithValue("@cost", new_cost)
            Else
                cmd.Parameters.AddWithValue("@discount", Nothing)
                cmd.Parameters.AddWithValue("@cost", cost)
            End If

            cmd.Parameters.AddWithValue("@base_price", base_price)
            cmd.Parameters.AddWithValue("@dealer_price", DeliveryView.GetFocusedRowCellValue(col_dealer_price))
            cmd.Parameters.AddWithValue("@regPrice", DeliveryView.GetFocusedRowCellValue(col_regular_price))
            cmd.Parameters.AddWithValue("@vipPrice", DeliveryView.GetFocusedRowCellValue(col_vip_price))
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    Private Sub DeliveryView_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles DeliveryView.RowUpdated



        'Dim ans = MsgBox("Saved new value?", vbQuestion + vbYesNo, "Save?")
        'If ans = vbYes Then



        'End If
    End Sub

End Class