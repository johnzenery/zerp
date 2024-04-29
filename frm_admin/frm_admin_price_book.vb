Imports DevExpress.XtraGrid.Views.Grid
Imports MySqlConnector

Public Class frm_admin_price_book


    '--- ON LOAD ---
    Private Sub frm_price_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadPriceBooks()
    End Sub




    '--- FUNCTIONS ----

    'Load Price Books
    Private Sub LoadPriceBooks()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim matrix_regular = "(IFNULL(
                                        IF(ims_price_matrix.regular_discount = 'NET', net_regular, regular_price - ((regular_discount / 100) * regular_price)), 
                                        regular_price
                                        )
                                  )"
                Dim matrix_dealer = "(IFNULL(
                                        IF(ims_price_matrix.dealer_discount = 'NET', dealer_price, regular_price - ((dealer_discount / 100) * regular_price)), 
                                        dealer_price
                                        )
                                  )"    'IF(net_dealer = 0.000, dealer_price, net_dealer)
                Dim matrix_vip = "(IFNULL(
                                        IF(ims_price_matrix.vip_discount = 'NET', vip_price, regular_price - ((vip_discount / 100) * regular_price)), 
                                       vip_price
                                        )
                                  )"    'IF(net_vip = 0.000, vip_price, net_vip)

                Dim cmd = New MySqlCommand("SELECT pid, winmodel, description, main_category, sub_category, brand, status,
                                base_price, discount, cost, regular_price, net_regular, dealer_price AS net_dealer, vip_price AS net_vip,
                                ((regular_price - cost) / regular_price) srp_margin, ((net_regular - cost) / net_regular) regular_margin,
                                ((dealer_price - cost) / dealer_price) dealer_margin, ((vip_price - cost) / vip_price) vip_margin,
                                " & matrix_regular & " AS matrix_regular, " & matrix_dealer & " AS matrix_dealer, " & matrix_vip & " AS matrix_vip,
                                ((" & matrix_regular & " - cost) / " & matrix_regular & ") AS matrix_regular_margin,
                                ((" & matrix_dealer & " - cost) / " & matrix_dealer & ") AS matrix_dealer_margin,
                                ((" & matrix_vip & " - cost) / " & matrix_vip & ") AS matrix_vip_margin
                                FROM ims_inventory
                                LEFT JOIN ims_price_matrix ON ims_price_matrix.combination_name=CONCAT(brand, ' ', sub_category)", connection)
                'cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)
                grid_pricebooks.DataSource = dt

                'HIDE MARGIN COLUMNS
                col_srp_margin.Visible = False
                col_net_price_margin.Visible = False
                col_net_dealer_margin.Visible = False
                col_net_vip_margin.Visible = False
                col_matrix_regular_margin.Visible = False
                col_matrix_dealer_margin.Visible = False
                col_matrix_vip_margin.Visible = False

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
    Function GetTotalDiscount() As Decimal
        Dim total_disc As Decimal = 1.0

        Try
            Dim disc_val = IIf(IsDBNull(grid_pricebooks_view.GetFocusedRowCellValue(col_discount)), "", grid_pricebooks_view.GetFocusedRowCellValue(col_discount))
            Dim disc As String = IIf(IsDBNull(disc_val) Or String.IsNullOrEmpty(disc_val), "0", disc_val)

            If Not IsDBNull(disc) Then
                For Each d As Decimal In disc.Split("/"c)
                    total_disc *= 1 - (d / 100)
                Next
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Return 1 - total_disc

    End Function



    '--- CONTROLS 

    Private Sub grid_pricebooks_view_RowStyle(sender As Object, e As RowStyleEventArgs) Handles grid_pricebooks_view.RowStyle
        Try
            Dim status As Object = grid_pricebooks_view.GetRowCellValue(e.RowHandle, "status")
            If status IsNot Nothing AndAlso Not IsDBNull(status) AndAlso status.Equals("Discontinued") Then
                e.Appearance.BackColor = Color.IndianRed
                e.Appearance.ForeColor = Color.White
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbExclamation, "Error")
        End Try
    End Sub


    Private Sub grid_pricebooks_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_pricebooks_view.CellValueChanged

        'Dim discount As Integer = 0
        'If Not IsDBNull(grid_pricebooks_view.GetFocusedRowCellValue(col_discount)) Then
        '    discount = grid_pricebooks_view.GetFocusedRowCellValue(col_discount)
        'End If

        Dim new_cost As Decimal
        Dim pid As Integer = grid_pricebooks_view.GetFocusedRowCellValue(col_pid)
        Dim base_price As Decimal = grid_pricebooks_view.GetFocusedRowCellValue(col_base_price)
        Dim cost As Decimal = grid_pricebooks_view.GetFocusedRowCellValue(col_cost)
        Dim disc_val = IIf(IsDBNull(grid_pricebooks_view.GetFocusedRowCellValue(col_discount)), "", grid_pricebooks_view.GetFocusedRowCellValue(col_discount))

        If Not Equals(disc_val, "NET") Then
            Dim discount As Decimal = GetTotalDiscount()
            new_cost = base_price - (base_price * discount)

            If e.Column.Equals(col_discount) Or e.Column.Equals(col_base_price) Then
                grid_pricebooks_view.SetFocusedRowCellValue(col_cost, new_cost)
                'grid_pricebooks_view.SetFocusedRowCellValue(col_discount, IIf(String.IsNullOrEmpty(disc_val), 0, disc_val))
            End If

        Else
            new_cost = grid_pricebooks_view.GetFocusedRowCellValue(col_cost)
        End If

        'COLUMN : SRP
        If e.Column.Equals(col_srp) Then
            Dim srp_price As Decimal = grid_pricebooks_view.GetFocusedRowCellValue(col_srp)
            grid_pricebooks_view.SetFocusedRowCellValue(col_srp_margin, (srp_price - cost) / srp_price)
        End If

        'COLUMN : REGULAR
        If e.Column.Equals(col_net_price) Then
            Dim net_price As Decimal = grid_pricebooks_view.GetFocusedRowCellValue(col_net_price)
            grid_pricebooks_view.SetFocusedRowCellValue(col_net_price_margin, (net_price - cost) / net_price)
        End If

        'COLUMN : DEALER
        If e.Column.Equals(col_net_dealer) Then
            Dim net_dealer As Decimal = grid_pricebooks_view.GetFocusedRowCellValue(col_net_dealer)
            grid_pricebooks_view.SetFocusedRowCellValue(col_net_dealer_margin, (net_dealer - cost) / net_dealer)
        End If

        'COLUMN : VIP
        If e.Column.Equals(col_net_vip) Then
            Dim net_vip As Decimal = grid_pricebooks_view.GetFocusedRowCellValue(col_net_vip)
            grid_pricebooks_view.SetFocusedRowCellValue(col_net_vip_margin, (net_vip - cost) / net_vip)
        End If

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("UPDATE ims_inventory 
                                SET discount=@discount, cost=@cost, base_price=@base_price, regular_price=@srp, 
                                net_regular=@net_regular, dealer_price=@dealer_price, vip_price=@vipPrice WHERE pid=@pid", connection)
                cmd.Parameters.AddWithValue("@pid", pid)


                If Not String.IsNullOrEmpty(disc_val) Then
                    cmd.Parameters.AddWithValue("@discount", disc_val)
                    cmd.Parameters.AddWithValue("@cost", new_cost)

                Else
                    cmd.Parameters.AddWithValue("@discount", "0")
                    cmd.Parameters.AddWithValue("@cost", cost)
                End If

                cmd.Parameters.AddWithValue("@base_price", base_price)
                cmd.Parameters.AddWithValue("@srp", grid_pricebooks_view.GetFocusedRowCellValue(col_srp))
                cmd.Parameters.AddWithValue("@net_regular", grid_pricebooks_view.GetFocusedRowCellValue(col_net_price))
                cmd.Parameters.AddWithValue("@dealer_price", grid_pricebooks_view.GetFocusedRowCellValue(col_net_dealer))
                cmd.Parameters.AddWithValue("@vipPrice", grid_pricebooks_view.GetFocusedRowCellValue(col_net_vip))
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btn_find_Click(sender As Object, e As EventArgs) Handles btn_find.Click
        If grid_pricebooks_view.ActiveFilter.IsEmpty Then
            btn_find.Text = "Close"
            btn_find.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
            grid_pricebooks_view.ActiveFilterString = "[regular_price] < [cost] OR [net_dealer] < [cost] OR [net_vip] < [cost] OR [matrix_regular] < [cost] OR [matrix_dealer] < [cost] OR [matrix_vip] < [cost]"
        Else
            btn_find.Text = "Find Below Cost"
            btn_find.Appearance.BackColor = Nothing
            grid_pricebooks_view.ActiveFilterString = ""
        End If
    End Sub

    'BUTTON : EXPORT
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Using sfd = New SaveFileDialog
            sfd.Filter = "Excel files (*.xlsx)|*.xlsx"
            sfd.FilterIndex = 2
            sfd.RestoreDirectory = True

            If sfd.ShowDialog() = DialogResult.OK Then
                grid_pricebooks_view.ExportToXlsx(sfd.FileName)
                Log_Export("Exported Price Books", frm_main.lbl_user_id.Text)
            End If
        End Using

    End Sub

    'BUTTON : SHOW / HIDE MARGIN COLUMNS
    Private Sub btn_show_margin_CheckedChanged(sender As Object, e As EventArgs) Handles btn_show_margin.CheckedChanged
        If btn_show_margin.Checked = True Then
            col_srp_margin.Visible = True
            col_net_price_margin.Visible = True
            col_net_dealer_margin.Visible = True
            col_net_vip_margin.Visible = True
            col_matrix_regular_margin.Visible = True
            col_matrix_dealer_margin.Visible = True
            col_matrix_vip_margin.Visible = True

            col_srp.VisibleIndex = 9
            col_srp_margin.VisibleIndex = 10
            col_net_price.VisibleIndex = 11
            col_net_price_margin.VisibleIndex = 12
            col_net_dealer.VisibleIndex = 13
            col_net_dealer_margin.VisibleIndex = 14
            col_net_vip.VisibleIndex = 15
            col_net_vip_margin.VisibleIndex = 16
            col_matrix_regular.VisibleIndex = 17
            col_matrix_regular_margin.VisibleIndex = 18
            col_matrix_dealer.VisibleIndex = 19
            col_matrix_dealer_margin.VisibleIndex = 20
            col_matrix_vip.VisibleIndex = 21
            col_matrix_vip_margin.VisibleIndex = 22

            btn_show_margin.Text = "Hide Margins"
        ElseIf btn_show_margin.Checked = False Then
            col_srp_margin.Visible = False
            col_net_price_margin.Visible = False
            col_net_dealer_margin.Visible = False
            col_net_vip_margin.Visible = False
            col_matrix_regular_margin.Visible = False
            col_matrix_dealer_margin.Visible = False
            col_matrix_vip_margin.Visible = False
            btn_show_margin.Text = "Show Margins"
        End If
    End Sub

End Class