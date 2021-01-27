'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/1/2019
' Description: Program1
'              Class FormClassCreate
'------------------------------------------------------------------------------------------------------------

Partial Class FormClassCreate
   Inherits System.Windows.Forms.Form

   'The maxinum number of characters in the key
   Private Const MAX_KEY_LENGTH As Integer = 6

   ' _frmShow is a data field of the class 
   'Private _frmShow As Form
   Private _frmShow As FormClassShow

   'Constructor
   Public Sub New()
      ' MyBase.New() is called implicitly 
      ' Need to call InitializeComponent defined on FormClassCreate.Designer.vb 
      InitializeComponent()

      _frmShow = New FormClassShow

      ' Setting value for property MainForm of _frmShow 
      _frmShow.MainForm = Me
   End Sub

   ' Hides the FormClassCreate form the displays the FormClassShow form
   Private Sub mnuShow_Click(sender As Object, e As EventArgs) Handles mnuShow.Click
      Me.Hide()
      _frmShow.Show()
      _frmShow.BringToFront()
   End Sub

   'Closes the program
   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      End
   End Sub

   'Creates a new button and adds it to the form while making sure a key is typed in
   'and that there's no duplicate keys 
   Private Sub mnuCreate_KeyPressed(sender As Object, e As EventArgs) Handles mnuCreate.Click
      Dim theCaption As String
      Dim theKey As String

      theCaption = txtCaption.Text.Trim()
      theKey = txtKey.Text.Trim()

      ' Checking input to make sure it isnt blank
      If theKey = "" Then
         MessageBox.Show("A key is required!")
      Else
         Try
            _frmShow.addButton(theKey, theCaption)
         Catch ex As Exception
            MessageBox.Show("Duplicate Key!")
         End Try
      End If
   End Sub

   'Private method that is used to remove buttons from the form and throws an exception if
   'there are no buttons
   Private Sub mnuRemove_KeyPressed(sender As Object, e As EventArgs) Handles mnuRemove.Click
      Try
         _frmShow.removeButton(txtKey.Text)
      Catch ex As Exception
         MessageBox.Show("No buttons")
      End Try
   End Sub

   'Sets the active control to the Key textbox when the form starts up
   Private Sub FormClassCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      Me.ActiveControl = txtKey
   End Sub

   'This sub makes sure the Key doesnt start with a digit, makes sure the button text doesnt have 
   'any spaces in it and also makes sure the key deosnt have more than 6 characters
   Private Sub txtKey_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) _
                              Handles txtKey.KeyPress
      If e.KeyChar <> Chr(Keys.Back) Then
         If txtKey.TextLength = 0 Then
            If IsNumeric(e.KeyChar) Then
               MessageBox.Show("Key cannot start with a digit!")
               e.Handled = True
            End If
         End If

         If e.KeyChar = Chr(Keys.Space) Then
            MessageBox.Show("Key cannot have a space!")
            e.Handled = True
         End If

         If txtKey.TextLength >= MAX_KEY_LENGTH Then
            MessageBox.Show("Key can have at most 6 characters!")
            e.Handled = True
         End If
      End If
   End Sub

   'Makes sure that pressing Alt+F4 will not close the form. 
   Private Sub Form1_FormClosing(ByVal sender As System.Object,
                                ByVal e As System.Windows.Forms.FormClosingEventArgs) _
                                Handles MyBase.FormClosing
      If (e.CloseReason = CloseReason.UserClosing) Then
         e.Cancel = True
      End If
   End Sub

End Class
