Public Class frmPrintReceipt

    Private _ReceiptNo As String

    Public Property ReceiptNo As String
        Get
            Return _ReceiptNo
        End Get
        Set(value As String)
            _ReceiptNo = value
        End Set
    End Property

    Private Sub FrmPrintReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ReceiptNo = "" Then
            'this is for the system to generate a new receipt no
            Me.spPrintReceiptTableAdapter.Fill(Me.restaurantDataSet1.spPrintReceipt, GetReceiptNo)
        Else
            'this is for the system to print previous receipt no
            Me.spPrintReceiptTableAdapter.Fill(Me.restaurantDataSet1.spPrintReceipt, ReceiptNo)
        End If

        Me.ReportViewer1.RefreshReport()

    End Sub

    'This function is to generate the running receipt no. e.g. 20040901, 20040902, 20040903 ...
    Private Function GetReceiptNo() As String

        Dim ReceiptNo As String = ""
        Dim _SQLConnection As New SqlClient.SqlConnection
        _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString

        _SQLConnection.Open()

        Dim strsql As String = "select max(id), receiptno from tblReceipt group by receiptno"
        Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(strsql, _SQLConnection)
        Dim _SQLDataReader As SqlClient.SqlDataReader = _SqlCommand.ExecuteReader

        If _SQLDataReader.HasRows = True Then

            While _SQLDataReader.Read

                If _SQLDataReader.IsDBNull(1) = True Then
                    'ReceiptNo = _SQLDataReader.Item(1).ToString
                    MsgBox("Cannot fetch receipt no from database.")
                ElseIf _SQLDataReader.IsDBNull(1) = False Then
                    ReceiptNo = _SQLDataReader.Item(1).ToString
                End If

            End While

        End If

        Return ReceiptNo

    End Function


End Class