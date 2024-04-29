
Imports MySqlConnector

Public Class ctl_collection_cashier_register_pay

    Public _banks(,) As String

    '---- FUNCTIONS





    '---- EVENTS

    'BUTTON : DELETE
    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Me.Dispose()
    End Sub

    'RADIO GROUP : PAYMENT
    Private Sub rg_payment_type_EditValueChanged(sender As Object, e As EventArgs) Handles rg_payment_type.EditValueChanged
        g_cheque.Visible = False
        g_epay.Visible = False
        g_card.Visible = False
        g_cheque.Height = 0
        cbb_fund.Enabled = True

        Select Case rg_payment_type.EditValue
            Case "Cash"
                Me.Height = 88
            Case "E-Payment"
                g_epay.Visible = True
                g_epay.Location = g_cheque.Location
                Me.Height = 170
            Case "Cheque"
                g_cheque.Visible = True
                g_cheque.Height = 127
                Me.Height = 220
            Case "Credit Card"
                g_card.Visible = True
                g_card.Location = g_cheque.Location
                g_card.Height = 100
                Me.Height = 192
                cbb_fund.Enabled = False
        End Select
    End Sub

    Private Sub cbb_bank_Properties_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_bank.Properties.SelectedIndexChanged
        Dim index As Integer = cbb_bank.SelectedIndex
        txt_acc_no.Text = _banks(index, 1)
        txt_acc_name.Text = _banks(index, 2)
    End Sub

    Private Sub cbb_terminal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbb_terminal.SelectedIndexChanged
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT fund_name FROM ims_cc_terminals 
                                              INNER JOIN ims_banks ON ims_banks.bank_id=ims_cc_terminals.assigned_fund_id
                                              WHERE terminal_name=@terminal", conn)
                    cmd.Parameters.AddWithValue("@terminal", cbb_terminal.EditValue)
                    Using rdr = cmd.ExecuteReader
                        rdr.Read()
                        If rdr.HasRows Then
                            cbb_fund.EditValue = rdr("fund_name")
                        Else
                            MsgBox("Assigned fund ID not found!", vbCritical, "Not found")
                        End If
                    End Using
                End Using
                conn.Close()
                End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub
End Class
