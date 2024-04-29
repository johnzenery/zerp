Imports MySqlConnector

Public Class frm_purchaseorder_purchase_request_new


    Private Sub frm_purchaseorder_purchase_request_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Search()
        grid_order.DataSource = Create_DataTable_Source()
        txt_requested_by.Text = frm_main.lbl_user_name.Text
    End Sub



    'LOAD SEARCH GRID
    Private Sub Load_Search()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT brand, winmodel, unit, description, pid, supplier FROM ims_inventory WHERE status='Active'", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_search.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Show Qty Dialog
    Private Sub Show_QtyDialog()
        Try
            Dim qty_dialog = New frm_sales_order_qty_dialog

            If qty_dialog.ShowDialog() = DialogResult.OK Then

                Using dt = TryCast(grid_order.DataSource, DataTable)
                    With grid_search_view
                        dt.Rows.Add(
                                qty_dialog.quantity_entered,
                                .GetFocusedRowCellValue(col_search_brand),
                                .GetFocusedRowCellValue(col_search_model),
                                .GetFocusedRowCellValue(col_search_unit),
                               .GetFocusedRowCellValue(col_search_description),
                                .GetFocusedRowCellValue(col_search_pid),
                                .GetFocusedRowCellValue(col_search_supplier)
                                )
                    End With
                End Using

            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Function Create_DataTable_Source() As DataTable
        Dim dt = New DataTable
        dt.Columns.Add("qty", GetType(Decimal))
        dt.Columns.Add("brand", GetType(String))
        dt.Columns.Add("winmodel", GetType(String))
        dt.Columns.Add("unit", GetType(String))
        dt.Columns.Add("description", GetType(String))
        dt.Columns.Add("pid", GetType(Integer))
        dt.Columns.Add("supplier", GetType(Integer))
        Return dt
    End Function






    '--- CONTROLS' EVENTS ----

    'GRID SEARCH : BUTTON (ADD)
    Private Sub btn_add_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_add.ButtonClick
        Show_QtyDialog()
    End Sub

    'BUTTON : SUMIT
    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If MsgBox("Press 'YES' to confirm.", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("INSERT INTO ims_purchase_request (requested_by, date_request) 
                                            VALUES ((SELECT usr_id FROM ims_users WHERE first_name=@requested_by), NOW())", conn)
                        cmd.Parameters.AddWithValue("@requested_by", txt_requested_by.Text)
                        If cmd.ExecuteNonQuery > 0 Then
                            Using cmd_2 = New MySqlCommand("INSERT INTO ims_purchase_request_items (pid, qty, supplier_id, pr_id) VALUES (@pid, @qty, @supplier_id, @pr_id)", conn)
                                cmd_2.Parameters.AddWithValue("@pid", 0)
                                cmd_2.Parameters.AddWithValue("@qty", 0)
                                cmd_2.Parameters.AddWithValue("@supplier_id", 0)
                                cmd_2.Parameters.AddWithValue("@pr_id", cmd.LastInsertedId())
                                cmd_2.Prepare()

                                For Each row As DataRow In TryCast(grid_order.DataSource, DataTable).Rows
                                    cmd_2.Parameters("pid").Value = row.Item("pid")
                                    cmd_2.Parameters("qty").Value = row.Item("qty")
                                    cmd_2.Parameters("supplier_id").Value = row.Item("supplier")
                                    cmd_2.ExecuteNonQuery()
                                Next

                                MsgBox("Success!", vbInformation, "Information")
                                Me.Close()
                            End Using
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    'FORM : KEYDOWN
    Private Sub frm_purchaseorder_purchase_request_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control = True And e.KeyCode = Keys.Enter Then
            Show_QtyDialog()
        End If
    End Sub

End Class