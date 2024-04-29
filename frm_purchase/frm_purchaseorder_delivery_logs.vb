Imports MySqlConnector

Public Class frm_purchaseorder_delivery_logs


    '--- ONLOAD ----
    Private Sub frm_delivery_logs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dt_start.EditValue = Date.Today.AddDays(-7)
        dt_end.EditValue = Date.Now
        LoadDelivered(dt_start.EditValue, dt_end.EditValue)

        'Super Admin Access
        If frm_main.lbl_user_id.Text = 10 Then
            grid_supplier_deliveries_view.Columns("date_received").OptionsColumn.ReadOnly = False
        End If

    End Sub




    '---- FUNCTIONS ----

    'Load Delivery Logs
    Private Sub LoadDelivered(startDate As Date, endDate As Date)

        Dim query = "SELECT reference, ims_inventory.unit, ims_inventory.pid, ims_inventory.brand, ims_inventory.winmodel, ims_inventory.description, qty, ims_deliveries.cost, date_received, CONCAT('PO', LPAD(ims_deliveries.purchase_id,5,0)) AS poid,
                    (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) AS supplier, ims_users.first_name, ims_delivery_receipts.count_by, ims_stores.store_name, 
                    CONCAT(ims_delivery_receipts.receipt_type, '#', ims_delivery_receipts.receipt_ref) receipt_ref, created_at, 
                    tax_type, dr_no, si_no, IF(is_bundle=1, 'YES', 'NO') is_bundle
                    FROM `ims_deliveries`
                    LEFT JOIN ims_delivery_receipts ON ims_delivery_receipts.payable_id=ims_deliveries.receipt_id
                    LEFT JOIN ims_inventory ON ims_inventory.pid=ims_deliveries.item
                    LEFT JOIN ims_users ON ims_users.usr_id=ims_deliveries.receiver
                    LEFT JOIN ims_stores ON ims_stores.store_id=ims_deliveries.store_id
                    LEFT JOIN ims_purchase ON ims_purchase.purchase_id=ims_deliveries.purchase_id
                    WHERE ims_deliveries.is_deleted='0' AND date_received BETWEEN CAST(@startDate AS DATE) AND CAST(@endDate AS DATE) 
                    ORDER BY date_received DESC"
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand(query, connection)
                cmd.Parameters.AddWithValue("@startDate", startDate.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@endDate", endDate.AddHours(23).AddMinutes(59).AddSeconds(59).ToString("yyyy-MM-dd HH:mm:ss"))
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_supplier_deliveries.DataSource = dt
                'grid_supplier_deliveries_view.BestFitColumns()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        grid_supplier_deliveries.ShowRibbonPrintPreview()
        Log_Export("Exported Supplier delivery logs.", frm_main.lbl_user_id.Text)
    End Sub

    Private Sub grid_supplier_deliveries_view_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles grid_supplier_deliveries_view.CellValueChanged
        If e.Column.Name = col_timestamp.Name Then
            If MsgBox("Press 'Yes' to confirm changes.", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
                Try
                    Using conn = New MySqlConnection(str)
                        conn.Open()
                        Using cmd = New MySqlCommand("UPDATE ims_deliveries SET date_received=@date_received WHERE reference=@ref", conn)
                            cmd.Parameters.AddWithValue("@ref", grid_supplier_deliveries_view.GetFocusedRowCellValue(col_id))
                            cmd.Parameters.AddWithValue("@date_received", CDate(e.Value))
                            cmd.ExecuteNonQuery()
                        End Using
                    End Using
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical, "Error")
                End Try
            End If
        End If
    End Sub

    'btn_view
    Private Sub btn_view_Click_1(sender As Object, e As EventArgs) Handles btn_view.Click
        LoadDelivered(dt_start.EditValue, dt_end.EditValue)
    End Sub
End Class