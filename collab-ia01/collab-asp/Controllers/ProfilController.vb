﻿Imports System.Web.Mvc

Namespace Controllers
    Public Class ProfilController
        Inherits Controller



        ' GET: Profil
        Function Index() As ActionResult
            Return View()
        End Function

        Function LadenProfil(intId As Integer) As ActionResult
            Dim intId As Integer

        End Function


        Function AnzeigenProfil(pintInId As Integer) As Influencer
            Dim intId As Integer
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