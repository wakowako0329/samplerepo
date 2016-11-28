Option Explicit On
Option Compare Text

Imports System.Data.OleDb

Public Class LOGINFORM
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Dim attempt As Integer
    Dim status As String

    Public Shared userID As Integer

    Private Sub LOGINFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        Me.Show()
        USERNAME.Focus()
        PASSWORD.Focus()
        LOGIN.Focus()
    End Sub


    Sub LOGIN_Click(sender As Object, e As EventArgs) Handles LOGIN.Click
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        Dim fname As String = ""
        Dim lname As String = ""
        Dim rank As String = ""
        Dim status As String = ""

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Try
            Dim getUserDetails As OleDbCommand = New OleDbCommand("SELECT * FROM Employee WHERE  Username = @Username and Password = @Password", myConnectiontoEmployeeInfo)
            With getUserDetails
                .Parameters.AddWithValue("@Username", USERNAME.Text)
                .Parameters.AddWithValue("@Password", PASSWORD.Text)
            End With
            Dim loginreader As OleDbDataReader = getUserDetails.ExecuteReader()

            If loginreader.Read = True Then
                If String.Equals(USERNAME.Text, loginreader("Username").ToString()) And String.Equals(PASSWORD.Text, loginreader("Password").ToString()) Then
                    fname = loginreader("Firstname")
                    lname = loginreader("Lastname")
                    status = loginreader("Status")
                    rank = loginreader("Ranks")
                    userID = loginreader("EmployeeID")

                    If status = "ACTIVE" Then
                        If rank = "Supervisor" Then
                            MsgBox("Supervisor Successfully logged in!")
                            Me.Hide()
                            With SUPERVISORACCESS
                                .Show()
                                .DISPLAYNAME.Text = "Hi " & fname & " " & lname & "!"
                                .lblName.Text = .DISPLAYNAME.Text
                                .lblDateTime.Text = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
                            End With
                        ElseIf rank = "Employee" Then
                            MsgBox("Employee Successfully logged in!")
                            Me.Hide()
                            With ADD_SALES
                                .Show()
                                .ORDER_LIST.Items.Clear()
                                .sales_no.Text = ""
                                .totalAmount.Text = ""
                                .BTNHOME.Enabled = True
                                .BTNNEWSALES.Enabled = True
                                .BTNFINALIZE.Enabled = False
                                .BTNCANCEL.Enabled = False
                                .menu1.Visible = False
                                .menu2.Visible = False
                                .menu3.Visible = False
                                .menu4.Visible = False
                                .menu5.Visible = False
                                .menu6.Visible = False
                                .menu7.Visible = False
                                .menu8.Visible = False
                                .btnVOID.Enabled = False
                                .chickenimage.Visible = True

                            End With
                        End If
                    ElseIf status = "INACTIVE" Then
                        MsgBox("THE ACCOUNT YOU'RE TRYING TO ACCESS IS CURRENTLY INACTIVE OR NOT AN EMPLOYEE ANYMORE.", MsgBoxStyle.Information, "LOGIN FAILED!")
                        Me.USERNAME.Text = ""
                        Me.PASSWORD.Text = ""
                        USERNAME.Focus()
                    End If
                Else
                    MsgBox("Username and Password incorrect, please enter a valid Username and Password!", MsgBoxStyle.Critical, "LOGIN FAILED")
                    Me.USERNAME.Text = ""
                    Me.PASSWORD.Text = ""
                    USERNAME.Focus()
                End If
            ElseIf USERNAME.Text = "" And PASSWORD.Text = "" Then
                MsgBox("Please enter a Username and a Password!", MsgBoxStyle.Critical, "LOGIN FAILED!")
                USERNAME.Focus()
            ElseIf USERNAME.Text = "" Then
                MsgBox("Please enter a Username!", MsgBoxStyle.Critical, "Fill up everything!")
                USERNAME.Focus()
            ElseIf PASSWORD.Text = "" Then
                MsgBox("Please enter a Password!", MsgBoxStyle.Critical, "Fill up everything!")
                PASSWORD.Focus()
            Else
                MsgBox("Username and Password incorrect, please enter a valid Username and Password!", MsgBoxStyle.Critical, "LOGIN FAILED")
                Me.USERNAME.Text = ""
                Me.PASSWORD.Text = ""
                USERNAME.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())
        Finally
            myConnectiontoEmployeeInfo.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CLOSEBTN.Click
        If MsgBox("Are you sure you want to close the program?", MsgBoxStyle.OkCancel, "Logout") = MsgBoxResult.Ok Then
            Application.Exit()
        End If
    End Sub


    Private Sub USERNAME_GotFocus(sender As Object, e As EventArgs) Handles USERNAME.GotFocus
        If USERNAME.Text = "Username" Then
            USERNAME.ForeColor = Color.White
            USERNAME.Text = ""
        End If
    End Sub

    Private Sub USERNAME_LostFocus(sender As Object, e As EventArgs) Handles USERNAME.LostFocus
        If USERNAME.Text = Nothing Then
            USERNAME.ForeColor = Color.Gray
            USERNAME.Text = "Username"
        End If
    End Sub


    Private Sub PASSWORD_GotFocus(sender As Object, e As EventArgs) Handles PASSWORD.GotFocus
        If PASSWORD.Text = "Password" Then
            PASSWORD.ForeColor = Color.White
            PASSWORD.Text = ""
        End If

    End Sub

    Private Sub PASSWORD_LostFocus(sender As Object, e As EventArgs) Handles PASSWORD.LostFocus
        If PASSWORD.Text = Nothing Then
            PASSWORD.ForeColor = Color.Gray
            PASSWORD.Text = "Password"
        End If
    End Sub

End Class
