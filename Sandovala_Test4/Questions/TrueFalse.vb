Imports System.Drawing
Imports System.Windows.Forms
Imports UWPCS3340

Public Class TrueFalse
   Implements IQuestions

   Const TrueFalseWidth As Integer = 700
   Const TrueFalseHeight As Integer = 120

   Private _key As Boolean
   Private _index As Integer
   Private _mode As QuestionMode

   Public Enum QuestionMode
      Creating
      Taking
   End Enum

   Public Property Index As Integer Implements IQuestions.Index
      Get
         Return _index
      End Get
      Set(value As Integer)
         _index = value
         lblIndex.Text = value.ToString + "."
      End Set
   End Property

   Private ReadOnly Property IQuestions_height As Integer Implements IQuestions.height
      Get
         Return Me.Height
      End Get
   End Property

   Public Sub Save() Implements IQuestions.Save
      If CType(lblIndex.Text, Integer) < 0 Then
         Throw New Exception("Question #" + lblIndex.Text.TrimEnd(".") + "Enter a question!")
         Exit Sub
      End If

      If txtQuestion.Text.Trim(" ") = "" Then
         Throw New Exception("Question #" + lblIndex.Text.TrimEnd(".") + ": No question is entered.")
         Exit Sub
      End If

      If rdoFalse.Checked = False And rdoTrue.Checked = False Then
         Throw New Exception("Question #" + lblIndex.Text.TrimEnd(".") + ": No key is selected.")
         Exit Sub
      End If

      If rdoFalse.Checked Then
         _key = False
      Else
         _key = True
      End If
   End Sub

   Public Sub DisplayOnForm(Pos As Point, theForm As Form, theMode As IQuestions.QuestionMode) Implements IQuestions.DisplayOnForm
      Me.Location = New Point(Pos)
      theForm.Controls.Add(Me)
      Me._mode = theMode
      Me.Show()
      Me.BringToFront()
      Me.Enabled = True
      Me.Visible = True



      If theMode = IQuestions.QuestionMode.Taking Then

         rdoFalse.Checked = False
         rdoTrue.Checked = False

         txtQuestion.ReadOnly = True
         txtQuestion.BackColor = Color.White

      ElseIf theMode = IQuestions.QuestionMode.Creating Then
         rdoFalse.Checked = False
         rdoTrue.Checked = False

         txtQuestion.ReadOnly = False
         txtQuestion.BackColor = Color.White
            checkKey()

        End If
   End Sub

   Public Sub RemoveFromForm(theForm As Form) Implements IQuestions.RemoveFromForm
      theForm.Controls.Remove(Me)
   End Sub

   Public Function Score() As Integer Implements IQuestions.Score
      If rdoTrue.Checked And _key = True Then
         Return 1
      ElseIf rdoFalse.Checked And _key = False Then
         Return 1
      Else
         Return 0
      End If
   End Function

    Sub checkKey()
        If _key Then
            rdoTrue.Checked = True
            rdoFalse.Checked = False

        ElseIf _key = False Then
            rdoTrue.Checked = False
            rdoFalse.Checked = True

        End If
    End Sub


End Class
