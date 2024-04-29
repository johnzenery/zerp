Imports System.IO
Imports DevExpress.Utils.CommonDialogs
Imports DevExpress.XtraPrinting.BarCode
Imports MySqlConnector
Imports OfficeOpenXml

Public Class frm_warehouse_stock_inventory

    '--- ON LOAD ---
    Private Sub frm_product_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyStore()
        LoadAllStore()

        If frm_main.lbl_user_role_id.Text = 1 Then
            btn_import.Visible = True
        Else
            btn_import.Visible = False
        End If

    End Sub



    '--- FUNCTIONS ----

    'MyStore Inventory
    Private Sub MyStore()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim my_store = "ims_" & frm_main.lbl_user_designation.Text.Trim.Replace(" ", "_").ToLower
                Dim query = "SELECT ims_inventory.pid, winmodel, brand, main_category, sub_category, description, status, masterbox_qty, qty_per_box, unit,
                            mystore.qty, mystore.on_hold, mystore.location, mystore.location_2, mystore.zone 
                            FROM ims_inventory 
                            INNER JOIN " & my_store & " AS mystore ON mystore.pid=ims_inventory.pid"

                Dim cmd_grid = New MySqlCommand(query, connection)
                cmd_grid.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd_grid)
                da.Fill(dt)

                grid_mystore.DataSource = dt

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub


    'Load ALL Store's Inventory
    Private Sub LoadAllStore()
        Try
            Dim stores_qty = String.Empty
            Dim total_qty = "0"
            Dim stores_onhold = "0"
            Dim left_join = String.Empty

            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET ALL STORES tables
                Using cmd = New MySqlCommand("SELECT store_name FROM ims_stores", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            Dim STORE = rdr("store_name")
                            stores_qty += ", ims_" & STORE.ToLower.Replace(" ", "_") & ".qty as '" & STORE.Replace("Winland ", String.Empty) & "'"
                            stores_onhold = String.Concat(stores_onhold, " + ", "IFNULL(ims_" & STORE.ToLower.Replace(" ", "_") & ".on_hold, 0)")
                            total_qty = String.Concat(total_qty, " + ", "IFNULL(ims_" & STORE.ToLower.Replace(" ", "_") & ".on_hold, 0)", " + ", "IFNULL(ims_" & STORE.ToLower.Replace(" ", "_") & ".qty, 0)")
                            left_join += " LEFT JOIN ims_" & STORE.ToLower.Replace(" ", "_") & " ON ims_inventory.pid=" & "ims_" & STORE.ToLower.Replace(" ", "_") & ".pid"
                        End While
                    End Using
                End Using

                'GET DATA FROM ALL STORES
                Dim query = "SELECT ims_inventory.pid AS 'PID', winmodel AS Model, brand as Brand, main_category AS 'Category', sub_category as 'Sub Cateogy', description as Description, status as 'Status', masterbox_qty as 'Master Box', qty_per_box as 'Inner Box', unit 'Unit',
                        (" & total_qty & ") AS 'Total', (" & stores_onhold & ") AS 'On-Hold'" & stores_qty & " FROM ims_inventory" & left_join
                Using cmd_grid = New MySqlCommand(query, connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd_grid)
                    da.Fill(dt)
                    grid_all.DataSource = dt
                End Using

                'FORMAT DISPLAY
                grid_all_view.Columns(0).Width = 100
                grid_all_view.Columns(1).Width = 200
                grid_all_view.Columns(2).Width = 150
                grid_all_view.Columns(3).Width = 150
                grid_all_view.Columns(4).Width = 150
                grid_all_view.Columns(5).Width = 500
                grid_all_view.Columns(6).Width = 100

                For i = 7 To grid_all_view.Columns.Count - 1
                    grid_all_view.Columns(i).Width = 120
                Next

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub





    '--- FUNCTIONS ----

    'Save Upon Edit of Location
    Private Sub grid_mystore_view_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grid_mystore_view.RowUpdated
        Dim rowView As DataRowView = TryCast(e.Row, DataRowView)
        Dim row As DataRow = rowView.Row

        Dim STORE = "ims_" & frm_main.lbl_user_designation.Text.Replace(" ", "_").ToLower
        Dim location = row("location").ToString.ToUpper
        Dim location_2 = row("location_2").ToString.ToUpper
        Dim zone = row("zone").ToString.ToUpper
        Dim pid = CInt(row("pid"))

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "UPDATE " & STORE & " SET location=@location, location_2=@location_2, zone=@zone WHERE pid=@pid"
                Dim cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@location", location)
                cmd.Parameters.AddWithValue("@location_2", location_2)
                cmd.Parameters.AddWithValue("@zone", zone)
                cmd.Parameters.AddWithValue("@pid", pid)
                cmd.ExecuteNonQuery()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        grid_mystore_view.SetRowCellValue(e.RowHandle, col_location_1, location)

    End Sub


    'btn_print 
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If TabPane.SelectedPageIndex = 0 Then
            grid_mystore_view.ShowPrintPreview()
        Else TabPane.SelectedPageIndex = 1
            grid_all_view.ShowPrintPreview()
        End If

    End Sub

    'btn_export
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        If TabPane.SelectedPageIndex = 0 Then
            Try

                Dim saveFileDialog = New SaveFileDialog
                saveFileDialog.Filter = "Excel File (*.xlsx*)|*.xlsx"

                If saveFileDialog.ShowDialog = DialogResult.OK Then

                    grid_mystore_view.OptionsView.ShowHorizontalLines = False
                    grid_mystore_view.OptionsView.ShowVerticalLines = False
                    grid_mystore_view.ExportToXlsx(saveFileDialog.FileName)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error Occured")
            End Try


        Else TabPane.SelectedPageIndex = 1
            Try

                Dim saveFileDialog = New SaveFileDialog
                saveFileDialog.Filter = "Excel File (*.xlsx*)|*.xlsx"

                If saveFileDialog.ShowDialog = DialogResult.OK Then

                    grid_all_view.OptionsView.ShowHorizontalLines = False
                    grid_all_view.OptionsView.ShowVerticalLines = False
                    grid_all_view.ExportToXlsx(saveFileDialog.FileName)
                End If

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error Occured")
            End Try
        End If

    End Sub

    Private Sub grid_mystore_view_EditFormPrepared(sender As Object, e As DevExpress.XtraGrid.Views.Grid.EditFormPreparedEventArgs) Handles grid_mystore_view.EditFormPrepared
        e.BindableControls("pid").Enabled = False
        e.BindableControls("winmodel").Enabled = False
        e.BindableControls("description").Enabled = False
        e.BindableControls("qty").Enabled = False
        e.BindableControls("on_hold").Enabled = False
        e.BindableControls("brand").Enabled = False
        e.BindableControls("main_category").Enabled = False
        e.BindableControls("sub_category").Enabled = False
        e.BindableControls("masterbox_qty").Enabled = False
        e.BindableControls("qty_per_box").Enabled = False
    End Sub

    Private Sub btn_simple_Click(sender As Object, e As EventArgs) Handles btn_import.Click
        frm_warehouse_import.Show()
    End Sub

    'BUTTON : GINEE EXPORT
    Private Sub btn_ginee_export_Click(sender As Object, e As EventArgs) Handles btn_ginee_export.Click
        Dim frm = New frm_warehouse_stock_inventory_export_dialog
        frm.ShowDialog()
        Return

        '--- OBSOLETE ---
        Try
            LoadAllStore()

            'Get Template into PATH
            Dim barcode_template() As Byte = My.Resources.ginee_export_template

            'Create Path
            Dim dir_path = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) & "\Zerp Data"
            If Not Directory.Exists(dir_path) Then Directory.CreateDirectory(dir_path)
            Dim full_path = dir_path & "\ginee_export_template.xlsx"

            File.WriteAllBytes(full_path, barcode_template)
            Dim temp_path = New FileInfo(full_path)

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Using package As New ExcelPackage(temp_path)
                Dim worksheet As ExcelWorksheet = package.Workbook.Worksheets(0)

                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("SELECT combined_tables.pid, ims_inventory.winmodel, combined_tables.total_qty 
                                                    FROM (
	                                                    SELECT pid, SUM(qty) AS total_qty
	                                                    FROM (
	                                                        SELECT pid, qty FROM ims_parsell_tinajeros
	                                                        UNION ALL
	                                                        SELECT pid, qty FROM ims_parsell_potrero
	                                                    ) combined_tables
	                                                    GROUP BY pid
                                                    ) combined_tables
                                                    LEFT JOIN ims_inventory ON ims_inventory.pid = combined_tables.pid", conn)

                        Dim dt = New DataTable
                        Dim da = New MySqlDataAdapter(cmd)
                        da.Fill(dt)

                        For i = 1 To dt.Rows.Count
                            worksheet.Cells(i + 1, 1).Value = dt.Rows(i - 1).Item("winmodel")
                            worksheet.Cells(i + 1, 3).Value = "001"
                            worksheet.Cells(i + 1, 6).Value = dt.Rows(i - 1).Item("total_qty")
                        Next

                    End Using
                    conn.Close()
                End Using

                Dim saveFileDialog As New SaveFileDialog
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx"
                saveFileDialog.FilterIndex = 2
                saveFileDialog.RestoreDirectory = True

                If saveFileDialog.ShowDialog() = DialogResult.OK Then
                    package.SaveAs(saveFileDialog.FileName)
                End If

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class