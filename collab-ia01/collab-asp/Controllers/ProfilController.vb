Imports System.Web.Mvc

Namespace Controllers
    Public Class ProfilController
        Inherits Controller



        ' GET: Profil
        Function Index() As ActionResult
            Return View()
        End Function

        Function LadenProfil(pintId As Integer) As ActionResult
            Dim intId As Integer

        End Function


        Function AnzeigenProfil(pintInId As Integer) As Influencer
            Dim intId As Integer
        End Function

        Function abbrechen() As ActionResult
            Return View()

        End Function

        Function speichernBewertung() As ActionResult
            Return View()

        End Function

        Function AnzeigenChat() As ActionResult
            Return View()
        End Function


        Function SpeichernNachricht() As ActionResult
        End Function


    End Class
End Namespace