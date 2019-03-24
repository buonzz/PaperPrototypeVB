<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageCheckup
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
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.dgvPatients = New System.Windows.Forms.DataGridView()
        Me.btnCheckHistory = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(128, 35)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(266, 22)
        Me.txtPatientID.TabIndex = 0
        '
        'dgvPatients
        '
        Me.dgvPatients.AllowUserToAddRows = False
        Me.dgvPatients.AllowUserToDeleteRows = False
        Me.dgvPatients.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPatients.Location = New System.Drawing.Point(24, 83)
        Me.dgvPatients.Name = "dgvPatients"
        Me.dgvPatients.RowTemplate.Height = 24
        Me.dgvPatients.Size = New System.Drawing.Size(764, 287)
        Me.dgvPatients.TabIndex = 1
        '
        'btnCheckHistory
        '
        Me.btnCheckHistory.Location = New System.Drawing.Point(632, 397)
        Me.btnCheckHistory.Name = "btnCheckHistory"
        Me.btnCheckHistory.Size = New System.Drawing.Size(156, 41)
        Me.btnCheckHistory.TabIndex = 2
        Me.btnCheckHistory.Text = "Check History"
        Me.btnCheckHistory.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Enter Patient ID"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(410, 40)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(0, 17)
        Me.lblMessage.TabIndex = 5
        '
        'frmManageCheckup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCheckHistory)
        Me.Controls.Add(Me.dgvPatients)
        Me.Controls.Add(Me.txtPatientID)
        Me.Name = "frmManageCheckup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Checkup"
        CType(Me.dgvPatients, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents dgvPatients As DataGridView
    Friend WithEvents btnCheckHistory As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblMessage As Label
End Class
