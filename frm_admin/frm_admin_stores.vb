Imports MySqlConnector
Imports System.Globalization

Public Class frm_admin_stores

    'ON_LOAD
    Private Sub frm_stores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Stores()
    End Sub



    '--- CONTROLs and EVENTS ----

    'btn_add
    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        frm_admin_store_add.ShowDialog()
        Load_Stores()
    End Sub




    '--- FUNCTIONS ---

    'Load Stores
    Public Sub Load_Stores()

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                Using cmd = New MySqlCommand("SELECT store_id, store_name, store_addr, person_in_charge 
                                        FROM ims_stores WHERE deleted=0", conn)
                    Dim dt = New DataTable
                    Dim da = New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    grid_store.DataSource = dt
                End Using

            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    Private Sub gridview_supplier_RowUpdated(sender As Object, e As DevExpress.XtraGrid.Views.Base.RowObjectEventArgs) Handles gridview_supplier.RowUpdated
        Dim rowView As DataRowView = TryCast(e.Row, DataRowView)
        Dim row As DataRow = rowView.Row

        Try
            Using connection = New MySqlConnection(str)
                connection.Open()

                Dim cmd = New MySqlCommand("UPDATE ims_stores SET store_name=@storeName, store_addr=@storeAddr, person_in_charge=@inCharge WHERE store_id=@storeID", connection)

                With CultureInfo.CurrentCulture.TextInfo
                    cmd.Parameters.AddWithValue("@storeID", row("store_id"))
                    cmd.Parameters.AddWithValue("@storeName", .ToTitleCase(row("store_name")))
                    cmd.Parameters.AddWithValue("@storeAddr", .ToTitleCase(row("store_addr")))
                    cmd.Parameters.AddWithValue("@inCharge", .ToTitleCase(row("person_in_charge")))
                End With

                Dim inserted = cmd.ExecuteNonQuery

                If inserted >= 1 Then MessageBox.Show("Successfully Updated!", "Information", MessageBoxButtons.OK)
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try

    End Sub


End Class