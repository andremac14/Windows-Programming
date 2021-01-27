<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassCreate
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
        Me.mspMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuShow = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuRemove = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtCaption = New System.Windows.Forms.TextBox()
        Me.txtKey = New System.Windows.Forms.TextBox()
        Me.lblCaption = New System.Windows.Forms.Label()
        Me.lblKey = New System.Windows.Forms.Label()
        Me.mspMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mspMain
        '
        Me.mspMain.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.mspMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuButton})
        Me.mspMain.Location = New System.Drawing.Point(0, 0)
        Me.mspMain.Name = "mspMain"
        Me.mspMain.Size = New System.Drawing.Size(500, 24)
        Me.mspMain.TabIndex = 0
        Me.mspMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuShow, Me.ToolStripMenuItem1, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuShow
        '
        Me.mnuShow.Name = "mnuShow"
        Me.mnuShow.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.mnuShow.Size = New System.Drawing.Size(149, 22)
        Me.mnuShow.Text = "&SHOW"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(146, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.mnuExit.Size = New System.Drawing.Size(149, 22)
        Me.mnuExit.Text = "E&XIT"
        '
        'mnuButton
        '
        Me.mnuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCreate, Me.ToolStripMenuItem2, Me.mnuRemove})
        Me.mnuButton.Name = "mnuButton"
        Me.mnuButton.Size = New System.Drawing.Size(55, 20)
        Me.mnuButton.Text = "Button"
        '
        'mnuCreate
        '
        Me.mnuCreate.Name = "mnuCreate"
        Me.mnuCreate.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.mnuCreate.Size = New System.Drawing.Size(161, 22)
        Me.mnuCreate.Text = "&CREATE"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(158, 6)
        '
        'mnuRemove
        '
        Me.mnuRemove.Name = "mnuRemove"
        Me.mnuRemove.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.mnuRemove.Size = New System.Drawing.Size(161, 22)
        Me.mnuRemove.Text = "&REMOVE"
        '
        'txtCaption
        '
        Me.txtCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCaption.Location = New System.Drawing.Point(156, 161)
        Me.txtCaption.Name = "txtCaption"
        Me.txtCaption.Size = New System.Drawing.Size(74, 20)
        Me.txtCaption.TabIndex = 1
        Me.txtCaption.Text = "The Caption"
        '
        'txtKey
        '
        Me.txtKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtKey.Location = New System.Drawing.Point(270, 161)
        Me.txtKey.MaxLength = 7
        Me.txtKey.Name = "txtKey"
        Me.txtKey.Size = New System.Drawing.Size(74, 20)
        Me.txtKey.TabIndex = 2
        Me.txtKey.Text = "TheKey"
        '
        'lblCaption
        '
        Me.lblCaption.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCaption.AutoSize = True
        Me.lblCaption.Location = New System.Drawing.Point(153, 136)
        Me.lblCaption.Name = "lblCaption"
        Me.lblCaption.Size = New System.Drawing.Size(77, 13)
        Me.lblCaption.TabIndex = 3
        Me.lblCaption.Text = "Button Caption"
        '
        'lblKey
        '
        Me.lblKey.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblKey.AutoSize = True
        Me.lblKey.Location = New System.Drawing.Point(276, 136)
        Me.lblKey.Name = "lblKey"
        Me.lblKey.Size = New System.Drawing.Size(59, 13)
        Me.lblKey.TabIndex = 4
        Me.lblKey.Text = "Button Key"
        '
        'FormClassCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 317)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblKey)
        Me.Controls.Add(Me.lblCaption)
        Me.Controls.Add(Me.txtKey)
        Me.Controls.Add(Me.txtCaption)
        Me.Controls.Add(Me.mspMain)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Location = New System.Drawing.Point(130, 136)
        Me.MainMenuStrip = Me.mspMain
        Me.Name = "FormClassCreate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program 1 - Andre Sandoval"
        Me.mspMain.ResumeLayout(False)
        Me.mspMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mspMain As MenuStrip
   Friend WithEvents mnuFile As ToolStripMenuItem
   Friend WithEvents mnuButton As ToolStripMenuItem
   Friend WithEvents mnuShow As ToolStripMenuItem
   Friend WithEvents mnuExit As ToolStripMenuItem
   Friend WithEvents mnuCreate As ToolStripMenuItem
   Friend WithEvents mnuRemove As ToolStripMenuItem
   Friend WithEvents txtCaption As TextBox
   Friend WithEvents txtKey As TextBox
   Friend WithEvents lblCaption As Label
   Friend WithEvents lblKey As Label
   Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
   Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
End Class
