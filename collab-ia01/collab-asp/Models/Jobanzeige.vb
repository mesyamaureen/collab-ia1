Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel

'ACHTUNG: JOBANZEIGE EINES BENUTZERS
Public Class Jobanzeige
    Private mintJobID As Integer
    Private mstrTitel As String
    Private mstrBeschreibung As String
    Private mbrBranche As Branche
    Private mlstJobanzeigeAlle As List(Of Jobanzeige)

    Private mstrVersion As String ' Neues Attribut vom Typ String  um UNICODE zu speichern

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

    Public Sub New(pJobanzeigeEntity As JobanzeigeEntity)
        mintJobID = pJobanzeigeEntity.JaIdPk
        mstrTitel = pJobanzeigeEntity.JaTitel
        mstrBeschreibung = pJobanzeigeEntity.JaBeschreibung

        'mbrBranche = New Branche(pJobanzeigeEntity.JaBrIdFk, "")
    End Sub

    'Properties
    Public Property JobID As Integer
        Get
            Return mintJobID
        End Get
        Set(value As Integer)
            mintJobID = value
        End Set
    End Property

    Public Property Titel As String
        Get
            Return mstrTitel
        End Get
        Set(value As String)
            mstrTitel = value
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

    Public Property Branche As Branche
        Get
            Return mbrBranche
        End Get
        Set(value As Branche)

        End Set
    End Property
    Public Property Version As String
        Get
            Return mstrVersion
        End Get
        Set(value As String)
            mstrVersion = value
        End Set
    End Property

    Public Property ListeJobanzeige As List(Of Jobanzeige)
        Get
            Return mlstJobanzeigeAlle
        End Get
        Set(value As List(Of Jobanzeige))
            mlstJobanzeigeAlle = value
        End Set
    End Property


    'Subs and Functions
    Public Function alleJobanzeigenLaden(pintJobID As Integer) As List(Of Jobanzeige)

    End Function

    Public Sub jobanzeigeLoeschen(pJobanzeige As Jobanzeige)

    End Sub

    Public Sub jobanzeigeAnlegen(pstrTitel As String, pstrBeschreibung As String, pbrBranche As Branche)

    End Sub

    Public Sub jobAnzeigeAktualisieren()

    End Sub

    Public Function gibAlsJobanzeigeEntity() As JobanzeigeEntity
        Dim jobE As JobanzeigeEntity
        jobE = New JobanzeigeEntity

        jobE.JaIdPk = mintJobID
        jobE.JaTitel = mstrTitel
        jobE.JaBeschreibung = mstrBeschreibung

        If mbrBranche IsNot Nothing Then
            jobE.JaBrIdFk = mbrBranche.BrancheID
        End If

        'JOB VERSION FEHLT

        Return jobE
    End Function

End Class
