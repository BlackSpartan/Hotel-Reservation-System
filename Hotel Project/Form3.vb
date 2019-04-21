Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_Hotel_projectDataSet.Room_Details' table. You can move, or remove it, as needed.
        Me.Room_DetailsTableAdapter.Fill(Me.My_Hotel_projectDataSet.Room_Details)
        cmblocation.Items.Add("Ground Floor")
        cmblocation.Items.Add("First Floor")
        cmblocation.Items.Add("Second Floor")
        cmblocation.Items.Add("Third Floor")
        cmbroomtype.Items.Add("Single")
        cmbroomtype.Items.Add("Double")
        cmbroomtype.Items.Add("Family")
        cmbstatus.Items.Add("Reserved")
        cmbstatus.Items.Add("Available")
        CancelButton = cancelbtn
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        RoomDetailsBindingSource.AddNew()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs)
        On Error GoTo saverr
        Me.RoomDetailsBindingSource.EndEdit()
        Me.Room_DetailsTableAdapter.Update(Me.My_Hotel_projectDataSet.Room_Details)
        ' MessageBox.Show("Data Saved Successfully ")
saverr:
        Exit Sub

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs)
        RoomDetailsBindingSource.RemoveCurrent()
    End Sub

    Private Sub closebtn_Click(sender As Object, e As EventArgs) Handles closebtn.Click
        Me.Close()
    End Sub
End Class