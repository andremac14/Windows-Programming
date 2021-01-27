'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormClassMDI
'------------------------------------------------------------------------------------------------------------

Imports UWPCS3340
Public Class FormClassMDI
   Private branchNum As Integer

   'Creates a new instance of formClassHouse
   Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      Dim f As FormClassBranch = New FormClassBranch

      f.MdiParent = Me

      branchNum += 1
      f.BranchNo = branchNum

      f.Show()

   End Sub

   'Terminates the program
   Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   'Sets the layout making the windows cascade
   Private Sub CascadeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CascadeToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.Cascade)
   End Sub

   'Sets the layout vertical
   Private Sub VerticalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerticalToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.TileVertical)
   End Sub

   'Sets the layout horizontal 
   Private Sub HorizontalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HorizontalToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.TileHorizontal)
   End Sub

   'Sets the layout by arranging the icons
   Private Sub ArrangeIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArrangeIconToolStripMenuItem.Click
      Me.LayoutMdi(MdiLayout.ArrangeIcons)
   End Sub

   'Loads all the correct things when loading the form
   Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
      lblDateTime.Text = Now

      Dim f As FormClassHouse = New FormClassHouse

      f.MdiParent = Me

      f.Show()
   End Sub

   'Updates the date and time of the program
   Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmrMDI.Tick
      lblDateTime.Text = Now
   End Sub
End Class
