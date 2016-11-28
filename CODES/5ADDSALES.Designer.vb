<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADD_SALES
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADD_SALES))
        Me.menu1 = New System.Windows.Forms.Button()
        Me.menu2 = New System.Windows.Forms.Button()
        Me.menu3 = New System.Windows.Forms.Button()
        Me.menu6 = New System.Windows.Forms.Button()
        Me.menu5 = New System.Windows.Forms.Button()
        Me.menu4 = New System.Windows.Forms.Button()
        Me.menu8 = New System.Windows.Forms.Button()
        Me.menu7 = New System.Windows.Forms.Button()
        Me.BTNHOME = New System.Windows.Forms.Button()
        Me.totalAmount = New System.Windows.Forms.Label()
        Me.sales_no = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DATEANDTIME = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNNEWSALES = New System.Windows.Forms.Button()
        Me.BTNFINALIZE = New System.Windows.Forms.Button()
        Me.BTNCANCEL = New System.Windows.Forms.Button()
        Me.btnVOID = New System.Windows.Forms.Button()
        Me.SalesItemTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.SalesItemTableAdapter()
        Me.AndoksDataSet = New WindowsApplication1.ANDOKSDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chickenimage = New System.Windows.Forms.PictureBox()
        Me.chkSeniorCitizen = New System.Windows.Forms.CheckBox()
        Me.ORDER_LIST = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.AndoksDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chickenimage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menu1
        '
        Me.menu1.BackColor = System.Drawing.Color.Transparent
        Me.menu1.BackgroundImage = CType(resources.GetObject("menu1.BackgroundImage"), System.Drawing.Image)
        Me.menu1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu1.Location = New System.Drawing.Point(265, 307)
        Me.menu1.Margin = New System.Windows.Forms.Padding(4)
        Me.menu1.Name = "menu1"
        Me.menu1.Size = New System.Drawing.Size(108, 82)
        Me.menu1.TabIndex = 0
        Me.menu1.UseVisualStyleBackColor = False
        Me.menu1.Visible = False
        '
        'menu2
        '
        Me.menu2.BackColor = System.Drawing.Color.Transparent
        Me.menu2.BackgroundImage = CType(resources.GetObject("menu2.BackgroundImage"), System.Drawing.Image)
        Me.menu2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu2.Location = New System.Drawing.Point(388, 307)
        Me.menu2.Margin = New System.Windows.Forms.Padding(4)
        Me.menu2.Name = "menu2"
        Me.menu2.Size = New System.Drawing.Size(111, 82)
        Me.menu2.TabIndex = 1
        Me.menu2.UseVisualStyleBackColor = False
        Me.menu2.Visible = False
        '
        'menu3
        '
        Me.menu3.BackColor = System.Drawing.Color.Transparent
        Me.menu3.BackgroundImage = CType(resources.GetObject("menu3.BackgroundImage"), System.Drawing.Image)
        Me.menu3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu3.Location = New System.Drawing.Point(265, 413)
        Me.menu3.Margin = New System.Windows.Forms.Padding(4)
        Me.menu3.Name = "menu3"
        Me.menu3.Size = New System.Drawing.Size(108, 82)
        Me.menu3.TabIndex = 2
        Me.menu3.UseVisualStyleBackColor = False
        Me.menu3.Visible = False
        '
        'menu6
        '
        Me.menu6.BackColor = System.Drawing.Color.Transparent
        Me.menu6.BackgroundImage = CType(resources.GetObject("menu6.BackgroundImage"), System.Drawing.Image)
        Me.menu6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu6.Location = New System.Drawing.Point(388, 528)
        Me.menu6.Margin = New System.Windows.Forms.Padding(4)
        Me.menu6.Name = "menu6"
        Me.menu6.Size = New System.Drawing.Size(111, 83)
        Me.menu6.TabIndex = 5
        Me.menu6.UseVisualStyleBackColor = False
        Me.menu6.Visible = False
        '
        'menu5
        '
        Me.menu5.BackColor = System.Drawing.Color.Transparent
        Me.menu5.BackgroundImage = CType(resources.GetObject("menu5.BackgroundImage"), System.Drawing.Image)
        Me.menu5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu5.Location = New System.Drawing.Point(265, 528)
        Me.menu5.Margin = New System.Windows.Forms.Padding(4)
        Me.menu5.Name = "menu5"
        Me.menu5.Size = New System.Drawing.Size(108, 83)
        Me.menu5.TabIndex = 4
        Me.menu5.UseVisualStyleBackColor = False
        Me.menu5.Visible = False
        '
        'menu4
        '
        Me.menu4.BackColor = System.Drawing.Color.Transparent
        Me.menu4.BackgroundImage = CType(resources.GetObject("menu4.BackgroundImage"), System.Drawing.Image)
        Me.menu4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu4.Location = New System.Drawing.Point(388, 412)
        Me.menu4.Margin = New System.Windows.Forms.Padding(4)
        Me.menu4.Name = "menu4"
        Me.menu4.Size = New System.Drawing.Size(111, 83)
        Me.menu4.TabIndex = 3
        Me.menu4.UseVisualStyleBackColor = False
        Me.menu4.Visible = False
        '
        'menu8
        '
        Me.menu8.BackColor = System.Drawing.Color.Transparent
        Me.menu8.BackgroundImage = CType(resources.GetObject("menu8.BackgroundImage"), System.Drawing.Image)
        Me.menu8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu8.Location = New System.Drawing.Point(388, 619)
        Me.menu8.Margin = New System.Windows.Forms.Padding(4)
        Me.menu8.Name = "menu8"
        Me.menu8.Size = New System.Drawing.Size(111, 82)
        Me.menu8.TabIndex = 8
        Me.menu8.UseVisualStyleBackColor = False
        Me.menu8.Visible = False
        '
        'menu7
        '
        Me.menu7.BackColor = System.Drawing.Color.Transparent
        Me.menu7.BackgroundImage = CType(resources.GetObject("menu7.BackgroundImage"), System.Drawing.Image)
        Me.menu7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.menu7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.menu7.Location = New System.Drawing.Point(265, 619)
        Me.menu7.Margin = New System.Windows.Forms.Padding(4)
        Me.menu7.Name = "menu7"
        Me.menu7.Size = New System.Drawing.Size(108, 82)
        Me.menu7.TabIndex = 7
        Me.menu7.UseVisualStyleBackColor = False
        Me.menu7.Visible = False
        '
        'BTNHOME
        '
        Me.BTNHOME.BackColor = System.Drawing.Color.Transparent
        Me.BTNHOME.BackgroundImage = CType(resources.GetObject("BTNHOME.BackgroundImage"), System.Drawing.Image)
        Me.BTNHOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNHOME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNHOME.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNHOME.Location = New System.Drawing.Point(1218, 39)
        Me.BTNHOME.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNHOME.Name = "BTNHOME"
        Me.BTNHOME.Size = New System.Drawing.Size(135, 36)
        Me.BTNHOME.TabIndex = 11
        Me.BTNHOME.UseVisualStyleBackColor = False
        '
        'totalAmount
        '
        Me.totalAmount.AutoSize = True
        Me.totalAmount.BackColor = System.Drawing.Color.Transparent
        Me.totalAmount.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmount.ForeColor = System.Drawing.Color.White
        Me.totalAmount.Location = New System.Drawing.Point(895, 681)
        Me.totalAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(0, 22)
        Me.totalAmount.TabIndex = 13
        '
        'sales_no
        '
        Me.sales_no.AutoSize = True
        Me.sales_no.BackColor = System.Drawing.Color.Transparent
        Me.sales_no.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sales_no.ForeColor = System.Drawing.Color.White
        Me.sales_no.Location = New System.Drawing.Point(918, 302)
        Me.sales_no.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.sales_no.Name = "sales_no"
        Me.sales_no.Size = New System.Drawing.Size(0, 21)
        Me.sales_no.TabIndex = 17
        '
        'Timer1
        '
        '
        'DATEANDTIME
        '
        Me.DATEANDTIME.AutoSize = True
        Me.DATEANDTIME.BackColor = System.Drawing.Color.Transparent
        Me.DATEANDTIME.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DATEANDTIME.ForeColor = System.Drawing.Color.White
        Me.DATEANDTIME.Location = New System.Drawing.Point(1040, 299)
        Me.DATEANDTIME.Name = "DATEANDTIME"
        Me.DATEANDTIME.Size = New System.Drawing.Size(0, 21)
        Me.DATEANDTIME.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(976, 299)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 22)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Date: "
        '
        'BTNNEWSALES
        '
        Me.BTNNEWSALES.BackColor = System.Drawing.Color.Transparent
        Me.BTNNEWSALES.BackgroundImage = CType(resources.GetObject("BTNNEWSALES.BackgroundImage"), System.Drawing.Image)
        Me.BTNNEWSALES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNNEWSALES.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNNEWSALES.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNNEWSALES.Location = New System.Drawing.Point(785, 169)
        Me.BTNNEWSALES.Name = "BTNNEWSALES"
        Me.BTNNEWSALES.Size = New System.Drawing.Size(145, 35)
        Me.BTNNEWSALES.TabIndex = 21
        Me.BTNNEWSALES.UseVisualStyleBackColor = False
        '
        'BTNFINALIZE
        '
        Me.BTNFINALIZE.BackColor = System.Drawing.Color.Transparent
        Me.BTNFINALIZE.BackgroundImage = CType(resources.GetObject("BTNFINALIZE.BackgroundImage"), System.Drawing.Image)
        Me.BTNFINALIZE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNFINALIZE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNFINALIZE.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFINALIZE.Location = New System.Drawing.Point(946, 169)
        Me.BTNFINALIZE.Name = "BTNFINALIZE"
        Me.BTNFINALIZE.Size = New System.Drawing.Size(145, 35)
        Me.BTNFINALIZE.TabIndex = 22
        Me.BTNFINALIZE.UseVisualStyleBackColor = False
        '
        'BTNCANCEL
        '
        Me.BTNCANCEL.BackColor = System.Drawing.Color.Transparent
        Me.BTNCANCEL.BackgroundImage = CType(resources.GetObject("BTNCANCEL.BackgroundImage"), System.Drawing.Image)
        Me.BTNCANCEL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNCANCEL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCANCEL.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCANCEL.Location = New System.Drawing.Point(1107, 168)
        Me.BTNCANCEL.Name = "BTNCANCEL"
        Me.BTNCANCEL.Size = New System.Drawing.Size(139, 35)
        Me.BTNCANCEL.TabIndex = 23
        Me.BTNCANCEL.UseVisualStyleBackColor = False
        '
        'btnVOID
        '
        Me.btnVOID.BackgroundImage = CType(resources.GetObject("btnVOID.BackgroundImage"), System.Drawing.Image)
        Me.btnVOID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnVOID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVOID.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVOID.Location = New System.Drawing.Point(785, 231)
        Me.btnVOID.Name = "btnVOID"
        Me.btnVOID.Size = New System.Drawing.Size(146, 41)
        Me.btnVOID.TabIndex = 24
        Me.btnVOID.UseVisualStyleBackColor = True
        '
        'SalesItemTableAdapter
        '
        Me.SalesItemTableAdapter.ClearBeforeFill = True
        '
        'AndoksDataSet
        '
        Me.AndoksDataSet.DataSetName = "ANDOKSDataSet"
        Me.AndoksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(831, 303)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Sales ID: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(826, 681)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 22)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Total: "
        '
        'chickenimage
        '
        Me.chickenimage.BackColor = System.Drawing.Color.Transparent
        Me.chickenimage.BackgroundImage = CType(resources.GetObject("chickenimage.BackgroundImage"), System.Drawing.Image)
        Me.chickenimage.ErrorImage = CType(resources.GetObject("chickenimage.ErrorImage"), System.Drawing.Image)
        Me.chickenimage.Location = New System.Drawing.Point(109, 289)
        Me.chickenimage.Name = "chickenimage"
        Me.chickenimage.Size = New System.Drawing.Size(551, 433)
        Me.chickenimage.TabIndex = 28
        Me.chickenimage.TabStop = False
        '
        'chkSeniorCitizen
        '
        Me.chkSeniorCitizen.AutoSize = True
        Me.chkSeniorCitizen.BackColor = System.Drawing.Color.Transparent
        Me.chkSeniorCitizen.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSeniorCitizen.ForeColor = System.Drawing.Color.White
        Me.chkSeniorCitizen.Location = New System.Drawing.Point(990, 239)
        Me.chkSeniorCitizen.Name = "chkSeniorCitizen"
        Me.chkSeniorCitizen.Size = New System.Drawing.Size(154, 26)
        Me.chkSeniorCitizen.TabIndex = 29
        Me.chkSeniorCitizen.Text = "Senior Citizen?"
        Me.chkSeniorCitizen.UseVisualStyleBackColor = False
        '
        'ORDER_LIST
        '
        Me.ORDER_LIST.AutoArrange = False
        Me.ORDER_LIST.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ORDER_LIST.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ORDER_LIST.FullRowSelect = True
        Me.ORDER_LIST.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.ORDER_LIST.Location = New System.Drawing.Point(828, 329)
        Me.ORDER_LIST.Name = "ORDER_LIST"
        Me.ORDER_LIST.Scrollable = False
        Me.ORDER_LIST.Size = New System.Drawing.Size(386, 349)
        Me.ORDER_LIST.TabIndex = 30
        Me.ORDER_LIST.UseCompatibleStateImageBehavior = False
        Me.ORDER_LIST.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Product ID"
        Me.ColumnHeader1.Width = 102
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Product Name"
        Me.ColumnHeader2.Width = 134
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty"
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Price"
        Me.ColumnHeader4.Width = 86
        '
        'ADD_SALES
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.ORDER_LIST)
        Me.Controls.Add(Me.chkSeniorCitizen)
        Me.Controls.Add(Me.chickenimage)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVOID)
        Me.Controls.Add(Me.BTNCANCEL)
        Me.Controls.Add(Me.BTNFINALIZE)
        Me.Controls.Add(Me.BTNNEWSALES)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DATEANDTIME)
        Me.Controls.Add(Me.sales_no)
        Me.Controls.Add(Me.totalAmount)
        Me.Controls.Add(Me.BTNHOME)
        Me.Controls.Add(Me.menu8)
        Me.Controls.Add(Me.menu7)
        Me.Controls.Add(Me.menu6)
        Me.Controls.Add(Me.menu5)
        Me.Controls.Add(Me.menu4)
        Me.Controls.Add(Me.menu3)
        Me.Controls.Add(Me.menu2)
        Me.Controls.Add(Me.menu1)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ADD_SALES"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NEW ORDER"
        CType(Me.AndoksDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chickenimage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menu1 As Button
    Friend WithEvents menu2 As Button
    Friend WithEvents menu3 As Button
    Friend WithEvents menu6 As Button
    Friend WithEvents menu5 As Button
    Friend WithEvents menu4 As Button
    Friend WithEvents menu8 As Button
    Friend WithEvents menu7 As Button
    Friend WithEvents BTNHOME As Button
    Friend WithEvents totalAmount As Label
    Friend WithEvents sales_no As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DATEANDTIME As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BTNNEWSALES As Button
    Friend WithEvents BTNFINALIZE As Button
    Friend WithEvents BTNCANCEL As Button
    Friend WithEvents btnVOID As Button
    Friend WithEvents SalesItemTableAdapter As ANDOKSDataSetTableAdapters.SalesItemTableAdapter
    Friend WithEvents AndoksDataSet As ANDOKSDataSet
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents chickenimage As PictureBox
    Friend WithEvents chkSeniorCitizen As CheckBox
    Friend WithEvents ORDER_LIST As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
