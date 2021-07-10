Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleJobanzeigenController
        Inherits Controller

        Private db As collabDBEntities = New collabDBEntities

        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"

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

        'Function Bearbeiten(ID As Integer) As ActionResult
        '    ''Deklaration
        '    'Dim job As Jobanzeige
        '    'Dim jobEntity As JobanzeigeEntity = db.tblJobanzeigen.Find(ID)
        '    ''Falls keine entsprechende Job gefunden wurde
        '    'If IsNothing(jobEntity) Then
        '    '    Return RedirectToAction("Index")
        '    'End If

        '    'db.Entry(jobEntity).State = EntityState.Detached

        '    'job = New Jobanzeige()
        '    'Return View(job)

        '    'Deklaration
        '    Dim job As Jobanzeige
        '    Dim jobEntity As JobanzeigeEntity
        '    Dim branche As Branche
        '    Dim brEntity As BrancheEntity
        '    Dim lstBranche As List(Of Branche)
        '    Dim vmJob As JobanzeigeViewModel

        '    'Datenbankzugriff über Entity Framework
        '    jobEntity = db.tblJobanzeigen.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblJobanzeige nachschlagen
        '    brEntity = jobEntity.tblBranchen 'Vom Datensatz aus tblJobanzeige in tblKategorien navigieren

        '    If jobEntity Is Nothing Then
        '        Return RedirectToAction("laden") 'wenn keine Jobanzeige gefunden, laden
        '    End If
        '    'Gefundene Datensatz aus der Datenbank loslösen
        '    db.Entry(jobEntity).State = EntityState.Detached
        '    'Umwandeln in ein Objekt der Model-Klasse
        '    job = New Jobanzeige(jobEntity)

        '    'Prüfen, ob Branche vorhanden
        '    If brEntity IsNot Nothing Then
        '        job.Branche = New Branche(brEntity)
        '    End If
        '    'Alle Branche aus Datenbank laden
        '    lstBranche = New List(Of Branche)
        '    For Each brEntity In db.tblBranchen.ToList
        '        branche = New Branche(brEntity)
        '        lstBranche.Add(branche)
        '    Next
        '    'Vorbereitung des View-Models
        '    vmJob = New JobanzeigeViewModel
        '    vmJob.Jobanzeige = job
        '    vmJob.ListeBranche = lstBranche

        '    Return View(vmJob) 'ViewModel mit Jobanzeige und allen Branchen an die View zur Bearbeitung geben
        'End Function

        ''POST: /Jobanzeige/Bearbeiten
        '<HttpPost>
        'Function Bearbeiten(pvmJobanzeige As JobanzeigeViewModel) As ActionResult
        '    Dim job As Jobanzeige
        '    Dim jobEntity As JobanzeigeEntity
        '    Dim branche As Branche
        '    Dim lstBranche As List(Of Branche)

        '    If Not (ModelState.IsValid) Then
        '        lstBranche = New List(Of Branche) 'alle Branche aus Datenbank laden
        '        For Each brEntity In db.tblBranchen.ToList
        '            branche = New Branche(brEntity)
        '            lstBranche.Add(branche)
        '        Next

        '        'Wenn nicht, dann zurück an die View
        '        Return View(pvmJobanzeige)
        '    End If

        '    'Jobanzeige aus dem ViewModel holen und in JobanzeigeEntity umwandeln
        '    job = pvmJobanzeige.Jobanzeige
        '    jobEntity = job.gibAlsJobanzeigeEntity
        '    'Speichern vorbereiten
        '    db.tblJobanzeigen.Attach(jobEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
        '    db.Entry(jobEntity).State = EntityState.Modified 'als Geändert markieren

        '    'Vorsichtig Änderungen speichern
        '    Try
        '        db.SaveChanges()
        '    Catch ex As Exception
        '        'Im Fehlerfall wird der Fehler im ViewModel vermerkt
        '        ModelState.AddModelError(String.Empty, "Bearbeiten war nicht erfolgreich.")
        '    End Try

        '    Return RedirectToAction("laden") 'Zurück zur Übersicht über alle Jobanzeigen
        'End Function

    End Class
End Namespace