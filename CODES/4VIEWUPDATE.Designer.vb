<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMPLOYEEINFORMATION
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EMPLOYEEINFORMATION))
        Me.SAVEDATA = New System.Windows.Forms.Button()
        Me.HOME = New System.Windows.Forms.Button()
        Me.EmployeeDataGridView = New System.Windows.Forms.DataGridView()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RanksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ANDOKSDataSet = New WindowsApplication1.ANDOKSDataSet()
        Me.EmployeeID = New System.Windows.Forms.TextBox()
        Me.Firstname = New System.Windows.Forms.TextBox()
        Me.Lastname = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Username = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.RanksTextBox = New System.Windows.Forms.TextBox()
        Me.SearchFname = New System.Windows.Forms.TextBox()
        Me.SearchLname = New System.Windows.Forms.TextBox()
        Me.SearchUsername = New System.Windows.Forms.TextBox()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.EmployeeTableAdapter = New WindowsApplication1.ANDOKSDataSetTableAdapters.EmployeeTableAdapter()
        Me.TableAdapterManager = New WindowsApplication1.ANDOKSDataSetTableAdapters.TableAdapterManager()
        Me.searchGender = New System.Windows.Forms.TextBox()
        Me.cboSTATUS = New System.Windows.Forms.ComboBox()
        Me.rSUPERVISOR = New System.Windows.Forms.RadioButton()
        Me.rEMPLOYEE = New System.Windows.Forms.RadioButton()
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SAVEDATA
        '
        Me.SAVEDATA.BackgroundImage = CType(resources.GetObject("SAVEDATA.BackgroundImage"), System.Drawing.Image)
        Me.SAVEDATA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.SAVEDATA.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SAVEDATA.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SAVEDATA.Location = New System.Drawing.Point(904, 672)
        Me.SAVEDATA.Name = "SAVEDATA"
        Me.SAVEDATA.Size = New System.Drawing.Size(143, 41)
        Me.SAVEDATA.TabIndex = 2
        Me.SAVEDATA.UseVisualStyleBackColor = True
        '
        'HOME
        '
        Me.HOME.BackgroundImage = CType(resources.GetObject("HOME.BackgroundImage"), System.Drawing.Image)
        Me.HOME.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.HOME.Cursor = System.Windows.Forms.Cursors.Hand
        Me.HOME.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HOME.ForeColor = System.Drawing.Color.Black
        Me.HOME.Location = New System.Drawing.Point(1190, 12)
        Me.HOME.Name = "HOME"
        Me.HOME.Size = New System.Drawing.Size(153, 44)
        Me.HOME.TabIndex = 4
        Me.HOME.UseVisualStyleBackColor = True
        '
        'EmployeeDataGridView
        '
        Me.EmployeeDataGridView.AllowDrop = True
        Me.EmployeeDataGridView.AllowUserToAddRows = False
        Me.EmployeeDataGridView.AutoGenerateColumns = False
        Me.EmployeeDataGridView.BackgroundColor = System.Drawing.Color.Black
        Me.EmployeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmployeeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmployeeIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.RanksDataGridViewTextBoxColumn, Me.Status})
        Me.EmployeeDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource
        Me.EmployeeDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.EmployeeDataGridView.GridColor = System.Drawing.Color.Black
        Me.EmployeeDataGridView.Location = New System.Drawing.Point(431, 335)
        Me.EmployeeDataGridView.Name = "EmployeeDataGridView"
        Me.EmployeeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmployeeDataGridView.ShowEditingIcon = False
        Me.EmployeeDataGridView.Size = New System.Drawing.Size(542, 207)
        Me.EmployeeDataGridView.TabIndex = 16
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        Me.EmployeeIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RanksDataGridViewTextBoxColumn
        '
        Me.RanksDataGridViewTextBoxColumn.DataPropertyName = "Ranks"
        Me.RanksDataGridViewTextBoxColumn.HeaderText = "Ranks"
        Me.RanksDataGridViewTextBoxColumn.Name = "RanksDataGridViewTextBoxColumn"
        Me.RanksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "Status"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.ANDOKSDataSet
        Me.EmployeeBindingSource.Filter = ""
        '
        'ANDOKSDataSet
        '
        Me.ANDOKSDataSet.DataSetName = "ANDOKSDataSet"
        Me.ANDOKSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeeID
        '
        Me.EmployeeID.BackColor = System.Drawing.Color.Black
        Me.EmployeeID.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmployeeID.ForeColor = System.Drawing.Color.White
        Me.EmployeeID.Location = New System.Drawing.Point(497, 578)
        Me.EmployeeID.Name = "EmployeeID"
        Me.EmployeeID.Size = New System.Drawing.Size(132, 29)
        Me.EmployeeID.TabIndex = 35
        '
        'Firstname
        '
        Me.Firstname.BackColor = System.Drawing.Color.Black
        Me.Firstname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Firstname.ForeColor = System.Drawing.Color.White
        Me.Firstname.Location = New System.Drawing.Point(497, 623)
        Me.Firstname.Name = "Firstname"
        Me.Firstname.Size = New System.Drawing.Size(132, 29)
        Me.Firstname.TabIndex = 37
        '
        'Lastname
        '
        Me.Lastname.BackColor = System.Drawing.Color.Black
        Me.Lastname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lastname.ForeColor = System.Drawing.Color.White
        Me.Lastname.Location = New System.Drawing.Point(497, 658)
        Me.Lastname.Name = "Lastname"
        Me.Lastname.Size = New System.Drawing.Size(132, 29)
        Me.Lastname.TabIndex = 39
        '
        'Gender
        '
        Me.Gender.BackColor = System.Drawing.Color.Black
        Me.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Gender.Enabled = False
        Me.Gender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Gender.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.Gender.ForeColor = System.Drawing.Color.White
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female"})
        Me.Gender.Location = New System.Drawing.Point(736, 578)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(132, 29)
        Me.Gender.TabIndex = 41
        '
        'Username
        '
        Me.Username.BackColor = System.Drawing.Color.Black
        Me.Username.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Username.ForeColor = System.Drawing.Color.White
        Me.Username.Location = New System.Drawing.Point(736, 620)
        Me.Username.Name = "Username"
        Me.Username.Size = New System.Drawing.Size(132, 29)
        Me.Username.TabIndex = 43
        '
        'Password
        '
        Me.Password.BackColor = System.Drawing.Color.Black
        Me.Password.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.ForeColor = System.Drawing.Color.White
        Me.Password.Location = New System.Drawing.Point(736, 655)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(132, 29)
        Me.Password.TabIndex = 45
        '
        'RanksTextBox
        '
        Me.RanksTextBox.BackColor = System.Drawing.Color.Black
        Me.RanksTextBox.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RanksTextBox.ForeColor = System.Drawing.Color.White
        Me.RanksTextBox.Location = New System.Drawing.Point(944, 578)
        Me.RanksTextBox.Name = "RanksTextBox"
        Me.RanksTextBox.Size = New System.Drawing.Size(132, 29)
        Me.RanksTextBox.TabIndex = 48
        '
        'SearchFname
        '
        Me.SearchFname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchFname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchFname.BackColor = System.Drawing.Color.Black
        Me.SearchFname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchFname.ForeColor = System.Drawing.Color.White
        Me.SearchFname.Location = New System.Drawing.Point(498, 164)
        Me.SearchFname.Name = "SearchFname"
        Me.SearchFname.Size = New System.Drawing.Size(272, 29)
        Me.SearchFname.TabIndex = 50
        Me.SearchFname.Text = "Firstname"
        '
        'SearchLname
        '
        Me.SearchLname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchLname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchLname.BackColor = System.Drawing.Color.Black
        Me.SearchLname.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLname.ForeColor = System.Drawing.Color.White
        Me.SearchLname.Location = New System.Drawing.Point(498, 204)
        Me.SearchLname.Name = "SearchLname"
        Me.SearchLname.Size = New System.Drawing.Size(272, 29)
        Me.SearchLname.TabIndex = 52
        Me.SearchLname.Text = "Lastname"
        '
        'SearchUsername
        '
        Me.SearchUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.SearchUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.SearchUsername.BackColor = System.Drawing.Color.Black
        Me.SearchUsername.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchUsername.ForeColor = System.Drawing.Color.White
        Me.SearchUsername.Location = New System.Drawing.Point(498, 286)
        Me.SearchUsername.Name = "SearchUsername"
        Me.SearchUsername.Size = New System.Drawing.Size(272, 29)
        Me.SearchUsername.TabIndex = 54
        Me.SearchUsername.Text = "Username"
        '
        'txtGender
        '
        Me.txtGender.BackColor = System.Drawing.Color.Black
        Me.txtGender.Enabled = False
        Me.txtGender.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.ForeColor = System.Drawing.Color.White
        Me.txtGender.Location = New System.Drawing.Point(736, 578)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(132, 29)
        Me.txtGender.TabIndex = 57
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.PaymentTableAdapter = Nothing
        Me.TableAdapterManager.ProductTableAdapter = Nothing
        Me.TableAdapterManager.SalesItemTableAdapter = Nothing
        Me.TableAdapterManager.SalesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApplication1.ANDOKSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'searchGender
        '
        Me.searchGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.searchGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.searchGender.BackColor = System.Drawing.Color.Black
        Me.searchGender.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchGender.ForeColor = System.Drawing.Color.White
        Me.searchGender.Location = New System.Drawing.Point(497, 244)
        Me.searchGender.Name = "searchGender"
        Me.searchGender.Size = New System.Drawing.Size(272, 29)
        Me.searchGender.TabIndex = 58
        Me.searchGender.Text = "Gender"
        '
        'cboSTATUS
        '
        Me.cboSTATUS.BackColor = System.Drawing.Color.Black
        Me.cboSTATUS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSTATUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboSTATUS.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSTATUS.ForeColor = System.Drawing.Color.White
        Me.cboSTATUS.FormattingEnabled = True
        Me.cboSTATUS.Items.AddRange(New Object() {"ACTIVE", "INACTIVE"})
        Me.cboSTATUS.Location = New System.Drawing.Point(944, 618)
        Me.cboSTATUS.Name = "cboSTATUS"
        Me.cboSTATUS.Size = New System.Drawing.Size(132, 29)
        Me.cboSTATUS.TabIndex = 59
        '
        'rSUPERVISOR
        '
        Me.rSUPERVISOR.AutoSize = True
        Me.rSUPERVISOR.BackColor = System.Drawing.Color.Transparent
        Me.rSUPERVISOR.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rSUPERVISOR.ForeColor = System.Drawing.Color.White
        Me.rSUPERVISOR.Location = New System.Drawing.Point(944, 574)
        Me.rSUPERVISOR.Name = "rSUPERVISOR"
        Me.rSUPERVISOR.Size = New System.Drawing.Size(109, 25)
        Me.rSUPERVISOR.TabIndex = 61
        Me.rSUPERVISOR.TabStop = True
        Me.rSUPERVISOR.Text = "Supervisor"
        Me.rSUPERVISOR.UseVisualStyleBackColor = False
        '
        'rEMPLOYEE
        '
        Me.rEMPLOYEE.AutoSize = True
        Me.rEMPLOYEE.BackColor = System.Drawing.Color.Transparent
        Me.rEMPLOYEE.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rEMPLOYEE.ForeColor = System.Drawing.Color.White
        Me.rEMPLOYEE.Location = New System.Drawing.Point(945, 592)
        Me.rEMPLOYEE.Name = "rEMPLOYEE"
        Me.rEMPLOYEE.Size = New System.Drawing.Size(102, 25)
        Me.rEMPLOYEE.TabIndex = 62
        Me.rEMPLOYEE.TabStop = True
        Me.rEMPLOYEE.Text = "Employee"
        Me.rEMPLOYEE.UseVisualStyleBackColor = False
        '
        'EMPLOYEEINFORMATION
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.ControlBox = False
        Me.Controls.Add(Me.rEMPLOYEE)
        Me.Controls.Add(Me.rSUPERVISOR)
        Me.Controls.Add(Me.cboSTATUS)
        Me.Controls.Add(Me.searchGender)
        Me.Controls.Add(Me.txtGender)
        Me.Controls.Add(Me.RanksTextBox)
        Me.Controls.Add(Me.EmployeeID)
        Me.Controls.Add(Me.Firstname)
        Me.Controls.Add(Me.Lastname)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Username)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.HOME)
        Me.Controls.Add(Me.SAVEDATA)
        Me.Controls.Add(Me.SearchUsername)
        Me.Controls.Add(Me.SearchLname)
        Me.Controls.Add(Me.EmployeeDataGridView)
        Me.Controls.Add(Me.SearchFname)
        Me.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EMPLOYEEINFORMATION"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.EmployeeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ANDOKSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SAVEDATA As Button
    Friend WithEvents HOME As Button
    Friend WithEvents ANDOKSDataSet As ANDOKSDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As ANDOKSDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents TableAdapterManager As ANDOKSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeeDataGridView As DataGridView
    Friend WithEvents EmployeeID As TextBox
    Friend WithEvents Firstname As TextBox
    Friend WithEvents Lastname As TextBox
    Friend WithEvents Gender As ComboBox
    Friend WithEvents Username As TextBox
    Friend WithEvents Password As TextBox
    Friend WithEvents RanksTextBox As TextBox
    Friend WithEvents SearchFname As TextBox
    Friend WithEvents SearchLname As TextBox
    Friend WithEvents SearchUsername As TextBox
    Friend WithEvents txtGender As TextBox
    Friend WithEvents searchGender As TextBox
    Friend WithEvents cboSTATUS As ComboBox
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RanksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents rSUPERVISOR As RadioButton
    Friend WithEvents rEMPLOYEE As RadioButton
End Class
