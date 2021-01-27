'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormClassList
'------------------------------------------------------------------------------------------------------------

Imports System.Windows.Forms
Imports UWPCS3340

Public Class FormClassList
    Private _mainForm As FormClassHouse

   Public WriteOnly Property MainForm As FormClassHouse
      Set(ByVal value As FormClassHouse)
         _mainForm = value
      End Set
   End Property

   'Makes sure the correct house is displayed in the formClassList
   Private Sub FormClassList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
      Dim numHouses As Integer = House.TotalCount

      txtCount.Text = numHouses

      lstHouses.Items.Clear()

      For index = 0 To numHouses - 1
         Dim h As House = House.HouseByIndex(index)
         lstHouses.Items.Add(h.ID.PadRight(8) & h.Type.PadLeft(12) & FormatCurrency(h.Price, 0).PadLeft(13))

      Next
   End Sub

   'Hides this form and goes back to formClassHouse
   Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   'Displays the selected house 
   Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
      If lstHouses.SelectedIndex = -1 Then
         MessageBox.Show("Select a house in the list!")
      Else
         _mainForm.DisplayHouse(House.HouseByIndex(lstHouses.SelectedIndex))
         Me.Hide()
         _mainForm.Show()
         _mainForm.BringToFront()
      End If
   End Sub

   'Handles the form closing
   Private Sub FormClassList_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
      If e.CloseReason = CloseReason.UserClosing Then
         e.Cancel = True
      End If
   End Sub

   'Refreshes the list after a record is updated 
   Private Sub refreshList()
      Dim numHouses As Integer = House.TotalCount
      For index = 0 To numHouses - 1
         Dim h As House = House.HouseByIndex(index)
         lstHouses.Items.Add(h.ID.PadRight(8) & h.Type.PadLeft(12) & FormatCurrency(h.Price, 0).PadLeft(13))
      Next
   End Sub

   'Removes the record from the list
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
      Try
         Dim h As IDisposable = House.HouseByIndex(lstHouses.SelectedIndex)

         h.Dispose()

         'lstHouses.Items.Clear()
         'txtCount.Text = House.TotalCount
         'refreshList()
      Catch ex As Exception
         MessageBox.Show("Select a house in the list!")
      End Try
   End Sub

   Private Sub FormClassList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      AddHandler House.HouseListUpdated, AddressOf HandleListUpdatedEvent
   End Sub

   Private Sub HandleListUpdatedEvent()
      Dim numHouse As Integer = House.TotalCount
      lstHouses.Items.Clear()

      For index = 0 To numHouse - 1
         Dim h As House = House.HouseByIndex(index)
         lstHouses.Items.Add(h.ID.PadRight(8) & h.Type.PadLeft(12) & FormatCurrency(h.Price, 0).PadLeft(13))
      Next
   End Sub
End Class