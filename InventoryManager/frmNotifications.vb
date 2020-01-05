Imports System.Data.SqlClient

Public Class frmNotifications
    Private Sub frmNotifications_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadnotifications()
    End Sub

    Private Sub loadnotifications()
        ConnectTOSQLServer1()
        strSQL = "select * from vw_notifications order by NotifDate desc"
        cmd = New SqlCommand(strSQL, Connection)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim notifs As New DataSet()
        dataadapter.Fill(notifs, "vw_notifications")
        dgvNotifications.DataSource = notifs
        dgvNotifications.DataMember = "vw_notifications"
        DisConnectSQLServer()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class