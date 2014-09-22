Option Strict On

Public Class Form1

    Private Sub btnFindLarger_Click(sender As System.Object, e As System.EventArgs) Handles btnFindLarger.Click
        Dim num1, num2 As Double

        Dim st1 As String = txtFirstNum.Text
        Dim st2 As String = txtSecondNum.Text
        Dim result As String

        If IsNumeric(txtFirstNum.Text) = False And IsNumeric(txtSecondNum.Text) = False Then
            GoTo ErrorMsg3
        ElseIf IsNumeric(txtFirstNum.Text) = False Then
            GoTo ErrorMsg1
        ElseIf IsNumeric(txtSecondNum.Text) = False Then
            GoTo ErrorMsg2
        End If

        num1 = CDbl(st1)
        num2 = CDbl(st2)

        If num1 > num2 Then
            result = "The larger number is " & num1 & "."
        ElseIf num2 > num1 Then
            result = "The larger number is " & num2 & "."
        Else
            result = "They are equal."
        End If

        txtResult.Text = result
        Exit Sub

ErrorMsg1:
        MessageBox.Show("Please enter a valid first number.", "Error")
        Exit Sub

ErrorMsg2:
        MessageBox.Show("Please enter a valid second number.", "Error")
        Exit Sub

ErrorMsg3:
        MessageBox.Show("Please enter valid numbers.", "Error")
        Exit Sub

    End Sub

    Private Sub txtFirstNum_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNum.TextChanged

    End Sub
End Class
