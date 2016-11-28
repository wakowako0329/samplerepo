Imports System.Data.OleDb
Public Class PAYMENTFORM

    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\bin\Debug\ANDOKS.accdb"'
    'Dim EmployeeinfoFile As String = "C:\Users\isheeiana\Documents\Visual Studio 2015\Projects\SYSANDPROJECT\SYSANDPROJECT\ANDOKS.accdb"'
    Dim EmployeeinfoFile As String = Application.StartupPath & "\ANDOKS.accdb"
    Dim myConnectiontoEmployeeInfo As OleDbConnection = New OleDbConnection
    Dim EmployeeConnString As String = provider & EmployeeinfoFile


    'Private Sub payment_KeyPress(sender As Object, e As KeyPressEventArgs) Handles payment.KeyPress

    '    If Char.IsDigit(e.KeyChar) = False Then
    '        If Char.IsDigit(e.KeyChar) Or e.KeyChar = "." Then
    '            If Me.payment.Text.Contains(".") Then
    '                If Me.payment.Text.Split(".")(1).Length < 2 Then
    '                    If Char.IsDigit(e.KeyChar) = False Then
    '                        e.Handled = True
    '                    End If
    '                Else
    '                    e.Handled = True
    '                End If
    '            End If
    '        Else
    '            e.Handled = True
    '        End If
    '    End If
    'End Sub


    Function getPaymentID() As Integer
        Dim Payment_ID As Integer
        'myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString'
        Dim dt As New DataTable
        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If


        Dim da As New OleDb.OleDbDataAdapter("Select Payment_ID" &
                                               " FROM Payment" &
                                            " ORDER BY Payment_ID DESC", myConnectiontoEmployeeInfo)
        da.Fill(dt)

        If dt.Rows.Count > 0 Then
            Payment_ID = dt.Rows(0).Item(0) + 1
        Else
            Payment_ID = 1
        End If
        Return Payment_ID

    End Function


    Private Sub BTNPAYMENT_Click(sender As Object, e As EventArgs) Handles BTNPAYMENT.Click
        Dim strStatus As String = "PROCESSED"

        If Not myConnectiontoEmployeeInfo.State = ConnectionState.Open Then
            myConnectiontoEmployeeInfo.Open()
        End If

        Dim access = New AccessToDatabase()

        If payment.Text = "" Then
            MsgBox("PLEASE ENTER AN AMOUNT!")
        Else
            If (IsNumeric(payment.Text)) Then
                Dim vpayment = Double.Parse(payment.Text)


                Dim change As Double = vpayment - Format(total_amount.Text, "currency")
                If vpayment >= total_amount.Text Then

                    access.insertToPaymentTable(myConnectiontoEmployeeInfo, getPaymentID, ADD_SALES.salesid, total_amount.Text, Format(vpayment, "currency"), Format(change, "currency"), Format(ADD_SALES.tax, "currency"), Format(ADD_SALES.discount, "currency"))
                    Me.Hide()
                    With ADD_SALES
                        .Hide()
                        .BTNFINALIZE.Enabled = False
                        .BTNCANCEL.Enabled = False
                        .btnVOID.Enabled = False
                        .BTNHOME.Enabled = True
                        .BTNNEWSALES.Enabled = True
                        .chickenimage.Visible = True
                        .ORDER_LIST.Items.Clear()
                        .sales_no.Text = Nothing
                        .totalAmount.Text = Nothing
                        .chkSeniorCitizen.Checked = False
                    End With
                    formReport.Show()
                Else
                    MsgBox("NOT ENOUGH MONEY!", MsgBoxStyle.Information)
                    payment.Clear()
                    payment.Focus()
                End If
            Else
                MsgBox("Please enter valid money.", MsgBoxStyle.Information)
            End If
        End If
    End Sub

    Private Sub PAYMENTFORM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnectiontoEmployeeInfo.ConnectionString = EmployeeConnString
    End Sub

End Class