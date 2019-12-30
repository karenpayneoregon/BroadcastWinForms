Public Class Form1
    Implements IMessageListener

    Public Sub OnListen(person As Person, form As Form) Implements IMessageListener.OnListen
        If TypeOf form Is ChildForm1 Then

            FirstNameTextBox.Text = person.FirstName
            LastNameTextBox.Text = person.LastName
            Dim position = GenderComboBox.FindString(person.Gender)

            If position > -1 Then
                GenderComboBox.SelectedIndex = position
            End If

        End If
    End Sub
    ''' <summary>
    ''' Set this form up as a listener
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Factory.Broadcaster().AddListener(Me)
        GenderComboBox.SelectedIndex = 0
    End Sub
    ''' <summary>
    ''' Create new child form, send person object created with controls
    ''' on this form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ChildFormOpenToolStripButton_Click(sender As Object, e As EventArgs) Handles ChildFormOpenToolStripButton.Click

        If Not String.IsNullOrWhiteSpace(FirstNameTextBox.Text) AndAlso Not String.IsNullOrWhiteSpace(LastNameTextBox.Text) Then

            Dim f As New ChildForm1

            Factory.Broadcaster().Broadcast(New Person() With {
                                               .FirstName = FirstNameTextBox.Text,
                                               .LastName = LastNameTextBox.Text,
                                               .Gender = GenderComboBox.Text,
                                               .Id = -1
                                               }, Me)
            Try
                f.ShowDialog()
            Finally
                f.Dispose()
            End Try

        End If
    End Sub
End Class
