'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormClassHouse
'------------------------------------------------------------------------------------------------------------

Imports UWPCS3340
Public Class FormClassHouse

   'Dim WithEvents h As UWPCS3340.House
   Protected _frmList As FormClassList
   Protected myHouse As House

   Public Sub New()
      ' This call is required by the designer.
      InitializeComponent()

      cobType.SelectedIndex = -1
      btnModify.Enabled = False
      grpGarages.Enabled = False
      grpRooms.Enabled = False
      txtID.Focus()
      ' Add any initialization after the InitializeComponent() call.
      _frmList = New FormClassList
      _frmList.MainForm = Me

      AddHandler House.HouseListUpdated, AddressOf HandleListUpdatedEvent
   End Sub

   Private Sub HandleListUpdatedEvent()
      Dim _ID As String = txtID.Text.Trim
      Dim price As String = txtPrice.Text.Trim

      If _ID = "" Or price = "" Then
         Exit Sub
      End If

      Dim aHouse As House

      For i As Integer = 0 To House.TotalCount - 1
         aHouse = House.HouseByIndex(i)

         If _ID = aHouse.ID Then
            myHouse = aHouse

            If price <> FormatCurrency(aHouse.Price, 0) Then
               MessageBox.Show("Price Changed!")
            End If

            DisplayHouse(myHouse)
            Exit Sub
         End If
      Next

      Reset()
   End Sub

   Private Sub reset()
      txtID.ReadOnly = False
      txtID.Text = ""
      cobType.SelectedIndex = -1
      cobType.Enabled = True
      txtPrice.Text = ""
      btnSave.Text = "&SAVE"
      btnModify.Enabled = False
      grpGarages.Enabled = False
      grpRooms.Enabled = False
      cobType.Focus()
   End Sub

   ''Displays a message if the price is changed
   'Private Sub HandlePriceChangeEvent() Handles h.PriceChanged
   '   MessageBox.Show("Price Changed!")
   '   txtPrice.Text = FormatCurrency(h.Price, 0)
   'End Sub

   'Handles the form closing 
   Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If
   End Sub

   'Enables the correct things when the form loads up 
   Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

      cobType.SelectedIndex = -1
      btnModify.Enabled = False
      grpGarages.Enabled = False
      grpRooms.Enabled = False
      txtID.Focus()
   End Sub

   'Saves the house to the list of houses and displays all the correct info and also makes sure the correct 
   'things are enabled
   Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
      If btnSave.Text.Contains("SAVE") Then

         ErrorProvider1.Clear()

         If cobType.SelectedIndex = -1 Then
            ' MessageBox.Show("Select house type please!")
            ErrorProvider1.SetError(cobType, "Must select type")
         Else
            Try
               If cobType.SelectedIndex = 0 Then
                  myHouse = New Chicago(txtID.Text)
               ElseIf cobType.SelectedIndex = 1 Then
                  myHouse = New Madison(txtID.Text)
               Else
                  myHouse = New Platteville(txtID.Text)
               End If

               SetControls()

            Catch ex As Exception
               ' MessageBox.Show(ex.Message)
               If ex.Message.Contains("unique") Then
                  ErrorProvider1.SetError(txtID, "ID Must be unique")
               ElseIf ex.Message.Contains("five") Then
                  ErrorProvider1.SetError(txtID, "ID Must have five chars")

               Else

               End If
            End Try
         End If

      Else
         txtID.ReadOnly = False
         txtID.Text = ""
         cobType.SelectedIndex = -1
         cobType.Enabled = True
         txtPrice.Text = ""
         btnSave.Text = "&SAVE"
         btnModify.Enabled = False
         grpGarages.Enabled = False
         grpRooms.Enabled = False
         cobType.Focus()

      End If

   End Sub

   'Sets the right number of rooms so that the right price can be set
   Private Sub setRooms(ByVal h As House)
      If h.Rooms = 2 Then
         rdoRoom2.Checked = True
      ElseIf h.Rooms = 3 Then
         rdoRoom3.Checked = True
      Else
         rdoRoom4.Checked = True
      End If
   End Sub

   'Sets the right number of garages so that the right price can be set
   Private Sub setGarages(ByVal h As House)
      If h.Garages = 1 Then
         rdoGarage1.Checked = True
      ElseIf h.Garages = 2 Then
         rdoGarage2.Checked = True
      Else
         rdoGarage3.Checked = True
      End If
   End Sub

   'Exits the program
   Public Overridable Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   'Changes the rooms and garages 
   Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
      Try
         myHouse.Modify(getRooms, getGarages)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   'Gets the room number based on what option is checked
   Private Function getRooms() As Integer
      Dim rooms As Integer

      If rdoRoom2.Checked Then
         rooms = 2
      ElseIf rdoRoom3.Checked Then
         rooms = 3
      Else
         rooms = 4
      End If

      Return rooms
   End Function

   'Gets the garage number based on what option is checked
   Private Function getGarages() As Integer
      Dim garages As Integer

      If rdoGarage1.Checked Then
         garages = 1
      ElseIf rdoGarage2.Checked Then
         garages = 2
      Else
         garages = 3
      End If

      Return garages
   End Function

   'Sets the correct garages and rooms based on which city the house is located
   Public Sub DisplayHouse(ByVal aHouse As House)
      myHouse = aHouse

      txtID.Text = myHouse.ID
      If myHouse.Type = "Chicago" Then
         cobType.SelectedIndex = 0
      ElseIf myHouse.Type = "Madison" Then
         cobType.SelectedIndex = 1
      Else
         cobType.SelectedIndex = 2
      End If

      SetControls()

   End Sub

   'Makes sure all the correct controls are set in the from
   Private Sub SetControls()
      setRooms(myHouse)
      setGarages(myHouse)
      txtPrice.Text = FormatCurrency(myHouse.Price, 0)

      cobType.Enabled = False
      txtID.ReadOnly = True
      btnSave.Text = "&NEW"
      btnModify.Enabled = True
      grpGarages.Enabled = True
      grpRooms.Enabled = True
   End Sub

   'Hides this form and brings up the formClassList
   Private Sub btnList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnList.Click
      Me.Hide()
      _frmList.Show()
      _frmList.BringToFront()
   End Sub
End Class
