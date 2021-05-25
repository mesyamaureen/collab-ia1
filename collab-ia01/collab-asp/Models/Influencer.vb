Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Influencer
    Inherits Benutzer

    Private mstrVorname As String
    Private mstrName As String
    Private mbrBranche As Branche
    Private mjAnzeige As Jobanzeige

    'Properties
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
        mstrVorname = String.Empty
        mstrName = String.Empty
        mbrBranche = Nothing
    End Sub

    'Konstruktor mit Parametern
    Sub New(pstrVorname As String, pstrName As String, pbrBranche As Branche)
        mstrVorname = pstrVorname
        mstrName = pstrName
        mbrBranche = pbrBranche
    End Sub

    'Subs and Functions
    Public Function influencerLaden(pintBenutzerID As Integer) As Influencer

    End Function

    Public Function alleInfluencerLaden() As List(Of Influencer)

    End Function
End Class
