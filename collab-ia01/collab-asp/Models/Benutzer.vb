Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Benutzer
    Private mintBenutzerID As Integer
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mstrEmail As String
    Private mbrBranche As Branche
    Private mstrBeschreibung As String

    'Properties
    Public Property Branche As Branche
        Get
            Return mbrBranche
        End Get
        Set(value As Branche)
            mbrBranche = value
        End Set
    End Property

    Public Property BenutzerID As Integer
        Get
            Return mintBenutzerID
        End Get
        Set(value As Integer)
            mintBenutzerID = value
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

    Public Property Passwort As String
        Get
            Return mstrPasswort
        End Get
        Set(value As String)
            mstrPasswort = value
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
    Public Property Beschreibung As String
        Get
            Return mstrBeschreibung
        End Get
        Set(value As String)
            mstrBeschreibung = value
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

    Sub New(pinfEntity As InfluencerEntity)
        mintBenutzerID = pinfEntity.InIdPk
        mstrBenutzername = pinfEntity.InBenutzername
        mstrPasswort = pinfEntity.InPasswort
        mstrEmail = pinfEntity.InEMail
        mstrBeschreibung = pinfEntity.InBeschreibung
    End Sub

    Sub New(puntEntity As UnternehmerEntity)
        mintBenutzerID = puntEntity.UIdPk
        mstrBenutzername = puntEntity.UBenutzername
        mstrPasswort = puntEntity.UPasswort
        mstrEmail = puntEntity.UEMail
        mstrBeschreibung = puntEntity.UBeschreibung
    End Sub

End Class
