Imports System.Data.SqlClient

Public Class frmAppointmentTransactions

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (Me.Width = 814) Then
            Me.Width = 1181
        Else
            Me.Width = 814
        End If
        getdata()
    End Sub
    Private Sub txtcontact1_OnValueChanged(sender As Object, e As EventArgs) Handles txtcontact1.OnValueChanged

        If (Len(txtcontact1.Text) > 9) Then
            ErrorProvider1.SetError(txtcontact1, "Invalid Number.")
            ErrorProvider1.SetIconPadding(txtcontact1, 5)
        Else
            ErrorProvider1.SetError(txtcontact1, "")
        End If
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

    Private Sub frmAppointmentTransactions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 814
        loadtext()
        dtpAppointmentDate.MinDate = Date.Today.AddDays(1)
        If appname = Nothing Then
            GroupBox1.Enabled = True
        Else
            GroupBox1.Enabled = False
        End If
        txtcontact1.Text = appcontact
        txtAddress.Text = appaddress
        txtName.Text = appname
        Console.WriteLine(appdate)
        dtpAppointmentDate.Value = appdate

        cboAppointmentTime.Text = apptime
        getdata()
    End Sub

    Private Sub getdata()
        Call ConnectTOSQLServer1()
        'strSQL = "select CustomerName,ContactNumber,Address from tblAppointment where AppointmentID = " & AppointmentID
        'cmd = New SqlCommand(strSQL, Connection)
        'reader = cmd.ExecuteReader
        'While reader.Read
        '    txtName.Text = reader.GetString(0)
        '    txtcontact1.Text = reader.GetString(1)
        '    txtAddress.Text = reader.GetString(2)
        'End While
        'reader.Close()
        strSQL = " select ServiceAvailedID,ServiceID, ServiceName,Emp_Fullname,ServicePrice from vw_ServiceAvailed where DataStatus = 'ACTIVE' and  TransactionID = " & AppointmentID
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ServiceAvailedList As New DataSet()
        dataadapter.Fill(ServiceAvailedList, "vw_ServiceAvailed")
        dgvServiceListing.DataSource = ServiceAvailedList
        dgvServiceListing.DataMember = "vw_ServiceAvailed"


        strSQL = "select ServiceID,ServiceName,ServicePrice,ServiceType,case when  ServiceID in (select ServiceID from vw_ItemCheck where Status = 'Not Available') then 'Not Available' else 'Available' end as Service_Availability from tblServices where ServiceStatus = 1 "
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim Appointments As New DataSet()
        dataadapter.Fill(Appointments, "tblServices")
        dgvReserveList.DataSource = Appointments
        dgvReserveList.DataMember = "tblServices"

        strSQL = "select ServiceID,ServiceName,ServicePrice,ServiceType,
case when  ServiceID in 
(select ServiceID from vw_ItemCheck where Status = 'Not Available') 
then 'Not Available' 
else 'Available' 
end as Service_Availability 
from tblServices 
where ServiceStatus = 1 and ServiceID not in (select ServiceID from vw_appointmentavailed where AppointmentID = " & AppointmentID & ")"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ServiceNotAvailed As New DataSet()
        dataadapter.Fill(ServiceNotAvailed, "tblServices")
        dgvOfferings.DataSource = ServiceNotAvailed
        dgvOfferings.DataMember = "tblServices"


        strSQL = "select ItemID,ItemBrand,ItemDescription,sum(abs(ConsumedNumber)) as Consumed from vw_TransactionList a 
inner join vw_ServiceAvailed b on a.[JA-Transaction] = b.TransactionID
inner join vw_ServiceConsumables c on c.ServiceID = b.ServiceID
where DataStatus = 'ACTIVE' and b.TransactionID = " & lastTransID & "group by ItemID,ItemBrand,ItemDescription"
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim consumedlist As New DataSet()
        dataadapter.Fill(consumedlist, "vw_TransactionList")
        dgvItemConsumed.DataSource = consumedlist
        dgvItemConsumed.DataMember = "vw_TransactionList"


        If dgvItemConsumed.Rows.Count = 0 Then
            labelConsumed.Visible = True
        Else
            labelConsumed.Visible = False
        End If

        Dim sum As Double = 0

        For i As Integer = 0 To dgvServiceListing.Rows.Count - 1
            sum += Convert.ToDouble(dgvServiceListing.Rows(i).Cells("service_price").Value)
        Next


        lblTotal.Text = sum.ToString()
        If (dgvServiceListing.Rows.Count = 0) Then
            lblShownone.Visible = True
        Else
            lblShownone.Visible = False
        End If


        Call DisConnectSQLServer()
    End Sub

    Private Sub dgvReserveList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserveList.CellDoubleClick
        If (dgvReserveList.Rows.Count > 0) Then
            If dgvReserveList.CurrentRow.Cells("status").Value <> "Not Available" Then
                servicecheckoutid = dgvReserveList.CurrentRow.Cells("serv_id").Value
                txtName.Enabled = False
                transactionidnum = 2
                Dim ab As New frmServiceDialog
                ab.ShowDialog()
            Else
                MsgBox("Service Unavailable due to insufficient inventory requirements.", MsgBoxStyle.Critical, Application.ProductName)
            End If
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSasve.Click
        If (dgvServiceListing.Rows.Count > 0) Then
            Dim ask = MsgBox("Are you sure you want to proceed and create this transaction?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                Me.Close()
            End If
        Else
            MsgBox("Please select atleast one service.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvServiceListing.Rows.Count <> 0 Then
            If dgvServiceListing.CurrentCell.RowIndex > -1 Then
                Dim ask = MsgBox("Are you sure you want to remove this service?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
                If ask = vbYes Then
                    Call RemoveService(dgvServiceListing.CurrentRow.Cells("serv_availid").Value)
                End If
            Else
                MsgBox("Please choose a service to be removed.", MsgBoxStyle.Information, Application.ProductName)
            End If
        Else
            MsgBox("Please add service first.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs)
        getdata()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        getdata()
    End Sub


    Private Sub frmAppointmentTransactions_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        frmAppointmentTransactions_Load(sender, e)
    End Sub

    Private Sub btnSaveTransaction_Click(sender As Object, e As EventArgs) Handles btnSaveTransaction.Click
        If txtName.Text <> "" And txtcontact1.Text <> "" And txtAddress.Text <> "" Then
            Dim ask = MsgBox("Are you sure you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                Dim appointdate = (dtpAppointmentDate.Text + " " + cboAppointmentTime.Text)
                AddAppointment_V2(appointdate, txtName.Text, txtcontact1.Text, txtAddress.Text)

                GroupBox1.Enabled = False
                MsgBox("Please select services.")
            End If
        End If
    End Sub

    Private Sub dgvReserveList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvReserveList.CellContentClick

    End Sub

    Private Sub frmAppointmentTransactions_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
        appname = Nothing
        appaddress = Nothing
        appdate = Nothing
        apptime = Nothing
        appcontact = Nothing
    End Sub
End Class