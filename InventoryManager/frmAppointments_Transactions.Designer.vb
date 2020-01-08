<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAppointments_Transactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAppointments_Transactions))
        Me.dgvAppointmentTransactions = New Bunifu.Framework.UI.BunifuCustomDataGrid()
        CType(Me.dgvAppointmentTransactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAppointmentTransactions
        '
        Me.dgvAppointmentTransactions.AllowUserToAddRows = False
        Me.dgvAppointmentTransactions.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgvAppointmentTransactions.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvAppointmentTransactions.BackgroundColor = System.Drawing.Color.White
        Me.dgvAppointmentTransactions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAppointmentTransactions.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvAppointmentTransactions.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvAppointmentTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAppointmentTransactions.DoubleBuffered = True
        Me.dgvAppointmentTransactions.EnableHeadersVisualStyles = False
        Me.dgvAppointmentTransactions.HeaderBgColor = System.Drawing.Color.SeaGreen
        Me.dgvAppointmentTransactions.HeaderForeColor = System.Drawing.Color.SeaGreen
        Me.dgvAppointmentTransactions.Location = New System.Drawing.Point(12, 195)
        Me.dgvAppointmentTransactions.Name = "dgvAppointmentTransactions"
        Me.dgvAppointmentTransactions.ReadOnly = True
        Me.dgvAppointmentTransactions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAppointmentTransactions.Size = New System.Drawing.Size(342, 276)
        Me.dgvAppointmentTransactions.TabIndex = 0
        '
        'frmAppointments_Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(890, 431)
        Me.Controls.Add(Me.dgvAppointmentTransactions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAppointments_Transactions"
        Me.Text = "frmAppointments_Transactions"
        CType(Me.dgvAppointmentTransactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvAppointmentTransactions As Bunifu.Framework.UI.BunifuCustomDataGrid
End Class
