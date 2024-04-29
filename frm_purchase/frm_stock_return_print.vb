Imports DevExpress.XtraReports.UI
Imports MySqlConnector

Public Class frm_stock_return_print

    ReadOnly conn As New MySqlConnection(str)
    Private Property accessories As String
    Private Property issue As String

    '--- FUNCTIONS ---

    'PRINT TAGS : SINGLE UNIT
    Public Sub PrintTag(rid As Integer, qty As Integer)
        Try
            conn.Open()
            Dim report As New doc_return_tag
            Dim printTool = New ReportPrintTool(report)
            Dim dt = New DataTable

            Using cmd = New MySqlCommand("SELECT id, ims_inventory.supmodel, rs_returns.type, serial, accessories, issue
                                          FROM rs_returns 
                                          INNER JOIN ims_inventory ON ims_inventory.pid=rs_returns.pid
                                          WHERE id=@rid", conn)
                cmd.Parameters.AddWithValue("@rid", rid)
                Using rdr = cmd.ExecuteReader
                    While rdr.Read
                        For i = 1 To qty
                            Dim sub_report As New doc_return_tag
                            sub_report.Parameters("RID").Value = rdr("id").ToString
                            sub_report.Parameters("model").Value = rdr("supmodel")
                            sub_report.Parameters("type").Value = rdr("type")
                            sub_report.Parameters("serial").Value = rdr("serial")
                            sub_report.Parameters("accessories").Value = rdr("accessories")
                            sub_report.Parameters("issue").Value = rdr("issue")
                            sub_report.CreateDocument()

                            report.Pages.AddRange(sub_report.Pages)
                        Next
                    End While
                End Using
            End Using


            report.ShowRibbonPreviewDialog()

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        Finally
            conn.Close()
        End Try
    End Sub





    '--- CONTROLS / EVENTS ----

    'BUTTON : PRINT
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click

        If Not (String.IsNullOrWhiteSpace(txt_rid.EditValue) Or String.IsNullOrWhiteSpace(se_qty.EditValue)) Then
            Dim rid As Integer = txt_rid.EditValue
            Dim qty As Integer = se_qty.EditValue
            PrintTag(rid, qty)
        Else
            MsgBox("Incomplete fields!", vbCritical, "Required")
        End If

    End Sub

    'BUTTON : CANCEL
    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        Me.Close()
    End Sub
End Class