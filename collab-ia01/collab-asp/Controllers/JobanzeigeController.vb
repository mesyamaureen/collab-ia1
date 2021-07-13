Imports System.Web.Mvc

Namespace Controllers
    Public Class JobanzeigeController
        Inherits Controller
        Public Shared mlstBranche As List(Of Branche)
        Public Shared mjobanzeigeListe As JobanzeigenListe
        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"

        Private db As collabDBEntities = New collabDBEntities '= New collabEntities


        'laden alle zugehörigen Jobanzeigen
        'GET: /Jobanzeige/meineJobanzeigen
        Function meineJobanzeigen() As ActionResult

            ' Deklaration
            Dim job As Jobanzeige
            Dim jaEntity As JobanzeigeEntity
            Dim jaListe As JobanzeigenListe

            ' Leere Liste initialisieren
            jaListe = New JobanzeigenListe()

            ' Alle Jobanzeigen aus der Datenbank holen
            For Each jaEntity In db.tblJobanzeigen.ToList
                ' Überprüfen, ob der Entity zum angemeldeten Unternehmer gehört
                If jaEntity.JaUIdFk.ToString().Equals(System.Web.HttpContext.Current.Session("BenutzerID")) Then
                    ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
                    job = New Jobanzeige(jaEntity)

                    ' Objekt der Model-Klasse zur Liste hinzufügen
                    jaListe.Jobanzeige.Add(job)
                End If
            Next

            ' Gesamte list anzeigen
            Return View(jaListe)
        End Function

        'GET: /Jobanzeige/Bearbeiten
        <HttpGet>
        Function Bearbeiten(ID As Integer) As ActionResult
            'Deklaration
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity
            Dim branche As Branche
            Dim brEntity As BrancheEntity
            Dim lstBranche As List(Of Branche)
            Dim vmJob As JobanzeigeViewModel

            'Datenbankzugriff über Entity Framework
            jobEntity = db.tblJobanzeigen.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblJobanzeige nachschlagen
            brEntity = jobEntity.tblBranchen 'Vom Datensatz aus tblJobanzeige in tblKategorien navigieren

            If jobEntity Is Nothing Then
                Return New HttpNotFoundResult("Aufgabe mit der ID " & ID & " wurde nicht gefunden") 'wenn keine Jobanzeige gefunden, laden
            End If
            'Gefundenen Datensatz aus der Datenbank loslösen
            db.Entry(jobEntity).State = EntityState.Detached
            'Umwandeln in ein Objekt der Model-Klasse
            job = New Jobanzeige(jobEntity)

            'Prüfen, ob Branche vorhanden
            If brEntity IsNot Nothing Then
                job.Branche = New Branche(brEntity)
            End If
            'Alle Branche aus Datenbank laden
            lstBranche = New List(Of Branche)
            For Each brEntity In db.tblBranchen.ToList
                branche = New Branche(brEntity)
                lstBranche.Add(branche)
            Next
            'Vorbereitung des View-Models
            vmJob = New JobanzeigeViewModel
            vmJob.Jobanzeige = job
            vmJob.ListeBranche = lstBranche

            Return View(vmJob) 'ViewModel mit Jobanzeige und allen Branchen an die View zur Bearbeitung geben
        End Function

        'POST: /Jobanzeige/Bearbeiten
        <HttpPost>
        Function Bearbeiten(pvmJobanzeige As JobanzeigeViewModel) As ActionResult
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity
            Dim branche As Branche
            Dim lstBranche As List(Of Branche)

            If Not (ModelState.IsValid) Then
                lstBranche = New List(Of Branche) 'alle Branche aus Datenbank laden
                For Each brEntity In db.tblBranchen.ToList
                    branche = New Branche(brEntity)
                    lstBranche.Add(branche)
                Next

                'Wenn nicht, dann zurück an die View
                Return View(pvmJobanzeige)
            End If

            'Jobanzeige aus dem ViewModel holen und in JobanzeigeEntity umwandeln
            job = pvmJobanzeige.Jobanzeige
            jobEntity = job.gibAlsJobanzeigeEntity
            'Speichern vorbereiten
            db.tblJobanzeigen.Attach(jobEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(jobEntity).State = EntityState.Modified 'als Geändert markieren

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Bearbeiten war nicht erfolgreich.")
            End Try

            Return RedirectToAction("meineJobanzeigen") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function


        'GET: /Jobanzeige/Hinzufuegen
        Function Hinzufuegen() As ActionResult
            Dim job As Jobanzeige
            Dim branche As Branche
            Dim lstBranche As List(Of Branche)
            Dim vmJob As JobanzeigeViewModel

            job = New Jobanzeige 'Neue leere Jobanzeige erzeugen

            'Alle Kategorien aus Datenbank laden
            lstBranche = New List(Of Branche)
            For Each brancheEntity In db.tblBranchen.ToList
                branche = New Branche(brancheEntity)
                lstBranche.Add(branche)
            Next

            'ViewModel vorbereiten
            vmJob = New JobanzeigeViewModel
            vmJob.Jobanzeige = job
            vmJob.ListeBranche = lstBranche
            Return View(vmJob) 'Neue Jobanzeige und Liste aller 
            'branche als ViewModel an die View übergeben
        End Function

        'POST: /Jobanzeige/Hinzufuegen
        <HttpPost>
        Function Hinzufuegen(pvmJob As JobanzeigeViewModel) As ActionResult
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity
            Dim branche As Branche
            Dim lstBranche As List(Of Branche)

            If Not ModelState.IsValid Then
                lstBranche = New List(Of Branche) 'Alle Branche aus Datenbank laden

                For Each brancheEntity In db.tblBranchen.ToList
                    branche = New Branche(brancheEntity)
                    lstBranche.Add(branche)
                Next
                pvmJob.ListeBranche = lstBranche
                Return View(pvmJob)
            End If

            'Jobanzeige aus dem ViewModel holen und in Jobanzeige entity umwandeln
            job = pvmJob.Jobanzeige
            job.UnternehmerID = Web.HttpContext.Current.Session("BenutzerID")
            jobEntity = job.gibAlsJobanzeigeEntity
            'speichern vorbereiten
            db.tblJobanzeigen.Attach(jobEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(jobEntity).State = EntityState.Added 'als Hinzugefügt markieren

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Hinzufügen war nicht erfolgreich.")
            End Try
            Return RedirectToAction("meineJobanzeigen") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function


        'GET: /Jobanzeige/Loeschen
        Function Loeschen(ID As Integer) As ActionResult
            'Dim job As Jobanzeige
            'Dim jobEntity As JobanzeigeEntity = db.tblJobanzeigen.Find(ID)

            'If IsNothing(jobEntity) Then
            '    Return RedirectToAction("Index")
            'End If

            'db.Entry(jobEntity).State = EntityState.Detached

            'job = New Jobanzeige(jobEntity)
            'Return View(job)

            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity
            jobEntity = db.tblJobanzeigen.Find(ID) 'Jobanzeige in Datenbank finden

            If jobEntity Is Nothing Then
                Return New HttpNotFoundResult("Jobanzeige mit der ID " & ID & " wurde nicht gefunden.")
            End If

            db.Entry(jobEntity).State = EntityState.Detached

            job = New Jobanzeige(jobEntity)
            Return View(job) 'An die View geben, damit dort das Löschen bestätigt werden soll
        End Function

        'POST: /Jobanzeige/Loeschen
        <HttpPost>
        Function Loeschen(pJob As Jobanzeige) As ActionResult
            Dim jobEntity As JobanzeigeEntity

            ' Aufgabe in AufgabeEntity umwandeln
            jobEntity = pJob.gibAlsJobanzeigeEntity
            'Speichern vorbereiten
            db.tblJobanzeigen.Attach(jobEntity)
            db.Entry(jobEntity).State = EntityState.Deleted 'als Gelöscht markieren
            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                ModelState.AddModelError(String.Empty, "Löschen war nicht erfolgreich.")
            End Try

            Return RedirectToAction("meineJobanzeigen") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function

        Function Bewerben(ID As Integer) As ActionResult
            'Deklaration
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity
            Dim branche As Branche
            Dim brEntity As BrancheEntity
            Dim vmJob As JobanzeigeViewModel

            'Datenbankzugriff über Entity Framework
            jobEntity = db.tblJobanzeigen.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblJobanzeige nachschlagen
            brEntity = jobEntity.tblBranchen 'Vom Datensatz aus tblJobanzeige in tblKategorien navigieren

            If jobEntity Is Nothing Then
                Return New HttpNotFoundResult("Jobanzeige mit der ID " & ID & " wurde nicht gefunden") 'wenn keine Jobanzeige gefunden, laden
            End If
            'Gefundenen Datensatz aus der Datenbank loslösen
            db.Entry(jobEntity).State = EntityState.Detached
            'Umwandeln in ein Objekt der Model-Klasse
            job = New Jobanzeige(jobEntity)

            'Prüfen, ob Branche vorhanden
            If brEntity IsNot Nothing Then
                job.Branche = New Branche(brEntity)
            End If

            brEntity = db.tblBranchen.Find(jobEntity.JaBrIdFk)

            If brEntity Is Nothing Then
                Return New HttpNotFoundResult("Branche mit der ID " & jobEntity.JaBrIdFk & " wurde nicht gefunden") 'wenn keine Branche gefunden, laden
            End If
            db.Entry(brEntity).State = EntityState.Detached
            branche = New Branche(brEntity)

            job.Branche = branche

            'Vorbereitung des View-Models
            vmJob = New JobanzeigeViewModel
            vmJob.Jobanzeige = job

            Return View(vmJob)
        End Function

        <HttpPost>
        Function Bewerben(pvmJobanzeige) As ActionResult
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity

            'Jobanzeige aus dem ViewModel holen und in JobanzeigeEntity umwandeln
            job = pvmJobanzeige.Jobanzeige
            jobEntity = job.gibAlsJobanzeigeEntity
            'Speichern vorbereiten
            db.tblJobanzeigen.Attach(jobEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(jobEntity).State = EntityState.Modified 'als Geändert markieren

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Öffnen war nicht erfolgreich.")
            End Try

            Return RedirectToAction("AlleJobanzeigen", "AlleJobanzeigen") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function

    End Class
End Namespace