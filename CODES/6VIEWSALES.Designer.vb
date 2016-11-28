<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VIEWSALESFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VIEWSALESFORM))
        Me.SalesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.SalesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANDOKSDataSet = New WindowsApplication1.ANDOKSDataSet()
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
        Me.SalesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.btnHOMESUPERVISOR = New System.Windows.Forms.Button()
        Me.SALES_NO = New System.Windows.Forms.Label()
        Me.SalesItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.SalesItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.total_sale_display = New System.Windows.Forms.Label()
        Me.searchDate = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.searchMonthly = New System.Windows.Forms.ComboBox()
        Me.SalesTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.SalesTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ANDOKSDataSetTableAdapters.TableAdapterManager()
        Me.PaymentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PaymentTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.PaymentTableAdapter()
        Me.SalesItemTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.SalesItemTableAdapter()
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SalesBindingNavigator.SuspendLayout()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SalesBindingNavigator
        '
        Me.SalesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.SalesBindingNavigator.BindingSource = Me.SalesBindingSource
        Me.SalesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.SalesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.SalesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.SalesBindingNavigatorSaveItem})
        Me.SalesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.SalesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.SalesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.SalesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.SalesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.SalesBindingNavigator.Name = "SalesBindingNavigator"
        Me.SalesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.SalesBindingNavigator.Size = New System.Drawing.Size(937, 29)
        Me.SalesBindingNavigator.TabIndex = 0
        Me.SalesBindingNavigator.Text = "BindingNavigator1"
        Me.SalesBindingNavigator.Visible = False
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'SalesBindingSource
        '
        Me.SalesBindingSource.DataMember = "Sales"
        Me.SalesBindingSource.DataSource = Me.ANDOKSDataSet
        '
        'ANDOKSDataSet
        '
        Me.ANDOKSDataSet.DataSetName = "ANDOKSDataSet"
        Me.ANDOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 26)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 29)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 26)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 29)
        '
        'SalesBindingNavigatorSaveItem
        '
        Me.SalesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesBindingNavigatorSaveItem.Image = CType(resources.GetObject("SalesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.SalesBindingNavigatorSaveItem.Name = "SalesBindingNavigatorSaveItem"
        Me.SalesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 26)
        Me.SalesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'btnHOMESUPERVISOR
        '
        Me.btnHOMESUPERVISOR.BackgroundImage = CType(resources.GetObject("btnHOMESUPERVISOR.BackgroundImage"), System.Drawing.Image)
        Me.btnHOMESUPERVISOR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnHOMESUPERVISOR.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHOMESUPERVISOR.Location = New System.Drawing.Point(1186, 42)
        Me.btnHOMESUPERVISOR.Name = "btnHOMESUPERVISOR"
        Me.btnHOMESUPERVISOR.Size = New System.Drawing.Size(142, 39)
        Me.btnHOMESUPERVISOR.TabIndex = 2
        Me.btnHOMESUPERVISOR.UseVisualStyleBackColor = True
        '
        'SALES_NO
        '
        Me.SALES_NO.AutoSize = True
        Me.SALES_NO.BackColor = System.Drawing.Color.Transparent
        Me.SALES_NO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SALES_NO.ForeColor = System.Drawing.Color.White
        Me.SALES_NO.Location = New System.Drawing.Point(655, 444)
        Me.SALES_NO.Name = "SALES_NO"
        Me.SALES_NO.Size = New System.Drawing.Size(0, 19)
        Me.SALES_NO.TabIndex = 5
        '
        'SalesItemDataGridView
        '
        Me.SalesItemDataGridView.AllowUserToAddRows = False
        Me.SalesItemDataGridView.AllowUserToDeleteRows = False
        Me.SalesItemDataGridView.AllowUserToResizeColumns = False
        Me.SalesItemDataGridView.AllowUserToResizeRows = False
        Me.SalesItemDataGridView.AutoGenerateColumns = False
        Me.SalesItemDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.SalesItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SalesItemIDDataGridViewTextBoxColumn, Me.SalesIDDataGridViewTextBoxColumn, Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.SalesItemDataGridView.DataSource = Me.SalesItemBindingSource
        Me.SalesItemDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SalesItemDataGridView.GridColor = System.Drawing.Color.Black
        Me.SalesItemDataGridView.Location = New System.Drawing.Point(347, 469)
        Me.SalesItemDataGridView.Name = "SalesItemDataGridView"
        Me.SalesItemDataGridView.Size = New System.Drawing.Size(642, 254)
        Me.SalesItemDataGridView.TabIndex = 6
        '
        'SalesItemIDDataGridViewTextBoxColumn
        '
        Me.SalesItemIDDataGridViewTextBoxColumn.DataPropertyName = "SalesItem_ID"
        Me.SalesItemIDDataGridViewTextBoxColumn.HeaderText = "SalesItem_ID"
        Me.SalesItemIDDataGridViewTextBoxColumn.Name = "SalesItemIDDataGridViewTextBoxColumn"
        '
        'SalesIDDataGridViewTextBoxColumn
        '
        Me.SalesIDDataGridViewTextBoxColumn.DataPropertyName = "Sales_ID"
        Me.SalesIDDataGridViewTextBoxColumn.HeaderText = "Sales_ID"
        Me.SalesIDDataGridViewTextBoxColumn.Name = "SalesIDDataGridViewTextBoxColumn"
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'SalesItemBindingSource
        '
        Me.SalesItemBindingSource.DataMember = "SalesItem"
        Me.SalesItemBindingSource.DataSource = Me.ANDOKSDataSet
        '
        'SalesDataGridView
        '
        Me.SalesDataGridView.AllowUserToAddRows = False
        Me.SalesDataGridView.AllowUserToDeleteRows = False
        Me.SalesDataGridView.AllowUserToResizeColumns = False
        Me.SalesDataGridView.AllowUserToResizeRows = False
        Me.SalesDataGridView.AutoGenerateColumns = False
        Me.SalesDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.SalesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SalesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.SalesDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalesDataGridView.DataSource = Me.SalesBindingSource
        Me.SalesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.SalesDataGridView.GridColor = System.Drawing.Color.Black
        Me.SalesDataGridView.Location = New System.Drawing.Point(403, 184)
        Me.SalesDataGridView.Name = "SalesDataGridView"
        Me.SalesDataGridView.Size = New System.Drawing.Size(539, 254)
        Me.SalesDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Sales_ID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Sales_ID"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "EmployeeID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "EmployeeID"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Total_Cost"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Total_Cost"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Date_Sold"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date_Sold"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(522, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "SALES ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(732, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "TOTAL SALE: "
        '
        'total_sale_display
        '
        Me.total_sale_display.AutoSize = True
        Me.total_sale_display.BackColor = System.Drawing.Color.Transparent
        Me.total_sale_display.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_sale_display.ForeColor = System.Drawing.Color.White
        Me.total_sale_display.Location = New System.Drawing.Point(844, 145)
        Me.total_sale_display.Name = "total_sale_display"
        Me.total_sale_display.Size = New System.Drawing.Size(0, 19)
        Me.total_sale_display.TabIndex = 8
        '
        'searchDate
        '
        Me.searchDate.AutoCompleteCustomSource.AddRange(New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.searchDate.BackColor = System.Drawing.Color.Black
        Me.searchDate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchDate.ForeColor = System.Drawing.Color.White
        Me.searchDate.FormatString = "M"
        Me.searchDate.FormattingEnabled = True
        Me.searchDate.Location = New System.Drawing.Point(450, 140)
        Me.searchDate.MaxDropDownItems = 100
        Me.searchDate.Name = "searchDate"
        Me.searchDate.Size = New System.Drawing.Size(117, 23)
        Me.searchDate.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(399, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Daily:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(567, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 19)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Monthly:"
        '
        'searchMonthly
        '
        Me.searchMonthly.AutoCompleteCustomSource.AddRange(New String() {"January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.searchMonthly.BackColor = System.Drawing.Color.Black
        Me.searchMonthly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.searchMonthly.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.searchMonthly.ForeColor = System.Drawing.Color.White
        Me.searchMonthly.FormatString = "M"
        Me.searchMonthly.FormattingEnabled = True
        Me.searchMonthly.Location = New System.Drawing.Point(635, 141)
        Me.searchMonthly.MaxDropDownItems = 100
        Me.searchMonthly.Name = "searchMonthly"
        Me.searchMonthly.Size = New System.Drawing.Size(92, 23)
        Me.searchMonthly.TabIndex = 13
        '
        'SalesTableAdapter
        '
        Me.SalesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.EmployeeTableAdapter = Nothing
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SalesItemTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ANDOKSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PaymentBindingSource
        '
        Me.PaymentBindingSource.DataMember = "Payment"
        Me.PaymentBindingSource.DataSource = Me.ANDOKSDataSet
        '
        'PaymentTableAdapter
        '
        Me.PaymentTableAdapter.ClearBeforeFill = True
        '
        'SalesItemTableAdapter
        '
        Me.SalesItemTableAdapter.ClearBeforeFill = True
        '
        'VIEWSALESFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.searchMonthly)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.searchDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.total_sale_display)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SalesDataGridView)
        Me.Controls.Add(Me.SalesItemDataGridView)
        Me.Controls.Add(Me.SALES_NO)
        Me.Controls.Add(Me.btnHOMESUPERVISOR)
        Me.Controls.Add(Me.SalesBindingNavigator)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "VIEWSALESFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VIEWSALES"
        CType(Me.SalesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SalesBindingNavigator.ResumeLayout(False)
        Me.SalesBindingNavigator.PerformLayout()
        CType(Me.SalesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaymentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ANDOKSDataSet As ANDOKSDataSet
    Friend WithEvents SalesBindingSource As BindingSource
    Friend WithEvents SalesTableAdapter As ANDOKSDataSetTableAdapters.SalesTableAdapter
    Friend WithEvents TableAdapterManager As ANDOKSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SalesBindingNavigator As BindingNavigator
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
    Friend WithEvents SalesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents SalesItemBindingSource As BindingSource
    Friend WithEvents PaymentBindingSource As BindingSource
    Friend WithEvents PaymentTableAdapter As ANDOKSDataSetTableAdapters.PaymentTableAdapter
    Friend WithEvents btnHOMESUPERVISOR As Button
    Friend WithEvents SALES_NO As Label

    Friend WithEvents SalesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents SalesItemDataGridView As DataGridView
    Friend WithEvents SalesItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalesItemTableAdapter As ANDOKSDataSetTableAdapters.SalesItemTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents total_sale_display As Label
    Friend WithEvents searchDate As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents searchMonthly As ComboBox
End Class
