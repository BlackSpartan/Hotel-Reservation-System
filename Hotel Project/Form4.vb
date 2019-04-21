Public Class Form4

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_Hotel_projectDataSet.Hall_Details' table. You can move, or remove it, as needed.
        Me.Hall_DetailsTableAdapter.Fill(Me.My_Hotel_projectDataSet.Hall_Details)
        cmbhalltype.Items.Add("Wedding")
        cmbhalltype.Items.Add("Conference")
        cmbstatus.Items.Add("Reserved")
        cmbstatus.Items.Add("Available")

        CancelButton = cancelbtn
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnaddnew.Click
        HallDetailsBindingSource.AddNew()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        HallDetailsBindingSource.EndEdit()
        Hall_DetailsTableAdapter.Update(My_Hotel_projectDataSet)

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        HallDetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub
End Class