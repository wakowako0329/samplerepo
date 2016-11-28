Imports System.Data.OleDb
Public Class SUPERVISORACCESS

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As New OleDb.OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile


    Private Sub SUPERVISORACCESS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
    End Sub

    Private Sub LOGOUT_Click(sender As Object, e As EventArgs) Handles LOGOUT.Click
        If MsgBox("Are you sure you want to logout your account?", MsgBoxStyle.OkCancel, "Logout") = MsgBoxResult.Ok Then
            Me.Hide()
            LOGINFORM.Show()
            LOGINFORM.USERNAME.Text = ""
            LOGINFORM.PASSWORD.Text = ""
            LOGINFORM.USERNAME.Focus()
            LOGINFORM.PASSWORD.Focus()
            LOGINFORM.LOGIN.Focus()
        End If
    End Sub


    Private Sub ADDEMP_Click(sender As Object, e As EventArgs) Handles ADDEMP.Click
        ADDEMPLOYEE.Show()
        Me.Hide()
        ADDEMPLOYEE.EmployeeTableAdapter.Fill(ADDEMPLOYEE.ANDOKSDataSet.Employee)
        ADDEMPLOYEE.cleardata()

    End Sub
    Private Sub BTNUPDATE_Click(sender As Object, e As EventArgs) Handles BTNUPDATE.Click

        Me.Hide()
        EMPLOYEEINFORMATION.Show()
        With EMPLOYEEINFORMATION
            .Show()
            .SAVEDATA.Visible = True
            .EmployeeID.Enabled = False
            .Firstname.Enabled = True
            .Lastname.Enabled = True
            .Gender.Enabled = True
            .Username.Enabled = False
            .Password.Enabled = False
            .RanksTextBox.Visible = False
            .cboSTATUS.Enabled = True
            .Gender.Visible = True
            .txtGender.Visible = False
            .rEMPLOYEE.Visible = True
            .rSUPERVISOR.Visible = True

            .SearchFname.Clear()
            .SearchLname.Clear()
            .searchGender.Clear()
            .SearchUsername.Clear()

            .SearchFname.Focus()
            .SearchLname.Focus()
            .searchGender.Focus()
            .SearchUsername.Focus()
            .SearchFname.Focus()

            .EmployeeDataGridView.ClearSelection()
            .cleardata()
            .EmployeeTableAdapter.Fill(.ANDOKSDataSet.Employee)

            .RanksTextBox.BackColor = Color.Black
            .EmployeeID.BackColor = Color.Black

        End With

    End Sub

    Private Sub BTNVIEW_Click(sender As Object, e As EventArgs) Handles BTNVIEW.Click
        Me.Hide()
        With EMPLOYEEINFORMATION
            .Show()
            .SAVEDATA.Visible = False
            .EmployeeID.Enabled = False
            .Firstname.Enabled = False
            .Lastname.Enabled = False
            .Gender.Enabled = False
            .Username.Enabled = False
            .Password.Enabled = False
            .RanksTextBox.Enabled = False
            .RanksTextBox.Visible = True
            .Gender.Visible = False
            .txtGender.Visible = True
            .cboSTATUS.Enabled = False
            .rSUPERVISOR.Visible = False
            .rEMPLOYEE.Visible = False

            .SearchFname.Clear()
            .SearchLname.Clear()
            .searchGender.Clear()
            .SearchUsername.Clear()

            .SearchFname.Focus()
            .SearchLname.Focus()
            .searchGender.Focus()
            .SearchUsername.Focus()
            .SearchFname.Focus()

            .EmployeeDataGridView.ClearSelection()
            .cleardata()
            .EmployeeTableAdapter.Fill(.ANDOKSDataSet.Employee)


            .EmployeeID.BackColor = Color.Black
            .Firstname.BackColor = Color.Black
            .Lastname.BackColor = Color.Black
            .txtGender.BackColor = Color.Black
            .Username.BackColor = Color.Black
            .Password.BackColor = Color.Black
            .RanksTextBox.BackColor = Color.Black

            .EmployeeID.ForeColor = Color.White
            .Firstname.ForeColor = Color.White
            .Lastname.ForeColor = Color.White
            .txtGender.ForeColor = Color.White
            .Username.ForeColor = Color.White
            .Password.ForeColor = Color.White
            .RanksTextBox.ForeColor = Color.White
        End With

    End Sub
    
    Sub cleardata()
        With ADDEMPLOYEE
            .getNo()
            .Firstname.Clear()
            .Lastname.Clear()
            .Gender.SelectedIndex = -1
            .Username.Clear()
            .Password.Clear()
            .rankAdmin.Checked = False
            .rankEmployee.Checked = False
        End With


        With EMPLOYEEINFORMATION
            .EmployeeID.Clear()
            .Firstname.Clear()
            .Lastname.Clear()
            .Gender.SelectedIndex = -1
            .Username.Clear()
            .Password.Clear()
            .RanksTextBox.Clear()
            .txtGender.Clear()
            .cboSTATUS.SelectedIndex = -1
            .rSUPERVISOR.Checked = False
            .rEMPLOYEE.Checked = False
        End With

    End Sub

    Private Sub VIEWSALE_Click(sender As Object, e As EventArgs) Handles VIEWSALE.Click
        'VIEWSALESFORM.Show()
        'VIEWSALESFORM.SALES_NO.Text = ""
        'VIEWSALESFORM.SalesDataGridView.ClearSelection()
        'VIEWSALESFORM.SalesTableAdapter.Fill(VIEWSALESFORM.ANDOKSDataSet.Sales)
        'VIEWSALESFORM.SalesItemTableAdapter.Fill(VIEWSALESFORM.ANDOKSDataSet.SalesItem)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        VIEWSALESFORM.btnHOMESUPERVISOR.Visible = True
        Me.Hide()
        With VIEWSALESFORM
            .Show()
            .SALES_NO.Text = ""
            'POPULATE DATA IN DATAGRID VIEW
            .SalesTableAdapter.Fill(VIEWSALESFORM.ANDOKSDataSet.Sales)
            .cleardisplayeddata()
            .populateDaily()

            Dim count As Integer = 0
            Dim cmdgetSales As OleDbCommand = New OleDbCommand("SELECT * FROM Sales", myConnectiontoEmployeeInfo)
            Dim getSales As OleDbDataReader = cmdgetSales.ExecuteReader()
            While getSales.Read
                count += 1
            End While
            .total = 0
            If count > 0 Then
                Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(Total_Cost) FROM Sales", myConnectiontoEmployeeInfo)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                While dr.Read
                    .total = dr(0)
                End While

                .total_sale_display.Text = Format(.total, "c")
            End If

        End With
        myConnectiontoEmployeeInfo.Close()
    End Sub

    Private Sub TAX_DISCOUNT_Click(sender As Object, e As EventArgs) Handles TAX_DISCOUNT.Click
        Me.Hide()
        LOOKUPFORM.Show()
    End Sub

    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        Me.Hide()
        STOCKSFORM.Show()
    End Sub
End Class