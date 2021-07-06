Public Class JobanzeigeViewModel
    Private mJobanzeige As Jobanzeige
    Private mlstBranche As List(Of Branche)

    Public Property Jobanzeige As Jobanzeige
        Get
            Return mJobanzeige
        End Get
        Set(value As Jobanzeige)
            mJobanzeige = value
        End Set
    End Property

    Public Property ListeBranche As List(Of Branche)
        Get
            Return mlstBranche
        End Get
        Set(value As List(Of Branche))
            mlstBranche = value
        End Set
    End Property
End Class
