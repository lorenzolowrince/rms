Public Class frmTableSetup
    Private Sub TblTableNoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblTableNoBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTableNoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RestaurantDataSet1)

    End Sub

    Private Sub FrmTableSetup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblTableNoTableAdapter.Fill(Me.RestaurantDataSet1.tblTableNo)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
        TablenoTextBox.Select()
    End Sub

End Class