Imports System.Data.SqlClient

Public Class frmDeductionForm
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim ask = MsgBox("Are you sure you want to cancel this action?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            Me.Close()
        End If
    End Sub

    Private Sub frmDeductionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub

    Private Sub LoadData()
        ConnectTOSQLServer1()
        strSQL = "select ItemBrand,ItemDescription,PhysicalStock from tblInventory where ItemID = " & itemID
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader
        If reader.Read = True Then
            txtItemBrand.Text = reader.GetString(0)
            txtItemDescription.Text = reader.GetString(1)
            txtStocks.Text = CStr(reader.GetDecimal(2))
        End If
        reader.Close()
        DisConnectSQLServer()
    End Sub

    Private Sub txtDeductedStocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDeductedStocks.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtDeductedStocks_OnValueChanged(sender As Object, e As EventArgs) Handles txtDeductedStocks.OnValueChanged

        '     Dim numbers = IIf(txtDeductedStocks.Text = "", CDec(0), CDec(txtDeductedStocks.Text))
        txtRetained.Text = CStr(ConvertToInteger(txtStocks.Text) - ConvertToInteger(txtDeductedStocks.Text))
    End Sub
    Private Function ConvertToInteger(ByRef value As String) As Integer
        If String.IsNullOrEmpty(value) Then
            value = "0"
        End If
        Return Convert.ToInt32(value)
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim ask = MsgBox("Are you sure you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If ask = vbYes Then
            ConnectTOSQLServer1()

            If (txtDeductedStocks.Text <> "" And txtRemarks.Text <> "" And txtRetained.Text >= 0) Then
                strSQL = "insert into tblNotifications(NotifDate,ItemNo,Message)values(getdate(), " & itemID & ",'" & txtDeductedStocks.Text & " item/s was removed due to " & txtRemarks.Text & " by " & login_name & "')"
                Console.WriteLine(strSQL)
                cmd = New SqlCommand(strSQL, Connection)
                cmd.ExecuteNonQuery()
                ManualDeduction(txtDeductedStocks.Text, itemID)
            End If
            DisConnectSQLServer()
        End If
    End Sub
End Class