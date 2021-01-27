<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassTakingQuiz
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
      Me.lblQuiz = New System.Windows.Forms.Label()
      Me.btnSubmit = New System.Windows.Forms.Button()
      Me.btnBack = New System.Windows.Forms.Button()
      Me.SuspendLayout()
      '
      'lblQuiz
      '
      Me.lblQuiz.AutoSize = True
      Me.lblQuiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lblQuiz.Location = New System.Drawing.Point(264, 50)
      Me.lblQuiz.Name = "lblQuiz"
      Me.lblQuiz.Size = New System.Drawing.Size(57, 20)
      Me.lblQuiz.TabIndex = 0
      Me.lblQuiz.Text = "Label1"
      '
      'btnSubmit
      '
      Me.btnSubmit.Location = New System.Drawing.Point(238, 105)
      Me.btnSubmit.Name = "btnSubmit"
      Me.btnSubmit.Size = New System.Drawing.Size(75, 23)
      Me.btnSubmit.TabIndex = 1
      Me.btnSubmit.Text = "SUBMIT"
      Me.btnSubmit.UseVisualStyleBackColor = True
      '
      'btnBack
      '
      Me.btnBack.Location = New System.Drawing.Point(468, 105)
      Me.btnBack.Name = "btnBack"
      Me.btnBack.Size = New System.Drawing.Size(75, 23)
      Me.btnBack.TabIndex = 2
      Me.btnBack.Text = "BACK"
      Me.btnBack.UseVisualStyleBackColor = True
      '
      'FormClassTakingQuiz
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(780, 157)
      Me.ControlBox = False
      Me.Controls.Add(Me.btnBack)
      Me.Controls.Add(Me.btnSubmit)
      Me.Controls.Add(Me.lblQuiz)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
      Me.Name = "FormClassTakingQuiz"
      Me.Text = "Taking a Quiz - Andre Sandoval"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblQuiz As Label
   Friend WithEvents btnSubmit As Button
   Friend WithEvents btnBack As Button
End Class
