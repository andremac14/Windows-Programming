'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date: 2/1/2019
' Description: Program1
'              Class FormClassShow
'------------------------------------------------------------------------------------------------------------

Public Class FormClassShow
   Private _mainForm As Form

   ' Form class data field
   Private WithEvents aButton As Button
   Private xPos As Integer = 100
   Private Const MAX_BUTTON_COUNT As Integer = 4
   Private _allButtons As New SortedList(MAX_BUTTON_COUNT)

   ' Sets _frmMain to a form object
   Public WriteOnly Property MainForm As Form
      Set(ByVal value As Form)
         _mainForm = value
      End Set
   End Property

   ' For event resize
   Private Const BUTTON_HEIGHT As Integer = 23
   Private Const BUTTON_WIDTH As Integer = 75
   Private Const MENU_HEIGHT As Integer = 24
   Private Const MARGIN_SIZE As Integer = 100

   'Exits the program
   Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
      End
   End Sub

   'Goes back to the FormCLassCreate form and hides this from
   Private Sub mnuReturn_Click(sender As Object, e As EventArgs) Handles mnuReturn.Click
      Me.Hide()
      _mainForm.Show()
      _mainForm.BringToFront()
   End Sub

   ' At most MAX_BUTTON_COUNT buttons can be created. If MAX_BUTTON_COUNT buttons have 
   ' been created already, then an exception will be thrown and no button will be added.
   ' If no button in _allButtons has theKey as its key, the method creates a button with theKey 
   ' and theCaption and adds the button to both the form and the sorted list _allButtons.
   ' The Add method of the sorted list will check the uniqueness condition on key and throw an
   ' exception if the condition is violated. The method does not check the condition by itself 
   ' and calls the Add method of the sorted list and lets the caller to handle the exception.
   ' No Try-and-Catch should be used inside the sub.
   Friend Sub addButton(ByVal theKey As String, ByVal theCaption As String)
      Static count As Integer
      ' Gets a new button object
      aButton = New Button
      count += 1

      ' Sets the button properties
      aButton.Text = theCaption
      aButton.Tag = theKey
      setFont(aButton)
      aButton.Location = New System.Drawing.Point(xPos, 50 * count)

      If _allButtons.Count >= MAX_BUTTON_COUNT Then
         MessageBox.Show("There are 4 buttons already!")
      Else
         ' Set the event handler for the object pointed by aButton
         ' Even the object is not pointed by aButton later
         AddHandler aButton.Click, AddressOf ButtonClick

         ' Adds the button to the sorted list
         _allButtons.Add(theKey, aButton)

         ' Puts the button on the form
         Me.Controls.Add(aButton)
         ArrangeButtons()
      End If
   End Sub

   ' If a button in _allButtons has theKey as its key, the method removes the button from both 
   ' the form and the sorted list. Otherwise, it throws an exception.
   ' No Try-and-Catch should be used inside the sub.
   Public Sub removeButton(ByVal theKey As String)
      Dim index As Integer
      index = _allButtons.IndexOfKey(theKey)

      If index = -1 Then
         ' not in the sorted list
         MessageBox.Show("The button doesn't exist!")
      Else
         aButton = _allButtons.GetByIndex(index)

         ' Remove from the form
         Me.Controls.Remove(aButton)
         _allButtons.RemoveAt(index)
         ArrangeButtons()
      End If
   End Sub

   ' Arranges all buttons on the form according to the requirements.
   ' It does not change any thing of any button, except its location on the form.
   ' You cannot use an if  (or select) statement inside the method!
   Private Sub ArrangeButtons()

      Dim temp, index As Integer
      Dim aButton As New Button

      temp = (Me.ClientSize.Width - 2 * MARGIN_SIZE - _allButtons.Count * BUTTON_WIDTH) / (_allButtons.Count + 1)

      For index = 0 To _allButtons.Count - 1
         aButton = CType(_allButtons.GetByIndex(index), Button)

         aButton.Top = MENU_HEIGHT + (Me.ClientSize.Height - MENU_HEIGHT - BUTTON_HEIGHT) / 2

         aButton.Left = MARGIN_SIZE + temp + index * (temp + BUTTON_WIDTH)
      Next

   End Sub

   ' Changes the font of all buttons when a shortcut menu item is clicked.
   ' It also updates the menu item as checked or unchecked.
   ' You cannot use an if  (or select) statement inside the method!
   Private Sub ChangeFont(ByVal f As FontStyle, ByVal m As ToolStripMenuItem)
      Dim b As Button
      m.Checked = Not m.Checked

      For index As Integer = 0 To _allButtons.Count - 1
         b = _allButtons.GetByIndex(index)
         b.Font = New Font(b.Font, b.Font.Style Xor f)
      Next
   End Sub

   ' Sets the font style of button b according to whether the three menu items
   ' are checked or not.
   ' The method should be called after a new button is created.
   Private Sub setFont(ByVal b As Button)
      If (mnuBold.Checked = True) Then
         b.Font = New Font(b.Font, b.Font.Style Xor FontStyle.Bold)
      End If
      If (mnuItalic.Checked = True) Then
         b.Font = New Font(b.Font, b.Font.Style Xor FontStyle.Italic)
      End If
      If (mnuUnderline.Checked = True) Then
         b.Font = New Font(b.Font, b.Font.Style Xor FontStyle.Underline)
      End If
   End Sub

   'Shows a textbox with the proper message when the button is clicked on
   Private Sub ButtonClick(ByVal sender As Object,
                            ByVal e As System.EventArgs)
      Dim TheButton As Button

      TheButton = CType(sender, Button)

      MessageBox.Show(TheButton.Tag() & Chr(Keys.LineFeed) & TheButton.Text)
   End Sub

   'Calls the method to change the font to the style to bold when that option is checked
   Private Sub MnuBoldToolStripMenuItem_ActionPerformed(sender As Object, e As EventArgs) _
                                                       Handles mnuBold.Click
      ChangeFont(FontStyle.Bold, mnuBold)
   End Sub

   'Calls the method to change the font to the style to italic when that option is checked
   Private Sub MnuItalicToolStripMenuItem_ActionPerformed(sender As Object, e As EventArgs) _
                                                         Handles mnuItalic.Click
      ChangeFont(FontStyle.Italic, mnuItalic)
   End Sub

   'Calls the method to change the font to the style to underlined when that option is checked
   Private Sub MnuUnderlineToolStripMenuItem_Click(sender As Object, e As EventArgs) _
                                                  Handles mnuUnderline.Click
      ChangeFont(FontStyle.Underline, mnuUnderline)
   End Sub

   'Calls the sub to arrange the buttons every time the form is resized 
   Private Sub FormClassShow_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
      ArrangeButtons()
   End Sub

   'Calls the sub to arrange the buttons every time the form is avtivated
   Private Sub FormClassShow_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
      ArrangeButtons()
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