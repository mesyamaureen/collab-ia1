Imports System.Web.Mvc

Namespace Controllers
    Public Class JobanzeigeController
        Inherits Controller

        ' GET: Jobanzeige
        Function Index() As ActionResult
            Return View()
        End Function

        'ladenJobanzeigeEinzeln() - für Bewerbung.html?
        Function LadenJobanzeigeEinzeln(ID As Integer) As ActionResult 'Rückgabewert=Jobanzeige/ActionResult?
            Dim intJobID As Integer
            Dim strTitel As String
            Dim strBeschreibung As String
            intJobID = ID
            Return View() 'hier nochmal überprüfen, ob es zurück in View geht oder zu anderer Funktion darunter z.B. AnzeigeJobanzeige
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
        <HttpPost>
        Function Speichern() As ActionResult
            'Dim intJobID As Integer
            'Dim strTitel As String
            'Dim strBeschreibung As String
            'strTitel = Request.Form("txtTitel")
            'strBeschreibung = Request.Form("txtBeschreibung")
        End Function

        'abbrechen()

    End Class
End Namespace