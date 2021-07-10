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
                    Dim benInfluencer As InfluencerEntity = From infl In db.tblInfluencer
                                                            Where (infl.InBenutzername.Equals(pben.Benutzername) And infl.InPasswort.Equals(pben.Passwort))
                    If benInfluencer IsNot Nothing Then
                        System.Web.HttpContext.Current.Session("BenutzerID") = benInfluencer.InIdPk.ToString()
                        System.Web.HttpContext.Current.Session("Benutzername") = benInfluencer.InBenutzername.ToString()
                        System.Web.HttpContext.Current.Session("Benutzertyp") = "Influencer"
                        Return RedirectToAction("UserDashBoard")
                    Else
                        Dim benUnt As UnternehmerEntity = From unt In db.tblUnternehmer
                                                          Where (unt.UBenutzername.Equals(pben.Benutzername) And unt.UPasswort.Equals(pben.Passwort))
                        If benUnt IsNot Nothing Then
                            System.Web.HttpContext.Current.Session("BenutzerID") = benUnt.UIdPk.ToString()
                            System.Web.HttpContext.Current.Session("Benutzername") = benUnt.UBenutzername.ToString()
                            System.Web.HttpContext.Current.Session("Benutzertyp") = "Unternehmer"
                            Return RedirectToAction("UserDashBoard")
                        End If
                    End If
                End Using
            End If
            Return View(pben)
        End Function

        Function UserDashBoard() As ActionResult
            If System.Web.HttpContext.Current.Session("BenutzerID") IsNot Nothing Then
                If System.Web.HttpContext.Current.Session("Benutzertyp") = "Influencer" Then
                    Return RedirectToAction("MeinProfilInfluencer", "InfluencerEinzeln") 'return view influencer
                Else
                    Return RedirectToAction("MeinProfilUnternehmer", "UnternehmerEinzeln") 'return view Unternehmer
                End If
            Else
                Return RedirectToAction("Einloggen")
            End If
        End Function

        Function AnzeigenListe() As List(Of Benutzer)

        End Function
    End Class
End Namespace