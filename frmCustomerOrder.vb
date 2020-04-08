Public Class frmCustomerOrder
    Private Sub TblOrdersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblOrdersBindingNavigatorSaveItem.Click

        If TablenoComboBox.Text = "" Then
            MsgBox("Please select Table No")
            TablenoComboBox.Select()

        ElseIf DiscountTextBox.Text = "" Then

            Dim result As DialogResult = MessageBox.Show("Do you want to give discount?", "Discount", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                MessageBox.Show("Please insert discount", "Discount", MessageBoxButtons.OK)
                DiscountTextBox.Select()

            ElseIf result = DialogResult.No Then
                Save()
            End If

        Else
            Save()

        End If

    End Sub

    Private Sub Save()

        Try
            Me.Validate()
            Me.TblOrdersBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.RestaurantDataSet1)

            Dim _SQLConnection As New SqlClient.SqlConnection
            _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

            Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("spInsertDiscount", _SQLConnection)
            With _SqlCommand
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("discount", DiscountTextBox.Text)
                .Parameters.AddWithValue("tableno", TablenoComboBox.Text)
                .Connection.Open()
                .ExecuteNonQuery()
                .Connection.Close()
            End With

            Me.TblOrdersTableAdapter.FillByTableNo(Me.RestaurantDataSet1.tblOrders, TablenoComboBox.Text)
            Me.TblOrdersTableAdapter1.Fill(Me.RestaurantDataSet.tblOrders)

            MsgBox("Order has been updated.")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblOrdersTableAdapter1.Fill(Me.RestaurantDataSet.tblOrders)
        LoadComboBox()
    End Sub

    Public Sub LoadComboBox()

        Dim _SQLConnection As New SqlClient.SqlConnection
        _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

        _SQLConnection.Open()

        Dim strsql As String = "select tableno, tablelocation from tblTableNo"
        Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(strsql, _SQLConnection)
        Dim _SQLDataReader As SqlClient.SqlDataReader = _SqlCommand.ExecuteReader

        If _SQLDataReader.HasRows = True Then

            While _SQLDataReader.Read

                If _SQLDataReader.IsDBNull(0) = True Then

                ElseIf _SQLDataReader.IsDBNull(0) = False Then
                    TablenoComboBox.Items.Add(_SQLDataReader.Item(0).ToString + "-" + _SQLDataReader.Item(1).ToString)
                End If

            End While
        Else
            MessageBox.Show("Please setup table.", "Table Setup", MessageBoxButtons.OK)

        End If

    End Sub

    Private Sub TblOrdersDataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblOrdersDataGridView1.CellClick
        Try
            Me.TblOrdersTableAdapter.FillByTableNo(Me.RestaurantDataSet1.tblOrders, TblOrdersDataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
            Me.SpReceiptSummaryTableAdapter.Fill(Me.RestaurantDataSet1.spReceiptSummary, TblOrdersDataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_Click_1(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        If TablenoComboBox.Text = "" Then
            MsgBox("Please select Table No")
        Else
            frmMenuList.ShowDialog()
        End If

    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) 

        'If TablenoComboBox.Text = "" Then
        '    MessageBox.Show("Please select which table no to print the receipt", "Receipt", MessageBoxButtons.OK)
        'Else

        '    Dim result As DialogResult = MessageBox.Show("Proceed to print receipt?", "Receipt", MessageBoxButtons.YesNo)

        '    If result = DialogResult.Yes Then

        '        Try
        '            Dim _SQLConnection As New SqlClient.SqlConnection
        '            _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

        '            Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("spReceipt", _SQLConnection)
        '            With _SqlCommand
        '                .CommandType = CommandType.StoredProcedure
        '                .Parameters.AddWithValue("tableno", TablenoComboBox.Text)
        '                MsgBox(TablenoComboBox.Text)
        '                .Parameters.AddWithValue("nextrunningno", GetRunningNo())
        '                .Connection.Open()
        '                .ExecuteNonQuery()
        '                .Connection.Close()
        '            End With

        '            frmPrintReceipt.ShowDialog()

        '        Catch ex As Exception
        '            MsgBox(ex.Message)
        '        End Try

        '    ElseIf result = DialogResult.No Then
        '        Exit Sub
        '    End If

        'End If

    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        If TablenoComboBox.Text = "" Then
            MessageBox.Show("Please select from Customer Order Summary to proceed.", "Payment", MessageBoxButtons.OK)
        Else
            frmPayment.ShowDialog()
        End If
    End Sub

End Class