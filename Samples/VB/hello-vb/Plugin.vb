Imports CivOne.Interfaces

Public Class Plugin
    Implements IPlugin

    Public ReadOnly Property Name As String Implements IPlugin.Name
        Get
            Return "Hello VB.NET!"
        End Get
    End Property

    Public ReadOnly Property Author As String Implements IPlugin.Author
        Get
            Return "SWY1985"
        End Get
    End Property

    Public ReadOnly Property Version As String Implements IPlugin.Version
        Get
            Return "0.1.0"
        End Get
    End Property
End Class