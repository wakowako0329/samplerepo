Option Explicit On
Imports System.Data.OleDb


Public Class EMPLOYEEINFORMATION
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As New OleDb.OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Dim dt As DataTable
    Dim strAdmin As String = "Admin"
    Dim strEmployee As String = "Employee"
    Public ranks As String



    Private Sub EMPLOYEEINFORMATION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ANDOKSDataSet.Employee' table. You can move, or remove it, as needed.
        EmployeeDataGridView.Columns(5).Visible = False
        EmployeeDataGridView.Columns(6).Visible = False

        EmployeeDataGridView.Update()
        EmployeeDataGridView.Refresh()
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString


    End Sub

    Private Sub HOME_Click(sender As Object, e As EventArgs) Handles HOME.Click
        Me.Hide()
        SUPERVISORACCESS.Show()

    End Sub

    Public Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles rEMPLOYEE.CheckedChanged
        ranks = "Employee"
    End Sub

    Public Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rSUPERVISOR.CheckedChanged
        ranks = "Supervisor"
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles SAVEDATA.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        'ACCOUNT PERMISSION QUERY'
        Dim cmdPassword As OleDbCommand = New OleDbCommand("SELECT [Password] FROM Employee WHERE Username = @Username AND [Password] = @Password")
        With cmdPassword
            .Parameters.AddWithValue("@Username", Username.Text)
            .Parameters.AddWithValue("@Password", Password.Text)
        End With
        'UPDATE THE ACCOUNT'    
        Dim cmdUpdate As OleDbCommand = New OleDbCommand("UPDATE [Employee] SET EmployeeID = @EmployeeID, Firstname = @Firstname,Lastname = @Lastname, Gender = @Gender,Username = @Username, [Password] = @Password,Ranks = @Ranks,Status = @Status WHERE EmployeeID = @EmployeeID", myConnectiontoEmployeeInfo)
        With cmdUpdate
            .Parameters.AddWithValue("@EmployeeID", EmployeeID.Text)
            .Parameters.AddWithValue("@Firstname", Firstname.Text)
            .Parameters.AddWithValue("@Lastname", Lastname.Text)
            .Parameters.AddWithValue("@Gender", Gender.Text)
            .Parameters.AddWithValue("@Username", Username.Text)
            .Parameters.AddWithValue("@Password", Password.Text)
            .Parameters.AddWithValue("@Ranks", ranks)
            .Parameters.AddWithValue("@Status", cboSTATUS.Text)
        End With

        Dim rank As String = ""

        Dim adminAccounts As OleDbCommand = New OleDbCommand("SELECT Ranks FROM Employee WHERE Username = @Username And Password = @Password", myConnectiontoEmployeeInfo)
        With adminAccounts
            .Parameters.AddWithValue("@Username", Username.Text)
            .Parameters.AddWithValue("@Password", Password.Text)
        End With

        Dim rankreader As OleDbDataReader = adminAccounts.ExecuteReader()
        While rankreader.Read
            rank = rankreader(0)
        End While
        If rank = "Supervisor" Then
            If EmployeeID.Text = "" Or Firstname.Text = "" Or Lastname.Text = "" Or Gender.Text = "" Or Username.Text = "" Or Password.Text = "" Or RanksTextBox.Text = "" Then
                MsgBox("All text box should be filled up!", vbOKOnly, "PROCEED")
            Else
                If MsgBox("This is a supervisor account. Are you sure you want to update the selected data?", MsgBoxStyle.OkCancel, "UPDATE") = MsgBoxResult.Ok Then
                    Try
                        cmdUpdate.ExecuteNonQuery()
                        MsgBox("DATA UPDATED!")
                        refreshdata()
                        cleardata()
                    Catch ex As Exception
                        MessageBox.Show("Error occured while updating the data!")
                    End Try
                    EmployeeDataGridView.ClearSelection()
                End If
            End If
        ElseIf rank = "Employee" Then
            If EmployeeID.Text = "" Or Firstname.Text = "" Or Lastname.Text = "" Or Gender.Text = "" Or Username.Text = "" Or Password.Text = "" Or RanksTextBox.Text = "" Then
                MessageBox.Show("All text box should be filled up!")
            Else
                If MsgBox("This is an employee account. Are you sure you want to update the selected data?", MsgBoxStyle.OkCancel, "UPDATE") = MsgBoxResult.Ok Then
                    Try
                        cmdUpdate.ExecuteNonQuery()
                        MsgBox("DATA UPDATED!")
                        refreshdata()
                        cleardata()
                    Catch ex As Exception
                        MessageBox.Show("Error occured while updating the data!")
                    End Try
                    EmployeeDataGridView.ClearSelection()
                End If
            End If
        End If
        EmployeeTableAdapter.Fill(ANDOKSDataSet.Employee)
        myConnectiontoEmployeeInfo.Close()

    End Sub

    Sub cleardata()
        EmployeeID.Clear()
        Firstname.Clear()
        Lastname.Clear()
        Gender.SelectedIndex = -1
        txtGender.Clear()
        Username.Clear()
        Password.Clear()
        cboSTATUS.SelectedIndex = -1
        rEMPLOYEE.Checked = False
        rSUPERVISOR.Checked = False
        RanksTextBox.Clear()
        Firstname.Focus()

    End Sub

    Private Sub searchGender_TextChanged(sender As Object, e As EventArgs) Handles searchGender.TextChanged
        Me.EmployeeTableAdapter.SearchbyGender(Me.ANDOKSDataSet.Employee, Me.SearchFname.Text, Me.SearchLname.Text, Me.searchGender.Text, Me.SearchUsername.Text)
    End Sub

    Private Sub SearchFname_TextChanged(sender As Object, e As EventArgs) Handles SearchFname.TextChanged
        Me.EmployeeTableAdapter.SeachbyFirstname(Me.ANDOKSDataSet.Employee, Me.SearchFname.Text, Me.SearchLname.Text, Me.searchGender.Text, Me.SearchUsername.Text)
    End Sub

    Private Sub SearchLname_TextChanged(sender As Object, e As EventArgs) Handles SearchLname.TextChanged
        Me.EmployeeTableAdapter.SearchbyLastname(Me.ANDOKSDataSet.Employee, Me.SearchFname.Text, Me.SearchLname.Text, Me.searchGender.Text, Me.SearchUsername.Text)
    End Sub

    Private Sub SearchUsername_TextChanged(sender As Object, e As EventArgs) Handles SearchUsername.TextChanged
        Me.EmployeeTableAdapter.SearchbyUsername(Me.ANDOKSDataSet.Employee, Me.SearchFname.Text, Me.SearchLname.Text, Me.searchGender.Text, Me.SearchUsername.Text)
    End Sub

    Private Sub EmployeeDataGridView_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDataGridView.CellMouseClick
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim rank As String = ""
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        Dim cmd2 As OleDbCommand = New OleDbCommand("SELECT Ranks FROM Employee WHERE Username = @Username and Password = @Password", myConnectiontoEmployeeInfo)

        With cmd2
            .Parameters.AddWithValue("@Username", Username.Text)
            .Parameters.AddWithValue("@Password", Password.Text)
        End With
        Dim cmd2reader As OleDbDataReader = cmd2.ExecuteReader()
        While cmd2reader.Read
            rank = cmd2reader(0)
        End While
        If rank = "Supervisor" Then
            Me.RanksTextBox.Text = "Supervisor"
            rSUPERVISOR.Checked = True


        ElseIf rank = "Employee" Then
            Me.RanksTextBox.Text = "Employee"
            rEMPLOYEE.Checked = True
        End If
        myConnectiontoEmployeeInfo.Close()
    End Sub

    Private Sub EmployeeDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles EmployeeDataGridView.CellClick
        Dim i As Integer
        i = EmployeeDataGridView.CurrentRow.Index

        EmployeeID.Text = EmployeeDataGridView.Item(0, i).Value
        Firstname.Text = EmployeeDataGridView.Item(1, i).Value
        Lastname.Text = EmployeeDataGridView.Item(2, i).Value
        txtGender.Text = EmployeeDataGridView.Item(3, i).Value
        Gender.Text = EmployeeDataGridView.Item(3, i).Value
        Username.Text = EmployeeDataGridView.Item(4, i).Value
        Password.Text = EmployeeDataGridView.Item(5, i).Value
        RanksTextBox.Text = EmployeeDataGridView.Item(6, i).Value
        cboSTATUS.Text = EmployeeDataGridView.Item(7, i).Value
    End Sub

    Sub refreshdata()
        Me.EmployeeDataGridView.DataSource = Nothing 'clear out the datasource for the Grid view
        Me.EmployeeTableAdapter.Fill(Me.ANDOKSDataSet.Employee) ' refill the table adapter from the dataset table
        Me.EmployeeDataGridView.DataSource = Me.EmployeeBindingSource  'reset the datasource from the binding source
        Me.EmployeeDataGridView.Refresh() 'should redraw with the new data

    End Sub

    Private Sub Username_TextChanged(sender As Object, e As EventArgs) Handles Username.TextChanged

    End Sub




    'CODE FOR SEARCH BAR

    'Private Sub SearchFname_GotFocus(sender As Object, e As EventArgs) Handles SearchFname.GotFocus
    '    If SearchFname.Text = "Firstname" Then
    '        SearchFname.ForeColor = Color.Black
    '        SearchFname.Text = ""

    '    End If
    'End Sub

    'Private Sub SearchFname_LostFocus(sender As Object, e As EventArgs) Handles SearchFname.LostFocus
    '    If SearchFname.Text = Nothing Then
    '        SearchFname.ForeColor = Color.Gray
    '        SearchFname.Text = "Firstname"

    '    End If
    'End Sub


    '    Private Sub Searchlname_GotFocus(sender As Object, e As EventArgs) Handles SearchLname.GotFocus
    '        If SearchFname.Text = "Lastname" Then
    '            SearchFname.ForeColor = Color.Black
    '            SearchFname.Text = ""

    '        End If
    '    End Sub

    '    Private Sub SearchLname_LostFocus(sender As Object, e As EventArgs) Handles SearchLname.LostFocus
    '        If SearchFname.Text = Nothing Then
    '            SearchFname.ForeColor = Color.Gray
    '            SearchFname.Text = "Lastname"
    '        End If
    '    End Sub


    '    Private Sub SearchGender_GotFocus(sender As Object, e As EventArgs) Handles searchGender.GotFocus
    '        If SearchFname.Text = "Gender" Then
    '            SearchFname.ForeColor = Color.Black
    '            SearchFname.Text = ""
    '        End If
    '    End Sub
    '    Private Sub SearchGender_LostFocus(sender As Object, e As EventArgs) Handles searchGender.LostFocus
    '        If SearchFname.Text = Nothing Then
    '            SearchFname.ForeColor = Color.Gray
    '            SearchFname.Text = "Gender"
    '        End If
    '    End Sub

    '    Private Sub searchUsername_GotFocus(sender As Object, e As EventArgs) Handles SearchUsername.GotFocus
    '        If SearchFname.Text = "Username" Then
    '            SearchFname.ForeColor = Color.Black
    '            SearchFname.Text = ""
    '        End If
    '    End Sub
    '    Private Sub searchUsername_LostFocus(sender As Object, e As EventArgs) Handles SearchUsername.LostFocus
    '        If SearchFname.Text = Nothing Then
    '            SearchFname.ForeColor = Color.Gray
    '            SearchFname.Text = "Username"
    '        End If
    '    End Sub
End Class