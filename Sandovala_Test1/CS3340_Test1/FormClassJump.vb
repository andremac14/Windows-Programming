Public Class FormClassJump
   Private WithEvents aButton As Button
   Private xPos As Integer = 100
   Private Const MAX_BUTTON_COUNT As Integer = 4

   Private Const BUTTON_WIDTH As Integer = 85
   Private Const BUTTON_HEIGHT As Integer = 35
   Private Const MAX_BUTTONS As Integer = 3

   Private _mainform As Form
   Private AllButtons As New SortedList(MAX_BUTTONS)

   ' Sets _frmMain to a form object
   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainform = value
      End Set
   End Property

   ' Required Friend sub
   Friend Sub RemoveButton(ByVal theKey As String)
      Dim index As Integer
      index = AllButtons.IndexOfKey(theKey)

      If index = -1 Then
         ' not in the sorted list
         MessageBox.Show("The button doesn't exist!")
      Else
         aButton = AllButtons.GetByIndex(index)

         ' Remove from the form
         Me.Controls.Remove(aButton)
         AllButtons.RemoveAt(index)
         ArrangeButtons()
      End If
   End Sub

   ' Required Friend sub
   Friend Sub CreateButton(ByVal theKey As String, ByVal theCaption As String)
      Static count As Integer
      ' Gets a new button object
      aButton = New Button
      count += 1

      ' Sets the button properties
      aButton.Text = theCaption
      aButton.Tag = theKey
      'setFont(aButton)
      aButton.Location = New System.Drawing.Point(xPos, 50 * count)

      If AllButtons.Count >= MAX_BUTTON_COUNT Then
         MessageBox.Show("There are 4 buttons already!")
      Else
         ' Set the event handler for the object pointed by aButton
         ' Even the object is not pointed by aButton later
         AddHandler aButton.Click, AddressOf ButtonClick

         ' Adds the button to the sorted list
         AllButtons.Add(theKey, aButton)

         ' Puts the button on the form
         Me.Controls.Add(aButton)
         ArrangeButtons()
      End If
   End Sub

   ' Required private sub
   Private Sub ArrangeButtons()

   End Sub

   ' Required event handler
   Private Sub JumpEvent(ByVal sender As System.Object, ByVal e As System.EventArgs)

   End Sub

   Private Sub FormClassJump_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
      ArrangeButtons()
   End Sub

   Private Sub FormClassJump_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
      ArrangeButtons()
   End Sub

   Private Sub FormClassJump_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   End Sub

   Private Sub ButtonClick(ByVal sender As Object,
                            ByVal e As System.EventArgs)
      Dim TheButton As Button

      TheButton = CType(sender, Button)

      MessageBox.Show(TheButton.Tag() & Chr(Keys.LineFeed) & TheButton.Text)
   End Sub

   Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
      End
   End Sub

   Private Sub BackToolStripMenuItem_ActionPerformed(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
      Me.Hide()
      _mainform.Show()
      _mainform.BringToFront()
   End Sub

End Class