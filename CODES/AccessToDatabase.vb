Imports System.Data.OleDb
Public Class AccessToDatabase


    'INSERT VALUE FROM DATABASE

    Sub insertToPaymentTable(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal payment_ID As Integer, ByVal sales_id As Integer, ByVal total_amount As Double, ByVal payment As Double,ByVal change As Double, ByVal tax As Double, ByVal discount As Double)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim cmdPayment As OleDbCommand = New OleDbCommand("INSERT INTO Payment(Payment_ID,Sales_ID,Total_Amount,Total_Payment,Change,Tax_Amount,Discount) VALUES(@Payment_ID,@Sales_ID,@Total_Amount,@Total_Payment,@Change,@Tax_Amount,@Discount)", myConnectiontoEmployeeInfo)
        With cmdPayment
            .Parameters.AddWithValue("@Payment_ID", payment_ID)
            .Parameters.AddWithValue("@Sales_ID", sales_id)
            .Parameters.AddWithValue("@Total_Amount,", total_amount)
            .Parameters.AddWithValue("@Total_Payment", payment)
            .Parameters.AddWithValue("@Change", change)
            .Parameters.AddWithValue("@Tax_Amount", tax)
            .Parameters.AddWithValue("@Discount", discount)
        End With

        Try
            cmdPayment.ExecuteNonQuery()
            MsgBox("THANK YOU FOR COMING! PLEASE COME AGAIN!", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("ERROR IN PAYMENT FORM", MsgBoxStyle.Information)
        End Try
    End Sub


    Sub insertNewtoSalesTable(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal sales_id As Integer, ByVal user_id As Integer, ByVal strStatus As String)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim cmdSales As OleDbCommand = New OleDbCommand("INSERT INTO Sales(Sales_ID, EmployeeID, Status) VALUES(@Sales_ID,@EmployeeID,@Status)", myConnectiontoEmployeeInfo)
        With cmdSales
            .Parameters.AddWithValue("@Sales_ID", sales_id)
            .Parameters.AddWithValue("@EmployeeID", user_id)
            .Parameters.AddWithValue("@Status", strStatus)
        End With
        Try
            cmdSales.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERROR WHEN INSERTING NEW")
        End Try
    End Sub
    Sub insertToSalesItemTable(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal salesitemid As Integer, ByVal sales_id As Integer, ByVal productno As Integer, ByVal prodname As String, ByVal prodqty As Integer, ByVal OJPrice As Integer)
        Dim cmdinsertProduct As OleDbCommand = Nothing
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        cmdinsertProduct = New OleDbCommand("INSERT INTO SalesItem(SalesItem_ID,Sales_ID,Product_ID,Product_Name,Qty,Price) VALUES(@SalesItem_ID,@Sales_ID,@Product_ID,@Product_Name,@Qty,@Price)", myConnectiontoEmployeeInfo)
        With cmdinsertProduct
            .Parameters.AddWithValue("@SalesItem_ID", salesitemid)
            .Parameters.AddWithValue("@Sales_ID", sales_id)
            .Parameters.AddWithValue("@Product_ID", productno)
            .Parameters.AddWithValue("@Product_Name", prodname)
            .Parameters.AddWithValue("@Qty", prodqty)
            .Parameters.AddWithValue("@Price", OJPrice)
        End With
        Try
            cmdinsertProduct.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERROR WHEN INSERTING DATA")
        End Try


    End Sub

    'END OF INSERT VALUE FROM DATABASE


    'UPDATE VALUE FROM DATABASE
    Sub updateLookupDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal value As Integer, ByVal name As String)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Lookup SET Lookup_Value = @value WHERE Lookup_Name = @name", myConnectiontoEmployeeInfo)

        cmd.Parameters.AddWithValue("@value", value)
        cmd.Parameters.AddWithValue("@name", name)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub updateProductDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal prodname As String, ByVal prodprice As Double, ByVal stocks As Integer, ByVal prod_id As Integer)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Product SET Product_Name = @prodname, Price = @price, Stocks = @stocks WHERE Product_ID = @prod_id", myConnectiontoEmployeeInfo)

        cmd.Parameters.AddWithValue("@prodname", prodname)
        cmd.Parameters.AddWithValue("@prodprice", prodprice)
        cmd.Parameters.AddWithValue("@stocks", stocks)
        cmd.Parameters.AddWithValue("@prod_id", prod_id)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Sub updateProductStocks(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal qty As Integer, ByVal prod_id As Integer)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Product SET Stocks = @qty WHERE Product_ID = @prod_id", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@qty", qty)
        cmd.Parameters.AddWithValue("@prod_id", prod_id)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub updateSalesDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal total_amount As Double, ByVal date_time As String, ByVal strStatus As String, ByVal sales_id As Integer)

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim access = New AccessToDatabase()

        Dim cmd As OleDbCommand = New OleDbCommand("UPDATE Sales SET Total_Cost = @Total_Cost, Date_Sold = @DATE_SOLD, Status = @strStatus WHERE Sales_ID = @Sales_ID", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@Total_Cost", total_amount)
        cmd.Parameters.AddWithValue("@DATE_SOLD", date_time)
        cmd.Parameters.AddWithValue("@strStatus", strStatus)
        cmd.Parameters.AddWithValue("@Sales_ID", sales_id)
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERROR UPDATING THE STATUS OF SALES")
        End Try

    End Sub

    Sub updateSalesItemTable(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal prodqty As Integer, ByVal prodTotal As Integer, ByVal productno As Integer, ByVal sales_id As Integer)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        Dim updateQuantity As OleDbCommand = New OleDbCommand("UPDATE SalesItem SET Qty = @qty , Price = @PRICE WHERE Product_ID = @prod_id AND Sales_ID = @salesid", myConnectiontoEmployeeInfo)
        With updateQuantity
            .Parameters.AddWithValue("@qty", prodqty)
            .Parameters.AddWithValue("@PRICE", prodTotal)
            .Parameters.AddWithValue("@prod_id", productno)
            .Parameters.AddWithValue("@sales_id", sales_id)
        End With
        Try
            updateQuantity.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("ERROR UPDATING THE ORDER")
        End Try

    End Sub
    'END OF UPDATE VALUE FROM DATABASE

    'DELETE VALUE FROM DATABASE
    Sub deleteOrderFromSalesItem(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal prod_id As Integer, ByVal sales_id As Integer)
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim cmd As OleDbCommand = New OleDbCommand("DELETE FROM SalesItem WHERE Product_ID = @prodid and Sales_ID = @salesno", myConnectiontoEmployeeInfo)
        With cmd
            .Parameters.AddWithValue("@prodid", prod_id)
            .Parameters.AddWithValue("@salesno", sales_id)
        End With
        Try
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error occured while deleting the menu!", MsgBoxStyle.Information)
        End Try
    End Sub

    'END OF UPDATE VALUE FROM DATABASE

    'RETRIEVE VALUE FROM DATABASE

    Function getUserDetailsById(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal id As Integer) As OleDbDataReader
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM Employee where EmployeeID = @id", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result

    End Function

    Function getSalesDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal id As Integer) As OleDbDataReader
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM Sales where Sales_ID = @id", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result

    End Function
    Function getPaymentDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal id As Integer) As OleDbDataReader
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM Payment where Sales_ID = @id", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@id", id)
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result

    End Function


    Function getLookupDetails(ByVal name As String, ByVal myConnectiontoEmployeeInfo As OleDbConnection) As OleDbDataReader
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM Lookup where Lookup_Name = @name", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@name", name)
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result

    End Function

    Function getUserDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection) As OleDbDataReader
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM Employee", myConnectiontoEmployeeInfo)
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result

    End Function

    'GET SALES ITEM DETAILS BY PROD ID
    Function getSalesItemDetailsByProdId(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal productno As Integer, ByVal salesid As Integer) As OleDbDataReader

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM SalesItem WHERE Product_ID = @Product_ID AND Sales_ID = @salesid", myConnectiontoEmployeeInfo)
        With cmd
            .Parameters.AddWithValue("@Product_ID", productno)
            .Parameters.AddWithValue("@Sales_ID", salesid)
        End With
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    'GET SALES ITEM DETAILS BY SALES ID
    Function getSalesItemDetailsBySalesID(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal salesid As Integer) As OleDbDataReader

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("Select * FROM SalesItem WHERE Sales_ID = @salesid ORDER BY Product_ID", myConnectiontoEmployeeInfo)
        With cmd
            .Parameters.AddWithValue("@Sales_ID", salesid)
        End With
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Function getProductDetails(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal productno As Integer) As OleDbDataReader
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim result As OleDbDataReader = Nothing

        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM Product WHERE Product_ID = @Product_ID", myConnectiontoEmployeeInfo)
        cmd.Parameters.AddWithValue("@Product_ID", productno)
        Try
            result = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return result
    End Function

    Function getSalesID(ByVal myConnectiontoEmployeeInfo As OleDbConnection) As Integer
        Dim sales_ID
        Dim dt As New DataTable
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If


        Dim da As New OleDb.OleDbDataAdapter("Select Sales_ID FROM Sales ORDER BY Sales_ID DESC", myConnectiontoEmployeeInfo)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            sales_ID = dt.Rows(0).Item(0) + 1

        Else
            sales_ID = 1
        End If
        Return sales_ID

    End Function



    Function getSalesItemID(ByVal myConnectiontoEmployeeInfo As OleDbConnection) As Integer
        Dim dt As New DataTable
        Dim SalesItem_ID = 0

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim da2 As New OleDb.OleDbDataAdapter("Select SalesItem_ID FROM SalesItem ORDER BY SalesItem_ID DESC", myConnectiontoEmployeeInfo)
        da2.Fill(dt)

        If dt.Rows.Count > 0 Then
            SalesItem_ID = dt.Rows(0).Item(0) + 1
        Else
            SalesItem_ID = 1
        End If
        Return SalesItem_ID
    End Function
    'END OF RETRIEVE VALUE FROM DATABASE


    'RETRIEVE SUM FROM DATABASE


    Function getTotalPerSalesID(ByVal myConnectiontoEmployeeInfo As OleDbConnection, ByVal sales_id As Integer) As OleDbDataReader

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim drTotal As OleDbDataReader

        Dim getTotal As OleDbCommand = New OleDbCommand("SELECT SUM(PRICE) FROM SalesItem WHERE Sales_ID = @sales_id", myConnectiontoEmployeeInfo)
        getTotal.Parameters.AddWithValue("@sales_id", sales_id)
        Try
            drTotal = getTotal.ExecuteReader()
        Catch ex As Exception
            MsgBox("ERROR IN RETRIEVING THE SUM OF SALES ITEM PER SALES_ID")
        End Try
        Return drTotal
    End Function
End Class
