'-------------------------------------------------'------------------------------------------------------------------------------------------------------------
' Test 2 of CS 3340
'
' Date: March 5, 2019
'
' Description: Class CSSE
'              Complete the class according to the comments.
'
'------------------------------------------------------------------------------------------------------------

Public MustInherit Class CSSE

   ' The class does not store all created objects,
   ' but keeps such a count and updates it whenever an object is created or disposed of.
   Private Shared TotalCount As Integer = 0

   Protected _score As Integer
   Protected SCORE_LOW_LIMIT As Integer
   Protected SCORE_HIGH_LIMIT As Integer

   Protected _delta As Integer
   Protected DELTA_LOW_LIMIT As Integer
   Protected DELTA_HIGH_LIMIT As Integer

   ' Raised when an object is created or disposed of.
   ' The parameter is the updated TotalCount.
   Public Shared Event TotalCountUpdated(ByVal num As Integer)

   ' Raised when _score equals SCORE_HIGH_LIMIT,
   ' either by property Score or by method Modify.
   Public Event PerfectScore()

   ' Reads and writes _score.
   ' Throws an exception when the new score would be out of the range.
   Public Property Score As Integer
      Get
         Return _score
      End Get
      Set(ByVal value As Integer)

      End Set
   End Property

   ' Reads and writes _delta.
   ' Throws an exception when the new delta would be out of the range.
   Public Property Delta As Integer
      Get
         Return _delta
      End Get
      Set(ByVal value As Integer)

      End Set
   End Property

   ' Sets _score and _delta to their low limits.
   Public Sub Reset()
      _score = SCORE_LOW_LIMIT
      _delta = DELTA_LOW_LIMIT
   End Sub

   ' Modifies _score using _delta. 
   ' The Sub-classes decide how to modify it.
   ' Throws an exception when the new score would be out of range. 
   Public MustOverride Sub Modify()

End Class
