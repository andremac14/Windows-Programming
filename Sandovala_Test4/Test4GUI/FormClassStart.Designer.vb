<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassStart
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
      Me.btnCreate = New System.Windows.Forms.Button()
      Me.btnEdit = New System.Windows.Forms.Button()
      Me.btnTake = New System.Windows.Forms.Button()
      Me.btnExit = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'btnCreate
      '
      Me.btnCreate.Location = New System.Drawing.Point(187, 200)
      Me.btnCreate.Name = "btnCreate"
      Me.btnCreate.Size = New System.Drawing.Size(75, 23)
      Me.btnCreate.TabIndex = 0
      Me.btnCreate.Text = "Create"
      Me.btnCreate.UseVisualStyleBackColor = True
      '
      'btnEdit
      '
      Me.btnEdit.Location = New System.Drawing.Point(333, 200)
      Me.btnEdit.Name = "btnEdit"
      Me.btnEdit.Size = New System.Drawing.Size(75, 23)
      Me.btnEdit.TabIndex = 1
      Me.btnEdit.Text = "Edit"
      Me.btnEdit.UseVisualStyleBackColor = True
      '
      'btnTake
      '
      Me.btnTake.Location = New System.Drawing.Point(503, 200)
      Me.btnTake.Name = "btnTake"
      Me.btnTake.Size = New System.Drawing.Size(75, 23)
      Me.btnTake.TabIndex = 2
      Me.btnTake.Text = "Take"
      Me.btnTake.UseVisualStyleBackColor = True
      '
      'btnExit
      '
      Me.btnExit.Location = New System.Drawing.Point(644, 200)
      Me.btnExit.Name = "btnExit"
      Me.btnExit.Size = New System.Drawing.Size(75, 23)
      Me.btnExit.TabIndex = 3
      Me.btnExit.Text = "Exit"
      Me.btnExit.UseVisualStyleBackColor = True
      '
      'FormClassStart
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(900, 437)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnExit)
      Me.Controls.Add(Me.btnTake)
      Me.Controls.Add(Me.btnEdit)
      Me.Controls.Add(Me.btnCreate)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormClassStart"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "Test 4 - Andre Sandoval"
      Me.ResumeLayout(False)

   End Sub

   Friend WithEvents btnCreate As Button
   Friend WithEvents btnEdit As Button
   Friend WithEvents btnTake As Button
   Friend WithEvents btnExit As Button
End Class
