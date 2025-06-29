Public Class Trainer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Trainer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item1 As New ListViewItem("Alice")
        item1.SubItems.Add("Smith")
        item1.SubItems.Add("Yoga")
        ListView1.Items.Add(item1)

        Dim item2 As New ListViewItem("Bob")
        item2.SubItems.Add("Johnson")
        item2.SubItems.Add("Pilates")
        ListView1.Items.Add(item2)

        Dim item3 As New ListViewItem("Charlie")
        item3.SubItems.Add("Davis")
        item3.SubItems.Add("Zumba")
        ListView1.Items.Add(item3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim name As String = selectedItem.Text
            Dim surname As String = selectedItem.SubItems(1).Text

            Dim progressForm As New ProgressForm()
            progressForm.MemberName = name
            progressForm.MemberSurname = surname
            progressForm.Show()
        Else
            MsgBox("Please select a member to monitor.", MsgBoxStyle.Exclamation, "No Member Selected")
        End If
    End Sub
End Class