Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Unternehmen
    Inherits Benutzer

    Private mstrFirmenname As String
    Private mjAnzeige As Jobanzeige
    Private mbrBranche As Branche

    'Properties

    Public Property Firmenname As String
        Get
            Return mstrFirmenname
        End Get
        Set(value As String)

        End Set
    End Property

    Public Property Jobanzeige As Jobanzeige
        Get
            Return mjAnzeige
        End Get
        Set(value As Jobanzeige)

        End Set
    End Property

    Public Property Branche As Branche
        Get
            Return mbrBranche
        End Get
        Set(value As Branche)

        End Set
    End Property

    'Parameterloser Konstruktor
    Sub New()
        mstrFirmenname = String.Empty
        mbrBranche = Nothing
    End Sub

    'Konstruktor mit Parametern
    Sub New(pstrFirmenname As String, pbrBranche As Branche)
        mstrFirmenname = pstrFirmenname
        mbrBranche = pbrBranche
    End Sub

    Public Function unternehmenLaden(pintBenutzerID As Integer) As Unternehmen

    End Function

    Public Function alleUnternehmenLaden() As List(Of Unternehmen)

    End Function
End Class
