<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.SendToCallingFormButton = New System.Windows.Forms.Button()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Last name"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(87, 15)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.FirstNameTextBox.TabIndex = 2
        Me.FirstNameTextBox.Text = "Karen"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(87, 44)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.LastNameTextBox.TabIndex = 3
        Me.LastNameTextBox.Text = "Payne"
        '
        'SendToCallingFormButton
        '
        Me.SendToCallingFormButton.Location = New System.Drawing.Point(29, 109)
        Me.SendToCallingFormButton.Name = "SendToCallingFormButton"
        Me.SendToCallingFormButton.Size = New System.Drawing.Size(192, 23)
        Me.SendToCallingFormButton.TabIndex = 4
        Me.SendToCallingFormButton.Text = "Send to caller"
        Me.SendToCallingFormButton.UseVisualStyleBackColor = True
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Female", "Male"})
        Me.GenderComboBox.Location = New System.Drawing.Point(87, 73)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(134, 21)
        Me.GenderComboBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Gender"
        '
        'ChildForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(255, 144)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.SendToCallingFormButton)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ChildForm1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Child Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents SendToCallingFormButton As Button
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
