<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ADDEMPLOYEE
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ADDEMPLOYEE))
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANDOKSDataSet = New WindowsApplication1.ANDOKSDataSet()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.HOME = New System.Windows.Forms.Button()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.AddEmplo = New System.Windows.Forms.Button()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Clear = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.EmployeeTableAdapter()
        Me.rankAdmin = New System.Windows.Forms.RadioButton()
        Me.rankEmployee = New System.Windows.Forms.RadioButton()
        Me.TableAdapterManager = New WindowsApplication1.ANDOKSDataSetTableAdapters.TableAdapterManager()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Firstname
        '
        Me.Firstname.BackColor = System.Drawing.Color.Black
        Me.Firstname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Firstname", True))
        Me.Firstname.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstname.ForeColor = System.Drawing.Color.White
        Me.Firstname.Location = New System.Drawing.Point(679, 278)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(273, 32)
        Me.Firstname.TabIndex = 8
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.ANDOKSDataSet
        '
        'ANDOKSDataSet
        '
        Me.ANDOKSDataSet.DataSetName = "ANDOKSDataSet"
        Me.ANDOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Lastname
        '
        Me.Lastname.BackColor = System.Drawing.Color.Black
        Me.Lastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Lastname", True))
        Me.Lastname.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastname.ForeColor = System.Drawing.Color.White
        Me.Lastname.Location = New System.Drawing.Point(679, 336)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(273, 32)
        Me.Lastname.TabIndex = 9
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.Black
        Me.Username.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Username", True))
        Me.Username.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(679, 452)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(273, 32)
        Me.Username.TabIndex = 10
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Black
        Me.Password.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Password", True))
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(679, 509)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(273, 32)
        Me.Password.TabIndex = 11
        '
        'HOME
        '
        Me.HOME.BackColor = System.Drawing.Color.Transparent
        Me.HOME.BackgroundImage = CType(resources.GetObject("HOME.BackgroundImage"), System.Drawing.Image)
        Me.HOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME.Location = New System.Drawing.Point(1198, 35)
        Me.HOME.Name = "HOME"
        Me.HOME.Size = New System.Drawing.Size(134, 36)
        Me.HOME.TabIndex = 17
        Me.HOME.UseVisualStyleBackColor = False
        '
        'EmployeeID
        '
        Me.EmployeeID.BackColor = System.Drawing.Color.Black
        Me.EmployeeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "EmployeeID", True))
        Me.EmployeeID.Enabled = False
        Me.EmployeeID.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.Color.White
        Me.EmployeeID.Location = New System.Drawing.Point(679, 219)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(273, 32)
        Me.EmployeeID.TabIndex = 20
        '
        'AddEmplo
        '
        Me.AddEmplo.BackColor = System.Drawing.Color.Transparent
        Me.AddEmplo.BackgroundImage = CType(resources.GetObject("AddEmplo.BackgroundImage"), System.Drawing.Image)
        Me.AddEmplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AddEmplo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AddEmplo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddEmplo.Location = New System.Drawing.Point(580, 636)
        Me.AddEmplo.Name = "AddEmplo"
        Me.AddEmplo.Size = New System.Drawing.Size(143, 41)
        Me.AddEmplo.TabIndex = 21
        Me.AddEmplo.UseVisualStyleBackColor = False
        '
        'Gender
        '
        Me.Gender.BackColor = System.Drawing.Color.Black
        Me.Gender.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeBindingSource, "Gender", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gender.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.White
        Me.Gender.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(679, 396)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(273, 31)
        Me.Gender.TabIndex = 23
        '
        'Clear
        '
        Me.Clear.BackgroundImage = CType(resources.GetObject("Clear.BackgroundImage"), System.Drawing.Image)
        Me.Clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Clear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.Location = New System.Drawing.Point(772, 636)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(137, 41)
        Me.Clear.TabIndex = 24
        Me.Clear.UseVisualStyleBackColor = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'rankAdmin
        '
        Me.rankAdmin.AutoSize = True
        Me.rankAdmin.BackColor = System.Drawing.Color.Transparent
        Me.rankAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rankAdmin.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rankAdmin.Location = New System.Drawing.Point(679, 579)
        Me.rankAdmin.Name = "rankAdmin"
        Me.rankAdmin.Size = New System.Drawing.Size(14, 13)
        Me.rankAdmin.TabIndex = 26
        Me.rankAdmin.TabStop = True
        Me.rankAdmin.UseVisualStyleBackColor = False
        '
        'rankEmployee
        '
        Me.rankEmployee.AutoSize = True
        Me.rankEmployee.BackColor = System.Drawing.Color.Transparent
        Me.rankEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rankEmployee.Font = New System.Drawing.Font("Times New Roman", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rankEmployee.Location = New System.Drawing.Point(879, 579)
        Me.rankEmployee.Name = "rankEmployee"
        Me.rankEmployee.Size = New System.Drawing.Size(14, 13)
        Me.rankEmployee.TabIndex = 27
        Me.rankEmployee.TabStop = True
        Me.rankEmployee.UseVisualStyleBackColor = False
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
        'ADDEMPLOYEE
        '
        Me.AcceptButton = Me.AddEmplo
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.rankEmployee)
        Me.Controls.Add(Me.rankAdmin)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.AddEmplo)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.HOME)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Firstname)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ADDEMPLOYEE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ADD ACCOUNT"
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Lastname As TextBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox

    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HOME As Button
    Friend WithEvents ANDOKSDataSet As ANDOKSDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As ANDOKSDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As ANDOKSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeID As TextBox
    Friend WithEvents AddEmplo As Button
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Clear As Button
    Friend WithEvents rankAdmin As RadioButton
    Friend WithEvents rankEmployee As RadioButton
End Class
