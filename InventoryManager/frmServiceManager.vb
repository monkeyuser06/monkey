Imports System.Data.SqlClient
Imports System.Linq

Public Class frmServiceManager

    Dim intValue As Integer
    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean

    Private Sub frmServiceManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
    End Sub

    Private Sub frmServiceManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lastTransID <> Nothing Then
            loadvalues()
        End If
    End Sub

    Private Sub loadvalues()
        Call ConnectTOSQLServer1()
        strSQL = "select ServiceName,ServicePrice,ServiceType,ServiceStatus from tblServices where ServiceID = " & lastTransID
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        Console.WriteLine(strSQL)
        While reader.Read()
            txtServiceName.Text = reader.GetString(0)
            txtServicePrice.Text = reader.GetDecimal(1)
            If (reader.GetString(2) = "Hair") Then
                rdoBody.Checked = True
            ElseIf (reader.GetString(2) = "Face") Then
                rdoFace.Checked = True
            ElseIf (reader.GetString(2) = "Body") Then
                rdoBody.Checked = True
            ElseIf (reader.GetString(2) = "Nails") Then
                rdoNails.Checked = True
            End If
            If reader.GetBoolean(3) = 1 Then
                rdoActive.Checked = True
            Else
                rdoInactive.Checked = True
            End If
        End While
        Call DisConnectSQLServer()
    End Sub
    Private Sub ServiceNameValidation()
        If txtServiceName.Text.Trim = "" Then
            ErrorProvider1.SetError(txtServiceName, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtServiceName, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtServiceName, "")
            ErrorProvider1.SetIconPadding(txtServiceName, 5)
        End If
    End Sub

    Private Sub PriceValidation()
        If txtServicePrice.Text.Trim = "" Then
            ErrorProvider1.SetError(txtServicePrice, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtServicePrice, 5)
            flag2 = False
        ElseIf Not (Integer.TryParse(txtServicePrice.Text, intValue)) Then
            ErrorProvider1.SetError(txtServicePrice, "Numeric characters only.")
            ErrorProvider1.SetIconPadding(txtServicePrice, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtServicePrice, "")
            ErrorProvider1.SetIconPadding(txtServicePrice, 5)
        End If
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


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InitializeFlags()
        ServiceNameValidation()
        PriceValidation()
        If flag1 = False OrElse flag2 = False Then
            Exit Sub
        End If
        Dim ask = MsgBox("Are you sure you want to save this service?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            If lastTransID = Nothing Then
                WhatRadioIsSelected(panelServiceStatus)
                Call AddService(txtServiceName.Text, txtServicePrice.Text, WhatRadioIsSelected(panelServiceStatus), WhatRadioIsSelected(panelServiceType))
                MsgBox("Successfully created service.")
                frmMenu.Enabled = True
                Me.Close()
            Else
                Call UpdateService(txtServiceName.Text, txtServicePrice.Text, WhatRadioIsSelected(panelServiceStatus), WhatRadioIsSelected(panelServiceType))
                MsgBox("Successfully created service.")
                frmMenu.Enabled = True
                Me.Close()
            End If
        End If
    End Sub

    Private Function WhatRadioIsSelected(ByVal grp As Panel) As String
        Dim rbtn As RadioButton
        Dim rbtnName As String = String.Empty
        Try
            Dim ctl As Control
            For Each ctl In grp.Controls
                If TypeOf ctl Is RadioButton Then
                    rbtn = DirectCast(ctl, RadioButton)
                    If rbtn.Checked Then
                        rbtnName = rbtn.Text
                        Exit For
                    End If
                End If
            Next
        Catch ex As Exception
            Dim stackframe As New Diagnostics.StackFrame(1)
            Throw New Exception("An error occurred in routine, '" & stackframe.GetMethod.ReflectedType.Name & "." & System.Reflection.MethodInfo.GetCurrentMethod.Name & "'." & Environment.NewLine & "  Message was: '" & ex.Message & "'")
        End Try
        Return rbtnName
    End Function

End Class