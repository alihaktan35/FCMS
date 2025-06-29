Imports System.Reflection.Emit
Imports System.Windows.Forms

Public Class EditForm
    Public Mode As String
    Public Data() As String
    Public ListRef As ListView
    Private itemRef As ListViewItem

    Private Sub EditForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        itemRef = CType(Me.Tag, ListViewItem)

        If Mode = "User" Then
            Label1.Text = "Card ID:"
            Label2.Text = "Full Name:"
            Label3.Text = "Mem. Until:"
        ElseIf Mode = "Class" Then
            Label1.Text = "Class:"
            Label2.Text = "Trainer:"
            Label3.Text = "Date:"
        End If

        TextBox1.Text = Data(0)
        TextBox2.Text = Data(1)
        TextBox3.Text = Data(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListRef IsNot Nothing AndAlso Me.Tag IsNot Nothing Then
            Dim selectedItem As ListViewItem = CType(Me.Tag, ListViewItem)
            ListRef.Items.Remove(selectedItem)
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListRef IsNot Nothing AndAlso Me.Tag IsNot Nothing Then
            Dim selectedItem As ListViewItem = CType(Me.Tag, ListViewItem)
            selectedItem.Text = TextBox1.Text
            selectedItem.SubItems(1).Text = TextBox2.Text
            selectedItem.SubItems(2).Text = TextBox3.Text
            Me.Close()
        End If
    End Sub
End Class