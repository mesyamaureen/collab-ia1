Public Class JobanzeigenListe
    Private mlstJobanzeigen As List(Of Jobanzeige)

    Public Sub New()
        mlstJobanzeigen = New List(Of Jobanzeige)
    End Sub

    Public Sub New(plstJobanzeigen As List(Of Jobanzeige))
        mlstJobanzeigen = plstJobanzeigen
    End Sub


    Public Property Jobanzeige As List(Of Jobanzeige)
        Get
            Return mlstJobanzeigen
        End Get
        Set(value As List(Of Jobanzeige))
            mlstJobanzeigen = value
        End Set
    End Property
End Class
