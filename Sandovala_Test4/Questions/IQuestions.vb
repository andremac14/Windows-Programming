Imports System.Drawing
Imports System.Windows.Forms

Public Interface IQuestions

   Enum QuestionMode
      Creating
      Taking
   End Enum

   ' The Get method returns the text of lblIndex without the dot at the end.
   ' The Set method set the text of lblIndex to an integer 
   '     provided by the Value parameter followed by a dot.
   Property Index() As Integer

   ' Returns the height of the control.
   ReadOnly Property height() As Integer

   ' Checks the following conditions: 
   '     lblIndex.Text is a positive integer 
   '     txtQuestion.Text is not an empty string after trimimg spaces from both ends
   '     one of the two radio buttons is checked.
   ' Throws an exception if any of the conditions is violated.
   ' Otherwise, it will save the checked radio button as the answer key.
   Sub Save()

   Sub DisplayOnForm(ByVal Pos As Point, ByVal theForm As Form, ByVal theMode As QuestionMode)

   Sub RemoveFromForm(ByVal theForm As Form)

   ' Returns one if the checked radio button matches the answer key,
   ' and zero otherwise.
   Function Score() As Integer
End Interface
