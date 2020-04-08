Public Class frmMenuSetup
    Private Sub TblFoodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblFoodBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblFoodBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RestaurantDataSet1)

    End Sub

    Private Sub FrmMenuManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TblBeverageTableAdapter.Fill(Me.RestaurantDataSet1.tblBeverage)
        Me.TblFoodTableAdapter.Fill(Me.RestaurantDataSet1.tblFood)

    End Sub
End Class