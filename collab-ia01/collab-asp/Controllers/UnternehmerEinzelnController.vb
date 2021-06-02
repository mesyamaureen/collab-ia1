Imports System.Web.Mvc

Namespace Controllers
    Public Class UnternehmerEinzelnController
        Inherits Controller

        ' GET: UnternehmerEinzeln
        Function Index() As ActionResult
            Return View()
        End Function



        ' GET: UnternehmerEinzeln/Edit/5
        Function UnternehmenBearbeiten(pUintId As Integer) As ActionResult
            Return View()
        End Function


    End Class
End Namespace