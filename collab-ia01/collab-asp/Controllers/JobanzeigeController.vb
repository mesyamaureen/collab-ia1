Imports System.Web.Mvc

Namespace Controllers
    Public Class JobanzeigeController
        Inherits Controller
        Public Shared mlstBranche As List(Of Branche)

        Private db As collabEntities '= New collabEntities

        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"

        Public Sub New()
            MyBase.New()
            db = New collabEntities
        End Sub

        'ausklammern?
        'Function Index() As ActionResult
        '    Dim lstJobanzeige As List(Of Jobanzeige)
        '    Dim job As Jobanzeige

        '    lstJobanzeige = New List(Of Jobanzeige)

        '    Dim elements = db.tblJobanzeigen.ToArray()

        '    ' Sollte vorher ein Speichern erfolgt sein, das auf diese Seite zurückführt, 
        '    ' muss hier geprüft werden, ob ein Fehler aufgetreten ist
        '    If TempData.ContainsKey(CONCURRENCY_EXCEPTION) Then
        '        ' wenn ja wird eine Fehlermeldung zum ModelState hinzufügt und anschließend in der View angezeigt
        '        ModelState.AddModelError(String.Empty, TempData.Item(CONCURRENCY_EXCEPTION))
        '        ' Fehlermeldung aus temporärer Zwischenablage entfernen, um sie nicht noch einmal anzuzeigen
        '        TempData.Remove(CONCURRENCY_EXCEPTION)
        '    End If
        '    Return View(lstJobanzeige)
        'End Function

        'ladenJobanzeigeEinzeln() - für Jobanzeige eines zugeordneten Unternehmens
        Function laden(pintID As Integer) As ActionResult
            Dim intID As Integer
            Dim strTitel As String
            Dim strBeschreibung As String



            'Benutzer prüfen, welcher angemeldete Unternehmer anhand Benutzer ID. Um die zugeordneten Jobanzeigen darzustellen

            'Alle Jobanzeigen in der Bewerbung.html Seite übertragen als eine Liste aller dazu gehörigen Jobanzeigen

            intID = Integer.Parse(Request.QueryString("ID"))
            strTitel = Request.QueryString("txtTitel")
            strBeschreibung = Request.QueryString("txtBeschreibung")
            Return View() 'hier nochmal überprüfen, ob es zurück in View geht oder zu anderer Funktion darunter z.B. AnzeigenJobanzeige
        End Function

        <HttpGet>
        Function Bearbeiten(ID As Integer) As ActionResult
            ''Deklaration
            'Dim job As Jobanzeige
            'Dim jobEntity As JobanzeigeEntity = db.tblJobanzeigen.Find(ID)
            ''Falls keine entsprechende Job gefunden wurde
            'If IsNothing(jobEntity) Then
            '    Return RedirectToAction("Index")
            'End If

            'db.Entry(jobEntity).State = EntityState.Detached

            'job = New Jobanzeige()
            'Return View(job)

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

            Return RedirectToAction("laden") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function


        Function Hinzufuegen(pjob As Jobanzeige) As ActionResult
            Dim jobEntity As JobanzeigeEntity

            jobEntity = pjob.gibAlsJobanzeigeEntity()

            If ModelState.IsValid Then
                db.tblJobanzeigen.Attach(jobEntity)
                db.Entry(jobEntity).State = EntityState.Added
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(pjob)
        End Function

        Function Loeschen(ID As Integer) As ActionResult
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity = db.tblJobanzeigen.Find(ID)

            If IsNothing(jobEntity) Then
                Return RedirectToAction("Index")
            End If

            db.Entry(jobEntity).State = EntityState.Detached

            job = New Jobanzeige(jobEntity)
            Return View(job)
        End Function

        'anzeigenFormular() - bei "Bearbeiten" + "hinzufügen" Pop-Up Fenster? 
        '<HttpPost>
        'Function Formular(ID As Integer) As ActionResult
        '    Dim intJobID As Integer
        '    Dim strTitel As String
        '    Dim strBeschreibung As String
        '    intJobID = Request.Form("intJobID")
        '    strTitel = Request.Form("strTitel")
        '    strBeschreibung = Request.Form("strBeschreibung")
        'End Function

        'speichern()
        <HttpPost>
        Function Speichern() As ActionResult 'nochmal sehen, ob benötigt ist
            'Dim intJobID As Integer
            'Dim strTitel As String
            'Dim strBeschreibung As String
            'strTitel = Request.Form("txtTitel")
            'strBeschreibung = Request.Form("txtBeschreibung")
        End Function

        'abbrechen?

    End Class
End Namespace