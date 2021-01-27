<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassCreatingQuiz
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
      Me.rdoTrueFalse = New System.Windows.Forms.RadioButton()
      Me.rdoMultipleChoice = New System.Windows.Forms.RadioButton()
      Me.btnBack = New System.Windows.Forms.Button()
      Me.btnNew = New System.Windows.Forms.Button()
      Me.btnSave = New System.Windows.Forms.Button()
      Me.btnRemove = New System.Windows.Forms.Button()
      Me.btnPrevious = New System.Windows.Forms.Button()
      Me.btnNext = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'rdoTrueFalse
      '
      Me.rdoTrueFalse.AutoSize = True
      Me.rdoTrueFalse.Location = New System.Drawing.Point(258, 75)
      Me.rdoTrueFalse.Name = "rdoTrueFalse"
      Me.rdoTrueFalse.Size = New System.Drawing.Size(72, 17)
      Me.rdoTrueFalse.TabIndex = 0
      Me.rdoTrueFalse.TabStop = True
      Me.rdoTrueFalse.Text = "TrueFalse"
      Me.rdoTrueFalse.UseVisualStyleBackColor = True
      '
      'rdoMultipleChoice
      '
      Me.rdoMultipleChoice.AutoSize = True
      Me.rdoMultipleChoice.Location = New System.Drawing.Point(453, 75)
      Me.rdoMultipleChoice.Name = "rdoMultipleChoice"
      Me.rdoMultipleChoice.Size = New System.Drawing.Size(80, 17)
      Me.rdoMultipleChoice.TabIndex = 1
      Me.rdoMultipleChoice.TabStop = True
      Me.rdoMultipleChoice.Text = "MultiChoice"
      Me.rdoMultipleChoice.UseVisualStyleBackColor = True
      '
      'btnBack
      '
      Me.btnBack.Location = New System.Drawing.Point(177, 23)
      Me.btnBack.Name = "btnBack"
      Me.btnBack.Size = New System.Drawing.Size(75, 23)
      Me.btnBack.TabIndex = 2
      Me.btnBack.Text = "BACK"
      Me.btnBack.UseVisualStyleBackColor = True
      '
      'btnNew
      '
      Me.btnNew.Location = New System.Drawing.Point(302, 23)
      Me.btnNew.Name = "btnNew"
      Me.btnNew.Size = New System.Drawing.Size(75, 23)
      Me.btnNew.TabIndex = 3
      Me.btnNew.Text = "NEW"
      Me.btnNew.UseVisualStyleBackColor = True
      '
      'btnSave
      '
      Me.btnSave.Location = New System.Drawing.Point(423, 23)
      Me.btnSave.Name = "btnSave"
      Me.btnSave.Size = New System.Drawing.Size(75, 23)
      Me.btnSave.TabIndex = 4
      Me.btnSave.Text = "SAVE"
      Me.btnSave.UseVisualStyleBackColor = True
      '
      'btnRemove
      '
      Me.btnRemove.Location = New System.Drawing.Point(552, 23)
      Me.btnRemove.Name = "btnRemove"
      Me.btnRemove.Size = New System.Drawing.Size(75, 23)
      Me.btnRemove.TabIndex = 5
      Me.btnRemove.Text = "REMOVE"
      Me.btnRemove.UseVisualStyleBackColor = True
      '
      'btnPrevious
      '
      Me.btnPrevious.Location = New System.Drawing.Point(251, 114)
      Me.btnPrevious.Name = "btnPrevious"
      Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
      Me.btnPrevious.TabIndex = 6
      Me.btnPrevious.Text = "PREVIOUS"
      Me.btnPrevious.UseVisualStyleBackColor = True
      '
      'btnNext
      '
      Me.btnNext.Location = New System.Drawing.Point(478, 114)
      Me.btnNext.Name = "btnNext"
      Me.btnNext.Size = New System.Drawing.Size(75, 23)
      Me.btnNext.TabIndex = 7
      Me.btnNext.Text = "NEXT"
      Me.btnNext.UseVisualStyleBackColor = True
      '
      'FormClassCreatingQuiz
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(804, 201)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnNext)
      Me.Controls.Add(Me.btnPrevious)
      Me.Controls.Add(Me.btnRemove)
      Me.Controls.Add(Me.btnSave)
      Me.Controls.Add(Me.btnNew)
      Me.Controls.Add(Me.btnBack)
      Me.Controls.Add(Me.rdoMultipleChoice)
      Me.Controls.Add(Me.rdoTrueFalse)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Name = "FormClassCreatingQuiz"
      Me.Text = "Creating a Quiz - Andre Sandoval"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents rdoTrueFalse As RadioButton
   Friend WithEvents rdoMultipleChoice As RadioButton
   Friend WithEvents btnBack As Button
   Friend WithEvents btnNew As Button
   Friend WithEvents btnSave As Button
   Friend WithEvents btnRemove As Button
   Friend WithEvents btnPrevious As Button
   Friend WithEvents btnNext As Button
End Class
