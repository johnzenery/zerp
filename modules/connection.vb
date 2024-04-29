Module connection


    Public connection_panel_password As String = "zerp"

    Public db As String = String.Empty             'My.Settings.database

    '--- FTP
    Public ftp_server As String = "winland.synology.me"
    Public ftp_username As String = "wlftp"
    Public ftp_password As String = "@Ftpmaster2297"
    Public ftp_userFolder As String = "User Photos"
    Public ftp_productFolder As String = "Product Photos"
    Public ftp_salesFolder As String = "Sales"

    'BUILDING CONNECTION STRING
    Public str As String = String.Empty '"Server=" & server & ";Userid=" & uid & ";Password=" & password & ";Port=" & port & ";Database=" & db & ";default command timeout=120;Convert Zero Datetime=True"

End Module
