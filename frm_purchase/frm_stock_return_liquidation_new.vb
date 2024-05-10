Imports DevExpress.XtraReports.UI
Imports Microsoft
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_stock_return_liquidation_new

    Public Property liquidation_id As Integer = 0

    '--- ONLOAD ---
    Private Sub frm_stock_return_liquidation_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitGrid()
    End Sub



    '--- FUNCTIONS ---

    'Load Grid
    Private Sub InitGrid()

        Dim addtl_query As String = String.Empty
        If liquidation_id > 0 Then
            addtl_query = "AND liquidation_id = " & liquidation_id
            Me.Text = $"Stock Liquidation #{liquidation_id}"
        Else
            addtl_query = "AND liquidation_id IS NULL "
        End If

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'GET RETURNS FROM DELIVERIES
                Using cmd = New MySqlCommand("SELECT rs_returns_deliveries.id, rid, qty_received, rs_returns.pid, ims_inventory.winmodel, ims_inventory.description, rs_returns.cost, (qty_received * rs_returns.cost) total_cost
                                            FROM rs_returns_deliveries
                                            LEFT JOIN rs_returns ON rs_returns.id=rs_returns_deliveries.rid
                                            LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            WHERE rs_returns_deliveries.status='Rejected' " & addtl_query, conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_liquidation.DataSource = dt

                End Using

                'GET INFO FROM SLID
                Using cmd = New MySqlCommand($"SELECT status, ims_users.first_name AS created_by, created_at
                                            FROM rs_returns_liquidation 
                                            LEFT JOIN ims_users ON ims_users.usr_id=rs_returns_liquidation.created_by
                                            WHERE liquidation_id={liquidation_id}", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            lbl_created_by.Text = rdr("created_by")
                            lbl_status.Text = rdr("status")
                            lbl_title.Text = $"Stock Liquidation #{liquidation_id}"
                        End While
                    End Using
                End Using

                conn.Close()
            End Using

            ComputeTotal()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'COMPUTE TOTAL
    Private Sub ComputeTotal(Optional kind As String = "")
        Dim totalAmount As Decimal = 0.00

        If Equals(kind, "new") Then
            Dim selectedRows = grid_liquidation_view.GetSelectedRows
            For i = 0 To selectedRows.Count - 1
                Dim amount As Decimal = grid_liquidation_view.GetRowCellValue(selectedRows(i), col_amount)
                totalAmount += amount
            Next
        Else
            For i = 0 To grid_liquidation_view.RowCount - 1
                Dim amount As Decimal = grid_liquidation_view.GetRowCellValue(i, col_amount)
                totalAmount += amount
            Next
        End If

        lbl_total_amount.Text = FormatCurrency(totalAmount)

    End Sub




    '--- CONTROLS / EVENTS ---

    'GRID : SELECTION CHANGED
    Private Sub grid_liquidation_view_SelectionChanged(sender As Object, e As DevExpress.Data.SelectionChangedEventArgs) Handles grid_liquidation_view.SelectionChanged
        ComputeTotal("new")
    End Sub

    'BUTTON : CREATE
    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        If MsgBox("Proceed to create?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim LastInsertedID As Integer = 0
                    Dim transc = conn.BeginTransaction

                    Try
                        'INSERT INTO rs_returns_liquidation
                        Using cmd = New MySqlCommand("INSERT INTO rs_returns_liquidation (created_at, created_by, status) 
                                                VALUES (CURRENT_TIMESTAMP, @created_by, 'Pending for Approval')", conn, transc)
                            cmd.Parameters.AddWithValue("@created_by", frm_main.lbl_user_id.Text)
                            cmd.ExecuteNonQuery()
                            LastInsertedID = cmd.LastInsertedId
                        End Using

                        'UPDATE RETURN TO VENDOR DELIVERIES
                        Using cmd = New MySqlCommand("UPDATE rs_returns_deliveries SET liquidation_id=@liquidation_id
                                                WHERE id=@id", conn, transc)
                            cmd.Parameters.AddWithValue("@liquidation_id", LastInsertedID)
                            cmd.Parameters.AddWithValue("@id", Nothing)
                            cmd.Prepare()

                            Dim selectedRows = grid_liquidation_view.GetSelectedRows
                            For i = 0 To selectedRows.Count - 1
                                cmd.Parameters("@id").Value = grid_liquidation_view.GetRowCellValue(selectedRows(i), col_id)
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        transc.Commit()
                        MsgBox("Successfully created!", vbInformation, "Information")
                        Me.Close()

                    Catch ex As Exception
                        transc.Rollback()
                        MsgBox($"Failed to create!{Environment.NewLine + ex.Message}", vbCritical, "Error Occured")
                    End Try

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'BUTTON : DELETE
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MsgBox("Press 'Yes' to delete.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Dim LastInsertedID As Integer = 0
                    Dim transc = conn.BeginTransaction

                    Try
                        'INSERT INTO rs_returns_liquidation
                        Using cmd = New MySqlCommand($"UPDATE rs_returns_liquidation SET is_deleted='1', status='Deleted' 
                                                WHERE liquidation_id={liquidation_id}", conn, transc)
                            cmd.ExecuteNonQuery()
                        End Using

                        'UPDATE RETURN TO VENDOR DELIVERIES
                        Using cmd = New MySqlCommand("UPDATE rs_returns_deliveries SET liquidation_id=NULL, status='Rejected'
                                                WHERE id=@id", conn, transc)
                            cmd.Parameters.AddWithValue("@id", Nothing)
                            cmd.Prepare()

                            For i = 0 To grid_liquidation_view.RowCount
                                cmd.Parameters("@id").Value = grid_liquidation_view.GetRowCellValue(i, col_id)
                                cmd.ExecuteNonQuery()
                            Next
                        End Using

                        transc.Commit()
                        MsgBox("Successfully deleted!", vbInformation, "Information")
                        Me.Close()

                    Catch ex As Exception
                        transc.Rollback()
                        MsgBox($"Failed to delete!{Environment.NewLine + ex.Message}", vbCritical, "Error Occured")
                    End Try

                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'BUTTON : PRINT
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Dim report = New doc_stock_liquidation
        Dim printTool = New ReportPrintTool(report)

        Dim table = New PrintData
        Dim packing_list_req As String = String.Empty

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'GET INFO FROM SLID
                Using cmd = New MySqlCommand($"SELECT status, ims_users.first_name AS created_by, created_at
                                            FROM rs_returns_liquidation 
                                            LEFT JOIN ims_users ON ims_users.usr_id=rs_returns_liquidation.created_by
                                            WHERE liquidation_id={liquidation_id}", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            report.Parameters("sl_id").Value = liquidation_id
                            report.Parameters("created_by").Value = rdr("created_by")
                            report.Parameters("created_at").Value = rdr("created_at")
                        End While
                    End Using
                End Using

                'GET REJECTED ITEMS BY SLID
                Using cmd = New MySqlCommand("SELECT rid, qty_received, rs_returns.pid, ims_inventory.winmodel, ims_inventory.description, rs_returns.cost, (qty_received * rs_returns.cost) total_cost
                                            FROM rs_returns_deliveries
                                            LEFT JOIN rs_returns ON rs_returns.id=rs_returns_deliveries.rid
                                            LEFT JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                            WHERE rs_returns_deliveries.status='Rejected' AND liquidation_id = " & liquidation_id, conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            table.stock_liquidation.Rows.Add(rdr("rid"), rdr("qty_received"), rdr("pid"), rdr("winmodel"), rdr("description"), rdr("cost"), rdr("total_cost"))
                        End While
                    End Using

                End Using
                conn.Close()
            End Using

            report.RequestParameters = False
            report.DataSource = table
            printTool.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub btn_approved_Click(sender As Object, e As EventArgs) Handles btn_approved.Click
        If MsgBox($"Press 'Yes' to confirm.{vbNewLine + vbNewLine}STATUS: Approved", vbYesNo + vbQuestion, "Information") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand($"UPDATE rs_returns_liquidation SET status='Approved' 
                                            WHERE liquidation_id={liquidation_id}", conn)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Approved!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK
                        End If
                    End Using
                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub btn_decline_Click(sender As Object, e As EventArgs) Handles btn_decline.Click
        If MsgBox($"Press 'Yes' to confirm.{vbNewLine + vbNewLine}STATUS: Decline", vbYesNo + vbQuestion, "Information") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand($"UPDATE rs_returns_liquidation SET status='Decline' 
                                            WHERE liquidation_id={liquidation_id}", conn)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Decline!", vbInformation, "Information")
                            Me.DialogResult = DialogResult.OK
                        End If
                    End Using
                    conn.Close()
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class