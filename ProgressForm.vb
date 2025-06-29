Public Class ProgressForm
    Public MemberName As String
    Public MemberSurname As String
    Private Sub ProgressForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Progress for " & MemberName & " " & MemberSurname

        If MemberName = "Alice" And MemberSurname = "Smith" Then
            Label2.Text = "Attendance: 8/10"
            Label3.Text = "Weight: 65.5kg"
            Label4.Text = "Member Since: 15/01/2024"
            RichTextBox1.Text = "Alice is very consistent and motivated. She's on track with her goals."

        ElseIf MemberName = "Bob" And MemberSurname = "Johnson" Then
            Label2.Text = "Attendance: 5/10"
            Label3.Text = "Weight: 78kg"
            Label4.Text = "Member Since: 02/03/2024"
            RichTextBox1.Text = "Bob needs to improve attendance and focus on diet."

        ElseIf MemberName = "Charlie" And MemberSurname = "Davis" Then
            Label2.Text = "Attendance: 9/10"
            Label3.Text = "Weight: 72kg"
            Label4.Text = "Member Since: 20/02/2024"
            RichTextBox1.Text = "Charlie is doing great. Only one session left to complete."

        Else
            Label2.Text = "Attendance: -"
            Label3.Text = "Weight: -"
            Label4.Text = "Member Since: -"
            RichTextBox1.Text = "No data available for this member."
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub
End Class