Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        F = Text1.Text '華氏值
        C = (F - 32) / 9 * 5
        TextBox1.Text = C
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        C = Text2.Text '攝氏值
        F = C * 9 / 5 + 32
        TextBox1.Text = F
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
