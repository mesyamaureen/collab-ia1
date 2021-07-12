Imports System.Web.Mvc

Namespace Controllers
    Public Class InfluencerEinzelnController
        Inherits Controller
        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"
        Private db As collabDBEntities = New collabDBEntities

        'GET: /InfluencerEinzeln/Influencer
        Function Influencer(ID As Integer) As ActionResult
            'Deklaration
            Dim inf As Influencer
            Dim infEntity As InfluencerEntity
            Dim branche As Branche
            Dim brEntity As BrancheEntity
            'Dim lstBranche As List(Of Branche)
            Dim vmInf As InfluencerViewModel

            'Datenbankzugriff über Entity Framework
            infEntity = db.tblInfluencer.Find(ID) 'Datensatz mit diesem Primärschlüssel in tblJobanzeige nachschlagen
            brEntity = infEntity.tblBranchen 'Vom Datensatz aus tblJobanzeige in tblKategorien navigieren

            If infEntity Is Nothing Then
                Return New HttpNotFoundResult("Influencer mit der ID " & ID & " wurde nicht gefunden") 'wenn keine Influencer gefunden, laden
            End If
            'Gefundenen Datensatz aus der Datenbank loslösen
            db.Entry(infEntity).State = EntityState.Detached
            'Umwandeln in ein Objekt der Model-Klasse
            inf = New Influencer(infEntity)

            'Prüfen, ob Branche vorhanden
            If brEntity IsNot Nothing Then
                inf.Branche = New Branche(brEntity)
            End If

            brEntity = db.tblBranchen.Find(infEntity.InBrIdFk)

            If brEntity Is Nothing Then
                Return New HttpNotFoundResult("Branche mit der ID " & infEntity.InBrIdFk & " wurde nicht gefunden") 'wenn keine Branche gefunden, laden
            End If
            db.Entry(brEntity).State = EntityState.Detached
            branche = New Branche(brEntity)

            inf.Branche = branche

            'Alle Branche aus Datenbank laden
            'lstBranche = New List(Of Branche)
            'For Each brEntity In db.tblBranchen.ToList
            '    branche = New Branche(brEntity)
            '    lstBranche.Add(branche)
            'Next

            'Vorbereitung des View-Models
            vmInf = New InfluencerViewModel
            vmInf.Influencer = inf
            'vmInf.ListeBranche = lstBranche

            Return View(vmInf) 'ViewModel mit Jobanzeige und allen Branchen an die View zur Bearbeitung geben
        End Function

        'POST: /InfluencerEinzeln/Influencer
        <HttpPost>
        Function Influencer(pvmInf As InfluencerViewModel) As ActionResult
            Dim inf As Influencer
            Dim infEntity As InfluencerEntity
            'Dim branche As Branche
            'Dim lstBranche As List(Of Branche)

            'If Not (ModelState.IsValid) Then
            '    lstBranche = New List(Of Branche) 'alle Branche aus Datenbank laden
            '    For Each brEntity In db.tblBranchen.ToList
            '        branche = New Branche(brEntity)
            '        lstBranche.Add(branche)
            '    Next

            '    'Wenn nicht, dann zurück an die View
            '    Return View(pvmJobanzeige)
            'End If

            'Jobanzeige aus dem ViewModel holen und in JobanzeigeEntity umwandeln
            inf = pvmInf.Influencer
            infEntity = inf.gibAlsInfluencerEntity
            'Speichern vorbereiten
            db.tblInfluencer.Attach(infEntity) 'Objekt der Entity-Klasse wieder mit Datenbank bekannt machen
            db.Entry(infEntity).State = EntityState.Modified 'als Geändert markieren

            'Vorsichtig Änderungen speichern
            Try
                db.SaveChanges()
            Catch ex As Exception
                'Im Fehlerfall wird der Fehler im ViewModel vermerkt
                ModelState.AddModelError(String.Empty, "Öffnen war nicht erfolgreich.")
            End Try

            Return RedirectToAction("Influencersuchen", "AlleInfluencer") 'Zurück zur Übersicht über alle Jobanzeigen
        End Function

        'Nach Login
        ' GET: InfluencerEinzeln
        Function MeinProfilInfluencer() As ActionResult
            Return View()
        End Function

        ' GET: InfluencerEinzeln/Edit/5
        Function InfluencerBearbeiten(pInId As Integer) As ActionResult
            Return View()
        End Function
    End Class
End Namespace