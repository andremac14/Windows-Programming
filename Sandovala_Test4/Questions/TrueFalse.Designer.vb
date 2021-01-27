<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TrueFalse
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
      Me.rdoTrue = New System.Windows.Forms.RadioButton()
      Me.rdoFalse = New System.Windows.Forms.RadioButton()
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
      'rdoTrue
      '
      Me.rdoTrue.AutoSize = True
      Me.rdoTrue.Location = New System.Drawing.Point(130, 70)
      Me.rdoTrue.Name = "rdoTrue"
      Me.rdoTrue.Size = New System.Drawing.Size(47, 17)
      Me.rdoTrue.TabIndex = 2
      Me.rdoTrue.TabStop = True
      Me.rdoTrue.Text = "True"
      Me.rdoTrue.UseVisualStyleBackColor = True
      '
      'rdoFalse
      '
      Me.rdoFalse.AutoSize = True
      Me.rdoFalse.Location = New System.Drawing.Point(380, 70)
      Me.rdoFalse.Name = "rdoFalse"
      Me.rdoFalse.Size = New System.Drawing.Size(50, 17)
      Me.rdoFalse.TabIndex = 3
      Me.rdoFalse.TabStop = True
      Me.rdoFalse.Text = "False"
      Me.rdoFalse.UseVisualStyleBackColor = True
      '
      'TrueFalse
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.Controls.Add(Me.rdoFalse)
      Me.Controls.Add(Me.rdoTrue)
      Me.Controls.Add(Me.txtQuestion)
      Me.Controls.Add(Me.lblIndex)
      Me.Name = "TrueFalse"
      Me.Size = New System.Drawing.Size(700, 120)
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblIndex As Windows.Forms.Label
   Friend WithEvents txtQuestion As Windows.Forms.TextBox
   Friend WithEvents rdoTrue As Windows.Forms.RadioButton
   Friend WithEvents rdoFalse As Windows.Forms.RadioButton
End Class
