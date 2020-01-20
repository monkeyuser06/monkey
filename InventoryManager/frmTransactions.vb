Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class frmTransactions
    Private fForm As frmTransactionManager = New frmTransactionManager()
    Dim cond As String
    Private str1 As String
    Private selectedRow As Integer
    Private transID As Integer

    Private Sub frmTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvTransactionsList.AutoGenerateColumns = False
        Call viewTransactions()
    End Sub

    Private Sub btnAddTransactions_Click(sender As Object, e As EventArgs) Handles btnAddTransactions.Click
        Dim ab As New frmServiceCheckout
        ab.ShowDialog()
        lastTransID = Nothing
        saveType1 = 1
    End Sub


    Private Sub viewTransactions()
        Call ConnectTOSQLServer1()
        strSQL = "
SELECT        [JA-Transaction], TransactionNumber, CONVERT(varchar, [Date/Time], 110) AS [Date], Format([Date/Time], 'hh:mm tt') AS [Time],
 CustomerName, [Service/s Availed] = STUFF
                             ((SELECT DISTINCT ', ' + [ServiceName]
                                 FROM            vw_ServiceAvailed b
                                 WHERE        b.TransactionID = a.[JA-Transaction] FOR XML PATH('')), 1, 2, '')	,ISNULL(Price,'0') as [Amount Collected] , TransactionStatus
FROM            (SELECT        [JA-Transaction], TransactionNumber, [Date/Time], CustomerName,case when TransactionStatus = 'For Appointment' then 'Pending' when TransactionStatus = 'Appointment Done' then 'Done' else TransactionStatus end as TransactionStatus,Price
							
                          FROM            tblTransactions ) a 
						  where TransactionStatus NOT IN('For Appointment', 'Expired')
						  order by [Date/Time] desc "

        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim TransactionList As New DataSet()
        dataadapter.Fill(TransactionList, "vw_TransactionList")
        dgvTransactionsList.DataSource = TransactionList
        dgvTransactionsList.DataMember = "vw_TransactionList"



        Call DisConnectSQLServer()
    End Sub

    Private Sub frmTransactions_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        frmTransactions_Load(sender, e)
    End Sub

    Private Sub dgvTransactionsList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTransactionsList.CellClick
        If (dgvTransactionsList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                lastTransID = 3

                lastTransID = CInt(Strings.Right(dgvTransactionsList.Rows(selectedRow).Cells(1).Value, 6))
                Console.WriteLine(lastTransID)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnExportExcel_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportExcel(dgvTransactionsList)
    End Sub


    Private Sub dtpTransactionDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpTransactionDate.ValueChanged
        dtpDateTo.MinDate = dtpTransactionDate.Value
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Call viewTransactions()
    End Sub

    Private Sub frmTransactions_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        viewTransactions()
    End Sub

    Private Sub btnEditTransaction_Click(sender As Object, e As EventArgs) Handles btnEditTransaction.Click
        If (dgvTransactionsList.CurrentRow.Cells("status").Value() <> "Done") Then
            Dim ab As New frmServiceCheckout
            ab.ShowDialog()
            saveType1 = 2
            transactionidnum = 1
            lastTransID = dgvTransactionsList.CurrentRow.Cells("idno").Value
            Console.WriteLine(lastTransID)
        Else
            MsgBox("Transaction has been completed. Modification is no longer permitted.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

    Private Sub btnCompleteTransaction_Click(sender As Object, e As EventArgs) Handles btnCompleteTransaction.Click
        If selectedRow >= 0 Then
            If dgvTransactionsList.Rows(selectedRow).Cells("status").Value <> "Done" Then
                Dim ask = MsgBox("Do you want to complete this transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
                If ask = vbYes Then
                    CompleteTransaction(CInt(Strings.Right(dgvTransactionsList.Rows(selectedRow).Cells(1).Value, 6)))
                    MsgBox("Successfully completed transaction.", MsgBoxStyle.Information, Application.ProductName)
                    viewTransactions()
                End If
            Else
                MsgBox("Transaction is already completed.", MsgBoxStyle.Information, Application.ProductName)
            End If
        End If
    End Sub
End Class