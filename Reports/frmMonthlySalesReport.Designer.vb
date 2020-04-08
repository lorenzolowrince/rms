<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMonthlySalesReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.spMonthlySalesReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.restaurantDataSet1 = New RestaurantManagementSystem.restaurantDataSet1()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.spMonthlySalesReportTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.spMonthlySalesReportTableAdapter()
        CType(Me.spMonthlySalesReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.restaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'spMonthlySalesReportBindingSource
        '
        Me.spMonthlySalesReportBindingSource.DataMember = "spMonthlySalesReport"
        Me.spMonthlySalesReportBindingSource.DataSource = Me.restaurantDataSet1
        '
        'restaurantDataSet1
        '
        Me.restaurantDataSet1.DataSetName = "restaurantDataSet1"
        Me.restaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "MonthlySalesReport"
        ReportDataSource1.Value = Me.spMonthlySalesReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RestaurantManagementSystem.MonthlySalesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(922, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'spMonthlySalesReportTableAdapter
        '
        Me.spMonthlySalesReportTableAdapter.ClearBeforeFill = True
        '
        'frmMonthlySalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(922, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmMonthlySalesReport"
        Me.Text = "Monthly Sales Report"
        CType(Me.spMonthlySalesReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.restaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spMonthlySalesReportBindingSource As BindingSource
    Friend WithEvents restaurantDataSet1 As restaurantDataSet1
    Friend WithEvents spMonthlySalesReportTableAdapter As restaurantDataSet1TableAdapters.spMonthlySalesReportTableAdapter
End Class
