Public Class Form

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Black
    End Sub

    Private Sub Ganti_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ganti.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Gold

        Else
            Me.BackColor = Color.Blue
        End If
    End Sub
End Class
