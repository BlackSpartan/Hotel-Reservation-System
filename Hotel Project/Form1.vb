Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Timer1.Enabled = True
    End Sub

    Private Sub extbtn_Click(sender As Object, e As EventArgs) Handles extbtn.Click
        Me.Close()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Value = ProgressBar1.Value + 5
        lbload.Text = "loading " & ProgressBar1.Value & " % " & " Completed "

        If ProgressBar1.Value >= 100 Then
            Timer1.Enabled = False
            Dim fomu2 As Form2 = New Form2()
            fomu2.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
