Public Class frmMenuList
    Private Sub TblFoodBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

        Try
            Me.Validate()
            Me.TblFoodBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RestaurantDataSet1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub FrmMenuManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblBeverageTableAdapter.Fill(Me.RestaurantDataSet1.tblBeverage)
        Me.TblFoodTableAdapter.Fill(Me.RestaurantDataSet1.tblFood)

    End Sub

    Private Sub TblFoodDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblFoodDataGridView.CellDoubleClick


    End Sub

    Private Sub FrmMenu_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Try
            frmCustomerOrder.TblOrdersTableAdapter.FillByTableNo(frmCustomerOrder.RestaurantDataSet1.tblOrders, frmCustomerOrder.TablenoComboBox.Text)
            frmCustomerOrder.TblOrdersTableAdapter1.Fill(frmCustomerOrder.RestaurantDataSet.tblOrders)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub TblBeverageDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblBeverageDataGridView.CellDoubleClick

    End Sub

    Private Sub TblBeverageDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblBeverageDataGridView.CellClick
        Try

            Dim _SQLConnection As New SqlClient.SqlConnection
            _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

            _SQLConnection.Open()

            Dim strsql As String = "INSERT INTO tblOrders(tableno, category, [order], price, quantity, status, [datetime], username) VALUES(@tableno, @category, @order, @price, @quantity, @status, @datetime, @username)"
            Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(strsql, _SQLConnection)

            With TblBeverageDataGridView

                _SqlCommand.Parameters.AddWithValue("@tableno", frmCustomerOrder.TablenoComboBox.Text)
                _SqlCommand.Parameters.AddWithValue("@category", .Rows(e.RowIndex).Cells(1).Value.ToString)
                _SqlCommand.Parameters.AddWithValue("@order", .Rows(e.RowIndex).Cells(3).Value.ToString)
                _SqlCommand.Parameters.AddWithValue("@price", .Rows(e.RowIndex).Cells(4).Value.ToString)
                _SqlCommand.Parameters.AddWithValue("@quantity", 1) 'insert default value
                _SqlCommand.Parameters.AddWithValue("@status", "open") 'insert default value
                _SqlCommand.Parameters.AddWithValue("@datetime", DateTime.Now)
                _SqlCommand.Parameters.AddWithValue("@username", MDIMain.UserLoggedIn.ToString)
                _SqlCommand.ExecuteNonQuery()

                MsgBox(.Rows(e.RowIndex).Cells(3).Value.ToString + " has been added.")

            End With

            _SQLConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TblFoodDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblFoodDataGridView.CellClick

        Try

            Dim _SQLConnection As New SqlClient.SqlConnection
            _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

            _SQLConnection.Open()

            Dim strsql As String = "INSERT INTO tblOrders(tableno, category, [order], price, quantity, status, [datetime], username) VALUES(@tableno, @category, @order, @price, @quantity, @status, @datetime, @username)"
            Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(strsql, _SQLConnection)

            With TblFoodDataGridView

                _SqlCommand.Parameters.AddWithValue("@tableno", frmCustomerOrder.TablenoComboBox.Text)
                _SqlCommand.Parameters.AddWithValue("@category", .Rows(e.RowIndex).Cells(1).Value.ToString)
                _SqlCommand.Parameters.AddWithValue("@order", .Rows(e.RowIndex).Cells(3).Value.ToString)
                _SqlCommand.Parameters.AddWithValue("@price", .Rows(e.RowIndex).Cells(4).Value.ToString)
                _SqlCommand.Parameters.AddWithValue("@quantity", 1) 'insert default value
                _SqlCommand.Parameters.AddWithValue("@status", "open") 'insert default value
                _SqlCommand.Parameters.AddWithValue("@datetime", DateTime.Now)
                _SqlCommand.Parameters.AddWithValue("@username", MDIMain.UserLoggedIn.ToString)
                _SqlCommand.ExecuteNonQuery()

                MsgBox(.Rows(e.RowIndex).Cells(3).Value.ToString + " has been added.")

            End With

            _SQLConnection.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class

