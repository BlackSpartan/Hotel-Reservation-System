Public Class Form7

   
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'My_Hotel_projectDataSet.Customer_Payment' table. You can move, or remove it, as needed.
        Me.Customer_PaymentTableACAdapter.Fill(Me.My_Hotel_projectDataSet.Customer_Payment)
        cmbcredittype.Items.Add("Visa")
        cmbcredittype.Items.Add("Zimswitch")


        CancelButton = closebtn

    End Sub
    

    Private Sub closebtn_Click_1(sender As Object, e As EventArgs) Handles closebtn.Click

    End Sub

    Private Sub btnpay_Click(sender As Object, e As EventArgs) Handles btnpay.Click
        MessageBox.Show("Payment Successful")
        CustomerPaymentBindingSource.EndEdit()
        Customer_PaymentTableACAdapter.Update(My_Hotel_projectDataSet)
    End Sub

    Private Sub newbtn_Click(sender As Object, e As EventArgs) Handles newbtn.Click
        CustomerPaymentBindingSource.AddNew()
    End Sub
End Class