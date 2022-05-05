Imports MySql.Data.MySqlClient

Public Class frm_purchaseorder_return_list



    '--- ON LOAD ----

    Private Sub frm_purchaseorder_return_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReturns()
    End Sub




    '--- FUNCTIONS ---

    Private Sub LoadReturns()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT concat('PV',LPAD(po_return_id,5,0)) AS po_return_id, supplier,
                                total_cost, created_at, status, concat('PV',LPAD(p_voucher_id,5,0)) AS voucher_id FROM ims_purchase_returns 
                                LEFT JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_returns.supplier_id 
                                WHERE is_deleted=0 ORDER BY po_return_id DESC", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_returns.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'New Return Button
    Private Sub btn_new_return_Click(sender As Object, e As EventArgs) Handles btn_new_return.Click
        frm_main.LoadFrm(New frm_purchaseorder_return_new)
    End Sub

    'View Purchase Return
    Private Sub btn_view_order_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view_order.ButtonClick
        Dim id As Integer = grid_returns_view.GetFocusedRowCellValue(col_rid).ToString.Replace("PV", "")
        Dim frm = New frm_purchaseorder_return_new
        frm.Show()
        frm.LoadEdit(id)
    End Sub

End Class