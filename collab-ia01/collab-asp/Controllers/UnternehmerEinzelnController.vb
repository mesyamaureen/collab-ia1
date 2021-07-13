Imports System.Web.Mvc

Namespace Controllers
    Public Class UnternehmerEinzelnController
        Inherits Controller
        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"
        Private db As collabDBEntities = New collabDBEntities

        Function Unternehmen(ID As Integer) As ActionResult
            'Deklaration
            Dim unt As Unternehmen
            Dim untEntity As UnternehmerEntity
            Dim branche As Branche
            Dim brEntity As BrancheEntity
            'Dim lstBranche As List(Of Branche)
            Dim vmUnt As UnternehmerViewModel

            'Datenbankzugriff über Entity Framework
            untEntity = db.tblUnternehmer.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblJobanzeige nachschlagen
            brEntity = untEntity.tblBranchen 'Vom Datensatz aus tblJobanzeige in tblKategorien navigieren

            If untEntity Is Nothing Then
                Return New HttpNotFoundResult("Influencer mit der ID " & ID & " wurde nicht gefunden") 'wenn keine Influencer gefunden, laden
            End If
            'Gefundenen Datensatz aus der Datenbank loslösen
            db.Entry(untEntity).State = EntityState.Detached
            'Umwandeln in ein Objekt der Model-Klasse
            unt = New Unternehmen(untEntity)

            'Prüfen, ob Branche vorhanden
            If brEntity IsNot Nothing Then
                unt.Branche = New Branche(brEntity)
            End If

            brEntity = db.tblBranchen.Find(untEntity.UBrIdFk)

            If brEntity Is Nothing Then
                Return New HttpNotFoundResult("Branche mit der ID " & untEntity.UBrIdFk & " wurde nicht gefunden") 'wenn keine Branche gefunden, laden
            End If
            db.Entry(brEntity).State = EntityState.Detached
            branche = New Branche(brEntity)

            unt.Branche = branche

            'Vorbereitung des View-Models
            vmUnt = New UnternehmerViewModel
            vmUnt.Unternehmen = unt
            'vmInf.ListeBranche = lstBranche

            Return View(vmUnt) 'ViewModel mit Jobanzeige und allen Branchen an die View zur Bearbeitung geben
        End Function

        <HttpPost>
        Function Unternehmen(pvmUnt As UnternehmerViewModel) As ActionResult
            Dim unt As Unternehmen
            Dim untEntity As UnternehmerEntity

            'Jobanzeige aus dem ViewModel holen und in JobanzeigeEntity umwandeln
            unt = pvmUnt.Unternehmen
            untEntity = unt.gibAlsUnternehmenEntity
            'Speichern vorbereiten
            db.tblUnternehmer.Attach(untEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(untEntity).State = EntityState.Modified 'als Geändert markieren

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Öffnen war nicht erfolgreich.")
            End Try

            Return RedirectToAction("Unternehmensuchen", "AlleUnternehmen") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function

        ' GET: UnternehmerEinzeln
        Function MeinProfilUnternehmer(Optional ID As Integer = -1) As ActionResult
            'Deklaration
            If ID = -1 Then
                ID = Int(Web.HttpContext.Current.Session("BenutzerID"))
            End If
            Dim unt As Unternehmen
            Dim untEntity As UnternehmerEntity
            Dim branche As Branche
            Dim brEntity As BrancheEntity
            Dim lstBranche As List(Of Branche)
            Dim vmUnt As UnternehmerViewModel

            'Datenbankzugriff über Entity Framework
            untEntity = db.tblUnternehmer.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblJobanzeige nachschlagen
            brEntity = untEntity.tblBranchen 'Vom Datensatz aus tblJobanzeige in tblKategorien navigieren

            If untEntity Is Nothing Then
                Return New HttpNotFoundResult("Aufgabe mit der ID " & ID & " wurde nicht gefunden") 'wenn keine Jobanzeige gefunden, laden
            End If
            'Gefundenen Datensatz aus der Datenbank loslösen
            db.Entry(untEntity).State = EntityState.Detached
            'Umwandeln in ein Objekt der Model-Klasse
            unt = New Unternehmen(untEntity)

            'Prüfen, ob Branche vorhanden
            If brEntity IsNot Nothing Then
                unt.Branche = New Branche(brEntity)
            End If
            'Alle Branche aus Datenbank laden
            lstBranche = New List(Of Branche)
            For Each brEntity In db.tblBranchen.ToList
                branche = New Branche(brEntity)
                lstBranche.Add(branche)
            Next
            'Vorbereitung des View-Models
            vmUnt = New UnternehmerViewModel
            vmUnt.Unternehmen = unt
            vmUnt.ListeBranche = lstBranche

            Return View(vmUnt) 'ViewModel mit Jobanzeige und allen Branchen an die View zur Bearbeitung geben
        End Function

        'POST: UnternehmerEinzeln/MeinProfilUnternehmer
        <HttpPost>
        Function MeinProfilUnternehmer(pvmUnt As UnternehmerViewModel) As ActionResult
            Dim unt As Unternehmen
            Dim untEntity As UnternehmerEntity
            Dim branche As Branche
            Dim lstBranche As List(Of Branche)

            If Not (ModelState.IsValid) Then
                lstBranche = New List(Of Branche) 'alle Branche aus Datenbank laden
                For Each brEntity In db.tblBranchen.ToList
                    branche = New Branche(brEntity)
                    lstBranche.Add(branche)
                Next

                'Wenn nicht, dann zurück an die View
                Return View(pvmUnt)
            End If

            'Jobanzeige aus dem ViewModel holen und in JobanzeigeEntity umwandeln
            unt = pvmUnt.Unternehmen
            untEntity = unt.gibAlsUnternehmenEntity
            'Speichern vorbereiten
            db.tblUnternehmer.Attach(untEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(untEntity).State = EntityState.Modified 'als Geändert markieren

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Bearbeiten war nicht erfolgreich.")
            End Try

            Return RedirectToAction("MeinProfilUnternehmer") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function

        ' GET: UnternehmerEinzeln/Edit/5
        Function UnternehmenBearbeiten(pUintId As Integer) As ActionResult
            Return View()
        End Function


    End Class
End Namespace