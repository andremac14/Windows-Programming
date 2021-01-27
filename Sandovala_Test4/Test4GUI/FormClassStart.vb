Public Class FormClassStart
   Private _frmCreatingQuiz As FormClassCreatingQuiz
   Private _frmTakingQuiz As FormClassTakingQuiz

   Private Sub FormClassStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      _frmCreatingQuiz = New FormClassCreatingQuiz
      _frmTakingQuiz = New FormClassTakingQuiz

      _frmCreatingQuiz.MainForm = Me
      _frmTakingQuiz.MainForm = Me
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      End
   End Sub

   Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
      _frmCreatingQuiz.QuestionRemove()
      Test4.allQuestions.Clear()

      Me.Hide()
      _frmCreatingQuiz.Show()
      _frmCreatingQuiz.BringToFront()
   End Sub

   Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
      Me.Hide()
      _frmCreatingQuiz.Show()
      _frmCreatingQuiz.BringToFront()
   End Sub

   Private Sub btnTake_Click(sender As Object, e As EventArgs) Handles btnTake.Click
      Me.Hide()
      _frmTakingQuiz.Show()
      _frmTakingQuiz.BringToFront()
   End Sub

   Private Sub FormClassStart_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
      If (Test4.allQuestions.Count = 0) Then
         btnEdit.Enabled = False
         btnTake.Enabled = False
      Else
         btnEdit.Enabled = True
         btnTake.Enabled = True
      End If
   End Sub
End Class
