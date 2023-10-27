
<ComClassAttribute>
Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Dim message = New System.Messaging.Message

        Dim exitCode = Shell("myExe.exe")

        ChDir("")

        IO.File.WriteAllText("xyz.txt", "")

        Dim q = Microsoft.VisualBasic.MsgBoxStyle.AbortRetryIgnore

        Return View()
    End Function
End Class
