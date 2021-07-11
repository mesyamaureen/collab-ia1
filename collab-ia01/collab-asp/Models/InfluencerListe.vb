Public Class InfluencerListe
    Private mlstInfluencer As List(Of Influencer)

    Public Sub New()
        mlstInfluencer = New List(Of Influencer)
    End Sub

    Public Sub New(plstInfluencer As List(Of Influencer))
        mlstInfluencer = plstInfluencer
    End Sub


    Public Property Influencer As List(Of Influencer)
        Get
            Return mlstInfluencer
        End Get
        Set(value As List(Of Influencer))
            mlstInfluencer = value
        End Set
    End Property
End Class
