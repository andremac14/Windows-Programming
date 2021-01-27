' Root Namespace UWPCS3340
Public Class Person
    Private _Name As String

    ' Constructor
    Public Sub New()
        _Name = "CS334"
        AllPersons.Add(Me)
    End Sub

    ' Constructor
    Public Sub New(ByVal aname As String)
        _Name = aname
        AllPersons.Add(Me)
    End Sub

    ' Gets or sets the name of a person
    ' Set procedure raises an error when no valid value provided
    Public Property Name() As String
        Get
            Return _Name
        End Get
        Set(ByVal Value As String)
            If Value <> "" Then
                _Name = Value
            Else
                Throw New Exception("Name cannot be an empty string!")
            End If
        End Set
    End Property

    ' Instance data field for individual objects
    Private _totalMiles As Single

    ' Define event
    Public Event Over40Miles(ByVal theName As String, ByVal totalMiles As Single)

    Public ReadOnly Property TotalMiles()
        Get
            Return _totalMiles
        End Get
    End Property

    ' Updates _totalMiles and raises event when condition satisified
    Public Sub WorkOut(ByVal Miles As String)
        If Not IsNumeric(Miles) Or Miles.IndexOf("e", StringComparison.CurrentCultureIgnoreCase) >= 0 Then
            Throw New Exception("Miles must be a number!")
        End If

        If Miles <= 0 Then
            Throw New Exception("Miles must be positive!")
        End If

        _totalMiles += Miles

        ' Should use a constant
        If _totalMiles > 40 Then
            RaiseEvent Over40Miles(_Name, _totalMiles)
        End If
    End Sub

    ' Shared list to store all person objects created
    Private Shared AllPersons As List(Of Person) = New List(Of Person)

    Public Shared ReadOnly Property TotalCount As Integer
        Get
            Return AllPersons.Count
        End Get
    End Property

    Public Shared Function GetPersonByIndex(ByVal index As Integer) As Person
        Return AllPersons(index)
    End Function
End Class
