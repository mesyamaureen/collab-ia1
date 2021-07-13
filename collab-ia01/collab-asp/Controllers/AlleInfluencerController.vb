Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleInfluencerController
        Inherits Controller

        Private db As collabDBEntities = New collabDBEntities

        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"
        ' GET: AlleInfluencer
        Function Influencersuchen() As ActionResult
            ' Deklaration
            Dim infl As Influencer
            Dim infEntity As InfluencerEntity
            Dim lstInfluencer As InfluencerListe

            ' Leere Liste initislisieren
            lstInfluencer = New InfluencerListe()

            ' Alle Influencer aus der Datenbank holen
            For Each infEntity In db.tblInfluencer.ToList
                ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
                infl = New Influencer(infEntity)

                ' Objekt der Model-Klasse zur Liste hinzufügen
                lstInfluencer.Influencer.Add(infl)
            Next

            ' Gesamte list anzeigen
            Return View(lstInfluencer)
        End Function
    End Class
End Namespace