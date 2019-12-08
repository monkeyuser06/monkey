<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServiceCheckout
    Inherits MetroFramework.Forms.MetroForm
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceCheckout))
        Me.txtSearchServ = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvSearchService = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.serv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv_class = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvServiceListing = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.serv_availid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.service_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_assigned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.service_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtContactNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTotal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave_1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.lblShownone = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.labl1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgvItemConsumed = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consumed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.labelConsumed = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvSearchService, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServiceListing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemConsumed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchServ
        '
        Me.txtSearchServ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchServ.Enabled = False
        Me.txtSearchServ.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchServ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchServ.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchServ.HintText = "Search Service"
        Me.txtSearchServ.isPassword = False
        Me.txtSearchServ.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtSearchServ.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearchServ.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtSearchServ.LineThickness = 3
        Me.txtSearchServ.Location = New System.Drawing.Point(732, 64)
        Me.txtSearchServ.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchServ.Name = "txtSearchServ"
        Me.txtSearchServ.Size = New System.Drawing.Size(160, 33)
        Me.txtSearchServ.TabIndex = 41
        Me.txtSearchServ.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvSearchService
        '
        Me.dgvSearchService.AllowUserToAddRows = False
        Me.dgvSearchService.AllowUserToDeleteRows = False
        Me.dgvSearchService.AllowUserToResizeColumns = False
        Me.dgvSearchService.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSearchService.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchService.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearchService.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvSearchService.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearchService.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchService.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchService.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearchService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchService.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serv_id, Me.serv_name, Me.serv_class, Me.serv_price, Me.status})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchService.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSearchService.DoubleBuffered = True
        Me.dgvSearchService.Enabled = False
        Me.dgvSearchService.EnableHeadersVisualStyles = False
        Me.dgvSearchService.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvSearchService.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvSearchService.Location = New System.Drawing.Point(429, 102)
        Me.dgvSearchService.MultiSelect = False
        Me.dgvSearchService.Name = "dgvSearchService"
        Me.dgvSearchService.ReadOnly = True
        Me.dgvSearchService.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearchService.RowHeadersVisible = False
        Me.dgvSearchService.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchService.RowTemplate.ReadOnly = True
        Me.dgvSearchService.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchService.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchService.Size = New System.Drawing.Size(503, 193)
        Me.dgvSearchService.TabIndex = 43
        '
        'serv_id
        '
        Me.serv_id.DataPropertyName = "ServiceID"
        Me.serv_id.HeaderText = "Service ID"
        Me.serv_id.Name = "serv_id"
        Me.serv_id.ReadOnly = True
        Me.serv_id.Visible = False
        '
        'serv_name
        '
        Me.serv_name.DataPropertyName = "ServiceName"
        Me.serv_name.HeaderText = "Service Name"
        Me.serv_name.Name = "serv_name"
        Me.serv_name.ReadOnly = True
        '
        'serv_class
        '
        Me.serv_class.DataPropertyName = "ServiceType"
        Me.serv_class.HeaderText = "Type"
        Me.serv_class.Name = "serv_class"
        Me.serv_class.ReadOnly = True
        '
        'serv_price
        '
        Me.serv_price.DataPropertyName = "ServicePrice"
        Me.serv_price.HeaderText = "Price"
        Me.serv_price.Name = "serv_price"
        Me.serv_price.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "Service_Availability"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'dgvServiceListing
        '
        Me.dgvServiceListing.AllowUserToAddRows = False
        Me.dgvServiceListing.AllowUserToDeleteRows = False
        Me.dgvServiceListing.AllowUserToResizeColumns = False
        Me.dgvServiceListing.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvServiceListing.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServiceListing.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvServiceListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiceListing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvServiceListing.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvServiceListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvServiceListing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvServiceListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serv_availid, Me.ServiceID, Me.service_name, Me.emp_assigned, Me.service_price})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServiceListing.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvServiceListing.DoubleBuffered = True
        Me.dgvServiceListing.Enabled = False
        Me.dgvServiceListing.EnableHeadersVisualStyles = False
        Me.dgvServiceListing.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvServiceListing.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvServiceListing.Location = New System.Drawing.Point(10, 253)
        Me.dgvServiceListing.MultiSelect = False
        Me.dgvServiceListing.Name = "dgvServiceListing"
        Me.dgvServiceListing.ReadOnly = True
        Me.dgvServiceListing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvServiceListing.RowHeadersVisible = False
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvServiceListing.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowTemplate.ReadOnly = True
        Me.dgvServiceListing.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvServiceListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceListing.Size = New System.Drawing.Size(413, 232)
        Me.dgvServiceListing.TabIndex = 44
        '
        'serv_availid
        '
        Me.serv_availid.DataPropertyName = "ServiceAvailedID"
        Me.serv_availid.HeaderText = "ServiceAvailedID"
        Me.serv_availid.Name = "serv_availid"
        Me.serv_availid.ReadOnly = True
        Me.serv_availid.Visible = False
        '
        'ServiceID
        '
        Me.ServiceID.DataPropertyName = "ServiceID"
        Me.ServiceID.HeaderText = "ServiceID"
        Me.ServiceID.Name = "ServiceID"
        Me.ServiceID.ReadOnly = True
        Me.ServiceID.Visible = False
        '
        'service_name
        '
        Me.service_name.DataPropertyName = "ServiceName"
        Me.service_name.HeaderText = "Service Name"
        Me.service_name.Name = "service_name"
        Me.service_name.ReadOnly = True
        '
        'emp_assigned
        '
        Me.emp_assigned.DataPropertyName = "Emp_Fullname"
        Me.emp_assigned.HeaderText = "Employee Assigned"
        Me.emp_assigned.Name = "emp_assigned"
        Me.emp_assigned.ReadOnly = True
        '
        'service_price
        '
        Me.service_price.DataPropertyName = "ServicePrice"
        Me.service_price.HeaderText = "Price"
        Me.service_price.Name = "service_price"
        Me.service_price.ReadOnly = True
        '
        'txtName
        '
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.HintForeColor = System.Drawing.Color.Gray
        Me.txtName.HintText = "Customer Name"
        Me.txtName.isPassword = False
        Me.txtName.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtName.LineIdleColor = System.Drawing.Color.Gray
        Me.txtName.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtName.LineThickness = 3
        Me.txtName.Location = New System.Drawing.Point(7, 20)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 33)
        Me.txtName.TabIndex = 1
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtContactNumber.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtContactNumber.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtContactNumber.HintForeColor = System.Drawing.Color.Gray
        Me.txtContactNumber.HintText = "Contact Number"
        Me.txtContactNumber.isPassword = False
        Me.txtContactNumber.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtContactNumber.LineIdleColor = System.Drawing.Color.Gray
        Me.txtContactNumber.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtContactNumber.LineThickness = 3
        Me.txtContactNumber.Location = New System.Drawing.Point(245, 20)
        Me.txtContactNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(137, 33)
        Me.txtContactNumber.TabIndex = 2
        Me.txtContactNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtAddress
        '
        Me.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAddress.HintForeColor = System.Drawing.Color.Gray
        Me.txtAddress.HintText = "Address"
        Me.txtAddress.isPassword = False
        Me.txtAddress.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtAddress.LineIdleColor = System.Drawing.Color.Gray
        Me.txtAddress.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtAddress.LineThickness = 3
        Me.txtAddress.Location = New System.Drawing.Point(7, 61)
        Me.txtAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(375, 33)
        Me.txtAddress.TabIndex = 3
        Me.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(7, 233)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(121, 17)
        Me.BunifuCustomLabel2.TabIndex = 50
        Me.BunifuCustomLabel2.Text = "Service/s Availed:"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblTotal.Location = New System.Drawing.Point(323, 488)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.Size = New System.Drawing.Size(71, 17)
        Me.lblTotal.TabIndex = 51
        Me.lblTotal.Text = "0"
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(243, 488)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(75, 16)
        Me.BunifuCustomLabel5.TabIndex = 51
        Me.BunifuCustomLabel5.Text = "Total Price"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave_1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtContactNumber)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 159)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'btnSave_1
        '
        Me.btnSave_1.Depth = 0
        Me.btnSave_1.Location = New System.Drawing.Point(164, 112)
        Me.btnSave_1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave_1.Name = "btnSave_1"
        Me.btnSave_1.Primary = True
        Me.btnSave_1.Size = New System.Drawing.Size(85, 29)
        Me.btnSave_1.TabIndex = 54
        Me.btnSave_1.Text = "SAVE"
        Me.btnSave_1.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Depth = 0
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(429, 526)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = True
        Me.btnSave.Size = New System.Drawing.Size(85, 29)
        Me.btnSave.TabIndex = 53
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblShownone
        '
        Me.lblShownone.AutoSize = True
        Me.lblShownone.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblShownone.Location = New System.Drawing.Point(149, 309)
        Me.lblShownone.Name = "lblShownone"
        Me.lblShownone.Size = New System.Drawing.Size(137, 17)
        Me.lblShownone.TabIndex = 54
        Me.lblShownone.Text = "No service selected."
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'labl1
        '
        Me.labl1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.labl1.Location = New System.Drawing.Point(31, 488)
        Me.labl1.Name = "labl1"
        Me.labl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.labl1.Size = New System.Drawing.Size(17, 17)
        Me.labl1.TabIndex = 55
        '
        'dgvItemConsumed
        '
        Me.dgvItemConsumed.AllowUserToAddRows = False
        Me.dgvItemConsumed.AllowUserToDeleteRows = False
        Me.dgvItemConsumed.AllowUserToResizeColumns = False
        Me.dgvItemConsumed.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemConsumed.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvItemConsumed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemConsumed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemConsumed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvItemConsumed.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemConsumed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemConsumed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvItemConsumed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemConsumed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.brand, Me.desc, Me.consumed})
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemConsumed.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgvItemConsumed.DoubleBuffered = True
        Me.dgvItemConsumed.Enabled = False
        Me.dgvItemConsumed.EnableHeadersVisualStyles = False
        Me.dgvItemConsumed.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemConsumed.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemConsumed.Location = New System.Drawing.Point(429, 329)
        Me.dgvItemConsumed.MultiSelect = False
        Me.dgvItemConsumed.Name = "dgvItemConsumed"
        Me.dgvItemConsumed.ReadOnly = True
        Me.dgvItemConsumed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvItemConsumed.RowHeadersVisible = False
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvItemConsumed.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowTemplate.ReadOnly = True
        Me.dgvItemConsumed.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvItemConsumed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemConsumed.Size = New System.Drawing.Size(494, 184)
        Me.dgvItemConsumed.TabIndex = 56
        '
        'ItemID
        '
        Me.ItemID.DataPropertyName = "ItemID"
        Me.ItemID.HeaderText = "ItemID"
        Me.ItemID.Name = "ItemID"
        Me.ItemID.ReadOnly = True
        Me.ItemID.Visible = False
        '
        'brand
        '
        Me.brand.DataPropertyName = "ItemBrand"
        Me.brand.HeaderText = "Brand"
        Me.brand.Name = "brand"
        Me.brand.ReadOnly = True
        '
        'desc
        '
        Me.desc.DataPropertyName = "ItemDescription"
        Me.desc.HeaderText = "Description"
        Me.desc.Name = "desc"
        Me.desc.ReadOnly = True
        '
        'consumed
        '
        Me.consumed.DataPropertyName = "Consumed"
        Me.consumed.HeaderText = "Consumed"
        Me.consumed.Name = "consumed"
        Me.consumed.ReadOnly = True
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(426, 309)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(123, 17)
        Me.BunifuCustomLabel1.TabIndex = 58
        Me.BunifuCustomLabel1.Text = "Item/s Consumed"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(428, 82)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(80, 17)
        Me.BunifuCustomLabel3.TabIndex = 59
        Me.BunifuCustomLabel3.Text = "Service List:"
        '
        'labelConsumed
        '
        Me.labelConsumed.AutoSize = True
        Me.labelConsumed.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.labelConsumed.Location = New System.Drawing.Point(595, 357)
        Me.labelConsumed.Name = "labelConsumed"
        Me.labelConsumed.Size = New System.Drawing.Size(168, 17)
        Me.labelConsumed.TabIndex = 60
        Me.labelConsumed.Text = "No Items Consumed Yet."
        '
        'btnSearch
        '
        Me.btnSearch.Enabled = False
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(899, 63)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 42
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.Image = Global.InventoryManager.My.Resources.Resources.minus
        Me.btnRemove.ImageActive = Nothing
        Me.btnRemove.Location = New System.Drawing.Point(398, 225)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRemove.TabIndex = 55
        Me.btnRemove.TabStop = False
        Me.btnRemove.Zoom = 10
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(319, 226)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "REFRESH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmServiceCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 569)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.labelConsumed)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.dgvItemConsumed)
        Me.Controls.Add(Me.labl1)
        Me.Controls.Add(Me.lblShownone)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.dgvServiceListing)
        Me.Controls.Add(Me.txtSearchServ)
        Me.Controls.Add(Me.dgvSearchService)
        Me.Controls.Add(Me.btnSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServiceCheckout"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Service Order"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.dgvSearchService, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServiceListing, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemConsumed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchServ As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvSearchService As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSearch As Button
    Friend WithEvents dgvServiceListing As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtContactNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTotal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lblShownone As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents serv_availid As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents service_name As DataGridViewTextBoxColumn
    Friend WithEvents emp_assigned As DataGridViewTextBoxColumn
    Friend WithEvents service_price As DataGridViewTextBoxColumn
    Friend WithEvents serv_id As DataGridViewTextBoxColumn
    Friend WithEvents serv_name As DataGridViewTextBoxColumn
    Friend WithEvents serv_class As DataGridViewTextBoxColumn
    Friend WithEvents serv_price As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents labl1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnSave_1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents dgvItemConsumed As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents consumed As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelConsumed As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Button1 As Button
End Class
