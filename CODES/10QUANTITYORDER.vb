Imports System.Data.OleDb
Public Class QUANTITYORDER
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile


    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim access = New AccessToDatabase()
        Dim prodqty As Integer
        Dim OJPrice As Integer
        Dim prodname As String = ""
        Dim stocks As Integer

        'RETRIEVE THE VALUE OF SALES ITEM TABLE BY PRODUCT ID
        Dim salesItemDetailsByProductId As OleDbDataReader = access.getSalesItemDetailsByProdId(myConnectiontoEmployeeInfo, ADD_SALES.product_number, ADD_SALES.sales_no.Text)

        'RETRIVE THE VALUE OF PRODUCT TABLE        
        Dim salesDetails As OleDbDataReader = access.getProductDetails(myConnectiontoEmployeeInfo, ADD_SALES.product_number)
        While salesDetails.Read
            OJPrice = salesDetails(2)
            prodname = salesDetails(1)
            stocks = salesDetails(3)
        End While

        Dim prodTotal As Integer
        With ADD_SALES
            If (txtQuantity.Text IsNot Nothing) Or Not String.IsNullOrEmpty(txtQuantity.Text) Or Not String.IsNullOrWhiteSpace(txtQuantity.Text) Then
                If (txtQuantity.Text > 0) Then
                    If stocks >= CInt(txtQuantity.Text) Then

                        'UPDATE THE PRODUCT STOCKS
                        stocks = stocks - CInt(txtQuantity.Text)
                        access.updateProductStocks(myConnectiontoEmployeeInfo, stocks, ADD_SALES.product_number)

                        If salesItemDetailsByProductId.Read = True Then

                            prodname = salesItemDetailsByProductId("Product_Name")
                            prodqty = salesItemDetailsByProductId("Qty")

                            prodqty = prodqty + CInt(txtQuantity.Text)
                            prodTotal = OJPrice * prodqty

                            'UPDATE THE QUANTITY 
                            access.updateSalesItemTable(myConnectiontoEmployeeInfo, prodqty, prodTotal, ADD_SALES.product_number, ADD_SALES.salesid)
                        Else
                            prodqty = CInt(txtQuantity.Text)
                            prodTotal = OJPrice * prodqty
                            'ADD THE PRODUCT 
                            access.insertToSalesItemTable(myConnectiontoEmployeeInfo, access.getSalesItemID(myConnectiontoEmployeeInfo), ADD_SALES.salesid, ADD_SALES.product_number, prodname, prodqty, prodTotal)
                        End If

                        Me.Hide()
                        .TOTAL_COST()
                        If .totalAmount.Text = 0 Then
                            .BTNFINALIZE.Enabled = False
                        Else
                            .BTNFINALIZE.Enabled = True
                        End If
                    ElseIf stocks = 0 Then
                        MsgBox("There are no more stocks available for " & prodname & ".", MsgBoxStyle.Information)
                        Me.Hide()
                    Else

                        MsgBox("There are only " & stocks & " stocks left for " & prodname & ".", MsgBoxStyle.Information)
                    End If

                Else
                    MsgBox("Please enter a proper quantity.", MsgBoxStyle.Information)
                End If
            End If
        End With
        myConnectiontoEmployeeInfo.Close()
    End Sub
    Private Sub QUANTITYORDER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
    End Sub

    Private Sub txtQuantity_GotFocus(sender As Object, e As EventArgs) Handles txtQuantity.GotFocus
        If txtQuantity.Text = "Enter the quantity.." Then
            txtQuantity.ForeColor = Color.Gray
            txtQuantity.Text = ""
        End If
    End Sub

    Private Sub txtQuantity_LostFocus(sender As Object, e As EventArgs) Handles txtQuantity.LostFocus
        If txtQuantity.Text = Nothing Then
            txtQuantity.ForeColor = Color.Gray
            txtQuantity.Text = "Enter the quantity.."
        End If
    End Sub

End Class