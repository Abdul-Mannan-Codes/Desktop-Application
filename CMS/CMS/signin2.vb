Public Class signin2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        signin.Show()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        signin3.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RichTextBox1_Click(sender As Object, e As EventArgs) Handles RichTextBox1.Click
        Dim address As String
        address = TextBox1.Text + ", Near " + TextBox2.Text + ", " + TextBox3.Text + ", " + TextBox5.Text + " - " + TextBox4.Text
        RichTextBox1.Text = address
    End Sub
End Class