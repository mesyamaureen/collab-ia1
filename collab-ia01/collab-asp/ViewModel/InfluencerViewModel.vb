Public Class InfluencerViewModel
    Private mInfluencer As Influencer
    Private mlstBranche As List(Of Branche)

    Public Property Influencer As Influencer
        Get
            Return mInfluencer
        End Get
        Set(value As Influencer)
            mInfluencer = value
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
