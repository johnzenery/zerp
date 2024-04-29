Imports MySqlConnector
Imports System.Configuration
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Module functions

    Public Property rowHandle As Integer
    Public Property sales_return_id As Integer
    Public Property sales_return_amount As Decimal
    Private Property is_backup_server As Boolean = False

    'TEST CONNECTION
    Public Function TestConnection()

        Dim bool = False

        'SELECT CONNECTION_STRING 
        Select Case My.Settings.ConnectionType
            Case "LAN"
                'server = local_server
                'port = local_port
                Select Case My.Settings.DatabaseType
                    Case "Production"
                        str = ConfigurationManager.ConnectionStrings("ProductionDB_LOCAL").ConnectionString
                    Case "Development"
                        str = ConfigurationManager.ConnectionStrings("DevelopmentDB_LOCAL").ConnectionString
                End Select

            Case "WAN"
                If is_backup_server = True Then
                    Select Case My.Settings.DatabaseType
                        Case "Production"
                            str = ConfigurationManager.ConnectionStrings("ProductionDB_WAN_BACKUP").ConnectionString
                        Case "Development"
                            str = ConfigurationManager.ConnectionStrings("DevelopmentDB_WAN_BACKUP").ConnectionString
                    End Select
                Else
                    Select Case My.Settings.DatabaseType
                        Case "Production"
                            str = ConfigurationManager.ConnectionStrings("ProductionDB_WAN").ConnectionString
                        Case "Development"
                            str = ConfigurationManager.ConnectionStrings("DevelopmentDB_WAN").ConnectionString
                    End Select
                End If

                'port = wan_port
        End Select

        'SELECT DATABASE
        'Select Case My.Settings.DatabaseType
        '    Case "Production"
        '        'db = production_db
        '        str = ConfigurationManager.ConnectionStrings("ProductionDB").ConnectionString
        '    Case "Development"
        '        'db = development_db
        '        str = ConfigurationManager.ConnectionStrings("DevelopmentDB").ConnectionString
        'End Select

        'SET NEW CONNECTION STRING
        'str = "Server=" & server & ";Userid=" & uid & ";Password=" & password & ";Port=" & port & ";Database=" & db & ";default command timeout=120;Convert Zero Datetime=True"

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                If conn.State = ConnectionState.Open Then
                    bool = True

                End If

            End Using
        Catch ex As Exception
            Dim errorCode As Integer = ex.HResult
        If is_backup_server = False Then
            is_backup_server = True
            bool = TestConnection()
        Else
            bool = False
            MsgBox("Couldn't establish connection to server." & Environment.NewLine & "Please contact your administrator." & Environment.NewLine & Environment.NewLine & ex.Message, vbCritical, "Error Occured")
        End If

        End Try

        Return bool

    End Function

    'Encrypt Password
    Public Function Encrypt(clearText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim clearBytes As Byte() = Encoding.Unicode.GetBytes(clearText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateEncryptor(), CryptoStreamMode.Write)
                    cs.Write(clearBytes, 0, clearBytes.Length)
                    cs.Close()
                End Using
                clearText = Convert.ToBase64String(ms.ToArray())
            End Using
        End Using
        Return clearText
    End Function

    'Decrypt Password
    Public Function Decrypt(cipherText As String) As String
        Dim EncryptionKey As String = "MAKV2SPBNI99212"
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Using encryptor As Aes = Aes.Create()
            Dim pdb As New Rfc2898DeriveBytes(EncryptionKey, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D,
             &H65, &H64, &H76, &H65, &H64, &H65,
             &H76})
            encryptor.Key = pdb.GetBytes(32)
            encryptor.IV = pdb.GetBytes(16)
            Using ms As New MemoryStream()
                Using cs As New CryptoStream(ms, encryptor.CreateDecryptor(), CryptoStreamMode.Write)
                    cs.Write(cipherBytes, 0, cipherBytes.Length)
                    cs.Close()
                End Using
                cipherText = Encoding.Unicode.GetString(ms.ToArray())
            End Using
        End Using
        Return cipherText
    End Function

    'Logs : Payment 
    Public Function Insert_PaymentLog(connection As MySqlConnection, payment_date As Date, order_id As Integer, customer As String,
                                  current_balance As Decimal, payment As Decimal, sales_returns As Decimal, balance As Decimal, payment_gateway As String, payment_ref As String)
        Dim payment_id As Integer = 0

        Try
            Using connection
                Using cmd = New MySqlCommand("INSERT INTO ims_payment_logs (payment_date, order_id, customer_id, current_balance, payment, returns_amount, balance, payment_gateway, payment_ref, received_by)
                                            VALUES (@payment_date, @order_id, (SELECT customer_id FROM ims_customers WHERE first_name=@customer), @current_balance, @payment, @returns_amount, @balance, @payment_gateway, @payment_ref, @received_by)", connection)
                    cmd.Parameters.AddWithValue("@payment_date", payment_date)
                    cmd.Parameters.AddWithValue("@order_id", order_id)
                    cmd.Parameters.AddWithValue("@customer", customer)
                    cmd.Parameters.AddWithValue("@current_balance", current_balance)
                    cmd.Parameters.AddWithValue("@returns_amount", sales_returns)
                    cmd.Parameters.AddWithValue("@payment", payment)
                    cmd.Parameters.AddWithValue("@balance", balance)
                    cmd.Parameters.AddWithValue("@payment_gateway", payment_gateway)
                    cmd.Parameters.AddWithValue("@payment_ref", payment_ref)
                    cmd.Parameters.AddWithValue("@received_by", frm_main.lbl_user_id.Text)
                    If cmd.ExecuteNonQuery() Then
                        payment_id = cmd.LastInsertedId
                    End If
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error encountered")
        End Try

        Return payment_id

    End Function

    'Logs : Export
    Public Sub Log_Export(description As String, user As Integer)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("INSERT INTO ims_logs_export (description, user, date_created) 
                                VALUES (@description, @user, current_timestamp)", conn)
                    cmd.Parameters.AddWithValue("@description", description)
                    cmd.Parameters.AddWithValue("@user", user)
                    cmd.ExecuteNonQuery()

                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error")
        End Try
    End Sub

    'Update Sales Returns
    Public Sub Update_SalesReturns(id As Integer, credit_ref As String, collection_id As Integer, conn As MySqlConnection, transc As MySqlTransaction)
        Try
            Using cmd = New MySqlCommand("UPDATE ims_sales_returns 
                                    SET is_applied=1, credit_ref=@credit_ref, collection_id=@collection_id
                                    WHERE sales_return_id=" & id, conn, transc)
                cmd.Parameters.AddWithValue("@credit_ref", credit_ref)
                cmd.Parameters.AddWithValue("@collection_id", collection_id)
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error encountered")
        End Try
    End Sub

    'Get CBM from Catalog
    Public Function GetCBM(item As String, conn As MySqlConnection)
        Dim cbm = 0.00

        Using cmd = New MySqlCommand("SELECT (IFNULL(length, 0) * IFNULL(width, 0) * IFNULL(height, 0)) / 100 AS cbm 
                        FROM ims_inventory WHERE pid=@pid", conn)
            cmd.Parameters.AddWithValue("@pid", item)
            cbm = cmd.ExecuteScalar
        End Using

        Return cbm

    End Function

    'Get KGS from Inventory
    Public Function GetKGS(item As String, conn As MySqlConnection)
        Dim kgs = 0.00

        Using cmd = New MySqlCommand("SELECT IFNULL(weight, 0) AS kgs 
                        FROM ims_inventory WHERE pid=@pid", conn)
            cmd.Parameters.AddWithValue("@pid", item)
            kgs = cmd.ExecuteScalar
        End Using

        Return kgs

    End Function

End Module





'OBJECTS

Public Class ChequesClass
    Public Property bank As String
    Public Property cheque_date As Date
    Public Property cheque_no As String
    Public Property amount As Decimal
    Public Property acc_no As String
    Public Property acc_name As String
    Public Property payee_name As String
End Class

Public Class SalesReturnClass
    Public Property qty As Decimal
    Public Property model As String
    Public Property description As String
    Public Property tax_type As String
    Public Property cost As Decimal
    Public Property unit_price As Decimal
    Public Property total_amount As Decimal
    Public Property pid As String
    Public Property purchase_date As Date
    Public Property last_qty As Decimal

End Class

Public Class PurchaseOrderClass
    Public Property is_bundle As Boolean
    Public Property pid As Integer
    Public Property qty As Decimal
    Public Property qty_per_box As Integer
    Public Property masterbox_qty As Integer
    Public Property min_order_qty As Integer
    Public Property winmodel As String
    Public Property supmodel As String
    Public Property brand As String
    Public Property sub_category As String
    Public Property description As String
    Public Property cost As Decimal
    Public Property total_cost As Decimal
    Public Property qty_received As Decimal
    Public Property base_price As Decimal
    Public Property discount As String
    Public Property unit As String
End Class

Public Class PurchaseReturnClass
    Public Property batch_no As Integer
    Public Property rid As Integer
    Public Property qty As Integer
    Public Property model As String
    Public Property description As String
    Public Property cost As Decimal
    Public Property total_cost As Decimal
End Class

Public Class SalesCustomerBankAccounts
    Public Property bank As String
    Public Property bank_acc_no As String
    Public Property bank_acc_name As String
End Class

Public Class UnitFieldClass
    Public Property Piece As Integer
    Public Property Set_item As Integer
    Public Property Lot As Integer
    Public Property Pair As Integer
    Public Property Roll As Integer
    Public Property Pack As Integer
    Public Property Kg As Integer
    Public Property Meter As Integer
    Public Property Gallon As Integer
    Public Property Liter As Integer
    Public Property Feet As Integer
    Public Property Inches As Integer
    Public Property Lenght As Integer
    Public Property Bundle As Integer
    Public Property Box As Integer
    Public Property Can As Integer
    Public Property Tube As Integer
End Class


