<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTransactions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransactions))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpTransactionDate = New MetroFramework.Controls.MetroDateTime()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.dtpDateTo = New MetroFramework.Controls.MetroDateTime()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSearch = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExportPdf = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnExportExcel = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnEditTransaction = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnAddTransactions = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.dgvTransactionsList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.idno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.date_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cust = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnCompleteTransaction = New Bunifu.Framework.UI.BunifuFlatButton()
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportPdf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SandyBrown
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1154, 10)
        Me.Panel1.TabIndex = 9
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTransactionDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpTransactionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTransactionDate.Location = New System.Drawing.Point(12, 16)
        Me.dtpTransactionDate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpTransactionDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(113, 29)
        Me.dtpTransactionDate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpTransactionDate.TabIndex = 17
        Me.dtpTransactionDate.UseCustomBackColor = True
        Me.dtpTransactionDate.UseCustomForeColor = True
        Me.dtpTransactionDate.UseStyleColors = True
        '
        'dtpDateTo
        '
        Me.dtpDateTo.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateTo.CustomFormat = "MM/dd/yyyy"
        Me.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDateTo.Location = New System.Drawing.Point(154, 16)
        Me.dtpDateTo.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpDateTo.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.Size = New System.Drawing.Size(113, 29)
        Me.dtpDateTo.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpDateTo.TabIndex = 17
        Me.dtpDateTo.UseCustomBackColor = True
        Me.dtpDateTo.UseCustomForeColor = True
        Me.dtpDateTo.UseStyleColors = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(131, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 24)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "-"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.search
        Me.btnSearch.ImageActive = Nothing
        Me.btnSearch.Location = New System.Drawing.Point(273, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(29, 29)
        Me.btnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnSearch.TabIndex = 21
        Me.btnSearch.TabStop = False
        Me.btnSearch.Zoom = 10
        '
        'btnExportPdf
        '
        Me.btnExportPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportPdf.BackColor = System.Drawing.Color.Transparent
        Me.btnExportPdf.Image = Global.InventoryManager.My.Resources.Resources.pdf
        Me.btnExportPdf.ImageActive = Nothing
        Me.btnExportPdf.Location = New System.Drawing.Point(1047, 128)
        Me.btnExportPdf.Name = "btnExportPdf"
        Me.btnExportPdf.Size = New System.Drawing.Size(46, 48)
        Me.btnExportPdf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportPdf.TabIndex = 19
        Me.btnExportPdf.TabStop = False
        Me.btnExportPdf.Visible = False
        Me.btnExportPdf.Zoom = 10
        '
        'btnExportExcel
        '
        Me.btnExportExcel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExportExcel.BackColor = System.Drawing.Color.Transparent
        Me.btnExportExcel.Image = Global.InventoryManager.My.Resources.Resources.excel
        Me.btnExportExcel.ImageActive = Nothing
        Me.btnExportExcel.Location = New System.Drawing.Point(995, 128)
        Me.btnExportExcel.Name = "btnExportExcel"
        Me.btnExportExcel.Size = New System.Drawing.Size(46, 48)
        Me.btnExportExcel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnExportExcel.TabIndex = 18
        Me.btnExportExcel.TabStop = False
        Me.btnExportExcel.Visible = False
        Me.btnExportExcel.Zoom = 10
        '
        'btnEditTransaction
        '
        Me.btnEditTransaction.Activecolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEditTransaction.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEditTransaction.BorderRadius = 7
        Me.btnEditTransaction.ButtonText = "Edit Transaction"
        Me.btnEditTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditTransaction.DisabledColor = System.Drawing.Color.Gray
        Me.btnEditTransaction.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEditTransaction.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_4_
        Me.btnEditTransaction.Iconimage_right = Nothing
        Me.btnEditTransaction.Iconimage_right_Selected = Nothing
        Me.btnEditTransaction.Iconimage_Selected = Nothing
        Me.btnEditTransaction.IconMarginLeft = 0
        Me.btnEditTransaction.IconMarginRight = 0
        Me.btnEditTransaction.IconRightVisible = True
        Me.btnEditTransaction.IconRightZoom = 0R
        Me.btnEditTransaction.IconVisible = True
        Me.btnEditTransaction.IconZoom = 90.0R
        Me.btnEditTransaction.IsTab = False
        Me.btnEditTransaction.Location = New System.Drawing.Point(951, 236)
        Me.btnEditTransaction.Name = "btnEditTransaction"
        Me.btnEditTransaction.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditTransaction.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnEditTransaction.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEditTransaction.selected = False
        Me.btnEditTransaction.Size = New System.Drawing.Size(191, 48)
        Me.btnEditTransaction.TabIndex = 12
        Me.btnEditTransaction.Text = "Edit Transaction"
        Me.btnEditTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditTransaction.Textcolor = System.Drawing.Color.White
        Me.btnEditTransaction.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnAddTransactions
        '
        Me.btnAddTransactions.Activecolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAddTransactions.BackColor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTransactions.BorderRadius = 7
        Me.btnAddTransactions.ButtonText = "Create Transaction"
        Me.btnAddTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTransactions.DisabledColor = System.Drawing.Color.Gray
        Me.btnAddTransactions.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAddTransactions.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_2_
        Me.btnAddTransactions.Iconimage_right = Nothing
        Me.btnAddTransactions.Iconimage_right_Selected = Nothing
        Me.btnAddTransactions.Iconimage_Selected = Nothing
        Me.btnAddTransactions.IconMarginLeft = 0
        Me.btnAddTransactions.IconMarginRight = 0
        Me.btnAddTransactions.IconRightVisible = True
        Me.btnAddTransactions.IconRightZoom = 0R
        Me.btnAddTransactions.IconVisible = True
        Me.btnAddTransactions.IconZoom = 90.0R
        Me.btnAddTransactions.IsTab = False
        Me.btnAddTransactions.Location = New System.Drawing.Point(951, 182)
        Me.btnAddTransactions.Name = "btnAddTransactions"
        Me.btnAddTransactions.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(91, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.btnAddTransactions.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAddTransactions.selected = False
        Me.btnAddTransactions.Size = New System.Drawing.Size(191, 48)
        Me.btnAddTransactions.TabIndex = 11
        Me.btnAddTransactions.Text = "Create Transaction"
        Me.btnAddTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddTransactions.Textcolor = System.Drawing.Color.White
        Me.btnAddTransactions.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'dgvTransactionsList
        '
        Me.dgvTransactionsList.AllowUserToAddRows = False
        Me.dgvTransactionsList.AllowUserToDeleteRows = False
        Me.dgvTransactionsList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvTransactionsList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvTransactionsList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTransactionsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvTransactionsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvTransactionsList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvTransactionsList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvTransactionsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvTransactionsList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvTransactionsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransactionsList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idno, Me.txnno, Me.date_, Me.time_, Me.cust, Me.serv, Me.price, Me.status})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTransactionsList.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvTransactionsList.DoubleBuffered = True
        Me.dgvTransactionsList.EnableHeadersVisualStyles = False
        Me.dgvTransactionsList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvTransactionsList.HeaderForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvTransactionsList.Location = New System.Drawing.Point(12, 128)
        Me.dgvTransactionsList.Name = "dgvTransactionsList"
        Me.dgvTransactionsList.ReadOnly = True
        Me.dgvTransactionsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvTransactionsList.RowHeadersVisible = False
        Me.dgvTransactionsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTransactionsList.Size = New System.Drawing.Size(922, 367)
        Me.dgvTransactionsList.TabIndex = 22
        '
        'idno
        '
        Me.idno.DataPropertyName = "[JA-Transaction]"
        Me.idno.HeaderText = "TXN"
        Me.idno.Name = "idno"
        Me.idno.ReadOnly = True
        Me.idno.Visible = False
        '
        'txnno
        '
        Me.txnno.DataPropertyName = "TransactionNumber"
        Me.txnno.HeaderText = "Transaction Number"
        Me.txnno.Name = "txnno"
        Me.txnno.ReadOnly = True
        '
        'date_
        '
        Me.date_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.date_.DataPropertyName = "Date"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.date_.DefaultCellStyle = DataGridViewCellStyle3
        Me.date_.HeaderText = "Date"
        Me.date_.Name = "date_"
        Me.date_.ReadOnly = True
        Me.date_.Width = 5
        '
        'time_
        '
        Me.time_.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.time_.DataPropertyName = "Time"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.time_.DefaultCellStyle = DataGridViewCellStyle4
        Me.time_.HeaderText = "Time"
        Me.time_.Name = "time_"
        Me.time_.ReadOnly = True
        Me.time_.Width = 5
        '
        'cust
        '
        Me.cust.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.cust.DataPropertyName = "CustomerName"
        Me.cust.HeaderText = "Customer Name"
        Me.cust.Name = "cust"
        Me.cust.ReadOnly = True
        '
        'serv
        '
        Me.serv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.serv.DataPropertyName = "Service/s Availed"
        Me.serv.HeaderText = "Services Availed"
        Me.serv.Name = "serv"
        Me.serv.ReadOnly = True
        '
        'price
        '
        Me.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.price.DataPropertyName = "Amount Collected"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.price.DefaultCellStyle = DataGridViewCellStyle5
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        Me.price.ReadOnly = True
        Me.price.Width = 69
        '
        'status
        '
        Me.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        Me.status.DataPropertyName = "TransactionStatus"
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        Me.status.Width = 5
        '
        'btnCompleteTransaction
        '
        Me.btnCompleteTransaction.Activecolor = System.Drawing.Color.Green
        Me.btnCompleteTransaction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCompleteTransaction.BackColor = System.Drawing.Color.Green
        Me.btnCompleteTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCompleteTransaction.BorderRadius = 7
        Me.btnCompleteTransaction.ButtonText = "Complete Transaction"
        Me.btnCompleteTransaction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompleteTransaction.DisabledColor = System.Drawing.Color.Gray
        Me.btnCompleteTransaction.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCompleteTransaction.Iconimage = Global.InventoryManager.My.Resources.Resources.New_Project_4_
        Me.btnCompleteTransaction.Iconimage_right = Nothing
        Me.btnCompleteTransaction.Iconimage_right_Selected = Nothing
        Me.btnCompleteTransaction.Iconimage_Selected = Nothing
        Me.btnCompleteTransaction.IconMarginLeft = 0
        Me.btnCompleteTransaction.IconMarginRight = 0
        Me.btnCompleteTransaction.IconRightVisible = True
        Me.btnCompleteTransaction.IconRightZoom = 0R
        Me.btnCompleteTransaction.IconVisible = True
        Me.btnCompleteTransaction.IconZoom = 90.0R
        Me.btnCompleteTransaction.IsTab = False
        Me.btnCompleteTransaction.Location = New System.Drawing.Point(951, 290)
        Me.btnCompleteTransaction.Name = "btnCompleteTransaction"
        Me.btnCompleteTransaction.Normalcolor = System.Drawing.Color.Green
        Me.btnCompleteTransaction.OnHovercolor = System.Drawing.Color.LimeGreen
        Me.btnCompleteTransaction.OnHoverTextColor = System.Drawing.Color.White
        Me.btnCompleteTransaction.selected = False
        Me.btnCompleteTransaction.Size = New System.Drawing.Size(191, 48)
        Me.btnCompleteTransaction.TabIndex = 12
        Me.btnCompleteTransaction.Text = "Complete Transaction"
        Me.btnCompleteTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCompleteTransaction.Textcolor = System.Drawing.Color.White
        Me.btnCompleteTransaction.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1154, 507)
        Me.Controls.Add(Me.dgvTransactionsList)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnExportPdf)
        Me.Controls.Add(Me.btnExportExcel)
        Me.Controls.Add(Me.dtpDateTo)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.btnCompleteTransaction)
        Me.Controls.Add(Me.btnEditTransaction)
        Me.Controls.Add(Me.btnAddTransactions)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTransactions"
        Me.Text = "frmTransactions"
        CType(Me.btnSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportPdf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnExportExcel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTransactionsList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnAddTransactions As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEditTransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents dtpTransactionDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents btnExportPdf As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnExportExcel As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents dtpDateTo As MetroFramework.Controls.MetroDateTime
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents dgvTransactionsList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnCompleteTransaction As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents idno As DataGridViewTextBoxColumn
    Friend WithEvents txnno As DataGridViewTextBoxColumn
    Friend WithEvents date_ As DataGridViewTextBoxColumn
    Friend WithEvents time_ As DataGridViewTextBoxColumn
    Friend WithEvents cust As DataGridViewTextBoxColumn
    Friend WithEvents serv As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
