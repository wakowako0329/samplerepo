<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SUPERVISORACCESS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SUPERVISORACCESS))
        Me.VIEWSALE = New System.Windows.Forms.Button()
        Me.ADDEMP = New System.Windows.Forms.Button()
        Me.LOGOUT = New System.Windows.Forms.Button()
        Me.BTNUPDATE = New System.Windows.Forms.Button()
        Me.BTNVIEW = New System.Windows.Forms.Button()
        Me.DISPLAYNAME = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDateTime = New System.Windows.Forms.Label()
        Me.TAX_DISCOUNT = New System.Windows.Forms.Button()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VIEWSALE
        '
        Me.VIEWSALE.BackgroundImage = CType(resources.GetObject("VIEWSALE.BackgroundImage"), System.Drawing.Image)
        Me.VIEWSALE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.VIEWSALE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.VIEWSALE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VIEWSALE.Location = New System.Drawing.Point(576, 399)
        Me.VIEWSALE.Name = "VIEWSALE"
        Me.VIEWSALE.Size = New System.Drawing.Size(218, 33)
        Me.VIEWSALE.TabIndex = 0
        Me.VIEWSALE.UseVisualStyleBackColor = True
        '
        'ADDEMP
        '
        Me.ADDEMP.BackgroundImage = CType(resources.GetObject("ADDEMP.BackgroundImage"), System.Drawing.Image)
        Me.ADDEMP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ADDEMP.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ADDEMP.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ADDEMP.Location = New System.Drawing.Point(577, 456)
        Me.ADDEMP.Name = "ADDEMP"
        Me.ADDEMP.Size = New System.Drawing.Size(218, 33)
        Me.ADDEMP.TabIndex = 4
        Me.ADDEMP.UseVisualStyleBackColor = True
        '
        'LOGOUT
        '
        Me.LOGOUT.BackgroundImage = CType(resources.GetObject("LOGOUT.BackgroundImage"), System.Drawing.Image)
        Me.LOGOUT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LOGOUT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOGOUT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGOUT.Location = New System.Drawing.Point(1217, 31)
        Me.LOGOUT.Name = "LOGOUT"
        Me.LOGOUT.Size = New System.Drawing.Size(131, 41)
        Me.LOGOUT.TabIndex = 7
        Me.LOGOUT.UseVisualStyleBackColor = True
        '
        'BTNUPDATE
        '
        Me.BTNUPDATE.BackgroundImage = CType(resources.GetObject("BTNUPDATE.BackgroundImage"), System.Drawing.Image)
        Me.BTNUPDATE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNUPDATE.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNUPDATE.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNUPDATE.Location = New System.Drawing.Point(576, 511)
        Me.BTNUPDATE.Name = "BTNUPDATE"
        Me.BTNUPDATE.Size = New System.Drawing.Size(217, 30)
        Me.BTNUPDATE.TabIndex = 9
        Me.BTNUPDATE.UseVisualStyleBackColor = True
        '
        'BTNVIEW
        '
        Me.BTNVIEW.BackgroundImage = CType(resources.GetObject("BTNVIEW.BackgroundImage"), System.Drawing.Image)
        Me.BTNVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNVIEW.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNVIEW.Location = New System.Drawing.Point(577, 559)
        Me.BTNVIEW.Name = "BTNVIEW"
        Me.BTNVIEW.Size = New System.Drawing.Size(217, 30)
        Me.BTNVIEW.TabIndex = 10
        Me.BTNVIEW.UseVisualStyleBackColor = True
        '
        'DISPLAYNAME
        '
        Me.DISPLAYNAME.BackColor = System.Drawing.Color.Black
        Me.DISPLAYNAME.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DISPLAYNAME.Enabled = False
        Me.DISPLAYNAME.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISPLAYNAME.ForeColor = System.Drawing.Color.White
        Me.DISPLAYNAME.Location = New System.Drawing.Point(34, 38)
        Me.DISPLAYNAME.Name = "DISPLAYNAME"
        Me.DISPLAYNAME.Size = New System.Drawing.Size(225, 34)
        Me.DISPLAYNAME.TabIndex = 13
        Me.DISPLAYNAME.Visible = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.ForeColor = System.Drawing.Color.White
        Me.lblName.Location = New System.Drawing.Point(31, 38)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 26)
        Me.lblName.TabIndex = 14
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = True
        Me.lblDateTime.BackColor = System.Drawing.Color.Transparent
        Me.lblDateTime.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDateTime.ForeColor = System.Drawing.Color.White
        Me.lblDateTime.Location = New System.Drawing.Point(31, 81)
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(0, 26)
        Me.lblDateTime.TabIndex = 15
        Me.lblDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblDateTime.Visible = False
        '
        'TAX_DISCOUNT
        '
        Me.TAX_DISCOUNT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAX_DISCOUNT.Location = New System.Drawing.Point(576, 606)
        Me.TAX_DISCOUNT.Name = "TAX_DISCOUNT"
        Me.TAX_DISCOUNT.Size = New System.Drawing.Size(217, 23)
        Me.TAX_DISCOUNT.TabIndex = 16
        Me.TAX_DISCOUNT.Text = "Tax/Discount"
        Me.TAX_DISCOUNT.UseVisualStyleBackColor = True
        '
        'btnStocks
        '
        Me.btnStocks.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocks.Location = New System.Drawing.Point(576, 643)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(217, 23)
        Me.btnStocks.TabIndex = 17
        Me.btnStocks.Text = "Stocks"
        Me.btnStocks.UseVisualStyleBackColor = True
        '
        'SUPERVISORACCESS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnStocks)
        Me.Controls.Add(Me.TAX_DISCOUNT)
        Me.Controls.Add(Me.lblDateTime)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.DISPLAYNAME)
        Me.Controls.Add(Me.BTNVIEW)
        Me.Controls.Add(Me.BTNUPDATE)
        Me.Controls.Add(Me.LOGOUT)
        Me.Controls.Add(Me.ADDEMP)
        Me.Controls.Add(Me.VIEWSALE)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SUPERVISORACCESS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SUPERVISOR ACCESS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VIEWSALE As Button
    Friend WithEvents ADDEMP As Button
    Friend WithEvents LOGOUT As Button
    Friend WithEvents BTNUPDATE As Button
    Friend WithEvents BTNVIEW As Button
    Friend WithEvents DISPLAYNAME As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblDateTime As Label
    Friend WithEvents TAX_DISCOUNT As Button
    Friend WithEvents btnStocks As Button
End Class
