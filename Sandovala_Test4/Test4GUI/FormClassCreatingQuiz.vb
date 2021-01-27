Public Class FormClassCreatingQuiz
   Private _mainForm As Form
   Private _theQuestion As IQuestions
   Private heightUpdated As Boolean = False
   Private initialHeight As Integer = 240

   Public WriteOnly Property HeightReseting As Boolean
      Set(value As Boolean)
         If value Then
            heightUpdated = Not value
            Me.Height = initialHeight
         End If
      End Set
   End Property
   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainForm = value
      End Set
   End Property

   Private Sub FormClassCreatingQuiz_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
      If _theQuestion IsNot Nothing Then
         If (rdoMultipleChoice.Checked = False And rdoTrueFalse.Checked = False) Then
            rdoTrueFalse.Checked = True
         End If
      End If
   End Sub

   Public Sub QuestionRemove()
      If (_theQuestion IsNot Nothing) Then
         _theQuestion.RemoveFromForm(Me)
         _theQuestion = Nothing
      End If
   End Sub

   Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
      If (Test4.allQuestions.Count = 5) Then
         MsgBox("There are five questions already.")
      Else
         If (_theQuestion IsNot Nothing) Then
            _theQuestion.RemoveFromForm(Me)
         End If
         If (rdoMultipleChoice.Checked) Then
            _theQuestion = New MultiChoice
         Else
            _theQuestion = New TrueFalse
         End If

         Dim initHeight = Me.Height
         If Not heightUpdated Then
            Me.Height += New MultiChoice().Height
            heightUpdated = True
         End If

         Test4.allQuestions.Add(_theQuestion)

         _theQuestion.Index = Test4.allQuestions.IndexOf(_theQuestion) + 1
         _theQuestion.DisplayOnForm(New Point(50, 180), Me, IQuestions.QuestionMode.Creating)

         enableButtons()
         buttonStatusCheck()
      End If
   End Sub

   Private Sub enableButtons()
      btnNew.Enabled = Not btnNew.Enabled
      btnPrevious.Enabled = Not btnPrevious.Enabled
      If (Test4.allQuestions.Count = 5) Then
         btnNext.Enabled = False
      Else
         btnNext.Enabled = Not btnNext.Enabled
      End If
      btnBack.Enabled = Not btnBack.Enabled
      rdoMultipleChoice.Enabled = Not rdoMultipleChoice.Enabled
      rdoTrueFalse.Enabled = Not rdoTrueFalse.Enabled
   End Sub

   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      If _theQuestion IsNot Nothing Then
         Try
            _theQuestion.Save()
            enableButtons()
            buttonStatusCheck()
         Catch ex As Exception
            MsgBox(ex.Message)
         End Try
      End If
   End Sub

   Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
      If _theQuestion IsNot Nothing Then
         _theQuestion.RemoveFromForm(Me)
         If (Test4.allQuestions.Count = 1) Then
            Me.Height -= New MultiChoice().Height
            Test4.allQuestions.Remove(_theQuestion)
            heightUpdated = False
         ElseIf (Test4.allQuestions.Count > 0) Then
            Test4.allQuestions.Remove(_theQuestion)
            _theQuestion = Test4.allQuestions(_theQuestion.Index - 2)
            _theQuestion.DisplayOnForm(New Point(50, 180), Me, IQuestions.QuestionMode.Creating)
         End If
         Dim indexNum = 1
         For Each qst As IQuestions In Test4.allQuestions
            qst.Index = indexNum
            indexNum += 1
         Next
         btnBack.Enabled = True
         btnNew.Enabled = True
         buttonStatusCheck()
      End If
   End Sub

   Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
      If (Test4.allQuestions.Count > 0) Then

         _theQuestion.RemoveFromForm(Me)
         _theQuestion = Test4.allQuestions(_theQuestion.Index - 2)
         _theQuestion.DisplayOnForm(New Point(50, 180), Me, IQuestions.QuestionMode.Creating)
         buttonStatusCheck()
      End If
   End Sub

   Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
      If (Test4.allQuestions.Count > 0) Then

         _theQuestion.RemoveFromForm(Me)
         _theQuestion = Test4.allQuestions(_theQuestion.Index)
         _theQuestion.DisplayOnForm(New Point(50, 180), Me, IQuestions.QuestionMode.Creating)
         buttonStatusCheck()
      End If
   End Sub

   Private Sub buttonStatusCheck()
      If (Test4.allQuestions.IndexOf(_theQuestion) < 1) Then
         btnPrevious.Enabled = False
      Else
         btnPrevious.Enabled = True
      End If

      If (Test4.allQuestions.IndexOf(_theQuestion) >= Test4.allQuestions.Count - 1 Or
         Test4.allQuestions.IndexOf(_theQuestion) < 0) Then
         btnNext.Enabled = False
      Else
         btnNext.Enabled = True
      End If
   End Sub

   Private Sub FormClassCreatingQuiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      buttonStatusCheck()
   End Sub
End Class