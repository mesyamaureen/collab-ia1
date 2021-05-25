Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleInfluencerController
        Inherits Controller

        ' GET: AlleInfluencer
        Function Index() As ActionResult
            Return View()
        End Function

        Function OeffnenInfluencer(pInId As Integer) As ActionResult

        End Function

        Function LoeschenInfluencer(pInintId As Integer) As ActionResult

        End Function

        Function NeuInfluencer() As Influencer

        End Function


    End Class
End Namespace