Imports System.Data.OleDb
Public Class LOOKUPFORM
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile


    Private Sub LOOKUPFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        Dim access = New AccessToDatabase()

        Dim getTax = access.getLookupDetails("Tax", myConnectiontoEmployeeInfo)
        While getTax.Read
            txtTax.Text = getTax(2)
        End While

        Dim getDiscount = access.getLookupDetails("Senior Citizen", myConnectiontoEmployeeInfo)
        While getDiscount.Read
            txtDiscount.Text = getDiscount(2)
        End While
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        SUPERVISORACCESS.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim access = New AccessToDatabase()
        If txtTax.Text = Nothing Or txtDiscount.Text = "" Or Not IsNumeric(txtDiscount.Text) Or Not IsNumeric(txtTax.Text) Then
            MsgBox("Please enter a valid number.", vbInformation)
        Else
            If Not txtTax.Text < 0 Or Not txtDiscount.Text < 0 Then
                access.updateLookupDetails(myConnectiontoEmployeeInfo, txtTax.Text, "Tax")
                access.updateLookupDetails(myConnectiontoEmployeeInfo, txtDiscount.Text, "Senior Citizen")
                MsgBox("Successfully updated the Tax/Discount percentage", vbInformation)
            Else
                MsgBox("Please enter a valid number.", vbInformation)
            End If
        End If
    End Sub

End Class