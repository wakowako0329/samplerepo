Imports System.Data
Imports System.Data.OleDb


Public Class ADDEMPLOYEE

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As New OleDb.OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Dim dr As OleDbDataReader
    Dim rank As String
    Dim user As String
    Dim pass As String
    Dim status As String = "ACTIVE"

    Private Sub ADDEMPLOYEE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ANDOKSDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.ANDOKSDataSet.Employee)
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        cleardata()
    End Sub
    Private Sub HOME_Click(sender As Object, e As EventArgs) Handles HOME.Click
        Me.Hide()
        SUPERVISORACCESS.Show()

    End Sub


    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        cleardata()
    End Sub

    Private Sub AddEmplo_Click(sender As Object, e As EventArgs) Handles AddEmplo.Click


        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim cmdUserExist As OleDbCommand = New OleDbCommand("SELECT Username FROM Employee WHERE Username = @Username AND [Password] = @Password", myConnectiontoEmployeeInfo)
        With cmdUserExist
            .Parameters.AddWithValue("@Username", Username.Text)
            .Parameters.AddWithValue("@Password", Password.Text)
        End With
        Dim readerUserExist As OleDbDataReader = cmdUserExist.ExecuteReader()
        While readerUserExist.Read
            user = readerUserExist(0)
        End While


        Dim cmdPassExist As OleDbCommand = New OleDbCommand("SELECT [Password] FROM Employee WHERE Username = @Username and [Password] = @Password", myConnectiontoEmployeeInfo)
        With cmdPassExist
            .Parameters.AddWithValue("@Username", Username.Text)
            .Parameters.AddWithValue("@Password", Password.Text)
        End With
        Dim readerPassExist As OleDbDataReader = cmdPassExist.ExecuteReader()
        While readerPassExist.Read
            pass = readerPassExist(0)
        End While



        If EmployeeID.Text = "" Or Firstname.Text = "" Or Lastname.Text = "" Or Gender.Text = "" Or Username.Text = "" Or Password.Text = "" Or rankAdmin.Checked = False And rankEmployee.Checked = False Then
            MessageBox.Show("All text box should be filled up!")
        Else
            If Username.Text = Password.Text Then
                MessageBox.Show("Username and Password should not be the same!")
            ElseIf user = Username.Text Then
                MessageBox.Show("Username already existing! Please pick another username.")
            ElseIf pass = Password.Text Then
                MessageBox.Show("Password already existing! Please pick another password.")
            ElseIf Username.Text <> Password.Text Then
                Try
                    Dim cmd As OleDbCommand = New OleDbCommand("INSERT INTO [Employee](EmployeeID, Firstname, Lastname, Gender, Username, [Password],Ranks,Status)" &
                                  "VALUES(@EmployeeID,@Firstname,@Lastname,@Gender,@Username,@Password,@Ranks,@Status)", myConnectiontoEmployeeInfo)
                    With cmd
                        .Parameters.AddWithValue("@EmployeeID", EmployeeID.Text)
                        .Parameters.AddWithValue("@Firstname", Firstname.Text)
                        .Parameters.AddWithValue("@Lastname", Lastname.Text)
                        .Parameters.AddWithValue("@Gender", Gender.Text)
                        .Parameters.AddWithValue("@Username", Username.Text)
                        .Parameters.AddWithValue("@Password", Password.Text)
                        .Parameters.AddWithValue("@Ranks", rank)
                        .Parameters.AddWithValue("@Status", status)
                    End With
                    cmd.ExecuteNonQuery()
                    MessageBox.Show("DATA SAVED!")
                    Firstname.Focus()
                    EMPLOYEEINFORMATION.EmployeeDataGridView.Update()
                    EMPLOYEEINFORMATION.EmployeeDataGridView.Refresh()
                    cleardata()
                Catch ex As Exception
                    MessageBox.Show("The username or password is already existing.")
                End Try
            End If
        End If
        myConnectiontoEmployeeInfo.Close()
    End Sub


    Sub cleardata()
        getNo()
        Firstname.Text = ""
        Lastname.Text = ""
        Gender.SelectedIndex = -1
        Username.Text = ""
        Password.Text = ""
        rankAdmin.Checked = False
        rankEmployee.Checked = False

    End Sub
    Sub getNo()
        Dim dt As New DataTable
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim da As New OleDb.OleDbDataAdapter("Select EmployeeID" &
                                               " FROM Employee" &
                                            " ORDER BY EmployeeID DESC", myConnectiontoEmployeeInfo)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Me.EmployeeID.Text = dt.Rows(0).Item(0) + 1
        Else
            Me.EmployeeID.Text = 10001
        End If
        myConnectiontoEmployeeInfo.Close()
    End Sub



    Private Sub rankEmployee_CheckedChanged(sender As Object, e As EventArgs) Handles rankEmployee.CheckedChanged
        rank = "Employee"
    End Sub

    Private Sub rankAdmin_CheckedChanged(sender As Object, e As EventArgs) Handles rankAdmin.CheckedChanged
        rank = "Supervisor"
    End Sub

End Class
