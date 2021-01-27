'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormClassHouse
'------------------------------------------------------------------------------------------------------------
Imports UWPCS3340
Public Class FormClassHouse
   Private _frmList As FormClassList 'Object of formClassList
   Private _house As House 'Object of hosue class
   Public HousesArray As List(Of House) = New List(Of House)
   Public roomCount As Integer
   Public garageCount As Integer
   Public HouseIndex As Integer
   Dim value As Boolean = False

   'Constructor
   Public Sub New()
      ' MyBase.New() is called implicitly 
      ' Need to call InitializeComponent defined on FormClassHouse.Designer.vb 
      InitializeComponent()

      _frmList = New FormClassList

      ' Setting value for property MainForm of _frmShow 
      _frmList.MainForm = Me
   End Sub

   'Exits the program
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      End
   End Sub

   'Hides this form and brings up the new form
   Private Sub btnList_Click(sender As Object, e As EventArgs) Handles btnList.Click
      Me.Hide()
      _frmList.Show()
      _frmList.BringToFront()
      _frmList.DisplayList()
   End Sub

   'Displays the correct house after it's created
   Friend Sub DisplayHouse()
      If cobType.Text = "Platteville" Then
         rdoRoomTwo.Checked = True
         rdoGarageOne.Checked = True
         _house = New Platteville(txtID.Text, 2, 1)
         HousesArray.Add(_house)
         txtPrice.Text = FormatCurrency(_house.Price, 0)
      ElseIf cobType.Text = "Madison" Then
         _house = New Madison(txtID.Text, 2, 1)
         rdoRoomTwo.Checked = True
         rdoGarageOne.Checked = True
         txtPrice.Text = FormatCurrency(_house.Price, 0)
      ElseIf cobType.Text = "Chicago" Then
         _house = New Chicago(txtID.Text, 2, 2)
         rdoRoomThree.Checked = True
         rdoGarageTwo.Checked = True
         txtPrice.Text = FormatCurrency(_house.Price, 0)
      End If
   End Sub

   'Makes sure all the correct hings are enables when the form starts up
   Private Sub FormClassHouse_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.ActiveControl = cobType
      btnRooms.Enabled = False
      btnGarages.Enabled = False
      grpRooms.Enabled = False
      grpGarages.Enabled = False

   End Sub

   'Saves the house to the list of houses and displays all the correct info and also makes sure the correct 
   'things are enabled
   Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
      Dim theId As String = txtID.Text.Trim

      If (btnSave.Text = "&SAVE") Then
         If (theId.Length <> 5) Then
            MessageBox.Show("MUST BE 5")
         Else
            DisplayHouse()
            btnRooms.Enabled = True
            btnGarages.Enabled = True
            grpRooms.Enabled = True
            grpGarages.Enabled = True
            cobType.Enabled = False
            txtID.Enabled = False
            btnSave.Text = "NEW"
            _frmList.lstHouses.Items.Add(Me._house.ID & "         " & Me._house.Type & "     " & Me._house.Price)
         End If
      Else
         cobType.Text = ""
         txtID.Clear()
         txtPrice.Clear()
         btnSave.Text = "&SAVE"
         cobType.Enabled = True
         grpRooms.Enabled = False
         btnRooms.Enabled = False
         grpGarages.Enabled = False
         btnGarages.Enabled = False
         txtID.Enabled = True
      End If
   End Sub

   'Sets the roomCount to 2
   Private Sub rdoRoomTwo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRoomTwo.CheckedChanged
      roomCount = 2
   End Sub

   'Sets the roomCount to 3
   Private Sub rdoRoomThree_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRoomThree.CheckedChanged
      roomCount = 3
   End Sub

   'Sets the roomCount to 4
   Private Sub rdoRoomFour_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRoomFour.CheckedChanged
      roomCount = 4

   End Sub

   'Sets the garageCount to 1
   Private Sub rdoGarageOne_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGarageOne.CheckedChanged
      garageCount = 1
   End Sub

   'Sets the garageCount to 2
   Private Sub rdoGarageTwo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGarageTwo.CheckedChanged
      garageCount = 2
   End Sub

   'Sets the garageCount to 3
   Private Sub rdoGarageThree_CheckedChanged(sender As Object, e As EventArgs) Handles rdoGarageThree.CheckedChanged
      garageCount = 3
   End Sub

   'Find the correct instance of the house so that the correct house can be modified 
   Private Sub FindHouse(houseID As String)
      HouseIndex = -1
      For index As Integer = 0 To House.TotalCount - 1
         _house = House.HouseByIndex(index)
         If _house.ID = houseID Then
            HouseIndex = index
         End If
      Next
   End Sub

   'Sets the right number of rooms so that the right price can be set
   Private Sub btnRooms_Click(sender As Object, e As EventArgs) Handles btnRooms.Click
      FindHouse(txtID.Text)
      If HouseIndex >= 0 Then
         _house = House.HouseByIndex(HouseIndex)
      End If

      If (_house.Type = "Platteville") Then
         If (roomCount = 4) Then
            MessageBox.Show("Number of rooms is out of range")
         Else
            _house.Rooms = roomCount
            MessageBox.Show("Price Changed!")
            txtPrice.Text = FormatCurrency(_house.Price, 0)
         End If
      ElseIf (_house.Type = "Chicago") Then
         If (roomCount = 2) Then
            MessageBox.Show("Number of rooms is out of range")
         Else
            _house.Rooms = roomCount
            MessageBox.Show("Price Changed!")
            txtPrice.Text = FormatCurrency(_house.Price, 0)
         End If
      Else
         _house.Rooms = roomCount
         MessageBox.Show("Price Changed!")
         txtPrice.Text = FormatCurrency(_house.Price, 0)
      End If
   End Sub

   'Sets the right number of garages so that the right price can be set
   Private Sub btnGarages_Click(sender As Object, e As EventArgs) Handles btnGarages.Click
      FindHouse(txtID.Text)
      If HouseIndex >= 0 Then
         _house = House.HouseByIndex(HouseIndex)
      End If

      If (_house.Type = "Platteville") Then
         If (garageCount = 3) Then
            MessageBox.Show("Number of garages is out of range!")
         Else
            _house.Garages = garageCount
            MessageBox.Show("Price Changed!")
            txtPrice.Text = FormatCurrency(_house.Price, 0)
         End If
      ElseIf (_house.Type = "Chicago") Then
         If (garageCount = 1) Then
            MessageBox.Show("Number of garages is out of range!")
         Else
            _house.Garages = garageCount
            MessageBox.Show("Price Changed!")
            txtPrice.Text = FormatCurrency(_house.Price, 0)
         End If
      Else
         _house.Garages = garageCount
         MessageBox.Show("Price Changed!")
         txtPrice.Text = FormatCurrency(_house.Price, 0)
      End If
   End Sub
End Class
