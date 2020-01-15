Imports System.Data.SqlClient

Public Class frmServiceDialog
    Dim type, hair, nail, face, body As String

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If cboEmployeeAssigned.SelectedIndex > -1 Then
            Dim ask = MsgBox("Do you want to continue adding this service?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                Console.WriteLine(lastTransID)
                Dim transic = IIf(transactionidnum = 1, lastTransID, AppointmentID)
                Console.WriteLine(lastTransID)

                Call AddServiceAvailed(transic, servicecheckoutid, cboEmployeeAssigned.SelectedValue)
                Me.Close()
            End If
        Else
            MsgBox("Please select employee first.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub



    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub frmServiceDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loaditems()
        loademployees()
        cboEmployeeAssigned.SelectedIndex = -1
    End Sub

    Private Sub loaditems()
        Call ConnectTOSQLServer1()
        strSQL = "select ServiceName,ServicePrice,ServiceType from tblServices where ServiceStatus = 1 and ServiceID = " & servicecheckoutid
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        While reader.Read()
            lblServicename.Text = reader.GetString(0)
            lblServicePrice.Text = CStr(reader.GetDecimal(1))
            type = reader.GetString(2)
        End While
        reader.Close()
        Call DisConnectSQLServer()
    End Sub
    Private Sub loademployees()
        Call ConnectTOSQLServer1()
        Dim cond As String = ""
        If (type.ToUpper = "HAIR") Then
            cond = "where Exp_Hair = 1"
        ElseIf (type.ToUpper = "FACE") Then
            cond = "where Exp_Face = 1"
        ElseIf (type.ToUpper = "NAILS") Then
            cond = "where Exp_Nail = 1"
        ElseIf (type.ToUpper = "BODY") Then
            cond = "where Exp_Body = 1"
        End If
        strSQL = "select Emp_Fullname,EmployeeID from tblEmployee " & cond
        Dim da2 As New SqlDataAdapter(strSQL, Connection)
        Dim table2 As New DataTable()
        da2.Fill(table2)
        cboEmployeeAssigned.DataSource = New BindingSource(table2, Nothing)
        cboEmployeeAssigned.DisplayMember = "Emp_Fullname"
        cboEmployeeAssigned.ValueMember = "EmployeeID"
        Call DisConnectSQLServer()
    End Sub

End Class