<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormClassMDI
   Inherits System.Windows.Forms.Form

   'Form overrides dispose to clean up the component list.
   <System.Diagnostics.DebuggerNonUserCode()>
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
   <System.Diagnostics.DebuggerStepThrough()>
   Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormClassMDI))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNew = New System.Windows.Forms.ToolStripButton()
        Me.btnExit = New System.Windows.Forms.ToolStripButton()
        Me.ddbWindows = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArrangeIconToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblUWP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblSpring = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDateTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmrMDI = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNew, Me.btnExit, Me.ddbWindows})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 35)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(63, 32)
        Me.btnNew.Text = "New"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(62, 32)
        Me.btnExit.Text = "EXIT"
        '
        'ddbWindows
        '
        Me.ddbWindows.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.VerticalToolStripMenuItem, Me.HorizontalToolStripMenuItem, Me.ArrangeIconToolStripMenuItem})
        Me.ddbWindows.Image = CType(resources.GetObject("ddbWindows.Image"), System.Drawing.Image)
        Me.ddbWindows.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ddbWindows.Name = "ddbWindows"
        Me.ddbWindows.Size = New System.Drawing.Size(105, 32)
        Me.ddbWindows.Text = "WINDOWS"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.CascadeToolStripMenuItem.Text = "Cascade"
        '
        'VerticalToolStripMenuItem
        '
        Me.VerticalToolStripMenuItem.Name = "VerticalToolStripMenuItem"
        Me.VerticalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.VerticalToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.VerticalToolStripMenuItem.Text = "Vertical"
        '
        'HorizontalToolStripMenuItem
        '
        Me.HorizontalToolStripMenuItem.Name = "HorizontalToolStripMenuItem"
        Me.HorizontalToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
        Me.HorizontalToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.HorizontalToolStripMenuItem.Text = "Horizontal"
        '
        'ArrangeIconToolStripMenuItem
        '
        Me.ArrangeIconToolStripMenuItem.Name = "ArrangeIconToolStripMenuItem"
        Me.ArrangeIconToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ArrangeIconToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ArrangeIconToolStripMenuItem.Text = "ArrangeIcon"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(28, 28)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblUWP, Me.lblSpring, Me.lblDateTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 415)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 35)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblUWP
        '
        Me.lblUWP.Name = "lblUWP"
        Me.lblUWP.Size = New System.Drawing.Size(77, 30)
        Me.lblUWP.Text = "UWP CS 3340"
        '
        'lblSpring
        '
        Me.lblSpring.Name = "lblSpring"
        Me.lblSpring.Size = New System.Drawing.Size(588, 30)
        Me.lblSpring.Spring = True
        '
        'lblDateTime
        '
        Me.lblDateTime.AutoSize = False
        Me.lblDateTime.Name = "lblDateTime"
        Me.lblDateTime.Size = New System.Drawing.Size(120, 30)
        '
        'tmrMDI
        '
        Me.tmrMDI.Enabled = True
        Me.tmrMDI.Interval = 3000
        '
        'FormClassMDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FormClassMDI"
        Me.Text = "Program 3 - Andre Sandoval"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
   Friend WithEvents btnNew As ToolStripButton
   Friend WithEvents btnExit As ToolStripButton
   Friend WithEvents StatusStrip1 As StatusStrip
   Friend WithEvents lblUWP As ToolStripStatusLabel
   Friend WithEvents lblSpring As ToolStripStatusLabel
   Friend WithEvents lblDateTime As ToolStripStatusLabel
   Friend WithEvents tmrMDI As Timer
   Friend WithEvents ddbWindows As ToolStripDropDownButton
   Friend WithEvents CascadeToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents VerticalToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents HorizontalToolStripMenuItem As ToolStripMenuItem
   Friend WithEvents ArrangeIconToolStripMenuItem As ToolStripMenuItem
End Class
