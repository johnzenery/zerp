Imports MySqlConnector
Imports Newtonsoft.Json

Public Class frm_purchaseorder_view_ordered_items

    Dim dt = New DataTable

    '--- ONLOAD ---
    Private Sub frm_purchaseorder_view_active_orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dt.Columns.Add("qty")
        dt.Columns.Add("qty_received")
        dt.Columns.Add("qty_to_receive")
        dt.Columns.Add("winmodel")
        dt.Columns.Add("supmodel")
        dt.Columns.Add("description")
        dt.Columns.Add("poid")
        dt.Columns.Add("po_status")
        dt.Columns.Add("supplier")
        dt.Columns.Add("date_sent", GetType(Date))

        load_active_orders()

    End Sub
    Dim count As Integer = 0


    '-- FUNCTIONS ---

    'Load All Orders
    Private Sub load_all_orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                dt.rows.clear()
                Using cmd = New MySqlCommand("SELECT orders, qty_received, concat('PO',LPAD(purchase_id,5,0)) as purchase_id, status,
                        (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) as supplier, IFNULL(date_sent, '1997-01-01') date_sent FROM ims_purchase
                        WHERE (STATUS='Unfinished' OR STATUS='Pending' OR STATUS='For Approval' OR STATUS='Approved' OR STATUS='Sent' OR STATUS='Partial' OR STATUS='Completed' OR 'Rejected' OR STATUS='Rejected (Sent)' OR STATUS='Rejected (Partial)' ) AND deleted='0'", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            If Not IsDBNull(rdr("orders")) Then
                                set_GridData(rdr("orders"), rdr("qty_received"), rdr("purchase_id"), rdr("status"), rdr("supplier"), rdr("date_sent"), False)
                            End If
                        End While

                        'Set to Grid
                        grid_po.DataSource = dt

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load All active Orders
    Private Sub load_active_orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                dt.rows.clear()
                Using cmd = New MySqlCommand("SELECT orders, qty_received, concat('PO',LPAD(purchase_id,5,0)) as purchase_id, status,
                        (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) as supplier, date_sent FROM ims_purchase
                        WHERE (STATUS='Sent' OR STATUS='Partial' OR STATUS='Rejected (Sent)') AND deleted='0'", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            If Not IsDBNull(rdr("orders")) Then
                                set_GridData(rdr("orders"), rdr("qty_received"), rdr("purchase_id"), rdr("status"), rdr("supplier"), rdr("date_sent"), False)
                            End If
                        End While

                        'Set to Grid
                        grid_po.DataSource = dt

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

    'Load All Fulfilled PO But NOT Oders
    Private Sub load_unfulfilled_orders()

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()
                dt.rows.clear()
                Using cmd = New MySqlCommand("SELECT orders, qty_received, concat('PO',LPAD(purchase_id,5,0)) as purchase_id, status,
                        (SELECT supplier FROM ims_suppliers WHERE id=ims_purchase.supplier) as supplier, date_sent FROM ims_purchase
                        WHERE(status ='Completed' OR status='Obsolete') AND deleted='0'", connection)
                    Using rdr = cmd.ExecuteReader
                        While rdr.Read
                            If Not IsDBNull(rdr("orders")) Then
                                set_GridData(rdr("orders"), rdr("qty_received"), rdr("purchase_id"), rdr("status"), rdr("supplier"), rdr("date_sent"), True)
                            End If
                        End While

                        'Set to Grid
                        grid_po.DataSource = dt

                    End Using
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub




    '--- CONTROLS ----

    'Set Units to Grid
    Private Sub set_GridData(units As String, qty_received As String, purchase_id As String, status As String, supplier As String, date_sent As Date, RemoveCompleted As Boolean)

        'Dim comma(), equal() As String
        'Dim received() As String = {}
        'Dim piece As String
        'Dim i As Integer
        'Dim colonseparator As New Regex("\b;\b")
        'Dim equalseparator As New Regex("\b=\b")


        'comma = colonseparator.Split(units)
        'If Not String.IsNullOrEmpty(qty_received) Then received = qty_received.Split(";")

        'For i = 0 To comma.Length - 1
        '    piece = comma(i).Trim
        '    equal = piece.Split("=")
        '    Dim r = 0

        '    If Not String.IsNullOrEmpty(qty_received) Then r = received(i)

        '    If RemoveCompleted = True Then If equal(1) = r Then Continue For
        '    table.Rows.Add(equal(1), r, equal(1) - r, equal(2), equal(3), equal(4), purchase_id, status, supplier)

        'Next

        Dim PurchaseOrder = JsonConvert.DeserializeObject(Of List(Of PurchaseOrderClass))(units)
        For Each Order In PurchaseOrder

            'Remove IF Completed
            If RemoveCompleted Then
                If Order.qty = Order.qty_received Then
                    Continue For
                End If
            End If
            dt.Rows.Add(
                            Order.qty,
                            Order.qty_received,
                            Order.qty - Order.qty_received,
                            Order.winmodel,
                            Order.supmodel,
                            Order.description,
                            purchase_id,
                            status,
                            supplier,
                            date_sent)
        Next

    End Sub

    Private Sub btn_export_Click(sender As Object, e As EventArgs) Handles btn_export.Click
        Dim saveFileDialog = New SaveFileDialog
        saveFileDialog.Filter = "PDF File (*.csv*)|*.csv"

        If saveFileDialog.ShowDialog = DialogResult.OK Then
            grid_po_view.ExportToCsv(saveFileDialog.FileName)
        End If

    End Sub

    'btn_unfulfilled_orders
    Private Sub btn_unfulfilled_orders_Click(sender As Object, e As EventArgs) Handles btn_unfulfilled_orders.Click
        load_unfulfilled_orders()
    End Sub

    'btn_active_orders
    Private Sub btn_active_orders_Click(sender As Object, e As EventArgs) Handles btn_active_orders.Click
        load_active_orders()
    End Sub

    'BUTTON : ALL ORDERS
    Private Sub btn_all_orders_Click(sender As Object, e As EventArgs) Handles btn_all_orders.Click
        load_all_orders()
    End Sub

End Class