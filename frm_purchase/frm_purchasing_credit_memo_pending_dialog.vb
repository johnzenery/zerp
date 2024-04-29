Imports MySqlConnector

Public Class frm_purchasing_credit_memo_pending_dialog

    Public Property supplier As String
    Public Property is_filtered As Boolean = False

    '--- ONLOAD ---
    Private Sub frm_purchasing_credit_memo_pending_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCredits()
    End Sub

    '--- FUNCTIONS ---
    Private Sub LoadCredits()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim query = "SELECT rs_returns_deliveries.id, rs_returns_deliveries.rid, rs_returns_deliveries.qty_received,
                                    ims_inventory.winmodel, ims_inventory.description,
                                    credit_cost, rs_returns_deliveries.status, rs_returns_deliveries.delivery_ref, ims_suppliers.supplier
                             FROM rs_returns_deliveries 
                             INNER JOIN rs_returns ON rs_returns.id=rs_returns_deliveries.rid
                             INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                             INNER JOIN ims_suppliers ON ims_suppliers.id=rs_returns.supplier_id
                             WHERE rs_returns_deliveries.status='Pending for Credit'"

                If is_filtered = True Then
                    query += " AND ims_suppliers.supplier=@supplier"
                End If

                Using cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@supplier", supplier)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_pending_credits.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class