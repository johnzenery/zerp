Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports MySqlConnector

Module functions

    'ReadOnly conn As New MySqlConnection(str)
    Public Property rowHandle As Integer
    Public Property sales_return_id As Integer
    Public Property sales_return_amount As Decimal

    'TEST CONNECTION
    Public Function TestConnection()

        Dim bool = False

        'SELECT CONNECTION_STRING 
        Select Case My.Settings.ConnectionType
            Case "LAN"
                server = local_server
                port = local_port
            Case "WAN"
                server = wan_server
                port = wan_port
        End Select

        'SELECTT Database Type
        Select Case My.Settings.DatabaseType
            Case "Production"
                db = production_db
            Case "Development"
                db = development_db
        End Select

        'SET NEW CONNECTION STRING
        str = "Server=" & server & ";Userid=" & uid & ";Password=" & password & ";Port=" & port & ";Database=" & db & ";Convert Zero Datetime=True"

        Try
            Using conn = New MySqlConnection(str)
                conn.Open()

                If conn.State = ConnectionState.Open Then
                    bool = True
                End If

            End Using
        Catch ex As Exception
            MsgBox("Couldn't connect to ZERP server!" & Environment.NewLine & "Please contact your administrator.", vbCritical, "Connection Problem")
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

    'Payment Logs
    Public Sub Insert_PaymentLog(connection As MySqlConnection, payment_date As Date, order_id As Integer, customer As String,
                                  current_balance As Decimal, payment As Decimal, sales_returns As Decimal, balance As Decimal, payment_gateway As String, payment_ref As String)
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
                    cmd.Parameters.AddWithValue("@received_by", frm_main.user_id.Text)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical, "Error encountered")
        End Try
    End Sub

    'Update Sales Returns
    Public Sub Update_SalesReturns(id As Integer)
        Try
            Using conn = New MySqlConnection(str)
                conn.Open()
                Using cmd = New MySqlCommand("UPDATE ims_sales_returns SET is_applied=1 WHERE sales_return_id=" & id, conn)
                    cmd.ExecuteNonQuery()
                End Using
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
End Class

Public Class SalesReturnClass
    Public Property qty As Decimal
    Public Property model As String
    Public Property description As String
    Public Property unit_price As Decimal
    Public Property total_amount As Decimal
    Public Property pid As String
    Public Property purchase_date As Date
    Public Property last_qty As Decimal

End Class

Public Class PurchaseOrderClass
    Public Property pid As Integer
    Public Property qty As Decimal
    Public Property winmodel As String
    Public Property supmodel As String
    Public Property description As String
    Public Property cost As Decimal
    Public Property total_cost As Decimal
    Public Property qty_received As Decimal
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


