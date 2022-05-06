Imports MySqlConnector

Public Class frm_admin_supplier

    ReadOnly conn As New MySqlConnection(str)


    'On Load
    Private Sub frm_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Supppliers()
    End Sub




    '--- FUNCTIONS ---

    'Load Suppliers
    Public Sub Load_Supppliers()

        Try

            conn.Open()
            Dim query = "SELECT * FROM ims_suppliers"

            Dim cmd = New MySqlCommand(query, conn)
            cmd.ExecuteNonQuery()

            Dim dt = New DataTable
            Dim da = New MySqlDataAdapter(cmd)
            da.Fill(dt)

            grid_supplier.DataSource = dt
            gridview_supplier.BestFitColumns()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub



    '--- CONTROLS ---

    'btn_add
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_admin_supplier_add.ShowDialog()
        Load_Supppliers()
    End Sub


    'Updating Rows
    Private Sub gridview_supplier_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gridview_supplier.RowUpdated

        Try
            conn.Open()

            Dim cmd = New MySqlCommand("UPDATE ims_suppliers SET supplier=@supplier, 
                            office_addr=@office_addr, warehouse_addr=@warehouse_addr, acc_name=@acc_name, acc_no=@acc_no,
                            contact_person=@contact_person, position=@position, zip_code=@zip_code, tin_no=@tin_no,
                            tel_no=@tel_no, mobile_no=@mobile_no, fax_no=@fax_no, email=@email, lead_time=@lead_time, terms=@terms, bank=@bank,
                            is_with_tax=@is_with_tax, tax_atc=@tax_atc, tax_rate=@tax_rate
                            WHERE id=@supplierID", conn)
            With gridview_supplier
                cmd.Parameters.AddWithValue("@supplierID", .GetFocusedRowCellValue(col_supid))
                cmd.Parameters.AddWithValue("@supplier", .GetFocusedRowCellValue(col_supplier_name))
                cmd.Parameters.AddWithValue("@office_addr", .GetFocusedRowCellValue(col_office_addr))
                cmd.Parameters.AddWithValue("@warehouse_addr", .GetFocusedRowCellValue(col_warehouse_addr))
                cmd.Parameters.AddWithValue("@zip_code", .GetFocusedRowCellValue(col_zip_code))
                cmd.Parameters.AddWithValue("@tin_no", .GetFocusedRowCellValue(col_tin_no))
                cmd.Parameters.AddWithValue("@bank", .GetFocusedRowCellValue(col_bank))
                cmd.Parameters.AddWithValue("@acc_name", .GetFocusedRowCellValue(col_acc_name))
                cmd.Parameters.AddWithValue("@acc_no", .GetFocusedRowCellValue(col_acc_nos))
                cmd.Parameters.AddWithValue("@contact_person", .GetFocusedRowCellValue(col_contact_person))
                cmd.Parameters.AddWithValue("@position", .GetFocusedRowCellValue(col_position))
                cmd.Parameters.AddWithValue("@tel_no", .GetFocusedRowCellValue(col_tel_no))
                cmd.Parameters.AddWithValue("@mobile_no", .GetFocusedRowCellValue(col_mobile_no))
                cmd.Parameters.AddWithValue("@fax_no", .GetFocusedRowCellValue(col_fax_no))
                cmd.Parameters.AddWithValue("@email", .GetFocusedRowCellValue(col_email))
                cmd.Parameters.AddWithValue("@lead_time", .GetFocusedRowCellValue(col_lead_time))
                cmd.Parameters.AddWithValue("@terms", .GetFocusedRowCellValue(col_terms))
                cmd.Parameters.AddWithValue("@is_with_tax", .GetFocusedRowCellValue(col_is_with_tax))
                cmd.Parameters.AddWithValue("@tax_atc", .GetFocusedRowCellValue(col_atc))
                cmd.Parameters.AddWithValue("@tax_rate", .GetFocusedRowCellValue(col_tax_rate))
            End With


            Dim inserted = cmd.ExecuteNonQuery

            If inserted >= 1 Then MsgBox("Successfully Updated!", vbInformation + vbOKOnly, "Information")

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try

    End Sub


End Class