<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultiChoice
   Inherits System.Windows.Forms.UserControl

   'UserControl overrides dispose to clean up the component list.
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
      Me.lblIndex = New System.Windows.Forms.Label()
      Me.txtQuestion = New System.Windows.Forms.TextBox()
      Me.txtAnswer1 = New System.Windows.Forms.TextBox()
      Me.txtAnswer3 = New System.Windows.Forms.TextBox()
      Me.txtAnswer2 = New System.Windows.Forms.TextBox()
      Me.txtAnswer4 = New System.Windows.Forms.TextBox()
      Me.RadioButton1 = New System.Windows.Forms.RadioButton()
      Me.RadioButton2 = New System.Windows.Forms.RadioButton()
      Me.RadioButton3 = New System.Windows.Forms.RadioButton()
      Me.RadioButton4 = New System.Windows.Forms.RadioButton()
      Me.SuspendLayout()
      '
      'lblIndex
      '
      Me.lblIndex.AutoSize = True
      Me.lblIndex.Location = New System.Drawing.Point(8, 24)
      Me.lblIndex.Name = "lblIndex"
      Me.lblIndex.Size = New System.Drawing.Size(39, 13)
      Me.lblIndex.TabIndex = 0
      Me.lblIndex.Text = "Label1"
      '
      'txtQuestion
      '
      Me.txtQuestion.Location = New System.Drawing.Point(64, 24)
      Me.txtQuestion.Name = "txtQuestion"
      Me.txtQuestion.Size = New System.Drawing.Size(560, 20)
      Me.txtQuestion.TabIndex = 1
      '
      'txtAnswer1
      '
      Me.txtAnswer1.Location = New System.Drawing.Point(160, 70)
      Me.txtAnswer1.Name = "txtAnswer1"
      Me.txtAnswer1.Size = New System.Drawing.Size(170, 20)
      Me.txtAnswer1.TabIndex = 2
      '
      'txtAnswer3
      '
      Me.txtAnswer3.Location = New System.Drawing.Point(160, 120)
      Me.txtAnswer3.Name = "txtAnswer3"
      Me.txtAnswer3.Size = New System.Drawing.Size(170, 20)
      Me.txtAnswer3.TabIndex = 3
      '
      'txtAnswer2
      '
      Me.txtAnswer2.Location = New System.Drawing.Point(440, 70)
      Me.txtAnswer2.Name = "txtAnswer2"
      Me.txtAnswer2.Size = New System.Drawing.Size(170, 20)
      Me.txtAnswer2.TabIndex = 4
      '
      'txtAnswer4
      '
      Me.txtAnswer4.Location = New System.Drawing.Point(440, 120)
      Me.txtAnswer4.Name = "txtAnswer4"
      Me.txtAnswer4.Size = New System.Drawing.Size(170, 20)
      Me.txtAnswer4.TabIndex = 5
      '
      'RadioButton1
      '
      Me.RadioButton1.AutoSize = True
      Me.RadioButton1.Location = New System.Drawing.Point(130, 70)
      Me.RadioButton1.Name = "RadioButton1"
      Me.RadioButton1.Size = New System.Drawing.Size(14, 13)
      Me.RadioButton1.TabIndex = 6
      Me.RadioButton1.TabStop = True
      Me.RadioButton1.UseVisualStyleBackColor = True
      '
      'RadioButton2
      '
      Me.RadioButton2.AutoSize = True
      Me.RadioButton2.Location = New System.Drawing.Point(410, 70)
      Me.RadioButton2.Name = "RadioButton2"
      Me.RadioButton2.Size = New System.Drawing.Size(14, 13)
      Me.RadioButton2.TabIndex = 7
      Me.RadioButton2.TabStop = True
      Me.RadioButton2.UseVisualStyleBackColor = True
      '
      'RadioButton3
      '
      Me.RadioButton3.AutoSize = True
      Me.RadioButton3.Location = New System.Drawing.Point(130, 120)
      Me.RadioButton3.Name = "RadioButton3"
      Me.RadioButton3.Size = New System.Drawing.Size(14, 13)
      Me.RadioButton3.TabIndex = 8
      Me.RadioButton3.TabStop = True
      Me.RadioButton3.UseVisualStyleBackColor = True
      '
      'RadioButton4
      '
      Me.RadioButton4.AutoSize = True
      Me.RadioButton4.Location = New System.Drawing.Point(410, 120)
      Me.RadioButton4.Name = "RadioButton4"
      Me.RadioButton4.Size = New System.Drawing.Size(14, 13)
      Me.RadioButton4.TabIndex = 9
      Me.RadioButton4.TabStop = True
      Me.RadioButton4.UseVisualStyleBackColor = True
      '
      'MultiChoice
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.Controls.Add(Me.RadioButton4)
      Me.Controls.Add(Me.RadioButton3)
      Me.Controls.Add(Me.RadioButton2)
      Me.Controls.Add(Me.RadioButton1)
      Me.Controls.Add(Me.txtAnswer4)
      Me.Controls.Add(Me.txtAnswer2)
      Me.Controls.Add(Me.txtAnswer3)
      Me.Controls.Add(Me.txtAnswer1)
      Me.Controls.Add(Me.txtQuestion)
      Me.Controls.Add(Me.lblIndex)
      Me.Name = "MultiChoice"
      Me.Size = New System.Drawing.Size(700, 180)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblIndex As Windows.Forms.Label
   Friend WithEvents txtQuestion As Windows.Forms.TextBox
   Friend WithEvents txtAnswer1 As Windows.Forms.TextBox
   Friend WithEvents txtAnswer3 As Windows.Forms.TextBox
   Friend WithEvents txtAnswer2 As Windows.Forms.TextBox
   Friend WithEvents txtAnswer4 As Windows.Forms.TextBox
   Friend WithEvents RadioButton1 As Windows.Forms.RadioButton
   Friend WithEvents RadioButton2 As Windows.Forms.RadioButton
   Friend WithEvents RadioButton3 As Windows.Forms.RadioButton
   Friend WithEvents RadioButton4 As Windows.Forms.RadioButton
End Class
