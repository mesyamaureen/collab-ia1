Imports System.Web.Mvc
Imports collab_asp.Benutzer

Namespace Controllers
    Public Class AlleProfileController
        Inherits Controller

        ' GET: AlleProfile
        Function Index() As ActionResult
            Return View()
        End Function


        Function Einloggen() As ActionResult
            Return View()
        End Function

        <HttpPost>
        <ValidateAntiForgeryToken>
        Function Einloggen(pben As Benutzer) As ActionResult
            If ModelState.IsValid Then
                Using db As collabDBEntities = New collabDBEntities
                    'Dim infl As InfluencerEntity
                    Dim benInfluencer As InfluencerEntity
                    Try
                        For Each infl In db.tblInfluencer.ToList
                            If (infl.InBenutzername.Equals(pben.Benutzername) And infl.InPasswort.Equals(pben.Passwort)) Then
                                benInfluencer = infl
                            End If
                        Next
                    Catch ex As Exception
                        benInfluencer = Nothing
                    End Try


                    If benInfluencer IsNot Nothing Then
                        System.Web.HttpContext.Current.Session("BenutzerID") = benInfluencer.InIdPk.ToString()
                        System.Web.HttpContext.Current.Session("Benutzername") = benInfluencer.InBenutzername.ToString()
                        System.Web.HttpContext.Current.Session("Benutzertyp") = "Influencer"
                        Return RedirectToAction("MeinProfilInfluencer", "InfluencerEinzeln")
                    Else
                        Dim unt As UnternehmerEntity
                        Dim benUnt As UnternehmerEntity

                        For Each unt In db.tblUnternehmer.ToList
                            If (unt.UBenutzername.Equals(pben.Benutzername) And unt.UPasswort.Equals(pben.Passwort)) Then
                                benUnt = unt
                            End If
                        Next

                        If benUnt IsNot Nothing Then
                            System.Web.HttpContext.Current.Session("BenutzerID") = benUnt.UIdPk.ToString()
                            System.Web.HttpContext.Current.Session("Benutzername") = benUnt.UBenutzername.ToString()
                            System.Web.HttpContext.Current.Session("Benutzertyp") = "Unternehmer"
                            Return RedirectToAction("MeinProfilUnternehmer", "UnternehmerEinzeln")
                        End If
                    End If
                End Using
            End If
            Return View(pben)
        End Function
    End Class
End Namespace