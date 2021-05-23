Imports System.Web.Mvc

Namespace Controllers
    Public Class JobanzeigeController
        Inherits Controller

        ' GET: Jobanzeige
        Function Index() As ActionResult
            Return View()
        End Function

        'ladenJobanzeigeEinzeln() - für Bewerbung.html?
        Function LadenJobanzeigeEinzeln(pintJobID As Integer) As Jobanzeige
            Dim intJobID As Integer
            Dim strTitel As String
            Dim strBeschreibung As String


        End Function

        'anzeigenJobanzeige()
        Function AnzeigenJobanzeige(pintJobID As Integer) As ActionResult

        End Function

        'loeschen()
        Function Loeschen(pintJobID As Integer) As ActionResult

        End Function

        'anzeigenFormular()
        Function AnzeigenFormular() As ActionResult

        End Function

        'speichern()
        Function Speichern() As ActionResult

        End Function

        'abbrechen()

    End Class
End Namespace