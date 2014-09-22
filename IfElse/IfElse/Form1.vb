Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text
        Dim result As String

        If IsNumeric(st1) = False And IsNumeric(st2) = False Then
            MessageBox.Show("Please enter valid numbers.", "Error")
            Exit Sub
        ElseIf IsNumeric(st1) = False Then
            MessageBox.Show("Please enter a valid first number.", "Error")
            Exit Sub
        ElseIf IsNumeric(st2) = False Then
            MessageBox.Show("Please enter a valid second number.", "Error")
            Exit Sub
        End If

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        If num1 < 0 Or num2 < 0 Then
            MessageBox.Show("Please enter positive numbers.", "Error")
            Exit Sub
        End If

        If num1 > num2 Then
            result = "The larger number is " & num1 & "."
        ElseIf num2 > num1 Then
            result = "The larger number is " & num2 & "."
        Else
            result = "They are equal."
        End If

        txtResult.Text = result

    End Sub


End Class
