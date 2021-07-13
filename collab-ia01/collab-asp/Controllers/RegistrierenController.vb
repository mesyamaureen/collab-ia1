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
            Dim vmBen As BenutzerViewModel

            ben = New Benutzer 'Neue leere Benutzer erzeugen

            'Alle BRanche aus Datenbank laden
            lstBranche = New List(Of Branche)
            For Each brancheEntity In db.tblBranchen.ToList
                branche = New Branche(brancheEntity)
                lstBranche.Add(branche)
            Next

            vmBen = New BenutzerViewModel
            vmBen.Benutzer = ben
            vmBen.ListeBranche = lstBranche
            Return View(vmBen) 'Neuer Benutzer und Liste aller 
            'branche als ViewModel an die View übergeben
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

            If Not ModelState.IsValid Then
                lstBranche = New List(Of Branche) 'Alle Branche aus Datenbank laden

                For Each brancheEntity In db.tblBranchen.ToList
                    branche = New Branche(brancheEntity)
                    lstBranche.Add(branche)
                Next
                pvmBenutzer.ListeBranche = lstBranche
                Return View(pvmBenutzer)
            End If

            'Benutzer aus dem ViewModel holen und in BenutzerEntity umwandeln
            ben = pvmBenutzer.Benutzer

            ' Verzweigung, ob Unternehmen oder Influencer
            If pvmBenutzer.Unternehmen.Firmenname Is Nothing Then
                inf = pvmBenutzer.Influencer
                inf.Benutzername = ben.Benutzername
                inf.Beschreibung = ben.Beschreibung
                inf.Email = ben.Email
                inf.Branche = ben.Branche
                For Each brancheEntity In db.tblBranchen.ToList
                    If brancheEntity.BrTitel.Equals(inf.Branche.BrancheTitel) Then
                        inf.BrancheID = brancheEntity.BrIdPk
                        inf.Branche.BrancheID = brancheEntity.BrIdPk
                        Exit For
                    End If
                Next
                inf.Passwort = ben.Passwort

                infEntity = inf.gibAlsInfluencerEntity

                'speichern vorbereiten
                db.tblInfluencer.Attach(infEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
                db.Entry(infEntity).State = EntityState.Added 'als Hinzugefügt markieren

            Else
                unt = pvmBenutzer.Unternehmen
                unt.Benutzername = ben.Benutzername
                unt.Beschreibung = ben.Beschreibung
                unt.Email = ben.Email
                unt.Branche = ben.Branche
                For Each brancheEntity In db.tblBranchen.ToList
                    If brancheEntity.BrTitel.Equals(unt.Branche.BrancheTitel) Then
                        unt.BrancheID = brancheEntity.BrIdPk
                        unt.Branche.BrancheID = brancheEntity.BrIdPk
                        Exit For
                    End If
                Next
                unt.Passwort = ben.Passwort

                untEntity = unt.gibAlsUnternehmenEntity

                db.tblUnternehmer.Attach(untEntity)
                db.Entry(untEntity).State = EntityState.Added
            End If

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Registrierung war nicht erfolgreich.")
            End Try
            Return RedirectToAction("Einloggen", "AlleProfile") 'Zu Einloggen-Seite
        End Function

    End Class
End Namespace