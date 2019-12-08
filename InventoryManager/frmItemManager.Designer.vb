<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemManager))
        Me.groupBoxRole = New System.Windows.Forms.GroupBox()
        Me.rdoFace = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoNails = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoBody = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoHair = New MaterialSkin.Controls.MaterialRadioButton()
        Me.txtDescription = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtStocks = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtItemBrand = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.btnSaveItem = New MaterialSkin.Controls.MaterialFlatButton()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpExpirationDate = New MetroFramework.Controls.MetroDateTime()
        Me.txtCritPoint = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtVolume = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdoSachet = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoBottle = New MaterialSkin.Controls.MaterialRadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.groupBoxRole.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'groupBoxRole
        '
        Me.groupBoxRole.Controls.Add(Me.rdoFace)
        Me.groupBoxRole.Controls.Add(Me.rdoNails)
        Me.groupBoxRole.Controls.Add(Me.rdoBody)
        Me.groupBoxRole.Controls.Add(Me.rdoHair)
        Me.groupBoxRole.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.groupBoxRole.Location = New System.Drawing.Point(11, 276)
        Me.groupBoxRole.Name = "groupBoxRole"
        Me.groupBoxRole.Size = New System.Drawing.Size(388, 62)
        Me.groupBoxRole.TabIndex = 5
        Me.groupBoxRole.TabStop = False
        Me.groupBoxRole.Text = "Classification"
        '
        'rdoFace
        '
        Me.rdoFace.AutoSize = True
        Me.rdoFace.Depth = 0
        Me.rdoFace.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoFace.Location = New System.Drawing.Point(115, 21)
        Me.rdoFace.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoFace.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoFace.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoFace.Name = "rdoFace"
        Me.rdoFace.Ripple = True
        Me.rdoFace.Size = New System.Drawing.Size(58, 30)
        Me.rdoFace.TabIndex = 10
        Me.rdoFace.TabStop = True
        Me.rdoFace.Text = "Face"
        Me.rdoFace.UseVisualStyleBackColor = True
        '
        'rdoNails
        '
        Me.rdoNails.AutoSize = True
        Me.rdoNails.Depth = 0
        Me.rdoNails.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoNails.Location = New System.Drawing.Point(255, 21)
        Me.rdoNails.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoNails.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoNails.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoNails.Name = "rdoNails"
        Me.rdoNails.Ripple = True
        Me.rdoNails.Size = New System.Drawing.Size(60, 30)
        Me.rdoNails.TabIndex = 12
        Me.rdoNails.TabStop = True
        Me.rdoNails.Text = "Nails"
        Me.rdoNails.UseVisualStyleBackColor = True
        '
        'rdoBody
        '
        Me.rdoBody.AutoSize = True
        Me.rdoBody.Depth = 0
        Me.rdoBody.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoBody.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoBody.Location = New System.Drawing.Point(37, 21)
        Me.rdoBody.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoBody.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoBody.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoBody.Name = "rdoBody"
        Me.rdoBody.Ripple = True
        Me.rdoBody.Size = New System.Drawing.Size(60, 30)
        Me.rdoBody.TabIndex = 9
        Me.rdoBody.TabStop = True
        Me.rdoBody.Text = "Body"
        Me.rdoBody.UseCompatibleTextRendering = True
        Me.rdoBody.UseVisualStyleBackColor = True
        '
        'rdoHair
        '
        Me.rdoHair.AutoSize = True
        Me.rdoHair.Depth = 0
        Me.rdoHair.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoHair.Location = New System.Drawing.Point(188, 21)
        Me.rdoHair.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoHair.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoHair.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoHair.Name = "rdoHair"
        Me.rdoHair.Ripple = True
        Me.rdoHair.Size = New System.Drawing.Size(54, 30)
        Me.rdoHair.TabIndex = 11
        Me.rdoHair.TabStop = True
        Me.rdoHair.Text = "Hair"
        Me.rdoHair.UseVisualStyleBackColor = True
        '
        'txtDescription
        '
        Me.txtDescription.Depth = 0
        Me.txtDescription.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtDescription.Hint = ""
        Me.txtDescription.Location = New System.Drawing.Point(94, 92)
        Me.txtDescription.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDescription.SelectedText = ""
        Me.txtDescription.SelectionLength = 0
        Me.txtDescription.SelectionStart = 0
        Me.txtDescription.Size = New System.Drawing.Size(295, 23)
        Me.txtDescription.TabIndex = 1
        Me.txtDescription.TabStop = False
        Me.txtDescription.UseSystemPasswordChar = False
        '
        'txtStocks
        '
        Me.txtStocks.Depth = 0
        Me.txtStocks.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtStocks.Hint = ""
        Me.txtStocks.Location = New System.Drawing.Point(111, 182)
        Me.txtStocks.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtStocks.Name = "txtStocks"
        Me.txtStocks.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtStocks.SelectedText = ""
        Me.txtStocks.SelectionLength = 0
        Me.txtStocks.SelectionStart = 0
        Me.txtStocks.Size = New System.Drawing.Size(93, 23)
        Me.txtStocks.TabIndex = 5
        Me.txtStocks.TabStop = False
        Me.txtStocks.UseSystemPasswordChar = False
        '
        'txtItemBrand
        '
        Me.txtItemBrand.Depth = 0
        Me.txtItemBrand.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtItemBrand.Hint = ""
        Me.txtItemBrand.Location = New System.Drawing.Point(94, 63)
        Me.txtItemBrand.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtItemBrand.Name = "txtItemBrand"
        Me.txtItemBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtItemBrand.SelectedText = ""
        Me.txtItemBrand.SelectionLength = 0
        Me.txtItemBrand.SelectionStart = 0
        Me.txtItemBrand.Size = New System.Drawing.Size(295, 23)
        Me.txtItemBrand.TabIndex = 0
        Me.txtItemBrand.TabStop = False
        Me.txtItemBrand.UseSystemPasswordChar = False
        '
        'btnSaveItem
        '
        Me.btnSaveItem.AutoSize = True
        Me.btnSaveItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveItem.Depth = 0
        Me.btnSaveItem.Location = New System.Drawing.Point(184, 347)
        Me.btnSaveItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Primary = False
        Me.btnSaveItem.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveItem.TabIndex = 7
        Me.btnSaveItem.TabStop = False
        Me.btnSaveItem.Text = "SAVE"
        Me.btnSaveItem.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(8, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Expiration Date"
        '
        'dtpExpirationDate
        '
        Me.dtpExpirationDate.CalendarFont = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpirationDate.CustomFormat = "MM/dd/yyyy"
        Me.dtpExpirationDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpExpirationDate.Location = New System.Drawing.Point(121, 241)
        Me.dtpExpirationDate.MinDate = New Date(2019, 8, 29, 0, 0, 0, 0)
        Me.dtpExpirationDate.MinimumSize = New System.Drawing.Size(0, 29)
        Me.dtpExpirationDate.Name = "dtpExpirationDate"
        Me.dtpExpirationDate.Size = New System.Drawing.Size(111, 29)
        Me.dtpExpirationDate.Style = MetroFramework.MetroColorStyle.Blue
        Me.dtpExpirationDate.TabIndex = 8
        Me.dtpExpirationDate.UseCustomBackColor = True
        Me.dtpExpirationDate.UseCustomForeColor = True
        Me.dtpExpirationDate.UseStyleColors = True
        '
        'txtCritPoint
        '
        Me.txtCritPoint.Depth = 0
        Me.txtCritPoint.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtCritPoint.Hint = ""
        Me.txtCritPoint.Location = New System.Drawing.Point(105, 211)
        Me.txtCritPoint.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtCritPoint.Name = "txtCritPoint"
        Me.txtCritPoint.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCritPoint.SelectedText = ""
        Me.txtCritPoint.SelectionLength = 0
        Me.txtCritPoint.SelectionStart = 0
        Me.txtCritPoint.Size = New System.Drawing.Size(97, 23)
        Me.txtCritPoint.TabIndex = 7
        Me.txtCritPoint.TabStop = False
        Me.txtCritPoint.UseSystemPasswordChar = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(8, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Brand"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(8, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Physical Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(8, 213)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Critical Point"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(8, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Description"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(210, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Volume"
        '
        'txtVolume
        '
        Me.txtVolume.Depth = 0
        Me.txtVolume.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtVolume.Hint = ""
        Me.txtVolume.Location = New System.Drawing.Point(274, 182)
        Me.txtVolume.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtVolume.Name = "txtVolume"
        Me.txtVolume.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtVolume.SelectedText = ""
        Me.txtVolume.SelectionLength = 0
        Me.txtVolume.SelectionStart = 0
        Me.txtVolume.Size = New System.Drawing.Size(115, 23)
        Me.txtVolume.TabIndex = 6
        Me.txtVolume.TabStop = False
        Me.txtVolume.UseSystemPasswordChar = False
        '
        'rdoSachet
        '
        Me.rdoSachet.AutoSize = True
        Me.rdoSachet.Depth = 0
        Me.rdoSachet.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoSachet.Location = New System.Drawing.Point(116, 150)
        Me.rdoSachet.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoSachet.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoSachet.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoSachet.Name = "rdoSachet"
        Me.rdoSachet.Ripple = True
        Me.rdoSachet.Size = New System.Drawing.Size(71, 30)
        Me.rdoSachet.TabIndex = 3
        Me.rdoSachet.TabStop = True
        Me.rdoSachet.Text = "Sachet"
        Me.rdoSachet.UseVisualStyleBackColor = True
        '
        'rdoBottle
        '
        Me.rdoBottle.AutoSize = True
        Me.rdoBottle.Depth = 0
        Me.rdoBottle.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoBottle.Location = New System.Drawing.Point(203, 150)
        Me.rdoBottle.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoBottle.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoBottle.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoBottle.Name = "rdoBottle"
        Me.rdoBottle.Ripple = True
        Me.rdoBottle.Size = New System.Drawing.Size(65, 30)
        Me.rdoBottle.TabIndex = 4
        Me.rdoBottle.TabStop = True
        Me.rdoBottle.Text = "Bottle"
        Me.rdoBottle.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(8, 156)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Container Type"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.Label8.Location = New System.Drawing.Point(8, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Price"
        '
        'txtPrice
        '
        Me.txtPrice.Depth = 0
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.txtPrice.Hint = ""
        Me.txtPrice.Location = New System.Drawing.Point(94, 121)
        Me.txtPrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.Size = New System.Drawing.Size(136, 23)
        Me.txtPrice.TabIndex = 2
        Me.txtPrice.TabStop = False
        Me.txtPrice.UseSystemPasswordChar = False
        '
        'frmItemManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 399)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rdoBottle)
        Me.Controls.Add(Me.rdoSachet)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtVolume)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCritPoint)
        Me.Controls.Add(Me.dtpExpirationDate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Controls.Add(Me.groupBoxRole)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtStocks)
        Me.Controls.Add(Me.txtItemBrand)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmItemManager"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Item Manager"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.groupBoxRole.ResumeLayout(False)
        Me.groupBoxRole.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents groupBoxRole As GroupBox
    Friend WithEvents rdoNails As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoBody As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoHair As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents txtDescription As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtStocks As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtItemBrand As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents btnSaveItem As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label1 As Label
    Friend WithEvents rdoFace As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents dtpExpirationDate As MetroFramework.Controls.MetroDateTime
    Friend WithEvents txtCritPoint As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents rdoBottle As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoSachet As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txtVolume As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label8 As Label
    Friend WithEvents txtPrice As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
