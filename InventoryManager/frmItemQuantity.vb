Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class frmItemQuantity
    Dim flag1 As Boolean
    Private Sub frmItemQuantity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not String.Compare(container1, "Sachet") Then
            lblWordings.Text = "Please put number of Sachets to be used."
            lblText2.Text = "Sachet/s"
        Else
            lblWordings.Text = "Please input the volume to be used."
            lblText2.Text = "ml"
        End If
    End Sub
    Private Sub Initializeflag()
        flag1 = True
    End Sub


    Function CheckForAlphaCharacters(ByVal StringToCheck As String)
        For i = 0 To StringToCheck.Length - 1
            If Char.IsLetter(StringToCheck.Chars(i)) Then
                Return True
            End If
        Next
        Return False
    End Function

    Private Sub Validation()
        If (txtQuantityOut.Text.Trim = "") Then
            ErrorProvider1.SetError(txtQuantityOut, "Blank field is not allowed.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        ElseIf (CDec(txtQuantityOut.Text.Trim) < 1) Then
            ErrorProvider1.SetError(txtQuantityOut, "Quantity must be atleast 1.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtQuantityOut, "")
        End If
    End Sub

    Private Sub btnSaveItem_Click(sender As Object, e As EventArgs) Handles btnSaveItem.Click
        If (txtQuantityOut.Text.Trim <> "") Then
            Dim ask = MsgBox("Do you want to continue?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If ask = vbYes Then
                Initializeflag()
                Validation()
                If (flag1 = False) Then
                    MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
                    Exit Sub
                End If
                checkoutqty = txtQuantityOut.Text
                Call AddCheckOut(serviceID, itemID, txtQuantityOut.Text.Trim)
                Call InventoryProcessing()
                frmShowCheckoutlist.Enabled = True
                Me.Close()
            End If
        Else
            MsgBox("Please put quantity to be used.")
        End If
    End Sub

    Private Sub txtQuantityOut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtQuantityOut.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
                ErrorProvider1.SetError(txtQuantityOut, "")
            Else
                ErrorProvider1.SetError(txtQuantityOut, "Only numbers are allowed in this field.")
                ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
            End If
            ErrorProvider1.SetError(txtQuantityOut, "")
        Else
            ErrorProvider1.SetError(txtQuantityOut, "Only numbers are allowed in this field.")
            ErrorProvider1.SetIconPadding(txtQuantityOut, 5)
        End If
    End Sub
End Class