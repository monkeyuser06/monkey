<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSearchCustomer
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchCustomer))
        Me.txtSearchname = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.dgvSearchList = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.lblResultCount = New System.Windows.Forms.Label()
        CType(Me.dgvSearchList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSearchname
        '
        Me.txtSearchname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSearchname.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtSearchname.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSearchname.HintForeColor = System.Drawing.Color.DarkGray
        Me.txtSearchname.HintText = "Search Name"
        Me.txtSearchname.isPassword = False
        Me.txtSearchname.LineFocusedColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineIdleColor = System.Drawing.Color.Gray
        Me.txtSearchname.LineMouseHoverColor = System.Drawing.Color.Teal
        Me.txtSearchname.LineThickness = 3
        Me.txtSearchname.Location = New System.Drawing.Point(217, 21)
        Me.txtSearchname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSearchname.Name = "txtSearchname"
        Me.txtSearchname.Size = New System.Drawing.Size(160, 33)
        Me.txtSearchname.TabIndex = 38
        Me.txtSearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'dgvSearchList
        '
        Me.dgvSearchList.AllowUserToAddRows = False
        Me.dgvSearchList.AllowUserToDeleteRows = False
        Me.dgvSearchList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvSearchList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchList.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvSearchList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvSearchList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvSearchList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSearchList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSearchList.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgvSearchList.DoubleBuffered = True
        Me.dgvSearchList.EnableHeadersVisualStyles = False
        Me.dgvSearchList.HeaderBgColor = System.Drawing.Color.LightSeaGreen
        Me.dgvSearchList.HeaderForeColor = System.Drawing.Color.Snow
        Me.dgvSearchList.Location = New System.Drawing.Point(12, 61)
        Me.dgvSearchList.MultiSelect = False
        Me.dgvSearchList.Name = "dgvSearchList"
        Me.dgvSearchList.ReadOnly = True
        Me.dgvSearchList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSearchList.RowHeadersVisible = False
        Me.dgvSearchList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchList.Size = New System.Drawing.Size(414, 453)
        Me.dgvSearchList.TabIndex = 40
        '
        'btnSearch
        '
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Image = Global.InventoryManager.My.Resources.Resources.magnifying_glass_1_
        Me.btnSearch.Location = New System.Drawing.Point(384, 21)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(33, 33)
        Me.btnSearch.TabIndex = 39
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lblResultCount
        '
        Me.lblResultCount.AutoSize = True
        Me.lblResultCount.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultCount.Location = New System.Drawing.Point(12, 37)
        Me.lblResultCount.Name = "lblResultCount"
        Me.lblResultCount.Size = New System.Drawing.Size(0, 17)
        Me.lblResultCount.TabIndex = 41
        '
        'frmSearchCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(438, 526)
        Me.Controls.Add(Me.lblResultCount)
        Me.Controls.Add(Me.txtSearchname)
        Me.Controls.Add(Me.dgvSearchList)
        Me.Controls.Add(Me.btnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSearchCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgvSearchList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtSearchname As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents dgvSearchList As Bunifu.Framework.UI.BunifuCustomDataGrid
    Friend WithEvents btnSearch As Button
    Friend WithEvents lblResultCount As Label
End Class
