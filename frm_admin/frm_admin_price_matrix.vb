Imports DevExpress
Imports DevExpress.Pdf.Interop
Imports MySqlConnector
Imports OfficeOpenXml

Public Class frm_admin_price_matrix

    '--- ONLOAD ---
    Private Sub frm_admin_price_matrix_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_PriceMatrix("show_all")
    End Sub



    '--- FUNCTIONS ---

    'LOAD PRICE MATRIX
    Private Sub Load_PriceMatrix(filter As String)
        Try
            Dim select_query As String = String.Empty
            Dim dt = New DataTable
            dt.Columns.Add("combination_id")
            dt.Columns.Add("combination_name")
            dt.Columns.Add("affected_items")
            dt.Columns.Add("regular_discount")
            dt.Columns.Add("dealer_discount")
            dt.Columns.Add("vip_discount")

            Select Case filter
                Case "show_null"
                    filter = "WHERE ims_price_matrix.regular_discount IS NULL OR ims_price_matrix.dealer_discount IS NULL OR ims_price_matrix.vip_discount IS NULL"
                Case "show_all"
                    filter = ""
            End Select

            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT combination_id, inv.combination_name, COUNT(inv.combination_name) affected_items,
                                    IF(ims_price_matrix.regular_discount = 'NET', ims_price_matrix.regular_discount, CONCAT(ims_price_matrix.regular_discount, '%')) regular_discount, 
                                    IF(ims_price_matrix.dealer_discount = 'NET', ims_price_matrix.dealer_discount, CONCAT(ims_price_matrix.dealer_discount, '%')) dealer_discount, 
                                    IF(ims_price_matrix.vip_discount = 'NET', ims_price_matrix.vip_discount, CONCAT(ims_price_matrix.vip_discount, '%')) vip_discount,
                                    MIN((regular_price - cost) / regular_price) AS min_margin,
                                    MAX((regular_price - cost) / regular_price) AS max_margin,
									AVG((regular_price - cost) / regular_price) AS avg_margin
								FROM 
                                (SELECT CONCAT(brand, ' ', sub_category) AS combination_name, regular_price, COST FROM ims_inventory) inv
                                LEFT JOIN ims_price_matrix ON ims_price_matrix.combination_name=inv.combination_name
                                " & filter & "
                                GROUP BY combination_name 
                                ORDER BY combination_name ASC", conn)

                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_price_matrix.DataSource = dt
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub grid_price_matrix_view_CellValueChanged(sender As Object, e As XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_price_matrix_view.CellValueChanged
        Try
            If Equals(e.Value.ToString, "NET") Or IsNumeric(e.Value) Or Equals(e.Value, String.Empty) Or e.Value.ToString.Contains("%") Then
                If Not e.Value.ToString.Contains("%") Then
                    If IsNumeric(e.Value) Or Equals(e.Value.ToString, "NET") Then

                        Using conn = New MySqlConnection(str)
                            conn.Open()

                            If IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_id)) Then
                                Using cmd = New MySqlCommand("INSERT INTO ims_price_matrix 
                                        (combination_name, regular_discount, dealer_discount, vip_discount)
                                        VALUES (@combination_name, @regular, @dealer, @vip)", conn)
                                    cmd.Parameters.AddWithValue("@combination_name", grid_price_matrix_view.GetFocusedRowCellValue(col_combinations))
                                    cmd.Parameters.AddWithValue("@regular", IIf(IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_regular_price)), Nothing, e.Value))
                                    cmd.Parameters.AddWithValue("@dealer", IIf(IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_dealer_price)), Nothing, e.Value))
                                    cmd.Parameters.AddWithValue("@vip", IIf(IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_vip_price)), Nothing, e.Value))
                                    If cmd.ExecuteNonQuery > 0 Then

                                        'IF ISDIGIT
                                        If Not Equals(e.Value.ToString, "NET") Then
                                            grid_price_matrix_view.SetFocusedValue(e.Value & "%")
                                        End If

                                        'RELOAD
                                        If cb_show_null.Text.Equals("Show NULL") Then
                                            Load_PriceMatrix("show_all")

                                        ElseIf cb_show_null.Text.Equals("Hide NULL") Then
                                            Load_PriceMatrix("show_null")
                                        End If

                                    End If
                                End Using

                            Else
                                If e.Column.Name = col_dealer_price.Name Then
                                    Using cmd = New MySqlCommand("UPDATE ims_price_matrix 
                                        SET dealer_discount=@dealer 
                                        WHERE combination_id=@combination_id", conn)
                                        cmd.Parameters.AddWithValue("@combination_id", grid_price_matrix_view.GetFocusedRowCellValue(col_id))
                                        cmd.Parameters.AddWithValue("@dealer", IIf(IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_dealer_price)), Nothing, e.Value))
                                        If cmd.ExecuteNonQuery > 0 Then
                                            If Not Equals(e.Value.ToString, "NET") Then
                                                grid_price_matrix_view.SetFocusedValue(e.Value & "%")
                                            End If
                                        End If
                                    End Using

                                ElseIf e.Column.Name = col_vip_price.Name Then
                                    Using cmd = New MySqlCommand("UPDATE ims_price_matrix 
                                        SET vip_discount=@vip 
                                        WHERE combination_id=@combination_id", conn)
                                        cmd.Parameters.AddWithValue("@combination_id", grid_price_matrix_view.GetFocusedRowCellValue(col_id))
                                        cmd.Parameters.AddWithValue("@vip", IIf(IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_vip_price)), Nothing, e.Value))
                                        If cmd.ExecuteNonQuery > 0 Then
                                            If Not Equals(e.Value.ToString, "NET") Then
                                                grid_price_matrix_view.SetFocusedValue(e.Value & "%")
                                            End If
                                        End If
                                    End Using

                                ElseIf e.Column.Name = col_regular_price.Name Then
                                    Using cmd = New MySqlCommand("UPDATE ims_price_matrix 
                                        SET regular_discount=@regular 
                                        WHERE combination_id=@combination_id", conn)
                                        cmd.Parameters.AddWithValue("@combination_id", grid_price_matrix_view.GetFocusedRowCellValue(col_id))
                                        cmd.Parameters.AddWithValue("@regular", IIf(IsDBNull(grid_price_matrix_view.GetFocusedRowCellValue(col_regular_price)), Nothing, e.Value))
                                        If cmd.ExecuteNonQuery > 0 Then
                                            If Not Equals(e.Value.ToString, "NET") Then
                                                grid_price_matrix_view.SetFocusedValue(e.Value & "%")
                                            End If
                                        End If
                                    End Using

                                End If

                            End If

                        End Using

                    End If
                End If

            Else
                MsgBox("Invalid value!")
                grid_price_matrix_view.SetFocusedValue(String.Empty)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'CHECKBOX : SHOW / HIDE NULL
    Private Sub cb_show_null_CheckedChanged(sender As Object, e As EventArgs) Handles cb_show_null.CheckedChanged
        If cb_show_null.Text.Equals("Show NULL") Then
            cb_show_null.Text = "Hide NULL"
            Load_PriceMatrix("show_null")

        ElseIf cb_show_null.Text.Equals("Hide NULL") Then
            cb_show_null.Text = "Show NULL"
            Load_PriceMatrix("show_all")

        End If
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Try
            Using conn = New MySqlConnection(str & ";AllowLoadLocalInFile=true")
                conn.Open()

                Dim blkcp = New MySqlBulkCopy(conn)
                blkcp.DestinationTableName = "ims_price_matrix"
                Dim res = blkcp.WriteToServer(TryCast(grid_price_matrix.DataSource, DataTable))
                If res.Warnings.Count > 0 Then
                    MsgBox(res.Warnings)
                End If
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Try
            Dim saveFileDialog = New SaveFileDialog With {.Filter = "Microsoft Excel (*.xlsx)|*.xlsx"}
            If saveFileDialog.ShowDialog = DialogResult.OK Then
                grid_price_matrix_view.ExportToXlsx(saveFileDialog.FileName)
            End If

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class