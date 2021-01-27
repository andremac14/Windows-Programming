'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program5
'              Class ReaderWriter
'------------------------------------------------------------------------------------------------------------

Imports System.Threading
Imports UWPCS3340

Public Class ReaderWriterForm

   Private rw As ReaderWriterClasses.ReaderWriter
   Private db As DatabaseClass

   Private dummyThread As Thread
   Private variableDelegate As enableButtons
   Private totalBalance As Integer = 1000
   Private Delegate Sub enableButtons()

   'Exits the from and displays a textbox befreo you exit 
   Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      dummyThread = New Thread(AddressOf ExitApplication)

      dummyThread.Start()

      btnExit.Enabled = False
      btnReader.Enabled = False
      btnWriter.Enabled = False

   End Sub

   'To wait for all worker threads to finish
   'Then exit application if the user answers Yes
   Sub ExitApplication()
      ' Thread dummyThread waiting here for all worker threads to finish
      ReaderWriterClasses.ReaderWriter.FinishReadWrite()

      Dim result As Microsoft.VisualBasic.MsgBoxResult
      result = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
      If result = MsgBoxResult.Yes Then
         Application.Exit()
      Else
         Me.Invoke(variableDelegate)
      End If
   End Sub

   'Creates a new reader and shows it in the textbox 
   Private Sub btnReader_Click(sender As Object, e As EventArgs) Handles btnReader.Click
      rw = New ReaderWriterClasses.Reader
      rw.DisplayMsg = New ReaderWriterClasses.ReaderWriter.PassMessage(AddressOf delegateSub)
      rw.MainForm = Me
      rw.SpinUp()

   End Sub

   'Creates a new writer and shows it in the textbox 
   Private Sub btnWriter_Click(sender As Object, e As EventArgs) Handles btnWriter.Click
      rw = New ReaderWriterClasses.Writer
      rw.MainForm = Me
      rw.DisplayMsg = New ReaderWriterClasses.ReaderWriter.PassMessage(AddressOf delegateSub)
      rw.SpinUp()
   End Sub

   'Loads everything correctly when the form loads
   Private Sub ReaderWriterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      db = New DatabaseClass(1000)
      ReaderWriterClasses.ReaderWriter.TheDatabase = db
      txtTotal.Text = totalBalance
      variableDelegate = New ReaderWriterForm.enableButtons(AddressOf subToEnableButtons)

   End Sub

   'Enables all buttons 
   Private Sub subToEnableButtons()
      btnExit.Enabled = True
      btnReader.Enabled = True
      btnWriter.Enabled = True
   End Sub

   'Displays the correct messages when you create readers and writers
   Private Sub delegateSub(ByVal id As String, ByVal state As ReaderWriterClasses.ReaderWriter.State, ByVal total As Integer)
      If state = rw.State.Waiting Then
         lstWaiting.Items.Add(id)
      ElseIf state = rw.State.Working Then
         If lstWaiting.Items.Contains(id) Then
            lstWaiting.Items.Remove(id)
         End If
         lstWorking.Items.Add(id)
         txtLog.Text &= id & " : Start to work: Total is " & total.ToString & vbCrLf
      Else
         If lstWorking.Items.Contains(id) Then
            lstWaiting.Items.Remove(id)
         End If

         If lstWaiting.Items.Contains(id) Then
            lstWaiting.Items.Remove(id)
         End If
         txtLog.Text &= id & " : Finished working: Total is " & total.ToString & vbCrLf
      End If

      txtTotal.Text = total
      txtLog.SelectionStart = txtLog.TextLength
      txtLog.ScrollToCaret()
   End Sub

End Class
