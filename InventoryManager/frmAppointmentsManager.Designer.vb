<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointmentsManager
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointmentsManager))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvServiceList = New System.Windows.Forms.DataGridView()
        Me.checkbox = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.serv_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Serv_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcontact1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.txtAddress = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dgvServiceList)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(20, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 419)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 498)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 55
        '
        'dgvServiceList
        '
        Me.dgvServiceList.AllowUserToAddRows = False
        Me.dgvServiceList.AllowUserToDeleteRows = False
        Me.dgvServiceList.AllowUserToResizeColumns = False
        Me.dgvServiceList.AllowUserToResizeRows = False
        Me.dgvServiceList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvServiceList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvServiceList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiceList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.checkbox, Me.serv_name, Me.Serv_id, Me.status})
        Me.dgvServiceList.Location = New System.Drawing.Point(5, 180)
        Me.dgvServiceList.Name = "dgvServiceList"
        Me.dgvServiceList.RowHeadersVisible = False
        Me.dgvServiceList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiceList.Size = New System.Drawing.Size(408, 311)
        Me.dgvServiceList.TabIndex = 54
        '
        'checkbox
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.NullValue = False
        Me.checkbox.DefaultCellStyle = DataGridViewCellStyle2
        Me.checkbox.HeaderText = ""
        Me.checkbox.Name = "checkbox"
        Me.checkbox.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.checkbox.Width = 50
        '
        'serv_name
        '
        Me.serv_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serv_name.DataPropertyName = "ServiceName"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.serv_name.DefaultCellStyle = DataGridViewCellStyle3
        Me.serv_name.HeaderText = "Service Name"
        Me.serv_name.Name = "serv_name"
        Me.serv_name.ReadOnly = True
        '
        'Serv_id
        '
        Me.Serv_id.DataPropertyName = "ServiceID"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Serv_id.DefaultCellStyle = DataGridViewCellStyle4
        Me.Serv_id.HeaderText = "Service ID"
        Me.Serv_id.Name = "Serv_id"
        Me.Serv_id.ReadOnly = True
        Me.Serv_id.Visible = False
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.status.DataPropertyName = "Status"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.status.DefaultCellStyle = DataGridViewCellStyle5
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "MM/dd/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 148)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(126, 26)
        Me.DateTimePicker1.TabIndex = 53
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtcontact1)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(410, 119)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Details"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(7, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 17)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Appointment Date"
        '
        'btnSave
        '
        Me.btnSave.Depth = 0
        Me.btnSave.Location = New System.Drawing.Point(160, 497)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = True
        Me.btnSave.Size = New System.Drawing.Size(85, 36)
        Me.btnSave.TabIndex = 51
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
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
        'frmAppointmentsManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(473, 499)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAppointmentsManager"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Appointment Details"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvServiceList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtAddress As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents dgvServiceList As DataGridView
    Friend WithEvents checkbox As DataGridViewCheckBoxColumn
    Friend WithEvents serv_name As DataGridViewTextBoxColumn
    Friend WithEvents Serv_id As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcontact1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents txtName As TextBox
End Class
