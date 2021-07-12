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

    'Properties
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
    End Sub

    'Konstruktor mit Parametern
    Sub New(pstrVorname As String, pstrName As String, pbrBranche As Branche, pstrBenutzername As String, pintBrancheID As Integer)
        mstrVorname = pstrVorname
        mstrName = pstrName
        mbrBranche = pbrBranche
        mstrBenutzername = pstrBenutzername
        mintBrancheID = pintBrancheID
    End Sub

    Sub New(pinflEntity As InfluencerEntity)
        mstrVorname = pinflEntity.InVorname
        mstrName = pinflEntity.InName
        mstrBenutzername = pinflEntity.InBenutzername
        mintBrancheID = pinflEntity.InBrIdFk
        'mbrBranche = pinflEntity.InBrIdFk
    End Sub
End Class
