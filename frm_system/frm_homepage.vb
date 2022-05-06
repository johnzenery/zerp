Imports System.Text.RegularExpressions
Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_homepage
    Private Sub frm_homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_welcome.Text = "Yehey! Welcome back " & frm_main.user_name.Text
        get_welcome_message()
    End Sub

    'Welcome Message
    Private Sub get_welcome_message()

        Dim msg = {
        {"Dale Carnegie", ""“Do the hard jobs first. The easy jobs will take care of themselves.”""},
        {"Dalai Lama", ""“Don't wish it were easier. Wish you were better.”""},
        {"Mahatma Gandhi", ""“The future depends on what you do today.”""},
        {"Confucius", ""“The man who moves a mountain begins by carrying away small stones.”""},
        {"Abraham Lincoln", ""“Things may come to those who wait, but only the things left by those who hustle.”""},
        {"Saint Francis", ""“Start by doing what’s necessary, then what’s possible; and suddenly you are doing the impossible.”""},
        {"Dale Carnegie", ""“People rarely succeed unless they have fun in what they are doing.”""},
        {"Irish Proverb", ""“You will never plough a field if you only turn it over in your mind.”""},
        {"Napoleon Hill", ""“Don't wait. The time will never be just right.”""},
        {"Martin Luther King, Jr.", ""“You don’t have to see the whole staircase, just take the first step.”""},
        {"Albert Einstein", ""“Try not to become a person of success, but rather try to become a person of value.”""},
        {"Joseph Barbara", ""“Happiness is the real sense of fulfillment that comes from hard work.”""},
        {"Seneca", ""“Luck is a matter of preparation meeting opportunity.”""},
        {"Bruce Lee", ""“It is not a daily increase, but a daily decrease. Hack away at the inessentials.”""}
            }

        Dim rnd = New Random
        Dim i = rnd.Next(1, msg.Length / 2)
        txt_quotes.Text = msg(i, 1) & vbCrLf & "- " & msg(i, 0)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Dim comma(), equal() As String
                Dim piece As String
                Dim j As Integer
                Dim colonseparator As New Regex("\b;\b")
                Dim equalseparator As New Regex("\b=\b")
                Dim units = String.Empty, poid = String.Empty, status = String.Empty
                Dim ListOfOrders = New List(Of PurchaseOrderClass)
                Dim dt = New DataTable

                Using cmd = New MySqlCommand("SELECT purchase_id, status, orders FROM ims_purchase WHERE purchase_id BETWEEN @begin AND @end", conn)
                    cmd.Parameters.AddWithValue("@begin", txt_begin.Text)
                    cmd.Parameters.AddWithValue("@end", txt_end.Text)
                    'Using rdr = cmd.ExecuteReader
                    '    While rdr.Read
                    '        poid = rdr("purchase_id")
                    '        status = rdr("status")
                    '        units = rdr("backup_orders")
                    '    End While
                    'End Using
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                    DataGridView1.DataSource = dt
                End Using

                For i = 0 To dt.Rows.Count - 1

                    comma = colonseparator.Split(dt.Rows(i).Item(2))

                    For j = 0 To comma.Length - 1
                        piece = comma(j).Trim
                        equal = piece.Split("=")
                        Dim received_qty = 0

                        Select Case dt.Rows(i).Item(1)
                            Case "Pending", "Rejected (Sent)", "Approved", "Unfinished", "For Approval", "For Re-approval", "Rejected", "Sent" : received_qty = 0
                            Case "Partial", "Completed", "Obsolete", "Rejected (Partial)", "UNKNOWN STATUS"

                                Using cmd = New MySqlCommand("SELECT SUM(qty) AS qty FROM ims_deliveries WHERE item=@item AND purchase_id=@poid", conn)
                                    cmd.Parameters.AddWithValue("poid", dt.Rows(i).Item(0))
                                    cmd.Parameters.AddWithValue("item", equal(0))
                                    Using rdr = cmd.ExecuteReader
                                        rdr.Read()
                                        received_qty = IIf(IsDBNull(rdr("qty")), 0, rdr("qty"))
                                    End Using
                                End Using

                        End Select

                        ListOfOrders.Add(New PurchaseOrderClass With {
                        .pid = equal(0),
                        .qty = equal(1),
                        .winmodel = equal(2),
                        .supmodel = equal(3),
                        .description = equal(4),
                        .cost = equal(5),
                        .total_cost = equal(6).Replace(";", ""),
                        .qty_received = received_qty
                    })
                    Next

                    Using cmd = New MySqlCommand("UPDATE ims_purchase SET new_orders=@orders WHERE purchase_id=@purchase_id", conn)
                        cmd.Parameters.AddWithValue("@orders", JsonConvert.SerializeObject(ListOfOrders))
                        cmd.Parameters.AddWithValue("@purchase_id", dt.Rows(i).Item(0))
                        cmd.ExecuteNonQuery()
                        ListOfOrders.Clear()

                    End Using

                Next

                MsgBox("Done!")
                dt.Rows.Clear()
                DataGridView1.DataSource = dt
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class