<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.btnManagePatient = New System.Windows.Forms.Button()
        Me.btnManageCheckup = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnManagePatient
        '
        Me.btnManagePatient.Location = New System.Drawing.Point(29, 88)
        Me.btnManagePatient.Name = "btnManagePatient"
        Me.btnManagePatient.Size = New System.Drawing.Size(172, 116)
        Me.btnManagePatient.TabIndex = 0
        Me.btnManagePatient.Text = "Manage Patient"
        Me.btnManagePatient.UseVisualStyleBackColor = True
        '
        'btnManageCheckup
        '
        Me.btnManageCheckup.Location = New System.Drawing.Point(240, 88)
        Me.btnManageCheckup.Name = "btnManageCheckup"
        Me.btnManageCheckup.Size = New System.Drawing.Size(172, 116)
        Me.btnManageCheckup.TabIndex = 1
        Me.btnManageCheckup.Text = "Manage Checkup"
        Me.btnManageCheckup.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(206, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Menu"
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(337, 253)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(75, 36)
        Me.btnDone.TabIndex = 3
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 320)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnManageCheckup)
        Me.Controls.Add(Me.btnManagePatient)
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnManagePatient As Button
    Friend WithEvents btnManageCheckup As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDone As Button
End Class
