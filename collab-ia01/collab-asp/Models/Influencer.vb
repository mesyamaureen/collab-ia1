Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Influencer
    Inherits Benutzer

    Private mintInfluencerID As Integer
    Private mstrVorname As String
    Private mstrName As String
    Private mbrBranche As Branche
    Private mjAnzeige As Jobanzeige

    'Properties
    Public Property InfluencerID As Integer
        Get
            Return mintInfluencerID
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property Vorname As String
        Get
            Return mstrVorname
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Name As String
        Get
            Return mstrName
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Branche As Branche
        Get
            Return mbrBranche
        End Get
        Set(value As Branche)
        End Set
    End Property

    Public Property Bewerbung As Jobanzeige
        Get
            Return mjAnzeige
        End Get
        Set(value As Jobanzeige)
        End Set
    End Property

    'Parameterloser Konstruktor
    Sub New()
        mintInfluencerID = Nothing
        mstrVorname = String.Empty
        mstrName = String.Empty
        mbrBranche = Nothing
    End Sub

    'Konstruktor mit Parametern
    Sub New(pintInfluencerID As Integer, pstrVorname As String, pstrName As String, pbrBranche As Branche)
        mintInfluencerID = pintInfluencerID
        mstrVorname = pstrVorname
        mstrName = pstrName
        mbrBranche = pbrBranche
    End Sub

End Class
