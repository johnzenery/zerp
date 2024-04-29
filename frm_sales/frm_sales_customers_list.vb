Imports MySqlConnector

Public Class frm_sales_customers_list

    '--- ONLOAD ----
    Private Sub frm_customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub


    '--- FUNCTION ----
    Private Sub LoadGrid()
        Using conn As New MySqlConnection(str)
            conn.Open()
            Dim cmd = New MySqlCommand("SELECT *, (credit_limit - used_credit) AS remaining_credit, ims_users.first_name AS assigned_agents, IF(is_deleted=0, 'Enabled', 'Disabled') AS status
                        FROM ims_customers 
                        LEFT JOIN ims_users ON ims_users.usr_id=assigned_agent", conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_customer.DataSource = dt

        End Using
    End Sub



    '--- CONTROLS ----

    'btn_edit
    Private Sub button_edit_ButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs) Handles button_edit.ButtonClick

        Dim frm = New frm_sales_customers_new

        With gridview_customer
            frm.Text = "Edit Customer Details"
            frm.lbl_title.Text = "Edit Customer Details"
            frm.lbl_customer_id.Text = .GetFocusedRowCellValue(col_id)
            frm.txt_fname.Text = .GetFocusedRowCellValue(col_fname)
            frm.txt_contact_person.Text = .GetFocusedRowCellValue(col_contact_person)
            frm.cbb_account_type.Text = .GetFocusedRowCellValue(col_type)
            frm.txt_contact.Text = .GetFocusedRowCellValue(col_contact)
            frm.txt_address.Text = .GetFocusedRowCellValue(col_addr)
            frm.cbb_shipping.Text = .GetFocusedRowCellValue(col_shipping)
            frm.txt_trucking.Text = .GetFocusedRowCellValue(col_trucking)
            frm.num_terms.Value = .GetFocusedRowCellValue(col_terms)
            frm.cbb_shipping.Text = .GetFocusedRowCellValue(col_shipping)
            frm.cbb_payment_type.EditValue = .GetFocusedRowCellValue(col_payment)
            frm.txt_credit_limit.Text = .GetFocusedRowCellValue(col_credit_limit)
            frm.txt_tin.Text = .GetFocusedRowCellValue(col_tin)
            Dim assigned_agent = .GetFocusedRowCellValue(col_assigned_agents)
            frm.cbb_agents.Text = IIf(IsDBNull(assigned_agent), "Unassigned", assigned_agent)
            frm.LoadSheet(IIf(IsDBNull(.GetFocusedRowCellValue(col_other_notes)), String.Empty, .GetFocusedRowCellValue(col_other_notes)))
            frm.btn_disable_customer.Visible = True
            frm.btn_disable_customer.Text = IIf(.GetFocusedRowCellValue(col_status).Equals("Enabled"), "Disable Customer", "Enable Customer")

            'Access for Admin
            If frm_main.lbl_user_role_id.Text = 1 Or frm_main.lbl_user_role_id.Text = 6 Then
                frm.txt_credit_limit.Enabled = True
                frm.num_terms.Enabled = True
                frm.cbb_account_type.Enabled = True
                frm.cbb_agents.Enabled = True
            End If

        End With

        If frm.ShowDialog() = DialogResult.OK Then
            LoadGrid()
        End If

    End Sub

    'BUTTON : NEW CUSTOMER
    Private Async Sub btn_customer_Click(sender As Object, e As EventArgs) Handles btn_customer.Click
        'frm_sales_customers_new.ShowDialog()
        Await frm_main.LoadFrm(New frm_sales_customers_new, "frm_sales_customers_new")
    End Sub

End Class