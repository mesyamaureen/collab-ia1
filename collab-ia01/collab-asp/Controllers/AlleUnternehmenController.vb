Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleUnternehmenController
        Inherits Controller


        Private db As collabDBEntities = New collabDBEntities

        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"

        ' GET: AlleUnternehmen
        Function Unternehmensuchen() As ActionResult
            ' Deklaration
            Dim unt As Unternehmen
            Dim unEntity As UnternehmerEntity
            Dim lstUnternehmer As UnternehmenListe

            ' Leere Liste initislisieren
            lstUnternehmer = New UnternehmenListe()

            ' Alle Aufgaben aus der Datenbank holen
            For Each unEntity In db.tblUnternehmer.ToList
                ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
                unt = New Unternehmen(unEntity)

                ' Objekt der Model-Klasse zur Liste hinzufügen
                lstUnternehmer.Unternehmen.Add(unt)
            Next

            ' Gesamte list anzeigen
            Return View(lstUnternehmer)
        End Function

        Function Unternehmer(pUnId As Integer) As ActionResult

            Return View()

        End Function

        Function LoeschenUnternehmen(pUintId As Integer) As ActionResult
            Return View()
        End Function

        Function NeuUnternehmer() As ActionResult
            Return View()

        End Function



    End Class
End Namespace