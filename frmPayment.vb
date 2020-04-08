Public Class frmPayment

    Dim Balance, Cash, ReceiptAmount As Double

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtCash.TextChanged
        Calculate()
    End Sub

    Private Sub FrmPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCash.Clear()
        txtReceiptAmount.Text = frmCustomerOrder.SpReceiptSummaryDataGridView.Rows(0).Cells(0).Value.ToString()
        txtCash.Select()
    End Sub

    Private Sub TxtBalance_TextChanged(sender As Object, e As EventArgs) Handles txtBalance.TextChanged
        Calculate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Balance = 0 Or Balance < 0 Then

            Try
                Dim _SQLConnection As New SqlClient.SqlConnection
                _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

                Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand("spReceipt", _SQLConnection)
                With _SqlCommand
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("tableno", frmCustomerOrder.TablenoComboBox.Text)
                    .Parameters.AddWithValue("cash", txtCash.Text)
                    .Parameters.AddWithValue("balance", txtBalance.Text)
                    .Parameters.AddWithValue("nextrunningno", GetRunningNo())
                    .Connection.Open()
                    .ExecuteNonQuery()
                    .Connection.Close()
                End With

                'this is to clear any receiptno reference and to show the correct print receipt
                frmPrintReceipt.ReceiptNo = ""
                frmPrintReceipt.ShowDialog()
                Me.Close()

                With frmCustomerOrder

                    .TblOrdersTableAdapter1.Fill(.RestaurantDataSet.tblOrders)
                    .TblOrdersTableAdapter.FillByTableNo(.RestaurantDataSet1.tblOrders, 0)
                    .SpReceiptSummaryTableAdapter.Fill(.RestaurantDataSet1.spReceiptSummary, 0)

                End With

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MessageBox.Show("Please enter the right cash amount", "Make Payment", MessageBoxButtons.OK)
            txtCash.Select()
        End If

    End Sub

    Private Function GetRunningNo() As Integer

        Dim RunningNo As Integer
        Dim _SQLConnection As New SqlClient.SqlConnection
        _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

        _SQLConnection.Open()

        Dim strsql As String = "select max(id) from tblReceipt"
        Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(strsql, _SQLConnection)
        Dim _SQLDataReader As SqlClient.SqlDataReader = _SqlCommand.ExecuteReader

        If _SQLDataReader.HasRows = True Then

            While _SQLDataReader.Read

                If _SQLDataReader.IsDBNull(0) = True Then
                    RunningNo = 1 'provide initial value of 1 to start the running no
                ElseIf _SQLDataReader.IsDBNull(0) = False Then
                    RunningNo = _SQLDataReader.Item(0) + 1
                End If

            End While

        End If

        Return RunningNo

    End Function


    Private Sub TxtReceiptAmount_TextChanged(sender As Object, e As EventArgs) Handles txtReceiptAmount.TextChanged
        Calculate()
    End Sub

    Private Sub Calculate()

        Try

            If txtCash.Text = "" Then
                txtCash.Text = 0
            ElseIf txtReceiptAmount.Text = "" Then
                txtReceiptAmount.Text = 0
            End If

            Cash = CType(txtCash.Text, Double)
            ReceiptAmount = CType(txtReceiptAmount.Text, Double)

            Balance = ReceiptAmount - Cash
            txtBalance.Text = Balance

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class