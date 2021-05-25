Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Benutzer
    Private mintBenutzerID As Integer
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mstrEmail As String
    Private mstrBeschreibung As String

    'Properties
    Public Property BenutzerID As Integer
        Get
            Return mintBenutzerID
        End Get
        Set(value As Integer)

        End Set
    End Property
    Public Property Benutzername As String
        Get
            Return mstrBenutzername
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Passwort As String
        Get
            Return mstrPasswort
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Email As String
        Get
            Return mstrEmail
        End Get
        Set(value As String)

        End Set
    End Property
    Public Property Beschreibung As String
        Get
            Return mstrBeschreibung
        End Get
        Set(value As String)

        End Set
    End Property

    'Parameterloser Konstruktor
    Sub New()
        mintBenutzerID = Nothing
        mstrBenutzername = String.Empty
        mstrPasswort = String.Empty
        mstrEmail = String.Empty
        mstrBeschreibung = String.Empty
    End Sub

    'Konstruktor mit Parameter
    Sub New(pintBenutzerID As Integer, pstrBenutzername As String, pstrPasswort As String, pstrEmail As String, pstrBeschreibung As String)
        mintBenutzerID = pintBenutzerID
        mstrBenutzername = pstrBenutzername
        mstrPasswort = pstrPasswort
        mstrEmail = pstrEmail
        mstrBeschreibung = pstrBeschreibung
    End Sub

    'Subs und Funktionen
    'Public Function alleBenutzerLaden() As List(Of Benutzer)

    'End Function

End Class
