<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmEmployeeManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEmployeeManager))
        Me.dgvEmployeeList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.btnExportEmployeeList = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddEmployee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateEmployee = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvExportList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFirstname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtLastname = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtMiddleInitial = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtEmail = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtContactNumber = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpExpertise = New System.Windows.Forms.GroupBox()
        Me.cboNails = New System.Windows.Forms.CheckBox()
        Me.cboHair = New System.Windows.Forms.CheckBox()
        Me.cboBody = New System.Windows.Forms.CheckBox()
        Me.cboFace = New System.Windows.Forms.CheckBox()
        Me.gbEmployeeDetails = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpHireDate = New System.Windows.Forms.DateTimePicker()
        Me.rdoInactive = New System.Windows.Forms.RadioButton()
        Me.rdoActive = New System.Windows.Forms.RadioButton()
        Me.idno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.name1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contact = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvExportList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpExpertise.SuspendLayout()
        Me.gbEmployeeDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvEmployeeList
        '
        Me.dgvEmployeeList.AllowUserToAddRows = False
        Me.dgvEmployeeList.AllowUserToDeleteRows = False
        Me.dgvEmployeeList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvEmployeeList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvEmployeeList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmployeeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmployeeList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvEmployeeList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvEmployeeList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvEmployeeList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmployeeList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idno, Me.name1, Me.email, Me.contact})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvEmployeeList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvEmployeeList.DoubleBuffered = True
        Me.dgvEmployeeList.EnableHeadersVisualStyles = False
        Me.dgvEmployeeList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvEmployeeList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvEmployeeList.Location = New System.Drawing.Point(12, 163)
        Me.dgvEmployeeList.MultiSelect = False
        Me.dgvEmployeeList.Name = "dgvEmployeeList"
        Me.dgvEmployeeList.ReadOnly = True
        Me.dgvEmployeeList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEmployeeList.RowHeadersVisible = False
        Me.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmployeeList.Size = New System.Drawing.Size(365, 341)
        Me.dgvEmployeeList.TabIndex = 19
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 10)
        Me.Panel1.TabIndex = 18
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnExportEmployeeList
        '
        Me.btnExportEmployeeList.Activecolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportEmployeeList.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportEmployeeList.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportEmployeeList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportEmployeeList.BorderRadius = 7
        Me.btnExportEmployeeList.ButtonText = "Export List"
        Me.btnExportEmployeeList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportEmployeeList.DisabledColor = System.Drawing.Color.Gray
        Me.btnExportEmployeeList.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExportEmployeeList.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_5_
        Me.btnExportEmployeeList.Iconimage_right = Nothing
        Me.btnExportEmployeeList.Iconimage_right_Selected = Nothing
        Me.btnExportEmployeeList.Iconimage_Selected = Nothing
        Me.btnExportEmployeeList.IconMarginLeft = 0
        Me.btnExportEmployeeList.IconMarginRight = 0
        Me.btnExportEmployeeList.IconRightVisible = True
        Me.btnExportEmployeeList.IconRightZoom = 0R
        Me.btnExportEmployeeList.IconVisible = True
        Me.btnExportEmployeeList.IconZoom = 90.0R
        Me.btnExportEmployeeList.IsTab = False
        Me.btnExportEmployeeList.Location = New System.Drawing.Point(968, 359)
        Me.btnExportEmployeeList.Name = "btnExportEmployeeList"
        Me.btnExportEmployeeList.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportEmployeeList.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportEmployeeList.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportEmployeeList.selected = False
        Me.btnExportEmployeeList.Size = New System.Drawing.Size(174, 48)
        Me.btnExportEmployeeList.TabIndex = 26
        Me.btnExportEmployeeList.Text = "Export List"
        Me.btnExportEmployeeList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportEmployeeList.Textcolor = System.Drawing.Color.White
        Me.btnExportEmployeeList.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddEmployee.BorderRadius = 7
        Me.btnAddEmployee.ButtonText = "Add Employee"
        Me.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEmployee.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddEmployee.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddEmployee.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnAddEmployee.Iconimage_right = Nothing
        Me.btnAddEmployee.Iconimage_right_Selected = Nothing
        Me.btnAddEmployee.Iconimage_Selected = Nothing
        Me.btnAddEmployee.IconMarginLeft = 0
        Me.btnAddEmployee.IconMarginRight = 0
        Me.btnAddEmployee.IconRightVisible = True
        Me.btnAddEmployee.IconRightZoom = 0R
        Me.btnAddEmployee.IconVisible = True
        Me.btnAddEmployee.IconZoom = 90.0R
        Me.btnAddEmployee.IsTab = False
        Me.btnAddEmployee.Location = New System.Drawing.Point(968, 251)
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddEmployee.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddEmployee.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddEmployee.selected = False
        Me.btnAddEmployee.Size = New System.Drawing.Size(174, 48)
        Me.btnAddEmployee.TabIndex = 20
        Me.btnAddEmployee.Text = "Add Employee"
        Me.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddEmployee.Textcolor = System.Drawing.Color.White
        Me.btnAddEmployee.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateEmployee
        '
        Me.btnUpdateEmployee.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateEmployee.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateEmployee.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateEmployee.BorderRadius = 7
        Me.btnUpdateEmployee.ButtonText = "Update Employee"
        Me.btnUpdateEmployee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateEmployee.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateEmployee.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateEmployee.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateEmployee.Iconimage_right = Nothing
        Me.btnUpdateEmployee.Iconimage_right_Selected = Nothing
        Me.btnUpdateEmployee.Iconimage_Selected = Nothing
        Me.btnUpdateEmployee.IconMarginLeft = 0
        Me.btnUpdateEmployee.IconMarginRight = 0
        Me.btnUpdateEmployee.IconRightVisible = True
        Me.btnUpdateEmployee.IconRightZoom = 0R
        Me.btnUpdateEmployee.IconVisible = True
        Me.btnUpdateEmployee.IconZoom = 90.0R
        Me.btnUpdateEmployee.IsTab = False
        Me.btnUpdateEmployee.Location = New System.Drawing.Point(968, 305)
        Me.btnUpdateEmployee.Name = "btnUpdateEmployee"
        Me.btnUpdateEmployee.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateEmployee.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateEmployee.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateEmployee.selected = False
        Me.btnUpdateEmployee.Size = New System.Drawing.Size(174, 48)
        Me.btnUpdateEmployee.TabIndex = 22
        Me.btnUpdateEmployee.Text = "Update Employee"
        Me.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateEmployee.Textcolor = System.Drawing.Color.White
        Me.btnUpdateEmployee.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(341, 124)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Silver
        Me.txtSearch.HintText = "Search"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(97, 121)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 33)
        Me.txtSearch.TabIndex = 29
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvExportList
        '
        Me.dgvExportList.AllowUserToAddRows = False
        Me.dgvExportList.AllowUserToDeleteRows = False
        Me.dgvExportList.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvExportList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvExportList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvExportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvExportList.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.dgvExportList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvExportList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvExportList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvExportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvExportList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvExportList.DoubleBuffered = True
        Me.dgvExportList.EnableHeadersVisualStyles = False
        Me.dgvExportList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvExportList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvExportList.Location = New System.Drawing.Point(847, 16)
        Me.dgvExportList.MultiSelect = False
        Me.dgvExportList.Name = "dgvExportList"
        Me.dgvExportList.ReadOnly = True
        Me.dgvExportList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvExportList.RowHeadersVisible = False
        Me.dgvExportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvExportList.Size = New System.Drawing.Size(217, 36)
        Me.dgvExportList.TabIndex = 31
        Me.dgvExportList.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Firstname:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Lastname:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 16)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Contact Number:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 109)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 16)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Middlename:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 148)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Email Address:"
        '
        'txtFirstname
        '
        Me.txtFirstname.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtFirstname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstname.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtFirstname.BorderThickness = 3
        Me.txtFirstname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtFirstname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstname.isPassword = False
        Me.txtFirstname.Location = New System.Drawing.Point(133, 23)
        Me.txtFirstname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(263, 31)
        Me.txtFirstname.TabIndex = 28
        Me.txtFirstname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtLastname
        '
        Me.txtLastname.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtLastname.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastname.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtLastname.BorderThickness = 3
        Me.txtLastname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLastname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtLastname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLastname.isPassword = False
        Me.txtLastname.Location = New System.Drawing.Point(133, 62)
        Me.txtLastname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(263, 31)
        Me.txtLastname.TabIndex = 29
        Me.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtMiddleInitial.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMiddleInitial.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtMiddleInitial.BorderThickness = 3
        Me.txtMiddleInitial.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtMiddleInitial.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtMiddleInitial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtMiddleInitial.isPassword = False
        Me.txtMiddleInitial.Location = New System.Drawing.Point(133, 101)
        Me.txtMiddleInitial.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(263, 31)
        Me.txtMiddleInitial.TabIndex = 30
        Me.txtMiddleInitial.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtEmail
        '
        Me.txtEmail.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtEmail.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtEmail.BorderThickness = 3
        Me.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmail.isPassword = False
        Me.txtEmail.Location = New System.Drawing.Point(133, 140)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(263, 31)
        Me.txtEmail.TabIndex = 31
        Me.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtContactNumber.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContactNumber.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtContactNumber.BorderThickness = 3
        Me.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContactNumber.isPassword = False
        Me.txtContactNumber.Location = New System.Drawing.Point(133, 179)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(263, 31)
        Me.txtContactNumber.TabIndex = 31
        Me.txtContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSave
        '
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.Location = New System.Drawing.Point(223, 353)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = False
        Me.btnSave.Size = New System.Drawing.Size(46, 36)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.AutoSize = True
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(277, 353)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Primary = False
        Me.btnCancel.Size = New System.Drawing.Size(64, 36)
        Me.btnCancel.TabIndex = 34
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(24, 275)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Status:"
        '
        'grpExpertise
        '
        Me.grpExpertise.Controls.Add(Me.cboNails)
        Me.grpExpertise.Controls.Add(Me.cboHair)
        Me.grpExpertise.Controls.Add(Me.cboBody)
        Me.grpExpertise.Controls.Add(Me.cboFace)
        Me.grpExpertise.Location = New System.Drawing.Point(133, 217)
        Me.grpExpertise.Name = "grpExpertise"
        Me.grpExpertise.Size = New System.Drawing.Size(263, 55)
        Me.grpExpertise.TabIndex = 42
        Me.grpExpertise.TabStop = False
        Me.grpExpertise.Text = "Expertise"
        '
        'cboNails
        '
        Me.cboNails.AutoSize = True
        Me.cboNails.Location = New System.Drawing.Point(196, 22)
        Me.cboNails.Name = "cboNails"
        Me.cboNails.Size = New System.Drawing.Size(60, 20)
        Me.cboNails.TabIndex = 41
        Me.cboNails.Text = "Nails"
        Me.cboNails.UseVisualStyleBackColor = True
        '
        'cboHair
        '
        Me.cboHair.AutoSize = True
        Me.cboHair.Location = New System.Drawing.Point(72, 22)
        Me.cboHair.Name = "cboHair"
        Me.cboHair.Size = New System.Drawing.Size(54, 20)
        Me.cboHair.TabIndex = 41
        Me.cboHair.Text = "Hair"
        Me.cboHair.UseVisualStyleBackColor = True
        '
        'cboBody
        '
        Me.cboBody.AutoSize = True
        Me.cboBody.Location = New System.Drawing.Point(6, 22)
        Me.cboBody.Name = "cboBody"
        Me.cboBody.Size = New System.Drawing.Size(60, 20)
        Me.cboBody.TabIndex = 41
        Me.cboBody.Text = "Body"
        Me.cboBody.UseVisualStyleBackColor = True
        '
        'cboFace
        '
        Me.cboFace.AutoSize = True
        Me.cboFace.Location = New System.Drawing.Point(132, 22)
        Me.cboFace.Name = "cboFace"
        Me.cboFace.Size = New System.Drawing.Size(58, 20)
        Me.cboFace.TabIndex = 41
        Me.cboFace.Text = "Face"
        Me.cboFace.UseVisualStyleBackColor = True
        '
        'gbEmployeeDetails
        '
        Me.gbEmployeeDetails.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbEmployeeDetails.Controls.Add(Me.Label1)
        Me.gbEmployeeDetails.Controls.Add(Me.dtpHireDate)
        Me.gbEmployeeDetails.Controls.Add(Me.rdoInactive)
        Me.gbEmployeeDetails.Controls.Add(Me.rdoActive)
        Me.gbEmployeeDetails.Controls.Add(Me.grpExpertise)
        Me.gbEmployeeDetails.Controls.Add(Me.Label11)
        Me.gbEmployeeDetails.Controls.Add(Me.btnCancel)
        Me.gbEmployeeDetails.Controls.Add(Me.btnSave)
        Me.gbEmployeeDetails.Controls.Add(Me.txtContactNumber)
        Me.gbEmployeeDetails.Controls.Add(Me.txtEmail)
        Me.gbEmployeeDetails.Controls.Add(Me.txtMiddleInitial)
        Me.gbEmployeeDetails.Controls.Add(Me.txtLastname)
        Me.gbEmployeeDetails.Controls.Add(Me.txtFirstname)
        Me.gbEmployeeDetails.Controls.Add(Me.Label8)
        Me.gbEmployeeDetails.Controls.Add(Me.Label9)
        Me.gbEmployeeDetails.Controls.Add(Me.Label7)
        Me.gbEmployeeDetails.Controls.Add(Me.Label5)
        Me.gbEmployeeDetails.Controls.Add(Me.Label3)
        Me.gbEmployeeDetails.Enabled = False
        Me.gbEmployeeDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEmployeeDetails.Location = New System.Drawing.Point(383, 103)
        Me.gbEmployeeDetails.Name = "gbEmployeeDetails"
        Me.gbEmployeeDetails.Size = New System.Drawing.Size(463, 401)
        Me.gbEmployeeDetails.TabIndex = 28
        Me.gbEmployeeDetails.TabStop = False
        Me.gbEmployeeDetails.Text = "Employee Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 275)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Hire Date:"
        '
        'dtpHireDate
        '
        Me.dtpHireDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpHireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHireDate.Location = New System.Drawing.Point(280, 298)
        Me.dtpHireDate.Name = "dtpHireDate"
        Me.dtpHireDate.Size = New System.Drawing.Size(116, 23)
        Me.dtpHireDate.TabIndex = 44
        '
        'rdoInactive
        '
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Location = New System.Drawing.Point(140, 301)
        Me.rdoInactive.Name = "rdoInactive"
        Me.rdoInactive.Size = New System.Drawing.Size(78, 20)
        Me.rdoInactive.TabIndex = 43
        Me.rdoInactive.Text = "Inactive"
        Me.rdoInactive.UseVisualStyleBackColor = True
        '
        'rdoActive
        '
        Me.rdoActive.AutoSize = True
        Me.rdoActive.Checked = True
        Me.rdoActive.Location = New System.Drawing.Point(67, 301)
        Me.rdoActive.Name = "rdoActive"
        Me.rdoActive.Size = New System.Drawing.Size(67, 20)
        Me.rdoActive.TabIndex = 43
        Me.rdoActive.TabStop = True
        Me.rdoActive.Text = "Active"
        Me.rdoActive.UseVisualStyleBackColor = True
        '
        'idno
        '
        Me.idno.DataPropertyName = "EmployeeID"
        Me.idno.HeaderText = "ID"
        Me.idno.Name = "idno"
        Me.idno.ReadOnly = True
        Me.idno.Visible = False
        '
        'name1
        '
        Me.name1.DataPropertyName = "Emp_Fullname"
        Me.name1.HeaderText = "Employee Name"
        Me.name1.Name = "name1"
        Me.name1.ReadOnly = True
        '
        'email
        '
        Me.email.DataPropertyName = "Emp_Email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'contact
        '
        Me.contact.DataPropertyName = "Emp_ContactNumber"
        Me.contact.HeaderText = "Contact Number"
        Me.contact.Name = "contact"
        Me.contact.ReadOnly = True
        '
        'frmEmployeeManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.dgvExportList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.gbEmployeeDetails)
        Me.Controls.Add(Me.dgvEmployeeList)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnExportEmployeeList)
        Me.Controls.Add(Me.btnAddEmployee)
        Me.Controls.Add(Me.btnUpdateEmployee)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEmployeeManager"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmEmployeeManager"
        CType(Me.dgvEmployeeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvExportList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpExpertise.ResumeLayout(False)
        Me.grpExpertise.PerformLayout()
        Me.gbEmployeeDetails.ResumeLayout(False)
        Me.gbEmployeeDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvEmployeeList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExportEmployeeList As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddEmployee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdateEmployee As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvExportList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents gbEmployeeDetails As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents dtpHireDate As DateTimePicker
    Friend WithEvents rdoInactive As RadioButton
    Friend WithEvents rdoActive As RadioButton
    Friend WithEvents grpExpertise As GroupBox
    Friend WithEvents cboNails As CheckBox
    Friend WithEvents cboHair As CheckBox
    Friend WithEvents cboBody As CheckBox
    Friend WithEvents cboFace As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtContactNumber As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtEmail As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtMiddleInitial As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtLastname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtFirstname As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents idno As DataGridViewTextBoxColumn
    Friend WithEvents name1 As DataGridViewTextBoxColumn
    Friend WithEvents email As DataGridViewTextBoxColumn
    Friend WithEvents contact As DataGridViewTextBoxColumn
End Class
