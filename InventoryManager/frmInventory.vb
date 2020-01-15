Imports System.Data.SqlClient

Public Class frmInventory
    Private outstock, instocks, critstock, expiring, cond As String
    Private selectedRow As Integer


    Private Sub frmInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cboClass.SelectedIndex = 0
        If login_accesstype = "ADMINISTRATOR" Then
            btnDeductStocks.Visible = True
        Else
            btnDeductStocks.Visible = False
        End If
        'TODO: This line of code loads data into the 'JandADataSet3.tblInventory' table. You can move, or remove it, as needed.
        Call viewItemList_reload()
    End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnSearch_Click(sender, e)
        End If
    End Sub


    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        saveType1 = 1
        Dim ab As New frmItemManager
        ab.Show()
        frmMenu.Enabled = False
    End Sub

    Private Sub btnUpdateItem_Click(sender As Object, e As EventArgs) Handles btnUpdateItem.Click
        If (selectedRow >= 0) Then
            saveType1 = 2
            Console.WriteLine(dgvItemList.CurrentRow.Cells("itemno").Value())
            itemID = dgvItemList.CurrentRow.Cells("itemno").Value()
            Dim frmitemmanagertemp As New frmItemManager
            frmitemmanagertemp.Show()
            frmMenu.Enabled = False
        End If
    End Sub

    Private Sub cardCritStock_Click(sender As Object, e As EventArgs) Handles rdoCritical.CheckedChanged
        If rdoCritical.Checked = True Then
            cond = "  where PhysicalStock <= CriticalPoint and PhysicalStock <> 0"
            Call viewItemList_reload()
        End If
    End Sub

    Private Sub cardOutofStock_Click(sender As Object, e As EventArgs) Handles rdoOutofStock.CheckedChanged
        If rdoOutofStock.Checked = True Then
            cond = " where PhysicalStock = '0'"
            Call viewItemList_reload()
        End If
    End Sub

    Private Sub btnExportItemList_Click(sender As Object, e As EventArgs) Handles btnExportExcel.Click
        ExportExcel(dgvItemList)
    End Sub

    Private Sub btnExportPdf_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            ' declaration textbox2 to save file dialog name
            Dim txt As String = SaveFileDialog1.FileName & ".pdf"
            Call Exporttopdf(txt, dgvItemList)
        End If
    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellClick
        If (dgvItemList.Rows.Count >= 0) Then
            Try
                selectedRow = e.RowIndex
            Catch ex As Exception
            End Try
            Console.WriteLine(selectedRow)
        End If
    End Sub




    Private Sub cardInStock_Paint(sender As Object, e As EventArgs)
        cond = " where Quantity <> '0'"
        Call viewItemList_reload()
    End Sub

    Private Sub cboClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboClass.SelectedIndexChanged
        If (cboClass.SelectedIndex = 0) Then
            cond = ""
        ElseIf (cboClass.SelectedIndex = 1) Then
            cond = " where ItemClass = 'Body'"
        ElseIf (cboClass.SelectedIndex = 2) Then
            cond = " where ItemClass = 'Face'"
        ElseIf (cboClass.SelectedIndex = 3) Then
            cond = " where ItemClass = 'Hair'"
        ElseIf (cboClass.SelectedIndex = 4) Then
            cond = " where ItemClass = 'Nails'"
        End If
        Call viewItemList_reload()
    End Sub

    Private Sub btnNotifications_Click(sender As Object, e As EventArgs) Handles btnNotifications.Click
        frmNotifications.ShowDialog()
    End Sub

    Private Sub rdoAll_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAll.CheckedChanged
        viewItemList_reload()
    End Sub

    Private Sub dgvItemList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellContentClick

    End Sub

    Private Sub btnDeductStocks_Click(sender As Object, e As EventArgs) Handles btnDeductStocks.Click
        Dim ask = MsgBox("Do you want to deduct stocks from this item?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            itemID = dgvItemList.CurrentRow.Cells(0).Value
            frmDeductionForm.ShowDialog()
        End If
    End Sub

    Private Sub frmInventory_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged
        Call viewItemList_reload()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = " where ItemBrand like '%" & txtSearch.Text.Trim.Replace("-", "") & "%' or ItemDescription like '%" & txtSearch.Text.Trim.Replace("-", "") & "%' "
        viewItemList_reload()
    End Sub
    Private Sub viewItemList_reload()
        Call ConnectTOSQLServer1()
        strSQL = "select ItemID,ItemBrand,ItemDescription,
concat(PhysicalStock,' ',ContainerType,case when PhysicalStock > 1 then 's' else '' end) as PhysicalStock
,concat(VolumePerStock,' ml') as VolumePerStock,concat(TotalVolume,' ml') as TotalVolume,
concat(CriticalPoint,' ',ContainerType,case when PhysicalStock > 1 then 's' else '' end)  as CriticalPoint,ContainerType,
 concat('Php' ,CAST(cast(Price as float) AS decimal(10,2))) as Price,ItemClass 
from tblInventory " & cond
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim ItemList As New DataSet()

        dataadapter.Fill(ItemList, "tblInventory")
        dgvItemList.DataSource = ItemList
        dgvItemList.DataMember = "tblInventory"
        dgvItemList.Columns("Price").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvItemList.Columns("volumeperstock").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvItemList.Columns("totalvolume").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight


        Call DisConnectSQLServer()
    End Sub

    Private Sub dgvItemList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvItemList.CellDoubleClick
        If (dgvItemList.Rows.Count >= 0) Then
            Try
                selectedRow = e.RowIndex
                itemID = dgvItemList.Rows(selectedRow).Cells(0).Value()
                'Dim ab As New frmInventoryItemLogs
                'ab.lblQuantity.Text = dgvItemList.Rows(selectedRow).Cells(3).Value
                'ab.ShowDialog()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class