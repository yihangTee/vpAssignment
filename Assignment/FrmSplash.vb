Public Class FrmSplash
    Private Sub FrmSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        Label1.Text = "Loading " & ProgressBar1.Value.ToString() & " %"
        If ProgressBar1.Value >= 100 Then
            Timer1.Stop()
            Me.Hide()
            FrmTable.Show()
        End If
    End Sub
End Class
