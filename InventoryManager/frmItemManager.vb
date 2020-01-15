Imports System.Data.SqlClient

Public Class frmItemManager


    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Private critPoint As String
    Private ExpiDate As Object
    Private ExpiDateforUpdate, CritPointForUpdate As Object
    Dim itemclass As String

    Private Sub frmItemManager_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        frmMenu.Enabled = True
    End Sub

    Private Sub frmItemManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (saveType1 = 2) Then
            GatherDataForUpdate()
        End If
    End Sub

    Private Sub GatherDataForUpdate()
        Call ConnectTOSQLServer1()
        strSQL = "select ItemBrand,ItemDescription,PhysicalStock,VolumePerStock,CriticalPoint,ContainerType,Price,ItemClass,ContainerType from tblInventory where ItemID = " & itemID
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        While reader.Read()
            txtItemBrand.Text = reader.GetString(0)
            txtDescription.Text = reader.GetString(1)
            txtCritPoint.Text = CStr(reader.GetDecimal(4))
            If (reader.GetString(8) = "Bottle") Then
                rdoBottle.Checked = True
            Else
                rdoSachet.Checked = True
            End If
            txtPrice.Text = reader.GetString(6)
            If (reader.GetString(7) = "Body") Then
                rdoBody.Checked = True
            ElseIf (reader.GetString(7) = "Hair") Then
                rdoHair.Checked = True
            ElseIf (reader.GetString(7) = "Face") Then
                rdoFace.Checked = True
            ElseIf (reader.GetString(7) = "Nails") Then
                rdoNails.Checked = True
            End If
            txtVolume.Text = CStr(reader.GetDecimal(3))
            Console.WriteLine(strSQL)
        End While
        reader.Close()
        txtItemBrand.Enabled = False
        txtDescription.Enabled = False
        txtVolume.Enabled = False
        txtPrice.Enabled = False
        txtCritPoint.Enabled = False
        rdoBottle.Enabled = False
        rdoSachet.Enabled = False
        groupBoxRole.Enabled = False
        Call DisConnectSQLServer()
    End Sub

    Private Sub rdoBottle_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBottle.CheckedChanged
        If (rdoBottle.Checked = True) Then
            txtVolume.Enabled = True
            txtVolume.Text = ""
        End If
    End Sub

    Private Sub txtStocks_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtVolume.KeyPress, txtStocks.KeyPress, txtCritPoint.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                ErrorProvider1.SetError(Me, "")
            Else
                ErrorProvider1.SetError(Me, "Only numbers are allowed in this field.")
                ErrorProvider1.SetIconPadding(Me, 5)
            End If
            ErrorProvider1.SetError(Me, "")
        Else
            ErrorProvider1.SetError(Me, "Only numbers are allowed in this field.")
            ErrorProvider1.SetIconPadding(Me, 5)
        End If
    End Sub

    Private Sub InitializeFlags()
        flag1 = True
        flag2 = True
        flag3 = True
        flag4 = True
        flag5 = True
        flag6 = True
        flag7 = True
        flag8 = True

    End Sub
    Private Sub RoleValidation()
        If (rdoNails.Checked) Then
            itemclass = "NAILS"
        ElseIf (rdoHair.Checked) Then
            itemclass = "HAIR"
        ElseIf (rdoBody.Checked) Then
            itemclass = "BODY"
        ElseIf (rdoFace.Checked) Then
            itemclass = "FACE"
        Else
            ErrorProvider1.SetError(groupBoxRole, "Please choose a item type.")
            ErrorProvider1.SetIconPadding(groupBoxRole, 5)
            flag8 = False
        End If
    End Sub

    Private Sub ItemNameValidation()
        If txtItemBrand.Text.Trim = "" Then

            ErrorProvider1.SetError(txtItemBrand, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtItemBrand, 5)
            flag1 = False

        ElseIf txtItemBrand.Text.IndexOfAny(restrictedCharactersForName) > -1 Then

            ErrorProvider1.SetError(txtItemBrand, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtItemBrand, 5)
            flag1 = False

        ElseIf IsNumeric(txtItemBrand.Text) = True Or txtItemBrand.Text.IndexOfAny("1234567890") > -1 Then

            ErrorProvider1.SetError(txtItemBrand, "Numeric characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtItemBrand, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtItemBrand, "")
        End If
    End Sub

    Private Sub ItemQuantityValidation()
        If txtStocks.Text.Trim = "" Then
            ErrorProvider1.SetError(txtStocks, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtStocks, 5)
            flag2 = False
        ElseIf txtStocks.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtStocks, "Special characters are not allowed in this field.")
            ErrorProvider1.SetIconPadding(txtStocks, 5)
            flag2 = False
        ElseIf IsNumeric(txtStocks.Text) = False Then
            ErrorProvider1.SetError(txtStocks, "Numeric characters only are the characters allowed in this field.")
            ErrorProvider1.SetIconPadding(txtStocks, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtStocks, "")

        End If
    End Sub


    Private Sub ItemDescriptionValidation()
        If txtDescription.Text.Trim = "" Then
            ErrorProvider1.SetError(txtDescription, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtDescription, 3)
            flag5 = False
        Else
            ErrorProvider1.SetError(txtDescription, "")
        End If
    End Sub

    Private Function GetGroupBoxCheckedButton(grpb As GroupBox) As RadioButton
        Dim rButton As RadioButton = grpb.Controls.OfType(Of RadioButton).Where(Function(r) r.Checked = True).FirstOrDefault()
        Return rButton
    End Function

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        InitializeFlags()
        ItemDescriptionValidation()
        ItemNameValidation()
        ItemQuantityValidation()
        RoleValidation()
        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then
            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
        Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
        If (ask = vbYes) Then

            Dim ContainerType As String
            If (rdoBottle.Checked = True) Then
                ContainerType = rdoBottle.Text
            Else
                ContainerType = rdoSachet.Text
            End If
            If (saveType1 = 1) Then
                Call AddItem(txtItemBrand.Text.Trim, txtDescription.Text.Trim, txtStocks.Text, txtVolume.Text, txtCritPoint.Text, ContainerType, txtPrice.Text, GetGroupBoxCheckedButton(groupBoxRole).Text, dtpExpirationDate.Value.ToString("MM/dd/yyyy"))
                MsgBox("Successfully added item.", MsgBoxStyle.Information, Application.ProductName)
                logInfo = "Added new item#" & lastIDforcheckin & " successfully."
                Call RecordLog(logInfo)
            ElseIf (saveType1 = 2) Then
                Call UpdateItem(txtStocks.Text, itemID, txtVolume.Text, dtpExpirationDate.Value.ToString("MM/dd/yyyy"))
                MsgBox("Successfully updated item.", MsgBoxStyle.Information, Application.ProductName)
            End If
            frmMenu.Enabled = True

            Me.Close()
        End If
    End Sub
End Class