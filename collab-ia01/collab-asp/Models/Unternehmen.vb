Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Unternehmen
    Inherits Benutzer

    Private mstrFirmenname As String
    Private mjAnzeige As Jobanzeige
    Private mbrBranche As Branche
    Private muntID As Integer

    'Properties

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

    Public Property Jobanzeige As Jobanzeige
        Get
            Return mjAnzeige
        End Get
        Set(value As Jobanzeige)
            mjAnzeige = value
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
    End Sub

    'Konstruktor mit Parametern
    Sub New(puntID As Integer, pstrFirmenname As String, pbrBranche As Branche)
        muntID = puntID
        mstrFirmenname = pstrFirmenname
        mbrBranche = pbrBranche
    End Sub

    Sub New(puntEntity As UnternehmerEntity)
        mstrFirmenname = puntEntity.UName
        muntID = puntEntity.UIdPk
        'mbrBranche = puntEntity.UBrIdFk
    End Sub
End Class
