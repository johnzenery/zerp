Imports MySqlConnector
Imports System.Globalization

Public Class frm_admin_supplier_add

    'ONLOAD
    Private Sub frm_admin_supplier_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'Close/Cancel
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub

    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If ValidateFields() Then Exit Sub

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim get_cmd = New MySqlCommand("select count(*) from ims_suppliers", connection)
                Dim supplier_id = get_cmd.ExecuteScalar

                Dim str = "INSERT INTO ims_suppliers (id, supplier, office_addr, warehouse_addr, zip_code, bank, tin_no, acc_name, acc_no, contact_person, position, tel_no, mobile_no, fax_no, email, lead_time, terms, is_with_tax, tax_atc, tax_rate) 
                        VALUES (@id, @supplier, @office_addr, @warehouse_addr, @zip_code, @bank, @tin_no, @acc_name, @acc_no, @contact_person, @position, @tel_no, @mobile_no, @fax_no, @email, @lead_time, @terms, @is_with_tax, @tax_atc, @tax_rate)"
                Dim cmd = New MySqlCommand(str, connection)

                With CultureInfo.CurrentCulture.TextInfo
                    cmd.Parameters.AddWithValue("@id", supplier_id)
                    cmd.Parameters.AddWithValue("@supplier", .ToTitleCase(txt_supname.Text.Trim))
                    cmd.Parameters.AddWithValue("@office_addr", .ToTitleCase(txt_officeadd.Text.Trim))
                    cmd.Parameters.AddWithValue("@warehouse_addr", .ToTitleCase(txt_warehouseadd.Text.Trim))
                    cmd.Parameters.AddWithValue("@zip_code", txt_zipcode.Text)
                    cmd.Parameters.AddWithValue("@tin_no", txt_tin_no.Text)
                    cmd.Parameters.AddWithValue("@bank", .ToTitleCase(txt_bank_name.EditValue.Trim))
                    cmd.Parameters.AddWithValue("@acc_name", .ToTitleCase(txt_acc_name.Text.Trim))
                    cmd.Parameters.AddWithValue("@acc_no", txt_acc_no.Text)
                    cmd.Parameters.AddWithValue("@contact_person", .ToTitleCase(txt_contact.Text.Trim))
                    cmd.Parameters.AddWithValue("@position", .ToTitleCase(txt_position.Text.Trim))
                    cmd.Parameters.AddWithValue("@tel_no", txt_telephone.Text.Trim)
                    cmd.Parameters.AddWithValue("@mobile_no", txt_mobile.Text.Trim)
                    cmd.Parameters.AddWithValue("@fax_no", txt_fax.Text.Trim)
                    cmd.Parameters.AddWithValue("@email", txt_email.Text.Trim.ToLower)
                    cmd.Parameters.AddWithValue("@lead_time", num_lead_days.Value)
                    cmd.Parameters.AddWithValue("@terms", num_terms_days.Value)
                    cmd.Parameters.AddWithValue("@is_with_tax", cb_ewt.Checked)
                    cmd.Parameters.AddWithValue("@tax_atc", txt_atc.Text.Trim)
                    cmd.Parameters.AddWithValue("@tax_rate", txt_tax_rate.Text.Trim)
                End With

                cmd.ExecuteNonQuery()

                MsgBox("New Supplier has been added!", vbInformation + vbOKOnly, "Information")
                Me.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Validation
    Private Function ValidateFields()

        'Supplier Name
        If String.IsNullOrEmpty(txt_supname.Text) Then
            MsgBox("Please fill the required fields.", vbInformation, "Information")
            Return True
        End If

        'Office Add
        If String.IsNullOrEmpty(txt_officeadd.Text) Then
            MsgBox("Please fill the required fields.", vbInformation, "Information")
            Return True
        End If

        'Warehouse Add
        If String.IsNullOrEmpty(txt_warehouseadd.Text) Then
            MsgBox("Please fill the required fields.", vbInformation, "Information")
            Return True
        End If

        'Lead Time
        If Not num_lead_days.Value > 0 Then
            MsgBox("Zero (0) Lead Time is NOT allowed.", vbInformation, "Information")
            Return True
        End If


        Return False

    End Function

    Private Sub txt_tax_rate_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_tax_rate.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class