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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnCheckHistory = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(24, 33)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(266, 22)
        Me.txtPatientID.TabIndex = 0
        Me.txtPatientID.Text = "Enter Patient ID"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 83)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(764, 287)
        Me.DataGridView1.TabIndex = 1
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
        'frmManageCheckup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCheckHistory)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPatientID)
        Me.Name = "frmManageCheckup"
        Me.Text = "Manage Checkup"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCheckHistory As Button
End Class
