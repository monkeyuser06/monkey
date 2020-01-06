<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentTransactions
    Inherits MetroFramework.Forms.MetroForm

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
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointmentTransactions))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSave_1 = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.txtName = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtContactNumber = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvServiceListing = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.serv_availid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServiceID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.service_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_assigned = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.service_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvReserveList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.serv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAdd = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuImageButton()
        Me.labelConsumed = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.dgvItemConsumed = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ItemID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.consumed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvOfferings = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.sid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sprice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.savailability = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblTotal = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblShownone = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSasve = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvServiceListing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReserveList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemConsumed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOfferings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSave_1)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.txtContactNumber)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 139)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'btnSave_1
        '
        Me.btnSave_1.Depth = 0
        Me.btnSave_1.Location = New System.Drawing.Point(160, 101)
        Me.btnSave_1.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave_1.Name = "btnSave_1"
        Me.btnSave_1.Primary = True
        Me.btnSave_1.Size = New System.Drawing.Size(85, 29)
        Me.btnSave_1.TabIndex = 64
        Me.btnSave_1.Text = "SAVE"
        Me.btnSave_1.UseVisualStyleBackColor = True
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
        'dgvServiceListing
        '
        Me.dgvServiceListing.AllowUserToAddRows = False
        Me.dgvServiceListing.AllowUserToDeleteRows = False
        Me.dgvServiceListing.AllowUserToResizeColumns = False
        Me.dgvServiceListing.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvServiceListing.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServiceListing.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiceListing.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvServiceListing.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvServiceListing.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvServiceListing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvServiceListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceListing.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serv_availid, Me.ServiceID, Me.service_name, Me.emp_assigned, Me.service_price})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServiceListing.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvServiceListing.DoubleBuffered = True
        Me.dgvServiceListing.EnableHeadersVisualStyles = False
        Me.dgvServiceListing.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvServiceListing.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvServiceListing.Location = New System.Drawing.Point(12, 188)
        Me.dgvServiceListing.MultiSelect = False
        Me.dgvServiceListing.Name = "dgvServiceListing"
        Me.dgvServiceListing.ReadOnly = True
        Me.dgvServiceListing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServiceListing.RowHeadersVisible = False
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvServiceListing.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowTemplate.ReadOnly = True
        Me.dgvServiceListing.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvServiceListing.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceListing.Size = New System.Drawing.Size(413, 246)
        Me.dgvServiceListing.TabIndex = 45
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
        'dgvReserveList
        '
        Me.dgvReserveList.AllowUserToAddRows = False
        Me.dgvReserveList.AllowUserToDeleteRows = False
        Me.dgvReserveList.AllowUserToResizeColumns = False
        Me.dgvReserveList.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvReserveList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvReserveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReserveList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReserveList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvReserveList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReserveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvReserveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserveList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serv_id, Me.serv_name, Me.price, Me.type, Me.status})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReserveList.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgvReserveList.DoubleBuffered = True
        Me.dgvReserveList.EnableHeadersVisualStyles = False
        Me.dgvReserveList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvReserveList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvReserveList.Location = New System.Drawing.Point(437, 73)
        Me.dgvReserveList.MultiSelect = False
        Me.dgvReserveList.Name = "dgvReserveList"
        Me.dgvReserveList.ReadOnly = True
        Me.dgvReserveList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvReserveList.RowHeadersVisible = False
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.dgvReserveList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.RowTemplate.ReadOnly = True
        Me.dgvReserveList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvReserveList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvReserveList.Size = New System.Drawing.Size(370, 194)
        Me.dgvReserveList.TabIndex = 46
        '
        'serv_id
        '
        Me.serv_id.DataPropertyName = "ServiceID"
        Me.serv_id.HeaderText = "ServiceID"
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
        'price
        '
        Me.price.DataPropertyName = "ServicePrice"
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'type
        '
        Me.type.DataPropertyName = "ServiceType"
        Me.type.HeaderText = "Type"
        Me.type.Name = "type"
        Me.type.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "Service_Availability"
        Me.status.HeaderText = "Availability"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(434, 53)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(80, 17)
        Me.BunifuCustomLabel1.TabIndex = 61
        Me.BunifuCustomLabel1.Text = "Service List:"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Image = Global.InventoryManager.My.Resources.Resources.plus_3_
        Me.btnAdd.ImageActive = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(782, 44)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(25, 25)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.TabStop = False
        Me.btnAdd.Zoom = 10
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.Image = Global.InventoryManager.My.Resources.Resources.minus
        Me.btnRemove.ImageActive = Nothing
        Me.btnRemove.Location = New System.Drawing.Point(400, 157)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRemove.TabIndex = 56
        Me.btnRemove.TabStop = False
        Me.btnRemove.Zoom = 10
        '
        'labelConsumed
        '
        Me.labelConsumed.AutoSize = True
        Me.labelConsumed.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.labelConsumed.Location = New System.Drawing.Point(537, 299)
        Me.labelConsumed.Name = "labelConsumed"
        Me.labelConsumed.Size = New System.Drawing.Size(168, 17)
        Me.labelConsumed.TabIndex = 65
        Me.labelConsumed.Text = "No Items Consumed Yet."
        '
        'dgvItemConsumed
        '
        Me.dgvItemConsumed.AllowUserToAddRows = False
        Me.dgvItemConsumed.AllowUserToDeleteRows = False
        Me.dgvItemConsumed.AllowUserToResizeColumns = False
        Me.dgvItemConsumed.AllowUserToResizeRows = False
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemConsumed.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvItemConsumed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemConsumed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvItemConsumed.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemConsumed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemConsumed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.dgvItemConsumed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemConsumed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.brand, Me.desc, Me.consumed})
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemConsumed.DefaultCellStyle = DataGridViewCellStyle13
        Me.dgvItemConsumed.DoubleBuffered = True
        Me.dgvItemConsumed.EnableHeadersVisualStyles = False
        Me.dgvItemConsumed.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemConsumed.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemConsumed.Location = New System.Drawing.Point(437, 271)
        Me.dgvItemConsumed.MultiSelect = False
        Me.dgvItemConsumed.Name = "dgvItemConsumed"
        Me.dgvItemConsumed.ReadOnly = True
        Me.dgvItemConsumed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvItemConsumed.RowHeadersVisible = False
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvItemConsumed.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowTemplate.ReadOnly = True
        Me.dgvItemConsumed.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvItemConsumed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemConsumed.Size = New System.Drawing.Size(370, 157)
        Me.dgvItemConsumed.TabIndex = 64
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
        'dgvOfferings
        '
        Me.dgvOfferings.AllowUserToAddRows = False
        Me.dgvOfferings.AllowUserToDeleteRows = False
        Me.dgvOfferings.AllowUserToResizeColumns = False
        Me.dgvOfferings.AllowUserToResizeRows = False
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvOfferings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvOfferings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOfferings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvOfferings.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvOfferings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOfferings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.dgvOfferings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOfferings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sid, Me.sname, Me.sprice, Me.stype, Me.savailability})
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOfferings.DefaultCellStyle = DataGridViewCellStyle18
        Me.dgvOfferings.DoubleBuffered = True
        Me.dgvOfferings.EnableHeadersVisualStyles = False
        Me.dgvOfferings.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvOfferings.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvOfferings.Location = New System.Drawing.Point(813, 73)
        Me.dgvOfferings.MultiSelect = False
        Me.dgvOfferings.Name = "dgvOfferings"
        Me.dgvOfferings.ReadOnly = True
        Me.dgvOfferings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvOfferings.RowHeadersVisible = False
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.RowsDefaultCellStyle = DataGridViewCellStyle20
        Me.dgvOfferings.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.RowTemplate.ReadOnly = True
        Me.dgvOfferings.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvOfferings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOfferings.Size = New System.Drawing.Size(356, 405)
        Me.dgvOfferings.TabIndex = 67
        '
        'sid
        '
        Me.sid.DataPropertyName = "ServiceID"
        Me.sid.HeaderText = "ServiceID"
        Me.sid.Name = "sid"
        Me.sid.ReadOnly = True
        Me.sid.Visible = False
        '
        'sname
        '
        Me.sname.DataPropertyName = "ServiceName"
        Me.sname.HeaderText = "Service Name"
        Me.sname.Name = "sname"
        Me.sname.ReadOnly = True
        '
        'sprice
        '
        Me.sprice.DataPropertyName = "ServicePrice"
        Me.sprice.HeaderText = "Price"
        Me.sprice.Name = "sprice"
        Me.sprice.ReadOnly = True
        '
        'stype
        '
        Me.stype.DataPropertyName = "ServiceType"
        Me.stype.HeaderText = "Type"
        Me.stype.Name = "stype"
        Me.stype.ReadOnly = True
        '
        'savailability
        '
        Me.savailability.DataPropertyName = "Service_Availability"
        Me.savailability.HeaderText = "Availability"
        Me.savailability.Name = "savailability"
        Me.savailability.ReadOnly = True
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(277, 437)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(75, 16)
        Me.BunifuCustomLabel5.TabIndex = 68
        Me.BunifuCustomLabel5.Text = "Total Price"
        '
        'lblTotal
        '
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblTotal.Location = New System.Drawing.Point(357, 437)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTotal.Size = New System.Drawing.Size(71, 17)
        Me.lblTotal.TabIndex = 69
        Me.lblTotal.Text = "0"
        '
        'lblShownone
        '
        Me.lblShownone.AutoSize = True
        Me.lblShownone.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.lblShownone.Location = New System.Drawing.Point(133, 244)
        Me.lblShownone.Name = "lblShownone"
        Me.lblShownone.Size = New System.Drawing.Size(163, 17)
        Me.lblShownone.TabIndex = 70
        Me.lblShownone.Text = "No Service Selected Yet."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(319, 159)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSasve
        '
        Me.btnSasve.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSasve.Location = New System.Drawing.Point(447, 472)
        Me.btnSasve.Name = "btnSasve"
        Me.btnSasve.Size = New System.Drawing.Size(91, 27)
        Me.btnSasve.TabIndex = 72
        Me.btnSasve.Text = "Save"
        Me.btnSasve.UseVisualStyleBackColor = True
        '
        'frmAppointmentTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 522)
        Me.Controls.Add(Me.btnSasve)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblShownone)
        Me.Controls.Add(Me.BunifuCustomLabel5)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.dgvOfferings)
        Me.Controls.Add(Me.labelConsumed)
        Me.Controls.Add(Me.dgvItemConsumed)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dgvReserveList)
        Me.Controls.Add(Me.dgvServiceListing)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAppointmentTransactions"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvServiceListing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReserveList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemConsumed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOfferings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtContactNumber As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvServiceListing As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents serv_availid As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents service_name As DataGridViewTextBoxColumn
    Friend WithEvents emp_assigned As DataGridViewTextBoxColumn
    Friend WithEvents service_price As DataGridViewTextBoxColumn
    Friend WithEvents dgvReserveList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSave_1 As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents labelConsumed As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgvItemConsumed As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents consumed As DataGridViewTextBoxColumn
    Friend WithEvents dgvOfferings As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents sid As DataGridViewTextBoxColumn
    Friend WithEvents sname As DataGridViewTextBoxColumn
    Friend WithEvents sprice As DataGridViewTextBoxColumn
    Friend WithEvents stype As DataGridViewTextBoxColumn
    Friend WithEvents savailability As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTotal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblShownone As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents serv_id As DataGridViewTextBoxColumn
    Friend WithEvents serv_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSasve As Button
End Class
