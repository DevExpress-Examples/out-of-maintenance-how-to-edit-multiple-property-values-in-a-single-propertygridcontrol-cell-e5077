Imports System

Namespace DXSample
    Public Class CategoryAttributesViewModel
        Private privatePerson As Person
        Public Overridable Property Person() As Person
            Get
                Return privatePerson
            End Get
            Protected Set(ByVal value As Person)
                privatePerson = value
            End Set
        End Property
        Public Sub New()
            Person = New Person With {.FirstName = "Anita", .LastName = "Benson", .Address = New Address With {.AddressLine1 = "9602 South Main", .AddressLine2 = "Seattle, 77025, USA"}, .Phone = "7138638137"}
        End Sub
    End Class
    Public Class Person
        Public Property FirstName() As String
        Public Property LastName() As String
        Public Property Address() As Address
        Public Property Phone() As String
    End Class
    Public Class Address
        Public Property AddressLine1() As String
        Public Property AddressLine2() As String
    End Class
End Namespace