Public Class Account
    Implements IBase
    Public Property AccountIdentifier As Integer
    Public ReadOnly Property Id As Integer Implements IBase.Id
        Get
            Return AccountIdentifier
        End Get
    End Property
End Class
