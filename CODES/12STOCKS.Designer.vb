<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class STOCKSFORM
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
        Me.stocksGridView = New System.Windows.Forms.DataGridView()
        Me.ProductIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StocksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANDOKSDataSet = New WindowsApplication1.ANDOKSDataSet()
        Me.ProductSalesItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductSalesItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.ProductTableAdapter()
        Me.SalesItemTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.SalesItemTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtStocks = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.stocksGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSalesItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductSalesItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'stocksGridView
        '
        Me.stocksGridView.AllowUserToAddRows = False
        Me.stocksGridView.AllowUserToDeleteRows = False
        Me.stocksGridView.AutoGenerateColumns = False
        Me.stocksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.stocksGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ProductIDDataGridViewTextBoxColumn, Me.ProductNameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.StocksDataGridViewTextBoxColumn})
        Me.stocksGridView.DataSource = Me.ProductBindingSource
        Me.stocksGridView.Location = New System.Drawing.Point(26, 38)
        Me.stocksGridView.Name = "stocksGridView"
        Me.stocksGridView.ReadOnly = True
        Me.stocksGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.stocksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.stocksGridView.Size = New System.Drawing.Size(564, 150)
        Me.stocksGridView.TabIndex = 0
        '
        'ProductIDDataGridViewTextBoxColumn
        '
        Me.ProductIDDataGridViewTextBoxColumn.DataPropertyName = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.HeaderText = "Product_ID"
        Me.ProductIDDataGridViewTextBoxColumn.Name = "ProductIDDataGridViewTextBoxColumn"
        Me.ProductIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductNameDataGridViewTextBoxColumn
        '
        Me.ProductNameDataGridViewTextBoxColumn.DataPropertyName = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.HeaderText = "Product_Name"
        Me.ProductNameDataGridViewTextBoxColumn.Name = "ProductNameDataGridViewTextBoxColumn"
        Me.ProductNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProductNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ProductNameDataGridViewTextBoxColumn.Width = 200
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.PriceDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PriceDataGridViewTextBoxColumn.Width = 120
        '
        'StocksDataGridViewTextBoxColumn
        '
        Me.StocksDataGridViewTextBoxColumn.DataPropertyName = "Stocks"
        Me.StocksDataGridViewTextBoxColumn.HeaderText = "Stocks"
        Me.StocksDataGridViewTextBoxColumn.Name = "StocksDataGridViewTextBoxColumn"
        Me.StocksDataGridViewTextBoxColumn.ReadOnly = True
        Me.StocksDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'ProductBindingSource
        '
        Me.ProductBindingSource.DataMember = "Product"
        Me.ProductBindingSource.DataSource = Me.ANDOKSDataSet
        '
        'ANDOKSDataSet
        '
        Me.ANDOKSDataSet.DataSetName = "ANDOKSDataSet"
        Me.ANDOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductSalesItemBindingSource
        '
        Me.ProductSalesItemBindingSource.DataMember = "ProductSalesItem"
        Me.ProductSalesItemBindingSource.DataSource = Me.ProductBindingSource
        '
        'ProductSalesItemBindingSource1
        '
        Me.ProductSalesItemBindingSource1.DataMember = "ProductSalesItem"
        Me.ProductSalesItemBindingSource1.DataSource = Me.ProductBindingSource
        '
        'ProductTableAdapter
        '
        Me.ProductTableAdapter.ClearBeforeFill = True
        '
        'SalesItemTableAdapter
        '
        Me.SalesItemTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Name:"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(133, 201)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(106, 20)
        Me.txtProductName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(245, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Price:"
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(294, 201)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(106, 20)
        Me.txtPrice.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(416, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Stocks:"
        '
        'txtStocks
        '
        Me.txtStocks.Location = New System.Drawing.Point(478, 201)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(106, 20)
        Me.txtStocks.TabIndex = 8
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(263, 241)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(-1, -1)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'STOCKSFORM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 275)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.stocksGridView)
        Me.Name = "STOCKSFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.stocksGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSalesItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductSalesItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents stocksGridView As DataGridView
    Friend WithEvents ANDOKSDataSet As ANDOKSDataSet
    Friend WithEvents ProductBindingSource As BindingSource
    Friend WithEvents ProductTableAdapter As ANDOKSDataSetTableAdapters.ProductTableAdapter
    Friend WithEvents ProductSalesItemBindingSource As BindingSource
    Friend WithEvents SalesItemTableAdapter As ANDOKSDataSetTableAdapters.SalesItemTableAdapter
    Friend WithEvents ProductSalesItemBindingSource1 As BindingSource
    Friend WithEvents ProductIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProductNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StocksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtStocks As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
