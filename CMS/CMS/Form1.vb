Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ProgressBar1.Visible = True
        ProgressBar1.Value = 0
        Timer1.Enabled = True
        Timer1.Interval = 100

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value = 100 Then
            signin.Show()
            Me.Hide()
            Timer1.Enabled = False
            ProgressBar1.Visible = False
        Else
            ProgressBar1.Value = ProgressBar1.Value + 10
        End If
    End Sub

    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
    End Sub
End Class
