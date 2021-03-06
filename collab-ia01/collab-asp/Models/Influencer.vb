Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Influencer
    Inherits Benutzer

    Private mstrVorname As String
    Private mstrName As String
    Private mbrBranche As Branche
    Private mjAnzeigen As List(Of Jobanzeige)
    Private mstrBenutzername As String
    Private mintBrancheID As Integer
    Private mintInfluencerID As Integer
    Private mstrPasswort As String
    Private mstrEmail As String
    Private mstrBeschreibung As String

    'Properties
    Public Property Passwort As String
        Get
            Return mstrPasswort
        End Get
        Set(value As String)
            mstrPasswort = value
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


    Public Property Email As String
        Get
            Return mstrEmail
        End Get
        Set(value As String)
            mstrEmail = value
        End Set
    End Property

    Public Property InfluencerID As Integer
        Get
            Return mintInfluencerID
        End Get
        Set(value As Integer)
            mintInfluencerID = value
        End Set
    End Property

    Public Property BrancheID As Integer
        Get
            Return mintBrancheID
        End Get
        Set(value As Integer)
            mintBrancheID = value
        End Set
    End Property

    Public Property Benutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)
            mstrBenutzername = value
        End Set
    End Property

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)
            mstrVorname = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)
            mstrName = value
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

    Public Property Bewerbungen As List(Of Jobanzeige)
        Get
            Return mjAnzeigen
        End Get
        Set(value As List(Of Jobanzeige))
            mjAnzeigen = value
        End Set
    End Property


    'Parameterloser Konstruktor
    Sub New()
        mstrVorname = String.Empty
        mstrName = String.Empty
        mbrBranche = Nothing
        mstrBenutzername = Nothing
        mintBrancheID = Nothing
        mintInfluencerID = Nothing
        mstrEmail = String.Empty
        mstrBeschreibung = String.Empty
        mstrPasswort = String.Empty
    End Sub

    'Konstruktor mit Parametern
    Sub New(pstrVorname As String, pstrName As String, pbrBranche As Branche, pstrBenutzername As String, pintBrancheID As Integer, pintInfluencerID As Integer, pstrEmail As String, pstrBeschreibung As String, pstrPasswort As String)
        mstrVorname = pstrVorname
        mstrName = pstrName
        mbrBranche = pbrBranche
        mstrBenutzername = pstrBenutzername
        mintBrancheID = pintBrancheID
        mintInfluencerID = pintInfluencerID
        mstrEmail = pstrEmail
        mstrBeschreibung = pstrBeschreibung
        mstrPasswort = pstrPasswort
    End Sub

    Sub New(pinflEntity As InfluencerEntity)
        mstrVorname = pinflEntity.InVorname
        mstrName = pinflEntity.InName
        mstrBenutzername = pinflEntity.InBenutzername
        mintBrancheID = pinflEntity.InBrIdFk
        mintInfluencerID = pinflEntity.InIdPk
        mstrEmail = pinflEntity.InEMail
        mstrBeschreibung = pinflEntity.InBeschreibung
        mstrPasswort = pinflEntity.InPasswort
    End Sub

    Public Function gibAlsInfluencerEntity() As InfluencerEntity
        Dim infE As InfluencerEntity
        infE = New InfluencerEntity

        infE.InIdPk = mintInfluencerID
        infE.InBenutzername = mstrBenutzername
        infE.InPasswort = Passwort
        infE.InName = mstrName
        infE.InVorname = mstrVorname
        infE.InEMail = mstrEmail
        infE.InBeschreibung = mstrBeschreibung

        If mbrBranche IsNot Nothing Then
            infE.InBrIdFk = mbrBranche.BrancheID
        End If

        Return infE
    End Function
End Class
