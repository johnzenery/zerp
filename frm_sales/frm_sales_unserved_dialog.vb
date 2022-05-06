

Imports MySqlConnector

Public Class frm_sales_unserved_dialog

    '---- DECLARATION -----
    Property cid As Integer = 0

    '---- ONLOAD ---
    Private Sub frm_sales_unserved_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_UservedItems()
    End Sub



    '---- FUNCTIONS -----

    'LOAD UNSERVED ITEMS
    Private Sub Load_UservedItems()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT 
	                                                created_at, qty, winmodel, description, 
	                                                (IF((SELECT COUNT(*) FROM ims_sales WHERE item=US.item AND DATE(purchase_date) >= DATE(US.created_at)) > 0, 'Served', 'Unserved')) item_status
                                                FROM ims_sales_unserved_items US
                                                INNER JOIN ims_inventory ON ims_inventory.pid=US.item
                                                WHERE customer_id=@cid", conn)
                    cmd.Parameters.AddWithValue("@cid", cid)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_unserved.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Dim saveFileDialog = New SaveFileDialog
        saveFileDialog.Filter = "PDF File (*.csv*)|*.csv"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            grid_unserved_view.ExportToCsv(saveFileDialog.FileName)
        End If

    End Sub
End Class