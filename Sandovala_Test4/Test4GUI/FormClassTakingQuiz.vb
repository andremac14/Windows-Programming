Public Class FormClassTakingQuiz
   Private _mainform As Form
   Private score As Integer
   Private initialHeight As Integer = 200

   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainform = value
      End Set
   End Property

   Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
      score = 0
      For Each qst As IQuestions In Test4.allQuestions
         score += qst.Score
      Next

      lblQuiz.Text = "Your Score is: " + score.ToString
   End Sub

   Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      For Each qst As IQuestions In Test4.allQuestions
         qst.RemoveFromForm(Me)
      Next
      Me.Hide()
      _mainform.Show()
      _mainform.BringToFront()
   End Sub

   Private Sub FormClassTakingQuiz_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
      lblQuiz.Text = "Thanks for Taking the Quiz!"
      Dim temp = 0
      Dim lastPos = 0
      Dim currentHeight = initialHeight
      For Each qst As IQuestions In Test4.allQuestions
         qst.DisplayOnForm(New Point(50, 100 + lastPos), Me, IQuestions.QuestionMode.Taking)
         temp += 1
         currentHeight += qst.height
         lastPos += qst.height
      Next
      Me.Height = currentHeight + btnSubmit.Height

      If Test4.allQuestions.Count > 0 Then
         Dim qst As IQuestions = Test4.allQuestions(0)
         btnSubmit.Top = lastPos + 100
         btnBack.Top = btnSubmit.Top
         btnSubmit.BringToFront()
         btnSubmit.Show()
         btnBack.Show()



      End If
      Me.StartPosition = FormStartPosition.CenterScreen
   End Sub
End Class