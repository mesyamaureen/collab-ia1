'------------------------------------------------------------------------------
' <auto-generated>
'    Dieser Code wurde aus einer Vorlage generiert.
'
'    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
'    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class InfluencerEntity
    Public Property InIdPk As Integer
    Public Property InVorname As String
    Public Property InName As String
    Public Property InBrIdFk As Nullable(Of Integer)
    Public Property InBenutzername As String
    Public Property InPasswort As String
    Public Property InEMail As String

    Public Overridable Property tblBranchen As BrancheEntity
    Public Overridable Property tblJobanzeigen As ICollection(Of JobanzeigeEntity) = New HashSet(Of JobanzeigeEntity)

End Class
