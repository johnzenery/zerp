Module connection


    Public connection_panel_password As String = "zerp"

    '--- DATABASE
    Public server As String = String.Empty          'My.Settings.server
    Public port As String = String.Empty            'My.Settings.port
    Public db As String = String.Empty              'My.Settings.database

    Public uid As String = "zerp"                   'My.Settings.username
    Public password As String = "zerpconnectsall"   'My.Settings.password

    Public local_server As String = "172.16.1.10"
    Public local_port As String = "3306"

    Public wan_server As String = "winlandene.synology.me"
    Public wan_port As String = "63306"

    Public production_db = "zerpdb"
    Public development_db = "zerpdbtest"

    '--- FTP
    Public ftp_username As String = "wlftp"
    Public ftp_password As String = "@Ftpmaster2297"
    Public ftp_userFolder As String = "User Photos"
    Public ftp_productFolder As String = "Product Photos"
    Public ftp_salesFolder As String = "Sales"

    'BUILDING CONNECTION STRING
    Public str As String = "Server=" & server & ";Userid=" & uid & ";Password=" & password & ";Port=" & port & ";Database=" & db & ";Convert Zero Datetime=True"

End Module
