Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleProfileController
        Inherits Controller

        ' GET: AlleProfile
        Function Index() As ActionResult
            Return View()
        End Function


        Function ermittelnBenutzer(pintId As Integer) As ActionResult
            Dim intId As Integer

        End Function

        Function AnzeigenListe() As List(Of Benutzer)

        End Function
    End Class
End Namespace