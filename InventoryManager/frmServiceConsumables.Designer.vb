<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceConsumables
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceConsumables))
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.dgvItemList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Container_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvConsumables = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.item_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.service_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Service_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRemove = New Bunifu.Framework.UI.BunifuImageButton()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConsumables, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.search
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(877, 53)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(30, 30)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 20
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'txtSearch
        '
        Me.txtSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearch.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearch.HintForeColor = System.Drawing.Color.Gray
        Me.txtSearch.HintText = "Item Name"
        Me.txtSearch.isPassword = False
        Me.txtSearch.LineFocusedColor = System.Drawing.Color.Pink
        Me.txtSearch.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearch.LineMouseHoverColor = System.Drawing.Color.Pink
        Me.txtSearch.LineThickness = 3
        Me.txtSearch.Location = New System.Drawing.Point(704, 53)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(166, 29)
        Me.txtSearch.TabIndex = 19
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(23, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Service Status:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Service Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Service Type:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Service Name:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(127, 60)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(97, 17)
        Me.lblName.TabIndex = 21
        Me.lblName.Text = "Service Name"
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblType.Location = New System.Drawing.Point(127, 88)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(85, 17)
        Me.lblType.TabIndex = 22
        Me.lblType.Text = "Service Type"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(127, 114)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(88, 17)
        Me.lblPrice.TabIndex = 23
        Me.lblPrice.Text = "Service Price"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Location = New System.Drawing.Point(127, 140)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(95, 17)
        Me.lblStatus.TabIndex = 24
        Me.lblStatus.Text = "Service Status"
        '
        'dgvItemList
        '
        Me.dgvItemList.AllowUserToAddRows = False
        Me.dgvItemList.AllowUserToDeleteRows = False
        Me.dgvItemList.AllowUserToResizeColumns = False
        Me.dgvItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvItemList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvItemList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Brand, Me.Description, Me.Type, Me.Container_})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvItemList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvItemList.DoubleBuffered = True
        Me.dgvItemList.EnableHeadersVisualStyles = False
        Me.dgvItemList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvItemList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvItemList.Location = New System.Drawing.Point(409, 89)
        Me.dgvItemList.MultiSelect = False
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.ReadOnly = True
        Me.dgvItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.RowTemplate.ReadOnly = True
        Me.dgvItemList.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.Size = New System.Drawing.Size(498, 380)
        Me.dgvItemList.TabIndex = 45
        '
        'ID
        '
        Me.ID.DataPropertyName = "ItemID"
        Me.ID.HeaderText = "Item ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        '
        'Brand
        '
        Me.Brand.DataPropertyName = "ItemBrand"
        Me.Brand.HeaderText = "Brand"
        Me.Brand.Name = "Brand"
        Me.Brand.ReadOnly = True
        '
        'Description
        '
        Me.Description.DataPropertyName = "ItemDescription"
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        '
        'Type
        '
        Me.Type.DataPropertyName = "ItemClass"
        Me.Type.HeaderText = "Class"
        Me.Type.Name = "Type"
        Me.Type.ReadOnly = True
        '
        'Container_
        '
        Me.Container_.DataPropertyName = "ContainerType"
        Me.Container_.HeaderText = "Container Type"
        Me.Container_.Name = "Container_"
        Me.Container_.ReadOnly = True
        '
        'dgvConsumables
        '
        Me.dgvConsumables.AllowUserToAddRows = False
        Me.dgvConsumables.AllowUserToDeleteRows = False
        Me.dgvConsumables.AllowUserToResizeColumns = False
        Me.dgvConsumables.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvConsumables.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvConsumables.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvConsumables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvConsumables.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvConsumables.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvConsumables.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvConsumables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsumables.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvConsumables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConsumables.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.item_id, Me.service_id, Me.Service_name, Me.brand_, Me.Desc, Me.qty})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvConsumables.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvConsumables.DoubleBuffered = True
        Me.dgvConsumables.EnableHeadersVisualStyles = False
        Me.dgvConsumables.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvConsumables.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvConsumables.Location = New System.Drawing.Point(23, 160)
        Me.dgvConsumables.MultiSelect = False
        Me.dgvConsumables.Name = "dgvConsumables"
        Me.dgvConsumables.ReadOnly = True
        Me.dgvConsumables.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvConsumables.RowHeadersVisible = False
        Me.dgvConsumables.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsumables.RowTemplate.ReadOnly = True
        Me.dgvConsumables.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConsumables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvConsumables.Size = New System.Drawing.Size(376, 321)
        Me.dgvConsumables.TabIndex = 46
        '
        'item_id
        '
        Me.item_id.DataPropertyName = "ItemUsageID"
        Me.item_id.HeaderText = "Item ID"
        Me.item_id.Name = "item_id"
        Me.item_id.ReadOnly = True
        Me.item_id.Visible = False
        '
        'service_id
        '
        Me.service_id.DataPropertyName = "ServiceID"
        Me.service_id.HeaderText = "ServiceID"
        Me.service_id.Name = "service_id"
        Me.service_id.ReadOnly = True
        Me.service_id.Visible = False
        '
        'Service_name
        '
        Me.Service_name.DataPropertyName = "ServiceName"
        Me.Service_name.HeaderText = "Service Name"
        Me.Service_name.Name = "Service_name"
        Me.Service_name.ReadOnly = True
        Me.Service_name.Visible = False
        '
        'brand_
        '
        Me.brand_.DataPropertyName = "ItemBrand"
        Me.brand_.HeaderText = "Brand"
        Me.brand_.Name = "brand_"
        Me.brand_.ReadOnly = True
        '
        'Desc
        '
        Me.Desc.DataPropertyName = "ItemDescription"
        Me.Desc.HeaderText = "Description"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        '
        'qty
        '
        Me.qty.DataPropertyName = "consumednumber"
        Me.qty.HeaderText = "Qty Consumed"
        Me.qty.Name = "qty"
        Me.qty.ReadOnly = True
        '
        'btnRemove
        '
        Me.btnRemove.BackColor = System.Drawing.Color.Transparent
        Me.btnRemove.Image = Global.InventoryManager.My.Resources.Resources.minus
        Me.btnRemove.ImageActive = Nothing
        Me.btnRemove.Location = New System.Drawing.Point(374, 132)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(25, 25)
        Me.btnRemove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRemove.TabIndex = 56
        Me.btnRemove.TabStop = False
        Me.btnRemove.Zoom = 10
        '
        'frmServiceConsumables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(930, 504)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.dgvConsumables)
        Me.Controls.Add(Me.dgvItemList)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServiceConsumables"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConsumables, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRemove, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblType As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents dgvItemList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents dgvConsumables As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Brand As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Type As DataGridViewTextBoxColumn
    Friend WithEvents Container_ As DataGridViewTextBoxColumn
    Friend WithEvents item_id As DataGridViewTextBoxColumn
    Friend WithEvents service_id As DataGridViewTextBoxColumn
    Friend WithEvents Service_name As DataGridViewTextBoxColumn
    Friend WithEvents brand_ As DataGridViewTextBoxColumn
    Friend WithEvents Desc As DataGridViewTextBoxColumn
    Friend WithEvents qty As DataGridViewTextBoxColumn
    Friend WithEvents btnRemove As Bunifu.Framework.UI.BunifuImageButton
End Class
