Imports System.Reflection

Public Class frm_splash_screen
    Sub New()
        InitializeComponent()
        Me.labelCopyright.Text = "Copyright © 2020 - " & DateTime.Now.Year.ToString() & " Parsell Company" & vbCrLf _
        & "All Rights reserved."

        Dim version As Version = Assembly.GetExecutingAssembly().GetName().Version
        lbl_version.Text = "v" & version.Major.ToString & "." & version.Minor.ToString & "." & version.Build.ToString

    End Sub

    Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
        MyBase.ProcessCommand(cmd, arg)
        Dim command As SplashScreenCommand = cmd


        If command = Global.Inventory_Management.frm_splash_screen.SplashScreenCommand.set_status Then
            lbl_status.Text = arg
        End If

    End Sub

    Public Enum SplashScreenCommand
        set_status
    End Enum

End Class
