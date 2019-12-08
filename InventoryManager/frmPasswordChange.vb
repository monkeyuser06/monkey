﻿Imports System.Data.SqlClient

Public Class frmPasswordChange

    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean


    Private Sub txtPassword2_KeyDown(sender As Object, e As KeyEventArgs)
        If (e.KeyCode = Keys.Enter) Then
            Call btnUpdatePassword_Click(sender, e)
        End If
    End Sub


    Private Sub textvalidation()
        If txtAnswer.Text.Trim = "" Then
            ErrorProvider1.SetError(txtAnswer, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtAnswer, 3)
            flag5 = False
        ElseIf txtAnswer.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then
            ErrorProvider1.SetError(txtAnswer, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtAnswer, 3)
            flag5 = False
        Else
            ErrorProvider1.SetError(txtAnswer, "")
        End If

        If cboSecretQuestion.SelectedIndex < 0 Then
            ErrorProvider1.SetError(cboSecretQuestion, "Please select a question.")
            ErrorProvider1.SetIconPadding(cboSecretQuestion, 3)
            flag4 = False
        Else
            ErrorProvider1.SetError(cboSecretQuestion, "")
        End If
    End Sub

    Private Sub btnUpdatePassword_Click(sender As Object, e As EventArgs) Handles btnUpdatePassword.Click
        Dim ask = MsgBox("Are you sure you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            InitializeFlags()
            PasswordValidation()
            If (flag6 = False Or flag7 = False Or flag1 = False) Then
                MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                Exit Sub
            End If

            Call PasswordChange(txtPassword1.Text, cboSecretQuestion.SelectedValue, txtAnswer.Text)
            MsgBox("Password has been successfully changed!", MsgBoxStyle.Information, Application.ProductName)
            logInfo = "Changed password."
            Call RecordLog(logInfo)
            frmMenu.Show()
            Me.Close()
        End If
    End Sub

    Private Sub frmPasswordChange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAccountID.Text = login_id
        lblName.Text = login_name
        lblRole.Text = login_accesstype
        lblUsername.Text = login_username
        Call ConnectTOSQLServer1()
        strSQL = "select * from tblSecretQuestion"
        Dim command As New SqlCommand(strSQL, Connection)
        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)



        cboSecretQuestion.DataSource = table
        cboSecretQuestion.DisplayMember = "Question"
        cboSecretQuestion.ValueMember = "QuestionID"
        Call DisConnectSQLServer()
    End Sub
    Private Sub InitializeFlags()

        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
        flag6 = True
        flag7 = True
        flag8 = True

    End Sub
    Private Sub PasswordValidation()
        If txtPassword1.Text.Trim = "" Then
            ErrorProvider1.SetError(txtPassword1, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword1, 3)
            flag6 = False
        ElseIf txtPassword1.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then
            ErrorProvider1.SetError(txtPassword1, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword1, 3)
            flag6 = False
        ElseIf txtPassword1.Text.Length < 8 Then
            ErrorProvider1.SetError(txtPassword1, "Password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtPassword1, 3)
            flag6 = False
        ElseIf txtPassword1.Text = "admin12345" Then
            ErrorProvider1.SetError(txtPassword1, "Password should not be the same as default password.")
            ErrorProvider1.SetIconPadding(txtPassword1, 3)
            flag6 = False
        Else
            ErrorProvider1.SetError(txtPassword1, "")
        End If

        If txtPassword2.Text.Trim = "" Then
            ErrorProvider1.SetError(txtPassword2, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword2, 3)
            flag7 = False
        ElseIf txtPassword2.Text.IndexOfAny(restrictedCharactersForPassword) > -1 Then
            ErrorProvider1.SetError(txtPassword2, "Special characters and spaces are not allowed.")
            ErrorProvider1.SetIconPadding(txtPassword2, 3)
            flag7 = False
        ElseIf txtPassword2.Text.Length < 8 Then
            ErrorProvider1.SetError(txtPassword2, "Password must be at least 8 characters.")
            ErrorProvider1.SetIconPadding(txtPassword2, 3)
            flag7 = False
        ElseIf txtPassword2.Text = "admin12345" Then
            ErrorProvider1.SetError(txtPassword2, "Password should not be the same as default password.")
            ErrorProvider1.SetIconPadding(txtPassword2, 3)
            flag7 = False

        Else
            ErrorProvider1.SetError(txtPassword2, "")
        End If


    End Sub
End Class