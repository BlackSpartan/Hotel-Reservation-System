Public Class Form12

    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_Hotel_projectDataSet.Reservation' table. You can move, or remove it, as needed.
        Me.ReservationTableAdapter.Fill(Me.My_Hotel_projectDataSet.Reservation)
        cmbid.Items.Add("National ID")
        cmbid.Items.Add("Vehicle Lisence")
        cmbid.Items.Add("Passport")
        cmbbussiness.Items.Add("Reservation")
        cmbbussiness.Items.Add("Travel Agent")
        cmbbussiness.Items.Add("Walk In")

        CancelButton = closebtn
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        ReservationBindingSource.AddNew()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ReservationBindingSource.EndEdit()
        ReservationTableAdapter.Update(My_Hotel_projectDataSet)
    End Sub
End Class