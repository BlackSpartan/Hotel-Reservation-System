Public Class Form5

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_Hotel_projectDataSet.Menu_Details' table. You can move, or remove it, as needed.
        Me.Menu_DetailsTableAdapter.Fill(Me.My_Hotel_projectDataSet.Menu_Details)
        If rbhall.Checked = True Then
            cmbfor.Enabled = False
        Else
            cmbfor.Enabled = True
        End If

        cmbfor.Items.Add("Wedding")
        cmbfor.Items.Add("Conference")
        CancelButton = backbtn
    End Sub

    Private Sub btnaddnew_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        MenuDetailsBindingSource.AddNew()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        MenuDetailsBindingSource.EndEdit()
        Menu_DetailsTableAdapter.Update(My_Hotel_projectDataSet)

    End Sub
End Class