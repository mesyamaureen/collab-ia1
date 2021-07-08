Imports System.Web.Mvc
Imports collab_asp.Benutzer

Namespace Controllers
    Public Class AlleProfileController
        Inherits Controller

        ' GET: AlleProfile
        Function Index() As ActionResult
            Return View()
        End Function


        Function Einloggen(pintId As Integer) As ActionResult
            Dim intId As Integer

            Return View()
        End Function

        Function Verify(pben As Benutzer) As ActionResult
            Return View()
        End Function

        Function AnzeigenListe() As List(Of Benutzer)

        End Function
    End Class
End Namespace