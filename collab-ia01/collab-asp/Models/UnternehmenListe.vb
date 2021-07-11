Public Class UnternehmenListe
    Private mlstUnternehmen As List(Of Unternehmen)

    Public Sub New()
        mlstUnternehmen = New List(Of Unternehmen)
    End Sub

    Public Sub New(plstUnternehmen As List(Of Unternehmen))
        mlstUnternehmen = plstUnternehmen
    End Sub


    Public Property Unternehmen As List(Of Unternehmen)
        Get
            Return mlstUnternehmen
        End Get
        Set(value As List(Of Unternehmen))
            mlstUnternehmen = value
        End Set
    End Property
End Class
