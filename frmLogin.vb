Public Class frmLogin

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See https://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Dim _SQLConnection As New SqlClient.SqlConnection
        _SQLConnection.ConnectionString = My.Settings.restaurantConnectionString
        _SQLConnection.Open()

        Dim strsql As String = "select username, password, role from tblUser where username = @username and password = @password"

        Dim _SqlCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(strsql, _SQLConnection)
        _SqlCommand.Parameters.AddWithValue("@username", UsernameTextBox.Text)
        _SqlCommand.Parameters.AddWithValue("@password", PasswordTextBox.Text)

        Dim _SQLDataReader As SqlClient.SqlDataReader = _SqlCommand.ExecuteReader

        If _SQLDataReader.HasRows = True Then

            MDIMain.UserLoggedIn = UsernameTextBox.Text
            MDIMain.ToolStripStatusLabel1.Text = "You are currently logged in as: " & MDIMain.UserLoggedIn.ToString
            Me.Close()

            Dim role As String = ""

            While _SQLDataReader.Read
                'check for the role
                role = _SQLDataReader.Item(2).ToString
            End While

            If role = "admin" Then
                MDIMain.ToolStripMenuItem1.Enabled = True
                MDIMain.ToolStripMenuItem2.Enabled = True
                MDIMain.ToolStripMenuItem3.Enabled = True
                MDIMain.ToolStripMenuItem4.Enabled = True
                MDIMain.ToolStripMenuItem6.Enabled = True
            Else
                MDIMain.ToolStripMenuItem1.Enabled = True
                MDIMain.ToolStripMenuItem2.Enabled = False
                MDIMain.ToolStripMenuItem3.Enabled = True
                MDIMain.ToolStripMenuItem4.Enabled = False
                MDIMain.ToolStripMenuItem6.Enabled = False
            End If

        Else
            MessageBox.Show("Wrong username or password.", "Login", MessageBoxButtons.OK)
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
            UsernameTextBox.Select()
        End If

        _SQLConnection.Close()

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
