Public Class frmDailySalesReport
    Private Sub FrmDailySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'restaurantDataSet1.spDailySalesReport' table. You can move, or remove it, as needed.
        Me.spDailySalesReportTableAdapter.Fill(Me.restaurantDataSet1.spDailySalesReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class