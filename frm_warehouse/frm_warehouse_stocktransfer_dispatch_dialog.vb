Imports DevExpress.XtraReports.UI
Imports MySqlConnector
Imports System.Globalization.CultureInfo
Imports System.Text.RegularExpressions

Public Class frm_warehouse_stocktransfer_dispatch_dialog

    Private total_kgs As Decimal
    Private total_cbm As Decimal


    '--- ONLOAD ---
    Private Sub frm_warehouse_stocktransfer_dispatch_dialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RetrieveData()
        txt_driver.Select()
    End Sub



    '--- FUNCTIONS ---

    'Get Prepare by and Checked by
    Private Sub RetrieveData()
        Try
            Using connect = New MySqlConnection(str)
                connect.Open()

                Using cmd = New MySqlCommand("SELECT prepared_by, checked_by 
                                FROM ims_stock_transfer_sub
                                WHERE sub_transfer_id=" & CInt(txt_transfer_id.Text), connect)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            txt_prepared_by.Text = rdr("prepared_by")
                            txt_count_by.Text = rdr("checked_by")
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Print Sub Transfer
    Public Sub printSubTransfer(stid As Integer, type As String)

        Dim report = New doc_sub_transfer()
        Dim printTool = New ReportPrintTool(report)
        Dim table = New PrintData
        Dim storesInItem() As String = {}
        Dim linkedWarehouse() As String = {}

        Dim items As String = String.Empty, warehouse_name As String = String.Empty

        Try

            Using conn = New MySqlConnection(str)
                conn.Open()

                'Get Common Values
                Using cmd = New MySqlCommand("SELECT sub_transfer_id,
                            root_transfer_id, ims_stock_transfer_sub.transfer_type, ST.public_note,
                            SRC.store_name AS src_store, RECVR.store_name AS recvr_store, 
                            ims_stock_transfer_sub.item, ims_stock_transfer_sub.total_cbm, ims_stock_transfer_sub.total_kgs, ST.created_at,
                            transBy.first_name AS transfer_by, approvedBy.first_name AS approved_by, 
                            prepared_by, checked_by, releasedBy.first_name AS released_by, delivered_by,
                            (SELECT value FROM ims_settings WHERE name='store_name') AS store_name,
                            (SELECT value FROM ims_settings WHERE name='store_info') AS store_info
                            FROM ims_stock_transfer_sub
                            INNER JOIN ims_stock_transfer AS ST ON ST.transfer_id=ims_stock_transfer_sub.root_transfer_id
                            INNER JOIN ims_stores AS SRC ON SRC.store_id=ims_stock_transfer_sub.src_store_id
                            INNER JOIN ims_stores AS RECVR ON RECVR.store_id=ims_stock_transfer_sub.recvr_store_id
                            LEFT JOIN ims_users AS transBy ON transBy.usr_id=ST.created_by
                            LEFT JOIN ims_users AS approvedBy ON approvedBy.usr_id=ST.approved_by
                            LEFT JOIN ims_users AS releasedBy ON releasedBy.usr_id=released_by
                            WHERE sub_transfer_id=" & stid, conn)

                    Using rdr = cmd.ExecuteReader()
                        While rdr.Read

                            report.Parameters("store_name").Value = rdr("store_name")
                            report.Parameters("store_info").Value = rdr("store_info")
                            report.Parameters("sub_transfer_id").Value = rdr("sub_transfer_id")
                            report.Parameters("transfer_id").Value = String.Concat("ST", rdr("root_transfer_id").ToString.PadLeft(5, "0"c))
                            report.Parameters("transfer_type").Value = rdr("transfer_type")
                            report.Parameters("src_store").Value = rdr("src_store")
                            report.Parameters("destination_store").Value = rdr("recvr_store")
                            report.Parameters("transfer_date").Value = rdr("created_at")

                            warehouse_name = IIf(type.Equals("receive"), rdr("recvr_store"), rdr("src_store"))
                            items = rdr("item")

                            report.Parameters("transfer_by").Value = rdr("transfer_by")
                            report.Parameters("approved_by").Value = rdr("approved_by")
                            report.Parameters("prepared_by").Value = rdr("prepared_by")
                            report.Parameters("checked_by").Value = rdr("checked_by")
                            report.Parameters("released_by").Value = rdr("released_by")
                            report.Parameters("delivered_by").Value = rdr("delivered_by")

                            report.Parameters("public_note").Value = rdr("public_note")
                            report.Parameters("total_cubic_meter").Value = rdr("total_cbm")
                            report.Parameters("total_weight").Value = rdr("total_kgs")

                        End While
                    End Using


                    warehouse_name = "ims_" & warehouse_name.Replace(" ", "_").ToLower

                    'Set to DataTable
                    SetDataTable(items, table.transferred_units, warehouse_name, conn)

                End Using

                If type.Equals("receive") Then
                    report.row_pcs.Visible = False
                End If

                report.DataSource = table
                report.RequestParameters = False
                report.ShowRibbonPreviewDialog
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Set to DataTable
    Private Sub SetDataTable(units As String, dt As DataTable, warehouse_tbl As String, conn As MySqlConnection)

        Dim comma(), piece, equal() As String
        Dim colonseparator As New Regex("\b;\b")
        Dim equalseparator As New Regex("\b=\b")

        'Clear DataTable
        If dt.Rows.Count > 0 Then dt.Rows.Clear()

        If Not String.IsNullOrEmpty(units) Then

            Using cmd = New MySqlCommand("SELECT ims_inventory.pid, winmodel, description, qty_per_box, masterbox_qty,
                            (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm, IFNULL(weight, 0) AS kgs,
                            location, location_2, unit
                            FROM ims_inventory 
                            LEFT JOIN " & warehouse_tbl & " AS w_tbl ON w_tbl.pid=ims_inventory.pid
                            WHERE ims_inventory.pid=@pid", conn)
                cmd.Parameters.AddWithValue("@pid", 0)
                cmd.Prepare()

                comma = colonseparator.Split(units)

                For i = 0 To comma.Length - 1
                    piece = comma(i).Trim
                    equal = piece.Split("=")

                    cmd.Parameters("@pid").Value = equal(0)

                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            dt.Rows.Add(equal(1).Trim.Replace(";", String.Empty), rdr("qty_per_box"), rdr("masterbox_qty"), rdr("winmodel"), rdr("description"), rdr("location"), rdr("location_2"), rdr("unit"))
                        End While
                    End Using

                Next

            End Using

        End If

    End Sub


    '--- CONTROLS ---


    'btn_dispatch
    Private Sub btn_dispatch_Click(sender As Object, e As EventArgs) Handles btn_dispatch.Click

        'Validation
        If String.IsNullOrWhiteSpace(txt_driver.Text) Then
            MsgBox("Complete all required fields!", vbCritical, "Incomplete Fields")
            Exit Sub
        End If

        'Confirmation
        If MsgBox("Press 'YES' to confirm.", vbYesNo + vbInformation, "Confirmation") = vbYes Then

            Try
                'Get Stock Transder ID
                Dim sstid = CInt(txt_transfer_id.Text)

                Using connect = New MySqlConnection(str)
                    connect.Open()

                    Using cmd = New MySqlCommand("UPDATE ims_stock_transfer_sub 
                                    SET released_by=@released_by, delivered_by=@delivered_by, status=@status, date_released=CURRENT_TIMESTAMP
                                    WHERE sub_transfer_id=@sub_transfer_id", connect)

                        cmd.Parameters.AddWithValue("@sub_transfer_id", sstid)
                        cmd.Parameters.AddWithValue("@released_by", frm_main.lbl_user_id.Text)
                        cmd.Parameters.AddWithValue("@delivered_by", CurrentCulture.TextInfo.ToTitleCase(txt_driver.Text.Trim))
                        cmd.Parameters.AddWithValue("@status", "Dispatched")
                        cmd.ExecuteNonQuery()

                        MsgBox("Dispatched!", vbInformation, "Information")
                        Me.Close()

                    End Using

                End Using

            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, "Error")
            End Try

        End If

    End Sub

    'btn_print
    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        printSubTransfer(txt_transfer_id.Text.Replace("ST", String.Empty), "send")
    End Sub
End Class