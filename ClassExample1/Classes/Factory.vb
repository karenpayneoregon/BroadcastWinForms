''' <summary>
''' Manager for listeners
''' </summary>
Public NotInheritable Class Factory

    Private Sub New()
    End Sub

    Private Shared _broadcaster As Broadcaster

    Public Shared Function Broadcaster() As Broadcaster

        If _broadcaster IsNot Nothing Then
            Return _broadcaster
        Else
            _broadcaster = New Broadcaster()
            Return _broadcaster
        End If

    End Function

End Class
