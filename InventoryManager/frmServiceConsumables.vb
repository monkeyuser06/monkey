Imports System.Data.SqlClient

Public Class frmServiceConsumables


    Dim cond As String
    Private selectedRow As Integer
    Private Sub frmServiceManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDatagrids()
    End Sub
    Private Sub frmServiceConsumables_EnabledChanged(sender As Object, e As EventArgs) Handles Me.EnabledChanged
        loadDatagrids()
    End Sub

    Private Sub loadDatagrids()
        Call ConnectTOSQLServer1()

        strSQL = "select * from tblServices where ServiceID = " & serviceID
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        While reader.Read()
            lblName.Text = reader.GetString(1)
            lblPrice.Text = reader.GetDecimal(2)
            lblStatus.Text = IIf(reader.GetBoolean(4) = True, "ACTIVE", "INACTIVE")
            lblType.Text = reader.GetString(3)
        End While
        reader.Close()

        strSQL = "select ItemID,ItemBrand,ItemDescription,ItemClass,ContainerType from tblInventory " & cond
        Dim ItemList As New DataSet()
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        dataadapter.Fill(ItemList, "tblInventory")
        dgvItemList.DataSource = ItemList
        dgvItemList.DataMember = "tblInventory"

        strSQL = "select ItemUsageID,ServiceName,c.ItemBrand,c.ItemDescription,
case when ContainerType = 'Bottle' then CONCAT(ConsumedNumber,' ml')
else CONCAT(COnsumedNumber,' Sachet/s') end as consumednumber, ServiceID
 from vw_ServiceConsumables c
inner join tblInventory d on c.ItemID = d.ItemID
 where  serviceID = " & serviceID
        Dim ServiceConsumables As New DataSet()
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        dataadapter.Fill(ServiceConsumables, "vw_ServiceConsumables")
        dgvConsumables.DataSource = ServiceConsumables
        dgvConsumables.DataMember = "vw_ServiceConsumables"
        dgvConsumables.Columns(0).Visible = False
        dgvConsumables.Columns(5).Visible = False
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = "where ItemBrand like '%" & txtSearch.Text.Trim.Replace("-", "") & "%' or ItemDescription like '%" & txtSearch.Text.Trim.Replace("-", "") & "%'"
        loadDatagrids()
    End Sub


    Private Sub dgvItemList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        If (dgvItemList.Rows.Count >= 0) Then
            Try
                selectedRow = e.RowIndex
                itemID = dgvItemList.CurrentRow.Cells("ID").Value

            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        If (dgvItemList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                itemID = dgvItemList.CurrentRow.Cells("ID").Value
                container1 = dgvItemList.CurrentRow.Cells("Container_").Value
                Dim frmItemQuantitytemp As New frmItemQuantity
                frmItemQuantitytemp.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub


    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            btnSearch_Click(sender, e)
        End If
    End Sub

    Private Sub frmServiceConsumables_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If dgvConsumables.Rows.Count > 0 Then
            Dim ask = MsgBox("Are you sure you want to proceed", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                Call ConnectTOSQLServer1()
                strSQL = "
update tblServiceConsumables
set Status ='INACTIVE'
where ItemUsageID = " & dgvConsumables.CurrentRow.Cells("item_id").Value
                cmd = New SqlCommand(strSQL, Connection)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully removed consumable.", MsgBoxStyle.Information, Application.ProductName)
                Call DisConnectSQLServer()
            End If
        End If
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub btnSearch_EnabledChanged(sender As Object, e As EventArgs) Handles btnSearch.EnabledChanged
        loadDatagrids()
    End Sub
End Class