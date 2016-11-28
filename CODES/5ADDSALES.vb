Imports System.Data.OleDb


Public Class ADD_SALES

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Dim totalcost As Double = 0
    Public Shared salesid, product_number, selectedProductID As Integer
    Public Shared tax, discount As Double
    Public Shared clickStatus As String



    Private Sub btnVOID_Click(sender As Object, e As EventArgs) Handles btnVOID.Click
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        If ORDER_LIST.SelectedItems.Count > 0 Then
            With Me
                .Show()
                .BTNFINALIZE.Enabled = False
                .BTNCANCEL.Enabled = False
                .btnVOID.Enabled = False
                .BTNHOME.Enabled = False
                .BTNNEWSALES.Enabled = False
                .menu1.Enabled = False
                .menu2.Enabled = False
                .menu3.Enabled = False
                .menu4.Enabled = False
                .menu5.Enabled = False
                .menu6.Enabled = False
                .menu7.Enabled = False
                .menu8.Enabled = False
                .chickenimage.Visible = False
                .TOTAL_COST()
            End With
            With CONFIRMATIONFORM
                .txtSupervisorPassword.Text = ""
                .Show()
            End With
        Else
            MsgBox("PICK AN ITEM FIRST!")
        End If

        clickStatus = "VOID"
        'Dim item As ListViewItem = ORDER_LIST.SelectedItems(0)
        'MsgBox(item.Text)

    End Sub
    Private Sub BTNCANCEL_Click(sender As Object, e As EventArgs) Handles BTNCANCEL.Click

        If MsgBox("Are you sure you want to cancel the order?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
            With Me
                .BTNFINALIZE.Enabled = False
                .BTNCANCEL.Enabled = False
                .btnVOID.Enabled = False
                .BTNHOME.Enabled = False
                .BTNNEWSALES.Enabled = False
                .menu1.Enabled = False
                .menu2.Enabled = False
                .menu3.Enabled = False
                .menu4.Enabled = False
                .menu5.Enabled = False
                .menu6.Enabled = False
                .menu7.Enabled = False
                .menu8.Enabled = False
                .chickenimage.Visible = False
                .TOTAL_COST()
            End With

            With CONFIRMATIONFORM
                .txtSupervisorPassword.Text = ""
                .Show()
            End With
            clickStatus = "CANCEL"

        End If
    End Sub


    Private Sub BTNFINALIZE_Click(sender As Object, e As EventArgs) Handles BTNFINALIZE.Click
        Dim strStatus As String = "PROCESSED"
        Dim access = New AccessToDatabase()


        Dim getTaxDetails = access.getLookupDetails("Tax", myConnectiontoEmployeeInfo)
        While getTaxDetails.Read
            tax = getTaxDetails(2)
        End While

        tax = (tax / 100) * Double.Parse(totalAmount.Text, Globalization.NumberStyles.Any)

        If chkSeniorCitizen.Checked Then
            Dim getDiscountDetails = access.getLookupDetails("Senior Citizen", myConnectiontoEmployeeInfo)
            While getDiscountDetails.Read
                discount = getDiscountDetails(2)
            End While
            discount = (discount / 100) * Double.Parse(totalAmount.Text, Globalization.NumberStyles.Any)
        End If

        Dim total As Double = (Double.Parse(totalAmount.Text, Globalization.NumberStyles.Any) + tax) - discount


        If MsgBox("Are you sure you want to finalize the order?", MsgBoxStyle.OkCancel, "Confirmation") = MsgBoxResult.Ok Then
            Me.Hide()
            PAYMENTFORM.Show()
            PAYMENTFORM.payment.Focus()
            PAYMENTFORM.payment.Text = ""
            PAYMENTFORM.total_amount.Text = Format(total, "currency")
            PAYMENTFORM.payment.Text = Format(PAYMENTFORM.payment.Text)
            access.updateSalesDetails(myConnectiontoEmployeeInfo, totalAmount.Text, DATEANDTIME.Text, strStatus, salesid)
        End If
    End Sub



    Private Sub BTNNEWSALES_Click(sender As Object, e As EventArgs) Handles BTNNEWSALES.Click
        Dim access = New AccessToDatabase()
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        Dim strStatus As String = "New"
        salesid = access.getSalesID(myConnectiontoEmployeeInfo)
        sales_no.Text = salesid
        ORDER_LIST.Items.Clear()
        access.insertNewtoSalesTable(myConnectiontoEmployeeInfo, salesid, LOGINFORM.userID, strStatus)
        menu1.Visible = True
        menu2.Visible = True
        menu3.Visible = True
        menu4.Visible = True
        menu5.Visible = True
        menu6.Visible = True
        menu7.Visible = True
        menu8.Visible = True
        chickenimage.Visible = False
        BTNHOME.Enabled = False
        BTNNEWSALES.Enabled = False
        BTNCANCEL.Enabled = True
        btnVOID.Enabled = True


        If totalcost = 0 Then
            BTNFINALIZE.Enabled = False
        Else
            BTNFINALIZE.Enabled = True
        End If

    End Sub



    Private Sub menu1_Click(sender As Object, e As EventArgs) Handles menu1.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 1
        transactionToDatabase(Product_No)
    End Sub

    Private Sub menu2_Click(sender As Object, e As EventArgs) Handles menu2.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 2
        transactionToDatabase(Product_No)
    End Sub

    Private Sub menu3_Click(sender As Object, e As EventArgs) Handles menu3.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 3
        transactionToDatabase(Product_No)
    End Sub

    Private Sub menu4_Click(sender As Object, e As EventArgs) Handles menu4.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 4
        transactionToDatabase(Product_No)
    End Sub


    Private Sub menu5_Click(sender As Object, e As EventArgs) Handles menu5.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 5
        transactionToDatabase(Product_No)
    End Sub

    Private Sub menu6_Click(sender As Object, e As EventArgs) Handles menu6.Click

        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 6
        transactionToDatabase(Product_No)
    End Sub

    Private Sub menu7_Click(sender As Object, e As EventArgs) Handles menu7.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim Product_No As Integer = 7
        transactionToDatabase(Product_No)
    End Sub

    Private Sub menu8_Click(sender As Object, e As EventArgs) Handles menu8.Click
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'        
        Dim Product_No As Integer = 8

        transactionToDatabase(Product_No)
    End Sub

    Sub transactionToDatabase(ByVal product_No As Integer)
        product_number = product_No
        Dim access = New AccessToDatabase()
        'RETRIVE THE VALUE OF PRODUCT TABLE        
        Dim salesDetails As OleDbDataReader = access.getProductDetails(myConnectiontoEmployeeInfo, ADD_SALES.product_number)
        While salesDetails.Read
            QUANTITYORDER.lblProductName.Text = salesDetails(1)
        End While
        With QUANTITYORDER
            .Hide()
            .Show()
            .txtQuantity.Text = Nothing
        End With
    End Sub

    Sub TOTAL_COST()
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        Dim totalcost As Double = 0
        'SalesItemTableAdapter.Fill(AndoksDataSet.SalesItem)
        populateListView()
        Dim access = New AccessToDatabase()
        Dim drTotal = access.getTotalPerSalesID(myConnectiontoEmployeeInfo, salesid)

        While drTotal.Read
            If Not IsDBNull(drTotal(0)) Then
                totalcost = drTotal(0)
            End If
        End While

        If totalcost = 0 Then
            BTNFINALIZE.Enabled = False
        End If
        totalAmount.Text = Format(totalcost, "c")
    End Sub

    Sub populateListView()
        ORDER_LIST.Items.Clear()
        Dim access = New AccessToDatabase()
        Dim getSalesItemDetails = access.getSalesItemDetailsBySalesID(myConnectiontoEmployeeInfo, salesid)

        While getSalesItemDetails.Read
            ORDER_LIST.Items.Add(getSalesItemDetails("Product_ID"))
            ORDER_LIST.Items(ORDER_LIST.Items.Count - 1).SubItems.Add(getSalesItemDetails("Product_Name"))
            ORDER_LIST.Items(ORDER_LIST.Items.Count - 1).SubItems.Add(getSalesItemDetails("Qty"))
            ORDER_LIST.Items(ORDER_LIST.Items.Count - 1).SubItems.Add(CInt(getSalesItemDetails("Price")).ToString("C"))
        End While

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DATEANDTIME.Text = Date.Now.ToString("MMMM-dd-yyyy")
    End Sub

    Private Sub ORDER_LIST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ORDER_LIST.SelectedIndexChanged

    End Sub

    Private Sub ORDER_LIST_Click(sender As Object, e As EventArgs) Handles ORDER_LIST.Click
        selectedProductID = ORDER_LIST.SelectedItems(0).Text
    End Sub

    Private Sub BTNHOME_Click(sender As Object, e As EventArgs) Handles BTNHOME.Click
        If MsgBox("Are you sure you want to logout your account?", MsgBoxStyle.OkCancel, "Logout") = MsgBoxResult.Ok Then
            Me.Hide()
            LOGINFORM.Show()
            LOGINFORM.USERNAME.Text = ""
            LOGINFORM.PASSWORD.Text = ""
            LOGINFORM.USERNAME.Focus()
            LOGINFORM.PASSWORD.Focus()
            LOGINFORM.USERNAME.Focus()
        End If
    End Sub

    Private Sub ADD_SALES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        Timer1.Enabled = True


    End Sub

End Class