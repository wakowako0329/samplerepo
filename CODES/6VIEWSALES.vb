Imports System.ComponentModel
Imports System.Data.OleDb


Public Class VIEWSALESFORM

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As New OleDb.OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile
    Public total As Integer

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SalesDataGridView.Columns(2).DefaultCellStyle.Format = "c"
        SalesDataGridView.Columns(3).DefaultCellStyle.Format = ("MMMM-dd-yyyy")
        SalesItemDataGridView.Columns(5).DefaultCellStyle.Format = "c"
        SalesTableAdapter.Fill(Me.ANDOKSDataSet.Sales)
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString


        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        myConnectiontoEmployeeInfo.Close()
    End Sub


    Private Sub btnHOME_Click(sender As Object, e As EventArgs) Handles btnHOMESUPERVISOR.Click
        Me.Hide()
        SUPERVISORACCESS.Show()

    End Sub


    Private Sub SalesDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles SalesDataGridView.CellClick
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        If SalesDataGridView.RowCount > 0 Then
            disablesorting()
            Dim i As Integer
            i = SalesDataGridView.CurrentRow.Index

            SALES_NO.Text = SalesDataGridView.Item(0, i).Value
            'POPULATE SALESITEM DATAGRID VIEW        
            populatesalesitemview()
        Else
            disablesorting()
            MsgBox("NO DATA TO BE DISPLAYED!")
        End If

        myConnectiontoEmployeeInfo.Close()
    End Sub

    Private Sub searchDate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchDate.SelectedIndexChanged
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        SearchDaily()
        myConnectiontoEmployeeInfo.Close()
    End Sub


    Public Sub SearchDaily()
        'POPULATE THE SALES DATAGRID VIEW
        If (searchDate.Text = "") Then
            MsgBox("NO DATA TO BE DISPLAYED!")
            SalesDataGridView.DataSource = Nothing
            total = 0
            total_sale_display.Text = Format(total, "c")
        Else

            Dim displayDate As OleDbCommand = New OleDbCommand("SELECT * FROM Sales WHERE Date_Sold = @datesold ORDER BY Sales_ID", myConnectiontoEmployeeInfo)
            With displayDate
                .Parameters.AddWithValue("@datesold", Convert.ToDateTime(searchDate.Text))
            End With
            Dim showData As OleDbDataReader = displayDate.ExecuteReader()
            Dim table As New DataTable()
            table.Load(showData)
            SalesDataGridView.DataSource = table

            'COMPUTE THE TOTAL SALES FOR EACH DATE
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(TOTAL_COST) FROM SALES WHERE DATE_SOLD = @date_sold", myConnectiontoEmployeeInfo)
            cmd.Parameters.AddWithValue("@date_sold", String.Format("{0:M/d/yyyy}", Convert.ToDateTime(searchDate.Text)))
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            While dr.Read
                total_sale_display.Text = Format(dr(0), "c")
            End While
        End If
        clearsalesitemviewforDaily()
            myConnectiontoEmployeeInfo.Close()
    End Sub

    Public Sub populateDaily()
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If


        Dim displayDate As OleDbCommand = New OleDbCommand("SELECT DISTINCT[Date_Sold] FROM Sales", myConnectiontoEmployeeInfo)
        Dim drDATE As OleDbDataReader = displayDate.ExecuteReader()
        While drDATE.Read
            Dim vDate = drDATE("Date_Sold")

            searchDate.Items.Add(vDate)
        End While
        myConnectiontoEmployeeInfo.Close()
    End Sub

    Private Sub searchMonthly_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchMonthly.SelectedIndexChanged
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        searchperMonth()
        myConnectiontoEmployeeInfo.Close()

    End Sub

    Public Sub searchperMonth()
        Dim intMonth As Integer
        If searchMonthly.Text = "January" Then
            intMonth = 1
        ElseIf searchMonthly.Text = "February" Then
            intMonth = 2
        ElseIf searchMonthly.Text = "March" Then
            intMonth = 3
        ElseIf searchMonthly.Text = "April" Then
            intMonth = 4
        ElseIf searchMonthly.Text = "May" Then
            intMonth = 5
        ElseIf searchMonthly.Text = "June" Then
            intMonth = 6
        ElseIf searchMonthly.Text = "July" Then
            intMonth = 7
        ElseIf searchMonthly.Text = "August" Then
            intMonth = 8
        ElseIf searchMonthly.Text = "September" Then
            intMonth = 9
        ElseIf searchMonthly.Text = "October" Then
            intMonth = 10
        ElseIf searchMonthly.Text = "November" Then
            intMonth = 11
        ElseIf searchMonthly.Text = "December" Then
            intMonth = 12
        End If
        Dim getMonth As OleDbCommand = New OleDbCommand("SELECT * FROM Sales WHERE MONTH(date_sold) =@monthsold ORDER BY Sales_ID", myConnectiontoEmployeeInfo)
        With getMonth
            .Parameters.AddWithValue("@monthsold", intMonth)
        End With
        Dim monthReader As OleDbDataReader = getMonth.ExecuteReader()
        Dim table As New DataTable()
        table.Load(monthReader)
        SalesDataGridView.DataSource = table
        If SalesDataGridView.RowCount > 0 Then
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT SUM(TOTAL_COST) FROM SALES WHERE  MONTH(date_sold) = @monthsold", myConnectiontoEmployeeInfo)
            cmd.Parameters.AddWithValue("@monthsold", intMonth)
            Dim dr As OleDbDataReader = cmd.ExecuteReader()
            While dr.Read
                total = dr(0)
            End While
        Else
            total = 0
        End If
        total_sale_display.Text = Format(total, "c")
        clearsalesitemviewforMonthly()
    End Sub

    Public Sub populateMonthly()
        With searchMonthly.Items
            .Add("January")
            .Add("February")
            .Add("March")
            .Add("April")
            .Add("May")
            .Add("June")
            .Add("July")
            .Add("August")
            .Add("September")
            .Add("October")
            .Add("November")
            .Add("December")
        End With
    End Sub
    Public Sub cleardisplayeddata()

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        SalesDataGridView.ClearSelection()
        populatesalesview()
        SalesItemDataGridView.DataSource = Nothing
        searchDate.Items.Clear()
        With searchMonthly.Items
            .Clear()
            .Add("January")
            .Add("February")
            .Add("March")
            .Add("April")
            .Add("May")
            .Add("June")
            .Add("July")
            .Add("August")
            .Add("September")
            .Add("October")
            .Add("November")
            .Add("December")
        End With
    End Sub

    Public Sub countofdata()
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If
        Dim count As Integer = 0
        Dim countdata As OleDbCommand = New OleDbCommand("SELECT COUNT(*) FROM Sales", myConnectiontoEmployeeInfo)
        Dim numberofdata As OleDbDataReader = countdata.ExecuteReader()
        While numberofdata.Read
            count = numberofdata(0)
        End While
        myConnectiontoEmployeeInfo.Close()
    End Sub

    Public Sub disablesorting()
        SalesDataGridView.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesDataGridView.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesDataGridView.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesDataGridView.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesDataGridView.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable

        SalesItemDataGridView.Columns(0).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesItemDataGridView.Columns(1).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesItemDataGridView.Columns(2).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesItemDataGridView.Columns(3).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesItemDataGridView.Columns(4).SortMode = DataGridViewColumnSortMode.NotSortable
        SalesItemDataGridView.Columns(5).SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub

    Public Sub clearsalesitemviewforDaily()
        SALES_NO.Text = ""
        SalesDataGridView.ClearSelection()
        SalesItemDataGridView.DataSource = Nothing
        With searchMonthly.Items
            .Clear()
            .Add("January")
            .Add("February")
            .Add("March")
            .Add("April")
            .Add("May")
            .Add("June")
            .Add("July")
            .Add("August")
            .Add("September")
            .Add("October")
            .Add("November")
            .Add("December")
        End With

    End Sub

    Public Sub clearsalesitemviewforMonthly()
        SALES_NO.Text = ""
        SalesDataGridView.ClearSelection()
        SalesItemDataGridView.DataSource = Nothing
        searchDate.Items.Clear()
        populateDaily()
    End Sub

    Public Sub populatesalesview()
        Dim getSalesItemData As OleDbCommand = New OleDbCommand("SELECT * FROM Sales ORDER BY Sales_ID", myConnectiontoEmployeeInfo)
        Dim displaySalesItem As OleDbDataReader = getSalesItemData.ExecuteReader()
        Dim table As New DataTable()
        table.Load(displaySalesItem)
        SalesDataGridView.DataSource = table
    End Sub

    Public Sub populatesalesitemview()
        Dim getSalesItemData As OleDbCommand = New OleDbCommand("SELECT * FROM SalesItem WHERE Sales_ID = @salesid", myConnectiontoEmployeeInfo)
        With getSalesItemData
            .Parameters.AddWithValue("@salesid", SALES_NO.Text)
        End With
        Dim displaySalesItem As OleDbDataReader = getSalesItemData.ExecuteReader()
        Dim table As New DataTable()
        table.Load(displaySalesItem)
        SalesItemDataGridView.DataSource = table
    End Sub

End Class