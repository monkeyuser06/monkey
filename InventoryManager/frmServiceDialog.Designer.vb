<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServiceDialog
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
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblServicePrice = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblServicename = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.cboEmployeeAssigned = New MetroFramework.Controls.MetroComboBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnAdd = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.btnCancel = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.SuspendLayout()
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(23, 32)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(96, 17)
        Me.BunifuCustomLabel1.TabIndex = 0
        Me.BunifuCustomLabel1.Text = "Service Name:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(23, 60)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(90, 17)
        Me.BunifuCustomLabel2.TabIndex = 1
        Me.BunifuCustomLabel2.Text = "Service Price:"
        '
        'lblServicePrice
        '
        Me.lblServicePrice.AutoSize = True
        Me.lblServicePrice.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicePrice.Location = New System.Drawing.Point(125, 60)
        Me.lblServicePrice.Name = "lblServicePrice"
        Me.lblServicePrice.Size = New System.Drawing.Size(90, 17)
        Me.lblServicePrice.TabIndex = 3
        Me.lblServicePrice.Text = "Service Price:"
        '
        'lblServicename
        '
        Me.lblServicename.AutoSize = True
        Me.lblServicename.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServicename.Location = New System.Drawing.Point(125, 32)
        Me.lblServicename.Name = "lblServicename"
        Me.lblServicename.Size = New System.Drawing.Size(96, 17)
        Me.lblServicename.TabIndex = 2
        Me.lblServicename.Text = "Service Name:"
        '
        'cboEmployeeAssigned
        '
        Me.cboEmployeeAssigned.FormattingEnabled = True
        Me.cboEmployeeAssigned.ItemHeight = 23
        Me.cboEmployeeAssigned.Location = New System.Drawing.Point(154, 83)
        Me.cboEmployeeAssigned.Name = "cboEmployeeAssigned"
        Me.cboEmployeeAssigned.Size = New System.Drawing.Size(240, 29)
        Me.cboEmployeeAssigned.TabIndex = 4
        Me.cboEmployeeAssigned.UseSelectable = True
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(23, 89)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(125, 17)
        Me.BunifuCustomLabel3.TabIndex = 5
        Me.BunifuCustomLabel3.Text = "Employee Assigned:"
        '
        'btnAdd
        '
        Me.btnAdd.Depth = 0
        Me.btnAdd.Location = New System.Drawing.Point(108, 140)
        Me.btnAdd.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Primary = True
        Me.btnAdd.Size = New System.Drawing.Size(93, 33)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Depth = 0
        Me.btnCancel.Location = New System.Drawing.Point(207, 140)
        Me.btnCancel.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Primary = True
        Me.btnCancel.Size = New System.Drawing.Size(93, 33)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "CANCEL"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'frmServiceDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(418, 196)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.BunifuCustomLabel3)
        Me.Controls.Add(Me.cboEmployeeAssigned)
        Me.Controls.Add(Me.lblServicePrice)
        Me.Controls.Add(Me.lblServicename)
        Me.Controls.Add(Me.BunifuCustomLabel2)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.MaximizeBox = False
        Me.Name = "frmServiceDialog"
        Me.Resizable = False
        Me.Style = MetroFramework.MetroColorStyle.Pink
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblServicePrice As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblServicename As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents cboEmployeeAssigned As MetroFramework.Controls.MetroComboBox
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnAdd As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents btnCancel As MaterialSkin.Controls.MaterialRaisedButton
End Class
