Imports System.Web.Mvc

Namespace Controllers
    Public Class ProfilController
        Inherits Controller



        ' GET: Profil
        Function Index() As ActionResult
            Return View()
        End Function

        Function LadenProfil() As ActionResult

        End Function


        Function AnzeigenProfil(pintInId As Integer) As Influencer

        End Function

        Function abbrechen() As ActionResult


        End Function

        Function speichernBewertung() As ActionResult

        End Function

        Function AnzeigenChat() As ActionResult

        End Function


        Function SpeichernNachricht() As ActionResult

        End Function


    End Class
End Namespace