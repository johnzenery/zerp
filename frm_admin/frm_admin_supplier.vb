Imports DevExpress.XtraEditors
Imports MySqlConnector

Public Class frm_admin_supplier


    'On Load
    Private Sub frm_supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Supppliers()
    End Sub




    '--- FUNCTIONS ---

    'Load Suppliers
    Public Sub Load_Supppliers()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET SUPPLIER DETAILS
                Using cmd = New MySqlCommand("SELECT * FROM ims_suppliers", connection)
                    cmd.ExecuteNonQuery()

                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_supplier.DataSource = dt
                    grid_supplier_view.BestFitColumns()
                End Using

                'SET TAX CODE TO CBB
                Using cmd = New MySqlCommand("SELECT tax_code FROM ims_tax_code", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_tax_code.Items.Add(rdr("tax_code"))
                        End While
                    End Using
                End Using

                connection.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub



    '--- CONTROLS ---

    'btn_add
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        frm_admin_supplier_add.ShowDialog()
        Load_Supppliers()
    End Sub


    'Updating Rows
    Private Sub gridview_supplier_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grid_supplier_view.RowUpdated

        If MsgBox("Save changes?", vbQuestion + vbYesNo, "Confirmation") = vbYes Then
            Try
                Using connection = New MySqlConnection(str)
                    connection.Open()
                    Dim cmd = New MySqlCommand("UPDATE ims_suppliers SET supplier=@supplier, 
                            office_addr=@office_addr, warehouse_addr=@warehouse_addr, acc_name=@acc_name, acc_no=@acc_no,
                            contact_person=@contact_person, position=@position, zip_code=@zip_code, tin_no=@tin_no,
                            tel_no=@tel_no, mobile_no=@mobile_no, fax_no=@fax_no, email=@email, lead_time=@lead_time, terms=@terms, bank=@bank,
                            is_with_tax=@is_with_tax, tax_atc=@tax_atc, tax_rate=@tax_rate
                            WHERE id=@supplierID", connection)
                    With grid_supplier_view
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

                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Successfully Updated!", vbInformation + vbOKOnly, "Information")
                    End If
                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try
        End If
    End Sub

    Private Sub cbb_tax_code_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbb_tax_code.SelectedValueChanged

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim cbb = TryCast(sender, ComboBoxEdit)

                Using cmd = New MySqlCommand($"SELECT tax_rate 
                                FROM ims_tax_code 
                                WHERE tax_code=@taxCode", conn)
                    cmd.Parameters.AddWithValue("@taxCode", cbb.EditValue)
                    grid_supplier_view.SetFocusedRowCellValue(col_tax_rate, cmd.ExecuteScalar)
                End Using

                conn.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

End Class