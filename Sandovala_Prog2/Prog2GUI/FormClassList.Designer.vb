<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassList
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
      Me.lblCount = New System.Windows.Forms.Label()
      Me.txtCount = New System.Windows.Forms.TextBox()
      Me.btnDisplay = New System.Windows.Forms.Button()
      Me.btnOk = New System.Windows.Forms.Button()
      Me.lstHouses = New System.Windows.Forms.ListBox()
      Me.SuspendLayout()
      '
      'lblCount
      '
      Me.lblCount.AutoSize = True
      Me.lblCount.Location = New System.Drawing.Point(165, 98)
      Me.lblCount.Name = "lblCount"
      Me.lblCount.Size = New System.Drawing.Size(122, 13)
      Me.lblCount.TabIndex = 0
      Me.lblCount.Text = "Total Number of Houses"
      '
      'txtCount
      '
      Me.txtCount.Location = New System.Drawing.Point(345, 98)
      Me.txtCount.Name = "txtCount"
      Me.txtCount.Size = New System.Drawing.Size(100, 20)
      Me.txtCount.TabIndex = 1
      Me.txtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
      '
      'btnDisplay
      '
      Me.btnDisplay.Location = New System.Drawing.Point(470, 142)
      Me.btnDisplay.Name = "btnDisplay"
      Me.btnDisplay.Size = New System.Drawing.Size(75, 23)
      Me.btnDisplay.TabIndex = 2
      Me.btnDisplay.Text = "&DISPLAY"
      Me.btnDisplay.UseVisualStyleBackColor = True
      '
      'btnOk
      '
      Me.btnOk.Location = New System.Drawing.Point(470, 214)
      Me.btnOk.Name = "btnOk"
      Me.btnOk.Size = New System.Drawing.Size(75, 23)
      Me.btnOk.TabIndex = 3
      Me.btnOk.Text = "&OK"
      Me.btnOk.UseVisualStyleBackColor = True
      '
      'lstHouses
      '
      Me.lstHouses.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
      Me.lstHouses.FormattingEnabled = True
      Me.lstHouses.ItemHeight = 14
      Me.lstHouses.Location = New System.Drawing.Point(168, 142)
      Me.lstHouses.Name = "lstHouses"
      Me.lstHouses.Size = New System.Drawing.Size(277, 88)
      Me.lstHouses.TabIndex = 4
      '
      'FormClassList
      '
      Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
      Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
      Me.ClientSize = New System.Drawing.Size(654, 361)
      Me.Controls.Add(Me.lstHouses)
      Me.Controls.Add(Me.btnOk)
      Me.Controls.Add(Me.btnDisplay)
      Me.Controls.Add(Me.txtCount)
      Me.Controls.Add(Me.lblCount)
      Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
      Me.Name = "FormClassList"
      Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
      Me.Text = "All Houses - Andre Sandoval"
      Me.ResumeLayout(False)
      Me.PerformLayout()

   End Sub

   Friend WithEvents lblCount As Label
   Friend WithEvents txtCount As TextBox
   Friend WithEvents btnDisplay As Button
   Friend WithEvents btnOk As Button
   Friend WithEvents lstHouses As ListBox
End Class
