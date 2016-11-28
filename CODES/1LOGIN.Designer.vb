<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LOGINFORM
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LOGINFORM))
        Me.USERNAME = New System.Windows.Forms.TextBox()
        Me.PASSWORD = New System.Windows.Forms.TextBox()
        Me.EmployeeTableAdapter1 = New WindowsApplication1.ANDOKSDataSetTableAdapters.EmployeeTableAdapter()
        Me.AndoksDataSet1 = New WindowsApplication1.ANDOKSDataSet()
        Me.CLOSEBTN = New System.Windows.Forms.Button()
        Me.LOGIN = New System.Windows.Forms.Button()
        CType(Me.AndoksDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'USERNAME
        '
        Me.USERNAME.BackColor = System.Drawing.Color.Black
        Me.USERNAME.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.USERNAME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.USERNAME.ForeColor = System.Drawing.Color.White
        Me.USERNAME.Location = New System.Drawing.Point(912, 552)
        Me.USERNAME.Name = "USERNAME"
        Me.USERNAME.Size = New System.Drawing.Size(272, 26)
        Me.USERNAME.TabIndex = 2
        Me.USERNAME.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PASSWORD
        '
        Me.PASSWORD.BackColor = System.Drawing.Color.Black
        Me.PASSWORD.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PASSWORD.ForeColor = System.Drawing.Color.White
        Me.PASSWORD.Location = New System.Drawing.Point(912, 602)
        Me.PASSWORD.Margin = New System.Windows.Forms.Padding(0)
        Me.PASSWORD.Name = "PASSWORD"
        Me.PASSWORD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PASSWORD.Size = New System.Drawing.Size(272, 26)
        Me.PASSWORD.TabIndex = 3
        Me.PASSWORD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EmployeeTableAdapter1
        '
        Me.EmployeeTableAdapter1.ClearBeforeFill = True
        '
        'AndoksDataSet1
        '
        Me.AndoksDataSet1.CaseSensitive = True
        Me.AndoksDataSet1.DataSetName = "ANDOKSDataSet"
        Me.AndoksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CLOSEBTN
        '
        Me.CLOSEBTN.BackColor = System.Drawing.Color.Transparent
        Me.CLOSEBTN.BackgroundImage = CType(resources.GetObject("CLOSEBTN.BackgroundImage"), System.Drawing.Image)
        Me.CLOSEBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CLOSEBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CLOSEBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CLOSEBTN.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.CLOSEBTN.FlatAppearance.BorderSize = 0
        Me.CLOSEBTN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CLOSEBTN.ForeColor = System.Drawing.Color.Black
        Me.CLOSEBTN.Location = New System.Drawing.Point(1054, 667)
        Me.CLOSEBTN.Name = "CLOSEBTN"
        Me.CLOSEBTN.Size = New System.Drawing.Size(137, 39)
        Me.CLOSEBTN.TabIndex = 5
        Me.CLOSEBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.CLOSEBTN.UseVisualStyleBackColor = False
        '
        'LOGIN
        '
        Me.LOGIN.BackColor = System.Drawing.Color.Transparent
        Me.LOGIN.BackgroundImage = CType(resources.GetObject("LOGIN.BackgroundImage"), System.Drawing.Image)
        Me.LOGIN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.LOGIN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LOGIN.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window
        Me.LOGIN.FlatAppearance.BorderSize = 0
        Me.LOGIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.LOGIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.LOGIN.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LOGIN.ForeColor = System.Drawing.Color.Black
        Me.LOGIN.Location = New System.Drawing.Point(904, 667)
        Me.LOGIN.Name = "LOGIN"
        Me.LOGIN.Size = New System.Drawing.Size(133, 39)
        Me.LOGIN.TabIndex = 4
        Me.LOGIN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.LOGIN.UseVisualStyleBackColor = False
        '
        'LOGINFORM
        '
        Me.AcceptButton = Me.LOGIN
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1362, 764)
        Me.ControlBox = False
        Me.Controls.Add(Me.CLOSEBTN)
        Me.Controls.Add(Me.LOGIN)
        Me.Controls.Add(Me.PASSWORD)
        Me.Controls.Add(Me.USERNAME)
        Me.Font = New System.Drawing.Font("Modern No. 20", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "LOGINFORM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.AndoksDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents USERNAME As TextBox
    Friend WithEvents PASSWORD As TextBox
    Friend WithEvents LOGIN As Button
    Friend WithEvents CLOSEBTN As Button
    Friend WithEvents EmployeeTableAdapter1 As ANDOKSDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents AndoksDataSet1 As ANDOKSDataSet
End Class
