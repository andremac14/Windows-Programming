'------------------------------------------------------------------------------------------------------------
' Name: Andre Sandoval
' Date:  2/18/2019
' Description: Program3
'              Class FormClassThread
'------------------------------------------------------------------------------------------------------------

Imports System.Threading
Imports UWPCS3340

Public Class FormClassThread

   Private totalBalance As Integer = 1000
   Private totalTransactions As Integer = 0
   Private dummyThread As Thread
   Private variableDelegate As enableButtons
   Private Delegate Sub enableButtons()
   Private _User As UserAccount

   'Exits the Application 
   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      dummyThread = New Thread(AddressOf ExitApplication)

      dummyThread.Start()

      btnExit.Enabled = False
      btnContinue.Enabled = False
      btnCreate.Enabled = False
      btnTerminate.Enabled = False
      btnWait.Enabled = False

   End Sub

   'Sets the balance text of the textbox to the balance 
   Private Sub FormClassThread_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      txtBalance.Text = FormatCurrency(totalBalance)
      txtTransaction.Text = FormatCurrency(totalTransactions)
   End Sub

   'To wait for all worker threads to finish
   'Then exit application if the user answers Yes
   Sub ExitApplication()
      ' Thread dummyThread waiting here for all worker threads to finish
      UserAccount.TerminateAllUsers()

      Dim result As Microsoft.VisualBasic.MsgBoxResult
      result = MsgBox("Do you want to exit?", MsgBoxStyle.YesNo)
      If result = MsgBoxResult.Yes Then
         Application.Exit()
      Else
         Me.Invoke(variableDelegate)
      End If
   End Sub

   'Creates a new user account 
   Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
      _User = New UWPCS3340.UserAccount()
      _User.MainForm = Me
      _User.TheTransaction = AddressOf delegateTheTransaction
      _User.TheReport = AddressOf delegateTheReport
      _User.SpinUp()

      'Dim temp As UserAccount.UserState = _User.UserState.Working

      'txtLog.Text &= _User._id & " Start to work" & vbCrLf
      'lstAllUsers.Items.Add(_User._id & " " & temp.ToString)

   End Sub

   'Displays the trans data to the text log
   Private Sub delegateTheTransaction(ByVal ID As String, ByVal Amount As Integer, ByVal Final As Boolean)
      If Final = False Then
         txtLog.Text &= ID & ": " & Amount & vbCrLf
         totalBalance += Amount
         txtBalance.Text = FormatCurrency(totalBalance, 2)
      Else
         txtLog.Text &= ID & ": Total transaction - " & FormatCurrency(Amount, 2) & vbCrLf
         totalTransactions += Amount
         txtTransaction.Text = FormatCurrency(totalTransactions, 2)
      End If

      txtLog.SelectionStart = Len(txtLog.Text) - 1
      txtLog.ScrollToCaret()
   End Sub

   'Displays the trans message to the text log
   Private Sub delegateTheReport(ByVal ID As String, ByVal State As UWPCS3340.UserAccount.UserState)
      Dim index1 As Integer = -1
      Dim num As Integer = lstAllUsers.Items.Count - 1
      Dim index2 As Integer = 0

      While (index2 <= num)
         If lstAllUsers.Items(index2).ToString.Contains(ID) Then
            index1 = index2
            Exit While
         End If

         index2 += 1
      End While


      If (index1 = -1) Then
         lstAllUsers.Items.Add(ID & " " & State.ToString)
         txtLog.Text &= ID & " " & "Start to work" & vbCrLf

         txtLog.SelectionStart = txtLog.TextLength
         txtLog.ScrollToCaret()
      ElseIf State = UserAccount.UserState.Terminated Then
         lstAllUsers.Items.RemoveAt(index1)
      Else
         lstAllUsers.Items(index1) = ID & " " & State.ToString
      End If
   End Sub

   'Makes the worker wait and not perform any work 
   Private Sub btnWait_Click(sender As Object, e As EventArgs) Handles btnWait.Click
      Try
         _User = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex)
         _User.UserWait()
      Catch ex As Exception

      End Try
   End Sub

   'Continues make a worker continue and stop waiting
   Private Sub btnContinue_Click(sender As Object, e As EventArgs) Handles btnContinue.Click
      Try
         _User = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex)
         _User.UserContinue()
      Catch ex As Exception

      End Try
   End Sub

   'Terninates the worker
   Private Sub btnTerminate_Click(sender As Object, e As EventArgs) Handles btnTerminate.Click
      If lstAllUsers.SelectedIndex < 0 Then
         Exit Sub
      End If

      _User = UserAccount.GetUserByIndex(lstAllUsers.SelectedIndex)
      _User.SpinDown()
   End Sub
End Class
