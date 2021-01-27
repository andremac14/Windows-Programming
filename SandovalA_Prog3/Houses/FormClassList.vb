Imports System.Windows.Forms

Public Class FormClassList
    Private _mainForm As FormClassCreate

    Public WriteOnly Property MainForm As Form
        Set(ByVal value As Form)
            _mainForm = value
        End Set
    End Property

    Private Sub FormClassList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Dim numHouses As Integer = House.TotalCount

        txtCount.Text = numHouses

        For index = 0 To numHouses - 1
            Dim h As House = House.HouseByIndex(index)
            lstHouses.Items.Add(h.ID.PadRight(8) & h.Type.PadRight(10) & FormatCurrency(h.Price).PadLeft(12))

        Next
    End Sub

    Private Sub FormClassList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class