Imports MySqlConnector

Public Class frm_purchaseorder_purchase_request_list


    'FORM : LOAD
    Private Sub frm_purchaseorder_purchase_request_list_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Purchase_Requests()
        If Not (frm_main.lbl_user_role_id.Text = "1" Or frm_main.lbl_user_role_id.Text = "3") Then
            col_action.Visible = False
        End If
    End Sub




    '--- FUNCTIONS

    Private Sub Load_Purchase_Requests()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT ims_purchase_request_items.id, ims_purchase_request_items.pid, qty, inv.winmodel,  
                                            inv.description, ims_users.first_name requested_by,  ims_suppliers.supplier, ims_purchase_request.date_request
                                            FROM ims_purchase_request_items 
                                            INNER JOIN ims_purchase_request ON ims_purchase_request.pr_id=ims_purchase_request_items.pr_id
                                            INNER JOIN ims_inventory inv ON inv.pid=ims_purchase_request_items.pid
                                            INNER JOIN ims_suppliers ON ims_suppliers.id=ims_purchase_request_items.supplier_id
                                            INNER JOIN ims_users ON ims_users.usr_id=ims_purchase_request.requested_by
                                            WHERE is_completed=0", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_purchase_request.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub




    '---- CONTROLS AND EVENTS

    'BUTTON : NEW
    Private Async Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        Await frm_main.LoadFrm(New frm_purchaseorder_purchase_request_new, "frm_purchaseorder_purchase_request_new")
    End Sub

    'BUTTON : DONE
    Private Sub btn_done_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_done.ButtonClick
        If MsgBox("Mark as 'Done'?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
            Try
                Using conn = New MySqlConnection(str)
                    conn.Open()
                    Using cmd = New MySqlCommand("UPDATE ims_purchase_request_items SET is_completed='1', completed_by=@completed_by WHERE id=@id", conn)
                        cmd.Parameters.AddWithValue("@id", grid_purchase_request_view.GetFocusedRowCellValue(col_pr_id))
                        cmd.Parameters.AddWithValue("@completed_by", frm_main.lbl_user_id.Text)
                        If cmd.ExecuteNonQuery > 0 Then
                            MsgBox("Success!", vbInformation, "Information")
                            Load_Purchase_Requests()
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

End Class