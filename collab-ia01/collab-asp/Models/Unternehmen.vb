Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Unternehmen
    Inherits Benutzer

    Private mstrFirmenname As String
    Private mjAnzeigen As List(Of Jobanzeige)
    Private mbrBranche As Branche
    Private muntID As Integer
    Private mbrID As Integer
    Private mstrBenutzername As String
    Private mstrPasswort As String
    Private mstrBeschreibung As String
    Private mstrEmail As String

    'Properties
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

    Public Property BrancheID As Integer
        Get
            Return mbrID
        End Get
        Set(value As Integer)
            mbrID = value
        End Set
    End Property


    Public Property UnternehmerID As Integer
        Get
            Return muntID
        End Get
        Set(value As Integer)
            muntID = value
        End Set
    End Property

    Public Property Firmenname As String
        Get
            Return mstrFirmenname
        End Get
        Set(value As String)
            mstrFirmenname = value
        End Set
    End Property

    Public Property Jobanzeigen As List(Of Jobanzeige)
        Get
            Return mjAnzeigen
        End Get
        Set(value As List(Of Jobanzeige))
            mjAnzeigen = value
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

    'Parameterloser Konstruktor
    Sub New()
        muntID = Nothing
        mstrFirmenname = String.Empty
        mbrBranche = Nothing
        mbrID = Nothing
        mstrBenutzername = String.Empty
        mstrPasswort = String.Empty
        mstrBeschreibung = String.Empty
        mstrEmail = String.Empty
    End Sub

    'Konstruktor mit Parametern
    Sub New(puntID As Integer, pstrFirmenname As String, pbrBranche As Branche, pbrID As Integer, pstrBenutzername As String, pstrPasswort As String, pstrBeschreibung As String, pstrEmail As String)
        muntID = puntID
        mstrFirmenname = pstrFirmenname
        mbrBranche = pbrBranche
        mbrID = pbrID
        mstrBenutzername = pstrBenutzername
        mstrPasswort = pstrPasswort
        mstrBeschreibung = pstrBeschreibung
        mstrEmail = pstrEmail
    End Sub

    Sub New(puntEntity As UnternehmerEntity)
        mstrFirmenname = puntEntity.UName
        muntID = puntEntity.UIdPk
        mbrID = puntEntity.UBrIdFk
        mstrBenutzername = puntEntity.UBenutzername
        mstrPasswort = puntEntity.UPasswort
        mstrEmail = puntEntity.UEMail
        mstrBeschreibung = puntEntity.UBeschreibung
    End Sub

    Public Function gibAlsUnternehmenEntity() As UnternehmerEntity
        Dim untE As UnternehmerEntity
        untE = New UnternehmerEntity

        untE.UBenutzername = mstrBenutzername
        untE.UEMail = mstrEmail
        untE.UIdPk = muntID
        untE.UName = mstrFirmenname
        untE.UPasswort = mstrPasswort
        untE.UBeschreibung = mstrBeschreibung

        If mbrBranche IsNot Nothing Then
            untE.UBrIdFk = mbrBranche.BrancheID
        End If

        Return untE
    End Function
End Class
