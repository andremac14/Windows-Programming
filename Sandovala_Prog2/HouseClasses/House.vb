'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class House
'------------------------------------------------------------------------------------------------------------

Public Class House
   Private Shared AllHouses As List(Of House) = New List(Of House)

   Protected _Price As Single
   Protected _Garages As Integer
   Protected _Rooms As Integer
   Protected _ID As String
   Protected _Type As String


   ' Returns the total count of created house objects.
   Public Shared ReadOnly Property TotalCount As Integer
      Get
         Return AllHouses.Count
      End Get
   End Property

   ' Returns the house at the specified index. 
   Public Shared ReadOnly Property HouseByIndex(ByVal index As Integer) As House
      Get
         Return AllHouses(index)
      End Get
   End Property

   'Constructor
   Public Sub New(ByVal aRooms As Integer, ByVal aGarage As Integer)
      Rooms = aRooms
      Garages = aGarage
      AllHouses.Add(Me)
   End Sub

   ' Returns the house type
   Public ReadOnly Property Type As String
      Get
         Return _Type
      End Get
   End Property

   ' Returns the house Id
   Public ReadOnly Property ID As String
      Get
         Return _ID
      End Get
   End Property

   ' Returns the number of rooms in a house
   Public Property Rooms As Integer
      Get
         Return _Rooms
      End Get
      Set(value As Integer)
         If value > 0 Then
            _Rooms = value
            setPrice()
         Else
            Throw New Exception("Please enter rooms")
         End If
      End Set
   End Property

   ' Returns the number of garages in a house
   Public Property Garages As Integer
      Get
         Return _Garages
      End Get
      Set(value As Integer)
         If value > 0 Then
            _Garages = value
            setPrice()
         Else
            Throw New Exception("Please enter garages")
         End If
      End Set
   End Property

   ' Returns the house price
   Public ReadOnly Property Price As Single
      Get
         Return _Price
      End Get
   End Property

   ' Calculates the price based on the number of rooms and number of garages.
   ' Event PriceChanged will be raised if the new calculated price is different 
   ' from the old price.
   ' It will be called after setting rooms and garages.
   Protected Overridable Sub setPrice()

   End Sub

   ' Raised when the price of the house changed.
   Public Event PriceChanged(Price As Integer)

   'Allows subclasses to change the price
   Protected Sub raisePrice()
      RaiseEvent PriceChanged(Me._Price)
   End Sub

End Class
