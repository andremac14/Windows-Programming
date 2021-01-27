'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormClassBranch
'------------------------------------------------------------------------------------------------------------
Imports UWPCS3340
Partial Class FormClassBranch
   Inherits UWPCS3340.FormClassHouse

   Private _branchNo As Integer ' Branch number

   Public WriteOnly Property BranchNo As Integer
      Set(value As Integer)
         _branchNo = value
         Me.Text = "Branch #" & _branchNo
         _frmList.Text = "Branch #" & _branchNo
         _frmList.MdiParent = Me.MdiParent
      End Set
   End Property

   'Disposes of the form
   Public Overrides Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Me.Dispose()
      Me.Close()
   End Sub
End Class
