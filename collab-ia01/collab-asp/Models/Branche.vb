Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.ComponentModel.DataAnnotations

Public Class Branche
    Private mintBrancheID As Integer
    Private mstrBrancheTitel As String

    'Properties
    Public Property BrancheID As Integer
        Get
            Return mintBrancheID
        End Get
        Set(value As Integer)
            mintBrancheID = value
        End Set
    End Property

    <Display(Name:="Branche")>
    Public Property BrancheTitel As String
        Get
            Return mstrBrancheTitel
        End Get
        Set(value As String)
            mstrBrancheTitel = value
        End Set
    End Property

    'Parameterloser Konstruktor
    Sub New()
        mintBrancheID = Nothing
        mstrBrancheTitel = String.Empty
    End Sub

    'Konstruktor mit Parametern
    Sub New(pintBrancheID As Integer, pstrBrancheTitel As String)
        mintBrancheID = pintBrancheID
        mstrBrancheTitel = pstrBrancheTitel
    End Sub

    Sub New(pbrEntity As BrancheEntity)
        mintBrancheID = pbrEntity.BrIdPk
        mstrBrancheTitel = pbrEntity.BrTitel
    End Sub

    Public Function gibAlsBrancheEntity() As BrancheEntity
        Dim brEntity As BrancheEntity
        brEntity = New BrancheEntity

        brEntity.BrIdPk = mintBrancheID
        brEntity.BrTitel = mstrBrancheTitel

        Return brEntity
    End Function
End Class
