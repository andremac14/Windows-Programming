'------------------------------------------------------------------------------------------------------------
' Test 2 of CS 3340
'
' Date: March 5, 2019
'
' Description: FormClassCSSE
'              Complete the class according to the comments.
'
'------------------------------------------------------------------------------------------------------------

Imports UWPCS3340

Public Class FormClassCSSE

   Private WithEvents valCSSE As CSSE
   Private val234 As CSSE
   Private val334 As CSSE
   Private count As Integer = 0
   Public cs As CS234 = New CS234
   Public cs1 As CS334 = New CS334
   ' Adds event handler for the TotalCountUpdated event,
   ' creates one object of CS234 and another object of CS334
   ' check radio button for CS234 
   ' and assign the CS234 object to valCSSE
   Private Sub FormClassCSSE_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      'AddHandler valCSSE.TotalCountUpdated, AddressOf HandleCountUpdatedEvent
      count = count + 2
      lblMsg.Text = "There are " + count.ToString + " total Objects"
      rdo234.Checked = True

      valCSSE = cs

      txtDelta.Text = valCSSE.Delta
      txtScore.Text = valCSSE.Score
   End Sub

   ' Tries to set the delta value of the selected object,
   ' and displays error message using error provider if an exception is thrown.
   ' You CAN ONLY use variable valCSSE and ex for Exception inside the sub.
   Private Sub btnDelta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelta.Click
      Try
         ErrorProvider1.Clear()
         valCSSE.Delta = txtDelta.Text
      Catch
         ErrorProvider1.SetError(txtDelta, "Must input correct delta")
      End Try
   End Sub

   ' Tries to set the score value of the selected object,
   ' and displays error message using error provider if an exception is thrown.
   ' You CAN ONLY use variable valCSSE and ex for Exception inside the sub.
   Private Sub btnScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScore.Click
      Try
         ErrorProvider1.Clear()
         valCSSE.Score = txtScore.Text
      Catch
         ErrorProvider1.SetError(txtDelta, "Must input correct delta")
      End Try
   End Sub

   ' Tries to modify the score value of the selected object,
   ' and displays error message using error provider if an exception is thrown.
   ' You CAN ONLY use variable valCSSE and ex for Exception inside the sub.
   Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
      valCSSE.Modify()
      'If (valCSSE.Score < 50 Or valCSSE.Score > 100) Then
      'ErrorProvider1.SetError(btnModify, "Out of range")
      'Else
      txtDelta.Text = valCSSE.Delta
      txtScore.Text = valCSSE.Score
      'End If

   End Sub

   Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
      valCSSE.Reset()

      txtDelta.Text = valCSSE.Delta
      txtScore.Text = valCSSE.Score
   End Sub

   Private Sub btnUnload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnload.Click
      Me.Dispose()
      Me.Close()
   End Sub

   Private Sub rdo334_CheckedChanged(sender As Object, e As EventArgs) Handles rdo334.CheckedChanged
      valCSSE = cs1

      txtDelta.Text = valCSSE.Delta
      txtScore.Text = valCSSE.Score
   End Sub

   Private Sub rdo234_CheckedChanged(sender As Object, e As EventArgs) Handles rdo234.CheckedChanged
      valCSSE = cs

      txtDelta.Text = valCSSE.Delta
      txtScore.Text = valCSSE.Score
   End Sub

End Class
