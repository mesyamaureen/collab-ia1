Public Class UnternehmerViewModel
    Private mUnternehmen As Unternehmen
    Private mlstBranche As List(Of Branche)

    Public Property Unternehmen As Unternehmen
        Get
            Return mUnternehmen
        End Get
        Set(value As Unternehmen)
            mUnternehmen = value
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
