<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassShow
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
        Me.components = New System.ComponentModel.Container()
        Me.mspMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.ctmFont = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuBold = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuItalic = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuUnderline = New System.Windows.Forms.ToolStripMenuItem()
        Me.mspMain.SuspendLayout()
        Me.ctmFont.SuspendLayout()
        Me.SuspendLayout()
        '
        'mspMain
        '
        Me.mspMain.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.mspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile})
        Me.mspMain.Location = New System.Drawing.Point(0, 0)
        Me.mspMain.Name = "mspMain"
        Me.mspMain.Size = New System.Drawing.Size(634, 24)
        Me.mspMain.TabIndex = 0
        Me.mspMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReturn, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuReturn
        '
        Me.mnuReturn.Name = "mnuReturn"
        Me.mnuReturn.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuReturn.Size = New System.Drawing.Size(159, 22)
        Me.mnuReturn.Text = "&RETURN"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(156, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(159, 22)
        Me.mnuExit.Text = "&EXIT"
        '
        'ctmFont
        '
        Me.ctmFont.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ctmFont.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBold, Me.mnuItalic, Me.mnuUnderline})
        Me.ctmFont.Name = "ctmFont"
        Me.ctmFont.Size = New System.Drawing.Size(195, 70)
        '
        'mnuBold
        '
        Me.mnuBold.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuBold.Name = "mnuBold"
        Me.mnuBold.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.mnuBold.Size = New System.Drawing.Size(194, 22)
        Me.mnuBold.Text = "Font Bold"
        '
        'mnuItalic
        '
        Me.mnuItalic.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuItalic.Name = "mnuItalic"
        Me.mnuItalic.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.mnuItalic.Size = New System.Drawing.Size(194, 22)
        Me.mnuItalic.Text = "Font Italic"
        '
        'mnuUnderline
        '
        Me.mnuUnderline.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuUnderline.Name = "mnuUnderline"
        Me.mnuUnderline.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.mnuUnderline.Size = New System.Drawing.Size(194, 22)
        Me.mnuUnderline.Text = "Font Underline"
        '
        'FormClassShow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 321)
        Me.ContextMenuStrip = Me.ctmFont
        Me.ControlBox = False
        Me.Controls.Add(Me.mspMain)
        Me.MainMenuStrip = Me.mspMain
        Me.MinimumSize = New System.Drawing.Size(575, 100)
        Me.Name = "FormClassShow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loading Controls Dynamically - Andre Sandoval"
        Me.mspMain.ResumeLayout(False)
        Me.mspMain.PerformLayout()
        Me.ctmFont.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mspMain As MenuStrip
   Friend WithEvents mnuFile As ToolStripMenuItem
   Friend WithEvents mnuReturn As ToolStripMenuItem
   Friend WithEvents mnuExit As ToolStripMenuItem
   Friend WithEvents ctmFont As ContextMenuStrip
   Friend WithEvents mnuBold As ToolStripMenuItem
   Friend WithEvents mnuItalic As ToolStripMenuItem
   Friend WithEvents mnuUnderline As ToolStripMenuItem
   Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
End Class
