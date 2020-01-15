<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointments
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointments))
        Me.dgvAppointments = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.custname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.address = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.contac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Services = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtSearchServ = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.btnAccept = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEditAppointment = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddAppointment = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dtpAppointdate = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblShow = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAppointments
        '
        Me.dgvAppointments.AllowUserToAddRows = False
        Me.dgvAppointments.AllowUserToDeleteRows = False
        Me.dgvAppointments.AllowUserToResizeColumns = False
        Me.dgvAppointments.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvAppointments.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAppointments.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAppointments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvAppointments.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvAppointments.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAppointments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAppointments.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointments.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.date_, Me.time_, Me.custname, Me.address, Me.contac, Me.Services, Me.Status})
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAppointments.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAppointments.DoubleBuffered = True
        Me.dgvAppointments.EnableHeadersVisualStyles = False
        Me.dgvAppointments.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvAppointments.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvAppointments.Location = New System.Drawing.Point(23, 119)
        Me.dgvAppointments.MultiSelect = False
        Me.dgvAppointments.Name = "dgvAppointments"
        Me.dgvAppointments.ReadOnly = True
        Me.dgvAppointments.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAppointments.RowHeadersVisible = False
        Me.dgvAppointments.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAppointments.RowTemplate.ReadOnly = True
        Me.dgvAppointments.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAppointments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAppointments.Size = New System.Drawing.Size(911, 365)
        Me.dgvAppointments.TabIndex = 44
        '
        'id
        '
        Me.id.DataPropertyName = "JA-Transaction"
        Me.id.HeaderText = "App"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'date_
        '
        Me.date_.DataPropertyName = "Date"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.date_.DefaultCellStyle = DataGridViewCellStyle3
        Me.date_.HeaderText = "Appointment Date"
        Me.date_.Name = "date_"
        Me.date_.ReadOnly = True
        '
        'time_
        '
        Me.time_.DataPropertyName = "Time"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.time_.DefaultCellStyle = DataGridViewCellStyle4
        Me.time_.HeaderText = "Appointment Time"
        Me.time_.Name = "time_"
        Me.time_.ReadOnly = True
        '
        'custname
        '
        Me.custname.DataPropertyName = "CustomerName"
        Me.custname.HeaderText = "Customer Name"
        Me.custname.Name = "custname"
        Me.custname.ReadOnly = True
        '
        'address
        '
        Me.address.DataPropertyName = "Address"
        Me.address.HeaderText = "Address"
        Me.address.Name = "address"
        Me.address.ReadOnly = True
        '
        'contac
        '
        Me.contac.DataPropertyName = "ContactNumber"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.contac.DefaultCellStyle = DataGridViewCellStyle5
        Me.contac.HeaderText = "Contact Number"
        Me.contac.Name = "contac"
        Me.contac.ReadOnly = True
        '
        'Services
        '
        Me.Services.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Services.DataPropertyName = "Service/s Availed"
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Services.DefaultCellStyle = DataGridViewCellStyle6
        Me.Services.HeaderText = "Services"
        Me.Services.Name = "Services"
        Me.Services.ReadOnly = True
        '
        'Status
        '
        Me.Status.DataPropertyName = "TransactionStatus"
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'txtSearchServ
        '
        Me.txtSearchServ.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearchServ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchServ.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchServ.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchServ.HintText = "Search Name"
        Me.txtSearchServ.isPassword = False
        Me.txtSearchServ.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtSearchServ.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearchServ.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtSearchServ.LineThickness = 3
        Me.txtSearchServ.Location = New System.Drawing.Point(710, 81)
        Me.txtSearchServ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchServ.Name = "txtSearchServ"
        Me.txtSearchServ.Size = New System.Drawing.Size(184, 33)
        Me.txtSearchServ.TabIndex = 47
        Me.txtSearchServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAccept
        '
        Me.btnAccept.Activecolor = System.Drawing.Color.DarkCyan
        Me.btnAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAccept.BackColor = System.Drawing.Color.DarkCyan
        Me.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAccept.BorderRadius = 7
        Me.btnAccept.ButtonText = "Accept Appointment"
        Me.btnAccept.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAccept.DisabledColor = System.Drawing.Color.Gray
        Me.btnAccept.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAccept.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_1_2
        Me.btnAccept.Iconimage_right = Nothing
        Me.btnAccept.Iconimage_right_Selected = Nothing
        Me.btnAccept.Iconimage_Selected = Nothing
        Me.btnAccept.IconMarginLeft = 0
        Me.btnAccept.IconMarginRight = 0
        Me.btnAccept.IconRightVisible = True
        Me.btnAccept.IconRightZoom = 0R
        Me.btnAccept.IconVisible = True
        Me.btnAccept.IconZoom = 90.0R
        Me.btnAccept.IsTab = False
        Me.btnAccept.Location = New System.Drawing.Point(940, 195)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Normalcolor = System.Drawing.Color.DarkCyan
        Me.btnAccept.OnHovercolor = System.Drawing.Color.Teal
        Me.btnAccept.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAccept.selected = False
        Me.btnAccept.Size = New System.Drawing.Size(191, 48)
        Me.btnAccept.TabIndex = 49
        Me.btnAccept.Text = "Accept Appointment"
        Me.btnAccept.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAccept.Textcolor = System.Drawing.Color.White
        Me.btnAccept.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(901, 80)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 48
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEditAppointment
        '
        Me.btnEditAppointment.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditAppointment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditAppointment.BorderRadius = 7
        Me.btnEditAppointment.ButtonText = "Edit Appointment"
        Me.btnEditAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditAppointment.DisabledColor = System.Drawing.Color.Gray
        Me.btnEditAppointment.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEditAppointment.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_4_
        Me.btnEditAppointment.Iconimage_right = Nothing
        Me.btnEditAppointment.Iconimage_right_Selected = Nothing
        Me.btnEditAppointment.Iconimage_Selected = Nothing
        Me.btnEditAppointment.IconMarginLeft = 0
        Me.btnEditAppointment.IconMarginRight = 0
        Me.btnEditAppointment.IconRightVisible = True
        Me.btnEditAppointment.IconRightZoom = 0R
        Me.btnEditAppointment.IconVisible = True
        Me.btnEditAppointment.IconZoom = 90.0R
        Me.btnEditAppointment.IsTab = False
        Me.btnEditAppointment.Location = New System.Drawing.Point(940, 249)
        Me.btnEditAppointment.Name = "btnEditAppointment"
        Me.btnEditAppointment.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditAppointment.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditAppointment.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEditAppointment.selected = False
        Me.btnEditAppointment.Size = New System.Drawing.Size(191, 48)
        Me.btnEditAppointment.TabIndex = 46
        Me.btnEditAppointment.Text = "Edit Appointment"
        Me.btnEditAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditAppointment.Textcolor = System.Drawing.Color.White
        Me.btnEditAppointment.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddAppointment
        '
        Me.btnAddAppointment.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddAppointment.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddAppointment.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddAppointment.BorderRadius = 7
        Me.btnAddAppointment.ButtonText = "Add Appointment"
        Me.btnAddAppointment.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddAppointment.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddAppointment.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddAppointment.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnAddAppointment.Iconimage_right = Nothing
        Me.btnAddAppointment.Iconimage_right_Selected = Nothing
        Me.btnAddAppointment.Iconimage_Selected = Nothing
        Me.btnAddAppointment.IconMarginLeft = 0
        Me.btnAddAppointment.IconMarginRight = 0
        Me.btnAddAppointment.IconRightVisible = True
        Me.btnAddAppointment.IconRightZoom = 0R
        Me.btnAddAppointment.IconVisible = True
        Me.btnAddAppointment.IconZoom = 90.0R
        Me.btnAddAppointment.IsTab = False
        Me.btnAddAppointment.Location = New System.Drawing.Point(940, 141)
        Me.btnAddAppointment.Name = "btnAddAppointment"
        Me.btnAddAppointment.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddAppointment.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddAppointment.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddAppointment.selected = False
        Me.btnAddAppointment.Size = New System.Drawing.Size(191, 48)
        Me.btnAddAppointment.TabIndex = 45
        Me.btnAddAppointment.Text = "Add Appointment"
        Me.btnAddAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddAppointment.Textcolor = System.Drawing.Color.White
        Me.btnAddAppointment.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dtpAppointdate
        '
        Me.dtpAppointdate.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointdate.CustomFormat = "MM/dd/yyyy"
        Me.dtpAppointdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointdate.Location = New System.Drawing.Point(167, 85)
        Me.dtpAppointdate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpAppointdate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpAppointdate.Name = "dtpAppointdate"
        Me.dtpAppointdate.Size = New System.Drawing.Size(116, 29)
        Me.dtpAppointdate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpAppointdate.TabIndex = 50
        Me.dtpAppointdate.UseCustomBackColor = True
        Me.dtpAppointdate.UseCustomForeColor = True
        Me.dtpAppointdate.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(31, 93)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 17)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Appointment Date:"
        '
        'lblShow
        '
        Me.lblShow.AutoSize = True
        Me.lblShow.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblShow.Location = New System.Drawing.Point(493, 172)
        Me.lblShow.Name = "lblShow"
        Me.lblShow.Size = New System.Drawing.Size(170, 17)
        Me.lblShow.TabIndex = 52
        Me.lblShow.Text = "No Appointments Found."
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.CheckBox1.Location = New System.Drawing.Point(289, 90)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 21)
        Me.CheckBox1.TabIndex = 53
        Me.CheckBox1.Text = "Show All"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'frmAppointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.lblShow)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpAppointdate)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.txtSearchServ)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEditAppointment)
        Me.Controls.Add(Me.btnAddAppointment)
        Me.Controls.Add(Me.dgvAppointments)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAppointments"
        CType(Me.dgvAppointments, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAppointments As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnEditAppointment As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddAppointment As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents txtSearchServ As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnAccept As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpAppointdate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents lblShow As Label
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents date_ As DataGridViewTextBoxColumn
    Friend WithEvents time_ As DataGridViewTextBoxColumn
    Friend WithEvents custname As DataGridViewTextBoxColumn
    Friend WithEvents address As DataGridViewTextBoxColumn
    Friend WithEvents contac As DataGridViewTextBoxColumn
    Friend WithEvents Services As DataGridViewTextBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
End Class
