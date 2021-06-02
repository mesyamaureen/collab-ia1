Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleInfluencerController
        Inherits Controller

        ' GET: AlleInfluencer
        Function Index() As ActionResult
            Return View()
        End Function

        Function OeffnenInfluencer(pInId As Integer) As ActionResult
            Return View()
        End Function

        Function LoeschenInfluencer(pInintId As Integer) As ActionResult
            Return View()
        End Function

        Function NeuInfluencer() As Influencer
            Return View()

        End Function


    End Class
End Namespace