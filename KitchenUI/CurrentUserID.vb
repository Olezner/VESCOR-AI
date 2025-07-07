Module Module1
    ' Define a global variable to store the current USERID
    Private _currentUserID As Integer = -1

    ' Method to set the current USERID after a successful login
    Public Sub SetCurrentUserID(userID As Integer)
        _currentUserID = userID
    End Sub

    Friend Function CurrentUser() As Integer
        Throw New NotImplementedException()
    End Function

    ''' <summary>
    ''' Property to get the current USERID
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property CurrentUserID As Integer
        Get
            Return _currentUserID
        End Get
    End Property
End Module

