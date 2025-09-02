Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim strFirstName = InputBox("Please Enter your first name")

        MessageBox.Show("Welcome to vb.net " & strFirstName)

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        Dim strFirstName As String = "John"
        strFirstName = "Jane"


        MsgBox("Hello and welcome " & strFirstName & " I hope you are well")
    End Sub

    Private Sub btrDataTypes_Click(sender As Object, e As EventArgs) Handles btrDataTypes.Click
        Dim strMake As String = "Toyota"
        Dim strModel As String = "Corolla"
        Dim intDoors As Integer = 4
        Dim strColour As String = "Blue"
        Dim boolTaxed As Boolean = True
        Dim intEngineSize As Integer = 1600
        Dim decPrice As Decimal = 999.9
        Dim dateRegistered As Date = #12/25/2020#


        MsgBox("The car is a " & strColour & Environment.NewLine & strMake & Environment.NewLine & strModel & " with " & intDoors & " doors. It has an engine size of " & intEngineSize & "cc \n and costs £" & decPrice & ". It was registered on " & dateRegistered & ". Taxed: " & boolTaxed)
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim intAge As Integer
        Dim strOccupation As String

        strFirstName = firstNameTextBox.Text
        strLastName = lastNameTextBox.Text
        intAge = CInt(ageTextBox.Text)
        strOccupation = occupationListBox.SelectedItem


        MsgBox("Hello " & strFirstName & " " & strLastName & ". You are " & intAge & " years old. " & strOccupation
               )
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        occupationListBox.Items.Add("Writer")
        occupationListBox.Items.Add("Actor")
    End Sub

    Private Sub twoNumberButton_Click(sender As Object, e As EventArgs) Handles twoNumberButton.Click
        Dim intFirstNumber As Integer
        Dim intSecondNumber As Integer
        Dim intTotal As Integer

        If IsNumeric(numberTextBox1.Text) And IsNumeric(numberTextBox2.Text) Then
            intFirstNumber = CInt(numberTextBox1.Text)
            intSecondNumber = CInt(numberTextBox2.Text)
            intTotal = intFirstNumber + intSecondNumber
            MsgBox("The total is " & intTotal)
        ElseIf Not IsNumeric(numberTextBox1.Text) And IsNumeric(numberTextBox2.Text) Then
            MsgBox("Please enter a valid number in the first text box.")
        Else
            MsgBox("Please enter valid numbers in both text boxes.")
        End If

        Select Case intTotal
            Case Is < 0
                MsgBox("The total is negative.")
            Case 5
                MsgBox("The total is 5.")
            Case 6 To 10
                MsgBox("The total is not 0.")
            Case Else
                MsgBox("The total is something else.")
        End Select

        'For i = 1 To 5
        '    Beep()
        '    Threading.Thread.Sleep(3000) ' Pause for 3 seconds
        'Next

        For i = 0 To 5
            MsgBox("This is loop number " & i)
        Next

        Dim output As String = ""

        For i = 0 To 10
            output = output & i & Environment.NewLine
        Next
        MsgBox(output)

    End Sub
End Class
