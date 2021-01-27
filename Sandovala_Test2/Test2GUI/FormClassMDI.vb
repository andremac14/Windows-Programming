'------------------------------------------------------------------------------------------------------------
' Test 2 of CS 3340
'
' Date: March 5, 2019
'
' Description: FormClassMDI
'
'------------------------------------------------------------------------------------------------------------
Imports UWPCS3340
Public Class FormClassMDI

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Application.Exit()
    End Sub

   Private Sub FormClassMDI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

      Dim f As FormClassCSSE = New FormClassCSSE

      f.MdiParent = Me

      f.Show()
   End Sub

   Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
      Dim f As FormClassCSSE = New FormClassCSSE

      f.MdiParent = Me

      f.Show()

   End Sub
End Class
