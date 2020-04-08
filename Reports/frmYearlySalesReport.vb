Public Class frmYearlySalesReport
    Private Sub FrmYearlySalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'restaurantDataSet1.spYearlySalesReport' table. You can move, or remove it, as needed.
        Me.spYearlySalesReportTableAdapter.Fill(Me.restaurantDataSet1.spYearlySalesReport)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class