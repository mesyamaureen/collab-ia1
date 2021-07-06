﻿Imports System.Web
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

        End Set
    End Property

    <Display(Name:="Branche")>
    Public Property BrancheTitel As String
        Get
            Return mstrBrancheTitel
        End Get
        Set(value As String)

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
End Class
