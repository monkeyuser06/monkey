﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServices
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServices))
        Me.dgvServiceList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnExportServices = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnUpdateService = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnCreateService = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServiceName = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnSave = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialFlatButton()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.switchServiceStatus = New Bunifu.Framework.UI.BunifuSwitch()
        Me.txtRemarks = New WindowsFormsControlLibrary1.BunifuCustomTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rdoBody = New System.Windows.Forms.RadioButton()
        Me.rdoHair = New System.Windows.Forms.RadioButton()
        Me.rdoFace = New System.Windows.Forms.RadioButton()
        Me.rdoNails = New System.Windows.Forms.RadioButton()
        Me.gbServiceDetails = New System.Windows.Forms.GroupBox()
        Me.btnConsumables = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.servnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.servstatus = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbServiceDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvServiceList
        '
        Me.dgvServiceList.AllowUserToAddRows = False
        Me.dgvServiceList.AllowUserToDeleteRows = False
        Me.dgvServiceList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvServiceList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServiceList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServiceList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiceList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvServiceList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvServiceList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.servnum, Me.servname, Me.servprice, Me.servtype, Me.servstatus})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServiceList.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServiceList.DoubleBuffered = True
        Me.dgvServiceList.EnableHeadersVisualStyles = False
        Me.dgvServiceList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvServiceList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvServiceList.Location = New System.Drawing.Point(12, 78)
        Me.dgvServiceList.MultiSelect = False
        Me.dgvServiceList.Name = "dgvServiceList"
        Me.dgvServiceList.ReadOnly = True
        Me.dgvServiceList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvServiceList.RowHeadersVisible = False
        Me.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceList.Size = New System.Drawing.Size(920, 415)
        Me.dgvServiceList.TabIndex = 9
        '
        'btnExportServices
        '
        Me.btnExportServices.Activecolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportServices.BackColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnExportServices.BorderRadius = 7
        Me.btnExportServices.ButtonText = "Export List"
        Me.btnExportServices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExportServices.DisabledColor = System.Drawing.Color.Gray
        Me.btnExportServices.Iconcolor = System.Drawing.Color.Transparent
        Me.btnExportServices.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_5_
        Me.btnExportServices.Iconimage_right = Nothing
        Me.btnExportServices.Iconimage_right_Selected = Nothing
        Me.btnExportServices.Iconimage_Selected = Nothing
        Me.btnExportServices.IconMarginLeft = 0
        Me.btnExportServices.IconMarginRight = 0
        Me.btnExportServices.IconRightVisible = True
        Me.btnExportServices.IconRightZoom = 0R
        Me.btnExportServices.IconVisible = True
        Me.btnExportServices.IconZoom = 90.0R
        Me.btnExportServices.IsTab = False
        Me.btnExportServices.Location = New System.Drawing.Point(951, 282)
        Me.btnExportServices.Name = "btnExportServices"
        Me.btnExportServices.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(207, Byte), Integer))
        Me.btnExportServices.OnHoverTextColor = System.Drawing.Color.White
        Me.btnExportServices.selected = False
        Me.btnExportServices.Size = New System.Drawing.Size(191, 48)
        Me.btnExportServices.TabIndex = 15
        Me.btnExportServices.Text = "Export List"
        Me.btnExportServices.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExportServices.Textcolor = System.Drawing.Color.White
        Me.btnExportServices.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnUpdateService
        '
        Me.btnUpdateService.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateService.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateService.BorderRadius = 7
        Me.btnUpdateService.ButtonText = "Update Service"
        Me.btnUpdateService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateService.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateService.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateService.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateService.Iconimage_right = Nothing
        Me.btnUpdateService.Iconimage_right_Selected = Nothing
        Me.btnUpdateService.Iconimage_Selected = Nothing
        Me.btnUpdateService.IconMarginLeft = 0
        Me.btnUpdateService.IconMarginRight = 0
        Me.btnUpdateService.IconRightVisible = True
        Me.btnUpdateService.IconRightZoom = 0R
        Me.btnUpdateService.IconVisible = True
        Me.btnUpdateService.IconZoom = 90.0R
        Me.btnUpdateService.IsTab = False
        Me.btnUpdateService.Location = New System.Drawing.Point(951, 336)
        Me.btnUpdateService.Name = "btnUpdateService"
        Me.btnUpdateService.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateService.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateService.selected = False
        Me.btnUpdateService.Size = New System.Drawing.Size(191, 48)
        Me.btnUpdateService.TabIndex = 12
        Me.btnUpdateService.Text = "Update Service"
        Me.btnUpdateService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateService.Textcolor = System.Drawing.Color.White
        Me.btnUpdateService.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnCreateService
        '
        Me.btnCreateService.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreateService.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCreateService.BorderRadius = 7
        Me.btnCreateService.ButtonText = "Add Service"
        Me.btnCreateService.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreateService.DisabledColor = System.Drawing.Color.Gray
        Me.btnCreateService.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCreateService.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnCreateService.Iconimage_right = Nothing
        Me.btnCreateService.Iconimage_right_Selected = Nothing
        Me.btnCreateService.Iconimage_Selected = Nothing
        Me.btnCreateService.IconMarginLeft = 0
        Me.btnCreateService.IconMarginRight = 0
        Me.btnCreateService.IconRightVisible = True
        Me.btnCreateService.IconRightZoom = 0R
        Me.btnCreateService.IconVisible = True
        Me.btnCreateService.IconZoom = 90.0R
        Me.btnCreateService.IsTab = False
        Me.btnCreateService.Location = New System.Drawing.Point(951, 174)
        Me.btnCreateService.Name = "btnCreateService"
        Me.btnCreateService.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnCreateService.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCreateService.selected = False
        Me.btnCreateService.Size = New System.Drawing.Size(191, 48)
        Me.btnCreateService.TabIndex = 10
        Me.btnCreateService.Text = "Add Service"
        Me.btnCreateService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreateService.Textcolor = System.Drawing.Color.White
        Me.btnCreateService.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Service Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 16)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Service Type:"
        '
        'txtServiceName
        '
        Me.txtServiceName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtServiceName.BorderColorFocused = System.Drawing.Color.HotPink
        Me.txtServiceName.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServiceName.BorderColorMouseHover = System.Drawing.Color.HotPink
        Me.txtServiceName.BorderThickness = 3
        Me.txtServiceName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtServiceName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtServiceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtServiceName.isPassword = False
        Me.txtServiceName.Location = New System.Drawing.Point(135, 23)
        Me.txtServiceName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.Size = New System.Drawing.Size(0, 31)
        Me.txtServiceName.TabIndex = 28
        Me.txtServiceName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.AutoSize = True
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Depth = 0
        Me.btnSave.Location = New System.Drawing.Point(239, 438)
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
        Me.btnCancel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.AutoSize = True
        Me.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(293, 438)
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
        Me.Label11.Location = New System.Drawing.Point(15, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 16)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Status:"
        '
        'switchServiceStatus
        '
        Me.switchServiceStatus.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.switchServiceStatus.BorderRadius = 0
        Me.switchServiceStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.switchServiceStatus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.switchServiceStatus.Location = New System.Drawing.Point(139, 99)
        Me.switchServiceStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.switchServiceStatus.Name = "switchServiceStatus"
        Me.switchServiceStatus.Oncolor = System.Drawing.Color.SeaGreen
        Me.switchServiceStatus.Onoffcolor = System.Drawing.Color.DarkGray
        Me.switchServiceStatus.Size = New System.Drawing.Size(51, 19)
        Me.switchServiceStatus.TabIndex = 40
        Me.switchServiceStatus.Textcolor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.switchServiceStatus.Value = True
        '
        'txtRemarks
        '
        Me.txtRemarks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemarks.BorderColor = System.Drawing.Color.SeaGreen
        Me.txtRemarks.Location = New System.Drawing.Point(139, 125)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemarks.Size = New System.Drawing.Size(0, 209)
        Me.txtRemarks.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Description:"
        '
        'rdoBody
        '
        Me.rdoBody.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoBody.AutoSize = True
        Me.rdoBody.Location = New System.Drawing.Point(139, 66)
        Me.rdoBody.Name = "rdoBody"
        Me.rdoBody.Size = New System.Drawing.Size(51, 26)
        Me.rdoBody.TabIndex = 57
        Me.rdoBody.Text = "Body"
        Me.rdoBody.UseVisualStyleBackColor = True
        '
        'rdoHair
        '
        Me.rdoHair.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHair.AutoSize = True
        Me.rdoHair.Location = New System.Drawing.Point(251, 66)
        Me.rdoHair.Name = "rdoHair"
        Me.rdoHair.Size = New System.Drawing.Size(45, 26)
        Me.rdoHair.TabIndex = 57
        Me.rdoHair.Text = "Hair"
        Me.rdoHair.UseVisualStyleBackColor = True
        '
        'rdoFace
        '
        Me.rdoFace.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoFace.AutoSize = True
        Me.rdoFace.Location = New System.Drawing.Point(196, 66)
        Me.rdoFace.Name = "rdoFace"
        Me.rdoFace.Size = New System.Drawing.Size(49, 26)
        Me.rdoFace.TabIndex = 58
        Me.rdoFace.Text = "Face"
        Me.rdoFace.UseVisualStyleBackColor = True
        '
        'rdoNails
        '
        Me.rdoNails.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoNails.AutoSize = True
        Me.rdoNails.Location = New System.Drawing.Point(302, 66)
        Me.rdoNails.Name = "rdoNails"
        Me.rdoNails.Size = New System.Drawing.Size(51, 26)
        Me.rdoNails.TabIndex = 58
        Me.rdoNails.Text = "Nails"
        Me.rdoNails.UseVisualStyleBackColor = True
        '
        'gbServiceDetails
        '
        Me.gbServiceDetails.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbServiceDetails.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.gbServiceDetails.Controls.Add(Me.rdoNails)
        Me.gbServiceDetails.Controls.Add(Me.rdoFace)
        Me.gbServiceDetails.Controls.Add(Me.rdoHair)
        Me.gbServiceDetails.Controls.Add(Me.rdoBody)
        Me.gbServiceDetails.Controls.Add(Me.Label4)
        Me.gbServiceDetails.Controls.Add(Me.txtRemarks)
        Me.gbServiceDetails.Controls.Add(Me.switchServiceStatus)
        Me.gbServiceDetails.Controls.Add(Me.Label11)
        Me.gbServiceDetails.Controls.Add(Me.btnCancel)
        Me.gbServiceDetails.Controls.Add(Me.btnSave)
        Me.gbServiceDetails.Controls.Add(Me.txtServiceName)
        Me.gbServiceDetails.Controls.Add(Me.Label5)
        Me.gbServiceDetails.Controls.Add(Me.Label3)
        Me.gbServiceDetails.Enabled = False
        Me.gbServiceDetails.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbServiceDetails.Location = New System.Drawing.Point(951, 12)
        Me.gbServiceDetails.Name = "gbServiceDetails"
        Me.gbServiceDetails.Size = New System.Drawing.Size(10, 10)
        Me.gbServiceDetails.TabIndex = 29
        Me.gbServiceDetails.TabStop = False
        Me.gbServiceDetails.Text = "Service Details"
        Me.gbServiceDetails.Visible = False
        '
        'btnConsumables
        '
        Me.btnConsumables.Activecolor = System.Drawing.Color.LightSeaGreen
        Me.btnConsumables.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConsumables.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnConsumables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConsumables.BorderRadius = 7
        Me.btnConsumables.ButtonText = "Add Consumables"
        Me.btnConsumables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConsumables.DisabledColor = System.Drawing.Color.Gray
        Me.btnConsumables.Iconcolor = System.Drawing.Color.Transparent
        Me.btnConsumables.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_5_
        Me.btnConsumables.Iconimage_right = Nothing
        Me.btnConsumables.Iconimage_right_Selected = Nothing
        Me.btnConsumables.Iconimage_Selected = Nothing
        Me.btnConsumables.IconMarginLeft = 0
        Me.btnConsumables.IconMarginRight = 0
        Me.btnConsumables.IconRightVisible = True
        Me.btnConsumables.IconRightZoom = 0R
        Me.btnConsumables.IconVisible = True
        Me.btnConsumables.IconZoom = 90.0R
        Me.btnConsumables.IsTab = False
        Me.btnConsumables.Location = New System.Drawing.Point(951, 228)
        Me.btnConsumables.Name = "btnConsumables"
        Me.btnConsumables.Normalcolor = System.Drawing.Color.LightSeaGreen
        Me.btnConsumables.OnHovercolor = System.Drawing.Color.Turquoise
        Me.btnConsumables.OnHoverTextColor = System.Drawing.Color.White
        Me.btnConsumables.selected = False
        Me.btnConsumables.Size = New System.Drawing.Size(191, 48)
        Me.btnConsumables.TabIndex = 30
        Me.btnConsumables.Text = "Add Consumables"
        Me.btnConsumables.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConsumables.Textcolor = System.Drawing.Color.White
        Me.btnConsumables.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(256, 39)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 34
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtSearch
        '
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
        Me.txtSearch.Location = New System.Drawing.Point(13, 38)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 33)
        Me.txtSearch.TabIndex = 33
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'servnum
        '
        Me.servnum.DataPropertyName = "Service Number"
        Me.servnum.HeaderText = "Service Number"
        Me.servnum.Name = "servnum"
        Me.servnum.ReadOnly = True
        '
        'servname
        '
        Me.servname.DataPropertyName = "Service Name"
        Me.servname.HeaderText = "Service Name"
        Me.servname.Name = "servname"
        Me.servname.ReadOnly = True
        '
        'servprice
        '
        Me.servprice.DataPropertyName = "Service Price"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.servprice.DefaultCellStyle = DataGridViewCellStyle3
        Me.servprice.HeaderText = "Service Price"
        Me.servprice.Name = "servprice"
        Me.servprice.ReadOnly = True
        '
        'servtype
        '
        Me.servtype.DataPropertyName = "Type"
        Me.servtype.HeaderText = "Type"
        Me.servtype.Name = "servtype"
        Me.servtype.ReadOnly = True
        '
        'servstatus
        '
        Me.servstatus.DataPropertyName = "Status"
        Me.servstatus.HeaderText = "Status"
        Me.servstatus.Name = "servstatus"
        Me.servstatus.ReadOnly = True
        '
        'frmServices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.btnConsumables)
        Me.Controls.Add(Me.gbServiceDetails)
        Me.Controls.Add(Me.btnExportServices)
        Me.Controls.Add(Me.btnUpdateService)
        Me.Controls.Add(Me.btnCreateService)
        Me.Controls.Add(Me.dgvServiceList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmServices"
        Me.Text = "Hair"
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbServiceDetails.ResumeLayout(False)
        Me.gbServiceDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExportServices As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnUpdateService As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnCreateService As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvServiceList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents gbServiceDetails As GroupBox
    Friend WithEvents rdoNails As RadioButton
    Friend WithEvents rdoFace As RadioButton
    Friend WithEvents rdoHair As RadioButton
    Friend WithEvents rdoBody As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents txtRemarks As WindowsFormsControlLibrary1.BunifuCustomTextbox
    Friend WithEvents switchServiceStatus As Bunifu.Framework.UI.BunifuSwitch
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtServiceName As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConsumables As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents servnum As DataGridViewTextBoxColumn
    Friend WithEvents servname As DataGridViewTextBoxColumn
    Friend WithEvents servprice As DataGridViewTextBoxColumn
    Friend WithEvents servtype As DataGridViewTextBoxColumn
    Friend WithEvents servstatus As DataGridViewTextBoxColumn
End Class
