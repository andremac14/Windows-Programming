Public Class FormClassButton
   Private _frmJump As FormClassJump


   'Constructor
   Public Sub New()
      ' MyBase.New() is called implicitly 
      ' Need to call InitializeComponent defined on FormClassCreate.Designer.vb 
      InitializeComponent()

      _frmJump = New FormClassJump

      ' Setting value for property MainForm of _frmShow 
      _frmJump.MainForm = Me
   End Sub


   Private Sub FormClassButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub mnuSwitch_Click(sender As Object, e As EventArgs) Handles mnuSwitch.Click
      Me.Hide()
      _frmJump.Show()
      _frmJump.BringToFront()
   End Sub

   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      End
   End Sub

   Private Sub mnuCreate_Click(sender As Object, e As EventArgs) Handles mnuCreate.Click
      Dim theCaption As String
      Dim theKey As String

      theCaption = txtCaption.Text.Trim()
      theKey = txtKey.Text.Trim()

      ' Checking input to make sure it isnt blank
      If theKey = "" Then
         MessageBox.Show("A key is required!")
      Else
         Try
            _frmJump.CreateButton(theKey, theCaption)
         Catch ex As Exception
            MessageBox.Show("Duplicate Key!")
         End Try
      End If
   End Sub

   Private Sub mnuRemove_Click(sender As Object, e As EventArgs) Handles mnuRemove.Click
      Try
         _frmJump.RemoveButton(txtKey.Text)
      Catch ex As Exception
         MessageBox.Show("No buttons")
      End Try
   End Sub
End Class
