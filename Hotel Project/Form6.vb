Public Class Form6

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_Hotel_projectDataSet.Customer_Registration' table. You can move, or remove it, as needed.
        Me.Customer_RegistrationTableAdapter.Fill(Me.My_Hotel_projectDataSet.Customer_Registration)
        cmbgender.Items.Add("Male")
        cmbgender.Items.Add("Female")
        CancelButton = closebtn
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgender.SelectedIndexChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub btaddnew_Click(sender As Object, e As EventArgs) Handles btaddnew.Click
        CustomerRegistrationBindingSource.AddNew()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        CustomerRegistrationBindingSource.EndEdit()
        Customer_RegistrationTableAdapter.Update(My_Hotel_projectDataSet)
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        CustomerRegistrationBindingSource.RemoveCurrent()
    End Sub
End Class