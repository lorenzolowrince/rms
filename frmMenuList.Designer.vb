<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuList
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
        Dim Label3 As System.Windows.Forms.Label
        Me.TblFoodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantDataSet1 = New RestaurantManagementSystem.restaurantDataSet1()
        Me.TblFoodDataGridView = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.category2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBeverageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblBeverageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblFoodTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.tblFoodTableAdapter()
        Me.TableAdapterManager = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager()
        Me.TblBeverageTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.tblBeverageTableAdapter()
        Me.TableAdapterManager1 = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TblFoodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFoodDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBeverageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblBeverageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(7, 9)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(299, 19)
        Label3.TabIndex = 7
        Label3.Text = "> Double click on the selection below to add."
        '
        'TblFoodBindingSource
        '
        Me.TblFoodBindingSource.DataMember = "tblFood"
        Me.TblFoodBindingSource.DataSource = Me.RestaurantDataSet1
        '
        'RestaurantDataSet1
        '
        Me.RestaurantDataSet1.DataSetName = "restaurantDataSet1"
        Me.RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFoodDataGridView
        '
        Me.TblFoodDataGridView.AutoGenerateColumns = False
        Me.TblFoodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblFoodDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.DataGridViewTextBoxColumn2, Me.category2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.TblFoodDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TblFoodDataGridView.DataSource = Me.TblFoodBindingSource
        Me.TblFoodDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblFoodDataGridView.Location = New System.Drawing.Point(3, 23)
        Me.TblFoodDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TblFoodDataGridView.Name = "TblFoodDataGridView"
        Me.TblFoodDataGridView.ReadOnly = True
        Me.TblFoodDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblFoodDataGridView.Size = New System.Drawing.Size(507, 416)
        Me.TblFoodDataGridView.TabIndex = 0
        '
        'id
        '
        Me.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.id.DataPropertyName = "id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.Width = 92
        '
        'category2
        '
        Me.category2.DataPropertyName = "category2"
        Me.category2.HeaderText = "category2"
        Me.category2.Name = "category2"
        Me.category2.ReadOnly = True
        Me.category2.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 72
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 66
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'TblBeverageDataGridView
        '
        Me.TblBeverageDataGridView.AutoGenerateColumns = False
        Me.TblBeverageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblBeverageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.TblBeverageDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TblBeverageDataGridView.DataSource = Me.TblBeverageBindingSource
        Me.TblBeverageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TblBeverageDataGridView.Location = New System.Drawing.Point(3, 23)
        Me.TblBeverageDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TblBeverageDataGridView.Name = "TblBeverageDataGridView"
        Me.TblBeverageDataGridView.ReadOnly = True
        Me.TblBeverageDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblBeverageDataGridView.Size = New System.Drawing.Size(504, 416)
        Me.TblBeverageDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "category"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Width = 92
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "category2"
        Me.DataGridViewTextBoxColumn9.HeaderText = "category2"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "name"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 72
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "price"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 66
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'TblBeverageBindingSource
        '
        Me.TblBeverageBindingSource.DataMember = "tblBeverage"
        Me.TblBeverageBindingSource.DataSource = Me.RestaurantDataSet1
        '
        'TblFoodTableAdapter
        '
        Me.TblFoodTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBeverageTableAdapter = Me.TblBeverageTableAdapter
        Me.TableAdapterManager.tblFoodTableAdapter = Me.TblFoodTableAdapter
        Me.TableAdapterManager.tblOrdersTableAdapter = Nothing
        Me.TableAdapterManager.tblReceiptTableAdapter = Nothing
        Me.TableAdapterManager.tblTableNoTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblBeverageTableAdapter
        '
        Me.TblBeverageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.tblBeverageTableAdapter = Nothing
        Me.TableAdapterManager1.tblFoodTableAdapter = Nothing
        Me.TableAdapterManager1.tblOrdersTableAdapter = Nothing
        Me.TableAdapterManager1.tblReceiptTableAdapter = Nothing
        Me.TableAdapterManager1.tblTableNoTableAdapter = Nothing
        Me.TableAdapterManager1.tblUserTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TblFoodDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(513, 442)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Food Selection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TblBeverageDataGridView)
        Me.GroupBox2.Location = New System.Drawing.Point(532, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(510, 442)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Beverage Selection"
        '
        'frmMenuList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 486)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Label3)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMenuList"
        Me.Text = "Menu List"
        CType(Me.TblFoodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFoodDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBeverageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblBeverageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RestaurantDataSet1 As restaurantDataSet1
    Friend WithEvents TblFoodBindingSource As BindingSource
    Friend WithEvents TblFoodTableAdapter As restaurantDataSet1TableAdapters.tblFoodTableAdapter
    Friend WithEvents TableAdapterManager As restaurantDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TblFoodDataGridView As DataGridView
    Friend WithEvents TblBeverageTableAdapter As restaurantDataSet1TableAdapters.tblBeverageTableAdapter
    Friend WithEvents TblBeverageBindingSource As BindingSource
    Friend WithEvents TblBeverageDataGridView As DataGridView
    Friend WithEvents TableAdapterManager1 As restaurantDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents category2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
End Class
