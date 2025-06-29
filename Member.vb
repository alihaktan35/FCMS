Public Class Member
    Private Sub Member_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim item1 As New ListViewItem("Yoga")
        item1.SubItems.Add("John Trainer")
        item1.SubItems.Add("Monday 10:00")
        ListView1.Items.Add(item1)

        Dim item2 As New ListViewItem("Pilates")
        item2.SubItems.Add("Sarah Coach")
        item2.SubItems.Add("Tuesday 14:00")
        ListView1.Items.Add(item2)

        Dim item3 As New ListViewItem("Zumba")
        item3.SubItems.Add("Mike Trainer")
        item3.SubItems.Add("Wednesday 18:00")
        ListView1.Items.Add(item3)

        Dim item4 As New ListViewItem("Spinning")
        item4.SubItems.Add("Anna Coach")
        item4.SubItems.Add("Thursday 12:00")
        ListView1.Items.Add(item4)

        Dim item5 As New ListViewItem("HIIT")
        item5.SubItems.Add("Jake Trainer")
        item5.SubItems.Add("Friday 17:00")
        ListView1.Items.Add(item5)

        Dim item6 As New ListViewItem("CrossFit")
        item6.SubItems.Add("Linda Coach")
        item6.SubItems.Add("Saturday 09:00")
        ListView1.Items.Add(item6)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim selectedItem As ListViewItem = ListView1.SelectedItems(0)
            Dim className As String = selectedItem.Text
            Dim trainer As String = selectedItem.SubItems(1).Text
            Dim time As String = selectedItem.SubItems(2).Text

            lblStatus.Text = "Successfully booked: " & className & " with " & trainer & " on " & time
            lblStatus.ForeColor = Color.Green
        Else
            lblStatus.Text = "Please select a class to book."
            lblStatus.ForeColor = Color.Red
        End If
    End Sub
End Class