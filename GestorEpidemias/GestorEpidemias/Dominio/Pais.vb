﻿Imports System.Windows
Public Class Pais

    Private DAO As DAOPais
    Private codigo, nombre, capital As String
    Private habitantes, superficie As Integer
    Private latlon As Point

    Public Property Codigo1 As String
        Get
            Return codigo
        End Get
        Set(value As String)
            codigo = value
        End Set
    End Property

    Public Property Nombre1 As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    Public Property Capital1 As String
        Get
            Return capital
        End Get
        Set(value As String)
            capital = value
        End Set
    End Property

    Public Property Habitantes1 As Integer
        Get
            Return habitantes
        End Get
        Set(value As Integer)
            habitantes = value
        End Set
    End Property

    Public Property Superficie1 As Integer
        Get
            Return superficie
        End Get
        Set(value As Integer)
            superficie = value
        End Set
    End Property

    Public Property LatLon1 As Point
        Get
            Return latlon
        End Get
        Set(value As Point)
            latlon = value
        End Set
    End Property

    Public Sub New()
        Me.DAO = New DAOPais
    End Sub

    Public Function readAll() As Collection
        DAO.readAll()
        Return DAO.lista
    End Function
End Class
