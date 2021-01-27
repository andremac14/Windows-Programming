'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class House
'------------------------------------------------------------------------------------------------------------

Public MustInherit Class House

    Implements IDisposable

    Private Shared AllHouses As List(Of House) = New List(Of House)
    'Private Shared _totalCount As Integer

    Protected _type As String
    Protected _ID As String
    Protected _rooms As Integer
    Protected _garages As Integer
    Protected _price As Single

    Protected _MaxRooms As Integer
    Protected _MinRooms As Integer
    Protected _MaxGarages As Integer
    Protected _MinGarages As Integer

    Protected _basePrice As Single
    Protected _extraRoomPrice As Integer
    Protected _extraGaragePrice As Integer

    Public Shared Event HouseListUpdated()

    'Makes sure the id has the correct qualifications
    Protected Sub New(ByVal theID As String)
        For index = 0 To AllHouses.Count - 1
            If AllHouses(index)._ID = theID Then
                Throw New Exception("ID must be unique!")
            End If
        Next

        If theID.Length <> 5 Then
            Throw New Exception("ID must have exactly five characters!")
        Else
            For index = 0 To 4
                Dim idChar = theID(index)
                If Not Char.IsLetterOrDigit(idChar) Then
                    Throw New Exception("Each character of ID must be a digit or letter!")
                End If
            Next
        End If

        _ID = theID
        AllHouses.Add(Me)

    End Sub

   Protected Sub RaiseEventUpdated()

   End Sub

   ' Returns the house type
   Public ReadOnly Property Type As String
      Get
         Return _type
      End Get
   End Property

   ' Returns the house ID
   Public ReadOnly Property ID As String
      Get
         Return _ID
      End Get
   End Property

   ' Returns the number of rooms
   Public ReadOnly Property Rooms As Integer
      Get
         Return _rooms
      End Get
   End Property

   ' Returns the number of garages in a house
   Public ReadOnly Property Garages As Integer
      Get
         Return _garages
      End Get
   End Property

   'Returns the house price 
   Public ReadOnly Property Price As Single
      Get
         Return _price
      End Get
   End Property

   'Modifys the amount of rooms and garages 
   Public Sub Modify(ByVal numRooms As Integer, ByVal numGarages As Integer)
      Dim invalid As Boolean = False
      Dim msg As String
      Dim r, g As Integer

      If numRooms < _MinRooms Or numRooms > _MaxRooms Then
         msg = "Number of rooms is out of range!" & vbCrLf 'Chr(Keys.lineffed)
         invalid = True
      Else
         msg = ""
      End If

      If numGarages < _MinGarages Or numGarages > _MaxGarages Then
         msg &= "Number of garages is out of range!"
         invalid = True
      End If

      If invalid Then
         Throw New Exception(msg)
      Else
         g = _garages
         r = _rooms
         _garages = numGarages
         _rooms = numRooms
         setPrice()

         If (g <> _garages Or r <> _rooms) Then
            RaiseEvent HouseListUpdated()
         End If
      End If
   End Sub

   'Sets the price based on the garageCount and the roomCount
   Protected Overridable Sub setPrice()
      Dim p As Single = _price

      _price = _basePrice + (Rooms - _MinRooms) * _extraRoomPrice + (Garages - _MinGarages) * _extraGaragePrice

   End Sub

   'Returns the count of all houses
   Public Shared ReadOnly Property TotalCount As Integer
      Get
         Return AllHouses.Count
      End Get
   End Property

   'Returns the houses
   Public Shared Function HouseByIndex(ByVal index As Integer) As House
      Return AllHouses(index)
   End Function

#Region "IDisposable Support"
   Private disposedValue As Boolean ' To detect redundant calls

   ' IDisposable
   Protected Overridable Sub Dispose(disposing As Boolean)
      If Not disposedValue Then
         If disposing Then
            ' TODO: dispose managed state (managed objects).
            AllHouses.Remove(Me)
            RaiseEvent HouseListUpdated()

         End If

         ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
         ' TODO: set large fields to null.
      End If
      disposedValue = True
   End Sub

   ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
   Protected Overrides Sub Finalize()
      ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
      Dispose(False)
      MyBase.Finalize()
   End Sub

   ' This code added by Visual Basic to correctly implement the disposable pattern.
   Private Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
      ' TODO: uncomment the following line if Finalize() is overridden above.
      GC.SuppressFinalize(Me)
   End Sub
#End Region
End Class
