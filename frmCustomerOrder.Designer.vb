<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim TablenoLabel As System.Windows.Forms.Label
        Dim DiscountLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerOrder))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TblOrdersBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TblOrdersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantDataSet1 = New RestaurantManagementSystem.restaurantDataSet1()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblOrdersBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblOrdersDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TablenoComboBox = New System.Windows.Forms.ComboBox()
        Me.TblOrdersDataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TblOrdersBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RestaurantDataSet = New RestaurantManagementSystem.restaurantDataSet()
        Me.TblOrdersTableAdapter1 = New RestaurantManagementSystem.restaurantDataSetTableAdapters.tblOrdersTableAdapter()
        Me.TableAdapterManager1 = New RestaurantManagementSystem.restaurantDataSetTableAdapters.TableAdapterManager()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.SpReceiptSummaryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpReceiptSummaryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.PrintToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DiscountTextBox = New System.Windows.Forms.TextBox()
        Me.TblOrdersTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.tblOrdersTableAdapter()
        Me.TableAdapterManager = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager()
        Me.SpReceiptSummaryTableAdapter = New RestaurantManagementSystem.restaurantDataSet1TableAdapters.spReceiptSummaryTableAdapter()
        TablenoLabel = New System.Windows.Forms.Label()
        DiscountLabel = New System.Windows.Forms.Label()
        CType(Me.TblOrdersBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblOrdersBindingNavigator.SuspendLayout()
        CType(Me.TblOrdersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrdersDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrdersDataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblOrdersBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.SpReceiptSummaryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpReceiptSummaryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TablenoLabel
        '
        TablenoLabel.AutoSize = True
        TablenoLabel.Font = New System.Drawing.Font("Calibri", 12.0!)
        TablenoLabel.Location = New System.Drawing.Point(11, 67)
        TablenoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TablenoLabel.Name = "TablenoLabel"
        TablenoLabel.Size = New System.Drawing.Size(144, 19)
        TablenoLabel.TabIndex = 2
        TablenoLabel.Text = "Table No && Location:"
        '
        'DiscountLabel
        '
        DiscountLabel.AutoSize = True
        DiscountLabel.Location = New System.Drawing.Point(375, 67)
        DiscountLabel.Name = "DiscountLabel"
        DiscountLabel.Size = New System.Drawing.Size(70, 19)
        DiscountLabel.TabIndex = 4
        DiscountLabel.Text = "Discount:"
        '
        'TblOrdersBindingNavigator
        '
        Me.TblOrdersBindingNavigator.AddNewItem = Nothing
        Me.TblOrdersBindingNavigator.BindingSource = Me.TblOrdersBindingSource
        Me.TblOrdersBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblOrdersBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblOrdersBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.ToolStripSeparator1, Me.BindingNavigatorDeleteItem, Me.TblOrdersBindingNavigatorSaveItem, Me.ToolStripSeparator2, Me.ToolStripButton1, Me.ToolStripSeparator3, Me.ToolStripSeparator4})
        Me.TblOrdersBindingNavigator.Location = New System.Drawing.Point(3, 23)
        Me.TblOrdersBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblOrdersBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblOrdersBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblOrdersBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblOrdersBindingNavigator.Name = "TblOrdersBindingNavigator"
        Me.TblOrdersBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblOrdersBindingNavigator.Size = New System.Drawing.Size(614, 25)
        Me.TblOrdersBindingNavigator.TabIndex = 0
        Me.TblOrdersBindingNavigator.Text = "BindingNavigator1"
        '
        'TblOrdersBindingSource
        '
        Me.TblOrdersBindingSource.DataMember = "tblOrders"
        Me.TblOrdersBindingSource.DataSource = Me.RestaurantDataSet1
        '
        'RestaurantDataSet1
        '
        Me.RestaurantDataSet1.DataSetName = "restaurantDataSet1"
        Me.RestaurantDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(60, 22)
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
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 23)
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'TblOrdersBindingNavigatorSaveItem
        '
        Me.TblOrdersBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblOrdersBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblOrdersBindingNavigatorSaveItem.Name = "TblOrdersBindingNavigatorSaveItem"
        Me.TblOrdersBindingNavigatorSaveItem.Size = New System.Drawing.Size(78, 22)
        Me.TblOrdersBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripButton1.Text = "Click to Insert/Add Order"
        Me.ToolStripButton1.ToolTipText = "Click to Insert/Add Order"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'TblOrdersDataGridView
        '
        Me.TblOrdersDataGridView.AllowUserToResizeColumns = False
        Me.TblOrdersDataGridView.AllowUserToResizeRows = False
        Me.TblOrdersDataGridView.AutoGenerateColumns = False
        Me.TblOrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblOrdersDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.TblOrdersDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TblOrdersDataGridView.DataSource = Me.TblOrdersBindingSource
        Me.TblOrdersDataGridView.Location = New System.Drawing.Point(7, 99)
        Me.TblOrdersDataGridView.Margin = New System.Windows.Forms.Padding(4)
        Me.TblOrdersDataGridView.Name = "TblOrdersDataGridView"
        Me.TblOrdersDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TblOrdersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblOrdersDataGridView.Size = New System.Drawing.Size(606, 423)
        Me.TblOrdersDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tableno"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.HeaderText = "Table No"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
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
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "order"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Item"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 63
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "quantity"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn4.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 90
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "price"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn6.HeaderText = "Price"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 66
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "datetime"
        Me.DataGridViewTextBoxColumn7.HeaderText = "datetime"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'TablenoComboBox
        '
        Me.TablenoComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrdersBindingSource, "tableno", True))
        Me.TablenoComboBox.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablenoComboBox.FormattingEnabled = True
        Me.TablenoComboBox.Location = New System.Drawing.Point(163, 64)
        Me.TablenoComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TablenoComboBox.Name = "TablenoComboBox"
        Me.TablenoComboBox.Size = New System.Drawing.Size(197, 27)
        Me.TablenoComboBox.TabIndex = 3
        '
        'TblOrdersDataGridView1
        '
        Me.TblOrdersDataGridView1.AllowUserToResizeColumns = False
        Me.TblOrdersDataGridView1.AllowUserToResizeRows = False
        Me.TblOrdersDataGridView1.AutoGenerateColumns = False
        Me.TblOrdersDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblOrdersDataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.TblOrdersDataGridView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.TblOrdersDataGridView1.DataSource = Me.TblOrdersBindingSource1
        Me.TblOrdersDataGridView1.Location = New System.Drawing.Point(10, 23)
        Me.TblOrdersDataGridView1.Name = "TblOrdersDataGridView1"
        Me.TblOrdersDataGridView1.ReadOnly = True
        Me.TblOrdersDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.TblOrdersDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TblOrdersDataGridView1.Size = New System.Drawing.Size(398, 333)
        Me.TblOrdersDataGridView1.TabIndex = 4
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "tableno"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Table No"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 91
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Total Amount"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Total Amount"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 120
        '
        'TblOrdersBindingSource1
        '
        Me.TblOrdersBindingSource1.DataMember = "tblOrders"
        Me.TblOrdersBindingSource1.DataSource = Me.RestaurantDataSet
        '
        'RestaurantDataSet
        '
        Me.RestaurantDataSet.DataSetName = "restaurantDataSet"
        Me.RestaurantDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblOrdersTableAdapter1
        '
        Me.TblOrdersTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = RestaurantManagementSystem.restaurantDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.TblOrdersDataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(417, 540)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Order Summary"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.SpReceiptSummaryDataGridView)
        Me.GroupBox3.Controls.Add(Me.BindingNavigator1)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 362)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(405, 163)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Receipt Summary"
        '
        'SpReceiptSummaryDataGridView
        '
        Me.SpReceiptSummaryDataGridView.AllowUserToResizeColumns = False
        Me.SpReceiptSummaryDataGridView.AllowUserToResizeRows = False
        Me.SpReceiptSummaryDataGridView.AutoGenerateColumns = False
        Me.SpReceiptSummaryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SpReceiptSummaryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13})
        Me.SpReceiptSummaryDataGridView.DataSource = Me.SpReceiptSummaryBindingSource
        Me.SpReceiptSummaryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SpReceiptSummaryDataGridView.Location = New System.Drawing.Point(3, 61)
        Me.SpReceiptSummaryDataGridView.Name = "SpReceiptSummaryDataGridView"
        Me.SpReceiptSummaryDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.SpReceiptSummaryDataGridView.Size = New System.Drawing.Size(399, 99)
        Me.SpReceiptSummaryDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Receipt Amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Receipt Amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Before Rounding"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Before Rounding"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Rounding Adjustment"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Rounding Adjustment"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'SpReceiptSummaryBindingSource
        '
        Me.SpReceiptSummaryBindingSource.DataMember = "spReceiptSummary"
        Me.SpReceiptSummaryBindingSource.DataSource = Me.RestaurantDataSet1
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.TblOrdersBindingSource
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripButton, Me.toolStripSeparator})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 23)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(399, 38)
        Me.BindingNavigator1.TabIndex = 5
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'PrintToolStripButton
        '
        Me.PrintToolStripButton.Image = CType(resources.GetObject("PrintToolStripButton.Image"), System.Drawing.Image)
        Me.PrintToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PrintToolStripButton.Name = "PrintToolStripButton"
        Me.PrintToolStripButton.Size = New System.Drawing.Size(113, 35)
        Me.PrintToolStripButton.Text = "Pay && Print Receipt"
        Me.PrintToolStripButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(6, 38)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(DiscountLabel)
        Me.GroupBox2.Controls.Add(Me.DiscountTextBox)
        Me.GroupBox2.Controls.Add(Me.TblOrdersBindingNavigator)
        Me.GroupBox2.Controls.Add(Me.TblOrdersDataGridView)
        Me.GroupBox2.Controls.Add(TablenoLabel)
        Me.GroupBox2.Controls.Add(Me.TablenoComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(435, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(620, 540)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Order List"
        '
        'DiscountTextBox
        '
        Me.DiscountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TblOrdersBindingSource, "discount", True))
        Me.DiscountTextBox.Location = New System.Drawing.Point(451, 64)
        Me.DiscountTextBox.Name = "DiscountTextBox"
        Me.DiscountTextBox.Size = New System.Drawing.Size(44, 27)
        Me.DiscountTextBox.TabIndex = 5
        '
        'TblOrdersTableAdapter
        '
        Me.TblOrdersTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblBeverageTableAdapter = Nothing
        Me.TableAdapterManager.tblFoodTableAdapter = Nothing
        Me.TableAdapterManager.tblOrdersTableAdapter = Me.TblOrdersTableAdapter
        Me.TableAdapterManager.tblReceiptTableAdapter = Nothing
        Me.TableAdapterManager.tblTableNoTableAdapter = Nothing
        Me.TableAdapterManager.tblUserTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = RestaurantManagementSystem.restaurantDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'SpReceiptSummaryTableAdapter
        '
        Me.SpReceiptSummaryTableAdapter.ClearBeforeFill = True
        '
        'frmCustomerOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 560)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCustomerOrder"
        Me.Text = "Customer Order Management"
        CType(Me.TblOrdersBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblOrdersBindingNavigator.ResumeLayout(False)
        Me.TblOrdersBindingNavigator.PerformLayout()
        CType(Me.TblOrdersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrdersDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrdersDataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblOrdersBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RestaurantDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.SpReceiptSummaryDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpReceiptSummaryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RestaurantDataSet1 As restaurantDataSet1
    Friend WithEvents TblOrdersBindingSource As BindingSource
    Friend WithEvents TblOrdersTableAdapter As restaurantDataSet1TableAdapters.tblOrdersTableAdapter
    Friend WithEvents TableAdapterManager As restaurantDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents TblOrdersBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents TblOrdersBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents TablenoComboBox As ComboBox
    Friend WithEvents RestaurantDataSet As restaurantDataSet
    Friend WithEvents TblOrdersBindingSource1 As BindingSource
    Friend WithEvents TblOrdersTableAdapter1 As restaurantDataSetTableAdapters.tblOrdersTableAdapter
    Friend WithEvents TableAdapterManager1 As restaurantDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents DiscountTextBox As TextBox
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents SpReceiptSummaryBindingSource As BindingSource
    Friend WithEvents SpReceiptSummaryTableAdapter As restaurantDataSet1TableAdapters.spReceiptSummaryTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox3 As GroupBox
    Public WithEvents TblOrdersDataGridView As DataGridView
    Public WithEvents TblOrdersDataGridView1 As DataGridView
    Public WithEvents SpReceiptSummaryDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PrintToolStripButton As ToolStripButton
    Friend WithEvents toolStripSeparator As ToolStripSeparator
End Class
