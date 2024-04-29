Imports MySqlConnector

Public Class frm_collection_SelectFromBilling_dialog

    Public ccdata As CollectionChequeData

    '--- ON LOAD ---

    Private Sub frm_collection_SelectFromSOA_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    '--- FUNCTIONS ---

    'Load Data to Grid
    Private Sub LoadData()
        Dim customer_id As Integer = ccdata.customer_id
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cmd = New MySqlCommand("SELECT concat('BS',LPAD(soa_id,5,0)) as soa_id, ims_customers.first_name as customer, ims_customers.customer_id, print_date, total 
                            FROM ims_soa
                            INNER JOIN ims_customers ON ims_customers.customer_id=ims_soa.customer_id
                            WHERE ims_soa.is_deleted=0 " & IIf(customer_id = 0, "", "AND ims_soa.customer_id=" & customer_id) & "
                            ORDER BY soa_id DESC", conn)
                cmd.ExecuteNonQuery()

                Dim dt = New DataTable
                Dim da = New MySqlDataAdapter(cmd)
                da.Fill(dt)

                grid_soa.DataSource = dt
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_select_Click(sender As Object, e As EventArgs) Handles btn_select.Click
        ccdata.billing_id = grid_soa_view.GetFocusedRowCellValue(col_soa_id).ToString.Replace("BS", String.Empty)
        ccdata.customer_name = grid_soa_view.GetFocusedRowCellValue(col_customer)
        ccdata.customer_id = grid_soa_view.GetFocusedRowCellValue(col_customer_id)
    End Sub
End Class