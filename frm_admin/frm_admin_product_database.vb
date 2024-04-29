Imports DevExpress.Utils.Extensions
Imports MySqlConnector
Imports OfficeOpenXml

Public Class frm_admin_product_database


    '--- ONLOAD
    Private Sub frm_admin_product_database_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressPanel.Visible = True
        BackgroundWorker.RunWorkerAsync()
    End Sub



    '--- FUNCTIONS

    Private Sub Load_Product_Database()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_inventory", conn)

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_product.Invoke(Sub()
                                            grid_product.DataSource = dt
                                        End Sub)


                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'EXPORT DATABASE (OLD)
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
                    Log_Export("Exported Product Database", frm_main.lbl_user_id.Text)

                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub







    '--- EVENTS ---

    Private Sub grid_product_view_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grid_product_view.RowUpdated

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim query = "UPDATE ims_inventory SET barcode=@barcode, winmodel=@winmodel, supmodel=@supmodel, supplier=@supplier, description=@description, technical_description=@technical_description,
                                    main_category=@main_category, sub_category=@sub_category, brand=@brand, type=@type, tags=@tags, status=@status, length=@length, width=@width, height=@height, weight=@weight,
                                    unit=@unit, hazards=@hazards, qty_per_box=@qty_per_box, masterbox_qty=@masterbox_qty, min_order_qty=@min_order_qty, warranty_period=@warranty_period, warranty_coverage=@warranty_coverage
                            WHERE pid=@pid"

                With grid_product_view

                    Dim cmd = New MySqlCommand(query, connection)
                    cmd.Parameters.AddWithValue("@pid", .GetFocusedRowCellValue(col_pid))
                    cmd.Parameters.AddWithValue("@barcode", .GetFocusedRowCellValue(col_barcode))
                    cmd.Parameters.AddWithValue("@winmodel", .GetFocusedRowCellValue(col_winmodel))
                    cmd.Parameters.AddWithValue("@supmodel", .GetFocusedRowCellValue(col_supmodel))
                    cmd.Parameters.AddWithValue("@supplier", .GetFocusedRowCellValue(col_supplier))
                    cmd.Parameters.AddWithValue("@description", .GetFocusedRowCellValue(col_description))
                    cmd.Parameters.AddWithValue("@technical_description", .GetFocusedRowCellValue(col_tech_description))
                    cmd.Parameters.AddWithValue("@main_category", .GetFocusedRowCellValue(col_main_category))
                    cmd.Parameters.AddWithValue("@sub_category", .GetFocusedRowCellValue(col_sub_category))
                    cmd.Parameters.AddWithValue("@brand", .GetFocusedRowCellValue(col_brand))
                    cmd.Parameters.AddWithValue("@type", .GetFocusedRowCellValue(col_type))
                    cmd.Parameters.AddWithValue("@tags", .GetFocusedRowCellValue(col_tags))
                    cmd.Parameters.AddWithValue("@status", .GetFocusedRowCellValue(col_status))
                    cmd.Parameters.AddWithValue("@length", .GetFocusedRowCellValue(col_length))
                    cmd.Parameters.AddWithValue("@width", .GetFocusedRowCellValue(col_width))
                    cmd.Parameters.AddWithValue("@height", .GetFocusedRowCellValue(col_height))
                    cmd.Parameters.AddWithValue("@weight", .GetFocusedRowCellValue(col_weight))
                    cmd.Parameters.AddWithValue("@unit", .GetFocusedRowCellValue(col_unit))
                    cmd.Parameters.AddWithValue("@hazards", .GetFocusedRowCellValue(col_hazards))
                    cmd.Parameters.AddWithValue("@qty_per_box", .GetFocusedRowCellValue(col_IBQ))
                    cmd.Parameters.AddWithValue("@masterbox_qty", .GetFocusedRowCellValue(col_MBQ))
                    cmd.Parameters.AddWithValue("@min_order_qty", .GetFocusedRowCellValue(col_MO_qty))
                    cmd.Parameters.AddWithValue("@warranty_period", .GetFocusedRowCellValue(col_warranty_period))
                    cmd.Parameters.AddWithValue("@warranty_coverage", .GetFocusedRowCellValue(col_warranty_coverage))
                    If cmd.ExecuteNonQuery() > 0 Then
                        MsgBox("Success!")
                    End If

                End With
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'BACKGROUND WORKER (DO WORK) : LOAD PRODUCTS
    Private Sub BackgroundWorker_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker.DoWork
        Load_Product_Database()
    End Sub

    'BACKGROUND WORKER (COMPLETED) : LOAD PRODUCTS
    Private Sub BackgroundWorker_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker.RunWorkerCompleted
        ProgressPanel.Visible = False
    End Sub

    'BUTTON : EDIT
    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        If btn_edit.Text = "Edit" Then
            btn_edit.Text = "Close"
            btn_edit.ImageOptions.SvgImage = My.Resources.cancel
            grid_product_view.OptionsBehavior.Editable = True

        ElseIf btn_edit.Text = "Close" Then
            btn_edit.Text = "Edit"
            btn_edit.ImageOptions.SvgImage = My.Resources.actions_edit
            grid_product_view.OptionsBehavior.Editable = False
        End If

    End Sub

    'BUTTON : MASS IMPORT / UPDATE
    Private Sub btn_import_update_Click(sender As Object, e As EventArgs) Handles btn_import_update.Click
        Dim frm = New frm_product_import
        frm.Show()
    End Sub

    'BUTTON : EXPORT DATABASE (OLD)
    Private Sub btn_export_database_Click(sender As Object, e As EventArgs) Handles btn_export_database.Click
        ExportDatabase()
    End Sub

    'BUTTON : EXPORT
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            ExcelPackage.LicenseContext = LicenseContext.Commercial
            Dim saveFileDialog = New SaveFileDialog With {.Filter = "Microsoft Excel (*.xlsx)|*.xlsx"}

            If saveFileDialog.ShowDialog = DialogResult.OK Then
                My.Computer.FileSystem.WriteAllBytes(saveFileDialog.FileName, My.Resources.import_template, False)


                Using package = New ExcelPackage(saveFileDialog.FileName)
                    Dim sheet = package.Workbook.Worksheets(0)

                    Dim dt = TryCast(grid_product.DataSource, DataTable)
                    Dim selected_rows = grid_product_view.GetSelectedRows

                    For i = 0 To selected_rows.Length - 1
                        For j = 0 To dt.Columns.Count - 1
                            Dim ds_row_index = grid_product_view.GetDataSourceRowIndex(selected_rows(i))
                            sheet.Cells(i + 2, j + 1).Value = dt.Rows(ds_row_index).Item(j)
                        Next
                    Next

                    package.Save()

                    MsgBox("Exported!", vbInformation, "Information")
                    Log_Export("Exported Product Database", frm_main.lbl_user_id.Text)

                End Using
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'GRID Product Database : Selection Changed
    Private Sub grid_product_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_product_view.SelectionChanged
        If grid_product_view.SelectedRowsCount > 0 Then
            btn_export.Enabled = True
        Else
            btn_export.Enabled = False
        End If
    End Sub

End Class