<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceManager
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServiceManager))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtServiceName = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.txtServicePrice = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rdoActive = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoInactive = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoFace = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoBody = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoNails = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rdoHair = New MaterialSkin.Controls.MaterialRadioButton()
        Me.btnSave = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.panelServiceType = New System.Windows.Forms.Panel()
        Me.panelServiceStatus = New System.Windows.Forms.Panel()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.panelServiceType.SuspendLayout()
        Me.panelServiceStatus.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Service Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 119)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Service Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Service Price"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(24, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Service Status"
        '
        'txtServiceName
        '
        Me.txtServiceName.Depth = 0
        Me.txtServiceName.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceName.Hint = ""
        Me.txtServiceName.Location = New System.Drawing.Point(127, 76)
        Me.txtServiceName.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtServiceName.Name = "txtServiceName"
        Me.txtServiceName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServiceName.SelectedText = ""
        Me.txtServiceName.SelectionLength = 0
        Me.txtServiceName.SelectionStart = 0
        Me.txtServiceName.Size = New System.Drawing.Size(249, 23)
        Me.txtServiceName.TabIndex = 0
        Me.txtServiceName.UseSystemPasswordChar = False
        '
        'txtServicePrice
        '
        Me.txtServicePrice.Depth = 0
        Me.txtServicePrice.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServicePrice.Hint = ""
        Me.txtServicePrice.Location = New System.Drawing.Point(127, 151)
        Me.txtServicePrice.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtServicePrice.Name = "txtServicePrice"
        Me.txtServicePrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtServicePrice.SelectedText = ""
        Me.txtServicePrice.SelectionLength = 0
        Me.txtServicePrice.SelectionStart = 0
        Me.txtServicePrice.Size = New System.Drawing.Size(249, 23)
        Me.txtServicePrice.TabIndex = 6
        Me.txtServicePrice.UseSystemPasswordChar = False
        '
        'rdoActive
        '
        Me.rdoActive.AutoSize = True
        Me.rdoActive.Depth = 0
        Me.rdoActive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoActive.Location = New System.Drawing.Point(11, 8)
        Me.rdoActive.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoActive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoActive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoActive.Name = "rdoActive"
        Me.rdoActive.Ripple = True
        Me.rdoActive.Size = New System.Drawing.Size(68, 30)
        Me.rdoActive.TabIndex = 8
        Me.rdoActive.TabStop = True
        Me.rdoActive.Text = "Active"
        Me.rdoActive.UseVisualStyleBackColor = True
        '
        'rdoInactive
        '
        Me.rdoInactive.AutoSize = True
        Me.rdoInactive.Depth = 0
        Me.rdoInactive.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoInactive.Location = New System.Drawing.Point(88, 8)
        Me.rdoInactive.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoInactive.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoInactive.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoInactive.Name = "rdoInactive"
        Me.rdoInactive.Ripple = True
        Me.rdoInactive.Size = New System.Drawing.Size(77, 30)
        Me.rdoInactive.TabIndex = 9
        Me.rdoInactive.TabStop = True
        Me.rdoInactive.Text = "Inactive"
        Me.rdoInactive.UseVisualStyleBackColor = True
        '
        'rdoFace
        '
        Me.rdoFace.AutoSize = True
        Me.rdoFace.Depth = 0
        Me.rdoFace.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoFace.Location = New System.Drawing.Point(74, 7)
        Me.rdoFace.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoFace.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoFace.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoFace.Name = "rdoFace"
        Me.rdoFace.Ripple = True
        Me.rdoFace.Size = New System.Drawing.Size(58, 30)
        Me.rdoFace.TabIndex = 11
        Me.rdoFace.TabStop = True
        Me.rdoFace.Text = "Face"
        Me.rdoFace.UseVisualStyleBackColor = True
        '
        'rdoBody
        '
        Me.rdoBody.AutoSize = True
        Me.rdoBody.Depth = 0
        Me.rdoBody.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoBody.Location = New System.Drawing.Point(9, 7)
        Me.rdoBody.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoBody.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoBody.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoBody.Name = "rdoBody"
        Me.rdoBody.Ripple = True
        Me.rdoBody.Size = New System.Drawing.Size(60, 30)
        Me.rdoBody.TabIndex = 10
        Me.rdoBody.TabStop = True
        Me.rdoBody.Text = "Body"
        Me.rdoBody.UseVisualStyleBackColor = True
        '
        'rdoNails
        '
        Me.rdoNails.AutoSize = True
        Me.rdoNails.Depth = 0
        Me.rdoNails.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoNails.Location = New System.Drawing.Point(198, 7)
        Me.rdoNails.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoNails.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoNails.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoNails.Name = "rdoNails"
        Me.rdoNails.Ripple = True
        Me.rdoNails.Size = New System.Drawing.Size(60, 30)
        Me.rdoNails.TabIndex = 13
        Me.rdoNails.TabStop = True
        Me.rdoNails.Text = "Nails"
        Me.rdoNails.UseVisualStyleBackColor = True
        '
        'rdoHair
        '
        Me.rdoHair.AutoSize = True
        Me.rdoHair.Depth = 0
        Me.rdoHair.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rdoHair.Location = New System.Drawing.Point(137, 7)
        Me.rdoHair.Margin = New System.Windows.Forms.Padding(0)
        Me.rdoHair.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rdoHair.MouseState = MaterialSkin.MouseState.HOVER
        Me.rdoHair.Name = "rdoHair"
        Me.rdoHair.Ripple = True
        Me.rdoHair.Size = New System.Drawing.Size(54, 30)
        Me.rdoHair.TabIndex = 12
        Me.rdoHair.TabStop = True
        Me.rdoHair.Text = "Hair"
        Me.rdoHair.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Depth = 0
        Me.btnSave.Location = New System.Drawing.Point(167, 241)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Primary = True
        Me.btnSave.Size = New System.Drawing.Size(90, 39)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'panelServiceType
        '
        Me.panelServiceType.Controls.Add(Me.rdoBody)
        Me.panelServiceType.Controls.Add(Me.rdoFace)
        Me.panelServiceType.Controls.Add(Me.rdoNails)
        Me.panelServiceType.Controls.Add(Me.rdoHair)
        Me.panelServiceType.Location = New System.Drawing.Point(119, 105)
        Me.panelServiceType.Name = "panelServiceType"
        Me.panelServiceType.Size = New System.Drawing.Size(271, 40)
        Me.panelServiceType.TabIndex = 15
        '
        'panelServiceStatus
        '
        Me.panelServiceStatus.Controls.Add(Me.rdoActive)
        Me.panelServiceStatus.Controls.Add(Me.rdoInactive)
        Me.panelServiceStatus.Location = New System.Drawing.Point(127, 180)
        Me.panelServiceStatus.Name = "panelServiceStatus"
        Me.panelServiceStatus.Size = New System.Drawing.Size(175, 43)
        Me.panelServiceStatus.TabIndex = 17
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'frmServiceManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(413, 306)
        Me.Controls.Add(Me.panelServiceStatus)
        Me.Controls.Add(Me.panelServiceType)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtServicePrice)
        Me.Controls.Add(Me.txtServiceName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServiceManager"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Service Manager"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        Me.panelServiceType.ResumeLayout(False)
        Me.panelServiceType.PerformLayout()
        Me.panelServiceStatus.ResumeLayout(False)
        Me.panelServiceStatus.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtServiceName As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents txtServicePrice As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rdoActive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoInactive As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoFace As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoBody As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoNails As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rdoHair As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents panelServiceType As Panel
    Friend WithEvents panelServiceStatus As Panel
    Friend WithEvents ErrorProvider1 As ErrorProvider
End Class
