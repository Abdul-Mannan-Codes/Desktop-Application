Public Class home
    Dim imgno As Integer = 0
    Private Sub home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Welcome " + signin.TextBox4.Text + ","
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If imgno = 0 Then
            PictureBox1.Image = My.Resources.graph__1_
            imgno = 1
            Label2.Text = "Staff Stats"
        ElseIf imgno = 1 Then
            PictureBox1.Image = My.Resources.graph
            imgno = 0
            Label2.Text = "Students Stats"
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If imgno = 0 Then
            PictureBox1.Image = My.Resources.graph__1_
            imgno = 1
        ElseIf imgno = 1 Then
            PictureBox1.Image = My.Resources.graph
            imgno = 0
        End If

    End Sub
End Class