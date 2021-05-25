Imports System.Web.Mvc

Namespace Controllers
    Public Class AlleUnternehmenController
        Inherits Controller

        ' GET: AlleUnternehmen
        Function Index() As ActionResult
            Return View()
        End Function

        Function OeffenenUnternehmen(pUnId As Integer) As ActionResult

        End Function

        Function LoeschenUnternehmen(pUintId As Integer) As ActionResult

        End Function

        Function NeuUnternehmer() As Unternehmen

        End Function



    End Class
End Namespace