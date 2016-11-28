<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAYMENTFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAYMENTFORM))
        Me.payment = New System.Windows.Forms.TextBox()
        Me.BTNPAYMENT = New System.Windows.Forms.Button()
        Me.total_amount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'payment
        '
        Me.payment.BackColor = System.Drawing.Color.Black
        Me.payment.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.payment.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.payment.ForeColor = System.Drawing.Color.White
        Me.payment.Location = New System.Drawing.Point(623, 570)
        Me.payment.Name = "payment"
        Me.payment.Size = New System.Drawing.Size(267, 25)
        Me.payment.TabIndex = 1
        '
        'BTNPAYMENT
        '
        Me.BTNPAYMENT.BackColor = System.Drawing.Color.Transparent
        Me.BTNPAYMENT.BackgroundImage = CType(resources.GetObject("BTNPAYMENT.BackgroundImage"), System.Drawing.Image)
        Me.BTNPAYMENT.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.BTNPAYMENT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPAYMENT.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPAYMENT.Location = New System.Drawing.Point(619, 643)
        Me.BTNPAYMENT.Name = "BTNPAYMENT"
        Me.BTNPAYMENT.Size = New System.Drawing.Size(154, 46)
        Me.BTNPAYMENT.TabIndex = 2
        Me.BTNPAYMENT.UseVisualStyleBackColor = False
        '
        'total_amount
        '
        Me.total_amount.BackColor = System.Drawing.Color.Black
        Me.total_amount.Enabled = False
        Me.total_amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_amount.ForeColor = System.Drawing.Color.White
        Me.total_amount.Location = New System.Drawing.Point(602, 482)
        Me.total_amount.Name = "total_amount"
        Me.total_amount.ReadOnly = True
        Me.total_amount.Size = New System.Drawing.Size(284, 31)
        Me.total_amount.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(591, 567)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "₱"
        '
        'PAYMENTFORM
        '
        Me.AcceptButton = Me.BTNPAYMENT
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.total_amount)
        Me.Controls.Add(Me.BTNPAYMENT)
        Me.Controls.Add(Me.payment)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PAYMENTFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents payment As TextBox
    Friend WithEvents BTNPAYMENT As Button
    Friend WithEvents total_amount As TextBox
    Friend WithEvents Label1 As Label
End Class
