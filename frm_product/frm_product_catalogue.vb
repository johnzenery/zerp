Imports DevExpress.Utils.Extensions
Imports DevExpress.XtraGrid
Imports MySqlConnector
Imports Renci.SshNet
Imports System.IO
Imports System.Threading

Public Class frm_product_catalogue

    Dim side_panel As New control_inventory_side
    Dim countdown_time As Integer


    '--- On LOAD ----
    Private Sub frm_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Shown
    Private Sub frm_inventory_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'panel_side.Hide()
        Init()
    End Sub




    '--- FUNCTIONS ----

    'Initializes Data
    Private Sub Init()
        grid_catalogue_view.ShowLoadingPanel()
        bgw_load_catalogue.RunWorkerAsync(frm_main.lbl_user_designation.Text)
    End Sub

    'bgw_load.DoWork 
    Private Sub bgw_load_catalogue_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw_load_catalogue.DoWork
        LoadInventory(e.Argument.ToString)
    End Sub

    'bgw_load.RunWorkerCompleted
    Private Sub bgw_load_catalogue_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgw_load_catalogue.RunWorkerCompleted
        grid_catalogue_view.HideLoadingPanel()
        setPriceBooks()
        col_my_qty.Visible = False
        col_onhold_qty.Visible = False
        col_other_qty.Visible = False
    End Sub

    'Load Inventory
    Private Sub LoadInventory(store_name As String)

        Dim STORE = "ims_" & store_name.ToLower.Replace(" ", "_")
        Dim tables As String() = get_all_store_tables(STORE).ToString().Split(New Char() {","c})
        Dim query As String = String.Empty, left_join As String = String.Empty

        For i = 0 To tables.Length - 2
            query += "IFNULL(" & tables(i) & ".qty, 0)"
            left_join += "LEFT JOIN " & tables(i) & " ON ims_inventory.pid=" & tables(i) & ".pid "
            If Not i = tables.Length - 2 Then
                query += " + "
            End If
        Next


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


        Dim cmd_str As String = "SELECT ims_inventory.pid, barcode,
                    winmodel, description, technical_description, tags,
                    base_price, cost, discount, regular_price,
                    " & matrix_regular & " AS matrix_regular_price, " & matrix_dealer & " AS matrix_dealer_price, " & matrix_vip & " AS matrix_vip_price,
                    main_category, sub_category, brand, tags, hazards,
                    length, width, height, weight,
                    serialized, warranty_period, warranty_coverage,
                    status, IFNULL(" & STORE & ".qty,0) as qty, IFNULL(" & STORE & ".on_hold,0) as onhold, (" & query & ") as other_qty 
                    FROM `ims_inventory` 
                    LEFT JOIN " & STORE & " ON ims_inventory.pid=" & STORE & ".pid " & left_join & "
                    LEFT JOIN ims_price_matrix ON ims_price_matrix.combination_name=CONCAT(brand, ' ', sub_category)
                    WHERE NOT status = 'For Approval'" 'regular_price, dealer_price, vip_price,

        Try

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand(cmd_str, connection)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_catalogue.Invoke(Sub()
                                          grid_catalogue.DataSource = dt
                                      End Sub)

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Get All Tables
    Private Function get_all_store_tables(MyStore As String) As Object
        Dim table As String = String.Empty
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using mySqlDataReader = New MySqlCommand("SELECT store_name FROM ims_stores", connection).ExecuteReader()
                    While mySqlDataReader.Read()
                        Dim str As String = String.Concat("ims_", mySqlDataReader("store_name").ToString().ToLower().Replace(" ", "_"))
                        'table = String.Concat(table, str, ",")
                        If Not str.Equals(MyStore) Then
                            table = String.Concat(table, str, ",")
                        End If
                    End While
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try

        Return table

    End Function

    'Set View for Dealer and VIP Price Books
    Private Sub setPriceBooks()
        Dim id As Integer = frm_main.lbl_user_role_id.Text

        If id = 1 Or id = 3 Or id = 6 Or id = 10 Then
            col_dealer_price.Visible = True
            col_vip_price.Visible = True
        End If

        If id = 7 Then
            col_dealer_price.Visible = True
        End If

    End Sub

    'Set Photo from server
    Private Sub setImage(FileName As String)

        Try

            Using client As New SftpClient(ftp_server, ftp_username, ftp_password)


                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_productFolder & "/" & FileName & ".jpg", ms)

                If Not ms.Length = 0 Then
                    pb_product.Invoke(Sub()
                                          pb_product.Image = Image.FromStream(ms)
                                      End Sub)
                Else
                    pb_product.Invoke(Sub()
                                          pb_product.Image = Nothing
                                      End Sub)
                End If
            End Using

        Catch ex As Exception
            'MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub





    '--- CONTROLS ----

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_catalogue.ShowPrintPreview()
    End Sub

    'View Details
    Private Sub ims_InventoryView_FocusedRowObjectChanged(sender As Object, e As Views.Base.FocusedRowObjectChangedEventArgs) Handles grid_catalogue_view.FocusedRowObjectChanged
        If SidePanel1.Visible = True Then
            If Not String.IsNullOrEmpty(grid_catalogue_view.GetRowCellValue(grid_catalogue_view.FocusedRowHandle, "pid")) Then

                If grid_catalogue_view.RowCount > 0 Then

                    With grid_catalogue_view
                        lbl_pid.Text = .GetFocusedRowCellValue("pid")
                        txt_status.Text = .GetFocusedRowCellValue("status")
                        If Not IsDBNull(.GetFocusedRowCellValue("barcode")) Then txt_barcode.Text = .GetFocusedRowCellValue("barcode") Else txt_barcode.Text = String.Empty
                        txt_winmodel.Text = .GetFocusedRowCellValue("winmodel")
                        txt_description.Text = .GetFocusedRowCellValue("description")
                        txt_retail_price.Text = .GetFocusedRowCellValue("regular_price")

                        txt_main_category.Text = .GetFocusedRowCellValue("main_category")
                        txt_sub_category.Text = .GetFocusedRowCellValue("sub_category")
                        txt_brand.Text = .GetFocusedRowCellValue("brand")

                        If Not IsDBNull(.GetFocusedRowCellValue("tags")) Then txt_tags.Text = .GetFocusedRowCellValue("tags") Else txt_tags.Text = String.Empty
                        If Not IsDBNull(.GetFocusedRowCellValue("hazards")) Then txt_hazards.Text = .GetFocusedRowCellValue("hazards") Else txt_hazards.Text = String.Empty

                        If Not IsDBNull(.GetFocusedRowCellValue("length")) Then txt_length.Text = .GetFocusedRowCellValue("length") Else txt_length.Text = String.Empty
                        If Not IsDBNull(.GetFocusedRowCellValue("width")) Then txt_width.Text = .GetFocusedRowCellValue("width") Else txt_width.Text = String.Empty
                        If Not IsDBNull(.GetFocusedRowCellValue("height")) Then txt_height.Text = .GetFocusedRowCellValue("height") Else txt_height.Text = String.Empty
                        If Not IsDBNull(.GetFocusedRowCellValue("weight")) Then txt_weight.Text = .GetFocusedRowCellValue("weight") Else txt_weight.Text = String.Empty
                        If Not IsDBNull(.GetFocusedRowCellValue("warranty_period")) Then txt_warranty.Text = .GetFocusedRowCellValue("warranty_period") & " Months - " & .GetFocusedRowCellValue("warranty_coverage") Else txt_warranty.Text = String.Empty

                        'Set Image to Picture Box
                        pb_product.Image = Nothing

                        countdown_timer.Stop()
                        countdown_time = 1
                        countdown_timer.Start()
                        'setImage(grid_catalogue_view.GetFocusedRowCellValue(col_pid).ToString)

                        'Dim thread = New Threading.Thread(Sub()

                        '                                  End Sub)
                        'thread.Start()

                    End With



                End If
            End If
        End If

    End Sub

    'btn_details # Show Details Panel
    Private Sub btn_details_Click(sender As Object, e As EventArgs) Handles btn_details.Click

        If SidePanel1.Visible = False Then
            SidePanel1.Show()
        Else
            SidePanel1.Hide()
        End If
    End Sub

    'View More Details
    Private Sub lbl_view_more_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lbl_view_more.LinkClicked
        Dim more_description As String = grid_catalogue_view.GetFocusedRowCellValue("technical_description")
        Dim frmProductDetail As New frm_product_details()
        frmProductDetail.lbl_more_details.Text = more_description
        'frmProductDetail.txt_details.Text = more_description
        frmProductDetail.Show()
        'frmProductDetail.txt_details.DeselectAll()
    End Sub

    'View Stocks
    Private Sub sw_view_stocks_Toggled(sender As Object, e As EventArgs) Handles sw_view_stocks.Toggled
        If sw_view_stocks.EditValue = True Then
            col_my_qty.Visible = True
            col_onhold_qty.Visible = True
            col_other_qty.Visible = True
            col_srp_price.VisibleIndex = 8
            col_regular_price.VisibleIndex = 9
            col_dealer_price.VisibleIndex = 10
            col_vip_price.VisibleIndex = 11
            col_my_qty.VisibleIndex = 12
            col_onhold_qty.VisibleIndex = 13
            col_other_qty.VisibleIndex = 14
        ElseIf sw_view_stocks.EditValue = False Then
            col_my_qty.Visible = False
            col_onhold_qty.Visible = False
            col_other_qty.Visible = False
        End If
    End Sub

    Private Sub link_view_image_Click(sender As Object, e As EventArgs) Handles link_view_image.Click
        'setImage(grid_catalogue_view.GetFocusedRowCellValue(col_pid))
    End Sub

    Private Sub countdown_timer_Tick(sender As Object, e As EventArgs) Handles countdown_timer.Tick
        countdown_time -= 1
        If countdown_time = 0 Then
            setImage(grid_catalogue_view.GetFocusedRowCellValue(col_pid).ToString)
            countdown_timer.Stop()
        End If
    End Sub
End Class

