Imports System.Web.Mvc

Namespace Controllers
    Public Class JobanzeigeController
        Inherits Controller

        ' GET: Jobanzeige
        Function Index() As ActionResult
            Return View()
        End Function

        'ladenJobanzeigeEinzeln() - für Bewerbung.html?
        Function laden(pintID As Integer) As ActionResult
            Dim intID As Integer
            Dim strTitel As String
            Dim strBeschreibung As String
            intID = Integer.Parse(Request.QueryString("ID"))
            strTitel = Request.QueryString("txtTitel")
            strBeschreibung = Request.QueryString("txtBeschreibung")
            Return View() 'hier nochmal überprüfen, ob es zurück in View geht oder zu anderer Funktion darunter z.B. AnzeigenJobanzeige
        End Function

        'anzeigenJobanzeige() - ist es nicht die gleiche Funktion wie laden?
        Function Jobanzeige(ID As Integer) As ActionResult

        End Function

        'loeschen()
        Function Loeschen(ID As Integer) As ActionResult
            Dim job As Jobanzeige


        End Function

        'anzeigenFormular() - bei "Bearbeiten" + "hinzufügen" Pop-Up Fenster? 
        <HttpPost>
        Function Formular(ID As Integer) As ActionResult
            Dim intJobID As Integer
            Dim strTitel As String
            Dim strBeschreibung As String
            intJobID = Request.Form("intJobID")
            strTitel = Request.Form("strTitel")
            strBeschreibung = Request.Form("strBeschreibung")
        End Function

        Function hinzufuegen() As ActionResult

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

        'abbrechen()?

    End Class
End Namespace