'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormIndividualClass
'------------------------------------------------------------------------------------------------------------

Public Class FormIndividualClass

   Private _mainForm As FormAllClass

   'Sets the main form to FormAllClass
   Public WriteOnly Property MainForm As FormAllClass
      Set(ByVal value As FormAllClass)
         _mainForm = value
      End Set
   End Property

   'Saves the item to the database record when the save button is clicked
   Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeeBindingNavigatorSaveItem.Click
      Try
         Me.Validate()
         Me.EmployeeBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)

         BindingNavigatorAddNewItem.Enabled = True
         btnReload.Enabled = True
         BindingNavigatorMoveFirstItem.Enabled = True
         EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem

      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   'Loads upo the correct record in the textboxes
   Private Sub FormIndividualClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         EmployeeTableAdapter.Connection.ConnectionString = _mainForm.connString

         'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

   End Sub

   'Exits the application
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   'Hides this form and shows the main form and brings the main form to front
   Private Sub btnAllEmployees_Click(sender As Object, e As EventArgs) Handles btnAllEmployees.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   'Reloads the dataset with the updated values
   Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
      Try
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   'Adds a new item to the database
   Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click
      BindingNavigatorAddNewItem.Enabled = False
      btnReload.Enabled = False
      BindingNavigatorMoveFirstItem.Enabled = False
      BindingNavigatorMoveLastItem.Enabled = False
      BindingNavigatorMoveNextItem.Enabled = False
      EmployeeBindingNavigator.MoveFirstItem = Nothing
      btnReload.Enabled = False
      btnAllEmployees.Enabled = False
      btnExit.Enabled = False

   End Sub

   'Deletes a record from the database and enables all the correct buttons
   Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
      BindingNavigatorAddNewItem.Enabled = True
      btnReload.Enabled = True
      BindingNavigatorMoveFirstItem.Enabled = True
      btnReload.Enabled = True
      btnAllEmployees.Enabled = True
      btnExit.Enabled = True

      EmployeeBindingNavigator.MoveFirstItem = BindingNavigatorMoveFirstItem
   End Sub
End Class