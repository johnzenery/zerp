Imports MySqlConnector

Public Class frm_admin_banks

    '--- ONLOAD----
    Private Sub frm_admin_banks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBankList()
    End Sub



    '--- FUNCTIONS ----

    'LOAD BANKS
    Private Sub LoadBankList()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT * FROM ims_banks", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_bank.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim frm = New frm_admin_banks_new
        If frm.ShowDialog() = DialogResult.OK Then
            LoadBankList()
            MsgBox("Added Successfully!", vbInformation, "Information")
        End If
    End Sub

    'btn_edit
    Private Sub btn_edit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick
        Dim frm = New frm_admin_banks_new
        frm.Text = "Edit Bank Details"
        frm.lbl_title.Text = "Edit Bank Details"
        frm.lbl_id.Text = grid_bank_view.GetFocusedRowCellValue(col_id)
        frm.txt_bank_no.Text = grid_bank_view.GetFocusedRowCellValue(col_bank_acc)
        frm.txt_bank_name.Text = grid_bank_view.GetFocusedRowCellValue(col_bank_name)
        frm.toggle_status.EditValue = grid_bank_view.GetFocusedRowCellValue(col_status)

        If frm.ShowDialog() = DialogResult.OK Then
            LoadBankList()
            MsgBox("Saved Successfully!", vbInformation, "Information")
        End If

    End Sub
End Class