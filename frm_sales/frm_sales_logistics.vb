Imports MySqlConnector

Public Class frm_sales_logistics

    '--- ONLOAD ---
    Private Sub frm_sales_logistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_logistics()
    End Sub




    '--- FUNCTIONS ----
    Private Sub Load_logistics()
        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("SELECT * FROM ims_logistics WHERE is_deleted='0'", connection)
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_logistics.DataSource = dt

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub




    '--- CONTROLS ----

    'btn_new_logistics
    Private Sub btn_new_logistics_Click(sender As Object, e As EventArgs) Handles btn_new_logistics.Click
        Me.Dispose()
        frm_sales_logistics_new.ShowDialog()
    End Sub

    'btn_view
    Private Sub btn_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_view.ButtonClick
        Dim frm = New frm_sales_logistics_new
        With grid_logistics_view
            frm.Text = .GetFocusedRowCellValue(col_logistics_contact)
            'frm.title.Text = "Logistic Details"

            frm.id.Text = .GetFocusedRowCellValue(col_id)
            frm.txt_name.Text = .GetFocusedRowCellValue(col_name)
            frm.txt_contact.Text = .GetFocusedRowCellValue(col_logistics_contact)
            frm.txt_contact_no.Text = .GetFocusedRowCellValue(col_logistics_contact_no)
            frm.txt_nearest.Text = .GetFocusedRowCellValue(col_nearest_branch)
            frm.txt_destinations.Text = .GetFocusedRowCellValue(col_logistics_destination)

            frm.btn_cancel.Visible = False
            frm.btn_new.Visible = False

        End With
        frm.ShowDialog()
        Load_logistics()
    End Sub

    'btn_edit
    Private Sub btn_edit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick
        Dim frm = New frm_sales_logistics_new
        With grid_logistics_view
            frm.Text = .GetFocusedRowCellValue(col_logistics_contact)
            'frm.title.Text = "Edit Logistic Details"

            frm.id.Text = .GetFocusedRowCellValue(col_id)
            frm.txt_name.Text = .GetFocusedRowCellValue(col_name)
            frm.txt_contact.Text = .GetFocusedRowCellValue(col_logistics_contact)
            frm.txt_contact_no.Text = .GetFocusedRowCellValue(col_logistics_contact_no)
            frm.txt_nearest.Text = .GetFocusedRowCellValue(col_nearest_branch)
            frm.txt_destinations.Text = .GetFocusedRowCellValue(col_logistics_destination)

            frm.btn_new.Text = "Update"

        End With
        frm.ShowDialog()
        Load_logistics()
    End Sub

    Private Sub btn_delete_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_delete.ButtonClick

        Dim ans = MsgBox("Press 'YES' to delete.", vbExclamation + vbYesNo, "Confirmation")
        If Not ans = vbYes Then Exit Sub

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Using cmd = New MySqlCommand("UPDATE ims_logistics SET is_deleted='1' WHERE logistics_id=@id", connection)
                    cmd.Parameters.AddWithValue("@id", grid_logistics_view.GetFocusedRowCellValue(col_id))
                    cmd.ExecuteNonQuery()

                    MsgBox("Deleted Successfully!", vbInformation, "Information")

                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

        Load_logistics()
    End Sub

End Class