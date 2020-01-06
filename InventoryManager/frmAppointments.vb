Imports System.Data.SqlClient

Public Class frmAppointments

    Dim cond = ""
    Private Sub btnAddAppointment_Click(sender As Object, e As EventArgs) Handles btnAddAppointment.Click
        saveType = 1
        frmMenu.Enabled = False
        Dim ab As New frmAppointmentsManager
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
        strSQL = "update tblAppointment set AppointmentStatus = 'Expired' where AppointmentDate < getdate()"
        cmd = New SqlCommand(strSQL, Connection)
        cmd.ExecuteNonQuery()
        Call DisConnectSQLServer()
    End Sub

    Private Sub LoadDatagrid()
        Call ConnectTOSQLServer1()
        strSQL = "select * from (
SELECT AppointmentID, cast(CONVERT(Varchar,appointmentdate,101) as Date) as Date, CONVERT(varchar(15)
,CAST(CONVERT(VARCHAR(8),AppointmentDate,108) AS time),100) as [Time], CustomerName, ContactNumber, Address,
[Service/s Availed] = STUFF
                         ((SELECT DISTINCT ', ' + ServiceName
                          FROM            vw_AppointmentAvailed b
                          WHERE        b.AppointmentID = a.AppointmentID FOR XML PATH('')), 1, 2, '')
, case when AppointmentStatus = 'Expired' then 'Lapsed' else AppointmentStatus end as AppointmentStatus 
FROM tblAppointment a) f where [Service/s Availed] is not null   " & cond & " order by Date desc"
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim Appointments As New DataSet()
        dataadapter.Fill(Appointments, "f")
        dgvAppointments.DataSource = Appointments
        dgvAppointments.DataMember = "f"

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
                If dgvAppointments.CurrentRow.Cells("status").Value = "Pending" Then
                    Dim ask = MsgBox("Are you sure you want to proceed this to transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
                    If ask = vbYes Then
                        translabel = 2
                        AppointmentID = dgvAppointments.CurrentRow.Cells("id").Value
                        Dim ab As New frmServiceCheckout
                        ab.ShowDialog()
                        Me.Close()
                    End If
                ElseIf (dgvAppointments.CurrentRow.Cells("status").Value = "Done") Then
                    MsgBox("Appointment is already " & dgvAppointments.CurrentRow.Cells("status").Value)
                ElseIf (dgvAppointments.CurrentRow.Cells("status").Value = "Expired") Then
                    MsgBox("Appointment is already " & dgvAppointments.CurrentRow.Cells("status").Value)
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


End Class