<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPayment
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
        Me.txtReceiptAmount = New System.Windows.Forms.TextBox()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtReceiptAmount
        '
        Me.txtReceiptAmount.Location = New System.Drawing.Point(132, 13)
        Me.txtReceiptAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiptAmount.Name = "txtReceiptAmount"
        Me.txtReceiptAmount.ReadOnly = True
        Me.txtReceiptAmount.Size = New System.Drawing.Size(132, 27)
        Me.txtReceiptAmount.TabIndex = 0
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(132, 52)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(132, 27)
        Me.txtCash.TabIndex = 1
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(132, 92)
        Me.txtBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(132, 27)
        Me.txtBalance.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 19)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Receipt Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(80, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cash:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Balance:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(132, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 48)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Pay && Print Receipt"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 205)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.txtReceiptAmount)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmPayment"
        Me.Text = "Make Payment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtReceiptAmount As TextBox
    Friend WithEvents txtCash As TextBox
    Friend WithEvents txtBalance As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
