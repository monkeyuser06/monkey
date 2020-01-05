<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotifications
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNotifications))
        Me.dgvNotifications = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.itemno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemBrand = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.serv_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvNotifications
        '
        Me.dgvNotifications.AllowUserToAddRows = False
        Me.dgvNotifications.AllowUserToDeleteRows = False
        Me.dgvNotifications.AllowUserToResizeColumns = False
        Me.dgvNotifications.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvNotifications.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNotifications.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvNotifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvNotifications.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvNotifications.BackgroundColor = System.Drawing.Color.White
        Me.dgvNotifications.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNotifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotifications.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNotifications.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.itemno, Me.ItemBrand, Me.serv_price, Me.status})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotifications.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvNotifications.DoubleBuffered = True
        Me.dgvNotifications.Enabled = False
        Me.dgvNotifications.EnableHeadersVisualStyles = False
        Me.dgvNotifications.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvNotifications.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvNotifications.Location = New System.Drawing.Point(12, 35)
        Me.dgvNotifications.MultiSelect = False
        Me.dgvNotifications.Name = "dgvNotifications"
        Me.dgvNotifications.ReadOnly = True
        Me.dgvNotifications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNotifications.RowHeadersVisible = False
        Me.dgvNotifications.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotifications.RowTemplate.ReadOnly = True
        Me.dgvNotifications.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotifications.Size = New System.Drawing.Size(476, 264)
        Me.dgvNotifications.TabIndex = 44
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(211, 305)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(79, 27)
        Me.btnClose.TabIndex = 45
        Me.btnClose.Text = "CLOSE"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'itemno
        '
        Me.itemno.DataPropertyName = "ItemNo"
        Me.itemno.HeaderText = "ItemNo"
        Me.itemno.Name = "itemno"
        Me.itemno.ReadOnly = True
        '
        'ItemBrand
        '
        Me.ItemBrand.DataPropertyName = "ItemBrand"
        Me.ItemBrand.HeaderText = "Brand"
        Me.ItemBrand.Name = "ItemBrand"
        Me.ItemBrand.ReadOnly = True
        '
        'serv_price
        '
        Me.serv_price.DataPropertyName = "NotifDate"
        Me.serv_price.HeaderText = "Date"
        Me.serv_price.Name = "serv_price"
        Me.serv_price.ReadOnly = True
        '
        'status
        '
        Me.status.DataPropertyName = "Message"
        Me.status.HeaderText = "Message"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'frmNotifications
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(500, 344)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.dgvNotifications)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmNotifications"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNotifications"
        CType(Me.dgvNotifications, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvNotifications As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnClose As Button
    Friend WithEvents itemno As DataGridViewTextBoxColumn
    Friend WithEvents ItemBrand As DataGridViewTextBoxColumn
    Friend WithEvents serv_price As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
End Class
