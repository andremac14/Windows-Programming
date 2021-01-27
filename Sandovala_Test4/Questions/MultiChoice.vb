Imports System.Drawing
Imports System.Windows.Forms
Imports UWPCS3340

Public Class MultiChoice
   Implements IQuestions

   Private _key As Integer
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

      If RadioButton1.Checked = False And RadioButton2.Checked = False And RadioButton3.Checked = False And RadioButton4.Checked = False Then
         Throw New Exception("Question #" + lblIndex.Text.TrimEnd(".") + ": No key is selected.")
         Exit Sub
      End If

      If RadioButton1.Checked Then
         _key = 1
      ElseIf RadioButton2.Checked Then
         _key = 2
      ElseIf RadioButton3.Checked Then
         _key = 3
      ElseIf RadioButton4.Checked Then
         _key = 4
      End If
   End Sub


   Public Function Score() As Integer Implements IQuestions.Score
      If RadioButton1.Checked And _key = 1 Then
         Return 1
      ElseIf RadioButton2.Checked And _key = 2 Then
         Return 1
      ElseIf RadioButton3.Checked And _key = 3 Then
         Return 1
      ElseIf RadioButton4.Checked And _key = 4 Then
         Return 1
      Else
         Return 0
      End If
   End Function

   Sub setRdoButtons()
      If _key = 1 Then
         RadioButton1.Checked = True
         RadioButton2.Checked = False
         RadioButton3.Checked = False
         RadioButton4.Checked = False

      ElseIf _key = 2 Then
         RadioButton1.Checked = False
         RadioButton2.Checked = True
         RadioButton3.Checked = False
         RadioButton4.Checked = False

      ElseIf _key = 3 Then
         RadioButton1.Checked = False
         RadioButton2.Checked = False
         RadioButton3.Checked = True
         RadioButton4.Checked = False

      ElseIf _key = 4 Then
         RadioButton1.Checked = False
         RadioButton2.Checked = False
         RadioButton3.Checked = False
         RadioButton4.Checked = True
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
      RadioButton1.Checked = False
      RadioButton2.Checked = False
      RadioButton3.Checked = False
      RadioButton4.Checked = False

      If theMode = IQuestions.QuestionMode.Taking Then

         txtQuestion.ReadOnly = True
         txtQuestion.BackColor = Color.White

      ElseIf theMode = IQuestions.QuestionMode.Creating Then

         txtQuestion.ReadOnly = False
         txtQuestion.BackColor = Color.White

         setRdoButtons()
      End If
   End Sub

   Public Sub RemoveFromForm(theForm As Form) Implements IQuestions.RemoveFromForm
      theForm.Controls.Remove(Me)
   End Sub
End Class
