Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleJobanzeigenController
        Inherits Controller

        Private db As collabEntities = New collabEntities

        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"
        ' GET: AlleJobanzeigen
        Function Index() As ActionResult
            Return View()
        End Function

        'anzeigenJobanzeigen() - = anzeigen Liste aller Jobanzeige?
        Function Jobanzeigen() As ActionResult
            ' Deklaration
            Dim job As Jobanzeige
            Dim jaEntity As JobanzeigeEntity
            Dim jaListe As JobanzeigenListe

            ' Leere Liste initislisieren
            jaListe = New JobanzeigenListe()

            ' Alle Aufgaben aus der Datenbank holen
            For Each jaEntity In db.tblJobanzeigen.ToList
                ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
                job = New Jobanzeige(jaEntity)

                ' Objekt der Model-Klasse zur Liste hinzufügen
                jaListe.Jobanzeige.Add(job)
            Next

            ' Gesamte list anzeigen
            Return View(jaListe)
        End Function

    End Class
End Namespace