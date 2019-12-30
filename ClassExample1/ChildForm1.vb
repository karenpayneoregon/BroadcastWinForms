Imports System.ComponentModel
Imports ClassExample1

Public Class ChildForm1
    Implements IMessageListener
    ''' <summary>
    ''' Listen for messages
    ''' </summary>
    Public Sub New()

        InitializeComponent()

        Factory.Broadcaster().AddListener(Me)

    End Sub
    ''' <summary>
    ''' React to calls from Form1 only, if there was not a 
    ''' check this event would pick up events from itself.
    ''' </summary>
    ''' <param name="person"></param>
    ''' <param name="form"></param>
    Public Sub OnListen(person As Person, form As Form) Implements IMessageListener.OnListen
        If TypeOf form Is Form1 Then
            FirstNameTextBox.Text = person.FirstName
            LastNameTextBox.Text = person.LastName
            Dim position = GenderComboBox.FindString(person.Gender)

            If position > -1 Then
                GenderComboBox.SelectedIndex = position
            End If

        Else
            '
            ' In this code sample this would be triggered when pressing the 
            ' SendToCallingFormButton button
            '
        End If
    End Sub
    ''' <summary>
    ''' Stop listening, remove this form from the Collection in Broadcaster class
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChildForm1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Factory.Broadcaster().RemoveListener(Me)
    End Sub
    ''' <summary>
    ''' Send out the current person to all listeners which in this demo is this form and the
    ''' main form, Form1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SendToCallingFormButton_Click(sender As Object, e As EventArgs) Handles SendToCallingFormButton.Click

        If Not String.IsNullOrWhiteSpace(FirstNameTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then

            Factory.Broadcaster().Broadcast(New Person() With {
                                               .FirstName = FirstNameTextBox.Text,
                                               .LastName = LastNameTextBox.Text,
                                               .Gender = GenderComboBox.Text,
                                               .Id = -1
                                               }, Me)
        Else
            MessageBox.Show("First and last name required")
        End If

    End Sub
    ''' <summary>
    ''' Move the form down so we can see form1
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChildForm1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        Top = Top + 200

    End Sub
End Class