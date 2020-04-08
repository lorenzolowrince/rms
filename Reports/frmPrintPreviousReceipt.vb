Public Class frmPrintPreviousReceipt

    Dim ReceiptNo As String

    Private Sub FrmPrintPreviousReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TblReceiptTableAdapter.Fill(Me.RestaurantDataSet1.tblReceipt)

    End Sub

    Private Sub TblReceiptDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TblReceiptDataGridView.CellClick

        Try
            ReceiptNo = TblReceiptDataGridView.Rows(e.RowIndex).Cells(1).Value.ToString
            Me.SpPrintPreviousReceiptsTableAdapter.Fill(Me.RestaurantDataSet1.spPrintPreviousReceipts, ReceiptNo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub PrintToolStripButton_Click(sender As Object, e As EventArgs) Handles PrintToolStripButton.Click
        frmPrintReceipt.ReceiptNo = ReceiptNo
        frmPrintReceipt.ShowDialog()
    End Sub

End Class