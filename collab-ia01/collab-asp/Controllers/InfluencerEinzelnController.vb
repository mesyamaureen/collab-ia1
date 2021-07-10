Imports System.Web.Mvc

Namespace Controllers
    Public Class InfluencerEinzelnController
        Inherits Controller

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