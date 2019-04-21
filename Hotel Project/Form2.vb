Public Class Form2

    Private Sub RoomSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomSetupToolStripMenuItem.Click
        Dim fomu3 As Form3 = New Form3()
        fomu3.ShowDialog()
    End Sub

    Private Sub HallSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HallSetupToolStripMenuItem.Click
        Dim fomu4 As Form4 = New Form4()
        fomu4.ShowDialog()
    End Sub

    Private Sub MenuSetupToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuSetupToolStripMenuItem.Click
        Dim fomu5 As Form5 = New Form5()
        fomu5.ShowDialog()
    End Sub

    Private Sub CustomerRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerRegistrationToolStripMenuItem.Click
        Dim fomu6 As Form6 = New Form6()
        fomu6.ShowDialog()
    End Sub

    Private Sub CustomerPaymentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerPaymentToolStripMenuItem.Click
        Dim fomu7 As Form7 = New Form7()
        fomu7.ShowDialog()

    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim fomu1 As Form1 = New Form1()
        fomu1.Show()
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CustomerDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomerDetailsToolStripMenuItem.Click
        Dim fomu8 As Form8 = New Form8()
        fomu8.ShowDialog()
    End Sub

    Private Sub ReservationDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationDetailsToolStripMenuItem.Click
        Dim fomu9 As Form9 = New Form9()
        fomu9.ShowDialog()
    End Sub

    Private Sub CancelModifyReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelModifyReservationToolStripMenuItem.Click
       
    End Sub

    Private Sub CancelReservatioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CancelReservatioToolStripMenuItem.Click
        Dim fomu11 As Form11 = New Form11()
        fomu11.ShowDialog()
    End Sub

    Private Sub ModifyReservationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyReservationToolStripMenuItem.Click
        Dim fomu10 As Form10 = New Form10()
        fomu10.ShowDialog()
    End Sub

    Private Sub ReservationFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservationFormToolStripMenuItem.Click
        Dim fomu12 As Form12 = New Form12()
        fomu12.ShowDialog()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class