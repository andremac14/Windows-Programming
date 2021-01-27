'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormClassList
'------------------------------------------------------------------------------------------------------------
Imports UWPCS3340
Public Class FormClassList
   ' The variable must point to the FormClassHouse object that created this object of FormClassList.
   Private _mainForm As FormClassHouse
   Private tempHouse As House

   'Sets the main form
   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainForm = value
      End Set
   End Property

   'Hides the list and brings up toe formClassHouse
   Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   'Displays the list of houses in the list box
   Friend Sub DisplayList()
      txtCount.Text = House.TotalCount
      lstHouses.Items.Clear()

      For Index As Integer = 0 To House.TotalCount - 1
         tempHouse = House.HouseByIndex(Index)
         lstHouses.Items.Add(tempHouse.ID.ToString.PadRight(15, " ") + tempHouse.Type.ToString.PadRight(15, " ") +
         FormatCurrency(tempHouse.Price.ToString, 0))
      Next
   End Sub

   'Displays the correct button that is clicked on  
   Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
      Try
         tempHouse = House.HouseByIndex(lstHouses.SelectedIndex())

         Me.Hide()
         _mainForm.Show()
         _mainForm.BringToFront()

         _mainForm.txtID.Text = tempHouse.ID
         _mainForm.txtPrice.Text = FormatCurrency(tempHouse.Price, 0)
         _mainForm.cobType.Text = tempHouse.Type
         _mainForm.cobType.Enabled = False
         _mainForm.grpGarages.Enabled = True
         _mainForm.grpRooms.Enabled = True
         _mainForm.btnRooms.Enabled = True
         _mainForm.btnGarages.Enabled = True
         _mainForm.btnSave.Text = "NEW"

         setRadioButtons()
      Catch
         MessageBox.Show("No house selected!")
      End Try
   End Sub

   'Sets the correct radio buttons based on how many rooms there are
   Friend Sub setRadioButtons()
      If tempHouse.Rooms.Equals(2) Then
         _mainForm.rdoRoomTwo.Checked = True
      ElseIf tempHouse.Rooms.Equals(3) Then
         _mainForm.rdoRoomThree.Checked = True
      ElseIf tempHouse.Rooms.Equals(4) Then
         _mainForm.rdoRoomFour.Checked = True
      End If

      If tempHouse.Garages.Equals(1) Then
         _mainForm.rdoGarageOne.Checked = True
      ElseIf tempHouse.Garages.Equals(2) Then
         _mainForm.rdoGarageTwo.Checked = True
      ElseIf tempHouse.Garages.Equals(3) Then
         _mainForm.rdoGarageThree.Checked = True
      End If
   End Sub

   Private Sub lstHouses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstHouses.SelectedIndexChanged

   End Sub
End Class