Imports System.Web.Mvc

Namespace Controllers
    Public Class InfluencerEinzelnController
        Inherits Controller

        ' GET: InfluencerEinzeln
        Function Index() As ActionResult
            Return View()
        End Function

        ' GET: UnternehmerEinzeln/Edit/5
        Function InfluencerBearbeiten(pInId As Integer) As ActionResult
            Return View()
        End Function
    End Class
End Namespace