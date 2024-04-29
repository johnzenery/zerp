Imports MySqlConnector

Public Class frm_admin_banks

    '--- ONLOAD----
    Private Sub frm_admin_banks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBankList()
        LoadTerminalList()
    End Sub



    '--- FUNCTIONS ----

    'LOAD BANKS
    Private Sub LoadBankList()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'DEBIT
                Using cmd = New MySqlCommand("SELECT * FROM ims_banks", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_banks.DataSource = dt
                    grid_banks_view.BestFitColumns()
                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'LOAD BANKS
    Private Sub LoadTerminalList()
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                'DEBIT
                Using cmd = New MySqlCommand("SELECT terminal_id, terminal_name, ims_banks.fund_name AS assigned_fund_name 
                                              FROM ims_cc_terminals
                                              LEFT JOIN ims_banks ON ims_banks.bank_id=ims_cc_terminals.assigned_fund_id
                                              WHERE is_deleted=0", conn)
                    cmd.ExecuteNonQuery()
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_terminal.DataSource = dt
                End Using

            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'btn_add
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_new_bank.Click
        Dim frm = New frm_admin_banks_new
        If frm.ShowDialog() = DialogResult.OK Then
            LoadBankList()
        End If
    End Sub

    'btn_edit
    Private Sub btn_edit_debit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_edit.ButtonClick
        Dim frm = New frm_admin_banks_new
        frm.Text = "Edit Bank Details"
        frm.lbl_title.Text = "Edit Bank Details"
        frm.lbl_id.Text = grid_banks_view.GetFocusedRowCellValue(col_id_debit)
        frm.txt_bank_no.Text = grid_banks_view.GetFocusedRowCellValue(col_bank_acc_debit).ToString
        frm.txt_bank_name.Text = grid_banks_view.GetFocusedRowCellValue(col_bank_name_debit).ToString
        frm.txt_fund_name.Text = grid_banks_view.GetFocusedRowCellValue(col_fund_name_debit).ToString
        frm.cb_debit.EditValue = grid_banks_view.GetFocusedRowCellValue(col_is_debit)
        frm.cb_credit.EditValue = grid_banks_view.GetFocusedRowCellValue(col_is_credit)
        frm.toggle_status.EditValue = grid_banks_view.GetFocusedRowCellValue(col_status_debit)
        frm.cbb_account_type.EditValue = grid_banks_view.GetFocusedRowCellValue(col_account_type)

        frm.old_bank_no = grid_banks_view.GetFocusedRowCellValue(col_bank_acc_debit).ToString
        frm.old_bank_name = grid_banks_view.GetFocusedRowCellValue(col_bank_name_debit).ToString

        If frm.ShowDialog() = DialogResult.OK Then
            LoadBankList()
        End If

    End Sub

    'BUTTON : NEW TERMINAL
    Private Sub btn_new_terminal_Click(sender As Object, e As EventArgs) Handles btn_new_terminal.Click
        Dim frm = New frm_admin_ccterminal_new
        frm.btn_delete.Visible = False
        If frm.ShowDialog = DialogResult.OK Then
            LoadTerminalList()
        End If
    End Sub

    'BUTTON : VIEW (TERMINAL)
    Private Sub btn_terminal_view_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles btn_terminal_view.ButtonClick
        Dim frm = New frm_admin_ccterminal_new
        frm.Text = "Edit Terminal"
        frm.txt_terminal_id.Text = grid_terminal_view.GetFocusedRowCellValue(col_terminal_id)
        frm.txt_terminal_name.Text = grid_terminal_view.GetFocusedRowCellValue(col_terminal_name)
        frm.assigned_fund_name = grid_terminal_view.GetFocusedRowCellValue(col_assigned_credit_fund)
        If frm.ShowDialog = DialogResult.OK Then
            LoadTerminalList()
        End If
    End Sub

End Class