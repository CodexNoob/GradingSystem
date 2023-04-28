Public Class Form1
    Dim asign As Double
    Dim quiz As Double
    Dim recite As Double
    Dim act As Double
    Dim att As Double
    Dim exam As Double


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        asign = (Val(TextBox1.Text) + Val(TextBox2.Text) + Val(TextBox3.Text) * 0.1 / 3)
        quiz = (Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text) * 0.2 / 3)
        recite = (Val(TextBox7.Text) * 0.15)
        act = (Val(TextBox8.Text) + Val(TextBox9.Text) + Val(TextBox10.Text) * 0.1 / 3)
        att = (Val(TextBox11.Text) * 0.05)
        exam = (Val(TextBox12.Text) * 0.4)

        TextBox13.Text = (asign + quiz + recite + act + att + exam) / 6
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
