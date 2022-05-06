Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_collection_soa

    ReadOnly conn As New MySqlConnection(str)

    '--- ONLOAD ---
    Private Sub frm_collection_soa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub




    '--- FUNCTIONS ---

    'Load Data to Grid
    Private Sub LoadData()
        Try
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT concat('SA',LPAD(soa_id,5,0)) as soa_id, ims_customers.first_name as customer, print_date, total, ims_users.first_name as prepared_by FROM ims_soa
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_soa.customer_id
                            INNER JOIN ims_users ON ims_users.usr_id=prepared_by 
                            WHERE ims_soa.is_deleted=0
                            ORDER BY soa_id DESC", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_soa.DataSource = dt

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub

    'Print SOA
    Private Sub PrintSOA(soa_id As Integer)

        Try
            Dim report = New doc_soa()
            Dim printTool = New ReportPrintTool(report)
            Dim table = New PrintData

            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("SELECT date_released, DATE_ADD(date_released, INTERVAL ims_orders.terms DAY) AS due_date,
                        CONCAT('SO',LPAD(order_id,5,0)) AS order_id, amount_due, po_reference 
                        FROM ims_orders
                        INNER JOIN ims_customers ON ims_customers.customer_id=ims_orders.customer 
                        WHERE soa_id=@soa_id", connection)
                    cmd.Parameters.AddWithValue("@soa_id", soa_id)

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            table.soa.Rows.Add(rdr("order_id"), rdr("date_released"), rdr("due_date"), rdr("amount_due"), rdr("po_reference"))
                        End While
                    End Using

                    report.DataSource = table

                End Using


                Using get_soa_details = New MySqlCommand("SELECT concat('SA',LPAD(soa_id,5,0)) as soa, ims_customers.first_name as customer, ims_customers.address, 
                            ims_customers.contact_person, print_date, total, ims_users.first_name as prepared_by,
                            (SELECT VALUE FROM ims_settings WHERE NAME='store_name') AS store_name, 
                            (SELECT value FROM ims_settings WHERE name='store_info') as store_info 
                            FROM ims_soa
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_soa.customer_id
                            INNER JOIN ims_users ON ims_users.usr_id=prepared_by
                            WHERE soa_id=@soa_id", connection)
                    get_soa_details.Parameters.AddWithValue("@soa_id", soa_id)

                    Using reader = get_soa_details.ExecuteReader
                        While reader.Read
                            report.Parameters("store_name").Value = reader("store_name")
                            report.Parameters("store_info").Value = reader("store_info")
                            report.Parameters("soa_id").Value = "SA" & soa_id.ToString.PadLeft(5, "0"c)
                            report.Parameters("customer").Value = reader("customer")
                            report.Parameters("attn").Value = reader("contact_person")
                            report.Parameters("print_date").Value = reader("print_date")
                            report.Parameters("addr").Value = reader("address")
                            report.Parameters("prepared_by").Value = reader("prepared_by")
                            report.Parameters("total").Value = reader("total")
                        End While
                    End Using

                    printTool.AutoShowParametersPanel = False
                    printTool.ShowRibbonPreviewDialog()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub




    '--- CONTROLS ---



    'btn_new |  Show SOA Generator
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Dim frm = frm_collection_soa_new
        frm.Show()
    End Sub

    'btn_print | Show Print Dialog
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        Dim SelectedRows = grid_soa_view.GetSelectedRows

        If Not SelectedRows.Length = 0 Then
            Dim soa_id = CInt(grid_soa_view.GetFocusedRowCellValue(col_soa_id).ToString.Replace("SA", ""))
            PrintSOA(soa_id)
        End If

    End Sub
End Class