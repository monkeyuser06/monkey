<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemQuantity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmItemQuantity))
        Me.btnSaveItem = New MaterialSkin.Controls.MaterialFlatButton()
        Me.txtQuantityOut = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblWordings = New System.Windows.Forms.Label()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSaveItem
        '
        Me.btnSaveItem.AutoSize = True
        Me.btnSaveItem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSaveItem.Depth = 0
        Me.btnSaveItem.Location = New System.Drawing.Point(138, 140)
        Me.btnSaveItem.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSaveItem.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSaveItem.Name = "btnSaveItem"
        Me.btnSaveItem.Primary = False
        Me.btnSaveItem.Size = New System.Drawing.Size(46, 36)
        Me.btnSaveItem.TabIndex = 25
        Me.btnSaveItem.TabStop = False
        Me.btnSaveItem.Text = "SAVE"
        Me.btnSaveItem.UseVisualStyleBackColor = True
        '
        'txtQuantityOut
        '
        Me.txtQuantityOut.Depth = 0
        Me.txtQuantityOut.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantityOut.Hint = ""
        Me.txtQuantityOut.Location = New System.Drawing.Point(55, 107)
        Me.txtQuantityOut.MouseState = MaterialSkin.MouseState.HOVER
        Me.txtQuantityOut.Name = "txtQuantityOut"
        Me.txtQuantityOut.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantityOut.SelectedText = ""
        Me.txtQuantityOut.SelectionLength = 0
        Me.txtQuantityOut.SelectionStart = 0
        Me.txtQuantityOut.Size = New System.Drawing.Size(83, 23)
        Me.txtQuantityOut.TabIndex = 40
        Me.txtQuantityOut.UseSystemPasswordChar = False
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblText2.Location = New System.Drawing.Point(144, 111)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(97, 17)
        Me.lblText2.TabIndex = 39
        Me.lblText2.Text = "Quantity Used"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.ErrorProvider1.ContainerControl = Me
        '
        'lblWordings
        '
        Me.lblWordings.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWordings.Location = New System.Drawing.Point(23, 57)
        Me.lblWordings.Name = "lblWordings"
        Me.lblWordings.Size = New System.Drawing.Size(267, 47)
        Me.lblWordings.TabIndex = 31
        Me.lblWordings.Text = "Please Input Volume:"
        Me.lblWordings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmItemQuantity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 188)
        Me.Controls.Add(Me.txtQuantityOut)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblWordings)
        Me.Controls.Add(Me.btnSaveItem)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmItemQuantity"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.Text = "Item Checkout"
        Me.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSaveItem As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents txtQuantityOut As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblText2 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents lblWordings As Label
End Class
