<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewCheckUp
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPatient = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDisease = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTreatment = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Patient"
        '
        'txtPatient
        '
        Me.txtPatient.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.txtPatient.Location = New System.Drawing.Point(171, 31)
        Me.txtPatient.Name = "txtPatient"
        Me.txtPatient.ReadOnly = True
        Me.txtPatient.Size = New System.Drawing.Size(355, 22)
        Me.txtPatient.TabIndex = 1
        Me.txtPatient.WordWrap = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Disease"
        '
        'txtDisease
        '
        Me.txtDisease.Location = New System.Drawing.Point(176, 84)
        Me.txtDisease.Multiline = True
        Me.txtDisease.Name = "txtDisease"
        Me.txtDisease.Size = New System.Drawing.Size(596, 181)
        Me.txtDisease.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Treatment"
        '
        'txtTreatment
        '
        Me.txtTreatment.Location = New System.Drawing.Point(178, 294)
        Me.txtTreatment.Multiline = True
        Me.txtTreatment.Name = "txtTreatment"
        Me.txtTreatment.Size = New System.Drawing.Size(593, 123)
        Me.txtTreatment.TabIndex = 5
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(552, 452)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(219, 45)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'frmNewCheckUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 518)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtTreatment)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDisease)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPatient)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmNewCheckUp"
        Me.Text = "New Check Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPatient As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDisease As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTreatment As TextBox
    Friend WithEvents btnSave As Button
End Class
