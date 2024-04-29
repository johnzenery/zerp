Imports System.Globalization
Imports MySqlConnector

Public Class frm_logistics_delivered_by

    Public Property driver_name As String

    Private Sub frm_logistics_delivered_by_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("SELECT DISTINCT delivered_by FROM ims_orders 
                                              WHERE delivered_by IS NOT NULL", conn)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            cbb_driver.Properties.Items.Add(rdr("delivered_by"))
                        End While
                    End Using
                End Using
                conn.Close()
                End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub btn_submit_Click(sender As Object, e As EventArgs) Handles btn_submit.Click
        If String.IsNullOrWhiteSpace(cbb_driver.EditValue) Then
            driver_name = String.Empty
        Else
            driver_name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(cbb_driver.EditValue)
        End If
        Me.DialogResult = DialogResult.OK
    End Sub

    Private Sub frm_logistics_delivered_by_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Not Me.DialogResult = DialogResult.OK Then
            e.Cancel = True
        End If
    End Sub


End Class