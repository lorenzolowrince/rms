Public Class frmUserSetup
    Private Sub TblUserBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblUserBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblUserBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RestaurantDataSet1)

    End Sub

    Private Sub FrmUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'RestaurantDataSet1.tblUser' table. You can move, or remove it, as needed.
        Me.TblUserTableAdapter.Fill(Me.RestaurantDataSet1.tblUser)

    End Sub
End Class