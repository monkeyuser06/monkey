<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAppointmentTransactions
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointmentTransactions))
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
        Me.btnRemove = New Bunifu.Framework.UI.BunifuImageButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSaveTransaction = New System.Windows.Forms.Button()
        Me.cboAppointmentTime = New System.Windows.Forms.ComboBox()
        Me.dtpAppointmentDate = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontact1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnAdd = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.dgvServiceListing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvReserveList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemConsumed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvOfferings, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvServiceListing.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvServiceListing.DoubleBuffered = True
        Me.dgvServiceListing.EnableHeadersVisualStyles = False
        Me.dgvServiceListing.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvServiceListing.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvServiceListing.Location = New System.Drawing.Point(12, 188)
        Me.dgvServiceListing.MultiSelect = False
        Me.dgvServiceListing.Name = "dgvServiceListing"
        Me.dgvServiceListing.ReadOnly = True
        Me.dgvServiceListing.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvServiceListing.RowHeadersVisible = False
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceListing.RowsDefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.service_price.DefaultCellStyle = DataGridViewCellStyle3
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
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvReserveList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvReserveList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvReserveList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvReserveList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvReserveList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReserveList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvReserveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReserveList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.serv_id, Me.serv_name, Me.price, Me.type, Me.status})
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvReserveList.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgvReserveList.DoubleBuffered = True
        Me.dgvReserveList.EnableHeadersVisualStyles = False
        Me.dgvReserveList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvReserveList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvReserveList.Location = New System.Drawing.Point(437, 73)
        Me.dgvReserveList.MultiSelect = False
        Me.dgvReserveList.Name = "dgvReserveList"
        Me.dgvReserveList.ReadOnly = True
        Me.dgvReserveList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
        Me.dgvReserveList.RowHeadersVisible = False
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvReserveList.RowsDefaultCellStyle = DataGridViewCellStyle12
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
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.price.DefaultCellStyle = DataGridViewCellStyle9
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
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemConsumed.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvItemConsumed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemConsumed.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvItemConsumed.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemConsumed.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemConsumed.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.dgvItemConsumed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemConsumed.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemID, Me.brand, Me.desc, Me.consumed})
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemConsumed.DefaultCellStyle = DataGridViewCellStyle15
        Me.dgvItemConsumed.DoubleBuffered = True
        Me.dgvItemConsumed.EnableHeadersVisualStyles = False
        Me.dgvItemConsumed.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemConsumed.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemConsumed.Location = New System.Drawing.Point(437, 271)
        Me.dgvItemConsumed.MultiSelect = False
        Me.dgvItemConsumed.Name = "dgvItemConsumed"
        Me.dgvItemConsumed.ReadOnly = True
        Me.dgvItemConsumed.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dgvItemConsumed.RowHeadersVisible = False
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemConsumed.RowsDefaultCellStyle = DataGridViewCellStyle17
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
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvOfferings.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle18
        Me.dgvOfferings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvOfferings.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvOfferings.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvOfferings.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvOfferings.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle19
        Me.dgvOfferings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOfferings.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.sid, Me.sname, Me.sprice, Me.stype, Me.savailability})
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvOfferings.DefaultCellStyle = DataGridViewCellStyle21
        Me.dgvOfferings.DoubleBuffered = True
        Me.dgvOfferings.EnableHeadersVisualStyles = False
        Me.dgvOfferings.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvOfferings.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvOfferings.Location = New System.Drawing.Point(813, 73)
        Me.dgvOfferings.MultiSelect = False
        Me.dgvOfferings.Name = "dgvOfferings"
        Me.dgvOfferings.ReadOnly = True
        Me.dgvOfferings.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.dgvOfferings.RowHeadersVisible = False
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvOfferings.RowsDefaultCellStyle = DataGridViewCellStyle23
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
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.sid.DefaultCellStyle = DataGridViewCellStyle20
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
        Me.Button1.Location = New System.Drawing.Point(701, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 71
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSasve
        '
        Me.btnSasve.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSasve.Location = New System.Drawing.Point(414, 472)
        Me.btnSasve.Name = "btnSasve"
        Me.btnSasve.Size = New System.Drawing.Size(91, 27)
        Me.btnSasve.TabIndex = 72
        Me.btnSasve.Text = "Save"
        Me.btnSasve.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.Image = Global.InventoryManager.My.Resources.Resources.minus
        Me.btnRemove.ImageActive = Nothing
        Me.btnRemove.Location = New System.Drawing.Point(782, 45)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRemove.TabIndex = 56
        Me.btnRemove.TabStop = False
        Me.btnRemove.Zoom = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.btnSaveTransaction)
        Me.GroupBox1.Controls.Add(Me.cboAppointmentTime)
        Me.GroupBox1.Controls.Add(Me.dtpAppointmentDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcontact1)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 168)
        Me.GroupBox1.TabIndex = 73
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
        '
        'btnSaveTransaction
        '
        Me.btnSaveTransaction.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveTransaction.Location = New System.Drawing.Point(289, 119)
        Me.btnSaveTransaction.Name = "btnSaveTransaction"
        Me.btnSaveTransaction.Size = New System.Drawing.Size(91, 27)
        Me.btnSaveTransaction.TabIndex = 73
        Me.btnSaveTransaction.Text = "Save"
        Me.btnSaveTransaction.UseVisualStyleBackColor = True
        '
        'cboAppointmentTime
        '
        Me.cboAppointmentTime.DropDownHeight = 100
        Me.cboAppointmentTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAppointmentTime.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAppointmentTime.FormattingEnabled = True
        Me.cboAppointmentTime.IntegralHeight = False
        Me.cboAppointmentTime.Items.AddRange(New Object() {"10:00 AM", "10:30 AM", "11:00 AM", "11:30 AM", "12:00 PM", "1:00 PM", "1:30 PM", "2:00 PM", "2:30 PM", "3:00 PM", "3:30 PM", "4:00 PM", "4:30 PM", "5:00 PM", "5:30 PM", "6:00 PM", "6:30 PM", "7:00 PM", "7:30 PM", "8:00 PM"})
        Me.cboAppointmentTime.Location = New System.Drawing.Point(141, 120)
        Me.cboAppointmentTime.MaxDropDownItems = 5
        Me.cboAppointmentTime.Name = "cboAppointmentTime"
        Me.cboAppointmentTime.Size = New System.Drawing.Size(121, 25)
        Me.cboAppointmentTime.TabIndex = 59
        '
        'dtpAppointmentDate
        '
        Me.dtpAppointmentDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpAppointmentDate.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAppointmentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpAppointmentDate.Location = New System.Drawing.Point(9, 119)
        Me.dtpAppointmentDate.Name = "dtpAppointmentDate"
        Me.dtpAppointmentDate.Size = New System.Drawing.Size(126, 26)
        Me.dtpAppointmentDate.TabIndex = 58
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(5, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "Appointment Date"
        '
        'txtName
        '
        Me.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtName.Location = New System.Drawing.Point(7, 31)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(209, 23)
        Me.txtName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(222, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "+639"
        '
        'txtcontact1
        '
        Me.txtcontact1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcontact1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtcontact1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcontact1.HintForeColor = System.Drawing.Color.Gray
        Me.txtcontact1.HintText = "XXXXXXXXX"
        Me.txtcontact1.isPassword = False
        Me.txtcontact1.LineFocusedColor = System.Drawing.Color.Blue
        Me.txtcontact1.LineIdleColor = System.Drawing.Color.Gray
        Me.txtcontact1.LineMouseHoverColor = System.Drawing.Color.Blue
        Me.txtcontact1.LineThickness = 3
        Me.txtcontact1.Location = New System.Drawing.Point(256, 29)
        Me.txtcontact1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcontact1.Name = "txtcontact1"
        Me.txtcontact1.Size = New System.Drawing.Size(88, 25)
        Me.txtcontact1.TabIndex = 2
        Me.txtcontact1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.Image = Global.InventoryManager.My.Resources.Resources.plus_3_
        Me.btnAdd.ImageActive = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(552, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(25, 25)
        Me.btnAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAdd.TabIndex = 63
        Me.btnAdd.TabStop = False
        Me.btnAdd.Visible = False
        Me.btnAdd.Zoom = 10
        '
        'frmAppointmentTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1181, 522)
        Me.Controls.Add(Me.GroupBox1)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAppointmentTransactions"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        CType(Me.dgvServiceListing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvReserveList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemConsumed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvOfferings, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAdd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvServiceListing As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dgvReserveList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents labelConsumed As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents dgvItemConsumed As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ItemID As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents consumed As DataGridViewTextBoxColumn
    Friend WithEvents dgvOfferings As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblTotal As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblShownone As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSasve As Button
    Friend WithEvents serv_availid As DataGridViewTextBoxColumn
    Friend WithEvents ServiceID As DataGridViewTextBoxColumn
    Friend WithEvents service_name As DataGridViewTextBoxColumn
    Friend WithEvents emp_assigned As DataGridViewTextBoxColumn
    Friend WithEvents service_price As DataGridViewTextBoxColumn
    Friend WithEvents serv_id As DataGridViewTextBoxColumn
    Friend WithEvents serv_name As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents type As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents sid As DataGridViewTextBoxColumn
    Friend WithEvents sname As DataGridViewTextBoxColumn
    Friend WithEvents sprice As DataGridViewTextBoxColumn
    Friend WithEvents stype As DataGridViewTextBoxColumn
    Friend WithEvents savailability As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontact1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cboAppointmentTime As ComboBox
    Friend WithEvents dtpAppointmentDate As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdd As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnSaveTransaction As Button
End Class
