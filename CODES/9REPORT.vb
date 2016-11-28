Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class formReport
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Private Sub formReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        populateListView()

    End Sub

    Sub populateListView()
        Dim dt As New DataTable
        'Dim ds As New DataSet
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        Try
            LIST_ITEM_ORDER.Items.Clear()
            Dim dapt As OleDbDataAdapter = New OleDbDataAdapter("SELECT s.Product_Name, s.Qty, s.Price, p.Price FROM SalesItem s
                                                                 INNER JOIN Product p on s.Product_ID = p.Product_ID 
                                                                 WHERE s.Sales_ID =" & ADD_SALES.salesid & "", myConnectiontoEmployeeInfo)
            Dim concatValue As String = ""
            dapt.Fill(dt)
            Dim item As DataRow
            For Each item In dt.Rows
                LIST_ITEM_ORDER.Items.Add(item.Item(0))
                concatValue = item.Item(1) & "@" & item.Item(3)
                LIST_ITEM_ORDER.Items(LIST_ITEM_ORDER.Items.Count - 1).SubItems.Add(concatValue)
                LIST_ITEM_ORDER.Items(LIST_ITEM_ORDER.Items.Count - 1).SubItems.Add(CInt(item.Item(2)).ToString("C"))

            Next
        Catch ex As Exception
            MsgBox("ERROR POPULATING THE LISTVIEW - " & ex.Message)
        End Try

        populateOtherData()

        myConnectiontoEmployeeInfo.Close()
    End Sub

    Sub populateOtherData()

        'SET THE HEIGHT OF LISTVIEW
        Dim v As Integer = LIST_ITEM_ORDER.Items.Count * 20 + LIST_ITEM_ORDER.Size.Height
        LIST_ITEM_ORDER.Size = New Size(LIST_ITEM_ORDER.Size.Width, v)

        'SET THE POSITION OF DETAILS PANEL
        Dim x As Integer = LIST_ITEM_ORDER.Location.Y + v
        panelDetails.Location = New Point(LIST_ITEM_ORDER.Location.X, x)


        'SET THE HEIGHT OF CONTAINER PANEL
        Dim y As Integer = v + x + panelTitle.Height

        'SET THE SIZE OF FORM     
        Dim newHeight = 0
        If (y > Me.Size.Height) Then
            newHeight = y - Me.Size.Height
        Else
            newHeight = Me.Size.Height - y
        End If
        Me.Size = New Size(Me.Size.Width, Me.Size.Height + newHeight)
        pnlContainer.Size = New Size(pnlContainer.Width, Me.Size.Height)

        MsgBox(y & " = " & Me.Size.Height & " = " & pnlContainer.Height)

        'POPULATE ALL THE DATA
        Dim access = New AccessToDatabase()
        Dim paymentDetails = access.getPaymentDetails(myConnectiontoEmployeeInfo, ADD_SALES.salesid)

        While paymentDetails.Read
            lblSalesID.Text = paymentDetails("Sales_ID")
            lblPayment.Text = "(" & paymentDetails("Total_Payment") & ")"
            lblChange.Text = paymentDetails("Change")
            lblVat.Text = paymentDetails("Tax_Amount")
            lblDiscount.Text = paymentDetails("Discount")
            lblTotal.Text = paymentDetails("Total_Amount")
        End While

        Dim salesDetails = access.getSalesDetails(myConnectiontoEmployeeInfo, ADD_SALES.salesid)
        While salesDetails.Read
            lblDateSold.Text = salesDetails("Date_Sold")
            Dim userDetails = access.getUserDetailsById(myConnectiontoEmployeeInfo, salesDetails("EmployeeID"))
            While userDetails.Read
                lblSalesPerson.Text = userDetails("Firstname")
            End While
            lblSubTotal.Text = salesDetails("Total_Cost")
        End While

    End Sub

    Private bitmap As Bitmap
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        btnPrint.Visible = False
        'Add a Panel control.
        Dim panel As New Panel()
        Me.Controls.Add(panel)

        'Create a Bitmap of size same as that of the Form.
        Dim grp As Graphics = panel.CreateGraphics()
        Dim formSize As Size = Me.ClientSize
        bitmap = New Bitmap(formSize.Width, formSize.Height, grp)
        grp = Graphics.FromImage(bitmap)

        'Copy screen area that that the Panel covers.
        Dim panelLocation As Point = PointToScreen(panel.Location)
        grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize)

        'Show the Print Preview Dialog.
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    Private Sub PrintPage(sender As Object, e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Print the contents.
        e.Graphics.DrawImage(bitmap, 230, 0)
        btnPrint.Visible = True
    End Sub


End Class