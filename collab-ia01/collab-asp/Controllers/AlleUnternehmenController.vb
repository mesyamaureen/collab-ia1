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

            ' Alle Unternehmen aus der Datenbank holen
            For Each unEntity In db.tblUnternehmer.ToList
                ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
                unt = New Unternehmen(unEntity)

                ' Objekt der Model-Klasse zur Liste hinzufügen
                lstUnternehmer.Unternehmen.Add(unt)
            Next

            ' Gesamte list anzeigen
            Return View(lstUnternehmer)
        End Function
    End Class
End Namespace