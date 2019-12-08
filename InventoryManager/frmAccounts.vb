﻿Imports System.Data.SqlClient
Imports Microsoft.Office.Interop
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Public Class frmAccounts

    Private Property selectedRow As Integer
    Private ActiveCount, InactiveCount As Int32
    Private cond As String
    Private Sub frmAccounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call viewUserlist_reload()
    End Sub

    Private Sub frmAccounts_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        frmAccounts_Load(sender, e)
    End Sub

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        saveType = 1
        frmAccountNew.Show()
        logInfo = "Accessed Account Creation Form"
        Call RecordLog(logInfo)
        frmMenu.Enabled = False
    End Sub

    Private Sub viewUserlist_reload()
        Call ConnectTOSQLServer1()

        strSQL = "SELECT AccountID,AccountUsername,AccountFullname,AccountType,AccountStatus from tblAccounts " & cond
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim UserList As New DataSet()

        dataadapter.Fill(UserList, "tblAccounts")
        dgvUserList.DataSource = UserList
        dgvUserList.DataMember = "tblAccounts"

        strSQL = "select count(accountno) from tblAccounts where AccountStatus = 'ACTIVE'"
        Console.WriteLine()
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                ActiveCount = reader.GetInt32(0)
            Loop
            reader.NextResult()
        Loop
        reader.Close()

        strSQL = "select count(accountno) from tblAccounts where AccountStatus = 'INACTIVE'"
        Console.WriteLine()
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.HasRows
            Do While reader.Read()
                InactiveCount = reader.GetInt32(0)
            Loop
            reader.NextResult()
        Loop
        reader.Close()

        lblActiveCount.Text = ActiveCount
        lblInactiveCount.Text = InactiveCount
        Call DisConnectSQLServer()
    End Sub



    Private Sub btnUpdateAccount_Click(sender As Object, e As EventArgs) Handles btnUpdateAccount.Click
        saveType = 2
        logInfo = "Tried Updating AccountID# " & dgvUserList.Rows(selectedRow).Cells(0).Value() & "."
        Call RecordLog(logInfo)
        frmAccountNew.Show()
        lastTransID = dgvUserList.CurrentRow.Cells("idno").Value
        frmMenu.Enabled = False
    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellClick, dgvUserList.CellContentClick
        If (dgvUserList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
            If (dgvUserList.Rows(selectedRow).Cells(4).Value() = "ACTIVE") Then
                btnDeactivateAccount.Text = "Deactivate Account"
            Else
                btnDeactivateAccount.Text = "Activate Account"
            End If
        End If
    End Sub

    Private Sub btnResetAccount_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        If (selectedRow < 0) Then
            MsgBox("Please select an account first.", MsgBoxStyle.Information)
        Else
            Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, "J&A Inventory Manager")
            If ask = vbYes Then
                accountID = dgvUserList.Rows(selectedRow).Cells(0).Value()
                logInfo = "Reset AccountID# " & dgvUserList.Rows(selectedRow).Cells(0).Value() & "."
                Call RecordLog(logInfo)
                Call ResetAccount(accountID)
                MsgBox("Password has been reset to default. Please use admin12345.", MsgBoxStyle.Information, "J&A Inventory Manager")
            End If
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = "where AccountUsername like '%" & txtSearch.Text.Trim.Replace("-", "") & "%' or AccountLastname = '" & txtSearch.Text.Trim.Replace("-", "") & "' or AccountFirstname = '" & txtSearch.Text.Trim.Replace("-", "") & "'"
        Call viewUserlist_reload()
    End Sub



    Private Sub lblInactiveCount_Click_1(sender As Object, e As EventArgs) Handles lblInactiveCount.Click, Label2.Click, BunifuCards2.Click
        cond = " where AccountType = 'INACTIVE'"
        viewUserlist_reload()
    End Sub

    Private Sub BunifuCards1_Click(sender As Object, e As EventArgs) Handles lblActiveCount.Click, Label1.Click, BunifuCards1.Click
        cond = " where AccountType = 'ACTIVE'"
        viewUserlist_reload()
    End Sub

    Private Sub dgvUserList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUserList.CellDoubleClick
        If (dgvUserList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                accID = dgvUserList.Rows(selectedRow).Cells(0).Value()
                accname = dgvUserList.Rows(selectedRow).Cells(1).Value()
                Dim ab As New frmAccountLogs
                ab.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub btnExportUsers_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportExcel(dgvUserList)
    End Sub

    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs) Handles btnExportPdf.Click
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            ' declaration textbox2 to save file dialog name
            Dim txt As String = SaveFileDialog1.FileName & ".pdf"
            title = "Accounts List Report"
            Call ExporttoPDF(txt, dgvUserList)
        End If
    End Sub

    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub btnDeactivateAccount_Click(sender As Object, e As EventArgs) Handles btnDeactivateAccount.Click
        If (selectedRow < 0) Then
            MsgBox("Please select an account first.", MsgBoxStyle.Information, "J&A Inventory Manager")
        Else
            Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, "J&A Inventory Manager")
            If ask = vbYes Then
                accountID = dgvUserList.Rows(selectedRow).Cells(0).Value()
                Dim Status = dgvUserList.Rows(selectedRow).Cells(4).Value()
                If Status = "ACTIVE" Then
                    Call DeactivateAccount(accountID)
                    logInfo = "Deactivated AccountID# " & dgvUserList.Rows(selectedRow).Cells(0).Value() & "'s access."
                    Call RecordLog(logInfo)
                    MsgBox("Account has been deactivated.", MsgBoxStyle.Information, "J&A Inventory Manager")

                ElseIf Status = "INACTIVE" Then
                    Call ActivateAccount(accountID)
                    logInfo = "Activated AccountID# " & dgvUserList.Rows(selectedRow).Cells(0).Value() & "'s access."
                    Call RecordLog(logInfo)
                    MsgBox("Account has been reactivated.", MsgBoxStyle.Information, "J&A Inventory Manager")
                End If
                Call viewUserlist_reload()
            End If
        End If
    End Sub
End Class