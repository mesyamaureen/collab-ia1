Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleInfluencerController
        Inherits Controller

        ' GET: AlleInfluencer
        Function Index() As ActionResult
            Return View()
        End Function

        Function Oeffnen(pInId As Integer) As ActionResult
            Return View()
        End Function

        Function Loeschen(pInintId As Integer) As ActionResult
            Return View()
        End Function

        Function Neu() As ActionResult
            Return View()

        End Function


    End Class
End Namespace