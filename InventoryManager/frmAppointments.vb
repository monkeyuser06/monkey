Imports System.Data.SqlClient

Public Class frmAppointments

    Dim cond = ""
    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        saveType = 1
        AppointmentID = Nothing
        frmMenu.Enabled = False
        Dim ab As New frmAppointmentTransactions
        ab.ShowDialog()
    End Sub


    'Private Sub btnEditAppointment_Click(sender As Object, e As EventArgs) Handles btnEditAppointment.Click
    '    saveType = 2
    '    frmMenu.Enabled = False
    '    Dim ab As New frmAppointmentsManager
    '    ab.ShowDialog()
    'End Sub

    Private Sub frmAppointments_Load(sender As Object, e As EventArgs) Handles Me.Load
        cond = " and Date = '" & dtpAppointdate.Value.ToString("MM/dd/yyyy") & "'"
        ExpiredAppointments()
        LoadDatagrid()
    End Sub

    Private Sub ExpiredAppointments()
        Call ConnectTOSQLServer1()
        strSQL = "update tblTransactions set TransactionStatus = 'Expired' where [Date/Time] < getdate() and TransactionStatus = 'For Appointment'"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Private Sub LoadDatagrid()
        Call ConnectTOSQLServer1()
        strSQL = "SELECT        [JA-Transaction], CONVERT(varchar, [Date/Time], 101) AS [Date], Format([Date/Time], 'hh:mm tt') AS [Time], 
 CustomerName,Address,ContactNumber, [Service/s Availed] = STUFF
                             ((SELECT DISTINCT ', ' + [ServiceName]
                                 FROM            vw_ServiceAvailed b
                                 WHERE        b.TransactionID = a.[JA-Transaction] FOR XML PATH('')), 1, 2, '')	 , TransactionStatus
FROM            (SELECT        [JA-Transaction], TransactionNumber,Address,ContactNumber, [Date/Time], CustomerName, TransactionStatus,Price
							
                          FROM            tblTransactions where TransactionStatus = 'For Appointment') a 
						  order by [Date/Time] desc"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim Appointments As New DataSet()
        dataadapter.Fill(Appointments, "a")
        dgvAppointments.DataSource = Appointments
        dgvAppointments.DataMember = "a"

        If (dgvAppointments.Rows.Count > 0) Then
            lblShow.Visible = False
        Else
            lblShow.Visible = True
        End If
        Call DisConnectSQLServer()
    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = " and CustomerName like '%" & txtSearchServ.Text & "%'"
        LoadDatagrid()
    End Sub


    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If dgvAppointments.Rows.Count > 0 Then
            If dgvAppointments.CurrentRow.Index > -1 Then
                If dgvAppointments.CurrentRow.Cells("status").Value = "For Appointment" Then
                    Dim ask = MsgBox("Are you sure you want to proceed this to transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
                    AppointmentID = dgvAppointments.CurrentRow.Cells(0).Value
                    AcceptAppointment_V2()
                    frmMenu.Enabled = False
                    frmMenu.Enabled = True

                End If
            End If
        End If
    End Sub

    Private Sub frmAppointments_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        LoadDatagrid()
    End Sub

    Private Sub dtpAppointdate_ValueChanged(sender As Object, e As EventArgs) Handles dtpAppointdate.ValueChanged
        CheckBox1.Checked = False
        cond = " and Date = '" & dtpAppointdate.Value.ToString("MM/dd/yyyy") & "'"
        LoadDatagrid()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked <> True Then
            cond = " and Date = '" & dtpAppointdate.Value.ToString("MM/dd/yyyy") & "'"
            LoadDatagrid()
        Else
            cond = ""
        End If
        LoadDatagrid()
    End Sub

    Private Sub btnEditAppointment_Click(sender As Object, e As EventArgs) Handles btnEditAppointment.Click
        AppointmentID = dgvAppointments.CurrentRow.Cells(0).Value
        Dim ab As New frmAppointmentTransactions
        ab.ShowDialog()
        appname = dgvAppointments.CurrentRow.Cells(3).Value
        appcontact = dgvAppointments.CurrentRow.Cells(5).Value
        appaddress = dgvAppointments.CurrentRow.Cells(4).Value
        appdate = dgvAppointments.CurrentRow.Cells(1).Value().ToString("MM/dd/yyyy")
        apptime = dgvAppointments.CurrentRow.Cells(2).Value
    End Sub

    Private Sub dgvAppointments_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAppointments.CellClick
        Console.WriteLine(CStr(dgvAppointments.CurrentRow.Cells(1).Value()) + " " + CStr(dgvAppointments.CurrentRow.Cells(2).Value()))
    End Sub
End Class