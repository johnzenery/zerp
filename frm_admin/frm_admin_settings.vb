Imports MySqlConnector

Public Class frm_admin_settings

    '--- ONLOAD ----
    Private Sub frm_settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_store_info()
    End Sub





    '--- FUNCTIONS ----
    Private Sub load_store_info()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                'GET Company Name
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='store_name'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            txt_company_name.Text = result("value")
                        End While
                    End Using
                End Using

                'GET COMPANY's Information
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='store_info'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            txt_company_info.Text = result("value")
                        End While
                    End Using
                End Using

                'GET BILLING's Payment Option Info
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='payment_option_info'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            me_payment_option_info.EditValue = result("value")
                        End While
                    End Using
                End Using

                'GET PURCHASING's Pullout Request Instruction
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='pullout_instruction'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            txt_pullout_instruction.EditValue = result("value")
                        End While
                    End Using
                End Using

                'GET Tax Rate
                Using cmd = New MySqlCommand("SELECT value FROM ims_settings WHERE name='tax_rate'", connection)
                    Using result = cmd.ExecuteReader
                        While result.Read
                            txt_tax_rate.EditValue = result("value")
                        End While
                    End Using
                End Using

                'GET Tax Code
                Using cmd = New MySqlCommand("SELECT * FROM ims_tax_code", connection)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    grid_tax_code.DataSource = dt
                    'grid_tax_code_view.BestFitColumns()
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub



    'btn_save
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Dim tax_rate As Integer = txt_tax_rate.Text.Trim
                Dim cmd = New MySqlCommand("UPDATE ims_settings SET value=@company_info WHERE name='store_info'; 
                                            UPDATE ims_settings SET value=@company_name WHERE name='store_name';
                                            UPDATE ims_settings SET value=@payment_option_info WHERE name='payment_option_info';
                                            UPDATE ims_settings SET value=@tax_rate WHERE name='tax_rate';
                                            UPDATE ims_settings SET value=@pullout_instruction WHERE name='pullout_instruction'", connection)
                cmd.Parameters.AddWithValue("@company_name", txt_company_name.Text.Trim)
                cmd.Parameters.AddWithValue("@company_info", txt_company_info.Text.Trim)
                cmd.Parameters.AddWithValue("@payment_option_info", me_payment_option_info.EditValue)
                cmd.Parameters.AddWithValue("@pullout_instruction", txt_pullout_instruction.EditValue)
                cmd.Parameters.AddWithValue("@tax_rate", tax_rate)

                If cmd.ExecuteNonQuery() > 0 Then
                    'SET TAX RATE
                    VAT_percentage = (tax_rate / 100) + 1

                    MsgBox("Updated Successfullly!", vbInformation, "Success")
                End If

                connection.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    Private Sub nav_documents_SelectedPageChanged(sender As Object, e As DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs) Handles nav_documents.SelectedPageChanged
        If e.Page.Caption = nav_documents.Text Then
            load_store_info()
        End If
    End Sub

    'UPDATE Tax UPON SUBMIT
    Private Sub grid_tax_code_view_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles grid_tax_code_view.RowUpdated
        Dim tax_id As String = grid_tax_code_view.GetFocusedRowCellValue(col_tax_id)
        Dim tax_code As String = grid_tax_code_view.GetFocusedRowCellValue(col_tax_code)
        Dim tax_rate As String = grid_tax_code_view.GetFocusedRowCellValue(col_tax_rate)
        Dim desc As String = grid_tax_code_view.GetFocusedRowCellValue(col_description)

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                Using cmd = New MySqlCommand("UPDATE ims_tax_code 
                                            SET tax_code=@tax_code, description=@desc, tax_rate=@tax_rate 
                                            WHERE tax_id=@tax_id", connection)
                    cmd.Parameters.AddWithValue("@tax_id", tax_id)
                    cmd.Parameters.AddWithValue("@tax_code", tax_code)
                    cmd.Parameters.AddWithValue("@tax_rate", tax_rate)
                    cmd.Parameters.AddWithValue("@desc", desc)
                    If cmd.ExecuteNonQuery > 0 Then
                        MsgBox("Updated!", vbInformation, "Information")
                    End If
                End Using
                connection.Close()
                End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class