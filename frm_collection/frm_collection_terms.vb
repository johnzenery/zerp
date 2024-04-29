Imports MySqlConnector

Public Class frm_collection_terms

    '--- ON LOAD ----
    Private Sub frm_collection_terms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_terms_orders()
    End Sub




    '--- FUNCTIONS ----


    'Load Unpaid (TERMS)
    Public Sub load_terms_orders()

        Try

            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim query = "SELECT status, order_id, date_ordered, shipping_method, ims_customers.first_name as customer, ims_users.first_name as agent, ims_customers.terms, amount_due, IFNULL(payment_status, 'UNPAID') as payment_status FROM ims_orders
                        INNER JOIN ims_customers ON ims_orders.customer=ims_customers.customer_id
                        INNER JOIN ims_users ON ims_orders.agent=ims_users.usr_id
                        WHERE payment_type='terms' AND (payment_status IS NULL OR NOT payment_status = 'PAID') AND NOT status='Cancelled' AND ims_orders.deleted='0'
                        ORDER BY order_id DESC"
                Dim cmd = New MySqlCommand(query, connection)
                Dim rdr As MySqlDataReader = cmd.ExecuteReader()

                Dim dt = New DataTable
                dt.Columns.Add("order_id")
                dt.Columns.Add("shipping_method")
                dt.Columns.Add("status")
                dt.Columns.Add("payment_status")
                dt.Columns.Add("customer")
                dt.Columns.Add("agent")
                dt.Columns.Add("date_ordered", GetType(Date))
                dt.Columns.Add("terms")
                dt.Columns.Add("remaining")
                dt.Columns.Add("classification")
                dt.Columns.Add("amount_due", System.Type.GetType("System.Decimal"))


                While rdr.Read
                    Dim terms = DateAdd("d", rdr("terms"), rdr("date_ordered"))
                    Dim days As Long = DateDiff(DateInterval.Day, Date.Today, terms)

                    Dim classification = String.Empty

                    If days < 0 Then classification = "OVERDUE" Else classification = "PENDING"

                    dt.Rows.Add(rdr("order_id"), rdr("shipping_method"), rdr("status"), rdr("payment_status"), rdr("customer"), rdr("agent"), rdr("date_ordered"), rdr("terms"), days.ToString, classification, rdr("amount_due"))
                End While

                grid_terms.DataSource = dt
                grid_terms_view.BestFitColumns()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub

End Class