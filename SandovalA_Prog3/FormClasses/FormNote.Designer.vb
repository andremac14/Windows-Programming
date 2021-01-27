<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNote
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
      Me.Button1 = New System.Windows.Forms.Button()
      Me.TextBox1 = New System.Windows.Forms.TextBox()
      Me.Button2 = New System.Windows.Forms.Button()
      Me.Button3 = New System.Windows.Forms.Button()
      Me.TextBox2 = New System.Windows.Forms.TextBox()
      Me.Button4 = New System.Windows.Forms.Button()
      Me.TextBox3 = New System.Windows.Forms.TextBox()
      Me.TextBox4 = New System.Windows.Forms.TextBox()
      Me.SuspendLayout()
      '
      'Button1
      '
      Me.Button1.Location = New System.Drawing.Point(63, 247)
      Me.Button1.Name = "Button1"
      Me.Button1.Size = New System.Drawing.Size(75, 23)
      Me.Button1.TabIndex = 0
      Me.Button1.Text = "Button1"
      Me.Button1.UseVisualStyleBackColor = True
      '
      'TextBox1
      '
      Me.TextBox1.Location = New System.Drawing.Point(122, 108)
      Me.TextBox1.Name = "TextBox1"
      Me.TextBox1.Size = New System.Drawing.Size(100, 20)
      Me.TextBox1.TabIndex = 1
      '
      'Button2
      '
      Me.Button2.Location = New System.Drawing.Point(165, 247)
      Me.Button2.Name = "Button2"
      Me.Button2.Size = New System.Drawing.Size(75, 23)
      Me.Button2.TabIndex = 2
      Me.Button2.Text = "Button2"
      Me.Button2.UseVisualStyleBackColor = True
      '
      'Button3
      '
      Me.Button3.Location = New System.Drawing.Point(275, 247)
      Me.Button3.Name = "Button3"
      Me.Button3.Size = New System.Drawing.Size(75, 23)
      Me.Button3.TabIndex = 3
      Me.Button3.Text = "Button3"
      Me.Button3.UseVisualStyleBackColor = True
      '
      'TextBox2
      '
      Me.TextBox2.Location = New System.Drawing.Point(477, 108)
      Me.TextBox2.Name = "TextBox2"
      Me.TextBox2.Size = New System.Drawing.Size(100, 20)
      Me.TextBox2.TabIndex = 4
      '
      'Button4
      '
      Me.Button4.Location = New System.Drawing.Point(486, 247)
      Me.Button4.Name = "Button4"
      Me.Button4.Size = New System.Drawing.Size(75, 23)
      Me.Button4.TabIndex = 5
      Me.Button4.Text = "Button4"
      Me.Button4.UseVisualStyleBackColor = True
      '
      'TextBox3
      '
      Me.TextBox3.Location = New System.Drawing.Point(275, 30)
      Me.TextBox3.Name = "TextBox3"
      Me.TextBox3.Size = New System.Drawing.Size(100, 20)
      Me.TextBox3.TabIndex = 6
      '
      'TextBox4
      '
      Me.TextBox4.Location = New System.Drawing.Point(448, 30)
      Me.TextBox4.Name = "TextBox4"
      Me.TextBox4.Size = New System.Drawing.Size(100, 20)
      Me.TextBox4.TabIndex = 7
      '
      'FormNote
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(677, 386)
      Me.Controls.Add(Me.TextBox4)
      Me.Controls.Add(Me.TextBox3)
      Me.Controls.Add(Me.Button4)
      Me.Controls.Add(Me.TextBox2)
      Me.Controls.Add(Me.Button3)
      Me.Controls.Add(Me.Button2)
      Me.Controls.Add(Me.TextBox1)
      Me.Controls.Add(Me.Button1)
      Me.Name = "FormNote"
      Me.Text = "FormNote"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub
   Friend WithEvents Button1 As System.Windows.Forms.Button
   Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
   Friend WithEvents Button2 As System.Windows.Forms.Button
   Friend WithEvents Button3 As System.Windows.Forms.Button
   Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
   Friend WithEvents Button4 As System.Windows.Forms.Button
   Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
   Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
End Class
