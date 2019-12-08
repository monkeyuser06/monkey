Imports System.Data.SqlClient

Public Class frmServiceCheckout
    Private cond As String
    Private flag1, flag2 As Boolean
    Private selectedRow As Integer


    Private Sub frmServiceCheckout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadservicelist()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = "and ServiceName like '%" & txtSearchServ.Text.Trim.Replace("-", "") & "%'"
        loadservicelist()
    End Sub

    Public Sub loadservicelist()
        Call ConnectTOSQLServer1()
        strSQL = "select ServiceID,ServiceName,ServicePrice,ServiceType,case when  ServiceID in (select ServiceID from vw_ItemCheck where Status = 'Not Available') then 'Not Available' else 'Available' end as Service_Availability from tblServices where ServiceStatus = 1 " & cond
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim SearchList As New DataSet()
        dataadapter.Fill(SearchList, "tblServices")
        dgvSearchService.DataSource = SearchList
        dgvSearchService.DataMember = "tblServices"
        Console.WriteLine(strSQL)

        strSQL = " select ServiceAvailedID,ServiceID, ServiceName,Emp_Fullname,ServicePrice from vw_ServiceAvailed where DataStatus = 'ACTIVE' and  TransactionID = " & lastTransID
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ServiceAvailedList As New DataSet()
        dataadapter.Fill(ServiceAvailedList, "vw_ServiceAvailed")
        dgvServiceListing.DataSource = ServiceAvailedList
        dgvServiceListing.DataMember = "vw_ServiceAvailed"
        Console.WriteLine(strSQL)

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
        If lastTransID <> Nothing Then
            strSQL = "select ItemID,ItemBrand,ItemDescription,case when ContainerType = 'Bottle' then CONCAT(Consumed,' ml') else CONCAT(Consumed,' Sachets') end as Consumed  from (
select c.ItemID,c.ItemBrand,c.ItemDescription,sum(abs(ConsumedNumber)) as Consumed, ContainerType from vw_TransactionList a 
inner join vw_ServiceAvailed b on a.[JA-Transaction] = b.TransactionID
inner join vw_ServiceConsumables c on c.ServiceID = b.ServiceID
inner join tblInventory d on c.ItemID = d.ItemID
where DataStatus = 'ACTIVE' 
and b.TransactionID = " & lastTransID & " group by c.ItemID,c.ItemBrand,c.ItemDescription,ContainerType) x"
            dataadapter = New SqlDataAdapter(strSQL, Connection)
            Dim consumedlist As New DataSet()
            dataadapter.Fill(consumedlist, "vw_TransactionList")
            dgvItemConsumed.DataSource = consumedlist
            dgvItemConsumed.DataMember = "vw_TransactionList"
            Console.WriteLine(strSQL)
            Console.WriteLine(lastTransID)

            If dgvItemConsumed.Rows.Count = 0 Then
                labelConsumed.Visible = True
            Else
                labelConsumed.Visible = False
            End If

            strSQL = "select CustomerName,ContactNumber,Address from tblTransactions where [JA-Transaction] = " & lastTransID
            cmd = New SqlCommand(strSQL, Connection)
            reader = cmd.ExecuteReader
            Console.WriteLine(strSQL)
            While reader.Read()
                txtName.Text = reader.GetString(0)
                If reader.IsDBNull(1) = True Then
                    txtContactNumber.Text = ""
                Else
                    txtContactNumber.Text = reader.GetString(1)
                End If
                If reader.IsDBNull(2) = True Then
                    txtAddress.Text = ""
                Else
                    txtAddress.Text = reader.GetString(2)
                End If
                If txtName.Text <> "" Then
                    dgvSearchService.Enabled = True
                    dgvServiceListing.Enabled = True
                    GroupBox1.Enabled = False
                    btnSave.Enabled = True
                    txtSearchServ.Enabled = True
                    btnSearch.Enabled = True
                End If
            End While
            reader.Close()
            GroupBox1.Enabled = False
        End If
        Call DisConnectSQLServer()
    End Sub

    Private Sub dgvSearchItem_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchService.CellContentClick, dgvSearchService.CellClick
        If (dgvSearchService.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvSearchItem_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchService.CellDoubleClick, dgvSearchService.CellContentDoubleClick
        If (dgvSearchService.Rows.Count > 0) Then
            If dgvSearchService.CurrentRow.Cells("status").Value <> "Not Available" Then
                servicecheckoutid = dgvSearchService.CurrentRow.Cells("serv_id").Value
                txtName.Enabled = False
                Dim ab As New frmServiceDialog
                ab.ShowDialog()
            Else
                MsgBox("Service Unavailable due to insufficient inventory requirements.", MsgBoxStyle.Critical, Application.ProductName)
            End If
        End If
    End Sub



    Private Sub frmServiceCheckout_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim ask = MsgBox("Do you want to close this form?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYesNo Then
            Me.Close()
        End If
    End Sub

    Private Sub txtName_EnabledChanged(sender As Object, e As EventArgs) Handles txtName.EnabledChanged
        If (txtName.Enabled = True) Then
            loadservicelist()
        End If
    End Sub

    Private Sub validateFields()
        If (txtName.Text.Trim = "") Then
            ErrorProvider1.SetError(txtName, "Name is required.")
            ErrorProvider1.SetIconPadding(txtName, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtName, "")
        End If

        If dgvSearchService.Rows.Count = 0 Then
            ErrorProvider1.SetError(labl1, "Please select atleast one service.")
            ErrorProvider1.SetIconPadding(labl1, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(labl1, "")
        End If

    End Sub

    Private Sub Initialize()
        flag1 = True
        flag2 = True
    End Sub


    Private Sub btnSave_Click_1(sender As Object, e As EventArgs) Handles btnSave.Click
        lastTransID = Nothing
        Me.Close()
    End Sub

    Private Sub frmServiceCheckout_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        loadservicelist()
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

    Private Sub GroupBox1_MouseHover(sender As Object, e As EventArgs) Handles GroupBox1.MouseHover
        loadservicelist()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave_1.Click
        Initialize()
        validateFields()
        If (flag1 = False OrElse flag2 = False) Then
            MsgBox("Please complete errors.", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            Call AddTransaction(txtName.Text, txtAddress.Text, "Pending")
            dgvSearchService.Enabled = True
            dgvServiceListing.Enabled = True
            GroupBox1.Enabled = False
            btnSave.Enabled = True
            txtSearchServ.Enabled = True
            btnSearch.Enabled = True
            MsgBox("Please select atleast one service.", MsgBoxStyle.Information, Application.ProductName)
        End If
    End Sub

End Class