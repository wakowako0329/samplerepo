Imports System.Data.OleDb
Public Class CONFIRMATIONFORM

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        Dim access = New AccessToDatabase()

        Dim userDetails = access.getUserDetails(myConnectiontoEmployeeInfo)

        Dim salesItemDetailsByProductId = access.getSalesItemDetailsByProdId(myConnectiontoEmployeeInfo, ADD_SALES.product_number, ADD_SALES.salesid)

        Dim salesItemDetailsBySalesId = access.getSalesItemDetailsBySalesID(myConnectiontoEmployeeInfo, ADD_SALES.salesid)



        QUANTITYORDER.Hide()
        If userDetails.Read = True Then
            If userDetails("Ranks").Equals("Supervisor") And String.Equals(userDetails("Password"), txtSupervisorPassword.Text) Then
                If (ADD_SALES.clickStatus.Equals("CANCEL")) Then
                    Dim strStatus As String = "CANCELLED"
                    While salesItemDetailsBySalesId.Read
                        Dim productDetails As OleDbDataReader = access.getProductDetails(myConnectiontoEmployeeInfo, salesItemDetailsBySalesId("Product_ID"))
                        While productDetails.Read
                            If (productDetails("Product_ID") = (salesItemDetailsBySalesId("Product_ID"))) Then
                                Dim newQty = salesItemDetailsBySalesId("Qty") + productDetails("Stocks")
                                Dim product_id = salesItemDetailsBySalesId("Product_ID")
                                access.updateProductStocks(myConnectiontoEmployeeInfo, newQty, product_id)
                            End If
                        End While
                    End While

                    access.updateSalesDetails(myConnectiontoEmployeeInfo, ADD_SALES.totalAmount.Text, ADD_SALES.DATEANDTIME.Text, strStatus, ADD_SALES.salesid)
                    MsgBox("Successfully cancelled the order.", MsgBoxStyle.Information)
                    Me.Hide()
                    With ADD_SALES
                        .Show()
                        .BTNFINALIZE.Enabled = False
                        .BTNCANCEL.Enabled = False
                        .btnVOID.Enabled = False
                        .BTNHOME.Enabled = True
                        .BTNNEWSALES.Enabled = True
                        .chickenimage.Visible = True
                        .chkSeniorCitizen.Checked = False
                        .totalAmount.Text = ""
                        .sales_no.Text = ""
                        .salesid = 0
                        .TOTAL_COST()
                    End With
                    DisplayAndEnableMenu()
                Else
                    While salesItemDetailsBySalesId.Read
                        Dim productDetails As OleDbDataReader = access.getProductDetails(myConnectiontoEmployeeInfo, salesItemDetailsBySalesId("Product_ID"))
                        While productDetails.Read
                            If (productDetails("Product_ID") = (salesItemDetailsBySalesId("Product_ID"))) Then
                                Dim newQty = salesItemDetailsBySalesId("Qty") + productDetails("Stocks")
                                If (salesItemDetailsBySalesId("Product_ID") = ADD_SALES.selectedProductID) Then
                                    access.updateProductStocks(myConnectiontoEmployeeInfo, newQty, ADD_SALES.selectedProductID)
                                End If
                            End If
                        End While
                    End While
                    access.deleteOrderFromSalesItem(myConnectiontoEmployeeInfo, ADD_SALES.selectedProductID, ADD_SALES.salesid)
                    MsgBox("The selected menu has been deleted!", MsgBoxStyle.Information)
                    'For Each i As ListViewItem In ADD_SALES.ORDER_LIST.SelectedItems
                    '    ADD_SALES.ORDER_LIST.Items.Remove(i)
                    'Next


                    Me.Hide()
                    With ADD_SALES
                        .BTNFINALIZE.Enabled = False
                        .BTNCANCEL.Enabled = True
                        .btnVOID.Enabled = True
                        .BTNHOME.Enabled = False
                        .BTNNEWSALES.Enabled = False
                        .TOTAL_COST()
                    End With
                    DisplayAndEnableMenu()
                    If ADD_SALES.ORDER_LIST.Items.Count > 0 Then
                        ADD_SALES.BTNFINALIZE.Enabled = True
                    End If
                End If

            Else
                MsgBox("Please enter a valid password of a supervisor.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Sub DisplayAndEnableMenu()
        With ADD_SALES
            .menu1.Enabled = True
            .menu2.Enabled = True
            .menu3.Enabled = True
            .menu4.Enabled = True
            .menu5.Enabled = True
            .menu6.Enabled = True
            .menu7.Enabled = True
            .menu8.Enabled = True
            .menu1.Visible = True
            .menu2.Visible = True
            .menu3.Visible = True
            .menu4.Visible = True
            .menu5.Visible = True
            .menu6.Visible = True
            .menu7.Visible = True
            .menu8.Visible = True
        End With
    End Sub

    Private Sub CONFIRMATIONFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString

    End Sub
End Class