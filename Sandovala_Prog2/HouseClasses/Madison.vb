'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class Madison
'------------------------------------------------------------------------------------------------------------

Public Class Madison
   Inherits House

   'Constructor
   Public Sub New(ByVal ID As String, ByVal aRooms As Integer, ByVal aGarage As Integer)
      MyBase.New(aRooms, aGarage)
      _Type = "Madison"
      _ID = ID
      _Price = 300000
   End Sub

   ' Calculates the price based on the number of rooms and number of garages.
   ' Event PriceChanged will be raised if the new calculated price is different 
   ' from the old price.
   ' It will be called after setting rooms and garages.
   Protected Overrides Sub setPrice()
      Dim initialPrice As Integer
      Dim totalPrice As Integer

      initialPrice = Me.Price
      totalPrice = 300000

      If Me.Rooms = 3 Then
         totalPrice = totalPrice + 10000
      End If
      If Me.Rooms = 4 Then
         totalPrice = totalPrice + 20000
      End If

      If Me.Garages = 2 Then
         totalPrice = totalPrice + 5000
      End If
      If Me.Garages = 3 Then
         totalPrice = totalPrice + 10000
      End If

      If totalPrice <> initialPrice Then
         Me._Price = totalPrice
         Me.raisePrice()
      End If
   End Sub

End Class
