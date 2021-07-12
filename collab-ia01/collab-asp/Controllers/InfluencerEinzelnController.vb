Imports System.Web.Mvc

Namespace Controllers
    Public Class InfluencerEinzelnController
        Inherits Controller
        Private Const CONCURRENCY_EXCEPTION As String = "DBUpdateConcurrencyException"
        Private db As collabDBEntities = New collabDBEntities

        'GET: /InfluencerEinzeln/Influencer
        Function Influencer(pintInfluencerID As Integer) As ActionResult
            Dim inf As Influencer
            Dim infEntity As InfluencerEntity
            Dim infListe As InfluencerListe

            'influencer leeren
            inf = New Influencer()
            infListe = New InfluencerListe()
            'Alle Influencer aus der Datenbank holen
            For Each infEntity In db.tblInfluencer.ToList
                'If infEntity.InIdPk.ToString().Equals(ausgewaehlterInfluencer) Then
            Next

            ' Alle Jobanzeigen aus der Datenbank holen
            'For Each jaEntity In db.tblJobanzeigen.ToList
            '    ' Überprüfen, ob der Entity zum angemeldeten Unternehmer gehört
            '    If jaEntity.JaUIdFk.ToString().Equals(System.Web.HttpContext.Current.Session("BenutzerID")) Then
            '        ' Objekt der Entity-Klasse in Objekt der Model-Klasse umwandeln
            '        job = New Jobanzeige(jaEntity)

            '        ' Objekt der Model-Klasse zur Liste hinzufügen
            '        jaListe.Jobanzeige.Add(job)
            '    End If
            'Next

            Return View()
        End Function

        'POST: /InfluencerEinzeln/Influencer
        <HttpPost>
        Function Influencer(pinfEntity As InfluencerEntity) As ActionResult

        End Function

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