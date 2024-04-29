Imports MySqlConnector
Imports Newtonsoft.Json
Imports System.Text.RegularExpressions

Public Class frm_homepage
    Private Sub frm_homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_welcome.Text = "Yehey! Welcome back " & frm_main.lbl_user_name.Text
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

End Class