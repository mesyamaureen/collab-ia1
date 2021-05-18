Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Unternehmer
    Inherits Benutzer

    Private mintUntID As Integer
    Private mstrFirmenname As String
    Private mjAnzeige As Jobanzeige
    Private mbrBranche As Branche

    'Properties
    Public Property UnternehmensID As Integer
        Get
            Return mintUntID
        End Get
        Set(value As Integer)

        End Set
    End Property

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
        mintUntID = Nothing
        mstrFirmenname = String.Empty
        mbrBranche = Nothing
    End Sub

    'Konstruktor mit Parametern
    Sub New(pintUntID As Integer, pstrFirmenname As String, pbrBranche As Branche)
        mintUntID = pintUntID
        mstrFirmenname = pstrFirmenname
        mbrBranche = pbrBranche
    End Sub
End Class
