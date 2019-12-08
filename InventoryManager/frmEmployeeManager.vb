

Imports System.IO
Imports System.Data
Imports System.Configuration
Imports System.Data.SqlClient


Public Class frmEmployeeManager

    Dim flag1, flag2, flag3, flag4, flag5, flag6, flag7, flag8 As Boolean
    Dim saveClass As String
    Dim userID As Int32
    Dim cond As String
    Dim Activecount, inactivecount As String

    Dim HairStat, NailStat, BodyStat As String
    Private ImageFileName As String
    Private Imageloc As String
    Dim fileName As String
    Private fileSavePath As String
    Dim saveDirectory As String = "C:\Users\Monkey\Desktop\ISAD Profile Pictures"
    Private newlocation As String
    Private old_newlocation As String
    Private imgFound As Image
    Private FoundTitle As String
    Private imageName As String
    Public Property selectedRow As Integer

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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Call clearfields()
        InitializeFlags()
        selectedRow = -1
        gbEmployeeDetails.Enabled = False
        dgvEmployeeList.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        InitializeFlags()
        FirstNameValidation()
        LastNameValidation()
        MiddleValidation()
        ExpertiseValidation()

        If flag1 = False Or flag2 = False Or flag3 = False Or flag4 = False Or flag5 = False Or flag6 = False Or flag7 = False Or flag8 = False Then
            MsgBox("Please complete all the required fields and errors.", MsgBoxStyle.Critical, Application.ProductName)
            Exit Sub
        End If
        If (saveClass = 1) Then
            Dim ask = MsgBox("Are you sure you want to add employee?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                Call ConnectTOSQLServer1()
                strSQL = "insert into tblEmployee(Emp_Lastname,Emp_Firstname,Emp_Middlename,Emp_Email,Emp_ContactNumber,Emp_Status,Exp_Body,Exp_Face,Exp_Hair,Exp_Nail,Hire_Date,Author)values(@lname,@fname,@mname,@email,@contact,@status,@body,@hair,@face,@nails,@hire,@author)"
                cmd = New SqlCommand(strSQL, Connection)
                cmd.Parameters.AddWithValue("@fname", SqlDbType.VarChar).Value = txtFirstname.Text
                cmd.Parameters.AddWithValue("@lname", SqlDbType.VarChar).Value = txtLastname.Text
                cmd.Parameters.AddWithValue("@mname", SqlDbType.VarChar).Value = txtMiddleInitial.Text
                cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txtEmail.Text
                cmd.Parameters.AddWithValue("@contact", SqlDbType.VarChar).Value = txtContactNumber.Text
                cmd.Parameters.AddWithValue("@body", SqlDbType.Bit).Value = cboBody.CheckState
                cmd.Parameters.AddWithValue("@hair", SqlDbType.Bit).Value = cboHair.CheckState
                cmd.Parameters.AddWithValue("@face", SqlDbType.Bit).Value = cboFace.CheckState
                cmd.Parameters.AddWithValue("@nails", SqlDbType.Bit).Value = cboNails.CheckState
                cmd.Parameters.AddWithValue("@author", SqlDbType.Int).Value = login_id
                cmd.Parameters.AddWithValue("@hire", SqlDbType.Date).Value = dtpHireDate.Value
                cmd.Parameters.AddWithValue("@status", SqlDbType.Bit).Value = IIf(rdoActive.Checked = True, rdoActive.Text, rdoInactive.Text)

                cmd.ExecuteNonQuery()

                Call DisConnectSQLServer()
                Call clearfields()
                gbEmployeeDetails.Enabled = False
                MsgBox("Successfully added employee details.", MsgBoxStyle.Information, Application.ProductName)
            End If
        ElseIf (saveClass = 2) Then
            Dim ask = MsgBox("Are you sure you want to update employee?", MsgBoxStyle.Information + vbYesNo, Application.ProductName)
            If (ask = vbYes) Then
                'Try
                '    fileName = Path.GetFileName(ImageFileName)
                '    fileSavePath = Path.Combine(saveDirectory, fileName)
                '    File.Copy(ImageFileName, fileSavePath, True)
                'Catch
                '    fileSavePath = ""
                'End Try
                Call ConnectTOSQLServer1()
                strSQL = "update tblEmployee set Emp_Firstname = @fname, Emp_Lastname = @lname, Emp_Middlename = @mname, Emp_Email = @email, Emp_ContactNumber = @contact, Hire_Date = @date, Exp_hair = @hair, Exp_Body = @body, Exp_Face = @face, Exp_Nail = @nail, Emp_Status = @status where EmployeeNo = @id"
                cmd = New SqlCommand(strSQL, Connection)
                cmd = New SqlCommand(strSQL, Connection)
                cmd.Parameters.AddWithValue("@fname", SqlDbType.VarChar).Value = txtFirstname.Text
                cmd.Parameters.AddWithValue("@lname", SqlDbType.VarChar).Value = txtLastname.Text
                cmd.Parameters.AddWithValue("@mname", SqlDbType.VarChar).Value = txtMiddleInitial.Text
                cmd.Parameters.AddWithValue("@email", SqlDbType.VarChar).Value = txtEmail.Text
                cmd.Parameters.AddWithValue("@contact", SqlDbType.VarChar).Value = txtContactNumber.Text
                cmd.Parameters.AddWithValue("@body", SqlDbType.Bit).Value = cboBody.CheckState
                cmd.Parameters.AddWithValue("@hair", SqlDbType.Bit).Value = cboHair.CheckState
                cmd.Parameters.AddWithValue("@face", SqlDbType.Bit).Value = cboFace.CheckState
                cmd.Parameters.AddWithValue("@nail", SqlDbType.Bit).Value = cboNails.CheckState
                cmd.Parameters.AddWithValue("@date", SqlDbType.Date).Value = dtpHireDate.Value
                cmd.Parameters.AddWithValue("@status", SqlDbType.Bit).Value = IIf(rdoActive.Checked = True, rdoActive.Text, rdoInactive.Text)
                cmd.Parameters.AddWithValue("@id", SqlDbType.VarChar).Value = dgvEmployeeList.Rows(selectedRow).Cells(0).Value

                Console.WriteLine(strSQL)
                cmd.ExecuteNonQuery()
                MsgBox("Successfully update employee details.", MsgBoxStyle.Information, Application.ProductName)
            End If
            Call clearfields()

        End If
        Call ViewEmployeeList()

    End Sub

    Private Sub dgvUserList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellClick
        If (dgvEmployeeList.Rows.Count > 0) Then
            Try
                selectedRow = e.RowIndex
                userID = dgvEmployeeList.Rows(selectedRow).Cells(0).Value()
            Catch ex As Exception
            End Try
        End If
    End Sub

    'Private Sub btnBrowseImage_Click(sender As Object, e As EventArgs)
    '    Using openFileDialog1 As OpenFileDialog = New OpenFileDialog()
    '        openFileDialog1.Filter = "Image Files (JPEG,GIF,BMP,PNG,ICO)|*.jpg;*.jpeg;*.gif;*.bmp;*.png;*ico"
    '        If openFileDialog1.ShowDialog() = DialogResult.OK Then
    '            If Not Directory.Exists(saveDirectory) Then
    '                Directory.CreateDirectory(saveDirectory)
    '            End If
    '            ImageFileName = openFileDialog1.FileName
    '            pbEmployeePic.BackgroundImage = Image.FromFile(openFileDialog1.FileName.ToUpper)

    '        End If
    '    End Using
    'End Sub
    Private Sub txtSearch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnSearch_Click(sender, e)
        End If
    End Sub


    Private Sub frmEmployeeManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cond = ""
        Call ViewEmployeeList()
    End Sub


    Private Sub btnExportEmployeeList_Click(sender As Object, e As EventArgs) Handles btnExportEmployeeList.Click
        ExportExcel(dgvExportList)
    End Sub
    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs)
        SaveFileDialog1.FileName = ""
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            ' declaration textbox2 to save file dialog name
            Dim txt As String = SaveFileDialog1.FileName
            '  Call ExporttoPDF(txt)
        End If
    End Sub

    Private Sub btnUpdateEmployee_Click(sender As Object, e As EventArgs) Handles btnUpdateEmployee.Click
        dgvEmployeeList.Enabled = False
        btnAddEmployee.Enabled = False
        btnUpdateEmployee.Enabled = False
        btnExportEmployeeList.Enabled = False
        gbEmployeeDetails.Enabled = True
        saveClass = 2
    End Sub

    Private Sub dgvEmployeeList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmployeeList.CellContentClick, dgvEmployeeList.CellClick
        Call ConnectTOSQLServer1()
        strSQL = "select * from tblEmployee where EmployeeID = '" & dgvEmployeeList.Rows(selectedRow).Cells("idno").Value & "'"
        Console.WriteLine(strSQL)
        cmd = New SqlCommand(strSQL, Connection)
        reader = cmd.ExecuteReader()
        Do While reader.Read()
            userID = reader.GetInt32(0)
            txtFirstname.Text = reader.GetString(2)
            txtLastname.Text = reader.GetString(3)
            txtMiddleInitial.Text = reader.GetString(4)
            txtEmail.Text = reader.GetString(6)
            txtContactNumber.Text = reader.GetString(7)
            dtpHireDate.Value = reader.GetDateTime(8)
            cboHair.Checked = reader.GetBoolean(10)
            cboFace.Checked = reader.GetBoolean(11)
            cboBody.Checked = reader.GetBoolean(12)
            cboNails.Checked = reader.GetBoolean(13)
            rdoActive.Checked = IIf(reader.GetString(14) = "Active", rdoActive.Checked = True, rdoInactive.Checked = True)
        Loop
        reader.Close()
        Call DisConnectSQLServer()
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        cond = " where Lastname = '" & txtSearch.Text.Trim.Replace("-", "") & "' or Firstname = '" & txtSearch.Text.Trim.Replace("-", "") & "'"
        Call ViewEmployeeList()
        logInfo = "Searched " & txtSearch.Text.Trim.Replace("-", "") & " in the Employee List."
        Call RecordLog(logInfo)
    End Sub


    Private Sub ExpertiseValidation()
        Dim isChecked As Boolean = (cboBody.Checked OrElse cboFace.Checked OrElse cboHair.Checked OrElse cboNails.Checked)
        If (isChecked = False) Then
            ErrorProvider1.SetError(grpExpertise, "Please select atleast one expertise")
        End If
    End Sub

    Private Sub btnAddEmployee_Click(sender As Object, e As EventArgs) Handles btnAddEmployee.Click
        clearfields()
        btnAddEmployee.Enabled = False
        btnUpdateEmployee.Enabled = False
        btnExportEmployeeList.Enabled = False
        dgvEmployeeList.Enabled = False
        gbEmployeeDetails.Enabled = True
        saveClass = 1
    End Sub

    Private Sub clearfields()
        txtContactNumber.Text = ""
        txtEmail.Text = ""
        txtFirstname.Text = ""
        txtLastname.Text = ""
        txtMiddleInitial.Text = ""
        btnAddEmployee.Enabled = True
        btnUpdateEmployee.Enabled = True
        btnExportEmployeeList.Enabled = True
        dgvEmployeeList.Enabled = True
        cboBody.Checked = False
        cboFace.Checked = False
        cboHair.Checked = False
        cboNails.Checked = False

        'pbEmployeePic.BackgroundImage = Nothing
    End Sub

    Private Sub FirstNameValidation()
        If txtFirstname.Text.Trim = "" Then
            ErrorProvider1.SetError(txtFirstname, "Blank field Is Not allowed.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False
        ElseIf txtFirstname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtFirstname, "Special characters are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False
        ElseIf IsNumeric(txtFirstname.Text) = True Or txtFirstname.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtFirstname, "Numbers are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtFirstname, 5)
            flag1 = False
        Else
            ErrorProvider1.SetError(txtFirstname, "")
        End If
    End Sub

    Private Sub LastNameValidation()
        If txtLastname.Text.Trim = "" Then
            ErrorProvider1.SetError(txtLastname, "Blank field Is Not allowed.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        ElseIf txtLastname.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtLastname, "Special characters are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        ElseIf IsNumeric(txtLastname.Text) = True Or txtLastname.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtLastname, "Numbers are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtLastname, 5)
            flag2 = False
        Else
            ErrorProvider1.SetError(txtLastname, "")
        End If
    End Sub

    Private Sub MiddleValidation()
        If txtMiddleInitial.Text.Trim = "" Then
            ErrorProvider1.SetError(txtMiddleInitial, "Blank field Is Not allowed.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        ElseIf txtMiddleInitial.Text.IndexOfAny(restrictedCharactersForName) > -1 Then
            ErrorProvider1.SetError(txtMiddleInitial, "Special characters are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        ElseIf IsNumeric(txtMiddleInitial.Text) = True Or txtMiddleInitial.Text.IndexOfAny("1234567890") > -1 Then
            ErrorProvider1.SetError(txtMiddleInitial, "Number are not allowed In this field.")
            ErrorProvider1.SetIconPadding(txtMiddleInitial, 5)
            flag3 = False
        Else
            ErrorProvider1.SetError(txtMiddleInitial, "")
        End If
    End Sub

    Private Sub ViewEmployeeList()
        Call ConnectTOSQLServer1()
        strSQL = "select EmployeeID,Emp_Fullname,Emp_Email,Emp_ContactNumber from tblEmployee" & cond
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim EmployeeList As New DataSet()

        dataadapter.Fill(EmployeeList, "tblEmployee")
        dgvEmployeeList.DataSource = EmployeeList
        dgvEmployeeList.DataMember = "tblEmployee"

        strSQL = "SELECT [EmployeeNo]
      ,[Emp_Firstname] as Firstname
      ,[Emp_Lastname] as Lastname
      ,[Emp_Fullname] as Fullname
      ,[Emp_Email] as Email
      ,[Emp_ContactNumber] as [Contact Number]
      ,[Hire_Date] as [Hire Date] 
      ,case when [Exp_Hair]='TRUE' then 'YES' ELSE 'NO' END as Hair
      ,case when [Exp_Face]='TRUE' then 'YES' ELSE 'NO' END as Face
      ,case when [Exp_Body]='TRUE' then 'YES' ELSE 'NO' END as Body
      ,case when [Exp_Nail]='TRUE' then 'YES' ELSE 'NO' END as Nail
      ,[Emp_Status] as Status
  FROM [dbo].[tblEmployee] " & cond
        Console.WriteLine(strSQL)
        dataadapter = New SqlDataAdapter(strSQL, Connection)
        Dim Employeelistexport As New DataSet()

        dataadapter.Fill(Employeelistexport, "tblEmployee")
        dgvExportList.DataSource = Employeelistexport
        dgvExportList.DataMember = "tblEmployee"
        Call DisConnectSQLServer()
    End Sub
End Class