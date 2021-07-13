Public Class BenutzerViewModel
    Private mBenutzer As Benutzer
    Private mInfluencer As Influencer
    Private mUnternehmen As Unternehmen
    Private mlstBranche As List(Of Branche)
    Private mlstInfluencer As List(Of Influencer)
    Private mlstUnternehmen As List(Of Unternehmen)

    Public Property Influencer As Influencer
        Get
            Return mInfluencer
        End Get
        Set(value As Influencer)
            mInfluencer = value
        End Set
    End Property

    Public Property Unternehmen As Unternehmen
        Get
            Return mUnternehmen
        End Get
        Set(value As Unternehmen)
            mUnternehmen = value
        End Set
    End Property

    Public Property Benutzer As Benutzer
        Get
            Return mBenutzer
        End Get
        Set(value As Benutzer)
            mBenutzer = value
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

    Public Property ListeInfluencer As List(Of Influencer)
        Get
            Return mlstInfluencer
        End Get
        Set(value As List(Of Influencer))
            mlstInfluencer = value
        End Set
    End Property

    Public Property ListeUnternehmen As List(Of Unternehmen)
        Get
            Return mlstUnternehmen
        End Get
        Set(value As List(Of Unternehmen))
            mlstUnternehmen = value
        End Set
    End Property
End Class
