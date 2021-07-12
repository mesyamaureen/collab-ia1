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

    'Properties
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
    End Sub

    'Konstruktor mit Parametern
    Sub New(puntID As Integer, pstrFirmenname As String, pbrBranche As Branche, pbrID As Integer)
        muntID = puntID
        mstrFirmenname = pstrFirmenname
        mbrBranche = pbrBranche
        mbrID = pbrID
    End Sub

    Sub New(puntEntity As UnternehmerEntity)
        mstrFirmenname = puntEntity.UName
        muntID = puntEntity.UIdPk
        mbrID = puntEntity.UBrIdFk
        'mbrBranche = puntEntity.UBrIdFk
    End Sub
End Class
