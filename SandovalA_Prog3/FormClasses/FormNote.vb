Public Class FormNote
   Private WithEvents aPerson As Person


   Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
      'Dim s As String = TextBox1.Text

      'If Not IsNumeric(s) Then
      '   Console.WriteLine("Not a number")
      'ElseIf s.IndexOf("e", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
      '   Console.WriteLine("2e3")
      'Else
      '   Console.WriteLine("a good number")
      'End If

      Dim theName As String = TextBox1.Text.Trim

      If theName = "" Then
         aPerson = New Person()
      Else
         aPerson = New Person(theName)
      End If
   End Sub

   Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
      'aPerson.Name = TextBox1.Text

      aPerson = Person.GetPersonByIndex(TextBox4.Text)

   End Sub

   Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
      Console.WriteLine(aPerson.Name & " has walked " & aPerson.TotalMiles & " miles.")
      TextBox3.Text = Person.TotalCount
   End Sub

   Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
      Try
         aPerson.WorkOut(TextBox2.Text)

      Catch ex As Exception
         Console.WriteLine("Miles must be a number!")

      End Try

   End Sub

   Private Sub aPerson_Over40Miles(theName As String, totalMiles As Single) Handles aPerson.Over40Miles
      MessageBox.Show(theName & " has walked " & totalMiles & " miles.")

   End Sub
End Class