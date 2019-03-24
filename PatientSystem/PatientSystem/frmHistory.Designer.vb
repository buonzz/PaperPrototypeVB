<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHistory
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
        Me.dgvCheckups = New System.Windows.Forms.DataGridView()
        Me.btnDone = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvCheckups, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCheckups
        '
        Me.dgvCheckups.AllowUserToAddRows = False
        Me.dgvCheckups.AllowUserToDeleteRows = False
        Me.dgvCheckups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCheckups.Location = New System.Drawing.Point(12, 12)
        Me.dgvCheckups.Name = "dgvCheckups"
        Me.dgvCheckups.RowTemplate.Height = 24
        Me.dgvCheckups.Size = New System.Drawing.Size(776, 426)
        Me.dgvCheckups.TabIndex = 0
        '
        'btnDone
        '
        Me.btnDone.Location = New System.Drawing.Point(661, 445)
        Me.btnDone.Name = "btnDone"
        Me.btnDone.Size = New System.Drawing.Size(127, 38)
        Me.btnDone.TabIndex = 1
        Me.btnDone.Text = "Done"
        Me.btnDone.UseVisualStyleBackColor = True
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(521, 444)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(123, 38)
        Me.btnAddRecord.TabIndex = 2
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(399, 445)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(116, 38)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'frmHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 495)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.btnDone)
        Me.Controls.Add(Me.dgvCheckups)
        Me.Name = "frmHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "History"
        CType(Me.dgvCheckups, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvCheckups As DataGridView
    Friend WithEvents btnDone As Button
    Friend WithEvents btnAddRecord As Button
    Friend WithEvents btnRefresh As Button
End Class
