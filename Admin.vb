Public Class Admin
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Application.Exit()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim user1 As New ListViewItem("0001")
        user1.SubItems.Add("Alice Smith")
        user1.SubItems.Add("31/12/2025")
        ListView1.Items.Add(user1)

        Dim user2 As New ListViewItem("0002")
        user2.SubItems.Add("Bob Johnson")
        user2.SubItems.Add("30/11/2025")
        ListView1.Items.Add(user2)

        Dim user3 As New ListViewItem("0003")
        user3.SubItems.Add("Charlie Davis")
        user3.SubItems.Add("15/10/2025")
        ListView1.Items.Add(user3)

        '''''''''''''''''''''''''''''''''''''''''

        Dim item1 As New ListViewItem("Yoga")
        item1.SubItems.Add("John Trainer")
        item1.SubItems.Add("Monday 10:00")
        ListView2.Items.Add(item1)

        Dim item2 As New ListViewItem("Pilates")
        item2.SubItems.Add("Sarah Coach")
        item2.SubItems.Add("Tuesday 14:00")
        ListView2.Items.Add(item2)

        Dim item3 As New ListViewItem("Zumba")
        item3.SubItems.Add("Mike Trainer")
        item3.SubItems.Add("Wednesday 18:00")
        ListView2.Items.Add(item3)

        Dim item4 As New ListViewItem("Spinning")
        item4.SubItems.Add("Anna Coach")
        item4.SubItems.Add("Thursday 12:00")
        ListView2.Items.Add(item4)

        Dim item5 As New ListViewItem("HIIT")
        item5.SubItems.Add("Jake Trainer")
        item5.SubItems.Add("Friday 17:00")
        ListView2.Items.Add(item5)

        Dim item6 As New ListViewItem("CrossFit")
        item6.SubItems.Add("Linda Coach")
        item6.SubItems.Add("Saturday 09:00")
        ListView2.Items.Add(item6)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListView1.SelectedItems.Count > 0 Then
            Dim item = ListView1.SelectedItems(0)
            Dim data = {item.Text, item.SubItems(1).Text, item.SubItems(2).Text}
            Dim f As New EditForm()
            f.Mode = "User"
            f.Data = data
            f.Tag = item ' referans
            f.ListRef = ListView1
            f.Show()
        Else
            MsgBox("Please select a user to edit.", MsgBoxStyle.Exclamation, "Edit User")
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If ListView2.SelectedItems.Count > 0 Then
            Dim item = ListView2.SelectedItems(0)
            Dim data = {item.Text, item.SubItems(1).Text, item.SubItems(2).Text}
            Dim f As New EditForm()
            f.Mode = "Class"
            f.Data = data
            f.Tag = item
            f.ListRef = ListView2
            f.Show()
        Else
            MsgBox("Please select a class to edit.", MsgBoxStyle.Exclamation, "Edit Class")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim newItem As New ListViewItem("0000") ' Card ID
        newItem.SubItems.Add("New") ' Name
        newItem.SubItems.Add("User") ' Surname
        newItem.SubItems.Add("31/12/2025") ' Active Membership
        ListView1.Items.Add(newItem)

        ' Yeni eklenen öğeyi otomatik seç
        newItem.Selected = True

        ' Edit formu otomatik aç
        Button1.PerformClick()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim newItem As New ListViewItem("New Class")
        newItem.SubItems.Add("Trainer Name")
        newItem.SubItems.Add("Date Info")
        ListView2.Items.Add(newItem)

        newItem.Selected = True

        Button4.PerformClick()
    End Sub
End Class