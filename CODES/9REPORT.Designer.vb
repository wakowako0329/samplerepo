<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formReport))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LIST_ITEM_ORDER = New System.Windows.Forms.ListView()
        Me.colProdName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProdQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colProdPrice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pnlContainer = New System.Windows.Forms.Panel()
        Me.panelTitle = New System.Windows.Forms.Panel()
        Me.lblSalesID = New System.Windows.Forms.Label()
        Me.lblDateSold = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelDetails = New System.Windows.Forms.Panel()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblChange = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblVat = New System.Windows.Forms.Label()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.lblSalesPerson = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.pnlContainer.SuspendLayout()
        Me.panelTitle.SuspendLayout()
        Me.panelDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(142, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pak! Manok!"
        '
        'LIST_ITEM_ORDER
        '
        Me.LIST_ITEM_ORDER.Alignment = System.Windows.Forms.ListViewAlignment.Left
        Me.LIST_ITEM_ORDER.AutoArrange = False
        Me.LIST_ITEM_ORDER.BackColor = System.Drawing.Color.White
        Me.LIST_ITEM_ORDER.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colProdName, Me.colProdQty, Me.colProdPrice})
        Me.LIST_ITEM_ORDER.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.LIST_ITEM_ORDER.Enabled = False
        Me.LIST_ITEM_ORDER.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LIST_ITEM_ORDER.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LIST_ITEM_ORDER.HideSelection = False
        Me.LIST_ITEM_ORDER.Location = New System.Drawing.Point(17, 153)
        Me.LIST_ITEM_ORDER.MultiSelect = False
        Me.LIST_ITEM_ORDER.Name = "LIST_ITEM_ORDER"
        Me.LIST_ITEM_ORDER.Size = New System.Drawing.Size(359, 50)
        Me.LIST_ITEM_ORDER.TabIndex = 1
        Me.LIST_ITEM_ORDER.UseCompatibleStateImageBehavior = False
        Me.LIST_ITEM_ORDER.View = System.Windows.Forms.View.Details
        '
        'colProdName
        '
        Me.colProdName.Text = "Product Name"
        Me.colProdName.Width = 170
        '
        'colProdQty
        '
        Me.colProdQty.Text = "Qty"
        Me.colProdQty.Width = 90
        '
        'colProdPrice
        '
        Me.colProdPrice.Text = "Price"
        Me.colProdPrice.Width = 85
        '
        'pnlContainer
        '
        Me.pnlContainer.Controls.Add(Me.panelTitle)
        Me.pnlContainer.Controls.Add(Me.panelDetails)
        Me.pnlContainer.Controls.Add(Me.LIST_ITEM_ORDER)
        Me.pnlContainer.Location = New System.Drawing.Point(-2, -1)
        Me.pnlContainer.Name = "pnlContainer"
        Me.pnlContainer.Size = New System.Drawing.Size(398, 473)
        Me.pnlContainer.TabIndex = 2
        '
        'panelTitle
        '
        Me.panelTitle.Controls.Add(Me.Label9)
        Me.panelTitle.Controls.Add(Me.lblSalesPerson)
        Me.panelTitle.Controls.Add(Me.lblSalesID)
        Me.panelTitle.Controls.Add(Me.lblDateSold)
        Me.panelTitle.Controls.Add(Me.Label6)
        Me.panelTitle.Controls.Add(Me.Label1)
        Me.panelTitle.Location = New System.Drawing.Point(0, 0)
        Me.panelTitle.Name = "panelTitle"
        Me.panelTitle.Size = New System.Drawing.Size(398, 143)
        Me.panelTitle.TabIndex = 7
        '
        'lblSalesID
        '
        Me.lblSalesID.AutoSize = True
        Me.lblSalesID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesID.Location = New System.Drawing.Point(78, 95)
        Me.lblSalesID.Name = "lblSalesID"
        Me.lblSalesID.Size = New System.Drawing.Size(38, 13)
        Me.lblSalesID.TabIndex = 3
        Me.lblSalesID.Text = "Label"
        '
        'lblDateSold
        '
        Me.lblDateSold.AutoSize = True
        Me.lblDateSold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateSold.Location = New System.Drawing.Point(18, 75)
        Me.lblDateSold.Name = "lblDateSold"
        Me.lblDateSold.Size = New System.Drawing.Size(38, 13)
        Me.lblDateSold.TabIndex = 2
        Me.lblDateSold.Text = "Label"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(184, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "21st Ave, Makati, Metro Manila"
        '
        'panelDetails
        '
        Me.panelDetails.Controls.Add(Me.lblSubTotal)
        Me.panelDetails.Controls.Add(Me.Label8)
        Me.panelDetails.Controls.Add(Me.btnPrint)
        Me.panelDetails.Controls.Add(Me.Label5)
        Me.panelDetails.Controls.Add(Me.lblChange)
        Me.panelDetails.Controls.Add(Me.Label7)
        Me.panelDetails.Controls.Add(Me.lblPayment)
        Me.panelDetails.Controls.Add(Me.Label4)
        Me.panelDetails.Controls.Add(Me.lblDiscount)
        Me.panelDetails.Controls.Add(Me.Label2)
        Me.panelDetails.Controls.Add(Me.Label3)
        Me.panelDetails.Controls.Add(Me.lblTotal)
        Me.panelDetails.Controls.Add(Me.lblVat)
        Me.panelDetails.Location = New System.Drawing.Point(17, 205)
        Me.panelDetails.Name = "panelDetails"
        Me.panelDetails.Size = New System.Drawing.Size(359, 229)
        Me.panelDetails.TabIndex = 6
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(137, 180)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(75, 23)
        Me.btnPrint.TabIndex = 7
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "CHANGE:"
        '
        'lblChange
        '
        Me.lblChange.AutoSize = True
        Me.lblChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChange.Location = New System.Drawing.Point(269, 60)
        Me.lblChange.Name = "lblChange"
        Me.lblChange.Size = New System.Drawing.Size(0, 15)
        Me.lblChange.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "CASH:"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayment.Location = New System.Drawing.Point(269, 36)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(0, 15)
        Me.lblPayment.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "DISCOUNT:"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(269, 128)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(0, 15)
        Me.lblDiscount.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "AMOUNT DUE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "VAT:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(269, 15)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(0, 15)
        Me.lblTotal.TabIndex = 2
        '
        'lblVat
        '
        Me.lblVat.AutoSize = True
        Me.lblVat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVat.Location = New System.Drawing.Point(269, 104)
        Me.lblVat.Name = "lblVat"
        Me.lblVat.Size = New System.Drawing.Size(0, 15)
        Me.lblVat.TabIndex = 4
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'lblSalesPerson
        '
        Me.lblSalesPerson.AutoSize = True
        Me.lblSalesPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSalesPerson.Location = New System.Drawing.Point(18, 117)
        Me.lblSalesPerson.Name = "lblSalesPerson"
        Me.lblSalesPerson.Size = New System.Drawing.Size(38, 13)
        Me.lblSalesPerson.TabIndex = 4
        Me.lblSalesPerson.Text = "Label"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 158)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "SUB-TOTAL:"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(269, 158)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(0, 15)
        Me.lblSubTotal.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(18, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "Sales ID:"
        '
        'formReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(395, 471)
        Me.ControlBox = False
        Me.Controls.Add(Me.pnlContainer)
        Me.Name = "formReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlContainer.ResumeLayout(False)
        Me.panelTitle.ResumeLayout(False)
        Me.panelTitle.PerformLayout()
        Me.panelDetails.ResumeLayout(False)
        Me.panelDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents pnlContainer As Panel
    Friend WithEvents colProdName As ColumnHeader
    Friend WithEvents colProdQty As ColumnHeader
    Friend WithEvents colProdPrice As ColumnHeader
    Friend WithEvents LIST_ITEM_ORDER As ListView
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVat As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents panelDetails As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblChange As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblPayment As Label
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents btnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents panelTitle As Panel
    Friend WithEvents lblDateSold As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblSalesID As Label
    Friend WithEvents lblSalesPerson As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents Label9 As Label
End Class
