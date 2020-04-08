<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTableSetup
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
        Dim TablenoLabel As System.Windows.Forms.Label
        Dim TablelocationLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTableSetup))
        Me.RestaurantDataSet1 = New RestaurantManagementSystem.restaurantDataSet1()
        Me.TblTableNoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTableNoTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.tblTableNoTableAdapter()
        Me.TableAdapterManager = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager()
        Me.TblTableNoBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblTableNoBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblTableNoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablenoTextBox = New System.Windows.Forms.TextBox()
        Me.TablelocationTextBox = New System.Windows.Forms.TextBox()
        TablenoLabel = New System.Windows.Forms.Label()
        TablelocationLabel = New System.Windows.Forms.Label()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTableNoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTableNoBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTableNoBindingNavigator.SuspendLayout()
        CType(Me.TblTableNoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TablenoLabel
        '
        TablenoLabel.AutoSize = True
        TablenoLabel.Location = New System.Drawing.Point(50, 43)
        TablenoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TablenoLabel.Name = "TablenoLabel"
        TablenoLabel.Size = New System.Drawing.Size(70, 19)
        TablenoLabel.TabIndex = 4
        TablenoLabel.Text = "Table No:"
        '
        'TablelocationLabel
        '
        TablelocationLabel.AutoSize = True
        TablelocationLabel.Location = New System.Drawing.Point(13, 78)
        TablelocationLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TablelocationLabel.Name = "TablelocationLabel"
        TablelocationLabel.Size = New System.Drawing.Size(107, 19)
        TablelocationLabel.TabIndex = 6
        TablelocationLabel.Text = "Table Location:"
        '
        'RestaurantDataSet1
        '
        Me.RestaurantDataSet1.DataSetName = "restaurantDataSet1"
        Me.RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblTableNoBindingSource
        '
        Me.TblTableNoBindingSource.DataMember = "tblTableNo"
        Me.TblTableNoBindingSource.DataSource = Me.RestaurantDataSet1
        '
        'TblTableNoTableAdapter
        '
        Me.TblTableNoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBeverageTableAdapter = Nothing
        Me.TableAdapterManager.tblFoodTableAdapter = Nothing
        Me.TableAdapterManager.tblOrdersTableAdapter = Nothing
        Me.TableAdapterManager.tblTableNoTableAdapter = Me.TblTableNoTableAdapter
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTableNoBindingNavigator
        '
        Me.TblTableNoBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTableNoBindingNavigator.BindingSource = Me.TblTableNoBindingSource
        Me.TblTableNoBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTableNoBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTableNoBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTableNoBindingNavigatorSaveItem})
        Me.TblTableNoBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTableNoBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTableNoBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTableNoBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTableNoBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTableNoBindingNavigator.Name = "TblTableNoBindingNavigator"
        Me.TblTableNoBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTableNoBindingNavigator.Size = New System.Drawing.Size(503, 25)
        Me.TblTableNoBindingNavigator.TabIndex = 0
        Me.TblTableNoBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblTableNoBindingNavigatorSaveItem
        '
        Me.TblTableNoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTableNoBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTableNoBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTableNoBindingNavigatorSaveItem.Name = "TblTableNoBindingNavigatorSaveItem"
        Me.TblTableNoBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTableNoBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTableNoDataGridView
        '
        Me.TblTableNoDataGridView.AutoGenerateColumns = False
        Me.TblTableNoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTableNoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.TblTableNoDataGridView.DataSource = Me.TblTableNoBindingSource
        Me.TblTableNoDataGridView.Location = New System.Drawing.Point(13, 121)
        Me.TblTableNoDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TblTableNoDataGridView.Name = "TblTableNoDataGridView"
        Me.TblTableNoDataGridView.Size = New System.Drawing.Size(477, 443)
        Me.TblTableNoDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tableno"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Table No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 91
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "tablelocation"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Table Location"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 128
        '
        'TablenoTextBox
        '
        Me.TablenoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTableNoBindingSource, "tableno", True))
        Me.TablenoTextBox.Location = New System.Drawing.Point(128, 40)
        Me.TablenoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TablenoTextBox.Name = "TablenoTextBox"
        Me.TablenoTextBox.Size = New System.Drawing.Size(132, 27)
        Me.TablenoTextBox.TabIndex = 5
        '
        'TablelocationTextBox
        '
        Me.TablelocationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblTableNoBindingSource, "tablelocation", True))
        Me.TablelocationTextBox.Location = New System.Drawing.Point(128, 75)
        Me.TablelocationTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TablelocationTextBox.Name = "TablelocationTextBox"
        Me.TablelocationTextBox.Size = New System.Drawing.Size(215, 27)
        Me.TablelocationTextBox.TabIndex = 7
        '
        'frmTableSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 575)
        Me.Controls.Add(TablenoLabel)
        Me.Controls.Add(Me.TablenoTextBox)
        Me.Controls.Add(TablelocationLabel)
        Me.Controls.Add(Me.TablelocationTextBox)
        Me.Controls.Add(Me.TblTableNoDataGridView)
        Me.Controls.Add(Me.TblTableNoBindingNavigator)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmTableSetup"
        Me.Text = "Table Setup"
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTableNoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTableNoBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTableNoBindingNavigator.ResumeLayout(False)
        Me.TblTableNoBindingNavigator.PerformLayout()
        CType(Me.TblTableNoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RestaurantDataSet1 As restaurantDataSet1
    Friend WithEvents TblTableNoBindingSource As BindingSource
    Friend WithEvents TblTableNoTableAdapter As restaurantDataSet1TableAdapters.tblTableNoTableAdapter
    Friend WithEvents TableAdapterManager As restaurantDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TblTableNoBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TblTableNoBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TblTableNoDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents TablenoTextBox As TextBox
    Friend WithEvents TablelocationTextBox As TextBox
End Class
