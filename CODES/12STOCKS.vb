Imports System.Data.OleDb
Public Class STOCKSFORM
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Dim id, stocks As Integer


    Private Sub STOCKSFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ANDOKSDataSet.Product' table. You can move, or remove it, as needed.
        stocksGridView.Update()
        stocksGridView.Refresh()
        Me.ProductTableAdapter.Fill(Me.ANDOKSDataSet.Product)
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        txtPrice.Text = ""
        txtStocks.Text = ""
        txtProductName.Text = ""

    End Sub

    Private Sub stocksGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles stocksGridView.CellClick
        Dim i As Integer
        i = stocksGridView.CurrentRow.Index
        With stocksGridView
            id = .Item(0, i).Value
            txtProductName.Text = .Item(1, i).Value
            txtPrice.Text = .Item(2, i).Value
            stocks = .Item(3, i).Value
        End With
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim access = New AccessToDatabase()

        If txtProductName.Text = Nothing Or txtPrice.Text = Nothing Or txtStocks.Text = Nothing Then
            MsgBox("No empty fields allowed", vbInformation)
        Else
            If Not IsNumeric(txtPrice.Text) Or Not IsNumeric(txtStocks.Text) Then
                MsgBox("Please enter a valid number", vbInformation)
            Else
                If txtPrice.Text < 0 Or txtStocks.Text < 0 Then
                    MsgBox("Please enter a whole number", vbInformation)
                Else
                    Dim newStocks = stocks + CInt(txtStocks.Text)
                    access.updateProductDetails(myConnectiontoEmployeeInfo, txtProductName.Text, Double.Parse(txtPrice.Text), newStocks, id)
                    MsgBox("Successfully updated the product details.", vbInformation)
                    txtProductName.Text = ""
                    txtPrice.Text = ""
                    txtStocks.Text = ""
                    Me.ProductTableAdapter.Fill(Me.ANDOKSDataSet.Product)
                End If
            End If
            End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        SUPERVISORACCESS.Show()
    End Sub

End Class