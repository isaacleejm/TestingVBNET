<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGo = New Button()
        btnVariables = New Button()
        btrDataTypes = New Button()
        btnSubmit = New Button()
        firstNameTextBox = New TextBox()
        firstNameLabel = New Label()
        lastNameLabel = New Label()
        lastNameTextBox = New TextBox()
        ageTextBox = New TextBox()
        ageLabel = New Label()
        occupationListBox = New ListBox()
        numberTextBox2 = New TextBox()
        numberTextBox1 = New TextBox()
        twoNumberButton = New Button()
        SuspendLayout()
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(152, 103)
        btnGo.Margin = New Padding(4, 5, 4, 5)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(254, 152)
        btnGo.TabIndex = 0
        btnGo.Text = "TextInput Button"
        btnGo.UseVisualStyleBackColor = True
        ' 
        ' btnVariables
        ' 
        btnVariables.Location = New Point(447, 103)
        btnVariables.Name = "btnVariables"
        btnVariables.Size = New Size(253, 152)
        btnVariables.TabIndex = 1
        btnVariables.Text = "Button1"
        btnVariables.UseVisualStyleBackColor = True
        ' 
        ' btrDataTypes
        ' 
        btrDataTypes.Location = New Point(152, 319)
        btrDataTypes.Name = "btrDataTypes"
        btrDataTypes.Size = New Size(254, 152)
        btrDataTypes.TabIndex = 2
        btrDataTypes.Text = "Data Type"
        btrDataTypes.UseVisualStyleBackColor = True
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(485, 548)
        btnSubmit.Margin = New Padding(4, 5, 4, 5)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(254, 152)
        btnSubmit.TabIndex = 3
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' firstNameTextBox
        ' 
        firstNameTextBox.Location = New Point(589, 412)
        firstNameTextBox.Name = "firstNameTextBox"
        firstNameTextBox.Size = New Size(150, 31)
        firstNameTextBox.TabIndex = 4
        ' 
        ' firstNameLabel
        ' 
        firstNameLabel.AutoSize = True
        firstNameLabel.Location = New Point(486, 415)
        firstNameLabel.Name = "firstNameLabel"
        firstNameLabel.Size = New Size(97, 25)
        firstNameLabel.TabIndex = 5
        firstNameLabel.Text = "First Name"
        ' 
        ' lastNameLabel
        ' 
        lastNameLabel.AutoSize = True
        lastNameLabel.Location = New Point(488, 462)
        lastNameLabel.Name = "lastNameLabel"
        lastNameLabel.Size = New Size(95, 25)
        lastNameLabel.TabIndex = 6
        lastNameLabel.Text = "Last Name"
        ' 
        ' lastNameTextBox
        ' 
        lastNameTextBox.Location = New Point(589, 462)
        lastNameTextBox.Name = "lastNameTextBox"
        lastNameTextBox.Size = New Size(150, 31)
        lastNameTextBox.TabIndex = 7
        ' 
        ' ageTextBox
        ' 
        ageTextBox.Location = New Point(589, 509)
        ageTextBox.Name = "ageTextBox"
        ageTextBox.Size = New Size(150, 31)
        ageTextBox.TabIndex = 9
        ' 
        ' ageLabel
        ' 
        ageLabel.AutoSize = True
        ageLabel.Location = New Point(488, 509)
        ageLabel.Name = "ageLabel"
        ageLabel.Size = New Size(44, 25)
        ageLabel.TabIndex = 8
        ageLabel.Text = "Age"
        ' 
        ' occupationListBox
        ' 
        occupationListBox.FormattingEnabled = True
        occupationListBox.ItemHeight = 25
        occupationListBox.Items.AddRange(New Object() {"Doctor", "Student", "Nurse", "Teacher", "Cleaner", "Programmer"})
        occupationListBox.Location = New Point(888, 107)
        occupationListBox.Name = "occupationListBox"
        occupationListBox.Size = New Size(180, 179)
        occupationListBox.TabIndex = 10
        ' 
        ' numberTextBox2
        ' 
        numberTextBox2.Location = New Point(918, 440)
        numberTextBox2.Name = "numberTextBox2"
        numberTextBox2.Size = New Size(150, 31)
        numberTextBox2.TabIndex = 12
        ' 
        ' numberTextBox1
        ' 
        numberTextBox1.Location = New Point(918, 390)
        numberTextBox1.Name = "numberTextBox1"
        numberTextBox1.Size = New Size(150, 31)
        numberTextBox1.TabIndex = 11
        ' 
        ' twoNumberButton
        ' 
        twoNumberButton.Location = New Point(908, 482)
        twoNumberButton.Margin = New Padding(4, 5, 4, 5)
        twoNumberButton.Name = "twoNumberButton"
        twoNumberButton.Size = New Size(176, 85)
        twoNumberButton.TabIndex = 13
        twoNumberButton.Text = "Submit"
        twoNumberButton.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1143, 750)
        Controls.Add(twoNumberButton)
        Controls.Add(numberTextBox2)
        Controls.Add(numberTextBox1)
        Controls.Add(occupationListBox)
        Controls.Add(ageTextBox)
        Controls.Add(ageLabel)
        Controls.Add(lastNameTextBox)
        Controls.Add(lastNameLabel)
        Controls.Add(firstNameLabel)
        Controls.Add(firstNameTextBox)
        Controls.Add(btnSubmit)
        Controls.Add(btrDataTypes)
        Controls.Add(btnVariables)
        Controls.Add(btnGo)
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGo As Button
    Friend WithEvents btnVariables As Button
    Friend WithEvents btrDataTypes As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents firstNameLabel As Label
    Friend WithEvents lastNameLabel As Label
    Friend WithEvents lastNameTextBox As TextBox
    Friend WithEvents ageTextBox As TextBox
    Friend WithEvents ageLabel As Label
    Friend WithEvents occupationListBox As ListBox
    Friend WithEvents numberTextBox2 As TextBox
    Friend WithEvents numberTextBox1 As TextBox
    Friend WithEvents twoNumberButton As Button

End Class
