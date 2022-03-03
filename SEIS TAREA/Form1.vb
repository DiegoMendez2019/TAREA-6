Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 + num2

        Label1.Text = res
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 - num2

        Label1.Text = res
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 * num2

        Label1.Text = res
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim num1, num2, res As Double

        num1 = TextBox1.Text
        num2 = TextBox2.Text

        res = num1 / num2

        Label1.Text = res
    End Sub
End Class
