Imports System.IO
Imports OfficeOpenXml
Imports MySqlConnector

Public Class frm_warehouse_stock_inventory_export_dialog

    '--- ONLOAD
    Private Sub frm_warehouse_stock_inventory_export_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadWarehouse()
    End Sub


    '--- FUNCTIONS ---

    'LOAD WAREHOUSES
    Private Sub LoadWarehouse()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT * FROM ims_stores", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_export.DataSource = dt
                    grid_export_view.BestFitColumns()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'EXPORT
    Private Sub Export(filename As String)
        Try
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial
            Dim ImportFileByte() As Byte = My.Resources.ginee_export_template
            IO.File.WriteAllBytes(filename, ImportFileByte)

            Dim file = New FileInfo(filename)
            Using package = New ExcelPackage(file)

                Dim worksheet = package.Workbook.Worksheets(0)

                Using conn = New MySqlConnection(str)
                    conn.Open()

                    Using cmd = New MySqlCommand("SELECT winmodel, (main_tbl.total_qty - IFNULL(left_tbl.diff_qty, 0)) AS total_qty 
                            FROM
                            (SELECT ims_inventory.pid, winmodel, (" & GetSelectedWarehouse_qty() & ") AS total_qty
                                FROM ims_inventory " & GetSelectedWarehouse_name() & "
                            ) main_tbl
                            LEFT JOIN (SELECT 
                                (Sum(qty) - Sum(scanned_qty)) diff_qty, mycart_orders.pid 
                                FROM mycart_orders where (status='Pending' or status='Picklisted' or status='Scanned') AND is_deleted=0 GROUP BY pid
                                ) left_tbl ON left_tbl.pid=main_tbl.pid
                            WHERE NOT main_tbl.total_qty=0 AND total_qty IS NOT NULL", conn)

                        Dim dt = New DataTable
                        Dim da = New MySqlDataAdapter(cmd)
                        da.Fill(dt)

                        For i = 1 To dt.Rows.Count
                            worksheet.Cells(i + 1, 1).Value = dt.Rows(i - 1).Item("winmodel")
                            worksheet.Cells(i + 1, 3).Value = txt_warehouse_code.EditValue
                            worksheet.Cells(i + 1, 6).Value = dt.Rows(i - 1).Item("total_qty")
                        Next

                    End Using
                    conn.Close()
                End Using

                'SAVE
                package.Save()

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'GET SELECTED WAREHOUSE
    Private Function GetSelectedWarehouse_name() As String
        Dim selected_rows = grid_export_view.GetSelectedRows
        Dim selected_warehouse As String = String.Empty

        For i = 0 To selected_rows.Length - 1

            Dim warehouse = "ims_" & grid_export_view.GetRowCellValue(selected_rows(i), col_warehouse_name).ToString.Replace(" ", "_").ToLower
            'LEFT JOIN
            selected_warehouse += String.Concat(Environment.NewLine & "LEFT JOIN ", warehouse, " ON ", warehouse, ".pid=ims_inventory.pid")
        Next

        Return selected_warehouse

    End Function

    'GET SELECTED WAREHOUSE : QTY
    Private Function GetSelectedWarehouse_qty() As String
        Dim selected_rows = grid_export_view.GetSelectedRows
        Dim selected_warehouse_qty As String = String.Empty

        For i = 0 To selected_rows.Length - 1

            Dim warehouse = "ims_" & grid_export_view.GetRowCellValue(selected_rows(i), col_warehouse_name).ToString.Replace(" ", "_").ToLower
            'TOTAL QTY
            selected_warehouse_qty = String.Concat(selected_warehouse_qty, " + ", "IFNULL(" & warehouse.ToLower.Replace(" ", "_") & ".qty, 0)")
        Next

        Return selected_warehouse_qty

    End Function




    '--- CONTROLS / EVENTS ---

    'BUTTON : CANCEL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'BUTTON : EXPORT
    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click

        If grid_export_view.GetSelectedRows.Length = 0 Then
            MsgBox("Select warehouse to export first!", vbCritical, "Required")
            Return
        End If

        If String.IsNullOrWhiteSpace(txt_warehouse_code.EditValue) Then
            MsgBox("Warehouse Code shouldn't be empty!", vbCritical, "Required")
            Return
        End If

        XtraSaveFileDialog1.Filter = "Excel Files (*.xlsx*)|*.xlsx"
        XtraSaveFileDialog1.FilterIndex = 2
        XtraSaveFileDialog1.RestoreDirectory = True
        XtraSaveFileDialog1.FileName = "Ginee Export Report"

        If XtraSaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Export(XtraSaveFileDialog1.FileName)
            MsgBox("Exported!", vbInformation, "Information")
            Me.Close()
        End If
    End Sub


End Class