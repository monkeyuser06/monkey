Imports System.Data.SqlClient
Imports System.Media
Imports System.Net.Mail
Imports System.Text.RegularExpressions

Public Class frmAppointmentsManager
    Dim flag1, flag2, flag3, flag4, flag5 As Boolean
    Dim charactersAllowed As String = "1234567890"
    Private Sub frmAppointmentsManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadtext()
        loadServiceList()
        dtpAppointmentDate.MinDate = Date.Today.AddDays(1)
    End Sub

    Private Sub loadtext()
        Call ConnectTOSQLServer1()
        strSQL = " select distinct CustomerName from tblAppointment
 union 
 select distinct CustomerName from tblTransactions
 where CustomerName <>''"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim namelist As New DataSet()
        dataadapter.Fill(namelist, "tblTransactions")
        Dim col As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To namelist.Tables(0).Rows.Count - 1
            col.Add(namelist.Tables(0).Rows(i)("CustomerName").ToString())
        Next
        txtName.AutoCompleteCustomSource = col
        Call DisConnectSQLServer()
    End Sub
    Private Sub loadServiceList()
        Call ConnectTOSQLServer1()
        strSQL = "select distinct ServiceID,ServiceName from tblServices"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim SearchList As New DataSet()
        dataadapter.Fill(SearchList, "tblServices")
        dgvServiceList.DataSource = SearchList
        dgvServiceList.DataMember = "tblServices"
        Call DisConnectSQLServer()
    End Sub

    Private Sub txtcontact1_OnValueChanged(sender As Object, e As EventArgs) Handles txtcontact1.OnValueChanged

        If (Len(txtcontact1.Text) > 9) Then
            ErrorProvider1.SetError(txtcontact1, "Invalid Number.")
            ErrorProvider1.SetIconPadding(txtcontact1, 5)
        Else
            ErrorProvider1.SetError(txtcontact1, "")
        End If
    End Sub

    Private Sub validationtext()
        If (txtName.Text.Trim = "") Then
            ErrorProvider1.SetError(txtName, "Name is required.")
            ErrorProvider1.SetIconPadding(txtName, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtName, "")
        End If

        Dim checkedCount = dgvServiceList.Rows.
                                         Cast(Of DataGridViewRow)().
                                         Where(Function(row) Not row.IsNewRow).
                                         Count(Function(row) CBool(row.Cells(0).Value))

        Select Case checkedCount
            Case 0
                'No rows are checked.
                ErrorProvider1.SetError(Label2, "Atleast one service is required.")
                ErrorProvider1.SetIconPadding(Label2, 5)
                flag2 = False
            Case Else
                'More than one row is checked.
                ErrorProvider1.SetError(Label2, "")
        End Select
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Initializeflag()
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Initializeflag()
        validationtext()
        If (flag1 = False OrElse flag2 = False) Then
            MsgBox("Please complete all errors.")
            Exit Sub
        End If

        Dim ask = MsgBox("Do you want to save appointment?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            Dim appointdate = (dtpAppointmentDate.Text + " " + cboTime.Text)
            '       Dim oDate As DateTime = DateTime.ParseExact(appointdate, "MM/dd/yyyy HH:mm tt", Nothing)
            Call AddAppointment(txtName.Text.Trim, "+639" & txtcontact1.Text.Trim, txtAddress.Text.Trim, appointdate)
            Call ConnectTOSQLServer1()
            Dim inserted As Integer = 0
            For Each row As DataGridViewRow In dgvServiceList.Rows
                Dim isSelected As Boolean = Convert.ToBoolean(row.Cells("checkbox").Value)

                If isSelected Then
                    strSQL = "insert into tblAppointmentService(AppointmentID,ServiceID)values(@id,@servid)"
                    cmd = New SqlCommand(strSQL, Connection)
                    cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newProdID
                    cmd.Parameters.AddWithValue("@servid", row.Cells("Serv_id").Value)
                    cmd.ExecuteNonQuery()
                    inserted += 1
                End If
            Next
            frmMenu.Enabled = True
            Me.Close()
            Call DisConnectSQLServer()

        End If
    End Sub

    Private Sub frmAppointmentsManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        frmMenu.Enabled = True
    End Sub

    Private Sub txtcontact1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                ErrorProvider1.SetError(Me, "")
            End If
        End If
    End Sub
End Class