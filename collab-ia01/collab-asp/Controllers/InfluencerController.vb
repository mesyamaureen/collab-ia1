Imports System.Web.Mvc

Namespace Controllers
    Public Class InfluencerController
        Inherits Controller

        ' GET: Influencer
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace