'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class Chicago, Madison, and Platteville 
'------------------------------------------------------------------------------------------------------------
Public Class Chicago
   Inherits House

    Public Sub New(ByVal theID As String)
      MyBase.New(theID)

      _type = "Chicago"

      _MaxRooms = 4
      _MinRooms = 3
      _MaxGarages = 3
      _MinGarages = 2

      _basePrice = 400000
      _extraRoomPrice = 20000
      _extraGaragePrice = 8000

      _rooms = _MinRooms
      _garages = _MinGarages
        _price = _basePrice

        RaiseEventUpdated()
    End Sub

   'Sets the correct price based on rooms and garages
   Protected Overrides Sub setPrice()
      Dim p As Single = _price

      _price = _basePrice + (Rooms - _MinRooms) * _extraRoomPrice + (Garages - _MinGarages) * _extraGaragePrice

      If Rooms = 3 And Garages = 3 Then
         _price += 2000
      End If

      'If p <> _price Then
      '   SubToRaiseEvent()
      'End If
   End Sub
End Class

' The Madison subclass that sets the baseline price and the correct number of rooms and garages
Public Class Madison
    Inherits House

    Public Sub New(ByVal theID As String)
        MyBase.New(theID)

        _type = "Madison"

        _MaxRooms = 4
        _MinRooms = 2
        _MaxGarages = 3
        _MinGarages = 1

        _basePrice = 300000
        _extraRoomPrice = 10000
        _extraGaragePrice = 5000

        _rooms = _MinRooms
        _garages = _MinGarages
        _price = _basePrice

        RaiseEventUpdated()
    End Sub
End Class

' The Platteville subclass that sets the baseline price and the correct number of rooms and garages
Public Class Platteville
    Inherits House

    Public Sub New(ByVal theID As String)
        MyBase.New(theID)

        _type = "Platteville"

        _MaxRooms = 3
        _MinRooms = 2
        _MaxGarages = 2
        _MinGarages = 1

        _basePrice = 200000
        _extraRoomPrice = 8000
        _extraGaragePrice = 2500

        _rooms = _MinRooms
        _garages = _MinGarages
        _price = _basePrice

        RaiseEventUpdated()
    End Sub
End Class
