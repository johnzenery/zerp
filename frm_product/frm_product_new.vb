Imports DevExpress.XtraEditors.Controls
Imports MySqlConnector
Imports Renci.SshNet
Imports Renci.SshNet.Sftp
Imports System.Globalization
Imports System.IO

Public Class frm_product_new

    Private Property old_pid As String
    Private Property old_model As String
    Private Property old_description As String
    Private Property src As String

    'Onload
    Private Sub frm_addunit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComponents()
    End Sub




    'Controls

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If Not ValidateForm() Then

            Select Case txt_title.Text
                Case "New Product" : NewProduct()
                Case "Update Product" : UpdateProduct(old_pid, src)
            End Select

            If Not pb_new_unit.Image Is Nothing Then
                Dim model = txt_winmodel.Text.Trim.ToUpper
                UploadProductPhoto(model)
            End If

            Me.DialogResult = DialogResult.OK

        End If

    End Sub

    'Clear Button
    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        ClearFields()
    End Sub





    'Functions

    'Intialize COmponents
    Private Sub LoadComponents()
        Load_Main_Categories()
        Load_Sub_Categories()
        Load_Brands()
        Load_Supplier()
    End Sub

    'Set Main Category (AUTOFILL)
    Private Sub Load_Main_Categories()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT main_category FROM `ims_inventory` GROUP BY main_category", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_maincategory.Properties.Items
                Coll.BeginUpdate()
                Try
                    While rdr.Read
                        Coll.Add(rdr("main_category"))
                    End While
                    rdr.Close()
                Finally
                    Coll.EndUpdate()
                End Try
                cbb_maincategory.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Sub Category (AUTOFILL)
    Private Sub Load_Sub_Categories()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT sub_category FROM `ims_inventory` GROUP BY sub_category", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_subcategory.Properties.Items
                Coll.BeginUpdate()
                Try
                    While rdr.Read
                        Coll.Add(rdr("sub_category"))
                    End While
                    rdr.Close()
                Finally
                    Coll.EndUpdate()
                End Try
                cbb_subcategory.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Brand (AUTOFILL)
    Private Sub Load_Brands()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT brand FROM `ims_inventory` GROUP BY brand", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_brand.Properties.Items
                Coll.BeginUpdate()
                Try
                    While rdr.Read
                        Coll.Add(rdr("brand"))
                    End While
                    rdr.Close()
                Finally
                    Coll.EndUpdate()
                End Try
                cbb_brand.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Set Supplier (AUTOFILL)
    Private Sub Load_Supplier()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("SELECT supplier FROM `ims_suppliers`", connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                Dim Coll As ComboBoxItemCollection = cbb_supplier.Properties.Items
                Coll.BeginUpdate()
                Try
                    While rdr.Read
                        Coll.Add(rdr("supplier"))
                    End While
                    rdr.Close()
                Finally
                    Coll.EndUpdate()
                End Try
                cbb_supplier.SelectedIndex = -1
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Validate Form
    Private Function ValidateForm()
        Dim Err = False

        'Product ID (SKU)
        If String.IsNullOrEmpty(txt_pid.Text) Then
            ErrorNotif.SetError(txt_pid, "Must have Winland Model.")
            Err = True
        End If

        'Winland Model
        If String.IsNullOrEmpty(txt_winmodel.Text) Then
            ErrorNotif.SetError(txt_winmodel, "Must have Winland Model.")
            Err = True
        End If

        'Supplier Model
        If String.IsNullOrEmpty(txt_supmodel.Text) Then
            ErrorNotif.SetError(txt_supmodel, "Must have Supplier Model.")
            Err = True
        End If

        'Supplier ComboBox
        If String.IsNullOrEmpty(cbb_supplier.Text) Then
            ErrorNotif.SetError(cbb_supplier, "Must have Supplier.")
            Err = True
        End If

        'Description
        If String.IsNullOrEmpty(txt_description.Text) Then
            ErrorNotif.SetError(txt_description, "Must have description")
            Err = True
        End If

        'Main Category ComboBox
        If String.IsNullOrEmpty(cbb_maincategory.Text) Then
            ErrorNotif.SetError(cbb_maincategory, "Must have Main Category.")
            Err = True
        End If

        'Sub Category ComboBox
        If String.IsNullOrEmpty(cbb_subcategory.Text) Then
            ErrorNotif.SetError(cbb_subcategory, "Must have Sub Category.")
            Err = True
        End If

        'Brand ComboBox
        If String.IsNullOrEmpty(cbb_brand.Text) Then
            ErrorNotif.SetError(cbb_brand, "Must have Brand.")
            Err = True
        End If

        'Base Price
        If String.IsNullOrEmpty(txt_baseprice.Text) Then
            ErrorNotif.SetError(txt_baseprice, "Must have Base Price.")
            Err = True
        End If

        'SRP
        If String.IsNullOrEmpty(txt_srp.Text) Then
            ErrorNotif.SetError(txt_srp, "Must have Price (SRP).")
            Err = True
        End If

        'Length
        'If String.IsNullOrEmpty(txt_length.Text) Then
        '    ErrorNotif.SetError(txt_length, "Must have Length.")
        '    Err = True
        'End If

        'Width
        'If String.IsNullOrEmpty(txt_width.Text) Then
        '    ErrorNotif.SetError(txt_width, "Must have Width.")
        '    Err = True
        'End If

        'Height
        'If String.IsNullOrEmpty(txt_height.Text) Then
        '    ErrorNotif.SetError(txt_height, "Must have Height.")
        '    Err = True
        'End If

        'Weight
        'If String.IsNullOrEmpty(txt_weight.Text) Then
        '    ErrorNotif.SetError(txt_weight, "Must have Weight.")
        '    Err = True
        'End If

        'Ideal Stock
        'If String.IsNullOrEmpty(txt_ideal_stock.Text) Then
        '    ErrorNotif.SetError(txt_ideal_stock, "Must have value.")
        '    Err = True
        'End If

        'Warning Stock
        'If String.IsNullOrEmpty(txt_warning_stock.Text) Then
        '    ErrorNotif.SetError(txt_warning_stock, "Must have value.")
        '    Err = True
        'End If

        'Warranty Period
        'If String.IsNullOrEmpty(txt_warranty_period.Text) Then
        '    ErrorNotif.SetError(txt_warranty_period, "Must have value.")
        '    Err = True
        'End If


        Return Err

    End Function

    'Clear Fields
    Private Sub ClearFields()
        txt_winmodel.ResetText()
        txt_supmodel.ResetText()
        cbb_supplier.ResetText()
        txt_description.ResetText()
        txt_cautions.ResetText()
        cbb_maincategory.ResetText()
        cbb_subcategory.ResetText()
        cbb_brand.ResetText()
        txt_tags.ResetText()
        txt_barcode.ResetText()
        switch_serialize.Checked = False
        txt_baseprice.Text = 0.00
        txt_discount.Text = 0
        txt_cost.Text = 0.00
        txt_srp.Text = 0.00
        txt_length.ResetText()
        txt_width.ResetText()
        txt_height.ResetText()
        txt_weight.ResetText()
        txt_stock_duration.ResetText()
    End Sub

    'Add New Product
    Private Async Sub NewProduct()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim duplicate = New MySqlCommand("SELECT COUNT(*) FROM `ims_inventory` WHERE winmodel=@model or description=@description or pid=@pid", connection)
                duplicate.Parameters.AddWithValue("@pid", txt_pid.Text.Trim)
                duplicate.Parameters.AddWithValue("@model", txt_winmodel.Text.Trim)
                duplicate.Parameters.AddWithValue("@description", txt_description.Text.Trim)
                Dim rdr_duplicate As MySqlDataReader = duplicate.ExecuteReader

                rdr_duplicate.Read()
                If rdr_duplicate("COUNT(*)") >= 1 Then
                    MsgBox("This model has duplicate in the system.", vbCritical, "Error")
                    Exit Sub
                End If
                rdr_duplicate.Close()


                Dim date_entry = String.Empty

                If cbb_status.Text.Equals("Active") Then
                    date_entry = Date.Today.ToString("MM-dd-yyyy")
                End If

                Dim cmd = New MySqlCommand("INSERT INTO ims_inventory (pid, winmodel, supmodel, supplier, description, technical_description, hazards, main_category, sub_category, brand, tags, barcode, serialized, base_price, discount, cost, regular_price, dealer_price, vip_price, length, width, height, weight, qty_per_box, ideal_stock, warning_stock, stock_duration, status, warranty_period, warranty_coverage, date_entry)
                                        VALUES (@pid, @winmodel, @supmodel, (SELECT id FROM ims_suppliers WHERE supplier=@supplier), @description, @technical_description, @hazards, @main_category, @sub_category, @brand, @tags, @barcode, @serialized, @base_price, @discount, @cost, @regular_price, @dealer_price, @vip_price, @length, @width, @height, @weight, @qty_per_box, @ideal_stock, @warning_stock, @stock_duration, @status, @warranty_period, @warranty_coverage, @date_entry)", connection)

                With CultureInfo.CurrentCulture.TextInfo
                    cmd.Parameters.AddWithValue("@pid", txt_pid.Text.Trim)
                    cmd.Parameters.AddWithValue("@winmodel", txt_winmodel.Text.Trim)
                    cmd.Parameters.AddWithValue("@supmodel", txt_supmodel.Text.Trim)
                    cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text.Trim)
                    cmd.Parameters.AddWithValue("@description", .ToTitleCase(txt_description.Text.Trim))
                    cmd.Parameters.AddWithValue("@technical_description", txt_more_description.Text.Trim())
                    cmd.Parameters.AddWithValue("@hazards", .ToTitleCase(txt_cautions.Text.Trim))
                    cmd.Parameters.AddWithValue("@main_category", .ToTitleCase(cbb_maincategory.Text.Trim))
                    cmd.Parameters.AddWithValue("@sub_category", .ToTitleCase(cbb_subcategory.Text.Trim))
                    cmd.Parameters.AddWithValue("@brand", .ToTitleCase(cbb_brand.Text.Trim))
                    cmd.Parameters.AddWithValue("@tags", .ToTitleCase(txt_tags.Text.Trim))
                    cmd.Parameters.AddWithValue("@barcode", txt_barcode.Text.Trim)
                    cmd.Parameters.AddWithValue("@serialized", switch_serialize.Checked)
                    cmd.Parameters.AddWithValue("@base_price", txt_baseprice.Text.Trim)
                    cmd.Parameters.AddWithValue("@discount", If(String.IsNullOrWhiteSpace(txt_discount.Text.Trim), Nothing, txt_discount.Text))
                    cmd.Parameters.AddWithValue("@cost", txt_cost.Text.Trim)
                    cmd.Parameters.AddWithValue("@regular_price", txt_srp.Text.Trim)
                    cmd.Parameters.AddWithValue("@dealer_price", txt_dealer_price.Text.Trim)
                    cmd.Parameters.AddWithValue("@vip_price", txt_vip_price.Text.Trim)
                    If Not String.IsNullOrEmpty(txt_length.Text) Then cmd.Parameters.AddWithValue("@length", txt_length.Text.Trim) Else cmd.Parameters.AddWithValue("@length", Nothing)
                    If Not String.IsNullOrEmpty(txt_width.Text) Then cmd.Parameters.AddWithValue("@width", txt_width.Text.Trim) Else cmd.Parameters.AddWithValue("@width", Nothing)
                    If Not String.IsNullOrEmpty(txt_height.Text) Then cmd.Parameters.AddWithValue("@height", txt_height.Text.Trim) Else cmd.Parameters.AddWithValue("@height", Nothing)
                    If Not String.IsNullOrEmpty(txt_weight.Text) Then cmd.Parameters.AddWithValue("@weight", txt_weight.Text.Trim) Else cmd.Parameters.AddWithValue("@weight", Nothing)
                    If Not String.IsNullOrEmpty(txt_qty_per_box.Text) Then cmd.Parameters.AddWithValue("@qty_per_box", txt_qty_per_box.Text.Trim) Else cmd.Parameters.AddWithValue("@qty_per_box", Nothing)
                    If Not String.IsNullOrEmpty(txt_ideal_stock.Text) Then cmd.Parameters.AddWithValue("@ideal_stock", txt_ideal_stock.Text.Trim) Else cmd.Parameters.AddWithValue("@ideal_stock", Nothing)
                    If Not String.IsNullOrEmpty(txt_warning_stock.Text) Then cmd.Parameters.AddWithValue("@warning_stock", txt_warning_stock.Text.Trim) Else cmd.Parameters.AddWithValue("@warning_stock", Nothing)
                    If Not String.IsNullOrEmpty(txt_stock_duration.Text) Then cmd.Parameters.AddWithValue("@stock_duration", txt_stock_duration.Text.Trim) Else cmd.Parameters.AddWithValue("@stock_duration", Nothing)
                    cmd.Parameters.AddWithValue("@status", cbb_status.Text.Trim)
                    If Not String.IsNullOrEmpty(txt_warranty_period.Text) Then cmd.Parameters.AddWithValue("@warranty_period", txt_warranty_period.Text.Trim) Else cmd.Parameters.AddWithValue("@warranty_period", Nothing)
                    cmd.Parameters.AddWithValue("@warranty_coverage", txt_warranty_coverage.Text.Trim)
                    cmd.Parameters.AddWithValue("@date_entry", date_entry)
                End With

                Dim inserted = cmd.ExecuteNonQuery

                If inserted >= 1 Then
                    MsgBox("Successfully Added!", vbInformation + vbOKOnly, "Information")
                End If

            End Using

            'ClearFields()
            Await frm_main.LoadFrm(New frm_product_new, "frm_product_new")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Update Product
    Private Async Sub UpdateProduct(pid As String, src As String)
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                If Not txt_pid.Text.Equals(old_pid) Then
                    If check_duplicate(connection, "pid") Then
                        MsgBox("Duplicate Product ID Found!", vbCritical, "Duplicate Entry")
                        Exit Sub
                    End If
                End If

                If Not txt_winmodel.Text.Equals(old_model) Then
                    If check_duplicate(connection, "winmodel") Then
                        MsgBox("Duplicate Model Found!", vbCritical, "Duplicate Entry")
                        Exit Sub
                    End If
                End If

                If Not txt_description.Text.Equals(old_description) Then
                    If check_duplicate(connection, "description") Then
                        MsgBox("Duplicate Description Found!", vbCritical, "Duplicate Entry")
                        Exit Sub
                    End If
                End If



                Dim cmd = New MySqlCommand("UPDATE ims_inventory SET pid=@pid, winmodel=@winmodel, supmodel=@supmodel, supplier=(SELECT id FROM ims_suppliers WHERE supplier=@supplier), description=@description, technical_description=@technical_description,
                                hazards=@hazards, main_category=@main_category, sub_category=@sub_category, brand=@brand, tags=@tags, 
                                barcode=@barcode, serialized=@serialized, base_price=@base_price, discount=@discount, cost=@cost, regular_price=@regular_price, 
                                length=@length, width=@width, height=@height, weight=@weight, qty_per_box=@qty_per_box, ideal_stock=@ideal_stock, warning_stock=@warning_stock,
                                stock_duration=@stock_duration, status=@status, warranty_period=@warranty_period, warranty_coverage=@warranty_coverage WHERE pid=" & pid, connection)

                With CultureInfo.CurrentCulture.TextInfo
                    cmd.Parameters.AddWithValue("@pid", txt_pid.Text.Trim)
                    cmd.Parameters.AddWithValue("@winmodel", txt_winmodel.Text.Trim)
                    cmd.Parameters.AddWithValue("@supmodel", txt_supmodel.Text.Trim)
                    cmd.Parameters.AddWithValue("@supplier", cbb_supplier.Text.Trim)
                    cmd.Parameters.AddWithValue("@description", .ToTitleCase(txt_description.Text.Trim))
                    cmd.Parameters.AddWithValue("@technical_description", txt_more_description.Text.Trim())
                    cmd.Parameters.AddWithValue("@hazards", .ToTitleCase(txt_cautions.Text.Trim))
                    cmd.Parameters.AddWithValue("@main_category", .ToTitleCase(cbb_maincategory.Text.Trim))
                    cmd.Parameters.AddWithValue("@sub_category", .ToTitleCase(cbb_subcategory.Text.Trim))
                    cmd.Parameters.AddWithValue("@brand", .ToTitleCase(cbb_brand.Text.Trim))
                    cmd.Parameters.AddWithValue("@tags", .ToTitleCase(txt_tags.Text.Trim))
                    cmd.Parameters.AddWithValue("@barcode", txt_barcode.Text.Trim)
                    cmd.Parameters.AddWithValue("@serialized", switch_serialize.Checked)
                    cmd.Parameters.AddWithValue("@base_price", txt_baseprice.Text.Trim)
                    cmd.Parameters.AddWithValue("@discount", If(String.IsNullOrWhiteSpace(txt_discount.Text.Trim), Nothing, txt_discount.Text))
                    cmd.Parameters.AddWithValue("@cost", txt_cost.Text.Trim)
                    cmd.Parameters.AddWithValue("@regular_price", txt_srp.Text.Trim)
                    cmd.Parameters.AddWithValue("@length", If(String.IsNullOrWhiteSpace(txt_length.Text.Trim), Nothing, txt_length.Text))
                    cmd.Parameters.AddWithValue("@width", If(String.IsNullOrWhiteSpace(txt_width.Text.Trim), Nothing, txt_width.Text))
                    cmd.Parameters.AddWithValue("@height", If(String.IsNullOrWhiteSpace(txt_height.Text.Trim), Nothing, txt_height.Text))
                    cmd.Parameters.AddWithValue("@weight", If(String.IsNullOrWhiteSpace(txt_weight.Text.Trim), Nothing, txt_weight.Text))
                    cmd.Parameters.AddWithValue("@qty_per_box", If(String.IsNullOrWhiteSpace(txt_ideal_stock.Text.Trim), Nothing, txt_ideal_stock.Text))
                    cmd.Parameters.AddWithValue("@ideal_stock", If(String.IsNullOrWhiteSpace(txt_ideal_stock.Text.Trim), Nothing, txt_ideal_stock.Text))
                    cmd.Parameters.AddWithValue("@warning_stock", If(String.IsNullOrWhiteSpace(txt_warning_stock.Text.Trim), Nothing, txt_warning_stock.Text))
                    cmd.Parameters.AddWithValue("@stock_duration", If(String.IsNullOrWhiteSpace(txt_stock_duration.Text.Trim), Nothing, txt_stock_duration.Text))
                    cmd.Parameters.AddWithValue("@status", cbb_status.Text.Trim)
                    cmd.Parameters.AddWithValue("@warranty_period", If(String.IsNullOrWhiteSpace(txt_warranty_period.Text.Trim), Nothing, txt_warranty_period.Text))
                    cmd.Parameters.AddWithValue("@warranty_coverage", txt_warranty_coverage.Text.Trim)
                End With

                Dim inserted = cmd.ExecuteNonQuery

                If inserted >= 1 Then
                    MsgBox("Successfully Updated!", vbInformation + vbOKOnly, "Information")
                End If

            End Using

            Me.Close()

            Select Case src
                Case "masterlist" : Await frm_main.LoadFrm(New frm_product_catalogue, "frm_product_catalogue")
                Case "approval" : Await frm_main.LoadFrm(New frm_admin_approval, "frm_admin_approval")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Check Duplicate
    Private Function check_duplicate(connection As MySqlConnection, column As String)
        Dim result = False
        Dim query As String = String.Empty
        Dim duplicate = New MySqlCommand

        Select Case column
            Case "pid"
                query = "SELECT COUNT(*) FROM `ims_inventory` WHERE pid=@pid"
                duplicate.Parameters.AddWithValue("@pid", txt_pid.Text.Trim)
            Case "winmodel"
                query = "SELECT COUNT(*) FROM `ims_inventory` WHERE winmodel=@winmodel"
                duplicate.Parameters.AddWithValue("@winmodel", txt_winmodel.Text.Trim)
            Case "description"
                query = "SELECT COUNT(*) FROM `ims_inventory` WHERE description=@description"
                duplicate.Parameters.AddWithValue("@description", txt_description.Text.Trim)
        End Select

        duplicate.Connection = connection
        duplicate.CommandText = query

        Dim rdr_duplicate As MySqlDataReader = duplicate.ExecuteReader

        While rdr_duplicate.Read()
            If rdr_duplicate("COUNT(*)") >= 1 Then
                result = True
            End If
        End While
        rdr_duplicate.Close()

        Return result
    End Function


    'Set Update Information
    Public Sub UpdateInformation(pid As Integer, source As String)

        Try
            txt_title.Text = "Update Product"
            Me.Text = "Update Product Information"
            breadcrumb.Visible = False
            btn_clear.Visible = False


            Using connect = New MySqlConnection(str)
                connect.Open()

                Dim cmd = New MySqlCommand("SELECT * FROM ims_inventory WHERE pid=@pid", connect)
                cmd.Parameters.AddWithValue("@pid", pid)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader

                While rdr.Read
                    txt_pid.Text = pid
                    txt_barcode.Text = IIf(IsDBNull(rdr("barcode")), String.Empty, rdr("barcode"))
                    txt_winmodel.Text = rdr("winmodel")
                    txt_supmodel.Text = rdr("supmodel")
                    txt_description.Text = rdr("description")
                    cbb_maincategory.Text = rdr("main_category")
                    cbb_subcategory.Text = rdr("sub_category")
                    cbb_brand.Text = rdr("brand")
                    txt_tags.Text = rdr("tags")
                    txt_baseprice.Text = rdr("base_price")
                    txt_cost.Text = rdr("cost")
                    IIf(Not IsDBNull(rdr("discount")), txt_discount.Text = rdr("discount").ToString, txt_discount.Text = String.Empty)
                    txt_srp.Text = rdr("regular_price")
                    If Not IsDBNull(rdr("length")) Then txt_length.Text = rdr("length") Else txt_length.Text = String.Empty
                    If Not IsDBNull(rdr("width")) Then txt_width.Text = rdr("width") Else txt_width.Text = String.Empty
                    If Not IsDBNull(rdr("height")) Then txt_height.Text = rdr("height") Else txt_height.Text = String.Empty
                    If Not IsDBNull(rdr("weight")) Then txt_weight.Text = rdr("weight") Else txt_weight.Text = String.Empty
                    txt_cautions.Text = IIf(IsDBNull(rdr("hazards")), String.Empty, rdr("hazards"))
                    cbb_status.Text = "For Approval"
                    cbb_supplier.SelectedIndex = rdr("supplier")
                    If Not IsDBNull(rdr("serialized")) Then switch_serialize.Checked = rdr("serialized") Else switch_serialize.Checked = False
                    If Not IsDBNull(rdr("ideal_stock")) Then txt_ideal_stock.Text = rdr("ideal_stock") Else txt_ideal_stock.Text = String.Empty
                    If Not IsDBNull(rdr("warning_stock")) Then txt_warning_stock.Text = rdr("warning_stock") Else txt_warning_stock.Text = String.Empty
                    If Not IsDBNull(rdr("stock_duration")) Then txt_stock_duration.Text = rdr("stock_duration") Else txt_stock_duration.Text = String.Empty
                    If Not IsDBNull(rdr("warranty_period")) Then txt_warranty_period.Text = rdr("warranty_period") Else txt_warranty_period.Text = String.Empty
                    txt_warranty_coverage.Text = IIf(IsDBNull(rdr("warranty_coverage")), String.Empty, rdr("warranty_coverage"))
                    setImage(rdr("winmodel"))
                End While

                old_pid = txt_pid.Text.Trim
                old_model = txt_winmodel.Text.Trim
                old_description = txt_description.Text.Trim
                src = source
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Upload Photo to Server
    Private Function UploadProductPhoto(model As String)

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
            Try
                client.Connect()

                'Get directoory list
                Dim files = client.ListDirectory("./")

                'Check IF FOLDER EXIST
                Dim is_exist = False
                For Each file As SftpFile In files
                    If Equals(file.Name, ftp_productFolder) Then is_exist = True
                Next

                'Creating folder IF NOT EXIST
                If is_exist = False Then
                    MsgBox("No folder '" & ftp_productFolder & "' existed! Creating one...")
                    client.CreateDirectory("./" & ftp_productFolder)
                End If

                'Saving file to Folder
                Dim stream As New MemoryStream
                pb_new_unit.Image.Save(stream, Imaging.ImageFormat.Jpeg)
                stream.Position = 0
                client.UploadFile(stream, "./" & ftp_productFolder & "/" & model & ".jpg")

            Catch ex As Exception
            End Try

        End Using

        Return model & ".jpg"

    End Function

    'Set Photo from server
    Private Sub setImage(FileName As String)

        Using client As New SftpClient(ftp_server, ftp_username, ftp_password)
            Try
                client.Connect()
                Dim ms As New MemoryStream
                client.DownloadFile("./" & ftp_productFolder & "/" & FileName & ".jpg", ms)

                If Not ms.Length = 0 Then
                    pb_new_unit.Image = Image.FromStream(ms)
                End If

            Catch ex As Exception
            Finally
                client.Disconnect()
            End Try
        End Using

    End Sub




    'Control Events

    'Base Price + Cost Calculation
    Private Sub txt_baseprice_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_baseprice.KeyUp
        Try
            If IsNumeric(txt_baseprice.Text) Then
                txt_cost.Text = txt_baseprice.Text - (txt_baseprice.Text * (txt_discount.Text / 100))
            End If
        Catch ex As Exception

        End Try
    End Sub

    'Discount Computation
    Private Sub txt_discount_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_discount.KeyUp
        Try
            If IsNumeric(txt_discount.Text) Then
                e.Handled = True
                txt_cost.Text = txt_baseprice.Text - (txt_baseprice.Text * (txt_discount.Text / 100))
            End If
        Catch ex As Exception

        End Try
    End Sub

    'btn_camera
    Private Sub btn_camera_Click(sender As Object, e As EventArgs) Handles btn_camera.Click
        Dim d As New OpenFileDialog
        If Not d.ShowDialog = DialogResult.Cancel Then
            pb_new_unit.Image = Image.FromFile(d.FileName)
        End If
    End Sub


End Class