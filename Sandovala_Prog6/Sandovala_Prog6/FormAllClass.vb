'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program2
'              Class FormAllClass
'------------------------------------------------------------------------------------------------------------

Imports Microsoft.Win32

Public Class FormAllClass

   Private _frmIndividual As FormIndividualClass

   Friend dbkey As Microsoft.Win32.RegistryKey
   Dim dblocation As String
   Friend connString As String

   'Saves new items to the database
   Private Sub EmployeeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
      Try
         Me.Validate()
         Me.EmployeeBindingSource.EndEdit()
         Me.TableAdapterManager.UpdateAll(Me.ActivityDataSet)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   'Loads the database from the correct location and if the database is not found then it prompts you with a message 
   'box to select the access database file
   Private Sub FormAllClass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Try
         dblocation = "D:\Activity.accdb"
         connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
         connString &= dblocation

         EmployeeTableAdapter.Connection.ConnectionString = connString

         'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)

      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try

      Try
         'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
         dblocation = EmployeeTableAdapter.Connection.DataSource
      Catch ex As Exception
         Dim openDB As New OpenFileDialog
         openDB.ShowDialog()

         dblocation = openDB.FileName
         connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
         connString &= dblocation

         EmployeeTableAdapter.Connection.ConnectionString = connString
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      End Try

      Dim connected As Boolean = False

      While Not connected
         Try
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
            connected = True
         Catch ex As Exception
            Dim openDB As New OpenFileDialog
            If openDB.ShowDialog() = DialogResult.OK Then
               dblocation = openDB.FileName
               connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
               connString &= dblocation
               EmployeeTableAdapter.Connection.ConnectionString = connString
            Else
               Exit While
            End If
         End Try
      End While

      If Not connected Then
         MessageBox.Show("No database selected!")
         Application.Exit()
      End If

      'Dim connected As Boolean = False

      While Not connected
         Try
            dbkey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("Software\UWPCS3340Prog6")
            dblocation = dbkey.GetValue("Software\UWPCS3340Prog6", "")
            connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & dblocation

            EmployeeTableAdapter.Connection.ConnectionString = connString

            'TODO: This line of code loads data into the 'ActivityDataSet.Employee' table. You can move, or remove it, as needed.
            Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
            connected = True

         Catch ex As Exception
            connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="

            Dim openDB As New OpenFileDialog
            If openDB.ShowDialog() = DialogResult.OK Then
               dblocation = openDB.FileName
               connString &= dblocation
               dbkey.SetValue("Software\UWPCS3340Prog6", dblocation, RegistryValueKind.String)
            Else
               Exit While
            End If
         End Try
      End While

      If Not connected Then
         MsgBox("No database selected!")
         Application.Exit()
      End If

      _frmIndividual = New FormIndividualClass
      _frmIndividual.MainForm = Me
   End Sub

   Private Sub EmployeeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAll.CellContentClick

   End Sub

   'Exits the program
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   'SHows the directory location of the database
   Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
      MessageBox.Show(EmployeeTableAdapter.Connection.DataSource)
   End Sub

   'Reloads and updates the database total
   Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click
      Try
         Me.EmployeeTableAdapter.Fill(Me.ActivityDataSet.Employee)
      Catch ex As Exception
         MessageBox.Show(ex.Message)
      End Try
   End Sub

   'Loads the FormIndividialClass and hides this form 
   Private Sub btnIndividual_Click(sender As Object, e As EventArgs) Handles btnIndividual.Click
      Me.Hide()
      _frmIndividual.Show()
      _frmIndividual.BringToFront()
   End Sub
End Class
