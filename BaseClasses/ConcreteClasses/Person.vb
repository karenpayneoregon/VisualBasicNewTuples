Public Class Person
    Implements IBase
    Public Property Identifier As Integer
    Public Property FirstName As String
    Public Property LastName As String
    Public Property Email As String
    Public Property Account As Account
    Public ReadOnly Property IsBussinessAccount As Boolean
        Get
            Return TypeOf Account Is BusinessAccount
        End Get
    End Property
    Public ReadOnly Property Id As Integer Implements IBase.Id
        Get
            Return Identifier
        End Get
    End Property
End Class
