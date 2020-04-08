<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDailySalesReport
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.restaurantDataSet1 = New RestaurantManagementSystem.restaurantDataSet1()
        Me.spDailySalesReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.spDailySalesReportTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.spDailySalesReportTableAdapter()
        CType(Me.restaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.spDailySalesReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DailySalesReport"
        ReportDataSource2.Value = Me.spDailySalesReportBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "RestaurantManagementSystem.DailySalesReport.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'restaurantDataSet1
        '
        Me.restaurantDataSet1.DataSetName = "restaurantDataSet1"
        Me.restaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'spDailySalesReportBindingSource
        '
        Me.spDailySalesReportBindingSource.DataMember = "spDailySalesReport"
        Me.spDailySalesReportBindingSource.DataSource = Me.restaurantDataSet1
        '
        'spDailySalesReportTableAdapter
        '
        Me.spDailySalesReportTableAdapter.ClearBeforeFill = True
        '
        'frmDailySalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmDailySalesReport"
        Me.Text = "Daily Sales Report"
        CType(Me.restaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.spDailySalesReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents spDailySalesReportBindingSource As BindingSource
    Friend WithEvents restaurantDataSet1 As restaurantDataSet1
    Friend WithEvents spDailySalesReportTableAdapter As restaurantDataSet1TableAdapters.spDailySalesReportTableAdapter
End Class
