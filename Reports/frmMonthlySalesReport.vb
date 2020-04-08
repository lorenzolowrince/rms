Public Class frmMonthlySalesReport
    Private Sub FrmMonthlySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'restaurantDataSet1.spMonthlySalesReport' table. You can move, or remove it, as needed.
        Me.spMonthlySalesReportTableAdapter.Fill(Me.restaurantDataSet1.spMonthlySalesReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class