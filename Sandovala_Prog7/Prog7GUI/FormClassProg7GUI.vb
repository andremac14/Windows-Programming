'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  5/1/2019
' Description: Program7
'              Class Prog7
'------------------------------------------------------------------------------------------------------------

Public Class FormClassProg7GUI
   Private myDatabase As DataClass
   Private frmOrder As UWPCS3340.FormClassOrder
   Private frmEmployee As UWPCS3340.FormClassGrid
   Private frmProduct As New UWPCS3340.FormClassGrid
   Private frmCustomer As New UWPCS3340.FormClassGrid

   'Exits the program 
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Application.Exit()
   End Sub

   'Loads the correct table for which button is pressed
   Private Sub FormClassProg7GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      myDatabase = New DataClass

      DataClass.setUpTable()

      frmEmployee = New UWPCS3340.FormClassGrid
      frmEmployee.MainForm = Me
      frmEmployee.TheAdapter = DataClass.employeeAdapter
      frmEmployee.TheTable = DataClass.employeeTbl
      frmEmployee.Text = "Employees - Andre Sandoval"

      frmProduct.MainForm = Me
      frmProduct.TheAdapter = DataClass.productAdapter
      frmProduct.TheTable = DataClass.productTbl
      frmProduct.Text = "Products - Andre Sandoval"

      frmCustomer.MainForm = Me
      frmCustomer.TheAdapter = DataClass.customerAdapter
      frmCustomer.TheTable = DataClass.customerTbl
      frmCustomer.Text = "Customers - Andre Sandoval"

      frmOrder = New FormClassOrder
      frmOrder.MainForm = Me
   End Sub

   'Closes the current form and opens the Employee table form 
   Private Sub btnEmployees_Click(sender As Object, e As EventArgs) Handles btnEmployees.Click
      Me.Hide()
      frmEmployee.Show()
      frmEmployee.BringToFront()
   End Sub

   'Closes the current form and opens the Product table form 
   Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
      Me.Hide()
      frmProduct.Show()
      frmProduct.BringToFront()
   End Sub

   Private Sub btnLocation_Click(sender As Object, e As EventArgs) Handles btnLocation.Click
      MessageBox.Show(DataClass.dbLocation)
   End Sub

   'Closes the current form and opens the customer form 
   Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
      Me.Hide()
      frmCustomer.Show()
      frmCustomer.BringToFront()
   End Sub

   'Closes the current form and opens the order form
   Private Sub btnOrders_Click(sender As Object, e As EventArgs) Handles btnOrders.Click
      Me.Hide()
      frmOrder.Show()
      frmOrder.BringToFront()
   End Sub
End Class
