Imports System.Web.Mvc

Namespace Controllers
    Public Class RegistrierenController
        Inherits Controller
        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"

        Private db As collabDBEntities = New collabDBEntities '= New collabEntities

        ' GET: /Registrieren/
        Function Registrieren() As ActionResult
            Dim ben As Benutzer
            Dim branche As Branche
            Dim lstBranche As List(Of Branche)
            Dim lstInf As List(Of Influencer)
            Dim lstUnt As List(Of Unternehmen)
            Dim vmBen As BenutzerViewModel

            ben = New Benutzer 'Neue leere Jobanzeige erzeugen

            'Alle Kategorien aus Datenbank laden
            lstBranche = New List(Of Branche)
            For Each brancheEntity In db.tblBranchen.ToList
                branche = New Branche(brancheEntity)
                lstBranche.Add(branche)
            Next

            'lstInf = New List(Of Influencer)
            'For Each infEntity In db.tblInfluencer.ToList
            '    ben = New Benutzer(infEntity)
            '    lstInf.Add(ben)
            'Next

            'lstUnt = New List(Of Unternehmen)
            'For Each untEntity In db.tblUnternehmer.ToList
            '    ben = New Benutzer(untEntity)
            '    lstUnt.Add(ben)
            'Next

            'ViewModel vorbereiten
            vmBen = New BenutzerViewModel
            vmBen.Benutzer = ben
            vmBen.ListeBranche = lstBranche
            Return View(vmBen) 'Neue Jobanzeige und Liste aller 
            'branche als ViewModel an die View übergeben
            'Return View()
            'Return View()
        End Function

        'POST: /Registrieren/
        <HttpPost>
        Function Registrieren(pvmBenutzer As BenutzerViewModel) As ActionResult
            Dim ben As Benutzer
            Dim inf As Influencer
            Dim unt As Unternehmen
            Dim infEntity As InfluencerEntity
            Dim untEntity As UnternehmerEntity
            Dim branche As Branche
            Dim lstBranche As List(Of Branche)
            Dim lstInf As List(Of Influencer)
            Dim lstUnt As List(Of Unternehmen)

            If Not ModelState.IsValid Then
                lstBranche = New List(Of Branche) 'Alle Branche aus Datenbank laden

                For Each brancheEntity In db.tblBranchen.ToList
                    branche = New Branche(brancheEntity)
                    lstBranche.Add(branche)
                Next
                pvmBenutzer.ListeBranche = lstBranche
                Return View(pvmBenutzer)
            End If

            'Jobanzeige aus dem ViewModel holen und in Jobanzeige entity umwandeln
            ben = pvmBenutzer.Benutzer
            'job.UnternehmerID = Web.HttpContext.Current.Session("BenutzerID")
            infEntity = inf.gibAlsInfluencerEntity
            untEntity = unt.gibAlsUnternehmenEntity
            'speichern vorbereiten
            db.tblInfluencer.Attach(infEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(infEntity).State = EntityState.Added 'als Hinzugefügt markieren
            db.tblUnternehmer.Attach(untEntity)
            db.Entry(untEntity).State = EntityState.Added

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Registrierung war nicht erfolgreich.")
            End Try
            Return RedirectToAction("Index", "Collab") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function

    End Class
End Namespace