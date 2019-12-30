Imports System.Collections.ObjectModel

Public Class Broadcaster
    Private ReadOnly _listeners As New Collection(Of IMessageListener)()

    Public Sub Broadcast(person As Person, sender As Form)
        For Each listener As IMessageListener In _listeners
            listener.OnListen(person, sender)
        Next
    End Sub

    ''' <summary>
    ''' Add a Listener to the Collection of Listeners
    ''' </summary>
    ''' <param name="Listener"></param>
    Public Sub AddListener(Listener As IMessageListener)
        _listeners.Add(Listener)
    End Sub
    ''' <summary>
    ''' Remove a Listener from the collection
    ''' </summary>
    ''' <param name="Listener"></param>
    Public Sub RemoveListener(Listener As IMessageListener)

        Dim index As Integer = 0

        Do While index < _listeners.Count

            If _listeners(index).Equals(Listener) Then
                _listeners.Remove(_listeners(index))
            End If

            index += 1

        Loop
    End Sub
End Class
