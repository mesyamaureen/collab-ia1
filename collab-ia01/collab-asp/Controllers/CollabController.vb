Imports System.Web.Mvc

Namespace Controllers
    Public Class CollabController
        Inherits Controller

        ' GET: Collab
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: InfluencerSuchen
        Function InfluencerSuchen() As ActionResult
            Return View()
        End Function

        'GET: UnternehmenSuchen
        Function UnternehmenSuchen() As ActionResult
            Return View()
        End Function

        'GET: Registrieren
        Function Registrieren() As ActionResult
            Return View()
        End Function

        'GET: Impressum
        Function Impressum() As ActionResult
            Return View()
        End Function
    End Class
End Namespace