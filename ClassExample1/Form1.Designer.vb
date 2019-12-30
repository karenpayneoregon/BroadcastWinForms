<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChildFormOpenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChildFormOpenToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(294, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(84, 84)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.LastNameTextBox.TabIndex = 7
        Me.LastNameTextBox.Text = "Adams"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(84, 55)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(134, 20)
        Me.FirstNameTextBox.TabIndex = 6
        Me.FirstNameTextBox.Text = "Mary"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Last name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "First name"
        '
        'ChildFormOpenToolStripButton
        '
        Me.ChildFormOpenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ChildFormOpenToolStripButton.Image = CType(resources.GetObject("ChildFormOpenToolStripButton.Image"), System.Drawing.Image)
        Me.ChildFormOpenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ChildFormOpenToolStripButton.Name = "ChildFormOpenToolStripButton"
        Me.ChildFormOpenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ChildFormOpenToolStripButton.Text = "Open child form modally"
        '
        'GenderComboBox
        '
        Me.GenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"Female", "Male"})
        Me.GenderComboBox.Location = New System.Drawing.Point(84, 110)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(134, 21)
        Me.GenderComboBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(36, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Gender"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 167)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.LastNameTextBox)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Basic class example"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ChildFormOpenToolStripButton As ToolStripButton
    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents Label3 As Label
End Class
