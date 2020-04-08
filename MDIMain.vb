Imports System.Windows.Forms

Public Class MDIMain

    Private _UserLoggedIn As String
    Public Property UserLoggedIn As String
        Get
            Return _UserLoggedIn
        End Get
        Set(ByVal value As String)
            _UserLoggedIn = value
        End Set
    End Property

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Create a new instance of the child form.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Make it a child of this MDI form before showing it.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Window " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Add code here to open the file.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Add code here to save the current contents of the form to a file.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub


    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub FileMenu_Click(sender As Object, e As EventArgs) Handles FileMenu.Click
        frmLogin.MdiParent = Me
        frmLogin.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        frmUserSetup.MdiParent = Me
        frmUserSetup.Show()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        frmMenuSetup.MdiParent = Me
        frmMenuSetup.Show()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        frmCustomerOrder.MdiParent = Me
        frmCustomerOrder.Show()
    End Sub

    Private Sub MDIMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ToolStripMenuItem1.Enabled = False
        ToolStripMenuItem2.Enabled = False
        ToolStripMenuItem3.Enabled = False
        ToolStripMenuItem4.Enabled = False
        ToolStripMenuItem6.Enabled = False

        frmLogin.MdiParent = Me
        frmLogin.Show()

    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        frmAbout.MdiParent = Me
        frmAbout.Show()
    End Sub

    Private Sub OrderListToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DailySalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailySalesReportToolStripMenuItem.Click
        frmDailySalesReport.MdiParent = Me
        frmDailySalesReport.Show()
    End Sub

    Private Sub ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem6.Click
        frmTableSetup.MdiParent = Me
        frmTableSetup.Show()
    End Sub

    Private Sub ToolStripMenuItem13_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem13.Click
        frmAbout.MdiParent = Me
        frmAbout.Show()
    End Sub

    Private Sub MonthlySalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlySalesReportToolStripMenuItem.Click
        frmMonthlySalesReport.MdiParent = Me
        frmMonthlySalesReport.Show()
    End Sub

    Private Sub YearlySalesReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearlySalesReportToolStripMenuItem.Click
        frmYearlySalesReport.MdiParent = Me
        frmYearlySalesReport.Show()
    End Sub

    Private Sub PrintPreviousReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintPreviousReceiptToolStripMenuItem.Click
        frmPrintPreviousReceipt.MdiParent = Me
        frmPrintPreviousReceipt.Show()
    End Sub
End Class
