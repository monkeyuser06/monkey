<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventory
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventory))
        Me.dgvItemList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.itemno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.brand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.volumeperstock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totalvolume = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.criticalpoint = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.container1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.classtype = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSearch = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.cboClass = New System.Windows.Forms.ComboBox()
        Me.btnNotifications = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExportExcel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnUpdateItem = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddItem = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvItemList
        '
        Me.dgvItemList.AllowUserToAddRows = False
        Me.dgvItemList.AllowUserToDeleteRows = False
        Me.dgvItemList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvItemList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvItemList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
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
        Me.dgvItemList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemno, Me.brand, Me.desc, Me.stocks, Me.volumeperstock, Me.totalvolume, Me.criticalpoint, Me.container1, Me.price, Me.classtype})
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
        Me.dgvItemList.Location = New System.Drawing.Point(12, 121)
        Me.dgvItemList.MultiSelect = False
        Me.dgvItemList.Name = "dgvItemList"
        Me.dgvItemList.ReadOnly = True
        Me.dgvItemList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvItemList.RowHeadersVisible = False
        Me.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvItemList.Size = New System.Drawing.Size(933, 372)
        Me.dgvItemList.TabIndex = 8
        '
        'itemno
        '
        Me.itemno.DataPropertyName = "ItemNo"
        Me.itemno.HeaderText = "ItemNumber"
        Me.itemno.Name = "itemno"
        Me.itemno.ReadOnly = True
        Me.itemno.Visible = False
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
        'stocks
        '
        Me.stocks.DataPropertyName = "PhysicalStock"
        Me.stocks.HeaderText = "Stocks"
        Me.stocks.Name = "stocks"
        Me.stocks.ReadOnly = True
        '
        'volumeperstock
        '
        Me.volumeperstock.DataPropertyName = "VolumePerStock"
        Me.volumeperstock.HeaderText = "Volume Per Stock"
        Me.volumeperstock.Name = "volumeperstock"
        Me.volumeperstock.ReadOnly = True
        '
        'totalvolume
        '
        Me.totalvolume.DataPropertyName = "TotalVolume"
        Me.totalvolume.HeaderText = "Total Volume"
        Me.totalvolume.Name = "totalvolume"
        Me.totalvolume.ReadOnly = True
        '
        'criticalpoint
        '
        Me.criticalpoint.DataPropertyName = "CriticalPoint"
        Me.criticalpoint.HeaderText = "Critical Point"
        Me.criticalpoint.Name = "criticalpoint"
        Me.criticalpoint.ReadOnly = True
        '
        'container1
        '
        Me.container1.DataPropertyName = "ContainerType"
        Me.container1.HeaderText = "Container"
        Me.container1.Name = "container1"
        Me.container1.ReadOnly = True
        Me.container1.Visible = False
        '
        'price
        '
        Me.price.DataPropertyName = "Price"
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        '
        'classtype
        '
        Me.classtype.DataPropertyName = "ItemClass"
        Me.classtype.HeaderText = "Class"
        Me.classtype.Name = "classtype"
        Me.classtype.ReadOnly = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 10)
        Me.Panel1.TabIndex = 19
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
        Me.txtSearch.Location = New System.Drawing.Point(669, 81)
        Me.txtSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(240, 33)
        Me.txtSearch.TabIndex = 31
        Me.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'cboClass
        '
        Me.cboClass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboClass.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cboClass.FormattingEnabled = True
        Me.cboClass.Items.AddRange(New Object() {"ALL", "BODY", "FACE", "HAIR", "NAILS"})
        Me.cboClass.Location = New System.Drawing.Point(535, 87)
        Me.cboClass.Name = "cboClass"
        Me.cboClass.Size = New System.Drawing.Size(127, 25)
        Me.cboClass.TabIndex = 34
        '
        'btnNotifications
        '
        Me.btnNotifications.BackColor = System.Drawing.Color.Transparent
        Me.btnNotifications.ErrorImage = Global.InventoryManager.My.Resources.Resources.alarm
        Me.btnNotifications.Image = Global.InventoryManager.My.Resources.Resources.bell
        Me.btnNotifications.ImageActive = Nothing
        Me.btnNotifications.Location = New System.Drawing.Point(12, 82)
        Me.btnNotifications.Name = "btnNotifications"
        Me.btnNotifications.Size = New System.Drawing.Size(32, 33)
        Me.btnNotifications.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnNotifications.TabIndex = 35
        Me.btnNotifications.TabStop = False
        Me.btnNotifications.Zoom = 10
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Image = Global.InventoryManager.My.Resources.Resources.excel
        Me.btnExportExcel.ImageActive = Nothing
        Me.btnExportExcel.Location = New System.Drawing.Point(1000, 120)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(46, 48)
        Me.btnExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportExcel.TabIndex = 33
        Me.btnExportExcel.TabStop = False
        Me.btnExportExcel.Visible = False
        Me.btnExportExcel.Zoom = 10
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(912, 82)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 32
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnUpdateItem
        '
        Me.btnUpdateItem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpdateItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUpdateItem.BorderRadius = 7
        Me.btnUpdateItem.ButtonText = "Add Stocks"
        Me.btnUpdateItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateItem.DisabledColor = System.Drawing.Color.Gray
        Me.btnUpdateItem.Iconcolor = System.Drawing.Color.Transparent
        Me.btnUpdateItem.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_3_
        Me.btnUpdateItem.Iconimage_right = Nothing
        Me.btnUpdateItem.Iconimage_right_Selected = Nothing
        Me.btnUpdateItem.Iconimage_Selected = Nothing
        Me.btnUpdateItem.IconMarginLeft = 0
        Me.btnUpdateItem.IconMarginRight = 0
        Me.btnUpdateItem.IconRightVisible = True
        Me.btnUpdateItem.IconRightZoom = 0R
        Me.btnUpdateItem.IconVisible = True
        Me.btnUpdateItem.IconZoom = 90.0R
        Me.btnUpdateItem.IsTab = False
        Me.btnUpdateItem.Location = New System.Drawing.Point(951, 228)
        Me.btnUpdateItem.Name = "btnUpdateItem"
        Me.btnUpdateItem.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(201, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(53, Byte), Integer))
        Me.btnUpdateItem.OnHoverTextColor = System.Drawing.Color.White
        Me.btnUpdateItem.selected = False
        Me.btnUpdateItem.Size = New System.Drawing.Size(191, 48)
        Me.btnUpdateItem.TabIndex = 11
        Me.btnUpdateItem.Text = "Add Stocks"
        Me.btnUpdateItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateItem.Textcolor = System.Drawing.Color.White
        Me.btnUpdateItem.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddItem
        '
        Me.btnAddItem.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddItem.BorderRadius = 7
        Me.btnAddItem.ButtonText = "Add Item"
        Me.btnAddItem.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddItem.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddItem.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddItem.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnAddItem.Iconimage_right = Nothing
        Me.btnAddItem.Iconimage_right_Selected = Nothing
        Me.btnAddItem.Iconimage_Selected = Nothing
        Me.btnAddItem.IconMarginLeft = 0
        Me.btnAddItem.IconMarginRight = 0
        Me.btnAddItem.IconRightVisible = True
        Me.btnAddItem.IconRightZoom = 0R
        Me.btnAddItem.IconVisible = True
        Me.btnAddItem.IconZoom = 90.0R
        Me.btnAddItem.IsTab = False
        Me.btnAddItem.Location = New System.Drawing.Point(951, 174)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddItem.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddItem.selected = False
        Me.btnAddItem.Size = New System.Drawing.Size(191, 48)
        Me.btnAddItem.TabIndex = 9
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddItem.Textcolor = System.Drawing.Color.White
        Me.btnAddItem.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.btnNotifications)
        Me.Controls.Add(Me.cboClass)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnUpdateItem)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.dgvItemList)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInventory"
        CType(Me.dgvItemList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnUpdateItem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnAddItem As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dgvItemList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtSearch As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents btnExportExcel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents itemno As DataGridViewTextBoxColumn
    Friend WithEvents brand As DataGridViewTextBoxColumn
    Friend WithEvents desc As DataGridViewTextBoxColumn
    Friend WithEvents stocks As DataGridViewTextBoxColumn
    Friend WithEvents volumeperstock As DataGridViewTextBoxColumn
    Friend WithEvents totalvolume As DataGridViewTextBoxColumn
    Friend WithEvents criticalpoint As DataGridViewTextBoxColumn
    Friend WithEvents container1 As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents classtype As DataGridViewTextBoxColumn
    Friend WithEvents cboClass As ComboBox
    Friend WithEvents btnNotifications As Bunifu.Framework.UI.BunifuImageButton
End Class
