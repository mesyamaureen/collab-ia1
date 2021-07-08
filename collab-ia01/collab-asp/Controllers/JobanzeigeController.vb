Imports System.Web.Mvc

Namespace Controllers
    Public Class JobanzeigeController
        Inherits Controller
        Public Shared mlstBranche As List(Of Branche)

        Private db As collabEntities = New collabEntities

        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"

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

        Function Bearbeiten(ID As Integer) As ActionResult
            Dim job As Jobanzeige
            Dim jobEntity As JobanzeigeEntity = db.tblJobanzeigen.Find(ID)

            If IsNothing(jobEntity) Then
                Return RedirectToAction("Index")
            End If

            db.Entry(jobEntity).State = EntityState.Detached

            job = New Jobanzeige()
            Return View(job)

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