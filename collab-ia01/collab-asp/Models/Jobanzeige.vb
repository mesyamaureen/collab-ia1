Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

Public Class Jobanzeige
    Private mintJobID As Integer
    Private mstrTitel As String
    Private mstrBeschreibung As String
    Private mbrBranche As Branche

    'Properties
    Public Property JobID As Integer
        Get
            Return mintJobID
        End Get
        Set(value As Integer)

        End Set
    End Property

    Public Property Titel As String
        Get
            Return mstrTitel
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

    Public Property Branche As Branche
        Get
            Return mbrBranche
        End Get
        Set(value As Branche)

        End Set
    End Property

    'Parameterloser Konstruktor
    Sub New()
        mintJobID = Nothing
        mstrTitel = String.Empty
        mstrBeschreibung = String.Empty
        mbrBranche = Nothing
    End Sub

    'Konstruktor mit Parameter
    Sub New(pintJobID As Integer, pstrTitel As String, pstrBeschreibung As String, pbrBranche As Branche)
        mintJobID = pintJobID
        mstrTitel = pstrTitel
        mstrBeschreibung = pstrBeschreibung
        mbrBranche = pbrBranche
    End Sub

    'Subs and Functions
    Public Function alleJobanzeigenLaden(pintJobID As Integer) As List(Of Jobanzeige)

    End Function

    Public Sub jobanzeigeLoeschen(pJobanzeige As Jobanzeige)

    End Sub

    Public Sub jobanzeigeAnlegen(pstrTitel As String, pstrBeschreibung As String, pbrBranche As Branche)

    End Sub

    Public Sub jobAnzeigeAktualisieren()

    End Sub
End Class
