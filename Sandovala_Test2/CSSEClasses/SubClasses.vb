'------------------------------------------------------------------------------------------------------------
' Test 2 of CS 3340
'
' Date: March 5, 2019
'
' Description: Subclasses of CSSE
'              Complete the subclass according to the comments.
'
'------------------------------------------------------------------------------------------------------------

Public Class CS234
   Inherits CSSE

   ' Specifies the ranges and sets both _score and _delta to the low limit.
   ' It also increment TotalCount and raise event TotalCountUpdated.
   Public Sub New()
      SCORE_LOW_LIMIT = 50
      DELTA_LOW_LIMIT = -5
      _score = SCORE_LOW_LIMIT
      _delta = DELTA_LOW_LIMIT
   End Sub

   ' Modifies _score by adding _delta to _score.
   ' Throws an exception when the new score would be out of range. 
   ' Raise event PerfectScore when the score is perfect.
   Public Overrides Sub Modify()
      Try
         _score = _score + _delta
      Catch

      End Try
   End Sub
End Class

Public Class CS334
   Inherits CSSE

   ' Specifies the ranges and sets both _score and _delta to the low limit.
   ' It also increment TotalCount and raise event TotalCountUpdated.
   Public Sub New()
      SCORE_LOW_LIMIT = 60
      DELTA_LOW_LIMIT = 1
      _score = SCORE_LOW_LIMIT
      _delta = DELTA_LOW_LIMIT
   End Sub

   ' Modifies _score by adding twice the value of _delta to _score.
   ' Throws an exception when the new score would be out of range. 
   ' Raise event PerfectScore when the score is perfect.
   Public Overrides Sub Modify()
      _score = _score + (_delta * 2)
   End Sub
End Class
