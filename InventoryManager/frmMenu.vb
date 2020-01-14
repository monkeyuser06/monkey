﻿Public Class frmMenu

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        logInfo = "Accessed the Menu"
        Call RecordLog(logInfo)
        lblName.Text = login_name
        If (login_accesstype = "ADMINISTRATOR") Then
            btnAccounts.Enabled = True
            btnDashboard.Enabled = True
            btnEmployeeList.Enabled = True
            btnInventory.Enabled = True
            btnServices.Enabled = True
            btnTransactions.Enabled = True
            btnExit.Enabled = True
        ElseIf (login_accesstype = "TRANSACTIONS") Then
            btnAccounts.Enabled = False
            btnDashboard.Enabled = True
            btnEmployeeList.Enabled = False
            btnInventory.Enabled = False
            btnServices.Enabled = False
            btnTransactions.Enabled = True
            btnExit.Enabled = True
        ElseIf (login_accesstype = "INVENTORY") Then
            btnAccounts.Enabled = False
            btnDashboard.Enabled = True
            btnEmployeeList.Enabled = False
            btnInventory.Enabled = True
            btnServices.Enabled = False
            btnTransactions.Enabled = False
            btnExit.Enabled = True
        End If
        btnDashboard_Click(sender, e)
        logInfo = "Accessed Dashboard Panel"
        Call RecordLog(logInfo)
        Call btnAccounts_EnabledChanged()
    End Sub

    Private Sub OpenPanel(ByVal Childform As Object)
        If panelMenu.Controls.Count > 0 Then
            panelMenu.Controls.RemoveAt(0)
        End If
        Dim fh As Form = TryCast(Childform, Form)
        fh.TopLevel = False
        fh.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        fh.Dock = DockStyle.Fill
        panelMenu.Controls.Add(fh)
        panelMenu.Tag = fh
        fh.Show()
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        lblAccounts.ForeColor = Color.Red
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblApp.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black
        logInfo = "Accessed Accounts Panel"
        Call RecordLog(logInfo)
        OpenPanel(New frmAccounts)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Red
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black
        lblApp.ForeColor = Color.Black
        logInfo = "Accessed Inventory Panel"
        Call RecordLog(logInfo)
        OpenPanel(New frmInventory)
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Red
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblApp.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black
        logInfo = "Accessed Transactions Panel"
        Call RecordLog(logInfo)
        OpenPanel(New frmTransactions)
    End Sub

    Private Sub btnEmployeeList_Click(sender As Object, e As EventArgs) Handles btnEmployeeList.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Red
        lblDashboard.ForeColor = Color.Black
        lblApp.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black
        logInfo = "Accessed Employee List Panel"
        Call RecordLog(logInfo)
        OpenPanel(New frmEmployeeManager)
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ''lblAccounts.ForeColor = Color.Black
        ''lblInventory.ForeColor = Color.Black
        ''lblTransactions.ForeColor = Color.Black
        ''lblEmployees.ForeColor = Color.Black
        ''lblDashboard.ForeColor = Color.Red
        ''lblServices.ForeColor = Color.Black
        ''lblApp.ForeColor = Color.Black
        ''logInfo = "Accessed Dashboard Panel"
        ''Call RecordLog(logInfo)
        ''OpenPanel(New frmDashboard)
        Dim webAddress As String = "http://localhost:8080/ja/?id=" & login_id
        Process.Start(webAddress)
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs)
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblApp.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black
        logInfo = "Accessed Settings Panel"
        Call RecordLog(logInfo)
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblServices.ForeColor = Color.Red
        lblApp.ForeColor = Color.Black
        logInfo = "Accessed Services Panel"
        Call RecordLog(logInfo)
        OpenPanel(New frmServices)
    End Sub

    Private Sub btnAccounts_EnabledChanged()
        If (btnAccounts.Enabled = False) Then
            btnAccounts.Image = btnAccounts.ErrorImage
        End If
        If (btnDashboard.Enabled = False) Then
            btnDashboard.Image = btnAccounts.ErrorImage
        End If
        If (btnEmployeeList.Enabled = False) Then
            btnEmployeeList.Image = btnEmployeeList.ErrorImage
        End If
        If (btnInventory.Enabled = False) Then
            btnInventory.Image = btnInventory.ErrorImage
        End If
        If (btnServices.Enabled = False) Then
            btnServices.Image = btnServices.ErrorImage
        End If
        If (btnTransactions.Enabled = False) Then
            btnTransactions.Image = btnTransactions.ErrorImage
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = Now.ToLongDateString
        lblTime.Text = TimeString
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblApp.Click

    End Sub

    Private Sub btnAppointment_Click(sender As Object, e As EventArgs) Handles btnAppointment.Click
        lblAccounts.ForeColor = Color.Black
        lblInventory.ForeColor = Color.Black
        lblTransactions.ForeColor = Color.Black
        lblEmployees.ForeColor = Color.Black
        lblDashboard.ForeColor = Color.Black
        lblServices.ForeColor = Color.Black
        lblApp.ForeColor = Color.Red
        logInfo = "Accessed Appointments Panel"
        Call RecordLog(logInfo)
        OpenPanel(New frmAppointments)
    End Sub

    Private Sub lblServices_Click(sender As Object, e As EventArgs) Handles lblServices.Click

    End Sub

    Private Sub lblInventory_Click(sender As Object, e As EventArgs) Handles lblInventory.Click

    End Sub
End Class