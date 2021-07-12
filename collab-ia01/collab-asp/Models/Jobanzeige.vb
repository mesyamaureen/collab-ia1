Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

'ACHTUNG: JOBANZEIGE EINES BENUTZERS
Public Class Jobanzeige
    Private mintJobID As Integer
    Private mstrTitel As String
    Private mstrBeschreibung As String
    Private mbrBranche As Branche
    Private mlstJobanzeigeAlle As List(Of Jobanzeige)
    Private muntId As Integer
    Private untBrancheId As Integer
    Private minfId As Integer
    Private mbytVersion As Byte()

    'Parameterloser Konstruktor
    Sub New()
        mintJobID = -1
        mstrTitel = String.Empty
        mstrBeschreibung = String.Empty
        mbrBranche = Nothing
        muntId = Nothing
        'mbytVersion = Nothing
    End Sub
    'Konstruktor mit Parameter
    Sub New(pintJobID As Integer, pstrTitel As String, pstrBeschreibung As String, pbrBranche As Branche, puntId As Integer)
        mintJobID = pintJobID
        mstrTitel = pstrTitel
        mstrBeschreibung = pstrBeschreibung
        mbrBranche = pbrBranche
        muntId = puntId
        'mbytVersion = pbytVersion
    End Sub
    'Kosntruktor für Entity-Klasse
    Public Sub New(pJobanzeigeEntity As JobanzeigeEntity)
        mintJobID = pJobanzeigeEntity.JaIdPk
        mstrTitel = pJobanzeigeEntity.JaTitel
        mstrBeschreibung = pJobanzeigeEntity.JaBeschreibung
        muntId = pJobanzeigeEntity.JaUIdFk


        If IsNothing(pJobanzeigeEntity.JaVersion) Then
            mbytVersion = Nothing
        Else
            mbytVersion = pJobanzeigeEntity.JaVersion
        End If

        mbrBranche = New Branche(pJobanzeigeEntity.JaBrIdFk, "")
    End Sub

    'Properties
    Public Property JobID As Integer
        Get
            Return mintJobID
        End Get
        Set(value As Integer)
            mintJobID = value
        End Set
    End Property

    Public Property Titel As String
        Get
            Return mstrTitel
        End Get
        Set(value As String)
            mstrTitel = value
        End Set
    End Property

    Public Property Beschreibung As String
        Get
            Return mstrBeschreibung
        End Get
        Set(value As String)
            mstrBeschreibung = value
        End Set
    End Property

    Public Property Branche As Branche
        Get
            Return mbrBranche
        End Get
        Set(value As Branche)
            mbrBranche = value
        End Set
    End Property
    Public Property Version As Byte()
        Get
            Return mbytVersion
        End Get
        Set(value As Byte())
            mbytVersion = value
        End Set
    End Property

    Public Property ListeJobanzeige As List(Of Jobanzeige)
        Get
            Return mlstJobanzeigeAlle
        End Get
        Set(value As List(Of Jobanzeige))
            mlstJobanzeigeAlle = value
        End Set
    End Property

    Public Property UnternehmerID As Integer
        Get
            Return muntId
        End Get
        Set(value As Integer)
            muntId = value
        End Set
    End Property

    Public Property InfluencerID As Integer
        Get
            Return minfId
        End Get
        Set(value As Integer)
            minfId = value
        End Set
    End Property


    Public Function gibAlsJobanzeigeEntity() As JobanzeigeEntity
        Dim jobE As JobanzeigeEntity
        jobE = New JobanzeigeEntity

        jobE.JaIdPk = mintJobID
        jobE.JaTitel = mstrTitel
        jobE.JaBeschreibung = mstrBeschreibung
        jobE.JaUIdFk = muntId

        If mbrBranche IsNot Nothing Then
            jobE.JaBrIdFk = mbrBranche.BrancheID
        End If

        Return jobE
    End Function

End Class
