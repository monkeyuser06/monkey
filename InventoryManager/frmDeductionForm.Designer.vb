<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeductionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDeductionForm))
        Me.txtItemBrand = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtItemDescription = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtStocks = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtDeductedStocks = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRetained = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnClose = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.SuspendLayout()
        '
        'txtItemBrand
        '
        Me.txtItemBrand.BorderColorFocused = System.Drawing.Color.Gray
        Me.txtItemBrand.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtItemBrand.BorderColorMouseHover = System.Drawing.Color.Pink
        Me.txtItemBrand.BorderThickness = 3
        Me.txtItemBrand.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemBrand.Enabled = False
        Me.txtItemBrand.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtItemBrand.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtItemBrand.isPassword = False
        Me.txtItemBrand.Location = New System.Drawing.Point(13, 30)
        Me.txtItemBrand.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemBrand.Name = "txtItemBrand"
        Me.txtItemBrand.Size = New System.Drawing.Size(180, 44)
        Me.txtItemBrand.TabIndex = 0
        Me.txtItemBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtItemDescription
        '
        Me.txtItemDescription.BorderColorFocused = System.Drawing.Color.Gray
        Me.txtItemDescription.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtItemDescription.BorderColorMouseHover = System.Drawing.Color.Pink
        Me.txtItemDescription.BorderThickness = 3
        Me.txtItemDescription.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtItemDescription.Enabled = False
        Me.txtItemDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtItemDescription.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtItemDescription.isPassword = False
        Me.txtItemDescription.Location = New System.Drawing.Point(201, 30)
        Me.txtItemDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtItemDescription.Name = "txtItemDescription"
        Me.txtItemDescription.Size = New System.Drawing.Size(305, 44)
        Me.txtItemDescription.TabIndex = 1
        Me.txtItemDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtStocks
        '
        Me.txtStocks.BorderColorFocused = System.Drawing.Color.Gray
        Me.txtStocks.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtStocks.BorderColorMouseHover = System.Drawing.Color.Pink
        Me.txtStocks.BorderThickness = 3
        Me.txtStocks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtStocks.Enabled = False
        Me.txtStocks.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtStocks.isPassword = False
        Me.txtStocks.Location = New System.Drawing.Point(15, 99)
        Me.txtStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.Size = New System.Drawing.Size(50, 44)
        Me.txtStocks.TabIndex = 2
        Me.txtStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtDeductedStocks
        '
        Me.txtDeductedStocks.BorderColorFocused = System.Drawing.Color.Gray
        Me.txtDeductedStocks.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtDeductedStocks.BorderColorMouseHover = System.Drawing.Color.Pink
        Me.txtDeductedStocks.BorderThickness = 3
        Me.txtDeductedStocks.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDeductedStocks.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDeductedStocks.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtDeductedStocks.isPassword = False
        Me.txtDeductedStocks.Location = New System.Drawing.Point(142, 99)
        Me.txtDeductedStocks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeductedStocks.Name = "txtDeductedStocks"
        Me.txtDeductedStocks.Size = New System.Drawing.Size(51, 44)
        Me.txtDeductedStocks.TabIndex = 3
        Me.txtDeductedStocks.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtRemarks
        '
        Me.txtRemarks.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRemarks.Location = New System.Drawing.Point(15, 167)
        Me.txtRemarks.Multiline = True
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(492, 125)
        Me.txtRemarks.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Item Brand"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(198, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Description"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(12, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Remaining Stocks"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(139, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Stocks Removed"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(260, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(110, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Stocks Retained"
        '
        'txtRetained
        '
        Me.txtRetained.BorderColorFocused = System.Drawing.Color.Gray
        Me.txtRetained.BorderColorIdle = System.Drawing.Color.Gray
        Me.txtRetained.BorderColorMouseHover = System.Drawing.Color.Pink
        Me.txtRetained.BorderThickness = 3
        Me.txtRetained.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtRetained.Enabled = False
        Me.txtRetained.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtRetained.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRetained.isPassword = False
        Me.txtRetained.Location = New System.Drawing.Point(263, 99)
        Me.txtRetained.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRetained.Name = "txtRetained"
        Me.txtRetained.Size = New System.Drawing.Size(51, 44)
        Me.txtRetained.TabIndex = 8
        Me.txtRetained.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(12, 147)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(115, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Remarks/Reason"
        '
        'btnSave
        '
        Me.btnSave.Activecolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.BorderRadius = 0
        Me.btnSave.ButtonText = "Save"
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledColor = System.Drawing.Color.Gray
        Me.btnSave.Iconcolor = System.Drawing.Color.Transparent
        Me.btnSave.Iconimage = Nothing
        Me.btnSave.Iconimage_right = Nothing
        Me.btnSave.Iconimage_right_Selected = Nothing
        Me.btnSave.Iconimage_Selected = Nothing
        Me.btnSave.IconMarginLeft = 0
        Me.btnSave.IconMarginRight = 0
        Me.btnSave.IconRightVisible = True
        Me.btnSave.IconRightZoom = 0R
        Me.btnSave.IconVisible = True
        Me.btnSave.IconZoom = 90.0R
        Me.btnSave.IsTab = False
        Me.btnSave.Location = New System.Drawing.Point(128, 299)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnSave.OnHoverTextColor = System.Drawing.Color.White
        Me.btnSave.selected = False
        Me.btnSave.Size = New System.Drawing.Size(129, 48)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnSave.Textcolor = System.Drawing.Color.White
        Me.btnSave.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnClose
        '
        Me.btnClose.Activecolor = System.Drawing.Color.Red
        Me.btnClose.BackColor = System.Drawing.Color.Red
        Me.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClose.BorderRadius = 0
        Me.btnClose.ButtonText = "Cancel"
        Me.btnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClose.DisabledColor = System.Drawing.Color.Gray
        Me.btnClose.Iconcolor = System.Drawing.Color.Transparent
        Me.btnClose.Iconimage = Nothing
        Me.btnClose.Iconimage_right = Nothing
        Me.btnClose.Iconimage_right_Selected = Nothing
        Me.btnClose.Iconimage_Selected = Nothing
        Me.btnClose.IconMarginLeft = 0
        Me.btnClose.IconMarginRight = 0
        Me.btnClose.IconRightVisible = True
        Me.btnClose.IconRightZoom = 0R
        Me.btnClose.IconVisible = True
        Me.btnClose.IconZoom = 90.0R
        Me.btnClose.IsTab = False
        Me.btnClose.Location = New System.Drawing.Point(263, 299)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(46, Byte), Integer), CType(CType(139, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.btnClose.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(36, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.btnClose.OnHoverTextColor = System.Drawing.Color.White
        Me.btnClose.selected = False
        Me.btnClose.Size = New System.Drawing.Size(129, 48)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "Cancel"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnClose.Textcolor = System.Drawing.Color.White
        Me.btnClose.TextFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'frmDeductionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 359)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtRetained)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRemarks)
        Me.Controls.Add(Me.txtDeductedStocks)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.txtItemDescription)
        Me.Controls.Add(Me.txtItemBrand)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDeductionForm"
        Me.Text = "frmDeductionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtItemBrand As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtItemDescription As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtStocks As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtDeductedStocks As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtRemarks As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtRetained As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnClose As Bunifu.Framework.UI.BunifuFlatButton

End Class
