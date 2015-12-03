Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Chocolate

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Chocolate Then
            Me.BackColor = Color.Blue
        Else
            Me.BackColor = Color.Chocolate


        End If
    End Sub
End Class
